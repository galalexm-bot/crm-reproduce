// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.CustomTypes.ExceptionScriptNHType
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Serialization;
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

namespace EleWise.ELMA.Runtime.NH.CustomTypes
{
  /// <summary>
  /// Тип NHibernate для класса <see cref="T:EleWise.ELMA.Common.Models.WorkTime" />
  /// </summary>
  [Serializable]
  public class ExceptionScriptNHType : IUserType
  {
    private readonly SqlType[] sqlTypes;
    private static ExceptionScriptNHType nO9tC7W0XbHOG7wZrWmi;

    /// <summary>
    /// Compare two instances of the class mapped by this type for persistent "equality"
    ///             ie. equality of persistent state
    /// </summary>
    /// <param name="x" />
    /// <param name="y" />
    /// <returns />
    public virtual bool Equals(object x, object y)
    {
      int num1 = 5;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (!(y is ExceptionData))
              {
                num2 = 2;
                continue;
              }
              goto label_9;
            case 2:
            case 6:
              goto label_8;
            case 3:
              if (y != null)
              {
                num2 = 7;
                continue;
              }
              goto label_5;
            case 4:
            case 7:
              if (x is ExceptionData)
                goto case 1;
              else
                goto label_7;
            case 5:
              if (x != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 4 : 0;
                continue;
              }
              goto case 3;
            default:
              goto label_5;
          }
        }
label_7:
        num1 = 6;
      }
label_5:
      return true;
label_8:
      return false;
label_9:
      ExceptionData exceptionData1 = (ExceptionData) x;
      ExceptionData exceptionData2 = (ExceptionData) y;
      return ExceptionScriptNHType.eflvWyW0n4ZUfpacr9jx((object) exceptionData1.ToString(), (object) exceptionData2.ToString());
    }

    /// <summary>
    /// Get a hashcode for the instance, consistent with persistence "equality"
    /// </summary>
    public virtual int GetHashCode(object x) => ExceptionScriptNHType.XJnDvsW0OEn0wQotbmYD(__typeref (ExceptionData)).GetHashCode() + 473;

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
      int num1 = 3;
      ExceptionData exceptionData;
      ExceptionHolder exceptionHolder;
      while (true)
      {
        int num2 = num1;
        object bytes;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (exceptionHolder != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 8 : 0;
                continue;
              }
              goto label_24;
            case 2:
              if (bytes == null)
              {
                num2 = 5;
                continue;
              }
              goto case 4;
            case 3:
              bytes = ExceptionScriptNHType.KZX4tKW02FMPGG6VYLFY((object) NHibernateUtil.Binary, (object) rs, (object) names[0], (object) session);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 1 : 2;
              continue;
            case 4:
              exceptionData = new ExceptionData();
              num2 = 7;
              continue;
            case 5:
              goto label_25;
            case 6:
              goto label_24;
            case 7:
              exceptionHolder = ClassSerializationHelper.DeserializeObjectByXml<ExceptionHolder>(bytes as byte[]);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 1 : 1;
              continue;
            case 8:
              goto label_31;
            case 9:
              exceptionData.ExceptionCode = ExceptionScriptNHType.z7pBWxW0PJpTENd4NuDF((object) exceptionHolder);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
              continue;
            default:
              goto label_5;
          }
        }
label_31:
        exceptionData.Message = (string) ExceptionScriptNHType.FEFmmZW0eb2pej8FdOrt((object) exceptionHolder);
        num1 = 9;
      }
