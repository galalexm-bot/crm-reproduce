using System.Drawing;
using System.Drawing.Drawing2D;
using EleWise.ELMA.Workflow.Diagrams.Shapes;
using j3AmrhgkCleVTGdEwA;
using Nevron.Diagram;
using Nevron.GraphicsCore;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Decorators;

public class SubProcessDecorator : BaseDecorator
{
	private class Border : NCustomPath
	{
		private static object CPxdScvg3YLdAhTvRiZf;

		public Border(float x, float y, float w, float h)
		{
			//Discarded unreachable code: IL_0030, IL_0035
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0107: Expected O, but got Unknown
			//IL_013e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0148: Expected O, but got Unknown
			jutNsfvgp2TN9xHOkaQf();
			((NCustomPath)this)._002Ector((GraphicsPath)X9Hls7vgCgh5hsaqHXUY(), (PathType)1);
			int num = 3;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2f119e188994b55be2499c193b880fb != 0)
			{
				num = 4;
			}
			while (true)
			{
				switch (num)
				{
				case 4:
					((NModel)this).ScaleModel(w / 32f, h / 32f, new NPointF(0f, 0f));
					num = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae4e393cddc4c98b9896b25c9e18c7d == 0)
					{
						num = 5;
					}
					break;
				case 6:
					dWJHGEvgM7aHMyElxoJ3(this, (object)new NStyle());
					num = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 == 0)
					{
						num = 0;
					}
					break;
				default:
					MjqgouvgVb1dakJg9MCM(XelcyWvgkeG69i3g8xxf(this), yrpKy1vgUO8fV50rrdbK());
					num = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58fb165cafed422d973d4a7156526541 == 0)
					{
						num = 1;
					}
					break;
				case 3:
					return;
				case 2:
					MjqgouvgVb1dakJg9MCM(XelcyWvgkeG69i3g8xxf(this), (object)new NStrokeStyle(xlrAf7vgGXPOI5V3Ot1n(), StrokeColor));
					num = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d == 0)
					{
						num = 3;
					}
					break;
				case 5:
					((NTransformableElement)this).Translate(x, y);
					num = 6;
					break;
				case 1:
					((NStyle)XelcyWvgkeG69i3g8xxf(this)).set_FillStyle((NFillStyle)new NColorFillStyle(hSNdxIvgAZkdhScHWW0Q()));
					num = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_db8eb3e90ad546d4b05544ab6326a49f != 0)
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
			RUZFIYvg7DtQXKZsJJh2(graphicsPath, new RectangleF(0f, 0f, 32f, 32f));
			return graphicsPath;
		}

		internal static void jutNsfvgp2TN9xHOkaQf()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}

		internal static object X9Hls7vgCgh5hsaqHXUY()
		{
			return CreatePath();
		}

		internal static void dWJHGEvgM7aHMyElxoJ3(object P_0, object P_1)
		{
			((NStyleableElement)P_0).set_Style((NStyle)P_1);
		}

		internal static object XelcyWvgkeG69i3g8xxf(object P_0)
		{
			return ((NStyleableElement)P_0).get_Style();
		}

		internal static object yrpKy1vgUO8fV50rrdbK()
		{
			return ShapeHelper.DefaultThickStrokeStyle;
		}

		internal static void MjqgouvgVb1dakJg9MCM(object P_0, object P_1)
		{
			((NStyle)P_0).set_StrokeStyle((NStrokeStyle)P_1);
		}

		internal static Color hSNdxIvgAZkdhScHWW0Q()
		{
			return StrokeColor;
		}

		internal static float xlrAf7vgGXPOI5V3Ot1n()
		{
			return StrokeWidth;
		}

		internal static bool MOZlKYvgTUdBn1FQ2lYi()
		{
			return CPxdScvg3YLdAhTvRiZf == null;
		}

		internal static Border RKYxblvgQNfYWJ4C08MS()
		{
			return (Border)CPxdScvg3YLdAhTvRiZf;
		}

		internal static void RUZFIYvg7DtQXKZsJJh2(object P_0, RectangleF P_1)
		{
			((GraphicsPath)P_0).AddRectangle(P_1);
		}
	}

	private class PlusH : NCustomPath
	{
		internal static object ts8pCLvg29GuX8mMcamN;

		public PlusH(float x, float y, float w, float h)
		{
			//Discarded unreachable code: IL_0020, IL_0025
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			//IL_0080: Expected O, but got Unknown
			//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0105: Expected O, but got Unknown
			NAhnrpvgiXevSjwP0gDo();
			((NCustomPath)this)._002Ector((GraphicsPath)NAZJNlvgIhZM2LpgGTWt(), (PathType)0);
			int num = 3;
			while (true)
			{
				switch (num)
				{
				case 4:
					Vva1A7vgepPd4mCLOcPB(((NStyleableElement)this).get_Style(), ShapeHelper.DefaultThickStrokeStyle);
					num = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 == 0)
					{
						num = 0;
					}
					break;
				case 2:
					YqLHnOvgrXW4ZxvZanrj(this, (object)new NStyle());
					num = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f453500aaab143479696408f48a03c17 != 0)
					{
						num = 1;
					}
					break;
				case 1:
					return;
				case 5:
					((NTransformableElement)this).Translate(x, y);
					num = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7ed81ca3cf804abbade4684f28f485d1 != 0)
					{
						num = 1;
					}
					break;
				case 3:
					yJQwKpvgaOrgEYuTa3t5(this, w / 32f, h / 32f, new NPointF(0f, 0f));
					num = 5;
					break;
				default:
					Vva1A7vgepPd4mCLOcPB(RWnXYJvgNIXmWxkq5OOd(this), (object)new NStrokeStyle(HbAM2VvgxOPS4NFiggiI(), wcOOWxvgS2fT4veyitsW()));
					num = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_558b46b4f4364838b08ac89d77f9a257 != 0)
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
			JaPO6Vvg1h5Y6M4qutRe(graphicsPath, 4, 16, 28, 16);
			return graphicsPath;
		}

		internal static void NAhnrpvgiXevSjwP0gDo()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}

		internal static object NAZJNlvgIhZM2LpgGTWt()
		{
			return CreatePath();
		}

		internal static void yJQwKpvgaOrgEYuTa3t5(object P_0, float P_1, float P_2, NPointF P_3)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			((NModel)P_0).ScaleModel(P_1, P_2, P_3);
		}

		internal static void YqLHnOvgrXW4ZxvZanrj(object P_0, object P_1)
		{
			((NStyleableElement)P_0).set_Style((NStyle)P_1);
		}

		internal static void Vva1A7vgepPd4mCLOcPB(object P_0, object P_1)
		{
			((NStyle)P_0).set_StrokeStyle((NStrokeStyle)P_1);
		}

		internal static object RWnXYJvgNIXmWxkq5OOd(object P_0)
		{
			return ((NStyleableElement)P_0).get_Style();
		}

		internal static float HbAM2VvgxOPS4NFiggiI()
		{
			return StrokeWidth;
		}

		internal static Color wcOOWxvgS2fT4veyitsW()
		{
			return StartColor;
		}

		internal static bool AgwIZ1vgosNXT01Kunle()
		{
			return ts8pCLvg29GuX8mMcamN == null;
		}

		internal static PlusH re1qbvvgFAlQBkKIKV7R()
		{
			return (PlusH)ts8pCLvg29GuX8mMcamN;
		}

		internal static void JaPO6Vvg1h5Y6M4qutRe(object P_0, int P_1, int P_2, int P_3, int P_4)
		{
			((GraphicsPath)P_0).AddLine(P_1, P_2, P_3, P_4);
		}
	}

	private class PlusV : NCustomPath
	{
		private static object JdXshVvghkSfdP3fwfKm;

		public PlusV(float x, float y, float w, float h)
		{
			//Discarded unreachable code: IL_0020, IL_0025
			//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b1: Expected O, but got Unknown
			//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_0104: Expected O, but got Unknown
			Jp4DjYvg48NTWhrh1xZw();
			((NCustomPath)this)._002Ector((GraphicsPath)ggmSHSvgz32X54im2mnO(), (PathType)0);
			int num = 5;
			while (true)
			{
				switch (num)
				{
				case 4:
					euYD31vBKNESjp3e8Qs0(this, x, y);
					num = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b876fa7b083748c8abf8c4b192a11078 == 0)
					{
						num = 2;
					}
					break;
				case 2:
					v46cSgvBv5VoC1aVHxCg(((NStyleableElement)this).get_Style(), Hpa6VvvBZfnXBkTb2gZ9());
					num = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 == 0)
					{
						num = 0;
					}
					break;
				default:
					v46cSgvBv5VoC1aVHxCg(nurmtnvBYOwDA9WjiYY8(this), (object)new NStrokeStyle(cZpwdFvB8j3tTIgfo1sj(), dp1UZsvBsF2SBvxLaUqP()));
					num = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5d3bc916b5664717ac60544de077bd16 != 0)
					{
						num = 1;
					}
					break;
				case 5:
					((NModel)this).ScaleModel(w / 32f, h / 32f, new NPointF(0f, 0f));
					num = 4;
					break;
				case 3:
					N6vV5avBOj6xKsyuoPCM(this, (object)new NStyle());
					num = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f8a84e2cb374827a50ba2cbcf11cf48 == 0)
					{
						num = 2;
					}
					break;
				case 1:
					return;
				}
			}
		}

		private static GraphicsPath CreatePath()
		{
			GraphicsPath graphicsPath = new GraphicsPath();
			graphicsPath.AddLine(16, 4, 16, 28);
			return graphicsPath;
		}

		internal static void Jp4DjYvg48NTWhrh1xZw()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}

		internal static object ggmSHSvgz32X54im2mnO()
		{
			return CreatePath();
		}

		internal static void euYD31vBKNESjp3e8Qs0(object P_0, float P_1, float P_2)
		{
			((NTransformableElement)P_0).Translate(P_1, P_2);
		}

		internal static void N6vV5avBOj6xKsyuoPCM(object P_0, object P_1)
		{
			((NStyleableElement)P_0).set_Style((NStyle)P_1);
		}

		internal static object Hpa6VvvBZfnXBkTb2gZ9()
		{
			return ShapeHelper.DefaultThickStrokeStyle;
		}

		internal static void v46cSgvBv5VoC1aVHxCg(object P_0, object P_1)
		{
			((NStyle)P_0).set_StrokeStyle((NStrokeStyle)P_1);
		}

		internal static object nurmtnvBYOwDA9WjiYY8(object P_0)
		{
			return ((NStyleableElement)P_0).get_Style();
		}

		internal static float cZpwdFvB8j3tTIgfo1sj()
		{
			return StrokeWidth;
		}

		internal static Color dp1UZsvBsF2SBvxLaUqP()
		{
			return StartColor;
		}

		internal static bool chxm23vgE2sIXeFmYcUf()
		{
			return JdXshVvghkSfdP3fwfKm == null;
		}

		internal static PlusV Ajj0BgvgwWIMkCEvFLT0()
		{
			return (PlusV)JdXshVvghkSfdP3fwfKm;
		}
	}

	private static SubProcessDecorator IwgiEROzKXurHF8peH84;

	protected static Color StrokeColor => kmuTBHOz8QNdCjnAkDa0(98, 189, 147);

	protected static Color StartColor => kmuTBHOz8QNdCjnAkDa0(184, 240, 208);

	protected static float StrokeWidth => 1f;

	public SubProcessDecorator()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		UsVXBiOzvmHl7rY1V6q5();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_61395ebf330446ac8ce99b55ee3acfa9 != 0)
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
				Height = 12f;
				num = 2;
				continue;
			}
			I0myprOzYUqxOOu8cihm(this, 12f);
			num = 1;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e632863bfb124ba083e3ba9b363fd70e == 0)
			{
				num = 1;
			}
		}
	}

	protected override void CreatePaths(NRectangleF bounds)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				AddPath((NPathPrimitive)(object)new Border(bounds.X, bounds.Y, bounds.Width, bounds.Height));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe7a0ffe67e4fea8e329ae6574ed2ca == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				AddPath((NPathPrimitive)(object)new PlusV(bounds.X, bounds.Y, bounds.Width, bounds.Height));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 != 0)
				{
					num2 = 2;
				}
				break;
			default:
				AddPath((NPathPrimitive)(object)new PlusH(bounds.X, bounds.Y, bounds.Width, bounds.Height));
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c447ffb64be44c09b6fd398df506785b != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static void UsVXBiOzvmHl7rY1V6q5()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static void I0myprOzYUqxOOu8cihm(object P_0, float value)
	{
		((BaseDecorator)P_0).Width = value;
	}

	internal static bool KBPtIkOzOyS1on8AojrF()
	{
		return IwgiEROzKXurHF8peH84 == null;
	}

	internal static SubProcessDecorator LpTgPdOzZ2LwJmAxcKXP()
	{
		return IwgiEROzKXurHF8peH84;
	}

	internal static Color kmuTBHOz8QNdCjnAkDa0(int P_0, int P_1, int P_2)
	{
		return Color.FromArgb(P_0, P_1, P_2);
	}
}
