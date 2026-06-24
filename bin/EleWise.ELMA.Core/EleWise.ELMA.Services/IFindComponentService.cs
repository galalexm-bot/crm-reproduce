using EleWise.ELMA.Api.Models;
using EleWise.ELMA.Core.ComponentModel;

namespace EleWise.ELMA.Services;

[ServiceContract]
internal interface IFindComponentService
{
	void RegisterSystemModule(ItemRuntimeModelDto[] itemRuntimeModels);
}
