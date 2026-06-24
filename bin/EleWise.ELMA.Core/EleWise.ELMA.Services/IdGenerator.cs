using System;
using System.Collections.Generic;
using EleWise.ELMA.Core.ComponentModel;

namespace EleWise.ELMA.Services;

[Service]
internal sealed class IdGenerator : IIdGenerator
{
	private readonly Dictionary<Guid, long> lastIdsByTypeUid = new Dictionary<Guid, long>();

	public long GenerateNewId(Guid typeUid)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		long num = default(long);
		if (!lastIdsByTypeUid.TryGetValue(typeUid, ref num))
		{
			num = 0L;
		}
		lastIdsByTypeUid.set_Item(typeUid, --num);
		return num;
	}
}
