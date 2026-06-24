using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using j3AmrhgkCleVTGdEwA;
using Nevron.Diagram;
using Nevron.GraphicsCore;

namespace EleWise.ELMA.Workflow.Diagrams.Shapes;

[Serializable]
public class RectanglePathWithImage : NCustomPath
{
	private Bitmap img;

	private float scale;

	private float img_w;

	private float img_h;

	private NSizeF img_size;

	internal static RectanglePathWithImage yeD0xt1ONh4okrvye72;

	public RectanglePathWithImage()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		sUg2dk1Y9XcQKx3Uvg9();
		((NCustomPath)this)._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae2bde9e5844c638021cdb56fc01122 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public RectanglePathWithImage(Bitmap img, float scale, float x, float y, float w, float h, float radius)
	{
		//Discarded unreachable code: IL_0029, IL_002e, IL_00ab, IL_00ba
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		((NCustomPath)this)._002Ector((GraphicsPath)hKimEa18D3g2ergS8eJ(x, y, w, h, radius), (PathType)1);
		int num = 7;
		while (true)
		{
			switch (num)
			{
			case 5:
				img_h = (float)SKlWOF1sia3b97n2sYm(img) * scale;
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 != 0)
				{
					num = 0;
				}
				break;
			case 1:
				return;
			case 2:
				return;
			case 6:
				if (img == null)
				{
					num = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 == 0)
					{
						num = 1;
					}
					break;
				}
				goto case 4;
			case 4:
				img_w = (float)img.Width * scale;
				num = 5;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e632863bfb124ba083e3ba9b363fd70e == 0)
				{
					num = 4;
				}
				break;
			case 7:
				this.img = img;
				num = 3;
				break;
			default:
				img_size = new NSizeF(img_w, img_h);
				num = 2;
				break;
			case 3:
				this.scale = scale;
				num = 6;
				break;
			}
		}
	}

	private static GraphicsPath CreatePath(float x, float y, float w, float h, float radius)
	{
		int num = 1;
		int num2 = num;
		float num4 = default(float);
		float num3 = default(float);
		while (true)
		{
			switch (num2)
			{
			default:
				num4 = y + h - radius;
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4ef74b4b7d13430e9d2f9b78cbdb367b == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				num3 = x + w - radius;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
			{
				GraphicsPath graphicsPath = new GraphicsPath();
				lIqsgh1JcatHGwCePDk(graphicsPath, num3, num4, radius, radius, 0f, 90f);
				lIqsgh1JcatHGwCePDk(graphicsPath, x, num4, radius, radius, 90f, 90f);
				lIqsgh1JcatHGwCePDk(graphicsPath, x, y, radius, radius, 180f, 90f);
				lIqsgh1JcatHGwCePDk(graphicsPath, num3, y, radius, radius, 270f, 90f);
				graphicsPath.CloseAllFigures();
				return graphicsPath;
			}
			}
		}
	}

	public override void Paint(NPaintContext context)
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		int num = 4;
		int num2 = num;
		NRectangleF val2 = default(NRectangleF);
		NPointF val = default(NPointF);
		while (true)
		{
			switch (num2)
			{
			case 5:
				GBObhC1lvJEGQ5ca0b9(context);
				num2 = 2;
				break;
			case 6:
				val2 = ((NMatrix2DF)(ref context.SceneToDevice)).TransformBounds(new NRectangleF(val, img_size));
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 != 0)
				{
					num2 = 1;
				}
				break;
			case 7:
				return;
			case 1:
				POL10O1ytM6CPfylqnO(((lI11lIII)context).Device, img, val2);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				if (img == null)
				{
					return;
				}
				num2 = 5;
				break;
			default:
				m5VDYP1mFuW9O7pO4OC(context);
				num2 = 7;
				break;
			case 2:
				((NPointF)(ref val))._002Ector(((NModel)this).get_Location().X + 2f, oLurSr10KFTF4woNuMF(this).Y + ((NModel)this).get_Bounds().Height - img_h - 2f);
				num2 = 6;
				break;
			case 4:
				((NPathPrimitive)this).Paint(context);
				num2 = 3;
				break;
			}
		}
	}

	internal static void sUg2dk1Y9XcQKx3Uvg9()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool aYo7Pj1ZNrfOTij3Mlu()
	{
		return yeD0xt1ONh4okrvye72 == null;
	}

	internal static RectanglePathWithImage Cn8SiI1vctEWQ3VG4sJ()
	{
		return yeD0xt1ONh4okrvye72;
	}

	internal static object hKimEa18D3g2ergS8eJ(float x, float y, float w, float h, float radius)
	{
		return CreatePath(x, y, w, h, radius);
	}

	internal static int SKlWOF1sia3b97n2sYm(object P_0)
	{
		return ((Image)P_0).Height;
	}

	internal static void lIqsgh1JcatHGwCePDk(object P_0, float P_1, float P_2, float P_3, float P_4, float P_5, float P_6)
	{
		((GraphicsPath)P_0).AddArc(P_1, P_2, P_3, P_4, P_5, P_6);
	}

	internal static bool GBObhC1lvJEGQ5ca0b9(object P_0)
	{
		return ((NPaintContext)P_0).StartDevicePaint();
	}

	internal static NPointF oLurSr10KFTF4woNuMF(object P_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NModel)P_0).get_Location();
	}

	internal static void POL10O1ytM6CPfylqnO(object P_0, object P_1, NRectangleF P_2)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		((l1ll1l11I)P_0).DrawImage((Bitmap)P_1, P_2);
	}

	internal static bool m5VDYP1mFuW9O7pO4OC(object P_0)
	{
		return ((NPaintContext)P_0).EndDevicePaint();
	}
}
