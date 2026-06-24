// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.CodeGeneration.PublicApi.PublicApiNodeEnumProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.CodeGeneration.PublicApi
{
  [Component(Order = 100)]
  internal class PublicApiNodeEnumProvider : IPublicApiNodeProvider
  {
    private static readonly string[] EnumObsoleteNodes;
    private static PublicApiNodeEnumProvider tYA5shhAbSwy5chTLO0r;

    public IEnumerable<IPublicApiNode> CreatePublicApiNodes() => (IEnumerable<IPublicApiNode>) new PublicApiNodeEnumProvider.\u003CCreatePublicApiNodes\u003Ed__0(-2);

    private static IEnumerable<IPublicApiNode> BuildEnumsTree(
      object parentPath,
      object groupTreeNode,
      List<EnumMetadata> metadataList,
      bool hidden)
    {
      // ISSUE: object of a compiler-generated type is created
      return (IEnumerable<IPublicApiNode>) new PublicApiNodeEnumProvider.\u003CBuildEnumsTree\u003Ed__2(-2)
      {
        \u003C\u003E3__parentPath = (string) parentPath,
        \u003C\u003E3__groupTreeNode = (MetadataTreeHelper.GroupNode) groupTreeNode,
        \u003C\u003E3__metadataList = metadataList,
        \u003C\u003E3__hidden = hidden
      };
    }

    public PublicApiNodeEnumProvider()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static PublicApiNodeEnumProvider()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            PublicApiNodeEnumProvider.EnumObsoleteNodes = new string[8]
            {
              (string) PublicApiNodeEnumProvider.tBwkr2hAE7maMwWEF1he(-649342099 - -1150814748 ^ 501261921),
              (string) PublicApiNodeEnumProvider.tBwkr2hAE7maMwWEF1he(-420743386 ^ -420967498),
              z2jc63fLkugS1X8Q9N.tE1kD1vbB(1012087039 ^ 1011893327),
              (string) PublicApiNodeEnumProvider.tBwkr2hAE7maMwWEF1he(-1852837372 ^ -1853059472),
              z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488685823),
              (string) PublicApiNodeEnumProvider.tBwkr2hAE7maMwWEF1he(-2138958856 ^ -2139001050),
              z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317574744),
              (string) PublicApiNodeEnumProvider.tBwkr2hAE7maMwWEF1he(572119659 - -337058038 ^ 909348759)
            };
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 0;
            continue;
          case 2:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 0 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static bool JNbkvchAhUteF07QLUK9() => PublicApiNodeEnumProvider.tYA5shhAbSwy5chTLO0r == null;

    internal static PublicApiNodeEnumProvider rbCQfQhAGeGmBdQq89DR() => PublicApiNodeEnumProvider.tYA5shhAbSwy5chTLO0r;

    internal static object tBwkr2hAE7maMwWEF1he(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}
