using System.Drawing;
using System.Drawing.Drawing2D;
using EleWise.ELMA.Workflow.Diagrams.Shapes;
using j3AmrhgkCleVTGdEwA;
using Nevron.Diagram;
using Nevron.GraphicsCore;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Decorators;

public class ErrorCatchDecorator : BaseDecorator
{
	private class Border : NCustomPath
	{
		private static object Qw2487vmakLjj1QgmPMF;

		public Border(float x, float y, float w, float h, PathType pathType, NFillStyle fillStyle)
		{
			//Discarded unreachable code: IL_0031, IL_0036
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Expected O, but got Unknown
			//IL_009c: Unknown result type (might be due to invalid IL or missing references)
			SD8R2ovmN8DWQGrOSK5Q();
			((NCustomPath)this)._002Ector((GraphicsPath)ngdkylvmxLcdIIDFf5l8(), pathType);
			int num = 5;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_26fa47f5bd8343debcae8b05a56a3ab5 == 0)
			{
				num = 5;
			}
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 4:
					((NStyleableElement)this).set_Style(new NStyle());
					num = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3ab79470996d472f815915b21f45aac1 != 0)
					{
						num = 1;
					}
					break;
				case 0:
					return;
				case 5:
					((NModel)this).ScaleModel(w / 32f, h / 32f, new NPointF(0f, 0f));
					num = 3;
					break;
				case 1:
					dGQRBuvmEFqZsW2QjoZU(GBSf1Yvm1NXaCee1Fqw4(this), JowEEWvmhjOGZPIyrMx4());
					num = 2;
					break;
				case 2:
					x2SD0UvmwslhevooPs0w(GBSf1Yvm1NXaCee1Fqw4(this), fillStyle);
					num = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_abfb511163674a3eae959fd60da8f319 != 0)
					{
						num = 0;
					}
					break;
				case 3:
					Wf09nJvmSmbqKlCu61JS(this, x, y);
					num = 4;
					break;
				}
			}
		}

		private static GraphicsPath CreatePath()
		{
			int num = 1;
			int num2 = num;
			GraphicsPath graphicsPath = default(GraphicsPath);
			while (true)
			{
				switch (num2)
				{
				case 2:
					return graphicsPath;
				case 1:
					graphicsPath = new GraphicsPath();
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_558b46b4f4364838b08ac89d77f9a257 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				J9bWTxvm4gkcppFhMbvv(graphicsPath, new PointF[7]
				{
					new PointF(0f, 30f),
					new PointF(9f, 3f),
					new PointF(19f, 14f),
					new PointF(31f, 1f),
					new PointF(22f, 28f),
					new PointF(12f, 17f),
					new PointF(0f, 30f)
				});
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a == 0)
				{
					num2 = 2;
				}
			}
		}

		internal static void SD8R2ovmN8DWQGrOSK5Q()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}

		internal static object ngdkylvmxLcdIIDFf5l8()
		{
			return CreatePath();
		}

		internal static void Wf09nJvmSmbqKlCu61JS(object P_0, float P_1, float P_2)
		{
			((NTransformableElement)P_0).Translate(P_1, P_2);
		}

		internal static object GBSf1Yvm1NXaCee1Fqw4(object P_0)
		{
			return ((NStyleableElement)P_0).get_Style();
		}

		internal static object JowEEWvmhjOGZPIyrMx4()
		{
			return ShapeHelper.DefaultThinStrokeStyle;
		}

		internal static void dGQRBuvmEFqZsW2QjoZU(object P_0, object P_1)
		{
			((NStyle)P_0).set_StrokeStyle((NStrokeStyle)P_1);
		}

		internal static void x2SD0UvmwslhevooPs0w(object P_0, object P_1)
		{
			((NStyle)P_0).set_FillStyle((NFillStyle)P_1);
		}

		internal static bool uIm8EqvmrV0juhaymCcA()
		{
			return Qw2487vmakLjj1QgmPMF == null;
		}

		internal static Border qV7kbZvmeY5HOSepLU1f()
		{
			return (Border)Qw2487vmakLjj1QgmPMF;
		}

		internal static void J9bWTxvm4gkcppFhMbvv(object P_0, object P_1)
		{
			((GraphicsPath)P_0).AddLines((PointF[])P_1);
		}
	}

	internal static ErrorCatchDecorator KsIJnkOwiIh9fufZ82L8;

	protected virtual PathType PathType => (PathType)0;

	protected virtual NFillStyle FillStyle => null;

	public ErrorCatchDecorator()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		qAecl8OwrgvKOPKmgi0c();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a == 0)
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
				Height = 16f;
				num = 2;
				continue;
			}
			GkQ0KMOweGrRmyC03qsi(this, 16f);
			num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ecf910d183864897a7c8ec77e01689a4 != 0)
			{
				num = 1;
			}
		}
	}

	protected override void CreatePaths(NRectangleF bounds)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
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
				AddPath((NPathPrimitive)(object)new Border(bounds.X, bounds.Y, bounds.Width, bounds.Height, tMpdfPOwN0TYa4sNsCZH(this), (NFillStyle)J1EkeMOwxuf9UdUo9cvo(this)));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b84ccb8b1bd147ef900b852047ecbf45 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void qAecl8OwrgvKOPKmgi0c()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static void GkQ0KMOweGrRmyC03qsi(object P_0, float value)
	{
		((BaseDecorator)P_0).Width = value;
	}

	internal static bool S5AfXiOwIIG4ITesqUfk()
	{
		return KsIJnkOwiIh9fufZ82L8 == null;
	}

	internal static ErrorCatchDecorator Dnq3DuOwaosGuiEtNO0K()
	{
		return KsIJnkOwiIh9fufZ82L8;
	}

	internal static PathType tMpdfPOwN0TYa4sNsCZH(object P_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((ErrorCatchDecorator)P_0).PathType;
	}

	internal static object J1EkeMOwxuf9UdUo9cvo(object P_0)
	{
		return ((ErrorCatchDecorator)P_0).FillStyle;
	}
}
