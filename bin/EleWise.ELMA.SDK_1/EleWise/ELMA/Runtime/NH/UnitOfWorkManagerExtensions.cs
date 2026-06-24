// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.UnitOfWorkManagerExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.NH
{
  public static class UnitOfWorkManagerExtensions
  {
    internal static UnitOfWorkManagerExtensions sDoQY9W6FKnPL3c4N5Tg;

    public static void Execute(this IUnitOfWorkManager manager, System.Action action)
    {
      int num1 = 2;
      IUnitOfWork unitOfWork;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_13;
          case 1:
            goto label_3;
          case 2:
            unitOfWork = manager.Create(string.Empty, true);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 1 : 1;
            continue;
          default:
            goto label_8;
        }
      }
label_13:
      return;
label_8:
      return;
label_3:
      try
      {
        UnitOfWorkManagerExtensions.QnMUEBW6otjcGgVKxnWg((object) action);
        int num2 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
          num2 = 1;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_6;
            case 1:
              UnitOfWorkManagerExtensions.WJs1OqW6bRC1xJTRGM8q((object) unitOfWork);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 0;
              continue;
            default:
              goto label_2;
          }
        }
label_6:
        return;
label_2:;
      }
      finally
      {
        if (unitOfWork != null)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_15;
              default:
                UnitOfWorkManagerExtensions.Xo50qNW6hd3xxgto7VWj((object) unitOfWork);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 1 : 1;
                continue;
            }
          }
        }
label_15:;
      }
    }

    /// <summary>Выполнить в новом Unit-of-work</summary>
    /// <param name="manager"></param>
    /// <param name="action"></param>
    public static void Execute(this IUnitOfWorkManager manager, Action<IUnitOfWork> action)
    {
      using (IUnitOfWork unitOfWork = manager.Create(string.Empty, true))
      {
        action(unitOfWork);
        unitOfWork.Commit();
      }
    }

    internal static void QnMUEBW6otjcGgVKxnWg([In] object obj0) => ((System.Action) obj0)();

    internal static void WJs1OqW6bRC1xJTRGM8q([In] object obj0) => ((IUnitOfWork) obj0).Commit();

    internal static void Xo50qNW6hd3xxgto7VWj([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static bool KcEhClW6BflFIaudj5In() => UnitOfWorkManagerExtensions.sDoQY9W6FKnPL3c4N5Tg == null;

    internal static UnitOfWorkManagerExtensions NENbP3W6WO3uAxEpZcns() => UnitOfWorkManagerExtensions.sDoQY9W6FKnPL3c4N5Tg;
  }
}
