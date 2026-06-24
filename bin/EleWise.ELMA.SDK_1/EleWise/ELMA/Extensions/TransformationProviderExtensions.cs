// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.TransformationProviderExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using SG9KiyIbtdgGDf12qr;
using System;

namespace EleWise.ELMA.Extensions
{
  public static class TransformationProviderExtensions
  {
    /// <summary>
    /// Выполнить действие в отдельной транзакции в новом соединении
    /// </summary>
    /// <param name="transformation"></param>
    /// <param name="doAction"></param>
    /// <param name="throwOnError"></param>
    public static void ExecuteInNewTransaction(
      [NotNull] this ITransformationProvider transformation,
      [NotNull] Action<ITransformationProvider> doAction,
      bool throwOnError = false)
    {
      Contract.ArgumentNotNull((object) transformation, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1335257383));
      Contract.ArgumentNotNull((object) doAction, z2jc63fLkugS1X8Q9N.tE1kD1vbB(647913418 ^ 647648572));
      using (ITransformationProvider withNewConnection = transformation.CreateWithNewConnection())
      {
        try
        {
          withNewConnection.BeginTransaction();
          doAction(withNewConnection);
          withNewConnection.CommitTransaction();
        }
        catch (Exception ex)
        {
          withNewConnection?.RollbackTransaction();
          Logger.Log.Error((object) ex);
          if (!throwOnError)
            return;
          throw;
        }
      }
    }
  }
}
