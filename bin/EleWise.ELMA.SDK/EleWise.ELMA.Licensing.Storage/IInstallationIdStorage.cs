namespace EleWise.ELMA.Licensing.Storages;

internal interface IInstallationIdStorage
{
	string Read();

	bool Write(string value);
}
