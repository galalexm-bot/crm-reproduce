// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.DevServer.CodeGeneration.AbstractGeneratorProvider`2
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Reflection;

namespace EleWise.ELMA.DevServer.CodeGeneration
{
  /// <summary>
  /// Базовая реализация провайдера генераторов кода по метаданным
  /// </summary>
  /// <typeparam name="TMd">Тип метаданных</typeparam>
  /// <typeparam name="TGen">Тип генератора</typeparam>
  public abstract class AbstractGeneratorProvider<TMd, TGen> : IMetadataGeneratorProvider where TMd : IMetadata
  {
    internal static object XEOMM7EOCPdayZdSmPjd;

    /// <inheritdoc />
    public virtual Type MetadataType => TypeOf<TMd>.Raw;

    /// <inheritdoc />
    public virtual Type GeneratorType => TypeOf<TGen>.Raw;

    protected AbstractGeneratorProvider()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool pc0q68EOv1OXjpNGL7It() => AbstractGeneratorProvider<TMd, TGen>.XEOMM7EOCPdayZdSmPjd == null;

    internal static object VLLEKNEO88FOeAxVUicN() => AbstractGeneratorProvider<TMd, TGen>.XEOMM7EOCPdayZdSmPjd;
  }
}
