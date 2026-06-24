using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using EleWise.ELMA.Workflow.Diagrams.Shapes;
using j3AmrhgkCleVTGdEwA;
using Nevron.Diagram;
using Nevron.GraphicsCore;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Decorators;

[Serializable]
public class UserTaskDecorator : BaseDecorator
{
	private class Border : NCustomPath
	{
		internal static object QICVINvBhYeOu45snqRP;

		public Border(float x, float y, float w, float h)
		{
			//Discarded unreachable code: IL_0020
			//IL_0093: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bd: Expected O, but got Unknown
			//IL_00db: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e5: Expected O, but got Unknown
			//IL_0112: Unknown result type (might be due to invalid IL or missing references)
			//IL_011c: Expected O, but got Unknown
			utCb1rvB4CCKBTYNbJxY();
			((NCustomPath)this)._002Ector(CreatePath(), (PathType)1);
			int num = 4;
			while (true)
			{
				switch (num)
				{
				case 6:
					xnJDOlvcZLKqqdZydCRp(((NStyleableElement)this).get_Style(), ShapeHelper.DefaultThinStrokeStyle);
					num = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 != 0)
					{
						num = 0;
					}
					break;
				case 4:
					QGtKY3vBzuE7AtwHwTVF(this, w / 24f, h / 24f, new NPointF(0f, 0f));
					num = 2;
					break;
				case 5:
					return;
				case 1:
				{
					KiKNiqvc8nJXt4TXhLO2(((NStyleableElement)this).get_Style(), (object)new NColorFillStyle(uhcq8LvcYQJw9RlCn5No()));
					int num2 = 5;
					num = num2;
					break;
				}
				default:
					xnJDOlvcZLKqqdZydCRp(((NStyleableElement)this).get_Style(), (object)new NStrokeStyle(Jq1dJivcvSlCO9GWKy7Q(), uhcq8LvcYQJw9RlCn5No()));
					num = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 != 0)
					{
						num = 1;
					}
					break;
				case 2:
					vq2dWWvcKPv7T8cKClgH(this, x, y);
					num = 3;
					break;
				case 3:
					OWR2j5vcO3RYmmBjogcp(this, (object)new NStyle());
					num = 6;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae4e393cddc4c98b9896b25c9e18c7d != 0)
					{
						num = 0;
					}
					break;
				}
			}
		}

		private static GraphicsPath CreatePath()
		{
			GraphicsPath graphicsPath = new GraphicsPath();
			cwiHvIvcsKFirb3AP2QH(graphicsPath, 0f, 22f, 0f, 18f);
			graphicsPath.AddArc(0f, 13f, 12f, 12f, 180f, 90f);
			iuP74LvcJXfwhHCuCeUD(graphicsPath, 4.5f, 1f, 11f, 13f, 135f, 270f);
			iuP74LvcJXfwhHCuCeUD(graphicsPath, 8f, 13f, 12f, 12f, 270f, 90f);
			cwiHvIvcsKFirb3AP2QH(graphicsPath, 20f, 18f, 20f, 22f);
			R3PqFQvcl7mTDXfWqwwY(graphicsPath);
			return graphicsPath;
		}

		internal static void utCb1rvB4CCKBTYNbJxY()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}

		internal static void QGtKY3vBzuE7AtwHwTVF(object P_0, float P_1, float P_2, NPointF P_3)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			((NModel)P_0).ScaleModel(P_1, P_2, P_3);
		}

		internal static void vq2dWWvcKPv7T8cKClgH(object P_0, float P_1, float P_2)
		{
			((NTransformableElement)P_0).Translate(P_1, P_2);
		}

		internal static void OWR2j5vcO3RYmmBjogcp(object P_0, object P_1)
		{
			((NStyleableElement)P_0).set_Style((NStyle)P_1);
		}

		internal static void xnJDOlvcZLKqqdZydCRp(object P_0, object P_1)
		{
			((NStyle)P_0).set_StrokeStyle((NStrokeStyle)P_1);
		}

		internal static float Jq1dJivcvSlCO9GWKy7Q()
		{
			return StrokeWidth;
		}

		internal static Color uhcq8LvcYQJw9RlCn5No()
		{
			return StrokeColor;
		}

		internal static void KiKNiqvc8nJXt4TXhLO2(object P_0, object P_1)
		{
			((NStyle)P_0).set_FillStyle((NFillStyle)P_1);
		}

		internal static bool Q0pVOovBEueHkvGM1lxU()
		{
			return QICVINvBhYeOu45snqRP == null;
		}

		internal static Border meZoIsvBwTqZain2M5eM()
		{
			return (Border)QICVINvBhYeOu45snqRP;
		}

		internal static void cwiHvIvcsKFirb3AP2QH(object P_0, float P_1, float P_2, float P_3, float P_4)
		{
			((GraphicsPath)P_0).AddLine(P_1, P_2, P_3, P_4);
		}

		internal static void iuP74LvcJXfwhHCuCeUD(object P_0, float P_1, float P_2, float P_3, float P_4, float P_5, float P_6)
		{
			((GraphicsPath)P_0).AddArc(P_1, P_2, P_3, P_4, P_5, P_6);
		}

		internal static void R3PqFQvcl7mTDXfWqwwY(object P_0)
		{
			((GraphicsPath)P_0).CloseAllFigures();
		}
	}

	internal static UserTaskDecorator b6iVU0Oz2duPDDrs9YV1;

	protected static Color StrokeColor => Color.FromArgb(98, 100, 101);

	protected static Color StartColor => Color.FromArgb(222, 227, 231);

	protected static float StrokeWidth => 0.1f;

	public UserTaskDecorator()
	{
		//Discarded unreachable code: IL_002a
		uQIfHHOziNHAyfDa4Z1s();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e4c570270f54493d8f3f4763a72f63f7 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				Obu9SaOza1jH67xufslA(this, 16f);
				num = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ffb1346d351f436b84bb1e9954c3bfa8 != 0)
				{
					num = 0;
				}
				break;
			case 1:
				return;
			default:
			{
				kMkFfAOzIyhg21iLlPWF(this, 19f);
				int num2 = 2;
				num = num2;
				break;
			}
			}
		}
	}

	protected override void CreatePaths(NRectangleF bounds)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				AddPath((NPathPrimitive)(object)new Border(bounds.X, bounds.Y, bounds.Width, bounds.Height));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b1ab9396b25b43af8f32e24b1948be96 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static void uQIfHHOziNHAyfDa4Z1s()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static void kMkFfAOzIyhg21iLlPWF(object P_0, float value)
	{
		((BaseDecorator)P_0).Width = value;
	}

	internal static void Obu9SaOza1jH67xufslA(object P_0, float value)
	{
		((BaseDecorator)P_0).Height = value;
	}

	internal static bool cVFGKyOzoHr4XtQgdjVr()
	{
		return b6iVU0Oz2duPDDrs9YV1 == null;
	}

	internal static UserTaskDecorator skZOK5OzFxsufAbcIutu()
	{
		return b6iVU0Oz2duPDDrs9YV1;
	}
}
