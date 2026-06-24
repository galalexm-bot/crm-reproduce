using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Bridge;
using Bridge.Html5;
using EleWise.ELMA.Api.Models;
using EleWise.ELMA.Api.Services;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Logging;
using EleWise.ELMA.Core.Serialization;
using EleWise.ELMA.Ioc;
using EleWise.ELMA.Model;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Core.Api;

[Service]
internal sealed class RequestService : IRequestService
{
	private sealed class _003C_003Ec__DisplayClass20_0
	{
		public string url;

		public RequestService _003C_003E4__this;

		public TaskCompletionSource<Response> tcs;

		public WebMethod method;

		public System.Type returnType;

		public RequestOptions options;

		public object data;
	}

	private sealed class _003C_003Ec__DisplayClass20_1
	{
		[StructLayout(3)]
		private struct _003C_003CPrepareRequest_003Eb__0_003Ed : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public _003C_003Ec__DisplayClass20_1 _003C_003E4__this;

			private object _003C_003Eu__1;

			private int _003Cattempt_003E5__2;

			private void MoveNext()
			{
				//IL_0026: Unknown result type (might be due to invalid IL or missing references)
				//IL_002c: Invalid comparison between Unknown and I4
				//IL_00de: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e5: Expected O, but got Unknown
				//IL_03be: Unknown result type (might be due to invalid IL or missing references)
				//IL_03c5: Expected O, but got Unknown
				int num = _003C_003E1__state;
				_003C_003Ec__DisplayClass20_1 _003C_003Ec__DisplayClass20_ = _003C_003E4__this;
				try
				{
					PublicServiceException ex;
					TaskAwaiter<JwtAuthResponse> val2;
					TaskAwaiter val;
					JwtAuthResponse result;
					switch (num)
					{
					default:
						if ((int)_003C_003Ec__DisplayClass20_.xmlHttp.ReadyState == 4)
						{
							ushort status = _003C_003Ec__DisplayClass20_.xmlHttp.Status;
							if (status != 200 && status != 304)
							{
								ex = null;
								string responseText = _003C_003Ec__DisplayClass20_.xmlHttp.ResponseText;
								if (!string.IsNullOrWhiteSpace(responseText))
								{
									try
									{
										ex = SerializationHelper.DeserializeObjectFromJson<PublicServiceException>(responseText);
									}
									catch (System.Exception message)
									{
										_003C_003Ec__DisplayClass20_.CS_0024_003C_003E8__locals1._003C_003E4__this.logger.Error(message);
										_003C_003Ec__DisplayClass20_.CS_0024_003C_003E8__locals1.tcs.SetException(new System.Exception(responseText));
									}
								}
								if (ex == null || ex.StatusCode != 401)
								{
									break;
								}
								if (!_003C_003Ec__DisplayClass20_.CS_0024_003C_003E8__locals1._003C_003E4__this.checkingToken)
								{
									_003C_003Ec__DisplayClass20_.CS_0024_003C_003E8__locals1._003C_003E4__this.checkingToken = true;
									val2 = _003C_003Ec__DisplayClass20_.CS_0024_003C_003E8__locals1._003C_003E4__this.authorizationService.RefreshToken(_003C_003Ec__DisplayClass20_.CS_0024_003C_003E8__locals1._003C_003E4__this.auth.RefreshToken).GetAwaiter();
									if (!val2.get_IsCompleted())
									{
										num = (_003C_003E1__state = 1);
										_003C_003Eu__1 = val2;
										((AsyncVoidMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter<JwtAuthResponse>, _003C_003CPrepareRequest_003Eb__0_003Ed>(ref val2, ref this);
										return;
									}
									goto IL_0270;
								}
								_003Cattempt_003E5__2 = 0;
								goto IL_03dc;
							}
							string text = Script.Write<string>("xmlHttp.responseURL", new object[0]);
							if (!string.IsNullOrEmpty(text))
							{
								string text2 = Script.DecodeURI(text);
								string text3 = Script.DecodeURI(_003C_003Ec__DisplayClass20_.CS_0024_003C_003E8__locals1.url);
								if (!text2.Contains(text3))
								{
									val = _003C_003Ec__DisplayClass20_.CS_0024_003C_003E8__locals1._003C_003E4__this.serverStatusService.CheckServerStatus().GetAwaiter();
									if (!val.get_IsCompleted())
									{
										num = (_003C_003E1__state = 0);
										_003C_003Eu__1 = val;
										((AsyncVoidMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter, _003C_003CPrepareRequest_003Eb__0_003Ed>(ref val, ref this);
										return;
									}
									goto IL_00f5;
								}
							}
							string responseText2 = _003C_003Ec__DisplayClass20_.xmlHttp.ResponseText;
							if (responseText2 == null)
							{
								_003C_003Ec__DisplayClass20_.CS_0024_003C_003E8__locals1.tcs.SetResult(new Response());
							}
							else
							{
								_003C_003Ec__DisplayClass20_.CS_0024_003C_003E8__locals1.tcs.SetResult(new Response
								{
									ResponseText = responseText2
								});
							}
							_003C_003Ec__DisplayClass20_.CS_0024_003C_003E8__locals1._003C_003E4__this.updateSessionService.SetNeedUpdate(flag: false);
						}
						goto end_IL_000e;
					case 0:
						val = (TaskAwaiter)_003C_003Eu__1;
						_003C_003Eu__1 = null;
						num = (_003C_003E1__state = -1);
						goto IL_00f5;
					case 1:
						val2 = (TaskAwaiter<JwtAuthResponse>)_003C_003Eu__1;
						_003C_003Eu__1 = null;
						num = (_003C_003E1__state = -1);
						goto IL_0270;
					case 2:
						{
							val = (TaskAwaiter)_003C_003Eu__1;
							_003C_003Eu__1 = null;
							num = (_003C_003E1__state = -1);
							goto IL_03d5;
						}
						IL_00f5:
						val.GetResult();
						goto end_IL_000e;
						IL_03d5:
						val.GetResult();
						goto IL_03dc;
						IL_03dc:
						if (_003C_003Ec__DisplayClass20_.oldAuth.AuthToken == _003C_003Ec__DisplayClass20_.CS_0024_003C_003E8__locals1._003C_003E4__this.auth.AuthToken)
						{
							if (_003Cattempt_003E5__2 > 10)
							{
								_003C_003Ec__DisplayClass20_.CS_0024_003C_003E8__locals1.tcs.SetException(new System.Exception(SR.T("Превышено число ожиданий получения токена авторизации")));
							}
							_003Cattempt_003E5__2++;
							val = System.Threading.Tasks.Task.Delay(50).GetAwaiter();
							if (!val.get_IsCompleted())
							{
								num = (_003C_003E1__state = 2);
								_003C_003Eu__1 = val;
								((AsyncVoidMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter, _003C_003CPrepareRequest_003Eb__0_003Ed>(ref val, ref this);
								return;
							}
							goto IL_03d5;
						}
						_003C_003Ec__DisplayClass20_.CS_0024_003C_003E8__locals1._003C_003E4__this.PrepareRequest(_003C_003Ec__DisplayClass20_.CS_0024_003C_003E8__locals1.tcs, _003C_003Ec__DisplayClass20_.CS_0024_003C_003E8__locals1.method, _003C_003Ec__DisplayClass20_.CS_0024_003C_003E8__locals1.url, _003C_003Ec__DisplayClass20_.CS_0024_003C_003E8__locals1.returnType, _003C_003Ec__DisplayClass20_.CS_0024_003C_003E8__locals1.options, _003C_003Ec__DisplayClass20_.CS_0024_003C_003E8__locals1.data);
						goto end_IL_000e;
						IL_0270:
						result = val2.GetResult();
						if (result == null)
						{
							string text4 = SR.T("Пустой результат авторизации");
							_003C_003Ec__DisplayClass20_.CS_0024_003C_003E8__locals1._003C_003E4__this.logger.Error(text4);
							_003C_003Ec__DisplayClass20_.CS_0024_003C_003E8__locals1.tcs.SetException(new System.Exception(text4));
						}
						else
						{
							_003C_003Ec__DisplayClass20_.CS_0024_003C_003E8__locals1._003C_003E4__this.auth = result;
							_003C_003Ec__DisplayClass20_.CS_0024_003C_003E8__locals1._003C_003E4__this.checkingToken = false;
							_003C_003Ec__DisplayClass20_.CS_0024_003C_003E8__locals1._003C_003E4__this.PrepareRequest(_003C_003Ec__DisplayClass20_.CS_0024_003C_003E8__locals1.tcs, _003C_003Ec__DisplayClass20_.CS_0024_003C_003E8__locals1.method, _003C_003Ec__DisplayClass20_.CS_0024_003C_003E8__locals1.url, _003C_003Ec__DisplayClass20_.CS_0024_003C_003E8__locals1.returnType, _003C_003Ec__DisplayClass20_.CS_0024_003C_003E8__locals1.options, _003C_003Ec__DisplayClass20_.CS_0024_003C_003E8__locals1.data);
						}
						goto end_IL_000e;
					}
					if (ex != null)
					{
						_003C_003Ec__DisplayClass20_.CS_0024_003C_003E8__locals1.tcs.SetException(new System.Exception(ex.Message));
					}
					else
					{
						_003C_003Ec__DisplayClass20_.CS_0024_003C_003E8__locals1.tcs.SetException(new System.Exception(_003C_003Ec__DisplayClass20_.xmlHttp.StatusText));
					}
					end_IL_000e:;
				}
				catch (System.Exception exception)
				{
					_003C_003E1__state = -2;
					((AsyncVoidMethodBuilder)(ref _003C_003Et__builder)).SetException(exception);
					return;
				}
				_003C_003E1__state = -2;
				((AsyncVoidMethodBuilder)(ref _003C_003Et__builder)).SetResult();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				((AsyncVoidMethodBuilder)(ref _003C_003Et__builder)).SetStateMachine(stateMachine);
			}
		}

		public XMLHttpRequest xmlHttp;

		public JwtAuthResponse oldAuth;

		public _003C_003Ec__DisplayClass20_0 CS_0024_003C_003E8__locals1;

		internal void _003CPrepareRequest_003Eb__0()
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			_003C_003CPrepareRequest_003Eb__0_003Ed _003C_003CPrepareRequest_003Eb__0_003Ed = default(_003C_003CPrepareRequest_003Eb__0_003Ed);
			_003C_003CPrepareRequest_003Eb__0_003Ed._003C_003E4__this = this;
			_003C_003CPrepareRequest_003Eb__0_003Ed._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
			_003C_003CPrepareRequest_003Eb__0_003Ed._003C_003E1__state = -1;
			AsyncVoidMethodBuilder _003C_003Et__builder = _003C_003CPrepareRequest_003Eb__0_003Ed._003C_003Et__builder;
			((AsyncVoidMethodBuilder)(ref _003C_003Et__builder)).Start<_003C_003CPrepareRequest_003Eb__0_003Ed>(ref _003C_003CPrepareRequest_003Eb__0_003Ed);
		}
	}

	private const string designerToken = "F2ED2D0B2B848DE05BF7A9B1FF9F510316A4B4EAC1EF3F535E19BB490B0B0293CA11FEA6A2F17E24E958AF7380E0D4263653DE78A845C34379D999B2E3203424";

	private const string Bearer = "Bearer ";

	private const string AuthorizationHeader = "Authorization";

	private JwtAuthResponse auth;

	private readonly ILazy<IAuthorizationService> lazyAuthorizationService;

	private readonly ILazy<IServerStatusService> lazyServerStatusService;

	private readonly ILazy<IUpdateSessionService> lazyUpdateSessionService;

	private readonly IApplicationData applicationData;

	private readonly ILogger logger;

	private bool checkingToken;

	private const int attemptsCount = 10;

	private IAuthorizationService authorizationService => lazyAuthorizationService.Value();

	private IServerStatusService serverStatusService => lazyServerStatusService.Value();

	private IUpdateSessionService updateSessionService => lazyUpdateSessionService.Value();

	public RequestService(ILazy<IAuthorizationService> lazyAuthorizationService, ILazy<IServerStatusService> lazyServerStatusService, ILazy<IUpdateSessionService> lazyUpdateSessionService, IApplicationData applicationData, ILogger logger)
	{
		this.lazyAuthorizationService = lazyAuthorizationService;
		this.lazyServerStatusService = lazyServerStatusService;
		this.lazyUpdateSessionService = lazyUpdateSessionService;
		this.applicationData = applicationData;
		this.logger = logger;
		auth = new JwtAuthResponse
		{
			AuthToken = applicationData.JwtAuthToken,
			RefreshToken = applicationData.RefreshToken
		};
	}

	public System.Threading.Tasks.Task<Response> Get(string url, System.Type returnType, RequestOptions options = null)
	{
		TaskCompletionSource<Response> val = new TaskCompletionSource<Response>();
		PrepareRequest(val, WebMethod.GET, url, returnType, options);
		return val.get_Task();
	}

	public System.Threading.Tasks.Task<Response> Post(string url, System.Type returnType, object data, RequestOptions options = null)
	{
		TaskCompletionSource<Response> val = new TaskCompletionSource<Response>();
		PrepareRequest(val, WebMethod.POST, url, returnType, options, data);
		return val.get_Task();
	}

	private void PrepareRequest(TaskCompletionSource<Response> tcs, WebMethod method, string url, System.Type returnType, RequestOptions options = null, object data = null)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Expected O, but got Unknown
		_003C_003Ec__DisplayClass20_0 _003C_003Ec__DisplayClass20_ = new _003C_003Ec__DisplayClass20_0();
		_003C_003Ec__DisplayClass20_.url = url;
		_003C_003Ec__DisplayClass20_._003C_003E4__this = this;
		_003C_003Ec__DisplayClass20_.tcs = tcs;
		_003C_003Ec__DisplayClass20_.method = method;
		_003C_003Ec__DisplayClass20_.returnType = returnType;
		_003C_003Ec__DisplayClass20_.options = options;
		_003C_003Ec__DisplayClass20_.data = data;
		if (auth == null)
		{
			logger.Error(SR.T("Модель авторизации не может быть пустой"));
			return;
		}
		try
		{
			_003C_003Ec__DisplayClass20_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass20_1();
			CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass20_;
			CS_0024_003C_003E8__locals0.xmlHttp = new XMLHttpRequest();
			CS_0024_003C_003E8__locals0.xmlHttp.Open((CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.method == WebMethod.POST) ? "POST" : "GET", CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.url, true);
			if (CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.options != null)
			{
				System.Collections.Generic.IEnumerator<KeyValuePair<string, string>> enumerator = ((System.Collections.Generic.IEnumerable<KeyValuePair<string, string>>)CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.options.Headers).GetEnumerator();
				try
				{
					while (((System.Collections.IEnumerator)enumerator).MoveNext())
					{
						KeyValuePair<string, string> current = enumerator.get_Current();
						CS_0024_003C_003E8__locals0.xmlHttp.SetRequestHeader(current.get_Key(), current.get_Value());
					}
				}
				finally
				{
					((System.IDisposable)enumerator)?.Dispose();
				}
			}
			CultureInfo currentCulture = SR.CurrentCulture;
			CS_0024_003C_003E8__locals0.xmlHttp.SetRequestHeader("Accept-Language", currentCulture.get_Name());
			if (!CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.options.Headers.ContainsKey("Content-Type"))
			{
				CS_0024_003C_003E8__locals0.xmlHttp.SetRequestHeader("Content-Type", "application/json");
			}
			CS_0024_003C_003E8__locals0.xmlHttp.SetRequestHeader("WebData-Version", "2.0");
			CS_0024_003C_003E8__locals0.xmlHttp.SetRequestHeader("ApplicationToken", "F2ED2D0B2B848DE05BF7A9B1FF9F510316A4B4EAC1EF3F535E19BB490B0B0293CA11FEA6A2F17E24E958AF7380E0D4263653DE78A845C34379D999B2E3203424");
			CS_0024_003C_003E8__locals0.xmlHttp.SetRequestHeader("X-Requested-With", "XMLHttpRequest");
			if (applicationData.InterfaceBuilderMode != InterfaceBuilderMode.DevServer && CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.method == WebMethod.POST && Script.Write<bool>("typeof AntiForgeryToken !== 'undefined'", new object[0]))
			{
				CS_0024_003C_003E8__locals0.xmlHttp.SetRequestHeader("__RequestVerificationToken", Script.Write<string>("AntiForgeryToken.Generate()", new object[0]));
			}
			CS_0024_003C_003E8__locals0.xmlHttp.SetRequestHeader("Authorization", string.Format("{0}{1}", (object)"Bearer ", (object)auth.AuthToken));
			if (TZ.ClientTimeZoneOffset.get_HasValue())
			{
				CS_0024_003C_003E8__locals0.xmlHttp.SetRequestHeader("ClientTimeZoneOffsetHeader", ((object)TZ.ClientTimeZoneOffset).ToString());
			}
			CS_0024_003C_003E8__locals0.oldAuth = (JwtAuthResponse)JSON.Parse(JSON.Stringify((object)auth));
			CS_0024_003C_003E8__locals0.xmlHttp.OnReadyStateChange = (Action)delegate
			{
				//IL_000a: Unknown result type (might be due to invalid IL or missing references)
				//IL_000f: Unknown result type (might be due to invalid IL or missing references)
				//IL_001d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0022: Unknown result type (might be due to invalid IL or missing references)
				_003C_003Ec__DisplayClass20_1._003C_003CPrepareRequest_003Eb__0_003Ed _003C_003CPrepareRequest_003Eb__0_003Ed = default(_003C_003Ec__DisplayClass20_1._003C_003CPrepareRequest_003Eb__0_003Ed);
				_003C_003CPrepareRequest_003Eb__0_003Ed._003C_003E4__this = CS_0024_003C_003E8__locals0;
				_003C_003CPrepareRequest_003Eb__0_003Ed._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
				_003C_003CPrepareRequest_003Eb__0_003Ed._003C_003E1__state = -1;
				AsyncVoidMethodBuilder _003C_003Et__builder = _003C_003CPrepareRequest_003Eb__0_003Ed._003C_003Et__builder;
				((AsyncVoidMethodBuilder)(ref _003C_003Et__builder)).Start<_003C_003Ec__DisplayClass20_1._003C_003CPrepareRequest_003Eb__0_003Ed>(ref _003C_003CPrepareRequest_003Eb__0_003Ed);
			};
			if (CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.data != null)
			{
				SendXhrWithObject(CS_0024_003C_003E8__locals0.xmlHttp, CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.data);
			}
			else
			{
				CS_0024_003C_003E8__locals0.xmlHttp.Send();
			}
		}
		catch (System.Exception ex)
		{
			logger.Error(ex.get_Message());
			throw;
		}
	}

	private static void SendXhrWithObject(XMLHttpRequest xmlHttp, object data)
	{
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		if (data != null)
		{
			if (data is string text)
			{
				string text2 = text;
				if (!string.IsNullOrWhiteSpace(text2))
				{
					xmlHttp.Send(text2);
				}
				else
				{
					xmlHttp.Send();
				}
				return;
			}
			Blob val;
			if ((val = (Blob)((data is Blob) ? data : null)) != null)
			{
				Blob val2 = val;
				xmlHttp.Send(val2);
				return;
			}
			FormData val3;
			if ((val3 = (FormData)((data is FormData) ? data : null)) != null)
			{
				FormData val4 = val3;
				xmlHttp.Send(val4);
				return;
			}
			ArrayBuffer val5;
			if ((val5 = (ArrayBuffer)((data is ArrayBuffer) ? data : null)) != null)
			{
				ArrayBuffer val6 = val5;
				xmlHttp.Send(val6);
				return;
			}
			ArrayBufferView val7;
			if ((val7 = (ArrayBufferView)((data is ArrayBufferView) ? data : null)) != null)
			{
				ArrayBufferView val8 = val7;
				xmlHttp.Send(val8);
				return;
			}
			DocumentInstance val9;
			if ((val9 = (DocumentInstance)((data is DocumentInstance) ? data : null)) != null)
			{
				DocumentInstance val10 = val9;
				xmlHttp.Send(val10);
				return;
			}
		}
		throw new InvalidOperationException(SR.T("Метод XMLHttpRequest.Send не поддерживает тип {0}", data.GetType().get_FullName()));
	}
}
