using Orleans.Hosting;

namespace EleWise.ELMA.Orleans.Providers;

public interface IClusteringProvider
{
	ISiloHostBuilder ConfigureClustering(ISiloHostBuilder builder);
}
