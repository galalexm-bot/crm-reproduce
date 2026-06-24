using System;
using System.Text;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Models.BackgroundOperations.HttpRequest;

public class HttpRequestBuilder
{
	private HttpRequestBackgroundOperation operation;

	internal static HttpRequestBuilder wSimJUOCIYmAaqAc3Zc4;

	public HttpRequestBuilder(string url)
	{
		//Discarded unreachable code: IL_0030, IL_0035
		Gd4u0GOCeIsLNXIPbvnt();
		this._002Ector(new Uri(url));
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_dcdfd019631e458b9cb5fa34a16a2fe1 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public HttpRequestBuilder(Uri url)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Gd4u0GOCeIsLNXIPbvnt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_db8eb3e90ad546d4b05544ab6326a49f == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
			{
				HttpRequestBackgroundOperation httpRequestBackgroundOperation = new HttpRequestBackgroundOperation();
				xMWnIsOCNgKlLwE3PeWS(httpRequestBackgroundOperation, url);
				operation = httpRequestBackgroundOperation;
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 != 0)
				{
					num = 0;
				}
				break;
			}
			}
		}
	}

	public HttpRequestOptionalParametersBuilder Get()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				nTjMCQOCxJYkNBIx1Khe(operation, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398691253 ^ -398566551));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d843b0b7f23e489fb6d586d64b0a634a != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return new HttpRequestOptionalParametersBuilder(operation);
			}
		}
	}

	public HttpRequestOptionalParametersBuilder Head()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return new HttpRequestOptionalParametersBuilder(operation);
			case 1:
				nTjMCQOCxJYkNBIx1Khe(operation, nDZ2UmOCSRY9jh48M4aY(0x5DB28AD2 ^ 0x5DB0A5FE));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_61395ebf330446ac8ce99b55ee3acfa9 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public HttpRequestOptionalParametersBuilder Delete()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				nTjMCQOCxJYkNBIx1Khe(operation, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1895853023 ^ -1895974119));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return new HttpRequestOptionalParametersBuilder(operation);
			}
		}
	}

	public HttpRequestOptionalParametersBuilder PostJson(string json)
	{
		return Post(json, (string)nDZ2UmOCSRY9jh48M4aY(-1647793954 ^ -1647671402), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1843E01F ^ 0x1841CF73));
	}

	public HttpRequestOptionalParametersBuilder PostJson(string json, string contentCharset)
	{
		return Post(json, (string)nDZ2UmOCSRY9jh48M4aY(-261315199 ^ -261190967), contentCharset);
	}

	public HttpRequestOptionalParametersBuilder PostXml(string xml)
	{
		return Post(xml, (string)nDZ2UmOCSRY9jh48M4aY(0x1EA50FCC ^ 0x1EA720B6), (string)nDZ2UmOCSRY9jh48M4aY(-980570076 ^ -980443320));
	}

	public HttpRequestOptionalParametersBuilder PostXml(string xml, string contentCharset)
	{
		return Post(xml, (string)nDZ2UmOCSRY9jh48M4aY(0xD305CC2 ^ 0xD3273B8), contentCharset);
	}

	public HttpRequestOptionalParametersBuilder Post(string content, string contentType, string contentCharset)
	{
		int num = 1;
		int num2 = num;
		byte[] bytes = default(byte[]);
		while (true)
		{
			switch (num2)
			{
			default:
				return Post(bytes, contentType, contentCharset);
			case 1:
				bytes = ((Encoding)aprQMoOC1kn8GYqZgUB2(contentCharset)).GetBytes(content);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ac5d16a577a84bb0b8ee3654769d2d33 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public HttpRequestOptionalParametersBuilder Post(byte[] body, string contentType)
	{
		return SendDataUsingMethod((string)nDZ2UmOCSRY9jh48M4aY(-432000546 ^ -431882802), body, contentType, null);
	}

	public HttpRequestOptionalParametersBuilder Post(byte[] body, string contentType, string contentCharset)
	{
		return SendDataUsingMethod((string)nDZ2UmOCSRY9jh48M4aY(0x75872B6 ^ 0x759BEA6), body, contentType, contentCharset);
	}

	public HttpRequestOptionalParametersBuilder PutJson(string json)
	{
		return Put(json, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2ACCDD87 ^ 0x2ACEF2CF), (string)nDZ2UmOCSRY9jh48M4aY(--1756698829 ^ 0x68B737A1));
	}

	public HttpRequestOptionalParametersBuilder PutJson(string json, string contentCharset)
	{
		return Put(json, (string)nDZ2UmOCSRY9jh48M4aY(-1895853023 ^ -1895974039), contentCharset);
	}

	public HttpRequestOptionalParametersBuilder PutXml(string xml)
	{
		return Put(xml, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1514166050 ^ -1514305628), (string)nDZ2UmOCSRY9jh48M4aY(0xDF4D1F8 ^ 0xDF6FE94));
	}

	public HttpRequestOptionalParametersBuilder PutXml(string xml, string contentCharset)
	{
		return Put(xml, (string)nDZ2UmOCSRY9jh48M4aY(-949717965 ^ -949593271), contentCharset);
	}

	public HttpRequestOptionalParametersBuilder Put(string content, string contentType, string contentCharset)
	{
		int num = 1;
		int num2 = num;
		byte[] body = default(byte[]);
		while (true)
		{
			switch (num2)
			{
			default:
				return Put(body, contentType, contentCharset);
			case 1:
				body = (byte[])fdg8deOChY8TFS1JVCGr(aprQMoOC1kn8GYqZgUB2(contentCharset), content);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_db8eb3e90ad546d4b05544ab6326a49f != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public HttpRequestOptionalParametersBuilder Put(byte[] body, string contentType)
	{
		return SendDataUsingMethod((string)nDZ2UmOCSRY9jh48M4aY(-684210684 ^ -684324328), body, contentType, null);
	}

	public HttpRequestOptionalParametersBuilder Put(byte[] body, string contentType, string contentCharset)
	{
		return SendDataUsingMethod((string)nDZ2UmOCSRY9jh48M4aY(-1386448964 ^ -1386366048), body, contentType, contentCharset);
	}

	public HttpRequestOptionalParametersBuilder Method(string method)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return new HttpRequestOptionalParametersBuilder(operation);
			case 1:
				nTjMCQOCxJYkNBIx1Khe(operation, method);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8a6cf36da0b84f319a7cf27018f28f5b != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private HttpRequestOptionalParametersBuilder SendDataUsingMethod(string method, byte[] body, string contentType, string contentCharset)
	{
		int num = 3;
		int num2 = num;
		HttpMediaType httpMediaType = default(HttpMediaType);
		while (true)
		{
			switch (num2)
			{
			case 2:
				nTjMCQOCxJYkNBIx1Khe(operation, method);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f05298ca2a4a4a639a58bc7f7d9ff7b9 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				FJiXHPOCEAbbp1guLFrY(operation, httpMediaType.ToString());
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 != 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				httpMediaType = new HttpMediaType(contentType, contentCharset);
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6b089b0d02ae4d3186c8d2cb8a24d4d3 != 0)
				{
					num2 = 2;
				}
				break;
			case 4:
				return new HttpRequestOptionalParametersBuilder(operation);
			case 1:
				operation.Payload = new PayloadBody(body);
				num2 = 4;
				break;
			}
		}
	}

	internal static void Gd4u0GOCeIsLNXIPbvnt()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool LnLPkiOCaTrqKnWQwMgi()
	{
		return wSimJUOCIYmAaqAc3Zc4 == null;
	}

	internal static HttpRequestBuilder CXbElfOCrWrUM3gkdFCX()
	{
		return wSimJUOCIYmAaqAc3Zc4;
	}

	internal static void xMWnIsOCNgKlLwE3PeWS(object P_0, object P_1)
	{
		((HttpRequestBackgroundOperation)P_0).RequestUri = (Uri)P_1;
	}

	internal static void nTjMCQOCxJYkNBIx1Khe(object P_0, object P_1)
	{
		((HttpRequestBackgroundOperation)P_0).Method = (string)P_1;
	}

	internal static object nDZ2UmOCSRY9jh48M4aY(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object aprQMoOC1kn8GYqZgUB2(object P_0)
	{
		return Encoding.GetEncoding((string)P_0);
	}

	internal static object fdg8deOChY8TFS1JVCGr(object P_0, object P_1)
	{
		return ((Encoding)P_0).GetBytes((string)P_1);
	}

	internal static void FJiXHPOCEAbbp1guLFrY(object P_0, object P_1)
	{
		((HttpRequestBackgroundOperation)P_0).ContentType = (string)P_1;
	}
}
