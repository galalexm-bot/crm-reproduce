namespace EleWise.ELMA.Model.ViewModel;

public interface IViewModelHandler : IViewModel
{
	void AfterView();

	void AfterAction();
}
