// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.Modules.ModuleConfigImportExtension
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Deploy.Import.ExtensionPoints;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Deploy.Import.Modules
{
  /// <summary>Расширение для импорта модулей</summary>
  internal sealed class ModuleConfigImportExtension : ConfigImportExtension
  {
    internal static ModuleConfigImportExtension ksWjKwEMf3d2d1h8mrBr;

    /// <inheritdoc />
    public override void OnPostCompleteTest(PostCompleteTestImportParameters parameters)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_4;
          case 1:
            if (ModuleConfigImportExtension.KvDhXWEMvTcDw3PkJMtv((object) parameters) is TestModuleImportSettings moduleImportSettings)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 1 : 3;
              continue;
            }
            goto label_10;
          case 2:
            base.OnPostCompleteTest(parameters);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 1 : 1;
            continue;
          case 3:
            if (!ModuleConfigImportExtension.zv7Y9eEM8rEgae7LqOUt((object) moduleImportSettings))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 0;
              continue;
            }
            parameters.ServiceData.Add((string) ModuleConfigImportExtension.C3vviYEMZd1wgv1X8aQM(1021410165 ^ 1021691845), string.Empty);
            num = 4;
            continue;
          case 4:
            goto label_2;
          default:
            goto label_11;
        }
      }
label_4:
      return;
label_2:
      return;
label_11:
      return;
label_10:;
    }

    public ModuleConfigImportExtension()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object KvDhXWEMvTcDw3PkJMtv([In] object obj0) => (object) ((PostCompleteTestImportParameters) obj0).ImportSettings;

    internal static bool zv7Y9eEM8rEgae7LqOUt([In] object obj0) => ((TestModuleImportSettings) obj0).Incompatible;

    internal static object C3vviYEMZd1wgv1X8aQM(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool CN5ROnEMQFVSvZX1dAEC() => ModuleConfigImportExtension.ksWjKwEMf3d2d1h8mrBr == null;

    internal static ModuleConfigImportExtension Kd3H2UEMCApmrOmbtLWn() => ModuleConfigImportExtension.ksWjKwEMf3d2d1h8mrBr;
  }
}
