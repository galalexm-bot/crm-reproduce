using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.UI.Services.FindComponent;

internal sealed class ComponentGraph
{
	internal class Vertex
	{
		private static Vertex E7x7UhQWNbk6byR2aP1Q;

		internal Guid HeaderUid { get; }

		internal Guid ItemUid { get; }

		internal Guid ModuleUid { get; }

		internal bool Async
		{
			[CompilerGenerated]
			get
			{
				return _003CAsync_003Ek__BackingField;
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
						_003CAsync_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
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

		internal HashSet<Guid> Owners { get; }

		internal HashSet<string> ViewItemUidList { get; }

		internal Vertex(Guid headerUid, Guid itemUid, Guid moduleUid, bool async)
		{
			//Discarded unreachable code: IL_002a, IL_002f
			ae20kDQWaTpH6MeaG4cw();
			base._002Ector();
			int num = 4;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
			{
				num = 2;
			}
			while (true)
			{
				switch (num)
				{
				case 3:
					ItemUid = itemUid;
					num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
					{
						num = 0;
					}
					break;
				case 2:
					return;
				case 4:
					HeaderUid = headerUid;
					num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
					{
						num = 3;
					}
					break;
				default:
					Async = async;
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
					{
						num = 5;
					}
					break;
				case 6:
					ViewItemUidList = new HashSet<string>();
					num = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
					{
						num = 2;
					}
					break;
				case 1:
					ModuleUid = moduleUid;
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
					{
						num = 0;
					}
					break;
				case 5:
					Owners = new HashSet<Guid>();
					num = 6;
					break;
				}
			}
		}

		internal static void ae20kDQWaTpH6MeaG4cw()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool M4gGE2QW36G6f5heeeOC()
		{
			return E7x7UhQWNbk6byR2aP1Q == null;
		}

		internal static Vertex RZxMSxQWp6lc6uDmZfZT()
		{
			return E7x7UhQWNbk6byR2aP1Q;
		}
	}

	private readonly Dictionary<Guid, Vertex> vertices;

	private static ComponentGraph jm5dxeBBBefFsXqgPk6w;

	internal ComponentGraph()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			vertices = new Dictionary<Guid, Vertex>();
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
			{
				num = 1;
			}
		}
	}

	internal void Clear()
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
				tCG64fBBb2sduDh2w84v(vertices);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal Vertex AddHeadVertex(Guid headerUid, Guid itemUid, Guid moduleUid, bool async)
	{
		return AddVertex(headerUid, itemUid, moduleUid, Guid.Empty, null, Guid.Empty, async);
	}

	internal Vertex AddVertex(Guid headerUid, Guid itemUid, Guid moduleUid, Guid parent, string renderUid, Guid owner, bool async)
	{
		//Discarded unreachable code: IL_017c
		int num = 11;
		Vertex value = default(Vertex);
		Vertex vertex = default(Vertex);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					if (Uqep2sBBG1Npxvgft2WR(owner, Guid.Empty))
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 9;
				case 8:
					p8C8HGBBfKnhbYtB6SFQ(value, false);
					num2 = 12;
					continue;
				case 3:
					if (value.Async != async)
					{
						num2 = 8;
						continue;
					}
					goto end_IL_0012;
				case 9:
					OT7EKiBBQbY2Uemu2pMZ(parent, Guid.Empty);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
					{
						num2 = 0;
					}
					continue;
				case 6:
					value = vertex;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
					{
						num2 = 0;
					}
					continue;
				case 12:
					goto end_IL_0012;
				case 1:
				case 10:
					if (!BdG6BkBBhyOZphEYdHFE(renderUid))
					{
						num2 = 2;
						continue;
					}
					goto case 5;
				case 11:
					if (vertices.TryGetValue(itemUid, out value))
					{
						num2 = 10;
						continue;
					}
					break;
				case 2:
					value.ViewItemUidList.Add(renderUid);
					num2 = 5;
					continue;
				default:
					return value;
				case 4:
					if (!JfC6fRBBEOLn0V9caqvB(vertices[owner]))
					{
						num2 = 3;
						continue;
					}
					goto end_IL_0012;
				case 7:
					break;
				}
				vertex = (vertices[itemUid] = new Vertex(headerUid, itemUid, moduleUid, async));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
				{
					num2 = 6;
				}
				continue;
				end_IL_0012:
				break;
			}
			value.Owners.Add(owner);
			num = 9;
		}
	}

	internal static bool pK2SYdBBWakhZl6GUwb1()
	{
		return jm5dxeBBBefFsXqgPk6w == null;
	}

	internal static ComponentGraph re0AixBBo0XLDoLT1kHa()
	{
		return jm5dxeBBBefFsXqgPk6w;
	}

	internal static void tCG64fBBb2sduDh2w84v(object P_0)
	{
		((Dictionary<Guid, Vertex>)P_0).Clear();
	}

	internal static bool BdG6BkBBhyOZphEYdHFE(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static bool Uqep2sBBG1Npxvgft2WR(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static bool JfC6fRBBEOLn0V9caqvB(object P_0)
	{
		return ((Vertex)P_0).Async;
	}

	internal static void p8C8HGBBfKnhbYtB6SFQ(object P_0, bool value)
	{
		((Vertex)P_0).Async = value;
	}

	internal static bool OT7EKiBBQbY2Uemu2pMZ(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}
}
