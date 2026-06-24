using System;
using System.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using Nevron.Diagram;
using Nevron.GraphicsCore;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Swimlanes;

[Serializable]
public class HSwimlaneLabel : NBoundsLabel
{
	private static HSwimlaneLabel jyAjt4Or0mMM8T9KfbAE;

	[EditorBrowsable(EditorBrowsableState.Never)]
	public HSwimlaneLabel()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		zrZnK4OrtUjSk6WlTsiO();
		((NBoundsLabel)this)._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bd84f42638494cb6b4427f8e13ec59af != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public HSwimlaneLabel(string text, Guid anchorUniqueId, NMargins margins)
	{
		//Discarded unreachable code: IL_002d, IL_0032
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		((NBoundsLabel)this)._002Ector(text, anchorUniqueId, margins);
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a27e75af798c48d692c4325f43aa9e6b == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public override bool GetDesiredSize(out NSizeF size)
	{
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		int num = 6;
		int num2 = num;
		NMargins val = default(NMargins);
		float num3 = default(float);
		float num4 = default(float);
		while (true)
		{
			switch (num2)
			{
			case 6:
				if (!((NDiagramNode)this).MeasureStringInScene((string)HsXHJQOrbunWQ2maKPC9(this), (NTextStyle)Jdism8Or5dCp64DlLBAU(this), ref size))
				{
					num2 = 5;
					break;
				}
				val = HtGUl7OrgXZHgfOZeEed(this);
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
			{
				float top = ((NMargins)(ref val)).get_Top();
				val = HtGUl7OrgXZHgfOZeEed(this);
				num3 = top + ((NMargins)(ref val)).get_Bottom();
				num2 = 4;
				break;
			}
			case 2:
			{
				float left = ((NMargins)(ref val)).get_Left();
				val = HtGUl7OrgXZHgfOZeEed(this);
				num4 = left + ((NMargins)(ref val)).get_Right();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b1ab9396b25b43af8f32e24b1948be96 == 0)
				{
					num2 = 1;
				}
				break;
			}
			case 5:
				return false;
			case 4:
				size.Width = 100f * size.Width / (100f - num4);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e2e244178c44ea09cd756894b022a62 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				val = ((NBoundsLabel)this).get_Margins();
				num2 = 3;
				break;
			default:
				size.Height = 100f * size.Height / (100f - num3);
				num2 = 6;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5d3bc916b5664717ac60544de077bd16 == 0)
				{
					num2 = 7;
				}
				break;
			case 7:
				return true;
			}
		}
	}

	public override bool GetWorldTextPaintInfo(string text, out NTextPaintInfo info)
	{
		//Discarded unreachable code: IL_0105, IL_0114, IL_01e3, IL_01f2, IL_0242, IL_0251, IL_0296, IL_02a5
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Invalid comparison between Unknown and I4
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		int num = 10;
		int num2 = num;
		NRectangleF val2 = default(NRectangleF);
		NPointF[] array = default(NPointF[]);
		BoxTextMode val4 = default(BoxTextMode);
		HSwimlaneShape hSwimlaneShape = default(HSwimlaneShape);
		NMatrix2DF val3 = default(NMatrix2DF);
		NMargins val = default(NMargins);
		while (true)
		{
			switch (num2)
			{
			case 5:
				if (((NRectangleF)(ref val2)).get_IsEmpty())
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_32f3e755437f4eacb85c8a0d536f83ea == 0)
					{
						num2 = 2;
					}
				}
				else
				{
					array = (NPointF[])IpwLW3OrXohZjJ5Fd1Ys(val2);
					num2 = 20;
				}
				break;
			case 7:
				if ((int)val4 == 0)
				{
					num2 = 14;
					break;
				}
				goto case 17;
			case 1:
				((NTextPaintInfo)(ref info)).InitFromBasisPoints(array, true);
				num2 = 6;
				break;
			case 11:
				return false;
			case 13:
				((NRectangleF)(ref val2))._002Ector(new NPointF(((NModel)hSwimlaneShape).get_ModelBounds().X, hb36R1OrPnxJS5bueUeZ(hSwimlaneShape).Y), new NSizeF(32f, hb36R1OrPnxJS5bueUeZ(hSwimlaneShape).Height));
				num2 = 18;
				break;
			case 6:
				val4 = C31sWZOruJmXojITRamW(this);
				num2 = 7;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5d3bc916b5664717ac60544de077bd16 != 0)
				{
					num2 = 2;
				}
				break;
			case 3:
				info.Mode = (PaintTextMode)1;
				num2 = 15;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b876fa7b083748c8abf8c4b192a11078 == 0)
				{
					num2 = 6;
				}
				break;
			case 20:
				val3 = Gyvk06OrdxVW18q3hEXv(hSwimlaneShape);
				num2 = 12;
				break;
			case 18:
				val = HtGUl7OrgXZHgfOZeEed(this);
				num2 = 16;
				break;
			default:
				info.Mode = (PaintTextMode)0;
				num2 = 19;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea != 0)
				{
					num2 = 19;
				}
				break;
			case 2:
				return false;
			case 8:
				if (hSwimlaneShape != null)
				{
					num2 = 13;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9269d021c6f148b6a1c4afb8cee03b6c == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 11;
			case 12:
				((NMatrix2DF)(ref val3)).TransformPoints(array);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b != 0)
				{
					num2 = 1;
				}
				break;
			case 9:
				hSwimlaneShape = HBSYafOrc0NTP8fKqDOC(this, cGkI5bOrBsIJvYeAWMMk(this)) as HSwimlaneShape;
				num2 = 8;
				break;
			case 4:
			case 15:
			case 19:
				return true;
			case 17:
				if ((int)val4 != 1)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e8980a9fd9d44c20920ffa276900c96f != 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 3;
			case 10:
				info = default(NTextPaintInfo);
				num2 = 9;
				break;
			case 16:
				val2 = ((NMargins)(ref val)).PercentDeflateRectangle(val2);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a != 0)
				{
					num2 = 5;
				}
				break;
			}
		}
	}

	private static NPointF[] GetPoints(NRectangleF rect)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		return (NPointF[])(object)new NPointF[3]
		{
			((NRectangleF)(ref rect)).get_Center(),
			new NPointF(rect.X, ((NRectangleF)(ref rect)).get_Bottom()),
			new NPointF(rect.X, rect.Y)
		};
	}

	internal static void zrZnK4OrtUjSk6WlTsiO()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool gEcKxnOrygPpIy3Fj2JK()
	{
		return jyAjt4Or0mMM8T9KfbAE == null;
	}

	internal static HSwimlaneLabel RREMgcOrmfQVEQK3Jbqq()
	{
		return jyAjt4Or0mMM8T9KfbAE;
	}

	internal static object HsXHJQOrbunWQ2maKPC9(object P_0)
	{
		return ((NLabel)P_0).get_Text();
	}

	internal static object Jdism8Or5dCp64DlLBAU(object P_0)
	{
		return ((NStyleComposerElement)P_0).ComposeTextStyle();
	}

	internal static NMargins HtGUl7OrgXZHgfOZeEed(object P_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NBoundsLabel)P_0).get_Margins();
	}

	internal static Guid cGkI5bOrBsIJvYeAWMMk(object P_0)
	{
		return ((NLabel)P_0).get_AnchorUniqueId();
	}

	internal static object HBSYafOrc0NTP8fKqDOC(object P_0, Guid P_1)
	{
		return ((NLabel)P_0).GetAnchorModel(P_1);
	}

	internal static NRectangleF hb36R1OrPnxJS5bueUeZ(object P_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NModel)P_0).get_ModelBounds();
	}

	internal static object IpwLW3OrXohZjJ5Fd1Ys(NRectangleF rect)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return GetPoints(rect);
	}

	internal static NMatrix2DF Gyvk06OrdxVW18q3hEXv(object P_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NTransformableElement)P_0).get_WorldTransform();
	}

	internal static BoxTextMode C31sWZOruJmXojITRamW(object P_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NBoundsLabel)P_0).get_Mode();
	}
}
