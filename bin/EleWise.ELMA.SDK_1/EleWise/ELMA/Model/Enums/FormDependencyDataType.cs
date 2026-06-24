// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Enums.FormDependencyDataType
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.Model.Enums
{
  public enum FormDependencyDataType
  {
    /// <summary>
    /// Прямая зависимость (когда форма используется на форме в виде кнопки)
    /// </summary>
    Direct,
    /// <summary>Дефолтная зависимость (зависимость форм по умолчанию)</summary>
    Default,
    /// <summary>Дочерняя зависимость (когда форма является дочерней)</summary>
    Child,
    /// <summary>
    /// Наследственная (когда форма базового объекта базы изменена в одном из наследников)
    /// </summary>
    Inherit,
    /// <summary>Наследственно-прямая</summary>
    /// <remarks>
    /// Когда используют форму из объекта-наследника,
    /// которая объявлена в объекте-родителе
    /// </remarks>
    DirectInherit,
    /// <summary>Наследственно-дефолтная</summary>
    /// <remarks>
    /// Когда используют форму по умолчанию из объекта-наследника,
    /// которая объявлена в объекте-родителе
    /// </remarks>
    DefaultInherit,
  }
}
