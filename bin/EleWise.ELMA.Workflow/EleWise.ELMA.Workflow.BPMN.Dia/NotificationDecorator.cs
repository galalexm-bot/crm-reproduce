using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using EleWise.ELMA.Workflow.Diagrams.Shapes;
using j3AmrhgkCleVTGdEwA;
using Nevron.Diagram;
using Nevron.GraphicsCore;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Decorators;

[Serializable]
public class NotificationDecorator : BaseDecorator
{
	private class Border : NCustomPath
	{
		internal static object A6YCvav56ITB35YZAbGD;

		public Border(float x, float y, float w, float h)
		{
			//Discarded unreachable code: IL_0020, IL_0025
			//IL_006a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Expected O, but got Unknown
			//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e6: Expected O, but got Unknown
			//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0106: Expected O, but got Unknown
			jvtcMXv5TiRA2tZYx880();
			((NCustomPath)this)._002Ector(CreatePath(), (PathType)1);
			int num = 3;
			while (true)
			{
				switch (num)
				{
				case 2:
					KcuqYRv5MIZSIAKZlQoR(A2Vl5Rv5CpqyocOHnMd8(this), ShapeHelper.DefaultThinStrokeStyle);
					num = 5;
					break;
				case 6:
					((NStyleableElement)this).set_Style(new NStyle());
					num = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_160bffb148c14c5da92d8d6ddf481bdc != 0)
					{
						num = 0;
					}
					break;
				case 3:
					oDOrjYv5QCZyFAooi4q2(this, w / 32f, h / 32f, new NPointF(0f, 0f));
					num = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1b8b735647da470aa2d45d64d6f538d1 != 0)
					{
						num = 0;
					}
					break;
				case 5:
					KcuqYRv5MIZSIAKZlQoR(A2Vl5Rv5CpqyocOHnMd8(this), (object)new NStrokeStyle(p9Gqswv5klkXpiupJk2s(), MSAI7Sv5UbR6hxoBbryh()));
					num = 4;
					break;
				case 1:
					return;
				case 4:
					((NStyle)A2Vl5Rv5CpqyocOHnMd8(this)).set_FillStyle((NFillStyle)new NColorFillStyle(StrokeColor));
					num = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3b4403f77a00495e957e5e4a6840e5d3 == 0)
					{
						num = 1;
					}
					break;
				default:
					n9D0ehv5pOl2YUEoQtSn(this, x, y);
					num = 6;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e9561fecdd4d49678d9f9ea7d295fb1b != 0)
					{
						num = 3;
					}
					break;
				}
			}
		}

		private static GraphicsPath CreatePath()
		{
			int num = 2;
			int num2 = num;
			GraphicsPath graphicsPath = default(GraphicsPath);
			while (true)
			{
				switch (num2)
				{
				default:
					return graphicsPath;
				case 1:
					kTP5tmv5V6I7G3epmr1d(graphicsPath, new PointF[11]
					{
						new PointF(0f, 4f),
						new PointF(3f, 1f),
						new PointF(28f, 1f),
						new PointF(31f, 4f),
						new PointF(31f, 18f),
						new PointF(28f, 21f),
						new PointF(20f, 21f),
						new PointF(20f, 30f),
						new PointF(11f, 21f),
						new PointF(3f, 21f),
						new PointF(0f, 18f)
					});
					num2 = 3;
					break;
				case 3:
					P27CLOv5AFk3UonVsxXI(graphicsPath);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5537a063960e465db83a04e35eea441b != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					graphicsPath = new GraphicsPath();
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a == 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}

		internal static void jvtcMXv5TiRA2tZYx880()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}

		internal static void oDOrjYv5QCZyFAooi4q2(object P_0, float P_1, float P_2, NPointF P_3)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			((NModel)P_0).ScaleModel(P_1, P_2, P_3);
		}

		internal static void n9D0ehv5pOl2YUEoQtSn(object P_0, float P_1, float P_2)
		{
			((NTransformableElement)P_0).Translate(P_1, P_2);
		}

		internal static object A2Vl5Rv5CpqyocOHnMd8(object P_0)
		{
			return ((NStyleableElement)P_0).get_Style();
		}

		internal static void KcuqYRv5MIZSIAKZlQoR(object P_0, object P_1)
		{
			((NStyle)P_0).set_StrokeStyle((NStrokeStyle)P_1);
		}

		internal static float p9Gqswv5klkXpiupJk2s()
		{
			return StrokeWidth;
		}

		internal static Color MSAI7Sv5UbR6hxoBbryh()
		{
			return StrokeColor;
		}

		internal static bool OlglVrv5qUUNjM3Z1pWq()
		{
			return A6YCvav56ITB35YZAbGD == null;
		}

		internal static Border U8rLiKv53c1yA06wxLvY()
		{
			return (Border)A6YCvav56ITB35YZAbGD;
		}

		internal static void kTP5tmv5V6I7G3epmr1d(object P_0, object P_1)
		{
			((GraphicsPath)P_0).AddLines((PointF[])P_1);
		}

		internal static void P27CLOv5AFk3UonVsxXI(object P_0)
		{
			((GraphicsPath)P_0).CloseAllFigures();
		}
	}

	private class ExclamationLine : NCustomPath
	{
		internal static object mjhXrLv5GovkUal86Yab;

		public ExclamationLine(float x, float y, float w, float h)
		{
			//Discarded unreachable code: IL_0020, IL_0025
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Expected O, but got Unknown
			//IL_0092: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dd: Expected O, but got Unknown
			//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fc: Expected O, but got Unknown
			//IL_0150: Unknown result type (might be due to invalid IL or missing references)
			//IL_015a: Expected O, but got Unknown
			Ky99VAv5ooVHFnxH8uAm();
			((NCustomPath)this)._002Ector((GraphicsPath)LNtGpYv5FZD1iLZUZ03N(), (PathType)1);
			int num = 2;
			while (true)
			{
				switch (num)
				{
				case 1:
					zGQYWav5aNe2RWN9GvQW(this, (object)new NStyle());
					num = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a != 0)
					{
						num = 3;
					}
					break;
				case 2:
					RNVN3Av5iCrwCcEuVBH1(this, w / 32f, h / 32f, new NPointF(0f, 0f));
					num = 5;
					break;
				case 5:
					d21oGsv5IfRh3o4Jtn5k(this, x, y);
					num = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1b8b735647da470aa2d45d64d6f538d1 != 0)
					{
						num = 1;
					}
					break;
				case 4:
					EmBIjlv5xuyasqSjRP0s(wsYZGEv5rrRIXgq1tG4k(this), (object)new NColorFillStyle(BBtKyNv51FPLn6ac7MB2()));
					num = 6;
					break;
				default:
					EmBIjlv5xuyasqSjRP0s(wsYZGEv5rrRIXgq1tG4k(this), (object)new NColorFillStyle(ShapeHelper.DefaultStrokeColor));
					num = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_60c5782a184b457aa78da2e5c62d4e27 == 0)
					{
						num = 7;
					}
					break;
				case 3:
					KrTF5Bv5N7ZKybFdH5TE(wsYZGEv5rrRIXgq1tG4k(this), qsSvjyv5e3uglgohiXgM());
					num = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4cc62744d0eb4cd68219b70dcad3e68e == 0)
					{
						num = 0;
					}
					break;
				case 7:
					KrTF5Bv5N7ZKybFdH5TE(wsYZGEv5rrRIXgq1tG4k(this), (object)new NStrokeStyle(n3mhnTv5Sis9H0HcaVuH(), BBtKyNv51FPLn6ac7MB2()));
					num = 4;
					break;
				case 6:
					return;
				}
			}
		}

		private static GraphicsPath CreatePath()
		{
			int num = 2;
			int num2 = num;
			GraphicsPath graphicsPath = default(GraphicsPath);
			while (true)
			{
				switch (num2)
				{
				case 2:
					graphicsPath = new GraphicsPath();
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 == 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					graphicsPath.AddLines(new PointF[4]
					{
						new PointF(14f, 13f),
						new PointF(13f, 4f),
						new PointF(17f, 4f),
						new PointF(16f, 13f)
					});
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_dcdfd019631e458b9cb5fa34a16a2fe1 != 0)
					{
						num2 = 0;
					}
					break;
				default:
					return graphicsPath;
				}
			}
		}

		internal static void Ky99VAv5ooVHFnxH8uAm()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}

		internal static object LNtGpYv5FZD1iLZUZ03N()
		{
			return CreatePath();
		}

		internal static void RNVN3Av5iCrwCcEuVBH1(object P_0, float P_1, float P_2, NPointF P_3)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			((NModel)P_0).ScaleModel(P_1, P_2, P_3);
		}

		internal static void d21oGsv5IfRh3o4Jtn5k(object P_0, float P_1, float P_2)
		{
			((NTransformableElement)P_0).Translate(P_1, P_2);
		}

		internal static void zGQYWav5aNe2RWN9GvQW(object P_0, object P_1)
		{
			((NStyleableElement)P_0).set_Style((NStyle)P_1);
		}

		internal static object wsYZGEv5rrRIXgq1tG4k(object P_0)
		{
			return ((NStyleableElement)P_0).get_Style();
		}

		internal static object qsSvjyv5e3uglgohiXgM()
		{
			return ShapeHelper.DefaultThinStrokeStyle;
		}

		internal static void KrTF5Bv5N7ZKybFdH5TE(object P_0, object P_1)
		{
			((NStyle)P_0).set_StrokeStyle((NStrokeStyle)P_1);
		}

		internal static void EmBIjlv5xuyasqSjRP0s(object P_0, object P_1)
		{
			((NStyle)P_0).set_FillStyle((NFillStyle)P_1);
		}

		internal static float n3mhnTv5Sis9H0HcaVuH()
		{
			return StrokeWidth;
		}

		internal static Color BBtKyNv51FPLn6ac7MB2()
		{
			return StartColor;
		}

		internal static bool cPJPXNv57LW72dn9ClD2()
		{
			return mjhXrLv5GovkUal86Yab == null;
		}

		internal static ExclamationLine UOmJYwv521KugHtc3Vxa()
		{
			return (ExclamationLine)mjhXrLv5GovkUal86Yab;
		}
	}

	private class ExclamationPoint : NCustomPath
	{
		internal static object k5SdZBv5hM6yjZE1D9RB;

		public ExclamationPoint(float x, float y, float w, float h)
		{
			//Discarded unreachable code: IL_0030, IL_0035
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0078: Expected O, but got Unknown
			//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00da: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e4: Expected O, but got Unknown
			//IL_0118: Unknown result type (might be due to invalid IL or missing references)
			//IL_0137: Unknown result type (might be due to invalid IL or missing references)
			//IL_0141: Expected O, but got Unknown
			mpTMMCv54m3GS8kNiCww();
			((NCustomPath)this)._002Ector(CreatePath(), (PathType)1);
			int num = 2;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 == 0)
			{
				num = 2;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					X21BnSvgsFjAH7byLnqd(H1oS99vgZbdRXE7Vvb9w(this), (object)new NColorFillStyle(bUJLORvg8BQ0FJxrVCbU()));
					num = 6;
					break;
				case 3:
					BF16wMvgKPXR6JjGbFSs(this, x, y);
					num = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f508947b0d94af1961e5aa17a8a2044 != 0)
					{
						num = 0;
					}
					break;
				default:
					t7TD2nvgOk1glyJ6E6dH(this, (object)new NStyle());
					num = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_160bffb148c14c5da92d8d6ddf481bdc != 0)
					{
						num = 4;
					}
					break;
				case 6:
					return;
				case 7:
					SxegYqvgvngXsaUOLmOU(((NStyleableElement)this).get_Style(), (object)new NStrokeStyle(pDh7atvgY30CBvUbpffn(), bUJLORvg8BQ0FJxrVCbU()));
					num = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1c37d4e24e094858975336738e156495 == 0)
					{
						num = 0;
					}
					break;
				case 2:
					wi6RfIv5zRH0t4UyDfRy(this, w / 32f, h / 32f, new NPointF(0f, 0f));
					num = 3;
					break;
				case 4:
					((NStyleableElement)this).get_Style().set_FillStyle((NFillStyle)new NColorFillStyle(ShapeHelper.DefaultStrokeColor));
					num = 7;
					break;
				case 5:
					SxegYqvgvngXsaUOLmOU(H1oS99vgZbdRXE7Vvb9w(this), ShapeHelper.DefaultThinStrokeStyle);
					num = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3bb28bf622874b4689f9265e58d14823 != 0)
					{
						num = 1;
					}
					break;
				}
			}
		}

		private static GraphicsPath CreatePath()
		{
			GraphicsPath graphicsPath = new GraphicsPath();
			SduRvnvgJJb9bnUq56rf(graphicsPath, 14, 16, 2, 2);
			return graphicsPath;
		}

		internal static void mpTMMCv54m3GS8kNiCww()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}

		internal static void wi6RfIv5zRH0t4UyDfRy(object P_0, float P_1, float P_2, NPointF P_3)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			((NModel)P_0).ScaleModel(P_1, P_2, P_3);
		}

		internal static void BF16wMvgKPXR6JjGbFSs(object P_0, float P_1, float P_2)
		{
			((NTransformableElement)P_0).Translate(P_1, P_2);
		}

		internal static void t7TD2nvgOk1glyJ6E6dH(object P_0, object P_1)
		{
			((NStyleableElement)P_0).set_Style((NStyle)P_1);
		}

		internal static object H1oS99vgZbdRXE7Vvb9w(object P_0)
		{
			return ((NStyleableElement)P_0).get_Style();
		}

		internal static void SxegYqvgvngXsaUOLmOU(object P_0, object P_1)
		{
			((NStyle)P_0).set_StrokeStyle((NStrokeStyle)P_1);
		}

		internal static float pDh7atvgY30CBvUbpffn()
		{
			return StrokeWidth;
		}

		internal static Color bUJLORvg8BQ0FJxrVCbU()
		{
			return StartColor;
		}

		internal static void X21BnSvgsFjAH7byLnqd(object P_0, object P_1)
		{
			((NStyle)P_0).set_FillStyle((NFillStyle)P_1);
		}

		internal static bool cvm39Ev5EDgdEdVrvaXV()
		{
			return k5SdZBv5hM6yjZE1D9RB == null;
		}

		internal static ExclamationPoint wTXrLlv5w8SFIq8OOoE3()
		{
			return (ExclamationPoint)k5SdZBv5hM6yjZE1D9RB;
		}

		internal static void SduRvnvgJJb9bnUq56rf(object P_0, int P_1, int P_2, int P_3, int P_4)
		{
			((GraphicsPath)P_0).AddEllipse(P_1, P_2, P_3, P_4);
		}
	}

	internal static NotificationDecorator mLO8GGO4CKJp5XnytCQs;

	protected static Color StrokeColor => Color.FromArgb(205, 194, 49);

	protected static Color StartColor => GoGbcZO4AtBvqWWXwwYn(255, 255, 134);

	protected static float StrokeWidth => 1f;

	public NotificationDecorator()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		g07CXLO4UAeqWpHPJnd7();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				QjIPQJO4VbrCdqX5UFST(this, 16f);
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_938c6be4ea2248868d7ed5d0e3346006 != 0)
				{
					num = 0;
				}
				break;
			case 2:
				return;
			default:
				Height = 16f;
				num = 2;
				break;
			}
		}
	}

	protected override void CreatePaths(NRectangleF bounds)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		int num = 3;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					AddPath((NPathPrimitive)(object)new ExclamationLine(bounds.X, bounds.Y, bounds.Width, bounds.Height));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_32f3e755437f4eacb85c8a0d536f83ea == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					break;
				default:
					AddPath((NPathPrimitive)(object)new ExclamationPoint(bounds.X, bounds.Y, bounds.Width, bounds.Height));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 != 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					return;
				}
				break;
			}
			AddPath((NPathPrimitive)(object)new Border(bounds.X, bounds.Y, bounds.Width, bounds.Height));
			num = 2;
		}
	}

	internal static void g07CXLO4UAeqWpHPJnd7()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static void QjIPQJO4VbrCdqX5UFST(object P_0, float value)
	{
		((BaseDecorator)P_0).Width = value;
	}

	internal static bool U2nNW9O4MxMnwBhBbuel()
	{
		return mLO8GGO4CKJp5XnytCQs == null;
	}

	internal static NotificationDecorator odUuljO4kUIR0DWaH0ml()
	{
		return mLO8GGO4CKJp5XnytCQs;
	}

	internal static Color GoGbcZO4AtBvqWWXwwYn(int P_0, int P_1, int P_2)
	{
		return Color.FromArgb(P_0, P_1, P_2);
	}
}
