// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Entities.IFormDependencyData
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Enums;
using System;

namespace EleWise.ELMA.Model.Entities
{
  /// <summary>Данные для зависимостей форм</summary>
  public interface IFormDependencyData
  {
    /// <summary>Уид зависимого объекта</summary>
    Guid DependObjectUid { get; }

    /// <summary>Уид формы зависимого объекта</summary>
    Guid DependObjectFormUid { get; }

    /// <summary>Уид используемого объекта</summary>
    Guid UsesObjectUid { get; }

    /// <summary>Уид формы используемого объекта</summary>
    Guid UsesObjectFormUid { get; }

    /// <summary>Тип зависимости</summary>
    FormDependencyDataType Type { get; }

    /// <summary>Сгенерировать информацию о зависимом объекте</summary>
    /// <returns></returns>
    string GenerateDependInfo();

    /// <summary>Сгенерировать информацию об используемом объекте</summary>
    /// <returns></returns>
    string GenerateUsesInfo();
  }
}
