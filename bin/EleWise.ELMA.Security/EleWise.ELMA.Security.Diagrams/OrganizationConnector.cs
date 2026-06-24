using System;
using System.Drawing;
using j3AmrhgkCleVTGdEwA;
using Nevron.Diagram;
using Nevron.GraphicsCore;

namespace EleWise.ELMA.Security.Diagrams.Shapes;

[Serializable]
public class OrganizationConnector : NRoutableConnector
{
	private static OrganizationConnector b08EjNLvrZ9L8rfLtxI;

	public OrganizationConnector()
	{
		//Discarded unreachable code: IL_002b, IL_0030
		y6VV1tLohJt9xAqh45e();
		((NRoutableConnector)this)._002Ector((RoutableConnectorType)0);
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d133bac4622e4b5596f3c44ee791169d != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			SetDefaultProperties();
			num = 1;
			if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b6bf1b70a8924e789fc4be8e9aadc953 == 0)
			{
				num = 1;
			}
		}
	}

	public OrganizationConnector(NPointF[] points)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		((NRoutableConnector)this)._002Ector(points);
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6ebd2dabc54f4311bbbe57be8fcccc48 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				SetDefaultProperties();
				num = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_56bc39e908f44451b3cdd0d68828e324 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	private void SetDefaultProperties()
	{
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		//IL_0088: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00dc: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		int num = 5;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				tqFS7CLKZacpqVK8RXi(this, (RerouteAutomatically)2);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_651070b1c9bd4381bbb7379d68d6508e != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			default:
				ISvL8GLOiDPcpVpd9MG(wT3fMyLtkcWsxQ9LvDr(this), (object)new NArrowheadStyle((ArrowheadShape)10, "", new NSizeL(5, 5), (NFillStyle)new NColorFillStyle(Color.Gray), new NStrokeStyle(5f, GNM6HALhfouWqH3RXMF())));
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a3a30dc594d64d20b0419bc3debf22fd != 0)
				{
					num2 = 1;
				}
				break;
			case 5:
				((NDiagramElementCollection)((NShape)this).get_Labels()).RemoveAllChildren();
				num2 = 4;
				break;
			case 1:
				YEoCurLcSDjFQYZagKX(wT3fMyLtkcWsxQ9LvDr(this), (object)new NArrowheadStyle((ArrowheadShape)0, "", MKIo3eLqPf18c3X0Gx0(), (NFillStyle)new NColorFillStyle(), new NStrokeStyle()));
				num2 = 2;
				break;
			case 4:
				HxMCMhLJEDrAN92Nf3o(this, NDR.NameConnectorsStyleSheet);
				num2 = 3;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6370a8f224e7416eb3575ae34b77f5e3 == 0)
				{
					num2 = 3;
				}
				break;
			}
		}
	}

	internal static void y6VV1tLohJt9xAqh45e()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}

	internal static bool NqhtFILCBc7I6S9LtpC()
	{
		return b08EjNLvrZ9L8rfLtxI == null;
	}

	internal static OrganizationConnector y0ysEQLUX9W4Vy40pJP()
	{
		return b08EjNLvrZ9L8rfLtxI;
	}

	internal static void HxMCMhLJEDrAN92Nf3o(object P_0, object P_1)
	{
		((NStyleableElement)P_0).set_StyleSheetName((string)P_1);
	}

	internal static void tqFS7CLKZacpqVK8RXi(object P_0, RerouteAutomatically P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((NRoutableConnector)P_0).set_RerouteAutomatically(P_1);
	}

	internal static object wT3fMyLtkcWsxQ9LvDr(object P_0)
	{
		return ((NStyleableElement)P_0).get_Style();
	}

	internal static Color GNM6HALhfouWqH3RXMF()
	{
		return Color.Black;
	}

	internal static void ISvL8GLOiDPcpVpd9MG(object P_0, object P_1)
	{
		((NStyle)P_0).set_StartArrowheadStyle((NArrowheadStyle)P_1);
	}

	internal static NSizeL MKIo3eLqPf18c3X0Gx0()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return NSizeL.get_Empty();
	}

	internal static void YEoCurLcSDjFQYZagKX(object P_0, object P_1)
	{
		((NStyle)P_0).set_EndArrowheadStyle((NArrowheadStyle)P_1);
	}
}
