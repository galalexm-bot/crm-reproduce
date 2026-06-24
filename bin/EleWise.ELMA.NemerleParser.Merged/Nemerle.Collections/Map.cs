using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Nemerle.Builtins;
using Nemerle.Core;

namespace Nemerle.Collections;

[DebuggerNonUserCode]
[DebuggerDisplay("Count = {Count}: {ToString()}")]
public class Map<TKey, TValue> : IEnumerable, IEnumerable<Nemerle.Builtins.Tuple<TKey, TValue>>
{
	private struct Node
	{
		public readonly TKey Key;

		public readonly TValue Value;

		public Node(TKey k, TValue v)
		{
			Key = k;
			Value = v;
		}

		public Node(TKey k)
		{
			Key = k;
		}

		public override string ToString()
		{
			return "(" + Convert.ToString(Key) + ", " + Convert.ToString(Value) + ")";
		}
	}

	private sealed class _N_closureOf_MakeNodeComparer_21202
	{
		internal Function<TKey, TKey, int> _N_cmp_21207;

		internal _N_closureOf_MakeNodeComparer_21202()
		{
		}
	}

	private sealed class _N__N_lambda__21195__21209 : Function<Node, Node, int>
	{
		[SpecialName]
		private _N_closureOf_MakeNodeComparer_21202 _N_MakeNodeComparer_closure_21213;

		public _N__N_lambda__21195__21209(_N_closureOf_MakeNodeComparer_21202 _N_MakeNodeComparer_closure_21213)
		{
			this._N_MakeNodeComparer_closure_21213 = _N_MakeNodeComparer_closure_21213;
		}

		[SpecialName]
		public sealed override int apply(Node x, Node y)
		{
			return _N_MakeNodeComparer_closure_21213._N_cmp_21207.apply(x.Key, y.Key);
		}
	}

	private sealed class _N_closureOf__ctor_21291
	{
		internal int _N_size_21298;

		internal Map<TKey, TValue> _N__N_closurised_this_ptr_21296;

		internal _N_closureOf__ctor_21291()
		{
		}
	}

	private sealed class _N__N_lambda__21237__21302 : Function<Nemerle.Builtins.Tuple<TKey, TValue>, TwoThreeTree.Node<Node>, TwoThreeTree.Node<Node>>
	{
		[SpecialName]
		private _N_closureOf__ctor_21291 _N__ctor_closure_21306;

		public _N__N_lambda__21237__21302(_N_closureOf__ctor_21291 _N__ctor_closure_21306)
		{
			this._N__ctor_closure_21306 = _N__ctor_closure_21306;
		}

		[SpecialName]
		public sealed override TwoThreeTree.Node<Node> apply(Nemerle.Builtins.Tuple<TKey, TValue> _N__21300, TwoThreeTree.Node<Node> _N__21301)
		{
			TValue val = default(TValue);
			TKey val2 = default(TKey);
			val2 = _N__21300.Field0;
			val = _N__21300.Field1;
			return _N__21301.Insert(new Node(val2, val), _N__ctor_closure_21306._N__N_closurised_this_ptr_21296._cmp, TwoThreeTree.InsertOptions.ThrowIfDuplicate, ref _N__ctor_closure_21306._N_size_21298);
		}
	}

	private sealed class _N_closureOf_RemoveRange_21404
	{
		internal int _N_size_21411;

		internal Map<TKey, TValue> _N__N_closurised_this_ptr_21409;

		internal _N_closureOf_RemoveRange_21404()
		{
		}
	}

	private sealed class _N__N_lambda__21395__21413 : Function<TKey, TwoThreeTree.Node<Node>, TwoThreeTree.Node<Node>>
	{
		[SpecialName]
		private _N_closureOf_RemoveRange_21404 _N_RemoveRange_closure_21417;

		public _N__N_lambda__21395__21413(_N_closureOf_RemoveRange_21404 _N_RemoveRange_closure_21417)
		{
			this._N_RemoveRange_closure_21417 = _N_RemoveRange_closure_21417;
		}

		[SpecialName]
		public sealed override TwoThreeTree.Node<Node> apply(TKey key, TwoThreeTree.Node<Node> tree)
		{
			return tree.Delete(new Node(key), _N_RemoveRange_closure_21417._N__N_closurised_this_ptr_21409._cmp, TwoThreeTree.DeleteOptions.IgnoreMissed, ref _N_RemoveRange_closure_21417._N_size_21411);
		}
	}

	private sealed class _N_closureOf_RemoveList_21434
	{
		internal int _N_size_21441;

		internal Map<TKey, TValue> _N__N_closurised_this_ptr_21439;

		internal _N_closureOf_RemoveList_21434()
		{
		}
	}

	private sealed class _N__N_lambda__21425__21443 : Function<TKey, TwoThreeTree.Node<Node>, TwoThreeTree.Node<Node>>
	{
		[SpecialName]
		private _N_closureOf_RemoveList_21434 _N_RemoveList_closure_21447;

		public _N__N_lambda__21425__21443(_N_closureOf_RemoveList_21434 _N_RemoveList_closure_21447)
		{
			this._N_RemoveList_closure_21447 = _N_RemoveList_closure_21447;
		}

