using System;
using System.Reflection;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.Web.Services.Description;
using System.Xml;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Web.Service;

[AttributeUsage(AttributeTargets.Method | AttributeTargets.Interface)]
public class WsdlDocumentationAttribute : LocalizedStringAttribute, IContractBehavior, IOperationBehavior, IWsdlExportExtension
{
	private ContractDescription contractDescription;

	private OperationDescription operationDescription;

	public WsdlDocumentationAttribute(string text)
		: base(text)
	{
	}

	public WsdlDocumentationAttribute(Type staticResourceType, string propertyName)
		: base(staticResourceType, propertyName)
	{
	}

	public void ExportContract(WsdlExporter exporter, WsdlContractConversionContext context)
	{
		if (contractDescription != null)
		{
			context.WsdlPortType.Documentation = string.Empty;
			XmlElement xmlElement = context.WsdlPortType.DocumentationElement.OwnerDocument.CreateElement("summary");
			xmlElement.InnerText = base.Value;
			context.WsdlPortType.DocumentationElement.AppendChild(xmlElement);
			return;
		}
		Operation operation = context.GetOperation(operationDescription);
		if (operation == null)
		{
			return;
		}
		operation.Documentation = string.Empty;
		XmlDocument ownerDocument = operation.DocumentationElement.OwnerDocument;
		XmlElement xmlElement2 = ownerDocument.CreateElement("summary");
		xmlElement2.InnerText = base.Value;
		operation.DocumentationElement.AppendChild(xmlElement2);
		object[] customAttributes = operationDescription.SyncMethod.ReturnParameter.GetCustomAttributes(typeof(WsdlParamOrReturnDocumentationAttribute), inherit: false);
		if (customAttributes.Length != 0)
		{
			XmlElement xmlElement3 = ownerDocument.CreateElement("returns");
			xmlElement3.InnerText = ((WsdlParamOrReturnDocumentationAttribute)customAttributes[0]).Value;
			operation.DocumentationElement.AppendChild(xmlElement3);
		}
		ParameterInfo[] parameters = operationDescription.SyncMethod.GetParameters();
		for (int i = 0; i < parameters.Length; i++)
		{
			object[] customAttributes2 = parameters[i].GetCustomAttributes(typeof(WsdlParamOrReturnDocumentationAttribute), inherit: false);
			if (customAttributes2.Length == 1)
			{
				XmlElement xmlElement4 = ownerDocument.CreateElement("param");
				XmlAttribute xmlAttribute = ownerDocument.CreateAttribute("name");
				xmlAttribute.Value = parameters[i].Name;
				xmlElement4.InnerText = ((WsdlParamOrReturnDocumentationAttribute)customAttributes2[0]).Value;
				xmlElement4.Attributes.Append(xmlAttribute);
				operation.DocumentationElement.AppendChild(xmlElement4);
			}
		}
	}

	public void ExportEndpoint(WsdlExporter exporter, WsdlEndpointConversionContext context)
	{
	}

	public void AddBindingParameters(ContractDescription description, ServiceEndpoint endpoint, BindingParameterCollection parameters)
	{
	}

	public void ApplyClientBehavior(ContractDescription description, ServiceEndpoint endpoint, ClientRuntime proxy)
	{
	}

	public void ApplyDispatchBehavior(ContractDescription description, ServiceEndpoint endpoint, DispatchRuntime dispatch)
	{
		contractDescription = description;
	}

	public void Validate(ContractDescription description, ServiceEndpoint endpoint)
	{
	}

	public void AddBindingParameters(OperationDescription description, BindingParameterCollection parameters)
	{
	}

	public void ApplyClientBehavior(OperationDescription description, ClientOperation proxy)
	{
	}

	public void ApplyDispatchBehavior(OperationDescription description, DispatchOperation dispatch)
	{
		operationDescription = description;
	}

	public void Validate(OperationDescription description)
	{
	}
}
