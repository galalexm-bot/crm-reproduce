using System;
using EleWise.ELMA.Core.Api;

namespace EleWise.ELMA.Api.Attributes;

[AttributeUsage(/*Could not decode attribute arguments.*/)]
public sealed class OperationAttribute : System.Attribute
{
	private WebMethod _003CMethod_003Ek__BackingField;

	private string _003CUriTemplate_003Ek__BackingField;

	private string _003CBodyContentType_003Ek__BackingField;

	public WebMethod Method
	{
		get
		{
			return _003CMethod_003Ek__BackingField;
		}
		set
		{
			_003CMethod_003Ek__BackingField = value;
		}
	}

	public string UriTemplate
	{
		get
		{
			return _003CUriTemplate_003Ek__BackingField;
		}
		set
		{
			_003CUriTemplate_003Ek__BackingField = value;
		}
	}

	public string BodyContentType
	{
		get
		{
			return _003CBodyContentType_003Ek__BackingField;
		}
		set
		{
			_003CBodyContentType_003Ek__BackingField = value;
		}
	}
}
