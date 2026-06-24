using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Nemerle.Builtins;
using Nemerle.Core;
using Nemerle.Internal;

namespace Nemerle.Collections;

internal static class TwoThreeTree
{
	public enum InsertOptions
	{
		Replace,
		ThrowIfDuplicate
	}

	public enum DeleteOptions
	{
		IgnoreMissed,
		ThrowIfMissed
	}

	[Variant("Nemerle.Collections.TwoThreeTree.Node.Leaf,Nemerle.Collections.TwoThreeTree.Node.Node2,Nemerle.Collections.TwoThreeTree.Node.Node3")]
	public abstract class Node<T>
	{
		[ConstantVariantOption]
		public class Leaf : Node<T>
		{
			public static readonly Leaf _N_constant_object;

			[SpecialName]
			public static Leaf _N_constant_object_generator()
			{
				return _N_constant_object;
			}

			static Leaf()
			{
				_N_constant_object = new Leaf();
			}

			[SpecialName]
			public override int _N_GetVariantCode()
			{
				return 0;
			}

			[RecordCtor]
			private Leaf()
			{
			}
		}

		[VariantOption]
		public class Node2 : Node<T>
		{
			public readonly Node<T> low;

			public readonly T value1;

			public readonly Node<T> hi;

			[SpecialName]
			public override int _N_GetVariantCode()
			{
				return 1;
			}

			[RecordCtor]
			public Node2([MappedMember("low")] Node<T> low, [MappedMember("value1")] T value1, [MappedMember("hi")] Node<T> hi)
			{
				this.low = low;
				this.value1 = value1;
				this.hi = hi;
			}
		}

		[VariantOption]
		public class Node3 : Node<T>
		{
			public readonly Node<T> low;

			public readonly T value1;

			public readonly Node<T> mid;

			public readonly T value2;

			public readonly Node<T> hi;

			[SpecialName]
			public override int _N_GetVariantCode()
			{
				return 2;
			}

			[RecordCtor]
			public Node3([MappedMember("low")] Node<T> low, [MappedMember("value1")] T value1, [MappedMember("mid")] Node<T> mid, [MappedMember("value2")] T value2, [MappedMember("hi")] Node<T> hi)
			{
				this.low = low;
				this.value1 = value1;
				this.mid = mid;
				this.value2 = value2;
				this.hi = hi;
			}
		}

		private abstract class CmpBase
		{
			public abstract override int Cmp21(Node2 node);

			public abstract override int Cmp31(Node3 node);

			public abstract override int Cmp32(Node3 node);
		}

		private class CmpValue : CmpBase
		{
			private readonly T _value;

			private readonly Function<T, T, int> _cmp;

			public override int Cmp21(Node2 node)
			{
				return _cmp.apply(_value, node.value1);
			}

			public override int Cmp31(Node3 node)
			{
				return _cmp.apply(_value, node.value1);
			}

			public override int Cmp32(Node3 node)
			{
				return _cmp.apply(_value, node.value2);
			}

			[RecordCtor]
			public CmpValue([MappedMember("_value")] T value, [MappedMember("_cmp")] Function<T, T, int> cmp)
			{
				_value = value;
				_cmp = cmp;
			}
		}

		private class CmpReplacement : CmpBase
		{
			public override int Cmp21(Node2 node)
			{
				Node<T> low = node.low;
				return (low != Leaf._N_constant_object) ? (-1) : 0;
			}

			public override int Cmp31(Node3 node)
			{
				Node<T> low = node.low;
				return (low != Leaf._N_constant_object) ? (-1) : 0;
			}

			public override int Cmp32(Node3 node)
			{
				Node<T> low = node.low;
				return (low != Leaf._N_constant_object) ? (-1) : 0;
			}
		}

		private sealed class _N_closureOf_Insert_28016
		{
			internal T _N_value_28033;

			internal Function<T, T, int> _N_cmp_28031;

			internal InsertOptions _N_options_28029;

			internal Node<T> _N_retL_28027;

			internal T _N_retV_28025;

			internal Node<T> _N_retH_28023;

			internal bool _N_replaced_28021;

			internal _N_closureOf_Insert_28016()
			{
			}
		}

		private sealed class _N_closureOf_Delete_28168
		{
			internal T _N_value_28181;

			internal DeleteOptions _N_options_28179;

			internal T _N_retValue_28177;

			internal Node<T> _N_retNode_28175;

			internal bool _N_isMissed_28173;

			internal _N_closureOf_Delete_28168()
			{
			}
		}

		private sealed class _N_closureOf_Filter_28332
		{
			internal Function<T, T, int> _N_cmp_28341;

			internal Function<T, bool> _N_fn_28339;

			internal int _N_size_28337;

			internal _N_closureOf_Filter_28332()
			{
			}
		}

		private sealed class _N_filterFn__28343 : Function<T, Node<T>, Node<T>>
		{
			[SpecialName]
			private _N_closureOf_Filter_28332 _N_Filter_closure_28347;

			public _N_filterFn__28343(_N_closureOf_Filter_28332 _N_Filter_closure_28347)
			{
				this._N_Filter_closure_28347 = _N_Filter_closure_28347;
			}

			[SpecialName]
			public sealed override Node<T> apply(T value, Node<T> tree)
			{
				return (!_N_Filter_closure_28347._N_fn_28339.apply(value)) ? tree : tree.Insert(value, _N_Filter_closure_28347._N_cmp_28341, InsertOptions.ThrowIfDuplicate, ref _N_Filter_closure_28347._N_size_28337);
			}
		}

		private sealed class _N_closureOf_Partition_28370
		{
			internal Function<T, T, int> _N_cmp_28385;

			internal Function<T, bool> _N_fn_28383;

			internal int _N_ysize_28381;

			internal Node<T> _N_ytree_28379;

			internal int _N_nsize_28377;

			internal Node<T> _N_ntree_28375;

			internal _N_closureOf_Partition_28370()
			{
			}
		}

		private sealed class _N_partitionFn__28387 : Function<T, object, object>
		{
			[SpecialName]
			private _N_closureOf_Partition_28370 _N_Partition_closure_28391;

			public _N_partitionFn__28387(_N_closureOf_Partition_28370 _N_Partition_closure_28391)
			{
				this._N_Partition_closure_28391 = _N_Partition_closure_28391;
			}

