using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.UI.Components.Dependency;
using EleWise.ELMA.UI.Components.Dependency.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Components.DependencyFinders;

[Component]
internal sealed class ModuleDependencyFinder : IDependencyFinder
{
	private readonly ISessionProvider sessionProvider;

	private static ModuleDependencyFinder TK5nBKfEXwV1uUR9pFww;

	private ISession Session => (ISession)Atq64PfEnZxsM9p9b1jt(sessionProvider, string.Empty);

	public ModuleDependencyFinder(ISessionProvider sessionProvider)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		CDj9axfEOR7d4ZgPeewx();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
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
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
			{
				num = 1;
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
		CS_0024_003C_003E8__locals0.moduleUids = dependencyRequests.Select((IDependencyRequest a) => _003C_003Ec.o9p8Ly8rKjKOYy0MEux6(a)).ToArray();
		CS_0024_003C_003E8__locals0.moduleInfoMetadatas = null;
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
					CS_0024_003C_003E8__locals0.moduleInfoMetadatas = ((ICriteria)_003C_003Ec__DisplayClass4_0.jjbo5j8rCJJ3A4nXXHCy(_003C_003Ec__DisplayClass4_0.ngghoR8rEnVGJFFNp9wW(_003C_003Ec__DisplayClass4_0.ngghoR8rEnVGJFFNp9wW(_003C_003Ec__DisplayClass4_0.ngghoR8rEnVGJFFNp9wW(_003C_003Ec__DisplayClass4_0.ngghoR8rEnVGJFFNp9wW(_003C_003Ec__DisplayClass4_0.IGKitK8rbOXr1sc0ALll(CS_0024_003C_003E8__locals0._003C_003E4__this.Session.CreateCriteria<ModuleMetadataItem>(), _003C_003Ec__DisplayClass4_0.G8nIgF8rorVrtALlsTek(0xD3DEF7E ^ 0xD3D59CC), _003C_003Ec__DisplayClass4_0.G8nIgF8rorVrtALlsTek(0x63ABA4E8 ^ 0x63ADAFAA)), _003C_003Ec__DisplayClass4_0.QOjPJv8rGqxQHk4aJ3EK(_003C_003Ec__DisplayClass4_0.l9Za6f8rhDdEKIPUUDIG(_003C_003Ec__DisplayClass4_0.G8nIgF8rorVrtALlsTek(0x269E5FCA ^ 0x26985484), CS_0024_003C_003E8__locals0.moduleUids))), _003C_003Ec__DisplayClass4_0.K1flCG8rfKEFMarEfbFk(_003C_003Ec__DisplayClass4_0.G8nIgF8rorVrtALlsTek(-1939377524 ^ -1939768850))), _003C_003Ec__DisplayClass4_0.K1flCG8rfKEFMarEfbFk(_003C_003Ec__DisplayClass4_0.G8nIgF8rorVrtALlsTek(0x571EA399 ^ 0x571F13C9))), _003C_003Ec__DisplayClass4_0.K1flCG8rfKEFMarEfbFk(_003C_003Ec__DisplayClass4_0.G8nIgF8rorVrtALlsTek(0x7EC153F ^ 0x7ECA3FD))), new IProjection[1] { (IProjection)_003C_003Ec__DisplayClass4_0.WD0GJk8rQZv5eIgNekDP(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -867782002)) })).List<ModuleInfoMetadata>();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		});
		foreach (ModuleInfoMetadata moduleInfoMetadata in CS_0024_003C_003E8__locals0.moduleInfoMetadatas)
		{
			ModuleDependency dependency = moduleInfoMetadata.Dependency;
			Guid[] moduleUids = CS_0024_003C_003E8__locals0.moduleUids;
			for (int i = 0; i < moduleUids.Length; i++)
			{
				_003C_003Ec__DisplayClass4_1 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass4_1();
				CS_0024_003C_003E8__locals1.moduleUid = moduleUids[i];
				IEnumerable<FunctionDependency> second = dependency.Functions.Where((FunctionDependency a) => _003C_003Ec__DisplayClass4_1.IPcBly8rVcUBOxqulVxR(_003C_003Ec__DisplayClass4_1.l8av2o8rIFGBfvwV28rB(a), CS_0024_003C_003E8__locals1.moduleUid));
				IEnumerable<DataClassDependency> second2 = dependency.DataClasses.Where((DataClassDependency a) => _003C_003Ec__DisplayClass4_1.IPcBly8rVcUBOxqulVxR(a.ModuleUid, CS_0024_003C_003E8__locals1.moduleUid));
				IEnumerable<ComponentDependency> second3 = dependency.Components.Where((ComponentDependency a) => a.ModuleUid == CS_0024_003C_003E8__locals1.moduleUid);
				enumerable = enumerable.Concat(second).Concat(second2).Concat(second3);
			}
		}
		return enumerable;
	}

	internal static object Atq64PfEnZxsM9p9b1jt(object P_0, object P_1)
	{
		return ((ISessionProvider)P_0).GetSession((string)P_1);
	}

	internal static bool np5O0RfETeM9rTnluk05()
	{
		return TK5nBKfEXwV1uUR9pFww == null;
	}

	internal static ModuleDependencyFinder B2fiosfEkoGAPm6x1PDw()
	{
		return TK5nBKfEXwV1uUR9pFww;
	}

	internal static void CDj9axfEOR7d4ZgPeewx()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
