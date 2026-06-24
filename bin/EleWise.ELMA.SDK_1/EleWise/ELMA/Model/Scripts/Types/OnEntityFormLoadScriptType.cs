// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.Types.OnEntityFormLoadScriptType
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
  [Component(Order = 105)]
  public class OnEntityFormLoadScriptType : EntityFormScriptType
  {
    public const string UID_S = "{557D89FB-B4AD-49CC-A137-FE01E1F27CAD}";
    public static readonly Guid UID;
    internal static OnEntityFormLoadScriptType bXrwiGbkpMK94Iw3pKav;

    public override Guid Uid => OnEntityFormLoadScriptType.UID;

    public override string Name => (string) OnEntityFormLoadScriptType.CGRdKZbkw0bHVOpUmRWZ(OnEntityFormLoadScriptType.LMx3fabktASFAemd8CQt(-53329496 >> 4 ^ -3153222));

    public OnEntityFormLoadScriptType()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static OnEntityFormLoadScriptType()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            OnEntityFormLoadScriptType.UID = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -105381618));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 0 : 0;
            continue;
          case 2:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static object LMx3fabktASFAemd8CQt(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object CGRdKZbkw0bHVOpUmRWZ([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool Tw8Y86bkabtrtZcTRp0S() => OnEntityFormLoadScriptType.bXrwiGbkpMK94Iw3pKav == null;

    internal static OnEntityFormLoadScriptType YberaYbkDoZJkV5ddGkk() => OnEntityFormLoadScriptType.bXrwiGbkpMK94Iw3pKav;
  }
}
