using System;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Attributes;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Interface, AllowMultiple = false, Inherited = false)]
public class PublicApiNodeIgnoreAttribute : Attribute
{
	private string[] publicApiIgnoreNodes;

	internal static PublicApiNodeIgnoreAttribute XwA8tuoQU0aGoJD7V50F;

	public string[] PublicApiIgnoreNodes
	{
		get
		{
			return publicApiIgnoreNodes;
		}
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
					publicApiIgnoreNodes = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
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

	public PublicApiNodeIgnoreAttribute(params string[] nodeId)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		y88KxWoQz9R3RDZbOuXl();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
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
			publicApiIgnoreNodes = nodeId;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
			{
				num = 1;
			}
		}
	}

	internal static void y88KxWoQz9R3RDZbOuXl()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool NtajtpoQsf91eNMolWLg()
	{
		return XwA8tuoQU0aGoJD7V50F == null;
	}

	internal static PublicApiNodeIgnoreAttribute rtYcX1oQclQABVkERSIF()
	{
		return XwA8tuoQU0aGoJD7V50F;
	}
}
