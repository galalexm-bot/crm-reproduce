using System.Drawing.Drawing2D;
using EleWise.ELMA.Workflow.Diagrams.Shapes;
using j3AmrhgkCleVTGdEwA;
using Nevron.Diagram;
using Nevron.GraphicsCore;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Decorators;

public class MultiInstanceDecorator : BaseDecorator
{
	private class Line : NCustomPath
	{
		internal static object OBCs4Rv5ux2Uhui3ED3j;

		public Line(float dx, float x, float y, float w, float h)
		{
			//Discarded unreachable code: IL_0031, IL_0036
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Expected O, but got Unknown
			//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
			((NCustomPath)this)._002Ector((GraphicsPath)lZj5jov5HjM39PPFrNkf(dx), (PathType)0);
			int num = 1;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58fb165cafed422d973d4a7156526541 != 0)
			{
				num = 3;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					aPT7tkv5fDQyIIK7fvNf(this, (object)new NStyle());
					num = 4;
					break;
				case 2:
					return;
				case 4:
					DihZ8xv5jESLoBMuAbYj(tQMA7Lv59TfNXiNSLDKm(this), SkCFH4v5Wd3evD5b8tUC());
					num = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 == 0)
					{
						num = 0;
					}
					break;
				default:
					YPpNNjv5L5opP9n5G0TZ(this, x, y);
					num = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 == 0)
					{
						num = 0;
					}
					break;
				case 3:
					((NModel)this).ScaleModel(w / 32f, h / 32f, new NPointF(0f, 0f));
					num = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 == 0)
					{
						num = 0;
					}
					break;
				}
			}
		}

		private static GraphicsPath CreatePath(float dx)
		{
			GraphicsPath graphicsPath = new GraphicsPath();
			OxEXuyv5RxEJUQGlRMry(graphicsPath, dx, 0f, dx, 32f);
			return graphicsPath;
		}

		internal static object lZj5jov5HjM39PPFrNkf(float dx)
		{
			return CreatePath(dx);
		}

		internal static void YPpNNjv5L5opP9n5G0TZ(object P_0, float P_1, float P_2)
		{
			((NTransformableElement)P_0).Translate(P_1, P_2);
		}

		internal static void aPT7tkv5fDQyIIK7fvNf(object P_0, object P_1)
		{
			((NStyleableElement)P_0).set_Style((NStyle)P_1);
		}

		internal static object tQMA7Lv59TfNXiNSLDKm(object P_0)
		{
			return ((NStyleableElement)P_0).get_Style();
		}

		internal static object SkCFH4v5Wd3evD5b8tUC()
		{
			return ShapeHelper.DefaultThickStrokeStyle;
		}

		internal static void DihZ8xv5jESLoBMuAbYj(object P_0, object P_1)
		{
			((NStyle)P_0).set_StrokeStyle((NStrokeStyle)P_1);
		}

		internal static bool Kew2Zrv5DrDVKj17lvLm()
		{
			return OBCs4Rv5ux2Uhui3ED3j == null;
		}

		internal static Line r1LCSQv5nlhvajBUFLXy()
		{
			return (Line)OBCs4Rv5ux2Uhui3ED3j;
		}

		internal static void OxEXuyv5RxEJUQGlRMry(object P_0, float P_1, float P_2, float P_3, float P_4)
		{
			((GraphicsPath)P_0).AddLine(P_1, P_2, P_3, P_4);
		}
	}

	private static MultiInstanceDecorator FOcoVeO4qX4wGOuanTFV;

	public MultiInstanceDecorator()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		pqL1RyO4QU9rFwn1Gfdg();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				ARrpLpO4p2Ey6TsGiYfD(this, 12f);
				num = 2;
				break;
			case 2:
				Height = 12f;
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b1ab9396b25b43af8f32e24b1948be96 == 0)
				{
					num = 1;
				}
				break;
			case 1:
				return;
			}
		}
	}

	protected override void CreatePaths(NRectangleF bounds)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				AddPath((NPathPrimitive)(object)new Line(16f, bounds.X, bounds.Y, bounds.Width, bounds.Height));
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b876fa7b083748c8abf8c4b192a11078 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				AddPath((NPathPrimitive)(object)new Line(4f, bounds.X, bounds.Y, bounds.Width, bounds.Height));
				num2 = 2;
				break;
			case 1:
				AddPath((NPathPrimitive)(object)new Line(28f, bounds.X, bounds.Y, bounds.Width, bounds.Height));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e9561fecdd4d49678d9f9ea7d295fb1b != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void pqL1RyO4QU9rFwn1Gfdg()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static void ARrpLpO4p2Ey6TsGiYfD(object P_0, float value)
	{
		((BaseDecorator)P_0).Width = value;
	}

	internal static bool vMtdocO43Xr7fc0nsYq3()
	{
		return FOcoVeO4qX4wGOuanTFV == null;
	}

	internal static MultiInstanceDecorator CuEwUEO4TWjhxMCPSZLI()
	{
		return FOcoVeO4qX4wGOuanTFV;
	}
}
