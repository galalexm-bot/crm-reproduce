using EleWise.ELMA.Ioc.Abstract;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.ViewModel;

namespace EleWise.ELMA.Core.React.Models;

internal class InputModel : Reactive, IReactInputModel, IInputModel, IDataExtension
{
	private string _003CKey_003Ek__BackingField;

	private IViewModel _003COwner_003Ek__BackingField;

	private IInputs _003CInputs_003Ek__BackingField;

	private ILifetimeScope _003CRootScope_003Ek__BackingField;

	private IDataStack _003CDataStack_003Ek__BackingField;

	public string Key
	{
		get
		{
			return _003CKey_003Ek__BackingField;
		}
		set
		{
			_003CKey_003Ek__BackingField = value;
		}
	}

	public IViewModel Owner
	{
		get
		{
			return _003COwner_003Ek__BackingField;
		}
		set
		{
			_003COwner_003Ek__BackingField = value;
		}
	}

	public IInputs Inputs
	{
		get
		{
			return _003CInputs_003Ek__BackingField;
		}
		set
		{
			_003CInputs_003Ek__BackingField = value;
		}
	}

	public ILifetimeScope RootScope
	{
		get
		{
			return _003CRootScope_003Ek__BackingField;
		}
		set
		{
			_003CRootScope_003Ek__BackingField = value;
		}
	}

	public IDataStack DataStack
	{
		get
		{
			return _003CDataStack_003Ek__BackingField;
		}
		set
		{
			_003CDataStack_003Ek__BackingField = value;
		}
	}
}
internal class InputModel<TInputs> : InputModel, IReactInputModel<TInputs>, IInputModel<TInputs>, IInputModel, IReactInputModel, IDataExtension where TInputs : IInputs
{
	private TInputs _003CInputs_003Ek__BackingField;

	public new TInputs Inputs
	{
		get
		{
			return _003CInputs_003Ek__BackingField;
		}
		set
		{
			_003CInputs_003Ek__BackingField = value;
		}
	}

	IInputs IInputModel.Inputs
	{
		get
		{
			return Inputs;
		}
		set
		{
			Inputs = (TInputs)value;
		}
	}
}
