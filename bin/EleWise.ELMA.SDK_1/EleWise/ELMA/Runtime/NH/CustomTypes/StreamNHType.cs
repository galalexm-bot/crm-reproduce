// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.CustomTypes.StreamNHType
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Logging;
using EleWise.ELMA.Memory;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Engine;
using NHibernate.SqlTypes;
using NHibernate.UserTypes;
using System;
using System.Data;
using System.Data.Common;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.NH.CustomTypes
{
  /// <summary>Базовый тип данных для типа "Поток"</summary>
  public abstract class StreamNHType : IUserType
  {
    private static readonly SqlType[] sqlTypes;
    internal static StreamNHType s17mbJWxCwFTvYNq16VD;

    /// <inheritdoc />
    public SqlType[] SqlTypes { get; }

    /// <inheritdoc />
    public Type ReturnedType { get; }

    /// <inheritdoc />
    public bool IsMutable { get; }

    /// <inheritdoc />
    public virtual object NullSafeGet(
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
            int num1 = StreamNHType.JGE7DbWxZaGuWpY1qsGC((object) rs, (object) names[0]);
            int num2 = 10;
            while (true)
            {
              int num3;
              int minimumBufferLength;
              switch (num2)
              {
                case 1:
                case 5:
                case 6:
                  goto label_1;
                case 2:
                case 4:
                  obj = (object) MemoryHelper.ActionWithMemoryBuffer<byte, (DbDataReader, int), MemoryStream>(minimumBufferLength, (rs, num1), new MemoryHelper.ActionWithMemoryBufferAndParameterDelegate<byte, (DbDataReader, int), MemoryStream>(this.NullSafeGetInternal));
                  num2 = 6;
                  continue;
                case 3:
                  obj = (object) null;
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 5 : 1;
                  continue;
                case 7:
                case 9:
                  minimumBufferLength = (int) StreamNHType.lPROMmWxIKxKDTHRMnmR((object) rs, num1, 0L, (object) null, 0, 0);
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
                  continue;
                case 8:
                  obj = (object) null;
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 1;
                  continue;
                case 10:
                  if (!(StreamNHType.T4fX45WxuMMyLfOw3aXh((object) rs, num1) is DBNull))
                  {
                    num3 = 7;
                    break;
                  }
                  goto case 8;
                default:
                  if (minimumBufferLength != 0)
                  {
                    num3 = 4;
                    break;
                  }
                  goto case 3;
              }
              num2 = num3;
            }
          }
          catch (Exception ex)
          {
            int num = 2;
            while (true)
            {
              switch (num)
              {
                case 1:
                  obj = (object) null;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
                  continue;
                case 2:
                  StreamNHType.AF0DiDWxiHT3JOD3UqiN(StreamNHType.rki4YKWxVgeNrI6JL8hP(), StreamNHType.zvEZg2WxSWi2V1OFynYr((object) ex), (object) ex);
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 1 : 1;
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
    public virtual void NullSafeSet(
      DbCommand cmd,
      object value,
      int index,
      ISessionImplementor session)
    {
      int num = 1;
      MemoryStream memoryStream;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (value == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 0 : 0;
              continue;
            }
            memoryStream = (MemoryStream) value;
            num = 5;
            continue;
          case 2:
            goto label_10;
          case 3:
            StreamNHType.cOw1LpWxK3awmI70daOp(StreamNHType.MfcRftWxqyuQYBZ3McGL((object) cmd.Parameters, index), (object) memoryStream);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 2 : 2;
            continue;
          case 4:
            StreamNHType.cOw1LpWxK3awmI70daOp(StreamNHType.MfcRftWxqyuQYBZ3McGL(StreamNHType.F68iFeWxRvkE6PZZCZnX((object) cmd), index), (object) DBNull.Value);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 8 : 3;
            continue;
          case 5:
            if (memoryStream.Length != 0L)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 5 : 6;
              continue;
            }
            goto case 4;
          case 6:
            StreamNHType.rQIp36WxXExtnxaWQNLI((object) memoryStream, 0L, SeekOrigin.Begin);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 3;
            continue;
          case 7:
            goto label_8;
          case 8:
            goto label_12;
          default:
            StreamNHType.cOw1LpWxK3awmI70daOp(StreamNHType.MfcRftWxqyuQYBZ3McGL(StreamNHType.F68iFeWxRvkE6PZZCZnX((object) cmd), index), (object) DBNull.Value);
            num = 7;
            continue;
        }
      }
label_10:
      return;
label_8:
      return;
label_12:;
    }

    /// <inheritdoc />
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      MemoryStream memoryStream = MemoryHelper.GetMemoryStream(Array.Empty<byte>(), false);
      goto label_6;
label_5:
      memoryStream = (MemoryStream) x;
label_6:
      return memoryStream.GetContentHashCode();
    }

    /// <inheritdoc />
    public object DeepCopy(object value)
    {
      int num = 3;
      MemoryStream memoryStream1;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_4;
          case 2:
            MemoryStream memoryStream2 = (MemoryStream) value;
            memoryStream1 = (MemoryStream) StreamNHType.NCu6UjWxTQdH42xV6ym9();
            StreamNHType.rQIp36WxXExtnxaWQNLI((object) memoryStream2, 0L, SeekOrigin.Begin);
            StreamNHType.OEPQnAWxkcKPmuqpTkSJ((object) memoryStream2, (object) memoryStream1);
            StreamNHType.rQIp36WxXExtnxaWQNLI((object) memoryStream1, 0L, SeekOrigin.Begin);
            StreamNHType.rQIp36WxXExtnxaWQNLI((object) memoryStream2, 0L, SeekOrigin.Begin);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 0 : 0;
            continue;
          case 3:
            if (value != null)
            {
              num = 2;
              continue;
            }
            goto label_4;
          default:
            goto label_6;
        }
      }
