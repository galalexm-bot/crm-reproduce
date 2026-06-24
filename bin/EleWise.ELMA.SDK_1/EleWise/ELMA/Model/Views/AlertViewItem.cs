// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.AlertViewItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Views
{
  /// <summary>Информационный блок</summary>
  [Serializable]
  public class AlertViewItem : RootViewItem
  {
    internal static AlertViewItem urkvg3oSrIyT8jeehYGA;

    /// <summary>ctor</summary>
    public AlertViewItem()
    {
      AlertViewItem.SkeHBJoSj9ehERATduep();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.AlertType = AlertType.Information;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Тип информационного блока</summary>
    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
    [DefaultValue(AlertType.Information)]
    public AlertType AlertType
    {
      get => this.\u003CAlertType\u003Ek__BackingField;
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
              this.\u003CAlertType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 0 : 0;
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

    /// <summary>Закрываемая</summary>
    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
    [DefaultValue(false)]
    public bool Closable
    {
      get => this.\u003CClosable\u003Ek__BackingField;
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
              this.\u003CClosable\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 0 : 0;
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
    public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (parentViewItem != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return AlertViewItem.SSAfi3oSYNYIUKlLkkck((object) parentViewItem, (object) this);
label_5:
      return false;
    }

    /// <inheritdoc />
    public override bool IsChildValid(ViewItem childViewItem) => true;

    internal static void SkeHBJoSj9ehERATduep() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool xJuBOYoSguqw5JXEV0Tx() => AlertViewItem.urkvg3oSrIyT8jeehYGA == null;

    internal static AlertViewItem puD30voS5lsKBbInJMCf() => AlertViewItem.urkvg3oSrIyT8jeehYGA;

    internal static bool SSAfi3oSYNYIUKlLkkck([In] object obj0, [In] object obj1) => ((ViewItem) obj0).IsChildValid((ViewItem) obj1);
  }
}
