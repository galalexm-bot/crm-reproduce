// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Dynamic.IDynamicObject
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.Dynamic
{
  /// <summary>Интерфейс динамического объекта</summary>
  public interface IDynamicObject
  {
    /// <summary>Содержит ли объект свойство с указанным именем</summary>
    /// <param name="name">Имя свойства</param>
    /// <param name="ignoreCase">Игнорировать регистр букв</param>
    /// <returns>True, если содержит</returns>
    bool ContainsProperty(string name, bool ignoreCase = false);

    /// <summary>Получить значение свойства</summary>
    /// <param name="name">Имя свойства</param>
    /// <param name="ignoreCase">Игнорировать регистр букв</param>
    /// <returns>Значение свойства</returns>
    object GetPropertyValue(string name, bool ignoreCase = false);

    /// <summary>Установить значение свойства</summary>
    /// <param name="name">Имя свойства</param>
    /// <param name="value">Значение свойства</param>
    /// <param name="ignoreCase">Игнорировать регистр букв</param>
    void SetPropertyValue(string name, object value, bool ignoreCase = false);
  }
}
