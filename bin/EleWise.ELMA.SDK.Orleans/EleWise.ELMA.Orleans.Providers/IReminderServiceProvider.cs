using Orleans.Hosting;

namespace EleWise.ELMA.Orleans.Providers;

public interface IReminderServiceProvider
{
	ISiloHostBuilder ConfigureReminderService(ISiloHostBuilder builder);
}
