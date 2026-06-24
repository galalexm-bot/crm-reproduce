using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security;
using EleWise.ELMA.Tasks.Models;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Tasks;

[Component]
public class ExpressionReplacementTaskPermission : ExpressionPermissionBase<IReplacementTask, ITaskBasePermission>
{
	protected override PropertyExpressionDescriptor[] AccesspropertiesExpressions()
	{
		return new PropertyExpressionDescriptor[1]
		{
			new PropertyExpressionDescriptor((IReplacementTask t) => (t.Replacement != null) ? t.Replacement.SourceUser : null, allowChief: true)
		};
	}

	protected override ICollection<ITaskBasePermission> GetPermissionPersistenceCollection(IReplacementTask target)
	{
		return (ICollection<ITaskBasePermission>)(target.Permissions ?? (target.Permissions = (ISet<ITaskBasePermission>)(object)new HashedSet<ITaskBasePermission>()));
	}
}
