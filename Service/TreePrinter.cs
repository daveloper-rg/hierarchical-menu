using System;
using System.Collections.Generic;
using System.Linq;
using HierarchicalMenu.Domain;

namespace HierarchicalMenu.Service
{
    public class TreePrinter
    {
        private readonly IEnumerable<Tree> _treeCollection;
        private readonly Action<string> _printer;

        public TreePrinter(IEnumerable<Tree> treeCollection, Action<string> printer)
        {
            _treeCollection = treeCollection;
            _printer = printer;
        }

        public void Print()
        {
            if (_treeCollection.Any())
            {
                PrintData(_treeCollection.First(), "");
            }
        }

        private void PrintData(Tree tree, string indent)
        {
            _printer(String.Format("{0}{1}", indent, $"- {tree.Name}"));
            indent += "   ";

            if (tree.Children.Any())
            {
                foreach (var child in tree.Children)
                {
                    PrintData(child, indent);
                }
            }
        }

    }
}
