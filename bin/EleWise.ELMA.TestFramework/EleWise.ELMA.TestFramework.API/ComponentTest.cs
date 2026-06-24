using System;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading.Tasks;
using EleWise.ELMA.Core.Controllers;
using EleWise.ELMA.Model.ViewModel;
using EleWise.ELMA.TestFramework.BDD;
using EleWise.ELMA.TestFramework.Mocking;
using EleWise.ELMA.TestFramework.Services;

namespace EleWise.ELMA.TestFramework.API;

public abstract class ComponentTest<TContext, TController, TServer> : Test<IComponentTestModel<TContext, TController>>, IComponentTest where TContext : IContext where TController : IClientController where TServer : IServerController
{
	private sealed class _003C_003Ec__DisplayClass2_0
	{
		public string methodName;

		public Action<TContext> mockFn;

		public MethodInfo methodInfo;

		internal void _003CMockServer_003Eb__0(IComponentTestModel<TContext, TController> model)
		{
			_003C_003Ec__DisplayClass2_1 obj = new _003C_003Ec__DisplayClass2_1
			{
				model = model,
				mock = new MockFunctionWithParam<TContext>(methodName, mockFn)
			};
			Func<System.Threading.Tasks.Task> val = () => obj.mock.Call(obj.model.Context);
			((object)obj.model.Controller.Server).set_Item(methodInfo.get_ScriptName(), (object)val);
		}
	}

	private sealed class _003C_003Ec__DisplayClass2_1
	{
		public MockFunctionWithParam<TContext> mock;

		public IComponentTestModel<TContext, TController> model;

		internal System.Threading.Tasks.Task _003CMockServer_003Eb__1()
		{
			return mock.Call(model.Context);
		}
	}

	private sealed class _003C_003Ec__DisplayClass3_0
	{
		public ComponentTest<TContext, TController, TServer> _003C_003E4__this;

		public Func<TContext, Func<System.Threading.Tasks.Task>> expression;

		public Action mockFn;

		internal void _003CMockAction_003Eb__0(IComponentTestModel<TContext, TController> model)
		{
			_003C_003Ec__DisplayClass3_1 _003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_1();
			string propertyName = _003C_003E4__this.GetPropertyName(model.Context, expression.Invoke(model.Context));
			_003C_003Ec__DisplayClass3_.mock = new MockFunction(propertyName, mockFn);
			Func<System.Threading.Tasks.Task> mock = () => _003C_003Ec__DisplayClass3_.mock.Call();
			_003C_003E4__this.MockProperty(model.Context, propertyName, mock);
		}
	}

	private sealed class _003C_003Ec__DisplayClass3_1
	{
		public MockFunction mock;

		internal System.Threading.Tasks.Task _003CMockAction_003Eb__1()
		{
			return mock.Call();
		}
	}

	private sealed class _003C_003Ec__DisplayClass4_0<T>
	{
		public ComponentTest<TContext, TController, TServer> _003C_003E4__this;

		public Func<TContext, Func<T, System.Threading.Tasks.Task>> expression;

		public Action<T> mockFn;

		internal void _003CMockAction_003Eb__0(IComponentTestModel<TContext, TController> model)
		{
			_003C_003Ec__DisplayClass4_1<T> _003C_003Ec__DisplayClass4_ = new _003C_003Ec__DisplayClass4_1<T>();
			string propertyName = _003C_003E4__this.GetPropertyName(model.Context, ((Func<TContext, Func<_003F, System.Threading.Tasks.Task>>)(object)expression).Invoke(model.Context));
			_003C_003Ec__DisplayClass4_.mock = new MockFunctionWithParam<T>(propertyName, mockFn);
			Func<T, System.Threading.Tasks.Task> mock = (Func<T, System.Threading.Tasks.Task>)(object)(Func<_003F, System.Threading.Tasks.Task>)((T param) => _003C_003Ec__DisplayClass4_.mock.Call(param));
			_003C_003E4__this.MockProperty(model.Context, propertyName, mock);
		}
	}

	private sealed class _003C_003Ec__DisplayClass4_1<T>
	{
		public MockFunctionWithParam<T> mock;

		internal System.Threading.Tasks.Task _003CMockAction_003Eb__1(T param)
		{
			return mock.Call(param);
		}
	}

