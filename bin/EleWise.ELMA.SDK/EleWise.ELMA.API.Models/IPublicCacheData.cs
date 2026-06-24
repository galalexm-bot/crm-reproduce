namespace EleWise.ELMA.API.Models;

public interface IPublicCacheData
{
	long Id { get; }

	long ObjectId { get; }

	IPublicClientCacheToken CacheToken { get; }
}
