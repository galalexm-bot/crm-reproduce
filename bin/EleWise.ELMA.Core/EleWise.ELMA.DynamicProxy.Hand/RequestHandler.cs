using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Bridge;
using Bridge.Html5;
using EleWise.ELMA.Api.Models;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.Api;
using EleWise.ELMA.Core.Serialization;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Types.Storage;
using Newtonsoft.Json;

namespace EleWise.ELMA.DynamicProxy.Handlers;

public sealed class RequestHandler : IMiddleware
{
	[StructLayout(3)]
	private struct _003CCall_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public RequestHandler _003C_003E4__this;

		public InvocationContext invocationContext;

		private Response _003Cresult_003E5__2;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c8: Expected O, but got Unknown
			int num = _003C_003E1__state;
			RequestHandler requestHandler = _003C_003E4__this;
			try
			{
				TaskAwaiter val;
				TaskAwaiter<Response> val2;
				if (num != 0)
				{
					if (num == 1)
					{
						val = (TaskAwaiter)_003C_003Eu__1;
						_003C_003Eu__1 = null;
						num = (_003C_003E1__state = -1);
						goto IL_00d8;
					}
					val2 = requestHandler.Request(invocationContext).GetAwaiter();
					if (!val2.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val2;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter<Response>, _003CCall_003Ed__6>(ref val2, ref this);
						return;
					}
				}
				else
				{
					val2 = (TaskAwaiter<Response>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
				}
				Response response = (_003Cresult_003E5__2 = val2.GetResult());
				val = invocationContext.Next().GetAwaiter();
				if (!val.get_IsCompleted())
				{
					num = (_003C_003E1__state = 1);
					_003C_003Eu__1 = val;
					((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter, _003CCall_003Ed__6>(ref val, ref this);
					return;
				}
				goto IL_00d8;
				IL_00d8:
				val.GetResult();
				invocationContext.ReturnValue = _003Cresult_003E5__2;
			}
			catch (System.Exception exception)
			{
				_003C_003E1__state = -2;
				((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).SetResult();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).SetStateMachine(stateMachine);
		}
	}

	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public RequestParameters rq;

		public RequestHandler _003C_003E4__this;

		internal void _003CRequest_003Eb__0(System.Threading.Tasks.Task<Response> response)
		{
			_003C_003E4__this.RequestTask(rq);
		}
	}

	private sealed class _003C_003Ec__DisplayClass7_1
	{
		public RequestParameters rq;

		public RequestHandler _003C_003E4__this;

		internal void _003CRequest_003Eb__1(System.Threading.Tasks.Task<Response> response)
		{
			_003C_003E4__this.RequestTask(rq);
		}
	}

	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public string key;

		internal bool _003CGetRequestTask_003Eb__0(string r)
		{
			return r.Contains(key);
		}
	}

	private static int REQUEST_LIFE_TIME = 200;

	private readonly IRequestService requestService;

	private readonly IApplicationData applicationData;

	private readonly JsonSerializerSettings serializationSettings;

	private TypedMap<string, System.Threading.Tasks.Task<Response>> requests;

