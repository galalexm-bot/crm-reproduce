// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Scripts.Types.PageScriptType
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.UI.Scripts.Types
{
  /// <summary>Тип сценария для страницы</summary>
  public class PageScriptType : FormScriptType
  {
    public const string UID_S = "{C81E2965-5096-4135-A4BD-06CD87F74B8D}";
    public static readonly Guid UID;
    private static PageScriptType C0j0tfLZYKmaUoZM4Uk;

    public override Guid Uid => PageScriptType.UID;

    public override string Name => (string) PageScriptType.dTYDd7LSbrxdeH3IsB9(PageScriptType.McJMUlLVKJpODmPZBnX(-1867198571 ^ -1867251541));

    protected override void SetMethodParameters(
      ScriptMethodDeclaration declaration,
      FormMetadata formMetadata,
      FormContextMetadata contextMetadata,
      FormTablePartMetadata tablePartMetadata,
      IDictionary<string, object> generationParams)
    {
      Contract.ArgumentNotNull((object) declaration, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1654249598 >> 2 ^ 413579635));
      Contract.ArgumentNotNull((object) formMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398663332 ^ -398709030));
      Contract.ArgumentNotNull((object) contextMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(222162814 ^ 222109916));
      if (tablePartMetadata != null)
        declaration.Parameters.Add(new ScriptMethodParameter(z2jc63fLkugS1X8Q9N.tE1kD1vbB(694673736 ^ -23604109 ^ -672096955), string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1925118608 << 2 ^ -889510524), (object) formMetadata.Name, (object) tablePartMetadata.Name)));
      else
        declaration.Parameters.Add(new ScriptMethodParameter(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-643786247 ^ -643803643), string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1514961705 ^ 1514973985), (object) formMetadata.Name, (object) contextMetadata.Name)));
    }

    public PageScriptType()
    {
      PageScriptType.vF2PQnLilRsjxRp4wqj();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static PageScriptType()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            PageScriptType.UID = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-441065788 ^ -2092910478 ^ 1727379086));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 0 : 0;
            continue;
          case 2:
            PageScriptType.vF2PQnLilRsjxRp4wqj();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static object McJMUlLVKJpODmPZBnX(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object dTYDd7LSbrxdeH3IsB9([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool mjmas9Lu5UQ7BTDfbQ5() => PageScriptType.C0j0tfLZYKmaUoZM4Uk == null;

    internal static PageScriptType jgYKQ7LIhD7GI2DxMs2() => PageScriptType.C0j0tfLZYKmaUoZM4Uk;

    internal static void vF2PQnLilRsjxRp4wqj() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
