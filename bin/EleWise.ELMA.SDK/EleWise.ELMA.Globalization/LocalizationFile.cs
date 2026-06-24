using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Text;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Globalization;

[Serializable]
public class LocalizationFile
{
	internal static LocalizationFile LRsI8AGGeoe2iQ6kxRFy;

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
				case 1:
					_003CName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
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

	public List<string> Header { get; set; }

	public string LocalizationName
	{
		[CompilerGenerated]
		get
		{
			return _003CLocalizationName_003Ek__BackingField;
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
					_003CLocalizationName_003Ek__BackingField = value;
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

	public ConcurrentBag<PoLineDescriptor> Resources { get; set; }

	public LocalizationFile()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		z9kDU6GGNLKknp1odIOy();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
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
				Resources = new ConcurrentBag<PoLineDescriptor>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public LocalizationFile(string fileName)
	{
		//Discarded unreachable code: IL_002a, IL_002f, IL_00ce, IL_0151, IL_0181, IL_0190, IL_019c, IL_01ab
		z9kDU6GGNLKknp1odIOy();
		this._002Ector();
		int num = 2;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
		{
			num = 3;
		}
		StreamReader streamReader = default(StreamReader);
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			default:
				streamReader = (StreamReader)Q23dj5GGpqaK6o4bHTfc(fileName);
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
				{
					num = 2;
				}
				break;
			case 4:
				if (!Lx4qvCGG3CINUfx7aDgi(fileName))
				{
					return;
				}
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
				{
					num = 0;
				}
				break;
			case 3:
				Name = fileName;
				num = 4;
				break;
			case 2:
				try
				{
					Tuple<List<string>, List<PoLineDescriptor>> tuple = PoParser.Parse(streamReader);
					int num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
					{
						num2 = 0;
					}
					while (true)
					{
						switch (num2)
						{
						default:
							return;
						case 0:
							return;
						case 1:
							Header = tuple.Item1;
							num2 = 2;
							break;
						case 2:
							Resources = new ConcurrentBag<PoLineDescriptor>(tuple.Item2);
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
				finally
				{
					int num3;
					if (streamReader == null)
					{
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
						{
							num3 = 0;
						}
						goto IL_0155;
					}
					goto IL_016b;
					IL_016b:
					xd775TGGaPfsfq7WpDPt(streamReader);
					num3 = 2;
					goto IL_0155;
					IL_0155:
					switch (num3)
					{
					default:
						goto end_IL_0130;
					case 1:
						break;
					case 0:
						goto end_IL_0130;
					case 2:
						goto end_IL_0130;
					}
					goto IL_016b;
					end_IL_0130:;
				}
			}
		}
	}

	public void SaveToFile(string dir = null)
	{
		//Discarded unreachable code: IL_009b, IL_00f8, IL_0107, IL_0112, IL_01a8, IL_01bb, IL_01ca, IL_0201, IL_026e, IL_027d, IL_0288, IL_0320, IL_0379, IL_03b1, IL_03c0, IL_03dc, IL_040f, IL_04de
		int num = 12;
		int num2 = num;
		string text2 = default(string);
		StreamWriter streamWriter = default(StreamWriter);
		List<string>.Enumerator enumerator2 = default(List<string>.Enumerator);
		string current = default(string);
		IEnumerator<PoLineDescriptor> enumerator = default(IEnumerator<PoLineDescriptor>);
		string text = default(string);
		bool flag = default(bool);
		while (true)
		{
			object obj;
			switch (num2)
			{
			default:
				return;
			case 2:
				File.Delete(text2);
				num2 = 9;
				continue;
			case 12:
				if (dir == null)
				{
					num2 = 11;
					continue;
				}
				goto case 10;
			case 13:
				try
				{
					int num3;
					if (Header != null)
					{
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
						{
							num3 = 0;
						}
						goto IL_009f;
					}
					goto IL_020b;
					IL_020b:
					Xp430iGG46I2Jkmw2Vr5(streamWriter, MbnZ9KGGwBKraLWVUQDu(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x68BBB53E ^ 0x68B80E40), C3qxvfGGtwAkkKWS3cUn(-1998538950 ^ -1998531580), C3qxvfGGtwAkkKWS3cUn(-420743386 ^ -420747134)));
					num3 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
					{
						num3 = 5;
					}
					goto IL_009f;
					IL_009f:
					while (true)
					{
						switch (num3)
						{
						case 3:
							streamWriter.WriteLine("");
							num3 = 2;
							continue;
						default:
							enumerator2 = Header.GetEnumerator();
							num3 = 6;
							continue;
						case 6:
							try
							{
								while (true)
								{
									IL_0153:
									int num6;
									if (!enumerator2.MoveNext())
									{
										num6 = 2;
										goto IL_0116;
									}
									goto IL_0130;
									IL_0116:
									while (true)
									{
										switch (num6)
										{
										case 1:
											break;
										case 3:
											goto IL_0153;
										default:
											streamWriter.WriteLine(current);
											num6 = 3;
											continue;
										case 2:
											goto end_IL_0153;
										}
										break;
									}
									goto IL_0130;
									IL_0130:
									current = enumerator2.Current;
									num6 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
									{
										num6 = 0;
									}
									goto IL_0116;
									continue;
									end_IL_0153:
									break;
								}
							}
							finally
							{
								((IDisposable)enumerator2).Dispose();
								int num7 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
								{
									num7 = 0;
								}
								switch (num7)
								{
								case 0:
									break;
								}
							}
							goto case 3;
						case 2:
						case 5:
							enumerator = Resources.GetEnumerator();
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
							{
								num3 = 1;
							}
							continue;
						case 4:
							break;
						case 1:
							try
							{
								while (true)
								{
									IL_02e4:
									int num4;
									if (!enumerator.MoveNext())
									{
										num4 = 3;
										goto IL_028c;
									}
									goto IL_02a6;
									IL_028c:
									while (true)
									{
										switch (num4)
										{
										case 1:
											break;
										case 2:
											V49FLgGGHQawM1Uht4ny(streamWriter, "");
											num4 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
											{
												num4 = 0;
											}
											continue;
										default:
											goto IL_02e4;
										case 3:
											goto end_IL_02e4;
										}
										break;
									}
									goto IL_02a6;
									IL_02a6:
									XtjtN9GG61SxGga1TH2R(enumerator.Current, streamWriter);
									num4 = 2;
									goto IL_028c;
									continue;
									end_IL_02e4:
									break;
								}
							}
							finally
							{
								if (enumerator != null)
								{
									int num5 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
									{
										num5 = 1;
									}
									while (true)
									{
										switch (num5)
										{
										case 1:
											xd775TGGaPfsfq7WpDPt(enumerator);
											num5 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
											{
												num5 = 0;
											}
											continue;
										case 0:
											break;
										}
										break;
									}
								}
							}
							goto end_IL_009f;
						}
						goto IL_020b;
						continue;
						end_IL_009f:
						break;
					}
				}
				finally
				{
					if (streamWriter != null)
					{
						int num8 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
						{
							num8 = 0;
						}
						while (true)
						{
							switch (num8)
							{
							default:
								xd775TGGaPfsfq7WpDPt(streamWriter);
								num8 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
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
				goto case 1;
			case 10:
				obj = jnGxvXGGDsWs6DOUmuiP(dir, Name);
				break;
			case 6:
				text += z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3630F361 ^ 0x363190B7);
				num2 = 4;
				continue;
			case 0:
				return;
			case 7:
				text2 = text;
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
				{
					num2 = 5;
				}
				continue;
			case 4:
				streamWriter = new StreamWriter(text, append: false, EncodingCache.UTF8WithoutEmitIdentifier);
				num2 = 11;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
				{
					num2 = 13;
				}
				continue;
			case 8:
				flag = Lx4qvCGG3CINUfx7aDgi(text);
				num2 = 5;
				continue;
			case 5:
				if (flag)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
					{
						num2 = 6;
					}
					continue;
				}
				goto case 4;
			case 9:
				TUw7TWGGAceOxRQQjOVU(text, text2);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
				{
					num2 = 2;
				}
				continue;
			case 1:
				if (!flag)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 2;
			case 3:
				return;
			case 11:
				obj = Name;
				break;
			}
			text = (string)obj;
			num2 = 7;
		}
	}

	public static List<PoLineDescriptor> ApplyFilter(IEnumerable<PoLineDescriptor> res, PoLineFilter filter)
	{
		_003C_003Ec__DisplayClass19_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass19_0();
		CS_0024_003C_003E8__locals0.filter = filter;
		if (res == null)
		{
			return new List<PoLineDescriptor>();
		}
		if (CS_0024_003C_003E8__locals0.filter.Fuzzy)
		{
			res = res.Where((PoLineDescriptor r) => _003C_003Ec.LHfgpEvgZmEVKqlusYDt(r));
		}
		if (CS_0024_003C_003E8__locals0.filter.HighPriority)
		{
			res = res.Where((PoLineDescriptor r) => !r.IsLow);
		}
		if (CS_0024_003C_003E8__locals0.filter.LowPriority)
		{
			res = res.Where((PoLineDescriptor r) => _003C_003Ec.EgoTrNvgueaXVC5wWPoE(r));
		}
		if (CS_0024_003C_003E8__locals0.filter.Untranslated)
		{
			res = res.Where((PoLineDescriptor r) => _003C_003Ec.U1cce6vgVVfLOjwF4Zl2(_003C_003Ec.lK39ncvgIYFdRB6ppaM2(r)));
		}
		if (!string.IsNullOrEmpty(CS_0024_003C_003E8__locals0.filter.SearchString))
		{
			res = res.Where(delegate(PoLineDescriptor r)
			{
				//Discarded unreachable code: IL_008e, IL_009d, IL_00ac
				int num = 2;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 3:
						return _003C_003Ec__DisplayClass19_0.cemlQJvgEFhAwyfroOra(_003C_003Ec__DisplayClass19_0.LsVM1Mvgf6TrVPpULHnQ(r), _003C_003Ec__DisplayClass19_0.G9XEyRvgGknHnTxBuANE(CS_0024_003C_003E8__locals0.filter), StringComparison.OrdinalIgnoreCase) >= 0;
					case 4:
						return false;
					case 1:
						return true;
					case 2:
						if (_003C_003Ec__DisplayClass19_0.cemlQJvgEFhAwyfroOra(_003C_003Ec__DisplayClass19_0.qgIExhvghMt9pbsHwNtw(r), _003C_003Ec__DisplayClass19_0.G9XEyRvgGknHnTxBuANE(CS_0024_003C_003E8__locals0.filter), StringComparison.OrdinalIgnoreCase) >= 0)
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
							{
								num2 = 0;
							}
							break;
						}
						goto default;
					default:
						if (_003C_003Ec__DisplayClass19_0.LsVM1Mvgf6TrVPpULHnQ(r) == null)
						{
							num2 = 4;
							break;
						}
						goto case 3;
					}
				}
			});
		}
		return res.ToList();
	}

	public long Count(PoLineFilter filter)
	{
		return ApplyFilter(Resources.Select((PoLineDescriptor r) => r).ToList(), filter).Count;
	}

	public List<PoLineDescriptor> Find(FetchOptions options, PoLineFilter filter)
	{
		List<PoLineDescriptor> list = Resources.Select((PoLineDescriptor r) => r).ToList();
		if (options != null && !string.IsNullOrEmpty(options.SortExpression))
		{
			string sortExpression = options.SortExpression;
			if (!(sortExpression == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420785812)))
			{
				if (sortExpression == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-538519530 ^ -538542526))
				{
					list = ((options.SortDirection == ListSortDirection.Descending) ? list.OrderBy((PoLineDescriptor r) => r.Value) : list.OrderByDescending((PoLineDescriptor r) => (string)_003C_003Ec.lK39ncvgIYFdRB6ppaM2(r))).ToList();
				}
			}
			else
			{
				list = ((options.SortDirection == ListSortDirection.Ascending) ? list.OrderBy((PoLineDescriptor r) => r.Key) : list.OrderByDescending((PoLineDescriptor r) => (string)_003C_003Ec.pDFMqQvgSoIFG6d6VgZu(r))).ToList();
			}
		}
		list = ApplyFilter(list, filter);
		if (options != null)
		{
			list = list.ToList();
			list = ((options.FirstResult + options.MaxResults >= list.Count) ? list.GetRange(options.FirstResult, list.Count - options.FirstResult) : list.GetRange(options.FirstResult, options.MaxResults));
		}
		return list;
	}

	public List<PoLineDescriptor> FindByWords(List<List<string>> words, bool containsMode)
	{
		_003C_003Ec__DisplayClass22_5 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass22_0();
		CS_0024_003C_003E8__locals0.words = words;
		CS_0024_003C_003E8__locals0.compareFunc = null;
		if (containsMode)
		{
			CS_0024_003C_003E8__locals0.compareFunc = delegate(List<string> list, List<string> wd)
			{
				CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass22_1();
				CS_0024_003C_003E8__locals0.list = list;
				return wd.Any(delegate(string w)
				{
					int num5 = 2;
					int num6 = num5;
					_003C_003Ec__DisplayClass22_2 _003C_003Ec__DisplayClass22_2 = default(_003C_003Ec__DisplayClass22_2);
					while (true)
					{
						switch (num6)
						{
						case 2:
							_003C_003Ec__DisplayClass22_2 = new _003C_003Ec__DisplayClass22_2();
							num6 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
							{
								num6 = 1;
							}
							break;
						case 1:
							_003C_003Ec__DisplayClass22_2.w = w;
							num6 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
							{
								num6 = 0;
							}
							break;
						default:
							return CS_0024_003C_003E8__locals0.list.Any(_003C_003Ec__DisplayClass22_2._003CFindByWords_003Eb__5);
						}
					}
				});
			};
		}
		else
		{
			CS_0024_003C_003E8__locals0.compareFunc = delegate(List<string> list, List<string> wd)
			{
				CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass22_3();
				CS_0024_003C_003E8__locals0.list = list;
				return wd.All(delegate(string w)
				{
					int num3 = 1;
					int num4 = num3;
					_003C_003Ec__DisplayClass22_4 _003C_003Ec__DisplayClass22_ = default(_003C_003Ec__DisplayClass22_4);
					while (true)
					{
						switch (num4)
						{
						case 1:
							_003C_003Ec__DisplayClass22_ = new _003C_003Ec__DisplayClass22_4();
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
							{
								num4 = 0;
							}
							break;
						default:
							_003C_003Ec__DisplayClass22_.w = w;
							num4 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
							{
								num4 = 2;
							}
							break;
						case 2:
							return CS_0024_003C_003E8__locals0.list.Any(_003C_003Ec__DisplayClass22_._003CFindByWords_003Eb__7);
						}
					}
				});
			};
		}
		CS_0024_003C_003E8__locals0.checkFuncOr = delegate(List<string> list)
		{
			CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass22_5();
			CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1 = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.list = list;
			return CS_0024_003C_003E8__locals0.words.Any((List<string> wd) => CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.compareFunc(CS_0024_003C_003E8__locals0.list, wd));
		};
		return Resources.Where(delegate(PoLineDescriptor r)
		{
			//Discarded unreachable code: IL_0041, IL_0050
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return CS_0024_003C_003E8__locals0.checkFuncOr(r.ValueWords);
				default:
					return true;
				case 1:
					if (CS_0024_003C_003E8__locals0.checkFuncOr(r.KeyWords))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				}
			}
		}).ToList();
	}

	public override string ToString()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return (string)rSJMkmGGxbUPd4gJXxyo(this);
			case 1:
				if (!DLKBu3GG7b2YnPQQvf98(Name))
				{
					return Name;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void z9kDU6GGNLKknp1odIOy()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool pTUW2NGGPCxwXsCPZ4mN()
	{
		return LRsI8AGGeoe2iQ6kxRFy == null;
	}

	internal static LocalizationFile y2VLxVGG1CBWEigbfoco()
	{
		return LRsI8AGGeoe2iQ6kxRFy;
	}

	internal static bool Lx4qvCGG3CINUfx7aDgi(object P_0)
	{
		return File.Exists((string)P_0);
	}

	internal static object Q23dj5GGpqaK6o4bHTfc(object P_0)
	{
		return File.OpenText((string)P_0);
	}

	internal static void xd775TGGaPfsfq7WpDPt(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object jnGxvXGGDsWs6DOUmuiP(object P_0, object P_1)
	{
		return Path.Combine((string)P_0, (string)P_1);
	}

	internal static object C3qxvfGGtwAkkKWS3cUn(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object MbnZ9KGGwBKraLWVUQDu(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static void Xp430iGG46I2Jkmw2Vr5(object P_0, object P_1)
	{
		((TextWriter)P_0).Write((string)P_1);
	}

	internal static void XtjtN9GG61SxGga1TH2R(object P_0, object P_1)
	{
		((PoLineDescriptor)P_0).WriteToFile((StreamWriter)P_1);
	}

	internal static void V49FLgGGHQawM1Uht4ny(object P_0, object P_1)
	{
		((TextWriter)P_0).WriteLine((string)P_1);
	}

	internal static void TUw7TWGGAceOxRQQjOVU(object P_0, object P_1)
	{
		File.Move((string)P_0, (string)P_1);
	}

	internal static bool DLKBu3GG7b2YnPQQvf98(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object rSJMkmGGxbUPd4gJXxyo(object P_0)
	{
		return P_0.ToString();
	}
}
