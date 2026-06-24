using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;
using Bridge.React;
using EleWise.ELMA.Core.Controllers;
using EleWise.ELMA.Core.React.ExtensionPoints;
using EleWise.ELMA.Core.React.Services;
using EleWise.ELMA.Core.UI.Services;
using EleWise.ELMA.Dispatcher;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Ioc;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Helpers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Validation;
using EleWise.ELMA.Model.ViewModel;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.Core.React.Models;

public abstract class ViewModel<TContext, TController> : ViewModel, IViewModel<TContext, TController>, IViewModel where TContext : IContext where TController : IController
{
	public new TContext Context
	{
		get
		{
			if (base.Context != null)
			{
				return (TContext)base.Context;
			}
			return default(TContext);
		}
		set
		{
			base.Context = value;
		}
	}

	public new TController Controller
	{
		get
		{
			if (controller != null)
			{
				return (TController)controller;
			}
			return default(TController);
		}
	}

	public ViewModel(IViewModelCreatorService viewModelCreatorService, ILazy<IViewItemComponentCreatorService> lazyViewItemComponentCreatorService, IReactComponentCreatorService reactComponentCreatorService, IDispatcher dispatcher)
		: base(viewModelCreatorService, lazyViewItemComponentCreatorService, reactComponentCreatorService, dispatcher)
	{
	}
}
public class ViewModel : Reactive, IReactViewModel, IViewModel, IReactService, IValidationViewModel
{
	private sealed class _003C_003Ec__DisplayClass57_0
	{
		public ViewModel _003C_003E4__this;

		public IOnValidate validationController;
	}

	private sealed class _003C_003Ec__DisplayClass57_1
	{
		public Action onBefore;

		public Action onAfter;

		public _003C_003Ec__DisplayClass57_0 CS_0024_003C_003E8__locals1;

		internal ValidationResult _003CCreateValidation_003Eb__2()
		{
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Expected O, but got Unknown
			_003C_003Ec__DisplayClass57_2 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass57_2();
			CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals2 = this;
			CS_0024_003C_003E8__locals0.result = null;
			bool flag = ReactiveHelper.InAction();
			if (flag)
			{
				onBefore.Invoke();
				CS_0024_003C_003E8__locals1._003C_003E4__this.Component.Dispatcher.Dispatch((Action)delegate
				{
					CS_0024_003C_003E8__locals0.result = CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.validationController.OnValidate();
				});
			}
			else
			{
				GlobalScopeHelper.Push(CS_0024_003C_003E8__locals1._003C_003E4__this.RenderOwner);
				try
				{
					CS_0024_003C_003E8__locals0.result = CS_0024_003C_003E8__locals1.validationController.OnValidate();
				}
				finally
				{
					GlobalScopeHelper.Pop(CS_0024_003C_003E8__locals1._003C_003E4__this.RenderOwner);
				}
			}
			if (CS_0024_003C_003E8__locals0.result.ErrorMessage != null && string.IsNullOrWhiteSpace(CS_0024_003C_003E8__locals0.result.ErrorMessage.ComponentName))
			{
				CS_0024_003C_003E8__locals0.result.ErrorMessage.ComponentName = CS_0024_003C_003E8__locals1._003C_003E4__this.Component.Name;
			}
			if (flag)
			{
				onAfter.Invoke();
			}
			return CS_0024_003C_003E8__locals0.result;
		}
	}

	private sealed class _003C_003Ec__DisplayClass57_2
	{
		public ValidationResult result;

		public _003C_003Ec__DisplayClass57_1 CS_0024_003C_003E8__locals2;

