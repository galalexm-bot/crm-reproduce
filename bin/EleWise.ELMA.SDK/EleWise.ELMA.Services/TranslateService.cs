using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Configuration;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Globalization;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Threading;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Services;

[Service(Type = ComponentType.Server)]
public class TranslateService : IInitHandler
{
	private bool _inited;

	private ConcurrentDictionary<string, LocalizationHolder> _localizations;

	private ConcurrentDictionary<string, bool> _mergeLocales;

	private string _translationsPath;

	private Queue<LocalizationOperation> _localizationOperations;

	private ConcurrentDictionary<Guid, PrepareOperationDescription> _prepareOperations;

	private ConcurrentDictionary<long, string> _translateLocales;

	private ConcurrentDictionary<long, bool> _translateMode;

	private DateTime _lastSaveTime;

	private readonly IContextBoundVariableService contextBoundVariableService;

	private readonly IZipStreamService zipStreamService;

	private object _translateChangeSinch;

	internal static TranslateService RZfUJWBAfHHNgHOuTnCH;

	public static TranslateService Instance => Locator.GetService<TranslateService>();

	public DateTime LastSaveTime => _lastSaveTime;

	public bool InLineTurned
	{
		get
		{
			bool value;
			return contextBoundVariableService.TryGetValue<bool>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951561958), out value) && value;
		}
		set
		{
			int num = 3;
			int num2 = num;
			bool value2 = default(bool);
			while (true)
			{
				switch (num2)
				{
				default:
					ProcessTranslateChange();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					if (value2 != value)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				case 3:
					contextBoundVariableService.TryGetValue<bool>((string)FQS7aDBAvN4WrUlFWP7J(--1333735954 ^ 0x4F7E6AEE), out value2);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					break;
				case 4:
					return;
				}
				Ew2ZcrBA8vjxXgeBqS4x(contextBoundVariableService, FQS7aDBAvN4WrUlFWP7J(-1123633026 ^ -1123557246), value);
				num2 = 4;
			}
		}
	}

	public bool InLineDisabled
	{
		get
		{
			bool value;
			return contextBoundVariableService.TryGetValue<bool>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1876063057 ^ -1876109873), out value) && value;
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
					Ew2ZcrBA8vjxXgeBqS4x(contextBoundVariableService, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x103FE975 ^ 0x103EB015), value);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public IRuntimeApplication RuntimeApplication
	{
		[CompilerGenerated]
		get
		{
			return _003CRuntimeApplication_003Ek__BackingField;
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
					_003CRuntimeApplication_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public bool Initialized => _inited;

	public TranslateService(IContextBoundVariableService contextBoundVariableService, IZipStreamService zipStreamService)
	{
		//Discarded unreachable code: IL_003a, IL_003f
		SingletonReader.JJCZtPuTvSt();
		_translateChangeSinch = new object();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				return;
			case 1:
				this.zipStreamService = zipStreamService;
				num = 2;
				continue;
			}
			this.contextBoundVariableService = contextBoundVariableService;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
			{
				num = 0;
			}
		}
	}

	public void Init()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				_localizations = new ConcurrentDictionary<string, LocalizationHolder>();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
				{
					num2 = 1;
				}
				break;
			default:
				_prepareOperations = new ConcurrentDictionary<Guid, PrepareOperationDescription>();
				num2 = 5;
				break;
			case 4:
				_translateMode = new ConcurrentDictionary<long, bool>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
				{
					num2 = 0;
				}
				break;
			case 6:
				_translateLocales = new ConcurrentDictionary<long, string>();
				num2 = 4;
				break;
			case 5:
				return;
			case 3:
				_localizationOperations = new Queue<LocalizationOperation>();
				num2 = 6;
				break;
			case 1:
				_mergeLocales = new ConcurrentDictionary<string, bool>();
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public void InitComplete()
	{
	}

	public string GetTranslateLocalization(long? userId = null)
	{
		if (!userId.HasValue)
		{
			IUser currentUser = AuthenticationService.GetCurrentUser();
			if (currentUser == null)
			{
				return null;
			}
			userId = Convert.ToInt64(currentUser.GetId());
		}
		if (_translateLocales.TryGetValue(userId.Value, out var value))
		{
			return value;
		}
		return null;
	}

	public void SetTranslateLocalization(long userId, string loc)
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
				_translateLocales[userId] = loc;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 1:
				ProcessTranslateChange();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void ProcessTranslateChange()
	{
		//Discarded unreachable code: IL_0050, IL_0097, IL_00a6, IL_00b1, IL_012d, IL_016d, IL_017c, IL_01a9, IL_01e1, IL_01f0
		int num = 2;
		int num2 = num;
		object translateChangeSinch = default(object);
		bool lockTaken = default(bool);
		IEnumerator<ITranslateChangeHandler> enumerator = default(IEnumerator<ITranslateChangeHandler>);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				try
				{
					Monitor.Enter(translateChangeSinch, ref lockTaken);
					int num3 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
					{
						num3 = 1;
					}
					while (true)
					{
						switch (num3)
						{
						case 1:
							enumerator = ((ComponentManager)KSeTlhBAZV8KWbppBHsH()).GetExtensionPoints<ITranslateChangeHandler>().GetEnumerator();
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
							{
								num3 = 0;
							}
							continue;
						}
						try
						{
							while (true)
							{
								int num4;
								if (!iEDjc0BAIkJ2BJAL1NTU(enumerator))
								{
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
									{
										num4 = 0;
									}
									goto IL_00b5;
								}
								goto IL_00f1;
								IL_00f1:
								cwmV6mBAu5d7WgXF0tH8(enumerator.Current);
								num4 = 2;
								goto IL_00b5;
								IL_00b5:
								switch (num4)
								{
								default:
									return;
								case 2:
									break;
								case 1:
									goto IL_00f1;
								case 0:
									return;
								}
							}
						}
						finally
						{
							int num5;
							if (enumerator == null)
							{
								num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
								{
									num5 = 1;
								}
								goto IL_0131;
							}
							goto IL_0147;
							IL_0147:
							YFfa75BAVm4swBHtrXIq(enumerator);
							num5 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
							{
								num5 = 1;
							}
							goto IL_0131;
							IL_0131:
							switch (num5)
							{
							case 1:
								goto end_IL_010c;
							case 2:
								goto end_IL_010c;
							}
							goto IL_0147;
							end_IL_010c:;
						}
					}
				}
				finally
				{
					if (lockTaken)
					{
						int num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
						{
							num6 = 0;
						}
						while (true)
						{
							switch (num6)
							{
							default:
								VXp0KXBASUuQGNvllZsX(translateChangeSinch);
								num6 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
								{
									num6 = 0;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
			case 0:
				return;
			case 2:
				translateChangeSinch = _translateChangeSinch;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				lockTaken = false;
				num2 = 3;
				break;
			}
		}
	}

	public LocalizationHolder GetTranslation(string id)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!_localizations.ContainsKey(id))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return _localizations[id];
			default:
				return null;
			}
		}
	}

	public void EnabledTranslationMode(long userId, bool enabled)
	{
		//Discarded unreachable code: IL_007b, IL_008a, IL_0099, IL_013f
		int num = 16;
		int num2 = num;
		CultureInfo cultureInfo = default(CultureInfo);
		_003C_003Ec__DisplayClass23_0 _003C_003Ec__DisplayClass23_ = default(_003C_003Ec__DisplayClass23_0);
		string translateLocalization = default(string);
		while (true)
		{
			switch (num2)
			{
			case 3:
				SetTranslateLocalization(userId, null);
				num2 = 7;
				break;
			case 4:
			case 7:
			case 10:
				ProcessTranslateChange();
				num2 = 11;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
				{
					num2 = 11;
				}
				break;
			case 16:
				CheckInit();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
				{
					num2 = 15;
				}
				break;
			case 2:
				if (enabled)
				{
					num2 = 12;
					break;
				}
				goto case 4;
			default:
				cultureInfo = GetTargets().FirstOrDefault(_003C_003Ec__DisplayClass23_._003CEnabledTranslationMode_003Eb__0);
				num2 = 8;
				break;
			case 11:
				return;
			case 12:
				_003C_003Ec__DisplayClass23_ = new _003C_003Ec__DisplayClass23_0();
				num2 = 9;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
				{
					num2 = 17;
				}
				break;
			case 17:
				translateLocalization = GetTranslateLocalization(userId);
				num2 = 11;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
				{
					num2 = 13;
				}
				break;
			case 5:
				if (c5WRyxBAqZMHTQ2adwPt(translateLocalization, lB8aEqBARygdkLy8VkYv(_003C_003Ec__DisplayClass23_.current), StringComparison.OrdinalIgnoreCase))
				{
					num2 = 3;
					break;
				}
				goto case 4;
			case 6:
				if (qhsg16BAi51kY0uYLLeb(translateLocalization))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 5;
			case 8:
				if (cultureInfo == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 14;
			case 13:
				_003C_003Ec__DisplayClass23_.current = SR.GetCurrentCulture();
				num2 = 6;
				break;
			case 14:
				SetTranslateLocalization(userId, cultureInfo.Name);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
			case 9:
				SetTranslateLocalization(userId, null);
				num2 = 10;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
				{
					num2 = 5;
				}
				break;
			case 15:
				_translateMode[userId] = enabled;
				num2 = 2;
				break;
			}
		}
	}

	public bool IsTranslationModeEnabled(long? userId = null)
	{
		if (!Initialized)
		{
			return false;
		}
		if (!userId.HasValue)
		{
			IUser user = null;
			try
			{
				user = AuthenticationService.GetCurrentUser();
			}
			catch (Exception ex)
			{
				Logger.Log.Error(ex.Message, ex);
				return false;
			}
			if (user == null)
			{
				return false;
			}
			userId = Convert.ToInt64(user.GetId());
		}
		if (_translateMode.TryGetValue(userId.Value, out var value))
		{
			return value;
		}
		return false;
	}

	public string T(string currentLoc, string targetLoc, string t, bool nowrapper = false)
	{
		//Discarded unreachable code: IL_0178, IL_0187, IL_01c2, IL_01d5, IL_01e4, IL_0234, IL_0243, IL_0274, IL_0283, IL_0292
		int num = 20;
		string text2 = default(string);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 16:
					if (!_localizations.ContainsKey(currentLoc))
					{
						num2 = 8;
						continue;
					}
					text2 = (string)tO5j3kBAXSorhq2HWfS5(_localizations[currentLoc], t);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
					{
						num2 = 4;
					}
					continue;
				case 19:
					if (!pUMixnBAKKKZF0jnnZsE(t, FQS7aDBAvN4WrUlFWP7J(0x7459E02 ^ 0x744C7D0)))
					{
						num = 11;
						break;
					}
					goto case 1;
				case 5:
					if (!string.IsNullOrEmpty(text2))
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
						{
							num2 = 18;
						}
						continue;
					}
					goto case 9;
				case 6:
				case 8:
					return t;
				case 10:
					if (!_localizations.ContainsKey(targetLoc))
					{
						num2 = 12;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
						{
							num2 = 1;
						}
					}
					else
					{
						text = (string)tO5j3kBAXSorhq2HWfS5(_localizations[targetLoc], t);
						num2 = 5;
					}
					continue;
				case 3:
				case 12:
					if (!qhsg16BAi51kY0uYLLeb(text2))
					{
						num = 13;
						break;
					}
					goto case 7;
				case 7:
					return t;
				case 13:
					return text2;
				case 4:
					if (qhsg16BAi51kY0uYLLeb(targetLoc))
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 10;
				case 17:
					return text2;
				case 14:
					return text;
				case 2:
					return (string)TPck7OBATWxcSohW2QAN(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-787452571 ^ -787401585), t, text2, text);
				default:
					if (!qhsg16BAi51kY0uYLLeb(text))
					{
						num2 = 14;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 17;
				case 15:
				case 18:
					if (nowrapper)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 2;
				case 1:
					return t;
				case 11:
					if (qhsg16BAi51kY0uYLLeb(currentLoc))
					{
						num2 = 6;
						continue;
					}
					goto case 16;
				case 9:
					text2 = t;
					num2 = 15;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
					{
						num2 = 3;
					}
					continue;
				case 20:
					CheckInit();
					num2 = 19;
					continue;
				}
				break;
			}
		}
	}

	public List<string> TA(string currentLoc, string targetLoc, string t, bool nowrapper = false)
	{
		CheckInit();
		List<string> list = new List<string>();
		if (t.Contains(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x269E5FCA ^ 0x269F0618)))
		{
			return new List<string> { t };
		}
		if (string.IsNullOrEmpty(currentLoc) || !_localizations.ContainsKey(currentLoc))
		{
			return new List<string> { t };
		}
		string text = _localizations[currentLoc].T(t);
		if (string.IsNullOrEmpty(targetLoc) || !_localizations.ContainsKey(targetLoc))
		{
			if (string.IsNullOrEmpty(text))
			{
				return new List<string> { t };
			}
			return new List<string> { text };
		}
		string text2 = _localizations[targetLoc].T(t);
		if (currentLoc.Equals(SR.KeyCultureInfo.Name, StringComparison.OrdinalIgnoreCase) && string.IsNullOrEmpty(text))
		{
			text = t;
		}
		if (nowrapper)
		{
			string text3 = ((!string.IsNullOrEmpty(text2)) ? text2 : text);
			return new List<string> { (!string.IsNullOrEmpty(text3)) ? text3 : t };
		}
		list.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x31326106 ^ 0x313338D4));
		list.Add(t);
		list.Add(text);
		list.Add(text2 ?? string.Empty);
		list.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-672123589 ^ -672043259));
		return list;
	}

	public void SetPriority(string locId, string t, bool val)
	{
		//Discarded unreachable code: IL_00ab, IL_00ba, IL_00c5, IL_0191, IL_01a4
		int num = 8;
		List<LocalizationFile>.Enumerator enumerator = default(List<LocalizationFile>.Enumerator);
		LocalizationFile current = default(LocalizationFile);
		List<LocalizationFile> file = default(List<LocalizationFile>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 4:
					_lastSaveTime = DateTime.Now;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
					{
						num2 = 1;
					}
					continue;
				case 6:
					return;
				case 5:
					ProcessTranslateChange();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
					{
						num2 = 0;
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
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
								{
									num3 = 1;
								}
								goto IL_00c9;
							}
							goto IL_0142;
							IL_0142:
							current = enumerator.Current;
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
							{
								num3 = 3;
							}
							goto IL_00c9;
							IL_00c9:
							while (true)
							{
								switch (num3)
								{
								case 2:
									break;
								case 3:
								{
									Queue<LocalizationOperation> localizationOperations = _localizationOperations;
									LocalizationSaveOperation localizationSaveOperation = new LocalizationSaveOperation();
									Rxx9cnBAksKJ6TWSg7qt(localizationSaveOperation, this);
									YeF4F2BAn2u9bGu9ix66(localizationSaveOperation, current);
									localizationOperations.LockEnqueue(localizationSaveOperation);
									num3 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
									{
										num3 = 0;
									}
									continue;
								}
								default:
									goto IL_0142;
								case 1:
									goto end_IL_00e3;
								}
								break;
							}
							continue;
							end_IL_00e3:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
					break;
				case 0:
					return;
				case 8:
					CheckInit();
					num2 = 7;
					continue;
				case 7:
					if (_localizations.ContainsKey(locId))
					{
						_localizations[locId].SetPriority(t, val, out file);
						num2 = 4;
						continue;
					}
					goto end_IL_0012;
				case 1:
					enumerator = file.GetEnumerator();
					num2 = 2;
					continue;
				case 3:
					break;
				}
				if (WAKfhGBAOhaKwH8gF6mI(file) <= 0)
				{
					return;
				}
				num2 = 5;
				continue;
				end_IL_0012:
				break;
			}
			num = 6;
		}
	}

	public void SetFuzzy(string locId, string t, bool val)
	{
		//Discarded unreachable code: IL_00a8, IL_00b2, IL_017e, IL_0191
		int num = 3;
		int num2 = num;
		List<LocalizationFile> file = default(List<LocalizationFile>);
		List<LocalizationFile>.Enumerator enumerator = default(List<LocalizationFile>.Enumerator);
		LocalizationFile current = default(LocalizationFile);
		while (true)
		{
			switch (num2)
			{
			case 5:
				if (WAKfhGBAOhaKwH8gF6mI(file) > 0)
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
					{
						num2 = 8;
					}
					break;
				}
				return;
			case 2:
				if (!_localizations.ContainsKey(locId))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
					{
						num2 = 1;
					}
					break;
				}
				_localizations[locId].SetFuzzy(t, val, out file);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
				{
					num2 = 0;
				}
				break;
			case 8:
				ProcessTranslateChange();
				num2 = 4;
				break;
			case 7:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
							{
								num3 = 3;
							}
							goto IL_00b6;
						}
						goto IL_00f6;
						IL_00f6:
						current = enumerator.Current;
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
						{
							num3 = 1;
						}
						goto IL_00b6;
						IL_00b6:
						while (true)
						{
							switch (num3)
							{
							case 2:
								goto IL_00f6;
							case 1:
							{
								Queue<LocalizationOperation> localizationOperations = _localizationOperations;
								LocalizationSaveOperation localizationSaveOperation = new LocalizationSaveOperation();
								Rxx9cnBAksKJ6TWSg7qt(localizationSaveOperation, this);
								YeF4F2BAn2u9bGu9ix66(localizationSaveOperation, current);
								localizationOperations.LockEnqueue(localizationSaveOperation);
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
								{
									num3 = 0;
								}
								continue;
							}
							case 3:
								goto end_IL_00d0;
							}
							break;
						}
						continue;
						end_IL_00d0:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				goto case 5;
			case 4:
				return;
			default:
				_lastSaveTime = DateTime.Now;
				num2 = 6;
				break;
			case 3:
				CheckInit();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				return;
			case 6:
				enumerator = file.GetEnumerator();
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
				{
					num2 = 7;
				}
				break;
			}
		}
	}

	public void SetTranslate(string locId, string t, string val)
	{
		//Discarded unreachable code: IL_0082, IL_0092, IL_00a1, IL_00ac, IL_00fc, IL_010b, IL_0116, IL_021c, IL_022f, IL_02ae, IL_02c1, IL_02f8, IL_0307, IL_0312, IL_03de, IL_03f1, IL_0400
		int num = 5;
		Dictionary<string, List<PoLineDescriptor>>.Enumerator enumerator2 = default(Dictionary<string, List<PoLineDescriptor>>.Enumerator);
		KeyValuePair<string, List<PoLineDescriptor>> current = default(KeyValuePair<string, List<PoLineDescriptor>>);
		List<PoLineDescriptor>.Enumerator enumerator3 = default(List<PoLineDescriptor>.Enumerator);
		PoLineDescriptor current2 = default(PoLineDescriptor);
		List<LocalizationFile> file = default(List<LocalizationFile>);
		LocalizationFile localizationFile = default(LocalizationFile);
		Dictionary<string, List<PoLineDescriptor>> dictionary = default(Dictionary<string, List<PoLineDescriptor>>);
		List<LocalizationFile>.Enumerator enumerator = default(List<LocalizationFile>.Enumerator);
		LocalizationFile current3 = default(LocalizationFile);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					CheckInit();
					num2 = 4;
					continue;
				case 6:
				case 13:
					_lastSaveTime = yJZTD2BAPHnTJZa5RGQK();
					num2 = 8;
					continue;
				case 9:
					try
					{
						while (true)
						{
							IL_025c:
							int num3;
							if (!enumerator2.MoveNext())
							{
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
								{
									num3 = 1;
								}
								goto IL_00b0;
							}
							goto IL_0239;
							IL_0239:
							current = enumerator2.Current;
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
							{
								num3 = 2;
							}
							goto IL_00b0;
							IL_00b0:
							while (true)
							{
								switch (num3)
								{
								case 2:
									enumerator3 = current.Value.GetEnumerator();
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
									{
										num3 = 0;
									}
									continue;
								default:
									try
									{
										while (true)
										{
											IL_0181:
											int num4;
											if (!enumerator3.MoveNext())
											{
												num4 = 5;
												goto IL_011a;
											}
											goto IL_013c;
											IL_011a:
											while (true)
											{
												switch (num4)
												{
												case 2:
													break;
												case 4:
													VgxaH0BAexdlW9p5BgAu(current2, val);
													num4 = 1;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
													{
														num4 = 0;
													}
													continue;
												case 3:
													goto IL_0181;
												default:
													file.Add(localizationFile);
													num4 = 3;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
													{
														num4 = 1;
													}
													continue;
												case 1:
													_localizations[locId].AddResourceToFile(current.Key, current2, out localizationFile);
													num4 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
													{
														num4 = 0;
													}
													continue;
												case 5:
													goto end_IL_0181;
												}
												break;
											}
											goto IL_013c;
											IL_013c:
											current2 = enumerator3.Current;
											num4 = 4;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
											{
												num4 = 4;
											}
											goto IL_011a;
											continue;
											end_IL_0181:
											break;
										}
									}
									finally
									{
										((IDisposable)enumerator3).Dispose();
										int num5 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
										{
											num5 = 0;
										}
										switch (num5)
										{
										case 0:
											break;
										}
									}
									goto IL_025c;
								case 3:
									break;
								case 4:
									goto IL_025c;
								case 1:
									goto end_IL_025c;
								}
								break;
							}
							goto IL_0239;
							continue;
							end_IL_025c:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator2).Dispose();
						int num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
						{
							num6 = 0;
						}
						switch (num6)
						{
						case 0:
							break;
						}
					}
					goto case 6;
				case 14:
					dictionary = FindKeyInBaseTranslate(t);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
					{
						num2 = 3;
					}
					continue;
				case 2:
					try
					{
						while (true)
						{
							IL_038c:
							int num7;
							if (!enumerator.MoveNext())
							{
								num7 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
								{
									num7 = 0;
								}
								goto IL_0316;
							}
							goto IL_0369;
							IL_0369:
							current3 = enumerator.Current;
							num7 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
							{
								num7 = 0;
							}
							goto IL_0316;
							IL_0316:
							while (true)
							{
								switch (num7)
								{
								case 3:
								{
									Queue<LocalizationOperation> localizationOperations = _localizationOperations;
									LocalizationSaveOperation localizationSaveOperation = new LocalizationSaveOperation();
									Rxx9cnBAksKJ6TWSg7qt(localizationSaveOperation, this);
									YeF4F2BAn2u9bGu9ix66(localizationSaveOperation, current3);
									localizationOperations.LockEnqueue(localizationSaveOperation);
									num7 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
									{
										num7 = 0;
									}
									continue;
								}
								case 1:
									break;
								default:
									goto IL_038c;
								case 2:
									goto end_IL_038c;
								}
								break;
							}
							goto IL_0369;
							continue;
							end_IL_038c:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num8 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
						{
							num8 = 0;
						}
						switch (num8)
						{
						case 0:
							break;
						}
					}
					break;
				case 7:
					return;
				case 10:
					goto end_IL_0012;
				case 1:
					_localizations[locId].SetTranslate(t, val, out file);
					num2 = 12;
					continue;
				case 12:
					if (file.Count != 0)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto case 14;
				case 3:
					if (dictionary.Count > 0)
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
						{
							num2 = 10;
						}
						continue;
					}
					goto case 6;
				case 4:
					if (_localizations.ContainsKey(locId))
					{
						t = (string)z7T3i0BA2IAvNs54Fp5M(z7T3i0BA2IAvNs54Fp5M(t, '\u00a0'.ToString(), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-889460160 ^ -889478302)), FQS7aDBAvN4WrUlFWP7J(-488881205 ^ -488874701), "");
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
						{
							num2 = 1;
						}
					}
					else
					{
						num2 = 7;
					}
					continue;
				case 8:
					enumerator = file.GetEnumerator();
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
					{
						num2 = 1;
					}
					continue;
				case 11:
					return;
				}
				ProcessTranslateChange();
				num2 = 11;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
				{
					num2 = 9;
				}
				continue;
				end_IL_0012:
				break;
			}
			enumerator2 = dictionary.GetEnumerator();
			num = 9;
		}
	}

	public bool HasMergingOperation(string locId)
	{
		//Discarded unreachable code: IL_0035, IL_0044
		int num = 3;
		bool value = default(bool);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					value = false;
					num2 = 2;
					continue;
				default:
					_mergeLocales.TryGetValue(locId, out value);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
				case 4:
					return value;
				case 2:
					if (qhsg16BAi51kY0uYLLeb(locId))
					{
						break;
					}
					goto default;
				}
				break;
			}
			num = 4;
		}
	}

	public bool IsNeedMerge(string locId)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
			{
				if (HasMergingOperation(locId))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
					{
						num2 = 0;
					}
					break;
				}
				object targetPath = bqFY6YBA1qvu8lc1Yj3f(locId);
				string translationDir = GetTranslationDir(locId);
				LocalizationHash localizationHash = SR.ComputeLocalizationHash((string)targetPath);
				LocalizationHash localizationHash2 = SR.ComputeLocalizationHash(translationDir);
				return !vLOSISBAN4VRWbEdameU(localizationHash, localizationHash2);
			}
			default:
				return false;
			}
		}
	}

	public void Merge(string locId)
	{
		//Discarded unreachable code: IL_00ac
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 4:
				return;
			case 2:
				_mergeLocales[locId] = true;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				if (HasMergingOperation(locId))
				{
					return;
				}
				num2 = 2;
				break;
			case 0:
				return;
			case 1:
			{
				Queue<LocalizationOperation> localizationOperations = _localizationOperations;
				LocalizationMergeOperation localizationMergeOperation = new LocalizationMergeOperation();
				Rxx9cnBAksKJ6TWSg7qt(localizationMergeOperation, this);
				mxmZsIBA3RMCGRvNZr8L(localizationMergeOperation, locId);
				localizationOperations.LockEnqueue(localizationMergeOperation);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
				{
					num2 = 0;
				}
				break;
			}
			}
		}
	}

	public Dictionary<string, List<PoLineDescriptor>> FindKeyInBaseTranslate(string t)
	{
		_003C_003Ec__DisplayClass33_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass33_0();
		CS_0024_003C_003E8__locals0.t = t;
		CheckInit();
		Dictionary<string, List<PoLineDescriptor>> dictionary = new Dictionary<string, List<PoLineDescriptor>>();
		LocalizationHolder translation = GetTranslation(SR.KeyCultureInfo.Name);
		if (translation == null)
		{
			return dictionary;
		}
		foreach (LocalizationFile item in translation.Files.Where((LocalizationFile p) => p.Resources.Any((PoLineDescriptor r) => _003C_003Ec__DisplayClass33_0.oXlTFaQkgyJ2FRKGTmx8(_003C_003Ec__DisplayClass33_0.lvdAJnQkrDGuLdriSb5G(r), CS_0024_003C_003E8__locals0.t, StringComparison.Ordinal))).ToList())
		{
			List<PoLineDescriptor> value = (from r in item.Resources
				where _003C_003Ec__DisplayClass33_0.oXlTFaQkgyJ2FRKGTmx8(_003C_003Ec__DisplayClass33_0.lvdAJnQkrDGuLdriSb5G(r), CS_0024_003C_003E8__locals0.t, StringComparison.Ordinal)
				select ClassSerializationHelper.CloneObject(r)).ToList();
			dictionary.Add(item.Name, value);
		}
		return dictionary;
	}

	public List<LocalizationOperation> GetTopOperations(int count)
	{
		List<LocalizationOperation> list = new List<LocalizationOperation>();
		for (int i = 0; i < count; i++)
		{
			if (_localizationOperations.LockTryDequeue(out var result))
			{
				list.Add(result);
			}
		}
		return list;
	}

	public void SaveChanges(LocalizationFile file)
	{
		int num = 2;
		int num2 = num;
		string dir = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				dir = (string)UdE5i0BAaIG6A8XDYqqt(_translationsPath, SRK58YBApWHZ06pj2bri(file));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				file.SaveToFile(dir);
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

	public void MergeFiles(string locId)
	{
		int num = 3;
		int num2 = num;
		LocalizationHolder localizationHolder = default(LocalizationHolder);
		string translationDir = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				localizationHolder = LoadHolder(translationDir);
				num2 = 4;
				break;
			case 0:
				return;
			case 4:
				if (localizationHolder != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 5;
			case 3:
			{
				object sourcePath = bqFY6YBA1qvu8lc1Yj3f(locId);
				translationDir = GetTranslationDir(locId);
				PoMerge.Merge((string)sourcePath, translationDir, doBackup: false);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
				{
					num2 = 1;
				}
				break;
			}
			case 5:
				_mergeLocales[locId] = false;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				_localizations.TryAdd((string)KOknoJBADrn9Kv5em4dO(localizationHolder), localizationHolder);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
				{
					num2 = 5;
				}
				break;
			}
		}
	}

	public List<CultureInfo> GetTargets()
	{
		return (from l in _localizations
			where !l.Key.Equals(SR.KeyCultureInfo.Name, StringComparison.OrdinalIgnoreCase)
			select new CultureInfo(l.Key)).ToList();
	}

	public void CreateLocal(string id, string baseLocal)
	{
		//Discarded unreachable code: IL_0185, IL_028e, IL_029d, IL_02c0, IL_0389, IL_0449, IL_047c, IL_048b, IL_0553, IL_058b, IL_059a
		int num = 1;
		int num2 = num;
		bool lockTaken = default(bool);
		object translateChangeSinch = default(object);
		int num4 = default(int);
		string[] array = default(string[]);
		string text2 = default(string);
		LocalizationHolder localizationHolder = default(LocalizationHolder);
		string text5 = default(string);
		string text7 = default(string);
		string fileName = default(string);
		string text3 = default(string);
		string text = default(string);
		string text4 = default(string);
		string text6 = default(string);
		string text8 = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				lockTaken = false;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				translateChangeSinch = _translateChangeSinch;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				try
				{
					Monitor.Enter(translateChangeSinch, ref lockTaken);
					int num3 = 8;
					while (true)
					{
						int num5;
						switch (num3)
						{
						case 13:
						case 34:
							if (num4 < array.Length)
							{
								num3 = 13;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
								{
									num3 = 17;
								}
								break;
							}
							goto default;
						case 33:
							if (btQPq9BAtHyKdLdDWWMW(text2))
							{
								num3 = 11;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
								{
									num3 = 2;
								}
								break;
							}
							goto case 4;
						default:
							localizationHolder = LoadHolder(text2);
							num3 = 35;
							break;
						case 30:
							if (!string.IsNullOrEmpty(baseLocal))
							{
								num3 = 19;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
								{
									num3 = 14;
								}
								break;
							}
							goto case 12;
						case 20:
							text5 = text7;
							num5 = 12;
							goto IL_007f;
						case 15:
							if (fileName != null)
							{
								num3 = 32;
								break;
							}
							goto case 26;
						case 3:
							_localizations.TryAdd((string)KOknoJBADrn9Kv5em4dO(localizationHolder), localizationHolder);
							num3 = 31;
							break;
						case 21:
							text3 = array[num4];
							num3 = 24;
							break;
						case 19:
							text7 = (string)UdE5i0BAaIG6A8XDYqqt(_translationsPath, baseLocal);
							num3 = 14;
							break;
						case 22:
							if (text != null)
							{
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
								{
									num3 = 1;
								}
								break;
							}
							goto case 23;
						case 26:
							num4++;
							num5 = 7;
							goto IL_007f;
						case 16:
							num4 = 0;
							num3 = 13;
							break;
						case 8:
							text2 = (string)UdE5i0BAaIG6A8XDYqqt(_translationsPath, id);
							num3 = 33;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
							{
								num3 = 4;
							}
							break;
						case 24:
							fileName = Path.GetFileName(text3);
							num3 = 15;
							break;
						case 11:
							return;
						case 4:
							Directory.CreateDirectory(text2);
							num3 = 6;
							break;
						case 32:
							text4 = (string)UdE5i0BAaIG6A8XDYqqt(text2, fileName);
							num3 = 27;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
							{
								num3 = 13;
							}
							break;
						case 6:
							text5 = (string)UdE5i0BAaIG6A8XDYqqt(_translationsPath, FQS7aDBAvN4WrUlFWP7J(0x6DC147B0 ^ 0x6DC01DE8));
							num3 = 30;
							break;
						case 14:
							if (!btQPq9BAtHyKdLdDWWMW(text7))
							{
								num3 = 28;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
								{
									num3 = 24;
								}
								break;
							}
							goto case 2;
						case 9:
							num4 = 0;
							num3 = 4;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
							{
								num3 = 5;
							}
							break;
						case 18:
							EWloxABA71Yg1Q03EiuH(text6, text8);
							num3 = 23;
							break;
						case 1:
							text8 = (string)UdE5i0BAaIG6A8XDYqqt(text2, text);
							num3 = 18;
							break;
						case 5:
						case 7:
							if (num4 >= array.Length)
							{
								num3 = 25;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
								{
									num3 = 8;
								}
								break;
							}
							goto case 21;
						case 23:
							num4++;
							num3 = 34;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
							{
								num3 = 19;
							}
							break;
						case 25:
							array = (string[])VnIZYNBAHtWblDQILung(text5);
							num3 = 16;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
							{
								num3 = 5;
							}
							break;
						case 29:
							text = (string)nH6fJ1BAA4Tn3Pamd7Fj(text6);
							num3 = 22;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
							{
								num3 = 1;
							}
							break;
						case 10:
						case 17:
							text6 = array[num4];
							num3 = 29;
							break;
						case 27:
							dughAMBA6SNolweMiD8E(text3, text4, true);
							num3 = 26;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
							{
								num3 = 17;
							}
							break;
						case 35:
							if (localizationHolder != null)
							{
								num3 = 3;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
								{
									num3 = 2;
								}
								break;
							}
							return;
						case 12:
						case 28:
						case 36:
							array = (string[])kuO8KpBA49hUtHJ99TDT(text5);
							num3 = 9;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
							{
								num3 = 3;
							}
							break;
						case 2:
							if (!((IEnumerable<string>)PVMpOQBAwKCAPKwM5IRj(text7, FQS7aDBAvN4WrUlFWP7J(0x7E6E5A0B ^ 0x7E6E444B))).Any(delegate(string f)
							{
								int num7 = 1;
								int num8 = num7;
								string text9 = default(string);
								while (true)
								{
									switch (num8)
									{
									case 2:
										return false;
									default:
										if (!_003C_003Ec.GWPSV5QksueR595TmxLs(text9))
										{
											return _003C_003Ec.aS8y05QkzxIDP3Tw96IP(text9, _003C_003Ec.xigfBdQkcjfIfY4WpHNg(0x7E6E5A0B ^ 0x7E6F013B), StringComparison.OrdinalIgnoreCase);
										}
										num8 = 2;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
										{
											num8 = 0;
										}
										break;
									case 1:
										text9 = (string)_003C_003Ec.jFI51XQkUWj2fc9C1wMs(f);
										num8 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
										{
											num8 = 0;
										}
										break;
									}
								}
							}))
							{
								num3 = 36;
								break;
							}
							goto case 20;
						case 31:
							return;
							IL_007f:
							num3 = num5;
							break;
						}
					}
				}
				finally
				{
					if (lockTaken)
					{
						int num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
						{
							num6 = 1;
						}
						while (true)
						{
							switch (num6)
							{
							case 1:
								VXp0KXBASUuQGNvllZsX(translateChangeSinch);
								num6 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
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
				return;
			}
		}
	}

	public Guid PrepareDownload(string id)
	{
		//Discarded unreachable code: IL_00d4, IL_00e3
		int num = 2;
		int num2 = num;
		Guid guid = default(Guid);
		PrepareOperationDescription value = default(PrepareOperationDescription);
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (!_prepareOperations.TryAdd(guid, value))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
					{
						num2 = 4;
					}
					break;
				}
				goto default;
			case 1:
			{
				PrepareOperationDescription prepareOperationDescription = new PrepareOperationDescription();
				sBGmqQBA04qqUyvc5ouQ(prepareOperationDescription, id);
				value = prepareOperationDescription;
				num2 = 3;
				break;
			}
			case 2:
				guid = hEr8nSBAxvoovAgRZxiu();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
				{
					num2 = 1;
				}
				break;
			default:
				ThreadStarter.QueueThread(DoPrepare, guid);
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				return guid;
			case 4:
				return Guid.Empty;
			}
		}
	}

	public PrepareOperationDescription GetPrepareOperationDescription(Guid operationGuid)
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 1;
		int num2 = num;
		PrepareOperationDescription value = default(PrepareOperationDescription);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!_prepareOperations.TryGetValue(operationGuid, out value))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				return value;
			default:
				return null;
			}
		}
	}

	public virtual void DoUpload(string locId, BinaryFile file)
	{
		//Discarded unreachable code: IL_0149, IL_0181, IL_01b9, IL_01c8, IL_01d8, IL_026b, IL_0318, IL_0350
		int num = 8;
		string text2 = default(string);
		object translateChangeSinch = default(object);
		Stream content = default(Stream);
		bool lockTaken = default(bool);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					ProcessTranslateChange();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
					{
						num2 = 1;
					}
					break;
				case 10:
					Vp4lYHBAJcwBuWX9JCIF(text2);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
					{
						num2 = 0;
					}
					break;
				case 11:
					throw new Exception((string)FQS7aDBAvN4WrUlFWP7J(0x53CACA3 ^ 0x53DF65D));
				case 8:
					if (!HasMergingOperation(locId))
					{
						goto end_IL_0012;
					}
					goto case 12;
				case 9:
					if (c07GmQBAdooXtbYnrPR6(this, text2))
					{
						translateChangeSinch = _translateChangeSinch;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
						{
							num2 = 3;
						}
					}
					else
					{
						num2 = 11;
					}
					break;
				default:
					content = file.GetContent();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
					{
						num2 = 2;
					}
					break;
				case 2:
					try
					{
						iqvIrhBA9kEJSJCWEUTq(zipStreamService, content, text2);
						int num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
						{
							num5 = 0;
						}
						switch (num5)
						{
						case 0:
							break;
						}
					}
					finally
					{
						if (content != null)
						{
							int num6 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
							{
								num6 = 0;
							}
							while (true)
							{
								switch (num6)
								{
								default:
									YFfa75BAVm4swBHtrXIq(content);
									num6 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
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
					goto case 9;
				case 6:
					if (!btQPq9BAtHyKdLdDWWMW(text2))
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
						{
							num2 = 10;
						}
						break;
					}
					goto default;
				case 3:
					lockTaken = false;
					num2 = 4;
					break;
				case 12:
					throw new Exception((string)tBJCj6BAmTRPs2raljWE(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-542721635 ^ -542645255), locId));
				case 7:
					text2 = (string)gy1ew0BAMrW0QqZemX7J(ysqNqUBAy8ncrpONy5hJ(), FQS7aDBAvN4WrUlFWP7J(0x53CACA3 ^ 0x53DF651));
					num2 = 6;
					break;
				case 4:
					try
					{
						Monitor.Enter(translateChangeSinch, ref lockTaken);
						int num3 = 3;
						while (true)
						{
							switch (num3)
							{
							case 1:
								FileUtils.CopyDirectory(text2, text);
								num3 = 2;
								continue;
							case 2:
								_localizations[locId] = LoadHolder(text);
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
								{
									num3 = 0;
								}
								continue;
							case 3:
								text = (string)UdE5i0BAaIG6A8XDYqqt(_translationsPath, locId);
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
								{
									num3 = 1;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
					finally
					{
						if (lockTaken)
						{
							int num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
							{
								num4 = 0;
							}
							while (true)
							{
								switch (num4)
								{
								default:
									Monitor.Exit(translateChangeSinch);
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
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
					goto case 5;
				case 1:
					return;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 7;
		}
	}

	public virtual bool ValidateTranslation(string path)
	{
		return IUA2ORBAlAMEmGk35HJU(Path.Combine(path, (string)FQS7aDBAvN4WrUlFWP7J(-420743386 ^ -420828138)));
	}

	public virtual void PublishTranslate(string id)
	{
		//Discarded unreachable code: IL_0082, IL_011b, IL_0152, IL_01ae, IL_01e6, IL_01f5
		int num = 4;
		int num2 = num;
		object translateChangeSinch = default(object);
		bool lockTaken = default(bool);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				throw new Exception((string)tBJCj6BAmTRPs2raljWE(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -105145160), id));
			case 1:
				try
				{
					Monitor.Enter(translateChangeSinch, ref lockTaken);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						default:
							SR.WatcherDisable = true;
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
							{
								num3 = 0;
							}
							break;
						case 1:
							try
							{
								string translationDir = GetTranslationDir(id);
								if (!Directory.Exists(translationDir))
								{
									throw new Exception((string)tBJCj6BAmTRPs2raljWE(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6DC147B0 ^ 0x6DC01C5A), id));
								}
								string dst = (string)bqFY6YBA1qvu8lc1Yj3f(id);
								FileUtils.CopyDirectory(translationDir, dst);
								int num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
								{
									num4 = 0;
								}
								switch (num4)
								{
								case 0:
									break;
								}
								return;
							}
							finally
							{
								SR.WatcherDisable = false;
								int num5 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
								{
									num5 = 0;
								}
								while (true)
								{
									switch (num5)
									{
									case 1:
										fCiwpOBAraivZPBbITlH(SR.Dir);
										num5 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
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
					}
				}
				finally
				{
					if (lockTaken)
					{
						int num6 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
						{
							num6 = 1;
						}
						while (true)
						{
							switch (num6)
							{
							case 1:
								Monitor.Exit(translateChangeSinch);
								num6 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
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
			case 0:
				return;
			case 2:
				lockTaken = false;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				if (!HasMergingOperation(id))
				{
					translateChangeSinch = _translateChangeSinch;
					num2 = 2;
				}
				else
				{
					num2 = 3;
				}
				break;
			}
		}
	}

	protected virtual void DoPrepare(object operationId)
	{
		//Discarded unreachable code: IL_01f8, IL_028d, IL_029c, IL_043a, IL_04a7, IL_0572, IL_0605, IL_0614, IL_0649, IL_0658, IL_0668, IL_0678, IL_0687, IL_0692, IL_0724, IL_0737, IL_09c5, IL_09d4, IL_0a6f, IL_0b03, IL_0b12
		int num = 4;
		int num2 = num;
		Guid key = default(Guid);
		_003C_003Ec__DisplayClass44_0 _003C_003Ec__DisplayClass44_ = default(_003C_003Ec__DisplayClass44_0);
		string text3 = default(string);
		string fileName2 = default(string);
		string fileName = default(string);
		string text10 = default(string);
		int num4 = default(int);
		string text6 = default(string);
		string[] array = default(string[]);
		string text11 = default(string);
		string text = default(string);
		string text7 = default(string);
		string dst = default(string);
		Dictionary<string, string> dictionary = default(Dictionary<string, string>);
		string key2 = default(string);
		string text5 = default(string);
		string text2 = default(string);
		List<string> list = default(List<string>);
		string text9 = default(string);
		List<string>.Enumerator enumerator = default(List<string>.Enumerator);
		string text8 = default(string);
		string text4 = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				return;
			case 2:
				if (!_prepareOperations.TryGetValue(key, out _003C_003Ec__DisplayClass44_.operation))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 5;
				}
				break;
			case 3:
				key = (Guid)operationId;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
				{
					num2 = 2;
				}
				break;
			case 5:
				try
				{
					LocalizationHolder localizationHolder = _localizations[(string)nJpacEBAg1WmS5RFqEiL(_003C_003Ec__DisplayClass44_.operation)];
					int num3 = 60;
					while (true)
					{
						int num5;
						switch (num3)
						{
						case 12:
							return;
						case 38:
							UbXaRDBAsU4ydOWFeLsV(wPK1CZBAUBhmsUkg3W82(localizationHolder), UdE5i0BAaIG6A8XDYqqt(text3, FQS7aDBAvN4WrUlFWP7J(0x1C9495B4 ^ 0x1C95C940)));
							num3 = 63;
							break;
						case 14:
							Vp4lYHBAJcwBuWX9JCIF(text3);
							num3 = 10;
							break;
						case 44:
							if (fileName2 == null)
							{
								num3 = 64;
								break;
							}
							goto case 3;
						case 2:
							fileName = Path.GetFileName(text10);
							num3 = 13;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
							{
								num3 = 8;
							}
							break;
						case 29:
						case 41:
							d0AdI7BAjknJdXnm01y6(_003C_003Ec__DisplayClass44_.operation, FQS7aDBAvN4WrUlFWP7J(-672123589 ^ -672044775));
							num3 = 18;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
							{
								num3 = 9;
							}
							break;
						case 46:
						case 64:
							num4++;
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
							{
								num3 = 6;
							}
							break;
						case 25:
							num4 = 0;
							num3 = 15;
							break;
						case 52:
							num4 = 0;
							num3 = 61;
							break;
						case 18:
							text3 = Path.Combine(text6, (string)KOknoJBADrn9Kv5em4dO(localizationHolder));
							num3 = 11;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
							{
								num3 = 10;
							}
							break;
						case 57:
							upNRhbBAc09B3VBZ4vTm(_003C_003Ec__DisplayClass44_.operation, PrepareLocalizationStatus.Completed);
							num3 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
							{
								num3 = 12;
							}
							break;
						case 7:
							text6 = (string)paXoRXBA5L6nD76tGRiA(FQS7aDBAvN4WrUlFWP7J(-3333094 ^ -3316200), IOExtensions.GetTempFileName(), localizationHolder.Name);
							num3 = 48;
							break;
						case 27:
							array = Directory.GetDirectories(text11);
							num3 = 52;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
							{
								num3 = 1;
							}
							break;
						case 48:
							if (Directory.Exists(text6))
							{
								num3 = 29;
								break;
							}
							goto case 56;
						case 31:
							fileName2 = Path.GetFileName(text);
							num3 = 44;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
							{
								num3 = 4;
							}
							break;
						case 11:
							if (btQPq9BAtHyKdLdDWWMW(text3))
							{
								num3 = 47;
								break;
							}
							goto case 14;
						case 56:
							Vp4lYHBAJcwBuWX9JCIF(text6);
							num3 = 14;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
							{
								num3 = 41;
							}
							break;
						case 63:
							_003C_003Ec__DisplayClass44_.operation.CurrentMessage = (string)FQS7aDBAvN4WrUlFWP7J(0x20261A4F ^ 0x20274747);
							num3 = 20;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
							{
								num3 = 42;
							}
							break;
						case 49:
							Locator.GetServiceNotNull<IZipService>().CreateZipFolder(text7, text3);
							num3 = 33;
							break;
						case 51:
							text7 = (string)UdE5i0BAaIG6A8XDYqqt(text6, tBJCj6BAmTRPs2raljWE(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7459E02 ^ 0x744C368), _003C_003Ec__DisplayClass44_.operation.LocalId));
							num3 = 49;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
							{
								num3 = 48;
							}
							break;
						case 32:
							d0AdI7BAjknJdXnm01y6(_003C_003Ec__DisplayClass44_.operation, FQS7aDBAvN4WrUlFWP7J(-1088304168 ^ -1088383060));
							num3 = 5;
							break;
						case 4:
							dst = (string)UdE5i0BAaIG6A8XDYqqt(text3, fileName);
							num3 = 43;
							break;
						case 60:
							text11 = (string)UdE5i0BAaIG6A8XDYqqt(_translationsPath, localizationHolder.Name);
							num3 = 7;
							break;
						case 50:
						case 54:
							text = array[num4];
							num3 = 31;
							break;
						case 19:
							dictionary[key2] = text5;
							num3 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
							{
								num3 = 35;
							}
							break;
						case 15:
						case 22:
							if (num4 >= array.Length)
							{
								num3 = 32;
								break;
							}
							goto case 24;
						case 9:
							dictionary.Add(text2, string.Empty);
							num3 = 46;
							break;
						case 55:
							list.Add(text5);
							num3 = 53;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
							{
								num3 = 42;
							}
							break;
						case 21:
							num4 = 0;
							num3 = 17;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
							{
								num3 = 14;
							}
							break;
						case 62:
							array = (string[])kuO8KpBA49hUtHJ99TDT(text11);
							num3 = 21;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
							{
								num3 = 5;
							}
							break;
						case 24:
							text9 = array[num4];
							num3 = 7;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
							{
								num3 = 59;
							}
							break;
						case 3:
							text2 = (string)UdE5i0BAaIG6A8XDYqqt(text3, fileName2);
							num3 = 5;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
							{
								num3 = 23;
							}
							break;
						case 20:
							try
							{
								while (true)
								{
									int num6;
									if (!enumerator.MoveNext())
									{
										num6 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
										{
											num6 = 0;
										}
										goto IL_0696;
									}
									goto IL_06ac;
									IL_06ac:
									File.Delete(enumerator.Current);
									num6 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
									{
										num6 = 2;
									}
									goto IL_0696;
									IL_0696:
									switch (num6)
									{
									case 1:
										goto IL_06ac;
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
								int num7 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
								{
									num7 = 0;
								}
								switch (num7)
								{
								case 0:
									break;
								}
							}
							goto case 36;
						default:
						{
							object obj = UdE5i0BAaIG6A8XDYqqt(_translationsPath, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3A6135BE ^ 0x3A606FE6));
							list = new List<string>();
							array = (string[])kuO8KpBA49hUtHJ99TDT(obj);
							num5 = 25;
							goto IL_00ae;
						}
						case 10:
						case 47:
							dictionary = new Dictionary<string, string>();
							num3 = 62;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
							{
								num3 = 31;
							}
							break;
						case 5:
							_003C_003Ec__DisplayClass44_.operation.CurrentMessage = (string)FQS7aDBAvN4WrUlFWP7J(0x42643203 ^ 0x42656EC3);
							num3 = 39;
							break;
						case 16:
						case 40:
							num4++;
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
							{
								num3 = 1;
							}
							break;
						case 26:
							if (dictionary.ContainsKey(key2))
							{
								num3 = 19;
								break;
							}
							goto case 35;
						case 53:
							num4++;
							num3 = 22;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
							{
								num3 = 8;
							}
							break;
						case 39:
							localizationHolder.RefreshStatistic();
							num5 = 38;
							goto IL_00ae;
						case 43:
							FileUtils.CopyDirectory(text10, dst);
							num3 = 40;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
							{
								num3 = 20;
							}
							break;
						case 45:
						case 58:
							text10 = array[num4];
							num3 = 2;
							break;
						case 33:
							_003C_003Ec__DisplayClass44_.operation.FileName = text7;
							num3 = 17;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
							{
								num3 = 28;
							}
							break;
						case 6:
						case 17:
							if (num4 < array.Length)
							{
								num3 = 50;
								break;
							}
							goto case 27;
						case 59:
							text8 = (string)nH6fJ1BAA4Tn3Pamd7Fj(text9);
							num5 = 30;
							goto IL_00ae;
						case 37:
							text4 = string.Format((string)FQS7aDBAvN4WrUlFWP7J(0x3A5D5EF ^ 0x3A489B7), rbyL4EBAY75lkwUDErEb(text8), oJ2MlbBAL9rtps79dMNM(text8));
							num3 = 34;
							break;
						case 28:
							_003C_003Ec__DisplayClass44_.operation.CurrentMessage = (string)FQS7aDBAvN4WrUlFWP7J(0x1FFEF86A ^ 0x1FFFA516);
							num3 = 57;
							break;
						case 35:
							dughAMBA6SNolweMiD8E(text9, text5, true);
							num3 = 55;
							break;
						case 13:
							if (fileName == null)
							{
								num5 = 16;
								goto IL_00ae;
							}
							goto case 4;
						case 42:
							enumerator = list.GetEnumerator();
							num3 = 11;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
							{
								num3 = 20;
							}
							break;
						case 36:
							_003C_003Ec__DisplayClass44_.operation.CurrentMessage = (string)FQS7aDBAvN4WrUlFWP7J(-1939377524 ^ -1939460146);
							num3 = 25;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
							{
								num3 = 51;
							}
							break;
						case 34:
							key2 = (string)UdE5i0BAaIG6A8XDYqqt(text3, text8);
							num3 = 8;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
							{
								num3 = 8;
							}
							break;
						case 30:
							if (text8 != null)
							{
								num3 = 32;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
								{
									num3 = 37;
								}
								break;
							}
							goto case 53;
						case 1:
						case 61:
							if (num4 < array.Length)
							{
								num3 = 35;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
								{
									num3 = 45;
								}
								break;
							}
							goto default;
						case 8:
							text5 = (string)UdE5i0BAaIG6A8XDYqqt(text3, text4);
							num3 = 26;
							break;
						case 23:
							{
								File.Copy(text, text2, overwrite: true);
								num3 = 9;
								break;
							}
							IL_00ae:
							num3 = num5;
							break;
						}
					}
				}
				catch (Exception ex)
				{
					int num8 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
					{
						num8 = 0;
					}
					while (true)
					{
						switch (num8)
						{
						case 2:
							return;
						case 3:
							upNRhbBAc09B3VBZ4vTm(_003C_003Ec__DisplayClass44_.operation, PrepareLocalizationStatus.Error);
							num8 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
							{
								num8 = 2;
							}
							break;
						default:
							lUujqdB7F2mv3wr9uTCF(b5igWjBAzYHR4hiL4klj(), ex.Message, ex);
							num8 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
							{
								num8 = 0;
							}
							break;
						case 1:
							_003C_003Ec__DisplayClass44_.operation.CurrentMessage = (string)dTxG1QB7B9FdKV0Kgtof(ex);
							num8 = 3;
							break;
						}
					}
				}
			case 4:
				_003C_003Ec__DisplayClass44_ = new _003C_003Ec__DisplayClass44_0();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
				{
					num2 = 3;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public List<LocalizationOperation> GetTopDownloadOperations(int count)
	{
		List<LocalizationOperation> list = new List<LocalizationOperation>();
		for (int i = 0; i < count; i++)
		{
			if (_localizationOperations.LockTryDequeue(out var result))
			{
				list.Add(result);
			}
		}
		return list;
	}

	public FileStream DownloadLocal(Guid operationGuid, out string fileName)
	{
		//Discarded unreachable code: IL_016a
		int num = 1;
		PrepareOperationDescription prepareOperationDescription = default(PrepareOperationDescription);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					throw new Exception(SR.T((string)FQS7aDBAvN4WrUlFWP7J(0x34185E55 ^ 0x341903E3)));
				default:
					if (jyGCHiB7W1X1hXrxQPXb(prepareOperationDescription) == PrepareLocalizationStatus.Completed)
					{
						if (prepareOperationDescription == null)
						{
							goto end_IL_0012;
						}
						if (IUA2ORBAlAMEmGk35HJU(kLiNtmB7oK6MZOxIRJqQ(prepareOperationDescription)))
						{
							num2 = 6;
							break;
						}
						goto case 5;
					}
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
					{
						num2 = 1;
					}
					break;
				case 4:
					throw new Exception(SR.T((string)FQS7aDBAvN4WrUlFWP7J(-1979251663 ^ -1979295195), operationGuid));
				case 2:
					return new FileStream(prepareOperationDescription.FileName, FileMode.Open, FileAccess.Read);
				case 5:
					throw new Exception(SR.T((string)FQS7aDBAvN4WrUlFWP7J(0x92F12D5 ^ 0x92E4CBB), kLiNtmB7oK6MZOxIRJqQ(prepareOperationDescription)));
				case 6:
					fileName = (string)nH6fJ1BAA4Tn3Pamd7Fj(kLiNtmB7oK6MZOxIRJqQ(prepareOperationDescription));
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					prepareOperationDescription = GetPrepareOperationDescription(operationGuid);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
					{
						num2 = 0;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 4;
		}
	}

	public string GetTranslationDir(string local)
	{
		return (string)UdE5i0BAaIG6A8XDYqqt(_translationsPath, local);
	}

	public string GetTranslationTemplateDir(string local)
	{
		return (string)UdE5i0BAaIG6A8XDYqqt(GetTranslationDir(local), FQS7aDBAvN4WrUlFWP7J(-1876063057 ^ -1876061469));
	}

	public LocalizationHash[] ComputeLocalizationHash()
	{
		//Discarded unreachable code: IL_0092, IL_00ef, IL_012f, IL_013a
		int num = 1;
		int num2 = num;
		object translateChangeSinch = default(object);
		LocalizationHash[] result = default(LocalizationHash[]);
		bool lockTaken = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 1:
				translateChangeSinch = _translateChangeSinch;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return result;
			default:
				lockTaken = false;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				try
				{
					Monitor.Enter(translateChangeSinch, ref lockTaken);
					int num3 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
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
							result = (LocalizationHash[])KFLnNFB7brZuK7VtKB1n();
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
							{
								num3 = 0;
							}
							break;
						}
					}
				}
				finally
				{
					int num4;
					if (!lockTaken)
					{
						num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
						{
							num4 = 0;
						}
						goto IL_00f3;
					}
					goto IL_0109;
					IL_0109:
					VXp0KXBASUuQGNvllZsX(translateChangeSinch);
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
					{
						num4 = 0;
					}
					goto IL_00f3;
					IL_00f3:
					switch (num4)
					{
					default:
						goto end_IL_00ce;
					case 2:
						break;
					case 1:
						goto end_IL_00ce;
					case 0:
						goto end_IL_00ce;
					}
					goto IL_0109;
					end_IL_00ce:;
				}
			}
		}
	}

	private LocalizationHolder LoadHolder(string folder)
	{
		//Discarded unreachable code: IL_0116, IL_0125, IL_01de, IL_0260, IL_02af, IL_0357, IL_0376, IL_03a2, IL_03fa
		int num = 14;
		string text2 = default(string);
		int num3 = default(int);
		string text = default(string);
		string[] array = default(string[]);
		LocalizationHolder localizationHolder = default(LocalizationHolder);
		TemplateDescription item = default(TemplateDescription);
		string path = default(string);
		string text3 = default(string);
		string text4 = default(string);
		StreamReader streamReader = default(StreamReader);
		LocalizationFile item2 = default(LocalizationFile);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 15:
					text2 = (string)UdE5i0BAaIG6A8XDYqqt(folder, FQS7aDBAvN4WrUlFWP7J(-867826612 ^ -867821056));
					num2 = 4;
					continue;
				case 22:
					num3 = 0;
					num2 = 16;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
					{
						num2 = 8;
					}
					continue;
				case 14:
					text = Path.GetFileName(folder);
					num2 = 13;
					continue;
				case 19:
					array = (string[])kuO8KpBA49hUtHJ99TDT(text2);
					num2 = 17;
					continue;
				case 13:
					if (text == null)
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
						{
							num2 = 20;
						}
						continue;
					}
					if (text.Equals(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5DD55050 ^ 0x5DD40A08), StringComparison.OrdinalIgnoreCase))
					{
						num2 = 18;
						continue;
					}
					goto case 15;
				case 10:
				case 11:
					if (num3 < array.Length)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 5;
				default:
					num3++;
					num2 = 11;
					continue;
				case 17:
					num3 = 0;
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
					{
						num2 = 10;
					}
					continue;
				case 4:
					localizationHolder = new LocalizationHolder
					{
						Name = text
					};
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
					{
						num2 = 3;
					}
					continue;
				case 7:
					item = new TemplateDescription
					{
						Name = Path.GetFileName(path)
					};
					num2 = 26;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
					{
						num2 = 7;
					}
					continue;
				case 25:
					num3++;
					num2 = 24;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
					{
						num2 = 13;
					}
					continue;
				case 23:
					text3 = (string)nH6fJ1BAA4Tn3Pamd7Fj(text4);
					num2 = 21;
					continue;
				case 3:
					array = (string[])PVMpOQBAwKCAPKwM5IRj(folder, FQS7aDBAvN4WrUlFWP7J(0x8317432 ^ 0x8316A72));
					num2 = 22;
					continue;
				case 8:
					streamReader = new StreamReader(text4, (Encoding)xXiQ19B7G9dNOy4ityj4());
					num2 = 6;
					continue;
				case 21:
					if (text3 != null)
					{
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto case 25;
				case 6:
					try
					{
						Tuple<List<string>, List<PoLineDescriptor>> tuple = PoParser.Parse(streamReader);
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
						{
							num4 = 1;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								localizationHolder.Files.Add(item2);
								num4 = 2;
								continue;
							case 1:
								item2 = new LocalizationFile
								{
									Name = text3,
									LocalizationName = text,
									Header = tuple.Item1,
									Resources = new ConcurrentBag<PoLineDescriptor>(tuple.Item2)
								};
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
								{
									num4 = 0;
								}
								continue;
							case 2:
								break;
							}
							break;
						}
					}
					finally
					{
						int num5;
						if (streamReader == null)
						{
							num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
							{
								num5 = 0;
							}
							goto IL_035b;
						}
						goto IL_0380;
						IL_0380:
						YFfa75BAVm4swBHtrXIq(streamReader);
						num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
						{
							num5 = 1;
						}
						goto IL_035b;
						IL_035b:
						switch (num5)
						{
						default:
							goto end_IL_0336;
						case 0:
							goto end_IL_0336;
						case 2:
							break;
						case 1:
							goto end_IL_0336;
						}
						goto IL_0380;
						end_IL_0336:;
					}
					goto case 25;
				case 1:
				case 12:
					path = array[num3];
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
					{
						num2 = 7;
					}
					continue;
				case 26:
					localizationHolder.Templates.Add(item);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
					{
						num2 = 0;
					}
					continue;
				case 16:
				case 24:
					if (num3 < array.Length)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 9;
				case 9:
					if (Directory.Exists(text2))
					{
						num2 = 19;
						continue;
					}
					goto case 5;
				case 2:
				case 27:
					break;
				case 5:
					return localizationHolder;
				case 18:
					text = (string)lB8aEqBARygdkLy8VkYv(k8KnZcB7hcmfwqnr1ku2());
					num2 = 15;
					continue;
				case 20:
					return null;
				}
				break;
			}
			text4 = array[num3];
			num = 23;
		}
	}

	private void DoInit()
	{
		//Discarded unreachable code: IL_0093, IL_00c8, IL_0165, IL_0174, IL_0262, IL_0271, IL_0280, IL_02a5
		int num = 17;
		string folder = default(string);
		string[] array = default(string[]);
		int num3 = default(int);
		LocalizationHolder localizationHolder = default(LocalizationHolder);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					Directory.CreateDirectory(_translationsPath);
					num2 = 13;
					continue;
				case 17:
					if (RuntimeApplication == null)
					{
						num2 = 16;
						continue;
					}
					break;
				case 8:
				case 19:
					folder = array[num3];
					num2 = 4;
					continue;
				case 2:
				case 21:
					num3++;
					num2 = 10;
					continue;
				case 4:
					localizationHolder = LoadHolder(folder);
					num2 = 3;
					continue;
				case 14:
					num3 = 0;
					num2 = 11;
					continue;
				case 15:
					return;
				case 12:
					if (Directory.Exists(_translationsPath))
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
						{
							num2 = 20;
						}
						continue;
					}
					goto default;
				case 7:
					_inited = true;
					num2 = 15;
					continue;
				case 3:
					if (localizationHolder == null)
					{
						num2 = 21;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
						{
							num2 = 13;
						}
						continue;
					}
					goto case 9;
				case 16:
					return;
				case 22:
					return;
				case 1:
					goto end_IL_0012;
				case 13:
				case 20:
					SinhWebResources(_translationsPath);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
					{
						num2 = 6;
					}
					continue;
				case 6:
					array = (string[])VnIZYNBAHtWblDQILung(_translationsPath);
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
					{
						num2 = 14;
					}
					continue;
				case 9:
					_localizations.TryAdd(localizationHolder.Name, localizationHolder);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
					{
						num2 = 0;
					}
					continue;
				case 18:
					_translationsPath = (string)UdE5i0BAaIG6A8XDYqqt(text, FQS7aDBAvN4WrUlFWP7J(0x7EC153F ^ 0x7ED4BFD));
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
					{
						num2 = 8;
					}
					continue;
				case 10:
				case 11:
					if (num3 < array.Length)
					{
						num2 = 19;
						continue;
					}
					goto case 7;
				case 5:
					break;
				}
				if (nqlTTqB7EroSrt7seXhQ(RuntimeApplication) == null)
				{
					return;
				}
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
				{
					num2 = 0;
				}
				continue;
				end_IL_0012:
				break;
			}
			text = (string)FP0o0CB7CCdHjKMycX0r(rEWT3SB7Q46dLAKlmNvP(U6lPgWB7fcGcCpVVUL94(nqlTTqB7EroSrt7seXhQ(RuntimeApplication))));
			num = 18;
		}
	}

	private void SinhWebResources(string translationsPath)
	{
		//Discarded unreachable code: IL_010c, IL_011b, IL_012a, IL_014a, IL_01fd, IL_020c, IL_0282, IL_0291, IL_036b, IL_039f, IL_03ae, IL_03be, IL_04c8, IL_0556, IL_0565, IL_05eb
		int num = 28;
		string fileName = default(string);
		string text6 = default(string);
		int num3 = default(int);
		string[] array = default(string[]);
		string text7 = default(string);
		string text10 = default(string);
		int num4 = default(int);
		string text8 = default(string);
		string[] array2 = default(string[]);
		string text = default(string);
		string text4 = default(string);
		string text2 = default(string);
		string text5 = default(string);
		string text9 = default(string);
		string text3 = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 29:
					fileName = Path.GetFileName(text6);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
					{
						num2 = 0;
					}
					continue;
				case 26:
				case 38:
					num3++;
					num2 = 17;
					continue;
				case 22:
				case 34:
					array = (string[])PVMpOQBAwKCAPKwM5IRj(text6, FQS7aDBAvN4WrUlFWP7J(-1870892489 ^ -1870893961));
					num2 = 23;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
					{
						num2 = 4;
					}
					continue;
				case 46:
					if (!c5WRyxBAqZMHTQ2adwPt(fileName, FQS7aDBAvN4WrUlFWP7J(-1767720453 ^ -1767644253), StringComparison.OrdinalIgnoreCase))
					{
						num2 = 22;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
						{
							num2 = 26;
						}
						continue;
					}
					goto case 16;
				case 5:
					Vp4lYHBAJcwBuWX9JCIF(text7);
					num2 = 9;
					continue;
				case 36:
					if (text10 != null)
					{
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
						{
							num2 = 12;
						}
						continue;
					}
					goto case 7;
				case 27:
					num4 = 0;
					num2 = 19;
					continue;
				case 45:
					if (!btQPq9BAtHyKdLdDWWMW(text7))
					{
						num2 = 5;
						continue;
					}
					goto case 9;
				case 7:
				case 44:
					num3++;
					num2 = 43;
					continue;
				case 41:
					text8 = Path.Combine(text6, (string)FQS7aDBAvN4WrUlFWP7J(-867826612 ^ -867821056));
					num2 = 47;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
					{
						num2 = 8;
					}
					continue;
				case 3:
				case 35:
					text6 = array2[num4];
					num2 = 29;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
					{
						num2 = 22;
					}
					continue;
				default:
					if (fileName == null)
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 40;
				case 16:
				case 32:
					dughAMBA6SNolweMiD8E(text, text4, true);
					num2 = 24;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
					{
						num2 = 38;
					}
					continue;
				case 4:
				case 21:
				case 39:
					num4++;
					num = 24;
					break;
				case 1:
					text2 = (string)nH6fJ1BAA4Tn3Pamd7Fj(text);
					num2 = 49;
					continue;
				case 31:
					if (btQPq9BAtHyKdLdDWWMW(text5))
					{
						num = 34;
						break;
					}
					goto case 42;
				case 9:
					array = Directory.GetFiles(text8);
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
					{
						num2 = 11;
					}
					continue;
				case 14:
					text4 = (string)UdE5i0BAaIG6A8XDYqqt(text7, text2);
					num2 = 30;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
					{
						num2 = 29;
					}
					continue;
				case 10:
					text9 = array[num3];
					num2 = 6;
					continue;
				case 12:
					text3 = (string)UdE5i0BAaIG6A8XDYqqt(text5, text10);
					num2 = 25;
					continue;
				case 18:
					if (!c5WRyxBAqZMHTQ2adwPt(fileName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6DC147B0 ^ 0x6DC01DE8), StringComparison.OrdinalIgnoreCase))
					{
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto case 8;
				case 37:
				case 43:
					if (num3 >= array.Length)
					{
						num2 = 34;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
						{
							num2 = 41;
						}
						continue;
					}
					goto case 10;
				case 6:
					text10 = (string)nH6fJ1BAA4Tn3Pamd7Fj(text9);
					num2 = 36;
					continue;
				case 11:
					num3 = 0;
					num2 = 2;
					continue;
				case 47:
					if (!btQPq9BAtHyKdLdDWWMW(text8))
					{
						num2 = 13;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
						{
							num2 = 21;
						}
						continue;
					}
					goto case 15;
				case 40:
					text5 = (string)UdE5i0BAaIG6A8XDYqqt(translationsPath, fileName);
					num = 31;
					break;
				case 19:
				case 24:
					if (num4 < array2.Length)
					{
						num2 = 3;
						continue;
					}
					return;
				case 28:
					array2 = (string[])VnIZYNBAHtWblDQILung(SR.Dir);
					num2 = 27;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num2 = 3;
					}
					continue;
				case 49:
					if (text2 != null)
					{
						num2 = 14;
						continue;
					}
					goto case 26;
				case 42:
					Vp4lYHBAJcwBuWX9JCIF(text5);
					num2 = 22;
					continue;
				case 33:
				case 48:
					text = array[num3];
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
					{
						num2 = 1;
					}
					continue;
				case 2:
				case 17:
					if (num3 < array.Length)
					{
						num2 = 33;
						continue;
					}
					goto case 4;
				case 30:
					if (!IUA2ORBAlAMEmGk35HJU(text4))
					{
						num2 = 16;
						continue;
					}
					goto case 46;
				case 8:
				case 13:
					dughAMBA6SNolweMiD8E(text9, text3, true);
					num2 = 44;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
					{
						num2 = 7;
					}
					continue;
				case 15:
					text7 = (string)UdE5i0BAaIG6A8XDYqqt(text5, FQS7aDBAvN4WrUlFWP7J(0x5DD55050 ^ 0x5DD54E1C));
					num2 = 45;
					continue;
				case 25:
					if (!IUA2ORBAlAMEmGk35HJU(text3))
					{
						num2 = 8;
						continue;
					}
					goto case 18;
				case 23:
					num3 = 0;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
					{
						num2 = 37;
					}
					continue;
				case 20:
					return;
				}
				break;
			}
		}
	}

	public void CheckInit()
	{
		//Discarded unreachable code: IL_0051, IL_0060
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				DoInit();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			case 0:
				return;
			case 3:
				if (_inited)
				{
					num2 = 2;
					break;
				}
				goto case 1;
			}
		}
	}

	internal static bool zoekpEBAQVDkZht5LeFv()
	{
		return RZfUJWBAfHHNgHOuTnCH == null;
	}

	internal static TranslateService eTf9L8BACrbZJv2Khifo()
	{
		return RZfUJWBAfHHNgHOuTnCH;
	}

	internal static object FQS7aDBAvN4WrUlFWP7J(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void Ew2ZcrBA8vjxXgeBqS4x(object P_0, object P_1, object P_2)
	{
		((IAbstractBoundVariableService)P_0).Set((string)P_1, P_2);
	}

	internal static object KSeTlhBAZV8KWbppBHsH()
	{
		return ComponentManager.Current;
	}

	internal static void cwmV6mBAu5d7WgXF0tH8(object P_0)
	{
		((ITranslateChangeHandler)P_0).Execute();
	}

	internal static bool iEDjc0BAIkJ2BJAL1NTU(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void YFfa75BAVm4swBHtrXIq(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void VXp0KXBASUuQGNvllZsX(object P_0)
	{
		Monitor.Exit(P_0);
	}

	internal static bool qhsg16BAi51kY0uYLLeb(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object lB8aEqBARygdkLy8VkYv(object P_0)
	{
		return ((CultureInfo)P_0).Name;
	}

	internal static bool c5WRyxBAqZMHTQ2adwPt(object P_0, object P_1, StringComparison P_2)
	{
		return ((string)P_0).Equals((string)P_1, P_2);
	}

	internal static bool pUMixnBAKKKZF0jnnZsE(object P_0, object P_1)
	{
		return ((string)P_0).Contains((string)P_1);
	}

	internal static object tO5j3kBAXSorhq2HWfS5(object P_0, object P_1)
	{
		return ((LocalizationHolder)P_0).T((string)P_1);
	}

	internal static object TPck7OBATWxcSohW2QAN(object P_0, object P_1, object P_2, object P_3)
	{
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	internal static void Rxx9cnBAksKJ6TWSg7qt(object P_0, object P_1)
	{
		((LocalizationOperation)P_0).TranslateService = (TranslateService)P_1;
	}

	internal static void YeF4F2BAn2u9bGu9ix66(object P_0, object P_1)
	{
		((LocalizationSaveOperation)P_0).File = (LocalizationFile)P_1;
	}

	internal static int WAKfhGBAOhaKwH8gF6mI(object P_0)
	{
		return ((List<LocalizationFile>)P_0).Count;
	}

	internal static object z7T3i0BA2IAvNs54Fp5M(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static void VgxaH0BAexdlW9p5BgAu(object P_0, object P_1)
	{
		((PoLineDescriptor)P_0).Value = (string)P_1;
	}

	internal static DateTime yJZTD2BAPHnTJZa5RGQK()
	{
		return DateTime.Now;
	}

	internal static object bqFY6YBA1qvu8lc1Yj3f(object P_0)
	{
		return SR.GetCultureDir((string)P_0);
	}

	internal static bool vLOSISBAN4VRWbEdameU(object P_0, object P_1)
	{
		return ((LocalizationHash)P_0).Equals((LocalizationHash)P_1);
	}

	internal static void mxmZsIBA3RMCGRvNZr8L(object P_0, object P_1)
	{
		((LocalizationMergeOperation)P_0).LocalId = (string)P_1;
	}

	internal static object SRK58YBApWHZ06pj2bri(object P_0)
	{
		return ((LocalizationFile)P_0).LocalizationName;
	}

	internal static object UdE5i0BAaIG6A8XDYqqt(object P_0, object P_1)
	{
		return Path.Combine((string)P_0, (string)P_1);
	}

	internal static object KOknoJBADrn9Kv5em4dO(object P_0)
	{
		return ((LocalizationHolder)P_0).Name;
	}

	internal static bool btQPq9BAtHyKdLdDWWMW(object P_0)
	{
		return Directory.Exists((string)P_0);
	}

	internal static object PVMpOQBAwKCAPKwM5IRj(object P_0, object P_1)
	{
		return Directory.GetFiles((string)P_0, (string)P_1);
	}

	internal static object kuO8KpBA49hUtHJ99TDT(object P_0)
	{
		return Directory.GetFiles((string)P_0);
	}

	internal static void dughAMBA6SNolweMiD8E(object P_0, object P_1, bool P_2)
	{
		File.Copy((string)P_0, (string)P_1, P_2);
	}

	internal static object VnIZYNBAHtWblDQILung(object P_0)
	{
		return Directory.GetDirectories((string)P_0);
	}

	internal static object nH6fJ1BAA4Tn3Pamd7Fj(object P_0)
	{
		return Path.GetFileName((string)P_0);
	}

	internal static void EWloxABA71Yg1Q03EiuH(object P_0, object P_1)
	{
		FileUtils.CopyDirectory((string)P_0, (string)P_1);
	}

	internal static Guid hEr8nSBAxvoovAgRZxiu()
	{
		return Guid.NewGuid();
	}

	internal static void sBGmqQBA04qqUyvc5ouQ(object P_0, object P_1)
	{
		((PrepareOperationDescription)P_0).LocalId = (string)P_1;
	}

	internal static object tBJCj6BAmTRPs2raljWE(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static object ysqNqUBAy8ncrpONy5hJ()
	{
		return IOExtensions.GetTempFileName();
	}

	internal static object gy1ew0BAMrW0QqZemX7J(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object Vp4lYHBAJcwBuWX9JCIF(object P_0)
	{
		return Directory.CreateDirectory((string)P_0);
	}

	internal static object iqvIrhBA9kEJSJCWEUTq(object P_0, object P_1, object P_2)
	{
		return ((IZipStreamService)P_0).ExtractZipFolder((Stream)P_1, (string)P_2);
	}

	internal static bool c07GmQBAdooXtbYnrPR6(object P_0, object P_1)
	{
		return ((TranslateService)P_0).ValidateTranslation((string)P_1);
	}

	internal static bool IUA2ORBAlAMEmGk35HJU(object P_0)
	{
		return File.Exists((string)P_0);
	}

	internal static void fCiwpOBAraivZPBbITlH(object P_0)
	{
		SR.ReInitSR((string)P_0);
	}

	internal static object nJpacEBAg1WmS5RFqEiL(object P_0)
	{
		return ((PrepareOperationDescription)P_0).LocalId;
	}

	internal static object paXoRXBA5L6nD76tGRiA(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static void d0AdI7BAjknJdXnm01y6(object P_0, object P_1)
	{
		((PrepareOperationDescription)P_0).CurrentMessage = (string)P_1;
	}

	internal static object rbyL4EBAY75lkwUDErEb(object P_0)
	{
		return Path.GetFileNameWithoutExtension((string)P_0);
	}

	internal static object oJ2MlbBAL9rtps79dMNM(object P_0)
	{
		return Path.GetExtension((string)P_0);
	}

	internal static object wPK1CZBAUBhmsUkg3W82(object P_0)
	{
		return ((LocalizationHolder)P_0).Statistic;
	}

	internal static void UbXaRDBAsU4ydOWFeLsV(object P_0, object P_1)
	{
		((LocalizationStatistic)P_0).SaveToXml((string)P_1);
	}

	internal static void upNRhbBAc09B3VBZ4vTm(object P_0, PrepareLocalizationStatus value)
	{
		((PrepareOperationDescription)P_0).Status = value;
	}

	internal static object b5igWjBAzYHR4hiL4klj()
	{
		return Logger.Log;
	}

	internal static void lUujqdB7F2mv3wr9uTCF(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static object dTxG1QB7B9FdKV0Kgtof(object P_0)
	{
		return ((Exception)P_0).Message;
	}

	internal static PrepareLocalizationStatus jyGCHiB7W1X1hXrxQPXb(object P_0)
	{
		return ((PrepareOperationDescription)P_0).Status;
	}

	internal static object kLiNtmB7oK6MZOxIRJqQ(object P_0)
	{
		return ((PrepareOperationDescription)P_0).FileName;
	}

	internal static object KFLnNFB7brZuK7VtKB1n()
	{
		return SR.ComputeLocalizationHash();
	}

	internal static object k8KnZcB7hcmfwqnr1ku2()
	{
		return SR.KeyCultureInfo;
	}

	internal static object xXiQ19B7G9dNOy4ityj4()
	{
		return Encoding.UTF8;
	}

	internal static object nqlTTqB7EroSrt7seXhQ(object P_0)
	{
		return ((IRuntimeApplication)P_0).Configuration;
	}

	internal static object U6lPgWB7fcGcCpVVUL94(object P_0)
	{
		return ((RuntimeConfiguration)P_0).Config;
	}

	internal static object rEWT3SB7Q46dLAKlmNvP(object P_0)
	{
		return ((System.Configuration.Configuration)P_0).FilePath;
	}

	internal static object FP0o0CB7CCdHjKMycX0r(object P_0)
	{
		return Path.GetDirectoryName((string)P_0);
	}
}
