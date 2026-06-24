using System;
using System.Collections;
using System.Collections.Generic;
using EleWise.ELMA.Core.Api;

namespace EleWise.ELMA.DynamicProxy;

internal sealed class RequestParameters
{
	private readonly string _003CUrl_003Ek__BackingField;

	private readonly System.Type _003CReturnType_003Ek__BackingField;

	private readonly object _003CData_003Ek__BackingField;

	private readonly RequestOptions _003COptions_003Ek__BackingField;

	private readonly System.DateTime _003CRequestTime_003Ek__BackingField;

	private string _003CKey_003Ek__BackingField;

	public string Url => _003CUrl_003Ek__BackingField;

	public System.Type ReturnType => _003CReturnType_003Ek__BackingField;

	public object Data => _003CData_003Ek__BackingField;

	public RequestOptions Options => _003COptions_003Ek__BackingField;

	public System.DateTime RequestTime => _003CRequestTime_003Ek__BackingField;

	public string Key
	{
		get
		{
			return _003CKey_003Ek__BackingField;
		}
		private set
		{
			_003CKey_003Ek__BackingField = value;
		}
	}

	public RequestParameters(string url, System.Type returnType, object data, RequestOptions options)
	{
		_003CUrl_003Ek__BackingField = url;
		_003CReturnType_003Ek__BackingField = returnType;
		_003CData_003Ek__BackingField = data;
		_003COptions_003Ek__BackingField = options;
		_003CRequestTime_003Ek__BackingField = System.DateTime.get_Now();
	}

	public void SaveRequestTime()
	{
		Key = Key + "_" + ((object)RequestTime.get_Ticks()).ToString();
	}

	public override string ToString()
	{
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		if (string.IsNullOrEmpty(Key))
		{
			string text = Url + ((ReturnType != null) ? ((object)((object)ReturnType).GetHashCode()).ToString() : "") + ((Data != null) ? ((object)Data.GetHashCode()).ToString() : "");
			if (Options != null && Options.Headers != null)
			{
				System.Collections.Generic.IEnumerator<KeyValuePair<string, string>> enumerator = ((System.Collections.Generic.IEnumerable<KeyValuePair<string, string>>)Options.Headers).GetEnumerator();
				try
				{
					while (((System.Collections.IEnumerator)enumerator).MoveNext())
					{
						KeyValuePair<string, string> current = enumerator.get_Current();
						text = text + current.get_Key() + current.get_Value();
					}
				}
				finally
				{
					((System.IDisposable)enumerator)?.Dispose();
				}
			}
			Key = text;
		}
		return Key;
	}
}
