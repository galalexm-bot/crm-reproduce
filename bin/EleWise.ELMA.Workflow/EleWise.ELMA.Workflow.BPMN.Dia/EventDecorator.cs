using System;
using System.Drawing.Drawing2D;
using EleWise.ELMA.Workflow.Diagrams.Shapes;
using j3AmrhgkCleVTGdEwA;
using Nevron.Diagram;
using Nevron.GraphicsCore;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Decorators;

public class EventDecorator : BaseDecorator
{
	private class EventMark : NCustomPath
	{
		private static object xG3ICmvBBXbXUpynqkTv;

		public EventMark(int i, float x, float y, float w, float h)
		{
			//Discarded unreachable code: IL_0031, IL_0036
			//IL_0073: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00df: Expected O, but got Unknown
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
			((NCustomPath)this)._002Ector((GraphicsPath)zUsVusvBXwgZtDfuoe1o(i), (PathType)0);
			int num = 2;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe4a54387d744988feba4889229faf1 == 0)
			{
				num = 2;
			}
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 2:
					hcNV01vBdyZSFI3xsx4U(this, w / 32f, h / 32f, new NPointF(0f, 0f));
					num = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7de614af35034bd0a6867d08a2ee4a84 == 0)
					{
						num = 4;
					}
					break;
				case 0:
					return;
				case 4:
					((NTransformableElement)this).Translate(x, y);
					num = 3;
					break;
				case 1:
					hdEJgBvBnZ2fbb35bpAK(PlZ6XWvBuCekOSeECl0l(this), Bn83hKvBDaUg4klYMrGc());
					num = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9269d021c6f148b6a1c4afb8cee03b6c != 0)
					{
						num = 0;
					}
					break;
				case 3:
					((NStyleableElement)this).set_Style(new NStyle());
					num = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_08023922bb0e4e809e5cff73a2b04988 == 0)
					{
						num = 1;
					}
					break;
				}
			}
		}

		private static GraphicsPath CreatePath(int i)
		{
			GraphicsPath graphicsPath = new GraphicsPath();
			double num = -Math.PI / 2.0 + Math.PI * 2.0 * (double)i / 5.0;
			double num2 = -Math.PI / 2.0 + Math.PI * 2.0 * (double)(i + 1) / 5.0;
			float num3 = (float)lXBWDWvBHSt7eslMbXwB(num);
			float num4 = (float)Math.Sin(num);
			float num5 = (float)lXBWDWvBHSt7eslMbXwB(num2);
			float num6 = (float)Math.Sin(num2);
			float x = 16f + 16f * num3;
			float y = 16f + 16f * num4;
			float x2 = 16f + 16f * num5;
			float y2 = 16f + 16f * num6;
			graphicsPath.AddLine(x, y, x2, y2);
			return graphicsPath;
		}

		internal static object zUsVusvBXwgZtDfuoe1o(int i)
		{
			return CreatePath(i);
		}

		internal static void hcNV01vBdyZSFI3xsx4U(object P_0, float P_1, float P_2, NPointF P_3)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			((NModel)P_0).ScaleModel(P_1, P_2, P_3);
		}

		internal static object PlZ6XWvBuCekOSeECl0l(object P_0)
		{
			return ((NStyleableElement)P_0).get_Style();
		}

		internal static object Bn83hKvBDaUg4klYMrGc()
		{
			return ShapeHelper.DefaultThinStrokeStyle;
		}

		internal static void hdEJgBvBnZ2fbb35bpAK(object P_0, object P_1)
		{
			((NStyle)P_0).set_StrokeStyle((NStrokeStyle)P_1);
		}

		internal static bool BrKPHEvBcxHmky3qDgru()
		{
			return xG3ICmvBBXbXUpynqkTv == null;
		}

		internal static EventMark Vdul7WvBPJuf2yvMcJn6()
		{
			return (EventMark)xG3ICmvBBXbXUpynqkTv;
		}

		internal static double lXBWDWvBHSt7eslMbXwB(double P_0)
		{
			return Math.Cos(P_0);
		}
	}

	private static EventDecorator pkHpgPOzTXg8dY4xDJTr;

	public EventDecorator()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		CSUJ3rOzCBuOHj68RfPV();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e9561fecdd4d49678d9f9ea7d295fb1b == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				KiEJEiOzk8p2qGMAGRMw(this, 16f);
				num = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9570b4a70465495fba22c942f586465a == 0)
				{
					num = 2;
				}
				break;
			case 1:
				QEG6yROzMFcTysDEZTr6(this, 16f);
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd == 0)
				{
					num = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	protected override void CreatePaths(NRectangleF bounds)
	{
		//Discarded unreachable code: IL_00d8, IL_00e7
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		int num = 2;
		int num2 = num;
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 3:
				AddPath((NPathPrimitive)(object)new EventMark(num3, bounds.X, bounds.Y, bounds.Width, bounds.Height));
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f != 0)
				{
					num2 = 4;
				}
				break;
			case 4:
				num3++;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				return;
			case 2:
				num3 = 0;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eef7d2ca1c3c4b74aeb81172ed542639 != 0)
				{
					num2 = 1;
				}
				break;
			default:
				if (num3 >= 5)
				{
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 != 0)
					{
						num2 = 5;
					}
					break;
				}
				goto case 3;
			}
		}
	}

	internal static void CSUJ3rOzCBuOHj68RfPV()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static void QEG6yROzMFcTysDEZTr6(object P_0, float value)
	{
		((BaseDecorator)P_0).Width = value;
	}

	internal static void KiEJEiOzk8p2qGMAGRMw(object P_0, float value)
	{
		((BaseDecorator)P_0).Height = value;
	}

	internal static bool VwluZuOzQe3W8AQ4XgAw()
	{
		return pkHpgPOzTXg8dY4xDJTr == null;
	}

	internal static EventDecorator ycaDJ7OzpT7xqNAeFXuF()
	{
		return pkHpgPOzTXg8dY4xDJTr;
	}
}
