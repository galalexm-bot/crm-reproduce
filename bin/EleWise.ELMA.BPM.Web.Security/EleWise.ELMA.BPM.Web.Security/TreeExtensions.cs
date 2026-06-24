using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Web.Mvc.Models.Trees;

namespace EleWise.ELMA.BPM.Web.Security.Extensions;

public static class TreeExtensions
{
	private static bool FilterTreeNode(TreeMenuNode node, Func<TreeMenuNode, bool> filter, bool keepChildNodes)
	{
		bool flag = filter(node);
		if (keepChildNodes && flag)
		{
			node.expanded = false;
			return true;
		}
		node.children = node.children.FilterTreeNodes(filter, keepChildNodes);
		node.expanded = node.children.Any() || flag;
		return node.expanded;
	}

	public static List<TreeMenuNode> FilterTreeNodes(this List<TreeMenuNode> tree, Func<TreeMenuNode, bool> filter, bool keepChildNodes)
	{
		if (tree == null || tree.Count <= 0 || filter == null)
		{
			return tree;
		}
		return tree.Where((TreeMenuNode node) => FilterTreeNode(node, filter, keepChildNodes)).ToList();
	}

	public static List<TreeMenuNode> FilterTreeNodes(this List<TreeMenuNode> tree, string filterText, Func<TreeMenuNode, string, bool> additionalCheck = null, bool keepChildNodes = false)
	{
		if (filterText.IsNullOrEmpty())
		{
			return tree;
		}
		filterText = filterText.ToLower();
		Func<TreeMenuNode, bool> filterNode = (TreeMenuNode node) => !node.text.IsNullOrEmpty() && node.text.ToLower().Contains(filterText);
		return tree.FilterTreeNodes((additionalCheck == null) ? filterNode : ((Func<TreeMenuNode, bool>)((TreeMenuNode node) => filterNode(node) || additionalCheck(node, filterText))), keepChildNodes);
	}

	public static TreeState LoadState(this TreeModel model)
	{
		if (model != null)
		{
			return TreePersonalizationAdministration.LoadState(model.Id);
		}
		return null;
	}

	public static TreeState SaveState(this TreeModel model, TreeState state)
	{
		if (model == null || state == null)
		{
			return null;
		}
		state.Id = model.Id;
		TreePersonalizationAdministration.SaveState(state.Id, state);
		return state;
	}
}
