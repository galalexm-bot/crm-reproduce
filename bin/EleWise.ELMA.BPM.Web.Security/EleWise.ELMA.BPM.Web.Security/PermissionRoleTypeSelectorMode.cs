using System;
using System.Collections.Generic;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Web.Mvc.Models.Boxes;
using EleWise.ELMA.Web.Mvc.Models.Trees;

namespace EleWise.ELMA.BPM.Web.Security.Models;

public class PermissionRoleTypeSelectorModel
{
	public string Title { get; set; }

	public PermissionRoleType[] TypeRoles { get; set; }

	public PermissionRoleType SelectedTypeRole { get; set; }

	public bool CreatePopup { get; set; }

	public string ObjectId { get; set; }

	public string Action { get; set; }

	public string Controller { get; set; }

	public string Area { get; set; }

	public string PopupId { get; set; }

	public string Callback { get; set; }

	public string SubmitScript { get; set; }

	public dynamic Data { get; set; }

	public TreeModel OrganizationTreeModel { get; set; }

	public TreeModel GroupsTreeModel { get; set; }

	public List<ExtTreeModel> ExtGroupsTreeModel { get; set; }

	public AutocompleteComboBox UserModel { get; set; }

	public IMetadata EntityMetadata { get; set; }

	public AutocompleteComboBox PropertyModel { get; set; }

	public bool CheckUserReplacement { get; set; }

	public ISet<EleWise.ELMA.Security.Models.IUser> Users { get; set; }

	public EleWise.ELMA.Security.Models.IUser User { get; set; }

	public Guid UserEntityFilterProvider { get; set; }

	public string UserEntityFilterData { get; set; }
}
