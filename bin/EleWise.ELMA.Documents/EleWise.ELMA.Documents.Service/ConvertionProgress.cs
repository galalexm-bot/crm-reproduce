using System;

namespace EleWise.ELMA.Documents.Services;

public class ConvertionProgress
{
	public Guid ConvertionUid { get; set; }

	public ConvertionState ConvertionState { get; set; }

	public int GlobalPercentComplete { get; set; }

	public int LocalPercentComplete { get; set; }

	public string CurrentWorkDescription { get; set; }

	public string CurrentName { get; set; }

	public ConvertionProgress()
	{
		ConvertionUid = Guid.NewGuid();
		ConvertionState = ConvertionState.NotStarted;
		CurrentWorkDescription = string.Empty;
		CurrentName = string.Empty;
	}
}
