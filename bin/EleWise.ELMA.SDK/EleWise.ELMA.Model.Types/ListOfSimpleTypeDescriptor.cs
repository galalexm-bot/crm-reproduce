using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.Collections;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.MetadataInternalContainer.Containers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Groups;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH.CustomTypes;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using Iesi.Collections.Generic;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Types;

public class ListOfSimpleTypeDescriptor : CLRTypeDescriptor<object, ListOfSimpleTypeSettings>, IMappingTypeDescriptor
{
	public const string UID_S = "{5C281E64-DDC8-4BC9-991A-84D9DC4E7649}";

	public static readonly Guid UID;

	internal static ListOfSimpleTypeDescriptor cxAu21oxIVfEp2BOreyp;

	public override Guid Uid => UID;

	public override string Name => (string)OmRr8FoxRtZJTKUp4qly(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740433930));

	public override Guid ParentUid => SystemTypesDescriptor.UID;

	public override Type RuntimeType => typeof(IList);

	protected override void ExtendSimplePropertyMapping(INHibernatePropertyTypeMapper mapper, EntityPropertyMetadata propertyMetadata)
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
				mapper.Type<XmlObjectSerializableType>();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				tqVhFLoxi2A2WfFAr2lB(this, mapper, propertyMetadata);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override bool IsVisibleForMetadata(ClassMetadata classMetadata)
	{
		//Discarded unreachable code: IL_003c, IL_004b
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return MetadataAccessInfo.EnvironmentType == MetadataEnvironmentType.DevServer;
			default:
				return true;
			case 3:
				if (MetadataAccessInfo.EnvironmentType != MetadataEnvironmentType.VisualStudio)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto default;
			case 1:
				if (classMetadata is EntityFilterMetadata)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			}
		}
	}

	public override bool IsEmpty(PropertyMetadata propertyMetadata, object val)
	{
		//Discarded unreachable code: IL_00c2, IL_00d9
		int num = 7;
		ICollection collection = default(ICollection);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
					if (propertyMetadata == null)
					{
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
						{
							num2 = 6;
						}
						break;
					}
					if ((ListOfSimpleTypeSettings)propertyMetadata.Settings != null)
					{
						num2 = 3;
						break;
					}
					goto case 4;
				case 1:
					if (collection == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
						{
							num2 = 0;
						}
						break;
					}
					if (!collection.Cast<object>().All((object v) => v == null))
					{
						goto end_IL_0012;
					}
					goto case 5;
				case 6:
					return true;
				case 4:
					return true;
				case 3:
					collection = val as ICollection;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
					{
						num2 = 1;
					}
					break;
				case 5:
					return true;
				case 2:
					return false;
				default:
					return true;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 2;
		}
	}

	public override ISyntaxNode GetPropertyTypeReference(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter)
	{
		//Discarded unreachable code: IL_00a6
		int num = 2;
		int num2 = num;
		Type itemSimpleType = default(Type);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (PLWIcCoxqJHhYJ6dDaTy(itemSimpleType, null))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			case 2:
				itemSimpleType = GetItemSimpleType(propertyMetadata);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				return (ISyntaxNode)lqqh7loxKRgiKQsKYxrw(TypeOf<List<object>>.Raw);
			default:
				return plDcAboxXwvRaKR00MNv(TypeOf.List).CreateTypeSyntax((ISyntaxNode)lqqh7loxKRgiKQsKYxrw(itemSimpleType));
			}
		}
	}

	public override IPropertyDefaultValueContainer GetDefaultContainer(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter = false)
	{
		//Discarded unreachable code: IL_004c, IL_005b
		int num = 2;
		Type itemSimpleType = default(Type);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (PLWIcCoxqJHhYJ6dDaTy(itemSimpleType, null))
					{
						goto end_IL_0012;
					}
					goto default;
				case 2:
					itemSimpleType = GetItemSimpleType(propertyMetadata);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
					{
						num2 = 1;
					}
					break;
				default:
					return new PropertyListValueContainer(TypeOf<object>.Raw);
				case 3:
					return new PropertyListValueContainer(itemSimpleType);
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 3;
		}
	}

	public override ISyntaxNode GetPropertyInitExpression(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter = false)
	{
		return ((ISyntaxNode)TC4iNXoxTHOPKC3WkhPu(this, classMetadata, propertyMetadata, forFilter)).ObjectCreationExpression();
	}

	public override TypeSettings CreateSettingsForFilterProperty(PropertyMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_007a, IL_0089
		int num = 2;
		ListOfSimpleTypeSettings listOfSimpleTypeSettings2 = default(ListOfSimpleTypeSettings);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (propertyMetadata.Settings != null)
					{
						goto end_IL_0012;
					}
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
					{
						num2 = 4;
					}
					break;
				case 3:
				{
					ListOfSimpleTypeSettings listOfSimpleTypeSettings = new ListOfSimpleTypeSettings();
					M2FfVmoxn8H47u7teFMp(listOfSimpleTypeSettings, nNduOVoxk3FV6p1hblBh(listOfSimpleTypeSettings2));
					IRn50Mox2yB3d6awhQt3(listOfSimpleTypeSettings, RjjQBeoxOrp6oeVs2Qyx(listOfSimpleTypeSettings2));
					return listOfSimpleTypeSettings;
				}
				case 2:
					if (propertyMetadata == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto default;
				case 1:
				case 4:
					return null;
				}
				continue;
				end_IL_0012:
				break;
			}
			listOfSimpleTypeSettings2 = (ListOfSimpleTypeSettings)propertyMetadata.Settings;
			num = 3;
		}
	}

	public override void ApplyFilterValue(ICriteria criteria, EntityMetadata metadata, EntityPropertyMetadata propertyMetadata, object value, string alias)
	{
		//Discarded unreachable code: IL_00dd, IL_00ec, IL_00fb
		int num = 2;
		int num2 = num;
		ICollection collection = default(ICollection);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 7:
				gGRo76oxPe7aVxDm9lNp(criteria, Restrictions.In(propertyMetadata.Name, collection));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
				{
					num2 = 0;
				}
				continue;
			case 0:
				return;
			case 6:
				return;
			case 5:
				return;
			case 1:
				collection = value as ICollection;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
				{
					num2 = 3;
				}
				continue;
			case 2:
				if (value == null)
				{
					return;
				}
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
				{
					num2 = 1;
				}
				continue;
			case 3:
				if (collection == null)
				{
					num2 = 6;
					continue;
				}
				break;
			case 4:
				break;
			}
			if (cgsHvxoxedEFPrT2t8UE(collection) <= 0)
			{
				break;
			}
			num2 = 7;
		}
	}

	public override IDictionary<string, object> Serialize(object obj, ClassMetadata metadata, PropertyMetadata propertyMetadata, EntitySerializationSettings settings)
	{
		if (obj == null)
		{
			return null;
		}
		Contract.ArgumentNotNull(metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x571EA399 ^ 0x571EEAA7));
		Contract.ArgumentNotNull(propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2A7797B7 ^ 0x2A77DEE5));
		obj = obj.CastAsRealType();
		PropertyInfo property = obj.GetProperty(metadata, propertyMetadata);
		if (property == null || !property.CanRead)
		{
			return null;
		}
		object value = property.GetValue(obj, null);
		SerializableDictionary<string, object> serializableDictionary = new SerializableDictionary<string, object>();
		if (value is IEnumerable source)
		{
			IEnumerable<object> enumerable = source.Cast<object>();
			SerializableList<object> serializableList = new SerializableList<object>();
			if (enumerable.Any())
			{
				Type type = CheckPropertyType(property.PropertyType);
				if (type != null && type != typeof(object) && (type == typeof(string) || type.IsPrimitive || type.IsValueType))
				{
					IMetadataRuntimeService service = Locator.GetService<IMetadataRuntimeService>();
					if (service != null && service.GetTypeDescriptor(type) is TypeDescriptor typeDescriptor)
					{
						foreach (object item2 in enumerable)
						{
							object item = typeDescriptor.SerializeSimple(item2, type, settings);
							serializableList.Add(item);
						}
						serializableDictionary[propertyMetadata.Name] = serializableList;
					}
				}
			}
			serializableDictionary[propertyMetadata.Name] = serializableList;
		}
		return serializableDictionary;
	}

	public override void Deserialize(object obj, [NotNull] ClassMetadata metadata, [NotNull] PropertyMetadata propertyMetadata, IDictionary<string, object> values)
	{
		if (obj == null || values == null)
		{
			return;
		}
		if (metadata == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97953432));
		}
		if (propertyMetadata == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4D1C1EE4 ^ 0x4D1C57B6));
		}
		obj = obj.CastAsRealType();
		PropertyInfo property = obj.GetProperty(metadata, propertyMetadata);
		if (property == null || !property.CanWrite)
		{
			return;
		}
		Type propertyType = property.PropertyType;
		string name = propertyMetadata.Name;
		Type type = CheckPropertyType(propertyType);
		if (!(type != null) || !(type != typeof(object)) || (!(type == typeof(string)) && !type.IsPrimitive && !type.IsValueType && !(type == typeof(FormViewItem))) || !values.TryGetValue(name, out var value))
		{
			return;
		}
		try
		{
			if (!(value is ICollection collection))
			{
				return;
			}
			List<object> list = new List<object>();
			foreach (object item2 in collection)
			{
				object item = DeserializeSimple(item2, type);
				list.Add(item);
			}
			if (IsIEnumerableTOrArray(propertyType))
			{
				Array array = Array.CreateInstance(type, list.Count);
				for (int i = 0; i < list.Count; i++)
				{
					((IList)array)[i] = list[i];
				}
				property.SetValue(obj, array, null);
				return;
			}
			IEnumerable enumerable = (IEnumerable)property.GetValue(obj, null);
			if (enumerable == null)
			{
				if (propertyType.IsInterface)
				{
					Type genericTypeDefinition = propertyType.GetGenericTypeDefinition();
					if (genericTypeDefinition == typeof(ICollection<>) || genericTypeDefinition == typeof(IList<>))
					{
						enumerable = (IEnumerable)Activator.CreateInstance(typeof(List<>).MakeGenericType(propertyType.GetGenericArguments()));
					}
					if (genericTypeDefinition == typeof(ISet<>))
					{
						enumerable = (IEnumerable)Activator.CreateInstance(typeof(HashSet<>).MakeGenericType(propertyType.GetGenericArguments()));
					}
					if (genericTypeDefinition == typeof(ISet<>))
					{
						enumerable = (IEnumerable)Activator.CreateInstance(typeof(HashedSet<>).MakeGenericType(propertyType.GetGenericArguments()));
					}
				}
				else
				{
					enumerable = (IEnumerable)Activator.CreateInstance(propertyType.GetGenericTypeDefinition().MakeGenericType(type));
				}
				property.SetValue(obj, enumerable, null);
			}
			UntypedICollectionProxy untypedICollectionProxy = enumerable.AsUntypedICollection();
			untypedICollectionProxy.Clear();
			foreach (object item3 in list)
			{
				untypedICollectionProxy.Add(item3);
			}
			property.SetValue(obj, enumerable, null);
		}
		catch
		{
		}
	}

	public override object DeserializeSimple(object value, Type deserializeToType)
	{
		//Discarded unreachable code: IL_0120, IL_015e, IL_0186
		int num = 5;
		TypeDescriptor typeDescriptor = default(TypeDescriptor);
		IMetadataRuntimeService service = default(IMetadataRuntimeService);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 11:
					typeDescriptor = pQwJeIoxpttgZa9aqL6x(service, deserializeToType) as TypeDescriptor;
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
					{
						num2 = 12;
					}
					continue;
				case 5:
					if (value == null)
					{
						num = 4;
						break;
					}
					if (!(deserializeToType == null))
					{
						if (!PLWIcCoxqJHhYJ6dDaTy(deserializeToType, kZnn0FoxNabgmibLYvio(typeof(object).TypeHandle)))
						{
							num2 = 3;
							continue;
						}
						goto case 14;
					}
					num2 = 8;
					continue;
				default:
					service = Locator.GetService<IMetadataRuntimeService>();
					num2 = 13;
					continue;
				case 8:
					throw new ArgumentNullException((string)A760MWox1ivxFHj2CX77(-105199646 ^ -105214362));
				case 13:
					if (service == null)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto case 11;
				case 1:
					if (aYAUuIox3tKb0A8679xj(deserializeToType, kZnn0FoxNabgmibLYvio(typeof(FormViewItem).TypeHandle)))
					{
						num2 = 9;
						continue;
					}
					goto case 3;
				case 14:
					if (deserializeToType == kZnn0FoxNabgmibLYvio(typeof(string).TypeHandle))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 2;
				case 2:
					if (!deserializeToType.IsPrimitive)
					{
						num = 7;
						break;
					}
					goto default;
				case 10:
					return kLhfCuoxai2Ttw4cmrWB(typeDescriptor, value, deserializeToType);
				case 3:
				case 6:
					return null;
				case 12:
					if (typeDescriptor != null)
					{
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
						{
							num2 = 9;
						}
						continue;
					}
					goto case 3;
				case 4:
					throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 0x4F7F7B64));
				case 7:
					if (!deserializeToType.IsValueType)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto default;
				}
				break;
			}
		}
	}

	internal Type GetItemSimpleType(IPropertyMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_00a2, IL_00b1, IL_00c0, IL_0167
		int num = 4;
		int num2 = num;
		Type firstGenericType = default(Type);
		ITypeDescriptor typeDescriptor = default(ITypeDescriptor);
		ListOfSimpleTypeSettings listOfSimpleTypeSettings = default(ListOfSimpleTypeSettings);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 2:
				firstGenericType = GetFirstGenericType(typeDescriptor.GetType());
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
				{
					num2 = 6;
				}
				break;
			case 9:
				if (listOfSimpleTypeSettings.SimpleTypeUid != Guid.Empty)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 7;
			case 6:
				if (!PLWIcCoxqJHhYJ6dDaTy(firstGenericType, null))
				{
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 5;
			case 4:
				if (propertyMetadata == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
					{
						num2 = 3;
					}
					break;
				}
				obj = EGPI7EoxD3ovhXsL5flV(propertyMetadata);
				goto IL_0172;
			default:
				if (typeDescriptor == null)
				{
					num2 = 8;
					break;
				}
				goto case 2;
			case 1:
				typeDescriptor = ((IMetadataService)BXlUahoxtSG8ZusIutsL()).GetTypeDescriptor(RjjQBeoxOrp6oeVs2Qyx(listOfSimpleTypeSettings), Guid.Empty);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				return firstGenericType.GetGenericArguments()[0];
			case 7:
			case 8:
				return null;
			case 3:
				{
					obj = null;
					goto IL_0172;
				}
				IL_0172:
				if ((listOfSimpleTypeSettings = obj as ListOfSimpleTypeSettings) != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
					{
						num2 = 9;
					}
					break;
				}
				goto case 7;
			}
		}
	}

	private bool IsIEnumerableTOrArray(Type propertyType)
	{
		//Discarded unreachable code: IL_0035, IL_0044, IL_0080
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				return true;
			case 3:
				if (!IsIEnumerableT(propertyType))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				return true;
			default:
				return false;
			case 4:
				if (!propertyType.IsArray)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			}
		}
	}

	private bool IsIEnumerableT(Type propertyType)
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!propertyType.IsGenericType)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				return propertyType.GetGenericTypeDefinition() == kZnn0FoxNabgmibLYvio(typeof(IEnumerable<>).TypeHandle);
			default:
				return false;
			}
		}
	}

	private Type CheckPropertyType(Type propertyType)
	{
		//Discarded unreachable code: IL_0085, IL_0094
		int num = 4;
		Type[] genericArguments = default(Type[]);
		Type[] genericArguments2 = default(Type[]);
		Type @interface = default(Type);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (genericArguments.Any())
					{
						num2 = 5;
						break;
					}
					goto case 6;
				case 3:
					genericArguments2 = propertyType.GetGenericArguments();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
					{
						num2 = 1;
					}
					break;
				case 7:
					return genericArguments2[0];
				case 1:
					if (genericArguments2.Any())
					{
						num2 = 7;
						break;
					}
					goto IL_00a4;
				default:
					@interface = propertyType.GetInterface(kZnn0FoxNabgmibLYvio(typeof(IEnumerable<>).TypeHandle).FullName);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
					{
						num2 = 9;
					}
					break;
				case 10:
					genericArguments = @interface.GetGenericArguments();
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
					{
						num2 = 2;
					}
					break;
				case 4:
					if (IsIEnumerableT(propertyType))
					{
						num2 = 3;
						break;
					}
					goto IL_00a4;
				case 5:
					return genericArguments[0];
				case 6:
					return null;
				case 9:
					if (@interface != null)
					{
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
						{
							num2 = 8;
						}
						break;
					}
					goto case 6;
				case 8:
					{
						if (!propertyType.IsArray)
						{
							num2 = 6;
							break;
						}
						goto default;
					}
					IL_00a4:
					if (!propertyType.IsGenericType)
					{
						goto end_IL_0012;
					}
					goto default;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 8;
		}
	}

	protected override ColumnType GetDbColumnType(EntityMetadata entityMetadata, EntityPropertyMetadata propertyMetadata)
	{
		return new ColumnType(DbType.Binary);
	}

	public Type GetFirstGenericType(Type type)
	{
		//Discarded unreachable code: IL_0089, IL_0098
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					return type;
				default:
					if (!PLWIcCoxqJHhYJ6dDaTy(type.BaseType, null))
					{
						return null;
					}
					goto end_IL_0012;
				case 3:
					return GetFirstGenericType(type.BaseType);
				case 2:
					if (aYAUuIox3tKb0A8679xj(type.GetGenericTypeDefinition(), typeof(TypeDescriptor<>)))
					{
						num2 = 4;
						break;
					}
					goto default;
				case 1:
					if (!type.IsGenericType)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 3;
		}
	}

	public ListOfSimpleTypeDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		q7DWDNoxwyj7QgLbmDU6();
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

	static ListOfSimpleTypeDescriptor()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				UID = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x637E299B ^ 0x637CA3CF));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				q7DWDNoxwyj7QgLbmDU6();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static void tqVhFLoxi2A2WfFAr2lB(object P_0, object P_1, object P_2)
	{
		((SimpleTypeDescriptor<object>)P_0).ExtendSimplePropertyMapping((INHibernatePropertyTypeMapper)P_1, (EntityPropertyMetadata)P_2);
	}

	internal static bool fsQOIZoxVbHPJ1L1ey1F()
	{
		return cxAu21oxIVfEp2BOreyp == null;
	}

	internal static ListOfSimpleTypeDescriptor En1qlqoxSGJ3jkCUjaVT()
	{
		return cxAu21oxIVfEp2BOreyp;
	}

	internal static object OmRr8FoxRtZJTKUp4qly(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool PLWIcCoxqJHhYJ6dDaTy(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static object lqqh7loxKRgiKQsKYxrw(Type type)
	{
		return type.CreateTypeSyntax();
	}

	internal static Type plDcAboxXwvRaKR00MNv(object P_0)
	{
		return ((RipeType)P_0).Raw;
	}

	internal static object TC4iNXoxTHOPKC3WkhPu(object P_0, object P_1, object P_2, bool forFilter)
	{
		return ((TypeDescriptor)P_0).GetPropertyTypeReference((ClassMetadata)P_1, (PropertyMetadata)P_2, forFilter);
	}

	internal static object nNduOVoxk3FV6p1hblBh(object P_0)
	{
		return ((SimpleTypeSettings)P_0).FieldName;
	}

	internal static void M2FfVmoxn8H47u7teFMp(object P_0, object P_1)
	{
		((SimpleTypeSettings)P_0).FieldName = (string)P_1;
	}

	internal static Guid RjjQBeoxOrp6oeVs2Qyx(object P_0)
	{
		return ((ListOfSimpleTypeSettings)P_0).SimpleTypeUid;
	}

	internal static void IRn50Mox2yB3d6awhQt3(object P_0, Guid value)
	{
		((ListOfSimpleTypeSettings)P_0).SimpleTypeUid = value;
	}

	internal static int cgsHvxoxedEFPrT2t8UE(object P_0)
	{
		return ((ICollection)P_0).Count;
	}

	internal static object gGRo76oxPe7aVxDm9lNp(object P_0, object P_1)
	{
		return ((ICriteria)P_0).Add((ICriterion)P_1);
	}

	internal static object A760MWox1ivxFHj2CX77(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static Type kZnn0FoxNabgmibLYvio(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool aYAUuIox3tKb0A8679xj(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static object pQwJeIoxpttgZa9aqL6x(object P_0, Type runtimeType)
	{
		return ((IMetadataService)P_0).GetTypeDescriptor(runtimeType);
	}

	internal static object kLhfCuoxai2Ttw4cmrWB(object P_0, object P_1, Type deserializeToType)
	{
		return ((TypeDescriptor)P_0).DeserializeSimple(P_1, deserializeToType);
	}

	internal static object EGPI7EoxD3ovhXsL5flV(object P_0)
	{
		return ((IPropertyMetadata)P_0).Settings;
	}

	internal static object BXlUahoxtSG8ZusIutsL()
	{
		return MetadataServiceContext.Service;
	}

	internal static void q7DWDNoxwyj7QgLbmDU6()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
