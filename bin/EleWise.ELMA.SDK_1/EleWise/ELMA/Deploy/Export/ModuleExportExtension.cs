// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Export.ModuleExportExtension
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.ExtensionPoints;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Deploy.Export
{
  /// <summary>Расширение экспорта модулей на DevServer</summary>
  internal sealed class ModuleExportExtension
  {
    private static ModuleExportExtension Cg3PPvEg1CCmnCCmrtjp;

    public ModuleExportExtension()
    {
      ModuleExportExtension.ljan8FEgpYswCuxbUVCl();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void ljan8FEgpYswCuxbUVCl() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool wYMEZeEgNZGV9bWDmsS7() => ModuleExportExtension.Cg3PPvEg1CCmnCCmrtjp == null;

    internal static ModuleExportExtension cP87UFEg3INdSAqLWorR() => ModuleExportExtension.Cg3PPvEg1CCmnCCmrtjp;

    /// <summary>Реализация "Важных" данных</summary>
    [Component]
    private sealed class ImportantData : IImportantData
    {
      internal static object c6BTB287Hi8M2q1R52cK;

      /// <inheritdoc />
      public Guid Uid => ModuleExportConsts.ModulePacketImportantDataUid;

      /// <inheritdoc />
      public IEnumerable<Version> Versions { get; }

      /// <inheritdoc />
      public string Module => (string) null;

      public ImportantData()
      {
        ModuleExportExtension.ImportantData.cmmWwS87xYX3dFLFnO4i();
        this.Versions = (IEnumerable<Version>) new Version[1]
        {
          new Version(4, 1, 6)
        };
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static void cmmWwS87xYX3dFLFnO4i() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool klv1j887A2ovpJGXmUX5() => ModuleExportExtension.ImportantData.c6BTB287Hi8M2q1R52cK == null;

      internal static ModuleExportExtension.ImportantData OULCgP877Kvjv6xgt7w5() => (ModuleExportExtension.ImportantData) ModuleExportExtension.ImportantData.c6BTB287Hi8M2q1R52cK;
    }
  }
}
