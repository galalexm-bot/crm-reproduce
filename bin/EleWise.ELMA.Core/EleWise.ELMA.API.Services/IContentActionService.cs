using System.Collections.Generic;
using System.Threading.Tasks;
using EleWise.ELMA.Api.Attributes;
using EleWise.ELMA.Core.Abstractions.Metadata.Models;

namespace EleWise.ELMA.Api.Services;

[InternalWebService("ContentAction", "")]
internal interface IContentActionService
{
	[GlobalFunction("d51d8c09-b2ad-4d4a-9de6-56bac87cdde0")]
	System.Threading.Tasks.Task<System.Collections.Generic.ICollection<ContentAction>> LoadAll();

	[GlobalFunction("527ad3ff-c3c8-44ec-a831-b2e427677210")]
	System.Threading.Tasks.Task<FormBindingModel> LoadFormBindingModel(ContentActionId actionId);

	[GlobalFunction("2cd41cbd-6a7c-457a-a2c8-898bd157995c")]
	System.Threading.Tasks.Task<ContentActionId> LoadActionId(ContentActionModel model);

	[GlobalFunction("5ad9ae6b-bec4-4af6-886f-977924b3083e")]
	System.Threading.Tasks.Task<EntityFormView> LoadEntityForm(FormModel formModel);
}
