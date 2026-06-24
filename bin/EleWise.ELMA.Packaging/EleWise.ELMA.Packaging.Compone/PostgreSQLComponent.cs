using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using EleWise.ELMA.Packaging.Components.PostgreSQL.Settings;
using EleWise.ELMA.Packaging.Components.Web;
using EleWise.ELMA.Packaging.FileSystems;
using EleWise.ELMA.Packaging.Logging;

namespace EleWise.ELMA.Packaging.Components.PostgreSQL;

[Export(typeof(PostgreSQLComponent))]
[Export(typeof(IElmaComponent))]
public class PostgreSQLComponent : ElmaComponent
{
	private class ProcessStarter
	{
		private string fileName;

		private string commandName;

		public string Arguments { get; set; }

		public ILogger Logger { get; set; }

		public ProcessStarter(string fileName, string commandName)
		{
			this.fileName = fileName;
			this.commandName = commandName;
		}

		public int Start()
		{
			Process process = new Process();
			process.StartInfo.FileName = fileName;
			process.StartInfo.Arguments = Arguments;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.StandardOutputEncoding = Encoding.GetEncoding(CultureInfo.CurrentCulture.TextInfo.ANSICodePage);
			process.OutputDataReceived += OutputDataReceived;
			process.Start();
			process.BeginOutputReadLine();
			process.WaitForExit();
			return process.ExitCode;
		}

		private void OutputDataReceived(object sender, DataReceivedEventArgs e)
		{
			if (Logger != null)
			{
				Logger.Debug(commandName + ": " + e.Data);
			}
		}
	}

	public const string ID = "PostgreSQL";

	private WebComponent _webComponent;

	[Import]
	public WebComponent WebComponent
	{
		get
		{
			return _webComponent.GetPropertyNotNull("WebComponent");
		}
		set
		{
			_webComponent = value;
		}
	}

	public override string Id => "PostgreSQL";

	public override string Name => "PostgreSQL";

	public override string RootPackageId => "PostgreSQL";

	protected override string RelativeComponentRoot => "PostgreSQL";

	protected virtual TimeSpan ServicePendingTimeout => TimeSpan.FromMinutes(1.0);

	protected virtual string BinDirectory => Path.Combine(ComponentRoot, "bin");

	protected virtual string DataDirectory => Path.Combine(ComponentRoot, "data");

	protected virtual string PgCtrlFileName => Path.Combine(BinDirectory, "pg_ctl.exe");

	protected virtual string InitDbFileName => Path.Combine(BinDirectory, "initdb.exe");

	protected virtual string SettingsFileName => Path.Combine(ComponentRoot, "ComponentSettings.config");

	public override void Configure(ElmaComponentSettings settings)
	{
		PostgreSQLSettings postgreSQLSettings = LoadSettings();
		PostgreSQLSettings postgreSQLSettings2 = settings as PostgreSQLSettings;
		if (postgreSQLSettings2 == null)
		{
			postgreSQLSettings2 = ((postgreSQLSettings != null) ? postgreSQLSettings : new PostgreSQLSettings());
		}
		if (postgreSQLSettings != null)
		{
			Unconfigure(postgreSQLSettings);
		}
		base.Configure(settings);
		postgreSQLSettings2.Save(SettingsFileName);
		if (!Directory.Exists(DataDirectory) || Directory.GetFiles(DataDirectory).Length == 0 || Directory.GetDirectories(DataDirectory).Length == 0)
		{
			ConfigureDataFolder(postgreSQLSettings2);
		}
		InstallService(postgreSQLSettings2);
	}

	public override void Unconfigure()
	{
		base.Unconfigure();
		PostgreSQLSettings postgreSQLSettings = LoadSettings();
		if (postgreSQLSettings != null)
		{
			Unconfigure(postgreSQLSettings);
		}
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
		return false;
	}

	public override void Start()
	{
		base.Start();
		ServiceController service = GetService();
		if (service != null)
		{
			if (WaitServicePending(service) == ServiceControllerStatus.Running)
			{
				base.Logger.Warn(SR.T("Сервер {0} уже запущен.", "PostgreSQL"));
				return;
			}
			try
			{
				base.Logger.Info(SR.T("Запуск сервиса '{0}'...", service.ServiceName));
				service.Start();
			}
			catch (Exception innerException)
			{
				throw new InvalidOperationException(SR.T("Не удалось запустить сервис '{0}'", service.ServiceName), innerException);
			}
			try
			{
				service.WaitForStatus(ServiceControllerStatus.Running);
			}
			catch (Exception innerException2)
			{
				throw new InvalidOperationException(SR.T("Не удалось дождаться завершения запуска сервиса '{0}'", service.ServiceName), innerException2);
			}
			Thread.Sleep(10000);
			base.Logger.Info(SR.T("Сервис '{0}' запущен.", service.ServiceName));
			return;
		}
		throw new InvalidOperationException(SR.T("Сервис '{0}' не найден", "PostgreSQL"));
	}

