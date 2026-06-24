// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Files.Previews.FilePreviewServiceProviderManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Runtime.Providers;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;

namespace EleWise.ELMA.Files.Previews
{
  /// <summary>
  /// Менеджер провайдеров <see cref="T:EleWise.ELMA.Files.Previews.FilePreviewServiceProvider" />.
  /// Регистрирует провайдер как <see cref="T:EleWise.ELMA.Files.Previews.IFilePreviewServiceProvider" />
  /// </summary>
  public class FilePreviewServiceProviderManager : 
    GenericProviderManager<FilePreviewServiceProvider, IFilePreviewServiceProvider>
  {
    /// <summary>Строковое представление идентификатора</summary>
    public const string UID_S = "{43075980-BB17-437D-B361-94DFBE2667D4}";
    /// <summary>Идентификатор провайдера</summary>
    public static readonly Guid UID;
    internal static FilePreviewServiceProviderManager qcruRVG2xtP1A3kqnMRN;

    /// <summary>Uid провайдера</summary>
    public override Guid Uid => FilePreviewServiceProviderManager.UID;

    /// <summary>Имя провайдера</summary>
    public override string Name => (string) FilePreviewServiceProviderManager.XoMgKLG2yWh7bOTNb0mX(-70007027 ^ -70245623);

    public FilePreviewServiceProviderManager()
    {
      FilePreviewServiceProviderManager.orda2UG2Mo7Dq8xOIl7M();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static FilePreviewServiceProviderManager()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            FilePreviewServiceProviderManager.orda2UG2Mo7Dq8xOIl7M();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            FilePreviewServiceProviderManager.UID = new Guid((string) FilePreviewServiceProviderManager.XoMgKLG2yWh7bOTNb0mX(-1867198571 ^ -1867043927));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 1 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static object XoMgKLG2yWh7bOTNb0mX(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool x3kFHVG20q511Sh3yREM() => FilePreviewServiceProviderManager.qcruRVG2xtP1A3kqnMRN == null;

    internal static FilePreviewServiceProviderManager cmDdE7G2mnE7rgaOdM1j() => FilePreviewServiceProviderManager.qcruRVG2xtP1A3kqnMRN;

    internal static void orda2UG2Mo7Dq8xOIl7M() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
