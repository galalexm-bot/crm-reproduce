// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.EnumMetadataAdditionalAttribute
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
  public class EnumMetadataAdditionalAttribute
  {
    internal static EnumMetadataAdditionalAttribute BcsPwIbDjGyxXBxv7ERR;

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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 0 : 0;
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
    public EnumParameter[] Parameters
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 0 : 0;
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

    public EnumMetadataAdditionalAttribute()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool E1wBqSbDYammT2Pf4URE() => EnumMetadataAdditionalAttribute.BcsPwIbDjGyxXBxv7ERR == null;

    internal static EnumMetadataAdditionalAttribute HYiED6bDL3XAC9Vd05eU() => EnumMetadataAdditionalAttribute.BcsPwIbDjGyxXBxv7ERR;
  }
}
