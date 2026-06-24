using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.Scripts.Types;

[Component]
public abstract class FormScriptType : ScriptTypeBase
{
	public static class Parameters
	{
		public const string FormMetadata = "FormMetadata";
	}

	private static FormScriptType Ddhw5xLC23UF2Ls5Edl;

	public override ScriptMethodDeclaration GenerateMethod(string name, IDictionary<string, object> generationParams = null)
	{
		ScriptMethodDeclaration scriptMethodDeclaration = new ScriptMethodDeclaration
		{
			Name = name
		};
		FormMetadata formMetadata = (FormMetadata)generationParams[z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4785BC0D ^ 0x478572D3)];
		FormContextMetadata contextMetadata = (FormContextMetadata)generationParams[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1852883714)];
		FormTablePartMetadata tablePartMetadata = GetParameterValue(generationParams, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34185E55 ^ 0x3418914D)) as FormTablePartMetadata;
		SetMethodParameters(scriptMethodDeclaration, formMetadata, contextMetadata, tablePartMetadata, generationParams);
		return scriptMethodDeclaration;
	}

	protected abstract void SetMethodParameters(ScriptMethodDeclaration declaration, FormMetadata formMetadata, FormContextMetadata contextMetadata, FormTablePartMetadata tablePartMetadata, IDictionary<string, object> generationParams);

	protected FormScriptType()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool R5SaBrLveQ9p3UnQtgm()
	{
		return Ddhw5xLC23UF2Ls5Edl == null;
	}

	internal static FormScriptType O6bYuHL8aVn4tSgSd8C()
	{
		return Ddhw5xLC23UF2Ls5Edl;
	}
}