		[SpecialName]
		public sealed override TwoThreeTree.Node<Node> apply(TKey key, TwoThreeTree.Node<Node> tree)
		{
			return tree.Delete(new Node(key), _N_RemoveList_closure_21447._N__N_closurised_this_ptr_21439._cmp, TwoThreeTree.DeleteOptions.IgnoreMissed, ref _N_RemoveList_closure_21447._N_size_21441);
		}
	}

	private sealed class _N_closureOf_ReplaceRange_21473
	{
		internal int _N_size_21480;

		internal Map<TKey, TValue> _N__N_closurised_this_ptr_21478;

		internal _N_closureOf_ReplaceRange_21473()
		{
		}
	}

	private sealed class _N__N_lambda__21462__21484 : Function<Nemerle.Builtins.Tuple<TKey, TValue>, TwoThreeTree.Node<Node>, TwoThreeTree.Node<Node>>
	{
		[SpecialName]
		private _N_closureOf_ReplaceRange_21473 _N_ReplaceRange_closure_21488;

		public _N__N_lambda__21462__21484(_N_closureOf_ReplaceRange_21473 _N_ReplaceRange_closure_21488)
		{
			this._N_ReplaceRange_closure_21488 = _N_ReplaceRange_closure_21488;
		}

		[SpecialName]
		public sealed override TwoThreeTree.Node<Node> apply(Nemerle.Builtins.Tuple<TKey, TValue> _N__21482, TwoThreeTree.Node<Node> _N__21483)
		{
			TValue val = default(TValue);
			TKey val2 = default(TKey);
			val2 = _N__21482.Field0;
			val = _N__21482.Field1;
			return _N__21483.Insert(new Node(val2, val), _N_ReplaceRange_closure_21488._N__N_closurised_this_ptr_21478._cmp, TwoThreeTree.InsertOptions.Replace, ref _N_ReplaceRange_closure_21488._N_size_21480);
		}
	}

	private sealed class _N_closureOf_ReplaceList_21509
	{
		internal int _N_size_21516;

		internal Map<TKey, TValue> _N__N_closurised_this_ptr_21514;

		internal _N_closureOf_ReplaceList_21509()
		{
		}
	}

	private sealed class _N__N_lambda__21498__21520 : Function<Nemerle.Builtins.Tuple<TKey, TValue>, TwoThreeTree.Node<Node>, TwoThreeTree.Node<Node>>
	{
		[SpecialName]
		private _N_closureOf_ReplaceList_21509 _N_ReplaceList_closure_21524;

		public _N__N_lambda__21498__21520(_N_closureOf_ReplaceList_21509 _N_ReplaceList_closure_21524)
		{
			this._N_ReplaceList_closure_21524 = _N_ReplaceList_closure_21524;
		}

		[SpecialName]
		public sealed override TwoThreeTree.Node<Node> apply(Nemerle.Builtins.Tuple<TKey, TValue> _N__21518, TwoThreeTree.Node<Node> _N__21519)
		{
			TValue val = default(TValue);
			TKey val2 = default(TKey);
			val2 = _N__21518.Field0;
			val = _N__21518.Field1;
			return _N__21519.Insert(new Node(val2, val), _N_ReplaceList_closure_21524._N__N_closurised_this_ptr_21514._cmp, TwoThreeTree.InsertOptions.Replace, ref _N_ReplaceList_closure_21524._N_size_21516);
		}
	}

	private sealed class _N_closureOf_Fold_21542<TAccumulator>
	{
		internal Function<TKey, TValue, TAccumulator, TAccumulator> _N_fn_21547;

		internal _N_closureOf_Fold_21542()
		{
		}
	}

	private sealed class _N__N_lambda__21534__21549<TAccumulator> : Function<Node, TAccumulator, TAccumulator>
	{
		[SpecialName]
		private _N_closureOf_Fold_21542<TAccumulator> _N_Fold_closure_21553;

		public _N__N_lambda__21534__21549(_N_closureOf_Fold_21542<TAccumulator> _N_Fold_closure_21553)
		{
			this._N_Fold_closure_21553 = _N_Fold_closure_21553;
		}

		[SpecialName]
		public sealed override TAccumulator apply(Node node, TAccumulator acc)
		{
			return _N_Fold_closure_21553._N_fn_21547.apply(node.Key, node.Value, acc);
		}
	}

	private sealed class _N_closureOf_FoldLeft_21569<TAccumulator>
	{
		internal Function<TKey, TValue, TAccumulator, TAccumulator> _N_fn_21574;

		internal _N_closureOf_FoldLeft_21569()
		{
		}
	}

	private sealed class _N__N_lambda__21561__21576<TAccumulator> : Function<Node, TAccumulator, TAccumulator>
	{
		[SpecialName]
		private _N_closureOf_FoldLeft_21569<TAccumulator> _N_FoldLeft_closure_21580;

		public _N__N_lambda__21561__21576(_N_closureOf_FoldLeft_21569<TAccumulator> _N_FoldLeft_closure_21580)
		{
			this._N_FoldLeft_closure_21580 = _N_FoldLeft_closure_21580;
		}

