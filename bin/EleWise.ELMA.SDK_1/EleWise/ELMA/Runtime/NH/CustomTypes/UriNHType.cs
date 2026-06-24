// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.CustomTypes.UriNHType
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Engine;
using NHibernate.SqlTypes;
using NHibernate.Type;
using NHibernate.UserTypes;
using System;
using System.Data;
using System.Data.Common;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.NH.CustomTypes
{
  /// <summary>
  /// Тип NHibernate для класса <see cref="T:System.Uri" />
  /// </summary>
  [Serializable]
  public class UriNHType : IUserType
  {
    private static UriNHType MXaQ6XWm9LVKskj7remg;

    /// <summary>
    /// Compare two instances of the class mapped by this type for persistent "equality"
    ///             ie. equality of persistent state
    /// </summary>
    /// <param name="x" />
    /// <param name="y" />
    /// <returns />
    public virtual bool Equals(object x, object y)
    {
      int num = 4;
      string str1;
      string str2;
      while (true)
      {
        Uri uri1;
        Uri uri2;
        object obj1;
        object obj2;
        switch (num)
        {
          case 1:
            goto label_15;
          case 2:
            obj1 = (object) null;
            goto label_28;
          case 3:
            uri2 = y as Uri;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 6 : 6;
            continue;
          case 4:
            uri1 = x as Uri;
            num = 3;
            continue;
          case 5:
            if (string.IsNullOrEmpty((string) UriNHType.t08Iv6Wm5Hmq8aONDTKe((object) uri2)))
            {
              num = 2;
              continue;
            }
            obj1 = UriNHType.t08Iv6Wm5Hmq8aONDTKe((object) uri2);
            goto label_28;
          case 6:
            if (UriNHType.CCJNZAWmryK8Sf2RBcPk((object) uri1, (object) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 10 : 4;
              continue;
            }
            goto case 7;
          case 7:
            obj2 = (object) null;
            break;
          case 8:
            if (UriNHType.CCJNZAWmryK8Sf2RBcPk((object) uri2, (object) null))
            {
              num = 5;
              continue;
            }
            goto case 2;
          case 9:
            goto label_16;
          case 10:
            if (UriNHType.XpTTO0WmguLsURMTEpMi((object) uri1.OriginalString))
            {
              num = 7;
              continue;
            }
            obj2 = UriNHType.t08Iv6Wm5Hmq8aONDTKe((object) uri1);
            break;
          case 11:
            goto label_7;
          case 12:
            if (str2 != null)
            {
              num = 9;
              continue;
            }
            goto label_15;
          case 13:
            if (str1 != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
              continue;
            }
            goto case 14;
          case 14:
            if (str2 == null)
            {
              num = 11;
              continue;
            }
            goto default;
          default:
            if (str1 != null)
            {
              num = 12;
              continue;
            }
            goto label_15;
        }
        str1 = (string) obj2;
        num = 8;
        continue;
label_28:
        str2 = (string) obj1;
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 0 : 13;
      }
label_7:
      return true;
label_15:
      return false;
label_16:
      return str1.Equals(str2);
    }

    /// <summary>
    /// Get a hashcode for the instance, consistent with persistence "equality"
    /// </summary>
    public virtual int GetHashCode(object x)
    {
      int num1 = 4;
      string str;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          Uri uri;
          object obj;
          switch (num2)
          {
            case 2:
              if (UriNHType.XpTTO0WmguLsURMTEpMi(UriNHType.t08Iv6Wm5Hmq8aONDTKe((object) uri)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 0 : 0;
                continue;
              }
              obj = UriNHType.t08Iv6Wm5Hmq8aONDTKe((object) uri);
              break;
            case 3:
              if (!UriNHType.CCJNZAWmryK8Sf2RBcPk((object) uri, (object) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 0 : 1;
                continue;
              }
              goto case 2;
            case 4:
              uri = x as Uri;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 3 : 3;
              continue;
            case 5:
              goto label_5;
            case 6:
              goto label_4;
            case 7:
              goto label_8;
            default:
              obj = (object) null;
              break;
          }
          str = (string) obj;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 2 : 7;
        }
label_8:
        if (str != null)
          num1 = 5;
        else
          break;
      }
label_4:
      // ISSUE: type reference
      return UriNHType.aRwOV8Wmj8PNsLDNE4Cp(__typeref (Uri)).GetHashCode() + 473;
label_5:
      return str.GetHashCode();
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
    public object NullSafeGet(
      DbDataReader rs,
      string[] names,
      ISessionImplementor session,
      object owner)
    {
      int num = 2;
      object obj;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (obj != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          case 2:
            obj = UriNHType.xcyskSWmYtvRbOCfAAVK((object) NHibernateUtil.String, (object) rs, (object) names[0], (object) session);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 0 : 1;
            continue;
          case 3:
            goto label_4;
          default:
            goto label_5;
        }
      }
label_4:
      return (object) null;
label_5:
      return (object) this.CreateUri(Convert.ToString(obj));
    }

    /// <summary>
    /// Write an instance of the mapped class to a prepared statement.
    ///             Implementors should handle possibility of null values.
    ///             A multi-column type should be written to parameters starting from index.
    /// </summary>
    /// <param name="cmd">a IDbCommand</param>
    /// <param name="value">the object to write</param>
    /// <param name="index">command parameter index</param>
    /// <exception cref="T:NHibernate.HibernateException">HibernateException</exception>
    public void NullSafeSet(DbCommand cmd, object value, int index, ISessionImplementor session)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            if ((object) (value as Uri) != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 8 : 5;
              continue;
            }
            goto default;
          case 2:
            if (value != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 1 : 1;
              continue;
            }
            goto default;
          case 3:
            UriNHType.o7fUpLWmsjs2X78xlkIA(UriNHType.ns933TWmUdEXIBP2P9yX(UriNHType.kTuS7sWmLARvOvQgppyQ((object) cmd), index), value);
            num = 7;
            continue;
          case 4:
            goto label_10;
          case 5:
            UriNHType.o7fUpLWmsjs2X78xlkIA(UriNHType.ns933TWmUdEXIBP2P9yX(UriNHType.kTuS7sWmLARvOvQgppyQ((object) cmd), index), (object) DBNull.Value);
            num = 4;
            continue;
          case 6:
            goto label_2;
          case 7:
            goto label_4;
          case 8:
            UriNHType.o7fUpLWmsjs2X78xlkIA((object) ((DbParameterCollection) UriNHType.kTuS7sWmLARvOvQgppyQ((object) cmd))[index], UriNHType.t08Iv6Wm5Hmq8aONDTKe((object) (Uri) value));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 6 : 3;
            continue;
          default:
            if (!(value is string))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 5 : 2;
              continue;
            }
            goto case 3;
        }
      }
