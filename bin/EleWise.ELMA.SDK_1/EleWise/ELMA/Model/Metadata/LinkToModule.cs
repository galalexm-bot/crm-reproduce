// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.LinkToModule
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>Ссылка на модуль</summary>
  [XmlRoot("LinkToModule")]
  [Serializable]
  public class LinkToModule
  {
    internal static LinkToModule SDbfu0bpJDVkGX64hKZx;

    /// <summary>Уникальный идентификатор модуля</summary>
    public virtual Guid ModuleUid
    {
      get => this.\u003CModuleUid\u003Ek__BackingField;
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
              this.\u003CModuleUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 0;
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

    /// <summary>Отображаемое имя модуля</summary>
    public virtual string DisplayName
    {
      get => this.\u003CDisplayName\u003Ek__BackingField;
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
              this.\u003CDisplayName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 0 : 0;
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
    public override string ToString() => (string) LinkToModule.ztmOGlbplumoAe6vFpEr((object) this);

    public LinkToModule()
    {
      LinkToModule.XK4l2HbprfZNkECLvEoH();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool Ik0M5tbp9qoHvpLJIH4H() => LinkToModule.SDbfu0bpJDVkGX64hKZx == null;

    internal static LinkToModule yD0XUUbpdqiDmqTR9CnL() => LinkToModule.SDbfu0bpJDVkGX64hKZx;

    internal static object ztmOGlbplumoAe6vFpEr([In] object obj0) => (object) ((LinkToModule) obj0).DisplayName;

    internal static void XK4l2HbprfZNkECLvEoH() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
