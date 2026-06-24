using System;
using System.Collections.Generic;
using System.Linq;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Web.Mvc.Models.Trees;

[Serializable]
public class TreeState
{
	public string Id { get; set; }

	public List<TreeNodeState> Nodes { get; set; }

	public bool this[string id]
	{
		get
		{
			return Nodes.FirstOrDefault((TreeNodeState n) => n != null && n.Id != null && n.Id.Equals(id, StringComparison.OrdinalIgnoreCase))?.Expanded ?? false;
		}
		set
		{
			TreeNodeState treeNodeState = Nodes.FirstOrDefault((TreeNodeState n) => n != null && n.Id != null && n.Id.Equals(id, StringComparison.OrdinalIgnoreCase));
			if (treeNodeState == null)
			{
				treeNodeState = new TreeNodeState
				{
					Id = id
				};
				Nodes.Add(treeNodeState);
			}
			treeNodeState.Expanded = value;
		}
	}

	public long[] ExpandedNodeIds
	{
		get
		{
			HashedSet<long> val = new HashedSet<long>();
			foreach (TreeNodeState node in Nodes)
			{
				if (node.Expanded && int.TryParse(node.Id, out var result))
				{
					((Set<long>)(object)val).Add((long)result);
				}
			}
			return ((IEnumerable<long>)val).ToArray();
		}
	}

	public TreeState()
	{
		Nodes = new List<TreeNodeState>();
	}

	public TreeState(IEnumerable<long> expandedNodesId)
		: this()
	{
		Nodes.AddRange(expandedNodesId.Select((long id) => new TreeNodeState
		{
			Id = id.ToString(),
			Expanded = true
		}));
	}
}
