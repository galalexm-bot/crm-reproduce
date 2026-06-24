// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Serialization.IPackSerializableItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.Serialization
{
  /// <summary>Интерфейс элемента упаковываемого перечислителя</summary>
  public interface IPackSerializableItem
  {
    /// <summary>Сериализация.</summary>
    string Serialize();

    /// <summary>Десериализация.</summary>
    /// <param name="value">Десериализация.</param>
    /// <returns></returns>
    void DeserializeFrom(string value);
  }
}
