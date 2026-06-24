// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.HtmlStringDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.FullTextSearch.Descriptors;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.HtmlStrings;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.MetadataInternalContainer.Containers;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Mvc;

namespace EleWise.ELMA.Model.Types
{
  /// <summary>Описание типа "HTML разметка"</summary>
  [Component(Order = 300)]
  public class HtmlStringDescriptor : 
    CLRTypeDescriptor<HtmlString, HtmlStringSettings>,
    IMappingTypeDescriptor,
    IConvertableTypeDescriptor
  {
    /// <summary>Uid типа</summary>
    public const string UID_S = "{0AEF74A9-D37C-4731-813B-D5F0B5EC4392}";
    /// <summary>Uid типа</summary>
    public static readonly Guid UID;
    private IFullTextPropertyDescriptor propertyDescriptor;
    private static HtmlStringDescriptor jmaBbCoHpaXhX0uxgUsX;

    /// <inheritdoc />
    protected override void ExtendSimplePropertyMapping(
      INHibernatePropertyTypeMapper mapper,
      EntityPropertyMetadata propertyMetadata)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            mapper.Type<HtmlStringType>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 0 : 0;
            continue;
          case 2:
            base.ExtendSimplePropertyMapping(mapper, propertyMetadata);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    /// <summary>Uid типа данных или группы типов</summary>
    public override Guid Uid => HtmlStringDescriptor.UID;

    /// <summary>Имя типа данных (или группы)</summary>
    public override string Name => (string) HtmlStringDescriptor.gbvoMyoHtE7dw2FMD0Ug((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(825385222 ^ 825287480));

    /// <summary>Пустое значение или нет</summary>
    /// <param name="propertyMetadata"></param>
    /// <param name="val"></param>
    /// <returns></returns>
    public override bool IsEmpty(PropertyMetadata propertyMetadata, object val)
    {
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!(val is IHtmlString))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          case 2:
            goto label_11;
          case 3:
            goto label_8;
          case 4:
            if (val == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 3 : 3;
              continue;
            }
            if (HtmlStringDescriptor.dbxgaloHwR61a22VcNeK(val.GetType(), typeof (string)))
            {
              num = 2;
              continue;
            }
            goto case 1;
          default:
            goto label_7;
        }
      }
label_4:
      object obj = HtmlStringDescriptor.yYPecqoH4Oo3CUS9JC3L((object) (IHtmlString) val);
      goto label_12;
label_7:
      obj = (object) null;
      goto label_12;
label_8:
      return true;
label_11:
      obj = (object) (string) val;
label_12:
      return HtmlStringDescriptor.oFGWusoH6MJiZfPMGmXy(obj);
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
      int num = 4;
      HtmlStringSettings htmlStringSettings;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_4;
          case 2:
            if (HtmlStringDescriptor.oFGWusoH6MJiZfPMGmXy(HtmlStringDescriptor.flFObcoHxTlo0FBCDY2m((object) htmlStringSettings)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 1 : 1;
              continue;
            }
            goto label_5;
          case 3:
            htmlStringSettings = (HtmlStringSettings) HtmlStringDescriptor.ejsPjloH7NeQZOu78tUK((object) propertyMetadata);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 0 : 0;
            continue;
          case 4:
            HtmlStringDescriptor.XFcS3ToHADMY4tQAsAhA((object) propertyMetadata, HtmlStringDescriptor.yZHPLtoHHwis8IZdpcEu(647913418 ^ 647894680));
            num = 3;
            continue;
          default:
            if (htmlStringSettings != null)
            {
              num = 2;
              continue;
            }
            goto label_4;
        }
      }
label_4:
      return (ISyntaxNode) null;
