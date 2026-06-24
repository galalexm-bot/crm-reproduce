// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ExtensionPoints.IOriginalCollectionExtension
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using System.Collections;

namespace EleWise.ELMA.ExtensionPoints
{
  /// <summary>Точка расширения для получения оригинальной коллекции</summary>
  [ExtensionPoint(ServiceScope.Shell, ComponentType.Web)]
  public interface IOriginalCollectionExtension
  {
    /// <summary>Проверка на применимость точки расширения</summary>
    /// <param name="obj">Проверяемый объект</param>
    bool Can(object obj);

    /// <summary>Получить оригинальную коллекцию</summary>
    /// <param name="obj">Объект из которого получаем оригинальную коллекцию</param>
    IEnumerable OriginalItems(object obj);
  }
}
