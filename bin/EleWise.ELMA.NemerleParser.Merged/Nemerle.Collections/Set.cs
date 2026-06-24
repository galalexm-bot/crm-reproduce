using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Nemerle.Builtins;
using Nemerle.Core;
using Nemerle.Internal;

namespace Nemerle.Collections;

[Nemerle.Internal.Extension]
[DebuggerNonUserCode]
[Nemerle.Internal.Extension]
[DebuggerDisplay("Count = {Count}: {ToString()}")]
public class Set<T> : IEnumerable, IEnumerable<T>, System.Collections.Generic.ICollection<T>, IComparable<Set<T>>
{
	private sealed class _N_closureOf__ctor_27098
	{
		internal int _N_size_27105;

		internal Set<T> _N__N_closurised_this_ptr_27103;

		internal _N_closureOf__ctor_27098()
		{
		}
	}

	private sealed class _N__N_lambda__27090__27107 : Function<T, TwoThreeTree.Node<T>, TwoThreeTree.Node<T>>
	{
		[SpecialName]
		private _N_closureOf__ctor_27098 _N__ctor_closure_27111;

		public _N__N_lambda__27090__27107(_N_closureOf__ctor_27098 _N__ctor_closure_27111)
		{
			this._N__ctor_closure_27111 = _N__ctor_closure_27111;
		}

		[SpecialName]
		public sealed override TwoThreeTree.Node<T> apply(T value, TwoThreeTree.Node<T> tree)
		{
			return tree.Insert(value, _N__ctor_closure_27111._N__N_closurised_this_ptr_27103._cmp, TwoThreeTree.InsertOptions.ThrowIfDuplicate, ref _N__ctor_closure_27111._N_size_27105);
		}
	}

	private sealed class _N_closureOf_RemoveRange_27157
	{
		internal int _N_size_27164;

		internal Set<T> _N__N_closurised_this_ptr_27162;

		internal _N_closureOf_RemoveRange_27157()
		{
		}
	}

	private sealed class _N__N_lambda__27148__27166 : Function<T, TwoThreeTree.Node<T>, TwoThreeTree.Node<T>>
	{
		[SpecialName]
		private _N_closureOf_RemoveRange_27157 _N_RemoveRange_closure_27170;

		public _N__N_lambda__27148__27166(_N_closureOf_RemoveRange_27157 _N_RemoveRange_closure_27170)
		{
			this._N_RemoveRange_closure_27170 = _N_RemoveRange_closure_27170;
		}

		[SpecialName]
		public sealed override TwoThreeTree.Node<T> apply(T value, TwoThreeTree.Node<T> tree)
		{
			return tree.Delete(value, _N_RemoveRange_closure_27170._N__N_closurised_this_ptr_27162._cmp, TwoThreeTree.DeleteOptions.IgnoreMissed, ref _N_RemoveRange_closure_27170._N_size_27164);
		}
	}

	private sealed class _N_closureOf_RemoveList_27187
	{
		internal int _N_size_27194;

		internal Set<T> _N__N_closurised_this_ptr_27192;

		internal _N_closureOf_RemoveList_27187()
		{
		}
	}

	private sealed class _N__N_lambda__27178__27196 : Function<T, TwoThreeTree.Node<T>, TwoThreeTree.Node<T>>
	{
		[SpecialName]
		private _N_closureOf_RemoveList_27187 _N_RemoveList_closure_27200;

		public _N__N_lambda__27178__27196(_N_closureOf_RemoveList_27187 _N_RemoveList_closure_27200)
		{
			this._N_RemoveList_closure_27200 = _N_RemoveList_closure_27200;
		}

		[SpecialName]
		public sealed override TwoThreeTree.Node<T> apply(T value, TwoThreeTree.Node<T> tree)
		{
			return tree.Delete(value, _N_RemoveList_closure_27200._N__N_closurised_this_ptr_27192._cmp, TwoThreeTree.DeleteOptions.IgnoreMissed, ref _N_RemoveList_closure_27200._N_size_27194);
		}
	}

	private sealed class _N_closureOf_ReplaceRange_27223
	{
		internal int _N_size_27230;

		internal Set<T> _N__N_closurised_this_ptr_27228;

		internal _N_closureOf_ReplaceRange_27223()
		{
		}
	}

