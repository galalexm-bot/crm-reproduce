// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Helpers.PropertyHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Helpers
{
  /// <summary>Помощник для работы со свойствами</summary>
  public class PropertyHelper
  {
    private static PropertyHelper akkInJhLEJXrvHId1Cmj;

    /// <summary>Скрывать ли поле сущности</summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="entity">Сущность</param>
    /// <param name="expr"></param>
    /// <returns></returns>
    public static bool IsHide<T>(T entity, Expression<Func<T, object>> expr) where T : class => Locator.GetService<IPropertyPermissionService>().CheckPropertyPermission((object) entity, InterfaceActivator.PropertyUid<T>(expr, true)) == PropertyPermissionType.Hide;

    /// <summary>
    /// Сформировать выражение для фильтрации по заданному свойству
    /// <br><b>Пример вызова:</b></br>
    /// <br>GetNameSortExpression &lt;TestEntity&gt;(e =&gt; e.Prop) - вернет "Prop.Name" </br>
    /// </summary>
    /// <typeparam name="T">Тип сущности</typeparam>
    /// <param name="expr">Выражение для получения свойства</param>
    /// <returns>Строка для сортировки</returns>
    public static string GetNameSortExpression<T>(Expression<Func<T, object>> expr) where T : class
    {
      Type type = typeof (T);
      if (!(expr.Body is MemberExpression body))
        throw new ArgumentException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(589593376 ^ -1977315327 ^ -1459401365), (object) expr));
      PropertyInfo member = body.Member as PropertyInfo;
      if (member == (PropertyInfo) null)
        throw new ArgumentException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1514961705 ^ 1515183505), (object) expr));
      if (type != member.ReflectedType && !type.IsSubclassOf(member.ReflectedType))
        throw new ArgumentException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-53329496 >> 4 ^ -3243202), (object) expr, (object) type));
      string propertyNameByMetadata = PropertyHelper.GetTitlePropertyNameByMetadata(member.PropertyType);
      return string.IsNullOrEmpty(propertyNameByMetadata) ? member.Name : member.Name + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-53329496 >> 4 ^ -3326242) + propertyNameByMetadata;
    }

    /// <summary>Получить для сущности "Имя" свойства-наименования</summary>
    /// <param name="entityType">Тип сущности</param>
    /// <returns>"Имя" свойства-наименования</returns>
    internal static string GetTitlePropertyNameByMetadata(Type entityType)
    {
      int num = 1;
      object obj;
      while (true)
      {
        switch (num)
        {
          case 1:
            obj = PropertyHelper.dXdk8ehLC5ADoWB9V0m3(entityType);
            if (obj == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return (string) null;
label_5:
      return (string) PropertyHelper.TZndk1hLvg6PZ4PTSDtc(obj);
    }

    /// <summary>
    /// Получить для сущности свойство, являющееся наименованием
    /// </summary>
    /// <param name="entityType">Тип сущности</param>
    /// <returns>Свойство-наименование</returns>
    internal static PropertyMetadata GetTitlePropertyByMetadata(Type entityType)
    {
      int num = 2;
      EntityMetadata entityMetadata;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (entityMetadata == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 0 : 0;
              continue;
            }
            goto label_6;
          case 2:
            entityMetadata = MetadataLoader.LoadMetadata(entityType) as EntityMetadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return (PropertyMetadata) null;
label_6:
      return (PropertyMetadata) PropertyHelper.YmIajthL8WgWf0lu474h((object) entityMetadata);
    }

    /// <summary>
    /// Сформировать выражение для фильтрации по метаданным свойства
    /// <br><b>Пример вызова:</b></br>
    /// <br>GetNameSortExpression(propertyMetadata)</br>
    /// </summary>
    /// <param name="propertyMetadata">Метаданные свойства сущности</param>
    /// <returns>Строка для сортировки</returns>
    public static string GetNameSortExpression(IPropertyMetadata propertyMetadata)
    {
      int num1 = 8;
      string str;
      while (true)
      {
        int num2 = num1;
        Guid? nullable1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_11;
            case 2:
              goto label_3;
            case 3:
              goto label_14;
            case 4:
              nullable1 = new Guid?();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 2 : 2;
              continue;
            case 5:
              goto label_13;
            case 6:
              if (!PropertyHelper.DkFFvOhLVg5De8nqS9mB((object) str))
              {
                num2 = 3;
                continue;
              }
              goto label_13;
            case 7:
              goto label_15;
            case 8:
              if (propertyMetadata != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 7 : 3;
                continue;
              }
              goto case 4;
            case 9:
              if (!PropertyHelper.z1cwd2hLutssaDJMim5A(nullable1.GetValueOrDefault(), Guid.Empty))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 0;
                continue;
              }
              goto label_11;
            default:
              str = (string) PropertyHelper.oJ1pPyhLInSBbyU37LTL(PropertyHelper.tdim6yhLZ6hmMt1IocEo((object) propertyMetadata));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 6 : 6;
              continue;
          }
        }
label_3:
        Guid? nullable2 = nullable1;
        goto label_16;
label_15:
        nullable2 = new Guid?(PropertyHelper.tdim6yhLZ6hmMt1IocEo((object) propertyMetadata));
label_16:
        nullable1 = nullable2;
        num1 = 9;
      }
label_11:
      return propertyMetadata.Name;
label_13:
      return propertyMetadata.Name;
label_14:
      return (string) PropertyHelper.dj2ph5hLiX09pq64LZeX((object) propertyMetadata.Name, PropertyHelper.dtLpLChLS7OIkkABmsll(572119659 - -337058038 ^ 909175205), (object) str);
    }

    /// <summary>Получить для сущности "Имя" свойства-наименования</summary>
    /// <param name="subTypeUid">Uid типа сущности</param>
    /// <returns>"Имя" свойства-наименования</returns>
    internal static string GetTitlePropertyNameByMetadata(Guid subTypeUid)
    {
      int num = 1;
      object obj;
      while (true)
      {
        switch (num)
        {
          case 1:
            obj = PropertyHelper.jR50RchLRPG3TZV0Qpqn(subTypeUid);
            if (obj == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return (string) null;
label_5:
      return (string) PropertyHelper.TZndk1hLvg6PZ4PTSDtc(obj);
    }

    /// <summary>
    /// Получить для сущности свойство, являющееся наименованием
    /// </summary>
    /// <param name="subTypeUid">Uid типа сущности</param>
    /// <returns>Свойство-наименование</returns>
    internal static PropertyMetadata GetTitlePropertyByMetadata(Guid subTypeUid)
    {
      int num = 3;
      EntityMetadata entityMetadata;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_6;
          case 2:
            if (entityMetadata != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 1 : 1;
              continue;
            }
            goto label_5;
          case 3:
            entityMetadata = MetadataLoader.LoadMetadata(subTypeUid) as EntityMetadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 2 : 2;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return (PropertyMetadata) null;
label_6:
      return (PropertyMetadata) PropertyHelper.YmIajthL8WgWf0lu474h((object) entityMetadata);
    }

    /// <summary>
    /// Сформировать выражение для фильтрации по метаданным свойства
    /// <br><b>Пример вызова:</b></br>
    /// <br>GetSortExpression(propertyMetadata, defaultValue)</br>
    /// </summary>
    /// <param name="propMetadata">Метаданные свойства сущности</param>
    /// <param name="defaultValue">Значение по умолчанию</param>
    /// <returns>Строка для сортировки</returns>
    internal static string GetSortExpression(IPropertyMetadata propMetadata, string defaultValue)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (propMetadata == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return defaultValue;
label_3:
      return (string) PropertyHelper.cw1Bm1hLqc7N8a4VfeYb((object) propMetadata);
    }

    public PropertyHelper()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object dXdk8ehLC5ADoWB9V0m3(Type entityType) => (object) PropertyHelper.GetTitlePropertyByMetadata(entityType);

    internal static object TZndk1hLvg6PZ4PTSDtc([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static bool V7YZ98hLfivEjVSL20Nj() => PropertyHelper.akkInJhLEJXrvHId1Cmj == null;

    internal static PropertyHelper JWCgSdhLQWSHg4aHbBve() => PropertyHelper.akkInJhLEJXrvHId1Cmj;

    internal static object YmIajthL8WgWf0lu474h([In] object obj0) => (object) ((ClassMetadata) obj0).GetTitleProperty();

    internal static Guid tdim6yhLZ6hmMt1IocEo([In] object obj0) => ((IPropertyMetadata) obj0).SubTypeUid;

    internal static bool z1cwd2hLutssaDJMim5A([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static object oJ1pPyhLInSBbyU37LTL(Guid subTypeUid) => (object) PropertyHelper.GetTitlePropertyNameByMetadata(subTypeUid);

    internal static bool DkFFvOhLVg5De8nqS9mB([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object dtLpLChLS7OIkkABmsll(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object dj2ph5hLiX09pq64LZeX([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static object jR50RchLRPG3TZV0Qpqn(Guid subTypeUid) => (object) PropertyHelper.GetTitlePropertyByMetadata(subTypeUid);

    internal static object cw1Bm1hLqc7N8a4VfeYb([In] object obj0) => (object) PropertyHelper.GetNameSortExpression((IPropertyMetadata) obj0);
  }
}
