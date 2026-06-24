// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Helpers.TablePartHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Services;
using SG9KiyIbtdgGDf12qr;
using System;

namespace EleWise.ELMA.Helpers
{
  public static class TablePartHelper
  {
    internal static TablePartHelper TQau6ehL383pNcbTf7mb;

    public static long GetLastTemporaryId() => ContextVars.GetOrAdd<long>((string) TablePartHelper.yXGMJihLDujRb9bF6aWJ(-1638402543 ^ -1638638033), (Func<long>) (() => 0L));

    public static void SetLastTemporaryId(long id)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ContextVars.Set<long>((string) TablePartHelper.yXGMJihLDujRb9bF6aWJ(-1852837372 ^ -1853072838), id);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public static long GetNextTemporaryId()
    {
      long id = TablePartHelper.GetLastTemporaryId() - 1L;
      TablePartHelper.WT40Z9hLtaKt2cKQ14Tp(id);
      return id;
    }

    internal static object yXGMJihLDujRb9bF6aWJ(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool e5oUbwhLp7Po3cCAwrCs() => TablePartHelper.TQau6ehL383pNcbTf7mb == null;

    internal static TablePartHelper NkbbUGhLavR1yTyD1ZcC() => TablePartHelper.TQau6ehL383pNcbTf7mb;

    internal static void WT40Z9hLtaKt2cKQ14Tp(long id) => TablePartHelper.SetLastTemporaryId(id);
  }
}
