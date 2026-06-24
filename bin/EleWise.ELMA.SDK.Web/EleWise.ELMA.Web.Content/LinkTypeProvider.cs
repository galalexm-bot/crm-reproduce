using System;
using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Web.Content;

public abstract class LinkTypeProvider
{
	public virtual bool ShowInTree => true;

	public virtual string Category => SR.M("Активные ссылки");

	public virtual string Image => null;

	public virtual string ActionType => null;

	public virtual bool IsAvalilable(RequestContext requestContext)
	{
		return true;
	}

	protected abstract string ValueElement(HtmlHelper htmlHelper);

	protected abstract string TextElement(HtmlHelper htmlHelper);

	public virtual MvcHtmlString GetSelectedScript(HtmlHelper htmlHelper)
	{
		return MvcHtmlString.Create("{var value = $('#" + ValueElement(htmlHelper) + "').val(); var text = $('#" + TextElement(htmlHelper) + "').val(); if(!!value) {({value: value, text: text})} else undefined}");
	}

	public virtual MvcHtmlString GetRunScript(HtmlHelper htmlHelper)
	{
		return MvcHtmlString.Create("jAlert('" + SR.T("Запуск из диалога настроек не поддерживается компонентом") + "', '" + SR.T("Предупреждение") + "')");
	}

	public virtual MvcHtmlString RenderActionView(HtmlHelper htmlHelper, IContentAction contentAction)
	{
		return null;
	}

	public virtual string GetActionName([NotNull] IContentAction contentAction)
	{
		if (contentAction == null)
		{
			throw new ArgumentNullException("contentAction");
		}
		if (string.IsNullOrEmpty(contentAction.Name))
		{
			return contentAction.Id;
		}
		return contentAction.Name;
	}
}
