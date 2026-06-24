using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EleWise.ELMA.Api.Attributes;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.UI.Models;

namespace EleWise.ELMA.Api.Services.Internal;

[InternalWebService("FormMetadata", "")]
internal interface IFormMetadataService
{
	[GlobalFunction("6a45abdf-1928-41cf-9fca-b83cf9e41308")]
	System.Threading.Tasks.Task<System.Collections.Generic.ICollection<FormMetadataItemHeader>> GetPageMetadataHeaders();

	[GlobalFunction("b3dc8ad5-b10a-4f1d-bf7a-5407bfe36233")]
	System.Threading.Tasks.Task<FormMetadataItem> LoadDraftMetadata(Guid uid);
}
