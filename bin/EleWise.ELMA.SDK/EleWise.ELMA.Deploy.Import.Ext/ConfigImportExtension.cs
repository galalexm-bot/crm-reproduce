using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Deploy.Import.ExtensionPoints;

public abstract class ConfigImportExtension : IConfigImportExtension, IConfigImportActionExtension
{
	internal static ConfigImportExtension MtL7FlElgaCfn28btpSV;

	public virtual void OnPostCompleteTest(PostCompleteTestImportParameters parameters)
	{
	}

	public virtual void OnPreStartTest(PreStartTestImportParameters parameters)
	{
	}

	public virtual void OnPreStartImport(PreStartImportParameters parameters)
	{
	}

	public virtual void OnPreReadPackets(PreReadPacketsParameters parameters)
	{
	}

	IReadMetadataResult IConfigImportActionExtension.OnReadMetadata(ReadMetadataParameters parameters, bool isTestRead)
	{
		return null;
	}

	public virtual void OnPostReadPackets(PostReadPacketsParameters parameters)
	{
	}

	public virtual void OnPostCompleteImport(PostCompleteImportParameters parameters)
	{
	}

	public virtual void OnPrePublish(PrePublishParameters parameters)
	{
	}

	public virtual void OnPostPublish(PostPublishParameters parameters)
	{
	}

	public virtual void OnImportSuccessfull(ImportSuccessfullParameters parameters)
	{
	}

	protected ConfigImportExtension()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		re2Is3ElY0OUUW5y0bDA();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void re2Is3ElY0OUUW5y0bDA()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool tMYr0FEl57ug779JRqec()
	{
		return MtL7FlElgaCfn28btpSV == null;
	}

	internal static ConfigImportExtension yjg9sSEljwIv55PSJl6k()
	{
		return MtL7FlElgaCfn28btpSV;
	}
}
