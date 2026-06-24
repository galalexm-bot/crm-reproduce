using System;

namespace EleWise.ELMA.IntegrationModules.Metadata;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
public class IntegrationModuleScriptSettingsAttribute : Attribute
{
	private bool onCompleteExecute;

	private bool onEnterExecute;

	private string onCompleteScript;

	private string onEnterScript;

	public bool OnCompleteExecute
	{
		get
		{
			return onCompleteExecute;
		}
		set
		{
			onCompleteExecute = value;
		}
	}

	public bool OnEnterExecute
	{
		get
		{
			return onEnterExecute;
		}
		set
		{
			onEnterExecute = value;
		}
	}

	public string OnCompleteScript
	{
		get
		{
			return onCompleteScript;
		}
		set
		{
			onCompleteScript = value;
		}
	}

	public string OnEnterScript
	{
		get
		{
			return onEnterScript;
		}
		set
		{
			onEnterScript = value;
		}
	}

	public IntegrationModuleScriptSettingsAttribute(bool onCompleteExecute, string onCompleteScript, bool onEnterExecute, string onEnterScript)
	{
		this.onCompleteExecute = onCompleteExecute;
		this.onCompleteScript = onCompleteScript;
		this.onEnterExecute = onEnterExecute;
		this.onEnterScript = onEnterScript;
	}
}