label_4:
      return (object) null;
label_6:
      return (object) memoryStream1;
    }

    /// <inheritdoc />
    public object Replace(object original, object target, object owner)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (((IUserType) this).Equals(original, target))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 0 : 0;
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
      return this.DeepCopy(original);
label_5:
      return original;
    }

    /// <inheritdoc />
    public object Assemble(object cached, object owner) => cached;

    /// <inheritdoc />
    public object Disassemble(object value) => value;

    private MemoryStream NullSafeGetInternal(
      byte[] buffer,
      int offset,
      int length,
      (DbDataReader, int) param)
    {
      (DbDataReader dbDataReader, int ordinal) = param;
      MemoryStream memoryStream = MemoryHelper.GetMemoryStream(length);
      try
      {
        dbDataReader.GetBytes(ordinal, 0L, buffer, offset, length);
        memoryStream.Write(buffer, offset, length);
        memoryStream.Seek(0L, SeekOrigin.Begin);
        return memoryStream;
      }
      catch
      {
        memoryStream?.Dispose();
        throw;
      }
    }

    /// <inheritdoc />
    bool IUserType.Equals(object x, object y)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (y != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 0 : 0;
              continue;
            }
            goto label_9;
          case 2:
            goto label_6;
          case 3:
            if (x == y)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 2 : 2;
              continue;
            }
            if (x != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 0 : 1;
              continue;
            }
            goto label_9;
          case 4:
            goto label_9;
          default:
            goto label_10;
        }
      }
label_6:
      return true;
label_9:
      return false;
label_10:
      return StreamNHType.sagVZuWxnTeoOp4phLyv((object) (MemoryStream) x, (object) (MemoryStream) y);
    }

    protected StreamNHType()
    {
      StreamNHType.rmsaXOWxOdpfIERhfyGQ();
      this.SqlTypes = StreamNHType.sqlTypes;
      this.ReturnedType = TypeOf<MemoryStream>.Raw;
      this.IsMutable = true;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static StreamNHType()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            StreamNHType.sqlTypes = new SqlType[1]
            {
              new SqlType(DbType.Binary, int.MaxValue)
            };
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 0 : 0;
            continue;
          case 2:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static int JGE7DbWxZaGuWpY1qsGC([In] object obj0, [In] object obj1) => ((DbDataReader) obj0).GetOrdinal((string) obj1);

    internal static object T4fX45WxuMMyLfOw3aXh([In] object obj0, [In] int obj1) => ((DbDataReader) obj0)[obj1];

    internal static long lPROMmWxIKxKDTHRMnmR(
      [In] object obj0,
      [In] int obj1,
      [In] long obj2,
      [In] object obj3,
      [In] int obj4,
      [In] int obj5)
    {
      return ((DbDataReader) obj0).GetBytes(obj1, obj2, (byte[]) obj3, obj4, obj5);
    }

    internal static object rki4YKWxVgeNrI6JL8hP() => (object) Logger.Log;

    internal static object zvEZg2WxSWi2V1OFynYr([In] object obj0) => (object) ((Exception) obj0).Message;

    internal static void AF0DiDWxiHT3JOD3UqiN([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Error(obj1, (Exception) obj2);

    internal static bool XlEnAEWxvOyp7D869pAf() => StreamNHType.s17mbJWxCwFTvYNq16VD == null;

    internal static StreamNHType TXYg28Wx83M3CsWQklrN() => StreamNHType.s17mbJWxCwFTvYNq16VD;

    internal static object F68iFeWxRvkE6PZZCZnX([In] object obj0) => (object) ((DbCommand) obj0).Parameters;

    internal static object MfcRftWxqyuQYBZ3McGL([In] object obj0, [In] int obj1) => (object) ((DbParameterCollection) obj0)[obj1];

    internal static void cOw1LpWxK3awmI70daOp([In] object obj0, [In] object obj1) => ((IDataParameter) obj0).Value = obj1;

    internal static long rQIp36WxXExtnxaWQNLI([In] object obj0, [In] long obj1, [In] SeekOrigin obj2) => ((Stream) obj0).Seek(obj1, obj2);

    internal static object NCu6UjWxTQdH42xV6ym9() => (object) MemoryHelper.GetMemoryStream();

    internal static void OEPQnAWxkcKPmuqpTkSJ([In] object obj0, [In] object obj1) => ((Stream) obj0).CopyTo((Stream) obj1);

    internal static bool sagVZuWxnTeoOp4phLyv([In] object obj0, [In] object obj1) => ((MemoryStream) obj0).Compare((MemoryStream) obj1);

    internal static void rmsaXOWxOdpfIERhfyGQ() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
