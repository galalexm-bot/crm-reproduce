using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.ServiceProcess;
using EleWise.ELMA.Packaging.Components.WebServer.Settings;
using EleWise.ELMA.Packaging.Logging;
using NuGet;

namespace EleWise.ELMA.Packaging.Components.WebServer;

[Export(typeof(WebServerComponent))]
[Export(typeof(IElmaComponent))]
public class WebServerComponent : ElmaComponent
{
	private static class Extern
	{
		[DllImport("kernel32.dll")]
		public static extern IntPtr OpenMutex(uint dwDesiredAccess, bool bInheritHandle, string lpName);
	}

	public const string ID = "WebServer";

	protected const string ServiceFileName = "EleWise.ELMA.WebServer.Service.exe";

	protected const string ShellFileName = "EleWise.ELMA.WebServer.Shell.exe";

	public override string Id => "WebServer";

	public override string Name => SR.T("Веб-сервер");

	public override string RootPackageId => "EleWise.ELMA.WebServer";

	public string WebServicePath => Path.Combine(ComponentRoot, "EleWise.ELMA.WebServer.Service.exe");

	protected override string RelativeComponentRoot => "Service";

	protected virtual TimeSpan ServicePendingTimeout => TimeSpan.FromMinutes(1.0);

	protected virtual string SettingsFileName => Path.Combine(ComponentRoot, "EleWise.ELMA.WebServer.config");

	public override void Install(IEnumerable<string> packages)
	{
		base.Logger.Info(SR.T("Компонент '{0}' устарел - установка не поддерживается.", Id));
	}

	public override void Configure(ElmaComponentSettings settings)
	{
		base.Logger.Info(SR.T("Компонент '{0}' устарел - конфигурирование не поддерживается.", Id));
	}

	public override void Unconfigure()
	{
		base.Unconfigure();
		UninstallService();
	}

	public void ConfigureWebSitePath(string webSitePath)
	{
		base.Logger.Info(SR.T("Компонент '{0}' устарел - конфигурирование не поддерживается.", Id));
	}

	public override bool IsStarted()
	{
		ServiceController service = GetService();
		if (service != null)
		{
			if (service.Status != ServiceControllerStatus.Running && service.Status != ServiceControllerStatus.StartPending)
			{
				return service.Status == ServiceControllerStatus.ContinuePending;
			}
			return true;
		}
		string text = Path.Combine(ComponentRoot, "EleWise.ELMA.WebServer.Shell.exe");
		if (File.Exists(text))
		{
			try
			{
				text = GetFullNameWithCorrectCase(new FileInfo(text));
				string lpName = "Elma3WebServerShell_" + text.GetHashCode();
				return Extern.OpenMutex(1048576u, bInheritHandle: false, lpName) != IntPtr.Zero;
			}
			catch (Exception exception)
			{
				base.Logger.Debug("Cannot check server state", exception);
			}
		}
		return false;
	}

	public override void Start()
	{
		base.Logger.Info(SR.T("Компонент '{0}' устарел - запуск не поддерживается.", Id));
	}

	public override void Stop()
	{
		base.Stop();
		ServiceController service = GetService();
		if (service == null)
		{
			return;
		}
		if (WaitServicePending(service) == ServiceControllerStatus.Stopped)
		{
			base.Logger.Warn(SR.T("Сервис внутреннего сервера уже остановлен."));
			return;
		}
		if (service.Status == ServiceControllerStatus.Running || service.Status == ServiceControllerStatus.Paused)
		{
			base.Logger.Info(SR.T("Остановка сервиса '{0}'...", service.ServiceName));
			try
			{
				service.Stop();
			}
			catch (Exception innerException)
			{
				throw new InvalidOperationException(SR.T("Не удалось остановить сервис '{0}'", service.ServiceName), innerException);
			}
		}
		try
		{
			service.WaitForStatus(ServiceControllerStatus.Stopped);
			base.Logger.Info(SR.T("Сервис '{0}' остановлен.", service.ServiceName));
		}
		catch (Exception innerException2)
		{
			throw new InvalidOperationException(SR.T("Не удалось дождаться завершения остановки сервиса '{0}'", service.ServiceName), innerException2);
		}
	}

	public override void Pause()
	{
		Stop();
	}

	public override void Uninstall()
	{
		base.Uninstall();
		DeleteSettingsFile(SettingsFileName);
	}

	public virtual WebServerSettings LoadSettings()
	{
		return WebServerSettings.Load(SettingsFileName);
	}

	public override IPreparedOperation PrepareInstallPackages(IEnumerable<PackageInfo> packageInfos, bool updateDependencies)
	{
		IPreparedOperation preparedOperation = base.PrepareInstallPackages(packageInfos, updateDependencies);
		if (preparedOperation == null)
		{
			return null;
		}
		return new CompositePreparedOperation(new IPreparedOperation[2]
		{
			preparedOperation,
			new SimplePreparedOperation(CheckServiceDisplayName)
		});
	}

	protected override IElmaProjectSystem CreateProjectSystem()
	{
		return new WebServerProjectSystem(this);
	}

	protected override IEnumerable<IElmaFolder> CreateFolders()
	{
		return new IElmaFolder[1]
		{
			new ElmaContentFolder(this)
		};
	}

	protected static ServiceController GetService(string serviceName)
	{
		return (from s in ServiceController.GetServices()
			where s.ServiceName == serviceName
			select s).FirstOrDefault();
	}

