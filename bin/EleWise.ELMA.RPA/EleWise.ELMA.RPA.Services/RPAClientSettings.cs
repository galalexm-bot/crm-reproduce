using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Runtime.Settings;

namespace EleWise.ELMA.RPA.Services;

public class RPAClientSettings : GlobalSettingsBase
{
	[Obsolete("Не используется")]
	public Uri ProcessRepositoryServiceAddress
	{
		get
		{
			if (ServerAddress == null)
			{
				return null;
			}
			return new UriBuilder(ServerAddress)
			{
				Port = ProcessRepositoryServicePort
			}.Uri;
		}
	}

	[Obsolete("Не используется")]
	public Uri TaskServiceAddress
	{
		get
		{
			if (ServerAddress == null)
			{
				return null;
			}
			return new UriBuilder(ServerAddress)
			{
				Port = TaskServicePort
			}.Uri;
		}
	}

	[Required(true)]
	[RequiredField]
	[DisplayName(typeof(RPAClientSettings_SR), "P_AuthToken")]
	public Guid AuthToken { get; set; }

	[Required(true)]
	[RequiredField]
	[DisplayName(typeof(RPAClientSettings_SR), "P_ServerAddress")]
	public Uri ServerAddress { get; set; }

	[Required(true)]
	[RequiredField]
	[DisplayName(typeof(RPAClientSettings_SR), "P_ProcessRepositoryServicePort")]
	[Obsolete("Не используется")]
	public int ProcessRepositoryServicePort { get; set; } = 8088;


	[Required(true)]
	[RequiredField]
	[DisplayName(typeof(RPAClientSettings_SR), "P_TaskServicePort")]
	[Obsolete("Не используется")]
	public int TaskServicePort { get; set; } = 8081;


	[DisplayName(typeof(RPAClientSettings_SR), "P_SystemName")]
	public string SystemName { get; set; } = "ELMA";


	[Required(true)]
	[RequiredField]
	[DisplayName(typeof(RPAClientSettings_SR), "P_PollingTimer")]
	public int PollingTimer { get; set; } = 1;

}
