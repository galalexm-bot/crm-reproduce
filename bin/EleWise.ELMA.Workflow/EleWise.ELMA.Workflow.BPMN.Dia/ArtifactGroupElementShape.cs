using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;
using Nevron;
using Nevron.Diagram;
using Nevron.Dom;
using Nevron.GraphicsCore;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes;

[Serializable]
public class ArtifactGroupElementShape : NCompositeShape
{
	internal static ArtifactGroupElementShape gQUqMdOFSYdkyJEf0adN;

	protected virtual Color StartColor => rFshVcOiLfO9iltj3XeS();

	protected virtual float StrokeWidth => 2f;

	protected virtual float DefaultWidth
	{
		[CompilerGenerated]
		get
		{
			return _003CDefaultWidth_003Ek__BackingField;
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
					_003CDefaultWidth_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a23e27b648a042f098a477c26c4beed1 == 0)
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

	protected virtual float DefaultHeight
	{
		[CompilerGenerated]
		get
		{
			return _003CDefaultHeight_003Ek__BackingField;
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
					_003CDefaultHeight_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ffb1346d351f436b84bb1e9954c3bfa8 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	protected virtual float Radius => 8f;

	public ArtifactGroupElementShape()
	{
		//Discarded unreachable code: IL_001e
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected O, but got Unknown
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected O, but got Unknown
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Expected O, but got Unknown
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Expected O, but got Unknown
		Nm1OF8OFEAPECRBJ4cgN();
		((NCompositeShape)this)._002Ector();
		int num = 12;
		NCustomPath val2 = default(NCustomPath);
		NAbilities val3 = default(NAbilities);
		NStyle val = default(NStyle);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					TxyKi6OitlpJto4LCJNN(iAZHf3Oim0S95lCFyOQg(this), val2);
					num2 = 13;
					continue;
				case 1:
					zdUyNmOigNnBVPgfr29a(this, val3);
					num2 = 6;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e == 0)
					{
						num2 = 0;
					}
					continue;
				case 8:
					val3 = QOPb1OOi5bIK8MXq0CbB(this);
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_160bffb148c14c5da92d8d6ddf481bdc == 0)
					{
						num2 = 5;
					}
					continue;
				case 2:
					wGUwKvOF4JEg4uyRWWgq(this, 164f);
					num2 = 16;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b84ccb8b1bd147ef900b852047ecbf45 != 0)
					{
						num2 = 14;
					}
					continue;
				case 15:
					ADAcswOissgZe90JQ4sD(val, (object)new NStrokeStyle(StrokeWidth, ie9fFNOi8jRjmygH8LSE()));
					num2 = 10;
					continue;
				case 6:
					return;
				case 5:
					((NAbilities)(ref val3)).set_InplaceEdit(true);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b != 0)
					{
						num2 = 1;
					}
					continue;
				case 13:
					yyxw1jOib2TPEqyqWFUh(this);
					num2 = 8;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4cc62744d0eb4cd68219b70dcad3e68e != 0)
					{
						num2 = 1;
					}
					continue;
				case 9:
					rcqcZyOi0uYRQ1gvoYKK(gVqvUaOiJ5sOtlsj6ic6(val), 65304);
					num2 = 11;
					continue;
				case 4:
					((NStrokeStyle)gVqvUaOiJ5sOtlsj6ic6(val)).set_Factor(1);
					num2 = 9;
					continue;
				case 11:
					break;
				default:
					val2 = new NCustomPath((GraphicsPath)OBkvQEOiZeHDxomg0A4o(0f, 0f, hPavuZOiK34Ja9xW3BGC(this), DefaultHeight, BpJE6GOiOSk75fKVfAiW(this)), (PathType)1);
					num2 = 7;
					continue;
				case 12:
					wkSC3EOFwKsXuwV05VPt(this, 96f);
					num2 = 2;
					continue;
				case 16:
					sd3QWHOFzeQldNuNLfZL(this, (RouteObstacleType)1);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6d48f3b4557a49578bf7f5ef0517e0be == 0)
					{
						num2 = 0;
					}
					continue;
				case 14:
					apgGY4OiYxEadMdUNb3s(val, (object)new NColorFillStyle(HqBjVYOivEbqhBHnw36G()));
					num2 = 15;
					continue;
				case 17:
					pZnsKtOiyEWhg4Oa3RjQ(val2, val);
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f2d402219199402696ade21eab23d086 == 0)
					{
						num2 = 0;
					}
					continue;
				case 10:
					BCaTm0OilTlm7p7NU0Kt(gVqvUaOiJ5sOtlsj6ic6(val), (LinePattern)65383);
					num2 = 4;
					continue;
				case 7:
					val = new NStyle();
					num2 = 14;
					continue;
				}
				break;
			}
			sd3QWHOFzeQldNuNLfZL(this, (RouteObstacleType)1);
			num = 17;
		}
	}

	protected override void CreateDefaultLabels()
	{
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		int num = 4;
		NBoundsLabel val2 = default(NBoundsLabel);
		NStyle val = default(NStyle);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					((NDiagramElementCollection)((NShape)this).get_Labels()).AddChild((INNode)(object)val2);
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 == 0)
					{
						num2 = 0;
					}
					continue;
				case 6:
					return;
				default:
					pMUn8VOiPpjKtHTI4fAR(val, (object)new NTextStyle(new Font((string)UI0S8qOiBXm1cZsNiRa9(-11799394 ^ -11946614), 13f), bQEOUrOicpp024Wl8Pe8(95, 95, 95)));
					num2 = 8;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_43af423d081c48e3bc6cea30ce47523d != 0)
					{
						num2 = 2;
					}
					continue;
				case 8:
					SyRPdDOidtVEf4SYrwnE(yeB7hMOiXcK5NCclinSk(val.get_TextStyle()), (VertAlign)2);
					num2 = 5;
					continue;
				case 3:
					val = new NStyle();
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c447ffb64be44c09b6fd398df506785b != 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					Mn70MdOiHYHytsxBJLku(fXjFgcOiDblph5ZjU678(this), oXEolBOinL5sPHIvRj34(val2));
					num2 = 6;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ac5d16a577a84bb0b8ee3654769d2d33 != 0)
					{
						num2 = 2;
					}
					continue;
				case 7:
					break;
				case 4:
					val2 = new NBoundsLabel((string)UI0S8qOiBXm1cZsNiRa9(-1514166050 ^ -1514294536), Guid.Empty, NMargins.Empty);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3bb28bf622874b4689f9265e58d14823 == 0)
					{
						num2 = 3;
					}
					continue;
				case 5:
					hLP648OiuSTyRVKe5opG(val.get_TextStyle(), new NPointL(0, -3));
					num2 = 7;
					continue;
				}
				break;
			}
			pZnsKtOiyEWhg4Oa3RjQ(val2, val);
			num = 2;
		}
	}

	private static GraphicsPath CreatePath(float x, float y, float w, float h, float radius)
	{
		int num = 2;
		int num2 = num;
		float num5 = default(float);
		float num3 = default(float);
		float num4 = default(float);
		while (true)
		{
			switch (num2)
			{
			case 3:
				num5 = y + h - num3;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_08023922bb0e4e809e5cff73a2b04988 == 0)
				{
					num2 = 0;
				}
				break;
			default:
			{
				GraphicsPath graphicsPath = new GraphicsPath();
				b7TG2EOiflPHKwnmg4rt(graphicsPath, num4, num5, num3, num3, 0f, 90f);
				b7TG2EOiflPHKwnmg4rt(graphicsPath, x, num5, num3, num3, 90f, 90f);
				b7TG2EOiflPHKwnmg4rt(graphicsPath, x, y, num3, num3, 180f, 90f);
				b7TG2EOiflPHKwnmg4rt(graphicsPath, num4, y, num3, num3, 270f, 90f);
				kBaFasOi9M1J9MVH8ey3(graphicsPath);
				return graphicsPath;
			}
			case 2:
				num3 = radius * 2f;
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_558b46b4f4364838b08ac89d77f9a257 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				num4 = x + w - num3;
				num2 = 3;
				break;
			}
		}
	}

	internal static void Nm1OF8OFEAPECRBJ4cgN()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static void wkSC3EOFwKsXuwV05VPt(object P_0, float value)
	{
		((ArtifactGroupElementShape)P_0).DefaultHeight = value;
	}

	internal static void wGUwKvOF4JEg4uyRWWgq(object P_0, float value)
	{
		((ArtifactGroupElementShape)P_0).DefaultWidth = value;
	}

	internal static void sd3QWHOFzeQldNuNLfZL(object P_0, RouteObstacleType P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((NShape)P_0).set_RouteObstacleType(P_1);
	}

	internal static float hPavuZOiK34Ja9xW3BGC(object P_0)
	{
		return ((ArtifactGroupElementShape)P_0).DefaultWidth;
	}

	internal static float BpJE6GOiOSk75fKVfAiW(object P_0)
	{
		return ((ArtifactGroupElementShape)P_0).Radius;
	}

	internal static object OBkvQEOiZeHDxomg0A4o(float x, float y, float w, float h, float radius)
	{
		return CreatePath(x, y, w, h, radius);
	}

	internal static Color HqBjVYOivEbqhBHnw36G()
	{
		return Color.Transparent;
	}

	internal static void apgGY4OiYxEadMdUNb3s(object P_0, object P_1)
	{
		((NStyle)P_0).set_FillStyle((NFillStyle)P_1);
	}

	internal static Color ie9fFNOi8jRjmygH8LSE()
	{
		return Color.Silver;
	}

	internal static void ADAcswOissgZe90JQ4sD(object P_0, object P_1)
	{
		((NStyle)P_0).set_StrokeStyle((NStrokeStyle)P_1);
	}

	internal static object gVqvUaOiJ5sOtlsj6ic6(object P_0)
	{
		return ((NStyle)P_0).get_StrokeStyle();
	}

	internal static void BCaTm0OilTlm7p7NU0Kt(object P_0, LinePattern P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((NStrokeStyle)P_0).set_Pattern(P_1);
	}

	internal static void rcqcZyOi0uYRQ1gvoYKK(object P_0, int P_1)
	{
		((NStrokeStyle)P_0).set_CustomPattern(P_1);
	}

	internal static void pZnsKtOiyEWhg4Oa3RjQ(object P_0, object P_1)
	{
		((NStyleableElement)P_0).set_Style((NStyle)P_1);
	}

	internal static object iAZHf3Oim0S95lCFyOQg(object P_0)
	{
		return ((NCompositeShape)P_0).get_Primitives();
	}

	internal static void TxyKi6OitlpJto4LCJNN(object P_0, object P_1)
	{
		((NDiagramElementCollection)P_0).AddChild((INNode)P_1);
	}

	internal static bool yyxw1jOib2TPEqyqWFUh(object P_0)
	{
		return ((NAggregateModel)P_0).UpdateModelBounds();
	}

	internal static NAbilities QOPb1OOi5bIK8MXq0CbB(object P_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NDiagramElement)P_0).get_Protection();
	}

	internal static void zdUyNmOigNnBVPgfr29a(object P_0, NAbilities P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((NDiagramElement)P_0).set_Protection(P_1);
	}

	internal static bool wxki1LOF1Nfhj29Ovs0d()
	{
		return gQUqMdOFSYdkyJEf0adN == null;
	}

	internal static ArtifactGroupElementShape DVEnHdOFhJJKqtJM0dHK()
	{
		return gQUqMdOFSYdkyJEf0adN;
	}

	internal static object UI0S8qOiBXm1cZsNiRa9(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static Color bQEOUrOicpp024Wl8Pe8(int P_0, int P_1, int P_2)
	{
		return Color.FromArgb(P_0, P_1, P_2);
	}

	internal static void pMUn8VOiPpjKtHTI4fAR(object P_0, object P_1)
	{
		((NStyle)P_0).set_TextStyle((NTextStyle)P_1);
	}

	internal static object yeB7hMOiXcK5NCclinSk(object P_0)
	{
		return ((NTextStyle)P_0).get_StringFormatStyle();
	}

	internal static void SyRPdDOidtVEf4SYrwnE(object P_0, VertAlign P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((NStringFormatStyle)P_0).set_VertAlign(P_1);
	}

	internal static void hLP648OiuSTyRVKe5opG(object P_0, NPointL P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((NTextStyle)P_0).set_Offset(P_1);
	}

	internal static object fXjFgcOiDblph5ZjU678(object P_0)
	{
		return ((NShape)P_0).get_Labels();
	}

	internal static Guid oXEolBOinL5sPHIvRj34(object P_0)
	{
		return ((NDiagramElement)P_0).get_UniqueId();
	}

	internal static void Mn70MdOiHYHytsxBJLku(object P_0, Guid P_1)
	{
		((NLabelCollection)P_0).set_DefaultLabelUniqueId(P_1);
	}

	internal static Color rFshVcOiLfO9iltj3XeS()
	{
		return Color.White;
	}

	internal static void b7TG2EOiflPHKwnmg4rt(object P_0, float P_1, float P_2, float P_3, float P_4, float P_5, float P_6)
	{
		((GraphicsPath)P_0).AddArc(P_1, P_2, P_3, P_4, P_5, P_6);
	}

	internal static void kBaFasOi9M1J9MVH8ey3(object P_0)
	{
		((GraphicsPath)P_0).CloseAllFigures();
	}
}
