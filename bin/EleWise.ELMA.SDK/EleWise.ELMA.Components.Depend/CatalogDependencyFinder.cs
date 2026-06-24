using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.UI.Components.Dependency;
using EleWise.ELMA.UI.Components.Dependency.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Transform;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Components.DependencyFinders;

[Component]
internal sealed class CatalogDependencyFinder : IDependencyFinder
{
	private class DependencyWithScriptModule
	{
		internal static object vtTciw8lNQN1WCCOvvjq;

		public MetadataDependencyContainer Dependencies
		{
			[CompilerGenerated]
			get
			{
				return _003CDependencies_003Ek__BackingField;
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
						_003CDependencies_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
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
					case 1:
						_003CClientScriptModuleId_003Ek__BackingField = value;
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
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
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

		public DependencyWithScriptModule()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool inwa1R8l3auRTCZIcYiW()
		{
			return vtTciw8lNQN1WCCOvvjq == null;
		}

		internal static DependencyWithScriptModule WkSGsc8lprZOvgh1qfxc()
		{
			return (DependencyWithScriptModule)vtTciw8lNQN1WCCOvvjq;
		}
	}

	private readonly ISessionProvider sessionProvider;

	private static CatalogDependencyFinder Du9ixlfES9UMW42y9cu7;

	private ISession Session => (ISession)GShQF3fEq48U84QZKTlU(sessionProvider, string.Empty);

	public CatalogDependencyFinder(ISessionProvider sessionProvider)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		l5o5IlfEKEaDsXH3OUTK();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			this.sessionProvider = sessionProvider;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
			{
				num = 0;
			}
		}
	}

