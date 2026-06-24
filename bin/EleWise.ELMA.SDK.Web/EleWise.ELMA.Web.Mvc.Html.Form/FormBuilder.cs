using System;
using System.Linq.Expressions;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Web.Mvc.Models;
using EleWise.ELMA.Web.Mvc.Models.Forms;

namespace EleWise.ELMA.Web.Mvc.Html.Forms;

public class FormBuilder<TModel> : IHtmlString
{
	public FormBuilderModel<TModel> Model { get; set; }

	public HtmlHelper Html { get; set; }

	public FormBuilder(HtmlHelper html, TModel model, ViewType viewType)
	{
		Html = html;
		Model = new FormBuilderModel<TModel>(model, viewType)
		{
			Layout = new DefaultFormLayout()
		};
	}

	public FormBuilder(HtmlHelper html, string elementId, TModel model, ViewType viewType)
	{
		Html = html;
		Model = new FormBuilderModel<TModel>(model, elementId, viewType)
		{
			Layout = new DefaultFormLayout()
		};
	}

	public FormBuilder<TModel> HideAllProperties(bool hide = true)
	{
		Model.HideDefaults = hide;
		return this;
	}

	public FormBuilder<TModel> LayoutTemplate([NotNull] Func<FormBuilderModel<TModel>, object> template)
	{
		if (template == null)
		{
			throw new ArgumentNullException("template");
		}
		Model.LayoutTemplate = template;
		return this;
	}

	public FormBuilder<TModel> LayoutConfig<TLayout>([NotNull] Action<TLayout> layoutConfig) where TLayout : IFormBuilderLayout
	{
		if (layoutConfig == null)
		{
			throw new ArgumentNullException("layoutConfig");
		}
		layoutConfig((TLayout)Model.Layout);
		return this;
	}

	public FormBuilder<TModel> Layout<TLayout>([NotNull] TLayout layoutImpl, Action<TLayout> layoutConfig = null) where TLayout : class, IFormBuilderLayout
	{
		if (layoutImpl == null)
		{
			throw new ArgumentNullException("layoutImpl");
		}
		layoutConfig?.Invoke(layoutImpl);
		Model.Layout = layoutImpl;
		return this;
	}

	public FormBuilder<TModel> Attributes([NotNull] Action<WebViewAttributes> viewAttributes)
	{
		if (viewAttributes == null)
		{
			throw new ArgumentNullException("viewAttributes");
		}
		viewAttributes(Model.Attributes);
		return this;
	}

	public FormBuilder<TModel> Form([NotNull] Action<FormViewModel> formAction)
	{
		if (formAction == null)
		{
			throw new ArgumentNullException("formAction");
		}
		formAction(Model.FormViewModel);
		return this;
	}

	public FormBuilder<TModel> HideForm(bool value = true)
	{
		Model.HideForm = value;
		return this;
	}

	public FormBuilder<TModel> Prefix(string value)
	{
		Model.HtmlInputPrefix = value;
		return this;
	}

	public PropertyRowBuilder<TModel> PropertyRow<TValue>([NotNull] Expression<Func<TModel, TValue>> propertyExpr)
	{
		if (propertyExpr == null)
		{
			throw new ArgumentNullException("propertyExpr");
		}
		string name = ((MemberExpression)propertyExpr.Body).Member.Name;
		return PropertyRow(name);
	}

	public PropertyRowBuilder<TModel> PropertyRow(string propertyName)
	{
		return new PropertyRowBuilder<TModel>(Model.GetPropertyRow(propertyName), Html);
	}

	public FormBuilder<TModel> FilterProperties([NotNull] Func<PropertyInfo, bool> filterDelegate)
	{
		if (filterDelegate == null)
		{
			throw new ArgumentNullException("filterDelegate");
		}
		Model.PropertyVisibleFilters.Add(filterDelegate);
		return this;
	}