	private sealed class _N__N_lambda__27214__27232 : Function<T, TwoThreeTree.Node<T>, TwoThreeTree.Node<T>>
	{
		[SpecialName]
		private _N_closureOf_ReplaceRange_27223 _N_ReplaceRange_closure_27236;

		public _N__N_lambda__27214__27232(_N_closureOf_ReplaceRange_27223 _N_ReplaceRange_closure_27236)
		{
			this._N_ReplaceRange_closure_27236 = _N_ReplaceRange_closure_27236;
		}

		[SpecialName]
		public sealed override TwoThreeTree.Node<T> apply(T value, TwoThreeTree.Node<T> tree)
		{
			return tree.Insert(value, _N_ReplaceRange_closure_27236._N__N_closurised_this_ptr_27228._cmp, TwoThreeTree.InsertOptions.Replace, ref _N_ReplaceRange_closure_27236._N_size_27230);
		}
	}

	private sealed class _N_closureOf_ReplaceList_27253
	{
		internal int _N_size_27260;

		internal Set<T> _N__N_closurised_this_ptr_27258;

		internal _N_closureOf_ReplaceList_27253()
		{
		}
	}

	private sealed class _N__N_lambda__27244__27262 : Function<T, TwoThreeTree.Node<T>, TwoThreeTree.Node<T>>
	{
		[SpecialName]
		private _N_closureOf_ReplaceList_27253 _N_ReplaceList_closure_27266;

		public _N__N_lambda__27244__27262(_N_closureOf_ReplaceList_27253 _N_ReplaceList_closure_27266)
		{
			this._N_ReplaceList_closure_27266 = _N_ReplaceList_closure_27266;
		}

		[SpecialName]
		public sealed override TwoThreeTree.Node<T> apply(T value, TwoThreeTree.Node<T> tree)
		{
			return tree.Insert(value, _N_ReplaceList_closure_27266._N__N_closurised_this_ptr_27258._cmp, TwoThreeTree.InsertOptions.Replace, ref _N_ReplaceList_closure_27266._N_size_27260);
		}
	}

	private sealed class _N_closureOf_Iter_27298
	{
		internal FunctionVoid<T> _N_fn_27303;

		internal _N_closureOf_Iter_27298()
		{
		}
	}

	private sealed class _N__N_lambda__27289__27305 : Function<T, object, object>
	{
		[SpecialName]
		private _N_closureOf_Iter_27298 _N_Iter_closure_27309;

		public _N__N_lambda__27289__27305(_N_closureOf_Iter_27298 _N_Iter_closure_27309)
		{
			this._N_Iter_closure_27309 = _N_Iter_closure_27309;
		}

		[SpecialName]
		public sealed override object apply(T value, object _N_wildcard_27288)
		{
			_N_Iter_closure_27309._N_fn_27303.apply_void(value);
			return null;
		}
	}

	private sealed class _N_closureOf_IterLeft_27326
	{
		internal FunctionVoid<T> _N_fn_27331;

		internal _N_closureOf_IterLeft_27326()
		{
		}
	}

	private sealed class _N__N_lambda__27317__27333 : Function<T, object, object>
	{
		[SpecialName]
		private _N_closureOf_IterLeft_27326 _N_IterLeft_closure_27337;

		public _N__N_lambda__27317__27333(_N_closureOf_IterLeft_27326 _N_IterLeft_closure_27337)
		{
			this._N_IterLeft_closure_27337 = _N_IterLeft_closure_27337;
		}

		[SpecialName]
		public sealed override object apply(T value, object _N_wildcard_27316)
		{
			_N_IterLeft_closure_27337._N_fn_27331.apply_void(value);
			return null;
		}
	}

	private sealed class _N_closureOf_IterRight_27354
	{
		internal FunctionVoid<T> _N_fn_27359;

		internal _N_closureOf_IterRight_27354()
		{
		}
	}

	private sealed class _N__N_lambda__27345__27361 : Function<T, object, object>
	{
		[SpecialName]
		private _N_closureOf_IterRight_27354 _N_IterRight_closure_27365;

		public _N__N_lambda__27345__27361(_N_closureOf_IterRight_27354 _N_IterRight_closure_27365)
		{
			this._N_IterRight_closure_27365 = _N_IterRight_closure_27365;
		}

		[SpecialName]
		public sealed override object apply(T value, object _N_wildcard_27344)
		{
			_N_IterRight_closure_27365._N_fn_27359.apply_void(value);
			return null;
		}
	}

