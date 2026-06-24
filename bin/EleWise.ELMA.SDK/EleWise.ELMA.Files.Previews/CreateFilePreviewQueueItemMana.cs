using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Locking;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Files.Previews;

public class CreateFilePreviewQueueItemManager : EntityManager<ICreateFilePreviewQueueItem, long>
{
	public const long MaxAttemptsCount = 8L;

	private static readonly string LockName;

	private static CreateFilePreviewQueueItemManager yvYVUvGexp0yv9DlSI7W;

	public new static CreateFilePreviewQueueItemManager Instance => Locator.GetServiceNotNull<CreateFilePreviewQueueItemManager>();

	public ILockService LockService
	{
		[CompilerGenerated]
		get
		{
			return _003CLockService_003Ek__BackingField;
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
					_003CLockService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public IFilePreviewService DocumentPreviewService
	{
		[CompilerGenerated]
		get
		{
			return _003CDocumentPreviewService_003Ek__BackingField;
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
					_003CDocumentPreviewService_003Ek__BackingField = value;
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

	public ITransformationProvider TransformationProvider
	{
		[CompilerGenerated]
		get
		{
			return _003CTransformationProvider_003Ek__BackingField;
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
					_003CTransformationProvider_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
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

	[Transaction]
	public virtual long[] GetTopElemets(int top)
	{
		//Discarded unreachable code: IL_0162, IL_01ea, IL_01f9, IL_03b4, IL_03c3, IL_03f4, IL_042c, IL_043b
		int num = 2;
		int num2 = num;
		long[] result = default(long[]);
		string sql = default(string);
		Dictionary<string, object> dictionary = default(Dictionary<string, object>);
		string text = default(string);
		int num4 = default(int);
		ILock @lock = default(ILock);
		while (true)
		{
			switch (num2)
			{
			default:
				return result;
			case 3:
				try
				{
					result = (from l in ((ICriteria)mYV03aGeLqKkXL06hcUk(WpP51BGejCalvLcc2YjE(WpP51BGejCalvLcc2YjE(NA0cwFGegaLSNrmqRO77(QdG5ptGeduOCObaibOXC(GQ89MTGeMNCaw6J1FTWt(this, null), NxnkxnGe9lk7jlP66ZZ7(LKlGWCGeJ6o2SeiJMCjF(-1824388195 ^ -1824355813), PreviewWorkStatus.None)), new IProjection[3]
						{
							(IProjection)aydncPGer74fC1Ukgb9w(byXRvdGelgysROeZRN42(LKlGWCGeJ6o2SeiJMCjF(-97972138 ^ -97939192)), LKlGWCGeJ6o2SeiJMCjF(0x48A7E34A ^ 0x48A40B2C)),
							(IProjection)aydncPGer74fC1Ukgb9w(Projections.Max((string)LKlGWCGeJ6o2SeiJMCjF(-1978478350 ^ -1978582884)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4A1640F ^ 0x4A2D245)),
							(IProjection)Projections.GroupProperty((string)LKlGWCGeJ6o2SeiJMCjF(-1426094279 ^ -1426296901))
						}), WhUF2cGe5rTcEV2iuGRq(LKlGWCGeJ6o2SeiJMCjF(-672123589 ^ -671906959))), Kbg9BJGeYAsww7UL1sMq(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -105304188))), top)).List<IList>()
						select (long)_003C_003Ec.AWM97RvzpBl7XlZTgrRS(l, 0)).ToArray();
					int num3 = 6;
					while (true)
					{
						switch (num3)
						{
						case 2:
							return result;
						case 7:
							return result;
						case 5:
							base.Session.CleanUpCache(TypeOf<ICreateFilePreviewQueueItem>.Raw);
							num3 = 2;
							break;
						case 10:
							TransformationProvider.ExecuteQuery(sql, dictionary);
							num3 = 5;
							break;
						case 11:
							sql = (string)fjp7peGPFB6A8IYT66Od(LKlGWCGeJ6o2SeiJMCjF(-488881205 ^ -488658169), new object[5]
							{
								LKlGWCGeJ6o2SeiJMCjF(0x4DC2B14D ^ 0x4DC15815),
								lP3YbdGec1BFxSmOEUcG(IMBti0GesiEry6sM9ufM(TransformationProvider), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4785BC0D ^ 0x47865463)),
								Wr1OIhGezVCBDkckDJ5P(TransformationProvider),
								lP3YbdGec1BFxSmOEUcG(IMBti0GesiEry6sM9ufM(TransformationProvider), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x571EA399 ^ 0x571E22C7)),
								text
							});
							num3 = 10;
							break;
						case 13:
							text = string.Join((string)LKlGWCGeJ6o2SeiJMCjF(0x7EC153F ^ 0x7EC47CF), result.Select((long item, int i) => (string)YTEoMmGPZcMBHn5OWfrc(LKlGWCGeJ6o2SeiJMCjF(--1867379187 ^ 0x6F4E1B3F), TransformationProvider.ParameterSeparator, i)));
							num3 = 9;
							break;
						case 8:
							num4 = 0;
							num3 = 12;
							break;
						default:
							dictionary.Add((string)xokgJVGeUfyGRwuUClY1(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-29254301 ^ -29215809), num4), result[num4]);
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
							{
								num3 = 1;
							}
							break;
						case 1:
							num4++;
							num3 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
							{
								num3 = 4;
							}
							break;
						case 6:
							if (result.Length == 0)
							{
								num3 = 7;
								break;
							}
							goto case 13;
						case 4:
						case 12:
							if (num4 < result.Length)
							{
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
								{
									num3 = 0;
								}
								break;
							}
							goto case 11;
						case 9:
							dictionary = new Dictionary<string, object> { 
							{
								(string)LKlGWCGeJ6o2SeiJMCjF(0x1FFEF86A ^ 0x1FFD10F8),
								0
							} };
							num3 = 8;
							break;
						}
					}
				}
				finally
				{
					if (@lock != null)
					{
						int num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
						{
							num5 = 0;
						}
						while (true)
						{
							switch (num5)
							{
							default:
								JEJSZRGPBOA215OcM3JI(@lock);
								num5 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
								{
									num5 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
			case 1:
				@lock = (ILock)nCqU0IGeywuDLmTt5bNy(LockService, LockName);
				num2 = 3;
				break;
			case 2:
				result = null;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public IList<ICreateFilePreviewQueueItem> GetNewElements()
	{
		return CreateCriteria().Add((ICriterion)(object)Restrictions.Or((ICriterion)(object)Restrictions.Eq(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70039925), (object)PreviewWorkStatus.None), (ICriterion)(object)((Junction)Restrictions.Conjunction()).Add((ICriterion)(object)Restrictions.Eq(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-29254301 ^ -29287195), (object)PreviewWorkStatus.Fail)).Add((ICriterion)(object)Restrictions.Lt(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x76DD48E ^ 0x76E1202), (object)8L)).Add((ICriterion)(object)Restrictions.Le(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837852693), (object)DateTime.Now)))).AddOrder(Order.Desc(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -811954144))).AddOrder(Order.Asc(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1217523399 ^ -1217490841)))
			.List<ICreateFilePreviewQueueItem>();
	}

	public void DeleteExecuted()
	{
		//Discarded unreachable code: IL_0102, IL_011a, IL_0129, IL_0134, IL_01b3, IL_01d6, IL_01e5, IL_0244, IL_02a8, IL_02b7, IL_030e, IL_036b, IL_037e, IL_038d
		switch (1)
		{
		case 0:
			break;
		case 1:
			try
			{
				IEnumerator<long> enumerator = ((ICriteria)QdG5ptGeduOCObaibOXC(GQ89MTGeMNCaw6J1FTWt(this, null), dNQUbBGPWhtaB4YJGoYn(NxnkxnGe9lk7jlP66ZZ7(LKlGWCGeJ6o2SeiJMCjF(-420743386 ^ -420776288), PreviewWorkStatus.Completed), Hgyx5KGPoVbEXjFcjaZY(((Junction)Restrictions.Conjunction()).Add((ICriterion)NxnkxnGe9lk7jlP66ZZ7(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1858920409), PreviewWorkStatus.Fail)), dNQUbBGPWhtaB4YJGoYn(Restrictions.IsNull(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xD3DEF7E ^ 0xD3E29F2)), Restrictions.Ge((string)LKlGWCGeJ6o2SeiJMCjF(0x8317432 ^ 0x832B2BE), (object)8L)))))).SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)ItnsBDGPbYIvUkYpLl3y(LKlGWCGeJ6o2SeiJMCjF(0x7459E02 ^ 0x7451F5C)) }).List<long>().GetEnumerator();
				int num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
				{
					num = 0;
				}
				switch (num)
				{
				default:
					try
					{
						long current = default(long);
						while (true)
						{
							IL_02c2:
							int num2;
							if (!IWOdRoGPf44N637vsy1x(enumerator))
							{
								num2 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
								{
									num2 = 3;
								}
								goto IL_0138;
							}
							goto IL_017b;
							IL_017b:
							current = enumerator.Current;
							num2 = 2;
							goto IL_0138;
							IL_0138:
							while (true)
							{
								switch (num2)
								{
								case 3:
									return;
								case 2:
									WdGt6ZGPhvwVdtHB9ZBC(base.Session);
									num2 = 4;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
									{
										num2 = 4;
									}
									continue;
								case 1:
									break;
								case 4:
									try
									{
										ICreateFilePreviewQueueItem createFilePreviewQueueItem = LoadOrNull(current);
										int num3 = 3;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
										{
											num3 = 3;
										}
										while (true)
										{
											switch (num3)
											{
											case 1:
												goto end_IL_01b7;
											case 3:
												if (createFilePreviewQueueItem == null)
												{
													num3 = 1;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
													{
														num3 = 1;
													}
													continue;
												}
												break;
											case 2:
												goto end_IL_01b7;
											}
											TryDeleteItem(createFilePreviewQueueItem);
											num3 = 2;
											continue;
											end_IL_01b7:
											break;
										}
									}
									catch (Exception ex)
									{
										int num4 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
										{
											num4 = 1;
										}
										while (true)
										{
											switch (num4)
											{
											case 1:
												Eu4nVhGPEQmiVItCl9Wk(HLCKrLGPG6esvMc1aWFg(this), xokgJVGeUfyGRwuUClY1(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-309639236 ^ -309809650), current), ex);
												num4 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
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
									goto IL_02c2;
								default:
									goto IL_02c2;
								}
								break;
							}
							goto IL_017b;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							int num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
							{
								num5 = 0;
							}
							while (true)
							{
								switch (num5)
								{
								default:
									JEJSZRGPBOA215OcM3JI(enumerator);
									num5 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
									{
										num5 = 1;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
				}
			}
			finally
			{
				WdGt6ZGPhvwVdtHB9ZBC(base.Session);
				int num6 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
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

	[Transaction]
	public virtual void TryDeleteItem(ICreateFilePreviewQueueItem item)
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
				if (!LockForCreatePreview(item))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
					{
						num2 = 0;
					}
					break;
				}
				item.Delete();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 2:
				return;
			}
		}
	}

	protected bool LockForCreatePreview(ICreateFilePreviewQueueItem item)
	{
		//Discarded unreachable code: IL_00a5, IL_010e, IL_0176, IL_01e7, IL_01f6
		int num = 3;
		int num2 = num;
		bool result = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (item == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
					{
						num2 = 2;
					}
				}
				else
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
					{
						num2 = 1;
					}
				}
				continue;
			case 2:
				throw new ArgumentNullException((string)LKlGWCGeJ6o2SeiJMCjF(-1638402543 ^ -1638441361));
			case 1:
				try
				{
					int num3 = SR.GetSetting((string)LKlGWCGeJ6o2SeiJMCjF(-1317790512 ^ -1317538088), 1);
					int num4 = 2;
					while (true)
					{
						switch (num4)
						{
						case 3:
							Refresh(item);
							num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
							{
								num4 = 0;
							}
							continue;
						case 5:
							num3 = 1;
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
							{
								num4 = 0;
							}
							continue;
						case 2:
							if (num3 > 0)
							{
								num4 = 4;
								continue;
							}
							goto case 5;
						default:
							jymirpGPQmCEvB2tG4HL(base.Session, item, num3);
							num4 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
							{
								num4 = 3;
							}
							continue;
						case 1:
							break;
						}
						break;
					}
				}
				catch
				{
					int num5 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
					{
						num5 = 0;
					}
					while (true)
					{
						switch (num5)
						{
						case 2:
							return result;
						case 1:
							Ol0XqxGPCDyU8yK209QD(HLCKrLGPG6esvMc1aWFg(this), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740507758) + item.Id);
							num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
							{
								num5 = 0;
							}
							break;
						default:
							result = false;
							num5 = 2;
							break;
						}
					}
				}
				break;
			}
			break;
		}
		return true;
	}

	public ICreateFilePreviewQueueItem FindItemById(string fileId)
	{
		int num = 1;
		int num2 = num;
		Filter filter = default(Filter);
		while (true)
		{
			switch (num2)
			{
			case 1:
				filter = new Filter
				{
					Query = (string)p8bbXlGPv4Y57NMRAUbf(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837853455), fileId)
				};
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return Find(filter, new FetchOptions(0, 1)).FirstOrDefault();
			}
		}
	}

	public CreateFilePreviewQueueItemManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		hU490pGP8qMh5x1ndPmW();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static CreateFilePreviewQueueItemManager()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				LockName = (string)LKlGWCGeJ6o2SeiJMCjF(-1837662597 ^ -1837853475);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				SingletonReader.JJCZtPuTvSt();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	internal static bool YVLitxGe0i806pbwZVso()
	{
		return yvYVUvGexp0yv9DlSI7W == null;
	}

	internal static CreateFilePreviewQueueItemManager eGyTDlGemapouVGqyCpu()
	{
		return yvYVUvGexp0yv9DlSI7W;
	}

	internal static object nCqU0IGeywuDLmTt5bNy(object P_0, object P_1)
	{
		return ((ILockService)P_0).AcquireLock((string)P_1);
	}

	internal static object GQ89MTGeMNCaw6J1FTWt(object P_0, object P_1)
	{
		return ((EntityManager<ICreateFilePreviewQueueItem, long>)P_0).CreateCriteria((IEntityFilter)P_1);
	}

	internal static object LKlGWCGeJ6o2SeiJMCjF(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object NxnkxnGe9lk7jlP66ZZ7(object P_0, object P_1)
	{
		return Restrictions.Eq((string)P_0, P_1);
	}

	internal static object QdG5ptGeduOCObaibOXC(object P_0, object P_1)
	{
		return ((ICriteria)P_0).Add((ICriterion)P_1);
	}

	internal static object byXRvdGelgysROeZRN42(object P_0)
	{
		return Projections.Max((string)P_0);
	}

	internal static object aydncPGer74fC1Ukgb9w(object P_0, object P_1)
	{
		return Projections.Alias((IProjection)P_0, (string)P_1);
	}

	internal static object NA0cwFGegaLSNrmqRO77(object P_0, object P_1)
	{
		return ((ICriteria)P_0).SetProjection((IProjection[])P_1);
	}

	internal static object WhUF2cGe5rTcEV2iuGRq(object P_0)
	{
		return Order.Desc((string)P_0);
	}

	internal static object WpP51BGejCalvLcc2YjE(object P_0, object P_1)
	{
		return ((ICriteria)P_0).AddOrder((Order)P_1);
	}

	internal static object Kbg9BJGeYAsww7UL1sMq(object P_0)
	{
		return Order.Asc((string)P_0);
	}

	internal static object mYV03aGeLqKkXL06hcUk(object P_0, int P_1)
	{
		return ((ICriteria)P_0).SetMaxResults(P_1);
	}

	internal static object xokgJVGeUfyGRwuUClY1(object P_0, object P_1)
	{
		return string.Concat(P_0, P_1);
	}

	internal static object IMBti0GesiEry6sM9ufM(object P_0)
	{
		return ((ITransformationProvider)P_0).Dialect;
	}

	internal static object lP3YbdGec1BFxSmOEUcG(object P_0, object P_1)
	{
		return ((Dialect)P_0).QuoteIfNeeded((string)P_1);
	}

	internal static object Wr1OIhGezVCBDkckDJ5P(object P_0)
	{
		return ((ITransformationProvider)P_0).ParameterSeparator;
	}

	internal static object fjp7peGPFB6A8IYT66Od(object P_0, object P_1)
	{
		return string.Format((string)P_0, (object[])P_1);
	}

	internal static void JEJSZRGPBOA215OcM3JI(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object dNQUbBGPWhtaB4YJGoYn(object P_0, object P_1)
	{
		return Restrictions.Or((ICriterion)P_0, (ICriterion)P_1);
	}

	internal static object Hgyx5KGPoVbEXjFcjaZY(object P_0, object P_1)
	{
		return ((Junction)P_0).Add((ICriterion)P_1);
	}

	internal static object ItnsBDGPbYIvUkYpLl3y(object P_0)
	{
		return Projections.Property((string)P_0);
	}

	internal static void WdGt6ZGPhvwVdtHB9ZBC(object P_0)
	{
		((ISession)P_0).Clear();
	}

	internal static object HLCKrLGPG6esvMc1aWFg(object P_0)
	{
		return ((EntityManager<ICreateFilePreviewQueueItem, long>)P_0).Logger;
	}

	internal static void Eu4nVhGPEQmiVItCl9Wk(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static bool IWOdRoGPf44N637vsy1x(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void jymirpGPQmCEvB2tG4HL(object P_0, object P_1, int timeout)
	{
		((ISession)P_0).LockWithWait(P_1, timeout);
	}

	internal static void Ol0XqxGPCDyU8yK209QD(object P_0, object P_1)
	{
		((ILogger)P_0).Debug(P_1);
	}

	internal static object p8bbXlGPv4Y57NMRAUbf(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static void hU490pGP8qMh5x1ndPmW()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object YTEoMmGPZcMBHn5OWfrc(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}
}
