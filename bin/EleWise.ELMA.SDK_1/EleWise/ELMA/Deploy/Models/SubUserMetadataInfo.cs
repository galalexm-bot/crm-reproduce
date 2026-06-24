// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Models.SubUserMetadataInfo
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace EleWise.ELMA.Deploy.Models
{
  /// <summary>
  /// Дополнительная информация о вложеных пользовательских метаданных
  /// </summary>
  public sealed class SubUserMetadataInfo
  {
    /// <summary>Список модулей скриптов</summary>
    /// <remarks>Ключ - название свойства, содержащего скрипт, Значение - идентификатор скрипта</remarks>
    public Dictionary<string, Guid> ScriptModules;
    private static SubUserMetadataInfo NO6FTjEwLbR6ycjaSh61;

    [EditorBrowsable(EditorBrowsableState.Never)]
    public SubUserMetadataInfo(IGroupedMetadata metadata)
    {
      SubUserMetadataInfo.nYGW3HEwc1A3x1IrTI83();
      // ISSUE: explicit constructor call
      this.\u002Ector((IMetadata) metadata);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="metadata">Метаданные</param>
    public SubUserMetadataInfo(IMetadata metadata)
    {
      SubUserMetadataInfo.nYGW3HEwc1A3x1IrTI83();
      this.ScriptModules = new Dictionary<string, Guid>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.Metadata = metadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Метаданные</summary>
    public IMetadata Metadata { get; }

    internal static void nYGW3HEwc1A3x1IrTI83() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool kbyu7SEwUF3Ik92MZJbO() => SubUserMetadataInfo.NO6FTjEwLbR6ycjaSh61 == null;

    internal static SubUserMetadataInfo UAG1HSEwsWcxYwtrwHCv() => SubUserMetadataInfo.NO6FTjEwLbR6ycjaSh61;
  }
}
