using System;
using System.Collections;
using System.ComponentModel.Composition;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Web.Mvc.Inputs;

[Component]
[InheritedExport(typeof(IInput))]
public abstract class BaseInput : IInput
{
	protected const string SET_SUFFIX = "Set";

	public abstract Guid TypeUid { get; }

	protected IMemoryCacheService CacheService => Locator.GetService<IMemoryCacheService>();

	public virtual MvcHtmlString Editor(HtmlHelper html, IPropertyMetadata metadata, ModelMetadata modelMetadata, string expression, ViewAttributes viewAttributes)
	{
		if (IsEnumerable(modelMetadata.get_ModelType()))
		{
			return MvcHtmlString.Empty;
		}
		string text = EditorTemplateName((ControllerContext)(object)html.get_ViewContext(), metadata, modelMetadata.get_ModelType(), viewAttributes);
		return EditorExtensions.Editor(html, expression, text, expression, (object)new
		{
			ViewAttributes = viewAttributes
		});
	}

	public virtual MvcHtmlString Display(HtmlHelper html, IPropertyMetadata metadata, ModelMetadata modelMetadata, string expression, ViewAttributes viewAttributes)
	{
		string text = DisplayTemplateName((ControllerContext)(object)html.get_ViewContext(), metadata, modelMetadata.get_ModelType(), viewAttributes);
		return DisplayExtensions.Display(html, expression, text, expression, (object)new
		{
			ViewAttributes = viewAttributes
		});
	}

	protected virtual bool CheckEnumerable()
	{
		return true;
	}

	protected virtual Type GetModelType(ModelMetadata metadata)
	{
		return metadata.get_ModelType();
	}

	private bool IsEnumerable(Type modelType)
	{
		if (CheckEnumerable() && typeof(IEnumerable).IsAssignableFrom(modelType))
		{
			return modelType != typeof(string);
		}
		return false;
	}

	public virtual string EditorTemplateName(ControllerContext controllerContext, IPropertyMetadata metadata, Type modelType, ViewAttributes viewAttributes)
	{
		if (IsEnumerable(modelType))
		{
			return null;
		}
		if (viewAttributes == null || string.IsNullOrEmpty(viewAttributes.TemplateName) || !ViewExists(controllerContext, isEditor: true, viewAttributes.TemplateName))
		{
			return GetTemplateName(metadata);
		}
		return viewAttributes.TemplateName;
	}

	public virtual string DisplayTemplateName(ControllerContext controllerContext, IPropertyMetadata metadata, Type modelType, ViewAttributes viewAttributes)
	{
		string text = "";
		if (IsEnumerable(modelType))
		{
			text = "Set";
		}
		return ((viewAttributes != null && !string.IsNullOrEmpty(viewAttributes.TemplateName) && ViewExists(controllerContext, isEditor: false, viewAttributes.TemplateName)) ? viewAttributes.TemplateName : GetTemplateName(metadata)) + text;
	}

	protected virtual string GetTemplateName(IPropertyMetadata metadata)
	{
		return null;
	}

	protected bool ViewExists(ControllerContext controllerContext, bool isEditor, string view)
	{
		string text = (isEditor ? "EditorTemplates/" : "DisplayTemplates/");
		string key = "ViewExists_" + text + view;
		if (CacheService == null || !CacheService.TryGetValue<bool>(key, out var result))
		{
			ViewEngineResult val = ViewEngines.get_Engines().FindPartialView(controllerContext, text + view);
			result = val != null && val.get_View() != null;
			if (CacheService != null)
			{
				CacheService.Insert(key, result, TimeSpan.FromSeconds(5.0));
			}
		}
		return result;
	}
}
