// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.IRemotingAssemblyResolverService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.Services
{
  /// <summary>
  /// Сервис получения сборок по Remoting-у (сервис доступен в дизайнере при подключении через Remoting)
  /// </summary>
  public interface IRemotingAssemblyResolverService
  {
    /// <summary>
    /// Получить Raw загруженной сборки. Если не найдена - возвращается null.
    /// </summary>
    /// <param name="assemblyName">Имя сборки</param>
    /// <param name="isFullName">True, если поиск ведется по полному имени сборки</param>
    /// <returns>Raw загруженной сборки</returns>
    byte[] ResolveAssembly(string assemblyName, bool isFullName);
  }
}
