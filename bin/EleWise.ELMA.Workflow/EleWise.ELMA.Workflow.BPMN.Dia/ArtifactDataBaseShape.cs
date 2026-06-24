using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Drawing2D;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Artifacts;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Decorators;
using EleWise.ELMA.Workflow.Diagrams.Shapes;
using j3AmrhgkCleVTGdEwA;
using Nevron;
using Nevron.Diagram;
using Nevron.Dom;
using Nevron.GraphicsCore;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes;

[Serializable]
public class ArtifactDataBaseShape : ArtifactTaskShape
{
	private static ArtifactDataBaseShape Mgi5dAOobdcSsfL9aHkb;

	protected virtual Color StartColor => DiBMQKOoCUOaRQ1OGUvk();

	protected virtual Color EndColor => Color.White;

	protected virtual Color StrokeColor => lW1wKNOoMSGwJHdFboWw(178, 184, 192);

	protected virtual float StrokeWidth => 1f;

	protected virtual int ColorAlpha => 255;

	protected virtual float DefaultWidth => 196f;

	protected virtual float DefaultHeight => 80f;

	protected override void CreateDefaultLabels()
	{
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected O, but got Unknown
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		int num = 10;
		NMargins val3 = default(NMargins);
		NStyle val2 = default(NStyle);
		NBoundsLabel val = default(NBoundsLabel);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 10:
					((NMargins)(ref val3))._002Ector(30f, 10f, 0f, 0f);
					num2 = 9;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_545887e65739480a965b7ddfab7d0632 != 0)
					{
						num2 = 7;
					}
					continue;
				case 2:
					val2.set_TextStyle(new NTextStyle(new Font(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-17847711 ^ -17962123), 12f), Color.FromArgb(95, 95, 95)));
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_448e6815cb30438893079dcbb906fd65 != 0)
					{
						num2 = 4;
					}
					continue;
				case 8:
					val2 = new NStyle();
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a27e75af798c48d692c4325f43aa9e6b != 0)
					{
						num2 = 2;
					}
					continue;
				case 1:
					TcnYPlOodWV3laQIDrvv(LY70fPOoPSwq7nxAP6Ks(gwiEpeOocdJTQhxYYNKx(val2)), (HorzAlign)1);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1de08766357542bdb81146373079f817 != 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					nMynmpOoXb9WXJRu1V5N(LY70fPOoPSwq7nxAP6Ks(gwiEpeOocdJTQhxYYNKx(val2)), (VertAlign)1);
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c559093b7320494babd70d164a6df42d == 0)
					{
						num2 = 0;
					}
					continue;
				case 9:
					break;
				case 3:
					((NStyleableElement)val).set_Style(val2);
					num2 = 7;
					continue;
				case 6:
					NMSQoQOoHx56JIvLIWyu(v0hawVOoDtUjOJDDMkcv(this), ak2B2YOontsZJ7k3kWLN(val));
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6fe3beca34a9422e873cd6ef331760ae == 0)
					{
						num2 = 5;
					}
					continue;
				default:
					P0hYwvOoureLHT00k2Dj(val2.get_TextStyle(), new NPointL(0, 0));
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4459fbe344a947429d197733d274ef68 != 0)
					{
						num2 = 3;
					}
					continue;
				case 7:
					((NDiagramElementCollection)((NShape)this).get_Labels()).AddChild((INNode)(object)val);
					num2 = 6;
					continue;
				case 5:
					return;
				}
				break;
			}
			val = new NBoundsLabel((string)PhWZvdOoBXUpkOvnSVRL(-148495695 ^ -148615845), Guid.Empty, val3);
			num = 8;
		}
	}

	public ArtifactDataBaseShape()
	{
		//Discarded unreachable code: IL_001a, IL_001f
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected O, but got Unknown
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected O, but got Unknown
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected O, but got Unknown
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 3;
		NStyle val3 = default(NStyle);
		NAbilities val = default(NAbilities);
		NCustomPath val2 = default(NCustomPath);
		while (true)
		{
			switch (num)
			{
			case 13:
				return;
			case 5:
				val3 = new NStyle();
				num = 8;
				break;
			case 11:
				val = CEQmNeOoTZa3BPBbx6O5(this);
				num = 6;
				break;
			case 6:
				((NAbilities)(ref val)).set_InplaceEdit(true);
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a9be7e056b4e4b6e863b634c418144f1 != 0)
				{
					num = 0;
				}
				break;
			case 1:
				Bf7ZBhOoRjvG4ndCeMRR(val2, val3);
				num = 12;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c447ffb64be44c09b6fd398df506785b != 0)
				{
					num = 1;
				}
				break;
			case 4:
				AddDecorator<ArtifactDataBaseDecorator>(DecoratorPosition.TopLeft);
				num = 13;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f == 0)
				{
					num = 1;
				}
				break;
			case 8:
				val3.set_StrokeStyle(new NStrokeStyle(s9DEJQOoWfhq2D1P6MbN()));
				num = 2;
				break;
			case 10:
				EMBXCKOopx1sOcF8h5Dj(this, (ShapeElementsMask)8);
				num = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4459fbe344a947429d197733d274ef68 == 0)
				{
					num = 2;
				}
				break;
			case 2:
				td8nOfOojUubOuSwdl6D(val3, (object)new NColorFillStyle(Color.Transparent));
				num = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4ef74b4b7d13430e9d2f9b78cbdb367b != 0)
				{
					num = 0;
				}
				break;
			case 3:
				val2 = new NCustomPath((GraphicsPath)lwZVB4Oo9ryWpKJhP7Ct(0f, 0f, PJFsj6OoLu7e9VLaDQOL(this), dNyRZCOofqVp68s23SGD(this)), (PathType)1);
				num = 5;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_448e6815cb30438893079dcbb906fd65 == 0)
				{
					num = 4;
				}
				break;
			case 9:
				QrVVapOo3lbdMKINqiFP(this);
				num = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 == 0)
				{
					num = 11;
				}
				break;
			case 7:
				AddPorts(0f, 0f, PJFsj6OoLu7e9VLaDQOL(this), dNyRZCOofqVp68s23SGD(this));
				num = 10;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e4c570270f54493d8f3f4763a72f63f7 != 0)
				{
					num = 8;
				}
				break;
			case 12:
				kYxvv6OoqPaolvktdoqD(I0ityrOo6w8fRTGVayQJ(this), val2);
				num = 9;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_dcdfd019631e458b9cb5fa34a16a2fe1 == 0)
				{
					num = 0;
				}
				break;
			default:
				LpuTAMOoQ3QorC0qAsNP(this, val);
				num = 7;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 == 0)
				{
					num = 7;
				}
				break;
			}
		}
	}

	public override void UpdateDecorators(Element element)
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
				base.UpdateDecorators(element);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_dcdfd019631e458b9cb5fa34a16a2fe1 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	protected virtual void AddPorts(float x, float y, float w, float h)
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
				ShapeHelper.AddPort((NShape)(object)this, new NContentAlignment(ContentAlignment.MiddleLeft), (string)PhWZvdOoBXUpkOvnSVRL(0x63D6C913 ^ 0x63D79313));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
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
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a23e27b648a042f098a477c26c4beed1 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				num4 = y + h;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7de614af35034bd0a6867d08a2ee4a84 == 0)
				{
					num2 = 0;
				}
				break;
			default:
			{
				GraphicsPath graphicsPath = new GraphicsPath();
				graphicsPath.AddLine(num3, y, x, y);
				rmqU7FOokD6Vwal9WqSv(graphicsPath, x, num4, num3, num4);
				ckoUhrOoUE5tRcePWXlm(graphicsPath);
				return graphicsPath;
			}
			}
		}
	}

	public void AddDecorator<TDecorator>(DecoratorPosition position = DecoratorPosition.Center) where TDecorator : BaseDecorator, new()
	{
		AddDecorator(typeof(TDecorator), position);
	}

	public void AddDecorator(Type decoratorType, DecoratorPosition position = DecoratorPosition.Center)
	{
		//Discarded unreachable code: IL_0056, IL_0065, IL_0070, IL_0097, IL_00bc, IL_00cb, IL_012f, IL_017c
		int num = 1;
		int num2 = num;
		BaseDecorator baseDecorator = default(BaseDecorator);
		IEnumerator enumerator = default(IEnumerator);
		while (true)
		{
			switch (num2)
			{
			case 3:
				baseDecorator = (BaseDecorator)SxSKDSOoFnrdXys4mOjM(decoratorType);
				num2 = 5;
				break;
			case 2:
				return;
			case 4:
				try
				{
					while (true)
					{
						int num3;
						if (!idXgrdOo2GyJjsH81OLA(enumerator))
						{
							num3 = 2;
							goto IL_0074;
						}
						goto IL_00d6;
						IL_0074:
						switch (num3)
						{
						case 3:
							return;
						case 1:
							goto IL_00d6;
						case 2:
							goto end_IL_00a1;
						}
						continue;
						IL_00d6:
						if (A4CGq6Oo7g13AAJJjcte(zEXk7lOoGvEAHxctVawd(enumerator).GetType(), decoratorType))
						{
							return;
						}
						num3 = 4;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd == 0)
						{
							num3 = 3;
						}
						goto IL_0074;
						continue;
						end_IL_00a1:
						break;
					}
				}
				finally
				{
					IDisposable disposable = enumerator as IDisposable;
					int num4 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e8980a9fd9d44c20920ffa276900c96f != 0)
					{
						num4 = 1;
					}
					while (true)
					{
						switch (num4)
						{
						case 2:
							vlmJuhOooqQxTH3hXWk2(disposable);
							num4 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_46e05b4e09174e34a9c81741b8b77a2f == 0)
							{
								num4 = 0;
							}
							continue;
						case 1:
							if (disposable != null)
							{
								num4 = 2;
								continue;
							}
							break;
						case 0:
							break;
						}
						break;
					}
				}
				goto case 3;
			case 6:
				kYxvv6OoqPaolvktdoqD(twZIRKOoVxh12OhU79Xy(this), baseDecorator);
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae2bde9e5844c638021cdb56fc01122 != 0)
				{
					num2 = 2;
				}
				break;
			default:
				enumerator = (IEnumerator)w358O6OoAaUt0916PMjV(twZIRKOoVxh12OhU79Xy(this));
				num2 = 4;
				break;
			case 1:
				if (twZIRKOoVxh12OhU79Xy(this) != null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe7a0ffe67e4fea8e329ae6574ed2ca == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			case 5:
				baseDecorator.Position = position;
				num2 = 6;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_46e05b4e09174e34a9c81741b8b77a2f == 0)
				{
					num2 = 6;
				}
				break;
			}
		}
	}

	protected override void UpdateElementReferences()
	{
		//Discarded unreachable code: IL_0080, IL_008f
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
			case 4:
				gdp6QGOoIsl3ckELelY0(this);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5c45a6e5a4614bfba7591d8a1c7ced1d == 0)
				{
					num2 = 1;
				}
				continue;
			case 3:
				if (((NShape)this).get_Decorators() == null)
				{
					num2 = 2;
					continue;
				}
				break;
			default:
				AddDecorator<ArtifactDataBaseDecorator>(DecoratorPosition.TopLeft);
				num2 = 4;
				continue;
			case 1:
				return;
			case 5:
				break;
			}
			WGbP1FOoifMnDBuveodn(twZIRKOoVxh12OhU79Xy(this));
			num2 = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f05298ca2a4a4a639a58bc7f7d9ff7b9 != 0)
			{
				num2 = 0;
			}
		}
	}

	internal static object PhWZvdOoBXUpkOvnSVRL(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object gwiEpeOocdJTQhxYYNKx(object P_0)
	{
		return ((NStyle)P_0).get_TextStyle();
	}

	internal static object LY70fPOoPSwq7nxAP6Ks(object P_0)
	{
		return ((NTextStyle)P_0).get_StringFormatStyle();
	}

	internal static void nMynmpOoXb9WXJRu1V5N(object P_0, VertAlign P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((NStringFormatStyle)P_0).set_VertAlign(P_1);
	}

	internal static void TcnYPlOodWV3laQIDrvv(object P_0, HorzAlign P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((NStringFormatStyle)P_0).set_HorzAlign(P_1);
	}

	internal static void P0hYwvOoureLHT00k2Dj(object P_0, NPointL P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((NTextStyle)P_0).set_Offset(P_1);
	}

	internal static object v0hawVOoDtUjOJDDMkcv(object P_0)
	{
		return ((NShape)P_0).get_Labels();
	}

	internal static Guid ak2B2YOontsZJ7k3kWLN(object P_0)
	{
		return ((NDiagramElement)P_0).get_UniqueId();
	}

	internal static void NMSQoQOoHx56JIvLIWyu(object P_0, Guid P_1)
	{
		((NLabelCollection)P_0).set_DefaultLabelUniqueId(P_1);
	}

	internal static bool hmdSW1Oo5UYFWc1nH68B()
	{
		return Mgi5dAOobdcSsfL9aHkb == null;
	}

	internal static ArtifactDataBaseShape oZsSm6Oog7Ix7OMkmyXQ()
	{
		return Mgi5dAOobdcSsfL9aHkb;
	}

	internal static float PJFsj6OoLu7e9VLaDQOL(object P_0)
	{
		return ((ArtifactDataBaseShape)P_0).DefaultWidth;
	}

	internal static float dNyRZCOofqVp68s23SGD(object P_0)
	{
		return ((ArtifactDataBaseShape)P_0).DefaultHeight;
	}

	internal static object lwZVB4Oo9ryWpKJhP7Ct(float x, float y, float w, float h)
	{
		return CreatePathBase(x, y, w, h);
	}

	internal static Color s9DEJQOoWfhq2D1P6MbN()
	{
		return Color.Transparent;
	}

	internal static void td8nOfOojUubOuSwdl6D(object P_0, object P_1)
	{
		((NStyle)P_0).set_FillStyle((NFillStyle)P_1);
	}

	internal static void Bf7ZBhOoRjvG4ndCeMRR(object P_0, object P_1)
	{
		((NStyleableElement)P_0).set_Style((NStyle)P_1);
	}

	internal static object I0ityrOo6w8fRTGVayQJ(object P_0)
	{
		return ((NCompositeShape)P_0).get_Primitives();
	}

	internal static void kYxvv6OoqPaolvktdoqD(object P_0, object P_1)
	{
		((NDiagramElementCollection)P_0).AddChild((INNode)P_1);
	}

	internal static bool QrVVapOo3lbdMKINqiFP(object P_0)
	{
		return ((NAggregateModel)P_0).UpdateModelBounds();
	}

	internal static NAbilities CEQmNeOoTZa3BPBbx6O5(object P_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NDiagramElement)P_0).get_Protection();
	}

	internal static void LpuTAMOoQ3QorC0qAsNP(object P_0, NAbilities P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((NDiagramElement)P_0).set_Protection(P_1);
	}

	internal static bool EMBXCKOopx1sOcF8h5Dj(object P_0, ShapeElementsMask P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NShape)P_0).CreateShapeElements(P_1);
	}

	internal static Color DiBMQKOoCUOaRQ1OGUvk()
	{
		return Color.White;
	}

	internal static Color lW1wKNOoMSGwJHdFboWw(int P_0, int P_1, int P_2)
	{
		return Color.FromArgb(P_0, P_1, P_2);
	}

	internal static void rmqU7FOokD6Vwal9WqSv(object P_0, float P_1, float P_2, float P_3, float P_4)
	{
		((GraphicsPath)P_0).AddLine(P_1, P_2, P_3, P_4);
	}

	internal static void ckoUhrOoUE5tRcePWXlm(object P_0)
	{
		((GraphicsPath)P_0).CloseAllFigures();
	}

	internal static object twZIRKOoVxh12OhU79Xy(object P_0)
	{
		return ((NShape)P_0).get_Decorators();
	}

	internal static object w358O6OoAaUt0916PMjV(object P_0)
	{
		return ((NDiagramElementCollection)P_0).GetEnumerator();
	}

	internal static object zEXk7lOoGvEAHxctVawd(object P_0)
	{
		return ((IEnumerator)P_0).Current;
	}

	internal static bool A4CGq6Oo7g13AAJJjcte(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static bool idXgrdOo2GyJjsH81OLA(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void vlmJuhOooqQxTH3hXWk2(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object SxSKDSOoFnrdXys4mOjM(Type P_0)
	{
		return Activator.CreateInstance(P_0);
	}

	internal static void WGbP1FOoifMnDBuveodn(object P_0)
	{
		((NDiagramElementCollection)P_0).RemoveAllChildren();
	}

	internal static void gdp6QGOoIsl3ckELelY0(object P_0)
	{
		((NCompositeShape)P_0).UpdateElementReferences();
	}
}
