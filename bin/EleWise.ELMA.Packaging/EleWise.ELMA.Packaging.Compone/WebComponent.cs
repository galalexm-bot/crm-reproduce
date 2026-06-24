using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.IO;
using System.Linq;
using System.Xml;
using EleWise.ELMA.Packaging.Components.SSPI;
using EleWise.ELMA.Packaging.Components.UpdatingWeb;
using EleWise.ELMA.Packaging.Components.Web.Settings;
using EleWise.ELMA.Packaging.Components.WebServer;
using EleWise.ELMA.Packaging.Components.WebServer.Settings;
using EleWise.ELMA.Packaging.FileSystems;
using EleWise.ELMA.Packaging.Logging;

namespace EleWise.ELMA.Packaging.Components.Web;

[Export(typeof(WebComponent))]
[Export(typeof(IElmaComponent))]
public class WebComponent : ElmaComponent
{
	public const string ID = "Web";

	private WebServerComponent _webServerComponent;

	private UpdatingWebComponent _updatingWebComponent;

	private SSPIComponent _SSPIComponent;

	private IISManager _iisManager;

	[Import]
	public WebServerComponent WebServerComponent
	{
		get
		{
			return _webServerComponent.GetPropertyNotNull("WebServerComponent");
		}
		set
		{
			_webServerComponent = value;
		}
	}

	[Import]
	public UpdatingWebComponent UpdatingWebComponent
	{
		get
		{
			return _updatingWebComponent.GetPropertyNotNull("UpdatingWebComponent");
		}
		set
		{
			_updatingWebComponent = value;
		}
	}

	[Import]
	public SSPIComponent SSPIComponent
	{
		get
		{
			return _SSPIComponent.GetPropertyNotNull("SSPIComponent");
		}
		set
		{
			_SSPIComponent = value;
		}
	}

	[Import]
	public IISManager IISManager
	{
		get
		{
			return _iisManager.GetPropertyNotNull("IISManager");
		}
		set
		{
			_iisManager = value;
		}
	}

	public override string Id => "Web";

	public override string Name => SR.T("Веб-часть");

	public override string RootPackageId => "EleWise.ELMA.BPM";

	protected override string RelativeComponentRoot => "Web";

	protected override bool AutoConfigure => false;

	protected virtual string SettingsFileName => Path.Combine(ComponentRoot, "ComponentSettings.config");

	public override void Configure(ElmaComponentSettings settings)
	{
		base.Configure(settings);
		WebComponentSettings webComponentSettings = LoadSettings();
		WebComponentSettings webComponentSettings2 = settings as WebComponentSettings;
		if (webComponentSettings2 == null)
		{
			if (webComponentSettings == null)
			{
				webComponentSettings2 = new WebComponentSettings();
				webComponentSettings2.InitByDefault();
			}
			else
			{
				webComponentSettings2 = webComponentSettings;
			}
		}
		ConfigureHosting(webComponentSettings, webComponentSettings2);
		ConfigureShortcuts(webComponentSettings, webComponentSettings2);
		webComponentSettings2.Save(SettingsFileName);
	}

	public override void Unconfigure()
	{
		base.Unconfigure();
		WebComponentSettings webComponentSettings = LoadSettings();
		if (webComponentSettings != null)
		{
			Unconfigure(webComponentSettings);
		}
	}

	public override bool IsStarted()
	{
		WebComponentSettings webComponentSettings = LoadSettings();
		if (webComponentSettings == null)
		{
			return false;
		}
		if (webComponentSettings.HostingType == HostingType.IIS)
		{
			if (IISManager.IsStarted(webComponentSettings.IISHosting))
			{
				return IISManager.GetPhysicalPath(webComponentSettings.IISHosting).Equals(ComponentRoot, StringComparison.CurrentCultureIgnoreCase);
			}
			return false;
		}
		if (webComponentSettings.HostingType == HostingType.InternalServer && WebServerComponent.IsInstalled())
		{
			WebServerSettings webServerSettings = WebServerComponent.LoadSettings();
			if (WebServerComponent.IsStarted() && webServerSettings != null)
			{
				return webServerSettings.Application.PhysicalPath.Equals(ComponentRoot, StringComparison.CurrentCultureIgnoreCase);
			}
			return false;
		}
		return false;
	}

	public override void Start()
	{
		base.Start();
		WebComponentSettings webComponentSettings = LoadSettings();
		if (webComponentSettings == null)
		{
			return;
		}
		if (webComponentSettings.HostingType == HostingType.IIS)
		{
			IISManager.ChangePhysicalPath(ComponentRoot, webComponentSettings.IISHosting);
			if (!IISManager.IsStarted(webComponentSettings.IISHosting))
			{
				IISManager.Start(webComponentSettings.IISHosting);
			}
		}
		else if (webComponentSettings.HostingType == HostingType.InternalServer && WebServerComponent.IsInstalled())
		{
			WebServerSettings webServerSettings = WebServerComponent.LoadSettings();
			if ((webServerSettings != null && webServerSettings.Application.PhysicalPath == null) || !webServerSettings.Application.PhysicalPath.Equals(ComponentRoot, StringComparison.CurrentCultureIgnoreCase))
			{
				WebServerComponent.ConfigureWebSitePath(ComponentRoot);
			}
			if (!WebServerComponent.IsStarted())
			{
				WebServerComponent.Start();
			}
		}
	}

