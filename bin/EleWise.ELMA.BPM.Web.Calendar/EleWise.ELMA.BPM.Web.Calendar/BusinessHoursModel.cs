using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace EleWise.ELMA.BPM.Web.Calendar.Models;

public sealed class BusinessHoursModel
{
	private const string TimeFormat = "hh\\:mm";

	[JsonProperty("startTime")]
	public string StartTime { get; set; }

	[JsonProperty("endTime")]
	public string EndTime { get; set; }

	[JsonProperty("daysOfWeek")]
	public int[] DaysOfWeek { get; set; }

	public BusinessHoursModel()
	{
	}

	public BusinessHoursModel(List<int> daysOfWeek, TimeSpan startTime, TimeSpan endTime)
	{
		StartTime = startTime.ToString("hh\\:mm");
		EndTime = endTime.ToString("hh\\:mm");
		DaysOfWeek = daysOfWeek.ToArray();
	}
}
