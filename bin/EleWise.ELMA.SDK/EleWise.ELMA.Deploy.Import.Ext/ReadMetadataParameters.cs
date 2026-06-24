using System;
using System.Collections.Generic;
using EleWise.ELMA.BPMApps;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Deploy.Import.ExtensionPoints;

public sealed class ReadMetadataParameters : ImportExtensionBaseParameters
{
	private readonly Action<TestImportMessages> testMessagesAdd;

	internal static ReadMetadataParameters w5NIa4ElKs0NNc71OP2H;

	public IImportSettings ImportSettings { get; }

	public IMetadata Metadata { get; }

	public bool IsSystemMetadata { get; }

	public IDictionary<string, ICollection<string>> Attributes { get; }

	public string TreeUid { get; }

	public MergeReplace MergeReplace { get; }

	public IDictionary<string, string> ServiceData { get; }

	public ICollection<long> Headers { get; }

	public ISet<Guid> MetadataNotIsUnique { get; }

	public BPMAppManifest ManifestExecuteMetadata { get; }

	public string ServerFolderName { get; }

	internal ReadMetadataParameters(List<DeployLogMessage> messages, List<DeploySystemMessage> systemMessages, IImportSettings importSettings, IMetadata metadata, bool isSystemMetadata, IDictionary<string, ICollection<string>> attributes, string treeUid, MergeReplace mergeReplace, IDictionary<string, string> serviceData, ICollection<long> headers, ISet<Guid> metadataNotIsUnique, BPMAppManifest manifestExecuteMetadata, string serverFolderName, Action<TestImportMessages> testMessagesAdd)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(messages, systemMessages);
		this.testMessagesAdd = testMessagesAdd;
		ImportSettings = importSettings;
		Metadata = metadata;
		IsSystemMetadata = isSystemMetadata;
		Attributes = attributes ?? new Dictionary<string, ICollection<string>>();
		TreeUid = treeUid;
		MergeReplace = mergeReplace;
		ServiceData = serviceData;
		Headers = headers;
		MetadataNotIsUnique = metadataNotIsUnique;
		ManifestExecuteMetadata = manifestExecuteMetadata;
		ServerFolderName = serverFolderName;
	}

	public void TestMessagesAdd(TestImportMessages message)
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
				testMessagesAdd(message);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool c3KjPgElXdxpEFbFRvC6()
	{
		return w5NIa4ElKs0NNc71OP2H == null;
	}

	internal static ReadMetadataParameters S2d7a2ElTbOKyos3ie8b()
	{
		return w5NIa4ElKs0NNc71OP2H;
	}
}
