using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Models;

namespace EleWise.ELMA.Model.Types;

[ExtensionPoint]
public interface ISystemDescriptor
{
	object SystemPropertyGetter(object target, PropertyInfoExpression expressionInfo, SystemPropertyInfo systemPropertyInfo);
}
