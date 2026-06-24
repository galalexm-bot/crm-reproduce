using System;
using EleWise.ELMA.Configuration;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Orleans.Configuration;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Services;
using Microsoft.Extensions.DependencyInjection;
using Orleans;
using Orleans.Configuration;
using Orleans.Hosting;

namespace EleWise.ELMA.Orleans.Providers.Implementations;

public class DefaultClusteringProvider : IClusteringProvider, IConfigurableProvider
{
	private ClusteringSettingsSection settings;

	public void Configure(ProviderSettingsSection settings, RuntimeConfiguration configuration)
	{
		this.settings = (ClusteringSettingsSection)settings;
	}

	public ISiloHostBuilder ConfigureClustering(ISiloHostBuilder builder)
	{
		return SiloHostBuilderExtensions.ConfigureServices(builder, (Action<IServiceCollection>)delegate(IServiceCollection services)
		{
			ServiceCollectionServiceExtensions.AddSingleton<IMembershipTable, DBMembershipTable>(ServiceCollectionServiceExtensions.AddSingleton<ITransformationProviderAsync>(OptionsServiceCollectionExtensions.Configure<ClusterMembershipOptions>(services, (Action<ClusterMembershipOptions>)settings.Configure), (ITransformationProviderAsync)Locator.GetServiceNotNull<IRuntimeApplication>().TransformationProvider));
		});
	}
}
