using System.Collections.Generic;
using System.IO;
using System.Web.Hosting;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Services;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Packaging;

namespace EleWise.ELMA.Designer.Web.Components;

[Component(Order = int.MaxValue, Type = ComponentType.WebServer, EnableInterceptiors = true)]
internal sealed class WebDesignerModuleEvents : IModuleContainerEvents
{
	private readonly IAutoDeployWithResultService autoDeployWithResultService;

	private readonly PackageService packageService;

	private const string DesignerPackageName = "EleWise.ELMA.BPM.WebDesigner";

	private const string DesignerPackageFullName = "EleWise.ELMA.BPM.WebDesigner.elma4";

	private const string DesignerAutoDeployPackageFullName = "EleWise.ELMA.BPM.WebDesigner.elma4deploy";

	private const string AutoDeployFolderName = "AutoDeploy";

	private const string PackageFolderName = "Package";

	public WebDesignerModuleEvents(IAutoDeployWithResultService autoDeployWithResultService, PackageService packageService)
	{
		this.autoDeployWithResultService = autoDeployWithResultService;
		this.packageService = packageService;
	}

	public void Activated()
	{
		RemoveDesignerAutoDeployModules();
		DeployWebDesigner();
	}

	public void Terminating()
	{
	}

	private void RemoveDesignerAutoDeployModules()
	{
		string path = Path.Combine(packageService.LocalRepositoryPath, "AutoDeploy");
		DirectoryInfo directoryInfo = new DirectoryInfo(path);
		if (directoryInfo.Exists)
		{
			DirectoryInfo[] directories = directoryInfo.GetDirectories("EleWise.ELMA.BPM.WebDesigner*");
			DirectoryInfo[] array = directories;
			foreach (DirectoryInfo directoryInfo2 in array)
			{
				directoryInfo2.Delete(recursive: true);
			}
			FileInfo[] files = directoryInfo.GetFiles("EleWise.ELMA.BPM.WebDesigner*");
			FileInfo[] array2 = files;
			foreach (FileInfo fileInfo in array2)
			{
				fileInfo.Delete();
			}
		}
	}

	private void DeployWebDesigner()
	{
		string text = HostingEnvironment.MapPath(Path.Combine("~/Modules/EleWise.ELMA.Designer.Web/Content/", "Package"));
		if (string.IsNullOrWhiteSpace(text))
		{
			return;
		}
		string text2 = Path.Combine(text, "AutoDeploy");
		if (Directory.Exists(text2))
		{
			try
			{
				Directory.Delete(text2, recursive: true);
			}
			catch
			{
			}
		}
		DirectoryInfo directoryInfo = new DirectoryInfo(text);
		if (!directoryInfo.Exists)
		{
			return;
		}
		FileInfo[] files = directoryInfo.GetFiles("EleWise.ELMA.BPM.WebDesigner*.elma4");
		if (files.Length != 1)
		{
			Logger.Log.Error(SR.T("Не найден файл веб-дизайнера для импорта"));
			return;
		}
		FileInfo[] files2 = directoryInfo.GetFiles("EleWise.ELMA.BPM.WebDesigner*.elma4deploy");
		if (files2.Length != 1)
		{
			Logger.Log.Error(SR.T("Не найден файл деплоя веб-дизайнера для импорта"));
			return;
		}
		string fullName = files[0].FullName;
		string fullName2 = files2[0].FullName;
		if (!File.Exists(fullName) || !File.Exists(fullName2))
		{
			return;
		}
		Directory.CreateDirectory(text2);
		File.Copy(fullName, Path.Combine(text2, "EleWise.ELMA.BPM.WebDesigner.elma4"));
		File.Copy(fullName2, Path.Combine(text2, "EleWise.ELMA.BPM.WebDesigner.elma4deploy"));
		IEnumerable<IDeployResult> enumerable = autoDeployWithResultService.RunAutoDeployWithResult(text2);
		foreach (IDeployResult item in enumerable)
		{
			if (item.HasErrors)
			{
				Logger.Log.Error(item.GetLog());
			}
		}
	}
}
