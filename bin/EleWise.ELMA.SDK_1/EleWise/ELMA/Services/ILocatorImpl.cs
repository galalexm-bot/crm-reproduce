// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.ILocatorImpl
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;

namespace EleWise.ELMA.Services
{
  /// <summary>Интерфейс класса, реализующего менеджер служб</summary>
  public interface ILocatorImpl
  {
    /// <summary>Получить службу с указанным типом и именем</summary>
    /// <param name="type">Тип службы</param>
    /// <param name="name">Имя службы</param>
    /// <returns>Служба</returns>
    object GetService(Type type, string name);

    /// <summary>Зарегистрировать службу</summary>
    /// <param name="type">Тип службы</param>
    /// <param name="obj">Служба</param>
    /// <param name="resolveProperties">Обрабатывать публичные свойства при регистрации</param>
    void AddService(Type type, object obj, bool resolveProperties);

    /// <summary>Разрегистрировать службу</summary>
    /// <param name="type">Тип службы</param>
    void RemoveService(Type type);
  }
}
