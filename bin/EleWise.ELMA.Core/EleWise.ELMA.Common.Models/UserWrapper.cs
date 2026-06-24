using System.Collections.Generic;
using System.Runtime.Serialization;
using EleWise.ELMA.Files;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Common.Models;

public sealed class UserWrapper : Entity
{
	private BinaryFile _003CPhoto_003Ek__BackingField;

	private UserStatus _003CStatus_003Ek__BackingField;

	private UserWrapper _003CReplacementUser_003Ek__BackingField;

	private System.Collections.Generic.IList<OrganizationItemWrapper> _003COrganizationItems_003Ek__BackingField;

	private System.Collections.Generic.IList<OrganizationItemWrapper> _003COrganizationGroups_003Ek__BackingField;

	public BinaryFile Photo
	{
		get
		{
			return _003CPhoto_003Ek__BackingField;
		}
		set
		{
			_003CPhoto_003Ek__BackingField = value;
		}
	}

	public UserStatus Status
	{
		get
		{
			return _003CStatus_003Ek__BackingField;
		}
		set
		{
			_003CStatus_003Ek__BackingField = value;
		}
	}

	public UserWrapper ReplacementUser
	{
		get
		{
			return _003CReplacementUser_003Ek__BackingField;
		}
		set
		{
			_003CReplacementUser_003Ek__BackingField = value;
		}
	}

	public System.Collections.Generic.IList<OrganizationItemWrapper> OrganizationItems
	{
		get
		{
			return _003COrganizationItems_003Ek__BackingField;
		}
		set
		{
			_003COrganizationItems_003Ek__BackingField = value;
		}
	}

	public System.Collections.Generic.IList<OrganizationItemWrapper> OrganizationGroups
	{
		get
		{
			return _003COrganizationGroups_003Ek__BackingField;
		}
		set
		{
			_003COrganizationGroups_003Ek__BackingField = value;
		}
	}

	[OnDeserialized]
	public void OnDeserialized(object raw)
	{
		OnDeserializedMethod(raw);
	}
}
