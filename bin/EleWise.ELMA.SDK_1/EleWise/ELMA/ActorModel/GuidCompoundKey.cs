// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ActorModel.GuidCompoundKey
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.ActorModel
{
  /// <summary>Составной ключ Актора.</summary>
  public struct GuidCompoundKey : IEquatable<GuidCompoundKey>
  {
    private static object OQ2nhGf3qTp5pXs9R9ME;

    /// <summary>
    /// Устанавливает и возвращает Guid-часть составного ключа.
    /// </summary>
    public Guid GuidKey
    {
      get => this.\u003CGuidKey\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CGuidKey\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>
    /// Устанавливает и возвращает строковую часть составного ключа.
    /// </summary>
    public string StringKey
    {
      get => this.\u003CStringKey\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CStringKey\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <inheritdoc />
    public override bool Equals(object obj)
    {
      int num = 2;
      GuidCompoundKey other;
      object obj1;
      while (true)
      {
        switch (num)
        {
          case 1:
            other = (GuidCompoundKey) obj1;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 0 : 0;
            continue;
          case 2:
            if ((obj1 = obj) is GuidCompoundKey)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 1 : 1;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return this.Equals(other);
label_3:
      return false;
    }

    /// <inheritdoc />
    public bool Equals(GuidCompoundKey other)
    {
      int num = 1;
      Guid guidKey;
      while (true)
      {
        switch (num)
        {
          case 1:
            guidKey = this.GuidKey;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_6;
          case 3:
            goto label_5;
          default:
            if (!guidKey.Equals(other.GuidKey))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 2;
              continue;
            }
            goto label_5;
        }
      }
label_5:
      return GuidCompoundKey.ofCcqKf3TsumkwaHDhWj((object) this.StringKey, (object) other.StringKey);
label_6:
      return false;
    }

    /// <inheritdoc />
    public override int GetHashCode() => (1925753114 * -1521134295 + EqualityComparer<Guid>.Default.GetHashCode(this.GuidKey)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.StringKey);

    /// <inheritdoc />
    public override string ToString() => (string) GuidCompoundKey.qLXKtLf3kCg0rxDD669O((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978427880), (object) this.GuidKey, (object) this.StringKey);

    internal static bool EYSs5Vf3KmiLRxohTPJD() => GuidCompoundKey.OQ2nhGf3qTp5pXs9R9ME == null;

    internal static object eHnH6kf3XCxLaQrboVyW() => GuidCompoundKey.OQ2nhGf3qTp5pXs9R9ME;

    internal static bool ofCcqKf3TsumkwaHDhWj([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static object qLXKtLf3kCg0rxDD669O([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);
  }
}
