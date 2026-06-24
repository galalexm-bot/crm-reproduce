using System;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Types.Settings;

namespace EleWise.ELMA.Model.Metadata;

public interface IPropertyMetadata : INamedMetadata, IOrderedMetadata, IMetadata, IXsiType
{
	new string Name { get; set; }

	Guid PropertyUid { get; set; }

	Guid TypeUid { get; set; }

	Guid SubTypeUid { get; set; }

	TypeSettings Settings { get; set; }

	bool Required { get; set; }

	Type DeclaringType { get; set; }

	string OnChangeScriptName { get; set; }
}
