// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Settings.IHasDefaultValue`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.Model.Types.Settings
{
  /// <summary>
  /// Интерфейс класса настроек типа, имеющего значение по умолчанию
  /// </summary>
  /// <typeparam name="T">Тип значения</typeparam>
  public interface IHasDefaultValue<T>
  {
    /// <summary>Значение по умолчанию</summary>
    T DefaultValue { get; set; }
  }
}
