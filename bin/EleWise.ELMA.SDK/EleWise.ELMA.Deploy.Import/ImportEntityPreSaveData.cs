using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Deploy.Import.Links;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Import;

public class ImportEntityPreSaveData
{
	internal static ImportEntityPreSaveData NKmlpMEm1l9uGAay8iBM;

	public Dictionary<string, string> ServiceData { get; private set; }

	public List<DeploySystemMessage> SystemMessages { get; private set; }

	public MergeReplace MergeReplace
	{
		[CompilerGenerated]
		get
		{
			return _003CMergeReplace_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
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
					_003CMergeReplace_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
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

	public LinksDictionary LinksDictionary
	{
		[CompilerGenerated]
		get
		{
			return _003CLinksDictionary_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
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
					_003CLinksDictionary_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ImportEntityPreSaveData(Dictionary<string, string> serviceData, List<DeploySystemMessage> systemMessages, MergeReplace mergeReplace, LinksDictionary linksDictionary)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		Contract.ArgumentNotNull(serviceData, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-289714582 ^ -289413250));
		Contract.ArgumentNotNull(systemMessages, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-281842504 ^ -281557118));
		Contract.ArgumentNotNull(linksDictionary, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x76DD48E ^ 0x7697FD4));
		ServiceData = serviceData;
		SystemMessages = systemMessages;
		MergeReplace = mergeReplace ?? new MergeReplace();
		LinksDictionary = linksDictionary;
	}

	internal static bool LOoWVoEmN5MxxEnj8DaQ()
	{
		return NKmlpMEm1l9uGAay8iBM == null;
	}

	internal static ImportEntityPreSaveData Gr39dEEm340rUVM8YuIG()
	{
		return NKmlpMEm1l9uGAay8iBM;
	}
}
