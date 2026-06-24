using System.Drawing;
using System.Drawing.Drawing2D;
using EleWise.ELMA.Workflow.Diagrams.Shapes;
using j3AmrhgkCleVTGdEwA;
using Nevron.Diagram;
using Nevron.GraphicsCore;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Decorators;

public class InternalSubProcessDecorator : BaseDecorator
{
	private class Border : NCustomPath
	{
		private static object ju4TbHvt0d4QQ78jDbmc;

		public Border(float x, float y, float w, float h)
		{
			//Discarded unreachable code: IL_0030, IL_0035
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c9: Expected O, but got Unknown
			//IL_0109: Unknown result type (might be due to invalid IL or missing references)
			//IL_0113: Expected O, but got Unknown
			//IL_011e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0128: Expected O, but got Unknown
			NhPm0Svtt9dD9Q3kSldR();
			((NCustomPath)this)._002Ector((GraphicsPath)Ni0MUIvtbURlSywsRuMi(), (PathType)1);
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 != 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				default:
					NdMqSDvt5o77am2Tpr2c(this, w / 32f, h / 32f, new NPointF(0f, 0f));
					num = 6;
					break;
				case 6:
					P0I599vtg1juKFXJI6Td(this, x, y);
					num = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a == 0)
					{
						num = 1;
					}
					break;
				case 4:
					eEN6WUvtXLkIbwRv3Eun(BlXiwgvtcBd7oJ8YWCsR(this), (object)new NStrokeStyle(dwv3ATvtupggNWh53S19(), StrokeColor));
					num = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e != 0)
					{
						num = 2;
					}
					break;
				case 2:
					return;
				case 3:
					eEN6WUvtXLkIbwRv3Eun(BlXiwgvtcBd7oJ8YWCsR(this), IXYB3gvtPIXoJbMERnaT());
					num = 5;
					break;
				case 5:
					((NStyle)BlXiwgvtcBd7oJ8YWCsR(this)).set_FillStyle((NFillStyle)new NColorFillStyle(bqfyvjvtdt8vV4FJp6sX()));
					num = 4;
					break;
				case 1:
					WIsnrBvtB7wZiOytZwfU(this, (object)new NStyle());
					num = 3;
					break;
				}
			}
		}

		private static GraphicsPath CreatePath()
		{
			GraphicsPath graphicsPath = new GraphicsPath();
			NWfsFovtDxmGueSMcfnS(graphicsPath, new RectangleF(0f, 0f, 32f, 32f));
			return graphicsPath;
		}

		internal static void NhPm0Svtt9dD9Q3kSldR()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}

		internal static object Ni0MUIvtbURlSywsRuMi()
		{
			return CreatePath();
		}

		internal static void NdMqSDvt5o77am2Tpr2c(object P_0, float P_1, float P_2, NPointF P_3)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			((NModel)P_0).ScaleModel(P_1, P_2, P_3);
		}

		internal static void P0I599vtg1juKFXJI6Td(object P_0, float P_1, float P_2)
		{
			((NTransformableElement)P_0).Translate(P_1, P_2);
		}

		internal static void WIsnrBvtB7wZiOytZwfU(object P_0, object P_1)
		{
			((NStyleableElement)P_0).set_Style((NStyle)P_1);
		}

		internal static object BlXiwgvtcBd7oJ8YWCsR(object P_0)
		{
			return ((NStyleableElement)P_0).get_Style();
		}

		internal static object IXYB3gvtPIXoJbMERnaT()
		{
			return ShapeHelper.DefaultThickStrokeStyle;
		}

		internal static void eEN6WUvtXLkIbwRv3Eun(object P_0, object P_1)
		{
			((NStyle)P_0).set_StrokeStyle((NStrokeStyle)P_1);
		}

		internal static Color bqfyvjvtdt8vV4FJp6sX()
		{
			return StrokeColor;
		}

		internal static float dwv3ATvtupggNWh53S19()
		{
			return StrokeWidth;
		}

		internal static bool jfVInEvtyvWL5xpfGaQh()
		{
			return ju4TbHvt0d4QQ78jDbmc == null;
		}

		internal static Border jK3cCRvtm0xrZnOk4KHL()
		{
			return (Border)ju4TbHvt0d4QQ78jDbmc;
		}

		internal static void NWfsFovtDxmGueSMcfnS(object P_0, RectangleF P_1)
		{
			((GraphicsPath)P_0).AddRectangle(P_1);
		}
	}

	private class PlusH : NCustomPath
	{
		private static object sCgdXMvtn7slaAMkssgj;

		public PlusH(float x, float y, float w, float h)
		{
			//Discarded unreachable code: IL_0030
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Expected O, but got Unknown
			//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e6: Expected O, but got Unknown
			CWYh65vtfHMi79wtc22m();
			((NCustomPath)this)._002Ector((GraphicsPath)UuGubfvt9eVUoStJWVEf(), (PathType)0);
			int num = 2;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae4e393cddc4c98b9896b25c9e18c7d != 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 1:
					D2O5aJvtqG2w7MlrbEHi(jrQZXbvtRutEa0lvQtOv(this), hcvQiHvt6IhNq4FTRG6h());
					num = 3;
					break;
				case 3:
					D2O5aJvtqG2w7MlrbEHi(jrQZXbvtRutEa0lvQtOv(this), (object)new NStrokeStyle(NZX4Wxvt3AyMIbT7jkJQ(), ymyaRbvtTXiDxQOQqATT()));
					num = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_43af423d081c48e3bc6cea30ce47523d == 0)
					{
						num = 0;
					}
					break;
				case 2:
				{
					CHSXhjvtWpcPgPgpshDq(this, w / 32f, h / 32f, new NPointF(0f, 0f));
					int num2 = 5;
					num = num2;
					break;
				}
				case 4:
					k0lrnQvtjqEY3xCt0rkb(this, (object)new NStyle());
					num = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae2bde9e5844c638021cdb56fc01122 != 0)
					{
						num = 1;
					}
					break;
				case 0:
					return;
				case 5:
					((NTransformableElement)this).Translate(x, y);
					num = 4;
					break;
				}
			}
		}

		private static GraphicsPath CreatePath()
		{
			GraphicsPath graphicsPath = new GraphicsPath();
			graphicsPath.AddLine(4, 16, 28, 16);
			return graphicsPath;
		}

		internal static void CWYh65vtfHMi79wtc22m()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}

		internal static object UuGubfvt9eVUoStJWVEf()
		{
			return CreatePath();
		}

		internal static void CHSXhjvtWpcPgPgpshDq(object P_0, float P_1, float P_2, NPointF P_3)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			((NModel)P_0).ScaleModel(P_1, P_2, P_3);
		}

		internal static void k0lrnQvtjqEY3xCt0rkb(object P_0, object P_1)
		{
			((NStyleableElement)P_0).set_Style((NStyle)P_1);
		}

		internal static object jrQZXbvtRutEa0lvQtOv(object P_0)
		{
			return ((NStyleableElement)P_0).get_Style();
		}

		internal static object hcvQiHvt6IhNq4FTRG6h()
		{
			return ShapeHelper.DefaultThickStrokeStyle;
		}

		internal static void D2O5aJvtqG2w7MlrbEHi(object P_0, object P_1)
		{
			((NStyle)P_0).set_StrokeStyle((NStrokeStyle)P_1);
		}

		internal static float NZX4Wxvt3AyMIbT7jkJQ()
		{
			return StrokeWidth;
		}

		internal static Color ymyaRbvtTXiDxQOQqATT()
		{
			return StartColor;
		}

		internal static bool di3u2dvtHGKtkcE58QNI()
		{
			return sCgdXMvtn7slaAMkssgj == null;
		}

		internal static PlusH F5slbavtLaWEZHNWBS0K()
		{
			return (PlusH)sCgdXMvtn7slaAMkssgj;
		}
	}

	private class PlusV : NCustomPath
	{
		internal static object tYQ7IYvtQUnte1NpD6LZ;

		public PlusV(float x, float y, float w, float h)
		{
			//Discarded unreachable code: IL_0030
			//IL_0075: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00df: Expected O, but got Unknown
			//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f8: Expected O, but got Unknown
			yeM0DDvtMZFZxB4y0gkL();
			((NCustomPath)this)._002Ector((GraphicsPath)kEeF28vtkEAaVcu1X0xH(), (PathType)0);
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f != 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 5:
					EiDlYQvtGMrfjUj5EnsP(((NStyleableElement)this).get_Style(), ShqZHJvtA9655SFAtlVH());
					num = 3;
					continue;
				case 1:
					hHhFw0vtUYFMG5T6chfK(this, x, y);
					num = 4;
					continue;
				case 3:
				{
					((NStyle)D1KBbYvt7CK4mnMXEdgP(this)).set_StrokeStyle(new NStrokeStyle(GCJh2Ivt2ApMfsRIsnCg(), SJBoSmvtoeJgxxbejCOf()));
					int num2 = 2;
					num = num2;
					continue;
				}
				case 4:
					FOd3UovtVhuVjyXfo6iT(this, (object)new NStyle());
					num = 5;
					continue;
				case 2:
					return;
				}
				((NModel)this).ScaleModel(w / 32f, h / 32f, new NPointF(0f, 0f));
				num = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 == 0)
				{
					num = 1;
				}
			}
		}

		private static GraphicsPath CreatePath()
		{
			GraphicsPath graphicsPath = new GraphicsPath();
			graphicsPath.AddLine(16, 4, 16, 28);
			return graphicsPath;
		}

		internal static void yeM0DDvtMZFZxB4y0gkL()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}

		internal static object kEeF28vtkEAaVcu1X0xH()
		{
			return CreatePath();
		}

		internal static void hHhFw0vtUYFMG5T6chfK(object P_0, float P_1, float P_2)
		{
			((NTransformableElement)P_0).Translate(P_1, P_2);
		}

		internal static void FOd3UovtVhuVjyXfo6iT(object P_0, object P_1)
		{
			((NStyleableElement)P_0).set_Style((NStyle)P_1);
		}

		internal static object ShqZHJvtA9655SFAtlVH()
		{
			return ShapeHelper.DefaultThickStrokeStyle;
		}

		internal static void EiDlYQvtGMrfjUj5EnsP(object P_0, object P_1)
		{
			((NStyle)P_0).set_StrokeStyle((NStrokeStyle)P_1);
		}

		internal static object D1KBbYvt7CK4mnMXEdgP(object P_0)
		{
			return ((NStyleableElement)P_0).get_Style();
		}

		internal static float GCJh2Ivt2ApMfsRIsnCg()
		{
			return StrokeWidth;
		}

		internal static Color SJBoSmvtoeJgxxbejCOf()
		{
			return StartColor;
		}

		internal static bool Pfr4LPvtpp8qOtFSZ2Qi()
		{
			return tYQ7IYvtQUnte1NpD6LZ == null;
		}

		internal static PlusV xwRGThvtCDeauP1NnYMD()
		{
			return (PlusV)tYQ7IYvtQUnte1NpD6LZ;
		}
	}

	private static InternalSubProcessDecorator kijbgdO4sqVkv6Gb4ZSS;

	protected static Color StrokeColor => CNQ0QEO4m0KQRsovDYH1(126, 159, 234);

	protected static Color StartColor => CNQ0QEO4m0KQRsovDYH1(200, 213, 255);

	protected static float StrokeWidth => 1f;

	public InternalSubProcessDecorator()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		pUVeUKO40WUhT13S3weL();
		base._002Ector();
		int num = 2;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_dcdfd019631e458b9cb5fa34a16a2fe1 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				IuMOwAO4ybd9cg8EXRDn(this, 12f);
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4cc62744d0eb4cd68219b70dcad3e68e != 0)
				{
					num = 0;
				}
				break;
			default:
				Height = 12f;
				num = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a27e75af798c48d692c4325f43aa9e6b == 0)
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
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 3:
				AddPath((NPathPrimitive)(object)new PlusV(bounds.X, bounds.Y, bounds.Width, bounds.Height));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				AddPath((NPathPrimitive)(object)new Border(bounds.X, bounds.Y, bounds.Width, bounds.Height));
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ffb1346d351f436b84bb1e9954c3bfa8 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				AddPath((NPathPrimitive)(object)new PlusH(bounds.X, bounds.Y, bounds.Width, bounds.Height));
				num2 = 3;
				break;
			}
		}
	}

	internal static void pUVeUKO40WUhT13S3weL()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static void IuMOwAO4ybd9cg8EXRDn(object P_0, float value)
	{
		((BaseDecorator)P_0).Width = value;
	}

	internal static bool uuU254O4JqwZPGd1TCIK()
	{
		return kijbgdO4sqVkv6Gb4ZSS == null;
	}

	internal static InternalSubProcessDecorator kBuyOIO4lhEFABC4xfMr()
	{
		return kijbgdO4sqVkv6Gb4ZSS;
	}

	internal static Color CNQ0QEO4m0KQRsovDYH1(int P_0, int P_1, int P_2)
	{
		return Color.FromArgb(P_0, P_1, P_2);
	}
}
