// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Helpers.CheckModuleHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Signatures;
using EleWise.ELMA.UI.Models;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.UI.Helpers
{
  /// <summary>Хэлпер для проверки модулей</summary>
  internal static class CheckModuleHelper
  {
    internal static CheckModuleHelper DhFJcHB8UrcpvG5wki5X;

    /// <summary>
    /// Проверка на совместимость зависимости модуля по ее сигнатуре
    /// </summary>
    /// <param name="dependency">Зависимость модуля</param>
    /// <param name="signature">Сигнатура модуля</param>
    /// <param name="moduleUid">Уникальный идентификатор проверяемого модуля в зависимостях</param>
    /// <returns>Результат проверки</returns>
    public static CompatibilityResult CheckSignatures(
      ModuleDependency dependency,
      ModuleSignature signature,
      Guid moduleUid)
    {
      int num = 1;
      CompatibilityResult compatibilityResult1;
      CompatibilityResult compatibilityResult2;
      CompatibilityResult compatibilityResult3;
      Guid moduleUid1;
      while (true)
      {
        switch (num)
        {
          case 1:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 0 : 0;
            continue;
          case 2:
            if (CheckModuleHelper.M1MCkxB8zMiU9sj5qTDl((object) compatibilityResult2))
            {
              num = 3;
              continue;
            }
            goto label_4;
          case 3:
            // ISSUE: reference to a compiler-generated method
            compatibilityResult3 = CheckModuleHelper.CheckDataClasses(dependency.DataClasses.Where<DataClassDependency>((Func<DataClassDependency, bool>) (c => CheckModuleHelper.\u003C\u003Ec__DisplayClass0_0.dGGsYXQGPKKPCRSsf9Ba(c.ModuleUid, moduleUid1))), (IEnumerable<DataClassDependency>) signature.DataClasses);
            num = 9;
            continue;
          case 4:
            goto label_9;
          case 5:
            goto label_6;
          case 6:
            if (!compatibilityResult1.IsValid)
            {
              num = 5;
              continue;
            }
            goto label_7;
          case 7:
            goto label_4;
          case 8:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            compatibilityResult2 = CheckModuleHelper.CheckComponents(dependency.Components.Where<ComponentDependency>((Func<ComponentDependency, bool>) (c => CheckModuleHelper.\u003C\u003Ec__DisplayClass0_0.dGGsYXQGPKKPCRSsf9Ba(CheckModuleHelper.\u003C\u003Ec__DisplayClass0_0.cHMJtoQGeFak9fswmE1H((object) c), moduleUid1))), (IEnumerable<ComponentSignature>) signature.Components);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 1 : 2;
            continue;
          case 9:
            if (CheckModuleHelper.M1MCkxB8zMiU9sj5qTDl((object) compatibilityResult3))
            {
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              compatibilityResult1 = CheckModuleHelper.CheckFunctions(dependency.Functions.Where<FunctionDependency>((Func<FunctionDependency, bool>) (c => CheckModuleHelper.\u003C\u003Ec__DisplayClass0_0.dGGsYXQGPKKPCRSsf9Ba(CheckModuleHelper.\u003C\u003Ec__DisplayClass0_0.cHMJtoQGeFak9fswmE1H((object) c), moduleUid1))), (IEnumerable<FunctionDependency>) signature.Functions);
              num = 6;
              continue;
            }
            num = 4;
            continue;
          default:
            moduleUid1 = moduleUid;
            num = 8;
            continue;
        }
      }
label_4:
      return compatibilityResult2;
label_6:
      return compatibilityResult1;
label_7:
      return (CompatibilityResult) CheckModuleHelper.fuZYgfBZFaDNkKZ8woow();
label_9:
      return compatibilityResult3;
    }

    private static CompatibilityResult CheckComponents(
      IEnumerable<ComponentDependency> dependencies,
      IEnumerable<ComponentSignature> signatureList)
    {
      // ISSUE: reference to a compiler-generated method
      Dictionary<Guid, ComponentSignature> dictionary = signatureList.ToDictionary<ComponentSignature, Guid, ComponentSignature>((Func<ComponentSignature, Guid>) (s => CheckModuleHelper.\u003C\u003Ec.l0f4MqQGac4tGr3Yx0TF((object) s)), (Func<ComponentSignature, ComponentSignature>) (s => s));
      foreach (ComponentDependency dependency in dependencies)
      {
        Guid headerUid = dependency.HeaderUid;
        if (!dictionary.ContainsKey(headerUid))
          return CompatibilityResult.Error(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(333888594 ^ 1075625116 ^ 1408957010), (object) dependency.DisplayName, (object) dependency.ModuleUid));
        ValidationResult validationResult = CheckComponentHelper.CheckSignature(dependency, dictionary[headerUid]);
        if (!validationResult.IsValid)
        {
          // ISSUE: reference to a compiler-generated method
          return CompatibilityResult.Error(((IEnumerable<ValidationError>) validationResult.Errors).Select<ValidationError, string>((Func<ValidationError, string>) (a => (string) CheckModuleHelper.\u003C\u003Ec.BVt3lqQGDv438k65ELMZ((object) a))));
        }
      }
      return CompatibilityResult.Ok();
    }

    private static CompatibilityResult CheckDataClasses(
      IEnumerable<DataClassDependency> dependencies,
      IEnumerable<DataClassDependency> signatureList)
    {
      // ISSUE: reference to a compiler-generated method
      Dictionary<Guid, DataClassDependency> dictionary = signatureList.ToDictionary<DataClassDependency, Guid, DataClassDependency>((Func<DataClassDependency, Guid>) (s => CheckModuleHelper.\u003C\u003Ec.l0f4MqQGac4tGr3Yx0TF((object) s)), (Func<DataClassDependency, DataClassDependency>) (s => s));
      foreach (DataClassDependency dependency in dependencies)
      {
        Guid headerUid = dependency.HeaderUid;
        if (!dictionary.ContainsKey(headerUid))
          return CompatibilityResult.Error(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(132912447 ^ 132967999), (object) dependency.DisplayName, (object) dependency.ModuleUid));
        CompatibilityResult compatibilityResult = dependency.Compatible(dictionary[headerUid]);
        if (!compatibilityResult.IsValid)
          return compatibilityResult;
      }
      return CompatibilityResult.Ok();
    }

    private static CompatibilityResult CheckFunctions(
      IEnumerable<FunctionDependency> dependencies,
      IEnumerable<FunctionDependency> signatureList)
    {
      // ISSUE: reference to a compiler-generated method
      Dictionary<Guid, FunctionDependency> dictionary = signatureList.ToDictionary<FunctionDependency, Guid, FunctionDependency>((Func<FunctionDependency, Guid>) (s => CheckModuleHelper.\u003C\u003Ec.l0f4MqQGac4tGr3Yx0TF((object) s)), (Func<FunctionDependency, FunctionDependency>) (s => s));
      foreach (FunctionDependency dependency in dependencies)
      {
        Guid headerUid = dependency.HeaderUid;
        if (!dictionary.ContainsKey(headerUid))
          return CompatibilityResult.Error(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606614888), (object) dependency.DisplayName, (object) dependency.ModuleUid));
        CompatibilityResult compatibilityResult = dependency.Compatible(dictionary[headerUid]);
        if (!compatibilityResult.IsValid)
          return compatibilityResult;
      }
      return CompatibilityResult.Ok();
    }

    internal static bool M1MCkxB8zMiU9sj5qTDl([In] object obj0) => ((CompatibilityResult) obj0).IsValid;

    internal static object fuZYgfBZFaDNkKZ8woow() => (object) CompatibilityResult.Ok();

    internal static bool hYuIT6B8sQDCfvlH7wgl() => CheckModuleHelper.DhFJcHB8UrcpvG5wki5X == null;

    internal static CheckModuleHelper l0lDFAB8c1ekYNeAaK7u() => CheckModuleHelper.DhFJcHB8UrcpvG5wki5X;
  }
}
