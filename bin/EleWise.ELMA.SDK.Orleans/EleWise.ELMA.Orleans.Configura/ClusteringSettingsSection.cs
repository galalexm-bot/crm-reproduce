using System;
using System.ComponentModel;
using System.Configuration;
using EleWise.ELMA.Configuration;
using Orleans.Configuration;

namespace EleWise.ELMA.Orleans.Configuration;

public class ClusteringSettingsSection : ProviderSettingsSection
{
	[ConfigurationProperty("ProbeTimeout", DefaultValue = "10")]
	[TypeConverter(typeof(TimeSpanSecondsConverter))]
	public TimeSpan ProbeTimeout
	{
		get
		{
			return (TimeSpan)base["ProbeTimeout"];
		}
		set
		{
			base["ProbeTimeout"] = value;
		}
	}

	[ConfigurationProperty("IAmAliveTablePublishTimeout", DefaultValue = "5")]
	[TypeConverter(typeof(TimeSpanSecondsConverter))]
	public TimeSpan IAmAliveTablePublishTimeout
	{
		get
		{
			return (TimeSpan)base["IAmAliveTablePublishTimeout"];
		}
		set
		{
			base["IAmAliveTablePublishTimeout"] = value;
		}
	}

	[ConfigurationProperty("TableRefreshTimeout", DefaultValue = "60")]
	[TypeConverter(typeof(TimeSpanSecondsConverter))]
	public TimeSpan TableRefreshTimeout
	{
		get
		{
			return (TimeSpan)base["TableRefreshTimeout"];
		}
		set
		{
			base["TableRefreshTimeout"] = value;
		}
	}

	[ConfigurationProperty("MaxJoinAttemptTime", DefaultValue = "300")]
	[TypeConverter(typeof(TimeSpanSecondsConverter))]
	public TimeSpan MaxJoinAttemptTime
	{
		get
		{
			return (TimeSpan)base["MaxJoinAttemptTime"];
		}
		set
		{
			base["MaxJoinAttemptTime"] = value;
		}
	}

	[ConfigurationProperty("NumProbedSilos", DefaultValue = 3)]
	public int NumProbedSilos
	{
		get
		{
			return (int)base["NumProbedSilos"];
		}
		set
		{
			base["NumProbedSilos"] = value;
		}
	}

	[ConfigurationProperty("NumMissedProbesLimit", DefaultValue = 3)]
	public int NumMissedProbesLimit
	{
		get
		{
			return (int)base["NumMissedProbesLimit"];
		}
		set
		{
			base["NumMissedProbesLimit"] = value;
		}
	}

	[ConfigurationProperty("NumVotesForDeathDeclaration", DefaultValue = 1)]
	public int NumVotesForDeathDeclaration
	{
		get
		{
			return (int)base["NumVotesForDeathDeclaration"];
		}
		set
		{
			base["NumVotesForDeathDeclaration"] = value;
		}
	}

	[ConfigurationProperty("DefunctSiloExpiration", DefaultValue = "10080")]
	[TypeConverter(typeof(TimeSpanMinutesConverter))]
	public TimeSpan DefunctSiloExpiration
	{
		get
		{
			return (TimeSpan)base["DefunctSiloExpiration"];
		}
		set
		{
			base["DefunctSiloExpiration"] = value;
		}
	}

	[ConfigurationProperty("DefunctSiloCleanupPeriod", DefaultValue = "10")]
	[TypeConverter(typeof(TimeSpanMinutesConverter))]
	public TimeSpan DefunctSiloCleanupPeriod
	{
		get
		{
			return (TimeSpan)base["DefunctSiloCleanupPeriod"];
		}
		set
		{
			base["DefunctSiloCleanupPeriod"] = value;
		}
	}

	protected override void InitializeAutoInitilize()
	{
		base.AutoInitialize = false;
	}

	public void Configure(ClusterMembershipOptions options)
	{
		options.set_ProbeTimeout(ProbeTimeout);
		options.set_IAmAliveTablePublishTimeout(IAmAliveTablePublishTimeout);
		options.set_TableRefreshTimeout(TableRefreshTimeout);
		options.set_MaxJoinAttemptTime(MaxJoinAttemptTime);
		options.set_NumProbedSilos(NumProbedSilos);
		options.set_NumMissedProbesLimit(NumMissedProbesLimit);
		options.set_DefunctSiloExpiration(DefunctSiloExpiration);
		options.set_DefunctSiloCleanupPeriod((TimeSpan?)DefunctSiloCleanupPeriod);
		options.set_NumVotesForDeathDeclaration(NumVotesForDeathDeclaration);
	}
}
