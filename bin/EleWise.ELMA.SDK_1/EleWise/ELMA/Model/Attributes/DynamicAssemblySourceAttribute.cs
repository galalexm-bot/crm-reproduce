// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.DynamicAssemblySourceAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>
  /// Указывает исходную сборку, на основе которой была сгенерирована динамическая сборка
  /// </summary>
  [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
  public class DynamicAssemblySourceAttribute : Attribute
  {
    private string assemblyName;
    private string hashCode;
    internal static DynamicAssemblySourceAttribute gpTaGmo8hb31yVZF5yOk;

    /// <summary>Ctor</summary>
    /// <param name="assemblyName">Имя сборки</param>
    /// <param name="hashCode">Хэш-код</param>
    public DynamicAssemblySourceAttribute(string assemblyName, string hashCode)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.hashCode = hashCode;
            num = 2;
            continue;
          case 2:
            goto label_3;
          default:
            this.assemblyName = assemblyName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Имя сборки</summary>
    public string AssemblyName => this.assemblyName;

    /// <summary>Хэш-код</summary>
    public string HashCode => this.hashCode;

    internal static bool wT8owjo8Gevi09wdSH9P() => DynamicAssemblySourceAttribute.gpTaGmo8hb31yVZF5yOk == null;

    internal static DynamicAssemblySourceAttribute SaLWTUo8EER9Uq2ZwQsI() => DynamicAssemblySourceAttribute.gpTaGmo8hb31yVZF5yOk;
  }
}
