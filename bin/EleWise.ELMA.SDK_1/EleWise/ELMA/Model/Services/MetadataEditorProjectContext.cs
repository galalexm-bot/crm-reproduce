// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Services.MetadataEditorProjectContext
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Services
{
  /// <summary>Контекст проекта редактора метаданных</summary>
  public class MetadataEditorProjectContext : IDisposable
  {
    private readonly IMetadataEditorService metadataEditorService;
    private readonly string oldProjectName;
    private readonly MetadataServiceContext activeContext;
    internal static MetadataEditorProjectContext fp88PcbQ9yZnBqpB1oLU;

    /// <summary>Ctor</summary>
    /// <param name="metadataEditorService">Редактор метаданных</param>
    /// <param name="projectName">Имя проекта</param>
    /// <param name="doActive">Сделать редактор метаданных текущим/активным</param>
    public MetadataEditorProjectContext(
      IMetadataEditorService metadataEditorService,
      string projectName,
      bool doActive = false)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 2:
            this.metadataEditorService = metadataEditorService;
            num = 3;
            continue;
          case 3:
            this.oldProjectName = (string) MetadataEditorProjectContext.Ah3MVObQru2i7UXbHgxM((object) metadataEditorService);
            num = 7;
            continue;
          case 4:
            MetadataEditorProjectContext.cUIif8bQ5MFgwNkLSHga((object) metadataEditorService, (object) projectName);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 0 : 0;
            continue;
          case 5:
            goto label_4;
          case 6:
            this.activeContext = new MetadataServiceContext((IMetadataService) metadataEditorService);
            num = 5;
            continue;
          case 7:
            if (MetadataEditorProjectContext.LK6OcUbQgvXQCfDI64bp((object) projectName))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 1 : 1;
              continue;
            }
            goto case 4;
          default:
            if (doActive)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 6 : 1;
              continue;
            }
            goto label_2;
        }
      }
label_4:
      return;
label_2:;
    }

    /// <inheritdoc />
    public void Dispose()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.activeContext != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 0;
              continue;
            }
            goto case 2;
          case 2:
            this.metadataEditorService.CurrentProjectName = this.oldProjectName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 2 : 3;
            continue;
          case 3:
            goto label_2;
          default:
            MetadataEditorProjectContext.vVWpCrbQjLA7d6VkAYeA((object) this.activeContext);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 2 : 0;
            continue;
        }
      }
label_2:;
    }

    internal static object Ah3MVObQru2i7UXbHgxM([In] object obj0) => (object) ((IMetadataEditorService) obj0).CurrentProjectName;

    internal static bool LK6OcUbQgvXQCfDI64bp([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static void cUIif8bQ5MFgwNkLSHga([In] object obj0, [In] object obj1) => ((IMetadataEditorService) obj0).CurrentProjectName = (string) obj1;

    internal static bool muZiwibQdnowADSbVYYL() => MetadataEditorProjectContext.fp88PcbQ9yZnBqpB1oLU == null;

    internal static MetadataEditorProjectContext thH7jcbQlq9OyKY4JftN() => MetadataEditorProjectContext.fp88PcbQ9yZnBqpB1oLU;

    internal static void vVWpCrbQjLA7d6VkAYeA([In] object obj0) => ((MetadataServiceContext) obj0).Dispose();
  }
}
