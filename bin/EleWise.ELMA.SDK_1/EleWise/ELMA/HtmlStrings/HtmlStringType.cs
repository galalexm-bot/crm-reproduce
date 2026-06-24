// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.HtmlStrings.HtmlStringType
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Engine;
using NHibernate.SqlTypes;
using NHibernate.UserTypes;
using System;
using System.Data;
using System.Data.Common;
using System.Runtime.InteropServices;
using System.Web;

namespace EleWise.ELMA.HtmlStrings
{
  /// <summary>
  /// Тип NHibernate для класса <see cref="T:System.Web.HtmlString" />
  /// </summary>
  [Serializable]
  public class HtmlStringType : IUserType
  {
    private StringSqlType _sqlType;
    private static HtmlStringType pNHU7V8Su105iJacA4J;

    /// <summary>Конструктор</summary>
    public HtmlStringType()
    {
      HtmlStringType.gHpxat8qgbR4EyZNJsQ();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this._sqlType = (StringSqlType) new StringClobSqlType();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    Type IUserType.ReturnedType => typeof (HtmlString);

    bool IUserType.IsMutable => true;

    /// <summary>The SQL types for the columns mapped by this type.</summary>
    SqlType[] IUserType.SqlTypes
    {
      get
      {
        int num = 1;
        SqlType[] sqlTypes;
        while (true)
        {
          switch (num)
          {
            case 1:
              sqlTypes = (SqlType[]) new StringSqlType[1]
              {
                this._sqlType
              };
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 0;
              continue;
            default:
              goto label_2;
          }
        }
label_2:
        return sqlTypes;
      }
    }

    /// <summary>
    /// Compare two instances of the class mapped by this type for persistent "equality"
    ///             ie. equality of persistent state
    /// </summary>
    /// <param name="x" />
    /// <param name="y" />
    /// <returns />
    bool IUserType.Equals(object x, object y)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!(y is HtmlString))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 3 : 4;
              continue;
            }
            goto label_12;
          case 2:
            if (y == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 0;
              continue;
            }
            break;
          case 3:
            if (x == null)
            {
              num = 2;
              continue;
            }
            break;
          case 4:
            goto label_11;
          default:
            goto label_8;
        }
        if (x is HtmlString)
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 1 : 1;
        else
          goto label_11;
      }
label_8:
      return true;
label_11:
      return false;
label_12:
      HtmlString htmlString1 = (HtmlString) x;
      HtmlString htmlString2 = (HtmlString) y;
      return HtmlStringType.Lo66cr8X0TOiLwMKT05(HtmlStringType.qQIyw48Ky6RkhrmYx2O((object) htmlString1), (object) htmlString2.ToHtmlString());
    }

    /// <summary>
    /// Get a hashcode for the instance, consistent with persistence "equality"
    /// </summary>
    int IUserType.GetHashCode(object x)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            if (x is HtmlString)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 1 : 1;
              continue;
            }
            goto label_2;
          default:
            goto label_2;
        }
      }
label_2:
      return 0;
