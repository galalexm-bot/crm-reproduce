using System;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.ViewModel;

namespace EleWise.ELMA.Core.React.Models;

public class ContextCreationParameters : IContextCreationParameters
{
	private readonly IViewModel _003CViewModel_003Ek__BackingField;

	private readonly IDataStack _003CInnerStack_003Ek__BackingField;

	private readonly IDataStack _003COuterStack_003Ek__BackingField;

	private readonly ClassMetadata _003CMetadata_003Ek__BackingField;

	private readonly Guid _003CMetadataUid_003Ek__BackingField;

	private readonly Guid _003CMetadataTypeUid_003Ek__BackingField;

	private readonly Guid _003CMetadataModuleUid_003Ek__BackingField;

	public IViewModel ViewModel => _003CViewModel_003Ek__BackingField;

	public IDataStack InnerStack => _003CInnerStack_003Ek__BackingField;

	public IDataStack OuterStack => _003COuterStack_003Ek__BackingField;

	public ClassMetadata Metadata => _003CMetadata_003Ek__BackingField;

	public Guid MetadataUid => _003CMetadataUid_003Ek__BackingField;

	public Guid MetadataTypeUid => _003CMetadataTypeUid_003Ek__BackingField;

	public Guid MetadataModuleUid => _003CMetadataModuleUid_003Ek__BackingField;

	public ContextCreationParameters(IViewModel viewModel, IDataStack innerStack, IDataStack outerStack, ClassMetadata metadata, Guid metadataUid, Guid metadataTypeUid, Guid metadataModuleUid)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		_003CViewModel_003Ek__BackingField = viewModel;
		_003CInnerStack_003Ek__BackingField = innerStack;
		_003COuterStack_003Ek__BackingField = outerStack;
		_003CMetadata_003Ek__BackingField = metadata;
		_003CMetadataUid_003Ek__BackingField = metadataUid;
		_003CMetadataTypeUid_003Ek__BackingField = metadataTypeUid;
		_003CMetadataModuleUid_003Ek__BackingField = metadataModuleUid;
	}
}
