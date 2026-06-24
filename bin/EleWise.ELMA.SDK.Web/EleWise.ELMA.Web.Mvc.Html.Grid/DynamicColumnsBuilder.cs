using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Models.ActionItems.Menu;
using EleWise.ELMA.Web.Mvc.Models.Grids;

namespace EleWise.ELMA.Web.Mvc.Html.Grids;

public class DynamicColumnsBuilder<T> where T : class
{
	private readonly DynamicGrid grid;

	private readonly HtmlHelper html;

	private readonly ClassMetadata _metadata;

	private DynamicGridBuilder<T> dynamicGridBuilder;

	protected GridState State { get; set; }

	public DynamicColumnsBuilder(HtmlHelper html, DynamicGrid grid, GridState state, ClassMetadata metadata)
	{
		this.html = html;
		this.grid = grid;
		_metadata = metadata;
		State = state;
	}

	public DynamicColumnsBuilder(HtmlHelper html, DynamicGrid grid, GridState state, ClassMetadata metadata, DynamicGridBuilder<T> dynamicGridBuilder)
		: this(html, grid, state, metadata)
	{
		this.dynamicGridBuilder = dynamicGridBuilder;
	}

	public DynamicColumnsBuilder<T> DefaultColumns(bool childs = false, IEnumerable<Guid> availablePropertyUids = null)
	{
		foreach (GridColumn gridColumn in GridBuilderExtensions.GetDefaultColumns(TypeOf<T>.Raw, _metadata, State, childs, availablePropertyUids))
		{
			GridColumn gridColumn2 = grid.Columns.FirstOrDefault((GridColumn c) => c.Name == gridColumn.Name);
			if (gridColumn2 == null)
			{
				grid.Columns.Add(gridColumn);
			}
			else if (string.IsNullOrWhiteSpace(gridColumn2.Width))
			{
				gridColumn2.Width = gridColumn.Width;
			}
		}
		return this;
	}

	public DynamicColumnBuilder<T, TValue> For<TValue>(Expression<Func<T, TValue>> propertySpecifier)
	{
		DynamicColumnBuilder<T, TValue> builder;
		DynamicGridColumn item = CreateColumn(propertySpecifier, out builder);
		grid.Columns.Add(item);
		return builder;
	}

	public DynamicColumnBuilder<T> For(string propertySpecifier)
	{
		DynamicColumnBuilder<T> builder;
		DynamicGridColumn item = CreateColumn(propertySpecifier, out builder);
		grid.Columns.Add(item);
		return builder;
	}

	public DynamicColumnBuilder<T> For(PropertyMetadata propertyMetadata)
	{
		ClassMetadata classMetadata = (from p in MetadataLoader.GetBasePropertiesAndMetadata(_metadata).Concat(MetadataLoader.GetChildProperties(_metadata))
			where p.Key.Uid == propertyMetadata.Uid
			select p.Value).FirstOrDefault();
		if (classMetadata == null)
		{
			return For(propertyMetadata.Name);
		}
		DynamicColumnBuilder<T> builder;
		DynamicGridColumn item = CreateColumn(classMetadata, propertyMetadata, out builder);
		grid.Columns.Add(item);
		return builder;
	}

	public DynamicColumnBuilder<T, string> ContextMenu(Func<T, ActionMenuShowParams, bool> getContextMenu)
	{
		ActionMenuShowParams showParams = new ActionMenuShowParams();
		DynamicGridColumn dynamicGridColumn = new DynamicGridColumn
		{
			Header = "",
			Sortable = false,
			Groupable = false,
			ValueType = typeof(string),
			Width = "55px",
			Template = (dynamic m) => (!(getContextMenu(m, showParams) ? true : false)) ? MvcHtmlString.Empty : html.ImageButton("#context_menu.svg", SR.T("Действия"), "", null, new
			{
				@class = "pointer context-menu-img"
			})
		};
		DynamicColumnBuilder<T, string> dynamicColumnBuilder = new DynamicColumnBuilder<T, string>(html, dynamicGridColumn, (T m) => "ContextMenuColumn", null, dynamicGridBuilder);
		dynamicColumnBuilder.CellHtmlAttributes((T m, GridColumn column1) => new
		{
			@class = "pointer",
			onclick = (getContextMenu(m, showParams) ? html.ActionMenuShow(showParams) : MvcHtmlString.Empty)
		});
		grid.Columns.Add(dynamicGridColumn);
		return dynamicColumnBuilder;
	}

