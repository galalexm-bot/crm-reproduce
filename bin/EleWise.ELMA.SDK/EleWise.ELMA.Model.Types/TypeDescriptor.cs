using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using EleWise.ELMA.API.Models;
using EleWise.ELMA.Common;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.FullTextSearch.Descriptors;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Db;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.MetadataInternalContainer.Containers;
using EleWise.ELMA.Model.Types.Helpers;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Types;

[Component]
public abstract class TypeDescriptor : IMappingTypeDescriptor, ITypeDescriptor, IXsiType, ITypeGenerationInfo, IPropertyTypeInfo, IDbTypeInfo, IFilterableType, IFullTextTypeDescriptor, ISerializableTypeDescriptor, IPropertyCompareTypeDescriptor, IFormatTypeDescriptor, ICopyableTypeDescriptor, ILoggerEnabledComponent, IPublicApplicationTypeDescriptor, ISortedProperty, IEditPropertyTableAvailibility, IUseEntityFilterOnly
{
	[NonSerialized]
	private ILogger _logger;

	private IFullTextPropertyDescriptor propertyDescriptor;

	internal static TypeDescriptor pYoQYTo0ARPoTKxsLhtM;

	[XmlIgnore]
	public ILogger Logger
	{
		get
		{
			return _logger;
		}
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
					_logger = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
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

	public virtual CopyAction CopyAction => CopyAction.Default;

	[XmlIgnore]
	public IRuntimeApplication RuntimeApplication
	{
		[CompilerGenerated]
		get
		{
			return _003CRuntimeApplication_003Ek__BackingField;
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
					_003CRuntimeApplication_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
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

	public abstract Guid Uid { get; }

	public abstract string Name { get; }

	public virtual bool Visible => true;

	public abstract Guid ParentUid { get; }

	public virtual bool IsGroup => false;

	public virtual Guid SubTypeUid => Guid.Empty;

	public virtual bool UseForId => false;

	public abstract bool UseForEntity { get; }

	public abstract bool CanBeNullable { get; }

	public abstract bool? DefaultNullableValue { get; }

	public virtual Type SettingsType => null;

	public virtual bool HasPropertyGetter => true;

	public virtual bool HasPropertySetter => true;

	public virtual bool AutoIncrementSupported => false;

	public virtual IFullTextPropertyDescriptor FullTextPropertyDescriptor
	{
		get
		{
			int num = 1;
			int num2 = num;
			IFullTextPropertyDescriptor fullTextPropertyDescriptor = default(IFullTextPropertyDescriptor);
			IFullTextPropertyDescriptor fullTextPropertyDescriptor2;
			while (true)
			{
				switch (num2)
				{
				default:
					fullTextPropertyDescriptor = (propertyDescriptor = new NoFullTextPropertyDescriptor());
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					fullTextPropertyDescriptor2 = propertyDescriptor;
					if (fullTextPropertyDescriptor2 != null)
					{
						break;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					fullTextPropertyDescriptor2 = fullTextPropertyDescriptor;
					break;
				}
				break;
			}
			return fullTextPropertyDescriptor2;
		}
	}

	public virtual bool UseEntityFilterOnly => false;

	public virtual bool IsAvailibleEditPropertyInTable => false;

	void IMappingTypeDescriptor.CreatePropertyMapping(INHibernatePropertiesMapper mappingBuilder, ClassMetadata metadata, EntityPropertyMetadata propertyMetadata)
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
				f3XiH2o00aROaNrmeih4(this, mappingBuilder, metadata, propertyMetadata);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	protected virtual void CreatePropertyMapping(INHibernatePropertiesMapper mappingBuilder, ClassMetadata metadata, EntityPropertyMetadata propertyMetadata)
	{
	}

	protected TypeDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				Logger = (ILogger)jDKDveo0m9ReQT681Zgi();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public abstract IEnumerable<ITypeDescriptor> GetSubTypes(ClassMetadata classMetadata);

	public virtual bool IsVisibleForMetadata(ClassMetadata classMetadata)
	{
		return true;
	}

	public virtual Guid GetFilterType(PropertyMetadata propertyMetadata, IMetadata entityMetadata)
	{
		return cFTaZ5o0yyuIsvWryPXH(this);
	}

	public virtual TypeSettings CreateSettingsForFilterProperty(PropertyMetadata propertyMetadata)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return null;
			case 1:
				if (propertyMetadata != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 2;
			}
			if (propertyMetadata.Settings == null)
			{
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			return ClassSerializationHelper.CloneObjectByXml((TypeSettings)DsNT07o0Mwxg5R8uVWNa(propertyMetadata));
		}
	}

	public virtual bool IsEmpty(PropertyMetadata propertyMetadata, object val)
	{
		return val == null;
	}

	public virtual bool IsEmptyOrDefault(PropertyMetadata propertyMetadata, object val)
	{
		return jfbuR8o0JaVVl0kQZpbH(this, propertyMetadata, val);
	}

	public virtual bool HasRealColumn(EntityMetadata entityMetadata, EntityPropertyMetadata propertyMetadata)
	{
		return true;
	}

	public abstract ISyntaxNode GetPropertyTypeReference(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter);

	public abstract ISyntaxNode GetPropertyInitExpression(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter = false);

	public abstract IPropertyDefaultValueContainer GetDefaultContainer(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter = false);

	public virtual IEnumerable<ISyntaxNode> GetPropertyGetterExpressions(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, string fieldName)
	{
		return null;
	}

	public virtual IEnumerable<ISyntaxNode> GetPropertySetterExpressions(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, string fieldName)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CGetAdditionalTypeMembers_003Ed__51))]
	public virtual IEnumerable<ISyntaxNode> GetAdditionalTypeMembers(ClassMetadata classMetadata, PropertyMetadata propertyMetadata)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CGetAdditionalTypeMembers_003Ed__51(-2);
	}

	public abstract string GetPropertyTypeDisplayName(PropertyMetadata propertyMetadata);

	public virtual string GetTypeDisplayName(Guid subTypeUid)
	{
		return (string)w4bq2qo09WYgadBlMUqC(this);
	}

	public abstract TypeDbStructures GetDbStructures(EntityMetadata entityMetadata, EntityPropertyMetadata propertyMetadata);

	public abstract bool ApplyDbChanges(IDbModelUpdater updater, EntityMetadata entityMetadata, EntityPropertyMetadata propertyMetadata, EntityPropertyMetadata oldPropertyMetadata);

	public virtual void ApplyFilterValue(ICriteria criteria, [NotNull] EntityMetadata metadata, [NotNull] EntityPropertyMetadata propertyMetadata, object value, string alias)
	{
		//Discarded unreachable code: IL_0041, IL_0050, IL_00ae, IL_00bd
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 6:
				return;
			default:
				throw new ArgumentNullException((string)VQ79B9o0duiDSjPyCec8(0x63ABA4E8 ^ 0x63ABEDD6));
			case 3:
				if (value == null)
				{
					num2 = 5;
					break;
				}
				sIAyVwo0jGJEaiTMjIFH(criteria, MLC5qZo05lxFcp8O3kKm(W4mpj0o0ll4ldKd0Qwa6(alias) ? E7pZfPo0rrUxiTXTu5x1(propertyMetadata) : MQoBBSo0gpI51K74ZviE(VQ79B9o0duiDSjPyCec8(0xD3DEF7E ^ 0xD3DAD7C), alias, E7pZfPo0rrUxiTXTu5x1(propertyMetadata)), value));
				num2 = 6;
				break;
			case 4:
				return;
			case 7:
				throw new ArgumentNullException((string)VQ79B9o0duiDSjPyCec8(-978351861 ^ -978337703));
			case 2:
				if (criteria == null)
				{
					num2 = 4;
					break;
				}
				goto case 3;
			case 1:
				if (metadata != null)
				{
					if (propertyMetadata != null)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
						{
							num2 = 2;
						}
						break;
					}
					goto case 7;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				return;
			}
		}
	}

	public virtual TypeSerializationDescriptor GetSerializeDescriptor([NotNull] ClassMetadata metadata, [NotNull] PropertyMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_0049, IL_0058, IL_014b, IL_0177
		int num = 3;
		int num2 = num;
		_003C_003Ec__DisplayClass62_0 _003C_003Ec__DisplayClass62_ = default(_003C_003Ec__DisplayClass62_0);
		string description = default(string);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 4:
				if (metadata == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
					{
						num2 = 0;
					}
					break;
				}
				if (_003C_003Ec__DisplayClass62_.propertyMetadata != null)
				{
					num2 = 7;
					break;
				}
				goto case 9;
			case 3:
				_003C_003Ec__DisplayClass62_ = new _003C_003Ec__DisplayClass62_0();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
				{
					num2 = 2;
				}
				break;
			case 5:
				return (TypeSerializationDescriptor)R1wwvtomFFNi8ETIG9TV(new TypeSerializationDescriptorBuilder().Description(description).Item(_003C_003Ec__DisplayClass62_._003CGetSerializeDescriptor_003Eb__0));
			default:
				throw new ArgumentNullException((string)VQ79B9o0duiDSjPyCec8(-210725949 ^ -210707715));
			case 9:
				throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6A81B9B4 ^ 0x6A81F0E6));
			case 7:
				if (!string.IsNullOrEmpty((string)OZhg1Jo0YlBanaSh8178(_003C_003Ec__DisplayClass62_.propertyMetadata)))
				{
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 1;
			case 1:
				obj = "";
				goto IL_01c1;
			case 2:
				_003C_003Ec__DisplayClass62_.propertyMetadata = propertyMetadata;
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
				{
					num2 = 4;
				}
				break;
			case 8:
				obj = SR.T((string)VQ79B9o0duiDSjPyCec8(-1765851862 ^ -1765952442), OZhg1Jo0YlBanaSh8178(_003C_003Ec__DisplayClass62_.propertyMetadata), StvIxto0L9vOiS2rvh2f(this, _003C_003Ec__DisplayClass62_.propertyMetadata));
				goto IL_01c1;
			case 6:
				{
					_003C_003Ec__DisplayClass62_.descr = (string)((!W4mpj0o0ll4ldKd0Qwa6(OZhg1Jo0YlBanaSh8178(_003C_003Ec__DisplayClass62_.propertyMetadata))) ? IJAfHco0zwF4LdPUkqrw(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-289714582 ^ -289814558), OZhg1Jo0YlBanaSh8178(_003C_003Ec__DisplayClass62_.propertyMetadata), RqkmY9o0cuIQZknlNuVZ(_003C_003Ec__DisplayClass62_.propertyMetadata), SR.T((string)VQ79B9o0duiDSjPyCec8(-1426094279 ^ -1426256239), StvIxto0L9vOiS2rvh2f(this, _003C_003Ec__DisplayClass62_.propertyMetadata))) : olKqBMo0sy3IorTaF7as(VQ79B9o0duiDSjPyCec8(-1979251663 ^ -1979233289), frdaDLo0U7OjXUFdVHO8(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1876063057 ^ -1875906965)), VQ79B9o0duiDSjPyCec8(0x53CB464B ^ 0x53CB098B)));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
					{
						num2 = 5;
					}
					break;
				}
				IL_01c1:
				description = (string)obj;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
				{
					num2 = 6;
				}
				break;
			}
		}
	}

	public virtual TypeSerializationDescriptor GetSerializeDescriptor(Guid subTypeUid)
	{
		int num = 1;
		int num2 = num;
		EntityMetadata entityMetadata = default(EntityMetadata);
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		while (true)
		{
			switch (num2)
			{
			case 2:
				entityMetadata.Properties.Add(propertyMetadata);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
				{
					num2 = 0;
				}
				continue;
			case 1:
				entityMetadata = new EntityMetadata();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				return GetSerializeDescriptor(entityMetadata, propertyMetadata);
			}
			PropertyMetadata obj = new PropertyMetadata
			{
				Name = (string)olKqBMo0sy3IorTaF7as(VQ79B9o0duiDSjPyCec8(-87337865 ^ -87352399), frdaDLo0U7OjXUFdVHO8(VQ79B9o0duiDSjPyCec8(-1979251663 ^ -1979345779)), VQ79B9o0duiDSjPyCec8(-1979251663 ^ -1979233295))
			};
			W5cZwGomBwe9EsDlOjmG(obj, cFTaZ5o0yyuIsvWryPXH(this));
			obj.SubTypeUid = subTypeUid;
			propertyMetadata = obj;
			num2 = 2;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
			{
				num2 = 0;
			}
		}
	}

	public virtual TypeSerializationDescriptor GetSettingsSerializeDescriptor()
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (!ueWwfqomoWnrlniJZtqY(TymIhMomWF1IXH0NR4XT(this), null))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			default:
				return null;
			case 1:
				return (TypeSerializationDescriptor)mdQRm7omhmOJKZvFEp10((TypeSettings)Uotg6aombL28AxO8Zedv(TymIhMomWF1IXH0NR4XT(this)));
			}
		}
	}

	public IDictionary<string, object> Serialize(object obj, [NotNull] ClassMetadata metadata, [NotNull] PropertyMetadata propertyMetadata)
	{
		return Serialize(obj, metadata, propertyMetadata, null);
	}

	public virtual IDictionary<string, object> Serialize(object obj, [NotNull] ClassMetadata metadata, [NotNull] PropertyMetadata propertyMetadata, EntitySerializationSettings settings)
	{
		if (obj == null)
		{
			return null;
		}
		if (metadata == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34185E55 ^ 0x3418176B));
		}
		if (propertyMetadata == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x61EC0CB8 ^ 0x61EC45EA));
		}
		obj = obj.CastAsRealType();
		PropertyInfo property = obj.GetProperty(metadata, propertyMetadata);
		if (property == null || !property.CanRead)
		{
			return null;
		}
		object value = property.GetValue(obj, null);
		SerializableDictionary<string, object> serializableDictionary = new SerializableDictionary<string, object>();
		Type propertyType = property.PropertyType;
		serializableDictionary[propertyMetadata.Name] = SerializeSimple(value, propertyType, settings);
		return serializableDictionary;
	}

	public object SerializeSimple(object value, Type valueType)
	{
		return dgnskRomGsL0qfui1xDT(this, value, valueType, null);
	}

	public virtual object SerializeSimple(object value, Type valueType, EntitySerializationSettings settings)
	{
		int num = 1;
		int num2 = num;
		TypeConverter typeConverter = default(TypeConverter);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return null;
			case 2:
				if (G6Tyl5omQMRBP1R4ZD7r(typeConverter, typeof(string)))
				{
					return Rtji51omCXXrDmdrO9MH(typeConverter, value);
				}
				num2 = 3;
				break;
			case 1:
				zcLiaromEpyZdHx3Joni(valueType, VQ79B9o0duiDSjPyCec8(0x68BBB53E ^ 0x68B93C82));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				typeConverter = (TypeConverter)bA65TAomfCfCfd8UFPQP(valueType);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public virtual void Deserialize(object obj, [NotNull] ClassMetadata metadata, [NotNull] PropertyMetadata propertyMetadata, IDictionary<string, object> values)
	{
		if (obj == null || values == null)
		{
			return;
		}
		if (metadata == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3630F361 ^ 0x3630BA5F));
		}
		if (propertyMetadata == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951500620));
		}
		obj = obj.CastAsRealType();
		PropertyInfo property = obj.GetProperty(metadata, propertyMetadata);
		if (property == null || !property.CanWrite)
		{
			return;
		}
		Type propertyType = property.PropertyType;
		if (!values.TryGetValue(propertyMetadata.Name, out var value))
		{
			return;
		}
		try
		{
			object value2 = DeserializeSimple(value, propertyType);
			property.SetValue(obj, value2, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, null, null);
		}
		catch (Exception exception)
		{
			Logger.Debug(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-542721635 ^ -542887057), Name, GetType(), propertyMetadata.Name, metadata.FullTypeName), exception);
		}
	}

	public virtual object DeserializeSimple(object value, Type deserializeToType)
	{
		//Discarded unreachable code: IL_0064, IL_00f2, IL_0101
		int num = 3;
		object obj = default(object);
		TypeConverter typeConverter = default(TypeConverter);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj2;
				switch (num2)
				{
				case 8:
					obj2 = obj.ToString();
					break;
				case 13:
					if (!BSAmfyomuEoxPxTiUAVt(typeConverter, obj.GetType()))
					{
						num2 = 6;
						continue;
					}
					goto case 5;
				case 14:
					if (Jcm0hcom8eYlG1BJ7bP6(deserializeToType))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto IL_00d3;
				case 12:
					if (obj is IDictionary<string, object>)
					{
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
						{
							num2 = 10;
						}
						continue;
					}
					goto IL_00d3;
				default:
					return null;
				case 11:
					return obj;
				case 7:
					return null;
				case 10:
					if (GnwWQ3omvjPZhNk39UEi((IDictionary<string, object>)obj) == 0)
					{
						num2 = 14;
						continue;
					}
					goto IL_00d3;
				case 6:
					if (!(obj is IFormattable formattable))
					{
						num2 = 8;
						continue;
					}
					obj2 = TalX6momIYh73VV8hUBR(formattable, null, CultureInfo.InvariantCulture);
					break;
				case 3:
					if (deserializeToType == null)
					{
						num2 = 2;
						continue;
					}
					obj = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
					{
						num2 = 1;
					}
					continue;
				case 5:
					if (typeConverter.CanConvertFrom(obj.GetType()))
					{
						num2 = 4;
						continue;
					}
					if (!ueWwfqomoWnrlniJZtqY(deserializeToType, TypeOf<object>.Raw))
					{
						num2 = 7;
						continue;
					}
					goto case 11;
				case 1:
					if (obj != null)
					{
						num2 = 12;
						continue;
					}
					goto case 14;
				case 2:
					throw new ArgumentNullException((string)VQ79B9o0duiDSjPyCec8(-210725949 ^ -210707897));
				case 9:
					throw new SerializationException(SR.T((string)VQ79B9o0duiDSjPyCec8(-882126494 ^ -882294342), null, deserializeToType));
				case 4:
					{
						return A0e8GuomSIijTIE7YG2I(typeConverter, null, jd5BvtomVnDnTeVbQ6n8(), obj);
					}
					IL_00d3:
					if (obj != null)
					{
						typeConverter = (TypeConverter)vcSwSXomZEE27OkcqPwq(deserializeToType);
						num2 = 13;
						continue;
					}
					goto end_IL_0012;
				}
				obj = obj2;
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
				{
					num2 = 0;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 9;
		}
	}

	public virtual PropertyCompareData GetCompareData(object oldObject, object newObject, [NotNull] ClassMetadata metadata, [NotNull] PropertyMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_0051, IL_0060
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (metadata == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
					{
						num2 = 0;
					}
					break;
				}
				if (propertyMetadata != null)
				{
					num2 = 3;
					break;
				}
				goto case 2;
			case 2:
				throw new ArgumentNullException((string)VQ79B9o0duiDSjPyCec8(-475857671 ^ -475875925));
			case 3:
			{
				PropertyCompareData propertyCompareData = new PropertyCompareData(ebOiAtomivuRTjy2IYWa(propertyMetadata), ebOiAtomivuRTjy2IYWa(metadata));
				IDictionary<string, object> dictionary = Serialize(oldObject, metadata, propertyMetadata);
				IDictionary<string, object> dictionary2 = Serialize(newObject, metadata, propertyMetadata);
				jdLmMEomq5AFRjVof8ld(propertyCompareData, bRe5OVomRWWvCUarrZS6(dictionary));
				DRU9EDomKcEwN3WmeDvv(propertyCompareData, bRe5OVomRWWvCUarrZS6(dictionary2));
				return propertyCompareData;
			}
			default:
				throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x571EA399 ^ 0x571EEAA7));
			}
		}
	}

	public virtual void SetCompareData(object oldObject, object newObject, [NotNull] ClassMetadata metadata, [NotNull] PropertyMetadata propertyMetadata, PropertyCompareData compareData)
	{
		//Discarded unreachable code: IL_005d, IL_006c, IL_00c8, IL_00d7, IL_00e7, IL_00f6, IL_0106
		int num = 9;
		int num2 = num;
		IDictionary<string, object> values2 = default(IDictionary<string, object>);
		IDictionary<string, object> values = default(IDictionary<string, object>);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				return;
			case 6:
				Deserialize(oldObject, metadata, propertyMetadata, values2);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
				{
					num2 = 3;
				}
				continue;
			case 3:
			case 12:
				if (T1WdD4omO11HkeLO2NI3(compareData) == null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
					{
						num2 = 2;
					}
					continue;
				}
				break;
			case 7:
				return;
			case 0:
				return;
			case 1:
				if (!UA1eo6omTJusAsd9YU5Z(Q2qisFomXCG0fgvv0PkH(compareData), ebOiAtomivuRTjy2IYWa(propertyMetadata)))
				{
					if (c3Cxa8omkYAt5onwrkN3(compareData) == null)
					{
						num2 = 12;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto case 13;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
				{
					num2 = 0;
				}
				continue;
			case 4:
				throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1A33FE36 ^ 0x1A33B708));
			case 8:
				if (propertyMetadata == null)
				{
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
					{
						num2 = 3;
					}
					continue;
				}
				if (compareData == null)
				{
					num2 = 7;
					continue;
				}
				goto case 1;
			case 13:
				values2 = (IDictionary<string, object>)vL88leomnG6TnPmuZarl(compareData.OldPropertyData);
				num2 = 6;
				continue;
			case 11:
				throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70021537));
			case 10:
				return;
			case 9:
				if (metadata != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
					{
						num2 = 8;
					}
					continue;
				}
				goto case 4;
			case 5:
				Deserialize(newObject, metadata, propertyMetadata, values);
				num2 = 10;
				continue;
			case 14:
				break;
			}
			values = (IDictionary<string, object>)ClassSerializationHelper.DeserializeObject(compareData.NewPropertyData);
			num2 = 5;
		}
	}

	public virtual string FormatValue(object value, PropertyMetadata propertyMetadata)
	{
		return FormatValue(value, propertyMetadata?.Settings);
	}

	public virtual string FormatValue(object value, TypeSettings settings)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (value == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return value.ToString();
			default:
				return string.Empty;
			}
		}
	}

	public virtual void Copy(object obj, object target, ClassMetadata metadata, PropertyMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_00c7, IL_00d6, IL_0154, IL_019f, IL_01ae, IL_01de
		int num = 8;
		int num2 = num;
		PropertyInfo propertyCached = default(PropertyInfo);
		object obj2 = default(object);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				throw new ArgumentNullException((string)VQ79B9o0duiDSjPyCec8(0x6DC147B0 ^ 0x6DC10E8E));
			case 11:
				throw new ArgumentNullException((string)VQ79B9o0duiDSjPyCec8(-643786247 ^ -643772245));
			case 16:
				return;
			case 0:
				return;
			case 7:
				return;
			case 1:
				if (target != null)
				{
					if (metadata != null)
					{
						if (propertyMetadata == null)
						{
							num2 = 11;
							break;
						}
						propertyCached = obj.GetType().GetPropertyCached((string)E7pZfPo0rrUxiTXTu5x1(propertyMetadata));
						num2 = 5;
					}
					else
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
						{
							num2 = 3;
						}
					}
				}
				else
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
					{
						num2 = 0;
					}
				}
				break;
			case 6:
				if (!yUPOqaom1KuGfj57ZDAJ(propertyCached))
				{
					num2 = 4;
					break;
				}
				S2ETo3omNN10ZO3rB1x3(propertyCached, target, obj2, null);
				num2 = 16;
				break;
			case 5:
				if (nvMj1yom22OUERfkYoWo(propertyCached, null))
				{
					num2 = 12;
					break;
				}
				goto case 9;
			case 10:
				return;
			case 12:
				return;
			case 15:
				return;
			case 2:
				obj2 = jEBu6womPRWCsjOAOBXR(propertyCached, obj, null);
				num2 = 11;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
				{
					num2 = 14;
				}
				break;
			case 9:
				if (!cIC9jpomevFgFYhEdMEY(propertyCached))
				{
					return;
				}
				num2 = 2;
				break;
			case 8:
				if (obj == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
					{
						num2 = 7;
					}
					break;
				}
				goto case 1;
			case 13:
				if (nvMj1yom22OUERfkYoWo(propertyCached, null))
				{
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
					{
						num2 = 6;
					}
					break;
				}
				goto case 6;
			case 4:
				return;
			case 14:
				propertyCached = target.GetType().GetPropertyCached((string)E7pZfPo0rrUxiTXTu5x1(propertyMetadata));
				num2 = 11;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
				{
					num2 = 13;
				}
				break;
			}
		}
	}

	public virtual IComparer GetComparer(Type sourceType, LambdaExpression propertyFunc, ListSortDirection order)
	{
		return null;
	}

	public virtual IComparer<TSource> GetComparer<TSource, TKey>(Func<TSource, TKey> propertyFunc, ListSortDirection order)
	{
		_003C_003Ec__DisplayClass79_0<TSource, TKey> _003C_003Ec__DisplayClass79_ = new _003C_003Ec__DisplayClass79_0<TSource, TKey>();
		_003C_003Ec__DisplayClass79_.propertyFunc = propertyFunc;
		if (_003C_003Ec__DisplayClass79_.propertyFunc == null)
		{
			return null;
		}
		ParameterExpression parameterExpression = Expression.Parameter(typeof(TSource), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488742149));
		Expression<Func<TSource, TKey>> propertyFunc2 = Expression.Lambda<Func<TSource, TKey>>(Expression.Invoke(Expression.Field(Expression.Constant(_003C_003Ec__DisplayClass79_, typeof(_003C_003Ec__DisplayClass79_0<TSource, TKey>)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, typeof(_003C_003Ec__DisplayClass79_0<TSource, TKey>).TypeHandle)), parameterExpression), new ParameterExpression[1] { parameterExpression });
		return (IComparer<TSource>)GetComparer(typeof(TSource), propertyFunc2, order);
	}

	public virtual bool IsSupportSort()
	{
		return false;
	}

	public virtual bool IsPublicApplicationDisplayEnabled(Guid subTypeUid)
	{
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass81_0 _003C_003Ec__DisplayClass81_ = default(_003C_003Ec__DisplayClass81_0);
		while (true)
		{
			switch (num2)
			{
			case 2:
				_003C_003Ec__DisplayClass81_ = new _003C_003Ec__DisplayClass81_0();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				_003C_003Ec__DisplayClass81_.subTypeUid = subTypeUid;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass81_._003C_003E4__this = this;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
				{
					num2 = 3;
				}
				break;
			default:
				return GetTypePublicApplicationProviders().Any(_003C_003Ec__DisplayClass81_._003CIsPublicApplicationDisplayEnabled_003Eb__0);
			}
		}
	}

	public virtual bool IsPublicApplicationEditorEnabled(Guid subTypeUid)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass82_0 _003C_003Ec__DisplayClass82_ = default(_003C_003Ec__DisplayClass82_0);
		while (true)
		{
			switch (num2)
			{
			default:
				_003C_003Ec__DisplayClass82_._003C_003E4__this = this;
				num2 = 3;
				break;
			case 1:
				_003C_003Ec__DisplayClass82_ = new _003C_003Ec__DisplayClass82_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return GetTypePublicApplicationProviders().Any(_003C_003Ec__DisplayClass82_._003CIsPublicApplicationEditorEnabled_003Eb__0);
			case 3:
				_003C_003Ec__DisplayClass82_.subTypeUid = subTypeUid;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public virtual void CheckPublicApplicationCompatibility([NotNull] ClassMetadata classMetadata, [NotNull] PropertyMetadata propertyMetadata, PropertyViewItem viewItem, string parentPropertyName, [NotNull] List<IPublicApplicationCompatibilityError> errors)
	{
		_003C_003Ec__DisplayClass83_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass83_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.classMetadata = classMetadata;
		CS_0024_003C_003E8__locals0.propertyMetadata = propertyMetadata;
		CS_0024_003C_003E8__locals0.viewItem = viewItem;
		CS_0024_003C_003E8__locals0.parentPropertyName = parentPropertyName;
		CS_0024_003C_003E8__locals0.errors = errors;
		if (CS_0024_003C_003E8__locals0.classMetadata == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420873790));
		}
		if (CS_0024_003C_003E8__locals0.propertyMetadata == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-889460160 ^ -889478382));
		}
		if (CS_0024_003C_003E8__locals0.errors == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53FA00CE ^ 0x53F867B4));
		}
		Action action = delegate
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
					CS_0024_003C_003E8__locals0._003C_003E4__this.GetTypePublicApplicationProviders().ForEach(delegate(ITypePublicApplicationProvider p)
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
								p.CheckPublicApplicationCompatibility(CS_0024_003C_003E8__locals0.classMetadata, CS_0024_003C_003E8__locals0.propertyMetadata, CS_0024_003C_003E8__locals0.viewItem, CS_0024_003C_003E8__locals0.parentPropertyName, CS_0024_003C_003E8__locals0.errors);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
								{
									num4 = 0;
								}
								break;
							}
						}
					});
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		};
		bool flag = CS_0024_003C_003E8__locals0.viewItem.IsReadOnly();
		bool flag2 = IsPublicApplicationDisplayEnabled(CS_0024_003C_003E8__locals0.propertyMetadata.SubTypeUid);
		bool flag3 = IsPublicApplicationDisplayEnabled(CS_0024_003C_003E8__locals0.propertyMetadata.SubTypeUid);
		if ((flag && flag2) || (!flag && flag3))
		{
			action();
			return;
		}
		bool? isReadOnly = ((flag2 && flag3) ? null : new bool?(flag2 ? true : false));
		CS_0024_003C_003E8__locals0.typeCode = string.Concat(Uid, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138157566), SubTypeUid, (!isReadOnly.HasValue) ? "" : (isReadOnly.Value ? z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2ACE37D ^ 0x2AE723B) : z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 0x4F7DA320)));
		PublicAppTypeCompatibilityError publicAppTypeCompatibilityError = CS_0024_003C_003E8__locals0.errors.OfType<PublicAppTypeCompatibilityError>().FirstOrDefault((PublicAppTypeCompatibilityError e) => _003C_003Ec__DisplayClass83_0.gMQyWTCVDZ2Ir7WPZD9x(_003C_003Ec__DisplayClass83_0.btVYrqCVaMRGrtCZu4nn(e), CS_0024_003C_003E8__locals0.typeCode));
		string text = ((!string.IsNullOrEmpty(CS_0024_003C_003E8__locals0.parentPropertyName)) ? (CS_0024_003C_003E8__locals0.parentPropertyName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x463A0F3C ^ 0x463A15F8)) : "") + CS_0024_003C_003E8__locals0.propertyMetadata.DisplayName;
		if (publicAppTypeCompatibilityError != null)
		{
			publicAppTypeCompatibilityError.PropertyNames.Add(text);
		}
		else
		{
			publicAppTypeCompatibilityError = new PublicAppTypeCompatibilityError(CS_0024_003C_003E8__locals0.typeCode, GetPropertyTypeDisplayName(CS_0024_003C_003E8__locals0.propertyMetadata), isReadOnly, text);
			CS_0024_003C_003E8__locals0.errors.Add(publicAppTypeCompatibilityError);
		}
		action();
	}

	private IEnumerable<ITypePublicApplicationProvider> GetTypePublicApplicationProviders()
	{
		return ComponentManager.Current.GetExtensionPoints<ITypePublicApplicationProvider>(useCache: true);
	}

	public override string ToString()
	{
		return (string)w4bq2qo09WYgadBlMUqC(this);
	}

	internal static void f3XiH2o00aROaNrmeih4(object P_0, object P_1, object P_2, object P_3)
	{
		((TypeDescriptor)P_0).CreatePropertyMapping((INHibernatePropertiesMapper)P_1, (ClassMetadata)P_2, (EntityPropertyMetadata)P_3);
	}

	internal static bool vHvybbo07OBZpgpPXYaX()
	{
		return pYoQYTo0ARPoTKxsLhtM == null;
	}

	internal static TypeDescriptor Vx0nioo0xLa5r96EnUOp()
	{
		return pYoQYTo0ARPoTKxsLhtM;
	}

	internal static object jDKDveo0m9ReQT681Zgi()
	{
		return NullLogger.Instance;
	}

	internal static Guid cFTaZ5o0yyuIsvWryPXH(object P_0)
	{
		return ((TypeDescriptor)P_0).Uid;
	}

	internal static object DsNT07o0Mwxg5R8uVWNa(object P_0)
	{
		return ((PropertyMetadata)P_0).Settings;
	}

	internal static bool jfbuR8o0JaVVl0kQZpbH(object P_0, object P_1, object P_2)
	{
		return ((TypeDescriptor)P_0).IsEmpty((PropertyMetadata)P_1, P_2);
	}

	internal static object w4bq2qo09WYgadBlMUqC(object P_0)
	{
		return ((TypeDescriptor)P_0).Name;
	}

	internal static object VQ79B9o0duiDSjPyCec8(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool W4mpj0o0ll4ldKd0Qwa6(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object E7pZfPo0rrUxiTXTu5x1(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static object MQoBBSo0gpI51K74ZviE(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static object MLC5qZo05lxFcp8O3kKm(object P_0, object P_1)
	{
		return Restrictions.Eq((string)P_0, P_1);
	}

	internal static object sIAyVwo0jGJEaiTMjIFH(object P_0, object P_1)
	{
		return ((ICriteria)P_0).Add((ICriterion)P_1);
	}

	internal static object OZhg1Jo0YlBanaSh8178(object P_0)
	{
		return ((NamedMetadata)P_0).DisplayName;
	}

	internal static object StvIxto0L9vOiS2rvh2f(object P_0, object P_1)
	{
		return ((TypeDescriptor)P_0).GetPropertyTypeDisplayName((PropertyMetadata)P_1);
	}

	internal static object frdaDLo0U7OjXUFdVHO8(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object olKqBMo0sy3IorTaF7as(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static object RqkmY9o0cuIQZknlNuVZ(object P_0)
	{
		return ((NamedMetadata)P_0).Description;
	}

	internal static object IJAfHco0zwF4LdPUkqrw(object P_0, object P_1, object P_2, object P_3)
	{
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	internal static object R1wwvtomFFNi8ETIG9TV(object P_0)
	{
		return ((TypeSerializationDescriptorBuilder)P_0).Descriptor;
	}

	internal static void W5cZwGomBwe9EsDlOjmG(object P_0, Guid value)
	{
		((PropertyMetadata)P_0).TypeUid = value;
	}

	internal static Type TymIhMomWF1IXH0NR4XT(object P_0)
	{
		return ((TypeDescriptor)P_0).SettingsType;
	}

	internal static bool ueWwfqomoWnrlniJZtqY(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static object Uotg6aombL28AxO8Zedv(Type P_0)
	{
		return Activator.CreateInstance(P_0);
	}

	internal static object mdQRm7omhmOJKZvFEp10(object P_0)
	{
		return ((TypeSettings)P_0).GetSerializationDescriptor();
	}

	internal static object dgnskRomGsL0qfui1xDT(object P_0, object P_1, Type valueType, object P_3)
	{
		return ((TypeDescriptor)P_0).SerializeSimple(P_1, valueType, (EntitySerializationSettings)P_3);
	}

	internal static void zcLiaromEpyZdHx3Joni(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object bA65TAomfCfCfd8UFPQP(Type type)
	{
		return ElmaTypeDescriptorHelper.GetConverter(type);
	}

	internal static bool G6Tyl5omQMRBP1R4ZD7r(object P_0, Type P_1)
	{
		return ((TypeConverter)P_0).CanConvertTo(P_1);
	}

	internal static object Rtji51omCXXrDmdrO9MH(object P_0, object P_1)
	{
		return ((TypeConverter)P_0).ConvertToInvariantString(P_1);
	}

	internal static int GnwWQ3omvjPZhNk39UEi(object P_0)
	{
		return ((ICollection<KeyValuePair<string, object>>)P_0).Count;
	}

	internal static bool Jcm0hcom8eYlG1BJ7bP6(Type type)
	{
		return type.IsAssignableFromNull();
	}

	internal static object vcSwSXomZEE27OkcqPwq(Type P_0)
	{
		return System.ComponentModel.TypeDescriptor.GetConverter(P_0);
	}

	internal static bool BSAmfyomuEoxPxTiUAVt(object P_0, Type P_1)
	{
		return ((TypeConverter)P_0).CanConvertFrom(P_1);
	}

	internal static object TalX6momIYh73VV8hUBR(object P_0, object P_1, object P_2)
	{
		return ((IFormattable)P_0).ToString((string)P_1, (IFormatProvider)P_2);
	}

	internal static object jd5BvtomVnDnTeVbQ6n8()
	{
		return CultureInfo.InvariantCulture;
	}

	internal static object A0e8GuomSIijTIE7YG2I(object P_0, object P_1, object P_2, object P_3)
	{
		return ((TypeConverter)P_0).ConvertFrom((ITypeDescriptorContext)P_1, (CultureInfo)P_2, P_3);
	}

	internal static Guid ebOiAtomivuRTjy2IYWa(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static object bRe5OVomRWWvCUarrZS6(object P_0)
	{
		return ClassSerializationHelper.SerializeObject(P_0);
	}

	internal static void jdLmMEomq5AFRjVof8ld(object P_0, object P_1)
	{
		((PropertyCompareData)P_0).OldPropertyData = (byte[])P_1;
	}

	internal static void DRU9EDomKcEwN3WmeDvv(object P_0, object P_1)
	{
		((PropertyCompareData)P_0).NewPropertyData = (byte[])P_1;
	}

	internal static Guid Q2qisFomXCG0fgvv0PkH(object P_0)
	{
		return ((PropertyCompareData)P_0).PropertyGuid;
	}

	internal static bool UA1eo6omTJusAsd9YU5Z(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static object c3Cxa8omkYAt5onwrkN3(object P_0)
	{
		return ((PropertyCompareData)P_0).OldPropertyData;
	}

	internal static object vL88leomnG6TnPmuZarl(object P_0)
	{
		return ClassSerializationHelper.DeserializeObject((byte[])P_0);
	}

	internal static object T1WdD4omO11HkeLO2NI3(object P_0)
	{
		return ((PropertyCompareData)P_0).NewPropertyData;
	}

	internal static bool nvMj1yom22OUERfkYoWo(object P_0, object P_1)
	{
		return (PropertyInfo)P_0 == (PropertyInfo)P_1;
	}

	internal static bool cIC9jpomevFgFYhEdMEY(object P_0)
	{
		return ((PropertyInfo)P_0).CanRead;
	}

	internal static object jEBu6womPRWCsjOAOBXR(object P_0, object P_1, object P_2)
	{
		return ((PropertyInfo)P_0).GetValue(P_1, (object[])P_2);
	}

	internal static bool yUPOqaom1KuGfj57ZDAJ(object P_0)
	{
		return ((PropertyInfo)P_0).CanWrite;
	}

	internal static void S2ETo3omNN10ZO3rB1x3(object P_0, object P_1, object P_2, object P_3)
	{
		((PropertyInfo)P_0).SetValue(P_1, P_2, (object[])P_3);
	}
}
[Component]
public abstract class TypeDescriptor<T> : TypeDescriptor
{
	private static object iVtFUEoruSUiPLi8Dl7B;

	public virtual object SerializeSimple(T value)
	{
		return SerializeSimple(value, typeof(T));
	}

	public virtual T DeserializeSimple(object value)
	{
		return (T)DeserializeSimple(value, typeof(T));
	}

	protected TypeDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool vp8ThcorI34EnYKYQXq6()
	{
		return iVtFUEoruSUiPLi8Dl7B == null;
	}

	internal static object Ym8MHWorVoOewpKRtJoy()
	{
		return iVtFUEoruSUiPLi8Dl7B;
	}
}
[Component]
public abstract class TypeDescriptor<T, SettingsT> : TypeDescriptor<T>
{
	private static object jmjcK4orSHnRGYdpa88k;

	public override Type SettingsType => typeof(SettingsT);

	protected TypeDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool z5DGjKoriDUmNe5hq047()
	{
		return jmjcK4orSHnRGYdpa88k == null;
	}

	internal static object lJIBJKorRof3aZUMTIta()
	{
		return jmjcK4orSHnRGYdpa88k;
	}
}
