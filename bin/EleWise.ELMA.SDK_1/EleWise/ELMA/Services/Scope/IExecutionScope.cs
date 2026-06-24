// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.Scope.IExecutionScope
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;

namespace EleWise.ELMA.Services.Scope
{
  /// <summary>Контекст выполнения</summary>
  public interface IExecutionScope : IDisposable
  {
    /// <summary>Резолв типа</summary>
    /// <param name="objectType">Тип объекта, который необхомо разрезолвить</param>
    /// <returns>Экземпляр объекта</returns>
    object Resolve(Type objectType);

    /// <summary>Резолв типа</summary>
    /// <typeparam name="T">ип объекта, который необхомо разрезолвить</typeparam>
    /// <returns>Экземпляр объекта</returns>
    T Resolve<T>() where T : class;
  }
}
