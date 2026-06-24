// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Dependencies.ScriptModuleDependencyContainer
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Dependencies
{
  /// <summary>Контейнер зависимостей для модуля сценариев</summary>
  public sealed class ScriptModuleDependencyContainer : IDependencyContainer
  {
    internal static ScriptModuleDependencyContainer VCxOHAhRB6Bv0enRnnch;

    /// <summary>Ctor</summary>
    public ScriptModuleDependencyContainer()
    {
      ScriptModuleDependencyContainer.xykq7fhRbT1ZhbYQDnqd();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.EnumDependencies = new List<EnumDependency>();
            num = 3;
            continue;
          case 2:
            this.DataClassDependencies = new List<DataClassDependency>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 0;
            continue;
          case 3:
            goto label_3;
          default:
            this.EntityDependencies = new List<EntityDependency>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Зависимости от датаклассов</summary>
    public List<DataClassDependency> DataClassDependencies { get; }

    /// <summary>Зависимости от сущностей</summary>
    public List<EntityDependency> EntityDependencies { get; }

    /// <summary>Зависимости от перечислений</summary>
    public List<EnumDependency> EnumDependencies { get; }

    internal static void xykq7fhRbT1ZhbYQDnqd() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool LYCecvhRWgUhNcDoDNXS() => ScriptModuleDependencyContainer.VCxOHAhRB6Bv0enRnnch == null;

    internal static ScriptModuleDependencyContainer xYbvlUhRoZhqv71dbXCF() => ScriptModuleDependencyContainer.VCxOHAhRB6Bv0enRnnch;
  }
}
