using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.Documents.Models;

[FilterFor(typeof(IDocumentMetadataGroup))]
public interface IDocumentMetadataGroupFilter : IEntityFilter
{
	Guid? MetadataType { get; set; }

	Guid? GroupType { get; set; }
}
