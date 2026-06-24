// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Helpers.DateTimeWrapper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Types.Helpers
{
  [XmlRoot("DateTimeValue")]
  [Component]
  public class DateTimeWrapper : IXsiType
  {
    private static DateTimeWrapper yRZEC3bQEgdD2bPR1nYx;

    public DateTimeWrapper()
    {
      DateTimeWrapper.VRZ19mbQCp6vEPVFMbKf();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
        num = 0;
      switch (num)
      {
      }
    }

    public DateTimeWrapper(DateTime? source)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Value = source;
    }

    [XmlElement("DateTimeUTC")]
    public long DateTimeTicks
    {
      get => this.\u003CDateTimeTicks\u003Ek__BackingField;
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
              this.\u003CDateTimeTicks\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 0 : 0;
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

    [XmlIgnore]
    public DateTime? Value
    {
      get => this.DateTimeTicks > 0L ? new DateTime?(new DateTime(this.DateTimeTicks).ToLocalTime()) : new DateTime?();
      set
      {
        if (!value.HasValue || !value.HasValue)
          return;
        this.DateTimeTicks = value.Value.ToUniversalTime().Ticks;
      }
    }

    internal static void VRZ19mbQCp6vEPVFMbKf() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool zcNyLxbQfUid6Wf2xopF() => DateTimeWrapper.yRZEC3bQEgdD2bPR1nYx == null;

    internal static DateTimeWrapper qVg0jvbQQePM5tJDNgTP() => DateTimeWrapper.yRZEC3bQEgdD2bPR1nYx;
  }
}
