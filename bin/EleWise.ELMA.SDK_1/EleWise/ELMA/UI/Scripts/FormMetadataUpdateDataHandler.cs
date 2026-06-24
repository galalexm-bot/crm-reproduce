// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Scripts.FormMetadataUpdateDataHandler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.UI.Managers;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.UI.Scripts
{
  /// <summary>
  /// Получение необходимых данных для обновления метаданных на новый рантайм для страниц и портлетов
  /// </summary>
  [Component]
  internal abstract class FormMetadataUpdateDataHandler : IMetadataUpdateDataHandler
  {
    private readonly FormMetadataItemHeaderManager formMetadataItemHeaderManager;
    internal static FormMetadataUpdateDataHandler ec5hQRlsR251611YlhP;

    /// <summary>Ctor</summary>
    /// <param name="formMetadataItemHeaderManager">Менеджер заголовков форм метаданных</param>
    protected FormMetadataUpdateDataHandler(
      FormMetadataItemHeaderManager formMetadataItemHeaderManager)
    {
      FormMetadataUpdateDataHandler.tIW1ETrFJtLYZIkwG7n();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.formMetadataItemHeaderManager = formMetadataItemHeaderManager;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 0 : 0;
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
    public IEnumerable<ScriptModule> GetScriptModules(IMetadataUpdateResult updateResult)
    {
      this.CreateComponent(updateResult);
      IFormMetadataItemHeader metadataItemHeader = this.formMetadataItemHeaderManager.Load(updateResult.Metadata.Uid);
      if (metadataItemHeader.Draft.ScriptModule == null)
        return (IEnumerable<ScriptModule>) new ScriptModule[0];
      return (IEnumerable<ScriptModule>) new ScriptModule[1]
      {
        metadataItemHeader.Draft.ScriptModule
      };
    }

    /// <inheritdoc />
    public abstract IEnumerable<Guid> GetFormUids(IMetadataUpdateResult updateResult);

    /// <summary>Создать компонент</summary>
    /// <param name="updateResult">Результат обновления метаданных</param>
    protected abstract void CreateComponent(IMetadataUpdateResult updateResult);

    internal static void tIW1ETrFJtLYZIkwG7n() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool IIPtXhlcqYaERm6hvCc() => FormMetadataUpdateDataHandler.ec5hQRlsR251611YlhP == null;

    internal static FormMetadataUpdateDataHandler Cn821alzGA40EmW8uZJ() => FormMetadataUpdateDataHandler.ec5hQRlsR251611YlhP;
  }
}
