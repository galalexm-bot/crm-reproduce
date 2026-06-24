using System;
using System.Collections.Generic;
using System.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Deploy.Models;

public sealed class SubUserMetadataInfo
{
	public Dictionary<string, Guid> ScriptModules;

	private static SubUserMetadataInfo NO6FTjEwLbR6ycjaSh61;

	public IMetadata Metadata { get; }

	[EditorBrowsable(EditorBrowsableState.Never)]
	public SubUserMetadataInfo(IGroupedMetadata metadata)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		nYGW3HEwc1A3x1IrTI83();
		this._002Ector((IMetadata)metadata);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public SubUserMetadataInfo(IMetadata metadata)
	{
		//Discarded unreachable code: IL_003a, IL_003f
		nYGW3HEwc1A3x1IrTI83();
		ScriptModules = new Dictionary<string, Guid>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			Metadata = metadata;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
			{
				num = 1;
			}
		}
	}

	internal static void nYGW3HEwc1A3x1IrTI83()
	{
		SingletonReader.PushGlobal();
	}

	internal static bool kbyu7SEwUF3Ik92MZJbO()
	{
		return NO6FTjEwLbR6ycjaSh61 == null;
	}

	internal static SubUserMetadataInfo UAG1HSEwsWcxYwtrwHCv()
	{
		return NO6FTjEwLbR6ycjaSh61;
	}
}
