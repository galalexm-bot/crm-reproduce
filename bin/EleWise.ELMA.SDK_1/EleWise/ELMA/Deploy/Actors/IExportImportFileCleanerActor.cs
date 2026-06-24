// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Actors.IExportImportFileCleanerActor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ActorModel.Abstractions;
using System.Threading.Tasks;

namespace EleWise.ELMA.Deploy.Actors
{
  /// <summary>Интерфейс актора запуска очистки файлов</summary>
  internal interface IExportImportFileCleanerActor : IActorWithGuidKey, IActor
  {
    /// <summary>Запустить очистку папки</summary>
    Task Start();
  }
}
