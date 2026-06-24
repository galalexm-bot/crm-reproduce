using System;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.OmniSharp.Infrastructure;

internal class SimpleWebClient
{
	private Uri baseUrl;

	private static SimpleWebClient vHxD4xWrnTboZWQTHLoa;

	public SimpleWebClient(string baseUrl)
	{
		//Discarded unreachable code: IL_001a, IL_001f
		tDG22yWreoTNV3x8I4QM();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				this.baseUrl = new Uri(baseUrl);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
				{
					num = 0;
				}
				break;
			case 2:
				GCNVAGWr144XGB9xEX0O(baseUrl, MGpTtRWrP8JNLvRl8bTO(0x7459E02 ^ 0x747ABC8));
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
				{
					num = 1;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public void SetBaseUrl(string baseUrl)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				GCNVAGWr144XGB9xEX0O(baseUrl, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477276144));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
				{
					num2 = 0;
				}
				break;
			default:
				this.baseUrl = new Uri(baseUrl);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				return;
			}
		}
	}

	public virtual Task<string> Post(string endpoint, string data, Action<WebRequest> requestSetup = null)
	{
		_003C_003Ec__DisplayClass3_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass3_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		Uri requestUri = new Uri(baseUrl, endpoint);
		CS_0024_003C_003E8__locals0.req = WebRequest.Create(requestUri);
		CS_0024_003C_003E8__locals0.req.Method = z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1FFEF86A ^ 0x1FFCCDB6);
		CS_0024_003C_003E8__locals0.req.ContentType = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2106517564 ^ -2106383828);
		requestSetup?.Invoke(CS_0024_003C_003E8__locals0.req);
		return SendPayload(CS_0024_003C_003E8__locals0.req, data).Then(() => CS_0024_003C_003E8__locals0._003C_003E4__this.GetResponse(CS_0024_003C_003E8__locals0.req));
	}

	public virtual Task<string> Get(string endpoint, Action<WebRequest> requestSetup = null)
	{
		WebRequest webRequest = WebRequest.Create(new Uri(baseUrl, endpoint));
		webRequest.Method = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1822890472 ^ -1822765036);
		requestSetup?.Invoke(webRequest);
		return GetResponse(webRequest);
	}

	[AsyncStateMachine(typeof(_003CSendPayload_003Ed__5))]
	private Task SendPayload(WebRequest webRequest, string data)
	{
		int num = 4;
		int num2 = num;
		_003CSendPayload_003Ed__5 stateMachine = default(_003CSendPayload_003Ed__5);
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		while (true)
		{
			switch (num2)
			{
			default:
				return stateMachine._003C_003Et__builder.Task;
			case 2:
				_003C_003Et__builder.Start(ref stateMachine);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				stateMachine.data = data;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
				{
					num2 = 6;
				}
				break;
			case 4:
				stateMachine._003C_003E4__this = this;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				stateMachine.webRequest = webRequest;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
				{
					num2 = 1;
				}
				break;
			case 5:
				_003C_003Et__builder = stateMachine._003C_003Et__builder;
				num2 = 2;
				break;
			case 6:
				stateMachine._003C_003Et__builder = kjfy5AWrN2IJClt64Zt5();
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
				{
					num2 = 5;
				}
				break;
			case 7:
				stateMachine._003C_003E1__state = -1;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
				{
					num2 = 5;
				}
				break;
			}
		}
	}

	[AsyncStateMachine(typeof(_003CGetResponse_003Ed__6))]
	private Task<string> GetResponse(WebRequest webRequest)
	{
		_003CGetResponse_003Ed__6 stateMachine = default(_003CGetResponse_003Ed__6);
		stateMachine.webRequest = webRequest;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<string>.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<string> _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	private void SendRequestWrite(byte[] buffer, int offset, int length, (Stream, string) param)
	{
		var (stream, text) = param;
		Encoding.UTF8.GetBytes(text, 0, text.Length, buffer, offset);
		stream.Write(buffer, offset, length);
	}

	internal static void tDG22yWreoTNV3x8I4QM()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object MGpTtRWrP8JNLvRl8bTO(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void GCNVAGWr144XGB9xEX0O(object P_0, object P_1)
	{
		Contract.ArgumentNotNullOrEmpty((string)P_0, (string)P_1);
	}

	internal static bool DBgVjTWrOidcDtYt7pqJ()
	{
		return vHxD4xWrnTboZWQTHLoa == null;
	}

	internal static SimpleWebClient nGdGViWr2j6RluTEQHYu()
	{
		return vHxD4xWrnTboZWQTHLoa;
	}

	internal static AsyncTaskMethodBuilder kjfy5AWrN2IJClt64Zt5()
	{
		return AsyncTaskMethodBuilder.Create();
	}
}
