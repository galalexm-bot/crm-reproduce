using System;
using System.Xml.Serialization;
using EleWise.ELMA.Documents.Metadata;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Types.Helpers;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Documents.Models;

[Serializable]
[XmlRoot("SendInfo")]
public class SendInfo
{
	[NonSerialized]
	private RelativeDateTime _sendDate;

	[NonSerialized]
	private SendStatus? _sendStatus;

	[NonSerialized]
	private IUser _sendUser;

	[NonSerialized]
	private ISendDocumentType _sendDocumentType;

	[DisplayName(typeof(__Resources_ISendableDocument), "P_SendStatus_DisplayName")]
	[XmlIgnore]
	public SendStatus? SendStatus
	{
		get
		{
			if (SendStatusVal < 0)
			{
				return null;
			}
			return (SendStatus)SendStatusVal;
		}
		set
		{
			if (value.HasValue)
			{
				SendStatusVal = Convert.ToInt32(value);
			}
			else
			{
				SendStatusVal = -1;
			}
		}
	}

	[XmlElement("SendStatus")]
	public int SendStatusVal { get; set; }

	[DisplayName(typeof(__Resources_ISendableDocument), "P_SendDate_DisplayName")]
	[XmlIgnore]
	public RelativeDateTime SendDate
	{
		get
		{
			return _sendDate;
		}
		set
		{
			_sendDate = value;
		}
	}

	[XmlElement("RelativeDateTimeRangeWrapper")]
	public RelativeDateTimeWrapper SendDateWrapper
	{
		get
		{
			if (SendDate != null)
			{
				return new RelativeDateTimeWrapper(SendDate);
			}
			return null;
		}
		set
		{
			if (value != null)
			{
				SendDate = new RelativeDateTime
				{
					IsRelative = value.IsRelative,
					DateTimeRange = ((value.DateTimeRange != null) ? new DateTimeRange(value.DateTimeRange.From.Value, value.DateTimeRange.To.Value) : new DateTimeRange(null, null)),
					RelativeFrom = value.RelativeFrom,
					RelativeTo = value.RelativeTo
				};
			}
		}
	}

	[DisplayName(typeof(__Resources_ISendableDocument), "P_SendUser_DisplayName")]
	[XmlIgnore]
	public IUser SendUser
	{
		get
		{
			if (_sendUser == null && SendUserId > 0)
			{
				_sendUser = UserManager.Instance.LoadOrNull(SendUserId);
			}
			return _sendUser;
		}
		set
		{
			_sendUser = value;
			SendUserId = value?.Id ?? 0;
		}
	}

	[XmlElement("SendUser")]
	public long SendUserId { get; set; }

	[DisplayName(typeof(__Resources_ISendableDocument), "P_SendDocumentType_DisplayName")]
	[XmlIgnore]
	public ISendDocumentType SendDocumentType
	{
		get
		{
			if (_sendDocumentType == null && SendDocumentTypeId > 0)
			{
				_sendDocumentType = EntityManager<ISendDocumentType>.Instance.LoadOrNull(SendDocumentTypeId);
			}
			return _sendDocumentType;
		}
		set
		{
			_sendDocumentType = value;
			SendDocumentTypeId = value?.Id ?? 0;
		}
	}

	[XmlElement("SendDocumentType")]
	public long SendDocumentTypeId { get; set; }

	[DisplayName(typeof(__Resources_ISendableDocument), "P_SendNumber_DisplayName")]
	[XmlElement("SendNumber")]
	public string SendNumber { get; set; }

	public SendInfo()
	{
		SendStatusVal = -1;
	}
}
