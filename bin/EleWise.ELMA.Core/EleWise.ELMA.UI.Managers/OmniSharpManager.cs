using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using EleWise.ELMA.Api.Services;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Scripts;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Services;
using EleWise.ELMA.DTO;
using EleWise.ELMA.OmniSharp.Api.Models;
using EleWise.ELMA.OmniSharp.Model;
using EleWise.ELMA.Scripts.Models;

namespace EleWise.ELMA.UI.Managers;

[Service]
internal sealed class OmniSharpManager : IOmniSharpManager
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<ScriptModule, bool> _003C_003E9__5_0;

		public static Func<WebReferenceInfo, WebReferenceInfo> _003C_003E9__8_0;

		internal bool _003CInitWorkspace_003Eb__5_0(ScriptModule a)
		{
			return a != null;
		}

		internal WebReferenceInfo _003CAddReferences_003Eb__8_0(WebReferenceInfo i)
		{
			return new WebReferenceInfo
			{
				WebReferenceName = i.WebReferenceName,
				CodeFilePath = i.CodeFilePath
			};
		}
	}

	[StructLayout(3)]
	private struct _003CInitWorkspace_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CodeType codeType;

		public string methodName;

		public NamedMetadata metadata;

		public ScriptModule clientScriptModule;

		public ScriptModule viewScriptModule;

		public ScriptModule serverScriptModule;

		public ScriptModule testScriptModule;

		public OmniSharpManager _003C_003E4__this;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			OmniSharpManager omniSharpManager = _003C_003E4__this;
			try
			{
				try
				{
					TaskAwaiter<OmniSharpItem> val2;
					if (num != 0)
					{
						InitWorkspaceRequest val = InterfaceCreator.Create<InitWorkspaceRequest>();
						val.set_CodeType((int)codeType);
						val.set_MethodName(methodName);
						val.set_Metadata(metadata);
						val.set_ScriptModules((System.Collections.Generic.ICollection<ScriptModule>)Enumerable.Where<ScriptModule>((System.Collections.Generic.IEnumerable<ScriptModule>)GetScriptModules(clientScriptModule, viewScriptModule, serverScriptModule, testScriptModule, codeType), (Func<ScriptModule, bool>)((ScriptModule a) => a != null)).ToArray());
						val2 = omniSharpManager.omniSharpService.InitWorkspace(val).GetAwaiter();
						if (!val2.get_IsCompleted())
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = val2;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter<OmniSharpItem>, _003CInitWorkspace_003Ed__5>(ref val2, ref this);
							return;
						}
					}
					else
					{
						val2 = (TaskAwaiter<OmniSharpItem>)_003C_003Eu__1;
						_003C_003Eu__1 = null;
						num = (_003C_003E1__state = -1);
					}
					OmniSharpItem result = val2.GetResult();
					omniSharpManager.SetOmniSharpItem(result);
				}
				catch (System.Exception)
				{
					omniSharpManager.notificationService.Warning(SR.T("Автодополнение отключено"), SR.T("Произошла ошибка при инициализации сервера автодополнения"));
					omniSharpManager.SetOmniSharpItem(InterfaceCreator.Create<OmniSharpItem>());
				}
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

	private readonly IOmniSharpService omniSharpService;

	private readonly INotificationService notificationService;

	private OmniSharpItem omniSharpItem;

	public OmniSharpManager(IOmniSharpService omniSharpService, INotificationService notificationService)
	{
		this.omniSharpService = omniSharpService;
		this.notificationService = notificationService;
	}

	public System.Threading.Tasks.Task StartServer(bool needRestart)
	{
		return omniSharpService.Start(needRestart);
	}

	public System.Threading.Tasks.Task InitWorkspace(NamedMetadata metadata, ScriptModule clientScriptModule, ScriptModule viewScriptModule, ScriptModule serverScriptModule, ScriptModule testScriptModule, CodeType codeType, string methodName)
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		_003CInitWorkspace_003Ed__5 _003CInitWorkspace_003Ed__ = default(_003CInitWorkspace_003Ed__5);
		_003CInitWorkspace_003Ed__._003C_003E4__this = this;
		_003CInitWorkspace_003Ed__.metadata = metadata;
		_003CInitWorkspace_003Ed__.clientScriptModule = clientScriptModule;
		_003CInitWorkspace_003Ed__.viewScriptModule = viewScriptModule;
		_003CInitWorkspace_003Ed__.serverScriptModule = serverScriptModule;
		_003CInitWorkspace_003Ed__.testScriptModule = testScriptModule;
		_003CInitWorkspace_003Ed__.codeType = codeType;
		_003CInitWorkspace_003Ed__.methodName = methodName;
		_003CInitWorkspace_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		_003CInitWorkspace_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder _003C_003Et__builder = _003CInitWorkspace_003Ed__._003C_003Et__builder;
		((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).Start<_003CInitWorkspace_003Ed__5>(ref _003CInitWorkspace_003Ed__);
		return ((AsyncTaskMethodBuilder)(ref _003CInitWorkspace_003Ed__._003C_003Et__builder)).get_Task();
	}

	public OmniSharpItem GetOmniSharpItem()
	{
		InitModel();
		return omniSharpItem;
	}

	public void SetOmniSharpItem(OmniSharpItem item)
	{
		InitModel();
		omniSharpItem.set_FileName(item.get_FileName());
		omniSharpItem.set_MethodPosition(item.get_MethodPosition());
		omniSharpItem.set_ProjectFileName(item.get_ProjectFileName());
	}

	public System.Threading.Tasks.Task AddReferences(AddReferencesModel model)
	{
		InitModel();
		AddReferencesRequest request = new AddReferencesRequest
		{
			FileName = omniSharpItem.get_FileName(),
			ProjectFileName = omniSharpItem.get_ProjectFileName(),
			AssemblyNames = model.AssemblyNames,
			GlobalModulesUids = model.GlobalModulesUids,
			WebReferences = Enumerable.Select<WebReferenceInfo, WebReferenceInfo>(model.WebReferences, (Func<WebReferenceInfo, WebReferenceInfo>)((WebReferenceInfo i) => new WebReferenceInfo
			{
				WebReferenceName = i.WebReferenceName,
				CodeFilePath = i.CodeFilePath
			})).ToArray()
		};
		return omniSharpService.AddReferences(request);
	}

	public System.Threading.Tasks.Task RemoveReferences(string[] assemblyNames, Guid[] globalModulesUids, string[] webReferencesNames)
	{
		InitModel();
		RemoveReferencesRequest request = new RemoveReferencesRequest
		{
			FileName = omniSharpItem.get_FileName(),
			ProjectFileName = omniSharpItem.get_ProjectFileName(),
			AssemblyNames = assemblyNames,
			GlobalModulesUids = globalModulesUids,
			WebReferencesNames = webReferencesNames
		};
		return omniSharpService.RemoveReferences(request);
	}

	private void InitModel()
	{
		if (omniSharpItem == null)
		{
			omniSharpItem = InterfaceCreator.Create<OmniSharpItem>();
		}
	}

	private static ScriptModule[] GetScriptModules(ScriptModule clientSM, ScriptModule viewSM, ScriptModule serverSM, ScriptModule testSM, CodeType codeType)
	{
		return codeType switch
		{
			CodeType.Client => (ScriptModule[])(object)new ScriptModule[2] { serverSM, clientSM }, 
			CodeType.View => (ScriptModule[])(object)new ScriptModule[3] { serverSM, clientSM, viewSM }, 
			CodeType.Server => (ScriptModule[])(object)new ScriptModule[1] { serverSM }, 
			CodeType.Test => (ScriptModule[])(object)new ScriptModule[4] { serverSM, clientSM, testSM, viewSM }, 
			_ => (ScriptModule[])(object)new ScriptModule[0], 
		};
	}
}
