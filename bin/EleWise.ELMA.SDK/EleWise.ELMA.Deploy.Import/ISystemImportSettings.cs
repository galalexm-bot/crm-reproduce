namespace EleWise.ELMA.Deploy.Import;

internal interface ISystemImportSettings : IImportSettings
{
	string FileText { get; set; }
}
