using System;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Services;

public class MetadataEditorProjectContext : IDisposable
{
	private readonly IMetadataEditorService metadataEditorService;

	private readonly string oldProjectName;

	private readonly MetadataServiceContext activeContext;

	internal static MetadataEditorProjectContext fp88PcbQ9yZnBqpB1oLU;

	public MetadataEditorProjectContext(IMetadataEditorService metadataEditorService, string projectName, bool doActive = false)
	{
		//Discarded unreachable code: IL_001a, IL_0063, IL_0072
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 2:
				this.metadataEditorService = metadataEditorService;
				num = 3;
				break;
			case 5:
				return;
			case 6:
			{
				activeContext = new MetadataServiceContext(metadataEditorService);
				int num2 = 5;
				num = num2;
				break;
			}
			default:
				if (!doActive)
				{
					return;
				}
				num = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
				{
					num = 1;
				}
				break;
			case 7:
				if (LK6OcUbQgvXQCfDI64bp(projectName))
				{
					num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
					{
						num = 1;
					}
					break;
				}
				goto case 4;
			case 4:
				cUIif8bQ5MFgwNkLSHga(metadataEditorService, projectName);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
				{
					num = 0;
				}
				break;
			case 3:
				oldProjectName = (string)Ah3MVObQru2i7UXbHgxM(metadataEditorService);
				num = 7;
				break;
			}
		}
	}

	public void Dispose()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				return;
			default:
				vVWpCrbQjLA7d6VkAYeA(activeContext);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				metadataEditorService.CurrentProjectName = oldProjectName;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
				{
					num2 = 3;
				}
				break;
			case 1:
				if (activeContext != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	internal static object Ah3MVObQru2i7UXbHgxM(object P_0)
	{
		return ((IMetadataEditorService)P_0).CurrentProjectName;
	}

	internal static bool LK6OcUbQgvXQCfDI64bp(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static void cUIif8bQ5MFgwNkLSHga(object P_0, object P_1)
	{
		((IMetadataEditorService)P_0).CurrentProjectName = (string)P_1;
	}

	internal static bool muZiwibQdnowADSbVYYL()
	{
		return fp88PcbQ9yZnBqpB1oLU == null;
	}

	internal static MetadataEditorProjectContext thH7jcbQlq9OyKY4JftN()
	{
		return fp88PcbQ9yZnBqpB1oLU;
	}

	internal static void vVWpCrbQjLA7d6VkAYeA(object P_0)
	{
		((MetadataServiceContext)P_0).Dispose();
	}
}
