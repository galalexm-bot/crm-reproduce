// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Settings.AnyTypeSettings
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Enums;
using j3AmrhgkCleVTGdEwA;
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Types.Settings
{
  /// <summary>Настройки для произвольного типа</summary>
  [Serializable]
  public class AnyTypeSettings : TypeSettings
  {
    internal static AnyTypeSettings apsLGQozdPX5kP1bCVAU;

    /// <summary>Ctor</summary>
    public AnyTypeSettings()
    {
      AnyTypeSettings.o1lAqLozgZ7icPaSeiX4();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor for serialization</summary>
    /// <param name="info">SerializationInfo</param>
    /// <param name="context">StreamingContext</param>
    protected AnyTypeSettings(SerializationInfo info, StreamingContext context)
    {
      AnyTypeSettings.o1lAqLozgZ7icPaSeiX4();
      // ISSUE: explicit constructor call
      base.\u002Ector(info, context);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Полное имя типа</summary>
    [PublicationBehaviour(PublicationType.Restart)]
    [DefaultValue("")]
    [XmlElement("FullTypeName")]
    public string FullTypeName
    {
      get => this.\u003CFullTypeName\u003Ek__BackingField;
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
              this.\u003CFullTypeName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 0 : 0;
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

    public override bool Equals(object obj)
    {
      int num = 2;
      AnyTypeSettings anyTypeSettings;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (anyTypeSettings == null)
            {
              num = 3;
              continue;
            }
            if (base.Equals(obj))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
              continue;
            }
            goto label_9;
          case 2:
            anyTypeSettings = obj as AnyTypeSettings;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_5;
          default:
            goto label_8;
        }
      }
label_5:
      return false;
label_8:
      return AnyTypeSettings.VV0sCQozjQKPyO79aIvf((object) this.FullTypeName, AnyTypeSettings.vMtxLRoz5LIJwf3P2nC0((object) anyTypeSettings));
label_9:
      return false;
    }

    internal static void o1lAqLozgZ7icPaSeiX4() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool SaBUyvozlTmPPwPxAKI3() => AnyTypeSettings.apsLGQozdPX5kP1bCVAU == null;

    internal static AnyTypeSettings nbaxDqozr6HGAWCELxXq() => AnyTypeSettings.apsLGQozdPX5kP1bCVAU;

    internal static object vMtxLRoz5LIJwf3P2nC0([In] object obj0) => (object) ((AnyTypeSettings) obj0).FullTypeName;

    internal static bool VV0sCQozjQKPyO79aIvf([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;
  }
}
