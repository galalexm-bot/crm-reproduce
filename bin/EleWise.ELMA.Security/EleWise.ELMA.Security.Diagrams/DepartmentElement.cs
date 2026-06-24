using System;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Security.Diagrams.Shapes;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Diagrams.Elements;

[Serializable]
[Shape(typeof(DepartmentShape))]
public class DepartmentElement : OrganizationElement
{
	private static DepartmentElement wgo9VMjTeYUPjAMH3NM;

	public override void InitNew()
	{
		int num = 4;
		int num2 = num;
		PositionElement positionElement = default(PositionElement);
		EmployeeGroupElement item = default(EmployeeGroupElement);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 4:
				base.InitNew();
				num2 = 3;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_443cb30a1c3f4e72a61ec4f52377fcc7 == 0)
				{
					num2 = 2;
				}
				break;
			case 3:
			{
				PositionElement positionElement2 = new PositionElement();
				hcgvwAj3GUtJMJmmIXG(positionElement2, kPqwJVjrOcD0BoxDSty());
				positionElement2.IsChief = true;
				BYaf4djSUBhP4RgOGeI(positionElement2, NRjesLjbOTYfdqqFubL(hhy22YjyXkiVb4lDV91(0x9D1442B ^ 0x9D1093B)));
				positionElement = positionElement2;
				num2 = 2;
				break;
			}
			case 5:
			{
				EmployeeGroupElement employeeGroupElement = new EmployeeGroupElement();
				hcgvwAj3GUtJMJmmIXG(employeeGroupElement, kPqwJVjrOcD0BoxDSty());
				BYaf4djSUBhP4RgOGeI(employeeGroupElement, NRjesLjbOTYfdqqFubL(hhy22YjyXkiVb4lDV91(-816887841 ^ -816903453)));
				item = employeeGroupElement;
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_df5466d729844e8ea757565832a01037 == 0)
				{
					num2 = 0;
				}
				break;
			}
			case 2:
				base.Composition.Add(positionElement);
				num2 = 5;
				break;
			case 1:
				positionElement.Composition.Add(item);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fe0eedb8ce484402a5c9a74346556b9f == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public DepartmentElement()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		oVVonZj9BhLPQqLCrPJ();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e2203cd019614c439eaf162fdd0eb05d == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Guid kPqwJVjrOcD0BoxDSty()
	{
		return Guid.NewGuid();
	}

	internal static void hcgvwAj3GUtJMJmmIXG(object P_0, Guid P_1)
	{
		((Element)P_0).Uid = P_1;
	}

	internal static object hhy22YjyXkiVb4lDV91(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object NRjesLjbOTYfdqqFubL(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static void BYaf4djSUBhP4RgOGeI(object P_0, object P_1)
	{
		((Element)P_0).Name = (string)P_1;
	}

	internal static bool ztrsw8jgXqGZIKgePEH()
	{
		return wgo9VMjTeYUPjAMH3NM == null;
	}

	internal static DepartmentElement xoWp8tj8lM8A8K40MQC()
	{
		return wgo9VMjTeYUPjAMH3NM;
	}

	internal static void oVVonZj9BhLPQqLCrPJ()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}
}
