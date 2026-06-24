// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.PropertyMetadataAdditionalAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Metadata
{
  [Serializable]
  public class PropertyMetadataAdditionalAttribute
  {
    private static PropertyMetadataAdditionalAttribute ryUlTabwE40SwQhfbSjT;

    [XmlAttribute]
    public string AddtibuteName
    {
      get => this.\u003CAddtibuteName\u003Ek__BackingField;
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
              this.\u003CAddtibuteName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 0 : 0;
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

    [XmlElement("Parameter")]
    public Parameter[] Parameters
    {
      get => this.\u003CParameters\u003Ek__BackingField;
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
              this.\u003CParameters\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 0;
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

    public PropertyMetadataAdditionalAttribute()
    {
      PropertyMetadataAdditionalAttribute.VFDZokbwC4GHBspyTF9m();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool ejwnwFbwfQgnV3s2Youy() => PropertyMetadataAdditionalAttribute.ryUlTabwE40SwQhfbSjT == null;

    internal static PropertyMetadataAdditionalAttribute zNENsXbwQgKeJeoHJNdN() => PropertyMetadataAdditionalAttribute.ryUlTabwE40SwQhfbSjT;

    internal static void VFDZokbwC4GHBspyTF9m() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