	private sealed class _003C_003Ec__DisplayClass5_0<T>
	{
		public ComponentTest<TContext, TController, TServer> _003C_003E4__this;

		public Func<TContext, Func<System.Threading.Tasks.Task<T>>> expression;

		public Func<T> mockFn;

		internal void _003CMockAction_003Eb__0(IComponentTestModel<TContext, TController> model)
		{
			_003C_003Ec__DisplayClass5_1<T> _003C_003Ec__DisplayClass5_ = new _003C_003Ec__DisplayClass5_1<T>();
			string propertyName = _003C_003E4__this.GetPropertyName(model.Context, ((Func<TContext, Func<System.Threading.Tasks.Task<_003F>>>)(object)expression).Invoke(model.Context));
			_003C_003Ec__DisplayClass5_.mock = new MockFunctionWithOutput<T>(propertyName, mockFn);
			Func<System.Threading.Tasks.Task<T>> mock = (Func<System.Threading.Tasks.Task<T>>)(object)(Func<System.Threading.Tasks.Task<_003F>>)(() => _003C_003Ec__DisplayClass5_.mock.Call());
			_003C_003E4__this.MockProperty(model.Context, propertyName, mock);
		}
	}

	private sealed class _003C_003Ec__DisplayClass5_1<T>
	{
		public MockFunctionWithOutput<T> mock;

		internal System.Threading.Tasks.Task<T> _003CMockAction_003Eb__1()
		{
			return mock.Call();
		}
	}

	private sealed class _003C_003Ec__DisplayClass6_0<T, TResult>
	{
		public ComponentTest<TContext, TController, TServer> _003C_003E4__this;

		public Func<TContext, Func<T, System.Threading.Tasks.Task<TResult>>> expression;

		public Func<T, TResult> mockFn;

		internal void _003CMockAction_003Eb__0(IComponentTestModel<TContext, TController> model)
		{
			_003C_003Ec__DisplayClass6_1<T, TResult> _003C_003Ec__DisplayClass6_ = new _003C_003Ec__DisplayClass6_1<T, TResult>();
			string propertyName = _003C_003E4__this.GetPropertyName(model.Context, ((Func<TContext, Func<_003F, System.Threading.Tasks.Task<_003F>>>)(object)expression).Invoke(model.Context));
			_003C_003Ec__DisplayClass6_.mock = new MockFunctionWithParamAndOutput<T, TResult>(propertyName, mockFn);
			Func<T, System.Threading.Tasks.Task<TResult>> mock = (Func<T, System.Threading.Tasks.Task<TResult>>)(object)(Func<_003F, System.Threading.Tasks.Task<_003F>>)((T param) => _003C_003Ec__DisplayClass6_.mock.Call(param));
			_003C_003E4__this.MockProperty(model.Context, propertyName, mock);
		}
	}

	private sealed class _003C_003Ec__DisplayClass6_1<T, TResult>
	{
		public MockFunctionWithParamAndOutput<T, TResult> mock;

		internal System.Threading.Tasks.Task<TResult> _003CMockAction_003Eb__1(T param)
		{
			return mock.Call(param);
		}
	}

	private sealed class _003C_003Ec__DisplayClass7_0<T>
	{
		public ComponentTest<TContext, TController, TServer> _003C_003E4__this;

		public Func<TContext, T> expression;

		public T value;

		public Func<T> _003C_003E9__1;

		internal void _003CSetValue_003Eb__0(IComponentTestModel<TContext, TController> model)
		{
			string propertyName = _003C_003E4__this.GetPropertyName(model.Context, ((Func<TContext, _003F>)(object)expression).Invoke(model.Context));
			Func<T> mock = (Func<T>)(object)(Func<_003F>)(() => value);
			_003C_003E4__this.MockProperty(model.Context, propertyName, mock);
		}

		internal T _003CSetValue_003Eb__1()
		{
			return value;
		}
	}

	private sealed class _003C_003Ec__DisplayClass8_0<T>
	{
		public ComponentTest<TContext, TController, TServer> _003C_003E4__this;

		public Func<TContext, T> expression;

		public Func<T> valueFunc;

