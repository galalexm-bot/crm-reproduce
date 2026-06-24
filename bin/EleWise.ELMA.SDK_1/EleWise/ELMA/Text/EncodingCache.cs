// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Text.EncodingCache
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System.Runtime.InteropServices;
using System.Text;

namespace EleWise.ELMA.Text
{
  /// <summary>
  /// Кеш <see cref="T:System.Text.Encoding" />
  /// </summary>
  public static class EncodingCache
  {
    /// <summary>Кодировка UTF8 без эмиссии идентификатора</summary>
    public static UTF8Encoding UTF8WithoutEmitIdentifier;
    /// <summary>Кодировка 1251</summary>
    public static Encoding Win1251Encoding;
    private static EncodingCache uHjOYtBPRpXhFLAeJSjc;

    static EncodingCache()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            EncodingCache.yiWgydBPX9bKGMXW7ji4();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 0;
            continue;
          case 2:
            EncodingCache.Win1251Encoding = (Encoding) EncodingCache.lxMyU6BPTkEsOXsZtMva(1251);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 0 : 3;
            continue;
          case 3:
            goto label_2;
          default:
            EncodingCache.UTF8WithoutEmitIdentifier = new UTF8Encoding(false);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static void yiWgydBPX9bKGMXW7ji4() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object lxMyU6BPTkEsOXsZtMva([In] int obj0) => (object) Encoding.GetEncoding(obj0);

    internal static bool LXJdaPBPq9qhXyIqWBwv() => EncodingCache.uHjOYtBPRpXhFLAeJSjc == null;

    internal static EncodingCache k7AAXiBPKD5sQQnaIc8E() => EncodingCache.uHjOYtBPRpXhFLAeJSjc;
  }
}
