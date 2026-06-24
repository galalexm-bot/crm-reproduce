// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.CustomTypes.FixedAbstractBinaryType
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Engine;
using NHibernate.SqlTypes;
using NHibernate.Type;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Data;
using System.Data.Common;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Runtime.NH.CustomTypes
{
  /// <summary>
  /// Logic to bind stream of byte into a VARBINARY
  /// Исправление по быстродействию
  /// </summary>
  /// <summary>
  /// Logic to bind stream of byte into a VARBINARY
  /// Исправление по быстродействию
  /// </summary>
  [Serializable]
  public abstract class FixedAbstractBinaryType : 
    MutableType,
    IVersionType,
    IType,
    ICacheAssembler,
    IComparer
  {
    private static FixedAbstractBinaryType fyvA8nWx2BN4AarAkcUj;

    /// <inheritdoc />
    public Task<object> NextAsync(
      object current,
      ISessionImplementor session,
      CancellationToken cancellationToken)
    {
      return Task.FromResult<object>(current);
    }

    /// <inheritdoc />
    public Task<object> SeedAsync(ISessionImplementor session, CancellationToken cancellationToken) => Task.FromResult<object>((object) null);

    internal FixedAbstractBinaryType()
    {
      FixedAbstractBinaryType.FxHxyAWx1KtZv8EdEsWC();
      // ISSUE: explicit constructor call
      this.\u002Ector(new BinarySqlType());
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal FixedAbstractBinaryType(BinarySqlType sqlType)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector((SqlType) sqlType);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <inheritdoc />
    public object Next(object current, ISessionImplementor session) => current;

    /// <inheritdoc />
    public object Seed(ISessionImplementor session) => (object) null;

    /// <inheritdoc />
    public override bool IsEqual(object x, object y)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 4:
            goto label_4;
          case 2:
            goto label_6;
          case 3:
            if (x != y)
            {
              if (x == null)
              {
                num = 4;
                continue;
              }
              break;
            }
            num = 2;
            continue;
        }
        if (y == null)
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 1 : 1;
        else
          goto label_5;
      }
label_4:
      return false;
label_5:
      return FixedAbstractBinaryType.wJCbhlWx31JguWFOUSxi(FixedAbstractBinaryType.PYZVdyWxNGKdGoJaVF3W((object) this, x), FixedAbstractBinaryType.PYZVdyWxNGKdGoJaVF3W((object) this, y));
label_6:
      return true;
    }

    /// <inheritdoc />
    public IComparer Comparator => (IComparer) this;

    /// <inheritdoc />
    public abstract override string Name { get; }

    /// <summary> Convert the byte[] into the expected object type</summary>
    protected internal abstract object ToExternalFormat(byte[] bytes);

    /// <summary> Convert the object into the internal byte[] representation</summary>
    protected internal abstract byte[] ToInternalFormat(object bytes);

    /// <inheritdoc />
    public override void Set(DbCommand cmd, object value, int index, ISessionImplementor session)
    {
      int num = 2;
      byte[] numArray;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            FixedAbstractBinaryType.f7sGZRWxawxyXABZO0cB((object) ((DbParameterCollection) FixedAbstractBinaryType.m2iYe9WxpCcBng1IrymL((object) cmd))[index], (object) numArray);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 0 : 0;
            continue;
          case 2:
            numArray = (byte[]) FixedAbstractBinaryType.PYZVdyWxNGKdGoJaVF3W((object) this, value);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    /// <inheritdoc />
    public override object Get(DbDataReader rs, int index, ISessionImplementor session)
    {
      int num = 2;
      byte[] numArray;
      int length;
      while (true)
      {
        switch (num)
        {
          case 1:
            numArray = new byte[length];
            num = 3;
            continue;
          case 2:
            length = (int) FixedAbstractBinaryType.HxiLIGWxDPFOctg9hRsI((object) rs, index, 0L, (object) null, 0, 0);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 1 : 0;
            continue;
          case 3:
            FixedAbstractBinaryType.HxiLIGWxDPFOctg9hRsI((object) rs, index, 0L, (object) numArray, 0, length);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return FixedAbstractBinaryType.rXPMyEWxtkGUqw3412Zh((object) this, (object) numArray);
    }

    /// <inheritdoc />
    public override object Get(DbDataReader rs, string name, ISessionImplementor session) => FixedAbstractBinaryType.rrmN91WxwvpxMlNqFoHk((object) this, (object) rs, rs.GetOrdinal(name), (object) session);

    /// <inheritdoc />
    public override int GetHashCode(object x)
    {
      int num = 5;
      int hashCode;
      while (true)
      {
        byte[] numArray;
        int index;
        switch (num)
        {
          case 1:
            ++index;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 7;
            continue;
          case 2:
            index = 0;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 6 : 3;
            continue;
          case 3:
            goto label_6;
          case 4:
            hashCode = 1;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 2 : 2;
            continue;
          case 5:
            numArray = (byte[]) FixedAbstractBinaryType.PYZVdyWxNGKdGoJaVF3W((object) this, x);
            num = 4;
            continue;
          case 6:
          case 7:
            if (index >= numArray.Length)
            {
              num = 3;
              continue;
            }
            break;
        }
        hashCode = 31 * hashCode + (int) numArray[index];
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 1 : 1;
      }
label_6:
      return hashCode;
    }

    /// <inheritdoc />
    public override int Compare(object x, object y)
    {
      int num1 = 14;
      while (true)
      {
        int num2 = num1;
        int index;
        byte[] numArray;
        byte[] internalFormat;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_15;
            case 2:
              if (numArray.Length > internalFormat.Length)
              {
                num2 = 4;
                continue;
              }
              index = 0;
              num2 = 3;
              continue;
            case 3:
            case 11:
              goto label_3;
            case 4:
              goto label_13;
            case 5:
              goto label_18;
            case 6:
            case 9:
              if ((int) numArray[index] >= (int) internalFormat[index])
              {
                num2 = 10;
                continue;
              }
              goto label_18;
            case 7:
              goto label_6;
            case 8:
              if (numArray.Length >= internalFormat.Length)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 2 : 2;
                continue;
              }
              goto label_6;
            case 10:
              if ((int) numArray[index] <= (int) internalFormat[index])
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 0 : 0;
                continue;
              }
              goto label_15;
            case 12:
              goto label_5;
            case 13:
              internalFormat = this.ToInternalFormat(y);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 1 : 8;
              continue;
            case 14:
              numArray = (byte[]) FixedAbstractBinaryType.PYZVdyWxNGKdGoJaVF3W((object) this, x);
              num2 = 13;
              continue;
            default:
              goto label_16;
          }
        }
label_3:
        if (index < numArray.Length)
        {
          num1 = 9;
          continue;
        }
        break;
label_16:
        ++index;
        num1 = 11;
      }
