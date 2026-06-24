using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Core.Diagnostics;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.Model;

public class TreeModel : DropDownItem, ITreeModel
{
	private sealed class _003C_003Ec__DisplayClass3_0<T>
	{
		public Func<T, string> key;

		public Func<T, string> parentKey;

		public Func<T, string> name;

		internal TreeModel _003CMap_003Eb__0(T item)
		{
			return new TreeModel(key.Invoke(item), parentKey?.Invoke(item), name.Invoke(item));
		}
	}

	private readonly string _003CParentKey_003Ek__BackingField;

	public string ParentKey => _003CParentKey_003Ek__BackingField;

	public TreeModel(string key, string value)
		: base(key, value)
	{
	}

	public TreeModel(string stringValue)
		: base(stringValue)
	{
	}

	public TreeModel(string key, string value, string parentKey)
		: this(key, value)
	{
		_003CParentKey_003Ek__BackingField = parentKey;
	}

	public static System.Collections.Generic.IEnumerable<ITreeModel> Map<T>(System.Collections.Generic.IEnumerable<T> source, Func<T, string> key, Func<T, string> name, Func<T, string> parentKey = null)
	{
		_003C_003Ec__DisplayClass3_0<T> CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass3_0<T>();
		CS_0024_003C_003E8__locals0.key = key;
		CS_0024_003C_003E8__locals0.parentKey = parentKey;
		CS_0024_003C_003E8__locals0.name = name;
		Contract.ArgumentNotNull(CS_0024_003C_003E8__locals0.key, "key");
		Contract.ArgumentNotNull(CS_0024_003C_003E8__locals0.name, "name");
		if (source == null)
		{
			return (System.Collections.Generic.IEnumerable<ITreeModel>)Enumerable.Empty<ITreeModel>();
		}
		return (System.Collections.Generic.IEnumerable<ITreeModel>)Enumerable.Select<T, TreeModel>(source, (Func<T, TreeModel>)((T item) => new TreeModel(CS_0024_003C_003E8__locals0.key.Invoke(item), CS_0024_003C_003E8__locals0.parentKey?.Invoke(item), CS_0024_003C_003E8__locals0.name.Invoke(item))));
	}
}
