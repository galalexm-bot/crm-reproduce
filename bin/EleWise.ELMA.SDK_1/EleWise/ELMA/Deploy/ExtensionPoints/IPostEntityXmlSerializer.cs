// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.ExtensionPoints.IPostEntityXmlSerializer
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Deploy.ExtensionPoints
{
  /// <summary>
  /// Точка расширения для изменения логики (де)сериализации сущностей
  /// и xml-сериализуемых объектов в процессе экспорта/импорта
  /// </summary>
  [ExtensionPoint(ComponentType.All)]
  public interface IPostEntityXmlSerializer
  {
    /// <summary>Подмена элементов в сериализованном объекте</summary>
    string Replace(string serializedObject);

    /// <summary>Обратная подмена элементов в сериализованном объекте</summary>
    string UndoReplace(string serializedObject);
  }
}
