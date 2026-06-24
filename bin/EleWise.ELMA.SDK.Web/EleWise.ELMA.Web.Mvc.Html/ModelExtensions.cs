using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.Routing;
using System.Web.WebPages;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Components;
using EleWise.ELMA.DynamicForms;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html.Buttons;
using EleWise.ELMA.Web.Mvc.Html.Forms;
using EleWise.ELMA.Web.Mvc.Html.Selectors;
using EleWise.ELMA.Web.Mvc.Models;
using EleWise.ELMA.Web.Mvc.Views.ViewItem;
using NHibernate.Proxy;

namespace EleWise.ELMA.Web.Mvc.Html;

public static class ModelExtensions
{
	private enum PropertyPart
	{
		Caption,
		Description,
		Value
	}

	[Obsolete("Use method TableForm")]
	public static ModelTable ModelTable(this HtmlHelper htmlHelper, Action<ModelTable> t)
	{
		ModelTable modelTable = new ModelTable(htmlHelper.get_ViewContext());
		t?.Invoke(modelTable);
		modelTable.RenderStart();
		return modelTable;
	}

	[Obsolete("Use method TableForm")]
	public static ModelTable ModelTable(this HtmlHelper htmlHelper, string id = null, string @class = null, string width = "100%", bool fixedLayout = true, int columns = 1, string captionColumnWidth = "200px", string valueColumnWidth = "auto", HtmlStyle style = null)
	{
		ModelTable modelTable = new ModelTable(htmlHelper.get_ViewContext());
		modelTable.Id = id;
		modelTable.Class = @class;
		modelTable.Width = width;
		modelTable.FixedLayout = fixedLayout;
		modelTable.Columns = columns;
		modelTable.CaptionColumnWidth = captionColumnWidth;
		modelTable.ValueColumnWidth = valueColumnWidth;
		if (style != null)
		{
			modelTable.Style = style;
		}
		modelTable.RenderStart();
		return modelTable;
	}

	public static TableFormRenderer TableForm(this HtmlHelper htmlHelper)
	{
		return htmlHelper.TableForm(null);
	}

	public static TableFormRenderer TableForm(this HtmlHelper htmlHelper, Action<TableFormBuilder> builderActions)
	{
		TableFormModel model = new TableFormModel();
		TableFormBuilder obj = new TableFormBuilder(model);
		builderActions?.Invoke(obj);
		TableFormRenderer tableFormRenderer = new TableFormRenderer(model, htmlHelper);
		tableFormRenderer.WriteStart();
		return tableFormRenderer;
	}

	public static TableFormRenderer TableForm(this HtmlHelper htmlHelper, ViewType viewType)
	{
		TableFormRenderer tableFormRenderer = new TableFormRenderer(new TableFormModel
		{
			ViewType = viewType
		}, htmlHelper);
		tableFormRenderer.WriteStart();
		return tableFormRenderer;
	}

	public static MvcHtmlString TableFormStart(this HtmlHelper htmlHelper)
	{
		return htmlHelper.TableFormStart(null);
	}

	public static MvcHtmlString TableFormStart(this HtmlHelper htmlHelper, Action<TableFormBuilder> builderActions)
	{
		TableFormModel tableFormModel = new TableFormModel();
		TableFormBuilder obj = new TableFormBuilder(tableFormModel);
		builderActions?.Invoke(obj);
		return tableFormModel.RenderStart(htmlHelper);
	}

	public static MvcHtmlString TableFormStart(this HtmlHelper htmlHelper, ViewType viewType)
	{
		return new TableFormModel
		{
			ViewType = viewType
		}.RenderStart(htmlHelper);
	}

	public static MvcHtmlString TableFormEnd(this HtmlHelper htmlHelper)
	{
		return htmlHelper.TableFormEnd(null);
	}

	public static MvcHtmlString TableFormEnd(this HtmlHelper htmlHelper, Action<TableFormBuilder> builderActions)
	{
		TableFormModel tableFormModel = new TableFormModel();
		TableFormBuilder obj = new TableFormBuilder(tableFormModel);
		builderActions?.Invoke(obj);
		return tableFormModel.RenderEnd(htmlHelper);
	}

	public static DynamicFormRenderer DynamicForm(this HtmlHelper htmlHelper)
	{
		return htmlHelper.DynamicForm((Action<DynamicFormBuilder>)null);
	}

	public static DynamicFormRenderer DynamicForm(this HtmlHelper htmlHelper, Action<DynamicFormBuilder> builderActions)
	{
		DynamicFormModel model = new DynamicFormModel();
		DynamicFormBuilder obj = new DynamicFormBuilder(model);
		builderActions?.Invoke(obj);
		DynamicFormRenderer dynamicFormRenderer = new DynamicFormRenderer(model, htmlHelper);
		dynamicFormRenderer.WriteStart();
		return dynamicFormRenderer;
	}

	public static DynamicFormRenderer DynamicForm(this HtmlHelper htmlHelper, string id, Guid? guid = null)
	{
		if (guid.HasValue)
		{
			id += $"_{guid.Value:N}";
		}
		Action<DynamicFormBuilder> builderActions = delegate(DynamicFormBuilder b)
		{
			b.Id(id);
		};
		return htmlHelper.DynamicForm(builderActions);
	}

	public static DynamicFormRenderer DynamicForm(this HtmlHelper htmlHelper, string id, Guid? guid, bool empty)
	{
		if (guid.HasValue)
		{
			id += string.Format("_{0:N}{1}", guid.Value, empty ? "_empty" : "");
		}
		Action<DynamicFormBuilder> builderActions = delegate(DynamicFormBuilder b)
		{
			b.Id(id);
		};
		return htmlHelper.DynamicForm(builderActions);
	}

	public static DynamicMvcForm ElmaDynamicForm(this HtmlHelper htmlHelper, string id, Guid? guid = null)
	{
		return new DynamicMvcForm(htmlHelper.ElmaForm(), htmlHelper.DynamicForm(id, guid));
	}

	public static DynamicMvcForm JavascriptDynamicForm(this HtmlHelper htmlHelper, string id, string submit, Guid? guid = null)
	{
		return new DynamicMvcForm(string.IsNullOrEmpty(id) ? htmlHelper.JavascriptForm("GlobalForm", submit) : htmlHelper.JavascriptForm(id + "-form", submit), htmlHelper.DynamicForm(id, guid));
	}

	public static DynamicMvcForm ElmaDynamicForm(this HtmlHelper htmlHelper, string id, bool confirmonclose, Guid? guid = null)
	{
		return new DynamicMvcForm(htmlHelper.ElmaForm("GlobalForm", confirmonclose), htmlHelper.DynamicForm(id, guid));
	}

	public static DynamicMvcForm ElmaDynamicForm(this HtmlHelper htmlHelper, string elmaFormId, string dynamicFormId, Guid? guid = null)
	{
		return new DynamicMvcForm(htmlHelper.ElmaForm(elmaFormId), htmlHelper.DynamicForm(dynamicFormId, guid));
	}

	public static MvcHtmlString DynamicFormStart(this HtmlHelper htmlHelper)
	{
		return htmlHelper.DynamicFormStart((Action<DynamicFormBuilder>)null);
	}

	public static MvcHtmlString DynamicFormStart(this HtmlHelper htmlHelper, Action<DynamicFormBuilder> builderActions)
	{
		DynamicFormModel dynamicFormModel = new DynamicFormModel();
		DynamicFormBuilder obj = new DynamicFormBuilder(dynamicFormModel);
		builderActions?.Invoke(obj);
		return dynamicFormModel.RenderStart(htmlHelper);
	}

	public static MvcHtmlString DynamicFormStart(this HtmlHelper htmlHelper, string id, Guid? guid = null)
	{
		if (guid.HasValue)
		{
			id += $"_{guid.Value:N}";
		}
		Action<DynamicFormBuilder> builderActions = delegate(DynamicFormBuilder b)
		{
			b.Id(id);
		};
		return htmlHelper.DynamicFormStart(builderActions);
	}

	public static MvcHtmlString DynamicFormEnd(this HtmlHelper htmlHelper)
	{
		return htmlHelper.DynamicFormEnd(null);
	}

	public static MvcHtmlString DynamicFormEnd(this HtmlHelper htmlHelper, Action<DynamicFormBuilder> builderActions)
	{
		DynamicFormModel dynamicFormModel = new DynamicFormModel();
		DynamicFormBuilder obj = new DynamicFormBuilder(dynamicFormModel);
		builderActions?.Invoke(obj);
		return dynamicFormModel.RenderEnd(htmlHelper);
	}

	public static bool IsEmpty<TModel, TValue>(ViewDataDictionary<TModel> viewData, Expression<Func<TModel, TValue>> expression, TModel dataItem)
	{
		ModelMetadata val = ModelMetadata.FromLambdaExpression<TModel, TValue>(expression, viewData);
		if (val == null)
		{
			return false;
		}
		PropertyMetadata propertyMetadata = val.GetPropertyMetadata() as PropertyMetadata;
		TValue val2 = expression.Compile()(dataItem);
		if (propertyMetadata == null)
		{
			return val2 == null;
		}
		return Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeDescriptor(propertyMetadata.TypeUid, propertyMetadata.SubTypeUid)?.IsEmpty(propertyMetadata, val2) ?? (val2 == null);
	}

