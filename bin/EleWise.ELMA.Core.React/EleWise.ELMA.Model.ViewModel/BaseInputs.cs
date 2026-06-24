using System;
using System.Threading.Tasks;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Model.ViewModel;

public class BaseInputs<TM, TChildren> : InputsWithChildren<TChildren>, IBaseInputs, IInputs
{
	private sealed class _003C_003Ec__DisplayClass16_0
	{
		public Func<object> value;

		internal TM _003CEleWise_002EELMA_002EModel_002EViewModel_002EIBaseInputs_002Eset_GetFunc_003Eb__0()
		{
			return ObjectExtensions.As<TM>(value.Invoke());
		}
	}

	private sealed class _003C_003Ec__DisplayClass19_0
	{
		public Action<object> value;

		internal void _003CEleWise_002EELMA_002EModel_002EViewModel_002EIBaseInputs_002Eset_SetFunc_003Eb__0(TM v)
		{
			value.Invoke((object)v);
		}
	}

	private Func<TM> _003CGetFunc_003Ek__BackingField;

	private Action<TM> _003CSetFunc_003Ek__BackingField;

	private Func<ViewAttributes> _003CAttributes_003Ek__BackingField;

	private Func<IPropertyMetadata> _003CPropertyMetadata_003Ek__BackingField;

	private Func<string> _003CDataTestId_003Ek__BackingField;

	private Func<IViewModel> _003CPropertyOwner_003Ek__BackingField;

	private Func<bool, FocusableType> _003CFocusableType_003Ek__BackingField;

	private Func<IKeyboardEvent, System.Threading.Tasks.Task> _003COnKeyPress_003Ek__BackingField;

	private Func<IChangeEvent, System.Threading.Tasks.Task> _003COnBlur_003Ek__BackingField;

	private Func<IFocusEvent, System.Threading.Tasks.Task> _003COnFocus_003Ek__BackingField;

	object IBaseInputs.Model
	{
		get
		{
			return Model;
		}
		set
		{
			Model = (TM)value;
		}
	}

	public TM Model
	{
		get
		{
			return GetFunc.Invoke();
		}
		set
		{
			SetFunc.Invoke(value);
		}
	}

	public Func<TM> GetFunc
	{
		get
		{
			return _003CGetFunc_003Ek__BackingField;
		}
		set
		{
			_003CGetFunc_003Ek__BackingField = value;
		}
	}

	public Action<TM> SetFunc
	{
		get
		{
			return _003CSetFunc_003Ek__BackingField;
		}
		set
		{
			_003CSetFunc_003Ek__BackingField = value;
		}
	}

	Func<object> IBaseInputs.GetFunc
	{
		get
		{
			return () => GetFunc.Invoke();
		}
		set
		{
			_003C_003Ec__DisplayClass16_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass16_0();
			CS_0024_003C_003E8__locals0.value = value;
			GetFunc = () => ObjectExtensions.As<TM>(CS_0024_003C_003E8__locals0.value.Invoke());
		}
	}

	Action<object> IBaseInputs.SetFunc
	{
		get
		{
			return delegate(object v)
			{
				SetFunc.Invoke((TM)v);
			};
		}
		set
		{
			_003C_003Ec__DisplayClass19_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass19_0();
			CS_0024_003C_003E8__locals0.value = value;
			SetFunc = delegate(TM v)
			{
				CS_0024_003C_003E8__locals0.value.Invoke((object)v);
			};
		}
	}

	public Func<ViewAttributes> Attributes
	{
		get
		{
			return _003CAttributes_003Ek__BackingField;
		}
		set
		{
			_003CAttributes_003Ek__BackingField = value;
		}
	}

	public Func<IPropertyMetadata> PropertyMetadata
	{
		get
		{
			return _003CPropertyMetadata_003Ek__BackingField;
		}
		set
		{
			_003CPropertyMetadata_003Ek__BackingField = value;
		}
	}

	public Func<string> DataTestId
	{
		get
		{
			return _003CDataTestId_003Ek__BackingField;
		}
		set
		{
			_003CDataTestId_003Ek__BackingField = value;
		}
	}

	public Func<IViewModel> PropertyOwner
	{
		get
		{
			return _003CPropertyOwner_003Ek__BackingField;
		}
		set
		{
			_003CPropertyOwner_003Ek__BackingField = value;
		}
	}

	public Func<bool, FocusableType> FocusableType
	{
		get
		{
			return _003CFocusableType_003Ek__BackingField;
		}
		set
		{
			_003CFocusableType_003Ek__BackingField = value;
		}
	}

	public Func<IKeyboardEvent, System.Threading.Tasks.Task> OnKeyPress
	{
		get
		{
			return _003COnKeyPress_003Ek__BackingField;
		}
		set
		{
			_003COnKeyPress_003Ek__BackingField = value;
		}
	}

	public Func<IChangeEvent, System.Threading.Tasks.Task> OnBlur
	{
		get
		{
			return _003COnBlur_003Ek__BackingField;
		}
		set
		{
			_003COnBlur_003Ek__BackingField = value;
		}
	}

	public Func<IFocusEvent, System.Threading.Tasks.Task> OnFocus
	{
		get
		{
			return _003COnFocus_003Ek__BackingField;
		}
		set
		{
			_003COnFocus_003Ek__BackingField = value;
		}
	}

	private object _003CEleWise_002EELMA_002EModel_002EViewModel_002EIBaseInputs_002Eget_GetFunc_003Eb__15_0()
	{
		return GetFunc.Invoke();
	}

	private void _003CEleWise_002EELMA_002EModel_002EViewModel_002EIBaseInputs_002Eget_SetFunc_003Eb__18_0(object v)
	{
		SetFunc.Invoke((TM)v);
	}
}
