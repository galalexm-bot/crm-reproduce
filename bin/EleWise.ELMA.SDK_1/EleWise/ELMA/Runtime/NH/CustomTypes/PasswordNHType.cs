// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.CustomTypes.PasswordNHType
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Common.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Engine;
using NHibernate.Type;
using NHibernate.UserTypes;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Data;
using System.Data.Common;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.NH.CustomTypes
{
  /// <summary>Тип пароль для NHibernate</summary>
  [Serializable]
  public class PasswordNHType : ICompositeUserType
  {
    /// <summary>Постфикс для хешевой колонки</summary>
    internal static string HashColumn;
    /// <summary>Постфикс для солевой колонки</summary>
    internal static string SaltColumn;
    internal static PasswordNHType AomFKAWx0k8QfhdlO8U0;

    /// <summary>Колонка для хеша</summary>
    /// <param name="propertyName">Название свойства</param>
    /// <returns></returns>
    internal static string GenerateHashName(string propertyName) => (string) PasswordNHType.wLxn9HWxMTFHtYC8dkIf((object) propertyName, (object) PasswordNHType.HashColumn);

    /// <summary>Колонка для соли</summary>
    /// <param name="propertyName">Название свойства</param>
    /// <returns></returns>
    internal static string GenerateSaltName(string propertyName) => propertyName + PasswordNHType.SaltColumn;

    /// <summary>Глубокая копия</summary>
    /// <param name="value">Объект типа "Пароль"</param>
    /// <returns></returns>
    public object DeepCopy(object value)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (value == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return (object) null;
label_5:
      return PasswordNHType.tRPIudWx9EILMGjIQe1S(PasswordNHType.hpfi6kWxJP24vRQCxSC2(value));
    }

    /// <summary>Восстановление сущности из кэшевого представления</summary>
    /// <param name="cached">Кэшированное представление</param>
    /// <param name="session">Сессия</param>
    /// <param name="owner">Родительский объект</param>
    /// <returns></returns>
    public object Assemble(object cached, ISessionImplementor session, object owner) => this.DeepCopy(cached);

    /// <summary>Получение представления для кэша из оригинала</summary>
    /// <param name="value">Объект</param>
    /// <param name="session">Сессия</param>
    /// <returns></returns>
    public object Disassemble(object value, ISessionImplementor session) => this.DeepCopy(value);

    /// <summary>Сравнение объектов</summary>
    /// <param name="x">Объект 1</param>
    /// <param name="y">Объект 2</param>
    /// <returns></returns>
    public bool Equals(object x, object y)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 4:
            goto label_7;
          case 2:
            goto label_2;
          case 3:
            if (x != y)
            {
              if (x == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 1 : 1;
                continue;
              }
              break;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 2 : 1;
            continue;
        }
        if (y == null)
          num = 4;
        else
          goto label_8;
      }
label_2:
      return true;
label_7:
      return false;
label_8:
      return x.Equals(y);
    }

    /// <summary>Считаем хеш-код</summary>
    /// <param name="x">Объект, по которому считается хеш-код</param>
    /// <returns></returns>
    public int GetHashCode(object x)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (x != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return x.GetHashCode();
label_3:
      // ISSUE: type reference
      return PasswordNHType.b6ve8sWxdgdZBPxHycUB(__typeref (PasswordInfo)).GetHashCode() + 327;
    }

    /// <summary>
    /// Поддерживает ли этот тип неизменяемость на уровне хибера (опция Immutable)
    /// </summary>
    public bool IsMutable => true;

    /// <summary>Получить информацию из БД</summary>
    /// <param name="dr">Ридер, из которого читаются данные</param>
    /// <param name="names">Колонки</param>
    /// <param name="session">Сессия</param>
    /// <param name="owner">Родительский объект</param>
    /// <returns></returns>
    public object NullSafeGet(
      DbDataReader dr,
      string[] names,
      ISessionImplementor session,
      object owner)
    {
      int num = 1;
      object obj1;
      object obj2;
      while (true)
      {
        switch (num)
        {
          case 1:
            obj2 = PasswordNHType.o1n9gDWxlocUCKso5jcc((object) NHibernateUtil.String, (object) dr, (object) names[0], (object) session);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_5;
          case 3:
            if (obj2 != null)
            {
              num = 4;
              continue;
            }
            goto label_6;
          case 4:
            if (obj1 == null)
            {
              num = 5;
              continue;
            }
            goto label_5;
          case 5:
            goto label_6;
          default:
            obj1 = PasswordNHType.o1n9gDWxlocUCKso5jcc((object) NHibernateUtil.String, (object) dr, (object) names[1], (object) session);
            num = 3;
            continue;
        }
      }
label_5:
      return (object) new PasswordInfo((string) PasswordNHType.R42xhIWxrcEoHucOHhYi(obj2), Convert.ToString(obj1), Guid.Empty);
label_6:
      return (object) null;
    }

    /// <summary>Сохранить объект в БД</summary>
    /// <param name="cmd">Команда, для выполнения запроса в БД</param>
    /// <param name="value">Объект</param>
    /// <param name="index">Индекс колоки, где хранится значение</param>
    /// <param name="session">Сессия</param>
    public void NullSafeSet(IDbCommand cmd, object value, int index, ISessionImplementor session)
    {
      int num1 = 1;
      while (true)
      {
        int num2 = num1;
        PasswordInfo passwordInfo;
        while (true)
        {
          switch (num2)
          {
            case 1:
              passwordInfo = (PasswordInfo) PasswordNHType.hpfi6kWxJP24vRQCxSC2(value);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 0;
              continue;
            case 2:
              PasswordNHType.zikrpBWx5YlJ5O7iBH7f((object) (IDataParameter) ((IList) PasswordNHType.lijaS7WxgLqfGFE4o8rK((object) cmd))[index], (object) DBNull.Value);
              num2 = 3;
              continue;
            case 3:
              ((IDataParameter) cmd.Parameters[index + 1]).Value = (object) DBNull.Value;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 6 : 6;
              continue;
            case 4:
              goto label_10;
            case 5:
              goto label_5;
            case 6:
              goto label_3;
            default:
              if (passwordInfo != null)
              {
                PasswordNHType.zikrpBWx5YlJ5O7iBH7f((object) (IDataParameter) ((IList) PasswordNHType.lijaS7WxgLqfGFE4o8rK((object) cmd))[index], PasswordNHType.WVEho9WxjA1LkD5NngrN((object) passwordInfo));
                num2 = 4;
                continue;
              }
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 2;
              continue;
          }
        }
label_10:
        PasswordNHType.zikrpBWx5YlJ5O7iBH7f((object) (IDataParameter) PasswordNHType.DXLCSjWxYUdhCXLNaH2t(PasswordNHType.lijaS7WxgLqfGFE4o8rK((object) cmd), index + 1), (object) passwordInfo.Salt);
        num1 = 5;
      }
label_5:
      return;
label_3:;
    }

    /// <summary>Сохранить объект в БД</summary>
    /// <param name="cmd">Команда, для выполнения запроса в БД</param>
    /// <param name="value">Объект</param>
    /// <param name="index">Индекс колоки, где хранится значение</param>
    /// <param name="settable">Можно ли устанавливать значение, по колонкам</param>
    /// <param name="session">Сессия</param>
    public void NullSafeSet(
      DbCommand cmd,
      object value,
      int index,
      bool[] settable,
      ISessionImplementor session)
    {
      int num = 2;
      PasswordInfo passwordInfo;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (passwordInfo == null)
            {
              num = 7;
              continue;
            }
            if (settable[0])
            {
              num = 6;
              continue;
            }
            goto case 3;
          case 2:
            passwordInfo = (PasswordInfo) PasswordNHType.hpfi6kWxJP24vRQCxSC2(value);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 1;
            continue;
          case 3:
            if (!settable[1])
            {
              num = 8;
              continue;
            }
            goto case 4;
          case 4:
            ((DbParameterCollection) PasswordNHType.VKNMqJWxLN4QwheC9vel((object) cmd))[index + 1].Value = (object) passwordInfo.Salt;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 3 : 9;
            continue;
          case 5:
            goto label_11;
          case 6:
            PasswordNHType.zikrpBWx5YlJ5O7iBH7f((object) ((DbParameterCollection) PasswordNHType.VKNMqJWxLN4QwheC9vel((object) cmd))[index], PasswordNHType.WVEho9WxjA1LkD5NngrN((object) passwordInfo));
            num = 3;
            continue;
          case 7:
            if (settable[0])
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 0;
              continue;
            }
            goto case 12;
          case 8:
            goto label_12;
          case 9:
            goto label_10;
          case 10:
            goto label_2;
          case 11:
            ((IDataParameter) PasswordNHType.qowtRRWxUXRTkhsLT1LX(PasswordNHType.VKNMqJWxLN4QwheC9vel((object) cmd), index + 1)).Value = (object) DBNull.Value;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 5 : 4;
            continue;
          case 12:
            if (!settable[1])
            {
              num = 10;
              continue;
            }
            goto case 11;
          default:
            PasswordNHType.zikrpBWx5YlJ5O7iBH7f(PasswordNHType.qowtRRWxUXRTkhsLT1LX(PasswordNHType.VKNMqJWxLN4QwheC9vel((object) cmd), index), (object) DBNull.Value);
            num = 12;
            continue;
        }
      }
