using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Security;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.Documents.Types;

[Serializable]
public class DocumentFolderSettings : EntitySettings
{
	[XmlElement("SelectOnlyEdit")]
	[DefaultValue(false)]
	public bool SelectOnlyEdit
	{
		get
		{
			return FolderPermissionUid.Contains("55231435-3179-4B96-A9BC-AA23CA670150");
		}
		set
		{
			if (value)
			{
				AddPermission("55231435-3179-4B96-A9BC-AA23CA670150");
			}
			else
			{
				RemovePermission("55231435-3179-4B96-A9BC-AA23CA670150");
			}
		}
	}

	[XmlElement("SelectOnlyCreate")]
	[DefaultValue(false)]
	public bool SelectOnlyCreate
	{
		get
		{
			return FolderPermissionUid.Contains("8D44697C-507F-403B-97A8-53FB6A13D421");
		}
		set
		{
			if (value)
			{
				AddPermission("8D44697C-507F-403B-97A8-53FB6A13D421");
			}
			else
			{
				RemovePermission("8D44697C-507F-403B-97A8-53FB6A13D421");
			}
		}
	}

	[XmlIgnore]
	public List<string> FolderPermissionUid { get; set; }

	[XmlElement("FolderPermissions")]
	public string SerializedInfos
	{
		get
		{
			if (FolderPermissionUid == null)
			{
				return string.Empty;
			}
			return string.Join(";", FolderPermissionUid.Select((string v) => ClassSerializationHelper.SerializeObjectByXml(v)));
		}
		set
		{
			if (string.IsNullOrEmpty(value))
			{
				FolderPermissionUid = new List<string>();
				return;
			}
			string[] source = value.Split(new string[1] { ";" }, StringSplitOptions.RemoveEmptyEntries);
			FolderPermissionUid = source.Select((string v) => ClassSerializationHelper.DeserializeObjectByXml<string>(v)).ToList();
		}
	}

	public void AddPermission(Permission permission)
	{
		AddPermission(permission.Id.ToString());
	}

	public void AddPermission(string permissionUid)
	{
		if (FolderPermissionUid == null)
		{
			FolderPermissionUid = new List<string>();
		}
		if (!FolderPermissionUid.Contains(permissionUid))
		{
			FolderPermissionUid.Add(permissionUid);
		}
	}

	public void RemovePermission(Permission permission)
	{
		RemovePermission(permission.Id.ToString());
	}

	public void RemovePermission(string permissionUid)
	{
		if (FolderPermissionUid == null)
		{
			FolderPermissionUid = new List<string>();
		}
		if (FolderPermissionUid.Contains(permissionUid))
		{
			FolderPermissionUid.Remove(permissionUid);
		}
	}

	public DocumentFolderSettings()
	{
	}

	protected DocumentFolderSettings(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
