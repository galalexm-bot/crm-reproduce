using System.Collections.Generic;
using System.Threading.Tasks;
using EleWise.ELMA.Api.Attributes;
using EleWise.ELMA.Core.Abstractions.Metadata.Models;

namespace EleWise.ELMA.Api.Services;

[InternalWebService("MetadataItem", "")]
public interface IMetadataItemGroupService
{
	[GlobalFunction("79c13fef-2f69-4cda-8ab7-9e598db121a7")]
	System.Threading.Tasks.Task<System.Collections.Generic.ICollection<MetadataItemGroup>> LoadAll();
}
