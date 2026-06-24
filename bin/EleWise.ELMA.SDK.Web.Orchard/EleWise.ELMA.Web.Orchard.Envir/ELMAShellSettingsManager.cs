using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Runtime.NH;
using Orchard.Environment.Configuration;

namespace EleWise.ELMA.Web.Orchard.Enviroment.Configuration;

public class ELMAShellSettingsManager : IShellSettingsManager
{
	public const string DataTablePrefix = "Orchard";

	public const string ShellName = "ELMA";

	private readonly ShellSettings[] shellSettingsArray;

	public ELMAShellSettingsManager(IEnumerable<IMainDatabaseProvider> databaseProviders)
	{
		IMainDatabaseProvider mainDatabaseProvider = databaseProviders.FirstOrDefault((IMainDatabaseProvider p) => p.Enabled);
		if (mainDatabaseProvider == null)
		{
			throw new InvalidOperationException("Could't find main database provider");
		}
		shellSettingsArray = new ShellSettings[1]
		{
			new ShellSettings
			{
				DataConnectionString = mainDatabaseProvider.ConnectionString,
				DataProvider = mainDatabaseProvider.DataProviderName,
				Name = "ELMA",
				DataTablePrefix = "Orchard",
				State = TenantState.Initializing
			}
		};
	}

	public IEnumerable<ShellSettings> LoadSettings()
	{
		return shellSettingsArray;
	}

	public void SaveSettings(ShellSettings settings)
	{
		throw new NotImplementedException();
	}
}
