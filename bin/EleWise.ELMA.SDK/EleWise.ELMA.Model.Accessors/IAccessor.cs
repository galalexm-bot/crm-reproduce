using System;
using System.ComponentModel;
using System.Linq.Expressions;

namespace EleWise.ELMA.Model.Accessors;

[EditorBrowsable(EditorBrowsableState.Never)]
public interface IAccessor
{
	Type PropertyType { get; }

	string PropertyName { get; }

	bool HasGetter { get; }

	bool HasSetter { get; }

	Expression GetExpression(Expression instance);

	Expression SetExpression(Expression instance, Expression value);
}
