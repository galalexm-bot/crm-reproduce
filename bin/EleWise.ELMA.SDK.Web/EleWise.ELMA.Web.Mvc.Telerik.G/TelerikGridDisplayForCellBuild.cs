using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.Routing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Inputs;
using Telerik.Web.Mvc.Extensions;
using Telerik.Web.Mvc.UI;
using Telerik.Web.Mvc.UI.Html;

namespace EleWise.ELMA.Web.Mvc.Telerik.Grids;

internal class TelerikGridDisplayForCellBuilder<TModel, TValue> : GridDisplayForCellBuilder<TModel, TValue> where TModel : class
{
	private bool checkPermissions;

	private string columnUniqueName;

	private readonly string expressionString;

	private Func<object, string> valueFunc;

	private Func<TModel, TValue> compiledExpression;

	private ClassMetadata metadata;

	private ViewAttributes viewAttributes;

	public TelerikGridDisplayForCellBuilder(GridColumnBase<TModel> column, Expression<Func<TModel, TValue>> expression, Func<TModel, TValue> compiledExpression, Func<object, string> valueFunc, ClassMetadata metadata = null, ViewAttributes viewAttributes = null)
	{
		base.set_ViewContext(((ViewComponentBase)column.get_Grid()).get_ViewContext());
		base.set_Expression(expression);
		((GridDataCellBuilderBase)this).set_HtmlAttributes((IDictionary<string, object>)((column.get_HtmlAttributes() != null) ? new RouteValueDictionary(column.get_HtmlAttributes()) : null));
		this.valueFunc = valueFunc;
		this.compiledExpression = compiledExpression;
		this.metadata = metadata;
		this.viewAttributes = viewAttributes;
		checkPermissions = (column as ITelerikGridBoundColumn)?.CheckCellPermissions ?? false;
		columnUniqueName = column.get_UniqueName();
	}

	public TelerikGridDisplayForCellBuilder(GridColumnBase<TModel> column, string expressionString, ClassMetadata metadata = null, ViewAttributes viewAttributes = null)
	{
		base.set_ViewContext(((ViewComponentBase)column.get_Grid()).get_ViewContext());
		((GridDataCellBuilderBase)this).set_HtmlAttributes((IDictionary<string, object>)((column.get_HtmlAttributes() != null) ? new RouteValueDictionary(column.get_HtmlAttributes()) : null));
		this.expressionString = expressionString;
		this.metadata = metadata;
		this.viewAttributes = viewAttributes;
		checkPermissions = (column as ITelerikGridBoundColumn)?.CheckCellPermissions ?? false;
		columnUniqueName = column.get_UniqueName();
	}