label_11:
      return;
label_12:
      return;
label_10:
      return;
label_2:;
    }

    /// <summary>Колонки сложного типа</summary>
    public string[] PropertyNames => new string[2]
    {
      PasswordNHType.HashColumn,
      PasswordNHType.SaltColumn
    };

    /// <summary>Типы колонок</summary>
    public IType[] PropertyTypes => new IType[2]
    {
      (IType) NHibernateUtil.String,
      (IType) NHibernateUtil.String
    };

    /// <summary>Получить объект для операции merge, replace</summary>
    /// <param name="original">Оригинальный объетк</param>
    /// <param name="target">Конечный объект</param>
    /// <param name="session">Сессия</param>
    /// <param name="owner">Родительский объект</param>
    /// <returns></returns>
    public object Replace(
      object original,
      object target,
      ISessionImplementor session,
      object owner)
    {
      return this.DeepCopy(original);
    }

    /// <summary>Возвращаемый тип</summary>
    public System.Type ReturnedClass => PasswordNHType.b6ve8sWxdgdZBPxHycUB(__typeref (PasswordInfo));

    /// <summary>Получить свойство из объекта по индексу</summary>
    /// <param name="component">Оригинальный объект</param>
    /// <param name="property">Порядковый номер свойства</param>
    /// <returns></returns>
    public object GetPropertyValue(object component, int property)
    {
      int num = 1;
      PasswordInfo passwordInfo;
      while (true)
      {
        switch (num)
        {
          case 1:
            passwordInfo = (PasswordInfo) PasswordNHType.hpfi6kWxJP24vRQCxSC2(component);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 0 : 0;
            continue;
          case 2:
          case 3:
            goto label_7;
          case 4:
            goto label_9;
          case 5:
            if (property != 1)
            {
              num = 4;
              continue;
            }
            goto label_8;
          default:
            if (property == 0)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 2 : 1;
              continue;
            }
            goto case 5;
        }
      }
