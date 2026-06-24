using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;

namespace EleWise.ELMA.Web.Mvc.Models.Inputs;

public class ModernCheckBoxBaseBuilder<TCopmonent, TBuilderResult> : IHtmlString where TCopmonent : ModernCheckBoxBase where TBuilderResult : class, IHtmlString
{
	protected TCopmonent Component { get; private set; }

	protected HtmlHelper HtmlHelper { get; private set; }

	public ModernCheckBoxBaseBuilder(TCopmonent component, HtmlHelper htmlHelper)
	{
		if (component == null)
		{
			throw new ArgumentNullException("component");
		}
		if (htmlHelper == null)
		{
			throw new ArgumentNullException("htmlHelper");
		}
		Component = component;
		HtmlHelper = htmlHelper;
	}

	public virtual TBuilderResult Id(string id)
	{
		Component.Id = id;
		return (TBuilderResult)(object)this;
	}

	public virtual TBuilderResult UniqueId()
	{
		Component.GenerateUniqueId();
		return (TBuilderResult)(object)this;
	}

	public TBuilderResult Name(string name)
	{
		return Name(name, generateIdByName: false);
	}

	public virtual TBuilderResult Name(string name, bool generateIdByName)
	{
		Component.Name = name;
		if (generateIdByName)
		{
			Component.GenerateIdByName();
		}
		return (TBuilderResult)(object)this;
	}

	public virtual TBuilderResult Checked(bool? @checked = true)
	{
		Component.IsChecked = @checked;
		return (TBuilderResult)(object)this;
	}

	public virtual TBuilderResult Value(object value)
	{
		Component.Value = value;
		return (TBuilderResult)(object)this;
	}

	public virtual TBuilderResult LabelText(string text)
	{
		LabelText(text, null);
		return (TBuilderResult)(object)this;
	}

	public virtual TBuilderResult LabelText(string text, string hint)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		if (string.IsNullOrEmpty(hint))
		{
			Component.LabelHtml = ((text != null) ? HtmlHelper.Encode(text) : null);
		}
		else
		{
			TagBuilder val = new TagBuilder("span");
			val.get_Attributes()["title"] = hint;
			val.set_InnerHtml(HtmlHelper.Encode(text));
			Component.LabelHtml = val.ToString((TagRenderMode)0);
		}
		return (TBuilderResult)(object)this;
	}

	public virtual TBuilderResult LabelHtml(string html)
	{
		Component.LabelHtml = html;
		return (TBuilderResult)(object)this;
	}

	public virtual TBuilderResult LabelContent(Func<object, object> content)
	{
		Component.LabelContent = content;
		return (TBuilderResult)(object)this;
	}

	public virtual TBuilderResult Disabled(bool disabled = true)
	{
		Component.Disabled = disabled;
		return (TBuilderResult)(object)this;
	}

	public virtual TBuilderResult Valid(bool isValid)
	{
		Component.IsValid = isValid;
		return (TBuilderResult)(object)this;
	}

	public virtual TBuilderResult Attributes(IDictionary<string, object> attributes)
	{
		if (attributes != null)
		{
			foreach (KeyValuePair<string, object> attribute in attributes)
			{
				Component.Attributes[attribute.Key] = attribute.Value;
			}
		}
		return (TBuilderResult)(object)this;
	}

	public virtual TBuilderResult Attributes(object attributes)
	{
		if (attributes != null)
		{
			Attributes(HtmlHelper.AnonymousObjectToHtmlAttributes(attributes));
		}
		return (TBuilderResult)(object)this;
	}

	public virtual TBuilderResult Attributes(Action<HtmlAttributes> attributesAction)
	{
		attributesAction?.Invoke(Component.Attributes);
		return (TBuilderResult)(object)this;
	}

	public virtual TBuilderResult LabelAttributes(IDictionary<string, object> attributes)
	{
		if (attributes != null)
		{
			foreach (KeyValuePair<string, object> attribute in attributes)
			{
				Component.LabelAttributes[attribute.Key] = attribute.Value;
			}
		}
		return (TBuilderResult)(object)this;
	}

	public virtual TBuilderResult LabelAttributes(object attributes)
	{
		if (attributes != null)
		{
			LabelAttributes(HtmlHelper.AnonymousObjectToHtmlAttributes(attributes));
		}
		return (TBuilderResult)(object)this;
	}

	public virtual TBuilderResult LabelAttributes(Action<HtmlAttributes> attributesAction)
	{
		attributesAction?.Invoke(Component.LabelAttributes);
		return (TBuilderResult)(object)this;
	}

	public virtual TBuilderResult ContainerAttributes(IDictionary<string, object> attributes)
	{
		if (attributes != null)
		{
			foreach (KeyValuePair<string, object> attribute in attributes)
			{
				Component.ContainerAttributes[attribute.Key] = attribute.Value;
			}
		}
		return (TBuilderResult)(object)this;
	}

	public virtual TBuilderResult ContainerAttributes(object attributes)
	{
		if (attributes != null)
		{
			ContainerAttributes(HtmlHelper.AnonymousObjectToHtmlAttributes(attributes));
		}
		return (TBuilderResult)(object)this;
	}

	public virtual TBuilderResult ContainerAttributes(Action<HtmlAttributes> attributesAction)
	{
		attributesAction?.Invoke(Component.ContainerAttributes);
		return (TBuilderResult)(object)this;
	}

	public virtual void Render()
	{
		Component.Render(HtmlHelper);
	}

	public string ToHtmlString()
	{
		return Component.ToHtmlString(HtmlHelper);
	}

	public override string ToString()
	{
		return ToHtmlString();
	}
}
