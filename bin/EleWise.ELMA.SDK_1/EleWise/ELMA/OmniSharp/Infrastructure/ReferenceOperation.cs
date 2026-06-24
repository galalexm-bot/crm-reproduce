// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.OmniSharp.Infrastructure.ReferenceOperation
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;

namespace EleWise.ELMA.OmniSharp.Infrastructure
{
  /// <summary>Операция omnisharp с дополнительными ссылками</summary>
  internal class ReferenceOperation
  {
    private volatile bool isSyncingNow;
    internal static ReferenceOperation mkolDhWriCQMTOL3qdLb;

    /// <summary>Ctor</summary>
    /// <param name="operation">Вид операции (адрес точки входа)</param>
    /// <param name="assemblies">Набор сборок .dll</param>
    /// <param name="webReferences">Набор веб-сервисов (исходные файлы)</param>
    public ReferenceOperation(
      string operation,
      IEnumerable<string> assemblies,
      IEnumerable<string> webReferences)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Operation = operation;
      this.Assemblies = assemblies;
      this.WebReferences = webReferences;
    }

    /// <summary>Вид операции (адрес точки входа)</summary>
    public string Operation { get; }

    /// <summary>Набор сборок .dll</summary>
    public IEnumerable<string> Assemblies { get; }

    /// <summary>Набор веб-сервисов (исходные файлы)</summary>
    public IEnumerable<string> WebReferences { get; }

    /// <summary>Производится ли синхронизация этой операции сейчас?</summary>
    public bool IsSyncingNow
    {
      get => this.isSyncingNow;
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
              this.isSyncingNow = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 0;
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

    internal static bool v1GvXdWrRi411KkjoCo5() => ReferenceOperation.mkolDhWriCQMTOL3qdLb == null;

    internal static ReferenceOperation RB5QaVWrqCeZg47lJMhQ() => ReferenceOperation.mkolDhWriCQMTOL3qdLb;
  }
}
