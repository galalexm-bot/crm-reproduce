using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using EleWise.ELMA.Actions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.SDK;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.CodeGeneration.PublicApi;

[Component(Order = 1000)]
public class PublicApiNodeEntityProvider : IPublicApiNodeProvider
{
	private class TypesAndMetadataBindingModel
	{
		internal static object JH0SPDvpfCqoKUatK30y;

		public Type ManagerType
		{
			[CompilerGenerated]
			get
			{
				return _003CManagerType_003Ek__BackingField;
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
						_003CManagerType_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
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

		public Type EntityType
		{
			[CompilerGenerated]
			get
			{
				return _003CEntityType_003Ek__BackingField;
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
						_003CEntityType_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
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

		public TypesAndMetadataBindingModel()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.PushGlobal();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool OENBUTvpQpyohdPMJGiF()
		{
			return JH0SPDvpfCqoKUatK30y == null;
		}

		internal static TypesAndMetadataBindingModel KKdjs9vpCKkyDqulQWjI()
		{
			return (TypesAndMetadataBindingModel)JH0SPDvpfCqoKUatK30y;
		}
	}

	private static readonly IList<string> ObsoleteNodes;

	private static object managerTypesInitLock;

	private static ConcurrentDictionary<Type, Type> managerTypes;

	private static PublicApiNodeEntityProvider xnqZ2khHLrQoCeKTgikc;

	[IteratorStateMachine(typeof(_003CCreatePublicApiNodes_003Ed__0))]
	public IEnumerable<IPublicApiNode> CreatePublicApiNodes()
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CCreatePublicApiNodes_003Ed__0(-2);
	}

	public static IEnumerable<IPublicApiNode> BuildObjectsTree(string parentPath, string groupName)
	{
		MetadataTreeHelper.GroupNode groupByName = MetadataTreeHelper.GetGroupByName(MetadataTreeHelper.BuildTree(GetEntityObjectsToTree(), showDisplayName: false, showEmptyGroups: false, generateForPublicApi: true), groupName);
		return BuildObjectsTree(parentPath, groupByName);
	}

	public static IEnumerable<IPublicApiNode> BuildObjectsTree(string parentPath, MetadataTreeHelper.GroupNode groupNode)
	{
		if (groupNode == null)
		{
			return Enumerable.Empty<IPublicApiNode>();
		}
		return BuildObjectsTree(parentPath, groupNode, GetEntityObjects(), hidden: false);
	}

	[IteratorStateMachine(typeof(_003CBuildObjectsTree_003Ed__5))]
	private static IEnumerable<IPublicApiNode> BuildObjectsTree(object parentPath, object groupTreeNode, IEnumerable<EntityMetadata> metadataList, bool hidden)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CBuildObjectsTree_003Ed__5(-2)
		{
			_003C_003E3__parentPath = (string)parentPath,
			_003C_003E3__groupTreeNode = (MetadataTreeHelper.GroupNode)groupTreeNode,
			_003C_003E3__metadataList = metadataList,
			_003C_003E3__hidden = hidden
		};
	}

	[IteratorStateMachine(typeof(_003CUserObject_003Ed__6))]
	private static IEnumerable<IPublicApiNode> UserObject(object parentPath, object metadata)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CUserObject_003Ed__6(-2)
		{
			_003C_003E3__parentPath = (string)parentPath,
			_003C_003E3__metadata = (EntityMetadata)metadata
		};
	}

	private static ISyntaxNode ManagerReferenceCode(object type)
	{
		return ((ISyntaxNode)qmxMpMhAFEkCaC9c0RyA(D8HeBkhHcr94BhJcaSDD(EleWise.ELMA.SDK.TypeOf.Locator).CreateTypeSyntax(), ((string)D8JDWlhHzqintGZnpKwv(-35995181 ^ -36063455)).GenericName((ISyntaxNode)type))).InvocationExpression();
	}

	[IteratorStateMachine(typeof(_003CTableParts_003Ed__8))]
	public static IEnumerable<IPublicApiNode> TableParts(string parentPath, EntityMetadata parentMetadata)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CTableParts_003Ed__8(-2)
		{
			_003C_003E3__parentPath = parentPath,
			_003C_003E3__parentMetadata = parentMetadata
		};
	}

