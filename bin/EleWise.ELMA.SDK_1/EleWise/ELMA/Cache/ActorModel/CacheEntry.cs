// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Cache.ActorModel.CacheEntry
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Cache.ActorModel
{
  /// <summary>Запись кэша.</summary>
  internal class CacheEntry
  {
    internal static CacheEntry q0WhvhfXH2vAaB3qah7n;

    /// <summary>Инициализирует запись кэша.</summary>
    /// <param name="key">Ключ.</param>
    /// <param name="value">Значение.</param>
    /// <param name="hash">Хэш.</param>
    /// <param name="angle">Угол.</param>
    /// <param name="expiration">Время, когда запись будет считаться недействительной.</param>
    public CacheEntry(string key, byte[] value, uint hash, double angle, DateTime expiration)
    {
      CacheEntry.gv6SmbfXxOjbi6EwMWf4();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.Hash = hash;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 0 : 0;
            continue;
          case 2:
            this.Key = key;
            num = 5;
            continue;
          case 3:
            this.Expiration = expiration;
            num = 4;
            continue;
          case 4:
            goto label_3;
          case 5:
            this.Value = value;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 1 : 1;
            continue;
          default:
            this.Angle = angle;
            num = 3;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Ключ записи.</summary>
    public string Key { get; }

    /// <summary>Значение записи.</summary>
    public byte[] Value { get; }

    /// <summary>Хэш записи.</summary>
    public uint Hash { get; }

    /// <summary>Угол записи.</summary>
    public double Angle { get; }

    /// <summary>Время, когда запись будет считаться недействительной.</summary>
    public DateTime Expiration { get; }

    /// <inheritdoc />
    public override string ToString() => (string) CacheEntry.M323HPfXmsvTtneHWpy0(CacheEntry.RkBdJCfX0WGsEUwSbRkb(-87337865 ^ -87158273), (object) new object[4]
    {
      (object) this.Key,
      (object) this.Hash,
      (object) this.Angle,
      (object) this.Expiration
    });

    internal static void gv6SmbfXxOjbi6EwMWf4() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool a0ebf8fXAW4bdsnEV0fr() => CacheEntry.q0WhvhfXH2vAaB3qah7n == null;

    internal static CacheEntry EPNhwyfX7YrILdbDrYiN() => CacheEntry.q0WhvhfXH2vAaB3qah7n;

    internal static object RkBdJCfX0WGsEUwSbRkb(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object M323HPfXmsvTtneHWpy0([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, (object[]) obj1);
  }
}
