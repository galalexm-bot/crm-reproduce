// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.Types.DefaultScriptType
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Scripts.Types
{
  /// <summary>
  /// Тип сценария по умолчанию (без параметров, с пустым результатом)
  /// </summary>
  [Component(Order = 100)]
  public class DefaultScriptType : ScriptType
  {
    public const string UID_S = "{00000000-0000-0000-0000-000000000000}";
    public static readonly Guid UID;
    private static DefaultScriptType t9rrTxbnh8ewXKM2WRNZ;

    public override Guid Uid => DefaultScriptType.UID;

    public override string Name => (string) DefaultScriptType.axbm4ybnQHmXQi6Jv6bV(DefaultScriptType.a80ApgbnfWNEjXak542S(1218962250 ^ 1218784008));

    public DefaultScriptType()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static DefaultScriptType()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            DefaultScriptType.BA6q0gbnC42lM1KhIalp();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            DefaultScriptType.UID = new Guid((string) DefaultScriptType.a80ApgbnfWNEjXak542S(272623989 ^ 272441633));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static object a80ApgbnfWNEjXak542S(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object axbm4ybnQHmXQi6Jv6bV([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool SdIigObnGtYFewPtkuUk() => DefaultScriptType.t9rrTxbnh8ewXKM2WRNZ == null;

    internal static DefaultScriptType oM4WKPbnEnmUF4bfcLIN() => DefaultScriptType.t9rrTxbnh8ewXKM2WRNZ;

    internal static void BA6q0gbnC42lM1KhIalp() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