label_3:
      return ((HtmlString) x).ToHtmlString().GetHashCode();
    }

    /// <summary>
    /// Retrieve an instance of the mapped class from a JDBC resultset.
    ///             Implementors should handle possibility of null values.
    /// </summary>
    /// <param name="rs">a IDataReader</param>
    /// <param name="names">column names</param>
    /// <param name="owner">the containing entity</param>
    /// <returns />
    /// <exception cref="T:NHibernate.HibernateException">HibernateException</exception>
    object IUserType.NullSafeGet(
      DbDataReader rs,
      string[] names,
      ISessionImplementor session,
      object owner)
    {
      int num = 1;
      object xml;
      while (true)
      {
        switch (num)
        {
          case 1:
            xml = NHibernateUtil.StringClob.NullSafeGet(rs, names[0], session);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return this.FromStringValue((string) xml);
    }

    void IUserType.NullSafeSet(
      DbCommand cmd,
      object value,
      int index,
      ISessionImplementor session)
    {
      int num = 1;
      string str;
      while (true)
      {
        switch (num)
        {
          case 1:
            str = this.ToString(value);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_4;
          default:
            HtmlStringType.lQLt7Q8n53FEI45FKgF(HtmlStringType.f9V2OJ8kHPXYjviaIaK(HtmlStringType.rAd3318TioZSAVmDQIE((object) cmd), index), str == null ? (object) DBNull.Value : (object) str);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 2 : 2;
            continue;
        }
      }
label_4:;
    }

    /// <summary>
    /// Return a deep copy of the persistent state, stopping at entities and at collections.
    /// </summary>
    /// <param name="value">generally a collection element or entity field</param>
    /// <returns>a copy</returns>
    object IUserType.DeepCopy(object value)
    {
      int num = 2;
      string str;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (str != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          case 2:
            str = this.ToString(value);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 0 : 1;
            continue;
          case 3:
            goto label_5;
          default:
            goto label_6;
        }
      }
label_5:
      return (object) null;
label_6:
      return (object) new HtmlString(str);
    }

    /// <summary>
    /// During merge, replace the existing (<paramref name="target" />) value in the entity
    ///             we are merging to with a new (<paramref name="original" />) value from the detached
    ///             entity we are merging. For immutable objects, or null values, it is safe to simply
    ///             return the first parameter. For mutable objects, it is safe to return a copy of the
    ///             first parameter. For objects with component values, it might make sense to
    ///             recursively replace component values.
    /// </summary>
    /// <param name="original">the value from the detached entity being merged</param>
    /// <param name="target">the value in the managed entity</param>
    /// <param name="owner">the managed entity</param>
    /// <returns>the value to be merged</returns>
    object IUserType.Replace(object original, object target, object owner)
    {
      int num = 3;
      string str;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_6;
          case 2:
            if (str != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 1 : 1;
              continue;
            }
            goto label_5;
          case 3:
            str = this.ToString(original);
            num = 2;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return (object) null;
label_6:
      return (object) new HtmlString(str);
    }

    /// <summary>
    /// Reconstruct an object from the cacheable representation. At the very least this
    ///             method should perform a deep copy if the type is mutable. (optional operation)
    /// </summary>
    /// <param name="cached">the object to be cached</param>
    /// <param name="owner">the owner of the cached object</param>
    /// <returns>
    /// a reconstructed object from the cachable representation
    /// </returns>
    object IUserType.Assemble(object cached, object owner)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            // ISSUE: type reference
            if (!HtmlStringType.xtMUAd82dLuNwIC1oRi(cached.GetType(), HtmlStringType.m8e5wK8O1ceMVOl4WSA(__typeref (string))))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          case 3:
            if (cached != null)
            {
              num = 2;
              continue;
            }
            goto label_2;
          case 4:
            goto label_2;
          case 5:
            goto label_10;
          default:
            // ISSUE: type reference
            if (HtmlStringType.xtMUAd82dLuNwIC1oRi(cached.GetType(), HtmlStringType.m8e5wK8O1ceMVOl4WSA(__typeref (HtmlString))))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 5 : 2;
              continue;
            }
            goto label_11;
        }
      }
label_2:
      return (object) null;
label_5:
      return (object) new HtmlString((string) cached);
label_10:
      return (object) (HtmlString) cached;
label_11:
      return (object) null;
    }

    /// <summary>
    /// Transform the object into its cacheable representation. At the very least this
    ///             method should perform a deep copy if the type is mutable. That may not be enough
    ///             for some implementations, however; for example, associations must be cached as
    ///             identifier values. (optional operation)
    /// </summary>
    /// <param name="value">the object to be cached</param>
    /// <returns>a cacheable representation of the object</returns>
    object IUserType.Disassemble(object value)
    {
      int num = 1;
      HtmlString htmlString;
      while (true)
      {
        switch (num)
        {
          case 1:
            htmlString = value as HtmlString;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_5;
          default:
            if (htmlString == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 2 : 1;
              continue;
            }
            goto label_6;
        }
      }
label_5:
      return (object) null;
label_6:
      return HtmlStringType.qQIyw48Ky6RkhrmYx2O((object) htmlString);
    }

    private string ToString(object val)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (val != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return val.ToString();
label_3:
      return (string) null;
    }

    private object FromStringValue(string xml)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (xml != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 0 : 1;
              continue;
            }
            goto label_4;
          default:
            goto label_4;
        }
      }
label_4:
      return (object) null;
label_5:
      return (object) new HtmlString(xml);
    }

    internal static void gHpxat8qgbR4EyZNJsQ() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool lD4j3O8ilxgMsMbomLQ() => HtmlStringType.pNHU7V8Su105iJacA4J == null;

    internal static HtmlStringType rv6oya8R19XuNeaHFMX() => HtmlStringType.pNHU7V8Su105iJacA4J;

    internal static object qQIyw48Ky6RkhrmYx2O([In] object obj0) => (object) ((HtmlString) obj0).ToHtmlString();

    internal static bool Lo66cr8X0TOiLwMKT05([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static object rAd3318TioZSAVmDQIE([In] object obj0) => (object) ((DbCommand) obj0).Parameters;

    internal static object f9V2OJ8kHPXYjviaIaK([In] object obj0, [In] int obj1) => (object) ((DbParameterCollection) obj0)[obj1];

    internal static void lQLt7Q8n53FEI45FKgF([In] object obj0, [In] object obj1) => ((IDataParameter) obj0).Value = obj1;

    internal static Type m8e5wK8O1ceMVOl4WSA([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool xtMUAd82dLuNwIC1oRi([In] Type obj0, [In] Type obj1) => obj0 == obj1;
  }
}
