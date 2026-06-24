// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.UrlDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.FullTextSearch.Descriptors;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.MetadataInternalContainer.Containers;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Runtime.NH.CustomTypes;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Data;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Types
{
  /// <summary>Описание типа "URL"</summary>
  [Component(Order = 1100)]
  public class UrlDescriptor : 
    CLRTypeDescriptor<Uri, UrlSettings>,
    IMappingTypeDescriptor,
    IConvertableTypeDescriptor
  {
    /// <summary>Uid типа</summary>
    public const string UID_S = "{66A64042-0490-4AD6-B804-4D08FA6C85F0}";
    /// <summary>Uid типа</summary>
    public static readonly Guid UID;
    private IFullTextPropertyDescriptor propertyDescriptor;
    internal static UrlDescriptor DfnwEnoHsOsKOs1aPqGw;

    /// <inheritdoc />
    protected override void ExtendSimplePropertyMapping(
      INHibernatePropertyTypeMapper mapper,
      EntityPropertyMetadata propertyMetadata)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            UrlDescriptor.YxxRILoAFSlgs9HmBa7y((object) this, (object) mapper, (object) propertyMetadata);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            mapper.Type<UriNHType>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 2 : 0;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Uid типа данных или группы типов</summary>
    public override Guid Uid => UrlDescriptor.UID;

    /// <summary>Имя типа данных (или группы)</summary>
    public override string Name => (string) UrlDescriptor.vQpgapoAWEZQ9vhRhdBs(UrlDescriptor.zHbsKxoABZOCRb7qWuYd(381945751 ^ 1158627804 ^ 1405867751));

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
      int num = 5;
      UrlSettings settings;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (UrlDescriptor.hatmrOoAhWV917M0u3Zq(UrlDescriptor.xnXXF8oAb4rk3UsiAAVD((object) settings)))
            {
              num = 2;
              continue;
            }
            goto label_8;
          case 2:
          case 3:
            goto label_7;
          case 4:
            settings = (UrlSettings) propertyMetadata.Settings;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 0;
            continue;
          case 5:
            UrlDescriptor.Bqx4XDoAooNNTS4TOHoZ((object) propertyMetadata, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(2045296739 + 1688595713 ^ -561060810));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 4 : 0;
            continue;
          default:
            if (settings == null)
            {
              num = 3;
              continue;
            }
            goto case 1;
        }
      }
label_7:
      return (ISyntaxNode) null;
label_8:
      // ISSUE: type reference
      return ((ISyntaxNode) UrlDescriptor.QFsYn6oAEaVe2A80eUaD(UrlDescriptor.eqMdtJoAG7k9HnUtoy44(__typeref (Uri)))).ObjectCreationExpression((ISyntaxNode) UrlDescriptor.ziAaeToAf3aTKmwdovFj(UrlDescriptor.xnXXF8oAb4rk3UsiAAVD((object) settings)), (ISyntaxNode) UrlDescriptor.ziAaeToAf3aTKmwdovFj((object) UriKind.RelativeOrAbsolute));
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
      int num1 = 2;
      UrlSettings urlSettings;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          string str;
          switch (num2)
          {
            case 1:
              urlSettings = (UrlSettings) UrlDescriptor.hSAlTsoAQN6XrB8Ru1xK((object) propertyMetadata);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 0 : 0;
              continue;
            case 2:
              Contract.ArgumentNotNull((object) propertyMetadata, (string) UrlDescriptor.zHbsKxoABZOCRb7qWuYd(1319452732 ^ 1319438702));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 0 : 1;
              continue;
            case 3:
              str = (string) null;
              break;
            case 4:
              goto label_8;
            default:
              if (urlSettings != null)
              {
                // ISSUE: explicit non-virtual call
                str = __nonvirtual (urlSettings.DefaultValue);
                break;
              }
              goto label_7;
          }
          if (UrlDescriptor.hatmrOoAhWV917M0u3Zq((object) str))
            num2 = 4;
          else
            goto label_12;
        }
label_7:
        num1 = 3;
      }
label_8:
      Uri uri = (Uri) null;
      goto label_13;
