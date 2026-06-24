using System;
using System.ComponentModel;
using System.Drawing;
using j3AmrhgkCleVTGdEwA;
using Nevron.Diagram;
using Nevron.GraphicsCore;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Diagrams.Shapes;

[Serializable]
public class OrgShapeLabel : NBoundsLabel
{
	private static OrgShapeLabel JahL7xjnuR7BtNRH7Wd;

	[EditorBrowsable(EditorBrowsableState.Never)]
	public OrgShapeLabel()
	{
		//Discarded unreachable code: IL_001a, IL_001f
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		GUhnc9j6dN7l8mF1pPo();
		((NBoundsLabel)this)._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 2:
				pWYKnhjlBDitGYEk48t(this, (object)new NStyle());
				num = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_ae9e5ed1f04543cd9a3ea633dd768889 != 0)
				{
					num = 1;
				}
				break;
			case 1:
				((NStyle)b2BFfQjNObNUZBKYsYM(this)).set_TextStyle(new NTextStyle(new Font((string)vh8lQTjZqVFXIecblH2(0x51BB29A6 ^ 0x51BB6578), 13f)));
				num = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_98c0ec8bd6124c50b29441c60f6a53bf != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public OrgShapeLabel(string text, Guid anchorUniqueId, NMargins margins)
	{
		//Discarded unreachable code: IL_001d, IL_0022
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		((NBoundsLabel)this)._002Ector(text, anchorUniqueId, margins);
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				dqnFyFjxfdCYbMG094M(((NStyleableElement)this).get_Style(), (object)new NTextStyle(new Font((string)vh8lQTjZqVFXIecblH2(-1957236745 ^ -1957256407), 13f)));
				num = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_75955a8c33b24cdca4663f20d9ee3c3b == 0)
				{
					num = 1;
				}
				break;
			case 2:
				pWYKnhjlBDitGYEk48t(this, (object)new NStyle());
				num = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e19c59c87b9f40ffa6cb17beeb01edcf == 0)
				{
					num = 0;
				}
				break;
			case 1:
				return;
			}
		}
	}

	public override bool GetDesiredSize(out NSizeF size)
	{
		return GetDesiredSize((string)u9lFj0jBDZQC77ShDly(this), out size);
	}

	protected bool GetDesiredSize(string text, out NSizeF size)
	{
		//Discarded unreachable code: IL_0045
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		int num = 4;
		int num2 = num;
		NMargins val = default(NMargins);
		float num3 = default(float);
		float num4 = default(float);
		while (true)
		{
			switch (num2)
			{
			case 1:
			{
				float left = ((NMargins)(ref val)).get_Left();
				val = kiINwqjuYHJSmcKo6ac(this);
				num3 = left + ((NMargins)(ref val)).get_Right();
				num2 = 3;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_ae5d5c9fcc284404ba2e43f0c4ab8892 != 0)
				{
					num2 = 8;
				}
				break;
			}
			case 4:
				if (((NDiagramNode)this).MeasureStringInScene(text, ((NStyleComposerElement)this).ComposeTextStyle(), ref size))
				{
					num2 = 3;
					break;
				}
				goto case 7;
			case 5:
			{
				float top = ((NMargins)(ref val)).get_Top();
				val = kiINwqjuYHJSmcKo6ac(this);
				num4 = top + ((NMargins)(ref val)).get_Bottom();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a9bad31b2eb24bb9b571e9b822d133bf != 0)
				{
					num2 = 0;
				}
				break;
			}
			default:
				size.Width = 100f * size.Width / (100f - num3);
				num2 = 6;
				break;
			case 6:
				size.Height = 100f * size.Height / (100f - num4);
				num2 = 2;
				break;
			case 8:
				val = kiINwqjuYHJSmcKo6ac(this);
				num2 = 5;
				break;
			case 7:
				return false;
			case 3:
				val = kiINwqjuYHJSmcKo6ac(this);
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8dab57df677749fba2d5364cf752799f != 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				return true;
			}
		}
	}

	public bool GetDesiredBounds(string text, out NRectangleF modelBounds)
	{
		//Discarded unreachable code: IL_0051
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		int num = 8;
		NSizeF size = default(NSizeF);
		NRectangleF val2 = default(NRectangleF);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					if (!((NRectangleF)(ref modelBounds)).get_IsEmpty())
					{
						num2 = 2;
						break;
					}
					goto case 5;
				case 8:
					GetDesiredSize(text, out size);
					num2 = 7;
					break;
				case 4:
					((NRectangleF)(ref val2))._002Ector(new NPointF(32f, (32f - size.Height) / 2f), new NSizeF(size.Width, size.Height));
					num2 = 11;
					break;
				case 6:
					if (size.Width < 64f)
					{
						num2 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8ec57fd3f43f4cf7983bc996ab09feb4 == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 10;
				case 7:
					if (size.Height < 16f)
					{
						goto end_IL_0012;
					}
					goto case 6;
				case 10:
					size.Width += 32f;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6370a8f224e7416eb3575ae34b77f5e3 == 0)
					{
						num2 = 0;
					}
					break;
				case 1:
					size.Width = 64f;
					num2 = 10;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6c7be8ec8b6749dcb0601e062f5515fa != 0)
					{
						num2 = 9;
					}
					break;
				case 9:
					size.Height = 16f;
					num2 = 6;
					break;
				case 11:
				{
					NMargins val = kiINwqjuYHJSmcKo6ac(this);
					modelBounds = ((NMargins)(ref val)).PercentDeflateRectangle(val2);
					num2 = 3;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7eacf98b652644699fca43e43408d382 == 0)
					{
						num2 = 1;
					}
					break;
				}
				case 5:
					return false;
				case 2:
					return true;
				default:
					size.Height += 24f;
					num2 = 4;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8b4bc2d0df7346ebba20e6c22632a575 == 0)
					{
						num2 = 3;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 9;
		}
	}

	public override bool GetWorldTextPaintInfo(string text, out NTextPaintInfo info)
	{
		//Discarded unreachable code: IL_0075, IL_00c8, IL_00d7, IL_018e
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Invalid comparison between Unknown and I4
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		int num = 17;
		OrganizationShape organizationShape = default(OrganizationShape);
		BoxTextMode mode = default(BoxTextMode);
		NPointF[] array = default(NPointF[]);
		NMatrix2DF val = default(NMatrix2DF);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					if (organizationShape == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_9a38cebc63824d86b02d76fd37722379 == 0)
						{
							num2 = 2;
						}
						continue;
					}
					if (CjYjGYjLg2n5IFwEuNW(text))
					{
						num2 = 13;
						continue;
					}
					goto case 19;
				case 6:
					if ((int)mode != 0)
					{
						num2 = 11;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8ec57fd3f43f4cf7983bc996ab09feb4 != 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 10;
				case 3:
				case 8:
				case 15:
					return true;
				case 16:
					organizationShape = y6DkZTje9N1y8V8KnfR(this, zMMkigjmpN49QwL9ySc(this)) as OrganizationShape;
					num = 5;
					break;
				case 13:
				case 18:
				{
					if (!GetDesiredBounds(text, out var modelBounds))
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_562220c988b04dea969b2dc6cde52015 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					array = (NPointF[])IaiSZkjae13jfITr93y(modelBounds);
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_03ad39fc745d49e3be14e8e100fb0203 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				case 10:
					info.Mode = (PaintTextMode)0;
					num2 = 15;
					continue;
				case 1:
					val = M5XxOMjRY4ro0KQwJIS(organizationShape);
					num2 = 19;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_05864899c47d415d8fae32c68fb25d39 == 0)
					{
						num2 = 20;
					}
					continue;
				case 2:
					return false;
				case 20:
					((NMatrix2DF)(ref val)).TransformPoints(array);
					num2 = 9;
					continue;
				default:
					return false;
				case 11:
					if ((int)mode != 1)
					{
						num2 = 3;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_97ec140e839b4bd5a711912170945a29 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 14;
				case 17:
					info = default(NTextPaintInfo);
					num = 16;
					break;
				case 9:
					((NTextPaintInfo)(ref info)).InitFromBasisPoints(array, true);
					num = 4;
					break;
				case 12:
					text += (string)vh8lQTjZqVFXIecblH2(0xCD88DD8 ^ 0xCD8C0D2);
					num2 = 18;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4ca2baab70e44d2ca8271afba4c9a72d != 0)
					{
						num2 = 18;
					}
					continue;
				case 19:
					if (orLDE8jHArmHqx7Qsdd(text, PS9KYxjjJFrqLoStqJV(text) - 1) != '\r')
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6b49024d17a94a69b2948ac938d43b7c == 0)
						{
							num2 = 7;
						}
						continue;
					}
					goto case 12;
				case 7:
					if (orLDE8jHArmHqx7Qsdd(text, PS9KYxjjJFrqLoStqJV(text) - 1) == '\n')
					{
						num2 = 12;
						continue;
					}
					goto case 13;
				case 14:
					info.Mode = (PaintTextMode)1;
					num2 = 3;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_03ad39fc745d49e3be14e8e100fb0203 != 0)
					{
						num2 = 8;
					}
					continue;
				case 4:
					mode = ((NBoundsLabel)this).get_Mode();
					num2 = 6;
					continue;
				}
				break;
			}
		}
	}

	private static NPointF[] GetPoints(NRectangleF rect)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		return (NPointF[])(object)new NPointF[3]
		{
			((NRectangleF)(ref rect)).get_Center(),
			new NPointF(rect.X, rect.Y),
			new NPointF(((NRectangleF)(ref rect)).get_Right(), rect.Y)
		};
	}

	internal static void GUhnc9j6dN7l8mF1pPo()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}

	internal static void pWYKnhjlBDitGYEk48t(object P_0, object P_1)
	{
		((NStyleableElement)P_0).set_Style((NStyle)P_1);
	}

	internal static object b2BFfQjNObNUZBKYsYM(object P_0)
	{
		return ((NStyleableElement)P_0).get_Style();
	}

	internal static object vh8lQTjZqVFXIecblH2(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool vMYAGYjiIQ6pMT66iyG()
	{
		return JahL7xjnuR7BtNRH7Wd == null;
	}

	internal static OrgShapeLabel gtG4sHj7lcwd65Xsfkx()
	{
		return JahL7xjnuR7BtNRH7Wd;
	}

	internal static void dqnFyFjxfdCYbMG094M(object P_0, object P_1)
	{
		((NStyle)P_0).set_TextStyle((NTextStyle)P_1);
	}

	internal static object u9lFj0jBDZQC77ShDly(object P_0)
	{
		return ((NLabel)P_0).get_Text();
	}

	internal static NMargins kiINwqjuYHJSmcKo6ac(object P_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NBoundsLabel)P_0).get_Margins();
	}

	internal static Guid zMMkigjmpN49QwL9ySc(object P_0)
	{
		return ((NLabel)P_0).get_AnchorUniqueId();
	}

	internal static object y6DkZTje9N1y8V8KnfR(object P_0, Guid P_1)
	{
		return ((NLabel)P_0).GetAnchorModel(P_1);
	}

	internal static bool CjYjGYjLg2n5IFwEuNW(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static int PS9KYxjjJFrqLoStqJV(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static char orLDE8jHArmHqx7Qsdd(object P_0, int P_1)
	{
		return ((string)P_0)[P_1];
	}

	internal static object IaiSZkjae13jfITr93y(NRectangleF rect)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return GetPoints(rect);
	}

	internal static NMatrix2DF M5XxOMjRY4ro0KQwJIS(object P_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NTransformableElement)P_0).get_WorldTransform();
	}
}
