// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.IIconPackService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model;

namespace EleWise.ELMA.Services
{
  /// <summary>
  /// Интерфейс сервиса предоставляющий доступ до объектов директории IconPack
  /// </summary>
  public interface IIconPackService : IConfigurationService
  {
    /// <summary>Получить иконку по наименованию</summary>
    /// <param name="name">Наименование иконки</param>
    /// <example>IconPackService.GetIcon("edit")</example>
    /// <returns></returns>
    IconModel GetIcon(string name);
  }
}
