using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Cache;
using EleWise.ELMA.Cache.Attributes;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security.DTO.Models;
using EleWise.ELMA.Security.Extensions;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using Iesi.Collections.Generic;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Criterion.Lambda;
using NHibernate.Transform;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class OrganizationItemManager : EntityManager<IOrganizationItem, long>
{
	[Component]
	internal class SecurityCacheSetIdAction : ISecurityCacheSetIdAction
	{
		private static SecurityCacheSetIdAction I2suijpw66JynoiZfJjr;

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
				case 1:
					ghNVEopwxFc5i0WWXTrl(Locator.GetServiceNotNull<IUnionComplexCacheService>(), lNhEhxpwZPUioaol9jmC(0x1618182 ^ 0x1613E24));
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_963eedaf34ef4c6cb3f0798bae513387 != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		public SecurityCacheSetIdAction()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8dab57df677749fba2d5364cf752799f != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static object lNhEhxpwZPUioaol9jmC(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static void ghNVEopwxFc5i0WWXTrl(object P_0, object P_1)
		{
			((IUnionComplexCacheService)P_0).RefreshTimestamp((string)P_1);
		}

		internal static bool BRFLPxpwlBE8F40hoBWt()
		{
			return I2suijpw66JynoiZfJjr == null;
		}

		internal static SecurityCacheSetIdAction blWUR5pwNQ7RapMq5X19()
		{
			return I2suijpw66JynoiZfJjr;
		}
	}

	private IUnionComplexCacheService unionComplexCacheService;

	internal static OrganizationItemManager z1R6q4IQxYuPGxGMOd8;

	public IUnionComplexCacheService UnionComplexCacheService
	{
		get
		{
			int num = 1;
			int num2 = num;
			IUnionComplexCacheService unionComplexCacheService = default(IUnionComplexCacheService);
			IUnionComplexCacheService obj;
			while (true)
			{
				switch (num2)
				{
				default:
					unionComplexCacheService = (this.unionComplexCacheService = Locator.GetService<IUnionComplexCacheService>());
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_dee60bd1c491407eb16511279f664d42 == 0)
					{
						num2 = 2;
					}
					continue;
				case 1:
					obj = this.unionComplexCacheService;
					if (obj != null)
					{
						break;
					}
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_651070b1c9bd4381bbb7379d68d6508e == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					obj = unionComplexCacheService;
					break;
				}
				break;
			}
			return obj;
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
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_443cb30a1c3f4e72a61ec4f52377fcc7 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public new static OrganizationItemManager Instance => Locator.GetServiceNotNull<OrganizationItemManager>();

	public IOrganizationItem LoadFullTree()
	{
		IQueryOver<IOrganizationItem, IOrganizationItem> obj = ((ISession)LvWN5UIgRcvpA3SqFkS(this)).QueryOver<IOrganizationItem>();
		ParameterExpression parameterExpression = (ParameterExpression)HQg7tCI3iAuIvxH0FKV(VKxw68I8fiZ60xHOo0q(typeof(IOrganizationItem).TypeHandle), Gj7GtuIrqkBXxF3BIKk(-1957236745 ^ -1957277227));
		IQueryOver<IOrganizationItem, IOrganizationItem> eager = ((QueryOverFetchBuilderBase<IQueryOver<IOrganizationItem, IOrganizationItem>, IOrganizationItem, IOrganizationItem>)(object)obj.Fetch(Expression.Lambda<Func<IOrganizationItem, object>>(Expression.Property(parameterExpression, (MethodInfo)Gr7fYAIyn8CfHNFBhbg((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }))).get_Eager();
		parameterExpression = (ParameterExpression)HQg7tCI3iAuIvxH0FKV(VKxw68I8fiZ60xHOo0q(typeof(IOrganizationItem).TypeHandle), Gj7GtuIrqkBXxF3BIKk(0x397B0322 ^ 0x397BBD00));
		return ((IQueryOver<IOrganizationItem>)(object)((QueryOverFetchBuilderBase<IQueryOver<IOrganizationItem, IOrganizationItem>, IOrganizationItem, IOrganizationItem>)(object)eager.Fetch(Expression.Lambda<Func<IOrganizationItem, object>>((Expression)wQXHPpIbSlr3M3cqxnE(parameterExpression, (MethodInfo)Gr7fYAIyn8CfHNFBhbg((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }))).get_Eager()).List().FirstOrDefault(delegate(IOrganizationItem i)
		{
			//Discarded unreachable code: IL_002d, IL_003c
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return !_003C_003Ec.ngny6Upwjge7iU2n3xO1(i);
				case 1:
					return false;
				case 2:
					if (_003C_003Ec.sVbVuNpwLBadlerM0Bmr(i) != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b6bf1b70a8924e789fc4be8e9aadc953 == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto default;
				}
			}
		});
	}

	public IEnumerable<IOrganizationItem> LoadFullList()
	{
		return base.Session.CreateCriteria<IOrganizationItem>().Add((ICriterion)(object)Restrictions.Eq(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xFD0849E ^ 0xFD0179C), (object)false)).List<IOrganizationItem>()
			.ToList();
	}

	[Obsolete("Для загрузки списка оргструктуры используйте LoadFullList()")]
	public IEnumerable<IOrganizationItem> LoadFullRootList()
	{
		return LoadFullList();
	}

	public IEnumerable<OrganizationItemDTO> LoadRootList()
	{
		return base.Session.GetNamedQuery(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x65F93013 ^ 0x65F98E39)).SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(OrganizationItemDTO))).CleanUpCache(cleanUpCache: false)
			.List<OrganizationItemDTO>();
	}

	[Obsolete("Для загрузки корневого элемента использовать LoadOrgStructRoot(). Для плоского списка всей оргструктуры LoadFullRootList()")]
	public virtual IOrganizationItem LoadFullRoot()
	{
		//Discarded unreachable code: IL_0078, IL_0087
		int num = 3;
		int num2 = num;
		IEnumerable<IOrganizationItem> source = default(IEnumerable<IOrganizationItem>);
		while (true)
		{
			switch (num2)
			{
			case 1:
				throw new InvalidOperationException((string)EmFF1oISgvyJl0SMbJd(Gj7GtuIrqkBXxF3BIKk(0x738E3073 ^ 0x738E8E3B)));
			default:
				if (source.Count() == 0)
				{
					num2 = 4;
					break;
				}
				return source.First((IOrganizationItem i) => _003C_003Ec.sVbVuNpwLBadlerM0Bmr(i) == null);
			case 3:
				source = LoadFullList();
				num2 = 2;
				break;
			case 2:
				if (source.Count((IOrganizationItem i) => _003C_003Ec.sVbVuNpwLBadlerM0Bmr(i) == null) <= 1)
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_73b92e1f752f422d899693d4318e4486 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			case 4:
				return null;
			}
		}
	}

	public virtual OrganizationItemDTO LoadRoot()
	{
		//Discarded unreachable code: IL_002e, IL_003d, IL_0048, IL_00ea, IL_00f9, IL_013a, IL_0182, IL_01c2, IL_01d1, IL_01dd, IL_01ec
		int num = 2;
		int num2 = num;
		IEnumerator<OrganizationItemDTO> enumerator = default(IEnumerator<OrganizationItemDTO>);
		OrganizationItemDTO current = default(OrganizationItemDTO);
		Dictionary<long, OrganizationItemDTO> dictionary = default(Dictionary<long, OrganizationItemDTO>);
		OrganizationItemDTO value = default(OrganizationItemDTO);
		OrganizationItemDTO result = default(OrganizationItemDTO);
		while (true)
		{
			switch (num2)
			{
			case 1:
				try
				{
					while (true)
					{
						int num3;
						if (!a4ZKiE4kEi3nNbD5GKr(enumerator))
						{
							num3 = 7;
							goto IL_004c;
						}
						goto IL_0122;
						IL_004c:
						while (true)
						{
							switch (num3)
							{
							case 4:
								if (nCjjUuIzZ47HIxngx9V(current) != 0L)
								{
									num3 = 3;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b54421a4e10b4c2fa10cef566e462fbd == 0)
									{
										num3 = 3;
									}
									continue;
								}
								goto case 5;
							case 3:
							case 6:
								if (dictionary.TryGetValue(nCjjUuIzZ47HIxngx9V(current), out value))
								{
									num3 = 1;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2df53c26a6094060a56f82d6cf94e7da != 0)
									{
										num3 = 0;
									}
									continue;
								}
								break;
							case 5:
								result = current;
								num3 = 0;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a16ce287ba7944e2afcf4e52864ec01d != 0)
								{
									num3 = 0;
								}
								continue;
							case 8:
								goto IL_0122;
							case 1:
								value.Items.Add(current);
								num3 = 2;
								continue;
							case 7:
								return result;
							}
							break;
						}
						continue;
						IL_0122:
						current = enumerator.Current;
						num3 = 4;
						goto IL_004c;
					}
				}
				finally
				{
					int num4;
					if (enumerator == null)
					{
						num4 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5c3c41b36b4846e0b1701d4e56408883 == 0)
						{
							num4 = 0;
						}
						goto IL_0186;
					}
					goto IL_019c;
					IL_019c:
					enumerator.Dispose();
					num4 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_da1dffb5695d4a95af335a696463801b == 0)
					{
						num4 = 2;
					}
					goto IL_0186;
					IL_0186:
					switch (num4)
					{
					default:
						goto end_IL_0161;
					case 1:
						break;
					case 0:
						goto end_IL_0161;
					case 2:
						goto end_IL_0161;
					}
					goto IL_019c;
					end_IL_0161:;
				}
			default:
				return result;
			case 2:
			{
				IList<OrganizationItemDTO> list = ((IQuery)LaiQZKI1rSgppAko0iD(JoY21YIfSsfIKfeas2S(UEy3x5I9kv0t0lOF2AK(LvWN5UIgRcvpA3SqFkS(this), Gj7GtuIrqkBXxF3BIKk(0x11C59687 ^ 0x11C528AD)), new AliasToBeanResultTransformer(VKxw68I8fiZ60xHOo0q(typeof(OrganizationItemDTO).TypeHandle))), false)).List<OrganizationItemDTO>();
				if (list.Count((OrganizationItemDTO i) => i.ParentItemId == 0) > 1)
				{
					throw new InvalidOperationException(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1580392499 ^ -1580359301)));
				}
				result = new OrganizationItemDTO();
				dictionary = list.ToDictionary((OrganizationItemDTO k) => k.Id, (OrganizationItemDTO v) => v);
				enumerator = list.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_66aae9daa3f84bb5931ed90b4759f85c != 0)
				{
					num2 = 1;
				}
				break;
			}
			}
		}
	}

	public virtual IOrganizationItem LoadOrgStructRoot()
	{
		ParameterExpression parameterExpression = (ParameterExpression)HQg7tCI3iAuIvxH0FKV(VKxw68I8fiZ60xHOo0q(typeof(IOrganizationItem).TypeHandle), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x31C71464 ^ 0x31C73FDC));
		return ((AbstractNHEntityManager<IOrganizationItem, long>)this).Find(Expression.Lambda<Func<IOrganizationItem, bool>>((Expression)tavpUa4AkXCLVRNmGQN(xs7B6e45s8m0MPyvqDp(wQXHPpIbSlr3M3cqxnE(parameterExpression, (MethodInfo)Gr7fYAIyn8CfHNFBhbg((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), UNZprQ4pKkLB091mA7Z(null, VKxw68I8fiZ60xHOo0q(typeof(object).TypeHandle))), xs7B6e45s8m0MPyvqDp(wQXHPpIbSlr3M3cqxnE(parameterExpression, (MethodInfo)Gr7fYAIyn8CfHNFBhbg((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), UNZprQ4pKkLB091mA7Z(false, VKxw68I8fiZ60xHOo0q(typeof(bool).TypeHandle)))), new ParameterExpression[1] { parameterExpression })).FirstOrDefault();
	}

	public virtual ICollection<IOrganizationItem> GetChildDepartments(IOrganizationItem parent)
	{
		_003C_003Ec__DisplayClass15_0 _003C_003Ec__DisplayClass15_ = new _003C_003Ec__DisplayClass15_0();
		_003C_003Ec__DisplayClass15_.parent = parent;
		ParameterExpression parameterExpression = Expression.Parameter(typeof(IOrganizationItem), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858473711 ^ -1858479447));
		return ((AbstractNHEntityManager<IOrganizationItem, long>)this).Find(Expression.Lambda<Func<IOrganizationItem, bool>>(Expression.AndAlso(Expression.Equal(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Field(Expression.Constant(_003C_003Ec__DisplayClass15_, typeof(_003C_003Ec__DisplayClass15_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))), Expression.Equal(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Constant(false, typeof(bool)))), new ParameterExpression[1] { parameterExpression }));
	}

	[Cache]
	public virtual long[] GetTree(IOrganizationItem item)
	{
		//Discarded unreachable code: IL_0052, IL_0061, IL_0106, IL_013e, IL_014d, IL_018d, IL_019c
		int num = 4;
		int num2 = num;
		IEnumerator<IOrganizationItem> enumerator = default(IEnumerator<IOrganizationItem>);
		List<long> list = default(List<long>);
		IOrganizationItem current = default(IOrganizationItem);
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (item == null)
				{
					num2 = 5;
					break;
				}
				goto case 6;
			case 1:
				try
				{
					while (true)
					{
						IL_00ca:
						int num3;
						if (!a4ZKiE4kEi3nNbD5GKr(enumerator))
						{
							num3 = 2;
							goto IL_0070;
						}
						goto IL_00b3;
						IL_0070:
						while (true)
						{
							switch (num3)
							{
							case 3:
								list.AddRange((IEnumerable<long>)Qst3LL4XTHpwGJfrY49(this, current));
								num3 = 0;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_dffee0180fb244db9738339fa28792b4 == 0)
								{
									num3 = 0;
								}
								continue;
							case 1:
								break;
							default:
								goto IL_00ca;
							case 2:
								goto end_IL_00ca;
							}
							break;
						}
						goto IL_00b3;
						IL_00b3:
						current = enumerator.Current;
						int num4 = 3;
						num3 = num4;
						goto IL_0070;
						continue;
						end_IL_00ca:
						break;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num5 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6370a8f224e7416eb3575ae34b77f5e3 != 0)
						{
							num5 = 0;
						}
						while (true)
						{
							switch (num5)
							{
							default:
								QU6Vid4nsHdn2F8vsyt(enumerator);
								num5 = 1;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a53a06d0e4134332947f6164df41fb0f != 0)
								{
									num5 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
				goto case 2;
			case 2:
			case 5:
				return (long[])qcyQcT4iZ324N6DOB3v(list);
			default:
				list.Add(item.Id);
				num2 = 7;
				break;
			case 4:
				list = new List<long>();
				num2 = 3;
				break;
			case 6:
				if (!kuA0Sm4WpNroJ5LNv2G(item))
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a3a30dc594d64d20b0419bc3debf22fd != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 7:
				enumerator = ((IEnumerable<IOrganizationItem>)item.SubItems).GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fe0eedb8ce484402a5c9a74346556b9f == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public virtual IEnumerable<long> GetOrgItemIdsByUser(long userId)
	{
		_003C_003Ec__DisplayClass17_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass17_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.userId = userId;
		return UnionComplexCacheService.GetOrAdd(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1889123947 ^ -1889075489) + CS_0024_003C_003E8__locals0.userId, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4E6718AE ^ 0x4E67A708), (Func<IEnumerable<long>>)delegate
		{
			string sql = string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1B3723C5 ^ 0x1B360DC5), CS_0024_003C_003E8__locals0._003C_003E4__this.TransformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5FD42272 ^ 0x5FD46774)), CS_0024_003C_003E8__locals0._003C_003E4__this.TransformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1973849202 ^ -1973865514)), CS_0024_003C_003E8__locals0._003C_003E4__this.TransformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x65F93013 ^ 0x65F93309)), CS_0024_003C_003E8__locals0.userId);
			List<long> list = new List<long>();
			using IDataReader dataReader = CS_0024_003C_003E8__locals0._003C_003E4__this.TransformationProvider.ExecuteQuery(sql);
			while (dataReader.Read())
			{
				list.Add(dataReader.GetInt64(0));
			}
			return list;
		});
	}

	public virtual IEnumerable<long> GetItemsByUser(long userId)
	{
		SqlSubQuery itemsByUserQuery = GetItemsByUserQuery(userId);
		ISQLQuery val = base.Session.CreateSQLQuery(itemsByUserQuery.Sql);
		for (int i = 0; i < itemsByUserQuery.ParametersValues.Length; i++)
		{
			((IQuery)val).SetParameter(i, itemsByUserQuery.ParametersValues[i]);
		}
		return ((IQuery)(object)val).CleanUpCache(cleanUpCache: false).List<object>().Select(Convert.ToInt64)
			.ToArray();
	}

	public virtual SqlSubQuery GetItemsByUserQuery(long userId)
	{
		return (SqlSubQuery)AIrhHl4BMactdh5pGyZ(tTOSbQ4xh4N8cAXZ4I5(LvWN5UIgRcvpA3SqFkS(this), aRucx24Z9HZM5jIdiQs(Dm36Wj4loTSeHGomCTT(Gj7GtuIrqkBXxF3BIKk(-2030777218 ^ -2030826394), qwCUUB47BbHfZJPI71Y(TransformationProvider.Dialect, Gj7GtuIrqkBXxF3BIKk(0x37FE8EDE ^ 0x37FE4E4E)), qwCUUB47BbHfZJPI71Y(sJcFf446qJfOCWaESjM(TransformationProvider), Gj7GtuIrqkBXxF3BIKk(-434542700 ^ -434526420)), qwCUUB47BbHfZJPI71Y(TransformationProvider.Dialect, Gj7GtuIrqkBXxF3BIKk(0x116C2699 ^ 0x116C2583))), Gj7GtuIrqkBXxF3BIKk(-1712587919 ^ -1712637033), wV9KLL4N8X2VFmYTTdW(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2121ECF9 ^ 0x21212C01), new object[4]
		{
			((Dialect)sJcFf446qJfOCWaESjM(TransformationProvider)).QuoteIfNeeded((string)Gj7GtuIrqkBXxF3BIKk(0xBBC1CCD ^ 0xBBC0CDD)),
			qwCUUB47BbHfZJPI71Y(sJcFf446qJfOCWaESjM(TransformationProvider), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-163225536 ^ -163208898)),
			qwCUUB47BbHfZJPI71Y(sJcFf446qJfOCWaESjM(TransformationProvider), Gj7GtuIrqkBXxF3BIKk(0x45F3B9A1 ^ 0x45F3BABB)),
			qwCUUB47BbHfZJPI71Y(sJcFf446qJfOCWaESjM(TransformationProvider), Gj7GtuIrqkBXxF3BIKk(0x6A336151 ^ 0x6A33A1C1))
		}))), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-784481839 ^ -784489987), userId);
	}

	[PublicApiMember]
	public virtual IEnumerable<IOrganizationItem> GetSubItems(IOrganizationItem orgItem)
	{
		List<IOrganizationItem> list = new List<IOrganizationItem>();
		if (orgItem == null)
		{
			throw new NullReferenceException(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1869C442 ^ 0x186905E0)));
		}
		if (!((IEnumerable<IOrganizationItem>)orgItem.SubItems).Any())
		{
			return list;
		}
		foreach (IOrganizationItem item in (IEnumerable<IOrganizationItem>)orgItem.SubItems)
		{
			if (!((IEnumerable<IOrganizationItem>)item.SubItems).Any())
			{
				list.Add(item);
				continue;
			}
			list.Add(item);
			IEnumerable<IOrganizationItem> subItems = GetSubItems(item);
			list.AddRange(subItems);
		}
		return list;
	}

	[PublicApiMember]
	public virtual IEnumerable<IOrganizationItem> GetSubItemsByLvl(IOrganizationItem orgItem, int lvl)
	{
		List<IOrganizationItem> list = new List<IOrganizationItem>();
		if (lvl <= 0)
		{
			return list;
		}
		if (orgItem == null)
		{
			throw new NullReferenceException(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1889123947 ^ -1889107913)));
		}
		if (!((IEnumerable<IOrganizationItem>)orgItem.SubItems).Any())
		{
			return list;
		}
		foreach (IOrganizationItem item in (IEnumerable<IOrganizationItem>)orgItem.SubItems)
		{
			list.Add(item);
			IEnumerable<IOrganizationItem> subItemsByLvl = GetSubItemsByLvl(item, lvl - 1);
			list.AddRange(subItemsByLvl);
		}
		return list;
	}

	[PublicApiMember]
	public virtual IOrganizationItem GetItemDepartment(IOrganizationItem orgItem)
	{
		//Discarded unreachable code: IL_0053, IL_0062, IL_00a8
		int num = 2;
		int num2 = num;
		IOrganizationItem organizationItem = default(IOrganizationItem);
		while (true)
		{
			switch (num2)
			{
			case 4:
			case 5:
				if (ryAFhX4mnAOdoaYatut(organizationItem) == OrganizationItemType.Department)
				{
					num2 = 3;
					break;
				}
				organizationItem = organizationItem.ParentItem;
				num2 = 6;
				break;
			case 2:
				organizationItem = (IOrganizationItem)BPaGsD4umVDRtwCPVTF(orgItem);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a16ce287ba7944e2afcf4e52864ec01d != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
			case 6:
				if (organizationItem != null)
				{
					num2 = 4;
					break;
				}
				goto default;
			default:
				return organizationItem;
			case 3:
				return organizationItem;
			}
		}
	}

	[PublicApiMember]
	public virtual ICollection<IOrganizationItem> GetItemDeptHead(IOrganizationItem orgItem)
	{
		List<IOrganizationItem> list = new List<IOrganizationItem>();
		IOrganizationItem itemDepartment = GetItemDepartment(orgItem);
		if (itemDepartment != null)
		{
			list.AddRange(((IEnumerable<IOrganizationItem>)itemDepartment.SubItems).Where((IOrganizationItem i) => i.ItemType == OrganizationItemType.Position));
		}
		return list;
	}

	[PublicApiMember]
	public virtual ICollection<IOrganizationItem> GetUserDeptHead(EleWise.ELMA.Security.Models.IUser user)
	{
		List<IOrganizationItem> list = new List<IOrganizationItem>();
		ISet<IOrganizationItem> organizationGroups = user.OrganizationGroups;
		((ICollection<IOrganizationItem>)organizationGroups).AddRange((IEnumerable<IOrganizationItem>)user.OrganizationItems);
		foreach (IOrganizationItem item in (IEnumerable<IOrganizationItem>)organizationGroups)
		{
			list.AddRange(GetItemDeptHead(item));
		}
		return list;
	}

	public OrganizationItemManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		GYOQvx4enVco1U5JeQC();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5ae6a44bd52345c5bcadd62b7063c7d9 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool uPr34gId4u2ndEbY2nH()
	{
		return z1R6q4IQxYuPGxGMOd8 == null;
	}

	internal static OrganizationItemManager EQipkVITUQMvQ5W6bQw()
	{
		return z1R6q4IQxYuPGxGMOd8;
	}

	internal static object LvWN5UIgRcvpA3SqFkS(object P_0)
	{
		return ((NHManagerBase)P_0).Session;
	}

	internal static Type VKxw68I8fiZ60xHOo0q(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object Gj7GtuIrqkBXxF3BIKk(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object HQg7tCI3iAuIvxH0FKV(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object Gr7fYAIyn8CfHNFBhbg(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object wQXHPpIbSlr3M3cqxnE(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static object EmFF1oISgvyJl0SMbJd(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object UEy3x5I9kv0t0lOF2AK(object P_0, object P_1)
	{
		return ((ISession)P_0).GetNamedQuery((string)P_1);
	}

	internal static object JoY21YIfSsfIKfeas2S(object P_0, object P_1)
	{
		return ((IQuery)P_0).SetResultTransformer((IResultTransformer)P_1);
	}

	internal static object LaiQZKI1rSgppAko0iD(object P_0, bool P_1)
	{
		return ((IQuery)P_0).CleanUpCache(P_1);
	}

	internal static long nCjjUuIzZ47HIxngx9V(object P_0)
	{
		return ((OrganizationItemDTO)P_0).ParentItemId;
	}

	internal static bool a4ZKiE4kEi3nNbD5GKr(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static object UNZprQ4pKkLB091mA7Z(object P_0, Type P_1)
	{
		return Expression.Constant(P_0, P_1);
	}

	internal static object xs7B6e45s8m0MPyvqDp(object P_0, object P_1)
	{
		return Expression.Equal((Expression)P_0, (Expression)P_1);
	}

	internal static object tavpUa4AkXCLVRNmGQN(object P_0, object P_1)
	{
		return Expression.AndAlso((Expression)P_0, (Expression)P_1);
	}

	internal static bool kuA0Sm4WpNroJ5LNv2G(object P_0)
	{
		return ((IEntity)P_0).IsNew();
	}

	internal static object Qst3LL4XTHpwGJfrY49(object P_0, object P_1)
	{
		return ((OrganizationItemManager)P_0).GetTree((IOrganizationItem)P_1);
	}

	internal static void QU6Vid4nsHdn2F8vsyt(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object qcyQcT4iZ324N6DOB3v(object P_0)
	{
		return ((List<long>)P_0).ToArray();
	}

	internal static object qwCUUB47BbHfZJPI71Y(object P_0, object P_1)
	{
		return ((Dialect)P_0).QuoteIfNeeded((string)P_1);
	}

	internal static object sJcFf446qJfOCWaESjM(object P_0)
	{
		return ((ITransformationProvider)P_0).Dialect;
	}

	internal static object Dm36Wj4loTSeHGomCTT(object P_0, object P_1, object P_2, object P_3)
	{
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	internal static object wV9KLL4N8X2VFmYTTdW(object P_0, object P_1)
	{
		return string.Format((string)P_0, (object[])P_1);
	}

	internal static object aRucx24Z9HZM5jIdiQs(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static object tTOSbQ4xh4N8cAXZ4I5(object P_0, object P_1)
	{
		return ((ISession)P_0).CreateSQLSubQuery((string)P_1);
	}

	internal static object AIrhHl4BMactdh5pGyZ(object P_0, object P_1, object P_2)
	{
		return ((SqlSubQuery)P_0).SetParameter((string)P_1, P_2);
	}

	internal static object BPaGsD4umVDRtwCPVTF(object P_0)
	{
		return ((IOrganizationItem)P_0).ParentItem;
	}

	internal static OrganizationItemType ryAFhX4mnAOdoaYatut(object P_0)
	{
		return ((IOrganizationItem)P_0).ItemType;
	}

	internal static void GYOQvx4enVco1U5JeQC()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}
}
