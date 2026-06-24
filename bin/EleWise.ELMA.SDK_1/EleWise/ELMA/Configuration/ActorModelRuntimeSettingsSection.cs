// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Configuration.ActorModelRuntimeSettingsSection
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.ComponentModel;
using System.Configuration;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Configuration
{
  /// <summary>
  /// Секция для конфигурирования типа провайдера среды Actor Model
  /// </summary>
  public class ActorModelRuntimeSettingsSection : ProviderSettingsSection
  {
    internal static ActorModelRuntimeSettingsSection vLLRuFfF0lRvsSYyB0CT;

    /// <summary>Таймаут ожидания завершения операции в секундах</summary>
    [TypeConverter(typeof (TimeSpanSecondsConverter))]
    [ConfigurationProperty("ResponseTimeout", DefaultValue = "600")]
    public TimeSpan ResponseTimeout
    {
      get => (TimeSpan) ActorModelRuntimeSettingsSection.VevEbffFJAGZF43Omv2x((object) this, ActorModelRuntimeSettingsSection.QqO6rtfFMgEFA5tHKGLT(1505778440 - 1981636111 ^ -475532455));
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
              this[z2jc63fLkugS1X8Q9N.tE1kD1vbB(2008901894 << 3 ^ -1108457584)] = (object) value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 0;
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
    protected override void InitializeAutoInitilize()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.AutoInitialize = false;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public ActorModelRuntimeSettingsSection()
    {
      ActorModelRuntimeSettingsSection.JuR9CcfF90J1bKBEjmQV();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object QqO6rtfFMgEFA5tHKGLT(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object VevEbffFJAGZF43Omv2x([In] object obj0, [In] object obj1) => ((ConfigurationElement) obj0)[(string) obj1];

    internal static bool VTylD3fFmmvVGN6epZWr() => ActorModelRuntimeSettingsSection.vLLRuFfF0lRvsSYyB0CT == null;

    internal static ActorModelRuntimeSettingsSection qKXwnFfFyC4sIERXTJqu() => ActorModelRuntimeSettingsSection.vLLRuFfF0lRvsSYyB0CT;

    internal static void JuR9CcfF90J1bKBEjmQV() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
