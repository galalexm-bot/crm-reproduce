using System;
using EleWise.ELMA.Common;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Services.Public;

[DeveloperApi(DeveloperApiType.ExtensionPoint)]
public interface IPublicServiceMethod
{
	Guid ServiceUid { get; }

	string Name { get; }

	string Description { get; }

	Version Version { get; }

	TypeSerializationDescriptor ParametersDescriptor { get; }

	TypeSerializationDescriptor ResultDescriptor { get; }

	WebData Execute(WebData parameters);
}
