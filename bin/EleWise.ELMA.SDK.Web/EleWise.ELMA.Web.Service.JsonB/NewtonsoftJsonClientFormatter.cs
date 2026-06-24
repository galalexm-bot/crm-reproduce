using System;
using System.IO;
using System.Net;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.Text;
using System.Xml;
using EleWise.ELMA.Memory;
using Newtonsoft.Json;

namespace EleWise.ELMA.Web.Service.JsonBehavior;

internal class NewtonsoftJsonClientFormatter : IClientMessageFormatter
{
	private OperationDescription operation;

	private Uri operationUri;

	public NewtonsoftJsonClientFormatter(OperationDescription operation, ServiceEndpoint endpoint)
	{
		this.operation = operation;
		string text = endpoint.Address.Uri.ToString();
		if (!text.EndsWith("/"))
		{
			text += "/";
		}
		operationUri = new Uri(text + operation.Name);
	}

	public object DeserializeReply(Message message, object[] parameters)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		if (!message.Properties.TryGetValue("WebBodyFormatMessageProperty", out var value) || (value as WebBodyFormatMessageProperty).Format != WebContentFormat.Raw)
		{
			throw new InvalidOperationException("Incoming messages must have a body format of Raw. Is a ContentTypeMapper set on the WebHttpBinding?");
		}
		XmlDictionaryReader readerAtBodyContents = message.GetReaderAtBodyContents();
		JsonSerializer val = new JsonSerializer();
		readerAtBodyContents.ReadStartElement("Binary");
		using MemoryStream stream = MemoryHelper.GetMemoryStream(readerAtBodyContents.ReadContentAsBase64(), writable: false);
		using StreamReader streamReader = new StreamReader(stream);
		Type type = operation.Messages[1].Body.ReturnValue.Type;
		return val.Deserialize((TextReader)streamReader, type);
	}

	public Message SerializeRequest(MessageVersion messageVersion, object[] parameters)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		JsonSerializer val = new JsonSerializer();
		using MemoryStream memoryStream = MemoryHelper.GetMemoryStream();
		using StreamWriter streamWriter = new StreamWriter(memoryStream, Encoding.UTF8);
		JsonWriter val2 = (JsonWriter)new JsonTextWriter((TextWriter)streamWriter);
		try
		{
			val2.set_Formatting((Formatting)1);
			if (parameters.Length == 1)
			{
				val.Serialize((TextWriter)streamWriter, parameters[0]);
			}
			else
			{
				val2.WriteStartObject();
				for (int i = 0; i < operation.Messages[0].Body.Parts.Count; i++)
				{
					val2.WritePropertyName(operation.Messages[0].Body.Parts[i].Name);
					val.Serialize(val2, parameters[i]);
				}
				val2.WriteEndObject();
			}
			val2.Flush();
			streamWriter.Flush();
			memoryStream.Seek(0L, SeekOrigin.Begin);
			Message message = MemoryHelper.ActionWithMemoryBuffer<byte, (MemoryStream, MessageVersion, string), Message>((int)memoryStream.Length, (memoryStream, messageVersion, operation.Messages[1].Action), CreateMessageAction);
			message.Headers.To = operationUri;
			message.Properties.Add("WebBodyFormatMessageProperty", new WebBodyFormatMessageProperty(WebContentFormat.Raw));
			HttpRequestMessageProperty httpRequestMessageProperty = new HttpRequestMessageProperty();
			httpRequestMessageProperty.Headers[HttpRequestHeader.ContentType] = "application/json";
			message.Properties.Add(HttpRequestMessageProperty.Name, httpRequestMessageProperty);
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