label_7:
      return PasswordNHType.WVEho9WxjA1LkD5NngrN((object) passwordInfo);
label_8:
      return PasswordNHType.RI2YGlWxsCiwCZE4N1EY((object) passwordInfo);
label_9:
      throw new Exception((string) PasswordNHType.yFRSY0WxzqMZneE5CVvU(PasswordNHType.A8cfCUWxclknv3E51tae(1319452732 ^ 1319594420), (object) property));
    }

    /// <summary>Присвоить свойство по индексу</summary>
    /// <param name="component">Оригинальный объект</param>
    /// <param name="property">Порядковый номер свойства</param>
    /// <param name="value">Значение для установки</param>
    public void SetPropertyValue(object component, int property, object value)
    {
      int num = 4;
      PasswordInfo passwordInfo;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_11;
          case 2:
            goto label_5;
          case 3:
            passwordInfo = (PasswordInfo) PasswordNHType.hpfi6kWxJP24vRQCxSC2(component);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 0 : 0;
            continue;
          case 4:
            if (component != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 2 : 3;
              continue;
            }
            goto label_5;
          case 5:
            goto label_2;
          case 6:
            passwordInfo.Hash = (string) PasswordNHType.R42xhIWxrcEoHucOHhYi(value);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 5 : 5;
            continue;
          case 7:
            if (property != 1)
            {
              num = 8;
              continue;
            }
            PasswordNHType.mjdRgHW0FVQxnwJVcCCn((object) passwordInfo, PasswordNHType.R42xhIWxrcEoHucOHhYi(value));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 1 : 1;
            continue;
          case 8:
            goto label_3;
          default:
            if (property != 0)
            {
              num = 7;
              continue;
            }
            goto case 6;
        }
      }
