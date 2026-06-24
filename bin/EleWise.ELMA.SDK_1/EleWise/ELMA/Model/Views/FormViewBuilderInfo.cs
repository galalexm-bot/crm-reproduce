// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.FormViewBuilderInfo
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Views
{
  /// <summary>Информация о построителе представления для модели</summary>
  public sealed class FormViewBuilderInfo
  {
    internal static FormViewBuilderInfo n4XafHoiYRwsbXIh1xwL;

    /// <summary>Ctor</summary>
    public FormViewBuilderInfo()
    {
      FormViewBuilderInfo.Nc0uBBoistT1vOcKgrRi();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.Properties = new List<PropertyViewInfo>();
            num = 2;
            continue;
          case 2:
            this.Notifications = new List<NotificationInfo>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 0 : 0;
            continue;
          default:
            goto label_6;
        }
      }
label_3:
      return;
label_6:;
    }

    /// <summary>Информация о свойствах</summary>
    public List<PropertyViewInfo> Properties { get; }

    /// <summary>Информация об уведомлениях</summary>
    public List<NotificationInfo> Notifications { get; }

    /// <summary>Закрыть текущее всплывающее окно</summary>
    public bool ClosePopup
    {
      get => this.\u003CClosePopup\u003Ek__BackingField;
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
              this.\u003CClosePopup\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 0 : 0;
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

    internal static void Nc0uBBoistT1vOcKgrRi() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool ce6NqwoiLtJQDWaIXuIi() => FormViewBuilderInfo.n4XafHoiYRwsbXIh1xwL == null;

    internal static FormViewBuilderInfo Mr958PoiUMTHueN5jQqm() => FormViewBuilderInfo.n4XafHoiYRwsbXIh1xwL;
  }
}