label_5:
      return 0;
label_6:
      return -1;
label_13:
      return 1;
label_15:
      return 1;
label_18:
      return -1;
    }

    /// <inheritdoc />
    public override string ToString(object val)
    {
      int num1 = 6;
      StringBuilder stringBuilder;
      while (true)
      {
        int num2 = num1;
        int index;
        string str;
        byte[] internalFormat;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 7:
              if (index < internalFormat.Length)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 0;
                continue;
              }
              goto label_14;
            case 2:
              if (FixedAbstractBinaryType.v3G5lYWx6OEfRe4pJh87((object) str) == 1)
              {
                num2 = 9;
                continue;
              }
              goto label_7;
            case 3:
              goto label_14;
            case 4:
              goto label_7;
            case 5:
              goto label_10;
            case 6:
              internalFormat = this.ToInternalFormat(val);
              num2 = 5;
              continue;
            case 8:
              index = 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 1 : 7;
              continue;
            case 9:
              stringBuilder.Append('0');
              num2 = 4;
              continue;
            case 10:
              ++index;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 1;
              continue;
            default:
              str = (string) FixedAbstractBinaryType.Lb75oeWx4HgiibuZDKMt((int) internalFormat[index], 16);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 2;
              continue;
          }
        }
label_7:
        FixedAbstractBinaryType.KWQ581WxHmvQBcraQZWx((object) stringBuilder, (object) str);
        num1 = 10;
        continue;
label_10:
        stringBuilder = new StringBuilder();
        num1 = 8;
      }