	protected ServiceControllerStatus WaitServicePending(ServiceController service)
	{
		switch (service.Status)
		{
		case ServiceControllerStatus.StartPending:
		case ServiceControllerStatus.ContinuePending:
			try
			{
				base.Logger.Info(SR.T("Ожидание завершения запуска сервиса '{0}'", service.ServiceName));
				service.WaitForStatus(ServiceControllerStatus.Running, ServicePendingTimeout);
			}
			catch (Exception innerException3)
			{
				throw new InvalidOperationException(SR.T("Не удалось дождаться завершения запуска сервиса '{0}'", service.ServiceName), innerException3);
			}
			break;
		case ServiceControllerStatus.PausePending:
			try
			{
				base.Logger.Info(SR.T("Ожидание завершения временной остановки сервиса '{0}'", service.ServiceName));
				service.WaitForStatus(ServiceControllerStatus.Paused, ServicePendingTimeout);
			}
			catch (Exception innerException2)
			{
				throw new InvalidOperationException(SR.T("Не удалось дождаться завершения временной остановки сервиса '{0}'", service.ServiceName), innerException2);
			}
			break;
		case ServiceControllerStatus.StopPending:
			try
			{
				base.Logger.Info(SR.T("Ожидание завершения остановки сервиса '{0}'", service.ServiceName));
				service.WaitForStatus(ServiceControllerStatus.Stopped, ServicePendingTimeout);
			}
			catch (Exception innerException)
			{
				throw new InvalidOperationException(SR.T("Не удалось дождаться завершения остановки сервиса '{0}'", service.ServiceName), innerException);
			}
			break;
		}
		return service.Status;
	}

	protected ServiceController GetService()
	{
		WebServerSettings webServerSettings = LoadSettings();
		return GetService((!string.IsNullOrEmpty(webServerSettings.Service.ServiceName)) ? webServerSettings.Service.ServiceName : ServiceInfo.DefaultServiceName);
	}

	protected void InstallService()
	{
		base.Logger.Info(SR.T("Установка сервиса внутреннего сервера..."));
		Process process = new Process();
		process.StartInfo.FileName = WebServicePath;
		process.StartInfo.Arguments = "-i";
		process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		process.Start();
		process.WaitForExit();
		if (process.ExitCode != 0)
		{
			throw new InvalidOperationException(SR.T("Не удалось зарегистрировать сервис внутреннего сервера (код ошибки: {0}). Подробности смотрите в журнале: {1}.", process.ExitCode, Path.Combine(Path.GetDirectoryName(WebServicePath), "logs")));
		}
		base.Logger.Info(SR.T("Сервис внутреннего сервера установлен."));
	}

	protected void UninstallService()
	{
		if (GetService() != null)
		{
			base.Logger.Info(SR.T("Удаление сервиса внутреннего сервера..."));
			Process process = new Process();
			process.StartInfo.FileName = WebServicePath;
			process.StartInfo.Arguments = "-u";
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.Start();
			process.WaitForExit();
			if (process.ExitCode != 0)
			{
				throw new InvalidOperationException(SR.T("Не удалось разрегистрировать сервис внутреннего сервера (код ошибки: {0}). Подробности смотрите в журнале: {1}.", process.ExitCode, Path.Combine(Path.GetDirectoryName(WebServicePath), "logs")));
			}
			base.Logger.Info(SR.T("Сервис внутреннего сервера удален."));
		}
	}

	protected void CheckServiceDisplayName()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (!Directory.Exists(ComponentRoot))
		{
			return;
		}
		string text = Path.Combine(ComponentRoot, Constants.PackageReferenceFile);
		if (!File.Exists(text))
		{
			return;
		}
		PackageReference val = new PackageReferenceFile(text).GetPackageReferences().FirstOrDefault((PackageReference p) => p.get_Id().Equals(RootPackageId));
		if (val == null)
		{
			return;
		}
		string text2 = val.get_Version().get_Version().Major + "." + val.get_Version().get_Version().Minor;
		string text3 = SR.T("Веб-сервер ELMA {0}", text2 + " " + ElmaEditionHelper.GetDisplayName(base.Settings.Edition));
		WebServerSettings webServerSettings = LoadSettings();
		if (webServerSettings != null && webServerSettings.Service != null && !string.IsNullOrEmpty(webServerSettings.Service.ServiceName))
		{
			ServiceController service = GetService(webServerSettings.Service.ServiceName);
			if (service != null && service.DisplayName != text3)
			{
				webServerSettings.Service.ServiceDescription = text3;
				Configure(webServerSettings);
			}
		}
	}

	private static string GetFullNameWithCorrectCase(FileSystemInfo fileOrFolder)
	{
		if (fileOrFolder == null)
		{
			throw new NullReferenceException();
		}
		return GetCorrectCaseOfParentFolder(fileOrFolder.FullName);
	}

	private static string GetCorrectCaseOfParentFolder(string fileOrFolder)
	{
		string directoryName = Path.GetDirectoryName(fileOrFolder);
		string fileName = Path.GetFileName(fileOrFolder);
		if (directoryName == null)
		{
			return fileOrFolder.TrimEnd(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar);
		}
		if (Directory.Exists(directoryName))
		{
			string text = Directory.GetFileSystemEntries(directoryName, fileName).FirstOrDefault();
			if (text != null)
			{
				fileName = Path.GetFileName(text);
			}
		}
		return GetCorrectCaseOfParentFolder(directoryName) + Path.DirectorySeparatorChar + fileName;
	}
}