	public DynamicColumnBuilder<T, TValue> Insert<TValue>(int index, Expression<Func<T, TValue>> propertySpecifier, Func<bool> columnVisible = null, Func<int> columnOrder = null)
	{
		DynamicColumnBuilder<T, TValue> builder;
		DynamicGridColumn dynamicGridColumn = CreateColumn(propertySpecifier, out builder);
		dynamicGridColumn.ColumnVisible = columnVisible;
		dynamicGridColumn.ColumnOrder = columnOrder;
		if (index >= 0)
		{
			grid.Columns.Insert(index, dynamicGridColumn);
		}
		else
		{
			grid.Columns.Add(dynamicGridColumn);
		}
		return builder;
	}

	private static Expression UnwrapExpression(Expression expr)
	{
		if (expr is LambdaExpression lambdaExpression)
		{
			return UnwrapExpression(lambdaExpression.Body);
		}
		if (expr is UnaryExpression unaryExpression && unaryExpression.NodeType == ExpressionType.Convert)
		{
			return UnwrapExpression(unaryExpression.Operand);
		}
		return expr;
	}

	public DynamicColumnBuilder<T, TValue> InsertAfter<TValue>(DynamicColumnBuilderBase existingColumnBuilder, Expression<Func<T, TValue>> propertySpecifier, bool displayOnlyWithExistingColumn = false)
	{
		return InsertAfter(existingColumnBuilder?.column, propertySpecifier, displayOnlyWithExistingColumn);
	}

	public DynamicColumnBuilder<T, TValue> InsertAfter<TValue>(GridColumn existingColumn, Expression<Func<T, TValue>> propertySpecifier, bool displayOnlyWithExistingColumn = false)
	{
		int index = ((existingColumn != null) ? (grid.Columns.IndexOf(existingColumn) + 1) : (-1));
		return Insert(index, propertySpecifier, displayOnlyWithExistingColumn ? ((Func<bool>)(() => existingColumn != null && existingColumn.Visible)) : null, () => (existingColumn == null) ? int.MinValue : existingColumn.Order);
	}

	public DynamicColumnBuilder<T, TValue> InsertAfter<TValue>(string existingColumnName, Expression<Func<T, TValue>> propertySpecifier, bool displayOnlyWithExistingColumn = false)
	{
		GridColumn existingColumn = ((!string.IsNullOrEmpty(existingColumnName)) ? grid.Columns.FirstOrDefault((GridColumn c) => c.Expression != null && c.Name == existingColumnName) : null);
		int index = ((existingColumn != null) ? (grid.Columns.IndexOf(existingColumn) + 1) : (-1));
		return Insert(index, propertySpecifier, displayOnlyWithExistingColumn ? ((Func<bool>)(() => existingColumn != null && existingColumn.Visible)) : null, () => (existingColumn == null) ? int.MinValue : existingColumn.Order);
	}

