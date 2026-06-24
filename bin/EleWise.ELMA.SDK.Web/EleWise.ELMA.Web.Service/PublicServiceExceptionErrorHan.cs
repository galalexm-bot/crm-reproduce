using System;
using System.Net;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.ServiceModel.Web;
using System.Xml.Serialization;
using EleWise.ELMA.Services.Public;

namespace EleWise.ELMA.Web.Service;

public class PublicServiceExceptionErrorHandler : IErrorHandler
{
	private readonly WebHttpBehavior webHttpBehavior;

	private readonly ContractDescription contractDescription;

	private readonly Type exceptionType = typeof(PublicServiceException);

	public PublicServiceExceptionErrorHandler(WebHttpBehavior webHttpBehavior, ContractDescription contractDescription)
	{
		this.webHttpBehavior = webHttpBehavior;
		this.contractDescription = contractDescription;
	}

	public bool HandleError(Exception error)
	{
		return error is WebFaultException<PublicServiceException>;
	}

	public void ProvideFault(Exception error, MessageVersion version, ref Message fault)
	{
		if (version != MessageVersion.None || error == null || (!(error is WebFaultException<PublicServiceException>) && fault != null))
		{
			return;
		}
		try
		{
			if (!(error is WebFaultException<PublicServiceException>))
			{
				return;
			}
			WebFaultException<PublicServiceException> ex = (WebFaultException<PublicServiceException>)error;
			WebOperationContext current = WebOperationContext.Current;
			current.OutgoingResponse.StatusCode = ex.StatusCode;
			string name = (string)OperationContext.Current.IncomingMessageProperties["HttpOperationName"];
			OperationDescription operationDescription = contractDescription.Operations.Find(name);
			bool flag = IsXmlSerializerFaultFormat(operationDescription);
			if (flag)
			{
				WebMessageFormat? format = current.OutgoingResponse.Format;
				if (format.GetValueOrDefault() == WebMessageFormat.Json)
				{
					if (format.HasValue)
					{
						goto IL_00a5;
					}
				}
				else if (false)
				{
					goto IL_00a5;
				}
			}
			WebMessageFormat? webMessageFormat = ((!flag) ? current.OutgoingResponse.Format : new WebMessageFormat?(WebMessageFormat.Xml));
			WebMessageFormat webMessageFormat2 = (webMessageFormat.HasValue ? webMessageFormat.Value : GetResponseFormat(operationDescription, current));
			if (ex.Detail != null)
			{
				switch (webMessageFormat2)
				{
				case WebMessageFormat.Xml:
					if (flag)
					{
						fault = current.CreateXmlResponse((object)ex.Detail, new XmlSerializer(exceptionType));
					}
					else
					{
						fault = current.CreateXmlResponse((object)ex.Detail, (XmlObjectSerializer)new DataContractSerializer(exceptionType));
					}
					break;
				case WebMessageFormat.Json:
					fault = current.CreateJsonResponse((object)ex.Detail, new DataContractJsonSerializer(exceptionType));
					break;
				}
			}
			else
			{
				if (OperationContext.Current.OutgoingMessageProperties.TryGetValue(HttpResponseMessageProperty.Name, out var value) && value != null)
				{
					((HttpResponseMessageProperty)value).SuppressEntityBody = true;
				}
				if (webMessageFormat2 == WebMessageFormat.Json)
				{
					fault.Properties.Add("WebBodyFormatMessageProperty", new WebBodyFormatMessageProperty(WebContentFormat.Json));
				}
			}
			return;
			IL_00a5:
			throw new InvalidOperationException();
		}
		catch (Exception)
		{
			WebOperationContext.Current.OutgoingResponse.StatusCode = HttpStatusCode.BadRequest;
			throw;
		}
	}

	internal bool IsXmlSerializerFaultFormat(OperationDescription operationDescription)
	{
		return operationDescription.Behaviors.Find<XmlSerializerOperationBehavior>()?.XmlSerializerFormatAttribute.SupportFaults ?? false;
	}

	internal WebMessageFormat GetResponseFormat(OperationDescription od, WebOperationContext current)
	{
		WebGetAttribute webGetAttribute = od.Behaviors.Find<WebGetAttribute>();
		WebInvokeAttribute webInvokeAttribute = od.Behaviors.Find<WebInvokeAttribute>();
		WebMessageFormat webMessageFormat = GetFormatFromAcceptHeader(current) ?? webHttpBehavior.DefaultOutgoingResponseFormat;
		WebMessageFormat? webMessageFormat2 = null;
		webMessageFormat2 = ((webGetAttribute != null) ? new WebMessageFormat?(webGetAttribute.IsResponseFormatSetExplicitly ? webGetAttribute.ResponseFormat : webMessageFormat) : ((webInvokeAttribute == null) ? new WebMessageFormat?(webMessageFormat) : new WebMessageFormat?(webInvokeAttribute.IsResponseFormatSetExplicitly ? webInvokeAttribute.ResponseFormat : webMessageFormat)));
		return webMessageFormat2.Value;
	}

	private WebMessageFormat? GetFormatFromAcceptHeader(WebOperationContext current)
	{
		string accept = current.IncomingRequest.Accept;
		if (string.IsNullOrWhiteSpace(accept))
		{
			return null;
		}
		if (accept.StartsWith("application/json"))
		{
			return WebMessageFormat.Json;
		}
		if (accept.StartsWith("application/xml"))
		{
			return WebMessageFormat.Xml;
		}
		if (accept.Contains("application/json"))
		{
			return WebMessageFormat.Json;
		}
		if (accept.Contains("application/xml"))
		{
			return WebMessageFormat.Xml;
		}
		return null;
	}
}
