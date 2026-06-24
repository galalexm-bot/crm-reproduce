using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;
using Nevron.Diagram;
using Nevron.Dom;
using Nevron.GraphicsCore;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Diagrams.Shapes;

[Serializable]
public class OrganizationAnnotationShape : OrganizationShape
{
	private Color strokeColor;

	private OrgShapeMode mode;

	internal static OrganizationAnnotationShape IogBL1mbJh8n1SpHjRs;

	protected virtual Color StartColor => Color.White;

	protected virtual float StrokeWidth => 0.5f;

	protected virtual float DefaultWidth
	{
		[CompilerGenerated]
		get
		{
			return _003CDefaultWidth_003Ek__BackingField;
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
				case 1:
					_003CDefaultWidth_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_61a610c13d6d47c8947a4d2d4016147a != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	protected virtual float DefaultHeight
	{
		[CompilerGenerated]
		get
		{
			return _003CDefaultHeight_003Ek__BackingField;
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
					_003CDefaultHeight_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c08b0b4e9ab14bedb2a2c7a0048ab814 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public OrganizationAnnotationShape()
	{
		//Discarded unreachable code: IL_002b, IL_0030
		xNMQR6mfU6WFR6myTbm();
		this._002Ector(OrgShapeMode.Main);
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_651070b1c9bd4381bbb7379d68d6508e == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected override void CreateDefaultLabels()
	{
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		int num = 2;
		int num2 = num;
		NBoundsLabel val = default(NBoundsLabel);
		NStyle val2 = default(NStyle);
		while (true)
		{
			switch (num2)
			{
			case 7:
				s1wn0be5RqHtOVeYR74(lnSCxMepdZFlpT2n45k(this), val);
				num2 = 4;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_03ad39fc745d49e3be14e8e100fb0203 == 0)
				{
					num2 = 4;
				}
				break;
			case 5:
				return;
			case 6:
				WBsZ4UmzBweEfaClSgn(val2, (object)new NTextStyle(new Font(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1084772212 ^ -1084752814), 13f), Color.FromArgb(95, 95, 95)));
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_ae9e5ed1f04543cd9a3ea633dd768889 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				val = new NBoundsLabel((string)FTMgbjm1hOSBg6INrEV(0x7CAA49C6 ^ 0x7CAA0508), Guid.Empty, NMargins.Empty);
				num2 = 3;
				break;
			case 4:
				BPWkcmeW9tT8wEHnGMu(lnSCxMepdZFlpT2n45k(this), Dk9DKveArfvSjbbtMlF(val));
				num2 = 5;
				break;
			default:
				gtguUuekn3BXGvPtlJu(val, val2);
				num2 = 5;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d689f5970f6345a7af332e1f7092123f == 0)
				{
					num2 = 7;
				}
				break;
			case 3:
				val2 = new NStyle();
				num2 = 6;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6ebd2dabc54f4311bbbe57be8fcccc48 == 0)
				{
					num2 = 6;
				}
				break;
			case 2:
				if (mode != 0)
				{
					return;
				}
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8b4bc2d0df7346ebba20e6c22632a575 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public OrganizationAnnotationShape(OrgShapeMode mode)
	{
		//Discarded unreachable code: IL_002b, IL_02f4, IL_0303, IL_0312
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected O, but got Unknown
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected O, but got Unknown
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected O, but got Unknown
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Expected O, but got Unknown
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected O, but got Unknown
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Expected O, but got Unknown
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Expected O, but got Unknown
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Expected O, but got Unknown
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0335: Expected O, but got Unknown
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Expected O, but got Unknown
		//IL_03e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ef: Expected O, but got Unknown
		xNMQR6mfU6WFR6myTbm();
		base._002Ector(mode);
		int num = 2;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0d00d0d8fcd5481b8bdc09ec82b1ea36 == 0)
		{
			num = 0;
		}
		NCustomPath val = default(NCustomPath);
		NCustomPath val5 = default(NCustomPath);
		NStyle val4 = default(NStyle);
		NStyle val3 = default(NStyle);
		NRectanglePath val2 = default(NRectanglePath);
		while (true)
		{
			int num2;
			switch (num)
			{
			case 13:
				w1PjSmen8rydt4HL0PJ(this, 24f);
				num = 23;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6949750552fc4dcdbaec6842e5667482 == 0)
				{
					num = 19;
				}
				break;
			case 21:
				s1wn0be5RqHtOVeYR74(fHE7rDeeVXLLwLdxADE(this), val);
				num = 8;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_11e42501f5004eefaeaccdfe8bd3b619 == 0)
				{
					num = 7;
				}
				break;
			case 1:
				w1PjSmen8rydt4HL0PJ(this, 164f);
				num = 18;
				break;
			case 3:
				gtguUuekn3BXGvPtlJu(val5, val4);
				num = 5;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a33ec05b36714591b0adf150b655c9a8 != 0)
				{
					num = 20;
				}
				break;
			case 16:
				WmmHoZeBHPQ0wGuFjWA(val3, (object)new NColorFillStyle(fHsueQelZDwOVm8HXtN()));
				num = 11;
				break;
			case 22:
				qULo4aeZXFbBl3rMKqo(((NStyle)NgQRKfe6fgE7LJLM5H3(this)).get_StrokeStyle(), new NLength(2));
				num = 27;
				break;
			case 14:
				((NStyleableElement)val).set_Style(val3);
				num = 21;
				break;
			case 12:
				s1wn0be5RqHtOVeYR74(((NCompositeShape)this).get_Primitives(), val2);
				num = 9;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0f3686d2211943308639c187009d1b4a == 0)
				{
					num = 26;
				}
				break;
			case 6:
				WmmHoZeBHPQ0wGuFjWA(val4, (object)new NColorFillStyle(fHsueQelZDwOVm8HXtN()));
				num = 10;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_61a610c13d6d47c8947a4d2d4016147a != 0)
				{
					num = 3;
				}
				break;
			case 10:
				val4.set_StrokeStyle(new NStrokeStyle(hoWb9ReuFMjOXj1gZEH(this), base.StrokeColor));
				num = 3;
				break;
			case 17:
				if (mode != 0)
				{
					num2 = 7;
					goto IL_0030;
				}
				goto case 25;
			case 9:
				return;
			case 11:
				LlWaSxeNBhEUeqLRctp(val3, (object)new NStrokeStyle(hoWb9ReuFMjOXj1gZEH(this), IONlaTemKDbJ3ZmPDDo(this)));
				num = 14;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_98c0ec8bd6124c50b29441c60f6a53bf == 0)
				{
					num = 12;
				}
				break;
			case 26:
				((NStyle)NgQRKfe6fgE7LJLM5H3(this)).set_FillStyle((NFillStyle)new NColorFillStyle(fHsueQelZDwOVm8HXtN()));
				num = 24;
				break;
			case 15:
				((NAggregateModel)this).UpdateModelBounds();
				num2 = 5;
				goto IL_0030;
			case 20:
				s1wn0be5RqHtOVeYR74(fHE7rDeeVXLLwLdxADE(this), val5);
				num = 15;
				break;
			case 8:
				val5 = new NCustomPath((GraphicsPath)GyyMcEeLUWLZ3LjU9EQ(0f, 0f, DefaultWidth, p4EyxXe72R1TTSE0brj(this)), (PathType)1);
				num = 4;
				break;
			default:
				zcjy5heXfWqdPQPXjCt(this, 32f);
				num = 13;
				break;
			case 18:
			case 23:
				val2 = new NRectanglePath(0f, 0f, ptNJF8eiWTRjoowRgyf(this), p4EyxXe72R1TTSE0brj(this));
				num = 12;
				break;
			case 4:
				val4 = new NStyle();
				num = 6;
				break;
			case 19:
				val3 = new NStyle();
				num = 12;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_ae5d5c9fcc284404ba2e43f0c4ab8892 != 0)
				{
					num = 16;
				}
				break;
			case 2:
				if (mode != OrgShapeMode.Preview)
				{
					num = 17;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a5d922da527e46afbe4b139adb51cde5 == 0)
					{
						num = 2;
					}
					break;
				}
				goto case 25;
			case 24:
				LlWaSxeNBhEUeqLRctp(NgQRKfe6fgE7LJLM5H3(this), (object)new NStrokeStyle(strokeColor));
				num = 22;
				break;
			case 25:
				zcjy5heXfWqdPQPXjCt(this, 64f);
				num = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1bc92e0376794fc182b6e366eee82dbd == 0)
				{
					num = 1;
				}
				break;
			case 5:
				aUk23eejh0PUVNCN4iI(fHE7rDeeVXLLwLdxADE(this), val2);
				num = 9;
				break;
			case 27:
				{
					val = new NCustomPath((GraphicsPath)DKFcowexo6amSJA71Y5(0f, 0f, ptNJF8eiWTRjoowRgyf(this), p4EyxXe72R1TTSE0brj(this)), (PathType)1);
					num = 19;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8b4bc2d0df7346ebba20e6c22632a575 == 0)
					{
						num = 5;
					}
					break;
				}
				IL_0030:
				num = num2;
				break;
			}
		}
	}

	public override void AddProtection()
	{
	}

	public override void AddPorts()
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_0062: Expected O, but got Unknown
		int num = 5;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
				{
					object obj = bGPMCheHAt3lIDBxHSg(this);
					NRotatedBoundsPort val = new NRotatedBoundsPort(Dk9DKveArfvSjbbtMlF(this), ContentAlignment.MiddleLeft);
					CeAMtyea4qHUaGP8xmK((object)val, FTMgbjm1hOSBg6INrEV(-1195916818 ^ -1195930340));
					s1wn0be5RqHtOVeYR74(obj, (object)val);
					num2 = 3;
					continue;
				}
				case 4:
					((NShape)this).CreateShapeElements((ShapeElementsMask)2);
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f5cf5deab67c429f89caddff1f348afc == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					vrc116eRHawOEDdT1rT(bGPMCheHAt3lIDBxHSg(this), true);
					num2 = 2;
					continue;
				case 2:
					return;
				case 5:
					if (((NShape)this).get_Ports() != null)
					{
						break;
					}
					goto end_IL_0012;
				}
				((NDiagramElementCollection)bGPMCheHAt3lIDBxHSg(this)).set_AutoGenerateUniqueNames(false);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_77bfde1a0739446782f0bda00c988550 == 0)
				{
					num2 = 1;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 4;
		}
	}

	private static GraphicsPath CreatePath(float x, float y, float w, float h)
	{
		int num = 2;
		int num2 = num;
		float num3 = default(float);
		float num4 = default(float);
		while (true)
		{
			switch (num2)
			{
			case 2:
				num3 = x + w / 3f;
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0d00d0d8fcd5481b8bdc09ec82b1ea36 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				num4 = y + h;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5028d2018b41471c962aaca947e33b9d == 0)
				{
					num2 = 0;
				}
				break;
			default:
			{
				GraphicsPath graphicsPath = new GraphicsPath();
				KMo7sbewopTmfEeCEcL(graphicsPath, num3, y, x, y);
				KMo7sbewopTmfEeCEcL(graphicsPath, x, num4, num3, num4);
				return graphicsPath;
			}
			}
		}
	}

	private static GraphicsPath CreatePathBase(float x, float y, float w, float h)
	{
		int num = 2;
		int num2 = num;
		float num3 = default(float);
		float num4 = default(float);
		while (true)
		{
			switch (num2)
			{
			case 2:
				num3 = x + w;
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2f11eccd7e8f4339a0b03ad9fe1eb947 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				num4 = y + h;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_05864899c47d415d8fae32c68fb25d39 == 0)
				{
					num2 = 0;
				}
				break;
			default:
			{
				GraphicsPath graphicsPath = new GraphicsPath();
				KMo7sbewopTmfEeCEcL(graphicsPath, num3, y, x, y);
				graphicsPath.AddLine(x, num4, num3, num4);
				z7MhQce2aSyspsDawQC(graphicsPath);
				return graphicsPath;
			}
			}
		}
	}

	internal static void xNMQR6mfU6WFR6myTbm()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}

	internal static bool gpTApomSBgCB2doykw1()
	{
		return IogBL1mbJh8n1SpHjRs == null;
	}

	internal static OrganizationAnnotationShape uxOPljm99VCAnIYX8x7()
	{
		return IogBL1mbJh8n1SpHjRs;
	}

	internal static object FTMgbjm1hOSBg6INrEV(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void WBsZ4UmzBweEfaClSgn(object P_0, object P_1)
	{
		((NStyle)P_0).set_TextStyle((NTextStyle)P_1);
	}

	internal static void gtguUuekn3BXGvPtlJu(object P_0, object P_1)
	{
		((NStyleableElement)P_0).set_Style((NStyle)P_1);
	}

	internal static object lnSCxMepdZFlpT2n45k(object P_0)
	{
		return ((NShape)P_0).get_Labels();
	}

	internal static void s1wn0be5RqHtOVeYR74(object P_0, object P_1)
	{
		((NDiagramElementCollection)P_0).AddChild((INNode)P_1);
	}

	internal static Guid Dk9DKveArfvSjbbtMlF(object P_0)
	{
		return ((NDiagramElement)P_0).get_UniqueId();
	}

	internal static void BPWkcmeW9tT8wEHnGMu(object P_0, Guid P_1)
	{
		((NLabelCollection)P_0).set_DefaultLabelUniqueId(P_1);
	}

	internal static void zcjy5heXfWqdPQPXjCt(object P_0, float value)
	{
		((OrganizationAnnotationShape)P_0).DefaultHeight = value;
	}

	internal static void w1PjSmen8rydt4HL0PJ(object P_0, float value)
	{
		((OrganizationAnnotationShape)P_0).DefaultWidth = value;
	}

	internal static float ptNJF8eiWTRjoowRgyf(object P_0)
	{
		return ((OrganizationAnnotationShape)P_0).DefaultWidth;
	}

	internal static float p4EyxXe72R1TTSE0brj(object P_0)
	{
		return ((OrganizationAnnotationShape)P_0).DefaultHeight;
	}

	internal static object NgQRKfe6fgE7LJLM5H3(object P_0)
	{
		return ((NStyleableElement)P_0).get_Style();
	}

	internal static Color fHsueQelZDwOVm8HXtN()
	{
		return Color.Transparent;
	}

	internal static void LlWaSxeNBhEUeqLRctp(object P_0, object P_1)
	{
		((NStyle)P_0).set_StrokeStyle((NStrokeStyle)P_1);
	}

	internal static void qULo4aeZXFbBl3rMKqo(object P_0, NLength P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((NStrokeStyle)P_0).set_Width(P_1);
	}

	internal static object DKFcowexo6amSJA71Y5(float x, float y, float w, float h)
	{
		return CreatePathBase(x, y, w, h);
	}

	internal static void WmmHoZeBHPQ0wGuFjWA(object P_0, object P_1)
	{
		((NStyle)P_0).set_FillStyle((NFillStyle)P_1);
	}

	internal static float hoWb9ReuFMjOXj1gZEH(object P_0)
	{
		return ((OrganizationAnnotationShape)P_0).StrokeWidth;
	}

	internal static Color IONlaTemKDbJ3ZmPDDo(object P_0)
	{
		return ((OrganizationAnnotationShape)P_0).StartColor;
	}

	internal static object fHE7rDeeVXLLwLdxADE(object P_0)
	{
		return ((NCompositeShape)P_0).get_Primitives();
	}

	internal static object GyyMcEeLUWLZ3LjU9EQ(float x, float y, float w, float h)
	{
		return CreatePath(x, y, w, h);
	}

	internal static void aUk23eejh0PUVNCN4iI(object P_0, object P_1)
	{
		((NDiagramElementCollection)P_0).RemoveChild((INNode)P_1);
	}

	internal static object bGPMCheHAt3lIDBxHSg(object P_0)
	{
		return ((NShape)P_0).get_Ports();
	}

	internal static void CeAMtyea4qHUaGP8xmK(object P_0, object P_1)
	{
		((NDiagramElement)P_0).set_Name((string)P_1);
	}

	internal static void vrc116eRHawOEDdT1rT(object P_0, bool P_1)
	{
		((NDiagramElementCollection)P_0).set_AutoGenerateUniqueNames(P_1);
	}

	internal static void KMo7sbewopTmfEeCEcL(object P_0, float P_1, float P_2, float P_3, float P_4)
	{
		((GraphicsPath)P_0).AddLine(P_1, P_2, P_3, P_4);
	}

	internal static void z7MhQce2aSyspsDawQC(object P_0)
	{
		((GraphicsPath)P_0).CloseAllFigures();
	}
}
