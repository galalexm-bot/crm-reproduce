using EleWise.ELMA.CRM.Models;

namespace EleWise.ELMA.CRM.Managers;

public class RelationshipCallManager : RelationshipBaseManager<IRelationshipCall, long>
{
	public override void Save(IRelationshipCall obj)
	{
		if (obj.IsNew())
		{
			obj.EndDate = obj.StartDate.AddMinutes(10.0);
		}
		base.Save(obj);
	}
}