label_12:
      uri = new Uri(urlSettings.DefaultValue, UriKind.RelativeOrAbsolute);
label_13:
      return (IPropertyDefaultValueContainer) new PropertyValueContainer<Uri>(uri);
    }

    public virtual object ConvertFrom(object value, PropertyMetadata propertyMetadata)
    {
      int num = 8;
      string uriString;
      while (true)
      {
        switch (num)
        {
          case 1:
            if ((object) (value as Uri) != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 3 : 2;
              continue;
            }
            // ISSUE: type reference
            if (!(value.GetType() == UrlDescriptor.eqMdtJoAG7k9HnUtoy44(__typeref (string))))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 0;
              continue;
            }
            goto case 5;
          case 2:
            goto label_6;
          case 3:
          case 6:
            goto label_14;
          case 4:
            if (UrlDescriptor.hatmrOoAhWV917M0u3Zq((object) uriString))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 2;
              continue;
            }
            goto label_7;
          case 5:
            uriString = (string) value;
            num = 4;
            continue;
          case 7:
            goto label_11;
          case 8:
            if (propertyMetadata == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 7 : 2;
              continue;
            }
            if (value == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 3 : 6;
              continue;
            }
            goto case 1;
          default:
            goto label_8;
        }
      }
label_6:
      return (object) null;
label_7:
      return (object) new Uri(uriString, UriKind.RelativeOrAbsolute);
label_8:
      return (object) null;
label_11:
      throw new ArgumentNullException((string) UrlDescriptor.zHbsKxoABZOCRb7qWuYd(-1886646897 ^ -1886632739));
