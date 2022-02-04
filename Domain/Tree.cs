using System.Collections.Generic;

namespace HierarchicalMenu.Domain
{
    public class Tree
    {
        private readonly int _id;
        private readonly string _name;
        private readonly int _parentId;

        private List<Tree> _children = default!;

        public Tree(int id, string name, int parentId)
        {
            _id = id;
            _name = name;
            _parentId = parentId;
        }

        public int Id => _id;
        public string Name => _name;
        public int ParentId => _parentId;

        public List<Tree> Children {
            get => _children;
            set => _children = value;
        }
    }
}
