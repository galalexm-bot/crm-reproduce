// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.CustomTypes.MoneyNHType
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Common.Models;
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
  /// Тип NHibernate для класса <see cref="T:EleWise.ELMA.Common.Models.Money" />
  /// </summary>
  [Serializable]
  public class MoneyNHType : IUserType
  {
    internal static MoneyNHType ayqxjcW0csXBWaAUMQvh;

    /// <summary>
    /// Compare two instances of the class mapped by this type for persistent "equality"
    ///             ie. equality of persistent state
    /// </summary>
    /// <param name="x" />
    /// <param name="y" />
    /// <returns />
    public virtual bool Equals(object x, object y)
    {
      int num1 = 2;
      Money money;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (y != null)
              {
                num2 = 7;
                continue;
              }
              goto label_10;
            case 2:
              if (x == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 1;
                continue;
              }
              goto case 7;
            case 3:
              money = (Money) x;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 5;
              continue;
            case 4:
            case 6:
              goto label_4;
            case 5:
              goto label_3;
            case 7:
              if (x is Money)
                break;
              goto label_12;
            case 8:
              goto label_10;
          }
          if (y is Money)
            num2 = 3;
          else
            goto label_4;
        }
label_12:
        num1 = 4;
      }
label_3:
      return money.CompareTo(y) == 0;
label_4:
      return false;
label_10:
      return true;
    }

    /// <summary>
    /// Get a hashcode for the instance, consistent with persistence "equality"
    /// </summary>
    public virtual int GetHashCode(object x)
    {
      int num1 = 3;
      Money money;
      double num2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_8;
          case 2:
            money = (Money) x;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 0 : 0;
            continue;
          case 3:
            if (x is Money)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 2 : 0;
              continue;
            }
            goto label_2;
          case 4:
            goto label_2;
          case 5:
            num2 = money.Value;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 1 : 0;
            continue;
          default:
            if (money.HasValue)
            {
              money = (Money) x;
              num1 = 5;
              continue;
            }
            num1 = 4;
            continue;
        }
      }
label_2:
      // ISSUE: type reference
      return MoneyNHType.Hi5hjLWmBuccUWo3oHWT(__typeref (Money)).GetHashCode() + 473;
label_8:
      return num2.GetHashCode();
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
      int num = 3;
      object obj;
      Money money;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (obj != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 0 : 0;
              continue;
            }
            goto label_7;
          case 2:
            money = new Money();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 1 : 1;
            continue;
          case 3:
            obj = MoneyNHType.mASA6tWmW2jjPGmn8XXs((object) NHibernateUtil.Double, (object) rs, (object) names[0], (object) session);
            num = 2;
            continue;
          case 4:
            goto label_7;
          default:
            money.Value = Convert.ToDouble(obj);
            num = 4;
            continue;
        }
      }
label_7:
      return (object) money;
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
      int num = 3;
      Money money;
      while (true)
      {
        switch (num)
        {
          case 1:
            money = (Money) value;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 0;
            continue;
          case 2:
          case 6:
            MoneyNHType.VsmlhkWmhwDxRLpQ7Qpc(MoneyNHType.apKQqCWmbHtmk2AoK6Mh(MoneyNHType.F6PO9dWmomtkbOZSCdE7((object) cmd), index), (object) DBNull.Value);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 5 : 1;
            continue;
          case 3:
            if (value == null)
            {
              num = 2;
              continue;
            }
            goto case 4;
          case 4:
            if (value is Money)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 1 : 1;
              continue;
            }
            goto case 2;
          case 5:
            goto label_2;
          case 7:
            goto label_11;
          default:
            if (!money.HasValue)
            {
              num = 6;
              continue;
            }
            object obj = MoneyNHType.apKQqCWmbHtmk2AoK6Mh(MoneyNHType.F6PO9dWmomtkbOZSCdE7((object) cmd), index);
            money = (Money) value;
            // ISSUE: variable of a boxed type
            __Boxed<double> local = (System.ValueType) money.Value;
            MoneyNHType.VsmlhkWmhwDxRLpQ7Qpc(obj, (object) local);
            num = 7;
            continue;
        }
      }
label_2:
      return;
label_11:;
    }

    /// <summary>
    /// Return a deep copy of the persistent state, stopping at entities and at collections.
    /// </summary>
    /// <param name="value">generally a collection element or entity field</param>
    /// <returns>a copy</returns>
    public virtual object DeepCopy(object value) => value;

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
    public virtual object Replace(object original, object target, object owner) => original;

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
    public virtual object Disassemble(object value) => value;

    /// <summary>The SQL types for the columns mapped by this type.</summary>
    public SqlType[] SqlTypes => new SqlType[1]
    {
      (SqlType) MoneyNHType.WyYP9IWmG9IshyVkFoFL((object) NHibernateUtil.Double)
    };

    /// <summary>
    /// The type returned by <c>NullSafeGet()</c>
    /// </summary>
    public System.Type ReturnedType => MoneyNHType.Hi5hjLWmBuccUWo3oHWT(__typeref (Money));

    /// <summary>Are objects of this type mutable?</summary>
    public virtual bool IsMutable => false;

    public MoneyNHType()
    {
      MoneyNHType.j4trsiWmEkiI8FJGVUsC();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool DmtGyEW0zprKFIlPNbjE() => MoneyNHType.ayqxjcW0csXBWaAUMQvh == null;

    internal static MoneyNHType wym8BfWmF6L0xollA0Nn() => MoneyNHType.ayqxjcW0csXBWaAUMQvh;

    internal static System.Type Hi5hjLWmBuccUWo3oHWT([In] RuntimeTypeHandle obj0) => System.Type.GetTypeFromHandle(obj0);

    internal static object mASA6tWmW2jjPGmn8XXs(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return ((NullableType) obj0).NullSafeGet((DbDataReader) obj1, (string) obj2, (ISessionImplementor) obj3);
    }

    internal static object F6PO9dWmomtkbOZSCdE7([In] object obj0) => (object) ((DbCommand) obj0).Parameters;

    internal static object apKQqCWmbHtmk2AoK6Mh([In] object obj0, [In] int obj1) => (object) ((DbParameterCollection) obj0)[obj1];

    internal static void VsmlhkWmhwDxRLpQ7Qpc([In] object obj0, [In] object obj1) => ((IDataParameter) obj0).Value = obj1;

    internal static object WyYP9IWmG9IshyVkFoFL([In] object obj0) => (object) ((NullableType) obj0).SqlType;

    internal static void j4trsiWmEkiI8FJGVUsC() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    public class Convention : AutoRegisterUserTypeConvention<MoneyNHType>
    {
      internal static MoneyNHType.Convention iNNOXfQY23F7aaNEYaVf;

      public Convention()
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool wPgwe5QYeZ5jth0N6PbT() => MoneyNHType.Convention.iNNOXfQY23F7aaNEYaVf == null;

      internal static MoneyNHType.Convention x3ubw9QYPMBMJr0nSXiX() => MoneyNHType.Convention.iNNOXfQY23F7aaNEYaVf;
    }
  }
}
