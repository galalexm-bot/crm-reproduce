// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ExtensionPoints.ISystemComponentCreator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.UI.Models;

namespace EleWise.ELMA.ExtensionPoints
{
  /// <summary>Точка расширения для создания системных компонентов</summary>
  [ExtensionPoint(ComponentType.All)]
  public interface ISystemComponentCreator
  {
    /// <summary>Создать системный компонент</summary>
    /// <returns>Системный компонент</returns>
    ComponentMetadataItem Create();
  }
}
