// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.EnumDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

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
using EleWise.ELMA.Runtime.NH.CustomTypes;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Types
{
  /// <summary>Описание типа "Перечисление"</summary>
  [Component(Order = 600)]
  public class EnumDescriptor : 
    SimpleTypeDescriptor<Enum, EnumSettings>,
    IMappingTypeDescriptor,
    IConvertableTypeDescriptor
  {
    /// <summary>Uid типа</summary>
    public const string UID_S = "{849C1AC9-4D46-4194-8CBB-43F84ADF9C17}";
    /// <summary>Uid типа</summary>
    public static readonly Guid UID;
    private IFullTextPropertyDescriptor propertyDescriptor;
    internal static EnumDescriptor jYgFD3o0GGl2WNGqU4gV;

    /// <summary>Создать мэппинг свойства</summary>
    /// <param name="mappingBuilder">Мэппинг</param>
    /// <param name="metadata">Метаданные</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    protected override void CreatePropertyMapping(
      INHibernatePropertiesMapper mappingBuilder,
      ClassMetadata metadata,
      EntityPropertyMetadata propertyMetadata)
    {
      int num1 = 6;
      while (true)
      {
        int num2 = num1;
        EnumMetadata enumPropertyMetadata;
        EntityPropertyMetadata propertyMetadata1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_7;
            case 2:
              goto label_11;
            case 3:
              if (EnumDescriptor.Sb9cKfo0v4j19Fxyw5yq((object) propertyMetadata1) == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 4 : 4;
                continue;
              }
              mappingBuilder.Property((string) EnumDescriptor.RXDwJ1o08ydFeVRaZ5T8((object) propertyMetadata1), ((SimpleTypeSettings) EnumDescriptor.Sb9cKfo0v4j19Fxyw5yq((object) propertyMetadata1)).FieldName, (Action<INHibernatePropertyTypeMapper>) (mapper =>
              {
                int num3 = 1;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      if (EnumDescriptor.\u003C\u003Ec__DisplayClass0_0.on8GnQCIal23yGcxYq2h((object) enumPropertyMetadata) != EnumMetadataType.Enum)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 0 : 0;
                        continue;
                      }
                      goto label_6;
                    case 2:
                      goto label_2;
                    default:
                      // ISSUE: type reference
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      EnumDescriptor.\u003C\u003Ec__DisplayClass0_0.ExoFh9CI4FTuXu2CBBeW((object) mapper, EnumDescriptor.\u003C\u003Ec__DisplayClass0_0.t3SImKCIDocWSfrAAxOF(__typeref (EnumNHType<>)).MakeGenericType(((IMetadataRuntimeService) EnumDescriptor.\u003C\u003Ec__DisplayClass0_0.F0i6ZdCItl6otxX1nD9Y()).GetTypeByUid(EnumDescriptor.\u003C\u003Ec__DisplayClass0_0.heEA6yCIw0T2D42AT7jL((object) propertyMetadata1))));
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 0 : 2;
                      continue;
                  }
                }
label_2:
                return;
label_6:;
              }), !EnumDescriptor.BMkBbmo0ZF9VV6I3qOEd((object) propertyMetadata1), sqlType: EnumDescriptor.DVWwtYo0uFh133FPh9Ot((object) enumPropertyMetadata) != EnumMetadataType.Enum ? (string) null : z2jc63fLkugS1X8Q9N.tE1kD1vbB(694673736 ^ -23604109 ^ -671958515));
              num2 = 2;
              continue;
            case 4:
              goto label_8;
            case 5:
              propertyMetadata1 = propertyMetadata;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 0 : 0;
              continue;
            case 6:
              num2 = 5;
              continue;
            default:
              EnumDescriptor.Y3i3hNo0QqISj4yv6qDG((object) propertyMetadata1, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(647913418 ^ 647894680));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 1 : 0;
              continue;
          }
        }
label_7:
        enumPropertyMetadata = this.GetMetadata(EnumDescriptor.DbUExRo0CPsbC1CVdQ64((object) propertyMetadata1), true);
        num1 = 3;
      }
label_11:
      return;
label_8:;
    }

    /// <summary>Uid типа</summary>
    public override Guid Uid => EnumDescriptor.UID;

    /// <summary>Имя "Перечисление"</summary>
    public override string Name => (string) EnumDescriptor.WImWEdo0VMhEfNS1Ztnt(EnumDescriptor.pngRfWo0IvMAZnnK9lCG(712480695 ^ 712317175));

    /// <summary>Uid родительской группы типов данных - корневая папка</summary>
    public override Guid ParentUid => Guid.Empty;

    /// <summary>Может ли тип быть Nullable</summary>
    public override bool CanBeNullable => true;

    /// <summary>
    /// Значение признака Nullable по умолчанию (используется, если CanBeNullable=true)
    /// </summary>
    public override bool? DefaultNullableValue => new bool?(false);

    public override bool IsAvailibleEditPropertyInTable => true;

    /// <summary>Пустое значение или нет</summary>
    /// <param name="propertyMetadata"></param>
    /// <param name="val"></param>
    /// <returns></returns>
    public override bool IsEmpty(PropertyMetadata propertyMetadata, object val)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (val is Enum)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 1 : 0;
              continue;
            }
            goto label_4;
          default:
            goto label_4;
        }
      }
label_4:
      return !(val is EnumBase);
