using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.API;
using EleWise.ELMA.API.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Security.Services.API;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Service.v1;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Managers;

public class PackageChangesManager : EntityManager<IPackageChanges, long>
{
	internal static PackageChangesManager H7nmfM0nXB4cBe7OdtF;

	[NotNull]
	public new static PackageChangesManager Instance => Locator.GetServiceNotNull<PackageChangesManager>();

	public IEnumerable<IUpdatePackageService> UpdatePackageServices { get; set; }

	public IPublicClientService PublicClientService
	{
		[CompilerGenerated]
		get
		{
			return _003CPublicClientService_003Ek__BackingField;
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
					_003CPublicClientService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_488725796a2e487f95c022f5056d8a88 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public IAuthenticationTokenService AuthenticationTokenService
	{
		[CompilerGenerated]
		get
		{
			return _003CAuthenticationTokenService_003Ek__BackingField;
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
					_003CAuthenticationTokenService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0b98d9f52b424149868b80d852714a70 == 0)
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

	public IPublicApplicationService PublicApplicationService
	{
		[CompilerGenerated]
		get
		{
			return _003CPublicApplicationService_003Ek__BackingField;
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
					_003CPublicApplicationService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f5cf5deab67c429f89caddff1f348afc != 0)
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

	public ITransformationProvider TransformationProvider
	{
		[CompilerGenerated]
		get
		{
			return _003CTransformationProvider_003Ek__BackingField;
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
					_003CTransformationProvider_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_da1dffb5695d4a95af335a696463801b != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[Transaction]
	public virtual void CreatePackageChangesForUser(int count)
	{
		//Discarded unreachable code: IL_0032, IL_0041, IL_004c, IL_0100, IL_0140, IL_014f, IL_015b
		int num = 2;
		int num2 = num;
		IEnumerator<EleWise.ELMA.Security.Models.IUser> enumerator = default(IEnumerator<EleWise.ELMA.Security.Models.IUser>);
		DetachedCriteria val = default(DetachedCriteria);
		EleWise.ELMA.Security.Models.IUser current = default(EleWise.ELMA.Security.Models.IUser);
		while (true)
		{
			switch (num2)
			{
			case 1:
				enumerator = ((ICriteria)jvOjFa0LFOkJN5KYYRo(liNkbD0el0VYLFDPZum(((ICriteria)JcDbJG0B3mNoeBYlUIR(KHasdd0ZmDcX5s0Jsvh(this, FetchOptions.All, InterfaceActivator.TypeOf<EleWise.ELMA.Security.Models.IUser>(), null, null), khXm4O0xZoxf30sgqcU(oF10Rl0lbGJmp82K1kD(0x1869C442 ^ 0x1869CBCC), UserStatus.Active))).Add((ICriterion)r04XqW0ue7hkKqe1mAj(oF10Rl0lbGJmp82K1kD(0x2121ECF9 ^ 0x2121FCE9), val)), wxeZ0C0m8w95IvHbGb4(oF10Rl0lbGJmp82K1kD(0x5EE4A7B ^ 0x5EE5A6B))), count)).List<EleWise.ELMA.Security.Models.IUser>().GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5c3c41b36b4846e0b1701d4e56408883 != 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				return;
			case 2:
				val = ((DetachedCriteria)DCXm3o06k09jxgJIvyi(InterfaceActivator.TypeOf<IPackageChanges>())).SetProjection((IProjection)cGcJp20N2Vax4wPpCFa(oF10Rl0lbGJmp82K1kD(0x116C2699 ^ 0x116C2583)));
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_75955a8c33b24cdca4663f20d9ee3c3b == 0)
				{
					num2 = 1;
				}
				continue;
			}
			try
			{
				while (true)
				{
					IL_00c4:
					int num3;
					if (!nkuob20a5sEQKGycPgt(enumerator))
					{
						num3 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6c7be8ec8b6749dcb0601e062f5515fa == 0)
						{
							num3 = 2;
						}
						goto IL_0050;
					}
					goto IL_00b1;
					IL_00b1:
					current = enumerator.Current;
					num3 = 3;
					goto IL_0050;
					IL_0050:
					while (true)
					{
						switch (num3)
						{
						case 3:
						{
							InstanceOf<IPackageChanges> instanceOf = new InstanceOf<IPackageChanges>();
							EcqLGJ0jKotP88nU1v0(instanceOf.New, PackageChangesStatus.New);
							LnICMq0HqHkNqx57uJG(instanceOf.New, current.Id);
							instanceOf.New.Save();
							num3 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_364662b38d3b4bdb9f3f1f11b8889cdc == 0)
							{
								num3 = 0;
							}
							continue;
						}
						case 1:
							break;
						default:
							goto IL_00c4;
						case 2:
							return;
						}
						break;
					}
					goto IL_00b1;
				}
			}
			finally
			{
				int num4;
				if (enumerator == null)
				{
					num4 = 2;
					goto IL_0104;
				}
				goto IL_011a;
				IL_0104:
				switch (num4)
				{
				case 2:
					goto end_IL_00ef;
				case 1:
					goto end_IL_00ef;
				}
				goto IL_011a;
				IL_011a:
				hkReX80R5VosBhIHqWG(enumerator);
				num4 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d4e4542f38914a2ba9396d8df0939ca9 == 0)
				{
					num4 = 0;
				}
				goto IL_0104;
				end_IL_00ef:;
			}
		}
	}

	[Transaction]
	public virtual IEnumerable<EleWise.ELMA.Security.Models.IUser> GetTopUsersForPrepare(int count)
	{
		int num = SR.GetSetting(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-784481839 ^ -784505253), 24);
		if (num < 0)
		{
			num = 24;
		}
		DetachedCriteria val = DetachedCriteria.For(InterfaceActivator.TypeOf<IPackageChanges>(), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1B3723C5 ^ 0x1B378417)).SetProjection((IProjection)(object)Projections.Property(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xAEB118D ^ 0xAEBB657))).Add((ICriterion)(object)Restrictions.Or((ICriterion)(object)Restrictions.IsNull(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1615559191 ^ -1615584743)), (ICriterion)(object)Restrictions.Le(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--561310391 ^ 0x217442A5), (object)DateTime.Now.AddHours(-num).Ticks)));
		IList<EleWise.ELMA.Security.Models.IUser> list = CreateCriteria(FetchOptions.All, InterfaceActivator.TypeOf<EleWise.ELMA.Security.Models.IUser>(), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x71CDF2F ^ 0x71C80B1)).Add((ICriterion)(object)Restrictions.In(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4A799728 ^ 0x4A793F12), (ICollection)new int[2] { 0, 100 })).Add((ICriterion)(object)Subqueries.PropertyIn(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x32A45635 ^ 0x32A4FE7B), val)).AddOrder(Order.Asc(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1027693337 ^ -1027732311)))
			.SetMaxResults(count)
			.List<EleWise.ELMA.Security.Models.IUser>();
		if (list.Count > 0)
		{
			((IQuery)(object)base.Session.CreateSQLQuery(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x43ED0455 ^ 0x43EDAC0F), TransformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x715714F9 ^ 0x7157BC49)), TransformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1957236745 ^ -1957240711)), 0, TransformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x31C71464 ^ 0x31C7177E)), string.Join(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-959661060 ^ -959667918), list.Select((EleWise.ELMA.Security.Models.IUser u) => u.Id))))).ExecuteUpdate(cleanUpCache: false);
			base.Session.CleanUpCache(InterfaceActivator.TypeOf<IPackageChanges>());
		}
		return list;
	}

	[Transaction]
	public virtual void CreateCacheForUser(EleWise.ELMA.Security.Models.IUser user)
	{
		//Discarded unreachable code: IL_00f6
		int num = 13;
		_003C_003Ec__DisplayClass24_0 _003C_003Ec__DisplayClass24_ = default(_003C_003Ec__DisplayClass24_0);
		IPublicClientSession publicClientSession = default(IPublicClientSession);
		PublicApplicationService.DefaultSystemApplication defaultSystemApplication = default(PublicApplicationService.DefaultSystemApplication);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 8:
					uQJT3h0JrDQ3Qi9FATg(AuthenticationTokenService, _003C_003Ec__DisplayClass24_.authToken);
					num2 = 15;
					continue;
				case 6:
				case 7:
					EcqLGJ0jKotP88nU1v0(_003C_003Ec__DisplayClass24_.packageChanges, PackageChangesStatus.Completed);
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c537c1b3b4be444086af51f6e9112d23 == 0)
					{
						num2 = 0;
					}
					continue;
				case 13:
					_003C_003Ec__DisplayClass24_ = new _003C_003Ec__DisplayClass24_0();
					num2 = 12;
					continue;
				case 2:
					HvXvke02eKSXF8DN8vq();
					num2 = 17;
					continue;
				case 15:
					if (_003C_003Ec__DisplayClass24_.packages == null)
					{
						num2 = 7;
						continue;
					}
					goto case 3;
				case 17:
					Guid.NewGuid();
					num2 = 4;
					continue;
				case 12:
					_003C_003Ec__DisplayClass24_._003C_003E4__this = this;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5028d2018b41471c962aaca947e33b9d == 0)
					{
						num2 = 9;
					}
					continue;
				case 5:
					return;
				default:
					qlqclZ0t8YmuUwMcgr1(_003C_003Ec__DisplayClass24_.packageChanges);
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_11e42501f5004eefaeaccdfe8bd3b619 == 0)
					{
						num2 = 0;
					}
					continue;
				case 14:
					CPA0xT0oBj0wLyMwE4w(PublicClientService, publicClientSession.SessionToken);
					num2 = 8;
					continue;
				case 1:
					return;
				case 16:
					break;
				case 9:
					_003C_003Ec__DisplayClass24_.packageChanges = ((ICriteria)JcDbJG0B3mNoeBYlUIR(JcDbJG0B3mNoeBYlUIR(CreateCriteria((FetchOptions)IYL4qJ0wMLjY0lJsmTP(), InterfaceActivator.TypeOf<IPackageChanges>()), khXm4O0xZoxf30sgqcU(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-848444002 ^ -848443772), user.Id)), Restrictions.Eq((string)oF10Rl0lbGJmp82K1kD(-737960346 ^ -737963544), (object)PackageChangesStatus.New))).List<IPackageChanges>().FirstOrDefault();
					num2 = 10;
					continue;
				case 10:
					if (_003C_003Ec__DisplayClass24_.packageChanges != null)
					{
						_003C_003Ec__DisplayClass24_.packages = null;
						num2 = 2;
					}
					else
					{
						num2 = 5;
					}
					continue;
				case 3:
					AP0d0w0KZE4Dwd6DM3q(_003C_003Ec__DisplayClass24_.packageChanges, ClassSerializationHelper.SerializeObjectByJson(_003C_003Ec__DisplayClass24_.packages));
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e0cdbab05b2b455cab94ec0ba1efc443 == 0)
					{
						num2 = 6;
					}
					continue;
				case 4:
					_003C_003Ec__DisplayClass24_.authToken = AuthenticationTokenService.CreateToken(user);
					num2 = 11;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_651070b1c9bd4381bbb7379d68d6508e != 0)
					{
						num2 = 4;
					}
					continue;
				case 18:
					GS3i0X0UrciOaAOByQZ(NafYqq0C4PThacwh847(this), user, new Action(_003C_003Ec__DisplayClass24_._003CCreateCacheForUser_003Eb__1));
					num2 = 11;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6e35a1cd804541a884550671c71dbb1c == 0)
					{
						num2 = 14;
					}
					continue;
				case 11:
					defaultSystemApplication = EleWise.ELMA.Security.Services.API.PublicApplicationService.DefaultApplications.First((PublicApplicationService.DefaultSystemApplication a) => _003C_003Ec.Oah6iOpjQEJM5shBre6y(a) == EleWise.ELMA.Security.Services.API.PublicApplicationService.AppUid_Agent);
					num2 = 16;
					continue;
				}
				break;
			}
			publicClientSession = (IPublicClientSession)EkZVmn0vnVL9aVFxs7r(PublicClientService, _003C_003Ec__DisplayClass24_.authToken, n0saDN0PwfjrVQSDN1t(defaultSystemApplication));
			num = 18;
		}
	}

	public PackageChangesManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		vKnX5n0hQ9Oj2mRFDdA();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1bc92e0376794fc182b6e366eee82dbd == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool r3vuo30ij3GqLE7OS1v()
	{
		return H7nmfM0nXB4cBe7OdtF == null;
	}

	internal static PackageChangesManager dfeOrX07JR3LGDr2F4n()
	{
		return H7nmfM0nXB4cBe7OdtF;
	}

	internal static object DCXm3o06k09jxgJIvyi(Type P_0)
	{
		return DetachedCriteria.For(P_0);
	}

	internal static object oF10Rl0lbGJmp82K1kD(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object cGcJp20N2Vax4wPpCFa(object P_0)
	{
		return Projections.Property((string)P_0);
	}

	internal static object KHasdd0ZmDcX5s0Jsvh(object P_0, object P_1, Type P_2, object P_3, object P_4)
	{
		return ((EntityManager<IPackageChanges, long>)P_0).CreateCriteria((FetchOptions)P_1, P_2, (string)P_3, (IEntityFilter)P_4);
	}

	internal static object khXm4O0xZoxf30sgqcU(object P_0, object P_1)
	{
		return Restrictions.Eq((string)P_0, P_1);
	}

	internal static object JcDbJG0B3mNoeBYlUIR(object P_0, object P_1)
	{
		return ((ICriteria)P_0).Add((ICriterion)P_1);
	}

	internal static object r04XqW0ue7hkKqe1mAj(object P_0, object P_1)
	{
		return Subqueries.PropertyNotIn((string)P_0, (DetachedCriteria)P_1);
	}

	internal static object wxeZ0C0m8w95IvHbGb4(object P_0)
	{
		return Order.Asc((string)P_0);
	}

	internal static object liNkbD0el0VYLFDPZum(object P_0, object P_1)
	{
		return ((ICriteria)P_0).AddOrder((Order)P_1);
	}

	internal static object jvOjFa0LFOkJN5KYYRo(object P_0, int P_1)
	{
		return ((ICriteria)P_0).SetMaxResults(P_1);
	}

	internal static void EcqLGJ0jKotP88nU1v0(object P_0, PackageChangesStatus P_1)
	{
		((IPackageChanges)P_0).Status = P_1;
	}

	internal static void LnICMq0HqHkNqx57uJG(object P_0, long P_1)
	{
		((IPackageChanges)P_0).UserId = P_1;
	}

	internal static bool nkuob20a5sEQKGycPgt(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void hkReX80R5VosBhIHqWG(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object IYL4qJ0wMLjY0lJsmTP()
	{
		return FetchOptions.First;
	}

	internal static void HvXvke02eKSXF8DN8vq()
	{
		PackageChangesService.InitEmptyDataSets();
	}

	internal static object n0saDN0PwfjrVQSDN1t(object P_0)
	{
		return ((PublicApplicationService.DefaultSystemApplication)P_0).DefaultToken;
	}

	internal static object EkZVmn0vnVL9aVFxs7r(object P_0, Guid P_1, object P_2)
	{
		return ((IPublicClientService)P_0).CreateSession(P_1, (string)P_2);
	}

	internal static object NafYqq0C4PThacwh847(object P_0)
	{
		return ((EntityManager<IPackageChanges, long>)P_0).SecurityService;
	}

	internal static void GS3i0X0UrciOaAOByQZ(object P_0, object P_1, object P_2)
	{
		((ISecurityService)P_0).RunByUser((IUser)P_1, (Action)P_2);
	}

	internal static bool CPA0xT0oBj0wLyMwE4w(object P_0, object P_1)
	{
		return ((IPublicClientService)P_0).RemoveSession((string)P_1);
	}

	internal static void uQJT3h0JrDQ3Qi9FATg(object P_0, Guid P_1)
	{
		((IAuthenticationTokenService)P_0).RemoveToken(P_1);
	}

	internal static void AP0d0w0KZE4Dwd6DM3q(object P_0, object P_1)
	{
		((IPackageChanges)P_0).PackagesInfo = (string)P_1;
	}

	internal static void qlqclZ0t8YmuUwMcgr1(object P_0)
	{
		((IEntity)P_0).Save();
	}

	internal static void vKnX5n0hQ9Oj2mRFDdA()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}
}
