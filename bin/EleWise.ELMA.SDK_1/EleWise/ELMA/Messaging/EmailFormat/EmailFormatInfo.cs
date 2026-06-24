// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Messaging.EmailFormat.EmailFormatInfo
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Xml.Serialization;

namespace EleWise.ELMA.Messaging.EmailFormat
{
  [XmlRoot]
  [Serializable]
  public class EmailFormatInfo
  {
    internal static EmailFormatInfo BHFjHbhymESJtGnmWraE;

    [XmlElement("Name")]
    public string Name
    {
      get => this.\u003CName\u003Ek__BackingField;
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
              this.\u003CName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 0 : 0;
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

    [XmlElement("SubjectPrefix")]
    public string SubjectPrefix
    {
      get => this.\u003CSubjectPrefix\u003Ek__BackingField;
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
              this.\u003CSubjectPrefix\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 0 : 0;
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

    public EmailFormatInfo()
    {
      EmailFormatInfo.dnawsFhyJmP4BGiaSMGq();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool Hu5Mqehyydq9cRiUZs6Q() => EmailFormatInfo.BHFjHbhymESJtGnmWraE == null;

    internal static EmailFormatInfo Xe1MC6hyMp2YZNxMHx5M() => EmailFormatInfo.BHFjHbhymESJtGnmWraE;

    internal static void dnawsFhyJmP4BGiaSMGq() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
