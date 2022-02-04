using System;
using System.Collections.Generic;
using System.Linq;
using HierarchicalMenu.Domain;

namespace HierarchicalMenu.Service
{
    public static class TreeCreation
    {

        public static List<Tree> Create(List<Tree> treeCollection, int parentId)
        {
            EnsureTreeCollectionIsValid(treeCollection, parentId);

            List<Tree> result = new();

            foreach (Tree tree in treeCollection)
            {
                if (tree.ParentId == parentId)
                {
                    result.Add(tree);
                    tree.Children = Create(treeCollection, tree.Id);
                }
            }

            return result;
        }

        private static void EnsureTreeCollectionIsValid(List<Tree> treeCollection, int parentId)
        {
            if (treeCollection == null || !treeCollection.Any() || parentId < 0)
            {
                throw new Exception("The tree collection is invalid.");
            }

        }
    }
}