		internal void _003CSetValue_003Eb__0(IComponentTestModel<TContext, TController> model)
		{
			string propertyName = _003C_003E4__this.GetPropertyName(model.Context, ((Func<TContext, _003F>)(object)expression).Invoke(model.Context));
			_003C_003E4__this.MockProperty(model.Context, propertyName, valueFunc, computed: true);
		}
	}

	private ITestComponentCreatorService _003CEleWise_002EELMA_002ETestFramework_002EAPI_002EIComponentTest_002ETestComponentCreatorService_003Ek__BackingField;

	public abstract string ComponentUid { get; }

	ITestComponentCreatorService IComponentTest.TestComponentCreatorService
	{
		get
		{
			return _003CEleWise_002EELMA_002ETestFramework_002EAPI_002EIComponentTest_002ETestComponentCreatorService_003Ek__BackingField;
		}
		set
		{
			_003CEleWise_002EELMA_002ETestFramework_002EAPI_002EIComponentTest_002ETestComponentCreatorService_003Ek__BackingField = value;
		}
	}

	protected override Func<IComponentTestModel<TContext, TController>> Model => (Func<IComponentTestModel<TContext, TController>>)(object)new Func<IComponentTestModel<IComponentTestModel<TContext, TController>, _003F>>(CreateTestModel);

	public IStep MockServer(Expression<Func<TServer, Func<System.Threading.Tasks.Task>>> expression, Action<TContext> mockFn)
	{
		_003C_003Ec__DisplayClass2_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass2_0();
		CS_0024_003C_003E8__locals0.mockFn = mockFn;
		CS_0024_003C_003E8__locals0.methodInfo = GetMethodInfo((LambdaExpression)(object)expression);
		CS_0024_003C_003E8__locals0.methodName = ((MemberInfo)CS_0024_003C_003E8__locals0.methodInfo).get_Name();
		return new TestStepWithParam<IComponentTestModel<TContext, TController>>((Action<IComponentTestModel<TContext, TController>>)(object)(Action<IComponentTestModel<IComponentTestModel<TContext, TController>, _003F>>)delegate(IComponentTestModel<TContext, TController> model)
		{
			_003C_003Ec__DisplayClass2_1 obj = new _003C_003Ec__DisplayClass2_1
			{
				model = model,
				mock = new MockFunctionWithParam<TContext>(CS_0024_003C_003E8__locals0.methodName, CS_0024_003C_003E8__locals0.mockFn)
			};
			Func<System.Threading.Tasks.Task> val = () => obj.mock.Call(obj.model.Context);
			((object)obj.model.Controller.Server).set_Item(CS_0024_003C_003E8__locals0.methodInfo.get_ScriptName(), (object)val);
		}, CS_0024_003C_003E8__locals0.methodName, StepType.MOCK);
	}

	public IStep MockAction(Func<TContext, Func<System.Threading.Tasks.Task>> expression, Action mockFn)
	{
		return new TestStepWithParam<IComponentTestModel<TContext, TController>>((Action<IComponentTestModel<TContext, TController>>)(object)new Action<IComponentTestModel<IComponentTestModel<TContext, TController>, _003F>>(new _003C_003Ec__DisplayClass3_0
		{
			_003C_003E4__this = this,
			expression = expression,
			mockFn = mockFn
		}._003CMockAction_003Eb__0), "MockAction", StepType.MOCK);
	}

	public IStep MockAction<T>(Func<TContext, Func<T, System.Threading.Tasks.Task>> expression, Action<T> mockFn)
	{
		return new TestStepWithParam<IComponentTestModel<TContext, TController>>((Action<IComponentTestModel<TContext, TController>>)(object)new Action<IComponentTestModel<IComponentTestModel<TContext, TController>, _003F>>(new _003C_003Ec__DisplayClass4_0<T>
		{
			_003C_003E4__this = this,
			expression = expression,
			mockFn = mockFn
		}._003CMockAction_003Eb__0), "MockAction", StepType.MOCK);
	}

	public IStep MockAction<T>(Func<TContext, Func<System.Threading.Tasks.Task<T>>> expression, Func<T> mockFn)
	{
		return new TestStepWithParam<IComponentTestModel<TContext, TController>>((Action<IComponentTestModel<TContext, TController>>)(object)new Action<IComponentTestModel<IComponentTestModel<TContext, TController>, _003F>>(new _003C_003Ec__DisplayClass5_0<T>
		{
			_003C_003E4__this = this,
			expression = expression,
			mockFn = mockFn
		}._003CMockAction_003Eb__0), "MockAction", StepType.MOCK);
	}

