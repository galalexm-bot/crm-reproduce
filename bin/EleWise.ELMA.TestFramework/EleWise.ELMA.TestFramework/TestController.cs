using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Bridge;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.UI.Models;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Model.Managers;
using EleWise.ELMA.Core.Services;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Scripts;
using EleWise.ELMA.Services;
using EleWise.ELMA.TestFramework.Core;
using EleWise.ELMA.TestFramework.Notification;
using EleWise.ELMA.TestFramework.Services;
using EleWise.ELMA.UI.Managers;

namespace EleWise.ELMA.TestFramework;

[Service]
internal sealed class TestController : ITestController
{
	[StructLayout(3)]
	private struct _003CLoadComponentTests_003Ed__19 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ComponentTestFixtureTree> _003C_003Et__builder;

		public TestController _003C_003E4__this;

		private int _003CcomponentCount_003E5__2;

		private int _003CtotalTestCount_003E5__3;

		private int _003CtestComponentCount_003E5__4;

		private List<ComponentTestFixture> _003CcomponentTests_003E5__5;

		private object _003C_003Eu__1;

		private System.Collections.Generic.IEnumerator<ComponentMetadataItemHeader> _003C_003E7__wrap5;

		private ComponentMetadataItemHeader _003CcomponentHeader_003E5__7;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			TestController testController = _003C_003E4__this;
			ComponentTestFixtureTree result3;
			try
			{
				TaskAwaiter<System.Collections.Generic.IEnumerable<ComponentMetadataItemHeader>> val;
				if (num != 0)
				{
					if (num == 1)
					{
						goto IL_00ad;
					}
					val = testController.ComponentMetadataItemManager.GetAllHeaders().GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val;
						_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<System.Collections.Generic.IEnumerable<ComponentMetadataItemHeader>>, _003CLoadComponentTests_003Ed__19>(ref val, ref this);
						return;
					}
				}
				else
				{
					val = (TaskAwaiter<System.Collections.Generic.IEnumerable<ComponentMetadataItemHeader>>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
				}
				System.Collections.Generic.IEnumerable<ComponentMetadataItemHeader> result = val.GetResult();
				_003CcomponentCount_003E5__2 = Enumerable.Count<ComponentMetadataItemHeader>(result);
				_003CtotalTestCount_003E5__3 = 0;
				_003CtestComponentCount_003E5__4 = 0;
				_003CcomponentTests_003E5__5 = new List<ComponentTestFixture>();
				_003C_003E7__wrap5 = result.GetEnumerator();
				goto IL_00ad;
				IL_00ad:
				try
				{
					if (num != 1)
					{
						goto IL_01aa;
					}
					TaskAwaiter<System.Type> val2 = (TaskAwaiter<System.Type>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_012b;
					IL_01aa:
					if (((System.Collections.IEnumerator)_003C_003E7__wrap5).MoveNext())
					{
						_003CcomponentHeader_003E5__7 = _003C_003E7__wrap5.get_Current();
						new ComponentTestFixture();
						val2 = testController.GetType(_003CcomponentHeader_003E5__7).GetAwaiter();
						if (!val2.get_IsCompleted())
						{
							num = (_003C_003E1__state = 1);
							_003C_003Eu__1 = val2;
							_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<System.Type>, _003CLoadComponentTests_003Ed__19>(ref val2, ref this);
							return;
						}
						goto IL_012b;
					}
					goto end_IL_00ae;
					IL_012b:
					System.Type result2 = val2.GetResult();
					if (result2 != null)
					{
						TestFixture testFixture = new TestFixture(result2, _003CcomponentHeader_003E5__7.get_DisplayName());
						int num2 = Enumerable.Count<ITestMethod>(testFixture.Tests);
						if (num2 != 0)
						{
							_003CtestComponentCount_003E5__4++;
							_003CtotalTestCount_003E5__3 += num2;
							_003CcomponentTests_003E5__5.Add(new ComponentTestFixture
							{
								Header = _003CcomponentHeader_003E5__7,
								TestFixture = testFixture
							});
							_003CcomponentHeader_003E5__7 = null;
						}
					}
					goto IL_01aa;
					end_IL_00ae:;
				}
				finally
				{
					if (num < 0 && _003C_003E7__wrap5 != null)
					{
						((System.IDisposable)_003C_003E7__wrap5).Dispose();
					}
				}
				_003C_003E7__wrap5 = null;
				ComponentTestFixtureTree obj = new ComponentTestFixtureTree
				{
					ComponentCount = _003CcomponentCount_003E5__2,
					TestComponentCount = _003CtestComponentCount_003E5__4,
					TotalTestsCount = _003CtotalTestCount_003E5__3,
					TestModules = (System.Collections.Generic.ICollection<ComponentTestFixture>)_003CcomponentTests_003E5__5
				};
				testController.LoadedTests = _003CcomponentTests_003E5__5;
				result3 = obj;
			}
			catch (System.Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult(result3);
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}
	}

