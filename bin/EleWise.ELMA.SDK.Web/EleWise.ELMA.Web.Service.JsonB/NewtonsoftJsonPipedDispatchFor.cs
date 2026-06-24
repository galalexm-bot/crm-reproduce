using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.Text;
using System.Xml;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Common.Models.API;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Serialization;
using Newtonsoft.Json;

namespace EleWise.ELMA.Web.Service.JsonBehavior;

internal class NewtonsoftJsonPipedDispatchFormatter : IDispatchMessageFormatter
{
	internal class XmlDictionaryWebDataReader
	{
		public EleWise.ELMA.Common.Models.WebData Deserialize(XmlDictionaryReader bodyReader)
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			XmlNodeType xmlNodeType;
			while (bodyReader.Read() && (xmlNodeType = bodyReader.MoveToContent()) != XmlNodeType.EndElement)
			{
				if (xmlNodeType != XmlNodeType.Element)
				{
					throw new InvalidOperationException();
				}
				string key = XmlConvert.DecodeName(bodyReader.LocalName);
				if (bodyReader.Name == "a:item")
				{
					key = XmlConvert.DecodeName(bodyReader.GetAttribute("item"));
				}
				object value = ReadObjectInternal(bodyReader);
				dictionary.Add(key, value);
			}
			if (dictionary.Count <= 0)
			{
				return null;
			}
			return new EleWise.ELMA.Common.Models.WebData(dictionary);
		}

		private object ReadObjectInternal(XmlDictionaryReader bodyReader)
		{
			if (string.Equals(bodyReader.GetAttribute("type"), "array", StringComparison.InvariantCultureIgnoreCase))
			{
				SerializableList<object> serializableList = new SerializableList<object>();
				while (bodyReader.Read() && bodyReader.IsStartElement("item") && bodyReader.MoveToContent() != XmlNodeType.EndElement)
				{
					object item = ReadObjectInternal(bodyReader);
					serializableList.Add(item);
				}
				return serializableList;
			}
			if (bodyReader.Read())
			{
				if (bodyReader.IsStartElement())
				{
					SerializableDictionary<string, object> serializableDictionary = new SerializableDictionary<string, object>();
					XmlNodeType xmlNodeType;
					while ((xmlNodeType = bodyReader.MoveToContent()) != XmlNodeType.EndElement)
					{
						if (xmlNodeType != XmlNodeType.Element)
						{
							throw new InvalidOperationException();
						}
						string key = XmlConvert.DecodeName(bodyReader.LocalName);
						if (bodyReader.Name == "a:item")
						{
							key = XmlConvert.DecodeName(bodyReader.GetAttribute("item"));
						}
						object value = ReadObjectInternal(bodyReader);
						serializableDictionary.Add(key, value);
						if (!bodyReader.Read())
						{
							throw new InvalidOperationException();
						}
					}
					return serializableDictionary;
				}
				return bodyReader.ReadString();
			}
			throw new NotImplementedException();
		}
	}

	private readonly IDispatchMessageFormatter defaultFormatter;

	private readonly DispatchOperation dispatchOperation;

	private readonly OperationDescription operation;

	public NewtonsoftJsonPipedDispatchFormatter(IDispatchMessageFormatter defaultFormatter, DispatchOperation dispatchOperation, OperationDescription operation)
	{
		this.defaultFormatter = defaultFormatter;
		this.dispatchOperation = dispatchOperation;
		this.operation = operation;
	}

	public void DeserializeRequest(Message message, object[] parameters)
	{
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		NewtonsoftJsonDispatchFormatter.ClientTimeZoneOffsetInit();
		bool flag = NewtonsoftJsonDispatchFormatter.IsIncomingWebData20Version();
		if (message.IsEmpty || !flag)
		{
			defaultFormatter.DeserializeRequest(message, parameters);
			return;
		}
		Type type = null;
		int num = 0;
		for (int i = 0; i < operation.Messages[0].Body.Parts.Count; i++)
		{
			type = operation.Messages[0].Body.Parts[i].Type;
			if (type.IsArray)
			{
				type = type.GetElementType();
			}
			if (type == typeof(EleWise.ELMA.Common.Models.WebData))
			{
				num = i;
				break;
			}
		}
		if (type != typeof(EleWise.ELMA.Common.Models.WebData))
		{
			defaultFormatter.DeserializeRequest(message, parameters);
			return;
		}
		if (!message.Properties.TryGetValue("WebBodyFormatMessageProperty", out var value) || (((WebBodyFormatMessageProperty)value).Format != WebContentFormat.Raw && ((WebBodyFormatMessageProperty)value).Format != WebContentFormat.Json))
		{
			throw new InvalidOperationException("Incoming messages must have a body format of Raw or Json. Is a ContentTypeMapper set on the WebHttpBinding?");
		}
		if (parameters.Length != 1)
		{
			MessageBuffer messageBuffer = message.CreateBufferedCopy(int.MaxValue);
			defaultFormatter.DeserializeRequest(messageBuffer.CreateMessage(), parameters);
			message = messageBuffer.CreateMessage();
		}
		XmlDictionaryReader readerAtBodyContents = message.GetReaderAtBodyContents();
		if (readerAtBodyContents.IsStartElement("Binary"))
		{
			readerAtBodyContents.ReadStartElement("Binary");
			using MemoryStream stream = MemoryHelper.GetMemoryStream(readerAtBodyContents.ReadContentAsBase64(), writable: false);
			using StreamReader streamReader = new StreamReader(stream);
			JsonSerializer val = new JsonSerializer();
			if (type == typeof(EleWise.ELMA.Common.Models.WebData))
			{
				type = typeof(EleWise.ELMA.Common.Models.API.WebData);
			}
			parameters[num] = val.Deserialize((TextReader)streamReader, type);
			return;
		}
		if (!readerAtBodyContents.IsStartElement("root"))
		{
			throw new InvalidOperationException("Incoming messages must have a body");
		}
		EleWise.ELMA.Common.Models.WebData webData = (EleWise.ELMA.Common.Models.WebData)(parameters[num] = new XmlDictionaryWebDataReader().Deserialize(readerAtBodyContents));
	}

	public Message SerializeReply(MessageVersion messageVersion, object[] parameters, object result)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		if (!NewtonsoftJsonDispatchFormatter.IsWebData20Version())
		{
			return defaultFormatter.SerializeReply(messageVersion, parameters, result);
		}
		JsonSerializer val = new JsonSerializer();
		using MemoryStream memoryStream = MemoryHelper.GetMemoryStream();
		using StreamWriter streamWriter = new StreamWriter(memoryStream, Encoding.UTF8);
		JsonWriter val2 = (JsonWriter)new JsonTextWriter((TextWriter)streamWriter);
		try
		{
			val.Serialize(val2, result);
			streamWriter.Flush();
			memoryStream.Seek(0L, SeekOrigin.Begin);
			Message message = MemoryHelper.ActionWithMemoryBuffer<byte, (MemoryStream, MessageVersion, string), Message>((int)memoryStream.Length, (memoryStream, messageVersion, dispatchOperation.Action), CreateMessageAction);
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
