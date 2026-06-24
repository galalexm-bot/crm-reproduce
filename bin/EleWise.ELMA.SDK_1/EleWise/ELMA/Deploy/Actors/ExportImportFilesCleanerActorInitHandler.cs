// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Actors.ExportImportFilesCleanerActorInitHandler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Threading.Tasks;

namespace EleWise.ELMA.Deploy.Actors
{
  /// <summary>
  /// Точка расширения для активации <see cref="T:EleWise.ELMA.Deploy.Actors.IExportImportFileCleanerActor" />
  /// </summary>
  [Component(Type = ComponentType.Server)]
  internal sealed class ExportImportFilesCleanerActorInitHandler : IActorInitHandler
  {
    internal static ExportImportFilesCleanerActorInitHandler JxkEJFEccmt2ExfYcjYU;

    /// <inheritdoc />
    public Task Init(IActorModelRuntime actorModelRuntime) => actorModelRuntime.GetActor<IExportImportFileCleanerActor>(Guid.Empty).Start();

    public ExportImportFilesCleanerActorInitHandler()
    {
      ExportImportFilesCleanerActorInitHandler.VVyc55EzB8GeipJhrcUM();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool bGEDvREczdEldtwTpU0B() => ExportImportFilesCleanerActorInitHandler.JxkEJFEccmt2ExfYcjYU == null;

    internal static ExportImportFilesCleanerActorInitHandler UYQi2NEzFY7YUQE121Uj() => ExportImportFilesCleanerActorInitHandler.JxkEJFEccmt2ExfYcjYU;

    internal static void VVyc55EzB8GeipJhrcUM() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
