using System;
using System.Collections.Specialized;
using System.Net;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Models.BackgroundOperations.HttpRequest;

[Serializable]
public class HttpResponse
{
	private long _contentLength;

	private WebHeaderCollection _headers;

	private string _contentType;

	private Uri _responseUri;

	private string _server;

	private HttpStatusCode _statusCode;

	private string _statusDescription;

	private PayloadBody _payload;

	internal static HttpResponse QnZMWoOMtIZb2hewNpnI;

	public long ContentLength => _contentLength;

	public string ContentType => _contentType;

	public WebHeaderCollection Headers => _headers;

	public Uri ResponseUri => _responseUri;

	public string Server => _server;

	public HttpStatusCode StatusCode => _statusCode;

	public string StatusDescription => _statusDescription;

	public PayloadBody Body => _payload;

	public HttpResponse()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		jjas9oOMgl441mkgvOZD();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5d3bc916b5664717ac60544de077bd16 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				_headers = new WebHeaderCollection();
				num = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d87d9a74c9e14f96a288cc3620965fe0 == 0)
				{
					num = 1;
				}
				break;
			case 1:
				_payload = new PayloadBody();
				num = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5c45a6e5a4614bfba7591d8a1c7ced1d == 0)
				{
					num = 2;
				}
				break;
			case 2:
				return;
			}
		}
	}

	public HttpResponse(WebResponse response, byte[] body)
	{
		//Discarded unreachable code: IL_001a, IL_001f, IL_00dd, IL_00ec
		jjas9oOMgl441mkgvOZD();
		base._002Ector();
		int num = 2;
		HttpWebResponse httpWebResponse = default(HttpWebResponse);
		while (true)
		{
			switch (num)
			{
			case 1:
				httpWebResponse = response as HttpWebResponse;
				num = 6;
				break;
			case 6:
				if (httpWebResponse == null)
				{
					num = 3;
					break;
				}
				goto case 12;
			case 10:
				_responseUri = response.ResponseUri;
				num = 7;
				break;
			case 12:
				_server = httpWebResponse.Server;
				num = 9;
				break;
			case 11:
				_statusDescription = httpWebResponse.StatusDescription;
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 == 0)
				{
					num = 0;
				}
				break;
			case 5:
				_contentType = (string)CZ5EOROMc655RlLAZxSJ(response);
				num = 10;
				break;
			case 8:
				return;
			case 4:
				iFhg58OMPKU1V6mkOGaR(_headers, response.Headers);
				num = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7ed81ca3cf804abbade4684f28f485d1 != 0)
				{
					num = 1;
				}
				break;
			case 9:
				_statusCode = HUGs2wOMXgb9FNdkPnPB(httpWebResponse);
				num = 11;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1de08766357542bdb81146373079f817 == 0)
				{
					num = 4;
				}
				break;
			case 7:
				_headers = new WebHeaderCollection();
				num = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 == 0)
				{
					num = 4;
				}
				break;
			case 2:
				_contentLength = lPwkAqOMBWwFhG4SyYmu(response);
				num = 5;
				break;
			default:
				_payload = new PayloadBody(body);
				num = 8;
				break;
			}
		}
	}

	internal static void jjas9oOMgl441mkgvOZD()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool KfytAUOMb8Jxo043ICax()
	{
		return QnZMWoOMtIZb2hewNpnI == null;
	}

	internal static HttpResponse npLUETOM5hOku1gY5tUF()
	{
		return QnZMWoOMtIZb2hewNpnI;
	}

	internal static long lPwkAqOMBWwFhG4SyYmu(object P_0)
	{
		return ((WebResponse)P_0).ContentLength;
	}

	internal static object CZ5EOROMc655RlLAZxSJ(object P_0)
	{
		return ((WebResponse)P_0).ContentType;
	}

	internal static void iFhg58OMPKU1V6mkOGaR(object P_0, object P_1)
	{
		((NameValueCollection)P_0).Add((NameValueCollection)P_1);
	}

	internal static HttpStatusCode HUGs2wOMXgb9FNdkPnPB(object P_0)
	{
		return ((HttpWebResponse)P_0).StatusCode;
	}
}
