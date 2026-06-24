using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web.Mvc;
using System.Web.WebPages;

namespace EleWise.ELMA.Web.Mvc.Html;

public class CombinedEditablePropertyBuilder<TModel>
{
	private HtmlHelper<TModel> html;

	private IList<CombinedContentModel<TModel>> content;

	private Action<WebViewAttributes> viewAttributesAction;

	private string buttonText;

	private bool onlyContent;

	public CombinedEditablePropertyBuilder(HtmlHelper<TModel> html)
	{
		this.html = html;
		onlyContent = false;
		content = new List<CombinedContentModel<TModel>>();
	}

	public CombinedEditablePropertyBuilder<TModel> ViewAttributesAction(Action<WebViewAttributes> viewAttributesAction)
	{
		this.viewAttributesAction = viewAttributesAction;
		return this;
	}

	public CombinedEditablePropertyBuilder<TModel> ButtonText(string buttonText)
	{
		this.buttonText = buttonText;
		return this;
	}

	public CombinedEditablePropertyBuilder<TModel> OnlyContent(bool onlyContent)
	{
		this.onlyContent = onlyContent;
		return this;
	}

	public CombinedEditablePropertyBuilder<TModel> Add(Expression<Func<TModel, dynamic>> expression)
	{
		Add(expression, null, null, null);
		return this;
	}

	public CombinedEditablePropertyBuilder<TModel> Add(Expression<Func<TModel, dynamic>> expression, Action<WebViewAttributes> viewAttributesAction, Func<dynamic, HelperResult> editorTemplate)
	{
		Add(expression, editorTemplate, null, viewAttributesAction);
		return this;
	}

	public CombinedEditablePropertyBuilder<TModel> Add(string expression)
	{
		Add(expression, null, null, null);
		return this;
	}

	public CombinedEditablePropertyBuilder<TModel> Add(string expression, Action<WebViewAttributes> viewAttributesAction, Func<dynamic, HelperResult> editorTemplate)
	{
		Add(expression, editorTemplate, null, viewAttributesAction);
		return this;
	}

	public CombinedEditablePropertyBuilder<TModel> Add(Expression<Func<TModel, dynamic>> expression, Func<dynamic, HelperResult> customMarkup)
	{
		Add(expression, null, customMarkup, null);
		return this;
	}

	public CombinedEditablePropertyBuilder<TModel> Add(string expression, Func<dynamic, HelperResult> customMarkup)
	{
		Add(expression, null, customMarkup, null);
		return this;
	}

	public CombinedEditablePropertyBuilder<TModel> Add(Func<dynamic, HelperResult> customMarkup)
	{
		Add((string)null, (Func<dynamic, HelperResult>)null, customMarkup, (Action<WebViewAttributes>)null);
		return this;
	}

	public CombinedEditablePropertyBuilder<TModel> Add(Expression<Func<TModel, dynamic>> expression, Func<dynamic, HelperResult> editorTemplate, Func<dynamic, HelperResult> customMarkup, Action<WebViewAttributes> viewAttributesAction)
	{
		content.Add(new CombinedContentModel<TModel>
		{
			Expression = expression,
			ViewAttributesAction = viewAttributesAction,
			EditorTemplate = editorTemplate,
			СustomMarkup = customMarkup
		});
		return this;
	}

	public CombinedEditablePropertyBuilder<TModel> Add(string expression, Func<dynamic, HelperResult> editorTemplate, Func<dynamic, HelperResult> customMarkup, Action<WebViewAttributes> viewAttributesAction)
	{
		content.Add(new CombinedContentModel<TModel>
		{
			ExpressionText = expression,
			ViewAttributesAction = viewAttributesAction,
			EditorTemplate = editorTemplate,
			СustomMarkup = customMarkup
		});
		return this;
	}

	public MvcHtmlString Render()
	{
		return html.CombinedEditableProperty(buttonText, viewAttributesAction, content, onlyContent);
	}
}
