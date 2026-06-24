using System.Collections.Generic;
using EleWise.ELMA.Documents.BPMN;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Documents.Components;

public abstract class ObjectDocumentResolverBase : IObjectDocumentResolver
{
	public abstract bool CheckType(IEntity entity);

	public abstract IEnumerable<IDocument> Resolve(IEntity entity);
}
