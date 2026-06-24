using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Runtime.NH.Listeners;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using Iesi.Collections.Generic;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Collection;
using NHibernate.Engine;
using NHibernate.Event;
using NHibernate.Persister.Entity;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Listeners;

[Component]
internal class SecurityCacheListener : EntityEventsListener
{
	internal class UpdateFlag
	{
		public static readonly UpdateFlag True;

		public static readonly UpdateFlag False;

		internal static UpdateFlag QomvaWpNugcTtIhRHnEM;

		public bool Enabled
		{
			[CompilerGenerated]
			get
			{
				return _003CEnabled_003Ek__BackingField;
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
						_003CEnabled_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a3a30dc594d64d20b0419bc3debf22fd == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public UpdateFlag(bool enabled)
		{
			//Discarded unreachable code: IL_002a, IL_002f
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_bcafdad7ca04437ebcc767622a0f9af3 == 0)
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
				Enabled = enabled;
				num = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e4840b3cf8a94577862fdc527af9db29 == 0)
				{
					num = 0;
				}
			}
		}

		static UpdateFlag()
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
					j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_df5466d729844e8ea757565832a01037 == 0)
					{
						num2 = 1;
					}
					break;
				case 0:
					return;
				case 1:
					True = new UpdateFlag(enabled: true);
					num2 = 3;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_66aae9daa3f84bb5931ed90b4759f85c == 0)
					{
						num2 = 2;
					}
					break;
				case 3:
					False = new UpdateFlag(enabled: false);
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_417fa9f431a6421fac341b81e122e2e7 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		internal static bool RUkRvCpNme6xX8rUS9RB()
		{
			return QomvaWpNugcTtIhRHnEM == null;
		}

		internal static UpdateFlag KRAoFOpNeYbow4hCF6n0()
		{
			return QomvaWpNugcTtIhRHnEM;
		}
	}

	internal const string needOldUpdateKey = "EleWise.ELMA.Security.SecurityCacheListener.Old.key";

	internal const string needUpdateKey = "EleWise.ELMA.Security.SecurityCacheListener.key";

	internal const string needUpdateUserKey = "EleWise.ELMA.Security.SecurityCacheListener.Users.key";

	internal const string needUpdateGroupKey = "EleWise.ELMA.Security.SecurityCacheListener.Groups.key";

	internal const string needUpdateOrganizationItemKey = "EleWise.ELMA.Security.SecurityCacheListener.OrganizationItems.key";

	private readonly IContextBoundVariableService contextBoundVariableService;

	internal static SecurityCacheListener cEkBiradcdMh5ZfcvYo;

	private IInternalSecurityService InternalSecurityService => (IInternalSecurityService)finDZkarntvxIKEgxrW((ILicensedModuleAssembly)((ComponentManager)IisgYXa8wZP47HIDbKi()).ModuleManager.FindUnitByUid(__AssemblyInfo.UID));

	public SecurityCacheListener(IContextBoundVariableService contextBoundVariableService)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		PLirEda3eW7tIgq7Ee2();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6f96338790994363b52cd5c55eb1342f == 0)
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
			this.contextBoundVariableService = contextBoundVariableService;
			num = 1;
			if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c78060c4cac8419092e4610bf7a03750 != 0)
			{
				num = 1;
			}
		}
	}

	public override bool OnPreInsert(PreInsertEvent @event)
	{
		int num = 5;
		int num2 = num;
		IUserGroup userGroup = default(IUserGroup);
		while (true)
		{
			switch (num2)
			{
			case 4:
				if (userGroup != null)
				{
					num2 = 2;
					break;
				}
				goto default;
			default:
				return fGbC7QaypHsl6nwgPIX(this, @event);
			case 5:
				userGroup = ((AbstractPreDatabaseOperationEvent)@event).get_Entity() as IUserGroup;
				num2 = 4;
				break;
			case 2:
				Process(userGroup, (IUserGroup u) => u.OrganizationItems, delegate(IUserGroup u, string v)
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
							u.OrganizationItemsHash = v;
							num4 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5ae6a44bd52345c5bcadd62b7063c7d9 != 0)
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
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3fde536d235f4cd390062db7c7cf1219 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				Process(userGroup, (IUserGroup u) => u.Users, delegate(IUserGroup u, string v)
				{
					int num5 = 1;
					int num6 = num5;
					while (true)
					{
						switch (num6)
						{
						default:
							return;
						case 1:
							_003C_003Ec.sYtnfepNRmGHqybbfVjp(u, v);
							num6 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8fd69cd0bea1432ca401d29377c613cc == 0)
							{
								num6 = 0;
							}
							break;
						case 0:
							return;
						}
					}
				});
				num2 = 3;
				break;
			case 3:
				Process(userGroup, (IUserGroup u) => u.Groups, delegate(IUserGroup u, string v)
				{
					int num7 = 1;
					int num8 = num7;
					while (true)
					{
						switch (num8)
						{
						default:
							return;
						case 1:
							_003C_003Ec.Dm2pIOpNwxlZ4P5I6jk5(u, v);
							num8 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_417fa9f431a6421fac341b81e122e2e7 == 0)
							{
								num8 = 0;
							}
							break;
						case 0:
							return;
						}
					}
				});
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8176869ecaf44a0b8819db51e9ec5eb4 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override bool OnPreUpdate(PreUpdateEvent @event)
	{
		//Discarded unreachable code: IL_00db, IL_00ea, IL_015d, IL_017e, IL_018d, IL_01b7, IL_01c6, IL_020f, IL_0274
		int num = 20;
		EleWise.ELMA.Security.Models.IUser user = default(EleWise.ELMA.Security.Models.IUser);
		int num3 = default(int);
		EleWise.ELMA.Security.Models.IUser user2 = default(EleWise.ELMA.Security.Models.IUser);
		IOrganizationItem organizationItem = default(IOrganizationItem);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				int num4;
				switch (num2)
				{
				case 1:
				case 9:
					if (user == null)
					{
						num2 = 10;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7ced317202a44233ac3d0deafcdd1923 == 0)
						{
							num2 = 10;
						}
						continue;
					}
					goto case 6;
				case 21:
					if (num3 >= 0)
					{
						num2 = 10;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_66aae9daa3f84bb5931ed90b4759f85c != 0)
						{
							num2 = 11;
						}
						continue;
					}
					goto case 13;
				case 15:
					((IEnumerable<IOrganizationItem>)user.OrganizationItems).FirstOrDefault();
					num2 = 22;
					continue;
				case 12:
					if (user2 == null)
					{
						num = 9;
						break;
					}
					goto default;
				case 8:
					PUisxga1LdplIHlT0mf(user2);
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1e79fb186de547eaaa37d66745fc7b90 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					if (!user2.OrganizationItems.IsInitialized<IOrganizationItem>())
					{
						num2 = 16;
						continue;
					}
					goto case 5;
				case 19:
					if (organizationItem == null)
					{
						num2 = 18;
						continue;
					}
					goto case 17;
				case 13:
					obj = null;
					goto IL_02cc;
				case 20:
					organizationItem = tvAjxEab2uufeSRT6uN(@event) as IOrganizationItem;
					num2 = 19;
					continue;
				default:
					if (user2 != user)
					{
						num2 = 2;
						continue;
					}
					goto case 1;
				case 3:
				case 10:
				case 18:
					return base.OnPreUpdate(@event);
				case 17:
					if (@event.get_OldState() == null)
					{
						num = 14;
						break;
					}
					goto case 4;
				case 4:
					num4 = Array.IndexOf((string[])c8n0naaSqQmXTYNAtXK(((AbstractPreDatabaseOperationEvent)@event).get_Persister()), (string)zirDGba9hYgr7wjQ594(-225736894 ^ -225736546));
					goto IL_02a2;
				case 16:
					((IEnumerable<IOrganizationItem>)user2.OrganizationItems).FirstOrDefault();
					num2 = 5;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_963eedaf34ef4c6cb3f0798bae513387 != 0)
					{
						num2 = 5;
					}
					continue;
				case 23:
					user = organizationItem.User;
					num2 = 12;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0ab7ce9a6369414380df24a533da8346 == 0)
					{
						num2 = 3;
					}
					continue;
				case 7:
					PUisxga1LdplIHlT0mf(user);
					num2 = 3;
					continue;
				case 6:
					if (!user.OrganizationItems.IsInitialized<IOrganizationItem>())
					{
						num = 15;
						break;
					}
					goto case 22;
				case 14:
					num4 = -1;
					goto IL_02a2;
				case 11:
					obj = (EleWise.ELMA.Security.Models.IUser)((object[])NDTpy6afungcYv4TFj8(@event))[num3];
					goto IL_02cc;
				case 5:
					ProcessRemove(user2, organizationItem, (EleWise.ELMA.Security.Models.IUser u) => u.OrganizationItems, delegate(EleWise.ELMA.Security.Models.IUser u, string v)
					{
						int num7 = 1;
						int num8 = num7;
						while (true)
						{
							switch (num8)
							{
							default:
								return;
							case 1:
								_003C_003Ec.slNX7IpN2Cuqd3HGdJiA(u, v);
								num8 = 0;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_364662b38d3b4bdb9f3f1f11b8889cdc != 0)
								{
									num8 = 0;
								}
								break;
							case 0:
								return;
							}
						}
					});
					num2 = 8;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_9a38cebc63824d86b02d76fd37722379 != 0)
					{
						num2 = 6;
					}
					continue;
				case 22:
					{
						ProcessAdd(user, organizationItem, (EleWise.ELMA.Security.Models.IUser u) => u.OrganizationItems, delegate(EleWise.ELMA.Security.Models.IUser u, string v)
						{
							int num5 = 1;
							int num6 = num5;
							while (true)
							{
								switch (num6)
								{
								default:
									return;
								case 1:
									u.OrganizationItemsHash = v;
									num6 = 0;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0a82cc1379bc48bbb836c94da8cb8564 == 0)
									{
										num6 = 0;
									}
									break;
								case 0:
									return;
								}
							}
						});
						num2 = 7;
						continue;
					}
					IL_02a2:
					num3 = num4;
					num2 = 10;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_417fa9f431a6421fac341b81e122e2e7 == 0)
					{
						num2 = 21;
					}
					continue;
					IL_02cc:
					user2 = (EleWise.ELMA.Security.Models.IUser)obj;
					num2 = 23;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2df53c26a6094060a56f82d6cf94e7da != 0)
					{
						num2 = 4;
					}
					continue;
				}
				break;
			}
		}
	}

	public override void OnPreUpdateCollection(PreCollectionUpdateEvent @event)
	{
		//Discarded unreachable code: IL_0186, IL_0195, IL_01a4, IL_01c1, IL_0239, IL_0306, IL_038a, IL_03ba, IL_03c9, IL_0518, IL_0596, IL_0607, IL_06d1, IL_0724, IL_0750, IL_075f, IL_07d5, IL_0865
		int num = 56;
		int num3 = default(int);
		_003C_003Ec__DisplayClass12_0 _003C_003Ec__DisplayClass12_ = default(_003C_003Ec__DisplayClass12_0);
		IOrganizationItem organizationItem2 = default(IOrganizationItem);
		int num4 = default(int);
		EleWise.ELMA.Security.Models.IUser[] array3 = default(EleWise.ELMA.Security.Models.IUser[]);
		object[] array = default(object[]);
		IOrganizationItem organizationItem = default(IOrganizationItem);
		_003C_003Ec__DisplayClass12_1 _003C_003Ec__DisplayClass12_2 = default(_003C_003Ec__DisplayClass12_1);
		CollectionEntry val = default(CollectionEntry);
		_003C_003Ec__DisplayClass12_2 _003C_003Ec__DisplayClass12_3 = default(_003C_003Ec__DisplayClass12_2);
		CollectionEntry collectionEntry = default(CollectionEntry);
		object[] array4 = default(object[]);
		EleWise.ELMA.Security.Models.IUser user = default(EleWise.ELMA.Security.Models.IUser);
		object[] array5 = default(object[]);
		EleWise.ELMA.Security.Models.IUser item2 = default(EleWise.ELMA.Security.Models.IUser);
		EleWise.ELMA.Security.Models.IUser user2 = default(EleWise.ELMA.Security.Models.IUser);
		IOrganizationItem[] array2 = default(IOrganizationItem[]);
		IOrganizationItem item = default(IOrganizationItem);
		object[] array6 = default(object[]);
		object[] array7 = default(object[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 78:
					num3 = 0;
					num2 = 32;
					continue;
				case 36:
					num3 = 0;
					num2 = 81;
					continue;
				case 84:
					return;
				case 64:
					if (_003C_003Ec__DisplayClass12_.user != null)
					{
						num2 = 20;
						continue;
					}
					goto case 17;
				case 16:
					num3++;
					num2 = 77;
					continue;
				case 72:
					organizationItem2.Users.Add(_003C_003Ec__DisplayClass12_.user);
					num2 = 14;
					continue;
				case 31:
				case 82:
					if (num4 < array3.Length)
					{
						num2 = 24;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6f96338790994363b52cd5c55eb1342f == 0)
						{
							num2 = 10;
						}
						continue;
					}
					goto case 76;
				case 43:
				case 81:
					if (num3 < array.Length)
					{
						num2 = 50;
						continue;
					}
					goto case 30;
				case 76:
					PUisxga1LdplIHlT0mf(organizationItem);
					num2 = 65;
					continue;
				case 8:
				case 10:
					if (num3 >= array.Length)
					{
						num = 17;
						break;
					}
					goto case 1;
				case 6:
					num3++;
					num2 = 10;
					continue;
				case 15:
				{
					IOrganizationItem obj2 = (IOrganizationItem)array[num3];
					muYFxGRnoaMNclubyyh(obj2, null);
					PUisxga1LdplIHlT0mf(obj2);
					num2 = 25;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a3a30dc594d64d20b0419bc3debf22fd != 0)
					{
						num2 = 53;
					}
					continue;
				}
				case 51:
					num4++;
					num2 = 29;
					continue;
				case 34:
					_003C_003Ec__DisplayClass12_2.oldCollection = (MdUVC1RW1mZSD8CXBVh(val) as IEnumerable).Cast<object>().ToList();
					num = 23;
					break;
				case 37:
					num3 = 0;
					num2 = 8;
					continue;
				case 35:
					_003C_003Ec__DisplayClass12_3 = new _003C_003Ec__DisplayClass12_2();
					num2 = 3;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b700f854946b45dfa4de8ce28732acad != 0)
					{
						num2 = 28;
					}
					continue;
				case 58:
					_003C_003Ec__DisplayClass12_3.oldCollection = (MdUVC1RW1mZSD8CXBVh(collectionEntry) as IEnumerable).Cast<object>().ToList();
					num2 = 19;
					continue;
				case 55:
					_003C_003Ec__DisplayClass12_.user = wd5MA1az99QHudULnMF(@event) as EleWise.ELMA.Security.Models.IUser;
					num2 = 64;
					continue;
				case 14:
				case 70:
					PUisxga1LdplIHlT0mf(organizationItem2);
					num2 = 3;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d4e4542f38914a2ba9396d8df0939ca9 != 0)
					{
						num2 = 6;
					}
					continue;
				case 77:
				case 80:
					if (num3 < array.Length)
					{
						num2 = 21;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_94a7beb9ab90455caa18ecaa3b17b19c == 0)
						{
							num2 = 21;
						}
						continue;
					}
					goto case 44;
				case 23:
					array4 = _003C_003Ec__DisplayClass12_2.oldCollection.Where(_003C_003Ec__DisplayClass12_2._003COnPreUpdateCollection_003Eb__0).ToArray();
					num2 = 11;
					continue;
				case 48:
					user.OrganizationGroups.Add(_003C_003Ec__DisplayClass12_.organizationItem);
					num2 = 61;
					continue;
				case 17:
				case 66:
					_003C_003Ec__DisplayClass12_.organizationItem = ((AbstractCollectionEvent)@event).get_AffectedOwnerOrNull() as IOrganizationItem;
					num2 = 79;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a33ec05b36714591b0adf150b655c9a8 == 0)
					{
						num2 = 11;
					}
					continue;
				case 30:
					array = array5;
					num2 = 37;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c843c5b509d748f086ceb6be01690351 != 0)
					{
						num2 = 8;
					}
					continue;
				case 27:
					num3 = 0;
					num2 = 80;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4b1278f673174e87a9fb6665eab69fc6 != 0)
					{
						num2 = 73;
					}
					continue;
				case 42:
				case 50:
					organizationItem = (IOrganizationItem)array[num3];
					num2 = 39;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6ebd2dabc54f4311bbbe57be8fcccc48 == 0)
					{
						num2 = 83;
					}
					continue;
				case 5:
					num4++;
					num2 = 19;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c08b0b4e9ab14bedb2a2c7a0048ab814 == 0)
					{
						num2 = 31;
					}
					continue;
				case 18:
				case 75:
					if (num3 >= array.Length)
					{
						num2 = 43;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0f3686d2211943308639c187009d1b4a == 0)
						{
							num2 = 46;
						}
						continue;
					}
					goto case 52;
				case 67:
					if (!((string)b8sD5RRX3IO77Jt71up(collectionEntry)).EndsWith(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x397B0322 ^ 0x397B4CF4)))
					{
						num2 = 84;
						continue;
					}
					goto case 54;
				case 20:
					_003C_003Ec__DisplayClass12_2 = new _003C_003Ec__DisplayClass12_1();
					num2 = 20;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c08b0b4e9ab14bedb2a2c7a0048ab814 == 0)
					{
						num2 = 25;
					}
					continue;
				case 26:
					num3 = 0;
					num2 = 69;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f6614d006512404f8cab65f09d3e1c89 == 0)
					{
						num2 = 35;
					}
					continue;
				case 12:
					num3 = 0;
					num2 = 75;
					continue;
				case 41:
					((ICollection<EleWise.ELMA.Security.Models.IUser>)organizationItem.Users).Remove(item2);
					num2 = 5;
					continue;
				case 52:
					user2 = (EleWise.ELMA.Security.Models.IUser)array[num3];
					num2 = 62;
					continue;
				case 79:
					if (_003C_003Ec__DisplayClass12_.organizationItem != null)
					{
						num2 = 17;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b128c216f9744fbcbc93a88cbe7b4554 == 0)
						{
							num2 = 35;
						}
						continue;
					}
					return;
				default:
					PUisxga1LdplIHlT0mf(user2);
					num2 = 9;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e4840b3cf8a94577862fdc527af9db29 != 0)
					{
						num2 = 45;
					}
					continue;
				case 29:
				case 49:
					if (num4 >= array2.Length)
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fc5e0189a7f447a7b93cd505b96d5f05 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 57;
				case 85:
					if (!((string)b8sD5RRX3IO77Jt71up(val)).EndsWith((string)zirDGba9hYgr7wjQ594(0x271B34E4 ^ 0x271B7B60)))
					{
						num2 = 63;
						continue;
					}
					goto case 73;
				case 45:
					num3++;
					num2 = 14;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5028d2018b41471c962aaca947e33b9d == 0)
					{
						num2 = 18;
					}
					continue;
				case 57:
					item = array2[num4];
					num2 = 74;
					continue;
				case 56:
					_003C_003Ec__DisplayClass12_ = new _003C_003Ec__DisplayClass12_0();
					num = 55;
					break;
				case 54:
					array = array6;
					num = 12;
					break;
				case 28:
					collectionEntry = ((IPersistenceContext)VLpOlsRpqPWvhHQdMvF(((AbstractEvent)@event).get_Session())).GetCollectionEntry((IPersistentCollection)HWCvykR5w37vKcFbJQ6(@event));
					num2 = 60;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a3a30dc594d64d20b0419bc3debf22fd == 0)
					{
						num2 = 43;
					}
					continue;
				case 47:
					num4 = 0;
					num2 = 49;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_dee60bd1c491407eb16511279f664d42 == 0)
					{
						num2 = 36;
					}
					continue;
				case 1:
					organizationItem2 = (IOrganizationItem)array[num3];
					num = 7;
					break;
				case 4:
					array7 = _003C_003Ec__DisplayClass12_3.newCollection.Where(_003C_003Ec__DisplayClass12_3._003COnPreUpdateCollection_003Eb__5).ToArray();
					num2 = 67;
					continue;
				case 25:
					val = (CollectionEntry)YIQ3TVRAT8urvJ8YHJb(VLpOlsRpqPWvhHQdMvF(UddsvJRkpNbXZ2ZAL2f(@event)), HWCvykR5w37vKcFbJQ6(@event));
					num2 = 2;
					continue;
				case 33:
				case 69:
					if (num3 >= array.Length)
					{
						num2 = 71;
						continue;
					}
					goto case 3;
				case 2:
					_003C_003Ec__DisplayClass12_2.newCollection = (((AbstractCollectionEvent)@event).get_Collection() as IEnumerable).Cast<object>().ToList();
					num2 = 34;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a3a30dc594d64d20b0419bc3debf22fd == 0)
					{
						num2 = 30;
					}
					continue;
				case 3:
					user = (EleWise.ELMA.Security.Models.IUser)array[num3];
					num2 = 39;
					continue;
				case 71:
					return;
				case 73:
					array = array4;
					num2 = 78;
					continue;
				case 61:
					PUisxga1LdplIHlT0mf(user);
					num2 = 13;
					continue;
				case 53:
					num3++;
					num = 68;
					break;
				case 44:
				case 63:
					if (!ux3tdtRirlTZ0ECJcxx(b8sD5RRX3IO77Jt71up(val), zirDGba9hYgr7wjQ594(0x2121ECF9 ^ 0x2121A355)))
					{
						num2 = 18;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e4840b3cf8a94577862fdc527af9db29 != 0)
						{
							num2 = 66;
						}
						continue;
					}
					goto case 59;
				case 38:
					num4 = 0;
					num2 = 82;
					continue;
				case 32:
				case 68:
					if (num3 >= array.Length)
					{
						num2 = 9;
						continue;
					}
					goto case 15;
				case 13:
					num3++;
					num = 33;
					break;
				case 46:
					array = array7;
					num2 = 26;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4b098d453cbc45388569889eb6ab714d == 0)
					{
						num2 = 16;
					}
					continue;
				case 59:
					array = array4;
					num2 = 36;
					continue;
				case 11:
					array5 = _003C_003Ec__DisplayClass12_2.newCollection.Where(_003C_003Ec__DisplayClass12_2._003COnPreUpdateCollection_003Eb__1).ToArray();
					num = 85;
					break;
				case 60:
					_003C_003Ec__DisplayClass12_3.newCollection = (HWCvykR5w37vKcFbJQ6(@event) as IEnumerable).Cast<object>().ToList();
					num2 = 31;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b54421a4e10b4c2fa10cef566e462fbd == 0)
					{
						num2 = 58;
					}
					continue;
				case 21:
				case 22:
				{
					IOrganizationItem obj = (IOrganizationItem)array[num3];
					muYFxGRnoaMNclubyyh(obj, _003C_003Ec__DisplayClass12_.user);
					PUisxga1LdplIHlT0mf(obj);
					num2 = 16;
					continue;
				}
				case 65:
					num3++;
					num2 = 43;
					continue;
				case 19:
					array6 = _003C_003Ec__DisplayClass12_3.oldCollection.Where(_003C_003Ec__DisplayClass12_3._003COnPreUpdateCollection_003Eb__4).ToArray();
					num2 = 4;
					continue;
				case 9:
					array = array5;
					num2 = 27;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8ec57fd3f43f4cf7983bc996ab09feb4 != 0)
					{
						num2 = 6;
					}
					continue;
				case 24:
				case 40:
					item2 = array3[num4];
					num2 = 41;
					continue;
				case 74:
					((ICollection<IOrganizationItem>)user2.OrganizationGroups).Remove(item);
					num2 = 51;
					continue;
				case 83:
					array3 = ((IEnumerable<EleWise.ELMA.Security.Models.IUser>)organizationItem.Users).Where(_003C_003Ec__DisplayClass12_._003COnPreUpdateCollection_003Eb__2).ToArray();
					num2 = 38;
					continue;
				case 7:
					if (!((IEnumerable<EleWise.ELMA.Security.Models.IUser>)organizationItem2.Users).All(_003C_003Ec__DisplayClass12_._003COnPreUpdateCollection_003Eb__3))
					{
						num2 = 2;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_05864899c47d415d8fae32c68fb25d39 == 0)
						{
							num2 = 70;
						}
						continue;
					}
					goto case 72;
				case 62:
					array2 = ((IEnumerable<IOrganizationItem>)user2.OrganizationGroups).Where(_003C_003Ec__DisplayClass12_._003COnPreUpdateCollection_003Eb__6).ToArray();
					num2 = 47;
					continue;
				case 39:
					if (((IEnumerable<IOrganizationItem>)user.OrganizationGroups).All(_003C_003Ec__DisplayClass12_._003COnPreUpdateCollection_003Eb__7))
					{
						num2 = 48;
						continue;
					}
					goto case 61;
				}
				break;
			}
		}
	}

	public override void OnPostInsert(PostInsertEvent @event)
	{
		//Discarded unreachable code: IL_0123, IL_0186, IL_0195, IL_01e6, IL_0221, IL_0242, IL_02a9
		int num = 17;
		EleWise.ELMA.Security.Models.IUser user = default(EleWise.ELMA.Security.Models.IUser);
		IUserGroup userGroup = default(IUserGroup);
		int num3 = default(int);
		IOrganizationItem organizationItem = default(IOrganizationItem);
		EleWise.ELMA.Security.Models.IUser newUser = default(EleWise.ELMA.Security.Models.IUser);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 17:
					user = WqR0bxR75EmpUT9FOOd(@event) as EleWise.ELMA.Security.Models.IUser;
					num2 = 16;
					continue;
				case 7:
				case 25:
					if (!(WqR0bxR75EmpUT9FOOd(@event) is EleWise.ELMA.Security.Models.IUser))
					{
						num2 = 3;
						continue;
					}
					goto case 20;
				case 6:
					if (adE4HPR61V5OdPnO1LL(user) != UserStatus.Blocked)
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0f3686d2211943308639c187009d1b4a == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 19;
				case 13:
				case 14:
					userGroup = WqR0bxR75EmpUT9FOOd(@event) as IUserGroup;
					num2 = 22;
					continue;
				case 1:
					return;
				case 12:
					return;
				case 18:
					if (!(WqR0bxR75EmpUT9FOOd(@event) is IOrganizationModel))
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a33ec05b36714591b0adf150b655c9a8 != 0)
						{
							num2 = 7;
						}
						continue;
					}
					goto case 4;
				case 4:
					RaiseUpdateCache();
					num2 = 25;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b496c4412b534db6beb066c8296e663d == 0)
					{
						num2 = 18;
					}
					continue;
				case 3:
					if (WqR0bxR75EmpUT9FOOd(@event) is IUserGroup)
					{
						num2 = 23;
						continue;
					}
					goto case 9;
				default:
					InternalSecurityService.CheckUserToAuthenticate(user, null, null, null);
					num2 = 19;
					continue;
				case 20:
				case 23:
					RaiseOldUpdateCache();
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b54421a4e10b4c2fa10cef566e462fbd != 0)
					{
						num2 = 0;
					}
					continue;
				case 16:
					if (user == null)
					{
						num2 = 13;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fa1b4c3a88294db7b3c25698c3f06dd7 == 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto case 6;
				case 19:
					RaiseUpdateCache(user);
					num2 = 14;
					continue;
				case 9:
					if (!(((AbstractPostDatabaseOperationEvent)@event).get_Entity() is IOrganizationItem))
					{
						num2 = 12;
						continue;
					}
					goto case 20;
				case 2:
					if (num3 >= 0)
					{
						num2 = 21;
						continue;
					}
					goto case 10;
				case 15:
					num3 = Array.IndexOf((string[])c8n0naaSqQmXTYNAtXK(DLxrXZRlSVfNEY6GTTQ(@event)), (string)zirDGba9hYgr7wjQ594(-76932334 ^ -76933938));
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_562220c988b04dea969b2dc6cde52015 == 0)
					{
						num2 = 1;
					}
					continue;
				case 5:
					if (organizationItem != null)
					{
						num = 15;
						break;
					}
					goto case 18;
				case 10:
					obj = null;
					goto IL_03d4;
				case 22:
					if (userGroup != null)
					{
						num = 11;
						break;
					}
					goto case 24;
				case 24:
					organizationItem = WqR0bxR75EmpUT9FOOd(@event) as IOrganizationItem;
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c78060c4cac8419092e4610bf7a03750 != 0)
					{
						num2 = 5;
					}
					continue;
				case 11:
					RaiseUpdateCache(userGroup, new Pair<long[], long[]>(((IEnumerable<EleWise.ELMA.Security.Models.IUser>)userGroup.Users).Select((EleWise.ELMA.Security.Models.IUser u) => u.Id).ToArray(), new long[0]), new Pair<long[], long[]>(((IEnumerable<IOrganizationItem>)userGroup.OrganizationItems).Select((IOrganizationItem oi) => oi.Id).ToArray(), new long[0]), new Pair<long[], long[]>(((IEnumerable<IUserGroup>)userGroup.Groups).Select((IUserGroup g) => g.Id).ToArray(), new long[0]));
					num2 = 18;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c08b0b4e9ab14bedb2a2c7a0048ab814 == 0)
					{
						num2 = 24;
					}
					continue;
				case 21:
					obj = (EleWise.ELMA.Security.Models.IUser)((object[])IVF0YZRNvGDZvMlYiWD(@event))[num3];
					goto IL_03d4;
				case 8:
					{
						RaiseUpdateCache(organizationItem, new Pair<long[], long[]>(((IEnumerable<EleWise.ELMA.Security.Models.IUser>)organizationItem.Users).Select((EleWise.ELMA.Security.Models.IUser u) => u.Id).ToArray(), new long[0]), null, newUser);
						num2 = 18;
						continue;
					}
					IL_03d4:
					newUser = (EleWise.ELMA.Security.Models.IUser)obj;
					num = 8;
					break;
				}
				break;
			}
		}
	}

	public override void OnPostUpdate(PostUpdateEvent @event)
	{
		//Discarded unreachable code: IL_006a, IL_00d8, IL_00e7, IL_0148, IL_02ea
		int num = 16;
		IOrganizationItem organizationItem = default(IOrganizationItem);
		EleWise.ELMA.Security.Models.IUser oldUser = default(EleWise.ELMA.Security.Models.IUser);
		EleWise.ELMA.Security.Models.IUser user = default(EleWise.ELMA.Security.Models.IUser);
		IUserGroup userGroup = default(IUserGroup);
		int num3 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				int num4;
				switch (num2)
				{
				case 13:
					obj = null;
					break;
				case 3:
				{
					IOrganizationItem organizationItem2 = organizationItem;
					ParameterExpression parameterExpression = (ParameterExpression)bDFvleRxOqZ5VQAJX7f(pbySjZRZL9f3y6Jlp8r(typeof(IOrganizationItem).TypeHandle), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1943394692 ^ -1943377520));
					RaiseUpdateCache(organizationItem2, GetChangedIds((AbstractPostDatabaseOperationEvent)(object)@event, Expression.Lambda<Func<IOrganizationItem, string>>((Expression)bFUUq3RB9nIt7iEUKLc(parameterExpression, (MethodInfo)D3n9dGRukw8UZy0UQj4((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })), oldUser, user);
					num2 = 11;
					continue;
				}
				case 11:
					if (((AbstractPostDatabaseOperationEvent)@event).get_Entity() is EleWise.ELMA.Security.Models.IUser)
					{
						num2 = 17;
						continue;
					}
					goto case 14;
				case 8:
					if (@event.get_OldState() != null)
					{
						num2 = 7;
						continue;
					}
					num4 = -1;
					goto IL_034a;
				case 12:
					return;
				case 7:
					num4 = Array.IndexOf((string[])c8n0naaSqQmXTYNAtXK(DLxrXZRlSVfNEY6GTTQ(@event)), (string)zirDGba9hYgr7wjQ594(-1615559191 ^ -1615558091));
					goto IL_034a;
				case 1:
					if (organizationItem != null)
					{
						num2 = 8;
						continue;
					}
					goto case 11;
				case 4:
				{
					IUserGroup group = userGroup;
					ParameterExpression parameterExpression = Expression.Parameter(pbySjZRZL9f3y6Jlp8r(typeof(IUserGroup).TypeHandle), (string)zirDGba9hYgr7wjQ594(0x2121ECF9 ^ 0x2121A31F));
					Pair<long[], long[]> changedIds = GetChangedIds((AbstractPostDatabaseOperationEvent)(object)@event, Expression.Lambda<Func<IUserGroup, string>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
					parameterExpression = (ParameterExpression)bDFvleRxOqZ5VQAJX7f(pbySjZRZL9f3y6Jlp8r(typeof(IUserGroup).TypeHandle), zirDGba9hYgr7wjQ594(-2068904634 ^ -2068886880));
					Pair<long[], long[]> changedIds2 = GetChangedIds((AbstractPostDatabaseOperationEvent)(object)@event, Expression.Lambda<Func<IUserGroup, string>>((Expression)bFUUq3RB9nIt7iEUKLc(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
					parameterExpression = (ParameterExpression)bDFvleRxOqZ5VQAJX7f(pbySjZRZL9f3y6Jlp8r(typeof(IUserGroup).TypeHandle), zirDGba9hYgr7wjQ594(0x46347DA6 ^ 0x46343240));
					RaiseUpdateCache(group, changedIds, changedIds2, GetChangedIds((AbstractPostDatabaseOperationEvent)(object)@event, Expression.Lambda<Func<IUserGroup, string>>(Expression.Property(parameterExpression, (MethodInfo)D3n9dGRukw8UZy0UQj4((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
					num2 = 9;
					continue;
				}
				case 16:
					goto end_IL_0012;
				case 14:
					if (WqR0bxR75EmpUT9FOOd(@event) is IUserGroup)
					{
						num2 = 6;
						continue;
					}
					goto case 10;
				case 15:
					if (userGroup != null)
					{
						num2 = 4;
						continue;
					}
					goto case 9;
				default:
					if (num3 < 0)
					{
						num2 = 13;
						continue;
					}
					obj = (EleWise.ELMA.Security.Models.IUser)((object[])gNoqvdRmbrunaEuixhJ(@event))[num3];
					break;
				case 5:
				case 6:
				case 17:
					RaiseOldUpdateCache();
					num2 = 9;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_39a415f51fd045a981443759203cc0ad == 0)
					{
						num2 = 12;
					}
					continue;
				case 2:
					user = organizationItem.User;
					num2 = 3;
					continue;
				case 9:
					organizationItem = WqR0bxR75EmpUT9FOOd(@event) as IOrganizationItem;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_39d15279765e4050b24c0f7d69df46db == 0)
					{
						num2 = 1;
					}
					continue;
				case 10:
					{
						if (!(((AbstractPostDatabaseOperationEvent)@event).get_Entity() is IOrganizationItem))
						{
							return;
						}
						num2 = 5;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_288a03909ebe4f56a0d34bfce957098b == 0)
						{
							num2 = 2;
						}
						continue;
					}
					IL_034a:
					num3 = num4;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_56bc39e908f44451b3cdd0d68828e324 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				oldUser = (EleWise.ELMA.Security.Models.IUser)obj;
				num2 = 2;
				continue;
				end_IL_0012:
				break;
			}
			userGroup = WqR0bxR75EmpUT9FOOd(@event) as IUserGroup;
			num = 15;
		}
	}

	public override void OnPostDelete(PostDeleteEvent @event)
	{
		//Discarded unreachable code: IL_0066, IL_0081, IL_00cb, IL_01a8
		int num = 8;
		IOrganizationItem organizationItem = default(IOrganizationItem);
		IUserGroup userGroup = default(IUserGroup);
		EleWise.ELMA.Security.Models.IUser oldUser = default(EleWise.ELMA.Security.Models.IUser);
		int num3 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 4:
					obj = null;
					goto IL_0337;
				case 16:
					if (organizationItem != null)
					{
						num2 = 14;
						continue;
					}
					goto case 5;
				case 5:
					if (((AbstractPostDatabaseOperationEvent)@event).get_Entity() is EleWise.ELMA.Security.Models.IUser)
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a7933e38c68f4f69b40e459b15579199 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 13;
				case 7:
					if (userGroup == null)
					{
						num2 = 15;
						continue;
					}
					goto case 10;
				case 12:
					if (WqR0bxR75EmpUT9FOOd(@event) is IOrganizationItem)
					{
						num = 11;
						break;
					}
					return;
				case 9:
				{
					IOrganizationItem organizationItem2 = organizationItem;
					ParameterExpression parameterExpression = (ParameterExpression)bDFvleRxOqZ5VQAJX7f(pbySjZRZL9f3y6Jlp8r(typeof(IOrganizationItem).TypeHandle), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-724676315 ^ -724689207));
					RaiseUpdateCache(organizationItem2, GetChangedIds((AbstractPostDatabaseOperationEvent)(object)@event, Expression.Lambda<Func<IOrganizationItem, string>>(Expression.Property(parameterExpression, (MethodInfo)D3n9dGRukw8UZy0UQj4((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })), oldUser, null);
					num2 = 5;
					continue;
				}
				default:
					RaiseOldUpdateCache();
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d133bac4622e4b5596f3c44ee791169d != 0)
					{
						num2 = 1;
					}
					continue;
				case 8:
					userGroup = WqR0bxR75EmpUT9FOOd(@event) as IUserGroup;
					num2 = 7;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fb7ef78ec97a4842bca66699308784ed == 0)
					{
						num2 = 5;
					}
					continue;
				case 3:
					if (num3 < 0)
					{
						num = 4;
						break;
					}
					obj = (EleWise.ELMA.Security.Models.IUser)((object[])Ffa9QXReFfuIDUsbxd2(@event))[num3];
					goto IL_0337;
				case 14:
					num3 = Array.IndexOf((string[])c8n0naaSqQmXTYNAtXK(DLxrXZRlSVfNEY6GTTQ(@event)), (string)zirDGba9hYgr7wjQ594(0x40096392 ^ 0x40096C4E));
					num2 = 3;
					continue;
				case 10:
				{
					IUserGroup group = userGroup;
					ParameterExpression parameterExpression = (ParameterExpression)bDFvleRxOqZ5VQAJX7f(pbySjZRZL9f3y6Jlp8r(typeof(IUserGroup).TypeHandle), zirDGba9hYgr7wjQ594(0x116C2699 ^ 0x116C697F));
					Pair<long[], long[]> changedIds = GetChangedIds((AbstractPostDatabaseOperationEvent)(object)@event, Expression.Lambda<Func<IUserGroup, string>>((Expression)bFUUq3RB9nIt7iEUKLc(parameterExpression, (MethodInfo)D3n9dGRukw8UZy0UQj4((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
					parameterExpression = (ParameterExpression)bDFvleRxOqZ5VQAJX7f(pbySjZRZL9f3y6Jlp8r(typeof(IUserGroup).TypeHandle), zirDGba9hYgr7wjQ594(0x271B34E4 ^ 0x271B7B02));
					Pair<long[], long[]> changedIds2 = GetChangedIds((AbstractPostDatabaseOperationEvent)(object)@event, Expression.Lambda<Func<IUserGroup, string>>((Expression)bFUUq3RB9nIt7iEUKLc(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
					parameterExpression = (ParameterExpression)bDFvleRxOqZ5VQAJX7f(pbySjZRZL9f3y6Jlp8r(typeof(IUserGroup).TypeHandle), zirDGba9hYgr7wjQ594(0x48E9668D ^ 0x48E9296B));
					RaiseUpdateCache(group, changedIds, changedIds2, GetChangedIds((AbstractPostDatabaseOperationEvent)(object)@event, Expression.Lambda<Func<IUserGroup, string>>((Expression)bFUUq3RB9nIt7iEUKLc(parameterExpression, (MethodInfo)D3n9dGRukw8UZy0UQj4((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
					num2 = 6;
					continue;
				}
				case 13:
					if (WqR0bxR75EmpUT9FOOd(@event) is IUserGroup)
					{
						num2 = 2;
						continue;
					}
					goto case 12;
				case 6:
				case 15:
					organizationItem = WqR0bxR75EmpUT9FOOd(@event) as IOrganizationItem;
					num2 = 16;
					continue;
				case 1:
					return;
					IL_0337:
					oldUser = (EleWise.ELMA.Security.Models.IUser)obj;
					num2 = 9;
					continue;
				}
				break;
			}
		}
	}

	public override void OnPostUpdateCollection(PostCollectionUpdateEvent @event)
	{
		//Discarded unreachable code: IL_0071, IL_0080, IL_0160, IL_016f, IL_01ae, IL_01bd, IL_01cc
		int num = 16;
		EleWise.ELMA.Security.Models.IUser user = default(EleWise.ELMA.Security.Models.IUser);
		IOrganizationItem organizationItem = default(IOrganizationItem);
		IUserGroup userGroup = default(IUserGroup);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 10:
					return;
				default:
					if (ux3tdtRirlTZ0ECJcxx(((CollectionEntry)YIQ3TVRAT8urvJ8YHJb(VLpOlsRpqPWvhHQdMvF(((AbstractEvent)@event).get_Session()), ((AbstractCollectionEvent)@event).get_Collection())).get_Role(), zirDGba9hYgr7wjQ594(0x9D1442B ^ 0x9D10BFD)))
					{
						num2 = 2;
						continue;
					}
					goto case 8;
				case 6:
					PUisxga1LdplIHlT0mf(user);
					num2 = 17;
					continue;
				case 3:
					PUisxga1LdplIHlT0mf(organizationItem);
					num2 = 13;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1bc92e0376794fc182b6e366eee82dbd != 0)
					{
						num2 = 18;
					}
					continue;
				case 14:
				case 17:
					organizationItem = ((AbstractCollectionEvent)@event).get_AffectedOwnerOrNull() as IOrganizationItem;
					num2 = 7;
					continue;
				case 7:
					if (organizationItem == null)
					{
						num2 = 8;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2f11eccd7e8f4339a0b03ad9fe1eb947 == 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto default;
				case 15:
					if (user == null)
					{
						num2 = 14;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0a82cc1379bc48bbb836c94da8cb8564 == 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 5;
				case 16:
					user = wd5MA1az99QHudULnMF(@event) as EleWise.ELMA.Security.Models.IUser;
					num2 = 15;
					continue;
				case 9:
					return;
				case 13:
					return;
				case 8:
				case 18:
					userGroup = wd5MA1az99QHudULnMF(@event) as IUserGroup;
					num2 = 12;
					continue;
				case 1:
					PUisxga1LdplIHlT0mf(userGroup);
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4b1278f673174e87a9fb6665eab69fc6 == 0)
					{
						num2 = 13;
					}
					continue;
				case 12:
					if (userGroup == null)
					{
						num2 = 10;
						continue;
					}
					goto case 11;
				case 5:
				{
					CollectionEntry collectionEntry = ((IPersistenceContext)VLpOlsRpqPWvhHQdMvF(UddsvJRkpNbXZ2ZAL2f(@event))).GetCollectionEntry((IPersistentCollection)HWCvykR5w37vKcFbJQ6(@event));
					if (ux3tdtRirlTZ0ECJcxx(b8sD5RRX3IO77Jt71up(collectionEntry), zirDGba9hYgr7wjQ594(-2030777218 ^ -2030795782)))
					{
						Process(user, (EleWise.ELMA.Security.Models.IUser u) => u.OrganizationItems, delegate(EleWise.ELMA.Security.Models.IUser u, string v)
						{
							int num9 = 1;
							int num10 = num9;
							while (true)
							{
								switch (num10)
								{
								default:
									return;
								case 1:
									_003C_003Ec.slNX7IpN2Cuqd3HGdJiA(u, v);
									num10 = 0;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c78060c4cac8419092e4610bf7a03750 == 0)
									{
										num10 = 0;
									}
									break;
								case 0:
									return;
								}
							}
						});
						PUisxga1LdplIHlT0mf(user);
					}
					if (ux3tdtRirlTZ0ECJcxx(b8sD5RRX3IO77Jt71up(collectionEntry), zirDGba9hYgr7wjQ594(0x4BBFF2C6 ^ 0x4BBFBD6A)))
					{
						num2 = 19;
						continue;
					}
					goto case 14;
				}
				case 19:
					Process(user, (EleWise.ELMA.Security.Models.IUser u) => u.OrganizationGroups, delegate(EleWise.ELMA.Security.Models.IUser u, string v)
					{
						int num7 = 1;
						int num8 = num7;
						while (true)
						{
							switch (num8)
							{
							default:
								return;
							case 0:
								return;
							case 1:
								_003C_003Ec.Rk3krkpNPagxOjmXPvrZ(u, v);
								num8 = 0;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d2fa92555e394879ba912e266541f735 == 0)
								{
									num8 = 0;
								}
								break;
							}
						}
					});
					num2 = 6;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a3a30dc594d64d20b0419bc3debf22fd == 0)
					{
						num2 = 2;
					}
					continue;
				case 2:
					Process(organizationItem, (IOrganizationItem u) => u.Users, delegate(IOrganizationItem u, string v)
					{
						int num13 = 1;
						int num14 = num13;
						while (true)
						{
							switch (num14)
							{
							default:
								return;
							case 0:
								return;
							case 1:
								_003C_003Ec.ByxaUqpNv31ULHMcS0bu(u, v);
								num14 = 0;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_417fa9f431a6421fac341b81e122e2e7 == 0)
								{
									num14 = 0;
								}
								break;
							}
						}
					});
					num = 3;
					break;
				case 11:
				{
					object obj = YIQ3TVRAT8urvJ8YHJb(((ISessionImplementor)((AbstractEvent)@event).get_Session()).get_PersistenceContext(), HWCvykR5w37vKcFbJQ6(@event));
					if (ux3tdtRirlTZ0ECJcxx(b8sD5RRX3IO77Jt71up(obj), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x78610A3D ^ 0x786145B9)))
					{
						Process(userGroup, (IUserGroup u) => u.OrganizationItems, delegate(IUserGroup u, string v)
						{
							int num5 = 1;
							int num6 = num5;
							while (true)
							{
								switch (num6)
								{
								default:
									return;
								case 0:
									return;
								case 1:
									_003C_003Ec.ymLHxXpNCAQfnuuBCC2R(u, v);
									num6 = 0;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fa1b4c3a88294db7b3c25698c3f06dd7 == 0)
									{
										num6 = 0;
									}
									break;
								}
							}
						});
						PUisxga1LdplIHlT0mf(userGroup);
					}
					if (((string)b8sD5RRX3IO77Jt71up(obj)).EndsWith((string)zirDGba9hYgr7wjQ594(-731479136 ^ -731460490)))
					{
						Process(userGroup, (IUserGroup u) => u.Users, delegate(IUserGroup u, string v)
						{
							int num3 = 1;
							int num4 = num3;
							while (true)
							{
								switch (num4)
								{
								default:
									return;
								case 0:
									return;
								case 1:
									_003C_003Ec.sYtnfepNRmGHqybbfVjp(u, v);
									num4 = 0;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a3b9996565fb40c18f26b204beedcb7f == 0)
									{
										num4 = 0;
									}
									break;
								}
							}
						});
						PUisxga1LdplIHlT0mf(userGroup);
					}
					if (!ux3tdtRirlTZ0ECJcxx(((CollectionEntry)obj).get_Role(), zirDGba9hYgr7wjQ594(0x432996D0 ^ 0x4329D922)))
					{
						num = 9;
						break;
					}
					goto case 4;
				}
				case 4:
					Process(userGroup, (IUserGroup u) => u.Groups, delegate(IUserGroup u, string v)
					{
						int num11 = 1;
						int num12 = num11;
						while (true)
						{
							switch (num12)
							{
							default:
								return;
							case 1:
								_003C_003Ec.Dm2pIOpNwxlZ4P5I6jk5(u, v);
								num12 = 0;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4aad3b757e09491eb106d72b1e7740cc != 0)
								{
									num12 = 0;
								}
								break;
							case 0:
								return;
							}
						}
					});
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6e35a1cd804541a884550671c71dbb1c != 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
		}
	}

	private Pair<long[], long[]> GetChangedIds<T>(AbstractPostDatabaseOperationEvent @event, Expression<Func<T, string>> prop)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		if (@event is PostInsertEvent)
		{
			return GetChangedIds(@event.get_Persister().get_PropertyNames(), null, ((PostInsertEvent)@event).get_State(), LinqUtils.NameOf(prop));
		}
		if (@event is PostDeleteEvent)
		{
			return GetChangedIds(@event.get_Persister().get_PropertyNames(), ((PostDeleteEvent)@event).get_DeletedState(), null, LinqUtils.NameOf(prop));
		}
		return GetChangedIds(@event.get_Persister().get_PropertyNames(), ((PostUpdateEvent)@event).get_OldState(), ((PostUpdateEvent)@event).get_State(), LinqUtils.NameOf(prop));
	}

	private Pair<long[], long[]> GetChangedIds(string[] propertyNames, object[] oldState, object[] state, string propName)
	{
		_003C_003Ec__DisplayClass18_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass18_0();
		int num = Array.IndexOf(propertyNames, propName);
		if (num < 0)
		{
			return null;
		}
		CS_0024_003C_003E8__locals0.oldValues = ((oldState != null && oldState[num] != null) ? (from s in ((string)oldState[num]).Split(new string[1] { SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xBBC1CCD ^ 0xBBC0603) }, StringSplitOptions.RemoveEmptyEntries)
			select _003C_003Ec.L3AqtkpNor2cBbBrVJpR(_003C_003Ec.f4dQ8GpNUAbA0hTmXCup(s))).ToList() : new List<long>());
		CS_0024_003C_003E8__locals0.newValues = ((state != null && state[num] != null) ? (from s in ((string)state[num]).Split(new string[1] { SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6A79A716 ^ 0x6A79BDD8) }, StringSplitOptions.RemoveEmptyEntries)
			select _003C_003Ec.L3AqtkpNor2cBbBrVJpR(_003C_003Ec.f4dQ8GpNUAbA0hTmXCup(s))).ToList() : new List<long>());
		return new Pair<long[], long[]>(CS_0024_003C_003E8__locals0.newValues.Where((long v) => !CS_0024_003C_003E8__locals0.oldValues.Contains(v)).ToArray(), CS_0024_003C_003E8__locals0.oldValues.Where((long v) => !CS_0024_003C_003E8__locals0.newValues.Contains(v)).ToArray());
	}

	private void RaiseOldUpdateCache()
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
				contextBoundVariableService.Set((string)zirDGba9hYgr7wjQ594(-1718905545 ^ -1718893261), UpdateFlag.True);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5ae6a44bd52345c5bcadd62b7063c7d9 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	private void RaiseUpdateCache()
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
				Ym7X65RjhTJ72EKRCcW(contextBoundVariableService, zirDGba9hYgr7wjQ594(0x31C71464 ^ 0x31C744B4));
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f0c2bdf066b1416088266cd84d9c3be2 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 2:
				XoJwsXRLJ8i4ZD2US4j(contextBoundVariableService, zirDGba9hYgr7wjQ594(0x715714F9 ^ 0x71574497), UpdateFlag.True);
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4b1278f673174e87a9fb6665eab69fc6 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void RaiseUpdateCache(EleWise.ELMA.Security.Models.IUser user)
	{
		int num = 3;
		int num2 = num;
		Dictionary<EleWise.ELMA.Security.Models.IUser, byte> orAdd = default(Dictionary<EleWise.ELMA.Security.Models.IUser, byte>);
		while (true)
		{
			switch (num2)
			{
			case 4:
				return;
			default:
				orAdd[user] = 0;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_288a03909ebe4f56a0d34bfce957098b != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				XoJwsXRLJ8i4ZD2US4j(contextBoundVariableService, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x190F47B7 ^ 0x190F16F7), orAdd);
				num2 = 4;
				break;
			case 3:
				if (VotqCvRHtq0arxJHI1p(contextBoundVariableService.GetOrAdd(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-698589567 ^ -698609937), () => UpdateFlag.False)))
				{
					return;
				}
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c08b0b4e9ab14bedb2a2c7a0048ab814 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				orAdd = contextBoundVariableService.GetOrAdd((string)zirDGba9hYgr7wjQ594(0x5FD42272 ^ 0x5FD47332), () => new Dictionary<EleWise.ELMA.Security.Models.IUser, byte>());
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a1a646659a464f3fa5c9aedc64725d72 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void RaiseUpdateCache(IUserGroup group, Pair<long[], long[]> userChanges, Pair<long[], long[]> orgItemsChanges, Pair<long[], long[]> groupsChanges)
	{
		if (!contextBoundVariableService.GetOrAdd(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1B47BFA1 ^ 0x1B47EFCF), () => UpdateFlag.False).Enabled && ((userChanges.First != null && userChanges.First.Length != 0) || (userChanges.Second != null && userChanges.Second.Length != 0) || (orgItemsChanges.First != null && orgItemsChanges.First.Length != 0) || (orgItemsChanges.Second != null && orgItemsChanges.Second.Length != 0) || (groupsChanges.First != null && groupsChanges.First.Length != 0) || (groupsChanges.Second != null && groupsChanges.Second.Length != 0)))
		{
			Dictionary<IUserGroup, GroupUpdate> orAdd = contextBoundVariableService.GetOrAdd(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4E6718AE ^ 0x4E67487E), () => new Dictionary<IUserGroup, GroupUpdate>());
			GroupUpdate value = (orAdd.ContainsKey(group) ? orAdd[group] : default(GroupUpdate));
			UpdateLists(ref value.AddUsers, ref value.RemoveUsers, userChanges);
			UpdateLists(ref value.AddOrganizationItems, ref value.RemoveOrganizationItems, orgItemsChanges);
			UpdateLists(ref value.AddGroups, ref value.RemoveGroups, groupsChanges);
			orAdd[group] = value;
			contextBoundVariableService.Set(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2037738356 ^ -2037726116), orAdd);
		}
	}

	private void RaiseUpdateCache(IOrganizationItem organizationItem, Pair<long[], long[]> userChanges, EleWise.ELMA.Security.Models.IUser oldUser, EleWise.ELMA.Security.Models.IUser newUser)
	{
		if (contextBoundVariableService.GetOrAdd(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1429357207 ^ -1429345017), () => UpdateFlag.False).Enabled)
		{
			return;
		}
		if (oldUser != newUser)
		{
			if (oldUser != null)
			{
				userChanges.Second = new long[1] { oldUser.Id };
			}
			if (newUser != null)
			{
				userChanges.First = new long[1] { newUser.Id };
			}
		}
		if ((userChanges.First != null && userChanges.First.Length != 0) || (userChanges.Second != null && userChanges.Second.Length != 0))
		{
			Dictionary<IOrganizationItem, OrganizationItemUpdate> orAdd = contextBoundVariableService.GetOrAdd(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2119527672 ^ -2119515482), () => new Dictionary<IOrganizationItem, OrganizationItemUpdate>());
			OrganizationItemUpdate value = (orAdd.ContainsKey(organizationItem) ? orAdd[organizationItem] : default(OrganizationItemUpdate));
			UpdateLists(ref value.AddUsers, ref value.RemoveUsers, userChanges);
			orAdd[organizationItem] = value;
			contextBoundVariableService.Set(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-737960346 ^ -737947704), orAdd);
		}
	}

	private void UpdateLists(ref long[] addList, ref long[] removeList, Pair<long[], long[]> changes)
	{
		_003C_003Ec__DisplayClass24_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass24_0();
		CS_0024_003C_003E8__locals0.changes = changes;
		CS_0024_003C_003E8__locals0.add = addList ?? new long[0];
		CS_0024_003C_003E8__locals0.remove = removeList ?? new long[0];
		addList = CS_0024_003C_003E8__locals0.add.Where((long i) => !CS_0024_003C_003E8__locals0.changes.Second.Contains(i)).Concat(CS_0024_003C_003E8__locals0.changes.First.Where(delegate(long i)
		{
			//Discarded unreachable code: IL_0058, IL_0067
			int num3 = 1;
			int num4 = num3;
			while (true)
			{
				switch (num4)
				{
				case 1:
					if (CS_0024_003C_003E8__locals0.remove.Contains(i))
					{
						num4 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0d00d0d8fcd5481b8bdc09ec82b1ea36 == 0)
						{
							num4 = 0;
						}
						break;
					}
					goto case 2;
				case 2:
					return !CS_0024_003C_003E8__locals0.add.Contains(i);
				default:
					return false;
				}
			}
		})).ToArray();
		removeList = CS_0024_003C_003E8__locals0.remove.Where((long i) => !CS_0024_003C_003E8__locals0.changes.First.Contains(i)).Concat(CS_0024_003C_003E8__locals0.changes.Second.Where(delegate(long i)
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (CS_0024_003C_003E8__locals0.remove.Contains(i))
					{
						return false;
					}
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d133bac4622e4b5596f3c44ee791169d != 0)
					{
						num2 = 0;
					}
					break;
				default:
					return !CS_0024_003C_003E8__locals0.add.Contains(i);
				}
			}
		})).ToArray();
	}

	private void Process<EntityT, CollectionEntryT>(EntityT entity, Func<EntityT, ISet<CollectionEntryT>> collectionAccessor, Action<EntityT, string> hashSetter) where EntityT : IEntity where CollectionEntryT : IEntity
	{
		if (NHibernateUtil.IsInitialized((object)entity))
		{
			ISet<CollectionEntryT> collection = collectionAccessor(entity);
			if (collection.IsInitialized<CollectionEntryT>())
			{
				HashSet(entity, (IEnumerable<CollectionEntryT>)collection, hashSetter);
			}
		}
	}

	private void ProcessAdd<EntityT, CollectionEntryT>(EntityT entity, CollectionEntryT add, Func<EntityT, ISet<CollectionEntryT>> collectionAccessor, Action<EntityT, string> hashSetter) where EntityT : IEntity where CollectionEntryT : IEntity
	{
		if (NHibernateUtil.IsInitialized((object)entity))
		{
			ISet<CollectionEntryT> val = collectionAccessor(entity);
			if (val.IsInitialized<CollectionEntryT>())
			{
				HashSet(entity, ((IEnumerable<CollectionEntryT>)val).Concat(new CollectionEntryT[1] { add }), hashSetter);
			}
		}
	}

	private void ProcessRemove<EntityT, CollectionEntryT>(EntityT entity, CollectionEntryT remove, Func<EntityT, ISet<CollectionEntryT>> collectionAccessor, Action<EntityT, string> hashSetter) where EntityT : IEntity where CollectionEntryT : IEntity
	{
		_003C_003Ec__DisplayClass27_0<EntityT, CollectionEntryT> CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass27_0<EntityT, CollectionEntryT>();
		CS_0024_003C_003E8__locals0.remove = remove;
		if (!NHibernateUtil.IsInitialized((object)entity))
		{
			return;
		}
		ISet<CollectionEntryT> val = collectionAccessor(entity);
		if (val.IsInitialized<CollectionEntryT>())
		{
			HashSet(entity, ((IEnumerable<CollectionEntryT>)val).Where((CollectionEntryT i) => !i.GetId().Equals(CS_0024_003C_003E8__locals0.remove.GetId())), hashSetter);
		}
	}

	private void HashSet<EntityT, CollectionEntryT>(EntityT entity, IEnumerable<CollectionEntryT> collection, Action<EntityT, string> hashSetter) where EntityT : IEntity where CollectionEntryT : IEntity
	{
		hashSetter(entity, string.Join(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1B3723C5 ^ 0x1B372A5B), (from id in collection.Select((CollectionEntryT i) => i.GetId()).Distinct((object o, object o1) => o.Equals(o1))
			orderby id
			select id).ToArray()));
	}

	internal static object IisgYXa8wZP47HIDbKi()
	{
		return ComponentManager.Current;
	}

	internal static object finDZkarntvxIKEgxrW(object P_0)
	{
		return ((ILicensedModuleAssembly)P_0).LicenseUnit;
	}

	internal static bool TtSJb7aTDjTqVTg75Y9()
	{
		return cEkBiradcdMh5ZfcvYo == null;
	}

	internal static SecurityCacheListener Jjbw19agrEREOktGJQe()
	{
		return cEkBiradcdMh5ZfcvYo;
	}

	internal static void PLirEda3eW7tIgq7Ee2()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}

	internal static bool fGbC7QaypHsl6nwgPIX(object P_0, object P_1)
	{
		return ((EntityEventsListener)P_0).OnPreInsert((PreInsertEvent)P_1);
	}

	internal static object tvAjxEab2uufeSRT6uN(object P_0)
	{
		return ((AbstractPreDatabaseOperationEvent)P_0).get_Entity();
	}

	internal static object c8n0naaSqQmXTYNAtXK(object P_0)
	{
		return ((IEntityPersister)P_0).get_PropertyNames();
	}

	internal static object zirDGba9hYgr7wjQ594(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object NDTpy6afungcYv4TFj8(object P_0)
	{
		return ((PreUpdateEvent)P_0).get_OldState();
	}

	internal static void PUisxga1LdplIHlT0mf(object P_0)
	{
		((IEntity)P_0).Save();
	}

	internal static object wd5MA1az99QHudULnMF(object P_0)
	{
		return ((AbstractCollectionEvent)P_0).get_AffectedOwnerOrNull();
	}

	internal static object UddsvJRkpNbXZ2ZAL2f(object P_0)
	{
		return ((AbstractEvent)P_0).get_Session();
	}

	internal static object VLpOlsRpqPWvhHQdMvF(object P_0)
	{
		return ((ISessionImplementor)P_0).get_PersistenceContext();
	}

	internal static object HWCvykR5w37vKcFbJQ6(object P_0)
	{
		return ((AbstractCollectionEvent)P_0).get_Collection();
	}

	internal static object YIQ3TVRAT8urvJ8YHJb(object P_0, object P_1)
	{
		return ((IPersistenceContext)P_0).GetCollectionEntry((IPersistentCollection)P_1);
	}

	internal static object MdUVC1RW1mZSD8CXBVh(object P_0)
	{
		return ((CollectionEntry)P_0).get_Snapshot();
	}

	internal static object b8sD5RRX3IO77Jt71up(object P_0)
	{
		return ((CollectionEntry)P_0).get_Role();
	}

	internal static void muYFxGRnoaMNclubyyh(object P_0, object P_1)
	{
		((IOrganizationItem)P_0).User = (EleWise.ELMA.Security.Models.IUser)P_1;
	}

	internal static bool ux3tdtRirlTZ0ECJcxx(object P_0, object P_1)
	{
		return ((string)P_0).EndsWith((string)P_1);
	}

	internal static object WqR0bxR75EmpUT9FOOd(object P_0)
	{
		return ((AbstractPostDatabaseOperationEvent)P_0).get_Entity();
	}

	internal static UserStatus adE4HPR61V5OdPnO1LL(object P_0)
	{
		return ((EleWise.ELMA.Security.Models.IUser)P_0).Status;
	}

	internal static object DLxrXZRlSVfNEY6GTTQ(object P_0)
	{
		return ((AbstractPostDatabaseOperationEvent)P_0).get_Persister();
	}

	internal static object IVF0YZRNvGDZvMlYiWD(object P_0)
	{
		return ((PostInsertEvent)P_0).get_State();
	}

	internal static Type pbySjZRZL9f3y6Jlp8r(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object bDFvleRxOqZ5VQAJX7f(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object bFUUq3RB9nIt7iEUKLc(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static object D3n9dGRukw8UZy0UQj4(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object gNoqvdRmbrunaEuixhJ(object P_0)
	{
		return ((PostUpdateEvent)P_0).get_OldState();
	}

	internal static object Ffa9QXReFfuIDUsbxd2(object P_0)
	{
		return ((PostDeleteEvent)P_0).get_DeletedState();
	}

	internal static void XoJwsXRLJ8i4ZD2US4j(object P_0, object P_1, object P_2)
	{
		((IAbstractBoundVariableService)P_0).Set((string)P_1, P_2);
	}

	internal static void Ym7X65RjhTJ72EKRCcW(object P_0, object P_1)
	{
		((IAbstractBoundVariableService)P_0).Remove((string)P_1);
	}

	internal static bool VotqCvRHtq0arxJHI1p(object P_0)
	{
		return ((UpdateFlag)P_0).Enabled;
	}
}
