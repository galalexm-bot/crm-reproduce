using System;
using System.Collections.Generic;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Web.Mvc.Html.EditableList;

namespace EleWise.ELMA.Security.Web.Controllers.Models;

public class ImportUserGridModel
{
	public Guid AuthProviderGuid { get; set; }

	public List<ImportUserModel> Data { get; set; }

	public EditableListModel Groups { get; set; }

	public ImportUserGridModel()
	{
		AuthProviderGuid = Guid.Empty;
		Data = new List<ImportUserModel>();
		Groups = new EditableListModel();
		Groups.Items = InterfaceActivator.Create<IEnumerable<EditableListItem>>();
	}
}
