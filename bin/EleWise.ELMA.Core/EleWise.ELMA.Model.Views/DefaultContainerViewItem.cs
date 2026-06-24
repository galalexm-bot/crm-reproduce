using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Model.Managers;
using EleWise.ELMA.Core.Model.Views.Toolbox;
using EleWise.ELMA.Core.Services;
using EleWise.ELMA.DTO;

namespace EleWise.ELMA.Model.Views;

internal sealed class DefaultContainerViewItem : ViewItem
{
	[Component(Order = 100)]
	private class ToolboxItem : AdditionalViewItemToolboxItem<DefaultContainerViewItem>
	{
		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

			public static Func<PropertyMetadata, bool> _003C_003E9__11_0;

			internal bool _003CIsEntityMetadata_003Eb__11_0(PropertyMetadata property)
			{
				return ((INamedMetadata)property).get_Name() == "Model";
			}
		}

		private readonly ICurrentPageService currentPageService;

		private readonly IMetadataServiceContext metadataServiceContext;

		public override Guid Uid => new Guid("{BF73FB64-E146-4178-8A5C-EAF03631C1A8}");

		public override string Name => SR.T("Контейнер для свойств по умолчанию");

		public override bool Visible => IsEntityMetadata();

		public override string Icon => "setting-default-container";

		public ToolboxItem(ICurrentPageService currentPageService, IMetadataServiceContext metadataServiceContext, ViewItemInfoService viewItemInfoService)
			: base((IViewItemInfoService)viewItemInfoService)
		{
			this.currentPageService = currentPageService;
			this.metadataServiceContext = metadataServiceContext;
		}

		private bool IsEntityMetadata()
		{
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			IMetadata metadata = currentPageService.CurrentPageViewModel.Metadata;
			DataClassMetadata val;
			if ((val = (DataClassMetadata)(object)((metadata is DataClassMetadata) ? metadata : null)) != null && ((INamedMetadata)val).get_Name() == "ViewModelContext")
			{
				PropertyMetadata val2 = Enumerable.FirstOrDefault<PropertyMetadata>((System.Collections.Generic.IEnumerable<PropertyMetadata>)((ClassMetadata)val).get_Properties(), (Func<PropertyMetadata, bool>)((PropertyMetadata property) => ((INamedMetadata)property).get_Name() == "Model"));
				if (val2 == null)
				{
					return false;
				}
				return CheckMetadata(metadataServiceContext.GetMetadata(((IPropertyMetadata)val2).get_SubTypeUid()));
			}
			return CheckMetadata(metadata);
		}

		private static bool CheckMetadata(IMetadata metadata)
		{
			EntityMetadata val;
			if ((val = (EntityMetadata)(object)((metadata is EntityMetadata) ? metadata : null)) != null)
			{
				return !DTOHelper.ProxyType("943d4d9d-5c7c-4de9-884f-014f014f92fb").CanCast(ObjectExtensions.As<ReactiveProxy>((object)val));
			}
			return false;
		}
	}

	public static readonly Guid ItemUid = new Guid("26A21740-0AF0-40A0-8230-D9CBEBE22F09");

	private int _003CStartColumnIndex_003Ek__BackingField;

	private bool _003CReadOnly_003Ek__BackingField;

	private bool _003COnlyUserProperties_003Ek__BackingField;

	public override Guid Uid
	{
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			return ItemUid;
		}
		set
		{
		}
	}

	public int StartColumnIndex
	{
		get
		{
			return _003CStartColumnIndex_003Ek__BackingField;
		}
		set
		{
			_003CStartColumnIndex_003Ek__BackingField = value;
		}
	}

	public bool ReadOnly
	{
		get
		{
			return _003CReadOnly_003Ek__BackingField;
		}
		set
		{
			_003CReadOnly_003Ek__BackingField = value;
		}
	}

	public bool OnlyUserProperties
	{
		get
		{
			return _003COnlyUserProperties_003Ek__BackingField;
		}
		set
		{
			_003COnlyUserProperties_003Ek__BackingField = value;
		}
	}

	public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		if (!(parentViewItem is FormViewItem) && !(parentViewItem is ColumnsLayoutViewItem))
		{
			return parentViewItem is ColumnViewItem;
		}
		return true;
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return false;
	}
}