label_5:
      try
      {
        object obj = ExceptionScriptNHType.rqEe90W01o7peTiw1Nv8((object) exceptionHolder.ExcetionData);
        int num3 = 6;
        while (true)
        {
          switch (num3)
          {
            case 1:
            case 2:
            case 9:
              goto label_24;
            case 3:
              if (obj is ScriptExecuteException)
              {
                num3 = 7;
                continue;
              }
              goto case 4;
            case 4:
              if (obj is Exception)
              {
                num3 = 8;
                continue;
              }
              goto case 5;
            case 5:
              ExceptionScriptNHType.pLZac4W0Nrx7iuOKhtPQ((object) exceptionData, (object) new Exception((string) ExceptionScriptNHType.JHqIKKW03j92LY7ofIeW((object) exceptionData)));
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 1 : 0;
              continue;
            case 6:
              if (obj == null)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 0 : 0;
                continue;
              }
              goto case 3;
            case 7:
              exceptionData.OriginalException = (Exception) (obj as ScriptExecuteException);
              num3 = 9;
              continue;
            case 8:
              ExceptionScriptNHType.pLZac4W0Nrx7iuOKhtPQ((object) exceptionData, (object) (obj as Exception));
              num3 = 2;
              continue;
            default:
              if (obj is ExceptionHolder)
              {
                num3 = 3;
                continue;
              }
              goto label_24;
          }
        }
      }
      catch (Exception ex)
      {
        int num4 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
          num4 = 0;
        while (true)
        {
          switch (num4)
          {
            case 1:
              ExceptionScriptNHType.fNkxSPW0DAnAiKmh9bL1(ExceptionScriptNHType.iQvA4rW0pU4BUWUb95Ab(), ExceptionScriptNHType.njnyTCW0axdU2Oe2QgC7((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-688192331 - 435440695 ^ -1123773908)), (object) ex);
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 0;
              continue;
            default:
              goto label_24;
          }
        }
      }
label_24:
      return (object) exceptionData;
label_25:
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
      int num1 = 4;
      while (true)
      {
        int num2 = num1;
        ExceptionHolder exceptionHolder;
        ExceptionData exceptionData;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_17;
            case 1:
              exceptionHolder = new ExceptionHolder();
              num2 = 6;
              continue;
            case 2:
              ExceptionScriptNHType.FGWsKtW0wQyiBNZZfncg(ExceptionScriptNHType.KGPEKZW0tIHdZGqNB8nh((object) cmd.Parameters, index), (object) DBNull.Value);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 0 : 0;
              continue;
            case 3:
              if (!(value is ExceptionData))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 2 : 2;
                continue;
              }
              exceptionData = (ExceptionData) value;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 1 : 1;
              continue;
            case 4:
              if (value != null)
              {
                num2 = 3;
                continue;
              }
              goto case 2;
            case 5:
              goto label_3;
            case 6:
              ExceptionScriptNHType.GwM19gW06yHKVFN7PtuQ((object) exceptionHolder, ExceptionScriptNHType.zCaInNW041mmb0b3poI2((object) exceptionData));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 7 : 9;
              continue;
            case 7:
              goto label_9;
            case 8:
              goto label_20;
            case 9:
              exceptionHolder.Message = (string) ExceptionScriptNHType.JHqIKKW03j92LY7ofIeW((object) exceptionData);
              num2 = 7;
              continue;
            default:
              goto label_15;
          }
        }
label_3:
        ((IDataParameter) ExceptionScriptNHType.KGPEKZW0tIHdZGqNB8nh(ExceptionScriptNHType.v8NjYZW07OSO6IxswuDy((object) cmd), index)).Value = (object) ClassSerializationHelper.SerializeObjectByXmlToBytes((object) exceptionHolder);
        num1 = 8;
        continue;
label_9:
        try
        {
          exceptionHolder.ExcetionData = (byte[]) ExceptionScriptNHType.UlrooFW0HFfBywCDy9XU((object) exceptionData.OriginalException);
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
            num3 = 0;
          switch (num3)
          {
            default:
              goto label_3;
          }
        }
        catch (Exception ex)
        {
          int num4 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0)
            num4 = 0;
          while (true)
          {
            switch (num4)
            {
              case 1:
                goto label_3;
              default:
                ((ILogger) ExceptionScriptNHType.iQvA4rW0pU4BUWUb95Ab()).Warn(ExceptionScriptNHType.njnyTCW0axdU2Oe2QgC7(ExceptionScriptNHType.fpwu60W0AmUTmPrABqYY(901793403 ^ 901934305)), ex);
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 1 : 1;
                continue;
            }
          }
        }
      }
label_17:
      return;
