using System;
using EleWise.ELMA.Core;

namespace EleWise.ELMA.Model.Views;

public class ListViewItemAddingException : System.Exception
{
	private Guid _003CParentUid_003Ek__BackingField;

	private Guid _003CItemUid_003Ek__BackingField;

	public Guid ParentUid
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _003CParentUid_003Ek__BackingField;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_003CParentUid_003Ek__BackingField = value;
		}
	}

	public Guid ItemUid
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _003CItemUid_003Ek__BackingField;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_003CItemUid_003Ek__BackingField = value;
		}
	}

	public override string Message => SR.T("Ошибка при добавлении элемента представления {0} в {1}", ItemUid, ParentUid);

	public ListViewItemAddingException(ViewItem parent, ViewItem item)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		ParentUid = parent.Uid;
		ItemUid = item.Uid;
	}
}
