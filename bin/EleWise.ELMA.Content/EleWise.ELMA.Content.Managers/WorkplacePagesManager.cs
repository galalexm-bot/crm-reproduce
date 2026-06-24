using EleWise.ELMA.Cache;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using NHibernate.Criterion;

namespace EleWise.ELMA.Content.Managers;

public class WorkplacePagesManager : EntityManager<IWorkplacePages, long>
{
	private static string WorkplacePagesByWorkPlaceFormat = "WorkplacePagesByWorkPlace_{0}";

	private static string WorkplacePagesByWorkPlaceTimestampFormat = "WorkplacePagesByWorkPlace_timestamp_{0}";

	public new static WorkplacePagesManager Instance => Locator.GetServiceNotNull<WorkplacePagesManager>();

	public IUnionComplexCacheService ComplexCacheService { get; set; }

	public IWorkplacePages GetWorkplacePagesByUser(long userId)
	{
		long? workplacePagesIdByUser = GetWorkplacePagesIdByUser(userId);
		if (!workplacePagesIdByUser.HasValue)
		{
			return null;
		}
		return LoadOrNull(workplacePagesIdByUser.Value);
	}

	internal long? GetWorkplacePagesIdByUser(long userId)
	{
		long? workPlaceId = WorkPlaceManager.Instance.GetWorkPlaceIdByUser(userId);
		return ComplexCacheService.GetOrAdd(string.Format(WorkplacePagesByWorkPlaceFormat, workPlaceId), string.Format(WorkplacePagesByWorkPlaceTimestampFormat, workPlaceId), () => CreateCriteria(null, InterfaceActivator.TypeOf<IWorkPlace>()).Add((ICriterion)((!workPlaceId.HasValue) ? ((object)Restrictions.Eq("Uid", (object)WorkPlaceManager.DefaultWorkPlaceUid)) : ((object)Restrictions.IdEq((object)workPlaceId)))).CreateAlias("WorkplacePages", "wpp").SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.Property("wpp.Id") })
			.UniqueResult<long?>());
	}

	internal void RefreshWorkplacePagesByWorkPlaceCache(IWorkPlace workPlace)
	{
		if (workPlace != null)
		{
			long? num = ((workPlace.Uid == WorkPlaceManager.DefaultWorkPlaceUid) ? null : new long?(workPlace.Id));
			ComplexCacheService.RefreshTimestamp(string.Format(WorkplacePagesByWorkPlaceTimestampFormat, num));
		}
	}
}
