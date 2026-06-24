using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Globalization;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Transformations;
using EleWise.ELMA.Model.Views.Toolbar;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Views;

[Serializable]
[DebuggerTypeProxy(typeof(DebugView))]
[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources_FormViewItem), "DisplayName")]
public class FormViewItem : FormView, IContainerViewItem, IThemeContainerViewItem
{
	public new sealed class DebugView
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly FormViewItem viewItem;

		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		private readonly RootViewItem.DebugView _rootViewItemDebugView;

		internal static DebugView ouy2PjCQKmkdhHrrpaIS;

		public ViewType ViewType
		{
			get
			{
				return viewItem.ViewType;
			}
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						viewItem.ViewType = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public bool? ReadOnly
		{
			get
			{
				return viewItem.ReadOnly;
			}
			set
			{
				viewItem.ReadOnly = value;
			}
		}

		public EleWise.ELMA.Model.Views.Toolbar.Toolbar Toolbar
		{
			get
			{
				return viewItem.Toolbar;
			}
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						EZPEhCCQnuE70gmh40d1(viewItem, value);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public string OnLoadScriptName
		{
			get
			{
				return viewItem.OnLoadScriptName;
			}
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						QQCpZ6CQOtEr5eBeVmgl(viewItem, value);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public DebugView(FormViewItem viewItem)
		{
			//Discarded unreachable code: IL_002a, IL_002f
			gMvJqJCQkvHfHelRN1oE();
			base._002Ector();
			int num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 2:
					return;
				case 1:
					_rootViewItemDebugView = new RootViewItem.DebugView(viewItem);
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
					{
						num = 0;
					}
					break;
				default:
					this.viewItem = viewItem;
					num = 2;
					break;
				}
			}
		}

		internal static void gMvJqJCQkvHfHelRN1oE()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool j2i6rsCQXluVPLZwAGNx()
		{
			return ouy2PjCQKmkdhHrrpaIS == null;
		}

		internal static DebugView gr2xtMCQTjstHbiA9yTn()
		{
			return ouy2PjCQKmkdhHrrpaIS;
		}

		internal static void EZPEhCCQnuE70gmh40d1(object P_0, object P_1)
		{
			((FormViewItem)P_0).Toolbar = (EleWise.ELMA.Model.Views.Toolbar.Toolbar)P_1;
		}

		internal static void QQCpZ6CQOtEr5eBeVmgl(object P_0, object P_1)
		{
			((FormView)P_0).OnLoadScriptName = (string)P_1;
		}
	}

	internal static FormViewItem dx5aZFo26ct58dwCeCZf;