		[SpecialName]
		public sealed override TAccumulator apply(Node node, TAccumulator acc)
		{
			return _N_FoldLeft_closure_21580._N_fn_21574.apply(node.Key, node.Value, acc);
		}
	}

	private sealed class _N_closureOf_FoldRight_21596<TAccumulator>
	{
		internal Function<TKey, TValue, TAccumulator, TAccumulator> _N_fn_21601;

		internal _N_closureOf_FoldRight_21596()
		{
		}
	}

	private sealed class _N__N_lambda__21588__21603<TAccumulator> : Function<Node, TAccumulator, TAccumulator>
	{
		[SpecialName]
		private _N_closureOf_FoldRight_21596<TAccumulator> _N_FoldRight_closure_21607;

		public _N__N_lambda__21588__21603(_N_closureOf_FoldRight_21596<TAccumulator> _N_FoldRight_closure_21607)
		{
			this._N_FoldRight_closure_21607 = _N_FoldRight_closure_21607;
		}

		[SpecialName]
		public sealed override TAccumulator apply(Node node, TAccumulator acc)
		{
			return _N_FoldRight_closure_21607._N_fn_21601.apply(node.Key, node.Value, acc);
		}
	}

	private sealed class _N_closureOf_Iter_21624
	{
		internal FunctionVoid<TKey, TValue> _N_fn_21629;

		internal _N_closureOf_Iter_21624()
		{
		}
	}

	private sealed class _N__N_lambda__21615__21631 : Function<Node, object, object>
	{
		[SpecialName]
		private _N_closureOf_Iter_21624 _N_Iter_closure_21635;

		public _N__N_lambda__21615__21631(_N_closureOf_Iter_21624 _N_Iter_closure_21635)
		{
			this._N_Iter_closure_21635 = _N_Iter_closure_21635;
		}

		[SpecialName]
		public sealed override object apply(Node node, object _N_wildcard_21614)
		{
			_N_Iter_closure_21635._N_fn_21629.apply_void(new Nemerle.Builtins.Tuple<TKey, TValue>(node.Key, node.Value));
			return null;
		}
	}

	private sealed class _N_closureOf_IterLeft_21652
	{
		internal FunctionVoid<TKey, TValue> _N_fn_21657;

		internal _N_closureOf_IterLeft_21652()
		{
		}
	}

	private sealed class _N__N_lambda__21643__21659 : Function<Node, object, object>
	{
		[SpecialName]
		private _N_closureOf_IterLeft_21652 _N_IterLeft_closure_21663;

		public _N__N_lambda__21643__21659(_N_closureOf_IterLeft_21652 _N_IterLeft_closure_21663)
		{
			this._N_IterLeft_closure_21663 = _N_IterLeft_closure_21663;
		}

		[SpecialName]
		public sealed override object apply(Node node, object _N_wildcard_21642)
		{
			_N_IterLeft_closure_21663._N_fn_21657.apply_void(new Nemerle.Builtins.Tuple<TKey, TValue>(node.Key, node.Value));
			return null;
		}
	}

	private sealed class _N_closureOf_IterRight_21680
	{
		internal FunctionVoid<TKey, TValue> _N_fn_21685;

		internal _N_closureOf_IterRight_21680()
		{
		}
	}

	private sealed class _N__N_lambda__21671__21687 : Function<Node, object, object>
	{
		[SpecialName]
		private _N_closureOf_IterRight_21680 _N_IterRight_closure_21691;

		public _N__N_lambda__21671__21687(_N_closureOf_IterRight_21680 _N_IterRight_closure_21691)
		{
			this._N_IterRight_closure_21691 = _N_IterRight_closure_21691;
		}

		[SpecialName]
		public sealed override object apply(Node node, object _N_wildcard_21670)
		{
			_N_IterRight_closure_21691._N_fn_21685.apply_void(new Nemerle.Builtins.Tuple<TKey, TValue>(node.Key, node.Value));
			return null;
		}
	}

	private sealed class _N_closureOf_Filter_21707
	{
		internal Function<TKey, TValue, bool> _N_fn_21712;

		internal _N_closureOf_Filter_21707()
		{
		}
	}

	private sealed class _N__N_lambda__21698__21718 : Function<Node, bool>
	{
		[SpecialName]
		private _N_closureOf_Filter_21707 _N_Filter_closure_21722;

		public _N__N_lambda__21698__21718(_N_closureOf_Filter_21707 _N_Filter_closure_21722)
		{
			this._N_Filter_closure_21722 = _N_Filter_closure_21722;
		}

		[SpecialName]
		public sealed override bool apply(Node node)
		{
			return _N_Filter_closure_21722._N_fn_21712.apply(node.Key, node.Value);
		}
	}

	private sealed class _N_closureOf_Partition_21740
	{
		internal Function<TKey, TValue, bool> _N_fn_21745;

		internal _N_closureOf_Partition_21740()
		{
		}
	}

	private sealed class _N__N_lambda__21729__21751 : Function<Node, bool>
	{
		[SpecialName]
		private _N_closureOf_Partition_21740 _N_Partition_closure_21755;

