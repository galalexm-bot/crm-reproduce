using System;
using System.Drawing;
using j3AmrhgkCleVTGdEwA;
using Nevron.Diagram;
using Nevron.Dom;
using Nevron.GraphicsCore;

namespace EleWise.ELMA.Security.Diagrams.Shapes;

[Serializable]
public class NestedStructureShape : OrganizationShape
{
	private static NestedStructureShape fU3GWuePRnaLdhwygOT;

	public NestedStructureShape()
	{
		//Discarded unreachable code: IL_002a
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected O, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected O, but got Unknown
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Expected O, but got Unknown
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Expected O, but got Unknown
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Expected O, but got Unknown
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Expected O, but got Unknown
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fa1b4c3a88294db7b3c25698c3f06dd7 != 0)
		{
			num = 4;
		}
		NLinePath val = default(NLinePath);
		float num2 = default(float);
		NLinePath val2 = default(NLinePath);
		while (true)
		{
			int num3;
			switch (num)
			{
			case 3:
				((NStrokeStyle)RdQKtMeKFfd092YTckI(FZN2qAeJGWCI4mavwRv(val))).set_Width(new NLength(1f * num2));
				num = 8;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_73b92e1f752f422d899693d4318e4486 == 0)
				{
					num = 9;
				}
				break;
			case 7:
				HEjPKdetPDcrV8Fr6tJ(val2, (object)new NStyle());
				num3 = 16;
				goto IL_002f;
			case 15:
				bgcjgMeqU7t8IMyUeaS(this);
				num = 13;
				break;
			case 1:
				((NDiagramElementCollection)Pc5VRceU0FPXgZf5X5d(this)).AddChild((INNode)(object)val2);
				num = 15;
				break;
			case 5:
				ulievYeOCuJPEBfYqr6(RdQKtMeKFfd092YTckI(FZN2qAeJGWCI4mavwRv(val2)), new NLength(1f * num2));
				num = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_364662b38d3b4bdb9f3f1f11b8889cdc == 0)
				{
					num = 1;
				}
				break;
			case 2:
				val2 = new NLinePath(20f, 20f, 23f, 20f);
				num = 7;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_615d1cac86f847c090f528929d6310c2 != 0)
				{
					num = 3;
				}
				break;
			case 8:
				M77RxyeoLvhLPSUwIKZ(Pc5VRceU0FPXgZf5X5d(this), 25f * num2, 0f * num2, num2 * 1.2f, base.StrokeColor, base.FillColor);
				num = 6;
				break;
			case 4:
				num2 = 0.5f;
				num3 = 12;
				goto IL_002f;
			case 16:
				caLhJXehFcY2SqTg5sa(FZN2qAeJGWCI4mavwRv(val2), (object)new NStrokeStyle(base.StrokeColor));
				num = 5;
				break;
			case 12:
				door(num2 * 0.9f, 0f, 20f);
				num = 5;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_03ad39fc745d49e3be14e8e100fb0203 != 0)
				{
					num = 14;
				}
				break;
			case 9:
				((NDiagramElementCollection)Pc5VRceU0FPXgZf5X5d(this)).AddChild((INNode)(object)val);
				num3 = 2;
				goto IL_002f;
			case 11:
				((NStyle)FZN2qAeJGWCI4mavwRv(val)).set_StrokeStyle(new NStrokeStyle(base.StrokeColor));
				num = 3;
				break;
			case 6:
				val = new NLinePath(8f, 20f, 37.5f, 20f);
				num = 10;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5c3c41b36b4846e0b1701d4e56408883 != 0)
				{
					num = 7;
				}
				break;
			case 13:
				return;
			case 14:
				door(num2 * 0.9f, 15f, 20f);
				num = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f4f2657bf7454f44b4829aa89c711f0d == 0)
				{
					num = 0;
				}
				break;
			case 10:
				((NStyleableElement)val).set_Style(new NStyle());
				num = 11;
				break;
			default:
				{
					door(num2 * 0.9f, 30f, 20f);
					num = 8;
					break;
				}
				IL_002f:
				num = num3;
				break;
			}
		}
	}

	private void door(float scale, float x, float y)
	{
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected O, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected O, but got Unknown
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected O, but got Unknown
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Expected O, but got Unknown
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected O, but got Unknown
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Expected O, but got Unknown
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Expected O, but got Unknown
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Expected O, but got Unknown
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_0352: Unknown result type (might be due to invalid IL or missing references)
		//IL_035c: Expected O, but got Unknown
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Expected O, but got Unknown
		int num = 9;
		NLinePath val4 = default(NLinePath);
		NRectanglePath val = default(NRectanglePath);
		NRectanglePath val3 = default(NRectanglePath);
		float num3 = default(float);
		NLinePath val2 = default(NLinePath);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					gnP68YecE8tAvh9HECB(Pc5VRceU0FPXgZf5X5d(this), val4);
					num = 6;
					break;
				default:
					((NStyle)FZN2qAeJGWCI4mavwRv(val)).set_StrokeStyle(new NStrokeStyle(base.StrokeColor));
					num2 = 21;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_56bc39e908f44451b3cdd0d68828e324 == 0)
					{
						num2 = 14;
					}
					continue;
				case 8:
					val = new NRectanglePath(4f * scale + x, scale * 5f + y, 24f * scale, 34f * scale);
					num2 = 11;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8dab57df677749fba2d5364cf752799f == 0)
					{
						num2 = 9;
					}
					continue;
				case 16:
					ulievYeOCuJPEBfYqr6(RdQKtMeKFfd092YTckI(FZN2qAeJGWCI4mavwRv(val3)), new NLength(num3));
					num2 = 17;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f0c2bdf066b1416088266cd84d9c3be2 == 0)
					{
						num2 = 15;
					}
					continue;
				case 12:
					((NStrokeStyle)RdQKtMeKFfd092YTckI(((NStyleableElement)val2).get_Style())).set_Width(new NLength(num3));
					num2 = 19;
					continue;
				case 1:
					ulievYeOCuJPEBfYqr6(RdQKtMeKFfd092YTckI(((NStyleableElement)val4).get_Style()), new NLength(num3));
					num2 = 4;
					continue;
				case 10:
					val2 = new NLinePath(20f * scale + x, 23f * scale + y, 23f * scale + x, 23f * scale + y);
					num2 = 20;
					continue;
				case 5:
					HEjPKdetPDcrV8Fr6tJ(val4, (object)new NStyle());
					num2 = 18;
					continue;
				case 14:
					caLhJXehFcY2SqTg5sa(FZN2qAeJGWCI4mavwRv(val3), (object)new NStrokeStyle(base.StrokeColor));
					num2 = 16;
					continue;
				case 6:
					return;
				case 3:
					val4 = new NLinePath(16f * scale + x, 0f * scale + y, 16f * scale + x, 5f * scale + y);
					num = 5;
					break;
				case 18:
					caLhJXehFcY2SqTg5sa(FZN2qAeJGWCI4mavwRv(val4), (object)new NStrokeStyle(base.StrokeColor));
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_147eeadb328044dda63bf8b1037653db != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					caLhJXehFcY2SqTg5sa(FZN2qAeJGWCI4mavwRv(val2), (object)new NStrokeStyle(base.StrokeColor));
					num2 = 12;
					continue;
				case 13:
					((NDiagramElementCollection)((NCompositeShape)this).get_Primitives()).AddChild((INNode)(object)val);
					num2 = 15;
					continue;
				case 9:
					num3 = 1f * scale;
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_86eb143f59c14824a2785845ea23f248 == 0)
					{
						num2 = 8;
					}
					continue;
				case 17:
					gnP68YecE8tAvh9HECB(((NCompositeShape)this).get_Primitives(), val3);
					num2 = 10;
					continue;
				case 20:
					((NStyleableElement)val2).set_Style(new NStyle());
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_ae5d5c9fcc284404ba2e43f0c4ab8892 == 0)
					{
						num2 = 2;
					}
					continue;
				case 15:
					val3 = new NRectanglePath(12f * scale + x, 9f * scale + y, 8f * scale, 6f * scale);
					num2 = 7;
					continue;
				case 21:
					((NStrokeStyle)RdQKtMeKFfd092YTckI(FZN2qAeJGWCI4mavwRv(val))).set_Width(new NLength(num3));
					num2 = 13;
					continue;
				case 19:
					((NDiagramElementCollection)Pc5VRceU0FPXgZf5X5d(this)).AddChild((INNode)(object)val2);
					num2 = 3;
					continue;
				case 7:
					HEjPKdetPDcrV8Fr6tJ(val3, (object)new NStyle());
					num2 = 5;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c08b0b4e9ab14bedb2a2c7a0048ab814 == 0)
					{
						num2 = 14;
					}
					continue;
				case 11:
					((NStyleableElement)val).set_Style(new NStyle());
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_56bc39e908f44451b3cdd0d68828e324 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
		}
	}

	internal static object Pc5VRceU0FPXgZf5X5d(object P_0)
	{
		return ((NCompositeShape)P_0).get_Primitives();
	}

	internal static void M77RxyeoLvhLPSUwIKZ(object P_0, float dx, float dy, float scale, Color strokeColor, Color fillColor)
	{
		OrganizationShapes.RenderHumanShape((NPrimitiveModelCollection)P_0, dx, dy, scale, strokeColor, fillColor);
	}

	internal static object FZN2qAeJGWCI4mavwRv(object P_0)
	{
		return ((NStyleableElement)P_0).get_Style();
	}

	internal static object RdQKtMeKFfd092YTckI(object P_0)
	{
		return ((NStyle)P_0).get_StrokeStyle();
	}

	internal static void HEjPKdetPDcrV8Fr6tJ(object P_0, object P_1)
	{
		((NStyleableElement)P_0).set_Style((NStyle)P_1);
	}

	internal static void caLhJXehFcY2SqTg5sa(object P_0, object P_1)
	{
		((NStyle)P_0).set_StrokeStyle((NStrokeStyle)P_1);
	}

	internal static void ulievYeOCuJPEBfYqr6(object P_0, NLength P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((NStrokeStyle)P_0).set_Width(P_1);
	}

	internal static bool bgcjgMeqU7t8IMyUeaS(object P_0)
	{
		return ((NAggregateModel)P_0).UpdateModelBounds();
	}

	internal static bool iLJlvRevs9OCwWFIIjN()
	{
		return fU3GWuePRnaLdhwygOT == null;
	}

	internal static NestedStructureShape pQoyq5eCr8TA6rroeNh()
	{
		return fU3GWuePRnaLdhwygOT;
	}

	internal static void gnP68YecE8tAvh9HECB(object P_0, object P_1)
	{
		((NDiagramElementCollection)P_0).AddChild((INNode)P_1);
	}
}
