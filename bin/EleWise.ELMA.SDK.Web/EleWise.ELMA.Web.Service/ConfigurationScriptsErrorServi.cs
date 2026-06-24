using System;
using System.Web;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Web.Service;

[Service(Type = ComponentType.Server)]
internal sealed class ConfigurationScriptsErrorService : IConfigurationScriptsErrorService
{
	private readonly IMetadataRuntimeService metadataRuntimeService;

	private const string PassPhrasePath = "ConfigScriptsErrorConfirmationCode.txt";

	private PassPhrase confirmationCode;

	private PassPhrase ConfirmationCode => confirmationCode ?? (confirmationCode = new PassPhrase("ConfigScriptsErrorConfirmationCode.txt"));

	public ConfigurationScriptsErrorService(IMetadataRuntimeService metadataRuntimeService)
	{
		this.metadataRuntimeService = metadataRuntimeService;
	}

	public bool Validate(string code)
	{
		bool num = ConfirmationCode.IsValid(code);
		if (num)
		{
			HttpContext.Current.Response.Cookies.Add(new HttpCookie("ConfigurationScriptsErrorService", code)
			{
				Expires = DateTime.Now.AddDays(10.0)
			});
		}
		return num;
	}

	public string GetFileAbsolutePath()
	{
		return ConfirmationCode.AbsolutePath;
	}

	public string GetErrors()
	{
		return metadataRuntimeService.ConfigurationScriptsErrors;
	}

	public bool IsValidCurrent()
	{
		string value = HttpContext.Current.Request.Cookies.Get("ConfigurationScriptsErrorService")?.Value;
		return ConfirmationCode.IsValid(value);
	}
}
