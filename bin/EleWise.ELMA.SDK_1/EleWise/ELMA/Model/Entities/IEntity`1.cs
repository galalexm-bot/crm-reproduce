// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Entities.IEntity`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Managers;

namespace EleWise.ELMA.Model.Entities
{
  /// <summary>Интерфейс сущности с идентификатором</summary>
  /// <typeparam name="IdT">Тип идентификатора (первичного ключа)</typeparam>
  [DefaultManager(typeof (EntityManagerMaker))]
  public interface IEntity<IdT> : IEntity, IIdentified
  {
    /// <summary>Идентификатор (первичный ключ)</summary>
    IdT Id { get; set; }
  }
}
