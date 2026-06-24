// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Remoting.Security.ChannelSinkHeaders
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Remoting.Security
{
  /// <summary>
  /// Заголовки в пакетах, передаваемых между сервером и дизайнером через Remoting
  /// </summary>
  internal class ChannelSinkHeaders
  {
    /// <summary>Номер версии</summary>
    public const string Version = "Security_Version";
    /// <summary>Имя пользователя</summary>
    public const string UserName = "Security_UserName";
    /// <summary>Пароль</summary>
    public const string Password = "Security_Password";
    /// <summary>Токен</summary>
    public const string Token = "Security_Token";
    /// <summary>Id авторизованного пользователя</summary>
    public const string UserId = "Security_UserId";
    /// <summary>Локаль дизайнера</summary>
    public const string CultureInfoName = "Security_CultureInfoName";
    /// <summary>Тип класса исключения при удаленном вызове</summary>
    public const string ExceptionType = "Security_ExceptionType";
    /// <summary>Сообщение исключения при удаленном вызове</summary>
    public const string ExceptionMessage = "Security_ExceptionMessage";
    internal static ChannelSinkHeaders O7BNlGk1jLWThckNJ63;

    public ChannelSinkHeaders()
    {
      ChannelSinkHeaders.WBAA5gkpeRlAVcBuxHX();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void WBAA5gkpeRlAVcBuxHX() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool h30p6ikNdsid1JE5PC4() => ChannelSinkHeaders.O7BNlGk1jLWThckNJ63 == null;

    internal static ChannelSinkHeaders yDhtAdk3U09WNilbtHi() => ChannelSinkHeaders.O7BNlGk1jLWThckNJ63;
  }
}
