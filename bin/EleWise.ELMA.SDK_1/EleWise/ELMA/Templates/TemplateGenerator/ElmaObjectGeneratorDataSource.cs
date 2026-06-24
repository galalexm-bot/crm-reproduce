// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Templates.TemplateGenerator.ElmaObjectGeneratorDataSource
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

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
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Templates.TemplateGenerator
{
  /// <summary>
  /// Источник данных на основе объекта с поддержкой специфики ELMA SDK
  /// </summary>
  /// <remarks>
  /// Дополнительно поддерживаются интерфейсы
  /// <see cref="T:EleWise.ELMA.Dynamic.IDynamicObject" />,
  /// <see cref="T:EleWise.ELMA.Dynamic.IExtendedPropertiesContainer" />
  /// </remarks>
  public class ElmaObjectGeneratorDataSource : 
    DefaultObjectGeneratorDataSource,
    ISupportGetPropertyMode
  {
    private GetPropertyMode getPropertyMode;
    private ClassMetadata dataSourceObjectMetadata;
    internal static ElmaObjectGeneratorDataSource u4Ul2MBpyfBHOGDHPLOQ;

    /// <summary>Ctor</summary>
    /// <param name="dataSourceObject">Объект источника данных</param>
    public ElmaObjectGeneratorDataSource(object dataSourceObject)
    {
      ElmaObjectGeneratorDataSource.cgBjVdBp9VWb92fRvlq7();
      // ISSUE: explicit constructor call
      base.\u002Ector(dataSourceObject.CastAsRealType());
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.dataSourceObjectMetadata = dataSourceObject != null ? MetadataLoader.LoadMetadata(ElmaObjectGeneratorDataSource.bZWsEgBpdTuePsiMl1ZG(dataSourceObject).GetType()) as ClassMetadata : (ClassMetadata) null;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <inheritdoc />
    public void SetPropertyGetMode(GetPropertyMode mode)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.getPropertyMode = mode;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Получить значение свойства</summary>
    /// <param name="container">Контейнер (объект)</param>
    /// <param name="name">Имя свойства</param>
    /// <returns>Значение свойства. Если не найдено свойство с таким именем - NULL</returns>
    protected override FormatedValue GetPropertyValue(FormatedValue container, string name)
    {
      int num1 = 42;
      FormatedValue formatedValue;
      object extendedProperty;
      object propertyValue1;
      Type[] genericArguments;
      PropertyDescriptor propertyDescriptor;
      ClassMetadata containerMetadata;
      ElmaObjectGeneratorDataSource generatorDataSource;
      string name1;
      while (true)
      {
        int num2 = num1;
        Type type1;
        while (true)
        {
          IDynamicObject dynamicObject;
          IExtendedPropertiesContainer propertiesContainer;
          MetadataBasedValue metadataBasedValue;
          object obj;
          switch (num2)
          {
            case 1:
              if (propertyDescriptor == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 27 : 7;
                continue;
              }
              goto label_64;
            case 2:
              if (!ElmaObjectGeneratorDataSource.CGX4CNBp5KOZ5DBRTdRo(type1, (Type) null))
              {
                num2 = 9;
                continue;
              }
              goto case 22;
            case 3:
              propertiesContainer = ElmaObjectGeneratorDataSource.tgiWtLBployNCIhGhNWa((object) container) as IExtendedPropertiesContainer;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 12 : 29;
              continue;
            case 4:
              extendedProperty = propertiesContainer.ExtendedProperties[name1];
              num2 = 36;
              continue;
            case 5:
              formatedValue = (FormatedValue) ElmaObjectGeneratorDataSource.Ggi16HBpsY1O0l65ryVo((object) this, (object) container, (object) name1);
              num2 = 25;
              continue;
            case 6:
              if (dynamicObject != null)
              {
                num2 = 21;
                continue;
              }
              goto case 3;
            case 7:
              obj = (object) null;
              goto label_69;
            case 8:
              goto label_25;
            case 9:
              goto label_26;
            case 10:
              if (container != null)
              {
                num2 = 33;
                continue;
              }
              obj = (object) this.dataSourceObjectMetadata;
              goto label_69;
            case 11:
              if (container != null)
              {
                num2 = 39;
                continue;
              }
              goto default;
            case 12:
              dynamicObject = container.Value as IDynamicObject;
              num2 = 6;
              continue;
            case 13:
              if (ElmaObjectGeneratorDataSource.tgiWtLBployNCIhGhNWa((object) container) is ClassMetadataPartsContainer metadataPartsContainer)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 20 : 17;
                continue;
              }
              break;
            case 14:
              goto label_24;
            case 15:
            case 44:
              goto label_42;
            case 16:
              propertyDescriptor = ((PropertyDescriptorCollection) ElmaObjectGeneratorDataSource.lMBeqnBprtPo0pLFM2mb((object) TypeDescriptor.GetProvider(type2).GetTypeDescriptor(type2))).Find(name1, false);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 1;
              continue;
            case 17:
              propertyValue1 = dynamicObject.GetPropertyValue(name1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 30 : 27;
              continue;
            case 18:
              if (propertiesContainer.ExtendedProperties.ContainsKey(name1))
              {
                num2 = 4;
                continue;
              }
              goto label_42;
            case 19:
              if (ElmaObjectGeneratorDataSource.tgiWtLBployNCIhGhNWa((object) container) is Type type2)
                goto case 16;
              else
                goto label_51;
            case 20:
              goto label_66;
            case 21:
              if (!dynamicObject.ContainsProperty(name1))
              {
                num2 = 3;
                continue;
              }
              goto case 17;
            case 22:
              if (!ElmaObjectGeneratorDataSource.Nj7UAnBpj1ma3TL2Tabf(type1))
              {
                num2 = 8;
                continue;
              }
              goto case 28;
            case 23:
              if (!(ElmaObjectGeneratorDataSource.tgiWtLBployNCIhGhNWa((object) container) is ClassMetadata classMetadata))
              {
                num2 = 19;
                continue;
              }
              goto label_49;
            case 24:
            case 31:
              goto label_70;
            case 25:
              if (formatedValue != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 40 : 6;
                continue;
              }
              if (container != null)
              {
                num2 = 32;
                continue;
              }
              goto label_31;
            case 26:
              goto label_31;
            case 27:
              goto label_55;
            case 28:
              genericArguments = type1.GetGenericArguments();
              num2 = 37;
              continue;
            case 29:
              if (propertiesContainer == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 7 : 15;
                continue;
              }
              goto case 34;
            case 30:
              goto label_45;
            case 32:
              if (container.Value != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 12 : 12;
                continue;
              }
              goto label_31;
            case 33:
              if (metadataBasedValue == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 7 : 7;
                continue;
              }
              obj = ElmaObjectGeneratorDataSource.MroPjIBpUdvl8YshZYdw((object) metadataBasedValue);
              goto label_69;
            case 34:
              if (propertiesContainer.ExtendedProperties == null)
              {
                num2 = 44;
                continue;
              }
              goto case 18;
            case 35:
              name1 = name;
              num2 = 11;
              continue;
            case 36:
              goto label_41;
            case 37:
              if (genericArguments.Length == 1)
              {
                num2 = 14;
                continue;
              }
              goto label_25;
            case 38:
              // ISSUE: reference to a compiler-generated method
              containerMetadata.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => ElmaObjectGeneratorDataSource.\u003C\u003Ec__DisplayClass2_0.d9u0jxQKNof9ypcZj4Mc((object) p.Name, (object) name1, StringComparison.CurrentCultureIgnoreCase)));
              num2 = 24;
              continue;
            case 39:
              if (this.getPropertyMode == GetPropertyMode.GetPropertyFromMetadata)
              {
                num2 = 23;
                continue;
              }
              break;
            case 40:
              if (containerMetadata == null)
              {
                num2 = 31;
                continue;
              }
              goto case 38;
            case 41:
              generatorDataSource = this;
              num2 = 35;
              continue;
            case 42:
              num2 = 41;
              continue;
            case 43:
              goto label_49;
            default:
              metadataBasedValue = container as MetadataBasedValue;
              num2 = 10;
              continue;
          }
          ElmaObjectGeneratorDataSource.FASAQGBpLdZ2ss7ytFNu((object) container, ElmaObjectGeneratorDataSource.bZWsEgBpdTuePsiMl1ZG(container.Value));
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 0 : 0;
          continue;
label_69:
          containerMetadata = (ClassMetadata) obj;
          num2 = 5;
        }
label_51:
        num1 = 13;
        continue;
label_55:
        Type type3 = (Type) null;
        goto label_65;
label_64:
        type3 = ElmaObjectGeneratorDataSource.C1lemQBpgf2d5qV0Ql2t((object) propertyDescriptor);
label_65:
        type1 = type3;
        num1 = 2;
      }
label_24:
      return (FormatedValue) ElmaObjectGeneratorDataSource.xyUONvBpYdIGlc1UFjpA((object) this, (object) genericArguments[0]);
label_25:
      return (FormatedValue) ElmaObjectGeneratorDataSource.xyUONvBpYdIGlc1UFjpA((object) this, (object) ElmaObjectGeneratorDataSource.C1lemQBpgf2d5qV0Ql2t((object) propertyDescriptor));
label_26:
      return (FormatedValue) null;
label_31:
      return (FormatedValue) null;
label_41:
      MetadataBasedValue propertyValue2 = new MetadataBasedValue();
      ElmaObjectGeneratorDataSource.FASAQGBpLdZ2ss7ytFNu((object) propertyValue2, extendedProperty);
      propertyValue2.Format = this.GetFormat(containerMetadata, name1, extendedProperty);
      return (FormatedValue) propertyValue2;
label_42:
      return (FormatedValue) null;
label_45:
      MetadataBasedValue propertyValue3 = new MetadataBasedValue();
      ElmaObjectGeneratorDataSource.FASAQGBpLdZ2ss7ytFNu((object) propertyValue3, propertyValue1);
      ElmaObjectGeneratorDataSource.efBJE6BpcZ9kPD4049j9((object) propertyValue3, (object) this.GetFormat(containerMetadata, name1, propertyValue1));
      return (FormatedValue) propertyValue3;
label_49:
      return this.GetPropertyFromMetadata(classMetadata, name1);
label_66:
      return metadataPartsContainer.GetClassMetadataParts().Select<ClassMetadata, FormatedValue>((Func<ClassMetadata, FormatedValue>) (m => generatorDataSource.GetPropertyFromMetadata(m, name1))).FirstOrDefault<FormatedValue>((Func<FormatedValue, bool>) (m => m != null));
label_70:
      MetadataBasedValue propertyValue4 = new MetadataBasedValue();
      ElmaObjectGeneratorDataSource.FASAQGBpLdZ2ss7ytFNu((object) propertyValue4, formatedValue.Value);
      ElmaObjectGeneratorDataSource.efBJE6BpcZ9kPD4049j9((object) propertyValue4, (object) this.GetFormat(containerMetadata, name1, ElmaObjectGeneratorDataSource.tgiWtLBployNCIhGhNWa((object) formatedValue)));
      ElmaObjectGeneratorDataSource.Y5MTBeBpzqHH4xVmdjPY((object) propertyValue4, container == null ? (object) null : ElmaObjectGeneratorDataSource.tgiWtLBployNCIhGhNWa((object) container));
      propertyValue4.PropertyName = name1;
      return (FormatedValue) propertyValue4;
    }

    /// <summary>Создать форматированное значение</summary>
    /// <param name="value"></param>
    /// <returns></returns>
    protected override FormatedValue CreateFormatedValue(object value)
    {
      MetadataBasedValue formatedValue = new MetadataBasedValue();
      ElmaObjectGeneratorDataSource.FASAQGBpLdZ2ss7ytFNu((object) formatedValue, value);
      ElmaObjectGeneratorDataSource.Y5MTBeBpzqHH4xVmdjPY((object) formatedValue, value);
      return (FormatedValue) formatedValue;
    }

    /// <inheritdoc />
    public override BlockInfo EnterBlock(string identifier, FormatedValue value)
    {
      int num = 3;
      BlockInfo blockInfo;
      while (true)
      {
        switch (num)
        {
          case 1:
            ElmaObjectGeneratorDataSource.lWKx6lBaFpbwZAXlYIXf((object) blockInfo, (object) value);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 0 : 0;
            continue;
          case 2:
            if (this.getPropertyMode == GetPropertyMode.GetPropertyFromMetadata)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 1 : 1;
              continue;
            }
            goto label_6;
          case 3:
            blockInfo = base.EnterBlock(identifier, value);
            num = 2;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      return blockInfo;
    }

    private BaseFormat GetFormat(ClassMetadata containerMetadata, string name, object value)
    {
      int num1 = 2;
      PropertyMetadata propertyMetadata1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          PropertyMetadata propertyMetadata2;
          string name1;
          switch (num2)
          {
            case 1:
              name1 = name;
              num2 = 4;
              continue;
            case 2:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 1 : 1;
              continue;
            case 3:
              propertyMetadata2 = (PropertyMetadata) null;
              break;
            case 4:
              if (containerMetadata != null)
              {
                // ISSUE: reference to a compiler-generated method
                propertyMetadata2 = containerMetadata.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => ((string) ElmaObjectGeneratorDataSource.\u003C\u003Ec__DisplayClass7_0.IUoCS4QK6TL1FvLDBP7I((object) p)).Equals(name1, StringComparison.CurrentCultureIgnoreCase)));
                break;
              }
              goto label_4;
            case 5:
              goto label_7;
            default:
              if (!(value is BinaryFile))
              {
                num2 = 5;
                continue;
              }
              goto label_8;
          }
          propertyMetadata1 = propertyMetadata2;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 0;
        }
