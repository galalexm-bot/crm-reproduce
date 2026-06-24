// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ExtensionPoints.IValidatorInfo
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using System;

namespace EleWise.ELMA.ExtensionPoints
{
  /// <summary>Интерфейс MVC-валидатора</summary>
  [ExtensionPoint(ComponentType.Web)]
  public interface IValidatorInfo
  {
    /// <summary>Атрибут валидации</summary>
    Type AttributeType { get; }

    /// <summary>Класс валидатора</summary>
    Type ValidatorType { get; }
  }
}
