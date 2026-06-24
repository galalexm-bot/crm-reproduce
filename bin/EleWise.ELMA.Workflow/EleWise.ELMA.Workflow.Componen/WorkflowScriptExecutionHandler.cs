using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.DataClasses;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Scripts.Models;
using EleWise.ELMA.Security;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.UI.Scripts.Services;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Components;

[Component]
internal sealed class WorkflowScriptExecutionHandler : IScriptExecutionHandler
{
	private sealed class BaseScriptExecutionInfo
	{
		internal static object RN2EtGvZgjulJwTZAJ9O;

		public IWorkflowInstance WorkflowInstance
		{
			[CompilerGenerated]
			get
			{
				return _003CWorkflowInstance_003Ek__BackingField;
			}
			[CompilerGenerated]
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						_003CWorkflowInstance_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e9561fecdd4d49678d9f9ea7d295fb1b == 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public ProcessContext ProcessContext
		{
			[CompilerGenerated]
			get
			{
				return _003CProcessContext_003Ek__BackingField;
			}
			[CompilerGenerated]
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						_003CProcessContext_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e9561fecdd4d49678d9f9ea7d295fb1b == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public List<DataClassMetadata> Includes { get; }

		public BaseScriptExecutionInfo()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 == 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					return;
				}
				Includes = new List<DataClassMetadata>();
				num = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a9be7e056b4e4b6e863b634c418144f1 == 0)
				{
					num = 0;
				}
			}
		}

		internal static bool fyXPd1vZBkgMVdxY9G0G()
		{
			return RN2EtGvZgjulJwTZAJ9O == null;
		}

		internal static BaseScriptExecutionInfo UnfnqDvZcYMQXRYxWSq7()
		{
			return (BaseScriptExecutionInfo)RN2EtGvZgjulJwTZAJ9O;
		}
	}

	private readonly WorkflowTaskBaseManager workflowTaskBaseManager;

	private readonly IWorkflowScriptingService workflowScriptingService;

	private readonly ViewModelDescriptor viewModelDescriptor;

	private readonly IEqlPropertiesService eqlPropertiesService;

	private readonly ISecurityService securityService;

	private static WorkflowScriptExecutionHandler iaNIZmOmaSUOffS34Onw;

	public WorkflowScriptExecutionHandler(WorkflowTaskBaseManager workflowTaskBaseManager, IWorkflowScriptingService workflowScriptingService, ViewModelDescriptor viewModelDescriptor, IEqlPropertiesService eqlPropertiesService, ISecurityService securityService)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		KjBK7YOmNtVJF14ewedB();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a23e27b648a042f098a477c26c4beed1 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 3:
				this.viewModelDescriptor = viewModelDescriptor;
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b84ccb8b1bd147ef900b852047ecbf45 == 0)
				{
					num = 0;
				}
				break;
			case 1:
				this.workflowTaskBaseManager = workflowTaskBaseManager;
				num = 2;
				break;
			case 2:
				this.workflowScriptingService = workflowScriptingService;
				num = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_61395ebf330446ac8ce99b55ee3acfa9 != 0)
				{
					num = 3;
				}
				break;
			case 4:
				this.securityService = securityService;
				num = 5;
				break;
			default:
				this.eqlPropertiesService = eqlPropertiesService;
				num = 4;
				break;
			case 5:
				return;
			}
		}
	}

	public bool Check(ScriptExecutionParams parameters)
	{
		return IlLclbOmhusLCF24GymL(PT67KCOmSs9LGNx8bwp0(VqyQmFOmxBOFXeyP4ywp(parameters)), new Guid((string)ma3qSVOm1CEGMRWXZDx2(0x738ABA6E ^ 0x738AA69A)));
	}

	public ScriptExecutionResult ExecuteScript(ScriptExecutionParams parameters)
	{
		//Discarded unreachable code: IL_01c0, IL_053d, IL_05c0, IL_05f3, IL_065c, IL_066b, IL_0749, IL_0758, IL_0768, IL_0820, IL_082f, IL_083a, IL_08ee, IL_0955, IL_098d, IL_099c
		int num = 51;
		_003C_003Ec__DisplayClass10_0 _003C_003Ec__DisplayClass10_ = default(_003C_003Ec__DisplayClass10_0);
		BaseScriptExecutionInfo baseScriptExecutionInfo = default(BaseScriptExecutionInfo);
		DataClass dataClass2 = default(DataClass);
		ProcessContext context = default(ProcessContext);
		Type viewModelContextType = default(Type);
		DataClassMetadata viewModelMetadata = default(DataClassMetadata);
		Type type = default(Type);
		Assembly scriptAssembly = default(Assembly);
		IWorkflowProcess workflowProcess = default(IWorkflowProcess);
		IWorkflowTaskBase workflowTaskBase = default(IWorkflowTaskBase);
		ScriptMethodInfo scriptMethodInfo = default(ScriptMethodInfo);
		WorkflowInstanceContext workflowInstanceContext = default(WorkflowInstanceContext);
		MethodInfo method = default(MethodInfo);
		List<DataClassMetadata> list = default(List<DataClassMetadata>);
		Dictionary<string, object> parameters2 = default(Dictionary<string, object>);
		IEnumerator<PropertyViewInfo> enumerator = default(IEnumerator<PropertyViewInfo>);
		DataClass dataClass = default(DataClass);
		DataClassMetadata viewModelMetadata2 = default(DataClassMetadata);
		object returnValue = default(object);
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		PropertyViewInfo current = default(PropertyViewInfo);
		TypeSettings typeSettings = default(TypeSettings);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 12:
				case 47:
					if (_003C_003Ec__DisplayClass10_.viewModelContext != null)
					{
						num = 23;
						break;
					}
					goto case 54;
				case 32:
					if (baseScriptExecutionInfo == null)
					{
						num = 36;
						break;
					}
					goto case 46;
				case 45:
					dataClass2 = (DataClass)DeserializeViewModelContext((string)bSQUK1Otsx4fHetx6MQt(_003C_003Ec__DisplayClass10_.parameters), (DataClassMetadata)M1ACqqOtOTtl3TOVN69q(context), viewModelContextType);
					num2 = 32;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 != 0)
					{
						num2 = 8;
					}
					continue;
				case 50:
					_003C_003Ec__DisplayClass10_.parameters = parameters;
					num2 = 14;
					continue;
				case 15:
					_003C_003Ec__DisplayClass10_.workflowInstance = baseScriptExecutionInfo.WorkflowInstance;
					num2 = 38;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f05298ca2a4a4a639a58bc7f7d9ff7b9 == 0)
					{
						num2 = 47;
					}
					continue;
				case 16:
					viewModelMetadata = (DataClassMetadata)M1ACqqOtOTtl3TOVN69q(baseScriptExecutionInfo.ProcessContext);
					num2 = 9;
					continue;
				case 46:
					type = RAMSjZOt8ZLtPjmgXeMl(scriptAssembly, Amsbc6OtYTBc7QDlEoLd(baseScriptExecutionInfo.ProcessContext));
					num2 = 52;
					continue;
				case 24:
					_003C_003Ec__DisplayClass10_.propertyContainer = null;
					num2 = 19;
					continue;
				case 53:
					viewModelContextType = RAMSjZOt8ZLtPjmgXeMl(scriptAssembly, Amsbc6OtYTBc7QDlEoLd(context));
					num2 = 45;
					continue;
				case 43:
					workflowProcess = (IWorkflowProcess)GgApgrOtKbT0r7JDvV9d(_003C_003Ec__DisplayClass10_.workflowInstance);
					num2 = 41;
					continue;
				case 3:
					_003C_003Ec__DisplayClass10_.workflowInstance = (IWorkflowInstance)dDio1POmzBArgFGkMnlD(V001PoOm4wJTm8tHbngu(workflowTaskBase));
					num2 = 43;
					continue;
				case 38:
					viewModelMetadata = (DataClassMetadata)M1ACqqOtOTtl3TOVN69q(context);
					num2 = 12;
					continue;
				case 29:
					baseScriptExecutionInfo = (BaseScriptExecutionInfo)fL7k8aOtvylWvS1ap7iF(workflowTaskBase, Cw6RDwOtZcoXDLL4MV02(scriptMethodInfo));
					num2 = 8;
					continue;
				case 41:
					_003C_003Ec__DisplayClass10_.viewModelType = null;
					num = 30;
					break;
				case 27:
					workflowInstanceContext = (WorkflowInstanceContext)AXHcHXOtmGDLNyDasr6g(_003C_003Ec__DisplayClass10_.workflowInstance);
					num2 = 26;
					continue;
				case 9:
					_003C_003Ec__DisplayClass10_.viewModelType = MLXSbyOtbXQoE1boSg69(scriptAssembly, ((NamedMetadata)rgH7NeOtJo3uDjZ9menD(baseScriptExecutionInfo)).Name);
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e9561fecdd4d49678d9f9ea7d295fb1b != 0)
					{
						num2 = 1;
					}
					continue;
				case 7:
					method = type.GetMethod((string)ma3qSVOm1CEGMRWXZDx2(0x1843E01F ^ 0x18425BB7), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
					num2 = 35;
					continue;
				case 40:
					list = new List<DataClassMetadata>();
					num2 = 20;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6dd19c81ff5e41fb8db9b50574437301 != 0)
					{
						num2 = 11;
					}
					continue;
				case 54:
					parameters2 = new Dictionary<string, object>();
					num2 = 24;
					continue;
				case 19:
					_003C_003Ec__DisplayClass10_.item = null;
					num2 = 4;
					continue;
				case 31:
					enumerator = _003C_003Ec__DisplayClass10_.propertyContainer.GetAll().GetEnumerator();
					num2 = 6;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4cc62744d0eb4cd68219b70dcad3e68e == 0)
					{
						num2 = 22;
					}
					continue;
				case 1:
					_003C_003Ec__DisplayClass10_.viewModelContext = dataClass;
					num2 = 15;
					continue;
				case 35:
					if (!DrD8ZPOtlaA0pMR2VYRM(method, null))
					{
						num2 = 25;
						continue;
					}
					goto case 17;
				case 20:
					context = workflowProcess.Context;
					num2 = 42;
					continue;
				case 21:
				case 39:
					if (NZtQFYOtLMcgjtMx7VAR(list) != 0)
					{
						num2 = 34;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 != 0)
						{
							num2 = 17;
						}
						continue;
					}
					goto case 11;
				case 34:
					MapValuesFromBaseToOriginal(dataClass2, _003C_003Ec__DisplayClass10_.viewModelContext, list);
					num2 = 6;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 != 0)
					{
						num2 = 11;
					}
					continue;
				case 8:
					scriptAssembly = GetScriptAssembly(workflowProcess);
					num2 = 51;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 != 0)
					{
						num2 = 53;
					}
					continue;
				case 17:
					viewModelMetadata2 = ((EntityMetadata)rgH7NeOtJo3uDjZ9menD(baseScriptExecutionInfo)).ViewModelMetadata;
					num2 = 2;
					continue;
				case 18:
				case 36:
					_003C_003Ec__DisplayClass10_.viewModelType = MLXSbyOtbXQoE1boSg69(scriptAssembly, context.Name);
					num2 = 44;
					continue;
				default:
					if (UmYKJWOtgQOrFlecH8Aw(Ag0uwuOmELFH8lsx72eW(_003C_003Ec__DisplayClass10_.parameters), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1498811449 ^ -1498920839)))
					{
						num2 = 6;
						continue;
					}
					goto case 54;
				case 13:
				{
					ScriptExecutionResult scriptExecutionResult = new ScriptExecutionResult();
					G6NB31OtBTdk2FGiUX7O(scriptExecutionResult, dataClass2);
					return scriptExecutionResult;
				}
				case 10:
					dataClass2 = null;
					num2 = 32;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6d48f3b4557a49578bf7f5ef0517e0be != 0)
					{
						num2 = 40;
					}
					continue;
				case 33:
					scriptMethodInfo = (ScriptMethodInfo)LPsNEYOmw52lTjTTOehl(Ag0uwuOmELFH8lsx72eW(_003C_003Ec__DisplayClass10_.parameters));
					num2 = 5;
					continue;
				case 26:
					if (workflowInstanceContext != null)
					{
						num2 = 28;
						continue;
					}
					goto case 21;
				case 6:
					if (list.Count != 0)
					{
						num2 = 3;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ecf910d183864897a7c8ec77e01689a4 != 0)
						{
							num2 = 48;
						}
						continue;
					}
					goto case 13;
				case 30:
					_003C_003Ec__DisplayClass10_.viewModelContext = null;
					num2 = 10;
					continue;
				case 14:
					_003C_003Ec__DisplayClass10_._003C_003E4__this = this;
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_938c6be4ea2248868d7ed5d0e3346006 != 0)
					{
						num2 = 33;
					}
					continue;
				case 4:
					try
					{
						returnValue = workflowScriptingService.ExecuteScript(_003C_003Ec__DisplayClass10_.workflowInstance, (string)jkZdW8OtPxH6sOSMrbaR(scriptMethodInfo), parameters2, _003C_003Ec__DisplayClass10_._003CExecuteScript_003Eb__1);
						int num5 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7ed81ca3cf804abbade4684f28f485d1 == 0)
						{
							num5 = 0;
						}
						switch (num5)
						{
						case 0:
							break;
						}
					}
					catch (Exception ex)
					{
						int num6 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5d3bc916b5664717ac60544de077bd16 == 0)
						{
							num6 = 1;
						}
						while (true)
						{
							switch (num6)
							{
							case 1:
								gSJamyOtutwWltC40Uwt(ze3N4GOtXgs9KspsgOZv(), HLdQqWOtdqQXeBPccbg5(ma3qSVOm1CEGMRWXZDx2(-1430645277 ^ -1430540777), new object[1] { jkZdW8OtPxH6sOSMrbaR(scriptMethodInfo) }), ex);
								num6 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_60c5782a184b457aa78da2e5c62d4e27 == 0)
								{
									num6 = 0;
								}
								break;
							default:
								throw;
							}
						}
					}
					goto case 27;
				case 48:
					MapValuesFromBaseToOriginal(dataClass2, _003C_003Ec__DisplayClass10_.viewModelContext, list);
					num2 = 13;
					continue;
				case 49:
					egtB8iOtt5MFErMjN9fc(method, dataClass, new object[3]
					{
						bGJIT0Ot00ejh7ppE5Qo(viewModelMetadata2),
						bGJIT0Ot00ejh7ppE5Qo(propertyMetadata),
						AXHcHXOtmGDLNyDasr6g(x6aKpwOtyPhMHanHAb6H(baseScriptExecutionInfo))
					});
					num2 = 30;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e != 0)
					{
						num2 = 37;
					}
					continue;
				case 5:
					workflowTaskBase = workflowTaskBaseManager.Load(((ModelInfo)VqyQmFOmxBOFXeyP4ywp(_003C_003Ec__DisplayClass10_.parameters)).SubTypeUid);
					num = 3;
					break;
				case 52:
					dataClass = (DataClass)DeserializeViewModelContext(_003C_003Ec__DisplayClass10_.parameters.Model, (DataClassMetadata)M1ACqqOtOTtl3TOVN69q(rgH7NeOtJo3uDjZ9menD(baseScriptExecutionInfo)), type);
					num2 = 7;
					continue;
				case 25:
				case 37:
					list.AddRange(baseScriptExecutionInfo.Includes);
					num2 = 16;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_60c5782a184b457aa78da2e5c62d4e27 != 0)
					{
						num2 = 7;
					}
					continue;
				case 42:
					if (M1ACqqOtOTtl3TOVN69q(context) == null)
					{
						FL2M8HOtcO6khS1yvTrH(securityService, new Action(_003C_003Ec__DisplayClass10_._003CExecuteScript_003Eb__0));
						num2 = 54;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_abfb511163674a3eae959fd60da8f319 != 0)
						{
							num2 = 24;
						}
					}
					else
					{
						num2 = 29;
					}
					continue;
				case 51:
					_003C_003Ec__DisplayClass10_ = new _003C_003Ec__DisplayClass10_0();
					num2 = 50;
					continue;
				case 28:
					if (_003C_003Ec__DisplayClass10_.propertyContainer == null)
					{
						num2 = 39;
						continue;
					}
					goto case 31;
				case 11:
				{
					ScriptExecutionResult scriptExecutionResult2 = new ScriptExecutionResult();
					G6NB31OtBTdk2FGiUX7O(scriptExecutionResult2, dataClass2);
					vIn09dOtfvuaUCZ4VcB7(scriptExecutionResult2, _003C_003Ec__DisplayClass10_.item);
					j1jRKGOt9e9A6QxNRYOC(scriptExecutionResult2, _003C_003Ec__DisplayClass10_.propertyContainer);
					scriptExecutionResult2.ReturnValue = returnValue;
					return scriptExecutionResult2;
				}
				case 44:
					_003C_003Ec__DisplayClass10_.viewModelContext = dataClass2;
					num2 = 38;
					continue;
				case 22:
					try
					{
						while (true)
						{
							IL_0919:
							int num3;
							if (!B9R2umOtHFDv6fVnRRvV(enumerator))
							{
								num3 = 6;
								goto IL_083e;
							}
							goto IL_08a5;
							IL_083e:
							while (true)
							{
								switch (num3)
								{
								case 4:
									current.Settings = typeSettings;
									num3 = 5;
									continue;
								case 3:
									typeSettings = (TypeSettings)HcRW1EOtnuuTSKQtgWcg(workflowInstanceContext, CO3wZsOtDiKXY3hWWILh(current));
									num3 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae2bde9e5844c638021cdb56fc01122 == 0)
									{
										num3 = 0;
									}
									continue;
								case 7:
									break;
								case 2:
									if (current == null)
									{
										num3 = 1;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2f119e188994b55be2499c193b880fb == 0)
										{
											num3 = 0;
										}
										continue;
									}
									goto case 3;
								default:
									if (typeSettings != null)
									{
										num3 = 4;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d87d9a74c9e14f96a288cc3620965fe0 != 0)
										{
											num3 = 1;
										}
										continue;
									}
									goto IL_0919;
								case 1:
								case 5:
									goto IL_0919;
								case 6:
									goto end_IL_0919;
								}
								break;
							}
							goto IL_08a5;
							IL_08a5:
							current = enumerator.Current;
							num3 = 2;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d == 0)
							{
								num3 = 2;
							}
							goto IL_083e;
							continue;
							end_IL_0919:
							break;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							int num4 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1b8b735647da470aa2d45d64d6f538d1 != 0)
							{
								num4 = 0;
							}
							while (true)
							{
								switch (num4)
								{
								default:
									enumerator.Dispose();
									num4 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea == 0)
									{
										num4 = 1;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
					goto case 21;
				case 2:
					propertyMetadata = viewModelMetadata2.Properties.First(delegate(PropertyMetadata q)
					{
						//Discarded unreachable code: IL_0052, IL_0061
						int num7 = 2;
						int num8 = num7;
						while (true)
						{
							switch (num8)
							{
							case 2:
								if (!_003C_003Ec.yC5lFwvZGYK5o6BnypfB(q))
								{
									num8 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 != 0)
									{
										num8 = 1;
									}
									break;
								}
								goto default;
							default:
								return _003C_003Ec.hTIBYFvZoNroyiSejPXm(_003C_003Ec.S91av9vZ7f9y4j0pDKhF(q), _003C_003Ec.fwf2t9vZ2q9uQlMwbk7R(0xA7339EE ^ 0xA72857A));
							case 1:
								return false;
							}
						}
					});
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e4c570270f54493d8f3f4763a72f63f7 == 0)
					{
						num2 = 49;
					}
					continue;
				case 23:
					eqlPropertiesService.SetEqlComputedProperties(_003C_003Ec__DisplayClass10_.viewModelContext, viewModelMetadata, ((IEnumerable<SerializedModel>)VhcrYeOt5Te7gcq2mnZJ(_003C_003Ec__DisplayClass10_.parameters)).Select(delegate(SerializedModel s)
					{
						SerializedModel serializedModel = new SerializedModel();
						_003C_003Ec.yBnxyGvZFs0bp1pDYrDu(serializedModel, s.Model);
						serializedModel.Name = (string)_003C_003Ec.hkoMalvZiKMpGk9LMl9W(s);
						return serializedModel;
					}).ToList());
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe7a0ffe67e4fea8e329ae6574ed2ca == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
		}
	}

	private static BaseScriptExecutionInfo GetScriptExecutionInfo(object workflowTask, Guid metadataUid)
	{
		//Discarded unreachable code: IL_00ef, IL_018f, IL_0298, IL_02a7, IL_02da, IL_02e9, IL_0307
		int num = 6;
		BaseScriptExecutionInfo baseScriptExecutionInfo = default(BaseScriptExecutionInfo);
		IWorkflowProcess workflowProcess = default(IWorkflowProcess);
		IWorkflowInstance workflowInstance = default(IWorkflowInstance);
		IWorkflowInstance parentInstance = default(IWorkflowInstance);
		IWorkflowInstance workflowInstance2 = default(IWorkflowInstance);
		DataClassMetadata dataClassMetadata = default(DataClassMetadata);
		IWorkflowProcess process = default(IWorkflowProcess);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 8:
					baseScriptExecutionInfo.ProcessContext = (ProcessContext)s6fJjeOtjcl1YuZUkWBi(workflowProcess);
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1c37d4e24e094858975336738e156495 == 0)
					{
						num2 = 0;
					}
					continue;
				case 6:
					workflowInstance = (IWorkflowInstance)dDio1POmzBArgFGkMnlD(V001PoOm4wJTm8tHbngu(workflowTask));
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_26fa47f5bd8343debcae8b05a56a3ab5 == 0)
					{
						num2 = 5;
					}
					continue;
				case 18:
					parentInstance = workflowInstance2.ParentInstance;
					num2 = 15;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6dd19c81ff5e41fb8db9b50574437301 != 0)
					{
						num2 = 14;
					}
					continue;
				case 13:
					baseScriptExecutionInfo.Includes.Add(dataClassMetadata);
					num2 = 19;
					continue;
				case 14:
				case 21:
					return null;
				case 16:
					baseScriptExecutionInfo = new BaseScriptExecutionInfo();
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 == 0)
					{
						num2 = 3;
					}
					continue;
				default:
					workflowInstance2 = parentInstance;
					num2 = 10;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c559093b7320494babd70d164a6df42d == 0)
					{
						num2 = 3;
					}
					continue;
				case 5:
					break;
				case 3:
					if (dataClassMetadata == null)
					{
						num2 = 2;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5537a063960e465db83a04e35eea441b == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 13;
				case 22:
					return baseScriptExecutionInfo;
				case 9:
				case 10:
					if (WyppieOtqL9J8vyHffy0(workflowInstance2) == null)
					{
						num2 = 22;
						continue;
					}
					goto case 18;
				case 20:
					if (!IlLclbOmhusLCF24GymL(metadataUid, Guid.Empty))
					{
						num2 = 7;
						continue;
					}
					goto case 14;
				case 7:
					if (IlLclbOmhusLCF24GymL(bGJIT0Ot00ejh7ppE5Qo(M1ACqqOtOTtl3TOVN69q(s6fJjeOtjcl1YuZUkWBi(((IProcessHeader)fcXhXsOtWtqrdP1Xaait(process)).Current))), metadataUid))
					{
						num2 = 21;
						continue;
					}
					goto case 12;
				case 17:
					dataClassMetadata = (DataClassMetadata)M1ACqqOtOTtl3TOVN69q(s6fJjeOtjcl1YuZUkWBi(BEGCBlOtRNyPXZTHWZU3(fcXhXsOtWtqrdP1Xaait(workflowProcess))));
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 != 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					ibAWFMOt6TwerV1ruLGG(baseScriptExecutionInfo, parentInstance);
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea != 0)
					{
						num2 = 11;
					}
					continue;
				case 12:
					if (workflowInstance.ParentInstance != null)
					{
						num2 = 16;
						continue;
					}
					goto case 14;
				case 19:
					if (!IlLclbOmhusLCF24GymL(bGJIT0Ot00ejh7ppE5Qo(dataClassMetadata), metadataUid))
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1c37d4e24e094858975336738e156495 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 8;
				case 15:
					workflowProcess = (IWorkflowProcess)GgApgrOtKbT0r7JDvV9d(parentInstance);
					num2 = 17;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c559093b7320494babd70d164a6df42d == 0)
					{
						num2 = 10;
					}
					continue;
				case 4:
					workflowInstance2 = workflowInstance;
					num2 = 9;
					continue;
				}
				break;
			}
			process = workflowInstance.Process;
			num = 20;
		}
	}

	private static Assembly GetScriptAssembly(object currentProcess)
	{
		//Discarded unreachable code: IL_0073, IL_0082, IL_00a8
		int num = 4;
		IWorkflowProcess workflowProcess = default(IWorkflowProcess);
		Assembly assembly = default(Assembly);
		ScriptModule scriptModule = default(ScriptModule);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 10:
					workflowProcess = workflowProcess.Parent;
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_978f838cc41a4debb9700ede4b63f820 == 0)
					{
						num2 = 1;
					}
					continue;
				case 2:
					return assembly;
				case 1:
				case 6:
					if (workflowProcess.Parent != null)
					{
						num2 = 9;
						continue;
					}
					break;
				case 7:
				case 9:
					scriptModule = (ScriptModule)DTNU5AOt3GlGT4xC5xeh(BZVO5rOtTwEOWlU8tkpR(workflowProcess));
					num2 = 10;
					continue;
				case 8:
					if (assembly == null)
					{
						num2 = 2;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 != 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 2;
				case 3:
					scriptModule = (ScriptModule)DTNU5AOt3GlGT4xC5xeh(workflowProcess);
					num2 = 6;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3b4403f77a00495e957e5e4a6840e5d3 != 0)
					{
						num2 = 3;
					}
					continue;
				case 4:
					workflowProcess = (IWorkflowProcess)currentProcess;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a27e75af798c48d692c4325f43aa9e6b != 0)
					{
						num2 = 3;
					}
					continue;
				case 5:
					goto end_IL_0012;
				}
				assembly = ComponentManager.FindLoadedAssembly((string)zQacosOtQh1q50PSTmHO(scriptModule), isFullName: false);
				num2 = 7;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7de614af35034bd0a6867d08a2ee4a84 == 0)
				{
					num2 = 8;
				}
				continue;
				end_IL_0012:
				break;
			}
			assembly = ComponentManager.LoadAssembly((byte[])x6JfdvOtpkn1wnOa3dSi(scriptModule), (byte[])HPudqaOtCj0uju51y7Gw(scriptModule));
			num = 2;
		}
	}

	private static Type GetViewModelType(object assembly, object contextName)
	{
		int num = 1;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 1:
				text = (string)WwXdkgOtMnp3MGjjMt4T(ma3qSVOm1CEGMRWXZDx2(0x6871CA ^ 0x69C648), contextName, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1EA50FCC ^ 0x1EA4B870));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a27e75af798c48d692c4325f43aa9e6b == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return Thi9SgOtkQRa7tADEYVl(assembly, text);
			}
		}
	}

	private static Type GetViewModelContextType(object assembly, object contextName)
	{
		int num = 1;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				return Thi9SgOtkQRa7tADEYVl(assembly, text);
			case 1:
				text = (string)XNo7UEOtUyHxNLUj4BTs(ma3qSVOm1CEGMRWXZDx2(0x101D10F ^ 0x1006D41), ma3qSVOm1CEGMRWXZDx2(-947937941 ^ -948041693), contextName, ma3qSVOm1CEGMRWXZDx2(0x4940763B ^ 0x4941C1C1));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3bb28bf622874b4689f9265e58d14823 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private static void MapValuesFromBaseToOriginal(object originalViewModelContext, object baseViewModelContext, List<DataClassMetadata> includes)
	{
		if ((DataClass)originalViewModelContext == null || (DataClass)baseViewModelContext == null)
		{
			return;
		}
		MethodInfo method = baseViewModelContext.GetType().GetMethod(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x42311138 ^ 0x4230AD46), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
		MethodInfo method2 = originalViewModelContext.GetType().GetMethod(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-43932417 ^ -44032169), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
		if (method == null || method2 == null)
		{
			return;
		}
		foreach (DataClassMetadata include in includes)
		{
			foreach (PropertyMetadata property in include.Properties)
			{
				if (!(property.Name == SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x141C968 ^ 0x14075FC)))
				{
					object obj = method.Invoke(baseViewModelContext, new object[2] { include.Uid, property.Uid });
					method2.Invoke(originalViewModelContext, new object[3] { include.Uid, property.Uid, obj });
				}
			}
		}
	}

	private object DeserializeViewModelContext(string model, DataClassMetadata viewModelContextMetadata, Type viewModelContextType)
	{
		int num = 1;
		int num2 = num;
		ExpandoObject value = default(ExpandoObject);
		_003C_003Ec__DisplayClass16_0 _003C_003Ec__DisplayClass16_ = default(_003C_003Ec__DisplayClass16_0);
		Type type = default(Type);
		while (true)
		{
			switch (num2)
			{
			case 7:
				value = (ExpandoObject)NEmNstOtIHtSFJHhcvec(new EntityJsonSerializer(), model);
				num2 = 6;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass16_ = new _003C_003Ec__DisplayClass16_0();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_85ba8d91af394836ac86666c40b1e150 != 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				FL2M8HOtcO6khS1yvTrH(securityService, new Action(_003C_003Ec__DisplayClass16_._003CDeserializeViewModelContext_003Eb__0));
				num2 = 9;
				break;
			case 3:
				_003C_003Ec__DisplayClass16_.requestMetadata = new ClassMetadata();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 == 0)
				{
					num2 = 4;
				}
				break;
			case 6:
				_003C_003Ec__DisplayClass16_.dict = new Dictionary<string, object> { 
				{
					(string)ma3qSVOm1CEGMRWXZDx2(-790221436 ^ -790129254),
					value
				} };
				num2 = 5;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a23e27b648a042f098a477c26c4beed1 == 0)
				{
					num2 = 4;
				}
				break;
			case 4:
			{
				_003C_003Ec__DisplayClass16_0 _003C_003Ec__DisplayClass16_2 = _003C_003Ec__DisplayClass16_;
				PropertyMetadata propertyMetadata = new PropertyMetadata();
				eG7XWTOtG8p2KO7d4V50(propertyMetadata, ma3qSVOm1CEGMRWXZDx2(-130098986 ^ -130064184));
				kkM1BvOt2q1yTd5g6VLX(propertyMetadata, geU8BYOt75aeEpPAjVwm(viewModelDescriptor));
				jCQeKjOto9rkyBg2I0Hw(propertyMetadata, bGJIT0Ot00ejh7ppE5Qo(viewModelContextMetadata));
				DataClassSettings dataClassSettings = new DataClassSettings();
				TnvGuHOtFVDFg3jBBWvK(dataClassSettings, RelationType.OneToOne);
				fkBgNHOti1dUxNqbhdBh(propertyMetadata, dataClassSettings);
				_003C_003Ec__DisplayClass16_2.paramPropertyMetadata = propertyMetadata;
				num2 = 7;
				break;
			}
			case 8:
				type = E1qaCNOtV0LZNOZsVVGb(typeof(ActionExecutionParamModel<>).TypeHandle).MakeGenericType(viewModelContextType);
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58fb165cafed422d973d4a7156526541 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				_003C_003Ec__DisplayClass16_._003C_003E4__this = this;
				num2 = 8;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a == 0)
				{
					num2 = 7;
				}
				break;
			case 2:
				_003C_003Ec__DisplayClass16_.functionRequest = (IActionExecutionParamModel)GiZFa6OtAfkAdpCHmm6N(type);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f91acf223c4b4303819d2f8f2fc6c8e1 == 0)
				{
					num2 = 3;
				}
				break;
			case 9:
				return AB3KZbOtaXVBfKqXLfyK(_003C_003Ec__DisplayClass16_.functionRequest);
			}
		}
	}

	private static object ProcessLegacySignature(Type type, object form, out PropertyViewInfoContainer propertyContainer)
	{
		int num = 1;
		int num2 = num;
		ClassMetadata classMetadata = default(ClassMetadata);
		while (true)
		{
			switch (num2)
			{
			default:
				propertyContainer = new PropertyViewInfoContainer(classMetadata);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b84ccb8b1bd147ef900b852047ecbf45 == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				classMetadata = MetadataLoader.LoadMetadata(type.GetGenericArguments()[0]) as ClassMetadata;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return QfkZ5YOtrXyNpE9ncSY3(type, new object[3] { form, classMetadata, propertyContainer });
			}
		}
	}

	private static object ProcessV2Signature(Type type, object form, Type viewModelType, object viewModelContext, out PropertyViewInfoContainer propertyContainer)
	{
		//Discarded unreachable code: IL_006d, IL_007c, IL_014a, IL_0159, IL_018b, IL_019a
		int num = 5;
		ClassMetadata classMetadata = default(ClassMetadata);
		Type baseType = default(Type);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 8:
					propertyContainer = new PropertyViewInfoContainer(classMetadata);
					num = 7;
					break;
				default:
					if (vMmi2DOteGALpiksE9va(baseType, null))
					{
						num = 10;
						break;
					}
					goto case 3;
				case 7:
					if (!MCpRkqOtSTUOl862CKrK(type, viewModelType))
					{
						num2 = 9;
						continue;
					}
					goto case 11;
				case 3:
					if (!ts9p8MOtNAc7u3Yr1ypk(baseType))
					{
						num2 = 2;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f2d402219199402696ade21eab23d086 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 12;
				case 2:
				case 6:
				case 10:
					return null;
				case 1:
					classMetadata = f8CsrgOtx31cIZPbsFKY(baseType.GetGenericArguments()[0], true, true) as ClassMetadata;
					num2 = 8;
					continue;
				case 5:
					propertyContainer = null;
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2f119e188994b55be2499c193b880fb == 0)
					{
						num2 = 1;
					}
					continue;
				case 12:
					if (!((DataClass)viewModelContext == null))
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 2;
				case 4:
					baseType = type.BaseType;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b1ab9396b25b43af8f32e24b1948be96 == 0)
					{
						num2 = 0;
					}
					continue;
				case 11:
					return null;
				case 9:
					return g01yLaOt1AuB9CuAW1ah(Array.Find(type.GetConstructors(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic), (ConstructorInfo ctorInfo) => ctorInfo.GetParameters().Length == 4), new object[4] { viewModelContext, form, classMetadata, propertyContainer });
				}
				break;
			}
		}
	}

	private static bool CheckParameterType(Type parameterType)
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return vMmi2DOteGALpiksE9va(parameterType.GetGenericTypeDefinition(), E1qaCNOtV0LZNOZsVVGb(typeof(FormViewBuilder<>).TypeHandle));
			default:
				return false;
			case 1:
				if (!parameterType.IsGenericType)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8a6cf36da0b84f319a7cf27018f28f5b == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	internal static void KjBK7YOmNtVJF14ewedB()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool XxSSTQOmrrQiL1wyPqAe()
	{
		return iaNIZmOmaSUOffS34Onw == null;
	}

	internal static WorkflowScriptExecutionHandler YVdVtIOmeNaXOy0qNpKf()
	{
		return iaNIZmOmaSUOffS34Onw;
	}

	internal static object VqyQmFOmxBOFXeyP4ywp(object P_0)
	{
		return ((ScriptExecutionParams)P_0).ModelInfo;
	}

	internal static Guid PT67KCOmSs9LGNx8bwp0(object P_0)
	{
		return ((ModelInfo)P_0).TypeUid;
	}

	internal static object ma3qSVOm1CEGMRWXZDx2(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool IlLclbOmhusLCF24GymL(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static object Ag0uwuOmELFH8lsx72eW(object P_0)
	{
		return ((ScriptExecutionParams)P_0).ScriptName;
	}

	internal static object LPsNEYOmw52lTjTTOehl(object P_0)
	{
		return ScriptMethodInfoHelper.Deserialize((string)P_0);
	}

	internal static object V001PoOm4wJTm8tHbngu(object P_0)
	{
		return ((IWorkflowTaskBase)P_0).WorkflowBookmark;
	}

	internal static object dDio1POmzBArgFGkMnlD(object P_0)
	{
		return ((IWorkflowBookmark)P_0).Instance;
	}

	internal static object GgApgrOtKbT0r7JDvV9d(object P_0)
	{
		return ((IWorkflowInstance)P_0).Process;
	}

	internal static object M1ACqqOtOTtl3TOVN69q(object P_0)
	{
		return ((EntityMetadata)P_0).ViewModelMetadata;
	}

	internal static Guid Cw6RDwOtZcoXDLL4MV02(object P_0)
	{
		return ((ScriptMethodInfo)P_0).MetadataUid;
	}

	internal static object fL7k8aOtvylWvS1ap7iF(object P_0, Guid metadataUid)
	{
		return GetScriptExecutionInfo(P_0, metadataUid);
	}

	internal static object Amsbc6OtYTBc7QDlEoLd(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static Type RAMSjZOt8ZLtPjmgXeMl(object P_0, object P_1)
	{
		return GetViewModelContextType(P_0, P_1);
	}

	internal static object bSQUK1Otsx4fHetx6MQt(object P_0)
	{
		return ((ScriptExecutionParams)P_0).Model;
	}

	internal static object rgH7NeOtJo3uDjZ9menD(object P_0)
	{
		return ((BaseScriptExecutionInfo)P_0).ProcessContext;
	}

	internal static bool DrD8ZPOtlaA0pMR2VYRM(object P_0, object P_1)
	{
		return (MethodInfo)P_0 != (MethodInfo)P_1;
	}

	internal static Guid bGJIT0Ot00ejh7ppE5Qo(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static object x6aKpwOtyPhMHanHAb6H(object P_0)
	{
		return ((BaseScriptExecutionInfo)P_0).WorkflowInstance;
	}

	internal static object AXHcHXOtmGDLNyDasr6g(object P_0)
	{
		return ((IWorkflowInstance)P_0).Context;
	}

	internal static object egtB8iOtt5MFErMjN9fc(object P_0, object P_1, object P_2)
	{
		return ((MethodBase)P_0).Invoke(P_1, (object[])P_2);
	}

	internal static Type MLXSbyOtbXQoE1boSg69(object P_0, object P_1)
	{
		return GetViewModelType(P_0, P_1);
	}

	internal static object VhcrYeOt5Te7gcq2mnZJ(object P_0)
	{
		return ((ScriptExecutionParams)P_0).AdditionalModels;
	}

	internal static bool UmYKJWOtgQOrFlecH8Aw(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static void G6NB31OtBTdk2FGiUX7O(object P_0, object P_1)
	{
		((ScriptExecutionResult)P_0).Model = P_1;
	}

	internal static void FL2M8HOtcO6khS1yvTrH(object P_0, object P_1)
	{
		((ISecurityService)P_0).RunWithElevatedPrivilegiesAndWithDeleted((Action)P_1);
	}

	internal static object jkZdW8OtPxH6sOSMrbaR(object P_0)
	{
		return ((ScriptMethodInfo)P_0).Name;
	}

	internal static object ze3N4GOtXgs9KspsgOZv()
	{
		return Logger.Log;
	}

	internal static object HLdQqWOtdqQXeBPccbg5(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static void gSJamyOtutwWltC40Uwt(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static Guid CO3wZsOtDiKXY3hWWILh(object P_0)
	{
		return ((PropertyViewInfo)P_0).Uid;
	}

	internal static object HcRW1EOtnuuTSKQtgWcg(object P_0, Guid P_1)
	{
		return ((Entity<long>)P_0).LoadPropertyInstanceSettings(P_1);
	}

	internal static bool B9R2umOtHFDv6fVnRRvV(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static int NZtQFYOtLMcgjtMx7VAR(object P_0)
	{
		return ((List<DataClassMetadata>)P_0).Count;
	}

	internal static void vIn09dOtfvuaUCZ4VcB7(object P_0, object P_1)
	{
		((ScriptExecutionResult)P_0).Item = P_1;
	}

	internal static void j1jRKGOt9e9A6QxNRYOC(object P_0, object P_1)
	{
		((ScriptExecutionResult)P_0).PropertyContainer = (PropertyViewInfoContainer)P_1;
	}

	internal static object fcXhXsOtWtqrdP1Xaait(object P_0)
	{
		return ((IWorkflowProcess)P_0).Header;
	}

	internal static object s6fJjeOtjcl1YuZUkWBi(object P_0)
	{
		return ((IWorkflowProcess)P_0).Context;
	}

	internal static object BEGCBlOtRNyPXZTHWZU3(object P_0)
	{
		return ((IProcessHeader)P_0).Current;
	}

	internal static void ibAWFMOt6TwerV1ruLGG(object P_0, object P_1)
	{
		((BaseScriptExecutionInfo)P_0).WorkflowInstance = (IWorkflowInstance)P_1;
	}

	internal static object WyppieOtqL9J8vyHffy0(object P_0)
	{
		return ((IWorkflowInstance)P_0).ParentInstance;
	}

	internal static object DTNU5AOt3GlGT4xC5xeh(object P_0)
	{
		return ((IWorkflowProcess)P_0).ScriptModule;
	}

	internal static object BZVO5rOtTwEOWlU8tkpR(object P_0)
	{
		return ((IWorkflowProcess)P_0).Parent;
	}

	internal static object zQacosOtQh1q50PSTmHO(object P_0)
	{
		return ((ScriptModule)P_0).AssemblyName;
	}

	internal static object x6JfdvOtpkn1wnOa3dSi(object P_0)
	{
		return ((ScriptModule)P_0).AssemblyRaw;
	}

	internal static object HPudqaOtCj0uju51y7Gw(object P_0)
	{
		return ((ScriptModule)P_0).DebugRaw;
	}

	internal static object WwXdkgOtMnp3MGjjMt4T(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static Type Thi9SgOtkQRa7tADEYVl(object P_0, object P_1)
	{
		return ((Assembly)P_0).GetType((string)P_1);
	}

	internal static object XNo7UEOtUyHxNLUj4BTs(object P_0, object P_1, object P_2, object P_3)
	{
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	internal static Type E1qaCNOtV0LZNOZsVVGb(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object GiZFa6OtAfkAdpCHmm6N(Type P_0)
	{
		return Activator.CreateInstance(P_0);
	}

	internal static void eG7XWTOtG8p2KO7d4V50(object P_0, object P_1)
	{
		((NamedMetadata)P_0).Name = (string)P_1;
	}

	internal static Guid geU8BYOt75aeEpPAjVwm(object P_0)
	{
		return ((TypeDescriptor)P_0).Uid;
	}

	internal static void kkM1BvOt2q1yTd5g6VLX(object P_0, Guid P_1)
	{
		((PropertyMetadata)P_0).TypeUid = P_1;
	}

	internal static void jCQeKjOto9rkyBg2I0Hw(object P_0, Guid P_1)
	{
		((PropertyMetadata)P_0).SubTypeUid = P_1;
	}

	internal static void TnvGuHOtFVDFg3jBBWvK(object P_0, RelationType P_1)
	{
		((DataClassSettings)P_0).RelationType = P_1;
	}

	internal static void fkBgNHOti1dUxNqbhdBh(object P_0, object P_1)
	{
		((PropertyMetadata)P_0).Settings = (TypeSettings)P_1;
	}

	internal static object NEmNstOtIHtSFJHhcvec(object P_0, object P_1)
	{
		return ((EntityJsonSerializer)P_0).DeserializeJson((string)P_1);
	}

	internal static object AB3KZbOtaXVBfKqXLfyK(object P_0)
	{
		return ((IActionExecutionParamModel)P_0).Parameter;
	}

	internal static object QfkZ5YOtrXyNpE9ncSY3(Type P_0, object P_1)
	{
		return Activator.CreateInstance(P_0, (object[])P_1);
	}

	internal static bool vMmi2DOteGALpiksE9va(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static bool ts9p8MOtNAc7u3Yr1ypk(Type parameterType)
	{
		return CheckParameterType(parameterType);
	}

	internal static object f8CsrgOtx31cIZPbsFKY(Type P_0, bool P_1, bool P_2)
	{
		return MetadataLoader.LoadMetadata(P_0, P_1, P_2);
	}

	internal static bool MCpRkqOtSTUOl862CKrK(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static object g01yLaOt1AuB9CuAW1ah(object P_0, object P_1)
	{
		return ((ConstructorInfo)P_0).Invoke((object[])P_1);
	}
}
