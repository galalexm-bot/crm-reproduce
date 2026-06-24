using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.DTO.Models;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Transform;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class ProcessGroupManager : EntityManager<IProcessGroup, long>
{
	private static ProcessGroupManager TdeaHqnIHDx3djh6YSb;

	public ProcessHeaderManager ProcessHeaderManager
	{
		[CompilerGenerated]
		get
		{
			return _003CProcessHeaderManager_003Ek__BackingField;
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
					_003CProcessHeaderManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6dd19c81ff5e41fb8db9b50574437301 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public new static ProcessGroupManager Instance => Locator.GetServiceNotNull<ProcessGroupManager>();

	public IEnumerable<IProcessGroup> LoadRootGroups()
	{
		return CreateCriteria().Add((ICriterion)(object)Restrictions.IsNull(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-862330810 ^ -862345482))).List<IProcessGroup>();
	}

	public IEnumerable<ProcessGroupDTO> LoadGroupsTree()
	{
		return base.Session.GetNamedQuery(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-197778752 ^ -197742772)).SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(ProcessGroupDTO))).CleanUpCache(cleanUpCache: false)
			.List<ProcessGroupDTO>();
	}

	[Transaction]
	public virtual void Delete(long groupId)
	{
		int num = 1;
		int num2 = num;
		IProcessGroup processGroup = default(IProcessGroup);
		while (true)
		{
			switch (num2)
			{
			case 1:
				processGroup = LoadOrNull(groupId);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return;
			case 3:
				return;
			}
			if (processGroup != null)
			{
				Delete(processGroup);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 != 0)
				{
					num2 = 2;
				}
			}
			else
			{
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2f119e188994b55be2499c193b880fb == 0)
				{
					num2 = 0;
				}
			}
		}
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
				type = InterfaceActivator.TypeOf<IProcessGroup>();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a != 0)
				{
					num2 = 0;
				}
				continue;
			}
			ExportRuleList exportRuleList = new ExportRuleList();
			ExportRule exportRule = new ExportRule();
			E83QpmneweGUi0ZHI3N(exportRule, type);
			exportRule.PropertyName = (string)oBqdqenNYeAYrA5Qcf3(0x74AB4717 ^ 0x74AB0199);
			exportRule.ExportRuleType = ExportRuleType.Export;
			exportRuleList.Add(exportRule);
			ExportRule obj = new ExportRule
			{
				ParentType = type
			};
			Fq0QSAnxIxOrjF8bQdk(obj, oBqdqenNYeAYrA5Qcf3(-947937941 ^ -947921957));
			obj.ExportRuleType = ExportRuleType.Export;
			exportRuleList.Add(obj);
			exportRuleList.Add(new ExportRule
			{
				ParentType = type,
				PropertyName = (string)oBqdqenNYeAYrA5Qcf3(-43932417 ^ -43964089),
				ExportRuleType = ExportRuleType.Export
			});
			ExportRule exportRule2 = new ExportRule();
			E83QpmneweGUi0ZHI3N(exportRule2, type);
			Fq0QSAnxIxOrjF8bQdk(exportRule2, oBqdqenNYeAYrA5Qcf3(0x56F860D7 ^ 0x56F8ED19));
			yobKWbnSuCQ5bxoE9IS(exportRule2, ExportRuleType.Export);
			exportRuleList.Add(exportRule2);
			ExportRule obj2 = new ExportRule
			{
				ParentType = type
			};
			Fq0QSAnxIxOrjF8bQdk(obj2, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x37E97159 ^ 0x37E93725));
			yobKWbnSuCQ5bxoE9IS(obj2, ExportRuleType.Export);
			exportRuleList.Add(obj2);
			return exportRuleList;
		}
	}

	[PublicApiMember]
	public override void Delete(IProcessGroup group)
	{
		//Discarded unreachable code: IL_01c5, IL_01d4, IL_01df, IL_027d, IL_02b5, IL_02c5, IL_02cf, IL_036d, IL_03a5, IL_03b4
		int num = 8;
		IEnumerator<IProcessGroup> enumerator2 = default(IEnumerator<IProcessGroup>);
		_003C_003Ec__DisplayClass10_0 _003C_003Ec__DisplayClass10_ = default(_003C_003Ec__DisplayClass10_0);
		IEnumerator<IProcessHeader> enumerator = default(IEnumerator<IProcessHeader>);
		while (true)
		{
			int num2 = num;
			ParameterExpression parameterExpression;
			while (true)
			{
				switch (num2)
				{
				case 1:
					parameterExpression = (ParameterExpression)U7WmO0nhaNhBnO9QM7e(DoeEsUn1U9u5DhSagGf(typeof(IProcessGroup).TypeHandle), oBqdqenNYeAYrA5Qcf3(--1756698829 ^ 0x68B5953F));
					enumerator2 = ((AbstractNHEntityManager<IProcessGroup, long>)this).Find(Expression.Lambda<Func<IProcessGroup, bool>>((Expression)i3Tq1mHOvyyNrTbHBvd(allafHnw2fvEwyTDPXT(parameterExpression, (MethodInfo)t1iYVUnEGfXF1orGRRA((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), GcAAuAHKdGKHQheI19G(jfWlbyn4UQDKinkqBeZ(_003C_003Ec__DisplayClass10_, DoeEsUn1U9u5DhSagGf(typeof(_003C_003Ec__DisplayClass10_0).TypeHandle)), LNU70DnzIY50KIvqyZ6((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))), new ParameterExpression[1] { parameterExpression })).GetEnumerator();
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5537a063960e465db83a04e35eea441b == 0)
					{
						num2 = 1;
					}
					continue;
				case 5:
					return;
				case 8:
					_003C_003Ec__DisplayClass10_ = new _003C_003Ec__DisplayClass10_0();
					num2 = 7;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_43af423d081c48e3bc6cea30ce47523d == 0)
					{
						num2 = 7;
					}
					continue;
				case 4:
					Contract.ArgumentNotNull(_003C_003Ec__DisplayClass10_.group, (string)oBqdqenNYeAYrA5Qcf3(-1303601216 ^ -1303637468));
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d87d9a74c9e14f96a288cc3620965fe0 == 0)
					{
						num2 = 1;
					}
					continue;
				case 2:
					break;
				case 3:
					try
					{
						while (true)
						{
							int num5;
							if (!enumerator2.MoveNext())
							{
								num5 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c == 0)
								{
									num5 = 1;
								}
								goto IL_01e3;
							}
							goto IL_01f9;
							IL_01f9:
							IProcessGroup current2 = enumerator2.Current;
							h02nkCHZr9tiBy6RerN(current2, _003C_003Ec__DisplayClass10_.group.Parent);
							cRvcEvHvXleWRi3FDWU(current2);
							num5 = 2;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e4c570270f54493d8f3f4763a72f63f7 == 0)
							{
								num5 = 2;
							}
							goto IL_01e3;
							IL_01e3:
							switch (num5)
							{
							case 2:
								continue;
							case 1:
								goto end_IL_0231;
							}
							goto IL_01f9;
							continue;
							end_IL_0231:
							break;
						}
					}
					finally
					{
						if (enumerator2 != null)
						{
							int num6 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d87d9a74c9e14f96a288cc3620965fe0 != 0)
							{
								num6 = 1;
							}
							while (true)
							{
								switch (num6)
								{
								case 1:
									a8LJ9RHYcqZHrGHD4yr(enumerator2);
									num6 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_43af423d081c48e3bc6cea30ce47523d == 0)
									{
										num6 = 0;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
						}
					}
					break;
				case 6:
					try
					{
						while (true)
						{
							int num3;
							if (!aowCBrHsvWGDfLp0Sm8(enumerator))
							{
								num3 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a == 0)
								{
									num3 = 1;
								}
								goto IL_02d3;
							}
							goto IL_030f;
							IL_030f:
							IProcessHeader current = enumerator.Current;
							lcBcJdH8jW2VKI9kJsK(current, _003C_003Ec__DisplayClass10_.group.Parent);
							cRvcEvHvXleWRi3FDWU(current);
							num3 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8a6cf36da0b84f319a7cf27018f28f5b == 0)
							{
								num3 = 0;
							}
							goto IL_02d3;
							IL_02d3:
							switch (num3)
							{
							case 2:
								goto IL_030f;
							case 1:
								goto end_IL_02e9;
							}
							continue;
							end_IL_02e9:
							break;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							int num4 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a9be7e056b4e4b6e863b634c418144f1 != 0)
							{
								num4 = 1;
							}
							while (true)
							{
								switch (num4)
								{
								case 1:
									a8LJ9RHYcqZHrGHD4yr(enumerator);
									num4 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 != 0)
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
					goto default;
				default:
					base.Delete(_003C_003Ec__DisplayClass10_.group);
					num2 = 5;
					continue;
				case 7:
					_003C_003Ec__DisplayClass10_.group = group;
					num2 = 4;
					continue;
				}
				break;
			}
			ProcessHeaderManager processHeaderManager = ProcessHeaderManager;
			parameterExpression = (ParameterExpression)U7WmO0nhaNhBnO9QM7e(DoeEsUn1U9u5DhSagGf(typeof(IProcessHeader).TypeHandle), oBqdqenNYeAYrA5Qcf3(-261315199 ^ -261347207));
			enumerator = processHeaderManager.Find(Expression.Lambda<Func<IProcessHeader, bool>>((Expression)i3Tq1mHOvyyNrTbHBvd(allafHnw2fvEwyTDPXT(parameterExpression, (MethodInfo)t1iYVUnEGfXF1orGRRA((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), GcAAuAHKdGKHQheI19G(jfWlbyn4UQDKinkqBeZ(_003C_003Ec__DisplayClass10_, DoeEsUn1U9u5DhSagGf(typeof(_003C_003Ec__DisplayClass10_0).TypeHandle)), LNU70DnzIY50KIvqyZ6((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))), new ParameterExpression[1] { parameterExpression })).GetEnumerator();
			num = 6;
		}
	}

	public ProcessGroupManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		O1Cs6YHJhbQWkGJnqiB();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool URw1MLnaZfEDZXkfMUx()
	{
		return TdeaHqnIHDx3djh6YSb == null;
	}

	internal static ProcessGroupManager kU6kRPnriZUpLOdftTZ()
	{
		return TdeaHqnIHDx3djh6YSb;
	}

	internal static void E83QpmneweGUi0ZHI3N(object P_0, Type P_1)
	{
		((ExportRule)P_0).ParentType = P_1;
	}

	internal static object oBqdqenNYeAYrA5Qcf3(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void Fq0QSAnxIxOrjF8bQdk(object P_0, object P_1)
	{
		((ExportRule)P_0).PropertyName = (string)P_1;
	}

	internal static void yobKWbnSuCQ5bxoE9IS(object P_0, ExportRuleType P_1)
	{
		((ExportRule)P_0).ExportRuleType = P_1;
	}

	internal static Type DoeEsUn1U9u5DhSagGf(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object U7WmO0nhaNhBnO9QM7e(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object t1iYVUnEGfXF1orGRRA(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object allafHnw2fvEwyTDPXT(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static object jfWlbyn4UQDKinkqBeZ(object P_0, Type P_1)
	{
		return Expression.Constant(P_0, P_1);
	}

	internal static object LNU70DnzIY50KIvqyZ6(RuntimeFieldHandle P_0)
	{
		return FieldInfo.GetFieldFromHandle(P_0);
	}

	internal static object GcAAuAHKdGKHQheI19G(object P_0, object P_1)
	{
		return Expression.Field((Expression)P_0, (FieldInfo)P_1);
	}

	internal static object i3Tq1mHOvyyNrTbHBvd(object P_0, object P_1)
	{
		return Expression.Equal((Expression)P_0, (Expression)P_1);
	}

	internal static void h02nkCHZr9tiBy6RerN(object P_0, object P_1)
	{
		((IProcessGroup)P_0).Parent = (IProcessGroup)P_1;
	}

	internal static void cRvcEvHvXleWRi3FDWU(object P_0)
	{
		((IEntity)P_0).Save();
	}

	internal static void a8LJ9RHYcqZHrGHD4yr(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void lcBcJdH8jW2VKI9kJsK(object P_0, object P_1)
	{
		((IProcessHeader)P_0).ParentGroup = (IProcessGroup)P_1;
	}

	internal static bool aowCBrHsvWGDfLp0Sm8(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void O1Cs6YHJhbQWkGJnqiB()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
