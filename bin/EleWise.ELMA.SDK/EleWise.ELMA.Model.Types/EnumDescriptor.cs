using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.FullTextSearch.Descriptors;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Helpers;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Types;

[Component(Order = 600)]
public class EnumDescriptor : SimpleTypeDescriptor<Enum, EnumSettings>, IMappingTypeDescriptor, IConvertableTypeDescriptor
{
	public const string UID_S = "{849C1AC9-4D46-4194-8CBB-43F84ADF9C17}";

	public static readonly Guid UID;

	private IFullTextPropertyDescriptor propertyDescriptor;

	internal static EnumDescriptor jYgFD3o0GGl2WNGqU4gV;

	public override Guid Uid => UID;

	public override string Name => (string)WImWEdo0VMhEfNS1Ztnt(pngRfWo0IvMAZnnK9lCG(0x2A7797B7 ^ 0x2A7518F7));

	public override Guid ParentUid => Guid.Empty;

	public override bool CanBeNullable => true;

	public override bool? DefaultNullableValue => false;

	public override bool IsAvailibleEditPropertyInTable => true;

	public override IFullTextPropertyDescriptor FullTextPropertyDescriptor
	{
		get
		{
			int num = 2;
			int num2 = num;
			IFullTextPropertyDescriptor fullTextPropertyDescriptor = default(IFullTextPropertyDescriptor);
			IFullTextPropertyDescriptor fullTextPropertyDescriptor2;
			while (true)
			{
				switch (num2)
				{
				case 1:
					fullTextPropertyDescriptor = (propertyDescriptor = new EnumPropertyDescriptor(this));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					fullTextPropertyDescriptor2 = propertyDescriptor;
					if (fullTextPropertyDescriptor2 == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				default:
					fullTextPropertyDescriptor2 = fullTextPropertyDescriptor;
					break;
				}
				break;
			}
			return fullTextPropertyDescriptor2;
		}
	}

	protected override void CreatePropertyMapping(INHibernatePropertiesMapper mappingBuilder, ClassMetadata metadata, EntityPropertyMetadata propertyMetadata)
	{
		int num = 6;
		_003C_003Ec__DisplayClass0_0 _003C_003Ec__DisplayClass0_ = default(_003C_003Ec__DisplayClass0_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					if (Sb9cKfo0v4j19Fxyw5yq(_003C_003Ec__DisplayClass0_.propertyMetadata) == null)
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
						{
							num2 = 4;
						}
					}
					else
					{
						mappingBuilder.Property((string)RXDwJ1o08ydFeVRaZ5T8(_003C_003Ec__DisplayClass0_.propertyMetadata), ((SimpleTypeSettings)Sb9cKfo0v4j19Fxyw5yq(_003C_003Ec__DisplayClass0_.propertyMetadata)).FieldName, _003C_003Ec__DisplayClass0_._003CCreatePropertyMapping_003Eb__0, !BMkBbmo0ZF9VV6I3qOEd(_003C_003Ec__DisplayClass0_.propertyMetadata), null, (DVWwtYo0uFh133FPh9Ot(_003C_003Ec__DisplayClass0_.enumPropertyMetadata) == EnumMetadataType.Enum) ? z2jc63fLkugS1X8Q9N.tE1kD1vbB(-672123589 ^ -671958515) : null);
						num2 = 2;
					}
					continue;
				default:
					Y3i3hNo0QqISj4yv6qDG(_003C_003Ec__DisplayClass0_.propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x269E5FCA ^ 0x269E1698));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					_003C_003Ec__DisplayClass0_.propertyMetadata = propertyMetadata;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					break;
				case 2:
					return;
				case 6:
					_003C_003Ec__DisplayClass0_ = new _003C_003Ec__DisplayClass0_0();
					num2 = 5;
					continue;
				case 4:
					return;
				}
				break;
			}
			_003C_003Ec__DisplayClass0_.enumPropertyMetadata = GetMetadata(DbUExRo0CPsbC1CVdQ64(_003C_003Ec__DisplayClass0_.propertyMetadata), throwOnError: true);
			num = 3;
		}
	}

	public override bool IsEmpty(PropertyMetadata propertyMetadata, object val)
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (val is Enum)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			default:
				return !(val is EnumBase);
			case 1:
				return false;
			}
		}
	}

	public override bool IsEmptyOrDefault(PropertyMetadata propertyMetadata, object val)
	{
		//Discarded unreachable code: IL_0051, IL_0060, IL_00a6
		int num = 6;
		int num2 = num;
		_003C_003Ec__DisplayClass16_0 _003C_003Ec__DisplayClass16_ = default(_003C_003Ec__DisplayClass16_0);
		EnumValueMetadata enumValueMetadata = default(EnumValueMetadata);
		Guid? defaultValue = default(Guid?);
		while (true)
		{
			switch (num2)
			{
			case 5:
				_003C_003Ec__DisplayClass16_.propertyMetadata = propertyMetadata;
				num2 = 3;
				break;
			case 7:
				return enumValueMetadata.EnumValue.Equals(val);
			case 6:
				_003C_003Ec__DisplayClass16_ = new _003C_003Ec__DisplayClass16_0();
				num2 = 5;
				break;
			case 4:
			case 9:
				return true;
			case 10:
				if (!_003C_003Ec__DisplayClass16_.propertyMetadata.Nullable)
				{
					return ModelHelper.GetEnumDefaultValue(val.GetType()).Equals(val);
				}
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
				{
					num2 = 2;
				}
				break;
			default:
				enumValueMetadata = GetMetadata(_003C_003Ec__DisplayClass16_.propertyMetadata.SubTypeUid, throwOnError: false).Values.FirstOrDefault(_003C_003Ec__DisplayClass16_._003CIsEmptyOrDefault_003Eb__0);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
				{
					num2 = 2;
				}
				break;
			case 3:
				if (val == null)
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			case 11:
				if (!defaultValue.HasValue)
				{
					return false;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
				{
					num2 = 0;
				}
				break;
			case 8:
				defaultValue = ((EnumSettings)_003C_003Ec__DisplayClass16_.propertyMetadata.Settings).DefaultValue;
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
				{
					num2 = 11;
				}
				break;
			case 1:
				if (!g7Jtkjo0ShGHKQZYDFru(this, _003C_003Ec__DisplayClass16_.propertyMetadata, val))
				{
					num2 = 10;
					break;
				}
				goto case 4;
			case 2:
				if (enumValueMetadata == null)
				{
					return false;
				}
				num2 = 7;
				break;
			}
		}
	}

	public override IEnumerable<ITypeDescriptor> GetSubTypes(ClassMetadata classMetadata)
	{
		List<NamedMetadata> metadataList = (from NamedMetadata o in MetadataServiceContext.Service.GetMetadataList().Where(delegate(IMetadata m)
			{
				//Discarded unreachable code: IL_008f, IL_009e
				int num = 3;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 2:
						if (!((EnumMetadata)m).ShowInTypeTree)
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
							{
								num2 = 0;
							}
							continue;
						}
						goto case 1;
					case 3:
						if (_003C_003Ec.Bx8UOSCIdpC81EopSgua(m.GetType(), _003C_003Ec.A5ROftCI9fZyUJODp0kk(typeof(EnumMetadata).TypeHandle)))
						{
							num2 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
							{
								num2 = 2;
							}
							continue;
						}
						break;
					case 1:
						return _003C_003Ec.XI9ZChCIlbIuZE4IDDC7((EnumMetadata)m) != EnumMetadataType.EnumExtension;
					}
					break;
				}
				return false;
			})
			orderby (string)_003C_003Ec.zKkNHTCIrtOXeT53sv6p(o)
			select o).ToList();
		return CompositeTypeDescriptorHelper.GetDescriptorsByGroups(this, metadataList);
	}

	public override ISyntaxNode GetPropertyTypeReference(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter)
	{
		//Discarded unreachable code: IL_00fc, IL_0124
		int num = 1;
		int num2 = num;
		EnumSettings enumSettings = default(EnumSettings);
		EnumMetadata metadata = default(EnumMetadata);
		while (true)
		{
			switch (num2)
			{
			case 1:
				Y3i3hNo0QqISj4yv6qDG(propertyMetadata, pngRfWo0IvMAZnnK9lCG(-1317790512 ^ -1317775998));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
				{
					num2 = 0;
				}
				break;
			case 8:
				if (!BMkBbmo0ZF9VV6I3qOEd(propertyMetadata))
				{
					num2 = 4;
					break;
				}
				goto case 9;
			case 3:
				enumSettings = (EnumSettings)uee7V6o0iRYOgHGiyIvd(propertyMetadata);
				num2 = 7;
				break;
			case 4:
			case 6:
				return ((string)hNWhmko0qc87X4ust3LZ(metadata)).CreateTypeSyntax();
			case 2:
				return PIPHOso0KOMXSboiKVbQ(typeof(Nullable<>).TypeHandle).CreateTypeSyntax((ISyntaxNode)f7Tbypo0XSjgOMwFAwhl(hNWhmko0qc87X4ust3LZ(metadata)));
			default:
				metadata = GetMetadata(DbUExRo0CPsbC1CVdQ64(propertyMetadata), throwOnError: true);
				num2 = 3;
				break;
			case 9:
				if (metadata.Type == EnumMetadataType.Enum)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 4;
			case 5:
				if (Ht05M6o0RbML8kQM8T1R(enumSettings) == EnumRelationType.Many)
				{
					return PIPHOso0KOMXSboiKVbQ(typeof(List<>).TypeHandle).CreateTypeSyntax((ISyntaxNode)f7Tbypo0XSjgOMwFAwhl(hNWhmko0qc87X4ust3LZ(metadata)));
				}
				num2 = 8;
				break;
			case 7:
				if (forFilter)
				{
					num2 = 5;
					break;
				}
				goto case 8;
			}
		}
	}

	public override void ApplyFilterValue(ICriteria criteria, EntityMetadata metadata, EntityPropertyMetadata propertyMetadata, object value, string alias)
	{
		//Discarded unreachable code: IL_005f, IL_006f, IL_007e, IL_00d4
		int num = 4;
		int num2 = num;
		object[] array = default(object[]);
		IEnumerable enumerable = default(IEnumerable);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (array.Length != 0)
				{
					num2 = 6;
					break;
				}
				return;
			case 2:
				return;
			case 7:
				if (enumerable == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 5;
			case 4:
				if (value != null)
				{
					num2 = 3;
					break;
				}
				return;
			case 8:
				return;
			case 3:
				enumerable = value as IEnumerable;
				num2 = 7;
				break;
			case 10:
				return;
			default:
				base.ApplyFilterValue(criteria, metadata, propertyMetadata, value, alias);
				num2 = 2;
				break;
			case 5:
				array = enumerable.OfType<object>().ToArray();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
				{
					num2 = 1;
				}
				break;
			case 9:
				return;
			case 6:
				criteria.Add((ICriterion)zENVVIo0kPO0NkkkrwXD(KmSGplo0TQmBIHB8ZVlV(alias) ? propertyMetadata.Name : string.Format((string)pngRfWo0IvMAZnnK9lCG(-561074844 ^ -561057946), alias, RXDwJ1o08ydFeVRaZ5T8(propertyMetadata)), array));
				num2 = 10;
				break;
			}
		}
	}

	public override string GetPropertyTypeDisplayName(PropertyMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_0084, IL_00b7, IL_00ec, IL_00fb
		int num = 2;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				return text;
			case 2:
				Y3i3hNo0QqISj4yv6qDG(propertyMetadata, pngRfWo0IvMAZnnK9lCG(0x48A7E34A ^ 0x48A7AA18));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				try
				{
					text = (string)scwuqro0nrXC1JH0SuuB(this, DbUExRo0CPsbC1CVdQ64(propertyMetadata));
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
					{
						num3 = 0;
					}
					return num3 switch
					{
						0 => text, 
						_ => text, 
					};
				}
				catch (Exception innerException)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					default:
						throw new InvalidOperationException((string)Q6SVIvo0Oorc7hhucfbX(pngRfWo0IvMAZnnK9lCG(-1217523399 ^ -1217618331), RXDwJ1o08ydFeVRaZ5T8(propertyMetadata)), innerException);
					}
				}
			}
		}
	}

	public override string GetTypeDisplayName(Guid subTypeUid)
	{
		int num = 1;
		int num2 = num;
		EnumMetadata metadata = default(EnumMetadata);
		while (true)
		{
			switch (num2)
			{
			case 1:
				metadata = GetMetadata(subTypeUid, throwOnError: false);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return (string)y7ZG6uo0ec0ZX2mSHm4T(pngRfWo0IvMAZnnK9lCG(-2138160520 ^ -2138295988), (metadata != null) ? WImWEdo0VMhEfNS1Ztnt(LRTdhDo02q9UicWrjiLl(metadata)) : "", SR.T((string)pngRfWo0IvMAZnnK9lCG(-1867198571 ^ -1867104217)));
			}
		}
	}

	public override string FormatValue(object value, TypeSettings settings)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return base.FormatValue(value, settings);
			case 1:
				if (value != null)
				{
					return (string)LHAuqRo0PDfLo7BSYA5T(value);
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private EnumValueMetadata GetPropertyDefaultValue(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter = false)
	{
		//Discarded unreachable code: IL_016e, IL_017d, IL_01b5, IL_01c4, IL_01d4, IL_01e3, IL_0286, IL_0295, IL_02ff, IL_0385, IL_03b0, IL_03f0
		int num = 26;
		_003C_003Ec__DisplayClass23_0 _003C_003Ec__DisplayClass23_ = default(_003C_003Ec__DisplayClass23_0);
		EnumValueMetadata enumValueMetadata = default(EnumValueMetadata);
		Guid? guid = default(Guid?);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 15:
					_003C_003Ec__DisplayClass23_.setting = (EnumSettings)uee7V6o0iRYOgHGiyIvd(propertyMetadata);
					num2 = 14;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					return null;
				case 24:
				case 29:
					if (enumValueMetadata != null)
					{
						num2 = 17;
						continue;
					}
					goto case 12;
				case 23:
					enumValueMetadata = _003C_003Ec__DisplayClass23_.enumMetadata.Values.FirstOrDefault(_003C_003Ec__DisplayClass23_._003CGetPropertyDefaultValue_003Eb__0);
					num2 = 28;
					continue;
				case 19:
					if (!guid.HasValue)
					{
						num2 = 3;
						continue;
					}
					goto case 13;
				case 4:
				case 6:
				case 16:
				case 28:
					if (!BMkBbmo0ZF9VV6I3qOEd(propertyMetadata))
					{
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
						{
							num2 = 18;
						}
						continue;
					}
					goto case 17;
				case 30:
					guid = _003C_003Ec__DisplayClass23_.setting.DefaultValue;
					num2 = 7;
					continue;
				case 13:
					guid = _003C_003Ec__DisplayClass23_.enumMetadata.DefaultValueUid;
					num2 = 22;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
					{
						num2 = 32;
					}
					continue;
				case 11:
					if (!bwOJyio01fWaRFAxZrpf(guid.Value, Guid.Empty))
					{
						num2 = 16;
						continue;
					}
					goto case 23;
				case 32:
					if (!(guid.Value != Guid.Empty))
					{
						num2 = 22;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
						{
							num2 = 11;
						}
						continue;
					}
					goto default;
				case 12:
					enumValueMetadata = _003C_003Ec__DisplayClass23_.enumMetadata.Values.FirstOrDefault();
					num2 = 20;
					continue;
				case 21:
					if (_003C_003Ec__DisplayClass23_.enumMetadata != null)
					{
						enumValueMetadata = null;
						num2 = 8;
						continue;
					}
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num2 = 2;
					}
					continue;
				default:
					enumValueMetadata = _003C_003Ec__DisplayClass23_.enumMetadata.Values.FirstOrDefault(_003C_003Ec__DisplayClass23_._003CGetPropertyDefaultValue_003Eb__1);
					num2 = 27;
					continue;
				case 7:
					if (guid.HasValue)
					{
						num2 = 10;
						continue;
					}
					goto case 4;
				case 5:
					if (_003C_003Ec__DisplayClass23_.setting == null)
					{
						num = 6;
						break;
					}
					goto case 30;
				case 25:
					Y3i3hNo0QqISj4yv6qDG(propertyMetadata, pngRfWo0IvMAZnnK9lCG(0x92F12D5 ^ 0x92F5B87));
					num2 = 15;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
					{
						num2 = 8;
					}
					continue;
				case 9:
					guid = _003C_003Ec__DisplayClass23_.enumMetadata.DefaultValueUid;
					num2 = 19;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
					{
						num2 = 16;
					}
					continue;
				case 1:
				case 3:
				case 22:
				case 27:
					if (enumValueMetadata != null)
					{
						num = 24;
						break;
					}
					goto case 31;
				case 10:
					guid = _003C_003Ec__DisplayClass23_.setting.DefaultValue;
					num = 11;
					break;
				case 14:
					_003C_003Ec__DisplayClass23_.enumMetadata = GetMetadata(DbUExRo0CPsbC1CVdQ64(propertyMetadata), throwOnError: false);
					num2 = 21;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
					{
						num2 = 21;
					}
					continue;
				case 17:
				case 20:
					return enumValueMetadata;
				case 26:
					_003C_003Ec__DisplayClass23_ = new _003C_003Ec__DisplayClass23_0();
					num2 = 25;
					continue;
				case 18:
					if (enumValueMetadata != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 9;
				case 8:
					if (forFilter)
					{
						num2 = 4;
						continue;
					}
					goto case 5;
				case 31:
					enumValueMetadata = _003C_003Ec__DisplayClass23_.enumMetadata.Values.FirstOrDefault(delegate(EnumValueMetadata v)
					{
						int num3 = 1;
						int? intValue = default(int?);
						while (true)
						{
							int num4 = num3;
							while (true)
							{
								switch (num4)
								{
								case 2:
									break;
								case 1:
									intValue = v.IntValue;
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
									{
										num4 = 0;
									}
									continue;
								default:
									if (intValue.HasValue)
									{
										num4 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
										{
											num4 = 2;
										}
										continue;
									}
									return false;
								case 3:
									return intValue.Value == 0;
								}
								break;
							}
							intValue = v.IntValue;
							num3 = 3;
						}
					});
					num2 = 29;
					continue;
				}
				break;
			}
		}
	}

	public override ISyntaxNode GetPropertyInitExpression(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter = false)
	{
		return GetPropertyInitExpression(classMetadata, forList: false, propertyMetadata, forFilter);
	}

	public ISyntaxNode GetPropertyInitExpression(ClassMetadata classMetadata, bool forList, PropertyMetadata propertyMetadata, bool forFilter = false)
	{
		//Discarded unreachable code: IL_0087, IL_0091, IL_00a0
		int num = 1;
		int num2 = num;
		EnumValueMetadata propertyDefaultValue = default(EnumValueMetadata);
		EnumSettings enumSettings = default(EnumSettings);
		EnumMetadata metadata = default(EnumMetadata);
		ISyntaxNode syntaxNode = default(ISyntaxNode);
		while (true)
		{
			ISyntaxNode type;
			object properties;
			object obj;
			switch (num2)
			{
			default:
				if (propertyDefaultValue != null)
				{
					num2 = 9;
					break;
				}
				goto case 4;
			case 10:
				if (Ht05M6o0RbML8kQM8T1R(enumSettings) == EnumRelationType.Many)
				{
					num2 = 3;
					break;
				}
				goto case 7;
			case 2:
				if (metadata == null)
				{
					num2 = 5;
					break;
				}
				type = Rx9HQFo0peeGsSWPtM8M(TypeOf.List).CreateTypeSyntax((ISyntaxNode)f7Tbypo0XSjgOMwFAwhl(hNWhmko0qc87X4ust3LZ(metadata)));
				if (syntaxNode != null && !forFilter && enumSettings.DefaultValue.HasValue)
				{
					Guid? defaultValue = enumSettings.DefaultValue;
					Guid empty = Guid.Empty;
					if (!defaultValue.HasValue || (defaultValue.HasValue && bwOJyio01fWaRFAxZrpf(defaultValue.GetValueOrDefault(), empty)))
					{
						properties = new ISyntaxNode[1] { syntaxNode };
						goto IL_023f;
					}
				}
				properties = null;
				goto IL_023f;
			case 4:
				obj = null;
				goto IL_0173;
			case 3:
				metadata = GetMetadata(DbUExRo0CPsbC1CVdQ64(propertyMetadata), throwOnError: false);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				propertyDefaultValue = GetPropertyDefaultValue(classMetadata, propertyMetadata, forFilter);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
				{
					num2 = 0;
				}
				break;
			case 8:
				if (forList)
				{
					num2 = 6;
					break;
				}
				goto case 7;
			case 7:
				return syntaxNode;
			case 6:
				if ((enumSettings = propertyMetadata.Settings as EnumSettings) != null)
				{
					num2 = 10;
					break;
				}
				goto case 7;
			case 9:
				obj = iyU5w4o030C3gK2wYPD7(LIKXc9o0N8DvWgs00sXW(pngRfWo0IvMAZnnK9lCG(-105199646 ^ -105168224), hNWhmko0qc87X4ust3LZ(GetMetadata(DbUExRo0CPsbC1CVdQ64(propertyMetadata), throwOnError: false)), pngRfWo0IvMAZnnK9lCG(0x7E6E5A0B ^ 0x7E6E40CF), RXDwJ1o08ydFeVRaZ5T8(propertyDefaultValue)));
				goto IL_0173;
			case 5:
				{
					return null;
				}
				IL_023f:
				syntaxNode = type.ObjectInitializationExpression((ISyntaxNode[])properties);
				num2 = 7;
				break;
				IL_0173:
				syntaxNode = (ISyntaxNode)obj;
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public override TypeSettings CreateSettingsForFilterProperty(PropertyMetadata propertyMetadata)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return null;
			case 2:
				if (propertyMetadata != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			case 1:
				if (uee7V6o0iRYOgHGiyIvd(propertyMetadata) != null)
				{
					EnumSettings obj = (EnumSettings)ClassSerializationHelper.CloneObjectByXml((TypeSettings)uee7V6o0iRYOgHGiyIvd(propertyMetadata));
					obj.DefaultValue = null;
					return obj;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual object ConvertFrom(object value, PropertyMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_0045, IL_0054, IL_00f8
		int num = 8;
		Type typeByUid = default(Type);
		EnumValueMetadata enumValueMetadata = default(EnumValueMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return value;
				case 1:
					return null;
				case 3:
					typeByUid = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(DbUExRo0CPsbC1CVdQ64(propertyMetadata));
					num2 = 4;
					break;
				case 8:
					if (propertyMetadata != null)
					{
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
						{
							num2 = 3;
						}
						break;
					}
					goto case 5;
				case 2:
					return TQWDQho0DcIICiUKakR1(typeByUid, s1S7CDo0aPlU2sfvX5o4(enumValueMetadata));
				case 4:
					if (!(value.GetType() == typeByUid))
					{
						goto end_IL_0012;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
					{
						num2 = 0;
					}
					break;
				case 5:
					throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CACA3 ^ 0x53CE5F1));
				case 7:
					if (value != null)
					{
						num2 = 3;
						break;
					}
					goto case 1;
				case 6:
					if (enumValueMetadata == null)
					{
						return null;
					}
					num2 = 2;
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			enumValueMetadata = value as EnumValueMetadata;
			num = 6;
		}
	}

	public override bool IsPublicApplicationDisplayEnabled(Guid subTypeUid)
	{
		return true;
	}

	public override bool IsPublicApplicationEditorEnabled(Guid subTypeUid)
	{
		return true;
	}

	protected override ColumnType GetDbColumnType(EntityMetadata entityMetadata, EntityPropertyMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_00e9, IL_0141, IL_014b, IL_015a, IL_017b, IL_01c9, IL_0204
		int num = 2;
		int num2 = num;
		ColumnType result = default(ColumnType);
		while (true)
		{
			switch (num2)
			{
			case 5:
				return new ColumnType(DbType.Int32);
			case 4:
				if (!r4mq36o0tkU5yMRQWQot(propertyMetadata.SubTypeUid, Guid.Empty))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 5;
				}
				continue;
			case 1:
				Y3i3hNo0QqISj4yv6qDG(propertyMetadata, pngRfWo0IvMAZnnK9lCG(0x1ECE530A ^ 0x1ECE1A58));
				num2 = 4;
				continue;
			case 3:
				return result;
			case 2:
				Contract.ArgumentNotNull(entityMetadata, (string)pngRfWo0IvMAZnnK9lCG(-583745292 ^ -583643334));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				EnumMetadata metadata = GetMetadata(DbUExRo0CPsbC1CVdQ64(propertyMetadata), throwOnError: false);
				int num3 = 3;
				while (true)
				{
					ColumnType columnType;
					switch (num3)
					{
					default:
						return result;
					case 0:
						return result;
					case 2:
						if (metadata.Type == EnumMetadataType.Enum)
						{
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
							{
								num3 = 0;
							}
							continue;
						}
						goto case 5;
					case 5:
						columnType = new ColumnType(DbType.Guid);
						break;
					case 3:
						if (metadata == null)
						{
							num3 = 4;
							continue;
						}
						goto case 2;
					case 1:
					case 4:
						columnType = new ColumnType(DbType.Int32);
						break;
					}
					result = columnType;
					num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
					{
						num3 = 0;
					}
				}
			}
			catch (Exception innerException)
			{
				int num4 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
				{
					num4 = 0;
				}
				switch (num4)
				{
				default:
					throw new InvalidOperationException((string)y7ZG6uo0ec0ZX2mSHm4T(pngRfWo0IvMAZnnK9lCG(-218496594 ^ -218591680), propertyMetadata.Name, entityMetadata.FullTypeName), innerException);
				}
			}
		}
	}

	protected override object GetDbDefaultValue(EntityPropertyMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_0098, IL_0170, IL_019a
		int num = 6;
		int num2 = num;
		EnumValueMetadata enumValueMetadata = default(EnumValueMetadata);
		EnumMetadata metadata = default(EnumMetadata);
		_003C_003Ec__DisplayClass31_0 _003C_003Ec__DisplayClass31_ = default(_003C_003Ec__DisplayClass31_0);
		int? intValue = default(int?);
		Guid guid;
		EnumSettings enumSettings = default(EnumSettings);
		while (true)
		{
			int num3;
			switch (num2)
			{
			case 14:
				return null;
			default:
				num3 = 0;
				goto IL_0228;
			case 4:
				if (enumValueMetadata == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 13;
			case 2:
				return null;
			case 11:
				if (metadata != null)
				{
					enumValueMetadata = metadata.Values.FirstOrDefault(_003C_003Ec__DisplayClass31_._003CGetDbDefaultValue_003Eb__0);
					num2 = 10;
				}
				else
				{
					num2 = 14;
				}
				continue;
			case 9:
				if (intValue.HasValue)
				{
					intValue = enumValueMetadata.IntValue;
					num2 = 12;
					continue;
				}
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
				{
					num2 = 1;
				}
				continue;
			case 13:
				intValue = enumValueMetadata.IntValue;
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
				{
					num2 = 9;
				}
				continue;
			case 3:
				metadata = GetMetadata(DbUExRo0CPsbC1CVdQ64(propertyMetadata), throwOnError: false);
				num2 = 11;
				continue;
			case 6:
				_003C_003Ec__DisplayClass31_ = new _003C_003Ec__DisplayClass31_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
				{
					num2 = 5;
				}
				continue;
			case 10:
				if (DVWwtYo0uFh133FPh9Ot(metadata) == EnumMetadataType.Enum)
				{
					num2 = 4;
					continue;
				}
				if (enumValueMetadata == null)
				{
					num2 = 8;
					continue;
				}
				guid = s1S7CDo0aPlU2sfvX5o4(enumValueMetadata);
				break;
			case 8:
				guid = Guid.Empty;
				break;
			case 5:
				if (!(propertyMetadata.SubTypeUid == Guid.Empty))
				{
					enumSettings = uee7V6o0iRYOgHGiyIvd(propertyMetadata) as EnumSettings;
					num2 = 7;
					continue;
				}
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
				{
					num2 = 2;
				}
				continue;
			case 7:
				_003C_003Ec__DisplayClass31_.defaultValue = ((enumSettings != null && enumSettings.DefaultValue.HasValue) ? enumSettings.DefaultValue : new Guid?(Guid.Empty));
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
				{
					num2 = 2;
				}
				continue;
			case 12:
				{
					num3 = intValue.Value;
					goto IL_0228;
				}
				IL_0228:
				return num3;
			}
			break;
		}
		return guid;
	}

	protected EnumMetadata GetMetadata(Guid subTypeUid, bool throwOnError)
	{
		//Discarded unreachable code: IL_0071, IL_00a4, IL_0118, IL_0127, IL_0136
		int num = 4;
		int num2 = num;
		EnumMetadata enumMetadata = default(EnumMetadata);
		while (true)
		{
			switch (num2)
			{
			default:
				return enumMetadata;
			case 4:
				try
				{
					enumMetadata = (EnumMetadata)((IMetadataService)qTpj2Ro0wVm7VKOZhIkL()).GetMetadata(subTypeUid, loadImplementation: true);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
				}
				catch (Exception exception)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
					{
						num4 = 0;
					}
					while (true)
					{
						switch (num4)
						{
						case 1:
							enumMetadata = null;
							num4 = 2;
							continue;
						default:
							base.Logger.Debug(aFE51Oo04QCjagRSq5oK(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-29254301 ^ -29103825), subTypeUid), exception);
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
							{
								num4 = 1;
							}
							continue;
						case 2:
							break;
						}
						break;
					}
				}
				goto case 3;
			case 1:
				return null;
			case 2:
				throw new TypeNotFoundException(subTypeUid);
			case 3:
				if (enumMetadata == null)
				{
					if (throwOnError)
					{
						num2 = 2;
						break;
					}
					goto case 1;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static Guid GetSubtypeUid(Type type)
	{
		int num = 2;
		int num2 = num;
		UidAttribute attribute = default(UidAttribute);
		while (true)
		{
			switch (num2)
			{
			default:
				return Guid.Empty;
			case 1:
				if (attribute != null)
				{
					return attribute.Uid;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				attribute = AttributeHelper<UidAttribute>.GetAttribute(type, inherited: false);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override object SerializeSimple(object value, Type valueType, EntitySerializationSettings settings)
	{
		//Discarded unreachable code: IL_00ce, IL_00dd
		int num = 1;
		int num2 = num;
		Guid guid = default(Guid);
		EnumBase enumBase = default(EnumBase);
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return null;
			case 5:
				guid = NJXE8go066cHcMekdHai(enumBase);
				num2 = 4;
				continue;
			case 4:
				return guid.ToString();
			case 2:
				return num3.ToString();
			case 1:
				if (value != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 3;
			}
			if ((object)(enumBase = value as EnumBase) != null)
			{
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
				{
					num2 = 5;
				}
				continue;
			}
			num3 = (int)value;
			num2 = 2;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
			{
				num2 = 1;
			}
		}
	}

	public override object DeserializeSimple(object value, Type deserializeToType)
	{
		//Discarded unreachable code: IL_00bc, IL_00c6, IL_00d5, IL_00e4, IL_0119, IL_01d3
		int num = 1;
		int num2 = num;
		EnumValueMetadata enumValueMetadata = default(EnumValueMetadata);
		EnumMetadata enumMetadata = default(EnumMetadata);
		_003C_003Ec__DisplayClass35_0 _003C_003Ec__DisplayClass35_ = default(_003C_003Ec__DisplayClass35_0);
		EnumValueMetadata[] array2 = default(EnumValueMetadata[]);
		while (true)
		{
			EnumValueMetadata[] array;
			switch (num2)
			{
			case 7:
				return enumValueMetadata.EnumValue;
			case 13:
				array = enumMetadata.Values.Where(_003C_003Ec__DisplayClass35_._003CDeserializeSimple_003Eb__1).ToArray();
				break;
			case 14:
				return null;
			case 5:
				if (enumMetadata != null)
				{
					_003C_003Ec__DisplayClass35_.valueInt = 0;
					num2 = 15;
				}
				else
				{
					num2 = 14;
				}
				continue;
			case 16:
				return base.DeserializeSimple(value, deserializeToType);
			case 17:
				if (DVWwtYo0uFh133FPh9Ot(enumMetadata) == EnumMetadataType.Enum)
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
					{
						num2 = 2;
					}
					continue;
				}
				goto case 13;
			case 9:
				enumValueMetadata = enumMetadata.Values.FirstOrDefault(_003C_003Ec__DisplayClass35_._003CDeserializeSimple_003Eb__2);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
				{
					num2 = 10;
				}
				continue;
			case 1:
				_003C_003Ec__DisplayClass35_ = new _003C_003Ec__DisplayClass35_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
				{
					num2 = 0;
				}
				continue;
			case 15:
				_003C_003Ec__DisplayClass35_.valueUid = Guid.Empty;
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
				{
					num2 = 1;
				}
				continue;
			case 8:
				return null;
			default:
				if (deserializeToType == null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
					{
						num2 = 0;
					}
				}
				else if (value != null)
				{
					enumMetadata = InterfaceActivator.LoadMetadata(deserializeToType) as EnumMetadata;
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
					{
						num2 = 5;
					}
				}
				else
				{
					num2 = 8;
				}
				continue;
			case 6:
				if (DVWwtYo0uFh133FPh9Ot(enumMetadata) != 0)
				{
					num2 = 19;
					continue;
				}
				goto case 18;
			case 11:
				return null;
			case 20:
				return array2[0].EnumValue;
			case 3:
				if (array2.Length != 0)
				{
					num2 = 20;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
					{
						num2 = 11;
					}
					continue;
				}
				goto case 11;
			case 18:
				if (!int.TryParse(value.ToString(), out _003C_003Ec__DisplayClass35_.valueInt))
				{
					num2 = 12;
					continue;
				}
				goto case 17;
			case 2:
				throw new ArgumentNullException((string)pngRfWo0IvMAZnnK9lCG(0x49E27B8A ^ 0x49E2320E));
			case 10:
				if (enumValueMetadata != null)
				{
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
					{
						num2 = 7;
					}
					continue;
				}
				goto IL_0078;
			case 12:
				return base.DeserializeSimple(value, deserializeToType);
			case 19:
				if (int.TryParse(value.ToString(), out _003C_003Ec__DisplayClass35_.valueInt))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
					{
						num2 = 9;
					}
					continue;
				}
				goto IL_0078;
			case 4:
				{
					array = enumMetadata.Values.Where(_003C_003Ec__DisplayClass35_._003CDeserializeSimple_003Eb__0).ToArray();
					break;
				}
				IL_0078:
				if (Guid.TryParse(value.ToString(), out _003C_003Ec__DisplayClass35_.valueUid))
				{
					num2 = 17;
					continue;
				}
				goto case 16;
			}
			array2 = array;
			num2 = 3;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
			{
				num2 = 0;
			}
		}
	}

	public EnumDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		oP1UVbo0HCr5qtIMePt3();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static EnumDescriptor()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				SingletonReader.JJCZtPuTvSt();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				UID = new Guid((string)pngRfWo0IvMAZnnK9lCG(0x3C5338FF ^ 0x3C51A893));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void Y3i3hNo0QqISj4yv6qDG(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static Guid DbUExRo0CPsbC1CVdQ64(object P_0)
	{
		return ((PropertyMetadata)P_0).SubTypeUid;
	}

	internal static object Sb9cKfo0v4j19Fxyw5yq(object P_0)
	{
		return ((EntityPropertyMetadata)P_0).SimpleTypeSettings;
	}

	internal static object RXDwJ1o08ydFeVRaZ5T8(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static bool BMkBbmo0ZF9VV6I3qOEd(object P_0)
	{
		return ((PropertyMetadata)P_0).Nullable;
	}

	internal static EnumMetadataType DVWwtYo0uFh133FPh9Ot(object P_0)
	{
		return ((EnumMetadata)P_0).Type;
	}

	internal static bool kdp6Qjo0EJo7ppVn2PlD()
	{
		return jYgFD3o0GGl2WNGqU4gV == null;
	}

	internal static EnumDescriptor g8vVVUo0fHIJEcBHQbp4()
	{
		return jYgFD3o0GGl2WNGqU4gV;
	}

	internal static object pngRfWo0IvMAZnnK9lCG(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object WImWEdo0VMhEfNS1Ztnt(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool g7Jtkjo0ShGHKQZYDFru(object P_0, object P_1, object P_2)
	{
		return ((TypeDescriptor)P_0).IsEmpty((PropertyMetadata)P_1, P_2);
	}

	internal static object uee7V6o0iRYOgHGiyIvd(object P_0)
	{
		return ((PropertyMetadata)P_0).Settings;
	}

	internal static EnumRelationType Ht05M6o0RbML8kQM8T1R(object P_0)
	{
		return ((EnumSettings)P_0).RelationType;
	}

	internal static object hNWhmko0qc87X4ust3LZ(object P_0)
	{
		return ((EnumMetadata)P_0).FullTypeName;
	}

	internal static Type PIPHOso0KOMXSboiKVbQ(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object f7Tbypo0XSjgOMwFAwhl(object P_0)
	{
		return ((string)P_0).CreateTypeSyntax();
	}

	internal static bool KmSGplo0TQmBIHB8ZVlV(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object zENVVIo0kPO0NkkkrwXD(object P_0, object P_1)
	{
		return Restrictions.In((string)P_0, (object[])P_1);
	}

	internal static object scwuqro0nrXC1JH0SuuB(object P_0, Guid subTypeUid)
	{
		return ((TypeDescriptor)P_0).GetTypeDisplayName(subTypeUid);
	}

	internal static object Q6SVIvo0Oorc7hhucfbX(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static object LRTdhDo02q9UicWrjiLl(object P_0)
	{
		return ((NamedMetadata)P_0).DisplayName;
	}

	internal static object y7ZG6uo0ec0ZX2mSHm4T(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static object LHAuqRo0PDfLo7BSYA5T(object P_0)
	{
		return EnumHelper.GetDisplayName(P_0);
	}

	internal static bool bwOJyio01fWaRFAxZrpf(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static object LIKXc9o0N8DvWgs00sXW(object P_0, object P_1, object P_2, object P_3)
	{
		return (string)P_0 + (string)P_1 + (string)P_2 + (string)P_3;
	}

	internal static object iyU5w4o030C3gK2wYPD7(object P_0)
	{
		return ((string)P_0).IdentifierName();
	}

	internal static Type Rx9HQFo0peeGsSWPtM8M(object P_0)
	{
		return ((RipeType)P_0).Raw;
	}

	internal static Guid s1S7CDo0aPlU2sfvX5o4(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static object TQWDQho0DcIICiUKakR1(Type enumType, Guid uid)
	{
		return ModelHelper.GetEnumValue(enumType, uid);
	}

	internal static bool r4mq36o0tkU5yMRQWQot(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static object qTpj2Ro0wVm7VKOZhIkL()
	{
		return MetadataServiceContext.Service;
	}

	internal static object aFE51Oo04QCjagRSq5oK(object P_0, object P_1)
	{
		return string.Concat(P_0, P_1);
	}

	internal static Guid NJXE8go066cHcMekdHai(object P_0)
	{
		return ((EnumBase)P_0).Value;
	}

	internal static void oP1UVbo0HCr5qtIMePt3()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
