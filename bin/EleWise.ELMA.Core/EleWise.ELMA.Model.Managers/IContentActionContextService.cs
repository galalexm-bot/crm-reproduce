using System.Collections.Generic;
using System.Threading.Tasks;
using EleWise.ELMA.Core.Abstractions.Metadata.Models;
using EleWise.ELMA.Core.ComponentModel;

namespace EleWise.ELMA.Model.Managers;

[ServiceContract]
public interface IContentActionContextService
{
	System.Collections.Generic.IEnumerable<ContentAction> GetAll();

	ContentAction GetAction(string actionId);

	System.Threading.Tasks.Task<EntityFormView> LoadEntityForm(FormModel model);

	System.Threading.Tasks.Task<ContentActionId> GetActionId(ContentActionModel model);

	System.Threading.Tasks.Task<FormBindingModel> GetFormBindingModel(string actionId);
}
