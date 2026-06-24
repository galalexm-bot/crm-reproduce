using System.Collections.Generic;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Documents.Extensions;

public class ConflictConvertReferencesObject
{
	public IDocument RefToDocument;

	public EntityMetadata RootEntityMetadata;

	public EntityMetadata EntityMetadata;

	public PropertyMetadata PropertyMetadata;

	public List<IEntity> RefObjects = new List<IEntity>();
}
