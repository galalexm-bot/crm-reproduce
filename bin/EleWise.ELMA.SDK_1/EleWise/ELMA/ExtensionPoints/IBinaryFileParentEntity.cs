// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ExtensionPoints.IBinaryFileParentEntity
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Files;
using EleWise.ELMA.Model.Entities;
using System;

namespace EleWise.ELMA.ExtensionPoints
{
  /// <summary>Получить парентовую сущность по файлу</summary>
  [ExtensionPoint(ServiceScope.Application, ComponentType.All)]
  public interface IBinaryFileParentEntity
  {
    /// <summary>Получить сущность по файлу</summary>
    /// <param name="file"></param>
    /// <returns></returns>
    IEntity GetEntity(BinaryFile file);

    /// <summary>Создать исключение шифрования</summary>
    /// <param name="id"></param>
    /// <returns></returns>
    SystemException CreateEncryptException(object id);
  }
}
