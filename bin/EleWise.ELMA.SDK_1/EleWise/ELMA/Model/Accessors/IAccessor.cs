// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Accessors.IAccessor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;
using System.ComponentModel;
using System.Linq.Expressions;

namespace EleWise.ELMA.Model.Accessors
{
  /// <summary>Информация о свойстве</summary>
  [EditorBrowsable(EditorBrowsableState.Never)]
  public interface IAccessor
  {
    /// <summary>Тип свойства</summary>
    Type PropertyType { get; }

    /// <summary>Имя свойство</summary>
    string PropertyName { get; }

    /// <summary>Наличие геттера у свойства</summary>
    bool HasGetter { get; }

    /// <summary>Наличие сеттера у свойства</summary>
    bool HasSetter { get; }

    /// <summary>Выражение для получения значения свойства</summary>
    /// <param name="instance">Выражение экземпляра</param>
    Expression GetExpression(Expression instance);

    /// <summary>Выражение для установки значения свойства</summary>
    /// <param name="instance">Выражение экземпляра</param>
    /// <param name="value">Выражение значения</param>
    Expression SetExpression(Expression instance, Expression value);
  }
}
