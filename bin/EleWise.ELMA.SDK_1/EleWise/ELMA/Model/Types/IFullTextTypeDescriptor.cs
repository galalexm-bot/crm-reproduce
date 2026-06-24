// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.IFullTextTypeDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.FullTextSearch.Descriptors;

namespace EleWise.ELMA.Model.Types
{
  /// <summary>
  /// Интерфейс работы с индексацией и полнотекстовым поиском для типа
  /// </summary>
  public interface IFullTextTypeDescriptor
  {
    /// <summary>Дескриптор для работы с типом в полнотестовом поиске</summary>
    IFullTextPropertyDescriptor FullTextPropertyDescriptor { get; }
  }
}
