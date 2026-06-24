// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.Components.DataClassMetadataCompatibilityChecker
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Metadata.Components
{
  /// <inheritdoc />
  [Component]
  internal sealed class DataClassMetadataCompatibilityChecker : 
    CompatibilityChecker<DataClassDependency>
  {
    private readonly IDependencyService dependencyService;
    private static DataClassMetadataCompatibilityChecker SkL4rShWo1hKkJ1DfiHk;

    /// <summary>Ctor</summary>
    /// <param name="dependencyService">Сервис для работы с зависимостями</param>
    public DataClassMetadataCompatibilityChecker(IDependencyService dependencyService)
    {
      DataClassMetadataCompatibilityChecker.xOMfMphWGiEEHWXvqIuK();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.dependencyService = dependencyService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <inheritdoc />
    public override ICollection<string> CheckCompatibility(
      DataClassDependency old,
      DataClassDependency @new)
    {
      Contract.NotNull((object) old, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1445902765 ^ -1980277732 ^ 539434499));
      Contract.NotNull((object) @new, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-688192331 - 435440695 ^ -1123638716));
      return (ICollection<string>) this.dependencyService.CheckDataClassCompatibility(old, @new).Errors;
    }

    internal static void xOMfMphWGiEEHWXvqIuK() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool GZA5BRhWbFDm55vfUjQS() => DataClassMetadataCompatibilityChecker.SkL4rShWo1hKkJ1DfiHk == null;

    internal static DataClassMetadataCompatibilityChecker Yg9s3rhWhkugYXplTLqA() => DataClassMetadataCompatibilityChecker.SkL4rShWo1hKkJ1DfiHk;
  }
}
