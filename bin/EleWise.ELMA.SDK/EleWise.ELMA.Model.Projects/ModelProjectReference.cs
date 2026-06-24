using System.IO;
using System.Linq;
using j3AmrhgkCleVTGdEwA;
using Microsoft.Build.Construction;

namespace EleWise.ELMA.Model.Projects;

public class ModelProjectReference
{
	private ModelProject project;

	private ProjectItemElement item;

	private string path;

	private static ModelProjectReference NN9ToJWjQ4ouHPVnDQMi;

	public string Name => (string)puprxpWjuS3jO87mY7HB(item);

	public string HintPath => path;

	public string FullPath
	{
		get
		{
			//Discarded unreachable code: IL_002d, IL_003c
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (!string.IsNullOrEmpty(path))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				case 2:
					return null;
				default:
					return Path.Combine((string)HhTDKnWjI4NrZYS2xnRf(project), path);
				}
			}
		}
	}

	public ModelProjectReference(ModelProject project, ProjectItemElement item)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		XK7B5UWj8LKKFcTLiUJY();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
		{
			num = 0;
		}
		ProjectMetadataElement projectMetadataElement = default(ProjectMetadataElement);
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				this.project = project;
				num = 2;
				break;
			case 2:
				this.item = item;
				num = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
				{
					num = 1;
				}
				break;
			case 0:
				return;
			case 4:
				projectMetadataElement = item.Metadata.FirstOrDefault((ProjectMetadataElement m) => (string)_003C_003Ec.Noag7iCFO6K3LRgmkKRY(m) == (string)_003C_003Ec.QJZW8ICF2WJDUiSyXKQD(-576149596 ^ -576022296));
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
				{
					num = 3;
				}
				break;
			case 3:
				path = (string)((projectMetadataElement != null) ? XF3ZxpWjZVnGwRceTmcI(projectMetadataElement) : null);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	internal static void XK7B5UWj8LKKFcTLiUJY()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object XF3ZxpWjZVnGwRceTmcI(object P_0)
	{
		return ((ProjectMetadataElement)P_0).Value;
	}

	internal static bool zgloeUWjC8hJQBcBeWc7()
	{
		return NN9ToJWjQ4ouHPVnDQMi == null;
	}

	internal static ModelProjectReference Ph7ljnWjvd4UHqwvlaca()
	{
		return NN9ToJWjQ4ouHPVnDQMi;
	}

	internal static object puprxpWjuS3jO87mY7HB(object P_0)
	{
		return ((ProjectItemElement)P_0).Include;
	}

	internal static object HhTDKnWjI4NrZYS2xnRf(object P_0)
	{
		return ((ModelProject)P_0).ProjectDir;
	}
}
