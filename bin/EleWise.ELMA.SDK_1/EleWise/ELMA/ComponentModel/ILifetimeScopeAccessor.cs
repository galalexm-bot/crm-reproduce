// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ComponentModel.ILifetimeScopeAccessor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using Autofac;
using System;

namespace EleWise.ELMA.ComponentModel
{
  /// <summary>Доступ к текущему контексту</summary>
  public interface ILifetimeScopeAccessor
  {
    /// <summary>Получить текущий контекст</summary>
    ILifetimeScope Current { get; }

    /// <summary>Тип текущего контекста</summary>
    ServiceScope CurrentType { get; set; }

    /// <summary>Поменять метод получения контекста</summary>
    /// <param name="accessor"></param>
    void SetAccessor(Func<ILifetimeScope> accessor);
  }
}
