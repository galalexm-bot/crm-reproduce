using System;
using System.Linq.Expressions;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Impl;
using NHibernate.SqlCommand;

namespace EleWise.ELMA.Runtime.NH;

public static class CriteriaExtension
{
	private static CriteriaExtension fyyRulWadXscdUvZebW8;

	public static ICriteria GetOrCreateAlias(this ICriteria criteria, string path, string associationPath, JoinType joinType, ref string alias)
	{
		//Discarded unreachable code: IL_0070, IL_00a2, IL_00b9, IL_00c8, IL_00d7, IL_00e7, IL_00f6, IL_01c4, IL_01f6, IL_020d, IL_021c, IL_022e, IL_023d
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		int num2 = num;
		ICriteria val = default(ICriteria);
		while (true)
		{
			switch (num2)
			{
			case 3:
				try
				{
					val = (ICriteria)ggsPOQWa5JD35HRkVcUE(criteria, associationPath);
					int num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
					{
						num5 = 0;
					}
					switch (num5)
					{
					case 0:
						break;
					}
				}
				catch (Exception)
				{
					int num6 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
					{
						num6 = 0;
					}
					switch (num6)
					{
					case 0:
						break;
					}
				}
				goto case 5;
			case 8:
				criteria.CreateAlias(associationPath, alias, joinType);
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
				{
					num2 = 11;
				}
				break;
			case 5:
			case 6:
				if (val != null)
				{
					num2 = 10;
					break;
				}
				goto case 8;
			case 4:
			case 10:
				alias = (string)N69Dj1WajtptZSgkdXKQ(val);
				num2 = 7;
				break;
			case 9:
				if (SalIuvWagl9qvhRO9qOD(path, associationPath))
				{
					num2 = 3;
					break;
				}
				goto case 5;
			case 2:
				if (val != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
					{
						num2 = 5;
					}
					break;
				}
				goto case 9;
			case 1:
				val = null;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				try
				{
					val = criteria.GetCriteriaByPath(path);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
				}
				catch (Exception)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				goto case 2;
			case 7:
			case 11:
				return criteria;
			}
		}
	}

	public static ICriteria GetOrCreateAlias(this ICriteria criteria, string path, JoinType joinType, ref string alias)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		return criteria.GetOrCreateAlias(path, path, joinType, ref alias);
	}

	public static IProjection GetProjection(this ICriteria criteria)
	{
		//Discarded unreachable code: IL_0052, IL_0061
		int num = 3;
		int num2 = num;
		CriteriaImpl val = default(CriteriaImpl);
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (val != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			case 1:
				return null;
			default:
				return (IProjection)RYXaOSWaY3842X2cgGxC(val);
			case 3:
				val = (CriteriaImpl)(object)((criteria is CriteriaImpl) ? criteria : null);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private static ICriteria AddProjection(this object criteria, object proj, Action<ProjectionList> action)
	{
		IProjection projection = ((ICriteria)criteria).GetProjection();
		if (projection == null)
		{
			((ICriteria)criteria).SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)proj });
		}
		else
		{
			ProjectionList val = (ProjectionList)(object)((projection is ProjectionList) ? projection : null);
			if (val == null)
			{
				val = Projections.ProjectionList();
				val.Add(projection);
			}
			action?.Invoke(val);
			((ICriteria)criteria).SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)val });
		}
		return (ICriteria)criteria;
	}

	public static ICriteria AddProjection(this ICriteria criteria, IProjection projection)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass4_0 _003C_003Ec__DisplayClass4_ = default(_003C_003Ec__DisplayClass4_0);
		while (true)
		{
			switch (num2)
			{
			default:
				_003C_003Ec__DisplayClass4_.projection = projection;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return criteria.AddProjection(_003C_003Ec__DisplayClass4_.projection, _003C_003Ec__DisplayClass4_._003CAddProjection_003Eb__0);
			case 1:
				_003C_003Ec__DisplayClass4_ = new _003C_003Ec__DisplayClass4_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static ICriteria AddProjection(this ICriteria criteria, IProjection projection, string alias)
	{
		int num = 3;
		int num2 = num;
		_003C_003Ec__DisplayClass5_0 _003C_003Ec__DisplayClass5_ = default(_003C_003Ec__DisplayClass5_0);
		while (true)
		{
			switch (num2)
			{
			default:
				_003C_003Ec__DisplayClass5_.alias = alias;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				_003C_003Ec__DisplayClass5_ = new _003C_003Ec__DisplayClass5_0();
				num2 = 2;
				break;
			case 1:
				return criteria.AddProjection(_003C_003Ec__DisplayClass5_.projection, _003C_003Ec__DisplayClass5_._003CAddProjection_003Eb__0);
			case 2:
				_003C_003Ec__DisplayClass5_.projection = projection;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static ICriteria AddProjection<T>(this ICriteria criteria, IProjection projection, Expression<Func<T>> alias)
	{
		_003C_003Ec__DisplayClass6_0<T> CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass6_0<T>();
		CS_0024_003C_003E8__locals0.projection = projection;
		CS_0024_003C_003E8__locals0.alias = alias;
		return criteria.AddProjection(CS_0024_003C_003E8__locals0.projection, delegate(ProjectionList projectionList)
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
					projectionList.Add<T>(CS_0024_003C_003E8__locals0.projection, CS_0024_003C_003E8__locals0.alias);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		});
	}

	public static ICriteria If(this ICriteria criteria, bool condition, Func<ICriteria, ICriteria> action)
	{
		if (!condition)
		{
			return criteria;
		}
		return action(criteria);
	}

	internal static bool SalIuvWagl9qvhRO9qOD(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static object ggsPOQWa5JD35HRkVcUE(object P_0, object P_1)
	{
		return ((ICriteria)P_0).GetCriteriaByPath((string)P_1);
	}

	internal static object N69Dj1WajtptZSgkdXKQ(object P_0)
	{
		return ((ICriteria)P_0).get_Alias();
	}

	internal static bool f7ihnpWal3Pl9hRbeCca()
	{
		return fyyRulWadXscdUvZebW8 == null;
	}

	internal static CriteriaExtension XNCvguWarnj2Kr1IKcAa()
	{
		return fyyRulWadXscdUvZebW8;
	}

	internal static object RYXaOSWaY3842X2cgGxC(object P_0)
	{
		return ((CriteriaImpl)P_0).get_Projection();
	}
}
