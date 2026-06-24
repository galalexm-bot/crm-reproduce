namespace EleWise.ELMA.Model.ViewModel;

public interface IInputsWithChildren<TChildren> : IInputs
{
	TChildren Children { get; set; }
}
