// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ExtensionPoints.ICryptoContextAuthServiceImpl
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.ExtensionPoints
{
  [ExtensionPoint(ServiceScope.Application, ComponentType.All)]
  public interface ICryptoContextAuthServiceImpl
  {
    /// <summary>Проверить подходит ли по типу</summary>
    /// <param name="entity"></param>
    /// <returns></returns>
    bool CheckType(IEntity entity);

    /// <summary>Залогинится в сущности</summary>
    /// <param name="entity"></param>
    /// <param name="password"></param>
    /// <returns></returns>
    bool SignInForEntity(IEntity entity, string password);

    /// <summary>Авторизован ли в документ?</summary>
    /// <param name="entity"></param>
    /// <returns></returns>
    bool IsSignForEntity(IEntity entity);

    /// <summary>Разлогиниться для документов</summary>
    /// <param name="entity"></param>
    void SignOutForEntity(IEntity entity);

    /// <summary>Расшифровать документ из контекста</summary>
    /// <param name="entity"></param>
    /// <returns></returns>
    IEntity DecryptFromContext(IEntity entity);

    /// <summary>Достать пароль из контекста</summary>
    /// <param name="entity"></param>
    /// <returns></returns>
    string GetPasswordFromContext(IEntity entity);
  }
}
