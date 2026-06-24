using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Scripts;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.UI.Metadata;
using EleWise.ELMA.Core.Diagnostics;
using EleWise.ELMA.Core.Model.Managers;
using EleWise.ELMA.DTO;
using EleWise.ELMA.Model.Metadata.DTO.Managers;
using EleWise.ELMA.Scripts.Models;

namespace EleWise.ELMA.Model.Scripts;

internal sealed class MethodsService : IMethodsService
{
	private sealed class _003C_003Ec__DisplayClass4_0
	{
		public Guid metadataUid;

		internal bool _003C_002Ector_003Eb__0(ScriptModuleWrapper wrapper)
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			if (wrapper.get_CodeType() == 1)
			{
				return wrapper.get_MetadataUid() == metadataUid;
			}
			return false;
		}

		internal bool _003C_002Ector_003Eb__1(ScriptModuleWrapper wrapper)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			if (wrapper.get_CodeType() == 0)
			{
				return wrapper.get_MetadataUid() == metadataUid;
			}
			return false;
		}

		internal bool _003C_002Ector_003Eb__2(ScriptModuleWrapper wrapper)
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			if (wrapper.get_CodeType() == 2)
			{
				return wrapper.get_MetadataUid() == metadataUid;
			}
			return false;
		}
	}

	[StructLayout(3)]
	private struct _003CGetScriptMethodWrappers_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<ScriptMethodInfoWrapper>> _003C_003Et__builder;

		public CodeType[] enableCodeTypes;

		public MethodsService _003C_003E4__this;

		private EnumerableInstance<ScriptMethodInfoWrapper> _003Cresult_003E5__2;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c3: Expected O, but got Unknown
			int num = _003C_003E1__state;
			MethodsService methodsService = _003C_003E4__this;
			System.Collections.Generic.IEnumerable<ScriptMethodInfoWrapper> result;
			try
			{
				TaskAwaiter val;
				if (num != 0)
				{
					_003Cresult_003E5__2 = Enumerable.Empty<ScriptMethodInfoWrapper>();
					if (ArrayExtensions.Contains<CodeType>(enableCodeTypes, CodeType.Server))
					{
						methodsService.InitServer();
						_003Cresult_003E5__2 = _003Cresult_003E5__2.Concat((System.Collections.Generic.IEnumerable<ScriptMethodInfoWrapper>)methodsService.serverMethodInfoWrappers);
					}
					if (ArrayExtensions.Contains<CodeType>(enableCodeTypes, CodeType.Client))
					{
						methodsService.InitClient();
						_003Cresult_003E5__2 = _003Cresult_003E5__2.Concat((System.Collections.Generic.IEnumerable<ScriptMethodInfoWrapper>)methodsService.clientMethodInfoWrappers);
					}
					if (!ArrayExtensions.Contains<CodeType>(enableCodeTypes, CodeType.GlobalFunction))
					{
						goto IL_00f0;
					}
					val = methodsService.InitGlobalScripts().GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val;
						_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter, _003CGetScriptMethodWrappers_003Ed__6>(ref val, ref this);
						return;
					}
				}
				else
				{
					val = (TaskAwaiter)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
				}
				val.GetResult();
				_003Cresult_003E5__2 = _003Cresult_003E5__2.Concat((System.Collections.Generic.IEnumerable<ScriptMethodInfoWrapper>)methodsService.globalMethodInfoWrappers);
				goto IL_00f0;
				IL_00f0:
				result = (System.Collections.Generic.IEnumerable<ScriptMethodInfoWrapper>)_003Cresult_003E5__2;
			}
			catch (System.Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult(result);
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(3)]
	private struct _003CGetGlobalScriptMethods_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<ScriptMethodDeclaration>> _003C_003Et__builder;

		public MethodsService _003C_003E4__this;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Expected O, but got Unknown
			int num = _003C_003E1__state;
			MethodsService methodsService = _003C_003E4__this;
			System.Collections.Generic.IEnumerable<ScriptMethodDeclaration> globalMethodInfos;
			try
			{
				TaskAwaiter val;
				if (num != 0)
				{
					val = methodsService.InitGlobalScripts().GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val;
						_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter, _003CGetGlobalScriptMethods_003Ed__7>(ref val, ref this);
						return;
					}
				}
				else
				{
					val = (TaskAwaiter)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
				}
				val.GetResult();
				globalMethodInfos = (System.Collections.Generic.IEnumerable<ScriptMethodDeclaration>)methodsService.globalMethodInfos;
			}
			catch (System.Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult(globalMethodInfos);
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}
	}

	private sealed class _003C_003Ec__DisplayClass12_0
	{
		public string methodName;

		public Guid metadataUid;

		internal bool _003CMethodExists_003Eb__0(ScriptMethodInfoWrapper a)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			if (a.Name == methodName)
			{
				return a.MetadataUid == metadataUid;
			}
			return false;
		}

		internal bool _003CMethodExists_003Eb__1(ScriptMethodInfoWrapper a)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			if (a.Name == methodName)
			{
				return a.MetadataUid == metadataUid;
			}
			return false;
		}
	}

	[StructLayout(3)]
	private struct _003CAddMethod_003Ed__13 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ScriptMethodInfoWrapper> _003C_003Et__builder;

		public CodeType[] enableCodeTypes;

		public MethodsService _003C_003E4__this;

		public ScriptMethodDeclaration method;

		public CodeType codeType;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			//IL_008b: Expected O, but got Unknown
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			MethodsService methodsService = _003C_003E4__this;
			ScriptMethodInfoWrapper result;
			try
			{
				TaskAwaiter val;
				if (num != 0)
				{
					if (ArrayExtensions.Contains<CodeType>(enableCodeTypes, CodeType.Server))
					{
						methodsService.InitServer();
					}
					if (ArrayExtensions.Contains<CodeType>(enableCodeTypes, CodeType.Client))
					{
						methodsService.InitClient();
					}
					if (!ArrayExtensions.Contains<CodeType>(enableCodeTypes, CodeType.GlobalFunction))
					{
						goto IL_00a2;
					}
					val = methodsService.InitGlobalScripts().GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val;
						_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter, _003CAddMethod_003Ed__13>(ref val, ref this);
						return;
					}
				}
				else
				{
					val = (TaskAwaiter)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
				}
				val.GetResult();
				goto IL_00a2;
				IL_00a2:
				Guid metadataUid = GetMetadataUid(methodsService.currentPageService.CurrentPageViewModel.Metadata);
				result = methodsService.AddMethod(method, codeType, metadataUid, addToScriptModule: true);
			}
			catch (System.Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult(result);
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(3)]
	private struct _003CInitGlobalScripts_003Ed__29 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MethodsService _003C_003E4__this;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			MethodsService methodsService = _003C_003E4__this;
			try
			{
				TaskAwaiter<System.Collections.Generic.IEnumerable<ValueTuple<ScriptMethodDeclaration, ScriptMethodInfoWrapper>>> val;
				if (num == 0)
				{
					val = (TaskAwaiter<System.Collections.Generic.IEnumerable<ValueTuple<ScriptMethodDeclaration, ScriptMethodInfoWrapper>>>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_00ac;
				}
				if (methodsService.functionMetadataItemManager != null && !methodsService.globalMethodsInited)
				{
					methodsService.globalMethodInfoWrappers = new ScriptMethodInfoWrapper[0];
					Guid moduleUid = methodsService.currentPageService.CurrentPageViewModel?.ModuleUid ?? Guid.Empty;
					val = methodsService.functionMetadataItemManager.GetMethods(moduleUid).GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter<System.Collections.Generic.IEnumerable<ValueTuple<ScriptMethodDeclaration, ScriptMethodInfoWrapper>>>, _003CInitGlobalScripts_003Ed__29>(ref val, ref this);
						return;
					}
					goto IL_00ac;
				}
				goto end_IL_000e;
				IL_00ac:
				System.Collections.Generic.IEnumerator<ValueTuple<ScriptMethodDeclaration, ScriptMethodInfoWrapper>> enumerator = val.GetResult().GetEnumerator();
				try
				{
					while (((System.Collections.IEnumerator)enumerator).MoveNext())
					{
						ValueTuple<ScriptMethodDeclaration, ScriptMethodInfoWrapper> current = enumerator.get_Current();
						ScriptMethodDeclaration item = current.Item1;
						ScriptMethodInfoWrapper item2 = current.Item2;
						methodsService.globalMethodInfos.Add(item);
						ArrayExtensions.Push<ScriptMethodInfoWrapper>(methodsService.globalMethodInfoWrappers, new ScriptMethodInfoWrapper[1] { item2 });
					}
				}
				finally
				{
					if (num < 0)
					{
						((System.IDisposable)enumerator)?.Dispose();
					}
				}
				methodsService.globalMethodsInited = true;
				end_IL_000e:;
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

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<PropertyMetadata, bool> _003C_003E9__31_0;

		internal bool _003CGetMetadataUid_003Eb__31_0(PropertyMetadata property)
		{
			return ((INamedMetadata)property).get_Name() == "Model";
		}
	}

	private readonly ICurrentPageService currentPageService;

	private readonly System.Collections.Generic.ICollection<ScriptModuleWrapper> wrappers;

	private readonly FunctionMetadataItemManager functionMetadataItemManager;

	private readonly System.Collections.Generic.ICollection<ScriptMethodDeclaration> serverMethodInfos = (System.Collections.Generic.ICollection<ScriptMethodDeclaration>)new List<ScriptMethodDeclaration>();

	private readonly System.Collections.Generic.ICollection<ScriptMethodDeclaration> clientMethodInfos = (System.Collections.Generic.ICollection<ScriptMethodDeclaration>)new List<ScriptMethodDeclaration>();

	private readonly System.Collections.Generic.ICollection<ScriptMethodDeclaration> globalMethodInfos = (System.Collections.Generic.ICollection<ScriptMethodDeclaration>)new List<ScriptMethodDeclaration>();

	private ScriptMethodInfoWrapper[] globalMethodInfoWrappers = new ScriptMethodInfoWrapper[0];

	private ScriptMethodInfoWrapper[] serverMethodInfoWrappers = new ScriptMethodInfoWrapper[0];

	private ScriptMethodInfoWrapper[] clientMethodInfoWrappers = new ScriptMethodInfoWrapper[0];

	private bool serverMethodsInited;

	private bool clientMethodsInited;

	private bool globalMethodsInited;

	private ScriptModule CurrentServerScriptModule => currentPageService.CurrentPageViewModel.ServerScriptModule;

	private ScriptModule CurrentClientScriptModule => currentPageService.CurrentPageViewModel.ClientScriptModule;

	public MethodsService(ICurrentPageService currentPageService, FunctionMetadataItemManager functionMetadataItemManager)
	{
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		Contract.ArgumentNotNull(currentPageService, "currentPageService");
		this.currentPageService = currentPageService;
		this.functionMetadataItemManager = functionMetadataItemManager;
		Guid metadataUid = GetMetadataUid(currentPageService.CurrentPageViewModel.Metadata);
		ScriptModuleWrapper val = InterfaceCreator.Create<ScriptModuleWrapper>();
		val.set_ScriptModule(currentPageService.CurrentPageViewModel.ServerScriptModule);
		val.set_CodeType(1);
		val.set_MetadataUid(metadataUid);
		ScriptModuleWrapper val2 = InterfaceCreator.Create<ScriptModuleWrapper>();
		val2.set_ScriptModule(currentPageService.CurrentPageViewModel.ClientScriptModule);
		val2.set_CodeType(0);
		val2.set_MetadataUid(metadataUid);
		List<ScriptModuleWrapper> obj = new List<ScriptModuleWrapper>();
		obj.Add(val);
		obj.Add(val2);
		wrappers = (System.Collections.Generic.ICollection<ScriptModuleWrapper>)obj;
	}

	public MethodsService(ICurrentPageService currentPageService, FunctionMetadataItemManager functionMetadataItemManager, System.Collections.Generic.ICollection<ScriptModuleWrapper> wrappers)
	{
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		_003C_003Ec__DisplayClass4_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass4_0();
		Contract.ArgumentNotNull(currentPageService, "currentPageService");
		this.currentPageService = currentPageService;
		this.wrappers = wrappers;
		this.functionMetadataItemManager = functionMetadataItemManager;
		CS_0024_003C_003E8__locals0.metadataUid = GetMetadataUid(currentPageService.CurrentPageViewModel.Metadata);
		if (currentPageService.CurrentPageViewModel.Metadata is FormContextMetadata)
		{
			ScriptModuleWrapper obj = Enumerable.FirstOrDefault<ScriptModuleWrapper>((System.Collections.Generic.IEnumerable<ScriptModuleWrapper>)wrappers);
			CS_0024_003C_003E8__locals0.metadataUid = ((obj != null) ? obj.get_MetadataUid() : Guid.Empty);
		}
		ScriptModuleWrapper val = Enumerable.FirstOrDefault<ScriptModuleWrapper>((System.Collections.Generic.IEnumerable<ScriptModuleWrapper>)wrappers, (Func<ScriptModuleWrapper, bool>)((ScriptModuleWrapper wrapper) => wrapper.get_CodeType() == 1 && wrapper.get_MetadataUid() == CS_0024_003C_003E8__locals0.metadataUid));
		if (val != null)
		{
			currentPageService.CurrentPageViewModel.ServerScriptModule = val.get_ScriptModule();
		}
		ScriptModuleWrapper val2 = Enumerable.FirstOrDefault<ScriptModuleWrapper>((System.Collections.Generic.IEnumerable<ScriptModuleWrapper>)wrappers, (Func<ScriptModuleWrapper, bool>)((ScriptModuleWrapper wrapper) => wrapper.get_CodeType() == 0 && wrapper.get_MetadataUid() == CS_0024_003C_003E8__locals0.metadataUid));
		if (val2 != null)
		{
			currentPageService.CurrentPageViewModel.ClientScriptModule = val2.get_ScriptModule();
		}
		ScriptModuleWrapper val3 = Enumerable.FirstOrDefault<ScriptModuleWrapper>((System.Collections.Generic.IEnumerable<ScriptModuleWrapper>)wrappers, (Func<ScriptModuleWrapper, bool>)((ScriptModuleWrapper wrapper) => wrapper.get_CodeType() == 2 && wrapper.get_MetadataUid() == CS_0024_003C_003E8__locals0.metadataUid));
		if (val3 != null)
		{
			currentPageService.CurrentPageViewModel.TestScriptModule = val3.get_ScriptModule();
		}
	}

	public System.Collections.Generic.IEnumerable<ScriptMethodInfoWrapper> GetClientScriptMethodWrappers()
	{
		InitClient();
		return clientMethodInfoWrappers;
	}

	public System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<ScriptMethodInfoWrapper>> GetScriptMethodWrappers(CodeType[] enableCodeTypes)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003CGetScriptMethodWrappers_003Ed__6 _003CGetScriptMethodWrappers_003Ed__ = default(_003CGetScriptMethodWrappers_003Ed__6);
		_003CGetScriptMethodWrappers_003Ed__._003C_003E4__this = this;
		_003CGetScriptMethodWrappers_003Ed__.enableCodeTypes = enableCodeTypes;
		_003CGetScriptMethodWrappers_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<ScriptMethodInfoWrapper>>.Create();
		_003CGetScriptMethodWrappers_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<ScriptMethodInfoWrapper>> _003C_003Et__builder = _003CGetScriptMethodWrappers_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CGetScriptMethodWrappers_003Ed__6>(ref _003CGetScriptMethodWrappers_003Ed__);
		return _003CGetScriptMethodWrappers_003Ed__._003C_003Et__builder.get_Task();
	}

	public System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<ScriptMethodDeclaration>> GetGlobalScriptMethods()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		_003CGetGlobalScriptMethods_003Ed__7 _003CGetGlobalScriptMethods_003Ed__ = default(_003CGetGlobalScriptMethods_003Ed__7);
		_003CGetGlobalScriptMethods_003Ed__._003C_003E4__this = this;
		_003CGetGlobalScriptMethods_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<ScriptMethodDeclaration>>.Create();
		_003CGetGlobalScriptMethods_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<ScriptMethodDeclaration>> _003C_003Et__builder = _003CGetGlobalScriptMethods_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CGetGlobalScriptMethods_003Ed__7>(ref _003CGetGlobalScriptMethods_003Ed__);
		return _003CGetGlobalScriptMethods_003Ed__._003C_003Et__builder.get_Task();
	}

	public System.Collections.Generic.IEnumerable<ScriptMethodDeclaration> GetServerScriptMethods()
	{
		InitServer();
		return (System.Collections.Generic.IEnumerable<ScriptMethodDeclaration>)serverMethodInfos;
	}

	public System.Collections.Generic.IEnumerable<ScriptMethodDeclaration> GetClientScriptMethods()
	{
		InitClient();
		return (System.Collections.Generic.IEnumerable<ScriptMethodDeclaration>)clientMethodInfos;
	}

	public void Refresh(CodeType codeType)
	{
		switch (codeType)
		{
		case CodeType.Server:
			serverMethodsInited = false;
			break;
		case CodeType.Client:
			clientMethodsInited = false;
			break;
		case CodeType.GlobalFunction:
			globalMethodsInited = false;
			break;
		case CodeType.Test:
			break;
		}
	}

	public bool MethodExists(string methodName, CodeType codeType)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		Guid metadataUid = GetMetadataUid(currentPageService.GetCurrentMetadata());
		return MethodExists(methodName, codeType, metadataUid);
	}

	public bool MethodExists(string methodName, CodeType codeType, Guid metadataUid)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		_003C_003Ec__DisplayClass12_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass12_0();
		CS_0024_003C_003E8__locals0.methodName = methodName;
		CS_0024_003C_003E8__locals0.metadataUid = metadataUid;
		switch (codeType)
		{
		case CodeType.Server:
			InitServer();
			return Enumerable.FirstOrDefault<ScriptMethodInfoWrapper>((System.Collections.Generic.IEnumerable<ScriptMethodInfoWrapper>)serverMethodInfoWrappers, (Func<ScriptMethodInfoWrapper, bool>)((ScriptMethodInfoWrapper a) => a.Name == CS_0024_003C_003E8__locals0.methodName && a.MetadataUid == CS_0024_003C_003E8__locals0.metadataUid)) != null;
		case CodeType.Client:
			InitClient();
			return Enumerable.FirstOrDefault<ScriptMethodInfoWrapper>((System.Collections.Generic.IEnumerable<ScriptMethodInfoWrapper>)clientMethodInfoWrappers, (Func<ScriptMethodInfoWrapper, bool>)((ScriptMethodInfoWrapper a) => a.Name == CS_0024_003C_003E8__locals0.methodName && a.MetadataUid == CS_0024_003C_003E8__locals0.metadataUid)) != null;
		default:
			return false;
		}
	}

	public System.Threading.Tasks.Task<ScriptMethodInfoWrapper> AddMethod(ScriptMethodDeclaration method, CodeType codeType, CodeType[] enableCodeTypes)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		_003CAddMethod_003Ed__13 _003CAddMethod_003Ed__ = default(_003CAddMethod_003Ed__13);
		_003CAddMethod_003Ed__._003C_003E4__this = this;
		_003CAddMethod_003Ed__.method = method;
		_003CAddMethod_003Ed__.codeType = codeType;
		_003CAddMethod_003Ed__.enableCodeTypes = enableCodeTypes;
		_003CAddMethod_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<ScriptMethodInfoWrapper>.Create();
		_003CAddMethod_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<ScriptMethodInfoWrapper> _003C_003Et__builder = _003CAddMethod_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CAddMethod_003Ed__13>(ref _003CAddMethod_003Ed__);
		return _003CAddMethod_003Ed__._003C_003Et__builder.get_Task();
	}

	private void InitServer()
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (wrappers == null || wrappers.get_Count() == 0 || serverMethodsInited)
		{
			return;
		}
		serverMethodInfoWrappers = new ScriptMethodInfoWrapper[0];
		System.Collections.Generic.IEnumerator<ScriptModuleWrapper> enumerator = ((System.Collections.Generic.IEnumerable<ScriptModuleWrapper>)wrappers).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				ScriptModuleWrapper current = enumerator.get_Current();
				if (current.get_CodeType() != 1)
				{
					continue;
				}
				System.Collections.Generic.IEnumerator<ScriptMethodDeclaration> enumerator2 = ((System.Collections.Generic.IEnumerable<ScriptMethodDeclaration>)current.get_ScriptModule().get_ScriptMethods()).GetEnumerator();
				try
				{
					while (((System.Collections.IEnumerator)enumerator2).MoveNext())
					{
						ScriptMethodDeclaration current2 = enumerator2.get_Current();
						AddMethod(current2, CodeType.Server, current.get_MetadataUid());
					}
				}
				finally
				{
					((System.IDisposable)enumerator2)?.Dispose();
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		serverMethodsInited = true;
	}

	private void InitClient()
	{
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		if (wrappers == null || wrappers.get_Count() == 0 || clientMethodsInited)
		{
			return;
		}
		clientMethodInfoWrappers = new ScriptMethodInfoWrapper[0];
		System.Collections.Generic.IEnumerator<ScriptModuleWrapper> enumerator = ((System.Collections.Generic.IEnumerable<ScriptModuleWrapper>)wrappers).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				ScriptModuleWrapper current = enumerator.get_Current();
				if (current.get_CodeType() != 0)
				{
					continue;
				}
				System.Collections.Generic.IEnumerator<ScriptMethodDeclaration> enumerator2 = ((System.Collections.Generic.IEnumerable<ScriptMethodDeclaration>)current.get_ScriptModule().get_ScriptMethods()).GetEnumerator();
				try
				{
					while (((System.Collections.IEnumerator)enumerator2).MoveNext())
					{
						ScriptMethodDeclaration current2 = enumerator2.get_Current();
						AddMethod(current2, CodeType.Client, current.get_MetadataUid());
					}
				}
				finally
				{
					((System.IDisposable)enumerator2)?.Dispose();
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		clientMethodsInited = true;
	}

	private System.Threading.Tasks.Task InitGlobalScripts()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		_003CInitGlobalScripts_003Ed__29 _003CInitGlobalScripts_003Ed__ = default(_003CInitGlobalScripts_003Ed__29);
		_003CInitGlobalScripts_003Ed__._003C_003E4__this = this;
		_003CInitGlobalScripts_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		_003CInitGlobalScripts_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder _003C_003Et__builder = _003CInitGlobalScripts_003Ed__._003C_003Et__builder;
		((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).Start<_003CInitGlobalScripts_003Ed__29>(ref _003CInitGlobalScripts_003Ed__);
		return ((AsyncTaskMethodBuilder)(ref _003CInitGlobalScripts_003Ed__._003C_003Et__builder)).get_Task();
	}

	private ScriptMethodInfoWrapper AddMethod(ScriptMethodDeclaration method, CodeType codeType, Guid metadataUid, bool addToScriptModule = false)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		switch (codeType)
		{
		case CodeType.Server:
		{
			ScriptMethodInfoWrapper scriptMethodInfoWrapper2 = new ScriptMethodInfoWrapper(method.get_Name(), method.get_DisplayInfo(), codeType, metadataUid);
			serverMethodInfos.Add(method);
			ArrayExtensions.Push<ScriptMethodInfoWrapper>(serverMethodInfoWrappers, new ScriptMethodInfoWrapper[1] { scriptMethodInfoWrapper2 });
			if (addToScriptModule)
			{
				CurrentServerScriptModule.get_ScriptMethods().Add(method);
			}
			return scriptMethodInfoWrapper2;
		}
		case CodeType.Client:
		{
			ScriptMethodInfoWrapper scriptMethodInfoWrapper = new ScriptMethodInfoWrapper(method.get_Name(), method.get_DisplayInfo(), codeType, metadataUid);
			clientMethodInfos.Add(method);
			ArrayExtensions.Push<ScriptMethodInfoWrapper>(clientMethodInfoWrappers, new ScriptMethodInfoWrapper[1] { scriptMethodInfoWrapper });
			if (addToScriptModule)
			{
				CurrentClientScriptModule.get_ScriptMethods().Add(method);
			}
			return scriptMethodInfoWrapper;
		}
		default:
			return null;
		}
	}

	internal static Guid GetMetadataUid(IMetadata metadata)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		DataClassMetadata val;
		if ((val = (DataClassMetadata)(object)((metadata is DataClassMetadata) ? metadata : null)) != null && ((INamedMetadata)val).get_Name() == "ViewModelContext")
		{
			if (((ICodeItemMetadata)val).get_Namespace() == "EleWise.ELMA.Model.Entities.ProcessContext")
			{
				return ((IMetadata)val).get_Uid();
			}
			PropertyMetadata obj = Enumerable.FirstOrDefault<PropertyMetadata>((System.Collections.Generic.IEnumerable<PropertyMetadata>)((ClassMetadata)val).get_Properties(), (Func<PropertyMetadata, bool>)((PropertyMetadata property) => ((INamedMetadata)property).get_Name() == "Model"));
			if (obj == null)
			{
				return metadata.get_Uid();
			}
			return ((IPropertyMetadata)obj).get_SubTypeUid();
		}
		return metadata.get_Uid();
	}
}
