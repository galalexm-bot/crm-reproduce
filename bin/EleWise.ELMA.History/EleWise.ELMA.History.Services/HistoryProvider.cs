using System;
using System.Collections.Generic;
using System.Linq;
using Autofac;
using Autofac.Builder;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Configuration;
using EleWise.ELMA.History.ExtensionPoints;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.Providers;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.History.Services;

internal sealed class HistoryProvider : AbstractProvider, IHistoryProvider
{
	private readonly IEnumerable<string> ignoredProviderNames = new string[2] { "FirebirdProvider", "OracleProvider" };

	private readonly int providerLength = "Provider".Length;

	private IHistoryRepository historyRepository;

	public IHistoryRepository HistoryRepository => historyRepository ?? (historyRepository = Locator.GetService<IHistoryRepository>());

	public override Guid Uid => Guid.Parse("B04B3C5C-72AF-4FE0-AB66-14EAD1ED50FD");

	public override string Name => "HistoryProvider";

	public override void Configure(ProviderSettingsSection settings, RuntimeConfiguration configuration)
	{
		IMainBaseSettingsSection mainDB = configuration.MainDB;
		string providerName = mainDB.ProviderType.Name;
		if (ignoredProviderNames.Any((string ignored) => ignored.Equals(providerName, StringComparison.InvariantCultureIgnoreCase)))
		{
			Logger.Log.Error(SR.T("Провайдер хранения истории не поддерживает работу с СУБД {0}", providerName.Remove(providerName.Length - providerLength)));
		}
		else
		{
			base.Configure(settings, configuration);
		}
	}

	public override void Init()
	{
		if (SettingsSection is HistoryProviderSettingsSection historyProviderSettingsSection)
		{
			RegistrationExtensions.PropertiesAutowired<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>(RegistrationExtensions.RegisterType(ComponentManager.Builder, historyProviderSettingsSection.RepositoryType).As<IHistoryRepository>().SingleInstance(), (PropertyWiringOptions)0);
		}
	}

	public override void InitComplete()
	{
		if (HistoryRepository != null)
		{
			HistoryRepository.InitRepository(SettingsSection as HistoryProviderSettingsSection);
		}
	}

	public override ProviderSettingsSection CreateSettings()
	{
		return new HistoryProviderSettingsSection();
	}
}
