// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.Public.IPublicServiceMethod
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Common;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Model.Attributes;
using System;

namespace EleWise.ELMA.Services.Public
{
  /// <summary>
  /// Базовый интерфейс для определения публичного метода для сервисов <see cref="T:EleWise.ELMA.Services.Public.IPublicService" />
  /// </summary>
  [DeveloperApi(DeveloperApiType.ExtensionPoint)]
  public interface IPublicServiceMethod
  {
    /// <summary>
    /// Идентификатор сервиса, к которому относится данный метод
    /// </summary>
    Guid ServiceUid { get; }

    /// <summary>
    /// Имя метода.
    /// Должно содержать только английские символы.
    /// Используется как часть пути доступа к методу.
    /// </summary>
    string Name { get; }

    /// <summary>Описание метода</summary>
    string Description { get; }

    /// <summary>
    /// Версия метода в API.
    /// Задается в соответствии с правилами описанными в EleWise.ELMA.API.PublicContractInfo.ApiVersionString
    /// </summary>
    Version Version { get; }

    /// <summary>Выполнить действие метода</summary>
    /// <param name="parameters">Входящий параметр в формате универсальных данных</param>
    /// <returns>Результат выполнения в формате универсальных данных</returns>
    WebData Execute(WebData parameters);

    /// <summary>Описание данных для входящего параметра</summary>
    TypeSerializationDescriptor ParametersDescriptor { get; }

    /// <summary>Описание результата выполнения</summary>
    TypeSerializationDescriptor ResultDescriptor { get; }
  }
}