	public IStep MockAction<T, TResult>(Func<TContext, Func<T, System.Threading.Tasks.Task<TResult>>> expression, Func<T, TResult> mockFn)
	{
		return new TestStepWithParam<IComponentTestModel<TContext, TController>>((Action<IComponentTestModel<TContext, TController>>)(object)new Action<IComponentTestModel<IComponentTestModel<TContext, TController>, _003F>>(new _003C_003Ec__DisplayClass6_0<T, TResult>
		{
			_003C_003E4__this = this,
			expression = expression,
			mockFn = mockFn
		}._003CMockAction_003Eb__0), "MockAction", StepType.MOCK);
	}

	public IStep SetValue<T>(Func<TContext, T> expression, T value)
	{
		return new TestStepWithParam<IComponentTestModel<TContext, TController>>((Action<IComponentTestModel<TContext, TController>>)(object)new Action<IComponentTestModel<IComponentTestModel<TContext, TController>, _003F>>(new _003C_003Ec__DisplayClass7_0<T>
		{
			_003C_003E4__this = this,
			expression = expression,
			value = value
		}._003CSetValue_003Eb__0), "SetValue", StepType.WHEN);
	}

	public IStep SetValue<T>(Func<TContext, T> expression, Func<T> valueFunc)
	{
		return new TestStepWithParam<IComponentTestModel<TContext, TController>>((Action<IComponentTestModel<TContext, TController>>)(object)new Action<IComponentTestModel<IComponentTestModel<TContext, TController>, _003F>>(new _003C_003Ec__DisplayClass8_0<T>
		{
			_003C_003E4__this = this,
			expression = expression,
			valueFunc = valueFunc
		}._003CSetValue_003Eb__0), "SetValue", StepType.WHEN);
	}

	private IComponentTestModel<TContext, TController> CreateTestModel()
	{
		IComponentViewItemViewModel componentViewItemViewModel = ((IComponentTest)this).TestComponentCreatorService.CreateModel<IComponentViewItemViewModel>(ComponentUid);
		return new ComponentTestModel<TContext, TController>(componentViewItemViewModel.Context, componentViewItemViewModel.Controller);
	}

	private MethodInfo GetMethodInfo(LambdaExpression expression)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		Expression operand = ((UnaryExpression)expression.get_Body()).get_Operand();
		return (MethodInfo)((ConstantExpression)((MethodCallExpression)((operand is MethodCallExpression) ? operand : null)).get_Object()).get_Value();
	}

	private string GetPropertyName(object target, object prop)
	{
		return null;
	}

	private void MockProperty(object target, string propertyName, object mock, bool computed = false)
	{
	}
}
public abstract class ComponentTest<TController, TServer> : Test<IComponentTestModel<TController>>, IComponentTest where TController : IClientController where TServer : IServerController
{
	private sealed class _003C_003Ec__DisplayClass2_0
	{
		public string methodName;

		public Action<IContext> mockFn;

		public MethodInfo methodInfo;

		internal void _003CMockServer_003Eb__0(IComponentTestModel<TController> model)
		{
			_003C_003Ec__DisplayClass2_1 obj = new _003C_003Ec__DisplayClass2_1
			{
				model = model,
				mock = new MockFunctionWithParam<IContext>(methodName, mockFn)
			};
			Func<System.Threading.Tasks.Task> val = () => obj.mock.Call(obj.model.Context);
			((object)obj.model.Controller.Server).set_Item(methodInfo.get_ScriptName(), (object)val);
		}
	}

	private sealed class _003C_003Ec__DisplayClass2_1
	{
		public MockFunctionWithParam<IContext> mock;

		public IComponentTestModel<TController> model;

		internal System.Threading.Tasks.Task _003CMockServer_003Eb__1()
		{
			return mock.Call(model.Context);
		}
	}

	private sealed class _003C_003Ec__DisplayClass3_0
	{
		public ComponentTest<TController, TServer> _003C_003E4__this;

		public Func<IContext, Func<System.Threading.Tasks.Task>> expression;

		public Action mockFn;

