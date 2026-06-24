// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Common.NamedValue`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Common
{
  /// <summary>Структура для передачи именованного значения</summary>
  /// <typeparam name="T"></typeparam>
  public struct NamedValue<T>
  {
    /// <summary>Наименование</summary>
    public readonly string Name;
    /// <summary>Значение</summary>
    public readonly T Value;

    public unsafe NamedValue(string name, T value)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      *(NamedValue<T>*) ref this = new NamedValue<T>();
      this.Name = name;
      this.Value = value;
    }
  }
}
