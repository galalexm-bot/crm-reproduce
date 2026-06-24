// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Scripts.Models.GlobalScriptModuleInitWorkspaceRequest
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Scripts;
using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Scripts.Models
{
  /// <summary>
  /// Запрос на инициализацию рабочего пространства для глобального скрипта
  /// </summary>
  public sealed class GlobalScriptModuleInitWorkspaceRequest : InitWorkspaceRequest
  {
    internal static GlobalScriptModuleInitWorkspaceRequest zZLRjTWBnuXQb6nBHtXf;

    /// <summary>Глобальный модуль сценариев</summary>
    public IGlobalScriptModule GlobalScriptModule
    {
      get => this.\u003CGlobalScriptModule\u003Ek__BackingField;
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
              this.\u003CGlobalScriptModule\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 0;
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

    /// <summary>Уникальный идентификатор редактируемого элемента</summary>
    public Guid ProjectItemUid
    {
      get => this.\u003CProjectItemUid\u003Ek__BackingField;
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
              this.\u003CProjectItemUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 0 : 0;
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

    public GlobalScriptModuleInitWorkspaceRequest()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool zuE0BlWBOjIswk9Fv7o3() => GlobalScriptModuleInitWorkspaceRequest.zZLRjTWBnuXQb6nBHtXf == null;

    internal static GlobalScriptModuleInitWorkspaceRequest YiShOeWB2ET3H8jjGSFF() => GlobalScriptModuleInitWorkspaceRequest.zZLRjTWBnuXQb6nBHtXf;
  }
}