label_5:
      return false;
    }

    /// <summary>
    /// Является ли значение пустым или значением по умолчанию
    /// </summary>
    /// <param name="propertyMetadata"></param>
    /// <param name="val"></param>
    /// <returns></returns>
    public override bool IsEmptyOrDefault(PropertyMetadata propertyMetadata, object val)
    {
      int num = 6;
      EnumValueMetadata enumValueMetadata;
      Guid? defaultValue;
      PropertyMetadata propertyMetadata1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!EnumDescriptor.g7Jtkjo0ShGHKQZYDFru((object) this, (object) propertyMetadata1, val))
            {
              num = 10;
              continue;
            }
            goto label_8;
          case 2:
            if (enumValueMetadata != null)
            {
              num = 7;
              continue;
            }
            goto label_4;
          case 3:
            if (val == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 4 : 0;
              continue;
            }
            goto case 1;
          case 4:
          case 9:
            goto label_8;
          case 5:
            propertyMetadata1 = propertyMetadata;
            num = 3;
            continue;
          case 6:
            num = 5;
            continue;
          case 7:
            goto label_3;
          case 8:
            defaultValue = ((EnumSettings) propertyMetadata1.Settings).DefaultValue;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 4 : 11;
            continue;
          case 10:
            if (propertyMetadata1.Nullable)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 8 : 2;
              continue;
            }
            goto label_6;
          case 11:
            if (defaultValue.HasValue)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            enumValueMetadata = this.GetMetadata(propertyMetadata1.SubTypeUid, false).Values.FirstOrDefault<EnumValueMetadata>((System.Func<EnumValueMetadata, bool>) (v => EnumDescriptor.\u003C\u003Ec__DisplayClass16_0.YhHCQ4CImbu98WqV3aXF(EnumDescriptor.\u003C\u003Ec__DisplayClass16_0.LoAQCyCIxO5tgG7V2OJq((object) v), ((EnumSettings) EnumDescriptor.\u003C\u003Ec__DisplayClass16_0.bmK0O6CI0oG9evWPZtMa((object) propertyMetadata1)).DefaultValue.Value)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 1 : 2;
            continue;
        }
      }
label_3:
      return enumValueMetadata.EnumValue.Equals(val);
label_4:
      return false;
label_5:
      return false;
label_6:
      return ModelHelper.GetEnumDefaultValue(val.GetType()).Equals(val);
label_8:
      return true;
    }

    /// <summary>
    /// Получить список подтипов - список перечислений, разбитых по папкам
    /// </summary>
    /// <param name="classMetadata">Метаданные класса</param>
    /// <returns>Список подтипов</returns>
    public override IEnumerable<ITypeDescriptor> GetSubTypes(ClassMetadata classMetadata) => CompositeTypeDescriptorHelper.GetDescriptorsByGroups((ITypeDescriptor) this, MetadataServiceContext.Service.GetMetadataList().Where<IMetadata>((System.Func<IMetadata, bool>) (m =>
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_6;
          case 2:
            if (!((EnumMetadata) m).ShowInTypeTree)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 0 : 0;
              continue;
            }
            goto label_6;
          case 3:
            // ISSUE: type reference
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            if (EnumDescriptor.\u003C\u003Ec.Bx8UOSCIdpC81EopSgua(m.GetType(), EnumDescriptor.\u003C\u003Ec.A5ROftCI9fZyUJODp0kk(__typeref (EnumMetadata))))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 2 : 2;
              continue;
            }
            goto label_7;
          default:
            goto label_7;
        }
      }
label_6:
      // ISSUE: reference to a compiler-generated method
      return EnumDescriptor.\u003C\u003Ec.XI9ZChCIlbIuZE4IDDC7((object) (EnumMetadata) m) != EnumMetadataType.EnumExtension;
label_7:
      return false;
    })).Cast<NamedMetadata>().OrderBy<NamedMetadata, string>((System.Func<NamedMetadata, string>) (o => (string) EnumDescriptor.\u003C\u003Ec.zKkNHTCIrtOXeT53sv6p((object) o))).ToList<NamedMetadata>());

    /// <summary>Получить ссылку на тип данных для свойства</summary>
    /// <param name="classMetadata">Метаданные класса</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <param name="forFilter">True, если свойство генерируется для фильтра</param>
    /// <returns>Ссылка на тип данных</returns>
    public override ISyntaxNode GetPropertyTypeReference(
      ClassMetadata classMetadata,
      PropertyMetadata propertyMetadata,
      bool forFilter)
    {
      int num = 1;
      EnumSettings enumSettings;
      EnumMetadata metadata;
      while (true)
      {
        switch (num)
        {
          case 1:
            EnumDescriptor.Y3i3hNo0QqISj4yv6qDG((object) propertyMetadata, EnumDescriptor.pngRfWo0IvMAZnnK9lCG(-1317790512 ^ -1317775998));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_7;
          case 3:
            enumSettings = (EnumSettings) EnumDescriptor.uee7V6o0iRYOgHGiyIvd((object) propertyMetadata);
            num = 7;
            continue;
          case 4:
          case 6:
            goto label_6;
          case 5:
            if (EnumDescriptor.Ht05M6o0RbML8kQM8T1R((object) enumSettings) != EnumRelationType.Many)
            {
              num = 8;
              continue;
            }
            goto label_8;
          case 7:
            if (forFilter)
            {
              num = 5;
              continue;
            }
            goto case 8;
          case 8:
            if (!EnumDescriptor.BMkBbmo0ZF9VV6I3qOEd((object) propertyMetadata))
            {
              num = 4;
              continue;
            }
            goto case 9;
          case 9:
            if (metadata.Type == EnumMetadataType.Enum)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 2 : 2;
              continue;
            }
            goto label_6;
          default:
            metadata = this.GetMetadata(EnumDescriptor.DbUExRo0CPsbC1CVdQ64((object) propertyMetadata), true);
            num = 3;
            continue;
        }
      }
label_6:
      return ((string) EnumDescriptor.hNWhmko0qc87X4ust3LZ((object) metadata)).CreateTypeSyntax();
label_7:
      // ISSUE: type reference
      return EnumDescriptor.PIPHOso0KOMXSboiKVbQ(__typeref (Nullable<>)).CreateTypeSyntax((ISyntaxNode) EnumDescriptor.f7Tbypo0XSjgOMwFAwhl(EnumDescriptor.hNWhmko0qc87X4ust3LZ((object) metadata)));
