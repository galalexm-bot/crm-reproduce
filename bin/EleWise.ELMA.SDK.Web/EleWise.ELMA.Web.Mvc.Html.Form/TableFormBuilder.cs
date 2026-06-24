using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Web.Mvc.Html.Forms;

public class TableFormBuilder : IHtmlString
{
	private TableFormModel _model;

	public TableFormBuilder(TableFormModel model)
	{
		if (model == null)
		{
			throw new ArgumentNullException("model");
		}
		_model = model;
	}

	public TableFormBuilder Id(string id)
	{
		_model.Id = id;
		return this;
	}

	public TableFormBuilder ViewType(ViewType viewType)
	{
		_model.ViewType = viewType;
		return this;
	}

	public TableFormBuilder ShowLines(bool? showLines = true)
	{
		_model.ShowLines = showLines;
		return this;
	}

	public virtual TableFormBuilder Attributes(IDictionary<string, object> attributes)
	{
		if (attributes != null)
		{
			foreach (KeyValuePair<string, object> attribute in attributes)
			{
				_model.Attributes[attribute.Key] = attribute.Value;
			}
			return this;
		}
		return this;
	}

	public virtual TableFormBuilder Attributes(object attributes)
	{
		if (attributes != null)
		{
			Attributes(HtmlHelper.AnonymousObjectToHtmlAttributes(attributes));
		}
		return this;
	}

	public virtual TableFormBuilder Attributes(Action<HtmlAttributes> attributesAction)
	{
		attributesAction?.Invoke(_model.Attributes);
		return this;
	}

	public virtual TableFormBuilder ContainerAttributes(IDictionary<string, object> attributes)
	{
		if (attributes != null)
		{
			foreach (KeyValuePair<string, object> attribute in attributes)
			{
				_model.ContainerAttributes[attribute.Key] = attribute.Value;
			}
			return this;
		}
		return this;
	}

	public virtual TableFormBuilder ContainerAttributes(object attributes)
	{
		if (attributes != null)
		{
			ContainerAttributes(HtmlHelper.AnonymousObjectToHtmlAttributes(attributes));
		}
		return this;
	}

	public virtual TableFormBuilder ContainerAttributes(Action<HtmlAttributes> attributesAction)
	{
		attributesAction?.Invoke(_model.ContainerAttributes);
		return this;
	}

	public string ToHtmlString()
	{
		return string.Empty;
	}

	public override string ToString()
	{
		return string.Empty;
	}
}
