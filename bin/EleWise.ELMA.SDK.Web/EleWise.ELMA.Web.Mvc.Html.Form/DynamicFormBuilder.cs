using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Web.Mvc.Html.Forms;

public class DynamicFormBuilder : IHtmlString
{
	private readonly DynamicFormModel model;

	public DynamicFormBuilder(DynamicFormModel model)
	{
		if (model == null)
		{
			throw new ArgumentNullException("model");
		}
		this.model = model;
	}

	public DynamicFormBuilder Id(string id)
	{
		model.Id = id;
		return this;
	}

	public DynamicFormBuilder ViewType(ViewType viewType)
	{
		model.ViewType = viewType;
		return this;
	}

	public virtual DynamicFormBuilder ContainerAttributes(IDictionary<string, object> attributes)
	{
		if (attributes != null)
		{
			foreach (KeyValuePair<string, object> attribute in attributes)
			{
				model.ContainerAttributes[attribute.Key] = attribute.Value;
			}
			return this;
		}
		return this;
	}

	public virtual DynamicFormBuilder ContainerAttributes(object attributes)
	{
		if (attributes != null)
		{
			ContainerAttributes(HtmlHelper.AnonymousObjectToHtmlAttributes(attributes));
		}
		return this;
	}

	public virtual DynamicFormBuilder ContainerAttributes(Action<HtmlAttributes> attributesAction)
	{
		attributesAction?.Invoke(model.ContainerAttributes);
		return this;
	}

	public string ToHtmlString()
	{
		return string.Empty;
	}

	public override string ToString()
	{
		return ToHtmlString();
	}
}
