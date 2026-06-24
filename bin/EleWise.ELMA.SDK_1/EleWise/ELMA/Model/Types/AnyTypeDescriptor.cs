// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.AnyTypeDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.DataClasses;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Db;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.MetadataInternalContainer.Containers;
using EleWise.ELMA.Model.Types.Groups;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Types
{
  /// <summary>Описание типа "Произвольный тип"</summary>
  public class AnyTypeDescriptor : TypeDescriptor
  {
    /// <summary>Uid типа</summary>
    public const string UID_S = "{C77CD813-1DFB-4777-AB7E-87B54BD09E38}";
    /// <summary>Uid типа</summary>
    public static readonly Guid UID;
    internal static AnyTypeDescriptor GNsS9RoJKdPt3X2kqUgR;

    /// <summary>Описание типа "Объект"</summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    [XmlIgnore]
    public DataClassDescriptor DataClassDescriptor
    {
      get => this.\u003CDataClassDescriptor\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CDataClassDescriptor\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>Uid типа данных</summary>
    public override Guid Uid => AnyTypeDescriptor.UID;

    /// <summary>Имя "Произвольный тип"</summary>
    public override string Name => (string) AnyTypeDescriptor.RZtpYZoJna8OX13dADSS(AnyTypeDescriptor.DV7wkioJkQxNx44j3T71(-1867198571 ^ -1867098511));

    /// <summary>Может ли тип быть Nullable</summary>
    public override bool CanBeNullable => false;

    /// <summary>
    /// Значение признака Nullable по умолчанию (используется, если CanBeNullable=true)
    /// </summary>
    public override bool? DefaultNullableValue => new bool?();

    /// <summary>Тип класса настроек типа данных</summary>
    public override Type SettingsType => AnyTypeDescriptor.j9mdDFoJOdS1Rb39BphS(__typeref (AnyTypeSettings));

    /// <summary>Uid родительской группы типов данных</summary>
    public override Guid ParentUid => SystemTypesDescriptor.UID;

    /// <summary>Можно ли использовать тип для сущностей</summary>
    public override bool UseForEntity => false;

    /// <summary>Получить список подтипов</summary>
    /// <param name="classMetadata">Метаданные класса</param>
    /// <returns>Список подтипов</returns>
    public override IEnumerable<ITypeDescriptor> GetSubTypes(ClassMetadata classMetadata) => (IEnumerable<ITypeDescriptor>) null;

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
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            AnyTypeDescriptor.sgKyBMoJP3c2IABoghAr(AnyTypeDescriptor.BmqX72oJeyuJMi2FWbFg((object) propertyMetadata) is AnyTypeSettings, AnyTypeDescriptor.DV7wkioJkQxNx44j3T71(572119659 - -337058038 ^ 909273449));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 0;
            continue;
          case 2:
            AnyTypeDescriptor.y5VU4eoJ2fLRpJjFLbK3(AnyTypeDescriptor.BmqX72oJeyuJMi2FWbFg((object) propertyMetadata), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420898064));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 1 : 1;
            continue;
          case 3:
            AnyTypeDescriptor.y5VU4eoJ2fLRpJjFLbK3((object) propertyMetadata, AnyTypeDescriptor.DV7wkioJkQxNx44j3T71(654297945 ^ 654279179));
            num = 2;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return (ISyntaxNode) AnyTypeDescriptor.kpM2AgoJ1VieBxf0Q3JW((object) ((AnyTypeSettings) AnyTypeDescriptor.BmqX72oJeyuJMi2FWbFg((object) propertyMetadata)).FullTypeName);
    }

    /// <summary>Получить отображаемое имя типа у свойства</summary>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <returns>Отображаемое имя типа у свойства</returns>
    public override string GetPropertyTypeDisplayName(PropertyMetadata propertyMetadata)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_4;
          case 2:
            Contract.ArgumentNotNull((object) propertyMetadata.Settings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(979449278 ^ 979589224));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 0;
            continue;
          case 3:
            AnyTypeDescriptor.y5VU4eoJ2fLRpJjFLbK3((object) propertyMetadata, AnyTypeDescriptor.DV7wkioJkQxNx44j3T71(-53329496 >> 4 ^ -3314360));
            num = 2;
            continue;
          default:
            Contract.CheckArgument(AnyTypeDescriptor.BmqX72oJeyuJMi2FWbFg((object) propertyMetadata) is AnyTypeSettings, (string) AnyTypeDescriptor.DV7wkioJkQxNx44j3T71(-1638402543 ^ -1638568935));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 1;
            continue;
        }
      }
