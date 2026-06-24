using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Html.Grids;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Web.Mvc.Models.Inputs;
using Telerik.Web.Mvc.UI;
using Telerik.Web.Mvc.UI.Fluent;

namespace EleWise.ELMA.BPM.Web.Common.Components;

public class SelectableGridBuilder<T> : DynamicGridBuilder<T> where T : class
{
	protected string PropertyIdName;

	protected string GridId;

	private bool multiSelect = true;

	private bool customCountInfo;

	private Guid? selectableGridProviderUid;

	private string selectableGridProviderData;

	private ISelectableGridProvider selectableGridProvider;

	private object itemModelObject;

	private object propertyValueObject;

	private SelectableGridCheckBoxModel selectableGridCheckBoxModel;

	private bool showCheckBox;

	private bool disabledSelectable;

	private Expression<Func<T, bool>> showCheckbox;

	public SelectableGridBuilder(HtmlHelper html, GridDataFilter<T> gridData, string propertyIdName)
		: this(html, gridData.GridId, (IGridData<T>)gridData, propertyIdName)
	{
	}

	public SelectableGridBuilder(HtmlHelper html, string gridId, IGridData<T> gridData, string propertyIdName)
		: this(html, gridId, gridData, propertyIdName, (Guid?)null)
	{
	}

	public SelectableGridBuilder(HtmlHelper html, string gridId, IGridData<T> gridData, string propertyIdName, Guid? stateProvider)
		: this(html, gridId, gridData, stateProvider)
	{
		PropertyIdName = propertyIdName;
	}

	protected SelectableGridBuilder(HtmlHelper html, string gridId, IGridData<T> gridData, Guid? stateProvider)
		: base(html, gridId, gridId, gridData, stateProvider)
	{
		GridId = gridId.HtmlEncode();
	}

	private bool ShowCheckBox(T rowValue)
	{
		if (showCheckbox != null && !showCheckbox.Compile()(rowValue))
		{
			return false;
		}
		if (selectableGridProvider == null)
		{
			return true;
		}
		SelectableGridCheckBoxModel selectableGridCheckBoxModel = new SelectableGridCheckBoxModel
		{
			PropertyName = PropertyIdName,
			Property = GetIdValue(PropertyIdName, rowValue),
			SelectableGridProviderData = selectableGridProviderData,
			RowObject = rowValue
		};
		if (selectableGridCheckBoxModel.EqualsFor(this.selectableGridCheckBoxModel))
		{
			return showCheckBox;
		}
		this.selectableGridCheckBoxModel = selectableGridCheckBoxModel;
		showCheckBox = selectableGridProvider.ShowCheckBox(selectableGridCheckBoxModel);
		return showCheckBox;
	}

	protected virtual object GetIdValue(string name, object value)
	{
		if (itemModelObject != null && itemModelObject.Equals(value))
		{
			return propertyValueObject;
		}
		propertyValueObject = ReflectionHelper.GetPropertyValue(name, value);
		itemModelObject = value;
		return propertyValueObject;
	}

	public SelectableGridBuilder<T> MultiSelect(bool value)
	{
		multiSelect = value;
		return this;
	}

	public SelectableGridBuilder<T> CustomCountInfo(bool value)
	{
		customCountInfo = value;
		return this;
	}

	public SelectableGridBuilder<T> DisabledSelectable(bool value)
	{
		disabledSelectable = value;
		return this;
	}

	public SelectableGridBuilder<T> SelectableGridProvider(Guid providerUid)
	{
		selectableGridProviderUid = providerUid;
		selectableGridProvider = ComponentManager.Current.GetExtensionPoints<ISelectableGridProvider>().FirstOrDefault(delegate(ISelectableGridProvider m)
		{
			Guid uid = m.Uid;
			Guid? guid = selectableGridProviderUid;
			return uid == guid;
		});
		return this;
	}

	public SelectableGridBuilder<T> SelectableGridProviderData(string providerData)
	{
		selectableGridProviderData = providerData;
		return this;
	}

	public SelectableGridBuilder<T> ShowCheckbox(Expression<Func<T, bool>> configurator)
	{
		showCheckbox = configurator;
		return this;
	}

	protected override string Render()
	{
		if (disabledSelectable)
		{
			return base.Render();
		}
		string elementsId = GridId.Replace("-", "_");
		RowPresetClass((T m, Grid<T> grid) => (!ShowCheckBox(m)) ? "" : "selectable");
		RowPresetHtmlAttributes((T m, Grid<T> grid) => new
		{
			elementId = GetIdValue(PropertyIdName, m)
		});
		Columns(delegate(DynamicColumnsBuilder<T> c)
		{
			SelectableGridCheckboxColumn(html, c);
		}).ClientEvents(delegate(GridClientEventsBuilder a)
		{
			a.OnDataBound($"gridOnDataBound_{elementsId}");
		});
		SelectableGridModel selectableGridModel = new SelectableGridModel
		{
			GridId = GridId,
			MultiSelect = multiSelect,
			CustomCountInfo = customCountInfo,
			ElementsId = elementsId
		};
		return string.Format("\r\n<div class='SelectableGrid' gridId='{0}'>\r\n    {1}\r\n    {2}\r\n    {3}\r\n</div>", GridId, PartialExtensions.Partial(html, "SelectableGrid/Init", (object)selectableGridModel), base.Render(), PartialExtensions.Partial(html, "SelectableGrid/AfterGrid", (object)selectableGridModel));
	}

