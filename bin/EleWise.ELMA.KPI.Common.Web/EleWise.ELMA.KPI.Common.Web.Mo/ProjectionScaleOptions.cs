using System.Collections.Generic;

namespace EleWise.ELMA.KPI.Common.Web.Models;

public class ProjectionScaleOptions
{
	public Dictionary<string, string> VisualizationRootStyles { get; set; }

	public Dictionary<string, string> VisualizationDescriptionStyles { get; set; }

	public Dictionary<string, string> VisualizationScaleStyles { get; set; }

	public string JsonValidationId { get; set; }

	public ProjectionScaleOptions()
	{
		VisualizationRootStyles = new Dictionary<string, string>();
		VisualizationDescriptionStyles = new Dictionary<string, string>();
		VisualizationScaleStyles = new Dictionary<string, string>();
	}
}
