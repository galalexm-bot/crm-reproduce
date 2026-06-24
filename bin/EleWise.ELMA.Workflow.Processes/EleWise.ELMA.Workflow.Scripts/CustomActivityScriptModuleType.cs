using System;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Templates;
using EleWise.ELMA.Workflow.DTO.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Scripts;

public class CustomActivityScriptModuleType : IScriptModuleType
{
	public class Parameters
	{
		private static Parameters bfmLKrAlB9A0s5cnBap;

		public string CustomActivityEntityName
		{
			[CompilerGenerated]
			get
			{
				return _003CCustomActivityEntityName_003Ek__BackingField;
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
						_003CCustomActivityEntityName_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_140e6a1eacec422f932ef627eb6c4c16 == 0)
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

		public Parameters()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			bA3BZXAJPI4BVQVUx8c();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_0b98e2160a714197bf0d3d74d55d90bc == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool Mqd2srAfDOiS7Po7LPr()
		{
			return bfmLKrAlB9A0s5cnBap == null;
		}

		internal static Parameters GUWhORALElkZBngnNyr()
		{
			return bfmLKrAlB9A0s5cnBap;
		}

		internal static void bA3BZXAJPI4BVQVUx8c()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
		}
	}

	public const string UID_S = "{4CFA21CA-3750-4E86-87FC-2209E72EE5D4}";

	public static readonly Guid UID;

	internal static CustomActivityScriptModuleType PGThAW3LHc0dW9Md4iB;

	public Guid Uid => UID;

	public string Name => (string)i8YHT13gl7qjsAeESXk(aAiuST35QCVGK5eNNBM(0x624F2FBE ^ 0x624F0568));

	public static string GenerateSourceCode(CustomActivityDTO ca, string fullAssemblyName)
	{
		int num = 3;
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = default(_003C_003Ec__DisplayClass2_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					return ResourceTemplateGenerator.GenerateTemplate<CustomActivityScriptModuleType>((string)aAiuST35QCVGK5eNNBM(0x62463138 ^ 0x62461B46), _003C_003Ec__DisplayClass2_._003CGenerateSourceCode_003Eb__0);
				case 3:
					break;
				case 4:
					_003C_003Ec__DisplayClass2_.summary = SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x747C4140 ^ 0x747C6B54), NDVKGK37063KEQXpRVs(_003C_003Ec__DisplayClass2_.ca.Header));
					num2 = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_25eedcea124a48258fd18106b7da9d93 == 0)
					{
						num2 = 1;
					}
					continue;
				default:
					_003C_003Ec__DisplayClass2_.ca = ca;
					num2 = 4;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_7ff589a2577e4ae68ceb125a419ed974 == 0)
					{
						num2 = 3;
					}
					continue;
				case 2:
					_003C_003Ec__DisplayClass2_.fullAssemblyName = fullAssemblyName;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_12d847d953a942998a65b55f3d0b7ddb != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			_003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
			num = 2;
		}
	}

	public string GenerateSourceCode(object parameters)
	{
		return GenerateSourceCode((CustomActivityDTO)parameters);
	}

	public ScriptCompileResult Compile(ScriptModule module)
	{
		throw new NotImplementedException();
	}

	public CustomActivityScriptModuleType()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		bTYvpu31tZPXJsrlXim();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2a731ad20cd44175bde6db1171290626 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static CustomActivityScriptModuleType()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				UID = new Guid((string)aAiuST35QCVGK5eNNBM(0x2C9503E1 ^ 0x2C9528D5));
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_feeb07d467ad474ea937eb4a7eec98da == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 2:
				j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_d526d6cd8ea24dfca60f96f0f0be6307 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static object NDVKGK37063KEQXpRVs(object P_0)
	{
		return ((CustomActivityHeaderDTO)P_0).Name;
	}

	internal static object aAiuST35QCVGK5eNNBM(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool xCr9GK3JAsChKiLF1oR()
	{
		return PGThAW3LHc0dW9Md4iB == null;
	}

	internal static CustomActivityScriptModuleType xPxU8R3rdVDKbaHPyUY()
	{
		return PGThAW3LHc0dW9Md4iB;
	}

	internal static object i8YHT13gl7qjsAeESXk(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static void bTYvpu31tZPXJsrlXim()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}
}
