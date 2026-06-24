// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Entities.IIdentified
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.Model.Entities
{
  /// <summary>Интерфейс объекта с идентификатором</summary>
  public interface IIdentified
  {
    /// <summary>
    /// Получить нетипизированное значение идентификатора у сущности
    /// </summary>
    /// <returns>Значение идентификатора</returns>
    object GetId();

    /// <summary>Установить нетипизированное значение идентификатора</summary>
    /// <param name="id">Значение идентификатора</param>
    void SetId(object id);
  }
}
