using System;

namespace EleWise.ELMA.IntegrationModules.Metadata;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
public class AuthenticationSettingAttribute : Attribute
{
	private long attemptCount;

	private long attemptInterval;

	private string beforeScriptName;

	private string afterScriptName;

	private Guid authType;

	private Guid? authSubType;

	public Guid AuthType
	{
		get
		{
			return authType;
		}
		set
		{
			authType = value;
		}
	}

	public Guid? AuthSubType
	{
		get
		{
			return authSubType;
		}
		set
		{
			authSubType = value;
		}
	}

	public long AttemptCount
	{
		get
		{
			return attemptCount;
		}
		set
		{
			attemptCount = value;
		}
	}

	public long AttemptInterval
	{
		get
		{
			return attemptInterval;
		}
		set
		{
			attemptInterval = value;
		}
	}

	public string BeforeScriptName
	{
		get
		{
			return beforeScriptName;
		}
		set
		{
			beforeScriptName = value;
		}
	}

	public string AfterScriptName
	{
		get
		{
			return afterScriptName;
		}
		set
		{
			afterScriptName = value;
		}
	}

	public AuthenticationSettingAttribute(string authType, string subtypeUid, long attemptCount, long attemptInterval, string beforeScriptName, string afterScriptName)
	{
		this.authType = new Guid(authType);
		if (!string.IsNullOrWhiteSpace(subtypeUid))
		{
			authSubType = new Guid(subtypeUid);
		}
		this.attemptCount = attemptCount;
		this.attemptInterval = attemptInterval;
		this.beforeScriptName = beforeScriptName;
		this.afterScriptName = afterScriptName;
	}
}
