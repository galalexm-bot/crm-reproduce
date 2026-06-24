using System;
using System.Net;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.BackgroundOperations;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Models.BackgroundOperations.HttpRequest;

[Serializable]
internal class HttpRequestBackgroundOperation : BaseBackgroundOperationWithCallbacks
{
	private static HttpRequestBackgroundOperation Od01rKOM8afalYZTUQ3V;

	public Uri RequestUri
	{
		[CompilerGenerated]
		get
		{
			return _003CRequestUri_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003CRequestUri_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_46e05b4e09174e34a9c81741b8b77a2f != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public string ContentType
	{
		[CompilerGenerated]
		get
		{
			return _003CContentType_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003CContentType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public string Method
	{
		[CompilerGenerated]
		get
		{
			return _003CMethod_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					_003CMethod_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public WebHeaderCollection Headers
	{
		[CompilerGenerated]
		get
		{
			return _003CHeaders_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					_003CHeaders_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f2d402219199402696ade21eab23d086 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public PayloadBody Payload
	{
		[CompilerGenerated]
		get
		{
			return _003CPayload_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					_003CPayload_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public HttpRequestBackgroundOperation()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7de614af35034bd0a6867d08a2ee4a84 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				return;
			case 1:
				Payload = new PayloadBody();
				num = 2;
				continue;
			}
			Headers = new WebHeaderCollection();
			num = 1;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f05298ca2a4a4a639a58bc7f7d9ff7b9 != 0)
			{
				num = 1;
			}
		}
	}

	internal static bool SDijnSOMs7pbRKVicHVS()
	{
		return Od01rKOM8afalYZTUQ3V == null;
	}

	internal static HttpRequestBackgroundOperation z7owt6OMJYZ0cUEi4dqk()
	{
		return Od01rKOM8afalYZTUQ3V;
	}
}
