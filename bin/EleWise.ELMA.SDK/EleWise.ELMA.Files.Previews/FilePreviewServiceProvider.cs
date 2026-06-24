using System;
using System.Configuration.Provider;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Files.Previews;

public abstract class FilePreviewServiceProvider : ProviderBase, IFilePreviewServiceProvider
{
	private static FilePreviewServiceProvider OKKtWqG2DbWbNxwVugeE;

	public abstract Guid ProviderUid { get; }

	public abstract void AddFileToQueue(string fileId, long priority);

	public abstract void DeleteFileFromQueue(string fileId);

	public abstract PreviewWorkStatus GetFilePreviewWorkStatus(string fileId);

	public abstract bool GeneratePreview(string fileId, string fileEncryptPassword, string password);

	public abstract bool CheckPassword(string fileId, string password);

	public abstract bool CheckPassword(string fileId, string fileEncryptPassword, string password);

	public virtual IFilePreviewCreator GetFilePreviewCreator(BinaryFile file)
	{
		//Discarded unreachable code: IL_009c, IL_00eb, IL_00fa, IL_019b, IL_01f4
		int num = 5;
		int num2 = num;
		IFilePreviewCreator result = default(IFilePreviewCreator);
		_003C_003Ec__DisplayClass8_0 _003C_003Ec__DisplayClass8_ = default(_003C_003Ec__DisplayClass8_0);
		_003C_003Ec__DisplayClass8_1 CS_0024_003C_003E8__locals0;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return result;
			case 3:
				return null;
			case 1:
				if (_003C_003Ec__DisplayClass8_.file != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
					{
						num2 = 3;
					}
				}
				continue;
			case 5:
				_003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_0();
				num2 = 4;
				continue;
			case 4:
				_003C_003Ec__DisplayClass8_.file = file;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
				{
					num2 = 1;
				}
				continue;
			}
			try
			{
				CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass8_1();
				int num3 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
				{
					num3 = 1;
				}
				while (true)
				{
					switch (num3)
					{
					case 3:
						return result;
					case 4:
						return result;
					case 1:
						CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass8_;
						num3 = 6;
						break;
					case 5:
						result = null;
						num3 = 4;
						break;
					case 2:
						if (hLJfLdG24FqJ4ox5cOj4(CS_0024_003C_003E8__locals0.ext))
						{
							num3 = 5;
							break;
						}
						goto default;
					default:
						result = ((ComponentManager)hETf2kG26ebrKCDD4bIY()).GetExtensionPoints<IFilePreviewCreator>().FirstOrDefault(delegate(IFilePreviewCreator c)
						{
							int num5 = 1;
							int num6 = num5;
							while (true)
							{
								switch (num6)
								{
								default:
									return _003C_003Ec__DisplayClass8_1.iWMu1Fvz2vkUoAWm8llp(c, CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.file);
								case 1:
									if (!c.Extensions.Any((string e) => _003C_003Ec__DisplayClass8_1.r0bsMLvzepBa06wrKiv3(e, CS_0024_003C_003E8__locals0.ext, StringComparison.OrdinalIgnoreCase)))
									{
										return false;
									}
									num6 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
									{
										num6 = 0;
									}
									break;
								}
							}
						});
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
						{
							num3 = 3;
						}
						break;
					case 6:
						CS_0024_003C_003E8__locals0.ext = CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.file.Extension;
						num3 = 2;
						break;
					}
				}
			}
			catch (Exception ex)
			{
				int num4 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
				{
					num4 = 0;
				}
				while (true)
				{
					switch (num4)
					{
					case 2:
						return result;
					case 1:
						result = null;
						num4 = 2;
						continue;
					}
					x2eHAMG2AiFueNHrZXTq(buWwydG2HAy1ype6VuWC(), ex.Message, ex);
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
					{
						num4 = 1;
					}
				}
			}
		}
	}

	protected FilePreviewServiceProvider()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		RmjxkXG278Y8Jl9VbVG9();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool hLJfLdG24FqJ4ox5cOj4(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object hETf2kG26ebrKCDD4bIY()
	{
		return ComponentManager.Current;
	}

	internal static object buWwydG2HAy1ype6VuWC()
	{
		return Logger.Log;
	}

	internal static void x2eHAMG2AiFueNHrZXTq(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static bool SUUja9G2tZ67YEVnCEct()
	{
		return OKKtWqG2DbWbNxwVugeE == null;
	}

	internal static FilePreviewServiceProvider vYYFsgG2wA9Ca6U85VXK()
	{
		return OKKtWqG2DbWbNxwVugeE;
	}

	internal static void RmjxkXG278Y8Jl9VbVG9()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
