using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Types;
using EleWise.ELMA.Model.Types;

namespace EleWise.ELMA.Documents.Metadata;

[Component]
public class DocumentEntityType : IEntityType
{
	public List<Guid> Types => new List<Guid> { DocumentTypeDescriptor.UID };
}
