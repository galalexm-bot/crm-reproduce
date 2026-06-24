using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Security.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IReplacementRuleExtension
{
	bool Can(EntityMetadata metadata);

	bool CanRule(EntityMetadata metadata);
}
