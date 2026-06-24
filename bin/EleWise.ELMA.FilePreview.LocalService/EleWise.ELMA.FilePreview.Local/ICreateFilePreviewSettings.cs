namespace EleWise.ELMA.FilePreview.LocalService.Services;

public interface ICreateFilePreviewSettings
{
	long MaxMemorySize { get; }

	int MaxProcessingTime { get; }

	int DomainHealthCheckPeriod { get; }

	int CheckQueuePeriod { get; }

	string FilePreviewCreatorRoot { get; }
}
