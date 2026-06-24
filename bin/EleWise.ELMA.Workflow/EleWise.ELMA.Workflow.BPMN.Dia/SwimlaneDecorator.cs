using System;
using System.Collections;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;
using Nevron.Diagram;
using Nevron.GraphicsCore;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Decorators;

[Serializable]
public class SwimlaneDecorator : BaseDecorator
{
	private class Border : NCustomPath
	{
		private static object a7dyCJvBJqmER49haXvT;

		public Border(float x, float y, float w, float h, NStyle style)
		{
			//Discarded unreachable code: IL_0030
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			xIfVcIvBynwxynu4qFWc();
			((NCustomPath)this)._002Ector((GraphicsPath)yxbgpNvBmdk8pBDWLkpy(), (PathType)1);
			int num = 1;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7de614af35034bd0a6867d08a2ee4a84 == 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				case 3:
					return;
				case 1:
					gfpHs9vBt075uSlFfv1g(this, w / 18f, h / 18f, new NPointF(0f, 0f));
					num = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a == 0)
					{
						num = 1;
					}
					break;
				case 2:
					((NTransformableElement)this).Translate(x, y);
					num = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_448e6815cb30438893079dcbb906fd65 == 0)
					{
						num = 0;
					}
					break;
				default:
				{
					cEEv21vBbWmKMj7v5nZt(this, style);
					int num2 = 3;
					num = num2;
					break;
				}
				}
			}
		}

		private static GraphicsPath CreatePath()
		{
			GraphicsPath graphicsPath = new GraphicsPath();
			graphicsPath.AddLine(4, 6, 4, 4);
			G2xlnrvB5sZNN52xL4H3(graphicsPath, 12, 4, 12, 2);
			G2xlnrvB5sZNN52xL4H3(graphicsPath, 16, 5, 12, 8);
			G2xlnrvB5sZNN52xL4H3(graphicsPath, 12, 6, 4, 6);
			graphicsPath.CloseFigure();
			graphicsPath.AddLine(12, 10, 12, 12);
			G2xlnrvB5sZNN52xL4H3(graphicsPath, 4, 12, 4, 14);
			G2xlnrvB5sZNN52xL4H3(graphicsPath, 0, 11, 4, 8);
			G2xlnrvB5sZNN52xL4H3(graphicsPath, 4, 10, 12, 10);
			T8GkAlvBgo2GxalfYsTn(graphicsPath);
			G2xlnrvB5sZNN52xL4H3(graphicsPath, 6, 16, 7, 16);
			G2xlnrvB5sZNN52xL4H3(graphicsPath, 10, 0, 9, 0);
			T8GkAlvBgo2GxalfYsTn(graphicsPath);
			return graphicsPath;
		}

		internal static void xIfVcIvBynwxynu4qFWc()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}

		internal static object yxbgpNvBmdk8pBDWLkpy()
		{
			return CreatePath();
		}

		internal static void gfpHs9vBt075uSlFfv1g(object P_0, float P_1, float P_2, NPointF P_3)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			((NModel)P_0).ScaleModel(P_1, P_2, P_3);
		}

		internal static void cEEv21vBbWmKMj7v5nZt(object P_0, object P_1)
		{
			((NStyleableElement)P_0).set_Style((NStyle)P_1);
		}

		internal static bool xpAFAqvBl0pet4M0NlmB()
		{
			return a7dyCJvBJqmER49haXvT == null;
		}

		internal static Border xhV71CvB0trq65ZCLyQA()
		{
			return (Border)a7dyCJvBJqmER49haXvT;
		}

		internal static void G2xlnrvB5sZNN52xL4H3(object P_0, int P_1, int P_2, int P_3, int P_4)
		{
			((GraphicsPath)P_0).AddLine(P_1, P_2, P_3, P_4);
		}

		internal static void T8GkAlvBgo2GxalfYsTn(object P_0)
		{
			((GraphicsPath)P_0).CloseFigure();
		}
	}

	private static SwimlaneDecorator zLnJCAOzs9KJZRtS7Q7b;

	public float RotationAngle
	{
		[CompilerGenerated]
		get
		{
			return _003CRotationAngle_003Ek__BackingField;
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
					_003CRotationAngle_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_dcdfd019631e458b9cb5fa34a16a2fe1 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public override NStyle Style
	{
		[CompilerGenerated]
		get
		{
			return _003CStyle_003Ek__BackingField;
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
					_003CStyle_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public SwimlaneDecorator()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Y8yJwZOz0ntKLbQuvUOR();
		base._002Ector();
		int num = 2;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			case 2:
				aHAADCOzyYuRnRj1GFuM(this, 16f);
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ecf910d183864897a7c8ec77e01689a4 == 0)
				{
					num = 0;
				}
				break;
			default:
				Height = 16f;
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6fe3beca34a9422e873cd6ef331760ae == 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	public void ResetStyle()
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				UpdatePathsStyle((NStyle)sbeODjOztVXIhsRIlWlD(this));
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			case 1:
				HmvUQrOzmdyAlcAGauWB(this, (object)new NStyle());
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void SetStyle(NFillStyle fillStyle, NStrokeStyle strokeStyle)
	{
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				NFPB2aOzbRVMcs3eN5OJ(((NStyleableElement)this).get_Style(), fillStyle);
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_719514a5a8ae47ed84e5a777ead0dc9f == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				RBj2VfOz5gbEZiWOoWoc(sbeODjOztVXIhsRIlWlD(this), strokeStyle);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f508947b0d94af1961e5aa17a8a2044 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				UpdatePathsStyle((NStyle)sbeODjOztVXIhsRIlWlD(this));
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				return;
			case 4:
				((NStyleableElement)this).set_Style(new NStyle());
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0991fd79553c4ecc82e8b5cb79c2bff2 == 0)
				{
					num2 = 3;
				}
				break;
			}
		}
	}

	protected override void CreatePaths(NRectangleF bounds)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			default:
				RotatePaths(RotationAngle);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 != 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				AddPath((NPathPrimitive)(object)new Border(bounds.X, bounds.Y, bounds.Width, bounds.Height, ((NStyleableElement)this).get_Style()));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void UpdatePathsStyle(NStyle style)
	{
		//Discarded unreachable code: IL_002e, IL_003d, IL_0048, IL_00dc, IL_0129, IL_0138
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		int num = 2;
		int num2 = num;
		IEnumerator enumerator = default(IEnumerator);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				try
				{
					while (true)
					{
						int num3;
						if (!lVyIKrOzBFWS8YOaGKKt(enumerator))
						{
							num3 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ac5d16a577a84bb0b8ee3654769d2d33 == 0)
							{
								num3 = 2;
							}
							goto IL_004c;
						}
						goto IL_0062;
						IL_0062:
						HmvUQrOzmdyAlcAGauWB((object)(NPathPrimitive)eDt0R7Ozg876QPFVMETt(enumerator), style);
						num3 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b == 0)
						{
							num3 = 1;
						}
						goto IL_004c;
						IL_004c:
						switch (num3)
						{
						case 1:
							continue;
						case 2:
							return;
						}
						goto IL_0062;
					}
				}
				finally
				{
					IDisposable disposable = enumerator as IDisposable;
					int num4 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a50dda04dedf4515816f963c67783c8f != 0)
					{
						num4 = 0;
					}
					while (true)
					{
						switch (num4)
						{
						default:
							if (disposable != null)
							{
								num4 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f508947b0d94af1961e5aa17a8a2044 == 0)
								{
									num4 = 1;
								}
								continue;
							}
							break;
						case 1:
							HttxeKOzcPQf9EjyVnkU(disposable);
							num4 = 2;
							continue;
						case 2:
							break;
						}
						break;
					}
				}
			case 2:
				enumerator = base.Paths.GetEnumerator();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a9be7e056b4e4b6e863b634c418144f1 == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			}
		}
	}

	private void RotatePaths(float rotationAngle)
	{
		//Discarded unreachable code: IL_002e, IL_003c, IL_00ea, IL_0147, IL_0156
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		int num2 = num;
		IEnumerator enumerator = default(IEnumerator);
		NPathPrimitive val = default(NPathPrimitive);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				enumerator = (IEnumerator)MpTmEJOzPUuPgZcPO5gZ(base.Paths);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4ef74b4b7d13430e9d2f9b78cbdb367b != 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				while (true)
				{
					IL_0082:
					int num3;
					if (!lVyIKrOzBFWS8YOaGKKt(enumerator))
					{
						num3 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9570b4a70465495fba22c942f586465a != 0)
						{
							num3 = 1;
						}
						goto IL_0040;
					}
					goto IL_005a;
					IL_005a:
					val = (NPathPrimitive)eDt0R7Ozg876QPFVMETt(enumerator);
					num3 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5537a063960e465db83a04e35eea441b != 0)
					{
						num3 = 0;
					}
					goto IL_0040;
					IL_0040:
					while (true)
					{
						switch (num3)
						{
						case 3:
							break;
						case 2:
							goto IL_0082;
						default:
							eat0flOzd9uxDCN3xb8J(val, (CoordinateSystem)0, rotationAngle, UVDbRjOzXVHDGpRZsPMp(val));
							num3 = 2;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 == 0)
							{
								num3 = 2;
							}
							continue;
						case 1:
							return;
						}
						break;
					}
					goto IL_005a;
				}
			}
			finally
			{
				IDisposable disposable = enumerator as IDisposable;
				int num4 = 2;
				while (true)
				{
					switch (num4)
					{
					case 2:
						if (disposable != null)
						{
							num4 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6d48f3b4557a49578bf7f5ef0517e0be != 0)
							{
								num4 = 1;
							}
							continue;
						}
						break;
					case 1:
						HttxeKOzcPQf9EjyVnkU(disposable);
						num4 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_719514a5a8ae47ed84e5a777ead0dc9f == 0)
						{
							num4 = 0;
						}
						continue;
					case 0:
						break;
					}
					break;
				}
			}
		}
	}

	internal static void Y8yJwZOz0ntKLbQuvUOR()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static void aHAADCOzyYuRnRj1GFuM(object P_0, float value)
	{
		((BaseDecorator)P_0).Width = value;
	}

	internal static bool cIuDJoOzJIJkxhXdCqKE()
	{
		return zLnJCAOzs9KJZRtS7Q7b == null;
	}

	internal static SwimlaneDecorator LO1SIFOzlp1Ox4kbW1ZG()
	{
		return zLnJCAOzs9KJZRtS7Q7b;
	}

	internal static void HmvUQrOzmdyAlcAGauWB(object P_0, object P_1)
	{
		((NStyleableElement)P_0).set_Style((NStyle)P_1);
	}

	internal static object sbeODjOztVXIhsRIlWlD(object P_0)
	{
		return ((NStyleableElement)P_0).get_Style();
	}

	internal static void NFPB2aOzbRVMcs3eN5OJ(object P_0, object P_1)
	{
		((NStyle)P_0).set_FillStyle((NFillStyle)P_1);
	}

	internal static void RBj2VfOz5gbEZiWOoWoc(object P_0, object P_1)
	{
		((NStyle)P_0).set_StrokeStyle((NStrokeStyle)P_1);
	}

	internal static object eDt0R7Ozg876QPFVMETt(object P_0)
	{
		return ((IEnumerator)P_0).Current;
	}

	internal static bool lVyIKrOzBFWS8YOaGKKt(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void HttxeKOzcPQf9EjyVnkU(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object MpTmEJOzPUuPgZcPO5gZ(object P_0)
	{
		return ((ArrayList)P_0).GetEnumerator();
	}

	internal static NPointF UVDbRjOzXVHDGpRZsPMp(object P_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NModel)P_0).get_PinPoint();
	}

	internal static void eat0flOzd9uxDCN3xb8J(object P_0, CoordinateSystem P_1, float P_2, NPointF P_3)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		((NTransformableElement)P_0).Rotate(P_1, P_2, P_3);
	}
}