label_4:
        num1 = 3;
      }
label_7:
      return (BaseFormat) new MetadataBasedFormat()
      {
        PropertyMetadata = propertyMetadata1
      };
label_8:
      return (BaseFormat) new DrawingFormat();
    }

    private FormatedValue GetPropertyFromMetadata(ClassMetadata classMetadata, string name)
    {
      int num = 24;
      IRuntimeTypeDescriptor runtimeTypeDescriptor1;
      INamedMetadata namedMetadata;
      IRuntimeTypeDescriptor runtimeTypeDescriptor2;
      ClassMetadata metadata1;
      while (true)
      {
        EntityMetadata metadata2;
        IMetadataService metadataService;
        Guid metadataUid;
        Guid guid;
        string name1;
        ElmaObjectGeneratorDataSource generatorDataSource;
        switch (num)
        {
          case 1:
            goto label_19;
          case 2:
            goto label_27;
          case 3:
            metadataService = (IMetadataService) ElmaObjectGeneratorDataSource.HsLOmlBaBy5W6gJjRNA6();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 0 : 0;
            continue;
          case 4:
            metadata1 = metadataService.GetMetadata(metadataUid) as ClassMetadata;
            num = 21;
            continue;
          case 5:
            runtimeTypeDescriptor1 = ElmaObjectGeneratorDataSource.hqOFfDBaQE4R21Hw9pdd((object) metadataService, ElmaObjectGeneratorDataSource.e1PAT0BaEgWehOULkrFK((object) propertyMetadata), ElmaObjectGeneratorDataSource.EDjor3BafeMhV5PWRmX5((object) propertyMetadata)) as IRuntimeTypeDescriptor;
            num = 22;
            continue;
          case 6:
            metadata2 = classMetadata as EntityMetadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 13 : 16;
            continue;
          case 7:
            metadata2 = classMetadata as EntityMetadata;
            num = 8;
            continue;
          case 8:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            namedMetadata = MetadataLoader.GetBaseClassMetadataList((ClassMetadata) metadata2, true).SelectMany<ClassMetadata, INamedMetadata>((Func<ClassMetadata, IEnumerable<INamedMetadata>>) (e => generatorDataSource.GetPropertiesFromMetadata(e))).FirstOrDefault<INamedMetadata>((Func<INamedMetadata, bool>) (p => ElmaObjectGeneratorDataSource.\u003C\u003Ec__DisplayClass8_0.gRYPmBQKmKOY8OQeuPZ9(ElmaObjectGeneratorDataSource.\u003C\u003Ec__DisplayClass8_0.HFg93gQK0VhicyQy3nsD((object) p), (object) name1)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 18 : 26;
            continue;
          case 9:
            goto label_4;
          case 10:
            if (runtimeTypeDescriptor2 == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 5 : 13;
              continue;
            }
            goto label_27;
          case 11:
            goto label_10;
          case 12:
            generatorDataSource = this;
            num = 3;
            continue;
          case 13:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            namedMetadata = this.GetPropertiesFromMetadata(classMetadata).FirstOrDefault<INamedMetadata>((Func<INamedMetadata, bool>) (p => ElmaObjectGeneratorDataSource.\u003C\u003Ec__DisplayClass8_0.gRYPmBQKmKOY8OQeuPZ9(ElmaObjectGeneratorDataSource.\u003C\u003Ec__DisplayClass8_0.HFg93gQK0VhicyQy3nsD((object) p), (object) name1)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 3 : 17;
            continue;
          case 14:
            if (!(namedMetadata is PropertyMetadata propertyMetadata))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 8 : 20;
              continue;
            }
            goto case 5;
          case 15:
            // ISSUE: reference to a compiler-generated method
            namedMetadata = MetadataLoader.GetChildClasses((ClassMetadata) metadata2).SelectMany<ClassMetadata, INamedMetadata>((Func<ClassMetadata, IEnumerable<INamedMetadata>>) (e => generatorDataSource.GetPropertiesFromMetadata(e))).FirstOrDefault<INamedMetadata>((Func<INamedMetadata, bool>) (p => ElmaObjectGeneratorDataSource.\u003C\u003Ec__DisplayClass8_0.gRYPmBQKmKOY8OQeuPZ9((object) p.Name, (object) name1)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 14 : 1;
            continue;
          case 16:
            string str1 = name1;
            // ISSUE: type reference
            ParameterExpression parameterExpression = Expression.Parameter(ElmaObjectGeneratorDataSource.XpsHLKBaWk0WoSGnlSjL(__typeref (IEntity<object>)), (string) ElmaObjectGeneratorDataSource.LvUFS7Baoc31K0KrZy5N(1113862659 ^ 1113897515));
            // ISSUE: method reference
            // ISSUE: type reference
            string str2 = LinqUtils.NameOf<IEntity<object>>(Expression.Lambda<Func<IEntity<object>, object>>((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (IEntity<object>.get_Id), __typeref (IEntity<object>))), parameterExpression));
            if (ElmaObjectGeneratorDataSource.x1PN3JBabhaQ5rJKjSa7((object) str1, (object) str2))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 25 : 9;
              continue;
            }
            goto case 13;
          case 17:
            if (namedMetadata == null)
            {
              num = 7;
              continue;
            }
            goto case 14;
          case 18:
            guid = ElmaObjectGeneratorDataSource.e1PAT0BaEgWehOULkrFK((object) propertyMetadata);
            break;
          case 19:
            runtimeTypeDescriptor2 = ElmaObjectGeneratorDataSource.L7c1v3BahWyu7yaF7YYe((object) metadataService, metadata2.IdTypeUid) as IRuntimeTypeDescriptor;
            num = 10;
            continue;
          case 20:
            if (namedMetadata != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 9 : 0;
              continue;
            }
            goto label_5;
          case 21:
            if (metadata1 != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 1;
              continue;
            }
            goto case 20;
          case 22:
            if (runtimeTypeDescriptor1 != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 11 : 0;
              continue;
            }
            if (!ElmaObjectGeneratorDataSource.PqNftJBaCtP5mPvJ3c9N(propertyMetadata.SubTypeUid, Guid.Empty))
            {
              num = 18;
              continue;
            }
            guid = ElmaObjectGeneratorDataSource.EDjor3BafeMhV5PWRmX5((object) propertyMetadata);
            break;
          case 23:
            name1 = name;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 12 : 3;
            continue;
          case 24:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 12 : 23;
            continue;
          case 25:
            if (metadata2 != null)
            {
              num = 19;
              continue;
            }
            goto case 13;
          case 26:
            if (namedMetadata == null)
            {
              num = 15;
              continue;
            }
            goto case 14;
          default:
            namedMetadata = (INamedMetadata) null;
            num = 6;
            continue;
        }
        metadataUid = guid;
        num = 4;
      }
label_4:
      return (FormatedValue) ElmaObjectGeneratorDataSource.xyUONvBpYdIGlc1UFjpA((object) this, (object) namedMetadata);
label_5:
      return (FormatedValue) null;
label_10:
      return (FormatedValue) ElmaObjectGeneratorDataSource.xyUONvBpYdIGlc1UFjpA((object) this, (object) ElmaObjectGeneratorDataSource.OKISNaBaG5uBxTcq4FVM((object) runtimeTypeDescriptor1));
label_19:
      return (FormatedValue) ElmaObjectGeneratorDataSource.xyUONvBpYdIGlc1UFjpA((object) this, (object) metadata1);
label_27:
      return base.CreateFormatedValue((object) ElmaObjectGeneratorDataSource.OKISNaBaG5uBxTcq4FVM((object) runtimeTypeDescriptor2));
    }

    private IEnumerable<INamedMetadata> GetPropertiesFromMetadata(ClassMetadata classMetadata)
    {
      IEnumerable<INamedMetadata> first = classMetadata.Properties.Cast<INamedMetadata>();
      if (classMetadata is EntityMetadata entityMetadata)
        first = first.Union<INamedMetadata>(entityMetadata.TableParts.Cast<INamedMetadata>()).Union<INamedMetadata>(entityMetadata.EntityProperties.Cast<INamedMetadata>()).Union<INamedMetadata>(entityMetadata.EntityTableParts.Cast<INamedMetadata>());
      return first;
    }

    internal static void cgBjVdBp9VWb92fRvlq7() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object bZWsEgBpdTuePsiMl1ZG([In] object obj0) => obj0.CastAsRealType();

    internal static bool kT9KPiBpMF5KbPOMjMlk() => ElmaObjectGeneratorDataSource.u4Ul2MBpyfBHOGDHPLOQ == null;

    internal static ElmaObjectGeneratorDataSource U8gsSxBpJsuDUMAG08Wx() => ElmaObjectGeneratorDataSource.u4Ul2MBpyfBHOGDHPLOQ;

    internal static object tgiWtLBployNCIhGhNWa([In] object obj0) => ((FormatedValue) obj0).Value;

    internal static object lMBeqnBprtPo0pLFM2mb([In] object obj0) => (object) ((ICustomTypeDescriptor) obj0).GetProperties();

    internal static Type C1lemQBpgf2d5qV0Ql2t([In] object obj0) => ((PropertyDescriptor) obj0).PropertyType;

    internal static bool CGX4CNBp5KOZ5DBRTdRo([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static bool Nj7UAnBpj1ma3TL2Tabf(Type type) => type.IsEnumerable();

    internal static object xyUONvBpYdIGlc1UFjpA([In] object obj0, [In] object obj1) => (object) __nonvirtual (((DefaultObjectGeneratorDataSource) obj0).CreateFormatedValue(obj1));

    internal static void FASAQGBpLdZ2ss7ytFNu([In] object obj0, [In] object obj1) => ((FormatedValue) obj0).Value = obj1;

    internal static object MroPjIBpUdvl8YshZYdw([In] object obj0) => (object) ((MetadataBasedValue) obj0).ContainerMetadata;

    internal static object Ggi16HBpsY1O0l65ryVo([In] object obj0, [In] object obj1, [In] object obj2) => (object) __nonvirtual (((DefaultObjectGeneratorDataSource) obj0).GetPropertyValue((FormatedValue) obj1, (string) obj2));

    internal static void efBJE6BpcZ9kPD4049j9([In] object obj0, [In] object obj1) => ((FormatedValue) obj0).Format = (BaseFormat) obj1;

    internal static void Y5MTBeBpzqHH4xVmdjPY([In] object obj0, [In] object obj1) => ((MetadataBasedValue) obj0).Container = obj1;

    internal static void lWKx6lBaFpbwZAXlYIXf([In] object obj0, [In] object obj1) => ((BlockInfo) obj0).CurrentValue = (FormatedValue) obj1;

    internal static object HsLOmlBaBy5W6gJjRNA6() => (object) MetadataServiceContext.Service;

    internal static Type XpsHLKBaWk0WoSGnlSjL([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object LvUFS7Baoc31K0KrZy5N(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool x1PN3JBabhaQ5rJKjSa7([In] object obj0, [In] object obj1) => ((string) obj0).Equals((string) obj1);

    internal static object L7c1v3BahWyu7yaF7YYe([In] object obj0, Guid typeUid) => (object) ((IMetadataService) obj0).GetIdTypeDescriptor(typeUid);

    internal static Type OKISNaBaG5uBxTcq4FVM([In] object obj0) => ((IRuntimeTypeDescriptor) obj0).RuntimeType;

    internal static Guid e1PAT0BaEgWehOULkrFK([In] object obj0) => ((PropertyMetadata) obj0).TypeUid;

    internal static Guid EDjor3BafeMhV5PWRmX5([In] object obj0) => ((PropertyMetadata) obj0).SubTypeUid;

    internal static object hqOFfDBaQE4R21Hw9pdd([In] object obj0, Guid typeUid, Guid subTypeUid) => (object) ((IMetadataService) obj0).GetTypeDescriptor(typeUid, subTypeUid);

    internal static bool PqNftJBaCtP5mPvJ3c9N([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;
  }
}
