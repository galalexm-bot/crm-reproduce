using System;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.UI;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.UI.Metadata;

namespace EleWise.ELMA.Model;

public sealed class RenderExtensionPointModel
{
	private string _003CPointId_003Ek__BackingField;

	private Guid _003CTypeUid_003Ek__BackingField;

	private ClientImplementationModel _003CImplementation_003Ek__BackingField;

	private ComponentMetadata _003CComponentMetadata_003Ek__BackingField;

	public string PointId
	{
		get
		{
			return _003CPointId_003Ek__BackingField;
		}
		set
		{
			_003CPointId_003Ek__BackingField = value;
		}
	}

	public Guid TypeUid
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _003CTypeUid_003Ek__BackingField;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_003CTypeUid_003Ek__BackingField = value;
		}
	}

	public ClientImplementationModel Implementation
	{
		get
		{
			return _003CImplementation_003Ek__BackingField;
		}
		set
		{
			_003CImplementation_003Ek__BackingField = value;
		}
	}

	public ComponentMetadata ComponentMetadata
	{
		get
		{
			return _003CComponentMetadata_003Ek__BackingField;
		}
		set
		{
			_003CComponentMetadata_003Ek__BackingField = value;
		}
	}
}
