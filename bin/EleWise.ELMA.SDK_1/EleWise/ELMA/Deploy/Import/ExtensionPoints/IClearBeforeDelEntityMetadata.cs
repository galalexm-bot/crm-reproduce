// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.ExtensionPoints.IClearBeforeDelEntityMetadata
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Deploy.Import.ExtensionPoints
{
  /// <summary>
  /// Расширение "отвязки" старых метаданных сущностей при импорте метаданных
  /// </summary>
  [ExtensionPoint(ComponentType.All)]
  public interface IClearBeforeDelEntityMetadata
  {
    /// <summary>"Отвязка" старой сущности</summary>
    /// <param name="oldobjectMd"></param>
    /// <returns>true - удаление выполнено, false - удаление не проведено</returns>
    void Clear(object oldobjectMd);
  }
}
