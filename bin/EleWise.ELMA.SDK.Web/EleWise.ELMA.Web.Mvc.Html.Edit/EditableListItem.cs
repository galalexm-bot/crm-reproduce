using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Security;

namespace EleWise.ELMA.Web.Mvc.Html.EditableList;

public class EditableListItem : ListItem
{
	public string Data { get; set; }

	public bool HideDeleteIcon { get; set; }

	public bool HideDeleteIconDrawBlankCell { get; set; }

	public bool Disable { get; set; }

	public PermissionRoleType PermissionRoleType { get; set; }

	public IEntity PermissionRole { get; set; }
}
