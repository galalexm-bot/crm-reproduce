// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Files.Previews.TiffPagesDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace EleWise.ELMA.Files.Previews
{
  /// <summary>Описание тифа</summary>
  [XmlRoot("TiffPagesDescriptor")]
  public class TiffPagesDescriptor
  {
    internal static TiffPagesDescriptor spVlmBGNUjXNs9Vc8dc5;

    /// <summary>Ширина</summary>
    [XmlElement("Width")]
    public int Width
    {
      get => this.\u003CWidth\u003Ek__BackingField;
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
              this.\u003CWidth\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 0;
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

    /// <summary>Высота</summary>
    [XmlElement("Height")]
    public int Height
    {
      get => this.\u003CHeight\u003Ek__BackingField;
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
              this.\u003CHeight\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 0 : 0;
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

    /// <summary>Названия файлов</summary>
    [XmlArray]
    public List<string> FileNames { get; set; }

    /// <summary>Ctor</summary>
    public TiffPagesDescriptor()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.FileNames = new List<string>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    internal static bool fh1LvlGNsOAUODySugDF() => TiffPagesDescriptor.spVlmBGNUjXNs9Vc8dc5 == null;

    internal static TiffPagesDescriptor ilAqOBGNcLaYuI92hgiS() => TiffPagesDescriptor.spVlmBGNUjXNs9Vc8dc5;
  }
}