			[SpecialName]
			public sealed override object apply(T value, object dummy)
			{
				if (_N_Partition_closure_28391._N_fn_28383.apply(value))
				{
					_N_Partition_closure_28391._N_ytree_28379 = _N_Partition_closure_28391._N_ytree_28379.Insert(value, _N_Partition_closure_28391._N_cmp_28385, InsertOptions.ThrowIfDuplicate, ref _N_Partition_closure_28391._N_ysize_28381);
				}
				else
				{
					_N_Partition_closure_28391._N_ntree_28375 = _N_Partition_closure_28391._N_ntree_28375.Insert(value, _N_Partition_closure_28391._N_cmp_28385, InsertOptions.ThrowIfDuplicate, ref _N_Partition_closure_28391._N_nsize_28377);
				}
				return dummy;
			}
		}

		private sealed class _N_closureOf_Sum_28583<TAccumulator>
		{
			internal Function<T, T, int> _N_cmp_28590;

			internal int _N_sz_28588;

			internal _N_closureOf_Sum_28583()
			{
			}
		}

		private sealed class _N__N_lambda__28574__28592<TAccumulator> : Function<T, Node<T>, Node<T>>
		{
			[SpecialName]
			private _N_closureOf_Sum_28583<TAccumulator> _N_Sum_closure_28596;

			public _N__N_lambda__28574__28592(_N_closureOf_Sum_28583<TAccumulator> _N_Sum_closure_28596)
			{
				this._N_Sum_closure_28596 = _N_Sum_closure_28596;
			}

			[SpecialName]
			public sealed override Node<T> apply(T value, Node<T> tree)
			{
				return tree.Insert(value, _N_Sum_closure_28596._N_cmp_28590, InsertOptions.Replace, ref _N_Sum_closure_28596._N_sz_28588);
			}
		}

		private sealed class _N_closureOf_Subtract_28615<TAccumulator>
		{
			internal Function<T, T, int> _N_cmp_28622;

			internal int _N_sz_28620;

			internal _N_closureOf_Subtract_28615()
			{
			}
		}

		private sealed class _N__N_lambda__28606__28624<TAccumulator> : Function<T, Node<T>, Node<T>>
		{
			[SpecialName]
			private _N_closureOf_Subtract_28615<TAccumulator> _N_Subtract_closure_28628;

			public _N__N_lambda__28606__28624(_N_closureOf_Subtract_28615<TAccumulator> _N_Subtract_closure_28628)
			{
				this._N_Subtract_closure_28628 = _N_Subtract_closure_28628;
			}

			[SpecialName]
			public sealed override Node<T> apply(T value, Node<T> tree)
			{
				return tree.Delete(value, _N_Subtract_closure_28628._N_cmp_28622, DeleteOptions.IgnoreMissed, ref _N_Subtract_closure_28628._N_sz_28620);
			}
		}

		private sealed class _N_closureOf_Intersect_28648<TAccumulator>
		{
			internal Function<T, T, int> _N_cmp_28659;

			internal int _N_sz_28657;

			internal T _N_outValue_28655;

			internal Node<T> _N__N_closurised_this_ptr_28653;

			internal _N_closureOf_Intersect_28648()
			{
			}
		}

		private sealed class _N__N_lambda__28639__28661<TAccumulator> : Function<T, Node<T>, Node<T>>
		{
			[SpecialName]
			private _N_closureOf_Intersect_28648<TAccumulator> _N_Intersect_closure_28665;

			public _N__N_lambda__28639__28661(_N_closureOf_Intersect_28648<TAccumulator> _N_Intersect_closure_28665)
			{
				this._N_Intersect_closure_28665 = _N_Intersect_closure_28665;
			}

			[SpecialName]
			public sealed override Node<T> apply(T value, Node<T> tree)
			{
				return (!_N_Intersect_closure_28665._N__N_closurised_this_ptr_28653.TryGet(value, _N_Intersect_closure_28665._N_cmp_28659, out _N_Intersect_closure_28665._N_outValue_28655)) ? tree : tree.Insert(value, _N_Intersect_closure_28665._N_cmp_28659, InsertOptions.ThrowIfDuplicate, ref _N_Intersect_closure_28665._N_sz_28657);
			}
		}

		private sealed class _N_closureOf_Xor_28696<TAccumulator>
		{
			internal Node<T> _N_that_28709;

			internal Function<T, T, int> _N_cmp_28707;

			internal int _N_sz_28705;

			internal T _N_outValue_28703;

			internal Node<T> _N__N_closurised_this_ptr_28701;

			internal _N_closureOf_Xor_28696()
			{
			}
		}

		private sealed class _N__N_lambda__28680__28711<TAccumulator> : Function<T, Node<T>, Node<T>>
		{
			[SpecialName]
			private _N_closureOf_Xor_28696<TAccumulator> _N_Xor_closure_28715;

			public _N__N_lambda__28680__28711(_N_closureOf_Xor_28696<TAccumulator> _N_Xor_closure_28715)
			{
				this._N_Xor_closure_28715 = _N_Xor_closure_28715;
			}

			[SpecialName]
			public sealed override Node<T> apply(T value, Node<T> tree)
			{
				return (!_N_Xor_closure_28715._N__N_closurised_this_ptr_28701.TryGet(value, _N_Xor_closure_28715._N_cmp_28707, out _N_Xor_closure_28715._N_outValue_28703)) ? tree.Insert(value, _N_Xor_closure_28715._N_cmp_28707, InsertOptions.ThrowIfDuplicate, ref _N_Xor_closure_28715._N_sz_28705) : tree;
			}
		}

		private sealed class _N__N_lambda__28687__28723<TAccumulator> : Function<T, Node<T>, Node<T>>
		{
			[SpecialName]
			private _N_closureOf_Xor_28696<TAccumulator> _N_Xor_closure_28727;

			public _N__N_lambda__28687__28723(_N_closureOf_Xor_28696<TAccumulator> _N_Xor_closure_28727)
			{
				this._N_Xor_closure_28727 = _N_Xor_closure_28727;
			}