label_8:
      // ISSUE: type reference
      return EnumDescriptor.PIPHOso0KOMXSboiKVbQ(__typeref (List<>)).CreateTypeSyntax((ISyntaxNode) EnumDescriptor.f7Tbypo0XSjgOMwFAwhl(EnumDescriptor.hNWhmko0qc87X4ust3LZ((object) metadata)));
    }

    public override void ApplyFilterValue(
      ICriteria criteria,
      EntityMetadata metadata,
      EntityPropertyMetadata propertyMetadata,
      object value,
      string alias)
    {
      int num = 4;
      object[] array;
      IEnumerable source;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (array.Length != 0)
            {
              num = 6;
              continue;
            }
            goto label_4;
          case 2:
            goto label_13;
          case 3:
            source = value as IEnumerable;
            num = 7;
            continue;
          case 4:
            if (value != null)
            {
              num = 3;
              continue;
            }
            goto label_6;
          case 5:
            array = source.OfType<object>().ToArray<object>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 1 : 1;
            continue;
          case 6:
            criteria.Add((ICriterion) EnumDescriptor.zENVVIo0kPO0NkkkrwXD(EnumDescriptor.KmSGplo0TQmBIHB8ZVlV((object) alias) ? (object) propertyMetadata.Name : (object) string.Format((string) EnumDescriptor.pngRfWo0IvMAZnnK9lCG(2045296739 + 1688595713 ^ -561057946), (object) alias, EnumDescriptor.RXDwJ1o08ydFeVRaZ5T8((object) propertyMetadata)), (object) array));
            num = 10;
            continue;
          case 7:
            if (source == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
              continue;
            }
            goto case 5;
          case 8:
            goto label_5;
          case 9:
            goto label_14;
          case 10:
            goto label_11;
          default:
            base.ApplyFilterValue(criteria, metadata, propertyMetadata, value, alias);
            num = 2;
            continue;
        }
      }
label_13:
      return;
label_5:
      return;
label_14:
      return;
label_11:
      return;
label_4:
      return;
label_6:;
    }

    /// <summary>
    /// Получить отображаемое имя типа у свойства - в соответствии с выбранным перечислением
    /// </summary>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <returns>Отображаемое имя типа у свойства</returns>
    public override string GetPropertyTypeDisplayName(PropertyMetadata propertyMetadata)
    {
      int num1 = 2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_4;
          case 2:
            EnumDescriptor.Y3i3hNo0QqISj4yv6qDG((object) propertyMetadata, EnumDescriptor.pngRfWo0IvMAZnnK9lCG(1218962250 ^ 1218947608));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 1 : 1;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      string propertyTypeDisplayName;
      return propertyTypeDisplayName;
label_4:
      try
      {
        propertyTypeDisplayName = (string) EnumDescriptor.scwuqro0nrXC1JH0SuuB((object) this, EnumDescriptor.DbUExRo0CPsbC1CVdQ64((object) propertyMetadata));
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
          num2 = 0;
        switch (num2)
        {
          default:
            goto label_2;
        }
      }
      catch (Exception ex)
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
          num3 = 0;
        switch (num3)
        {
          default:
            throw new InvalidOperationException((string) EnumDescriptor.Q6SVIvo0Oorc7hhucfbX(EnumDescriptor.pngRfWo0IvMAZnnK9lCG(-1217523399 ^ -1217618331), EnumDescriptor.RXDwJ1o08ydFeVRaZ5T8((object) propertyMetadata)), ex);
        }
      }
    }

    /// <summary>Получить отображаемое имя типа</summary>
    /// <param name="subTypeUid">Уникальные идентификатор подтипа</param>
    /// <returns></returns>
    public override string GetTypeDisplayName(Guid subTypeUid)
    {
      int num = 1;
      EnumMetadata metadata;
      while (true)
      {
        switch (num)
        {
          case 1:
            metadata = this.GetMetadata(subTypeUid, false);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return (string) EnumDescriptor.y7ZG6uo0ec0ZX2mSHm4T(EnumDescriptor.pngRfWo0IvMAZnnK9lCG(-2138160520 ^ -2138295988), metadata == null ? (object) "" : EnumDescriptor.WImWEdo0VMhEfNS1Ztnt(EnumDescriptor.LRTdhDo02q9UicWrjiLl((object) metadata)), (object) EleWise.ELMA.SR.T((string) EnumDescriptor.pngRfWo0IvMAZnnK9lCG(-1867198571 ^ -1867104217)));
    }

    /// <summary>Форматировать значение</summary>
    /// <param name="value">Значение</param>
    /// <param name="settings">Настройки свойства</param>
    /// <returns>Сформатированное значение</returns>
    public override string FormatValue(object value, TypeSettings settings)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (value == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return base.FormatValue(value, settings);
label_3:
      return (string) EnumDescriptor.LHAuqRo0PDfLo7BSYA5T(value);
    }

    private EnumValueMetadata GetPropertyDefaultValue(
      ClassMetadata classMetadata,
      PropertyMetadata propertyMetadata,
      bool forFilter = false)
    {
      int num1 = 26;
      EnumValueMetadata propertyDefaultValue;
      while (true)
      {
        int num2 = num1;
        Guid? nullable;
        EnumSettings setting;
        while (true)
        {
          EnumMetadata enumMetadata;
          switch (num2)
          {
            case 1:
            case 3:
            case 22:
            case 27:
              if (propertyDefaultValue == null)
                goto case 31;
              else
                goto label_30;
            case 2:
              goto label_4;
            case 4:
            case 6:
            case 16:
            case 28:
              if (!EnumDescriptor.BMkBbmo0ZF9VV6I3qOEd((object) propertyMetadata))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 10 : 18;
                continue;
              }
              goto label_34;
            case 5:
              if (setting != null)
                goto case 30;
              else
                goto label_26;
            case 7:
              if (nullable.HasValue)
              {
                num2 = 10;
                continue;
              }
              goto case 4;
            case 8:
              if (forFilter)
              {
                num2 = 4;
                continue;
              }
              goto case 5;
            case 9:
              nullable = enumMetadata.DefaultValueUid;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 19 : 16;
              continue;
            case 10:
              goto label_31;
            case 11:
              if (!EnumDescriptor.bwOJyio01fWaRFAxZrpf(nullable.Value, Guid.Empty))
              {
                num2 = 16;
                continue;
              }
              goto case 23;
            case 12:
              propertyDefaultValue = enumMetadata.Values.FirstOrDefault<EnumValueMetadata>();
              num2 = 20;
              continue;
            case 13:
              nullable = enumMetadata.DefaultValueUid;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 22 : 32;
              continue;
            case 14:
              enumMetadata = this.GetMetadata(EnumDescriptor.DbUExRo0CPsbC1CVdQ64((object) propertyMetadata), false);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 21 : 21;
              continue;
            case 15:
              setting = (EnumSettings) EnumDescriptor.uee7V6o0iRYOgHGiyIvd((object) propertyMetadata);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 14 : 0;
              continue;
            case 17:
            case 20:
              goto label_34;
            case 18:
              if (propertyDefaultValue != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 1;
                continue;
              }
              goto case 9;
            case 19:
              if (!nullable.HasValue)
              {
                num2 = 3;
                continue;
              }
              goto case 13;
            case 21:
              if (enumMetadata != null)
              {
                propertyDefaultValue = (EnumValueMetadata) null;
                num2 = 8;
                continue;
              }
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 1 : 2;
              continue;
            case 23:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              propertyDefaultValue = enumMetadata.Values.FirstOrDefault<EnumValueMetadata>((System.Func<EnumValueMetadata, bool>) (v => EnumDescriptor.\u003C\u003Ec__DisplayClass23_0.JTSuMtCIU3n0GNDdF2mo(EnumDescriptor.\u003C\u003Ec__DisplayClass23_0.imS8sMCILUwJwm2evjZb((object) v), setting.DefaultValue.Value)));
              num2 = 28;
              continue;
            case 24:
            case 29:
              if (propertyDefaultValue != null)
              {
                num2 = 17;
                continue;
              }
              goto case 12;
            case 25:
              EnumDescriptor.Y3i3hNo0QqISj4yv6qDG((object) propertyMetadata, EnumDescriptor.pngRfWo0IvMAZnnK9lCG(1232639661 >> 3 ^ 154098567));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 15 : 8;
              continue;
            case 26:
              num2 = 25;
              continue;
            case 30:
              nullable = setting.DefaultValue;
              num2 = 7;
              continue;
            case 31:
              List<EnumValueMetadata> values = enumMetadata.Values;
              // ISSUE: reference to a compiler-generated field
              System.Func<EnumValueMetadata, bool> func = EnumDescriptor.\u003C\u003Ec.\u003C\u003E9__23_2;
              System.Func<EnumValueMetadata, bool> predicate;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                EnumDescriptor.\u003C\u003Ec.\u003C\u003E9__23_2 = predicate = (System.Func<EnumValueMetadata, bool>) (v =>
                {
                  int num3 = 1;
                  int? intValue;
                  while (true)
                  {
                    int num4 = num3;
                    while (true)
                    {
                      switch (num4)
                      {
                        case 1:
                          intValue = v.IntValue;
                          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 0 : 0;
                          continue;
                        case 2:
                          goto label_3;
                        case 3:
                          goto label_7;
                        default:
                          if (intValue.HasValue)
                          {
                            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 1 : 2;
                            continue;
                          }
                          goto label_8;
                      }
                    }
label_3:
                    intValue = v.IntValue;
                    num3 = 3;
                  }
label_7:
                  return intValue.Value == 0;
label_8:
                  return false;
                });
              }
              else
                goto label_32;
label_42:
              propertyDefaultValue = values.FirstOrDefault<EnumValueMetadata>(predicate);
              num2 = 29;
              continue;
label_32:
              predicate = func;
              goto label_42;
            case 32:
              if (!(nullable.Value != Guid.Empty))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 22 : 11;
                continue;
              }
              break;
          }
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          propertyDefaultValue = enumMetadata.Values.FirstOrDefault<EnumValueMetadata>((System.Func<EnumValueMetadata, bool>) (v => EnumDescriptor.\u003C\u003Ec__DisplayClass23_0.JTSuMtCIU3n0GNDdF2mo(EnumDescriptor.\u003C\u003Ec__DisplayClass23_0.imS8sMCILUwJwm2evjZb((object) v), enumMetadata.DefaultValueUid.Value)));
          num2 = 27;
        }
label_26:
        num1 = 6;
        continue;
label_30:
        num1 = 24;
        continue;
label_31:
        nullable = setting.DefaultValue;
        num1 = 11;
      }