	[IteratorStateMachine(typeof(_003CTableParts_003Ed__9))]
	public static IEnumerable<IPublicApiNode> TableParts(string parentPath, Type type)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CTableParts_003Ed__9(-2)
		{
			_003C_003E3__parentPath = parentPath,
			_003C_003E3__type = type
		};
	}

	[IteratorStateMachine(typeof(_003CTablePart_003Ed__10))]
	private static IEnumerable<IPublicApiNode> TablePart(object parentPath, object metadata)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CTablePart_003Ed__10(-2)
		{
			_003C_003E3__parentPath = (string)parentPath,
			_003C_003E3__metadata = (EntityMetadata)metadata
		};
	}

	public static ISyntaxNode GetManagerReferenceCode(ISyntaxNode type)
	{
		return ((ISyntaxNode)qmxMpMhAFEkCaC9c0RyA(EleWise.ELMA.SDK.TypeOf.Locator.Raw.CreateTypeSyntax(), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x10E41EDB ^ 0x10E76829).GenericName(type))).InvocationExpression();
	}

	public static MethodInfo[] InvokeMethods(Type type)
	{
		return (from m in type.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.InvokeMethod)
			where AttributeHelper<PublicApiMemberAttribute>.GetAttribute(m, inherited: false) != null
			where AttributeHelper<PublicApiNodeIdAttribute>.GetAttribute(m, inherited: false) == null
			select m).ToArray();
	}

	public static IEnumerable<IPublicApiNode> InvokeMethods(string parentPath, Type managerType, params TypeArgument[] typeArguments)
	{
		return InvokeMethods(parentPath, managerType, (MethodInfo m) => true, typeArguments);
	}

	[IteratorStateMachine(typeof(_003CInvokeMethods_003Ed__14))]
	public static IEnumerable<IPublicApiNode> InvokeMethods(string parentPath, Type managerType, Func<MethodInfo, bool> exceptFunc, params TypeArgument[] typeArguments)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CInvokeMethods_003Ed__14(-2)
		{
			_003C_003E3__parentPath = parentPath,
			_003C_003E3__managerType = managerType,
			_003C_003E3__exceptFunc = exceptFunc,
			_003C_003E3__typeArguments = typeArguments
		};
	}

	private static IEnumerable<EntityMetadata> GetEntityObjects()
	{
		return PublicApiCodeGenerator.Current.GetAllMetadata().OfType<EntityMetadata>().Where(delegate(EntityMetadata m)
		{
			//Discarded unreachable code: IL_0068, IL_0077
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (!_003C_003Ec.vwMM8rvpR6XXp89FX1MS(_003C_003Ec.YlVCsZvpi2JpTVFJarnJ(), m))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
						{
							num2 = 1;
						}
						break;
					}
					goto default;
				default:
					return !_003C_003Ec.g43TgxvpksGQqj5MpYc4(PublicApiCodeGenerator.Current, m);
				case 1:
					return false;
				}
			}
		})
			.ToArray();
	}

	public static IEnumerable<ICodeItemMetadata> GetEntityObjectsToTree()
	{
		return ((IEnumerable<ICodeItemMetadata>)(from m in GetEntityObjects()
			orderby m.DisplayName
			select m)).ToArray();
	}

	public static Type GetManagerType(Type entityType)
	{
		//Discarded unreachable code: IL_0095, IL_0130, IL_0289, IL_02c1
		int num = 1;
		DefaultManagerAttribute defaultManagerAttribute = default(DefaultManagerAttribute);
		Type value = default(Type);
		bool lockTaken = default(bool);
		object obj = default(object);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					if (!entityType.IsInterface)
					{
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
						{
							num2 = 7;
						}
						continue;
					}
					goto case 10;
				case 13:
					defaultManagerAttribute = AttributeHelper<DefaultManagerAttribute>.GetAttribute(entityType, inherited: true);
					num = 4;
					break;
				case 4:
					if (defaultManagerAttribute == null)
					{
						num2 = 5;
						continue;
					}
					goto case 7;
				case 8:
					return value;
				case 12:
					value = hna0eGhAWOcfXWh2X1ha(defaultManagerAttribute, entityType);
					num = 11;
					break;
				case 6:
					lockTaken = false;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
					{
						num2 = 2;
					}
					continue;
				case 1:
					if (managerTypes == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 3;
				case 2:
					try
					{
						Monitor.Enter(obj, ref lockTaken);
						int num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
						{
							num3 = 1;
						}
						while (true)
						{
							switch (num3)
							{
							case 1:
								if (managerTypes == null)
								{
									num3 = 2;
									continue;
								}
								break;
							case 2:
								managerTypes = new ConcurrentDictionary<Type, Type>((from type in ((ComponentManager)OV0KajhABNRCZBWBPwLI()).GetExtensionPointTypes(typeof(IEntityManager))
									select new
									{
										type = type,
										entityManager = type.GetInterface(EleWise.ELMA.SDK.TypeOf.IEntityManager1.Raw.FullName)
									} into t
									where t.entityManager != null
									group t by t.entityManager.GetGenericArguments()[0]).ToDictionary(t => t.Key, t => (from tt in t
									select tt.type into tt
									where AttributeHelper<ObsoleteAttribute>.GetAttribute(tt, inherited: false) == null
									select tt).LastOrDefault()));
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
								{
									num3 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
					finally
					{
						if (lockTaken)
						{
							int num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
							{
								num4 = 0;
							}
							while (true)
							{
								switch (num4)
								{
								default:
									Monitor.Exit(obj);
									num4 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
									{
										num4 = 1;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
					goto case 3;
				case 7:
				case 9:
					if (defaultManagerAttribute != null)
					{
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
						{
							num2 = 12;
						}
						continue;
					}
					goto case 11;
				case 11:
					managerTypes[entityType] = value;
					num2 = 8;
					continue;
				default:
					obj = managerTypesInitLock;
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
					{
						num2 = 6;
					}
					continue;
				case 3:
					if (!managerTypes.TryGetValue(entityType, out value))
					{
						num2 = 13;
						continue;
					}
					goto case 8;
				case 10:
					defaultManagerAttribute = (from intf in entityType.GetInterfaces()
						select AttributeHelper<DefaultManagerAttribute>.GetAttribute(intf, inherited: false)).FirstOrDefault((DefaultManagerAttribute attr) => attr != null);
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
					{
						num2 = 9;
					}
					continue;
				}
				break;
			}
		}
	}

	public static IEnumerable<Type> GetManagerTypes()
	{
		return Locator.GetServiceNotNull<IEntityManagerTypesStorage>().GetManagerTypes().ToArray();
	}

	public static IEnumerable<IPublicApiNode> Members<T, TManager>(string parentPath, bool skipTableParts = false, bool skipTypeUid = false) where T : IEntity where TManager : IEntityManager<T>
	{
		return Members(parentPath, TypeOf<T>.Raw, TypeOf<TManager>.Raw, skipTableParts, skipTypeUid);
	}

	[IteratorStateMachine(typeof(_003CMembers_003Ed__22))]
	private static IEnumerable<IPublicApiNode> Members(object parentPath, Type type, Type managerType, bool skipTableParts = false, bool skipTypeUid = false)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CMembers_003Ed__22(-2)
		{
			_003C_003E3__parentPath = (string)parentPath,
			_003C_003E3__type = type,
			_003C_003E3__managerType = managerType,
			_003C_003E3__skipTableParts = skipTableParts,
			_003C_003E3__skipTypeUid = skipTypeUid
		};
	}

	public PublicApiNodeEntityProvider()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		hFoU3xhAoYvAEsF4xcvy();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static PublicApiNodeEntityProvider()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				return;
			case 1:
				hFoU3xhAoYvAEsF4xcvy();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				managerTypesInitLock = new object();
				num2 = 3;
				continue;
			}
			ObsoleteNodes = new string[9]
			{
				(string)D8JDWlhHzqintGZnpKwv(0x4D1C1EE4 ^ 0x4D1F658E),
				z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x66F566B6 ^ 0x66F61DCE),
				z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4D1C1EE4 ^ 0x4D1F657C),
				(string)D8JDWlhHzqintGZnpKwv(0x4EDCBA32 ^ 0x4EDFC19E),
				(string)D8JDWlhHzqintGZnpKwv(0x92F12D5 ^ 0x92C691F),
				z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978553574),
				(string)D8JDWlhHzqintGZnpKwv(-541731959 ^ -541675625),
				(string)D8JDWlhHzqintGZnpKwv(-1886646897 ^ -1886424637),
				z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1824388195 ^ -1824426007)
			};
			num2 = 2;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
			{
				num2 = 1;
			}
		}
	}

	internal static Type D8HeBkhHcr94BhJcaSDD(object P_0)
	{
		return ((RipeType)P_0).Raw;
	}

	internal static object D8JDWlhHzqintGZnpKwv(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object qmxMpMhAFEkCaC9c0RyA(object P_0, object P_1)
	{
		return ((ISyntaxNode)P_0).MemberAccessExpression((ISyntaxNode)P_1);
	}

	internal static bool McewQahHUWDv6xvKAjbG()
	{
		return xnqZ2khHLrQoCeKTgikc == null;
	}

	internal static PublicApiNodeEntityProvider i6qPY0hHsL6F7gcpj6YY()
	{
		return xnqZ2khHLrQoCeKTgikc;
	}

	internal static object OV0KajhABNRCZBWBPwLI()
	{
		return ComponentManager.Current;
	}

	internal static Type hna0eGhAWOcfXWh2X1ha(object P_0, Type objectType)
	{
		return ((DefaultManagerAttribute)P_0).GetManagerType(objectType);
	}

	internal static void hFoU3xhAoYvAEsF4xcvy()
	{
		SingletonReader.PushGlobal();
	}
}
