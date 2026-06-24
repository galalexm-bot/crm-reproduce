// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.ModalViewItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.ComponentModel;

namespace EleWise.ELMA.Model.Views
{
  /// <summary>Модальное окно</summary>
  [Serializable]
  public sealed class ModalViewItem : RootViewItem, IViewItemLoading
  {
    internal static ModalViewItem l9amcBoVyORbJuJtvVRn;

    /// <summary>Ctor</summary>
    public ModalViewItem()
    {
      ModalViewItem.cPMj6BoV9ON4o4Lr4jZS();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.Size = ViewItemComponentSize.Medium;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 0 : 0;
            continue;
          case 2:
            this.LoadingType = ViewItemLoadingType.AsyncLoading;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    /// <summary>Размер</summary>
    [DefaultValue(ViewItemComponentSize.Medium)]
    public ViewItemComponentSize Size
    {
      get => this.\u003CSize\u003Ek__BackingField;
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
              this.\u003CSize\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 0 : 0;
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

    /// <summary>Заголовок</summary>
    [EleWise.ELMA.Globalization.Localizable]
    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
    public string Title
    {
      get => this.\u003CTitle\u003Ek__BackingField;
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
              this.\u003CTitle\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 0;
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

    /// <summary>Уничтожать окно при закрытии</summary>
    [DefaultValue(false)]
    public bool DestroyOnClose
    {
      get => this.\u003CDestroyOnClose\u003Ek__BackingField;
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
              this.\u003CDestroyOnClose\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 0 : 0;
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
    [DefaultValue(ViewItemLoadingType.AsyncLoading)]
    public ViewItemLoadingType LoadingType
    {
      get => this.\u003CLoadingType\u003Ek__BackingField;
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
              this.\u003CLoadingType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 0;
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
    public override bool IsValid(ViewType viewType, ViewItem parentViewItem) => true;

    /// <inheritdoc />
    public override bool IsChildValid(ViewItem childViewItem) => true;

    internal static void cPMj6BoV9ON4o4Lr4jZS() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool Sfm63boVMtCtymQykUoq() => ModalViewItem.l9amcBoVyORbJuJtvVRn == null;

    internal static ModalViewItem YclPsVoVJrI3BQLiAIeL() => ModalViewItem.l9amcBoVyORbJuJtvVRn;
  }
}
