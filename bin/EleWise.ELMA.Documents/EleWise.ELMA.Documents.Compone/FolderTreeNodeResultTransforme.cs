using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Runtime.NH;

namespace EleWise.ELMA.Documents.Components;

internal class FolderTreeNodeResultTransformer : AliasToBeanResultTransformer
{
	private class FolderTreeNodeInternal : FolderTreeNode
	{
		public Guid? PermissionId { get; set; }
	}

	private readonly Action<FolderTreeNode> action;

	private readonly bool isAdmin;

	public FolderTreeNodeResultTransformer()
		: this(null, isAdmin: false)
	{
	}

	public FolderTreeNodeResultTransformer(Action<FolderTreeNode> action, bool isAdmin)
		: base(typeof(FolderTreeNodeInternal))
	{
		this.action = action;
		this.isAdmin = isAdmin;
	}

	public override IList TransformList(IList collection)
	{
		return (from FolderTreeNodeInternal obj in base.TransformList(collection)
			group obj by obj.Id).Select(delegate(IGrouping<long, FolderTreeNodeInternal> g)
		{
			FolderTreeNodeInternal folderTreeNodeInternal = g.First();
			FolderTreeNode folderTreeNode = new FolderTreeNode
			{
				Id = folderTreeNodeInternal.Id,
				Name = folderTreeNodeInternal.Name,
				CreationDate = folderTreeNodeInternal.CreationDate,
				FolderId = folderTreeNodeInternal.FolderId,
				CreationAuthor = folderTreeNodeInternal.CreationAuthor,
				NodeTypeUid = folderTreeNodeInternal.NodeTypeUid,
				ImageUrl = folderTreeNodeInternal.ImageUrl,
				Virtual = folderTreeNodeInternal.Virtual,
				HasChild = folderTreeNodeInternal.HasChild,
				Expanded = folderTreeNodeInternal.Expanded,
				Depth = folderTreeNodeInternal.Depth
			};
			folderTreeNode.Permissions = (isAdmin ? new List<Guid> { PermissionProvider.DocumentFullAccessPermission.Id } : (from v in g
				where v.PermissionId.HasValue
				select v.PermissionId.Value).ToList());
			if (action != null)
			{
				action(folderTreeNode);
			}
			return folderTreeNode;
		}).ToList();
	}
}
