using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Runtime.Db.Actions;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.Db;

[Component]
public abstract class DbUpdateHandler : IDbUpdateHandler, IActionsHolder
{
	private List<IDbAction> tablesCreatedActions;

	private List<IDbAction> tablesDeletedActions;

	private List<IDbAction> foreignKeysCreatedActions;

	private List<IDbAction> primaryKeysCreatedActions;

	private List<IDbAction> onCompleteActions;

	internal static DbUpdateHandler jPomcwWiO7k5nGxHaT6d;

	public abstract Guid ProviderUid { get; }

	public abstract bool HasChanges { get; }

	public abstract bool NeedRecreateConstraints { get; }

	public List<IDbAction> TablesCreatedActions => tablesCreatedActions;

	public List<IDbAction> TablesDeletedActions => tablesDeletedActions;

	public List<IDbAction> ForeignKeysCreatedActions => foreignKeysCreatedActions;

	public List<IDbAction> PrimaryKeysCreatedActions => primaryKeysCreatedActions;

	public List<IDbAction> OnCompleteActions => onCompleteActions;

	public ITransformationProvider Transform
	{
		[CompilerGenerated]
		get
		{
			return _003CTransform_003Ek__BackingField;
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
					_003CTransform_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ISessionProvider SessionProvider
	{
		[CompilerGenerated]
		protected get
		{
			return _003CSessionProvider_003Ek__BackingField;
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
					_003CSessionProvider_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public DbUpdateMarkerService MarkerService
	{
		[CompilerGenerated]
		get
		{
			return _003CMarkerService_003Ek__BackingField;
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
					_003CMarkerService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
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

	public bool HasActions
	{
		get
		{
			//Discarded unreachable code: IL_008b, IL_009a, IL_00f0, IL_00ff, IL_0120
			int num = 7;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 2:
						if (gfnlIHWi3TEMb4t593ir(PrimaryKeysCreatedActions) > 0)
						{
							num2 = 5;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
							{
								num2 = 5;
							}
							continue;
						}
						goto case 4;
					case 7:
						if (gfnlIHWi3TEMb4t593ir(TablesCreatedActions) > 0)
						{
							goto end_IL_0012;
						}
						goto case 1;
					default:
						if (ForeignKeysCreatedActions.Count > 0)
						{
							num2 = 3;
							continue;
						}
						goto case 2;
					case 1:
						if (gfnlIHWi3TEMb4t593ir(TablesDeletedActions) <= 0)
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
							{
								num2 = 0;
							}
							continue;
						}
						break;
					case 4:
						return gfnlIHWi3TEMb4t593ir(OnCompleteActions) > 0;
					case 3:
					case 5:
					case 6:
						break;
					}
					return true;
					continue;
					end_IL_0012:
					break;
				}
				num = 6;
			}
		}
	}

	protected ISession Session
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return (ISession)gmGFiUWiab1KYLCSZnSH(SessionProvider, "");
				case 1:
					Contract.NotNull(SessionProvider, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70037984 ^ -70074644));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public virtual void CreateInitialStructures()
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
				IMAqYPWi1LVvpWDfqanb(Transform, h64QPHWiPVdJjUleALl3(-70037984 ^ -70060802));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual void Init()
	{
	}

	public virtual void OnStart(DbUpdateParameters parameters)
	{
	}

	public virtual void OnTriggersDeleting(TriggersDeletingEventArgs e)
	{
	}

	public virtual void OnTriggersDeleted()
	{
	}

	public virtual void OnProceduresDeleting(ProceduresDeletingEventArgs e)
	{
	}

	public virtual void OnProceduresDeleted()
	{
	}

	public virtual void OnViewsDeleting(ViewsDeletingEventArgs e)
	{
	}

	public virtual void OnViewsDeleted()
	{
	}

	public virtual void OnIndexesDeleting(IndexesDeletingEventArgs e)
	{
	}

	public virtual void OnIndexesDeleted()
	{
	}

	public virtual void OnForeignKeysDeleting(ForeginKeysDeletingEventArgs e)
	{
	}

	public virtual void OnForeignKeysDeleted()
	{
	}

	public virtual void OnPrimaryKeysDeleting(PrimaryKeysDeletingEventArgs e)
	{
	}

	public virtual void OnPrimaryKeysDeleted()
	{
	}

	public virtual void OnTablesCreating(TablesCreatingEventArgs e)
	{
	}

	public virtual void OnTablesCreated()
	{
		//Discarded unreachable code: IL_002e, IL_0038, IL_00ca, IL_00dd, IL_00ec
		int num = 1;
		int num2 = num;
		List<IDbAction>.Enumerator enumerator = default(List<IDbAction>.Enumerator);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				enumerator = TablesCreatedActions.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
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
					if (!enumerator.MoveNext())
					{
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
						{
							num3 = 1;
						}
						goto IL_003c;
					}
					goto IL_0078;
					IL_0078:
					enumerator.Current.Execute();
					num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
					{
						num3 = 0;
					}
					goto IL_003c;
					IL_003c:
					switch (num3)
					{
					case 2:
						goto IL_0078;
					case 1:
						return;
					}
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
				int num4 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
				{
					num4 = 0;
				}
				switch (num4)
				{
				case 0:
					break;
				}
			}
		}
	}

	public virtual void OnTablesDeleting(TablesDeletingEventArgs e)
	{
	}

	public virtual void OnTablesDeleted()
	{
		//Discarded unreachable code: IL_002f, IL_003e, IL_0049, IL_00db, IL_00ee, IL_00fd
		int num = 2;
		int num2 = num;
		List<IDbAction>.Enumerator enumerator = default(List<IDbAction>.Enumerator);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
							{
								num3 = 2;
							}
							goto IL_004d;
						}
						goto IL_0063;
						IL_0063:
						ahxlIUWiNC6tLHNdLW5x(enumerator.Current);
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
						{
							num3 = 1;
						}
						goto IL_004d;
						IL_004d:
						switch (num3)
						{
						case 2:
							return;
						case 1:
							continue;
						}
						goto IL_0063;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
			case 2:
				enumerator = TablesDeletedActions.GetEnumerator();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public virtual void OnForeignKeysCreating(ForeignKeysCreatingEventArgs e)
	{
	}

	public virtual void OnForeignKeysCreated()
	{
		//Discarded unreachable code: IL_0056, IL_0065, IL_0070, IL_0102, IL_0115, IL_0124
		int num = 1;
		int num2 = num;
		List<IDbAction>.Enumerator enumerator = default(List<IDbAction>.Enumerator);
		while (true)
		{
			switch (num2)
			{
			case 1:
				enumerator = ForeignKeysCreatedActions.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
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
						num3 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
						{
							num3 = 1;
						}
						goto IL_0074;
					}
					goto IL_008a;
					IL_008a:
					ahxlIUWiNC6tLHNdLW5x(enumerator.Current);
					num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
					{
						num3 = 1;
					}
					goto IL_0074;
					IL_0074:
					switch (num3)
					{
					case 2:
						return;
					case 1:
						continue;
					}
					goto IL_008a;
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
				int num4 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
				{
					num4 = 0;
				}
				switch (num4)
				{
				case 0:
					break;
				}
			}
		}
	}

	public virtual void OnPrimaryKeysCreating(PrimaryKeysCreatingEventArgs e)
	{
	}

	public virtual void OnPrimaryKeysCreated()
	{
		//Discarded unreachable code: IL_0055, IL_0064, IL_006f, IL_0101, IL_0114, IL_0123
		int num = 1;
		int num2 = num;
		List<IDbAction>.Enumerator enumerator = default(List<IDbAction>.Enumerator);
		while (true)
		{
			switch (num2)
			{
			case 1:
				enumerator = PrimaryKeysCreatedActions.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
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
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
						{
							num3 = 0;
						}
						goto IL_0073;
					}
					goto IL_0089;
					IL_0089:
					enumerator.Current.Execute();
					num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
					{
						num3 = 2;
					}
					goto IL_0073;
					IL_0073:
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
					goto IL_0089;
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
				int num4 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
				{
					num4 = 0;
				}
				switch (num4)
				{
				case 0:
					break;
				}
			}
		}
	}

	public virtual void OnIndexesCreating(IndexesCreatingEventArgs e)
	{
	}

	public virtual void OnIndexesCreated()
	{
	}

	public virtual void OnViewsCreating(ViewsCreatingEventArgs e)
	{
	}

	public virtual void OnViewsCreated()
	{
	}

	public virtual void OnTriggersCreating(TriggersCreatingEventArgs e)
	{
	}

	public virtual void OnTriggersCreated()
	{
	}

	public virtual void OnProceduresCreating(ProceduresCreatingEventArgs e)
	{
	}

	public virtual void OnProceduresCreated()
	{
	}

	public virtual void OnComplete()
	{
		//Discarded unreachable code: IL_002f, IL_003e, IL_0049, IL_00cb, IL_00de, IL_00ed
		int num = 2;
		int num2 = num;
		List<IDbAction>.Enumerator enumerator = default(List<IDbAction>.Enumerator);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 2;
							goto IL_004d;
						}
						goto IL_0063;
						IL_004d:
						switch (num3)
						{
						case 2:
							return;
						case 1:
							continue;
						}
						goto IL_0063;
						IL_0063:
						enumerator.Current.Execute();
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
						{
							num3 = 1;
						}
						goto IL_004d;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
			case 2:
				enumerator = OnCompleteActions.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public void CheckAllActions()
	{
		//Discarded unreachable code: IL_0046, IL_0055, IL_0060, IL_00e2, IL_00f5, IL_0121, IL_0130, IL_013b, IL_01cd, IL_01e0, IL_01f0, IL_01ff, IL_0290, IL_02a3, IL_02b2, IL_02da, IL_02e9, IL_02f4, IL_0376, IL_0389
		int num = 6;
		int num2 = num;
		List<IDbAction>.Enumerator enumerator = default(List<IDbAction>.Enumerator);
		while (true)
		{
			switch (num2)
			{
			case 8:
				try
				{
					while (true)
					{
						int num10;
						if (!enumerator.MoveNext())
						{
							num10 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
							{
								num10 = 0;
							}
							goto IL_0064;
						}
						goto IL_007a;
						IL_007a:
						Br5tsUWipqtZJPSnshtq(enumerator.Current);
						num10 = 2;
						goto IL_0064;
						IL_0064:
						switch (num10)
						{
						case 1:
							goto IL_007a;
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
					((IDisposable)enumerator).Dispose();
					int num11 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
					{
						num11 = 0;
					}
					switch (num11)
					{
					case 0:
						break;
					}
				}
				goto case 7;
			case 1:
				return;
			case 6:
				enumerator = TablesCreatedActions.GetEnumerator();
				num2 = 5;
				continue;
			case 3:
				try
				{
					while (true)
					{
						int num8;
						if (!enumerator.MoveNext())
						{
							num8 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
							{
								num8 = 1;
							}
							goto IL_013f;
						}
						goto IL_017b;
						IL_017b:
						Br5tsUWipqtZJPSnshtq(enumerator.Current);
						num8 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
						{
							num8 = 0;
						}
						goto IL_013f;
						IL_013f:
						switch (num8)
						{
						case 1:
							goto IL_017b;
						case 2:
							goto end_IL_0155;
						}
						continue;
						end_IL_0155:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num9 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num9 = 0;
					}
					switch (num9)
					{
					case 0:
						break;
					}
				}
				break;
			default:
				try
				{
					while (true)
					{
						int num6;
						if (!enumerator.MoveNext())
						{
							int num5 = 2;
							num6 = num5;
							goto IL_020e;
						}
						goto IL_0224;
						IL_020e:
						switch (num6)
						{
						case 2:
							return;
						case 1:
							continue;
						}
						goto IL_0224;
						IL_0224:
						Br5tsUWipqtZJPSnshtq(enumerator.Current);
						num6 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
						{
							num6 = 1;
						}
						goto IL_020e;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num7 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
					{
						num7 = 0;
					}
					switch (num7)
					{
					case 0:
						break;
					}
				}
			case 4:
				enumerator = TablesDeletedActions.GetEnumerator();
				num2 = 3;
				continue;
			case 5:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 2;
							goto IL_02f8;
						}
						goto IL_030e;
						IL_02f8:
						switch (num3)
						{
						case 1:
							break;
						default:
							continue;
						case 2:
							goto end_IL_0334;
						}
						goto IL_030e;
						IL_030e:
						Br5tsUWipqtZJPSnshtq(enumerator.Current);
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
						{
							num3 = 0;
						}
						goto IL_02f8;
						continue;
						end_IL_0334:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				goto case 4;
			case 7:
				enumerator = PrimaryKeysCreatedActions.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				break;
			}
			enumerator = ForeignKeysCreatedActions.GetEnumerator();
			num2 = 8;
		}
	}

	protected DbUpdateHandler()
	{
		//Discarded unreachable code: IL_007a, IL_007f
		fsaDIGWiDuoJ3cSyNyB2();
		tablesCreatedActions = new List<IDbAction>();
		tablesDeletedActions = new List<IDbAction>();
		foreignKeysCreatedActions = new List<IDbAction>();
		primaryKeysCreatedActions = new List<IDbAction>();
		onCompleteActions = new List<IDbAction>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object h64QPHWiPVdJjUleALl3(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void IMAqYPWi1LVvpWDfqanb(object P_0, object P_1)
	{
		Contract.ServiceNotNull(P_0, (string)P_1);
	}

	internal static bool aAjLxOWi2RbkxLkdEZGs()
	{
		return jPomcwWiO7k5nGxHaT6d == null;
	}

	internal static DbUpdateHandler itcfXiWie88tQdpDuQhY()
	{
		return jPomcwWiO7k5nGxHaT6d;
	}

	internal static void ahxlIUWiNC6tLHNdLW5x(object P_0)
	{
		((IDbAction)P_0).Execute();
	}

	internal static int gfnlIHWi3TEMb4t593ir(object P_0)
	{
		return ((List<IDbAction>)P_0).Count;
	}

	internal static void Br5tsUWipqtZJPSnshtq(object P_0)
	{
		((IDbAction)P_0).Check();
	}

	internal static object gmGFiUWiab1KYLCSZnSH(object P_0, object P_1)
	{
		return ((ISessionProvider)P_0).GetSession((string)P_1);
	}

	internal static void fsaDIGWiDuoJ3cSyNyB2()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
