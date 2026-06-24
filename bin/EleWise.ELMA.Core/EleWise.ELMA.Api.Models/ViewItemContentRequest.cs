using System;
using Bridge;
using EleWise.ELMA.Api.Attributes;

namespace EleWise.ELMA.Api.Models;

[ObjectLiteral]
[SimpleSerialize]
public sealed class ViewItemContentRequest : ViewItemRequest
{
	private Guid _003CFormUid_003Ek__BackingField;

	private Guid _003CViewItemUid_003Ek__BackingField;

	public Guid FormUid
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _003CFormUid_003Ek__BackingField;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_003CFormUid_003Ek__BackingField = value;
		}
	}

	public Guid ViewItemUid
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _003CViewItemUid_003Ek__BackingField;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_003CViewItemUid_003Ek__BackingField = value;
		}
	}
}
