// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.CodeGeneration.PublicApi.PublicApiFilterHelpers
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.CodeGeneration.PublicApi
{
  public class PublicApiFilterHelpers : IPublicApiNode
  {
    private bool isDelta;
    public const string ClassName = "PublicApiFilterHelpers";
    private static PublicApiFilterHelpers uVIEinhHxOpSoA2cEIEn;

    public string ParentPath => (string) PublicApiFilterHelpers.pPAFZThHyjfGq2mgs5fO(993438473 ^ 993382425);

    public static string Path => (string) PublicApiFilterHelpers.pPAFZThHyjfGq2mgs5fO(-649342099 - -1150814748 ^ 501261999);

    string IPublicApiNode.Path => (string) PublicApiFilterHelpers.groDyphHMIXSLFZK9q7a();

    public IEnumerable<ISyntaxNode> Generate(
      IDictionary<string, IEnumerable<IPublicApiNode>> tree)
    {
      // ISSUE: object of a compiler-generated type is created
      return (IEnumerable<ISyntaxNode>) new PublicApiFilterHelpers.\u003CGenerate\u003Ed__8(-2)
      {
        \u003C\u003E4__this = this,
        \u003C\u003E3__tree = tree
      };
    }

    /// <summary>Установить флаг дельта-сборки</summary>
    internal void SetIsDelta()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.isDelta = true;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    private IEnumerable<ISyntaxNode> BaseGenericFilter() => (IEnumerable<ISyntaxNode>) new PublicApiFilterHelpers.\u003CBaseGenericFilter\u003Ed__10(-2)
    {
      \u003C\u003E4__this = this
    };

    public PublicApiFilterHelpers()
    {
      PublicApiFilterHelpers.By7p1JhHJKCegp8WNs6w();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object pPAFZThHyjfGq2mgs5fO(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool EthclihH01oXotKVkRmV() => PublicApiFilterHelpers.uVIEinhHxOpSoA2cEIEn == null;

    internal static PublicApiFilterHelpers vkrfILhHmBNxawv8exJQ() => PublicApiFilterHelpers.uVIEinhHxOpSoA2cEIEn;

    internal static object groDyphHMIXSLFZK9q7a() => (object) PublicApiFilterHelpers.Path;

    internal static void By7p1JhHJKCegp8WNs6w() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
