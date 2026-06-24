namespace EleWise.ELMA.Workflow.Models.BackgroundOperations;

public interface IBackgroundOperationResult
{
	byte[] SerializedResult { get; }

	bool IsError { get; }
}
