// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.IEditPropertyTableAvailibility
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.Model.Types
{
  /// <summary>
  /// Дополнительный интерфейс необходимый для помечания нужного дескриптора, что он может отображаться на редактирование в таблице блока
  /// </summary>
  public interface IEditPropertyTableAvailibility
  {
    /// <summary>
    /// Разрешено ли использовать данный тип в блоке на редактирование как таблица
    /// </summary>
    bool IsAvailibleEditPropertyInTable { get; }
  }
}