	public static bool IsEmpty(ViewDataDictionary viewData, string expression, object dataItem)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		ViewDataDictionary val = new ViewDataDictionary(viewData);
		val.set_Model(dataItem);
		ModelMetadata val2 = ModelMetadata.FromStringExpression(expression, val);
		if (val2 == null)
		{
			return false;
		}
		PropertyMetadata propertyMetadata = val2.GetPropertyMetadata() as PropertyMetadata;
		object model = val2.get_Model();
		if (propertyMetadata == null)
		{
			return model == null;
		}
		return Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeDescriptor(propertyMetadata.TypeUid, propertyMetadata.SubTypeUid)?.IsEmpty(propertyMetadata, model) ?? (model == null);
	}

	public static MvcHtmlString DisplayValue(this HtmlHelper htmlHelper, IEntity entity)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		if (entity == null)
		{
			return null;
		}
		string text = entity.ToString();
		MvcHtmlString val = new MvcHtmlString(htmlHelper.Encode(string.IsNullOrWhiteSpace(text) ? SR.Untitled : text));
		string text2 = htmlHelper.Url().ObjectLink(entity);
		if (!string.IsNullOrEmpty(text2))
		{
			TagBuilder val2 = new TagBuilder("a");
			val2.set_InnerHtml(((HtmlString)(object)val).ToHtmlString());
			val2.MergeAttribute("href", text2);
			val = MvcHtmlString.Create(val2.ToString((TagRenderMode)0));
		}
		return val;
	}

	public static ActionButtonBuilder DisplayValueButton(this HtmlHelper htmlHelper, IEntity entity)
	{
		if (entity == null)
		{
			return null;
		}
		string text = entity.ToString();
		string text2 = htmlHelper.Encode(string.IsNullOrWhiteSpace(text) ? SR.Untitled : text);
		string text3 = htmlHelper.Url().ObjectLink(entity);
		if (!string.IsNullOrEmpty(text3))
		{
			return htmlHelper.Button().Text(text2).Url(text3)
				.AsLink();
		}
		return htmlHelper.Button().Text(text2).Style(ButtonStyle.Simple)
			.ReadOnly()
			.AsLink();
	}

	public static MvcHtmlString Caption<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression, Action<WebViewAttributes> viewAttributesAction = null, bool forDisplay = false)
	{
		WebViewAttributes webViewAttributes = new WebViewAttributes();
		ApplyObjectViewData(webViewAttributes, ModelMetadata.FromLambdaExpression<TModel, TValue>(expression, html.get_ViewData()), null, forDisplay, new PropertyCaptionViewItem());
		viewAttributesAction?.Invoke(webViewAttributes);
		if (forDisplay)
		{
			webViewAttributes.ReadOnly = true;
		}
		TagBuilder val = (webViewAttributes.RenderContainer ? ((HtmlHelper)(object)html).PropertyCaptionContainerTagBuilder(((HtmlString)(object)html.PropertyCaptionContainerId(expression, webViewAttributes)).ToHtmlString(), webViewAttributes.ContainerTagName, webViewAttributes) : null);
		if (val != null && webViewAttributes.ContainerBuilderAction != null)
		{
			webViewAttributes.ContainerBuilderAction(val);
		}
		return PropertyPartHelper(PropertyPart.Caption, html, expression, webViewAttributes, val);
	}

	public static MvcHtmlString Caption(this HtmlHelper html, string expression, Action<WebViewAttributes> viewAttributesAction = null, bool forDisplay = false)
	{
		WebViewAttributes webViewAttributes = new WebViewAttributes();
		ApplyObjectViewData(webViewAttributes, ModelMetadata.FromStringExpression(expression, html.get_ViewData()), null, forDisplay, new PropertyCaptionViewItem());
		viewAttributesAction?.Invoke(webViewAttributes);
		if (forDisplay)
		{
			webViewAttributes.ReadOnly = true;
		}
		TagBuilder val = (webViewAttributes.RenderContainer ? html.PropertyCaptionContainerTagBuilder(((HtmlString)(object)html.PropertyCaptionContainerId(expression, webViewAttributes)).ToHtmlString(), webViewAttributes.ContainerTagName, webViewAttributes) : null);
		if (val != null && webViewAttributes.ContainerBuilderAction != null)
		{
			webViewAttributes.ContainerBuilderAction(val);
		}
		return PropertyPartHelper(PropertyPart.Caption, html, expression, webViewAttributes, val);
	}

	public static MvcHtmlString Caption(this HtmlHelper html, string expression, PropertyViewItem propViewItem, Action<WebViewAttributes> viewAttributesAction, bool forDisplay = false)
	{
		WebViewAttributes webViewAttributes = new WebViewAttributes();
		if (propViewItem != null)
		{
			webViewAttributes.CopyFrom(propViewItem.Attributes);
		}
		ApplyObjectViewData(webViewAttributes, ModelMetadata.FromStringExpression(expression, html.get_ViewData()), propViewItem, forDisplay);
		viewAttributesAction?.Invoke(webViewAttributes);
		if (forDisplay)
		{
			webViewAttributes.ReadOnly = true;
		}
		TagBuilder val = (webViewAttributes.RenderContainer ? html.PropertyCaptionContainerTagBuilder(((HtmlString)(object)html.PropertyCaptionContainerId(expression, webViewAttributes)).ToHtmlString(), webViewAttributes.ContainerTagName, webViewAttributes) : null);
		if (val != null && webViewAttributes.ContainerBuilderAction != null)
		{
			webViewAttributes.ContainerBuilderAction(val);
		}
		return PropertyPartHelper(PropertyPart.Caption, html, expression, webViewAttributes, val);
	}

	public static MvcHtmlString Description<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression, Action<WebViewAttributes> viewAttributesAction = null)
	{
		WebViewAttributes webViewAttributes = new WebViewAttributes();
		ApplyObjectViewData(webViewAttributes, ModelMetadata.FromLambdaExpression<TModel, TValue>(expression, html.get_ViewData()), null, forceReadOnly: false, new PropertyDescriptionViewItem());
		viewAttributesAction?.Invoke(webViewAttributes);
		TagBuilder val = (webViewAttributes.RenderContainer ? ((HtmlHelper)(object)html).PropertyDescriptionContainerTagBuilder(((HtmlString)(object)html.PropertyDescriptionContainerId(expression, webViewAttributes)).ToHtmlString(), webViewAttributes.ContainerTagName, webViewAttributes) : null);
		if (val != null && webViewAttributes.ContainerBuilderAction != null)
		{
			webViewAttributes.ContainerBuilderAction(val);
		}
		return PropertyPartHelper(PropertyPart.Description, html, expression, webViewAttributes, val);
	}

	public static MvcHtmlString Description(this HtmlHelper html, string expression, Action<WebViewAttributes> viewAttributesAction = null)
	{
		WebViewAttributes webViewAttributes = new WebViewAttributes();
		ApplyObjectViewData(webViewAttributes, ModelMetadata.FromStringExpression(expression, html.get_ViewData()), null, forceReadOnly: false, new PropertyDescriptionViewItem());
		viewAttributesAction?.Invoke(webViewAttributes);
		TagBuilder val = (webViewAttributes.RenderContainer ? html.PropertyDescriptionContainerTagBuilder(((HtmlString)(object)html.PropertyDescriptionContainerId(expression, webViewAttributes)).ToHtmlString(), webViewAttributes.ContainerTagName, webViewAttributes) : null);
		if (val != null && webViewAttributes.ContainerBuilderAction != null)
		{
			webViewAttributes.ContainerBuilderAction(val);
		}
		return PropertyPartHelper(PropertyPart.Description, html, expression, webViewAttributes, val);
	}

	public static MvcHtmlString Description(this HtmlHelper html, string expression, PropertyViewItem propViewItem, Action<WebViewAttributes> viewAttributesAction)
	{
		WebViewAttributes webViewAttributes = new WebViewAttributes();
		if (propViewItem != null)
		{
			webViewAttributes.CopyFrom(propViewItem.Attributes);
		}
		ApplyObjectViewData(webViewAttributes, ModelMetadata.FromStringExpression(expression, html.get_ViewData()), propViewItem);
		viewAttributesAction?.Invoke(webViewAttributes);
		TagBuilder val = (webViewAttributes.RenderContainer ? html.PropertyDescriptionContainerTagBuilder(((HtmlString)(object)html.PropertyDescriptionContainerId(expression, webViewAttributes)).ToHtmlString(), webViewAttributes.ContainerTagName, webViewAttributes) : null);
		if (val != null && webViewAttributes.ContainerBuilderAction != null)
		{
			webViewAttributes.ContainerBuilderAction(val);
		}
		return PropertyPartHelper(PropertyPart.Description, html, expression, webViewAttributes, val);
	}

	public static MvcHtmlString DisplayChanges<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expressionOld, Expression<Func<TModel, TValue>> expressionNew, Action<WebViewAttributes> viewAttributesActionOld = null, Action<WebViewAttributes> viewAttributesActionNew = null)
	{
		return ((HtmlHelper)(object)html).DisplayChanges(ExpressionHelper.GetExpressionText((LambdaExpression)expressionOld), ExpressionHelper.GetExpressionText((LambdaExpression)expressionNew), viewAttributesActionOld, viewAttributesActionNew);
	}

	public static MvcHtmlString DisplayChanges(this HtmlHelper html, string expressionOld, string expressionNew, Action<WebViewAttributes> viewAttributesActionOld = null, Action<WebViewAttributes> viewAttributesActionNew = null)
	{
		ModelMetadata mdOld = ModelMetadata.FromStringExpression(expressionOld, html.get_ViewData());
		ModelMetadata mdNew = ModelMetadata.FromStringExpression(expressionNew, html.get_ViewData());
		if (mdOld != null && mdNew != null && !object.Equals(mdOld.get_Model(), mdNew.get_Model()))
		{
			IHistoryPropertyRowDisplay historyPropertyRowDisplay = (from p in Locator.GetServiceNotNull<IEnumerable<IHistoryPropertyRowDisplay>>()
				where p.CanDisplay(mdOld, mdNew)
				select p).FirstOrDefault();
			PropertyChangesRow propertyChangesRow = new PropertyChangesRow
			{
				Caption = html.Caption(expressionOld, delegate(WebViewAttributes a)
				{
					a.ReadOnly = true;
				}),
				OldValue = html.Display(expressionOld, viewAttributesActionOld),
				NewValue = html.Display(expressionNew, viewAttributesActionNew),
				OldState = mdOld.get_Model(),
				NewState = mdNew.get_Model()
			};
			if (historyPropertyRowDisplay != null)
			{
				return historyPropertyRowDisplay.DisplayChanges(html, mdOld, mdNew, propertyChangesRow);
			}
			return PartialExtensions.Partial(html, "Templates/PropertyChangesRow", (object)propertyChangesRow);
		}
		return MvcHtmlString.Empty;
	}

	public static MvcHtmlString DisplayChanges(this HtmlHelper html, IEntity entityOld, IEntity entityNew, List<Guid> exceptions = null, bool fullView = false, Func<string, IEntity, IEntity, MvcHtmlString> f = null)
	{
		if (entityOld == null || entityNew == null)
		{
			return MvcHtmlString.Empty;
		}
		ClassMetadata obj = (ClassMetadata)MetadataLoader.LoadMetadata(entityOld.GetType());
		ClassMetadata classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(entityNew.GetType());
		EntityChangesTable entityChangesTable = new EntityChangesTable
		{
			EntityOld = entityOld,
			EntityNew = entityNew,
			FullView = fullView
		};
		foreach (PropertyMetadata propertyOld in obj.Properties)
		{
			if (exceptions != null && exceptions.Contains(propertyOld.Uid))
			{
				continue;
			}
			PropertyMetadata propertyMetadata = classMetadata.Properties.FirstOrDefault((PropertyMetadata p) => p.Uid == propertyOld.Uid);
			if (propertyMetadata == null)
			{
				continue;
			}
			object propertyValue = entityOld.GetPropertyValue(propertyOld.Uid);
			object propertyValue2 = entityNew.GetPropertyValue(propertyMetadata.Uid);
			bool flag = false;
			if (propertyValue != null && propertyValue2 != null)
			{
				flag = (propertyValue is IEnumerable && !(propertyValue is string)) || object.Equals(propertyValue, propertyValue2);
			}
			else if (propertyValue == null && propertyValue2 == null)
			{
				flag = true;
			}
			if (!flag)
			{
				if (f != null)
				{
					MvcHtmlString val = f(propertyOld.Name, entityOld, entityNew);
					entityChangesTable.Rows.Add((val == null) ? new EntityChangesRow
					{
						Name = propertyOld.Name
					} : new EntityChangesRow
					{
						Value = val
					});
				}
				else
				{
					entityChangesTable.Rows.Add(new EntityChangesRow
					{
						Name = propertyOld.Name
					});
				}
			}
		}
		return PartialExtensions.Partial(html, "Templates/EntityChangesTable", (object)entityChangesTable);
	}

	public static MvcHtmlString ModernHidden<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression, object additionalData = null)
	{
		return html.ModernHidden(expression, new RouteValueDictionary(additionalData));
	}

	public static MvcHtmlString ModernHiddenFor(this HtmlHelper html, string expression, object value, object additionalData = null)
	{
		return html.ModernHiddenFor(expression, value, new RouteValueDictionary(additionalData));
	}

	public static MvcHtmlString ModernHidden<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression, IDictionary<string, object> additionalData)
	{
		ModelMetadata val = ModelMetadata.FromLambdaExpression<TModel, TValue>(expression, html.get_ViewData());
		if (val != null)
		{
			string expressionText = ExpressionHelper.GetExpressionText((LambdaExpression)expression);
			return ((HtmlHelper)(object)html).ModernHiddenFor(expressionText, val.get_Model(), additionalData);
		}
		return InputExtensions.HiddenFor<TModel, TValue>(html, expression);
	}

	public static MvcHtmlString ModernHiddenFor(this HtmlHelper html, string expression, object value, IDictionary<string, object> additionalData)
	{
		Dictionary<string, object> addtionalData = (from kv in ((IEnumerable<KeyValuePair<string, object>>)html.get_ViewData()).Concat(new RouteValueDictionary(additionalData))
			group kv by kv.Key).ToDictionary((IGrouping<string, KeyValuePair<string, object>> kv) => kv.Key, (IGrouping<string, KeyValuePair<string, object>> kv) => kv.Last().Value);
		IHiddenInputRenderer hiddenInputRenderer = ComponentManager.Current.GetExtensionPoints<IHiddenInputRenderer>().FirstOrDefault((IHiddenInputRenderer r) => r.CanRender(html, expression, value, addtionalData));
		if (hiddenInputRenderer == null)
		{
			return InputExtensions.Hidden(html, expression, value);
		}
		return hiddenInputRenderer.Hidden(html, expression, value, addtionalData);
	}

	public static MvcHtmlString Display<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression, Action<WebViewAttributes> viewAttributesAction = null)
	{
		WebViewAttributes webViewAttributes = new WebViewAttributes();
		ApplyObjectViewData(webViewAttributes, ModelMetadata.FromLambdaExpression<TModel, TValue>(expression, html.get_ViewData()), null, forceReadOnly: true, new PropertyValueViewItem());
		viewAttributesAction?.Invoke(webViewAttributes);
		webViewAttributes.ReadOnly = true;
		TagBuilder val = (webViewAttributes.RenderContainer ? ((HtmlHelper)(object)html).PropertyValueContainerTagBuilder(((HtmlString)(object)html.PropertyValueContainerId(expression, webViewAttributes)).ToHtmlString(), webViewAttributes.ContainerTagName, webViewAttributes) : null);
		if (val != null && webViewAttributes.ContainerBuilderAction != null)
		{
			webViewAttributes.ContainerBuilderAction(val);
		}
		return PropertyPartHelper(PropertyPart.Value, html, expression, webViewAttributes, val);
	}

	public static MvcHtmlString Display(this HtmlHelper html, string expression, Action<WebViewAttributes> viewAttributesAction = null)
	{
		WebViewAttributes webViewAttributes = new WebViewAttributes();
		ApplyObjectViewData(webViewAttributes, ModelMetadata.FromStringExpression(expression, html.get_ViewData()), null, forceReadOnly: true, new PropertyValueViewItem());
		viewAttributesAction?.Invoke(webViewAttributes);
		webViewAttributes.ReadOnly = true;
		TagBuilder val = (webViewAttributes.RenderContainer ? html.PropertyValueContainerTagBuilder(((HtmlString)(object)html.PropertyValueContainerId(expression, webViewAttributes)).ToHtmlString(), webViewAttributes.ContainerTagName, webViewAttributes) : null);
		if (val != null && webViewAttributes.ContainerBuilderAction != null)
		{
			webViewAttributes.ContainerBuilderAction(val);
		}
		return PropertyPartHelper(PropertyPart.Value, html, expression, webViewAttributes, val);
	}

	public static MvcHtmlString Editor<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression, Action<WebViewAttributes> viewAttributesAction = null)
	{
		WebViewAttributes webViewAttributes = new WebViewAttributes();
		ApplyObjectViewData(webViewAttributes, ModelMetadata.FromLambdaExpression<TModel, TValue>(expression, html.get_ViewData()), null, forceReadOnly: false, new PropertyValueViewItem());
		viewAttributesAction?.Invoke(webViewAttributes);
		webViewAttributes.ReadOnly = false;
		TagBuilder val = (webViewAttributes.RenderContainer ? ((HtmlHelper)(object)html).PropertyValueContainerTagBuilder(((HtmlString)(object)html.PropertyValueContainerId(expression, webViewAttributes)).ToHtmlString(), webViewAttributes.ContainerTagName, webViewAttributes) : null);
		if (val != null && webViewAttributes.ContainerBuilderAction != null)
		{
			webViewAttributes.ContainerBuilderAction(val);
		}
		return PropertyPartHelper(PropertyPart.Value, html, expression, webViewAttributes, val);
	}

	public static MvcHtmlString Editor(this HtmlHelper html, string expression, Action<WebViewAttributes> viewAttributesAction = null)
	{
		WebViewAttributes webViewAttributes = new WebViewAttributes();
		ApplyObjectViewData(webViewAttributes, ModelMetadata.FromStringExpression(expression, html.get_ViewData()), null, forceReadOnly: false, new PropertyValueViewItem());
		viewAttributesAction?.Invoke(webViewAttributes);
		webViewAttributes.ReadOnly = false;
		TagBuilder val = (webViewAttributes.RenderContainer ? html.PropertyValueContainerTagBuilder(((HtmlString)(object)html.PropertyValueContainerId(expression, webViewAttributes)).ToHtmlString(), webViewAttributes.ContainerTagName, webViewAttributes) : null);
		if (val != null && webViewAttributes.ContainerBuilderAction != null)
		{
			webViewAttributes.ContainerBuilderAction(val);
		}
		return PropertyPartHelper(PropertyPart.Value, html, expression, webViewAttributes, val);
	}

	public static MvcHtmlString EditorOrDisplay(this HtmlHelper html, string expression, Action<WebViewAttributes> viewAttributesAction = null)
	{
		WebViewAttributes webViewAttributes = new WebViewAttributes();
		webViewAttributes.ReadOnly = false;
		ApplyObjectViewData(webViewAttributes, ModelMetadata.FromStringExpression(expression, html.get_ViewData()), null, forceReadOnly: false, new PropertyValueViewItem());
		viewAttributesAction?.Invoke(webViewAttributes);
		TagBuilder val = (webViewAttributes.RenderContainer ? html.PropertyValueContainerTagBuilder(((HtmlString)(object)html.PropertyValueContainerId(expression, webViewAttributes)).ToHtmlString(), webViewAttributes.ContainerTagName, webViewAttributes) : null);
		if (val != null && webViewAttributes.ContainerBuilderAction != null)
		{
			webViewAttributes.ContainerBuilderAction(val);
		}
		return PropertyPartHelper(PropertyPart.Value, html, expression, webViewAttributes, val);
	}

	public static MvcHtmlString EditorOrDisplay(this HtmlHelper html, string expression, PropertyViewItem propViewItem)
	{
		WebViewAttributes webViewAttributes = new WebViewAttributes();
		webViewAttributes.ReadOnly = true;
		if (propViewItem != null)
		{
			webViewAttributes.CopyFrom(propViewItem.Attributes);
		}
		ApplyObjectViewData(webViewAttributes, ModelMetadata.FromStringExpression(expression, html.get_ViewData()), propViewItem);
		TagBuilder val = (webViewAttributes.RenderContainer ? html.PropertyValueContainerTagBuilder(((HtmlString)(object)html.PropertyValueContainerId(expression, webViewAttributes)).ToHtmlString(), webViewAttributes.ContainerTagName, webViewAttributes) : null);
		if (val != null && webViewAttributes.ContainerBuilderAction != null)
		{
			webViewAttributes.ContainerBuilderAction(val);
		}
		return PropertyPartHelper(PropertyPart.Value, html, expression, webViewAttributes, val);
	}

	public static MvcHtmlString EditorOrDisplay(this HtmlHelper html, string expression, PropertyViewItem propViewItem, Action<WebViewAttributes> viewAttributesAction)
	{
		WebViewAttributes webViewAttributes = new WebViewAttributes();
		webViewAttributes.ReadOnly = true;
		if (propViewItem != null)
		{
			webViewAttributes.CopyFrom(propViewItem.Attributes);
		}
		ApplyObjectViewData(webViewAttributes, ModelMetadata.FromStringExpression(expression, html.get_ViewData()), propViewItem);
		viewAttributesAction?.Invoke(webViewAttributes);
		TagBuilder val = (webViewAttributes.RenderContainer ? html.PropertyValueContainerTagBuilder(((HtmlString)(object)html.PropertyValueContainerId(expression, webViewAttributes)).ToHtmlString(), webViewAttributes.ContainerTagName, webViewAttributes) : null);
		if (val != null && webViewAttributes.ContainerBuilderAction != null)
		{
			webViewAttributes.ContainerBuilderAction(val);
		}
		return PropertyPartHelper(PropertyPart.Value, html, expression, webViewAttributes, val);
	}

	public static MvcHtmlString EditorOrDisplay<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression, Action<WebViewAttributes> viewAttributesAction = null)
	{
		WebViewAttributes webViewAttributes = new WebViewAttributes();
		webViewAttributes.ReadOnly = false;
		ApplyObjectViewData(webViewAttributes, ModelMetadata.FromLambdaExpression<TModel, TValue>(expression, html.get_ViewData()), null, forceReadOnly: false, new PropertyValueViewItem());
		viewAttributesAction?.Invoke(webViewAttributes);
		TagBuilder val = (webViewAttributes.RenderContainer ? ((HtmlHelper)(object)html).PropertyValueContainerTagBuilder(((HtmlString)(object)html.PropertyValueContainerId(expression, webViewAttributes)).ToHtmlString(), webViewAttributes.ContainerTagName, webViewAttributes) : null);
		if (val != null && webViewAttributes.ContainerBuilderAction != null)
		{
			webViewAttributes.ContainerBuilderAction(val);
		}
		return PropertyPartHelper(PropertyPart.Value, html, expression, webViewAttributes, val);
	}

	public static MvcHtmlString Property<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression, Action<WebViewAttributes> viewAttributesAction = null)
	{
		WebViewAttributes webViewAttributes = new WebViewAttributes();
		webViewAttributes.ReadOnly = true;
		ApplyObjectViewData(webViewAttributes, ModelMetadata.FromLambdaExpression<TModel, TValue>(expression, html.get_ViewData()));
		viewAttributesAction?.Invoke(webViewAttributes);
		return PropertyHelper(html, expression, null, webViewAttributes);
	}

	public static MvcHtmlString Property<TModel>(this HtmlHelper<TModel> html, string expression, Action<WebViewAttributes> viewAttributesAction = null)
	{
		WebViewAttributes webViewAttributes = new WebViewAttributes();
		webViewAttributes.ReadOnly = true;
		ApplyObjectViewData(webViewAttributes, ModelMetadata.FromStringExpression(expression, (ViewDataDictionary)(object)html.get_ViewData()));
		viewAttributesAction?.Invoke(webViewAttributes);
		return PropertyHelper<TModel>(html, expression, webViewAttributes);
	}

	public static MvcHtmlString Property(this HtmlHelper html, string expression, Action<WebViewAttributes> viewAttributesAction = null)
	{
		WebViewAttributes webViewAttributes = new WebViewAttributes();
		webViewAttributes.ReadOnly = true;
		ApplyObjectViewData(webViewAttributes, ModelMetadata.FromStringExpression(expression, html.get_ViewData()));
		viewAttributesAction?.Invoke(webViewAttributes);
		return PropertyHelper(html, expression, webViewAttributes);
	}

	public static MvcHtmlString Property(this HtmlHelper html, string expression, PropertyViewItem propViewItem)
	{
		WebViewAttributes webViewAttributes = new WebViewAttributes();
		webViewAttributes.ReadOnly = true;
		bool needHidden = true;
		if (propViewItem != null)
		{
			webViewAttributes.CopyFrom(propViewItem.Attributes);
			needHidden = propViewItem.IsMainPropertyViewItem();
		}
		ApplyObjectViewData(webViewAttributes, ModelMetadata.FromStringExpression(expression, html.get_ViewData()), propViewItem);
		return PropertyHelper(html, expression, webViewAttributes, containerContent: false, needHidden);
	}

	public static MvcHtmlString Property(this HtmlHelper html, string expression, PropertyViewItem propViewItem, Action<WebViewAttributes> viewAttributesAction)
	{
		WebViewAttributes webViewAttributes = new WebViewAttributes();
		webViewAttributes.ReadOnly = true;
		bool needHidden = true;
		if (propViewItem != null)
		{
			webViewAttributes.CopyFrom(propViewItem.Attributes);
			needHidden = propViewItem.IsMainPropertyViewItem();
		}
		ApplyObjectViewData(webViewAttributes, ModelMetadata.FromStringExpression(expression, html.get_ViewData()), propViewItem);
		viewAttributesAction?.Invoke(webViewAttributes);
		return PropertyHelper(html, expression, webViewAttributes, containerContent: false, needHidden);
	}

	public static MvcHtmlString PropertyValueContainerContent(this HtmlHelper html, string expression, PropertyViewItem propViewItem, Action<WebViewAttributes> viewAttributesAction)
	{
		WebViewAttributes webViewAttributes = new WebViewAttributes();
		webViewAttributes.ReadOnly = true;
		bool needHidden = true;
		if (propViewItem != null)
		{
			webViewAttributes.CopyFrom(propViewItem.Attributes);
			needHidden = propViewItem.IsMainPropertyViewItem();
		}
		ApplyObjectViewData(webViewAttributes, ModelMetadata.FromStringExpression(expression, html.get_ViewData()), propViewItem);
		viewAttributesAction?.Invoke(webViewAttributes);
		return PropertyHelper(html, expression, webViewAttributes, containerContent: true, needHidden);
	}

	public static MvcHtmlString CombinedEditableProperty<TModel>(this HtmlHelper<TModel> html, string expression, Action<WebViewAttributes> viewAttributesAction = null, Func<dynamic, HelperResult> editorTemplate = null)
	{
		return new CombinedEditablePropertyBuilder<TModel>(html).ButtonText(ModelMetadata.FromStringExpression(expression, (ViewDataDictionary)(object)html.get_ViewData()).GetPropertyMetadata().DisplayName).Add(expression, viewAttributesAction, editorTemplate).Render();
	}

	public static MvcHtmlString CombinedEditableProperty<TModel>(this HtmlHelper<TModel> html, Expression<Func<TModel, dynamic>> expression, Action<WebViewAttributes> viewAttributesAction = null, Func<dynamic, HelperResult> editorTemplate = null)
	{
		return new CombinedEditablePropertyBuilder<TModel>(html).ButtonText(ModelMetadata.FromLambdaExpression<TModel, object>((Expression<Func<TModel, object>>)expression, html.get_ViewData()).GetPropertyMetadata().DisplayName).Add(expression, viewAttributesAction, editorTemplate).Render();
	}

	public static CombinedEditablePropertyBuilder<TModel> CombinedEditableProperty<TModel>(this HtmlHelper<TModel> html)
	{
		return new CombinedEditablePropertyBuilder<TModel>(html);
	}

	public static MvcHtmlString CombinedEditableProperty<TModel>(this HtmlHelper<TModel> html, string buttonText, Action<WebViewAttributes> commonViewAttributesAction, IList<CombinedContentModel<TModel>> contents, bool onlyContent = false)
	{
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected O, but got Unknown
		CombinedPropertyValueModel combinedPropertyValueModel = new CombinedPropertyValueModel();
		combinedPropertyValueModel.Content = new List<CombinedMarkupContentModel>();
		WebViewAttributes webViewAttributes = new WebViewAttributes();
		commonViewAttributesAction?.Invoke(webViewAttributes);
		if (onlyContent)
		{
			webViewAttributes.Html.AddClass("combined-control hidden-control");
		}
		else
		{
			webViewAttributes.TrClass += "combined-control hidden-control";
		}
		combinedPropertyValueModel.ButtonText = webViewAttributes.LocalizableName ?? buttonText;
		combinedPropertyValueModel.Attributes = webViewAttributes;
		EleWise.ELMA.Web.Mvc.Models.PropertyRowModel propertyRowModel = new EleWise.ELMA.Web.Mvc.Models.PropertyRowModel();
		List<string> list = new List<string>();
		foreach (CombinedContentModel<TModel> content in contents)
		{
			CombinedMarkupContentModel combinedMarkupContentModel = new CombinedMarkupContentModel();
			WebViewAttributes webViewAttributes2 = new WebViewAttributes();
			ModelMetadata val = null;
			if (content.Expression != null || !string.IsNullOrEmpty(content.ExpressionText))
			{
				string expressionText;
				if (content.Expression != null)
				{
					val = ModelMetadata.FromLambdaExpression<TModel, object>((Expression<Func<TModel, object>>)content.Expression, html.get_ViewData());
					expressionText = ExpressionHelper.GetExpressionText((LambdaExpression)content.Expression);
				}
				else
				{
					val = ModelMetadata.FromStringExpression(content.ExpressionText, (ViewDataDictionary)(object)html.get_ViewData());
					expressionText = content.ExpressionText;
				}
				ApplyObjectViewData(webViewAttributes2, val);
				if (content.ViewAttributesAction != null)
				{
					content.ViewAttributesAction(webViewAttributes2);
				}
				webViewAttributes2.ReadOnly = false;
				combinedMarkupContentModel.ExpressionMarkup = (MvcHtmlString)((content.EditorTemplate != null) ? ((object)new MvcHtmlString(content.EditorTemplate(val).ToHtmlString())) : ((object)PropertyPartHelper(PropertyPart.Value, (HtmlHelper)(object)html, val, expressionText, webViewAttributes2)));
				list.Add(((HtmlHelper)html).get_ViewContext().get_ViewData().get_TemplateInfo()
					.GetFullHtmlFieldName(expressionText));
			}
			else if (content.ViewAttributesAction != null)
			{
				content.ViewAttributesAction(webViewAttributes2);
			}
			if (content.СustomMarkup != null)
			{
				combinedMarkupContentModel.СustomMarkup = new MvcHtmlString(content.СustomMarkup(val).ToHtmlString());
			}
			combinedMarkupContentModel.Attributes = webViewAttributes2;
			combinedPropertyValueModel.Content.Add(combinedMarkupContentModel);
		}
		propertyRowModel.ModelName = string.Join("_", list);
		propertyRowModel.Caption = MvcHtmlString.Create(combinedPropertyValueModel.ButtonText);
		propertyRowModel.Description = MvcHtmlString.Empty;
		propertyRowModel.Value = PartialExtensions.Partial((HtmlHelper)(object)html, "Templates/PropertyValueBehindButton", (object)combinedPropertyValueModel);
		propertyRowModel.ViewAttributes = webViewAttributes;
		propertyRowModel.OnlyValueContainerContent = onlyContent;
		return PartialExtensions.Partial((HtmlHelper)(object)html, "Templates/PropertyRow", (object)propertyRowModel);
	}

	public static MvcHtmlString EditableProperty<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression, Action<WebViewAttributes> viewAttributesAction = null, Func<dynamic, HelperResult> editorTemplate = null)
	{
		WebViewAttributes webViewAttributes = new WebViewAttributes();
		ApplyObjectViewData(webViewAttributes, ModelMetadata.FromLambdaExpression<TModel, TValue>(expression, html.get_ViewData()));
		viewAttributesAction?.Invoke(webViewAttributes);
		webViewAttributes.ReadOnly = false;
		return PropertyHelper(html, expression, editorTemplate, webViewAttributes);
	}

	public static MvcHtmlString EditableProperty<TModel>(this HtmlHelper<TModel> html, string expression, Action<WebViewAttributes> viewAttributesAction = null)
	{
		WebViewAttributes webViewAttributes = new WebViewAttributes();
		ApplyObjectViewData(webViewAttributes, ModelMetadata.FromStringExpression(expression, (ViewDataDictionary)(object)html.get_ViewData()));
		viewAttributesAction?.Invoke(webViewAttributes);
		webViewAttributes.ReadOnly = false;
		return PropertyHelper<TModel>(html, expression, webViewAttributes);
	}

	public static MvcHtmlString EditableProperty(this HtmlHelper html, string expression, Action<WebViewAttributes> viewAttributesAction = null)
	{
		WebViewAttributes webViewAttributes = new WebViewAttributes();
		ApplyObjectViewData(webViewAttributes, ModelMetadata.FromStringExpression(expression, html.get_ViewData()));
		viewAttributesAction?.Invoke(webViewAttributes);
		webViewAttributes.ReadOnly = false;
		return PropertyHelper(html, expression, webViewAttributes);
	}

	public static MvcHtmlString RequiredProperty<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression, Action<WebViewAttributes> viewAttributesAction = null)
	{
		WebViewAttributes webViewAttributes = new WebViewAttributes();
		ApplyObjectViewData(webViewAttributes, ModelMetadata.FromLambdaExpression<TModel, TValue>(expression, html.get_ViewData()));
		viewAttributesAction?.Invoke(webViewAttributes);
		webViewAttributes.ReadOnly = false;
		webViewAttributes.Required = true;
		return PropertyHelper(html, expression, null, webViewAttributes);
	}

	public static MvcHtmlString RequiredProperty<TModel, TValue>(this HtmlHelper<TModel> html, string expression, Action<WebViewAttributes> viewAttributesAction = null)
	{
		WebViewAttributes webViewAttributes = new WebViewAttributes();
		ApplyObjectViewData(webViewAttributes, ModelMetadata.FromStringExpression(expression, (ViewDataDictionary)(object)html.get_ViewData()));
		viewAttributesAction?.Invoke(webViewAttributes);
		webViewAttributes.ReadOnly = false;
		webViewAttributes.Required = true;
		return PropertyHelper<TModel>(html, expression, webViewAttributes);
	}

	public static string PropertyContainerBaseId(string modelId, WebViewAttributes viewAttributes)
	{
		return modelId + ((viewAttributes != null && viewAttributes.NeedPostfix && viewAttributes.ViewItemUid.HasValue) ? ("_" + viewAttributes.ViewItemUid.ToString().Replace('-', '_')) : "");
	}

	public static MvcHtmlString PropertyContainerId(string modelId, WebViewAttributes viewAttributes = null)
	{
		return MvcHtmlString.Create(PropertyContainerBaseId(modelId, viewAttributes) + "_Container");
	}

	public static MvcHtmlString PropertyContainerId(this HtmlHelper html, string expression, WebViewAttributes viewAttributes = null)
	{
		return PropertyContainerId(html.GetModelId(expression), viewAttributes);
	}

	public static MvcHtmlString PropertyContainerId<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression, WebViewAttributes viewAttributes = null)
	{
		return ((HtmlHelper)(object)html).PropertyContainerId(ExpressionHelper.GetExpressionText((LambdaExpression)expression), viewAttributes);
	}

	public static TagBuilder PropertyContainerTagBuilder(this HtmlHelper html, string id, string tagName, WebViewAttributes viewAttributes)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		TagBuilder val = new TagBuilder(string.IsNullOrWhiteSpace(tagName) ? "tr" : tagName);
		val.get_Attributes()["id"] = id;
		if (!string.IsNullOrEmpty(viewAttributes.TrClass))
		{
			val.get_Attributes()["class"] = viewAttributes.TrClass;
		}
		if (!viewAttributes.Visible)
		{
			val.get_Attributes()["style"] = "display:none;";
		}
		if (viewAttributes.ContainerBuilderAction != null)
		{
			viewAttributes.ContainerBuilderAction(val);
		}
		return val;
	}

	public static IDisposable PropertyContainer(this HtmlHelper html, string expression, string tagName = null, Action<TagBuilder> builderAction = null)
	{
		WebViewAttributes webViewAttributes = new WebViewAttributes();
		ApplyObjectViewData(webViewAttributes, ModelMetadata.FromStringExpression(expression, html.get_ViewData()));
		TagBuilder val = html.PropertyContainerTagBuilder(((HtmlString)(object)html.PropertyContainerId(expression, webViewAttributes)).ToHtmlString(), tagName, webViewAttributes);
		builderAction?.Invoke(val);
		return new StartEndTemplate(html.get_ViewContext(), val.ToString((TagRenderMode)1), val.ToString((TagRenderMode)2));
	}

	public static IDisposable PropertyContainer<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression, string tagName = null, Action<TagBuilder> builderAction = null)
	{
		return ((HtmlHelper)(object)html).PropertyContainer(ExpressionHelper.GetExpressionText((LambdaExpression)expression), tagName, builderAction);
	}

	public static MvcHtmlString PropertyCaptionContainerId(string modelId, WebViewAttributes viewAttributes = null)
	{
		return MvcHtmlString.Create(PropertyContainerBaseId(modelId, viewAttributes) + "_CaptionContainer");
	}

	public static MvcHtmlString PropertyCaptionContainerId(this HtmlHelper html, string expression, WebViewAttributes viewAttributes = null)
	{
		return PropertyCaptionContainerId(html.GetModelId(expression), viewAttributes);
	}

	public static MvcHtmlString PropertyCaptionContainerId<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression, WebViewAttributes viewAttributes = null)
	{
		return ((HtmlHelper)(object)html).PropertyCaptionContainerId(ExpressionHelper.GetExpressionText((LambdaExpression)expression), viewAttributes);
	}

	public static TagBuilder PropertyCaptionContainerTagBuilder(this HtmlHelper html, string id, string tagName, WebViewAttributes viewAttributes)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		TagBuilder val = new TagBuilder(string.IsNullOrWhiteSpace(tagName) ? "td" : tagName);
		val.get_Attributes()["id"] = id;
		val.get_Attributes()["style"] = "white-space:pre-line;";
		val.AddCssClass("captionCell");
		if (!string.IsNullOrEmpty(viewAttributes.Class))
		{
			val.AddCssClass(viewAttributes.Class);
		}
		if (!string.IsNullOrEmpty(viewAttributes.LabelStyle))
		{
			val.get_Attributes()["style"] += viewAttributes.LabelStyle;
		}
		if (!viewAttributes.Visible)
		{
			val.get_Attributes()["style"] += "display:none;";
		}
		if (viewAttributes.ContainerBuilderAction != null)
		{
			viewAttributes.ContainerBuilderAction(val);
		}
		return val;
	}

	public static IDisposable PropertyCaptionContainer(this HtmlHelper html, string expression, string tagName = null, Action<TagBuilder> builderAction = null)
	{
		WebViewAttributes webViewAttributes = new WebViewAttributes();
		ApplyObjectViewData(webViewAttributes, ModelMetadata.FromStringExpression(expression, html.get_ViewData()), null, forceReadOnly: false, new PropertyCaptionViewItem());
		TagBuilder val = html.PropertyCaptionContainerTagBuilder(((HtmlString)(object)html.PropertyCaptionContainerId(expression, webViewAttributes)).ToHtmlString(), tagName, webViewAttributes);
		builderAction?.Invoke(val);
		return new StartEndTemplate(html.get_ViewContext(), val.ToString((TagRenderMode)1), val.ToString((TagRenderMode)2));
	}

	public static IDisposable PropertyCaptionContainer<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression, string tagName = null, Action<TagBuilder> builderAction = null)
	{
		return ((HtmlHelper)(object)html).PropertyCaptionContainer(ExpressionHelper.GetExpressionText((LambdaExpression)expression), tagName, builderAction);
	}

	public static MvcHtmlString PropertyValueContainerId(string modelId, WebViewAttributes viewAttributes = null)
	{
		return MvcHtmlString.Create(PropertyContainerBaseId(modelId, viewAttributes) + "_ValueContainer");
	}

	public static MvcHtmlString PropertyValueContainerId(this HtmlHelper html, string expression, WebViewAttributes viewAttributes = null)
	{
		return PropertyValueContainerId(html.GetModelId(expression), viewAttributes);
	}

	public static MvcHtmlString PropertyValueContainerId<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression, WebViewAttributes viewAttributes = null)
	{
		return ((HtmlHelper)(object)html).PropertyValueContainerId(ExpressionHelper.GetExpressionText((LambdaExpression)expression), viewAttributes);
	}

	public static TagBuilder PropertyValueContainerTagBuilder(this HtmlHelper html, string id, string tagName, WebViewAttributes viewAttributes)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		TagBuilder val = new TagBuilder(string.IsNullOrWhiteSpace(tagName) ? "td" : tagName);
		val.get_Attributes()["id"] = id;
		if (val.get_TagName().ToLower() == "td" && viewAttributes.ValueCellColspan > 1)
		{
			val.get_Attributes()["colspan"] = viewAttributes.ValueCellColspan.ToString();
		}
		if (!val.get_Attributes().ContainsKey("style"))
		{
			val.get_Attributes().Add("style", "");
		}
		if (!viewAttributes.Visible)
		{
			val.get_Attributes()["style"] = "display:none;";
		}
		val.get_Attributes()["style"] += (string.IsNullOrEmpty(viewAttributes.ValueStyle) ? "" : viewAttributes.ValueStyle);
		if (viewAttributes.ContainerBuilderAction != null)
		{
			viewAttributes.ContainerBuilderAction(val);
		}
		return val;
	}

	public static IDisposable PropertyValueContainer(this HtmlHelper html, string expression, string tagName = null, Action<TagBuilder> builderAction = null)
	{
		WebViewAttributes webViewAttributes = new WebViewAttributes();
		ApplyObjectViewData(webViewAttributes, ModelMetadata.FromStringExpression(expression, html.get_ViewData()), null, forceReadOnly: false, new PropertyValueViewItem());
		TagBuilder val = html.PropertyValueContainerTagBuilder(((HtmlString)(object)html.PropertyValueContainerId(expression, webViewAttributes)).ToHtmlString(), tagName, webViewAttributes);
		builderAction?.Invoke(val);
		return new StartEndTemplate(html.get_ViewContext(), val.ToString((TagRenderMode)1), val.ToString((TagRenderMode)2));
	}

	public static IDisposable PropertyValueContainer<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression, string tagName = null, Action<TagBuilder> builderAction = null)
	{
		return ((HtmlHelper)(object)html).PropertyValueContainer(ExpressionHelper.GetExpressionText((LambdaExpression)expression), tagName, builderAction);
	}

	public static MvcHtmlString PropertyDescriptionContainerId(string modelId, WebViewAttributes viewAttributes = null)
	{
		return MvcHtmlString.Create(PropertyContainerBaseId(modelId, viewAttributes) + "_DescriptionContainer");
	}

	public static MvcHtmlString PropertyDescriptionContainerId(this HtmlHelper html, string expression, WebViewAttributes viewAttributes = null)
	{
		return PropertyDescriptionContainerId(html.GetModelId(expression), viewAttributes);
	}

	public static MvcHtmlString PropertyDescriptionContainerId<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression, WebViewAttributes viewAttributes = null)
	{
		return ((HtmlHelper)(object)html).PropertyDescriptionContainerId(ExpressionHelper.GetExpressionText((LambdaExpression)expression), viewAttributes);
	}

	public static TagBuilder PropertyDescriptionContainerTagBuilder(this HtmlHelper html, string id, string tagName, WebViewAttributes viewAttributes)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		TagBuilder val = new TagBuilder(string.IsNullOrWhiteSpace(tagName) ? "div" : tagName);
		val.get_Attributes()["id"] = id;
		if (!viewAttributes.Visible)
		{
			val.get_Attributes()["style"] = "display:none;";
		}
		if (viewAttributes.ContainerBuilderAction != null)
		{
			viewAttributes.ContainerBuilderAction(val);
		}
		return val;
	}

	public static IDisposable PropertyDescriptionContainer(this HtmlHelper html, string expression, string tagName = null, Action<TagBuilder> builderAction = null)
	{
		WebViewAttributes webViewAttributes = new WebViewAttributes();
		ApplyObjectViewData(webViewAttributes, ModelMetadata.FromStringExpression(expression, html.get_ViewData()), null, forceReadOnly: false, new PropertyDescriptionViewItem());
		TagBuilder val = html.PropertyDescriptionContainerTagBuilder(((HtmlString)(object)html.PropertyDescriptionContainerId(expression, webViewAttributes)).ToHtmlString(), tagName, webViewAttributes);
		builderAction?.Invoke(val);
		return new StartEndTemplate(html.get_ViewContext(), val.ToString((TagRenderMode)1), val.ToString((TagRenderMode)2));
	}

	public static IDisposable PropertyDescriptionContainer<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression, string tagName = null, Action<TagBuilder> builderAction = null)
	{
		return ((HtmlHelper)(object)html).PropertyDescriptionContainer(ExpressionHelper.GetExpressionText((LambdaExpression)expression), tagName, builderAction);
	}

	public static MvcHtmlString FormViewItem<TModel>(this HtmlHelper<TModel> html, FormView formViewItem, Expression<Func<TModel, object>> expression = null, ActionRoute actionRoute = null, ViewType viewType = ViewType.Custom, ItemType itemType = ItemType.Default, Guid? viewProviderUid = null, string viewItemId = null, Guid? dynamicFormsProviderUid = null, string dynamicFormsProviderData = null, string formId = null)
	{
		return ((HtmlHelper)(object)html).FormViewItem(formViewItem, expression?.Compile()(html.get_ViewData().get_Model()).CastAsRealType(), (expression != null) ? LinqUtils.FullNameOf(expression) : null, actionRoute, viewType, itemType, viewProviderUid, viewItemId, dynamicFormsProviderUid, dynamicFormsProviderData, formId);
	}

	public static MvcHtmlString FormViewItem(this HtmlHelper html, FormView formViewItem, object model = null, string htmlFieldPrefix = null, ActionRoute actionRoute = null, ViewType viewType = ViewType.Custom, ItemType itemType = ItemType.Default, Guid? viewProviderUid = null, string viewItemId = null, Guid? dynamicFormsProviderUid = null, string dynamicFormsProviderData = null, string formId = null)
	{
		if (model == null)
		{
			model = html.get_ViewData().get_Model();
		}
		if (model != null && formViewItem is FormViewItem formViewItem2 && FormRenderHelper.CanRenderRuntimeVersion2(formViewItem2))
		{
			MvcHtmlString val = RenderRuntimeVersion2(html, model, formViewItem2, viewType);
			if (val != null)
			{
				return val;
			}
		}
		ViewType orDefault = ContextVars.GetOrDefault<ViewType>("FormViewItemViewType");
		ContextVars.Set("FormViewItemViewType", viewType);
		ItemType orDefault2 = ContextVars.GetOrDefault<ItemType>("FormViewItemItemType");
		ContextVars.Set("FormViewItemItemType", itemType);
		object orDefault3 = ContextVars.GetOrDefault<object>("FormViewItemEntity");
		ContextVars.Set("FormViewItemEntity", model);
		Guid orDefault4 = ContextVars.GetOrDefault<Guid>("FormViewItemViewProviderUid");
		ContextVars.Set("FormViewItemViewProviderUid", viewProviderUid.HasValue ? viewProviderUid.Value : Guid.Empty);
		string orDefault5 = ContextVars.GetOrDefault<string>("FormViewItemViewItemId");
		ContextVars.Set("FormViewItemViewItemId", viewItemId);
		Guid orDefault6 = ContextVars.GetOrDefault<Guid>("FormViewItemDynamicFormsProviderUid");
		ContextVars.Set("FormViewItemDynamicFormsProviderUid", dynamicFormsProviderUid.HasValue ? dynamicFormsProviderUid.Value : Guid.Empty);
		string orDefault7 = ContextVars.GetOrDefault<string>("FormViewItemDynamicFormsProviderData");
		ContextVars.Set("FormViewItemDynamicFormsProviderData", dynamicFormsProviderData);
		string orDefault8 = ContextVars.GetOrDefault<string>("FormViewItemFormId");
		ContextVars.Set("FormViewItemFormId", formId);
		try
		{
			return RenderViewItem(html, formViewItem, model, htmlFieldPrefix, null, actionRoute);
		}
		finally
		{
			ContextVars.Set("FormViewItemViewType", orDefault);
			ContextVars.Set("FormViewItemItemType", orDefault2);
			ContextVars.Set("FormViewItemEntity", orDefault3);
			ContextVars.Set("FormViewItemViewProviderUid", orDefault4);
			ContextVars.Set("FormViewItemViewItemId", orDefault5);
			ContextVars.Set("FormViewItemDynamicFormsProviderUid", orDefault6);
			ContextVars.Set("FormViewItemDynamicFormsProviderData", orDefault7);
			ContextVars.Set("FormViewItemFormId", orDefault8);
		}
	}

	public static MvcHtmlString ViewItem(this HtmlHelper html, ViewItem viewItem, Func<MvcHtmlString, object> itemTemplate = null)
	{
		return RenderViewItem(html, viewItem, null, null, null, null, itemTemplate);
	}

	public static MvcHtmlString AsyncViewItem(this HtmlHelper html, ViewItem viewItem, object originalModel, object viewModel, string htmlFieldPrefix, ActionRoute actionRoute, ViewType viewType, ItemType itemType, Func<IViewItemRenderer, MvcHtmlString> applyRenderer = null)
	{
		ContextVars.Set("FormViewItemViewType", viewType);
		ContextVars.Set("FormViewItemItemType", itemType);
		ContextVars.Set("FormViewItemEntity", viewModel);
		try
		{
			return RenderViewItem(html, viewItem, delegate(ViewItem vi, ViewItem viParent, object vm, Func<MvcHtmlString, object> it)
			{
				IViewItemRenderer viewItemRenderer = ComponentManager.Current.GetExtensionPoints<IViewItemRenderer>().FirstOrDefault((IViewItemRenderer p) => p.CanRender(vi));
				if (viewItemRenderer == null)
				{
					throw new Exception(SR.T("Не найдена точка расширения для отрисовки элемента представления формы {0}", vi.GetType()));
				}
				return (applyRenderer != null) ? applyRenderer(viewItemRenderer) : viewItemRenderer.RenderSubItems(html, vi, vm);
			}, viewModel, htmlFieldPrefix, originalModel, actionRoute);
		}
		finally
		{
			ContextVars.Remove("FormViewItemViewType");
			ContextVars.Remove("FormViewItemItemType");
			ContextVars.Remove("FormViewItemEntity");
		}
	}

	public static FormViewItem TransformateExtensions(this FormViewItem formViewItem, object model)
	{
		FormViewItem formViewItem2 = formViewItem;
		ComponentManager.Current.GetExtensionPoints<IFormViewItemTransformate>().Each(delegate(IFormViewItemTransformate p)
		{
			formViewItem = p.Transformate(formViewItem, model);
		});
		if (formViewItem2 != formViewItem)
		{
			return formViewItem;
		}
		return (FormViewItem)formViewItem.Clone();
	}

	public static MvcHtmlString TabViewItem(this HtmlHelper html, TabPanelItemsBuilder tabs, TabViewItem tabViewItem, int index)
	{
		TabPanelItemsBuilder orDefault = ContextVars.GetOrDefault<TabPanelItemsBuilder>("TabPanelItemsBuilder");
		ContextVars.Set("TabPanelItemsBuilder", tabs);
		int? orDefault2 = ContextVars.GetOrDefault<int?>("IndexTabViewItemObject");
		ContextVars.Set("IndexTabViewItemObject", (int?)index);
		try
		{
			return html.ViewItem(tabViewItem);
		}
		finally
		{
			ContextVars.Set("TabPanelItemsBuilder", orDefault);
			ContextVars.Set("IndexTabViewItemObject", orDefault2);
		}
	}

	public static MvcHtmlString CustomViewItem(this HtmlHelper html, ICustomViewItem viewItem)
	{
		return html.CustomViewItem(viewItem as ViewItem, viewItem.CustomViewName, viewItem.UseOriginalModel);
	}

	public static MvcHtmlString CustomViewItem(this HtmlHelper html, ViewItem viewItem, string customViewName, bool useOriginalModel = false)
	{
		RootViewItem orDefault = ContextVars.GetOrDefault<RootViewItem>("ViewItemRoot");
		ContextVars.Set("ViewItemRoot", (RootViewItem)viewItem);
		try
		{
			if (!useOriginalModel)
			{
				return PartialExtensions.Partial(html, customViewName);
			}
			object orDefault2 = ContextVars.GetOrDefault<object>("ViewItemModel");
			string orDefault3 = ContextVars.GetOrDefault<string>("ViewItemPrefix");
			string htmlFieldPrefix = html.get_ViewData().get_TemplateInfo().get_HtmlFieldPrefix();
			html.get_ViewData().get_TemplateInfo().set_HtmlFieldPrefix(orDefault3);
			try
			{
				return PartialExtensions.Partial(html, customViewName, orDefault2);
			}
			finally
			{
				html.get_ViewData().get_TemplateInfo().set_HtmlFieldPrefix(htmlFieldPrefix);
			}
		}
		finally
		{
			ContextVars.Set("ViewItemRoot", orDefault);
		}
	}

	public static MvcHtmlString TabCaptionCustomViewItem(this HtmlHelper html, ViewItem viewItem, string customViewName, bool useOriginalModel, out long? counter, out string counterText)
	{
		TabCaptionCounterData data = TabCaptionViewItemControl<object, EleWise.ELMA.Model.Views.TabViewItem>.Data;
		TabCaptionViewItemControl<object, EleWise.ELMA.Model.Views.TabViewItem>.Data = new TabCaptionCounterData();
		try
		{
			return html.CustomViewItem(viewItem, customViewName, useOriginalModel);
		}
		finally
		{
			counter = TabCaptionViewItemControl<object, EleWise.ELMA.Model.Views.TabViewItem>.Data.Counter;
			counterText = TabCaptionViewItemControl<object, EleWise.ELMA.Model.Views.TabViewItem>.Data.CounterText;
			TabCaptionViewItemControl<object, EleWise.ELMA.Model.Views.TabViewItem>.Data = data;
		}
	}

	public static string RowBaseId(string modelId)
	{
		return "Row_" + modelId.Replace('-', '_');
	}

	public static MvcHtmlString RowId(string modelId)
	{
		return MvcHtmlString.Create(RowBaseId(modelId) + "_Container");
	}

	public static TagBuilder RowTagBuilder(this HtmlHelper html, string id, string tagName, WebViewAttributes viewAttributes)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		TagBuilder val = new TagBuilder(string.IsNullOrWhiteSpace(tagName) ? "tr" : tagName);
		val.get_Attributes()["id"] = id;
		if (!string.IsNullOrEmpty(viewAttributes.TrClass))
		{
			val.get_Attributes()["class"] = viewAttributes.TrClass;
		}
		if (!viewAttributes.Visible)
		{
			val.get_Attributes()["style"] = "display:none;";
		}
		if (viewAttributes.ContainerBuilderAction != null)
		{
			viewAttributes.ContainerBuilderAction(val);
		}
		return val;
	}

	public static object Implementation(this object m)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		if (!NHibernateProxyHelper.IsProxy(m))
		{
			return m;
		}
		return ((INHibernateProxy)m).get_HibernateLazyInitializer().GetImplementation();
	}

	public static string Cut(this string m, int length)
	{
		if (string.IsNullOrEmpty(m))
		{
			return "";
		}
		if (m.Length <= length)
		{
			return m;
		}
		return $"{m.Substring(0, length)}...";
	}

	private static MvcHtmlString PropertyHelper<TModel, TValue>(HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression, Func<dynamic, HelperResult> editorTemplate, WebViewAttributes viewAttributes)
	{
		return PropertyHelper(html, ModelMetadata.FromLambdaExpression<TModel, TValue>(expression, html.get_ViewData()), expression, ExpressionHelper.GetExpressionText((LambdaExpression)expression), editorTemplate, viewAttributes);
	}

	private static MvcHtmlString PropertyHelper<TModel>(HtmlHelper<TModel> html, string expression, WebViewAttributes viewAttributes)
	{
		return PropertyHelper<TModel>(html, ModelMetadata.FromStringExpression(expression, (ViewDataDictionary)(object)html.get_ViewData()), expression, expression, viewAttributes);
	}

	private static MvcHtmlString PropertyHelper(HtmlHelper html, string expression, WebViewAttributes viewAttributes, bool containerContent = false, bool needHidden = true)
	{
		ModelMetadata metadata = ModelMetadata.FromStringExpression(expression, html.get_ViewData());
		return PropertyHelper(html, metadata, expression, expression, viewAttributes, containerContent, needHidden);
	}

	private static MvcHtmlString PropertyHelper<TModel, TValue>(HtmlHelper<TModel> html, ModelMetadata metadata, Expression<Func<TModel, TValue>> expression, string expressionText, Func<dynamic, HelperResult> editorTemplate, WebViewAttributes viewAttributes)
	{
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		if (metadata.GetPropertyMetadata().TypeUid == ExceptionScriptDescriptor.UID && metadata.get_Model() == null)
		{
			return null;
		}
		viewAttributes = viewAttributes ?? new WebViewAttributes();
		EleWise.ELMA.Web.Mvc.Models.PropertyRowModel propertyRowModel = new EleWise.ELMA.Web.Mvc.Models.PropertyRowModel();
		propertyRowModel.ModelName = ((HtmlHelper)html).get_ViewContext().get_ViewData().get_TemplateInfo()
			.GetFullHtmlFieldName(expressionText);
		propertyRowModel.Caption = PropertyPartHelper(PropertyPart.Caption, (HtmlHelper)(object)html, metadata, expressionText, viewAttributes);
		propertyRowModel.Description = ((!viewAttributes.ShowDescription) ? MvcHtmlString.Empty : PropertyPartHelper(PropertyPart.Description, (HtmlHelper)(object)html, metadata, expressionText, viewAttributes));
		propertyRowModel.Value = (MvcHtmlString)((editorTemplate != null) ? ((object)new MvcHtmlString(editorTemplate(metadata).ToHtmlString())) : ((object)PropertyPartHelper(PropertyPart.Value, (HtmlHelper)(object)html, metadata, expressionText, viewAttributes)));
		return RenderPropertyRow<TModel>(html, propertyRowModel, metadata, viewAttributes);
	}

	private static MvcHtmlString PropertyHelper<TModel>(HtmlHelper<TModel> html, ModelMetadata metadata, string expression, string expressionText, WebViewAttributes viewAttributes)
	{
		IPropertyMetadata propertyMetadata = metadata.GetPropertyMetadata();
		if (propertyMetadata != null && propertyMetadata.TypeUid == ExceptionScriptDescriptor.UID && metadata.get_Model() == null)
		{
			return null;
		}
		viewAttributes = viewAttributes ?? new WebViewAttributes();
		EleWise.ELMA.Web.Mvc.Models.PropertyRowModel propertyRowModel = new EleWise.ELMA.Web.Mvc.Models.PropertyRowModel();
		propertyRowModel.ModelName = ((HtmlHelper)html).get_ViewContext().get_ViewData().get_TemplateInfo()
			.GetFullHtmlFieldName(expressionText);
		propertyRowModel.Validation = ValidationMessage((HtmlHelper)(object)html, expression);
		propertyRowModel.Caption = PropertyPartHelper(PropertyPart.Caption, (HtmlHelper)(object)html, metadata, expressionText, viewAttributes, propertyRowModel.Validation);
		propertyRowModel.Description = ((viewAttributes == null || !viewAttributes.ShowDescription) ? MvcHtmlString.Empty : PropertyPartHelper(PropertyPart.Description, (HtmlHelper)(object)html, metadata, expressionText, viewAttributes));
		propertyRowModel.Value = PropertyPartHelper(PropertyPart.Value, (HtmlHelper)(object)html, metadata, expressionText, viewAttributes);
		return RenderPropertyRow<TModel>(html, propertyRowModel, metadata, viewAttributes);
	}

	private static MvcHtmlString PropertyHelper(HtmlHelper html, ModelMetadata metadata, string expression, string expressionText, WebViewAttributes viewAttributes, bool containerContent = false, bool needHidden = true)
	{
		IPropertyMetadata propertyMetadata = metadata.GetPropertyMetadata();
		if (propertyMetadata == null || (propertyMetadata.TypeUid == ExceptionScriptDescriptor.UID && metadata.get_Model() == null))
		{
			return null;
		}
		viewAttributes = viewAttributes ?? new WebViewAttributes();
		EleWise.ELMA.Web.Mvc.Models.PropertyRowModel propertyRowModel = new EleWise.ELMA.Web.Mvc.Models.PropertyRowModel();
		propertyRowModel.ModelName = html.get_ViewContext().get_ViewData().get_TemplateInfo()
			.GetFullHtmlFieldName(expressionText);
		if (!containerContent)
		{
			propertyRowModel.Validation = ValidationMessage(html, expression);
			propertyRowModel.Caption = PropertyPartHelper(PropertyPart.Caption, html, metadata, expressionText, viewAttributes);
			propertyRowModel.Description = ((!viewAttributes.ShowDescription) ? MvcHtmlString.Empty : PropertyPartHelper(PropertyPart.Description, html, metadata, expressionText, viewAttributes));
		}
		propertyRowModel.Value = PropertyPartHelper(PropertyPart.Value, html, metadata, expressionText, viewAttributes, propertyRowModel.Validation);
		propertyRowModel.OnlyValueContainerContent = containerContent;
		propertyRowModel.NeedHidden = needHidden;
		return RenderPropertyRow(html, propertyRowModel, metadata, viewAttributes);
	}

	private static bool IsLetter(char c)
	{
		if ('A' > c || c > 'Z')
		{
			if ('a' <= c)
			{
				return c <= 'z';
			}
			return false;
		}
		return true;
	}

	private static MvcHtmlString ValidationMessage(HtmlHelper html, string expression)
	{
		string fullHtmlFieldName = html.get_ViewContext().get_ViewData().get_TemplateInfo()
			.GetFullHtmlFieldName(expression);
		if (fullHtmlFieldName.Length <= 0 || IsLetter(fullHtmlFieldName[0]))
		{
			return ValidationExtensions.ValidationMessage(html, expression);
		}
		return ValidationExtensions.ValidationMessage(html, expression, (object)new
		{
			id = TagBuilder.CreateSanitizedId("T" + fullHtmlFieldName + "_validationMessage").Remove(0, 1)
		});
	}

	private static MvcHtmlString RenderPropertyRow<TModel>(HtmlHelper<TModel> html, EleWise.ELMA.Web.Mvc.Models.PropertyRowModel model, ModelMetadata metadata, WebViewAttributes viewAttributes)
	{
		model.ViewAttributes = viewAttributes;
		if (!string.IsNullOrEmpty(viewAttributes.RenderFiled))
		{
			ModelMetadata val = ModelMetadata.FromStringExpression(viewAttributes.RenderFiled, (ViewDataDictionary)(object)html.get_ViewData());
			if (val != null && val.get_Model() != null)
			{
				model.HiddenField = ((HtmlHelper)(object)html).ModernHiddenFor(viewAttributes.RenderFiled, val.get_Model());
			}
		}
		string text = ((metadata.GetPropertyMetadata() is ITablePartMetadata) ? "Templates/TablePartRow" : "Templates/PropertyRow");
		return PartialExtensions.Partial((HtmlHelper)(object)html, text, (object)model);
	}

	private static MvcHtmlString RenderPropertyRow(HtmlHelper html, EleWise.ELMA.Web.Mvc.Models.PropertyRowModel model, ModelMetadata metadata, WebViewAttributes viewAttributes)
	{
		model.ViewAttributes = viewAttributes;
		if (!string.IsNullOrEmpty(viewAttributes.RenderFiled))
		{
			ModelMetadata val = ModelMetadata.FromStringExpression(viewAttributes.RenderFiled, html.get_ViewData());
			if (val != null && val.get_Model() != null)
			{
				model.HiddenField = html.ModernHiddenFor(viewAttributes.RenderFiled, val.get_Model());
			}
		}
		string text = ((metadata.GetPropertyMetadata() is ITablePartMetadata) ? "Templates/TablePartRow" : "Templates/PropertyRow");
		return PartialExtensions.Partial(html, text, (object)model);
	}

	private static MvcHtmlString PropertyPartHelper<TModel, TValue>(PropertyPart propertyPart, HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression, WebViewAttributes viewAttributes, TagBuilder containerTagBuilder)
	{
		return PropertyPartHelper(propertyPart, (HtmlHelper)(object)html, ModelMetadata.FromLambdaExpression<TModel, TValue>(expression, html.get_ViewData()), ExpressionHelper.GetExpressionText((LambdaExpression)expression), viewAttributes, containerTagBuilder);
	}

	private static MvcHtmlString PropertyPartHelper(PropertyPart propertyPart, HtmlHelper html, string expression, WebViewAttributes viewAttributes, TagBuilder containerTagBuilder)
	{
		return PropertyPartHelper(propertyPart, html, ModelMetadata.FromStringExpression(expression, html.get_ViewData()), expression, viewAttributes, containerTagBuilder);
	}

	private static MvcHtmlString PropertyPartHelper(PropertyPart propertyPart, HtmlHelper html, ModelMetadata metadata, string expression, WebViewAttributes viewAttributes, TagBuilder containerTagBuilder)
	{
		MvcHtmlString val = PropertyPartHelper(propertyPart, html, metadata, expression, viewAttributes);
		if (containerTagBuilder == null)
		{
			return val;
		}
		return MvcHtmlString.Create(containerTagBuilder.ToString((TagRenderMode)1) + ((val != null) ? ((HtmlString)(object)val).ToHtmlString() : "") + containerTagBuilder.ToString((TagRenderMode)2));
	}

	private static MvcHtmlString PropertyPartHelper(PropertyPart propertyPart, HtmlHelper html, ModelMetadata metadata, string expression, WebViewAttributes viewAttributes)
	{
		return PropertyPartHelper(propertyPart, html, metadata, expression, viewAttributes, (MvcHtmlString)null);
	}

	private static MvcHtmlString PropertyPartHelper(PropertyPart propertyPart, HtmlHelper html, ModelMetadata metadata, string expression, WebViewAttributes viewAttributes, MvcHtmlString validationMessageContent)
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		viewAttributes = viewAttributes ?? new WebViewAttributes();
		bool flag = viewAttributes.ReadOnly ?? false;
		if (viewAttributes.ViewStyle == ModelViewStyle.Default)
		{
			viewAttributes.ViewStyle = (flag ? ModelViewStyle.Display : ModelViewStyle.Editor);
		}
		IPropertyMetadata propertyMetadata = metadata.GetPropertyMetadata();
		if (propertyMetadata is PropertyMetadata propertyMetadata2 && propertyMetadata2.CalculateType != 0)
		{
			viewAttributes.ReadOnly = true;
		}
		int num;
		if (propertyPart == PropertyPart.Value && viewAttributes.ValidationMessage)
		{
			num = ((!flag) ? 1 : 0);
			if (num != 0 && html.get_ViewContext().get_FormContext() == null)
			{
				html.get_ViewContext().set_FormContext(new FormContext());
			}
		}
		else
		{
			num = 0;
		}
		bool required = !flag && viewAttributes.Visible && viewAttributes.Required;
		MvcHtmlString arg = ((num != 0) ? (validationMessageContent ?? ValidationMessage(html, expression)) : MvcHtmlString.Empty);
		if (propertyMetadata == null)
		{
			switch (propertyPart)
			{
			case PropertyPart.Caption:
				return PartialExtensions.Partial(html, "Templates/PropertyCaption", (object)new PropertyCaption
				{
					Required = required,
					Text = (viewAttributes.LocalizableName ?? metadata.get_PropertyName()).HtmlEncode()
				});
			case PropertyPart.Value:
				if (!flag)
				{
					return MvcHtmlString.Create(string.Format("{0}{1}{2}", AddRequiredLabelToContentIfNeeded(viewAttributes, EditorExtensions.Editor(html, expression, (string)null, expression, (object)new ViewAttributesContainer(viewAttributes)), required), arg, (viewAttributes.EntityModelBinderProvider == Guid.Empty) ? "" : $"<input type=\"hidden\" name=\"{html.get_ViewContext().get_ViewData().get_TemplateInfo().GetFullHtmlFieldName(expression)}_BinderProviderUid\" value=\"{viewAttributes.EntityModelBinderProvider}\" />"));
			}
			return DisplayExtensions.Display(html, expression, (string)null, expression, (object)new ViewAttributesContainer(viewAttributes));
		default:
			return MvcHtmlString.Empty;
		}
	}
	required = !flag && viewAttributes.Visible && (propertyMetadata.Required || viewAttributes.Required);
	switch (propertyPart)
	{
	case PropertyPart.Caption:
	{
		string text2 = viewAttributes.LocalizableName ?? propertyMetadata.DisplayName;
		string text3 = viewAttributes.LocalizablePropertyPath ?? viewAttributes.PropertyPath;
		return PartialExtensions.Partial(html, "Templates/PropertyCaption", (object)new PropertyCaption
		{
			Required = required,
			Text = text2,
			PropertyPath = ((!string.IsNullOrEmpty(text3)) ? PartialExtensions.Partial(html, "DisplayTemplates/PropertyPath", (object)text3) : MvcHtmlString.Empty)
		});
	}
	case PropertyPart.Description:
	{
		string text = viewAttributes.LocalizableDescription ?? propertyMetadata.Description;
		if (string.IsNullOrEmpty(text))
		{
			return MvcHtmlString.Empty;
		}
		return PartialExtensions.Partial(html, "Templates/PropertyDescription", (object)SR.T(text));
	}
	case PropertyPart.Value:
		return MvcHtmlString.Create($"{PropertyInputHelper(html, propertyMetadata, metadata, expression, viewAttributes, required)}{arg}");
	default:
		return MvcHtmlString.Empty;
	}
}

