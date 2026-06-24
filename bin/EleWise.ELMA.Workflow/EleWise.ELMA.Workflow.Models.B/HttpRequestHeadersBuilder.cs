using System.Collections.Specialized;
using System.Net;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Models.BackgroundOperations.HttpRequest;

public class HttpRequestHeadersBuilder
{
	private HttpRequestOptionalParametersBuilder optionalHttpBuilder;

	private HttpRequestBackgroundOperation operation;

	internal static HttpRequestHeadersBuilder BnYDvIOCwBYXtCdEmAg9;

	internal HttpRequestHeadersBuilder(HttpRequestOptionalParametersBuilder optionalHttpBuilder, HttpRequestBackgroundOperation operation)
	{
		//Discarded unreachable code: IL_001e
		RWtJcpOMKtYgYE2DmJ7T();
		base._002Ector();
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				this.operation = operation;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6fe3beca34a9422e873cd6ef331760ae != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 2:
				this.optionalHttpBuilder = optionalHttpBuilder;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0991fd79553c4ecc82e8b5cb79c2bff2 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public HttpRequestOptionalParametersBuilder Add(string headerName, string value)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				OwiQyoOMOq0SQOAjHXiX(operation.Headers, headerName, value);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return optionalHttpBuilder;
			}
		}
	}

	public HttpRequestOptionalParametersBuilder Add(HttpRequestHeader header, string value)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return optionalHttpBuilder;
			case 1:
				r7GBuVOMvYFQMY0eZXCv(cs04x1OMZxXIZitIhBbS(operation), header, value);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1c37d4e24e094858975336738e156495 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public HttpRequestOptionalParametersBuilder Set(string headerName, string value)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return optionalHttpBuilder;
			case 1:
				((NameValueCollection)cs04x1OMZxXIZitIhBbS(operation)).Set(headerName, value);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4ef74b4b7d13430e9d2f9b78cbdb367b == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public HttpRequestOptionalParametersBuilder Set(HttpRequestHeader header, string value)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return optionalHttpBuilder;
			case 1:
				s2iF7POMYiTmBEAsDr5r(cs04x1OMZxXIZitIhBbS(operation), header, value);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5c45a6e5a4614bfba7591d8a1c7ced1d != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void RWtJcpOMKtYgYE2DmJ7T()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool ehC7FlOC4TGbaFwBOr7h()
	{
		return BnYDvIOCwBYXtCdEmAg9 == null;
	}

	internal static HttpRequestHeadersBuilder UXdtwlOCz6DkEXfoFRXd()
	{
		return BnYDvIOCwBYXtCdEmAg9;
	}

	internal static void OwiQyoOMOq0SQOAjHXiX(object P_0, object P_1, object P_2)
	{
		((NameValueCollection)P_0).Add((string)P_1, (string)P_2);
	}

	internal static object cs04x1OMZxXIZitIhBbS(object P_0)
	{
		return ((HttpRequestBackgroundOperation)P_0).Headers;
	}

	internal static void r7GBuVOMvYFQMY0eZXCv(object P_0, HttpRequestHeader P_1, object P_2)
	{
		((WebHeaderCollection)P_0).Add(P_1, (string)P_2);
	}

	internal static void s2iF7POMYiTmBEAsDr5r(object P_0, HttpRequestHeader P_1, object P_2)
	{
		((WebHeaderCollection)P_0).Set(P_1, (string)P_2);
	}
}
