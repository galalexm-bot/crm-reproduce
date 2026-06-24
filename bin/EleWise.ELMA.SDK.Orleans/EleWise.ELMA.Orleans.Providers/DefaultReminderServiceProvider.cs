using System;
using EleWise.ELMA.Orleans.Providers.Reminders;
using Microsoft.Extensions.DependencyInjection;
using Orleans;
using Orleans.Hosting;

namespace EleWise.ELMA.Orleans.Providers.Implementations;

public class DefaultReminderServiceProvider : IReminderServiceProvider
{
	public ISiloHostBuilder ConfigureReminderService(ISiloHostBuilder builder)
	{
		return SiloHostBuilderExtensions.ConfigureServices(builder, (Action<IServiceCollection>)delegate(IServiceCollection services)
		{
			ServiceCollectionServiceExtensions.AddSingleton<IReminderTable, MemoryReminderTable>(services);
		});
	}
}
