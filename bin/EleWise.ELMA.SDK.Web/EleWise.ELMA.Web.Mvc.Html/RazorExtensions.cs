using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.WebPages;
using EleWise.ELMA.Actions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Actions;
using EleWise.ELMA.Web.Content;

namespace EleWise.ELMA.Web.Mvc.Html;

public static class RazorExtensions
{
	public static IHtmlString Repeat(int times, Func<int, object> template)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < times; i++)
		{
			stringBuilder.Append(template(i));
		}
		return new HtmlString(stringBuilder.ToString());
	}

	public static HelperResult Repeat<T>(this IEnumerable<T> items, Func<T, HelperResult> template)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		if (items != null)
		{
			return new HelperResult((Action<TextWriter>)delegate(TextWriter writer)
			{
				foreach (T item in items)
				{
					template(item).WriteTo(writer);
				}
			});
		}
		return new HelperResult((Action<TextWriter>)delegate(TextWriter textWriter)
		{
			textWriter.Write("");
		});
	}

	public static IHtmlString B(string text)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		TagBuilder val = new TagBuilder("b");
		val.SetInnerText(text);
		return new HtmlString(((object)val).ToString());
	}

	public static MvcHtmlString EmptyFormAction([NotNull] this HtmlHelper html, [NotNull] ActionRoute actionRoute, [NotNull] string formId)
	{
		if (html == null)
		{
			throw new ArgumentNullException("html");
		}
		if (actionRoute == null)
		{
			throw new ArgumentNullException("actionRoute");
		}
		if (formId == null)
		{
			throw new ArgumentNullException("formId");
		}
		return PartialExtensions.Partial(html, "Templates/EmptyActionForm", (object)new ActionFormViewModel
		{
			FormId = formId,
			Route = actionRoute
		});
	}

	public static MvcHtmlString IfAction(this MvcHtmlString htmlString, string objectUid, string actionUid, params object[] methodArgs)
	{
		if (Locator.GetServiceNotNull<ActionDispatcherService>().CheckAction(objectUid, actionUid, methodArgs))
		{
			return htmlString;
		}
		return MvcHtmlString.Empty;
	}

	public static MvcHtmlString IfActionFor<TManager>([NotNull] this HtmlHelper html, [NotNull] Expression<Action<TManager>> expression, [NotNull] Func<object, object> template) where TManager : IEntityManager
	{
		if (html == null)
		{
			throw new ArgumentNullException("html");
		}
		if (expression == null)
		{
			throw new ArgumentNullException("expression");
		}
		if (template == null)
		{
			throw new ArgumentNullException("template");
		}
		if (Locator.GetServiceNotNull<ActionDispatcherService>().CheckAction(expression))
		{
			return MvcHtmlString.Create(new StringBuilder().Append(template(html)).ToString());
		}
		return MvcHtmlString.Empty;
	}

	public static MvcHtmlString ActionLinkFor<TManager>([NotNull] this HtmlHelper html, [NotNull] Expression<Action<TManager>> expression, bool checkAction = true, IDictionary<string, object> htmlAttributes = null) where TManager : IEntityManager
	{
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		if (html == null)
		{
			throw new ArgumentNullException("html");
		}
		if (expression == null)
		{
			throw new ArgumentNullException("expression");
		}
		ActionDispatcherService serviceNotNull = Locator.GetServiceNotNull<ActionDispatcherService>();
		ContentDispatchActionService serviceNotNull2 = Locator.GetServiceNotNull<ContentDispatchActionService>();
		if (!checkAction || serviceNotNull.CheckAction(expression))
		{
			IAuditEventArgs actionInfoFor = serviceNotNull.GetActionInfoFor(expression);
			if (actionInfoFor != null)
			{
				IContentDispatchAction eventAction = serviceNotNull2.GetEventAction(actionInfoFor.Object, actionInfoFor.Action);
				string name = eventAction.Name;
				string href = eventAction.GetHref(((ControllerContext)html.get_ViewContext()).get_RequestContext(), actionInfoFor.ExtendedProperties.Values.ToArray());
				eventAction.OnRender(html, actionInfoFor.ExtendedProperties.Values.ToArray());
				TagBuilder val = new TagBuilder("a");
				val.set_InnerHtml((!string.IsNullOrEmpty(name)) ? HttpUtility.HtmlEncode(name) : string.Empty);
				val.MergeAttributes<string, object>(htmlAttributes);
				val.MergeAttribute("href", href);
				return MvcHtmlString.Create(val.ToString((TagRenderMode)0));
			}
		}
		return MvcHtmlString.Empty;
	}

	public static string ActionFor<TManager>([NotNull] this UrlHelper url, [NotNull] Expression<Action<TManager>> expression) where TManager : IEntityManager
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (expression == null)
		{
			throw new ArgumentNullException("expression");
		}
		ActionDispatcherService serviceNotNull = Locator.GetServiceNotNull<ActionDispatcherService>();
		ContentDispatchActionService serviceNotNull2 = Locator.GetServiceNotNull<ContentDispatchActionService>();
		if (serviceNotNull.CheckAction(expression))
		{
			IAuditEventArgs actionInfoFor = serviceNotNull.GetActionInfoFor(expression);
			if (actionInfoFor != null)
			{
				return serviceNotNull2.GetHref(actionInfoFor.Object, actionInfoFor.Action, url.get_RequestContext(), actionInfoFor.ExtendedProperties.Values.ToArray());
			}
		}
		return "";
	}

	public static MvcHtmlString AsSingleLine(this MvcHtmlString htmlString)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		if (htmlString == null)
		{
			return null;
		}
		return new MvcHtmlString(((HtmlString)(object)htmlString).ToHtmlString().Replace(Environment.NewLine, " "));
	}
}
