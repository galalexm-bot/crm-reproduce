using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Components;

[Component]
internal sealed class FunctionLinkedFinder : LinkedFinderBase
{
	private readonly IFunctionMetadataItemHeaderManager functionMetadataItemHeaderManager;

	private static FunctionLinkedFinder te5lX3fG2Nf4o0rUV6iF;

	public FunctionLinkedFinder(IFunctionMetadataItemHeaderManager functionMetadataItemHeaderManager)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		YFKROffG1HRB6YqobqSu();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
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
			this.functionMetadataItemHeaderManager = functionMetadataItemHeaderManager;
			num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
			{
				num = 1;
			}
		}
	}

	public override FindLinkedObjectsResult FindLinkedObjects(ICollection<ILinkedObject> objectsToSearch, LinkedObjectsContext context)
	{
		FindLinkedObjectsResult findLinkedObjectsResult = new FindLinkedObjectsResult();
		foreach (ILinkedObject item in objectsToSearch)
		{
			IMetadata metadata = GetMetadata(item.Uid, context, findLinkedObjectsResult);
			if (metadata != null && metadata is FunctionMetadata functionMetadata)
			{
				FillObj(findLinkedObjectsResult, context, functionMetadata.Uid);
				if (functionMetadata.ParameterType != null)
				{
					FillObj(findLinkedObjectsResult, context, functionMetadata.ParameterType.SubTypeUid);
				}
				if (functionMetadata.ReturnType != null)
				{
					FillObj(findLinkedObjectsResult, context, functionMetadata.ReturnType.SubTypeUid);
				}
			}
		}
		return findLinkedObjectsResult;
	}

	protected override IMetadata GetMetadataWithUid(Guid metadataId, LinkedObjectsContext context)
	{
		//Discarded unreachable code: IL_0072, IL_0081, IL_0092
		int num = 4;
		int num2 = num;
		FunctionMetadataItemHeader functionMetadataItemHeader = default(FunctionMetadataItemHeader);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 4:
				functionMetadataItemHeader = functionMetadataItemHeaderManager.LoadOrNull(metadataId);
				num2 = 3;
				continue;
			default:
				return ((FunctionMetadataItem)jlsjsmfGNnX01Fq0ZkxL(functionMetadataItemHeader)).Metadata as FunctionMetadata;
			case 3:
				if (functionMetadataItemHeader != null)
				{
					num2 = 2;
					continue;
				}
				goto case 1;
			case 1:
				obj = null;
				break;
			case 2:
				obj = jlsjsmfGNnX01Fq0ZkxL(functionMetadataItemHeader);
				break;
			}
			if (obj == null)
			{
				break;
			}
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
			{
				num2 = 0;
			}
		}
		return null;
	}

	internal static void YFKROffG1HRB6YqobqSu()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool OD0KX5fGeRNYTj7GpELI()
	{
		return te5lX3fG2Nf4o0rUV6iF == null;
	}

	internal static FunctionLinkedFinder su24dBfGP9JfQ9tdaULZ()
	{
		return te5lX3fG2Nf4o0rUV6iF;
	}

	internal static object jlsjsmfGNnX01Fq0ZkxL(object P_0)
	{
		return ((FunctionMetadataItemHeader)P_0).Draft;
	}
}
