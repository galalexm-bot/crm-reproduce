// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.CustomTypes.DateTimeNHType
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
  /// Тип NHibernate для DateTime.
  /// В случае default значения даты в бд уходит null
  /// </summary>
  [Serializable]
  public class DateTimeNHType : IUserType
  {
    private static DateTimeNHType UyPlMxW0QdtRwHtxEUaG;

    /// <summary>
    /// Compare two instances of the class mapped by this type for persistent "equality"
    ///             ie. equality of persistent state
    /// </summary>
    /// <param name="x" />
    /// <param name="y" />
    /// <returns />
    public bool Equals(object x, object y) => DateTimeNHType.M5RFiKW08EpWCKNHuPmE((object) NHibernateUtil.DateTime, x, y);

    /// <summary>
    /// Get a hashcode for the instance, consistent with persistence "equality"
    /// </summary>
    public int GetHashCode(object x) => DateTimeNHType.GUiw18W0ZjKFE9FW6uYi((object) NHibernateUtil.DateTime, x);

    /// <summary>
    /// Retrieve an instance of the mapped class from a JDBC resultset.
    ///             Implementors should handle possibility of null values.
    /// </summary>
    /// <param name="rs">a IDataReader</param>
    /// <param name="names">column names</param>
    /// <param name="owner">the containing entity</param>
    /// <returns />
    /// <exception cref="T:NHibernate.HibernateException">HibernateException</exception>
    public virtual object NullSafeGet(
      DbDataReader rs,
      string[] names,
      ISessionImplementor session,
      object owner)
    {
      int num = 2;
      DateTime? nullable;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (nullable.HasValue)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          case 2:
            nullable = DateTimeNHType.KWAPB6W0uJy12Rd1Kwxf((object) NHibernateUtil.DateTime, (object) rs, (object) names[0], (object) session) as DateTime?;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 0 : 1;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return (object) DateTimeNHType.DXgiYeW0IHagdQpoxCQZ(nullable.Value);
label_3:
      return DateTimeNHType.KWAPB6W0uJy12Rd1Kwxf((object) NHibernateUtil.DateTime, (object) rs, (object) names[0], (object) session);
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
    public virtual void NullSafeSet(
      DbCommand cmd,
      object value,
      int index,
      ISessionImplementor session)
    {
      int num = 1;
      DateTime runtimeDateTime;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (value == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 0 : 0;
              continue;
            }
            runtimeDateTime = (DateTime) value;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 2;
            continue;
          case 2:
            DateTimeNHType.xxXQgyW0iuYomA9BV56F(DateTimeNHType.LFDXNkW0SY9yoHqwINfg((object) cmd.Parameters, index), !(runtimeDateTime != new DateTime()) ? (object) DBNull.Value : (object) runtimeDateTime.ToServerDateTime());
            num = 4;
            continue;
          case 3:
            goto label_4;
          case 4:
            goto label_8;
          default:
            DateTimeNHType.xxXQgyW0iuYomA9BV56F(DateTimeNHType.LFDXNkW0SY9yoHqwINfg(DateTimeNHType.XvGqgCW0VNwaUmtlcQee((object) cmd), index), (object) DBNull.Value);
            num = 3;
            continue;
        }
      }
label_4:
      return;
label_8:;
    }

    /// <summary>
    /// Return a deep copy of the persistent state, stopping at entities and at collections.
    /// </summary>
    /// <param name="value">generally a collection element or entity field</param>
    /// <returns>a copy</returns>
    public object DeepCopy(object value) => value;

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
    public object Replace(object original, object target, object owner) => original;

    /// <summary>
    /// Reconstruct an object from the cacheable representation. At the very least this
    ///             method should perform a deep copy if the type is mutable. (optional operation)
    /// </summary>
    /// <param name="cached">the object to be cached</param>
    /// <param name="owner">the owner of the cached object</param>
    /// <returns>
    /// a reconstructed object from the cachable representation
    /// </returns>
    public virtual object Assemble(object cached, object owner) => cached;

    /// <summary>
    /// Transform the object into its cacheable representation. At the very least this
    ///             method should perform a deep copy if the type is mutable. That may not be enough
    ///             for some implementations, however; for example, associations must be cached as
    ///             identifier values. (optional operation)
    /// </summary>
    /// <param name="value">the object to be cached</param>
    /// <returns>a cacheable representation of the object</returns>
    public object Disassemble(object value) => value;

    /// <summary>The SQL types for the columns mapped by this type.</summary>
    public SqlType[] SqlTypes => new SqlType[1]
    {
      (SqlType) DateTimeNHType.ywulcoW0RCuFbML4PCda((object) NHibernateUtil.DateTime)
    };

    /// <summary>
    /// The type returned by <c>NullSafeGet()</c>
    /// </summary>
    public System.Type ReturnedType => DateTimeNHType.vIvoHkW0qvDKUg4WBGo1(__typeref (DateTime));

    /// <summary>Are objects of this type mutable?</summary>
    public bool IsMutable => false;

    public DateTimeNHType()
    {
      DateTimeNHType.J9WxScW0K3H3lBqXncCo();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool M5RFiKW08EpWCKNHuPmE([In] object obj0, [In] object obj1, [In] object obj2) => ((AbstractType) obj0).IsEqual(obj1, obj2);

    internal static bool rSDk1VW0CynC6BQ9qHXr() => DateTimeNHType.UyPlMxW0QdtRwHtxEUaG == null;

    internal static DateTimeNHType rnt704W0vZoUQs5HFccN() => DateTimeNHType.UyPlMxW0QdtRwHtxEUaG;

    internal static int GUiw18W0ZjKFE9FW6uYi([In] object obj0, [In] object obj1) => ((AbstractType) obj0).GetHashCode(obj1);

    internal static object KWAPB6W0uJy12Rd1Kwxf(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return ((NullableType) obj0).NullSafeGet((DbDataReader) obj1, (string) obj2, (ISessionImplementor) obj3);
    }

    internal static DateTime DXgiYeW0IHagdQpoxCQZ(DateTime serverDateTime) => serverDateTime.ToRuntimeDateTimeFromServer();

    internal static object XvGqgCW0VNwaUmtlcQee([In] object obj0) => (object) ((DbCommand) obj0).Parameters;

    internal static object LFDXNkW0SY9yoHqwINfg([In] object obj0, [In] int obj1) => (object) ((DbParameterCollection) obj0)[obj1];

    internal static void xxXQgyW0iuYomA9BV56F([In] object obj0, [In] object obj1) => ((IDataParameter) obj0).Value = obj1;

    internal static object ywulcoW0RCuFbML4PCda([In] object obj0) => (object) ((NullableType) obj0).SqlType;

    internal static System.Type vIvoHkW0qvDKUg4WBGo1([In] RuntimeTypeHandle obj0) => System.Type.GetTypeFromHandle(obj0);

    internal static void J9WxScW0K3H3lBqXncCo() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    public class Convention : AutoRegisterUserTypeConvention<DateTimeNHType>
    {
      internal static DateTimeNHType.Convention f1U2PJQYSOgHMW6QMCK3;

      public Convention()
      {
        DateTimeNHType.Convention.g7sSMBQYqTxAZiPuBoqr();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static void g7sSMBQYqTxAZiPuBoqr() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool aX5YY4QYi36se9hJoUGv() => DateTimeNHType.Convention.f1U2PJQYSOgHMW6QMCK3 == null;

      internal static DateTimeNHType.Convention NQ5FE5QYRCccfEcEsXCq() => DateTimeNHType.Convention.f1U2PJQYSOgHMW6QMCK3;
    }
  }
}
