// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ActorModel.Publication.IGlobalScriptModulePublicationActor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ActorModel.Attributes;
using System.Threading.Tasks;

namespace EleWise.ELMA.ActorModel.Publication
{
  /// <summary>
  /// Интерфейс актора публикации глобального модуля <see cref="T:EleWise.ELMA.Model.Scripts.IGlobalScriptModule" />
  /// </summary>
  [FeatureFlagManaged("Publication.Actor.Enabled", true)]
  internal interface IGlobalScriptModulePublicationActor : IActorWithIntegerKey, IActor
  {
    /// <summary>Опубликовать глобальный модуль</summary>
    Task Publish();

    /// <summary>Завершение публикации</summary>
    Task PublicationComplete();
  }
}
