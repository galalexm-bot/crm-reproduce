// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.AutoMaps.IAutoMapConfigurator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using AutoMapper;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Model.AutoMaps
{
  [ExtensionPoint(ComponentType.All)]
  public interface IAutoMapConfigurator
  {
    void Configure(IMapperConfigurationExpression configuration);
  }
}