	public IEnumerable<Dependency> GetDependencies(IEnumerable<IDependencyRequest> dependencyRequests)
	{
		_003C_003Ec__DisplayClass4_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass4_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		IEnumerable<Dependency> enumerable = Enumerable.Empty<Dependency>();
		if (!dependencyRequests.Any())
		{
			return enumerable;
		}
		CS_0024_003C_003E8__locals0.dependenciesWithScriptModulesList = null;
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
				case 1:
					CS_0024_003C_003E8__locals0.dependenciesWithScriptModulesList = ((ICriteria)_003C_003Ec__DisplayClass4_0.WSF2Ht8l0BxMkuDmVgpB(_003C_003Ec__DisplayClass4_0.zJNGiD8lA4QB2hii85Ny(((ICriteria)_003C_003Ec__DisplayClass4_0.vA0DE88l6m8cRoIMB0qx(_003C_003Ec__DisplayClass4_0.vA0DE88l6m8cRoIMB0qx(_003C_003Ec__DisplayClass4_0.UDuF4G8l4tmAO8TFqQDF(CS_0024_003C_003E8__locals0._003C_003E4__this.Session.CreateCriteria<IMetadataItemHeader>(), _003C_003Ec__DisplayClass4_0.pPjUuf8lw17wqkSJAHM2(0x34185E55 ^ 0x341A20CF), _003C_003Ec__DisplayClass4_0.pPjUuf8lw17wqkSJAHM2(-1459557599 ^ -1459167175)), _003C_003Ec__DisplayClass4_0.pPjUuf8lw17wqkSJAHM2(-1979251663 ^ -1979190623), _003C_003Ec__DisplayClass4_0.pPjUuf8lw17wqkSJAHM2(0x7247028A ^ 0x72426EC2)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-16752921 ^ -16733391), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138603608))).Add((ICriterion)_003C_003Ec__DisplayClass4_0.WG5pA68lHm9GRJJPCc80(_003C_003Ec__DisplayClass4_0.pPjUuf8lw17wqkSJAHM2(0x1DE3DD89 ^ 0x1DE28DE1))), _003C_003Ec__DisplayClass4_0.WG5pA68lHm9GRJJPCc80(_003C_003Ec__DisplayClass4_0.pPjUuf8lw17wqkSJAHM2(0x57A5235E ^ 0x57A5D688))), new IProjection[3]
					{
						(IProjection)_003C_003Ec__DisplayClass4_0.wPLaZZ8l7JtuDxq6TRPS(Projections.Property((string)_003C_003Ec__DisplayClass4_0.pPjUuf8lw17wqkSJAHM2(-882126494 ^ -881993150)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3A5D5EF ^ 0x3A48587)),
						(IProjection)_003C_003Ec__DisplayClass4_0.wPLaZZ8l7JtuDxq6TRPS(_003C_003Ec__DisplayClass4_0.ih111S8lxj4E8hA84MKA(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x68BBB53E ^ 0x68BED964)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x17ADCCD8 ^ 0x17A8A0B0)),
						Projections.Alias((IProjection)_003C_003Ec__DisplayClass4_0.ih111S8lxj4E8hA84MKA(_003C_003Ec__DisplayClass4_0.pPjUuf8lw17wqkSJAHM2(0xD3DEF7E ^ 0xD3883F6)), (string)_003C_003Ec__DisplayClass4_0.pPjUuf8lw17wqkSJAHM2(-234299632 ^ -233983096))
					})).SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(DependencyWithScriptModule))).List<DependencyWithScriptModule>();
					num6 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
					{
						num6 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		});
		foreach (DependencyWithScriptModule dependenciesWithScriptModules in CS_0024_003C_003E8__locals0.dependenciesWithScriptModulesList)
		{
			MetadataDependencyContainer dependencies = dependenciesWithScriptModules.Dependencies;
			foreach (IDependencyRequest dependencyRequest in dependencyRequests)
			{
				_003C_003Ec__DisplayClass4_1 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass4_1();
				CS_0024_003C_003E8__locals1.moduleUid = dependencyRequest.ModuleUid;
				IEnumerable<FunctionDependency> second = dependencies.FunctionDependencies.Where((FunctionDependency a) => _003C_003Ec__DisplayClass4_1.SOmOkm8ldZKfLCiHfxq2(a) == CS_0024_003C_003E8__locals1.moduleUid);
				IEnumerable<DataClassDependency> second2 = dependencies.DataClassDependencies.Where((DataClassDependency a) => _003C_003Ec__DisplayClass4_1.eJTNka8llOZ09OUtjHhc(_003C_003Ec__DisplayClass4_1.SOmOkm8ldZKfLCiHfxq2(a), CS_0024_003C_003E8__locals1.moduleUid));
				IEnumerable<Dependency> second3 = dependencies.FormDependencies.SelectMany(delegate(FormViewItemDependencyContainer a)
				{
					IEnumerable<ComponentDependency> first = a.ComponentDependencies.Where((ComponentDependency c) => c.ModuleUid == CS_0024_003C_003E8__locals1.moduleUid);
					IEnumerable<DataClassDependency> second6 = a.DataClassDependencies.Where((DataClassDependency d) => _003C_003Ec__DisplayClass4_1.eJTNka8llOZ09OUtjHhc(_003C_003Ec__DisplayClass4_1.SOmOkm8ldZKfLCiHfxq2(d), CS_0024_003C_003E8__locals1.moduleUid));
					return ((IEnumerable<Dependency>)first).Concat((IEnumerable<Dependency>)second6);
				});
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
					CS_0024_003C_003E8__locals0.serverScriptModuleDependencyContainers = ((ICriteria)_003C_003Ec__DisplayClass4_0.WSF2Ht8l0BxMkuDmVgpB(CS_0024_003C_003E8__locals0._003C_003E4__this.Session.CreateCriteria<ScriptModule>().Add((ICriterion)_003C_003Ec__DisplayClass4_0.wrOcvx8lmlDGtKsetDwT(_003C_003Ec__DisplayClass4_0.pPjUuf8lw17wqkSJAHM2(-210725949 ^ -210759011), CS_0024_003C_003E8__locals0.dependenciesWithScriptModulesList.Select((DependencyWithScriptModule s) => _003C_003Ec.o964AS8lYw7rfWfnNtbd(s)).ToArray())).Add((ICriterion)(object)Restrictions.IsNotNull((string)_003C_003Ec__DisplayClass4_0.pPjUuf8lw17wqkSJAHM2(0x20261A4F ^ 0x20274A27))), new IProjection[1] { (IProjection)Projections.Property((string)_003C_003Ec__DisplayClass4_0.pPjUuf8lw17wqkSJAHM2(0x7C1EE318 ^ 0x7C1FB370)) })).List<ScriptModuleDependencyContainer>();
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
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
					CS_0024_003C_003E8__locals0.clientScriptModuleDependencyContainers = ((ICriteria)_003C_003Ec__DisplayClass4_0.WSF2Ht8l0BxMkuDmVgpB(_003C_003Ec__DisplayClass4_0.zJNGiD8lA4QB2hii85Ny(_003C_003Ec__DisplayClass4_0.zJNGiD8lA4QB2hii85Ny(CS_0024_003C_003E8__locals0._003C_003E4__this.Session.CreateCriteria<ScriptModule>(), _003C_003Ec__DisplayClass4_0.wrOcvx8lmlDGtKsetDwT(_003C_003Ec__DisplayClass4_0.pPjUuf8lw17wqkSJAHM2(0x53CB464B ^ 0x53CBC715), CS_0024_003C_003E8__locals0.dependenciesWithScriptModulesList.Select((DependencyWithScriptModule s) => s.ClientScriptModuleId).ToArray())), _003C_003Ec__DisplayClass4_0.WG5pA68lHm9GRJJPCc80(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-210725949 ^ -210648149))), new IProjection[1] { (IProjection)_003C_003Ec__DisplayClass4_0.ih111S8lxj4E8hA84MKA(_003C_003Ec__DisplayClass4_0.pPjUuf8lw17wqkSJAHM2(-70007027 ^ -70084763)) })).List<ScriptModuleDependencyContainer>();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		});
		IEnumerable<Dependency> second4 = ScriptModuleDependencies(CS_0024_003C_003E8__locals0.serverScriptModuleDependencyContainers, dependencyRequests);
		IEnumerable<Dependency> second5 = ScriptModuleDependencies(CS_0024_003C_003E8__locals0.clientScriptModuleDependencyContainers, dependencyRequests);
		return enumerable.Concat(second4).Concat(second5);
	}

	private static IEnumerable<Dependency> ScriptModuleDependencies(IEnumerable<ScriptModuleDependencyContainer> scriptModuleDependencyContainers, IEnumerable<IDependencyRequest> dependencyRequests)
	{
		IEnumerable<Dependency> enumerable = Enumerable.Empty<Dependency>();
		foreach (ScriptModuleDependencyContainer scriptModuleDependencyContainer in scriptModuleDependencyContainers)
		{
			foreach (IDependencyRequest dependencyRequest in dependencyRequests)
			{
				_003C_003Ec__DisplayClass6_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass6_0();
				CS_0024_003C_003E8__locals0.moduleUid = dependencyRequest.ModuleUid;
				IEnumerable<DataClassDependency> second = scriptModuleDependencyContainer.DataClassDependencies.Where((DataClassDependency a) => _003C_003Ec__DisplayClass6_0.P0bLB98lz0VjqbhDCvPe(a) == CS_0024_003C_003E8__locals0.moduleUid);
				enumerable = enumerable.Concat(second);
			}
		}
		return enumerable;
	}

	internal static object GShQF3fEq48U84QZKTlU(object P_0, object P_1)
	{
		return ((ISessionProvider)P_0).GetSession((string)P_1);
	}

	internal static bool oHyN0kfEiEgGuvIJawSj()
	{
		return Du9ixlfES9UMW42y9cu7 == null;
	}

	internal static CatalogDependencyFinder tbDSvafERSCo6Bt72HmS()
	{
		return Du9ixlfES9UMW42y9cu7;
	}

	internal static void l5o5IlfEKEaDsXH3OUTK()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