private static MvcHtmlString PropertyInputHelper(HtmlHelper html, IPropertyMetadata prop, ModelMetadata metadata, string expression, ViewAttributes viewAttributes, bool required)
{
	//IL_0235: Unknown result type (might be due to invalid IL or missing references)
	//IL_023f: Expected O, but got Unknown
	//IL_0257: Unknown result type (might be due to invalid IL or missing references)
	//IL_025c: Unknown result type (might be due to invalid IL or missing references)
	//IL_026c: Unknown result type (might be due to invalid IL or missing references)
	//IL_0279: Expected O, but got Unknown
	//IL_0286: Unknown result type (might be due to invalid IL or missing references)
	//IL_028b: Unknown result type (might be due to invalid IL or missing references)
	//IL_029b: Unknown result type (might be due to invalid IL or missing references)
	//IL_02a8: Expected O, but got Unknown
	//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
	//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
	//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
	//IL_02d7: Expected O, but got Unknown
	IEnumerable<IInput> inputExtensions = GetInputExtensions(html);
	IInput input = inputExtensions.FirstOrDefault((IInput inp) => inp.TypeUid == prop.TypeUid);
	if (input == null)
	{
		input = inputExtensions.FirstOrDefault((IInput inp) => inp.TypeUid == Guid.Empty);
	}
	if (input == null)
	{
		return MvcHtmlString.Create($"Input for type \"{prop.TypeUid}\" is not defined");
	}
	if (viewAttributes == null)
	{
		viewAttributes = new ViewAttributes
		{
			ReadOnly = true
		};
	}
	bool flag = viewAttributes.ReadOnly ?? false;
	if (viewAttributes.TypeSettings == null && viewAttributes.TypeSettingsCreator != null)
	{
		viewAttributes.TypeSettings = viewAttributes.TypeSettingsCreator();
		if (viewAttributes.TypeSettingsAction != null)
		{
			viewAttributes.TypeSettings = ClassSerializationHelper.CloneObjectByXml(viewAttributes.TypeSettings);
			viewAttributes.TypeSettingsAction(viewAttributes.TypeSettings);
		}
	}
	PropertyViewItem propertyViewItem = html.get_ViewData().get_Item("View") as PropertyViewItem;
	bool flag2 = propertyViewItem?.EditableInTable ?? false;
	if (viewAttributes.TypeSettings == null)
	{
		viewAttributes.TypeSettings = prop.Settings;
		if (metadata.GetContainerObject() is IEntity entity && (!flag || flag2))
		{
			TypeSettings typeSettings = entity.LoadPropertyInstanceSettings(prop.Uid);
			if (typeSettings != null)
			{
				viewAttributes.TypeSettings = typeSettings;
			}
		}
		if (viewAttributes.TypeSettingsAction != null)
		{
			viewAttributes.TypeSettings = ClassSerializationHelper.CloneObjectByXml(viewAttributes.TypeSettings);
			viewAttributes.TypeSettingsAction(viewAttributes.TypeSettings);
		}
	}
	ICollection<ModelClientValidationRule> validationRules = null;
	Func<ICollection<ModelClientValidationRule>> GetValidationRules = delegate
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		if (validationRules == null)
		{
			string fullHtmlFieldName3 = html.get_ViewContext().get_ViewData().get_TemplateInfo()
				.GetFullHtmlFieldName(expression);
			if (html.get_ViewContext().get_FormContext() == null)
			{
				html.get_ViewContext().set_FormContext(new FormContext());
			}
			validationRules = html.get_ViewContext().get_FormContext().GetValidationMetadataForField(fullHtmlFieldName3, true)
				.get_ValidationRules();
		}
		return validationRules;
	};
	if (prop is ITablePartMetadata && viewAttributes.Visible)
	{
		string fullHtmlFieldName = html.get_ViewContext().get_ViewData().get_TemplateInfo()
			.GetFullHtmlFieldName(expression);
		if (html.get_ViewContext().get_FormContext() == null)
		{
			html.get_ViewContext().set_FormContext(new FormContext());
		}
		FieldValidationMetadata validationMetadataForField = html.get_ViewContext().get_FormContext().GetValidationMetadataForField(fullHtmlFieldName, true);
		ModelClientValidationRule val = new ModelClientValidationRule();
		val.set_ErrorMessage(SR.T("Необходимо завершить редактирование записи"));
		val.set_ValidationType("needCompleteGridEditing");
		ModelClientValidationRule item = val;
		validationMetadataForField.get_ValidationRules().Add(item);
		ModelClientValidationRule val2 = new ModelClientValidationRule();
		val2.set_ErrorMessage(SR.T("Заполните значения обязательных полей"));
		val2.set_ValidationType("reqfieldTablePart");
		item = val2;
		validationMetadataForField.get_ValidationRules().Add(item);
		ModelClientValidationRule val3 = new ModelClientValidationRule();
		val3.set_ErrorMessage(SR.T("Заполните значения обязательных полей на других страницах"));
		val3.set_ValidationType("reqfieldEntireTablePart");
		item = val3;
		validationMetadataForField.get_ValidationRules().Add(item);
	}
	if (prop.Required && !viewAttributes.Visible)
	{
		GetValidationRules().Clear();
	}
	if (!flag && viewAttributes.Visible && viewAttributes.Required && !prop.Required)
	{
		((ModelValidator)new RequiredFieldValidator(metadata, (ControllerContext)(object)html.get_ViewContext(), new RequiredFieldAttribute())).GetClientValidationRules().ForEach(delegate(ModelClientValidationRule r)
		{
			GetValidationRules().Add(r);
		});
	}
	if (!string.IsNullOrEmpty(viewAttributes.ValidationError))
	{
		((ModelValidator)new ScriptValidator(metadata, (ControllerContext)(object)html.get_ViewContext(), new ScriptValidationAttribute(viewAttributes.ValidationError))).GetClientValidationRules().ForEach(delegate(ModelClientValidationRule r)
		{
			GetValidationRules().Add(r);
		});
	}
	IMvcValidatableTypeSettings mvcValidatableTypeSettings = viewAttributes.TypeSettings as IMvcValidatableTypeSettings;
	if ((!flag || flag2) && viewAttributes.Visible)
	{
		mvcValidatableTypeSettings?.ApplyValidationRules(GetValidationRules(), metadata, (ControllerContext)(object)html.get_ViewContext(), prop.Settings);
	}
	PropertyMetadata propertyMetadata = prop as PropertyMetadata;
	if (viewAttributes.EntityFilterProvider == Guid.Empty && propertyMetadata != null && propertyMetadata.Settings is EntitySettings && metadata.get_ContainerType() != null)
	{
		foreach (IEntityFilterProvider filterProvider in GetFilterProviders(html))
		{
			string text = ((filterProvider is IEntityInstanceFilterProvider entityInstanceFilterProvider) ? entityInstanceFilterProvider.GetFilterProviderData(metadata.GetContainerObject() as IEntity, metadata.get_ContainerType(), propertyMetadata, viewAttributes) : filterProvider.GetFilterProviderData(metadata.get_ContainerType(), propertyMetadata, viewAttributes));
			if (text != null)
			{
				viewAttributes.EntityFilterProvider = filterProvider.ProviderUid;
				viewAttributes.EntityFilterData = text;
				break;
			}
		}
	}
	WebViewAttributes webViewAttributes = viewAttributes as WebViewAttributes;
	if (webViewAttributes != null)
	{
		string fullHtmlFieldName2 = html.get_ViewContext().get_ViewData().get_TemplateInfo()
			.GetFullHtmlFieldName(expression);
		string text2 = (viewAttributes.DisableDynamicForms ? null : ((!string.IsNullOrEmpty(viewAttributes.OnChangeScriptName)) ? viewAttributes.OnChangeScriptName : ((!string.IsNullOrEmpty(prop.OnChangeScriptName)) ? prop.OnChangeScriptName : null)));
		if (propertyViewItem != null && flag2)
		{
			if (!string.IsNullOrEmpty(text2))
			{
				DynamicFormSettings dynamicFormSettings = html.get_ViewContext().get_ViewData().get_Item("DynamicFormSettings") as DynamicFormSettings;
				var obj = new
				{
					viewItemUid = dynamicFormSettings.ViewItemUid,
					formId = dynamicFormSettings.FormId,
					parentPropertyFieldId = dynamicFormSettings.ParentPropertyFieldId,
					parentFormId = dynamicFormSettings.ParentFormId,
					typeUid = html.get_ViewContext().get_ViewData().get_Item("typeUidAttribute"),
					expression = expression,
					dataItemId = html.get_ViewContext().get_ViewData().get_Item("dataItemId")
				};
				webViewAttributes.Html.onchange = $"function(e) {{ elma.changeTablePartPropertyDynamic(e, '{fullHtmlFieldName2}','{text2}', '{new JsonSerializer().Serialize(obj)}'); }}";
			}
			else
			{
				webViewAttributes.Html.onchange = string.Format("function(e) {{ elma.changeTablePartProperty(e, '{0}', {1}); }}", expression, html.get_ViewContext().get_ViewData().get_Item("dataItemId"));
			}
		}
		else if (!string.IsNullOrEmpty(text2))
		{
			webViewAttributes.Html.onchange = $"function(e) {{ elma.dynamicForms.onChange(e, '{fullHtmlFieldName2}', '{text2}', elma.dynamicForms.getForm(e.target || e, 'div[type=dynamicForm]')); }}";
		}
	}
	MvcHtmlString val4 = (flag ? input.Display(html, prop, metadata, expression, viewAttributes) : MvcHtmlString.Create(string.Format("{0}{1}", AddRequiredLabelToContentIfNeeded(webViewAttributes, input.Editor(html, prop, metadata, expression, viewAttributes), required), (viewAttributes.EntityModelBinderProvider == Guid.Empty) ? "" : $"<input type=\"hidden\" name=\"{html.get_ViewContext().get_ViewData().get_TemplateInfo().GetFullHtmlFieldName(expression)}_BinderProviderUid\" value=\"{viewAttributes.EntityModelBinderProvider}\" />")));
