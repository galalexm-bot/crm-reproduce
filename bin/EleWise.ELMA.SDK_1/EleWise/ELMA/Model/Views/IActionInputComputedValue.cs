// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.IActionInputComputedValue
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Signatures;

namespace EleWise.ELMA.Model.Views
{
  /// <summary>Вычисляемое значение для инпута-действия компонента</summary>
  public interface IActionInputComputedValue : IInputComputedValue, IComputedValue
  {
    /// <summary>Сигнатура возвращаемого типа</summary>
    TypeSignature ReturnType { get; set; }

    /// <summary>Сигнатура типа параметра</summary>
    TypeSignature ParameterType { get; set; }
  }
}
