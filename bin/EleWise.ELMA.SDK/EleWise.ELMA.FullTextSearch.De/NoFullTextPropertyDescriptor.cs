using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EleWise.ELMA.FullTextSearch.Model;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.FullTextSearch.Descriptors;

public sealed class NoFullTextPropertyDescriptor : IFullTextPropertyMappingDescriptor, IFullTextPropertyDescriptor
{
	private static NoFullTextPropertyDescriptor zlEcvgG8iRWsGbH6rBfi;

	public ISerializableTypeDescriptor TypeDescriptor
	{
		[CompilerGenerated]
		get
		{
			return _003CTypeDescriptor_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
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
					_003CTypeDescriptor_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public bool IsSupportedIndexing => false;

	public bool IsSupportedSearchInIndex => false;

	public bool IsSupportedFullTextSearchInIndex => false;

	public FieldIndexList GetIndexField(object obj, IPropertyMetadata propMd, bool reindex)
	{
		return new FieldIndexList();
	}

	public FieldListItem GetSearchField(object value, IPropertyMetadata propMd)
	{
		return new FieldListItem((string)MpKrVWG8TZuHII8Ljp31(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1859097199), Jjb45yG8Xe53xn5T2vOP(I9b4SpG8KAO8J3OIqF4P(propMd).ToString())), string.Empty);
	}

	public FilterListItem GetFilterField(object value, IPropertyMetadata propMd, IEntityFilter filter)
	{
		return null;
	}

	public List<string> GetReturnField(IPropertyMetadata propMd)
	{
		return null;
	}

	public SortListItem GetSortField(IPropertyMetadata propMd)
	{
		return null;
	}

	public void SetIndexField(object obj, object value, IPropertyMetadata propMd)
	{
	}

	public void SetEmptyIndexField(object obj, IPropertyMetadata propMd, string fieldName)
	{
	}

	public FieldIndexList GetMappingField(IPropertyMetadata propMd)
	{
		return new FieldIndexList();
	}

	public NoFullTextPropertyDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool YbBSB6G8RJ95OGrWnAVx()
	{
		return zlEcvgG8iRWsGbH6rBfi == null;
	}

	internal static NoFullTextPropertyDescriptor wLk9K4G8q5PM6y8qiqsh()
	{
		return zlEcvgG8iRWsGbH6rBfi;
	}

	internal static Guid I9b4SpG8KAO8J3OIqF4P(object P_0)
	{
		return ((IMetadata)P_0).Uid;
	}

	internal static object Jjb45yG8Xe53xn5T2vOP(object P_0)
	{
		return ((string)P_0).ToLower();
	}

	internal static object MpKrVWG8TZuHII8Ljp31(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}
}