	private void SelectableGridCheckboxColumn(HtmlHelper html, DynamicColumnsBuilder<T> columnsBuilder)
	{
		if (!disabledSelectable)
		{
			Func<T, ModernCheckBoxBuilder> columnCheckbox = delegate(T m)
			{
				object idValue = GetIdValue(PropertyIdName, m);
				object obj = ((idValue is IEntity) ? ((IEntity)idValue).GetId() : idValue);
				return (!ShowCheckBox(m)) ? null : html.ModernCheckBox(renderUncheckedInput: false).Id($"selectCheckbox_{GridId}_{obj}").Name($"selectCheckbox_{GridId}")
					.Value(obj);
			};
			string header = (multiSelect ? html.ModernCheckBox(renderUncheckedInput: false).Id("selectAllCheckbox_" + GridId).Attributes(delegate(HtmlAttributes a)
			{
				a.onclick = $"elma.SelectableGrid.selectAll('{GridId}')";
			})
				.ContainerAttributes(delegate(HtmlAttributes a)
				{
					a.Add("tooltiptext", SR.T("Выбрать все/Снять выделение"));
				})
				.ToString() : "");
			columnsBuilder.Insert(0, (T m) => columnCheckbox(m), null, () => int.MinValue).Order(int.MinValue).Uid("gridRowsSelectorColumn" + GridId)
				.Header(header)
				.NotSortable()
				.NotResizable()
				.Width(30);
		}
	}
}
public class SelectableGridBuilder<T, TValue> : SelectableGridBuilder<T> where T : class
{
	private readonly Func<T, Grid, TValue> idDelegate;

	private readonly Expression<Func<T, TValue>> idExpressionFunc;

	[Obsolete("Конструктор устарел")]
	public SelectableGridBuilder(HtmlHelper html, GridDataFilter<T> gridData, Expression<Func<T, TValue>> expression)
		: this(html, gridData.GridId, (IGridData<T>)gridData, expression)
	{
	}

	[Obsolete("Конструктор устарел")]
	public SelectableGridBuilder(HtmlHelper html, string gridId, IGridData<T> gridData, Expression<Func<T, TValue>> expression)
		: this(html, gridId, gridData, expression, (Guid?)null)
	{
	}

	[Obsolete("Конструктор устарел")]
	public SelectableGridBuilder(HtmlHelper html, string gridId, IGridData<T> gridData, Expression<Func<T, TValue>> expression, Guid? stateProvider)
		: base(html, gridId, gridData, stateProvider)
	{
		idExpressionFunc = expression;
	}

	public SelectableGridBuilder(HtmlHelper html, GridDataFilter<T> gridData, Func<T, Grid, TValue> @delegate)
		: this(html, gridData.GridId, (IGridData<T>)gridData, @delegate)
	{
	}

	public SelectableGridBuilder(HtmlHelper html, string gridId, IGridData<T> gridData, Func<T, Grid, TValue> @delegate)
		: this(html, gridId, gridData, @delegate, (Guid?)null)
	{
	}

	public SelectableGridBuilder(HtmlHelper html, string gridId, IGridData<T> gridData, Func<T, Grid, TValue> @delegate, Guid? stateProvider)
		: base(html, gridId, gridData, stateProvider)
	{
		idDelegate = @delegate;
	}

	protected override object GetIdValue(string name, object value)
	{
		if (idDelegate != null)
		{
			return GetDelegateValue<T, Grid, object>(idDelegate, grid, (T)value);
		}
		if (idExpressionFunc != null)
		{
			return GetExpressionValue<T, object>(idExpressionFunc, (T)value);
		}
		return null;
	}

	private static TDelegateValue GetDelegateValue<TObject, TGridObject, TDelegateValue>(Delegate @delegate, TGridObject grid, T obj)
	{
		return (TDelegateValue)@delegate.DynamicInvoke(obj, grid);
	}

	private static TExpressionValue GetExpressionValue<TObject, TExpressionValue>(Expression expr, TObject obj)
	{
		Func<TExpressionValue> func = () => ((Expression<Func<TObject, TExpressionValue>>)expr).Compile()(obj);
		string name = "GridExtensions_GetExpressionName";
		object value2;
		if (ContextVars.TryGetValue<Dictionary<object, object>>(name, out var value))
		{
			if (value.TryGetValue(expr, out value2))
			{
				return (TExpressionValue)value2;
			}
			value2 = func();
			value.Add(expr, value2);
			ContextVars.Set(name, value);
			return (TExpressionValue)value2;
		}
		value2 = func();
		value = new Dictionary<object, object> { { expr, value2 } };
		ContextVars.Set(name, value);
		return (TExpressionValue)value2;
	}
}
