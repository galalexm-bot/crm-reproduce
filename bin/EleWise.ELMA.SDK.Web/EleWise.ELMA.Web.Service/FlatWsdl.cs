using System;
using System.Collections.Generic;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.Web.Services.Description;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace EleWise.ELMA.Web.Service;

internal sealed class FlatWsdl : IWsdlExportExtension, IEndpointBehavior
{
	public void ExportContract(WsdlExporter exporter, WsdlContractConversionContext context)
	{
	}

	public void ExportEndpoint(WsdlExporter exporter, WsdlEndpointConversionContext context)
	{
		if (exporter.GeneratedWsdlDocuments.Count > 1)
		{
			throw new ApplicationException("Single file option is not supported in multiple wsdl files");
		}
		System.Web.Services.Description.ServiceDescription serviceDescription = exporter.GeneratedWsdlDocuments[0];
		XmlSchemas xmlSchemas = new XmlSchemas();
		foreach (XmlSchema item in exporter.GeneratedXmlSchemas.Schemas())
		{
			xmlSchemas.Add(item);
		}
		foreach (XmlSchema item2 in xmlSchemas)
		{
			item2.Includes.Clear();
		}
		serviceDescription.Types.Schemas.Clear();
		serviceDescription.Types.Schemas.Add(xmlSchemas);
	}

	private void AddImportedSchemas(XmlSchema schema, XmlSchemaSet schemaSet, List<XmlSchema> importsList)
	{
		foreach (XmlSchemaImport include in schema.Includes)
		{
			foreach (XmlSchema item in schemaSet.Schemas(include.Namespace))
			{
				if (!importsList.Contains(item))
				{
					importsList.Add(item);
					AddImportedSchemas(item, schemaSet, importsList);
				}
			}
		}
	}

	private void RemoveXsdImports(XmlSchema schema)
	{
		for (int i = 0; i < schema.Includes.Count; i++)
		{
			if (schema.Includes[i] is XmlSchemaImport)
			{
				schema.Includes.RemoveAt(i--);
			}
		}
	}

	public void AddBindingParameters(ServiceEndpoint endpoint, BindingParameterCollection bindingParameters)
	{
	}

	public void ApplyClientBehavior(ServiceEndpoint endpoint, ClientRuntime clientRuntime)
	{
	}

	public void ApplyDispatchBehavior(ServiceEndpoint endpoint, EndpointDispatcher endpointDispatcher)
	{
	}

	public void Validate(ServiceEndpoint endpoint)
	{
	}
}
