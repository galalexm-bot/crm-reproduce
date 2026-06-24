using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Metadata;

public class MetadataPublishedEventArgs : EventArgs
{
	internal static MetadataPublishedEventArgs a2fIlBbDHyG87Nj3E1Co;

	public MetadataPublishResult PublishResult
	{
		[CompilerGenerated]
		get
		{
			return _003CPublishResult_003Ek__BackingField;
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
					_003CPublishResult_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
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

	public ICollection<IRootMetadata> SoftPublishedMetadata { get; set; }

	public ICollection<IRootMetadata> RestartNeededMetadata { get; set; }

	public ICollection<IRootMetadata> DeltaPublishedMetadata { get; set; }

	public MetadataPublishedEventArgs()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		GgU8E0bDxFBdXJje0LFN();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool IsQI4WbDAvwJRgbZdRQU()
	{
		return a2fIlBbDHyG87Nj3E1Co == null;
	}

	internal static MetadataPublishedEventArgs wSGLAabD7iOX5eVtvKnc()
	{
		return a2fIlBbDHyG87Nj3E1Co;
	}

	internal static void GgU8E0bDxFBdXJje0LFN()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