label_4:
      return (string) AnyTypeDescriptor.RZtpYZoJna8OX13dADSS(AnyTypeDescriptor.NOD6b0oJNcu3GtijpuMB((object) (AnyTypeSettings) AnyTypeDescriptor.BmqX72oJeyuJMi2FWbFg((object) propertyMetadata)));
    }

    /// <summary>Получить выражение инициализации свойства</summary>
    /// <param name="classMetadata">Метаданные класса</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <param name="forFilter">Для фильтра</param>
    /// <returns>Выражение</returns>
    public override ISyntaxNode GetPropertyInitExpression(
      ClassMetadata classMetadata,
      PropertyMetadata propertyMetadata,
      bool forFilter = false)
    {
      return (ISyntaxNode) null;
    }

    /// <summary>
    /// Получить контейнер свойства сущности с данными по умолчанию
    /// </summary>
    /// <param name="classMetadata">Метаданные класса</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <param name="forFilter">Для фильтра</param>
    /// <returns>Контейнер</returns>
    public override IPropertyDefaultValueContainer GetDefaultContainer(
      ClassMetadata classMetadata,
      PropertyMetadata propertyMetadata,
      bool forFilter = false)
    {
      return (IPropertyDefaultValueContainer) new EleWise.ELMA.Model.MetadataInternalContainer.Containers.PropertyAnyTypeValueContainer((IPropertyMetadata) propertyMetadata);
    }

    public override TypeDbStructures GetDbStructures(
      EntityMetadata entityMetadata,
      EntityPropertyMetadata propertyMetadata)
    {
      throw new NotImplementedException();
    }

    public override bool ApplyDbChanges(
      IDbModelUpdater updater,
      EntityMetadata entityMetadata,
      EntityPropertyMetadata propertyMetadata,
      EntityPropertyMetadata oldPropertyMetadata)
    {
      throw new NotImplementedException();
    }

    /// <inheritdoc />
    public override object SerializeSimple(
      object value,
      Type valueType,
      EntitySerializationSettings settings)
    {
      int num1 = 6;
      while (true)
      {
        int num2 = num1;
        Type type;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (!AnyTypeDescriptor.cxsJbEoJ3lIul7TqYWnn(type, TypeOf<EleWise.ELMA.Common.Models.API.WebData>.Raw))
              {
                if (!(value is DataClass dataClass))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 4 : 4;
                  continue;
                }
                goto label_18;
              }
              else
              {
                num2 = 3;
                continue;
              }
            case 2:
              if (value is SerializableList<object> serializableList)
              {
                num2 = 7;
                continue;
              }
              goto label_12;
            case 3:
              goto label_8;
            case 4:
              if (!(value is SerializableDictionary<string, object> serializableDictionary))
              {
                num2 = 2;
                continue;
              }
              goto label_3;
            case 5:
              goto label_13;
            case 6:
              if (value == null)
              {
                num2 = 5;
                continue;
              }
              goto label_14;
            case 7:
              goto label_11;
            case 8:
              goto label_3;
            case 9:
              goto label_18;
            case 10:
              if (!AnyTypeDescriptor.cxsJbEoJ3lIul7TqYWnn(type, TypeOf<EleWise.ELMA.Common.Models.WebData>.Raw))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 1 : 0;
                continue;
              }
              goto label_15;
            default:
              goto label_15;
          }
        }
label_14:
        type = value.GetType();
        num1 = 10;
      }
label_3:
      return (object) serializableDictionary;
label_8:
      return (object) ((EleWise.ELMA.Common.Models.WebData) value).ToDictionary();
label_11:
      return (object) serializableList;
label_12:
      return base.SerializeSimple(value, valueType, settings);
label_13:
      return (object) null;
label_15:
      return (object) EleWise.ELMA.Common.Models.API.WebData.Create((EleWise.ELMA.Common.Models.WebData) value).ToDictionary();
label_18:
      return AnyTypeDescriptor.SADCdBoJpVlIuPmLHgNu((object) this.DataClassDescriptor, (object) dataClass, valueType, (object) settings);
    }

    public AnyTypeDescriptor()
    {
      AnyTypeDescriptor.Wr4y1moJapAoFipOGf1Y();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static AnyTypeDescriptor()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            AnyTypeDescriptor.UID = new Guid((string) AnyTypeDescriptor.DV7wkioJkQxNx44j3T71(-643786247 ^ -643693667));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 0 : 0;
            continue;
          case 2:
            AnyTypeDescriptor.Wr4y1moJapAoFipOGf1Y();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static bool SKHgMioJX15KdJbF7elc() => AnyTypeDescriptor.GNsS9RoJKdPt3X2kqUgR == null;

    internal static AnyTypeDescriptor Myv6rVoJTiMD6Kf38Jfn() => AnyTypeDescriptor.GNsS9RoJKdPt3X2kqUgR;

    internal static object DV7wkioJkQxNx44j3T71(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object RZtpYZoJna8OX13dADSS([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static Type j9mdDFoJOdS1Rb39BphS([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static void y5VU4eoJ2fLRpJjFLbK3([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static object BmqX72oJeyuJMi2FWbFg([In] object obj0) => (object) ((PropertyMetadata) obj0).Settings;

    internal static void sgKyBMoJP3c2IABoghAr(bool condition, [In] object obj1) => Contract.CheckArgument(condition, (string) obj1);

    internal static object kpM2AgoJ1VieBxf0Q3JW([In] object obj0) => (object) ((string) obj0).CreateTypeSyntax();

    internal static object NOD6b0oJNcu3GtijpuMB([In] object obj0) => (object) ((AnyTypeSettings) obj0).FullTypeName;

    internal static bool cxsJbEoJ3lIul7TqYWnn([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static object SADCdBoJpVlIuPmLHgNu(
      [In] object obj0,
      [In] object obj1,
      Type valueType,
      [In] object obj3)
    {
      return ((TypeDescriptor) obj0).SerializeSimple(obj1, valueType, (EntitySerializationSettings) obj3);
    }

    internal static void Wr4y1moJapAoFipOGf1Y() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
