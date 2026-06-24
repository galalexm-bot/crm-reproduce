using System.Web.Hosting;

namespace Orchard.FileSystems.AppData;

public class AppDataFolderRoot : IAppDataFolderRoot, ISingletonDependency, IDependency
{
	public string RootPath => "~/App_Data";

	public string RootFolder => HostingEnvironment.MapPath(RootPath);
}
