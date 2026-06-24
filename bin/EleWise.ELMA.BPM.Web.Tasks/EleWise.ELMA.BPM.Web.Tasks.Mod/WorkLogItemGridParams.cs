using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web.Routing;
using EleWise.ELMA.BPM.Web.Tasks.Components;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.Models;

public class WorkLogItemGridParams
{
	private DateTime? dateTo;

	private DateTime? dateFrom;

	public string[] ExtP { get; set; }

	public string GridId { get; set; }

	public bool SimpleSearch { get; set; }

	public string DefSort { get; set; }

	public ListSortDirection? DefDir { get; set; }

	public WorkLogSummaryTableMode? Mode { get; set; }

	public long? User { get; set; }

	public bool MyDepartment { get; set; }

	public Guid? ObjectUid { get; set; }

	public long? ObjectId { get; set; }

	public DateTime? DateTo
	{
		get
		{
			if (!dateTo.HasValue)
			{
				if (!string.IsNullOrEmpty(DateToUrl))
				{
					return Convert.ToDateTime(DateToUrl);
				}
				return null;
			}
			return dateTo.Value;
		}
		set
		{
			dateTo = value;
		}
	}

	public DateTime? DateFrom
	{
		get
		{
			if (!dateFrom.HasValue)
			{
				if (!string.IsNullOrEmpty(DateFromUrl))
				{
					return Convert.ToDateTime(DateFromUrl);
				}
				return null;
			}
			return dateFrom.Value;
		}
		set
		{
			dateFrom = value;
		}
	}

	public string DateToUrl { get; set; }

	public string DateFromUrl { get; set; }

	public bool ShowDraft { get; set; }

	public bool DisableSecurity { get; set; }

	public string Ids { get; set; }

	public WorkLogItemStatus? Status { get; set; }

	public long? ActivityId { get; set; }

	public void SetExtParam(string key, string value)
	{
		string text = $"{key}={value}";
		int? extParamIndex = GetExtParamIndex(key);
		List<string> list = null;
		if (!extParamIndex.HasValue)
		{
			list = ((ExtP == null) ? new List<string>() : new List<string>(ExtP));
			list.Add(text);
		}
		else
		{
			ExtP[extParamIndex.Value] = text;
			list = new List<string>(ExtP);
		}
		ExtP = list.ToArray();
	}

	public string GetExtParam(string key)
	{
		int? extParamIndex = GetExtParamIndex(key);
		if (!extParamIndex.HasValue)
		{
			return null;
		}
		return ExtP[extParamIndex.Value].Substring(key.Length + 1);
	}

	private int? GetExtParamIndex(string key)
	{
		if (string.IsNullOrEmpty(key))
		{
			throw new Exception(SR.T("Неверное имя параметра"));
		}
		if (ExtP == null || ExtP.Length == 0)
		{
			return null;
		}
		for (int i = 0; i < ExtP.Length; i++)
		{
			string text = ExtP[i];
			if (!string.IsNullOrEmpty(text) && text.Substring(0, key.Length + 1).ToLower() == key.ToLower() + "=")
			{
				return i;
			}
		}
		return null;
	}

	public RouteValueDictionary ToRouteValueDictionary(bool toUrl = false)
	{
		RouteValueDictionary routeDic = new RouteValueDictionary();
		Action<string, object> action = delegate(string key, object value)
		{
			routeDic.Add($"Parameters.{key}", value);
		};
		Func<DateTime?, string> func = (DateTime? d) => (!d.HasValue) ? "" : d.Value.ToString("d.M.yyyy HH:mm:ss");
		if (SimpleSearch)
		{
			action("SimpleSearch", SimpleSearch);
		}
		if (User.HasValue)
		{
			action("User", User);
		}
		if (ObjectUid.HasValue)
		{
			action("ObjectUid", ObjectUid);
		}
		if (ObjectId.HasValue)
		{
			action("ObjectId", ObjectId);
		}
		if (Mode.HasValue)
		{
			action("Mode", Mode);
		}
		if (ShowDraft)
		{
			action("ShowDraft", ShowDraft);
		}
		if (MyDepartment)
		{
			action("MyDepartment", MyDepartment);
		}
		if (toUrl)
		{
			if (DateFrom.HasValue)
			{
				action("DateFromUrl", func(DateFrom));
			}
			if (DateTo.HasValue)
			{
				action("DateToUrl", func(DateTo));
			}
		}
		else
		{
			if (DateFrom.HasValue)
			{
				action("DateFrom", DateFrom);
			}
			if (DateTo.HasValue)
			{
				action("DateTo", DateTo);
			}
		}
		if (!string.IsNullOrEmpty(DefSort))
		{
			action("DefSort", DefSort);
		}
		if (DefDir.HasValue)
		{
			action("DefDir", DefDir);
		}
		if (DisableSecurity)
		{
			action("DisableSecurity", DisableSecurity);
		}
		if (!string.IsNullOrEmpty(Ids))
		{
			action("Ids", Ids);
		}
		if (!string.IsNullOrEmpty(GridId))
		{
			action("GridId", GridId);
		}
		if (Status.HasValue)
		{
			action("Status", Status);
		}
		if (ActivityId.HasValue)
		{
			action("ActivityId", ActivityId);
		}
		if (ExtP != null && ExtP.Length != 0)
		{
			int num = 0;
			foreach (string item in ExtP.Where((string s) => !string.IsNullOrEmpty(s)))
			{
				action($"ExtP[{num}]", item);
				num++;
			}
		}
		return routeDic;
	}
}
