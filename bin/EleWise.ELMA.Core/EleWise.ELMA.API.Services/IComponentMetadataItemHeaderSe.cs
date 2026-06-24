using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EleWise.ELMA.Api.Attributes;
using EleWise.ELMA.Core.Abstractions.Metadata.Models;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.UI.Models;

namespace EleWise.ELMA.Api.Services;

[InternalWebService("ComponentMetadata", "")]
public interface IComponentMetadataItemHeaderService
{
	[GlobalFunction("1ede5c75-a7ee-43b5-81f3-c237d79cc44e")]
	System.Threading.Tasks.Task<ComponentMetadataItemHeader> CreateComponent(CreateModel createModel);

	[GlobalFunction("9236e133-5cff-41fc-8492-d8cfceefa6e2")]
	System.Threading.Tasks.Task<ComponentMetadataItemHeader> CreatePage(CreateModel createModel);

	[GlobalFunction("cf60bc86-3934-439d-83df-842c765045ba")]
	System.Threading.Tasks.Task<ComponentMetadataItemHeader> CreatePortlet(CreateModel createModel);

	[GlobalFunction("cf0ef151-a84d-4867-b2a1-169393a2c8cf")]
	System.Threading.Tasks.Task<ComponentMetadataItemHeader> EditHeader(CreateModel editModel);

	[GlobalFunction("33b989ac-29be-4a2b-85b8-a253c7ac7e30")]
	System.Threading.Tasks.Task<System.Collections.Generic.ICollection<ComponentMetadataItemHeader>> LoadAll();

	[GlobalFunction("1c5e6c38-d943-40be-9298-7cbaa817546e")]
	System.Threading.Tasks.Task<ComponentMetadataItemHeader> Load(Guid headerUid);

	[GlobalFunction("ce57032b-19c9-490e-90a9-1e74b34d23e3")]
	System.Threading.Tasks.Task<ComponentMetadataPublishResult> Publish(Guid headerUid);

	[GlobalFunction("aae606c9-f98f-4851-a019-15d34a2b01ae")]
	System.Threading.Tasks.Task<ComponentMetadataPublishResult> Emulation(Guid headerUid);

	[GlobalFunction("b2819846-e722-4517-a57f-75c8a9941fb5")]
	System.Threading.Tasks.Task Delete(Guid headerUid);

	[GlobalFunction("841cb47d-0c29-40cc-96ed-7eafe406bb8e")]
	System.Threading.Tasks.Task<ComponentMetadataItemHeader> Copy(Guid headerUid);
}
