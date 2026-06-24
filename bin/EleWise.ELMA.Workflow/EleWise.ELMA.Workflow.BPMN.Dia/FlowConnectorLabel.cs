using System;
using j3AmrhgkCleVTGdEwA;
using Nevron.Diagram;
using Nevron.Diagram.Filters;
using Nevron.Dom;
using Nevron.Filters;
using Nevron.GraphicsCore;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Connectors;

[Serializable]
public class FlowConnectorLabel : NLabel
{
	internal bool field1;

	internal float field2;

	internal bool field3;

	private static FlowConnectorLabel FLAGkZO1ki2ub28ps2Ts;

	public bool AllowDownwardOrientation
	{
		get
		{
			return field3;
		}
		set
		{
			//Discarded unreachable code: IL_0085
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					uloTUJO1eopR7l61C9bl(this);
					num2 = 4;
					break;
				case 2:
					CuUJb1O1rEn3R9GVGpJx(this, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-768800937 ^ -768641493));
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae2bde9e5844c638021cdb56fc01122 == 0)
					{
						num2 = 7;
					}
					break;
				case 6:
					return;
				case 1:
					if (field3 != value)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_805f3361d2ba4dac8da4174f89314253 == 0)
						{
							num2 = 0;
						}
						break;
					}
					return;
				case 7:
					field3 = value;
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eef7d2ca1c3c4b74aeb81172ed542639 == 0)
					{
						num2 = 2;
					}
					break;
				case 8:
					((NStyleableElement)this).Invalidate();
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5537a063960e465db83a04e35eea441b == 0)
					{
						num2 = 1;
					}
					break;
				case 4:
					PsySYLO1NY5es3RwNpVQ(this, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-360662087 ^ -360527163));
					num2 = 5;
					break;
				default:
					if (!AofketO1a1u3oCShCnOg(this, Vjbu37O1GXyNpXbrOFjf(-360662087 ^ -360527163), value))
					{
						num2 = 3;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b84ccb8b1bd147ef900b852047ecbf45 == 0)
						{
							num2 = 6;
						}
						break;
					}
					goto case 8;
				case 5:
					return;
				}
			}
		}
	}

	public float PercentPosition
	{
		get
		{
			return field2;
		}
		set
		{
			//Discarded unreachable code: IL_0137
			int num = 5;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					((NStyleableElement)this).Invalidate();
					num2 = 3;
					break;
				case 2:
					uloTUJO1eopR7l61C9bl(this);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f453500aaab143479696408f48a03c17 == 0)
					{
						num2 = 0;
					}
					break;
				case 7:
					field2 = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 == 0)
					{
						num2 = 6;
					}
					break;
				default:
					((NDiagramElement)this).RecordProperty((string)Vjbu37O1GXyNpXbrOFjf(-1638225214 ^ -1638343822));
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 == 0)
					{
						num2 = 7;
					}
					break;
				case 3:
					((NDiagramNode)this).OnPropertyChanged(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6871CA ^ 0x6A007A));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3b4403f77a00495e957e5e4a6840e5d3 == 0)
					{
						num2 = 1;
					}
					break;
				case 5:
					if (field2 != value)
					{
						num2 = 4;
						break;
					}
					return;
				case 4:
					if (!AofketO1a1u3oCShCnOg(this, Vjbu37O1GXyNpXbrOFjf(-1716458555 ^ -1716348299), value))
					{
						num2 = 8;
						break;
					}
					goto case 2;
				case 8:
					return;
				case 1:
					return;
				}
			}
		}
	}

	public bool UseLineOrientation
	{
		get
		{
			return field1;
		}
		set
		{
			//Discarded unreachable code: IL_012f, IL_013e
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 4:
					((NStyleableElement)this).Invalidate();
					num2 = 8;
					break;
				case 5:
					uloTUJO1eopR7l61C9bl(this);
					num2 = 7;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a == 0)
					{
						num2 = 5;
					}
					break;
				case 7:
					PsySYLO1NY5es3RwNpVQ(this, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1756698829 ^ 0x68B7691F));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f != 0)
					{
						num2 = 0;
					}
					break;
				case 8:
					CuUJb1O1rEn3R9GVGpJx(this, Vjbu37O1GXyNpXbrOFjf(0x7381F16B ^ 0x738380B9));
					num2 = 3;
					break;
				case 2:
					if (field1 != value)
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_26fa47f5bd8343debcae8b05a56a3ab5 == 0)
						{
							num2 = 0;
						}
						break;
					}
					return;
				case 0:
					return;
				case 6:
					return;
				case 1:
					if (!AofketO1a1u3oCShCnOg(this, Vjbu37O1GXyNpXbrOFjf(0x628167BE ^ 0x6283166C), value))
					{
						num2 = 6;
						break;
					}
					goto case 4;
				case 3:
					field1 = value;
					num2 = 5;
					break;
				}
			}
		}
	}

	public FlowConnectorLabel()
	{
		//Discarded unreachable code: IL_002a
		hcQZqFO1Ab2nbdfW1ThW();
		((NLabel)this)._002Ector();
		int num = 1;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 == 0)
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
			case 1:
			{
				field2 = 50f;
				int num2 = 3;
				num = num2;
				break;
			}
			case 3:
				field1 = false;
				num = 2;
				break;
			case 2:
				field3 = false;
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_abfb511163674a3eae959fd60da8f319 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public FlowConnectorLabel(string text, Guid anchorUniqueId, float percentPosition, bool useLineOrientation, bool allowDownwardOrientation)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		hcQZqFO1Ab2nbdfW1ThW();
		((NLabel)this)._002Ector(text, anchorUniqueId);
		int num = 1;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f91acf223c4b4303819d2f8f2fc6c8e1 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				field1 = useLineOrientation;
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6dd19c81ff5e41fb8db9b50574437301 == 0)
				{
					num = 2;
				}
				break;
			case 1:
				field2 = percentPosition;
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 != 0)
				{
					num = 0;
				}
				break;
			case 3:
				return;
			case 2:
				field3 = allowDownwardOrientation;
				num = 3;
				break;
			}
		}
	}

	public override NFilter GetFilterForReferenceProperty(string property)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				throw new ArgumentException(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5DB28AD2 ^ 0x5DB0FA24), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5DB28AD2 ^ 0x5DB0FBBA));
			case 1:
				if (!GDmPr2O17OcUpNUCwOC3(property, Vjbu37O1GXyNpXbrOFjf(0x37F755F5 ^ 0x37F52523)))
				{
					return (NFilter)(object)NFilters.TypeNModel;
				}
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c447ffb64be44c09b6fd398df506785b != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override bool GetWorldTextPaintInfo(string text, out NTextPaintInfo info)
	{
		//Discarded unreachable code: IL_0223, IL_0232, IL_028d
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0362: Unknown result type (might be due to invalid IL or missing references)
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_037d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0409: Unknown result type (might be due to invalid IL or missing references)
		//IL_041e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0420: Unknown result type (might be due to invalid IL or missing references)
		//IL_0425: Unknown result type (might be due to invalid IL or missing references)
		//IL_047d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0484: Unknown result type (might be due to invalid IL or missing references)
		//IL_048b: Unknown result type (might be due to invalid IL or missing references)
		//IL_049f: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a4: Unknown result type (might be due to invalid IL or missing references)
		int num = 23;
		INWorld val2 = default(INWorld);
		int num4 = default(int);
		NMatrix2DF val = default(NMatrix2DF);
		NSizeF val3 = default(NSizeF);
		NModel val5 = default(NModel);
		NPointF center = default(NPointF);
		NLineSegmentF value = default(NLineSegmentF);
		NPointF val4 = default(NPointF);
		float angle = default(float);
		FlowConnectorShape flowConnectorShape = default(FlowConnectorShape);
		NLineSegmentF? longestSegment = default(NLineSegmentF?);
		float num3 = default(float);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 28:
					return false;
				case 13:
					if (val2 == null)
					{
						num2 = 37;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 == 0)
						{
							num2 = 12;
						}
						continue;
					}
					goto case 26;
				case 14:
					if ((uint)(num4 - 2) <= 1u)
					{
						num2 = 29;
						continue;
					}
					goto case 12;
				case 26:
					val = nggo6fO1Fy73pQdJDZuU(val2);
					num2 = 9;
					continue;
				case 23:
					info = default(NTextPaintInfo);
					num2 = 22;
					continue;
				case 12:
					info.Size = val3;
					num2 = 11;
					continue;
				case 31:
					if (val2 != null)
					{
						num2 = 18;
						continue;
					}
					goto case 10;
				case 22:
					val5 = (NModel)omWSb1O12Q9ntJFN8Sx7(this, ((NLabel)this).get_AnchorUniqueId());
					num2 = 16;
					continue;
				case 27:
					center = ((NLineSegmentF)(ref value)).get_Center();
					num2 = 33;
					continue;
				case 11:
					info.Origin = val4;
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e4c570270f54493d8f3f4763a72f63f7 == 0)
					{
						num2 = 4;
					}
					continue;
				case 3:
					if (!field3)
					{
						num2 = 6;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_938c6be4ea2248868d7ed5d0e3346006 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 12;
				case 18:
					val = nggo6fO1Fy73pQdJDZuU(val2);
					info.Origin = ((NMatrix2DF)(ref val)).TransformPoint(info.Origin);
					num2 = 10;
					continue;
				case 10:
					info.Orientation = 0f;
					num2 = 20;
					continue;
				case 17:
					angle = ((NLineSegmentF)(ref value)).get_Angle();
					num2 = 8;
					continue;
				case 39:
					info.Mode = (PaintTextMode)2;
					num2 = 24;
					continue;
				case 24:
					return true;
				case 5:
					val = idRrPtO1oDwhS1xHCtl2(flowConnectorShape);
					info.Origin = ((NMatrix2DF)(ref val)).TransformPoint(info.Origin);
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 == 0)
					{
						num2 = 31;
					}
					continue;
				case 8:
					value = longestSegment.Value;
					num2 = 27;
					continue;
				case 2:
					longestSegment = flowConnectorShape.GetLongestSegment();
					num = 32;
					break;
				case 35:
					value = longestSegment.Value;
					num2 = 17;
					continue;
				case 16:
					if (val5 == null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 == 0)
						{
							num2 = 1;
						}
					}
					else if (((NDiagramNode)this).MeasureStringInWorld(text, ((NStyleComposerElement)this).ComposeTextStyle(), ref val3))
					{
						flowConnectorShape = (FlowConnectorShape)(object)val5;
						num2 = 2;
					}
					else
					{
						num2 = 28;
					}
					continue;
				case 19:
					if (Math.Abs((double)angle - Math.PI) < 0.5)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3b4403f77a00495e957e5e4a6840e5d3 == 0)
						{
							num2 = 21;
						}
						continue;
					}
					goto case 30;
				case 4:
					info.Orientation = num3 * 57.29578f;
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 != 0)
					{
						num2 = 39;
					}
					continue;
				case 34:
					if (longestSegment.HasValue)
					{
						num2 = 35;
						continue;
					}
					val4 = val5.GetLengthLocation(field2);
					num2 = 13;
					continue;
				case 30:
					info.Origin = new NPointF(center.X + val3.Width / 2f + 2f, center.Y);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b876fa7b083748c8abf8c4b192a11078 == 0)
					{
						num2 = 0;
					}
					continue;
				case 38:
					return true;
				default:
					info.Size = val3;
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a == 0)
					{
						num2 = 0;
					}
					continue;
				case 15:
					num3 = XKOmx9O1iwUI7ydlrG2U(val5, field2);
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b == 0)
					{
						num2 = 0;
					}
					continue;
				case 20:
					info.Mode = (PaintTextMode)2;
					num = 38;
					break;
				case 9:
					val4 = ((NMatrix2DF)(ref val)).TransformPoint(val4);
					num2 = 19;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_545887e65739480a965b7ddfab7d0632 == 0)
					{
						num2 = 25;
					}
					continue;
				case 33:
					if (!(Math.Abs(angle) < 0.5f))
					{
						num2 = 19;
						continue;
					}
					goto case 21;
				case 1:
					return false;
				case 21:
					info.Origin = new NPointF(center.X, center.Y + val3.Height / 2f + 2f);
					num2 = 7;
					continue;
				case 32:
				{
					INNode rootNode = ((NDiagramNode)this).get_RootNode();
					val2 = (INWorld)(object)((rootNode is INWorld) ? rootNode : null);
					num2 = 34;
					continue;
				}
				case 29:
					num3 += 3.141593f;
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e9561fecdd4d49678d9f9ea7d295fb1b == 0)
					{
						num2 = 12;
					}
					continue;
				case 25:
				case 37:
					num3 = 0f;
					num2 = 36;
					continue;
				case 6:
					num4 = Q9jCjdO1I3swfHVNmboX(num3);
					num2 = 14;
					continue;
				case 36:
					if (field1)
					{
						num2 = 15;
						continue;
					}
					goto case 12;
				}
				break;
			}
		}
	}

	internal static void hcQZqFO1Ab2nbdfW1ThW()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool LqPS57O1U3nAkqAsnKAG()
	{
		return FLAGkZO1ki2ub28ps2Ts == null;
	}

	internal static FlowConnectorLabel jr3io4O1VtgOlkCKqPvR()
	{
		return FLAGkZO1ki2ub28ps2Ts;
	}

	internal static object Vjbu37O1GXyNpXbrOFjf(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool GDmPr2O17OcUpNUCwOC3(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static object omWSb1O12Q9ntJFN8Sx7(object P_0, Guid P_1)
	{
		return ((NLabel)P_0).GetAnchorModel(P_1);
	}

	internal static NMatrix2DF idRrPtO1oDwhS1xHCtl2(object P_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NTransformableElement)P_0).get_SceneTransform();
	}

	internal static NMatrix2DF nggo6fO1Fy73pQdJDZuU(object P_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((INWorld)P_0).get_SceneToWorld();
	}

	internal static float XKOmx9O1iwUI7ydlrG2U(object P_0, float P_1)
	{
		return ((NModel)P_0).GetLengthOrientation(P_1);
	}

	internal static int Q9jCjdO1I3swfHVNmboX(float P_0)
	{
		return NGeometry2D.AngleQuadrant(P_0);
	}

	internal static bool AofketO1a1u3oCShCnOg(object P_0, object P_1, object P_2)
	{
		return ((NDiagramNode)P_0).OnPropertyChanging((string)P_1, P_2);
	}

	internal static void CuUJb1O1rEn3R9GVGpJx(object P_0, object P_1)
	{
		((NDiagramElement)P_0).RecordProperty((string)P_1);
	}

	internal static void uloTUJO1eopR7l61C9bl(object P_0)
	{
		((NStyleableElement)P_0).Invalidate();
	}

	internal static void PsySYLO1NY5es3RwNpVQ(object P_0, object P_1)
	{
		((NDiagramNode)P_0).OnPropertyChanged((string)P_1);
	}
}
