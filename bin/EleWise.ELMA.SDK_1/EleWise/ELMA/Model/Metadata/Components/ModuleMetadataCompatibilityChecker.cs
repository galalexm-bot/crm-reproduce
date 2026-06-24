// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.Components.ModuleMetadataCompatibilityChecker
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Metadata.ExtensionPoints;
using EleWise.ELMA.Model.Signatures;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Model.Metadata.Components
{
  /// <inheritdoc />
  [Component]
  internal sealed class ModuleMetadataCompatibilityChecker : CompatibilityChecker<ModuleSignature>
  {
    private readonly IEnumerable<ICompatibilityChecker<DataClassDependency>> dataClassCheckers;
    private readonly IEnumerable<ICompatibilityChecker<FunctionDependency>> functionCheckers;
    private readonly IEnumerable<ICompatibilityChecker<ComponentSignature>> componentCheckers;

    /// <summary>Ctor</summary>
    /// <param name="dataClassCheckers">Проверки совместимости для датаклассов</param>
    /// <param name="functionCheckers">Проверки совместимости для функций</param>
    /// <param name="componentCheckers">Проверки совместимости для компонентов</param>
    public ModuleMetadataCompatibilityChecker(
      IEnumerable<ICompatibilityChecker<DataClassDependency>> dataClassCheckers,
      IEnumerable<ICompatibilityChecker<FunctionDependency>> functionCheckers,
      IEnumerable<ICompatibilityChecker<ComponentSignature>> componentCheckers)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.dataClassCheckers = dataClassCheckers;
      this.functionCheckers = functionCheckers;
      this.componentCheckers = componentCheckers;
    }

    /// <inheritdoc />
    public override ICollection<string> CheckCompatibility(
      ModuleSignature old,
      ModuleSignature @new)
    {
      List<string> first = this.CheckDataClasses((ICollection<DataClassDependency>) old.DataClasses, (ICollection<DataClassDependency>) @new.DataClasses);
      List<string> stringList = this.CheckFunctions((ICollection<FunctionDependency>) old.Functions, (ICollection<FunctionDependency>) @new.Functions);
      List<string> second1 = this.CheckComponents((ICollection<ComponentSignature>) old.Components, (ICollection<ComponentSignature>) @new.Components);
      List<string> second2 = stringList;
      return (ICollection<string>) first.Concat<string>((IEnumerable<string>) second2).Concat<string>((IEnumerable<string>) second1).ToList<string>();
    }

    private List<string> CheckDataClasses(
      ICollection<DataClassDependency> old,
      ICollection<DataClassDependency> @new)
    {
      // ISSUE: reference to a compiler-generated method
      Dictionary<Guid, DataClassDependency> dictionary = @new.ToDictionary<DataClassDependency, Guid, DataClassDependency>((Func<DataClassDependency, Guid>) (d => ModuleMetadataCompatibilityChecker.\u003C\u003Ec.GYydMRCdXUYhFKU3YJWY((object) d)), (Func<DataClassDependency, DataClassDependency>) (d => d));
      List<string> stringList = new List<string>();
      foreach (DataClassDependency dataClassDependency in (IEnumerable<DataClassDependency>) old)
      {
        DataClassDependency oldDependency = dataClassDependency;
        DataClassDependency newDependency;
        if (!dictionary.TryGetValue(oldDependency.HeaderUid, out newDependency))
          stringList.Add(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1142330761 ^ 1541959139 ^ 536730238), (object) oldDependency.Name));
        else
          stringList.AddRange(this.dataClassCheckers.SelectMany<ICompatibilityChecker<DataClassDependency>, string>((Func<ICompatibilityChecker<DataClassDependency>, IEnumerable<string>>) (c => (IEnumerable<string>) c.CheckCompatibility(oldDependency, newDependency))));
      }
      return stringList;
    }

    private List<string> CheckFunctions(
      ICollection<FunctionDependency> old,
      ICollection<FunctionDependency> @new)
    {
      Dictionary<Guid, FunctionDependency> dictionary = @new.ToDictionary<FunctionDependency, Guid, FunctionDependency>((Func<FunctionDependency, Guid>) (d => d.HeaderUid), (Func<FunctionDependency, FunctionDependency>) (d => d));
      List<string> stringList = new List<string>();
      foreach (FunctionDependency functionDependency in (IEnumerable<FunctionDependency>) old)
      {
        FunctionDependency oldDependency = functionDependency;
        FunctionDependency newDependency;
        if (!dictionary.TryGetValue(oldDependency.HeaderUid, out newDependency))
          stringList.Add(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-281842504 ^ -282046914), (object) oldDependency.Name));
        else
          stringList.AddRange(this.functionCheckers.SelectMany<ICompatibilityChecker<FunctionDependency>, string>((Func<ICompatibilityChecker<FunctionDependency>, IEnumerable<string>>) (c => (IEnumerable<string>) c.CheckCompatibility(oldDependency, newDependency))));
      }
      return stringList;
    }

    private List<string> CheckComponents(
      ICollection<ComponentSignature> old,
      ICollection<ComponentSignature> @new)
    {
      List<string> stringList = new List<string>();
      Dictionary<Guid, ComponentSignature> dictionary = @new.ToDictionary<ComponentSignature, Guid, ComponentSignature>((Func<ComponentSignature, Guid>) (c => c.HeaderUid), (Func<ComponentSignature, ComponentSignature>) (c => c));
      foreach (ComponentSignature componentSignature in (IEnumerable<ComponentSignature>) old)
      {
        ComponentSignature oldComponent = componentSignature;
        ComponentSignature newComponent;
        if (!dictionary.TryGetValue(oldComponent.HeaderUid, out newComponent))
          stringList.Add(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(993438473 ^ 993364469), (object) oldComponent.Name));
        else
          stringList.AddRange(this.componentCheckers.SelectMany<ICompatibilityChecker<ComponentSignature>, string>((Func<ICompatibilityChecker<ComponentSignature>, IEnumerable<string>>) (c => (IEnumerable<string>) c.CheckCompatibility(oldComponent, newComponent))));
      }
      return stringList;
    }
  }
}
