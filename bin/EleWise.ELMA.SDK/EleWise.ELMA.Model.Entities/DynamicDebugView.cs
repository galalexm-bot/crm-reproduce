using System;
using System.Diagnostics;
using System.Linq;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Security;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Entities;

internal class DynamicDebugView
{
	private class EntityContainer
	{
		private static object XxyayXCsNsW3vDcoFj5s;

		public object Id { get; }

		public EntityContainer(IEntity entity)
		{
			//Discarded unreachable code: IL_002a, IL_002f
			Y9ddZUCsaElZ5nIZ0fcC();
			base._002Ector();
			int num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
			{
				num = 0;
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
					Id = entity.GetId();
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
					{
						num = 0;
					}
					break;
				}
			}
		}

		internal static void Y9ddZUCsaElZ5nIZ0fcC()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool aO9thhCs3AeSWTWV2Qc8()
		{
			return XxyayXCsNsW3vDcoFj5s == null;
		}

		internal static EntityContainer tqPygvCspRaloB6x9Mpt()
		{
			return (EntityContainer)XxyayXCsNsW3vDcoFj5s;
		}
	}

	private class FilterContainer : IEntityFilter
	{
		private readonly object filter;

		internal static object MUxkMuCsDUhwZ2TUhh2N;

		public string SearchString
		{
			get
			{
				return ((IEntityFilter)filter).SearchString;
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
						QN83PXCs6YxA3N1wrh6x(filter, value);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public Type Subtype
		{
			get
			{
				return ((IEntityFilter)filter).Subtype;
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
						d4HKsfCsH1foqBYvXYoE(filter, value);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public Guid? PermissionId
		{
			get
			{
				return ((IEntityFilter)filter).PermissionId;
			}
			set
			{
				((IEntityFilter)filter).PermissionId = value;
			}
		}

		public IUser PermissionUser
		{
			get
			{
				return (IUser)lbjl64CsATikw3OV4Hiw(filter);
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
						RQoY8uCs7J9LnZJEZD2n(filter, value);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public bool DisableSecurity
		{
			get
			{
				return rqpojaCsxHvVHIZ2shaE(filter);
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
						((IEntityFilter)filter).DisableSecurity = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public bool DisableSoftDeletable
		{
			get
			{
				return IGUTX4Cs0pONEckhNRIN(filter);
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
						lCXVAHCsmkX4WkAMlvDe(filter, value);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public bool SkipAdminPermission
		{
			get
			{
				return sMmcs9Csy38f6307lIjn(filter);
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
						NvafAnCsMkJQ7Od7roI3(filter, value);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
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

		public object Id
		{
			get
			{
				return dHDoDCCsJnGGekafBfsD(filter);
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
						baSSySCs92EBGho3nI0c(filter, value);
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

		public object HierarchyParent
		{
			get
			{
				return zUDs6qCsdqOC2MYtjWwa(filter);
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
						o5WkM3CslMI4utVYnKqm(filter, value);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
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

		public bool FilterByHierarchyParent
		{
			get
			{
				return gnkhOBCsrZH0aQBx3mJL(filter);
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
						((IEntityFilter)filter).FilterByHierarchyParent = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
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

		public bool DisableAutoFilter
		{
			get
			{
				return o0T7hICsgpxaXWvaNMUf(filter);
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
						QM6isxCs51NXprEP6UrZ(filter, value);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public bool ShowOnlyGroups
		{
			get
			{
				return ((IEntityFilter)filter).ShowOnlyGroups;
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
						Oo9Oa1CsjDAtSrBf7V52(filter, value);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public bool FullTextInAttachments
		{
			get
			{
				return dJPbc4CsYX0qrAHQscch(filter);
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
						qCKx9fCsL8hbUa0X7qPN(filter, value);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
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

		public string Query
		{
			get
			{
				return (string)CWmVlZCsUT53PGbGWAej(filter);
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
						BykLmiCssq8pNRHSb1QR(filter, value);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public QueryParameters QueryParameters => (QueryParameters)mPvfsECscsyvnRV0Rsgf(filter);

		public FilterContainer(IEntityFilter filter)
		{
			//Discarded unreachable code: IL_002a, IL_002f
			LiEtnRCs4eRy1rMXfJR8();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
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
					this.filter = filter;
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
					{
						num = 0;
					}
					break;
				}
			}
		}

		bool IEntityFilter.IsEmpty()
		{
			throw new NotImplementedException();
		}

		internal static void LiEtnRCs4eRy1rMXfJR8()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool uVXK4WCstlTOi4bWVF9i()
		{
			return MUxkMuCsDUhwZ2TUhh2N == null;
		}

		internal static FilterContainer FD4dm6Cswq9KmWtR8pHA()
		{
			return (FilterContainer)MUxkMuCsDUhwZ2TUhh2N;
		}

		internal static void QN83PXCs6YxA3N1wrh6x(object P_0, object P_1)
		{
			((IEntityFilter)P_0).SearchString = (string)P_1;
		}

		internal static void d4HKsfCsH1foqBYvXYoE(object P_0, Type value)
		{
			((IEntityFilter)P_0).Subtype = value;
		}

		internal static object lbjl64CsATikw3OV4Hiw(object P_0)
		{
			return ((IEntityFilter)P_0).PermissionUser;
		}

		internal static void RQoY8uCs7J9LnZJEZD2n(object P_0, object P_1)
		{
			((IEntityFilter)P_0).PermissionUser = (IUser)P_1;
		}

		internal static bool rqpojaCsxHvVHIZ2shaE(object P_0)
		{
			return ((IEntityFilter)P_0).DisableSecurity;
		}

		internal static bool IGUTX4Cs0pONEckhNRIN(object P_0)
		{
			return ((IEntityFilter)P_0).DisableSoftDeletable;
		}

		internal static void lCXVAHCsmkX4WkAMlvDe(object P_0, bool value)
		{
			((IEntityFilter)P_0).DisableSoftDeletable = value;
		}

		internal static bool sMmcs9Csy38f6307lIjn(object P_0)
		{
			return ((IEntityFilter)P_0).SkipAdminPermission;
		}

		internal static void NvafAnCsMkJQ7Od7roI3(object P_0, bool value)
		{
			((IEntityFilter)P_0).SkipAdminPermission = value;
		}

		internal static object dHDoDCCsJnGGekafBfsD(object P_0)
		{
			return ((IEntityFilter)P_0).Id;
		}

		internal static void baSSySCs92EBGho3nI0c(object P_0, object P_1)
		{
			((IEntityFilter)P_0).Id = P_1;
		}

		internal static object zUDs6qCsdqOC2MYtjWwa(object P_0)
		{
			return ((IEntityFilter)P_0).HierarchyParent;
		}

		internal static void o5WkM3CslMI4utVYnKqm(object P_0, object P_1)
		{
			((IEntityFilter)P_0).HierarchyParent = P_1;
		}

		internal static bool gnkhOBCsrZH0aQBx3mJL(object P_0)
		{
			return ((IEntityFilter)P_0).FilterByHierarchyParent;
		}

		internal static bool o0T7hICsgpxaXWvaNMUf(object P_0)
		{
			return ((IEntityFilter)P_0).DisableAutoFilter;
		}

		internal static void QM6isxCs51NXprEP6UrZ(object P_0, bool value)
		{
			((IEntityFilter)P_0).DisableAutoFilter = value;
		}

		internal static void Oo9Oa1CsjDAtSrBf7V52(object P_0, bool value)
		{
			((IEntityFilter)P_0).ShowOnlyGroups = value;
		}

		internal static bool dJPbc4CsYX0qrAHQscch(object P_0)
		{
			return ((IEntityFilter)P_0).FullTextInAttachments;
		}

		internal static void qCKx9fCsL8hbUa0X7qPN(object P_0, bool value)
		{
			((IEntityFilter)P_0).FullTextInAttachments = value;
		}

		internal static object CWmVlZCsUT53PGbGWAej(object P_0)
		{
			return ((IEntityFilter)P_0).Query;
		}

		internal static void BykLmiCssq8pNRHSb1QR(object P_0, object P_1)
		{
			((IEntityFilter)P_0).Query = (string)P_1;
		}

		internal static object mPvfsECscsyvnRV0Rsgf(object P_0)
		{
			return ((IEntityFilter)P_0).QueryParameters;
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
	public readonly object data0;

	[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
	public readonly object data1;

	[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
	public readonly object data2;

	[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
	public readonly object data3;

	[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
	public readonly object data4;

	[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
	public readonly object data5;

	[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
	public readonly object data6;

	[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
	public readonly object data7;

	[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
	public readonly object data8;

	[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
	public readonly object data9;

	[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
	public readonly object data10;

	private static DynamicDebugView X2STtbh829ppvgyYgWK2;

	public DynamicDebugView(IValueContainerObjectInternal valueContainer)
	{
		//Discarded unreachable code: IL_001e, IL_00d1, IL_00e0, IL_0131, IL_0140
		iah2p7h81NaxMNd763b9();
		base._002Ector();
		int num = 3;
		int num2 = num;
		IEntityFilter filter = default(IEntityFilter);
		IEntity entity = default(IEntity);
		while (true)
		{
			switch (num2)
			{
			case 2:
				data0 = new FilterContainer(filter);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
				{
					num2 = 0;
				}
				continue;
			case 1:
				data0 = new EntityContainer(entity);
				num2 = 5;
				continue;
			case 4:
				return;
			case 3:
				if ((entity = valueContainer as IEntity) == null)
				{
					num2 = 6;
					continue;
				}
				goto case 1;
			case 5:
			case 6:
				if ((filter = valueContainer as IEntityFilter) == null)
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
					{
						num2 = 7;
					}
					continue;
				}
				goto case 2;
			}
			valueContainer.GetData().Reverse().Take(10)
				.ForEach(delegate(object d, int i)
				{
					int num3 = 1;
					int num4 = num3;
					while (true)
					{
						switch (num4)
						{
						default:
							return;
						case 1:
							YjOmp9h8Ng7rePtUJO8X(typeof(DynamicDebugView).TypeHandle).GetField((string)jAT5y3h8pSK5ZMV035EI(H4AltWh83nGEOxePmXUr(-1870892489 ^ -1870712705), i + 1)).SetValue(this, d);
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
							{
								num4 = 0;
							}
							break;
						case 0:
							return;
						}
					}
				});
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
			{
				num2 = 4;
			}
		}
	}

	internal static void iah2p7h81NaxMNd763b9()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool QgcSHlh8e4qABvWLcd5w()
	{
		return X2STtbh829ppvgyYgWK2 == null;
	}

	internal static DynamicDebugView bBKOuch8PqB7lkGJXuRw()
	{
		return X2STtbh829ppvgyYgWK2;
	}

	internal static Type YjOmp9h8Ng7rePtUJO8X(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object H4AltWh83nGEOxePmXUr(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object jAT5y3h8pSK5ZMV035EI(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}
}
