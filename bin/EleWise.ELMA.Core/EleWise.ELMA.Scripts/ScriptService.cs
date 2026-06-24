using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Bridge;
using Bridge.Html5;
using EleWise.ELMA.Api.Models;
using EleWise.ELMA.Api.Services.Internal;
using EleWise.ELMA.Core.Abstractions.Metadata.Models;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Dependencies;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Scripts;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Types;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.UI;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.UI.Metadata;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Model.Managers;
using EleWise.ELMA.Core.Serialization;
using EleWise.ELMA.Core.Services;
using EleWise.ELMA.DTO;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.ViewModel;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Scripts.Models;
using EleWise.ELMA.Scripts.ScriptHandlers;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Scripts;

[Service]
[Rules(/*Could not decode attribute arguments.*/)]
internal sealed class ScriptService : IScriptService
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<AdditionalModel, SerializedModelDto> _003C_003E9__10_3;

		public static Func<string, object, object> _003C_003E9__10_0;

		public static Func<PropertyViewInfoDto, PropertyViewInfo> _003C_003E9__10_1;

		public static Func<NotificationInfoDto, NotificationInfo> _003C_003E9__10_2;

		public static Func<PropertyMetadata, bool> _003C_003E9__11_0;

		internal SerializedModelDto _003CExecuteScriptWithResult_003Eb__10_3(AdditionalModel a)
		{
			return new SerializedModelDto
			{
				Model = SerializationHelper.SerializeObjectByJson(a.Model),
				Name = a.Name
			};
		}

		internal object _003CExecuteScriptWithResult_003Eb__10_0(string key, object value)
		{
			if (key == "Parent")
			{
				return JSON.Stringify(value, new string[3] { "Id", "Uid", "TypeUid" });
			}
			return value;
		}

		internal PropertyViewInfo _003CExecuteScriptWithResult_003Eb__10_1(PropertyViewInfoDto a)
		{
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			PropertyViewInfo obj = InterfaceCreator.Create<PropertyViewInfo>();
			obj.set_Required(a.Required);
			obj.set_Uid(a.Uid);
			obj.set_Visible(a.Visible);
			obj.set_IsValid(a.IsValid);
			obj.set_ReadOnly(a.ReadOnly);
			obj.set_ValidationMessage(a.ValidationMessage);
			obj.set_Settings(InterfaceCreator.Create<TypeSettings>(a.Settings));
			return obj;
		}

		internal NotificationInfo _003CExecuteScriptWithResult_003Eb__10_2(NotificationInfoDto a)
		{
			NotificationInfo obj = InterfaceCreator.Create<NotificationInfo>();
			obj.set_Message(a.Message);
			obj.set_Type(a.Type);
			return obj;
		}

		internal bool _003CGenerateServerParameters_003Eb__11_0(PropertyMetadata property)
		{
			return ((INamedMetadata)property).get_Name() == "Model";
		}
	}

	[StructLayout(3)]
	private struct _003CExecuteScriptWithResult_003Ed__10 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<object> _003C_003Et__builder;

		public ScriptExecutionParams executionParams;

		public ScriptService _003C_003E4__this;

		private ReactiveProxy _003Cmodel_003E5__2;

		private ReactiveProxy _003Citem_003E5__3;

		private ScriptExecutionResponseDto _003Cresult_003E5__4;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0104: Unknown result type (might be due to invalid IL or missing references)
			//IL_011e: Unknown result type (might be due to invalid IL or missing references)
			//IL_04f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_04f9: Expected O, but got Unknown
			int num = _003C_003E1__state;
			ScriptService CS_0024_003C_003E8__locals0 = _003C_003E4__this;
			object result;
			try
			{
				TaskAwaiter<ScriptExecutionResponseDto> val3;
				TaskAwaiter<LoadComponentScriptsResult> val2;
				TaskAwaiter val;
				FormViewBuilderInfoDto formViewBuilderInfo;
				ScriptExecutionResponseDto scriptExecutionResponseDto;
				switch (num)
				{
				default:
				{
					SerializationSettings settings = new SerializationSettings
					{
						WriteReferences = true
					};
					_003Cmodel_003E5__2 = executionParams.Model;
					System.Collections.Generic.IEnumerator<ISerializationHandler> enumerator = CS_0024_003C_003E8__locals0.serializationHandlers.GetEnumerator();
					try
					{
						while (((System.Collections.IEnumerator)enumerator).MoveNext())
						{
							enumerator.get_Current().BeforeSerialize(_003Cmodel_003E5__2);
						}
					}
					finally
					{
						if (num < 0)
						{
							((System.IDisposable)enumerator)?.Dispose();
						}
					}
					ModelInfo modelInfo = executionParams.ModelInfo;
					ScriptExecutionRequestDto scriptExecutionRequestDto = new ScriptExecutionRequestDto
					{
						AdditionalModels = Enumerable.Select<AdditionalModel, SerializedModelDto>((System.Collections.Generic.IEnumerable<AdditionalModel>)executionParams.AdditionalModels, (Func<AdditionalModel, SerializedModelDto>)((AdditionalModel a) => new SerializedModelDto
						{
							Model = SerializationHelper.SerializeObjectByJson(a.Model),
							Name = a.Name
						})).ToArray(),
						ScriptName = executionParams.ScriptName,
						Model = JSON.Stringify(ConvertHelper.Serialize(_003Cmodel_003E5__2, settings)),
						ModelInfo = new ModelInfoDto
						{
							FormUid = modelInfo.get_FormUid(),
							TypeUid = modelInfo.get_TypeUid(),
							ViewType = modelInfo.get_ViewType(),
							SubTypeUid = modelInfo.get_SubTypeUid()
						},
						EntityTypeSerializationSettings = Enumerable.Select<EntityDependency, EntityTypeSerializationSettingsDto>(CS_0024_003C_003E8__locals0.currentPageService.GetEntityDependencies(), (Func<EntityDependency, EntityTypeSerializationSettingsDto>)((EntityDependency a) => new EntityTypeSerializationSettingsDto
						{
							TypeUid = ((Dependency)a).get_HeaderUid(),
							Properties = a.GetProperties(CS_0024_003C_003E8__locals0.dependencyHackList)
						})).ToArray(),
						RuntimeModel = CS_0024_003C_003E8__locals0.findComponentService.GetCurrentRuntimeModel()
					};
					_003Citem_003E5__3 = executionParams.Item;
					if (_003Citem_003E5__3 != null)
					{
						scriptExecutionRequestDto.Item = JSON.Stringify(_003Citem_003E5__3.Json, (Func<string, object, object>)((string key, object value) => (key == "Parent") ? JSON.Stringify(value, new string[3] { "Id", "Uid", "TypeUid" }) : value));
					}
					val3 = CS_0024_003C_003E8__locals0.scriptExecutionService.ExecuteScript(scriptExecutionRequestDto, ScriptMethodInfoHelper.Deserialize(scriptExecutionRequestDto.ScriptName)?.Name).GetAwaiter();
					if (!val3.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val3;
						_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<ScriptExecutionResponseDto>, _003CExecuteScriptWithResult_003Ed__10>(ref val3, ref this);
						return;
					}
					goto IL_022c;
				}
				case 0:
					val3 = (TaskAwaiter<ScriptExecutionResponseDto>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_022c;
				case 1:
					val2 = (TaskAwaiter<LoadComponentScriptsResult>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_02f5;
				case 2:
					{
						val = (TaskAwaiter)_003C_003Eu__1;
						_003C_003Eu__1 = null;
						num = (_003C_003E1__state = -1);
						goto IL_0509;
					}
					IL_0509:
					val.GetResult();
					goto IL_0510;
					IL_02fd:
					if (_003Citem_003E5__3 != null)
					{
						ConvertHelper.Reconcile(_003Citem_003E5__3, _003Cresult_003E5__4.Item);
					}
					if (executionParams.UpdateModel)
					{
						ConvertHelper.Reconcile(_003Cmodel_003E5__2, _003Cresult_003E5__4.Model);
					}
					formViewBuilderInfo = _003Cresult_003E5__4.FormViewBuilderInfo;
					if (formViewBuilderInfo != null)
					{
						FormViewBuilderInfo val4 = InterfaceCreator.Create<FormViewBuilderInfo>();
						val4.set_ClosePopup(formViewBuilderInfo.ClosePopup);
						val4.get_Properties().AddRange((System.Collections.Generic.IEnumerable<PropertyViewInfo>)Enumerable.Select<PropertyViewInfoDto, PropertyViewInfo>((System.Collections.Generic.IEnumerable<PropertyViewInfoDto>)formViewBuilderInfo.Properties, (Func<PropertyViewInfoDto, PropertyViewInfo>)delegate(PropertyViewInfoDto a)
						{
							//IL_0013: Unknown result type (might be due to invalid IL or missing references)
							PropertyViewInfo obj2 = InterfaceCreator.Create<PropertyViewInfo>();
							obj2.set_Required(a.Required);
							obj2.set_Uid(a.Uid);
							obj2.set_Visible(a.Visible);
							obj2.set_IsValid(a.IsValid);
							obj2.set_ReadOnly(a.ReadOnly);
							obj2.set_ValidationMessage(a.ValidationMessage);
							obj2.set_Settings(InterfaceCreator.Create<TypeSettings>(a.Settings));
							return obj2;
						}));
						val4.get_Notifications().AddRange((System.Collections.Generic.IEnumerable<NotificationInfo>)Enumerable.Select<NotificationInfoDto, NotificationInfo>((System.Collections.Generic.IEnumerable<NotificationInfoDto>)formViewBuilderInfo.Notifications, (Func<NotificationInfoDto, NotificationInfo>)delegate(NotificationInfoDto a)
						{
							NotificationInfo obj = InterfaceCreator.Create<NotificationInfo>();
							obj.set_Message(a.Message);
							obj.set_Type(a.Type);
							return obj;
						}));
						IViewModel viewModel = executionParams.ViewModel;
						if (viewModel is IFormViewModel formViewModel && formViewModel.ViewItem is FormViewItem formViewItem)
						{
							CS_0024_003C_003E8__locals0.formService.UpdateForm(formViewItem, val4);
							if (val4.get_ClosePopup())
							{
								Action closeCurrentDrawer = formViewModel.CloseCurrentDrawer;
								if (closeCurrentDrawer != null)
								{
									closeCurrentDrawer.Invoke();
								}
							}
						}
						if (!(viewModel is IComponentViewItemViewModel componentViewItemViewModel) || !(componentViewItemViewModel.CurrentViewItem is FormViewItem formViewItem2))
						{
							break;
						}
						IMetadata metadata = componentViewItemViewModel.UIViewModel.get_Metadata();
						if (!(metadata is PageComponentMetadata) && !(metadata is PortletComponentMetadata))
						{
							break;
						}
						CS_0024_003C_003E8__locals0.formService.UpdateForm(formViewItem2, val4);
						if (!(metadata is PageComponentMetadata))
						{
							break;
						}
						if (val4.get_ClosePopup() && componentViewItemViewModel.ViewItem is ComponentViewItem componentViewItem && componentViewItem.CloseCurrentDrawer != null)
						{
							val = componentViewItem.CloseCurrentDrawer.Call().GetAwaiter();
							if (!val.get_IsCompleted())
							{
								num = (_003C_003E1__state = 2);
								_003C_003Eu__1 = val;
								_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter, _003CExecuteScriptWithResult_003Ed__10>(ref val, ref this);
								return;
							}
							goto IL_0509;
						}
						goto IL_0510;
					}
					result = null;
					goto end_IL_000e;
					IL_0510:
					if (!string.IsNullOrWhiteSpace(_003Cresult_003E5__4.RedirectUrl))
					{
						CS_0024_003C_003E8__locals0.redirectService.Redirect(_003Cresult_003E5__4.RedirectUrl);
					}
					break;
					IL_02f5:
					val2.GetResult();
					goto IL_02fd;
					IL_022c:
					scriptExecutionResponseDto = (_003Cresult_003E5__4 = val3.GetResult());
					if (!string.IsNullOrEmpty(_003Cresult_003E5__4.ExceptionMessage))
					{
						System.Exception ex = new System.Exception(_003Cresult_003E5__4.ExceptionMessage);
						_ = _003Cresult_003E5__4.ExceptionStackTrace;
						throw ex;
					}
					if (_003Cresult_003E5__4.AdditionalComponentModels.Length != 0)
					{
						val2 = CS_0024_003C_003E8__locals0.findComponentService.LoadRuntimeMetadata((System.Collections.Generic.IEnumerable<ClientComponentModel>)Enumerable.Select<ClientComponentModelDto, ClientComponentModel>((System.Collections.Generic.IEnumerable<ClientComponentModelDto>)_003Cresult_003E5__4.AdditionalComponentModels, (Func<ClientComponentModelDto, ClientComponentModel>)FindComponentService.MapClientComponentModelFromDto)).GetAwaiter();
						if (!val2.get_IsCompleted())
						{
							num = (_003C_003E1__state = 1);
							_003C_003Eu__1 = val2;
							_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<LoadComponentScriptsResult>, _003CExecuteScriptWithResult_003Ed__10>(ref val2, ref this);
							return;
						}
						goto IL_02f5;
					}
					goto IL_02fd;
				}
				result = _003Cresult_003E5__4.ReturnValue;
				end_IL_000e:;
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

	private readonly IScriptExecutionService scriptExecutionService;

	private readonly ICurrentPageService currentPageService;

	private readonly FindComponentService findComponentService;

	private readonly IMetadataServiceContext metadataServiceContext;

	private readonly System.Collections.Generic.IEnumerable<IDependencyHackList> dependencyHackList;

	private readonly IFormService formService;

	private readonly IRedirectService redirectService;

	private readonly System.Collections.Generic.IEnumerable<ISerializationHandler> serializationHandlers;

	public ScriptService(IScriptExecutionService scriptExecutionService, ICurrentPageService currentPageService, FindComponentService findComponentService, IMetadataServiceContext metadataServiceContext, System.Collections.Generic.IEnumerable<IDependencyHackList> dependencyHackList, IFormService formService, IRedirectService redirectService, System.Collections.Generic.IEnumerable<ISerializationHandler> serializationHandlers)
	{
		this.scriptExecutionService = scriptExecutionService;
		this.currentPageService = currentPageService;
		this.findComponentService = findComponentService;
		this.metadataServiceContext = metadataServiceContext;
		this.dependencyHackList = dependencyHackList;
		this.formService = formService;
		this.redirectService = redirectService;
		this.serializationHandlers = serializationHandlers;
	}

	public System.Threading.Tasks.Task ExecuteScript(ScriptExecutionParams executionParams)
	{
		return ExecuteScriptWithResult(executionParams);
	}

	public System.Threading.Tasks.Task<object> ExecuteScriptWithResult(ScriptExecutionParams executionParams)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003CExecuteScriptWithResult_003Ed__10 _003CExecuteScriptWithResult_003Ed__ = default(_003CExecuteScriptWithResult_003Ed__10);
		_003CExecuteScriptWithResult_003Ed__._003C_003E4__this = this;
		_003CExecuteScriptWithResult_003Ed__.executionParams = executionParams;
		_003CExecuteScriptWithResult_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<object>.Create();
		_003CExecuteScriptWithResult_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<object> _003C_003Et__builder = _003CExecuteScriptWithResult_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CExecuteScriptWithResult_003Ed__10>(ref _003CExecuteScriptWithResult_003Ed__);
		return _003CExecuteScriptWithResult_003Ed__._003C_003Et__builder.get_Task();
	}

	public System.Collections.Generic.IEnumerable<ScriptMethodParameter> GenerateServerParameters(GenerateParametersOptions options = null)
	{
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		List<ScriptMethodParameter> val = new List<ScriptMethodParameter>();
		CurrentPageModel currentPageViewModel = currentPageService.CurrentPageViewModel;
		if (currentPageViewModel.OverrideInitWorkspace)
		{
			if (currentPageViewModel.ViewItem is FormViewItem formViewItem && formViewItem.RuntimeVersion == RuntimeVersion.Version1)
			{
				IMetadata metadata = currentPageViewModel.Metadata;
				EntityMetadata val2;
				if ((val2 = (EntityMetadata)(object)((metadata is EntityMetadata) ? metadata : null)) != null)
				{
					ScriptMethodParameter val3 = InterfaceCreator.Create<ScriptMethodParameter>();
					string text;
					if (DTOHelper.ProxyType("943d4d9d-5c7c-4de9-884f-014f014f92fb").CanCast(ObjectExtensions.As<ReactiveProxy>((object)val2)))
					{
						text = "Context";
						val3.set_Name("context");
						val3.set_Type(text);
					}
					else
					{
						string @namespace = ((ICodeItemMetadata)val2).get_Namespace();
						string text2 = "I" + ((INamedMetadata)val2).get_Name();
						text = ((!string.IsNullOrWhiteSpace(@namespace)) ? (@namespace + "." + text2) : text2);
						val3.set_Name("entity");
						val3.set_Type(text);
					}
					val.Add(val3);
					if (options != null && options.Item != null)
					{
						ScriptMethodParameter val4 = InterfaceCreator.Create<ScriptMethodParameter>();
						val4.set_Name("item");
						val4.set_Type(((ICodeItemMetadata)options.Item).get_FullTypeName());
						val.Add(val4);
						ScriptMethodParameter val5 = InterfaceCreator.Create<ScriptMethodParameter>();
						val5.set_Name("form");
						val5.set_Type("EleWise.ELMA.Model.Views.FormViewBuilder<" + ((ICodeItemMetadata)options.Item).get_FullTypeName() + ">");
						val.Add(val5);
					}
					else
					{
						ScriptMethodParameter val6 = InterfaceCreator.Create<ScriptMethodParameter>();
						val6.set_Name("form");
						val6.set_Type("EleWise.ELMA.Model.Views.FormViewBuilder<" + text + ">");
						val.Add(val6);
					}
				}
			}
			else
			{
				IMetadata metadata2 = currentPageViewModel.Metadata;
				DataClassMetadata val7;
				if ((val7 = (DataClassMetadata)(object)((metadata2 is DataClassMetadata) ? metadata2 : null)) != null && ((INamedMetadata)val7).get_Name() == "ViewModelContext")
				{
					PropertyMetadata val8 = Enumerable.FirstOrDefault<PropertyMetadata>((System.Collections.Generic.IEnumerable<PropertyMetadata>)((ClassMetadata)val7).get_Properties(), (Func<PropertyMetadata, bool>)((PropertyMetadata property) => ((INamedMetadata)property).get_Name() == "Model"));
					EntityMetadata val9;
					if (val8 != null && (val9 = (EntityMetadata)/*isinst with value type is only supported in some contexts*/) != null)
					{
						if (DTOHelper.ProxyType("943d4d9d-5c7c-4de9-884f-014f014f92fb").CanCast(ObjectExtensions.As<ReactiveProxy>((object)val9)))
						{
							ScriptMethodParameter val10 = InterfaceCreator.Create<ScriptMethodParameter>();
							val10.set_Name("context");
							val10.set_Type("Context");
							val.Add(val10);
						}
						else
						{
							string namespace2 = ((ICodeItemMetadata)val9).get_Namespace();
							string text3 = "I" + ((INamedMetadata)val9).get_Name();
							ScriptMethodParameter val11 = InterfaceCreator.Create<ScriptMethodParameter>();
							val11.set_Name("entity");
							val11.set_Type((!string.IsNullOrWhiteSpace(namespace2)) ? (namespace2 + "." + text3) : text3);
							val.Add(val11);
						}
					}
				}
				if (options != null && options.Item != null)
				{
					ScriptMethodParameter val12 = InterfaceCreator.Create<ScriptMethodParameter>();
					val12.set_Name("item");
					val12.set_Type(((ICodeItemMetadata)options.Item).get_FullTypeName());
					val.Add(val12);
					ScriptMethodParameter val13 = InterfaceCreator.Create<ScriptMethodParameter>();
					val13.set_Name("form");
					val13.set_Type(options.Item.get_TypeName() + "_ViewModel");
					val.Add(val13);
				}
				else
				{
					ScriptMethodParameter val14 = InterfaceCreator.Create<ScriptMethodParameter>();
					val14.set_Name("form");
					val14.set_Type("ViewModel");
					val.Add(val14);
				}
			}
		}
		else
		{
			ScriptMethodParameter val15 = InterfaceCreator.Create<ScriptMethodParameter>();
			val15.set_Name(GetParameterName());
			val15.set_Type("ViewModel");
			val.Add(val15);
		}
		return (System.Collections.Generic.IEnumerable<ScriptMethodParameter>)val;
	}

	private string GetParameterName()
	{
		IMetadata currentMetadata = currentPageService.GetCurrentMetadata();
		if (currentMetadata != null)
		{
			if (currentMetadata is PortletComponentMetadata)
			{
				return "portlet";
			}
			if (currentMetadata is PageComponentMetadata)
			{
				return "page";
			}
			if (currentMetadata is ComponentMetadata)
			{
				return "component";
			}
		}
		return "model";
	}

	private EntityTypeSerializationSettingsDto _003CExecuteScriptWithResult_003Eb__10_4(EntityDependency a)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		return new EntityTypeSerializationSettingsDto
		{
			TypeUid = ((Dependency)a).get_HeaderUid(),
			Properties = a.GetProperties(dependencyHackList)
		};
	}
}