	private sealed class _003C_003Ec__DisplayClass20_0
	{
		[StructLayout(3)]
		private struct _003C_003CRunComponentTests_003Eb__0_003Ed : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public _003C_003Ec__DisplayClass20_0 _003C_003E4__this;

			private object _003C_003Eu__1;

			private void MoveNext()
			{
				//IL_002e: Unknown result type (might be due to invalid IL or missing references)
				//IL_003e: Unknown result type (might be due to invalid IL or missing references)
				//IL_004e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0090: Unknown result type (might be due to invalid IL or missing references)
				//IL_0096: Expected O, but got Unknown
				int num = _003C_003E1__state;
				_003C_003Ec__DisplayClass20_0 _003C_003Ec__DisplayClass20_ = _003C_003E4__this;
				try
				{
					TaskAwaiter<System.Type> val;
					TaskAwaiter val2;
					if (num != 0)
					{
						if (num == 1)
						{
							val = (TaskAwaiter<System.Type>)_003C_003Eu__1;
							_003C_003Eu__1 = null;
							num = (_003C_003E1__state = -1);
							goto IL_0110;
						}
						val2 = _003C_003Ec__DisplayClass20_._003C_003E4__this.currentPageService.SetCurrentPageUidAsync(_003C_003Ec__DisplayClass20_.componentTest.Header.get_ModuleUid(), _003C_003Ec__DisplayClass20_.componentTest.Header.get_Uid(), _003C_003Ec__DisplayClass20_.componentTest.Header.get_MetadataTypeUid(), InterfaceBuilderViewMode.Emulation).GetAwaiter();
						if (!val2.get_IsCompleted())
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = val2;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter, _003C_003CRunComponentTests_003Eb__0_003Ed>(ref val2, ref this);
							return;
						}
					}
					else
					{
						val2 = (TaskAwaiter)_003C_003Eu__1;
						_003C_003Eu__1 = null;
						num = (_003C_003E1__state = -1);
					}
					val2.GetResult();
					val = _003C_003Ec__DisplayClass20_._003C_003E4__this.GetType(_003C_003Ec__DisplayClass20_.componentTest.Header).GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 1);
						_003C_003Eu__1 = val;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter<System.Type>, _003C_003CRunComponentTests_003Eb__0_003Ed>(ref val, ref this);
						return;
					}
					goto IL_0110;
					IL_0110:
					System.Type result = val.GetResult();
					_003C_003Ec__DisplayClass20_.componentTest.TestFixture.Instance = _003C_003Ec__DisplayClass20_._003C_003E4__this.testFactory.CreateTest(result);
				}
				catch (System.Exception exception)
				{
					_003C_003E1__state = -2;
					((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).SetException(exception);
					return;
				}
				_003C_003E1__state = -2;
				((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).SetResult();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).SetStateMachine(stateMachine);
			}
		}

		public ComponentTestFixture componentTest;

		public TestController _003C_003E4__this;

		internal System.Threading.Tasks.Task _003CRunComponentTests_003Eb__0()
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			_003C_003CRunComponentTests_003Eb__0_003Ed _003C_003CRunComponentTests_003Eb__0_003Ed = default(_003C_003CRunComponentTests_003Eb__0_003Ed);
			_003C_003CRunComponentTests_003Eb__0_003Ed._003C_003E4__this = this;
			_003C_003CRunComponentTests_003Eb__0_003Ed._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
			_003C_003CRunComponentTests_003Eb__0_003Ed._003C_003E1__state = -1;
			AsyncTaskMethodBuilder _003C_003Et__builder = _003C_003CRunComponentTests_003Eb__0_003Ed._003C_003Et__builder;
			((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).Start<_003C_003CRunComponentTests_003Eb__0_003Ed>(ref _003C_003CRunComponentTests_003Eb__0_003Ed);
			return ((AsyncTaskMethodBuilder)(ref _003C_003CRunComponentTests_003Eb__0_003Ed._003C_003Et__builder)).get_Task();
		}
	}

	[StructLayout(3)]
	private struct _003CGetType_003Ed__22 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<System.Type> _003C_003Et__builder;

		public TestController _003C_003E4__this;

		public ComponentMetadataItemHeader componentHeader;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			TestController testController = _003C_003E4__this;
			System.Type result2;
			try
			{
				TaskAwaiter<RenderComponentModel> val;
				if (num != 0)
				{
					val = testController.findComponentService.FindComponent(componentHeader.get_Uid(), InterfaceBuilderViewMode.Emulation).GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val;
						_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<RenderComponentModel>, _003CGetType_003Ed__22>(ref val, ref this);
						return;
					}
				}
				else
				{
					val = (TaskAwaiter<RenderComponentModel>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
				}
				RenderComponentModel result = val.GetResult();
				if (result == null)
				{
					result2 = null;
				}
				else
				{
					ComponentMetadataItem val2 = testController.ComponentMetadataItemManager.LoadOrNull(result.Header.get_ItemUid());
					if (val2 == null)
					{
						result2 = null;
					}
					else
					{
						string assemblyName = val2.get_ClientScriptModule().get_AssemblyName();
						object obj = testController.scriptLoaderService.LoadModule(assemblyName);
						if (obj == null)
						{
							result2 = null;
						}
						else
						{
							System.Type typeFromModule = ((ICodeItemMetadata)(object)val2.get_Metadata()).GetTypeFromModule(obj);
							result2 = ((typeFromModule != null) ? Script.Write<System.Type>("{0}[{1}]", new object[2] { typeFromModule, "ComponentTests" }) : null);
						}
					}
				}
			}
			catch (System.Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult(result2);
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}
	}

	private const string ComponentTestsKey = "ComponentTests";

	private readonly ITestRunner testRunner;

	private readonly ICurrentPageService currentPageService;

	private readonly IScriptLoaderService scriptLoaderService;

	private readonly ITestAssemblyBuilder testBuilder;

	private readonly ComponentMetadataItemManager ComponentMetadataItemManager;

	private readonly FindComponentService findComponentService;

	private readonly INotificationService notificationService;

	private readonly ITestFactory testFactory;

	private static TestConfig _003CFrameworkConfig_003Ek__BackingField;

	private List<ComponentTestFixture> _003CLoadedTests_003Ek__BackingField;

	public static TestConfig FrameworkConfig
	{
		get
		{
			return _003CFrameworkConfig_003Ek__BackingField;
		}
		private set
		{
			_003CFrameworkConfig_003Ek__BackingField = value;
		}
	}

	public List<ComponentTestFixture> LoadedTests
	{
		get
		{
			return _003CLoadedTests_003Ek__BackingField;
		}
		private set
		{
			_003CLoadedTests_003Ek__BackingField = value;
		}
	}

	public TestController(ITestRunner testRunner, ICurrentPageService currentPageService, IScriptLoaderService scriptLoaderService, INotificationService notificationService, ComponentMetadataItemManager ComponentMetadataItemManager, FindComponentService findComponentService, ITestFactory testFactory)
	{
		this.currentPageService = currentPageService;
		this.testRunner = testRunner;
		this.scriptLoaderService = scriptLoaderService;
		this.notificationService = notificationService;
		this.ComponentMetadataItemManager = ComponentMetadataItemManager;
		this.findComponentService = findComponentService;
		this.testFactory = testFactory;
		testBuilder = new TestAssemblyBuilder();
		FrameworkConfig = new TestConfig();
	}

	public void RunComponentTests(Guid componentUid, ITestNotifier notifier)
	{
		CurrentPageModel currentPageViewModel = currentPageService.CurrentPageViewModel;
		string assemblyName = currentPageViewModel.ClientScriptModule.get_AssemblyName();
		object obj = scriptLoaderService.LoadModule(assemblyName);
		if (obj == null)
		{
			return;
		}
		IMetadata metadata = currentPageViewModel.Metadata;
		ICodeItemMetadata val = (ICodeItemMetadata)(object)((metadata is ICodeItemMetadata) ? metadata : null);
		if (val == null)
		{
			return;
		}
		System.Type typeFromModule = val.GetTypeFromModule(obj);
		if (typeFromModule == null)
		{
			return;
		}
		System.Type type = Script.Write<System.Type>("{0}[{1}]", new object[2] { typeFromModule, "ComponentTests" });
		if (type != null)
		{
			TestFixture testFixture = new TestFixture(type);
			if (!Enumerable.Any<ITestMethod>(testFixture.Tests))
			{
				notificationService.Warning(SR.T("Запуск тестов"), SR.T("Не найдены тесты для запуска"));
			}
			else
			{
				testRunner.Run(testFixture, notifier);
			}
		}
	}

	public System.Threading.Tasks.Task<ComponentTestFixtureTree> LoadComponentTests()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		_003CLoadComponentTests_003Ed__19 _003CLoadComponentTests_003Ed__ = default(_003CLoadComponentTests_003Ed__19);
		_003CLoadComponentTests_003Ed__._003C_003E4__this = this;
		_003CLoadComponentTests_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<ComponentTestFixtureTree>.Create();
		_003CLoadComponentTests_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<ComponentTestFixtureTree> _003C_003Et__builder = _003CLoadComponentTests_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CLoadComponentTests_003Ed__19>(ref _003CLoadComponentTests_003Ed__);
		return _003CLoadComponentTests_003Ed__._003C_003Et__builder.get_Task();
	}

	public System.Threading.Tasks.Task RunComponentTests(ITestNotifier testNotifier)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (LoadedTests == null)
		{
			throw new InvalidOperationException(SR.T("Тесты компонентов не были загружены"));
		}
		Enumerator<ComponentTestFixture> enumerator = LoadedTests.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				_003C_003Ec__DisplayClass20_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass20_0();
				CS_0024_003C_003E8__locals0._003C_003E4__this = this;
				CS_0024_003C_003E8__locals0.componentTest = enumerator.get_Current();
				testRunner.Run(CS_0024_003C_003E8__locals0.componentTest.TestFixture, testNotifier, delegate
				{
					//IL_000a: Unknown result type (might be due to invalid IL or missing references)
					//IL_000f: Unknown result type (might be due to invalid IL or missing references)
					//IL_001d: Unknown result type (might be due to invalid IL or missing references)
					//IL_0022: Unknown result type (might be due to invalid IL or missing references)
					_003C_003Ec__DisplayClass20_0._003C_003CRunComponentTests_003Eb__0_003Ed _003C_003CRunComponentTests_003Eb__0_003Ed = default(_003C_003Ec__DisplayClass20_0._003C_003CRunComponentTests_003Eb__0_003Ed);
					_003C_003CRunComponentTests_003Eb__0_003Ed._003C_003E4__this = CS_0024_003C_003E8__locals0;
					_003C_003CRunComponentTests_003Eb__0_003Ed._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
					_003C_003CRunComponentTests_003Eb__0_003Ed._003C_003E1__state = -1;
					AsyncTaskMethodBuilder _003C_003Et__builder = _003C_003CRunComponentTests_003Eb__0_003Ed._003C_003Et__builder;
					((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).Start<_003C_003Ec__DisplayClass20_0._003C_003CRunComponentTests_003Eb__0_003Ed>(ref _003C_003CRunComponentTests_003Eb__0_003Ed);
					return ((AsyncTaskMethodBuilder)(ref _003C_003CRunComponentTests_003Eb__0_003Ed._003C_003Et__builder)).get_Task();
				});
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		return System.Threading.Tasks.Task.get_CompletedTask();
	}

	public void RunTests()
	{
		System.Collections.Generic.IEnumerable<ITestAssembly> testAssemblies = testBuilder.Build(AppDomain.get_CurrentDomain().GetAssemblies());
		testRunner.Run(testAssemblies);
	}

	private System.Threading.Tasks.Task<System.Type> GetType(ComponentMetadataItemHeader componentHeader)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003CGetType_003Ed__22 _003CGetType_003Ed__ = default(_003CGetType_003Ed__22);
		_003CGetType_003Ed__._003C_003E4__this = this;
		_003CGetType_003Ed__.componentHeader = componentHeader;
		_003CGetType_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<System.Type>.Create();
		_003CGetType_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<System.Type> _003C_003Et__builder = _003CGetType_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CGetType_003Ed__22>(ref _003CGetType_003Ed__);
		return _003CGetType_003Ed__._003C_003Et__builder.get_Task();
	}
}
