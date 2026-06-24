using System;
using System.Web.Mvc;

namespace EleWise.ELMA.Web.Mvc.Html.Forms;

public class PropertyRowBuilder<TModel>
{
	public PropertyRowModel<TModel> Model { get; set; }

	public HtmlHelper Html { get; set; }

	public PropertyRowBuilder(PropertyRowModel<TModel> rowModel, HtmlHelper html)
	{
		Model = rowModel;
		Html = html;
	}

	public PropertyRowBuilder<TModel> Hide(bool value = true)
	{
		Model.Visible = !value;
		return this;
	}

	public PropertyRowBuilder<TModel> Order(int value)
	{
		Model.Order = value;
		return this;
	}

	public PropertyRowBuilder<TModel> RowTemplate(Func<PropertyRowModel<TModel>, object> value)
	{
		Model.Template = value;
		return this;
	}

	public PropertyRowBuilder<TModel> CaptionTemplate(Func<TModel, bool, object> value)
	{
		Model.Driver.RenderCaption = (HtmlHelper<TModel> helper, TModel model, bool arg3) => MvcHtmlString.Create(value(model, arg3).ToString());
		return this;
	}

	public PropertyRowBuilder<TModel> ValueTemplate(Func<TModel, object> value)
	{
		Model.Driver.RenderValue = (HtmlHelper<TModel> helper, TModel model) => MvcHtmlString.Create(value(model).ToString());
		return this;
	}

	public PropertyRowBuilder<TModel> EditorTemplate(Func<TModel, object> value)
	{
		Model.Driver.RenderEditor = (HtmlHelper<TModel> helper, TModel model) => MvcHtmlString.Create(value(model).ToString());
		return this;
	}

	public PropertyRowBuilder<TModel> DescriptionTemplate(Func<TModel, object> value)
	{
		Model.Driver.RenderDescription = (HtmlHelper<TModel> helper, TModel model) => MvcHtmlString.Create(value(model).ToString());
		return this;
	}

	public PropertyRowBuilder<TModel> Attributes(Action<WebViewAttributes> value)
	{
		if (value != null)
		{
			Model.RowDisplayActions.Add(delegate(PropertyRowModel model)
			{
				value(model.Attributes);
			});
		}
		return this;
	}

	public PropertyRowBuilder<TModel> CaptionAttributes(Action<WebViewAttributes> value)
	{
		if (value != null)
		{
			Model.RowDisplayActions.Add(delegate(PropertyRowModel model)
			{
				value(model.Driver.CaptionAttributes);
			});
		}
		return this;
	}

	public PropertyRowBuilder<TModel> ValueAttributes(Action<WebViewAttributes> value)
	{
		if (value != null)
		{
			Model.RowDisplayActions.Add(delegate(PropertyRowModel model)
			{
				value(model.Driver.ValueAttributes);
			});
		}
		return this;
	}

	public PropertyRowBuilder<TModel> EditorAttributes(Action<WebViewAttributes> value)
	{
		if (value != null)
		{
			Model.RowDisplayActions.Add(delegate(PropertyRowModel model)
			{
				value(model.Driver.EditorAttributes);
			});
		}
		return this;
	}

	public PropertyRowBuilder<TModel> DescriptionAttributes(Action<WebViewAttributes> value)
	{
		if (value != null)
		{
			Model.RowDisplayActions.Add(delegate(PropertyRowModel model)
			{
				value(model.Driver.DescriptionAttributes);
			});
		}
		return this;
	}
}
public class PropertyRowBuilder
{
	public PropertyRowModel Model { get; set; }

	public HtmlHelper Html { get; set; }

	public PropertyRowBuilder(PropertyRowModel rowModel, HtmlHelper html)
	{
		Model = rowModel;
		Html = html;
	}

	public PropertyRowBuilder Hide(bool value = false)
	{
		Model.Visible = !value;
		return this;
	}

	public PropertyRowBuilder Order(int value)
	{
		Model.Order = value;
		return this;
	}

	public PropertyRowBuilder RowTemplate(Func<PropertyRowModel, object> value)
	{
		Model.Template = value;
		return this;
	}

	public PropertyRowBuilder Attributes(Action<WebViewAttributes> value)
	{
		if (value != null)
		{
			Model.RowDisplayActions.Add(delegate(PropertyRowModel model)
			{
				value(model.Attributes);
			});
		}
		return this;
	}

	public PropertyRowBuilder CaptionAttributes(Action<WebViewAttributes> value)
	{
		if (value != null)
		{
			Model.RowDisplayActions.Add(delegate(PropertyRowModel model)
			{
				value(model.Driver.CaptionAttributes);
			});
		}
		return this;
	}

	public PropertyRowBuilder ValueAttributes(Action<WebViewAttributes> value)
	{
		if (value != null)
		{
			Model.RowDisplayActions.Add(delegate(PropertyRowModel model)
			{
				value(model.Driver.ValueAttributes);
			});
		}
		return this;
	}

	public PropertyRowBuilder EditorAttributes(Action<WebViewAttributes> value)
	{
		if (value != null)
		{
			Model.RowDisplayActions.Add(delegate(PropertyRowModel model)
			{
				value(model.Driver.EditorAttributes);
			});
		}
		return this;
	}

	public PropertyRowBuilder DescriptionAttributes(Action<WebViewAttributes> value)
	{
		if (value != null)
		{
			Model.RowDisplayActions.Add(delegate(PropertyRowModel model)
			{
				value(model.Driver.DescriptionAttributes);
			});
		}
		return this;
	}
}
