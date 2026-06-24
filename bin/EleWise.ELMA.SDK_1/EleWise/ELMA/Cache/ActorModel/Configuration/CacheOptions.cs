// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Cache.ActorModel.Configuration.CacheOptions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Cache.ActorModel.Configuration
{
  /// <summary>Настройки распределенного кэша.</summary>
  public sealed class CacheOptions
  {
    internal static CacheOptions VOYW2XfTQeb7XnHyv7ih;

    /// <summary>Количество резервных серверов для ключа.</summary>
    public byte ReplicaFactor
    {
      get => this.\u003CReplicaFactor\u003Ek__BackingField;
      internal set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CReplicaFactor\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 0 : 0;
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

    public CacheOptions()
    {
      CacheOptions.QwkpsifT8aMVAMEUmlbC();
      // ISSUE: reference to a compiler-generated field
      this.\u003CReplicaFactor\u003Ek__BackingField = (byte) 1;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool mktokIfTC7stPTxH5D8O() => CacheOptions.VOYW2XfTQeb7XnHyv7ih == null;

    internal static CacheOptions My4rASfTvOgAviflT1S5() => CacheOptions.VOYW2XfTQeb7XnHyv7ih;

    internal static void QwkpsifT8aMVAMEUmlbC() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
