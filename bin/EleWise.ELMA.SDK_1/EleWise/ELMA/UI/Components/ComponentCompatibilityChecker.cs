// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Components.ComponentCompatibilityChecker
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata.Components;
using EleWise.ELMA.Model.Signatures;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.UI.Components
{
  /// <inheritdoc />
  [Component]
  internal sealed class ComponentCompatibilityChecker : CompatibilityChecker<ComponentSignature>
  {
    internal static ComponentCompatibilityChecker WKliLBBZMMdb4qnMqhNR;

    /// <inheritdoc />
    public override ICollection<string> CheckCompatibility(
      ComponentSignature old,
      ComponentSignature @new)
    {
      Contract.NotNull((object) old, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1178210108 ^ 1178274672));
      Contract.NotNull((object) @new, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1242972401 >> 4 ^ 77692469));
      List<InputComputedValue> inputs = @new.Inputs;
      // ISSUE: reference to a compiler-generated method
      Dictionary<string, InputComputedValue> dictionary = old.Inputs.ToDictionary<InputComputedValue, string, InputComputedValue>((Func<InputComputedValue, string>) (i => (string) ComponentCompatibilityChecker.\u003C\u003Ec.EbS0l9QEZgvZvoljnjZD((object) i)), (Func<InputComputedValue, InputComputedValue>) (i => i));
      if (inputs.Count == 0)
        return (ICollection<string>) Array.Empty<string>();
      List<string> stringList = new List<string>();
      foreach (InputComputedValue inputComputedValue1 in inputs)
      {
        InputComputedValue inputComputedValue2;
        if (!dictionary.TryGetValue(inputComputedValue1.Name, out inputComputedValue2))
        {
          if (inputComputedValue1.Required)
            stringList.Add(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(277947046 - -1479185048 ^ 1757065576), (object) @new.Name, (object) @new.DisplayName, (object) inputComputedValue1.Name));
        }
        else
        {
          if (inputComputedValue1.Nullable != inputComputedValue2.Nullable && !inputComputedValue1.Nullable && inputComputedValue2.Nullable)
            stringList.Add(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(712480695 ^ 712413873), (object) @new.Name, (object) inputComputedValue1.Name));
          if (inputComputedValue1.RelationType != inputComputedValue2.RelationType)
            stringList.Add(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1858952133), (object) @new.Name, (object) inputComputedValue1.Name));
          if (inputComputedValue1.TypeUid != inputComputedValue2.TypeUid || inputComputedValue1.SubTypeUid != inputComputedValue2.SubTypeUid)
            stringList.Add(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-643786247 ^ -643719235), (object) @new.Name, (object) inputComputedValue1.Name));
          if (inputComputedValue2 is ActionInputComputedValue inputComputedValue3 && inputComputedValue1 is ActionInputComputedValue inputComputedValue4)
          {
            TypeSignature parameterType1 = inputComputedValue3.ParameterType;
            TypeSignature parameterType2 = inputComputedValue4.ParameterType;
            if (parameterType1.TypeUid != parameterType2.TypeUid || parameterType1.SubTypeUid != parameterType2.SubTypeUid)
              stringList.Add(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1051802738 - -1831968059 ^ -1411129521), (object) @new.Name, (object) inputComputedValue1.Name));
            if (parameterType1.Nullable != parameterType2.Nullable && parameterType1.Nullable && !parameterType2.Nullable)
              stringList.Add(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-710283084 ^ -537863435 ^ 173551079), (object) @new.Name, (object) inputComputedValue1.Name));
            if (parameterType1.RelationType != parameterType2.RelationType)
              stringList.Add(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1852900764), (object) @new.Name, (object) inputComputedValue1.Name));
            TypeSignature returnType1 = inputComputedValue3.ReturnType;
            TypeSignature returnType2 = inputComputedValue4.ReturnType;
            if (returnType1.TypeUid != returnType2.TypeUid || returnType1.SubTypeUid != returnType2.SubTypeUid)
              stringList.Add(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 1333672738), (object) @new.Name, (object) inputComputedValue1.Name));
            if (returnType1.Nullable != returnType2.Nullable && returnType1.Nullable && !returnType2.Nullable)
              stringList.Add(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1319452732 ^ 1319389746), (object) @new.Name, (object) inputComputedValue1.Name));
            if (returnType1.RelationType != returnType2.RelationType)
              stringList.Add(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~538519529 ^ -538455308), (object) @new.Name, (object) inputComputedValue1.Name));
          }
        }
      }
      return (ICollection<string>) stringList;
    }

    public ComponentCompatibilityChecker()
    {
      ComponentCompatibilityChecker.k6Y3b5BZdHxI3LgkgbvD();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void k6Y3b5BZdHxI3LgkgbvD() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool mlod3ZBZJeyIjc4eASSV() => ComponentCompatibilityChecker.WKliLBBZMMdb4qnMqhNR == null;

    internal static ComponentCompatibilityChecker uZ0qGmBZ9dkvNRNgmvkJ() => ComponentCompatibilityChecker.WKliLBBZMMdb4qnMqhNR;
  }
}
