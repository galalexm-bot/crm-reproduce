using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Web;
using EleWise.ELMA.Messaging.Email.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Runtime.Settings;
using EleWise.ELMA.Security.Cryptography;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.Messaging.Email;

public class EmailSettings : GlobalSettingsBase
{
	public const string PASSWORD_NOT_CHANGED = "($PASSWORD_NOT_CHANGED$)";

	public const string HtmlFooterFileUidString = "{799DD7A1-8A7E-4606-B368-58DCFEDF59E4}";

	public static Guid HtmlFooterFileUid = new Guid("{799DD7A1-8A7E-4606-B368-58DCFEDF59E4}");

	private string smtpPassword;

	[DisplayName(typeof(EmailSettings_SR), "P_Enabled")]
	public bool Enabled { get; set; }

	[DisplayName(typeof(EmailSettings_SR), "P_SmtpHost")]
	public string SmtpHost { get; set; }

	[DisplayName(typeof(EmailSettings_SR), "P_SmtpPort")]
	public int SmtpPort { get; set; }

	[DisplayName(typeof(EmailSettings_SR), "P_SmtpEncoding")]
	public string SmtpEncoding { get; set; }

	[DisplayName(typeof(EmailSettings_SR), "P_SmtpEnableSsl")]
	[Obsolete("use SmtpSSLType instead", true)]
	public bool SmtpEnableSsl
	{
		get
		{
			return SmtpSSLType != SSLType.None;
		}
		set
		{
			SmtpSSLType = (value ? ((SmtpPort != 587) ? SSLType.SSL : SSLType.TLS) : SSLType.None);
		}
	}

	[DisplayName(typeof(EmailSettings_SR), "P_SmtpSSLType")]
	public SSLType SmtpSSLType { get; set; }

	[DisplayName(typeof(EmailSettings_SR), "P_SmtpCredentials")]
	public bool SmtpCredentials { get; set; }

	[DisplayName(typeof(EmailSettings_SR), "P_SmtpUserName")]
	public string SmtpUserName { get; set; }

	[DisplayName(typeof(EmailSettings_SR), "P_SmtpPassword")]
	public string SmtpPassword
	{
		get
		{
			return smtpPassword;
		}
		set
		{
			if (value != "($PASSWORD_NOT_CHANGED$)")
			{
				smtpPassword = value;
			}
		}
	}

	[Required(true)]
	[RequiredField]
	[DisplayName(typeof(EmailSettings_SR), "P_SenderName")]
	public string SenderName { get; set; }

	[Required(true)]
	[RequiredField]
	[DisplayName(typeof(EmailSettings_SR), "P_SenderEMail")]
	public string SenderEMail { get; set; }

	[DisplayName(typeof(EmailSettings_SR), "P_SubjectPrefix")]
	public string SubjectPrefix { get; set; }

	[DisplayName(typeof(EmailSettings_SR), "P_BodyFooterSeparator")]
	public string BodyFooterSeparator { get; set; }

	[StringSettings(MultiLine = true)]
	[DisplayName(typeof(EmailSettings_SR), "P_BodyFooter")]
	public string BodyFooter { get; set; }

	[DisplayName(typeof(EmailSettings_SR), "P_Timeout")]
	[Int32Settings(MinValue = 15, FieldName = "Timeout")]
	public int Timeout { get; set; }

	[DisplayName(typeof(EmailSettings_SR), "P_MaxAttachmensSize")]
	[Int32Settings(MinValue = 0, MaxValue = 100, FieldName = "MaxAttachmensSize")]
	public int MaxAttachmensSize { get; set; }

	[BoolSettings(DisplayType = BoolDisplayType.RadioButtons)]
	[DisplayName(typeof(EmailSettings_SR), "P_IsHtmlFooter")]
	public bool IsHtmlFooter { get; set; }

	public string HtmlBodyFooterString { get; set; }

	[DisplayName(typeof(EmailSettings_SR), "P_HtmlBodyFooter")]
	public HtmlString HtmlBodyFooter
	{
		get
		{
			return new HtmlString(HtmlBodyFooterString);
		}
		set
		{
			HtmlBodyFooterString = value.ToString();
		}
	}

	[BoolSettings(DisplayType = BoolDisplayType.RadioButtons)]
	[DisplayName(typeof(EmailSettings_SR), "P_IncludeHeaderInBody")]
	public bool IncludeHeaderInBody { get; set; }

	public EmailSettings()
	{
		Enabled = false;
		SmtpHost = string.Empty;
		SmtpPort = 25;
		SmtpSSLType = SSLType.None;
		SenderName = SR.M("ELMA");
		SenderEMail = string.Empty;
		SubjectPrefix = string.Format("[{0}]", SR.M("[ELMA]"));
		BodyFooterSeparator = "--";
		BodyFooter = SR.T("Это сообщение автоматически сформировано системой ELMA");
		SmtpCredentials = false;
		SmtpUserName = string.Empty;
		SmtpEncoding = "UTF-8";
		Timeout = 15;
		MaxAttachmensSize = 40;
		IsHtmlFooter = false;
		IncludeHeaderInBody = true;
	}

	public Encoding GetEmailEncoding()
	{
		return EmailEncoding.GetEncoding(SmtpEncoding);
	}

	public FooterFileModel GetFooterFileList()
	{
		string bLOB = DataAccessManager.BLOBManager.GetBLOB<string>(HtmlFooterFileUid, "HtmlFooterFile");
		if (string.IsNullOrEmpty(bLOB))
		{
			return null;
		}
		return ClassSerializationHelper.DeserializeObjectByJson<FooterFileModel>(bLOB);
	}

	protected override IDictionary<string, string> GetStorageValue(PropertyInfo property)
	{
		IDictionary<string, string> storageValue = base.GetStorageValue(property);
		string name = property.Name;
		if (name == "SmtpPassword")
		{
			return new Dictionary<string, string> { 
			{
				property.Name,
				ElmaCryptoProvider.EncryptPassword(SmtpPassword)
			} };
		}
		return storageValue;
	}

	protected override void SetStorageValue(PropertyInfo property, IDictionary<string, string> values)
	{
		string name = property.Name;
		if (name == "SmtpPassword")
		{
			if (values.TryGetValue(property.Name, out var value))
			{
				string text2 = (SmtpPassword = ElmaCryptoProvider.DecryptPassword(value));
			}
		}
		else
		{
			base.SetStorageValue(property, values);
		}
	}

	protected override bool SkipProperty(PropertyInfo property)
	{
		if (!(property.Name == "SmtpEnableSsl") && !(property.Name == "HtmlBodyFooter"))
		{
			return base.SkipProperty(property);
		}
		return true;
	}
}
