// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using HierarchicalMenu.Domain;
using HierarchicalMenu.Service;

List<Tree> list = new();
list.Add(new Tree(1, "Administration", 0));
list.Add(new Tree(2, "User Admin", 1));
list.Add(new Tree(3, "Create User", 2));
list.Add(new Tree(4, "Edit User", 2));
list.Add(new Tree(5, "Product Admin", 1));
list.Add(new Tree(6, "All Products", 5));
list.Add(new Tree(7, "My Products", 6));
list.Add(new Tree(8, "Create Products", 5));
list.Add(new Tree(9, "Order Admin", 1));
list.Add(new Tree(10, "Order Reports", 9));
list.Add(new Tree(11, "Audit Reports", 10));
list.Add(new Tree(12, "Updated Orders", 11));
list.Add(new Tree(13, "Created Orders", 11));
list.Add(new Tree(14, "Create Order", 9));
list.Add(new Tree(15, "Reports", 1));
list.Add(new Tree(16, "Win Tech Report", 15));
list.Add(new Tree(17, "Microsoft Report", 15));

List<Tree> tree = TreeCreation.Create(list, 0);
var printer = new TreePrinter(tree, Console.WriteLine);

printer.Print();