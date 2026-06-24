// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ExtensionPoints.IViewModelDescriptorExtension
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.ExtensionPoints
{
  /// <summary>Точка расширения ViewModelDescriptor</summary>
  [ExtensionPoint(ComponentType.All)]
  public interface IViewModelDescriptorExtension
  {
    /// <summary>Проверить текущие реализации</summary>
    /// <param name="typeRef">Ссылка на тип</param>
    /// <returns><c>True</c>, если реализация подходит</returns>
    bool Check(string typeRef);

    /// <summary>Получить метаданнные</summary>
    /// <param name="typeRef">Ссылка на тип</param>
    /// <returns>Метаданные</returns>
    IMetadata GetMetadata(string typeRef);
  }
}
