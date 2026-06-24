using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.DynamicForms;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Locking;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Scripts.Entities;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Services.Scope;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Processes;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Services;

[Service(Type = ComponentType.Server, EnableInterceptors = true)]
public class WorkflowScriptingService : IWorkflowScriptingService
{
	private sealed class ScriptExecutionInfo
	{
		internal static object muKMRXANPaFArPUHOi8;

		public object ScriptInstance { get; }

		public MethodInfo MethodInfo { get; }

		public object ContextInstance { get; }

		public ScriptExecutionInfo(object scriptInstance, MethodInfo methodInfo, object contextInstance)
		{
			//Discarded unreachable code: IL_002a, IL_002f
			c18MCNAS3Gd07muMQNO();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_820de5fd03a94336b27530b7b54bc5b6 != 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					return;
				case 3:
					MethodInfo = methodInfo;
					num = 2;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_c3ae8e111f574ce9b09d9ed725c1ab53 != 0)
					{
						num = 2;
					}
					break;
				case 2:
					ContextInstance = contextInstance;
					num = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_9bbeebf035a641e28535eada260bd583 == 0)
					{
						num = 1;
					}
					break;
				default:
					ScriptInstance = scriptInstance;
					num = 3;
					break;
				}
			}
		}

		internal static void c18MCNAS3Gd07muMQNO()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
		}

		internal static bool GoAJKMAdxdog7YvZLW8()
		{
			return muKMRXANPaFArPUHOi8 == null;
		}

		internal static ScriptExecutionInfo aHioGJAjjfvUYoZOKuH()
		{
			return (ScriptExecutionInfo)muKMRXANPaFArPUHOi8;
		}
	}

	private static readonly ILogger WorkflowLog;

	private Dictionary<Guid, Type> registeredContextTypes;

	internal static WorkflowScriptingService TKYXQtogHsLu2ZNw4kC;

	public WorkflowInstanceContextService WorkflowInstanceContextService
	{
		[CompilerGenerated]
		get
		{
			return _003CWorkflowInstanceContextService_003Ek__BackingField;
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
					_003CWorkflowInstanceContextService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_9747bbf97f854087a2d2f13ea94f4085 == 0)
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

	public IExecutionScopeFactory ExecutionScopeFactory
	{
		[CompilerGenerated]
		get
		{
			return _003CExecutionScopeFactory_003Ek__BackingField;
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
					_003CExecutionScopeFactory_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_66cfffef200f40f698da30612ad0e4fb == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ILockKeyFactory LockKeyFactory
	{
		[CompilerGenerated]
		get
		{
			return _003CLockKeyFactory_003Ek__BackingField;
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
					_003CLockKeyFactory_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_0b98e2160a714197bf0d3d74d55d90bc == 0)
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

	public object GetScriptInstance(IWorkflowInstance instance)
	{
		int num = 1;
		int num2 = num;
		string error = default(string);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return b8jcSF3F1LIfG0pIYHd(GetScriptExecutionInfo(instance, string.Empty, error));
			case 1:
				ITqeNY3XSjyBStocjjX((IInternalProcessesService)eJrmb83CSK4ohl4o7sa((ILicensedModuleAssembly)((IModuleManager)k6r6rkozxfyRwRKwoPx(t5uABKoZ2V2VsZC8vVE())).FindUnitByUid(vmySwg3Eh8oBaV1uQ5D())));
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_bbeafe91b1c448baa8c5cf2ab0baaadd != 0)
				{
					num2 = 0;
				}
				continue;
			}
			error = (string)PSanEj3xRJUkoPXhmYT(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-693602260 ^ -693608710), new object[2]
			{
				zQldom3h6bdEfwE1QH0(kAbgMl33WWWI3iZy3Ih(aGJBj23oS9pi3VEPjjE(instance))),
				instance.Id
			});
			num2 = 0;
			if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e45b9499c327415a9efec43f507582e4 != 0)
			{
				num2 = 2;
			}
		}
	}

	public object ExecuteScript(IWorkflowInstance instance, string scriptName, Dictionary<string, object> parameters = null, Func<string, Type, object> parameterAccessor = null)
	{
		Contract.ArgumentNotNull(instance, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-351702578 ^ -351709548));
		Contract.ArgumentNotNull(instance.Process, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3C126B81 ^ 0x3C124CEF));
		Contract.ArgumentNotNull(instance.Process.ScriptModule, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x33BD2188 ^ 0x33BD061A));
		((IInternalProcessesService)((ILicensedModuleAssembly)ComponentManager.Current.ModuleManager.FindUnitByUid(__AssemblyInfo.UID)).LicenseUnit).Check();
		DateTime now = DateTime.Now;
		string text = SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x33BD2188 ^ 0x33BD0658), SR.T(instance.Process.Name), instance.Id);
		Logger.Log.Debug(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-869419654 ^ -869425886), scriptName, SR.T(instance.Process.Name), instance.Id));
		try
		{
			ScriptExecutionInfo scriptExecutionInfo;
			try
			{
				scriptExecutionInfo = GetScriptExecutionInfo(instance, scriptName, text);
			}
			catch (Exception innerException)
			{
				throw new ScriptExecuteException(text + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-275456087 ^ -275463369)), innerException);
			}
			if (scriptExecutionInfo == null || scriptExecutionInfo.MethodInfo == null)
			{
				return null;
			}
			object result = ExecuteScript(text, scriptExecutionInfo, instance, parameters, parameterAccessor);
			Logger.Log.Debug(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-30505303 ^ -30500443));
			WorkflowLog.Debug(FormatLogMessage(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-465190147 ^ -465183277), instance, now, scriptName));
			return result;
		}
		catch (ScriptExecuteException exception)
		{
			Logger.Log.Error(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-465190147 ^ -465183309), exception);
			throw;
		}
		catch (Exception ex)
		{
			Logger.Log.Error(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-905209456 ^ -905214242), ex);
			throw new ScriptExecuteException(text, ex);
		}
	}

	private static string FormatLogMessage(object name, object instance, DateTime start, string message = null)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				SWBclr3wjtU9Pw045o1(instance, KGlBRX386BGALJkpgKe(0x927D360 ^ 0x927F43A));
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_405af183be2449cfa4440c68827d6de9 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return (string)InK2fj3QFqIhVyostoj(new object[9]
				{
					name,
					KGlBRX386BGALJkpgKe(-2144947971 ^ -2144948345),
					SR.T(((IWorkflowProcess)aGJBj23oS9pi3VEPjjE(instance)).Name),
					KGlBRX386BGALJkpgKe(-1015538293 ^ -1015545333),
					MpHbMG3tRTRrce4gNvM(instance),
					KGlBRX386BGALJkpgKe(-1587393812 ^ -1587391132),
					(!string.IsNullOrEmpty(message)) ? acqN7o3sfNi2rCBgMTY(message, KGlBRX386BGALJkpgKe(-1197637235 ^ -1197629927)) : "",
					(int)qjqN8B3qUeefjvEHaPK(txdNrp32MyBEPZ6lb1e(), start).TotalMilliseconds,
					KGlBRX386BGALJkpgKe(-465190147 ^ -465183389)
				});
			}
		}
	}

	private ScriptExecutionInfo GetScriptExecutionInfo(IWorkflowInstance instance, string scriptName, string error, List<Type> viewedTypes = null)
	{
		IWorkflowProcess process = instance.Process;
		Assembly scriptModuleAssembly = GetScriptModuleAssembly(process, error);
		ScriptModule scriptModule = process.ScriptModule;
		string name = scriptModule.Namespace + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x713816B4 ^ 0x71380A88) + scriptModule.ClassName;
		Type type;
		try
		{
			type = scriptModuleAssembly.GetType(name);
		}
		catch (Exception innerException)
		{
			throw new ScriptExecuteException(error + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1015538293 ^ -1015543981) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-7731921 ^ -7726739)), innerException);
		}
		if (type == null)
		{
			throw new ScriptExecuteException(error + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1060279669 ^ 0x3F328FAD) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3F8E27D0 ^ 0x3F8E3B92)));
		}
		MethodInfo methodInfo = null;
		if (!string.IsNullOrEmpty(scriptName))
		{
			methodInfo = GetMethodInfo(error, type, scriptName, throwOnNotFound: false);
			if (methodInfo == null)
			{
				if (viewedTypes == null)
				{
					viewedTypes = new List<Type>();
				}
				viewedTypes.Add(type);
				if (instance.ParentInstance == null)
				{
					foreach (Type viewedType in viewedTypes)
					{
						ScriptExecutionService.MethodNotFound(viewedType, scriptName);
					}
					return null;
				}
				return GetScriptExecutionInfo(instance.ParentInstance, scriptName, error, viewedTypes);
			}
		}
		object scriptInstance;
		try
		{
			scriptInstance = CreateScriptInstance(type);
		}
		catch (Exception innerException2)
		{
			throw new ScriptExecuteException(error + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xB84E87 ^ 0xB8545F) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xB863F17 ^ 0xB862389)), innerException2);
		}
		return new ScriptExecutionInfo(scriptInstance, methodInfo, instance.Context);
	}

	private static MethodInfo GetMethodInfo(object errorTitle, Type type, object scriptName, bool throwOnNotFound)
	{
		//Discarded unreachable code: IL_00e4, IL_0163, IL_016d, IL_01d5, IL_02d2, IL_02e5, IL_03bd, IL_0483, IL_04d2, IL_051d, IL_052c
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass18_0 _003C_003Ec__DisplayClass18_ = default(_003C_003Ec__DisplayClass18_0);
		MethodInfo methodInfo = default(MethodInfo);
		string text = default(string);
		List<MethodInfo>.Enumerator enumerator = default(List<MethodInfo>.Enumerator);
		_003C_003Ec__DisplayClass18_1 _003C_003Ec__DisplayClass18_2 = default(_003C_003Ec__DisplayClass18_1);
		MethodInfo current = default(MethodInfo);
		List<string> values = default(List<string>);
		string text3 = default(string);
		string name = default(string);
		while (true)
		{
			switch (num2)
			{
			case 2:
				_003C_003Ec__DisplayClass18_ = new _003C_003Ec__DisplayClass18_0();
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2d82a778b0ee4fc0915a368d2259a8f3 == 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				if (kKQVny34Tt4KF3bSTE5(methodInfo, null))
				{
					num2 = 6;
					break;
				}
				text = (string)errorTitle + (string)PSanEj3xRJUkoPXhmYT(KGlBRX386BGALJkpgKe(0x5DD795B3 ^ 0x5DD7B585), new object[1] { _003C_003Ec__DisplayClass18_.scriptName });
				num2 = 5;
				break;
			case 3:
				throw new ScriptExecuteException(text);
			case 7:
				try
				{
					string text2 = ((IEnumerable<string>)nSaDUk3VF6gKC1CRhBQ(_003C_003Ec__DisplayClass18_.scriptName, new string[1] { (string)KGlBRX386BGALJkpgKe(0x234241C0 ^ 0x23425E54) }, StringSplitOptions.None)).First();
					int num3 = 7;
					while (true)
					{
						MethodInfo methodInfo2;
						switch (num3)
						{
						default:
							goto end_IL_00e8;
						case 8:
							enumerator = type.GetMethods().ToList().Where(_003C_003Ec__DisplayClass18_2._003CGetMethodInfo_003Eb__1)
								.ToList()
								.GetEnumerator();
							num3 = 2;
							continue;
						case 2:
							try
							{
								while (true)
								{
									IL_0197:
									int num4;
									if (!enumerator.MoveNext())
									{
										num4 = 3;
										if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_405af183be2449cfa4440c68827d6de9 != 0)
										{
											num4 = 3;
										}
										goto IL_0171;
									}
									goto IL_01bd;
									IL_01bd:
									current = enumerator.Current;
									num4 = 5;
									goto IL_0171;
									IL_0171:
									while (true)
									{
										switch (num4)
										{
										case 6:
											goto IL_0197;
										case 2:
											goto IL_01bd;
										case 0:
											break;
										case 1:
											methodInfo = current;
											num4 = 0;
											if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_405af183be2449cfa4440c68827d6de9 == 0)
											{
												num4 = 0;
											}
											continue;
										case 4:
											if (!JermOU3aLBuKuLc7OLI(string.Format((string)KGlBRX386BGALJkpgKe(--286570904 ^ 0x1114A62C), yC0LXI3MbQgYAJPUCFM(current), string.Join((string)KGlBRX386BGALJkpgKe(-478552651 ^ -478559691), values)), text2))
											{
												num4 = 1;
												if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_a9f4f79195cf4308a30b686c5cb386e5 == 0)
												{
													num4 = 1;
												}
												continue;
											}
											goto IL_0197;
										case 5:
											values = current.GetParameters().Select(delegate(ParameterInfo q)
											{
												int num7 = 1;
												int num8 = num7;
												string text4 = default(string);
												while (true)
												{
													switch (num8)
													{
													default:
														return (string)_003C_003Ec.S0JvwYAuGRuE9RcRHyp(text4, 1, _003C_003Ec.jGU1lhAimEPxSpguKDW(text4) - 2);
													case 1:
														text4 = (string)_003C_003Ec.Dms4w1AeVDdBo9xCE41(q.ParameterType);
														num8 = 0;
														if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_cc6425824e2145d58580462376bc9992 == 0)
														{
															num8 = 0;
														}
														break;
													}
												}
											}).ToList();
											num4 = 1;
											if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_b54291e8d6924fb3b3fee419f778cbd9 != 0)
											{
												num4 = 4;
											}
											continue;
										case 3:
											break;
										}
										break;
									}
									break;
								}
							}
							finally
							{
								((IDisposable)enumerator).Dispose();
								int num5 = 0;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_f679e84d83df40c6973457c358e7e4e4 == 0)
								{
									num5 = 0;
								}
								switch (num5)
								{
								case 0:
									break;
								}
							}
							goto case 6;
						case 4:
							methodInfo2 = type.GetMethod(text2);
							if ((object)methodInfo2 == null)
							{
								num3 = 12;
								continue;
							}
							break;
						case 3:
							_003C_003Ec__DisplayClass18_2 = new _003C_003Ec__DisplayClass18_1();
							num3 = 9;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_820de5fd03a94336b27530b7b54bc5b6 == 0)
							{
								num3 = 13;
							}
							continue;
						case 13:
							text3 = text2.Substring(bKuZML3KTioJFdwWn7P(text2, '(') + 1).Replace((string)KGlBRX386BGALJkpgKe(0x4CBDA8D5 ^ 0x4CBDB77B), "");
							num3 = 7;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e496a9998cf542ff98d1a5e001d6c664 == 0)
							{
								num3 = 10;
							}
							continue;
						case 10:
							_003C_003Ec__DisplayClass18_2.parametersList = ((IEnumerable<string>)nSaDUk3VF6gKC1CRhBQ(text3, new string[1] { (string)KGlBRX386BGALJkpgKe(-402075023 ^ -402076175) }, StringSplitOptions.None)).ToList();
							num3 = 8;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_122c98752b3a49d0ab2b48b3f7a3ed7e == 0)
							{
								num3 = 8;
							}
							continue;
						case 9:
							goto end_IL_00e8;
						case 11:
							name = (string)vjAET23PGaKvi722hAW(text2, 0, jsg2KQ3vNYMs1JXL5Oh(text2, KGlBRX386BGALJkpgKe(0x33BD2188 ^ 0x33BD3E20), StringComparison.Ordinal));
							num3 = 1;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_f44d857a149741d8874c141a12a734dc == 0)
							{
								num3 = 1;
							}
							continue;
						case 7:
							if (!GXfiRP3DURxMKK511Qw(text2, KGlBRX386BGALJkpgKe(0x27475F40 ^ 0x274740E8)))
							{
								num3 = 4;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3cf4c0e592254156b9e651c03075f59e == 0)
								{
									num3 = 4;
								}
								continue;
							}
							goto case 3;
						case 1:
							methodInfo = type.GetMethod(name);
							num3 = 0;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_5581cf8fc5c14768be6f13345a9a04e1 == 0)
							{
								num3 = 0;
							}
							continue;
						case 6:
							if (!McOE2F3YrT6sjX7aMFb(methodInfo, null))
							{
								num3 = 5;
								continue;
							}
							goto case 11;
						case 5:
							goto end_IL_00e8;
						case 12:
							methodInfo2 = type.GetMethods().FirstOrDefault(_003C_003Ec__DisplayClass18_._003CGetMethodInfo_003Eb__0);
							break;
						case 0:
							goto end_IL_00e8;
						}
						methodInfo = methodInfo2;
						num3 = 9;
						continue;
						end_IL_00e8:
						break;
					}
				}
				catch (Exception innerException)
				{
					int num6 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_f1ba867523264a63932ee1e8d0cd4a24 != 0)
					{
						num6 = 0;
					}
					switch (num6)
					{
					default:
						throw new ScriptExecuteException((string)acqN7o3sfNi2rCBgMTY(errorTitle, PSanEj3xRJUkoPXhmYT(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-416187968 ^ -416193016), new object[1] { _003C_003Ec__DisplayClass18_.scriptName })), innerException);
					}
				}
				goto case 4;
			case 6:
				return methodInfo;
			case 1:
				_003C_003Ec__DisplayClass18_.scriptName = (string)scriptName;
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_94abcc9c95ac4ce4baec9537ccf1485a != 0)
				{
					num2 = 0;
				}
				break;
			case 8:
				return null;
			case 5:
				if (!throwOnNotFound)
				{
					OkpgKs3TOKiVn7cxjo8(CZTU0339cWZf7mK6mjo(), text);
					num2 = 8;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_f44d857a149741d8874c141a12a734dc == 0)
					{
						num2 = 8;
					}
				}
				else
				{
					num2 = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_0b98e2160a714197bf0d3d74d55d90bc == 0)
					{
						num2 = 3;
					}
				}
				break;
			default:
				methodInfo = null;
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_5e3789bc3f974f489e0b5a0c8243b85d == 0)
				{
					num2 = 7;
				}
				break;
			}
		}
	}

	private static string GetTypeInfo(Type type)
	{
		//Discarded unreachable code: IL_0061, IL_0070, IL_007f, IL_00af, IL_0110, IL_011f
		int num = 9;
		int num3 = default(int);
		Type type2 = default(Type);
		Type[] genericArguments = default(Type[]);
		List<string> list = default(List<string>);
		string text = default(string);
		string result = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 10:
					num3++;
					num2 = 2;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_d526d6cd8ea24dfca60f96f0f0be6307 == 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
				case 5:
					type2 = genericArguments[num3];
					num = 4;
					break;
				case 2:
				case 11:
					if (num3 < genericArguments.Length)
					{
						num2 = 1;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_4db1e829bcb046ad87c01fa1925cdfce == 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 6;
				case 4:
					list.Add((string)jVTc7i3ccg40Ju4RCg7(type2));
					num2 = 10;
					continue;
				case 6:
					text = string.Join((string)KGlBRX386BGALJkpgKe(-7731921 ^ -7723685), list);
					num = 14;
					break;
				default:
					result = string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-481953825 ^ -481962171), type.Namespace, yC0LXI3MbQgYAJPUCFM(type));
					num2 = 15;
					continue;
				case 14:
					result = (string)gxON5K3NFDQvAH7yQow(KGlBRX386BGALJkpgKe(0x7AADECE0 ^ 0x7AADCC9A), type.Namespace, yC0LXI3MbQgYAJPUCFM(type), text);
					num2 = 3;
					continue;
				case 7:
					list = new List<string>();
					num2 = 13;
					continue;
				case 9:
					if (!type.IsGenericType)
					{
						num2 = 8;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_ff730ec99c9d438e9ab033b91102c6e4 != 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 7;
				case 12:
					num3 = 0;
					num2 = 9;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_128870479a48410393b814985ef83c9e == 0)
					{
						num2 = 11;
					}
					continue;
				case 13:
					genericArguments = type.GetGenericArguments();
					num2 = 12;
					continue;
				case 3:
				case 15:
					return result;
				}
				break;
			}
		}
	}

	private static object ExecuteScript(object errorTitle, object methodInfo, object scriptInstance, object instance, object context, Dictionary<string, object> parameters, Func<string, Type, object> parameterAccessor)
	{
		ScriptExecutionInfo scriptExecutionInfo = new ScriptExecutionInfo(scriptInstance, (MethodInfo)methodInfo, context);
		return ExecuteScript(errorTitle, scriptExecutionInfo, instance, parameters, parameterAccessor);
	}

	private static object ExecuteScript(object errorTitle, object scriptExecutionInfo, object instance, Dictionary<string, object> parameters, Func<string, Type, object> parameterAccessor)
	{
		object contextInstance = ((ScriptExecutionInfo)scriptExecutionInfo).ContextInstance;
		MethodInfo methodInfo = ((ScriptExecutionInfo)scriptExecutionInfo).MethodInfo;
		object scriptInstance = ((ScriptExecutionInfo)scriptExecutionInfo).ScriptInstance;
		parameters = parameters ?? new Dictionary<string, object>();
		parameters[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-254800515 ^ -254800585)] = contextInstance;
		parameters[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1803374629 ^ -1803383021)] = instance;
		List<object> list = new List<object>();
		ParameterInfo[] parameters2 = methodInfo.GetParameters();
		foreach (ParameterInfo parameterInfo in parameters2)
		{
			if (parameters.TryGetValue(parameterInfo.Name, out var value) && (value == null || parameterInfo.ParameterType.IsAssignableFrom(value.GetType())))
			{
				list.Add(value);
				continue;
			}
			value = null;
			if (parameterAccessor != null)
			{
				value = parameterAccessor(parameterInfo.Name, parameterInfo.ParameterType);
			}
			if (value == null && parameterInfo.ParameterType.IsValueType)
			{
				value = Activator.CreateInstance(parameterInfo.ParameterType);
			}
			list.Add(value);
		}
		try
		{
			object result = EntityScriptingService.InvokeWithDiagnostics(methodInfo, scriptInstance, list.ToArray(), (string)errorTitle);
			if (contextInstance is IEntity entity)
			{
				DynamicFormHelper.ProcessNewTablePartItems(entity, (EntityMetadata)MetadataLoader.LoadMetadata(entity.CastAsRealType().GetType()));
				return result;
			}
			return result;
		}
		catch (TargetInvocationException ex)
		{
			throw new ScriptExecuteException((string)errorTitle + (ex.InnerException ?? ex).Message, ex);
		}
		catch (Exception ex2)
		{
			throw new ScriptExecuteException((string)errorTitle + ex2.Message, ex2);
		}
	}

	private Assembly GetScriptModuleAssembly(IWorkflowProcess process, string error)
	{
		//Discarded unreachable code: IL_018d, IL_019c, IL_0203, IL_0212, IL_02e2, IL_03d8, IL_0433, IL_055e, IL_059e, IL_05ad, IL_05b9, IL_05e9, IL_0629, IL_0638, IL_0644, IL_0691, IL_06fe, IL_070d, IL_0728, IL_0737
		int num = 16;
		Assembly assembly = default(Assembly);
		ScriptModule scriptModule = default(ScriptModule);
		IDisposable disposable = default(IDisposable);
		string text2 = default(string);
		string text3 = default(string);
		bool lockTaken = default(bool);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 18:
					if (PUSjWF3kmXtRmlGYh6W(process) == null)
					{
						num = 17;
						break;
					}
					goto default;
				case 15:
					throw new ArgumentNullException((string)KGlBRX386BGALJkpgKe(0x7AADECE0 ^ 0x7AADC430));
				case 4:
					if (WorkflowInstanceContextService != null)
					{
						num2 = 14;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2f22e6eeec1e40a4b9dae10f79ea3ae0 == 0)
						{
							num2 = 10;
						}
						continue;
					}
					goto case 7;
				case 5:
				case 13:
				case 17:
					if (gxIOOA3mukiBvpkn74o(assembly, null))
					{
						num2 = 1;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_67c4b8cf6de246108f53fc3d72e6757a == 0)
						{
							num2 = 1;
						}
						continue;
					}
					return assembly;
				case 8:
					if (scriptModule == null)
					{
						num = 9;
						break;
					}
					assembly = null;
					num = 11;
					break;
				case 9:
					throw new InvalidOperationException((string)PSanEj3xRJUkoPXhmYT(KGlBRX386BGALJkpgKe(0x51F798FE ^ 0x51F7B01C), new object[2]
					{
						VWnqUp3jrShQH0oaPvX(process.Header),
						process.Id
					}));
				case 16:
					if (process != null)
					{
						scriptModule = (ScriptModule)uAWmpP3dLnQZQjI5uGC(process);
						num2 = 8;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2a731ad20cd44175bde6db1171290626 != 0)
						{
							num2 = 1;
						}
					}
					else
					{
						num2 = 15;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_9747bbf97f854087a2d2f13ea94f4085 != 0)
						{
							num2 = 6;
						}
					}
					continue;
				case 10:
					if (((Array)oUwm2n3SDMaqQgn2G2b(scriptModule)).Length != 0)
					{
						num2 = 3;
						continue;
					}
					goto case 18;
				default:
					assembly = GetScriptModuleAssembly((IWorkflowProcess)PUSjWF3kmXtRmlGYh6W(process), error);
					num2 = 13;
					continue;
				case 2:
					if (gxIOOA3mukiBvpkn74o(assembly, null))
					{
						num2 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_b813a6ed0be8497dbd700b40350f9732 != 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 5;
				case 14:
					j1lmVW3A9EfMpvoAMH5(WorkflowInstanceContextService, process);
					num2 = 7;
					continue;
				case 1:
					throw new ScriptExecuteException((string)pcgfEF3Wj7nOGyB7o8B(error, KGlBRX386BGALJkpgKe(0x82E000E ^ 0x82E1AD6), SR.T((string)KGlBRX386BGALJkpgKe(0x319750D3 ^ 0x31977947), VWnqUp3jrShQH0oaPvX(TNPo8L3BTArL02UJ6kN(process)), process.Id)));
				case 6:
					try
					{
						string text = Path.Combine(((ComponentManager)t5uABKoZ2V2VsZC8vVE()).WorkDirectory, (string)KGlBRX386BGALJkpgKe(0x48B7D69C ^ 0x48B7FFD4), (string)KGlBRX386BGALJkpgKe(-1587393812 ^ -1587387510));
						int num3 = 5;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_0bfa1473b6a64d0f975c9b2348e2eb28 == 0)
						{
							num3 = 3;
						}
						while (true)
						{
							switch (num3)
							{
							case 6:
								disposable = (IDisposable)KKQiSe3yEET4WUWwNGe(LockKeyFactory, text2);
								num3 = 0;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_c3ae8e111f574ce9b09d9ed725c1ab53 == 0)
								{
									num3 = 0;
								}
								continue;
							case 5:
								if (!rpFfDs3pjr1XmGll97X(text))
								{
									num3 = 4;
									if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_13175fe1d68b47f98df2806801617f3f != 0)
									{
										num3 = 4;
									}
									continue;
								}
								goto case 1;
							case 3:
								text3 = Path.Combine(text, (string)geevF23bmAB7c0nSM6Q(scriptModule) + (string)KGlBRX386BGALJkpgKe(-1756425685 ^ -1756415069));
								num3 = 6;
								continue;
							case 1:
								text2 = (string)hAANre3nu9rOHXkWAE3(text, acqN7o3sfNi2rCBgMTY(scriptModule.AssemblyName, KGlBRX386BGALJkpgKe(-949720076 ^ -949730680)));
								num3 = 3;
								continue;
							default:
								try
								{
									IDisposable obj = disposable;
									int num4 = 0;
									if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_98890646a18d4a91b352a4ea5d1be319 != 0)
									{
										num4 = 0;
									}
									while (true)
									{
										switch (num4)
										{
										default:
											lockTaken = false;
											num4 = 1;
											if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_708ed3fc86604750bea250f1bed031ed == 0)
											{
												num4 = 0;
											}
											continue;
										case 1:
											try
											{
												Monitor.Enter(obj, ref lockTaken);
												int num5 = 3;
												if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_4d66b27a693d4e1f9d801c17731a3049 != 0)
												{
													num5 = 1;
												}
												while (true)
												{
													switch (num5)
													{
													case 4:
														dbm8ru36IDNi6KCRvbx(text2, oUwm2n3SDMaqQgn2G2b(scriptModule), YkJyKc3OsUC1pL7jyBI(1.0), 10);
														num5 = 1;
														if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_36f887aeb2714eb8a19eed4fd9ed8ed8 != 0)
														{
															num5 = 1;
														}
														continue;
													case 3:
														assembly = ComponentManager.FindLoadedAssembly((string)geevF23bmAB7c0nSM6Q(scriptModule), isFullName: false);
														num5 = 2;
														if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_c8901ad9999948b380523446821824e3 != 0)
														{
															num5 = 2;
														}
														continue;
													case 2:
														if (assembly == null)
														{
															num5 = 4;
															if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_19817a6c27b8478eb2c8f07b7fca8477 != 0)
															{
																num5 = 0;
															}
															continue;
														}
														break;
													default:
														assembly = (Assembly)Dkpuq030sbOQCC2qIxb(scriptModule.AssemblyRaw, pcbT9h3RmsEoy20LbrX(scriptModule));
														num5 = 5;
														continue;
													case 1:
														dbm8ru36IDNi6KCRvbx(text3, pcbT9h3RmsEoy20LbrX(scriptModule), YkJyKc3OsUC1pL7jyBI(1.0), 10);
														num5 = 0;
														if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_d526d6cd8ea24dfca60f96f0f0be6307 != 0)
														{
															num5 = 0;
														}
														continue;
													case 5:
														break;
													}
													break;
												}
											}
											finally
											{
												int num6;
												if (!lockTaken)
												{
													num6 = 0;
													if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_0bce36a95fd341dfb7b4178ccc0544f2 == 0)
													{
														num6 = 0;
													}
													goto IL_0562;
												}
												goto IL_0578;
												IL_0578:
												Monitor.Exit(obj);
												num6 = 0;
												if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_427a79594804461da96485ca77914e7b != 0)
												{
													num6 = 1;
												}
												goto IL_0562;
												IL_0562:
												switch (num6)
												{
												default:
													goto end_IL_053d;
												case 2:
													break;
												case 0:
													goto end_IL_053d;
												case 1:
													goto end_IL_053d;
												}
												goto IL_0578;
												end_IL_053d:;
											}
											break;
										case 2:
											break;
										}
										break;
									}
								}
								finally
								{
									int num7;
									if (disposable == null)
									{
										num7 = 1;
										if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_b813a6ed0be8497dbd700b40350f9732 != 0)
										{
											num7 = 1;
										}
										goto IL_05ed;
									}
									goto IL_0603;
									IL_0603:
									disposable.Dispose();
									num7 = 1;
									if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_7b098b7bc47e4d38a5b2691cab1a4e36 == 0)
									{
										num7 = 2;
									}
									goto IL_05ed;
									IL_05ed:
									switch (num7)
									{
									case 1:
										goto end_IL_05c8;
									case 2:
										goto end_IL_05c8;
									}
									goto IL_0603;
									end_IL_05c8:;
								}
								break;
							case 4:
								RUF69u3G4Jxq8TRswXp(text);
								num3 = 1;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_37eee1d96f2f408eb3b01bde6c7d25e0 != 0)
								{
									num3 = 1;
								}
								continue;
							case 2:
								break;
							}
							break;
						}
					}
					catch (Exception innerException)
					{
						int num8 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_515bc4036cf74f5eac12dac987ad5bea != 0)
						{
							num8 = 0;
						}
						switch (num8)
						{
						default:
							throw new ScriptExecuteException((string)pcgfEF3Wj7nOGyB7o8B(error, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3907FE5 ^ 0x390653D), PSanEj3xRJUkoPXhmYT(KGlBRX386BGALJkpgKe(0x604C9214 ^ 0x604CBB80), new object[2]
							{
								VWnqUp3jrShQH0oaPvX(TNPo8L3BTArL02UJ6kN(process)),
								process.Id
							})), innerException);
						}
					}
					goto case 5;
				case 7:
					num2 = 6;
					continue;
				case 3:
				case 12:
					assembly = (Assembly)UoKWbF3UTLW4ofPi4is(geevF23bmAB7c0nSM6Q(scriptModule), false);
					num2 = 2;
					continue;
				case 11:
					if (oUwm2n3SDMaqQgn2G2b(scriptModule) != null)
					{
						num2 = 10;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_ad15cce9717f4dd880232fa1f5e3eab0 == 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto case 18;
				}
				break;
			}
		}
	}

	private object CreateScriptInstance(Type scriptModuleType)
	{
		//Discarded unreachable code: IL_004d, IL_0085, IL_00bd, IL_00cc
		int num = 1;
		int num2 = num;
		IExecutionScope executionScope = default(IExecutionScope);
		object result = default(object);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return result;
			case 1:
				executionScope = (IExecutionScope)D7KrP03erh8tjyYGSx2(dxWPUk3HtVChKDFfypR(ExecutionScopeFactory.CreateScope(), scriptModuleType, Array.Empty<Type>()));
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_8a653485701e45079b9af8815b59e5f3 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				result = iqAvfX3iVwwmN2BwVis(executionScope, scriptModuleType);
				int num3 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_9bbeebf035a641e28535eada260bd583 == 0)
				{
					num3 = 0;
				}
				return num3 switch
				{
					0 => result, 
					_ => result, 
				};
			}
			finally
			{
				if (executionScope != null)
				{
					int num4 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_12d847d953a942998a65b55f3d0b7ddb != 0)
					{
						num4 = 0;
					}
					while (true)
					{
						switch (num4)
						{
						default:
							LJ8O8a3utpqY2nThKCm(executionScope);
							num4 = 0;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_0b98e2160a714197bf0d3d74d55d90bc == 0)
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
		}
	}

	public WorkflowScriptingService()
	{
		//Discarded unreachable code: IL_003a, IL_003f
		R5282C3lJrHpN6I9Oao();
		registeredContextTypes = new Dictionary<Guid, Type>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_36c7cf283a024daf893e3b9d58dc5698 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static WorkflowScriptingService()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_67c4b8cf6de246108f53fc3d72e6757a == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			default:
				WorkflowLog = (ILogger)J73nlD3fnFw2PBZRkrD(KGlBRX386BGALJkpgKe(-2144947971 ^ -2144956393));
				num2 = 2;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_22e71f1d40564f3ab8f9ac9108d98dcb == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	internal static bool Ra4nF8o17DCrnMoXZ9J()
	{
		return TKYXQtogHsLu2ZNw4kC == null;
	}

	internal static WorkflowScriptingService mNDPTIoIYVe4Sx7eySf()
	{
		return TKYXQtogHsLu2ZNw4kC;
	}

	internal static object t5uABKoZ2V2VsZC8vVE()
	{
		return ComponentManager.Current;
	}

	internal static object k6r6rkozxfyRwRKwoPx(object P_0)
	{
		return ((ComponentManager)P_0).ModuleManager;
	}

	internal static Guid vmySwg3Eh8oBaV1uQ5D()
	{
		return __AssemblyInfo.UID;
	}

	internal static object eJrmb83CSK4ohl4o7sa(object P_0)
	{
		return ((ILicensedModuleAssembly)P_0).LicenseUnit;
	}

	internal static void ITqeNY3XSjyBStocjjX(object P_0)
	{
		((IInternalProcessesService)P_0).Check();
	}

	internal static object aGJBj23oS9pi3VEPjjE(object P_0)
	{
		return ((IWorkflowInstance)P_0).Process;
	}

	internal static object kAbgMl33WWWI3iZy3Ih(object P_0)
	{
		return ((IWorkflowProcess)P_0).Name;
	}

	internal static object zQldom3h6bdEfwE1QH0(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object PSanEj3xRJUkoPXhmYT(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static object b8jcSF3F1LIfG0pIYHd(object P_0)
	{
		return ((ScriptExecutionInfo)P_0).ScriptInstance;
	}

	internal static object KGlBRX386BGALJkpgKe(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void SWBclr3wjtU9Pw045o1(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object MpHbMG3tRTRrce4gNvM(object P_0)
	{
		return ((IWorkflowInstance)P_0).Name;
	}

	internal static object acqN7o3sfNi2rCBgMTY(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static DateTime txdNrp32MyBEPZ6lb1e()
	{
		return DateTime.Now;
	}

	internal static TimeSpan qjqN8B3qUeefjvEHaPK(DateTime P_0, DateTime P_1)
	{
		return P_0 - P_1;
	}

	internal static object InK2fj3QFqIhVyostoj(object P_0)
	{
		return string.Concat((object[])P_0);
	}

	internal static object nSaDUk3VF6gKC1CRhBQ(object P_0, object P_1, StringSplitOptions P_2)
	{
		return ((string)P_0).Split((string[])P_1, P_2);
	}

	internal static bool GXfiRP3DURxMKK511Qw(object P_0, object P_1)
	{
		return ((string)P_0).Contains((string)P_1);
	}

	internal static int bKuZML3KTioJFdwWn7P(object P_0, char P_1)
	{
		return ((string)P_0).IndexOf(P_1);
	}

	internal static object yC0LXI3MbQgYAJPUCFM(object P_0)
	{
		return ((MemberInfo)P_0).Name;
	}

	internal static bool JermOU3aLBuKuLc7OLI(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static bool McOE2F3YrT6sjX7aMFb(object P_0, object P_1)
	{
		return (MethodInfo)P_0 == (MethodInfo)P_1;
	}

	internal static int jsg2KQ3vNYMs1JXL5Oh(object P_0, object P_1, StringComparison P_2)
	{
		return ((string)P_0).IndexOf((string)P_1, P_2);
	}

	internal static object vjAET23PGaKvi722hAW(object P_0, int P_1, int P_2)
	{
		return ((string)P_0).Substring(P_1, P_2);
	}

	internal static bool kKQVny34Tt4KF3bSTE5(object P_0, object P_1)
	{
		return (MethodInfo)P_0 != (MethodInfo)P_1;
	}

	internal static object CZTU0339cWZf7mK6mjo()
	{
		return Logger.Log;
	}

	internal static void OkpgKs3TOKiVn7cxjo8(object P_0, object P_1)
	{
		((ILogger)P_0).Warn(P_1);
	}

	internal static object jVTc7i3ccg40Ju4RCg7(Type type)
	{
		return GetTypeInfo(type);
	}

	internal static object gxON5K3NFDQvAH7yQow(object P_0, object P_1, object P_2, object P_3)
	{
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	internal static object uAWmpP3dLnQZQjI5uGC(object P_0)
	{
		return ((IWorkflowProcess)P_0).ScriptModule;
	}

	internal static object VWnqUp3jrShQH0oaPvX(object P_0)
	{
		return ((IProcessHeader)P_0).Name;
	}

	internal static object oUwm2n3SDMaqQgn2G2b(object P_0)
	{
		return ((ScriptModule)P_0).AssemblyRaw;
	}

	internal static object PUSjWF3kmXtRmlGYh6W(object P_0)
	{
		return ((IWorkflowProcess)P_0).Parent;
	}

	internal static object geevF23bmAB7c0nSM6Q(object P_0)
	{
		return ((ScriptModule)P_0).AssemblyName;
	}

	internal static object UoKWbF3UTLW4ofPi4is(object P_0, bool P_1)
	{
		return ComponentManager.FindLoadedAssembly((string)P_0, P_1);
	}

	internal static bool gxIOOA3mukiBvpkn74o(object P_0, object P_1)
	{
		return (Assembly)P_0 == (Assembly)P_1;
	}

	internal static Type j1lmVW3A9EfMpvoAMH5(object P_0, object P_1)
	{
		return ((WorkflowInstanceContextService)P_0).GetInstanceContextType((IWorkflowProcess)P_1);
	}

	internal static bool rpFfDs3pjr1XmGll97X(object P_0)
	{
		return Directory.Exists((string)P_0);
	}

	internal static object RUF69u3G4Jxq8TRswXp(object P_0)
	{
		return Directory.CreateDirectory((string)P_0);
	}

	internal static object hAANre3nu9rOHXkWAE3(object P_0, object P_1)
	{
		return Path.Combine((string)P_0, (string)P_1);
	}

	internal static object KKQiSe3yEET4WUWwNGe(object P_0, object P_1)
	{
		return ((ILockKeyFactory)P_0).Get((string)P_1);
	}

	internal static TimeSpan YkJyKc3OsUC1pL7jyBI(double P_0)
	{
		return TimeSpan.FromSeconds(P_0);
	}

	internal static void dbm8ru36IDNi6KCRvbx(object P_0, object P_1, TimeSpan P_2, int P_3)
	{
		IOExtensions.WriteAllBytesWithAttempts((string)P_0, (byte[])P_1, P_2, P_3);
	}

	internal static object pcbT9h3RmsEoy20LbrX(object P_0)
	{
		return ((ScriptModule)P_0).DebugRaw;
	}

	internal static object Dkpuq030sbOQCC2qIxb(object P_0, object P_1)
	{
		return ComponentManager.LoadAssembly((byte[])P_0, (byte[])P_1);
	}

	internal static object TNPo8L3BTArL02UJ6kN(object P_0)
	{
		return ((IWorkflowProcess)P_0).Header;
	}

	internal static object pcgfEF3Wj7nOGyB7o8B(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static object dxWPUk3HtVChKDFfypR(object P_0, Type P_1, object P_2)
	{
		return ((IExecutionScopeBuilder)P_0).AddRegistration(P_1, (Type[])P_2);
	}

	internal static object D7KrP03erh8tjyYGSx2(object P_0)
	{
		return ((IExecutionScopeBuilder)P_0).StartScope();
	}

	internal static object iqAvfX3iVwwmN2BwVis(object P_0, Type P_1)
	{
		return ((IExecutionScope)P_0).Resolve(P_1);
	}

	internal static void LJ8O8a3utpqY2nThKCm(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void R5282C3lJrHpN6I9Oao()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}

	internal static object J73nlD3fnFw2PBZRkrD(object P_0)
	{
		return Logger.GetLogger((string)P_0);
	}
}
