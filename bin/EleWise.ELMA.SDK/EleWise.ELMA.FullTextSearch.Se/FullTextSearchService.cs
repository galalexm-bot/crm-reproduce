using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics;
using EleWise.ELMA.Diagnostics.Statistics;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.FullTextSearch.Constants;
using EleWise.ELMA.FullTextSearch.Enum;
using EleWise.ELMA.FullTextSearch.Exceptions;
using EleWise.ELMA.FullTextSearch.ExtensionPoints;
using EleWise.ELMA.FullTextSearch.Manager;
using EleWise.ELMA.FullTextSearch.Model;
using EleWise.ELMA.FullTextSearch.Settings;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Filters;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.FullTextSearch.Services;

[Service]
internal class FullTextSearchService : IFullTextSearchServiceReIndexingTypeExtension, IFullTextSearchService
{
	private static readonly ILogger IndexLog;

	private object objectIndex;

	private List<IFullTextSearchFieldsMappingsReIndexingExtension> points;

	internal static FullTextSearchService zoSitbGSyLMSR9ms7NtQ;

	public IFullTextSearchDescriptorService FullTextSearchDescriptorService
	{
		[CompilerGenerated]
		get
		{
			return _003CFullTextSearchDescriptorService_003Ek__BackingField;
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
					_003CFullTextSearchDescriptorService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
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

	private IBLOBDataManager BlobManager => (IBLOBDataManager)xT4UloGS9N7QXN3i8jM3();

	public IFullTextSearchProvider Provider
	{
		get
		{
			int num = 1;
			int num2 = num;
			_003C_003Ec__DisplayClass10_0 _003C_003Ec__DisplayClass10_ = default(_003C_003Ec__DisplayClass10_0);
			FullTextSearchSettingsModule serviceNotNull = default(FullTextSearchSettingsModule);
			while (true)
			{
				switch (num2)
				{
				case 5:
					return ((ComponentManager)NOHLYUGSlP7MTR4Jk6gL()).GetExtensionPoints<IFullTextSearchProvider>().FirstOrDefault(_003C_003Ec__DisplayClass10_._003Cget_Provider_003Eb__0);
				case 1:
					_003C_003Ec__DisplayClass10_ = new _003C_003Ec__DisplayClass10_0();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
					{
						num2 = 0;
					}
					break;
				default:
					_003C_003Ec__DisplayClass10_.providerUid = default(Guid);
					num2 = 4;
					break;
				case 4:
					serviceNotNull = Locator.GetServiceNotNull<FullTextSearchSettingsModule>();
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
					{
						num2 = 1;
					}
					break;
				case 2:
					if (serviceNotNull.Settings != null)
					{
						num2 = 3;
						break;
					}
					goto case 5;
				case 3:
					_003C_003Ec__DisplayClass10_.providerUid = IxAwiJGSdB9BFpCe7aDV(serviceNotNull.Settings);
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
					{
						num2 = 3;
					}
					break;
				}
			}
		}
	}

	private List<IFullTextSearchFieldsMappingsReIndexingExtension> Points => points ?? (points = ComponentManager.Current.GetExtensionPoints<IFullTextSearchFieldsMappingsReIndexingExtension>().ToList());

	private Guid BlobFullTextSearchStateUid => new Guid((string)fgHpoSGSY0ad2L8AABrV(-1939377524 ^ -1939561828));

	private Guid BlobFullTextSearchStopedInfoUid => new Guid((string)fgHpoSGSY0ad2L8AABrV(-398663332 ^ -398511872));

	private bool GetServerStatus()
	{
		//Discarded unreachable code: IL_003d, IL_0067, IL_0071, IL_0080, IL_00c8, IL_0100, IL_010f
		bool result = default(bool);
		switch (1)
		{
		default:
			return result;
		case 1:
			try
			{
				int num;
				if (Provider == null)
				{
					num = 2;
					goto IL_0041;
				}
				goto IL_0057;
				IL_0041:
				switch (num)
				{
				default:
					return result;
				case 0:
					return result;
				case 1:
					break;
				case 2:
					goto IL_008b;
				}
				goto IL_0057;
				IL_0057:
				int num2 = (x66jIWGSroJxCobKf9Yi(Provider) ? 1 : 0);
				goto IL_008c;
				IL_008c:
				result = (byte)num2 != 0;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
				{
					num = 0;
				}
				goto IL_0041;
				IL_008b:
				num2 = 0;
				goto IL_008c;
			}
			catch
			{
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
				{
					num3 = 1;
				}
				while (true)
				{
					switch (num3)
					{
					default:
						return result;
					case 0:
						return result;
					case 1:
						result = false;
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
						{
							num3 = 0;
						}
						break;
					}
				}
			}
		}
	}

	public bool IndexingIsWorking()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return GetServerStatus();
			case 1:
				if (GetIndexState() != FullTextSearchState.On)
				{
					return false;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual FullTextSearchResultModel Search(Type cardType, FullTextSearchResultModel resultModel, string searchString, int? pageIndex = null, int? pageSize = null)
	{
		_003C_003Ec__DisplayClass16_0 _003C_003Ec__DisplayClass16_ = new _003C_003Ec__DisplayClass16_0();
		_003C_003Ec__DisplayClass16_.cardType = cardType;
		_003C_003Ec__DisplayClass16_.resultModel = resultModel;
		if (Provider == null)
		{
			return _003C_003Ec__DisplayClass16_.resultModel;
		}
		using (DiagnosticsManager.StartCall(() => new IndexCallInfo(IndexCallsType.Search)))
		{
			_003C_003Ec__DisplayClass16_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass16_1();
			CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass16_;
			CS_0024_003C_003E8__locals0.listForHighlight = new List<string>();
			Points.ForEach(delegate(IFullTextSearchFieldsMappingsReIndexingExtension p)
			{
				int num9 = 1;
				int num10 = num9;
				while (true)
				{
					switch (num10)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						CS_0024_003C_003E8__locals0.listForHighlight.AddRange(p.GetHighlightFields(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.cardType));
						num10 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
						{
							num10 = 0;
						}
						break;
					}
				}
			});
			CS_0024_003C_003E8__locals0.listForFilter = new FilterList();
			Points.ForEach(delegate(IFullTextSearchFieldsMappingsReIndexingExtension p)
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
						CS_0024_003C_003E8__locals0.listForFilter.AddRange(p.GetFilterFields(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.cardType, CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.resultModel));
						num8 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
						{
							num8 = 0;
						}
						break;
					}
				}
			});
			CS_0024_003C_003E8__locals0.listForFields = new List<string>();
			Points.ForEach(delegate(IFullTextSearchFieldsMappingsReIndexingExtension p)
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
						CS_0024_003C_003E8__locals0.listForFields.AddRange(p.GetFields(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.cardType));
						num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
						{
							num6 = 0;
						}
						break;
					}
				}
			});
			CS_0024_003C_003E8__locals0.listForSearch = new List<string>();
			Points.ForEach(delegate(IFullTextSearchFieldsMappingsReIndexingExtension p)
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
						CS_0024_003C_003E8__locals0.listForSearch.AddRange(p.GetSearchFields(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.cardType));
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
						{
							num4 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			});
			int? from = null;
			int? size = null;
			if (pageIndex.HasValue && pageSize.HasValue && pageIndex > 0 && pageSize > 0)
			{
				from = (pageIndex - 1) * pageSize;
				size = pageSize;
			}
			try
			{
				CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.resultModel = Provider.Search(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.cardType, searchString, CS_0024_003C_003E8__locals0.listForHighlight, CS_0024_003C_003E8__locals0.listForFilter, CS_0024_003C_003E8__locals0.listForFields, CS_0024_003C_003E8__locals0.listForSearch, from, size);
			}
			catch (WebException ex)
			{
				Logger.Log.Error(ex);
				CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.resultModel.Error = new FullTextFilterException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638646845)), ex);
			}
			catch (Exception ex2)
			{
				throw ex2;
			}
			if (CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.resultModel != null && CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.resultModel.Items != null)
			{
				CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.resultModel.Items.ForEach(delegate(FullTextSearchResultItem i)
				{
					int num = 3;
					int num2 = num;
					object obj = default(object);
					while (true)
					{
						switch (num2)
						{
						default:
							return;
						case 0:
							return;
						case 1:
							_003C_003Ec__DisplayClass16_0.NwdjjZvU2wvnrcl3NaZn(i, (IFullTextSearchObject)obj);
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
							{
								num2 = 0;
							}
							break;
						case 2:
							((WebData)_003C_003Ec__DisplayClass16_0.VFQEZOvUOTIjr53ncE6m(i)).SaveToEntity(obj, ignoreNullDescriptor: true);
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
							{
								num2 = 1;
							}
							break;
						case 3:
							obj = InterfaceActivator.Create(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.cardType);
							num2 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
							{
								num2 = 1;
							}
							break;
						}
					}
				});
			}
			return CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.resultModel;
		}
	}

	public virtual FullTextSearchResultModel Search(Type cardType, string searchString, int? pageIndex = null, int? pageSize = null)
	{
		return Search(cardType, null, searchString, pageIndex, pageSize);
	}

	private bool IndexMany(Type cardType, List<IFullTextSearchObjectContainer> objects)
	{
		if (!objects.Any())
		{
			return true;
		}
		lock (objectIndex)
		{
			try
			{
				while (objects.Count > 0)
				{
					if (!IsIndexingOn())
					{
						throw new StopIndexingException();
					}
					int count = ((100 <= objects.Count) ? 100 : objects.Count);
					List<IFullTextSearchObjectContainer> list = new List<IFullTextSearchObjectContainer>();
					list.AddRange(objects.GetRange(0, count));
					Index(cardType, list);
					objects.RemoveRange(0, count);
				}
			}
			catch (StopIndexingException)
			{
				IndexLog.Warn(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-538519530 ^ -538662110), FullTextSearchConst.StopIndexTextLog, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2108095944)));
				throw;
			}
			catch (Exception ex2)
			{
				IndexLog.Error(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-561074844 ^ -561159336) + ex2.Message, ex2);
				return false;
			}
		}
		return true;
	}

	private bool ReIndexMany(Type cardType, List<ToReindex> listToReindex)
	{
		using IndexCallInfo indexCallInfo = DiagnosticsManager.StartCall(() => new IndexCallInfo(IndexCallsType.ReIndex));
		try
		{
			if (!listToReindex.Any())
			{
				return true;
			}
			return Provider != null && Provider.ReIndex(cardType, listToReindex);
		}
		catch (Exception ex)
		{
			if (indexCallInfo != null)
			{
				indexCallInfo.Exception = ex;
			}
			IndexLog.Error(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3CE17B75 ^ 0x3CE2B511) + ex.Message, ex);
			return false;
		}
	}

	private bool Index(Type cardType, List<IFullTextSearchObjectContainer> objects)
	{
		using IndexCallInfo indexCallInfo = DiagnosticsManager.StartCall(() => new IndexCallInfo(IndexCallsType.Index));
		try
		{
			if (Provider == null || !objects.Any())
			{
				return false;
			}
			return Provider.Index(cardType, objects);
		}
		catch (StopIndexingException)
		{
			throw;
		}
		catch (Exception ex2)
		{
			if (indexCallInfo != null)
			{
				indexCallInfo.Exception = ex2;
			}
			IndexLog.Error(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C9495B4 ^ 0x1C975B24) + ex2.Message, ex2);
			return false;
		}
	}

	private bool DeleteAllFromType(Type cardType)
	{
		//Discarded unreachable code: IL_007a, IL_00b2, IL_00f2, IL_00fd, IL_0165, IL_0174
		int num = 2;
		IndexCallInfo indexCallInfo = default(IndexCallInfo);
		while (true)
		{
			int num2 = num;
			Func<IndexCallInfo> func;
			while (true)
			{
				switch (num2)
				{
				default:
					return false;
				case 3:
					func = _003C_003Ec._003C_003E9__21_0;
					if (func == null)
					{
						num2 = 6;
						continue;
					}
					break;
				case 4:
					return true;
				case 5:
					try
					{
						Provider.DeleteAllFromType(cardType);
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
						{
							num3 = 0;
						}
						switch (num3)
						{
						case 0:
							break;
						}
					}
					finally
					{
						int num4;
						if (indexCallInfo == null)
						{
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
							{
								num4 = 1;
							}
							goto IL_00b6;
						}
						goto IL_00cc;
						IL_00cc:
						((IDisposable)indexCallInfo).Dispose();
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
						{
							num4 = 0;
						}
						goto IL_00b6;
						IL_00b6:
						switch (num4)
						{
						default:
							goto end_IL_0091;
						case 2:
							break;
						case 1:
							goto end_IL_0091;
						case 0:
							goto end_IL_0091;
						}
						goto IL_00cc;
						end_IL_0091:;
					}
					goto case 4;
				case 2:
					hdvqeLGSgMh54UjtNtoS(IndexLog, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138972842));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					if (Provider != null)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto default;
				case 6:
					func = (_003C_003Ec._003C_003E9__21_0 = () => new IndexCallInfo(IndexCallsType.Delete));
					break;
				}
				break;
			}
			indexCallInfo = DiagnosticsManager.StartCall(func);
			num = 5;
		}
	}

	private IFullTextSearchObjectContainer ObjectByEntity(Type cardType, IEntity entity)
	{
		//Discarded unreachable code: IL_0144, IL_0153
		int num = 3;
		int num2 = num;
		_003C_003Ec__DisplayClass22_0 _003C_003Ec__DisplayClass22_ = default(_003C_003Ec__DisplayClass22_0);
		while (true)
		{
			switch (num2)
			{
			case 5:
				return _003C_003Ec__DisplayClass22_.wrapper;
			case 7:
				if (anfqmHGSj9HNVWQ9uJmi(_003C_003Ec__DisplayClass22_.wrapper) != null)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
					{
						num2 = 8;
					}
					break;
				}
				goto case 5;
			case 1:
				if (_003C_003Ec__DisplayClass22_.entity != null)
				{
					num2 = 4;
					break;
				}
				goto case 6;
			case 6:
				return null;
			case 4:
				_003C_003Ec__DisplayClass22_.wrapper = new FullTextSearchObjectContainer
				{
					SearchObject = (k7udifGS5LS4W4XHDujW(_003C_003Ec__DisplayClass22_.cardType) as IFullTextSearchObject)
				};
				num2 = 7;
				break;
			case 3:
				_003C_003Ec__DisplayClass22_ = new _003C_003Ec__DisplayClass22_0();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				_003C_003Ec__DisplayClass22_.cardType = cardType;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
				{
					num2 = 0;
				}
				break;
			case 8:
				Points.ForEach(_003C_003Ec__DisplayClass22_._003CObjectByEntity_003Eb__0);
				num2 = 5;
				break;
			default:
				_003C_003Ec__DisplayClass22_.entity = entity;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public bool IndexEntities(Type cardType, List<Guid> listUid)
	{
		_003C_003Ec__DisplayClass23_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass23_0();
		CS_0024_003C_003E8__locals0.cardType = cardType;
		CS_0024_003C_003E8__locals0.listUid = listUid;
		CS_0024_003C_003E8__locals0.entities = new List<IEntity>();
		Points.ForEach(delegate(IFullTextSearchFieldsMappingsReIndexingExtension p)
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
					CS_0024_003C_003E8__locals0.entities.AddRange(p.GetEntities(CS_0024_003C_003E8__locals0.cardType, CS_0024_003C_003E8__locals0.listUid));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		});
		return IndexEntities(CS_0024_003C_003E8__locals0.cardType, CS_0024_003C_003E8__locals0.entities);
	}

	public bool IndexEntities(Type cardType, List<long> listId)
	{
		_003C_003Ec__DisplayClass24_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass24_0();
		CS_0024_003C_003E8__locals0.cardType = cardType;
		CS_0024_003C_003E8__locals0.listId = listId;
		CS_0024_003C_003E8__locals0.entities = new List<IEntity>();
		Points.ForEach(delegate(IFullTextSearchFieldsMappingsReIndexingExtension p)
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
					CS_0024_003C_003E8__locals0.entities.AddRange(p.GetEntities(CS_0024_003C_003E8__locals0.cardType, CS_0024_003C_003E8__locals0.listId));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		});
		return IndexEntities(CS_0024_003C_003E8__locals0.cardType, CS_0024_003C_003E8__locals0.entities);
	}

	private bool IndexEntities(Type cardType, IEnumerable<IEntity> list)
	{
		List<IFullTextSearchObjectContainer> list2 = new List<IFullTextSearchObjectContainer>();
		foreach (IEntity item in list)
		{
			if (item != null)
			{
				IFullTextSearchObjectContainer fullTextSearchObjectContainer = ObjectByEntity(cardType, item);
				if (fullTextSearchObjectContainer?.SearchObject != null)
				{
					list2.Add(fullTextSearchObjectContainer);
				}
			}
		}
		return IndexMany(cardType, list2);
	}

	private bool IsIndexingOn()
	{
		return GetIndexState() == FullTextSearchState.On;
	}

	public bool ReIndexAllEntities(IIndexQueue item, string dirtyValues, out bool breakBecauseIsIndexAll)
	{
		//Discarded unreachable code: IL_004e, IL_00d5, IL_013e, IL_014d, IL_019e, IL_022e, IL_02b6, IL_02ee, IL_033d, IL_0375, IL_0428, IL_053f, IL_054e
		int num = 3;
		int num2 = num;
		_003C_003Ec__DisplayClass27_0 CS_0024_003C_003E8__locals0;
		ContinueInfo continueInfo = default(ContinueInfo);
		IEnumerator<Type> enumerator = default(IEnumerator<Type>);
		Type current = default(Type);
		_003C_003Ec__DisplayClass27_1 _003C_003Ec__DisplayClass27_ = default(_003C_003Ec__DisplayClass27_1);
		KeyValuePair<Type, Guid> keyValuePair = default(KeyValuePair<Type, Guid>);
		bool result = default(bool);
		ContinueInfo.PageInfo value = default(ContinueInfo.PageInfo);
		Guid guid = default(Guid);
		while (true)
		{
			switch (num2)
			{
			default:
				try
				{
					CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass27_0();
					int num3 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
					{
						num3 = 1;
					}
					while (true)
					{
						switch (num3)
						{
						case 1:
							continueInfo = ParseContinueInfo(dirtyValues);
							num3 = 4;
							continue;
						case 5:
							Points.ForEach(delegate(IFullTextSearchFieldsMappingsReIndexingExtension p)
							{
								int num10 = 1;
								int num11 = num10;
								while (true)
								{
									switch (num11)
									{
									default:
										return;
									case 1:
										CS_0024_003C_003E8__locals0.typePairs.AddRange(p.GetSupportedCardTypes());
										num11 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
										{
											num11 = 0;
										}
										break;
									case 0:
										return;
									}
								}
							});
							num3 = 2;
							continue;
						case 4:
							CS_0024_003C_003E8__locals0.typePairs = new List<KeyValuePair<Type, Guid>>();
							num3 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
							{
								num3 = 5;
							}
							continue;
						default:
							try
							{
								while (true)
								{
									IL_0278:
									int num4;
									if (!PYbCwxGSsp1ZhpISAUCy(enumerator))
									{
										num4 = 3;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
										{
											num4 = 14;
										}
										goto IL_00e3;
									}
									goto IL_0205;
									IL_0205:
									current = enumerator.Current;
									num4 = 16;
									goto IL_00e3;
									IL_00e3:
									while (true)
									{
										int num5;
										switch (num4)
										{
										case 1:
											if (!CS_0024_003C_003E8__locals0.typePairs.Any(_003C_003Ec__DisplayClass27_._003CReIndexAllEntities_003Eb__3))
											{
												num5 = 3;
												goto IL_00df;
											}
											goto default;
										case 16:
											_003C_003Ec__DisplayClass27_ = new _003C_003Ec__DisplayClass27_1();
											num5 = 15;
											goto IL_00df;
										case 15:
											if (IsIndexingOn())
											{
												num4 = 18;
												continue;
											}
											goto case 2;
										default:
											keyValuePair = CS_0024_003C_003E8__locals0.typePairs.First(_003C_003Ec__DisplayClass27_._003CReIndexAllEntities_003Eb__4);
											num4 = 12;
											continue;
										case 17:
											result = ReIndexAllEntitiesByType(current, out breakBecauseIsIndexAll, item, null, value, fromIndexAll: true);
											num4 = 6;
											continue;
										case 10:
											break;
										case 13:
											if (continueInfo == null)
											{
												num4 = 9;
												continue;
											}
											goto case 8;
										case 3:
										case 7:
											if (!sVMlM4GSUnxTQ9AY6k0g(guid, Guid.Empty))
											{
												num5 = 5;
												goto IL_00df;
											}
											goto case 13;
										case 4:
											guid = Guid.Empty;
											num4 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
											{
												num4 = 0;
											}
											continue;
										case 5:
										case 9:
										case 11:
											goto IL_0278;
										case 12:
											guid = keyValuePair.Value;
											num4 = 7;
											continue;
										case 2:
											throw new StopIndexingException();
										case 18:
											_003C_003Ec__DisplayClass27_.typeF = current;
											num4 = 4;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
											{
												num4 = 0;
											}
											continue;
										case 8:
											if (continueInfo.PagesInfo.TryGetValue(guid, out value))
											{
												num4 = 17;
												continue;
											}
											goto IL_0278;
										case 14:
											goto end_IL_0278;
										case 6:
											{
												return result;
											}
											IL_00df:
											num4 = num5;
											continue;
										}
										break;
									}
									goto IL_0205;
									continue;
									end_IL_0278:
									break;
								}
							}
							finally
							{
								if (enumerator != null)
								{
									int num6 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
									{
										num6 = 0;
									}
									while (true)
									{
										switch (num6)
										{
										default:
											enumerator.Dispose();
											num6 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
											{
												num6 = 1;
											}
											continue;
										case 1:
											break;
										}
										break;
									}
								}
							}
							break;
						case 2:
							enumerator = (from t in CS_0024_003C_003E8__locals0.typePairs.Select((KeyValuePair<Type, Guid> p) => p.Key).ToList()
								where t != null
								select t).Distinct().GetEnumerator();
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
							{
								num3 = 0;
							}
							continue;
						case 3:
							break;
						}
						break;
					}
				}
				catch (StopIndexingException)
				{
					int num7 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
					{
						num7 = 0;
					}
					while (true)
					{
						switch (num7)
						{
						case 1:
							breakBecauseIsIndexAll = false;
							num7 = 2;
							continue;
						case 2:
							throw;
						}
						IndexLog.Warn(string.Format((string)fgHpoSGSY0ad2L8AABrV(-606654180 ^ -606780888), FullTextSearchConst.StopIndexTextLog, fgHpoSGSY0ad2L8AABrV(-210725949 ^ -210543337)));
						num7 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
						{
							num7 = 1;
						}
					}
				}
				catch (Exception ex2)
				{
					int num8 = 3;
					while (true)
					{
						switch (num8)
						{
						case 3:
							yWlb45GiF4OqXGSKdj5C(IndexLog, xlNxXoGSzg7OR7SnOT7b(fgHpoSGSY0ad2L8AABrV(-542721635 ^ -542804127), rqsk9HGSc47bwP4Fdy7P(ex2)), ex2);
							num8 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
							{
								num8 = 1;
							}
							break;
						default:
						{
							result = false;
							int num9 = 2;
							num8 = num9;
							break;
						}
						case 1:
							breakBecauseIsIndexAll = false;
							num8 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
							{
								num8 = 0;
							}
							break;
						case 2:
							return result;
						}
					}
				}
				break;
			case 3:
				hdvqeLGSgMh54UjtNtoS(IndexLog, JLRHGAGSLN1tDB5iTsUG(fgHpoSGSY0ad2L8AABrV(-2106517564 ^ -2106402544), Array.Empty<object>()));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
				{
					num2 = 1;
				}
				continue;
			case 2:
				breakBecauseIsIndexAll = false;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
				{
					num2 = 0;
				}
				continue;
			case 1:
				break;
			}
			break;
		}
		return true;
	}

	public IndexResult ReIndexingByType(IIndexQueue item)
	{
		//Discarded unreachable code: IL_0085, IL_0094
		int num = 1;
		int num2 = num;
		Guid? cardTypeUid = default(Guid?);
		ContinueInfo continueInfo = default(ContinueInfo);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (jeMXU7GiWtpq7MWtlP8R(IUihCiGiBexsLfEIaEHG(item)))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 6;
			default:
				cardTypeUid = item.CardTypeUid;
				num2 = 8;
				break;
			case 8:
				if (cardTypeUid.HasValue)
				{
					num2 = 4;
					break;
				}
				goto case 6;
			case 2:
				return new IndexResult();
			case 3:
				WqHVPZGibtl6FoX1rRXQ(item);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
				{
					num2 = 2;
				}
				break;
			case 7:
				item.DirtyValues = ConvertToContinueInfo(continueInfo);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
				{
					num2 = 3;
				}
				break;
			case 5:
			{
				Dictionary<Guid, ContinueInfo.PageInfo> pagesInfo = continueInfo.PagesInfo;
				cardTypeUid = item.CardTypeUid;
				pagesInfo.Add(cardTypeUid.Value, new ContinueInfo.PageInfo());
				num2 = 7;
				break;
			}
			case 9:
				continueInfo = new ContinueInfo();
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
				{
					num2 = 5;
				}
				break;
			case 6:
			{
				IndexResult indexResult = new IndexResult();
				YCrOfoGioCkoucIh2GEA(indexResult, false);
				return indexResult;
			}
			case 4:
				item.QueueType = IndexQueueType.IndexAll;
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
				{
					num2 = 9;
				}
				break;
			}
		}
	}

	public bool ReIndexAllEntitiesByType(Type cardType, Guid? typeUidFilter = null)
	{
		bool breakBecauseIsIndexAll;
		return ReIndexAllEntitiesByType(cardType, out breakBecauseIsIndexAll, null, typeUidFilter);
	}

	private bool ReIndexAllEntitiesByType(Type cardType, out bool breakBecauseIsIndexAll, IIndexQueue item = null, Guid? typeUidFilter = null, ContinueInfo.PageInfo pageInfo = null, bool fromIndexAll = false)
	{
		_003C_003Ec__DisplayClass30_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass30_0();
		CS_0024_003C_003E8__locals0.cardType = cardType;
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		IndexLog.Warn(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1637C429 ^ 0x16340B17));
		breakBecauseIsIndexAll = false;
		CS_0024_003C_003E8__locals0.lastId = null;
		CS_0024_003C_003E8__locals0.pageIndex = null;
		int num = 0;
		CS_0024_003C_003E8__locals0.typePairs = new List<KeyValuePair<Type, Guid>>();
		Points.ForEach(delegate(IFullTextSearchFieldsMappingsReIndexingExtension p)
		{
			int num2 = 1;
			int num3 = num2;
			while (true)
			{
				switch (num3)
				{
				default:
					return;
				case 1:
					CS_0024_003C_003E8__locals0.typePairs.AddRange(p.GetSupportedCardTypes());
					num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
					{
						num3 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		});
		Guid guid = Guid.Empty;
		if (CS_0024_003C_003E8__locals0.typePairs.Any((KeyValuePair<Type, Guid> p) => p.Key == CS_0024_003C_003E8__locals0.cardType))
		{
			guid = CS_0024_003C_003E8__locals0.typePairs.FirstOrDefault((KeyValuePair<Type, Guid> p) => p.Key == CS_0024_003C_003E8__locals0.cardType).Value;
		}
		try
		{
			if (pageInfo != null && (pageInfo.LastId.HasValue || pageInfo.Page.HasValue))
			{
				num = pageInfo.Attempt;
				if (pageInfo.LastId.HasValue)
				{
					CS_0024_003C_003E8__locals0.lastId = pageInfo.LastId;
				}
				else
				{
					CS_0024_003C_003E8__locals0.pageIndex = pageInfo.Page + 1;
				}
			}
			if (pageInfo == null || (!pageInfo.LastId.HasValue && !pageInfo.Page.HasValue))
			{
				DeleteAllFromType(CS_0024_003C_003E8__locals0.cardType);
			}
			bool flag = true;
			while (flag)
			{
				_003C_003Ec__DisplayClass30_1 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass30_1();
				CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1 = CS_0024_003C_003E8__locals0;
				CS_0024_003C_003E8__locals1.typeListFilter = null;
				if (typeUidFilter.HasValue && MetadataLoader.LoadMetadata(typeUidFilter.Value) is ClassMetadata metadata)
				{
					CS_0024_003C_003E8__locals1.typeListFilter = (from m in MetadataLoader.GetChildClasses(metadata)
						select _003C_003Ec.i6r182vUDqeGg8a5r72e(m)).ToList();
				}
				IEntity[] array = Points.SelectMany((IFullTextSearchFieldsMappingsReIndexingExtension p) => (!CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.pageIndex.HasValue) ? p.LoadEntities(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.cardType, CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.lastId, CS_0024_003C_003E8__locals1.typeListFilter) : p.LoadEntitiesByPage(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.cardType, CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.pageIndex.Value, CS_0024_003C_003E8__locals1.typeListFilter)).ToArray();
				if (array.Length != 0)
				{
					List<IFullTextSearchObjectContainer> objects = (from e in array
						select CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1._003C_003E4__this.ObjectByEntity(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.cardType, e) into o
						where o != null
						select o).ToList();
					IndexMany(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.cardType, objects);
					CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.pageIndex = null;
					CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.lastId = array.Max((IEntity e) => (long)_003C_003Ec.kl8R0UvUtTlH6g0PcnMj(e));
					if (item != null && item.QueueType == IndexQueueType.IndexAll)
					{
						SaveDirtyInfoProgres(item, guid, CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.lastId, num, CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.cardType);
					}
				}
				else
				{
					flag = false;
					if (fromIndexAll && item != null && item.QueueType == IndexQueueType.IndexAll && guid != Guid.Empty)
					{
						ContinueInfo continueInfo = ParseContinueInfo(item.DirtyValues);
						continueInfo.RemovePageInfo(guid);
						if (continueInfo.PagesInfo.Count > 0)
						{
							breakBecauseIsIndexAll = true;
							item.DirtyValues = ConvertToContinueInfo(continueInfo);
							item.Save();
						}
					}
				}
				if (fromIndexAll)
				{
					if (flag)
					{
						breakBecauseIsIndexAll = true;
					}
					flag = false;
				}
			}
			return true;
		}
		catch (StopIndexingException)
		{
			SaveDirtyInfoProgres(item, guid, CS_0024_003C_003E8__locals0.lastId, ++num, CS_0024_003C_003E8__locals0.cardType);
			IndexLog.Warn(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70142919), FullTextSearchConst.StopIndexTextLog, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x92F12D5 ^ 0x92CDDEB)));
			throw;
		}
		catch (Exception ex2)
		{
			SaveDirtyInfoProgres(item, guid, CS_0024_003C_003E8__locals0.lastId, ++num, CS_0024_003C_003E8__locals0.cardType);
			IndexLog.Error(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-561074844 ^ -561159658), ex2.Message), ex2);
			return false;
		}
	}

	public bool ReIndexByPropertyList(Type cardType, List<IEnumerable<KeyValuePair<string, object>>> listProperty)
	{
		List<ToReindex> list = new List<ToReindex>();
		bool result = true;
		foreach (IEnumerable<KeyValuePair<string, object>> item in listProperty)
		{
			WebData webData = new WebData(item.Where((KeyValuePair<string, object> p) => !(p.Value is FieldIndexListItem)));
			FieldIndexList fieldIndexList = new FieldIndexList();
			fieldIndexList.AddRange(from p in item
				select p.Value as FieldIndexListItem into p
				where p != null
				select p);
			if (webData.Items.Any((WebDataItem d) => _003C_003Ec.vbvt37vU4gjTtEJeNjKw(((string)_003C_003Ec.nyQSMjvUwkScujl568C2(d)).ToLower(), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1876063057 ^ -1876115499))))
			{
				list.Add(new ToReindex(webData.Items.First((WebDataItem d) => _003C_003Ec.vbvt37vU4gjTtEJeNjKw(d.Name.ToLower(), _003C_003Ec.qXF8E7vU6H5f9gr5Mho7(-1710575414 ^ -1710521424))).Value, webData, fieldIndexList));
			}
			else
			{
				IndexLog.Info(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x76DD48E ^ 0x76E1B4A), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-29254301 ^ -29207919)));
			}
		}
		if (list.Any())
		{
			while (list.Count > 0)
			{
				List<ToReindex> list2 = new List<ToReindex>();
				int count = ((100 <= list.Count) ? 100 : list.Count);
				list2.AddRange(list.GetRange(0, count));
				if (list2.Any())
				{
					try
					{
						if (!ReIndexMany(cardType, list2))
						{
							result = false;
						}
					}
					catch (Exception)
					{
						return false;
					}
				}
				list.RemoveRange(0, count);
			}
		}
		return result;
	}

	public FullTextSearchState GetIndexState()
	{
		int num = 2;
		int num2 = num;
		FullTextSearchState? bLOB = default(FullTextSearchState?);
		while (true)
		{
			switch (num2)
			{
			default:
				return FullTextSearchState.Off;
			case 1:
				if (bLOB.HasValue)
				{
					return bLOB.Value;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				bLOB = BlobManager.GetBLOB<FullTextSearchState?>(BlobFullTextSearchStateUid, (string)fgHpoSGSY0ad2L8AABrV(-1123633026 ^ -1123718954));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public void SetOffIndexState()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				BlobManager.SetBLOB(BlobFullTextSearchStateUid, (string)fgHpoSGSY0ad2L8AABrV(-1487388570 ^ -1487171378), (FullTextSearchState?)FullTextSearchState.Off);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			case 1:
				hdvqeLGSgMh54UjtNtoS(IndexLog, JLRHGAGSLN1tDB5iTsUG(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740522712), Array.Empty<object>()));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void SetReadyIndexState()
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
				BlobManager.SetBLOB(BlobFullTextSearchStateUid, (string)fgHpoSGSY0ad2L8AABrV(-1870892489 ^ -1870683489), (FullTextSearchState?)FullTextSearchState.Ready);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 2:
				hdvqeLGSgMh54UjtNtoS(IndexLog, JLRHGAGSLN1tDB5iTsUG(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1637C429 ^ 0x16341509), Array.Empty<object>()));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void SetOnIndexState()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				hdvqeLGSgMh54UjtNtoS(IndexLog, JLRHGAGSLN1tDB5iTsUG(fgHpoSGSY0ad2L8AABrV(0x63ABA4E8 ^ 0x63A875A0), Array.Empty<object>()));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				BlobManager.SetBLOB(BlobFullTextSearchStateUid, (string)fgHpoSGSY0ad2L8AABrV(-629844702 ^ -629766774), (FullTextSearchState?)FullTextSearchState.On);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void StartIndexing()
	{
		//Discarded unreachable code: IL_0079, IL_0088
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 6:
				((IndexQueueManager)uZcdBBGihaiGwKchLmPA()).ClearQueue();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
				{
					num2 = 3;
				}
				break;
			case 7:
				SetOnIndexState();
				num2 = 6;
				break;
			case 4:
				return;
			case 2:
				hdvqeLGSgMh54UjtNtoS(IndexLog, string.Format((string)fgHpoSGSY0ad2L8AABrV(-957824448 ^ -957672662)));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
				{
					num2 = 1;
				}
				break;
			default:
			{
				IIndexQueue indexQueue = InterfaceActivator.Create<IIndexQueue>();
				indexQueue.QueueType = IndexQueueType.IndexAll;
				indexQueue.Save();
				num2 = 8;
				break;
			}
			case 3:
				Provider.DeleteIndex();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
				{
					num2 = 0;
				}
				break;
			case 8:
				return;
			case 5:
				if (Provider == null)
				{
					num2 = 4;
					break;
				}
				goto case 7;
			case 1:
				BlobManager.RemoveBLOB<string>(BlobFullTextSearchStopedInfoUid, (string)fgHpoSGSY0ad2L8AABrV(-2106517564 ^ -2106407346));
				num2 = 5;
				break;
			}
		}
	}

	public void StartReIndexing()
	{
		//Discarded unreachable code: IL_006f, IL_007e
		int num = 9;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 6:
				if (GetIndexState() == FullTextSearchState.On)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
					{
						num2 = 2;
					}
					break;
				}
				return;
			case 4:
				return;
			case 9:
				hdvqeLGSgMh54UjtNtoS(IndexLog, JLRHGAGSLN1tDB5iTsUG(fgHpoSGSY0ad2L8AABrV(0x34185E55 ^ 0x341B8FBD), Array.Empty<object>()));
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
				{
					num2 = 8;
				}
				break;
			case 2:
				SetOnIndexState();
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
				{
					num2 = 7;
				}
				break;
			case 3:
				SetOffIndexState();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				return;
			case 1:
				Hgh1CtGiGIgc4Doh2UBG(uZcdBBGihaiGwKchLmPA());
				num2 = 2;
				break;
			case 7:
			{
				IIndexQueue indexQueue = InterfaceActivator.Create<IIndexQueue>();
				indexQueue.QueueType = IndexQueueType.IndexAll;
				WqHVPZGibtl6FoX1rRXQ(indexQueue);
				num2 = 5;
				break;
			}
			default:
				if (Provider == null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 6;
			case 8:
				BlobManager.RemoveBLOB<string>(BlobFullTextSearchStopedInfoUid, (string)fgHpoSGSY0ad2L8AABrV(0x4A1640F ^ 0x4A2B585));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void StopIndexing()
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
				StopIndexing(null);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public void StopIndexing(string info)
	{
		//Discarded unreachable code: IL_0051, IL_012a, IL_0139, IL_0186, IL_0195
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				edCG0IGiE5iyIX4YhmTN(Provider);
				num2 = 6;
				break;
			case 5:
				if (Provider == null)
				{
					num2 = 7;
					break;
				}
				goto default;
			case 1:
			case 11:
				IndexLog.Warn(string.Format((string)fgHpoSGSY0ad2L8AABrV(-541731959 ^ -541720131)));
				num2 = 9;
				break;
			case 2:
				if (jeMXU7GiWtpq7MWtlP8R(info))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 3;
			case 3:
				hdvqeLGSgMh54UjtNtoS(IndexLog, xlNxXoGSzg7OR7SnOT7b(fgHpoSGSY0ad2L8AABrV(-882126494 ^ -882375826), info));
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
				{
					num2 = 1;
				}
				break;
			case 8:
			case 9:
				SetOffIndexState();
				num2 = 10;
				break;
			case 6:
				return;
			case 7:
				return;
			case 4:
				BlobManager.SetBLOB(BlobFullTextSearchStopedInfoUid, (string)fgHpoSGSY0ad2L8AABrV(-289714582 ^ -289890336), info);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
				{
					num2 = 8;
				}
				break;
			case 10:
				((IndexQueueManager)uZcdBBGihaiGwKchLmPA()).ClearQueue();
				num2 = 5;
				break;
			}
		}
	}

	public string GetStopIndexingInfo()
	{
		return BlobManager.GetBLOB<string>(BlobFullTextSearchStopedInfoUid, (string)fgHpoSGSY0ad2L8AABrV(-606654180 ^ -606805866));
	}

	public void StopIndexingType(Type type)
	{
		//Discarded unreachable code: IL_00e6
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				IndexLog.Warn(string.Format((string)fgHpoSGSY0ad2L8AABrV(-2112703338 ^ -2112788796), xIKfLlGiffaEnnuG2fHR(type)));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				return;
			case 4:
				return;
			default:
				if (Provider == null)
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
					{
						num2 = 4;
					}
					continue;
				}
				break;
			case 2:
				DeleteAllFromType(type);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
				{
					num2 = 0;
				}
				continue;
			case 5:
				break;
			}
			if (GetIndexState() != FullTextSearchState.On)
			{
				break;
			}
			num2 = 2;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
			{
				num2 = 1;
			}
		}
	}

	public FullTextSearchResultModel Find(Type cardType, FullTextSearchResultModel resultModel, IEntityFilter filter, SerializableFilter filterFields, List<Guid> selectedColumns, int firstResult, int maxResult, string sortExpression, ListSortDirection sortDirection)
	{
		_003C_003Ec__DisplayClass48_0 _003C_003Ec__DisplayClass48_ = new _003C_003Ec__DisplayClass48_0();
		_003C_003Ec__DisplayClass48_.cardType = cardType;
		using IndexCallInfo indexCallInfo = DiagnosticsManager.StartCall(() => new IndexCallInfo(IndexCallsType.Find));
		try
		{
			_003C_003Ec__DisplayClass48_1 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass48_1();
			CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass48_;
			if (Provider == null || filter == null)
			{
				return null;
			}
			if (!IndexingIsWorking())
			{
				return null;
			}
			FilterForAttribute filterForAttribute = (FilterForAttribute)filter.GetType().GetCustomAttributes(typeof(FilterForAttribute), inherit: true).FirstOrDefault();
			if (filterForAttribute == null)
			{
				return null;
			}
			EntityMetadata entityMetadata = (EntityMetadata)MetadataLoader.LoadMetadata(filterForAttribute.EntityType);
			if (entityMetadata == null)
			{
				return null;
			}
			CS_0024_003C_003E8__locals1.allPropertiesAndClasses = MetadataLoader.GetChildProperties(entityMetadata);
			List<EntityPropertyMetadata> list = CS_0024_003C_003E8__locals1.allPropertiesAndClasses.Select((KeyValuePair<PropertyMetadata, ClassMetadata> p) => p.Key).OfType<EntityPropertyMetadata>().ToList();
			FieldList listSearchFields = new FieldList();
			FilterList listFilterField = new FilterList();
			ProcessingFilter(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.cardType, resultModel, filter, filterFields, out var listFastSearch, listSearchFields, listFilterField, list);
			CS_0024_003C_003E8__locals1.listReturnFields = new List<string>();
			Points.ForEach(delegate(IFullTextSearchFieldsMappingsReIndexingExtension p)
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
						CS_0024_003C_003E8__locals1.listReturnFields.AddRange(p.GetFields(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.cardType));
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
						{
							num4 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			});
			if (selectedColumns != null)
			{
				foreach (Guid selectedColumn in selectedColumns)
				{
					_003C_003Ec__DisplayClass48_2 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass48_2();
					CS_0024_003C_003E8__locals0.selectedColumnF = selectedColumn;
					EntityPropertyMetadata entityPropertyMetadata = list.FirstOrDefault((EntityPropertyMetadata p) => _003C_003Ec__DisplayClass48_2.jXhenCvsigibUYYMnElx(p) == CS_0024_003C_003E8__locals0.selectedColumnF);
					if (entityPropertyMetadata == null)
					{
						continue;
					}
					IFullTextSearchDescriptorService serviceNotNull = Locator.GetServiceNotNull<IFullTextSearchDescriptorService>();
					if (!serviceNotNull.IsSupportedSearchInIndex(entityPropertyMetadata))
					{
						throw new FullTextFilterException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CACA3 ^ 0x53F7E21), entityPropertyMetadata.TypeUid, entityPropertyMetadata.SubTypeUid, entityPropertyMetadata.Uid, entityPropertyMetadata.Name, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7C1EE318 ^ 0x7C1D2F18)));
					}
					List<string> returnField = serviceNotNull.GetReturnField(entityPropertyMetadata);
					if (returnField != null)
					{
						CS_0024_003C_003E8__locals1.listReturnFields.AddRange(returnField.Where((string f) => !_003C_003Ec.mWGLqrvUH1yeMVRW669N(f)));
					}
				}
			}
			SortList sortList = new SortList();
			List<EntityPropertyMetadata> list2 = new List<EntityPropertyMetadata>();
			SortList defaultSortExpression = Locator.GetServiceNotNull<IFullTextSearchCardService>().GetExtensionByFilter(filter).GetDefaultSortExpression();
			if (defaultSortExpression != null)
			{
				sortList.AddRange(defaultSortExpression.Where((SortListItem s) => s != null));
			}
			_003C_003Ec__DisplayClass48_3 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass48_3();
			CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals2 = CS_0024_003C_003E8__locals1;
			CS_0024_003C_003E8__locals2.sortPropName = CustomPropertyProjection.GetExpressionFromString(sortExpression, out CS_0024_003C_003E8__locals2.entityName);
			if (CS_0024_003C_003E8__locals2.sortPropName.Contains(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x42643203 ^ 0x426428C7)))
			{
				throw new FullTextFilterException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1637C429 ^ 0x16341775), CS_0024_003C_003E8__locals2.sortPropName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886404209)));
			}
			EntityPropertyMetadata entityPropertyMetadata2 = list.FirstOrDefault(delegate(EntityPropertyMetadata p)
			{
				//Discarded unreachable code: IL_007c, IL_00b1
				int num = 1;
				int num2 = num;
				_003C_003Ec__DisplayClass48_4 _003C_003Ec__DisplayClass48_2 = default(_003C_003Ec__DisplayClass48_4);
				KeyValuePair<PropertyMetadata, ClassMetadata> keyValuePair = default(KeyValuePair<PropertyMetadata, ClassMetadata>);
				while (true)
				{
					switch (num2)
					{
					case 2:
						if (_003C_003Ec__DisplayClass48_3.oF4ZVovsTbPtpUCJGN1c(_003C_003Ec__DisplayClass48_3.zXNHo5vskeKNo6IR3P7U(_003C_003Ec__DisplayClass48_2.p).FullName, CS_0024_003C_003E8__locals2.entityName))
						{
							num2 = 5;
							break;
						}
						goto IL_0135;
					case 3:
						if (keyValuePair.Value == null)
						{
							num2 = 9;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
							{
								num2 = 9;
							}
							break;
						}
						goto case 8;
					case 6:
						return true;
					case 10:
						return false;
					case 4:
						if (_003C_003Ec__DisplayClass48_3.zXNHo5vskeKNo6IR3P7U(_003C_003Ec__DisplayClass48_2.p) != null)
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
							{
								num2 = 2;
							}
							break;
						}
						goto IL_0135;
					case 1:
						_003C_003Ec__DisplayClass48_2 = new _003C_003Ec__DisplayClass48_4();
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
						{
							num2 = 0;
						}
						break;
					default:
						_003C_003Ec__DisplayClass48_2.p = p;
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
						{
							num2 = 2;
						}
						break;
					case 5:
						return true;
					case 11:
						return true;
					case 9:
						if (_003C_003Ec__DisplayClass48_3.vHoJaGvsOVYp56Z4BU87(CS_0024_003C_003E8__locals2.entityName))
						{
							num2 = 6;
							break;
						}
						goto case 10;
					case 7:
						if (!_003C_003Ec__DisplayClass48_3.oF4ZVovsTbPtpUCJGN1c(_003C_003Ec__DisplayClass48_2.p.Name, CS_0024_003C_003E8__locals2.sortPropName))
						{
							num2 = 10;
							break;
						}
						goto case 4;
					case 8:
						{
							if (_003C_003Ec__DisplayClass48_3.oF4ZVovsTbPtpUCJGN1c(_003C_003Ec__DisplayClass48_3.tKOFUsvsnkyD5DVHoQBM(keyValuePair.Value), CS_0024_003C_003E8__locals2.entityName))
							{
								num2 = 11;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
								{
									num2 = 4;
								}
								break;
							}
							goto case 9;
						}
						IL_0135:
						keyValuePair = CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals2.allPropertiesAndClasses.FirstOrDefault(_003C_003Ec__DisplayClass48_2._003CFind_003Eb__7);
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
						{
							num2 = 3;
						}
						break;
					}
				}
			});
			if (entityPropertyMetadata2 != null)
			{
				list2.Add(entityPropertyMetadata2);
			}
			IFullTextSearchDescriptorService serviceNotNull2 = Locator.GetServiceNotNull<IFullTextSearchDescriptorService>();
			foreach (EntityPropertyMetadata item in list2)
			{
				if (item != null)
				{
					if (!serviceNotNull2.IsSupportedSearchInIndex(item))
					{
						throw new FullTextFilterException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x68BBB53E ^ 0x68B867BC), item.TypeUid, item.SubTypeUid, item.Uid, item.Name, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1998538950 ^ -1998357702)));
					}
					SortListItem sortField = serviceNotNull2.GetSortField(item);
					if (sortField == null)
					{
						throw new FullTextFilterException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12441CA4 ^ 0x1247CF7E), item.TypeUid, item.SubTypeUid, item.Uid, item.Name, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-210725949 ^ -210542653)));
					}
					sortField.Direction = sortDirection;
					sortList.Add(sortField);
				}
			}
			resultModel = Provider.Find(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.cardType, listFastSearch, listSearchFields, listFilterField, CS_0024_003C_003E8__locals1.listReturnFields, sortList, firstResult, maxResult);
			if (resultModel != null)
			{
				resultModel.ListReturnFields = new List<string>();
				resultModel.ListReturnFields.AddRange(CS_0024_003C_003E8__locals1.listReturnFields);
			}
			return resultModel;
		}
		catch (FullTextFilterException exception)
		{
			if (indexCallInfo != null)
			{
				indexCallInfo.IsCancel = true;
			}
			IndexLog.Warn(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1979251663 ^ -1979398095), exception);
			return null;
		}
		catch (Exception ex)
		{
			if (indexCallInfo != null)
			{
				indexCallInfo.Exception = ex;
			}
			Logger.Log.Error(ex);
			return null;
		}
	}

	public FullTextSearchResultModel Find(Type cardType, List<string> listReturnFields, FilterList listFilterFields, SortList listSortFields, int firstResult, int maxResult)
	{
		using IndexCallInfo indexCallInfo = DiagnosticsManager.StartCall(() => new IndexCallInfo(IndexCallsType.Find));
		try
		{
			if (Provider == null)
			{
				return null;
			}
			if (!IndexingIsWorking())
			{
				return null;
			}
			FullTextSearchResultModel fullTextSearchResultModel = Provider.Find(cardType, listReturnFields, listFilterFields, listSortFields, maxResult);
			if (fullTextSearchResultModel != null)
			{
				fullTextSearchResultModel.ListReturnFields = new List<string>();
				fullTextSearchResultModel.ListReturnFields.AddRange(listReturnFields);
			}
			return fullTextSearchResultModel;
		}
		catch (FullTextFilterException exception)
		{
			if (indexCallInfo != null)
			{
				indexCallInfo.IsCancel = true;
			}
			IndexLog.Warn(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4EDCBA32 ^ 0x4EDF7632), exception);
			return null;
		}
		catch (Exception ex)
		{
			if (indexCallInfo != null)
			{
				indexCallInfo.Exception = ex;
			}
			Logger.Log.Error(ex);
			return null;
		}
	}

	public FullTextSearchResultModel Count(Type cardType, FullTextSearchResultModel resultModel, IEntityFilter filter, SerializableFilter filterFields)
	{
		//Discarded unreachable code: IL_00db, IL_00ea, IL_00f9, IL_0157, IL_0173, IL_019f, IL_01ae, IL_023c, IL_0297, IL_03b0, IL_03ec, IL_04ab, IL_04e3
		int num = 2;
		int num2 = num;
		FullTextSearchResultModel result = default(FullTextSearchResultModel);
		FilterList filterList = default(FilterList);
		EntityMetadata entityMetadata = default(EntityMetadata);
		FilterForAttribute filterForAttribute = default(FilterForAttribute);
		FieldList fieldList = default(FieldList);
		FastSearchList listFastSearch = default(FastSearchList);
		IEnumerable<EntityPropertyMetadata> allProperties = default(IEnumerable<EntityPropertyMetadata>);
		IndexCallInfo indexCallInfo = default(IndexCallInfo);
		while (true)
		{
			Func<IndexCallInfo> func;
			switch (num2)
			{
			default:
				try
				{
					int num3;
					if (Provider != null)
					{
						num3 = 22;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
						{
							num3 = 19;
						}
						goto IL_0057;
					}
					goto IL_0115;
					IL_0115:
					result = null;
					num3 = 13;
					goto IL_0057;
					IL_0057:
					while (true)
					{
						int num4;
						switch (num3)
						{
						case 10:
						case 17:
							if (!IndexingIsWorking())
							{
								num3 = 7;
								continue;
							}
							goto default;
						case 20:
							filterList = new FilterList();
							num3 = 12;
							continue;
						case 4:
							break;
						case 3:
						case 23:
							entityMetadata = (EntityMetadata)MetadataLoader.LoadMetadata(YONWoKGivAn5rAEsK5J2(filterForAttribute));
							num4 = 8;
							goto IL_0053;
						case 6:
							result = null;
							num3 = 2;
							continue;
						case 18:
							result = resultModel;
							num3 = 11;
							continue;
						case 7:
							result = null;
							num3 = 15;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
							{
								num3 = 9;
							}
							continue;
						case 21:
							fieldList = new FieldList();
							num4 = 20;
							goto IL_0053;
						default:
							filterForAttribute = (FilterForAttribute)((IEnumerable<object>)nZdevOGiCjXQLHCGMG3P(filter.GetType(), N0YHeUGiQUGa1dkfn9sT(typeof(FilterForAttribute).TypeHandle), true)).FirstOrDefault();
							num3 = 4;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
							{
								num3 = 5;
							}
							continue;
						case 12:
							ProcessingFilter(cardType, resultModel, filter, filterFields, out listFastSearch, fieldList, filterList, allProperties);
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
							{
								num3 = 1;
							}
							continue;
						case 14:
							result = null;
							num3 = 16;
							continue;
						case 22:
							if (filter != null)
							{
								num3 = 10;
								continue;
							}
							break;
						case 5:
							if (filterForAttribute != null)
							{
								num3 = 3;
								continue;
							}
							goto case 6;
						case 1:
							resultModel = (FullTextSearchResultModel)n3E0XCGi89O8Hx3rHcmt(Provider, cardType, listFastSearch, fieldList, filterList);
							num3 = 18;
							continue;
						case 8:
							if (entityMetadata != null)
							{
								num3 = 19;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
								{
									num3 = 16;
								}
								continue;
							}
							goto case 14;
						case 9:
						case 19:
							allProperties = (from p in MetadataLoader.GetChildProperties(entityMetadata)
								select p.Key).OfType<EntityPropertyMetadata>();
							num3 = 21;
							continue;
						case 2:
							return result;
						case 11:
							return result;
						case 13:
							return result;
						case 15:
							return result;
						case 16:
							{
								return result;
							}
							IL_0053:
							num3 = num4;
							continue;
						}
						break;
					}
					goto IL_0115;
				}
				catch (FullTextFilterException ex)
				{
					int num5 = 4;
					while (true)
					{
						switch (num5)
						{
						case 4:
							if (indexCallInfo == null)
							{
								num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
								{
									num5 = 1;
								}
								break;
							}
							goto case 5;
						case 1:
						case 2:
							re6dvsGiuu9xh5PL6xcT(IndexLog, fgHpoSGSY0ad2L8AABrV(0x53FA00CE ^ 0x53F9CCCE), ex);
							num5 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
							{
								num5 = 3;
							}
							break;
						case 5:
						{
							S0O4qnGiZ6KY5VOVXGxF(indexCallInfo, true);
							int num6 = 2;
							num5 = num6;
							break;
						}
						case 3:
							result = null;
							num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
							{
								num5 = 0;
							}
							break;
						default:
							return result;
						case 0:
							return result;
						}
					}
				}
				catch (Exception ex2)
				{
					int num7 = 4;
					while (true)
					{
						switch (num7)
						{
						case 1:
							((ILogger)CxCkcNGiIjAQqZOi40n0()).Error(ex2);
							num7 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
							{
								num7 = 0;
							}
							break;
						case 3:
							indexCallInfo.Exception = ex2;
							num7 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
							{
								num7 = 1;
							}
							break;
						case 4:
							if (indexCallInfo != null)
							{
								num7 = 3;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
								{
									num7 = 2;
								}
								break;
							}
							goto case 1;
						default:
							result = null;
							num7 = 2;
							break;
						case 2:
							return result;
						}
					}
				}
				finally
				{
					if (indexCallInfo != null)
					{
						int num8 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
						{
							num8 = 0;
						}
						while (true)
						{
							switch (num8)
							{
							default:
								((IDisposable)indexCallInfo).Dispose();
								num8 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
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
				}
			case 2:
				func = _003C_003Ec._003C_003E9__50_0;
				if (func == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			case 3:
				return result;
			case 1:
				func = (_003C_003Ec._003C_003E9__50_0 = () => new IndexCallInfo(IndexCallsType.Count));
				break;
			}
			indexCallInfo = DiagnosticsManager.StartCall(func);
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
			{
				num2 = 0;
			}
		}
	}

	private void ProcessingFilter(Type cardType, FullTextSearchResultModel resultModel, IEntityFilter filter, SerializableFilter filterFields, out FastSearchList listFastSearch, FieldList listSearchFields, FilterList listFilterField, IEnumerable<EntityPropertyMetadata> allProperties)
	{
		_003C_003Ec__DisplayClass51_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass51_0();
		CS_0024_003C_003E8__locals0.cardType = cardType;
		CS_0024_003C_003E8__locals0.filter = filter;
		CS_0024_003C_003E8__locals0.resultModel = resultModel;
		CS_0024_003C_003E8__locals0.listFilterField = listFilterField;
		if (!string.IsNullOrWhiteSpace(CS_0024_003C_003E8__locals0.filter.Query))
		{
			throw new FullTextFilterException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87523133)));
		}
		_003C_003Ec__DisplayClass51_1 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass51_1();
		CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1 = CS_0024_003C_003E8__locals0;
		CS_0024_003C_003E8__locals1.forListFastSearch = new List<string>();
		List<EntityPropertyMetadata> source = allProperties.Where(delegate(EntityPropertyMetadata p)
		{
			//Discarded unreachable code: IL_0031, IL_0040
			int num13 = 3;
			int num14 = num13;
			while (true)
			{
				switch (num14)
				{
				default:
					return _003C_003Ec.K9QumfvU7lsfml8AXi6p(p.TypeUid, TextDescriptor.UID);
				case 1:
					return true;
				case 3:
					if (!_003C_003Ec.Eo91D2vUAlxtrwOBZn9D(p))
					{
						return false;
					}
					num14 = 2;
					break;
				case 2:
					if (_003C_003Ec.K9QumfvU7lsfml8AXi6p(p.TypeUid, StringDescriptor.UID))
					{
						num14 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
						{
							num14 = 1;
						}
						break;
					}
					goto default;
				}
			}
		}).ToList();
		Points.ForEach(delegate(IFullTextSearchFieldsMappingsReIndexingExtension p)
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
					CS_0024_003C_003E8__locals1.forListFastSearch.AddRange(p.GetSearchFields(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.cardType, CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.filter));
					num12 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
					{
						num12 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		});
		CS_0024_003C_003E8__locals1.forListFastSearch.AddRange(source.Select((EntityPropertyMetadata fsProperty) => (string)_003C_003Ec.ijqoaPvU0sMDrbbCFYbg(_003C_003Ec.qXF8E7vU6H5f9gr5Mho7(-1334993905 ^ -1334947777), _003C_003Ec.VEgNW7vUxkN4Tewj8ChT(_003C_003Ec.i6r182vUDqeGg8a5r72e(fsProperty).ToString()))));
		CS_0024_003C_003E8__locals1.weights = new Dictionary<string, Weight>();
		Points.ForEach(delegate(IFullTextSearchFieldsMappingsReIndexingExtension p)
		{
			int num9 = 1;
			int num10 = num9;
			while (true)
			{
				switch (num10)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					p.GetWeightSearchFields(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.cardType).ForEach(delegate(KeyValuePair<string, Weight> w)
					{
						if (!CS_0024_003C_003E8__locals1.weights.ContainsKey(w.Key))
						{
							CS_0024_003C_003E8__locals1.weights.Add(w.Key, w.Value);
						}
					});
					num10 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
					{
						num10 = 0;
					}
					break;
				}
			}
		});
		listFastSearch = new FastSearchList(string.IsNullOrWhiteSpace(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.filter.SearchString) ? "" : CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.filter.SearchString, CS_0024_003C_003E8__locals1.forListFastSearch, CS_0024_003C_003E8__locals1.weights);
		if (filterFields != null && filterFields.Properties != null && filterFields.Properties.Any())
		{
			ClassMetadata classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(CS_0024_003C_003E8__locals0.filter.GetType());
			foreach (FilterProperty property in filterFields.Properties)
			{
				if (property.Value == null)
				{
					continue;
				}
				_003C_003Ec__DisplayClass51_2 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass51_2();
				CS_0024_003C_003E8__locals3.CS_0024_003C_003E8__locals2 = CS_0024_003C_003E8__locals0;
				CS_0024_003C_003E8__locals3.filterPropertyF = property;
				CS_0024_003C_003E8__locals3.filterPropertyMd = classMetadata.Properties.ToList().FirstOrDefault((PropertyMetadata p) => _003C_003Ec__DisplayClass51_2.LeGJ8RvsmcNlsEJLrQGR(_003C_003Ec__DisplayClass51_2.tb84jgvsxH61OcqwfIpZ(p), _003C_003Ec__DisplayClass51_2.Lqhxxovs0HwawgBlgm36(CS_0024_003C_003E8__locals3.filterPropertyF)));
				if (CS_0024_003C_003E8__locals3.filterPropertyMd == null)
				{
					continue;
				}
				EntityPropertyMetadata entityPropertyMetadata = allProperties.FirstOrDefault((EntityPropertyMetadata p) => _003C_003Ec__DisplayClass51_2.tb84jgvsxH61OcqwfIpZ(p) == _003C_003Ec__DisplayClass51_2.wjj0DivsyrrUa0TjARYe(CS_0024_003C_003E8__locals3.filterPropertyMd));
				if (entityPropertyMetadata != null)
				{
					if (!FullTextSearchDescriptorService.IsSupportedSearchInIndex(entityPropertyMetadata))
					{
						throw new FullTextFilterException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12A5FAC7 ^ 0x12A636BF), entityPropertyMetadata.TypeUid, entityPropertyMetadata.SubTypeUid, entityPropertyMetadata.Uid, entityPropertyMetadata.Name, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488665141)));
					}
					if (FullTextSearchDescriptorService.IsSupportedFullTextSearchInIndex(entityPropertyMetadata))
					{
						listSearchFields.Add(FullTextSearchDescriptorService.GetSearchField(property.Value, entityPropertyMetadata));
						continue;
					}
					_003C_003Ec__DisplayClass51_3 CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass51_3();
					CS_0024_003C_003E8__locals4.CS_0024_003C_003E8__locals3 = CS_0024_003C_003E8__locals3;
					CS_0024_003C_003E8__locals4.autoListFilterField = new FilterList();
					CS_0024_003C_003E8__locals4.hasProcessing = false;
					Points.ForEach(delegate(IFullTextSearchFieldsMappingsReIndexingExtension p)
					{
						int num7 = 2;
						int num8 = num7;
						FilterList filterList2 = default(FilterList);
						while (true)
						{
							switch (num8)
							{
							case 1:
								if (filterList2 == null)
								{
									return;
								}
								num8 = 4;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
								{
									num8 = 4;
								}
								break;
							default:
								CS_0024_003C_003E8__locals4.hasProcessing = true;
								num8 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
								{
									num8 = 3;
								}
								break;
							case 3:
								return;
							case 4:
								CS_0024_003C_003E8__locals4.autoListFilterField.AddRange(filterList2);
								num8 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
								{
									num8 = 0;
								}
								break;
							case 2:
								filterList2 = (FilterList)_003C_003Ec__DisplayClass51_3.TTnLn7vsl9MoULfJN5fH(p, CS_0024_003C_003E8__locals4.CS_0024_003C_003E8__locals3.CS_0024_003C_003E8__locals2.cardType, CS_0024_003C_003E8__locals4.CS_0024_003C_003E8__locals3.filterPropertyF, CS_0024_003C_003E8__locals4.CS_0024_003C_003E8__locals3.CS_0024_003C_003E8__locals2.resultModel);
								num8 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
								{
									num8 = 1;
								}
								break;
							}
						}
					});
					if (CS_0024_003C_003E8__locals4.hasProcessing)
					{
						CS_0024_003C_003E8__locals4.CS_0024_003C_003E8__locals3.CS_0024_003C_003E8__locals2.listFilterField.AddRange(CS_0024_003C_003E8__locals4.autoListFilterField);
						continue;
					}
					FilterListItem filterField = FullTextSearchDescriptorService.GetFilterField(property.Value, entityPropertyMetadata, CS_0024_003C_003E8__locals4.CS_0024_003C_003E8__locals3.CS_0024_003C_003E8__locals2.filter);
					if (filterField != null)
					{
						CS_0024_003C_003E8__locals4.CS_0024_003C_003E8__locals3.CS_0024_003C_003E8__locals2.listFilterField.Add(filterField);
					}
					continue;
				}
				_003C_003Ec__DisplayClass51_4 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass51_4();
				CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals4 = CS_0024_003C_003E8__locals3;
				CS_0024_003C_003E8__locals2.customListFilterField = new FilterList();
				CS_0024_003C_003E8__locals2.customListSearchField = new FieldList();
				CS_0024_003C_003E8__locals2.hasProcessing = false;
				Points.ForEach(delegate(IFullTextSearchFieldsMappingsReIndexingExtension p)
				{
					int num5 = 2;
					FilterList filterList = default(FilterList);
					while (true)
					{
						int num6 = num5;
						while (true)
						{
							switch (num6)
							{
							case 2:
								filterList = (FilterList)_003C_003Ec__DisplayClass51_4.m0yuqxvsYuEP2HvPpEpY(p, CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals4.CS_0024_003C_003E8__locals2.cardType, CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals4.filterPropertyF, CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals4.CS_0024_003C_003E8__locals2.resultModel);
								num6 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
								{
									num6 = 1;
								}
								break;
							default:
								CS_0024_003C_003E8__locals2.hasProcessing = true;
								num6 = 3;
								break;
							case 1:
								if (filterList == null)
								{
									return;
								}
								goto end_IL_0012;
							case 4:
								CS_0024_003C_003E8__locals2.customListFilterField.AddRange(filterList);
								num6 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
								{
									num6 = 0;
								}
								break;
							case 3:
								return;
							}
							continue;
							end_IL_0012:
							break;
						}
						num5 = 4;
					}
				});
				Points.ForEach(delegate(IFullTextSearchFieldsMappingsReIndexingExtension p)
				{
					int num3 = 1;
					FieldList customSearchFields = default(FieldList);
					while (true)
					{
						int num4 = num3;
						while (true)
						{
							switch (num4)
							{
							case 4:
								CS_0024_003C_003E8__locals2.customListSearchField.AddRange(customSearchFields);
								num4 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
								{
									num4 = 1;
								}
								break;
							default:
								if (customSearchFields == null)
								{
									return;
								}
								goto end_IL_0012;
							case 3:
								return;
							case 1:
								customSearchFields = p.GetCustomSearchFields(CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals4.CS_0024_003C_003E8__locals2.cardType, CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals4.filterPropertyF);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
								{
									num4 = 0;
								}
								break;
							case 2:
								CS_0024_003C_003E8__locals2.hasProcessing = true;
								num4 = 3;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
								{
									num4 = 1;
								}
								break;
							}
							continue;
							end_IL_0012:
							break;
						}
						num3 = 4;
					}
				});
				if (CS_0024_003C_003E8__locals2.hasProcessing)
				{
					CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals4.CS_0024_003C_003E8__locals2.listFilterField.AddRange(CS_0024_003C_003E8__locals2.customListFilterField);
					listSearchFields.AddRange(CS_0024_003C_003E8__locals2.customListSearchField);
					continue;
				}
				throw new FullTextFilterException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-542721635 ^ -542806671), CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals4.filterPropertyF.Uid, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3A6135BE ^ 0x3A62F9BE)));
			}
		}
		Points.ForEach(delegate(IFullTextSearchFieldsMappingsReIndexingExtension p)
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
					CS_0024_003C_003E8__locals0.listFilterField.AddRange(p.GetFilterFields(CS_0024_003C_003E8__locals0.cardType, CS_0024_003C_003E8__locals0.resultModel));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		});
	}

	private void SaveDirtyInfoProgres(IIndexQueue item, Guid typeUid, long? lastId, int attempt, Type cardType)
	{
		_003C_003Ec__DisplayClass52_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass52_0();
		CS_0024_003C_003E8__locals0.typeUid = typeUid;
		if (CS_0024_003C_003E8__locals0.typeUid != Guid.Empty)
		{
			ContinueInfo continueInfo = ParseContinueInfo(item.DirtyValues);
			if (attempt > 5)
			{
				continueInfo.RemovePageInfo(CS_0024_003C_003E8__locals0.typeUid);
				IFullTextSearchFieldsMappingsReIndexingExtension fullTextSearchFieldsMappingsReIndexingExtension = Points.FirstOrDefault((IFullTextSearchFieldsMappingsReIndexingExtension a) => _003C_003Ec__DisplayClass52_0.ukcNFGvsz59AyYoAx1gv(a, CS_0024_003C_003E8__locals0.typeUid) != null);
				if (fullTextSearchFieldsMappingsReIndexingExtension != null && fullTextSearchFieldsMappingsReIndexingExtension.SettingModule != null)
				{
					fullTextSearchFieldsMappingsReIndexingExtension.DisableIndexing(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-195614443 ^ -195756909)));
					IndexLog.ErrorFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-561074844 ^ -561153268), fullTextSearchFieldsMappingsReIndexingExtension.SettingModule.ModuleName);
				}
				else
				{
					IndexLog.ErrorFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x31326106 ^ 0x3131B7F0), CS_0024_003C_003E8__locals0.typeUid);
				}
				DeleteAllFromType(cardType);
			}
			else
			{
				continueInfo.AddIdInfo(CS_0024_003C_003E8__locals0.typeUid, lastId ?? 0, attempt);
			}
			item.DirtyValues = ConvertToContinueInfo(continueInfo);
		}
		item.Save();
	}

	private ContinueInfo ParseContinueInfo(string dirtyValues)
	{
		//Discarded unreachable code: IL_00eb, IL_00fa, IL_019c, IL_01ab, IL_01d2, IL_0249, IL_0279, IL_0288, IL_0298, IL_02a7, IL_02c6, IL_036e, IL_037d
		int num = 26;
		string[] array2 = default(string[]);
		string[] array = default(string[]);
		ContinueInfo continueInfo = default(ContinueInfo);
		Guid result = default(Guid);
		long result4 = default(long);
		int result2 = default(int);
		int result3 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 24:
					array2 = (string[])jX9INFGiVDr65x5c7N5y(dirtyValues, new char[1] { ';' });
					num2 = 20;
					continue;
				case 13:
					if (array[2].Length <= 0)
					{
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 6;
				case 27:
				case 29:
					return continueInfo;
				case 11:
					if (array.Length != 3)
					{
						num2 = 3;
						continue;
					}
					goto case 14;
				case 28:
					LkmWGSGiRyDCbwJjyuN2(continueInfo, result, result4, result2);
					num2 = 16;
					continue;
				case 1:
					if (!int.TryParse(array[2], out result3))
					{
						num2 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
						{
							num2 = 10;
						}
						continue;
					}
					goto case 22;
				case 17:
				case 19:
					if (!hFmFpnGiiW1Ad7W7VlK8(s5V3fBGiSYLRKnU8VKGN(array[1]), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70054443)))
					{
						num2 = 31;
						continue;
					}
					goto case 1;
				case 20:
					num3 = 0;
					num2 = 12;
					continue;
				case 22:
					gNlvAMGiqQAKHs9o8U5j(continueInfo, result, result3, result2);
					num2 = 7;
					continue;
				case 14:
					if (!Guid.TryParse(array[0], out result))
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 13;
				case 6:
					if (!hFmFpnGiiW1Ad7W7VlK8(s5V3fBGiSYLRKnU8VKGN(array[1]), fgHpoSGSY0ad2L8AABrV(-538519530 ^ -538563194)))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
						{
							num2 = 17;
						}
						continue;
					}
					goto case 15;
				case 26:
					continueInfo = new ContinueInfo();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
					{
						num2 = 25;
					}
					continue;
				case 4:
				case 7:
				case 10:
				case 16:
				case 18:
				case 31:
					num3++;
					num2 = 21;
					continue;
				case 3:
					if (array.Length == 4)
					{
						num2 = 14;
						continue;
					}
					goto case 4;
				case 23:
					array = array2[num3].Split('.');
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
					{
						num2 = 1;
					}
					continue;
				case 2:
				case 32:
					dOVskbGiKhnJkuHVxf8s(continueInfo);
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
					{
						num2 = 27;
					}
					continue;
				case 30:
					break;
				case 25:
					if (jeMXU7GiWtpq7MWtlP8R(dirtyValues))
					{
						num2 = 32;
						continue;
					}
					goto case 24;
				case 15:
					if (long.TryParse(array[2], out result4))
					{
						num2 = 28;
						continue;
					}
					goto case 4;
				default:
					if (array.Length == 4)
					{
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
						{
							num2 = 30;
						}
						continue;
					}
					goto case 11;
				case 12:
				case 21:
					if (num3 >= array2.Length)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
						{
							num2 = 29;
						}
						continue;
					}
					goto case 23;
				case 5:
					result2 = 0;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
					{
						num2 = 0;
					}
					continue;
				case 8:
				case 9:
					continueInfo.PagesInfo.Add(result, new ContinueInfo.PageInfo());
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
					{
						num2 = 18;
					}
					continue;
				}
				break;
			}
			int.TryParse(array[3], out result2);
			num = 11;
		}
	}

	private string ConvertToContinueInfo(ContinueInfo continueInfo)
	{
		//Discarded unreachable code: IL_007d, IL_008c, IL_0097, IL_02cd, IL_02dc, IL_0332, IL_0341, IL_0377, IL_038a
		int num = 2;
		int num2 = num;
		string text = default(string);
		Dictionary<Guid, ContinueInfo.PageInfo>.Enumerator enumerator = default(Dictionary<Guid, ContinueInfo.PageInfo>.Enumerator);
		KeyValuePair<Guid, ContinueInfo.PageInfo> current = default(KeyValuePair<Guid, ContinueInfo.PageInfo>);
		int? page = default(int?);
		long? lastId = default(long?);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return text;
			case 2:
				text = "";
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
				{
					num2 = 1;
				}
				continue;
			case 1:
				enumerator = continueInfo.PagesInfo.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
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
						num3 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
						{
							num3 = 0;
						}
						goto IL_009b;
					}
					goto IL_02a5;
					IL_02a5:
					current = enumerator.Current;
					num3 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
					{
						num3 = 8;
					}
					goto IL_009b;
					IL_009b:
					while (true)
					{
						switch (num3)
						{
						case 7:
							return text;
						case 10:
							page = current.Value.Page;
							num3 = 13;
							continue;
						case 4:
						case 9:
						case 11:
						case 12:
							break;
						case 6:
							if (lastId.HasValue)
							{
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
								{
									num3 = 0;
								}
								continue;
							}
							goto case 10;
						case 5:
							lastId = current.Value.LastId;
							num3 = 6;
							continue;
						case 3:
							text += (string)JLRHGAGSLN1tDB5iTsUG(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1FFEF86A ^ 0x1FFD2FF6), new object[4] { current.Key, null, null, 0 });
							num3 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
							{
								num3 = 9;
							}
							continue;
						case 1:
							text = (string)QwupiPGiTQj97kQeaQZ6(text, JLRHGAGSLN1tDB5iTsUG(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34185E55 ^ 0x341B89C9), new object[4]
							{
								current.Key,
								fgHpoSGSY0ad2L8AABrV(0x34185E55 ^ 0x3418948D),
								current.Value.Page,
								aYhI8wGiXG8whnGerYuf(current.Value)
							}));
							num3 = 12;
							continue;
						default:
							text = (string)QwupiPGiTQj97kQeaQZ6(text, JLRHGAGSLN1tDB5iTsUG(fgHpoSGSY0ad2L8AABrV(0x269E5FCA ^ 0x269D8856), new object[4]
							{
								current.Key,
								z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867236859),
								current.Value.LastId,
								aYhI8wGiXG8whnGerYuf(current.Value)
							}));
							num3 = 11;
							continue;
						case 2:
							goto IL_02a5;
						case 13:
							if (page.HasValue)
							{
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
								{
									num3 = 1;
								}
								continue;
							}
							goto case 3;
						case 8:
							if (!sVMlM4GSUnxTQ9AY6k0g(current.Key, Guid.Empty))
							{
								num3 = 4;
								continue;
							}
							goto case 5;
						}
						break;
					}
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
		}
	}

	public FullTextSearchService()
	{
		//Discarded unreachable code: IL_003a, IL_003f
		F8wo4hGik136Sr72gTQm();
		objectIndex = new object();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static FullTextSearchService()
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
				IndexLog = (ILogger)HsQkADGinDAKG2q1Alo1(fgHpoSGSY0ad2L8AABrV(0x63ABA4E8 ^ 0x63A89C78));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 2:
				F8wo4hGik136Sr72gTQm();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static bool svHTnFGSMrfx9WGJbaKX()
	{
		return zoSitbGSyLMSR9ms7NtQ == null;
	}

	internal static FullTextSearchService FMWAkgGSJw2n3A6yAH1s()
	{
		return zoSitbGSyLMSR9ms7NtQ;
	}

	internal static object xT4UloGS9N7QXN3i8jM3()
	{
		return DataAccessManager.BLOBManager;
	}

	internal static Guid IxAwiJGSdB9BFpCe7aDV(object P_0)
	{
		return ((FullTextSearchSettings)P_0).ProviderUid;
	}

	internal static object NOHLYUGSlP7MTR4Jk6gL()
	{
		return ComponentManager.Current;
	}

	internal static bool x66jIWGSroJxCobKf9Yi(object P_0)
	{
		return ((IFullTextSearchProvider)P_0).GetServerStatus();
	}

	internal static void hdvqeLGSgMh54UjtNtoS(object P_0, object P_1)
	{
		((ILogger)P_0).Warn(P_1);
	}

	internal static object k7udifGS5LS4W4XHDujW(Type t)
	{
		return InterfaceActivator.Create(t);
	}

	internal static object anfqmHGSj9HNVWQ9uJmi(object P_0)
	{
		return ((FullTextSearchObjectContainer)P_0).SearchObject;
	}

	internal static object fgHpoSGSY0ad2L8AABrV(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object JLRHGAGSLN1tDB5iTsUG(object P_0, object P_1)
	{
		return string.Format((string)P_0, (object[])P_1);
	}

	internal static bool sVMlM4GSUnxTQ9AY6k0g(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static bool PYbCwxGSsp1ZhpISAUCy(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static object rqsk9HGSc47bwP4Fdy7P(object P_0)
	{
		return ((Exception)P_0).Message;
	}

	internal static object xlNxXoGSzg7OR7SnOT7b(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static void yWlb45GiF4OqXGSKdj5C(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static object IUihCiGiBexsLfEIaEHG(object P_0)
	{
		return ((IIndexQueue)P_0).DirtyValues;
	}

	internal static bool jeMXU7GiWtpq7MWtlP8R(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static void YCrOfoGioCkoucIh2GEA(object P_0, bool value)
	{
		((IndexResult)P_0).Result = value;
	}

	internal static void WqHVPZGibtl6FoX1rRXQ(object P_0)
	{
		((IEntity)P_0).Save();
	}

	internal static object uZcdBBGihaiGwKchLmPA()
	{
		return IndexQueueManager.Instance;
	}

	internal static void Hgh1CtGiGIgc4Doh2UBG(object P_0)
	{
		((IndexQueueManager)P_0).ClearQueue();
	}

	internal static bool edCG0IGiE5iyIX4YhmTN(object P_0)
	{
		return ((IFullTextSearchProvider)P_0).DeleteIndex();
	}

	internal static object xIKfLlGiffaEnnuG2fHR(object P_0)
	{
		return ((MemberInfo)P_0).Name;
	}

	internal static Type N0YHeUGiQUGa1dkfn9sT(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object nZdevOGiCjXQLHCGMG3P(object P_0, Type P_1, bool P_2)
	{
		return ((MemberInfo)P_0).GetCustomAttributes(P_1, P_2);
	}

	internal static Type YONWoKGivAn5rAEsK5J2(object P_0)
	{
		return ((FilterForAttribute)P_0).EntityType;
	}

	internal static object n3E0XCGi89O8Hx3rHcmt(object P_0, Type cardType, object P_2, object P_3, object P_4)
	{
		return ((IFullTextSearchProvider)P_0).Count(cardType, (FastSearchList)P_2, (FieldList)P_3, (FilterList)P_4);
	}

	internal static void S0O4qnGiZ6KY5VOVXGxF(object P_0, bool value)
	{
		((IndexCallInfo)P_0).IsCancel = value;
	}

	internal static void re6dvsGiuu9xh5PL6xcT(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Warn(P_1, (Exception)P_2);
	}

	internal static object CxCkcNGiIjAQqZOi40n0()
	{
		return Logger.Log;
	}

	internal static object jX9INFGiVDr65x5c7N5y(object P_0, object P_1)
	{
		return ((string)P_0).Split((char[])P_1);
	}

	internal static object s5V3fBGiSYLRKnU8VKGN(object P_0)
	{
		return ((string)P_0).ToLower();
	}

	internal static bool hFmFpnGiiW1Ad7W7VlK8(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static void LkmWGSGiRyDCbwJjyuN2(object P_0, Guid typeUid, long lastId, int attempt)
	{
		((ContinueInfo)P_0).AddIdInfo(typeUid, lastId, attempt);
	}

	internal static void gNlvAMGiqQAKHs9o8U5j(object P_0, Guid typeUid, int pageIndex, int attempt)
	{
		((ContinueInfo)P_0).AddPageInfo(typeUid, pageIndex, attempt);
	}

	internal static void dOVskbGiKhnJkuHVxf8s(object P_0)
	{
		((ContinueInfo)P_0).PrepareEmptyPages();
	}

	internal static int aYhI8wGiXG8whnGerYuf(object P_0)
	{
		return ((ContinueInfo.PageInfo)P_0).Attempt;
	}

	internal static object QwupiPGiTQj97kQeaQZ6(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static void F8wo4hGik136Sr72gTQm()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object HsQkADGinDAKG2q1Alo1(object P_0)
	{
		return Logger.GetLogger((string)P_0);
	}
}
