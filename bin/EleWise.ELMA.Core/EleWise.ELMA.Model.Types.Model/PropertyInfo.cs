using Bridge;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Model.Types.Models;

[ObjectLiteral]
public sealed class PropertyInfo
{
	private bool _003CShouldSerialize_003Ek__BackingField;

	private bool _003CNullable_003Ek__BackingField;

	private PropertyInfoExpression _003CExpression_003Ek__BackingField;

	private IPropertyMetadata _003CPropertyMetadata_003Ek__BackingField;

	private string _003CSubTypeUid_003Ek__BackingField;

	private object _003CInitValue_003Ek__BackingField;

	public bool ShouldSerialize
	{
		get
		{
			return _003CShouldSerialize_003Ek__BackingField;
		}
		set
		{
			_003CShouldSerialize_003Ek__BackingField = value;
		}
	}

	public bool Nullable
	{
		get
		{
			return _003CNullable_003Ek__BackingField;
		}
		set
		{
			_003CNullable_003Ek__BackingField = value;
		}
	}

	public PropertyInfoExpression Expression
	{
		get
		{
			return _003CExpression_003Ek__BackingField;
		}
		set
		{
			_003CExpression_003Ek__BackingField = value;
		}
	}

	public IPropertyMetadata PropertyMetadata
	{
		get
		{
			return _003CPropertyMetadata_003Ek__BackingField;
		}
		set
		{
			_003CPropertyMetadata_003Ek__BackingField = value;
		}
	}

	public string SubTypeUid
	{
		get
		{
			return _003CSubTypeUid_003Ek__BackingField;
		}
		set
		{
			_003CSubTypeUid_003Ek__BackingField = value;
		}
	}

	public object InitValue
	{
		get
		{
			return _003CInitValue_003Ek__BackingField;
		}
		set
		{
			_003CInitValue_003Ek__BackingField = value;
		}
	}
}
