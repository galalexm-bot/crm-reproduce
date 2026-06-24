// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.Toolbar.ToolbarItemListAddingException
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Views.Toolbar
{
  [Serializable]
  public class ToolbarItemListAddingException : Exception
  {
    internal static ToolbarItemListAddingException qCCHTxotO3vcwhWflRNF;

    public Guid ParentUid
    {
      get => this.\u003CParentUid\u003Ek__BackingField;
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
              this.\u003CParentUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 0 : 0;
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

    public Guid ItemUid
    {
      get => this.\u003CItemUid\u003Ek__BackingField;
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
              this.\u003CItemUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
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

    public ToolbarItemListAddingException(ToolbarItem parent, ToolbarItem item)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            this.ParentUid = parent.Uid;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
            continue;
          default:
            this.ItemUid = ToolbarItemListAddingException.HuARXJotPMPlAxWVyfV5((object) item);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 1 : 0;
            continue;
        }
      }
label_2:;
    }

    public override string Message => (string) ToolbarItemListAddingException.Or1MvYot10tXN0SpFh3P((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1290212282 ^ -644262414 ^ 1787024592), (object) this.ItemUid, (object) this.ParentUid);

    internal static bool Blq656ot254DRY8U7aNO() => ToolbarItemListAddingException.qCCHTxotO3vcwhWflRNF == null;

    internal static ToolbarItemListAddingException VZjmwuoteOVbfFERuG3j() => ToolbarItemListAddingException.qCCHTxotO3vcwhWflRNF;

    internal static Guid HuARXJotPMPlAxWVyfV5([In] object obj0) => ((ToolbarItem) obj0).Uid;

    internal static object Or1MvYot10tXN0SpFh3P([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);
  }
}
