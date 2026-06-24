using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Diagrams;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security.Diagrams.Elements;

[Serializable]
public abstract class OrganizationElement : Element2D
{
	private List<OrganizationElement> composition;

	private static OrganizationElement GLfTTBHpZCcpomihIZl;

	public string EmployeeCount
	{
		[CompilerGenerated]
		get
		{
			return _003CEmployeeCount_003Ek__BackingField;
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
					_003CEmployeeCount_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_66aae9daa3f84bb5931ed90b4759f85c != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public List<OrganizationElement> Composition
	{
		get
		{
			return composition;
		}
		set
		{
			composition = value;
		}
	}

	public IList<OrganizationElement> GetChildElements()
	{
		List<OrganizationElement> list = new List<OrganizationElement>();
		if (base.OutputConnectors != null)
		{
			foreach (Connector outputConnector in base.OutputConnectors)
			{
				if (outputConnector.EndElement != null && outputConnector.EndElement is OrganizationElement item)
				{
					list.Add(item);
				}
			}
			return list;
		}
		return list;
	}

	public override void OnCopied(Dictionary<Guid, Element> copiedElements = null)
	{
		base.OnCopied(copiedElements);
		if (composition == null)
		{
			return;
		}
		foreach (OrganizationElement item in composition)
		{
			item.Uid = Guid.NewGuid();
			item.OnCopied(copiedElements);
		}
	}

	protected OrganizationElement()
	{
		//Discarded unreachable code: IL_003a, IL_003f
		E1YOBwHWOTTqHLyEfX6();
		composition = new List<OrganizationElement>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_56bc39e908f44451b3cdd0d68828e324 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool wkwFNQH5aoUBtrVg2tu()
	{
		return GLfTTBHpZCcpomihIZl == null;
	}

	internal static OrganizationElement jxQ7EvHAYXjD1j457Fu()
	{
		return GLfTTBHpZCcpomihIZl;
	}

	internal static void E1YOBwHWOTTqHLyEfX6()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}
}
