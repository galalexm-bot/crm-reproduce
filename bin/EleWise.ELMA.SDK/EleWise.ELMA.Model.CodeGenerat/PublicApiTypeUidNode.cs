using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.CodeGeneration.PublicApi;

public class PublicApiTypeUidNode : IPublicApiNode
{
	private readonly EntityMetadata entityMetadata;

	internal static PublicApiTypeUidNode myQRpgh7CjkQA9m0G15n;

	public string ParentPath
	{
		[CompilerGenerated]
		get
		{
			return _003CParentPath_003Ek__BackingField;
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
					_003CParentPath_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string Path => (string)gRVFEQh7IvOaOf3Itar5(ParentPath, r09bD7h7u04chKngGoy9(-210725949 ^ -210563071));

	public PublicApiTypeUidNode(string parentPath, [NotNull] EntityMetadata entityMetadata)
	{
		//Discarded unreachable code: IL_001a, IL_001f
		vWXdsWh7ZWG4ZKeHqwx7();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 2:
				ParentPath = parentPath;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
				{
					num = 0;
				}
				break;
			case 1:
				this.entityMetadata = entityMetadata;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	[IteratorStateMachine(typeof(_003CGenerate_003Ed__8))]
	public IEnumerable<ISyntaxNode> Generate(IDictionary<string, IEnumerable<IPublicApiNode>> tree)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CGenerate_003Ed__8(-2)
		{
			_003C_003E4__this = this
		};
	}

	internal static void vWXdsWh7ZWG4ZKeHqwx7()
	{
		SingletonReader.PushGlobal();
	}

	internal static bool lr7o7vh7vCC9r9iNgpHB()
	{
		return myQRpgh7CjkQA9m0G15n == null;
	}

	internal static PublicApiTypeUidNode nRoT1uh78vvGZq8iQYqC()
	{
		return myQRpgh7CjkQA9m0G15n;
	}

	internal static object r09bD7h7u04chKngGoy9(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object gRVFEQh7IvOaOf3Itar5(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}
}
