// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.Entities.BaseMetadataUpdateDataHandler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts.Manager;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Model.Scripts.Entities
{
  /// <summary>
  /// Получение необходимых данных для обновления метаданных на новый рантайм
  /// </summary>
  [Component]
  public abstract class BaseMetadataUpdateDataHandler : IMetadataUpdateDataHandler
  {
    /// <summary>Менеджер модулей сценариев</summary>
    protected readonly ScriptModuleManager ScriptModuleManager;
    internal static BaseMetadataUpdateDataHandler UI38Shb2EBHUG5mNVW1b;

    /// <summary>Ctor</summary>
    /// <param name="scriptModuleManager">Менеджер модулей сценариев</param>
    public BaseMetadataUpdateDataHandler(ScriptModuleManager scriptModuleManager)
    {
      BaseMetadataUpdateDataHandler.OkP98Eb2COJQeOgaaQ08();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.ScriptModuleManager = scriptModuleManager;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <inheritdoc />
    public abstract bool Check(IMetadata metadata);

    /// <inheritdoc />
    public virtual IEnumerable<ScriptModule> GetScriptModules(IMetadataUpdateResult updateResult) => Enumerable.Empty<ScriptModule>();

    /// <inheritdoc />
    public virtual IEnumerable<Guid> GetFormUids(IMetadataUpdateResult updateResult) => Enumerable.Empty<Guid>();

    internal static void OkP98Eb2COJQeOgaaQ08() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool G0Qr5Hb2fGr7UlYRVg4I() => BaseMetadataUpdateDataHandler.UI38Shb2EBHUG5mNVW1b == null;

    internal static BaseMetadataUpdateDataHandler iKTDwPb2QSNg8vK53S49() => BaseMetadataUpdateDataHandler.UI38Shb2EBHUG5mNVW1b;
  }
}