label_4:
      return (EnumValueMetadata) null;
label_34:
      return propertyDefaultValue;
    }

    /// <summary>
    /// Получить выражение инициализации свойства - в соответствии со значением по умолчанию
    /// </summary>
    /// <param name="classMetadata">Метаданные класса</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <param name="forFilter">Для фильтра</param>
    /// <returns>Выражение</returns>
    public override ISyntaxNode GetPropertyInitExpression(
      ClassMetadata classMetadata,
      PropertyMetadata propertyMetadata,
      bool forFilter = false)
    {
      return this.GetPropertyInitExpression(classMetadata, false, propertyMetadata, forFilter);
    }

    /// <summary>
    /// Получить выражение инициализации свойства - в соответствии со значением по умолчанию
    /// </summary>
    /// <param name="classMetadata">Метаданные класса</param>
    /// <param name="forList">Получать ли выражение для списка</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <param name="forFilter">Для фильтра</param>
    /// <returns>Выражение</returns>
    public ISyntaxNode GetPropertyInitExpression(
      ClassMetadata classMetadata,
      bool forList,
      PropertyMetadata propertyMetadata,
      bool forFilter = false)
    {
      int num = 1;
      ISyntaxNode propertyInitExpression;
      while (true)
      {
        EnumValueMetadata propertyDefaultValue;
        EnumMetadata metadata;
        object obj;
        switch (num)
        {
          case 1:
            propertyDefaultValue = this.GetPropertyDefaultValue(classMetadata, propertyMetadata, forFilter);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 0 : 0;
            continue;
          case 2:
            if (metadata == null)
            {
              num = 5;
              continue;
            }
            ISyntaxNode typeSyntax = EnumDescriptor.Rx9HQFo0peeGsSWPtM8M((object) TypeOf.List).CreateTypeSyntax((ISyntaxNode) EnumDescriptor.f7Tbypo0XSjgOMwFAwhl(EnumDescriptor.hNWhmko0qc87X4ust3LZ((object) metadata)));
            ISyntaxNode[] syntaxNodeArray;
            if (propertyInitExpression != null && !forFilter)
            {
              Guid? defaultValue = settings.DefaultValue;
              if (defaultValue.HasValue)
              {
                defaultValue = settings.DefaultValue;
                Guid empty = Guid.Empty;
                if ((!defaultValue.HasValue ? 1 : (!defaultValue.HasValue ? 0 : (EnumDescriptor.bwOJyio01fWaRFAxZrpf(defaultValue.GetValueOrDefault(), empty) ? 1 : 0))) != 0)
                {
                  syntaxNodeArray = new ISyntaxNode[1]
                  {
                    propertyInitExpression
                  };
                  goto label_24;
                }
              }
            }
            syntaxNodeArray = (ISyntaxNode[]) null;
label_24:
            propertyInitExpression = typeSyntax.ObjectInitializationExpression(syntaxNodeArray);
            num = 7;
            continue;
          case 3:
            metadata = this.GetMetadata(EnumDescriptor.DbUExRo0CPsbC1CVdQ64((object) propertyMetadata), false);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 2 : 2;
            continue;
          case 4:
            obj = (object) null;
            break;
          case 5:
            goto label_18;
          case 6:
            if (propertyMetadata.Settings is EnumSettings settings)
            {
              num = 10;
              continue;
            }
            goto label_13;
          case 7:
            goto label_13;
          case 8:
            if (forList)
            {
              num = 6;
              continue;
            }
            goto label_13;
          case 9:
            obj = EnumDescriptor.iyU5w4o030C3gK2wYPD7(EnumDescriptor.LIKXc9o0N8DvWgs00sXW(EnumDescriptor.pngRfWo0IvMAZnnK9lCG(-105199646 ^ -105168224), EnumDescriptor.hNWhmko0qc87X4ust3LZ((object) this.GetMetadata(EnumDescriptor.DbUExRo0CPsbC1CVdQ64((object) propertyMetadata), false)), EnumDescriptor.pngRfWo0IvMAZnnK9lCG(-1839087379 - 334718690 ^ 2121154767), EnumDescriptor.RXDwJ1o08ydFeVRaZ5T8((object) propertyDefaultValue)));
            break;
          case 10:
            if (EnumDescriptor.Ht05M6o0RbML8kQM8T1R((object) settings) == EnumRelationType.Many)
            {
              num = 3;
              continue;
            }
            goto label_13;
          default:
            if (propertyDefaultValue != null)
            {
              num = 9;
              continue;
            }
            goto case 4;
        }
        propertyInitExpression = (ISyntaxNode) obj;
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 8 : 2;
      }
label_13:
      return propertyInitExpression;
label_18:
      return (ISyntaxNode) null;
    }

    /// <summary>
    /// Создать настройки для свойства фильтра, построенного по свойству сущности (должен быть определен у дескриптора типа свойства фильтра)
    /// </summary>
    /// <param name="propertyMetadata">Свойство сущности</param>
    /// <returns></returns>
    public override TypeSettings CreateSettingsForFilterProperty(PropertyMetadata propertyMetadata)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (EnumDescriptor.uee7V6o0iRYOgHGiyIvd((object) propertyMetadata) == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          case 2:
            if (propertyMetadata != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 1 : 0;
              continue;
            }
            goto label_2;
          default:
            goto label_2;
        }
      }
