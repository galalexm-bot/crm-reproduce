using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.NH.Listeners;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Event;

namespace EleWise.ELMA.Security.Listeners;

[Component]
public class UserCertificateListener : PostFlushEventListener
{
	internal static UserCertificateListener aPFnbpHPJOdeWDp30GH;

	public UserCertificateManager UserCertificateManager
	{
		[CompilerGenerated]
		get
		{
			return _003CUserCertificateManager_003Ek__BackingField;
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
				case 1:
					_003CUserCertificateManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_97ec140e839b4bd5a711912170945a29 != 0)
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

	public override void OnPostInsert(PostInsertEvent @event)
	{
		int num = 1;
		int num2 = num;
		IUserCertificate certificate = default(IUserCertificate);
		while (true)
		{
			switch (num2)
			{
			default:
				UpdateDefault(certificate);
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_bed74a20bc6648fab6800acd64e4559d == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			case 1:
				certificate = irlnErHUrM3v4FN8hRL(@event) as IUserCertificate;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2f11eccd7e8f4339a0b03ad9fe1eb947 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override void OnPostUpdate(PostUpdateEvent @event)
	{
		int num = 2;
		int num2 = num;
		IUserCertificate certificate = default(IUserCertificate);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				UpdateDefault(certificate);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3c78e0d08cb4410a900ca26e4b83108c == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				certificate = irlnErHUrM3v4FN8hRL(@event) as IUserCertificate;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c3d852ec782a44099f926fd43a0da6df == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			}
		}
	}

	private void UpdateDefault(IUserCertificate certificate)
	{
		//Discarded unreachable code: IL_0117, IL_0127, IL_0136, IL_0141, IL_0215, IL_024d, IL_025c, IL_026c, IL_027b, IL_028b, IL_029a, IL_02aa, IL_02b9, IL_02eb
		int num = 11;
		bool? isDefault = default(bool?);
		Guid? cryptoActionGuid = default(Guid?);
		IEnumerator<IUserCertificate> enumerator = default(IEnumerator<IUserCertificate>);
		IUserCertificate current = default(IUserCertificate);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 3:
					if (isDefault.Value)
					{
						num = 2;
						break;
					}
					return;
				case 11:
					if (certificate != null)
					{
						num = 10;
						break;
					}
					return;
				case 13:
					if (!isDefault.HasValue)
					{
						num2 = 8;
						continue;
					}
					goto case 6;
				case 0:
					return;
				case 8:
					return;
				case 2:
					if (GKDttQHoehfeHl5URCE(certificate) == null)
					{
						num2 = 12;
						continue;
					}
					goto case 14;
				case 1:
					return;
				case 14:
					cryptoActionGuid = certificate.CryptoActionGuid;
					num2 = 5;
					continue;
				case 5:
					if (cryptoActionGuid.HasValue)
					{
						num2 = 9;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0dd863774da04dfd9f21706b4b60a6b9 == 0)
						{
							num2 = 8;
						}
						continue;
					}
					return;
				case 15:
					return;
				case 10:
					isDefault = certificate.IsDefault;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_364662b38d3b4bdb9f3f1f11b8889cdc == 0)
					{
						num2 = 13;
					}
					continue;
				case 4:
					try
					{
						while (true)
						{
							IL_01ad:
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 0;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_77bfde1a0739446782f0bda00c988550 != 0)
								{
									num3 = 0;
								}
								goto IL_0145;
							}
							goto IL_0163;
							IL_0163:
							current = enumerator.Current;
							num3 = 3;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6e35a1cd804541a884550671c71dbb1c == 0)
							{
								num3 = 4;
							}
							goto IL_0145;
							IL_0145:
							while (true)
							{
								switch (num3)
								{
								default:
									return;
								case 0:
									return;
								case 3:
									break;
								case 2:
									current.IsDefault = false;
									num3 = 1;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b6bf1b70a8924e789fc4be8e9aadc953 == 0)
									{
										num3 = 1;
									}
									continue;
								case 1:
									goto IL_01ad;
								case 4:
									if (current.Id != certificate.Id)
									{
										num3 = 2;
										continue;
									}
									goto IL_01ad;
								}
								break;
							}
							goto IL_0163;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							int num4 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4aad3b757e09491eb106d72b1e7740cc == 0)
							{
								num4 = 0;
							}
							while (true)
							{
								switch (num4)
								{
								default:
									xBfGKfHJTtBKwHQ40g3(enumerator);
									num4 = 1;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0a82cc1379bc48bbb836c94da8cb8564 == 0)
									{
										num4 = 1;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
				case 12:
					return;
				case 6:
					isDefault = certificate.IsDefault;
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8dab57df677749fba2d5364cf752799f != 0)
					{
						num2 = 3;
					}
					continue;
				case 7:
					return;
				case 9:
				{
					UserCertificateManager userCertificateManager = UserCertificateManager;
					EleWise.ELMA.Security.Models.IUser user = certificate.User;
					cryptoActionGuid = certificate.CryptoActionGuid;
					enumerator = userCertificateManager.GetCertificates(user, cryptoActionGuid.Value).Where(delegate(IUserCertificate c)
					{
						int num5 = 2;
						int num6 = num5;
						bool? isDefault2 = default(bool?);
						while (true)
						{
							switch (num6)
							{
							case 2:
								isDefault2 = c.IsDefault;
								num6 = 1;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4aad3b757e09491eb106d72b1e7740cc == 0)
								{
									num6 = 0;
								}
								break;
							case 1:
								if (!isDefault2.HasValue)
								{
									return false;
								}
								num6 = 0;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7fbc19cae8c8414894251bb8ae24a12e == 0)
								{
									num6 = 0;
								}
								break;
							default:
								isDefault2 = c.IsDefault;
								num6 = 3;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0a82cc1379bc48bbb836c94da8cb8564 == 0)
								{
									num6 = 1;
								}
								break;
							case 3:
								return isDefault2.Value;
							}
						}
					}).GetEnumerator();
					num2 = 4;
					continue;
				}
				}
				break;
			}
		}
	}

	public UserCertificateListener()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e19c59c87b9f40ffa6cb17beeb01edcf != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool LZi8I2HvAmG44Kngbf8()
	{
		return aPFnbpHPJOdeWDp30GH == null;
	}

	internal static UserCertificateListener dwiNTTHCUiKWZSEVWTy()
	{
		return aPFnbpHPJOdeWDp30GH;
	}

	internal static object irlnErHUrM3v4FN8hRL(object P_0)
	{
		return ((AbstractPostDatabaseOperationEvent)P_0).get_Entity();
	}

	internal static object GKDttQHoehfeHl5URCE(object P_0)
	{
		return ((IUserCertificate)P_0).User;
	}

	internal static void xBfGKfHJTtBKwHQ40g3(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}
}
