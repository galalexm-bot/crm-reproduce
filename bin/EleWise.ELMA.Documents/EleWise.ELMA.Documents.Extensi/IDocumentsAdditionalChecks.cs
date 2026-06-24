using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Documents.Extensions;

[ExtensionPoint(ServiceScope.Application, ComponentType.All)]
public interface IDocumentsAdditionalChecks
{
	bool IsItNecessaryType(IEntity ent);

	object GetFromEntity(IEntity ent);
}