label_5:
      // ISSUE: type reference
      return ((ISyntaxNode) HtmlStringDescriptor.j1QkvkoHmFIkjIS8Wmy1(HtmlStringDescriptor.QreBo6oH0YnChfOD8sNQ(__typeref (MvcHtmlString)))).ObjectCreationExpression(htmlStringSettings.DefaultValue.CreateSyntaxNode());
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
      int num = 2;
      HtmlStringSettings htmlStringSettings;
      while (true)
      {
        string str;
        switch (num)
        {
          case 1:
            htmlStringSettings = (HtmlStringSettings) HtmlStringDescriptor.ejsPjloH7NeQZOu78tUK((object) propertyMetadata);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 3 : 4;
            continue;
          case 2:
            HtmlStringDescriptor.XFcS3ToHADMY4tQAsAhA((object) propertyMetadata, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1218962250 ^ 1218947608));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 1;
            continue;
          case 3:
            goto label_9;
          case 4:
            if (htmlStringSettings == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 0 : 0;
              continue;
            }
            // ISSUE: explicit non-virtual call
            str = __nonvirtual (htmlStringSettings.DefaultValue);
            break;
          case 5:
            if (htmlStringSettings == null)
            {
              num = 6;
              continue;
            }
            goto label_14;
          case 6:
            goto label_4;
          default:
            str = (string) null;
            break;
        }
        if (!string.IsNullOrEmpty(str))
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 2 : 5;
        else
          goto label_9;
      }
label_4:
      string str1 = (string) null;
      goto label_15;
label_9:
      MvcHtmlString mvcHtmlString = (MvcHtmlString) null;
      goto label_16;
label_14:
      // ISSUE: explicit non-virtual call
      str1 = __nonvirtual (htmlStringSettings.DefaultValue);
label_15:
      mvcHtmlString = new MvcHtmlString(str1);
label_16:
      return (IPropertyDefaultValueContainer) new PropertyValueContainer<HtmlString>((HtmlString) mvcHtmlString);
    }

    public virtual object ConvertFrom(object value, PropertyMetadata propertyMetadata)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_8;
          case 2:
            if (!(value is HtmlString))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 0 : 0;
              continue;
            }
            goto label_8;
          case 3:
            if (value != null)
            {
              num = 2;
              continue;
            }
            goto label_8;
          case 4:
            goto label_4;
          default:
            // ISSUE: type reference
            if (value.GetType() == HtmlStringDescriptor.QreBo6oH0YnChfOD8sNQ(__typeref (string)))
            {
              num = 4;
              continue;
            }
            goto label_5;
        }
      }
label_4:
      return HtmlStringDescriptor.u7OplToHy7tVFxGInqRa((object) (string) value);
label_5:
      return (object) null;
label_8:
      return value;
    }

    public override object SerializeSimple(
      object value,
      Type valueType,
      EntitySerializationSettings settings)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (value is IHtmlString)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 0 : 0;
              continue;
            }
            goto case 3;
          case 2:
            goto label_4;
          case 3:
            if (value == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 1 : 2;
              continue;
            }
            goto label_5;
          default:
            goto label_6;
        }
      }
label_4:
      return (object) null;
label_5:
      return (object) value.ToString();
label_6:
      return HtmlStringDescriptor.yYPecqoH4Oo3CUS9JC3L((object) (IHtmlString) value);
    }

    public override object DeserializeSimple(object value, Type deserializeToType) => this.ConvertFrom(value, (PropertyMetadata) null);

    public override TypeSettings CreateSettingsForFilterProperty(PropertyMetadata propertyMetadata)
    {
      int num = 2;
      HtmlStringSettings forFilterProperty;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (forFilterProperty == null)
            {
              num = 3;
              continue;
            }
            break;
          case 2:
            forFilterProperty = (HtmlStringSettings) base.CreateSettingsForFilterProperty(propertyMetadata);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 1 : 1;
            continue;
          case 3:
          case 4:
            goto label_3;
        }
        HtmlStringDescriptor.omou8eoHM8BtONGDkanp((object) forFilterProperty, (object) null);
        num = 4;
      }
