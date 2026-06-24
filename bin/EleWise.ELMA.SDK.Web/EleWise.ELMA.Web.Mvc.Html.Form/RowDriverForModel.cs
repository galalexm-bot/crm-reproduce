using System;
using System.Web.Mvc;

namespace EleWise.ELMA.Web.Mvc.Html.Forms;

public class RowDriverForModel<TModel> : RowDriver
{
	public new Func<HtmlHelper<TModel>, TModel, bool, MvcHtmlString> RenderCaption
	{
		get
		{
			if (base.RenderCaption == null)
			{
				return null;
			}
			return (HtmlHelper<TModel> helper, TModel model, bool arg3) => base.RenderCaption((HtmlHelper)(object)helper, model, arg3);
		}
		set
		{
			if (value == null)
			{
				base.RenderCaption = null;
				return;
			}
			base.RenderCaption = (HtmlHelper helper, object o, bool arg3) => helper.HtmlHelperFunc((TModel)o, (HtmlHelper<TModel> htmlHelper) => value(htmlHelper, (TModel)o, arg3));
		}
	}

	public new Func<HtmlHelper<TModel>, TModel, MvcHtmlString> RenderValue
	{
		get
		{
			if (base.RenderValue == null)
			{
				return null;
			}
			return (HtmlHelper<TModel> helper, TModel model) => base.RenderValue((HtmlHelper)(object)helper, model);
		}
		set
		{
			if (value == null)
			{
				base.RenderValue = null;
				return;
			}
			base.RenderValue = (HtmlHelper helper, object o) => helper.HtmlHelperFunc((TModel)o, (HtmlHelper<TModel> htmlHelper) => value(htmlHelper, (TModel)o));
		}
	}

	public new Func<HtmlHelper<TModel>, TModel, MvcHtmlString> RenderEditor
	{
		get
		{
			if (base.RenderEditor == null)
			{
				return null;
			}
			return (HtmlHelper<TModel> helper, TModel model) => base.RenderEditor((HtmlHelper)(object)helper, model);
		}
		set
		{
			if (value == null)
			{
				base.RenderEditor = null;
				return;
			}
			base.RenderEditor = (HtmlHelper helper, object o) => helper.HtmlHelperFunc((TModel)o, (HtmlHelper<TModel> htmlHelper) => value(htmlHelper, (TModel)o));
		}
	}

	public new Func<HtmlHelper<TModel>, TModel, MvcHtmlString> RenderDescription
	{
		get
		{
			if (base.RenderDescription == null)
			{
				return null;
			}
			return (HtmlHelper<TModel> helper, TModel model) => base.RenderDescription((HtmlHelper)(object)helper, model);
		}
		set
		{
			if (value == null)
			{
				base.RenderDescription = null;
				return;
			}
			base.RenderDescription = (HtmlHelper helper, object o) => helper.HtmlHelperFunc((TModel)o, (HtmlHelper<TModel> htmlHelper) => value(htmlHelper, (TModel)o));
		}
	}

	protected RowDriverForModel(string propertyName, Type realType = null)
		: base(realType ?? typeof(TModel), propertyName)
	{
	}

	public override MvcHtmlString Caption(HtmlHelper html, object model, bool forDisplay)
	{
		return html.HtmlHelperFunc((TModel)model, (HtmlHelper<TModel> helper) => RowCaption(helper, helper.get_ViewData().get_Model(), forDisplay));
	}

	public override MvcHtmlString Value(HtmlHelper html, object model)
	{
		return html.HtmlHelperFunc((TModel)model, (HtmlHelper<TModel> helper) => RowValue(helper, helper.get_ViewData().get_Model()));
	}

	public override MvcHtmlString Editor(HtmlHelper html, object model)
	{
		return html.HtmlHelperFunc((TModel)model, (HtmlHelper<TModel> helper) => RowEditor(helper, helper.get_ViewData().get_Model()));
	}

	public override MvcHtmlString Description(HtmlHelper html, object model)
	{
		return html.HtmlHelperFunc((TModel)model, (HtmlHelper<TModel> helper) => RowDescription(helper, helper.get_ViewData().get_Model()));
	}

	public virtual MvcHtmlString RowCaption(HtmlHelper<TModel> html, TModel rowModel, bool forDisplay)
	{
		if (RenderCaption == null)
		{
			return MvcHtmlString.Empty;
		}
		return RenderCaption(html, rowModel, forDisplay);
	}

	public virtual MvcHtmlString RowValue(HtmlHelper<TModel> html, TModel rowModel)
	{
		if (RenderValue == null)
		{
			return MvcHtmlString.Empty;
		}
		return RenderValue(html, rowModel);
	}

	public virtual MvcHtmlString RowEditor(HtmlHelper<TModel> html, TModel rowModel)
	{
		if (RenderEditor == null)
		{
			return MvcHtmlString.Empty;
		}
		return RenderEditor(html, rowModel);
	}

	public virtual MvcHtmlString RowDescription(HtmlHelper<TModel> html, TModel rowModel)
	{
		if (RenderDescription == null)
		{
			return MvcHtmlString.Empty;
		}
		return RenderDescription(html, rowModel);
	}
}