label_2:
      return (TypeSettings) null;
label_3:
      EnumSettings forFilterProperty = (EnumSettings) ClassSerializationHelper.CloneObjectByXml<TypeSettings>((TypeSettings) EnumDescriptor.uee7V6o0iRYOgHGiyIvd((object) propertyMetadata));
      forFilterProperty.DefaultValue = new Guid?();
      return (TypeSettings) forFilterProperty;
    }

    public virtual object ConvertFrom(object value, PropertyMetadata propertyMetadata)
    {
      int num1 = 8;
      EnumValueMetadata enumValueMetadata;
      Type typeByUid;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_5;
            case 2:
              goto label_9;
            case 3:
              typeByUid = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(EnumDescriptor.DbUExRo0CPsbC1CVdQ64((object) propertyMetadata));
              num2 = 4;
              continue;
            case 4:
              if (value.GetType() == typeByUid)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 0;
                continue;
              }
              goto label_4;
            case 5:
              goto label_13;
            case 6:
              if (enumValueMetadata != null)
              {
                num2 = 2;
                continue;
              }
              goto label_10;
            case 7:
              if (value != null)
              {
                num2 = 3;
                continue;
              }
              goto label_5;
            case 8:
              if (propertyMetadata != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 7 : 3;
                continue;
              }
              goto label_13;
            default:
              goto label_3;
          }
        }
label_4:
        enumValueMetadata = value as EnumValueMetadata;
        num1 = 6;
      }
label_3:
      return value;
label_5:
      return (object) null;
label_9:
      return EnumDescriptor.TQWDQho0DcIICiUKakR1(typeByUid, EnumDescriptor.s1S7CDo0aPlU2sfvX5o4((object) enumValueMetadata));
label_10:
      return (object) null;
label_13:
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(87862435 ^ 87877105));
    }

    public override bool IsPublicApplicationDisplayEnabled(Guid subTypeUid) => true;

    public override bool IsPublicApplicationEditorEnabled(Guid subTypeUid) => true;

    /// <summary>Получить тип колонки в БД</summary>
    /// <param name="propertyMetadata">Метаданные свойства (не может быть NULL)</param>
    /// <returns>Тип колонки БД</returns>
    protected override ColumnType GetDbColumnType(
      EntityMetadata entityMetadata,
      EntityPropertyMetadata propertyMetadata)
    {
      int num1 = 2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            EnumDescriptor.Y3i3hNo0QqISj4yv6qDG((object) propertyMetadata, EnumDescriptor.pngRfWo0IvMAZnnK9lCG(516838154 ^ 516823640));
            num1 = 4;
            continue;
          case 2:
            Contract.ArgumentNotNull((object) entityMetadata, (string) EnumDescriptor.pngRfWo0IvMAZnnK9lCG(-1426456882 ^ 2009939514 ^ -583643334));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 1 : 0;
            continue;
          case 3:
            goto label_7;
          case 4:
            if (!EnumDescriptor.r4mq36o0tkU5yMRQWQot(propertyMetadata.SubTypeUid, Guid.Empty))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 0 : 0;
              continue;
            }
            num1 = 5;
            continue;
          case 5:
            goto label_2;
          default:
            goto label_9;
        }
      }
