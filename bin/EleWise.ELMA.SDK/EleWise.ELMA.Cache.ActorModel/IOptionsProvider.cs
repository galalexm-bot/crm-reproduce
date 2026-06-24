using EleWise.ELMA.Cache.ActorModel.Configuration;

namespace EleWise.ELMA.Cache.ActorModel;

public interface IOptionsProvider
{
	CacheOptions Options { get; }
}