			[SpecialName]
			public sealed override Node<T> apply(T value, Node<T> tree)
			{
				return (!_N_Xor_closure_28727._N_that_28709.TryGet(value, _N_Xor_closure_28727._N_cmp_28707, out _N_Xor_closure_28727._N_outValue_28703)) ? tree.Insert(value, _N_Xor_closure_28727._N_cmp_28707, InsertOptions.ThrowIfDuplicate, ref _N_Xor_closure_28727._N_sz_28705) : tree;
			}
		}

		private sealed class _N__N_lambda__28736__28744 : Function<T, List<T>, List<T>>
		{
			[SpecialName]
			public static readonly _N__N_lambda__28736__28744 Instance = new _N__N_lambda__28736__28744();

			[SpecialName]
			public sealed override List<T> apply(T value, List<T> lst)
			{
				lst.Add(value);
				return lst;
			}
		}

		private sealed class _N__N_lambda__28758__28766 : Function<T, list<T>, list<T>>
		{
			[SpecialName]
			public static readonly _N__N_lambda__28758__28766 Instance = new _N__N_lambda__28758__28766();

			[SpecialName]
			public sealed override list<T> apply(T _N__28756, list<T> _N__28757)
			{
				return new list<T>.Cons(_N__28756, _N__28757);
			}
		}

		private sealed class _N_closureOf_MapToArray_28786<U>
		{
			internal Function<T, U> _N_fn_28791;

			internal _N_closureOf_MapToArray_28786()
			{
			}
		}

		private sealed class _N__N_lambda__28778__28793<U> : Function<T, List<U>, List<U>>
		{
			[SpecialName]
			private _N_closureOf_MapToArray_28786<U> _N_MapToArray_closure_28797;

			public _N__N_lambda__28778__28793(_N_closureOf_MapToArray_28786<U> _N_MapToArray_closure_28797)
			{
				this._N_MapToArray_closure_28797 = _N_MapToArray_closure_28797;
			}

			[SpecialName]
			public sealed override List<U> apply(T value, List<U> lst)
			{
				lst.Add(_N_MapToArray_closure_28797._N_fn_28791.apply(value));
				return lst;
			}
		}

		private sealed class _N_closureOf_MapToList_28812<U>
		{
			internal Function<T, U> _N_fn_28817;

			internal _N_closureOf_MapToList_28812()
			{
			}
		}

		private sealed class _N__N_lambda__28804__28819<U> : Function<T, list<U>, list<U>>
		{
			[SpecialName]
			private _N_closureOf_MapToList_28812<U> _N_MapToList_closure_28823;

			public _N__N_lambda__28804__28819(_N_closureOf_MapToList_28812<U> _N_MapToList_closure_28823)
			{
				this._N_MapToList_closure_28823 = _N_MapToList_closure_28823;
			}

			[SpecialName]
			public sealed override list<U> apply(T value, list<U> acc)
			{
				return new list<U>.Cons(_N_MapToList_closure_28823._N_fn_28817.apply(value), acc);
			}
		}

		private sealed class _N_closureOf_ToString_28843
		{
			internal string _N_delim_28848;

			internal _N_closureOf_ToString_28843()
			{
			}
		}

		private sealed class _N__N_lambda__28833__28850 : Function<T, StringBuilder, StringBuilder>
		{
			[SpecialName]
			private _N_closureOf_ToString_28843 _N_ToString_closure_28854;

			public _N__N_lambda__28833__28850(_N_closureOf_ToString_28843 _N_ToString_closure_28854)
			{
				this._N_ToString_closure_28854 = _N_ToString_closure_28854;
			}

			[SpecialName]
			public sealed override StringBuilder apply(T value, StringBuilder sb)
			{
				return sb.Append(value).Append(_N_ToString_closure_28854._N_delim_28848);
			}
		}

		private sealed class _N__N_lambda__28863__28871 : Function<T, int, int>
		{
			[SpecialName]
			public static readonly _N__N_lambda__28863__28871 Instance = new _N__N_lambda__28863__28871();

			[SpecialName]
			public sealed override int apply(T val, int hash)
			{
				return (hash ^ val.GetHashCode()) * 5 + hash;
			}
		}

		private static readonly CmpBase _cmpReplacement;

		public int Count
		{
			get
			{
				checked
				{
					int result;
					if (this == Leaf._N_constant_object)
					{
						result = 0;
					}
					else if (this is Node2)
					{
						Node2 node = (Node2)this;
						result = 1 + node.low.Count + node.hi.Count;
					}
					else
					{
						if (!(this is Node3))
						{
							throw new MatchFailureException();
						}
						Node3 node2 = (Node3)this;
						result = 2 + node2.low.Count + node2.mid.Count + node2.hi.Count;
					}
					return result;
				}
			}
		}

		static Node()
		{
			_cmpReplacement = new CmpReplacement();
		}

		public Node<T> Insert(T value, Function<T, T, int> cmp, InsertOptions options, ref int size)
		{
			_N_closureOf_Insert_28016 n_closureOf_Insert_ = new _N_closureOf_Insert_28016();
			n_closureOf_Insert_._N_value_28033 = value;
			n_closureOf_Insert_._N_cmp_28031 = cmp;
			n_closureOf_Insert_._N_options_28029 = options;
			n_closureOf_Insert_._N_replaced_28021 = false;
			Node<T> result = ((!_N_insert_28047(n_closureOf_Insert_, this)) ? new Node2(n_closureOf_Insert_._N_retL_28027, n_closureOf_Insert_._N_retV_28025, n_closureOf_Insert_._N_retH_28023) : n_closureOf_Insert_._N_retL_28027);
			checked
			{
				if (!n_closureOf_Insert_._N_replaced_28021)
				{
					size++;
				}
				return result;
			}
		}

		public Node<T> Delete(T value, Function<T, T, int> cmp, DeleteOptions options, ref int size)
		{
			_N_closureOf_Delete_28168 n_closureOf_Delete_ = new _N_closureOf_Delete_28168();
			n_closureOf_Delete_._N_value_28181 = value;
			n_closureOf_Delete_._N_options_28179 = options;
			n_closureOf_Delete_._N_retValue_28177 = default(T);
			n_closureOf_Delete_._N_retNode_28175 = null;
			n_closureOf_Delete_._N_isMissed_28173 = false;
			_N_delete_28194(n_closureOf_Delete_, this, new CmpValue(n_closureOf_Delete_._N_value_28181, cmp));
			checked
			{
				Node<T> result;
				if (n_closureOf_Delete_._N_isMissed_28173)
				{
					result = this;
				}
				else
				{
					size--;
					result = n_closureOf_Delete_._N_retNode_28175;
				}
				return result;
			}
		}

