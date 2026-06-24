using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.Caching;
using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.DataClasses;
using EleWise.ELMA.ExpressionUtil;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Events.Audit;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Metadata;

public class MetadataLoader
{
	private static readonly PropertyInfo dictionaryIndexer;

	private static readonly IDictionary<string, MemoryCache> MetadataCaches;

	private static readonly MethodInfo getCacheValueMethod;

	private static readonly MethodInfo getCacheValueCondMethod;

	private static readonly MethodInfo paramToStringMethod;

	private static readonly MethodInfo typeParamToStringMethod;

	private static readonly MethodInfo genericCollectionToStringMethod;

	private static readonly MethodInfo identifiedParamToStringMethod;

	private static readonly MethodInfo stringJoinMethod;

	private static IDictionary<Type, IRootMetadata> loadedMetadataInherit;

	private static IDictionary<Type, IRootMetadata> loadedMetadataNotInherit;

	private static IDictionary<Guid, List<KeyValuePair<PropertyMetadata, ClassMetadata>>> propertiesByParents;

	private static Func<Guid, bool, bool, List<ClassMetadata>> getChildClassesCached;

	private static Func<Guid, List<EnumMetadata>> getChildEnumsCached;

	private static Func<Guid, bool, List<ClassMetadata>> getBaseClassesCached;

	private static MetadataLoader GbOXxjb0WCmVE4JvNPuN;

