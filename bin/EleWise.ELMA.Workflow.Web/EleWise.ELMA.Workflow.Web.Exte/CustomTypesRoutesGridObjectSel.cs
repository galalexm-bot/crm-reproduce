using System;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models.ActionItems.Menu;
using EleWise.ELMA.Web.Mvc.Models.Buttons;
using EleWise.ELMA.Web.Mvc.Models.Grids;

namespace EleWise.ELMA.Workflow.Web.Extensions;

[Component]
internal sealed class CustomTypesRoutesGridObjectSelectorExtended : IGridObjectSelectorExtensionExtended, IGridObjectSelectorExtension
{
	public void EditGrid(DynamicGrid grid, Guid typeUid)
	{
	}

	public void EditGrid(DynamicGrid grid, Guid typeUid, HtmlHelper html)
	{
		if (CanAdd(typeUid))
		{
			GridColumn gridColumn = new GridColumn
			{
				Sortable = false,
				Width = (grid.Resizeable ? "24px" : "1%"),
				Order = -2147483647,
				Header = CheckedColumnHeaderTemplate(html),
				UniqueName = "checkedColumn" + typeUid,
				ValueType = typeof(long),
				Resizable = false
			};
			Func<object, string> func2 = (Func<object, string>)(gridColumn.Template = (Func<object, string>)((dynamic entity) => CheckedColumnTemplate(entity, html)));
			grid.Columns.Add(gridColumn);
		}
	}

	private bool CanAdd(Guid typeUid)
	{
		return false;
	}

	private string CheckedColumnTemplate(IEntity entity, HtmlHelper html)
	{
		if (entity != null)
		{
			return html.ModernCheckBox(renderUncheckedInput: true).Name("objectid").Value(entity.GetId())
				.ToString();
		}
		return string.Empty;
	}

	private string CheckedColumnHeaderTemplate(HtmlHelper html)
	{
		return ((object)html.SmartCheckbox(new SmartCheckBox
		{
			Menu = new ActionMenu("checkedobject_menu"),
			Id = "ObjectSelectCheckbox",
			DefaultScript = "ToggleCheckbox(this)"
		})).ToString();
	}
}
