using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Connectors;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Events;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Decorators;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Events;
using EleWise.ELMA.Workflow.Diagrams.Shapes;
using EleWise.ELMA.Workflow.Diagrams.Shapes.Decorators;
using j3AmrhgkCleVTGdEwA;
using Nevron.Diagram;
using Nevron.Dom;
using Nevron.GraphicsCore;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Connectors;

[Serializable]
public class FlowConnectorShape : NRoutableConnector, IBorderDecoratable, IDecoratableShape
{
	internal static FlowConnectorShape FADditO1xJcs2sJ9D5SA;

	public FlowConnectorShape()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		((NRoutableConnector)this)._002Ector();
		int num = 2;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				VawmYMO1hqxcGv5V1HcM(this, (ShapeElementsMask)8);
				num = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4ef74b4b7d13430e9d2f9b78cbdb367b == 0)
				{
					num = 1;
				}
				break;
			case 1:
				SetDefaultStyles();
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2f119e188994b55be2499c193b880fb != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public FlowConnectorShape(NPointF[] points)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		TBnf4iO1ElWU0l32kViy();
		((NRoutableConnector)this)._002Ector(points);
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f8a84e2cb374827a50ba2cbcf11cf48 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				return;
			case 1:
				SetDefaultStyles();
				num = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b == 0)
				{
					num = 0;
				}
				break;
			default:
				VawmYMO1hqxcGv5V1HcM(this, (ShapeElementsMask)8);
				num = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public NLineSegmentF? GetLongestSegment()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		_003C_003Ec__DisplayClass2_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass2_0();
		CS_0024_003C_003E8__locals0.segments = ((NPolyPathShape)this).ToLineSegments();
		return CS_0024_003C_003E8__locals0.segments.FirstOrDefault((NLineSegmentF s) => ((NLineSegmentF)(ref s)).get_Length() == CS_0024_003C_003E8__locals0.segments.Max((NLineSegmentF s1) => ((NLineSegmentF)(ref s1)).get_Length()));
	}

	protected override void CreateDefaultLabels()
	{
		int num = 1;
		int num2 = num;
		FlowConnectorLabel flowConnectorLabel = default(FlowConnectorLabel);
		while (true)
		{
			switch (num2)
			{
			case 1:
				flowConnectorLabel = new FlowConnectorLabel("", Guid.Empty, 50f, useLineOrientation: true, allowDownwardOrientation: false);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_978f838cc41a4debb9700ede4b63f820 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return;
			case 2:
				((NShape)this).get_Labels().set_DefaultLabelUniqueId(pNMEvQO1zYK8GrqOlOXB(flowConnectorLabel));
				num2 = 3;
				break;
			default:
				WFwQDpO14UOPjFdVqo5d(jhxqmbO1wfn840f5Rrmh(this), flowConnectorLabel);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6fe3beca34a9422e873cd6ef331760ae == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public virtual NModel GetBorderDecoratorModel(NRectangleF bounds)
	{
		//Discarded unreachable code: IL_0049, IL_0058, IL_0063, IL_00a1, IL_0137, IL_0194, IL_01a3, IL_01ee, IL_01f8, IL_02a3, IL_02b6
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected O, but got Unknown
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected O, but got Unknown
		int num = 4;
		NModel val = default(NModel);
		IEnumerator enumerator = default(IEnumerator);
		List<INNode> list = default(List<INNode>);
		INNode val3 = default(INNode);
		NPolyPathShape val2 = default(NPolyPathShape);
		List<INNode>.Enumerator enumerator2 = default(List<INNode>.Enumerator);
		INNode current = default(INNode);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 8:
					return val;
				case 6:
					try
					{
						while (true)
						{
							int num3;
							if (!oQVq4sOhYOsi0odWYW2R(enumerator))
							{
								num3 = 4;
								goto IL_0067;
							}
							goto IL_00e7;
							IL_0067:
							while (true)
							{
								switch (num3)
								{
								case 5:
									list.Add(val3);
									num3 = 2;
									continue;
								case 1:
								case 2:
									break;
								case 3:
									if (!(val3 is IExecutionDecorator))
									{
										num3 = 1;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4cc62744d0eb4cd68219b70dcad3e68e != 0)
										{
											num3 = 1;
										}
										continue;
									}
									goto case 5;
								default:
									goto IL_00e7;
								case 4:
									goto end_IL_00ab;
								}
								break;
							}
							continue;
							IL_00e7:
							val3 = (INNode)WNP5wTOhvi33mmaHsnno(enumerator);
							num3 = 3;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c447ffb64be44c09b6fd398df506785b != 0)
							{
								num3 = 3;
							}
							goto IL_0067;
							continue;
							end_IL_00ab:
							break;
						}
					}
					finally
					{
						IDisposable disposable = enumerator as IDisposable;
						int num4 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3bb28bf622874b4689f9265e58d14823 == 0)
						{
							num4 = 1;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								if (disposable != null)
								{
									num4 = 2;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c == 0)
									{
										num4 = 2;
									}
									continue;
								}
								break;
							case 2:
								I8t9KmOh8cc3IOB3ZVB7(disposable);
								num4 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 != 0)
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
					break;
				case 3:
					val2 = (NPolyPathShape)val;
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae4e393cddc4c98b9896b25c9e18c7d != 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					val = (NModel)OXhEviOhK3B1DNRKvHUD(this);
					num2 = 3;
					continue;
				case 2:
					try
					{
						while (true)
						{
							int num5;
							if (!enumerator2.MoveNext())
							{
								num5 = 2;
								goto IL_01fc;
							}
							goto IL_0254;
							IL_01fc:
							while (true)
							{
								switch (num5)
								{
								case 2:
									return val;
								case 1:
									VDZv2mOhsGX2mxWLZ2Uq(HBXPTuOhOn8UpKcAr1bq(val2), current);
									num5 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e9561fecdd4d49678d9f9ea7d295fb1b != 0)
									{
										num5 = 0;
									}
									continue;
								case 3:
									goto IL_0254;
								}
								break;
							}
							continue;
							IL_0254:
							current = enumerator2.Current;
							num5 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 != 0)
							{
								num5 = 1;
							}
							goto IL_01fc;
						}
					}
					finally
					{
						((IDisposable)enumerator2).Dispose();
						int num6 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e == 0)
						{
							num6 = 0;
						}
						switch (num6)
						{
						case 0:
							break;
						}
					}
				default:
					enumerator = (IEnumerator)ekbHR2OhZisloTRwkyZl(HBXPTuOhOn8UpKcAr1bq(val2));
					num2 = 6;
					continue;
				case 5:
					if (HBXPTuOhOn8UpKcAr1bq(val2) != null)
					{
						num2 = 7;
						continue;
					}
					goto case 8;
				case 7:
					list = new List<INNode>();
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a == 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					break;
				}
				break;
			}
			enumerator2 = list.GetEnumerator();
			num = 2;
		}
	}

	public virtual NModel GetBorderDecoratorModelTriger(NRectangleF bounds, NModel lastPath)
	{
		//Discarded unreachable code: IL_003d, IL_0078, IL_0082, IL_00f4, IL_0103, IL_01b4, IL_01f8, IL_0207, IL_0234, IL_0243
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected O, but got Unknown
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Expected O, but got Unknown
		int num = 3;
		int num2 = num;
		NModel result = default(NModel);
		IEnumerator enumerator = default(IEnumerator);
		NPolyPathShape val = default(NPolyPathShape);
		CompositeDecorator compositeDecorator = default(CompositeDecorator);
		while (true)
		{
			switch (num2)
			{
			case 1:
			case 5:
				return result;
			case 6:
				enumerator = (IEnumerator)ekbHR2OhZisloTRwkyZl(((NShape)val).get_Decorators());
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a9be7e056b4e4b6e863b634c418144f1 != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				val = (NPolyPathShape)lastPath;
				num2 = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1de08766357542bdb81146373079f817 != 0)
				{
					num2 = 4;
				}
				continue;
			case 3:
				result = null;
				num2 = 2;
				continue;
			case 4:
				if (HBXPTuOhOn8UpKcAr1bq(val) == null)
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 6;
			}
			try
			{
				while (true)
				{
					int num3;
					if (!oQVq4sOhYOsi0odWYW2R(enumerator))
					{
						num3 = 3;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede == 0)
						{
							num3 = 1;
						}
						goto IL_0086;
					}
					goto IL_016f;
					IL_016f:
					compositeDecorator = ((INNode)WNP5wTOhvi33mmaHsnno(enumerator)) as CompositeDecorator;
					num3 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 == 0)
					{
						num3 = 0;
					}
					goto IL_0086;
					IL_0086:
					while (true)
					{
						switch (num3)
						{
						case 3:
							return result;
						case 1:
						case 5:
							break;
						default:
							if (compositeDecorator == null)
							{
								num3 = 4;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c447ffb64be44c09b6fd398df506785b == 0)
								{
									num3 = 5;
								}
								continue;
							}
							goto case 4;
						case 4:
							result = (NModel)new NEllipsePath(iZln3xOhJLUpBiTOUlFF(lastPath).X - compositeDecorator.width / 2f, iZln3xOhJLUpBiTOUlFF(lastPath).Y - compositeDecorator.height / 2f, compositeDecorator.width, compositeDecorator.height);
							num3 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5537a063960e465db83a04e35eea441b != 0)
							{
								num3 = 1;
							}
							continue;
						case 2:
							goto IL_016f;
						}
						break;
					}
				}
			}
			finally
			{
				IDisposable disposable = enumerator as IDisposable;
				int num4 = 3;
				while (true)
				{
					switch (num4)
					{
					case 1:
						I8t9KmOh8cc3IOB3ZVB7(disposable);
						num4 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_978f838cc41a4debb9700ede4b63f820 != 0)
						{
							num4 = 0;
						}
						continue;
					case 2:
						break;
					case 3:
						if (disposable == null)
						{
							num4 = 2;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_08023922bb0e4e809e5cff73a2b04988 == 0)
							{
								num4 = 1;
							}
							continue;
						}
						goto case 1;
					case 0:
						break;
					}
					break;
				}
			}
		}
	}

	public virtual void UpdateDecorators(Element element)
	{
		//Discarded unreachable code: IL_00b7, IL_00c6, IL_0194
		int num = 7;
		FlowConnectorElement flowConnectorElement = default(FlowConnectorElement);
		Type triggerDecoratorType = default(Type);
		BaseDecorator baseDecorator = default(BaseDecorator);
		CompositeDecorator compositeDecorator = default(CompositeDecorator);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 11:
					return;
				case 14:
					if (ebiNOjOhyVMnnH3yvpqI(flowConnectorElement))
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e9561fecdd4d49678d9f9ea7d295fb1b != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 5;
				case 5:
					if (S8WsGuOhmUOovKAGmckw(flowConnectorElement) != 0)
					{
						num2 = 2;
						continue;
					}
					return;
				case 4:
					return;
				case 2:
					triggerDecoratorType = EventShape.GetTriggerDecoratorType(S8WsGuOhmUOovKAGmckw(flowConnectorElement));
					num = 8;
					break;
				case 6:
					flowConnectorElement = element as FlowConnectorElement;
					num2 = 13;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 != 0)
					{
						num2 = 8;
					}
					continue;
				case 3:
					baseDecorator = (BaseDecorator)SqinpVOhbAopjlshusv7(triggerDecoratorType);
					num = 10;
					break;
				default:
					WFwQDpO14UOPjFdVqo5d(((NShape)this).get_Decorators(), compositeDecorator);
					num2 = 9;
					continue;
				case 10:
					compositeDecorator = new CompositeDecorator(new BaseDecorator[2]
					{
						new BoundaryInterruptingDecorator(),
						baseDecorator
					});
					num2 = 12;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ffb1346d351f436b84bb1e9954c3bfa8 != 0)
					{
						num2 = 5;
					}
					continue;
				case 7:
					AeVa8lOh05dfPMlebZ3I(vY4IY5Ohl5R2Aw8i4EBi(this));
					num2 = 6;
					continue;
				case 9:
					return;
				case 1:
					WFwQDpO14UOPjFdVqo5d(vY4IY5Ohl5R2Aw8i4EBi(this), new DefaultConnectorDecorator());
					num = 5;
					break;
				case 13:
					if (flowConnectorElement == null)
					{
						return;
					}
					num2 = 14;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c7fe5d092d804f7e91041fb2338cec1a != 0)
					{
						num2 = 0;
					}
					continue;
				case 8:
					if (!LWIVZxOhtGeQEOEKR7LT(triggerDecoratorType, null))
					{
						return;
					}
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f8a84e2cb374827a50ba2cbcf11cf48 != 0)
					{
						num2 = 0;
					}
					continue;
				case 12:
					GDpY7OOh54xSBbbRyks7(compositeDecorator, DecoratorPosition.StartModelPoint);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c447ffb64be44c09b6fd398df506785b != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
		}
	}

	private void SetDefaultStyles()
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected O, but got Unknown
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected O, but got Unknown
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected O, but got Unknown
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected O, but got Unknown
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Expected O, but got Unknown
		//IL_01f6: Expected O, but got Unknown
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected O, but got Unknown
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected O, but got Unknown
		int num = 7;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
					VScGXkOhgODdHtfmYkj6(this, new NMargins(16f));
					num2 = 6;
					continue;
				case 6:
					wQESVtOhBKdV4lvTTAn4(this, (RerouteAutomatically)2);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a != 0)
					{
						num2 = 3;
					}
					continue;
				case 1:
					KT3TIpOhL2Lwk09kcl8e(XSsE6uOhPdb9SOLc6kQo(this), (object)new NBridgeStyle((BridgeShape)1, new NSizeL(5, 5)));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 == 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					gueouxOhDkInXDLxPN4q(this, 7f);
					num2 = 8;
					continue;
				case 9:
					if (XSsE6uOhPdb9SOLc6kQo(UZcxsAOhccBGo3pBt9HY(((NShape)this).get_Labels())) == null)
					{
						num2 = 10;
						continue;
					}
					break;
				case 12:
					if (UZcxsAOhccBGo3pBt9HY(jhxqmbO1wfn840f5Rrmh(this)) != null)
					{
						num2 = 9;
						continue;
					}
					goto case 4;
				case 4:
					if (XSsE6uOhPdb9SOLc6kQo(this) == null)
					{
						num2 = 2;
						continue;
					}
					goto case 5;
				case 13:
					goto end_IL_0012;
				case 3:
					if (jhxqmbO1wfn840f5Rrmh(this) != null)
					{
						num2 = 12;
						continue;
					}
					goto case 4;
				default:
					B4Ehg4OhurWh6UHwgrTL(XSsE6uOhPdb9SOLc6kQo(this), (object)new NColorFillStyle(Color.Yellow));
					num2 = 13;
					continue;
				case 2:
					hEVSV0OhXMIs0xROcTJY(this, (object)new NStyle());
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5c45a6e5a4614bfba7591d8a1c7ced1d == 0)
					{
						num2 = 5;
					}
					continue;
				case 10:
					hEVSV0OhXMIs0xROcTJY(UZcxsAOhccBGo3pBt9HY(((NShape)this).get_Labels()), (object)new NStyle());
					num2 = 14;
					continue;
				case 11:
					return;
				case 8:
					DI8f7nOhH4kwWrsybiHk(XSsE6uOhPdb9SOLc6kQo(this), (object)new NArrowheadStyle((ArrowheadShape)13, "", new NSizeL(4, 8), (NFillStyle)new NColorFillStyle(vpEjwnOhnteACvCA6cGx()), new NStrokeStyle(2f, vpEjwnOhnteACvCA6cGx())));
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_978f838cc41a4debb9700ede4b63f820 == 0)
					{
						num2 = 0;
					}
					continue;
				case 14:
					break;
				}
				B4Ehg4OhurWh6UHwgrTL(((NStyleableElement)UZcxsAOhccBGo3pBt9HY(jhxqmbO1wfn840f5Rrmh(this))).get_Style(), (object)new NColorFillStyle(MhIDSHOhdb1UYCDQ2cpU()));
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4cc62744d0eb4cd68219b70dcad3e68e == 0)
				{
					num2 = 4;
				}
				continue;
				end_IL_0012:
				break;
			}
			eCTvPgOhfCXea72ReXn2(XSsE6uOhPdb9SOLc6kQo(this), (object)new NStrokeStyle(vpEjwnOhnteACvCA6cGx()));
			num = 11;
		}
	}

	public NRectangleF GetDecoratorBounds(BaseDecorator decorator)
	{
		//Discarded unreachable code: IL_011a, IL_0129
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		int num = 2;
		int num2 = num;
		NPointF center = default(NPointF);
		NLineSegmentF? longestSegment = default(NLineSegmentF?);
		NLineSegmentF value = default(NLineSegmentF);
		while (true)
		{
			switch (num2)
			{
			case 5:
				return new NRectangleF(new NPointF(center.X - kRvMITOh9sYCtm9SEOht(decorator) / 2f, center.Y - Dp1P76OhW7h34SKjARx8(decorator) / 2f), new NSizeF(kRvMITOh9sYCtm9SEOht(decorator), decorator.Height));
			case 1:
				return NRectangleF.Empty;
			case 4:
				longestSegment = GetLongestSegment();
				num2 = 6;
				break;
			default:
				center = ((NLineSegmentF)(ref value)).get_Center();
				num2 = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 == 0)
				{
					num2 = 5;
				}
				break;
			case 2:
				if (!(decorator is DefaultConnectorDecorator))
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b876fa7b083748c8abf8c4b192a11078 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 4;
			case 3:
				value = longestSegment.Value;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e9561fecdd4d49678d9f9ea7d295fb1b == 0)
				{
					num2 = 0;
				}
				break;
			case 6:
				if (longestSegment.HasValue)
				{
					num2 = 3;
					break;
				}
				goto case 1;
			}
		}
	}

	internal static bool VawmYMO1hqxcGv5V1HcM(object P_0, ShapeElementsMask P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NShape)P_0).CreateShapeElements(P_1);
	}

	internal static bool kkS0pnO1SKNtpJMxCC7Q()
	{
		return FADditO1xJcs2sJ9D5SA == null;
	}

	internal static FlowConnectorShape B9XM8bO111XdIqCsyN7R()
	{
		return FADditO1xJcs2sJ9D5SA;
	}

	internal static void TBnf4iO1ElWU0l32kViy()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static object jhxqmbO1wfn840f5Rrmh(object P_0)
	{
		return ((NShape)P_0).get_Labels();
	}

	internal static void WFwQDpO14UOPjFdVqo5d(object P_0, object P_1)
	{
		((NDiagramElementCollection)P_0).AddChild((INNode)P_1);
	}

	internal static Guid pNMEvQO1zYK8GrqOlOXB(object P_0)
	{
		return ((NDiagramElement)P_0).get_UniqueId();
	}

	internal static object OXhEviOhK3B1DNRKvHUD(object P_0)
	{
		return ((NDiagramNode)P_0).Clone();
	}

	internal static object HBXPTuOhOn8UpKcAr1bq(object P_0)
	{
		return ((NShape)P_0).get_Decorators();
	}

	internal static object ekbHR2OhZisloTRwkyZl(object P_0)
	{
		return ((NDiagramElementCollection)P_0).GetEnumerator();
	}

	internal static object WNP5wTOhvi33mmaHsnno(object P_0)
	{
		return ((IEnumerator)P_0).Current;
	}

	internal static bool oQVq4sOhYOsi0odWYW2R(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void I8t9KmOh8cc3IOB3ZVB7(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void VDZv2mOhsGX2mxWLZ2Uq(object P_0, object P_1)
	{
		((NDiagramElementCollection)P_0).RemoveChild((INNode)P_1);
	}

	internal static NPointF iZln3xOhJLUpBiTOUlFF(object P_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NModel)P_0).get_StartPoint();
	}

	internal static object vY4IY5Ohl5R2Aw8i4EBi(object P_0)
	{
		return ((NShape)P_0).get_Decorators();
	}

	internal static void AeVa8lOh05dfPMlebZ3I(object P_0)
	{
		((NDiagramElementCollection)P_0).RemoveAllChildren();
	}

	internal static bool ebiNOjOhyVMnnH3yvpqI(object P_0)
	{
		return ((FlowConnectorElement)P_0).IsDefault;
	}

	internal static EventTrigger S8WsGuOhmUOovKAGmckw(object P_0)
	{
		return ((FlowConnectorElement)P_0).Trigger;
	}

	internal static bool LWIVZxOhtGeQEOEKR7LT(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static object SqinpVOhbAopjlshusv7(Type P_0)
	{
		return Activator.CreateInstance(P_0);
	}

	internal static void GDpY7OOh54xSBbbRyks7(object P_0, DecoratorPosition value)
	{
		((BaseDecorator)P_0).Position = value;
	}

	internal static void VScGXkOhgODdHtfmYkj6(object P_0, NMargins P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((NAggregateModel)P_0).set_Padding(P_1);
	}

	internal static void wQESVtOhBKdV4lvTTAn4(object P_0, RerouteAutomatically P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((NRoutableConnector)P_0).set_RerouteAutomatically(P_1);
	}

	internal static object UZcxsAOhccBGo3pBt9HY(object P_0)
	{
		return ((NLabelCollection)P_0).get_DefaultLabel();
	}

	internal static object XSsE6uOhPdb9SOLc6kQo(object P_0)
	{
		return ((NStyleableElement)P_0).get_Style();
	}

	internal static void hEVSV0OhXMIs0xROcTJY(object P_0, object P_1)
	{
		((NStyleableElement)P_0).set_Style((NStyle)P_1);
	}

	internal static Color MhIDSHOhdb1UYCDQ2cpU()
	{
		return Color.Yellow;
	}

	internal static void B4Ehg4OhurWh6UHwgrTL(object P_0, object P_1)
	{
		((NStyle)P_0).set_FillStyle((NFillStyle)P_1);
	}

	internal static void gueouxOhDkInXDLxPN4q(object P_0, float P_1)
	{
		((NMutablePolyPathShape)P_0).set_CornerRounding(P_1);
	}

	internal static Color vpEjwnOhnteACvCA6cGx()
	{
		return Color.Black;
	}

	internal static void DI8f7nOhH4kwWrsybiHk(object P_0, object P_1)
	{
		((NStyle)P_0).set_EndArrowheadStyle((NArrowheadStyle)P_1);
	}

	internal static void KT3TIpOhL2Lwk09kcl8e(object P_0, object P_1)
	{
		((NStyle)P_0).set_BridgeStyle((NBridgeStyle)P_1);
	}

	internal static void eCTvPgOhfCXea72ReXn2(object P_0, object P_1)
	{
		((NStyle)P_0).set_StrokeStyle((NStrokeStyle)P_1);
	}

	internal static float kRvMITOh9sYCtm9SEOht(object P_0)
	{
		return ((BaseDecorator)P_0).Width;
	}

	internal static float Dp1P76OhW7h34SKjARx8(object P_0)
	{
		return ((BaseDecorator)P_0).Height;
	}
}