		public Nemerle.Builtins.Tuple<int, Node<T>> Filter(Function<T, T, int> cmp, Function<T, bool> fn)
		{
			_N_closureOf_Filter_28332 n_closureOf_Filter_ = new _N_closureOf_Filter_28332();
			n_closureOf_Filter_._N_cmp_28341 = cmp;
			n_closureOf_Filter_._N_fn_28339 = fn;
			n_closureOf_Filter_._N_size_28337 = 0;
			Function<T, Node<T>, Node<T>> fn2 = new _N_filterFn__28343(n_closureOf_Filter_);
			return new Nemerle.Builtins.Tuple<int, Node<T>>(n_closureOf_Filter_._N_size_28337, Fold(Leaf._N_constant_object, fn2));
		}

		public Nemerle.Builtins.Tuple<int, Node<T>, int, Node<T>> Partition(Function<T, T, int> cmp, Function<T, bool> fn)
		{
			_N_closureOf_Partition_28370 n_closureOf_Partition_ = new _N_closureOf_Partition_28370();
			n_closureOf_Partition_._N_cmp_28385 = cmp;
			n_closureOf_Partition_._N_fn_28383 = fn;
			n_closureOf_Partition_._N_ysize_28381 = 0;
			n_closureOf_Partition_._N_ytree_28379 = Leaf._N_constant_object;
			n_closureOf_Partition_._N_nsize_28377 = 0;
			n_closureOf_Partition_._N_ntree_28375 = Leaf._N_constant_object;
			Function<T, object, object> fn2 = new _N_partitionFn__28387(n_closureOf_Partition_);
			object obj = Fold(null, fn2);
			return new Nemerle.Builtins.Tuple<int, Node<T>, int, Node<T>>(n_closureOf_Partition_._N_ysize_28381, n_closureOf_Partition_._N_ytree_28379, n_closureOf_Partition_._N_nsize_28377, n_closureOf_Partition_._N_ntree_28375);
		}

		public bool TryGet(T value, Function<T, T, int> cmp, out T outValue)
		{
			outValue = value;
			Node<T> node = this;
			int result;
			while (true)
			{
				if (node == Leaf._N_constant_object)
				{
					result = 0;
					break;
				}
				if (node is Node2)
				{
					Node2 node2 = (Node2)node;
					int num = cmp.apply(value, node2.value1);
					int num2 = num;
					if (num2 < 0)
					{
						node = node2.low;
						continue;
					}
					int num3 = num;
					if (num3 > 0)
					{
						node = node2.hi;
						continue;
					}
					outValue = node2.value1;
					result = 1;
					break;
				}
				if (node is Node3)
				{
					Node3 node3 = (Node3)node;
					int num4 = cmp.apply(value, node3.value1);
					int num5 = num4;
					if (num5 < 0)
					{
						node = node3.low;
						continue;
					}
					int num6 = num4;
					if (num6 > 0)
					{
						int num7 = cmp.apply(value, node3.value2);
						int num8 = num7;
						if (num8 < 0)
						{
							node = node3.mid;
							continue;
						}
						int num9 = num7;
						if (num9 > 0)
						{
							node = node3.hi;
							continue;
						}
						outValue = node3.value2;
						result = 1;
						break;
					}
					outValue = node3.value1;
					result = 1;
					break;
				}
				throw new MatchFailureException();
			}
			return (byte)result != 0;
		}

		public IEnumerable<T> Enumerate()
		{
			return ToArray();
		}

		public TAccumulator Fold<TAccumulator>(TAccumulator acc, Function<T, TAccumulator, TAccumulator> fn)
		{
			return FoldLeft(acc, fn);
		}

		public TAccumulator FoldLeft<TAccumulator>(TAccumulator acc, Function<T, TAccumulator, TAccumulator> fn)
		{
			TAccumulator val = default(TAccumulator);
			TAccumulator result;
			if (this == Leaf._N_constant_object)
			{
				result = acc;
			}
			else if (this is Node2)
			{
				Node2 node = (Node2)this;
				val = node.low.FoldLeft(acc, fn);
				val = fn.apply(node.value1, val);
				val = node.hi.FoldLeft(val, fn);
				result = val;
			}
			else
			{
				if (!(this is Node3))
				{
					throw new MatchFailureException();
				}
				Node3 node2 = (Node3)this;
				val = node2.low.FoldLeft(acc, fn);
				val = fn.apply(node2.value1, val);
				val = node2.mid.FoldLeft(val, fn);
				val = fn.apply(node2.value2, val);
				val = node2.hi.FoldLeft(val, fn);
				result = val;
			}
			return result;
		}

		public TAccumulator FoldRight<TAccumulator>(TAccumulator acc, Function<T, TAccumulator, TAccumulator> fn)
		{
			TAccumulator val = default(TAccumulator);
			TAccumulator result;
			if (this == Leaf._N_constant_object)
			{
				result = acc;
			}
			else if (this is Node2)
			{
				Node2 node = (Node2)this;
				val = node.hi.FoldRight(acc, fn);
				val = fn.apply(node.value1, val);
				val = node.low.FoldRight(val, fn);
				result = val;
			}
			else
			{
				if (!(this is Node3))
				{
					throw new MatchFailureException();
				}
				Node3 node2 = (Node3)this;
				val = node2.hi.FoldRight(acc, fn);
				val = fn.apply(node2.value2, val);
				val = node2.mid.FoldRight(val, fn);
				val = fn.apply(node2.value1, val);
				val = node2.low.FoldRight(val, fn);
				result = val;
			}
			return result;
		}