	public FormBuilder<TModel> EachPropertyRow([NotNull] Action<PropertyRowModel> action)
	{
		if (action == null)
		{
			throw new ArgumentNullException("action");
		}
		Model.PropertyRowActions.Add(action);
		return this;
	}

	public string ToHtmlString()
	{
		using (new ObjectViewData(Html, Html.get_ViewData(), Model.Model, initialize: true))
		{
			return ((object)Model.Render(Html)).ToString();
		}
	}

	public override string ToString()
	{
		return ToHtmlString();
	}
}
public class FormBuilder : IHtmlString
{
	public FormBuilderModel Model { get; set; }

	public HtmlHelper Html { get; set; }

	public FormBuilder(HtmlHelper html, object model, ViewType viewType)
	{
		Html = html;
		Model = new FormBuilderModel(model, viewType)
		{
			Layout = new DefaultFormLayout()
		};
	}

	public FormBuilder(HtmlHelper html, string formUid, object model, ViewType viewType)
	{
		Html = html;
		Model = new FormBuilderModel(model, viewType, formUid)
		{
			Layout = new DefaultFormLayout()
		};
	}

	public FormBuilder HideAllProperties(bool hide = true)
	{
		Model.HideDefaults = hide;
		return this;
	}

	public FormBuilder LayoutTemplate([NotNull] Func<FormBuilderModel, object> template)
	{
		if (template == null)
		{
			throw new ArgumentNullException("template");
		}
		Model.LayoutTemplate = template;
		return this;
	}

	public FormBuilder LayoutConfig<TLayout>([NotNull] Action<TLayout> layoutConfig) where TLayout : IFormBuilderLayout
	{
		if (layoutConfig == null)
		{
			throw new ArgumentNullException("layoutConfig");
		}
		layoutConfig((TLayout)Model.Layout);
		return this;
	}

	public FormBuilder Layout<TLayout>([NotNull] TLayout layoutImpl, Action<TLayout> layoutConfig = null) where TLayout : class, IFormBuilderLayout
	{
		if (layoutImpl == null)
		{
			throw new ArgumentNullException("layoutImpl");
		}
		layoutConfig?.Invoke(layoutImpl);
		Model.Layout = layoutImpl;
		return this;
	}

	public FormBuilder Attributes([NotNull] Action<WebViewAttributes> viewAttributes)
	{
		if (viewAttributes == null)
		{
			throw new ArgumentNullException("viewAttributes");
		}
		viewAttributes(Model.Attributes);
		return this;
	}

	public FormBuilder Form([NotNull] Action<FormViewModel> formAction)
	{
		if (formAction == null)
		{
			throw new ArgumentNullException("formAction");
		}
		formAction(Model.FormViewModel);
		return this;
	}

	public FormBuilder HideForm(bool value = true)
	{
		Model.HideForm = value;
		return this;
	}

	public FormBuilder Prefix(string value)
	{
		Model.HtmlInputPrefix = value;
		return this;
	}

	public PropertyRowBuilder PropertyRow(string propertyName)
	{
		return new PropertyRowBuilder(Model.GetPropertyRow(propertyName), Html);
	}

	public FormBuilder FilterProperties([NotNull] Func<PropertyInfo, bool> filterDelegate)
	{
		if (filterDelegate == null)
		{
			throw new ArgumentNullException("filterDelegate");
		}
		Model.PropertyVisibleFilters.Add(filterDelegate);
		return this;
	}

	public FormBuilder EachPropertyRow([NotNull] Action<PropertyRowModel> action)
	{
		if (action == null)
		{
			throw new ArgumentNullException("action");
		}
		Model.PropertyRowActions.Add(action);
		return this;
	}

	public string ToHtmlString()
	{
		using (new ObjectViewData(Html, Html.get_ViewData(), Model.FormModel, initialize: true))
		{
			return ((object)Model.Render(Html)).ToString();
		}
	}

	public override string ToString()
	{
		return ToHtmlString();
	}
}
