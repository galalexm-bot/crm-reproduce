using System;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using EleWise.ELMA.Components;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.BackgroundOperations;
using EleWise.ELMA.Workflow.Models.BackgroundOperations.HttpRequest;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Components.BackgroundOperations;

internal class HttpRequestTaskExecutor : BackgroundOperationExecutorBase
{
	private string[] sendDataMethods;

	internal static HttpRequestTaskExecutor WiPiKdOBUTZG6c0QQmdG;

	public override bool CanExecute(IBackgroundOperation executionInfo)
	{
		return executionInfo is HttpRequestBackgroundOperation;
	}

	public override string GetDescription(IBackgroundOperation executionInfo)
	{
		int num = 1;
		int num2 = num;
		HttpRequestBackgroundOperation httpRequestBackgroundOperation = default(HttpRequestBackgroundOperation);
		while (true)
		{
			switch (num2)
			{
			case 1:
				httpRequestBackgroundOperation = executionInfo as HttpRequestBackgroundOperation;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_60c5782a184b457aa78da2e5c62d4e27 == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return string.Empty;
			}
			if (httpRequestBackgroundOperation == null)
			{
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 != 0)
				{
					num2 = 2;
				}
				continue;
			}
			return (string)KhbvjFOBouolJC22datL(pThu9IOBGi6kFYVVbU2A(-45832783 ^ -45781497), new object[2]
			{
				dZFrW7OB7EJWfJUCbjnj(httpRequestBackgroundOperation),
				KbcVCvOB2M3vlTDcgFKd(httpRequestBackgroundOperation)
			});
		}
	}

	protected override Task<object> RunTaskImpl(IBackgroundOperation executionInfo, CancellationToken token)
	{
		_003C_003Ec__DisplayClass2_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass2_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.info = CastTo<HttpRequestBackgroundOperation>(executionInfo);
		CS_0024_003C_003E8__locals0.request = GetWebRequest(CS_0024_003C_003E8__locals0.info);
		return (sendDataMethods.Contains(CS_0024_003C_003E8__locals0.info.Method.ToUpper()) ? CS_0024_003C_003E8__locals0.request.GetRequestStreamAsync().Then((Stream stream) => CS_0024_003C_003E8__locals0._003C_003E4__this.SendRequestBodyAsync((Stream)_003C_003Ec__DisplayClass2_0.Yc1uHDvvofiVnNnWUunW(_003C_003Ec__DisplayClass2_0.m3RZuBvv2NCOeqolVC8n(CS_0024_003C_003E8__locals0.info)), stream), token).Then(() => CS_0024_003C_003E8__locals0.request.GetResponseAsync(), token) : CS_0024_003C_003E8__locals0.request.GetResponseAsync()).Then((Func<WebResponse, Task<object>>)GetHttpResponseAsync, token);
	}

	private WebRequest GetWebRequest(HttpRequestBackgroundOperation taskInfo)
	{
		//Discarded unreachable code: IL_005c, IL_006b
		int num = 2;
		int num2 = num;
		WebRequest webRequest = default(WebRequest);
		while (true)
		{
			switch (num2)
			{
			case 5:
				UcJj3GOBrvT3MeygVpw1(hdVuZMOBIMakWVW6Rowo(webRequest), gAga1tOBaZRLcwTDRLjN(taskInfo));
				num2 = 4;
				break;
			case 3:
			case 6:
				return webRequest;
			default:
				HQlLhpOBxxYyDgR7tV5J(webRequest, qH27ZWOBNLAKZTdM8kVB(taskInfo));
				num2 = 3;
				break;
			case 4:
				if (uBVPmjOBeHLbkDsECyrr(taskInfo.ContentType))
				{
					num2 = 6;
					break;
				}
				goto default;
			case 1:
				JgCEacOBinPV1LFl3FfO(webRequest, dZFrW7OB7EJWfJUCbjnj(taskInfo));
				num2 = 5;
				break;
			case 2:
				webRequest = (WebRequest)zSqDpFOBFe84FcdFaOBm(KbcVCvOB2M3vlTDcgFKd(taskInfo));
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b876fa7b083748c8abf8c4b192a11078 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private Task<object> GetHttpResponseAsync(WebResponse response)
	{
		_003C_003Ec__DisplayClass5_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass5_0();
		CS_0024_003C_003E8__locals0.response = response;
		return CS_0024_003C_003E8__locals0.response.GetResponseStream().ReadAllBytesAsync().Then((Func<byte[], object>)((byte[] buf) => new HttpResponse(CS_0024_003C_003E8__locals0.response, buf)));
	}

	private Task SendRequestBodyAsync(Stream src, Stream dest)
	{
		int num = 3;
		int num2 = num;
		_003C_003Ec__DisplayClass6_0 _003C_003Ec__DisplayClass6_ = default(_003C_003Ec__DisplayClass6_0);
		while (true)
		{
			switch (num2)
			{
			case 2:
				_003C_003Ec__DisplayClass6_.src = src;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_abfb511163674a3eae959fd60da8f319 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				return ((Task)OVoPC6OBSbKgndf3SeSS(_003C_003Ec__DisplayClass6_.src, _003C_003Ec__DisplayClass6_.dest)).ContinueWith((Action<Task>)_003C_003Ec__DisplayClass6_._003CSendRequestBodyAsync_003Eb__0);
			case 3:
				_003C_003Ec__DisplayClass6_ = new _003C_003Ec__DisplayClass6_0();
				num2 = 2;
				break;
			default:
				_003C_003Ec__DisplayClass6_.dest = dest;
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0991fd79553c4ecc82e8b5cb79c2bff2 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public HttpRequestTaskExecutor()
	{
		//Discarded unreachable code: IL_0062, IL_0067
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		sendDataMethods = new string[2]
		{
			(string)pThu9IOBGi6kFYVVbU2A(-261315199 ^ -261265007),
			SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4FD00585 ^ 0x4FD1C999)
		};
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_18b351a59a324c25b4f150a9771bcf69 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool A6eVQUOBVuSB9IIOvGlY()
	{
		return WiPiKdOBUTZG6c0QQmdG == null;
	}

	internal static HttpRequestTaskExecutor DbHgkeOBAXF6OiqE3nt7()
	{
		return WiPiKdOBUTZG6c0QQmdG;
	}

	internal static object pThu9IOBGi6kFYVVbU2A(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object dZFrW7OB7EJWfJUCbjnj(object P_0)
	{
		return ((HttpRequestBackgroundOperation)P_0).Method;
	}

	internal static object KbcVCvOB2M3vlTDcgFKd(object P_0)
	{
		return ((HttpRequestBackgroundOperation)P_0).RequestUri;
	}

	internal static object KhbvjFOBouolJC22datL(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static object zSqDpFOBFe84FcdFaOBm(object P_0)
	{
		return WebRequest.Create((Uri)P_0);
	}

	internal static void JgCEacOBinPV1LFl3FfO(object P_0, object P_1)
	{
		((WebRequest)P_0).Method = (string)P_1;
	}

	internal static object hdVuZMOBIMakWVW6Rowo(object P_0)
	{
		return ((WebRequest)P_0).Headers;
	}

	internal static object gAga1tOBaZRLcwTDRLjN(object P_0)
	{
		return ((HttpRequestBackgroundOperation)P_0).Headers;
	}

	internal static void UcJj3GOBrvT3MeygVpw1(object P_0, object P_1)
	{
		((NameValueCollection)P_0).Add((NameValueCollection)P_1);
	}

	internal static bool uBVPmjOBeHLbkDsECyrr(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object qH27ZWOBNLAKZTdM8kVB(object P_0)
	{
		return ((HttpRequestBackgroundOperation)P_0).ContentType;
	}

	internal static void HQlLhpOBxxYyDgR7tV5J(object P_0, object P_1)
	{
		((WebRequest)P_0).ContentType = (string)P_1;
	}

	internal static object OVoPC6OBSbKgndf3SeSS(object P_0, object P_1)
	{
		return ((Stream)P_0).CopyStreamToStreamAsync((Stream)P_1);
	}
}
