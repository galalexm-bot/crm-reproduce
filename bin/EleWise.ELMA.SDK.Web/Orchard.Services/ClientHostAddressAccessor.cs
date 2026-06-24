using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Orchard.Services;

public class ClientHostAddressAccessor : IClientHostAddressAccessor, IDependency
{
	private readonly IWorkContextAccessor _wca;

	public bool EnableClientHostAddressHeader { get; set; }

	public string ClientHostAddressHeaderName { get; set; }

	public ClientHostAddressAccessor(IWorkContextAccessor wca)
	{
		_wca = wca;
	}

	public string GetClientAddress()
	{
		WorkContext context = _wca.GetContext();
		if (context == null || context.HttpContext == null)
		{
			return string.Empty;
		}
		HttpRequestBase request = context.HttpContext.Request;
		if (EnableClientHostAddressHeader && !string.IsNullOrWhiteSpace(ClientHostAddressHeaderName))
		{
			string name = ClientHostAddressHeaderName.Trim();
			string[] source = ParseAddresses(request.Headers[name]).ToArray();
			if (source.Any())
			{
				return source.First();
			}
		}
		return request.UserHostAddress;
	}

	private static IEnumerable<string> ParseAddresses(string value)
	{
		if (string.IsNullOrWhiteSpace(value))
		{
			return Enumerable.Empty<string>();
		}
		return from x in value.Split(new string[1] { "," }, StringSplitOptions.RemoveEmptyEntries)
			select x.Trim();
	}
}
