using System;
using System.IO;
using EleWise.ELMA.Logging;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Licensing.Storages;

public class InstallationIdFileStorage : IInstallationIdStorage
{
	private string _path;

	private bool _canRead;

	private bool _canWrite;

	private static InstallationIdFileStorage RKQy4fxAGbWlq2MkJIV;

	public bool CanRead => _canRead;

	public bool CanWrite => _canWrite;

	public InstallationIdFileStorage(string path)
	{
		//Discarded unreachable code: IL_002a, IL_002f, IL_00ca, IL_018c, IL_01e9, IL_01f8, IL_0225, IL_0258, IL_02b5, IL_02c4, IL_0333, IL_0366, IL_03c3, IL_03d2
		LP6kgPx0dVT0bQUCTdR();
		base._002Ector();
		int num = 3;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
		{
			num = 4;
		}
		string text = default(string);
		while (true)
		{
			switch (num)
			{
			case 5:
				return;
			case 4:
				if (!wyKAPfxmNVw5OMGwIIa(path))
				{
					_path = path;
					num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
					{
						num = 1;
					}
				}
				else
				{
					num = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
					{
						num = 2;
					}
				}
				continue;
			default:
				try
				{
					Guid guid = Cs16jFxl2i2tLgRNr9x();
					int num6 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
					{
						num6 = 1;
					}
					while (true)
					{
						switch (num6)
						{
						case 1:
							text = guid.ToString();
							num6 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
							{
								num6 = 0;
							}
							break;
						case 2:
							_canWrite = true;
							num6 = 3;
							break;
						default:
						{
							object obj = nt6eF1xrJnsagrXDH6o(path, jAfVi1xJEFv610O4hMj(text, M1LVXdxMeCetuN1k9UA(0x4EDCBA32 ^ 0x4EDC26D2)));
							VeXeqFxgp99glMNbp5a(obj, M1LVXdxMeCetuN1k9UA(-16752921 ^ -16760469));
							wSskbPx5gyvIDTGH4IW(obj);
							num6 = 2;
							break;
						}
						case 3:
							return;
						}
					}
				}
				catch (Exception ex3)
				{
					int num7 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
					{
						num7 = 0;
					}
					while (true)
					{
						switch (num7)
						{
						case 1:
							return;
						}
						hbH3xJx9XFVI2t3K30o(u4cRF2xyWDvExR7FkYM(), (string)M1LVXdxMeCetuN1k9UA(-1108654032 ^ -1108618020) + path, ex3);
						num7 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
						{
							num7 = 1;
						}
					}
				}
			case 7:
				try
				{
					BLjX6rxd4xjtUGqpUq9(path);
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				catch (Exception ex2)
				{
					int num5 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
					{
						num5 = 1;
					}
					while (true)
					{
						switch (num5)
						{
						default:
							return;
						case 1:
							hbH3xJx9XFVI2t3K30o(u4cRF2xyWDvExR7FkYM(), jAfVi1xJEFv610O4hMj(M1LVXdxMeCetuN1k9UA(-1123633026 ^ -1123670810), path), ex2);
							num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
							{
								num5 = 0;
							}
							break;
						case 0:
							return;
						}
					}
				}
				break;
			case 6:
				num = 7;
				continue;
			case 8:
				return;
			case 1:
				if (!Directory.Exists(path))
				{
					num = 3;
					continue;
				}
				goto case 6;
			case 2:
				break;
			case 3:
				try
				{
					Directory.CreateDirectory(path);
					int num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
					{
						num2 = 0;
					}
					switch (num2)
					{
					case 0:
						break;
					}
				}
				catch (Exception ex)
				{
					int num3 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
					{
						num3 = 1;
					}
					while (true)
					{
						switch (num3)
						{
						default:
							return;
						case 0:
							return;
						case 1:
							hbH3xJx9XFVI2t3K30o(u4cRF2xyWDvExR7FkYM(), jAfVi1xJEFv610O4hMj(M1LVXdxMeCetuN1k9UA(0x1FFEF86A ^ 0x1FFE6446), path), ex);
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
							{
								num3 = 0;
							}
							break;
						}
					}
				}
				goto case 6;
			}
			_canRead = true;
			num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
			{
				num = 0;
			}
		}
	}

	public string Read()
	{
		//Discarded unreachable code: IL_00d6, IL_00e5, IL_00f5, IL_0146, IL_01a3, IL_01b2
		int num = 3;
		int num2 = num;
		string result = default(string);
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (!_canRead)
				{
					num2 = 2;
					break;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
				{
					num2 = 1;
				}
				break;
			default:
				return null;
			case 1:
				try
				{
					string text = (string)nt6eF1xrJnsagrXDH6o(_path, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477105944));
					int num3 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
					{
						num3 = 1;
					}
					while (true)
					{
						switch (num3)
						{
						case 2:
							return result;
						case 4:
						{
							result = ((string)otfjj2xY6xHStsS8NrR(text)).Trim(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487399382).ToCharArray());
							int num4 = 2;
							num3 = num4;
							continue;
						}
						case 0:
							break;
						case 1:
							if (!RFmqgexj9H0lw4ALmL7(text))
							{
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
								{
									num3 = 0;
								}
								continue;
							}
							goto case 4;
						case 3:
							break;
						}
						break;
					}
				}
				catch (Exception ex)
				{
					int num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
					{
						num5 = 0;
					}
					while (true)
					{
						switch (num5)
						{
						default:
							hbH3xJx9XFVI2t3K30o(u4cRF2xyWDvExR7FkYM(), jAfVi1xJEFv610O4hMj(M1LVXdxMeCetuN1k9UA(-16752921 ^ -16727109), _path), ex);
							num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
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
				goto default;
			case 2:
				return null;
			}
		}
	}

	public bool Write(string value)
	{
		//Discarded unreachable code: IL_0058, IL_00ac, IL_0104, IL_0113, IL_0123
		int num = 1;
		int num2 = num;
		string text = default(string);
		bool result = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return false;
			case 2:
				try
				{
					File.WriteAllText(text, value);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
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
							result = true;
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
							{
								num3 = 0;
							}
							break;
						}
					}
				}
				catch (Exception exception)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
					{
						num4 = 1;
					}
					while (true)
					{
						switch (num4)
						{
						case 1:
							Logger.Log.Error(jAfVi1xJEFv610O4hMj(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-787452571 ^ -787418925), text), exception);
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
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
				goto case 3;
			case 1:
				if (_canWrite)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 4;
			case 4:
				return false;
			default:
				text = (string)nt6eF1xrJnsagrXDH6o(_path, M1LVXdxMeCetuN1k9UA(-951514650 ^ -951479084));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	internal static void LP6kgPx0dVT0bQUCTdR()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool wyKAPfxmNVw5OMGwIIa(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object u4cRF2xyWDvExR7FkYM()
	{
		return Logger.Log;
	}

	internal static object M1LVXdxMeCetuN1k9UA(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object jAfVi1xJEFv610O4hMj(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static void hbH3xJx9XFVI2t3K30o(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static object BLjX6rxd4xjtUGqpUq9(object P_0)
	{
		return Directory.GetFiles((string)P_0);
	}

	internal static Guid Cs16jFxl2i2tLgRNr9x()
	{
		return Guid.NewGuid();
	}

	internal static object nt6eF1xrJnsagrXDH6o(object P_0, object P_1)
	{
		return Path.Combine((string)P_0, (string)P_1);
	}

	internal static void VeXeqFxgp99glMNbp5a(object P_0, object P_1)
	{
		File.WriteAllText((string)P_0, (string)P_1);
	}

	internal static void wSskbPx5gyvIDTGH4IW(object P_0)
	{
		File.Delete((string)P_0);
	}

	internal static bool jGEpGdx7OIIyY0hDNFm()
	{
		return RKQy4fxAGbWlq2MkJIV == null;
	}

	internal static InstallationIdFileStorage ceV8fgxxtMLnw2PwQmf()
	{
		return RKQy4fxAGbWlq2MkJIV;
	}

	internal static bool RFmqgexj9H0lw4ALmL7(object P_0)
	{
		return File.Exists((string)P_0);
	}

	internal static object otfjj2xY6xHStsS8NrR(object P_0)
	{
		return File.ReadAllText((string)P_0);
	}
}