if (propertyMetadata != null && viewAttributes.Visible && (viewAttributes.Required || propertyMetadata.Required) && viewAttributes.ViewStyle == ModelViewStyle.GridDisplay)
{
	string text3 = "requiredField";
	if (html.get_ViewContext() != null && html.get_ViewContext().get_ViewData() != null && html.get_ViewContext().get_ViewData().get_Model() != null && IsEmpty(html.get_ViewData(), expression, html.get_ViewContext().get_ViewData().get_Model()))
	{
		text3 += " grid-empty-value";
	}
	return MvcHtmlString.Create(((HtmlString)(object)val4).ToHtmlString() + $"<span class=\"{text3}\" />");
}
return val4;
}

private static MvcHtmlString AddRequiredLabelToContentIfNeeded(WebViewAttributes webViewAttributes, MvcHtmlString content, bool required)
{
//IL_0038: Unknown result type (might be due to invalid IL or missing references)
//IL_003e: Expected O, but got Unknown
//IL_007f: Unknown result type (might be due to invalid IL or missing references)
//IL_0085: Expected O, but got Unknown
//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
//IL_00a7: Expected O, but got Unknown
//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
//IL_00ee: Expected O, but got Unknown
//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
//IL_00f4: Expected O, but got Unknown
if (!required || webViewAttributes == null || webViewAttributes.AdditionalViewData == null)
{
	return content;
}
if (!Convert.ToBoolean(webViewAttributes.AdditionalViewData["ShowRequiredLabel"] ?? ((object)false)))
{
	return content;
}
TagBuilder val = new TagBuilder("div");
val.get_Attributes()["style"] = "float: right;";
val.get_Attributes()["style"] += "width: 10px;";
TagBuilder val2 = new TagBuilder("span");
val2.AddCssClass("caption-required");
val.set_InnerHtml(((object)val2).ToString());
TagBuilder val3 = new TagBuilder("div");
val3.get_Attributes()["style"] = "margin-right: 15px;";
val3.set_InnerHtml(((object)content).ToString());
TagBuilder val4 = new TagBuilder("div");
val4.set_InnerHtml(((object)val).ToString() + ((object)val3).ToString());
return new MvcHtmlString(((object)val4).ToString());
}

