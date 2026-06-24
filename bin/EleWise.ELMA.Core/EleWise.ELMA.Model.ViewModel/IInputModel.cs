namespace EleWise.ELMA.Model.ViewModel;

public interface IInputModel
{
	string Key { get; set; }

	IViewModel Owner { get; set; }

	IInputs Inputs { get; set; }
}
public interface IInputModel<TInputs> : IInputModel where TInputs : IInputs
{
	new TInputs Inputs { get; set; }
}
