using System.Diagnostics;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Files.Previews;

public abstract class BasePasswordFilePreviewCreatorEx : BaseFilePreviewCreatorEx, IPasswordFilePreviewCreatorEx, IFilePreviewCreatorEx, IFilePreviewCreator, IPasswordFilePreviewCreator
{
	internal static BasePasswordFilePreviewCreatorEx l8bB8vGOaUWrgjpCa9Nr;

	public abstract bool CheckPassword(BinaryFile file, string password);

	public virtual void Create(string path, BinaryFile file, string password)
	{
	}

	Process IPasswordFilePreviewCreatorEx.CreateWithExternalCreator(string filePreviewDir, BinaryFile file, string password)
	{
		return (Process)jZVp8dGOwQvdId0VUW8E(this, filePreviewDir, file, password);
	}

	protected BasePasswordFilePreviewCreatorEx()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		BHRMTRGO4Cjr6kkacl0N();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object jZVp8dGOwQvdId0VUW8E(object P_0, object P_1, object P_2, object P_3)
	{
		return ((BaseFilePreviewCreatorEx)P_0).CreateWithExternalCreator((string)P_1, (BinaryFile)P_2, (string)P_3);
	}

	internal static bool imiXQEGODknZbd2AdSHp()
	{
		return l8bB8vGOaUWrgjpCa9Nr == null;
	}

	internal static BasePasswordFilePreviewCreatorEx hB86NtGOtP3HCRgwl7ZA()
	{
		return l8bB8vGOaUWrgjpCa9Nr;
	}

	internal static void BHRMTRGO4Cjr6kkacl0N()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
