namespace EleWise.ELMA.BPM.Web.Common.Models;

public class SoftUpdateStatusModel
{
	public bool IsUpdateFinished { get; set; }

	public bool HasErrors { get; set; }

	public string CurrentOperationDescription { get; set; }
}