		public _N__N_lambda__21729__21751(_N_closureOf_Partition_21740 _N_Partition_closure_21755)
		{
			this._N_Partition_closure_21755 = _N_Partition_closure_21755;
		}

		[SpecialName]
		public sealed override bool apply(Node node)
		{
			return _N_Partition_closure_21755._N_fn_21745.apply(node.Key, node.Value);
		}
	}

	private sealed class _N_closureOf_ForAll_21769
	{
		internal Function<TKey, TValue, bool> _N_fn_21774;

		internal _N_closureOf_ForAll_21769()
		{
		}
	}

	private sealed class _N__N_lambda__21762__21776 : Function<Node, bool>
	{
		[SpecialName]
		private _N_closureOf_ForAll_21769 _N_ForAll_closure_21780;

		public _N__N_lambda__21762__21776(_N_closureOf_ForAll_21769 _N_ForAll_closure_21780)
		{
			this._N_ForAll_closure_21780 = _N_ForAll_closure_21780;
		}

		[SpecialName]
		public sealed override bool apply(Node node)
		{
			return _N_ForAll_closure_21780._N_fn_21774.apply(node.Key, node.Value);
		}
	}

	private sealed class _N_closureOf_Exists_21794
	{
		internal Function<TKey, TValue, bool> _N_fn_21799;

		internal _N_closureOf_Exists_21794()
		{
		}
	}

	private sealed class _N__N_lambda__21787__21801 : Function<Node, bool>
	{
		[SpecialName]
		private _N_closureOf_Exists_21794 _N_Exists_closure_21805;

		public _N__N_lambda__21787__21801(_N_closureOf_Exists_21794 _N_Exists_closure_21805)
		{
			this._N_Exists_closure_21805 = _N_Exists_closure_21805;
		}

		[SpecialName]
		public sealed override bool apply(Node node)
		{
			return _N_Exists_closure_21805._N_fn_21799.apply(node.Key, node.Value);
		}
	}

	private sealed class _N__N_lambda__21827__21834 : Function<Node, Nemerle.Builtins.Tuple<TKey, TValue>>
	{
		[SpecialName]
		public static readonly _N__N_lambda__21827__21834 Instance = new _N__N_lambda__21827__21834();

		[SpecialName]
		public sealed override Nemerle.Builtins.Tuple<TKey, TValue> apply(Node node)
		{
			return new Nemerle.Builtins.Tuple<TKey, TValue>(node.Key, node.Value);
		}
	}

	private sealed class _N__N_lambda__21845__21852 : Function<Node, Nemerle.Builtins.Tuple<TKey, TValue>>
	{
		[SpecialName]
		public static readonly _N__N_lambda__21845__21852 Instance = new _N__N_lambda__21845__21852();

		[SpecialName]
		public sealed override Nemerle.Builtins.Tuple<TKey, TValue> apply(Node node)
		{
			return new Nemerle.Builtins.Tuple<TKey, TValue>(node.Key, node.Value);
		}
	}

	private sealed class _N_closureOf_MapToList_21871<U>
	{
		internal Function<TKey, TValue, U> _N_fn_21876;

		internal _N_closureOf_MapToList_21871()
		{
		}
	}

	private sealed class _N__N_lambda__21864__21878<U> : Function<Node, U>
	{
		[SpecialName]
		private _N_closureOf_MapToList_21871<U> _N_MapToList_closure_21882;

		public _N__N_lambda__21864__21878(_N_closureOf_MapToList_21871<U> _N_MapToList_closure_21882)
		{
			this._N_MapToList_closure_21882 = _N_MapToList_closure_21882;
		}

		[SpecialName]
		public sealed override U apply(Node node)
		{
			return _N_MapToList_closure_21882._N_fn_21876.apply(node.Key, node.Value);
		}
	}

	private sealed class _N_closureOf_MapToArray_21896<U>
	{
		internal Function<TKey, TValue, U> _N_fn_21901;

		internal _N_closureOf_MapToArray_21896()
		{
		}
	}

	private sealed class _N__N_lambda__21889__21903<U> : Function<Node, U>
	{
		[SpecialName]
		private _N_closureOf_MapToArray_21896<U> _N_MapToArray_closure_21907;

		public _N__N_lambda__21889__21903(_N_closureOf_MapToArray_21896<U> _N_MapToArray_closure_21907)
		{
			this._N_MapToArray_closure_21907 = _N_MapToArray_closure_21907;
		}

		[SpecialName]
		public sealed override U apply(Node node)
		{
			return _N_MapToArray_closure_21907._N_fn_21901.apply(node.Key, node.Value);
		}
	}

	private class _N_Enumerator_21942 : IEnumerator, IDisposable, IEnumerator<Nemerle.Builtins.Tuple<TKey, TValue>>
	{
		private bool _N_finally_needed_21968;

		internal Node _N_elem_21966;

		internal IEnumerator<Node> _N_enumerator_21964;

		internal Nemerle.Builtins.Tuple<TKey, TValue> _N_current;

		internal int _N_state;

		internal Function<bool> _N__N_yielding_function_21960;

		internal Map<TKey, TValue> _N__N_closurised_this_ptr_21958;

