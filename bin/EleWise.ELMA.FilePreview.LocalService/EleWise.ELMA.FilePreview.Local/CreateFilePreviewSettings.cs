using System.Configuration;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Packaging;

namespace EleWise.ELMA.FilePreview.LocalService.Services;

[Service]
public class CreateFilePreviewSettings : ICreateFilePreviewSettings
{
	private const long DefaultMaxMemorySize = 524288000L;

	private const int DefaultMaxProcessingTime = 60000;

	private const int DefaultDomainHealthCheckPeriod = 1000;

	private const int DefaultCheckQueuePeriod = 1000;

	public long MaxMemorySize { get; }

	public int MaxProcessingTime { get; }

	public int DomainHealthCheckPeriod { get; }

	public int CheckQueuePeriod { get; }

	public string FilePreviewCreatorRoot { get; }

	public CreateFilePreviewSettings(PackageService packageService)
	{
		double.TryParse(ConfigurationManager.AppSettings["CreateFilePreview.MaxMemorySize"], out var result);
		double.TryParse(ConfigurationManager.AppSettings["CreateFilePreview.MaxProcessingTime"], out var result2);
		int.TryParse(ConfigurationManager.AppSettings["CreateFilePreview.DomainHealthCheckPeriod"], out var result3);
		int.TryParse(ConfigurationManager.AppSettings["CreateFilePreview.CheckQueuePeriod"], out var result4);
		MaxMemorySize = ((result <= 0.0) ? 524288000 : ((long)(result * 1024.0 * 1024.0)));
		MaxProcessingTime = ((result2 <= 0.0) ? 60000 : ((int)(result2 * 1000.0)));
		DomainHealthCheckPeriod = ((result3 <= 0) ? 1000 : result3);
		CheckQueuePeriod = ((result4 <= 0) ? 1000 : result4);
		packageService.CheckInitialized();
		IElmaComponent component = packageService.GetComponent("FilePreviewCreator");
		FilePreviewCreatorRoot = component.ComponentRoot;
	}
}