internal static IEnumerable<IInput> GetInputExtensions(HtmlHelper html)
{
return ((ControllerContext)html.get_ViewContext()).get_HttpContext().GetOrAddItem("EleWise.ELMA.Web.Mvc.Html.ModelExtensions.Inputs", () => ComponentManager.Current.GetExtensionPoints<IInput>());
}

private static IEnumerable<IEntityFilterProvider> GetFilterProviders(HtmlHelper html)
{
return ((ControllerContext)html.get_ViewContext()).get_HttpContext().GetOrAddItem("EleWise.ELMA.Web.Mvc.Html.ModelExtensions.EntityFilterProviders", () => ComponentManager.Current.GetExtensionPoints<IEntityFilterProvider>());
}

private static void ApplyObjectViewData(WebViewAttributes a, ModelMetadata modelMetadata, PropertyViewItem item = null, bool forceReadOnly = false, PropertyViewItem newItem = null)
{
if (a == null || modelMetadata == null)
{
	return;
}
ObjectViewData current = ObjectViewData.GetCurrent();
if (current == null || current.Metadata == null)
{
	return;
}
IPropertyMetadata prop = modelMetadata.GetPropertyMetadata();
if (prop == null)
{
	return;
}
IEnumerable<IPropertyMetadata> source;
if (!(current.Metadata is IEntityMetadata entityMetadata))
{
	IEnumerable<IPropertyMetadata> enumerable = current.Metadata.Properties.OfType<IPropertyMetadata>().ToList();
	source = enumerable;
}
else
{
	source = entityMetadata.GetPropertiesAndTableParts();
}
if (!source.Any((IPropertyMetadata p) => p.PropertyUid == prop.PropertyUid))
{
	return;
}
if (item == null && ViewItemControl<EleWise.ELMA.Model.Views.ViewItem, object, object>.ViewItem is RootViewItem rootViewItem && current.View != null)
{
	item = newItem ?? new PropertyViewItem();
	PropertyViewItem propertyViewItem = current.View.GetAllItems(ignoreHide: false).OfType<PropertyViewItem>().FirstOrDefault((PropertyViewItem p) => p.PropertyUid == prop.PropertyUid);
	if (propertyViewItem != null)
	{
		item.CopyFrom(propertyViewItem);
	}
	else
	{
		item.PropertyUid = prop.PropertyUid;
		if (prop is PropertyMetadata && ((PropertyMetadata)prop).ViewSettings != null)
		{
			item.Attributes.ReadOnly = ((PropertyMetadata)prop).ViewSettings.GetForView(current.ViewType, current.ItemType).ReadOnly;
		}
	}
	item.Hide = true;
	item.IsCustom = true;
	rootViewItem.Items.Add(item);
	if (!item.IsMainPropertyViewItem())
	{
		forceReadOnly = true;
	}
}
if (item != null)
{
	a.ViewItemUid = item.Uid;
	a.NeedPostfix = item.NeedPostfix();
	if (prop is ITablePartMetadata)
	{
		PropertyViewItem viewItem = current.GetViewItem<PropertyViewItem>(item.Uid);
		if (viewItem != null)
		{
			a.ViewItemTransformation = item.CreateTransformation(viewItem);
		}
	}
}
ViewAttribute viewAttribute = ((item == null && prop is PropertyMetadata && ((PropertyMetadata)prop).ViewSettings != null) ? ((PropertyMetadata)prop).ViewSettings.GetForView(current.ViewType, current.ItemType) : null);
object obj = ((current.Model != null) ? current.ModelType.GetReflectionProperty(prop.Name).GetValue(current.Model, null) : null);
if (forceReadOnly)
{
	a.ReadOnly = true;
}
else
{
	a.ReadOnly = current.ReadOnly || (viewAttribute != null && viewAttribute.ReadOnly) || (item != null && item.Items.Count > 0 && obj != null && !(prop is ITablePartMetadata)) || (item?.IsReadOnly() ?? false);
}
if (item == null && a.ReadOnly.Value)
{
	a.FullReadOnly = true;
}
if (item != null && !item.IsVisible())
{
	a.Visible = false;
}
if (item != null && item.Attributes.Required)
{
	a.Required = true;
}
a.ShowDescription = current.ShowDescription;
if (item != null && item.Attributes != null && item.Attributes.Description != null)
{
	a.ShowDescription = true;
	a.Description = item.Attributes.Description;
}
if (item == null)
{
	if (a.ReadOnly.Value && current.RenderReadOnlyPropertyFiled)
	{
		a.RenderFiled = $"{prop.Name}.Id";
	}
}
else if (item.Items.Count > 0 && obj != null && !(prop is ITablePartMetadata))
{
	a.RenderFiled = $"{prop.Name}.Id";
}
a.Class = "dft_table_td_inputs";
if (!string.IsNullOrEmpty(a.RenderFiled))
{
	a.Class = "grouping_field_label";
	a.TrClass = "grouping_field";
}
if (current.Padding > 0)
{
	string text = $"padding-left:{current.Padding}px;";
	a.LabelStyle = a.LabelStyle + ((!string.IsNullOrWhiteSpace(a.LabelStyle)) ? ";" : "") + text;
	a.ValueStyle = a.ValueStyle + ((!string.IsNullOrWhiteSpace(a.ValueStyle)) ? ";" : "") + text;
	a.TrClass += "grouping-child-field";
}
a.FormId = current.FormId;
a.ViewProviderUid = current.ViewProviderUid;
a.ViewItemId = current.ViewItemId;
a.DynamicFormsProviderUid = current.DynamicFormsProviderUid;
a.DynamicFormsProviderData = current.DynamicFormsProviderData;
if (current.Model is IEntity)
{
	a.TablePartParentId = ((IEntity)current.Model).GetId();
	IMetadata metadata = MetadataLoader.LoadMetadata(((IEntity)current.Model).CastAsRealType().GetType());
	a.TablePartParentMetadataUid = metadata.Uid;
}
if (item != null)
{
	a.OnChangeScriptName = item.Attributes.OnChangeScriptName;
}
}

