using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.UI.Models;

[FilterFor(typeof(ComponentMetadataItemHeader))]
public class ComponentMetadataItemHeaderFilter : Filter
{
	private string _name;

	private string _displayName;

	private DateTimeRange _creationDate;

	private Guid? _metadataTypeUid;

	private bool? _isPublished;

	private static ComponentMetadataItemHeaderFilter MaUDTnBWwIVH2w14cXK3;

	public virtual string Name
	{
		get
		{
			return _name;
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					_name = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public virtual string DisplayName
	{
		get
		{
			return _displayName;
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					_displayName = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public virtual DateTimeRange CreationDate
	{
		get
		{
			return _creationDate;
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					_creationDate = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public virtual Guid? MetadataTypeUid
	{
		get
		{
			return _metadataTypeUid;
		}
		set
		{
			_metadataTypeUid = value;
		}
	}

	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[CanBeNull]
	[Uid("7a10d073-4547-4ed9-be4f-353e011edfe5")]
	[CustomFilterProperty]
	[DisplayName("SR.M('Опубликовано')")]
	[BoolSettings(FieldName = "IsPublished")]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	public virtual bool? IsPublished
	{
		get
		{
			return _isPublished;
		}
		set
		{
			_isPublished = value;
		}
	}

	public ComponentMetadataItemHeaderFilter()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		AuJX7XBWHep45pNL7IV3();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void AuJX7XBWHep45pNL7IV3()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool cBSo95BW4ItKhDhAJrod()
	{
		return MaUDTnBWwIVH2w14cXK3 == null;
	}

	internal static ComponentMetadataItemHeaderFilter PuKPypBW6QGab8U2rQrF()
	{
		return MaUDTnBWwIVH2w14cXK3;
	}
}
