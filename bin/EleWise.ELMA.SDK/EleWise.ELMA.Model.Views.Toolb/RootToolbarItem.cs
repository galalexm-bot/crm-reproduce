using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Transformations;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views.Toolbar;

[Serializable]
public class RootToolbarItem : ToolbarItem
{
	private ToolbarItemList items;

	private IEnumerable<ToolbarItem> oldItems;

	private static RootToolbarItem dl1MMNot4SKiEoVh8TrE;

	[XmlArrayItem("RootViewItem", typeof(RootToolbarItem))]
	[NotNull]
	[XmlArrayItem("ViewItem")]
	public ToolbarItemList Items => items;

	protected RootToolbarItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		r263lwotAKkJ5gQ4OkSy();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				items = new ToolbarItemList(this)
				{
					ClearingItems = ClearingItems,
					ClearedItems = ClearedItems,
					AddingItem = AddingItem,
					AddedItem = AddedItem,
					RemovingItem = RemovingItem,
					RemovedItem = RemovedItem
				};
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	~RootToolbarItem()
	{
		//Discarded unreachable code: IL_0072, IL_020a, IL_021d, IL_022c
		switch (1)
		{
		case 0:
			break;
		case 1:
			try
			{
				items.ClearingItems = delegate
				{
				};
				int num = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
				{
					num = 2;
				}
				while (true)
				{
					switch (num)
					{
					case 4:
						return;
					case 3:
						items.ClearedItems = delegate
						{
						};
						num = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
						{
							num = 0;
						}
						break;
					default:
						items.AddingItem = delegate
						{
						};
						num = 5;
						break;
					case 5:
						items.AddedItem = delegate
						{
						};
						num = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
						{
							num = 1;
						}
						break;
					case 1:
						items.RemovingItem = delegate
						{
						};
						num = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
						{
							num = 2;
						}
						break;
					case 2:
						items.RemovedItem = delegate
						{
						};
						num = 4;
						break;
					}
				}
			}
			finally
			{
				JHX4Jbot7SKTjIEi3QUn(this);
				int num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				case 0:
					break;
				}
			}
		}
	}

	private void ClearingItems(object sender, EventArgs eventArgs)
	{
		//Discarded unreachable code: IL_005e, IL_006d, IL_0078, IL_0105, IL_0124, IL_0133, IL_0160, IL_016f
		int num = 3;
		int num2 = num;
		IEnumerator<ToolbarItem> enumerator = default(IEnumerator<ToolbarItem>);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				oldItems = items.ToArray();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
				{
					num2 = 0;
				}
				break;
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
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
							{
								num3 = 1;
							}
							goto IL_007c;
						}
						goto IL_0092;
						IL_0092:
						uRkeQBotx1CKR9vvnxeJ(enumerator.Current, this);
						num3 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
						{
							num3 = 2;
						}
						goto IL_007c;
						IL_007c:
						switch (num3)
						{
						case 2:
							continue;
						case 1:
							goto end_IL_00b9;
						}
						goto IL_0092;
						continue;
						end_IL_00b9:
						break;
					}
				}
				finally
				{
					int num4;
					if (enumerator == null)
					{
						num4 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
						{
							num4 = 2;
						}
						goto IL_0109;
					}
					goto IL_013e;
					IL_013e:
					spOtaNot0ivGWmOhYhfY(enumerator);
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
					{
						num4 = 0;
					}
					goto IL_0109;
					IL_0109:
					switch (num4)
					{
					default:
						goto end_IL_00e4;
					case 2:
						goto end_IL_00e4;
					case 1:
						break;
					case 0:
						goto end_IL_00e4;
					}
					goto IL_013e;
					end_IL_00e4:;
				}
				goto case 1;
			case 3:
				enumerator = Items.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	private void ClearedItems(object sender, EventArgs eventArgs)
	{
		//Discarded unreachable code: IL_002e, IL_003d, IL_00dc, IL_00eb, IL_0118, IL_0127
		int num = 1;
		int num2 = num;
		IEnumerator<ToolbarItem> enumerator = default(IEnumerator<ToolbarItem>);
		while (true)
		{
			switch (num2)
			{
			case 1:
				enumerator = oldItems.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return;
			}
			try
			{
				while (true)
				{
					int num3;
					if (!enumerator.MoveNext())
					{
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
						{
							num3 = 0;
						}
						goto IL_004c;
					}
					goto IL_0062;
					IL_0062:
					dTgjlZotmWryBfwDUQ33(enumerator.Current, this);
					int num4 = 2;
					num3 = num4;
					goto IL_004c;
					IL_004c:
					switch (num3)
					{
					default:
						return;
					case 1:
						break;
					case 2:
						continue;
					case 0:
						return;
					}
					goto IL_0062;
				}
			}
			finally
			{
				int num6;
				if (enumerator == null)
				{
					int num5 = 2;
					num6 = num5;
					goto IL_00c1;
				}
				goto IL_00f6;
				IL_00c1:
				switch (num6)
				{
				case 2:
					goto end_IL_00a8;
				case 1:
					goto end_IL_00a8;
				}
				goto IL_00f6;
				IL_00f6:
				enumerator.Dispose();
				num6 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
				{
					num6 = 0;
				}
				goto IL_00c1;
				end_IL_00a8:;
			}
		}
	}

	private void AddingItem(object sender, EventedListEventArgs<ToolbarItem> listViewItemEventArgs)
	{
		listViewItemEventArgs.Item.OnAdding(this);
	}

	private void AddedItem(object sender, EventedListEventArgs<ToolbarItem> listViewItemEventArgs)
	{
		listViewItemEventArgs.Item.OnAdded(this);
	}

	private void RemovingItem(object sender, EventedListEventArgs<ToolbarItem> listViewItemEventArgs)
	{
		listViewItemEventArgs.Item.OnRemoving(this);
	}

	private void RemovedItem(object sender, EventedListEventArgs<ToolbarItem> listViewItemEventArgs)
	{
		listViewItemEventArgs.Item.OnRemoved(this);
	}

	public override void OnAdding(RootToolbarItem parent)
	{
		//Discarded unreachable code: IL_007b, IL_008a, IL_0095, IL_0122, IL_015a, IL_0169
		int num = 1;
		int num2 = num;
		IEnumerator<ToolbarItem> enumerator = default(IEnumerator<ToolbarItem>);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			default:
				enumerator = Items.GetEnumerator();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
				{
					num2 = 3;
				}
				break;
			case 1:
				base.OnAdding(parent);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
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
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
							{
								num3 = 2;
							}
							goto IL_0099;
						}
						goto IL_00af;
						IL_00af:
						DUlPOfotyMeeHnmpqa0a(enumerator.Current, parent);
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
						{
							num3 = 0;
						}
						goto IL_0099;
						IL_0099:
						switch (num3)
						{
						case 2:
							return;
						case 1:
							break;
						default:
							continue;
						}
						goto IL_00af;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
						{
							num4 = 1;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								spOtaNot0ivGWmOhYhfY(enumerator);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
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
	}

	public override void OnAdded(RootToolbarItem parent)
	{
		//Discarded unreachable code: IL_0033, IL_003d, IL_00ca, IL_00e9, IL_00f8, IL_0125, IL_0134
		int num = 2;
		int num2 = num;
		IEnumerator<ToolbarItem> enumerator = default(IEnumerator<ToolbarItem>);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
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
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
							{
								num3 = 1;
							}
							goto IL_0041;
						}
						goto IL_0057;
						IL_0057:
						BPwKAfotMbe5NJU2X3uQ(enumerator.Current, parent);
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
						{
							num3 = 0;
						}
						goto IL_0041;
						IL_0041:
						switch (num3)
						{
						case 1:
							return;
						case 2:
							break;
						default:
							continue;
						}
						goto IL_0057;
					}
				}
				finally
				{
					int num4;
					if (enumerator == null)
					{
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
						{
							num4 = 2;
						}
						goto IL_00ce;
					}
					goto IL_0103;
					IL_0103:
					enumerator.Dispose();
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
					{
						num4 = 0;
					}
					goto IL_00ce;
					IL_00ce:
					switch (num4)
					{
					default:
						goto end_IL_00a9;
					case 2:
						goto end_IL_00a9;
					case 1:
						break;
					case 0:
						goto end_IL_00a9;
					}
					goto IL_0103;
					end_IL_00a9:;
				}
			case 2:
				base.OnAdded(parent);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				enumerator = Items.GetEnumerator();
				num2 = 3;
				break;
			}
		}
	}

	public override void OnRemoving(RootToolbarItem parent)
	{
		//Discarded unreachable code: IL_0059, IL_0063, IL_00f0, IL_0128, IL_0137
		int num = 3;
		int num2 = num;
		IEnumerator<ToolbarItem> enumerator = default(IEnumerator<ToolbarItem>);
		while (true)
		{
			switch (num2)
			{
			case 3:
				enumerator = Items.GetEnumerator();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
				{
					num2 = 2;
				}
				continue;
			case 2:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
							{
								num3 = 0;
							}
							goto IL_0067;
						}
						goto IL_007d;
						IL_007d:
						uRkeQBotx1CKR9vvnxeJ(enumerator.Current, parent);
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
						{
							num3 = 1;
						}
						goto IL_0067;
						IL_0067:
						switch (num3)
						{
						case 2:
							goto IL_007d;
						case 1:
							continue;
						case 0:
							break;
						}
						break;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
						{
							num4 = 1;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								enumerator.Dispose();
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
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
				break;
			case 1:
				return;
			}
			base.OnRemoving(parent);
			num2 = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
			{
				num2 = 1;
			}
		}
	}

	public override void OnRemoved(RootToolbarItem parent)
	{
		//Discarded unreachable code: IL_0048, IL_0057, IL_0062, IL_00cf, IL_00ee, IL_00fd, IL_012a, IL_0139
		int num = 1;
		IEnumerator<ToolbarItem> enumerator = default(IEnumerator<ToolbarItem>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					break;
				case 3:
					return;
				default:
					try
					{
						while (true)
						{
							int num3;
							if (!DTEJvQotJQvYQ9jSvRte(enumerator))
							{
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
								{
									num3 = 0;
								}
								goto IL_0066;
							}
							goto IL_007c;
							IL_007c:
							dTgjlZotmWryBfwDUQ33(enumerator.Current, parent);
							num3 = 2;
							goto IL_0066;
							IL_0066:
							switch (num3)
							{
							case 2:
								continue;
							case 1:
								goto end_IL_0093;
							}
							goto IL_007c;
							continue;
							end_IL_0093:
							break;
						}
					}
					finally
					{
						int num4;
						if (enumerator == null)
						{
							num4 = 2;
							goto IL_00d3;
						}
						goto IL_0108;
						IL_00d3:
						switch (num4)
						{
						default:
							goto end_IL_00be;
						case 2:
							goto end_IL_00be;
						case 1:
							break;
						case 0:
							goto end_IL_00be;
						}
						goto IL_0108;
						IL_0108:
						spOtaNot0ivGWmOhYhfY(enumerator);
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
						{
							num4 = 0;
						}
						goto IL_00d3;
						end_IL_00be:;
					}
					break;
				case 1:
					enumerator = Items.GetEnumerator();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			base.OnRemoved(parent);
			num = 3;
		}
	}

	public RootToolbarItem CreateCopy()
	{
		int num = 2;
		int num2 = num;
		ToolbarItemList toolbarItemList = default(ToolbarItemList);
		while (true)
		{
			switch (num2)
			{
			case 1:
				items = null;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				toolbarItemList = items;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
				{
					num2 = 1;
				}
				break;
			default:
			{
				RootToolbarItem result = ClassSerializationHelper.CloneObjectByXml(this);
				items = toolbarItemList;
				return result;
			}
			}
		}
	}

	public IEnumerable<ToolbarItem> GetAllItems(bool ignoreHide = true)
	{
		return FindItems(this, ignoreHide, null, null);
	}

	private static IEnumerable<ToolbarItem> FindItems(object toolbarItem, bool ignoreHide, Func<ToolbarItem, bool> itemCondition, Func<ToolbarItem, bool> deepCondition)
	{
		_003C_003Ec__DisplayClass18_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass18_0();
		CS_0024_003C_003E8__locals0.ignoreHide = ignoreHide;
		CS_0024_003C_003E8__locals0.itemCondition = itemCondition;
		CS_0024_003C_003E8__locals0.deepCondition = deepCondition;
		if (!(toolbarItem is RootToolbarItem rootToolbarItem))
		{
			return new ToolbarItem[0];
		}
		return rootToolbarItem.Items.Where(delegate(ToolbarItem item)
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return _003C_003Ec__DisplayClass18_0.W25WQeCZeVyV500JBtq6(item);
				case 1:
					if (!CS_0024_003C_003E8__locals0.ignoreHide)
					{
						return true;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}).SelectMany(delegate(ToolbarItem item)
		{
			CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass18_1();
			CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1 = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.item = item;
			return Enumerable.Empty<ToolbarItem>().If(CS_0024_003C_003E8__locals0.itemCondition == null || CS_0024_003C_003E8__locals0.itemCondition(CS_0024_003C_003E8__locals0.item), (IEnumerable<ToolbarItem> enumerable) => enumerable.Concat(new ToolbarItem[1] { CS_0024_003C_003E8__locals0.item })).If(CS_0024_003C_003E8__locals0.deepCondition == null || CS_0024_003C_003E8__locals0.deepCondition(CS_0024_003C_003E8__locals0.item), (IEnumerable<ToolbarItem> enumerable) => enumerable.Concat(FindItems(CS_0024_003C_003E8__locals0.item, CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.ignoreHide, CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.itemCondition, CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.deepCondition)));
		});
	}

	internal static void r263lwotAKkJ5gQ4OkSy()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool hY06kBot6a8oLP6kPLUl()
	{
		return dl1MMNot4SKiEoVh8TrE == null;
	}

	internal static RootToolbarItem kZvdOkotHt352hop6jYW()
	{
		return dl1MMNot4SKiEoVh8TrE;
	}

	internal static void JHX4Jbot7SKTjIEi3QUn(object P_0)
	{
		P_0.Finalize();
	}

	internal static void uRkeQBotx1CKR9vvnxeJ(object P_0, object P_1)
	{
		((ToolbarItem)P_0).OnRemoving((RootToolbarItem)P_1);
	}

	internal static void spOtaNot0ivGWmOhYhfY(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void dTgjlZotmWryBfwDUQ33(object P_0, object P_1)
	{
		((ToolbarItem)P_0).OnRemoved((RootToolbarItem)P_1);
	}

	internal static void DUlPOfotyMeeHnmpqa0a(object P_0, object P_1)
	{
		((ToolbarItem)P_0).OnAdding((RootToolbarItem)P_1);
	}

	internal static void BPwKAfotMbe5NJU2X3uQ(object P_0, object P_1)
	{
		((ToolbarItem)P_0).OnAdded((RootToolbarItem)P_1);
	}

	internal static bool DTEJvQotJQvYQ9jSvRte(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}
}