private static string GetModelId(this HtmlHelper html, string expression)
{
string fullHtmlFieldName = html.get_ViewContext().get_ViewData().get_TemplateInfo()
	.GetFullHtmlFieldName(expression);
if (fullHtmlFieldName == null)
{
	return "";
}
return TagBuilder.CreateSanitizedId(fullHtmlFieldName);
}

private static MvcHtmlString RenderViewItem(HtmlHelper html, ViewItem viewItem, object viewModel = null, string htmlFieldPrefix = null, object originalModel = null, ActionRoute actionRoute = null, Func<MvcHtmlString, object> itemTemplate = null)
{
return RenderViewItem(html, viewItem, delegate(ViewItem vi, ViewItem viParent, object vm, Func<MvcHtmlString, object> it)
{
	IViewItemRenderer viewItemRenderer = ComponentManager.Current.GetExtensionPoints<IViewItemRenderer>().FirstOrDefault((IViewItemRenderer p) => p.CanRender(vi));
	if (viewItemRenderer == null)
	{
		throw new Exception(SR.T("Не найдена точка расширения для отрисовки элемента представления формы {0}", vi.GetType()));
	}
	if (it == null || viewItemRenderer.SupportParentRender(vi, viParent))
	{
		return viewItemRenderer.Render(html, vi, vm);
	}
	object obj = it(viewItemRenderer.Render(html, vi, vm));
	return MvcHtmlString.Create((obj != null) ? obj.ToString() : "");
}, viewModel, htmlFieldPrefix, originalModel, actionRoute, itemTemplate);
}

