using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Components;

[Component(Order = 100)]
internal class WorkflowFormDependencyExtension : IFormDependencyExtension
{
	internal static WorkflowFormDependencyExtension gDSe1rOyzwyNJkT1GpO1;

	public bool CheckType(Guid uid)
	{
		return WorkflowProcessManager.Instance.LoadOrNull(uid) != null;
	}

	public bool ExistForm(Guid objectUid, Guid formUid)
	{
		//Discarded unreachable code: IL_00ae, IL_00bd
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = default(_003C_003Ec__DisplayClass1_0);
		IWorkflowProcess workflowProcess = default(IWorkflowProcess);
		while (true)
		{
			switch (num2)
			{
			case 1:
				_003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b876fa7b083748c8abf8c4b192a11078 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				_003C_003Ec__DisplayClass1_.formUid = formUid;
				num2 = 5;
				break;
			case 2:
				return workflowProcess.Forms.Items.Any(_003C_003Ec__DisplayClass1_._003CExistForm_003Eb__0);
			case 4:
				return false;
			case 3:
				if (workflowProcess == null)
				{
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 == 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 2;
			case 5:
				workflowProcess = WorkflowProcessManager.Instance.LoadOrNull(objectUid);
				num2 = 3;
				break;
			}
		}
	}

	public IEnumerable<Guid> GetFormUids(Guid uid)
	{
		_003C_003Ec__DisplayClass2_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass2_0();
		CS_0024_003C_003E8__locals0.result = new List<Guid>();
		IWorkflowProcess workflowProcess = WorkflowProcessManager.Instance.LoadOrNull(uid);
		if (workflowProcess == null)
		{
			return CS_0024_003C_003E8__locals0.result;
		}
		workflowProcess.Forms.Items.ForEach(delegate(WorkflowForm q)
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
					CS_0024_003C_003E8__locals0.result.Add(_003C_003Ec__DisplayClass2_0.nOn9S6vOMhCsLyxY4gG9(q));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_639c11c7bb65456db9f29c9c42f28bf7 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		});
		return CS_0024_003C_003E8__locals0.result;
	}

	public IEnumerable<IFormDependencyData> GetDependenciesForBaseClasses(Guid dependObjectUid, Guid dependObjectFormUid, IMetadata usesObjectMetadata, Guid usesObjectFormUid, FormDependencyDataType type)
	{
		return new List<IFormDependencyData>();
	}

	public IEnumerable<IFormDependencyData> GetDependenciesForBaseClasses(Guid dependObjectUid, Guid dependObjectFormUid, Guid usesObjectUid, Guid usesObjectFormUid, FormDependencyDataType type)
	{
		List<IFormDependencyData> list = new List<IFormDependencyData>();
		IWorkflowProcess workflowProcess = WorkflowProcessManager.Instance.LoadOrNull(usesObjectUid);
		if (workflowProcess == null)
		{
			return list;
		}
		for (IWorkflowProcess parent = workflowProcess.Parent; parent != null; parent = parent.Parent)
		{
			list.Add(new FormDependencyData(workflowProcess.Uid, dependObjectFormUid, parent.Uid, usesObjectFormUid, FormDependencyDataType.Direct));
		}
		return list;
	}

	public void GenerateNewDependencies(IMetadata dependObjectMetadata)
	{
	}

