using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Metadata;
using NHibernate.Proxy;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Services;

[Service(Type = ComponentType.Server)]
public class FindReferenceService
{
	[Serializable]
	public class ReferenceMap
	{
		internal static ReferenceMap knydgFC2d7MbN9Wb6ye5;

		public string ReferenceEntityName
		{
			[CompilerGenerated]
			get
			{
				return _003CReferenceEntityName_003Ek__BackingField;
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
						_003CReferenceEntityName_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public Guid ElementEntityUid
		{
			[CompilerGenerated]
			get
			{
				return _003CElementEntityUid_003Ek__BackingField;
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
						_003CElementEntityUid_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public string ElementEntityName
		{
			[CompilerGenerated]
			get
			{
				return _003CElementEntityName_003Ek__BackingField;
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
						_003CElementEntityName_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public string ElementPropertyName
		{
			[CompilerGenerated]
			get
			{
				return _003CElementPropertyName_003Ek__BackingField;
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
						_003CElementPropertyName_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
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

		public Guid ElementPropertyUid
		{
			[CompilerGenerated]
			get
			{
				return _003CElementPropertyUid_003Ek__BackingField;
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
						_003CElementPropertyUid_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
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

		public ReferenceEnum ReferenceType
		{
			[CompilerGenerated]
			get
			{
				return _003CReferenceType_003Ek__BackingField;
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
						_003CReferenceType_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
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

		public ReferenceMap()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			qtf3BkC2gBainpwcCwCs();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool vpNeveC2lMkreoV63u92()
		{
			return knydgFC2d7MbN9Wb6ye5 == null;
		}

		internal static ReferenceMap G9GAAyC2r82attabMnPT()
		{
			return knydgFC2d7MbN9Wb6ye5;
		}

		internal static void qtf3BkC2gBainpwcCwCs()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	public class Reference
	{
		private static Reference ECRGALC2543wJWORPcP5;

		public EntityMetadata EntityMetadata
		{
			[CompilerGenerated]
			get
			{
				return _003CEntityMetadata_003Ek__BackingField;
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
						_003CEntityMetadata_003Ek__BackingField = value;
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

		public PropertyMetadata PropertyMetadata
		{
			[CompilerGenerated]
			get
			{
				return _003CPropertyMetadata_003Ek__BackingField;
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
						_003CPropertyMetadata_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public ReferenceEnum ReferenceType
		{
			[CompilerGenerated]
			get
			{
				return _003CReferenceType_003Ek__BackingField;
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
						_003CReferenceType_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public Reference()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			AMsOZ2C2L30lr1IPe4ms();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool dGcbuWC2je4TxQFMa1cR()
		{
			return ECRGALC2543wJWORPcP5 == null;
		}

		internal static Reference PSTVlGC2YifT0FS9IrMm()
		{
			return ECRGALC2543wJWORPcP5;
		}

		internal static void AMsOZ2C2L30lr1IPe4ms()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	public enum ReferenceEnum
	{
		Simple,
		ManyToMany
	}

	internal interface IInstanceActor : IServerPlacementActor, IActorWithGuidKey, IActor
	{
		Task AddReferences(IEnumerable<ReferenceMap> references, IEnumerable<ReferenceMap> allReferences);
	}

	internal class InstanceActor : Actor, IInstanceActor, IServerPlacementActor, IActorWithGuidKey, IActor
	{
		private readonly ILazy<FindReferenceService> findReferenceService;

		private static InstanceActor pvOc1aCeWQatqEw2dkAY;

		public InstanceActor(ILazy<FindReferenceService> findReferenceService)
		{
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			this.findReferenceService = findReferenceService;
		}

		public Task AddReferences(IEnumerable<ReferenceMap> references, IEnumerable<ReferenceMap> allReferences)
		{
			if (findReferenceService.IsRegistered)
			{
				references?.ForEach(delegate(ReferenceMap m)
				{
					int num3 = 2;
					int num4 = num3;
					while (true)
					{
						switch (num4)
						{
						default:
							return;
						case 1:
							findReferenceService.Value.Add(findReferenceService.Value.allReferences, m);
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
							{
								num4 = 0;
							}
							break;
						case 2:
							findReferenceService.Value.Add(findReferenceService.Value.references, m);
							num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
							{
								num4 = 1;
							}
							break;
						case 0:
							return;
						}
					}
				});
				allReferences?.ForEach(delegate(ReferenceMap m)
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
							findReferenceService.Value.Add(findReferenceService.Value.allReferences, m);
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				});
			}
			return Task.CompletedTask;
		}

		internal static bool Xh7IowCeo39xxD2KCOeP()
		{
			return pvOc1aCeWQatqEw2dkAY == null;
		}

		internal static InstanceActor P6SJveCeb9u1CKaexLhS()
		{
			return pvOc1aCeWQatqEw2dkAY;
		}
	}

	private static readonly string BLOBStoreKey;

	private readonly IServerPlacementPublishService serverPlacementPublishService;

	private readonly ILazy<ITransformationProvider> transformationProvider;

	private readonly ILazy<IMetadataRuntimeService> metadataService;

	private readonly ILazy<ISessionProvider> sessionProvider;

	private readonly ConcurrentDictionary<string, ConcurrentDictionary<Guid, ReferenceMap>> references;

	private readonly ConcurrentDictionary<string, ConcurrentDictionary<Guid, ReferenceMap>> allReferences;

	private readonly IDictionary<Guid, EntityMetadata> cachedLoadedMetadata;

	internal static FindReferenceService nBDVsnb8eOYJew1IYYky;

	public FindReferenceService(IServerPlacementPublishService serverPlacementPublishService, ILazy<ITransformationProvider> transformationProvider, ILazy<IMetadataRuntimeService> metadataService, ILazy<ISessionProvider> sessionProvider)
	{
		SingletonReader.JJCZtPuTvSt();
		references = new ConcurrentDictionary<string, ConcurrentDictionary<Guid, ReferenceMap>>();
		allReferences = new ConcurrentDictionary<string, ConcurrentDictionary<Guid, ReferenceMap>>();
		cachedLoadedMetadata = new ConcurrentDictionary<Guid, EntityMetadata>();
		base._002Ector();
		this.serverPlacementPublishService = serverPlacementPublishService;
		this.transformationProvider = transformationProvider;
		this.metadataService = metadataService;
		this.sessionProvider = sessionProvider;
	}

	public void AddReference(ReferenceMap map)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				Add(allReferences, map);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				Send(new ReferenceMap[1] { map }, null);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				if (Add(references, map))
				{
					num2 = 3;
					break;
				}
				return;
			case 0:
				return;
			}
		}
	}

	public void AddToAllReference(ReferenceMap map)
	{
		//Discarded unreachable code: IL_0079, IL_0088
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				Send(null, new ReferenceMap[1] { map });
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 2:
				return;
			case 3:
				if (!Add(allReferences, map))
				{
					num2 = 2;
					break;
				}
				goto case 1;
			}
		}
	}

	public void AddReferences(IEnumerable<ReferenceMap> references, IEnumerable<ReferenceMap> allReferences)
	{
		references = references.Where(delegate(ReferenceMap m)
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return Add(this.references, m);
				case 1:
					Add(this.allReferences, m);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}).ToArray();
		allReferences = allReferences.Where((ReferenceMap m) => Add(this.allReferences, m)).ToArray();
		if (references.Any() || allReferences.Any())
		{
			Send(references, allReferences);
		}
	}

	public void AddMetadata(IEnumerable<EntityMetadata> metadatas)
	{
		List<ReferenceMap> list = new List<ReferenceMap>();
		List<ReferenceMap> list2 = new List<ReferenceMap>();
		Dictionary<Guid, ClassMetadata> dictionary = metadatas.Where(delegate(EntityMetadata m)
		{
			//Discarded unreachable code: IL_0035, IL_0044, IL_0087, IL_0096
			int num5 = 4;
			int num6 = num5;
			while (true)
			{
				switch (num6)
				{
				case 4:
					if (m == null)
					{
						num6 = 3;
						break;
					}
					goto case 1;
				case 1:
					if (_003C_003Ec.hqd9MbCeSoZfwCw6RidD(m) == EntityMetadataType.Entity)
					{
						num6 = 2;
						break;
					}
					goto default;
				default:
					return _003C_003Ec.hqd9MbCeSoZfwCw6RidD(m) == EntityMetadataType.InterfaceImplementation;
				case 2:
					return true;
				case 3:
					return false;
				}
			}
		}).ToDictionary((Func<EntityMetadata, Guid>)((EntityMetadata m) => _003C_003Ec.xTF0rECeibTO6kOQrmcX(m)), (Func<EntityMetadata, ClassMetadata>)((EntityMetadata m) => m));
		foreach (ClassMetadata value4 in dictionary.Values)
		{
			using IEnumerator<PropertyMetadata> enumerator2 = value4.Properties.Where(delegate(PropertyMetadata p)
			{
				int num3 = 1;
				int num4 = num3;
				while (true)
				{
					switch (num4)
					{
					case 1:
						if (!(_003C_003Ec.GhQXxrCeRh4R6LYawUUG(p) is EntitySettings))
						{
							return false;
						}
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
						{
							num4 = 0;
						}
						break;
					default:
						return _003C_003Ec.TjxxAUCeKgrxlfmyjZRV(_003C_003Ec.wivj3QCeqvRvdd4nAqvX(p), Guid.Empty);
					}
				}
			}).GetEnumerator();
			while (enumerator2.MoveNext())
			{
				_003C_003Ec__DisplayClass15_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass15_0();
				CS_0024_003C_003E8__locals0.prop = enumerator2.Current;
				ConcurrentDictionary<Guid, ReferenceMap> value2;
				switch (((EntitySettings)CS_0024_003C_003E8__locals0.prop.Settings).RelationType)
				{
				case RelationType.OneToOne:
				{
					if (!dictionary.TryGetValue(CS_0024_003C_003E8__locals0.prop.SubTypeUid, out var value3))
					{
						value3 = (ClassMetadata)MetadataServiceContext.Service.GetMetadata(CS_0024_003C_003E8__locals0.prop.SubTypeUid);
					}
					if (value3 == null)
					{
						break;
					}
					if (value3.Properties.Any(delegate(PropertyMetadata p)
					{
						int num = 1;
						int num2 = num;
						EntitySettings entitySettings = default(EntitySettings);
						while (true)
						{
							switch (num2)
							{
							default:
								if (_003C_003Ec__DisplayClass15_0.anKd3bCeQBWDaGfvSKJk(entitySettings) == RelationType.OneToMany)
								{
									num2 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
									{
										num2 = 0;
									}
									continue;
								}
								break;
							case 1:
								if ((entitySettings = p.Settings as EntitySettings) != null)
								{
									num2 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
									{
										num2 = 0;
									}
									continue;
								}
								break;
							case 2:
								return _003C_003Ec__DisplayClass15_0.gN0atuCe8gFEdRa6111S(_003C_003Ec__DisplayClass15_0.ohhWQ0CeCBdbJhGoHCKw(entitySettings), _003C_003Ec__DisplayClass15_0.EFvBU1Cevnbhd7RPCV5j(CS_0024_003C_003E8__locals0.prop));
							}
							break;
						}
						return false;
					}))
					{
						if (!allReferences.TryGetValue(value4.FullTypeName, out value2) || !value2.ContainsKey(CS_0024_003C_003E8__locals0.prop.Uid))
						{
							list2.Add(new ReferenceMap
							{
								ElementEntityUid = value4.Uid,
								ElementEntityName = value4.FullTypeName,
								ElementPropertyName = CS_0024_003C_003E8__locals0.prop.Name,
								ElementPropertyUid = CS_0024_003C_003E8__locals0.prop.Uid,
								ReferenceEntityName = value3.FullTypeName,
								ReferenceType = ReferenceEnum.Simple
							});
						}
					}
					else if (!references.TryGetValue(value4.FullTypeName, out value2) || !value2.ContainsKey(CS_0024_003C_003E8__locals0.prop.Uid))
					{
						list.Add(new ReferenceMap
						{
							ElementEntityUid = value4.Uid,
							ElementEntityName = value4.FullTypeName,
							ElementPropertyName = CS_0024_003C_003E8__locals0.prop.Name,
							ElementPropertyUid = CS_0024_003C_003E8__locals0.prop.Uid,
							ReferenceEntityName = value3.FullTypeName,
							ReferenceType = ReferenceEnum.Simple
						});
					}
					break;
				}
				case RelationType.ManyToMany:
				{
					if (!dictionary.TryGetValue(CS_0024_003C_003E8__locals0.prop.SubTypeUid, out var value))
					{
						value = (ClassMetadata)MetadataServiceContext.Service.GetMetadata(CS_0024_003C_003E8__locals0.prop.SubTypeUid);
					}
					if (value is EntityMetadata && (!references.TryGetValue(value4.FullTypeName, out value2) || !value2.ContainsKey(CS_0024_003C_003E8__locals0.prop.Uid)))
					{
						list.Add(new ReferenceMap
						{
							ElementEntityUid = value4.Uid,
							ElementEntityName = value4.FullTypeName,
							ElementPropertyName = CS_0024_003C_003E8__locals0.prop.Name,
							ElementPropertyUid = CS_0024_003C_003E8__locals0.prop.Uid,
							ReferenceEntityName = value.FullTypeName,
							ReferenceType = ReferenceEnum.ManyToMany
						});
					}
					break;
				}
				}
			}
		}
		AddReferences(list, list2);
	}

	public ICollection<Reference> GetReferences(string entityName, bool all = false)
	{
		_003C_003Ec__DisplayClass16_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass16_0();
		if (!(all ? allReferences : references).TryGetValue(entityName, out var value))
		{
			return Array.Empty<Reference>();
		}
		CS_0024_003C_003E8__locals0.loadedMetadata = new Dictionary<Guid, EntityMetadata>();
		HashSet<Guid> hashSet = new HashSet<Guid>();
		foreach (Guid item in value.Values.Select((ReferenceMap m) => m.ElementEntityUid).Distinct())
		{
			EntityMetadata value2 = (EntityMetadata)MetadataLoader.LoadMetadataOrNull(item, inherit: false, loadImplementation: false);
			if (value2 != null)
			{
				CS_0024_003C_003E8__locals0.loadedMetadata[item] = value2;
				cachedLoadedMetadata.Remove(item);
			}
			else if (cachedLoadedMetadata.TryGetValue(item, out value2))
			{
				CS_0024_003C_003E8__locals0.loadedMetadata[item] = value2;
			}
			else
			{
				hashSet.Add(item);
			}
		}
		if (hashSet.Count > 0)
		{
			foreach (EntityMetadata item2 in sessionProvider.Value.GetSession(string.Empty).CreateCriteria<EntityMetadata>().Add((ICriterion)(object)Restrictions.In(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138932118), (ICollection)hashSet.ToArray()))
				.List<EntityMetadata>())
			{
				EntityMetadata entityMetadata = ClassSerializationHelper.CloneObjectByXml(item2);
				entityMetadata.Properties.AddRange((IEnumerable<PropertyMetadata>)entityMetadata.EntityProperties);
				((ICollection<EntityPropertyMetadata>)entityMetadata.EntityProperties).Clear();
				entityMetadata.TableParts.AddRange((IEnumerable<TablePartMetadata>)entityMetadata.EntityTableParts);
				((ICollection<TablePartMetadata>)entityMetadata.EntityTableParts).Clear();
				CS_0024_003C_003E8__locals0.loadedMetadata[entityMetadata.Uid] = entityMetadata;
				cachedLoadedMetadata[entityMetadata.Uid] = entityMetadata;
			}
		}
		return value.Values.Select(delegate(ReferenceMap m)
		{
			int num = 2;
			int num2 = num;
			EntityMetadata entityMetadata2 = default(EntityMetadata);
			PropertyMetadata propertyMetadata = default(PropertyMetadata);
			_003C_003Ec__DisplayClass16_1 _003C_003Ec__DisplayClass16_ = default(_003C_003Ec__DisplayClass16_1);
			while (true)
			{
				switch (num2)
				{
				case 3:
				{
					Reference reference = new Reference();
					_003C_003Ec__DisplayClass16_0.uviOHUCe2sfDkBi20wnN(reference, entityMetadata2);
					_003C_003Ec__DisplayClass16_0.uiaX5tCeejRcdMZFSYr9(reference, propertyMetadata);
					_003C_003Ec__DisplayClass16_0.wlc0nBCe1xcHBWMypDE2(reference, _003C_003Ec__DisplayClass16_0.ltaqGqCePrKcPeBwLkck(_003C_003Ec__DisplayClass16_.m));
					return reference;
				}
				case 4:
					entityMetadata2 = CS_0024_003C_003E8__locals0.loadedMetadata[_003C_003Ec__DisplayClass16_0.zCMCXTCeOZwITRBFaWUa(_003C_003Ec__DisplayClass16_.m)];
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					_003C_003Ec__DisplayClass16_ = new _003C_003Ec__DisplayClass16_1();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
					{
						num2 = 1;
					}
					break;
				default:
					propertyMetadata = entityMetadata2.Properties.FirstOrDefault(_003C_003Ec__DisplayClass16_._003CGetReferences_003Eb__2);
					num2 = 3;
					break;
				case 1:
					_003C_003Ec__DisplayClass16_.m = m;
					num2 = 4;
					break;
				}
			}
		}).ToArray();
	}

	public void DeleteEntityReferences(IEntity entity)
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
				DeleteEntityReferences(entity, null, null);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public void DeleteEntityReferences(IEntity entity, string entityName, ISession session)
	{
		//Discarded unreachable code: IL_008e, IL_00b9, IL_0151, IL_0195, IL_01a4, IL_01b5, IL_01c4, IL_0359, IL_0368, IL_0378, IL_03db, IL_0456, IL_0465, IL_049c, IL_04ce, IL_04e5, IL_04f4, IL_057f, IL_05db, IL_063c, IL_0701, IL_0733, IL_074a, IL_07d4, IL_07f3, IL_0802, IL_082f, IL_083e, IL_0871
		int num = 2;
		List<string> list = default(List<string>);
		IClassMetadata val = default(IClassMetadata);
		IEnumerator<Reference> enumerator = default(IEnumerator<Reference>);
		Type type = default(Type);
		EntitySettings entitySettings = default(EntitySettings);
		EntityPropertyMetadata entityPropertyMetadata = default(EntityPropertyMetadata);
		Type typeByUid = default(Type);
		Reference current = default(Reference);
		object obj3 = default(object);
		string text4 = default(string);
		string text3 = default(string);
		object id = default(object);
		string text = default(string);
		Guid typeUid = default(Guid);
		string text2 = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 2:
					if (entity != null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					return;
				default:
					obj = null;
					goto IL_08e6;
				case 18:
					list = new List<string>();
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
					{
						num2 = 3;
					}
					continue;
				case 12:
					if (val != null)
					{
						num2 = 15;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto default;
				case 8:
					enumerator = list.SelectMany((string en) => GetReferences(en)).GetEnumerator();
					num = 6;
					break;
				case 4:
				case 7:
				case 9:
					if (!AmESMwb8tv8VKoJBE9lO(type, null))
					{
						num2 = 8;
						continue;
					}
					goto case 14;
				case 10:
					return;
				case 1:
					if (session == null)
					{
						num2 = 5;
						continue;
					}
					goto case 18;
				case 11:
					val = (IClassMetadata)iiA9Obb8aUGU0yRySGFX(AER7KAb8pKDOMmHF49lO(session), entityName);
					num2 = 12;
					continue;
				case 5:
					session = sessionProvider.Value.GetSession("");
					num2 = 16;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
					{
						num2 = 18;
					}
					continue;
				case 6:
					try
					{
						while (true)
						{
							int num4;
							if (!W9JKYAb8gnL3IE32BQrt(enumerator))
							{
								int num3 = 10;
								num4 = num3;
								goto IL_01d3;
							}
							goto IL_02dd;
							IL_01d3:
							while (true)
							{
								Guid guid;
								object obj2;
								object obj4;
								switch (num4)
								{
								case 22:
									if (entitySettings.RelationType != 0)
									{
										num4 = 5;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
										{
											num4 = 5;
										}
										continue;
									}
									goto case 1;
								case 7:
								case 8:
									break;
								case 2:
									if (entityPropertyMetadata != null)
									{
										num4 = 11;
										continue;
									}
									goto case 26;
								case 15:
									typeByUid = metadataService.Value.GetTypeByUid(qEVDH3b8yd4ejvt6NHLB(ywArutb8m4nUfxonf5lJ(current)));
									num4 = 9;
									continue;
								default:
									obj3 = xe9dE1b8d8Usi4hby8Kp(entity);
									num4 = 4;
									continue;
								case 18:
									goto IL_02dd;
								case 25:
									text4 = string.Format((string)wxE3pBb86726BAQS1KJr(-1217523399 ^ -1217616711), p3u35ib8AHCO9yKusU8M(BVjrtRb8HIQk6mlXfbXU(transformationProvider.Value), text3), p3u35ib8AHCO9yKusU8M(BVjrtRb8HIQk6mlXfbXU(transformationProvider.Value), entitySettings.FieldName));
									num4 = 23;
									continue;
								case 13:
									if (entitySettings.RelationType == RelationType.ManyToMany)
									{
										num4 = 6;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
										{
											num4 = 12;
										}
										continue;
									}
									break;
								case 16:
									if (entitySettings != null)
									{
										num4 = 22;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
										{
											num4 = 22;
										}
										continue;
									}
									goto case 5;
								case 26:
									guid = current.EntityMetadata.Uid;
									goto IL_07a2;
								case 23:
									id = entity.GetId();
									num4 = 3;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
									{
										num4 = 1;
									}
									continue;
								case 19:
									text = metadataService.Value.GetTypeByUid(current.EntityMetadata.Uid).FullName + (string)wxE3pBb86726BAQS1KJr(-882126494 ^ -882127962) + (string)iATTWUb8rxy9X2B9tnvM(S3piZmb8wWMddlGyuUi9(current));
									num4 = 14;
									continue;
								case 9:
									try
									{
										session.CleanUpCache(typeByUid);
										int num7 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
										{
											num7 = 0;
										}
										switch (num7)
										{
										case 0:
											break;
										}
									}
									catch (MappingException)
									{
										int num8 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
										{
											num8 = 0;
										}
										switch (num8)
										{
										case 0:
											break;
										}
									}
									break;
								case 5:
								case 28:
									if (entitySettings == null)
									{
										num4 = 2;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
										{
											num4 = 8;
										}
										continue;
									}
									goto case 13;
								case 21:
									session.CleanUpCache(ModelHelper.GetEntityType(typeUid));
									num4 = 15;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
									{
										num4 = 0;
									}
									continue;
								case 1:
									entityPropertyMetadata = current.PropertyMetadata as EntityPropertyMetadata;
									num4 = 15;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
									{
										num4 = 24;
									}
									continue;
								case 27:
									obj2 = null;
									goto IL_0765;
								case 3:
									((IQuery)aBdahYb8xuK2dphXa4ka(bxJnSyb87qfSUBXa8E2l(session, text4), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7E6E5A0B ^ 0x7E6CEFE9), id)).ExecuteUpdate(cleanUpCache: false);
									num4 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
									{
										num4 = 2;
									}
									continue;
								case 20:
									obj4 = jWk4sgb845FF5re5ZiXx(current.EntityMetadata);
									goto IL_078f;
								case 24:
									if (entityPropertyMetadata == null)
									{
										num4 = 20;
										continue;
									}
									obj4 = entityPropertyMetadata.GetTableName(current.EntityMetadata);
									goto IL_078f;
								case 4:
									dRsabQb8lhw39ZAbmH5j(aBdahYb8xuK2dphXa4ka(session.CreateSQLQuery(text2), wxE3pBb86726BAQS1KJr(-1426094279 ^ -1426246949), obj3), false);
									num4 = 10;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
									{
										num4 = 19;
									}
									continue;
								case 17:
									if (current.PropertyMetadata != null)
									{
										num4 = 6;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
										{
											num4 = 2;
										}
										continue;
									}
									goto case 27;
								case 12:
									text2 = (string)lcNyIob89rB2jQ37tTZq(wxE3pBb86726BAQS1KJr(-2107978722 ^ -2108130840), p3u35ib8AHCO9yKusU8M(BVjrtRb8HIQk6mlXfbXU(transformationProvider.Value), T41KqOb8M8MOqnCdlVPr(entitySettings)), p3u35ib8AHCO9yKusU8M(BVjrtRb8HIQk6mlXfbXU(transformationProvider.Value), JTAN0Pb8JFLK5lkMGHpn(entitySettings)));
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
									{
										num4 = 0;
									}
									continue;
								case 14:
									try
									{
										session.CleanUpCollectionsCache(text);
										int num5 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
										{
											num5 = 0;
										}
										switch (num5)
										{
										case 0:
											break;
										}
									}
									catch (MappingException)
									{
										int num6 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
										{
											num6 = 0;
										}
										switch (num6)
										{
										case 0:
											break;
										}
									}
									break;
								case 6:
									obj2 = ((PropertyMetadata)S3piZmb8wWMddlGyuUi9(current)).Settings as EntitySettings;
									goto IL_0765;
								case 11:
									guid = LltYN8b80cJnNjdve7Dd(entityPropertyMetadata);
									goto IL_07a2;
								case 10:
									return;
									IL_078f:
									text3 = (string)obj4;
									num4 = 25;
									continue;
									IL_07a2:
									typeUid = guid;
									num4 = 21;
									continue;
									IL_0765:
									entitySettings = (EntitySettings)obj2;
									num4 = 3;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
									{
										num4 = 16;
									}
									continue;
								}
								break;
							}
							continue;
							IL_02dd:
							current = enumerator.Current;
							num4 = 17;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
							{
								num4 = 16;
							}
							goto IL_01d3;
						}
					}
					finally
					{
						int num9;
						if (enumerator == null)
						{
							num9 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
							{
								num9 = 0;
							}
							goto IL_07d8;
						}
						goto IL_080d;
						IL_080d:
						enumerator.Dispose();
						num9 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
						{
							num9 = 1;
						}
						goto IL_07d8;
						IL_07d8:
						switch (num9)
						{
						default:
							goto end_IL_07b3;
						case 0:
							goto end_IL_07b3;
						case 2:
							break;
						case 1:
							goto end_IL_07b3;
						}
						goto IL_080d;
						end_IL_07b3:;
					}
				case 17:
					type = wI9QDwb83ZNJKOkMPP0G(entity);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
					{
						num2 = 7;
					}
					continue;
				case 13:
					return;
				case 3:
					if (i0ga54b8N9CS22JYWgBA(entityName))
					{
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
						{
							num2 = 17;
						}
						continue;
					}
					goto case 11;
				case 14:
					list.Add(type.FullName);
					num = 16;
					break;
				case 16:
					type = type.BaseType;
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
					{
						num2 = 2;
					}
					continue;
				case 15:
					{
						obj = SMh3Erb8DdY8YmR3Nw94(val);
						goto IL_08e6;
					}
					IL_08e6:
					type = (Type)obj;
					num2 = 9;
					continue;
				}
				break;
			}
		}
	}

	private bool Add(ConcurrentDictionary<string, ConcurrentDictionary<Guid, ReferenceMap>> references, ReferenceMap map)
	{
		if (references.GetOrAdd(map.ReferenceEntityName, (string _) => new ConcurrentDictionary<Guid, ReferenceMap>()).TryAdd(map.ElementPropertyUid, map))
		{
			cachedLoadedMetadata.Remove(map.ElementEntityUid);
			return true;
		}
		return false;
	}

	private void Send(IEnumerable<ReferenceMap> references, IEnumerable<ReferenceMap> allReferences)
	{
		_003C_003Ec__DisplayClass20_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass20_0();
		CS_0024_003C_003E8__locals0.references = references;
		CS_0024_003C_003E8__locals0.allReferences = allReferences;
		serverPlacementPublishService.For<IInstanceActor>().Publish((IInstanceActor a) => a.AddReferences(CS_0024_003C_003E8__locals0.references, CS_0024_003C_003E8__locals0.allReferences));
	}

	static FindReferenceService()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			default:
				BLOBStoreKey = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740433008);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				SingletonReader.JJCZtPuTvSt();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool P1qUMcb8Pj6hGB81u1Lp()
	{
		return nBDVsnb8eOYJew1IYYky == null;
	}

	internal static FindReferenceService NgaXXtb81y4U3ZRGgWMw()
	{
		return nBDVsnb8eOYJew1IYYky;
	}

	internal static bool i0ga54b8N9CS22JYWgBA(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static Type wI9QDwb83ZNJKOkMPP0G(object P_0)
	{
		return NHibernateProxyHelper.GuessClass(P_0);
	}

	internal static object AER7KAb8pKDOMmHF49lO(object P_0)
	{
		return ((ISession)P_0).get_SessionFactory();
	}

	internal static object iiA9Obb8aUGU0yRySGFX(object P_0, object P_1)
	{
		return ((ISessionFactory)P_0).GetClassMetadata((string)P_1);
	}

	internal static Type SMh3Erb8DdY8YmR3Nw94(object P_0)
	{
		return ((IClassMetadata)P_0).get_MappedClass();
	}

	internal static bool AmESMwb8tv8VKoJBE9lO(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static object S3piZmb8wWMddlGyuUi9(object P_0)
	{
		return ((Reference)P_0).PropertyMetadata;
	}

	internal static object jWk4sgb845FF5re5ZiXx(object P_0)
	{
		return ((EntityMetadata)P_0).TableName;
	}

	internal static object wxE3pBb86726BAQS1KJr(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object BVjrtRb8HIQk6mlXfbXU(object P_0)
	{
		return ((ITransformationProvider)P_0).Dialect;
	}

	internal static object p3u35ib8AHCO9yKusU8M(object P_0, object P_1)
	{
		return ((Dialect)P_0).QuoteIfNeeded((string)P_1);
	}

	internal static object bxJnSyb87qfSUBXa8E2l(object P_0, object P_1)
	{
		return ((ISession)P_0).CreateSQLQuery((string)P_1);
	}

	internal static object aBdahYb8xuK2dphXa4ka(object P_0, object P_1, object P_2)
	{
		return ((IQuery)P_0).SetParameter((string)P_1, P_2);
	}

	internal static Guid LltYN8b80cJnNjdve7Dd(object P_0)
	{
		return ((PropertyMetadata)P_0).SubTypeUid;
	}

	internal static object ywArutb8m4nUfxonf5lJ(object P_0)
	{
		return ((Reference)P_0).EntityMetadata;
	}

	internal static Guid qEVDH3b8yd4ejvt6NHLB(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static object T41KqOb8M8MOqnCdlVPr(object P_0)
	{
		return ((EntitySettings)P_0).RelationTableName;
	}

	internal static object JTAN0Pb8JFLK5lkMGHpn(object P_0)
	{
		return ((EntitySettings)P_0).ChildColumnName;
	}

	internal static object lcNyIob89rB2jQ37tTZq(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static object xe9dE1b8d8Usi4hby8Kp(object P_0)
	{
		return ((IIdentified)P_0).GetId();
	}

	internal static int dRsabQb8lhw39ZAbmH5j(object P_0, bool cleanUpCache)
	{
		return ((IQuery)P_0).ExecuteUpdate(cleanUpCache);
	}

	internal static object iATTWUb8rxy9X2B9tnvM(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static bool W9JKYAb8gnL3IE32BQrt(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}
}
