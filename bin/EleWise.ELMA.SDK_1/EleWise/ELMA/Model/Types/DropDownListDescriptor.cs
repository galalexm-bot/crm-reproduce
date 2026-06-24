// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.DropDownListDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.FullTextSearch.Descriptors;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Common;
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
using System.Collections.Generic;
using System.Data;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Types
{
  /// <summary>Описание типа "Выпадающий список"</summary>
  [Component(Order = 900)]
  public class DropDownListDescriptor : 
    CLRTypeDescriptor<DropDownItem, DropDownListSettings>,
    IMappingTypeDescriptor,
    ILocalizableType
  {
    /// <summary>Uid типа</summary>
    public const string UID_S = "{55888705-4BFA-431B-8A93-71B80EED484D}";
    /// <summary>Uid типа</summary>
    public static readonly Guid UID;
    private IFullTextPropertyDescriptor propertyDescriptor;
    private static DropDownListDescriptor hrq1oPoAmU2K3MFBP7Yf;

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
            DropDownListDescriptor.n9htvqoAJlFBU17lYR1b((object) this, (object) mapper, (object) propertyMetadata);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            mapper.Type<DropDownItemNHType>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 2 : 0;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Uid типа</summary>
    public override Guid Uid => DropDownListDescriptor.UID;

    /// <summary>Имя "Выпадающий список"</summary>
    public override string Name => EleWise.ELMA.SR.T((string) DropDownListDescriptor.dnOjFPoA93fF8IeXeltS(-787452571 ^ -787290009));

    /// <summary>
    /// Является ли значение пустым или значением по умолчанию
    /// </summary>
    /// <param name="propertyMetadata"></param>
    /// <param name="val"></param>
    /// <returns></returns>
    public override bool IsEmptyOrDefault(PropertyMetadata propertyMetadata, object val)
    {
      int num = 15;
      DropDownListSettings downListSettings;
      DropDownItem dropDownItem;
      while (true)
      {
        switch (num)
        {
          case 1:
            dropDownItem = val as DropDownItem;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 11 : 11;
            continue;
          case 2:
            goto label_18;
          case 3:
          case 5:
            goto label_2;
          case 4:
            if (DropDownListDescriptor.D34pYboArvSJPoSaUTk9((object) dropDownItem) != null)
            {
              if (DropDownListDescriptor.xcojBqoAglxy3l9UrKuy((object) downListSettings) != null)
              {
                num = 12;
                continue;
              }
              goto label_8;
            }
            else
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 5 : 0;
              continue;
            }
          case 6:
          case 14:
            goto label_13;
          case 7:
            goto label_7;
          case 8:
            if (downListSettings != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 1 : 0;
              continue;
            }
            goto label_18;
          case 9:
            downListSettings = (DropDownListSettings) DropDownListDescriptor.sCBV3voAlL5RcXZma4D7((object) propertyMetadata);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 8 : 5;
            continue;
          case 10:
            goto label_8;
          case 11:
            if (dropDownItem == null)
            {
              num = 3;
              continue;
            }
            goto case 4;
          case 12:
            if (!DropDownListDescriptor.PpUbVUoAjDCFA0WRD3SE(DropDownListDescriptor.k5TgGToA5fqSnCntJ3mj((object) dropDownItem), (object) ((DropDownItem) DropDownListDescriptor.xcojBqoAglxy3l9UrKuy((object) downListSettings)).Key))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 10 : 3;
              continue;
            }
            goto label_7;
          case 13:
            if (DropDownListDescriptor.Ji69XUoAdCcpUecZXsDu((object) this, (object) propertyMetadata, val))
            {
              num = 6;
              continue;
            }
            if (propertyMetadata != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 9 : 9;
              continue;
            }
            goto label_20;
          case 15:
            if (val == null)
            {
              num = 14;
              continue;
            }
            goto case 13;
          default:
            goto label_20;
        }
      }
label_2:
      return true;
label_7:
      return DropDownListDescriptor.zgJQFAoAYm4YVQPjDYh0(DropDownListDescriptor.D34pYboArvSJPoSaUTk9((object) dropDownItem), DropDownListDescriptor.D34pYboArvSJPoSaUTk9(DropDownListDescriptor.xcojBqoAglxy3l9UrKuy((object) downListSettings)));
label_8:
      return false;
label_13:
      return true;
label_18:
      return true;
label_20:
      return true;
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
      int num = 3;
      DropDownListSettings downListSettings;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            downListSettings = (DropDownListSettings) DropDownListDescriptor.sCBV3voAlL5RcXZma4D7((object) propertyMetadata);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 0 : 0;
            continue;
          case 3:
            DropDownListDescriptor.gLUbqcoALhHks7ZSOPOb((object) propertyMetadata, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1581325282 << 3 ^ -234318270));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 2 : 2;
            continue;
          case 4:
          case 5:
            goto label_2;
          case 6:
            if (downListSettings.DefaultValue != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 1;
              continue;
            }
            goto label_2;
          default:
            if (downListSettings == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 5 : 2;
              continue;
            }
            goto case 6;
        }
      }