		internal Function<bool> _N__N_wildcard_3438_21956;

		public Nemerle.Builtins.Tuple<TKey, TValue> Current => _N_current;

		public void Dispose()
		{
			_N_state = -1;
			if (_N_finally_needed_21968)
			{
				((IDisposable)_N_enumerator_21964).Dispose();
			}
		}

		public void Reset()
		{
			//Discarded unreachable code: IL_0006
			throw new NotSupportedException();
		}

		public bool MoveNext()
		{
			try
			{
				bool flag = false;
				if (_N_state != 1)
				{
					if (_N_state != 0)
					{
						return false;
					}
					_N_enumerator_21964 = _N__N_closurised_this_ptr_21958._tree.Enumerate().GetEnumerator();
					_N_finally_needed_21968 = true;
				}
				if (_N_enumerator_21964.MoveNext())
				{
					Node node = (_N_elem_21966 = _N_enumerator_21964.Current);
					_N_current = new Nemerle.Builtins.Tuple<TKey, TValue>(_N_elem_21966.Key, _N_elem_21966.Value);
					_N_state = 1;
					return true;
				}
				_N_finally_needed_21968 = false;
				((IDisposable)_N_enumerator_21964).Dispose();
				return false;
			}
			catch
			{
				//try-fault
				Dispose();
				throw;
			}
		}

		[SpecialName]
		object IEnumerator.get_Current()
		{
			return Current;
		}
	}

	private sealed class _N_closureOf_CopyTo_21999
	{
		internal Nemerle.Builtins.Tuple<TKey, TValue>[] _N_arr_22004;

		internal _N_closureOf_CopyTo_21999()
		{
		}
	}

	private sealed class _N_copyOne__22006 : Function<Node, int, int>
	{
		[SpecialName]
		private _N_closureOf_CopyTo_21999 _N_CopyTo_closure_22010;

		public _N_copyOne__22006(_N_closureOf_CopyTo_21999 _N_CopyTo_closure_22010)
		{
			this._N_CopyTo_closure_22010 = _N_CopyTo_closure_22010;
		}

		[SpecialName]
		public sealed override int apply(Node value, int arrayIndex)
		{
			ref Nemerle.Builtins.Tuple<TKey, TValue> reference = ref _N_CopyTo_closure_22010._N_arr_22004[arrayIndex];
			reference = new Nemerle.Builtins.Tuple<TKey, TValue>(value.Key, value.Value);
			return checked(arrayIndex + 1);
		}
	}

	private readonly TwoThreeTree.Node<Node> _tree;

	private readonly Function<Node, Node, int> _cmp;

	private readonly int _size;

	public bool IsEmpty => _size == 0;

	public bool IsReadOnly => true;

	public int Count => _size;

	private static Function<Node, Node, int> MakeNodeComparer(Function<TKey, TKey, int> cmp)
	{
		_N_closureOf_MakeNodeComparer_21202 n_closureOf_MakeNodeComparer_ = new _N_closureOf_MakeNodeComparer_21202();
		n_closureOf_MakeNodeComparer_._N_cmp_21207 = cmp;
		return new _N__N_lambda__21195__21209(n_closureOf_MakeNodeComparer_);
	}

	private static Function<Node, Node, int> DefaultComparer()
	{
		return MakeNodeComparer(NemerleCollectionsComparer.Comparer<TKey>.Default);
	}

	public Map()
		: this(0, (TwoThreeTree.Node<Node>)TwoThreeTree.Node<Node>.Leaf._N_constant_object, DefaultComparer())
	{
	}

	public Map(Function<TKey, TKey, int> cmp)
		: this(0, (TwoThreeTree.Node<Node>)TwoThreeTree.Node<Node>.Leaf._N_constant_object, MakeNodeComparer(cmp))
	{
	}

	public Map(IEnumerable<Nemerle.Builtins.Tuple<TKey, TValue>> coll)
		: this(0, (TwoThreeTree.Node<Node>)TwoThreeTree.Node<Node>.Leaf._N_constant_object, DefaultComparer(), coll)
	{
	}

	public Map(IEnumerable<Nemerle.Builtins.Tuple<TKey, TValue>> coll, Function<TKey, TKey, int> cmp)
		: this(0, (TwoThreeTree.Node<Node>)TwoThreeTree.Node<Node>.Leaf._N_constant_object, MakeNodeComparer(cmp), coll)
	{
	}

	private Map(int size, TwoThreeTree.Node<Node> tree, Function<Node, Node, int> cmp, IEnumerable<Nemerle.Builtins.Tuple<TKey, TValue>> coll)
	{
		_N_closureOf__ctor_21291 n_closureOf__ctor_ = new _N_closureOf__ctor_21291
		{
			_N_size_21298 = size
		};
		base._002Ector();
		n_closureOf__ctor_._N__N_closurised_this_ptr_21296 = this;
		_cmp = cmp;
		Function<Nemerle.Builtins.Tuple<TKey, TValue>, TwoThreeTree.Node<Node>, TwoThreeTree.Node<Node>> convert = new _N__N_lambda__21237__21302(n_closureOf__ctor_);
		_tree = coll.Fold(tree, convert);
		_size = n_closureOf__ctor_._N_size_21298;
	}

