using System;
using System.Reflection;
using System.Threading.Tasks;
using EleWise.ELMA.Core.Controllers;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.ViewModel;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.TestFramework.BDD;
using EleWise.ELMA.TestFramework.Services;

namespace EleWise.ELMA.TestFramework.API;

public abstract class BaseViewItemComponentTest<TViewItem, TInputs, TContext, TController> : Test<IBaseViewItemComponentTestModel<TViewItem, TInputs, TContext, TController>>, IComponentTest where TViewItem : IViewItem where TInputs : IInputs where TContext : IContext where TController : IController
{
	private IViewItemViewModel viewModel;

	private IBaseViewItemComponentTestModel<TViewItem, TInputs, TContext, TController> model;

	private ITestComponentCreatorService _003CEleWise_002EELMA_002ETestFramework_002EAPI_002EIComponentTest_002ETestComponentCreatorService_003Ek__BackingField;

	public abstract System.Type ComponentType { get; }

	protected override Func<IBaseViewItemComponentTestModel<TViewItem, TInputs, TContext, TController>> Model => (Func<IBaseViewItemComponentTestModel<TViewItem, TInputs, TContext, TController>>)(object)(Func<IBaseViewItemComponentTestModel<IBaseViewItemComponentTestModel<TViewItem, TInputs, TContext, TController>, _003F, _003F, _003F>>)(() => CreateTestModel());

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

	public override void RunScenario(string name, params IStep[] steps)
	{
		if (steps.Length != 0)
		{
			((System.Array)steps).Unshift(new object[1] { Setup() });
		}
		base.RunScenario(name, steps);
	}

	private IBaseViewItemComponentTestModel<TViewItem, TInputs, TContext, TController> CreateTestModel()
	{
		ITestComponentCreatorService testComponentCreatorService = ((IComponentTest)this).TestComponentCreatorService;
		viewModel = (IViewItemViewModel)testComponentCreatorService.CreateBaseViewItemComponent(ComponentType, typeof(TViewItem), typeof(TContext), typeof(TController));
		model = new BaseViewItemComponentTestModel<TViewItem, TInputs, TContext, TController>(viewModel.ViewItem, viewModel.InputModel.Inputs, viewModel.Context, viewModel.Controller);
		return model;
	}

	private IStep Setup()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		return new Step(new Action(TriggerLifeCycleMethods), ComponentType.get_Name(), StepType.GIVEN);
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

	private IBaseViewItemComponentTestModel<TViewItem, TInputs, TContext, TController> _003Cget_Model_003Eb__6_0()
	{
		return CreateTestModel();
	}
}
