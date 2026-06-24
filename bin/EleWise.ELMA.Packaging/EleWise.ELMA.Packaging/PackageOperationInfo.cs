using NuGet;

namespace EleWise.ELMA.Packaging;

public class PackageOperationInfo
{
	public PackageInfo Package { get; set; }

	public PackageOperationType Type { get; set; }

	public SemanticVersion InstalledVersion { get; set; }

	public override string ToString()
	{
		if (Package == null)
		{
			return "";
		}
		return Package.ToString() + " - " + ((Type == PackageOperationType.Install) ? SR.T("Установка") : ((Type == PackageOperationType.Update) ? SR.T("Обновление") : SR.T("Удаление")));
	}
}
