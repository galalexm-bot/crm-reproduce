using System;
using System.Drawing;
using j3AmrhgkCleVTGdEwA;
using Nevron.Diagram;
using Nevron.Dom;

namespace EleWise.ELMA.Security.Diagrams.Shapes;

[Serializable]
public class PositionShape : OrganizationShape
{
	private static PositionShape imTAMtjvE3SdV3aii5m;

	public PositionShape()
	{
		//Discarded unreachable code: IL_002b, IL_0030
		pnpmChjoS3w8FGqmo5s();
		this._002Ector(OrgShapeMode.Main);
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8fd69cd0bea1432ca401d29377c613cc == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public PositionShape(OrgShapeMode mode)
	{
		//Discarded unreachable code: IL_001b, IL_0020
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		pnpmChjoS3w8FGqmo5s();
		base._002Ector(mode);
		int num = 7;
		NRectanglePath val = default(NRectanglePath);
		float num2 = default(float);
		while (true)
		{
			switch (num)
			{
			case 6:
				val = new NRectanglePath(0f, 0f, 32f * num2, 32f * num2);
				num = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_651070b1c9bd4381bbb7379d68d6508e != 0)
				{
					num = 0;
				}
				break;
			case 5:
				return;
			case 4:
				fD6MCXjhcpjp0wY8l81(dkGevsjJXJJYNiANUf8(this), val);
				num = 5;
				break;
			case 1:
				RnMDkUjK5sFHFQBXson(dkGevsjJXJJYNiANUf8(this), val);
				num = 2;
				break;
			case 2:
				_ = 2;
				num = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0ab7ce9a6369414380df24a533da8346 == 0)
				{
					num = 0;
				}
				break;
			default:
				MB5Sy7jtPFGEBB8cUDS(dkGevsjJXJJYNiANUf8(this), 1f, 1f, num2, base.StrokeColor, base.FillColor);
				num = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4162f809c129429a9879671f23845052 != 0)
				{
					num = 3;
				}
				break;
			case 7:
				num2 = 1f;
				num = 6;
				break;
			case 3:
				((NAggregateModel)this).UpdateModelBounds();
				num = 4;
				break;
			}
		}
	}

	internal static void pnpmChjoS3w8FGqmo5s()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}

	internal static bool dUuIvujCyIQHIivfILV()
	{
		return imTAMtjvE3SdV3aii5m == null;
	}

	internal static PositionShape lcmPpyjUapMrELqDldD()
	{
		return imTAMtjvE3SdV3aii5m;
	}

	internal static object dkGevsjJXJJYNiANUf8(object P_0)
	{
		return ((NCompositeShape)P_0).get_Primitives();
	}

	internal static void RnMDkUjK5sFHFQBXson(object P_0, object P_1)
	{
		((NDiagramElementCollection)P_0).AddChild((INNode)P_1);
	}

	internal static void MB5Sy7jtPFGEBB8cUDS(object P_0, float dx, float dy, float scale, Color strokeColor, Color fillColor)
	{
		OrganizationShapes.RenderHumanShape((NPrimitiveModelCollection)P_0, dx, dy, scale, strokeColor, fillColor);
	}

	internal static void fD6MCXjhcpjp0wY8l81(object P_0, object P_1)
	{
		((NDiagramElementCollection)P_0).RemoveChild((INNode)P_1);
	}
}