		internal void _003CMockAction_003Eb__0(IComponentTestModel<TController> model)
		{
			_003C_003Ec__DisplayClass3_1 _003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_1();
			string propertyName = _003C_003E4__this.GetPropertyName(model.Context, expression.Invoke(model.Context));
			_003C_003Ec__DisplayClass3_.mock = new MockFunction(propertyName, mockFn);
			Func<System.Threading.Tasks.Task> mock = () => _003C_003Ec__DisplayClass3_.mock.Call();
			_003C_003E4__this.MockProperty(model.Context, propertyName, mock);
		}
	}

	private sealed class _003C_003Ec__DisplayClass3_1
	{
		public MockFunction mock;

		internal System.Threading.Tasks.Task _003CMockAction_003Eb__1()
		{
			return mock.Call();
		}
	}

	private sealed class _003C_003Ec__DisplayClass4_0<T>
	{
		public ComponentTest<TController, TServer> _003C_003E4__this;

		public Func<IContext, Func<T, System.Threading.Tasks.Task>> expression;

		public Action<T> mockFn;

		internal void _003CMockAction_003Eb__0(IComponentTestModel<TController> model)
		{
			_003C_003Ec__DisplayClass4_1<T> _003C_003Ec__DisplayClass4_ = new _003C_003Ec__DisplayClass4_1<T>();
			string propertyName = _003C_003E4__this.GetPropertyName(model.Context, ((Func<IContext, Func<_003F, System.Threading.Tasks.Task>>)(object)expression).Invoke(model.Context));
			_003C_003Ec__DisplayClass4_.mock = new MockFunctionWithParam<T>(propertyName, mockFn);
			Func<T, System.Threading.Tasks.Task> mock = (Func<T, System.Threading.Tasks.Task>)(object)(Func<_003F, System.Threading.Tasks.Task>)((T param) => _003C_003Ec__DisplayClass4_.mock.Call(param));
			_003C_003E4__this.MockProperty(model.Context, propertyName, mock);
		}
	}

	private sealed class _003C_003Ec__DisplayClass4_1<T>
	{
		public MockFunctionWithParam<T> mock;

		internal System.Threading.Tasks.Task _003CMockAction_003Eb__1(T param)
		{
			return mock.Call(param);
		}
	}

	private sealed class _003C_003Ec__DisplayClass5_0<T>
	{
		public ComponentTest<TController, TServer> _003C_003E4__this;

		public Func<IContext, Func<System.Threading.Tasks.Task<T>>> expression;

		public Func<T> mockFn;

		internal void _003CMockAction_003Eb__0(IComponentTestModel<TController> model)
		{
			_003C_003Ec__DisplayClass5_1<T> _003C_003Ec__DisplayClass5_ = new _003C_003Ec__DisplayClass5_1<T>();
			string propertyName = _003C_003E4__this.GetPropertyName(model.Context, ((Func<IContext, Func<System.Threading.Tasks.Task<_003F>>>)(object)expression).Invoke(model.Context));
			_003C_003Ec__DisplayClass5_.mock = new MockFunctionWithOutput<T>(propertyName, mockFn);
			Func<System.Threading.Tasks.Task<T>> mock = (Func<System.Threading.Tasks.Task<T>>)(object)(Func<System.Threading.Tasks.Task<_003F>>)(() => _003C_003Ec__DisplayClass5_.mock.Call());
			_003C_003E4__this.MockProperty(model.Context, propertyName, mock);
		}
	}

	private sealed class _003C_003Ec__DisplayClass5_1<T>
	{
		public MockFunctionWithOutput<T> mock;

		internal System.Threading.Tasks.Task<T> _003CMockAction_003Eb__1()
		{
			return mock.Call();
		}
	}

	private sealed class _003C_003Ec__DisplayClass6_0<T, TResult>
	{
		public ComponentTest<TController, TServer> _003C_003E4__this;

		public Func<IContext, Func<T, System.Threading.Tasks.Task<TResult>>> expression;

		public Func<T, TResult> mockFn;

