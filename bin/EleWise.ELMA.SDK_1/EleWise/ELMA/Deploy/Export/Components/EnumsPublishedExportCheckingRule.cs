// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Export.Components.EnumsPublishedExportCheckingRule
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export.Models;
using EleWise.ELMA.Model.Metadata.Managers;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Deploy.Export.Components
{
  /// <summary>
  /// Правило проверки на наличие опубликованной версии для перечислений
  /// </summary>
  [Component]
  internal sealed class EnumsPublishedExportCheckingRule : ObjectsPublishedExportCheckingRule
  {
    internal static EnumsPublishedExportCheckingRule JHLZW0EsBHIjjeWujgk0;

    /// <summary>Ctor</summary>
    /// <param name="metadataItemHeaderManager">Менеджер заголовков метаданных</param>
    public EnumsPublishedExportCheckingRule(
      MetadataItemHeaderManager metadataItemHeaderManager)
    {
      EnumsPublishedExportCheckingRule.xyF33kEsbsKOsl9S9q7S();
      // ISSUE: explicit constructor call
      base.\u002Ector(metadataItemHeaderManager);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <inheritdoc />
    public override IExportCheckingResult Check(IExportCheckingContext context)
    {
      int num1 = 8;
      BaseExportCheckingResult result;
      while (true)
      {
        int num2 = num1;
        object obj;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (objectsExportSetting.Enums != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 0 : 0;
                continue;
              }
              goto label_12;
            case 2:
              if (!(obj is ObjectsExportSetting objectsExportSetting))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 6 : 6;
                continue;
              }
              goto case 1;
            case 3:
            case 5:
            case 6:
              goto label_12;
            case 4:
              if (context.Settings.CustomSettings.TryGetValue(ObjectsExportConsts.ExportExtensionUid, out obj))
                goto case 2;
              else
                goto label_10;
            case 7:
              result = new BaseExportCheckingResult();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 4 : 4;
              continue;
            case 8:
              EnumsPublishedExportCheckingRule.tlvDU4EsGletVRlpTNxt((object) context, EnumsPublishedExportCheckingRule.sx9oTXEshjnwQLOPLnqk(979449278 ^ 979464616));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 7 : 4;
              continue;
            default:
              this.Check((IEnumerable<Guid>) objectsExportSetting.Enums, result);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 3 : 1;
              continue;
          }
        }
label_10:
        num1 = 5;
      }
label_12:
      return (IExportCheckingResult) result;
    }

    /// <inheritdoc />
    protected override string PublishedMissed(string displayName) => EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477469224), (object) displayName);

    internal static void xyF33kEsbsKOsl9S9q7S() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool MhOkBWEsW2lW7RsEAb0C() => EnumsPublishedExportCheckingRule.JHLZW0EsBHIjjeWujgk0 == null;

    internal static EnumsPublishedExportCheckingRule uTJ5NmEsoXbIRoKIp2lR() => EnumsPublishedExportCheckingRule.JHLZW0EsBHIjjeWujgk0;

    internal static object sx9oTXEshjnwQLOPLnqk(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void tlvDU4EsGletVRlpTNxt([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);
  }
}