label_10:
      return;
label_2:
      return;
label_4:;
    }

    /// <summary>
    /// Return a deep copy of the persistent state, stopping at entities and at collections.
    /// </summary>
    /// <param name="value">generally a collection element or entity field</param>
    /// <returns>a copy</returns>
    public virtual object DeepCopy(object value)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if ((object) (value as Uri) == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return (object) null;
label_3:
      return (object) this.CloneUri((Uri) value);
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
    public virtual object Replace(object original, object target, object owner)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if ((object) (original as Uri) != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          case 2:
            goto label_4;
          default:
            goto label_5;
        }
      }
label_4:
      return (object) null;
label_5:
      return (object) this.CloneUri((Uri) original);
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
    public virtual object Assemble(object cached, object owner)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if ((object) (cached as Uri) == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return (object) null;
label_3:
      return (object) this.CloneUri((Uri) cached);
    }

    /// <summary>
    /// Transform the object into its cacheable representation. At the very least this
    ///             method should perform a deep copy if the type is mutable. That may not be enough
    ///             for some implementations, however; for example, associations must be cached as
    ///             identifier values. (optional operation)
    /// </summary>
    /// <param name="value">the object to be cached</param>
    /// <returns>a cacheable representation of the object</returns>
    public virtual object Disassemble(object value)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if ((object) (value as Uri) == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 0;
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
      return (object) this.CloneUri((Uri) value);
    }

    /// <summary>The SQL types for the columns mapped by this type.</summary>
    public SqlType[] SqlTypes => new SqlType[1]
    {
      (SqlType) UriNHType.KvCJubWmcQPkThtEmH5T((object) NHibernateUtil.String)
    };

    /// <summary>
    /// The type returned by <c>NullSafeGet()</c>
    /// </summary>
    public System.Type ReturnedType => UriNHType.aRwOV8Wmj8PNsLDNE4Cp(__typeref (Uri));

    /// <summary>Are objects of this type mutable?</summary>
    public virtual bool IsMutable => true;

    private Uri CloneUri(Uri obj)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (UriNHType.CCJNZAWmryK8Sf2RBcPk((object) obj, (object) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 1;
              continue;
            }
            goto label_4;
          default:
            goto label_4;
        }
      }
