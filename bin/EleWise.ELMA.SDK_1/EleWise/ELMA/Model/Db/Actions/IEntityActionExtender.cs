// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Db.Actions.IEntityActionExtender
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Model.Db.Actions
{
  [ExtensionPoint(ServiceScope.Application, ComponentType.All)]
  public interface IEntityActionExtender
  {
    void Extend(IDbModelUpdater updater, EntityMetadata metadata);
  }
}
