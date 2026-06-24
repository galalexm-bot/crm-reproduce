// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Dependencies.MetadataDependencyContainer
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Dependencies
{
  /// <summary>Контейнер зависимости для метаданных</summary>
  public sealed class MetadataDependencyContainer : IDependencyContainer
  {
    internal static MetadataDependencyContainer w0bx82hijinm6fwvmaO5;

    /// <summary>Ctor</summary>
    public MetadataDependencyContainer()
    {
      MetadataDependencyContainer.CIj2LGhiUfMllWUAQfy6();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.FormDependencies = new List<FormViewItemDependencyContainer>();
            num = 3;
            continue;
          case 2:
            goto label_3;
          case 3:
            this.FunctionDependencies = new List<FunctionDependency>();
            num = 4;
            continue;
          case 4:
            this.DataClassDependencies = new List<DataClassDependency>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 2 : 5;
            continue;
          case 5:
            this.EntityDependencies = new List<EntityDependency>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 0 : 0;
            continue;
          default:
            this.EnumDependencies = new List<EnumDependency>();
            num = 2;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Зависимости в формах</summary>
    public List<FormViewItemDependencyContainer> FormDependencies { get; }

    /// <summary>Общие зависимости от функций</summary>
    public List<FunctionDependency> FunctionDependencies { get; }

    /// <summary>Общие зависимости от датаклассов</summary>
    public List<DataClassDependency> DataClassDependencies { get; }

    /// <summary>Общие зависимости от сущностей</summary>
    public List<EntityDependency> EntityDependencies { get; }

    /// <summary>Общие зависимости от перечислений</summary>
    public List<EnumDependency> EnumDependencies { get; }

    internal static void CIj2LGhiUfMllWUAQfy6() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool kUohS3hiYIkmeKEMBASy() => MetadataDependencyContainer.w0bx82hijinm6fwvmaO5 == null;

    internal static MetadataDependencyContainer WZQ6H7hiLxE3k9ulSyyK() => MetadataDependencyContainer.w0bx82hijinm6fwvmaO5;
  }
}
