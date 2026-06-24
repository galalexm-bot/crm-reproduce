// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Globalization.ITranslateDTOManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ExtensionPoints;

namespace EleWise.ELMA.Globalization
{
  public interface ITranslateDTOManager : IConfigurationService
  {
    /// <summary>Включен ли режим перевода на сервере</summary>
    /// <returns></returns>
    bool IsTranslationMode();

    /// <summary>Языки на сервере</summary>
    /// <returns></returns>
    string[] GetServerLocals();

    /// <summary>Изменились ли файлы локали на сервере</summary>
    /// <param name="designerLocalizationHash"></param>
    /// <returns></returns>
    bool IsTranslationChanged(LocalizationHash[] designerLocalizationHash);

    /// <summary>Получить измененные переводы с сервера</summary>
    /// <param name="designerLocalizationHash"></param>
    /// <returns></returns>
    byte[] GetTranslations(LocalizationHash[] designerLocalizationHash);

    /// <summary>Загрузить информацию по базовой локали сервера</summary>
    /// <returns></returns>
    CultureInfoSimple GetDefaultLocal();
  }
}
