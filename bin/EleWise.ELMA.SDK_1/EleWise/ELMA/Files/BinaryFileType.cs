// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Files.BinaryFileType
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Runtime.Managers;
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

namespace EleWise.ELMA.Files
{
  /// <summary>Пользовательский тип для файла</summary>
  [Serializable]
  public class BinaryFileType : IUserType
  {
    private static BinaryFileType VB4TXGGT4VoPr2l3ea3d;

    /// <summary>
    /// Compare two instances of the class mapped by this type for persistent "equality"
    ///             ie. equality of persistent state
    /// </summary>
    /// <param name="x" />
    /// <param name="y" />
    /// <returns />
    bool IUserType.Equals(object x, object y)
    {
      int num1 = 1;
      BinaryFile binaryFile1;
      BinaryFile binaryFile2;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              binaryFile1 = x as BinaryFile;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 0 : 0;
              continue;
            case 2:
              if (binaryFile2 != null)
              {
                num2 = 5;
                continue;
              }
              goto label_14;
            case 3:
              if (binaryFile1 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 6 : 4;
                continue;
              }
              goto case 4;
            case 4:
              if (binaryFile1 != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 1 : 2;
                continue;
              }
              goto label_14;
            case 5:
              goto label_3;
            case 6:
              if (binaryFile2 != null)
              {
                num2 = 4;
                continue;
              }
              goto label_15;
            case 7:
              goto label_12;
            default:
              binaryFile2 = y as BinaryFile;
              num2 = 3;
              continue;
          }
        }
label_3:
        if (binaryFile1 != binaryFile2)
          num1 = 7;
        else
          goto label_13;
      }
label_12:
      return binaryFile1.Equals((object) binaryFile2);
label_13:
      return true;
label_14:
      return false;
label_15:
      return true;
    }

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
            if (x != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 0 : 0;
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
      return BinaryFileType.zBqQVoGTA5IaYxC232Me(__typeref (BinaryFile)).GetHashCode() + 473;
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
      string str;
      while (true)
      {
        switch (num)
        {
          case 1:
            str = (string) BinaryFileType.xPc0n8GT7sWmiIj8VhTp((object) NHibernateUtil.String, (object) rs, (object) names[0], (object) session);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_5;
          default:
            if (!BinaryFileType.G0WYmQGTx0pnYfBI1b5T((object) str))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 2 : 1;
              continue;
            }
            goto label_6;
        }
      }
label_5:
      return BinaryFileType.dh2EETGTmRUXqcoecNQb(BinaryFileType.GtvmZUGT0Cl6mu75Zqvf(), (object) str);
label_6:
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
    void IUserType.NullSafeSet(
      DbCommand cmd,
      object value,
      int index,
      ISessionImplementor session)
    {
      int num1 = 6;
      while (true)
      {
        int num2 = num1;
        BinaryFile binaryFile;
        string str;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 9:
              BinaryFileType.FYpp7rGTJwJc9EoJ69oN((object) ((DbParameterCollection) BinaryFileType.egOTJHGTyvfRc8LpAJ3l((object) cmd))[index], (object) str);
              num2 = 2;
              continue;
            case 2:
              goto label_3;
            case 3:
              goto label_5;
            case 4:
              str = ((IFileManager) BinaryFileType.GtvmZUGT0Cl6mu75Zqvf()).SaveFile(binaryFile);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 1 : 1;
              continue;
            case 5:
              binaryFile = (BinaryFile) value;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 0 : 0;
              continue;
            case 6:
              if (value != null)
              {
                num2 = 5;
                continue;
              }
              goto label_13;
            case 7:
              if (!BinaryFileType.G0WYmQGTx0pnYfBI1b5T((object) str))
              {
                num2 = 9;
                continue;
              }
              goto case 4;
            case 8:
              goto label_13;
            default:
              str = (string) BinaryFileType.iL8RrqGT97aVJBcm739J((object) binaryFile);
              num2 = 7;
              continue;
          }
        }
label_13:
        BinaryFileType.FYpp7rGTJwJc9EoJ69oN(BinaryFileType.QDiVsdGTMTSQk1UiWKi7(BinaryFileType.egOTJHGTyvfRc8LpAJ3l((object) cmd), index), (object) DBNull.Value);
        num1 = 3;
      }
label_3:
      return;
label_5:;
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
      (SqlType) BinaryFileType.oX01wqGTlBXbBc3IbUPg(BinaryFileType.LtYY3kGTds7YeBhZmkxn(250))
    };

    /// <summary>
    /// The type returned by <c>NullSafeGet()</c>
    /// </summary>
    System.Type IUserType.ReturnedType => BinaryFileType.zBqQVoGTA5IaYxC232Me(__typeref (BinaryFile));

    /// <summary>Are objects of this type mutable?</summary>
    bool IUserType.IsMutable => true;

    public BinaryFileType()
    {
      BinaryFileType.ueJeHGGTr3XugLOgpZqu();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool nYnR92GT6OnS1rcdIGko() => BinaryFileType.VB4TXGGT4VoPr2l3ea3d == null;

    internal static BinaryFileType FmNhkSGTHrivSbUFuDHh() => BinaryFileType.VB4TXGGT4VoPr2l3ea3d;

    internal static System.Type zBqQVoGTA5IaYxC232Me([In] RuntimeTypeHandle obj0) => System.Type.GetTypeFromHandle(obj0);

    internal static object xPc0n8GT7sWmiIj8VhTp(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return ((NullableType) obj0).NullSafeGet((DbDataReader) obj1, (string) obj2, (ISessionImplementor) obj3);
    }

    internal static bool G0WYmQGTx0pnYfBI1b5T([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object GtvmZUGT0Cl6mu75Zqvf() => (object) DataAccessManager.FileManager;

    internal static object dh2EETGTmRUXqcoecNQb([In] object obj0, [In] object obj1) => (object) ((IFileManager) obj0).LoadFile((string) obj1);

    internal static object egOTJHGTyvfRc8LpAJ3l([In] object obj0) => (object) ((DbCommand) obj0).Parameters;

    internal static object QDiVsdGTMTSQk1UiWKi7([In] object obj0, [In] int obj1) => (object) ((DbParameterCollection) obj0)[obj1];

    internal static void FYpp7rGTJwJc9EoJ69oN([In] object obj0, [In] object obj1) => ((IDataParameter) obj0).Value = obj1;

    internal static object iL8RrqGT97aVJBcm739J([In] object obj0) => (object) ((BinaryFile) obj0).Id;

    internal static object LtYY3kGTds7YeBhZmkxn([In] int obj0) => (object) TypeFactory.GetStringType(obj0);

    internal static object oX01wqGTlBXbBc3IbUPg([In] object obj0) => (object) ((NullableType) obj0).SqlType;

    internal static void ueJeHGGTr3XugLOgpZqu() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
