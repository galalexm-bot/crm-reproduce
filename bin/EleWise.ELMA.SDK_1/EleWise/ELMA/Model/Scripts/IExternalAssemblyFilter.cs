// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.IExternalAssemblyFilter
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.Model.Scripts
{
  /// <summary>Фильтр для объекта "Внешняя сборка"</summary>
  [FilterFor(typeof (IExternalAssembly))]
  public interface IExternalAssemblyFilter : IEntityFilter
  {
    /// <summary>Фильтр для свойства "Имя сборки"</summary>
    string Name { get; set; }

    /// <summary>Фильтр для свойства "HashCode"</summary>
    string HashCode { get; set; }
  }
}
