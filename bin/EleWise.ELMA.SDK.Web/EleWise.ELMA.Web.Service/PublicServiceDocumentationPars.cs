using System;
using System.Collections.Concurrent;
using System.Linq;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Services.Public;

namespace EleWise.ELMA.Web.Service;

internal class PublicServiceDocumentationParser
{
	private static readonly ConcurrentDictionary<IPublicService, ClassDocumentationElement> ParsedCache = new ConcurrentDictionary<IPublicService, ClassDocumentationElement>();

	private readonly IPublicService publicService;

	private ClassDocumentationElement parsedElement;

	public PublicServiceDocumentationParser([NotNull] IPublicService publicService)
	{
		if (publicService == null)
		{
			throw new ArgumentNullException("publicService");
		}
		this.publicService = publicService;
	}

	public ClassDocumentationElement Parse()
	{
		if (parsedElement != null)
		{
			return parsedElement;
		}
		parsedElement = ParsedCache.GetOrAdd(publicService, (IPublicService service) => new ClassDocumentationElement(GetClassSummary(), service.GetType(), service.Name)
		{
			Methods = ParseMethods()
		});
		return parsedElement;
	}

	private MethodDocumentationElement[] ParseMethods()
	{
		return ComponentManager.Current.GetExtensionPoints<IPublicServiceMethodsProvider>().SelectMany((IPublicServiceMethodsProvider provider) => from method in provider.GetMethods()
			where method.ServiceUid == publicService.Uid
			select method).Select(ParseMethod)
			.ToArray();
	}

	private MethodDocumentationElement ParseMethod(IPublicServiceMethod method)
	{
		return new MethodDocumentationElement(method.Description, method.Name, method.Version.ToString(3))
		{
			Parameters = ParseParameters(method),
			ReturnValue = ParseReturnValue(method),
			RequiresAuthorization = true
		};
	}

	private ReturnValueDocumentationElement ParseReturnValue(IPublicServiceMethod method)
	{
		return new ReturnValueDocumentationElement(method.ResultDescriptor.Description, typeof(WebData))
		{
			TypeDescriptor = method.ResultDescriptor
		};
	}

	private ParameterDocumentationElement[] ParseParameters(IPublicServiceMethod method)
	{
		return new ParameterDocumentationElement[1]
		{
			new ParameterDocumentationElement(method.ParametersDescriptor.Description, typeof(WebData), "data")
			{
				TypeDescriptor = method.ParametersDescriptor
			}
		};
	}

	private string GetClassSummary()
	{
		return publicService.Description;
	}
}
