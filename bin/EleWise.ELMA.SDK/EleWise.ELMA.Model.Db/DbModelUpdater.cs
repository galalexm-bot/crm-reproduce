using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Db.Actions;
using EleWise.ELMA.Model.Db.Helpers;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.Db;
using EleWise.ELMA.Runtime.Db.Actions;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using Microsoft.Win32;
using NHibernate;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Db;

[Component(Order = -1)]
public class DbModelUpdater : DbUpdateHandler, IDbModelUpdater, IActionsHolder
{
	private class ModuleRef
	{
		private static object DT78FNChJIirv90EVoJ8;

		public string Name
		{
			[CompilerGenerated]
			get
			{
				return _003CName_003Ek__BackingField;
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
						_003CName_003Ek__BackingField = value;
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

		public ModuleRef()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			LLMMTKChlGQlsPTjAhDP();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool TpDBFdCh9Lh7avR4T4h1()
		{
			return DT78FNChJIirv90EVoJ8 == null;
		}

		internal static ModuleRef q1TBXUChd4lOaOOlIIcF()
		{
			return (ModuleRef)DT78FNChJIirv90EVoJ8;
		}

		internal static void LLMMTKChlGQlsPTjAhDP()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	private RegistryKey _processEntityPropertyMetadataChangesHackWriteKey;

	private IList<string> processEntityPropertyMetadataChangesHack;

	private bool hasChanges;

	private IEnumerable<string> deactivatingModules;

	private readonly Dictionary<Guid, AbstractMetadata> currMetadata;

	private readonly Dictionary<Guid, AbstractMetadata> prevMetadata;

	private readonly Dictionary<AbstractMetadata, ModuleRef> currMetadataModules;

	private readonly Dictionary<AbstractMetadata, ModuleRef> prevMetadataModules;

	private readonly Dictionary<string, ModuleRef> moduleRefs;

	private bool recreateConstraints;

	private bool needRecreateConstraints;

	private static readonly ILogger DbUpdateLog;

	internal static DbModelUpdater O5qXfSoorDF2hrPyRPyX;

	public override Guid ProviderUid => Guid.Empty;

	public override bool HasChanges => hasChanges;

	public override bool NeedRecreateConstraints => needRecreateConstraints;

	public bool RecreateConstraints => recreateConstraints;

	public IMetadataRuntimeService MetadataService
	{
		[CompilerGenerated]
		get
		{
			return _003CMetadataService_003Ek__BackingField;
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
					_003CMetadataService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public IEnumerable<AbstractMetadata> CurrentMetadata => currMetadata.Values.ToReadOnlyCollection();

	public IEnumerable<AbstractMetadata> PreviousMetadata => prevMetadata.Values.ToReadOnlyCollection();

	public override void Init()
	{
		//Discarded unreachable code: IL_0077
		int num = 5;
		int num2 = num;
		IRuntimeApplication serviceNotNull = default(IRuntimeApplication);
		while (true)
		{
			switch (num2)
			{
			case 3:
				RemoveProcessEntityPropertyMetadataChangesHack();
				num2 = 6;
				break;
			case 4:
				serviceNotNull = Locator.GetServiceNotNull<IRuntimeApplication>();
				num2 = 2;
				break;
			case 1:
				return;
			case 8:
				return;
			case 12:
				SaveMetadata();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
				{
					num2 = 0;
				}
				break;
			case 7:
				LoadCurrentMetadata();
				num2 = 10;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
				{
					num2 = 10;
				}
				break;
			case 2:
				deactivatingModules = ((DbPreUpdater)QkXxEfoojJa6FFLIIxGn(serviceNotNull)).GetDeactivatingModules();
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
				{
					num2 = 7;
				}
				break;
			default:
				if (hasChanges)
				{
					num2 = 8;
					break;
				}
				goto case 12;
			case 6:
				CheckAllActions();
				num2 = 9;
				break;
			case 5:
				base.Init();
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
				{
					num2 = 4;
				}
				break;
			case 11:
				ProcessMetadataChanges();
				num2 = 3;
				break;
			case 10:
				LoadPreviousMetadata();
				num2 = 11;
				break;
			case 9:
				hasChanges = base.HasActions;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override void OnStart(DbUpdateParameters parameters)
	{
		//Discarded unreachable code: IL_006a, IL_0079, IL_00c6, IL_0169, IL_0178, IL_0183, IL_0202, IL_023a, IL_0249, IL_027a, IL_02b2
		int num = 6;
		IEnumerable<IEntityActionExtender> extensionPoints = default(IEnumerable<IEntityActionExtender>);
		IEnumerator<EntityMetadata> enumerator = default(IEnumerator<EntityMetadata>);
		EntityMetadata current = default(EntityMetadata);
		IEnumerator<IEntityActionExtender> enumerator2 = default(IEnumerator<IEntityActionExtender>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 8:
					apqCMZooYmYusrPGTi54(base.ForeignKeysCreatedActions);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					return;
				default:
					extensionPoints = ((ComponentManager)axumBMooLlY7Mhn4KKDC()).GetExtensionPoints<IEntityActionExtender>();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					return;
				case 7:
					if (!recreateConstraints)
					{
						num2 = 3;
						continue;
					}
					goto case 8;
				case 4:
					try
					{
						while (true)
						{
							IL_013d:
							int num3;
							if (!a6Xjbsooc1RoelgwJJWa(enumerator))
							{
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
								{
									num3 = 1;
								}
								goto IL_00d4;
							}
							goto IL_00f6;
							IL_00f6:
							current = enumerator.Current;
							int num4 = 5;
							num3 = num4;
							goto IL_00d4;
							IL_00d4:
							while (true)
							{
								switch (num3)
								{
								case 1:
									return;
								case 4:
									break;
								case 5:
									base.ForeignKeysCreatedActions.Add(new EntityForeignKeysAction(this, current));
									num3 = 2;
									continue;
								case 2:
									enumerator2 = extensionPoints.GetEnumerator();
									num3 = 3;
									continue;
								default:
									goto IL_013d;
								case 3:
									try
									{
										while (true)
										{
											int num5;
											if (!enumerator2.MoveNext())
											{
												num5 = 2;
												goto IL_0187;
											}
											goto IL_01b3;
											IL_0187:
											switch (num5)
											{
											case 1:
												break;
											default:
												goto IL_01b3;
											case 2:
												goto end_IL_019d;
											}
											continue;
											IL_01b3:
											xUmpYIooUCTMsJGTfpw6(enumerator2.Current, this, current);
											num5 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
											{
												num5 = 1;
											}
											goto IL_0187;
											continue;
											end_IL_019d:
											break;
										}
									}
									finally
									{
										if (enumerator2 != null)
										{
											int num6 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
											{
												num6 = 1;
											}
											while (true)
											{
												switch (num6)
												{
												case 1:
													VJ6qT2oosW0aSBDWnQVE(enumerator2);
													num6 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
													{
														num6 = 0;
													}
													continue;
												case 0:
													break;
												}
												break;
											}
										}
									}
									goto IL_013d;
								}
								break;
							}
							goto IL_00f6;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							int num7 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
							{
								num7 = 0;
							}
							while (true)
							{
								switch (num7)
								{
								case 1:
									VJ6qT2oosW0aSBDWnQVE(enumerator);
									num7 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
									{
										num7 = 0;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
						}
					}
				case 6:
					base.OnStart(parameters);
					num2 = 5;
					continue;
				case 5:
					recreateConstraints = parameters.RecreateConstraints;
					num2 = 7;
					continue;
				case 1:
					enumerator = (from m in currMetadata.Values.OfType<EntityMetadata>()
						where !_003C_003Ec.rrMINtChjLS0hxxbkuhO(m)
						select m).GetEnumerator();
					num = 4;
					break;
				}
				break;
			}
		}
	}

	public override void OnComplete()
	{
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				gmxKaIobo0Q20fYMCIVo(moduleRefs);
				num2 = 7;
				break;
			case 4:
				base.OnComplete();
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
				{
					num2 = 3;
				}
				break;
			case 3:
				O8pRgBobFuS1ZtsNc4iW(S8PJ74oozuGqpBF5WjuB(), (Action)delegate
				{
					SaveMetadata();
				});
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
				{
					num2 = 1;
				}
				break;
			case 7:
				return;
			default:
				d1ATmaobWrN6aZpTfQR7(currMetadataModules);
				num2 = 2;
				break;
			case 6:
				D9XgoIobBbfV8d0grcZV(currMetadata);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				D9XgoIobBbfV8d0grcZV(prevMetadata);
				num2 = 5;
				break;
			case 5:
				prevMetadataModules.Clear();
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
				{
					num2 = 6;
				}
				break;
			}
		}
	}

	public virtual string GenerateDeletingColumnTemporaryName(string tableName, string columnName)
	{
		return base.Transform.GenerateDeletingColumnTemporaryName(tableName, columnName);
	}

	public virtual string GetDeletingColumnTemporaryName(string tableName, string columnName)
	{
		return (string)wPi26hobbLmeXJ3nvZgQ(base.Transform, tableName, columnName);
	}

	public override void OnTablesCreated()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				YWXZxVobhoDJcXyjIbPJ(this);
				num2 = 3;
				break;
			case 2:
				base.OnTablesCreated();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return;
			case 1:
				if (RecreateConstraints)
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected virtual string GetDbName()
	{
		return string.Empty;
	}

	protected virtual void ProcessMetadataChanges()
	{
		//Discarded unreachable code: IL_0036, IL_0045, IL_0050, IL_0120, IL_012f, IL_01e6, IL_0297, IL_02aa, IL_0316, IL_0325, IL_0330, IL_03d5, IL_03e8, IL_03f7
		int num = 2;
		int num2 = num;
		Dictionary<Guid, AbstractMetadata>.ValueCollection.Enumerator enumerator = default(Dictionary<Guid, AbstractMetadata>.ValueCollection.Enumerator);
		AbstractMetadata current = default(AbstractMetadata);
		AbstractMetadata current2 = default(AbstractMetadata);
		ModuleRef moduleRef = default(ModuleRef);
		AbstractMetadata value2 = default(AbstractMetadata);
		AbstractMetadata value = default(AbstractMetadata);
		EntityMetadata entityMetadata = default(EntityMetadata);
		while (true)
		{
			switch (num2)
			{
			case 4:
				enumerator = prevMetadata.Values.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				enumerator = currMetadata.Values.GetEnumerator();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
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
						if (!enumerator.MoveNext())
						{
							num3 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
							{
								num3 = 1;
							}
							goto IL_0334;
						}
						goto IL_0396;
						IL_0396:
						current = enumerator.Current;
						num3 = 3;
						goto IL_0334;
						IL_0334:
						while (true)
						{
							switch (num3)
							{
							case 1:
								break;
							case 3:
								OKvq5FobGNk8egotQQvw(this, current);
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
								{
									num3 = 0;
								}
								continue;
							default:
								goto IL_0396;
							case 2:
								goto end_IL_034e;
							}
							break;
						}
						continue;
						end_IL_034e:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
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
			case 3:
				return;
			}
			try
			{
				while (true)
				{
					IL_0211:
					int num5;
					if (!enumerator.MoveNext())
					{
						num5 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
						{
							num5 = 5;
						}
						goto IL_0054;
					}
					goto IL_009e;
					IL_009e:
					current2 = enumerator.Current;
					num5 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
					{
						num5 = 8;
					}
					goto IL_0054;
					IL_0054:
					while (true)
					{
						switch (num5)
						{
						case 7:
							break;
						case 12:
							if (deactivatingModules.Contains((string)TIHVUOobQdEVVPZy6uvd(moduleRef)))
							{
								num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
								{
									num5 = 0;
								}
								continue;
							}
							goto IL_0211;
						case 2:
						case 3:
						case 13:
							moduleRef = prevMetadataModules[value2];
							num5 = 12;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
							{
								num5 = 12;
							}
							continue;
						default:
							ProcessDeletedMetadataItem(current2);
							num5 = 15;
							continue;
						case 8:
							currMetadata.TryGetValue(DmN37SobEks2fuJmC4C1(current2), out value);
							num5 = 11;
							continue;
						case 1:
							if (entityMetadata.Type == EntityMetadataType.InterfaceImplementation)
							{
								num5 = 5;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
								{
									num5 = 1;
								}
								continue;
							}
							goto case 2;
						case 10:
							entityMetadata = current2 as EntityMetadata;
							num5 = 4;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
							{
								num5 = 4;
							}
							continue;
						case 4:
							value2 = current2;
							num5 = 6;
							continue;
						case 14:
							value2 = current2;
							num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
							{
								num5 = 3;
							}
							continue;
						case 6:
							if (entityMetadata == null)
							{
								num5 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
								{
									num5 = 2;
								}
								continue;
							}
							goto case 1;
						case 15:
							goto IL_0211;
						case 5:
							if (prevMetadata.TryGetValue(gakq6OobfvJAprkvEFC2(entityMetadata), out value2))
							{
								num5 = 13;
								continue;
							}
							goto case 14;
						case 11:
							if (value == null)
							{
								num5 = 10;
								continue;
							}
							goto IL_0211;
						case 9:
							return;
						}
						break;
					}
					goto IL_009e;
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
				int num6 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
				{
					num6 = 0;
				}
				switch (num6)
				{
				case 0:
					break;
				}
			}
		}
	}

	protected virtual void ProcessMetadataItemChanges(AbstractMetadata metadata)
	{
		//Discarded unreachable code: IL_005f, IL_006e, IL_00b7
		int num = 6;
		int num2 = num;
		EntityMetadata entityMetadata = default(EntityMetadata);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				ProcessEntityMetadataChanges(entityMetadata);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
				{
					num2 = 4;
				}
				break;
			case 3:
				return;
			case 2:
				if (dqbLe5obCPq9twLJqUed(entityMetadata))
				{
					num2 = 3;
					break;
				}
				goto case 1;
			case 5:
				if (entityMetadata == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 4:
				return;
			case 0:
				return;
			case 6:
				entityMetadata = metadata as EntityMetadata;
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	protected virtual void ProcessEntityMetadataChanges(EntityMetadata metadata)
	{
		//Discarded unreachable code: IL_00fd, IL_02b2, IL_02c1, IL_02f4, IL_0303, IL_0313, IL_0327, IL_0374, IL_0383, IL_038e, IL_04a0, IL_04b3, IL_04c2, IL_055c, IL_056b, IL_05bd, IL_0628, IL_06c6, IL_06e4, IL_0788, IL_07be, IL_07c9, IL_07d3, IL_08bb, IL_08e6, IL_08f5, IL_09d8, IL_0a41, IL_0a77, IL_0a8a, IL_0a99, IL_0b0a, IL_0bd3, IL_0be2, IL_0c2c, IL_0d15, IL_0d28, IL_0d37
		int num = 46;
		_003C_003Ec__DisplayClass17_0 _003C_003Ec__DisplayClass17_ = default(_003C_003Ec__DisplayClass17_0);
		AbstractMetadata value = default(AbstractMetadata);
		List<TablePartMetadata>.Enumerator enumerator = default(List<TablePartMetadata>.Enumerator);
		EntityMetadata entityMetadata = default(EntityMetadata);
		string isGroupColumnName = default(string);
		SimpleTypeSettings simpleTypeSettings = default(SimpleTypeSettings);
		SimpleTypeSettings simpleTypeSettings2 = default(SimpleTypeSettings);
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		List<PropertyMetadata>.Enumerator enumerator2 = default(List<PropertyMetadata>.Enumerator);
		_003C_003Ec__DisplayClass17_1 _003C_003Ec__DisplayClass17_4 = default(_003C_003Ec__DisplayClass17_1);
		EntityPropertyMetadata entityPropertyMetadata = default(EntityPropertyMetadata);
		PropertyMetadata propertyMetadata2 = default(PropertyMetadata);
		int startTableActionsIndex = default(int);
		string tableName = default(string);
		string parentColumnName = default(string);
		_003C_003Ec__DisplayClass17_2 _003C_003Ec__DisplayClass17_3 = default(_003C_003Ec__DisplayClass17_2);
		_003C_003Ec__DisplayClass17_3 _003C_003Ec__DisplayClass17_2 = default(_003C_003Ec__DisplayClass17_3);
		TablePartMetadata tablePartMetadata = default(TablePartMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj2;
				object obj;
				switch (num2)
				{
				case 15:
					prevMetadata.TryGetValue(_003C_003Ec__DisplayClass17_.metadata.ImplementationUid, out value);
					num2 = 13;
					continue;
				case 7:
				case 16:
				case 39:
				case 54:
					enumerator = entityMetadata.TableParts.GetEnumerator();
					num2 = 9;
					continue;
				case 1:
					if (!DDYo5Pobn7938k5w0fhI(_003C_003Ec__DisplayClass17_.metadata))
					{
						num2 = 15;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
						{
							num2 = 31;
						}
						continue;
					}
					goto case 51;
				case 30:
					base.TablesCreatedActions.Add(new NewEntityAction(this, _003C_003Ec__DisplayClass17_.metadata));
					num2 = 35;
					continue;
				case 23:
					if (!jFdspcob2SPPIVFpZp9Q(_003C_003Ec__DisplayClass17_.metadata.IsGroupPropertyUid, Guid.Empty))
					{
						num2 = 37;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
						{
							num2 = 39;
						}
						continue;
					}
					goto case 29;
				case 38:
					if (PBkId4obVVbEnTesSK9P(entityMetadata))
					{
						num2 = 28;
						continue;
					}
					goto case 36;
				case 10:
					if (value != null)
					{
						num2 = 50;
						continue;
					}
					goto case 37;
				case 36:
					if (GoSmeTobSdkgVWAra1YL(_003C_003Ec__DisplayClass17_.metadata) == Guid.Empty)
					{
						num = 2;
						break;
					}
					goto case 4;
				case 44:
					return;
				case 40:
					base.TablesDeletedActions.Add(new DbUpdateAction(base.Transform, (string)j9HeB4obukWkAm8EyPOq(_003C_003Ec__DisplayClass17_.metadata), new string[1] { (string)qIR95KobvejQeGSTm33y(0x31326106 ^ 0x31322364) }, new object[1] { DmN37SobEks2fuJmC4C1(_003C_003Ec__DisplayClass17_.metadata) }, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xA592A41 ^ 0xA5B7B57)));
					num2 = 19;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
					{
						num2 = 6;
					}
					continue;
				case 47:
					isGroupColumnName = (string)jE1VN7obPG2JUAqJI4vB(simpleTypeSettings);
					num2 = 33;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
					{
						num2 = 10;
					}
					continue;
				case 53:
					obj2 = null;
					goto IL_0e7a;
				case 21:
					if (simpleTypeSettings2 == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
						{
							num2 = 7;
						}
						continue;
					}
					goto case 47;
				case 24:
					if (propertyMetadata == null)
					{
						num2 = 42;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
						{
							num2 = 35;
						}
						continue;
					}
					obj = SeXBgpobeNim7CurEAMC(propertyMetadata) as SimpleTypeSettings;
					goto IL_0e5e;
				case 3:
					try
					{
						while (true)
						{
							int num10;
							if (!enumerator2.MoveNext())
							{
								num10 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
								{
									num10 = 1;
								}
								goto IL_0392;
							}
							goto IL_040c;
							IL_040c:
							_003C_003Ec__DisplayClass17_4 = new _003C_003Ec__DisplayClass17_1();
							num10 = 2;
							goto IL_0392;
							IL_0392:
							while (true)
							{
								switch (num10)
								{
								case 4:
									uLoNkeobRWTde8qV8CRS(this, _003C_003Ec__DisplayClass17_.metadata, _003C_003Ec__DisplayClass17_4.propertyMetadata, entityMetadata, entityPropertyMetadata);
									num10 = 3;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
									{
										num10 = 1;
									}
									continue;
								case 3:
									break;
								case 5:
									goto IL_040c;
								case 2:
									_003C_003Ec__DisplayClass17_4.propertyMetadata = (EntityPropertyMetadata)enumerator2.Current;
									num10 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
									{
										num10 = 0;
									}
									continue;
								default:
									entityPropertyMetadata = (EntityPropertyMetadata)entityMetadata.Properties.FirstOrDefault(_003C_003Ec__DisplayClass17_4._003CProcessEntityMetadataChanges_003Eb__0);
									num10 = 4;
									continue;
								case 1:
									goto end_IL_03e6;
								}
								break;
							}
							continue;
							end_IL_03e6:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator2).Dispose();
						int num11 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
						{
							num11 = 0;
						}
						switch (num11)
						{
						case 0:
							break;
						}
					}
					goto case 5;
				case 41:
				case 52:
					if (!_003C_003Ec__DisplayClass17_.metadata.AllowCreateHeirs)
					{
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 38;
				case 5:
					enumerator2 = entityMetadata.Properties.GetEnumerator();
					num = 18;
					break;
				case 48:
					if (propertyMetadata2 == null)
					{
						num = 53;
						break;
					}
					obj2 = SeXBgpobeNim7CurEAMC(propertyMetadata2) as SimpleTypeSettings;
					goto IL_0e7a;
				default:
					if (!DDYo5Pobn7938k5w0fhI(entityMetadata))
					{
						num2 = 20;
						continue;
					}
					goto case 11;
				case 13:
				case 50:
					if (_003C_003Ec__DisplayClass17_.metadata != value)
					{
						if (value == null)
						{
							num2 = 30;
							continue;
						}
						entityMetadata = value as EntityMetadata;
						num2 = 17;
					}
					else
					{
						num2 = 44;
					}
					continue;
				case 46:
					_003C_003Ec__DisplayClass17_ = new _003C_003Ec__DisplayClass17_0();
					num2 = 45;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
					{
						num2 = 21;
					}
					continue;
				case 45:
					_003C_003Ec__DisplayClass17_.metadata = metadata;
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
					{
						num2 = 12;
					}
					continue;
				case 29:
					if (jFdspcob2SPPIVFpZp9Q(_003C_003Ec__DisplayClass17_.metadata.ParentPropertyUid, Guid.Empty))
					{
						num2 = 14;
						continue;
					}
					goto case 7;
				case 12:
					prevMetadata.TryGetValue(DmN37SobEks2fuJmC4C1(_003C_003Ec__DisplayClass17_.metadata), out value);
					num2 = 10;
					continue;
				case 51:
					if (PeNFtAobO0og5s85Gpgs(_003C_003Ec__DisplayClass17_.metadata) == HierarchyType.GroupAndElements)
					{
						goto case 23;
					}
					goto case 20;
				case 4:
				case 8:
				case 28:
					startTableActionsIndex = KbckdKobiYyR0e0WHwuK(base.TablesCreatedActions);
					num2 = 6;
					continue;
				case 34:
					if (simpleTypeSettings != null)
					{
						num2 = 21;
						continue;
					}
					goto case 7;
				case 6:
					enumerator2 = _003C_003Ec__DisplayClass17_.metadata.Properties.GetEnumerator();
					num2 = 3;
					continue;
				case 19:
					needRecreateConstraints = true;
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
					{
						num2 = 1;
					}
					continue;
				case 37:
					if (_003C_003Ec__DisplayClass17_.metadata.Type == EntityMetadataType.InterfaceImplementation)
					{
						num2 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
						{
							num2 = 15;
						}
						continue;
					}
					goto case 13;
				case 49:
					return;
				case 42:
					obj = null;
					goto IL_0e5e;
				case 35:
					return;
				case 2:
					base.TablesCreatedActions.Add(new DbCreateColumnAction(base.Transform, (string)j9HeB4obukWkAm8EyPOq(_003C_003Ec__DisplayClass17_.metadata), new Column((string)qIR95KobvejQeGSTm33y(-1751176224 ^ -1751160446), DbType.Guid)));
					num2 = 40;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
					{
						num2 = 25;
					}
					continue;
				case 43:
					base.TablesCreatedActions.Add(new ChangeEntityAction(this, _003C_003Ec__DisplayClass17_.metadata, entityMetadata));
					num2 = 41;
					continue;
				case 14:
					tableName = (string)j9HeB4obukWkAm8EyPOq(_003C_003Ec__DisplayClass17_.metadata);
					num2 = 32;
					continue;
				case 27:
					base.TablesDeletedActions.Add(new DbUpdateIsGroupColumnAction(base.Transform, tableName, isGroupColumnName, parentColumnName));
					num2 = 16;
					continue;
				case 18:
					try
					{
						while (true)
						{
							IL_0879:
							int num6;
							if (!enumerator2.MoveNext())
							{
								num6 = 5;
								goto IL_07d7;
							}
							goto IL_07f9;
							IL_07d7:
							while (true)
							{
								switch (num6)
								{
								case 2:
									break;
								case 1:
									_003C_003Ec__DisplayClass17_3.oldPropertyMetadata = (EntityPropertyMetadata)enumerator2.Current;
									num6 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
									{
										num6 = 0;
									}
									continue;
								default:
									if ((EntityPropertyMetadata)_003C_003Ec__DisplayClass17_.metadata.Properties.FirstOrDefault(_003C_003Ec__DisplayClass17_3._003CProcessEntityMetadataChanges_003Eb__1) == null)
									{
										num6 = 3;
										continue;
									}
									goto IL_0879;
								case 4:
									goto IL_0879;
								case 3:
									try
									{
										base.TablesDeletedActions.Add(new DeletePropertyAction(this, _003C_003Ec__DisplayClass17_.metadata, _003C_003Ec__DisplayClass17_3.oldPropertyMetadata, ref startTableActionsIndex));
										int num7 = 5;
										while (true)
										{
											switch (num7)
											{
											case 1:
												break;
											default:
												needRecreateConstraints = true;
												num7 = 2;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
												{
													num7 = 1;
												}
												continue;
											case 4:
												if (!_003C_003Ec__DisplayClass17_.metadata.IsUnique)
												{
													num7 = 3;
													continue;
												}
												break;
											case 5:
												if (hky8mPobKfZK3oy0mlNJ(QaeEHfobqLG62l2dFAWy(_003C_003Ec__DisplayClass17_3.oldPropertyMetadata), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34A6D230 ^ 0x34A6BDA2)))
												{
													num7 = 4;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
													{
														num7 = 3;
													}
													continue;
												}
												break;
											case 3:
												if (!wbEh2vobX2YmLKjrVTVs(GoSmeTobSdkgVWAra1YL(_003C_003Ec__DisplayClass17_.metadata), Guid.Empty))
												{
													num7 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
													{
														num7 = 1;
													}
													continue;
												}
												goto default;
											case 2:
												break;
											}
											break;
										}
									}
									catch (Exception ex)
									{
										int num8 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
										{
											num8 = 0;
										}
										while (true)
										{
											switch (num8)
											{
											default:
												uZ3SrMobkDN6qTaVKWvZ(vELDWgobTRh3h9ejUk7Q(), gnAQ19obZTRBE0PrrqGx(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x638095EB ^ 0x6382C4D3), QaeEHfobqLG62l2dFAWy(entityMetadata), QaeEHfobqLG62l2dFAWy(_003C_003Ec__DisplayClass17_3.oldPropertyMetadata)), ex);
												num8 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
												{
													num8 = 1;
												}
												continue;
											case 1:
												break;
											}
											break;
										}
									}
									goto IL_0879;
								case 5:
									goto end_IL_0879;
								}
								break;
							}
							goto IL_07f9;
							IL_07f9:
							_003C_003Ec__DisplayClass17_3 = new _003C_003Ec__DisplayClass17_2();
							num6 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
							{
								num6 = 0;
							}
							goto IL_07d7;
							continue;
							end_IL_0879:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator2).Dispose();
						int num9 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
						{
							num9 = 0;
						}
						switch (num9)
						{
						case 0:
							break;
						}
					}
					goto default;
				case 11:
					if (entityMetadata.HierarchyType != 0)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 20;
				case 22:
					propertyMetadata2 = _003C_003Ec__DisplayClass17_.metadata.Properties.FirstOrDefault(_003C_003Ec__DisplayClass17_._003CProcessEntityMetadataChanges_003Eb__3);
					num2 = 48;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
					{
						num2 = 41;
					}
					continue;
				case 9:
					try
					{
						while (true)
						{
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 5;
								goto IL_0b18;
							}
							goto IL_0b85;
							IL_0c9d:
							if (rLBBp3ob1V7seHSNwmYq(_003C_003Ec__DisplayClass17_2.oldTablePartMetadata))
							{
								continue;
							}
							num3 = 10;
							goto IL_0b18;
							IL_0b85:
							_003C_003Ec__DisplayClass17_2 = new _003C_003Ec__DisplayClass17_3();
							int num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
							{
								num4 = 1;
							}
							goto IL_0b1c;
							IL_0b18:
							num4 = num3;
							goto IL_0b1c;
							IL_0b1c:
							while (true)
							{
								switch (num4)
								{
								case 5:
									return;
								case 2:
									if (tablePartMetadata != null)
									{
										num4 = 4;
										continue;
									}
									goto case 12;
								case 9:
									goto IL_0b85;
								case 1:
									_003C_003Ec__DisplayClass17_2.oldTablePartMetadata = enumerator.Current;
									num4 = 11;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
									{
										num4 = 8;
									}
									continue;
								case 3:
									tablePartMetadata = _003C_003Ec__DisplayClass17_.metadata.TableParts.FirstOrDefault(_003C_003Ec__DisplayClass17_2._003CProcessEntityMetadataChanges_003Eb__5);
									num4 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
									{
										num4 = 1;
									}
									continue;
								case 11:
									if (_003C_003Ec__DisplayClass17_2.oldTablePartMetadata == null)
									{
										num4 = 7;
										continue;
									}
									goto IL_0c9d;
								case 4:
									if (!rLBBp3ob1V7seHSNwmYq(tablePartMetadata))
									{
										num4 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
										{
											num4 = 12;
										}
										continue;
									}
									break;
								case 12:
									DeleteSubTableParts(_003C_003Ec__DisplayClass17_2.oldTablePartMetadata);
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
									{
										num4 = 0;
									}
									continue;
								case 8:
									goto IL_0c9d;
								case 10:
									if (_003C_003Ec__DisplayClass17_.metadata.TableParts.FirstOrDefault(_003C_003Ec__DisplayClass17_2._003CProcessEntityMetadataChanges_003Eb__4) != null)
									{
										num4 = 6;
										continue;
									}
									goto case 3;
								}
								break;
							}
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
						{
							num5 = 0;
						}
						switch (num5)
						{
						case 0:
							break;
						}
					}
				case 32:
					propertyMetadata = _003C_003Ec__DisplayClass17_.metadata.Properties.FirstOrDefault(_003C_003Ec__DisplayClass17_._003CProcessEntityMetadataChanges_003Eb__2);
					num2 = 22;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
					{
						num2 = 24;
					}
					continue;
				case 33:
					parentColumnName = (string)jE1VN7obPG2JUAqJI4vB(simpleTypeSettings2);
					num2 = 15;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
					{
						num2 = 27;
					}
					continue;
				case 26:
					throw new DbModelException((string)gnAQ19obZTRBE0PrrqGx(nWpKsFob8KMuUwOEbHQY(qIR95KobvejQeGSTm33y(0xD3DEF7E ^ 0xD3FBFE8)), _003C_003Ec__DisplayClass17_.metadata.FullTypeName, value.GetType().FullName));
				case 25:
					if (!myJ0rUobI0gEkYVqH1ca(j9HeB4obukWkAm8EyPOq(_003C_003Ec__DisplayClass17_.metadata), j9HeB4obukWkAm8EyPOq(entityMetadata)))
					{
						num2 = 52;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 43;
				case 17:
					if (entityMetadata != null)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
						{
							num2 = 25;
						}
						continue;
					}
					goto case 26;
				case 20:
				case 31:
					{
						num2 = 45;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
						{
							num2 = 54;
						}
						continue;
					}
					IL_0e5e:
					simpleTypeSettings = (SimpleTypeSettings)obj;
					num = 22;
					break;
					IL_0e7a:
					simpleTypeSettings2 = (SimpleTypeSettings)obj2;
					num = 34;
					break;
				}
				break;
			}
		}
	}

	protected void DeleteSubTableParts(TablePartMetadata tablePartMetadata)
	{
		//Discarded unreachable code: IL_003a, IL_0049, IL_00ed, IL_0100, IL_010f, IL_016b, IL_01a6, IL_01b5, IL_0258, IL_0262, IL_031c, IL_032f, IL_033e, IL_0375, IL_0388, IL_0397, IL_03ea, IL_0452
		int num = 1;
		int num2 = num;
		List<TablePartMetadata>.Enumerator enumerator = default(List<TablePartMetadata>.Enumerator);
		TablePartMetadata current = default(TablePartMetadata);
		List<PropertyMetadata>.Enumerator enumerator2 = default(List<PropertyMetadata>.Enumerator);
		PropertyMetadata current2 = default(PropertyMetadata);
		List<Table>.Enumerator enumerator3 = default(List<Table>.Enumerator);
		Table current3 = default(Table);
		while (true)
		{
			switch (num2)
			{
			case 3:
				try
				{
					while (true)
					{
						IL_0085:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
							{
								num3 = 0;
							}
							goto IL_0058;
						}
						goto IL_0072;
						IL_0072:
						current = enumerator.Current;
						num3 = 3;
						goto IL_0058;
						IL_0058:
						while (true)
						{
							switch (num3)
							{
							case 1:
								goto IL_0072;
							case 2:
								goto IL_0085;
							case 3:
							{
								DeleteSubTableParts(current);
								int num4 = 2;
								num3 = num4;
								continue;
							}
							case 0:
								break;
							}
							break;
						}
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num5 = 0;
					}
					switch (num5)
					{
					case 0:
						break;
					}
				}
				goto case 2;
			case 4:
				return;
			default:
				enumerator = tablePartMetadata.TableParts.GetEnumerator();
				num2 = 3;
				break;
			case 2:
				num2 = 5;
				break;
			case 5:
				try
				{
					DbDeleteTableAction item = new DbDeleteTableAction(base.Transform, tablePartMetadata.TableName);
					int num6 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
					{
						num6 = 1;
					}
					while (true)
					{
						switch (num6)
						{
						default:
							return;
						case 0:
							return;
						case 1:
							enumerator2 = tablePartMetadata.Properties.GetEnumerator();
							num6 = 2;
							continue;
						case 2:
							try
							{
								while (true)
								{
									IL_0205:
									int num7;
									if (!enumerator2.MoveNext())
									{
										num7 = 3;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
										{
											num7 = 4;
										}
										goto IL_01c4;
									}
									goto IL_01e2;
									IL_01e2:
									current2 = enumerator2.Current;
									num7 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
									{
										num7 = 0;
									}
									goto IL_01c4;
									IL_01c4:
									while (true)
									{
										switch (num7)
										{
										case 2:
											break;
										case 1:
											goto IL_0205;
										default:
										{
											enumerator3 = DbModelHelper.GetPropertyDbStructures(tablePartMetadata, (EntityPropertyMetadata)current2).Tables.GetEnumerator();
											int num10 = 3;
											num7 = num10;
											continue;
										}
										case 3:
											try
											{
												while (true)
												{
													int num8;
													if (!enumerator3.MoveNext())
													{
														num8 = 1;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
														{
															num8 = 0;
														}
														goto IL_0266;
													}
													goto IL_02a6;
													IL_02a6:
													current3 = enumerator3.Current;
													num8 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
													{
														num8 = 0;
													}
													goto IL_0266;
													IL_0266:
													while (true)
													{
														switch (num8)
														{
														case 2:
															break;
														case 3:
															goto IL_02a6;
														default:
															base.TablesDeletedActions.Add(new DbDeleteTableAction(base.Transform, (string)psUqrsobNrtwRxujMK24(current3)));
															num8 = 2;
															continue;
														case 1:
															goto end_IL_0280;
														}
														break;
													}
													continue;
													end_IL_0280:
													break;
												}
											}
											finally
											{
												((IDisposable)enumerator3).Dispose();
												int num9 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
												{
													num9 = 0;
												}
												switch (num9)
												{
												case 0:
													break;
												}
											}
											goto IL_0205;
										case 4:
											goto end_IL_0205;
										}
										break;
									}
									goto IL_01e2;
									continue;
									end_IL_0205:
									break;
								}
							}
							finally
							{
								((IDisposable)enumerator2).Dispose();
								int num11 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
								{
									num11 = 0;
								}
								switch (num11)
								{
								case 0:
									break;
								}
							}
							break;
						case 3:
							break;
						}
						base.TablesDeletedActions.Add(item);
						num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
						{
							num6 = 0;
						}
					}
				}
				catch (Exception ex)
				{
					int num12 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
					{
						num12 = 0;
					}
					while (true)
					{
						switch (num12)
						{
						case 1:
							return;
						}
						P34K8gob3TkRdjQ59amL(vELDWgobTRh3h9ejUk7Q(), string.Format((string)qIR95KobvejQeGSTm33y(-521266112 ^ -521384502), tablePartMetadata.Name, tablePartMetadata.TableName), ex);
						num12 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
						{
							num12 = 0;
						}
					}
				}
			case 1:
				if (tablePartMetadata.TableParts != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	protected virtual void ProcessEntityPropertyMetadataChanges(EntityMetadata metadata, EntityPropertyMetadata propertyMetadata, EntityMetadata oldMetadata, EntityPropertyMetadata oldPropertyMetadata)
	{
		//Discarded unreachable code: IL_00c5, IL_0287, IL_0296, IL_02a6, IL_03b3, IL_03c2, IL_04d2, IL_0508, IL_05e3, IL_069b
		int num = 9;
		_003C_003Ec__DisplayClass19_0 _003C_003Ec__DisplayClass19_ = default(_003C_003Ec__DisplayClass19_0);
		IPropertyTypeInfo propertyTypeInfo = default(IPropertyTypeInfo);
		IPropertyTypeInfo propertyTypeInfo2 = default(IPropertyTypeInfo);
		string propertyTypeDisplayName = default(string);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 10:
					if (SeXBgpobeNim7CurEAMC(oldPropertyMetadata) != null)
					{
						num = 24;
						break;
					}
					return;
				case 9:
					_003C_003Ec__DisplayClass19_ = new _003C_003Ec__DisplayClass19_0();
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
					{
						num2 = 7;
					}
					continue;
				case 8:
					_003C_003Ec__DisplayClass19_.metadata = metadata;
					num2 = 15;
					continue;
				case 3:
					if (hNac88obp6warxwvY3bC(_003C_003Ec__DisplayClass19_.metadata))
					{
						num2 = 36;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
						{
							num2 = 10;
						}
						continue;
					}
					return;
				case 1:
					if (hNac88obp6warxwvY3bC(_003C_003Ec__DisplayClass19_.metadata))
					{
						num2 = 12;
						continue;
					}
					goto case 21;
				case 30:
				{
					List<IDbAction> list = base.ForeignKeysCreatedActions;
					ITransformationProvider transform = base.Transform;
					Index index = new Index();
					jpKUQMobDaRFgrqClaZD(index, cxEXv4obayf6pPYOwsak(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2ACE37D ^ 0x2AEB293), j9HeB4obukWkAm8EyPOq(_003C_003Ec__DisplayClass19_.metadata)));
					zkeN31obt4Fv0xx7kf1E(index, j9HeB4obukWkAm8EyPOq(_003C_003Ec__DisplayClass19_.metadata));
					index.Columns = new List<string> { z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87344155) };
					list.Add(new DbCreateUniqueIndexAction(transform, index));
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
					{
						num2 = 19;
					}
					continue;
				}
				case 25:
					propertyTypeInfo = (IPropertyTypeInfo)pwRxABobA2OrFRos66rC(MetadataService, propertyMetadata.TypeUid, IxgolWob6qRxyFEnBoxu(propertyMetadata));
					num2 = 4;
					continue;
				case 36:
					if (wbEh2vobX2YmLKjrVTVs(GoSmeTobSdkgVWAra1YL(_003C_003Ec__DisplayClass19_.metadata), Guid.Empty))
					{
						num2 = 16;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
						{
							num2 = 6;
						}
						continue;
					}
					return;
				case 6:
					if (!hky8mPobKfZK3oy0mlNJ(QaeEHfobqLG62l2dFAWy(propertyMetadata), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-234299632 ^ -234311550)))
					{
						num2 = 26;
						continue;
					}
					goto case 3;
				case 23:
					if (!bto49BobwI9bJck2GyDT(oldPropertyMetadata))
					{
						num2 = 32;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
						{
							num2 = 27;
						}
						continue;
					}
					goto case 21;
				case 37:
					needRecreateConstraints = true;
					num = 18;
					break;
				case 12:
					if (wbEh2vobX2YmLKjrVTVs(_003C_003Ec__DisplayClass19_.metadata.BaseClassUid, Guid.Empty))
					{
						num = 35;
						break;
					}
					goto case 21;
				case 19:
				case 31:
					base.TablesDeletedActions.Add(new UidInitializeAction(this, _003C_003Ec__DisplayClass19_.metadata, propertyMetadata, base.Session));
					num2 = 37;
					continue;
				case 35:
					if (!bto49BobwI9bJck2GyDT(propertyMetadata))
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
						{
							num2 = 34;
						}
						continue;
					}
					goto case 23;
				case 15:
					if (oldPropertyMetadata == null)
					{
						num = 39;
						break;
					}
					if (!hky8mPobKfZK3oy0mlNJ(QaeEHfobqLG62l2dFAWy(propertyMetadata), qIR95KobvejQeGSTm33y(-105199646 ^ -105207696)))
					{
						num2 = 21;
						continue;
					}
					goto case 1;
				case 24:
					if (propertyMetadata.Settings != SeXBgpobeNim7CurEAMC(oldPropertyMetadata))
					{
						num2 = 40;
						continue;
					}
					return;
				case 40:
					new ChangePropertyAction(this, _003C_003Ec__DisplayClass19_.metadata, propertyMetadata, oldPropertyMetadata);
					num2 = 7;
					continue;
				case 26:
					return;
				case 2:
					if (!jFdspcob2SPPIVFpZp9Q(IxgolWob6qRxyFEnBoxu(propertyMetadata), IxgolWob6qRxyFEnBoxu(oldPropertyMetadata)))
					{
						num2 = 18;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
						{
							num2 = 27;
						}
						continue;
					}
					goto case 14;
				case 38:
					propertyTypeInfo2 = (IPropertyTypeInfo)pwRxABobA2OrFRos66rC(MetadataService, zbIT8gob4Xrdk5sPA8Un(oldPropertyMetadata), IxgolWob6qRxyFEnBoxu(oldPropertyMetadata));
					num2 = 25;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
					{
						num2 = 6;
					}
					continue;
				case 4:
					if (propertyTypeInfo2 != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 17;
				case 17:
					throw new DbModelException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1FFEF86A ^ 0x1FFCA996), propertyMetadata.Name, QaeEHfobqLG62l2dFAWy(_003C_003Ec__DisplayClass19_.metadata), zbIT8gob4Xrdk5sPA8Un(oldPropertyMetadata)));
				default:
					if (propertyTypeInfo == null)
					{
						num2 = 11;
						continue;
					}
					propertyTypeDisplayName = propertyTypeInfo2.GetPropertyTypeDisplayName(oldPropertyMetadata);
					num2 = 29;
					continue;
				case 13:
					needRecreateConstraints = true;
					num2 = 33;
					continue;
				case 7:
					return;
				case 28:
					return;
				case 39:
					base.TablesCreatedActions.Add(new NewPropertyAction(this, _003C_003Ec__DisplayClass19_.metadata, propertyMetadata));
					num = 6;
					break;
				case 21:
				case 33:
				case 34:
					if (jFdspcob2SPPIVFpZp9Q(propertyMetadata.TypeUid, zbIT8gob4Xrdk5sPA8Un(oldPropertyMetadata)))
					{
						num2 = 22;
						continue;
					}
					goto case 2;
				case 14:
				case 22:
					if (GetProcessEntityPropertyMetadataChangesHack().Contains((string)uNvZP7obHutjOLc3DoFB(QaeEHfobqLG62l2dFAWy(_003C_003Ec__DisplayClass19_.metadata), qIR95KobvejQeGSTm33y(0x3B36AB09 ^ 0x3B36B1CD), QaeEHfobqLG62l2dFAWy(propertyMetadata))))
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 38;
				case 18:
					return;
				case 16:
					if (ComponentManager.Current.GetExtensionPoints<IIgnoreUidUI>().Any(_003C_003Ec__DisplayClass19_._003CProcessEntityPropertyMetadataChanges_003Eb__0))
					{
						num = 31;
						break;
					}
					goto case 30;
				case 32:
					base.OnCompleteActions.Add(new UidInitializeAction(this, _003C_003Ec__DisplayClass19_.metadata, propertyMetadata, base.Session));
					num2 = 13;
					continue;
				case 11:
					throw new DbModelException(SR.T((string)qIR95KobvejQeGSTm33y(-882126494 ^ -882278242), QaeEHfobqLG62l2dFAWy(propertyMetadata), QaeEHfobqLG62l2dFAWy(_003C_003Ec__DisplayClass19_.metadata), zbIT8gob4Xrdk5sPA8Un(propertyMetadata)));
				case 29:
					text = (string)eChi4wob7Q9DXaGjhcb4(propertyTypeInfo, propertyMetadata);
					num2 = 20;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
					{
						num2 = 17;
					}
					continue;
				case 20:
					throw new DbModelException(SR.T((string)qIR95KobvejQeGSTm33y(0x5F3078B6 ^ 0x5F322A2A), propertyMetadata.Name, _003C_003Ec__DisplayClass19_.metadata.Name, propertyTypeDisplayName, text));
				case 5:
				case 27:
					if (SeXBgpobeNim7CurEAMC(propertyMetadata) == null)
					{
						num2 = 28;
						continue;
					}
					goto case 10;
				}
				break;
			}
		}
	}