label_3:
      return (TypeSettings) forFilterProperty;
    }

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
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <param name="val">Значение фильтра</param>
    public override void ApplyFilterValue(
      ICriteria criteria,
      EntityMetadata metadata,
      EntityPropertyMetadata propertyMetadata,
      object val,
      string alias)
    {
      int num = 8;
      while (true)
      {
        string str;
        object obj;
        switch (num)
        {
          case 1:
            obj = HtmlStringDescriptor.yYPecqoH4Oo3CUS9JC3L((object) (IHtmlString) val);
            break;
          case 2:
            goto label_4;
          case 3:
            if (val is IHtmlString)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 1 : 1;
              continue;
            }
            goto case 5;
          case 4:
            if (str != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
              continue;
            }
            goto label_16;
          case 5:
            obj = (object) null;
            break;
          case 6:
            obj = (object) (string) val;
            break;
          case 7:
            if (val is string)
            {
              num = 6;
              continue;
            }
            goto case 3;
          case 8:
            if (val != null)
            {
              num = 7;
              continue;
            }
            goto label_17;
          case 9:
            HtmlStringDescriptor.A7IwK9oHleQPy4uG5oik((object) criteria, HtmlStringDescriptor.LiZOuZoHdeYVGXrXgWlK(!HtmlStringDescriptor.oFGWusoH6MJiZfPMGmXy((object) alias) ? HtmlStringDescriptor.O0iiZNoHJk7PXecVDQEL(HtmlStringDescriptor.yZHPLtoHHwis8IZdpcEu(322893104 - -1992822529 ^ -1979234765), (object) alias, (object) propertyMetadata.Name) : HtmlStringDescriptor.M09UBdoH91AMvPI8XO7y((object) propertyMetadata), (object) str, (object) MatchMode.Anywhere));
            num = 2;
            continue;
          case 10:
            goto label_15;
          case 11:
            goto label_22;
          default:
            if (!str.Trim().Equals(string.Empty))
            {
              num = 9;
              continue;
            }
            goto label_11;
        }
        str = (string) obj;
        num = 4;
      }
label_4:
      return;
label_15:
      return;
label_22:
      return;
label_16:
      return;
label_11:
      return;
label_17:;
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
              this.propertyDescriptor = propertyDescriptor1 = (IFullTextPropertyDescriptor) new HtmlStringPropertyDescriptor((ISerializableTypeDescriptor) this);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 0 : 0;
              continue;
            case 2:
              propertyDescriptor2 = this.propertyDescriptor;
              if (propertyDescriptor2 == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 1;
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

    public HtmlStringDescriptor()
    {
      HtmlStringDescriptor.whEpjLoHrDY6oW8JHimm();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static HtmlStringDescriptor()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            HtmlStringDescriptor.UID = new Guid((string) HtmlStringDescriptor.yZHPLtoHHwis8IZdpcEu(1051802738 - -1831968059 ^ -1411359759));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
            continue;
          case 2:
            HtmlStringDescriptor.whEpjLoHrDY6oW8JHimm();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static bool vcF43SoHaiBaMaMARD7o() => HtmlStringDescriptor.jmaBbCoHpaXhX0uxgUsX == null;

    internal static HtmlStringDescriptor H35xa1oHDDI8kaLJ6Zmm() => HtmlStringDescriptor.jmaBbCoHpaXhX0uxgUsX;

    internal static object gbvoMyoHtE7dw2FMD0Ug([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool dbxgaloHwR61a22VcNeK([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static object yYPecqoH4Oo3CUS9JC3L([In] object obj0) => (object) ((IHtmlString) obj0).ToHtmlString();

    internal static bool oFGWusoH6MJiZfPMGmXy([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object yZHPLtoHHwis8IZdpcEu(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void XFcS3ToHADMY4tQAsAhA([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static object ejsPjloH7NeQZOu78tUK([In] object obj0) => (object) ((PropertyMetadata) obj0).Settings;

    internal static object flFObcoHxTlo0FBCDY2m([In] object obj0) => (object) ((HtmlStringSettings) obj0).DefaultValue;

    internal static Type QreBo6oH0YnChfOD8sNQ([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object j1QkvkoHmFIkjIS8Wmy1(Type type) => (object) type.CreateTypeSyntax();

    internal static object u7OplToHy7tVFxGInqRa([In] object obj0) => (object) MvcHtmlString.Create((string) obj0);

    internal static void omou8eoHM8BtONGDkanp([In] object obj0, [In] object obj1) => ((HtmlStringSettings) obj0).DefaultValue = (string) obj1;

    internal static object O0iiZNoHJk7PXecVDQEL([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static object M09UBdoH91AMvPI8XO7y([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static object LiZOuZoHdeYVGXrXgWlK([In] object obj0, [In] object obj1, [In] object obj2) => (object) ElmaRestrictions.InsensitiveLike((string) obj0, (string) obj1, (MatchMode) obj2);

    internal static object A7IwK9oHleQPy4uG5oik([In] object obj0, [In] object obj1) => (object) ((ICriteria) obj0).Add((ICriterion) obj1);

    internal static void whEpjLoHrDY6oW8JHimm() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