		public bool ForAll<TAccumulator>(Function<T, bool> fn)
		{
			int result;
			if (this == Leaf._N_constant_object)
			{
				result = 1;
			}
			else if (this is Node2)
			{
				Node2 node = (Node2)this;
				result = ((fn.apply(node.value1) && node.low.ForAll<object>(fn) && node.hi.ForAll<object>(fn)) ? 1 : 0);
			}
			else
			{
				if (!(this is Node3))
				{
					throw new MatchFailureException();
				}
				Node3 node2 = (Node3)this;
				result = ((fn.apply(node2.value1) && fn.apply(node2.value2) && node2.low.ForAll<object>(fn) && node2.mid.ForAll<object>(fn) && node2.hi.ForAll<object>(fn)) ? 1 : 0);
			}
			return (byte)result != 0;
		}

		public bool Exists<TAccumulator>(Function<T, bool> fn)
		{
			int result;
			if (this == Leaf._N_constant_object)
			{
				result = 0;
			}
			else if (this is Node2)
			{
				Node2 node = (Node2)this;
				result = ((fn.apply(node.value1) || node.low.Exists<object>(fn) || node.hi.Exists<object>(fn)) ? 1 : 0);
			}
			else
			{
				if (!(this is Node3))
				{
					throw new MatchFailureException();
				}
				Node3 node2 = (Node3)this;
				result = ((fn.apply(node2.value1) || fn.apply(node2.value2) || node2.low.Exists<object>(fn) || node2.mid.Exists<object>(fn) || node2.hi.Exists<object>(fn)) ? 1 : 0);
			}
			return (byte)result != 0;
		}

		public Node<T> Sum<TAccumulator>(ref int size, Node<T> that, Function<T, T, int> cmp)
		{
			_N_closureOf_Sum_28583<TAccumulator> n_closureOf_Sum_ = new _N_closureOf_Sum_28583<TAccumulator>();
			n_closureOf_Sum_._N_cmp_28590 = cmp;
			n_closureOf_Sum_._N_sz_28588 = size;
			Function<T, Node<T>, Node<T>> fn = new _N__N_lambda__28574__28592<TAccumulator>(n_closureOf_Sum_);
			Node<T> result = that.Fold(this, fn);
			size = n_closureOf_Sum_._N_sz_28588;
			return result;
		}

		public Node<T> Subtract<TAccumulator>(ref int size, Node<T> that, Function<T, T, int> cmp)
		{
			_N_closureOf_Subtract_28615<TAccumulator> n_closureOf_Subtract_ = new _N_closureOf_Subtract_28615<TAccumulator>();
			n_closureOf_Subtract_._N_cmp_28622 = cmp;
			n_closureOf_Subtract_._N_sz_28620 = size;
			Function<T, Node<T>, Node<T>> fn = new _N__N_lambda__28606__28624<TAccumulator>(n_closureOf_Subtract_);
			Node<T> result = that.Fold(this, fn);
			size = n_closureOf_Subtract_._N_sz_28620;
			return result;
		}

		public Node<T> Intersect<TAccumulator>(ref int size, Node<T> that, Function<T, T, int> cmp)
		{
			_N_closureOf_Intersect_28648<TAccumulator> n_closureOf_Intersect_ = new _N_closureOf_Intersect_28648<TAccumulator>();
			n_closureOf_Intersect_._N_cmp_28659 = cmp;
			n_closureOf_Intersect_._N__N_closurised_this_ptr_28653 = this;
			n_closureOf_Intersect_._N_sz_28657 = 0;
			Leaf n_constant_object = Leaf._N_constant_object;
			Function<T, Node<T>, Node<T>> fn = new _N__N_lambda__28639__28661<TAccumulator>(n_closureOf_Intersect_);
			Node<T> result = that.Fold(n_constant_object, fn);
			size = n_closureOf_Intersect_._N_sz_28657;
			return result;
		}

		public Node<T> Xor<TAccumulator>(ref int size, Node<T> that, Function<T, T, int> cmp)
		{
			_N_closureOf_Xor_28696<TAccumulator> n_closureOf_Xor_ = new _N_closureOf_Xor_28696<TAccumulator>();
			n_closureOf_Xor_._N_that_28709 = that;
			n_closureOf_Xor_._N_cmp_28707 = cmp;
			n_closureOf_Xor_._N__N_closurised_this_ptr_28701 = this;
			n_closureOf_Xor_._N_sz_28705 = 0;
			Leaf n_constant_object = Leaf._N_constant_object;
			Node<T> n_that_ = n_closureOf_Xor_._N_that_28709;
			Function<T, Node<T>, Node<T>> fn = new _N__N_lambda__28680__28711<TAccumulator>(n_closureOf_Xor_);
			Node<T> acc = n_that_.Fold(n_constant_object, fn);
			Function<T, Node<T>, Node<T>> fn2 = new _N__N_lambda__28687__28723<TAccumulator>(n_closureOf_Xor_);
			Node<T> result = Fold(acc, fn2);
			size = n_closureOf_Xor_._N_sz_28705;
			return result;
		}

		public T[] ToArray()
		{
			List<T> acc = new List<T>();
			Function<T, List<T>, List<T>> instance = _N__N_lambda__28736__28744.Instance;
			return FoldLeft(acc, instance).ToArray();
		}

		public list<T> ToList()
		{
			list<T>.Nil n_constant_object = list<T>.Nil._N_constant_object;
			Function<T, list<T>, list<T>> instance = _N__N_lambda__28758__28766.Instance;
			return FoldRight(n_constant_object, instance);
		}

		public U[] MapToArray<U>(Function<T, U> fn)
		{
			_N_closureOf_MapToArray_28786<U> n_closureOf_MapToArray_ = new _N_closureOf_MapToArray_28786<U>();
			n_closureOf_MapToArray_._N_fn_28791 = fn;
			List<U> acc = new List<U>();
			Function<T, List<U>, List<U>> fn2 = new _N__N_lambda__28778__28793<U>(n_closureOf_MapToArray_);
			return FoldLeft(acc, fn2).ToArray();
		}

		public list<U> MapToList<U>(Function<T, U> fn)
		{
			_N_closureOf_MapToList_28812<U> n_closureOf_MapToList_ = new _N_closureOf_MapToList_28812<U>();
			n_closureOf_MapToList_._N_fn_28817 = fn;
			list<U>.Nil n_constant_object = list<U>.Nil._N_constant_object;
			Function<T, list<U>, list<U>> fn2 = new _N__N_lambda__28804__28819<U>(n_closureOf_MapToList_);
			return FoldRight(n_constant_object, fn2);
		}

