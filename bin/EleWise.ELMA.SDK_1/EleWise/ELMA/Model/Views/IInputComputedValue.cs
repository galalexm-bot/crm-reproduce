// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.IInputComputedValue
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Types.Settings;
using System;

namespace EleWise.ELMA.Model.Views
{
  /// <summary>Вычисляемое значение для инпута компонента</summary>
  public interface IInputComputedValue : IComputedValue
  {
    /// <summary>Уникальный идентификатор типа инпута</summary>
    Guid TypeUid { get; set; }

    /// <summary>Уникальный идентификатор подтипа инпута</summary>
    Guid SubTypeUid { get; set; }

    /// <summary>Обязательно для заполнения</summary>
    bool Required { get; set; }

    /// <summary>Может иметь пустое значение</summary>
    bool Nullable { get; set; }

    /// <summary>Тип связи</summary>
    RelationType RelationType { get; set; }
  }
}