		internal void _003CMockAction_003Eb__0(IComponentTestModel<TController> model)
		{
			_003C_003Ec__DisplayClass6_1<T, TResult> _003C_003Ec__DisplayClass6_ = new _003C_003Ec__DisplayClass6_1<T, TResult>();
			string propertyName = _003C_003E4__this.GetPropertyName(model.Context, ((Func<IContext, Func<_003F, System.Threading.Tasks.Task<_003F>>>)(object)expression).Invoke(model.Context));
			_003C_003Ec__DisplayClass6_.mock = new MockFunctionWithParamAndOutput<T, TResult>(propertyName, mockFn);
			Func<T, System.Threading.Tasks.Task<TResult>> mock = (Func<T, System.Threading.Tasks.Task<TResult>>)(object)(Func<_003F, System.Threading.Tasks.Task<_003F>>)((T param) => _003C_003Ec__DisplayClass6_.mock.Call(param));
			_003C_003E4__this.MockProperty(model.Context, propertyName, mock);
		}
	}

	private sealed class _003C_003Ec__DisplayClass6_1<T, TResult>
	{
		public MockFunctionWithParamAndOutput<T, TResult> mock;

		internal System.Threading.Tasks.Task<TResult> _003CMockAction_003Eb__1(T param)
		{
			return mock.Call(param);
		}
	}

	private sealed class _003C_003Ec__DisplayClass7_0<T>
	{
		public ComponentTest<TController, TServer> _003C_003E4__this;

		public Func<IContext, T> expression;

		public T value;

		internal void _003CSetValue_003Eb__0(IComponentTestModel<TController> model)
		{
			string propertyName = _003C_003E4__this.GetPropertyName(model.Context, ((Func<IContext, _003F>)(object)expression).Invoke(model.Context));
			_003C_003E4__this.MockProperty(model.Context, propertyName, value);
		}
	}

	private sealed class _003C_003Ec__DisplayClass8_0<T>
	{
		public ComponentTest<TController, TServer> _003C_003E4__this;

		public Func<IContext, T> expression;

		public Func<T> valueFunc;

		internal void _003CSetValue_003Eb__0(IComponentTestModel<TController> model)
		{
			string propertyName = _003C_003E4__this.GetPropertyName(model.Context, ((Func<IContext, _003F>)(object)expression).Invoke(model.Context));
			_003C_003E4__this.MockProperty(model.Context, propertyName, valueFunc, computed: true);
		}
	}

	private ITestComponentCreatorService _003CEleWise_002EELMA_002ETestFramework_002EAPI_002EIComponentTest_002ETestComponentCreatorService_003Ek__BackingField;

	public abstract string ComponentUid { get; }

	ITestComponentCreatorService IComponentTest.TestComponentCreatorService
	{
		get
		{
			return _003CEleWise_002EELMA_002ETestFramework_002EAPI_002EIComponentTest_002ETestComponentCreatorService_003Ek__BackingField;
		}
		set
		{
			_003CEleWise_002EELMA_002ETestFramework_002EAPI_002EIComponentTest_002ETestComponentCreatorService_003Ek__BackingField = value;
		}
	}

	protected override Func<IComponentTestModel<TController>> Model => (Func<IComponentTestModel<TController>>)(object)new Func<IComponentTestModel<IComponentTestModel<TController>>>(CreateTestModel);

	public IStep MockServer(Expression<Func<TServer, Func<System.Threading.Tasks.Task>>> expression, Action<IContext> mockFn)
	{
		_003C_003Ec__DisplayClass2_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass2_0();
		CS_0024_003C_003E8__locals0.mockFn = mockFn;
		CS_0024_003C_003E8__locals0.methodInfo = GetMethodInfo((LambdaExpression)(object)expression);
		CS_0024_003C_003E8__locals0.methodName = ((MemberInfo)CS_0024_003C_003E8__locals0.methodInfo).get_Name();
		return new TestStepWithParam<IComponentTestModel<TController>>((Action<IComponentTestModel<TController>>)(object)(Action<IComponentTestModel<IComponentTestModel<TController>>>)delegate(IComponentTestModel<TController> model)
		{
			_003C_003Ec__DisplayClass2_1 obj = new _003C_003Ec__DisplayClass2_1
			{
				model = model,
				mock = new MockFunctionWithParam<IContext>(CS_0024_003C_003E8__locals0.methodName, CS_0024_003C_003E8__locals0.mockFn)
			};
			Func<System.Threading.Tasks.Task> val = () => obj.mock.Call(obj.model.Context);
			((object)obj.model.Controller.Server).set_Item(CS_0024_003C_003E8__locals0.methodInfo.get_ScriptName(), (object)val);
		}, CS_0024_003C_003E8__locals0.methodName, StepType.MOCK);
	}

