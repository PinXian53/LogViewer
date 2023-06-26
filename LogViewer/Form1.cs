using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace LogViewer
{
    public partial class Form1 : UIForm
    {
        public Form1()
        {
            AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;
            InitializeComponent();
            InitializeDropDownList();
            logoPictureBox.Image = Properties.Resources.icon;
        }

        private const string RawDataColumnName = "458d87d8-e582-4b03-96c5-4fc9f84bd324";
        private const int RawDataColumnIndex = 0;
        private const string ColorColumnName = "51487b22-7643-4207-bf05-8b5937388927";
        private const int ColorColumnIndex = 1;
        private string searchString = null;
        private DataTable dataTable = null;

        private void BindDataGridView(List<ColumnMapping> columnMappingList, JArray jsonArray)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                var tmpDataTable = new DataTable();
                tmpDataTable.Columns.Add(RawDataColumnName, typeof(string));
                tmpDataTable.Columns.Add(ColorColumnName, typeof(Color));

                var searchList = new List<string>();
                foreach (var columnMapping in columnMappingList)
                {
                    if ("SerialNumber" == columnMapping.SpecialColumn)
                    {
                        tmpDataTable.Columns.Add(columnMapping.ColumnName, typeof(long));
                    }
                    else
                    {
                        tmpDataTable.Columns.Add(columnMapping.ColumnName, typeof(string));
                    }


                    if (columnMapping.Searchable)
                    {
                        searchList.Add(columnMapping.ColumnName + " like '%{0}%'");
                    }
                }

                if (searchList.Count > 0)
                {
                    searchString = string.Join(" or ", searchList);
                }

                long serialNumber = 1;
                foreach (var jToken in jsonArray)
                {
                    var row = tmpDataTable.NewRow();
                    row[RawDataColumnIndex] = jToken.ToString();
                    foreach (var columnMapping in columnMappingList)
                    {
                        if ("SerialNumber" == columnMapping.SpecialColumn)
                        {
                            row[columnMapping.ColumnName] = serialNumber;
                        }
                        else
                        {
                            var value = jToken.SelectToken(columnMapping.JsonPath);
                            row[columnMapping.ColumnName] = value;
                            if (columnMapping.IsSeverity)
                            {
                                row[ColorColumnIndex] = GetColor(value?.ToString());
                            }
                        }
                    }

                    tmpDataTable.Rows.Add(row);
                    serialNumber++;
                }

                dataTable = tmpDataTable;
                dataGridView.DataSource = dataTable;
                dataGridView.Columns[RawDataColumnIndex].Visible = false;
                dataGridView.Columns[ColorColumnIndex].Visible = false;
                if (autoResizeSwitch.Active)
                {
                    AutoResize();
                }

                rowCountLabel.Text = (dataGridView.RowCount - 1).ToString("N0");
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private List<ColumnMapping> GetColumnMappingList()
        {
            var text = File.ReadAllText(Path.Combine("config", configComboBox.Text), Encoding.UTF8);
            return JsonConvert.DeserializeObject<List<ColumnMapping>>(text);
        }


        private void dataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            logTextBox.Text = dataGridView.Rows[e.RowIndex].Cells[RawDataColumnIndex].Value.ToString();
        }

        private void dataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            var value = dataGridView.Rows[e.RowIndex].Cells[ColorColumnIndex].Value;
            if (value is Color color)
            {
                dataGridView.Rows[e.RowIndex].DefaultCellStyle.ForeColor = color;
            }
        }

        private Color GetColor(string severity)
        {
            if (severity == null)
            {
                return Color.Black;
            }

            if (string.Equals("error", severity, StringComparison.CurrentCultureIgnoreCase))
            {
                return Color.Red;
            }

            if (string.Equals("warn", severity, StringComparison.CurrentCultureIgnoreCase))
            {
                return Color.DarkOrange;
            }

            return Color.Black;
        }

        private void chooseLogButton_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.Filter = "json|*.json|log|*.log|txt|*.txt";
                var result = dialog.ShowDialog();

                if (result != DialogResult.OK || string.IsNullOrWhiteSpace(dialog.FileName))
                {
                    return;
                }

                logPathLable.Text = dialog.FileName;
            }
        }

        private void InitializeDropDownList()
        {
            var files = Directory.GetFiles("config");
            foreach (var file in files)
            {
                if (file.EndsWith(".json"))
                {
                    configComboBox.Items.Add(new FileInfo(file).Name);
                }
            }

            configComboBox.SelectedIndex = 0;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(logPathLable.Text))
            {
                throw new Exception("please choose log file");
            }

            var text = File.ReadAllText(logPathLable.Text, Encoding.UTF8);
            JArray jsonArray;
            try
            {
                jsonArray = JArray.Parse(text);
            }
            catch (Exception)
            {
                throw new Exception("is not json array");
            }

            var columnMappingList = GetColumnMappingList();
            BindDataGridView(columnMappingList, jsonArray);
        }

        private Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            string dllName = args.Name.Contains(",")
                ? args.Name.Substring(0, args.Name.IndexOf(','))
                : args.Name.Replace(".dll", "");
            dllName = dllName.Replace(".", "_");
            if (dllName.EndsWith("_resources")) return null;
            System.Resources.ResourceManager rm =
                new System.Resources.ResourceManager(GetType().Namespace + ".Properties.Resources",
                    Assembly.GetExecutingAssembly());
            byte[] bytes = (byte[])rm.GetObject(dllName);
            return Assembly.Load(bytes);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (dataTable == null)
            {
                return;
            }

            try
            {
                Cursor = Cursors.WaitCursor;
                var dataView = dataTable.DefaultView;
                if (string.IsNullOrWhiteSpace(searchTextBox.Text))
                {
                    dataView.RowFilter = null;
                    if (autoResizeSwitch.Active)
                    {
                        AutoResize();
                    }
                    rowCountLabel.Text = (dataGridView.RowCount - 1).ToString("N0");
                    return;
                }

                if (syntaxSwitch.Active)
                {
                    dataView.RowFilter = searchTextBox.Text;
                }
                else if (string.IsNullOrWhiteSpace(searchString))
                {
                    dataView.RowFilter = null;
                }
                else
                {
                    dataView.RowFilter = string.Format(searchString, searchTextBox.Text.Trim());
                }

                if (autoResizeSwitch.Active)
                {
                    AutoResize();
                }
                rowCountLabel.Text = (dataGridView.RowCount - 1).ToString("N0");
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void autoResizeSwitch_ValueChanged(object sender, bool value)
        {
            if (autoResizeSwitch.Active)
            {
                try
                {
                    Cursor = Cursors.WaitCursor;
                    AutoResize();
                }
                finally
                {
                    Cursor = Cursors.Default;
                }
            }
        }

        private void AutoResize()
        {
            dataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView.AutoResizeColumns();
            dataGridView.AutoResizeRows();
        }
    }
}