using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.UI.Components.Dependency.Models;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.Components.Dependency;

[Component]
internal sealed class ComponentDependencyFinder : IDependencyFinder
{
	private class ComponentMetadataWithScriptModule
	{
		internal static object iiwXItQEumD5AMDiQOXT;

		public ComponentMetadata ComponentMetadata
		{
			[CompilerGenerated]
			get
			{
				return _003CComponentMetadata_003Ek__BackingField;
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
						_003CComponentMetadata_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public long ClientScriptModuleId
		{
			[CompilerGenerated]
			get
			{
				return _003CClientScriptModuleId_003Ek__BackingField;
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
						_003CClientScriptModuleId_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public long ScriptModuleId
		{
			[CompilerGenerated]
			get
			{
				return _003CScriptModuleId_003Ek__BackingField;
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
						_003CScriptModuleId_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
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

		public ComponentMetadataWithScriptModule()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			oJUrJHQESjAAdRDBqZTE();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool P8sQ2FQEIXe7tgHPg5pC()
		{
			return iiwXItQEumD5AMDiQOXT == null;
		}

		internal static ComponentMetadataWithScriptModule T34L27QEVvAJvLr9p8BU()
		{
			return (ComponentMetadataWithScriptModule)iiwXItQEumD5AMDiQOXT;
		}

		internal static void oJUrJHQESjAAdRDBqZTE()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	private readonly ISessionProvider sessionProvider;

	internal static ComponentDependencyFinder Tvn3vlBuEtSKCyquoPG8;

	private ISession Session => (ISession)lghD42BuCKPQ8v9qb10s(sessionProvider, string.Empty);

	public ComponentDependencyFinder(ISessionProvider sessionProvider)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		EjNHrnBuvkYK1e4QqZru();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				this.sessionProvider = sessionProvider;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public IEnumerable<EleWise.ELMA.Model.Dependencies.Dependency> GetDependencies(IEnumerable<IDependencyRequest> dependencyRequests)
	{
		_003C_003Ec__DisplayClass4_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass4_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		IEnumerable<EleWise.ELMA.Model.Dependencies.Dependency> enumerable = Enumerable.Empty<EleWise.ELMA.Model.Dependencies.Dependency>();
		if (!dependencyRequests.Any())
		{
			return enumerable;
		}
		CS_0024_003C_003E8__locals0.componentMetadataWithScriptModules = null;
		Session.ExecuteWithTimeout(0, delegate
		{
			int num5 = 1;
			int num6 = num5;
			while (true)
			{
				switch (num6)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					CS_0024_003C_003E8__locals0.componentMetadataWithScriptModules = ((ICriteria)_003C_003Ec__DisplayClass4_0.VPKJHTQE1EtSWuTRcbd8(((ICriteria)_003C_003Ec__DisplayClass4_0.DjcrhlQEn0YMvcgPNH2W(_003C_003Ec__DisplayClass4_0.DjcrhlQEn0YMvcgPNH2W(_003C_003Ec__DisplayClass4_0.DjcrhlQEn0YMvcgPNH2W(_003C_003Ec__DisplayClass4_0.IADB7NQETAbFphfp4Mt4(_003C_003Ec__DisplayClass4_0.IADB7NQETAbFphfp4Mt4(CS_0024_003C_003E8__locals0._003C_003E4__this.Session.CreateCriteria<ComponentMetadataItem>(), _003C_003Ec__DisplayClass4_0.DtfNkgQEXdUlkfSq16fC(-281842504 ^ -281830872), _003C_003Ec__DisplayClass4_0.DtfNkgQEXdUlkfSq16fC(-561074844 ^ -561266388)), _003C_003Ec__DisplayClass4_0.DtfNkgQEXdUlkfSq16fC(0x68BBB53E ^ 0x68BB40E8), _003C_003Ec__DisplayClass4_0.DtfNkgQEXdUlkfSq16fC(-1638402543 ^ -1638753727)), _003C_003Ec__DisplayClass4_0.OjxBERQEkaUS97eCmo6g(_003C_003Ec__DisplayClass4_0.DtfNkgQEXdUlkfSq16fC(0x17ADCCD8 ^ 0x17AD398C), true)), _003C_003Ec__DisplayClass4_0.OjxBERQEkaUS97eCmo6g(_003C_003Ec__DisplayClass4_0.DtfNkgQEXdUlkfSq16fC(-1858887263 ^ -1858906129), false)), _003C_003Ec__DisplayClass4_0.c14yekQEOv3Ih4hjZlfN(_003C_003Ec__DisplayClass4_0.DtfNkgQEXdUlkfSq16fC(-1146510045 ^ -1146445079)))).SetProjection((IProjection[])(object)new IProjection[3]
					{
						(IProjection)_003C_003Ec__DisplayClass4_0.IC7n6WQEeBHq1BlZvyeI(_003C_003Ec__DisplayClass4_0.WcYS7tQE2Vaf1FLgUA20(_003C_003Ec__DisplayClass4_0.DtfNkgQEXdUlkfSq16fC(-2138958856 ^ -2138921670)), _003C_003Ec__DisplayClass4_0.DtfNkgQEXdUlkfSq16fC(--1418440330 ^ 0x548B5D5C)),
						(IProjection)_003C_003Ec__DisplayClass4_0.IC7n6WQEeBHq1BlZvyeI(_003C_003Ec__DisplayClass4_0.WcYS7tQE2Vaf1FLgUA20(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-957824448 ^ -957501926)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12A5FAC7 ^ 0x12A096AF)),
						(IProjection)_003C_003Ec__DisplayClass4_0.IC7n6WQEeBHq1BlZvyeI(_003C_003Ec__DisplayClass4_0.WcYS7tQE2Vaf1FLgUA20(_003C_003Ec__DisplayClass4_0.DtfNkgQEXdUlkfSq16fC(-1411196499 ^ -1410878171)), _003C_003Ec__DisplayClass4_0.DtfNkgQEXdUlkfSq16fC(0x269E5FCA ^ 0x269B3352))
					}), new AliasToBeanResultTransformer(_003C_003Ec__DisplayClass4_0.kUe61WQEPnRecsmqXDIH(typeof(ComponentMetadataWithScriptModule).TypeHandle)))).List<ComponentMetadataWithScriptModule>();
					num6 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
					{
						num6 = 0;
					}
					break;
				}
			}
		});
		foreach (ComponentMetadataWithScriptModule componentMetadataWithScriptModule in CS_0024_003C_003E8__locals0.componentMetadataWithScriptModules)
		{
			ComponentMetadata componentMetadata = componentMetadataWithScriptModule.ComponentMetadata;
			foreach (IDependencyRequest dependencyRequest in dependencyRequests)
			{
				_003C_003Ec__DisplayClass4_1 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass4_1();
				CS_0024_003C_003E8__locals1.moduleUid = dependencyRequest.ModuleUid;
				IEnumerable<FunctionDependency> second = componentMetadata.FunctionDependencies.Where((FunctionDependency a) => _003C_003Ec__DisplayClass4_1.BYBQsjQE49yV1QKeMGRx(_003C_003Ec__DisplayClass4_1.xVhtbXQEwCy2UGCJAEBt(a), CS_0024_003C_003E8__locals1.moduleUid));
				IEnumerable<DataClassDependency> second2 = componentMetadata.DataClassDependencies.Where((DataClassDependency a) => _003C_003Ec__DisplayClass4_1.BYBQsjQE49yV1QKeMGRx(a.ModuleUid, CS_0024_003C_003E8__locals1.moduleUid));
				IEnumerable<ComponentDependency> second3 = componentMetadata.ComponentDependencies.Where((ComponentDependency a) => _003C_003Ec__DisplayClass4_1.BYBQsjQE49yV1QKeMGRx(a.ModuleUid, CS_0024_003C_003E8__locals1.moduleUid));
				enumerable = enumerable.Concat(second).Concat(second2).Concat(second3);
			}
		}
		CS_0024_003C_003E8__locals0.serverScriptModuleDependencyContainers = null;
		Session.ExecuteWithTimeout(0, delegate
		{
			int num3 = 1;
			int num4 = num3;
			while (true)
			{
				switch (num4)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					CS_0024_003C_003E8__locals0.serverScriptModuleDependencyContainers = ((ICriteria)_003C_003Ec__DisplayClass4_0.O0O6qmQE3GbdKZ5dYjwk(_003C_003Ec__DisplayClass4_0.DjcrhlQEn0YMvcgPNH2W(_003C_003Ec__DisplayClass4_0.DjcrhlQEn0YMvcgPNH2W(CS_0024_003C_003E8__locals0._003C_003E4__this.Session.CreateCriteria<ScriptModule>(), _003C_003Ec__DisplayClass4_0.A9mVXBQENvsrnffMHXKw(_003C_003Ec__DisplayClass4_0.DtfNkgQEXdUlkfSq16fC(-35995181 ^ -36028275), CS_0024_003C_003E8__locals0.componentMetadataWithScriptModules.Select((ComponentMetadataWithScriptModule c) => _003C_003Ec.SThpU9QExvX0F7aGVl4P(c)).ToArray())), Restrictions.IsNotNull((string)_003C_003Ec__DisplayClass4_0.DtfNkgQEXdUlkfSq16fC(0x5DD55050 ^ 0x5DD40038))), new IProjection[1] { (IProjection)Projections.Property((string)_003C_003Ec__DisplayClass4_0.DtfNkgQEXdUlkfSq16fC(0x18A6761F ^ 0x18A72677)) })).List<ScriptModuleDependencyContainer>();
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
					{
						num4 = 0;
					}
					break;
				}
			}
		});
		CS_0024_003C_003E8__locals0.clientScriptModuleDependencyContainers = null;
		Session.ExecuteWithTimeout(0, delegate
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
					CS_0024_003C_003E8__locals0.clientScriptModuleDependencyContainers = ((ICriteria)_003C_003Ec__DisplayClass4_0.DjcrhlQEn0YMvcgPNH2W(CS_0024_003C_003E8__locals0._003C_003E4__this.Session.CreateCriteria<ScriptModule>(), _003C_003Ec__DisplayClass4_0.A9mVXBQENvsrnffMHXKw(_003C_003Ec__DisplayClass4_0.DtfNkgQEXdUlkfSq16fC(-3333094 ^ -3300028), CS_0024_003C_003E8__locals0.componentMetadataWithScriptModules.Select((ComponentMetadataWithScriptModule c) => _003C_003Ec.gfUXC6QE0xX9FeM8NQof(c)).ToArray()))).Add((ICriterion)(object)Restrictions.IsNotNull((string)_003C_003Ec__DisplayClass4_0.DtfNkgQEXdUlkfSq16fC(-477139494 ^ -477217358))).SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.Property(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2107925386)) }).List<ScriptModuleDependencyContainer>();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		});
		IEnumerable<EleWise.ELMA.Model.Dependencies.Dependency> second4 = ScriptModuleDependencies(CS_0024_003C_003E8__locals0.serverScriptModuleDependencyContainers, dependencyRequests);
		IEnumerable<EleWise.ELMA.Model.Dependencies.Dependency> second5 = ScriptModuleDependencies(CS_0024_003C_003E8__locals0.clientScriptModuleDependencyContainers, dependencyRequests);
		return enumerable.Concat(second4).Concat(second5);
	}

