using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Scripts.Manager;

public class GlobalScriptModuleHeaderManager : EntityManager<IGlobalScriptModuleHeader, long>
{
	private readonly string headerPublished;

	private readonly string assemblyStatus;

	private readonly string assemblyName;

	private readonly string headerNamespace;

	internal static GlobalScriptModuleHeaderManager eQuWiBbnptDKtvmKIfb3;

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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public GlobalScriptModuleManager GlobalScriptModuleManager => Locator.GetServiceNotNull<GlobalScriptModuleManager>();

	public new static GlobalScriptModuleHeaderManager Instance => Locator.GetServiceNotNull<GlobalScriptModuleHeaderManager>();

	public override void SetupFilter(ICriteria criteria, IEntityFilter filter)
	{
		//Discarded unreachable code: IL_011b, IL_012a, IL_013a, IL_0149
		int num = 7;
		int num2 = num;
		IGlobalScriptModuleHeaderFilter globalScriptModuleHeaderFilter = default(IGlobalScriptModuleHeaderFilter);
		DetachedCriteria val = default(DetachedCriteria);
		while (true)
		{
			switch (num2)
			{
			case 8:
				if (globalScriptModuleHeaderFilter == null)
				{
					num2 = 4;
					break;
				}
				goto case 2;
			case 1:
				val = ((DetachedCriteria)Y2g6LgbnHlVVrBuRORRv(tFJmccbn4y6rDMk8sv3N(InterfaceActivator.TypeOf<AssemblyModelsMetadata>()), fqARP6bn6Tr9WWwE2qOP(assemblyStatus, AssemblyModelsMetadataStatus.GlobalModule))).SetProjection((IProjection)E36INLbnAOTqR3wlKan1(assemblyName));
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
				{
					num2 = 9;
				}
				break;
			case 3:
			case 10:
				if (globalScriptModuleHeaderFilter.LoadedOnly)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
					{
						num2 = 1;
					}
					break;
				}
				return;
			case 6:
				globalScriptModuleHeaderFilter = filter as IGlobalScriptModuleHeaderFilter;
				num2 = 8;
				break;
			case 2:
				if (!QrYk8qbntc2FnIjoid8X(globalScriptModuleHeaderFilter))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
					{
						num2 = 3;
					}
					break;
				}
				goto default;
			case 4:
				return;
			case 5:
				return;
			case 7:
				base.SetupFilter(criteria, filter);
				num2 = 6;
				break;
			default:
				criteria.Add((ICriterion)Nfd4OWbnwmwZm9gdq7GA(headerPublished));
				num2 = 10;
				break;
			case 9:
				ABrLL8bnx3hZhSlCQsaD(criteria, rqjJLLbn7XWwGQgTfFoc(headerNamespace, val));
				num2 = 5;
				break;
			}
		}
	}

	public virtual IEnumerable<IGlobalScriptModuleHeader> LoadRuntimeLoadedHeaders()
	{
		IGlobalScriptModuleHeaderFilter globalScriptModuleHeaderFilter = InterfaceActivator.Create<IGlobalScriptModuleHeaderFilter>();
		globalScriptModuleHeaderFilter.Deleted = false;
		globalScriptModuleHeaderFilter.PublishedOnly = true;
		globalScriptModuleHeaderFilter.LoadedOnly = true;
		return Find(globalScriptModuleHeaderFilter, null);
	}

	public virtual bool CheckGlobalScriptModuleName(long id, string name, out string errorMessage)
	{
		//Discarded unreachable code: IL_01af, IL_01be
		int num = 3;
		int num2 = num;
		ICriteria val = default(ICriteria);
		while (true)
		{
			switch (num2)
			{
			case 7:
				ABrLL8bnx3hZhSlCQsaD(val, JkaQm0bndn4FK7965Qc4(fqARP6bn6Tr9WWwE2qOP(im3aaEbnMRmTVLfZxexZ(0x6A81B9B4 ^ 0x6A8138EA), id)));
				num2 = 10;
				break;
			case 2:
				if (!rcX8XNbnye28oVt19ATh(PRclmdbnmUmRH3UFUdiF(name), string.Empty))
				{
					num2 = 5;
					break;
				}
				goto case 8;
			case 6:
				if (id > 0)
				{
					num2 = 7;
					break;
				}
				goto case 10;
			case 9:
				return false;
			case 5:
				errorMessage = string.Empty;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
				{
					num2 = 1;
				}
				break;
			case 8:
				errorMessage = SR.T((string)im3aaEbnMRmTVLfZxexZ(0x103FE975 ^ 0x103D21D1));
				num2 = 9;
				break;
			case 4:
				errorMessage = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x307E9FD1 ^ 0x307C5735));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				val = ((ICriteria)q1NRYXbnJBn0WfyOW3Vo(this, null)).Add((ICriterion)YFus6vbn9HDXUqTHNK2E(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6A81B9B4 ^ 0x6A81CA74), name));
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
				{
					num2 = 0;
				}
				break;
			case 10:
				if (BW9xgfbnlMlvCxqWA2Q5(this, val))
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
					{
						num2 = 4;
					}
					break;
				}
				return true;
			default:
				return false;
			case 3:
				if (!UjuXu6bn0pbaTgW95DUL(name))
				{
					num2 = 2;
					break;
				}
				goto case 8;
			}
		}
	}

	public virtual bool CheckGlobalScriptModuleClassName(long id, string name, out string errorMessage)
	{
		//Discarded unreachable code: IL_0059, IL_0143, IL_01d9, IL_021c, IL_022b
		int num = 11;
		int num2 = num;
		ICriteria val = default(ICriteria);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return false;
			case 6:
				return true;
			case 7:
				ABrLL8bnx3hZhSlCQsaD(val, JkaQm0bndn4FK7965Qc4(fqARP6bn6Tr9WWwE2qOP(im3aaEbnMRmTVLfZxexZ(-957824448 ^ -957856994), id)));
				num2 = 12;
				continue;
			case 1:
			case 12:
				if (!BW9xgfbnlMlvCxqWA2Q5(this, val))
				{
					num2 = 6;
					continue;
				}
				goto default;
			case 5:
				val = (ICriteria)ABrLL8bnx3hZhSlCQsaD(UdTY20bnrMo4y0B1tXYs(UdTY20bnrMo4y0B1tXYs(CreateCriteria(), im3aaEbnMRmTVLfZxexZ(0x7247028A ^ 0x7247AF76), im3aaEbnMRmTVLfZxexZ(0x1637C429 ^ 0x16350DA3)), im3aaEbnMRmTVLfZxexZ(-1876063057 ^ -1875950281), im3aaEbnMRmTVLfZxexZ(-1979251663 ^ -1979331187)), YFus6vbn9HDXUqTHNK2E(im3aaEbnMRmTVLfZxexZ(-561074844 ^ -561224526), name));
				num2 = 8;
				continue;
			case 11:
				if (UjuXu6bn0pbaTgW95DUL(name))
				{
					num2 = 10;
					continue;
				}
				goto case 13;
			default:
				errorMessage = SR.T((string)im3aaEbnMRmTVLfZxexZ(0x42643203 ^ 0x4266FBF9));
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
				{
					num2 = 0;
				}
				continue;
			case 13:
				if (!rcX8XNbnye28oVt19ATh(name.Trim(), string.Empty))
				{
					num2 = 4;
					continue;
				}
				break;
			case 8:
				if (id <= 0)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 7;
			case 9:
				return false;
			case 4:
				errorMessage = string.Empty;
				num2 = 5;
				continue;
			case 2:
			case 10:
				break;
			}
			errorMessage = SR.T((string)im3aaEbnMRmTVLfZxexZ(0x3B36AB09 ^ 0x3B3463AD));
			num2 = 9;
		}
	}

	public virtual bool CheckGlobalScriptModuleTableName(long id, string name, out string errorMessage)
	{
		//Discarded unreachable code: IL_006e, IL_007d, IL_0122, IL_0131
		int num = 7;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 6:
				if (string.IsNullOrEmpty(name))
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
					{
						num2 = 5;
					}
					break;
				}
				goto case 2;
			case 8:
				return false;
			case 9:
				errorMessage = string.Empty;
				num2 = 3;
				break;
			case 1:
				return false;
			case 4:
			case 5:
				errorMessage = (string)f9HkGHbn5iD0dGSgWlTH(im3aaEbnMRmTVLfZxexZ(0x3C5338FF ^ 0x3C51F05B));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				if (!rcX8XNbnye28oVt19ATh(PRclmdbnmUmRH3UFUdiF(name), string.Empty))
				{
					if (!HxSHDUbnYI7XmLemN8Ji(mgksgybnj7MrkP1hWJlE(TransformationProvider), name))
					{
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
						{
							num2 = 9;
						}
						break;
					}
					goto default;
				}
				num2 = 4;
				break;
			case 7:
				TWhwk2bngmqHq6HSJlLo(TransformationProvider, im3aaEbnMRmTVLfZxexZ(0x269E5FCA ^ 0x269C956E));
				num2 = 6;
				break;
			default:
				errorMessage = (string)f9HkGHbn5iD0dGSgWlTH(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606733368));
				num2 = 8;
				break;
			case 3:
				return true;
			}
		}
	}

	public override ExportRuleList ExportRules()
	{
		int num = 5;
		int num2 = num;
		ExportRuleList exportRuleList = default(ExportRuleList);
		Type type = default(Type);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return exportRuleList;
			case 5:
				type = G1J3oUbnLYquVKXEI0TE(this);
				num2 = 4;
				break;
			case 6:
			{
				ExportRuleList exportRuleList6 = exportRuleList;
				ExportRule exportRule = new ExportRule
				{
					ParentType = type
				};
				ExportRule exportRule6 = exportRule;
				ParameterExpression parameterExpression = (ParameterExpression)JcGLF5bncy7KoK0cv1ZY(JR1mfUbnsXNYqpbZOtka(typeof(IGlobalScriptModuleHeader).TypeHandle), im3aaEbnMRmTVLfZxexZ(0x53CACA3 ^ 0x53C0017));
				FgL7pvbOWV3MPxawRZVB(exportRule6, LinqUtils.NameOf(Expression.Lambda<Func<IGlobalScriptModuleHeader, object>>(Expression.Property(parameterExpression, (MethodInfo)zhtfuQbnzhinfd4yFxox((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
				eltPQsbOBmL5lH0xBUe0(exportRule, ExportRuleType.Export);
				exportRuleList6.Add(exportRule);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
				{
					num2 = 0;
				}
				break;
			}
			case 2:
			{
				ExportRuleList exportRuleList5 = exportRuleList;
				ExportRule exportRule = new ExportRule();
				nINSEZbnUoPM3v2rtxkQ(exportRule, type);
				ExportRule exportRule5 = exportRule;
				ParameterExpression parameterExpression = (ParameterExpression)JcGLF5bncy7KoK0cv1ZY(JR1mfUbnsXNYqpbZOtka(typeof(IGlobalScriptModuleHeader).TypeHandle), im3aaEbnMRmTVLfZxexZ(-1710575414 ^ -1710613378));
				FgL7pvbOWV3MPxawRZVB(exportRule5, LinqUtils.NameOf(Expression.Lambda<Func<IGlobalScriptModuleHeader, object>>((Expression)VZYI1cbOFIYULGmlKWws(parameterExpression, (MethodInfo)zhtfuQbnzhinfd4yFxox((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
				eltPQsbOBmL5lH0xBUe0(exportRule, ExportRuleType.Export);
				exportRuleList5.Add(exportRule);
				num2 = 3;
				break;
			}
			case 3:
			{
				ExportRuleList exportRuleList4 = exportRuleList;
				ExportRule exportRule = new ExportRule();
				nINSEZbnUoPM3v2rtxkQ(exportRule, type);
				ExportRule exportRule4 = exportRule;
				ParameterExpression parameterExpression = (ParameterExpression)JcGLF5bncy7KoK0cv1ZY(JR1mfUbnsXNYqpbZOtka(typeof(IGlobalScriptModuleHeader).TypeHandle), im3aaEbnMRmTVLfZxexZ(-521266112 ^ -521228044));
				FgL7pvbOWV3MPxawRZVB(exportRule4, LinqUtils.NameOf(Expression.Lambda<Func<IGlobalScriptModuleHeader, object>>(Expression.Property(parameterExpression, (MethodInfo)zhtfuQbnzhinfd4yFxox((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
				exportRule.ExportRuleType = ExportRuleType.Export;
				exportRuleList4.Add(exportRule);
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
				{
					num2 = 6;
				}
				break;
			}
			case 4:
				exportRuleList = new ExportRuleList();
				num2 = 7;
				break;
			case 7:
			{
				ExportRuleList exportRuleList3 = exportRuleList;
				ExportRule exportRule = new ExportRule();
				nINSEZbnUoPM3v2rtxkQ(exportRule, type);
				ExportRule exportRule3 = exportRule;
				ParameterExpression parameterExpression = (ParameterExpression)JcGLF5bncy7KoK0cv1ZY(JR1mfUbnsXNYqpbZOtka(typeof(IGlobalScriptModuleHeader).TypeHandle), im3aaEbnMRmTVLfZxexZ(-2112703338 ^ -2112743390));
				exportRule3.PropertyName = LinqUtils.NameOf(Expression.Lambda<Func<IGlobalScriptModuleHeader, object>>((Expression)VZYI1cbOFIYULGmlKWws(parameterExpression, (MethodInfo)zhtfuQbnzhinfd4yFxox((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
				eltPQsbOBmL5lH0xBUe0(exportRule, ExportRuleType.Export);
				exportRuleList3.Add(exportRule);
				num2 = 2;
				break;
			}
			default:
			{
				ExportRuleList exportRuleList2 = exportRuleList;
				ExportRule exportRule = new ExportRule();
				nINSEZbnUoPM3v2rtxkQ(exportRule, type);
				ExportRule exportRule2 = exportRule;
				ParameterExpression parameterExpression = (ParameterExpression)JcGLF5bncy7KoK0cv1ZY(JR1mfUbnsXNYqpbZOtka(typeof(IGlobalScriptModuleHeader).TypeHandle), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2108006230));
				exportRule2.PropertyName = LinqUtils.NameOf(Expression.Lambda<Func<IGlobalScriptModuleHeader, object>>((Expression)GgvJVVbOo3FdjBy6panG(VZYI1cbOFIYULGmlKWws(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), JR1mfUbnsXNYqpbZOtka(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
				eltPQsbOBmL5lH0xBUe0(exportRule, ExportRuleType.Export);
				exportRuleList2.Add(exportRule);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
				{
					num2 = 1;
				}
				break;
			}
			}
		}
	}

	public byte[] GetAssemblyRaw(Guid headerUid)
	{
		//Discarded unreachable code: IL_0073, IL_0082
		int num = 3;
		int num2 = num;
		IGlobalScriptModuleHeader globalScriptModuleHeader = default(IGlobalScriptModuleHeader);
		IGlobalScriptModule globalScriptModule = default(IGlobalScriptModule);
		while (true)
		{
			switch (num2)
			{
			case 3:
				globalScriptModuleHeader = LoadOrNull(headerUid);
				num2 = 2;
				break;
			case 5:
				globalScriptModule = GlobalScriptModuleManager.LoadOrNull(((IEntity<long>)FqUHcnbObRp2NWlnFiNH(globalScriptModuleHeader)).Id);
				num2 = 6;
				break;
			default:
				return (byte[])sdilkrbOhadC05PS4OVo(globalScriptModule.ScriptModule);
			case 1:
				return null;
			case 4:
				if (globalScriptModuleHeader.Published != null)
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
					{
						num2 = 5;
					}
					break;
				}
				goto case 1;
			case 2:
				if (globalScriptModuleHeader == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 4;
			case 6:
				if (globalScriptModule != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			}
		}
	}

	public GlobalScriptModuleHeaderManager()
	{
		//Discarded unreachable code: IL_00a8, IL_00ad
		Cx26VtbOG9HJZqGXvKWg();
		headerPublished = (string)im3aaEbnMRmTVLfZxexZ(0x571EA399 ^ 0x571CDD03);
		assemblyStatus = (string)im3aaEbnMRmTVLfZxexZ(0x3630F361 ^ 0x363072E7);
		assemblyName = (string)im3aaEbnMRmTVLfZxexZ(0x18A6761F ^ 0x18A605DF);
		headerNamespace = (string)im3aaEbnMRmTVLfZxexZ(-978351861 ^ -978448569);
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool RfTnUKbnaGaC1RTAQ249()
	{
		return eQuWiBbnptDKtvmKIfb3 == null;
	}

	internal static GlobalScriptModuleHeaderManager DpA9mdbnDnkUWfFiTqsB()
	{
		return eQuWiBbnptDKtvmKIfb3;
	}

	internal static bool QrYk8qbntc2FnIjoid8X(object P_0)
	{
		return ((IGlobalScriptModuleHeaderFilter)P_0).PublishedOnly;
	}

	internal static object Nfd4OWbnwmwZm9gdq7GA(object P_0)
	{
		return Restrictions.IsNotNull((string)P_0);
	}

	internal static object tFJmccbn4y6rDMk8sv3N(Type P_0)
	{
		return DetachedCriteria.For(P_0);
	}

	internal static object fqARP6bn6Tr9WWwE2qOP(object P_0, object P_1)
	{
		return Restrictions.Eq((string)P_0, P_1);
	}

	internal static object Y2g6LgbnHlVVrBuRORRv(object P_0, object P_1)
	{
		return ((DetachedCriteria)P_0).Add((ICriterion)P_1);
	}

	internal static object E36INLbnAOTqR3wlKan1(object P_0)
	{
		return Projections.Property((string)P_0);
	}

	internal static object rqjJLLbn7XWwGQgTfFoc(object P_0, object P_1)
	{
		return Subqueries.PropertyIn((string)P_0, (DetachedCriteria)P_1);
	}

	internal static object ABrLL8bnx3hZhSlCQsaD(object P_0, object P_1)
	{
		return ((ICriteria)P_0).Add((ICriterion)P_1);
	}

	internal static bool UjuXu6bn0pbaTgW95DUL(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object PRclmdbnmUmRH3UFUdiF(object P_0)
	{
		return ((string)P_0).Trim();
	}

	internal static bool rcX8XNbnye28oVt19ATh(object P_0, object P_1)
	{
		return ((string)P_0).Equals((string)P_1);
	}

	internal static object im3aaEbnMRmTVLfZxexZ(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object q1NRYXbnJBn0WfyOW3Vo(object P_0, object P_1)
	{
		return ((EntityManager<IGlobalScriptModuleHeader, long>)P_0).CreateCriteria((IEntityFilter)P_1);
	}

	internal static object YFus6vbn9HDXUqTHNK2E(object P_0, object P_1)
	{
		return ElmaRestrictions.InsensitiveLike((string)P_0, P_1);
	}

	internal static object JkaQm0bndn4FK7965Qc4(object P_0)
	{
		return Restrictions.Not((ICriterion)P_0);
	}

	internal static bool BW9xgfbnlMlvCxqWA2Q5(object P_0, object P_1)
	{
		return ((EntityManager<IGlobalScriptModuleHeader, long>)P_0).ReturnExists((ICriteria)P_1);
	}

	internal static object UdTY20bnrMo4y0B1tXYs(object P_0, object P_1, object P_2)
	{
		return ((ICriteria)P_0).CreateAlias((string)P_1, (string)P_2);
	}

	internal static void TWhwk2bngmqHq6HSJlLo(object P_0, object P_1)
	{
		Contract.ServiceNotNull(P_0, (string)P_1);
	}

	internal static object f9HkGHbn5iD0dGSgWlTH(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object mgksgybnj7MrkP1hWJlE(object P_0)
	{
		return ((ITransformationProvider)P_0).Dialect;
	}

	internal static bool HxSHDUbnYI7XmLemN8Ji(object P_0, object P_1)
	{
		return ((Dialect)P_0).IsReservedWord((string)P_1);
	}

	internal static Type G1J3oUbnLYquVKXEI0TE(object P_0)
	{
		return ((EntityManager<IGlobalScriptModuleHeader, long>)P_0).ImplementationType;
	}

	internal static void nINSEZbnUoPM3v2rtxkQ(object P_0, Type value)
	{
		((ExportRule)P_0).ParentType = value;
	}

	internal static Type JR1mfUbnsXNYqpbZOtka(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object JcGLF5bncy7KoK0cv1ZY(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object zhtfuQbnzhinfd4yFxox(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object VZYI1cbOFIYULGmlKWws(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static void eltPQsbOBmL5lH0xBUe0(object P_0, ExportRuleType value)
	{
		((ExportRule)P_0).ExportRuleType = value;
	}

	internal static void FgL7pvbOWV3MPxawRZVB(object P_0, object P_1)
	{
		((ExportRule)P_0).PropertyName = (string)P_1;
	}

	internal static object GgvJVVbOo3FdjBy6panG(object P_0, Type P_1)
	{
		return Expression.Convert((Expression)P_0, P_1);
	}

	internal static object FqUHcnbObRp2NWlnFiNH(object P_0)
	{
		return ((IGlobalScriptModuleHeader)P_0).Published;
	}

	internal static object sdilkrbOhadC05PS4OVo(object P_0)
	{
		return ((ScriptModule)P_0).AssemblyRaw;
	}

	internal static void Cx26VtbOG9HJZqGXvKWg()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
