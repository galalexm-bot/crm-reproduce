using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using EleWise.ELMA.Cache;
using EleWise.ELMA.Cache.Attributes;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Licensing;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security.DTO.Models;
using EleWise.ELMA.Security.Extensions;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Type;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class UserGroupManager : EntityManager<IUserGroup, long>
{
	[Component]
	internal class SecurityCacheSetIdAction : ISecurityCacheSetIdAction
	{
		private static SecurityCacheSetIdAction zEJZw5p2M2xoMynF6Twb;

		public void Execute()
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
					AHno2Op2VhD8LKiDhssc(tfQP4Ep2Inb6rOmL10OK(), PHZbJAp24dZ6wbvwQ3rb(-185816410 ^ -185828374));
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0ab7ce9a6369414380df24a533da8346 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		public SecurityCacheSetIdAction()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			K068xFp2QDAVv2j9Komf();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a1d876260ca946cdbdcbec4b9517d613 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static object tfQP4Ep2Inb6rOmL10OK()
		{
			return ComplexCacheService;
		}

		internal static object PHZbJAp24dZ6wbvwQ3rb(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static void AHno2Op2VhD8LKiDhssc(object P_0, object P_1)
		{
			((IComplexCacheService)P_0).RefreshTimestamp((string)P_1);
		}

		internal static bool Bsgc1Hp2spSb5YJBpi2h()
		{
			return zEJZw5p2M2xoMynF6Twb == null;
		}

		internal static SecurityCacheSetIdAction CsgCfHp2YhIKGAPXMZUR()
		{
			return zEJZw5p2M2xoMynF6Twb;
		}

		internal static void K068xFp2QDAVv2j9Komf()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		}
	}

	[Obsolete("Not used", true)]
	public const string GETGROUPSFORUSERS_CACHE_REGION = "GetGroupsByUser";

	internal static UserGroupManager apW841V1l0N8v4D2ZPK;

	public new static UserGroupManager Instance => Locator.GetServiceNotNull<UserGroupManager>();

	private static IComplexCacheService ComplexCacheService => Locator.GetServiceNotNull<IComplexCacheService>();

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
				case 1:
					_003CTransformationProvider_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0dd863774da04dfd9f21706b4b60a6b9 != 0)
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

	protected override void SetupAutoFilter(ICriteria criteria, IEntityFilter filter)
	{
		//Discarded unreachable code: IL_003d, IL_004c
		int num = 5;
		bool? addToNewUser = default(bool?);
		IUserGroupFilter userGroupFilter = default(IUserGroupFilter);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 2:
					return;
				case 4:
					break;
				case 0:
					return;
				case 3:
					addToNewUser = userGroupFilter.AddToNewUser;
					num2 = 6;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a53a06d0e4134332947f6164df41fb0f != 0)
					{
						num2 = 2;
					}
					continue;
				case 6:
					if (!addToNewUser.HasValue)
					{
						num2 = 2;
						continue;
					}
					goto case 1;
				case 1:
					F96pf5QWnrYequVpFZE(criteria, yBefRdQAjjgnVGRI2Ql(BMjDSDQ5HOn8auMu6qG(0x1B3723C5 ^ 0x1B37F2C9), userGroupFilter.AddToNewUser));
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3fde536d235f4cd390062db7c7cf1219 == 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					YwKcMBQpetxGaiqI4lE(this, criteria, filter);
					num2 = 4;
					continue;
				}
				break;
			}
			userGroupFilter = (IUserGroupFilter)filter;
			num = 3;
		}
	}

	public virtual IEnumerable<long> GetGroupsByUser(long userId)
	{
		return GetGroupsByUser(userId, recursive: true);
	}

	public virtual IEnumerable<long> GetGroupsByUser(long userId, bool recursive)
	{
		_003C_003Ec__DisplayClass12_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass12_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.userId = userId;
		CS_0024_003C_003E8__locals0.recursive = recursive;
		return ComplexCacheService.GetOrAdd(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2E78F5A0 ^ 0x2E782488) + CS_0024_003C_003E8__locals0.userId + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-764392425 ^ -764389329) + CS_0024_003C_003E8__locals0.recursive.ToString(), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1801396866 ^ -1801450446), delegate
		{
			//Discarded unreachable code: IL_0079, IL_0088
			int num = 3;
			ISQLQuery val = default(ISQLQuery);
			int num3 = default(int);
			SqlSubQuery sqlSubQuery = default(SqlSubQuery);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						((IQuery)val).SetParameter(num3, ((object[])_003C_003Ec__DisplayClass12_0.FFeq3tp2SKgiDnl5cDDi(sqlSubQuery))[num3]);
						num2 = 5;
						continue;
					case 1:
					case 7:
						if (num3 >= ((Array)_003C_003Ec__DisplayClass12_0.FFeq3tp2SKgiDnl5cDDi(sqlSubQuery)).Length)
						{
							num2 = 6;
							continue;
						}
						goto default;
					case 6:
						return ((IQuery)_003C_003Ec__DisplayClass12_0.PSGgfRp29WWhV96o4dSI(val, false)).List<object>().Select(Convert.ToInt64).ToArray();
					case 4:
						num3 = 0;
						num2 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d689f5970f6345a7af332e1f7092123f == 0)
						{
							num2 = 1;
						}
						continue;
					case 3:
						sqlSubQuery = (SqlSubQuery)_003C_003Ec__DisplayClass12_0.gquK3Sp2rS7cZ4xsSa90(CS_0024_003C_003E8__locals0._003C_003E4__this, CS_0024_003C_003E8__locals0.userId, CS_0024_003C_003E8__locals0.recursive);
						num2 = 2;
						continue;
					case 5:
						num3++;
						num2 = 7;
						continue;
					case 2:
						break;
					}
					break;
				}
				val = (ISQLQuery)_003C_003Ec__DisplayClass12_0.I6wZnvp2bKNDpTFIlqyE(_003C_003Ec__DisplayClass12_0.SsuBMgp23uyvZsC1yOsf(CS_0024_003C_003E8__locals0._003C_003E4__this), _003C_003Ec__DisplayClass12_0.KMukuQp2yy5SYCArWnEi(sqlSubQuery));
				num = 4;
			}
		});
	}

	public virtual SqlSubQuery GetGroupsByUserQuery(long userId, bool recursive)
	{
		return (SqlSubQuery)B2Wi8eQ6XALLlKrflY1(XrX3DNQ7xs2uR0ed8pN(aV5wMfQX4eKgHjP7Ipe(this), string.Format((string)(recursive ? SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1076846736 ^ -1076867380) : BMjDSDQ5HOn8auMu6qG(0xC66FB14 ^ 0xC662A7A)), cMPoDqQnrCiW4qW8enI(TransformationProvider.Dialect, BMjDSDQ5HOn8auMu6qG(-1957236745 ^ -1957232657)), cMPoDqQnrCiW4qW8enI(cSlRLkQiHSJv8AiUCbr(TransformationProvider), BMjDSDQ5HOn8auMu6qG(0x190F47B7 ^ 0x190F44AD)), ((Dialect)cSlRLkQiHSJv8AiUCbr(TransformationProvider)).QuoteIfNeeded((string)(recursive ? BMjDSDQ5HOn8auMu6qG(--1130812004 ^ 0x4366923C) : SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x43ED0455 ^ 0x43ED0BBD))))), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-177725793 ^ -177701197), userId);
	}

	public virtual SqlSubQuery GetGroupsByUserQuery(long userId)
	{
		return (SqlSubQuery)jVsdtWQlDdVyK48W3bC(this, userId, true);
	}

	public virtual IEnumerable<IUserGroup> GetGroupsByIds(long[] Ids, Guid typeGuid)
	{
		if (Ids == null)
		{
			throw new ArgumentNullException(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x31274285 ^ 0x3127909B));
		}
		if (Ids.Length == 0)
		{
			return new List<IUserGroup>();
		}
		ICriteria val = base.Session.CreateCriteria(typeof(IUserGroup)).Add((ICriterion)(object)Restrictions.In(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-426925384 ^ -426921304), (ICollection)Ids));
		if (typeGuid != Guid.Empty)
		{
			val.Add((ICriterion)(object)Restrictions.Eq(base.EntityTypeUidPropertyName, (object)typeGuid));
		}
		return Find(val);
	}

	[ContextCache]
	public virtual IEnumerable<long> GetUsersByGroup(long groupId)
	{
		return GetUsersByGroup(groupId, null);
	}

	public virtual IDictionary<long, List<long>> GetUsersByManyGroups(long[] groupIds)
	{
		return (from v in ((IQuery)CreateUsersByManyGroupsSQLQuery(groupIds, null, resultAsEntity: false, forceGrouping: true)).List<object[]>().Select(delegate(object[] o)
			{
				long result = 0L;
				long result2 = 0L;
				if (o[0] != null)
				{
					long.TryParse(o[0].ToString(), out result);
				}
				long.TryParse(o[1].ToString(), out result2);
				return new
				{
					UserId = ((result == 0L) ? null : new long?(result)),
					GroupdId = result2
				};
			})
			group v by v.GroupdId).ToDictionary(g => g.Key, g => (from o in g
			where o.UserId.HasValue
			select o into s
			select s.UserId.Value).ToList());
	}

	public virtual IEnumerable<long> GetUsersByGroup(long groupId, UserStatus[] userStatuses)
	{
		return ((IQuery)CreateUsersByGroupSQLQuery(groupId, userStatuses, resultAsEntity: false)).List<object>().Select(Convert.ToInt64);
	}

	public virtual IEnumerable<EleWise.ELMA.Security.Models.IUser> GetUsersByGroupAsEntity(long groupId, UserStatus[] userStatuses)
	{
		return ((IQuery)CreateUsersByGroupSQLQuery(groupId, userStatuses, resultAsEntity: true).AddEntity(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2104667969 ^ -2104655209), InterfaceActivator.TypeOf<EleWise.ELMA.Security.Models.IUser>())).List<EleWise.ELMA.Security.Models.IUser>();
	}

	protected virtual ISQLQuery CreateUsersByGroupSQLQuery(long groupId, UserStatus[] userStatuses, bool resultAsEntity)
	{
		return CreateUsersByManyGroupsSQLQuery(new long[1] { groupId }, userStatuses, resultAsEntity);
	}

	private ISQLQuery CreateUsersByManyGroupsSQLQuery(long[] groupIds, UserStatus[] userStatuses, bool resultAsEntity, bool forceGrouping = false)
	{
		//Discarded unreachable code: IL_0110, IL_0218, IL_0444, IL_0453, IL_057b, IL_05bc, IL_05cb
		//IL_048c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0492: Expected O, but got Unknown
		int num = 4;
		StringBuilder stringBuilder = default(StringBuilder);
		string text4 = default(string);
		bool flag = default(bool);
		bool flag2 = default(bool);
		string text = default(string);
		string text2 = default(string);
		string text3 = default(string);
		string text5 = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3;
				switch (num2)
				{
				case 2:
					WKpu4RQxqDYO8wk47wO(stringBuilder, BMjDSDQ5HOn8auMu6qG(0x7CAA49C6 ^ 0x7CAA9BB0), text4);
					num2 = 18;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5c3c41b36b4846e0b1701d4e56408883 == 0)
					{
						num2 = 21;
					}
					continue;
				case 19:
					if (!flag)
					{
						num2 = 16;
						continue;
					}
					goto case 32;
				case 4:
					stringBuilder = new StringBuilder();
					num2 = 3;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f6614d006512404f8cab65f09d3e1c89 == 0)
					{
						num2 = 1;
					}
					continue;
				case 24:
					num3 = ((userStatuses.Length == 0) ? 1 : 0);
					break;
				case 14:
					if (!flag2)
					{
						num2 = 22;
						continue;
					}
					goto case 10;
				case 5:
					text = (string)cMPoDqQnrCiW4qW8enI(TransformationProvider.Dialect, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1801396866 ^ -1801413338));
					num2 = 27;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e2203cd019614c439eaf162fdd0eb05d == 0)
					{
						num2 = 6;
					}
					continue;
				case 31:
					LSrBcBQZRhPmpuHGYBk(stringBuilder, BMjDSDQ5HOn8auMu6qG(-1076846736 ^ -1076867780), text, text2);
					num2 = 12;
					continue;
				default:
					text2 = (string)cMPoDqQnrCiW4qW8enI(TransformationProvider.Dialect, BMjDSDQ5HOn8auMu6qG(0x3B1D6430 ^ 0x3B1D6BEC));
					num2 = 9;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7ced317202a44233ac3d0deafcdd1923 == 0)
					{
						num2 = 11;
					}
					continue;
				case 32:
					WKpu4RQxqDYO8wk47wO(stringBuilder, BMjDSDQ5HOn8auMu6qG(0x5FD42272 ^ 0x5FD4F154), text4);
					num2 = 18;
					continue;
				case 29:
					WKpu4RQxqDYO8wk47wO(stringBuilder, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-426925384 ^ -426937888), text3);
					num2 = 20;
					continue;
				case 15:
					flag = groupIds.Length > 1 || forceGrouping;
					num2 = 17;
					continue;
				case 21:
					LSrBcBQZRhPmpuHGYBk(stringBuilder, BMjDSDQ5HOn8auMu6qG(0x28EBA022 ^ 0x28EB7290), text3, cMPoDqQnrCiW4qW8enI(cSlRLkQiHSJv8AiUCbr(TransformationProvider), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6AA79E0 ^ 0x6AA69F0)));
					num2 = 8;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_75955a8c33b24cdca4663f20d9ee3c3b == 0)
					{
						num2 = 23;
					}
					continue;
				case 22:
					LSrBcBQZRhPmpuHGYBk(stringBuilder, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7A093321 ^ 0x7A09E1FD), text5, string.Join(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1965109395 ^ -1965107805), userStatuses.Cast<int>().ToArray()));
					num2 = 13;
					continue;
				case 6:
					WKpu4RQxqDYO8wk47wO(stringBuilder, BMjDSDQ5HOn8auMu6qG(-731479136 ^ -731492186), text3);
					num2 = 25;
					continue;
				case 28:
					text3 = TransformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-959661060 ^ -959661850));
					num2 = 5;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a3b9996565fb40c18f26b204beedcb7f == 0)
					{
						num2 = 4;
					}
					continue;
				case 12:
					WKpu4RQxqDYO8wk47wO(stringBuilder, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6A79A716 ^ 0x6A797560), text4);
					num2 = 6;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3fde536d235f4cd390062db7c7cf1219 == 0)
					{
						num2 = 9;
					}
					continue;
				case 17:
					if (!resultAsEntity)
					{
						num2 = 7;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2f11eccd7e8f4339a0b03ad9fe1eb947 == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 26;
				case 23:
					LSrBcBQZRhPmpuHGYBk(stringBuilder, BMjDSDQ5HOn8auMu6qG(0x7DABA580 ^ 0x7DAB775C), text5, string.Join((string)BMjDSDQ5HOn8auMu6qG(0x84482CB ^ 0x8449805), userStatuses.Cast<int>().ToArray()));
					num2 = 29;
					continue;
				case 11:
					text5 = (string)cMPoDqQnrCiW4qW8enI(TransformationProvider.Dialect, BMjDSDQ5HOn8auMu6qG(0x8875F5C ^ 0x88750D2));
					num2 = 15;
					continue;
				case 7:
				case 8:
					if (flag2)
					{
						num2 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0a82cc1379bc48bbb836c94da8cb8564 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 6;
				case 10:
				case 13:
				case 20:
					return (ISQLQuery)MqMPyWQmKdB9BHSFNmb(HGVaGIQuE49GHg8MQJ6(HeEDHLQBcI8RUom5O0t(aV5wMfQX4eKgHjP7Ipe(this), stringBuilder.ToString()), false), BMjDSDQ5HOn8auMu6qG(0x37FE8EDE ^ 0x37FE5DA2), groupIds);
				case 1:
					stringBuilder.AppendFormat(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x71BC7C31 ^ 0x71BCAF37), text3);
					num2 = 19;
					continue;
				case 27:
					text4 = (string)cMPoDqQnrCiW4qW8enI(cSlRLkQiHSJv8AiUCbr(TransformationProvider), BMjDSDQ5HOn8auMu6qG(0x51BB29A6 ^ 0x51BB39BE));
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0a82cc1379bc48bbb836c94da8cb8564 == 0)
					{
						num2 = 0;
					}
					continue;
				case 9:
					LSrBcBQZRhPmpuHGYBk(stringBuilder, BMjDSDQ5HOn8auMu6qG(-1429357207 ^ -1429377061), text3, cMPoDqQnrCiW4qW8enI(cSlRLkQiHSJv8AiUCbr(TransformationProvider), BMjDSDQ5HOn8auMu6qG(0x1A9A1A63 ^ 0x1A9A0A73)));
					num2 = 14;
					continue;
				case 3:
					if (userStatuses != null)
					{
						num2 = 24;
						continue;
					}
					num3 = 1;
					break;
				case 26:
					rOqGtkQNhpw60ao1OtM(stringBuilder, BMjDSDQ5HOn8auMu6qG(0x46F7DF98 ^ 0x46F70DB6));
					num2 = 31;
					continue;
				case 30:
					goto end_IL_0012;
				case 16:
				case 18:
					WKpu4RQxqDYO8wk47wO(stringBuilder, BMjDSDQ5HOn8auMu6qG(-1965109395 ^ -1965155247), text);
					num2 = 4;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a9bad31b2eb24bb9b571e9b822d133bf == 0)
					{
						num2 = 30;
					}
					continue;
				case 25:
					stringBuilder.AppendFormat((string)BMjDSDQ5HOn8auMu6qG(-1943394692 ^ -1943342032), text, text2);
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a33ec05b36714591b0adf150b655c9a8 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				flag2 = (byte)num3 != 0;
				num2 = 28;
				continue;
				end_IL_0012:
				break;
			}
			WKpu4RQxqDYO8wk47wO(stringBuilder, BMjDSDQ5HOn8auMu6qG(-731479136 ^ -731491882), text4);
			num = 10;
		}
	}

	public IUserGroup Load(string name)
	{
		return ((ICriteria)reqot9QeDIFqJXuoVbL(this, null)).Add((ICriterion)yBefRdQAjjgnVGRI2Ql(BMjDSDQ5HOn8auMu6qG(0x2121ECF9 ^ 0x21212185), name)).UniqueResult<IUserGroup>();
	}

	public override void SetupFilter(ICriteria criteria, IEntityFilter filter)
	{
		//Discarded unreachable code: IL_00b3, IL_019e, IL_020a, IL_0219, IL_0254, IL_0263, IL_0272, IL_0282, IL_0292, IL_03e8, IL_03f7, IL_0407, IL_0416
		int num = 3;
		IConcurrentLicenseInfo concurrentLicenseInfo = default(IConcurrentLicenseInfo);
		ILicensedUnit mainLicensedUnit = default(ILicensedUnit);
		IUserGroupFilter userGroupFilter = default(IUserGroupFilter);
		List<long> list = default(List<long>);
		while (true)
		{
			int num2 = num;
			object obj;
			while (true)
			{
				switch (num2)
				{
				case 14:
					if (aYb1KvQRlsVZcihEEbP(concurrentLicenseInfo))
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5c3c41b36b4846e0b1701d4e56408883 == 0)
						{
							num2 = 19;
						}
						continue;
					}
					goto case 6;
				case 2:
				case 10:
					F96pf5QWnrYequVpFZE(criteria, Restrictions.Eq((string)WuUOOVQH1kN3IoqHBGY(this), (object)base.ImplementationTypeUid));
					num2 = 9;
					continue;
				case 1:
				case 4:
				case 8:
				case 11:
				case 21:
					base.SetupFilter(criteria, filter);
					num2 = 24;
					continue;
				case 25:
					if (!dSe852QjlseaVdSiNOX(f4Ak6GQLp5vbijBlDs8(filter), null))
					{
						num2 = 20;
						continue;
					}
					goto case 2;
				case 6:
				case 23:
					criteria.Add((ICriterion)(object)Restrictions.Not((ICriterion)yBefRdQAjjgnVGRI2Ql(BMjDSDQ5HOn8auMu6qG(0x5EE4A7B ^ 0x5EE45E5), SecurityConstants.PrivilegeUsersGroupUid)));
					num2 = 17;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a9bad31b2eb24bb9b571e9b822d133bf != 0)
					{
						num2 = 5;
					}
					continue;
				case 9:
				case 20:
					mainLicensedUnit = ComponentManager.Current.ModuleManager.MainLicensedUnit;
					num2 = 16;
					continue;
				case 24:
					return;
				case 18:
					if (concurrentLicenseInfo == null)
					{
						num2 = 6;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_364662b38d3b4bdb9f3f1f11b8889cdc != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 14;
				default:
					if (userGroupFilter.Workers.Count <= 0)
					{
						num2 = 21;
						continue;
					}
					break;
				case 12:
					F96pf5QWnrYequVpFZE(criteria, Restrictions.In((IProjection)(object)Projections.Property((string)BMjDSDQ5HOn8auMu6qG(0xAEB118D ^ 0xAEB019D)), (ICollection)list));
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a16ce287ba7944e2afcf4e52864ec01d != 0)
					{
						num2 = 1;
					}
					continue;
				case 3:
					if (filter == null)
					{
						num2 = 2;
						continue;
					}
					goto case 25;
				case 22:
					if (Ham1OKQwFxb6CgiWKni(list) > 1000)
					{
						num2 = 13;
						continue;
					}
					goto case 12;
				case 5:
					obj = null;
					goto end_IL_0012;
				case 13:
				{
					object obj2 = zkQQGyQv1B7Xu7PSUnS(BMjDSDQ5HOn8auMu6qG(-1973849202 ^ -1973837794), cMPoDqQnrCiW4qW8enI(cSlRLkQiHSJv8AiUCbr(TransformationProvider), BMjDSDQ5HOn8auMu6qG(-219609047 ^ -219604935)), XIXVdLQ2l8YuPP8cphx(TransformationProvider, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2068904634 ^ -2068852416), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-905821499 ^ -905799963)), HPSKGoQPA4BNWrrmlJM(cSlRLkQiHSJv8AiUCbr(TransformationProvider), DbType.Int64));
					object[] obj3 = new object[2]
					{
						string.Join(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2104667969 ^ -2104671097), list),
						SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1429500015 ^ -1429496919)
					};
					IType[] array = (IType[])(object)new StringType[2]
					{
						(StringType)NHibernateUtil.StringClob,
						NHibernateUtil.String
					};
					criteria.Add((ICriterion)YlL5oSQCJ2wGCAI1Gkr(obj2, obj3, array));
					num2 = 8;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a16ce287ba7944e2afcf4e52864ec01d != 0)
					{
						num2 = 8;
					}
					continue;
				}
				case 15:
					if (userGroupFilter == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_77bfde1a0739446782f0bda00c988550 == 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 7;
				case 16:
					if (mainLicensedUnit == null)
					{
						num2 = 5;
						continue;
					}
					obj = DWHk9TQa6vhv2K2iEFi(mainLicensedUnit) as IConcurrentLicenseInfo;
					goto end_IL_0012;
				case 7:
					if (userGroupFilter.Workers == null)
					{
						num2 = 11;
						continue;
					}
					goto default;
				case 17:
				case 19:
					userGroupFilter = filter as IUserGroupFilter;
					num2 = 15;
					continue;
				case 26:
					break;
				}
				list = (from w in userGroupFilter.Workers.Where(delegate(Worker w)
					{
						//Discarded unreachable code: IL_0069, IL_0078
						int num3 = 1;
						int num4 = num3;
						while (true)
						{
							switch (num4)
							{
							case 2:
								return _003C_003Ec.W2kByZpPAaGktl026WHq(w) > 0;
							default:
								return false;
							case 1:
								if (!_003C_003Ec.WonbEopP5E9xAoOe23TV(_003C_003Ec.xVY3BKpPpw6umHVvWjaw(w), UserGroupDTO.MetadataUid))
								{
									num4 = 0;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0d00d0d8fcd5481b8bdc09ec82b1ea36 != 0)
									{
										num4 = 0;
									}
									break;
								}
								goto case 2;
							}
						}
					})
					select _003C_003Ec.W2kByZpPAaGktl026WHq(w)).ToList();
				num2 = 22;
				continue;
				end_IL_0012:
				break;
			}
			concurrentLicenseInfo = (IConcurrentLicenseInfo)obj;
			num = 18;
		}
	}

	public uint? GetMaxGroupUsersCount(IUserGroup group)
	{
		_003C_003Ec__DisplayClass24_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass24_0();
		CS_0024_003C_003E8__locals0.group = group;
		ILicensedModuleAccessGroup licensedModuleAccessGroup = ComponentManager.Current.GetExtensionPoints<ILicensedModuleAccessGroup>().FirstOrDefault((ILicensedModuleAccessGroup g) => _003C_003Ec__DisplayClass24_0.pV6EBHpPlGJdVuO2xXBk(_003C_003Ec__DisplayClass24_0.w8TZ1tpP6tIkZtUkoj79(g), CS_0024_003C_003E8__locals0.group.Uid));
		if (licensedModuleAccessGroup != null && ComponentManager.Current.ModuleManager.FindUnitByUid(licensedModuleAccessGroup.ModuleUid) is ILicensedUnit licensedUnit && licensedUnit.GetLicenseInfo() is IWorkplaceLicenseInfo workplaceLicenseInfo && workplaceLicenseInfo.WorkplaceCount.HasValue)
		{
			return workplaceLicenseInfo.WorkplaceCount.Value;
		}
		IPrivilegeModuleAccessGroup privilegeModuleAccessGroup = ComponentManager.Current.GetExtensionPoints<IPrivilegeModuleAccessGroup>().FirstOrDefault((IPrivilegeModuleAccessGroup g) => _003C_003Ec__DisplayClass24_0.pV6EBHpPlGJdVuO2xXBk(_003C_003Ec__DisplayClass24_0.XOrtItpPNFZxMriWed2D(g), _003C_003Ec__DisplayClass24_0.lS9uP9pPZuprRLHsaDF8(CS_0024_003C_003E8__locals0.group)));
		if (privilegeModuleAccessGroup != null && ComponentManager.Current.ModuleManager.FindUnitByUid(privilegeModuleAccessGroup.ModuleUid) is ILicensedUnit licensedUnit2 && licensedUnit2.GetLicenseInfo() is IConcurrentLicenseInfo concurrentLicenseInfo)
		{
			return concurrentLicenseInfo.PrivilegeCount;
		}
		return null;
	}

	[Transaction]
	[PublicApiMember]
	public override void Save(IUserGroup obj)
	{
		//Discarded unreachable code: IL_0074, IL_0083
		int num = 9;
		int num2 = num;
		uint? maxGroupUsersCount = default(uint?);
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 6:
				return;
			case 7:
				base.Save(obj);
				num2 = 6;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4b098d453cbc45388569889eb6ab714d == 0)
				{
					num2 = 4;
				}
				continue;
			case 2:
				if (maxGroupUsersCount.HasValue)
				{
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a9bad31b2eb24bb9b571e9b822d133bf == 0)
					{
						num2 = 3;
					}
					continue;
				}
				goto case 7;
			case 4:
				throw new LicenseException(SR.T((string)BMjDSDQ5HOn8auMu6qG(-1712587919 ^ -1712640251), obj.Name, maxGroupUsersCount.Value, num3 - maxGroupUsersCount.Value));
			case 1:
				throw new InvalidOperationException((string)O8ialrQUR2SNfdOEYuv(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5EE4A7B ^ 0x5EE9E57)));
			case 8:
				maxGroupUsersCount = GetMaxGroupUsersCount(obj);
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_05864899c47d415d8fae32c68fb25d39 == 0)
				{
					num2 = 2;
				}
				continue;
			case 5:
				Sipl8TQK8imfmyDADFR(obj.Groups);
				num2 = 7;
				continue;
			case 9:
				if (!HasCircle(obj))
				{
					num2 = 8;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8dab57df677749fba2d5364cf752799f == 0)
					{
						num2 = 7;
					}
					continue;
				}
				goto case 1;
			case 3:
				num3 = mCKWifQo9fNDuJn0d9c(obj.Users);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4b098d453cbc45388569889eb6ab714d != 0)
				{
					num2 = 0;
				}
				continue;
			}
			if (num3 > maxGroupUsersCount.Value)
			{
				num2 = 3;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_94a7beb9ab90455caa18ecaa3b17b19c == 0)
				{
					num2 = 4;
				}
			}
			else
			{
				K7KulYQJikuil2RoIn7(obj.OrganizationItems);
				num2 = 5;
			}
		}
	}

	public static int GetLicensedGroupUsers(IEnumerable groupUsers)
	{
		//Discarded unreachable code: IL_004d, IL_005c
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (groupUsers != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0a82cc1379bc48bbb836c94da8cb8564 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			default:
				return 0;
			case 1:
				return groupUsers.OfType<EleWise.ELMA.Security.Models.IUser>().Count(delegate(EleWise.ELMA.Security.Models.IUser u)
				{
					//Discarded unreachable code: IL_0052, IL_0061
					int num3 = 1;
					int num4 = num3;
					while (true)
					{
						switch (num4)
						{
						case 1:
							if (u.Status != 0)
							{
								num4 = 0;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4b1278f673174e87a9fb6665eab69fc6 == 0)
								{
									num4 = 0;
								}
								break;
							}
							goto case 2;
						case 2:
							return _003C_003Ec.So6mGlpPWtVlZ4reRjud(u.Uid, SecurityConstants.AdminUserUid);
						default:
							return false;
						}
					}
				});
			}
		}
	}

	public bool HasCircle(IUserGroup userGroup)
	{
		return FindCircle(userGroup, new HashSet<IUserGroup>(), userGroup);
	}

	private static bool FindCircle(object findGroup, ISet<IUserGroup> set, object userGroup)
	{
		foreach (IUserGroup item in (IEnumerable<IUserGroup>)((IUserGroup)userGroup).Groups)
		{
			if (item == findGroup)
			{
				return true;
			}
			if (!set.Contains(item))
			{
				set.Add(item);
				if (FindCircle(findGroup, set, item))
				{
					return true;
				}
			}
		}
		return false;
	}

	public override ExportRuleList ExportRules()
	{
		int num = 1;
		int num2 = num;
		Type type = default(Type);
		while (true)
		{
			switch (num2)
			{
			case 1:
				type = InterfaceActivator.TypeOf<IUserGroup>();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1c9893e65c104705bb8b228f8a38d9cd == 0)
				{
					num2 = 0;
				}
				continue;
			}
			ExportRuleList exportRuleList = new ExportRuleList();
			ExportRule exportRule = new ExportRule();
			KhE8PxQtafWF1pSajVt(exportRule, type);
			exportRule.PropertyName = (string)BMjDSDQ5HOn8auMu6qG(-1943394692 ^ -1943341200);
			fKvZscQhmlZHqXWhZi4(exportRule, ExportRuleType.Export);
			exportRuleList.Add(exportRule);
			ExportRule exportRule2 = new ExportRule();
			KhE8PxQtafWF1pSajVt(exportRule2, type);
			LrLeESQOKO2wjjLOB43(exportRule2, BMjDSDQ5HOn8auMu6qG(0x417D81DE ^ 0x417DCBF2));
			fKvZscQhmlZHqXWhZi4(exportRule2, ExportRuleType.Export);
			exportRuleList.Add(exportRule2);
			ExportRule obj = new ExportRule
			{
				ParentType = type
			};
			LrLeESQOKO2wjjLOB43(obj, BMjDSDQ5HOn8auMu6qG(0x46F7DF98 ^ 0x46F712CA));
			fKvZscQhmlZHqXWhZi4(obj, ExportRuleType.Export);
			exportRuleList.Add(obj);
			ExportRule exportRule3 = new ExportRule();
			KhE8PxQtafWF1pSajVt(exportRule3, type);
			exportRule3.PropertyName = (string)BMjDSDQ5HOn8auMu6qG(0xAEB118D ^ 0xAEB5B15);
			fKvZscQhmlZHqXWhZi4(exportRule3, ExportRuleType.Export);
			exportRuleList.Add(exportRule3);
			ExportRule obj2 = new ExportRule
			{
				ParentType = type
			};
			LrLeESQOKO2wjjLOB43(obj2, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--553267277 ^ 0x20FA6B57));
			fKvZscQhmlZHqXWhZi4(obj2, ExportRuleType.Export);
			exportRuleList.Add(obj2);
			ExportRule exportRule4 = new ExportRule();
			KhE8PxQtafWF1pSajVt(exportRule4, type);
			LrLeESQOKO2wjjLOB43(exportRule4, BMjDSDQ5HOn8auMu6qG(0x397B0322 ^ 0x397BBD2A));
			fKvZscQhmlZHqXWhZi4(exportRule4, ExportRuleType.Export);
			exportRuleList.Add(exportRule4);
			ExportRule obj3 = new ExportRule
			{
				ParentType = type
			};
			LrLeESQOKO2wjjLOB43(obj3, BMjDSDQ5HOn8auMu6qG(0x5EE4A7B ^ 0x5EE9F3F));
			fKvZscQhmlZHqXWhZi4(obj3, ExportRuleType.Export);
			exportRuleList.Add(obj3);
			ExportRule exportRule5 = new ExportRule();
			KhE8PxQtafWF1pSajVt(exportRule5, type);
			LrLeESQOKO2wjjLOB43(exportRule5, BMjDSDQ5HOn8auMu6qG(-714706387 ^ -714692743));
			fKvZscQhmlZHqXWhZi4(exportRule5, ExportRuleType.Export);
			exportRuleList.Add(exportRule5);
			ExportRule obj4 = new ExportRule
			{
				ParentType = type,
				PropertyName = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1618182 ^ 0x16154EE)
			};
			fKvZscQhmlZHqXWhZi4(obj4, ExportRuleType.Export);
			exportRuleList.Add(obj4);
			ExportRule obj5 = new ExportRule
			{
				ParentType = type,
				PropertyName = (string)BMjDSDQ5HOn8auMu6qG(--1983795824 ^ 0x763E9F0C)
			};
			fKvZscQhmlZHqXWhZi4(obj5, ExportRuleType.Export);
			exportRuleList.Add(obj5);
			ExportRule exportRule6 = new ExportRule();
			KhE8PxQtafWF1pSajVt(exportRule6, type);
			LrLeESQOKO2wjjLOB43(exportRule6, BMjDSDQ5HOn8auMu6qG(0x31C71464 ^ 0x31C7C1E4));
			exportRule6.ExportRuleType = ExportRuleType.Export;
			exportRuleList.Add(exportRule6);
			ExportRule exportRule7 = new ExportRule();
			KhE8PxQtafWF1pSajVt(exportRule7, type);
			exportRule7.PropertyName = (string)BMjDSDQ5HOn8auMu6qG(-1329706983 ^ -1329671303);
			fKvZscQhmlZHqXWhZi4(exportRule7, ExportRuleType.Export);
			exportRuleList.Add(exportRule7);
			ExportRule exportRule8 = new ExportRule();
			KhE8PxQtafWF1pSajVt(exportRule8, type);
			LrLeESQOKO2wjjLOB43(exportRule8, BMjDSDQ5HOn8auMu6qG(-816887841 ^ -816887743));
			fKvZscQhmlZHqXWhZi4(exportRule8, ExportRuleType.Export);
			exportRuleList.Add(exportRule8);
			ExportRule obj6 = new ExportRule
			{
				ParentType = type
			};
			LrLeESQOKO2wjjLOB43(obj6, BMjDSDQ5HOn8auMu6qG(0xA5DAE86 ^ 0xA5D7B20));
			fKvZscQhmlZHqXWhZi4(obj6, ExportRuleType.Export);
			exportRuleList.Add(obj6);
			ExportRule exportRule9 = new ExportRule();
			KhE8PxQtafWF1pSajVt(exportRule9, type);
			LrLeESQOKO2wjjLOB43(exportRule9, BMjDSDQ5HOn8auMu6qG(-698589567 ^ -698559999));
			fKvZscQhmlZHqXWhZi4(exportRule9, ExportRuleType.Export);
			exportRuleList.Add(exportRule9);
			return exportRuleList;
		}
	}

	[PublicApiMember]
	public virtual bool CheckUserInGroup(EleWise.ELMA.Security.Models.IUser user, IUserGroup userGroup)
	{
		return ((UserGroupManager)bbAUGAQq9IC69jUc01f()).GetUsersByGroup(userGroup.Id).Contains(user.Id);
	}

	[PublicApiMember]
	public virtual IEnumerable<IUser> GetUsersByGroup(IUserGroup userGroup)
	{
		return GetUsersByGroup(userGroup, null);
	}

	[PublicApiMember]
	public virtual IEnumerable<EleWise.ELMA.Security.Models.IUser> GetUsersByGroup(IUserGroup userGroup, UserStatus[] userStatus)
	{
		return GetUsersByGroupAsEntity(userGroup.Id, userStatus);
	}

	public UserGroupManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		E4m9WUQcksfRyJ8NOG6();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_73b92e1f752f422d899693d4318e4486 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool tHsSURVzXAnBR48iWtr()
	{
		return apW841V1l0N8v4D2ZPK == null;
	}

	internal static UserGroupManager s8dt79Qkc684S2jeiI8()
	{
		return apW841V1l0N8v4D2ZPK;
	}

	internal static void YwKcMBQpetxGaiqI4lE(object P_0, object P_1, object P_2)
	{
		((EntityManager<IUserGroup, long>)P_0).SetupAutoFilter((ICriteria)P_1, (IEntityFilter)P_2);
	}

	internal static object BMjDSDQ5HOn8auMu6qG(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object yBefRdQAjjgnVGRI2Ql(object P_0, object P_1)
	{
		return Restrictions.Eq((string)P_0, P_1);
	}

	internal static object F96pf5QWnrYequVpFZE(object P_0, object P_1)
	{
		return ((ICriteria)P_0).Add((ICriterion)P_1);
	}

	internal static object aV5wMfQX4eKgHjP7Ipe(object P_0)
	{
		return ((NHManagerBase)P_0).Session;
	}

	internal static object cMPoDqQnrCiW4qW8enI(object P_0, object P_1)
	{
		return ((Dialect)P_0).QuoteIfNeeded((string)P_1);
	}

	internal static object cSlRLkQiHSJv8AiUCbr(object P_0)
	{
		return ((ITransformationProvider)P_0).Dialect;
	}

	internal static object XrX3DNQ7xs2uR0ed8pN(object P_0, object P_1)
	{
		return ((ISession)P_0).CreateSQLSubQuery((string)P_1);
	}

	internal static object B2Wi8eQ6XALLlKrflY1(object P_0, object P_1, object P_2)
	{
		return ((SqlSubQuery)P_0).SetParameter((string)P_1, P_2);
	}

	internal static object jVsdtWQlDdVyK48W3bC(object P_0, long userId, bool recursive)
	{
		return ((UserGroupManager)P_0).GetGroupsByUserQuery(userId, recursive);
	}

	internal static object rOqGtkQNhpw60ao1OtM(object P_0, object P_1)
	{
		return ((StringBuilder)P_0).Append((string)P_1);
	}

	internal static object LSrBcBQZRhPmpuHGYBk(object P_0, object P_1, object P_2, object P_3)
	{
		return ((StringBuilder)P_0).AppendFormat((string)P_1, P_2, P_3);
	}

	internal static object WKpu4RQxqDYO8wk47wO(object P_0, object P_1, object P_2)
	{
		return ((StringBuilder)P_0).AppendFormat((string)P_1, P_2);
	}

	internal static object HeEDHLQBcI8RUom5O0t(object P_0, object P_1)
	{
		return ((ISession)P_0).CreateSQLQuery((string)P_1);
	}

	internal static object HGVaGIQuE49GHg8MQJ6(object P_0, bool P_1)
	{
		return ((IQuery)P_0).CleanUpCache(P_1);
	}

	internal static object MqMPyWQmKdB9BHSFNmb(object P_0, object P_1, object P_2)
	{
		return ((IQuery)P_0).SetParameterList((string)P_1, (IEnumerable)P_2);
	}

	internal static object reqot9QeDIFqJXuoVbL(object P_0, object P_1)
	{
		return ((EntityManager<IUserGroup, long>)P_0).CreateCriteria((IEntityFilter)P_1);
	}

	internal static Type f4Ak6GQLp5vbijBlDs8(object P_0)
	{
		return ((IEntityFilter)P_0).Subtype;
	}

	internal static bool dSe852QjlseaVdSiNOX(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static object WuUOOVQH1kN3IoqHBGY(object P_0)
	{
		return ((EntityManager<IUserGroup, long>)P_0).EntityTypeUidPropertyName;
	}

	internal static object DWHk9TQa6vhv2K2iEFi(object P_0)
	{
		return ((ILicensedUnit)P_0).GetLicenseInfo();
	}

	internal static bool aYb1KvQRlsVZcihEEbP(object P_0)
	{
		return ((IConcurrentLicenseInfo)P_0).IsConcurrent;
	}

	internal static int Ham1OKQwFxb6CgiWKni(object P_0)
	{
		return ((List<long>)P_0).Count;
	}

	internal static object XIXVdLQ2l8YuPP8cphx(object P_0, object P_1, object P_2)
	{
		return ((ITransformationProvider)P_0).TableFunction((string)P_1, (string)P_2);
	}

	internal static object HPSKGoQPA4BNWrrmlJM(object P_0, DbType P_1)
	{
		return ((Dialect)P_0).GetTypeName(P_1);
	}

	internal static object zkQQGyQv1B7Xu7PSUnS(object P_0, object P_1, object P_2, object P_3)
	{
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	internal static object YlL5oSQCJ2wGCAI1Gkr(object P_0, object P_1, object P_2)
	{
		return Expression.Sql((string)P_0, (object[])P_1, (IType[])P_2);
	}

	internal static object O8ialrQUR2SNfdOEYuv(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static int mCKWifQo9fNDuJn0d9c(object P_0)
	{
		return GetLicensedGroupUsers((IEnumerable)P_0);
	}

	internal static void K7KulYQJikuil2RoIn7(object P_0)
	{
		((ICollection<IOrganizationItem>)P_0).Clear();
	}

	internal static void Sipl8TQK8imfmyDADFR(object P_0)
	{
		((ICollection<IUserGroup>)P_0).Clear();
	}

	internal static void KhE8PxQtafWF1pSajVt(object P_0, Type P_1)
	{
		((ExportRule)P_0).ParentType = P_1;
	}

	internal static void fKvZscQhmlZHqXWhZi4(object P_0, ExportRuleType P_1)
	{
		((ExportRule)P_0).ExportRuleType = P_1;
	}

	internal static void LrLeESQOKO2wjjLOB43(object P_0, object P_1)
	{
		((ExportRule)P_0).PropertyName = (string)P_1;
	}

	internal static object bbAUGAQq9IC69jUc01f()
	{
		return Instance;
	}

	internal static void E4m9WUQcksfRyJ8NOG6()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}
}
