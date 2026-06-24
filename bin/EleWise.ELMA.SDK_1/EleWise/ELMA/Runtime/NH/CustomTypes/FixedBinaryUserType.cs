// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.CustomTypes.FixedBinaryUserType
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.Db;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Engine;
using NHibernate.SqlTypes;
using NHibernate.UserTypes;
using System;
using System.Data;
using System.Data.Common;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.NH.CustomTypes
{
  /// <summary>Тип данных для типа "Бинарные данные"</summary>
  [Serializable]
  public class FixedBinaryUserType : IUserType
  {
    private readonly SqlType[] sqlTypes;
    internal static FixedBinaryUserType XIuN8oWmiBoBudb80q83;

    bool IUserType.Equals(object x, object y)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (y == null)
            {
              num = 4;
              continue;
            }
            goto label_3;
          case 2:
            goto label_8;
          case 3:
            if (x == y)
            {
              num = 2;
              continue;
            }
            if (x == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 0 : 0;
              continue;
            }
            goto case 1;
          default:
            goto label_2;
        }
      }
label_2:
      return false;
label_3:
      return FixedBinaryUserType.SCnguVWmKc8HwjutKTds((object) (byte[]) x, (object) (byte[]) y);
label_8:
      return true;
    }

    public int GetHashCode(object x)
    {
      int num = 9;
      int hashCode;
      while (true)
      {
        int index;
        byte[] numArray1;
        byte[] numArray2;
        switch (num)
        {
          case 1:
            index = 0;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 2 : 1;
            continue;
          case 3:
            hashCode = 1;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 1 : 1;
            continue;
          case 4:
            hashCode = 31 * hashCode + (int) numArray1[index];
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 7 : 4;
            continue;
          case 5:
            goto label_9;
          case 6:
            numArray2 = Array.Empty<byte>();
            break;
          case 7:
            ++index;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
            continue;
          case 8:
            numArray2 = (byte[]) x;
            break;
          case 9:
            if (x != null)
            {
              num = 8;
              continue;
            }
            goto case 6;
          default:
            if (index >= numArray1.Length)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 5 : 3;
              continue;
            }
            goto case 4;
        }
        numArray1 = numArray2;
        num = 3;
      }
label_9:
      return hashCode;
    }

    /// <inheritdoc />
    public object NullSafeGet(
      DbDataReader rs,
      string[] names,
      ISessionImplementor session,
      object owner)
    {
      object obj;
      switch (1)
      {
        case 1:
          try
          {
            int ordinal = rs.GetOrdinal(names[0]);
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
              num = 0;
            while (true)
            {
              switch (num)
              {
                case 1:
                case 4:
                  obj = (object) rs.GetBytes(ordinal);
                  num = 2;
                  continue;
                case 2:
                case 5:
                  goto label_1;
                case 3:
                  obj = (object) null;
                  num = 5;
                  continue;
                default:
                  if (!(rs[ordinal] is DBNull))
                  {
                    num = 4;
                    continue;
                  }
                  goto case 3;
              }
            }
          }
          catch (Exception ex)
          {
            int num = 2;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
              num = 0;
            while (true)
            {
              switch (num)
              {
                case 1:
                  obj = (object) null;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 0 : 0;
                  continue;
                case 2:
                  FixedBinaryUserType.WHHAqYWmk0FVhjVeTY2C(FixedBinaryUserType.BHLQqEWmXvFccW2IxNvA(), FixedBinaryUserType.TadIJbWmT9r5X1y06SyJ((object) ex), (object) ex);
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 1 : 1;
                  continue;
                default:
                  goto label_1;
              }
            }
          }
      }
label_1:
      return obj;
    }

    /// <inheritdoc />
    public void NullSafeSet(DbCommand cmd, object value, int index, ISessionImplementor session)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_4;
          case 1:
            object obj1 = FixedBinaryUserType.FGBcSdWmOmG08YHKk0Ul(FixedBinaryUserType.us41E8WmnwObbPGSvxsp((object) cmd), index);
            object obj2 = value;
            object obj3 = obj2 == null ? (object) DBNull.Value : obj2;
            FixedBinaryUserType.UjJFteWm2kZF5oUvbMXm(obj1, obj3);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_4:
      return;
label_2:;
    }

    public object DeepCopy(object value)
    {
      int num = 3;
      byte[] numArray1;
      byte[] numArray2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            numArray2 = (byte[]) value;
            num = 5;
            continue;
          case 3:
            if (value != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 2 : 1;
              continue;
            }
            goto label_4;
          case 4:
            FixedBinaryUserType.z5OBm8WmevDtQKILPJtD((object) numArray2, 0, (object) numArray1, 0, numArray2.Length);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 1 : 0;
            continue;
          case 5:
            numArray1 = new byte[numArray2.Length];
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 4 : 2;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return (object) numArray1;
label_4:
      return (object) null;
    }

    public object Replace(object original, object target, object owner)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (FixedBinaryUserType.oMDCADWmP4VVssvJVPRL((object) this, original, target))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return original;
label_3:
      return this.DeepCopy(original);
    }

    public object Assemble(object cached, object owner) => cached;

    public object Disassemble(object value) => value;

    public SqlType[] SqlTypes => this.sqlTypes;

    public Type ReturnedType => FixedBinaryUserType.dhYv78Wm1DvClax4X1Zy(__typeref (byte[]));

    public bool IsMutable => true;

    public FixedBinaryUserType()
    {
      FixedBinaryUserType.ELhTg7WmNXXYjQs7Hau2();
      this.sqlTypes = new SqlType[1]
      {
        new SqlType(DbType.Binary, int.MaxValue)
      };
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool SCnguVWmKc8HwjutKTds([In] object obj0, [In] object obj1) => CollectionExtensions.ByteArrayCompare((byte[]) obj0, (byte[]) obj1);

    internal static bool tDGItHWmRlhaKTkKxYct() => FixedBinaryUserType.XIuN8oWmiBoBudb80q83 == null;

    internal static FixedBinaryUserType gD1Y4RWmqh84EXbS3QiJ() => FixedBinaryUserType.XIuN8oWmiBoBudb80q83;

    internal static object BHLQqEWmXvFccW2IxNvA() => (object) Logger.Log;

    internal static object TadIJbWmT9r5X1y06SyJ([In] object obj0) => (object) ((Exception) obj0).Message;

    internal static void WHHAqYWmk0FVhjVeTY2C([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Error(obj1, (Exception) obj2);

    internal static object us41E8WmnwObbPGSvxsp([In] object obj0) => (object) ((DbCommand) obj0).Parameters;

    internal static object FGBcSdWmOmG08YHKk0Ul([In] object obj0, [In] int obj1) => (object) ((DbParameterCollection) obj0)[obj1];

    internal static void UjJFteWm2kZF5oUvbMXm([In] object obj0, [In] object obj1) => ((IDataParameter) obj0).Value = obj1;

    internal static void z5OBm8WmevDtQKILPJtD(
      [In] object obj0,
      [In] int obj1,
      [In] object obj2,
      [In] int obj3,
      [In] int obj4)
    {
      Array.Copy((Array) obj0, obj1, (Array) obj2, obj3, obj4);
    }

    internal static bool oMDCADWmP4VVssvJVPRL([In] object obj0, [In] object obj1, [In] object obj2) => ((IUserType) obj0).Equals(obj1, obj2);

    internal static Type dhYv78Wm1DvClax4X1Zy([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static void ELhTg7WmNXXYjQs7Hau2() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
