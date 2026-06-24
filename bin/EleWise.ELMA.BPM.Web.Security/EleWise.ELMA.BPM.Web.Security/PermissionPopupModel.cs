using System;
using System.Collections.Generic;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Web.Mvc.Models.Boxes;
using EleWise.ELMA.Web.Mvc.Models.Trees;

namespace EleWise.ELMA.BPM.Web.Security.Models;

[Obsolete("следует использовать PermissionRoleTypeSelectorModel")]
public class PermissionPopupModel
{
	public string Title { get; set; }

	public PermissionObjectType[] ObjectTypes { get; set; }

	public PermissionObjectType SelectObjectType { get; set; }

	public bool CreatePopup { get; set; }

	public long ObjectId { get; set; }

	public string Action { get; set; }

	public string Controller { get; set; }

	public string Area { get; set; }

	public string PopupId { get; set; }

	public string Callback { get; set; }

	public string SubmitScript { get; set; }

	public TreeModel OrganizationTreeModel { get; set; }

	public TreeModel GroupsTreeModel { get; set; }

	public List<ExtTreeModel> ExtGroupsTreeModel { get; set; }

	public AutocompleteComboBox UserModel { get; set; }
}