	protected override void AppendCellContent(IHtmlNode td, object dataItem)
	{
		//IL_0616: Unknown result type (might be due to invalid IL or missing references)
		HtmlHelper<TModel> val = new HtmlHelper<TModel>(base.get_ViewContext(), (IViewDataContainer)(object)new TelerikGridViewDataContainer<TModel>((TModel)dataItem, base.get_ViewContext().get_ViewData()));
		string htmlFieldPrefix = ((ViewDataDictionary)val.get_ViewData()).get_TemplateInfo().get_HtmlFieldPrefix();
		PropertyViewItem columnViewItem = null;
		bool flag = false;
		PropertyViewItem gridViewItem = base.get_ViewContext().get_ViewData().get_Item("View") as PropertyViewItem;
		long num = (dataItem.GetPropertyValue("Id", null) as long?) ?? 0;
		if (gridViewItem != null && Guid.TryParse(columnUniqueName, out var columnUid))
		{
			IEnumerable<PropertyViewItem> propertyViewItems = ContextVars.GetOrAdd($"propertyViewItems_{gridViewItem.PropertyUid}", () => gridViewItem.Items.OfType<PropertyViewItem>());
			flag = ContextVars.GetOrAdd($"isEditMode_{gridViewItem.PropertyUid}", () => propertyViewItems.Any((PropertyViewItem a) => a.EditableInTable));
			columnViewItem = ContextVars.GetOrAdd($"columnViewItem_{gridViewItem.PropertyUid}_{columnUid}", () => gridViewItem.FindItem((PropertyViewItem p) => p.PropertyUid == columnUid));
			if (flag && columnViewItem != null)
			{
				string arg = ((ControllerContext)base.get_ViewContext()).get_HttpContext().Items["InputContainerId"] as string;
				((ViewDataDictionary)val.get_ViewData()).get_TemplateInfo().set_HtmlFieldPrefix($"Prop_{arg}_{gridViewItem.PropertyUid}_{num}");
				base.get_ViewContext().get_ViewData().set_Item("View", (object)columnViewItem);
				Guid orAdd = ContextVars.GetOrAdd($"typeUidAttribute_{gridViewItem.PropertyUid}", () => (Guid)this.metadata.GetPropertyValue("Uid", Guid.Empty));
				base.get_ViewContext().get_ViewData().set_Item("typeUidAttribute", (object)orAdd);
				base.get_ViewContext().get_ViewData().set_Item("dataItemId", (object)num);
			}
		}
		try
		{
			string text = "";
			IPropertyPermissionService propertyPermissionService = (checkPermissions ? Locator.GetService<IPropertyPermissionService>() : null);
			if (base.get_Expression() != null && ExpressionExtensions.ToMemberExpression((LambdaExpression)base.get_Expression()) != null)
			{
				if (propertyPermissionService != null)
				{
					IPropertyMetadata propertyMetadata2 = ModelMetadata.FromLambdaExpression<TModel, TValue>(base.get_Expression(), val.get_ViewData()).GetPropertyMetadata();
					if (propertyMetadata2 != null && propertyPermissionService.CheckPropertyPermission(dataItem, propertyMetadata2.PropertyUid) == PropertyPermissionType.Hide)
					{
						text = "<div></div>";
					}
				}
				if (string.IsNullOrEmpty(text))
				{
					text = ((HtmlString)(object)val.Display(base.get_Expression(), delegate(WebViewAttributes a)
					{
						a.ViewStyle = ModelViewStyle.GridDisplay;
						if (this.viewAttributes != null)
						{
							a.Required = this.viewAttributes.Required && !(this.viewAttributes.ReadOnly ?? false);
						}
					})).ToHtmlString();
				}
			}
			else if (base.get_Expression() != null)
			{
				TValue val2 = compiledExpression((TModel)dataItem);
				Type nonNullableType = typeof(TValue).GetNonNullableType();
				IMetadataRuntimeService serviceNotNull = Locator.GetServiceNotNull<IMetadataRuntimeService>();
				ITypeDescriptor typeDescriptor = serviceNotNull.GetTypeDescriptor(nonNullableType);
				if (typeDescriptor == null)
				{
					IMetadata metadata = MetadataLoader.LoadMetadata(nonNullableType);
					typeDescriptor = ((val2 is Enum || val2 is EnumBase) ? serviceNotNull.GetTypeDescriptor(EnumDescriptor.UID, metadata.Uid) : ((!(val2 is IEntity)) ? serviceNotNull.GetTypeDescriptor(metadata.Uid, Guid.Empty) : serviceNotNull.GetTypeDescriptor(EntityDescriptor.UID, metadata.Uid)));
				}
				if (typeDescriptor != null && val2 != null)
				{
					EntityPropertyMetadata propertyMetadata = new EntityPropertyMetadata
					{
						TypeUid = typeDescriptor.Uid,
						SubTypeUid = typeDescriptor.SubTypeUid
					};
					if (ComponentManager.Current.GetExtensionPoints<IInput>().FirstOrDefault((IInput inp) => inp.TypeUid == propertyMetadata.TypeUid) is BaseInput baseInput)
					{
						ViewAttributes viewAttributes = new ViewAttributes
						{
							TypeSettings = propertyMetadata.Settings
						};
						string text2 = baseInput.DisplayTemplateName(((ControllerContext)((HtmlHelper)val).get_ViewContext()).get_Controller().get_ControllerContext(), propertyMetadata, nonNullableType, viewAttributes);
						text = ((HtmlString)(object)PartialExtensions.Partial((HtmlHelper)(object)val, "DisplayTemplates/" + text2, (object)val2)).ToHtmlString();
					}
					else
					{
						text = ((val2 != null) ? val2.ToString() : "");
					}
				}
				else
				{
					text = ((val2 != null) ? val2.ToString() : "");
				}
			}
			else
			{
				bool flag2 = false;
				string entityName;
				string exp = CustomPropertyProjection.GetExpressionFromString(expressionString, out entityName);
				if (!string.IsNullOrEmpty(entityName))
				{
					IMetadataRuntimeService serviceNotNull2 = Locator.GetServiceNotNull<IMetadataRuntimeService>();
					flag2 = !string.IsNullOrEmpty(entityName) && this.metadata != null && !serviceNotNull2.GetTypeByUid(this.metadata.Uid).IsAssignableFrom(dataItem.GetType().GetTypeWithoutProxy());
				}
				if (propertyPermissionService != null)
				{
					IPropertyMetadata propertyMetadata3 = ModelMetadata.FromStringExpression(exp, (ViewDataDictionary)(object)val.get_ViewData()).GetPropertyMetadata();
					if (propertyMetadata3 == null)
					{
						propertyMetadata3 = ((dataItem != null) ? ((ClassMetadata)MetadataLoader.LoadMetadata(dataItem.GetType().GetTypeWithoutProxy())) : null)?.Properties.FirstOrDefault((PropertyMetadata p) => p.Name == exp);
					}
					if (propertyMetadata3 != null && propertyPermissionService.CheckPropertyPermission(dataItem, propertyMetadata3.PropertyUid) == PropertyPermissionType.Hide)
					{
						text = "<div></div>";
					}
				}
				if (string.IsNullOrEmpty(text))
				{
					text = (flag2 ? "" : ((HtmlString)(object)((HtmlHelper)(object)val).Display(exp, delegate(WebViewAttributes a)
					{
						a.ViewStyle = ModelViewStyle.GridDisplay;
						if (this.viewAttributes != null)
						{
							a.Required = this.viewAttributes.Required && !(this.viewAttributes.ReadOnly ?? false);
						}
						if (columnViewItem != null)
						{
							string onChangeScriptName = columnViewItem.Attributes.OnChangeScriptName;
							string onChangeScriptName2 = gridViewItem.Attributes.OnChangeScriptName;
							if (!onChangeScriptName2.IsNullOrWhiteSpace())
							{
								a.OnChangeScriptName = $"{onChangeScriptName};{onChangeScriptName2}";
							}
							else if (!onChangeScriptName.IsNullOrWhiteSpace())
							{
								a.OnChangeScriptName = $"{onChangeScriptName};";
							}
						}
					})).ToHtmlString());
				}
			}
			if (valueFunc != null)
			{
				text = (string.IsNullOrEmpty(text) ? "<div></div>" : ((HtmlString)(object)MvcHtmlString.Create($"<a href=\"{valueFunc(dataItem)}\">{text}</a>")).ToHtmlString());
			}
			if (flag && columnViewItem != null)
			{
				IHtmlNode val3 = new HtmlElement("div").Attribute("id", $"Prop_{gridViewItem.PropertyUid}_{num}_{ElmaTagBuilder.CreateSanitizedId(expressionString)}_ValueContainer");
				if (StringExtensions.HasValue(text))
				{
					val3.Html(text);
					val3.AppendTo(td);
				}
				else
				{
					td.Html(StringExtensions.HasValue(text) ? text : "&nbsp;");
				}
			}
			else
			{
				td.Html(StringExtensions.HasValue(text) ? text : "&nbsp;");
			}
		}
		finally
		{
			if (gridViewItem != null)
			{
				base.get_ViewContext().get_ViewData().set_Item("View", (object)gridViewItem);
				((ViewDataDictionary)val.get_ViewData()).get_TemplateInfo().set_HtmlFieldPrefix(htmlFieldPrefix);
			}
		}
	}
}
