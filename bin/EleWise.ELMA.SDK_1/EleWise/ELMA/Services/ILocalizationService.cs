// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.ILocalizationService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Security;
using System.Globalization;

namespace EleWise.ELMA.Services
{
  public interface ILocalizationService
  {
    /// <summary>Установить культуру для текущего пользователя</summary>
    /// <param name="info">Культура</param>
    void Save(CultureInfo info);

    /// <summary>Установить культуру для указанного пользователя</summary>
    /// <param name="info">Культура</param>
    /// <param name="user">Пользователь</param>
    void Save(CultureInfo info, IUser user);

    /// <summary>Получить сохраненный язык для текущего пользователя</summary>
    /// <returns></returns>
    CultureInfo Load();

    /// <summary>Получить локаль конкретного пользователя</summary>
    /// <param name="user"></param>
    /// <returns></returns>
    CultureInfo Load(IUser user);

    /// <summary>Если есть сохраненная культур , установить ее</summary>
    void InitCulture();

    /// <summary>Системная локаль по умолчанию</summary>
    CultureInfo DefaultCulture { get; }

    /// <summary>Установить системную локаль по умолчанию</summary>
    /// <param name="name"></param>
    void SetDefaultCulture(string name);
  }
}
