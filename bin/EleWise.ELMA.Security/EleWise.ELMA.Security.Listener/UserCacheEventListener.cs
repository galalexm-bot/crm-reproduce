using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Files;
using EleWise.ELMA.Runtime.NH.Listeners;
using EleWise.ELMA.Security.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Event;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Listeners;

[Component]
public class UserCacheEventListener : PostFlushEventListener
{
	public static string UserDictionaryUid;

	public static string UserDictionaryTimeStump;

	private static object obj;

	private static UserCacheEventListener E0ShIfHLP8Ee1qXQaI6;

	public IComplexCacheService CacheService
	{
		[CompilerGenerated]
		get
		{
			return _003CCacheService_003Ek__BackingField;
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
					_003CCacheService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b496c4412b534db6beb066c8296e663d != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public override void OnPostInsert(PostInsertEvent @event)
	{
		//Discarded unreachable code: IL_0090, IL_009f
		int num = 4;
		int num2 = num;
		EleWise.ELMA.Security.Models.IUser user = default(EleWise.ELMA.Security.Models.IUser);
		while (true)
		{
			switch (num2)
			{
			default:
				UserPhotoCacheUpdate(user);
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fb7ef78ec97a4842bca66699308784ed != 0)
				{
					num2 = 2;
				}
				break;
			case 3:
				if (user == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6949750552fc4dcdbaec6842e5667482 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			case 4:
				user = ((AbstractPostDatabaseOperationEvent)@event).get_Entity() as EleWise.ELMA.Security.Models.IUser;
				num2 = 3;
				break;
			case 1:
				return;
			case 2:
				return;
			}
		}
	}

	public override void OnPostUpdate(PostUpdateEvent @event)
	{
		//Discarded unreachable code: IL_0036, IL_0045
		int num = 1;
		int num2 = num;
		EleWise.ELMA.Security.Models.IUser user = default(EleWise.ELMA.Security.Models.IUser);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 4:
				return;
			default:
				if (user == null)
				{
					num2 = 4;
					continue;
				}
				break;
			case 1:
				user = h0W2dNHanOOk4yjsAjt(@event) as EleWise.ELMA.Security.Models.IUser;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_562220c988b04dea969b2dc6cde52015 != 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				break;
			}
			UserPhotoCacheUpdate(user);
			num2 = 1;
			if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5ae6a44bd52345c5bcadd62b7063c7d9 == 0)
			{
				num2 = 2;
			}
		}
	}

	private void UserPhotoCacheUpdate(EleWise.ELMA.Security.Models.IUser user)
	{
		//Discarded unreachable code: IL_00db, IL_015e, IL_0196
		int num = 2;
		int num2 = num;
		Dictionary<long, Guid> orAdd = default(Dictionary<long, Guid>);
		bool lockTaken = default(bool);
		object obj = default(object);
		while (true)
		{
			switch (num2)
			{
			case 5:
				CacheService.RefreshTimestamp(UserDictionaryTimeStump);
				num2 = 6;
				break;
			case 1:
				if (orAdd.Any())
				{
					num2 = 4;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e4840b3cf8a94577862fdc527af9db29 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 5;
			case 6:
				return;
			default:
				lockTaken = false;
				num2 = 3;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4aad3b757e09491eb106d72b1e7740cc == 0)
				{
					num2 = 2;
				}
				break;
			case 4:
				obj = UserCacheEventListener.obj;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a1d876260ca946cdbdcbec4b9517d613 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				try
				{
					Monitor.Enter(obj, ref lockTaken);
					int num3 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b496c4412b534db6beb066c8296e663d == 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						case 1:
							return;
						}
						orAdd[user.Id] = ((zraIm2HRZF2DTsPHSRK(user) != null) ? ((BinaryFile)zraIm2HRZF2DTsPHSRK(user)).Uid : Guid.Empty);
						num3 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7ced317202a44233ac3d0deafcdd1923 == 0)
						{
							num3 = 1;
						}
					}
				}
				finally
				{
					if (lockTaken)
					{
						int num4 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5c3c41b36b4846e0b1701d4e56408883 == 0)
						{
							num4 = 1;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								Monitor.Exit(obj);
								num4 = 0;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8523ddc2b5094f2f87aec3d74da64bd2 == 0)
								{
									num4 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
				}
			case 2:
				orAdd = CacheService.GetOrAdd(UserDictionaryUid, UserDictionaryTimeStump, () => new Dictionary<long, Guid>());
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_488725796a2e487f95c022f5056d8a88 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public UserCacheEventListener()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		uZDLNvHw443eyDY0brU();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b1df165db1394c8cbd9914e637f5e083 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static UserCacheEventListener()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				return;
			case 4:
				obj = new object();
				num2 = 3;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8dab57df677749fba2d5364cf752799f == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				UserDictionaryUid = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x32A45635 ^ 0x32A41B5D);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a7933e38c68f4f69b40e459b15579199 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				uZDLNvHw443eyDY0brU();
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e2be4970ad4d405ab7ed74c6b68c9f7d != 0)
				{
					num2 = 0;
				}
				break;
			default:
				UserDictionaryTimeStump = (string)xUoP7bH294SKeFGcKT0(-1365352774 ^ -1365372108);
				num2 = 4;
				break;
			}
		}
	}

	internal static bool F4XjhyHji8bt4CZTAve()
	{
		return E0ShIfHLP8Ee1qXQaI6 == null;
	}

	internal static UserCacheEventListener mT9YUtHH7Y5TSB9yRYQ()
	{
		return E0ShIfHLP8Ee1qXQaI6;
	}

	internal static object h0W2dNHanOOk4yjsAjt(object P_0)
	{
		return ((AbstractPostDatabaseOperationEvent)P_0).get_Entity();
	}

	internal static object zraIm2HRZF2DTsPHSRK(object P_0)
	{
		return ((EleWise.ELMA.Security.Models.IUser)P_0).Photo;
	}

	internal static void uZDLNvHw443eyDY0brU()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}

	internal static object xUoP7bH294SKeFGcKT0(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
