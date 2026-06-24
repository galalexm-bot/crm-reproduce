using System;
using System.Reflection;
using System.Threading.Tasks;
using EleWise.ELMA.Core.Controllers;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.ViewModel;
using EleWise.ELMA.TestFramework.BDD;
using EleWise.ELMA.TestFramework.Services;

namespace EleWise.ELMA.TestFramework.API;

public abstract class BaseReactComponentTest<TInputs, TContext, TController> : Test<IBaseReactComponentTestModel<TContext, TController, TInputs>>, IComponentTest where TInputs : IInputs where TContext : IContext where TController : IController
{
	private IViewModel viewModel;

	private IBaseReactComponentTestModel<TContext, TController, TInputs> model;

	private ITestComponentCreatorService _003CEleWise_002EELMA_002ETestFramework_002EAPI_002EIComponentTest_002ETestComponentCreatorService_003Ek__BackingField;

	public abstract System.Type ComponentType { get; }

	protected override Func<IBaseReactComponentTestModel<TContext, TController, TInputs>> Model => (Func<IBaseReactComponentTestModel<TContext, TController, TInputs>>)(object)new Func<IBaseReactComponentTestModel<_003F, _003F, IBaseReactComponentTestModel<TContext, TController, TInputs>>>(CreateTestModel);

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

	public sealed override void RunScenario(string name, params IStep[] steps)
	{
		if (steps.Length != 0)
		{
			((System.Array)steps).Unshift(new object[1] { Setup() });
		}
		base.RunScenario(name, steps);
	}

	private IBaseReactComponentTestModel<TContext, TController, TInputs> CreateTestModel()
	{
		ITestComponentCreatorService testComponentCreatorService = ((IComponentTest)this).TestComponentCreatorService;
		viewModel = (IViewModel)testComponentCreatorService.CreateBaseReactComponent(ComponentType, typeof(TInputs), typeof(TContext), typeof(TController));
		model = new BaseReactComponentTestModel<TContext, TController, TInputs>(viewModel.Context, viewModel.Controller, viewModel.InputModel.Inputs);
		return model;
	}

	private IStep Setup()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		return new Step((Action)delegate
		{
			TriggerLifeCycleMethods();
		}, ComponentType.get_Name(), StepType.GIVEN);
	}

	private void TriggerLifeCycleMethods()
	{
		if (model.Controller is IOnInit)
		{
			object thisController = model.Controller;
			MethodInfo method = typeof(IOnInit).GetMethod("OnInit");
			ViewModelHelper.CallControllerMethod((IController)thisController, (method != null) ? method.get_ScriptName() : null, null);
		}
		if (model.Controller is IOnLoad)
		{
			object thisController2 = model.Controller;
			MethodInfo method2 = typeof(IOnLoad).GetMethod("OnLoad");
			ViewModelHelper.CallControllerMethod((IController)thisController2, (method2 != null) ? method2.get_ScriptName() : null, null);
		}
		if (model.Controller is IOnLoadAsync)
		{
			object thisController3 = model.Controller;
			MethodInfo method3 = typeof(IOnLoadAsync).GetMethod("OnLoadAsync");
			((System.Threading.Tasks.Task)ViewModelHelper.CallControllerMethod((IController)thisController3, (method3 != null) ? method3.get_ScriptName() : null, null)).Wait();
		}
	}

	private void _003CSetup_003Eb__12_0()
	{
		TriggerLifeCycleMethods();
	}
}