	public override void Stop()
	{
		base.Stop();
		ServiceController service = GetService();
		if (service != null)
		{
			if (WaitServicePending(service) == ServiceControllerStatus.Stopped)
			{
				base.Logger.Warn(SR.T("Сервер {0} уже остановлен.", "PostgreSQL"));
				return;
			}
			if (WebComponent != null && WebComponent.IsInstalled() && WebComponent.IsStarted())
			{
				WebComponent.Stop();
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
				return;
			}
			catch (Exception innerException2)
			{
				throw new InvalidOperationException(SR.T("Не удалось дождаться завершения остановки сервиса '{0}'", service.ServiceName), innerException2);
			}
		}
		throw new InvalidOperationException(SR.T("Сервис '{0}' не найден", "PostgreSQL"));
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

	public virtual PostgreSQLSettings LoadSettings()
	{
		if (!File.Exists(SettingsFileName))
		{
			return null;
		}
		return PostgreSQLSettings.Load(SettingsFileName);
	}

	protected override IElmaProjectSystem CreateProjectSystem()
	{
		return new PostgreSQLProjectSystem(this);
	}

	protected override IEnumerable<IElmaFolder> CreateFolders()
	{
		return new IElmaFolder[1]
		{
			new PostgreSQLFolder(this)
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

	protected virtual void Unconfigure(PostgreSQLSettings settings)
	{
		if (settings != null)
		{
			UninstallService(settings);
		}
	}

	protected ServiceController GetService()
	{
		PostgreSQLSettings postgreSQLSettings = LoadSettings();
		if (postgreSQLSettings == null)
		{
			return null;
		}
		return GetService(postgreSQLSettings.ServiceName);
	}

	protected void InstallService(PostgreSQLSettings settings)
	{
		base.Logger.Info(SR.T("Установка сервера {0}...", "PostgreSQL"));
		try
		{
			base.Logger.Debug("Trying to grant access for PostgreSQL root directory");
			DirectoryInfo directoryInfo = new DirectoryInfo(ComponentRoot);
			if (directoryInfo.Exists)
			{
				DirectorySecurity accessControl = directoryInfo.GetAccessControl();
				FileSystemAccessRule rule = new FileSystemAccessRule(settings.ServiceUser, FileSystemRights.Modify, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow);
				accessControl.AddAccessRule(rule);
				directoryInfo.SetAccessControl(accessControl);
				base.Logger.Debug("Sucessfull grant access for PostgreSQL root directory");
			}
		}
		catch (Exception exception)
		{
			base.Logger.Debug("Cannot grant access for PostgreSQL root directory", exception);
		}
		ProcessStarter processStarter = new ProcessStarter(PgCtrlFileName, "PgCtrl-Register");
		processStarter.Logger = base.Logger;
		processStarter.Arguments = $"register -N {settings.ServiceName} -U \"{settings.ServiceUser}\" -D \"{DataDirectory}\" -S auto -o \"-p {settings.Port}\"";
		int num = processStarter.Start();
		if (num != 0)
		{
			throw new InvalidOperationException(SR.T("Не удалось зарегистрировать сервис {0} (код ошибки: {1}).", "PostgreSQL", num));
		}
		base.Logger.Info(SR.T("Сервер {0} установлен.", "PostgreSQL"));
	}

	protected void UninstallService(PostgreSQLSettings settings)
	{
		if (GetService() != null)
		{
			base.Logger.Info(SR.T("Удаление сервиса сервера {0}...", "PostgreSQL"));
			int num = new ProcessStarter(PgCtrlFileName, "PgCtrl-Unregister")
			{
				Logger = base.Logger,
				Arguments = $"unregister -N {settings.ServiceName}"
			}.Start();
			if (num != 0)
			{
				throw new InvalidOperationException(SR.T("Не удалось разрегистрировать сервис {0} (код ошибки: {1}).", "PostgreSQL", num));
			}
			base.Logger.Info(SR.T("Сервис сервера {0} удален.", "PostgreSQL"));
		}
	}

	protected void ConfigureDataFolder(PostgreSQLSettings settings)
	{
		base.Logger.Info(SR.T("Конфигурирование сервера {0}...", "PostgreSQL"));
		string text = ((!string.IsNullOrEmpty(settings.SuperuserPassword)) ? (Path.GetTempPath() + Guid.NewGuid().ToString("n")) : null);
		try
		{
			if (text != null)
			{
				File.WriteAllText(text, settings.SuperuserPassword);
			}
			ProcessStarter processStarter = new ProcessStarter(InitDbFileName, "InitDb");
			processStarter.Logger = base.Logger;
			if (text != null)
			{
				processStarter.Arguments = $"-D \"{DataDirectory}\" -E UTF8 -A md5 -U {settings.SuperuserName} \"--pwfile={text}\"";
			}
			else
			{
				processStarter.Arguments = $"-D \"{DataDirectory}\" -E UTF8 -U {settings.SuperuserName}";
			}
			int num = processStarter.Start();
			if (num != 0)
			{
				throw new InvalidOperationException(SR.T("Не удалось сконфигурировать сервер (код ошибки: {0}).", num));
			}
		}
		finally
		{
			if (text != null && File.Exists(text))
			{
				try
				{
					FS.DeleteFile(text);
				}
				catch
				{
				}
			}
		}
		base.Logger.Info(SR.T("Сервер {0} сконфигурирован.", "PostgreSQL"));
	}
}
