// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.CustomTypes.EnumNHType`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Enums;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Engine;
using NHibernate.SqlTypes;
using NHibernate.UserTypes;
using System;
using System.Data.Common;

namespace EleWise.ELMA.Runtime.NH.CustomTypes
{
  /// <summary>Тип NHibernate для наследуемых перечислений</summary>
  /// <typeparam name="TEnum">Тип перечисления</typeparam>
  [Serializable]
  public class EnumNHType<TEnum> : IUserType where TEnum : EnumBase
  {
    private static object k79walW0LjNnUpX2rd8L;

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
      TEnum enum1;
      TEnum enum2;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!((EnumBase) enum2 == (EnumBase) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 7 : 5;
              continue;
            }
            goto case 10;
          case 2:
            if (!((EnumBase) enum1 == (EnumBase) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
              continue;
            }
            goto label_6;
          case 3:
            enum1 = y as TEnum;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 1 : 1;
            continue;
          case 4:
            enum2 = x as TEnum;
            num = 3;
            continue;
          case 5:
            goto label_10;
          case 6:
          case 8:
            goto label_6;
          case 7:
          case 9:
            if ((EnumBase) enum2 == (EnumBase) null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 8 : 8;
              continue;
            }
            goto case 2;
          case 10:
            if (!((EnumBase) enum1 == (EnumBase) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 6 : 9;
              continue;
            }
            goto label_10;
          default:
            goto label_7;
        }
      }
label_6:
      return false;
label_7:
      return enum2.Equals((object) enum1);
label_10:
      return true;
    }

    /// <summary>
    /// Get a hashcode for the instance, consistent with persistence "equality"
    /// </summary>
    public virtual int GetHashCode(object x)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (x != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 2:
            goto label_2;
          default:
            goto label_3;
        }
      }
label_2:
      return typeof (TEnum).GetHashCode() + 473;
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
    public object NullSafeGet(
      DbDataReader rs,
      string[] names,
      ISessionImplementor session,
      object owner)
    {
      int num = 2;
      Guid uid;
      object obj;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (obj != null)
            {
              num = 4;
              continue;
            }
            goto label_4;
          case 2:
            obj = NHibernateUtil.Guid.NullSafeGet(rs, names[0], session);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 1 : 0;
            continue;
          case 3:
            goto label_4;
          case 4:
            uid = (Guid) obj;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return ModelHelper.GetEnumValue(typeof (TEnum), uid);
label_4:
      return (object) null;
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
            if (!(value is Guid))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 0;
              continue;
            }
            goto case 4;
          case 2:
            if (value == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 1 : 0;
              continue;
            }
            goto case 8;
          case 3:
            goto label_2;
          case 4:
            cmd.Parameters[index].Value = (object) (Guid) value;
            num = 3;
            continue;
          case 5:
            cmd.Parameters[index].Value = (object) ((TEnum) value).Value;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 6 : 7;
            continue;
          case 6:
            goto label_7;
          case 7:
            goto label_13;
          case 8:
            if (value is TEnum)
            {
              num = 5;
              continue;
            }
            goto case 1;
          default:
            cmd.Parameters[index].Value = (object) DBNull.Value;
            num = 6;
            continue;
        }
      }
label_2:
      return;
label_7:
      return;
label_13:;
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
      NHibernateUtil.Guid.SqlType
    };

    /// <summary>
    /// The type returned by <c>NullSafeGet()</c>
    /// </summary>
    public Type ReturnedType => typeof (TEnum);

    /// <summary>Are objects of this type mutable?</summary>
    public virtual bool IsMutable => false;

    public EnumNHType()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool EGkeQhW0U5GvoPNscvGi() => EnumNHType<TEnum>.k79walW0LjNnUpX2rd8L == null;

    internal static object n6HgUsW0skaM6XgERID3() => EnumNHType<TEnum>.k79walW0LjNnUpX2rd8L;
  }
}
