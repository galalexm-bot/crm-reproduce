// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Metadata.FormPartMetadata
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.UI.Metadata
{
  /// <summary>Часть формы страницы или портлета</summary>
  public class FormPartMetadata : AbstractMetadata
  {
    private static FormPartMetadata KcumHuBE3862DQ6Z4kJl;

    /// <summary>Метаданные модели</summary>
    public FormContextMetadata Context
    {
      get => this.\u003CContext\u003Ek__BackingField;
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
              this.\u003CContext\u003Ek__BackingField = value;
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

    /// <summary>Представление формы</summary>
    public FormViewItem View
    {
      get => this.\u003CView\u003Ek__BackingField;
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
              this.\u003CView\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 0;
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

    public override void InitNew()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.Context = new FormContextMetadata();
            num = 4;
            continue;
          case 2:
            base.InitNew();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 1 : 1;
            continue;
          case 3:
            FormPartMetadata.IKXmDHBEDUfVt9t4V6q4((object) this.View, (object) null);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 5 : 2;
            continue;
          case 4:
            this.Context.InitNew();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 0 : 0;
            continue;
          case 5:
            goto label_2;
          default:
            this.View = new FormViewItem();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 1 : 3;
            continue;
        }
      }
label_2:;
    }

    /// <summary>
    /// Сгенерировать новые идентификаторы для всех составляющих элементов (например, для публикации или копирования)
    /// </summary>
    public virtual void GenerateNewUids()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_5;
          case 1:
            if (this.Context == null)
            {
              num = 4;
              continue;
            }
            goto case 3;
          case 2:
            FormPartMetadata.W0GyG2BEtAEP2MdIpOqt((object) this, Guid.NewGuid());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 0 : 1;
            continue;
          case 3:
            FormPartMetadata.r9vdN1BEwilnsM0NPbLc((object) this.Context);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 0 : 0;
            continue;
          case 4:
            goto label_2;
          default:
            goto label_8;
        }
      }
label_5:
      return;
label_2:
      return;
label_8:;
    }

    public FormPartMetadata()
    {
      FormPartMetadata.Sr8WMEBE4pZX8k5wW7JV();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool lH9TFlBEpkZOa5sG6Syk() => FormPartMetadata.KcumHuBE3862DQ6Z4kJl == null;

    internal static FormPartMetadata fipUJnBEal2w0H6c2MwQ() => FormPartMetadata.KcumHuBE3862DQ6Z4kJl;

    internal static void IKXmDHBEDUfVt9t4V6q4([In] object obj0, [In] object obj1) => ((ViewItem) obj0).InitNew((ViewItem) obj1);

    internal static void W0GyG2BEtAEP2MdIpOqt([In] object obj0, Guid value) => ((AbstractMetadata) obj0).Uid = value;

    internal static void r9vdN1BEwilnsM0NPbLc([In] object obj0) => ((FormContextMetadata) obj0).GenerateNewUids();

    internal static void Sr8WMEBE4pZX8k5wW7JV() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