	[EleWise.ELMA.Model.Transformations.ChangeableProperty]
	public override Guid Uid
	{
		get
		{
			return base.Uid;
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					base.Uid = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public Guid GroupUid
	{
		[CompilerGenerated]
		get
		{
			return _003CGroupUid_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003CGroupUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public Guid TargetUid
	{
		[CompilerGenerated]
		get
		{
			return _003CTargetUid_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					_003CTargetUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[EleWise.ELMA.Model.Transformations.ChangeableProperty]
	[EleWise.ELMA.Globalization.Localizable]
	public string DisplayName
	{
		[CompilerGenerated]
		get
		{
			return _003CDisplayName_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					_003CDisplayName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[EleWise.ELMA.Model.Transformations.ChangeableProperty]
	[Obsolete("Use HideEmptySettings instead", false)]
	[ForceDefaultValue(false)]
	[XmlForceElement]
	public bool HideEmptyChildProperties
	{
		get
		{
			return false;
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					base.HideEmpty = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public Guid MainPlaceholderUid
	{
		[CompilerGenerated]
		get
		{
			return _003CMainPlaceholderUid_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003CMainPlaceholderUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public EleWise.ELMA.Model.Views.Toolbar.Toolbar Toolbar
	{
		[CompilerGenerated]
		get
		{
			return _003CToolbar_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003CToolbar_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public ViewItemTheme Theme
	{
		[CompilerGenerated]
		get
		{
			return _003CTheme_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003CTheme_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	[EleWise.ELMA.Model.Transformations.ChangeableProperty]
	[DefaultValue(RuntimeVersion.Version1)]
	public RuntimeVersion RuntimeVersion
	{
		[CompilerGenerated]
		get
		{
			return _003CRuntimeVersion_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003CRuntimeVersion_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeGroupUid()
	{
		return BDtySEo27qxkxWsqkZKD(GroupUid, Guid.Empty);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeTargetUid()
	{
		return BDtySEo27qxkxWsqkZKD(TargetUid, Guid.Empty);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual bool ShouldSerializeMainPlaceholderUid()
	{
		return BDtySEo27qxkxWsqkZKD(MainPlaceholderUid, Guid.Empty);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual bool ShouldSerializeTheme()
	{
		return Theme != ViewItemTheme.Inherit;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual bool ShouldSerializeRuntimeVersion()
	{
		return RuntimeVersion != RuntimeVersion.Version1;
	}

	protected internal override void SetReadOnly()
	{
		base.SetReadOnly();
	}

	protected internal override void SetReadOnly(bool value)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				ReadOnly = value;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				base.SetReadOnly(value);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public bool IsValid()
	{
		ViewItem invalidItem;
		return IsValid(out invalidItem);
	}

	public bool IsValid(out ViewItem invalidItem)
	{
		//Discarded unreachable code: IL_010e, IL_011e
		int num = 6;
		ICollection<Guid> uids = default(ICollection<Guid>);
		Guid? guid = default(Guid?);
		ICollection<Guid> collection = default(ICollection<Guid>);
		while (true)
		{
			int num2 = num;
			object obj;
			while (true)
			{
				Guid? guid2;
				switch (num2)
				{
				case 7:
					invalidItem = InvalidItem(this, uids, base.ViewType);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
					{
						num2 = 4;
					}
					continue;
				default:
					if (!guid.HasValue)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
						{
							num2 = 2;
						}
						continue;
					}
					obj = ViewItemMetadataAttribute.GetUids(MetadataLoader.LoadMetadata(guid.Value));
					if (obj == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto end_IL_0012;
				case 2:
					collection = new Guid[0];
					num2 = 3;
					continue;
				case 6:
					if (!BDtySEo27qxkxWsqkZKD(GroupUid, Guid.Empty))
					{
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
						{
							num2 = 5;
						}
						continue;
					}
					guid2 = GroupUid;
					break;
				case 4:
					return invalidItem == null;
				case 3:
					obj = collection;
					goto end_IL_0012;
				case 5:
					guid2 = base.MetadataUid;
					break;
				case 1:
					obj = new Guid[1] { guid.Value };
					goto end_IL_0012;
				}
				guid = guid2;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
				{
					num2 = 0;
				}
				continue;
				end_IL_0012:
				break;
			}
			uids = (ICollection<Guid>)obj;
			num = 7;
		}
	}

	private static ViewItem InvalidItem(object parentViewItem, ICollection<Guid> uids, ViewType viewType)
	{
		if (parentViewItem is RootViewItem rootViewItem)
		{
			foreach (ViewItem item in rootViewItem.Items)
			{
				if (!ViewItemMetadataAttribute.IsAvailable(item.GetType(), uids))
				{
					return item;
				}
				if (!item.IsValid(viewType, (ViewItem)parentViewItem))
				{
					return item;
				}
				ViewItem viewItem = InvalidItem(item, uids, viewType);
				if (viewItem != null)
				{
					return viewItem;
				}
			}
		}
		return null;
	}

	public new FormViewItem Transformate(ViewItemTransformation transformation)
	{
		int num = 3;
		int num2 = num;
		_003C_003Ec__DisplayClass45_0 _003C_003Ec__DisplayClass45_ = default(_003C_003Ec__DisplayClass45_0);
		while (true)
		{
			switch (num2)
			{
			case 3:
				_003C_003Ec__DisplayClass45_ = new _003C_003Ec__DisplayClass45_0();
				num2 = 2;
				break;
			case 1:
				return ContextCacheExtensions.GetCacheData(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-234299632 ^ -234176836), this, _003C_003Ec__DisplayClass45_.transformation, _003C_003Ec__DisplayClass45_._003CTransformate_003Eb__0);
			case 2:
				_003C_003Ec__DisplayClass45_._003C_003E4__this = this;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				_003C_003Ec__DisplayClass45_.transformation = transformation;
				num2 = 4;
				break;
			case 4:
				if (_003C_003Ec__DisplayClass45_.transformation == null)
				{
					return (FormViewItem)base.Transformate((ViewItemTransformation)null);
				}
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public FormViewItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		p8Mtxko2xJyGUMpp0SDx();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool lfqSRDo2HlFb6tOOlXxn()
	{
		return dx5aZFo26ct58dwCeCZf == null;
	}

	internal static FormViewItem TvcAKTo2AwmZrDlr7TNU()
	{
		return dx5aZFo26ct58dwCeCZf;
	}

	internal static bool BDtySEo27qxkxWsqkZKD(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static void p8Mtxko2xJyGUMpp0SDx()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
