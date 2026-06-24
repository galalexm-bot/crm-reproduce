using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Transformations;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views;

[Serializable]
[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources_RootViewItem), "DisplayName")]
[DebuggerTypeProxy(typeof(DebugView))]
public abstract class RootViewItem : ViewItem, IHideEmptyViewItem, IReadOnlyViewItem
{
	public new sealed class DebugView
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public readonly RootViewItem viewItem;

		private static DebugView Bnds3PC8bSujfrpjnLKT;

		[DebuggerDisplay("{\"Count = \" + _Items.Count, nq}", Name = "Items")]
		public ListViewItem _Items => (ListViewItem)KDX8F6C8fZfxcj6sF1A5(viewItem);

		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		public ViewItem.DebugView viewItemDebugView
		{
			[CompilerGenerated]
			get
			{
				return _003CviewItemDebugView_003Ek__BackingField;
			}
			[CompilerGenerated]
			private set
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
						_003CviewItemDebugView_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
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

		public DebugView(RootViewItem viewItem)
		{
			//Discarded unreachable code: IL_001a, IL_001f
			h1ieynC8ERfTt0hk1ZlN();
			base._002Ector();
			int num = 2;
			while (true)
			{
				switch (num)
				{
				case 1:
					return;
				case 2:
					viewItemDebugView = new ViewItem.DebugView(viewItem);
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
					{
						num = 0;
					}
					break;
				default:
					this.viewItem = viewItem;
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
					{
						num = 1;
					}
					break;
				}
			}
		}

		internal static void h1ieynC8ERfTt0hk1ZlN()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool gTnD08C8h5fiObvr5XfE()
		{
			return Bnds3PC8bSujfrpjnLKT == null;
		}

		internal static DebugView fxUoAUC8GtXXQUesVSq4()
		{
			return Bnds3PC8bSujfrpjnLKT;
		}

		internal static object KDX8F6C8fZfxcj6sF1A5(object P_0)
		{
			return ((RootViewItem)P_0).Items;
		}
	}

	private readonly ListViewItem items;

	private IEnumerable<ViewItem> oldItems;

	internal static RootViewItem bDQ0oio3Er7IpD2vgC1V;

	public Guid? MetadataUid { get; set; }

	[NotNull]
	[XmlArrayItem("ViewItem")]
	[XmlArrayItem("RootViewItem", typeof(RootViewItem))]
	public ListViewItem Items => items;

