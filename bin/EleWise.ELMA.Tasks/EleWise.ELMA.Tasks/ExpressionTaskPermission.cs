using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security;
using EleWise.ELMA.Tasks.Models;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Tasks;

[Component]
public class ExpressionTaskPermission : ExpressionPermissionBase<ITask, ITaskBasePermission>
{
	protected override PropertyExpressionDescriptor[] AccesspropertiesExpressions()
	{
		return new PropertyExpressionDescriptor[2]
		{
			new PropertyExpressionDescriptor((ITask t) => t.ControlUser, allowChief: true),
			new PropertyExpressionDescriptor((ITask t) => t.CurrentControllers, allowChief: true)
		};
	}

	protected override ICollection<ITaskBasePermission> GetPermissionPersistenceCollection(ITask target)
	{
		return (ICollection<ITaskBasePermission>)(target.Permissions ?? (target.Permissions = (ISet<ITaskBasePermission>)(object)new HashedSet<ITaskBasePermission>()));
	}
}
