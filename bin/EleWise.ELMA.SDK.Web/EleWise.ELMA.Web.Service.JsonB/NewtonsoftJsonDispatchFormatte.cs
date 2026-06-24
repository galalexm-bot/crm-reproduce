using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Services;
using Newtonsoft.Json;

namespace EleWise.ELMA.Web.Service.JsonBehavior;

internal class NewtonsoftJsonDispatchFormatter : IDispatchMessageFormatter
{
	private readonly OperationDescription operation;

	private readonly IDispatchMessageFormatter defaultFormatter;

	private readonly Dictionary<string, int> parameterNames;

	public NewtonsoftJsonDispatchFormatter(OperationDescription operation, bool isRequest, IDispatchMessageFormatter defaultFormatter)
	{
		this.operation = operation;
		this.defaultFormatter = defaultFormatter;
		if (!isRequest)
		{
			return;
		}
		int count = operation.Messages[0].Body.Parts.Count;
		if (count > 1)
		{
			parameterNames = new Dictionary<string, int>();
			for (int i = 0; i < count; i++)
			{
				parameterNames.Add(operation.Messages[0].Body.Parts[i].Name, i);
			}
		}
	}

	public void DeserializeRequest(Message message, object[] parameters)
	{
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Invalid comparison between Unknown and I4
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Invalid comparison between Unknown and I4
		if (!IsWebData20Version())
		{
			defaultFormatter.DeserializeRequest(message, parameters);
		}
		else
		{
			if (message.IsEmpty)
			{
				return;
			}
			if (!message.Properties.TryGetValue("WebBodyFormatMessageProperty", out var value) || (value as WebBodyFormatMessageProperty).Format != WebContentFormat.Raw)
			{
				throw new InvalidOperationException("Incoming messages must have a body format of Raw. Is a ContentTypeMapper set on the WebHttpBinding?");
			}
			XmlDictionaryReader readerAtBodyContents = message.GetReaderAtBodyContents();
			readerAtBodyContents.ReadStartElement("Binary");
			MemoryStream memoryStream = MemoryHelper.GetMemoryStream(readerAtBodyContents.ReadContentAsBase64(), writable: false);
			StreamReader streamReader = new StreamReader(memoryStream);
			JsonSerializer val = new JsonSerializer();
			if (parameters.Length == 1)
			{
				parameters[0] = val.Deserialize((TextReader)streamReader, operation.Messages[0].Body.Parts[0].Type);
			}
			else
			{
				JsonReader val2 = (JsonReader)new JsonTextReader((TextReader)streamReader);
				val2.Read();
				if ((int)val2.get_TokenType() != 1)
				{
					throw new InvalidOperationException("Input needs to be wrapped in an object");
				}
				val2.Read();
				while ((int)val2.get_TokenType() == 4)
				{
					string key = val2.get_Value() as string;
					val2.Read();
					if (parameterNames.ContainsKey(key))
					{
						int num = parameterNames[key];
						parameters[num] = val.Deserialize(val2, operation.Messages[0].Body.Parts[num].Type);
					}
					else
					{
						val2.Skip();
					}
					val2.Read();
				}
				val2.Close();
			}
			streamReader.Close();
			memoryStream.Close();
		}
	}

	internal static bool IsWebData20Version()
	{
		WebOperationContext current = WebOperationContext.Current;
		if (current != null && current.IncomingRequest.Headers["WebData-Version"] == "2.0")
		{
			WebMessageFormat? format = current.OutgoingResponse.Format;
			if (format.HasValue)
			{
				return format.Value == WebMessageFormat.Json;
			}
			return false;
		}
		return false;
	}

	internal static bool IsIncomingWebData20Version()
	{
		WebOperationContext current = WebOperationContext.Current;
		if (current != null)
		{
			return current.IncomingRequest.Headers["WebData-Version"] == "2.0";
		}
		return false;
	}

	internal static void ClientTimeZoneOffsetInit()
	{
		string text = HttpContextAccessor.CurrentContext.Request.Headers["ClientTimeZoneOffsetHeader"];
		if (text != null && int.TryParse(text, out var intValue))
		{
			ContextVars.GetOrAdd("ClientTimeZoneOffsetKey", () => intValue);
		}
	}

	public Message SerializeReply(MessageVersion messageVersion, object[] parameters, object result)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		if (!IsWebData20Version())
		{
			return defaultFormatter.SerializeReply(messageVersion, parameters, result);
		}
		JsonSerializer val = new JsonSerializer();
		using MemoryStream memoryStream = MemoryHelper.GetMemoryStream();
		using StreamWriter streamWriter = new StreamWriter(memoryStream, Encoding.UTF8);
		JsonWriter val2 = (JsonWriter)new JsonTextWriter((TextWriter)streamWriter);
		try
		{
			val2.set_Formatting((Formatting)1);
			val.Serialize(val2, result);
			streamWriter.Flush();
			memoryStream.Seek(0L, SeekOrigin.Begin);
			Message message = MemoryHelper.ActionWithMemoryBuffer<byte, (MemoryStream, MessageVersion, string), Message>((int)memoryStream.Length, (memoryStream, messageVersion, operation.Messages[1].Action), CreateMessageAction);
			message.Properties.Add("WebBodyFormatMessageProperty", new WebBodyFormatMessageProperty(WebContentFormat.Raw));
			HttpResponseMessageProperty httpResponseMessageProperty = new HttpResponseMessageProperty();
			httpResponseMessageProperty.Headers[HttpResponseHeader.ContentType] = "application/json";
			message.Properties.Add(HttpResponseMessageProperty.Name, httpResponseMessageProperty);
			return message;
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
	}

	private Message CreateMessageAction(byte[] buffer, int offset, int length, (MemoryStream, MessageVersion, string) param)
	{
		param.Item1.Read(buffer, offset, length);
		return Message.CreateMessage(param.Item2, param.Item3, new RawBodyWriter(buffer, offset, length));
	}
}