label_20:
      return;
label_15:;
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
    public SqlType[] SqlTypes => this.sqlTypes;

    /// <summary>
    /// The type returned by <c>NullSafeGet()</c>
    /// </summary>
    public System.Type ReturnedType => ExceptionScriptNHType.XJnDvsW0OEn0wQotbmYD(__typeref (ExceptionData));

    /// <summary>Are objects of this type mutable?</summary>
    public virtual bool IsMutable => false;

    public ExceptionScriptNHType()
    {
      ExceptionScriptNHType.r1dcwvW0xYvnSF6e0avM();
      this.sqlTypes = new SqlType[1]
      {
        new SqlType(DbType.Binary, int.MaxValue)
      };
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool eflvWyW0n4ZUfpacr9jx([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static bool BCMu7LW0TkYDtQBQHFBB() => ExceptionScriptNHType.nO9tC7W0XbHOG7wZrWmi == null;

    internal static ExceptionScriptNHType tBmVV5W0kqir39Mwr6sU() => ExceptionScriptNHType.nO9tC7W0XbHOG7wZrWmi;

    internal static System.Type XJnDvsW0OEn0wQotbmYD([In] RuntimeTypeHandle obj0) => System.Type.GetTypeFromHandle(obj0);

    internal static object KZX4tKW02FMPGG6VYLFY(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return ((NullableType) obj0).NullSafeGet((DbDataReader) obj1, (string) obj2, (ISessionImplementor) obj3);
    }

    internal static object FEFmmZW0eb2pej8FdOrt([In] object obj0) => (object) ((ExceptionHolder) obj0).Message;

    internal static int z7pBWxW0PJpTENd4NuDF([In] object obj0) => ((ExceptionHolder) obj0).Code;

    internal static object rqEe90W01o7peTiw1Nv8([In] object obj0) => ClassSerializationHelper.DeserializeObject((byte[]) obj0);

    internal static void pLZac4W0Nrx7iuOKhtPQ([In] object obj0, [In] object obj1) => ((ExceptionData) obj0).OriginalException = (Exception) obj1;

    internal static object JHqIKKW03j92LY7ofIeW([In] object obj0) => (object) ((ExceptionData) obj0).Message;

    internal static object iQvA4rW0pU4BUWUb95Ab() => (object) Logger.Log;

    internal static object njnyTCW0axdU2Oe2QgC7([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static void fNkxSPW0DAnAiKmh9bL1([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Warn(obj1, (Exception) obj2);

    internal static object KGPEKZW0tIHdZGqNB8nh([In] object obj0, [In] int obj1) => (object) ((DbParameterCollection) obj0)[obj1];

    internal static void FGWsKtW0wQyiBNZZfncg([In] object obj0, [In] object obj1) => ((IDataParameter) obj0).Value = obj1;

    internal static int zCaInNW041mmb0b3poI2([In] object obj0) => ((ExceptionData) obj0).ExceptionCode;

    internal static void GwM19gW06yHKVFN7PtuQ([In] object obj0, int value) => ((ExceptionHolder) obj0).Code = value;

    internal static object UlrooFW0HFfBywCDy9XU([In] object obj0) => (object) ClassSerializationHelper.SerializeObject(obj0);

    internal static object fpwu60W0AmUTmPrABqYY(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object v8NjYZW07OSO6IxswuDy([In] object obj0) => (object) ((DbCommand) obj0).Parameters;

    internal static void r1dcwvW0xYvnSF6e0avM() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    public class Convention : AutoRegisterUserTypeConvention<ExceptionScriptNHType>
    {
      internal static ExceptionScriptNHType.Convention xtVH0eQYKqeYbK9DDC1T;

      public Convention()
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool sO67EVQYXP1f6iMeoZo7() => ExceptionScriptNHType.Convention.xtVH0eQYKqeYbK9DDC1T == null;

      internal static ExceptionScriptNHType.Convention opZygiQYT81hXffh34ob() => ExceptionScriptNHType.Convention.xtVH0eQYKqeYbK9DDC1T;
    }
  }
}
