
namespace LogViewer
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chooseLogButton = new Sunny.UI.UIButton();
            this.configComboBox = new Sunny.UI.UIComboBox();
            this.logTextBox = new Sunny.UI.UIRichTextBox();
            this.dataGridView = new Sunny.UI.UIDataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.startButton = new Sunny.UI.UIButton();
            this.logPathLable = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.searchTextBox = new Sunny.UI.UITextBox();
            this.syntaxSwitch = new Sunny.UI.UISwitch();
            this.label5 = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.searchButton = new Sunny.UI.UISymbolButton();
            this.label6 = new System.Windows.Forms.Label();
            this.autoResizeSwitch = new Sunny.UI.UISwitch();
            this.label7 = new System.Windows.Forms.Label();
            this.rowCountLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // chooseLogButton
            // 
            this.chooseLogButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chooseLogButton.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.chooseLogButton.Location = new System.Drawing.Point(401, 49);
            this.chooseLogButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.chooseLogButton.Name = "chooseLogButton";
            this.chooseLogButton.Size = new System.Drawing.Size(100, 30);
            this.chooseLogButton.Style = Sunny.UI.UIStyle.Custom;
            this.chooseLogButton.TabIndex = 0;
            this.chooseLogButton.Text = "choose";
            this.chooseLogButton.Click += new System.EventHandler(this.chooseLogButton_Click);
            // 
            // configComboBox
            // 
            this.configComboBox.DataSource = null;
            this.configComboBox.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.configComboBox.FillColor = System.Drawing.Color.White;
            this.configComboBox.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.configComboBox.Location = new System.Drawing.Point(401, 87);
            this.configComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.configComboBox.MinimumSize = new System.Drawing.Size(63, 0);
            this.configComboBox.Name = "configComboBox";
            this.configComboBox.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.configComboBox.Size = new System.Drawing.Size(228, 30);
            this.configComboBox.Style = Sunny.UI.UIStyle.Custom;
            this.configComboBox.TabIndex = 1;
            this.configComboBox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.configComboBox.Watermark = "";
            // 
            // logTextBox
            // 
            this.logTextBox.FillColor = System.Drawing.Color.White;
            this.logTextBox.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.logTextBox.Location = new System.Drawing.Point(34, 620);
            this.logTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logTextBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.Padding = new System.Windows.Forms.Padding(2);
            this.logTextBox.ShowText = false;
            this.logTextBox.Size = new System.Drawing.Size(1332, 256);
            this.logTextBox.Style = Sunny.UI.UIStyle.Custom;
            this.logTextBox.TabIndex = 4;
            this.logTextBox.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dataGridView.Location = new System.Drawing.Point(34, 169);
            this.dataGridView.Name = "dataGridView";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.ScrollBarRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dataGridView.SelectedIndex = -1;
            this.dataGridView.Size = new System.Drawing.Size(1332, 422);
            this.dataGridView.StripeOddColor = System.Drawing.Color.White;
            this.dataGridView.Style = Sunny.UI.UIStyle.Custom;
            this.dataGridView.TabIndex = 6;
            this.dataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseClick);
            this.dataGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView_CellPainting);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(207, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "3. Start";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(207, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "2. Choose config";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(207, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "1. Choose log";
            // 
            // startButton
            // 
            this.startButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startButton.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.startButton.Location = new System.Drawing.Point(401, 125);
            this.startButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(100, 30);
            this.startButton.Style = Sunny.UI.UIStyle.Custom;
            this.startButton.TabIndex = 12;
            this.startButton.Text = "start";
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // logPathLable
            // 
            this.logPathLable.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.logPathLable.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.logPathLable.Location = new System.Drawing.Point(554, 52);
            this.logPathLable.Name = "logPathLable";
            this.logPathLable.Size = new System.Drawing.Size(777, 23);
            this.logPathLable.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(853, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Search";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchTextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.searchTextBox.Location = new System.Drawing.Point(916, 125);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchTextBox.MinimumSize = new System.Drawing.Size(1, 16);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Padding = new System.Windows.Forms.Padding(5);
            this.searchTextBox.ShowText = false;
            this.searchTextBox.Size = new System.Drawing.Size(407, 29);
            this.searchTextBox.Style = Sunny.UI.UIStyle.Custom;
            this.searchTextBox.TabIndex = 15;
            this.searchTextBox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchTextBox.Watermark = "";
            // 
            // syntaxSwitch
            // 
            this.syntaxSwitch.ActiveText = "On";
            this.syntaxSwitch.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.syntaxSwitch.InActiveText = "Off";
            this.syntaxSwitch.Location = new System.Drawing.Point(1012, 85);
            this.syntaxSwitch.MinimumSize = new System.Drawing.Size(1, 1);
            this.syntaxSwitch.Name = "syntaxSwitch";
            this.syntaxSwitch.Size = new System.Drawing.Size(75, 26);
            this.syntaxSwitch.Style = Sunny.UI.UIStyle.Custom;
            this.syntaxSwitch.TabIndex = 16;
            this.syntaxSwitch.Text = "uiSwitch1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(853, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "Use RowFilter syntax";
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Location = new System.Drawing.Point(25, 48);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(131, 115);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 5;
            this.logoPictureBox.TabStop = false;
            // 
            // searchButton
            // 
            this.searchButton.CircleRectWidth = 2;
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.FillColor = System.Drawing.Color.White;
            this.searchButton.FillColor2 = System.Drawing.Color.Silver;
            this.searchButton.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.searchButton.IsCircle = true;
            this.searchButton.Location = new System.Drawing.Point(1331, 114);
            this.searchButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.searchButton.Name = "searchButton";
            this.searchButton.RectColor = System.Drawing.Color.Silver;
            this.searchButton.Size = new System.Drawing.Size(35, 49);
            this.searchButton.Style = Sunny.UI.UIStyle.Custom;
            this.searchButton.StyleCustomMode = true;
            this.searchButton.Symbol = 61442;
            this.searchButton.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.searchButton.SymbolHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.searchButton.SymbolPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.searchButton.SymbolSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.searchButton.TabIndex = 86;
            this.searchButton.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(1156, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 19);
            this.label6.TabIndex = 87;
            this.label6.Text = "Auto resize";
            // 
            // autoResizeSwitch
            // 
            this.autoResizeSwitch.ActiveText = "On";
            this.autoResizeSwitch.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.autoResizeSwitch.InActiveText = "Off";
            this.autoResizeSwitch.Location = new System.Drawing.Point(1248, 85);
            this.autoResizeSwitch.MinimumSize = new System.Drawing.Size(1, 1);
            this.autoResizeSwitch.Name = "autoResizeSwitch";
            this.autoResizeSwitch.Size = new System.Drawing.Size(75, 26);
            this.autoResizeSwitch.Style = Sunny.UI.UIStyle.Custom;
            this.autoResizeSwitch.TabIndex = 88;
            this.autoResizeSwitch.Text = "uiSwitch1";
            this.autoResizeSwitch.ValueChanged += new Sunny.UI.UISwitch.OnValueChanged(this.autoResizeSwitch_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(34, 596);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 19);
            this.label7.TabIndex = 89;
            this.label7.Text = "rows : ";
            // 
            // rowCountLabel
            // 
            this.rowCountLabel.AutoSize = true;
            this.rowCountLabel.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rowCountLabel.Location = new System.Drawing.Point(94, 596);
            this.rowCountLabel.Name = "rowCountLabel";
            this.rowCountLabel.Size = new System.Drawing.Size(0, 19);
            this.rowCountLabel.TabIndex = 90;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1401, 896);
            this.Controls.Add(this.rowCountLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.autoResizeSwitch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.syntaxSwitch);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.logPathLable);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.configComboBox);
            this.Controls.Add(this.chooseLogButton);
            this.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "Form1";
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "Json Log Viewer v1.2.1";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label rowCountLabel;

        private System.Windows.Forms.Label label7;

        private Sunny.UI.UISwitch autoResizeSwitch;

        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.Label label4;

        #endregion

        private Sunny.UI.UIButton chooseLogButton;
        private Sunny.UI.UIComboBox configComboBox;
        private Sunny.UI.UIRichTextBox logTextBox;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private Sunny.UI.UIDataGridView dataGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Sunny.UI.UIButton startButton;
        private System.Windows.Forms.Label logPathLable;
        private Sunny.UI.UITextBox searchTextBox;
        private Sunny.UI.UISwitch syntaxSwitch;
        private System.Windows.Forms.Label label5;
        private Sunny.UI.UISymbolButton searchButton;
    }
}