label_14:
      return value;
    }

    public override TypeSettings CreateSettingsForFilterProperty(PropertyMetadata propertyMetadata)
    {
      int num = 4;
      UrlSettings forFilterProperty;
      while (true)
      {
        switch (num)
        {
          case 2:
            UrlDescriptor.u3GSycoACnBatY0oEoBM((object) forFilterProperty, (object) null);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 1;
            continue;
          case 3:
            if (forFilterProperty == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 0 : 0;
              continue;
            }
            goto case 2;
          case 4:
            forFilterProperty = (UrlSettings) base.CreateSettingsForFilterProperty(propertyMetadata);
            num = 3;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      return (TypeSettings) forFilterProperty;
    }

    public override bool IsPublicApplicationDisplayEnabled(Guid subTypeUid) => true;

    public override bool IsPublicApplicationEditorEnabled(Guid subTypeUid) => true;

    /// <summary>Получить тип колонки в БД</summary>
    /// <param name="entityMetadata">Метаданные сущности</param>
    /// <param name="propertyMetadata">Метаданные свойства (не может быть NULL)</param>
    /// <returns>Тип колонки БД</returns>
    protected override ColumnType GetDbColumnType(
      EntityMetadata entityMetadata,
      EntityPropertyMetadata propertyMetadata)
    {
      return new ColumnType(DbType.String, int.MaxValue);
    }

    /// <summary>Применить в критерий NHibernate условия</summary>
    /// <param name="criteria">Критерий</param>
    /// <param name="metadata">Метаданные класса</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <param name="value">Значение фильтра</param>
    /// <param name="alias">Алиас для запроса</param>
    public override void ApplyFilterValue(
      ICriteria criteria,
      EntityMetadata metadata,
      EntityPropertyMetadata propertyMetadata,
      object value,
      string alias)
    {
      int num = 2;
      MatchMode anywhere;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (UrlDescriptor.mQjuy4oAvjdy3irRYpiH((object) (Uri) value) != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
              continue;
            }
            goto label_13;
          case 2:
            if (value != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 1;
              continue;
            }
            goto label_12;
          case 3:
            goto label_3;
          case 4:
            goto label_2;
          case 5:
            criteria.Add((ICriterion) ElmaRestrictions.InsensitiveLike(string.IsNullOrEmpty(alias) ? (string) UrlDescriptor.H2IyNKoAuS2mSXpEqXDP((object) propertyMetadata) : (string) UrlDescriptor.vbydbnoAIRamnedSPJvR(UrlDescriptor.zHbsKxoABZOCRb7qWuYd(-1837662597 ^ -1837679495), (object) alias, UrlDescriptor.H2IyNKoAuS2mSXpEqXDP((object) propertyMetadata)), ((Uri) value).OriginalString, anywhere));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 3 : 2;
            continue;
          default:
            if (!UrlDescriptor.Nat3XxoAZsAocmWEkNyL(UrlDescriptor.BQmhgXoA8KeEls4C2qFY(UrlDescriptor.mQjuy4oAvjdy3irRYpiH((object) (Uri) value)), (object) string.Empty))
            {
              anywhere = MatchMode.Anywhere;
              num = 5;
              continue;
            }
            num = 4;
            continue;
        }
      }
label_3:
      return;
label_2:
      return;
label_12:
      return;
label_13:;
    }

    public override IFullTextPropertyDescriptor FullTextPropertyDescriptor
    {
      get
      {
        int num = 1;
        IFullTextPropertyDescriptor propertyDescriptor1;
        IFullTextPropertyDescriptor propertyDescriptor2;
        while (true)
        {
          switch (num)
          {
            case 1:
              propertyDescriptor2 = this.propertyDescriptor;
              if (propertyDescriptor2 == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            case 2:
              goto label_6;
            default:
              this.propertyDescriptor = propertyDescriptor1 = (IFullTextPropertyDescriptor) new UrlPropertyDescriptor((ISerializableTypeDescriptor) this);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 2;
              continue;
          }
        }
label_2:
        return propertyDescriptor2;
label_6:
        return propertyDescriptor1;
      }
    }

    public UrlDescriptor()
    {
      UrlDescriptor.E6aR5noAVOLArb5D6vTL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static UrlDescriptor()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            UrlDescriptor.E6aR5noAVOLArb5D6vTL();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            UrlDescriptor.UID = new Guid((string) UrlDescriptor.zHbsKxoABZOCRb7qWuYd(~-306453669 ^ 306618342));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static void YxxRILoAFSlgs9HmBa7y([In] object obj0, [In] object obj1, [In] object obj2) => __nonvirtual (((SimpleTypeDescriptor<Uri>) obj0).ExtendSimplePropertyMapping((INHibernatePropertyTypeMapper) obj1, (EntityPropertyMetadata) obj2));

    internal static bool dyAW8LoHcX5DWItJnwtU() => UrlDescriptor.DfnwEnoHsOsKOs1aPqGw == null;

    internal static UrlDescriptor J5mJWJoHzWBtdp5uB93V() => UrlDescriptor.DfnwEnoHsOsKOs1aPqGw;

    internal static object zHbsKxoABZOCRb7qWuYd(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object vQpgapoAWEZQ9vhRhdBs([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static void Bqx4XDoAooNNTS4TOHoZ([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static object xnXXF8oAb4rk3UsiAAVD([In] object obj0) => (object) ((UrlSettings) obj0).DefaultValue;

    internal static bool hatmrOoAhWV917M0u3Zq([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static Type eqMdtJoAG7k9HnUtoy44([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object QFsYn6oAEaVe2A80eUaD(Type type) => (object) type.CreateTypeSyntax();

    internal static object ziAaeToAf3aTKmwdovFj([In] object obj0) => (object) obj0.CreateSyntaxNode();

    internal static object hSAlTsoAQN6XrB8Ru1xK([In] object obj0) => (object) ((PropertyMetadata) obj0).Settings;

    internal static void u3GSycoACnBatY0oEoBM([In] object obj0, [In] object obj1) => ((UrlSettings) obj0).DefaultValue = (string) obj1;

    internal static object mQjuy4oAvjdy3irRYpiH([In] object obj0) => (object) ((Uri) obj0).OriginalString;

    internal static object BQmhgXoA8KeEls4C2qFY([In] object obj0) => (object) ((string) obj0).Trim();

    internal static bool Nat3XxoAZsAocmWEkNyL([In] object obj0, [In] object obj1) => ((string) obj0).Equals((string) obj1);

    internal static object H2IyNKoAuS2mSXpEqXDP([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static object vbydbnoAIRamnedSPJvR([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static void E6aR5noAVOLArb5D6vTL() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
