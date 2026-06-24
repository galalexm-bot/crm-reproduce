using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.ExtensionPoints;

[DeveloperApi(DeveloperApiType.ExtensionPoint)]
[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface ICustomSortable
{
	bool CheckMetadata(ClassMetadata classMetadata, string sortExpression);

	bool IsSortable(ClassMetadata classMetadata, PropertyMetadata metadata);

	string BuildSortExpression(ClassMetadata classMetadata, string sortExpression);
}