	public DynamicColumnBuilder<T, TValue> InsertAfter<TValue>(Expression<Func<T, object>> existingColumnExpression, Expression<Func<T, TValue>> propertySpecifier, bool displayOnlyWithExistingColumn = false)
	{
		GridColumn existingColumn = ((existingColumnExpression != null) ? grid.Columns.FirstOrDefault((GridColumn c) => c.Expression != null && UnwrapExpression(c.Expression).ToString() == UnwrapExpression(existingColumnExpression).ToString()) : null);
		int index = ((existingColumn != null) ? (grid.Columns.IndexOf(existingColumn) + 1) : (-1));
		return Insert(index, propertySpecifier, displayOnlyWithExistingColumn ? ((Func<bool>)(() => existingColumn != null && existingColumn.Visible)) : null, () => (existingColumn == null) ? int.MinValue : existingColumn.Order);
	}

	public GridColumn GetColumn(Expression<Func<T, object>> existingColumnExpression)
	{
		GridColumn gridColumn = ((existingColumnExpression != null) ? grid.Columns.FirstOrDefault((GridColumn c) => c.Expression != null && UnwrapExpression(c.Expression).ToString() == UnwrapExpression(existingColumnExpression).ToString()) : null);
		if (gridColumn == null)
		{
			string existingColumnName = ExpressionHelper.GetExpressionText((LambdaExpression)existingColumnExpression);
			gridColumn = ((existingColumnName != null) ? grid.Columns.FirstOrDefault((GridColumn c) => c.Name == existingColumnName) : null);
		}
		return gridColumn;
	}

	public DynamicColumnBuilder<T, TValue> InsertBefore<TValue>(DynamicColumnBuilderBase existingColumnBuilder, Expression<Func<T, TValue>> propertySpecifier, bool displayOnlyWithExistingColumn = false)
	{
		return InsertBefore(existingColumnBuilder?.column, propertySpecifier, displayOnlyWithExistingColumn);
	}

	public DynamicColumnBuilder<T, TValue> InsertBefore<TValue>(GridColumn existingColumn, Expression<Func<T, TValue>> propertySpecifier, bool displayOnlyWithExistingColumn = false)
	{
		int index = ((existingColumn != null) ? grid.Columns.IndexOf(existingColumn) : (-1));
		return Insert(index, propertySpecifier, displayOnlyWithExistingColumn ? ((Func<bool>)(() => existingColumn != null && existingColumn.Visible)) : null, () => (existingColumn == null) ? int.MinValue : existingColumn.Order);
	}

	public DynamicColumnBuilder<T, TValue> InsertBefore<TValue>(Expression<Func<T, object>> existingColumnExpression, Expression<Func<T, TValue>> propertySpecifier, bool displayOnlyWithExistingColumn = false)
	{
		GridColumn existingColumn = ((existingColumnExpression != null) ? grid.Columns.FirstOrDefault((GridColumn c) => c.Expression != null && UnwrapExpression(c.Expression).ToString() == UnwrapExpression(existingColumnExpression).ToString()) : null);
		int index = ((existingColumn != null) ? grid.Columns.IndexOf(existingColumn) : (-1));
		return Insert(index, propertySpecifier, displayOnlyWithExistingColumn ? ((Func<bool>)(() => existingColumn != null && existingColumn.Visible)) : null, () => (existingColumn == null) ? int.MinValue : existingColumn.Order);
	}

	private static MemberExpression GetMemberExpression(LambdaExpression expression)
	{
		return RemoveUnary(expression.Body) as MemberExpression;
	}

	private static Expression RemoveUnary(Expression body)
	{
		if (body is UnaryExpression unaryExpression)
		{
			return unaryExpression.Operand;
		}
		return body;
	}

	[UsedImplicitly]
	private static Type GetTypeFromMemberExpression(MemberExpression memberExpression)
	{
		if (memberExpression == null)
		{
			return null;
		}
		Type type = GetTypeFromMemberInfo(memberExpression.Member, (PropertyInfo p) => p.PropertyType) ?? GetTypeFromMemberInfo(memberExpression.Member, (MethodInfo m) => m.ReturnType);
		if (type != null)
		{
			return type;
		}
		return GetTypeFromMemberInfo(memberExpression.Member, (FieldInfo f) => f.FieldType);
	}

