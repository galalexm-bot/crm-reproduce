using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Helpers;

namespace EleWise.ELMA.ExtensionPoints;

[ExtensionPoint(ServiceScope.Application, ComponentType.All)]
public interface IEntityCopyRuleProvider
{
	bool CheckType(object entity);

	void InitRules<T>(RestrictionsBuilder<T> builder) where T : class;
}