	protected virtual void ProcessDeletedMetadataItem(AbstractMetadata metadata)
	{
		//Discarded unreachable code: IL_0084, IL_0093
		int num = 2;
		int num2 = num;
		EntityMetadata entityMetadata = default(EntityMetadata);
		while (true)
		{
			switch (num2)
			{
			case 5:
				if (entityMetadata.IsInterfaceType)
				{
					num2 = 4;
					continue;
				}
				break;
			case 2:
				entityMetadata = metadata as EntityMetadata;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
				{
					num2 = 1;
				}
				continue;
			case 1:
				if (entityMetadata != null)
				{
					num2 = 5;
					continue;
				}
				return;
			case 3:
				return;
			case 4:
				return;
			}
			Lr0TxIobxQDBhfNZd9Eq(this, entityMetadata);
			num2 = 3;
		}
	}

	protected virtual void ProcessDeletedEntityMetadata(EntityMetadata metadata)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				needRecreateConstraints = true;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
				{
					num2 = 0;
				}
				break;
			default:
				base.TablesDeletedActions.Add(new DeleteEntityAction(this, metadata));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			}
		}
	}

	private IList<string> GetProcessEntityPropertyMetadataChangesHack()
	{
		if (processEntityPropertyMetadataChangesHack != null)
		{
			return processEntityPropertyMetadataChangesHack;
		}
		try
		{
			_processEntityPropertyMetadataChangesHackWriteKey = Registry.LocalMachine.OpenSubKey(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x17ADCCD8 ^ 0x17AD52DC), writable: true);
			if (_processEntityPropertyMetadataChangesHackWriteKey != null)
			{
				string name = Guid.NewGuid().ToString();
				_processEntityPropertyMetadataChangesHackWriteKey.SetValue(name, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886645757));
				_processEntityPropertyMetadataChangesHackWriteKey.DeleteValue(name);
			}
		}
		catch (IOException)
		{
			_processEntityPropertyMetadataChangesHackWriteKey = null;
		}
		catch (SecurityException)
		{
			_processEntityPropertyMetadataChangesHackWriteKey = null;
		}
		catch (UnauthorizedAccessException)
		{
			_processEntityPropertyMetadataChangesHackWriteKey = null;
		}
		if (_processEntityPropertyMetadataChangesHackWriteKey != null)
		{
			string text = _processEntityPropertyMetadataChangesHackWriteKey.GetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3630F361 ^ 0x3632A001)) as string;
			if (!text.IsNullOrWhiteSpace())
			{
				processEntityPropertyMetadataChangesHack = text.Split(new char[1] { ';' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
			}
		}
		processEntityPropertyMetadataChangesHack = processEntityPropertyMetadataChangesHack ?? new string[0];
		return processEntityPropertyMetadataChangesHack;
	}

	private void RemoveProcessEntityPropertyMetadataChangesHack()
	{
		//Discarded unreachable code: IL_009a, IL_00a9
		int num = 5;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					iOjfLwob0urUEgPqhoi9(_processEntityPropertyMetadataChangesHackWriteKey, qIR95KobvejQeGSTm33y(0x269E5FCA ^ 0x269C0CAA));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					if (_processEntityPropertyMetadataChangesHackWriteKey == null)
					{
						num2 = 4;
						continue;
					}
					goto default;
				case 1:
				case 4:
					processEntityPropertyMetadataChangesHack = new string[0];
					num2 = 3;
					continue;
				case 2:
					return;
				case 3:
					break;
				}
				break;
			}
			_processEntityPropertyMetadataChangesHackWriteKey = null;
			num = 2;
		}
	}

	private void LoadCurrentMetadata()
	{
		//Discarded unreachable code: IL_005b, IL_00d2, IL_01cf, IL_0224, IL_0254, IL_0273, IL_0282, IL_029f, IL_02ae
		int num = 4;
		int num2 = num;
		IEnumerator<AssemblyModelsMetadata> enumerator = default(IEnumerator<AssemblyModelsMetadata>);
		AssemblyModelsMetadata current = default(AssemblyModelsMetadata);
		ModuleRef value = default(ModuleRef);
		int num4 = default(int);
		AbstractMetadata metadata = default(AbstractMetadata);
		AbstractMetadata[] array = default(AbstractMetadata[]);
		while (true)
		{
			switch (num2)
			{
			case 4:
				D9XgoIobBbfV8d0grcZV(currMetadata);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				try
				{
					while (true)
					{
						int num3;
						if (!a6Xjbsooc1RoelgwJJWa(enumerator))
						{
							num3 = 6;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
							{
								num3 = 7;
							}
							goto IL_0069;
						}
						goto IL_0122;
						IL_0122:
						current = enumerator.Current;
						num3 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
						{
							num3 = 11;
						}
						goto IL_0069;
						IL_0069:
						while (true)
						{
							switch (num3)
							{
							case 5:
							{
								ModuleRef moduleRef = new ModuleRef();
								kPebmFobypcVVrFP5d7B(moduleRef, current.Name);
								value = moduleRef;
								num3 = 8;
								continue;
							}
							case 10:
								num4++;
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
								{
									num3 = 0;
								}
								continue;
							case 3:
								break;
							case 9:
								goto IL_0122;
							case 2:
								AddMetadataToDictionary(currMetadata, currMetadataModules, metadata, value);
								num3 = 10;
								continue;
							case 4:
							case 12:
								metadata = array[num4];
								num3 = 2;
								continue;
							case 14:
								num4 = 0;
								num3 = 6;
								continue;
							default:
								if (num4 < array.Length)
								{
									int num5 = 4;
									num3 = num5;
									continue;
								}
								break;
							case 8:
								moduleRefs[current.Name] = value;
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
								{
									num3 = 1;
								}
								continue;
							case 1:
							case 13:
								array = (AbstractMetadata[])zLHD4gobMPBpLIyGZ6Wy(current);
								num3 = 14;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
								{
									num3 = 8;
								}
								continue;
							case 11:
								if (moduleRefs.TryGetValue((string)CjDwcyobm1tkAWd4ZShC(current), out value))
								{
									num3 = 13;
									continue;
								}
								goto case 5;
							case 7:
								return;
							}
							break;
						}
					}
				}
				finally
				{
					int num6;
					if (enumerator == null)
					{
						num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
						{
							num6 = 0;
						}
						goto IL_0258;
					}
					goto IL_028d;
					IL_028d:
					VJ6qT2oosW0aSBDWnQVE(enumerator);
					num6 = 2;
					goto IL_0258;
					IL_0258:
					switch (num6)
					{
					default:
						goto end_IL_0233;
					case 0:
						goto end_IL_0233;
					case 1:
						break;
					case 2:
						goto end_IL_0233;
					}
					goto IL_028d;
					end_IL_0233:;
				}
			default:
				enumerator = MetadataService.GetAssemblyModelsMetadataList().GetEnumerator();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				d1ATmaobWrN6aZpTfQR7(currMetadataModules);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	private void LoadPreviousMetadata()
	{
		//Discarded unreachable code: IL_005b, IL_006a, IL_01ee, IL_01fd, IL_024e, IL_0286, IL_0295
		int num = 2;
		int num2 = num;
		IEnumerator<AssemblyModelsMetadata> enumerator = default(IEnumerator<AssemblyModelsMetadata>);
		AssemblyModelsMetadata current = default(AssemblyModelsMetadata);
		ModuleRef value = default(ModuleRef);
		int num4 = default(int);
		AbstractMetadata[] array = default(AbstractMetadata[]);
		AbstractMetadata metadata = default(AbstractMetadata);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				D9XgoIobBbfV8d0grcZV(prevMetadata);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				try
				{
					while (true)
					{
						IL_01c3:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 4;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
							{
								num3 = 2;
							}
							goto IL_0079;
						}
						goto IL_00b7;
						IL_00b7:
						current = enumerator.Current;
						num3 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
						{
							num3 = 7;
						}
						goto IL_0079;
						IL_0079:
						while (true)
						{
							switch (num3)
							{
							case 12:
								break;
							case 10:
								moduleRefs[(string)CjDwcyobm1tkAWd4ZShC(current)] = value;
								num3 = 9;
								continue;
							case 7:
								if (!moduleRefs.TryGetValue((string)CjDwcyobm1tkAWd4ZShC(current), out value))
								{
									num3 = 5;
									continue;
								}
								goto case 9;
							case 5:
							{
								ModuleRef moduleRef = new ModuleRef();
								kPebmFobypcVVrFP5d7B(moduleRef, CjDwcyobm1tkAWd4ZShC(current));
								value = moduleRef;
								int num5 = 10;
								num3 = num5;
								continue;
							}
							default:
								if (num4 >= array.Length)
								{
									num3 = 11;
									continue;
								}
								goto case 6;
							case 6:
								metadata = array[num4];
								num3 = 3;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
								{
									num3 = 0;
								}
								continue;
							case 8:
								num4++;
								num3 = 2;
								continue;
							case 9:
								array = (AbstractMetadata[])zLHD4gobMPBpLIyGZ6Wy(current);
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
								{
									num3 = 1;
								}
								continue;
							case 1:
								num4 = 0;
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
								{
									num3 = 0;
								}
								continue;
							case 11:
								goto IL_01c3;
							case 3:
								AddMetadataToDictionary(prevMetadata, prevMetadataModules, metadata, value);
								num3 = 8;
								continue;
							case 4:
								return;
							}
							break;
						}
						goto IL_00b7;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num6 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
						{
							num6 = 1;
						}
						while (true)
						{
							switch (num6)
							{
							case 1:
								enumerator.Dispose();
								num6 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
								{
									num6 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
				}
			case 3:
				enumerator = MetadataService.GetPreviousAssemblyModelsMetadataList().GetEnumerator();
				num2 = 4;
				break;
			case 1:
				prevMetadataModules.Clear();
				num2 = 3;
				break;
			case 0:
				return;
			}
		}
	}

	private void AddMetadataToDictionary(Dictionary<Guid, AbstractMetadata> dictionary, Dictionary<AbstractMetadata, ModuleRef> modulesDict, AbstractMetadata metadata, ModuleRef moduleRef)
	{
		dictionary[metadata.Uid] = metadata;
		modulesDict[metadata] = moduleRef;
		if (!(metadata is ICompositeMetadata compositeMetadata))
		{
			return;
		}
		IEnumerable<IMetadata> compositeParts = compositeMetadata.GetCompositeParts();
		if (compositeParts == null)
		{
			return;
		}
		foreach (IMetadata item in compositeParts)
		{
			if (item is AbstractMetadata metadata2)
			{
				AddMetadataToDictionary(dictionary, modulesDict, metadata2, moduleRef);
			}
		}
	}

	private void SaveMetadata()
	{
		//Discarded unreachable code: IL_0076, IL_017f, IL_0229, IL_0248, IL_0278, IL_029b, IL_02aa, IL_02b5, IL_034b, IL_035e, IL_036d, IL_0406, IL_0410, IL_048d, IL_049c, IL_04c2, IL_0510, IL_065e, IL_06c1, IL_06f9, IL_0708
		int num = 6;
		int num2 = num;
		IEnumerable<AssemblyModelsMetadata> previousAssemblyModelsMetadataList = default(IEnumerable<AssemblyModelsMetadata>);
		IEnumerator<AssemblyModelsMetadata> enumerator = default(IEnumerator<AssemblyModelsMetadata>);
		_003C_003Ec__DisplayClass50_0 _003C_003Ec__DisplayClass50_2 = default(_003C_003Ec__DisplayClass50_0);
		bool flag = default(bool);
		AssemblyModelsMetadata assemblyModelsMetadata = default(AssemblyModelsMetadata);
		List<NamespaceMetadata.TreeNode>.Enumerator enumerator2 = default(List<NamespaceMetadata.TreeNode>.Enumerator);
		IEnumerable<AssemblyModelsMetadata> assemblyModelsMetadataList = default(IEnumerable<AssemblyModelsMetadata>);
		_003C_003Ec__DisplayClass50_1 _003C_003Ec__DisplayClass50_ = default(_003C_003Ec__DisplayClass50_1);
		NamespaceMetadata.TreeNode current = default(NamespaceMetadata.TreeNode);
		while (true)
		{
			switch (num2)
			{
			case 5:
				previousAssemblyModelsMetadataList = MetadataService.GetPreviousAssemblyModelsMetadataList();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
				{
					num2 = 1;
				}
				continue;
			case 3:
				return;
			case 8:
				try
				{
					while (true)
					{
						int num5;
						if (!a6Xjbsooc1RoelgwJJWa(enumerator))
						{
							num5 = 11;
							goto IL_0084;
						}
						goto IL_0129;
						IL_0084:
						while (true)
						{
							switch (num5)
							{
							case 1:
							case 8:
								break;
							default:
							{
								pld11pobJSyldIpiBuoa(_003C_003Ec__DisplayClass50_2.newMetadata, AssemblyModelsMetadataStatus.Runned);
								int num6 = 4;
								num5 = num6;
								continue;
							}
							case 9:
								if (_003C_003Ec__DisplayClass50_2.newMetadata.Id > 0)
								{
									num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
									{
										num5 = 0;
									}
									continue;
								}
								goto case 3;
							case 6:
								flag = true;
								num5 = 9;
								continue;
							case 10:
								goto IL_0129;
							case 5:
								_003C_003Ec__DisplayClass50_2.newMetadata = enumerator.Current;
								num5 = 7;
								continue;
							case 2:
								if (_003C_003Ec__DisplayClass50_2.newMetadata != assemblyModelsMetadata)
								{
									num5 = 6;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
									{
										num5 = 6;
									}
									continue;
								}
								break;
							case 7:
								assemblyModelsMetadata = previousAssemblyModelsMetadataList.FirstOrDefault(_003C_003Ec__DisplayClass50_2._003CSaveMetadata_003Eb__0);
								num5 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
								{
									num5 = 1;
								}
								continue;
							case 4:
								base.Session.Merge<AssemblyModelsMetadata>(_003C_003Ec__DisplayClass50_2.newMetadata);
								num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
								{
									num5 = 1;
								}
								continue;
							case 3:
								c2rFr7ob9BQeWLocSF5D(base.Session, _003C_003Ec__DisplayClass50_2.newMetadata);
								num5 = 8;
								continue;
							case 11:
								goto end_IL_00be;
							}
							break;
						}
						continue;
						IL_0129:
						_003C_003Ec__DisplayClass50_2 = new _003C_003Ec__DisplayClass50_0();
						num5 = 5;
						goto IL_0084;
						continue;
						end_IL_00be:
						break;
					}
				}
				finally
				{
					int num7;
					if (enumerator == null)
					{
						num7 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
						{
							num7 = 0;
						}
						goto IL_022d;
					}
					goto IL_0256;
					IL_0256:
					VJ6qT2oosW0aSBDWnQVE(enumerator);
					num7 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
					{
						num7 = 1;
					}
					goto IL_022d;
					IL_022d:
					switch (num7)
					{
					default:
						goto end_IL_0208;
					case 0:
						goto end_IL_0208;
					case 2:
						break;
					case 1:
						goto end_IL_0208;
					}
					goto IL_0256;
					end_IL_0208:;
				}
				goto case 4;
			case 4:
				enumerator = previousAssemblyModelsMetadataList.GetEnumerator();
				num2 = 10;
				continue;
			case 2:
				enumerator2 = NamespaceMetadata.BuildNamespaceTree(currMetadata.Values.OfType<NamespaceMetadata>().ToList()).Nodes.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
				{
					num2 = 0;
				}
				continue;
			case 9:
				enumerator = assemblyModelsMetadataList.GetEnumerator();
				num2 = 8;
				continue;
			case 1:
				flag = false;
				num2 = 9;
				continue;
			case 7:
				if (!flag)
				{
					return;
				}
				num2 = 2;
				continue;
			case 6:
				assemblyModelsMetadataList = MetadataService.GetAssemblyModelsMetadataList();
				num2 = 5;
				continue;
			case 10:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 16;
							goto IL_0414;
						}
						goto IL_061b;
						IL_0414:
						while (true)
						{
							switch (num3)
							{
							case 14:
								if (deactivatingModules.Contains((string)CjDwcyobm1tkAWd4ZShC(_003C_003Ec__DisplayClass50_.prevMetadata)))
								{
									num3 = 2;
									continue;
								}
								goto case 3;
							case 5:
							case 8:
							case 13:
							case 15:
								break;
							case 3:
								pld11pobJSyldIpiBuoa(_003C_003Ec__DisplayClass50_.prevMetadata, AssemblyModelsMetadataStatus.RunnedDisable);
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
								{
									num3 = 0;
								}
								continue;
							case 10:
								_003C_003Ec__DisplayClass50_.prevMetadata = enumerator.Current;
								num3 = 9;
								continue;
							default:
								base.Session.Merge<AssemblyModelsMetadata>(_003C_003Ec__DisplayClass50_.prevMetadata);
								num3 = 13;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
								{
									num3 = 0;
								}
								continue;
							case 6:
							case 12:
								c2rFr7ob9BQeWLocSF5D(base.Session, _003C_003Ec__DisplayClass50_.prevMetadata);
								num3 = 15;
								continue;
							case 7:
								if (!hky8mPobKfZK3oy0mlNJ(_003C_003Ec__DisplayClass50_.prevMetadata.Name, qIR95KobvejQeGSTm33y(0x17ADCCD8 ^ 0x17ADC6F6)))
								{
									num3 = 4;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
									{
										num3 = 2;
									}
									continue;
								}
								break;
							case 2:
								base.Session.Delete(_003C_003Ec__DisplayClass50_.prevMetadata.Id, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87366483));
								num3 = 8;
								continue;
							case 9:
								if (!hky8mPobKfZK3oy0mlNJ(CjDwcyobm1tkAWd4ZShC(_003C_003Ec__DisplayClass50_.prevMetadata), qIR95KobvejQeGSTm33y(0x5A4C7B29 ^ 0x5A4C714D)))
								{
									num3 = 7;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
									{
										num3 = 7;
									}
									continue;
								}
								break;
							case 11:
								goto IL_061b;
							case 1:
								if (LHsEFpobdGuvddHU1PoL(_003C_003Ec__DisplayClass50_.prevMetadata) <= 0)
								{
									num3 = 6;
									continue;
								}
								goto case 14;
							case 4:
								if (assemblyModelsMetadataList.Any(_003C_003Ec__DisplayClass50_._003CSaveMetadata_003Eb__1))
								{
									num3 = 5;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
									{
										num3 = 4;
									}
									continue;
								}
								goto case 1;
							case 16:
								goto end_IL_04a7;
							}
							break;
						}
						continue;
						IL_061b:
						_003C_003Ec__DisplayClass50_ = new _003C_003Ec__DisplayClass50_1();
						num3 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
						{
							num3 = 10;
						}
						goto IL_0414;
						continue;
						end_IL_04a7:
						break;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								VJ6qT2oosW0aSBDWnQVE(enumerator);
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
								{
									num4 = 0;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
				goto case 7;
			}
			try
			{
				while (true)
				{
					int num8;
					if (!enumerator2.MoveNext())
					{
						num8 = 3;
						goto IL_02b9;
					}
					goto IL_02e9;
					IL_02b9:
					while (true)
					{
						switch (num8)
						{
						case 3:
							return;
						case 2:
							break;
						default:
							goto IL_02e9;
						case 1:
							SaveNamespaceGroup(current, null);
							num8 = 2;
							continue;
						}
						break;
					}
					continue;
					IL_02e9:
					current = enumerator2.Current;
					num8 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
					{
						num8 = 1;
					}
					goto IL_02b9;
				}
			}
			finally
			{
				((IDisposable)enumerator2).Dispose();
				int num9 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
				{
					num9 = 0;
				}
				switch (num9)
				{
				case 0:
					break;
				}
			}
		}
	}

	private void SaveNamespaceGroup(NamespaceMetadata.TreeNode node, IMetadataItemGroup parent)
	{
		//Discarded unreachable code: IL_0077, IL_0086, IL_0091, IL_0148, IL_015b, IL_016a
		int num = 9;
		IMetadataItemGroup metadataItemGroup = default(IMetadataItemGroup);
		_003C_003Ec__DisplayClass51_0 _003C_003Ec__DisplayClass51_ = default(_003C_003Ec__DisplayClass51_0);
		List<NamespaceMetadata.TreeNode>.Enumerator enumerator = default(List<NamespaceMetadata.TreeNode>.Enumerator);
		NamespaceMetadata.TreeNode current = default(NamespaceMetadata.TreeNode);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					YYKvM6ohW5braayyVceP(metadataItemGroup, _003C_003Ec__DisplayClass51_.node.Namespace);
					num2 = 4;
					continue;
				case 1:
					try
					{
						while (true)
						{
							IL_00f6:
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
								{
									num3 = 0;
								}
								goto IL_0095;
							}
							goto IL_00af;
							IL_00af:
							current = enumerator.Current;
							num3 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
							{
								num3 = 2;
							}
							goto IL_0095;
							IL_0095:
							while (true)
							{
								switch (num3)
								{
								default:
									return;
								case 1:
									break;
								case 3:
									SaveNamespaceGroup(current, metadataItemGroup);
									num3 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
									{
										num3 = 1;
									}
									continue;
								case 2:
									goto IL_00f6;
								case 0:
									return;
								}
								break;
							}
							goto IL_00af;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
				case 12:
					FKtpSUohbGuQh4e7hLtF(metadataItemGroup);
					num2 = 10;
					continue;
				case 2:
					return;
				default:
					if (metadataItemGroup == null)
					{
						num2 = 11;
						continue;
					}
					goto case 7;
				case 7:
					gOsSvuobzNg6BNxnCFCW(metadataItemGroup, Mv9dCDobcU5eQLn2Wayr(_003C_003Ec__DisplayClass51_.node));
					num2 = 13;
					continue;
				case 4:
					metadataItemGroup.Parent = parent;
					num2 = 5;
					continue;
				case 6:
				{
					IEntityManager<IMetadataItemGroup> instance = EntityManager<IMetadataItemGroup>.Instance;
					ParameterExpression parameterExpression = (ParameterExpression)DnC2bIobrICpddRQ8BC7(FsCAnmoblbbXgkXkbhds(typeof(IMetadataItemGroup).TypeHandle), qIR95KobvejQeGSTm33y(-576149596 ^ -576171996));
					metadataItemGroup = instance.Find(Expression.Lambda<Func<IMetadataItemGroup, bool>>((Expression)K0t3GbobsrmKEMhm0PKw(vK0QKmobUaa5f56cMBqI(Expression.Property(parameterExpression, (MethodInfo)Wn9nb5obg2av6LSXi1o0((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), v3LhnoobLFhSrbO6VLy9(EqRGw8obYFlMDoSHeNF1(ogWWMtob5CajJr6VYA6S(_003C_003Ec__DisplayClass51_, FsCAnmoblbbXgkXkbhds(typeof(_003C_003Ec__DisplayClass51_0).TypeHandle)), n4amMTobjvcEh7Yu44vN((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/))), vK0QKmobUaa5f56cMBqI(v3LhnoobLFhSrbO6VLy9(parameterExpression, (MethodInfo)Wn9nb5obg2av6LSXi1o0((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), ogWWMtob5CajJr6VYA6S(true, FsCAnmoblbbXgkXkbhds(typeof(bool).TypeHandle)))), new ParameterExpression[1] { parameterExpression })).FirstOrDefault();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				case 11:
					break;
				case 5:
					BFj6wTohoQNaclFkQkrS(metadataItemGroup, true);
					num2 = 12;
					continue;
				case 13:
					qNF0bHohBeKo50v5ipdD(metadataItemGroup, TJDiSHohFJLtZjVmycSs(_003C_003Ec__DisplayClass51_.node));
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
					{
						num2 = 3;
					}
					continue;
				case 8:
					_003C_003Ec__DisplayClass51_.node = node;
					num2 = 6;
					continue;
				case 9:
					_003C_003Ec__DisplayClass51_ = new _003C_003Ec__DisplayClass51_0();
					num2 = 8;
					continue;
				case 10:
					enumerator = _003C_003Ec__DisplayClass51_.node.Nodes.GetEnumerator();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			metadataItemGroup = InterfaceActivator.Create<IMetadataItemGroup>();
			num = 7;
		}
	}

	string IDbModelUpdater.GenerateForeignKeyName(string tableName, string columnName)
	{
		return GenerateNameHelper.GenerateForeignKeyName((string)qIR95KobvejQeGSTm33y(0x4EDCBA32 ^ 0x4EDEE998), tableName, columnName);
	}

	string IDbModelUpdater.GeneratePrimaryKeyName(string tableName, string columnName)
	{
		return GenerateNameHelper.GeneratePrimaryKeyName((string)qIR95KobvejQeGSTm33y(0x637E299B ^ 0x637C7A23), tableName, columnName);
	}

	public DbModelUpdater()
	{
		//Discarded unreachable code: IL_007a, IL_007f
		P2O0Jhohh0EcDSPOXcTQ();
		currMetadata = new Dictionary<Guid, AbstractMetadata>();
		prevMetadata = new Dictionary<Guid, AbstractMetadata>();
		currMetadataModules = new Dictionary<AbstractMetadata, ModuleRef>();
		prevMetadataModules = new Dictionary<AbstractMetadata, ModuleRef>();
		moduleRefs = new Dictionary<string, ModuleRef>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static DbModelUpdater()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				DbUpdateLog = (ILogger)D6eFhKohG6e9X0KX3pP9(qIR95KobvejQeGSTm33y(-541731959 ^ -541842459));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				SingletonReader.JJCZtPuTvSt();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	internal static object QkXxEfoojJa6FFLIIxGn(object P_0)
	{
		return ((IRuntimeApplication)P_0).DbPreUpdater;
	}

	internal static bool toRjdpoog6DFxSZdftXY()
	{
		return O5qXfSoorDF2hrPyRPyX == null;
	}

	internal static DbModelUpdater LGxuxooo517XPctPV0Sk()
	{
		return O5qXfSoorDF2hrPyRPyX;
	}

	internal static void apqCMZooYmYusrPGTi54(object P_0)
	{
		((List<IDbAction>)P_0).Clear();
	}

	internal static object axumBMooLlY7Mhn4KKDC()
	{
		return ComponentManager.Current;
	}

	internal static void xUmpYIooUCTMsJGTfpw6(object P_0, object P_1, object P_2)
	{
		((IEntityActionExtender)P_0).Extend((IDbModelUpdater)P_1, (EntityMetadata)P_2);
	}

	internal static void VJ6qT2oosW0aSBDWnQVE(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static bool a6Xjbsooc1RoelgwJJWa(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static object S8PJ74oozuGqpBF5WjuB()
	{
		return SR.KeyCultureInfo;
	}

	internal static void O8pRgBobFuS1ZtsNc4iW(object P_0, object P_1)
	{
		SR.RunWithCulture((CultureInfo)P_0, (Action)P_1);
	}

	internal static void D9XgoIobBbfV8d0grcZV(object P_0)
	{
		((Dictionary<Guid, AbstractMetadata>)P_0).Clear();
	}

	internal static void d1ATmaobWrN6aZpTfQR7(object P_0)
	{
		((Dictionary<AbstractMetadata, ModuleRef>)P_0).Clear();
	}

	internal static void gmxKaIobo0Q20fYMCIVo(object P_0)
	{
		((Dictionary<string, ModuleRef>)P_0).Clear();
	}

	internal static object wPi26hobbLmeXJ3nvZgQ(object P_0, object P_1, object P_2)
	{
		return ((ITransformationProvider)P_0).GetDeletingColumnTemporaryName((string)P_1, (string)P_2);
	}

	internal static void YWXZxVobhoDJcXyjIbPJ(object P_0)
	{
		((DbUpdateHandler)P_0).OnForeignKeysCreated();
	}

	internal static void OKvq5FobGNk8egotQQvw(object P_0, object P_1)
	{
		((DbModelUpdater)P_0).ProcessMetadataItemChanges((AbstractMetadata)P_1);
	}

	internal static Guid DmN37SobEks2fuJmC4C1(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static Guid gakq6OobfvJAprkvEFC2(object P_0)
	{
		return ((EntityMetadata)P_0).ImplementationUid;
	}

	internal static object TIHVUOobQdEVVPZy6uvd(object P_0)
	{
		return ((ModuleRef)P_0).Name;
	}

	internal static bool dqbLe5obCPq9twLJqUed(object P_0)
	{
		return ((ClassMetadata)P_0).IsInterfaceType;
	}

	internal static object qIR95KobvejQeGSTm33y(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object nWpKsFob8KMuUwOEbHQY(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object gnAQ19obZTRBE0PrrqGx(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static object j9HeB4obukWkAm8EyPOq(object P_0)
	{
		return ((EntityMetadata)P_0).TableName;
	}

	internal static bool myJ0rUobI0gEkYVqH1ca(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static bool PBkId4obVVbEnTesSK9P(object P_0)
	{
		return ((ClassMetadata)P_0).AllowCreateHeirs;
	}

	internal static Guid GoSmeTobSdkgVWAra1YL(object P_0)
	{
		return ((ClassMetadata)P_0).BaseClassUid;
	}

	internal static int KbckdKobiYyR0e0WHwuK(object P_0)
	{
		return ((List<IDbAction>)P_0).Count;
	}

	internal static void uLoNkeobRWTde8qV8CRS(object P_0, object P_1, object P_2, object P_3, object P_4)
	{
		((DbModelUpdater)P_0).ProcessEntityPropertyMetadataChanges((EntityMetadata)P_1, (EntityPropertyMetadata)P_2, (EntityMetadata)P_3, (EntityPropertyMetadata)P_4);
	}

	internal static object QaeEHfobqLG62l2dFAWy(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static bool hky8mPobKfZK3oy0mlNJ(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static bool wbEh2vobX2YmLKjrVTVs(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static object vELDWgobTRh3h9ejUk7Q()
	{
		return Logger.Log;
	}

	internal static void uZ3SrMobkDN6qTaVKWvZ(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Info(P_1, (Exception)P_2);
	}

	internal static bool DDYo5Pobn7938k5w0fhI(object P_0)
	{
		return ((EntityMetadata)P_0).Hierarchical;
	}

	internal static HierarchyType PeNFtAobO0og5s85Gpgs(object P_0)
	{
		return ((EntityMetadata)P_0).HierarchyType;
	}

	internal static bool jFdspcob2SPPIVFpZp9Q(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static object SeXBgpobeNim7CurEAMC(object P_0)
	{
		return ((PropertyMetadata)P_0).Settings;
	}

	internal static object jE1VN7obPG2JUAqJI4vB(object P_0)
	{
		return ((SimpleTypeSettings)P_0).FieldName;
	}

	internal static bool rLBBp3ob1V7seHSNwmYq(object P_0)
	{
		return ((EntityMetadata)P_0).IsActivePermissionMetadata();
	}

	internal static object psUqrsobNrtwRxujMK24(object P_0)
	{
		return ((Table)P_0).Name;
	}

	internal static void P34K8gob3TkRdjQ59amL(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static bool hNac88obp6warxwvY3bC(object P_0)
	{
		return ((EntityMetadata)P_0).IsUnique;
	}

	internal static object cxEXv4obayf6pPYOwsak(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static void jpKUQMobDaRFgrqClaZD(object P_0, object P_1)
	{
		((Index)P_0).Name = (string)P_1;
	}

	internal static void zkeN31obt4Fv0xx7kf1E(object P_0, object P_1)
	{
		((Index)P_0).TableName = (string)P_1;
	}

	internal static bool bto49BobwI9bJck2GyDT(object P_0)
	{
		return ((PropertyMetadata)P_0).IsSystem;
	}

	internal static Guid zbIT8gob4Xrdk5sPA8Un(object P_0)
	{
		return ((PropertyMetadata)P_0).TypeUid;
	}

	internal static Guid IxgolWob6qRxyFEnBoxu(object P_0)
	{
		return ((PropertyMetadata)P_0).SubTypeUid;
	}

	internal static object uNvZP7obHutjOLc3DoFB(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static object pwRxABobA2OrFRos66rC(object P_0, Guid typeUid, Guid subTypeUid)
	{
		return ((IMetadataService)P_0).GetTypeDescriptor(typeUid, subTypeUid);
	}

	internal static object eChi4wob7Q9DXaGjhcb4(object P_0, object P_1)
	{
		return ((IPropertyTypeInfo)P_0).GetPropertyTypeDisplayName((PropertyMetadata)P_1);
	}

	internal static void Lr0TxIobxQDBhfNZd9Eq(object P_0, object P_1)
	{
		((DbModelUpdater)P_0).ProcessDeletedEntityMetadata((EntityMetadata)P_1);
	}

	internal static void iOjfLwob0urUEgPqhoi9(object P_0, object P_1)
	{
		((RegistryKey)P_0).DeleteValue((string)P_1);
	}

	internal static object CjDwcyobm1tkAWd4ZShC(object P_0)
	{
		return ((AssemblyModelsMetadata)P_0).Name;
	}

	internal static void kPebmFobypcVVrFP5d7B(object P_0, object P_1)
	{
		((ModuleRef)P_0).Name = (string)P_1;
	}

	internal static object zLHD4gobMPBpLIyGZ6Wy(object P_0)
	{
		return ((AssemblyModelsMetadata)P_0).RestoreMetadata();
	}

	internal static void pld11pobJSyldIpiBuoa(object P_0, AssemblyModelsMetadataStatus value)
	{
		((AssemblyModelsMetadata)P_0).Status = value;
	}

	internal static object c2rFr7ob9BQeWLocSF5D(object P_0, object P_1)
	{
		return ((ISession)P_0).Save(P_1);
	}

	internal static long LHsEFpobdGuvddHU1PoL(object P_0)
	{
		return ((AssemblyModelsMetadata)P_0).Id;
	}

	internal static Type FsCAnmoblbbXgkXkbhds(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object DnC2bIobrICpddRQ8BC7(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object Wn9nb5obg2av6LSXi1o0(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object ogWWMtob5CajJr6VYA6S(object P_0, Type P_1)
	{
		return Expression.Constant(P_0, P_1);
	}

	internal static object n4amMTobjvcEh7Yu44vN(RuntimeFieldHandle P_0)
	{
		return FieldInfo.GetFieldFromHandle(P_0);
	}

	internal static object EqRGw8obYFlMDoSHeNF1(object P_0, object P_1)
	{
		return Expression.Field((Expression)P_0, (FieldInfo)P_1);
	}

	internal static object v3LhnoobLFhSrbO6VLy9(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static object vK0QKmobUaa5f56cMBqI(object P_0, object P_1)
	{
		return Expression.Equal((Expression)P_0, (Expression)P_1);
	}

	internal static object K0t3GbobsrmKEMhm0PKw(object P_0, object P_1)
	{
		return Expression.AndAlso((Expression)P_0, (Expression)P_1);
	}

	internal static object Mv9dCDobcU5eQLn2Wayr(object P_0)
	{
		return ((NamespaceMetadata.TreeNode)P_0).Name;
	}

	internal static void gOsSvuobzNg6BNxnCFCW(object P_0, object P_1)
	{
		((IMetadataItemGroup)P_0).Name = (string)P_1;
	}

	internal static object TJDiSHohFJLtZjVmycSs(object P_0)
	{
		return ((NamespaceMetadata.TreeNode)P_0).DisplayName;
	}

	internal static void qNF0bHohBeKo50v5ipdD(object P_0, object P_1)
	{
		((IMetadataItemGroup)P_0).DisplayName = (string)P_1;
	}

	internal static void YYKvM6ohW5braayyVceP(object P_0, object P_1)
	{
		((IMetadataItemGroup)P_0).Namespace = (string)P_1;
	}

	internal static void BFj6wTohoQNaclFkQkrS(object P_0, bool value)
	{
		((IMetadataItemGroup)P_0).IsSystem = value;
	}

	internal static void FKtpSUohbGuQh4e7hLtF(object P_0)
	{
		((IEntity)P_0).Save();
	}

	internal static void P2O0Jhohh0EcDSPOXcTQ()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object D6eFhKohG6e9X0KX3pP9(object P_0)
	{
		return Logger.GetLogger((string)P_0);
	}
}
