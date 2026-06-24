using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EleWise.ELMA.Api.Attributes;

namespace EleWise.ELMA.Api.Services.Internal;

[InternalWebService("DocumentMetadataHead", "EleWise.ELMA.Documents")]
public interface IDocumentMetadataHeadService
{
	[GlobalFunction("c24d11f3-1973-46f5-8573-8b0b794d19eb")]
	System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Guid>> GetActiveDocumentTypeUids(Guid metadataUid);
}
