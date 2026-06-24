using System.Web.Mvc;
using EleWise.ELMA.Cache;

namespace EleWise.ELMA.Web.Mvc;

public interface ICacheTempDataProvider : ITempDataProvider
{
	ICacheService CacheService { get; }
}
