using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EleWise.ELMA.Api.Attributes;
using EleWise.ELMA.Api.Models;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Views;
using EleWise.ELMA.Core.Api;

namespace EleWise.ELMA.Api.Services;

[InternalWebService("FormViewItem", "")]
internal interface IFormViewItemService
{
	[Operation(Method = WebMethod.GET, UriTemplate = "/GetMetadataForms?metadataUid={metadataUid}")]
	System.Threading.Tasks.Task<System.Collections.Generic.ICollection<FormViewItemHeaderDto>> GetMetadataForms(Guid metadataUid);

	[GlobalFunction("9fc9c1d7-441a-42ee-863d-476095da8d06")]
	System.Threading.Tasks.Task<System.Collections.Generic.ICollection<VisibleGroupInfo>> FindVisibleGroupsAndViewItems(NamedMetadata metadataDto);
}
