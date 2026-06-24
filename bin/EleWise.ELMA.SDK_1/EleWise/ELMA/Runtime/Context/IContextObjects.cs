// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Context.IContextObjects
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.Runtime.Context
{
  /// <summary>Хранилище объектов</summary>
  public interface IContextObjects
  {
    /// <summary>Получить экземпляр объекта</summary>
    /// <typeparam name="T">Тип объекта</typeparam>
    /// <returns>Экземпляр объекта</returns>
    T Get<T>() where T : class;

    /// <summary>Сохранить экземпляр объекта</summary>
    /// <param name="obj">Экземпляр объекта</param>
    /// <typeparam name="T">Тип объекта</typeparam>
    void Set<T>(T obj) where T : class;
  }
}
