using EleWise.ELMA.Model.ViewModel;

namespace EleWise.ELMA.Core.Controllers;

public interface IRequireOwnerController
{
	void SetOwner(IViewModel owner);
}
