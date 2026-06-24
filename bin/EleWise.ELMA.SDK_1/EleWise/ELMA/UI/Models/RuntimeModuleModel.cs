// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Models.RuntimeModuleModel
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.UI.Models
{
  /// <summary>Модель данных модуля</summary>
  public sealed class RuntimeModuleModel
  {
    internal static RuntimeModuleModel bhNmCGBW5cbblVB6RvY3;

    /// <summary>Метаданные модуля</summary>
    public ModuleMetadataItem MetadataItem
    {
      get => this.\u003CMetadataItem\u003Ek__BackingField;
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
              this.\u003CMetadataItem\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 0;
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

    /// <summary>Клиентский скрипт</summary>
    public ClientScriptModel Script
    {
      get => this.\u003CScript\u003Ek__BackingField;
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
              this.\u003CScript\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 0 : 0;
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

    public RuntimeModuleModel()
    {
      RuntimeModuleModel.vxgjvOBWLGrpmn086RDi();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool alpNxcBWjNcpRRX4JFRv() => RuntimeModuleModel.bhNmCGBW5cbblVB6RvY3 == null;

    internal static RuntimeModuleModel aeEOchBWYV5Amd63p8Z0() => RuntimeModuleModel.bhNmCGBW5cbblVB6RvY3;

    internal static void vxgjvOBWLGrpmn086RDi() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
