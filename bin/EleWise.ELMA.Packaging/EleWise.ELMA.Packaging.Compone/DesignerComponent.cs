using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Xml;
using EleWise.ELMA.Packaging.Components.Designer.Settings;
using EleWise.ELMA.Packaging.FileSystems;
using EleWise.ELMA.Packaging.Logging;
using EleWise.ELMA.Packaging.Shortcuts;

namespace EleWise.ELMA.Packaging.Components.Designer;

[Export(typeof(DesignerComponent))]
[Export(typeof(IElmaComponent))]
public class DesignerComponent : ElmaComponent
{
	public const string ID = "Designer";

	public override string Id => "Designer";

	public override string Name => SR.T("Дизайнер");

	public override string RootPackageId => "EleWise.ELMA.BPM";

	protected virtual string DesignerExeFileName => Path.Combine(ComponentRoot, "EleWise.ELMA.BPM.Designer.exe");

	protected override string RelativeComponentRoot => "Designer";

	protected virtual string SettingsFileName => Path.Combine(ComponentRoot, "ComponentSettings.config");

	public override void Start()
	{
		Process.Start(DesignerExeFileName);
	}

	public override void Stop()
	{
		try
		{
			foreach (Process runningDesignerProcess in GetRunningDesignerProcesses(onlyCurrentUser: false))
			{
				runningDesignerProcess.Kill();
			}
		}
		catch (Exception exception)
		{
			base.Logger.Error("Не удалось закрыть дизайнер", exception);
		}
	}

	public override void Pause()
	{
		Stop();
	}

	public override bool IsStarted()
	{
		return GetRunningDesignerProcesses(onlyCurrentUser: false).Any();
	}

	public override void Configure(ElmaComponentSettings settings)
	{
		base.Configure(settings);
		DesignerComponentSettings designerComponentSettings = LoadSettings();
		DesignerComponentSettings designerComponentSettings2 = settings as DesignerComponentSettings;
		if (designerComponentSettings2 == null)
		{
			if (designerComponentSettings == null)
			{
				designerComponentSettings2 = new DesignerComponentSettings();
				designerComponentSettings2.InitByDefault();
			}
			else
			{
				designerComponentSettings2 = designerComponentSettings;
			}
		}
		ConfigureShortcuts(designerComponentSettings2);
		designerComponentSettings2.Save(SettingsFileName);
	}

	public override void Unconfigure()
	{
		base.Unconfigure();
		LoadSettings();
		ConfigureShortcuts(null);
	}

	public override void Install(IEnumerable<string> packages)
	{
		base.Install(packages);
		SetupConfigFile();
	}

	public override void Uninstall()
	{
		base.Uninstall();
		DeleteSettingsFile(SettingsFileName);
	}

	public override void BeforePrepareUpdate()
	{
		base.BeforePrepareUpdate();
		if (IsInstalled() && IsStarted())
		{
			throw new InvalidOperationException(SR.T("Для выполнения операции требуется закрыть дизайнер ELMA у всех пользователей на данном компьютере."));
		}
	}

	public override void AfterUpdate(bool success)
	{
		base.AfterUpdate(success);
		if (success)
		{
			SetupConfigFile();
		}
	}

	protected override IElmaProjectSystem CreateProjectSystem()
	{
		return new DesignerProjectSystem(this);
	}

	protected override IEnumerable<IElmaFolder> CreateFolders()
	{
		return new IElmaFolder[2]
		{
			new DesignerFolder(this),
			new DesignerHelpChmFolder(this)
		};
	}

	protected virtual IEnumerable<Process> GetRunningDesignerProcesses(bool onlyCurrentUser)
	{
		try
		{
			int currentSessionID = Process.GetCurrentProcess().SessionId;
			return (from p in ProcessHelper.FindProcesses(DesignerExeFileName)
				where !onlyCurrentUser || p.SessionId == currentSessionID
				select p).ToArray();
		}
		catch (Exception exception)
		{
			base.Logger.Warn(SR.T("Не удалось получить список процессов запущеных дизайнеров ELMA."), exception);
			return new Process[0];
		}
	}

	protected virtual DesignerComponentSettings LoadSettings()
	{
		if (!File.Exists(SettingsFileName))
		{
			return null;
		}
		return DesignerComponentSettings.Load(SettingsFileName);
	}

	protected virtual void ConfigureShortcuts(DesignerComponentSettings settings)
	{
		string desktopDirectory = GetDesktopDirectory();
		string designerExeFileName = DesignerExeFileName;
		if (Directory.Exists(desktopDirectory))
		{
			string[] files = Directory.GetFiles(desktopDirectory, "*.lnk");
			foreach (string text in files)
			{
				if (text.Contains("ELMA"))
				{
					string shortcutTarget = Shortcut.GetShortcutTarget(text);
					if (shortcutTarget != null && shortcutTarget.Equals(designerExeFileName, StringComparison.CurrentCultureIgnoreCase))
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
				string[] files2 = Directory.GetFiles(path, "*.lnk");
				foreach (string text2 in files2)
				{
					if (text2.Contains("ELMA"))
					{
						string shortcutTarget2 = Shortcut.GetShortcutTarget(text2);
						if (shortcutTarget2 != null && shortcutTarget2.Equals(designerExeFileName, StringComparison.CurrentCultureIgnoreCase))
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
		if (settings != null)
		{
			Path.Combine(ComponentRoot, "");
			if (settings.StartMenuShortcut != null)
			{
				settings.StartMenuShortcut.CreateShortcut(GetStartMenuDirectory(), designerExeFileName, SR.T("Запустить дизайнер ELMA"));
			}
			if (settings.DesktopShortcut != null)
			{
				settings.StartMenuShortcut.CreateShortcut(desktopDirectory, designerExeFileName, SR.T("Запустить дизайнер ELMA"));
			}
		}
	}

	protected virtual void SetupConfigFile()
	{
		string text = DesignerExeFileName + ".config";
		if (File.Exists(text))
		{
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.Load(text);
			xmlDocument.SelectNodes("/configuration/appSettings/add[@key=\"WebSitePath\"]").OfType<XmlElement>().FirstOrDefault()?.SetAttribute("value", "{$STARTDIR}\\Web");
			xmlDocument.Save(text);
		}
	}

	protected override void ConfigureShortcuts()
	{
		base.ConfigureShortcuts();
		DesignerComponentSettings settings = LoadSettings();
		ConfigureShortcuts(settings);
	}
}
