// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.ListViewItemAddingException
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Views
{
  [Serializable]
  public class ListViewItemAddingException : Exception
  {
    private static ListViewItemAddingException igse64oONkpf7cQKkgSD;

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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 0 : 0;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 0;
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

    public ListViewItemAddingException(ViewItem parent, ViewItem item)
    {
      ListViewItemAddingException.v5fINqoOaSEN2trfEsJF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.ParentUid = ListViewItemAddingException.zvILkZoODF1PgVxbOunb((object) parent);
            num = 2;
            continue;
          case 2:
            this.ItemUid = ListViewItemAddingException.zvILkZoODF1PgVxbOunb((object) item);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
            continue;
          default:
            goto label_6;
        }
      }
label_3:
      return;
label_6:;
    }

    public override string Message => (string) ListViewItemAddingException.kaBuIdoOwRosqT6RN9ly(ListViewItemAddingException.l6GRbDoOtREif5xYEHe0(-649342099 - -1150814748 ^ 501318475), (object) this.ItemUid, (object) this.ParentUid);

    internal static bool PaFsZXoO3ej7hPBFntu5() => ListViewItemAddingException.igse64oONkpf7cQKkgSD == null;

    internal static ListViewItemAddingException RoT4yXoOpGrMI9NEU4WJ() => ListViewItemAddingException.igse64oONkpf7cQKkgSD;

    internal static void v5fINqoOaSEN2trfEsJF() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static Guid zvILkZoODF1PgVxbOunb([In] object obj0) => ((ViewItem) obj0).Uid;

    internal static object l6GRbDoOtREif5xYEHe0(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object kaBuIdoOwRosqT6RN9ly([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);
  }
}