	[DefaultValue(false)]
	[EleWise.ELMA.Model.Transformations.ChangeableProperty]
	[Obsolete("Use HideEmptySettings instead", true)]
	public bool HideEmpty
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
				case 0:
					return;
				case 1:
					HideEmptySettings = ((!value) ? HideEmptyEnum.ShowEmpty : HideEmptyEnum.HideEmpty);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlElement("HideEmpty")]
	[DefaultValue(HideEmptyEnum.Inherit)]
	[EleWise.ELMA.Model.Transformations.ChangeableProperty]
	public HideEmptyEnum HideEmptySettings
	{
		[CompilerGenerated]
		get
		{
			return _003CHideEmptySettings_003Ek__BackingField;
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
					_003CHideEmptySettings_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[EleWise.ELMA.Model.Transformations.ChangeableProperty]
	public virtual bool? ReadOnly { get; set; }

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeMetadataUid()
	{
		int num = 1;
		int num2 = num;
		Guid? metadataUid = default(Guid?);
		while (true)
		{
			switch (num2)
			{
			default:
				return metadataUid.HasValue;
			case 1:
				metadataUid = MetadataUid;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeItems()
	{
		return mUWqHDo3CoQoyNt5GQUZ(Items) > 0;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual bool ShouldSerializeReadOnly()
	{
		int num = 1;
		int num2 = num;
		bool? readOnly = default(bool?);
		while (true)
		{
			switch (num2)
			{
			default:
				return readOnly.HasValue;
			case 1:
				readOnly = ReadOnly;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual bool IsHideEmpty(RootViewItem parent = null)
	{
		//Discarded unreachable code: IL_009c, IL_00ab
		int num = 2;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				RootViewItem rootViewItem;
				RootViewItem rootViewItem2;
				switch (num2)
				{
				case 1:
					return HideEmptySettings == HideEmptyEnum.HideEmpty;
				default:
					rootViewItem = parent;
					if (rootViewItem == null)
					{
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
						{
							num2 = 5;
						}
						break;
					}
					goto IL_00d5;
				case 2:
					if (HideEmptySettings == HideEmptyEnum.Inherit)
					{
						rootViewItem2 = parent;
						if (rootViewItem2 == null)
						{
							num2 = 4;
							break;
						}
						goto IL_00bc;
					}
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
					{
						num2 = 1;
					}
					break;
				case 4:
					rootViewItem2 = base.Parent;
					goto IL_00bc;
				case 5:
					rootViewItem = base.Parent;
					goto IL_00d5;
				case 3:
					{
						return false;
					}
					IL_00bc:
					if (rootViewItem2 == null)
					{
						goto end_IL_0012;
					}
					goto default;
					IL_00d5:
					return rootViewItem.IsHideEmpty();
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 3;
		}
	}

	public FormViewItemTransformation CreateTransformation(RootViewItem originalItem)
	{
		return (FormViewItemTransformation)eQdp2Yo3vlFWBdlqYJBW(this, originalItem);
	}

	public ViewItem FindItem(Guid itemUid)
	{
		return FindItem(this, itemUid);
	}

	public T FindItem<T>(Guid itemUid) where T : ViewItem
	{
		return FindItem(this, itemUid) as T;
	}

	public ViewItem FindItem(Func<ViewItem, bool> condition)
	{
		return FindItem(this, condition);
	}

	public T FindItem<T>(Func<T, bool> condition) where T : ViewItem
	{
		_003C_003Ec__DisplayClass27_0<T> CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass27_0<T>();
		CS_0024_003C_003E8__locals0.condition = condition;
		return FindItem(this, delegate(ViewItem item)
		{
			//Discarded unreachable code: IL_0066, IL_0075
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return CS_0024_003C_003E8__locals0.condition((T)item);
				default:
					return false;
				case 1:
					if (!(item is T))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				}
			}
		}) as T;
	}

	public IEnumerable<ViewItem> GetAllItems(bool ignoreHide = true)
	{
		return FindItems(this, ignoreHide, null, null);
	}

	public IEnumerable<ViewItem> FindItems(bool ignoreHide = true, Func<ViewItem, bool> itemCondition = null, Func<ViewItem, bool> deepCondition = null)
	{
		return FindItems(this, ignoreHide, itemCondition, deepCondition);
	}

	public IEnumerable<PropertyViewItem> GetAllProperties(bool ignoreHide = true)
	{
		return GetAllProperties(this, ignoreHide);
	}

	public void RemoveHiddenViewItems()
	{
		LEGFrCo38iCbL9OYYxWe(this);
	}

	public override void FullCopyFrom(ViewItem viewItem)
	{
		//Discarded unreachable code: IL_0065, IL_006f, IL_0129, IL_013c, IL_014b
		int num = 1;
		int num2 = num;
		ViewItem viewItem2 = default(ViewItem);
		List<ViewItem>.Enumerator enumerator = default(List<ViewItem>.Enumerator);
		ViewItem current = default(ViewItem);
		RootViewItem rootViewItem = default(RootViewItem);
		while (true)
		{
			switch (num2)
			{
			default:
				base.CopyFrom(viewItem2);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
				{
					num2 = 1;
				}
				break;
			case 7:
				return;
			case 5:
				try
				{
					while (true)
					{
						IL_00d7:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
							{
								num3 = 0;
							}
							goto IL_0073;
						}
						goto IL_00b4;
						IL_00b4:
						current = enumerator.Current;
						num3 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
						{
							num3 = 2;
						}
						goto IL_0073;
						IL_0073:
						while (true)
						{
							switch (num3)
							{
							default:
								return;
							case 0:
								return;
							case 2:
								items.Add(current);
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
								{
									num3 = 1;
								}
								continue;
							case 3:
								break;
							case 1:
								goto IL_00d7;
							}
							break;
						}
						goto IL_00b4;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
			case 4:
				items.Clear();
				num2 = 3;
				break;
			case 6:
				if (rootViewItem == null)
				{
					return;
				}
				num2 = 4;
				break;
			case 3:
				enumerator = ((IEnumerable<ViewItem>)t2tSmPo3Ze1WkfGitAo8(rootViewItem)).ToList().GetEnumerator();
				num2 = 5;
				break;
			case 2:
				rootViewItem = viewItem2 as RootViewItem;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
				{
					num2 = 6;
				}
				break;
			case 1:
				viewItem2 = ClassSerializationHelper.CloneObjectByXml(viewItem);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected internal override void SetReadOnly()
	{
		base.SetReadOnly();
	}

	protected internal override void SetReadOnly(bool value)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				base.SetReadOnly(value);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				SetReadOnly(value, recursive: true);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	protected internal virtual void SetReadOnly(bool value, bool recursive)
	{
		//Discarded unreachable code: IL_006a, IL_0074, IL_0101, IL_0120, IL_012f, IL_014c, IL_015b
		int num = 1;
		int num2 = num;
		IEnumerator<ViewItem> enumerator = default(IEnumerator<ViewItem>);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			default:
				enumerator = Items.GetEnumerator();
				num2 = 3;
				break;
			case 1:
				if (!recursive)
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
							{
								num3 = 0;
							}
							goto IL_0078;
						}
						goto IL_008e;
						IL_008e:
						enumerator.Current.SetReadOnly(value);
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
						{
							num3 = 0;
						}
						goto IL_0078;
						IL_0078:
						switch (num3)
						{
						case 1:
							return;
						case 2:
							break;
						default:
							continue;
						}
						goto IL_008e;
					}
				}
				finally
				{
					int num4;
					if (enumerator == null)
					{
						num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
						{
							num4 = 0;
						}
						goto IL_0105;
					}
					goto IL_013a;
					IL_013a:
					enumerator.Dispose();
					num4 = 2;
					goto IL_0105;
					IL_0105:
					switch (num4)
					{
					case 1:
						goto end_IL_00e0;
					case 2:
						goto end_IL_00e0;
					}
					goto IL_013a;
					end_IL_00e0:;
				}
			}
		}
	}

	public virtual bool IsReadOnly()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
			{
				RootViewItem parent = base.Parent;
				if (parent == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
					{
						num2 = 0;
					}
					break;
				}
				return cby3dbo3ucdy79maGJyZ(parent);
			}
			default:
				return false;
			}
		}
	}

	protected internal override void SetVisible(bool visible)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				iPUjMEo3IjZ789rMlw0O(this, visible, true);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 2:
				base.SetVisible(visible);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	protected internal virtual void SetVisible(bool visible, bool recursive)
	{
		//Discarded unreachable code: IL_007a, IL_0089, IL_0094, IL_0111, IL_0149, IL_0158
		int num = 2;
		int num2 = num;
		IEnumerator<ViewItem> enumerator = default(IEnumerator<ViewItem>);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return;
			case 1:
				enumerator = Items.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				if (!recursive)
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
				{
					num2 = 1;
				}
				continue;
			}
			try
			{
				while (true)
				{
					int num3;
					if (!enumerator.MoveNext())
					{
						num3 = 2;
						goto IL_0098;
					}
					goto IL_00ae;
					IL_0098:
					switch (num3)
					{
					case 2:
						return;
					case 1:
						break;
					default:
						continue;
					}
					goto IL_00ae;
					IL_00ae:
					aqXiJFo3VEdIVvA3NupI(enumerator.Current, visible);
					num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num3 = 0;
					}
					goto IL_0098;
				}
			}
			finally
			{
				if (enumerator != null)
				{
					int num4 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
					{
						num4 = 0;
					}
					while (true)
					{
						switch (num4)
						{
						case 1:
							Rl9bFIo3SII2LovqKbJx(enumerator);
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
							{
								num4 = 0;
							}
							continue;
						case 0:
							break;
						}
						break;
					}
				}
			}
		}
	}

	public virtual bool IsVisible()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
			{
				RootViewItem parent = base.Parent;
				if (parent == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return Fr3tTeo3iYQpfdOP64RF(parent);
			}
			default:
				return true;
			}
		}
	}

	protected RootViewItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		QsHU4go3Rpi83UPaeaaE();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				items = new ListViewItem(this)
				{
					ClearingItems = ClearingItems,
					ClearedItems = ClearedItems,
					AddingItem = AddingItem,
					AddedItem = AddedItem,
					RemovingItem = RemovingItem,
					RemovedItem = RemovedItem
				};
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	private void ClearingItems(object sender, EventArgs eventArgs)
	{
		//Discarded unreachable code: IL_0075, IL_0084, IL_008f, IL_010c, IL_012b, IL_015b, IL_016a
		int num = 3;
		int num2 = num;
		IEnumerator<ViewItem> enumerator = default(IEnumerator<ViewItem>);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				enumerator = Items.GetEnumerator();
				num2 = 2;
				continue;
			case 1:
				break;
			case 0:
				return;
			case 2:
				try
				{
					while (true)
					{
						int num3;
						if (!IJutxco3KsBAaQOipffv(enumerator))
						{
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
							{
								num3 = 0;
							}
							goto IL_0093;
						}
						goto IL_00a9;
						IL_00a9:
						PBIOyGo3qdbmoDRaeEdk(enumerator.Current, this);
						num3 = 2;
						goto IL_0093;
						IL_0093:
						switch (num3)
						{
						case 1:
							goto IL_00a9;
						case 2:
							continue;
						case 0:
							break;
						}
						break;
					}
				}
				finally
				{
					int num4;
					if (enumerator == null)
					{
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
						{
							num4 = 0;
						}
						goto IL_0110;
					}
					goto IL_0139;
					IL_0139:
					Rl9bFIo3SII2LovqKbJx(enumerator);
					num4 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
					{
						num4 = 1;
					}
					goto IL_0110;
					IL_0110:
					switch (num4)
					{
					default:
						goto end_IL_00eb;
					case 0:
						goto end_IL_00eb;
					case 2:
						break;
					case 1:
						goto end_IL_00eb;
					}
					goto IL_0139;
					end_IL_00eb:;
				}
				break;
			}
			oldItems = items.ToArray();
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
			{
				num2 = 0;
			}
		}
	}

	private void ClearedItems(object sender, EventArgs eventArgs)
	{
		//Discarded unreachable code: IL_002e, IL_003d, IL_0048, IL_00c5, IL_00e4, IL_00f3, IL_0120, IL_012f
		int num = 1;
		int num2 = num;
		IEnumerator<ViewItem> enumerator = default(IEnumerator<ViewItem>);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				enumerator = oldItems.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				while (true)
				{
					int num3;
					if (!IJutxco3KsBAaQOipffv(enumerator))
					{
						num3 = 2;
						goto IL_004c;
					}
					goto IL_0078;
					IL_004c:
					switch (num3)
					{
					case 1:
						break;
					default:
						goto IL_0078;
					case 2:
						return;
					}
					continue;
					IL_0078:
					eJFsINo3XMAaR1Su1X3K(enumerator.Current, this);
					num3 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
					{
						num3 = 1;
					}
					goto IL_004c;
				}
			}
			finally
			{
				int num4;
				if (enumerator == null)
				{
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
					{
						num4 = 2;
					}
					goto IL_00c9;
				}
				goto IL_00fe;
				IL_00fe:
				Rl9bFIo3SII2LovqKbJx(enumerator);
				num4 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
				{
					num4 = 0;
				}
				goto IL_00c9;
				IL_00c9:
				switch (num4)
				{
				default:
					goto end_IL_00a4;
				case 2:
					goto end_IL_00a4;
				case 1:
					break;
				case 0:
					goto end_IL_00a4;
				}
				goto IL_00fe;
				end_IL_00a4:;
			}
		}
	}

	private void AddingItem(object sender, EventedListEventArgs<ViewItem> listViewItemEventArgs)
	{
		listViewItemEventArgs.Item.OnAdding(this);
	}

	private void AddedItem(object sender, EventedListEventArgs<ViewItem> listViewItemEventArgs)
	{
		listViewItemEventArgs.Item.OnAdded(this);
	}

	private void RemovingItem(object sender, EventedListEventArgs<ViewItem> listViewItemEventArgs)
	{
		listViewItemEventArgs.Item.OnRemoving(this);
	}

	private void RemovedItem(object sender, EventedListEventArgs<ViewItem> listViewItemEventArgs)
	{
		listViewItemEventArgs.Item.OnRemoved(this);
	}

	public override void OnAdding(RootViewItem parent)
	{
		//Discarded unreachable code: IL_0059, IL_0068, IL_0073, IL_0100, IL_0138, IL_0147
		int num = 3;
		int num2 = num;
		IEnumerator<ViewItem> enumerator = default(IEnumerator<ViewItem>);
		while (true)
		{
			switch (num2)
			{
			case 2:
				enumerator = Items.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
				{
					num2 = 0;
				}
				continue;
			case 1:
				return;
			case 3:
				base.OnAdding(parent);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
				{
					num2 = 2;
				}
				continue;
			}
			try
			{
				while (true)
				{
					int num3;
					if (!enumerator.MoveNext())
					{
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
						{
							num3 = 1;
						}
						goto IL_0077;
					}
					goto IL_008d;
					IL_008d:
					tOlAPSo3TdjmsuX8jVLE(enumerator.Current, parent);
					num3 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
					{
						num3 = 2;
					}
					goto IL_0077;
					IL_0077:
					switch (num3)
					{
					case 2:
						continue;
					case 1:
						return;
					}
					goto IL_008d;
				}
			}
			finally
			{
				if (enumerator != null)
				{
					int num4 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
					{
						num4 = 1;
					}
					while (true)
					{
						switch (num4)
						{
						case 1:
							Rl9bFIo3SII2LovqKbJx(enumerator);
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
							{
								num4 = 0;
							}
							continue;
						case 0:
							break;
						}
						break;
					}
				}
			}
		}
	}

	public override void OnAdded(RootViewItem parent)
	{
		//Discarded unreachable code: IL_0032, IL_003c, IL_00c9, IL_0101, IL_0110
		int num = 2;
		int num2 = num;
		IEnumerator<ViewItem> enumerator = default(IEnumerator<ViewItem>);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
							{
								num3 = 1;
							}
							goto IL_0040;
						}
						goto IL_0056;
						IL_0056:
						enumerator.Current.OnAdded(parent);
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
						{
							num3 = 0;
						}
						goto IL_0040;
						IL_0040:
						switch (num3)
						{
						case 2:
							break;
						default:
							continue;
						case 1:
							return;
						}
						goto IL_0056;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								Rl9bFIo3SII2LovqKbJx(enumerator);
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
								{
									num4 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
			case 2:
				base.OnAdded(parent);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				enumerator = Items.GetEnumerator();
				num2 = 3;
				break;
			case 0:
				return;
			}
		}
	}

	public override void OnRemoving(RootViewItem parent)
	{
		//Discarded unreachable code: IL_007a, IL_0089, IL_0094, IL_0111, IL_0130, IL_015c, IL_016b
		int num = 2;
		int num2 = num;
		IEnumerator<ViewItem> enumerator = default(IEnumerator<ViewItem>);
		while (true)
		{
			switch (num2)
			{
			case 2:
				enumerator = Items.GetEnumerator();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
				{
					num2 = 1;
				}
				continue;
			case 1:
				try
				{
					while (true)
					{
						int num3;
						if (!IJutxco3KsBAaQOipffv(enumerator))
						{
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
							{
								num3 = 0;
							}
							goto IL_0098;
						}
						goto IL_00d4;
						IL_00d4:
						PBIOyGo3qdbmoDRaeEdk(enumerator.Current, parent);
						num3 = 2;
						goto IL_0098;
						IL_0098:
						switch (num3)
						{
						case 2:
							continue;
						case 1:
							goto IL_00d4;
						case 0:
							break;
						}
						break;
					}
				}
				finally
				{
					int num4;
					if (enumerator == null)
					{
						num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
						{
							num4 = 1;
						}
						goto IL_0115;
					}
					goto IL_013a;
					IL_013a:
					Rl9bFIo3SII2LovqKbJx(enumerator);
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
					{
						num4 = 0;
					}
					goto IL_0115;
					IL_0115:
					switch (num4)
					{
					default:
						goto end_IL_00f0;
					case 1:
						goto end_IL_00f0;
					case 2:
						break;
					case 0:
						goto end_IL_00f0;
					}
					goto IL_013a;
					end_IL_00f0:;
				}
				break;
			case 3:
				return;
			}
			base.OnRemoving(parent);
			num2 = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
			{
				num2 = 3;
			}
		}
	}

	public override void OnRemoved(RootViewItem parent)
	{
		//Discarded unreachable code: IL_0033, IL_0042, IL_004d, IL_00ca, IL_0102, IL_0111
		int num = 3;
		int num2 = num;
		IEnumerator<ViewItem> enumerator = default(IEnumerator<ViewItem>);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 2;
							goto IL_0051;
						}
						goto IL_007d;
						IL_0051:
						switch (num3)
						{
						case 1:
							goto IL_007d;
						case 2:
							goto end_IL_0067;
						}
						continue;
						IL_007d:
						eJFsINo3XMAaR1Su1X3K(enumerator.Current, parent);
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
						{
							num3 = 0;
						}
						goto IL_0051;
						continue;
						end_IL_0067:
						break;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								enumerator.Dispose();
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
								{
									num4 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
				goto case 1;
			case 1:
				base.OnRemoved(parent);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				enumerator = Items.GetEnumerator();
				num2 = 2;
				break;
			}
		}
	}

	protected override IEnumerable<PropertyInfo> GetPropertiesForCopy()
	{
		return from p in base.GetPropertiesForCopy()
			where _003C_003Ec.L3TlO2C8iBokhZseMGvt(_003C_003Ec.U1jxLvC8VayYnISXQg2T(p), _003C_003Ec.gDxE6GC8ShrtvhnAT2T1(0x10E41EDB ^ 0x10E6B339))
			select p;
	}

	internal static ViewItem FindItem(ViewItem viewItem, Guid itemUid)
	{
		RootViewItem container;
		return FindItem(viewItem, itemUid, out container);
	}

	internal static ViewItem FindItem(ViewItem viewItem, Guid itemUid, out RootViewItem container)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass54_0 _003C_003Ec__DisplayClass54_ = default(_003C_003Ec__DisplayClass54_0);
		while (true)
		{
			switch (num2)
			{
			case 1:
				_003C_003Ec__DisplayClass54_ = new _003C_003Ec__DisplayClass54_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
				{
					num2 = 0;
				}
				break;
			default:
				_003C_003Ec__DisplayClass54_.itemUid = itemUid;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return FindItem(viewItem, _003C_003Ec__DisplayClass54_._003CFindItem_003Eb__0, out container);
			}
		}
	}

	internal static ViewItem FindItem(ViewItem viewItem, Func<ViewItem, bool> condition)
	{
		RootViewItem container;
		return FindItem(viewItem, condition, out container);
	}

	internal static ViewItem FindItem(ViewItem viewItem, Func<ViewItem, bool> condition, out RootViewItem container)
	{
		container = null;
		if (condition == null)
		{
			return null;
		}
		if (condition(viewItem))
		{
			return viewItem;
		}
		if (viewItem is RootViewItem rootViewItem && rootViewItem.Items != null)
		{
			foreach (ViewItem item in rootViewItem.Items)
			{
				ViewItem viewItem2 = FindItem(item, condition, out container);
				if (viewItem2 != null)
				{
					if (container == null)
					{
						container = rootViewItem;
					}
					return viewItem2;
				}
			}
		}
		return null;
	}

	private static IEnumerable<ViewItem> FindItems(object viewItem, bool ignoreHide, Func<ViewItem, bool> itemCondition, Func<ViewItem, bool> deepCondition)
	{
		_003C_003Ec__DisplayClass57_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass57_0();
		CS_0024_003C_003E8__locals0.ignoreHide = ignoreHide;
		CS_0024_003C_003E8__locals0.itemCondition = itemCondition;
		CS_0024_003C_003E8__locals0.deepCondition = deepCondition;
		if (!(viewItem is RootViewItem rootViewItem))
		{
			return new ViewItem[0];
		}
		return rootViewItem.Items.Where(delegate(ViewItem i)
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (!CS_0024_003C_003E8__locals0.ignoreHide)
					{
						return true;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
					{
						num2 = 0;
					}
					break;
				default:
					return !_003C_003Ec__DisplayClass57_0.y6BljdC81N9KNMlUK5MV(i);
				}
			}
		}).SelectMany(delegate(ViewItem i)
		{
			CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass57_1();
			CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1 = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.i = i;
			return Enumerable.Empty<ViewItem>().If(CS_0024_003C_003E8__locals0.itemCondition == null || CS_0024_003C_003E8__locals0.itemCondition(CS_0024_003C_003E8__locals0.i), (IEnumerable<ViewItem> enumerable) => enumerable.Concat(new ViewItem[1] { CS_0024_003C_003E8__locals0.i })).If(CS_0024_003C_003E8__locals0.deepCondition == null || CS_0024_003C_003E8__locals0.deepCondition(CS_0024_003C_003E8__locals0.i), (IEnumerable<ViewItem> enumerable) => enumerable.Concat(FindItems(CS_0024_003C_003E8__locals0.i, CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.ignoreHide, CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.itemCondition, CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.deepCondition)));
		});
	}

	private static IEnumerable<PropertyViewItem> GetAllProperties(object viewItem, bool ignoreHide)
	{
		_003C_003Ec__DisplayClass58_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass58_0();
		CS_0024_003C_003E8__locals0.ignoreHide = ignoreHide;
		if (!(viewItem is RootViewItem rootViewItem))
		{
			return new PropertyViewItem[0];
		}
		return rootViewItem.Items.Where(delegate(ViewItem i)
		{
			//Discarded unreachable code: IL_0039, IL_0048
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return !_003C_003Ec__DisplayClass58_0.WIt9RGC860SjXXdUeBwc(i);
				default:
					return true;
				case 1:
					if (!CS_0024_003C_003E8__locals0.ignoreHide)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				}
			}
		}).SelectMany((ViewItem i) => (!(i is PropertyViewItem)) ? GetAllProperties(i, CS_0024_003C_003E8__locals0.ignoreHide) : new PropertyViewItem[1] { (PropertyViewItem)i });
	}

	public static void RemoveHiddenViewItems(RootViewItem rootViewItem)
	{
		int num = 3;
		int num2 = num;
		_003C_003Ec__DisplayClass59_0 _003C_003Ec__DisplayClass59_ = default(_003C_003Ec__DisplayClass59_0);
		while (true)
		{
			switch (num2)
			{
			case 4:
				return;
			default:
				((IEnumerable)t2tSmPo3Ze1WkfGitAo8(_003C_003Ec__DisplayClass59_.rootViewItem)).OfType<RootViewItem>().Each(RemoveHiddenViewItems);
				num2 = 4;
				break;
			case 2:
				_003C_003Ec__DisplayClass59_.rootViewItem = rootViewItem;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				_003C_003Ec__DisplayClass59_ = new _003C_003Ec__DisplayClass59_0();
				num2 = 2;
				break;
			case 1:
				_003C_003Ec__DisplayClass59_.rootViewItem.items.Where((ViewItem i) => _003C_003Ec.CGBRJeC8RUjHGVhVkvlW(i)).ToList().ForEach(_003C_003Ec__DisplayClass59_._003CRemoveHiddenViewItems_003Eb__1);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override IEnumerable<string> GetLocalizableStrings()
	{
		List<string> list = new List<string>();
		IEnumerable<string> localizableStrings = base.GetLocalizableStrings();
		if (localizableStrings != null)
		{
			list.AddRange(localizableStrings);
		}
		if (items != null)
		{
			foreach (ViewItem item in items)
			{
				IEnumerable<string> localizableStrings2 = item.GetLocalizableStrings();
				if (localizableStrings2 != null)
				{
					foreach (string item2 in localizableStrings2)
					{
						if (item2 != null && !list.Contains(item2))
						{
							list.Add(item2);
						}
					}
				}
			}
			return list;
		}
		return list;
	}

	public override void ApplyLocalization()
	{
		//Discarded unreachable code: IL_0039, IL_0048, IL_00a6, IL_00b5, IL_00c0, IL_013c, IL_016c, IL_017b, IL_0187
		int num = 5;
		int num2 = num;
		IEnumerator<ViewItem> enumerator = default(IEnumerator<ViewItem>);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return;
			default:
				enumerator = items.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
				{
					num2 = 1;
				}
				break;
			case 5:
				base.ApplyLocalization();
				num2 = 4;
				break;
			case 4:
				if (items == null)
				{
					num2 = 3;
					break;
				}
				goto default;
			case 2:
				return;
			case 1:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
							{
								num3 = 0;
							}
							goto IL_00c4;
						}
						goto IL_00da;
						IL_00da:
						enumerator.Current.ApplyLocalization();
						num3 = 2;
						goto IL_00c4;
						IL_00c4:
						switch (num3)
						{
						case 1:
							return;
						case 2:
							continue;
						}
						goto IL_00da;
					}
				}
				finally
				{
					int num4;
					if (enumerator == null)
					{
						num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
						{
							num4 = 1;
						}
						goto IL_0140;
					}
					goto IL_0156;
					IL_0156:
					enumerator.Dispose();
					num4 = 2;
					goto IL_0140;
					IL_0140:
					switch (num4)
					{
					case 1:
						goto end_IL_011b;
					case 2:
						goto end_IL_011b;
					}
					goto IL_0156;
					end_IL_011b:;
				}
			}
		}
	}

	internal static bool UDZZIho3fjQtqeI41Shi()
	{
		return bDQ0oio3Er7IpD2vgC1V == null;
	}

	internal static RootViewItem up0kqEo3QhjXEW01EZeT()
	{
		return bDQ0oio3Er7IpD2vgC1V;
	}

	internal static int mUWqHDo3CoQoyNt5GQUZ(object P_0)
	{
		return ((EventedList<ViewItem>)P_0).Count;
	}

	internal static object eQdp2Yo3vlFWBdlqYJBW(object P_0, object P_1)
	{
		return TransformationViewItem.CreateTransformation((ViewItem)P_0, (ViewItem)P_1);
	}

	internal static void LEGFrCo38iCbL9OYYxWe(object P_0)
	{
		RemoveHiddenViewItems((RootViewItem)P_0);
	}

	internal static object t2tSmPo3Ze1WkfGitAo8(object P_0)
	{
		return ((RootViewItem)P_0).Items;
	}

	internal static bool cby3dbo3ucdy79maGJyZ(object P_0)
	{
		return ((RootViewItem)P_0).IsReadOnly();
	}

	internal static void iPUjMEo3IjZ789rMlw0O(object P_0, bool visible, bool recursive)
	{
		((RootViewItem)P_0).SetVisible(visible, recursive);
	}

	internal static void aqXiJFo3VEdIVvA3NupI(object P_0, bool visible)
	{
		((ViewItem)P_0).SetVisible(visible);
	}

	internal static void Rl9bFIo3SII2LovqKbJx(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static bool Fr3tTeo3iYQpfdOP64RF(object P_0)
	{
		return ((RootViewItem)P_0).IsVisible();
	}

	internal static void QsHU4go3Rpi83UPaeaaE()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static void PBIOyGo3qdbmoDRaeEdk(object P_0, object P_1)
	{
		((ViewItem)P_0).OnRemoving((RootViewItem)P_1);
	}

	internal static bool IJutxco3KsBAaQOipffv(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void eJFsINo3XMAaR1Su1X3K(object P_0, object P_1)
	{
		((ViewItem)P_0).OnRemoved((RootViewItem)P_1);
	}

	internal static void tOlAPSo3TdjmsuX8jVLE(object P_0, object P_1)
	{
		((ViewItem)P_0).OnAdding((RootViewItem)P_1);
	}
}
