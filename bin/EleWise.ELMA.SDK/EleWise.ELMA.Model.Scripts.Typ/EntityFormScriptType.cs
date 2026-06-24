using System.Collections.Generic;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Scripts.Types;

public abstract class EntityFormScriptType : ScriptTypeBase
{
	public static class Parameters
	{
		public const string ClassMetadata = "ClassMetadata";

		public const string TablePartMetadata = "TablePartMetadata";
	}

	internal static EntityFormScriptType sVRp7Abk1V5nMIZA4pes;

	public override ScriptMethodDeclaration GenerateMethod(string name, IDictionary<string, object> generationParams = null)
	{
		ScriptMethodDeclaration scriptMethodDeclaration = new ScriptMethodDeclaration
		{
			Name = name
		};
		string text = GetEntityTypeName(generationParams);
		scriptMethodDeclaration.Parameters.Add(new ScriptMethodParameter(GetEntityParameterName(generationParams), text));
		if (GetParameterValue(generationParams, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5A4C7B29 ^ 0x5A4CB431)) is TablePartMetadata tablePartMetadata)
		{
			text = tablePartMetadata.TypeName;
			scriptMethodDeclaration.Parameters.Add(new ScriptMethodParameter(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xA592A41 ^ 0xA59823F), text));
		}
		scriptMethodDeclaration.Parameters.Add(new ScriptMethodParameter(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7EC153F ^ 0x7ECEED9), string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x76DD48E ^ 0x76F12CC), text)));
		return scriptMethodDeclaration;
	}

	protected virtual string GetEntityTypeName(IDictionary<string, object> generationParams)
	{
		if (!(GetParameterValue(generationParams, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-542721635 ^ -542738585)) is ClassMetadata classMetadata))
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xA592A41 ^ 0xA596EBD);
		}
		return classMetadata.TypeName;
	}

	protected virtual string GetEntityParameterName(IDictionary<string, object> generationParams)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088329860);
	}

	protected EntityFormScriptType()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool p3cdqkbkNPRBrw9KtYHT()
	{
		return sVRp7Abk1V5nMIZA4pes == null;
	}

	internal static EntityFormScriptType u45uihbk3BfdsnBtWjWH()
	{
		return sVRp7Abk1V5nMIZA4pes;
	}
}
