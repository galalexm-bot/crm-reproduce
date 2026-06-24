// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Services.ISspiService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.Security.Services
{
  public interface ISspiService
  {
    /// <summary>Проверить авторизацию пользователя по SSPI тикету</summary>
    /// <param name="sspiTicket">Тикет SSPI</param>
    /// <param name="userAgent">UserAgent</param>
    /// <param name="userHostAddress">Адрес хоста</param>
    /// <returns></returns>
    IUser ValidateUser(string sspiTicket, string userAgent, string userHostAddress);
  }
}
