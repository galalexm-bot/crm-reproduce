// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.IAbstractBoundVariableService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.Services
{
  /// <summary>Абстракный сервис для работы с переменными</summary>
  public interface IAbstractBoundVariableService
  {
    /// <summary>Содержится ли значение переменной</summary>
    /// <param name="name">Имя переменной</param>
    /// <returns>True, если содержится</returns>
    bool Contains(string name);

    /// <summary>Получить значение переменной</summary>
    /// <typeparam name="T">Тип значения</typeparam>
    /// <param name="name">Имя переменной</param>
    /// <exception cref="T:EleWise.ELMA.Exceptions.VariableNotFoundException">Исключение "Переменная не найдена"</exception>
    /// <returns>Значение переменной</returns>
    T Get<T>(string name);

    /// <summary>Попытаться получить значение переменной</summary>
    /// <typeparam name="T">Тип значения</typeparam>
    /// <param name="name">Имя переменной</param>
    /// <param name="value">Полученное значение (или значение по умолчанию для типа <typeparamref name="T" />, если элемент не найден)</param>
    /// <returns>True, если переменная найдена</returns>
    bool TryGetValue<T>(string name, out T value);

    /// <summary>Установить значение переменной</summary>
    /// <param name="name">Имя переменной</param>
    /// <param name="value">Значение переменной</param>
    void Set(string name, object value);

    /// <summary>Удалить значение переменной</summary>
    /// <param name="key">Имя переменной</param>
    void Remove(string key);
  }
}
