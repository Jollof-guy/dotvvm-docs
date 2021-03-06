using System.Collections.Generic;

namespace DotvvmWeb.Views.Docs.Controls.businesspack.TreeView.sample5
{
    public class TreeItem
    {
        public string Name { get; set; }
        public bool HasItems => Items?.Count > 0;
        public List<TreeItem> Items { get; set; } = new List<TreeItem>();
    }
}