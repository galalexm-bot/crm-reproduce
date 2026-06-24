// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Reports.DiagnosticsReport
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Diagnostics.Reports
{
  /// <summary>Отчет о диагностике системы</summary>
  [Component]
  public abstract class DiagnosticsReport : IDiagnosticsReport
  {
    internal static DiagnosticsReport W4IRfnEGQYUfoKcK3vSQ;

    /// <summary>Уникальный идентификатор отчета</summary>
    public abstract Guid Uid { get; }

    /// <summary>Название отчета</summary>
    public abstract string Name { get; }

    /// <summary>Экспортировать отчет</summary>
    /// <returns>Имя файла</returns>
    public abstract string Export();

    /// <summary>Экспортировать отчет</summary>
    /// <returns>Имя файла</returns>
    public abstract void Export(string fileName);

    protected virtual string DefaultFolder => (string) DiagnosticsReport.YdI9bsEGZ6xtNwht5Zc6((object) ((DiagnosticsManager) DiagnosticsReport.UJgFNeEG8iYdQ5v7GLJU()).Folder, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(813604817 ^ 813345819));

    /// <summary>Очистить старые отчеты согласно настроек диагностики</summary>
    /// <param name="filesPattern">Шаблон файлов</param>
    protected void ClearOldReports(string filesPattern)
    {
      int num = 1;
      DiagnosticsSettings settings;
      DateTime older;
      while (true)
      {
        switch (num)
        {
          case 1:
            settings = ((DiagnosticsManager) DiagnosticsReport.UJgFNeEG8iYdQ5v7GLJU()).Settings;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 0 : 0;
            continue;
          case 2:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 1 : 3;
            continue;
          case 3:
            older = DateTime.Now.AddHours((double) -settings.ClearOldReports);
            num = 4;
            continue;
          case 4:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            IEnumerable<FileSystemInfo> enumeration = new DirectoryInfo(Path.GetDirectoryName(filesPattern)).EnumerateFileSystemInfos(Path.GetFileName(filesPattern), SearchOption.TopDirectoryOnly).Where<FileSystemInfo>((Func<FileSystemInfo, bool>) (f => DiagnosticsReport.\u003C\u003Ec__DisplayClass8_0.Dkrvto8iToQjeXeAEC9F(DiagnosticsReport.\u003C\u003Ec__DisplayClass8_0.eMAaq48iXRg0Ap89OFK9((object) f), older)));
            // ISSUE: reference to a compiler-generated field
            Action<FileSystemInfo> action1 = DiagnosticsReport.\u003C\u003Ec.\u003C\u003E9__8_1;
            Action<FileSystemInfo> action2;
            if (action1 == null)
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              DiagnosticsReport.\u003C\u003Ec.\u003C\u003E9__8_1 = action2 = (Action<FileSystemInfo>) (f => DiagnosticsReport.\u003C\u003Ec.q8mQrn8iej0T6Tr0R0ft((object) f));
            }
            else
              goto label_12;
label_11:
            enumeration.ForEach<FileSystemInfo>(action2);
            num = 5;
            continue;
label_12:
            action2 = action1;
            goto label_11;
          case 5:
            goto label_9;
          default:
            if (settings.ClearOldReports > 0)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 2 : 0;
              continue;
            }
            goto label_2;
        }
      }
label_9:
      return;
label_2:;
    }

    protected DiagnosticsReport()
    {
      DiagnosticsReport.EnLILfEGui0WG4trmoyw();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object UJgFNeEG8iYdQ5v7GLJU() => (object) DiagnosticsManager.Instance;

    internal static object YdI9bsEGZ6xtNwht5Zc6([In] object obj0, [In] object obj1) => (object) Path.Combine((string) obj0, (string) obj1);

    internal static bool BtoSLEEGC6gihdckfdJG() => DiagnosticsReport.W4IRfnEGQYUfoKcK3vSQ == null;

    internal static DiagnosticsReport SjPHdaEGvXlHFJS4IFiZ() => DiagnosticsReport.W4IRfnEGQYUfoKcK3vSQ;

    internal static void EnLILfEGui0WG4trmoyw() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