	public RequestHandler(IRequestService requestService, IApplicationData applicationData)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		JsonSerializerSettings val = new JsonSerializerSettings();
		val.set_NullValueHandling((NullValueHandling)1);
		val.set_TypeNameHandling((TypeNameHandling)0);
		serializationSettings = val;
		base._002Ector();
		this.requestService = requestService;
		this.applicationData = applicationData;
		requests = new TypedMap<string, System.Threading.Tasks.Task<Response>>();
	}

	public System.Threading.Tasks.Task Call(InvocationContext invocationContext)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003CCall_003Ed__6 _003CCall_003Ed__ = default(_003CCall_003Ed__6);
		_003CCall_003Ed__._003C_003E4__this = this;
		_003CCall_003Ed__.invocationContext = invocationContext;
		_003CCall_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		_003CCall_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder _003C_003Et__builder = _003CCall_003Ed__._003C_003Et__builder;
		((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).Start<_003CCall_003Ed__6>(ref _003CCall_003Ed__);
		return ((AsyncTaskMethodBuilder)(ref _003CCall_003Ed__._003C_003Et__builder)).get_Task();
	}

	private System.Threading.Tasks.Task<Response> Request(InvocationContext invocationContext)
	{
		MethodInfo method = invocationContext.Method;
		ParameterInfo[] parameters = ((MethodBase)method).GetParameters();
		System.Type[] genericArguments = method.get_ReturnType().GetGenericArguments();
		System.Type returnType = ((genericArguments.Length != 0) ? genericArguments[0] : typeof(void));
		object[] arguments = invocationContext.Arguments;
		object obj = null;
		bool flag = false;
		string text = ApiProvider.GetServicePath(invocationContext.TargetType, method, applicationData.BaseUrl);
		WebMethod webMethod = ApiProvider.GetWebMethod(method);
		for (int i = 0; i < arguments.Length; i++)
		{
			object obj2 = arguments[i];
			ParameterInfo val = parameters[i];
			if (text.Contains("{" + val.get_Name() + "}"))
			{
				string text2 = ((val.get_ParameterType() != typeof(string) || !string.IsNullOrWhiteSpace(ObjectExtensions.As<string>(obj2))) ? SerializationHelper.SerializeObjectByJson(obj2) : null);
				text = text.Replace("{" + parameters[i].get_Name() + "}", Script.EncodeURIComponent((!string.IsNullOrWhiteSpace(text2)) ? text2.Trim(new char[1] { '"' }) : ""));
				continue;
			}
			if (webMethod == WebMethod.POST && !flag)
			{
				if (obj2 is string text3)
				{
					obj = text3;
				}
				else
				{
					System.Type type = obj2.GetType();
					System.Type type2 = (type.IsIEnumerableTOrArray() ? type.GetTypeElementFromEnumerable() : type);
					bool flag2 = type2.IsSimpleType();
					if (obj2 is System.Collections.IEnumerable enumerable)
					{
						if (flag2)
						{
							object[] array = new object[0];
							{
								System.Collections.IEnumerator enumerator = enumerable.GetEnumerator();
								try
								{
									while (enumerator.MoveNext())
									{
										object current = enumerator.get_Current();
										string text4 = ConvertHelper.SerializeWithType(type2, current);
										ArrayExtensions.Push<object>(array, new object[1] { text4 });
									}
								}
								finally
								{
									System.IDisposable disposable = enumerator as System.IDisposable;
									if (disposable != null)
									{
										disposable.Dispose();
									}
								}
							}
							obj = JSON.Stringify((object)array);
						}
						else
						{
							obj = SerializationHelper.SerializeObjectByJson(enumerable, serializationSettings);
						}
					}
					else
					{
						obj = (flag2 ? ConvertHelper.SerializeWithType(type2, obj2) : SerializationHelper.SerializeObjectByJson(obj2, serializationSettings));
						if ((string)obj == "{}")
						{
							obj = obj2;
						}
					}
				}
				flag = true;
				continue;
			}
			throw new System.Exception(SR.T("POST запрос может иметь только один параметр в теле. Параметр: {0}", parameters[i].get_Name()));
		}
		RequestOptions requestOptions = new RequestOptions();
		object obj3 = default(object);
		if (invocationContext.ContextVars.TryGetValue("AdditionalHeaders", ref obj3) && obj3 is IDictionary<string, string> source)
		{
			((System.Collections.Generic.ICollection<KeyValuePair<string, string>>)requestOptions.Headers).AddRange((System.Collections.Generic.IEnumerable<KeyValuePair<string, string>>)source);
		}
		switch (webMethod)
		{
		case WebMethod.POST:
		{
			_003C_003Ec__DisplayClass7_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass7_0();
			CS_0024_003C_003E8__locals0._003C_003E4__this = this;
			string bodyType = ApiProvider.GetBodyType(method);
			if (!string.IsNullOrWhiteSpace(bodyType))
			{
				requestOptions.Headers.Add("Content-Type", bodyType);
			}
			CS_0024_003C_003E8__locals0.rq = new RequestParameters(text, returnType, obj, requestOptions);
			System.Threading.Tasks.Task<Response> requestTask2 = GetRequestTask(CS_0024_003C_003E8__locals0.rq);
			if (requestTask2 != null)
			{
				return requestTask2;
			}
			requestTask2 = requestService.Post(text, returnType, obj, requestOptions);
			CS_0024_003C_003E8__locals0.rq.SaveRequestTime();
			requests.Set(CS_0024_003C_003E8__locals0.rq.Key, requestTask2);
			requestTask2.ContinueWith((Action<System.Threading.Tasks.Task<Response>>)delegate
			{
				CS_0024_003C_003E8__locals0._003C_003E4__this.RequestTask(CS_0024_003C_003E8__locals0.rq);
			});
			return requestTask2;
		}
		case WebMethod.GET:
		{
			_003C_003Ec__DisplayClass7_1 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass7_1();
			CS_0024_003C_003E8__locals1._003C_003E4__this = this;
			CS_0024_003C_003E8__locals1.rq = new RequestParameters(text, returnType, null, requestOptions);
			System.Threading.Tasks.Task<Response> requestTask = GetRequestTask(CS_0024_003C_003E8__locals1.rq);
			if (requestTask != null)
			{
				return requestTask;
			}
			requestTask = requestService.Get(text, returnType, requestOptions);
			requestTask.ContinueWith((Action<System.Threading.Tasks.Task<Response>>)delegate
			{
				CS_0024_003C_003E8__locals1._003C_003E4__this.RequestTask(CS_0024_003C_003E8__locals1.rq);
			});
			CS_0024_003C_003E8__locals1.rq.SaveRequestTime();
			requests.Set(CS_0024_003C_003E8__locals1.rq.Key, requestTask);
			return requestTask;
		}
		default:
			return System.Threading.Tasks.Task.FromResult<Response>((Response)null);
		}
	}

	private System.Threading.Tasks.Task<Response> GetRequestTask(RequestParameters rq)
	{
		_003C_003Ec__DisplayClass8_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass8_0();
		System.Threading.Tasks.Task<Response> result = null;
		CS_0024_003C_003E8__locals0.key = ((object)rq).ToString();
		System.Collections.Generic.IEnumerable<string> enumerable = null;
		if (Enumerable.Any<string>((System.Collections.Generic.IEnumerable<string>)requests.get_Keys()))
		{
			enumerable = (System.Collections.Generic.IEnumerable<string>)Enumerable.Where<string>((System.Collections.Generic.IEnumerable<string>)requests.get_Keys(), (Func<string, bool>)((string r) => r.Contains(CS_0024_003C_003E8__locals0.key)));
		}
		if (enumerable == null)
		{
			return null;
		}
		System.Collections.Generic.IEnumerator<string> enumerator = enumerable.GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				string current = enumerator.get_Current();
				int num = current.LastIndexOf("_");
				long num2 = long.Parse(current.Substring(num + 1));
				if ((System.DateTime.get_Now().get_Ticks() - num2) / 10000 < REQUEST_LIFE_TIME)
				{
					return requests.Get(current);
				}
			}
			return result;
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
	}

	private void RequestTask(RequestParameters rq)
	{
		requests.Delete(((object)rq).ToString());
	}
}
