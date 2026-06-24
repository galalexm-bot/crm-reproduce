// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.CustomTypes.DropDownItemNHType
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Common;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Engine;
using NHibernate.SqlTypes;
using NHibernate.Type;
using NHibernate.UserTypes;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Data;
using System.Data.Common;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.NH.CustomTypes
{
  /// <summary>
  /// Тип NHibernate для класса <see cref="T:EleWise.ELMA.Model.Common.DropDownItem" />
  /// </summary>
  [Serializable]
  public class DropDownItemNHType : AbstractStringType, IUserType
  {
    private static DropDownItemNHType mCMWL8WyFPWayUFpPvCJ;

    /// <summary>Конструктор</summary>
    public DropDownItemNHType()
    {
      DropDownItemNHType.CX4BiQWyokwIUeFexohO();
      // ISSUE: explicit constructor call
      base.\u002Ector((SqlType) new StringSqlType());
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal DropDownItemNHType(StringSqlType sqlType)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector((SqlType) sqlType);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public override System.Type ReturnedClass => DropDownItemNHType.XYu32gWybdc6kUAdtb5n(__typeref (DropDownItem));

    public override string Name => (string) DropDownItemNHType.c1CNinWyhYLQ3TeMGQEi(-1824388195 ^ -1824512109);

    public override void Set(DbCommand cmd, object value, int index, ISessionImplementor session)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            DropDownItemNHType.HVd8SHWyfLqDjUqcE49Y(DropDownItemNHType.aj2Z75WyEvUOjLfxD8Lx(DropDownItemNHType.d6YWLSWyGdwAcuiqRbJg((object) cmd), index), (object) this.ToString(value));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public override object Get(DbDataReader rs, int index, ISessionImplementor session) => (object) new DropDownItem((string) DropDownItemNHType.dW1yH4WyQwtGbQFlp4Ue(rs[index]));

    public override object Get(DbDataReader rs, string name, ISessionImplementor session) => (object) new DropDownItem(Convert.ToString(rs[name]));

    public override string ToString(object val)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (val != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return val.ToString();
label_5:
      return (string) null;
    }

    public override object FromStringValue(string xml) => (object) new DropDownItem(xml);

    /// <summary>
    /// Compare two instances of the class mapped by this type for persistent "equality"
    ///             ie. equality of persistent state
    /// </summary>
    /// <param name="x" />
    /// <param name="y" />
    /// <returns />
    bool IUserType.Equals(object x, object y) => DropDownItemNHType.ROFjMbWyCxhMbny3vVjU((object) this, x, y);

    /// <summary>
    /// Get a hashcode for the instance, consistent with persistence "equality"
    /// </summary>
    int IUserType.GetHashCode(object x)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (x == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return 0;
label_3:
      return x.GetHashCode();
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
      return (object) new DropDownItem((string) DropDownItemNHType.yjmgj9WyvLlSBvNZDV3Q((object) this, (object) rs, (object) names, (object) session));
    }

    /// <summary>
    /// Return a deep copy of the persistent state, stopping at entities and at collections.
    /// </summary>
    /// <param name="value">generally a collection element or entity field</param>
    /// <returns>a copy</returns>
    object IUserType.DeepCopy(object value) => value;

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
    object IUserType.Replace(object original, object target, object owner) => original;

    /// <summary>
    /// Reconstruct an object from the cacheable representation. At the very least this
    ///             method should perform a deep copy if the type is mutable. (optional operation)
    /// </summary>
    /// <param name="cached">the object to be cached</param>
    /// <param name="owner">the owner of the cached object</param>
    /// <returns>
    /// a reconstructed object from the cachable representation
    /// </returns>
    object IUserType.Assemble(object cached, object owner) => cached;

    /// <summary>
    /// Transform the object into its cacheable representation. At the very least this
    ///             method should perform a deep copy if the type is mutable. That may not be enough
    ///             for some implementations, however; for example, associations must be cached as
    ///             identifier values. (optional operation)
    /// </summary>
    /// <param name="value">the object to be cached</param>
    /// <returns>a cacheable representation of the object</returns>
    object IUserType.Disassemble(object value) => value;

    /// <summary>The SQL types for the columns mapped by this type.</summary>
    SqlType[] IUserType.SqlTypes => new SqlType[1]
    {
      (SqlType) DropDownItemNHType.e2Zmp0Wy8LVksvJwF72r((object) this)
    };

    /// <summary>
    /// The type returned by <c>NullSafeGet()</c>
    /// </summary>
    System.Type IUserType.ReturnedType => DropDownItemNHType.dr87SmWyZYrEkEcWaOem((object) this);

    internal static void CX4BiQWyokwIUeFexohO() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool QVRO4iWyB9BnWgc0CHvX() => DropDownItemNHType.mCMWL8WyFPWayUFpPvCJ == null;

    internal static DropDownItemNHType EOGuX9WyWf6aPiysqROk() => DropDownItemNHType.mCMWL8WyFPWayUFpPvCJ;

    internal static System.Type XYu32gWybdc6kUAdtb5n([In] RuntimeTypeHandle obj0) => System.Type.GetTypeFromHandle(obj0);

    internal static object c1CNinWyhYLQ3TeMGQEi(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object d6YWLSWyGdwAcuiqRbJg([In] object obj0) => (object) ((DbCommand) obj0).Parameters;

    internal static object aj2Z75WyEvUOjLfxD8Lx([In] object obj0, [In] int obj1) => (object) ((DbParameterCollection) obj0)[obj1];

    internal static void HVd8SHWyfLqDjUqcE49Y([In] object obj0, [In] object obj1) => ((IDataParameter) obj0).Value = obj1;

    internal static object dW1yH4WyQwtGbQFlp4Ue([In] object obj0) => (object) Convert.ToString(obj0);

    internal static bool ROFjMbWyCxhMbny3vVjU([In] object obj0, [In] object obj1, [In] object obj2) => ((AbstractType) obj0).IsEqual(obj1, obj2);

    internal static object yjmgj9WyvLlSBvNZDV3Q(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return ((NullableType) obj0).NullSafeGet((DbDataReader) obj1, (string[]) obj2, (ISessionImplementor) obj3);
    }

    internal static object e2Zmp0Wy8LVksvJwF72r([In] object obj0) => (object) ((NullableType) obj0).SqlType;

    internal static System.Type dr87SmWyZYrEkEcWaOem([In] object obj0) => ((AbstractType) obj0).ReturnedClass;
  }
}
