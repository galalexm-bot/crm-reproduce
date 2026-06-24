// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.IMembershipService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.Security
{
  /// <summary>Сервис управления учетными записями пользователей</summary>
  public interface IMembershipService
  {
    /// <summary>Получить настройки сервиса</summary>
    /// <returns>Настройки сервиса</returns>
    MembershipSettings GetSettings();

    /// <summary>Получить настройки сервиса</summary>
    /// <returns>Настройки сервиса</returns>
    MembershipSettings GetSettings(IUser user);

    /// <summary>Создать пользователя</summary>
    /// <param name="createUserParams">Параметры создания</param>
    /// <returns>Новый пользователь</returns>
    IUser CreateUser(CreateUserParams createUserParams);

    /// <summary>Получить пользователя по имени</summary>
    /// <param name="username">Имя учетной записи</param>
    /// <returns>Пользователь, или <c>null</c></returns>
    IUser GetUser(string username);

    /// <summary>Получить пользователя по идентификатору</summary>
    /// <param name="userId">Идентификатор пользователя</param>
    /// <returns>Пользователь, или <c>null</c></returns>
    IUser GetUser(object userId);

    /// <summary>Проверить авторизацию пользователя</summary>
    /// <param name="userNameOrEmail">Имя пользователя</param>
    /// <param name="password">Пароль</param>
    /// <returns><c>true</c>, если пользователь успешно авторизован</returns>
    IUser ValidateUser(string userNameOrEmail, string password);

    /// <summary>Установить новый пароль для пользователя</summary>
    /// <param name="user"></param>
    /// <param name="password"></param>
    void SetPassword(IUser user, string password);

    /// <summary>Получить количество неудачных попыток входа</summary>
    /// <param name="userName">Логин пользователя</param>
    /// <returns>Количество неудачных попыток входа</returns>
    long GetFailedLogon(string userName);

    /// <summary>Проверить обязательность смены пароля</summary>
    /// <param name="userId">Идентификатор пользователя</param>
    void CheckRequireChangePassword(object userId);
  }
}