	public override void Stop()
	{
		base.Stop();
		WebComponentSettings webComponentSettings = LoadSettings();
		if (webComponentSettings != null)
		{
			if (webComponentSettings.HostingType == HostingType.IIS)
			{
				IISManager.Stop(webComponentSettings.IISHosting);
			}
			else if (webComponentSettings.HostingType == HostingType.InternalServer && WebServerComponent.IsInstalled())
			{
				WebServerComponent.Stop();
			}
		}
	}

	public override void Pause()
	{
		WebComponentSettings webComponentSettings = LoadSettings();
		if (webComponentSettings == null || !UpdatingWebComponent.IsInstalled())
		{
			Stop();
		}
		else if (webComponentSettings.HostingType == HostingType.IIS)
		{
			if (IISManager.IsStarted(webComponentSettings.IISHosting))
			{
				IISManager.ChangePhysicalPath(UpdatingWebComponent.ComponentRoot, webComponentSettings.IISHosting);
			}
		}
		else if (webComponentSettings.HostingType == HostingType.InternalServer && WebServerComponent.IsStarted())
		{
			WebServerComponent.Stop();
			WebServerComponent.ConfigureWebSitePath(UpdatingWebComponent.ComponentRoot);
			WebServerComponent.Start();
		}
	}

	public override void Install(IEnumerable<string> packages)
	{
		base.Install(packages);
		if (!UpdatingWebComponent.IsInstalled())
		{
			UpdatingWebComponent.Install(null);
		}
		if (!SSPIComponent.IsInstalled())
		{
			SSPIComponent.Install(null);
		}
	}

	public override void Uninstall()
	{
		if (WebServerComponent.IsInstalled())
		{
			WebServerComponent.Uninstall();
		}
		base.Uninstall();
		DeleteSettingsFile(SettingsFileName);
		if (SSPIComponent.IsInstalled())
		{
			SSPIComponent.Uninstall();
		}
		if (UpdatingWebComponent.IsInstalled())
		{
			UpdatingWebComponent.Uninstall();
		}
	}

	public override void BeforeUpdate()
	{
		base.BeforeUpdate();
		string[] temporaryPaths = WebFolder.TemporaryPaths;
		foreach (string path in temporaryPaths)
		{
			string text = Path.Combine(ComponentRoot, path);
			if (Directory.Exists(text))
			{
				try
				{
					Directory.Delete(text, recursive: true);
				}
				catch (Exception exception)
				{
					EleWise.ELMA.Packaging.Logging.Logger.Log.Warn(SR.T("Не удалось удалить папку '{0}'", text), exception);
				}
			}
		}
	}

	public override string GetConfigurationPackagesDirectory()
	{
		string configurationFileName = GetConfigurationFileName();
		if (string.IsNullOrEmpty(configurationFileName) || !File.Exists(configurationFileName))
		{
			return null;
		}
		return Path.Combine(Path.GetDirectoryName(configurationFileName), "Packages");
	}

	public virtual WebComponentSettings LoadSettings()
	{
		if (!File.Exists(SettingsFileName))
		{
			return null;
		}
		return WebComponentSettings.Load(SettingsFileName);
	}

	protected override IElmaProjectSystem CreateProjectSystem()
	{
		return new WebProjectSystem(this);
	}

	protected override IEnumerable<IElmaFolder> CreateFolders()
	{
		return new IElmaFolder[2]
		{
			new WebFolder(this),
			new WebModuleFolder(this)
		};
	}

	protected virtual void ConfigureHosting(WebComponentSettings oldSettings, WebComponentSettings newSettings)
	{
		if (oldSettings != null)
		{
			Unconfigure(oldSettings);
		}
		if (newSettings.HostingType == HostingType.IIS)
		{
			IISManager.Install(ComponentRoot, oldSettings.IISHosting);
		}
		else
		{
			if (newSettings.HostingType != HostingType.InternalServer)
			{
				return;
			}
			if (!WebServerComponent.IsInstalled())
			{
				WebServerComponent.Install(null);
				string text = Path.Combine(WebServerComponent.ComponentRoot, "Language.xml");
				if (!File.Exists(text))
				{
					string text2 = Path.Combine(ComponentRoot, "Language.xml");
					if (File.Exists(text2))
					{
						File.Copy(text2, text, overwrite: true);
					}
				}
			}
			if (File.Exists(WebServerComponent.WebServicePath))
			{
				WebServerComponent.ConfigureWebSitePath(ComponentRoot);
				WebServerComponent.Configure(null);
			}
		}
	}

