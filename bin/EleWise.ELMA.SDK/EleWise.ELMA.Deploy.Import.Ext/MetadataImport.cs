using System.Collections.Generic;
using EleWise.ELMA.BPMApps;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Deploy.Import.ExtensionPoints;

[Component]
public abstract class MetadataImport : IMetadataImport
{
	internal static MetadataImport kYdQw9ErXXsZvhgfrgTD;

	public abstract void CreateFakeChapter(NamedMetadata namedMd, BPMAppFakeManifest fakeManifest, BPMAppManifest manifest);

	public virtual void MergeMetadataSettings(NamedMetadata mdBase, NamedMetadata mdImported, Dictionary<string, string> serviceData)
	{
	}

	protected MetadataImport()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool q0H1SEErTIqyRrKjsk3v()
	{
		return kYdQw9ErXXsZvhgfrgTD == null;
	}

	internal static MetadataImport gFoKEjErkfVucG69dmEJ()
	{
		return kYdQw9ErXXsZvhgfrgTD;
	}
}
