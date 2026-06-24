using System.Runtime.Serialization;

namespace EleWise.ELMA.Documents.API.Models;

[DataContract]
public class UpdateAgentInfo
{
	private bool _needUpdate;

	private bool _error;

	[DataMember]
	public bool NeedUpdate
	{
		get
		{
			if (!_error)
			{
				return _needUpdate;
			}
			return false;
		}
		set
		{
			_needUpdate = value;
		}
	}

	[DataMember]
	public bool Error
	{
		get
		{
			return _error;
		}
		set
		{
			_error = value;
		}
	}

	[DataMember]
	public string LinkWin { get; set; }

	[DataMember]
	public string LinkMac { get; set; }

	[DataMember]
	public string LinkLinux { get; set; }
}
