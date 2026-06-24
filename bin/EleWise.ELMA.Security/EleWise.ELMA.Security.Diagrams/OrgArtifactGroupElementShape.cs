using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;
using Nevron;
using Nevron.Diagram;
using Nevron.Dom;
using Nevron.GraphicsCore;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Diagrams.Shapes;

[Serializable]
public class OrgArtifactGroupElementShape : NCompositeShape
{
	private Color fillColor;

	private OrgShapeMode mode;

	internal static OrgArtifactGroupElementShape dBDarJeGntTxuHCwNUK;

	protected virtual Color StartColor => REiIpsL587iQ1ScKPSr();

	protected virtual float StrokeWidth => 2f;

	private float DefaultWidth
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
				case 0:
					return;
				case 1:
					_003CDefaultWidth_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f791092a54884ca2ab7376df2d89215c == 0)
					{
						num2 = 0;
					}
					break;
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
				case 1:
					_003CDefaultHeight_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6949750552fc4dcdbaec6842e5667482 == 0)
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

	protected virtual float Radius => 8f;

	public OrgArtifactGroupElementShape()
	{
		//Discarded unreachable code: IL_002b, IL_0030
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		this._002Ector(OrgShapeMode.Main);
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_03ad39fc745d49e3be14e8e100fb0203 == 0)
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
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected O, but got Unknown
		int num = 7;
		int num2 = num;
		NStyle val2 = default(NStyle);
		NBoundsLabel val = default(NBoundsLabel);
		while (true)
		{
			switch (num2)
			{
			case 8:
				yM21LXeIlBsKORbj148(fZjeusesGH8H30XoEoP(val2), new NPointL(0, -3));
				num2 = 3;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2df53c26a6094060a56f82d6cf94e7da == 0)
				{
					num2 = 4;
				}
				break;
			case 2:
				return;
			case 7:
				if (mode != 0)
				{
					return;
				}
				num2 = 6;
				break;
			case 5:
				val2 = new NStyle();
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c78060c4cac8419092e4610bf7a03750 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				hKDIqIeMWTm9Y5vQeFd(val2, (object)new NTextStyle(new Font((string)APLpy8eE4fFwFxUaWWK(0x71CDF2F ^ 0x71C93F1), 13f), pTXagNeDa2ikCfVZPkk(95, 95, 95)));
				num2 = 9;
				break;
			case 6:
				val = new NBoundsLabel(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x11C59687 ^ 0x11C5B7E7), Guid.Empty, NMargins.Empty);
				num2 = 5;
				break;
			case 9:
				((NStringFormatStyle)P7jeypeYE17y5ALOBLW(fZjeusesGH8H30XoEoP(val2))).set_VertAlign((VertAlign)2);
				num2 = 8;
				break;
			case 3:
				YgIGDueV4CN3cXIEHXk(IpbrBxe4TXh9cqfI36B(this), val);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0a82cc1379bc48bbb836c94da8cb8564 == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				((NStyleableElement)val).set_Style(val2);
				num2 = 3;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_06e91bc1320c425bb120c2fac8d1e3be != 0)
				{
					num2 = 2;
				}
				break;
			default:
				ptKtbfeQ1NjBchUi7GN(((NShape)this).get_Labels(), ((NDiagramElement)val).get_UniqueId());
				num2 = 2;
				break;
			}
		}
	}

	public OrgArtifactGroupElementShape(OrgShapeMode mode)
	{
		//Discarded unreachable code: IL_001a, IL_001f
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected O, but got Unknown
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected O, but got Unknown
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Expected O, but got Unknown
		G4GrdYedIm0DIV9YMTL();
		((NCompositeShape)this)._002Ector();
		int num = 12;
		NCustomPath val = default(NCustomPath);
		NStyle val2 = default(NStyle);
		while (true)
		{
			switch (num)
			{
			case 4:
				DefaultWidth = 164f;
				num = 5;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_61a610c13d6d47c8947a4d2d4016147a == 0)
				{
					num = 8;
				}
				break;
			case 2:
				((NDiagramElementCollection)((NCompositeShape)this).get_Primitives()).AddChild((INNode)(object)val);
				num = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5adff34accb14bd183b62ef1a2f5f964 == 0)
				{
					num = 3;
				}
				break;
			case 8:
				Hc7XkOeg7k4MLoBn9la(this, (RouteObstacleType)1);
				num = 11;
				break;
			case 3:
				Xf64nxLp1ClEwx28GAW(this);
				num = 10;
				break;
			case 11:
				val = new NCustomPath((GraphicsPath)Kf1mH2e3QLb4STmt1yy(0f, 0f, DefaultWidth, STL7Mye8cwEqOntqUEq(this), XQFeb7erQOlB5vmcnMv(this)), (PathType)1);
				num = 7;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0f87584a8fee4f91864943acbd35d6d6 == 0)
				{
					num = 6;
				}
				break;
			case 13:
				((NStrokeStyle)AORxjnefwTGft6OQDeT(val2)).set_CustomPattern(65304);
				num = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0dd863774da04dfd9f21706b4b60a6b9 == 0)
				{
					num = 0;
				}
				break;
			case 9:
				suJRJ2e1OWkBxf8lPgC(AORxjnefwTGft6OQDeT(val2), (LinePattern)65383);
				num = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_308690af1b2f43b9a97bf91d774a6420 != 0)
				{
					num = 1;
				}
				break;
			case 7:
				val2 = new NStyle();
				num = 6;
				break;
			case 5:
				NRW6eke9eNZydVctUl5(val2, (object)new NStrokeStyle(StrokeWidth, AMjQxKeSQdNylM00chI()));
				num = 9;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a33ec05b36714591b0adf150b655c9a8 == 0)
				{
					num = 5;
				}
				break;
			case 12:
				KYCyLDeTb9L7uwgqPvV(this, 96f);
				num = 4;
				break;
			case 10:
				return;
			case 1:
				I0UKdyez6LF54Zqb6ij(val2.get_StrokeStyle(), 1);
				num = 13;
				break;
			case 6:
				crx5XUeb5FKbqEIO2GD(val2, (object)new NColorFillStyle(ECY8Pwey7IDRvnBlavb()));
				num = 5;
				break;
			default:
				IucKchLkbTS7VICEb7X(val, val2);
				num = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_daaf990ff0c644fb99cfba0a043a9b93 == 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	private static GraphicsPath CreatePath(float x, float y, float w, float h, float radius)
	{
		int num = 3;
		int num2 = num;
		float num4 = default(float);
		float num3 = default(float);
		float num5 = default(float);
		while (true)
		{
			switch (num2)
			{
			case 2:
				num4 = x + w - num3;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_364662b38d3b4bdb9f3f1f11b8889cdc == 0)
				{
					num2 = 0;
				}
				break;
			default:
				num5 = y + h - num3;
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_bed74a20bc6648fab6800acd64e4559d != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
			{
				GraphicsPath graphicsPath = new GraphicsPath();
				cVlfRMLAJH43W6YeNfk(graphicsPath, num4, num5, num3, num3, 0f, 90f);
				cVlfRMLAJH43W6YeNfk(graphicsPath, x, num5, num3, num3, 90f, 90f);
				cVlfRMLAJH43W6YeNfk(graphicsPath, x, y, num3, num3, 180f, 90f);
				graphicsPath.AddArc(num4, y, num3, num3, 270f, 90f);
				EmsP5nLWvqEhC3Ex9B6(graphicsPath);
				return graphicsPath;
			}
			case 3:
				num3 = radius * 2f;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b128c216f9744fbcbc93a88cbe7b4554 == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	internal static bool WVSfWeeFMwRdlkFH7AP()
	{
		return dBDarJeGntTxuHCwNUK == null;
	}

	internal static OrgArtifactGroupElementShape NUuqxXe0RlvFIdXWcli()
	{
		return dBDarJeGntTxuHCwNUK;
	}

	internal static object APLpy8eE4fFwFxUaWWK(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static Color pTXagNeDa2ikCfVZPkk(int P_0, int P_1, int P_2)
	{
		return Color.FromArgb(P_0, P_1, P_2);
	}

	internal static void hKDIqIeMWTm9Y5vQeFd(object P_0, object P_1)
	{
		((NStyle)P_0).set_TextStyle((NTextStyle)P_1);
	}

	internal static object fZjeusesGH8H30XoEoP(object P_0)
	{
		return ((NStyle)P_0).get_TextStyle();
	}

	internal static object P7jeypeYE17y5ALOBLW(object P_0)
	{
		return ((NTextStyle)P_0).get_StringFormatStyle();
	}

	internal static void yM21LXeIlBsKORbj148(object P_0, NPointL P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((NTextStyle)P_0).set_Offset(P_1);
	}

	internal static object IpbrBxe4TXh9cqfI36B(object P_0)
	{
		return ((NShape)P_0).get_Labels();
	}

	internal static void YgIGDueV4CN3cXIEHXk(object P_0, object P_1)
	{
		((NDiagramElementCollection)P_0).AddChild((INNode)P_1);
	}

	internal static void ptKtbfeQ1NjBchUi7GN(object P_0, Guid P_1)
	{
		((NLabelCollection)P_0).set_DefaultLabelUniqueId(P_1);
	}

	internal static void G4GrdYedIm0DIV9YMTL()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}

	internal static void KYCyLDeTb9L7uwgqPvV(object P_0, float value)
	{
		((OrgArtifactGroupElementShape)P_0).DefaultHeight = value;
	}

	internal static void Hc7XkOeg7k4MLoBn9la(object P_0, RouteObstacleType P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((NShape)P_0).set_RouteObstacleType(P_1);
	}

	internal static float STL7Mye8cwEqOntqUEq(object P_0)
	{
		return ((OrgArtifactGroupElementShape)P_0).DefaultHeight;
	}

	internal static float XQFeb7erQOlB5vmcnMv(object P_0)
	{
		return ((OrgArtifactGroupElementShape)P_0).Radius;
	}

	internal static object Kf1mH2e3QLb4STmt1yy(float x, float y, float w, float h, float radius)
	{
		return CreatePath(x, y, w, h, radius);
	}

	internal static Color ECY8Pwey7IDRvnBlavb()
	{
		return Color.Transparent;
	}

	internal static void crx5XUeb5FKbqEIO2GD(object P_0, object P_1)
	{
		((NStyle)P_0).set_FillStyle((NFillStyle)P_1);
	}

	internal static Color AMjQxKeSQdNylM00chI()
	{
		return Color.Silver;
	}

	internal static void NRW6eke9eNZydVctUl5(object P_0, object P_1)
	{
		((NStyle)P_0).set_StrokeStyle((NStrokeStyle)P_1);
	}

	internal static object AORxjnefwTGft6OQDeT(object P_0)
	{
		return ((NStyle)P_0).get_StrokeStyle();
	}

	internal static void suJRJ2e1OWkBxf8lPgC(object P_0, LinePattern P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((NStrokeStyle)P_0).set_Pattern(P_1);
	}

	internal static void I0UKdyez6LF54Zqb6ij(object P_0, int P_1)
	{
		((NStrokeStyle)P_0).set_Factor(P_1);
	}

	internal static void IucKchLkbTS7VICEb7X(object P_0, object P_1)
	{
		((NStyleableElement)P_0).set_Style((NStyle)P_1);
	}

	internal static bool Xf64nxLp1ClEwx28GAW(object P_0)
	{
		return ((NAggregateModel)P_0).UpdateModelBounds();
	}

	internal static Color REiIpsL587iQ1ScKPSr()
	{
		return Color.White;
	}

	internal static void cVlfRMLAJH43W6YeNfk(object P_0, float P_1, float P_2, float P_3, float P_4, float P_5, float P_6)
	{
		((GraphicsPath)P_0).AddArc(P_1, P_2, P_3, P_4, P_5, P_6);
	}

	internal static void EmsP5nLWvqEhC3Ex9B6(object P_0)
	{
		((GraphicsPath)P_0).CloseAllFigures();
	}
}
