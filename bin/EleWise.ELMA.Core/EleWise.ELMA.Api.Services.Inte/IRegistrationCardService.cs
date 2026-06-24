using System.Threading.Tasks;
using EleWise.ELMA.Api.Attributes;
using EleWise.ELMA.Core.Abstractions.Metadata.Constants.Documents;
using EleWise.ELMA.Core.Abstractions.Metadata.Models;

namespace EleWise.ELMA.Api.Services.Internal;

[InternalWebService("RegistrationCard", "EleWise.ELMA.Documents.Docflow")]
internal interface IRegistrationCardService
{
	[GlobalFunction("daac0013-2bf8-4663-9aa0-5b45aaa3e1a0")]
	System.Threading.Tasks.Task<EntityFormView> GetEditRKKForm(EditRKKForm editRkkForm);

	[GlobalFunction("2d668ef0-8ba2-4bcd-b414-e1f1deea9e68")]
	System.Threading.Tasks.Task<EntityFormView> GetCreateRKKForm(CreateRKKForm createRkkForm);
}
