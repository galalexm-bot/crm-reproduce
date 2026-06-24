using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Workflow.Models;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Workflow.Processes.Web.Models;

public class ProcessGeneralInfo
{
	public IProcessHeader Header { get; set; }

	public IUser OwnerUser { get; set; }

	public IOrganizationItem OwnerOrganizationItem { get; set; }

	public IUserGroup OwnerUserGroup { get; set; }

	public ISet<IUser> CuratorUsers { get; set; }

	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "e502f586-afd4-4f55-bedb-f71028ffd302")]
	[EntityProperty]
	public ISet<IOrganizationItem> CuratorOrganizationItems { get; set; }

	public ISet<IUserGroup> CuratorUserGroups { get; set; }

	public ProcessGeneralInfo()
	{
		CuratorUsers = (ISet<IUser>)(object)new HashedSet<IUser>();
		CuratorOrganizationItems = (ISet<IOrganizationItem>)(object)new HashedSet<IOrganizationItem>();
		CuratorUserGroups = (ISet<IUserGroup>)(object)new HashedSet<IUserGroup>();
	}
}
