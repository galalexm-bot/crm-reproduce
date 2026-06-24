using System;
using System.Globalization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.NH.Listeners;
using EleWise.ELMA.Security.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Event;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Listeners;

[Component]
public class UserListener : EntityEventsListener
{
	internal static UserListener AEtjJuHEq4VpJddHZTR;

	public override bool OnPreInsert(PreInsertEvent @event)
	{
		int num = 1;
		int num2 = num;
		EleWise.ELMA.Security.Models.IUser user = default(EleWise.ELMA.Security.Models.IUser);
		while (true)
		{
			switch (num2)
			{
			case 3:
				FixUserLocal(user);
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7eacf98b652644699fca43e43408d382 == 0)
				{
					num2 = 1;
				}
				continue;
			default:
				if (user != null)
				{
					num2 = 3;
					continue;
				}
				break;
			case 1:
				user = ((AbstractPreDatabaseOperationEvent)@event).get_Entity() as EleWise.ELMA.Security.Models.IUser;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_417fa9f431a6421fac341b81e122e2e7 == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				break;
			}
			break;
		}
		return false;
	}

	public override bool OnPreUpdate(PreUpdateEvent @event)
	{
		//Discarded unreachable code: IL_00c0
		int num = 5;
		DateTime? dateTime = default(DateTime?);
		EleWise.ELMA.Security.Models.IUser user = default(EleWise.ELMA.Security.Models.IUser);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 8:
					dateTime = user.BlockDate;
					num2 = 9;
					continue;
				case 7:
					break;
				case 12:
					dateTime = (user.BlockDate = null);
					num2 = 6;
					continue;
				case 2:
					if (wq1aCmHYrM2FatMT3eB(user) == UserStatus.Blocked)
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e4840b3cf8a94577862fdc527af9db29 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 10;
				case 4:
					if (user != null)
					{
						num2 = 7;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6c7be8ec8b6749dcb0601e062f5515fa != 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto case 6;
				case 5:
					user = hXV62EHsWw1Y7dmrPR2(@event) as EleWise.ELMA.Security.Models.IUser;
					num2 = 3;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6f96338790994363b52cd5c55eb1342f != 0)
					{
						num2 = 4;
					}
					continue;
				case 3:
					if (!dateTime.HasValue)
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7ced317202a44233ac3d0deafcdd1923 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 10;
				case 6:
				case 11:
					return false;
				case 9:
					if (dateTime.HasValue)
					{
						num2 = 4;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a3a30dc594d64d20b0419bc3debf22fd != 0)
						{
							num2 = 12;
						}
						continue;
					}
					goto case 6;
				default:
					user.BlockDate = D8TfHdHIFX1UvMpaCHZ();
					num2 = 11;
					continue;
				case 10:
					if (wq1aCmHYrM2FatMT3eB(user) != UserStatus.Blocked)
					{
						num2 = 8;
						continue;
					}
					goto case 6;
				case 1:
					dateTime = user.BlockDate;
					num2 = 3;
					continue;
				}
				break;
			}
			FixUserLocal(user);
			num = 2;
		}
	}

	private void FixUserLocal(IUser user)
	{
		//Discarded unreachable code: IL_0058, IL_0161, IL_0170, IL_01ab, IL_01ba
		int num = 3;
		int num2 = num;
		CultureInfo cultureInfo2 = default(CultureInfo);
		while (true)
		{
			switch (num2)
			{
			case 4:
				try
				{
					CultureInfo cultureInfo = CultureInfo.CreateSpecificCulture((string)bMUGagH4ydK7XnerahB(user));
					int num3 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_94a7beb9ab90455caa18ecaa3b17b19c == 0)
					{
						num3 = 1;
					}
					while (true)
					{
						switch (num3)
						{
						default:
							return;
						case 1:
							LLCEeTHT1ZIMKJBccZB(user, dWLjqTHdWl1mlLvEyqn(cultureInfo));
							num3 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7ced317202a44233ac3d0deafcdd1923 == 0)
							{
								num3 = 0;
							}
							break;
						case 0:
							return;
						}
					}
				}
				catch (Exception ex)
				{
					int num4 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7ced317202a44233ac3d0deafcdd1923 != 0)
					{
						num4 = 0;
					}
					while (true)
					{
						object obj;
						switch (num4)
						{
						default:
							ogtuPUHryktvNAEQIdD(DiDJ25HgTnUdBuN2Ayf(), m8BaE6H8Twbj0h7imY1(ex), ex);
							num4 = 2;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e2203cd019614c439eaf162fdd0eb05d == 0)
							{
								num4 = 1;
							}
							continue;
						case 3:
							LLCEeTHT1ZIMKJBccZB(user, dWLjqTHdWl1mlLvEyqn(cultureInfo2));
							num4 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b1df165db1394c8cbd9914e637f5e083 == 0)
							{
								num4 = 1;
							}
							continue;
						case 2:
							obj = tGOeYlH3SRFSVCpjB9M();
							if (obj != null)
							{
								break;
							}
							num4 = 4;
							continue;
						case 4:
							obj = cN35KWHyM2S2ZukJQNd();
							break;
						case 1:
							return;
						}
						cultureInfo2 = (CultureInfo)obj;
						int num5 = 3;
						num4 = num5;
					}
				}
			case 3:
				if (jEahGWHVjn5Vw8CYDLA(bMUGagH4ydK7XnerahB(user)))
				{
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_daaf990ff0c644fb99cfba0a043a9b93 != 0)
					{
						num2 = 2;
					}
					continue;
				}
				break;
			case 1:
				return;
			case 2:
				return;
			}
			if (((string)bMUGagH4ydK7XnerahB(user)).Contains((string)GfaMEuHQMTkdt2nvVlu(-1712587919 ^ -1712590103)))
			{
				break;
			}
			num2 = 4;
		}
	}

	public UserListener()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		dHMOtTHbZWR4PJwy6vJ();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8523ddc2b5094f2f87aec3d74da64bd2 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool MRbEh2HDq8yDEPFiNIM()
	{
		return AEtjJuHEq4VpJddHZTR == null;
	}

	internal static UserListener a7TmVZHMCEa6w9fj6iP()
	{
		return AEtjJuHEq4VpJddHZTR;
	}

	internal static object hXV62EHsWw1Y7dmrPR2(object P_0)
	{
		return ((AbstractPreDatabaseOperationEvent)P_0).get_Entity();
	}

	internal static UserStatus wq1aCmHYrM2FatMT3eB(object P_0)
	{
		return ((EleWise.ELMA.Security.Models.IUser)P_0).Status;
	}

	internal static DateTime D8TfHdHIFX1UvMpaCHZ()
	{
		return DateTime.Now;
	}

	internal static object bMUGagH4ydK7XnerahB(object P_0)
	{
		return ((IUser)P_0).Lang;
	}

	internal static bool jEahGWHVjn5Vw8CYDLA(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object GfaMEuHQMTkdt2nvVlu(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object dWLjqTHdWl1mlLvEyqn(object P_0)
	{
		return ((CultureInfo)P_0).Name;
	}

	internal static void LLCEeTHT1ZIMKJBccZB(object P_0, object P_1)
	{
		((IUser)P_0).Lang = (string)P_1;
	}

	internal static object DiDJ25HgTnUdBuN2Ayf()
	{
		return Logger.Log;
	}

	internal static object m8BaE6H8Twbj0h7imY1(object P_0)
	{
		return ((Exception)P_0).Message;
	}

	internal static void ogtuPUHryktvNAEQIdD(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static object tGOeYlH3SRFSVCpjB9M()
	{
		return SR.GetDefaultCulture();
	}

	internal static object cN35KWHyM2S2ZukJQNd()
	{
		return SR.KeyCultureInfo;
	}

	internal static void dHMOtTHbZWR4PJwy6vJ()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}
}
