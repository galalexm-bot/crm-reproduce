using System.Net;
using System.Web.Services.Discovery;
using System.Web.Services.Protocols;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Scripts.ServiceReference;

public class WebServiceDiscoveryClientProtocol : DiscoveryClientProtocol
{
	private HttpWebResponse lastResponseReceived;

	private static WebServiceDiscoveryClientProtocol qwj45HWFJIQ3DMkJLjbJ;

	public bool IsAuthenticationRequired
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (lastResponseReceived != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
						{
							num2 = 0;
						}
						break;
					}
					return false;
				default:
					return W77XD8WFrw7rwmITxYkG(lastResponseReceived) == HttpStatusCode.Unauthorized;
				}
			}
		}
	}

	public WebServiceDiscoveryClientProtocol()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		NNXF3pWFldljj5cZV3sY();
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

	public HttpAuthenticationHeader GetAuthenticationHeader()
	{
		//Discarded unreachable code: IL_0065, IL_0074
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (lastResponseReceived == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			default:
				return new HttpAuthenticationHeader(lastResponseReceived.Headers);
			case 1:
				return null;
			}
		}
	}

	protected override WebResponse GetWebResponse(WebRequest request)
	{
		int num = 1;
		int num2 = num;
		WebResponse webResponse = default(WebResponse);
		while (true)
		{
			switch (num2)
			{
			default:
				lastResponseReceived = webResponse as HttpWebResponse;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return webResponse;
			case 1:
				webResponse = (WebResponse)CK2II2WFgaqh3QeSeFJU(this, request);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void NNXF3pWFldljj5cZV3sY()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool SvrKHhWF9PNNMtsxs8ue()
	{
		return qwj45HWFJIQ3DMkJLjbJ == null;
	}

	internal static WebServiceDiscoveryClientProtocol W7dB5xWFdfMG8wyZdD3t()
	{
		return qwj45HWFJIQ3DMkJLjbJ;
	}

	internal static HttpStatusCode W77XD8WFrw7rwmITxYkG(object P_0)
	{
		return ((HttpWebResponse)P_0).StatusCode;
	}

	internal static object CK2II2WFgaqh3QeSeFJU(object P_0, object P_1)
	{
		return ((HttpWebClientProtocol)P_0).GetWebResponse((WebRequest)P_1);
	}
}
