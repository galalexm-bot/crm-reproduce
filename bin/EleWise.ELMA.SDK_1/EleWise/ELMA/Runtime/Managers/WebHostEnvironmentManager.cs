// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Managers.WebHostEnvironmentManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Runtime.Managers
{
  /// <summary>Реализация менеджера для работы с хостом веб-сервера</summary>
  [Component(Type = ComponentType.WebServer)]
  public class WebHostEnvironmentManager : 
    DTOManager,
    IWebHostEnvironmentManager,
    IConfigurationService
  {
    private Guid hostSessionUid;
    private static WebHostEnvironmentManager Gm4MoEWMLA5926aouQ3b;

    /// <summary>Реализация сервиса</summary>
    public IWebHostEnvironmentService WebHostEnvironmentService
    {
      get => this.\u003CWebHostEnvironmentService\u003Ek__BackingField;
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
              this.\u003CWebHostEnvironmentService\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 0 : 0;
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

    /// <summary>Перезапустить хост</summary>
    public virtual void RestartHost()
    {
      int num1 = 3;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_4;
            case 2:
              goto label_3;
            case 3:
              if (this.WebHostEnvironmentService != null)
                break;
              goto label_7;
          }
          this.WebHostEnvironmentService.RestartHost();
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 1;
        }
label_7:
        num1 = 2;
      }
label_4:
      return;
label_3:;
    }

    /// <summary>
    /// Получить уникальный идентификатор для сессии запуска данного хоста
    /// </summary>
    /// <returns></returns>
    public virtual Guid GetHostSessionUid() => this.hostSessionUid;

    public WebHostEnvironmentManager()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.hostSessionUid = WebHostEnvironmentManager.PJW5DZWMcoyBBII4KIeI();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool yS9232WMUaBc325qO38w() => WebHostEnvironmentManager.Gm4MoEWMLA5926aouQ3b == null;

    internal static WebHostEnvironmentManager ml5BdhWMs1Xs4aoDoVZr() => WebHostEnvironmentManager.Gm4MoEWMLA5926aouQ3b;

    internal static Guid PJW5DZWMcoyBBII4KIeI() => Guid.NewGuid();
  }
}
