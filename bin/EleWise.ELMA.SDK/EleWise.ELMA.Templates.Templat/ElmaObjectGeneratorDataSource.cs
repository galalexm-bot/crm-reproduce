using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.Dynamic;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.TemplateGenerator;
using EleWise.TemplateGenerator.DataSources;
using EleWise.TemplateGenerator.Formats;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Templates.TemplateGenerator;

public class ElmaObjectGeneratorDataSource : DefaultObjectGeneratorDataSource, ISupportGetPropertyMode
{
	private GetPropertyMode getPropertyMode;

	private ClassMetadata dataSourceObjectMetadata;

	internal static ElmaObjectGeneratorDataSource u4Ul2MBpyfBHOGDHPLOQ;

	public ElmaObjectGeneratorDataSource(object dataSourceObject)
	{
		//Discarded unreachable code: IL_0030, IL_0035
		cgBjVdBp9VWb92fRvlq7();
		base._002Ector(dataSourceObject.CastAsRealType());
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
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
			dataSourceObjectMetadata = ((dataSourceObject != null) ? (MetadataLoader.LoadMetadata(bZWsEgBpdTuePsiMl1ZG(dataSourceObject).GetType()) as ClassMetadata) : null);
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
			{
				num = 1;
			}
		}
	}

	public void SetPropertyGetMode(GetPropertyMode mode)
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
				getPropertyMode = mode;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected override FormatedValue GetPropertyValue(FormatedValue container, string name)
	{
		//Discarded unreachable code: IL_00e5, IL_00f4, IL_0121, IL_0130, IL_0174, IL_0183, IL_02fc, IL_0338, IL_03bb, IL_03ca, IL_041a, IL_0495, IL_050a, IL_0537
		int num = 42;
		ClassMetadata classMetadata2 = default(ClassMetadata);
		Type type2 = default(Type);
		IDynamicObject dynamicObject = default(IDynamicObject);
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = default(_003C_003Ec__DisplayClass2_0);
		FormatedValue formatedValue = default(FormatedValue);
		object obj = default(object);
		IExtendedPropertiesContainer extendedPropertiesContainer = default(IExtendedPropertiesContainer);
		MetadataBasedValue metadataBasedValue2 = default(MetadataBasedValue);
		object propertyValue = default(object);
		Type[] genericArguments = default(Type[]);
		PropertyDescriptor propertyDescriptor = default(PropertyDescriptor);
		ClassMetadataPartsContainer classMetadataPartsContainer = default(ClassMetadataPartsContainer);
		Type type = default(Type);
		ClassMetadata classMetadata = default(ClassMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj2;
				object obj3;
				switch (num2)
				{
				case 11:
					if (container != null)
					{
						num2 = 39;
						continue;
					}
					goto default;
				case 23:
					if ((classMetadata2 = tgiWtLBployNCIhGhNWa(container) as ClassMetadata) == null)
					{
						num2 = 19;
						continue;
					}
					goto case 43;
				case 2:
					if (!CGX4CNBp5KOZ5DBRTdRo(type2, null))
					{
						num2 = 9;
						continue;
					}
					goto case 22;
				case 21:
					if (!dynamicObject.ContainsProperty(_003C_003Ec__DisplayClass2_.name))
					{
						num2 = 3;
						continue;
					}
					goto case 17;
				case 5:
					formatedValue = (FormatedValue)Ggi16HBpsY1O0l65ryVo(this, container, _003C_003Ec__DisplayClass2_.name);
					num2 = 25;
					continue;
				case 4:
					obj = extendedPropertiesContainer.ExtendedProperties[_003C_003Ec__DisplayClass2_.name];
					num2 = 36;
					continue;
				case 18:
					if (extendedPropertiesContainer.ExtendedProperties.ContainsKey(_003C_003Ec__DisplayClass2_.name))
					{
						num2 = 4;
						continue;
					}
					goto case 15;
				case 42:
					_003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
					num2 = 41;
					continue;
				case 22:
					if (!Nj7UAnBpj1ma3TL2Tabf(type2))
					{
						num2 = 8;
						continue;
					}
					goto case 28;
				case 25:
					if (formatedValue != null)
					{
						num2 = 40;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
						{
							num2 = 6;
						}
						continue;
					}
					if (container != null)
					{
						num2 = 32;
						continue;
					}
					goto case 26;
				default:
					metadataBasedValue2 = container as MetadataBasedValue;
					num2 = 10;
					continue;
				case 33:
					if (metadataBasedValue2 == null)
					{
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
						{
							num2 = 7;
						}
						continue;
					}
					obj2 = MroPjIBpUdvl8YshZYdw(metadataBasedValue2);
					goto IL_05ff;
				case 17:
					propertyValue = dynamicObject.GetPropertyValue(_003C_003Ec__DisplayClass2_.name);
					num2 = 30;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
					{
						num2 = 27;
					}
					continue;
				case 14:
					return (FormatedValue)xyUONvBpYdIGlc1UFjpA(this, genericArguments[0]);
				case 8:
					return (FormatedValue)xyUONvBpYdIGlc1UFjpA(this, C1lemQBpgf2d5qV0Ql2t(propertyDescriptor));
				case 9:
					return null;
				case 13:
					if ((classMetadataPartsContainer = tgiWtLBployNCIhGhNWa(container) as ClassMetadataPartsContainer) != null)
					{
						num2 = 20;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
						{
							num2 = 17;
						}
						continue;
					}
					goto IL_05ce;
				case 1:
					if (propertyDescriptor == null)
					{
						num2 = 27;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
						{
							num2 = 7;
						}
						continue;
					}
					obj3 = C1lemQBpgf2d5qV0Ql2t(propertyDescriptor);
					goto IL_057d;
				case 26:
					return null;
				case 12:
					dynamicObject = container.Value as IDynamicObject;
					num2 = 6;
					continue;
				case 37:
					if (genericArguments.Length == 1)
					{
						num2 = 14;
						continue;
					}
					goto case 8;
				case 34:
					if (extendedPropertiesContainer.ExtendedProperties == null)
					{
						num2 = 44;
						continue;
					}
					goto case 18;
				case 35:
					_003C_003Ec__DisplayClass2_.name = name;
					num2 = 11;
					continue;
				case 16:
					propertyDescriptor = ((PropertyDescriptorCollection)lMBeqnBprtPo0pLFM2mb(TypeDescriptor.GetProvider(type).GetTypeDescriptor(type))).Find(_003C_003Ec__DisplayClass2_.name, ignoreCase: false);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
					{
						num2 = 1;
					}
					continue;
				case 10:
					if (container != null)
					{
						num2 = 33;
						continue;
					}
					obj2 = dataSourceObjectMetadata;
					goto IL_05ff;
				case 36:
				{
					MetadataBasedValue metadataBasedValue4 = new MetadataBasedValue();
					FASAQGBpLdZ2ss7ytFNu(metadataBasedValue4, obj);
					metadataBasedValue4.Format = GetFormat(classMetadata, _003C_003Ec__DisplayClass2_.name, obj);
					return metadataBasedValue4;
				}
				case 15:
				case 44:
					return null;
				case 41:
					_003C_003Ec__DisplayClass2_._003C_003E4__this = this;
					num2 = 35;
					continue;
				case 30:
				{
					MetadataBasedValue metadataBasedValue3 = new MetadataBasedValue();
					FASAQGBpLdZ2ss7ytFNu(metadataBasedValue3, propertyValue);
					efBJE6BpcZ9kPD4049j9(metadataBasedValue3, GetFormat(classMetadata, _003C_003Ec__DisplayClass2_.name, propertyValue));
					return metadataBasedValue3;
				}
				case 3:
					extendedPropertiesContainer = tgiWtLBployNCIhGhNWa(container) as IExtendedPropertiesContainer;
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
					{
						num2 = 29;
					}
					continue;
				case 32:
					if (container.Value != null)
					{
						num2 = 12;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
						{
							num2 = 12;
						}
						continue;
					}
					goto case 26;
				case 43:
					return GetPropertyFromMetadata(classMetadata2, _003C_003Ec__DisplayClass2_.name);
				case 19:
					if ((object)(type = tgiWtLBployNCIhGhNWa(container) as Type) == null)
					{
						num = 13;
						break;
					}
					goto case 16;
				case 29:
					if (extendedPropertiesContainer == null)
					{
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
						{
							num2 = 15;
						}
						continue;
					}
					goto case 34;
				case 28:
					genericArguments = type2.GetGenericArguments();
					num2 = 37;
					continue;
				case 27:
					obj3 = null;
					goto IL_057d;
				case 40:
					if (classMetadata == null)
					{
						num2 = 31;
						continue;
					}
					goto case 38;
				case 6:
					if (dynamicObject != null)
					{
						num2 = 21;
						continue;
					}
					goto case 3;
				case 7:
					obj2 = null;
					goto IL_05ff;
				case 38:
					classMetadata.Properties.FirstOrDefault(_003C_003Ec__DisplayClass2_._003CGetPropertyValue_003Eb__2);
					num2 = 24;
					continue;
				case 39:
					if (getPropertyMode == GetPropertyMode.GetPropertyFromMetadata)
					{
						num2 = 23;
						continue;
					}
					goto IL_05ce;
				case 20:
					return classMetadataPartsContainer.GetClassMetadataParts().Select(_003C_003Ec__DisplayClass2_._003CGetPropertyValue_003Eb__0).FirstOrDefault((FormatedValue m) => m != null);
				case 24:
				case 31:
					{
						MetadataBasedValue metadataBasedValue = new MetadataBasedValue();
						FASAQGBpLdZ2ss7ytFNu(metadataBasedValue, formatedValue.Value);
						efBJE6BpcZ9kPD4049j9(metadataBasedValue, GetFormat(classMetadata, _003C_003Ec__DisplayClass2_.name, tgiWtLBployNCIhGhNWa(formatedValue)));
						Y5MTBeBpzqHH4xVmdjPY(metadataBasedValue, (container != null) ? tgiWtLBployNCIhGhNWa(container) : null);
						metadataBasedValue.PropertyName = _003C_003Ec__DisplayClass2_.name;
						return metadataBasedValue;
					}
					IL_05ce:
					FASAQGBpLdZ2ss7ytFNu(container, bZWsEgBpdTuePsiMl1ZG(container.Value));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
					{
						num2 = 0;
					}
					continue;
					IL_05ff:
					classMetadata = (ClassMetadata)obj2;
					num2 = 5;
					continue;
					IL_057d:
					type2 = (Type)obj3;
					num = 2;
					break;
				}
				break;
			}
		}
	}

	protected override FormatedValue CreateFormatedValue(object value)
	{
		MetadataBasedValue metadataBasedValue = new MetadataBasedValue();
		FASAQGBpLdZ2ss7ytFNu(metadataBasedValue, value);
		Y5MTBeBpzqHH4xVmdjPY(metadataBasedValue, value);
		return metadataBasedValue;
	}

	public override BlockInfo EnterBlock(string identifier, FormatedValue value)
	{
		int num = 3;
		int num2 = num;
		BlockInfo blockInfo = default(BlockInfo);
		while (true)
		{
			switch (num2)
			{
			case 1:
				lWKx6lBaFpbwZAXlYIXf(blockInfo, value);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				if (getPropertyMode == GetPropertyMode.GetPropertyFromMetadata)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			case 3:
				blockInfo = base.EnterBlock(identifier, value);
				num2 = 2;
				continue;
			}
			break;
		}
		return blockInfo;
	}

	private BaseFormat GetFormat(ClassMetadata containerMetadata, string name, object value)
	{
		//Discarded unreachable code: IL_004e
		int num = 2;
		_003C_003Ec__DisplayClass7_0 _003C_003Ec__DisplayClass7_ = default(_003C_003Ec__DisplayClass7_0);
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 4:
					if (containerMetadata != null)
					{
						obj = containerMetadata.Properties.FirstOrDefault(_003C_003Ec__DisplayClass7_._003CGetFormat_003Eb__0);
						break;
					}
					goto end_IL_0012;
				case 3:
					obj = null;
					break;
				case 1:
					_003C_003Ec__DisplayClass7_.name = name;
					num2 = 4;
					continue;
				case 5:
					return new MetadataBasedFormat
					{
						PropertyMetadata = propertyMetadata
					};
				default:
					if (value is BinaryFile)
					{
						return new DrawingFormat();
					}
					num2 = 5;
					continue;
				case 2:
					_003C_003Ec__DisplayClass7_ = new _003C_003Ec__DisplayClass7_0();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				propertyMetadata = (PropertyMetadata)obj;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
				{
					num2 = 0;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 3;
		}
	}

	private FormatedValue GetPropertyFromMetadata(ClassMetadata classMetadata, string name)
	{
		//Discarded unreachable code: IL_01c2, IL_0262, IL_0356
		int num = 24;
		int num2 = num;
		IRuntimeTypeDescriptor runtimeTypeDescriptor = default(IRuntimeTypeDescriptor);
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		INamedMetadata namedMetadata = default(INamedMetadata);
		EntityMetadata entityMetadata = default(EntityMetadata);
		_003C_003Ec__DisplayClass8_0 _003C_003Ec__DisplayClass8_ = default(_003C_003Ec__DisplayClass8_0);
		IRuntimeTypeDescriptor runtimeTypeDescriptor2 = default(IRuntimeTypeDescriptor);
		IMetadataService metadataService = default(IMetadataService);
		ClassMetadata classMetadata2 = default(ClassMetadata);
		Guid metadataUid = default(Guid);
		while (true)
		{
			Guid guid;
			switch (num2)
			{
			case 22:
				if (runtimeTypeDescriptor != null)
				{
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				if (!PqNftJBaCtP5mPvJ3c9N(propertyMetadata.SubTypeUid, Guid.Empty))
				{
					num2 = 18;
					continue;
				}
				guid = EDjor3BafeMhV5PWRmX5(propertyMetadata);
				break;
			case 9:
				return (FormatedValue)xyUONvBpYdIGlc1UFjpA(this, namedMetadata);
			default:
				namedMetadata = null;
				num2 = 6;
				continue;
			case 7:
				entityMetadata = classMetadata as EntityMetadata;
				num2 = 8;
				continue;
			case 8:
				namedMetadata = MetadataLoader.GetBaseClassMetadataList(entityMetadata, includeExtensions: true).SelectMany(_003C_003Ec__DisplayClass8_._003CGetPropertyFromMetadata_003Eb__2).FirstOrDefault(_003C_003Ec__DisplayClass8_._003CGetPropertyFromMetadata_003Eb__3);
				num2 = 18;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
				{
					num2 = 26;
				}
				continue;
			case 19:
				runtimeTypeDescriptor2 = L7c1v3BahWyu7yaF7YYe(metadataService, entityMetadata.IdTypeUid) as IRuntimeTypeDescriptor;
				num2 = 10;
				continue;
			case 11:
				return (FormatedValue)xyUONvBpYdIGlc1UFjpA(this, OKISNaBaG5uBxTcq4FVM(runtimeTypeDescriptor));
			case 23:
				_003C_003Ec__DisplayClass8_.name = name;
				num2 = 12;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
				{
					num2 = 3;
				}
				continue;
			case 24:
				_003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_0();
				num2 = 12;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
				{
					num2 = 23;
				}
				continue;
			case 12:
				_003C_003Ec__DisplayClass8_._003C_003E4__this = this;
				num2 = 3;
				continue;
			case 14:
				if ((propertyMetadata = namedMetadata as PropertyMetadata) == null)
				{
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
					{
						num2 = 20;
					}
					continue;
				}
				goto case 5;
			case 5:
				runtimeTypeDescriptor = hqOFfDBaQE4R21Hw9pdd(metadataService, e1PAT0BaEgWehOULkrFK(propertyMetadata), EDjor3BafeMhV5PWRmX5(propertyMetadata)) as IRuntimeTypeDescriptor;
				num2 = 22;
				continue;
			case 1:
				return (FormatedValue)xyUONvBpYdIGlc1UFjpA(this, classMetadata2);
			case 20:
				if (namedMetadata == null)
				{
					return null;
				}
				num2 = 9;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
				{
					num2 = 0;
				}
				continue;
			case 26:
				if (namedMetadata == null)
				{
					num2 = 15;
					continue;
				}
				goto case 14;
			case 18:
				guid = e1PAT0BaEgWehOULkrFK(propertyMetadata);
				break;
			case 15:
				namedMetadata = MetadataLoader.GetChildClasses(entityMetadata).SelectMany(_003C_003Ec__DisplayClass8_._003CGetPropertyFromMetadata_003Eb__4).FirstOrDefault(_003C_003Ec__DisplayClass8_._003CGetPropertyFromMetadata_003Eb__5);
				num2 = 14;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
				{
					num2 = 1;
				}
				continue;
			case 6:
				entityMetadata = classMetadata as EntityMetadata;
				num2 = 13;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
				{
					num2 = 16;
				}
				continue;
			case 2:
				return base.CreateFormatedValue(OKISNaBaG5uBxTcq4FVM(runtimeTypeDescriptor2));
			case 13:
				namedMetadata = GetPropertiesFromMetadata(classMetadata).FirstOrDefault(_003C_003Ec__DisplayClass8_._003CGetPropertyFromMetadata_003Eb__1);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
				{
					num2 = 17;
				}
				continue;
			case 17:
				if (namedMetadata == null)
				{
					num2 = 7;
					continue;
				}
				goto case 14;
			case 25:
				if (entityMetadata != null)
				{
					num2 = 19;
					continue;
				}
				goto case 13;
			case 4:
				classMetadata2 = metadataService.GetMetadata(metadataUid) as ClassMetadata;
				num2 = 21;
				continue;
			case 10:
				if (runtimeTypeDescriptor2 == null)
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
					{
						num2 = 13;
					}
					continue;
				}
				goto case 2;
			case 21:
				if (classMetadata2 != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
					{
						num2 = 1;
					}
					continue;
				}
				goto case 20;
			case 3:
				metadataService = (IMetadataService)HsLOmlBaBy5W6gJjRNA6();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
				{
					num2 = 0;
				}
				continue;
			case 16:
			{
				string name2 = _003C_003Ec__DisplayClass8_.name;
				ParameterExpression parameterExpression = Expression.Parameter(XpsHLKBaWk0WoSGnlSjL(typeof(IEntity<object>).TypeHandle), (string)LvUFS7Baoc31K0KrZy5N(0x42643203 ^ 0x4264BA2B));
				if (x1PN3JBabhaQ5rJKjSa7(name2, LinqUtils.NameOf(Expression.Lambda<Func<IEntity<object>, object>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(IEntity<object>).TypeHandle)), new ParameterExpression[1] { parameterExpression }))))
				{
					num2 = 25;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
					{
						num2 = 9;
					}
					continue;
				}
				goto case 13;
			}
			}
			metadataUid = guid;
			num2 = 4;
		}
	}

	private IEnumerable<INamedMetadata> GetPropertiesFromMetadata(ClassMetadata classMetadata)
	{
		IEnumerable<INamedMetadata> enumerable = classMetadata.Properties.Cast<INamedMetadata>();
		if (classMetadata is EntityMetadata entityMetadata)
		{
			enumerable = enumerable.Union(entityMetadata.TableParts.Cast<INamedMetadata>()).Union(((IEnumerable)entityMetadata.EntityProperties).Cast<INamedMetadata>()).Union(((IEnumerable)entityMetadata.EntityTableParts).Cast<INamedMetadata>());
		}
		return enumerable;
	}

	internal static void cgBjVdBp9VWb92fRvlq7()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object bZWsEgBpdTuePsiMl1ZG(object P_0)
	{
		return P_0.CastAsRealType();
	}

	internal static bool kT9KPiBpMF5KbPOMjMlk()
	{
		return u4Ul2MBpyfBHOGDHPLOQ == null;
	}

	internal static ElmaObjectGeneratorDataSource U8gsSxBpJsuDUMAG08Wx()
	{
		return u4Ul2MBpyfBHOGDHPLOQ;
	}

	internal static object tgiWtLBployNCIhGhNWa(object P_0)
	{
		return ((FormatedValue)P_0).Value;
	}

	internal static object lMBeqnBprtPo0pLFM2mb(object P_0)
	{
		return ((ICustomTypeDescriptor)P_0).GetProperties();
	}

	internal static Type C1lemQBpgf2d5qV0Ql2t(object P_0)
	{
		return ((PropertyDescriptor)P_0).PropertyType;
	}

	internal static bool CGX4CNBp5KOZ5DBRTdRo(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static bool Nj7UAnBpj1ma3TL2Tabf(Type type)
	{
		return type.IsEnumerable();
	}

	internal static object xyUONvBpYdIGlc1UFjpA(object P_0, object P_1)
	{
		return ((DefaultObjectGeneratorDataSource)P_0).CreateFormatedValue(P_1);
	}

	internal static void FASAQGBpLdZ2ss7ytFNu(object P_0, object P_1)
	{
		((FormatedValue)P_0).Value = P_1;
	}

	internal static object MroPjIBpUdvl8YshZYdw(object P_0)
	{
		return ((MetadataBasedValue)P_0).ContainerMetadata;
	}

	internal static object Ggi16HBpsY1O0l65ryVo(object P_0, object P_1, object P_2)
	{
		return ((DefaultObjectGeneratorDataSource)P_0).GetPropertyValue((FormatedValue)P_1, (string)P_2);
	}

	internal static void efBJE6BpcZ9kPD4049j9(object P_0, object P_1)
	{
		((FormatedValue)P_0).Format = (BaseFormat)P_1;
	}

	internal static void Y5MTBeBpzqHH4xVmdjPY(object P_0, object P_1)
	{
		((MetadataBasedValue)P_0).Container = P_1;
	}

	internal static void lWKx6lBaFpbwZAXlYIXf(object P_0, object P_1)
	{
		((BlockInfo)P_0).CurrentValue = (FormatedValue)P_1;
	}

	internal static object HsLOmlBaBy5W6gJjRNA6()
	{
		return MetadataServiceContext.Service;
	}

	internal static Type XpsHLKBaWk0WoSGnlSjL(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object LvUFS7Baoc31K0KrZy5N(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool x1PN3JBabhaQ5rJKjSa7(object P_0, object P_1)
	{
		return ((string)P_0).Equals((string)P_1);
	}

	internal static object L7c1v3BahWyu7yaF7YYe(object P_0, Guid typeUid)
	{
		return ((IMetadataService)P_0).GetIdTypeDescriptor(typeUid);
	}

	internal static Type OKISNaBaG5uBxTcq4FVM(object P_0)
	{
		return ((IRuntimeTypeDescriptor)P_0).RuntimeType;
	}

	internal static Guid e1PAT0BaEgWehOULkrFK(object P_0)
	{
		return ((PropertyMetadata)P_0).TypeUid;
	}

	internal static Guid EDjor3BafeMhV5PWRmX5(object P_0)
	{
		return ((PropertyMetadata)P_0).SubTypeUid;
	}

	internal static object hqOFfDBaQE4R21Hw9pdd(object P_0, Guid typeUid, Guid subTypeUid)
	{
		return ((IMetadataService)P_0).GetTypeDescriptor(typeUid, subTypeUid);
	}

	internal static bool PqNftJBaCtP5mPvJ3c9N(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}
}