	private Map(int size, TwoThreeTree.Node<Node> tree, Function<Node, Node, int> cmp)
	{
		_tree = tree;
		_cmp = cmp;
		_size = size;
	}

	public bool Contains(TKey key)
	{
		Node outValue = default(Node);
		return _tree.TryGet(new Node(key), _cmp, out outValue);
	}

	public Map<TKey, TValue> Clear()
	{
		return new Map<TKey, TValue>(0, TwoThreeTree.Node<Node>.Leaf._N_constant_object, _cmp);
	}

	public Map<TKey, TValue> Add(TKey key, TValue value)
	{
		int size = _size;
		TwoThreeTree.Node<Node> tree = _tree.Insert(new Node(key, value), _cmp, TwoThreeTree.InsertOptions.ThrowIfDuplicate, ref size);
		return new Map<TKey, TValue>(size, tree, _cmp);
	}

	public Map<TKey, TValue> AddRange(IEnumerable<Nemerle.Builtins.Tuple<TKey, TValue>> elems)
	{
		return new Map<TKey, TValue>(_size, _tree, _cmp, elems);
	}

	public Map<TKey, TValue> AddList(list<Nemerle.Builtins.Tuple<TKey, TValue>> elems)
	{
		return AddRange(elems);
	}

	public Map<TKey, TValue> Remove(TKey key)
	{
		int size = _size;
		TwoThreeTree.Node<Node> tree = _tree.Delete(new Node(key), _cmp, TwoThreeTree.DeleteOptions.IgnoreMissed, ref size);
		return new Map<TKey, TValue>(size, tree, _cmp);
	}

	public Map<TKey, TValue> RemoveRange(IEnumerable<TKey> elems)
	{
		_N_closureOf_RemoveRange_21404 n_closureOf_RemoveRange_ = new _N_closureOf_RemoveRange_21404();
		n_closureOf_RemoveRange_._N__N_closurised_this_ptr_21409 = this;
		n_closureOf_RemoveRange_._N_size_21411 = _size;
		TwoThreeTree.Node<Node> tree = _tree;
		Function<TKey, TwoThreeTree.Node<Node>, TwoThreeTree.Node<Node>> convert = new _N__N_lambda__21395__21413(n_closureOf_RemoveRange_);
		TwoThreeTree.Node<Node> tree2 = elems.Fold(tree, convert);
		return new Map<TKey, TValue>(n_closureOf_RemoveRange_._N_size_21411, tree2, _cmp);
	}

	public Map<TKey, TValue> RemoveList(list<TKey> elems)
	{
		_N_closureOf_RemoveList_21434 n_closureOf_RemoveList_ = new _N_closureOf_RemoveList_21434();
		n_closureOf_RemoveList_._N__N_closurised_this_ptr_21439 = this;
		n_closureOf_RemoveList_._N_size_21441 = _size;
		TwoThreeTree.Node<Node> tree = _tree;
		Function<TKey, TwoThreeTree.Node<Node>, TwoThreeTree.Node<Node>> convert = new _N__N_lambda__21425__21443(n_closureOf_RemoveList_);
		TwoThreeTree.Node<Node> tree2 = elems.Fold(tree, convert);
		return new Map<TKey, TValue>(n_closureOf_RemoveList_._N_size_21441, tree2, _cmp);
	}

	public Map<TKey, TValue> Replace(TKey key, TValue value)
	{
		int size = _size;
		TwoThreeTree.Node<Node> tree = _tree.Insert(new Node(key, value), _cmp, TwoThreeTree.InsertOptions.Replace, ref size);
		return new Map<TKey, TValue>(size, tree, _cmp);
	}

	public Map<TKey, TValue> ReplaceRange(IEnumerable<Nemerle.Builtins.Tuple<TKey, TValue>> elems)
	{
		_N_closureOf_ReplaceRange_21473 n_closureOf_ReplaceRange_ = new _N_closureOf_ReplaceRange_21473();
		n_closureOf_ReplaceRange_._N__N_closurised_this_ptr_21478 = this;
		n_closureOf_ReplaceRange_._N_size_21480 = _size;
		TwoThreeTree.Node<Node> tree = _tree;
		Function<Nemerle.Builtins.Tuple<TKey, TValue>, TwoThreeTree.Node<Node>, TwoThreeTree.Node<Node>> convert = new _N__N_lambda__21462__21484(n_closureOf_ReplaceRange_);
		TwoThreeTree.Node<Node> tree2 = elems.Fold(tree, convert);
		return new Map<TKey, TValue>(n_closureOf_ReplaceRange_._N_size_21480, tree2, _cmp);
	}

