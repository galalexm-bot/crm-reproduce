using System;
using EleWise.ELMA.ExtensionPoints;

namespace EleWise.ELMA.Model.Metadata;

public interface IMetadata : IXsiType
{
	Guid Uid { get; set; }

	Guid ModuleUid { get; }

	bool Internal { get; }

	void InitNew();

	void AfterLoad();
}
