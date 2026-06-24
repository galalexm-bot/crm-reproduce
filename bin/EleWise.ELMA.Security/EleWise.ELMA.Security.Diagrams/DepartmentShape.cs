using System;
using j3AmrhgkCleVTGdEwA;
using Nevron.Diagram;
using Nevron.Dom;
using Nevron.GraphicsCore;

namespace EleWise.ELMA.Security.Diagrams.Shapes;

[Serializable]
public class DepartmentShape : OrganizationShape
{
	private static DepartmentShape QK9teXLXC2s45LtSsp5;

	public DepartmentShape()
	{
		//Discarded unreachable code: IL_002b, IL_0030
		uXIujkL7hYsbae7Rjw8();
		this._002Ector(OrgShapeMode.Main);
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c3d852ec782a44099f926fd43a0da6df != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public DepartmentShape(OrgShapeMode mode)
	{
		//Discarded unreachable code: IL_001b
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected O, but got Unknown
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected O, but got Unknown
		uXIujkL7hYsbae7Rjw8();
		base._002Ector(mode);
		int num = 4;
		NRectanglePath val = default(NRectanglePath);
		NRectanglePath val2 = default(NRectanglePath);
		float num2 = default(float);
		while (true)
		{
			int num3;
			switch (num)
			{
			case 10:
				((NDiagramElementCollection)uATpGkL60S96IdRV8Rp(this)).AddChild((INNode)(object)val);
				num = 2;
				break;
			case 8:
				Smtur5LN6oyZFTWnn3H(val2, (object)new NStyle());
				num3 = 11;
				goto IL_0020;
			case 4:
				num2 = 1f;
				num = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f6614d006512404f8cab65f09d3e1c89 == 0)
				{
					num = 0;
				}
				break;
			default:
				val = new NRectanglePath(0f, 0f, 32f * num2, 32f * num2);
				num = 10;
				break;
			case 1:
				return;
			case 5:
				val2 = new NRectanglePath(12f * num2, 4f * num2, 8f * num2, 4f * num2);
				num = 8;
				break;
			case 11:
				nYWVdjLxApYdOxcAV4n(cJwXKjLZ0O8HcdSLA6y(val2), (object)new NStrokeStyle(base.StrokeColor));
				num = 7;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_76accc62823f4af5a14c51746ed23095 == 0)
				{
					num = 6;
				}
				break;
			case 7:
				UVhtruLlDlb41EQQIw1(uATpGkL60S96IdRV8Rp(this), val2);
				num = 6;
				break;
			case 6:
				((NDiagramElementCollection)uATpGkL60S96IdRV8Rp(this)).AddChild((INNode)new NLinePath(20f * num2, 18f * num2, 23f * num2, 18f * num2));
				num = 3;
				break;
			case 9:
				tZJ8UfLu9WV6lwMOrBb(((NCompositeShape)this).get_Primitives(), val);
				num = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1bc92e0376794fc182b6e366eee82dbd != 0)
				{
					num = 1;
				}
				break;
			case 2:
				UVhtruLlDlb41EQQIw1(uATpGkL60S96IdRV8Rp(this), (object)new NRectanglePath(4f * num2, 0f, 24f * num2, 32f * num2));
				num3 = 5;
				goto IL_0020;
			case 3:
				{
					GSshh8LBiDZTC55jDLI(this);
					num = 9;
					break;
				}
				IL_0020:
				num = num3;
				break;
			}
		}
	}

	internal static void uXIujkL7hYsbae7Rjw8()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}

	internal static bool pUqJs4Ln76K3Cbrcs9t()
	{
		return QK9teXLXC2s45LtSsp5 == null;
	}

	internal static DepartmentShape uc0H22LioR8ufnAD8hI()
	{
		return QK9teXLXC2s45LtSsp5;
	}

	internal static object uATpGkL60S96IdRV8Rp(object P_0)
	{
		return ((NCompositeShape)P_0).get_Primitives();
	}

	internal static void UVhtruLlDlb41EQQIw1(object P_0, object P_1)
	{
		((NDiagramElementCollection)P_0).AddChild((INNode)P_1);
	}

	internal static void Smtur5LN6oyZFTWnn3H(object P_0, object P_1)
	{
		((NStyleableElement)P_0).set_Style((NStyle)P_1);
	}

	internal static object cJwXKjLZ0O8HcdSLA6y(object P_0)
	{
		return ((NStyleableElement)P_0).get_Style();
	}

	internal static void nYWVdjLxApYdOxcAV4n(object P_0, object P_1)
	{
		((NStyle)P_0).set_StrokeStyle((NStrokeStyle)P_1);
	}

	internal static bool GSshh8LBiDZTC55jDLI(object P_0)
	{
		return ((NAggregateModel)P_0).UpdateModelBounds();
	}

	internal static void tZJ8UfLu9WV6lwMOrBb(object P_0, object P_1)
	{
		((NDiagramElementCollection)P_0).RemoveChild((INNode)P_1);
	}
}