label_4:
      return (Uri) null;
label_5:
      return this.CreateUri(obj.OriginalString, true);
    }

    private Uri CreateUri(string url, bool forceCreate = false)
    {
      int num = 3;
      string str;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_4;
          case 2:
            str = url;
            if (str == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 0 : 0;
              continue;
            }
            goto label_7;
          case 3:
            if (!UriNHType.XpTTO0WmguLsURMTEpMi((object) url) | forceCreate)
            {
              num = 2;
              continue;
            }
            goto label_4;
          default:
            goto label_8;
        }
      }
label_4:
      return (Uri) null;
label_8:
      string uriString = string.Empty;
label_9:
      return new Uri(uriString, UriKind.RelativeOrAbsolute);
label_7:
      uriString = str;
      goto label_9;
    }

    public UriNHType()
    {
      UriNHType.TjuCQVWmzNiIC9FjEQuj();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool CCJNZAWmryK8Sf2RBcPk([In] object obj0, [In] object obj1) => (Uri) obj0 != (Uri) obj1;

    internal static bool XpTTO0WmguLsURMTEpMi([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object t08Iv6Wm5Hmq8aONDTKe([In] object obj0) => (object) ((Uri) obj0).OriginalString;

    internal static bool uj6BkjWmdOi2sgLRauUD() => UriNHType.MXaQ6XWm9LVKskj7remg == null;

    internal static UriNHType ebN0YbWmln6bRJcS6fLT() => UriNHType.MXaQ6XWm9LVKskj7remg;

    internal static System.Type aRwOV8Wmj8PNsLDNE4Cp([In] RuntimeTypeHandle obj0) => System.Type.GetTypeFromHandle(obj0);

    internal static object xcyskSWmYtvRbOCfAAVK(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return ((NullableType) obj0).NullSafeGet((DbDataReader) obj1, (string) obj2, (ISessionImplementor) obj3);
    }

    internal static object kTuS7sWmLARvOvQgppyQ([In] object obj0) => (object) ((DbCommand) obj0).Parameters;

    internal static object ns933TWmUdEXIBP2P9yX([In] object obj0, [In] int obj1) => (object) ((DbParameterCollection) obj0)[obj1];

    internal static void o7fUpLWmsjs2X78xlkIA([In] object obj0, [In] object obj1) => ((IDataParameter) obj0).Value = obj1;

    internal static object KvCJubWmcQPkThtEmH5T([In] object obj0) => (object) ((NullableType) obj0).SqlType;

    internal static void TjuCQVWmzNiIC9FjEQuj() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    public class Convention : AutoRegisterUserTypeConvention<UriNHType>
    {
      private static UriNHType.Convention VPuepxQYMlWtlADQ0X4F;

      public Convention()
      {
        UriNHType.Convention.pNxq12QYdEkwNKqbRx0D();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static void pNxq12QYdEkwNKqbRx0D() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool iNaR0kQYJT4IBHlrXjfI() => UriNHType.Convention.VPuepxQYMlWtlADQ0X4F == null;

      internal static UriNHType.Convention NHcyCXQY9H9htIdWSjwv() => UriNHType.Convention.VPuepxQYMlWtlADQ0X4F;
    }
  }
}
