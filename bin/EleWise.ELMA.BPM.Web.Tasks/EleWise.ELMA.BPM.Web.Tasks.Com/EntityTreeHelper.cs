using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Components;
using EleWise.ELMA.Tasks.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Models.Trees;

namespace EleWise.ELMA.BPM.Web.Tasks.Components;

public class EntityTreeHelper
{
	public static List<TreeMenuNode> BuildTree(IEnumerable<Guid> objectTypeUids, TreeState treeState, bool enabled, Func<ClassMetadata, string> nameFormatter = null, Func<ClassMetadata, string> onClick = null)
	{
		List<TreeMenuNode> list = new List<TreeMenuNode>();
		BuildTree(MetadataTreeHelper.BuildTree(objectTypeUids.Select(GetMetadata)), list, treeState, enabled, nameFormatter, onClick);
		return list;
	}

	private static void BuildTree(MetadataTreeHelper.GroupNode parent, ICollection<TreeMenuNode> nodes, TreeState treeState, bool enabled, Func<ClassMetadata, string> nameFormatter, Func<ClassMetadata, string> onClick)
	{
		foreach (MetadataTreeHelper.GroupNode groupNode2 in parent.GroupNodes)
		{
			string nodeId = "group_" + ((groupNode2.Group != null) ? groupNode2.Group.Id.ToString() : groupNode2.Namespace);
			MetadataTreeHelper.GroupNode groupNode = groupNode2;
			TreeMenuNode treeMenuNode2 = null;
			foreach (TreeMenuNode item in nodes.Where((TreeMenuNode treeMenuNode) => nodeId == treeMenuNode.id))
			{
				groupNode = null;
				treeMenuNode2 = item;
			}
			if (groupNode != null)
			{
				treeMenuNode2 = new TreeMenuNode
				{
					text = SR.T(groupNode2.Name),
					expanded = (nodeId != null && treeState != null && treeState[nodeId]),
					id = nodeId,
					icon = "#dict_list.svg",
					checkable = false
				};
				nodes.Add(treeMenuNode2);
			}
			BuildTree(groupNode2, treeMenuNode2.children, treeState, enabled, nameFormatter, onClick);
		}
		foreach (ClassMetadata item2 in parent.MetadataNodes.Select((MetadataTreeHelper.MetadataNode n) => n.Metadata).OfType<ClassMetadata>().Where(delegate(ClassMetadata c)
		{
			IWorkLogExtension workLogExtension = WorkLogExtensionHelper.FindExtensionByObjectUid(c.Uid, enabled: true);
			return c is IEntityMetadata && ((enabled && workLogExtension != null) || (!enabled && workLogExtension == null));
		}))
		{
			TreeMenuNode treeMenuNode3 = new TreeMenuNode
			{
				text = ((nameFormatter != null) ? nameFormatter(item2) : item2.DisplayName),
				expanded = (treeState?[item2.Uid.ToString()] ?? false),
				id = item2.Uid.ToString(),
				icon = EntityImageUrl(item2),
				isHtml = true
			};
			if (onClick != null)
			{
				treeMenuNode3.onclick = onClick(item2);
			}
			nodes.Add(treeMenuNode3);
		}
	}

	private static ClassMetadata GetMetadata(Guid uid)
	{
		if (!(uid != Guid.Empty))
		{
			return null;
		}
		return (ClassMetadata)MetadataLoader.LoadMetadata(uid);
	}

	private static string EntityImageUrl(NamedMetadata metadata)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		string image = GetImage(metadata);
		UrlHelper url = new UrlHelper(HttpContextAccessor.CurrentContext.Request.RequestContext);
		string text = url.Image(image);
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		return url.Image("#dictionary.svg");
	}

	private static string GetImage(NamedMetadata metadata)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		if (metadata != null && metadata.Images != null && metadata.Images.Count > 0)
		{
			return new UrlHelper(HttpContextAccessor.CurrentContext.Request.RequestContext).Action("Object", "Images", (object)new
			{
				area = "EleWise.ELMA.SDK.Web",
				id = metadata.Uid
			});
		}
		return null;
	}
}