label_2:
      return new ColumnType(DbType.Int32);
label_7:
      ColumnType dbColumnType;
      return dbColumnType;
label_9:
      try
      {
        EnumMetadata metadata = this.GetMetadata(EnumDescriptor.DbUExRo0CPsbC1CVdQ64((object) propertyMetadata), false);
        int num2 = 3;
        while (true)
        {
          ColumnType columnType;
          switch (num2)
          {
            case 1:
            case 4:
              columnType = new ColumnType(DbType.Int32);
              break;
            case 2:
              if (metadata.Type == EnumMetadataType.Enum)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 1 : 0;
                continue;
              }
              goto case 5;
            case 3:
              if (metadata == null)
              {
                num2 = 4;
                continue;
              }
              goto case 2;
            case 5:
              columnType = new ColumnType(DbType.Guid);
              break;
            default:
              goto label_7;
          }
          dbColumnType = columnType;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 0 : 0;
        }
      }
      catch (Exception ex)
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
          num3 = 0;
        switch (num3)
        {
          default:
            throw new InvalidOperationException((string) EnumDescriptor.y7ZG6uo0ec0ZX2mSHm4T(EnumDescriptor.pngRfWo0IvMAZnnK9lCG(-218496594 ^ -218591680), (object) propertyMetadata.Name, (object) entityMetadata.FullTypeName), ex);
        }
      }
    }

    /// <inheritdoc />
    protected override object GetDbDefaultValue(EntityPropertyMetadata propertyMetadata)
    {
      int num1 = 6;
      EnumMetadata metadata;
      EnumValueMetadata enumValueMetadata;
      int? intValue;
      EnumSettings enumSettings;
      Guid? defaultValue;
      while (true)
      {
        switch (num1)
        {
          case 2:
            goto label_8;
          case 3:
            metadata = this.GetMetadata(EnumDescriptor.DbUExRo0CPsbC1CVdQ64((object) propertyMetadata), false);
            num1 = 11;
            continue;
          case 4:
            if (enumValueMetadata == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 0 : 0;
              continue;
            }
            goto case 13;
          case 5:
            if (!(propertyMetadata.SubTypeUid == Guid.Empty))
            {
              enumSettings = EnumDescriptor.uee7V6o0iRYOgHGiyIvd((object) propertyMetadata) as EnumSettings;
              num1 = 7;
              continue;
            }
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 2 : 2;
            continue;
          case 6:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 5;
            continue;
          case 7:
            defaultValue = enumSettings == null || !enumSettings.DefaultValue.HasValue ? new Guid?(Guid.Empty) : enumSettings.DefaultValue;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 3 : 2;
            continue;
          case 8:
            goto label_19;
          case 9:
            if (intValue.HasValue)
            {
              intValue = enumValueMetadata.IntValue;
              num1 = 12;
              continue;
            }
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 1 : 1;
            continue;
          case 10:
            if (EnumDescriptor.DVWwtYo0uFh133FPh9Ot((object) metadata) == EnumMetadataType.Enum)
            {
              num1 = 4;
              continue;
            }
            if (enumValueMetadata == null)
            {
              num1 = 8;
              continue;
            }
            goto label_27;
          case 11:
            if (metadata != null)
            {
              enumValueMetadata = metadata.Values.FirstOrDefault<EnumValueMetadata>((System.Func<EnumValueMetadata, bool>) (v =>
              {
                int num2 = 3;
                Guid guid;
                Guid? nullable;
                while (true)
                {
                  switch (num2)
                  {
                    case 1:
                      goto label_4;
                    case 2:
                      nullable = defaultValue;
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 0 : 0;
                      continue;
                    case 3:
                      // ISSUE: reference to a compiler-generated method
                      guid = EnumDescriptor.\u003C\u003Ec__DisplayClass31_0.Oo4e3FCVFWNQ3ej92qC3((object) v);
                      num2 = 2;
                      continue;
                    case 4:
                      goto label_3;
                    default:
                      if (nullable.HasValue)
                      {
                        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 1 : 1;
                        continue;
                      }
                      goto label_3;
                  }
                }
label_3:
                return false;
label_4:
                // ISSUE: reference to a compiler-generated method
                return EnumDescriptor.\u003C\u003Ec__DisplayClass31_0.AwRQtdCVBjWTb5dQb4eK(guid, nullable.GetValueOrDefault());
              }));
              num1 = 10;
              continue;
            }
            num1 = 14;
            continue;
          case 12:
            goto label_23;
          case 13:
            intValue = enumValueMetadata.IntValue;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 8 : 9;
            continue;
          case 14:
            goto label_2;
          default:
            goto label_5;
        }
      }
label_2:
      return (object) null;
label_5:
      int dbDefaultValue1 = 0;
      goto label_24;
label_8:
      return (object) null;
label_19:
      Guid dbDefaultValue2 = Guid.Empty;
      goto label_28;
label_23:
      dbDefaultValue1 = intValue.Value;
label_24:
      return (object) dbDefaultValue1;
label_27:
      dbDefaultValue2 = EnumDescriptor.s1S7CDo0aPlU2sfvX5o4((object) enumValueMetadata);
label_28:
      return (object) dbDefaultValue2;
    }

    /// <summary>
    /// Получить метаданные перечисления по уникальному идентификатору (из сервиса IMetadataService или IMetadataRuntimeService)
    /// </summary>
    /// <param name="subTypeUid">Uid перечисления (подтипа)</param>
    /// <returns>Метаданные перечисления</returns>
    protected EnumMetadata GetMetadata(Guid subTypeUid, bool throwOnError)
    {
      int num1 = 4;
      EnumMetadata metadata;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_13;
          case 2:
            goto label_14;
          case 3:
label_15:
            if (metadata == null)
            {
              if (throwOnError)
              {
                num1 = 2;
                continue;
              }
              goto label_13;
            }
            else
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 0;
              continue;
            }
          case 4:
            try
            {
              metadata = (EnumMetadata) ((IMetadataService) EnumDescriptor.qTpj2Ro0wVm7VKOZhIkL()).GetMetadata(subTypeUid);
              int num2 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
                num2 = 0;
              switch (num2)
              {
                default:
                  goto label_15;
              }
            }
            catch (Exception ex)
            {
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
                num3 = 0;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    metadata = (EnumMetadata) null;
                    num3 = 2;
                    continue;
                  case 2:
                    goto label_15;
                  default:
                    this.Logger.Debug(EnumDescriptor.aFE51Oo04QCjagRSq5oK((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1872275253 >> 6 ^ -29103825), (object) subTypeUid), ex);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 1;
                    continue;
                }
              }
            }
          default:
            goto label_2;
        }
      }
