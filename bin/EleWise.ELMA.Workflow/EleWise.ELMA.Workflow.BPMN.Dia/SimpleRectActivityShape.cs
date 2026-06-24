using System;
using System.Drawing;
using EleWise.ELMA.Workflow.Diagrams.Shapes;
using j3AmrhgkCleVTGdEwA;
using Nevron.Diagram;
using Nevron.GraphicsCore;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.SubProcess;

[Serializable]
public abstract class SimpleRectActivityShape : NRectangleShape
{
	private static SimpleRectActivityShape oAWrHwONZUS1HXuKmwH7;

	protected virtual Color StartColor => MC5W4PONb6go7EpiHDTN();

	public SimpleRectActivityShape()
	{
		//Discarded unreachable code: IL_0043
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		ScST7jON8MVOHHY7O45R();
		((NRectangleShape)this)._002Ector(new NRectanglePath(0f, 0f, 96f, 64f));
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a == 0)
		{
			num = 0;
		}
		NAbilities val = default(NAbilities);
		while (true)
		{
			switch (num)
			{
			case 3:
				return;
			case 6:
				((NAbilities)(ref val)).set_InplaceEdit(true);
				num = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_61395ebf330446ac8ce99b55ee3acfa9 != 0)
				{
					num = 5;
				}
				break;
			case 2:
				Bjd8VCONmvdhAaE1bIwL(k4vcd1ON0q6EqDKAU1ey(this), L3Af12ONyoEZpBvDxbQ0());
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3b4403f77a00495e957e5e4a6840e5d3 == 0)
				{
					num = 1;
				}
				break;
			case 4:
			{
				r74a3KONlQvdPYBUDdYF(((NStyleableElement)this).get_Style(), (object)new NGradientFillStyle((GradientStyle)0, (GradientVariant)0, StartColor, StartColor));
				int num2 = 2;
				num = num2;
				break;
			}
			case 1:
				VabN0UONtBeTqlyrGusL(this);
				num = 3;
				break;
			default:
				val = moiR7sONsbX3EKJlkepI(this);
				num = 5;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae2bde9e5844c638021cdb56fc01122 == 0)
				{
					num = 6;
				}
				break;
			case 5:
				OKjg76ONJ9RVwVjqom5I(this, val);
				num = 4;
				break;
			}
		}
	}

	protected virtual void AddPorts()
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
				ShapeHelper.AddPorts((NShape)(object)this, addIntermediate: true);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4ef74b4b7d13430e9d2f9b78cbdb367b != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void ScST7jON8MVOHHY7O45R()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static NAbilities moiR7sONsbX3EKJlkepI(object P_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NDiagramElement)P_0).get_Protection();
	}

	internal static void OKjg76ONJ9RVwVjqom5I(object P_0, NAbilities P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((NDiagramElement)P_0).set_Protection(P_1);
	}

	internal static void r74a3KONlQvdPYBUDdYF(object P_0, object P_1)
	{
		((NStyle)P_0).set_FillStyle((NFillStyle)P_1);
	}

	internal static object k4vcd1ON0q6EqDKAU1ey(object P_0)
	{
		return ((NStyleableElement)P_0).get_Style();
	}

	internal static object L3Af12ONyoEZpBvDxbQ0()
	{
		return ShapeHelper.DefaultStrokeStyle;
	}

	internal static void Bjd8VCONmvdhAaE1bIwL(object P_0, object P_1)
	{
		((NStyle)P_0).set_StrokeStyle((NStrokeStyle)P_1);
	}

	internal static void VabN0UONtBeTqlyrGusL(object P_0)
	{
		((SimpleRectActivityShape)P_0).AddPorts();
	}

	internal static bool tne9owONvGhaApAgDx9w()
	{
		return oAWrHwONZUS1HXuKmwH7 == null;
	}

	internal static SimpleRectActivityShape mXYQxWONYNY6hmFPTwX1()
	{
		return oAWrHwONZUS1HXuKmwH7;
	}

	internal static Color MC5W4PONb6go7EpiHDTN()
	{
		return Color.White;
	}
}
