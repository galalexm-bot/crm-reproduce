using System;
using System.Collections.Generic;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.Web.Mvc.Models.Chartjs;

public class LineChartData
{
	public List<Pair<DateTime, DateTime>> dates { get; private set; }

	public List<string> labels { get; private set; }

	public List<ChartDataset> datasets { get; private set; }

	public long? lineTodayAtIndex { get; set; }

	public string lineTodayColor { get; set; }

	public DateTime MaxDateValue { get; set; }

	public DateTime MinDateFromAll { get; set; }

	public LineChartData(List<Pair<DateTime, DateTime>> dates, List<string> labels, List<ChartDataset> datasets)
	{
		this.dates = dates;
		this.labels = labels;
		this.datasets = datasets;
	}

	public LineChartData()
	{
		labels = new List<string>();
		datasets = new List<ChartDataset>();
		dates = new List<Pair<DateTime, DateTime>>();
	}

	public string ToJson()
	{
		return new JsonSerializer().Serialize(this);
	}
}
