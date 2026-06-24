using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Orchard.FileSystems.AppData;
using Orchard.Logging;

namespace Orchard.Environment.Configuration;

public class ShellSettingsManager : Component, IShellSettingsManager
{
	private const string SettingsFileName = "Settings.txt";

	private readonly IAppDataFolder _appDataFolder;

	private readonly IShellSettingsManagerEventHandler _events;

	public ShellSettingsManager(IAppDataFolder appDataFolder, IShellSettingsManagerEventHandler events)
	{
		_appDataFolder = appDataFolder;
		_events = events;
	}

	IEnumerable<ShellSettings> IShellSettingsManager.LoadSettings()
	{
		base.Logger.Information("Reading ShellSettings...");
		ShellSettings[] array = LoadSettingsInternal().ToArray();
		IEnumerable<string> enumerable = array.Select((ShellSettings settings) => settings.Name);
		base.Logger.Information("Returning {0} ShellSettings objects for tenants {1}.", enumerable.Count(), string.Join(", ", enumerable));
		return array;
	}

	void IShellSettingsManager.SaveSettings(ShellSettings settings)
	{
		if (settings == null)
		{
			throw new ArgumentNullException("settings");
		}
		if (string.IsNullOrEmpty(settings.Name))
		{
			throw new ArgumentException("The Name property of the supplied ShellSettings object is null or empty; the settings cannot be saved.", "settings");
		}
		base.Logger.Information("Saving ShellSettings for tenant '{0}'...", settings.Name);
		string path = Path.Combine(Path.Combine("Sites", settings.Name), "Settings.txt");
		_appDataFolder.CreateFile(path, ShellSettingsSerializer.ComposeSettings(settings));
		base.Logger.Information("ShellSettings saved successfully; flagging tenant '{0}' for restart.", settings.Name);
		_events.Saved(settings);
	}

	private IEnumerable<ShellSettings> LoadSettingsInternal()
	{
		IEnumerable<string> enumerable = from path in _appDataFolder.ListDirectories("Sites").SelectMany((string path) => _appDataFolder.ListFiles(path))
			where string.Equals(Path.GetFileName(path), "Settings.txt", StringComparison.OrdinalIgnoreCase)
			select path;
		foreach (string item in enumerable)
		{
			yield return ShellSettingsSerializer.ParseSettings(_appDataFolder.ReadFile(item));
		}
	}
}
