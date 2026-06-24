// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Entities.ISoftDeletable
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.Model.Entities
{
  /// <summary>
  /// Интерфейс сущности, обладающей возможностью "мягкого" удаления
  /// </summary>
  public interface ISoftDeletable
  {
    /// <summary>Признак удаления</summary>
    bool IsDeleted { get; set; }

    /// <summary>Реально удалить сущность из базы</summary>
    bool HardDelete { get; set; }
  }
}
