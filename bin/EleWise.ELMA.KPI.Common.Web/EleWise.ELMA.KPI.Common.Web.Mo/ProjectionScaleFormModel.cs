using EleWise.ELMA.KPI.Models;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.KPI.Common.Web.Models;

public class ProjectionScaleFormModel
{
	public IProjectionScale ProjectionScale { get; set; }

	public string JsonData { get; set; }

	public string ScaleId { get; set; }

	public bool IsPopup { get; set; }

	public SavePopupProperties SavePopupProperties { get; set; }

	public string ItemsJsonData { get; set; }

	public ProjectionScaleOptions Options { get; set; }

	public ProjectionScaleFormModel()
		: this(null, "defaultScale")
	{
	}

	public ProjectionScaleFormModel(IProjectionScale scale, string scaleId, ProjectionScaleOptions options = null)
	{
		if (scale == null)
		{
			scale = InterfaceActivator.Create<IProjectionScale>();
		}
		ProjectionScale = scale;
		ScaleId = scaleId;
		JsonData = "";
		Options = options ?? new ProjectionScaleOptions();
	}

	public void AddVisualizationStyle(string key, string value)
	{
		Options.VisualizationRootStyles.Add(key, value);
	}

	public void AddVisualizationDescriptionStyle(string key, string value)
	{
		Options.VisualizationDescriptionStyles.Add(key, value);
	}

	public void AddVisualizationScaleStyle(string key, string value)
	{
		Options.VisualizationScaleStyles.Add(key, value);
	}
}
