using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.Documents.Models;

[FilterFor(typeof(IDocumentMetadataHead))]
public interface IDocumentMetadataHeadFilter : IEntityFilter
{
	Guid? DocumentTypeUid { get; set; }

	Guid? MetadataType { get; set; }
}