	private sealed class _N_closureOf_CopyTo_27466
	{
		internal T[] _N_arr_27471;

		internal _N_closureOf_CopyTo_27466()
		{
		}
	}

	private sealed class _N_copyOne__27473 : Function<T, int, int>
	{
		[SpecialName]
		private _N_closureOf_CopyTo_27466 _N_CopyTo_closure_27477;

		public _N_copyOne__27473(_N_closureOf_CopyTo_27466 _N_CopyTo_closure_27477)
		{
			this._N_CopyTo_closure_27477 = _N_CopyTo_closure_27477;
		}

		[SpecialName]
		public sealed override int apply(T value, int arrayIndex)
		{
			_N_CopyTo_closure_27477._N_arr_27471[arrayIndex] = value;
			return checked(arrayIndex + 1);
		}
	}

	private sealed class _N_closureOf_Equals_27513
	{
		internal Set<T> _N_that_27518;

		internal _N_closureOf_Equals_27513()
		{
		}
	}

	private sealed class _N__N_lambda__27506__27526 : Function<T, bool>
	{
		[SpecialName]
		private _N_closureOf_Equals_27513 _N_Equals_closure_27530;

		public _N__N_lambda__27506__27526(_N_closureOf_Equals_27513 _N_Equals_closure_27530)
		{
			this._N_Equals_closure_27530 = _N_Equals_closure_27530;
		}

		[SpecialName]
		public sealed override bool apply(T _N__27505)
		{
			return _N_Equals_closure_27530._N_that_27518.Contains(_N__27505);
		}
	}

	private sealed class _N__N_lambda__27709__27716 : Function<Set<T>, Set<T>, Set<T>>
	{
		[SpecialName]
		public static readonly _N__N_lambda__27709__27716 Instance = new _N__N_lambda__27709__27716();

		[SpecialName]
		public sealed override Set<T> apply(Set<T> e, Set<T> s)
		{
			return s.Sum(e);
		}
	}

	private sealed class _N__N_lambda__27729__27736 : Function<Set<T>, Set<T>, Set<T>>
	{
		[SpecialName]
		public static readonly _N__N_lambda__27729__27736 Instance = new _N__N_lambda__27729__27736();

		[SpecialName]
		public sealed override Set<T> apply(Set<T> e, Set<T> s)
		{
			return s.Sum(e);
		}
	}

	private readonly TwoThreeTree.Node<T> _tree;

	private readonly Function<T, T, int> _cmp;

	private readonly int _size;

	public bool this[T value] => Contains(value);

	public bool IsEmpty => _size == 0;

	public bool IsReadOnly => true;

	public int Count => _size;

	public Set()
		: this(0, (TwoThreeTree.Node<T>)TwoThreeTree.Node<T>.Leaf._N_constant_object, NemerleCollectionsComparer.Comparer<T>.Default)
	{
	}

	public Set(Function<T, T, int> cmp)
		: this(0, (TwoThreeTree.Node<T>)TwoThreeTree.Node<T>.Leaf._N_constant_object, cmp)
	{
	}

	public Set(IEnumerable<T> coll)
		: this(0, (TwoThreeTree.Node<T>)TwoThreeTree.Node<T>.Leaf._N_constant_object, NemerleCollectionsComparer.Comparer<T>.Default, coll)
	{
	}

	public Set(IEnumerable<T> coll, Function<T, T, int> cmp)
		: this(0, (TwoThreeTree.Node<T>)TwoThreeTree.Node<T>.Leaf._N_constant_object, cmp, coll)
	{
	}

	private Set(int size, TwoThreeTree.Node<T> tree, Function<T, T, int> cmp, IEnumerable<T> coll)
	{
		_N_closureOf__ctor_27098 n_closureOf__ctor_ = new _N_closureOf__ctor_27098
		{
			_N_size_27105 = size
		};
		base._002Ector();
		n_closureOf__ctor_._N__N_closurised_this_ptr_27103 = this;
		_cmp = cmp;
		Function<T, TwoThreeTree.Node<T>, TwoThreeTree.Node<T>> convert = new _N__N_lambda__27090__27107(n_closureOf__ctor_);
		_tree = coll.Fold(tree, convert);
		_size = n_closureOf__ctor_._N_size_27105;
	}

	private Set(int size, TwoThreeTree.Node<T> tree, Function<T, T, int> cmp)
	{
		_tree = tree;
		_cmp = cmp;
		_size = size;
	}

