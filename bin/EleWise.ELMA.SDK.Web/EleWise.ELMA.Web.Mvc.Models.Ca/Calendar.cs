using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Web.Mvc.Models.Calendar;

public class Calendar
{
	public string Id { get; set; }

	public List<DateTime> Dates { get; set; }

	public DateTime Value { get; set; }

	public string Action { get; set; }

	public string Controller { get; set; }

	public object RouteValues { get; set; }

	public string OnChange { get; set; }

	public object HtmlAttributes { get; set; }

	public bool ShowWeekNumbers { get; set; }

	public Calendar()
	{
		Value = DateTime.Now;
		Dates = new List<DateTime>();
		RouteValues = new { };
		ShowWeekNumbers = false;
	}
}
