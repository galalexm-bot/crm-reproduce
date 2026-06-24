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

public abstract class FullTextPropertyDescriptor : IFullTextPropertyMappingDescriptor, IFullTextPropertyDescriptor
{
	protected Func<IPropertyMetadata, string> ValueFieldName;

	protected Func<IPropertyMetadata, string> SortFieldName;

	private static FullTextPropertyDescriptor qaqI7RGVoQHcm8SOA6WD;

	protected ISerializableTypeDescriptor TypeDescriptor
	{
		[CompilerGenerated]
		get
		{
			return _003CTypeDescriptor_003Ek__BackingField;
		}
		[CompilerGenerated]
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
					_003CTypeDescriptor_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public virtual bool IsSupportedIndexing => true;

	public virtual bool IsSupportedSearchInIndex => true;

	public virtual bool IsSupportedFullTextSearchInIndex => false;

	protected FullTextPropertyDescriptor(ISerializableTypeDescriptor typeDescriptor)
	{
		//Discarded unreachable code: IL_008e, IL_0093
		SingletonReader.JJCZtPuTvSt();
		ValueFieldName = (IPropertyMetadata propMd) => (string)_003C_003Ec.aEC9vHvYTGD0XZxgSFM4(_003C_003Ec.OxQZwIvYKc76NaucHxDl(0x53CACA3 ^ 0x53DEC47), _003C_003Ec.nljfwavYXjAnjaaoYFHF(propMd).ToString().ToLower(), _003C_003Ec.OxQZwIvYKc76NaucHxDl(0x6DC147B0 ^ 0x6DC10EC6));
		SortFieldName = (IPropertyMetadata propMd) => (string)_003C_003Ec.aEC9vHvYTGD0XZxgSFM4(_003C_003Ec.OxQZwIvYKc76NaucHxDl(-1088304168 ^ -1088386244), _003C_003Ec.nljfwavYXjAnjaaoYFHF(propMd).ToString(), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -104915070));
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				TypeDescriptor = typeDescriptor;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public virtual FieldIndexList GetIndexField(object obj, IPropertyMetadata propMd, bool reindex)
	{
		return new FieldIndexList();
	}

	public virtual FieldListItem GetSearchField(object value, IPropertyMetadata propMd)
	{
		return new FieldListItem(ValueFieldName(propMd), string.Empty);
	}

	public virtual FilterListItem GetFilterField(object value, IPropertyMetadata propMd, IEntityFilter filter)
	{
		return null;
	}

	public virtual List<string> GetReturnField(IPropertyMetadata propMd)
	{
		return new List<string> { ValueFieldName(propMd) };
	}

	public virtual SortListItem GetSortField(IPropertyMetadata propMd)
	{
		return null;
	}

	public virtual void SetIndexField(object obj, object value, IPropertyMetadata propMd)
	{
	}

	public virtual void SetEmptyIndexField(object obj, IPropertyMetadata propMd, string fieldName)
	{
	}

	public virtual FieldIndexList GetMappingField(IPropertyMetadata propMd)
	{
		return new FieldIndexList();
	}

	internal static bool pDakIMGVboaoqPLVBlRw()
	{
		return qaqI7RGVoQHcm8SOA6WD == null;
	}

	internal static FullTextPropertyDescriptor kTMB9nGVhgi245bdDZel()
	{
		return qaqI7RGVoQHcm8SOA6WD;
	}
}
