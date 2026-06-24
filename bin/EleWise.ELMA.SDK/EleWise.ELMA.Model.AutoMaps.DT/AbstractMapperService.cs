using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.Collections;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.DataClasses;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Services;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.AutoMaps.DTOMapper.Internal;

internal abstract class AbstractMapperService : IMapperService, IInternalMapperService
{
	protected ICollection<IInternalMapperConfiguration> mappers;

	internal readonly ConcurrentDictionary<Guid, IInternalMapperConfiguration> mappersByUidCache;

	internal readonly ConcurrentDictionary<(Type, Guid), ISet<IInternalMapperConfiguration>> mappersByTypeAndUidCache;

	internal readonly ConcurrentDictionary<string, ISet<IInternalMapperConfiguration>> mappersByTypeRef;

	internal readonly ConcurrentDictionary<Guid, ModuleVersion[]> PublishedModules;

	private static readonly Type defaultMapperType;

	private static DataClassDescriptor dataClassDescriptor;

	private readonly IModuleMetadataLoader moduleMetadataLoader;

	private static AbstractMapperService biDP2XhxejTRU9NWL0vI;

	private static DataClassDescriptor DataClassDescriptor
	{
		get
		{
			int num = 1;
			int num2 = num;
			DataClassDescriptor obj;
			while (true)
			{
				switch (num2)
				{
				case 1:
					obj = dataClassDescriptor;
					if (obj != null)
					{
						break;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					obj = (dataClassDescriptor = Locator.GetServiceNotNull<DataClassDescriptor>());
					break;
				}
				break;
			}
			return obj;
		}
	}

	protected abstract void Init();

	public TDestination Map<TDestination>(object source) where TDestination : class
	{
		return Map(typeof(TDestination), source).As<TDestination>();
	}

	public TDestination Map<TSource, TDestination>(TSource source) where TSource : class where TDestination : class
	{
		return Map<TDestination>(source);
	}

	public TDestination Map<TSource, TDestination>(TSource source, TDestination destination) where TSource : class where TDestination : class
	{
		return Map(TypeOf<TDestination>.Raw, source, destination).As<TDestination>();
	}

	private object Map(Type destinationType, object source, object destination = null)
	{
		//Discarded unreachable code: IL_00db, IL_0180
		int num = 8;
		int num2 = num;
		IInternalMapperConfiguration mapper2 = default(IInternalMapperConfiguration);
		DataClass dataClass = default(DataClass);
		IInternalMapperConfiguration mapper = default(IInternalMapperConfiguration);
		object obj3 = default(object);
		Guid metadataUid = default(Guid);
		while (true)
		{
			object obj2;
			Guid guid;
			object obj;
			switch (num2)
			{
			case 15:
				G1uQErhxaVWb807gtRvt(mapper2, dataClass, destination, this);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
				{
					num2 = 0;
				}
				continue;
			case 1:
				return destination;
			case 12:
				if ((object)(dataClass = source as DataClass) == null)
				{
					num2 = 11;
					continue;
				}
				goto case 10;
			case 2:
				if (destination == null)
				{
					num2 = 14;
					continue;
				}
				obj2 = hETGUHhxpkYkETPOWCDy(destination);
				goto IL_019d;
			case 8:
				if (source == null)
				{
					num2 = 7;
					continue;
				}
				J8jeRKhxNLhTT5ALmUmY(this);
				num2 = 12;
				continue;
			case 3:
				mapper = GetMapper(obj3.GetType(), metadataUid);
				num2 = 5;
				continue;
			case 7:
				return null;
			case 10:
				mapper2 = GetMapper(dataClass, destinationType);
				num2 = 2;
				continue;
			case 13:
				oOfoyYhxDJI6DxKudEdq(mapper, obj3, (DataClass)destination, this);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
				{
					num2 = 1;
				}
				continue;
			case 9:
				obj3 = hETGUHhxpkYkETPOWCDy(source);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
				{
					num2 = 3;
				}
				continue;
			default:
				return destination;
			case 11:
			{
				UidAttribute attribute = AttributeHelper<UidAttribute>.GetAttribute(destinationType, inherited: true);
				if (attribute == null)
				{
					num2 = 6;
					continue;
				}
				guid = attribute.Uid;
				goto IL_01b8;
			}
			case 14:
				obj2 = qd0R9Fhx36hR7CctRgAq(mapper2, dataClass);
				goto IL_019d;
			case 5:
				obj = destination;
				if (obj == null)
				{
					num2 = 4;
					continue;
				}
				break;
			case 6:
				guid = Guid.Empty;
				goto IL_01b8;
			case 4:
				{
					obj = mapper.CreateDestinationInstance();
					break;
				}
				IL_01b8:
				metadataUid = guid;
				num2 = 9;
				continue;
				IL_019d:
				destination = obj2;
				num2 = 15;
				continue;
			}
			destination = obj;
			num2 = 13;
		}
	}

	protected AbstractMapperService(IModuleMetadataLoader moduleMetadataLoader)
	{
		//Discarded unreachable code: IL_007a, IL_007f
		mnGol7hxtxcupJqLb71D();
		mappers = new MappersCollection();
		mappersByUidCache = new ConcurrentDictionary<Guid, IInternalMapperConfiguration>();
		mappersByTypeAndUidCache = new ConcurrentDictionary<(Type, Guid), ISet<IInternalMapperConfiguration>>();
		mappersByTypeRef = new ConcurrentDictionary<string, ISet<IInternalMapperConfiguration>>();
		PublishedModules = new ConcurrentDictionary<Guid, ModuleVersion[]>();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
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
				this.moduleMetadataLoader = moduleMetadataLoader;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public IInternalMapperConfiguration GetMapper(Type declaredSourceType, Guid metadataUid)
	{
		int num = 1;
		int num2 = num;
		IInternalMapperConfiguration mapperInternal = default(IInternalMapperConfiguration);
		while (true)
		{
			switch (num2)
			{
			default:
				return mapperInternal;
			case 1:
			{
				ISet<IInternalMapperConfiguration> orAdd = mappersByTypeAndUidCache.GetOrAdd((declaredSourceType, metadataUid), ((Type, Guid) tuple) => new ConcurrentHashSet<IInternalMapperConfiguration>());
				mapperInternal = GetMapperInternal(declaredSourceType, metadataUid);
				orAdd.Add(mapperInternal);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
				{
					num2 = 0;
				}
				break;
			}
			}
		}
	}

	public IInternalMapperConfiguration GetMapper(Guid metadataUid)
	{
		return mappersByUidCache.GetOrAdd(metadataUid, delegate(Guid mdUid)
		{
			int num = 3;
			int num2 = num;
			_003C_003Ec__DisplayClass17_0 _003C_003Ec__DisplayClass17_ = default(_003C_003Ec__DisplayClass17_0);
			DataClassMetadata metadataByUid = default(DataClassMetadata);
			while (true)
			{
				switch (num2)
				{
				default:
					_003C_003Ec__DisplayClass17_.typeRef = (string)comIxuhx03u2gGKPBgkm(metadataByUid);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					metadataByUid = ((DataClassDescriptor)eam8wohxx4RWqR79Duye()).GetMetadataByUid(mdUid);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					_003C_003Ec__DisplayClass17_ = new _003C_003Ec__DisplayClass17_0();
					num2 = 2;
					break;
				case 1:
					return mappers.FirstOrDefault(_003C_003Ec__DisplayClass17_._003CGetMapper_003Eb__1);
				}
			}
		});
	}

	public IInternalMapperConfiguration GetMapper(DataClass dataClass, Type declaredSourceType)
	{
		int num = 1;
		int num2 = num;
		string dataClassTypeRef = default(string);
		while (true)
		{
			switch (num2)
			{
			case 1:
				dataClassTypeRef = (string)OuHKVmhxwUui1DoYb2My(dataClass);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return GetMapper(dataClassTypeRef, declaredSourceType);
			}
		}
	}

	private IInternalMapperConfiguration GetMapperInternal(Type declaredType, Guid mdUid)
	{
		//Discarded unreachable code: IL_00de, IL_00ed, IL_010d, IL_011c, IL_02b9, IL_0384, IL_0393
		int num = 10;
		IInternalMapperConfiguration internalMapperConfiguration = default(IInternalMapperConfiguration);
		_003C_003Ec__DisplayClass19_1 _003C_003Ec__DisplayClass19_ = default(_003C_003Ec__DisplayClass19_1);
		_003C_003Ec__DisplayClass19_0 _003C_003Ec__DisplayClass19_2 = default(_003C_003Ec__DisplayClass19_0);
		string text = default(string);
		EntityMetadata entityMetadata = default(EntityMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 29:
					internalMapperConfiguration = mappers.FirstOrDefault(_003C_003Ec__DisplayClass19_._003CGetMapperInternal_003Eb__2);
					num2 = 21;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
					{
						num2 = 2;
					}
					continue;
				case 26:
					_003C_003Ec__DisplayClass19_ = new _003C_003Ec__DisplayClass19_1();
					num2 = 4;
					continue;
				case 7:
					if (internalMapperConfiguration != null)
					{
						num2 = 11;
						continue;
					}
					_003C_003Ec__DisplayClass19_2.baseType = _003C_003Ec__DisplayClass19_2.declaredType.BaseType;
					num = 20;
					break;
				case 9:
					_003C_003Ec__DisplayClass19_2.declaredType = declaredType;
					num2 = 23;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
					{
						num2 = 24;
					}
					continue;
				case 1:
				case 6:
					if (!jNWCmjhx7FCNqKMEJwOx(_003C_003Ec__DisplayClass19_2.baseType, TypeOf<object>.Raw))
					{
						num2 = 14;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
						{
							num2 = 7;
						}
						continue;
					}
					goto case 28;
				case 27:
					if (adVWpqhxAOrNIjpuDQfh(_003C_003Ec__DisplayClass19_.type, null))
					{
						num2 = 29;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
						{
							num2 = 21;
						}
						continue;
					}
					goto case 12;
				case 23:
					return internalMapperConfiguration;
				case 8:
					if (!TypeOf<IEntity>.Raw.IsAssignableFrom(_003C_003Ec__DisplayClass19_2.declaredType))
					{
						num2 = 12;
						continue;
					}
					goto case 22;
				case 11:
					return internalMapperConfiguration;
				case 10:
					_003C_003Ec__DisplayClass19_2 = new _003C_003Ec__DisplayClass19_0();
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
					{
						num2 = 0;
					}
					continue;
				case 18:
					if (internalMapperConfiguration != null)
					{
						num2 = 13;
						continue;
					}
					_003C_003Ec__DisplayClass19_2.baseType = _003C_003Ec__DisplayClass19_2.baseType.BaseType;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
					{
						num2 = 1;
					}
					continue;
				case 13:
					return internalMapperConfiguration;
				case 14:
					internalMapperConfiguration = mappers.FirstOrDefault(_003C_003Ec__DisplayClass19_2._003CGetMapperInternal_003Eb__1);
					num2 = 17;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
					{
						num2 = 16;
					}
					continue;
				case 16:
					if (internalMapperConfiguration == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
						{
							num2 = 8;
						}
						continue;
					}
					goto case 23;
				case 21:
					if (internalMapperConfiguration != null)
					{
						num2 = 19;
						continue;
					}
					goto case 12;
				case 19:
					return internalMapperConfiguration;
				case 12:
				case 25:
					internalMapperConfiguration = TryFindMapperByType(_003C_003Ec__DisplayClass19_2.declaredType);
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
					{
						num2 = 6;
					}
					continue;
				case 17:
					if (internalMapperConfiguration != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
						{
							num2 = 0;
						}
						continue;
					}
					internalMapperConfiguration = TryFindMapperByType(_003C_003Ec__DisplayClass19_2.baseType);
					num2 = 18;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num2 = 3;
					}
					continue;
				case 3:
					mappers.Add(internalMapperConfiguration);
					num2 = 15;
					continue;
				case 28:
					text = (string)comIxuhx03u2gGKPBgkm(((DataClassDescriptor)eam8wohxx4RWqR79Duye()).GetMetadataByUid(mdUid));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
					{
						num2 = 5;
					}
					continue;
				default:
					return internalMapperConfiguration;
				case 24:
					internalMapperConfiguration = mappers.FirstOrDefault(_003C_003Ec__DisplayClass19_2._003CGetMapperInternal_003Eb__0);
					num2 = 16;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
					{
						num2 = 16;
					}
					continue;
				case 5:
					internalMapperConfiguration = (IInternalMapperConfiguration)mY3BVuhxm59bIlexahex(_003C_003Ec__DisplayClass19_2.declaredType, text);
					num = 3;
					break;
				case 22:
					if ((entityMetadata = MetadataLoader.LoadMetadata(_003C_003Ec__DisplayClass19_2.declaredType) as EntityMetadata) == null)
					{
						num2 = 25;
						continue;
					}
					goto case 26;
				case 2:
				case 20:
					if (adVWpqhxAOrNIjpuDQfh(_003C_003Ec__DisplayClass19_2.baseType, null))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 28;
				case 15:
					return internalMapperConfiguration;
				case 4:
					_003C_003Ec__DisplayClass19_.type = ((IMetadataRuntimeService)yG658Hhx4tTuDuHVOCji()).GetTypeByUidOrNull((AJlipJhx6wbklACOF3nl(entityMetadata) == EntityMetadataType.InterfaceImplementation) ? entityMetadata.ImplementationUid : hoWhVwhxHTZtyXRPadZD(entityMetadata), loadImplementation: false);
					num2 = 27;
					continue;
				}
				break;
			}
		}
	}

	private IInternalMapperConfiguration TryFindMapperByType(Type sourceType)
	{
		//Discarded unreachable code: IL_00df, IL_0166
		int num = 8;
		int num2 = num;
		int num3 = default(int);
		ModuleVersion[] orAdd = default(ModuleVersion[]);
		_003C_003Ec__DisplayClass20_0 _003C_003Ec__DisplayClass20_ = default(_003C_003Ec__DisplayClass20_0);
		string text = default(string);
		IInternalMapperConfiguration internalMapperConfiguration = default(IInternalMapperConfiguration);
		string fullName = default(string);
		DataClassMetadata dataClassMetadata = default(DataClassMetadata);
		while (true)
		{
			switch (num2)
			{
			case 5:
			case 16:
				if (num3 < orAdd.Length)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 15:
				num3 = 0;
				num2 = 16;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
				{
					num2 = 16;
				}
				break;
			case 11:
				return null;
			case 3:
				if (mappers.FirstOrDefault(_003C_003Ec__DisplayClass20_._003CTryFindMapperByType_003Eb__0) == null)
				{
					text = (string)sZ1L81hxMfRiGxrFK0vq(LdUA2MhxyBJleThyfpsH(_003C_003Ec__DisplayClass20_.sourceType.Assembly));
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
					{
						num2 = 9;
					}
				}
				else
				{
					num2 = 11;
				}
				break;
			case 17:
				mappers.Add(internalMapperConfiguration);
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
				{
					num2 = 5;
				}
				break;
			default:
				_003C_003Ec__DisplayClass20_.typeToMap = (string)Nda9dahxJaPy5t0xDPI8(fullName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487385500), text);
				num2 = 9;
				break;
			case 6:
				return internalMapperConfiguration;
			case 14:
				internalMapperConfiguration = (IInternalMapperConfiguration)mY3BVuhxm59bIlexahex(_003C_003Ec__DisplayClass20_.sourceType, comIxuhx03u2gGKPBgkm(dataClassMetadata));
				num2 = 17;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
				{
					num2 = 0;
				}
				break;
			case 9:
				orAdd = PublishedModules.GetOrAdd(Guid.Empty, _003C_003Ec__DisplayClass20_._003CTryFindMapperByType_003Eb__1);
				num2 = 9;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
				{
					num2 = 15;
				}
				break;
			case 2:
				return null;
			case 7:
				_003C_003Ec__DisplayClass20_.sourceType = sourceType;
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
				{
					num2 = 13;
				}
				break;
			case 10:
				fullName = _003C_003Ec__DisplayClass20_.sourceType.FullName;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
				{
					num2 = 0;
				}
				break;
			case 12:
				if (dataClassMetadata == null)
				{
					num3++;
					num2 = 5;
				}
				else
				{
					num2 = 14;
				}
				break;
			case 13:
				_003C_003Ec__DisplayClass20_._003C_003E4__this = this;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
				{
					num2 = 3;
				}
				break;
			case 8:
				_003C_003Ec__DisplayClass20_ = new _003C_003Ec__DisplayClass20_0();
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
			case 4:
				dataClassMetadata = ((ModuleInfoMetadata)xXNGXAhx92oTMsi7KlUf(orAdd[num3])).DataClasses.FirstOrDefault(_003C_003Ec__DisplayClass20_._003CTryFindMapperByType_003Eb__2);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
				{
					num2 = 12;
				}
				break;
			}
		}
	}

	private IInternalMapperConfiguration GetMapper(string dataClassTypeRef, Type declaredSourceType)
	{
		int num = 1;
		int num2 = num;
		IInternalMapperConfiguration internalMapper = default(IInternalMapperConfiguration);
		while (true)
		{
			switch (num2)
			{
			default:
				return internalMapper;
			case 1:
			{
				ISet<IInternalMapperConfiguration> orAdd = mappersByTypeRef.GetOrAdd(dataClassTypeRef, (string typeRef) => new ConcurrentHashSet<IInternalMapperConfiguration>());
				internalMapper = GetInternalMapper(dataClassTypeRef, declaredSourceType);
				orAdd.Add(internalMapper);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
				{
					num2 = 0;
				}
				break;
			}
			}
		}
	}

	private IInternalMapperConfiguration GetInternalMapper(string typeRef, Type declaredSourceType)
	{
		//Discarded unreachable code: IL_0202, IL_0300, IL_030f, IL_0360, IL_036f, IL_040f, IL_041e, IL_0538, IL_0547, IL_0569, IL_065b, IL_0730, IL_0768, IL_0777, IL_07a9
		int num = 22;
		_003C_003Ec__DisplayClass22_0 _003C_003Ec__DisplayClass22_ = default(_003C_003Ec__DisplayClass22_0);
		IInternalMapperConfiguration internalMapperConfiguration4 = default(IInternalMapperConfiguration);
		Type type = default(Type);
		IInternalMapperConfiguration internalMapperConfiguration2 = default(IInternalMapperConfiguration);
		int num3 = default(int);
		IInternalMapperConfiguration internalMapperConfiguration = default(IInternalMapperConfiguration);
		IInternalMapperConfiguration[] array2 = default(IInternalMapperConfiguration[]);
		IInternalMapperConfiguration[] array = default(IInternalMapperConfiguration[]);
		IInternalMapperConfiguration internalMapperConfiguration3 = default(IInternalMapperConfiguration);
		ModuleVersion[] orAdd = default(ModuleVersion[]);
		List<IInternalMapperConfiguration> list = default(List<IInternalMapperConfiguration>);
		EntityMetadata entityMetadata = default(EntityMetadata);
		IEnumerator<DataClassMetadata> enumerator = default(IEnumerator<DataClassMetadata>);
		DataClassMetadata current = default(DataClassMetadata);
		string text = default(string);
		Type type2 = default(Type);
		IInternalMapperConfiguration item = default(IInternalMapperConfiguration);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 36:
					_003C_003Ec__DisplayClass22_._003C_003E4__this = this;
					num2 = 27;
					continue;
				case 27:
					_003C_003Ec__DisplayClass22_.declaredSourceType = declaredSourceType;
					num2 = 6;
					continue;
				case 28:
					if (jNWCmjhx7FCNqKMEJwOx(Pxe4GthxLO1YNd2kjYVZ(internalMapperConfiguration4), type))
					{
						num2 = 31;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
						{
							num2 = 25;
						}
						continue;
					}
					goto IL_031d;
				case 35:
					if (!jNWCmjhx7FCNqKMEJwOx(internalMapperConfiguration4.SourceType, _003C_003Ec__DisplayClass22_.declaredSourceType))
					{
						num2 = 39;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
						{
							num2 = 31;
						}
						continue;
					}
					goto case 4;
				case 14:
					return internalMapperConfiguration2;
				case 23:
					num3 = 0;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
					{
						num2 = 19;
					}
					continue;
				case 25:
					return internalMapperConfiguration;
				case 18:
				case 41:
					if (num3 >= array2.Length)
					{
						num2 = 11;
						continue;
					}
					goto case 24;
				case 6:
					array = mappers.Where(_003C_003Ec__DisplayClass22_._003CGetInternalMapper_003Eb__0).ToArray();
					num2 = 12;
					continue;
				case 20:
					return internalMapperConfiguration2;
				case 17:
					internalMapperConfiguration2 = CreateDefaultMapper(_003C_003Ec__DisplayClass22_.declaredSourceType, _003C_003Ec__DisplayClass22_.typeRef);
					num2 = 13;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
					{
						num2 = 13;
					}
					continue;
				case 21:
					_003C_003Ec__DisplayClass22_.typeRef = typeRef;
					num2 = 36;
					continue;
				case 5:
					return internalMapperConfiguration3;
				case 33:
					internalMapperConfiguration = (IInternalMapperConfiguration)mY3BVuhxm59bIlexahex(_003C_003Ec__DisplayClass22_.declaredSourceType, _003C_003Ec__DisplayClass22_.typeRef);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
					{
						num2 = 7;
					}
					continue;
				case 22:
					_003C_003Ec__DisplayClass22_ = new _003C_003Ec__DisplayClass22_0();
					num2 = 21;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
					{
						num2 = 12;
					}
					continue;
				case 37:
					mappers.Add(internalMapperConfiguration3);
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
					{
						num2 = 3;
					}
					continue;
				case 32:
					num3++;
					num2 = 22;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
					{
						num2 = 29;
					}
					continue;
				case 13:
					break;
				case 7:
					mappers.Add(internalMapperConfiguration);
					num2 = 25;
					continue;
				case 42:
					internalMapperConfiguration3 = CreateDefaultMapper(_003C_003Ec__DisplayClass22_.declaredSourceType, _003C_003Ec__DisplayClass22_.typeRef);
					num2 = 37;
					continue;
				case 31:
					return internalMapperConfiguration4;
				case 15:
					array2 = array;
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
					{
						num2 = 7;
					}
					continue;
				case 9:
					num3 = 0;
					num2 = 18;
					continue;
				case 26:
					if (array.Length == 0)
					{
						num2 = 42;
						continue;
					}
					goto IL_016e;
				case 19:
				case 29:
					if (num3 < orAdd.Length)
					{
						num2 = 15;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
						{
							num2 = 16;
						}
						continue;
					}
					goto case 1;
				case 8:
					array = list.Where(_003C_003Ec__DisplayClass22_._003CGetInternalMapper_003Eb__3).ToArray();
					num2 = 26;
					continue;
				case 1:
					if (gfJcn8hxYPuBu20epjs9(list) <= 0)
					{
						num2 = 12;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
						{
							num2 = 33;
						}
						continue;
					}
					goto case 8;
				case 10:
					if (TypeOf<IEntity>.Raw.IsAssignableFrom(_003C_003Ec__DisplayClass22_.declaredSourceType))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 15;
				case 38:
					orAdd = PublishedModules.GetOrAdd(Guid.Empty, _003C_003Ec__DisplayClass22_._003CGetInternalMapper_003Eb__2);
					num2 = 23;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
					{
						num2 = 5;
					}
					continue;
				case 4:
					return internalMapperConfiguration4;
				case 39:
					if (adVWpqhxAOrNIjpuDQfh(type, null))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
						{
							num2 = 28;
						}
						continue;
					}
					goto IL_031d;
				case 11:
					internalMapperConfiguration2 = array.FirstOrDefault(_003C_003Ec__DisplayClass22_._003CGetInternalMapper_003Eb__1);
					num2 = 30;
					continue;
				default:
					if ((entityMetadata = MetadataLoader.LoadMetadata(_003C_003Ec__DisplayClass22_.declaredSourceType) as EntityMetadata) != null)
					{
						num2 = 3;
						continue;
					}
					goto case 15;
				case 24:
					internalMapperConfiguration4 = array2[num3];
					num2 = 18;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
					{
						num2 = 35;
					}
					continue;
				case 30:
					if (internalMapperConfiguration2 == null)
					{
						num2 = 17;
						continue;
					}
					goto case 20;
				case 2:
					list = new List<IInternalMapperConfiguration>();
					num2 = 38;
					continue;
				case 34:
					try
					{
						while (true)
						{
							IL_06ae:
							int num4;
							if (!wCDAQMhx56jEdhMyTirh(enumerator))
							{
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
								{
									num4 = 1;
								}
								goto IL_0577;
							}
							goto IL_061c;
							IL_061c:
							current = enumerator.Current;
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
							{
								num4 = 0;
							}
							goto IL_0577;
							IL_0577:
							while (true)
							{
								switch (num4)
								{
								default:
									text = (string)MUuYZshxlTBD5h3AND2U(orD7n0hxdSRtHLefH5rr(current));
									num4 = 3;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
									{
										num4 = 5;
									}
									continue;
								case 5:
									if (XqLEo5hxrDgA4msHKhkL(text))
									{
										num4 = 8;
										continue;
									}
									goto case 7;
								case 4:
									if (_003C_003Ec__DisplayClass22_.declaredSourceType.IsAssignableFrom(type2))
									{
										num4 = 2;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
										{
											num4 = 2;
										}
										continue;
									}
									goto IL_06ae;
								case 6:
									break;
								case 11:
									if (!jNWCmjhx7FCNqKMEJwOx(type2, null))
									{
										num4 = 4;
										continue;
									}
									goto IL_06ae;
								case 2:
								{
									item = (IInternalMapperConfiguration)mY3BVuhxm59bIlexahex(type2, comIxuhx03u2gGKPBgkm(current));
									int num5 = 9;
									num4 = num5;
									continue;
								}
								case 9:
									mappers.Add(item);
									num4 = 8;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
									{
										num4 = 10;
									}
									continue;
								case 3:
								case 8:
									goto IL_06ae;
								case 7:
									type2 = k4lAakhxgW51YGgJy3WI(text);
									num4 = 11;
									continue;
								case 10:
									list.Add(item);
									num4 = 3;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
									{
										num4 = 2;
									}
									continue;
								case 1:
									goto end_IL_06ae;
								}
								break;
							}
							goto IL_061c;
							continue;
							end_IL_06ae:
							break;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							int num6 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
							{
								num6 = 0;
							}
							while (true)
							{
								switch (num6)
								{
								default:
									nhHuqVhxjo3sKT8b41Qp(enumerator);
									num6 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
									{
										num6 = 1;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
					goto case 32;
				case 12:
					if (array.Length == 0)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto IL_016e;
				case 16:
				case 40:
					enumerator = ((ModuleInfoMetadata)xXNGXAhx92oTMsi7KlUf(orAdd[num3])).DataClasses.Where((DataClassMetadata dto) => _003C_003Ec.QgHc80vwcZi9XpC4lLA9(dto) != null).GetEnumerator();
					num2 = 34;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
					{
						num2 = 26;
					}
					continue;
				case 3:
					{
						type = ((IMetadataRuntimeService)yG658Hhx4tTuDuHVOCji()).GetTypeByUidOrNull((AJlipJhx6wbklACOF3nl(entityMetadata) == EntityMetadataType.InterfaceImplementation) ? entityMetadata.ImplementationUid : hoWhVwhxHTZtyXRPadZD(entityMetadata), loadImplementation: false);
						num2 = 15;
						continue;
					}
					IL_031d:
					num3++;
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
					{
						num2 = 41;
					}
					continue;
					IL_016e:
					type = null;
					num2 = 10;
					continue;
				}
				break;
			}
			mappers.Add(internalMapperConfiguration2);
			num = 14;
		}
	}

	private static IInternalMapperConfiguration CreateDefaultMapper(Type declaredSourceType, object typeRef)
	{
		return (IInternalMapperConfiguration)eQFOWNhxUa08VOEJsnAS(defaultMapperType.MakeGenericType(declaredSourceType), new object[1] { typeRef });
	}

	static AbstractMapperService()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				SingletonReader.JJCZtPuTvSt();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
				{
					num2 = 0;
				}
				break;
			default:
				defaultMapperType = VCPJLdhxsFlKI1xJlNoK(typeof(DefaultDataClassBidirectionalMap<>).TypeHandle);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	internal static void J8jeRKhxNLhTT5ALmUmY(object P_0)
	{
		((AbstractMapperService)P_0).Init();
	}

	internal static object qd0R9Fhx36hR7CctRgAq(object P_0, object P_1)
	{
		return ((IInternalMapperConfiguration)P_0).CreateSourceInstance((DataClass)P_1);
	}

	internal static object hETGUHhxpkYkETPOWCDy(object P_0)
	{
		return P_0.CastAsRealType();
	}

	internal static void G1uQErhxaVWb807gtRvt(object P_0, object P_1, object P_2, object P_3)
	{
		((IInternalMapperConfiguration)P_0).MapReverse((DataClass)P_1, P_2, (IInternalMapperService)P_3);
	}

	internal static void oOfoyYhxDJI6DxKudEdq(object P_0, object P_1, object P_2, object P_3)
	{
		((IInternalMapperConfiguration)P_0).Map(P_1, (DataClass)P_2, (IInternalMapperService)P_3);
	}

	internal static bool LNNLcDhxPxsqx5xYK7cH()
	{
		return biDP2XhxejTRU9NWL0vI == null;
	}

	internal static AbstractMapperService rS6fZ3hx1QEpDCNJSA9g()
	{
		return biDP2XhxejTRU9NWL0vI;
	}

	internal static void mnGol7hxtxcupJqLb71D()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object OuHKVmhxwUui1DoYb2My(object P_0)
	{
		return ((DataClass)P_0).TypeRef;
	}

	internal static object yG658Hhx4tTuDuHVOCji()
	{
		return MetadataServiceContext.MetadataRuntimeService;
	}

	internal static EntityMetadataType AJlipJhx6wbklACOF3nl(object P_0)
	{
		return ((EntityMetadata)P_0).Type;
	}

	internal static Guid hoWhVwhxHTZtyXRPadZD(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static bool adVWpqhxAOrNIjpuDQfh(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static bool jNWCmjhx7FCNqKMEJwOx(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static object eam8wohxx4RWqR79Duye()
	{
		return DataClassDescriptor;
	}

	internal static object comIxuhx03u2gGKPBgkm(object P_0)
	{
		return ((DataClassMetadata)P_0).TypeRef;
	}

	internal static object mY3BVuhxm59bIlexahex(Type declaredSourceType, object P_1)
	{
		return CreateDefaultMapper(declaredSourceType, P_1);
	}

	internal static object LdUA2MhxyBJleThyfpsH(object P_0)
	{
		return ((Assembly)P_0).GetName();
	}

	internal static object sZ1L81hxMfRiGxrFK0vq(object P_0)
	{
		return ((AssemblyName)P_0).Name;
	}

	internal static object Nda9dahxJaPy5t0xDPI8(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static object xXNGXAhx92oTMsi7KlUf(object P_0)
	{
		return ((ModuleVersion)P_0).Metadata;
	}

	internal static object orD7n0hxdSRtHLefH5rr(object P_0)
	{
		return ((DataClassMetadata)P_0).TypeToMap;
	}

	internal static object MUuYZshxlTBD5h3AND2U(object P_0)
	{
		return ((TypeToMap)P_0).FullTypeName;
	}

	internal static bool XqLEo5hxrDgA4msHKhkL(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static Type k4lAakhxgW51YGgJy3WI(object P_0)
	{
		return Type.GetType((string)P_0);
	}

	internal static bool wCDAQMhx56jEdhMyTirh(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void nhHuqVhxjo3sKT8b41Qp(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static int gfJcn8hxYPuBu20epjs9(object P_0)
	{
		return ((List<IInternalMapperConfiguration>)P_0).Count;
	}

	internal static Type Pxe4GthxLO1YNd2kjYVZ(object P_0)
	{
		return ((IInternalMapperConfiguration)P_0).SourceType;
	}

	internal static object eQFOWNhxUa08VOEJsnAS(Type P_0, object P_1)
	{
		return Activator.CreateInstance(P_0, (object[])P_1);
	}

	internal static Type VCPJLdhxsFlKI1xJlNoK(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}
}
