// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Cache.ActorModel.CacheResult
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Cache.ActorModel
{
  /// <summary>Результат обращения к кэшу.</summary>
  public struct CacheResult
  {
    /// <summary>Результат, представляющий "кэш-промах".</summary>
    public static CacheResult Failed;
    /// <summary>Значение ключа.</summary>
    public byte[] Value;
    /// <summary>Флаг успешного или неуспешного поиска ключа в кэше.</summary>
    public bool Success;
    internal static object C8u7eyfXyom1ARo0ZoxQ;

    /// <summary>Инициализирует экземпляр структуры.</summary>
    /// <param name="value">Значение ключа.</param>
    public CacheResult(byte[] value)
    {
      CacheResult.CANsA8fX9DFE50cEkyQC();
      this = new CacheResult(value, true);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Инициализирует экземпляр структуры.</summary>
    /// <param name="value">Значение ключа.</param>
    /// <param name="success">Флаг успешного или неуспешного поиска ключа в кэше.</param>
    public CacheResult(byte[] value, bool success)
    {
      CacheResult.CANsA8fX9DFE50cEkyQC();
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            this.Value = value;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 0 : 0;
            continue;
          default:
            this.Success = success;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 1 : 1;
            continue;
        }
      }
label_2:;
    }

    static CacheResult()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            CacheResult.CANsA8fX9DFE50cEkyQC();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            CacheResult.Failed = new CacheResult((byte[]) null, false);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 2 : 1;
            continue;
        }
      }
label_2:;
    }

    internal static void CANsA8fX9DFE50cEkyQC() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool hmKMjkfXMK3HuJkoC3Vc() => CacheResult.C8u7eyfXyom1ARo0ZoxQ == null;

    internal static object bo0ve3fXJRcgnTXwxvd3() => CacheResult.C8u7eyfXyom1ARo0ZoxQ;
  }
}
