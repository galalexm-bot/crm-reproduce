using EleWise.ELMA.Runtime.NH.Listeners;
using EleWise.ELMA.Security.Models.API;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Event;

namespace EleWise.ELMA.Security.Listeners;

internal class PublicApplicationListener : EntityEventsListener
{
	internal static PublicApplicationListener dSo8afHzwjBahIN5DmX;

	public override bool OnPreDelete(PreDeleteEvent @event)
	{
		//Discarded unreachable code: IL_009a
		int num = 1;
		IPublicApplication publicApplication = default(IPublicApplication);
		IPublicApplicationToken publicApplicationToken = default(IPublicApplicationToken);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					if (ja13uCaAHweyxvymUjG(publicApplication))
					{
						num2 = 7;
						break;
					}
					goto IL_006e;
				case 4:
					if (!uTndgBaWyuI0DhSURIE(publicApplicationToken))
					{
						goto end_IL_0012;
					}
					goto case 3;
				case 7:
					return true;
				case 3:
					return true;
				case 6:
					return false;
				case 1:
					publicApplication = RsROAna512YagIA6Vcn(@event) as IPublicApplication;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0df0152125fa4e148590f3218518a41b != 0)
					{
						num2 = 0;
					}
					break;
				default:
					if (publicApplication != null)
					{
						num2 = 5;
						break;
					}
					goto IL_006e;
				case 2:
					{
						if (publicApplicationToken != null)
						{
							num2 = 4;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a1a646659a464f3fa5c9aedc64725d72 != 0)
							{
								num2 = 1;
							}
							break;
						}
						goto case 6;
					}
					IL_006e:
					publicApplicationToken = RsROAna512YagIA6Vcn(@event) as IPublicApplicationToken;
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8b4bc2d0df7346ebba20e6c22632a575 != 0)
					{
						num2 = 2;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 6;
		}
	}

	public PublicApplicationListener()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fe0eedb8ce484402a5c9a74346556b9f == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object RsROAna512YagIA6Vcn(object P_0)
	{
		return ((AbstractPreDatabaseOperationEvent)P_0).get_Entity();
	}

	internal static bool ja13uCaAHweyxvymUjG(object P_0)
	{
		return ((IPublicApplication)P_0).IsSystem;
	}

	internal static bool uTndgBaWyuI0DhSURIE(object P_0)
	{
		return ((IPublicApplicationToken)P_0).IsSystem;
	}

	internal static bool HseXNmakwBtAuomRLIc()
	{
		return dSo8afHzwjBahIN5DmX == null;
	}

	internal static PublicApplicationListener LRj0GEapCBbowRmWVlW()
	{
		return dSo8afHzwjBahIN5DmX;
	}
}
