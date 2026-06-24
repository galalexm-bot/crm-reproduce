using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using EleWise.ELMA.Model.Common;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Globalization;

[Serializable]
public class LocalizationHolder
{
	public const string HolderTemplate = "SRString:{0}:{1}:{2}";

	private object _sinchObjs;

	private Dictionary<string, string> _cache;

	internal static LocalizationHolder ymdk8gGhsskcwF28v8Aa;

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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public List<TemplateDescription> Templates { get; set; }

	public List<LocalizationFile> Files { get; set; }

	public LocalizationStatistic Statistic
	{
		[CompilerGenerated]
		get
		{
			return _003CStatistic_003Ek__BackingField;
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
					_003CStatistic_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
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

	public LocalizationHolder()
	{
		//Discarded unreachable code: IL_004a, IL_004f
		VWXUOXGGFuOkNlqpQ1M4();
		_sinchObjs = new object();
		_cache = new Dictionary<string, string>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				Files = new List<LocalizationFile>();
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
				{
					num = 2;
				}
				break;
			case 2:
				Templates = new List<TemplateDescription>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
				{
					num = 1;
				}
				break;
			case 1:
				return;
			}
		}
	}

	public string T(string key)
	{
		//Discarded unreachable code: IL_0054, IL_0063, IL_0074, IL_0083, IL_00c1, IL_00d0, IL_01fa, IL_020d, IL_021c
		int num = 6;
		int num2 = num;
		_003C_003Ec__DisplayClass14_0 _003C_003Ec__DisplayClass14_ = default(_003C_003Ec__DisplayClass14_0);
		List<LocalizationFile>.Enumerator enumerator = default(List<LocalizationFile>.Enumerator);
		PoLineDescriptor poLineDescriptor = default(PoLineDescriptor);
		string result = default(string);
		string text = default(string);
		string value = default(string);
		while (true)
		{
			switch (num2)
			{
			case 5:
				_003C_003Ec__DisplayClass14_.key = key;
				num2 = 3;
				break;
			case 4:
				return null;
			default:
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
								num3 = 7;
							}
							goto IL_0092;
						}
						goto IL_0175;
						IL_0175:
						poLineDescriptor = enumerator.Current.Resources.FirstOrDefault(_003C_003Ec__DisplayClass14_._003CT_003Eb__0);
						num3 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
						{
							num3 = 3;
						}
						goto IL_0092;
						IL_0092:
						while (true)
						{
							switch (num3)
							{
							case 4:
								return result;
							case 3:
								if (poLineDescriptor != null)
								{
									num3 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
									{
										num3 = 0;
									}
									continue;
								}
								break;
							case 5:
								_cache[_003C_003Ec__DisplayClass14_.key] = text;
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
								{
									num3 = 0;
								}
								continue;
							case 1:
								break;
							case 2:
							{
								text = (string)jPl69FGGBXtIf1TkGWO0(poLineDescriptor);
								int num4 = 5;
								num3 = num4;
								continue;
							}
							default:
								result = text;
								num3 = 4;
								continue;
							case 6:
								goto IL_0175;
							case 7:
								goto end_IL_012a;
							}
							break;
						}
						continue;
						end_IL_012a:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
					{
						num5 = 0;
					}
					switch (num5)
					{
					case 0:
						break;
					}
				}
				goto case 4;
			case 6:
				_003C_003Ec__DisplayClass14_ = new _003C_003Ec__DisplayClass14_0();
				num2 = 5;
				break;
			case 3:
				if (!_cache.TryGetValue(_003C_003Ec__DisplayClass14_.key, out value))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 2;
			case 2:
				return value;
			case 1:
				enumerator = Files.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void AddResourceToFile(string file, PoLineDescriptor line, out LocalizationFile localizationFile)
	{
		int num = 4;
		int num2 = num;
		_003C_003Ec__DisplayClass15_0 _003C_003Ec__DisplayClass15_ = default(_003C_003Ec__DisplayClass15_0);
		while (true)
		{
			switch (num2)
			{
			case 5:
				return;
			case 1:
				return;
			case 4:
				_003C_003Ec__DisplayClass15_ = new _003C_003Ec__DisplayClass15_0();
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
				{
					num2 = 3;
				}
				continue;
			case 2:
				localizationFile = Files.FirstOrDefault(_003C_003Ec__DisplayClass15_._003CAddResourceToFile_003Eb__0);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				_003C_003Ec__DisplayClass15_.file = file;
				num2 = 2;
				continue;
			}
			if (localizationFile != null)
			{
				localizationFile.Resources.Add(line);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
				{
					num2 = 1;
				}
			}
			else
			{
				num2 = 5;
			}
		}
	}