		public string ToString(string first, string delim, string last)
		{
			_N_closureOf_ToString_28843 n_closureOf_ToString_ = new _N_closureOf_ToString_28843();
			n_closureOf_ToString_._N_delim_28848 = delim;
			StringBuilder stringBuilder = new StringBuilder().Append(first);
			StringBuilder acc = stringBuilder;
			Function<T, StringBuilder, StringBuilder> fn = new _N__N_lambda__28833__28850(n_closureOf_ToString_);
			stringBuilder = FoldLeft(acc, fn);
			checked
			{
				if (stringBuilder.Length > first.Length)
				{
					stringBuilder.Length -= n_closureOf_ToString_._N_delim_28848.Length;
				}
				StringBuilder stringBuilder2 = stringBuilder.Append(last);
				return stringBuilder.ToString();
			}
		}

		public override int GetHashCode()
		{
			Function<T, int, int> instance = _N__N_lambda__28863__28871.Instance;
			return FoldLeft(0, instance);
		}

		[SpecialName]
		public abstract override int _N_GetVariantCode();

		[SpecialName]
		public static int _N_GetVariantCodeSafe(Node<T> x)
		{
			return ((object)x != null) ? x._N_GetVariantCode() : (-1);
		}

		[SpecialName]
		public static int _N_GetVariantCodeObject(object x)
		{
			return (!(x is Node<T>)) ? (-1) : ((Node<T>)x)._N_GetVariantCode();
		}

		private static bool _N_eq_28035(InsertOptions options, T value)
		{
			return options switch
			{
				InsertOptions.Replace => true, 
				InsertOptions.ThrowIfDuplicate => throw new ArgumentException("\"" + Convert.ToString(value) + "\" already in the tree"), 
				_ => throw new ArgumentException("The parameter options has invalid value: \"" + Convert.ToString(options) + "\"", "options"), 
			};
		}

		private static bool _N_insert_28047(_N_closureOf_Insert_28016 _N_Insert_cp_28046, Node<T> _N_wildcard_2850)
		{
			int result;
			if (_N_wildcard_2850 == Leaf._N_constant_object)
			{
				_N_Insert_cp_28046._N_retL_28027 = Leaf._N_constant_object;
				_N_Insert_cp_28046._N_retV_28025 = _N_Insert_cp_28046._N_value_28033;
				_N_Insert_cp_28046._N_retH_28023 = Leaf._N_constant_object;
				result = 0;
			}
			else if (_N_wildcard_2850 is Node2)
			{
				Node2 node = (Node2)_N_wildcard_2850;
				int num = _N_Insert_cp_28046._N_cmp_28031.apply(_N_Insert_cp_28046._N_value_28033, node.value1);
				if (num < 0)
				{
					if (_N_insert_28047(_N_Insert_cp_28046, node.low))
					{
						_N_Insert_cp_28046._N_retL_28027 = new Node2(_N_Insert_cp_28046._N_retL_28027, node.value1, node.hi);
						result = 1;
					}
					else
					{
						_N_Insert_cp_28046._N_retL_28027 = new Node3(_N_Insert_cp_28046._N_retL_28027, _N_Insert_cp_28046._N_retV_28025, _N_Insert_cp_28046._N_retH_28023, node.value1, node.hi);
						result = 1;
					}
				}
				else if (num > 0)
				{
					if (_N_insert_28047(_N_Insert_cp_28046, node.hi))
					{
						_N_Insert_cp_28046._N_retL_28027 = new Node2(node.low, node.value1, _N_Insert_cp_28046._N_retL_28027);
						result = 1;
					}
					else
					{
						_N_Insert_cp_28046._N_retL_28027 = new Node3(node.low, node.value1, _N_Insert_cp_28046._N_retL_28027, _N_Insert_cp_28046._N_retV_28025, _N_Insert_cp_28046._N_retH_28023);
						result = 1;
					}
				}
				else
				{
					_N_Insert_cp_28046._N_replaced_28021 = _N_eq_28035(_N_Insert_cp_28046._N_options_28029, _N_Insert_cp_28046._N_value_28033);
					_N_Insert_cp_28046._N_retL_28027 = new Node2(node.low, _N_Insert_cp_28046._N_value_28033, node.hi);
					result = 1;
				}
			}
			else
			{
				if (!(_N_wildcard_2850 is Node3))
				{
					throw new MatchFailureException();
				}
				Node3 node2 = (Node3)_N_wildcard_2850;
				int num = _N_Insert_cp_28046._N_cmp_28031.apply(_N_Insert_cp_28046._N_value_28033, node2.value1);
				if (num < 0)
				{
					if (_N_insert_28047(_N_Insert_cp_28046, node2.low))
					{
						_N_Insert_cp_28046._N_retL_28027 = new Node3(_N_Insert_cp_28046._N_retL_28027, node2.value1, node2.mid, node2.value2, node2.hi);
						result = 1;
					}
					else
					{
						_N_Insert_cp_28046._N_retL_28027 = new Node2(_N_Insert_cp_28046._N_retL_28027, _N_Insert_cp_28046._N_retV_28025, _N_Insert_cp_28046._N_retH_28023);
						_N_Insert_cp_28046._N_retV_28025 = node2.value1;
						_N_Insert_cp_28046._N_retH_28023 = new Node2(node2.mid, node2.value2, node2.hi);
						result = 0;
					}
				}
				else if (num > 0)
				{
					num = _N_Insert_cp_28046._N_cmp_28031.apply(_N_Insert_cp_28046._N_value_28033, node2.value2);
					if (num < 0)
					{
						if (_N_insert_28047(_N_Insert_cp_28046, node2.mid))
						{
							_N_Insert_cp_28046._N_retL_28027 = new Node3(node2.low, node2.value1, _N_Insert_cp_28046._N_retL_28027, node2.value2, node2.hi);
							result = 1;
						}
						else
						{
							_N_Insert_cp_28046._N_retL_28027 = new Node2(node2.low, node2.value1, _N_Insert_cp_28046._N_retL_28027);
							_N_Insert_cp_28046._N_retH_28023 = new Node2(_N_Insert_cp_28046._N_retH_28023, node2.value2, node2.hi);
							result = 0;
						}
					}
					else if (num > 0)
					{
						if (_N_insert_28047(_N_Insert_cp_28046, node2.hi))
						{
							_N_Insert_cp_28046._N_retL_28027 = new Node3(node2.low, node2.value1, node2.mid, node2.value2, _N_Insert_cp_28046._N_retL_28027);
							result = 1;
						}
						else
						{
							_N_Insert_cp_28046._N_retH_28023 = new Node2(_N_Insert_cp_28046._N_retL_28027, _N_Insert_cp_28046._N_retV_28025, _N_Insert_cp_28046._N_retH_28023);
							_N_Insert_cp_28046._N_retL_28027 = new Node2(node2.low, node2.value1, node2.mid);
							_N_Insert_cp_28046._N_retV_28025 = node2.value2;
							result = 0;
						}
					}
					else
					{
						_N_Insert_cp_28046._N_replaced_28021 = _N_eq_28035(_N_Insert_cp_28046._N_options_28029, _N_Insert_cp_28046._N_value_28033);
						_N_Insert_cp_28046._N_retL_28027 = new Node3(node2.low, node2.value1, node2.mid, _N_Insert_cp_28046._N_value_28033, node2.hi);
						result = 1;
					}
				}
				else
				{
					_N_Insert_cp_28046._N_replaced_28021 = _N_eq_28035(_N_Insert_cp_28046._N_options_28029, _N_Insert_cp_28046._N_value_28033);
					_N_Insert_cp_28046._N_retL_28027 = new Node3(node2.low, _N_Insert_cp_28046._N_value_28033, node2.mid, node2.value2, node2.hi);
					result = 1;
				}
			}
			return (byte)result != 0;
		}

