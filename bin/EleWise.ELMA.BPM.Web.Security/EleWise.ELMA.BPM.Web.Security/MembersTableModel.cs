using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.BPM.Web.Security.Models;

public class MembersTableModel
{
	public string TypeName { get; set; }

	public List<PermissionModel> Members { get; set; }

	public string EntityName { get; set; }

	public string OnChangeScript { get; set; }

	public long EntityId { get; set; }

	public bool Editable { get; set; }

	public MembersTableModel()
	{
		Members = new List<PermissionModel>();
	}

	public MembersTableModel(string typeName, string entityName, long entityId, bool editable, IEnumerable<IUserGroup> userGroups, IEnumerable<IOrganizationItem> organizationItems, IEnumerable<IUser> users, string onChangeScript = null)
	{
		Members = new List<PermissionModel>();
		if (userGroups != null && userGroups.Count() > 0)
		{
			Members.AddRange(userGroups.Select((IUserGroup o) => new PermissionModel
			{
				Id = o.Id,
				Text = o.Name,
				ObjectType = PermissionObjectType.Group,
				AccessType = PermissionAccessType.Full
			}).ToList());
		}
		if (organizationItems != null && organizationItems.Count() > 0)
		{
			Members.AddRange(organizationItems.Select((IOrganizationItem o) => new PermissionModel
			{
				Id = o.Id,
				Text = o.Name,
				ObjectType = PermissionObjectType.Organization,
				AccessType = PermissionAccessType.Full
			}).ToList());
		}
		if (users != null && users.Count() > 0)
		{
			Members.AddRange(users.Select((IUser o) => new PermissionModel
			{
				Id = o.Id,
				Text = o.GetFullName(),
				ObjectType = PermissionObjectType.User,
				AccessType = PermissionAccessType.Full
			}).ToList());
		}
		TypeName = typeName;
		EntityName = entityName;
		EntityId = entityId;
		Editable = editable;
		OnChangeScript = onChangeScript;
	}
}
