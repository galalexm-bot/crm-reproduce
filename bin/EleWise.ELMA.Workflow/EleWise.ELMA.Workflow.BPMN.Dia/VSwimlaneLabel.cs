using System;
using System.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using Nevron.Diagram;
using Nevron.GraphicsCore;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Swimlanes;

[Serializable]
public class VSwimlaneLabel : NBoundsLabel
{
	private static VSwimlaneLabel zJELdyOebXZZmCfFFwYU;

	[EditorBrowsable(EditorBrowsableState.Never)]
	public VSwimlaneLabel()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		OOVZN8OeB7R0a71bjj0d();
		((NBoundsLabel)this)._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3b4403f77a00495e957e5e4a6840e5d3 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public VSwimlaneLabel(string text, Guid anchorUniqueId, NMargins margins)
	{
		//Discarded unreachable code: IL_002d, IL_0032
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		OOVZN8OeB7R0a71bjj0d();
		((NBoundsLabel)this)._002Ector(text, anchorUniqueId, margins);
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_26fa47f5bd8343debcae8b05a56a3ab5 == 0)
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
		//Discarded unreachable code: IL_00fd, IL_010c
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		int num = 3;
		float num4 = default(float);
		float num3 = default(float);
		NMargins val = default(NMargins);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
					size.Width = 100f * size.Width / (100f - num4);
					num2 = 6;
					continue;
				case 6:
					size.Height = 100f * size.Height / (100f - num3);
					num2 = 5;
					continue;
				case 1:
					return false;
				case 2:
					val = aOC4u4OeXJryJLbpFPUN(this);
					num2 = 8;
					continue;
				case 4:
					break;
				case 8:
				{
					float left = ((NMargins)(ref val)).get_Left();
					val = aOC4u4OeXJryJLbpFPUN(this);
					num4 = left + ((NMargins)(ref val)).get_Right();
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a9be7e056b4e4b6e863b634c418144f1 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				case 3:
					if (((NDiagramNode)this).MeasureStringInScene((string)f4mvknOecjZ0tdh6IsF0(this), (NTextStyle)HuVBdLOePpy6I4q4kmXI(this), ref size))
					{
						num2 = 2;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_160bffb148c14c5da92d8d6ddf481bdc == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 1;
				case 5:
					return true;
				default:
					val = aOC4u4OeXJryJLbpFPUN(this);
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e2e244178c44ea09cd756894b022a62 != 0)
					{
						num2 = 4;
					}
					continue;
				}
				break;
			}
			float top = ((NMargins)(ref val)).get_Top();
			val = aOC4u4OeXJryJLbpFPUN(this);
			num3 = top + ((NMargins)(ref val)).get_Bottom();
			num = 7;
		}
	}

	public override bool GetWorldTextPaintInfo(string text, out NTextPaintInfo info)
	{
		//Discarded unreachable code: IL_00e8, IL_00f7, IL_012a, IL_01b7
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Invalid comparison between Unknown and I4
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		int num = 16;
		VSwimlaneShape vSwimlaneShape = default(VSwimlaneShape);
		NRectangleF val = default(NRectangleF);
		BoxTextMode val2 = default(BoxTextMode);
		NPointF[] array = default(NPointF[]);
		NMatrix2DF worldTransform = default(NMatrix2DF);
		NMargins margins = default(NMargins);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 15:
					goto end_IL_0012;
				case 6:
					if (vSwimlaneShape == null)
					{
						num2 = 10;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f2d402219199402696ade21eab23d086 != 0)
						{
							num2 = 19;
						}
					}
					else
					{
						((NRectangleF)(ref val))._002Ector(new NPointF(((NModel)vSwimlaneShape).get_ModelBounds().X, ((NModel)vSwimlaneShape).get_ModelBounds().Y), new NSizeF(((NModel)vSwimlaneShape).get_ModelBounds().Width, 32f));
						num2 = 11;
					}
					continue;
				case 1:
					if ((int)val2 == 0)
					{
						num2 = 14;
						continue;
					}
					goto case 13;
				case 3:
				case 4:
				case 12:
					return true;
				case 5:
					val2 = pEsUXfOeucOD6Wjb1Ljp(this);
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6b089b0d02ae4d3186c8d2cb8a24d4d3 == 0)
					{
						num2 = 1;
					}
					continue;
				case 17:
					((NTextPaintInfo)(ref info)).InitFromBasisPoints(array, true);
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58fb165cafed422d973d4a7156526541 == 0)
					{
						num2 = 2;
					}
					continue;
				case 8:
					if (((NRectangleF)(ref val)).get_IsEmpty())
					{
						num2 = 2;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 != 0)
						{
							num2 = 2;
						}
					}
					else
					{
						array = (NPointF[])wY8oZVOedpnqKd0TULB1(val);
						num2 = 7;
					}
					continue;
				case 13:
					if ((int)val2 != 1)
					{
						num2 = 4;
						continue;
					}
					break;
				case 19:
					return false;
				case 7:
					worldTransform = ((NTransformableElement)vSwimlaneShape).get_WorldTransform();
					num2 = 10;
					continue;
				case 11:
					margins = ((NBoundsLabel)this).get_Margins();
					num2 = 18;
					continue;
				default:
					info.Mode = (PaintTextMode)0;
					num2 = 3;
					continue;
				case 10:
					((NMatrix2DF)(ref worldTransform)).TransformPoints(array);
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1b8b735647da470aa2d45d64d6f538d1 != 0)
					{
						num2 = 17;
					}
					continue;
				case 16:
					info = default(NTextPaintInfo);
					num2 = 15;
					continue;
				case 18:
					val = ((NMargins)(ref margins)).PercentDeflateRectangle(val);
					num2 = 8;
					continue;
				case 2:
					return false;
				case 9:
					break;
				}
				info.Mode = (PaintTextMode)1;
				num2 = 12;
				continue;
				end_IL_0012:
				break;
			}
			vSwimlaneShape = ((NLabel)this).GetAnchorModel(((NLabel)this).get_AnchorUniqueId()) as VSwimlaneShape;
			num = 6;
		}
	}

	private static NPointF[] GetPoints(NRectangleF rect)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		return (NPointF[])(object)new NPointF[3]
		{
			((NRectangleF)(ref rect)).get_Center(),
			new NPointF(rect.X, rect.Y),
			new NPointF(((NRectangleF)(ref rect)).get_Right(), rect.Y)
		};
	}

	internal static void OOVZN8OeB7R0a71bjj0d()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool H6hHHjOe5xiVSM6hb0Eh()
	{
		return zJELdyOebXZZmCfFFwYU == null;
	}

	internal static VSwimlaneLabel UFtOeYOeg30aTVUi5Roo()
	{
		return zJELdyOebXZZmCfFFwYU;
	}

	internal static object f4mvknOecjZ0tdh6IsF0(object P_0)
	{
		return ((NLabel)P_0).get_Text();
	}

	internal static object HuVBdLOePpy6I4q4kmXI(object P_0)
	{
		return ((NStyleComposerElement)P_0).ComposeTextStyle();
	}

	internal static NMargins aOC4u4OeXJryJLbpFPUN(object P_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NBoundsLabel)P_0).get_Margins();
	}

	internal static object wY8oZVOedpnqKd0TULB1(NRectangleF rect)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return GetPoints(rect);
	}

	internal static BoxTextMode pEsUXfOeucOD6Wjb1Ljp(object P_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NBoundsLabel)P_0).get_Mode();
	}
}
