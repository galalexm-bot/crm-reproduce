using System;
using System.Drawing;
using j3AmrhgkCleVTGdEwA;
using Nevron.Diagram;
using Nevron.Dom;

namespace EleWise.ELMA.Security.Diagrams.Shapes;

[Serializable]
public class EmployeeGroupShape : OrganizationShape
{
	internal static EmployeeGroupShape c25ZIxLmPDsDdoXi1sM;

	public EmployeeGroupShape()
	{
		//Discarded unreachable code: IL_002b, IL_0030
		UjGNLYLjX8d28hAEFoo();
		this._002Ector(OrgShapeMode.Main);
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_39d15279765e4050b24c0f7d69df46db == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public EmployeeGroupShape(OrgShapeMode mode)
	{
		//Discarded unreachable code: IL_001b, IL_0020
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		UjGNLYLjX8d28hAEFoo();
		base._002Ector(mode);
		int num = 5;
		float num2 = default(float);
		NRectanglePath val = default(NRectanglePath);
		while (true)
		{
			switch (num)
			{
			case 5:
				num2 = 1f;
				num = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_98c0ec8bd6124c50b29441c60f6a53bf == 0)
				{
					num = 0;
				}
				break;
			case 8:
				return;
			case 9:
				_ = 2;
				num = 3;
				break;
			case 7:
				N3YGC4L282NooKPEUyj(this);
				num = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_147eeadb328044dda63bf8b1037653db == 0)
				{
					num = 4;
				}
				break;
			case 6:
				YrbrgjLwU9hYETuAxPZ(((NCompositeShape)this).get_Primitives(), 4f * num2, 8f * num2, 0.75f * num2, base.StrokeColor, base.FillColor);
				num = 7;
				break;
			case 3:
				OrganizationShapes.RenderSmallHumanShape((NPrimitiveModelCollection)OEDV2KLHlgqfNyS9FQG(this), 0f, 0f, 1f * num2, base.StrokeColor, base.FillColor);
				num = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c843c5b509d748f086ceb6be01690351 == 0)
				{
					num = 1;
				}
				break;
			default:
				val = new NRectanglePath(0f, 0f, 32f * num2, 32f * num2);
				num = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1e79fb186de547eaaa37d66745fc7b90 == 0)
				{
					num = 2;
				}
				break;
			case 4:
				U5o4BpLPm4sPesSgY86(OEDV2KLHlgqfNyS9FQG(this), val);
				num = 5;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c3d852ec782a44099f926fd43a0da6df == 0)
				{
					num = 8;
				}
				break;
			case 2:
				TBe0nHLaFK3LVtv9cJf(OEDV2KLHlgqfNyS9FQG(this), val);
				num = 9;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1e79fb186de547eaaa37d66745fc7b90 == 0)
				{
					num = 2;
				}
				break;
			case 1:
				KjMHlSLRLRQlcEVd7Q2(((NCompositeShape)this).get_Primitives(), 15f * num2, 0f, 1f * num2, base.StrokeColor, base.FillColor);
				num = 6;
				break;
			}
		}
	}

	internal static void UjGNLYLjX8d28hAEFoo()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}

	internal static bool neygk4LeU0fgPWt8WuV()
	{
		return c25ZIxLmPDsDdoXi1sM == null;
	}

	internal static EmployeeGroupShape Cdn5CsLLc4x2lXIajBB()
	{
		return c25ZIxLmPDsDdoXi1sM;
	}

	internal static object OEDV2KLHlgqfNyS9FQG(object P_0)
	{
		return ((NCompositeShape)P_0).get_Primitives();
	}

	internal static void TBe0nHLaFK3LVtv9cJf(object P_0, object P_1)
	{
		((NDiagramElementCollection)P_0).AddChild((INNode)P_1);
	}

	internal static void KjMHlSLRLRQlcEVd7Q2(object P_0, float dx, float dy, float scale, Color strokeColor, Color fillColor)
	{
		OrganizationShapes.RenderSmallHumanShape((NPrimitiveModelCollection)P_0, dx, dy, scale, strokeColor, fillColor);
	}

	internal static void YrbrgjLwU9hYETuAxPZ(object P_0, float dx, float dy, float scale, Color strokeColor, Color fillColor)
	{
		OrganizationShapes.RenderHumanShape((NPrimitiveModelCollection)P_0, dx, dy, scale, strokeColor, fillColor);
	}

	internal static bool N3YGC4L282NooKPEUyj(object P_0)
	{
		return ((NAggregateModel)P_0).UpdateModelBounds();
	}

	internal static void U5o4BpLPm4sPesSgY86(object P_0, object P_1)
	{
		((NDiagramElementCollection)P_0).RemoveChild((INNode)P_1);
	}
}
