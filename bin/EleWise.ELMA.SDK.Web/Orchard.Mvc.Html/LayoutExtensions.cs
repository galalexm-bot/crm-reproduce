using System;
using System.IO;
using System.Linq;
using System.Web.Mvc;
using System.Web.UI;
using System.Web.WebPages;
using Orchard.Localization;
using Orchard.Mvc.ViewEngines;
using Orchard.UI.PageClass;
using Orchard.UI.PageTitle;

namespace Orchard.Mvc.Html;

public static class LayoutExtensions
{
	private class HtmlTextWriterScope : IDisposable
	{
		private readonly HtmlTextWriter _context;

		private readonly TextWriter _writer;

		public HtmlTextWriterScope(HtmlTextWriter context, TextWriter writer)
		{
			_context = context;
			_writer = _context.InnerWriter;
			_context.InnerWriter = writer;
		}

		public void Dispose()
		{
			_context.InnerWriter = _writer;
		}
	}

	public static HelperResult RenderOrchardBody(this HtmlHelper html)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		LayoutViewContext layoutViewContext = LayoutViewContext.From((ControllerContext)(object)html.get_ViewContext());
		return new HelperResult((Action<TextWriter>)delegate(TextWriter writer)
		{
			writer.Write(layoutViewContext.BodyContent);
		});
	}

	public static MvcHtmlString Body(this HtmlHelper html)
	{
		return MvcHtmlString.Create(LayoutViewContext.From((ControllerContext)(object)html.get_ViewContext()).BodyContent);
	}

	public static void AddTitleParts(this HtmlHelper html, params string[] titleParts)
	{
		html.GetWorkContext().Resolve<IPageTitleBuilder>().AddTitleParts(titleParts);
	}

	public static void AppendTitleParts(this HtmlHelper html, params string[] titleParts)
	{
		html.GetWorkContext().Resolve<IPageTitleBuilder>().AppendTitleParts(titleParts);
	}

	public static MvcHtmlString Title(this HtmlHelper html, params string[] titleParts)
	{
		IPageTitleBuilder pageTitleBuilder = html.GetWorkContext().Resolve<IPageTitleBuilder>();
		html.AddTitleParts(titleParts);
		return MvcHtmlString.Create(html.Encode(pageTitleBuilder.GenerateTitle()));
	}

	public static MvcHtmlString TitleForPage(this HtmlHelper html, params string[] titleParts)
	{
		if (titleParts == null || titleParts.Length < 1)
		{
			return null;
		}
		html.AppendTitleParts(titleParts);
		return MvcHtmlString.Create(html.Encode(titleParts[0]));
	}

	public static MvcHtmlString TitleForPage(this HtmlHelper html, params LocalizedString[] titleParts)
	{
		if (titleParts == null || titleParts.Length < 1)
		{
			return null;
		}
		html.AppendTitleParts(titleParts.Select((LocalizedString part) => part.ToString()).ToArray());
		return MvcHtmlString.Create(html.Encode((object)titleParts[0]));
	}

	public static void AddPageClassNames(this HtmlHelper html, params object[] classNames)
	{
		html.GetWorkContext().Resolve<IPageClassBuilder>().AddClassNames(classNames);
	}

	public static MvcHtmlString ClassForPage(this HtmlHelper html, params object[] classNames)
	{
		IPageClassBuilder pageClassBuilder = html.GetWorkContext().Resolve<IPageClassBuilder>();
		html.AddPageClassNames(classNames);
		html.AddPageClassNames(((ControllerContext)html.get_ViewContext()).get_RouteData().Values["area"]);
		return MvcHtmlString.Create(html.Encode(pageClassBuilder.ToString()));
	}

	public static IDisposable Capture(this ViewUserControl control, string name)
	{
		TextWriter namedContent = LayoutViewContext.From((ControllerContext)(object)control.get_ViewContext()).GetNamedContent(name);
		return new HtmlTextWriterScope(control.get_Writer(), namedContent);
	}
}
