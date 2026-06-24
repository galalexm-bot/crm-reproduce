using System;
using Bridge;
using EleWise.ELMA.Core.Abstractions.Metadata.Models;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Extensions;

namespace EleWise.ELMA.Model.ViewModel;

[ObjectLiteral(/*Could not decode attribute arguments.*/)]
public sealed class ModelMetadata
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<object> _003C_003E9__0_0;

		internal object _003C_002Ector_003Eb__0_0()
		{
			return null;
		}
	}

	private readonly ModelMetadata _003CParent_003Ek__BackingField;

	private readonly ClassMetadata _003CMetadata_003Ek__BackingField;

	private Func<object> _003CGetModelFunc_003Ek__BackingField;

	private string[] _003CPrefix_003Ek__BackingField;

	private ModelInfo _003CModelInfo_003Ek__BackingField;

	private bool rootCalculated;

	private ModelMetadata root;

	public ModelMetadata Parent => _003CParent_003Ek__BackingField;

	public ClassMetadata Metadata => _003CMetadata_003Ek__BackingField;

	public object Model => GetModelFunc.Invoke();

	public Func<object> GetModelFunc
	{
		get
		{
			return _003CGetModelFunc_003Ek__BackingField;
		}
		set
		{
			_003CGetModelFunc_003Ek__BackingField = value;
		}
	}

	public string[] Prefix
	{
		get
		{
			return _003CPrefix_003Ek__BackingField;
		}
		set
		{
			_003CPrefix_003Ek__BackingField = value;
		}
	}

	public ModelInfo ModelInfo
	{
		get
		{
			return _003CModelInfo_003Ek__BackingField;
		}
		set
		{
			_003CModelInfo_003Ek__BackingField = value;
		}
	}

	public ModelMetadata(ModelMetadata parent, ClassMetadata metadata)
		: this(parent, metadata, () => null)
	{
	}

	public ModelMetadata(ModelMetadata parent, ClassMetadata metadata, Func<object> getModelFunc)
		: this(parent, metadata, getModelFunc, null)
	{
	}

	public ModelMetadata(ModelMetadata parent, ClassMetadata metadata, Func<object> getModelFunc, ModelInfo modelInfo)
	{
		_003CParent_003Ek__BackingField = parent;
		_003CMetadata_003Ek__BackingField = metadata;
		GetModelFunc = getModelFunc;
		ModelInfo = modelInfo;
	}

	public object GetModel(string expression, object defaultValue = null)
	{
		return Model.GetPlainPropertyValue(expression, defaultValue);
	}

	public void SetModel(string expression, object value)
	{
		Model?.SetPlainPropertyValue(expression, value);
	}

	internal ModelMetadata Root()
	{
		if (rootCalculated)
		{
			return root;
		}
		for (ModelMetadata parent = Parent; parent != null; parent = parent.Parent)
		{
			root = parent;
		}
		rootCalculated = true;
		return root;
	}
}
