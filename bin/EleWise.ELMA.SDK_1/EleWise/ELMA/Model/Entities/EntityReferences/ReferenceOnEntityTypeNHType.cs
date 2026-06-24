// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Entities.EntityReferences.ReferenceOnEntityTypeNHType
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
using SG9KiyIbtdgGDf12qr;
using System;
using System.Data;
using System.Data.Common;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Entities.EntityReferences
{
  /// <summary>Ссылка на тип объекта</summary>
  [Serializable]
  public class ReferenceOnEntityTypeNHType : IUserType
  {
    internal static ReferenceOnEntityTypeNHType TIhQF7hVVtPSHchC3epB;

    /// <summary>
    /// Compare two instances of the class mapped by this type for persistent "equality"
    ///             ie. equality of persistent state
    /// </summary>
    /// <param name="x" />
    /// <param name="y" />
    /// <returns />
    public bool Equals(object x, object y)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (x == y)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 0 : 0;
              continue;
            }
            if (x != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 3 : 3;
              continue;
            }
            goto label_4;
          case 2:
            goto label_4;
          case 3:
            if (y == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 2 : 2;
              continue;
            }
            goto label_5;
          default:
            goto label_8;
        }
      }
label_4:
      return false;
label_5:
      return x.Equals(y);
label_8:
      return true;
    }

    /// <summary>
    /// Get a hashcode for the instance, consistent with persistence "equality"
    /// </summary>
    public int GetHashCode(object x)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (x == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 0;
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
      return x.GetHashCode();
label_3:
      // ISSUE: type reference
      return ReferenceOnEntityTypeNHType.Sn3HeIhVR1lqcfbrLWug(__typeref (ReferenceOnEntityType)).GetHashCode() + 473;
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
            if (obj == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 2:
            obj = ReferenceOnEntityTypeNHType.Cui7DVhVqydfV94fSwJm((object) NHibernateUtil.Guid, (object) rs, (object) names[0], (object) session);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_2;
          default:
            goto label_3;
        }
      }
label_2:
      return (object) new ReferenceOnEntityType()
      {
        TypeUid = (Guid) obj
      };
label_3:
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
      int num1 = 2;
      while (true)
      {
        int num2 = num1;
        ReferenceOnEntityType referenceOnEntityType;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_3;
            case 1:
              goto label_4;
            case 2:
              if (value == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 1 : 0;
                continue;
              }
              referenceOnEntityType = (ReferenceOnEntityType) value;
              num2 = 3;
              continue;
            case 3:
              ReferenceOnEntityTypeNHType.mU3CpRhVkGg9ytERHQNq(ReferenceOnEntityTypeNHType.byM2vRhVKsVDkJHkTGmJ(ReferenceOnEntityTypeNHType.iCidWLhVXUY5NSfZYpge((object) cmd), index), (object) ReferenceOnEntityTypeNHType.DDB9JOhVTTVgCCAPN09x((object) referenceOnEntityType));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 0 : 0;
              continue;
            case 4:
              goto label_7;
            default:
              goto label_10;
          }
        }
label_4:
        ((IDataParameter) ReferenceOnEntityTypeNHType.byM2vRhVKsVDkJHkTGmJ((object) cmd.Parameters, index)).Value = (object) DBNull.Value;
        num1 = 4;
      }
label_3:
      return;
label_7:
      return;
