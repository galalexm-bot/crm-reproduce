// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Files.Previews.IFilePreviewArchiverService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.Files.Previews
{
  /// <summary>Архивирование превьюшек</summary>
  public interface IFilePreviewArchiverService
  {
    /// <summary>Получить путь до архива с превьюхой</summary>
    /// <param name="file">Файл</param>
    /// <returns></returns>
    string GetArchive(BinaryFile file);

    /// <summary>Удалить архив с превьюхой</summary>
    /// <param name="file"></param>
    void ClearArchive(BinaryFile file);
  }
}
