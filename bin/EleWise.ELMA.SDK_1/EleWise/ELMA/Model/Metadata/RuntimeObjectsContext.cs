// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.RuntimeObjectsContext
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>Пустой контекст проверки на связанность метаданных</summary>
  public class RuntimeObjectsContext
  {
    internal static RuntimeObjectsContext Ibv2FIbNQYOo9sw4ySR1;

    /// <summary>Загруженные в контекст проверки метаданные</summary>
    public IDictionary<Guid, IMetadata> LoadedMetadata { get; }

    /// <summary>Загруженные в контекст проверки данные</summary>
    public IDictionary<Guid, object> LoadedData { get; }

    /// <summary>
    /// Загруженные в контекст проверки данные со строковым ключем
    /// </summary>
    public IDictionary<string, object> LoadedWithStringKey { get; }

    /// <summary>Отмеченные объекты</summary>
    public ICollection<ILinkedObject> CheckedObjects { get; }

    /// <summary>Ctor</summary>
    public RuntimeObjectsContext()
    {
      RuntimeObjectsContext.gHPgE4bN8H00BfSye3OM();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.LoadedMetadata = (IDictionary<Guid, IMetadata>) new Dictionary<Guid, IMetadata>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 2 : 2;
            continue;
          case 2:
            this.LoadedData = (IDictionary<Guid, object>) new Dictionary<Guid, object>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 0 : 0;
            continue;
          case 3:
            goto label_2;
          case 4:
            this.CheckedObjects = (ICollection<ILinkedObject>) new List<ILinkedObject>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 1 : 1;
            continue;
          default:
            this.LoadedWithStringKey = (IDictionary<string, object>) new Dictionary<string, object>();
            num = 3;
            continue;
        }
      }
label_2:;
    }

    internal static void gHPgE4bN8H00BfSye3OM() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool FR2mMkbNC75r6JSXOD57() => RuntimeObjectsContext.Ibv2FIbNQYOo9sw4ySR1 == null;

    internal static RuntimeObjectsContext asyVeZbNvdY3OD5ZKEoN() => RuntimeObjectsContext.Ibv2FIbNQYOo9sw4ySR1;
  }
}
