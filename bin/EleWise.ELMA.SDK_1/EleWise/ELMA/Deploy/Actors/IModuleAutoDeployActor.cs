// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Actors.IModuleAutoDeployActor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ActorModel.Abstractions;
using System.Threading.Tasks;

namespace EleWise.ELMA.Deploy.Actors
{
  /// <summary>
  /// Интерфейс актора, который следит за папкой файловой системы с целью авторазвертывания пакетов, появляющихся в этой папке
  /// </summary>
  internal interface IModuleAutoDeployActor : IActorWithGuidKey, IActor
  {
    /// <summary>Запустить отслеживание папки</summary>
    /// <returns></returns>
    Task StartWatching();
  }
}
