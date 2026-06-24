using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using EleWise.ELMA.Web.Mvc.Html;

namespace EleWise.ELMA.Web.Mvc.Models.Inputs;

public abstract class ModernCheckBoxBase
{
	protected const string IconClass = "checkboxbase-icon";

	protected const string LabelClass = "checkboxbase-label";

	public virtual string Id { get; set; }

	public virtual string Name { get; set; }

	public virtual bool? IsChecked { get; set; }

	public virtual object Value { get; set; }

	public virtual string LabelHtml { get; set; }

	public Func<object, object> LabelContent { get; set; }

	public virtual bool Disabled { get; set; }

	public virtual bool IsValid { get; set; }

	public virtual HtmlAttributes Attributes { get; private set; }

	public virtual HtmlAttributes LabelAttributes { get; private set; }

	public virtual HtmlAttributes ContainerAttributes { get; private set; }

	protected abstract InputType InputType { get; }

	protected abstract string DefaultIdPrefix { get; }

	protected virtual string DefaultValue => null;

	protected virtual string ContainerCssClass => "input-label";

	public ModernCheckBoxBase()
	{
		IsValid = true;
		Attributes = new HtmlAttributes();
		LabelAttributes = new HtmlAttributes();
		ContainerAttributes = new HtmlAttributes();
	}

	public virtual void CopyAttributesForProperty(HtmlHelper htmlHelper, ModelMetadata metadata, string fullHtmlFieldName)
	{
		if (htmlHelper == null)
		{
			throw new ArgumentNullException("htmlHelper");
		}
		ModelState val = default(ModelState);
		if (htmlHelper.get_ViewData().get_ModelState().TryGetValue(Name, ref val) && ((Collection<ModelError>)(object)val.get_Errors()).Count > 0)
		{
			IsValid = false;
		}
		IDictionary<string, object> unobtrusiveValidationAttributes = htmlHelper.GetUnobtrusiveValidationAttributes(fullHtmlFieldName, metadata);
		if (unobtrusiveValidationAttributes == null)
		{
			return;
		}
		foreach (KeyValuePair<string, object> item in unobtrusiveValidationAttributes)
		{
			Attributes[item.Key] = item.Value;
		}
	}

	public void Render(HtmlHelper htmlHelper)
	{
		if (htmlHelper == null)
		{
			throw new ArgumentNullException("htmlHelper");
		}
		using HtmlTextWriter writer = new HtmlTextWriter(htmlHelper.get_ViewContext().get_Writer());
		Render(htmlHelper, writer);
	}

	public string ToHtmlString(HtmlHelper htmlHelper)
	{
		if (htmlHelper == null)
		{
			throw new ArgumentNullException("htmlHelper");
		}
		using StringWriter stringWriter = new StringWriter();
		Render(htmlHelper, new HtmlTextWriter(stringWriter));
		return stringWriter.ToString();
	}

	public void Render(HtmlHelper htmlHelper, HtmlTextWriter writer)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		TagBuilder val = new TagBuilder("label");
		val.MergeAttributes<string, object>((IDictionary<string, object>)ContainerAttributes);
		if (!string.IsNullOrEmpty(ContainerCssClass))
		{
			val.MergeAttribute("class", ContainerCssClass);
		}
		writer.Write(val.ToString((TagRenderMode)1));
		RenderContent(htmlHelper, writer);
		writer.Write(val.ToString((TagRenderMode)2));
	}

	public virtual void GenerateUniqueId()
	{
		Id = DefaultIdPrefix + Guid.NewGuid().ToString("n");
	}

	public virtual void GenerateIdByName()
	{
		if (!string.IsNullOrEmpty(Name))
		{
			Id = TagBuilder.CreateSanitizedId(Name);
		}
	}

	protected virtual void RenderContent(HtmlHelper htmlHelper, HtmlTextWriter writer)
	{
		RenderMainInput(htmlHelper, writer);
		RenderIcon(htmlHelper, writer);
		RenderLabel(htmlHelper, writer);
	}

	protected virtual void RenderMainInput(HtmlHelper htmlHelper, HtmlTextWriter writer)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		TagBuilder val = new TagBuilder("input");
		val.MergeAttributes<string, object>((IDictionary<string, object>)Attributes);
		if (!string.IsNullOrEmpty(Id))
		{
			val.MergeAttribute("id", Id);
		}
		val.MergeAttribute("type", HtmlHelper.GetInputTypeString(InputType));
		if (!string.IsNullOrEmpty(Name))
		{
			val.MergeAttribute("name", Name, true);
		}
		object obj = Value ?? DefaultValue;
		if (obj != null)
		{
			val.MergeAttribute("value", obj.ToString());
		}
		if (IsChecked.HasValue && IsChecked.Value)
		{
			val.MergeAttribute("checked", "checked");
		}
		if (Disabled)
		{
			val.MergeAttribute("disabled", "true");
		}
		if (!IsValid)
		{
			val.AddCssClass(HtmlHelper.ValidationInputCssClassName);
		}
		writer.Write(val.ToString((TagRenderMode)3));
	}

	protected virtual void RenderLabel(HtmlHelper htmlHelper, HtmlTextWriter writer)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		TagBuilder val = new TagBuilder("span");
		val.MergeAttributes<string, object>((IDictionary<string, object>)LabelAttributes);
		val.AddCssClass("checkboxbase-label");
		string text = LabelHtml;
		if (LabelContent != null)
		{
			object obj = LabelContent(htmlHelper.get_ViewData().get_Model());
			text = ((obj is IHtmlString) ? ((IHtmlString)obj).ToHtmlString() : ((obj != null) ? htmlHelper.Encode(obj.ToString()) : ""));
		}
		val.set_InnerHtml(" " + text);
		writer.Write(val.ToString((TagRenderMode)0));
	}

	protected virtual void RenderIcon(HtmlHelper htmlHelper, HtmlTextWriter writer)
	{
		writer.Write(htmlHelper.SvgImage("#radio.svg", new
		{
			@class = "checkboxbase-icon"
		}));
	}
}
