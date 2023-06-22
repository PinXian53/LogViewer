
namespace LogViewer
{
    class ColumnMapping
    {
        public string ColumnName { set; get; }
        public string JsonPath { set; get; }
        public bool IsSeverity { set; get; } = false;
        public bool Searchable { set; get; } = false;
        public string SpecialColumn { set; get; }
    }
}