label_2:
      return (ISyntaxNode) null;
label_3:
      // ISSUE: type reference
      return DropDownListDescriptor.j1Xw2toAUFJyPbs05Q9q(__typeref (DropDownItem)).CreateTypeSyntax().ObjectCreationExpression(DropDownListDescriptor.k5TgGToA5fqSnCntJ3mj(DropDownListDescriptor.xcojBqoAglxy3l9UrKuy((object) downListSettings)).CreateSyntaxNode(), (ISyntaxNode) DropDownListDescriptor.jRSuXAoAs9c9CxXtILco(DropDownListDescriptor.D34pYboArvSJPoSaUTk9(DropDownListDescriptor.xcojBqoAglxy3l9UrKuy((object) downListSettings))));
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
      int num = 1;
      DropDownListSettings downListSettings;
      while (true)
      {
        switch (num)
        {
          case 1:
            Contract.ArgumentNotNull((object) propertyMetadata, (string) DropDownListDescriptor.dnOjFPoA93fF8IeXeltS(-1380439818 << 3 ^ 1841368802));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_5;
          default:
            downListSettings = (DropDownListSettings) DropDownListDescriptor.sCBV3voAlL5RcXZma4D7((object) propertyMetadata);
            if (downListSettings == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 2 : 1;
              continue;
            }
            goto label_6;
        }
      }
label_5:
      DropDownItem dropDownItem = (DropDownItem) null;
      goto label_7;
label_6:
      // ISSUE: explicit non-virtual call
      dropDownItem = __nonvirtual (downListSettings.DefaultValue);
label_7:
      return (IPropertyDefaultValueContainer) new PropertyValueContainer<DropDownItem>(dropDownItem);
    }

    /// <summary>Применить в критерий NHibernate условия</summary>
    /// <param name="criteria">Критерий</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <param name="value">Значение фильтра</param>
    public override void ApplyFilterValue(
      ICriteria criteria,
      EntityMetadata metadata,
      EntityPropertyMetadata propertyMetadata,
      object value,
      string alias)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (value is DropDownItem)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          case 2:
            goto label_7;
          case 3:
            goto label_2;
          default:
            DropDownListDescriptor.Ra4VD0o7BUkSyUmHbI2h((object) criteria, DropDownListDescriptor.IPie0eo7FW82drgpxVNx(!DropDownListDescriptor.VKyRVEoAcGaokuO7rF7Q((object) alias) ? (object) string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1574260816 ^ 1574244946), (object) alias, (object) propertyMetadata.Name) : DropDownListDescriptor.AFnAtnoAzkTSlaZUEblJ((object) propertyMetadata), (object) value.ToString(), (object) MatchMode.Exact));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 1 : 2;
            continue;
        }
      }
label_7:
      return;
label_2:
      return;