	private static Type GetTypeFromMemberInfo<TMember>(MemberInfo member, Func<TMember, Type> func) where TMember : MemberInfo
	{
		if (member is TMember)
		{
			return func((TMember)member);
		}
		return null;
	}

	private DynamicGridColumn CreateColumn<TValue>(Expression<Func<T, TValue>> propertySpecifier, out DynamicColumnBuilder<T, TValue> builder)
	{
		string text = GetMemberExpression(propertySpecifier)?.Member.Name;
		ViewDataDictionary<T> val = new ViewDataDictionary<T>();
		ModelMetadata val2 = null;
		if (propertySpecifier.Body.NodeType == ExpressionType.MemberAccess)
		{
			val2 = ModelMetadata.FromLambdaExpression<T, TValue>(propertySpecifier, val);
		}
		IPropertyMetadata propertyMetadata = val2?.GetPropertyMetadata();
		Func<T, TValue> propertySpecifierFunc = propertySpecifier.Compile();
		DynamicGridColumn dynamicGridColumn = new DynamicGridColumn
		{
			Header = ((propertyMetadata != null) ? propertyMetadata.DisplayName : text),
			SortExpression = PropertyHelper.GetSortExpression(propertyMetadata, text),
			Name = ((propertyMetadata != null) ? propertyMetadata.Name : text),
			ValueType = typeof(TValue),
			Expression = propertySpecifier
		};
		if (propertyMetadata != null)
		{
			dynamicGridColumn.UniqueName = propertyMetadata.Uid.ToString();
		}
		builder = new DynamicColumnBuilder<T, TValue>(html, dynamicGridColumn, propertySpecifierFunc, _metadata, dynamicGridBuilder);
		return dynamicGridColumn;
	}

	private DynamicGridColumn CreateColumn(string propertySpecifier, out DynamicColumnBuilder<T> builder)
	{
		ViewDataDictionary<T> val = new ViewDataDictionary<T>();
		ModelMetadata val2 = ModelMetadata.FromStringExpression(propertySpecifier, (ViewDataDictionary)(object)val);
		IPropertyMetadata propertyMetadata = val2?.GetPropertyMetadata();
		DynamicGridColumn dynamicGridColumn = new DynamicGridColumn
		{
			Header = ((propertyMetadata != null) ? propertyMetadata.DisplayName : propertySpecifier),
			SortExpression = PropertyHelper.GetSortExpression(propertyMetadata, propertySpecifier),
			Name = ((propertyMetadata != null) ? propertyMetadata.Name : propertySpecifier),
			ValueType = val2.get_ModelType()
		};
		if (propertyMetadata != null)
		{
			dynamicGridColumn.UniqueName = propertyMetadata.Uid.ToString();
		}
		builder = new DynamicColumnBuilder<T>(html, dynamicGridColumn, propertySpecifier, _metadata, dynamicGridBuilder);
		return dynamicGridColumn;
	}

	private DynamicGridColumn CreateColumn(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, out DynamicColumnBuilder<T> builder)
	{
		string text = (_metadata.Properties.All((PropertyMetadata p) => p.Uid != propertyMetadata.Uid) ? string.Format("{0}___{1}", propertyMetadata.Name, classMetadata.FullTypeName.Replace(".", "__")) : propertyMetadata.Name);
		DynamicGridColumn dynamicGridColumn = new DynamicGridColumn
		{
			Header = propertyMetadata.DisplayName,
			SortExpression = PropertyHelper.GetSortExpression(propertyMetadata, text),
			Name = text,
			ValueType = ModelHelper.GetEntityType(classMetadata.Uid)
		};
		dynamicGridColumn.UniqueName = propertyMetadata.Uid.ToString();
		builder = new DynamicColumnBuilder<T>(html, dynamicGridColumn, propertyMetadata.Name, _metadata, dynamicGridBuilder);
		return dynamicGridColumn;
	}
}
