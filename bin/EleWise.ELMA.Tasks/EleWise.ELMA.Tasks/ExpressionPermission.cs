using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security;
using EleWise.ELMA.Tasks.Models;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Tasks;

[Component]
public class ExpressionPermission : ExpressionPermissionBase<ITaskBase, ITaskBasePermission>
{
	protected override PropertyExpressionDescriptor[] AccesspropertiesExpressions()
	{
		return new PropertyExpressionDescriptor[5]
		{
			new PropertyExpressionDescriptor((ITaskBase t) => t.CreationAuthor, allowChief: true),
			new PropertyExpressionDescriptor((ITaskBase t) => t.Executor, allowChief: true),
			new PropertyExpressionDescriptor((ITaskBase t) => t.ExecutorReplaced, allowChief: true),
			new PropertyExpressionDescriptor((ITaskBase t) => t.Harmonizator, allowChief: true),
			new PropertyExpressionDescriptor((ITaskBase t) => t.InformTo, allowChief: true)
		};
	}

	protected override ICollection<ITaskBasePermission> GetPermissionPersistenceCollection(ITaskBase target)
	{
		return (ICollection<ITaskBasePermission>)(target.Permissions ?? (target.Permissions = (ISet<ITaskBasePermission>)(object)new HashedSet<ITaskBasePermission>()));
	}
}