	public void GenerateNewDependencies(Guid dependObjectUid)
	{
		//Discarded unreachable code: IL_00eb, IL_0129, IL_01b2, IL_01c1, IL_01d2, IL_01dc, IL_022a, IL_0234, IL_02f0, IL_0303, IL_0312, IL_0379, IL_03b1, IL_03c0, IL_040b, IL_041a, IL_0425, IL_0508, IL_0512, IL_05e1, IL_05f4, IL_0603, IL_06a6, IL_06b5, IL_06e2, IL_06f1, IL_0701, IL_0710, IL_08a9, IL_08db, IL_09c3, IL_09fb, IL_0a0f, IL_0a19, IL_0b5f, IL_0b72, IL_0c80
		int num = 14;
		IWorkflowProcess workflowProcess2 = default(IWorkflowProcess);
		IWorkflowProcess workflowProcess = default(IWorkflowProcess);
		List<IFormDependencyData> list = default(List<IFormDependencyData>);
		List<WorkflowForm>.Enumerator enumerator = default(List<WorkflowForm>.Enumerator);
		IEnumerator<IConnectorSettingsExtensionElement> enumerator2 = default(IEnumerator<IConnectorSettingsExtensionElement>);
		IConnectorSettingsExtensionElement current2 = default(IConnectorSettingsExtensionElement);
		IEnumerator<Guid> enumerator3 = default(IEnumerator<Guid>);
		Guid current3 = default(Guid);
		List<Guid>.Enumerator enumerator4 = default(List<Guid>.Enumerator);
		Guid current4 = default(Guid);
		BPMNFlowElement bPMNFlowElement = default(BPMNFlowElement);
		List<Guid> list2 = default(List<Guid>);
		CommonEditEntityWorkflowElement commonEditEntityWorkflowElement = default(CommonEditEntityWorkflowElement);
		IFormDependency formDependency = default(IFormDependency);
		IEnumerator<ConnectorSettingsExtension> enumerator5 = default(IEnumerator<ConnectorSettingsExtension>);
		_003C_003Ec__DisplayClass6_0 _003C_003Ec__DisplayClass6_ = default(_003C_003Ec__DisplayClass6_0);
		Connector connector = default(Connector);
		Guid current5 = default(Guid);
		Guid? formUid = default(Guid?);
		ClassMetadata classMetadata = default(ClassMetadata);
		WorkflowForm current = default(WorkflowForm);
		FormViewItem form = default(FormViewItem);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					workflowProcess2 = (IWorkflowProcess)eNgQaiOm8MxQ3322ajQe(workflowProcess);
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae4e393cddc4c98b9896b25c9e18c7d != 0)
					{
						num2 = 1;
					}
					continue;
				case 11:
					return;
				default:
					list = new List<IFormDependencyData>();
					num2 = 15;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b == 0)
					{
						num2 = 5;
					}
					continue;
				case 18:
					if (VEBEJwOmsKSVimlLY33T(workflowProcess) == null)
					{
						num2 = 9;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9269d021c6f148b6a1c4afb8cee03b6c != 0)
						{
							num2 = 9;
						}
						continue;
					}
					if (!xOSSPYOmJ8oDvBbqpqH7(VEBEJwOmsKSVimlLY33T(workflowProcess)))
					{
						num2 = 16;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_938c6be4ea2248868d7ed5d0e3346006 == 0)
						{
							num2 = 8;
						}
						continue;
					}
					goto end_IL_0012;
				case 5:
					workflowProcess2 = workflowProcess2.Parent;
					num2 = 7;
					continue;
				case 15:
					enumerator = ((WorkflowFormsContainer)peq9udOmZkN3Xa9YOxxC(workflowProcess)).Items.GetEnumerator();
					num2 = 6;
					continue;
				case 1:
				case 7:
					if (workflowProcess2 == null)
					{
						num2 = 18;
						continue;
					}
					break;
				case 3:
					try
					{
						while (true)
						{
							int num5;
							if (!rZnhGWOmXcDtqDYurw7f(enumerator2))
							{
								num5 = 15;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_60c5782a184b457aa78da2e5c62d4e27 == 0)
								{
									num5 = 20;
								}
								goto IL_0137;
							}
							goto IL_08b3;
							IL_08b3:
							current2 = enumerator2.Current;
							num5 = 14;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_69cb4a76addb44f28bb765f059e441c7 == 0)
							{
								num5 = 22;
							}
							goto IL_0137;
							IL_0137:
							while (true)
							{
								int num10;
								switch (num5)
								{
								case 2:
									try
									{
										while (true)
										{
											IL_01fe:
											int num6;
											if (!enumerator3.MoveNext())
											{
												num6 = 0;
												if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f8ecc99a1f4a4b6abc73e9b50261ea83 != 0)
												{
													num6 = 0;
												}
												goto IL_01e0;
											}
											goto IL_031d;
											IL_031d:
											current3 = enumerator3.Current;
											num6 = 2;
											goto IL_01e0;
											IL_01e0:
											while (true)
											{
												switch (num6)
												{
												case 1:
													goto IL_01fe;
												case 4:
													try
													{
														while (true)
														{
															int num7;
															if (!enumerator4.MoveNext())
															{
																num7 = 0;
																if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e8980a9fd9d44c20920ffa276900c96f != 0)
																{
																	num7 = 1;
																}
																goto IL_0238;
															}
															goto IL_0278;
															IL_0278:
															current4 = enumerator4.Current;
															num7 = 3;
															goto IL_0238;
															IL_0238:
															while (true)
															{
																switch (num7)
																{
																case 2:
																	goto IL_0278;
																case 3:
																	list.Add(new FormDependencyData(s5FBLBOmvKd3tIJaGHd2(workflowProcess), hWatpfOmmcgBtlMyFArx(bPMNFlowElement), current4, current3, FormDependencyDataType.Direct));
																	num7 = 0;
																	if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6d48f3b4557a49578bf7f5ef0517e0be == 0)
																	{
																		num7 = 0;
																	}
																	continue;
																case 1:
																	goto end_IL_0252;
																}
																break;
															}
															continue;
															end_IL_0252:
															break;
														}
													}
													finally
													{
														((IDisposable)enumerator4).Dispose();
														int num8 = 0;
														if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eef7d2ca1c3c4b74aeb81172ed542639 == 0)
														{
															num8 = 0;
														}
														switch (num8)
														{
														case 0:
															break;
														}
													}
													goto IL_01fe;
												case 3:
													goto IL_031d;
												case 2:
													enumerator4 = list2.GetEnumerator();
													num6 = 4;
													if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 != 0)
													{
														num6 = 1;
													}
													continue;
												case 0:
													break;
												}
												break;
											}
											break;
										}
									}
									finally
									{
										if (enumerator3 != null)
										{
											int num9 = 0;
											if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 != 0)
											{
												num9 = 0;
											}
											while (true)
											{
												switch (num9)
												{
												default:
													vXG2qEOmtDWQkbsGEecN(enumerator3);
													num9 = 1;
													if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cb262bcfe4074a1ab16e653815d57f28 == 0)
													{
														num9 = 0;
													}
													continue;
												case 1:
													break;
												}
												break;
											}
										}
									}
									goto default;
								case 1:
									cD0KTvOm5VUNKRVxdxHO(commonEditEntityWorkflowElement);
									num10 = 23;
									goto IL_0133;
								case 24:
									if (formDependency == null)
									{
										num5 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b1ab9396b25b43af8f32e24b1948be96 != 0)
										{
											num5 = 0;
										}
										continue;
									}
									goto case 21;
								case 25:
									try
									{
										while (true)
										{
											IL_047c:
											int num11;
											if (!rZnhGWOmXcDtqDYurw7f(enumerator5))
											{
												num11 = 6;
												goto IL_0429;
											}
											goto IL_045b;
											IL_0429:
											while (true)
											{
												switch (num11)
												{
												case 8:
													break;
												case 4:
													goto IL_047c;
												case 2:
													_003C_003Ec__DisplayClass6_.settings = enumerator5.Current;
													num11 = 3;
													continue;
												default:
													connector = bPMNFlowElement.OutputConnectors.FirstOrDefault(_003C_003Ec__DisplayClass6_._003CGenerateNewDependencies_003Eb__0);
													num11 = 7;
													if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_08023922bb0e4e809e5cff73a2b04988 == 0)
													{
														num11 = 5;
													}
													continue;
												case 5:
													enumerator4 = list2.GetEnumerator();
													num11 = 1;
													if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 == 0)
													{
														num11 = 0;
													}
													continue;
												case 1:
													try
													{
														while (true)
														{
															IL_059f:
															int num12;
															if (!enumerator4.MoveNext())
															{
																num12 = 2;
																goto IL_0516;
															}
															goto IL_0530;
															IL_0516:
															while (true)
															{
																switch (num12)
																{
																case 3:
																	break;
																default:
																{
																	List<IFormDependencyData> list3 = list;
																	Guid dependObjectUid2 = s5FBLBOmvKd3tIJaGHd2(workflowProcess);
																	Guid dependObjectFormUid = hWatpfOmmcgBtlMyFArx(connector);
																	Guid usesObjectUid = current5;
																	formUid = _003C_003Ec__DisplayClass6_.settings.FormUid;
																	list3.Add(new FormDependencyData(dependObjectUid2, dependObjectFormUid, usesObjectUid, formUid.Value, FormDependencyDataType.Direct));
																	num12 = 1;
																	if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e2e244178c44ea09cd756894b022a62 == 0)
																	{
																		num12 = 0;
																	}
																	continue;
																}
																case 1:
																	goto IL_059f;
																case 2:
																	goto end_IL_059f;
																}
																break;
															}
															goto IL_0530;
															IL_0530:
															current5 = enumerator4.Current;
															num12 = 0;
															if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede != 0)
															{
																num12 = 0;
															}
															goto IL_0516;
															continue;
															end_IL_059f:
															break;
														}
													}
													finally
													{
														((IDisposable)enumerator4).Dispose();
														int num13 = 0;
														if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_639c11c7bb65456db9f29c9c42f28bf7 != 0)
														{
															num13 = 0;
														}
														switch (num13)
														{
														case 0:
															break;
														}
													}
													goto IL_047c;
												case 7:
													if (connector != null)
													{
														num11 = 5;
														continue;
													}
													goto IL_047c;
												case 3:
													formUid = _003C_003Ec__DisplayClass6_.settings.FormUid;
													num11 = 9;
													if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1c37d4e24e094858975336738e156495 == 0)
													{
														num11 = 6;
													}
													continue;
												case 9:
													if (formUid.HasValue)
													{
														num11 = 0;
														if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_61395ebf330446ac8ce99b55ee3acfa9 != 0)
														{
															num11 = 0;
														}
														continue;
													}
													goto IL_047c;
												case 6:
													goto end_IL_047c;
												}
												break;
											}
											goto IL_045b;
											IL_045b:
											_003C_003Ec__DisplayClass6_ = new _003C_003Ec__DisplayClass6_0();
											num11 = 1;
											if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d == 0)
											{
												num11 = 2;
											}
											goto IL_0429;
											continue;
											end_IL_047c:
											break;
										}
									}
									finally
									{
										int num15;
										if (enumerator5 == null)
										{
											int num14 = 2;
											num15 = num14;
											goto IL_068b;
										}
										goto IL_06c0;
										IL_068b:
										switch (num15)
										{
										default:
											goto end_IL_0672;
										case 2:
											goto end_IL_0672;
										case 1:
											break;
										case 0:
											goto end_IL_0672;
										}
										goto IL_06c0;
										IL_06c0:
										enumerator5.Dispose();
										num15 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e9561fecdd4d49678d9f9ea7d295fb1b == 0)
										{
											num15 = 0;
										}
										goto IL_068b;
										end_IL_0672:;
									}
									break;
								case 14:
									if (fJeiGnOmym07osXdSugI(formDependency.FormUids) > 0)
									{
										num10 = 3;
										goto IL_0133;
									}
									goto default;
								case 3:
									enumerator3 = formDependency.FormUids.GetEnumerator();
									num5 = 2;
									continue;
								case 4:
									if (bPMNFlowElement != null)
									{
										num5 = 16;
										continue;
									}
									break;
								case 16:
									formDependency = current2 as IFormDependency;
									num5 = 7;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 == 0)
									{
										num5 = 24;
									}
									continue;
								case 6:
								case 10:
								case 15:
								case 18:
								case 26:
									enumerator5 = current2.ConnectorSettings.GetEnumerator();
									num5 = 19;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0991fd79553c4ecc82e8b5cb79c2bff2 == 0)
									{
										num5 = 25;
									}
									continue;
								case 13:
									if (commonEditEntityWorkflowElement == null)
									{
										num5 = 26;
										continue;
									}
									goto case 12;
								case 23:
									classMetadata = grPEYcOmB1TY9YDU11W4(cD0KTvOm5VUNKRVxdxHO(commonEditEntityWorkflowElement), true, true) as ClassMetadata;
									num5 = 11;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eef7d2ca1c3c4b74aeb81172ed542639 == 0)
									{
										num5 = 2;
									}
									continue;
								case 5:
									list.Add(new FormDependencyData(s5FBLBOmvKd3tIJaGHd2(workflowProcess), hWatpfOmmcgBtlMyFArx(bPMNFlowElement), cD0KTvOm5VUNKRVxdxHO(commonEditEntityWorkflowElement), G1yseKOmgse5yiEbScsq(commonEditEntityWorkflowElement), FormDependencyDataType.Direct));
									num5 = 2;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ecf910d183864897a7c8ec77e01689a4 != 0)
									{
										num5 = 6;
									}
									continue;
								case 12:
									if (gXHAeYOmbNvdsTtUCcD3(commonEditEntityWorkflowElement))
									{
										num5 = 4;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a != 0)
										{
											num5 = 5;
										}
										continue;
									}
									goto case 1;
								case 21:
									if (formDependency.FormUids != null)
									{
										num5 = 14;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b == 0)
										{
											num5 = 3;
										}
										continue;
									}
									goto default;
								case 8:
									break;
								case 17:
									goto IL_08b3;
								case 9:
									list.Add(new FormDependencyData(s5FBLBOmvKd3tIJaGHd2(workflowProcess), hWatpfOmmcgBtlMyFArx(bPMNFlowElement), cD0KTvOm5VUNKRVxdxHO(commonEditEntityWorkflowElement), ((ClassDefaultForms)h0MKR1OmcXjuruKPHkDW(classMetadata)).EditUid, FormDependencyDataType.Direct));
									num5 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4459fbe344a947429d197733d274ef68 != 0)
									{
										num5 = 15;
									}
									continue;
								case 11:
									if (classMetadata == null)
									{
										num5 = 18;
										continue;
									}
									goto case 19;
								case 22:
									bPMNFlowElement = current2 as BPMNFlowElement;
									num5 = 4;
									continue;
								case 19:
									if (!(VfhmZEOmPo5P7ED4hIVU(h0MKR1OmcXjuruKPHkDW(classMetadata)) != Guid.Empty))
									{
										num5 = 10;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 != 0)
										{
											num5 = 8;
										}
										continue;
									}
									goto case 9;
								default:
									commonEditEntityWorkflowElement = current2 as CommonEditEntityWorkflowElement;
									num5 = 13;
									continue;
								case 20:
									goto end_IL_087e;
									IL_0133:
									num5 = num10;
									continue;
								}
								break;
							}
							continue;
							end_IL_087e:
							break;
						}
					}
					finally
					{
						if (enumerator2 != null)
						{
							int num16 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 != 0)
							{
								num16 = 0;
							}
							while (true)
							{
								switch (num16)
								{
								default:
									vXG2qEOmtDWQkbsGEecN(enumerator2);
									num16 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c7fe5d092d804f7e91041fb2338cec1a == 0)
									{
										num16 = 1;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
					goto case 17;
				case 6:
					try
					{
						while (true)
						{
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b == 0)
								{
									num3 = 0;
								}
								goto IL_0a1d;
							}
							goto IL_0aac;
							IL_0aac:
							current = enumerator.Current;
							num3 = 4;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_dcdfd019631e458b9cb5fa34a16a2fe1 == 0)
							{
								num3 = 1;
							}
							goto IL_0a1d;
							IL_0a1d:
							while (true)
							{
								switch (num3)
								{
								case 3:
									list.Add(new FormDependencyData(s5FBLBOmvKd3tIJaGHd2(workflowProcess), current.Uid, workflowProcess.Uid, c1k4rtOmYptmlaZD9Wxx(current), FormDependencyDataType.Child));
									num3 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4ef74b4b7d13430e9d2f9b78cbdb367b == 0)
									{
										num3 = 0;
									}
									continue;
								case 2:
									goto IL_0aac;
								case 4:
									form = current.CreateFormViewItem(workflowProcess);
									num3 = 5;
									continue;
								case 5:
									list.AddRange(FormDependencyHelper.GenerateFormDependencies(s5FBLBOmvKd3tIJaGHd2(workflowProcess), form));
									num3 = 6;
									continue;
								case 6:
									if (!(c1k4rtOmYptmlaZD9Wxx(current) == Guid.Empty))
									{
										num3 = 2;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 != 0)
										{
											num3 = 3;
										}
										continue;
									}
									break;
								case 1:
									goto end_IL_0a43;
								}
								break;
							}
							continue;
							end_IL_0a43:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num4 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 != 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
					goto case 8;
				case 8:
					list2 = new List<Guid>();
					num2 = 2;
					continue;
				case 9:
					return;
				case 13:
					if (workflowProcess == null)
					{
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 == 0)
					{
						num2 = 0;
					}
					continue;
				case 10:
					goto end_IL_0012;
				case 14:
					workflowProcess = WorkflowProcessManager.Instance.LoadOrNull(dependObjectUid);
					num2 = 10;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_938c6be4ea2248868d7ed5d0e3346006 != 0)
					{
						num2 = 13;
					}
					continue;
				case 17:
					l75u3LOmuuuLgUgM7SZD(workflowProcess.Uid, fCKD8mOmdcah4JMVt4QP(list));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e == 0)
					{
						num2 = 4;
					}
					continue;
				case 4:
					return;
				case 16:
					INtZkCOmlyaSHyG2rHgp(VEBEJwOmsKSVimlLY33T(workflowProcess));
					num2 = 8;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7de614af35034bd0a6867d08a2ee4a84 == 0)
					{
						num2 = 10;
					}
					continue;
				case 12:
					break;
				}
				list2.Add(s5FBLBOmvKd3tIJaGHd2(workflowProcess2));
				num2 = 5;
				continue;
				end_IL_0012:
				break;
			}
			enumerator2 = ((IEnumerable)geV8NnOm0SOAEMYGdO8y(workflowProcess.Diagram)).OfType<IConnectorSettingsExtensionElement>().GetEnumerator();
			num = 3;
		}
	}

	public WorkflowFormDependencyExtension()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		mRbQrfOmD6RFoNfrRRqy();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool sPwSJaOmKt0rRFdYBwpq()
	{
		return gDSe1rOyzwyNJkT1GpO1 == null;
	}

	internal static WorkflowFormDependencyExtension tbRtC3OmOZ84FYNXgCCA()
	{
		return gDSe1rOyzwyNJkT1GpO1;
	}

	internal static object peq9udOmZkN3Xa9YOxxC(object P_0)
	{
		return ((IWorkflowProcess)P_0).Forms;
	}

	internal static Guid s5FBLBOmvKd3tIJaGHd2(object P_0)
	{
		return ((IWorkflowProcess)P_0).Uid;
	}

	internal static Guid c1k4rtOmYptmlaZD9Wxx(object P_0)
	{
		return ((WorkflowForm)P_0).ParentFormUid;
	}

	internal static object eNgQaiOm8MxQ3322ajQe(object P_0)
	{
		return ((IWorkflowProcess)P_0).Parent;
	}

	internal static object VEBEJwOmsKSVimlLY33T(object P_0)
	{
		return ((IWorkflowProcess)P_0).Diagram;
	}

	internal static bool xOSSPYOmJ8oDvBbqpqH7(object P_0)
	{
		return ((Diagram)P_0).DiagramLoaded;
	}

	internal static void INtZkCOmlyaSHyG2rHgp(object P_0)
	{
		((Diagram)P_0).LoadDiagram();
	}

	internal static object geV8NnOm0SOAEMYGdO8y(object P_0)
	{
		return ((Diagram)P_0).Elements;
	}

	internal static int fJeiGnOmym07osXdSugI(object P_0)
	{
		return ((ICollection<Guid>)P_0).Count;
	}

	internal static Guid hWatpfOmmcgBtlMyFArx(object P_0)
	{
		return ((Element)P_0).Uid;
	}

	internal static void vXG2qEOmtDWQkbsGEecN(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static bool gXHAeYOmbNvdsTtUCcD3(object P_0)
	{
		return ((CommonEditEntityWorkflowElement)P_0).SelectDocumentForm;
	}

	internal static Guid cD0KTvOm5VUNKRVxdxHO(object P_0)
	{
		return ((CommonEditEntityWorkflowElement)P_0).DocumentType;
	}

	internal static Guid G1yseKOmgse5yiEbScsq(object P_0)
	{
		return ((CommonEditEntityWorkflowElement)P_0).DocumentFormUid;
	}

	internal static object grPEYcOmB1TY9YDU11W4(Guid P_0, bool P_1, bool P_2)
	{
		return MetadataLoader.LoadMetadata(P_0, P_1, P_2);
	}

	internal static object h0MKR1OmcXjuruKPHkDW(object P_0)
	{
		return ((ClassMetadata)P_0).DefaultForms;
	}

	internal static Guid VfhmZEOmPo5P7ED4hIVU(object P_0)
	{
		return ((ClassDefaultForms)P_0).EditUid;
	}

	internal static bool rZnhGWOmXcDtqDYurw7f(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static object fCKD8mOmdcah4JMVt4QP(object P_0)
	{
		return ((List<IFormDependencyData>)P_0).ToArray();
	}

	internal static void l75u3LOmuuuLgUgM7SZD(Guid P_0, object P_1)
	{
		FormDependencyHelper.Update(P_0, (IFormDependencyData[])P_1);
	}

	internal static void mRbQrfOmD6RFoNfrRRqy()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