label_10:;
    }

    /// <summary>
    /// Return a deep copy of the persistent state, stopping at entities and at collections.
    /// </summary>
    /// <param name="value">generally a collection element or entity field</param>
    /// <returns>a copy</returns>
    public object DeepCopy(object value)
    {
      int num = 2;
      ReferenceOnEntityType referenceOnEntityType;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (value == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 1 : 0;
              continue;
            }
            referenceOnEntityType = (ReferenceOnEntityType) ReferenceOnEntityTypeNHType.hwZKvyhVnNARqTgiHYEV(value);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return (object) new ReferenceOnEntityType()
      {
        TypeUid = ReferenceOnEntityTypeNHType.DDB9JOhVTTVgCCAPN09x((object) referenceOnEntityType)
      };
label_5:
      return (object) null;
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
    public object Replace(object original, object target, object owner) => this.DeepCopy(original);

    /// <summary>
    /// Reconstruct an object from the cacheable representation. At the very least this
    ///             method should perform a deep copy if the type is mutable. (optional operation)
    /// </summary>
    /// <param name="cached">the object to be cached</param>
    /// <param name="owner">the owner of the cached object</param>
    /// <returns>
    /// a reconstructed object from the cachable representation
    /// </returns>
    public object Assemble(object cached, object owner) => this.DeepCopy(cached);

    /// <summary>
    /// Transform the object into its cacheable representation. At the very least this
    ///             method should perform a deep copy if the type is mutable. That may not be enough
    ///             for some implementations, however; for example, associations must be cached as
    ///             identifier values. (optional operation)
    /// </summary>
    /// <param name="value">the object to be cached</param>
    /// <returns>a cacheable representation of the object</returns>
    public object Disassemble(object value) => this.DeepCopy(value);

    /// <summary>The SQL types for the columns mapped by this type.</summary>
    public SqlType[] SqlTypes => new SqlType[1]
    {
      (SqlType) ReferenceOnEntityTypeNHType.CPF77ghVOeiANVc9WGv5((object) NHibernateUtil.Guid)
    };

    /// <summary>
    /// The type returned by <c>NullSafeGet()</c>
    /// </summary>
    public System.Type ReturnedType => ReferenceOnEntityTypeNHType.Sn3HeIhVR1lqcfbrLWug(__typeref (ReferenceOnEntityType));

    /// <summary>Are objects of this type mutable?</summary>
    public bool IsMutable => true;

    private static ReferenceOnEntityType AsReferenceOnEntityType(object value)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (value == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return (ReferenceOnEntityType) null;
label_5:
      return value is ReferenceOnEntityType referenceOnEntityType ? referenceOnEntityType : throw new InvalidCastException((string) ReferenceOnEntityTypeNHType.xJ80YZhVecvExTN3LDKO(ReferenceOnEntityTypeNHType.Hv100nhV20f6BHLbiHdM(516838154 ^ 516717300), (object) typeof (ReferenceOnEntityType), (object) value.GetType()));
    }

    public ReferenceOnEntityTypeNHType()
    {
      ReferenceOnEntityTypeNHType.Tb0eiohVPvnkrO2EncaH();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool ijddjShVS9prXwuDadYk() => ReferenceOnEntityTypeNHType.TIhQF7hVVtPSHchC3epB == null;

    internal static ReferenceOnEntityTypeNHType fatmkjhVioECiZA3Q4p4() => ReferenceOnEntityTypeNHType.TIhQF7hVVtPSHchC3epB;

    internal static System.Type Sn3HeIhVR1lqcfbrLWug([In] RuntimeTypeHandle obj0) => System.Type.GetTypeFromHandle(obj0);

    internal static object Cui7DVhVqydfV94fSwJm(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return ((NullableType) obj0).NullSafeGet((DbDataReader) obj1, (string) obj2, (ISessionImplementor) obj3);
    }

    internal static object byM2vRhVKsVDkJHkTGmJ([In] object obj0, [In] int obj1) => (object) ((DbParameterCollection) obj0)[obj1];

    internal static object iCidWLhVXUY5NSfZYpge([In] object obj0) => (object) ((DbCommand) obj0).Parameters;

    internal static Guid DDB9JOhVTTVgCCAPN09x([In] object obj0) => ((ReferenceOnEntityType) obj0).TypeUid;

    internal static void mU3CpRhVkGg9ytERHQNq([In] object obj0, [In] object obj1) => ((IDataParameter) obj0).Value = obj1;

    internal static object hwZKvyhVnNARqTgiHYEV([In] object obj0) => (object) ReferenceOnEntityTypeNHType.AsReferenceOnEntityType(obj0);

    internal static object CPF77ghVOeiANVc9WGv5([In] object obj0) => (object) ((NullableType) obj0).SqlType;

    internal static object Hv100nhV20f6BHLbiHdM(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object xJ80YZhVecvExTN3LDKO([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static void Tb0eiohVPvnkrO2EncaH() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