	public Set<T> Clear()
	{
		return new Set<T>(0, TwoThreeTree.Node<T>.Leaf._N_constant_object, _cmp);
	}

	public Set<T> Add(T value)
	{
		int size = _size;
		TwoThreeTree.Node<T> tree = _tree.Insert(value, _cmp, TwoThreeTree.InsertOptions.ThrowIfDuplicate, ref size);
		return new Set<T>(size, tree, _cmp);
	}

	public Set<T> AddRange(IEnumerable<T> elems)
	{
		return new Set<T>(_size, _tree, _cmp, elems);
	}

	public Set<T> AddList(list<T> elems)
	{
		return AddRange(elems);
	}

	public Set<T> Remove(T value)
	{
		int size = _size;
		TwoThreeTree.Node<T> tree = _tree.Delete(value, _cmp, TwoThreeTree.DeleteOptions.IgnoreMissed, ref size);
		return new Set<T>(size, tree, _cmp);
	}

	public Set<T> RemoveRange(IEnumerable<T> elems)
	{
		_N_closureOf_RemoveRange_27157 n_closureOf_RemoveRange_ = new _N_closureOf_RemoveRange_27157();
		n_closureOf_RemoveRange_._N__N_closurised_this_ptr_27162 = this;
		n_closureOf_RemoveRange_._N_size_27164 = _size;
		TwoThreeTree.Node<T> tree = _tree;
		Function<T, TwoThreeTree.Node<T>, TwoThreeTree.Node<T>> convert = new _N__N_lambda__27148__27166(n_closureOf_RemoveRange_);
		TwoThreeTree.Node<T> tree2 = elems.Fold(tree, convert);
		return new Set<T>(n_closureOf_RemoveRange_._N_size_27164, tree2, _cmp);
	}

	public Set<T> RemoveList(list<T> elems)
	{
		_N_closureOf_RemoveList_27187 n_closureOf_RemoveList_ = new _N_closureOf_RemoveList_27187();
		n_closureOf_RemoveList_._N__N_closurised_this_ptr_27192 = this;
		n_closureOf_RemoveList_._N_size_27194 = _size;
		TwoThreeTree.Node<T> tree = _tree;
		Function<T, TwoThreeTree.Node<T>, TwoThreeTree.Node<T>> convert = new _N__N_lambda__27178__27196(n_closureOf_RemoveList_);
		TwoThreeTree.Node<T> tree2 = elems.Fold(tree, convert);
		return new Set<T>(n_closureOf_RemoveList_._N_size_27194, tree2, _cmp);
	}

	public Set<T> Replace(T value)
	{
		int size = _size;
		TwoThreeTree.Node<T> tree = _tree.Insert(value, _cmp, TwoThreeTree.InsertOptions.Replace, ref size);
		return new Set<T>(size, tree, _cmp);
	}

	public Set<T> ReplaceRange(IEnumerable<T> elems)
	{
		_N_closureOf_ReplaceRange_27223 n_closureOf_ReplaceRange_ = new _N_closureOf_ReplaceRange_27223();
		n_closureOf_ReplaceRange_._N__N_closurised_this_ptr_27228 = this;
		n_closureOf_ReplaceRange_._N_size_27230 = _size;
		TwoThreeTree.Node<T> tree = _tree;
		Function<T, TwoThreeTree.Node<T>, TwoThreeTree.Node<T>> convert = new _N__N_lambda__27214__27232(n_closureOf_ReplaceRange_);
		TwoThreeTree.Node<T> tree2 = elems.Fold(tree, convert);
		return new Set<T>(n_closureOf_ReplaceRange_._N_size_27230, tree2, _cmp);
	}

	public Set<T> ReplaceList(list<T> elems)
	{
		_N_closureOf_ReplaceList_27253 n_closureOf_ReplaceList_ = new _N_closureOf_ReplaceList_27253();
		n_closureOf_ReplaceList_._N__N_closurised_this_ptr_27258 = this;
		n_closureOf_ReplaceList_._N_size_27260 = _size;
		TwoThreeTree.Node<T> tree = _tree;
		Function<T, TwoThreeTree.Node<T>, TwoThreeTree.Node<T>> convert = new _N__N_lambda__27244__27262(n_closureOf_ReplaceList_);
		TwoThreeTree.Node<T> tree2 = elems.Fold(tree, convert);
		return new Set<T>(n_closureOf_ReplaceList_._N_size_27260, tree2, _cmp);
	}