	public Map<TKey, TValue> ReplaceList(list<Nemerle.Builtins.Tuple<TKey, TValue>> elems)
	{
		_N_closureOf_ReplaceList_21509 n_closureOf_ReplaceList_ = new _N_closureOf_ReplaceList_21509();
		n_closureOf_ReplaceList_._N__N_closurised_this_ptr_21514 = this;
		n_closureOf_ReplaceList_._N_size_21516 = _size;
		TwoThreeTree.Node<Node> tree = _tree;
		Function<Nemerle.Builtins.Tuple<TKey, TValue>, TwoThreeTree.Node<Node>, TwoThreeTree.Node<Node>> convert = new _N__N_lambda__21498__21520(n_closureOf_ReplaceList_);
		TwoThreeTree.Node<Node> tree2 = elems.Fold(tree, convert);
		return new Map<TKey, TValue>(n_closureOf_ReplaceList_._N_size_21516, tree2, _cmp);
	}

	public TAccumulator Fold<TAccumulator>(TAccumulator acc, Function<TKey, TValue, TAccumulator, TAccumulator> fn)
	{
		_N_closureOf_Fold_21542<TAccumulator> n_closureOf_Fold_ = new _N_closureOf_Fold_21542<TAccumulator>();
		n_closureOf_Fold_._N_fn_21547 = fn;
		TwoThreeTree.Node<Node> tree = _tree;
		Function<Node, TAccumulator, TAccumulator> fn2 = new _N__N_lambda__21534__21549<TAccumulator>(n_closureOf_Fold_);
		return tree.FoldLeft(acc, fn2);
	}

	public TAccumulator FoldLeft<TAccumulator>(TAccumulator acc, Function<TKey, TValue, TAccumulator, TAccumulator> fn)
	{
		_N_closureOf_FoldLeft_21569<TAccumulator> n_closureOf_FoldLeft_ = new _N_closureOf_FoldLeft_21569<TAccumulator>();
		n_closureOf_FoldLeft_._N_fn_21574 = fn;
		TwoThreeTree.Node<Node> tree = _tree;
		Function<Node, TAccumulator, TAccumulator> fn2 = new _N__N_lambda__21561__21576<TAccumulator>(n_closureOf_FoldLeft_);
		return tree.FoldLeft(acc, fn2);
	}

	public TAccumulator FoldRight<TAccumulator>(TAccumulator acc, Function<TKey, TValue, TAccumulator, TAccumulator> fn)
	{
		_N_closureOf_FoldRight_21596<TAccumulator> n_closureOf_FoldRight_ = new _N_closureOf_FoldRight_21596<TAccumulator>();
		n_closureOf_FoldRight_._N_fn_21601 = fn;
		TwoThreeTree.Node<Node> tree = _tree;
		Function<Node, TAccumulator, TAccumulator> fn2 = new _N__N_lambda__21588__21603<TAccumulator>(n_closureOf_FoldRight_);
		return tree.FoldRight(acc, fn2);
	}

	public void Iter(FunctionVoid<TKey, TValue> fn)
	{
		_N_closureOf_Iter_21624 n_closureOf_Iter_ = new _N_closureOf_Iter_21624();
		n_closureOf_Iter_._N_fn_21629 = fn;
		TwoThreeTree.Node<Node> tree = _tree;
		Function<Node, object, object> fn2 = new _N__N_lambda__21615__21631(n_closureOf_Iter_);
		object obj = tree.FoldLeft(null, fn2);
	}

	public void IterLeft(FunctionVoid<TKey, TValue> fn)
	{
		_N_closureOf_IterLeft_21652 n_closureOf_IterLeft_ = new _N_closureOf_IterLeft_21652();
		n_closureOf_IterLeft_._N_fn_21657 = fn;
		TwoThreeTree.Node<Node> tree = _tree;
		Function<Node, object, object> fn2 = new _N__N_lambda__21643__21659(n_closureOf_IterLeft_);
		object obj = tree.FoldLeft(null, fn2);
	}

	public void IterRight(FunctionVoid<TKey, TValue> fn)
	{
		_N_closureOf_IterRight_21680 n_closureOf_IterRight_ = new _N_closureOf_IterRight_21680();
		n_closureOf_IterRight_._N_fn_21685 = fn;
		TwoThreeTree.Node<Node> tree = _tree;
		Function<Node, object, object> fn2 = new _N__N_lambda__21671__21687(n_closureOf_IterRight_);
		object obj = tree.FoldRight(null, fn2);
	}

	public Map<TKey, TValue> Filter(Function<TKey, TValue, bool> fn)
	{
		_N_closureOf_Filter_21707 n_closureOf_Filter_ = new _N_closureOf_Filter_21707();
		n_closureOf_Filter_._N_fn_21712 = fn;
		TwoThreeTree.Node<Node> tree = _tree;
		Function<Node, Node, int> cmp = _cmp;
		Function<Node, bool> fn2 = new _N__N_lambda__21698__21718(n_closureOf_Filter_);
		Nemerle.Builtins.Tuple<int, TwoThreeTree.Node<Node>> tuple = tree.Filter(cmp, fn2);
		int field = tuple.Field0;
		TwoThreeTree.Node<Node> tree2 = tuple.Field1;
		return new Map<TKey, TValue>(field, tree2, _cmp);
	}

