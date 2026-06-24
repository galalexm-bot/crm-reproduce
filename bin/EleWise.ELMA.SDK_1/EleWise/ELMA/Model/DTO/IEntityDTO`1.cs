// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.DTO.IEntityDTO`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.Model.DTO
{
  /// <summary>
  /// Интерфейс DTO для сущности с типизированным идентификатором
  /// </summary>
  public interface IEntityDTO<TId> : IEntityDTO
  {
    /// <summary>Идентификатор</summary>
    TId Id { get; set; }
  }
}
