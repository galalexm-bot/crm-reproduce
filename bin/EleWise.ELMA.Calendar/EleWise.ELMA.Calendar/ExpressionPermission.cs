using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Calendar;

[Component]
public class ExpressionPermission : ExpressionPermissionBase<ICalendarEvent, ICalendarEventPermission>
{
	protected override PropertyExpressionDescriptor[] AccesspropertiesExpressions()
	{
		return new PropertyExpressionDescriptor[2]
		{
			new PropertyExpressionDescriptor((ICalendarEvent t) => t.CreationAuthor),
			new PropertyExpressionDescriptor((ICalendarEvent t) => ((IEnumerable<ICalendarEventUser>)t.EventUsers).Select((ICalendarEventUser e) => e.User))
		};
	}

	protected override ICollection<ICalendarEventPermission> GetPermissionPersistenceCollection(ICalendarEvent target)
	{
		return (ICollection<ICalendarEventPermission>)(target.Permissions ?? (target.Permissions = (ISet<ICalendarEventPermission>)(object)new HashedSet<ICalendarEventPermission>()));
	}
}
