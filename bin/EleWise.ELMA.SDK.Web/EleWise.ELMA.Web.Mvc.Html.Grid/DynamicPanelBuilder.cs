using System;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.Routing;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Web.Mvc.Models.Grids;

namespace EleWise.ELMA.Web.Mvc.Html.Grids;

public class DynamicPanelBuilder<T> : GridBuilder<T> where T : class
{
	protected string dynamicContentId;

	protected DynamicGrid dynamicGrid;

	private readonly ClassMetadata _metadata;

	public DynamicPanelBuilder(HtmlHelper html, IGridData<T> gridData)
		: base(html, gridData)
	{
	}

	public DynamicPanelBuilder(HtmlHelper html, string dynamicContentId, IGridData<T> gridData)
		: this(html, "", dynamicContentId, gridData)
	{
	}

	public DynamicPanelBuilder(HtmlHelper html, string uniqueName, string dynamicContentId, IGridData<T> gridData)
		: base(html, gridData)
	{
		if (string.IsNullOrEmpty(uniqueName))
		{
			uniqueName = GridHelper.GetGridId(((ControllerContext)html.get_ViewContext()).get_RouteData());
		}
		this.dynamicContentId = dynamicContentId;
		grid = (dynamicGrid = new DynamicGrid(uniqueName, dynamicContentId, gridData, typeof(T)));
		_metadata = (ClassMetadata)MetadataLoader.LoadMetadata(typeof(T));
	}

	public DynamicPanelBuilder<T> Columns(Action<DynamicColumnsBuilder<T>> columnsBuilder)
	{
		DynamicColumnsBuilder<T> obj = new DynamicColumnsBuilder<T>(html, dynamicGrid, null, _metadata);
		columnsBuilder(obj);
		return this;
	}

	public DynamicPanelBuilder<T> DefaultColumns(bool childs = false)
	{
		new DynamicColumnsBuilder<T>(html, dynamicGrid, null, _metadata).DefaultColumns(childs);
		return this;
	}

	public DynamicPanelBuilder<T> DefaultSortExpression(string sortExpression)
	{
		grid.GridData.SortExpression = sortExpression;
		return this;
	}

	public DynamicPanelBuilder<T> Action(string action)
	{
		grid.Action = action;
		return this;
	}

	public DynamicPanelBuilder<T> Controller(string controller)
	{
		grid.Controller = controller;
		return this;
	}

	public DynamicPanelBuilder<T> RouteValues(object routeValues)
	{
		grid.RouteValues = new RouteValueDictionary(routeValues);
		return this;
	}

	public DynamicPanelBuilder<T> Uid(string uniqueName)
	{
		string text3 = (grid.UniqueName = (dynamicGrid.UniqueName = uniqueName));
		return this;
	}

	protected override string Render()
	{
		return ((object)PartialExtensions.Partial(html, "Templates/DynamicPanel", (object)grid)).ToString();
	}
}
