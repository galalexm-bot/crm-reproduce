namespace EleWise.ELMA.Model.ViewModel;

public abstract class InputsWithChildren<TChildren> : InputsWithoutChildren, IInputsWithChildren<TChildren>, IInputs
{
	private TChildren _003CChildren_003Ek__BackingField;

	public TChildren Children
	{
		get
		{
			return _003CChildren_003Ek__BackingField;
		}
		set
		{
			_003CChildren_003Ek__BackingField = value;
		}
	}
}