label_3:;
    }

    public override TypeSettings CreateSettingsForFilterProperty(PropertyMetadata propertyMetadata)
    {
      int num = 4;
      DropDownListSettings forFilterProperty;
      while (true)
      {
        switch (num)
        {
          case 1:
            DropDownListDescriptor.BIVYhOo7Wc0Sp05SDKuV((object) forFilterProperty, (object) null);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 2 : 2;
            continue;
          case 3:
            if (forFilterProperty == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 0;
              continue;
            }
            goto case 1;
          case 4:
            forFilterProperty = (DropDownListSettings) base.CreateSettingsForFilterProperty(propertyMetadata);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 1 : 3;
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

    public override bool IsAvailibleEditPropertyInTable => true;

    /// <summary>Получить тип колонки в БД</summary>
    /// <param name="propertyMetadata">Метаданные свойства (не может быть NULL)</param>
    /// <returns>Тип колонки БД</returns>
    protected override ColumnType GetDbColumnType(
      EntityMetadata entityMetadata,
      EntityPropertyMetadata propertyMetadata)
    {
      return new ColumnType(DbType.String, 2000);
    }

    /// <summary>Строки локализации</summary>
    /// <returns></returns>
    public IEnumerable<string> GetLocalizableStrings(PropertyMetadata propertyMetadata)
    {
      List<string> localizableStrings = new List<string>();
      if (propertyMetadata == null)
        return (IEnumerable<string>) localizableStrings;
      if (!(propertyMetadata.Settings is DropDownListSettings settings))
        return (IEnumerable<string>) localizableStrings;
      foreach (DropDownItem dropDownItem in (List<DropDownItem>) settings.Items)
      {
        if (!string.IsNullOrEmpty(dropDownItem.Key))
          localizableStrings.Add(dropDownItem.Value);
      }
      return (IEnumerable<string>) localizableStrings;
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
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            case 2:
              goto label_6;
            default:
              this.propertyDescriptor = propertyDescriptor1 = (IFullTextPropertyDescriptor) new DropDownPropertyDescriptor((ISerializableTypeDescriptor) this);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 2;
              continue;
          }
        }
label_2:
        return propertyDescriptor2;
label_6:
        return propertyDescriptor1;
      }
    }

    public DropDownListDescriptor()
    {
      DropDownListDescriptor.zkkduTo7o02kcCrarmwv();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static DropDownListDescriptor()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            DropDownListDescriptor.UID = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1052221104 - 768835541 ^ 283548659));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
            continue;
          case 2:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 0 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static void n9htvqoAJlFBU17lYR1b([In] object obj0, [In] object obj1, [In] object obj2) => __nonvirtual (((SimpleTypeDescriptor<DropDownItem>) obj0).ExtendSimplePropertyMapping((INHibernatePropertyTypeMapper) obj1, (EntityPropertyMetadata) obj2));

    internal static bool fAN7LVoAyd3EZ9hmt0U5() => DropDownListDescriptor.hrq1oPoAmU2K3MFBP7Yf == null;

    internal static DropDownListDescriptor PGk2cGoAMS8DSBLY9rCp() => DropDownListDescriptor.hrq1oPoAmU2K3MFBP7Yf;

    internal static object dnOjFPoA93fF8IeXeltS(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool Ji69XUoAdCcpUecZXsDu([In] object obj0, [In] object obj1, [In] object obj2) => ((TypeDescriptor) obj0).IsEmpty((PropertyMetadata) obj1, obj2);

    internal static object sCBV3voAlL5RcXZma4D7([In] object obj0) => (object) ((PropertyMetadata) obj0).Settings;

    internal static object D34pYboArvSJPoSaUTk9([In] object obj0) => (object) ((DropDownItem) obj0).Value;

    internal static object xcojBqoAglxy3l9UrKuy([In] object obj0) => (object) ((DropDownListSettings) obj0).DefaultValue;

    internal static object k5TgGToA5fqSnCntJ3mj([In] object obj0) => (object) ((DropDownItem) obj0).Key;

    internal static bool PpUbVUoAjDCFA0WRD3SE([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static bool zgJQFAoAYm4YVQPjDYh0([In] object obj0, [In] object obj1) => ((string) obj0).Equals((string) obj1);

    internal static void gLUbqcoALhHks7ZSOPOb([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static Type j1Xw2toAUFJyPbs05Q9q([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object jRSuXAoAs9c9CxXtILco([In] object obj0) => (object) obj0.CreateSyntaxNode();

    internal static bool VKyRVEoAcGaokuO7rF7Q([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object AFnAtnoAzkTSlaZUEblJ([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static object IPie0eo7FW82drgpxVNx([In] object obj0, [In] object obj1, [In] object obj2) => (object) ElmaRestrictions.InsensitiveLike((string) obj0, (string) obj1, (MatchMode) obj2);

    internal static object Ra4VD0o7BUkSyUmHbI2h([In] object obj0, [In] object obj1) => (object) ((ICriteria) obj0).Add((ICriterion) obj1);

    internal static void BIVYhOo7Wc0Sp05SDKuV([In] object obj0, [In] object obj1) => ((DropDownListSettings) obj0).DefaultValue = (DropDownItem) obj1;

    internal static void zkkduTo7o02kcCrarmwv() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
