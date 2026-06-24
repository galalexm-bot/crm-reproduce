using System;
using System.Collections.Generic;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Deploy.Import.Links;

public class LinksDictionary : List<ILinksDictionaryItem>
{
	private static LinksDictionary kCdspFEJHJinB3spr2vJ;

	public bool AddLink(LinksDictionaryItem item)
	{
		//Discarded unreachable code: IL_0064, IL_0073, IL_00c6, IL_00d5
		int num = 8;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (Hq78E1EJxgp8KLGLR4Zy(item) != Guid.Empty)
				{
					num2 = 3;
					break;
				}
				goto case 6;
			case 4:
				return true;
			case 6:
			case 7:
				return false;
			case 8:
				if (item == null)
				{
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
					{
						num2 = 7;
					}
					break;
				}
				goto case 1;
			case 2:
				if (DrHPt7EJmYAlZH66HJ3i(xPHVKgEJMFx2mP6TSgvq(item), Guid.Empty))
				{
					num2 = 5;
					break;
				}
				goto case 6;
			case 3:
				if (!DrHPt7EJmYAlZH66HJ3i(Hkt9JSEJ09SbYkVdHDcZ(item), Guid.Empty))
				{
					num2 = 6;
					break;
				}
				goto default;
			default:
				if (aty2soEJyG1qR1H33PGY(item) != Guid.Empty)
				{
					num2 = 2;
					break;
				}
				goto case 6;
			case 5:
				Add(item);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public LinksDictionary()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		HoTK0DEJJnM2YRWq9uM4();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Guid Hq78E1EJxgp8KLGLR4Zy(object P_0)
	{
		return ((LinksDictionaryItem)P_0).EntityUid;
	}

	internal static Guid Hkt9JSEJ09SbYkVdHDcZ(object P_0)
	{
		return ((LinksDictionaryItem)P_0).EntityTypeUid;
	}

	internal static bool DrHPt7EJmYAlZH66HJ3i(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static Guid aty2soEJyG1qR1H33PGY(object P_0)
	{
		return ((LinksDictionaryItem)P_0).LinkUid;
	}

	internal static Guid xPHVKgEJMFx2mP6TSgvq(object P_0)
	{
		return ((LinksDictionaryItem)P_0).LinkPropertyUid;
	}

	internal static bool o6yvHFEJA1aCA5NIUFVQ()
	{
		return kCdspFEJHJinB3spr2vJ == null;
	}

	internal static LinksDictionary Mo6vSlEJ7aapy28iqTFF()
	{
		return kCdspFEJHJinB3spr2vJ;
	}

	internal static void HoTK0DEJJnM2YRWq9uM4()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