		internal void _003CCreateValidation_003Eb__3()
		{
			result = CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.validationController.OnValidate();
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Action _003C_003E9__57_0;

		public static Action _003C_003E9__57_1;

		internal void _003CCreateValidation_003Eb__57_0()
		{
		}

		internal void _003CCreateValidation_003Eb__57_1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass59_0
	{
		public string propertyName;

		public ViewModel _003C_003E4__this;

		internal object _003CGenerateContext_003Eb__0()
		{
			return _003C_003E4__this.GetInput(propertyName);
		}
	}

	private readonly ILazy<IViewItemComponentCreatorService> lazyViewItemComponentCreatorService;

	private readonly IDispatcher dispatcher;

	protected DataStack Stack = new DataStack();

	private Func<IInputModel> inputModelFunc;

	private IComponentContainer componentSettings;

	private IViewModelValidationModel validationModel;

	private IViewModelCreatorService _003CViewModelCreatorService_003Ek__BackingField;

	private IReactComponentCreatorService _003CReactComponentCreatorService_003Ek__BackingField;

	private bool _003CError_003Ek__BackingField;

	private string _003CErrorMessage_003Ek__BackingField;

	private ErrorStackModel _003CErrorInfo_003Ek__BackingField = new ErrorStackModel();

	private IContext _003CContext_003Ek__BackingField;

	private IComponentDispatcher _003CComponentDispatcher_003Ek__BackingField;

	protected IController controller;

	public IViewModelCreatorService ViewModelCreatorService
	{
		get
		{
			return _003CViewModelCreatorService_003Ek__BackingField;
		}
		set
		{
			_003CViewModelCreatorService_003Ek__BackingField = value;
		}
	}

	public IViewItemComponentCreatorService ViewItemComponentCreatorService => lazyViewItemComponentCreatorService.Value();

	public IReactComponentCreatorService ReactComponentCreatorService
	{
		get
		{
			return _003CReactComponentCreatorService_003Ek__BackingField;
		}
		set
		{
			_003CReactComponentCreatorService_003Ek__BackingField = value;
		}
	}

	public bool Error
	{
		get
		{
			return _003CError_003Ek__BackingField;
		}
		set
		{
			_003CError_003Ek__BackingField = value;
		}
	}

	public string ErrorMessage
	{
		get
		{
			return _003CErrorMessage_003Ek__BackingField;
		}
		set
		{
			_003CErrorMessage_003Ek__BackingField = value;
		}
	}

	public ErrorStackModel ErrorInfo
	{
		get
		{
			return _003CErrorInfo_003Ek__BackingField;
		}
		set
		{
			_003CErrorInfo_003Ek__BackingField = value;
		}
	}

	public IInputModel InputModel => inputModelFunc?.Invoke();

	public virtual bool Ready
	{
		get
		{
			if (Context != null && controller != null)
			{
				return !Error;
			}
			return false;
		}
	}

	public IContext Context
	{
		get
		{
			return _003CContext_003Ek__BackingField;
		}
		set
		{
			_003CContext_003Ek__BackingField = value;
		}
	}

	public virtual IComponentContainer Component
	{
		get
		{
			if (componentSettings == null)
			{
				componentSettings = new ComponentContainer(this);
			}
			return componentSettings;
		}
	}

	public IViewModel RenderOwner => InputModel?.Owner;

	public virtual IController Controller => controller;

	public IComponentDispatcher ComponentDispatcher
	{
		get
		{
			return _003CComponentDispatcher_003Ek__BackingField;
		}
		private set
		{
			_003CComponentDispatcher_003Ek__BackingField = value;
		}
	}

	public IValidationModel ValidationModel
	{
		get
		{
			if (validationModel == null)
			{
				validationModel = new ValidationModel(this);
			}
			return validationModel;
		}
	}

	private IViewModelValidationModel ValidationModelInternal => (IViewModelValidationModel)ValidationModel;

	public ViewModel(IViewModelCreatorService viewModelCreatorService, ILazy<IViewItemComponentCreatorService> lazyViewItemComponentCreatorService, IReactComponentCreatorService reactComponentCreatorService, IDispatcher dispatcher)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		this.lazyViewItemComponentCreatorService = lazyViewItemComponentCreatorService;
		ViewModelCreatorService = viewModelCreatorService;
		ReactComponentCreatorService = reactComponentCreatorService;
		this.dispatcher = dispatcher;
		DefineProperty(this, new PropertyInfoExpression
		{
			ObjectExpression = "controller",
			ExpressionForSerialize = "controller"
		});
		DefineProperty(this, new PropertyInfoExpression
		{
			ObjectExpression = "Error",
			ExpressionForSerialize = "Error"
		});
	}

