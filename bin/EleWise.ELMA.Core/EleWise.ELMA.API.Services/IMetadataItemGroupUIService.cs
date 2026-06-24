using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EleWise.ELMA.Api.Attributes;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.UI.Models;

namespace EleWise.ELMA.Api.Services;

[InternalWebService("MetadataItemGroupUI", "")]
public interface IMetadataItemGroupUIService
{
	[GlobalFunction("c52ece84-b867-4992-a05f-283d12f0477b")]
	System.Threading.Tasks.Task<System.Collections.Generic.ICollection<MetadataItemGroupUI>> LoadGroups();

	[GlobalFunction("7e5762bd-6134-41b4-af18-fe6e4ef7f9d0")]
	System.Threading.Tasks.Task<MetadataItemGroupUI> CreateGroup(MetadataItemGroupUI group);

	[GlobalFunction("1a29c7b1-95cc-4980-8916-2f1ef604fd02")]
	System.Threading.Tasks.Task Delete(Guid groupUid);

	[GlobalFunction("0e666394-5b14-42e6-9947-b151d0c6e026")]
	System.Threading.Tasks.Task<MetadataItemGroupUI> EditGroup(MetadataItemGroupUI group);
}