	public Nemerle.Builtins.Tuple<Map<TKey, TValue>, Map<TKey, TValue>> Partition(Function<TKey, TValue, bool> fn)
	{
		_N_closureOf_Partition_21740 n_closureOf_Partition_ = new _N_closureOf_Partition_21740();
		n_closureOf_Partition_._N_fn_21745 = fn;
		TwoThreeTree.Node<Node> tree = _tree;
		Function<Node, Node, int> cmp = _cmp;
		Function<Node, bool> fn2 = new _N__N_lambda__21729__21751(n_closureOf_Partition_);
		Nemerle.Builtins.Tuple<int, TwoThreeTree.Node<Node>, int, TwoThreeTree.Node<Node>> tuple = tree.Partition(cmp, fn2);
		int field = tuple.Field0;
		TwoThreeTree.Node<Node> tree2 = tuple.Field1;
		int field2 = tuple.Field2;
		TwoThreeTree.Node<Node> tree3 = tuple.Field3;
		return new Nemerle.Builtins.Tuple<Map<TKey, TValue>, Map<TKey, TValue>>(new Map<TKey, TValue>(field, tree2, _cmp), new Map<TKey, TValue>(field2, tree3, _cmp));
	}

	public bool ForAll(Function<TKey, TValue, bool> fn)
	{
		_N_closureOf_ForAll_21769 n_closureOf_ForAll_ = new _N_closureOf_ForAll_21769();
		n_closureOf_ForAll_._N_fn_21774 = fn;
		TwoThreeTree.Node<Node> tree = _tree;
		Function<Node, bool> fn2 = new _N__N_lambda__21762__21776(n_closureOf_ForAll_);
		return tree.ForAll<object>(fn2);
	}

	public bool Exists(Function<TKey, TValue, bool> fn)
	{
		_N_closureOf_Exists_21794 n_closureOf_Exists_ = new _N_closureOf_Exists_21794();
		n_closureOf_Exists_._N_fn_21799 = fn;
		TwoThreeTree.Node<Node> tree = _tree;
		Function<Node, bool> fn2 = new _N__N_lambda__21787__21801(n_closureOf_Exists_);
		return tree.Exists<object>(fn2);
	}

	public option<TValue> Find(TKey key)
	{
		Node outValue = default(Node);
		return (!_tree.TryGet(new Node(key), _cmp, out outValue)) ? ((option<TValue>)option<TValue>.None._N_constant_object) : ((option<TValue>)new option<TValue>.Some(outValue.Value));
	}

	public TValue Get(TKey key)
	{
		Node outValue = default(Node);
		if (_tree.TryGet(new Node(key), _cmp, out outValue))
		{
			return outValue.Value;
		}
		throw new ArgumentException("key not found");
	}

	public list<Nemerle.Builtins.Tuple<TKey, TValue>> ToList()
	{
		TwoThreeTree.Node<Node> tree = _tree;
		Function<Node, Nemerle.Builtins.Tuple<TKey, TValue>> instance = _N__N_lambda__21827__21834.Instance;
		return tree.MapToList(instance);
	}

	public Nemerle.Builtins.Tuple<TKey, TValue>[] ToArray()
	{
		TwoThreeTree.Node<Node> tree = _tree;
		Function<Node, Nemerle.Builtins.Tuple<TKey, TValue>> instance = _N__N_lambda__21845__21852.Instance;
		return tree.MapToArray(instance);
	}

	public list<U> MapToList<U>(Function<TKey, TValue, U> fn)
	{
		_N_closureOf_MapToList_21871<U> n_closureOf_MapToList_ = new _N_closureOf_MapToList_21871<U>();
		n_closureOf_MapToList_._N_fn_21876 = fn;
		TwoThreeTree.Node<Node> tree = _tree;
		Function<Node, U> fn2 = new _N__N_lambda__21864__21878<U>(n_closureOf_MapToList_);
		return tree.MapToList(fn2);
	}

	public U[] MapToArray<U>(Function<TKey, TValue, U> fn)
	{
		_N_closureOf_MapToArray_21896<U> n_closureOf_MapToArray_ = new _N_closureOf_MapToArray_21896<U>();
		n_closureOf_MapToArray_._N_fn_21901 = fn;
		TwoThreeTree.Node<Node> tree = _tree;
		Function<Node, U> fn2 = new _N__N_lambda__21889__21903<U>(n_closureOf_MapToArray_);
		return tree.MapToArray(fn2);
	}

	public IEnumerator<Nemerle.Builtins.Tuple<TKey, TValue>> GetEnumerator()
	{
		_N_Enumerator_21942 n_Enumerator_ = new _N_Enumerator_21942();
		n_Enumerator_._N__N_closurised_this_ptr_21958 = this;
		return n_Enumerator_;
	}

	public void CopyTo(Nemerle.Builtins.Tuple<TKey, TValue>[] arr, int arrayIndex)
	{
		_N_closureOf_CopyTo_21999 n_closureOf_CopyTo_ = new _N_closureOf_CopyTo_21999();
		n_closureOf_CopyTo_._N_arr_22004 = arr;
		Function<Node, int, int> fn = new _N_copyOne__22006(n_closureOf_CopyTo_);
		int num = _tree.Fold(arrayIndex, fn);
	}

	public override string ToString()
	{
		return _tree.ToString("Map[", ", ", "]");
	}

	[SpecialName]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}