	protected virtual void ConfigureShortcuts(WebComponentSettings oldSettings, WebComponentSettings newSettings)
	{
		string desktopDirectory = GetDesktopDirectory();
		if (oldSettings != null)
		{
			string value = "http://127.0.0.1:" + GetPort(oldSettings);
			if (Directory.Exists(desktopDirectory))
			{
				string[] files = Directory.GetFiles(desktopDirectory, "*.url");
				foreach (string text in files)
				{
					if (text.Contains("ELMA"))
					{
						string internetShortcutUrl = ShortcutInfo.GetInternetShortcutUrl(text);
						if (internetShortcutUrl != null && internetShortcutUrl.Equals(value, StringComparison.CurrentCultureIgnoreCase))
						{
							FS.DeleteFile(text);
						}
					}
				}
			}
			string commonStartMenuDirectory = GetCommonStartMenuDirectory();
			if (Directory.Exists(commonStartMenuDirectory))
			{
				string[] files = Directory.GetDirectories(commonStartMenuDirectory);
				foreach (string path in files)
				{
					if (!Path.GetFileName(path).Contains("ELMA"))
					{
						continue;
					}
					string[] files2 = Directory.GetFiles(path, "*.url");
					foreach (string text2 in files2)
					{
						if (text2.Contains("ELMA"))
						{
							string internetShortcutUrl2 = ShortcutInfo.GetInternetShortcutUrl(text2);
							if (internetShortcutUrl2 != null && internetShortcutUrl2.Equals(value, StringComparison.CurrentCultureIgnoreCase))
							{
								FS.DeleteFile(text2);
							}
						}
					}
					if (Directory.GetFileSystemEntries(path).Length == 0)
					{
						FS.DeleteDirectory(path, deleteEmptyDirs: false, null);
					}
				}
			}
		}
		if (newSettings != null)
		{
			string url = "http://127.0.0.1:" + GetPort(newSettings);
			if (newSettings.StartMenuShortcut != null)
			{
				newSettings.StartMenuShortcut.CreateInternetShortcut(GetStartMenuDirectory(), url);
			}
			if (newSettings.DesktopShortcut != null)
			{
				newSettings.DesktopShortcut.CreateInternetShortcut(desktopDirectory, url);
			}
		}
	}

	protected virtual void Unconfigure(WebComponentSettings settings)
	{
		if (settings != null)
		{
			if (settings.HostingType == HostingType.IIS)
			{
				IISManager.Uninstall(settings.IISHosting);
			}
			else if (settings.HostingType == HostingType.InternalServer && WebServerComponent.IsInstalled())
			{
				WebServerComponent.Unconfigure();
			}
			ConfigureShortcuts(settings, null);
		}
	}

	protected override void ConfigureShortcuts()
	{
		base.ConfigureShortcuts();
		WebComponentSettings webComponentSettings = LoadSettings();
		ConfigureShortcuts(webComponentSettings, webComponentSettings);
	}

	protected string GetConfigurationFileName()
	{
		string text = Path.Combine(ComponentRoot, "connection.config");
		if (File.Exists(text))
		{
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.Load(text);
			XmlElement xmlElement = xmlDocument.SelectNodes("//connectionStrings/add[@name=\"ConfigurationFile\"]").OfType<XmlElement>().FirstOrDefault();
			if (xmlElement != null && xmlElement.Attributes["connectionString"] != null)
			{
				string value = xmlElement.Attributes["connectionString"].Value;
				if (!Path.IsPathRooted(value))
				{
					return Path.Combine(ComponentRoot, value);
				}
				return value;
			}
		}
		return null;
	}

	public override IPreparedOperation PrepareInstallPackages(IEnumerable<PackageInfo> packageInfos, bool updateDependencies)
	{
		IPreparedOperation preparedOperation = base.PrepareInstallPackages(packageInfos, updateDependencies);
		WebComponentSettings settings = LoadSettings();
		WebComponentSettings webComponentSettings = settings;
		if (webComponentSettings == null || webComponentSettings.HostingType != HostingType.IIS)
		{
			return preparedOperation;
		}
		SimplePreparedOperation simplePreparedOperation = new SimplePreparedOperation(delegate
		{
			IISManager.Update(settings.IISHosting);
		});
		if (preparedOperation == null)
		{
			return simplePreparedOperation;
		}
		return new CompositePreparedOperation(new IPreparedOperation[2] { preparedOperation, simplePreparedOperation });
	}

	private int GetPort(WebComponentSettings settings)
	{
		if (settings == null)
		{
			return 0;
		}
		if (settings.HostingType == HostingType.IIS)
		{
			return settings.IISHosting.Port;
		}
		if (WebServerComponent != null)
		{
			return WebServerComponent.LoadSettings()?.Application.Port ?? 0;
		}
		return 0;
	}
}
