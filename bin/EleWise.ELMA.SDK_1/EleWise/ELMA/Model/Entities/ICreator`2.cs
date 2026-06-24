// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Entities.ICreator`2
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System.ComponentModel;

namespace EleWise.ELMA.Model.Entities
{
  /// <summary>
  /// Интерфейс контейнера метода создания экземпляра данных динамической сущности/фильтра
  /// </summary>
  /// <typeparam name="T">Тип данных динамической сущности/фильтра</typeparam>
  /// <typeparam name="TData">Тип интерфейса данных динамической сущности/фильтра</typeparam>
  [EditorBrowsable(EditorBrowsableState.Never)]
  public interface ICreator<T, TData> where TData : class
  {
    /// <summary>Создать данные</summary>
    /// <returns>Экземпляр данных</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    TData Create(T entity);
  }
}