private static MvcHtmlString RenderViewItem(HtmlHelper html, ViewItem viewItem, Func<ViewItem, ViewItem, object, Func<MvcHtmlString, object>, MvcHtmlString> render, object viewModel = null, string htmlFieldPrefix = null, object originalModel = null, ActionRoute actionRoute = null, Func<MvcHtmlString, object> itemTemplate = null)
{
if (viewItem is FormViewItem)
{
	ContextVars.Set("FormViewItemOriginalViewItem", (FormViewItem)ClassSerializationHelper.CloneObjectByXml(viewItem));
	viewItem = ((FormViewItem)viewItem).TransformateExtensions(originalModel ?? html.get_ViewData().get_Model());
}
if (viewItem.Hide)
{
	return MvcHtmlString.Empty;
}
ViewItem orDefault = ContextVars.GetOrDefault<ViewItem>("ViewItemObject");
ContextVars.Set("ViewItemObject", viewItem);
RootViewItem orDefault2 = ContextVars.GetOrDefault<RootViewItem>("ViewItemParentObject");
ContextVars.Set("ViewItemParentObject", orDefault as RootViewItem);
ActionRoute orDefault3 = ContextVars.GetOrDefault<ActionRoute>("ViewItemActionRoute");
if (actionRoute != null || viewItem is FormViewItem)
{
	ContextVars.Set("ViewItemActionRoute", actionRoute);
}
bool isOldModelNull = false;
object orAdd = ContextVars.GetOrAdd("ViewItemModel", delegate
{
	isOldModelNull = true;
	return originalModel ?? html.get_ViewData().get_Model();
});
bool isOldPrefixNull = false;
string oldHtmlFieldPrefix = html.get_ViewData().get_TemplateInfo().get_HtmlFieldPrefix();
string orAdd2 = ContextVars.GetOrAdd("ViewItemPrefix", delegate
{
	isOldPrefixNull = true;
	return oldHtmlFieldPrefix;
});
if (!string.IsNullOrEmpty(htmlFieldPrefix))
{
	html.get_ViewData().get_TemplateInfo().set_HtmlFieldPrefix(html.get_ViewData().get_TemplateInfo().GetFullHtmlFieldName(htmlFieldPrefix));
}
try
{
	return render(viewItem, orDefault ?? viewItem.Parent, viewModel, itemTemplate);
}
catch (Exception ex)
{
	Logger.Log.Error("Не удалось отобразить пользовательскую разметку", ex);
	return PartialExtensions.Partial(html, "RazorViewError/RazorViewError", (object)ex);
}
finally
{
	html.get_ViewData().get_TemplateInfo().set_HtmlFieldPrefix(oldHtmlFieldPrefix);
	ContextVars.Set("ViewItemObject", orDefault);
	ContextVars.Set("ViewItemParentObject", orDefault2);
	ContextVars.Set("ViewItemActionRoute", orDefault3);
	if (isOldModelNull)
	{
		ContextVars.Remove("ViewItemModel");
	}
	else
	{
		ContextVars.Set("ViewItemModel", orAdd);
	}
	if (isOldPrefixNull)
	{
		ContextVars.Remove("ViewItemPrefix");
	}
	else
	{
		ContextVars.Set("ViewItemPrefix", orAdd2);
	}
}
}

