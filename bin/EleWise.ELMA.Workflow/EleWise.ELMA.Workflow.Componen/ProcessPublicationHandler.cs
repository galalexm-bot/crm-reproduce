using System;
using System.Collections;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.Workflow.ExtensionPoints;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Services;
using EleWise.ELMA.Workflow.ViewItems;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Components;

[Component]
internal sealed class ProcessPublicationHandler : IProcessPublicationHandler
{
	private readonly IWorkflowProcessDependencyService workflowProcessDependencyService;

	private static ProcessPublicationHandler xmJqJEO09GX07YJ68MVI;

	public ProcessPublicationHandler(IWorkflowProcessDependencyService workflowProcessDependencyService)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		EUZNdUO0Rp1vCIXssSAL();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3bb28bf622874b4689f9265e58d14823 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				this.workflowProcessDependencyService = workflowProcessDependencyService;
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3ab79470996d472f815915b21f45aac1 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public void UpdateProcess(IWorkflowProcess process)
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			default:
				UpdateIncludeList(process);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				if (eMVTONO067Br4mFWD8WG(process.Context) != null)
				{
					CollectDependencies(process);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b != 0)
					{
						num2 = 4;
					}
				}
				else
				{
					num2 = 2;
				}
				break;
			case 4:
				Vel0XfO0qdu75eBuULRl(process);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58fb165cafed422d973d4a7156526541 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				return;
			}
		}
	}

	private void CollectDependencies(IWorkflowProcess process)
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
				workflowProcessDependencyService.CollectDependencies(process);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f508947b0d94af1961e5aa17a8a2044 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private static void UpdateCalculateScriptMethodNames(object process)
	{
		//Discarded unreachable code: IL_0036, IL_0045, IL_00cc, IL_00db, IL_017c, IL_018f, IL_021a, IL_022d, IL_023c, IL_024d, IL_025c, IL_02cc, IL_02db, IL_03b4, IL_03c7, IL_0471, IL_0480, IL_048b, IL_0502, IL_050c, IL_05ae, IL_05c1, IL_05d0, IL_0601, IL_0639, IL_06c7, IL_06da, IL_06e9
		int num = 4;
		List<PropertyMetadata>.Enumerator enumerator5 = default(List<PropertyMetadata>.Enumerator);
		IViewModelPropertyMetadata viewModelPropertyMetadata = default(IViewModelPropertyMetadata);
		List<ComputedValue>.Enumerator enumerator3 = default(List<ComputedValue>.Enumerator);
		List<WorkflowForm>.Enumerator enumerator = default(List<WorkflowForm>.Enumerator);
		WorkflowTaskForm workflowTaskForm = default(WorkflowTaskForm);
		List<ViewItemTransformation>.Enumerator enumerator4 = default(List<ViewItemTransformation>.Enumerator);
		ViewItemTransformationChange viewItemTransformationChange = default(ViewItemTransformationChange);
		FormViewItem formViewItem2 = default(FormViewItem);
		WorkflowForm current = default(WorkflowForm);
		IEnumerator<ViewItem> enumerator2 = default(IEnumerator<ViewItem>);
		FormViewItem formViewItem = default(FormViewItem);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 3:
					try
					{
						while (true)
						{
							int num13;
							if (!enumerator5.MoveNext())
							{
								num13 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_805f3361d2ba4dac8da4174f89314253 != 0)
								{
									num13 = 0;
								}
								goto IL_0054;
							}
							goto IL_0199;
							IL_0199:
							viewModelPropertyMetadata = enumerator5.Current as IViewModelPropertyMetadata;
							num13 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b != 0)
							{
								num13 = 0;
							}
							goto IL_0054;
							IL_0054:
							while (true)
							{
								switch (num13)
								{
								case 3:
									uBdeZNO0QWm5L3MM9swZ(zoOjkFO0TvwnToCeSQlH(viewModelPropertyMetadata), ((AbstractMetadata)eMVTONO067Br4mFWD8WG(yGTd0TO03pnEQBItHkrN(process))).Uid);
									num13 = 5;
									continue;
								case 2:
									break;
								case 6:
									try
									{
										while (true)
										{
											int num16;
											if (!enumerator3.MoveNext())
											{
												int num15 = 2;
												num16 = num15;
												goto IL_00ea;
											}
											goto IL_011a;
											IL_00ea:
											switch (num16)
											{
											case 1:
												break;
											default:
												goto IL_011a;
											case 2:
												goto end_IL_0100;
											}
											continue;
											IL_011a:
											uBdeZNO0QWm5L3MM9swZ(enumerator3.Current, LqGLc6O0p6LQ0JJXt3ZH(eMVTONO067Br4mFWD8WG(yGTd0TO03pnEQBItHkrN(process))));
											num16 = 1;
											if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 == 0)
											{
												num16 = 1;
											}
											goto IL_00ea;
											continue;
											end_IL_0100:
											break;
										}
									}
									finally
									{
										((IDisposable)enumerator3).Dispose();
										int num17 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 != 0)
										{
											num17 = 0;
										}
										switch (num17)
										{
										case 0:
											break;
										}
									}
									break;
								case 4:
									goto IL_0199;
								default:
									if (viewModelPropertyMetadata != null)
									{
										num13 = 3;
										continue;
									}
									break;
								case 5:
								{
									enumerator3 = viewModelPropertyMetadata.ComputedValues.GetEnumerator();
									int num14 = 6;
									num13 = num14;
									continue;
								}
								case 1:
									goto end_IL_00a0;
								}
								break;
							}
							continue;
							end_IL_00a0:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator5).Dispose();
						int num18 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e != 0)
						{
							num18 = 0;
						}
						switch (num18)
						{
						case 0:
							break;
						}
					}
					break;
				case 2:
					try
					{
						while (true)
						{
							IL_0666:
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 8;
								goto IL_026b;
							}
							goto IL_0643;
							IL_026b:
							while (true)
							{
								switch (num3)
								{
								case 10:
									if (workflowTaskForm != null)
									{
										num3 = 2;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a != 0)
										{
											num3 = 7;
										}
										continue;
									}
									goto IL_0666;
								case 6:
									try
									{
										while (true)
										{
											IL_0372:
											int num9;
											if (!enumerator4.MoveNext())
											{
												num9 = 4;
												goto IL_02ea;
											}
											goto IL_0335;
											IL_02ea:
											while (true)
											{
												switch (num9)
												{
												case 3:
													((FormViewItemTransformation)wItKfvO0AlyXDjFmwamf(workflowTaskForm)).Items.Add(viewItemTransformationChange);
													num9 = 1;
													if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5537a063960e465db83a04e35eea441b == 0)
													{
														num9 = 0;
													}
													continue;
												case 2:
													if (viewItemTransformationChange != null)
													{
														num9 = 0;
														if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 == 0)
														{
															num9 = 3;
														}
														continue;
													}
													goto IL_0372;
												case 1:
													goto IL_0372;
												case 4:
													goto end_IL_0372;
												}
												break;
											}
											goto IL_0335;
											IL_0335:
											viewItemTransformationChange = enumerator4.Current as ViewItemTransformationChange;
											int num10 = 2;
											num9 = num10;
											goto IL_02ea;
											continue;
											end_IL_0372:
											break;
										}
									}
									finally
									{
										((IDisposable)enumerator4).Dispose();
										int num11 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b84ccb8b1bd147ef900b852047ecbf45 != 0)
										{
											num11 = 0;
										}
										switch (num11)
										{
										case 0:
											break;
										}
									}
									goto case 4;
								case 7:
								{
									formViewItem2 = (FormViewItem)c0SDulO0MIMW0GbIwFpC(current, process);
									int num8 = 5;
									num3 = num8;
									continue;
								}
								case 1:
									enumerator2 = formViewItem.GetAllItems(ignoreHide: false).GetEnumerator();
									num3 = 4;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_545887e65739480a965b7ddfab7d0632 == 0)
									{
										num3 = 9;
									}
									continue;
								case 3:
									workflowTaskForm = current as WorkflowTaskForm;
									num3 = 10;
									continue;
								case 5:
									formViewItem = (FormViewItem)formViewItem2.Clone();
									num3 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f8ecc99a1f4a4b6abc73e9b50261ea83 == 0)
									{
										num3 = 0;
									}
									continue;
								case 4:
									x9nwFnO0GVroMC6kpwZ2(workflowTaskForm, ClassSerializationHelper.CloneObjectByXml((FormViewItemTransformation)wItKfvO0AlyXDjFmwamf(workflowTaskForm)));
									num3 = 11;
									continue;
								case 9:
									try
									{
										while (true)
										{
											int num4;
											if (!ElwULHO0kgRy6rT7HKX6(enumerator2))
											{
												num4 = 0;
												if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae4e393cddc4c98b9896b25c9e18c7d == 0)
												{
													num4 = 2;
												}
												goto IL_048f;
											}
											goto IL_04a9;
											IL_04a9:
											enumerator3 = enumerator2.Current.DynamicProperties.GetEnumerator();
											num4 = 1;
											if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_938c6be4ea2248868d7ed5d0e3346006 != 0)
											{
												num4 = 3;
											}
											goto IL_048f;
											IL_048f:
											switch (num4)
											{
											case 1:
												break;
											default:
												continue;
											case 3:
												try
												{
													while (true)
													{
														int num5;
														if (!enumerator3.MoveNext())
														{
															num5 = 1;
															if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8a6cf36da0b84f319a7cf27018f28f5b != 0)
															{
																num5 = 1;
															}
															goto IL_0510;
														}
														goto IL_0526;
														IL_0526:
														ComputedValueHelper.SetCalculateScriptMethodName(enumerator3.Current, ((AbstractMetadata)eMVTONO067Br4mFWD8WG(yGTd0TO03pnEQBItHkrN(process))).Uid);
														num5 = 0;
														if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c559093b7320494babd70d164a6df42d == 0)
														{
															num5 = 0;
														}
														goto IL_0510;
														IL_0510:
														switch (num5)
														{
														case 2:
															break;
														default:
															continue;
														case 1:
															goto end_IL_055c;
														}
														goto IL_0526;
														continue;
														end_IL_055c:
														break;
													}
												}
												finally
												{
													((IDisposable)enumerator3).Dispose();
													int num6 = 0;
													if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b876fa7b083748c8abf8c4b192a11078 != 0)
													{
														num6 = 0;
													}
													switch (num6)
													{
													case 0:
														break;
													}
												}
												continue;
											case 2:
												goto end_IL_04d6;
											}
											goto IL_04a9;
											continue;
											end_IL_04d6:
											break;
										}
									}
									finally
									{
										if (enumerator2 != null)
										{
											int num7 = 0;
											if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 != 0)
											{
												num7 = 0;
											}
											while (true)
											{
												switch (num7)
												{
												default:
													KmuOKpO0UgA4s7wQixqc(enumerator2);
													num7 = 1;
													if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4ef74b4b7d13430e9d2f9b78cbdb367b != 0)
													{
														num7 = 0;
													}
													continue;
												case 1:
													break;
												}
												break;
											}
										}
									}
									goto case 2;
								case 11:
									goto IL_0666;
								case 2:
									enumerator4 = ((FormViewItemTransformation)N5IK6aO0VeJIk55yGG66(formViewItem, formViewItem2)).Items.GetEnumerator();
									num3 = 6;
									continue;
								case 8:
									return;
								}
								break;
							}
							goto IL_0643;
							IL_0643:
							current = enumerator.Current;
							num3 = 3;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a50dda04dedf4515816f963c67783c8f != 0)
							{
								num3 = 3;
							}
							goto IL_026b;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num12 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b == 0)
						{
							num12 = 0;
						}
						switch (num12)
						{
						case 0:
							break;
						}
					}
				case 0:
					return;
				case 1:
					break;
				case 4:
					goto end_IL_0012;
				}
				enumerator = ((WorkflowFormsContainer)uf0fwPO0C5m6JZ6TSns9(process)).Items.GetEnumerator();
				num2 = 2;
				continue;
				end_IL_0012:
				break;
			}
			enumerator5 = ((EntityMetadata)yGTd0TO03pnEQBItHkrN(process)).ViewModelMetadata.Properties.GetEnumerator();
			num = 3;
		}
	}

	private void UpdateIncludeList(IWorkflowProcess workflowProcess)
	{
		//Discarded unreachable code: IL_004a, IL_0100, IL_010f
		int num = 2;
		IWorkflowProcess parent = default(IWorkflowProcess);
		DataClassMetadata dataClassMetadata = default(DataClassMetadata);
		DataClassDependency signature = default(DataClassDependency);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				default:
					return;
				case 6:
					obj = null;
					break;
				case 5:
				{
					ProcessContext context = parent.Context;
					if (context != null)
					{
						obj = eMVTONO067Br4mFWD8WG(context);
						break;
					}
					goto end_IL_0012;
				}
				case 8:
					return;
				case 9:
					parent = workflowProcess.Parent;
					num2 = 4;
					continue;
				case 4:
					if (parent != null)
					{
						num2 = 5;
						continue;
					}
					goto case 6;
				case 0:
					return;
				case 1:
					dataClassMetadata.IncludeList.Clear();
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_32f3e755437f4eacb85c8a0d536f83ea == 0)
					{
						num2 = 9;
					}
					continue;
				case 2:
					dataClassMetadata = (DataClassMetadata)eMVTONO067Br4mFWD8WG(yGTd0TO03pnEQBItHkrN(workflowProcess));
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd == 0)
					{
						num2 = 0;
					}
					continue;
				case 7:
					dataClassMetadata.IncludeList.Add(signature);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					obj = null;
					break;
				}
				if (obj != null)
				{
					signature = ((DataClassMetadata)eMVTONO067Br4mFWD8WG(yGTd0TO03pnEQBItHkrN(parent))).GetSignature(simple: true);
					num2 = 7;
					continue;
				}
				num2 = 7;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f33560c5d18b4e10b24a458578aa60fd == 0)
				{
					num2 = 8;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 3;
		}
	}

	internal static void EUZNdUO0Rp1vCIXssSAL()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool Hgmp8uO0WEcRSYk4AY93()
	{
		return xmJqJEO09GX07YJ68MVI == null;
	}

	internal static ProcessPublicationHandler mUW4SwO0jqodYjTgk1D0()
	{
		return xmJqJEO09GX07YJ68MVI;
	}

	internal static object eMVTONO067Br4mFWD8WG(object P_0)
	{
		return ((EntityMetadata)P_0).ViewModelMetadata;
	}

	internal static void Vel0XfO0qdu75eBuULRl(object P_0)
	{
		UpdateCalculateScriptMethodNames(P_0);
	}

	internal static object yGTd0TO03pnEQBItHkrN(object P_0)
	{
		return ((IWorkflowProcess)P_0).Context;
	}

	internal static object zoOjkFO0TvwnToCeSQlH(object P_0)
	{
		return ((IViewModelPropertyMetadata)P_0).ComputedValue;
	}

	internal static void uBdeZNO0QWm5L3MM9swZ(object P_0, Guid P_1)
	{
		ComputedValueHelper.SetCalculateScriptMethodName((IComputedValue)P_0, P_1);
	}

	internal static Guid LqGLc6O0p6LQ0JJXt3ZH(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static object uf0fwPO0C5m6JZ6TSns9(object P_0)
	{
		return ((IWorkflowProcess)P_0).Forms;
	}

	internal static object c0SDulO0MIMW0GbIwFpC(object P_0, object P_1)
	{
		return ((WorkflowForm)P_0).CreateFormViewItem((IWorkflowProcess)P_1);
	}

	internal static bool ElwULHO0kgRy6rT7HKX6(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void KmuOKpO0UgA4s7wQixqc(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object N5IK6aO0VeJIk55yGG66(object P_0, object P_1)
	{
		return ((RootViewItem)P_0).CreateTransformation((RootViewItem)P_1);
	}

	internal static object wItKfvO0AlyXDjFmwamf(object P_0)
	{
		return ((WorkflowTaskForm)P_0).Transformation;
	}

	internal static void x9nwFnO0GVroMC6kpwZ2(object P_0, object P_1)
	{
		((WorkflowTaskForm)P_0).Transformation = (FormViewItemTransformation)P_1;
	}
}
