// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Transformations.IAttributesChangeableProperties
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.Model.Transformations
{
  /// <summary>
  /// Интерфейс для класса, возвращающего список имен свойств, для которых нужно отслеживать изменение
  /// </summary>
  public interface IAttributesChangeableProperties
  {
    string[] GetProperties();
  }
}