label_14:
      return stringBuilder.ToString();
    }

    /// <inheritdoc />
    public override object DeepCopyNotNull(object value)
    {
      int num = 1;
      byte[] numArray;
      byte[] bytes;
      while (true)
      {
        switch (num)
        {
          case 1:
            numArray = (byte[]) FixedAbstractBinaryType.PYZVdyWxNGKdGoJaVF3W((object) this, value);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_5;
          case 3:
            FixedAbstractBinaryType.CJ7TYaWxABCai9HYwMRA((object) numArray, 0, (object) bytes, 0, numArray.Length);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 0 : 2;
            continue;
          default:
            bytes = new byte[numArray.Length];
            num = 3;
            continue;
        }
      }
label_5:
      return this.ToExternalFormat(bytes);
    }

    /// <inheritdoc />
    public override object FromStringValue(string xml)
    {
      int num = 9;
      byte[] numArray;
      int index;
      string str;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_7;
          case 2:
          case 7:
            if (index >= numArray.Length)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 0 : 1;
              continue;
            }
            goto case 10;
          case 3:
            ++index;
            num = 7;
            continue;
          case 4:
            goto label_4;
          case 5:
            numArray[index] = (byte) FixedAbstractBinaryType.nSMP6eWxxGtXdsRrtJnt((object) str, 16);
            num = 3;
            continue;
          case 6:
            index = 0;
            num = 2;
            continue;
          case 8:
            goto label_9;
          case 9:
            if (xml == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 8 : 1;
              continue;
            }
            if (xml.Length % 2 == 0)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          case 10:
            str = (string) FixedAbstractBinaryType.eTZPVgWx7P6m5uFso5Z9((object) xml, index * 2, (index + 1) * 2 - index * 2);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 5 : 5;
            continue;
          default:
            numArray = new byte[FixedAbstractBinaryType.v3G5lYWx6OEfRe4pJh87((object) xml) / 2];
            num = 6;
            continue;
        }
      }
label_4:
      throw new ArgumentException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638539501));
label_7:
      return FixedAbstractBinaryType.rXPMyEWxtkGUqw3412Zh((object) this, (object) numArray);
label_9:
      return (object) null;
    }

    internal static void FxHxyAWx1KtZv8EdEsWC() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool cKbJ9rWxeWgHhKin08lq() => FixedAbstractBinaryType.fyvA8nWx2BN4AarAkcUj == null;

    internal static FixedAbstractBinaryType zk8NHiWxPEnIHJhRa0Mc() => FixedAbstractBinaryType.fyvA8nWx2BN4AarAkcUj;

    internal static object PYZVdyWxNGKdGoJaVF3W([In] object obj0, [In] object obj1) => (object) ((FixedAbstractBinaryType) obj0).ToInternalFormat(obj1);

    internal static bool wJCbhlWx31JguWFOUSxi([In] object obj0, [In] object obj1) => CollectionExtensions.ByteArrayCompare((byte[]) obj0, (byte[]) obj1);

    internal static object m2iYe9WxpCcBng1IrymL([In] object obj0) => (object) ((DbCommand) obj0).Parameters;

    internal static void f7sGZRWxawxyXABZO0cB([In] object obj0, [In] object obj1) => ((IDataParameter) obj0).Value = obj1;

    internal static long HxiLIGWxDPFOctg9hRsI(
      [In] object obj0,
      [In] int obj1,
      [In] long obj2,
      [In] object obj3,
      [In] int obj4,
      [In] int obj5)
    {
      return ((DbDataReader) obj0).GetBytes(obj1, obj2, (byte[]) obj3, obj4, obj5);
    }

    internal static object rXPMyEWxtkGUqw3412Zh([In] object obj0, [In] object obj1) => ((FixedAbstractBinaryType) obj0).ToExternalFormat((byte[]) obj1);

    internal static object rrmN91WxwvpxMlNqFoHk([In] object obj0, [In] object obj1, [In] int obj2, [In] object obj3) => ((NullableType) obj0).Get((DbDataReader) obj1, obj2, (ISessionImplementor) obj3);

    internal static object Lb75oeWx4HgiibuZDKMt([In] int obj0, [In] int obj1) => (object) Convert.ToString(obj0, obj1);

    internal static int v3G5lYWx6OEfRe4pJh87([In] object obj0) => ((string) obj0).Length;

    internal static object KWQ581WxHmvQBcraQZWx([In] object obj0, [In] object obj1) => (object) ((StringBuilder) obj0).Append((string) obj1);

    internal static void CJ7TYaWxABCai9HYwMRA(
      [In] object obj0,
      [In] int obj1,
      [In] object obj2,
      [In] int obj3,
      [In] int obj4)
    {
      Array.Copy((Array) obj0, obj1, (Array) obj2, obj3, obj4);
    }

    internal static object eTZPVgWx7P6m5uFso5Z9([In] object obj0, [In] int obj1, [In] int obj2) => (object) ((string) obj0).Substring(obj1, obj2);

    internal static int nSMP6eWxxGtXdsRrtJnt([In] object obj0, [In] int obj1) => Convert.ToInt32((string) obj0, obj1);
  }
}
