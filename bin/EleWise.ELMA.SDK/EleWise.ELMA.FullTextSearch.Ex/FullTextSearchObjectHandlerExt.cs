using System;
using System.Collections.Generic;
using EleWise.ELMA.FullTextSearch.Model;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.FullTextSearch.ExtensionPoints;

public abstract class FullTextSearchObjectHandlerExtension : IFullTextSearchObjectHandlerExtension
{
	private static FullTextSearchObjectHandlerExtension PM4pfCGqnWYcdcbZ9OmS;

	public abstract Guid Uid { get; }

	public abstract Type SupportedCard { get; }

	public abstract List<Guid> SupportedUids { get; }

	public abstract List<string> GetImportantProperties { get; }

	public virtual List<string> GetVisualDataProperties => new List<string>();

	public abstract List<QueueToIndex> ProcessingMergedIndexQueue(List<KeyValuePair<string, object>> mergedIndexQueueItem, long id, Guid typeUid);

	public virtual void OnInsertProcessing(Guid typeUid, object obj)
	{
	}

	public virtual void OnDeleteProcessing(Guid typeUid, object obj)
	{
	}

	protected FullTextSearchObjectHandlerExtension()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool qo2mT8GqOJqnNkFpSABY()
	{
		return PM4pfCGqnWYcdcbZ9OmS == null;
	}

	internal static FullTextSearchObjectHandlerExtension doKPo4Gq2tqvGlBpw9Wx()
	{
		return PM4pfCGqnWYcdcbZ9OmS;
	}
}