	public virtual void FillViewModel(Func<IInputModel> inputModel, System.Type typeContext, System.Type typeController, IReactComponent component)
	{
		inputModelFunc = inputModel;
		if (typeContext != null)
		{
			GenerateContext(typeContext);
		}
		if (typeController != null)
		{
			GenerateController(typeController);
		}
	}

	public virtual System.Threading.Tasks.Task Destroy()
	{
		return System.Threading.Tasks.Task.get_CompletedTask();
	}

	public void SetDynamicData(DataStackItem dataItem)
	{
		((HashSet<DataStackItem>)Stack).Add(dataItem);
	}

	public void RestoreDynamicData(DataStackItem dataItem)
	{
		((HashSet<DataStackItem>)Stack).Remove(dataItem);
	}

	public IDataStack GetDynamicData()
	{
		return Stack;
	}

	public void DestroyValidation()
	{
		ValidationModelInternal.Destroy();
		if (RenderOwner is ViewModel viewModel)
		{
			viewModel.ValidationModelInternal.RemoveValidator(OwnerValidator);
		}
	}

	protected void CreateValidation()
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		_003C_003Ec__DisplayClass57_0 _003C_003Ec__DisplayClass57_ = new _003C_003Ec__DisplayClass57_0();
		_003C_003Ec__DisplayClass57_._003C_003E4__this = this;
		if ((_003C_003Ec__DisplayClass57_.validationController = controller as IOnValidate) != null)
		{
			_003C_003Ec__DisplayClass57_2 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass57_1();
			CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass57_;
			object obj = _003C_003Ec._003C_003E9__57_0;
			if (obj == null)
			{
				Action val = delegate
				{
				};
				obj = (object)val;
				_003C_003Ec._003C_003E9__57_0 = val;
			}
			CS_0024_003C_003E8__locals0.onBefore = (Action)obj;
			object obj2 = _003C_003Ec._003C_003E9__57_1;
			if (obj2 == null)
			{
				Action val2 = delegate
				{
				};
				obj2 = (object)val2;
				_003C_003Ec._003C_003E9__57_1 = val2;
			}
			CS_0024_003C_003E8__locals0.onAfter = (Action)obj2;
			if (controller is IHandleValidateAction handleValidateAction)
			{
				CS_0024_003C_003E8__locals0.onBefore = new Action(handleValidateAction.OnBeforeValidateAction);
				CS_0024_003C_003E8__locals0.onAfter = new Action(handleValidateAction.OnAfterValidateAction);
			}
			ValidationModelInternal.AddValidator(delegate
			{
				//IL_0044: Unknown result type (might be due to invalid IL or missing references)
				//IL_004e: Expected O, but got Unknown
				CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass57_2();
				CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals2 = CS_0024_003C_003E8__locals0;
				CS_0024_003C_003E8__locals0.result = null;
				bool flag = ReactiveHelper.InAction();
				if (flag)
				{
					CS_0024_003C_003E8__locals0.onBefore.Invoke();
					CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1._003C_003E4__this.Component.Dispatcher.Dispatch((Action)delegate
					{
						CS_0024_003C_003E8__locals0.result = CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.validationController.OnValidate();
					});
				}
				else
				{
					GlobalScopeHelper.Push(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1._003C_003E4__this.RenderOwner);
					try
					{
						CS_0024_003C_003E8__locals0.result = CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.validationController.OnValidate();
					}
					finally
					{
						GlobalScopeHelper.Pop(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1._003C_003E4__this.RenderOwner);
					}
				}
				if (CS_0024_003C_003E8__locals0.result.ErrorMessage != null && string.IsNullOrWhiteSpace(CS_0024_003C_003E8__locals0.result.ErrorMessage.ComponentName))
				{
					CS_0024_003C_003E8__locals0.result.ErrorMessage.ComponentName = CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1._003C_003E4__this.Component.Name;
				}
				if (flag)
				{
					CS_0024_003C_003E8__locals0.onAfter.Invoke();
				}
				return CS_0024_003C_003E8__locals0.result;
			}, Component.Name + "Validator");
		}
		if (RenderOwner is ViewModel viewModel)
		{
			viewModel.ValidationModelInternal.AddValidator(OwnerValidator, Component.Name + "$OwnerValidator$" + RenderOwner.Component.Name);
		}
	}

