using System;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Engine.Storage.Abstractions;

namespace EleWise.ELMA.DTO;

[Service]
internal sealed class SystemProxyMetadataReferencesStorage : ISystemProxyMetadataReferencesStorage, ISystemMetadataReferencesStorage
{
	private Func<string, string> _003CGetMetadataUidFunc_003Ek__BackingField;

	public Func<string, string> GetMetadataUidFunc
	{
		get
		{
			return _003CGetMetadataUidFunc_003Ek__BackingField;
		}
		set
		{
			_003CGetMetadataUidFunc_003Ek__BackingField = value;
		}
	}

	public string GetMetadataUid(string typeName)
	{
		if (GetMetadataUidFunc != null)
		{
			return GetMetadataUidFunc.Invoke(typeName);
		}
		return null;
	}
}