	public TAccumulator Fold<TAccumulator>(TAccumulator acc, Function<T, TAccumulator, TAccumulator> fn)
	{
		return _tree.FoldLeft(acc, fn);
	}

	public TAccumulator FoldLeft<TAccumulator>(TAccumulator acc, Function<T, TAccumulator, TAccumulator> fn)
	{
		return _tree.FoldLeft(acc, fn);
	}

	public TAccumulator FoldRight<TAccumulator>(TAccumulator acc, Function<T, TAccumulator, TAccumulator> fn)
	{
		return _tree.FoldRight(acc, fn);
	}

	public void Iter(FunctionVoid<T> fn)
	{
		_N_closureOf_Iter_27298 n_closureOf_Iter_ = new _N_closureOf_Iter_27298();
		n_closureOf_Iter_._N_fn_27303 = fn;
		TwoThreeTree.Node<T> tree = _tree;
		Function<T, object, object> fn2 = new _N__N_lambda__27289__27305(n_closureOf_Iter_);
		object obj = tree.FoldLeft(null, fn2);
	}

	public void IterLeft(FunctionVoid<T> fn)
	{
		_N_closureOf_IterLeft_27326 n_closureOf_IterLeft_ = new _N_closureOf_IterLeft_27326();
		n_closureOf_IterLeft_._N_fn_27331 = fn;
		TwoThreeTree.Node<T> tree = _tree;
		Function<T, object, object> fn2 = new _N__N_lambda__27317__27333(n_closureOf_IterLeft_);
		object obj = tree.FoldLeft(null, fn2);
	}

	public void IterRight(FunctionVoid<T> fn)
	{
		_N_closureOf_IterRight_27354 n_closureOf_IterRight_ = new _N_closureOf_IterRight_27354();
		n_closureOf_IterRight_._N_fn_27359 = fn;
		TwoThreeTree.Node<T> tree = _tree;
		Function<T, object, object> fn2 = new _N__N_lambda__27345__27361(n_closureOf_IterRight_);
		object obj = tree.FoldRight(null, fn2);
	}

	public Set<T> Filter(Function<T, bool> fn)
	{
		Nemerle.Builtins.Tuple<int, TwoThreeTree.Node<T>> tuple = _tree.Filter(_cmp, fn);
		int field = tuple.Field0;
		TwoThreeTree.Node<T> tree = tuple.Field1;
		return new Set<T>(field, tree, _cmp);
	}

	public Nemerle.Builtins.Tuple<Set<T>, Set<T>> Partition(Function<T, bool> fn)
	{
		Nemerle.Builtins.Tuple<int, TwoThreeTree.Node<T>, int, TwoThreeTree.Node<T>> tuple = _tree.Partition(_cmp, fn);
		int field = tuple.Field0;
		TwoThreeTree.Node<T> tree = tuple.Field1;
		int field2 = tuple.Field2;
		TwoThreeTree.Node<T> tree2 = tuple.Field3;
		return new Nemerle.Builtins.Tuple<Set<T>, Set<T>>(new Set<T>(field, tree, _cmp), new Set<T>(field2, tree2, _cmp));
	}

	public bool ForAll(Function<T, bool> fn)
	{
		return _tree.ForAll<object>(fn);
	}

	public bool Exists(Function<T, bool> fn)
	{
		return _tree.Exists<object>(fn);
	}

	public bool Contains(T value)
	{
		T outValue = default(T);
		return _tree.TryGet(value, _cmp, out outValue);
	}

	public Set<T> Sum(Set<T> that)
	{
		int size = _size;
		TwoThreeTree.Node<T> tree = _tree.Sum<object>(ref size, that._tree, _cmp);
		return new Set<T>(size, tree, _cmp);
	}

	public Set<T> Subtract(Set<T> that)
	{
		int size = _size;
		TwoThreeTree.Node<T> tree = _tree.Subtract<object>(ref size, that._tree, _cmp);
		return new Set<T>(size, tree, _cmp);
	}

	public Set<T> Intersect(Set<T> that)
	{
		int size = _size;
		TwoThreeTree.Node<T> tree = _tree.Intersect<object>(ref size, that._tree, _cmp);
		return new Set<T>(size, tree, _cmp);
	}

