using System.Collections.Generic;

namespace EleWise.ELMA.Web.Mvc.Models.Chartjs;

public class ChartDataset
{
	public string label { get; set; }

	public string fillColor { get; set; }

	public string strokeColor { get; set; }

	public string pointColor { get; set; }

	public string pointStrokeColor { get; set; }

	public string pointHighlightFill { get; set; }

	public string pointHighlightStroke { get; set; }

	public List<long> dashStyle { get; set; }

	public List<double> data { get; set; }

	public bool? hide { get; set; }

	public bool? impulse { get; set; }
}