private static bool EqualsEnumerable(this IEnumerable collection1, IEnumerable collection2)
{
if (collection1 == null && collection2 == null)
{
	return true;
}
if (collection1 == null || collection2 == null)
{
	return false;
}
bool result = false;
int num = collection1.Cast<object>().Count();
int num2 = collection2.Cast<object>().Count();
if (num == num2)
{
	IEnumerable generalCollections = collection1.GetGeneralCollections(collection2);
	if (num2 == generalCollections.Cast<object>().Count())
	{
		result = true;
	}
}
return result;
}

private static IEnumerable GetGeneralCollections(this IEnumerable collection1, IEnumerable collection2)
{
List<object> list = new List<object>();
foreach (object val3 in collection1)
{
	if (collection2.Cast<object>().Any((object val2) => object.Equals(val3, val2)) && !list.Any((object valGeneral) => object.Equals(val3, valGeneral)))
	{
		list.Add(val3);
	}
}
return list;
}

private static MvcHtmlString RenderRuntimeVersion2(HtmlHelper html, object model, FormViewItem formViewItem, ViewType viewType)
{
if (!(model is IEntity<long> entity))
{
	return null;
}
Type type = entity.GetType();
if (FormRenderHelper.GetFormUid(type, viewType) == formViewItem.Uid)
{
	if ((uint)(viewType - 1) <= 1u || viewType == ViewType.Display)
	{
		return RenderView(html, entity, type, viewType);
	}
	return null;
}
return RenderViewItem(html, entity, type, formViewItem);
}

private static MvcHtmlString RenderView(HtmlHelper html, IEntity<long> entity, Type entityType, ViewType viewType)
{
if (FormRenderHelper.CanRenderRuntimeVersion2(entityType, viewType))
{
	IMetadata metadata = MetadataLoader.LoadMetadata(entityType);
	Guid uid = metadata.Uid;
	Dictionary<string, object> dictionary = new Dictionary<string, object>
	{
		["EntityId"] = entity.Id,
		["EntityTypeUid"] = uid
	};
	EntityMetadata em;
	if ((em = metadata as EntityMetadata) != null && em.Hierarchical)
	{
		dictionary["Hierarchical"] = true;
		PropertyMetadata propertyMetadata = ((em.HierarchyType == HierarchyType.GroupAndElements && em.IsGroupPropertyUid != Guid.Empty) ? em.Properties.FirstOrDefault((PropertyMetadata p) => p.Uid == em.IsGroupPropertyUid) : null);
		if (propertyMetadata != null)
		{
			dictionary["IsGroup"] = (bool)entity.GetPropertyValue(propertyMetadata.Uid);
		}
		PropertyMetadata propertyMetadata2 = ((em.ParentPropertyUid != Guid.Empty) ? em.Properties.FirstOrDefault((PropertyMetadata p) => p.Uid == em.ParentPropertyUid) : null);
		if (propertyMetadata2 != null)
		{
			IEntity entity2 = (IEntity)entity.GetPropertyValue(propertyMetadata2.Uid);
			if (entity2 != null)
			{
				dictionary["ParentEntityId"] = entity2.GetId();
				dictionary["ParentEntityTypeUid"] = MetadataLoader.LoadMetadata(entity2.GetType()).Uid;
			}
		}
	}
	return RenderPageApplication(html, viewType switch
	{
		ViewType.Edit => EntitySystemComponentConstants.EditUid, 
		ViewType.Create => EntitySystemComponentConstants.CreateUid, 
		_ => EntitySystemComponentConstants.DisplayUid, 
	}, dictionary);
}
return null;
}

private static MvcHtmlString RenderViewItem(HtmlHelper html, IEntity<long> entity, Type entityType, FormViewItem viewItem)
{
Guid uid = MetadataLoader.LoadMetadata(entityType).Uid;
ViewItemHideMode hideMode = ViewItemControl<EleWise.ELMA.Model.Views.ViewItem, object, object>.HideMode;
Dictionary<string, object> inputsModel = new Dictionary<string, object>
{
	{ "WorkflowTaskId", entity.Id },
	{ "WorkflowTaskTypeUid", uid },
	{ "FormUid", viewItem.Uid },
	{ "HideMode", hideMode }
};
return RenderPageApplication(html, EntitySystemComponentConstants.CustomUid, inputsModel);
}

private static MvcHtmlString RenderPageApplication(HtmlHelper html, Guid pageUid, Dictionary<string, object> inputsModel)
{
PageApplicationData applicationData = new PageApplicationData(pageUid, inputsModel);
return html.RenderPageV2(applicationData);
}
}
