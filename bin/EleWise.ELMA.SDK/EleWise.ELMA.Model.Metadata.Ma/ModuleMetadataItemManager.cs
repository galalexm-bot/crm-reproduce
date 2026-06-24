using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.SqlCommand;
using NHibernate.Transform;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Metadata.Managers;

internal class ModuleMetadataItemManager : EntityManager<ModuleMetadataItem, long>, IModuleMetadataItemManager, IEntityManager<ModuleMetadataItem, long>, IEntityManager<ModuleMetadataItem>, IEntityManager
{
	internal const string AssemblyPrefix = "__ModuleAssembly__";

	private readonly ConcurrentDictionary<string, ModuleMetadataItem> moduleCache;

	private IEnumerable<IEntityFilterProvider> entityFilterProviders;

	internal static ModuleMetadataItemManager th1ewLbz6nJVn7IEhUH3;

	private IEnumerable<IEntityFilterProvider> EntityFilterProviders => entityFilterProviders ?? (entityFilterProviders = Locator.GetServiceNotNull<IEnumerable<IEntityFilterProvider>>());

	public new static ModuleMetadataItemManager Instance => Locator.GetServiceNotNull<ModuleMetadataItemManager>();

	public ModuleMetadataItemManager()
	{
		//Discarded unreachable code: IL_003a, IL_003f
		SingletonReader.JJCZtPuTvSt();
		moduleCache = new ConcurrentDictionary<string, ModuleMetadataItem>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
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
				G9y9UJbzxxNcqtymHd7b(Eb2aIdbz7Van90fwoKB9(), new ResolveEventHandler(CurrentDomainOnAssemblyResolve));
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public UIMetadataPublishResult Publish(Guid headerUid, string comment)
	{
		throw new NotImplementedException();
	}

	public ModuleMetadataItem Create(string name, string displayName, string description)
	{
		int num = 4;
		int num2 = num;
		ModuleInfoMetadata moduleInfoMetadata = default(ModuleInfoMetadata);
		while (true)
		{
			switch (num2)
			{
			case 2:
				Rqok6xbzmkuJUgNLeQku(moduleInfoMetadata, displayName);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
			{
				ModuleMetadataItem moduleMetadataItem = Create();
				jAGsNlbzMltFjkarSWB8(moduleMetadataItem, moduleInfoMetadata);
				voZrQEbz9uRUmY4mEwSf(moduleMetadataItem, QhsIUgbzJ6LIyfPJNew4(moduleInfoMetadata));
				sKyYmybzdhR57YrjJmJr(moduleMetadataItem);
				return moduleMetadataItem;
			}
			case 3:
				O5hSTPbz0RnovppIDSS0(moduleInfoMetadata);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
				{
					num2 = 0;
				}
				break;
			default:
				Js7w3sbzyAQuEyX1AuWa(moduleInfoMetadata, description);
				num2 = 5;
				break;
			case 1:
				moduleInfoMetadata.Name = name;
				num2 = 2;
				break;
			case 4:
				moduleInfoMetadata = new ModuleInfoMetadata();
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public List<RuntimeModuleModel> LoadRuntimeMetadata(IEnumerable<Guid> itemUids, bool debug)
	{
		_003C_003Ec__DisplayClass10_0 _003C_003Ec__DisplayClass10_ = new _003C_003Ec__DisplayClass10_0();
		_003C_003Ec__DisplayClass10_._003C_003E4__this = this;
		List<RuntimeModuleModel> list = new List<RuntimeModuleModel>();
		if (itemUids.ToArray().Length == 0)
		{
			return list;
		}
		IList<ModuleMetadataItem> list2 = new List<ModuleMetadataItem>();
		_003C_003Ec__DisplayClass10_.notLoadedItemUids = new List<Guid>();
		foreach (Guid itemUid in itemUids)
		{
			if (moduleCache.TryGetValue(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x10E41EDB ^ 0x10E55E3F), itemUid, SR.CurrentLCID), out var value))
			{
				list2.Add(value);
			}
			else
			{
				_003C_003Ec__DisplayClass10_.notLoadedItemUids.Add(itemUid);
			}
		}
		if (_003C_003Ec__DisplayClass10_.notLoadedItemUids.Count > 0)
		{
			_003C_003Ec__DisplayClass10_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass10_1();
			CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass10_;
			CS_0024_003C_003E8__locals0.loadedModules = null;
			SR.LocalizableString.RunWithSRLocalizer(delegate
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
						CS_0024_003C_003E8__locals0.loadedModules = CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1._003C_003E4__this.CreateCriteriaForArraySearch(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.notLoadedItemUids, (string)_003C_003Ec__DisplayClass10_1.MaWMMeCJp0tUTguQOYIl(0x7247028A ^ 0x72476D18), null, null).List<ModuleMetadataItem>();
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			});
			foreach (ModuleMetadataItem loadedModule in CS_0024_003C_003E8__locals0.loadedModules)
			{
				moduleCache.TryAdd(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70088727), loadedModule.Uid, SR.CurrentLCID), loadedModule);
			}
			list2.AddRange(CS_0024_003C_003E8__locals0.loadedModules);
		}
		if (list2.Count == 0)
		{
			return list;
		}
		foreach (ModuleMetadataItem item in list2)
		{
			ModuleMetadataItem moduleMetadataItem = item;
			byte[] array = (debug ? item.ClientDebugRaw : item.ClientAssemblyRaw);
			string text = Encoding.UTF8.GetString(array ?? Array.Empty<byte>());
			ModuleInfoMetadata moduleInfoMetadata = (ModuleInfoMetadata)moduleMetadataItem.Metadata;
			if (moduleMetadataItem.Header.Published?.Id == moduleMetadataItem.Id)
			{
				foreach (ComponentMetadata component in moduleInfoMetadata.Components)
				{
					foreach (PropertyViewItem allProperty in component.Content.View.GetAllProperties())
					{
						FillFilterProvider(allProperty, null, moduleMetadataItem, component.Content.Context);
					}
				}
			}
			if (SR.GetCurrentCulture().Name != SR.KeyCultureInfo.Name)
			{
				text = SR.TranslateStringResource(text);
				moduleMetadataItem = CloneHelperBuilder.Create(item).Restrictions(delegate(RestrictionsBuilder<ModuleMetadataItem> a)
				{
					RestrictionBuilderSelectType<ModuleMetadataItem> restrictionBuilderSelectType = a.Rule();
					ParameterExpression parameterExpression = Expression.Parameter(typeof(ModuleMetadataItem), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7EC153F ^ 0x7ECE0AF));
					restrictionBuilderSelectType.ForPropertyName(Expression.Lambda<Func<ModuleMetadataItem, object>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })).ByRef();
				}).Clone();
				moduleMetadataItem.Uid = item.Uid;
				foreach (ComponentMetadata component2 in moduleInfoMetadata.Components)
				{
					component2.Content.View.ApplyLocalization();
				}
			}
			list.Add(new RuntimeModuleModel
			{
				MetadataItem = moduleMetadataItem,
				Script = new ClientScriptModel
				{
					AssemblyName = ClientAssemblyName(moduleInfoMetadata),
					SourceCode = text
				}
			});
		}
		return list;
	}

	public override void Save(ModuleMetadataItem obj)
	{
		int num = 7;
		ModuleInfoMetadata moduleInfoMetadata = default(ModuleInfoMetadata);
		IUser user = default(IUser);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 10:
					S1LkK0hFBCT3P9FiLe2m(V5RJkZbzUJJDyB8wfuaF(obj), H3R8g7hFFDt14Zx9gXar(moduleInfoMetadata));
					num2 = 15;
					continue;
				case 3:
					FaS10GbzzXpDKLYAlUBu(obj.Header, obj);
					num2 = 17;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
					{
						num2 = 15;
					}
					continue;
				case 11:
					HkPO2VbzgtXEUyW0oD2P(obj.Metadata is ModuleInfoMetadata, FQYAlkbzlFWi9cTXkavo(0x3A6135BE ^ 0x3A6229EA));
					num2 = 2;
					continue;
				case 15:
					xjLPaBhFob9aY6MPwtyX(V5RJkZbzUJJDyB8wfuaF(obj), xoRIuUhFWJCC875rEdiZ(moduleInfoMetadata));
					num2 = 8;
					continue;
				default:
					if (obj.Header == null)
					{
						num = 4;
						break;
					}
					goto case 17;
				case 13:
					((ModuleMetadataItemHeader)V5RJkZbzUJJDyB8wfuaF(obj)).Uid = QhsIUgbzJ6LIyfPJNew4(moduleInfoMetadata);
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
					{
						num2 = 0;
					}
					continue;
				case 17:
					moduleInfoMetadata = (ModuleInfoMetadata)IRlokkbzr7hAX5SAefqd(obj);
					num2 = 13;
					continue;
				case 7:
					Contract.ArgumentNotNull(obj, (string)FQYAlkbzlFWi9cTXkavo(0x92F12D5 ^ 0x92FB15D));
					num = 6;
					break;
				case 5:
					NvF8oebzc1B2i7LcZMvx(V5RJkZbzUJJDyB8wfuaF(obj), UcuscFbzsAPsYwp7BxPD(obj));
					num2 = 12;
					continue;
				case 8:
					base.Save(obj);
					num2 = 16;
					continue;
				case 6:
					HkPO2VbzgtXEUyW0oD2P(IRlokkbzr7hAX5SAefqd(obj) != null, FQYAlkbzlFWi9cTXkavo(-488881205 ^ -488850937));
					num2 = 11;
					continue;
				case 2:
					if (!YyWFfEbz5lEEclaRNNYn(obj))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
						{
							num2 = 1;
						}
					}
					else
					{
						user = (IUser)STC2YKbzjoTqpTrUilgc(base.AuthenticationService);
						num2 = 14;
					}
					continue;
				case 16:
					return;
				case 9:
					return;
				case 4:
					n3fyrDbzLFVg8NhCfvDX(obj, InterfaceActivator.Create<ModuleMetadataItemHeader>());
					num2 = 5;
					continue;
				case 1:
					base.Save(obj);
					num2 = 9;
					continue;
				case 14:
					obj.CreationAuthorId = (long?)((user != null) ? QA06IAbzYSnlPvass4Tr(user) : null);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
					{
						num2 = 0;
					}
					continue;
				case 12:
					obj.Header.CreationAuthorId = (long?)((user != null) ? QA06IAbzYSnlPvass4Tr(user) : null);
					num2 = 3;
					continue;
				}
				break;
			}
		}
	}

	public IEnumerable<ModuleMetadataItem> GetLastPublished(IEnumerable<Guid> notLoaded)
	{
		return CreateCriteria(FetchOptions.All, base.ImplementationType, z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1867379187 ^ 0x6F4D0463)).CreateAlias(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x61EC0CB8 ^ 0x61ECBA0A), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2108006230), (JoinType)0, (ICriterion)(object)Restrictions.EqProperty(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-309639236 ^ -309611990), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1751176224 ^ -1751130558))).Add((ICriterion)(object)Restrictions.Not((ICriterion)(object)Restrictions.In(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12A5FAC7 ^ 0x12A50F7B), (ICollection)notLoaded.ToArray()))).Add((ICriterion)(object)Restrictions.IsNotNull(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978441230)))
			.Add((ICriterion)(object)Restrictions.IsNotNull(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 0x4F7FC776)))
			.Add((ICriterion)(object)Restrictions.IsNotNull(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -36028249)))
			.List<ModuleMetadataItem>();
	}

	public IEnumerable<ModuleMetadataItemWrapper> GetLastPublishedHeaders(IEnumerable<Guid> notLoaded)
	{
		return CreateCriteria(FetchOptions.All, base.ImplementationType, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x57A5235E ^ 0x57A5D6CE)).CreateAlias(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1822890472 ^ -1822928726), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837641009), (JoinType)0, (ICriterion)(object)Restrictions.EqProperty(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-561074844 ^ -561096462), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-576149596 ^ -576171514))).Add((ICriterion)(object)Restrictions.Not((ICriterion)(object)Restrictions.In(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-138018305 ^ -137956285), (ICollection)notLoaded.ToArray()))).Add((ICriterion)(object)Restrictions.IsNotNull(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x66F566B6 ^ 0x66F4D7B6)))
			.Add((ICriterion)(object)Restrictions.IsNotNull(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-234299632 ^ -234345868)))
			.Add((ICriterion)(object)Restrictions.IsNotNull(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-3333094 ^ -3299986)))
			.SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.ProjectionList().Add((IProjection)(object)Projections.Property(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70045007)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1637C429 ^ 0x16373153)).Add((IProjection)(object)Projections.Property(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1DE3DD89 ^ 0x1DE3B21B)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1FFEF86A ^ 0x1FFE97F8))
				.Add((IProjection)(object)Projections.Property(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1979251663 ^ -1979190955)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x269E5FCA ^ 0x269EAAAE)) })
			.SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(ModuleMetadataItemWrapper)))
			.List<ModuleMetadataItemWrapper>();
	}

	internal static string ClientAssemblyName(ModuleInfoMetadata metadata)
	{
		return (string)cT841whFbe751E2uPBeH((string)FQYAlkbzlFWi9cTXkavo(-1886646897 ^ -1886592705) + (string)H3R8g7hFFDt14Zx9gXar(metadata), '.', '_');
	}

	internal static string ServerAssemblyName(ModuleInfoMetadata metadata)
	{
		return (string)sdPcyQhFhsV8fT3lOn9y(FQYAlkbzlFWi9cTXkavo(-1088304168 ^ -1088346264), H3R8g7hFFDt14Zx9gXar(metadata));
	}

	internal static Guid VersionUid(ModuleInfoMetadata metadata, string version)
	{
		return dJuLsNhFEa3mboGPDEcY(FksQXOhFG5lQJni74lXB(FQYAlkbzlFWi9cTXkavo(-475857671 ^ -475930523), QhsIUgbzJ6LIyfPJNew4(metadata), H3R8g7hFFDt14Zx9gXar(metadata), version));
	}

	private Assembly CurrentDomainOnAssemblyResolve(object sender, ResolveEventArgs args)
	{
		//Discarded unreachable code: IL_015b
		int num = 2;
		int num2 = num;
		ModuleMetadataItem moduleMetadataItem = default(ModuleMetadataItem);
		AssemblyName assemblyName = default(AssemblyName);
		Assembly assembly = default(Assembly);
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (((string)Ics6j9hFfSkFje2wQuya(args)).StartsWith(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x76DD48E ^ 0x76D383E)))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
					{
						num2 = 1;
					}
					break;
				}
				return null;
			case 3:
				moduleMetadataItem = ((ICriteria)DgEfXYhFvZ11JmFoJDXT(DgEfXYhFvZ11JmFoJDXT(CreateCriteria(), g0V8vPhFC3Zgl0p2neld(FQYAlkbzlFWi9cTXkavo(0x5F3078B6 ^ 0x5F31C8E6), z8AYYUhFQ4wP0oMSrGCb(assemblyName))), Restrictions.Eq((string)FQYAlkbzlFWi9cTXkavo(-740338220 ^ -740305760), (object)QWulBxhF8FiGb4Jj4QMa(assemblyName).ToString()))).UniqueResult<ModuleMetadataItem>();
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
				{
					num2 = 8;
				}
				break;
			case 7:
				if (eXwD0yhFu15Wb9Ghq5fV(assembly, null))
				{
					num2 = 6;
					break;
				}
				goto default;
			case 8:
				assembly = (Assembly)NjQDeDhFZrFPWaCjxoiW(ScriptExecutionHandlerHelper.CreateFullAssemblyName(assemblyName.Name, QWulBxhF8FiGb4Jj4QMa(assemblyName).ToString(), (string)FQYAlkbzlFWi9cTXkavo(0xA592A41 ^ 0xA59EFA7), (string)FQYAlkbzlFWi9cTXkavo(-1317790512 ^ -1317794762)), true);
				num2 = 7;
				break;
			default:
				return assembly;
			case 6:
				if (moduleMetadataItem == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 4;
			case 4:
				assembly = (Assembly)QLb46FhFSfe72dsBNNtK(TcUnOXhFIWwoBjOcJjNA(moduleMetadataItem), zdIpE4hFVTHM2ccetdxf(moduleMetadataItem));
				num2 = 5;
				break;
			case 1:
				assemblyName = new AssemblyName((string)Ics6j9hFfSkFje2wQuya(args));
				num2 = 3;
				break;
			}
		}
	}

	private void FillFilterProvider(PropertyViewItem propertyViewItem, Type containerType, IEntity entity, ClassMetadata contextMetadata)
	{
		//Discarded unreachable code: IL_0053, IL_0062, IL_006d, IL_010c, IL_011b, IL_0158, IL_01e0, IL_0218, IL_0227
		int num = 1;
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		ViewAttributes attributes = default(ViewAttributes);
		_003C_003Ec__DisplayClass18_0 _003C_003Ec__DisplayClass18_ = default(_003C_003Ec__DisplayClass18_0);
		IEnumerator<IEntityFilterProvider> enumerator = default(IEnumerator<IEntityFilterProvider>);
		IEntityFilterProvider current = default(IEntityFilterProvider);
		IEntityInstanceFilterProvider entityInstanceFilterProvider = default(IEntityInstanceFilterProvider);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (propertyMetadata == null)
					{
						num2 = 4;
						continue;
					}
					attributes = _003C_003Ec__DisplayClass18_.propertyViewItem.Attributes;
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
					{
						num2 = 5;
					}
					continue;
				case 7:
					try
					{
						while (true)
						{
							int num3;
							if (!R5hRKShFq2GJxHXNnTt8(enumerator))
							{
								num3 = 9;
								goto IL_0071;
							}
							goto IL_017e;
							IL_0071:
							while (true)
							{
								object obj;
								switch (num3)
								{
								case 1:
									attributes.EntityFilterProvider = current.ProviderUid;
									num3 = 8;
									continue;
								case 6:
									entityInstanceFilterProvider = current as IEntityInstanceFilterProvider;
									num3 = 3;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
									{
										num3 = 0;
									}
									continue;
								case 7:
									break;
								case 8:
									hQboEahFRHf5RHBHVNJ0(attributes, text);
									num3 = 4;
									continue;
								case 4:
									return;
								case 3:
									if (entityInstanceFilterProvider == null)
									{
										num3 = 4;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
										{
											num3 = 5;
										}
										continue;
									}
									obj = YPw3l3hFi7P7HSNpPqi5(entityInstanceFilterProvider, entity, containerType, propertyMetadata, attributes);
									goto IL_019e;
								case 5:
									obj = current.GetFilterProviderData(containerType, propertyMetadata, attributes);
									goto IL_019e;
								case 2:
									if (text != null)
									{
										num3 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
										{
											num3 = 1;
										}
										continue;
									}
									break;
								default:
									goto IL_017e;
								case 9:
									return;
									IL_019e:
									text = (string)obj;
									num3 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
									{
										num3 = 1;
									}
									continue;
								}
								break;
							}
							continue;
							IL_017e:
							current = enumerator.Current;
							num3 = 6;
							goto IL_0071;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							int num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
							{
								num4 = 1;
							}
							while (true)
							{
								switch (num4)
								{
								case 1:
									Ko67KDhFKwxRchufaCbi(enumerator);
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
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
				case 5:
					break;
				default:
					_003C_003Ec__DisplayClass18_.propertyViewItem = propertyViewItem;
					num2 = 6;
					continue;
				case 3:
					return;
				case 1:
					_003C_003Ec__DisplayClass18_ = new _003C_003Ec__DisplayClass18_0();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					return;
				case 6:
					propertyMetadata = contextMetadata.Properties.FirstOrDefault(_003C_003Ec__DisplayClass18_._003CFillFilterProvider_003Eb__0);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
					{
						num2 = 2;
					}
					continue;
				}
				break;
			}
			enumerator = EntityFilterProviders.GetEnumerator();
			num = 7;
		}
	}

	internal static object Eb2aIdbz7Van90fwoKB9()
	{
		return AppDomain.CurrentDomain;
	}

	internal static void G9y9UJbzxxNcqtymHd7b(object P_0, object P_1)
	{
		((AppDomain)P_0).AssemblyResolve += (ResolveEventHandler)P_1;
	}

	internal static bool YWji0qbzHgHkrdU6gVGP()
	{
		return th1ewLbz6nJVn7IEhUH3 == null;
	}

	internal static ModuleMetadataItemManager bH1wYabzAucifpgJhYwJ()
	{
		return th1ewLbz6nJVn7IEhUH3;
	}

	internal static void O5hSTPbz0RnovppIDSS0(object P_0)
	{
		((AbstractMetadata)P_0).InitNew();
	}

	internal static void Rqok6xbzmkuJUgNLeQku(object P_0, object P_1)
	{
		((NamedMetadata)P_0).DisplayName = (string)P_1;
	}

	internal static void Js7w3sbzyAQuEyX1AuWa(object P_0, object P_1)
	{
		((NamedMetadata)P_0).Description = (string)P_1;
	}

	internal static void jAGsNlbzMltFjkarSWB8(object P_0, object P_1)
	{
		((ModuleMetadataItem)P_0).Metadata = P_1;
	}

	internal static Guid QhsIUgbzJ6LIyfPJNew4(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static void voZrQEbz9uRUmY4mEwSf(object P_0, Guid value)
	{
		((ModuleMetadataItem)P_0).Uid = value;
	}

	internal static void sKyYmybzdhR57YrjJmJr(object P_0)
	{
		((Entity<long>)P_0).Save();
	}

	internal static object FQYAlkbzlFWi9cTXkavo(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object IRlokkbzr7hAX5SAefqd(object P_0)
	{
		return ((ModuleMetadataItem)P_0).Metadata;
	}

	internal static void HkPO2VbzgtXEUyW0oD2P(bool condition, object P_1)
	{
		Contract.CheckArgument(condition, (string)P_1);
	}

	internal static bool YyWFfEbz5lEEclaRNNYn(object P_0)
	{
		return ((Entity<long>)P_0).IsNew();
	}

	internal static object STC2YKbzjoTqpTrUilgc(object P_0)
	{
		return ((IAuthenticationService)P_0).GetCurrentUser();
	}

	internal static object QA06IAbzYSnlPvass4Tr(object P_0)
	{
		return ((IIdentified)P_0).GetId();
	}

	internal static void n3fyrDbzLFVg8NhCfvDX(object P_0, object P_1)
	{
		((ModuleMetadataItem)P_0).Header = (ModuleMetadataItemHeader)P_1;
	}

	internal static object V5RJkZbzUJJDyB8wfuaF(object P_0)
	{
		return ((ModuleMetadataItem)P_0).Header;
	}

	internal static DateTime UcuscFbzsAPsYwp7BxPD(object P_0)
	{
		return ((ModuleMetadataItem)P_0).CreationDate;
	}

	internal static void NvF8oebzc1B2i7LcZMvx(object P_0, DateTime value)
	{
		((ModuleMetadataItemHeader)P_0).CreationDate = value;
	}

	internal static void FaS10GbzzXpDKLYAlUBu(object P_0, object P_1)
	{
		((ModuleMetadataItemHeader)P_0).Draft = (ModuleMetadataItem)P_1;
	}

	internal static object H3R8g7hFFDt14Zx9gXar(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static void S1LkK0hFBCT3P9FiLe2m(object P_0, object P_1)
	{
		((ModuleMetadataItemHeader)P_0).Name = (string)P_1;
	}

	internal static object xoRIuUhFWJCC875rEdiZ(object P_0)
	{
		return ((NamedMetadata)P_0).DisplayName;
	}

	internal static void xjLPaBhFob9aY6MPwtyX(object P_0, object P_1)
	{
		((ModuleMetadataItemHeader)P_0).DisplayName = (string)P_1;
	}

	internal static object cT841whFbe751E2uPBeH(object P_0, char P_1, char P_2)
	{
		return ((string)P_0).Replace(P_1, P_2);
	}

	internal static object sdPcyQhFhsV8fT3lOn9y(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object FksQXOhFG5lQJni74lXB(object P_0, object P_1, object P_2, object P_3)
	{
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	internal static Guid dJuLsNhFEa3mboGPDEcY(object P_0)
	{
		return ((string)P_0).GetDeterministicGuid();
	}

	internal static object Ics6j9hFfSkFje2wQuya(object P_0)
	{
		return ((ResolveEventArgs)P_0).Name;
	}

	internal static object z8AYYUhFQ4wP0oMSrGCb(object P_0)
	{
		return ((AssemblyName)P_0).Name;
	}

	internal static object g0V8vPhFC3Zgl0p2neld(object P_0, object P_1)
	{
		return Restrictions.Eq((string)P_0, P_1);
	}

	internal static object DgEfXYhFvZ11JmFoJDXT(object P_0, object P_1)
	{
		return ((ICriteria)P_0).Add((ICriterion)P_1);
	}

	internal static object QWulBxhF8FiGb4Jj4QMa(object P_0)
	{
		return ((AssemblyName)P_0).Version;
	}

	internal static object NjQDeDhFZrFPWaCjxoiW(object P_0, bool isFullName)
	{
		return ComponentManager.FindLoadedAssembly((string)P_0, isFullName);
	}

	internal static bool eXwD0yhFu15Wb9Ghq5fV(object P_0, object P_1)
	{
		return (Assembly)P_0 == (Assembly)P_1;
	}

	internal static object TcUnOXhFIWwoBjOcJjNA(object P_0)
	{
		return ((ModuleMetadataItem)P_0).AssemblyRaw;
	}

	internal static object zdIpE4hFVTHM2ccetdxf(object P_0)
	{
		return ((ModuleMetadataItem)P_0).DebugRaw;
	}

	internal static object QLb46FhFSfe72dsBNNtK(object P_0, object P_1)
	{
		return ComponentManager.LoadAssembly((byte[])P_0, (byte[])P_1);
	}

	internal static object YPw3l3hFi7P7HSNpPqi5(object P_0, object P_1, Type entityType, object P_3, object P_4)
	{
		return ((IEntityInstanceFilterProvider)P_0).GetFilterProviderData((IEntity)P_1, entityType, (PropertyMetadata)P_3, (ViewAttributes)P_4);
	}

	internal static void hQboEahFRHf5RHBHVNJ0(object P_0, object P_1)
	{
		((ViewAttributes)P_0).EntityFilterData = (string)P_1;
	}

	internal static bool R5hRKShFq2GJxHXNnTt8(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void Ko67KDhFKwxRchufaCbi(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}
}
