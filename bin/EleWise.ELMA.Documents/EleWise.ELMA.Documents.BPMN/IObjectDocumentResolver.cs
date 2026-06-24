using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Documents.BPMN;

[ExtensionPoint(ServiceScope.Application, ComponentType.All)]
public interface IObjectDocumentResolver
{
	bool CheckType(IEntity entity);

	IEnumerable<IDocument> Resolve(IEntity entity);
}
