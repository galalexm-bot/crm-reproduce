using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Documents.Models;

[Serializable]
public class FolderTreeNode
{
	public long Id { get; set; }

	public string Name { get; set; }

	public DateTime? CreationDate { get; set; }

	public virtual long? FolderId { get; set; }

	public int FolderType { get; set; }

	public long CreationAuthor { get; set; }

	public Guid NodeTypeUid { get; set; }

	public string ImageUrl { get; set; }

	public bool Virtual { get; set; }

	public bool Expanded { get; set; }

	public bool HasChild { get; set; }

	public List<Guid> Permissions { get; set; }

	internal long Depth { get; set; }

	public FolderTreeNode()
	{
		Permissions = new List<Guid>();
	}

	public bool HasPermission(Guid permissionId)
	{
		if (!Permissions.Contains(PermissionProvider.DocumentFullAccessPermission.Id))
		{
			return Permissions.Contains(permissionId);
		}
		return true;
	}
}