label_2:
      return metadata;
label_13:
      return (EnumMetadata) null;
label_14:
      throw new TypeNotFoundException(subTypeUid);
    }

    /// <summary>Получить Guid подтипа Enum из типа</summary>
    /// <param name="type">Тип Enum</param>
    /// <returns>Guid подтипа Enum из типа</returns>
    internal static Guid GetSubtypeUid(Type type)
    {
      int num = 2;
      UidAttribute attribute;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (attribute == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          case 2:
            attribute = AttributeHelper<UidAttribute>.GetAttribute(type, false);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 1 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return Guid.Empty;
label_3:
      return attribute.Uid;
    }

    /// <inheritdoc />
    public override object SerializeSimple(
      object value,
      Type valueType,
      EntitySerializationSettings settings)
    {
      int num1 = 1;
      Guid guid;
      int num2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (value != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 2:
            goto label_8;
          case 3:
            goto label_2;
          case 4:
            goto label_6;
          case 5:
            guid = EnumDescriptor.NJXE8go066cHcMekdHai((object) enumBase);
            num1 = 4;
            continue;
          default:
            if (value is EnumBase enumBase)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 2 : 5;
              continue;
            }
            num2 = (int) value;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 2 : 1;
            continue;
        }
      }
label_2:
      return (object) null;
label_6:
      return (object) guid.ToString();
label_8:
      return (object) num2.ToString();
    }

    public override object DeserializeSimple(object value, Type deserializeToType)
    {
      int num1 = 1;
      EnumValueMetadata enumValueMetadata;
      EnumValueMetadata[] enumValueMetadataArray;
      while (true)
      {
        EnumMetadata enumMetadata;
        EnumValueMetadata[] array;
        int valueInt;
        Guid valueUid;
        switch (num1)
        {
          case 1:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_28;
          case 3:
            if (enumValueMetadataArray.Length != 0)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 20 : 11;
              continue;
            }
            goto label_22;
          case 4:
            array = enumMetadata.Values.Where<EnumValueMetadata>((System.Func<EnumValueMetadata, bool>) (v =>
            {
              int num2 = 1;
              int num3;
              int? intValue;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    intValue = v.IntValue;
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 0;
                    continue;
                  case 2:
                    goto label_3;
                  default:
                    num3 = valueInt;
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 2 : 1;
                    continue;
                }
              }
label_3:
              return intValue.GetValueOrDefault() == num3 & intValue.HasValue;
            })).ToArray<EnumValueMetadata>();
            goto label_37;
          case 5:
            if (enumMetadata != null)
            {
              valueInt = 0;
              num1 = 15;
              continue;
            }
            num1 = 14;
            continue;
          case 6:
            if (EnumDescriptor.DVWwtYo0uFh133FPh9Ot((object) enumMetadata) != EnumMetadataType.Enum)
            {
              num1 = 19;
              continue;
            }
            goto case 18;
          case 7:
            goto label_2;
          case 8:
            goto label_16;
          case 9:
            enumValueMetadata = enumMetadata.Values.FirstOrDefault<EnumValueMetadata>((System.Func<EnumValueMetadata, bool>) (v =>
            {
              int num4 = 1;
              int? intValue;
              int num5;
              while (true)
              {
                switch (num4)
                {
                  case 1:
                    intValue = v.IntValue;
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 0 : 0;
                    continue;
                  case 2:
                    goto label_3;
                  default:
                    num5 = valueInt;
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 2 : 1;
                    continue;
                }
              }
label_3:
              return intValue.GetValueOrDefault() == num5 & intValue.HasValue;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 3 : 10;
            continue;
          case 10:
            if (enumValueMetadata != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 7 : 7;
              continue;
            }
            break;
          case 11:
            goto label_22;
          case 12:
            goto label_33;
          case 13:
            // ISSUE: reference to a compiler-generated method
            array = enumMetadata.Values.Where<EnumValueMetadata>((System.Func<EnumValueMetadata, bool>) (v => EnumDescriptor.\u003C\u003Ec__DisplayClass35_0.JBVJa1CVGtSFX2I51YN6(v.Uid, valueUid))).ToArray<EnumValueMetadata>();
            goto label_37;
          case 14:
            goto label_6;
          case 15:
            valueUid = Guid.Empty;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 6 : 1;
            continue;
          case 16:
            goto label_10;
          case 17:
            if (EnumDescriptor.DVWwtYo0uFh133FPh9Ot((object) enumMetadata) == EnumMetadataType.Enum)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 4 : 2;
              continue;
            }
            goto case 13;
          case 18:
            if (!int.TryParse(value.ToString(), out valueInt))
            {
              num1 = 12;
              continue;
            }
            goto case 17;
          case 19:
            if (int.TryParse(value.ToString(), out valueInt))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 9;
              continue;
            }
            break;
          case 20:
            goto label_23;
          default:
            if (deserializeToType == (Type) null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 2 : 0;
              continue;
            }
            if (value != null)
            {
              enumMetadata = InterfaceActivator.LoadMetadata(deserializeToType) as EnumMetadata;
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 5 : 5;
              continue;
            }
            num1 = 8;
            continue;
        }
        if (Guid.TryParse(value.ToString(), out valueUid))
        {
          num1 = 17;
          continue;
        }
        goto label_10;
