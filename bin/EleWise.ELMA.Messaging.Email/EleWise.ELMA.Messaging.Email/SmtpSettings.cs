using System;

namespace EleWise.ELMA.Messaging.Email;

public class SmtpSettings
{
	private string userName;

	public string Host { get; set; }

	public int Port { get; set; }

	public bool NeedCredentials { get; set; }

	public string UserName
	{
		get
		{
			return userName;
		}
		set
		{
			userName = value;
			NeedCredentials = true;
		}
	}

	public string Password { get; set; }

	public SSLType SSLType { get; set; }

	public int Timeout { get; set; }

	internal int ConnectTimeout { get; set; }

	public int MaxAttachmensSize { get; set; }

	internal bool NecessarilySendFiles { get; set; }

	internal TimeSpan SendTime { get; set; }

	public SmtpSettings()
	{
		Timeout = 15;
		ConnectTimeout = 30;
		MaxAttachmensSize = 40;
	}

	public SmtpSettings(string host, int port)
		: this()
	{
		Host = host;
		Port = port;
	}

	public SmtpSettings(string host, int port, SSLType sslType, string userName, string password)
		: this()
	{
		Host = host;
		Port = port;
		SSLType = sslType;
		UserName = userName;
		Password = password;
	}

	internal SmtpSettings(EmailSettings settings)
		: this()
	{
		Host = settings.SmtpHost;
		Port = settings.SmtpPort;
		UserName = settings.SmtpUserName;
		Password = settings.SmtpPassword;
		NeedCredentials = settings.SmtpCredentials;
		SSLType = settings.SmtpSSLType;
		Timeout = settings.Timeout;
		MaxAttachmensSize = settings.MaxAttachmensSize;
	}
}
