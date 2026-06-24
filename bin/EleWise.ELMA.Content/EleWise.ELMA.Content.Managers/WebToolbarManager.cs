using EleWise.ELMA.Cache;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using NHibernate.Criterion;

namespace EleWise.ELMA.Content.Managers;

public class WebToolbarManager : EntityManager<IWebToolbar, long>
{
	private static string WebToolbarByWorkPlaceFormat = "WebToolbarByWorkPlace_{0}";

	private static string WebToolbarByWorkPlaceTimestampFormat = "WebToolbarByWorkPlace_timestamp_{0}";

	public new static WebToolbarManager Instance => Locator.GetServiceNotNull<WebToolbarManager>();

	public IUnionComplexCacheService ComplexCacheService { get; set; }

	public IWebToolbar GetToolbarByUser(long userId)
	{
		long? webToolbarIdByUser = GetWebToolbarIdByUser(userId);
		if (!webToolbarIdByUser.HasValue)
		{
			return null;
		}
		return LoadOrNull(webToolbarIdByUser.Value);
	}

	internal long? GetWebToolbarIdByUser(long userId)
	{
		long? workPlaceId = WorkPlaceManager.Instance.GetWorkPlaceIdByUser(userId);
		return ComplexCacheService.GetOrAdd(string.Format(WebToolbarByWorkPlaceFormat, workPlaceId), string.Format(WebToolbarByWorkPlaceTimestampFormat, workPlaceId), () => CreateCriteria(null, InterfaceActivator.TypeOf<IWorkPlace>()).Add((ICriterion)((!workPlaceId.HasValue) ? ((object)Restrictions.Eq("Uid", (object)WorkPlaceManager.DefaultWorkPlaceUid)) : ((object)Restrictions.IdEq((object)workPlaceId)))).CreateAlias("Toolbar", "tp").SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.Property("tp.Id") })
			.UniqueResult<long?>());
	}

	internal void RefreshWebToolbarByWorkPlaceCache(IWorkPlace workPlace)
	{
		if (workPlace != null)
		{
			long? num = ((workPlace.Uid == WorkPlaceManager.DefaultWorkPlaceUid) ? null : new long?(workPlace.Id));
			ComplexCacheService.RefreshTimestamp(string.Format(WebToolbarByWorkPlaceTimestampFormat, num));
		}
	}
}