label_37:
        enumValueMetadataArray = array;
        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 3 : 0;
      }
label_2:
      return enumValueMetadata.EnumValue;
label_6:
      return (object) null;
label_10:
      return base.DeserializeSimple(value, deserializeToType);
label_16:
      return (object) null;
label_22:
      return (object) null;
label_23:
      return enumValueMetadataArray[0].EnumValue;
label_28:
      throw new ArgumentNullException((string) EnumDescriptor.pngRfWo0IvMAZnnK9lCG(1470998129 - 231418599 ^ 1239560718));
label_33:
      return base.DeserializeSimple(value, deserializeToType);
    }

    public override IFullTextPropertyDescriptor FullTextPropertyDescriptor
    {
      get
      {
        int num = 2;
        IFullTextPropertyDescriptor propertyDescriptor1;
        IFullTextPropertyDescriptor propertyDescriptor2;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.propertyDescriptor = propertyDescriptor1 = (IFullTextPropertyDescriptor) new EnumPropertyDescriptor((ISerializableTypeDescriptor) this);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 0 : 0;
              continue;
            case 2:
              propertyDescriptor2 = this.propertyDescriptor;
              if (propertyDescriptor2 == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 1 : 0;
                continue;
              }
              goto label_2;
            default:
              goto label_6;
          }
        }
label_2:
        return propertyDescriptor2;
label_6:
        return propertyDescriptor1;
      }
    }

    public EnumDescriptor()
    {
      EnumDescriptor.oP1UVbo0HCr5qtIMePt3();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static EnumDescriptor()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            EnumDescriptor.UID = new Guid((string) EnumDescriptor.pngRfWo0IvMAZnnK9lCG(1012087039 ^ 1011984531));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 0 : 0;
            continue;
          case 2:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static void Y3i3hNo0QqISj4yv6qDG([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static Guid DbUExRo0CPsbC1CVdQ64([In] object obj0) => ((PropertyMetadata) obj0).SubTypeUid;

    internal static object Sb9cKfo0v4j19Fxyw5yq([In] object obj0) => (object) ((EntityPropertyMetadata) obj0).SimpleTypeSettings;

    internal static object RXDwJ1o08ydFeVRaZ5T8([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static bool BMkBbmo0ZF9VV6I3qOEd([In] object obj0) => ((PropertyMetadata) obj0).Nullable;

    internal static EnumMetadataType DVWwtYo0uFh133FPh9Ot([In] object obj0) => ((EnumMetadata) obj0).Type;

    internal static bool kdp6Qjo0EJo7ppVn2PlD() => EnumDescriptor.jYgFD3o0GGl2WNGqU4gV == null;

    internal static EnumDescriptor g8vVVUo0fHIJEcBHQbp4() => EnumDescriptor.jYgFD3o0GGl2WNGqU4gV;

    internal static object pngRfWo0IvMAZnnK9lCG(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object WImWEdo0VMhEfNS1Ztnt([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool g7Jtkjo0ShGHKQZYDFru([In] object obj0, [In] object obj1, [In] object obj2) => ((TypeDescriptor) obj0).IsEmpty((PropertyMetadata) obj1, obj2);

    internal static object uee7V6o0iRYOgHGiyIvd([In] object obj0) => (object) ((PropertyMetadata) obj0).Settings;

    internal static EnumRelationType Ht05M6o0RbML8kQM8T1R([In] object obj0) => ((EnumSettings) obj0).RelationType;

    internal static object hNWhmko0qc87X4ust3LZ([In] object obj0) => (object) ((EnumMetadata) obj0).FullTypeName;

    internal static Type PIPHOso0KOMXSboiKVbQ([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object f7Tbypo0XSjgOMwFAwhl([In] object obj0) => (object) ((string) obj0).CreateTypeSyntax();

    internal static bool KmSGplo0TQmBIHB8ZVlV([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object zENVVIo0kPO0NkkkrwXD([In] object obj0, [In] object obj1) => (object) Restrictions.In((string) obj0, (object[]) obj1);

    internal static object scwuqro0nrXC1JH0SuuB([In] object obj0, Guid subTypeUid) => (object) ((TypeDescriptor) obj0).GetTypeDisplayName(subTypeUid);

    internal static object Q6SVIvo0Oorc7hhucfbX([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static object LRTdhDo02q9UicWrjiLl([In] object obj0) => (object) ((NamedMetadata) obj0).DisplayName;

    internal static object y7ZG6uo0ec0ZX2mSHm4T([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static object LHAuqRo0PDfLo7BSYA5T([In] object obj0) => (object) EnumHelper.GetDisplayName(obj0);

    internal static bool bwOJyio01fWaRFAxZrpf([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static object LIKXc9o0N8DvWgs00sXW(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) ((string) obj0 + (string) obj1 + (string) obj2 + (string) obj3);
    }

    internal static object iyU5w4o030C3gK2wYPD7([In] object obj0) => (object) ((string) obj0).IdentifierName();

    internal static Type Rx9HQFo0peeGsSWPtM8M([In] object obj0) => ((RipeType) obj0).Raw;

    internal static Guid s1S7CDo0aPlU2sfvX5o4([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static object TQWDQho0DcIICiUKakR1(Type enumType, Guid uid) => ModelHelper.GetEnumValue(enumType, uid);

    internal static bool r4mq36o0tkU5yMRQWQot([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static object qTpj2Ro0wVm7VKOZhIkL() => (object) MetadataServiceContext.Service;

    internal static object aFE51Oo04QCjagRSq5oK([In] object obj0, [In] object obj1) => (object) (obj0.ToString() + obj1);

    internal static Guid NJXE8go066cHcMekdHai([In] object obj0) => ((EnumBase) obj0).Value;

    internal static void oP1UVbo0HCr5qtIMePt3() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
