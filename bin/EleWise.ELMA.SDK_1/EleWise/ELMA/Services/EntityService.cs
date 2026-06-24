// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.EntityService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Services
{
  [Service]
  public class EntityService
  {
    private static EntityService i6FWJjB75H5HMh8Nftmm;

    /// <summary>
    /// Управление проверкой на загрузку мягкоудаленных объектов
    /// </summary>
    public RunWithSoftDeletableService RunWithSoftDeletableService
    {
      get => this.\u003CRunWithSoftDeletableService\u003Ek__BackingField;
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
              this.\u003CRunWithSoftDeletableService\u003Ek__BackingField = value;
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

    /// <summary>Запуск действия с отключненной проверкой на удаление</summary>
    /// <param name="action"></param>
    public void RunWithSoftDeletable(System.Action action)
    {
      int num1 = 1;
      bool flag;
      while (true)
      {
        switch (num1)
        {
          case 1:
            flag = false;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_14;
          default:
            goto label_2;
        }
      }
label_14:
      return;
label_2:
      try
      {
        flag = EntityService.YdOrm3B7LoK6fHx0hfZC((object) this.RunWithSoftDeletableService);
        int num2 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
          num2 = 0;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (flag)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 0;
                continue;
              }
              goto case 2;
            case 2:
              EntityService.q1duxGB7UU03xh56wOUi((object) this.RunWithSoftDeletableService, true);
              num2 = 3;
              continue;
            case 4:
              goto label_13;
            default:
              EntityService.PpWbafB7sZNnlFCAWgBn((object) action);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 4 : 4;
              continue;
          }
        }
label_13:;
      }
      finally
      {
        int num3;
        if (flag)
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 0 : 0;
        else
          goto label_15;
label_12:
        switch (num3)
        {
          case 2:
            break;
          default:
        }
label_15:
        EntityService.q1duxGB7UU03xh56wOUi((object) this.RunWithSoftDeletableService, false);
        num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
        {
          num3 = 1;
          goto label_12;
        }
        else
          goto label_12;
      }
    }

    public EntityService()
    {
      EntityService.w3UTE7B7cQpm5Zvw3pWV();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool k1QkMBB7j4rgAM7eRf9Y() => EntityService.i6FWJjB75H5HMh8Nftmm == null;

    internal static EntityService BaaEroB7YtCHH0hjyZvM() => EntityService.i6FWJjB75H5HMh8Nftmm;

    internal static bool YdOrm3B7LoK6fHx0hfZC([In] object obj0) => ((RunWithSoftDeletableService) obj0).Turned;

    internal static void q1duxGB7UU03xh56wOUi([In] object obj0, bool value) => ((RunWithSoftDeletableService) obj0).Turned = value;

    internal static void PpWbafB7sZNnlFCAWgBn([In] object obj0) => ((System.Action) obj0)();

    internal static void w3UTE7B7cQpm5Zvw3pWV() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
