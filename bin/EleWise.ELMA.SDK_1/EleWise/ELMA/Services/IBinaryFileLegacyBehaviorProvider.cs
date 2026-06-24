// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.IBinaryFileLegacyBehaviorProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Files;
using System;

namespace EleWise.ELMA.Services
{
  /// <summary>
  /// Провайдер обратной совместимости при работе с BinaryFile.
  /// </summary>
  /// <remarks>
  /// <para>
  /// Применим только в штатного провайдере!
  /// В KB (например, https://www.elma-bpm.ru/KB/article-5499.html) описан вариант добавления версии документа
  /// с созданием BinaryFile-а через такой код:
  /// </para>
  /// <para>
  /// context.Fayl = InterfaceActivator.Create{BinaryFile}();
  /// context.Fayl.Name="Name.docx";
  /// context.Fayl.CreateDate = DateTime.Now;
  /// context.Fayl.InitializeContentFilePath();
  /// System.IO.File.Copy(@"c:\Шаблон1.docx", context.Fayl.ContentFilePath);
  /// </para>
  /// <para>
  /// Последние две строчки для распределённого провайдера не работают - способ хранения контента изменился, как и способ создания BinaryFile-а.
  /// Соответственно изменились и подходы к работе с объектами BinaryFile-ов внутри провайдеров.
  /// Однако данное решение наверняка было широко растиражировано и необходимо обеспечить его работоспособность в штатном провайдере.
  /// Этот интерфейс как раз для этого.
  /// </para>
  /// </remarks>
  public interface IBinaryFileLegacyBehaviorProvider
  {
    /// <summary>
    /// Инициализировать местоположение контента.
    /// Создаёт ссылку на контент, но не создаёт сам файл.
    /// </summary>
    /// <param name="binaryFile">Файл, у которого будет инициализировано местоположение контента.</param>
    /// <returns>Ссылку на местоположение контента.</returns>
    Uri InitializeContentLocation(BinaryFile binaryFile);

    /// <summary>Получить размер контента в режиме совместимости.</summary>
    /// <param name="binaryFile">Файл, размер которого нужно определить.</param>
    /// <returns>Размер файла, либо null, если файл не существует.</returns>
    long? GetLength(BinaryFile binaryFile);

    /// <summary>Получить crc файла в режиме совместимости.</summary>
    /// <param name="binaryFile">Файл, crc которого нужно определить.</param>
    /// <returns>Crc файла, либо null, если файл не существует.</returns>
    uint? GetCrc(BinaryFile binaryFile);
  }
}
