// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Helpers.ITypeWrapperResolver
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using System;

namespace EleWise.ELMA.Model.Types.Helpers
{
  /// <summary>Определитель для типов для сохранялки фильтра</summary>
  [ExtensionPoint(ServiceScope.Application, ComponentType.All)]
  public interface ITypeWrapperResolver
  {
    /// <summary>Уникальный идентификатор</summary>
    Guid Uid { get; }

    /// <summary>Заголовок (для отображения)</summary>
    string Caption { get; }

    /// <summary>Получение объекта из описания</summary>
    /// <param name="typeDescriptor"></param>
    /// <returns></returns>
    object GetObjectInstance(string typeDescriptor);

    /// <summary>Пулучение описания из объекта</summary>
    /// <param name="property"></param>
    /// <returns></returns>
    string GetObjectInstanceDescriptor(object property);
  }
}
