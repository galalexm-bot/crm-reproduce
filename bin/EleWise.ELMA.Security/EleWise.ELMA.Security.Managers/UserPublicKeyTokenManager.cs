using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Security;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Managers;

public class UserPublicKeyTokenManager : EntityManager<IUserPublicKeyToken, long>
{
	internal static UserPublicKeyTokenManager zmw9fmMfdOrrJ4cljD6;

	[NotNull]
	public new static UserPublicKeyTokenManager Instance => Locator.GetServiceNotNull<UserPublicKeyTokenManager>();

	public void RegisterToken(string name, string deviceId, string key, EleWise.ELMA.Security.Models.IUser user = null)
	{
		//Discarded unreachable code: IL_00d1, IL_02ed, IL_02fc
		int num = 1;
		IUserPublicKeyToken userPublicKeyToken = default(IUserPublicKeyToken);
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = default(_003C_003Ec__DisplayClass2_0);
		EleWise.ELMA.Security.Models.IUser user2 = default(EleWise.ELMA.Security.Models.IUser);
		ISecurityService serviceNotNull = default(ISecurityService);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					if (fL4OkSsl8dED4qMyDuj(userPublicKeyToken) == user)
					{
						num2 = 3;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b1df165db1394c8cbd9914e637f5e083 == 0)
						{
							num2 = 7;
						}
						continue;
					}
					throw new Exception((string)Bk2yHTspMDaYtvEvoyE(CRyfTUskreyJaETbxvG(0x397B0322 ^ 0x397BBA04)));
				case 9:
					if (userPublicKeyToken != null)
					{
						num2 = 3;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e19c59c87b9f40ffa6cb17beeb01edcf != 0)
						{
							num2 = 3;
						}
					}
					else
					{
						IUserPublicKeyToken userPublicKeyToken2 = InterfaceActivator.Create<IUserPublicKeyToken>();
						userPublicKeyToken2.Name = name;
						bFv7J6sN6VSdfBqMRBl(userPublicKeyToken2, user);
						OnRZNvsZpY1aaVNcYBE(userPublicKeyToken2, _003C_003Ec__DisplayClass2_.key);
						tFjP3Asx4xkBJd7q9wJ(userPublicKeyToken2, deviceId);
						G8tt4ZsBTdPQn8OZQy7(userPublicKeyToken2);
						num2 = 16;
					}
					continue;
				case 2:
					if (user2 != user)
					{
						num2 = 2;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_06e91bc1320c425bb120c2fac8d1e3be == 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 10;
				case 13:
					if (user != null)
					{
						num2 = 4;
						continue;
					}
					goto case 8;
				case 16:
					return;
				case 5:
					if (serviceNotNull.HasPermission(user2, PermissionProvider.UserManagmentPermission))
					{
						num2 = 10;
						continue;
					}
					goto case 6;
				case 7:
					throw new Exception(SR.T((string)CRyfTUskreyJaETbxvG(0x2CFDCC80 ^ 0x2CFD7452)));
				case 8:
					user = user2;
					num2 = 11;
					continue;
				default:
					_003C_003Ec__DisplayClass2_.key = key;
					num2 = 15;
					continue;
				case 1:
					_003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_ae9e5ed1f04543cd9a3ea633dd768889 != 0)
					{
						num2 = 0;
					}
					continue;
				case 6:
					throw new SecurityException((string)Bk2yHTspMDaYtvEvoyE(CRyfTUskreyJaETbxvG(-76932334 ^ -76901444)));
				case 10:
					if (!oXtY0Vs5g0EMQWJj9wY(_003C_003Ec__DisplayClass2_.key))
					{
						num2 = 14;
						continue;
					}
					goto case 12;
				case 15:
					user2 = (EleWise.ELMA.Security.Models.IUser)Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser();
					num = 13;
					break;
				case 12:
					throw new Exception((string)Bk2yHTspMDaYtvEvoyE(CRyfTUskreyJaETbxvG(-724676315 ^ -724637295)));
				case 14:
				{
					ParameterExpression parameterExpression = (ParameterExpression)bU9hmMsWmljok1GEd4Q(mQEuM5sAD2hRImiocT7(typeof(IUserPublicKeyToken).TypeHandle), CRyfTUskreyJaETbxvG(0x738E3073 ^ 0x738E8599));
					userPublicKeyToken = ((AbstractNHEntityManager<IUserPublicKeyToken, long>)this).Find(Expression.Lambda<Func<IUserPublicKeyToken, bool>>((Expression)DZQ4nbs6IlyKLaDKuhx(Expression.Property(parameterExpression, (MethodInfo)NsDo01sXOpmQ02RU1lt((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), jyQtRNs7Xg88nDNc6VU(TfuiP9sn2dHbs7aE5Zi(_003C_003Ec__DisplayClass2_, typeof(_003C_003Ec__DisplayClass2_0)), IoyFjOsiYnRr4Lh1VsG((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))), new ParameterExpression[1] { parameterExpression })).FirstOrDefault();
					num = 9;
					break;
				}
				case 4:
				case 11:
					serviceNotNull = Locator.GetServiceNotNull<ISecurityService>();
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c78060c4cac8419092e4610bf7a03750 != 0)
					{
						num2 = 2;
					}
					continue;
				}
				break;
			}
		}
	}

	public void UnRegisterToken(long id, EleWise.ELMA.Security.Models.IUser user = null)
	{
		//Discarded unreachable code: IL_0176, IL_0185, IL_0195, IL_01bb, IL_0247
		int num = 8;
		ISecurityService serviceNotNull = default(ISecurityService);
		EleWise.ELMA.Security.Models.IUser user2 = default(EleWise.ELMA.Security.Models.IUser);
		TrustedDeviceService serviceNotNull2 = default(TrustedDeviceService);
		IUserPublicKeyToken userPublicKeyToken = default(IUserPublicKeyToken);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 15:
					if (!jXVNr7smOv8iGl3lOtl(serviceNotNull, user2, PermissionProvider.UserManagmentPermission))
					{
						num2 = 13;
						continue;
					}
					goto IL_0160;
				case 12:
					user = user2;
					num2 = 10;
					continue;
				case 3:
					if (YhxMpdseiIbmJf8wF8u(serviceNotNull2.GetDevices(user)) > 0)
					{
						num2 = 18;
						continue;
					}
					goto case 4;
				case 17:
					if (EfTrj6sjPWWusl6pwLe(ypiLf8sLIHNEstaqyM3(), user))
					{
						num2 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c843c5b509d748f086ceb6be01690351 == 0)
						{
							num2 = 9;
						}
						continue;
					}
					throw new Exception((string)Bk2yHTspMDaYtvEvoyE(CRyfTUskreyJaETbxvG(-1429500015 ^ -1429522917)));
				case 10:
				case 14:
					serviceNotNull = Locator.GetServiceNotNull<ISecurityService>();
					num2 = 5;
					continue;
				case 8:
					user2 = (EleWise.ELMA.Security.Models.IUser)E80kWqsuLlrH0uUPlym(Locator.GetServiceNotNull<IAuthenticationService>());
					num2 = 7;
					continue;
				case 6:
					if (!serviceNotNull2.TrustedLogonEnabled(user))
					{
						num2 = 11;
						continue;
					}
					goto case 3;
				case 16:
					if (userPublicKeyToken.User == user)
					{
						num2 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_364662b38d3b4bdb9f3f1f11b8889cdc == 0)
						{
							num2 = 1;
						}
						continue;
					}
					return;
				case 13:
					throw new SecurityException((string)Bk2yHTspMDaYtvEvoyE(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5FD42272 ^ 0x5FD4AADC)));
				case 2:
				case 9:
				case 11:
				case 18:
					break;
				case 0:
					return;
				case 4:
					if (Instance.Count(user) > 1)
					{
						num2 = 2;
						continue;
					}
					goto case 17;
				case 1:
					NeIgISsHN6Adxfs6fOl(userPublicKeyToken);
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f791092a54884ca2ab7376df2d89215c != 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					if (user2 != user)
					{
						num2 = 15;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_75955a8c33b24cdca4663f20d9ee3c3b == 0)
						{
							num2 = 15;
						}
						continue;
					}
					goto IL_0160;
				case 7:
					{
						if (user != null)
						{
							num2 = 14;
							continue;
						}
						goto case 12;
					}
					IL_0160:
					serviceNotNull2 = Locator.GetServiceNotNull<TrustedDeviceService>();
					num2 = 6;
					continue;
				}
				break;
			}
			userPublicKeyToken = Load(id);
			num = 16;
		}
	}

	[Obsolete]
	public IUserPublicKeyToken GetToken(IUser user)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass4_0 _003C_003Ec__DisplayClass4_ = default(_003C_003Ec__DisplayClass4_0);
		while (true)
		{
			switch (num2)
			{
			case 2:
			{
				ParameterExpression parameterExpression = Expression.Parameter(mQEuM5sAD2hRImiocT7(typeof(IUserPublicKeyToken).TypeHandle), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4D765E72 ^ 0x4D76EB98));
				return ((AbstractNHEntityManager<IUserPublicKeyToken, long>)this).Find(Expression.Lambda<Func<IUserPublicKeyToken, bool>>((Expression)DZQ4nbs6IlyKLaDKuhx(Expression.Property(parameterExpression, (MethodInfo)NsDo01sXOpmQ02RU1lt((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Field(Expression.Constant(_003C_003Ec__DisplayClass4_, mQEuM5sAD2hRImiocT7(typeof(_003C_003Ec__DisplayClass4_0).TypeHandle)), (FieldInfo)IoyFjOsiYnRr4Lh1VsG((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))), new ParameterExpression[1] { parameterExpression })).FirstOrDefault();
			}
			case 1:
				_003C_003Ec__DisplayClass4_ = new _003C_003Ec__DisplayClass4_0();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_07d1789322864bd7a6f8c5e113ce5c9a != 0)
				{
					num2 = 0;
				}
				break;
			default:
				_003C_003Ec__DisplayClass4_.user = user;
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_86eb143f59c14824a2785845ea23f248 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public IEnumerable<IUserPublicKeyToken> GetTokens(IUser user = null)
	{
		_003C_003Ec__DisplayClass5_0 _003C_003Ec__DisplayClass5_ = new _003C_003Ec__DisplayClass5_0();
		_003C_003Ec__DisplayClass5_.searchUser = user ?? Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser();
		ParameterExpression parameterExpression = Expression.Parameter(typeof(IUserPublicKeyToken), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-784481839 ^ -784501701));
		return ((AbstractNHEntityManager<IUserPublicKeyToken, long>)this).Find(Expression.Lambda<Func<IUserPublicKeyToken, bool>>(Expression.Equal(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Field(Expression.Constant(_003C_003Ec__DisplayClass5_, typeof(_003C_003Ec__DisplayClass5_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))), new ParameterExpression[1] { parameterExpression }));
	}

	public IUserPublicKeyToken GetTokenByPublicKey(IUser user, string publicKey)
	{
		int num = 3;
		int num2 = num;
		_003C_003Ec__DisplayClass6_0 _003C_003Ec__DisplayClass6_ = default(_003C_003Ec__DisplayClass6_0);
		while (true)
		{
			switch (num2)
			{
			case 3:
				_003C_003Ec__DisplayClass6_ = new _003C_003Ec__DisplayClass6_0();
				num2 = 2;
				break;
			case 2:
				_003C_003Ec__DisplayClass6_.user = user;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7fbc19cae8c8414894251bb8ae24a12e != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
			{
				ParameterExpression parameterExpression = (ParameterExpression)bU9hmMsWmljok1GEd4Q(mQEuM5sAD2hRImiocT7(typeof(IUserPublicKeyToken).TypeHandle), CRyfTUskreyJaETbxvG(0x7CAA49C6 ^ 0x7CAAFC2C));
				return ((AbstractNHEntityManager<IUserPublicKeyToken, long>)this).Find(Expression.Lambda<Func<IUserPublicKeyToken, bool>>((Expression)Pa3bEesRr2AcRpFtRAC(Expression.Equal((Expression)PKBKsWsaMyKMMfBfDoi(parameterExpression, (MethodInfo)NsDo01sXOpmQ02RU1lt((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (Expression)jyQtRNs7Xg88nDNc6VU(TfuiP9sn2dHbs7aE5Zi(_003C_003Ec__DisplayClass6_, mQEuM5sAD2hRImiocT7(typeof(_003C_003Ec__DisplayClass6_0).TypeHandle)), IoyFjOsiYnRr4Lh1VsG((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))), DZQ4nbs6IlyKLaDKuhx(PKBKsWsaMyKMMfBfDoi(parameterExpression, (MethodInfo)NsDo01sXOpmQ02RU1lt((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), jyQtRNs7Xg88nDNc6VU(TfuiP9sn2dHbs7aE5Zi(_003C_003Ec__DisplayClass6_, typeof(_003C_003Ec__DisplayClass6_0)), IoyFjOsiYnRr4Lh1VsG((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)))), new ParameterExpression[1] { parameterExpression })).FirstOrDefault();
			}
			default:
				_003C_003Ec__DisplayClass6_.publicKey = publicKey;
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6f96338790994363b52cd5c55eb1342f == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public long Count(IUser user = null)
	{
		int num = 1;
		int num2 = num;
		EleWise.ELMA.Security.Models.IUser user2 = default(EleWise.ELMA.Security.Models.IUser);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 2:
			{
				InstanceOf<IUserPublicKeyTokenFilter> instanceOf = new InstanceOf<IUserPublicKeyTokenFilter>();
				lxs44UswAPS0GfeFc9u(instanceOf.New, user2);
				return na6Qoms2A5xDpilaEkD(this, instanceOf.New);
			}
			case 1:
				obj = user;
				if (obj == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f791092a54884ca2ab7376df2d89215c == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			default:
				obj = E80kWqsuLlrH0uUPlym(Locator.GetServiceNotNull<IAuthenticationService>());
				break;
			}
			user2 = (EleWise.ELMA.Security.Models.IUser)obj;
			num2 = 1;
			if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8ec57fd3f43f4cf7983bc996ab09feb4 == 0)
			{
				num2 = 2;
			}
		}
	}

	public bool Exists(IUser user = null)
	{
		int num = 2;
		int num2 = num;
		EleWise.ELMA.Security.Models.IUser user2 = default(EleWise.ELMA.Security.Models.IUser);
		while (true)
		{
			object obj;
			switch (num2)
			{
			default:
			{
				InstanceOf<IUserPublicKeyTokenFilter> instanceOf = new InstanceOf<IUserPublicKeyTokenFilter>();
				lxs44UswAPS0GfeFc9u(instanceOf.New, user2);
				return a3hWMjsvJX7TF5DAfDG(this, instanceOf.New);
			}
			case 2:
				obj = user;
				if (obj != null)
				{
					break;
				}
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7eacf98b652644699fca43e43408d382 == 0)
				{
					num2 = 0;
				}
				continue;
			case 1:
				obj = E80kWqsuLlrH0uUPlym(zMg9PAsPVuhV7kNOK0w(this));
				break;
			}
			user2 = (EleWise.ELMA.Security.Models.IUser)obj;
			num2 = 0;
			if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3c78e0d08cb4410a900ca26e4b83108c == 0)
			{
				num2 = 0;
			}
		}
	}

	public UserPublicKeyTokenManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		p2s0IasCkOIPQLKnNxH();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8fd69cd0bea1432ca401d29377c613cc != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object CRyfTUskreyJaETbxvG(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object Bk2yHTspMDaYtvEvoyE(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool oXtY0Vs5g0EMQWJj9wY(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static Type mQEuM5sAD2hRImiocT7(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object bU9hmMsWmljok1GEd4Q(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object NsDo01sXOpmQ02RU1lt(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object TfuiP9sn2dHbs7aE5Zi(object P_0, Type P_1)
	{
		return Expression.Constant(P_0, P_1);
	}

	internal static object IoyFjOsiYnRr4Lh1VsG(RuntimeFieldHandle P_0)
	{
		return FieldInfo.GetFieldFromHandle(P_0);
	}

	internal static object jyQtRNs7Xg88nDNc6VU(object P_0, object P_1)
	{
		return Expression.Field((Expression)P_0, (FieldInfo)P_1);
	}

	internal static object DZQ4nbs6IlyKLaDKuhx(object P_0, object P_1)
	{
		return Expression.Equal((Expression)P_0, (Expression)P_1);
	}

	internal static object fL4OkSsl8dED4qMyDuj(object P_0)
	{
		return ((IUserPublicKeyToken)P_0).User;
	}

	internal static void bFv7J6sN6VSdfBqMRBl(object P_0, object P_1)
	{
		((IUserPublicKeyToken)P_0).User = (EleWise.ELMA.Security.Models.IUser)P_1;
	}

	internal static void OnRZNvsZpY1aaVNcYBE(object P_0, object P_1)
	{
		((IUserPublicKeyToken)P_0).PublicKey = (string)P_1;
	}

	internal static void tFjP3Asx4xkBJd7q9wJ(object P_0, object P_1)
	{
		((IUserPublicKeyToken)P_0).DeviceId = (string)P_1;
	}

	internal static void G8tt4ZsBTdPQn8OZQy7(object P_0)
	{
		((IEntity)P_0).Save();
	}

	internal static bool CJxoHwM1kvCEmRR7gO8()
	{
		return zmw9fmMfdOrrJ4cljD6 == null;
	}

	internal static UserPublicKeyTokenManager gYEDYRMziFHVgTFYZr4()
	{
		return zmw9fmMfdOrrJ4cljD6;
	}

	internal static object E80kWqsuLlrH0uUPlym(object P_0)
	{
		return ((IAuthenticationService)P_0).GetCurrentUser();
	}

	internal static bool jXVNr7smOv8iGl3lOtl(object P_0, object P_1, object P_2)
	{
		return ((ISecurityService)P_0).HasPermission((IUser)P_1, (Permission)P_2);
	}

	internal static int YhxMpdseiIbmJf8wF8u(object P_0)
	{
		return ((List<DeviceToken>)P_0).Count;
	}

	internal static object ypiLf8sLIHNEstaqyM3()
	{
		return UserCertificateManager.Instance;
	}

	internal static bool EfTrj6sjPWWusl6pwLe(object P_0, object P_1)
	{
		return ((UserCertificateManager)P_0).Exists((IUser)P_1);
	}

	internal static void NeIgISsHN6Adxfs6fOl(object P_0)
	{
		((IEntity)P_0).Delete();
	}

	internal static object PKBKsWsaMyKMMfBfDoi(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static object Pa3bEesRr2AcRpFtRAC(object P_0, object P_1)
	{
		return Expression.AndAlso((Expression)P_0, (Expression)P_1);
	}

	internal static void lxs44UswAPS0GfeFc9u(object P_0, object P_1)
	{
		((IUserPublicKeyTokenFilter)P_0).User = (EleWise.ELMA.Security.Models.IUser)P_1;
	}

	internal static long na6Qoms2A5xDpilaEkD(object P_0, object P_1)
	{
		return ((AbstractNHEntityManager<IUserPublicKeyToken, long>)P_0).Count((IEntityFilter)P_1);
	}

	internal static object zMg9PAsPVuhV7kNOK0w(object P_0)
	{
		return ((EntityManager<IUserPublicKeyToken, long>)P_0).AuthenticationService;
	}

	internal static bool a3hWMjsvJX7TF5DAfDG(object P_0, object P_1)
	{
		return ((EntityManager<IUserPublicKeyToken, long>)P_0).Exists((IEntityFilter)P_1);
	}

	internal static void p2s0IasCkOIPQLKnNxH()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}
}