		private static bool _N_missed_28184(_N_closureOf_Delete_28168 _N_Delete_cp_28183, Node<T> node)
		{
			if (_N_Delete_cp_28183._N_options_28179 == DeleteOptions.ThrowIfMissed)
			{
				throw new ArgumentException("\"" + Convert.ToString(_N_Delete_cp_28183._N_value_28181) + "\" not in the tree");
			}
			if (_N_Delete_cp_28183._N_options_28179 == DeleteOptions.IgnoreMissed)
			{
				_N_Delete_cp_28183._N_isMissed_28173 = true;
				_N_Delete_cp_28183._N_retNode_28175 = node;
				return false;
			}
			throw new MatchFailureException();
		}

		private static bool _N_delete_28194(_N_closureOf_Delete_28168 _N_Delete_cp_28193, Node<T> node, CmpBase cmp)
		{
			T val = default(T);
			int result;
			if (node == Leaf._N_constant_object)
			{
				result = (_N_missed_28184(_N_Delete_cp_28193, (Leaf)node) ? 1 : 0);
			}
			else if (node is Node2)
			{
				Node2 node2 = (Node2)node;
				int num = cmp.Cmp21(node2);
				if (num < 0)
				{
					bool flag = _N_delete_28194(_N_Delete_cp_28193, node2.low, cmp);
					val = node2.value1;
					if (flag)
					{
						Node<T> hi = node2.hi;
						if (hi == Leaf._N_constant_object)
						{
							throw new AssertionException("lib\\TwoThreeTree.n", 237, "", "");
						}
						if (hi is Node2)
						{
							node2 = (Node2)hi;
							_N_Delete_cp_28193._N_retNode_28175 = new Node3(_N_Delete_cp_28193._N_retNode_28175, val, node2.low, node2.value1, node2.hi);
							result = 1;
						}
						else
						{
							if (!(hi is Node3))
							{
								throw new MatchFailureException();
							}
							Node3 node3 = (Node3)hi;
							_N_Delete_cp_28193._N_retNode_28175 = new Node2(new Node2(_N_Delete_cp_28193._N_retNode_28175, val, node3.low), node3.value1, new Node2(node3.mid, node3.value2, node3.hi));
							result = 0;
						}
					}
					else
					{
						_N_Delete_cp_28193._N_retNode_28175 = new Node2(_N_Delete_cp_28193._N_retNode_28175, val, node2.hi);
						result = 0;
					}
				}
				else if (num > 0)
				{
					result = (_N_balanceHi_28208(_N_Delete_cp_28193, _N_delete_28194(_N_Delete_cp_28193, node2.hi, cmp), node2.value1, node2) ? 1 : 0);
				}
				else
				{
					Node<T> hi = node2.low;
					if (hi == Leaf._N_constant_object)
					{
						_N_Delete_cp_28193._N_retValue_28177 = node2.value1;
						_N_Delete_cp_28193._N_retNode_28175 = Leaf._N_constant_object;
						result = 1;
					}
					else
					{
						result = (_N_balanceHi_28208(_N_Delete_cp_28193, _N_delete_28194(_N_Delete_cp_28193, node2.hi, _cmpReplacement), _N_Delete_cp_28193._N_retValue_28177, node2) ? 1 : 0);
					}
				}
			}
			else
			{
				if (!(node is Node3))
				{
					throw new MatchFailureException();
				}
				Node3 node3 = (Node3)node;
				int num = cmp.Cmp31(node3);
				if (num < 0)
				{
					bool flag = _N_delete_28194(_N_Delete_cp_28193, node3.low, cmp);
					val = node3.value1;
					if (flag)
					{
						Node<T> hi = node3.mid;
						if (hi == Leaf._N_constant_object)
						{
							throw new AssertionException("lib\\TwoThreeTree.n", 297, "", "");
						}
						if (hi is Node2)
						{
							Node2 node2 = (Node2)hi;
							_N_Delete_cp_28193._N_retNode_28175 = new Node2(new Node3(_N_Delete_cp_28193._N_retNode_28175, val, node2.low, node2.value1, node2.hi), node3.value2, node3.hi);
							result = 0;
						}
						else
						{
							if (!(hi is Node3))
							{
								throw new MatchFailureException();
							}
							Node3 node4 = (Node3)hi;
							_N_Delete_cp_28193._N_retNode_28175 = new Node3(new Node2(_N_Delete_cp_28193._N_retNode_28175, val, node4.low), node4.value1, new Node2(node4.mid, node4.value2, node4.hi), node3.value2, node3.hi);
							result = 0;
						}
					}
					else
					{
						_N_Delete_cp_28193._N_retNode_28175 = new Node3(_N_Delete_cp_28193._N_retNode_28175, val, node3.mid, node3.value2, node3.hi);
						result = 0;
					}
				}
				else if (num > 0)
				{
					num = cmp.Cmp32(node3);
					if (num < 0)
					{
						result = (_N_balanceMid_28249(_N_Delete_cp_28193, _N_delete_28194(_N_Delete_cp_28193, node3.mid, cmp), node3.value1, node3) ? 1 : 0);
					}
					else if (num > 0)
					{
						result = (_N_balanceHi_28267(_N_Delete_cp_28193, _N_delete_28194(_N_Delete_cp_28193, node3.hi, cmp), node3.value2, node3) ? 1 : 0);
					}
					else
					{
						Node<T> hi = node3.low;
						if (hi == Leaf._N_constant_object)
						{
							_N_Delete_cp_28193._N_retValue_28177 = node3.value2;
							_N_Delete_cp_28193._N_retNode_28175 = new Node2(Leaf._N_constant_object, node3.value1, Leaf._N_constant_object);
							result = 0;
						}
						else
						{
							result = (_N_balanceHi_28267(_N_Delete_cp_28193, _N_delete_28194(_N_Delete_cp_28193, node3.hi, _cmpReplacement), _N_Delete_cp_28193._N_retValue_28177, node3) ? 1 : 0);
						}
					}
				}
				else
				{
					Node<T> hi = node3.low;
					if (hi == Leaf._N_constant_object)
					{
						_N_Delete_cp_28193._N_retValue_28177 = node3.value1;
						_N_Delete_cp_28193._N_retNode_28175 = new Node2(Leaf._N_constant_object, node3.value2, Leaf._N_constant_object);
						result = 0;
					}
					else
					{
						result = (_N_balanceMid_28249(_N_Delete_cp_28193, _N_delete_28194(_N_Delete_cp_28193, node3.mid, _cmpReplacement), _N_Delete_cp_28193._N_retValue_28177, node3) ? 1 : 0);
					}
				}
			}
			return (byte)result != 0;
		}