	private ValidationResult OwnerValidator()
	{
		GlobalScopeHelper.Push(RenderOwner);
		try
		{
			return ValidationModel.GetSummaryResult();
		}
		finally
		{
			GlobalScopeHelper.Pop(RenderOwner);
		}
	}

	protected virtual void GenerateContext(System.Type typeContext)
	{
		if (typeContext == null)
		{
			return;
		}
		IContext context = (IContext)Activator.CreateInstance(typeContext);
		PropertyInfo[] properties = typeContext.GetProperties();
		System.Type baseType = typeContext.get_BaseType();
		PropertyInfo[] array = properties;
		foreach (PropertyInfo val in array)
		{
			_003C_003Ec__DisplayClass59_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass59_0();
			CS_0024_003C_003E8__locals0._003C_003E4__this = this;
			CS_0024_003C_003E8__locals0.propertyName = ((MemberInfo)val).get_Name();
			if (baseType.GetProperty(CS_0024_003C_003E8__locals0.propertyName) != null)
			{
				PropertyInfoExpression expression = new PropertyInfoExpression
				{
					ObjectExpression = CS_0024_003C_003E8__locals0.propertyName,
					ExpressionForSerialize = CS_0024_003C_003E8__locals0.propertyName
				};
				ConvertHelper.RedefineProp(context, expression, () => CS_0024_003C_003E8__locals0._003C_003E4__this.GetInput(CS_0024_003C_003E8__locals0.propertyName));
			}
			else
			{
				object propertyValue = context.GetPropertyValue(CS_0024_003C_003E8__locals0.propertyName, DefaultValueHelper.GetTypeDefaultValue(val.get_PropertyType()));
				DefineProperty(context, new PropertyInfoExpression
				{
					ObjectExpression = CS_0024_003C_003E8__locals0.propertyName,
					ExpressionForSerialize = CS_0024_003C_003E8__locals0.propertyName
				});
				context.SetPropertyValue(CS_0024_003C_003E8__locals0.propertyName, propertyValue);
			}
		}
		Context = context;
	}

	protected internal static void DefineProperty(object target, PropertyInfoExpression expression)
	{
		_ = expression.ObjectExpression;
	}

	protected virtual void GenerateController(System.Type typeController)
	{
		if (typeController != null && !typeController.get_IsInterface())
		{
			controller = ViewModelCreatorService.ControllerCreator(typeController, Context, this);
			CreateDispatcher(typeController);
			dispatcher.Dispatch(new ActionCommand("ControllerCommand", "", controller, (Func<System.Threading.Tasks.Task>)delegate
			{
				CreateValidation();
				return System.Threading.Tasks.Task.get_CompletedTask();
			}));
		}
	}

	protected void CreateDispatcher(System.Type typeController)
	{
		System.Type type = typeof(ComponentDispatcher<>).MakeGenericType(new System.Type[1] { typeController });
		ComponentDispatcher = (IComponentDispatcher)Activator.CreateInstance(type, new object[2] { dispatcher, this });
	}

	protected object GetInput(string propertyName)
	{
		if (InputModel.Inputs == null)
		{
			return null;
		}
		PropertyInfo property = ((object)InputModel.Inputs).GetType().GetProperty(propertyName);
		if (property != null)
		{
			return property.GetValue((object)InputModel.Inputs);
		}
		return ((object)InputModel.Inputs).get_Item(propertyName);
	}

	protected IDataStack GetData()
	{
		if (!(InputModel is IReactViewItemInputModel reactViewItemInputModel))
		{
			return null;
		}
		return reactViewItemInputModel.DataStack;
	}

	private System.Threading.Tasks.Task _003CGenerateController_003Eb__61_0()
	{
		CreateValidation();
		return System.Threading.Tasks.Task.get_CompletedTask();
	}
}
