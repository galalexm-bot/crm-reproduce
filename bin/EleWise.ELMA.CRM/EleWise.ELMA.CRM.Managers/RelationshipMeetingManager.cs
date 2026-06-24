using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.CRM.Managers;

public class RelationshipMeetingManager : RelationshipBaseManager<IRelationshipMeeting, long>
{
	public new static RelationshipMeetingManager Instance => Locator.GetServiceNotNull<RelationshipMeetingManager>();

	internal void ClarifyTime(IRelationshipMeeting obj)
	{
		if (obj.TimeNotSet)
		{
			obj.StartDate = obj.StartDate.Date.Add(Locator.GetServiceNotNull<IProductionCalendarService>().GetGlobalProductionSchedule().GetWorkTimeStart(obj.StartDate));
			obj.EndDate = obj.StartDate;
		}
	}

	public override void Save(IRelationshipMeeting obj)
	{
		if (obj.IsNew())
		{
			ClarifyTime(obj);
		}
		base.Save(obj);
	}
}
