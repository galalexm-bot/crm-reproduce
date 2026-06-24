using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Templates;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.Scripts;

[Component]
public abstract class FormScriptModuleType<TParams> : IScriptModuleType where TParams : FormScriptCodeGenerationParams
{
	private static object wPNB1QYGvy4ccnTqYNO;

	public abstract Guid Uid { get; }

	public abstract string Name { get; }

	protected abstract string TemplateFileName { get; }

	public virtual string GenerateSourceCode(TParams p)
	{
		_003C_003Ec__DisplayClass0_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass0_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.p = p;
		return ResourceTemplateGenerator.GenerateTemplate<FormScriptModuleType<FormScriptCodeGenerationParams>>(TemplateFileName, (string s) => CS_0024_003C_003E8__locals0._003C_003E4__this.ProcessTemplate(s, CS_0024_003C_003E8__locals0.p));
	}

	public string GenerateSourceCode(object parameters)
	{
		return GenerateSourceCode((TParams)parameters);
	}

	public virtual ScriptCompileResult Compile(ScriptModule module)
	{
		throw new NotImplementedException();
	}

	protected virtual string ProcessTemplate(string template, TParams p)
	{
		Contract.ArgumentNotNull(p, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6A81B9B4 ^ 0x6A81736C));
		Contract.NotNull(p.Metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3CE17B75 ^ 0x3CE1B1AB));
		return template.Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740319454), p.Metadata.Namespace).Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837648533), p.Metadata.Name).Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CACA3 ^ 0x53C6789), GetSummary(p));
	}

	protected abstract string GetSummary(TParams p);

	protected FormScriptModuleType()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool RK4KCJYEGOhX57L2tT1()
	{
		return wPNB1QYGvy4ccnTqYNO == null;
	}

	internal static object j1ln5tYfAlvedcjAxdg()
	{
		return wPNB1QYGvy4ccnTqYNO;
	}
}
