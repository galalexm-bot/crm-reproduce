using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.Routing;
using EleWise.ELMA.BPM.Web.Tasks.Models;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.KPI.Models.Performance;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Tasks.Extensions;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.Extensions;

public static class PerformanceDisciplineExtensions
{
	public static MvcHtmlString GetDisciplineTotalTasksLink(this HtmlHelper html, IUser user, DateTime periodStart, DateTime periodEnd, string title)
	{
		RouteValueDictionary routeValueDictionary = new RouteValueDictionary
		{
			{ "area", "EleWise.ELMA.BPM.Web.Tasks" },
			{
				"Filter.Query",
				user.GetDisciplineTotalTasksQuery(periodStart, periodEnd)
			}
		};
		return LinkExtensions.ActionLink(html, title, "Search", "AllTasks", routeValueDictionary, (IDictionary<string, object>)null);
	}

	public static MvcHtmlString GetActiveTasksLink(this HtmlHelper html, IUser user, long count)
	{
		RouteValueDictionary routeValueDictionary = new RouteValueDictionary
		{
			{ "area", "EleWise.ELMA.BPM.Web.Tasks" },
			{
				"Filter.CompleteStatus",
				TaskCompleteStatus.Active
			},
			{ "Filter.Executors[0].Id", user.Id }
		};
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add("onclick", "event.stopImmediatePropagation(); window.location.href = this.href;");
		return LinkExtensions.ActionLink(html, count.ToString(), "Search", "AllTasks", routeValueDictionary, (IDictionary<string, object>)dictionary);
	}

	public static MvcHtmlString GetDisciplineWellDoneLink(this HtmlHelper html, IUser user, DateTime periodStart, DateTime periodEnd, string title)
	{
		RouteValueDictionary routeValueDictionary = new RouteValueDictionary
		{
			{ "area", "EleWise.ELMA.BPM.Web.Tasks" },
			{
				"Filter.Query",
				user.GetDisciplineWellDoneQuery(periodStart, periodEnd)
			}
		};
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add("style", "color:#008000");
		return LinkExtensions.ActionLink(html, title, "Search", "AllTasks", routeValueDictionary, (IDictionary<string, object>)dictionary);
	}

	public static MvcHtmlString GetDisciplineProtractedLink(this HtmlHelper html, IUser user, DateTime periodStart, DateTime periodEnd, string title)
	{
		RouteValueDictionary routeValueDictionary = new RouteValueDictionary
		{
			{ "area", "EleWise.ELMA.BPM.Web.Tasks" },
			{
				"Filter.Query",
				user.GetDisciplineProtractedQuery(periodStart, periodEnd)
			}
		};
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add("style", "color:#FF0000");
		return LinkExtensions.ActionLink(html, title, "Search", "AllTasks", routeValueDictionary, (IDictionary<string, object>)dictionary);
	}

	public static MvcHtmlString GetProtractedTasksLink(this HtmlHelper html, IUser user, long count)
	{
		RouteValueDictionary routeValueDictionary = new RouteValueDictionary
		{
			{ "area", "EleWise.ELMA.BPM.Web.Tasks" },
			{
				"Filter.CompleteStatus",
				TaskCompleteStatus.Expired
			},
			{ "Filter.Executors[0].Id", user.Id }
		};
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add("style", "color:#FF0000");
		dictionary.Add("onclick", "event.stopImmediatePropagation(); window.location.href = this.href;");
		return LinkExtensions.ActionLink(html, count.ToString(), "Search", "AllTasks", routeValueDictionary, (IDictionary<string, object>)dictionary);
	}

	public static MvcHtmlString UserPerformance(this HtmlHelper html, CompanyUser user)
	{
		string text = "keyfeature-text";
		switch (user.KeyFeature)
		{
		case KeyIndicator.Discipline:
		{
			PerformanceDiscipline performanceDiscipline = user.PerformanceDiscipline;
			return MvcHtmlString.Create(string.Format(arg1: (performanceDiscipline.ProcentWellDone > 90.0) ? (text + " green") : ((!(performanceDiscipline.ProcentWellDone > 50.0)) ? (text + " red") : (text + " yellow")), format: "<div><span class=\"{1}\">{0}</span></div>", arg0: (performanceDiscipline.ProcentWellDone / 100.0).ToString("P1")));
		}
		case KeyIndicator.NumTasks:
		{
			MvcHtmlString protractedTasksLink = html.GetProtractedTasksLink(user.User, user.NumTasks.First);
			MvcHtmlString activeTasksLink = html.GetActiveTasksLink(user.User, user.NumTasks.Second);
			return MvcHtmlString.Create($"<div><span class='keyfeature-text red'>{protractedTasksLink}</span><span class='keyfeature-text'> / {activeTasksLink}</span></div>");
		}
		case KeyIndicator.WorkLog:
		{
			long first = user.WorkLog.First;
			long second = user.WorkLog.Second;
			double num = ((first + second == 0L) ? 0.0 : (100.0 * (double)first / (double)(first + second)));
			return MvcHtmlString.Create(string.Format(arg1: (num > 90.0) ? (text + " green") : ((!(num > 50.0)) ? (text + " red") : (text + " yellow")), format: "<div><span class=\"{1}\">{0}</span></div>", arg0: PartialExtensions.Partial(html, "DisplayTemplates/WorkTimeCompact", (object)new WorkTime(first))));
		}
		default:
			return MvcHtmlString.Empty;
		}
	}
}
