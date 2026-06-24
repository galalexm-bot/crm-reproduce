using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.Diagrams;
using EleWise.ELMA.Workflow.Diagrams.Shapes.Decorators;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using Nevron.Diagram;
using Nevron.Diagram.Extensions;
using Nevron.Dom;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Services;

[Service]
public class DiagramExporterService : IDiagramExporterService
{
	private static DiagramExporterService bHCp2ZA0HNp08odYMLH;

	public Stream ExportDiagramWorkflowProcess(IWorkflowProcess workflowProcess)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (CsS3F9AtmlFAxhEhgK1(workflowProcess) != null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ac5d16a577a84bb0b8ee3654769d2d33 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return null;
			default:
				return ExportImageToStream((NDrawingDocument)m3oATwAbNk7mCA8fIgj(CsS3F9AtmlFAxhEhgK1(workflowProcess)));
			}
		}
	}

	public Stream ExportDiagramWorkflowInstance(IWorkflowInstance instance)
	{
		//Discarded unreachable code: IL_011f, IL_012e, IL_0139, IL_01bb, IL_01f3, IL_0203, IL_0211, IL_0366, IL_0375, IL_0384, IL_0394, IL_040a, IL_0442, IL_048d, IL_0497, IL_050d, IL_051c, IL_057b, IL_0618, IL_06c7, IL_06ff, IL_0721, IL_0730, IL_0819, IL_0922, IL_0931, IL_095b, IL_096a, IL_099b, IL_09ba, IL_09c9, IL_09f6, IL_0a05
		int num = 10;
		int num2 = num;
		WorkflowDiagram workflowDiagram = default(WorkflowDiagram);
		_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = default(_003C_003Ec__DisplayClass1_0);
		NDrawingDocument document = default(NDrawingDocument);
		IEnumerator<IWorkflowQueueItem> enumerator2 = default(IEnumerator<IWorkflowQueueItem>);
		IEnumerator<Element> enumerator3 = default(IEnumerator<Element>);
		IEnumerator<IWorkflowTrackingItem> enumerator = default(IEnumerator<IWorkflowTrackingItem>);
		_003C_003Ec__DisplayClass1_3 _003C_003Ec__DisplayClass1_4 = default(_003C_003Ec__DisplayClass1_3);
		Element element3 = default(Element);
		_003C_003Ec__DisplayClass1_2 _003C_003Ec__DisplayClass1_3 = default(_003C_003Ec__DisplayClass1_2);
		Element element2 = default(Element);
		List<Guid> list = default(List<Guid>);
		_003C_003Ec__DisplayClass1_1 _003C_003Ec__DisplayClass1_2 = default(_003C_003Ec__DisplayClass1_1);
		Element element = default(Element);
		while (true)
		{
			switch (num2)
			{
			case 4:
				workflowDiagram = ClassSerializationHelper.CloneObjectByXml((WorkflowDiagram)CsS3F9AtmlFAxhEhgK1(_003C_003Ec__DisplayClass1_.instance.Process));
				num2 = 11;
				continue;
			case 8:
				return ExportImageToStream(document);
			case 2:
			{
				WorkflowQueueItemManager serviceNotNull = Locator.GetServiceNotNull<WorkflowQueueItemManager>();
				ParameterExpression parameterExpression = (ParameterExpression)bHlBDZAL5uXBSJhEL0u(WuLBSCAnoWXv4IOtSeQ(typeof(IWorkflowQueueItem).TypeHandle), gMZA61AHddEgq8Q9En2(-1303601216 ^ -1303541458));
				enumerator2 = serviceNotNull.Find(Expression.Lambda<Func<IWorkflowQueueItem, bool>>(Expression.Equal((Expression)MwaCLdA9FfsuHrdgOVb(parameterExpression, (MethodInfo)oQrmYxAfjiroMioI3xY((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (Expression)zugPHEARaPnxOVZ23ol(INAEQ4AWnRltYbCUSMo(_003C_003Ec__DisplayClass1_, WuLBSCAnoWXv4IOtSeQ(typeof(_003C_003Ec__DisplayClass1_0).TypeHandle)), cLN5rpAjllCNXocSTB4((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))), new ParameterExpression[1] { parameterExpression })).GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a == 0)
				{
					num2 = 1;
				}
				continue;
			}
			case 12:
				try
				{
					while (true)
					{
						int num10;
						if (!Giv4EJAcUiCNZvEY3ja(enumerator3))
						{
							num10 = 2;
							goto IL_013d;
						}
						goto IL_0169;
						IL_013d:
						switch (num10)
						{
						case 1:
							break;
						default:
							goto IL_0169;
						case 2:
							goto end_IL_0153;
						}
						continue;
						IL_0169:
						Element current = enumerator3.Current;
						Ty48PMABu48qT651j5X(current, uQJJ9jAg0NRoW0kvDKT(current));
						num10 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bd84f42638494cb6b4427f8e13ec59af == 0)
						{
							num10 = 1;
						}
						goto IL_013d;
						continue;
						end_IL_0153:
						break;
					}
				}
				finally
				{
					if (enumerator3 != null)
					{
						int num11 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e2e244178c44ea09cd756894b022a62 != 0)
						{
							num11 = 1;
						}
						while (true)
						{
							switch (num11)
							{
							case 1:
								sjVLlxAPZ84vVKdBF31(enumerator3);
								num11 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_43af423d081c48e3bc6cea30ce47523d != 0)
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
				goto case 3;
			case 7:
				try
				{
					while (true)
					{
						int num8;
						if (!enumerator.MoveNext())
						{
							num8 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c == 0)
							{
								num8 = 0;
							}
							goto IL_0215;
						}
						goto IL_03d3;
						IL_03d3:
						_003C_003Ec__DisplayClass1_4 = new _003C_003Ec__DisplayClass1_3();
						num8 = 9;
						goto IL_0215;
						IL_0215:
						while (true)
						{
							switch (num8)
							{
							case 9:
								_003C_003Ec__DisplayClass1_4.activeElementTracking = enumerator.Current;
								num8 = 11;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 == 0)
								{
									num8 = 12;
								}
								continue;
							case 6:
								((NShape)oxJpmdAd9NWsnhXppTc(element3)).CreateShapeElements((ShapeElementsMask)8);
								num8 = 3;
								continue;
							case 7:
								if (element3 == null)
								{
									num8 = 10;
									continue;
								}
								goto case 4;
							case 4:
								if (oxJpmdAd9NWsnhXppTc(element3) == null)
								{
									num8 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f33560c5d18b4e10b24a458578aa60fd != 0)
									{
										num8 = 0;
									}
									continue;
								}
								goto case 11;
							case 3:
							case 8:
								if (QJ2g2dAuo0ecwIQ0fGl(oxJpmdAd9NWsnhXppTc(element3)) != null)
								{
									num8 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e632863bfb124ba083e3ba9b363fd70e != 0)
									{
										num8 = 2;
									}
									continue;
								}
								break;
							case 11:
								if (element3.Shape.get_Decorators() != null)
								{
									num8 = 8;
									continue;
								}
								goto case 6;
							case 2:
							{
								object obj2 = QJ2g2dAuo0ecwIQ0fGl(oxJpmdAd9NWsnhXppTc(element3));
								ActiveDecorator activeDecorator2 = new ActiveDecorator();
								DZAMyVA3lweTxBEEm8Q(activeDecorator2, ActiveDecoratorStyle.Active);
								V12m4uADGJHD5jEjpFQ(obj2, activeDecorator2);
								num8 = 5;
								continue;
							}
							case 12:
								element3 = ((IEnumerable<Element>)LxSaaiA5Mgj2TQ9aRLX(workflowDiagram)).FirstOrDefault(_003C_003Ec__DisplayClass1_4._003CExportDiagramWorkflowInstance_003Eb__5);
								num8 = 6;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 == 0)
								{
									num8 = 7;
								}
								continue;
							case 13:
								goto IL_03d3;
							case 1:
								goto end_IL_027f;
							}
							break;
						}
						continue;
						end_IL_027f:
						break;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num9 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 != 0)
						{
							num9 = 1;
						}
						while (true)
						{
							switch (num9)
							{
							case 1:
								sjVLlxAPZ84vVKdBF31(enumerator);
								num9 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f91acf223c4b4303819d2f8f2fc6c8e1 != 0)
								{
									num9 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
				}
				goto case 8;
			case 11:
				enumerator3 = ((ElementList)LxSaaiA5Mgj2TQ9aRLX(workflowDiagram)).GetEnumerator();
				num2 = 12;
				continue;
			case 3:
				document = workflowDiagram.Document;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_639c11c7bb65456db9f29c9c42f28bf7 == 0)
				{
					num2 = 6;
				}
				continue;
			case 1:
				try
				{
					while (true)
					{
						int num6;
						if (!Giv4EJAcUiCNZvEY3ja(enumerator2))
						{
							num6 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_545887e65739480a965b7ddfab7d0632 == 0)
							{
								num6 = 2;
							}
							goto IL_049b;
						}
						goto IL_0622;
						IL_0622:
						_003C_003Ec__DisplayClass1_3 = new _003C_003Ec__DisplayClass1_2();
						num6 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 == 0)
						{
							num6 = 1;
						}
						goto IL_049b;
						IL_049b:
						while (true)
						{
							switch (num6)
							{
							case 11:
							case 13:
								if (QJ2g2dAuo0ecwIQ0fGl(oxJpmdAd9NWsnhXppTc(element2)) == null)
								{
									num6 = 4;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0991fd79553c4ecc82e8b5cb79c2bff2 != 0)
									{
										num6 = 0;
									}
									continue;
								}
								goto case 7;
							default:
								if (oxJpmdAd9NWsnhXppTc(element2) != null)
								{
									num6 = 9;
									continue;
								}
								break;
							case 10:
								if (element2 == null)
								{
									num6 = 3;
									continue;
								}
								goto default;
							case 8:
								g4piO8A6ymQqIEdutHf(oxJpmdAd9NWsnhXppTc(element2), (ShapeElementsMask)8);
								num6 = 10;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4ef74b4b7d13430e9d2f9b78cbdb367b == 0)
								{
									num6 = 13;
								}
								continue;
							case 3:
							case 4:
							case 5:
								break;
							case 9:
								if (((NShape)oxJpmdAd9NWsnhXppTc(element2)).get_Decorators() != null)
								{
									num6 = 11;
									continue;
								}
								goto case 8;
							case 12:
								element2 = ((IEnumerable<Element>)LxSaaiA5Mgj2TQ9aRLX(workflowDiagram)).FirstOrDefault(_003C_003Ec__DisplayClass1_3._003CExportDiagramWorkflowInstance_003Eb__4);
								num6 = 10;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 == 0)
								{
									num6 = 9;
								}
								continue;
							case 1:
								_003C_003Ec__DisplayClass1_3.queueItem = enumerator2.Current;
								num6 = 12;
								continue;
							case 6:
								goto IL_0622;
							case 7:
							{
								object obj = QJ2g2dAuo0ecwIQ0fGl(oxJpmdAd9NWsnhXppTc(element2));
								ActiveDecorator activeDecorator = new ActiveDecorator();
								DZAMyVA3lweTxBEEm8Q(activeDecorator, (rCjbd8AqmSW425K5947(_003C_003Ec__DisplayClass1_3.queueItem) == 0L) ? ActiveDecoratorStyle.Queued : (_003C_003Ec__DisplayClass1_3.queueItem.NextExecuteDate.HasValue ? ActiveDecoratorStyle.QueuedWarn : ActiveDecoratorStyle.QueuedError));
								V12m4uADGJHD5jEjpFQ(obj, activeDecorator);
								num6 = 5;
								continue;
							}
							case 2:
								goto end_IL_0585;
							}
							break;
						}
						continue;
						end_IL_0585:
						break;
					}
				}
				finally
				{
					if (enumerator2 != null)
					{
						int num7 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_69cb4a76addb44f28bb765f059e441c7 == 0)
						{
							num7 = 1;
						}
						while (true)
						{
							switch (num7)
							{
							case 1:
								sjVLlxAPZ84vVKdBF31(enumerator2);
								num7 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1de08766357542bdb81146373079f817 != 0)
								{
									num7 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
				}
				break;
			case 9:
				_003C_003Ec__DisplayClass1_.instance = instance;
				num2 = 4;
				continue;
			default:
				try
				{
					while (true)
					{
						IL_084c:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 8;
							goto IL_073f;
						}
						goto IL_083b;
						IL_073f:
						while (true)
						{
							switch (num3)
							{
							case 15:
								if (list.Contains(CmlMIAAXP4gHqosIKFR(_003C_003Ec__DisplayClass1_2.executedElementTracking)))
								{
									num3 = 8;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f33560c5d18b4e10b24a458578aa60fd == 0)
									{
										num3 = 12;
									}
									continue;
								}
								goto case 16;
							case 11:
								V12m4uADGJHD5jEjpFQ(QJ2g2dAuo0ecwIQ0fGl(oxJpmdAd9NWsnhXppTc(element)), new ExecutedDecorator());
								num3 = 6;
								continue;
							case 7:
								element = ((IEnumerable<Element>)LxSaaiA5Mgj2TQ9aRLX(workflowDiagram)).FirstOrDefault(_003C_003Ec__DisplayClass1_2._003CExportDiagramWorkflowInstance_003Eb__3);
								num3 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_719514a5a8ae47ed84e5a777ead0dc9f != 0)
								{
									num3 = 1;
								}
								continue;
							case 5:
								_003C_003Ec__DisplayClass1_2.executedElementTracking = enumerator.Current;
								num3 = 15;
								continue;
							case 9:
								break;
							default:
								goto IL_084c;
							case 13:
								element.Shape.CreateShapeElements((ShapeElementsMask)8);
								num3 = 4;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_639c11c7bb65456db9f29c9c42f28bf7 != 0)
								{
									num3 = 0;
								}
								continue;
							case 16:
								list.Add(CmlMIAAXP4gHqosIKFR(_003C_003Ec__DisplayClass1_2.executedElementTracking));
								num3 = 4;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e == 0)
								{
									num3 = 7;
								}
								continue;
							case 1:
								if (element == null)
								{
									num3 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_dcdfd019631e458b9cb5fa34a16a2fe1 == 0)
									{
										num3 = 0;
									}
									continue;
								}
								goto case 10;
							case 10:
								if (oxJpmdAd9NWsnhXppTc(element) != null)
								{
									num3 = 2;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c == 0)
									{
										num3 = 14;
									}
									continue;
								}
								goto IL_084c;
							case 14:
								if (QJ2g2dAuo0ecwIQ0fGl(element.Shape) != null)
								{
									int num4 = 3;
									num3 = num4;
									continue;
								}
								goto case 13;
							case 3:
							case 4:
								if (((NShape)oxJpmdAd9NWsnhXppTc(element)).get_Decorators() == null)
								{
									num3 = 2;
									continue;
								}
								goto case 11;
							case 8:
								goto end_IL_084c;
							}
							break;
						}
						goto IL_083b;
						IL_083b:
						_003C_003Ec__DisplayClass1_2 = new _003C_003Ec__DisplayClass1_1();
						num3 = 5;
						goto IL_073f;
						continue;
						end_IL_084c:
						break;
					}
				}
				finally
				{
					int num5;
					if (enumerator == null)
					{
						num5 = 2;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a == 0)
						{
							num5 = 0;
						}
						goto IL_099f;
					}
					goto IL_09d4;
					IL_09d4:
					sjVLlxAPZ84vVKdBF31(enumerator);
					num5 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e9561fecdd4d49678d9f9ea7d295fb1b == 0)
					{
						num5 = 1;
					}
					goto IL_099f;
					IL_099f:
					switch (num5)
					{
					case 2:
						goto end_IL_097a;
					case 1:
						goto end_IL_097a;
					}
					goto IL_09d4;
					end_IL_097a:;
				}
				goto case 2;
			case 10:
				_003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0();
				num2 = 9;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e632863bfb124ba083e3ba9b363fd70e == 0)
				{
					num2 = 7;
				}
				continue;
			case 6:
			{
				IEnumerable<IWorkflowTrackingItem> enumerable = ((IEnumerable<IWorkflowTrackingItem>)_003C_003Ec__DisplayClass1_.instance.Tracking).Where(delegate(IWorkflowTrackingItem t)
				{
					int num14 = 1;
					int num15 = num14;
					DateTime? endDate2 = default(DateTime?);
					while (true)
					{
						switch (num15)
						{
						case 1:
							endDate2 = t.EndDate;
							num15 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c7fe5d092d804f7e91041fb2338cec1a == 0)
							{
								num15 = 0;
							}
							break;
						default:
							return endDate2.HasValue;
						}
					}
				});
				list = new List<Guid>();
				enumerator = enumerable.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f05298ca2a4a4a639a58bc7f7d9ff7b9 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			case 5:
				break;
			}
			enumerator = ((IEnumerable<IWorkflowTrackingItem>)_003C_003Ec__DisplayClass1_.instance.Tracking).Where(delegate(IWorkflowTrackingItem t)
			{
				int num12 = 1;
				int num13 = num12;
				DateTime? endDate = default(DateTime?);
				while (true)
				{
					switch (num13)
					{
					case 1:
						endDate = t.EndDate;
						num13 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a != 0)
						{
							num13 = 0;
						}
						break;
					default:
						return !endDate.HasValue;
					}
				}
			}).GetEnumerator();
			num2 = 7;
		}
	}

	private Stream ExportImageToStream(NDrawingDocument document)
	{
		//Discarded unreachable code: IL_0091, IL_00c9, IL_0101, IL_0110
		int num = 3;
		int num2 = num;
		Bitmap bitmap = default(Bitmap);
		MemoryStream memoryStream = default(MemoryStream);
		while (true)
		{
			switch (num2)
			{
			case 2:
				bitmap = ExportImageToBitmap(document);
				num2 = 4;
				break;
			default:
				memoryStream.Seek(0L, SeekOrigin.Begin);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f != 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				try
				{
					UySsIiAp6yh1me8r1i7(bitmap, memoryStream, He8Y5EAQdeMnOUb6Ueh());
					int num3 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
				}
				finally
				{
					if (bitmap != null)
					{
						int num4 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_60c5782a184b457aa78da2e5c62d4e27 == 0)
						{
							num4 = 1;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								sjVLlxAPZ84vVKdBF31(bitmap);
								num4 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_32f3e755437f4eacb85c8a0d536f83ea == 0)
								{
									num4 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
				}
				goto default;
			case 3:
				memoryStream = (MemoryStream)QB8QE1ATerUFhKkHKqw();
				num2 = 2;
				break;
			case 1:
				return memoryStream;
			}
		}
	}

	private Bitmap ExportImageToBitmap(NDrawingDocument document)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		return (Bitmap)saOmvbACkgHuwhXfC0Q((object)new NImageExporter(document));
	}

	public DiagramExporterService()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6b089b0d02ae4d3186c8d2cb8a24d4d3 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object CsS3F9AtmlFAxhEhgK1(object P_0)
	{
		return ((IWorkflowProcess)P_0).Diagram;
	}

	internal static object m3oATwAbNk7mCA8fIgj(object P_0)
	{
		return ((Diagram)P_0).Document;
	}

	internal static bool dUyiArAyuB2FqOOFn1B()
	{
		return bHCp2ZA0HNp08odYMLH == null;
	}

	internal static DiagramExporterService kXB7ceAmpRmcJ0QjAbV()
	{
		return bHCp2ZA0HNp08odYMLH;
	}

	internal static object LxSaaiA5Mgj2TQ9aRLX(object P_0)
	{
		return ((Diagram)P_0).Elements;
	}

	internal static object uQJJ9jAg0NRoW0kvDKT(object P_0)
	{
		return ((Element)P_0).LocalizableName;
	}

	internal static void Ty48PMABu48qT651j5X(object P_0, object P_1)
	{
		((Element)P_0).Name = (string)P_1;
	}

	internal static bool Giv4EJAcUiCNZvEY3ja(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void sjVLlxAPZ84vVKdBF31(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static Guid CmlMIAAXP4gHqosIKFR(object P_0)
	{
		return ((IWorkflowTrackingItem)P_0).ElementUid;
	}

	internal static object oxJpmdAd9NWsnhXppTc(object P_0)
	{
		return ((Element)P_0).Shape;
	}

	internal static object QJ2g2dAuo0ecwIQ0fGl(object P_0)
	{
		return ((NShape)P_0).get_Decorators();
	}

	internal static void V12m4uADGJHD5jEjpFQ(object P_0, object P_1)
	{
		((NDiagramElementCollection)P_0).AddChild((INNode)P_1);
	}

	internal static Type WuLBSCAnoWXv4IOtSeQ(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object gMZA61AHddEgq8Q9En2(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object bHlBDZAL5uXBSJhEL0u(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object oQrmYxAfjiroMioI3xY(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object MwaCLdA9FfsuHrdgOVb(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static object INAEQ4AWnRltYbCUSMo(object P_0, Type P_1)
	{
		return Expression.Constant(P_0, P_1);
	}

	internal static object cLN5rpAjllCNXocSTB4(RuntimeFieldHandle P_0)
	{
		return FieldInfo.GetFieldFromHandle(P_0);
	}

	internal static object zugPHEARaPnxOVZ23ol(object P_0, object P_1)
	{
		return Expression.Field((Expression)P_0, (FieldInfo)P_1);
	}

	internal static bool g4piO8A6ymQqIEdutHf(object P_0, ShapeElementsMask P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NShape)P_0).CreateShapeElements(P_1);
	}

	internal static long rCjbd8AqmSW425K5947(object P_0)
	{
		return ((IWorkflowQueueItem)P_0).Attempt;
	}

	internal static void DZAMyVA3lweTxBEEm8Q(object P_0, ActiveDecoratorStyle value)
	{
		((ActiveDecorator)P_0).Style = value;
	}

	internal static object QB8QE1ATerUFhKkHKqw()
	{
		return MemoryHelper.GetMemoryStream();
	}

	internal static object He8Y5EAQdeMnOUb6Ueh()
	{
		return ImageFormat.Jpeg;
	}

	internal static void UySsIiAp6yh1me8r1i7(object P_0, object P_1, object P_2)
	{
		((Image)P_0).Save((Stream)P_1, (ImageFormat)P_2);
	}

	internal static object saOmvbACkgHuwhXfC0Q(object P_0)
	{
		return ((NImageExporter)P_0).RenderToBitmap();
	}
}