	public static IMetadata LoadMetadata(Type runtimeType, bool inherit = true, bool loadImplementation = true)
	{
		//Discarded unreachable code: IL_0141, IL_0150, IL_0172, IL_017c, IL_01a0, IL_01af, IL_01ff, IL_02b3, IL_02f3, IL_030f, IL_0407, IL_0423, IL_0432, IL_0441, IL_04b0, IL_04e0, IL_0507, IL_056f
		int num = 39;
		Type type = default(Type);
		IDictionary<Type, IRootMetadata> dictionary = default(IDictionary<Type, IRootMetadata>);
		IRootMetadata value = default(IRootMetadata);
		MetadataTypeAttribute metadataTypeAttribute = default(MetadataTypeAttribute);
		bool flag = default(bool);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				IDictionary<Type, IRootMetadata> dictionary2;
				int num3;
				Type type2;
				switch (num2)
				{
				case 9:
					if (!AFL3RPb0fDyljXlhlbV9(type))
					{
						num2 = 23;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 3;
				case 40:
					if (!type.IsClass)
					{
						num2 = 21;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
						{
							num2 = 31;
						}
						continue;
					}
					goto case 24;
				case 38:
					if (!inherit)
					{
						num = 14;
						break;
					}
					dictionary2 = loadedMetadataInherit;
					goto IL_057e;
				case 20:
					inherit = false;
					num2 = 36;
					continue;
				case 14:
					dictionary2 = loadedMetadataNotInherit;
					goto IL_057e;
				case 2:
				case 27:
					dictionary[type] = value;
					num2 = 26;
					continue;
				case 42:
					if (!type.IsAbstract)
					{
						num = 33;
						break;
					}
					goto case 10;
				case 46:
					if (!type.IsInterface)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
						{
							num2 = 8;
						}
						continue;
					}
					goto case 21;
				case 19:
					value = new ClassMetadata();
					num2 = 25;
					continue;
				case 30:
					if (dictionary.TryGetValue(type, out value))
					{
						num2 = 22;
						continue;
					}
					goto case 6;
				case 1:
				case 29:
					if (!type.IsEnum)
					{
						num2 = 40;
						continue;
					}
					goto case 10;
				case 16:
				case 31:
				case 33:
					if (type.IsClass)
					{
						num2 = 11;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
						{
							num2 = 34;
						}
						continue;
					}
					goto case 46;
				case 11:
					loadedMetadataInherit[type] = value;
					num2 = 13;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
					{
						num2 = 37;
					}
					continue;
				case 24:
					if (type.IsSealed)
					{
						num2 = 42;
						continue;
					}
					goto case 16;
				case 28:
					value = null;
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
					{
						num2 = 30;
					}
					continue;
				case 15:
					if (!ComponentManager.Initialized)
					{
						num2 = 18;
						continue;
					}
					goto case 7;
				case 7:
					num3 = ((y6iuUeb0CvSZCdPaX0hU(ComponentManager.Current) == ComponentManager.LifetimeStage.Initialized) ? 1 : 0);
					goto IL_05ae;
				case 5:
					value = nUUTUSb0ZP5lQlcoifjE(sg0DmXb08NO3ovJJlTLh(metadataTypeAttribute)) as IRootMetadata;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
					{
						num2 = 4;
					}
					continue;
				case 39:
					iZQhrMb0G2Ei0gNqaGCL(runtimeType, rfy1yjb0hRjTYPwEUpjk(0x2ACE37D ^ 0x2AE1BA3));
					num2 = 38;
					continue;
				case 10:
					value = new EnumMetadata();
					num2 = 13;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
					{
						num2 = 1;
					}
					continue;
				case 37:
					loadedMetadataNotInherit[type] = value;
					num = 41;
					break;
				case 44:
					if (metadataTypeAttribute == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 5;
				default:
					if (!type.IsPrimitive)
					{
						num2 = 21;
						continue;
					}
					goto case 4;
				case 21:
				case 34:
					if (TypeOf<IDataClass>.Raw.IsAssignableFrom(type))
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
						{
							num2 = 20;
						}
						continue;
					}
					goto case 19;
				case 17:
					type2 = type;
					goto IL_0591;
				case 45:
					value.ApplyRestartUnrequiredChanges(inherit);
					num2 = 2;
					continue;
				case 22:
				case 26:
					return value;
				case 3:
					type = type.GetNonNullableType();
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
					{
						num2 = 12;
					}
					continue;
				case 6:
					metadataTypeAttribute = type.GetReflectionCustomAttributes(hFy5DQb0vXGxVrJJmu17(typeof(MetadataTypeAttribute).TypeHandle), inherit: false).FirstOrDefault() as MetadataTypeAttribute;
					num2 = 44;
					continue;
				case 47:
					if (flag)
					{
						num2 = 45;
						continue;
					}
					goto case 2;
				case 36:
					value = new DataClassMetadata();
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
					{
						num2 = 11;
					}
					continue;
				case 43:
					value.LoadFromType(type, inherit);
					num2 = 47;
					continue;
				case 4:
				case 13:
				case 25:
				case 41:
					if (value == null)
					{
						num2 = 27;
						continue;
					}
					goto case 43;
				case 8:
					if (type.IsValueType)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 4;
				case 12:
				case 23:
					if (loadImplementation)
					{
						num2 = 32;
						continue;
					}
					goto case 17;
				case 35:
					type = jCuu0eb0E4immWvfQVWF(runtimeType);
					num2 = 9;
					continue;
				case 32:
					type2 = kJBLVjb0Q7nkxs6GlxXN(type);
					goto IL_0591;
				case 18:
					{
						num3 = 0;
						goto IL_05ae;
					}
					IL_0591:
					type = type2;
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
					{
						num2 = 15;
					}
					continue;
					IL_057e:
					dictionary = dictionary2;
					num2 = 35;
					continue;
					IL_05ae:
					flag = (byte)num3 != 0;
					num2 = 28;
					continue;
				}
				break;
			}
		}
	}

	public static IMetadata LoadMetadata(Guid uid, bool inherit = true, bool loadImplementation = true)
	{
		//Discarded unreachable code: IL_0057, IL_0066
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (!K50hkLb0uR8qJN072NCK(uid, Guid.Empty))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			default:
				return null;
			case 1:
				return LoadMetadata(MetadataServiceContext.MetadataRuntimeService.GetTypeByUid(uid, loadImplementation), inherit, loadImplementation);
			}
		}
	}

	public static IMetadata LoadMetadataOrNull(Guid uid, bool inherit = true, bool loadImplementation = true)
	{
		//Discarded unreachable code: IL_0045, IL_0054, IL_008b, IL_009a
		int num = 3;
		int num2 = num;
		Type typeByUidOrNull = default(Type);
		while (true)
		{
			switch (num2)
			{
			default:
				return null;
			case 5:
				return LoadMetadata(typeByUidOrNull, inherit, loadImplementation);
			case 4:
				if (ArTwsfb0IMD1ih1Vg8NW(typeByUidOrNull, null))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
					{
						num2 = 5;
					}
					break;
				}
				goto default;
			case 3:
				if (!K50hkLb0uR8qJN072NCK(uid, Guid.Empty))
				{
					num2 = 2;
					break;
				}
				goto case 1;
			case 1:
				return null;
			case 2:
				typeByUidOrNull = MetadataServiceContext.MetadataRuntimeService.GetTypeByUidOrNull(uid, loadImplementation);
				num2 = 4;
				break;
			}
		}
	}

	public static List<KeyValuePair<PropertyMetadata, ClassMetadata>> GetChildProperties(ClassMetadata metadata)
	{
		_003C_003Ec__DisplayClass3_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass3_0();
		CS_0024_003C_003E8__locals0.metadata = metadata;
		Contract.ArgumentNotNull(CS_0024_003C_003E8__locals0.metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x76DD48E ^ 0x76D9DB0));
		if (CS_0024_003C_003E8__locals0.metadata.Uid == Guid.Empty || !propertiesByParents.TryGetValue(CS_0024_003C_003E8__locals0.metadata.Uid, out var value))
		{
			value = new List<KeyValuePair<PropertyMetadata, ClassMetadata>>();
			GetChildProperties(CS_0024_003C_003E8__locals0.metadata, value);
			propertiesByParents[CS_0024_003C_003E8__locals0.metadata.Uid] = value;
		}
		return (from pm in CS_0024_003C_003E8__locals0.metadata.Properties
			select new KeyValuePair<PropertyMetadata, ClassMetadata>(pm, CS_0024_003C_003E8__locals0.metadata) into p
			orderby p.Key.Order
			select p).Concat(value).ToList();
	}

	public static List<PropertyMetadata> GetBaseProperties(ClassMetadata metadata)
	{
		Contract.ArgumentNotNull(metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x638095EB ^ 0x6380DCD5));
		Func<Guid, ClassMetadata> func = (Guid uid) => (ClassMetadata)((IMetadataService)_003C_003Ec.QEf6MbC46BXEwoRAqHGb()).GetMetadata(uid, loadImplementation: true);
		return GetBaseProperties(metadata, func);
	}

	public static List<PropertyMetadata> GetBaseProperties(ClassMetadata metadata, Func<Guid, ClassMetadata> func)
	{
		Contract.ArgumentNotNull(metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-309639236 ^ -309653886));
		List<PropertyMetadata> list = new List<PropertyMetadata>();
		GetBaseProperties(metadata, list, null, func);
		return list;
	}

	public static List<KeyValuePair<PropertyMetadata, ClassMetadata>> GetBasePropertiesAndMetadata(ClassMetadata metadata)
	{
		Contract.ArgumentNotNull(metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-521266112 ^ -521251458));
		Func<Guid, ClassMetadata> func = (Guid uid) => (ClassMetadata)((IMetadataService)_003C_003Ec.QEf6MbC46BXEwoRAqHGb()).GetMetadata(uid, loadImplementation: true);
		return GetBasePropertiesAndMetadata(metadata, func);
	}

	public static List<KeyValuePair<PropertyMetadata, ClassMetadata>> GetBasePropertiesAndMetadata(ClassMetadata metadata, Func<Guid, ClassMetadata> func)
	{
		Contract.ArgumentNotNull(metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97953432));
		List<KeyValuePair<PropertyMetadata, ClassMetadata>> list = new List<KeyValuePair<PropertyMetadata, ClassMetadata>>();
		GetBaseProperties(metadata, null, list, func);
		return list;
	}

	public static List<IPropertyMetadata> GetBasePropertiesAndTableParts(ClassMetadata metadata, bool includeExtensions = false)
	{
		Contract.ArgumentNotNull(metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1858869089));
		return GetPropertiesAndTableParts(metadata, onlyBase: true, includeExtensions);
	}

	public static List<IPropertyMetadata> GetPropertiesAndTableParts(ClassMetadata metadata, bool includeExtensions = false)
	{
		Contract.ArgumentNotNull(metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6A81B9B4 ^ 0x6A81F08A));
		return GetPropertiesAndTableParts(metadata, onlyBase: false, includeExtensions);
	}

	public static List<ClassMetadata> GetBaseClassMetadataList(ClassMetadata metadata, bool includeExtensions)
	{
		Contract.ArgumentNotNull(metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867217237));
		return GetClassMetadataList(metadata, includeBase: true, includeRootMetadata: false, includeExtensions);
	}

	public static List<ClassMetadata> GetBaseClassMetadataList(ClassMetadata metadata, bool includeExtensions = false, bool loadImplementation = true)
	{
		Contract.ArgumentNotNull(metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2112703338 ^ -2112684632));
		return GetClassMetadataList(metadata, includeBase: true, includeRootMetadata: false, includeExtensions, loadImplementation);
	}

	public static List<ClassMetadata> GetClassExtensionsMetadataList(ClassMetadata metadata, bool includeBaseClasses)
	{
		Contract.ArgumentNotNull(metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-3333094 ^ -3314396));
		return GetClassMetadataList(metadata, includeBaseClasses, includeRootMetadata: true, includeExtensions: true);
	}

	public static List<EnumValueMetadata> GetEntityActions(EntityMetadata metadata, bool inherit, bool onlyBase)
	{
		Contract.ArgumentNotNull(metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4DC2B14D ^ 0x4DC2F873));
		return GetEntityActions(metadata, inherit, onlyBase, loadextensions: true);
	}

	public static List<EnumValueMetadata> GetEntityActions(EntityMetadata metadata, bool inherit = true, bool onlyBase = false, bool loadextensions = true)
	{
		Contract.ArgumentNotNull(metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x26FFCB59 ^ 0x26FF8267));
		List<EnumValueMetadata> list = new List<EnumValueMetadata>();
		GetEntityActions(list, metadata, inherit, onlyBase, loadextensions);
		return list;
	}

	public static List<ClassMetadata> GetBaseClasses(ClassMetadata metadata, bool loadImplementation = true)
	{
		Contract.ArgumentNotNull(metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4EDCBA32 ^ 0x4EDCF30C));
		if (MetadataServiceContext.MetadataRuntimeServiceOrNull != null)
		{
			return new List<ClassMetadata>(getBaseClassesCached(metadata.Uid, loadImplementation));
		}
		return GetBaseClassesList(metadata, loadImplementation);
	}

	public static List<ClassMetadata> GetChildClasses(ClassMetadata metadata, bool loadImplementation = true)
	{
		return GetChildClasses(metadata, loadImplementation, includeRoot: false);
	}

	public static List<ClassMetadata> GetChildClasses(ClassMetadata metadata, bool loadImplementation, bool includeRoot)
	{
		Contract.ArgumentNotNull(metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-541731959 ^ -541746505));
		if (MetadataServiceContext.MetadataRuntimeServiceOrNull != null)
		{
			return new List<ClassMetadata>(getChildClassesCached(metadata.Uid, loadImplementation, includeRoot));
		}
		return GetChildClassesList(metadata, loadImplementation, includeRoot);
	}

	public static List<ClassMetadata> GetChildClasses(Guid mdUid, bool loadImplementation = true, bool includeRoot = false)
	{
		return GetChildClasses((ClassMetadata)LoadMetadata(mdUid, inherit: false, loadImplementation), loadImplementation, includeRoot);
	}

	public static List<EnumMetadata> GetChildEnums(EnumMetadata metadata)
	{
		Contract.ArgumentNotNull(metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4D1C1EE4 ^ 0x4D1C57DA));
		if (MetadataServiceContext.MetadataRuntimeServiceOrNull != null)
		{
			return new List<EnumMetadata>(getChildEnumsCached(metadata.Uid));
		}
		return GetChildEnumsList(metadata);
	}

	public static bool IsBaseClass(Guid uid, ClassMetadata metadata, bool loadImplementation = true)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass20_0 _003C_003Ec__DisplayClass20_ = default(_003C_003Ec__DisplayClass20_0);
		while (true)
		{
			switch (num2)
			{
			default:
				_003C_003Ec__DisplayClass20_.uid = uid;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass20_ = new _003C_003Ec__DisplayClass20_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return GetBaseClasses(metadata, loadImplementation).Any(_003C_003Ec__DisplayClass20_._003CIsBaseClass_003Eb__0);
			}
		}
	}

	public static bool IsBaseOrChildClass<T>(Guid objectTypeUid)
	{
		return IsBaseOrChildClass(typeof(T), objectTypeUid);
	}

	public static bool IsBaseOrChildClass(Guid basetypeUid, Guid objectTypeUid)
	{
		return IsBaseOrChildClass(LoadMetadata(basetypeUid) as ClassMetadata, objectTypeUid);
	}

	public static bool IsBaseOrChildClass(Type basetype, Guid objectTypeUid)
	{
		return IsBaseOrChildClass(LoadMetadata(basetype) as ClassMetadata, objectTypeUid);
	}

	public static bool IsBaseOrChildClass(ClassMetadata baseMetadata, Guid objectTypeUid)
	{
		//Discarded unreachable code: IL_00c9
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass24_0 _003C_003Ec__DisplayClass24_ = default(_003C_003Ec__DisplayClass24_0);
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (K50hkLb0uR8qJN072NCK(_003C_003Ec__DisplayClass24_.objectTypeUid, jdpuMXb0V0gvw39Mg8Tj(baseMetadata)))
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
					{
						num2 = 5;
					}
					break;
				}
				goto case 3;
			case 3:
				return GetChildClasses(baseMetadata).Any(_003C_003Ec__DisplayClass24_._003CIsBaseOrChildClass_003Eb__0);
			case 5:
				return true;
			case 4:
				if (baseMetadata == null)
				{
					return false;
				}
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass24_ = new _003C_003Ec__DisplayClass24_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				_003C_003Ec__DisplayClass24_.objectTypeUid = objectTypeUid;
				num2 = 4;
				break;
			}
		}
	}

	public static bool IsBaseOrChildClass(ClassMetadata baseMetadata, ClassMetadata metadata)
	{
		return dQhHgLb0SNRkd5yaWEUC(baseMetadata, jdpuMXb0V0gvw39Mg8Tj(metadata));
	}

	public static Type GetFilterType(Guid uid)
	{
		//Discarded unreachable code: IL_0096, IL_00a5
		int num = 7;
		Type type3 = default(Type);
		Type type = default(Type);
		Type type2 = default(Type);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
				case 8:
					if (type3 == null)
					{
						num2 = 4;
						continue;
					}
					goto case 5;
				case 1:
					break;
				case 5:
					return type3;
				case 7:
					type = VGGB4jb0iOeDO9QkE9id(uid);
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
					{
						num2 = 3;
					}
					continue;
				case 4:
					if (!ArTwsfb0IMD1ih1Vg8NW(type2, null))
					{
						num2 = 5;
						continue;
					}
					goto case 3;
				case 3:
					type3 = UkWceKb0XLk2DT2LOSIr(type2.Assembly, A6Nlv7b0KhjbmBXjfDg7(type2.FullName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921219329)));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
					{
						num2 = 0;
					}
					continue;
				case 9:
					return type;
				default:
					type2 = type2.BaseType;
					num2 = 8;
					continue;
				case 6:
					if (!ArTwsfb0IMD1ih1Vg8NW(type, null))
					{
						ReferenceOnEntityType referenceOnEntityType = new ReferenceOnEntityType();
						Spj3M4b0RDDawGQZlcdm(referenceOnEntityType, uid);
						type2 = DDwdDAb0qOouhF3AyNmF(referenceOnEntityType);
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
						{
							num2 = 1;
						}
					}
					else
					{
						num2 = 9;
					}
					continue;
				}
				break;
			}
			type3 = null;
			num = 2;
		}
	}

	public static ClassMetadata GetEntityMetadataByFilter(Type filterType, bool inherit = true, bool loadImplementation = true)
	{
		int num = 2;
		int num2 = num;
		FilterForAttribute filterForAttribute = default(FilterForAttribute);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return null;
			case 2:
				if (DC4jwZb0TPgFT0F789Kd(filterType, null))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
					{
						num2 = 1;
					}
					break;
				}
				filterForAttribute = (FilterForAttribute)((IEnumerable<object>)X1xPCib0k25Nt2UEKy9j(filterType, hFy5DQb0vXGxVrJJmu17(typeof(FilterForAttribute).TypeHandle), inherit: true)).FirstOrDefault();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (filterForAttribute != null)
				{
					return (ClassMetadata)LoadMetadata(W2X9olb0n4FZWalKI0fu(filterForAttribute), inherit, loadImplementation);
				}
				num2 = 3;
				break;
			case 1:
				return null;
			}
		}
	}

	public static MetadataImage ParentImage(ClassMetadata metadata, int size)
	{
		//Discarded unreachable code: IL_0070, IL_007f
		int num = 4;
		int num2 = num;
		MetadataImage image = default(MetadataImage);
		while (true)
		{
			switch (num2)
			{
			case 5:
				if (image.Data != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 2;
			case 3:
				if (image == null)
				{
					num2 = 2;
					break;
				}
				goto case 5;
			case 4:
				image = metadata.GetImage(size, onlyToSize: true);
				num2 = 3;
				break;
			case 1:
				return image;
			case 2:
				if (McwB1Ob02j8RHnalpkN3(QhfTXcb0OXKZ6imHbWIZ(metadata), Guid.Empty))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
					{
						num2 = 0;
					}
					break;
				}
				return null;
			default:
				return ParentImage((ClassMetadata)((IMetadataService)HdLAFlb0e8vQFDZZSPX2()).GetMetadata(QhfTXcb0OXKZ6imHbWIZ(metadata), loadImplementation: true), size);
			}
		}
	}

	public static List<PropertyMetadata> GetNotVisibleProperties(ClassMetadata metadata, ViewType viewType)
	{
		List<PropertyMetadata> list = new List<PropertyMetadata>();
		foreach (PropertyMetadata property in metadata.Properties)
		{
			ViewAttribute viewAttribute = ((property.ViewSettings != null) ? property.ViewSettings.GetForView(viewType) : null);
			if (viewAttribute != null && !viewAttribute.Visible)
			{
				list.Add(property);
			}
		}
		return list;
	}

	public static List<Guid> GetDependentMetadataUids(IRootMetadata metadata)
	{
		HashSet<Guid> hashSet = new HashSet<Guid>();
		GetDependentMetadataUidsRecursive(metadata, hashSet);
		return hashSet.ToList();
	}

	public static ClassMetadata GetRealMetadataForProperty(ClassMetadata metadata, string propertyName)
	{
		int num = 4;
		int num2 = num;
		ClassMetadata classMetadata = default(ClassMetadata);
		_003C_003Ec__DisplayClass31_0 _003C_003Ec__DisplayClass31_ = default(_003C_003Ec__DisplayClass31_0);
		while (true)
		{
			switch (num2)
			{
			default:
				return classMetadata;
			case 4:
				_003C_003Ec__DisplayClass31_ = new _003C_003Ec__DisplayClass31_0();
				num2 = 3;
				break;
			case 1:
				if (!classMetadata.Properties.Any(_003C_003Ec__DisplayClass31_._003CGetRealMetadataForProperty_003Eb__0))
				{
					if (!McwB1Ob02j8RHnalpkN3(QhfTXcb0OXKZ6imHbWIZ(classMetadata), Guid.Empty))
					{
						return null;
					}
					num2 = 5;
				}
				else
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
					{
						num2 = 0;
					}
				}
				break;
			case 3:
				_003C_003Ec__DisplayClass31_.propertyName = propertyName;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
				{
					num2 = 2;
				}
				break;
			case 5:
				return GetRealMetadataForProperty((ClassMetadata)LoadMetadata(QhfTXcb0OXKZ6imHbWIZ(classMetadata), inherit: false), _003C_003Ec__DisplayClass31_.propertyName);
			case 2:
				classMetadata = (ClassMetadata)LoadMetadata(jdpuMXb0V0gvw39Mg8Tj(metadata), inherit: false);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static ClassMetadata GetRealMetadataForProperty(ClassMetadata metadata, Guid propertyuid)
	{
		//Discarded unreachable code: IL_0041, IL_00ee, IL_00fd
		int num = 5;
		_003C_003Ec__DisplayClass32_0 _003C_003Ec__DisplayClass32_ = default(_003C_003Ec__DisplayClass32_0);
		ClassMetadata classMetadata = default(ClassMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					_003C_003Ec__DisplayClass32_ = new _003C_003Ec__DisplayClass32_0();
					num2 = 4;
					continue;
				case 7:
					return classMetadata;
				default:
					if (!(QhfTXcb0OXKZ6imHbWIZ(classMetadata) != Guid.Empty))
					{
						num2 = 2;
						continue;
					}
					goto case 3;
				case 1:
					if (!classMetadata.Properties.Any(_003C_003Ec__DisplayClass32_._003CGetRealMetadataForProperty_003Eb__0))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 7;
				case 6:
					classMetadata = (ClassMetadata)LoadMetadata(jdpuMXb0V0gvw39Mg8Tj(metadata), inherit: false);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					break;
				case 3:
					return (ClassMetadata)VSSKEBb0P1atop7fMNCV((ClassMetadata)LoadMetadata(classMetadata.BaseClassUid, inherit: false), _003C_003Ec__DisplayClass32_.propertyuid);
				case 2:
					return null;
				}
				break;
			}
			_003C_003Ec__DisplayClass32_.propertyuid = propertyuid;
			num = 6;
		}
	}

	public static bool CompareTypeUids(Guid leftTypeUid, Guid rightTypeUid)
	{
		//Discarded unreachable code: IL_0075, IL_0084, IL_0094, IL_00a3, IL_012b, IL_013a, IL_0170, IL_017f, IL_018e
		int num = 6;
		int num2 = num;
		List<Guid> list = default(List<Guid>);
		while (true)
		{
			switch (num2)
			{
			case 4:
				return true;
			case 2:
			case 9:
				if (!K50hkLb0uR8qJN072NCK(rightTypeUid, EntityDescriptor.UID))
				{
					num2 = 7;
					break;
				}
				goto case 3;
			default:
				return true;
			case 7:
			case 10:
				return false;
			case 1:
				if (!list.Contains(rightTypeUid))
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
					{
						num2 = 9;
					}
					break;
				}
				goto case 4;
			case 8:
				if (!K50hkLb0uR8qJN072NCK(leftTypeUid, EntityDescriptor.UID))
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 1;
			case 3:
				if (!list.Contains(leftTypeUid))
				{
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
					{
						num2 = 2;
					}
					break;
				}
				goto default;
			case 6:
				if (!K50hkLb0uR8qJN072NCK(leftTypeUid, rightTypeUid))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
					{
						num2 = 5;
					}
					break;
				}
				goto case 11;
			case 12:
				list.Add(EntityDescriptor.UID);
				num2 = 8;
				break;
			case 11:
				return true;
			case 5:
				list = ((ComponentManager)tZ8JPXb01RBnUu5F7IOE()).GetExtensionPoints<IEntityType>().SelectMany((IEntityType e) => e.Types).ToList();
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
				{
					num2 = 12;
				}
				break;
			}
		}
	}

	public static Func<TResult> UseCachingForFunc<TResult>(Expression<Func<TResult>> extractValueExpr)
	{
		return (Func<TResult>)CompileLambda(GetDecoratedLambda(extractValueExpr, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53FA00CE ^ 0x53F8F836)));
	}

	public static Func<TResult> UseCachingForFunc<TResult>(Expression<Func<TResult>> extractValueExpr, out Action clearAction)
	{
		clearAction = ClearFunc(extractValueExpr.ToString());
		return (Func<TResult>)CompileLambda(GetDecoratedLambda(extractValueExpr, extractValueExpr.ToString()));
	}

	public static Func<T1, TResult> UseCachingForFunc<T1, TResult>(Expression<Func<T1, TResult>> extractValueExpr)
	{
		return (Func<T1, TResult>)CompileLambda(GetDecoratedLambda(extractValueExpr, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3C5338FF ^ 0x3C51C007)));
	}

	public static Func<T1, TResult> UseConditionalCachingForFunc<T1, TResult>(Expression<Func<T1, Tuple<TResult, bool>>> extractValueExpr)
	{
		return (Func<T1, TResult>)CompileLambda(GetDecoratedLambda(extractValueExpr, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4D1C1EE4 ^ 0x4D1EE61C), useConditionalCaching: true));
	}

	public static Func<T1, TResult> UseCachingForFunc<T1, TResult>(Expression<Func<T1, TResult>> extractValueExpr, out Action clearAction)
	{
		clearAction = ClearFunc(extractValueExpr.ToString());
		return (Func<T1, TResult>)CompileLambda(GetDecoratedLambda(extractValueExpr, extractValueExpr.ToString()));
	}

	public static Func<T1, T2, TResult> UseCachingForFunc<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> extractValueExpr)
	{
		return (Func<T1, T2, TResult>)CompileLambda(GetDecoratedLambda(extractValueExpr, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x68BBB53E ^ 0x68B94DC6)));
	}

	public static Func<T1, T2, TResult> UseCachingForFunc<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> extractValueExpr, out Action clearAction)
	{
		clearAction = ClearFunc(extractValueExpr.ToString());
		return (Func<T1, T2, TResult>)CompileLambda(GetDecoratedLambda(extractValueExpr, extractValueExpr.ToString()));
	}

	public static Func<T1, T2, T3, TResult> UseCachingForFunc<T1, T2, T3, TResult>(Expression<Func<T1, T2, T3, TResult>> extractValueExpr)
	{
		return (Func<T1, T2, T3, TResult>)CompileLambda(GetDecoratedLambda(extractValueExpr, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x92F12D5 ^ 0x92DEA2D)));
	}

	public static Func<T1, T2, T3, TResult> UseCachingForFunc<T1, T2, T3, TResult>(Expression<Func<T1, T2, T3, TResult>> extractValueExpr, out Action clearAction)
	{
		clearAction = ClearFunc(extractValueExpr.ToString());
		return (Func<T1, T2, T3, TResult>)CompileLambda(GetDecoratedLambda(extractValueExpr, extractValueExpr.ToString()));
	}

	private static Delegate CompileLambda(object exp)
	{
		return ((LambdaExpression)exp).CompileFast();
	}

	private static Action ClearFunc(object region)
	{
		_003C_003Ec__DisplayClass46_0 _003C_003Ec__DisplayClass46_ = new _003C_003Ec__DisplayClass46_0();
		_003C_003Ec__DisplayClass46_.region = (string)region;
		return delegate
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
					_003C_003Ec__DisplayClass46_0.mioy4hC6hjW61eQGPmNU(MetadataCaches[_003C_003Ec__DisplayClass46_.region]);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		};
	}

	private static T GetCacheValue<T>(object key, object region, Func<T> func)
	{
		MemoryCache memoryCache = MetadataCaches[(string)region];
		object obj = memoryCache.Get((string)key);
		if (obj is MemoryCacheService.NullValue)
		{
			obj = default(T);
		}
		else if (obj == null)
		{
			obj = func();
			memoryCache.Set((string)key, obj ?? ((object)MemoryCacheService.NullValue.Null), ObjectCache.InfiniteAbsoluteExpiration);
		}
		return (T)obj;
	}

	private static T GetCacheValueCond<T>(object key, object region, Func<Tuple<T, bool>> func)
	{
		MemoryCache memoryCache = MetadataCaches[(string)region];
		object obj = memoryCache.Get((string)key);
		if (obj is MemoryCacheService.NullValue)
		{
			obj = default(T);
		}
		else if (obj == null)
		{
			Tuple<T, bool> tuple = func();
			obj = tuple.Item1;
			if (tuple.Item2)
			{
				memoryCache.Set((string)key, obj ?? ((object)MemoryCacheService.NullValue.Null), ObjectCache.InfiniteAbsoluteExpiration);
			}
		}
		return (T)obj;
	}

	private static LambdaExpression GetDecoratedLambda(object extractValueExpr, string region = "MetadataCache", bool useConditionalCaching = false)
	{
		//Discarded unreachable code: IL_003d, IL_0089
		int num = 6;
		int num2 = num;
		ParameterExpression parameterExpression = default(ParameterExpression);
		Type type = default(Type);
		BlockExpression body = default(BlockExpression);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 2:
				parameterExpression = (ParameterExpression)G61G0Ib03ExuEEY1ePT4(TypeOf<string>.Raw, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-541731959 ^ -541809623));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
				{
					num2 = 0;
				}
				continue;
			case 4:
				obj = yCb190b0N45F1kIgDbIx(extractValueExpr);
				goto IL_0115;
			case 5:
				if (useConditionalCaching)
				{
					num2 = 3;
					continue;
				}
				goto case 4;
			case 6:
				MetadataCaches.AddOrUpdate(region, (string r) => new MemoryCache((string)_003C_003Ec.tNnVQZC4HvQ8ji59B3gX(0x3630F361 ^ 0x36320B99)), (string r, MemoryCache c) => c);
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
				{
					num2 = 5;
				}
				continue;
			case 3:
				obj = yCb190b0N45F1kIgDbIx(extractValueExpr).GetGenericArguments()[0];
				goto IL_0115;
			case 1:
				{
					return Expression.Lambda(bi4K2bb0Hh2VJUfy7JFS(((IEnumerable<ParameterInfo>)rhiAb4b06960eoE0OlRM(rKCeARb04HIwr40TfUy9(extractValueExpr).GetMethod(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1DE3DD89 ^ 0x1DE3CFD1)))).Select((ParameterInfo p) => _003C_003Ec.kEx50mC4ADAnV3DlOlwA(p)).Concat(type).ToArray()), body, ((LambdaExpression)extractValueExpr).Parameters);
				}
				IL_0115:
				type = (Type)obj;
				num2 = 2;
				continue;
			}
			body = Expression.Block(type, new ParameterExpression[1] { parameterExpression }, (Expression)bhShTTb0pEibt3Lu1hjI(parameterExpression, extractValueExpr), (Expression)prtaygb0w5YMZJe5R35W(null, AytSBfb0aHhMK2t77p26(useConditionalCaching ? getCacheValueCondMethod : getCacheValueMethod, new Type[1] { type }), parameterExpression, uCxWjjb0DB2XAry83aoA(region), ohqCGEb0td9C1DKlhRT9(Expression.Invoke((Expression)extractValueExpr, ((LambdaExpression)extractValueExpr).Parameters), Array.Empty<ParameterExpression>())));
			num2 = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
			{
				num2 = 1;
			}
		}
	}

	private static Expression GenerateKey(object keyVar, object extractValueExpr)
	{
		//Discarded unreachable code: IL_0064, IL_0073, IL_007e, IL_00e9, IL_01cd, IL_0208, IL_0217, IL_0227, IL_0236, IL_027c, IL_02da, IL_030a, IL_0319, IL_034a, IL_0382, IL_0391
		int num = 3;
		int num2 = num;
		List<Expression> list = default(List<Expression>);
		IEnumerator<ParameterExpression> enumerator = default(IEnumerator<ParameterExpression>);
		MethodInfo methodInfo = default(MethodInfo);
		ParameterExpression current = default(ParameterExpression);
		Type type = default(Type);
		while (true)
		{
			switch (num2)
			{
			default:
				return (Expression)zL5GDxb0y1WmEN9HNhvn(keyVar, Expression.Call(stringJoinMethod, Expression.Constant(rfy1yjb0hRjTYPwEUpjk(0x103FE975 ^ 0x103FBDA9)), Expression.NewArrayInit(TypeOf<string>.Raw, list)));
			case 1:
				try
				{
					while (true)
					{
						IL_01b2:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 21;
							goto IL_0082;
						}
						goto IL_0159;
						IL_0082:
						while (true)
						{
							switch (num3)
							{
							case 19:
								methodInfo = typeParamToStringMethod;
								num3 = 8;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
								{
									num3 = 20;
								}
								continue;
							case 3:
							case 4:
								throw new ArgumentException((string)dpEQnWb0xkhki0BaPV1d(rfy1yjb0hRjTYPwEUpjk(-35995181 ^ -36161339)));
							case 7:
							case 11:
							case 12:
							case 20:
								list.Add((Expression)f2THF8b00n8akfDjewAt(methodInfo, current));
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
								{
									num3 = 2;
								}
								continue;
							case 1:
								break;
							case 10:
								if (!(type == typeof(Type)))
								{
									num3 = 6;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
									{
										num3 = 13;
									}
									continue;
								}
								goto case 19;
							default:
								if (!type.IsEnumerableOfSimpleType())
								{
									num3 = 16;
									continue;
								}
								goto case 5;
							case 2:
								goto IL_01b2;
							case 15:
							case 16:
								if (!Mn79ENb07IKF2WIafijG(type))
								{
									num3 = 3;
									continue;
								}
								goto case 14;
							case 9:
								if (WdEKh6b0AFpbUHT8FoDa(type))
								{
									num3 = 18;
									continue;
								}
								goto case 17;
							case 17:
								if (type.IsEnum)
								{
									num3 = 8;
									continue;
								}
								goto case 10;
							case 14:
								methodInfo = identifiedParamToStringMethod;
								num3 = 11;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
								{
									num3 = 6;
								}
								continue;
							case 6:
								type = rKCeARb04HIwr40TfUy9(current);
								num3 = 9;
								continue;
							case 5:
								methodInfo = (MethodInfo)AytSBfb0aHhMK2t77p26(genericCollectionToStringMethod, new Type[1] { type.GetGenericArguments()[0] });
								num3 = 5;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
								{
									num3 = 7;
								}
								continue;
							case 8:
							case 18:
								methodInfo = paramToStringMethod.MakeGenericMethod(type);
								num3 = 12;
								continue;
							case 21:
								goto end_IL_01b2;
							}
							break;
						}
						goto IL_0159;
						IL_0159:
						current = enumerator.Current;
						num3 = 6;
						goto IL_0082;
						continue;
						end_IL_01b2:
						break;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								R17if8b0mw9b9Cym0ZVt(enumerator);
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
								{
									num4 = 0;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
				goto default;
			case 2:
				enumerator = ((LambdaExpression)extractValueExpr).Parameters.GetEnumerator();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				list = new List<Expression> { (Expression)uCxWjjb0DB2XAry83aoA(ParamToString(extractValueExpr.ToString())) };
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private static string ParamToString<T>(T val)
	{
		if (val != null)
		{
			return val.ToString().Escape('\'').Quote('\'');
		}
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7EC153F ^ 0x7EC05D9);
	}

	private static string TypeParamToString(Type type)
	{
		//Discarded unreachable code: IL_002a
		int num = 1;
		int num2 = num;
		object val;
		while (true)
		{
			switch (num2)
			{
			default:
				val = null;
				break;
			case 1:
				if (!ArTwsfb0IMD1ih1Vg8NW(type, null))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
					{
						num2 = 0;
					}
					continue;
				}
				val = type.AssemblyQualifiedName;
				break;
			}
			break;
		}
		return ParamToString((string)val);
	}

	private static string GenericCollectionToString<T>(IEnumerable<T> collection)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2A7797B7 ^ 0x2A776155) + collection.ToSeparatedQuotedString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x307E9FD1 ^ 0x307ECD21), '\'') + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2ACE37D ^ 0x2AC1595);
	}

	private static string IdentifiedParamToString(object param)
	{
		//Discarded unreachable code: IL_00ae, IL_00bd
		int num = 6;
		IEntity entity = default(IEntity);
		Type type = default(Type);
		object obj = default(object);
		ArgumentException ex = default(ArgumentException);
		ArgumentException ex2 = default(ArgumentException);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					break;
				case 9:
					entity = param as IEntity;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
					{
						num2 = 2;
					}
					continue;
				case 10:
				case 11:
					return (string)qZy6CAb0lHa17quDCLyX(type) + (string)rfy1yjb0hRjTYPwEUpjk(0x17ADCCD8 ^ 0x17AC9D9A) + ParamToString(obj);
				case 8:
					if (!WdEKh6b0AFpbUHT8FoDa(obj.GetType()))
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 9;
				default:
					((ILogger)e0AdMkb0JVa2kHDnmA4l()).Log(LogLevel.Error, (Exception)ex, (string)VMvTNXb09F0FLuxIjmrj(ex), Array.Empty<object>());
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
					{
						num2 = 9;
					}
					continue;
				case 1:
					if (!u0WkyMb0d0yo3hdSviuJ(entity))
					{
						num2 = 11;
						continue;
					}
					break;
				case 6:
					type = param.GetType();
					num2 = 5;
					continue;
				case 7:
					((ILogger)e0AdMkb0JVa2kHDnmA4l()).Log(LogLevel.Error, (Exception)ex2, (string)VMvTNXb09F0FLuxIjmrj(ex2), Array.Empty<object>());
					num2 = 10;
					continue;
				case 5:
					obj = Sx1apub0MXZrb7lAKYIu(param);
					num2 = 8;
					continue;
				case 2:
					if (entity != null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 10;
				case 4:
					ex = new ArgumentException((string)dpEQnWb0xkhki0BaPV1d(rfy1yjb0hRjTYPwEUpjk(-561074844 ^ -561228792)));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			ex2 = new ArgumentException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-281842504 ^ -281962864), type.FullName));
			num = 7;
		}
	}

	internal static void AddMetadataToCache(Type runtimeType, IRootMetadata metadata, bool inherit = true)
	{
		//Discarded unreachable code: IL_003a, IL_0059, IL_0068
		int num = 3;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				IDictionary<Type, IRootMetadata> dictionary;
				switch (num2)
				{
				default:
					dictionary = loadedMetadataNotInherit;
					break;
				case 1:
					return;
				case 2:
					if (inherit)
					{
						goto end_IL_0012;
					}
					goto default;
				case 3:
					iZQhrMb0G2Ei0gNqaGCL(runtimeType, rfy1yjb0hRjTYPwEUpjk(-629844702 ^ -629690884));
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					dictionary = loadedMetadataInherit;
					break;
				}
				Type type = runtimeType.GetTypeWithoutProxy();
				if (AFL3RPb0fDyljXlhlbV9(type))
				{
					type = type.GetNonNullableType();
				}
				dictionary[type] = metadata;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
				{
					num2 = 1;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 4;
		}
	}

	private static void GetBaseClass(object metadata, List<ClassMetadata> res, bool loadImplementation = true)
	{
		if (!(((ClassMetadata)metadata).BaseClassUid != Guid.Empty))
		{
			return;
		}
		ClassMetadata classMetadata = (ClassMetadata)MetadataServiceContext.Service.GetMetadata(((ClassMetadata)metadata).BaseClassUid, loadImplementation);
		if (classMetadata != null)
		{
			res.Add(classMetadata);
			if (classMetadata.BaseClassUid != Guid.Empty)
			{
				GetBaseClass(classMetadata, res, loadImplementation);
			}
		}
	}

	private static void GetChildClasses(object metadata, List<ClassMetadata> res, bool loadImplementation = true)
	{
		_003C_003Ec__DisplayClass70_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass70_0();
		CS_0024_003C_003E8__locals0.metadata = (ClassMetadata)metadata;
		List<ClassMetadata> list = (from m in MetadataServiceContext.Service.GetMetadataList().OfType<ClassMetadata>()
			where _003C_003Ec__DisplayClass70_0.IH07itC68golkUVjpvFT(_003C_003Ec__DisplayClass70_0.bscMwJC6CvUdHdZy1oBk(m), _003C_003Ec__DisplayClass70_0.eY0iSPC6vPajvM3RVipE(CS_0024_003C_003E8__locals0.metadata))
			select m).ToList();
		res.AddRange(list);
		foreach (ClassMetadata item in list)
		{
			GetChildClasses(item, res, loadImplementation);
		}
	}

	private static void GetChildEnums(object metadata, List<EnumMetadata> res)
	{
		_003C_003Ec__DisplayClass71_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass71_0();
		CS_0024_003C_003E8__locals0.metadata = (EnumMetadata)metadata;
		List<EnumMetadata> list = (from m in MetadataServiceContext.Service.GetMetadataList().OfType<EnumMetadata>()
			where _003C_003Ec__DisplayClass71_0.B46Vb4C6iON2shgLObiu(_003C_003Ec__DisplayClass71_0.ksILixC6VWuR005Q3HIs(m), _003C_003Ec__DisplayClass71_0.NQHOJLC6SXi85xen1OiY(CS_0024_003C_003E8__locals0.metadata))
			select m).ToList();
		res.AddRange(list);
		foreach (EnumMetadata item in list)
		{
			GetChildEnums(item, res);
		}
	}

	private static void GetChildProperties(object metadata, List<KeyValuePair<PropertyMetadata, ClassMetadata>> properties)
	{
		_003C_003Ec__DisplayClass72_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass72_0();
		CS_0024_003C_003E8__locals0.metadata = (ClassMetadata)metadata;
		CS_0024_003C_003E8__locals0.properties = properties;
		if (!(CS_0024_003C_003E8__locals0.metadata.Uid != Guid.Empty))
		{
			return;
		}
		foreach (ClassMetadata item in from m in MetadataServiceContext.Service.GetMetadataList().OfType<ClassMetadata>()
			where _003C_003Ec__DisplayClass72_0.bPqmjHC6nfMDxojtO20l(_003C_003Ec__DisplayClass72_0.vrhhgHC6T5GBNl7sHBGq(m), _003C_003Ec__DisplayClass72_0.GZTmEDC6kUlG2QMy88A4(CS_0024_003C_003E8__locals0.metadata))
			select m)
		{
			_003C_003Ec__DisplayClass72_1 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass72_1();
			CS_0024_003C_003E8__locals1.child = (ClassMetadata)LoadMetadata(item.Uid, inherit: false, loadImplementation: false);
			CS_0024_003C_003E8__locals0.properties.AddRange(from pm in CS_0024_003C_003E8__locals1.child.Properties.Where(delegate(PropertyMetadata pm)
				{
					int num = 1;
					int num2 = num;
					_003C_003Ec__DisplayClass72_2 _003C_003Ec__DisplayClass72_ = default(_003C_003Ec__DisplayClass72_2);
					while (true)
					{
						switch (num2)
						{
						default:
							_003C_003Ec__DisplayClass72_.pm = pm;
							num2 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
							{
								num2 = 1;
							}
							break;
						case 1:
							_003C_003Ec__DisplayClass72_ = new _003C_003Ec__DisplayClass72_2();
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
							{
								num2 = 0;
							}
							break;
						case 2:
							return !CS_0024_003C_003E8__locals0.properties.Any(_003C_003Ec__DisplayClass72_._003CGetChildProperties_003Eb__4);
						}
					}
				})
				select new KeyValuePair<PropertyMetadata, ClassMetadata>(pm, CS_0024_003C_003E8__locals1.child) into p
				orderby p.Key.Order
				select p);
			GetChildProperties(CS_0024_003C_003E8__locals1.child, CS_0024_003C_003E8__locals0.properties);
		}
	}

	private static void GetBaseProperties(object metadata, List<PropertyMetadata> properties, List<KeyValuePair<PropertyMetadata, ClassMetadata>> propertiesAndMetadata, Func<Guid, ClassMetadata> func)
	{
		_003C_003Ec__DisplayClass73_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass73_0();
		CS_0024_003C_003E8__locals0.properties = properties;
		CS_0024_003C_003E8__locals0.propertiesAndMetadata = propertiesAndMetadata;
		if (func == null || !(((ClassMetadata)metadata).BaseClassUid != Guid.Empty))
		{
			return;
		}
		_003C_003Ec__DisplayClass73_1 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass73_1();
		CS_0024_003C_003E8__locals1.baseClass = func(((ClassMetadata)metadata).BaseClassUid);
		if (CS_0024_003C_003E8__locals1.baseClass == null)
		{
			return;
		}
		GetBaseProperties(CS_0024_003C_003E8__locals1.baseClass, CS_0024_003C_003E8__locals0.properties, CS_0024_003C_003E8__locals0.propertiesAndMetadata, func);
		if (CS_0024_003C_003E8__locals0.properties != null)
		{
			CS_0024_003C_003E8__locals0.properties.AddRange(CS_0024_003C_003E8__locals1.baseClass.Properties.Where(delegate(PropertyMetadata bp)
			{
				int num3 = 2;
				int num4 = num3;
				_003C_003Ec__DisplayClass73_2 _003C_003Ec__DisplayClass73_2 = default(_003C_003Ec__DisplayClass73_2);
				while (true)
				{
					switch (num4)
					{
					case 2:
						_003C_003Ec__DisplayClass73_2 = new _003C_003Ec__DisplayClass73_2();
						num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
						{
							num4 = 1;
						}
						break;
					case 1:
						_003C_003Ec__DisplayClass73_2.bp = bp;
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
						{
							num4 = 0;
						}
						break;
					default:
						return CS_0024_003C_003E8__locals0.properties.All(_003C_003Ec__DisplayClass73_2._003CGetBaseProperties_003Eb__3);
					}
				}
			}));
		}
		if (CS_0024_003C_003E8__locals0.propertiesAndMetadata == null)
		{
			return;
		}
		CS_0024_003C_003E8__locals0.propertiesAndMetadata.AddRange(from p in CS_0024_003C_003E8__locals1.baseClass.Properties.Where(delegate(PropertyMetadata bp)
			{
				int num = 2;
				int num2 = num;
				_003C_003Ec__DisplayClass73_3 _003C_003Ec__DisplayClass73_ = default(_003C_003Ec__DisplayClass73_3);
				while (true)
				{
					switch (num2)
					{
					default:
						return CS_0024_003C_003E8__locals0.propertiesAndMetadata.All(_003C_003Ec__DisplayClass73_._003CGetBaseProperties_003Eb__4);
					case 1:
						_003C_003Ec__DisplayClass73_.bp = bp;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
						{
							num2 = 0;
						}
						break;
					case 2:
						_003C_003Ec__DisplayClass73_ = new _003C_003Ec__DisplayClass73_3();
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
						{
							num2 = 1;
						}
						break;
					}
				}
			})
			select new KeyValuePair<PropertyMetadata, ClassMetadata>(p, CS_0024_003C_003E8__locals1.baseClass));
	}

	private static List<IPropertyMetadata> GetPropertiesAndTableParts(object metadata, bool onlyBase, bool includeExtensions)
	{
		Contract.ArgumentNotNull(metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1876063057 ^ -1876048495));
		List<ClassMetadata> classMetadataList = GetClassMetadataList(metadata, includeBase: true, !onlyBase, includeExtensions);
		List<IPropertyMetadata> list = new List<IPropertyMetadata>();
		foreach (ClassMetadata item in classMetadataList)
		{
			if (item is EntityMetadata entityMetadata)
			{
				list.AddRange(entityMetadata.GetPropertiesAndTableParts());
			}
			else
			{
				list.AddRange(item.Properties.Cast<IPropertyMetadata>());
			}
		}
		return list;
	}

	private static List<ClassMetadata> GetClassMetadataList(object rootMetadata, bool includeBase, bool includeRootMetadata, bool includeExtensions, bool loadImplementation = true)
	{
		Contract.ArgumentNotNull(rootMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-309639236 ^ -309740244));
		Func<Guid, bool, ClassMetadata> func = (Guid uid, bool loadImpl) => (ClassMetadata)((IMetadataService)_003C_003Ec.QEf6MbC46BXEwoRAqHGb()).GetMetadata(uid, loadImpl);
		Func<Guid, List<ClassMetadata>> getExtensionsFunc = delegate(Guid uid)
		{
			_003C_003Ec__DisplayClass75_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass75_0();
			CS_0024_003C_003E8__locals0.uid = uid;
			return MetadataServiceContext.Service.GetMetadataList().OfType<ClassMetadata>().Where(delegate(ClassMetadata m)
			{
				//Discarded unreachable code: IL_009f
				int num = 2;
				int num2 = num;
				EntityMetadata entityMetadata = default(EntityMetadata);
				while (true)
				{
					switch (num2)
					{
					case 1:
						if (entityMetadata == null)
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
							{
								num2 = 0;
							}
							continue;
						}
						goto case 4;
					case 2:
						entityMetadata = m as EntityMetadata;
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
						{
							num2 = 0;
						}
						continue;
					case 4:
						if (_003C_003Ec__DisplayClass75_0.uqofucC6jjoueGk4rl4l(entityMetadata) == EntityMetadataType.InterfaceExtension)
						{
							num2 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
							{
								num2 = 0;
							}
							continue;
						}
						break;
					case 3:
						return _003C_003Ec__DisplayClass75_0.Bi7fYqC6Ys57LhVxkQJZ(entityMetadata.BaseClassUid, CS_0024_003C_003E8__locals0.uid);
					}
					break;
				}
				return false;
			})
				.ToList();
		};
		List<ClassMetadata> result = new List<ClassMetadata>();
		if (includeRootMetadata)
		{
			GetClassMetadataListNonRecursive(rootMetadata, result, includeExtensions, getExtensionsFunc);
		}
		if (includeBase)
		{
			GetBaseClassMetadataList(rootMetadata, result, func, includeExtensions, getExtensionsFunc, loadImplementation);
		}
		return result;
	}

	private static void GetBaseClassMetadataList(object metadata, List<ClassMetadata> result, Func<Guid, bool, ClassMetadata> func, bool includeExtensions, Func<Guid, List<ClassMetadata>> getExtensionsFunc, bool loadImplementation = true)
	{
		_003C_003Ec__DisplayClass76_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass76_0();
		CS_0024_003C_003E8__locals0.getExtensionsFunc = getExtensionsFunc;
		CS_0024_003C_003E8__locals0.metadata = (ClassMetadata)metadata;
		if (func == null || !(CS_0024_003C_003E8__locals0.metadata.BaseClassUid != Guid.Empty))
		{
			return;
		}
		ClassMetadata classMetadata = func(CS_0024_003C_003E8__locals0.metadata.BaseClassUid, loadImplementation);
		if (classMetadata == null)
		{
			return;
		}
		GetClassMetadataListNonRecursive(classMetadata, result, includeExtensions, (Guid uid) => (CS_0024_003C_003E8__locals0.getExtensionsFunc == null) ? new List<ClassMetadata>() : CS_0024_003C_003E8__locals0.getExtensionsFunc(uid).Where(delegate(ClassMetadata m)
		{
			//Discarded unreachable code: IL_002d, IL_003c
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (m == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				case 2:
					return m.Uid != _003C_003Ec__DisplayClass76_0.l9QPl8C6zOkZRDmf1Ch6(CS_0024_003C_003E8__locals0.metadata);
				default:
					return false;
				}
			}
		}).ToList());
		GetBaseClassMetadataList(classMetadata, result, func, includeExtensions, CS_0024_003C_003E8__locals0.getExtensionsFunc, loadImplementation);
	}

	private static void GetClassMetadataListNonRecursive(object metadata, List<ClassMetadata> result, bool includeExtensions, Func<Guid, List<ClassMetadata>> getExtensionsFunc)
	{
		if (metadata == null)
		{
			return;
		}
		List<ClassMetadata> list = new List<ClassMetadata>();
		list.Add((ClassMetadata)metadata);
		if (includeExtensions && getExtensionsFunc != null)
		{
			List<ClassMetadata> list2 = getExtensionsFunc(((AbstractMetadata)metadata).Uid);
			if (list2 != null)
			{
				list.AddRange(list2);
			}
		}
		result.InsertRange(0, list);
	}

	public static Guid GetMetadataUid(EntityMetadata metadata)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (a7b5yFb0rSOkTOMr9GGX(metadata) == EntityMetadataType.InterfaceExtension)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
					{
						num2 = 0;
					}
					break;
				}
				return metadata.Uid;
			default:
				return QhfTXcb0OXKZ6imHbWIZ(metadata);
			}
		}
	}

	private static void GetEntityActions(List<EnumValueMetadata> items, object metadata, bool inherit, bool onlyBase, bool includeExtensions)
	{
		Contract.ArgumentNotNull(metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837680827));
		switch (((EntityMetadata)metadata).Type)
		{
		case EntityMetadataType.InterfaceExtension:
			if (includeExtensions && ((ClassMetadata)metadata).BaseClassUid != Guid.Empty)
			{
				metadata = (EntityMetadata)MetadataServiceContext.Service.GetMetadata(((ClassMetadata)metadata).BaseClassUid, loadImplementation: false);
			}
			break;
		case EntityMetadataType.InterfaceImplementation:
			metadata = (EntityMetadata)MetadataServiceContext.Service.GetMetadata(((EntityMetadata)metadata).ImplementationUid, loadImplementation: false);
			break;
		}
		foreach (EntityMetadata classMetadata in GetClassMetadataList(metadata, inherit, !onlyBase || !inherit, includeExtensions, loadImplementation: false))
		{
			if (classMetadata.Actions != null)
			{
				items.AddRange(classMetadata.Actions.Values);
			}
		}
		if (inherit)
		{
			items.AddRange(EntityAuditActionProvider.DefaultActions.Values);
		}
	}

	private static void GetDependentMetadataUidsRecursive(object metadata, ISet<Guid> result, IDictionary<Guid, List<EntityMetadata>> entityMetadataByBaseClassUid = null)
	{
		if (metadata == null || !result.Add(((IMetadata)metadata).Uid))
		{
			return;
		}
		if (metadata is ICompositeMetadata compositeMetadata)
		{
			AddCompositeMetadataUids(compositeMetadata, result);
		}
		if (!(metadata is EntityMetadata entityMetadata))
		{
			return;
		}
		if (entityMetadataByBaseClassUid == null)
		{
			entityMetadataByBaseClassUid = (from m in MetadataServiceContext.Service.GetMetadataList().OfType<EntityMetadata>()
				where m.Type != EntityMetadataType.InterfaceExtension
				group m by m.BaseClassUid).ToDictionary((IGrouping<Guid, EntityMetadata> g) => g.Key, (IGrouping<Guid, EntityMetadata> g) => g.ToList());
		}
		EntityMetadataType type = entityMetadata.Type;
		if (type == EntityMetadataType.InterfaceExtension)
		{
			result.Add(entityMetadata.BaseClassUid);
			GetDependentMetadataUidsRecursive(MetadataServiceContext.Service.GetMetadata(entityMetadata.BaseClassUid) as EntityMetadata, result, entityMetadataByBaseClassUid);
			return;
		}
		if (entityMetadataByBaseClassUid.TryGetValue(entityMetadata.Uid, out var value))
		{
			foreach (EntityMetadata item in value)
			{
				GetDependentMetadataUidsRecursive(item, result, entityMetadataByBaseClassUid);
			}
		}
		if (entityMetadata.Type == EntityMetadataType.Interface)
		{
			GetDependentMetadataUidsRecursive(MetadataServiceContext.Service.GetMetadata(entityMetadata.ImplementationUid) as EntityMetadata, result, entityMetadataByBaseClassUid);
		}
	}

	private static void AddCompositeMetadataUids(object compositeMetadata, ISet<Guid> uids)
	{
		if (compositeMetadata == null)
		{
			return;
		}
		IEnumerable<IMetadata> compositeParts = ((ICompositeMetadata)compositeMetadata).GetCompositeParts();
		if (compositeParts == null)
		{
			return;
		}
		foreach (IMetadata item in compositeParts)
		{
			uids.Add(item.Uid);
			if (item is ICompositeMetadata compositeMetadata2)
			{
				AddCompositeMetadataUids(compositeMetadata2, uids);
			}
		}
	}

	private static List<ClassMetadata> EnumerateChildClasses(Guid metadataUid, bool loadImplementation, bool includeRoot)
	{
		if (LoadMetadataOrNull(metadataUid, inherit: false, loadImplementation) is ClassMetadata metadata)
		{
			return GetChildClassesList(metadata, loadImplementation, includeRoot);
		}
		return new List<ClassMetadata>();
	}

	private static List<EnumMetadata> EnumerateChildEnums(Guid metadataUid)
	{
		if (LoadMetadataOrNull(metadataUid, inherit: false, loadImplementation: false) is EnumMetadata metadata)
		{
			return GetChildEnumsList(metadata);
		}
		return new List<EnumMetadata>();
	}

	private static List<ClassMetadata> EnumerateBaseClasses(Guid metadataUid, bool loadImplementation)
	{
		if (LoadMetadataOrNull(metadataUid, inherit: false, loadImplementation) is ClassMetadata metadata)
		{
			return GetBaseClassesList(metadata, loadImplementation);
		}
		return new List<ClassMetadata>();
	}

	private static List<ClassMetadata> GetChildClassesList(object metadata, bool loadImplementation, bool includeRoot)
	{
		List<ClassMetadata> list = new List<ClassMetadata>();
		GetChildClasses(metadata, list, loadImplementation);
		if (includeRoot)
		{
			list.Add((ClassMetadata)metadata);
		}
		return list;
	}

	private static List<EnumMetadata> GetChildEnumsList(object metadata)
	{
		List<EnumMetadata> list = new List<EnumMetadata>();
		GetChildEnums(metadata, list);
		return list;
	}

	private static List<ClassMetadata> GetBaseClassesList(object metadata, bool loadImplementation = true)
	{
		List<ClassMetadata> list = new List<ClassMetadata>();
		GetBaseClass(metadata, list, loadImplementation);
		return list;
	}

	public MetadataLoader()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		G07GOwb0gqiqe4SA4PQt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static MetadataLoader()
	{
		int num = 8;
		ParameterExpression parameterExpression = default(ParameterExpression);
		ParameterExpression parameterExpression3 = default(ParameterExpression);
		ParameterExpression parameterExpression2 = default(ParameterExpression);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 12:
					identifiedParamToStringMethod = TypeOf<MetadataLoader>.Raw.GetMethod((string)rfy1yjb0hRjTYPwEUpjk(-1765851862 ^ -1765947840), BindingFlags.Static | BindingFlags.NonPublic);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
					{
						num2 = 0;
					}
					continue;
				case 21:
					break;
				case 7:
					dictionaryIndexer = (from p in TypeOf<IDictionary<string, MemoryCache>>.Raw.GetProperties()
						where _003C_003Ec.yBoI4vC47IUeOIuvFB2N(p.PropertyType, TypeOf<MemoryCache>.Raw)
						select p).First(delegate(PropertyInfo p)
					{
						int num3 = 1;
						int num4 = num3;
						ParameterInfo[] array = default(ParameterInfo[]);
						while (true)
						{
							switch (num4)
							{
							default:
								if (array.Length != 1)
								{
									return false;
								}
								num4 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
								{
									num4 = 2;
								}
								break;
							case 1:
								array = (ParameterInfo[])_003C_003Ec.NTeLODC4x4DuEYv4Pg8p(p);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
								{
									num4 = 0;
								}
								break;
							case 2:
								return _003C_003Ec.yBoI4vC47IUeOIuvFB2N(array[0].ParameterType, TypeOf<string>.Raw);
							}
						}
					});
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
					{
						num2 = 9;
					}
					continue;
				case 18:
					parameterExpression = (ParameterExpression)sxvXecb05ZbUxG0q7H0f(hFy5DQb0vXGxVrJJmu17(typeof(Guid).TypeHandle), rfy1yjb0hRjTYPwEUpjk(-1487388570 ^ -1487305808));
					num2 = 16;
					continue;
				default:
					stringJoinMethod = TypeOf<string>.Raw.GetMethod((string)rfy1yjb0hRjTYPwEUpjk(0xD3DEF7E ^ 0xD3F14E2), new Type[2]
					{
						TypeOf<string>.Raw,
						TypeOf<IEnumerable<string>>.Raw
					});
					num2 = 22;
					continue;
				case 15:
					return;
				case 1:
					parameterExpression3 = (ParameterExpression)sxvXecb05ZbUxG0q7H0f(hFy5DQb0vXGxVrJJmu17(typeof(Guid).TypeHandle), rfy1yjb0hRjTYPwEUpjk(0x7E6E5A0B ^ 0x7E6F99DD));
					num2 = 21;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
					{
						num2 = 3;
					}
					continue;
				case 5:
					getCacheValueCondMethod = TypeOf<MetadataLoader>.Raw.GetMethod((string)rfy1yjb0hRjTYPwEUpjk(0x1A33FE36 ^ 0x1A3104FC), BindingFlags.Static | BindingFlags.NonPublic);
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
					{
						num2 = 2;
					}
					continue;
				case 3:
					loadedMetadataNotInherit = PublishCacheContext.CreateCache(delegate(IDictionary<Type, IRootMetadata> c, Type t, Guid _)
					{
						c.Remove(t);
					});
					num2 = 4;
					continue;
				case 8:
					G07GOwb0gqiqe4SA4PQt();
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
					{
						num2 = 7;
					}
					continue;
				case 16:
					parameterExpression2 = (ParameterExpression)sxvXecb05ZbUxG0q7H0f(hFy5DQb0vXGxVrJJmu17(typeof(bool).TypeHandle), rfy1yjb0hRjTYPwEUpjk(0x1637C429 ^ 0x16353F81));
					num2 = 19;
					continue;
				case 9:
					MetadataCaches = PublishCacheContext.CreateCache((IDictionary<string, MemoryCache> cache) => cache?.ToConcurrentDictionary((KeyValuePair<string, MemoryCache> p) => p.Key, (KeyValuePair<string, MemoryCache> p) => new MemoryCache(p.Value.Name)) ?? new ConcurrentDictionary<string, MemoryCache>(), null, delegate(IDictionary<string, MemoryCache> cache)
					{
						cache.ForEach(delegate(KeyValuePair<string, MemoryCache> c)
						{
							c.Value.Clear();
						});
					});
					num2 = 2;
					continue;
				case 17:
					genericCollectionToStringMethod = TypeOf<MetadataLoader>.Raw.GetMethod((string)rfy1yjb0hRjTYPwEUpjk(-1334993905 ^ -1334876357), BindingFlags.Static | BindingFlags.NonPublic);
					num2 = 12;
					continue;
				case 14:
					getBaseClassesCached = UseCachingForFunc(Expression.Lambda<Func<Guid, bool, List<ClassMetadata>>>((Expression)ItTTupb0Y6tdLUKNT6Bq(null, (MethodInfo)IqunObb0jwUUfS3wS4Ps((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), new Expression[2] { parameterExpression3, parameterExpression2 }), new ParameterExpression[2] { parameterExpression3, parameterExpression2 }));
					num2 = 15;
					continue;
				case 22:
					loadedMetadataInherit = PublishCacheContext.CreateCache(delegate(IDictionary<Type, IRootMetadata> c, Type _, Guid __)
					{
						c.Clear();
					});
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
					{
						num2 = 2;
					}
					continue;
				case 11:
					parameterExpression2 = (ParameterExpression)sxvXecb05ZbUxG0q7H0f(hFy5DQb0vXGxVrJJmu17(typeof(bool).TypeHandle), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-889460160 ^ -889646616));
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
					{
						num2 = 14;
					}
					continue;
				case 20:
					parameterExpression3 = Expression.Parameter(hFy5DQb0vXGxVrJJmu17(typeof(Guid).TypeHandle), (string)rfy1yjb0hRjTYPwEUpjk(0x42643203 ^ 0x4265F1D5));
					num2 = 11;
					continue;
				case 6:
					typeParamToStringMethod = TypeOf<MetadataLoader>.Raw.GetMethod((string)rfy1yjb0hRjTYPwEUpjk(0x4785BC0D ^ 0x47874703), BindingFlags.Static | BindingFlags.NonPublic);
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
					{
						num2 = 17;
					}
					continue;
				case 10:
					paramToStringMethod = TypeOf<MetadataLoader>.Raw.GetMethod((string)rfy1yjb0hRjTYPwEUpjk(0x5F3078B6 ^ 0x5F328246), BindingFlags.Static | BindingFlags.NonPublic);
					num2 = 6;
					continue;
				case 2:
					getCacheValueMethod = TypeOf<MetadataLoader>.Raw.GetMethod(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-583745292 ^ -583648680), BindingFlags.Static | BindingFlags.NonPublic);
					num2 = 5;
					continue;
				case 19:
					parameterExpression3 = (ParameterExpression)sxvXecb05ZbUxG0q7H0f(typeof(bool), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x42643203 ^ 0x4265F13F));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
					{
						num2 = 13;
					}
					continue;
				case 4:
					propertiesByParents = PublishCacheContext.CreateCache(delegate(IDictionary<Guid, List<KeyValuePair<PropertyMetadata, ClassMetadata>>> c, Type _, Guid __)
					{
						c.Clear();
					});
					num2 = 18;
					continue;
				case 13:
					getChildClassesCached = UseCachingForFunc(Expression.Lambda<Func<Guid, bool, bool, List<ClassMetadata>>>((Expression)ItTTupb0Y6tdLUKNT6Bq(null, (MethodInfo)IqunObb0jwUUfS3wS4Ps((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), new Expression[3] { parameterExpression, parameterExpression2, parameterExpression3 }), new ParameterExpression[3] { parameterExpression, parameterExpression2, parameterExpression3 }));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			getChildEnumsCached = UseCachingForFunc(Expression.Lambda<Func<Guid, List<EnumMetadata>>>((Expression)ItTTupb0Y6tdLUKNT6Bq(null, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), new Expression[1] { parameterExpression3 }), new ParameterExpression[1] { parameterExpression3 }));
			num = 20;
		}
	}

	internal static object rfy1yjb0hRjTYPwEUpjk(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void iZQhrMb0G2Ei0gNqaGCL(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static Type jCuu0eb0E4immWvfQVWF(Type type)
	{
		return type.GetTypeWithoutProxy();
	}

	internal static bool AFL3RPb0fDyljXlhlbV9(Type type)
	{
		return TypeExtensions.IsNullableType(type);
	}

	internal static Type kJBLVjb0Q7nkxs6GlxXN(Type t)
	{
		return InterfaceActivator.TypeOf(t);
	}

	internal static ComponentManager.LifetimeStage y6iuUeb0CvSZCdPaX0hU(object P_0)
	{
		return ((ComponentManager)P_0).Stage;
	}

	internal static Type hFy5DQb0vXGxVrJJmu17(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static Type sg0DmXb08NO3ovJJlTLh(object P_0)
	{
		return ((MetadataTypeAttribute)P_0).MetadataType;
	}

	internal static object nUUTUSb0ZP5lQlcoifjE(Type P_0)
	{
		return Activator.CreateInstance(P_0);
	}

	internal static bool gbcEbgb0oiT7uxKx8wjf()
	{
		return GbOXxjb0WCmVE4JvNPuN == null;
	}

	internal static MetadataLoader X8ly9ob0bgL7BObd21ds()
	{
		return GbOXxjb0WCmVE4JvNPuN;
	}

	internal static bool K50hkLb0uR8qJN072NCK(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static bool ArTwsfb0IMD1ih1Vg8NW(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static Guid jdpuMXb0V0gvw39Mg8Tj(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static bool dQhHgLb0SNRkd5yaWEUC(object P_0, Guid objectTypeUid)
	{
		return IsBaseOrChildClass((ClassMetadata)P_0, objectTypeUid);
	}

	internal static Type VGGB4jb0iOeDO9QkE9id(Guid uid)
	{
		return UniqueFilterHelper.GetUniqueFilterType(uid);
	}

	internal static void Spj3M4b0RDDawGQZlcdm(object P_0, Guid value)
	{
		((ReferenceOnEntityType)P_0).TypeUid = value;
	}

	internal static Type DDwdDAb0qOouhF3AyNmF(object P_0)
	{
		return ((ReferenceOnEntityType)P_0).EntityType;
	}

	internal static object A6Nlv7b0KhjbmBXjfDg7(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static Type UkWceKb0XLk2DT2LOSIr(object P_0, object P_1)
	{
		return ((Assembly)P_0).GetReflectionType((string)P_1);
	}

	internal static bool DC4jwZb0TPgFT0F789Kd(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static object X1xPCib0k25Nt2UEKy9j(Type type, Type attributeType, bool inherit)
	{
		return type.GetReflectionCustomAttributes(attributeType, inherit);
	}

	internal static Type W2X9olb0n4FZWalKI0fu(object P_0)
	{
		return ((FilterForAttribute)P_0).EntityType;
	}

	internal static Guid QhfTXcb0OXKZ6imHbWIZ(object P_0)
	{
		return ((ClassMetadata)P_0).BaseClassUid;
	}

	internal static bool McwB1Ob02j8RHnalpkN3(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static object HdLAFlb0e8vQFDZZSPX2()
	{
		return MetadataServiceContext.Service;
	}

	internal static object VSSKEBb0P1atop7fMNCV(object P_0, Guid propertyuid)
	{
		return GetRealMetadataForProperty((ClassMetadata)P_0, propertyuid);
	}

	internal static object tZ8JPXb01RBnUu5F7IOE()
	{
		return ComponentManager.Current;
	}

	internal static Type yCb190b0N45F1kIgDbIx(object P_0)
	{
		return ((LambdaExpression)P_0).ReturnType;
	}

	internal static object G61G0Ib03ExuEEY1ePT4(Type P_0, object P_1)
	{
		return Expression.Variable(P_0, (string)P_1);
	}

	internal static object bhShTTb0pEibt3Lu1hjI(object P_0, object P_1)
	{
		return GenerateKey(P_0, P_1);
	}

	internal static object AytSBfb0aHhMK2t77p26(object P_0, object P_1)
	{
		return ((MethodInfo)P_0).MakeGenericMethod((Type[])P_1);
	}

	internal static object uCxWjjb0DB2XAry83aoA(object P_0)
	{
		return Expression.Constant(P_0);
	}

	internal static object ohqCGEb0td9C1DKlhRT9(object P_0, object P_1)
	{
		return Expression.Lambda((Expression)P_0, (ParameterExpression[])P_1);
	}

	internal static object prtaygb0w5YMZJe5R35W(object P_0, object P_1, object P_2, object P_3, object P_4)
	{
		return Expression.Call((Expression)P_0, (MethodInfo)P_1, (Expression)P_2, (Expression)P_3, (Expression)P_4);
	}

	internal static Type rKCeARb04HIwr40TfUy9(object P_0)
	{
		return ((Expression)P_0).Type;
	}

	internal static object rhiAb4b06960eoE0OlRM(object P_0)
	{
		return ((MethodBase)P_0).GetParameters();
	}

	internal static Type bi4K2bb0Hh2VJUfy7JFS(object P_0)
	{
		return Expression.GetFuncType((Type[])P_0);
	}

	internal static bool WdEKh6b0AFpbUHT8FoDa(Type type)
	{
		return type.IsSimpleType();
	}

	internal static bool Mn79ENb07IKF2WIafijG(Type type)
	{
		return type.IsIdentifiedType();
	}

	internal static object dpEQnWb0xkhki0BaPV1d(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object f2THF8b00n8akfDjewAt(object P_0, object P_1)
	{
		return Expression.Call((MethodInfo)P_0, (Expression)P_1);
	}

	internal static void R17if8b0mw9b9Cym0ZVt(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object zL5GDxb0y1WmEN9HNhvn(object P_0, object P_1)
	{
		return Expression.Assign((Expression)P_0, (Expression)P_1);
	}

	internal static object Sx1apub0MXZrb7lAKYIu(object P_0)
	{
		return ((IIdentified)P_0).GetId();
	}

	internal static object e0AdMkb0JVa2kHDnmA4l()
	{
		return Logger.Log;
	}

	internal static object VMvTNXb09F0FLuxIjmrj(object P_0)
	{
		return ((Exception)P_0).Message;
	}

	internal static bool u0WkyMb0d0yo3hdSviuJ(object P_0)
	{
		return ((IEntity)P_0).IsNew();
	}

	internal static object qZy6CAb0lHa17quDCLyX(Type type)
	{
		return TypeParamToString(type);
	}

	internal static EntityMetadataType a7b5yFb0rSOkTOMr9GGX(object P_0)
	{
		return ((EntityMetadata)P_0).Type;
	}

	internal static void G07GOwb0gqiqe4SA4PQt()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object sxvXecb05ZbUxG0q7H0f(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object IqunObb0jwUUfS3wS4Ps(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object ItTTupb0Y6tdLUKNT6Bq(object P_0, object P_1, object P_2)
	{
		return Expression.Call((Expression)P_0, (MethodInfo)P_1, (Expression[])P_2);
	}
}
