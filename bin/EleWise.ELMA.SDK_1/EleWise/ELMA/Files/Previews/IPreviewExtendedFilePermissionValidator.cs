// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Files.Previews.IPreviewExtendedFilePermissionValidator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Files.Previews
{
  /// <summary>Расширенный валидатор доступа к файлу для превью</summary>
  [ExtensionPoint(ServiceScope.Application, ComponentType.All)]
  public interface IPreviewExtendedFilePermissionValidator
  {
    /// <summary>Есть ли привилегия к файлу</summary>
    /// <param name="containsEntity">Сущность содержащая файл</param>
    /// <param name="file">Файл</param>
    PreviewPermissionValidatorResult HasPermission(object containsEntity, BinaryFile file);
  }
}
