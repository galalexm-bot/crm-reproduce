// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.EnumMetadataTypeAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>Указывает тип метаданных перечисления</summary>
  public class EnumMetadataTypeAttribute : Attribute
  {
    private EnumMetadataType type;
    internal static EnumMetadataTypeAttribute sbO71aoveDNRbYvri4cx;

    /// <summary>Ctor</summary>
    /// <param name="type">Тип метаданных перечисления</param>
    public EnumMetadataTypeAttribute(EnumMetadataType type)
    {
      EnumMetadataTypeAttribute.hTZ4f7ovNX1W9qw2xGEU();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.type = type;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Тип метаданных перечисления</summary>
    public EnumMetadataType Type => this.type;

    internal static void hTZ4f7ovNX1W9qw2xGEU() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool f0HYXEovPdpMDuotpmFo() => EnumMetadataTypeAttribute.sbO71aoveDNRbYvri4cx == null;

    internal static EnumMetadataTypeAttribute dA3md8ov1OMgyqvWp3Lm() => EnumMetadataTypeAttribute.sbO71aoveDNRbYvri4cx;
  }
}