label_11:
      return;
label_2:
      return;
label_3:
      throw new Exception((string) PasswordNHType.yFRSY0WxzqMZneE5CVvU(PasswordNHType.A8cfCUWxclknv3E51tae(-1858887263 ^ -1859024855), (object) property));
label_5:
      throw new ArgumentNullException((string) PasswordNHType.A8cfCUWxclknv3E51tae(1642859704 ^ 1642997072));
    }

    private static PasswordInfo AsPasswordInfo(object value)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (value != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          case 2:
            goto label_5;
          default:
            goto label_6;
        }
      }
label_5:
      return (PasswordInfo) null;
label_6:
      // ISSUE: type reference
      return value is PasswordInfo passwordInfo ? passwordInfo : throw new InvalidCastException(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(236071375 ^ 235929649), (object) PasswordNHType.b6ve8sWxdgdZBPxHycUB(__typeref (PasswordInfo)), (object) value.GetType()));
    }

    public PasswordNHType()
    {
      PasswordNHType.WGkXB4W0BnKbaNtCulEl();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static PasswordNHType()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            PasswordNHType.HashColumn = (string) PasswordNHType.A8cfCUWxclknv3E51tae(825385222 ^ 825248576);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 0;
            continue;
          case 2:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_2;
          default:
            PasswordNHType.SaltColumn = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675367949);
            num = 3;
            continue;
        }
      }
label_2:;
    }

    internal static object wLxn9HWxMTFHtYC8dkIf([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static bool Row85sWxmWBETuBWULrk() => PasswordNHType.AomFKAWx0k8QfhdlO8U0 == null;

    internal static PasswordNHType zv0LI6WxyZi1xnvLbsiY() => PasswordNHType.AomFKAWx0k8QfhdlO8U0;

    internal static object hpfi6kWxJP24vRQCxSC2([In] object obj0) => (object) PasswordNHType.AsPasswordInfo(obj0);

    internal static object tRPIudWx9EILMGjIQe1S([In] object obj0) => ((PasswordInfo) obj0).Clone();

    internal static System.Type b6ve8sWxdgdZBPxHycUB([In] RuntimeTypeHandle obj0) => System.Type.GetTypeFromHandle(obj0);

    internal static object o1n9gDWxlocUCKso5jcc(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return ((NullableType) obj0).NullSafeGet((DbDataReader) obj1, (string) obj2, (ISessionImplementor) obj3);
    }

    internal static object R42xhIWxrcEoHucOHhYi([In] object obj0) => (object) Convert.ToString(obj0);

    internal static object lijaS7WxgLqfGFE4o8rK([In] object obj0) => (object) ((IDbCommand) obj0).Parameters;

    internal static void zikrpBWx5YlJ5O7iBH7f([In] object obj0, [In] object obj1) => ((IDataParameter) obj0).Value = obj1;

    internal static object WVEho9WxjA1LkD5NngrN([In] object obj0) => (object) ((PasswordInfo) obj0).Hash;

    internal static object DXLCSjWxYUdhCXLNaH2t([In] object obj0, [In] int obj1) => ((IList) obj0)[obj1];

    internal static object VKNMqJWxLN4QwheC9vel([In] object obj0) => (object) ((DbCommand) obj0).Parameters;

    internal static object qowtRRWxUXRTkhsLT1LX([In] object obj0, [In] int obj1) => (object) ((DbParameterCollection) obj0)[obj1];

    internal static object RI2YGlWxsCiwCZE4N1EY([In] object obj0) => (object) ((PasswordInfo) obj0).Salt;

    internal static object A8cfCUWxclknv3E51tae(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object yFRSY0WxzqMZneE5CVvU([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static void mjdRgHW0FVQxnwJVcCCn([In] object obj0, [In] object obj1) => ((PasswordInfo) obj0).Salt = (string) obj1;

    internal static void WGkXB4W0BnKbaNtCulEl() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
