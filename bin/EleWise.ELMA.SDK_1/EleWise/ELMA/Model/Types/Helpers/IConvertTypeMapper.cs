// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Helpers.IConvertTypeMapper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Model.Types.Helpers
{
  /// <summary>Конвертер типа</summary>
  [ExtensionPoint(ServiceScope.Application, ComponentType.All)]
  public interface IConvertTypeMapper
  {
    /// <summary>Можно ли применять конвертер</summary>
    /// <param name="originalPropertyMetadata">Тип</param>
    /// <param name="convertPropertyMetadata">Тип в который нужно сконвертировать</param>
    /// <returns></returns>
    bool RelativeConvertNeeded(
      IPropertyMetadata originalPropertyMetadata,
      IPropertyMetadata convertPropertyMetadata);

    /// <summary>Конвертировать тип</summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    object Convert(object obj);
  }
}
