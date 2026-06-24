using System;
using System.Reflection;
using System.Threading.Tasks;
using EleWise.ELMA.Core.React.Services;
using EleWise.ELMA.Core.UI.Services;
using EleWise.ELMA.Dispatcher;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Ioc;
using EleWise.ELMA.Model.Helpers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.ViewModel;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.Core.React.Models;

public class BaseInputViewModel : ViewModel, IViewModelHandler, IViewModel
{
	private sealed class _003C_003Ec__DisplayClass15_0
	{
		public string propertyName;

		public BaseInputViewModel _003C_003E4__this;

		internal object _003CGenerateContext_003Eb__1()
		{
			return _003C_003E4__this.GetInput(propertyName);
		}
	}

	private IComponentContainer componentSettings;

	private object value;

	private bool hasValueModel;

	public override IComponentContainer Component
	{
		get
		{
			if (componentSettings == null)
			{
				componentSettings = new InputComponentContainer(this);
			}
			return componentSettings;
		}
	}

	public Func<IKeyboardEvent, System.Threading.Tasks.Task> OnKeyPress => ((IBaseInputs)base.InputModel.Inputs).OnKeyPress;

	public Func<IFocusEvent, System.Threading.Tasks.Task> OnFocus => ((IBaseInputs)base.InputModel.Inputs).OnFocus;

	public Func<IChangeEvent, System.Threading.Tasks.Task> OnBlur => ((IBaseInputs)base.InputModel.Inputs).OnBlur;

	public BaseInputViewModel(IViewModelCreatorService viewModelCreatorService, ILazy<IViewItemComponentCreatorService> viewItemComponentCreatorService, IReactComponentCreatorService reactComponentCreatorService, IDispatcher dispatcher)
		: base(viewModelCreatorService, viewItemComponentCreatorService, reactComponentCreatorService, dispatcher)
	{
	}

	public void AfterView()
	{
		ClearCacheValue();
	}

	public void AfterAction()
	{
		ClearCacheValue();
	}

	private void ClearCacheValue()
	{
		value = null;
		hasValueModel = false;
	}

	protected override void GenerateContext(System.Type typeContext)
	{
		if (typeContext == null)
		{
			return;
		}
		IBaseContext baseContext = (IBaseContext)Activator.CreateInstance(typeContext);
		System.Type type = ((object)baseContext).GetType();
		PropertyInfo[] properties = type.GetProperties();
		System.Type baseType = type.get_BaseType();
		PropertyInfo[] array = properties;
		foreach (PropertyInfo val in array)
		{
			_003C_003Ec__DisplayClass15_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass15_0();
			CS_0024_003C_003E8__locals0._003C_003E4__this = this;
			CS_0024_003C_003E8__locals0.propertyName = ((MemberInfo)val).get_Name();
			if (CS_0024_003C_003E8__locals0.propertyName == "Model")
			{
				_ = baseContext.GetFunc;
				baseContext.GetFunc = delegate
				{
					if (hasValueModel)
					{
						return value;
					}
					value = ((IBaseInputs)base.InputModel.Inputs).GetFunc.Invoke();
					hasValueModel = true;
					return value;
				};
			}
			else if (CS_0024_003C_003E8__locals0.propertyName == "GetFunc" || CS_0024_003C_003E8__locals0.propertyName == "SetFunc")
			{
				baseContext.SetPropertyValue(CS_0024_003C_003E8__locals0.propertyName, GetInput(CS_0024_003C_003E8__locals0.propertyName));
			}
			else if (baseType.GetProperty(CS_0024_003C_003E8__locals0.propertyName) != null)
			{
				PropertyInfoExpression expression = new PropertyInfoExpression
				{
					ObjectExpression = CS_0024_003C_003E8__locals0.propertyName,
					ExpressionForSerialize = CS_0024_003C_003E8__locals0.propertyName
				};
				ConvertHelper.RedefineProp(baseContext, expression, () => CS_0024_003C_003E8__locals0._003C_003E4__this.GetInput(CS_0024_003C_003E8__locals0.propertyName));
			}
			else
			{
				object propertyValue = baseContext.GetPropertyValue(CS_0024_003C_003E8__locals0.propertyName, DefaultValueHelper.GetTypeDefaultValue(val.get_PropertyType()));
				ViewModel.DefineProperty(baseContext, new PropertyInfoExpression
				{
					ObjectExpression = CS_0024_003C_003E8__locals0.propertyName,
					ExpressionForSerialize = CS_0024_003C_003E8__locals0.propertyName
				});
				baseContext.SetPropertyValue(CS_0024_003C_003E8__locals0.propertyName, propertyValue);
			}
		}
		base.Context = baseContext;
	}

	private object _003CGenerateContext_003Eb__15_0()
	{
		if (hasValueModel)
		{
			return value;
		}
		value = ((IBaseInputs)base.InputModel.Inputs).GetFunc.Invoke();
		hasValueModel = true;
		return value;
	}
}
