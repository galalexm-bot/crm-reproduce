// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.CustomTypes.WorkTimeNHType
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Common.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Engine;
using NHibernate.SqlTypes;
using NHibernate.UserTypes;
using System;
using System.Data;
using System.Data.Common;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.NH.CustomTypes
{
  /// <summary>
  /// Тип NHibernate для класса <see cref="T:EleWise.ELMA.Common.Models.WorkTime" />
  /// </summary>
  [Serializable]
  public class WorkTimeNHType : IUserType
  {
    internal static WorkTimeNHType MXyNOuW0JGW6iZ95nUFe;

    /// <summary>
    /// Compare two instances of the class mapped by this type for persistent "equality"
    ///             ie. equality of persistent state
    /// </summary>
    /// <param name="x" />
    /// <param name="y" />
    /// <returns />
    public virtual bool Equals(object x, object y)
    {
      int num = 7;
      WorkTime workTime1;
      WorkTime workTime2;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 3:
            goto label_16;
          case 2:
            goto label_6;
          case 4:
            if (y != null)
            {
              num = 9;
              continue;
            }
            goto label_6;
          case 5:
            workTime1 = (WorkTime) x;
            num = 12;
            continue;
          case 6:
          case 9:
            if (x is WorkTime)
            {
              num = 11;
              continue;
            }
            goto label_2;
          case 7:
            if (x != null)
            {
              num = 6;
              continue;
            }
            goto case 4;
          case 8:
            if (workTime1.HasValue)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 3 : 2;
              continue;
            }
            break;
          case 10:
            goto label_2;
          case 11:
            if (y is WorkTime)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 5 : 5;
              continue;
            }
            goto label_2;
          case 12:
            workTime2 = (WorkTime) y;
            num = 8;
            continue;
        }
        if (workTime2.HasValue)
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 1 : 0;
        else
          goto label_17;
      }
label_2:
      return false;
label_6:
      return true;
label_16:
      return workTime1.Value == workTime2.Value;
label_17:
      return true;
    }

    /// <summary>
    /// Get a hashcode for the instance, consistent with persistence "equality"
    /// </summary>
    public virtual int GetHashCode(object x)
    {
      int num1 = 1;
      WorkTime workTime;
      long num2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (x is WorkTime)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          case 2:
            goto label_10;
          case 3:
            num2 = workTime.Value;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 2 : 2;
            continue;
          case 4:
            goto label_3;
          case 5:
            workTime = (WorkTime) x;
            num1 = 3;
            continue;
          case 6:
            if (workTime.HasValue)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 5 : 5;
              continue;
            }
            goto label_3;
          default:
            workTime = (WorkTime) x;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 6 : 5;
            continue;
        }
      }
label_3:
      return typeof (WorkTime).GetHashCode() + 473;
label_10:
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
      int num = 4;
      WorkTime workTime;
      object obj;
      while (true)
      {
        switch (num)
        {
          case 1:
            workTime.Value = WorkTimeNHType.h5BVqkW0lmPOhfkP9QOW(obj);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 0 : 0;
            continue;
          case 2:
            if (obj != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 1;
              continue;
            }
            goto label_2;
          case 3:
            workTime = new WorkTime();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 1 : 2;
            continue;
          case 4:
            obj = NHibernateUtil.Double.NullSafeGet(rs, names[0], session);
            num = 3;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return (object) workTime;
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
      WorkTime workTime;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (value is WorkTime)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 4 : 1;
              continue;
            }
            goto case 2;
          case 2:
          case 7:
            WorkTimeNHType.BJvYFoW05uvCHglUrqQT(WorkTimeNHType.tIbcYDW0giQshWZBolEi(WorkTimeNHType.ycPAWfW0rx5iQRRbjjbq((object) cmd), index), (object) DBNull.Value);
            num = 6;
            continue;
          case 3:
            if (value == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 2 : 2;
              continue;
            }
            goto case 1;
          case 4:
            workTime = (WorkTime) value;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 0 : 0;
            continue;
          case 5:
            goto label_6;
          case 6:
            goto label_4;
          default:
            if (!workTime.HasValue)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 1 : 7;
              continue;
            }
            DbParameter parameter = cmd.Parameters[index];
            workTime = (WorkTime) value;
            // ISSUE: variable of a boxed type
            __Boxed<long> local = (System.ValueType) workTime.Value;
            WorkTimeNHType.BJvYFoW05uvCHglUrqQT((object) parameter, (object) local);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 5 : 2;
            continue;
        }
      }
label_6:
      return;
label_4:;
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
      NHibernateUtil.Int64.SqlType
    };

    /// <summary>
    /// The type returned by <c>NullSafeGet()</c>
    /// </summary>
    public Type ReturnedType => WorkTimeNHType.UsAFaHW0j5bWDALthCYB(__typeref (WorkTime));

    /// <summary>Are objects of this type mutable?</summary>
    public virtual bool IsMutable => false;

    public WorkTimeNHType()
    {
      WorkTimeNHType.kPfJ1pW0Yy2LBfDHkJh2();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool rTAKXLW09Qq96YCL483d() => WorkTimeNHType.MXyNOuW0JGW6iZ95nUFe == null;

    internal static WorkTimeNHType dnXniBW0dHcgSpmC90yX() => WorkTimeNHType.MXyNOuW0JGW6iZ95nUFe;

    internal static long h5BVqkW0lmPOhfkP9QOW([In] object obj0) => Convert.ToInt64(obj0);

    internal static object ycPAWfW0rx5iQRRbjjbq([In] object obj0) => (object) ((DbCommand) obj0).Parameters;

    internal static object tIbcYDW0giQshWZBolEi([In] object obj0, [In] int obj1) => (object) ((DbParameterCollection) obj0)[obj1];

    internal static void BJvYFoW05uvCHglUrqQT([In] object obj0, [In] object obj1) => ((IDataParameter) obj0).Value = obj1;

    internal static Type UsAFaHW0j5bWDALthCYB([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static void kPfJ1pW0Yy2LBfDHkJh2() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    public class Convention : AutoRegisterUserTypeConvention<WorkTimeNHType>
    {
      internal static WorkTimeNHType.Convention cxAdJEQYk6qW8xlym30A;

      public Convention()
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool I8Z6UlQYn6yb7H1y5EX7() => WorkTimeNHType.Convention.cxAdJEQYk6qW8xlym30A == null;

      internal static WorkTimeNHType.Convention U1s9qwQYO5u604aOPsuk() => WorkTimeNHType.Convention.cxAdJEQYk6qW8xlym30A;
    }
  }
}
