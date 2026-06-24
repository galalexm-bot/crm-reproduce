using System;
using System.Drawing;
using j3AmrhgkCleVTGdEwA;
using Nevron.Diagram;
using Nevron.Dom;
using Nevron.GraphicsCore;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Diagrams.Shapes;

[Serializable]
public abstract class OrganizationShape : NCompositeShape
{
	private Color strokeColor;

	private Color fillColor;

	private OrgShapeMode mode;

	private static OrganizationShape rqm5EbLG1sE1ZXST1Nl;

	protected Color StrokeColor => strokeColor;

	protected Color FillColor => fillColor;

	public OrganizationShape()
	{
		//Discarded unreachable code: IL_002b, IL_0030
		F6r2T8LEhfAlMFEW0IJ();
		this._002Ector(OrgShapeMode.Main);
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_98c0ec8bd6124c50b29441c60f6a53bf == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public OrganizationShape(OrgShapeMode mode)
	{
		//Discarded unreachable code: IL_002a, IL_002f, IL_00be
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected O, but got Unknown
		F6r2T8LEhfAlMFEW0IJ();
		((NCompositeShape)this)._002Ector();
		int num = 5;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_03ad39fc745d49e3be14e8e100fb0203 == 0)
		{
			num = 2;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 8:
				nXiLcELIERShVT6sg7G(((NStyleableElement)this).get_Style(), (object)new NStrokeStyle(strokeColor));
				num = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e2203cd019614c439eaf162fdd0eb05d == 0)
				{
					num = 2;
				}
				break;
			case 2:
				((NStrokeStyle)k7P2FvL4g17M3UqCEEe(((NStyleableElement)this).get_Style())).set_Width(new NLength(2));
				num = 7;
				break;
			case 3:
				return;
			case 5:
				_ = 2;
				num = 3;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2f11eccd7e8f4339a0b03ad9fe1eb947 != 0)
				{
					num = 4;
				}
				break;
			case 9:
				FxlrwtLVrhZesM4dFtf(this);
				num = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a33ec05b36714591b0adf150b655c9a8 == 0)
				{
					num = 0;
				}
				break;
			case 7:
				AddProtection();
				num = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7fbc19cae8c8414894251bb8ae24a12e != 0)
				{
					num = 1;
				}
				break;
			case 1:
				if (mode != 0)
				{
					num = 3;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f5cf5deab67c429f89caddff1f348afc != 0)
					{
						num = 0;
					}
					break;
				}
				goto case 9;
			case 10:
				jtCPdvLYWrBGqj9wgOK(hWmWh0Lsn6RZ2fn1qny(this), (object)new NColorFillStyle(fillColor));
				num = 8;
				break;
			case 0:
				return;
			case 4:
				strokeColor = mode switch
				{
					OrgShapeMode.Preview => HABounLD3uLC07MphZH(), 
					OrgShapeMode.Main => Color.Gray, 
					_ => Color.LightGreen, 
				};
				num = 6;
				break;
			case 6:
				fillColor = mode switch
				{
					OrgShapeMode.Preview => Bff2evLMtgKP5nodaqf(248, 248, 248), 
					OrgShapeMode.Main => Bff2evLMtgKP5nodaqf(240, 240, 240), 
					_ => Color.FromArgb(248, 255, 248), 
				};
				num = 8;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4b1278f673174e87a9fb6665eab69fc6 == 0)
				{
					num = 10;
				}
				break;
			}
		}
	}

	public virtual void AddProtection()
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		int num = 6;
		int num2 = num;
		NAbilities val = default(NAbilities);
		NInteractionStyle interactionStyle = default(NInteractionStyle);
		while (true)
		{
			switch (num2)
			{
			case 7:
				return;
			case 5:
				((NAbilities)(ref val)).set_ResizeX(true);
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e2be4970ad4d405ab7ed74c6b68c9f7d == 0)
				{
					num2 = 3;
				}
				break;
			case 3:
				((NAbilities)(ref val)).set_ResizeY(true);
				num2 = 8;
				break;
			case 4:
				((NShape)this).set_InteractionStyle(interactionStyle);
				num2 = 7;
				break;
			case 8:
				((NAbilities)(ref val)).set_InplaceEdit(false);
				num2 = 2;
				break;
			default:
				((NInteractionStyle)(ref interactionStyle)).set_Mask((InteractionStyleMask)0);
				num2 = 4;
				break;
			case 1:
				interactionStyle = ((NShape)this).get_InteractionStyle();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0f3686d2211943308639c187009d1b4a != 0)
				{
					num2 = 0;
				}
				break;
			case 6:
				val = RUZXgKLQFyafnx3DV8t(this);
				num2 = 3;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a1a646659a464f3fa5c9aedc64725d72 == 0)
				{
					num2 = 5;
				}
				break;
			case 2:
				oVtHA5LdUQ1x912OITl(this, val);
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6370a8f224e7416eb3575ae34b77f5e3 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	protected override void CreateDefaultLabels()
	{
		//Discarded unreachable code: IL_005e, IL_006d
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		int num = 3;
		int num2 = num;
		OrgShapeLabel orgShapeLabel = default(OrgShapeLabel);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				if (mode != 0)
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f5cf5deab67c429f89caddff1f348afc == 0)
					{
						num2 = 2;
					}
					continue;
				}
				break;
			case 2:
				return;
			case 5:
				fCA4uTLgxobS7hjBpKF(vyffCyLTjGMI2asjXRo(this), orgShapeLabel);
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4162f809c129429a9879671f23845052 != 0)
				{
					num2 = 1;
				}
				continue;
			case 1:
				lDBMcvLr7FmMJEm4nvs(vyffCyLTjGMI2asjXRo(this), l3gWTAL8IwC5QUYQGtd(orgShapeLabel));
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5ae6a44bd52345c5bcadd62b7063c7d9 == 0)
				{
					num2 = 0;
				}
				continue;
			case 0:
				return;
			case 4:
				break;
			}
			orgShapeLabel = new OrgShapeLabel("", Guid.Empty, NMargins.Empty);
			num2 = 5;
		}
	}

	public virtual void AddPorts()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				AddPort(ContentAlignment.MiddleLeft, (string)jkrBjvL3IZs0WepuBUO(0x6A336151 ^ 0x6A332DA3));
				num2 = 4;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_31b4b139e534452696f4bfdfc16f1b03 == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 2:
				AddPort(ContentAlignment.TopCenter, (string)jkrBjvL3IZs0WepuBUO(0x738E3073 ^ 0x738E7C8B));
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b496c4412b534db6beb066c8296e663d == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				AddPort(ContentAlignment.BottomRight, (string)jkrBjvL3IZs0WepuBUO(-737960346 ^ -737946782));
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4162f809c129429a9879671f23845052 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				AddPort(ContentAlignment.BottomCenter, (string)jkrBjvL3IZs0WepuBUO(0x6547C338 ^ 0x65478FC6));
				num2 = 3;
				break;
			}
		}
	}

	public void AddPort(ContentAlignment align, string name)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
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
				AddPort(new NContentAlignment(align), name);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_01fd90314ba945f0a4ee79d2372961e2 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void AddPort(float percX, float percY, string name)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				AddPort(new NContentAlignment(percX, percY), name);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_288a03909ebe4f56a0d34bfce957098b != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public void AddPort(NContentAlignment align, string name)
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_006c: Expected O, but got Unknown
		int num = 3;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					goto end_IL_0012;
				case 1:
				{
					object obj = QTNfwdLbSsFoFuQTJOR(this);
					NRotatedBoundsPort val = new NRotatedBoundsPort(l3gWTAL8IwC5QUYQGtd(this), align);
					ce5We1LSgIFS4cJGmGS((object)val, name);
					fCA4uTLgxobS7hjBpKF(obj, (object)val);
					num2 = 5;
					continue;
				}
				case 3:
					if (((NShape)this).get_Ports() == null)
					{
						num2 = 2;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_308690af1b2f43b9a97bf91d774a6420 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					break;
				case 4:
					return;
				case 2:
					((NShape)this).CreateShapeElements((ShapeElementsMask)2);
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4ca2baab70e44d2ca8271afba4c9a72d == 0)
					{
						num2 = 0;
					}
					continue;
				}
				DRv3mULyZgetlePKlqF(((NShape)this).get_Ports(), false);
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0d00d0d8fcd5481b8bdc09ec82b1ea36 == 0)
				{
					num2 = 1;
				}
				continue;
				end_IL_0012:
				break;
			}
			DRv3mULyZgetlePKlqF(QTNfwdLbSsFoFuQTJOR(this), true);
			num = 4;
		}
	}

	internal static void F6r2T8LEhfAlMFEW0IJ()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}

	internal static bool pyBlLrLFntwGe5IC8u7()
	{
		return rqm5EbLG1sE1ZXST1Nl == null;
	}

	internal static OrganizationShape TRitdpL0sLYbhF7jyRc()
	{
		return rqm5EbLG1sE1ZXST1Nl;
	}

	internal static Color HABounLD3uLC07MphZH()
	{
		return Color.Silver;
	}

	internal static Color Bff2evLMtgKP5nodaqf(int P_0, int P_1, int P_2)
	{
		return Color.FromArgb(P_0, P_1, P_2);
	}

	internal static object hWmWh0Lsn6RZ2fn1qny(object P_0)
	{
		return ((NStyleableElement)P_0).get_Style();
	}

	internal static void jtCPdvLYWrBGqj9wgOK(object P_0, object P_1)
	{
		((NStyle)P_0).set_FillStyle((NFillStyle)P_1);
	}

	internal static void nXiLcELIERShVT6sg7G(object P_0, object P_1)
	{
		((NStyle)P_0).set_StrokeStyle((NStrokeStyle)P_1);
	}

	internal static object k7P2FvL4g17M3UqCEEe(object P_0)
	{
		return ((NStyle)P_0).get_StrokeStyle();
	}

	internal static void FxlrwtLVrhZesM4dFtf(object P_0)
	{
		((OrganizationShape)P_0).AddPorts();
	}

	internal static NAbilities RUZXgKLQFyafnx3DV8t(object P_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NDiagramElement)P_0).get_Protection();
	}

	internal static void oVtHA5LdUQ1x912OITl(object P_0, NAbilities P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((NDiagramElement)P_0).set_Protection(P_1);
	}

	internal static object vyffCyLTjGMI2asjXRo(object P_0)
	{
		return ((NShape)P_0).get_Labels();
	}

	internal static void fCA4uTLgxobS7hjBpKF(object P_0, object P_1)
	{
		((NDiagramElementCollection)P_0).AddChild((INNode)P_1);
	}

	internal static Guid l3gWTAL8IwC5QUYQGtd(object P_0)
	{
		return ((NDiagramElement)P_0).get_UniqueId();
	}

	internal static void lDBMcvLr7FmMJEm4nvs(object P_0, Guid P_1)
	{
		((NLabelCollection)P_0).set_DefaultLabelUniqueId(P_1);
	}

	internal static object jkrBjvL3IZs0WepuBUO(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void DRv3mULyZgetlePKlqF(object P_0, bool P_1)
	{
		((NDiagramElementCollection)P_0).set_AutoGenerateUniqueNames(P_1);
	}

	internal static object QTNfwdLbSsFoFuQTJOR(object P_0)
	{
		return ((NShape)P_0).get_Ports();
	}

	internal static void ce5We1LSgIFS4cJGmGS(object P_0, object P_1)
	{
		((NDiagramElement)P_0).set_Name((string)P_1);
	}
}
