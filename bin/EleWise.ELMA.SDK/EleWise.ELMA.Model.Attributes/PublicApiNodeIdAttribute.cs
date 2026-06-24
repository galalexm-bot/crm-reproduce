using System;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Attributes;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Interface, AllowMultiple = false, Inherited = false)]
public class PublicApiNodeIdAttribute : Attribute
{
	private string publicApiNodeId;

	internal static PublicApiNodeIdAttribute MId4EqoQjaIx1TK308wc;

	public string PublicApiNodeId
	{
		get
		{
			return publicApiNodeId;
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
					publicApiNodeId = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
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

	public PublicApiNodeIdAttribute(string nodeId)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
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
				publicApiNodeId = nodeId;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	internal static bool Tpyr5QoQYa1bf9top8iY()
	{
		return MId4EqoQjaIx1TK308wc == null;
	}

	internal static PublicApiNodeIdAttribute YfUZaUoQL8tCYblwrCFV()
	{
		return MId4EqoQjaIx1TK308wc;
	}
}
