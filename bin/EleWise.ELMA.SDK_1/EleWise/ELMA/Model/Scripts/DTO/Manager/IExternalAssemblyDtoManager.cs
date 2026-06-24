// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.DTO.Manager.IExternalAssemblyDtoManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Scripts.DTO.Models;
using System;

namespace EleWise.ELMA.Model.Scripts.DTO.Manager
{
  public interface IExternalAssemblyDtoManager : IConfigurationService
  {
    ExternalAssemblyDto LoadOrNull(Guid uid);

    ExternalAssemblyDto Load(string hashCode);

    string GetHashCode(Guid uid);

    Guid? Exist(string hashCode);

    void Save(ExternalAssemblyDto externalAssembly);
  }
}