	public Set<T> Xor(Set<T> that)
	{
		int size = _size;
		TwoThreeTree.Node<T> tree = _tree.Xor<object>(ref size, that._tree, _cmp);
		return new Set<T>(size, tree, _cmp);
	}

	public list<T> ToList()
	{
		return _tree.ToList();
	}

	public T[] ToArray()
	{
		return _tree.ToArray();
	}

	public list<U> MapToList<U>(Function<T, U> fn)
	{
		return _tree.MapToList(fn);
	}

	public U[] MapToArray<U>(Function<T, U> fn)
	{
		return _tree.MapToArray(fn);
	}

	public IEnumerator<T> GetEnumerator()
	{
		return _tree.Enumerate().GetEnumerator();
	}

	public void CopyTo(T[] arr, int arrayIndex)
	{
		_N_closureOf_CopyTo_27466 n_closureOf_CopyTo_ = new _N_closureOf_CopyTo_27466();
		n_closureOf_CopyTo_._N_arr_27471 = arr;
		Function<T, int, int> fn = new _N_copyOne__27473(n_closureOf_CopyTo_);
		int num = _tree.Fold(arrayIndex, fn);
	}

	private bool Remove_Invalid(T _N_wildcard_2848)
	{
		//Discarded unreachable code: IL_000b
		throw new NotSupportedException("this is functional set, which is read-only");
	}

	bool System.Collections.Generic.ICollection<T>.Remove(T _N_wildcard_2848)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Remove_Invalid
		return this.Remove_Invalid(_N_wildcard_2848);
	}

	private void Clear_Invalid()
	{
		//Discarded unreachable code: IL_000b
		throw new NotSupportedException("this is functional set, which is read-only");
	}

	void System.Collections.Generic.ICollection<T>.Clear()
	{
		//ILSpy generated this explicit interface implementation from .override directive in Clear_Invalid
		this.Clear_Invalid();
	}

	private void Add_Invalid(T _N_wildcard_2849)
	{
		//Discarded unreachable code: IL_000b
		throw new NotSupportedException("this is functional set, which is read-only and returns new instance upon adding element");
	}

	void System.Collections.Generic.ICollection<T>.Add(T _N_wildcard_2849)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Add_Invalid
		this.Add_Invalid(_N_wildcard_2849);
	}

	public override string ToString()
	{
		return _tree.ToString("Set[", ", ", "]");
	}

	public override int GetHashCode()
	{
		return _tree.GetHashCode();
	}

	public override bool Equals(object that)
	{
		_N_closureOf_Equals_27513 n_closureOf_Equals_ = new _N_closureOf_Equals_27513();
		int result;
		if (that is Set<T>)
		{
			n_closureOf_Equals_._N_that_27518 = (Set<T>)that;
			if (_size == n_closureOf_Equals_._N_that_27518._size)
			{
				Function<T, bool> fn = new _N__N_lambda__27506__27526(n_closureOf_Equals_);
				result = (ForAll(fn) ? 1 : 0);
			}
			else
			{
				result = 0;
			}
		}
		else
		{
			result = 0;
		}
		return (byte)result != 0;
	}

	public int CompareTo(Set<T> that)
	{
		int num = 0;
		T[] array = ToArray();
		T[] array2 = that.ToArray();
		int num2 = Math.Min(array.Length, array2.Length);
		for (num = 0; num < num2; num = checked(num + 1))
		{
			int num3 = _cmp.apply(array[num], array2[num]);
			if (num3 != 0)
			{
				return num3;
			}
		}
		return (array.Length != array2.Length) ? ((array.Length >= array2.Length) ? 1 : (-1)) : 0;
	}

	[Nemerle.Internal.Extension]
	public static Set<T> Sum(this list<Set<T>> sets)
	{
		Set<T> ini = new Set<T>();
		Function<Set<T>, Set<T>, Set<T>> instance = _N__N_lambda__27709__27716.Instance;
		return sets.Fold(ini, instance);
	}

	[Nemerle.Internal.Extension]
	public static Set<T> Sum(this list<Set<T>> sets, Function<T, T, int> cmp)
	{
		Set<T> ini = new Set<T>(cmp);
		Function<Set<T>, Set<T>, Set<T>> instance = _N__N_lambda__27729__27736.Instance;
		return sets.Fold(ini, instance);
	}

	[SpecialName]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}
