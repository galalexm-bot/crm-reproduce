using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Metadata;

[Component]
public class MetadataContainer : IXsiRoot
{
	private static MetadataContainer vivXwkbxXEKamfPt9q1r;

	public AbstractMetadata[] Metadata
	{
		[CompilerGenerated]
		get
		{
			return _003CMetadata_003Ek__BackingField;
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
					_003CMetadata_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public MetadataContainer()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		kiVN0SbxntKw8MGAUrop();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool jDvipGbxTkRfwvMccBR8()
	{
		return vivXwkbxXEKamfPt9q1r == null;
	}

	internal static MetadataContainer QUtoNwbxkTILqMioVE0K()
	{
		return vivXwkbxXEKamfPt9q1r;
	}

	internal static void kiVN0SbxntKw8MGAUrop()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