	public IStep MockAction(Func<IContext, Func<System.Threading.Tasks.Task>> expression, Action mockFn)
	{
		return new TestStepWithParam<IComponentTestModel<TController>>((Action<IComponentTestModel<TController>>)(object)new Action<IComponentTestModel<IComponentTestModel<TController>>>(new _003C_003Ec__DisplayClass3_0
		{
			_003C_003E4__this = this,
			expression = expression,
			mockFn = mockFn
		}._003CMockAction_003Eb__0), "MockAction", StepType.MOCK);
	}

	public IStep MockAction<T>(Func<IContext, Func<T, System.Threading.Tasks.Task>> expression, Action<T> mockFn)
	{
		return new TestStepWithParam<IComponentTestModel<TController>>((Action<IComponentTestModel<TController>>)(object)new Action<IComponentTestModel<IComponentTestModel<TController>>>(new _003C_003Ec__DisplayClass4_0<T>
		{
			_003C_003E4__this = this,
			expression = expression,
			mockFn = mockFn
		}._003CMockAction_003Eb__0), "MockAction", StepType.MOCK);
	}

	public IStep MockAction<T>(Func<IContext, Func<System.Threading.Tasks.Task<T>>> expression, Func<T> mockFn)
	{
		return new TestStepWithParam<IComponentTestModel<TController>>((Action<IComponentTestModel<TController>>)(object)new Action<IComponentTestModel<IComponentTestModel<TController>>>(new _003C_003Ec__DisplayClass5_0<T>
		{
			_003C_003E4__this = this,
			expression = expression,
			mockFn = mockFn
		}._003CMockAction_003Eb__0), "MockAction", StepType.MOCK);
	}

	public IStep MockAction<T, TResult>(Func<IContext, Func<T, System.Threading.Tasks.Task<TResult>>> expression, Func<T, TResult> mockFn)
	{
		return new TestStepWithParam<IComponentTestModel<TController>>((Action<IComponentTestModel<TController>>)(object)new Action<IComponentTestModel<IComponentTestModel<TController>>>(new _003C_003Ec__DisplayClass6_0<T, TResult>
		{
			_003C_003E4__this = this,
			expression = expression,
			mockFn = mockFn
		}._003CMockAction_003Eb__0), "MockAction", StepType.MOCK);
	}

	public IStep SetValue<T>(Func<IContext, T> expression, T value)
	{
		return new TestStepWithParam<IComponentTestModel<TController>>((Action<IComponentTestModel<TController>>)(object)new Action<IComponentTestModel<IComponentTestModel<TController>>>(new _003C_003Ec__DisplayClass7_0<T>
		{
			_003C_003E4__this = this,
			expression = expression,
			value = value
		}._003CSetValue_003Eb__0), "SetValue", StepType.WHEN);
	}

	public IStep SetValue<T>(Func<IContext, T> expression, Func<T> valueFunc)
	{
		return new TestStepWithParam<IComponentTestModel<TController>>((Action<IComponentTestModel<TController>>)(object)new Action<IComponentTestModel<IComponentTestModel<TController>>>(new _003C_003Ec__DisplayClass8_0<T>
		{
			_003C_003E4__this = this,
			expression = expression,
			valueFunc = valueFunc
		}._003CSetValue_003Eb__0), "SetValue", StepType.WHEN);
	}

	private IComponentTestModel<TController> CreateTestModel()
	{
		IComponentViewItemViewModel componentViewItemViewModel = ((IComponentTest)this).TestComponentCreatorService.CreateModel<IComponentViewItemViewModel>(ComponentUid);
		return new ComponentTestModel<TController>(componentViewItemViewModel.Context, componentViewItemViewModel.Controller);
	}

	private MethodInfo GetMethodInfo(LambdaExpression expression)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		Expression operand = ((UnaryExpression)expression.get_Body()).get_Operand();
		return (MethodInfo)((ConstantExpression)((MethodCallExpression)((operand is MethodCallExpression) ? operand : null)).get_Object()).get_Value();
	}

	private string GetPropertyName(object target, object prop)
	{
		return null;
	}

	private void MockProperty(object target, string propertyName, object mock, bool computed = false)
	{
	}
}
