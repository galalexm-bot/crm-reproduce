using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.CRM.Models;

namespace EleWise.ELMA.CRM.Notifications;

public abstract class UserRecipientHandlerBase
{
	public IEnumerable<object> GetRecipients(object value)
	{
		if (value == null)
		{
			return new object[0];
		}
		if (!(value is IRelationship relationship) || !((IEnumerable<IRelationshipUser>)relationship.RelationshipUsers).Any())
		{
			return new object[0];
		}
		return (from eu in ((IEnumerable<IRelationshipUser>)relationship.RelationshipUsers).Where(CheckCondition)
			select eu.User).ToList();
	}

	public abstract bool CheckCondition(IRelationshipUser user);
}
