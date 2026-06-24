using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Locking;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Mappings;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Scripts.Entities;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Services.Scope;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.CustomActivity;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Processes;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Services;

[Service(Type = ComponentType.Server, EnableInterceptors = true)]
public class CustomActivityScriptingService : ICustomActivityScriptingService
{
	private static readonly ILogger WorkflowLog;

	internal static CustomActivityScriptingService S08fYcXsLpO3ZhC0UU8;

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
				case 1:
					_003CExecutionScopeFactory_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_c5274b5f82c74d1e8e92ea099532df1e == 0)
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
				case 0:
					return;
				case 1:
					_003CLockKeyFactory_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_708ed3fc86604750bea250f1bed031ed != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public object GetParametersInstance(ICustomActivityHeader customActivityHeader)
	{
		//Discarded unreachable code: IL_00a0, IL_00d3, IL_0120, IL_0149, IL_01a0, IL_01ee, IL_0221, IL_0268, IL_0277, IL_02f8, IL_0341, IL_0381, IL_0390, IL_039c, IL_03ab, IL_03bb, IL_03ca, IL_05d8, IL_060b, IL_0651
		int num = 15;
		int num2 = num;
		Assembly assembly = default(Assembly);
		CustomActivityParameters customActivityParameters = default(CustomActivityParameters);
		Type type = default(Type);
		string text = default(string);
		IDisposable disposable = default(IDisposable);
		bool lockTaken = default(bool);
		string text2 = default(string);
		object obj = default(object);
		while (true)
		{
			switch (num2)
			{
			case 12:
				assembly = (Assembly)OZO403X9hF0WHpcwG8e(Rso2y8X4s29M47svD93(customActivityParameters), false);
				num2 = 9;
				break;
			default:
				try
				{
					type = HcAcdlXpRHhCQVbxcxx(assembly, Jekl08XAArfO8OSRhCw(customActivityParameters));
					int num5 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_58d62f4202494b18a0cc2631d85b3ead == 0)
					{
						num5 = 0;
					}
					switch (num5)
					{
					case 0:
						break;
					}
				}
				catch (Exception innerException2)
				{
					int num6 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_eb17dd137d8d48b5ba1e0580355a54c3 != 0)
					{
						num6 = 0;
					}
					switch (num6)
					{
					default:
						throw new ScriptExecuteException(text + (string)iLtl1GXc6vErd4Qr13s(-680549150 ^ -680542662) + (string)Wt4snrXmDssMwhnhLLI(iLtl1GXc6vErd4Qr13s(-588615921 ^ -588614593)), innerException2);
					}
				}
				goto case 2;
			case 6:
				try
				{
					IDisposable disposable2 = disposable;
					int num7 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_368897dda30d41e8b26c6b065203d16b != 0)
					{
						num7 = 0;
					}
					while (true)
					{
						switch (num7)
						{
						default:
							lockTaken = false;
							num7 = 1;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3600d9e606e544d2b67d1fc1ad9becc3 != 0)
							{
								num7 = 1;
							}
							continue;
						case 1:
							try
							{
								Monitor.Enter(disposable2, ref lockTaken);
								int num8 = 3;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_fc30864faaad488ba50da4607dce40b9 != 0)
								{
									num8 = 0;
								}
								while (true)
								{
									switch (num8)
									{
									default:
										try
										{
											assembly = (Assembly)S602ClXSsnY07veHEFI(ekhamqXdieXbgebP1Gr(customActivityParameters), h6ZgjVXjcmQJptQVX8c(customActivityParameters));
											int num9 = 0;
											if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_dc680cc6c18b4142944f593b8b103a17 != 0)
											{
												num9 = 0;
											}
											switch (num9)
											{
											case 0:
												break;
											}
										}
										catch (Exception innerException3)
										{
											int num10 = 0;
											if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e284642f05f54785bb4c3e22d7a51872 == 0)
											{
												num10 = 0;
											}
											switch (num10)
											{
											default:
												throw new ScriptExecuteException((string)uj8f4FXkuixwML2JYHc(text, iLtl1GXc6vErd4Qr13s(-437373675 ^ -437375027), SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1633140121 ^ -1633134457))), innerException3);
											}
										}
										break;
									case 3:
										assembly = (Assembly)OZO403X9hF0WHpcwG8e(Rso2y8X4s29M47svD93(customActivityParameters), false);
										num8 = 2;
										if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_58d62f4202494b18a0cc2631d85b3ead != 0)
										{
											num8 = 2;
										}
										continue;
									case 2:
										if (siR4JVXTKnlVB5JotnI(assembly, null))
										{
											num8 = 0;
											if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_76260b548c684c6c95eb679c837b8945 != 0)
											{
												num8 = 0;
											}
											continue;
										}
										break;
									case 1:
										break;
									}
									break;
								}
							}
							finally
							{
								if (lockTaken)
								{
									int num11 = 0;
									if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_67c4b8cf6de246108f53fc3d72e6757a == 0)
									{
										num11 = 0;
									}
									while (true)
									{
										switch (num11)
										{
										default:
											wcsHl7XbNc5HNsm2c02(disposable2);
											num11 = 1;
											if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_77bc2455d9c3443ca1c76a1788888437 != 0)
											{
												num11 = 1;
											}
											continue;
										case 1:
											break;
										}
										break;
									}
								}
							}
							break;
						}
						break;
					}
				}
				finally
				{
					int num12;
					if (disposable == null)
					{
						num12 = 2;
						goto IL_0345;
					}
					goto IL_035b;
					IL_0345:
					switch (num12)
					{
					default:
						goto end_IL_0330;
					case 1:
						break;
					case 2:
						goto end_IL_0330;
					case 0:
						goto end_IL_0330;
					}
					goto IL_035b;
					IL_035b:
					VLipCSXUabDgmleyPWU(disposable);
					num12 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_b54291e8d6924fb3b3fee419f778cbd9 == 0)
					{
						num12 = 0;
					}
					goto IL_0345;
					end_IL_0330:;
				}
				goto case 7;
			case 7:
			case 8:
				if (siR4JVXTKnlVB5JotnI(assembly, null))
				{
					num2 = 6;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_37eee1d96f2f408eb3b01bde6c7d25e0 != 0)
					{
						num2 = 11;
					}
				}
				else
				{
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_7f79a06dec5f490c93fd11725200b9b3 != 0)
					{
						num2 = 0;
					}
				}
				break;
			case 11:
				throw new ScriptExecuteException((string)uj8f4FXkuixwML2JYHc(text, iLtl1GXc6vErd4Qr13s(-1967154668 ^ -1967161140), Wt4snrXmDssMwhnhLLI(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1386102027 ^ -1386096619))));
			case 14:
				text = (string)NxJFO6XvGgFsMd9dKWU(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4E58FEAF ^ 0x4E58E741), new object[2]
				{
					t26Zu9XaSY7T9W7HCeB(customActivityHeader),
					((IEntity<long>)Udoh5fXYTX2Tpmg9DN5(customActivityHeader)).Id
				});
				num2 = 3;
				break;
			case 15:
				((IInternalProcessesService)Dr40u0XMTSvxhDSXhlJ((ILicensedModuleAssembly)vK0Hq1XKQyeLANoMiuP(aJkJbZXVFXlnTZjmFin(C9DPBGXQgHVn32LamHi()), X0ybVpXD8XtYbAJpcGA()))).Check();
				num2 = 14;
				break;
			case 2:
				if (bJlqaQXG8EMviISNpxw(type, null))
				{
					num2 = 5;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_7ff589a2577e4ae68ceb125a419ed974 == 0)
					{
						num2 = 1;
					}
				}
				else
				{
					num2 = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_a9f4f79195cf4308a30b686c5cb386e5 == 0)
					{
						num2 = 0;
					}
				}
				break;
			case 10:
				return obj;
			case 13:
				disposable = (IDisposable)Gr5EdHXNUPxpfkOmwa7(LockKeyFactory, text2);
				num2 = 6;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_4756c9eca18a4abd877173fe66f77852 != 0)
				{
					num2 = 6;
				}
				break;
			case 9:
				if (!siR4JVXTKnlVB5JotnI(assembly, null))
				{
					num2 = 8;
					break;
				}
				goto case 4;
			case 4:
				text2 = (string)iLtl1GXc6vErd4Qr13s(-408604271 ^ -408605917) + (string)Rso2y8X4s29M47svD93(customActivityParameters);
				num2 = 3;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e284642f05f54785bb4c3e22d7a51872 != 0)
				{
					num2 = 13;
				}
				break;
			case 5:
				throw new ScriptExecuteException((string)uj8f4FXkuixwML2JYHc(text, iLtl1GXc6vErd4Qr13s(-769877317 ^ -769884061), Wt4snrXmDssMwhnhLLI(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xE6AF0C2 ^ 0xE6AEBF2))));
			case 1:
				try
				{
					obj = vmQg2RXnKOHfO0Wc6Pv(type);
					int num3 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_ec7d0b62d0f94d70bbee4df19d5df325 != 0)
					{
						num3 = 0;
					}
					return num3 switch
					{
						0 => obj, 
						_ => obj, 
					};
				}
				catch (Exception innerException)
				{
					int num4 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_bbeafe91b1c448baa8c5cf2ab0baaadd != 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					default:
						throw new ScriptExecuteException((string)uj8f4FXkuixwML2JYHc(text, iLtl1GXc6vErd4Qr13s(0xB863F17 ^ 0xB8625CF), SR.T((string)iLtl1GXc6vErd4Qr13s(0x4E58FEAF ^ 0x4E58E521))), innerException);
					}
				}
			case 3:
				customActivityParameters = (CustomActivityParameters)kKBrIRXPivj386fAGMx(Udoh5fXYTX2Tpmg9DN5(customActivityHeader));
				num2 = 12;
				break;
			}
		}
	}

	public object GetScriptInstance(ICustomActivityHeader customActivityHeader)
	{
		//Discarded unreachable code: IL_0130, IL_013f, IL_0256, IL_0265, IL_0296, IL_02c9, IL_030f, IL_0369, IL_03a5, IL_03dd, IL_0415, IL_0424, IL_0450, IL_0497, IL_04c0, IL_0507, IL_05a5, IL_05d8, IL_0624, IL_0633, IL_0654, IL_0694, IL_06a3, IL_06d0, IL_0710, IL_071f, IL_072b, IL_073a
		int num = 13;
		Assembly assembly = default(Assembly);
		ScriptModule scriptModule = default(ScriptModule);
		string text = default(string);
		string text2 = default(string);
		IDisposable disposable = default(IDisposable);
		string text3 = default(string);
		Type type = default(Type);
		object obj2 = default(object);
		bool lockTaken = default(bool);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					if (!siR4JVXTKnlVB5JotnI(assembly, null))
					{
						num2 = 4;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3c90beae50bc45bbb9c4179594d556e4 == 0)
						{
							num2 = 7;
						}
						continue;
					}
					break;
				case 9:
					return obj2;
				case 8:
					assembly = (Assembly)OZO403X9hF0WHpcwG8e(scriptModule.AssemblyName, false);
					num2 = 5;
					continue;
				case 16:
					scriptModule = (ScriptModule)thEMhUXOqWYjOleIsHM(customActivityHeader.Published);
					num2 = 8;
					continue;
				case 10:
					throw new ScriptExecuteException((string)uj8f4FXkuixwML2JYHc(text, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1756425685 ^ -1756428045), Wt4snrXmDssMwhnhLLI(iLtl1GXc6vErd4Qr13s(0x1C21F94 ^ 0x1C2047A))));
				case 15:
					text2 = (string)uj8f4FXkuixwML2JYHc(O9qSkbXWeCX8ohtAlnj(scriptModule), iLtl1GXc6vErd4Qr13s(0x4E58FEAF ^ 0x4E58E293), V4ChxoXHgFZC0cMi83F(scriptModule));
					num2 = 5;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3ccbd21470394457949c11be6f557154 == 0)
					{
						num2 = 6;
					}
					continue;
				case 12:
					text = SR.T((string)iLtl1GXc6vErd4Qr13s(0x5A5DBA54 ^ 0x5A5DA3BA), t26Zu9XaSY7T9W7HCeB(customActivityHeader), customActivityHeader.Published.Id);
					num2 = 16;
					continue;
				default:
					disposable = (IDisposable)Gr5EdHXNUPxpfkOmwa7(LockKeyFactory, text3);
					num2 = 3;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_b9495424a4ef4f809c30bcc362ac3faa != 0)
					{
						num2 = 3;
					}
					continue;
				case 14:
					if (bJlqaQXG8EMviISNpxw(type, null))
					{
						num2 = 5;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_dc680cc6c18b4142944f593b8b103a17 != 0)
						{
							num2 = 11;
						}
					}
					else
					{
						num2 = 4;
					}
					continue;
				case 11:
					throw new ScriptExecuteException((string)uj8f4FXkuixwML2JYHc(text, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-711228462 ^ -711223030), Wt4snrXmDssMwhnhLLI(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-92270799 ^ -92269709))));
				case 13:
					goto end_IL_0012;
				case 6:
					try
					{
						type = HcAcdlXpRHhCQVbxcxx(assembly, text2);
						int num13 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_71034f51e0444c3592d323fffec09e96 != 0)
						{
							num13 = 0;
						}
						switch (num13)
						{
						case 0:
							break;
						}
					}
					catch (Exception innerException3)
					{
						int num14 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_76260b548c684c6c95eb679c837b8945 == 0)
						{
							num14 = 0;
						}
						switch (num14)
						{
						default:
							throw new ScriptExecuteException((string)uj8f4FXkuixwML2JYHc(text, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-437373675 ^ -437375027), Wt4snrXmDssMwhnhLLI(iLtl1GXc6vErd4Qr13s(0x4CBDA8D5 ^ 0x4CBDB497))), innerException3);
						}
					}
					goto case 14;
				case 2:
				case 7:
					if (!siR4JVXTKnlVB5JotnI(assembly, null))
					{
						num2 = 15;
						continue;
					}
					goto case 10;
				case 4:
					try
					{
						IExecutionScope executionScope = (IExecutionScope)qtiqr4XeePiL4tcpRUF(ExecutionScopeFactory.CreateScope().AddRegistration(type));
						int num9 = 1;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3600d9e606e544d2b67d1fc1ad9becc3 == 0)
						{
							num9 = 1;
						}
						switch (num9)
						{
						default:
							return obj2;
						case 0:
							return obj2;
						case 1:
							try
							{
								obj2 = oojjDvXisZp7w7TP1pt(executionScope, type);
								int num10 = 0;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_c41b9b25e0a04be1b1ded81427c555dd != 0)
								{
									num10 = 0;
								}
								return num10 switch
								{
									0 => obj2, 
									_ => obj2, 
								};
							}
							finally
							{
								if (executionScope != null)
								{
									int num11 = 0;
									if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_ff730ec99c9d438e9ab033b91102c6e4 == 0)
									{
										num11 = 1;
									}
									while (true)
									{
										switch (num11)
										{
										case 1:
											executionScope.Dispose();
											num11 = 0;
											if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_1fcd5b77d5534d528c98a4d02b302a40 != 0)
											{
												num11 = 0;
											}
											continue;
										case 0:
											break;
										}
										break;
									}
								}
							}
						}
					}
					catch (Exception innerException2)
					{
						int num12 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_51bbd8978ad84af991914149de98c8c6 == 0)
						{
							num12 = 0;
						}
						switch (num12)
						{
						default:
							throw new ScriptExecuteException((string)uj8f4FXkuixwML2JYHc(text, iLtl1GXc6vErd4Qr13s(0x124714F0 ^ 0x12470E28), Wt4snrXmDssMwhnhLLI(iLtl1GXc6vErd4Qr13s(-1947292726 ^ -1947289772))), innerException2);
						}
					}
				case 3:
					try
					{
						IDisposable obj = disposable;
						int num3 = 1;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_f44d857a149741d8874c141a12a734dc == 0)
						{
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							case 1:
								lockTaken = false;
								num3 = 0;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2180cded74a649d583efc1ab91959551 != 0)
								{
									num3 = 0;
								}
								continue;
							default:
								try
								{
									Monitor.Enter(obj, ref lockTaken);
									int num4 = 3;
									while (true)
									{
										switch (num4)
										{
										case 3:
											assembly = ComponentManager.FindLoadedAssembly((string)X44NrfX6btWLMbegjjG(scriptModule), isFullName: false);
											num4 = 1;
											if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_820de5fd03a94336b27530b7b54bc5b6 != 0)
											{
												num4 = 1;
											}
											continue;
										case 1:
											if (siR4JVXTKnlVB5JotnI(assembly, null))
											{
												num4 = 2;
												if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_d3b68071fc514b3d835e436b531f4252 != 0)
												{
													num4 = 1;
												}
												continue;
											}
											break;
										case 2:
											try
											{
												assembly = (Assembly)S602ClXSsnY07veHEFI(y1SgyVX0yV4m3Jpmgdy(scriptModule), MHl3AoXBkK4MiGxT81G(scriptModule));
												int num5 = 0;
												if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_128870479a48410393b814985ef83c9e == 0)
												{
													num5 = 0;
												}
												switch (num5)
												{
												case 0:
													break;
												}
											}
											catch (Exception innerException)
											{
												int num6 = 0;
												if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_13af7ecdfdd3466b80333112ab4ca5a5 == 0)
												{
													num6 = 0;
												}
												switch (num6)
												{
												default:
													throw new ScriptExecuteException((string)uj8f4FXkuixwML2JYHc(text, iLtl1GXc6vErd4Qr13s(0x234241C0 ^ 0x23425B18), Wt4snrXmDssMwhnhLLI(iLtl1GXc6vErd4Qr13s(0x3F8E27D0 ^ 0x3F8E3C3E))), innerException);
												}
											}
											break;
										case 0:
											break;
										}
										break;
									}
								}
								finally
								{
									int num7;
									if (!lockTaken)
									{
										num7 = 2;
										goto IL_0658;
									}
									goto IL_066e;
									IL_0658:
									switch (num7)
									{
									default:
										goto end_IL_0643;
									case 1:
										break;
									case 2:
										goto end_IL_0643;
									case 0:
										goto end_IL_0643;
									}
									goto IL_066e;
									IL_066e:
									Monitor.Exit(obj);
									num7 = 0;
									if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_bd008fca9c464e14859870d0f9208652 == 0)
									{
										num7 = 0;
									}
									goto IL_0658;
									end_IL_0643:;
								}
								break;
							}
							break;
						}
					}
					finally
					{
						int num8;
						if (disposable == null)
						{
							num8 = 1;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_bbeafe91b1c448baa8c5cf2ab0baaadd != 0)
							{
								num8 = 1;
							}
							goto IL_06d4;
						}
						goto IL_06ea;
						IL_06ea:
						VLipCSXUabDgmleyPWU(disposable);
						num8 = 2;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_908b32727d48459090dc901d67456a14 == 0)
						{
							num8 = 2;
						}
						goto IL_06d4;
						IL_06d4:
						switch (num8)
						{
						case 1:
							goto end_IL_06af;
						case 2:
							goto end_IL_06af;
						}
						goto IL_06ea;
						end_IL_06af:;
					}
					goto case 2;
				case 1:
					break;
				}
				text3 = (string)fApQqLXRI4ac0XTGDY2(iLtl1GXc6vErd4Qr13s(0x47356CA4 ^ 0x47357616), X44NrfX6btWLMbegjjG(scriptModule));
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_dc680cc6c18b4142944f593b8b103a17 == 0)
				{
					num2 = 0;
				}
				continue;
				end_IL_0012:
				break;
			}
			niGJwDXy990FCTKqUov((IInternalProcessesService)Dr40u0XMTSvxhDSXhlJ((ILicensedModuleAssembly)vK0Hq1XKQyeLANoMiuP(aJkJbZXVFXlnTZjmFin(C9DPBGXQgHVn32LamHi()), X0ybVpXD8XtYbAJpcGA())));
			num = 12;
		}
	}

	public object ExecuteScript(ICustomActivityHeader customActivityHeader, string scriptName, Dictionary<string, object> parameters = null, WorkflowInstanceContext wfContext = null, CustomActivityElement caElement = null)
	{
		Contract.ArgumentNotNull(customActivityHeader, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-416187968 ^ -416193220));
		Contract.ArgumentNotNull(customActivityHeader.Published, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1737696342 ^ -1737701758));
		Contract.ArgumentNotNull(customActivityHeader.Published.ScriptModule, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-138431307 ^ -138434083));
		Contract.ArgumentNotNull(customActivityHeader.Published.ScriptModule.AssemblyRaw, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x20C96B1E ^ 0x20C976DC));
		((IInternalProcessesService)((ILicensedModuleAssembly)ComponentManager.Current.ModuleManager.FindUnitByUid(__AssemblyInfo.UID)).LicenseUnit).Check();
		DateTime now = DateTime.Now;
		string text = SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-478552651 ^ -478559141), customActivityHeader.Name, customActivityHeader.Published.Id);
		Logger.Log.Debug(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C21F94 ^ 0x1C201A0), scriptName, customActivityHeader.Name, customActivityHeader.Published.Id));
		try
		{
			object parametersInstance;
			try
			{
				parametersInstance = GetParametersInstance(customActivityHeader);
			}
			catch (Exception innerException)
			{
				throw new ScriptExecuteException(text + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x78FAF0B5 ^ 0x78FAEE0F)), innerException);
			}
			object scriptInstance;
			try
			{
				scriptInstance = GetScriptInstance(customActivityHeader);
			}
			catch (Exception innerException2)
			{
				throw new ScriptExecuteException(text + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1060279669 ^ 0x3F3289EB)), innerException2);
			}
			Type type = scriptInstance.GetType();
			MethodInfo methodInfo = GetMethodInfo(text, type, scriptName, throwOnNotFound: false);
			if (methodInfo == null)
			{
				ScriptExecutionService.MethodNotFound(type, scriptName);
				return null;
			}
			object result = ExecuteScript(text, methodInfo, scriptInstance, customActivityHeader, parametersInstance, parameters, wfContext, caElement);
			Logger.Log.Debug(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x51B6C0BE ^ 0x51B6DFB2));
			WorkflowLog.Debug(FormatLogMessage(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1967154668 ^ -1967160006), customActivityHeader, now, scriptName));
			return result;
		}
		catch (ScriptExecuteException exception)
		{
			Logger.Log.Error(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1164596236 ^ -1164593990), exception);
			throw;
		}
		catch (Exception ex)
		{
			Logger.Log.Error(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1803374629 ^ -1803374443), ex);
			throw new ScriptExecuteException(text, ex);
		}
	}

	private static string FormatLogMessage(object name, object customActivityHeader, DateTime start, string message = null)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				sS1ixoXuRjfxCn1ov3f(customActivityHeader, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2C9503E1 ^ 0x2C951F1D));
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_bf7c4b70954d454aa91550540c3daabc == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return (string)f6wZPFXJydQH86vrKIw(new object[9]
				{
					name,
					iLtl1GXc6vErd4Qr13s(-1587393812 ^ -1587391082),
					t26Zu9XaSY7T9W7HCeB(customActivityHeader),
					iLtl1GXc6vErd4Qr13s(0x32F3F75 ^ 0x32F20F5),
					((ICustomActivityHeader)customActivityHeader).Name,
					iLtl1GXc6vErd4Qr13s(0x2C9503E1 ^ 0x2C951C69),
					(!Gc2TFeXlaDOsD4uUXZw(message)) ? fApQqLXRI4ac0XTGDY2(message, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x27A6CAB5 ^ 0x27A6D521)) : "",
					(int)DWjJ27XL8VuDs8NdgYX(jDLvZxXfVEhlnU43NQm(), start).TotalMilliseconds,
					SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1683072034 ^ -1683078080)
				});
			}
		}
	}

	private static MethodInfo GetMethodInfo(object errorTitle, Type type, object scriptName, bool throwOnNotFound)
	{
		//Discarded unreachable code: IL_01e5, IL_01f4, IL_0232, IL_0276, IL_036a, IL_037d, IL_038c, IL_0417, IL_04d5, IL_051a, IL_0529
		int num = 7;
		MethodInfo methodInfo2 = default(MethodInfo);
		_003C_003Ec__DisplayClass13_0 _003C_003Ec__DisplayClass13_ = default(_003C_003Ec__DisplayClass13_0);
		string message = default(string);
		_003C_003Ec__DisplayClass13_1 _003C_003Ec__DisplayClass13_2 = default(_003C_003Ec__DisplayClass13_1);
		string text2 = default(string);
		List<MethodInfo>.Enumerator enumerator = default(List<MethodInfo>.Enumerator);
		MethodInfo current = default(MethodInfo);
		List<string> values = default(List<string>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					return methodInfo2;
				case 2:
					if (!throwOnNotFound)
					{
						goto end_IL_0012;
					}
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_d69eb50e19fe417b8cd197dfca4d0d49 != 0)
					{
						num2 = 0;
					}
					break;
				case 7:
					_003C_003Ec__DisplayClass13_ = new _003C_003Ec__DisplayClass13_0();
					num2 = 6;
					break;
				case 1:
					methodInfo2 = null;
					num2 = 4;
					break;
				case 6:
					_003C_003Ec__DisplayClass13_.scriptName = (string)scriptName;
					num2 = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_ad15cce9717f4dd880232fa1f5e3eab0 == 0)
					{
						num2 = 0;
					}
					break;
				default:
					throw new ScriptExecuteException(message);
				case 8:
					if (!(methodInfo2 != null))
					{
						message = (string)fApQqLXRI4ac0XTGDY2(errorTitle, NxJFO6XvGgFsMd9dKWU(iLtl1GXc6vErd4Qr13s(0x3C126B81 ^ 0x3C124BB7), new object[1] { _003C_003Ec__DisplayClass13_.scriptName }));
						num2 = 2;
						break;
					}
					num2 = 3;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_22e71f1d40564f3ab8f9ac9108d98dcb == 0)
					{
						num2 = 5;
					}
					break;
				case 4:
					try
					{
						string text = ((IEnumerable<string>)d40IB9XrG2WIkFSuBUQ(_003C_003Ec__DisplayClass13_.scriptName, new string[1] { SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-796330436 ^ -796333656) }, StringSplitOptions.None)).First();
						int num3 = 3;
						while (true)
						{
							MethodInfo methodInfo;
							switch (num3)
							{
							case 9:
								_003C_003Ec__DisplayClass13_2.parametersList = ((IEnumerable<string>)d40IB9XrG2WIkFSuBUQ(text2, new string[1] { SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-746011232 ^ -746005984) }, StringSplitOptions.None)).ToList();
								num3 = 1;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3059bb5cee2f4eb68ccea048bb8e848c == 0)
								{
									num3 = 1;
								}
								continue;
							case 5:
								try
								{
									while (true)
									{
										IL_02e0:
										int num5;
										if (!enumerator.MoveNext())
										{
											num5 = 3;
											goto IL_01ff;
										}
										goto IL_025a;
										IL_01ff:
										int num6 = num5;
										while (true)
										{
											switch (num6)
											{
											case 5:
												methodInfo2 = current;
												num6 = 1;
												if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_9747bbf97f854087a2d2f13ea94f4085 == 0)
												{
													num6 = 2;
												}
												continue;
											case 1:
												break;
											case 2:
												goto end_IL_02e0;
											case 4:
												if (wdHS60XzA6MSsCcPDUk(pGRyElXZcKMUb2gOTa7(iLtl1GXc6vErd4Qr13s(-79921577 ^ -79928861), XXAZ27XIxx8OKS9r8Jl(current), string.Join((string)iLtl1GXc6vErd4Qr13s(-1411073168 ^ -1411078928), values)), text))
												{
													num6 = 0;
													if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_71034f51e0444c3592d323fffec09e96 != 0)
													{
														num6 = 0;
													}
													continue;
												}
												goto case 5;
											default:
												goto IL_02e0;
											case 6:
												values = ((IEnumerable<ParameterInfo>)iIBNTPX1OCvGVmYjSpe(current)).Select(delegate(ParameterInfo q)
												{
													int num9 = 1;
													int num10 = num9;
													string text3 = default(string);
													while (true)
													{
														switch (num10)
														{
														default:
															return text3.Substring(1, _003C_003Ec.l4q8ssmZr2WJde94HY2(text3) - 2);
														case 1:
															text3 = (string)_003C_003Ec.FDGcHwmIlIFnS2wPg30(_003C_003Ec.l5gxuDm1eG3VF6SqM8n(q));
															num10 = 0;
															if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_94abcc9c95ac4ce4baec9537ccf1485a != 0)
															{
																num10 = 0;
															}
															break;
														}
													}
												}).ToList();
												num6 = 4;
												continue;
											case 3:
												goto end_IL_02e0;
											}
											break;
										}
										goto IL_025a;
										IL_025a:
										current = enumerator.Current;
										num5 = 6;
										goto IL_01ff;
										continue;
										end_IL_02e0:
										break;
									}
								}
								finally
								{
									((IDisposable)enumerator).Dispose();
									int num7 = 0;
									if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_9451b1fac1ed452e82e1cbd5a96b41fd == 0)
									{
										num7 = 0;
									}
									switch (num7)
									{
									case 0:
										break;
									}
								}
								goto end_IL_0160;
							case 1:
								enumerator = type.GetMethods().ToList().Where(_003C_003Ec__DisplayClass13_2._003CGetMethodInfo_003Eb__1)
									.ToList()
									.GetEnumerator();
								num3 = 5;
								continue;
							case 2:
								text2 = ((string)nseVbEXgcpOe48JC3yR(text, UCjcKgX5rtJqHiWWL5s(text, '(') + 1)).Replace((string)iLtl1GXc6vErd4Qr13s(-897645572 ^ -897639342), "");
								num3 = 9;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_bd008fca9c464e14859870d0f9208652 != 0)
								{
									num3 = 9;
								}
								continue;
							case 6:
								goto end_IL_0160;
							case 3:
								if (!ztnT2wX7sbKHUgZfLlL(text, iLtl1GXc6vErd4Qr13s(-416187968 ^ -416192920)))
								{
									int num4 = 4;
									num3 = num4;
									continue;
								}
								goto case 7;
							case 7:
								_003C_003Ec__DisplayClass13_2 = new _003C_003Ec__DisplayClass13_1();
								num3 = 2;
								continue;
							case 4:
								methodInfo = type.GetMethod(text);
								if ((object)methodInfo != null)
								{
									break;
								}
								num3 = 0;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_12d847d953a942998a65b55f3d0b7ddb == 0)
								{
									num3 = 0;
								}
								continue;
							default:
								methodInfo = type.GetMethods().FirstOrDefault(_003C_003Ec__DisplayClass13_._003CGetMethodInfo_003Eb__0);
								break;
							case 8:
								goto end_IL_0160;
							}
							methodInfo2 = methodInfo;
							num3 = 6;
							continue;
							end_IL_0160:
							break;
						}
					}
					catch (Exception innerException)
					{
						int num8 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_476f57418da6445caf8a3854ac0b8f67 == 0)
						{
							num8 = 0;
						}
						switch (num8)
						{
						default:
							throw new ScriptExecuteException((string)errorTitle + SR.T((string)iLtl1GXc6vErd4Qr13s(-1952076060 ^ -1952075476), _003C_003Ec__DisplayClass13_.scriptName), innerException);
						}
					}
					goto case 8;
				case 3:
					return null;
				}
				continue;
				end_IL_0012:
				break;
			}
			((ILogger)Eo6O8yoEYTttIIrVp8A()).Warn(message);
			num = 3;
		}
	}

	private static string GetTypeInfo(Type type)
	{
		//Discarded unreachable code: IL_008b, IL_009a, IL_00d2, IL_00e1
		int num = 9;
		int num2 = num;
		int num3 = default(int);
		List<string> list = default(List<string>);
		Type[] genericArguments = default(Type[]);
		string result = default(string);
		Type type2 = default(Type);
		string arg = default(string);
		while (true)
		{
			switch (num2)
			{
			case 3:
				num3 = 0;
				num2 = 13;
				break;
			case 8:
				list = new List<string>();
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_4db1e829bcb046ad87c01fa1925cdfce != 0)
				{
					num2 = 0;
				}
				break;
			case 5:
			case 13:
				if (num3 < genericArguments.Length)
				{
					num2 = 6;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_405af183be2449cfa4440c68827d6de9 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 12;
			case 9:
				if (type.IsGenericType)
				{
					num2 = 7;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_25eedcea124a48258fd18106b7da9d93 == 0)
					{
						num2 = 8;
					}
					break;
				}
				goto case 11;
			case 11:
				result = (string)pGRyElXZcKMUb2gOTa7(iLtl1GXc6vErd4Qr13s(-769877317 ^ -769869279), type.Namespace, type.Name);
				num2 = 7;
				break;
			case 1:
				num3++;
				num2 = 5;
				break;
			case 2:
			case 6:
				type2 = genericArguments[num3];
				num2 = 14;
				break;
			case 4:
			case 7:
				return result;
			case 10:
				result = string.Format((string)iLtl1GXc6vErd4Qr13s(0x6C324F5C ^ 0x6C326F26), type.Namespace, XXAZ27XIxx8OKS9r8Jl(type), arg);
				num2 = 4;
				break;
			case 12:
				arg = string.Join((string)iLtl1GXc6vErd4Qr13s(-2038019883 ^ -2038011743), list);
				num2 = 10;
				break;
			case 14:
				list.Add((string)gLafqjoCKlmCKnLHpFX(type2));
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2a731ad20cd44175bde6db1171290626 == 0)
				{
					num2 = 1;
				}
				break;
			default:
				genericArguments = type.GetGenericArguments();
				num2 = 3;
				break;
			}
		}
	}

	private static object ExecuteScript(object errorTitle, object methodInfo, object scriptInstance, object customActivityHeader, object context, Dictionary<string, object> parameters = null, WorkflowInstanceContext wfContext = null, CustomActivityElement caElement = null)
	{
		parameters = parameters ?? new Dictionary<string, object>();
		parameters[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x77F4B0AB ^ 0x77F4901B)] = context;
		parameters[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2125832759 ^ -2125824767)] = ((ICustomActivityHeader)customActivityHeader).Published;
		List<object> list = new List<object>();
		ParameterInfo[] parameters2 = ((MethodBase)methodInfo).GetParameters();
		foreach (ParameterInfo parameterInfo in parameters2)
		{
			if ((parameters.TryGetValue(parameterInfo.Name, out var value) && value == null) || parameterInfo.ParameterType.IsAssignableFrom(value.GetType()))
			{
				list.Add(value);
				continue;
			}
			value = (parameterInfo.ParameterType.IsValueType ? Activator.CreateInstance(parameterInfo.ParameterType) : null);
			list.Add(value);
		}
		if (wfContext != null && context != null && caElement != null && caElement.InputContextMap != null)
		{
			PropertyMapHelper.Map(wfContext, context, caElement.InputContextMap.Reverse());
		}
		object result;
		try
		{
			result = EntityScriptingService.InvokeWithDiagnostics((MethodInfo)methodInfo, scriptInstance, list.ToArray(), (string)errorTitle);
		}
		catch (TargetInvocationException ex)
		{
			throw new ScriptExecuteException((string)errorTitle + (ex.InnerException ?? ex).Message, ex);
		}
		catch (Exception ex2)
		{
			throw new ScriptExecuteException((string)errorTitle + ex2.Message, ex2);
		}
		if (wfContext != null && context != null && caElement != null && caElement.OutputContextMap != null)
		{
			PropertyMapHelper.Map(context, wfContext, caElement.OutputContextMap);
		}
		return result;
	}

	public CustomActivityScriptingService()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		oGWrDWoXbG3oW2uCCcQ();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_58d62f4202494b18a0cc2631d85b3ead == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static CustomActivityScriptingService()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			default:
				WorkflowLog = (ILogger)XMIXQZooU10AewtTIWp(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5DD795B3 ^ 0x5DD7B559));
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_766d50e1f7cc46f1bc746fe53086708c == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				oGWrDWoXbG3oW2uCCcQ();
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_476f57418da6445caf8a3854ac0b8f67 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool XdObn3X2mbFAlNJkEQL()
	{
		return S08fYcXsLpO3ZhC0UU8 == null;
	}

	internal static CustomActivityScriptingService CQf8GQXqJdS3KvBE7UN()
	{
		return S08fYcXsLpO3ZhC0UU8;
	}

	internal static object C9DPBGXQgHVn32LamHi()
	{
		return ComponentManager.Current;
	}

	internal static object aJkJbZXVFXlnTZjmFin(object P_0)
	{
		return ((ComponentManager)P_0).ModuleManager;
	}

	internal static Guid X0ybVpXD8XtYbAJpcGA()
	{
		return __AssemblyInfo.UID;
	}

	internal static object vK0Hq1XKQyeLANoMiuP(object P_0, Guid P_1)
	{
		return ((IModuleManager)P_0).FindUnitByUid(P_1);
	}

	internal static object Dr40u0XMTSvxhDSXhlJ(object P_0)
	{
		return ((ILicensedModuleAssembly)P_0).LicenseUnit;
	}

	internal static object t26Zu9XaSY7T9W7HCeB(object P_0)
	{
		return ((ICustomActivityHeader)P_0).Name;
	}

	internal static object Udoh5fXYTX2Tpmg9DN5(object P_0)
	{
		return ((ICustomActivityHeader)P_0).Published;
	}

	internal static object NxJFO6XvGgFsMd9dKWU(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static object kKBrIRXPivj386fAGMx(object P_0)
	{
		return ((ICustomActivity)P_0).Parameters;
	}

	internal static object Rso2y8X4s29M47svD93(object P_0)
	{
		return ((CustomActivityParameters)P_0).AssemblyName;
	}

	internal static object OZO403X9hF0WHpcwG8e(object P_0, bool P_1)
	{
		return ComponentManager.FindLoadedAssembly((string)P_0, P_1);
	}

	internal static bool siR4JVXTKnlVB5JotnI(object P_0, object P_1)
	{
		return (Assembly)P_0 == (Assembly)P_1;
	}

	internal static object iLtl1GXc6vErd4Qr13s(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object Gr5EdHXNUPxpfkOmwa7(object P_0, object P_1)
	{
		return ((ILockKeyFactory)P_0).Get((string)P_1);
	}

	internal static object ekhamqXdieXbgebP1Gr(object P_0)
	{
		return ((CustomActivityParameters)P_0).AssemblyRaw;
	}

	internal static object h6ZgjVXjcmQJptQVX8c(object P_0)
	{
		return ((CustomActivityParameters)P_0).DebugRaw;
	}

	internal static object S602ClXSsnY07veHEFI(object P_0, object P_1)
	{
		return ComponentManager.LoadAssembly((byte[])P_0, (byte[])P_1);
	}

	internal static object uj8f4FXkuixwML2JYHc(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static void wcsHl7XbNc5HNsm2c02(object P_0)
	{
		Monitor.Exit(P_0);
	}

	internal static void VLipCSXUabDgmleyPWU(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object Wt4snrXmDssMwhnhLLI(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object Jekl08XAArfO8OSRhCw(object P_0)
	{
		return ((ClassMetadata)P_0).FullTypeName;
	}

	internal static Type HcAcdlXpRHhCQVbxcxx(object P_0, object P_1)
	{
		return ((Assembly)P_0).GetType((string)P_1);
	}

	internal static bool bJlqaQXG8EMviISNpxw(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static object vmQg2RXnKOHfO0Wc6Pv(Type P_0)
	{
		return Activator.CreateInstance(P_0);
	}

	internal static void niGJwDXy990FCTKqUov(object P_0)
	{
		((IInternalProcessesService)P_0).Check();
	}

	internal static object thEMhUXOqWYjOleIsHM(object P_0)
	{
		return ((ICustomActivity)P_0).ScriptModule;
	}

	internal static object X44NrfX6btWLMbegjjG(object P_0)
	{
		return ((ScriptModule)P_0).AssemblyName;
	}

	internal static object fApQqLXRI4ac0XTGDY2(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object y1SgyVX0yV4m3Jpmgdy(object P_0)
	{
		return ((ScriptModule)P_0).AssemblyRaw;
	}

	internal static object MHl3AoXBkK4MiGxT81G(object P_0)
	{
		return ((ScriptModule)P_0).DebugRaw;
	}

	internal static object O9qSkbXWeCX8ohtAlnj(object P_0)
	{
		return ((ScriptModule)P_0).Namespace;
	}

	internal static object V4ChxoXHgFZC0cMi83F(object P_0)
	{
		return ((ScriptModule)P_0).ClassName;
	}

	internal static object qtiqr4XeePiL4tcpRUF(object P_0)
	{
		return ((IExecutionScopeBuilder)P_0).StartScope();
	}

	internal static object oojjDvXisZp7w7TP1pt(object P_0, Type P_1)
	{
		return ((IExecutionScope)P_0).Resolve(P_1);
	}

	internal static void sS1ixoXuRjfxCn1ov3f(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static bool Gc2TFeXlaDOsD4uUXZw(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static DateTime jDLvZxXfVEhlnU43NQm()
	{
		return DateTime.Now;
	}

	internal static TimeSpan DWjJ27XL8VuDs8NdgYX(DateTime P_0, DateTime P_1)
	{
		return P_0 - P_1;
	}

	internal static object f6wZPFXJydQH86vrKIw(object P_0)
	{
		return string.Concat((object[])P_0);
	}

	internal static object d40IB9XrG2WIkFSuBUQ(object P_0, object P_1, StringSplitOptions P_2)
	{
		return ((string)P_0).Split((string[])P_1, P_2);
	}

	internal static bool ztnT2wX7sbKHUgZfLlL(object P_0, object P_1)
	{
		return ((string)P_0).Contains((string)P_1);
	}

	internal static int UCjcKgX5rtJqHiWWL5s(object P_0, char P_1)
	{
		return ((string)P_0).IndexOf(P_1);
	}

	internal static object nseVbEXgcpOe48JC3yR(object P_0, int P_1)
	{
		return ((string)P_0).Substring(P_1);
	}

	internal static object iIBNTPX1OCvGVmYjSpe(object P_0)
	{
		return ((MethodBase)P_0).GetParameters();
	}

	internal static object XXAZ27XIxx8OKS9r8Jl(object P_0)
	{
		return ((MemberInfo)P_0).Name;
	}

	internal static object pGRyElXZcKMUb2gOTa7(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static bool wdHS60XzA6MSsCcPDUk(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static object Eo6O8yoEYTttIIrVp8A()
	{
		return Logger.Log;
	}

	internal static object gLafqjoCKlmCKnLHpFX(Type type)
	{
		return GetTypeInfo(type);
	}

	internal static void oGWrDWoXbG3oW2uCCcQ()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}

	internal static object XMIXQZooU10AewtTIWp(object P_0)
	{
		return Logger.GetLogger((string)P_0);
	}
}
