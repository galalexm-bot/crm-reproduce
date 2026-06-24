// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.SystemImportSettings
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Deploy.Import
{
  /// <summary>Настройки системного кастомного импорта</summary>
  /// <remarks>Импортирует подготовленную в виде текста конфигурацию. Не предусматривает этап тестирования и импорта метаданных</remarks>
  [Serializable]
  public sealed class SystemImportSettings : ISystemImportSettings, IImportSettings
  {
    private static SystemImportSettings qrtg89E0fWly6lp6ERJj;

    /// <summary>Ctor</summary>
    /// <param name="fileText">Импортируемый текст</param>
    public SystemImportSettings(string fileText)
    {
      SystemImportSettings.JfZSpUE0vunmsXkUKjVt();
      // ISSUE: reference to a compiler-generated field
      this.\u003CTestResult\u003Ek__BackingField = (ICollection<TestImportMessages>) new List<TestImportMessages>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.FileText = fileText;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Текст файла экспорта конфигурации</summary>
    public string FileText
    {
      get => this.\u003CFileText\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CFileText\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <inheritdoc />
    public int ImportStep
    {
      get => 2;
      set => throw new NotImplementedException();
    }

    /// <inheritdoc />
    public ICollection<TestImportMessages> TestResult { get; set; }

    internal static void JfZSpUE0vunmsXkUKjVt() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool HnMW34E0Q7L12QAVOdh9() => SystemImportSettings.qrtg89E0fWly6lp6ERJj == null;

    internal static SystemImportSettings Y3e0oCE0C9eM4chRngFj() => SystemImportSettings.qrtg89E0fWly6lp6ERJj;
  }
}
