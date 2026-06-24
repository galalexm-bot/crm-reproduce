// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Export.Services.ExportCheckingService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export.ExtensionPoints;
using EleWise.ELMA.Deploy.Export.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Deploy.Export.Services
{
  /// <summary>Сервис проверки выгружаемой конфигурации</summary>
  [Service]
  internal sealed class ExportCheckingService : IExportCheckingService
  {
    /// <summary>Правила проверки</summary>
    private IEnumerable<IExportCheckingRule> exportRules;
    internal static ExportCheckingService rx6dZqELvtMaddxTmA2r;

    /// <summary>Ctor</summary>
    /// <param name="exportRules">Правила проверки</param>
    public ExportCheckingService(IEnumerable<IExportCheckingRule> exportRules)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.exportRules = exportRules;
    }

    /// <inheritdoc />
    public IExportCheckingResult Check(IExportCheckingContext context)
    {
      int num1 = 1;
      IExportCheckingContext context1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_5;
            case 3:
              goto label_6;
            default:
              context1 = context;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 2 : 2;
              continue;
          }
        }
label_5:
        ExportCheckingService.qYMV2eELIl5aounoefKY((object) context1, ExportCheckingService.HidntwELuZ8sjyjYcA0Q(-643786247 ^ -643768849));
        num1 = 3;
      }
label_6:
      return this.Combine(this.exportRules.Select<IExportCheckingRule, IExportCheckingResult>((Func<IExportCheckingRule, IExportCheckingResult>) (rule => rule.Check(context1))));
    }

    /// <summary>Объединение результатов проверки</summary>
    private IExportCheckingResult Combine(IEnumerable<IExportCheckingResult> results)
    {
      Contract.ArgumentNotNull((object) results, z2jc63fLkugS1X8Q9N.tE1kD1vbB(589593376 ^ -1977315327 ^ -1459228851));
      BaseExportCheckingResult exportCheckingResult = new BaseExportCheckingResult();
      exportCheckingResult.AddMessages(results.SelectMany<IExportCheckingResult, ExportCheckingMessage>((Func<IExportCheckingResult, IEnumerable<ExportCheckingMessage>>) (r => (IEnumerable<ExportCheckingMessage>) r.Messages)));
      return (IExportCheckingResult) exportCheckingResult;
    }

    internal static object HidntwELuZ8sjyjYcA0Q(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void qYMV2eELIl5aounoefKY([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static bool SaegywEL8eiHFjQPOZh9() => ExportCheckingService.rx6dZqELvtMaddxTmA2r == null;

    internal static ExportCheckingService YmtqCxELZSABjkOWeW5v() => ExportCheckingService.rx6dZqELvtMaddxTmA2r;
  }
}
