using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Ranges;

namespace EleWise.ELMA.UI.Models;

[FilterFor(typeof(IFormMetadataItemHeader))]
public interface IFormMetadataItemHeaderFilter : IEntityFilter
{
	string Name { get; set; }

	string DisplayName { get; set; }

	DateTimeRange CreationDate { get; set; }

	Guid? MetadataType { get; set; }

	IFormMetadataItemGroup Group { get; set; }
}
