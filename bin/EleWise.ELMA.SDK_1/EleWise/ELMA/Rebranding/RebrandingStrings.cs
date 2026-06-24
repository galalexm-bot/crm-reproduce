// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Rebranding.RebrandingStrings
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace EleWise.ELMA.Rebranding
{
  [XmlRoot("RebrandingStrings")]
  public class RebrandingStrings
  {
    private static RebrandingStrings hKr08hPZ3dC4ngvP88S;

    /// <summary>Строки для ребрендинга</summary>
    [XmlArray]
    [DataMember]
    [XmlArrayItem("String")]
    public List<RebrandingStrings.RebrandingString> Strings { get; set; }

    /// <summary>Ctor</summary>
    public RebrandingStrings()
    {
      RebrandingStrings.qA5cWJPVfnuQiXdnAAq();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.Strings = new List<RebrandingStrings.RebrandingString>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    internal static void qA5cWJPVfnuQiXdnAAq() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool w9e7QYPu0vV5DZ2se6p() => RebrandingStrings.hKr08hPZ3dC4ngvP88S == null;

    internal static RebrandingStrings b7HmMMPIdGBuUnk9XsD() => RebrandingStrings.hKr08hPZ3dC4ngvP88S;

    public class RebrandingString
    {
      internal static RebrandingStrings.RebrandingString D5bP1dfM8VJ8MqnTHXal;

      /// <summary>Ключ в требуемой культуре</summary>
      public string Key
      {
        get => this.\u003CKey\u003Ek__BackingField;
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
                this.\u003CKey\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 0 : 0;
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

      /// <summary>Значение, на которое будет заменено значение ключа</summary>
      public string Value
      {
        get => this.\u003CValue\u003Ek__BackingField;
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
                this.\u003CValue\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 0;
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

      public RebrandingString()
      {
        RebrandingStrings.RebrandingString.CrwfOEfMI1wMNol4PY1B();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool ANOvc6fMZwRJmxHZhfOq() => RebrandingStrings.RebrandingString.D5bP1dfM8VJ8MqnTHXal == null;

      internal static RebrandingStrings.RebrandingString fjqgJNfMuYMo7v5AiWwT() => RebrandingStrings.RebrandingString.D5bP1dfM8VJ8MqnTHXal;

      internal static void CrwfOEfMI1wMNol4PY1B() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }
  }
}
