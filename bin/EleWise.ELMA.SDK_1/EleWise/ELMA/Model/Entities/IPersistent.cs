// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Entities.IPersistent
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.Model.Entities
{
  /// <summary>Интерфейс сущности, имеющей связь с БД</summary>
  public interface IPersistent
  {
    /// <summary>Сохранить сущность в БД</summary>
    void Save();

    /// <summary>Обновить сущность в БД</summary>
    void Update();

    /// <summary>Удалить сущность в БД</summary>
    void Delete();

    /// <summary>Обновить сущность</summary>
    void Refresh();
  }
}