		private static bool _N_balanceHi_28208(_N_closureOf_Delete_28168 _N_Delete_cp_28207, bool isEmpty, T value, Node2 node)
		{
			int result;
			if (isEmpty)
			{
				Node<T> low = node.low;
				if (low == Leaf._N_constant_object)
				{
					throw new AssertionException("lib\\TwoThreeTree.n", 258, "", "");
				}
				if (low is Node2)
				{
					Node2 node2 = (Node2)low;
					_N_Delete_cp_28207._N_retNode_28175 = new Node3(node2.low, node2.value1, node2.hi, value, _N_Delete_cp_28207._N_retNode_28175);
					result = 1;
				}
				else
				{
					if (!(low is Node3))
					{
						throw new MatchFailureException();
					}
					Node3 node3 = (Node3)low;
					_N_Delete_cp_28207._N_retNode_28175 = new Node2(new Node2(node3.low, node3.value1, node3.mid), node3.value2, new Node2(node3.hi, value, _N_Delete_cp_28207._N_retNode_28175));
					result = 0;
				}
			}
			else
			{
				_N_Delete_cp_28207._N_retNode_28175 = new Node2(node.low, value, _N_Delete_cp_28207._N_retNode_28175);
				result = 0;
			}
			return (byte)result != 0;
		}

		private static bool _N_balanceMid_28249(_N_closureOf_Delete_28168 _N_Delete_cp_28248, bool isEmpty, T value, Node3 node)
		{
			int result;
			if (isEmpty)
			{
				Node<T> low = node.low;
				if (low == Leaf._N_constant_object)
				{
					throw new AssertionException("lib\\TwoThreeTree.n", 318, "", "");
				}
				if (low is Node2)
				{
					Node2 node2 = (Node2)low;
					_N_Delete_cp_28248._N_retNode_28175 = new Node2(new Node3(node2.low, node2.value1, node2.hi, value, _N_Delete_cp_28248._N_retNode_28175), node.value2, node.hi);
					result = 0;
				}
				else
				{
					if (!(low is Node3))
					{
						throw new MatchFailureException();
					}
					Node3 node3 = (Node3)low;
					_N_Delete_cp_28248._N_retNode_28175 = new Node3(new Node2(node3.low, node3.value1, node3.mid), node3.value2, new Node2(node3.hi, value, _N_Delete_cp_28248._N_retNode_28175), node.value2, node.hi);
					result = 0;
				}
			}
			else
			{
				_N_Delete_cp_28248._N_retNode_28175 = new Node3(node.low, value, _N_Delete_cp_28248._N_retNode_28175, node.value2, node.hi);
				result = 0;
			}
			return (byte)result != 0;
		}

		private static bool _N_balanceHi_28267(_N_closureOf_Delete_28168 _N_Delete_cp_28266, bool isEmpty, T value, Node3 node)
		{
			int result;
			if (isEmpty)
			{
				Node<T> mid = node.mid;
				if (mid == Leaf._N_constant_object)
				{
					throw new AssertionException("lib\\TwoThreeTree.n", 339, "", "");
				}
				if (mid is Node2)
				{
					Node2 node2 = (Node2)mid;
					_N_Delete_cp_28266._N_retNode_28175 = new Node2(node.low, node.value1, new Node3(node2.low, node2.value1, node2.hi, value, _N_Delete_cp_28266._N_retNode_28175));
					result = 0;
				}
				else
				{
					if (!(mid is Node3))
					{
						throw new MatchFailureException();
					}
					Node3 node3 = (Node3)mid;
					_N_Delete_cp_28266._N_retNode_28175 = new Node3(node.low, node.value1, new Node2(node3.low, node3.value1, node3.mid), node3.value2, new Node2(node3.hi, value, _N_Delete_cp_28266._N_retNode_28175));
					result = 0;
				}
			}
			else
			{
				_N_Delete_cp_28266._N_retNode_28175 = new Node3(node.low, node.value1, node.mid, value, _N_Delete_cp_28266._N_retNode_28175);
				result = 0;
			}
			return (byte)result != 0;
		}
	}
}
