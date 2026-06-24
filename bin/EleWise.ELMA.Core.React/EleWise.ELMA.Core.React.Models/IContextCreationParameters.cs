using System;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.ViewModel;

namespace EleWise.ELMA.Core.React.Models;

public interface IContextCreationParameters
{
	IViewModel ViewModel { get; }

	IDataStack InnerStack { get; }

	IDataStack OuterStack { get; }

	ClassMetadata Metadata { get; }

	Guid MetadataUid { get; }

	Guid MetadataTypeUid { get; }

	Guid MetadataModuleUid { get; }
}
