namespace Orchard.FileSystems.AppData;

public interface IAppDataFolderRoot : ISingletonDependency, IDependency
{
	string RootPath { get; }

	string RootFolder { get; }
}