	public void SetTranslate(string key, string val, out List<LocalizationFile> file)
	{
		//Discarded unreachable code: IL_003b, IL_006d, IL_007c, IL_0087, IL_01de, IL_01fd, IL_020c, IL_0239, IL_0305, IL_0318, IL_0327
		int num = 5;
		int num2 = num;
		List<LocalizationFile>.Enumerator enumerator = default(List<LocalizationFile>.Enumerator);
		_003C_003Ec__DisplayClass16_0 _003C_003Ec__DisplayClass16_ = default(_003C_003Ec__DisplayClass16_0);
		LocalizationFile current = default(LocalizationFile);
		IEnumerator<PoLineDescriptor> enumerator2 = default(IEnumerator<PoLineDescriptor>);
		PoLineDescriptor current2 = default(PoLineDescriptor);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return;
			case 2:
				enumerator = Files.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				file = new List<LocalizationFile>();
				num2 = 2;
				continue;
			case 5:
				_003C_003Ec__DisplayClass16_ = new _003C_003Ec__DisplayClass16_0();
				num2 = 4;
				continue;
			case 4:
				_003C_003Ec__DisplayClass16_.key = key;
				num2 = 3;
				continue;
			}
			try
			{
				while (true)
				{
					IL_0266:
					int num3;
					if (!enumerator.MoveNext())
					{
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
						{
							num3 = 0;
						}
						goto IL_0049;
					}
					goto IL_0243;
					IL_0243:
					current = enumerator.Current;
					num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
					{
						num3 = 0;
					}
					goto IL_0049;
					IL_0049:
					while (true)
					{
						switch (num3)
						{
						case 1:
							return;
						case 3:
							try
							{
								while (true)
								{
									IL_014a:
									int num5;
									if (!JDSNW0GGbNrxJ6LmUUjN(enumerator2))
									{
										num5 = 4;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
										{
											num5 = 5;
										}
										goto IL_008b;
									}
									goto IL_0105;
									IL_0105:
									current2 = enumerator2.Current;
									num5 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
									{
										num5 = 2;
									}
									goto IL_008b;
									IL_008b:
									while (true)
									{
										switch (num5)
										{
										case 3:
											_cache[_003C_003Ec__DisplayClass16_.key] = val;
											num5 = 2;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
											{
												num5 = 6;
											}
											continue;
										case 6:
											file.Add(current);
											num5 = 3;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
											{
												num5 = 4;
											}
											continue;
										case 7:
											break;
										case 1:
											F3BbSrGGovE6ZP5KLoc0(current2, false);
											num5 = 3;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
											{
												num5 = 2;
											}
											continue;
										case 4:
											goto IL_014a;
										default:
											if (current2.IsFuzzy)
											{
												num5 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
												{
													num5 = 0;
												}
												continue;
											}
											goto case 3;
										case 2:
											aOZ0bZGGWlPH8YLRriLs(current2, val);
											num5 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
											{
												num5 = 0;
											}
											continue;
										case 5:
											goto end_IL_014a;
										}
										break;
									}
									goto IL_0105;
									continue;
									end_IL_014a:
									break;
								}
							}
							finally
							{
								int num6;
								if (enumerator2 == null)
								{
									num6 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
									{
										num6 = 0;
									}
									goto IL_01e2;
								}
								goto IL_0217;
								IL_0217:
								e5aY0fGGhyBwpXUEbVyB(enumerator2);
								num6 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
								{
									num6 = 2;
								}
								goto IL_01e2;
								IL_01e2:
								switch (num6)
								{
								default:
									goto end_IL_01bd;
								case 0:
									goto end_IL_01bd;
								case 1:
									break;
								case 2:
									goto end_IL_01bd;
								}
								goto IL_0217;
								end_IL_01bd:;
							}
							goto IL_0266;
						case 4:
							break;
						case 2:
							goto IL_0266;
						default:
						{
							enumerator2 = current.Resources.Where(_003C_003Ec__DisplayClass16_._003CSetTranslate_003Eb__0).GetEnumerator();
							int num4 = 3;
							num3 = num4;
							continue;
						}
						}
						break;
					}
					goto IL_0243;
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
				int num7 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
				{
					num7 = 0;
				}
				switch (num7)
				{
				case 0:
					break;
				}
			}
		}
	}

	public void SetPriority(string key, bool val, out List<LocalizationFile> file)
	{
		//Discarded unreachable code: IL_007e, IL_0088, IL_00c3, IL_00cd, IL_0181, IL_01a0, IL_01d0, IL_0280, IL_0293, IL_02a2
		int num = 5;
		int num2 = num;
		_003C_003Ec__DisplayClass17_0 _003C_003Ec__DisplayClass17_ = default(_003C_003Ec__DisplayClass17_0);
		List<LocalizationFile>.Enumerator enumerator = default(List<LocalizationFile>.Enumerator);
		LocalizationFile current = default(LocalizationFile);
		IEnumerator<PoLineDescriptor> enumerator2 = default(IEnumerator<PoLineDescriptor>);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return;
			case 5:
				_003C_003Ec__DisplayClass17_ = new _003C_003Ec__DisplayClass17_0();
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
				{
					num2 = 0;
				}
				continue;
			case 4:
				_003C_003Ec__DisplayClass17_.key = key;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
				{
					num2 = 1;
				}
				continue;
			case 2:
				file = new List<LocalizationFile>();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
				{
					num2 = 1;
				}
				continue;
			case 1:
				enumerator = Files.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				while (true)
				{
					IL_01da:
					int num3;
					if (!enumerator.MoveNext())
					{
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
						{
							num3 = 0;
						}
						goto IL_008c;
					}
					goto IL_00aa;
					IL_00aa:
					current = enumerator.Current;
					num3 = 4;
					goto IL_008c;
					IL_008c:
					while (true)
					{
						switch (num3)
						{
						default:
							return;
						case 0:
							return;
						case 2:
							break;
						case 1:
							try
							{
								while (true)
								{
									IL_0135:
									int num4;
									if (!JDSNW0GGbNrxJ6LmUUjN(enumerator2))
									{
										num4 = 3;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
										{
											num4 = 1;
										}
										goto IL_00d1;
									}
									goto IL_00eb;
									IL_00eb:
									BAtHgqGGGOYcxTXapULw(enumerator2.Current, val);
									num4 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
									{
										num4 = 1;
									}
									goto IL_00d1;
									IL_00d1:
									while (true)
									{
										switch (num4)
										{
										case 2:
											break;
										case 1:
											file.Add(current);
											num4 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
											{
												num4 = 0;
											}
											continue;
										default:
											goto IL_0135;
										case 3:
											goto end_IL_0135;
										}
										break;
									}
									goto IL_00eb;
									continue;
									end_IL_0135:
									break;
								}
							}
							finally
							{
								int num5;
								if (enumerator2 == null)
								{
									num5 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
									{
										num5 = 1;
									}
									goto IL_0185;
								}
								goto IL_01ae;
								IL_01ae:
								e5aY0fGGhyBwpXUEbVyB(enumerator2);
								num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
								{
									num5 = 0;
								}
								goto IL_0185;
								IL_0185:
								switch (num5)
								{
								default:
									goto end_IL_0160;
								case 1:
									goto end_IL_0160;
								case 2:
									break;
								case 0:
									goto end_IL_0160;
								}
								goto IL_01ae;
								end_IL_0160:;
							}
							goto IL_01da;
						case 3:
							goto IL_01da;
						case 4:
							enumerator2 = current.Resources.Where(_003C_003Ec__DisplayClass17_._003CSetPriority_003Eb__0).GetEnumerator();
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
							{
								num3 = 1;
							}
							continue;
						}
						break;
					}
					goto IL_00aa;
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
				int num6 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
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

	public void SetFuzzy(string key, bool val, out List<LocalizationFile> file)
	{
		//Discarded unreachable code: IL_003a, IL_0049, IL_0054, IL_007c, IL_008b, IL_0096, IL_013a, IL_0172, IL_0181, IL_0255, IL_0268, IL_0277
		int num = 2;
		int num2 = num;
		List<LocalizationFile>.Enumerator enumerator = default(List<LocalizationFile>.Enumerator);
		_003C_003Ec__DisplayClass18_0 _003C_003Ec__DisplayClass18_ = default(_003C_003Ec__DisplayClass18_0);
		LocalizationFile current = default(LocalizationFile);
		IEnumerator<PoLineDescriptor> enumerator2 = default(IEnumerator<PoLineDescriptor>);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return;
			case 4:
				enumerator = Files.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				_003C_003Ec__DisplayClass18_ = new _003C_003Ec__DisplayClass18_0();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
				{
					num2 = 0;
				}
				continue;
			case 5:
				file = new List<LocalizationFile>();
				num2 = 4;
				continue;
			case 1:
				_003C_003Ec__DisplayClass18_.key = key;
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
				{
					num2 = 5;
				}
				continue;
			}
			try
			{
				while (true)
				{
					IL_01af:
					int num3;
					if (!enumerator.MoveNext())
					{
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
						{
							num3 = 0;
						}
						goto IL_0058;
					}
					goto IL_018c;
					IL_018c:
					current = enumerator.Current;
					num3 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
					{
						num3 = 4;
					}
					goto IL_0058;
					IL_0058:
					while (true)
					{
						switch (num3)
						{
						default:
							return;
						case 2:
							try
							{
								while (true)
								{
									IL_00ee:
									int num4;
									if (!enumerator2.MoveNext())
									{
										num4 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
										{
											num4 = 1;
										}
										goto IL_009a;
									}
									goto IL_00b4;
									IL_00b4:
									F3BbSrGGovE6ZP5KLoc0(enumerator2.Current, val);
									num4 = 3;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
									{
										num4 = 0;
									}
									goto IL_009a;
									IL_009a:
									while (true)
									{
										switch (num4)
										{
										case 3:
											file.Add(current);
											num4 = 2;
											continue;
										case 2:
											goto IL_00ee;
										case 1:
											goto end_IL_00ee;
										}
										break;
									}
									goto IL_00b4;
									continue;
									end_IL_00ee:
									break;
								}
							}
							finally
							{
								if (enumerator2 != null)
								{
									int num5 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
									{
										num5 = 0;
									}
									while (true)
									{
										switch (num5)
										{
										case 1:
											enumerator2.Dispose();
											num5 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
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
							goto IL_01af;
						case 3:
							break;
						case 1:
							goto IL_01af;
						case 4:
							enumerator2 = current.Resources.Where(_003C_003Ec__DisplayClass18_._003CSetFuzzy_003Eb__0).GetEnumerator();
							num3 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
							{
								num3 = 2;
							}
							continue;
						case 0:
							return;
						}
						break;
					}
					goto IL_018c;
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
				int num6 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
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

	public void RefreshStatistic()
	{
		//Discarded unreachable code: IL_0073, IL_00d6, IL_010e, IL_011d
		int num = 2;
		int num2 = num;
		object sinchObjs = default(object);
		bool lockTaken = default(bool);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				sinchObjs = _sinchObjs;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 3:
				try
				{
					Monitor.Enter(sinchObjs, ref lockTaken);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						case 1:
							return;
						}
						Statistic = (LocalizationStatistic)mIrKkSGGEHFLsEiRIFtP(this, null);
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
						{
							num3 = 1;
						}
					}
				}
				finally
				{
					if (lockTaken)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								Vq2xFbGGfXopoVwHvFRj(sinchObjs);
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
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
			case 1:
				lockTaken = false;
				num2 = 3;
				break;
			}
		}
	}

	public static LocalizationStatistic GetStatistic(LocalizationHolder holder, PoLineFilter filter)
	{
		//Discarded unreachable code: IL_007d, IL_008c, IL_00a2, IL_010d, IL_014d, IL_015c, IL_0167, IL_0213, IL_037d, IL_0770, IL_0783
		int num = 17;
		LocalizationStatistic localizationStatistic = default(LocalizationStatistic);
		_003C_003Ec__DisplayClass24_0 _003C_003Ec__DisplayClass24_ = default(_003C_003Ec__DisplayClass24_0);
		List<LocalizationFile>.Enumerator enumerator = default(List<LocalizationFile>.Enumerator);
		LocalizationFile current = default(LocalizationFile);
		List<PoLineDescriptor> list3 = default(List<PoLineDescriptor>);
		long value5 = default(long);
		int num4 = default(int);
		long value2 = default(long);
		long value3 = default(long);
		long value7 = default(long);
		long value4 = default(long);
		List<PoLineDescriptor> list2 = default(List<PoLineDescriptor>);
		long value = default(long);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				List<LocalizationFile> list;
				switch (num2)
				{
				case 8:
				case 19:
					list = holder.Files;
					goto IL_07aa;
				case 11:
					localizationStatistic = new LocalizationStatistic();
					num2 = 6;
					break;
				case 4:
					return localizationStatistic;
				case 17:
					_003C_003Ec__DisplayClass24_ = new _003C_003Ec__DisplayClass24_0();
					num2 = 16;
					break;
				case 16:
					_003C_003Ec__DisplayClass24_.filter = filter;
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
					{
						num2 = 6;
					}
					break;
				case 6:
					if (_003C_003Ec__DisplayClass24_.filter == null)
					{
						goto end_IL_0012;
					}
					goto case 20;
				case 20:
					if (!VN3F2wGGC1N1yZN7et8b(ap1pouGGQ9D5RelvYWe9(_003C_003Ec__DisplayClass24_.filter)))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 8;
				case 7:
					try
					{
						while (true)
						{
							IL_02bd:
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 20;
								goto IL_016b;
							}
							goto IL_028b;
							IL_016b:
							while (true)
							{
								List<PoLineDescriptor> list4;
								switch (num3)
								{
								case 4:
									localizationStatistic.StringsByFile.Add((string)nivQGPGGvhHVYgLrgE0B(current), T8XhNIGG8AC2LnT9eiAQ(list3));
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
									{
										num3 = 1;
									}
									continue;
								case 5:
									localizationStatistic.HighPriorityWordsByFile.Add(current.Name, value5);
									num3 = 6;
									continue;
								case 9:
									localizationStatistic.TranslatedByFile.Add((string)nivQGPGGvhHVYgLrgE0B(current), num4);
									num3 = 7;
									continue;
								case 14:
									localizationStatistic.WordsByFile.Add((string)nivQGPGGvhHVYgLrgE0B(current), value2);
									num3 = 7;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
									{
										num3 = 13;
									}
									continue;
								case 17:
									localizationStatistic.FuzzyCharsByFile.Add(current.Name, value3);
									num3 = 23;
									continue;
								case 10:
									goto IL_02bd;
								case 21:
									localizationStatistic.TranslatedCharsByFile.Add(current.Name, value7);
									num3 = 12;
									continue;
								case 3:
									localizationStatistic.CharsByFile.Add((string)nivQGPGGvhHVYgLrgE0B(current), value4);
									num3 = 15;
									continue;
								case 2:
									localizationStatistic.HighPriorityByFile.Add((string)nivQGPGGvhHVYgLrgE0B(current), list2.Count);
									num3 = 16;
									continue;
								case 18:
									localizationStatistic.HighPriorityCharsByFile.Add((string)nivQGPGGvhHVYgLrgE0B(current), value);
									num3 = 10;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
									{
										num3 = 6;
									}
									continue;
								case 19:
									list4 = LocalizationFile.ApplyFilter(current.Resources, _003C_003Ec__DisplayClass24_.filter);
									goto IL_03a4;
								case 22:
									if (_003C_003Ec__DisplayClass24_.filter == null)
									{
										num3 = 8;
										continue;
									}
									goto case 19;
								case 8:
									list4 = current.Resources.ToList();
									goto IL_03a4;
								case 1:
									value2 = list3.Sum((PoLineDescriptor r) => LocalizationStatistic.CountWords((string)_003C_003Ec.xcOlucvrOMsZZWm1qLRv(r)));
									num3 = 14;
									continue;
								case 13:
									value4 = list3.Sum((PoLineDescriptor r) => _003C_003Ec.I6o531vr2ud2LaLHCpL8(_003C_003Ec.xcOlucvrOMsZZWm1qLRv(r)));
									num3 = 3;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
									{
										num3 = 2;
									}
									continue;
								case 15:
									num4 = list3.Count((PoLineDescriptor r) => !_003C_003Ec.kAe6tuvreGVbFQC7WMdb(r.Value));
									num3 = 9;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
									{
										num3 = 6;
									}
									continue;
								case 7:
								{
									List<PoLineDescriptor> source = list3.Where((PoLineDescriptor r) => !_003C_003Ec.kAe6tuvreGVbFQC7WMdb(_003C_003Ec.N6YjT2vrPb6Ysw8yl2cw(r))).ToList();
									long value6 = source.Sum((PoLineDescriptor r) => _003C_003Ec.H1JeSPvr1V1BU38oB10g(_003C_003Ec.xcOlucvrOMsZZWm1qLRv(r)));
									localizationStatistic.TranslatedWordsByFile.Add((string)nivQGPGGvhHVYgLrgE0B(current), value6);
									value7 = source.Sum((PoLineDescriptor r) => _003C_003Ec.I6o531vr2ud2LaLHCpL8(r.Key));
									num3 = 21;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
									{
										num3 = 19;
									}
									continue;
								}
								case 12:
									localizationStatistic.ProgressByFile.Add((string)nivQGPGGvhHVYgLrgE0B(current), Convert.ToInt32((T8XhNIGG8AC2LnT9eiAQ(list3) > 0) ? (num4 * 100 / list3.Count) : 0));
									num3 = 24;
									continue;
								case 24:
									localizationStatistic.FuzzyByFile.Add((string)nivQGPGGvhHVYgLrgE0B(current), list3.Count((PoLineDescriptor r) => _003C_003Ec.luU4IXvrNCLcOtkw1pxa(r)));
									num3 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
									{
										num3 = 11;
									}
									continue;
								case 11:
								{
									List<PoLineDescriptor> source2 = list3.Where((PoLineDescriptor r) => _003C_003Ec.luU4IXvrNCLcOtkw1pxa(r)).ToList();
									long value8 = source2.Sum((PoLineDescriptor r) => LocalizationStatistic.CountWords((string)_003C_003Ec.xcOlucvrOMsZZWm1qLRv(r)));
									localizationStatistic.FuzzyWordsByFile.Add((string)nivQGPGGvhHVYgLrgE0B(current), value8);
									value3 = source2.Sum((PoLineDescriptor r) => _003C_003Ec.I6o531vr2ud2LaLHCpL8(r.Key));
									num3 = 17;
									continue;
								}
								case 23:
									list2 = list3.Where((PoLineDescriptor r) => !_003C_003Ec.rhbfoAvr3KQiAZ5OVEEM(r)).ToList();
									num3 = 2;
									continue;
								case 16:
									value5 = list2.Sum((PoLineDescriptor r) => _003C_003Ec.H1JeSPvr1V1BU38oB10g(_003C_003Ec.xcOlucvrOMsZZWm1qLRv(r)));
									num3 = 4;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
									{
										num3 = 5;
									}
									continue;
								case 6:
									value = list2.Sum((PoLineDescriptor r) => _003C_003Ec.I6o531vr2ud2LaLHCpL8(_003C_003Ec.xcOlucvrOMsZZWm1qLRv(r)));
									num3 = 3;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
									{
										num3 = 18;
									}
									continue;
								case 20:
									goto end_IL_02bd;
									IL_03a4:
									list3 = list4;
									num3 = 4;
									continue;
								}
								break;
							}
							goto IL_028b;
							IL_028b:
							current = enumerator.Current;
							num3 = 22;
							goto IL_016b;
							continue;
							end_IL_02bd:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
						{
							num5 = 0;
						}
						switch (num5)
						{
						case 0:
							break;
						}
					}
					goto case 14;
				case 1:
					list = holder.Files.Where(_003C_003Ec__DisplayClass24_._003CGetStatistic_003Eb__0).ToList();
					goto IL_07aa;
				case 14:
					localizationStatistic.TotalStrings = localizationStatistic.StringsByFile.Sum((KeyValuePair<string, long> f) => f.Value);
					num2 = 15;
					break;
				case 15:
					Tp9kpOGGZgKdi5DChnvF(localizationStatistic, localizationStatistic.TranslatedByFile.Sum((KeyValuePair<string, long> f) => f.Value));
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
					{
						num2 = 2;
					}
					break;
				case 3:
					NsehwFGGShtui6qS5jjM(localizationStatistic, qyRdk3GGVxtHOjFdsN4R((NkyqEVGGuM9LUCArKZQZ(localizationStatistic) > 0) ? (Murt8YGGIcGKN2aFPGeT(localizationStatistic) * 100 / NkyqEVGGuM9LUCArKZQZ(localizationStatistic)) : 0));
					num2 = 9;
					break;
				case 9:
					localizationStatistic.TotalFuzzy = localizationStatistic.FuzzyByFile.Sum((KeyValuePair<string, long> f) => f.Value);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
					{
						num2 = 0;
					}
					break;
				default:
					Q369UUGGi9h9H9TpL8Q0(localizationStatistic, localizationStatistic.WordsByFile.Sum((KeyValuePair<string, long> w) => w.Value));
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
					{
						num2 = 12;
					}
					break;
				case 12:
					WUATp2GGRfwNURipDvGn(localizationStatistic, localizationStatistic.CharsByFile.Sum((KeyValuePair<string, long> c) => c.Value));
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					localizationStatistic.TranslatedWords = localizationStatistic.TranslatedWordsByFile.Sum((KeyValuePair<string, long> tw) => tw.Value);
					num2 = 22;
					break;
				case 22:
					nhmNkoGGqEDWdhUEeyNN(localizationStatistic, localizationStatistic.TranslatedCharsByFile.Sum((KeyValuePair<string, long> tc) => tc.Value));
					num2 = 5;
					break;
				case 5:
					qJswHXGGK3aKY8uSKZgL(localizationStatistic, localizationStatistic.FuzzyWordsByFile.Sum((KeyValuePair<string, long> w) => w.Value));
					num2 = 13;
					break;
				case 13:
					aFhLhEGGXLpuvlvSKvdx(localizationStatistic, localizationStatistic.FuzzyCharsByFile.Sum((KeyValuePair<string, long> w) => w.Value));
					num2 = 18;
					break;
				case 18:
					localizationStatistic.TotalHighStrings = localizationStatistic.HighPriorityByFile.Sum((KeyValuePair<string, long> w) => w.Value);
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
					{
						num2 = 5;
					}
					break;
				case 10:
					VHPAwfGGTJdSopTLUT3l(localizationStatistic, localizationStatistic.HighPriorityWordsByFile.Sum((KeyValuePair<string, long> w) => w.Value));
					num2 = 21;
					break;
				case 21:
					{
						yEOaM2GGkwvExi81MkAX(localizationStatistic, localizationStatistic.HighPriorityCharsByFile.Sum((KeyValuePair<string, long> w) => w.Value));
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
						{
							num2 = 4;
						}
						break;
					}
					IL_07aa:
					enumerator = list.GetEnumerator();
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
					{
						num2 = 7;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 19;
		}
	}

	protected static List<PoLineDescriptor> GetDescriptors(PoLineFilter filter, LocalizationHolder mainHolder, LocalizationHolder joinHolder)
	{
		_003C_003Ec__DisplayClass25_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass25_0();
		CS_0024_003C_003E8__locals0.filter = filter;
		List<PoLineDescriptor> list = ((CS_0024_003C_003E8__locals0.filter != null && !string.IsNullOrEmpty(CS_0024_003C_003E8__locals0.filter.FileName)) ? mainHolder.Files.Where((LocalizationFile f) => f.Name.Equals((string)_003C_003Ec__DisplayClass25_0.sovh3fvr6h7qJGiC79Fe(CS_0024_003C_003E8__locals0.filter), StringComparison.OrdinalIgnoreCase)).ToList() : mainHolder.Files).SelectMany((LocalizationFile f) => f.Resources).ToList();
		List<PoLineDescriptor> list2 = LocalizationFile.ApplyFilter(list, CS_0024_003C_003E8__locals0.filter);
		if (joinHolder != null)
		{
			_003C_003Ec__DisplayClass25_1 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass25_1();
			CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1 = CS_0024_003C_003E8__locals0;
			List<LocalizationFile> source = ((CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.filter != null && !string.IsNullOrEmpty(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.filter.FileName)) ? joinHolder.Files.Where((LocalizationFile f) => _003C_003Ec__DisplayClass25_0.qEksrBvrATJHwN7FUTxU(_003C_003Ec__DisplayClass25_0.FXgGm7vrH448OPYXKi5l(f), _003C_003Ec__DisplayClass25_0.sovh3fvr6h7qJGiC79Fe(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.filter), StringComparison.OrdinalIgnoreCase)).ToList() : joinHolder.Files);
			CS_0024_003C_003E8__locals1.newRes = source.SelectMany((LocalizationFile f) => f.Resources).ToList();
			CS_0024_003C_003E8__locals1.ress = list2;
			if (CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.filter != null && !string.IsNullOrEmpty(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.filter.SearchString))
			{
				PoLineFilter filter2 = new PoLineFilter
				{
					SearchString = CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.filter.SearchString
				};
				CS_0024_003C_003E8__locals1.newRes = LocalizationFile.ApplyFilter(CS_0024_003C_003E8__locals1.newRes, filter2);
				IEnumerable<PoLineDescriptor> second = list.Where(delegate(PoLineDescriptor r)
				{
					//Discarded unreachable code: IL_0039
					int num = 5;
					int num2 = num;
					_003C_003Ec__DisplayClass25_2 _003C_003Ec__DisplayClass25_ = default(_003C_003Ec__DisplayClass25_2);
					while (true)
					{
						switch (num2)
						{
						case 4:
							_003C_003Ec__DisplayClass25_.r = r;
							num2 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
							{
								num2 = 3;
							}
							break;
						case 2:
							if (CS_0024_003C_003E8__locals1.ress.All(_003C_003Ec__DisplayClass25_._003CGetDescriptors_003Eb__6))
							{
								num2 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
								{
									num2 = 1;
								}
								break;
							}
							goto default;
						case 5:
							_003C_003Ec__DisplayClass25_ = new _003C_003Ec__DisplayClass25_2();
							num2 = 4;
							break;
						case 1:
							return _003C_003Ec__DisplayClass25_1.wkfgnXvryV1Ibqq2Y7yI(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.filter, _003C_003Ec__DisplayClass25_.r);
						default:
							return false;
						case 3:
							if (!CS_0024_003C_003E8__locals1.newRes.Any(_003C_003Ec__DisplayClass25_._003CGetDescriptors_003Eb__5))
							{
								num2 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
								{
									num2 = 0;
								}
								break;
							}
							goto case 2;
						}
					}
				});
				list2 = list2.Union(second).ToList();
			}
		}
		return list2;
	}

	public static long Count(PoLineFilter filter, LocalizationHolder mainHolder, LocalizationHolder joinHolder)
	{
		return T8XhNIGG8AC2LnT9eiAQ(GetDescriptors(filter, mainHolder, joinHolder));
	}

	public long Count(PoLineFilter filter)
	{
		return okGCsxGGnD0xuGd8qEwp(filter, this, null);
	}

	public static List<PoLineDescriptor> Find(FetchOptions options, PoLineFilter filter, LocalizationHolder mainHolder, LocalizationHolder joinHolder)
	{
		List<PoLineDescriptor> list = GetDescriptors(filter, mainHolder, joinHolder);
		if (options != null)
		{
			if (!string.IsNullOrEmpty(options.SortExpression))
			{
				string sortExpression = options.SortExpression;
				if (!(sortExpression == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1459557599 ^ -1459597973)))
				{
					if (sortExpression == z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x42643203 ^ 0x42649457))
					{
						list = ((options.SortDirection == ListSortDirection.Descending) ? list.OrderBy((PoLineDescriptor r) => (string)_003C_003Ec.N6YjT2vrPb6Ysw8yl2cw(r)) : list.OrderByDescending((PoLineDescriptor r) => (string)_003C_003Ec.N6YjT2vrPb6Ysw8yl2cw(r))).ToList();
					}
				}
				else
				{
					list = ((options.SortDirection == ListSortDirection.Ascending) ? list.OrderBy((PoLineDescriptor r) => (string)_003C_003Ec.xcOlucvrOMsZZWm1qLRv(r)) : list.OrderByDescending((PoLineDescriptor r) => (string)_003C_003Ec.xcOlucvrOMsZZWm1qLRv(r))).ToList();
				}
			}
			list = ((options.FirstResult + options.MaxResults >= list.Count) ? list.GetRange(options.FirstResult, list.Count - options.FirstResult) : list.GetRange(options.FirstResult, options.MaxResults));
		}
		return list;
	}

	public List<PoLineDescriptor> Find(FetchOptions options, PoLineFilter filter)
	{
		return Find(options, filter, this, null);
	}

	public PoLineDescriptor Find(string key)
	{
		//Discarded unreachable code: IL_0057, IL_0066, IL_0071, IL_00a0, IL_00af, IL_00be, IL_018e, IL_01a1
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass30_0 _003C_003Ec__DisplayClass30_ = default(_003C_003Ec__DisplayClass30_0);
		List<LocalizationFile>.Enumerator enumerator = default(List<LocalizationFile>.Enumerator);
		PoLineDescriptor poLineDescriptor = default(PoLineDescriptor);
		PoLineDescriptor result = default(PoLineDescriptor);
		while (true)
		{
			switch (num2)
			{
			case 2:
				_003C_003Ec__DisplayClass30_ = new _003C_003Ec__DisplayClass30_0();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 6;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
							{
								num3 = 3;
							}
							goto IL_0075;
						}
						goto IL_011e;
						IL_011e:
						poLineDescriptor = enumerator.Current.Resources.FirstOrDefault(_003C_003Ec__DisplayClass30_._003CFind_003Eb__0);
						num3 = 3;
						goto IL_0075;
						IL_0075:
						while (true)
						{
							switch (num3)
							{
							case 3:
								if (poLineDescriptor == null)
								{
									num3 = 4;
									continue;
								}
								goto case 2;
							case 2:
								result = poLineDescriptor;
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
								{
									num3 = 5;
								}
								continue;
							case 1:
								goto IL_011e;
							case 6:
								goto end_IL_00c9;
							case 5:
								return result;
							}
							break;
						}
						continue;
						end_IL_00c9:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				goto case 3;
			case 3:
				return null;
			default:
				enumerator = Files.GetEnumerator();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
				{
					num2 = 4;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass30_.key = key;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public List<PoLineDescriptor> FindByWords(FetchOptions options, List<List<string>> words, bool containsMode)
	{
		_003C_003Ec__DisplayClass31_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass31_0();
		CS_0024_003C_003E8__locals0.words = words;
		CS_0024_003C_003E8__locals0.containsMode = containsMode;
		List<PoLineDescriptor> list = Files.SelectMany((LocalizationFile f) => f.FindByWords(CS_0024_003C_003E8__locals0.words, CS_0024_003C_003E8__locals0.containsMode)).ToList();
		if (options != null)
		{
			if (!string.IsNullOrEmpty(options.SortExpression))
			{
				string sortExpression = options.SortExpression;
				if (!(sortExpression == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1633514411 ^ -1633539553)))
				{
					if (sortExpression == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1108654032 ^ -1108611484))
					{
						list = ((options.SortDirection == ListSortDirection.Descending) ? list.OrderBy((PoLineDescriptor r) => (string)_003C_003Ec.N6YjT2vrPb6Ysw8yl2cw(r)) : list.OrderByDescending((PoLineDescriptor r) => (string)_003C_003Ec.N6YjT2vrPb6Ysw8yl2cw(r))).ToList();
					}
				}
				else
				{
					list = ((options.SortDirection == ListSortDirection.Ascending) ? list.OrderBy((PoLineDescriptor r) => (string)_003C_003Ec.xcOlucvrOMsZZWm1qLRv(r)) : list.OrderByDescending((PoLineDescriptor r) => (string)_003C_003Ec.xcOlucvrOMsZZWm1qLRv(r))).ToList();
				}
			}
			list = ((options.FirstResult + options.MaxResults >= list.Count) ? list.GetRange(options.FirstResult, list.Count - options.FirstResult) : list.GetRange(options.FirstResult, options.MaxResults));
		}
		return list;
	}

	public static string[] SplitByWords(string text)
	{
		return ((IEnumerable<string>)frr1R1GG2NoQa1EcY894(text, LkMOMoGGObJX7pSilgLZ(0x12441CA4 ^ 0x1247A7D0))).Select((string w) => (string)_003C_003Ec.hxn8DmvrpsUFX4jgsLIn(w)).Where(delegate(string w)
		{
			//Discarded unreachable code: IL_002d, IL_003c
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return _003C_003Ec.PhblcbvraXIuC3woKfXG(w) > 2;
				case 1:
					return false;
				case 2:
					if (string.IsNullOrEmpty(w))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto default;
				}
			}
		}).ToArray();
	}

	public List<PoLineDescriptor> FindByWords(FetchOptions options, string text, double level, bool containsMode)
	{
		string[] array = SplitByWords(text);
		if (array.Length == 0)
		{
			return new List<PoLineDescriptor>();
		}
		if (array.Length > 10)
		{
			array = array.ToList().GetRange(0, 10).ToArray();
		}
		int num = array.Length;
		long num2 = Convert.ToInt64(Math.Round((double)array.Length * level));
		List<List<string>> list = new List<List<string>>();
		string[] buffer = new string[num2];
		GetCombination(0L, 0L, num, num2, array, list, buffer);
		return FindByWords(options, list, containsMode);
	}

	public void GetCombination(long pos, long maxUsed, long wordsCount, long wordsLevelCount, string[] words, List<List<string>> combinations, string[] buffer)
	{
		if (pos == wordsLevelCount)
		{
			combinations.Add(buffer.ToList());
			return;
		}
		for (long num = maxUsed + 1; num <= wordsCount; num++)
		{
			buffer[pos] = words[num - 1];
			GetCombination(pos + 1, num, wordsCount, wordsLevelCount, words, combinations, buffer);
		}
	}

	internal static void VWXUOXGGFuOkNlqpQ1M4()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool eQ09tOGhcg0Qg5KlAW0H()
	{
		return ymdk8gGhsskcwF28v8Aa == null;
	}

	internal static LocalizationHolder gXSx2mGhzpNiPSYJECKe()
	{
		return ymdk8gGhsskcwF28v8Aa;
	}

	internal static object jPl69FGGBXtIf1TkGWO0(object P_0)
	{
		return ((PoLineDescriptor)P_0).Value;
	}

	internal static void aOZ0bZGGWlPH8YLRriLs(object P_0, object P_1)
	{
		((PoLineDescriptor)P_0).Value = (string)P_1;
	}

	internal static void F3BbSrGGovE6ZP5KLoc0(object P_0, bool value)
	{
		((PoLineDescriptor)P_0).IsFuzzy = value;
	}

	internal static bool JDSNW0GGbNrxJ6LmUUjN(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void e5aY0fGGhyBwpXUEbVyB(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void BAtHgqGGGOYcxTXapULw(object P_0, bool value)
	{
		((PoLineDescriptor)P_0).IsLow = value;
	}

	internal static object mIrKkSGGEHFLsEiRIFtP(object P_0, object P_1)
	{
		return GetStatistic((LocalizationHolder)P_0, (PoLineFilter)P_1);
	}

	internal static void Vq2xFbGGfXopoVwHvFRj(object P_0)
	{
		Monitor.Exit(P_0);
	}

	internal static object ap1pouGGQ9D5RelvYWe9(object P_0)
	{
		return ((PoLineFilter)P_0).FileName;
	}

	internal static bool VN3F2wGGC1N1yZN7et8b(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object nivQGPGGvhHVYgLrgE0B(object P_0)
	{
		return ((LocalizationFile)P_0).Name;
	}

	internal static int T8XhNIGG8AC2LnT9eiAQ(object P_0)
	{
		return ((List<PoLineDescriptor>)P_0).Count;
	}

	internal static void Tp9kpOGGZgKdi5DChnvF(object P_0, long value)
	{
		((LocalizationStatistic)P_0).Translated = value;
	}

	internal static long NkyqEVGGuM9LUCArKZQZ(object P_0)
	{
		return ((LocalizationStatistic)P_0).TotalStrings;
	}

	internal static long Murt8YGGIcGKN2aFPGeT(object P_0)
	{
		return ((LocalizationStatistic)P_0).Translated;
	}

	internal static int qyRdk3GGVxtHOjFdsN4R(long P_0)
	{
		return Convert.ToInt32(P_0);
	}

	internal static void NsehwFGGShtui6qS5jjM(object P_0, int value)
	{
		((LocalizationStatistic)P_0).TotalProgress = value;
	}

	internal static void Q369UUGGi9h9H9TpL8Q0(object P_0, long value)
	{
		((LocalizationStatistic)P_0).TotalWords = value;
	}

	internal static void WUATp2GGRfwNURipDvGn(object P_0, long value)
	{
		((LocalizationStatistic)P_0).TotalChars = value;
	}

	internal static void nhmNkoGGqEDWdhUEeyNN(object P_0, long value)
	{
		((LocalizationStatistic)P_0).TranslatedChars = value;
	}

	internal static void qJswHXGGK3aKY8uSKZgL(object P_0, long value)
	{
		((LocalizationStatistic)P_0).TotalFuzzyWords = value;
	}

	internal static void aFhLhEGGXLpuvlvSKvdx(object P_0, long value)
	{
		((LocalizationStatistic)P_0).TotalFuzzyChars = value;
	}

	internal static void VHPAwfGGTJdSopTLUT3l(object P_0, long value)
	{
		((LocalizationStatistic)P_0).TotalHighWords = value;
	}

	internal static void yEOaM2GGkwvExi81MkAX(object P_0, long value)
	{
		((LocalizationStatistic)P_0).TotalHighChars = value;
	}

	internal static long okGCsxGGnD0xuGd8qEwp(object P_0, object P_1, object P_2)
	{
		return Count((PoLineFilter)P_0, (LocalizationHolder)P_1, (LocalizationHolder)P_2);
	}

	internal static object LkMOMoGGObJX7pSilgLZ(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object frr1R1GG2NoQa1EcY894(object P_0, object P_1)
	{
		return Regex.Split((string)P_0, (string)P_1);
	}
}
