using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using EleWise.ELMA.Workflow.Diagrams.Shapes;
using j3AmrhgkCleVTGdEwA;
using Nevron.Diagram;
using Nevron.Dom;
using Nevron.GraphicsCore;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Gateways;

[Serializable]
public abstract class GatewayShape : BPMNShape
{
	internal static GatewayShape P5DcR6ONrH2mtXJXXDnT;

	protected virtual Color StartColor => yOV13lOx0JLBYZkruwXO(244, 244, 244);

	protected virtual Color EndColor => yOV13lOx0JLBYZkruwXO(244, 244, 244);

	protected virtual Color StrokeColor => yOV13lOx0JLBYZkruwXO(156, 164, 175);

	protected virtual float DefaultWidth => 49f;

	protected virtual float DefaultHeight => 49f;

	protected virtual float StrokeWidth => 2f;

	protected virtual float Radius => 4f;

	public GatewayShape()
	{
		//Discarded unreachable code: IL_002a
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected O, but got Unknown
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		qSXAbcONxTGCKrNb57en();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4ef74b4b7d13430e9d2f9b78cbdb367b == 0)
		{
			num = 1;
		}
		NCustomPath val = default(NCustomPath);
		NAbilities val2 = default(NAbilities);
		while (true)
		{
			switch (num)
			{
			case 4:
				val = new NCustomPath(CreatePath(0f, 0f, gyiOIUONhbEvQj8J7MGf(this), xyrfvZONE92GNd2kPtIC(this), ddKfHYONwg9oD2upw7fZ(this)), (PathType)1);
				num = 9;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a27e75af798c48d692c4325f43aa9e6b == 0)
				{
					num = 5;
				}
				break;
			case 9:
				mEocL0OxKW2tIenTJwfu(FVrcG5ON4RBOoolOihuQ(this), (object)new NGradientFillStyle((GradientStyle)0, (GradientVariant)0, StartColor, jxBkHjONzAcQVvrV93Fp(this)));
				num = 6;
				break;
			case 8:
				((NAbilities)(ref val2)).set_ResizeY(true);
				num = 11;
				break;
			case 10:
				g4om4BOx84We8bVtZe79(this);
				num = 2;
				break;
			case 2:
				((NDiagramElementCollection)lfMl0KOxs9tSUww5sWlC(this)).RemoveAllChildren();
				num = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f508947b0d94af1961e5aa17a8a2044 != 0)
				{
					num = 3;
				}
				break;
			case 7:
				((NAbilities)(ref val2)).set_ResizeX(true);
				num = 8;
				break;
			case 6:
				tXpRahOxZiL7Le76dBo1(((NStyleableElement)this).get_Style(), (object)new NStrokeStyle(StrokeWidth, Bt39HfOxOQouxkL0sUbQ(this)));
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe7a0ffe67e4fea8e329ae6574ed2ca != 0)
				{
					num = 0;
				}
				break;
			case 3:
				return;
			case 1:
				val2 = HRqYVsONSMEaly5PKJyL(this);
				num = 7;
				break;
			case 5:
			{
				cJrWr2ON1QAdbIQjq6VK(this, val2);
				int num2 = 4;
				num = num2;
				break;
			}
			case 11:
				((NAbilities)(ref val2)).set_InplaceEdit(true);
				num = 5;
				break;
			default:
				bYWV6EOxYcr90OuIF2ba(uoEjenOxvVU5vgEIOOqv(this), val);
				num = 10;
				break;
			}
		}
	}

	public override NModel GetBorderDecoratorModel(NRectangleF bounds)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		return (NModel)(object)CreateGatewayPolygon(bounds.X, bounds.Y, bounds.Width, bounds.Height);
	}

	protected NPolygonPath CreateGatewayPolygon(float x, float y, float w, float h)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		return new NPolygonPath((NPointF[])(object)new NPointF[4]
		{
			new NPointF(x + w / 2f, y),
			new NPointF(x + w, y + h / 2f),
			new NPointF(x + w / 2f, y + h),
			new NPointF(x, y + h / 2f)
		});
	}

	private GraphicsPath CreatePath(float x, float y, float w, float h, float radius)
	{
		int num = 5;
		int num2 = num;
		float num7 = default(float);
		float num3 = default(float);
		float num6 = default(float);
		float num5 = default(float);
		float num4 = default(float);
		while (true)
		{
			switch (num2)
			{
			case 2:
				num7 = y + h - num3;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4459fbe344a947429d197733d274ef68 == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				num3 = radius * 2f;
				num2 = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				num6 = y + h / 2f - radius;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_545887e65739480a965b7ddfab7d0632 == 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				num5 = x + w / 2f - radius;
				num2 = 3;
				break;
			default:
			{
				GraphicsPath graphicsPath = new GraphicsPath();
				wj33NaOxJqgV3ekQcoLP(graphicsPath, num5, y, num3, num3, 225f, 90f);
				wj33NaOxJqgV3ekQcoLP(graphicsPath, num4, num6, num3, num3, 315f, 90f);
				wj33NaOxJqgV3ekQcoLP(graphicsPath, num5, num7, num3, num3, 45f, 90f);
				wj33NaOxJqgV3ekQcoLP(graphicsPath, x, num6, num3, num3, 135f, 90f);
				HQHe2tOxluPE9AgviZtX(graphicsPath);
				return graphicsPath;
			}
			case 1:
				num4 = x + w - num3;
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a == 0)
				{
					num2 = 0;
				}
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
			case 1:
				fDCEXaOxy9jB4cQRQfjK(this, false);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static void qSXAbcONxTGCKrNb57en()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static NAbilities HRqYVsONSMEaly5PKJyL(object P_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NDiagramElement)P_0).get_Protection();
	}

	internal static void cJrWr2ON1QAdbIQjq6VK(object P_0, NAbilities P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((NDiagramElement)P_0).set_Protection(P_1);
	}

	internal static float gyiOIUONhbEvQj8J7MGf(object P_0)
	{
		return ((GatewayShape)P_0).DefaultWidth;
	}

	internal static float xyrfvZONE92GNd2kPtIC(object P_0)
	{
		return ((GatewayShape)P_0).DefaultHeight;
	}

	internal static float ddKfHYONwg9oD2upw7fZ(object P_0)
	{
		return ((GatewayShape)P_0).Radius;
	}

	internal static object FVrcG5ON4RBOoolOihuQ(object P_0)
	{
		return ((NStyleableElement)P_0).get_Style();
	}

	internal static Color jxBkHjONzAcQVvrV93Fp(object P_0)
	{
		return ((GatewayShape)P_0).EndColor;
	}

	internal static void mEocL0OxKW2tIenTJwfu(object P_0, object P_1)
	{
		((NStyle)P_0).set_FillStyle((NFillStyle)P_1);
	}

	internal static Color Bt39HfOxOQouxkL0sUbQ(object P_0)
	{
		return ((GatewayShape)P_0).StrokeColor;
	}

	internal static void tXpRahOxZiL7Le76dBo1(object P_0, object P_1)
	{
		((NStyle)P_0).set_StrokeStyle((NStrokeStyle)P_1);
	}

	internal static object uoEjenOxvVU5vgEIOOqv(object P_0)
	{
		return ((NCompositeShape)P_0).get_Primitives();
	}

	internal static void bYWV6EOxYcr90OuIF2ba(object P_0, object P_1)
	{
		((NDiagramElementCollection)P_0).AddChild((INNode)P_1);
	}

	internal static void g4om4BOx84We8bVtZe79(object P_0)
	{
		((GatewayShape)P_0).AddPorts();
	}

	internal static object lfMl0KOxs9tSUww5sWlC(object P_0)
	{
		return ((NShape)P_0).get_Labels();
	}

	internal static bool xA4VGaONe8xrSrf62BMJ()
	{
		return P5DcR6ONrH2mtXJXXDnT == null;
	}

	internal static GatewayShape iv5tJ3ONNYwcqQRau1c4()
	{
		return P5DcR6ONrH2mtXJXXDnT;
	}

	internal static void wj33NaOxJqgV3ekQcoLP(object P_0, float P_1, float P_2, float P_3, float P_4, float P_5, float P_6)
	{
		((GraphicsPath)P_0).AddArc(P_1, P_2, P_3, P_4, P_5, P_6);
	}

	internal static void HQHe2tOxluPE9AgviZtX(object P_0)
	{
		((GraphicsPath)P_0).CloseAllFigures();
	}

	internal static Color yOV13lOx0JLBYZkruwXO(int P_0, int P_1, int P_2)
	{
		return Color.FromArgb(P_0, P_1, P_2);
	}

	internal static void fDCEXaOxy9jB4cQRQfjK(object P_0, bool addIntermediate)
	{
		ShapeHelper.AddPorts((NShape)P_0, addIntermediate);
	}
}