	private static IEnumerable<EleWise.ELMA.Model.Dependencies.Dependency> ScriptModuleDependencies(IEnumerable<ScriptModuleDependencyContainer> scriptModuleDependencyContainers, IEnumerable<IDependencyRequest> dependencyRequests)
	{
		IEnumerable<EleWise.ELMA.Model.Dependencies.Dependency> enumerable = Enumerable.Empty<EleWise.ELMA.Model.Dependencies.Dependency>();
		foreach (ScriptModuleDependencyContainer scriptModuleDependencyContainer in scriptModuleDependencyContainers)
		{
			foreach (IDependencyRequest dependencyRequest in dependencyRequests)
			{
				_003C_003Ec__DisplayClass6_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass6_0();
				CS_0024_003C_003E8__locals0.moduleUid = dependencyRequest.ModuleUid;
				IEnumerable<DataClassDependency> second = scriptModuleDependencyContainer.DataClassDependencies.Where((DataClassDependency a) => _003C_003Ec__DisplayClass6_0.fOxvRcQEJWcYSP77hjdS(a.ModuleUid, CS_0024_003C_003E8__locals0.moduleUid));
				enumerable = enumerable.Concat(second);
			}
		}
		return enumerable;
	}

	internal static object lghD42BuCKPQ8v9qb10s(object P_0, object P_1)
	{
		return ((ISessionProvider)P_0).GetSession((string)P_1);
	}

	internal static bool jFZkqPBufjHtnPDNu0aw()
	{
		return Tvn3vlBuEtSKCyquoPG8 == null;
	}

	internal static ComponentDependencyFinder ps8Y6HBuQt13bxqvAC7P()
	{
		return Tvn3vlBuEtSKCyquoPG8;
	}

	internal static void EjNHrnBuvkYK1e4QqZru()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
