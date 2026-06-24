// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.IActorContextService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.Services
{
  /// <summary>Сервис контекста исполнения в акторе</summary>
  public interface IActorContextService
  {
    /// <summary>Получить контекст</summary>
    /// <param name="key">Ключ</param>
    /// <param name="value">Полученное значение</param>
    /// <returns>True, если значение найдено</returns>
    bool TryGet(string key, out object value);

    /// <summary>Добавить в контекст</summary>
    /// <param name="key">Ключ</param>
    /// <param name="value">Передаваемый объект</param>
    /// <remarks>
    /// В качестве контекста следует передавать только сериализуемые провайдером актора объекты.
    /// </remarks>
    void Set(string key, object value);
  }
}
