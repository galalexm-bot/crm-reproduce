using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Extensions;

public static class TransformationProviderExtensions
{
	public static void ExecuteInNewTransaction([NotNull] this ITransformationProvider transformation, [NotNull] Action<ITransformationProvider> doAction, bool throwOnError = false)
	{
		Contract.ArgumentNotNull(transformation, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1335257383));
		Contract.ArgumentNotNull(doAction, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x269E5FCA ^ 0x269A553C));
		using ITransformationProvider transformationProvider = transformation.CreateWithNewConnection();
		try
		{
			transformationProvider.BeginTransaction();
			doAction(transformationProvider);
			transformationProvider.CommitTransaction();
		}
		catch (Exception message)
		{
			transformationProvider?.RollbackTransaction();
			Logger.Log.Error(message);
			if (throwOnError)
			{
				throw;
			}
		}
	}
}
