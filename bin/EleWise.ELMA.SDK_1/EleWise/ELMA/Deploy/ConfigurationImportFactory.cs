// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.ConfigurationImportFactory
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Import;
using j3AmrhgkCleVTGdEwA;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Deploy
{
  /// <inheritdoc />
  [Service]
  internal sealed class ConfigurationImportFactory : IConfigurationImportFactory
  {
    private readonly IConfigurationImportInternalFactory internalFactory;
    private static ConfigurationImportFactory N8Z5KKEOA63usFKcoT4f;

    /// <summary>Ctor</summary>
    /// <param name="internalFactory">Внутренний сервис-фабрика</param>
    public ConfigurationImportFactory(
      IConfigurationImportInternalFactory internalFactory)
    {
      ConfigurationImportFactory.OULAGYEO0ToRwGNBjA2i();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.internalFactory = internalFactory;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <inheritdoc />
    public IConfigurationTester CreateTester(IImportSettings importSettings) => (IConfigurationTester) this.internalFactory.CreateTester(importSettings);

    /// <inheritdoc />
    public IConfigurationImporter CreateImporter(IImportSettings importSettings) => (IConfigurationImporter) ConfigurationImportFactory.y3PjDHEOmb4mVh1Jlk5t((object) this.internalFactory, (object) importSettings);

    internal static void OULAGYEO0ToRwGNBjA2i() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool QyR7L9EO7u0lWJt5JJju() => ConfigurationImportFactory.N8Z5KKEOA63usFKcoT4f == null;

    internal static ConfigurationImportFactory uyMmwuEOxaEYhHYeVdXX() => ConfigurationImportFactory.N8Z5KKEOA63usFKcoT4f;

    internal static object y3PjDHEOmb4mVh1Jlk5t([In] object obj0, [In] object obj1) => (object) ((IConfigurationImportInternalFactory) obj0).CreateImporter((IImportSettings) obj1);
  }
}
