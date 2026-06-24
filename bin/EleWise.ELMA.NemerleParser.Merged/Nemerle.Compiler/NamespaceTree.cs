using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Nemerle.Builtins;
using Nemerle.Collections;
using Nemerle.Compiler.Parsetree;
using Nemerle.Core;
using Nemerle.Internal;
using Nemerle.Utility;

namespace Nemerle.Compiler;

public class NamespaceTree : ISupportRelocation
{
	[Variant("Nemerle.Compiler.NamespaceTree.TypeInfoCache.No,Nemerle.Compiler.NamespaceTree.TypeInfoCache.Cached,Nemerle.Compiler.NamespaceTree.TypeInfoCache.CachedAmbiguous,Nemerle.Compiler.NamespaceTree.TypeInfoCache.NotLoaded,Nemerle.Compiler.NamespaceTree.TypeInfoCache.NotLoadedList,Nemerle.Compiler.NamespaceTree.TypeInfoCache.MacroCall,Nemerle.Compiler.NamespaceTree.TypeInfoCache.NamespaceReference")]
	public abstract class TypeInfoCache : ISupportRelocation
	{
		[ConstantVariantOption]
		public class No : TypeInfoCache
		{
			public static readonly No _N_constant_object;

			[SpecialName]
			public static No _N_constant_object_generator()
			{
				return _N_constant_object;
			}

			static No()
			{
				_N_constant_object = new No();
			}

			[SpecialName]
			public override int _N_GetVariantCode()
			{
				return 0;
			}

			[RecordCtor]
			private No()
			{
			}
		}

		[VariantOption]
		public class Cached : TypeInfoCache
		{
			public readonly TypeInfo tycon;

			[SpecialName]
			public override int _N_GetVariantCode()
			{
				return 1;
			}

			[RecordCtor]
			public Cached([MappedMember("tycon")] TypeInfo tycon)
			{
				this.tycon = tycon;
			}
		}

		[VariantOption]
		public class CachedAmbiguous : TypeInfoCache
		{
			public readonly list<TypeInfo> elems;

			[SpecialName]
			public override int _N_GetVariantCode()
			{
				return 2;
			}

			[CompilerGenerated]
			internal override void RelocateImplInternal(RelocationInfo _info)
			{
				if (_info.VisitedObjects.ContainsKey(this))
				{
					return;
				}
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				list<TypeInfo> list = elems;
				if (list != null)
				{
					list = list;
					while (list is list<TypeInfo>.Cons)
					{
						TypeInfo hd = ((list<TypeInfo>.Cons)list).hd;
						list = ((list<TypeInfo>.Cons)list).tl;
						((ISupportRelocation)hd).RelocateImpl(_info);
						list = list;
					}
				}
			}

			[RecordCtor]
			public CachedAmbiguous([MappedMember("elems")] list<TypeInfo> elems)
			{
				this.elems = elems;
			}
		}

		[VariantOption]
		public class NotLoaded : TypeInfoCache
		{
			public readonly ExternalType e;

			[SpecialName]
			public override int _N_GetVariantCode()
			{
				return 3;
			}

			[CompilerGenerated]
			internal override void RelocateImplInternal(RelocationInfo _info)
			{
				if (!_info.VisitedObjects.ContainsKey(this))
				{
					base.RelocateImplInternal(_info);
					_info.VisitedObjects[this] = 0;
					e?.RelocateImplInternal(_info);
				}
			}

			[RecordCtor]
			public NotLoaded([MappedMember("e")] ExternalType e)
			{
				this.e = e;
			}
		}

		[VariantOption]
		public class NotLoadedList : TypeInfoCache
		{
			public readonly list<ExternalType> elems;

			[SpecialName]
			public override int _N_GetVariantCode()
			{
				return 4;
			}

			[CompilerGenerated]
			internal override void RelocateImplInternal(RelocationInfo _info)
			{
				if (_info.VisitedObjects.ContainsKey(this))
				{
					return;
				}
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				list<ExternalType> list = elems;
				if (list != null)
				{
					list = list;
					while (list is list<ExternalType>.Cons)
					{
						ExternalType hd = ((list<ExternalType>.Cons)list).hd;
						list = ((list<ExternalType>.Cons)list).tl;
						((ISupportRelocation)hd).RelocateImpl(_info);
						list = list;
					}
				}
			}

			[RecordCtor]
			public NotLoadedList([MappedMember("elems")] list<ExternalType> elems)
			{
				this.elems = elems;
			}
		}

		[VariantOption]
		public class MacroCall : TypeInfoCache
		{
			public readonly IMacro m;

			[SpecialName]
			public override int _N_GetVariantCode()
			{
				return 5;
			}

			[RecordCtor]
			public MacroCall([MappedMember("m")] IMacro m)
			{
				this.m = m;
			}
		}

		[ConstantVariantOption]
		public class NamespaceReference : TypeInfoCache
		{
			public static readonly NamespaceReference _N_constant_object;

			[SpecialName]
			public static NamespaceReference _N_constant_object_generator()
			{
				return _N_constant_object;
			}

			static NamespaceReference()
			{
				_N_constant_object = new NamespaceReference();
			}

			[SpecialName]
			public override int _N_GetVariantCode()
			{
				return 6;
			}

			[RecordCtor]
			private NamespaceReference()
			{
			}
		}

		[SpecialName]
		public abstract override int _N_GetVariantCode();

		[SpecialName]
		public static int _N_GetVariantCodeSafe(TypeInfoCache x)
		{
			return ((object)x != null) ? x._N_GetVariantCode() : (-1);
		}

		[SpecialName]
		public static int _N_GetVariantCodeObject(object x)
		{
			return (!(x is TypeInfoCache)) ? (-1) : ((TypeInfoCache)x)._N_GetVariantCode();
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
		}

		void ISupportRelocation.RelocateImpl(RelocationInfo _info)
		{
			//ILSpy generated this explicit interface implementation from .override directive in RelocateImplInternal
			this.RelocateImplInternal(_info);
		}
	}

	[ComVisible(false)]
	[DebuggerDisplay("NamespaceTree.Node: '{GetDisplayName()}'")]
	public class Node : IEquatable<Node>, ISupportRelocation
	{
		[DebuggerDisplay("NamespaceTree.Node: '{FullName}'")]
		[ComVisible(false)]
		private class NodeDebugDisplayHelper : ISupportRelocation
		{
			private sealed class _N__N_lambda__86858__86879 : Function<Node, Node, int>
			{
				[SpecialName]
				public static readonly _N__N_lambda__86858__86879 Instance = new _N__N_lambda__86858__86879();

				[SpecialName]
				public sealed override int apply(Node x, Node y)
				{
					return x.PartName.CompareTo(y.PartName);
				}
			}

			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private readonly Node _node;

			public string FullName => _node.GetDisplayName();

			public Node[] Children
			{
				get
				{
					Hashtable<string, Node> children = _node.Children;
					Node[] result;
					if ((object)children == null)
					{
						result = new Node[0];
					}
					else
					{
						Node[] source = _node.Children.Values.NToArray();
						Function<Node, Node, int> instance = _N__N_lambda__86858__86879.Instance;
						result = source.SortInplace(instance.apply);
					}
					return result;
				}
			}

			public NodeDebugDisplayHelper(Node node)
			{
				_node = node;
			}

			[CompilerGenerated]
			internal override void RelocateImplInternal(RelocationInfo _info)
			{
			}

			void ISupportRelocation.RelocateImpl(RelocationInfo _info)
			{
				//ILSpy generated this explicit interface implementation from .override directive in RelocateImplInternal
				this.RelocateImplInternal(_info);
			}
		}

		private sealed class _N_closureOf_GetTypeBuilders_86263
		{
			internal List<TypeBuilder> _N_result_86268;

			internal _N_closureOf_GetTypeBuilders_86263()
			{
			}
		}

		private sealed class _N_closureOf_LoadValue_86569
		{
			internal Hashtable<int, Type> _N_by_parms_amount_86576;

			internal Node _N__N_closurised_this_ptr_86574;

			internal _N_closureOf_LoadValue_86569()
			{
			}
		}

		private sealed class _N__N_lambda__86558__86578 : Function<ExternalType, list<TypeInfo>, list<TypeInfo>>
		{
			[SpecialName]
			private _N_closureOf_LoadValue_86569 _N_LoadValue_closure_86582;

			public _N__N_lambda__86558__86578(_N_closureOf_LoadValue_86569 _N_LoadValue_closure_86582)
			{
				this._N_LoadValue_closure_86582 = _N_LoadValue_closure_86582;
			}

			[SpecialName]
			public sealed override list<TypeInfo> apply(ExternalType e, list<TypeInfo> acc)
			{
				int length = e.system_type.GetGenericArguments().Length;
				object result;
				if (_N_LoadValue_closure_86582._N_by_parms_amount_86576.Contains(length))
				{
					Type type = _N_LoadValue_closure_86582._N_by_parms_amount_86576[length];
					Message.Warning(string.Concat(string.Concat(string.Concat("using type `[" + Convert.ToString(type.Assembly) + "]" + Convert.ToString(type.TypeFullName()) + "' that", " was defined in more than one assembly: "), " `[" + Convert.ToString(e.system_type.Assembly) + "]" + Convert.ToString(e.system_type.TypeFullName()) + "'"), " (the first version was used)"));
					result = acc;
				}
				else
				{
					_N_LoadValue_closure_86582._N_by_parms_amount_86576.Add(length, e.system_type);
					e.ConstructTypeInfo(_N_LoadValue_closure_86582._N__N_closurised_this_ptr_86574, fix_node: false);
					result = new list<TypeInfo>.Cons(e.tycon, acc);
				}
				return (list<TypeInfo>)result;
			}
		}

		private sealed class _N_closureOf_LookupType_86606
		{
			internal int _N_args_count_86611;

			internal _N_closureOf_LookupType_86606()
			{
			}
		}

		private sealed class _N_closureOf_LookupTypes_86665
		{
			internal list<string> _N_split_86674;

			internal Node _N__N_closurised_this_ptr_86672;

			internal string _N_mem_name_86670;

			internal _N_closureOf_LookupTypes_86665()
			{
			}
		}

		private sealed class _N__N_lambda__86656__86710 : Function<string, Node, list<TypeInfo>, list<TypeInfo>>
		{
			[SpecialName]
			private _N_closureOf_LookupTypes_86665 _N_LookupTypes_closure_86714;

			public _N__N_lambda__86656__86710(_N_closureOf_LookupTypes_86665 _N_LookupTypes_closure_86714)
			{
				this._N_LookupTypes_closure_86714 = _N_LookupTypes_closure_86714;
			}

			[SpecialName]
			public sealed override list<TypeInfo> apply(string name, Node node, list<TypeInfo> acc)
			{
				return (!Completion.MatchName(name, _N_LookupTypes_closure_86714._N_mem_name_86670)) ? acc : (_N_LookupTypes_closure_86714._N__N_closurised_this_ptr_86672._N_make_list_86677(_N_LookupTypes_closure_86714, node.Value, node) + acc);
			}
		}

		private sealed class _N_closureOf_ToString_86795
		{
			internal StringBuilder _N_s_86800;

			internal _N_closureOf_ToString_86795()
			{
			}
		}

		private sealed class _N__N_lambda__86785__86805 : FunctionVoid<string, Node>
		{
			[SpecialName]
			private _N_closureOf_ToString_86795 _N_ToString_closure_86809;

			public _N__N_lambda__86785__86805(_N_closureOf_ToString_86795 _N_ToString_closure_86809)
			{
				this._N_ToString_closure_86809 = _N_ToString_closure_86809;
			}

			[SpecialName]
			public sealed override void apply_void(string x, Node y)
			{
				StringBuilder stringBuilder = _N_ToString_closure_86809._N_s_86800.Append(string.Concat(string.Concat(x + "-", y.ToString()), ", "));
			}
		}

		public readonly Node Parent;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly string name;

		public TypeInfoCache Value;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		internal Hashtable<string, Node> children;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public Hashtable<string, Node> Children => children;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public list<string> FullName => (!(name == null)) ? GetNameWithSuffix(list<string>.Nil._N_constant_object) : new list<string>.Cons("alias", list<string>.Nil._N_constant_object);

		public bool IsFromAlias => name == null;

		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		private NodeDebugDisplayHelper NodeDebugDisplay => new NodeDebugDisplayHelper(this);

		public string PartName
		{
			[CompilerGenerated]
			[DebuggerStepThrough]
			get
			{
				return name;
			}
		}

		public Node(Node parent, string n, TypeInfoCache v)
		{
			Parent = parent;
			name = n;
			Value = v;
		}

		public void EnsureCached()
		{
			TypeInfoCache value = Value;
			if (value is TypeInfoCache.NotLoaded)
			{
				ExternalType e = ((TypeInfoCache.NotLoaded)value).e;
				e.ConstructTypeInfo(this, fix_node: true);
			}
			else if (value is TypeInfoCache.NotLoadedList)
			{
				list<TypeInfo> list = LoadValue((TypeInfoCache.NotLoadedList)value);
			}
		}

		public TypeBuilder[] GetTopLevelTypeBuilders()
		{
			return GetTypeBuilders(onlyTopDeclarations: true);
		}

		public TypeBuilder[] GetTypeBuilders()
		{
			return GetTypeBuilders(onlyTopDeclarations: false);
		}

		public TypeBuilder[] GetTypeBuilders(bool onlyTopDeclarations)
		{
			_N_closureOf_GetTypeBuilders_86263 n_closureOf_GetTypeBuilders_ = new _N_closureOf_GetTypeBuilders_86263();
			n_closureOf_GetTypeBuilders_._N_result_86268 = new List<TypeBuilder>();
			_N_scan_86271(n_closureOf_GetTypeBuilders_, this, n_closureOf_GetTypeBuilders_._N_result_86268);
			if (!onlyTopDeclarations)
			{
				_N_getNestedTypes_86306(n_closureOf_GetTypeBuilders_, n_closureOf_GetTypeBuilders_._N_result_86268.ToArray());
			}
			return n_closureOf_GetTypeBuilders_._N_result_86268.ToArray();
		}

		public bool Equals(Node other)
		{
			return other != null && (this == other || (Parent != null && Parent.Equals(other.Parent) && name == other.name));
		}

		public bool Equals(list<string> ns)
		{
			int result;
			if ((object)ns == list<string>.Nil._N_constant_object)
			{
				result = ((Parent == null) ? 1 : 0);
			}
			else
			{
				if (!(ns is list<string>.Cons))
				{
					throw new MatchFailureException();
				}
				string hd = ((list<string>.Cons)ns).hd;
				list<string> tl = ((list<string>.Cons)ns).tl;
				result = ((name == hd && Parent != null && Parent.Equals(tl)) ? 1 : 0);
			}
			return (byte)result != 0;
		}

		public override int GetHashCode()
		{
			int num = ((!(name == null)) ? name.GetHashCode() : 0);
			return (Parent != null) ? ((Parent.GetHashCode() * 7) ^ num) : num;
		}

		public string GetDisplayName()
		{
			return FullName.ToString(".");
		}

		public list<string> GetNameWithSuffix(list<string> suffix)
		{
			Node node = null;
			node = this;
			while (node.Parent != null)
			{
				suffix = new list<string>.Cons(node.name, suffix);
				node = node.Parent;
			}
			return suffix;
		}

		public void Clear()
		{
			if (children != null)
			{
				children.Clear();
			}
		}

		public Node Path(string n)
		{
			int num = 0;
			Node node = null;
			int num2 = 0;
			node = this;
			num2 = 0;
			checked
			{
				for (num = 0; num < n.Length; num++)
				{
					if (n[num] == '.')
					{
						node = node.Child(n.Substring(num2, num - num2));
						num2 = num + 1;
					}
				}
				if (n.Length > 0 && !n.EndsWith("."))
				{
					node = node.Child(n.Substring(num2, n.Length - num2));
				}
				return node;
			}
		}

		public Node Path(list<string> n)
		{
			Node node = null;
			node = this;
			list<string> list = n;
			while (list is list<string>.Cons)
			{
				string hd = ((list<string>.Cons)list).hd;
				list = ((list<string>.Cons)list).tl;
				node = node.Child(hd);
				list = list;
			}
			return node;
		}

		public TypeInfoCache TryPath(list<string> n)
		{
			list<string> list = n;
			Node node = this;
			object result;
			while (true)
			{
				if (list is list<string>.Cons)
				{
					string hd;
					option<Node> option;
					if ((object)((list<string>.Cons)list).tl == list<string>.Nil._N_constant_object)
					{
						hd = ((list<string>.Cons)list).hd;
						if (node.children == null)
						{
							node.children = new Hashtable<string, Node>(10);
						}
						option = node.children.Get(hd);
						if (option is option<Node>.Some)
						{
							node = ((option<Node>.Some)option).val;
							result = node.Value;
							break;
						}
						if (hd.Length == 0)
						{
							result = TypeInfoCache.No._N_constant_object;
							break;
						}
						char c = hd[checked(hd.Length - 1)];
						if (c == '*' || c == '&')
						{
							string text = hd.TrimEnd('*', '&');
							option = node.children.Get(text);
							Nemerle.Builtins.Tuple<Type, LibraryReference> tuple;
							if (option is option<Node>.Some)
							{
								Node val = ((option<Node>.Some)option).val;
								TypeInfoCache value = val.Value;
								if (value is TypeInfoCache.Cached)
								{
									TypeInfo tycon = ((TypeInfoCache.Cached)value).tycon;
									tuple = new Nemerle.Builtins.Tuple<Type, LibraryReference>(tycon.SystemType, tycon.GetLibraryReference());
								}
								else if (value is TypeInfoCache.NotLoaded)
								{
									ExternalType e = ((TypeInfoCache.NotLoaded)value).e;
									tuple = new Nemerle.Builtins.Tuple<Type, LibraryReference>(e.system_type, e.library);
								}
								else
								{
									tuple = new Nemerle.Builtins.Tuple<Type, LibraryReference>(null, null);
								}
							}
							else
							{
								tuple = new Nemerle.Builtins.Tuple<Type, LibraryReference>(null, null);
							}
							Nemerle.Builtins.Tuple<Type, LibraryReference> tuple2 = tuple;
							Type field = tuple2.Field0;
							LibraryReference field2 = tuple2.Field1;
							if (field != null)
							{
								text = field.TypeFullName() + hd.Substring(text.Length);
								field = field.Assembly.GetType(text);
								if (!(field != null))
								{
									throw new AssertionException("ncc\\hierarchy\\NamespaceTree.n", 267, "nst != null", "");
								}
								node = node.Child(hd);
								result = (node.Value = new TypeInfoCache.Cached(field2.ConstructTypeInfo(field, node)));
								break;
							}
							result = TypeInfoCache.No._N_constant_object;
							break;
						}
						result = TypeInfoCache.No._N_constant_object;
						break;
					}
					hd = ((list<string>.Cons)list).hd;
					list = ((list<string>.Cons)list).tl;
					if (node.children == null)
					{
						node.children = new Hashtable<string, Node>(10);
					}
					option = node.children.Get(hd);
					if (option is option<Node>.Some)
					{
						node = ((option<Node>.Some)option).val;
						list<string> list2 = list;
						node = node;
						list = list2;
						continue;
					}
					result = TypeInfoCache.No._N_constant_object;
					break;
				}
				result = Value;
				break;
			}
			return (TypeInfoCache)result;
		}

		public Node PassTo(list<string> name)
		{
			object result;
			if (Children == null)
			{
				result = (((object)name != list<string>.Nil._N_constant_object) ? null : this);
			}
			else if (name is list<string>.Cons)
			{
				string hd = ((list<string>.Cons)name).hd;
				list<string> tl = ((list<string>.Cons)name).tl;
				Node valueOrDefault = Children.GetValueOrDefault(hd, null);
				if ((object)valueOrDefault != null)
				{
					TypeInfoCache value = valueOrDefault.Value;
					if (!(value is TypeInfoCache.No))
					{
						result = valueOrDefault.PassTo(tl);
						goto IL_00ab;
					}
				}
				result = null;
			}
			else
			{
				if ((object)name != list<string>.Nil._N_constant_object)
				{
					throw new MatchFailureException();
				}
				result = this;
			}
			goto IL_00ab;
			IL_00ab:
			return (Node)result;
		}

		public static Node PassTo(list<Node> nss, list<string> name)
		{
			object result;
			while (true)
			{
				if (nss is list<Node>.Cons)
				{
					Node hd = ((list<Node>.Cons)nss).hd;
					list<Node> list = ((list<Node>.Cons)nss).tl;
					if (hd.Children == null)
					{
						list<Node> obj = list;
						name = name;
						nss = obj;
						continue;
					}
					hd = hd.PassTo(name);
					if ((object)hd == null)
					{
						list<Node> obj2 = list;
						name = name;
						nss = obj2;
						continue;
					}
					result = hd;
					break;
				}
				if ((object)nss == list<Node>.Nil._N_constant_object)
				{
					result = null;
					break;
				}
				throw new MatchFailureException();
			}
			return (Node)result;
		}

		internal list<TypeInfo> LoadValue(TypeInfoCache.NotLoadedList val)
		{
			_N_closureOf_LoadValue_86569 n_closureOf_LoadValue_ = new _N_closureOf_LoadValue_86569();
			n_closureOf_LoadValue_._N__N_closurised_this_ptr_86574 = this;
			n_closureOf_LoadValue_._N_by_parms_amount_86576 = new Hashtable<int, Type>();
			list<ExternalType> elems = val.elems;
			list<TypeInfo>.Nil n_constant_object = list<TypeInfo>.Nil._N_constant_object;
			Function<ExternalType, list<TypeInfo>, list<TypeInfo>> f = new _N__N_lambda__86558__86578(n_closureOf_LoadValue_);
			list<TypeInfo> list = elems.FoldLeft(n_constant_object, f);
			Value = new TypeInfoCache.CachedAmbiguous(list);
			return list;
		}

		public option<TypeInfo> LookupType(list<string> split, int args_count)
		{
			_N_closureOf_LookupType_86606 n_closureOf_LookupType_ = new _N_closureOf_LookupType_86606();
			n_closureOf_LookupType_._N_args_count_86611 = args_count;
			TypeInfoCache typeInfoCache = TryPath(split);
			if (typeInfoCache == TypeInfoCache.No._N_constant_object)
			{
				goto IL_00ec;
			}
			object result;
			if (typeInfoCache is TypeInfoCache.Cached)
			{
				TypeInfo tycon = ((TypeInfoCache.Cached)typeInfoCache).tycon;
				result = new option<TypeInfo>.Some(tycon);
			}
			else if (typeInfoCache is TypeInfoCache.CachedAmbiguous)
			{
				list<TypeInfo> cached = ((TypeInfoCache.CachedAmbiguous)typeInfoCache).elems;
				result = _N_search_86614(n_closureOf_LookupType_, cached);
			}
			else if (typeInfoCache is TypeInfoCache.NotLoaded)
			{
				ExternalType e = ((TypeInfoCache.NotLoaded)typeInfoCache).e;
				e.ConstructTypeInfo(Path(split), fix_node: true);
				result = new option<TypeInfo>.Some(e.tycon);
			}
			else
			{
				if (!(typeInfoCache is TypeInfoCache.NotLoadedList))
				{
					if (typeInfoCache is TypeInfoCache.MacroCall || typeInfoCache == TypeInfoCache.NamespaceReference._N_constant_object)
					{
						goto IL_00ec;
					}
					throw new MatchFailureException();
				}
				list<TypeInfo> cached = Path(split).LoadValue((TypeInfoCache.NotLoadedList)typeInfoCache);
				result = _N_search_86614(n_closureOf_LookupType_, cached);
			}
			goto IL_00fc;
			IL_00ec:
			result = option<TypeInfo>.None._N_constant_object;
			goto IL_00fc;
			IL_00fc:
			return (option<TypeInfo>)result;
		}

		public list<TypeInfo> LookupTypes(list<string> split, bool for_completion = false)
		{
			_N_closureOf_LookupTypes_86665 n_closureOf_LookupTypes_ = new _N_closureOf_LookupTypes_86665();
			n_closureOf_LookupTypes_._N_split_86674 = split;
			n_closureOf_LookupTypes_._N__N_closurised_this_ptr_86672 = this;
			object result;
			if (for_completion)
			{
				Nemerle.Builtins.Tuple<list<string>, string> tuple = NList.DivideLast(n_closureOf_LookupTypes_._N_split_86674);
				list<string> field = tuple.Field0;
				n_closureOf_LookupTypes_._N_mem_name_86670 = tuple.Field1;
				Node node = PassTo(field);
				if (node != null && node.children != null)
				{
					Hashtable<string, Node> hashtable = node.children;
					list<TypeInfo>.Nil n_constant_object = list<TypeInfo>.Nil._N_constant_object;
					Function<string, Node, list<TypeInfo>, list<TypeInfo>> f = new _N__N_lambda__86656__86710(n_closureOf_LookupTypes_);
					result = hashtable.Fold(n_constant_object, f);
				}
				else
				{
					result = list<TypeInfo>.Nil._N_constant_object;
				}
			}
			else
			{
				result = _N_make_list_86677(n_closureOf_LookupTypes_, TryPath(n_closureOf_LookupTypes_._N_split_86674), null);
			}
			return (list<TypeInfo>)result;
		}

		public option<Type> LookupSystemType(list<string> split)
		{
			TypeInfoCache typeInfoCache = TryPath(split);
			if (typeInfoCache == TypeInfoCache.No._N_constant_object)
			{
				goto IL_00e5;
			}
			object result;
			if (typeInfoCache is TypeInfoCache.Cached)
			{
				TypeInfo tycon = ((TypeInfoCache.Cached)typeInfoCache).tycon;
				result = new option<Type>.Some(tycon.SystemType);
			}
			else if (typeInfoCache is TypeInfoCache.CachedAmbiguous)
			{
				list<TypeInfo> list = ((TypeInfoCache.CachedAmbiguous)typeInfoCache).elems;
				result = new option<Type>.Some(list.Head.SystemType);
			}
			else if (typeInfoCache is TypeInfoCache.NotLoaded)
			{
				ExternalType e = ((TypeInfoCache.NotLoaded)typeInfoCache).e;
				result = new option<Type>.Some(e.system_type);
			}
			else
			{
				if (!(typeInfoCache is TypeInfoCache.NotLoadedList))
				{
					if (typeInfoCache is TypeInfoCache.MacroCall || typeInfoCache == TypeInfoCache.NamespaceReference._N_constant_object)
					{
						goto IL_00e5;
					}
					throw new MatchFailureException();
				}
				list<ExternalType> list2 = ((TypeInfoCache.NotLoadedList)typeInfoCache).elems;
				result = new option<Type>.Some(list2.Head.system_type);
			}
			goto IL_00f5;
			IL_00e5:
			result = option<Type>.None._N_constant_object;
			goto IL_00f5;
			IL_00f5:
			return (option<Type>)result;
		}

		public option<TypeInfo> LookupValue()
		{
			return LookupType(list<string>.Nil._N_constant_object, -1);
		}

		public option<IMacro> LookupMacro(list<string> split)
		{
			TypeInfoCache typeInfoCache = TryPath(split);
			object result;
			if (typeInfoCache is TypeInfoCache.MacroCall)
			{
				IMacro m = ((TypeInfoCache.MacroCall)typeInfoCache).m;
				result = new option<IMacro>.Some(m);
			}
			else
			{
				result = option<IMacro>.None._N_constant_object;
			}
			return (option<IMacro>)result;
		}

		internal void AddChild(string name, Node node)
		{
			if (children == null)
			{
				children = new Hashtable<string, Node>(16);
			}
			children.Add(name, node);
		}

		internal void CleanUp()
		{
			list<string> fullName = FullName;
			if (fullName is list<string>.Cons && ((list<string>.Cons)fullName).hd == "alias" && (object)((list<string>.Cons)fullName).tl == list<string>.Nil._N_constant_object)
			{
				Clear();
			}
			Value = TypeInfoCache.No._N_constant_object;
		}

		private Node Child(string name)
		{
			if (children == null)
			{
				children = new Hashtable<string, Node>(16);
			}
			option<Node> option = children.Get(name);
			Node result;
			if (option == option<Node>.None._N_constant_object)
			{
				Node node = new Node(this, name, TypeInfoCache.No._N_constant_object);
				children.Add(name, node);
				result = node;
			}
			else
			{
				if (!(option is option<Node>.Some))
				{
					throw new MatchFailureException();
				}
				Node node = ((option<Node>.Some)option).val;
				result = node;
			}
			return result;
		}

		public override string ToString()
		{
			_N_closureOf_ToString_86795 n_closureOf_ToString_ = new _N_closureOf_ToString_86795();
			n_closureOf_ToString_._N_s_86800 = new StringBuilder("( ");
			if (children != null)
			{
				Hashtable<string, Node> hashtable = children;
				FunctionVoid<string, Node> f = new _N__N_lambda__86785__86805(n_closureOf_ToString_);
				hashtable.Iter(f);
			}
			StringBuilder stringBuilder = n_closureOf_ToString_._N_s_86800.Append(")\n");
			return n_closureOf_ToString_._N_s_86800.ToString();
		}

		public override bool Equals(object other)
		{
			return other == this || (other is Node && Equals((Node)other));
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				_info.VisitedObjects[this] = 0;
				Value?.RelocateImplInternal(_info);
			}
		}

		void ISupportRelocation.RelocateImpl(RelocationInfo _info)
		{
			//ILSpy generated this explicit interface implementation from .override directive in RelocateImplInternal
			this.RelocateImplInternal(_info);
		}

		private static void _N_scan_86271(_N_closureOf_GetTypeBuilders_86263 _N_GetTypeBuilders_cp_86270, Node node, List<TypeBuilder> result)
		{
			if (node.Children == null)
			{
				return;
			}
			foreach (KeyValuePair<string, Node> child in node.Children)
			{
				KeyValuePair<string, Node> keyValuePair = child;
				Node value = keyValuePair.Value;
				TypeInfoCache value2 = value.Value;
				if (value2 is TypeInfoCache.Cached)
				{
					if (((TypeInfoCache.Cached)value2).tycon is TypeBuilder)
					{
						TypeBuilder item = (TypeBuilder)((TypeInfoCache.Cached)value2).tycon;
						result.Add(item);
					}
				}
				else if (value2 is TypeInfoCache.CachedAmbiguous)
				{
					list<TypeInfo> list = ((TypeInfoCache.CachedAmbiguous)value2).elems;
					list<TypeInfo> list2 = list;
					while (list2 is list<TypeInfo>.Cons)
					{
						TypeInfo hd = ((list<TypeInfo>.Cons)list2).hd;
						list<TypeInfo> list3 = ((list<TypeInfo>.Cons)list2).tl;
						if (hd is TypeBuilder)
						{
							TypeBuilder item2 = (TypeBuilder)hd;
							result.Add(item2);
						}
						list2 = list3;
					}
				}
				else if (value2 == TypeInfoCache.NamespaceReference._N_constant_object)
				{
					_N_scan_86271(_N_GetTypeBuilders_cp_86270, value, result);
				}
			}
		}

		private static void _N_getNestedTypes_86306(_N_closureOf_GetTypeBuilders_86263 _N_GetTypeBuilders_cp_86305, IEnumerable<TypeBuilder> sec)
		{
			IEnumerator<TypeBuilder> enumerator = sec.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					TypeBuilder current = enumerator.Current;
					TypeBuilder typeBuilder = current;
					list<TypeBuilder> declaredNestedTypes = typeBuilder.DeclaredNestedTypes;
					_N_GetTypeBuilders_cp_86305._N_result_86268.AddRange(declaredNestedTypes);
					_N_getNestedTypes_86306(_N_GetTypeBuilders_cp_86305, declaredNestedTypes);
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
		}

		private static option<TypeInfo> _N_search_86614(_N_closureOf_LookupType_86606 _N_LookupType_cp_86613, list<TypeInfo> cached)
		{
			object result;
			while (true)
			{
				if (cached is list<TypeInfo>.Cons)
				{
					TypeInfo hd = ((list<TypeInfo>.Cons)cached).hd;
					list<TypeInfo> list = ((list<TypeInfo>.Cons)cached).tl;
					if (_N_LookupType_cp_86613._N_args_count_86611 == -1 || _N_LookupType_cp_86613._N_args_count_86611 == hd.TyparmsCount)
					{
						result = new option<TypeInfo>.Some(hd);
						break;
					}
					cached = list;
					continue;
				}
				if ((object)cached == list<TypeInfo>.Nil._N_constant_object)
				{
					result = option<TypeInfo>.None._N_constant_object;
					break;
				}
				throw new MatchFailureException();
			}
			return (option<TypeInfo>)result;
		}

		private list<TypeInfo> _N_make_list_86677(_N_closureOf_LookupTypes_86665 _N_LookupTypes_cp_86676, TypeInfoCache val, Node path)
		{
			if (val == TypeInfoCache.No._N_constant_object)
			{
				goto IL_00fc;
			}
			object result;
			if (val is TypeInfoCache.Cached)
			{
				TypeInfo tycon = ((TypeInfoCache.Cached)val).tycon;
				result = new list<TypeInfo>.Cons(tycon, list<TypeInfo>.Nil._N_constant_object);
			}
			else if (val is TypeInfoCache.CachedAmbiguous)
			{
				list<TypeInfo> list = ((TypeInfoCache.CachedAmbiguous)val).elems;
				result = list;
			}
			else if (val is TypeInfoCache.NotLoaded)
			{
				ExternalType e = ((TypeInfoCache.NotLoaded)val).e;
				Node node = ((path != null) ? path : Path(_N_LookupTypes_cp_86676._N_split_86674));
				e.ConstructTypeInfo(node, fix_node: true);
				result = new list<TypeInfo>.Cons(e.tycon, list<TypeInfo>.Nil._N_constant_object);
			}
			else
			{
				if (!(val is TypeInfoCache.NotLoadedList))
				{
					if (val is TypeInfoCache.MacroCall || val == TypeInfoCache.NamespaceReference._N_constant_object)
					{
						goto IL_00fc;
					}
					throw new MatchFailureException();
				}
				Node node = ((path != null) ? path : Path(_N_LookupTypes_cp_86676._N_split_86674));
				result = node.LoadValue((TypeInfoCache.NotLoadedList)val);
			}
			goto IL_010c;
			IL_00fc:
			result = list<TypeInfo>.Nil._N_constant_object;
			goto IL_010c;
			IL_010c:
			return (list<TypeInfo>)result;
		}
	}

	private sealed class _N_closureOf_ResetAllTypes_85736
	{
		internal _N_closureOf_ResetAllTypes_85736()
		{
		}
	}

	private sealed class _N_closureOf_AddType_85788
	{
		internal TypeBuilder _N_par_85803;

		internal TopDeclaration _N_newdecl_85801;

		internal Node _N_ns_node_85799;

		internal int _N_new_gparms_85797;

		internal TypeBuilder _N_builder_85795;

		internal NamespaceTree _N__N_closurised_this_ptr_85793;

		internal _N_closureOf_AddType_85788()
		{
		}
	}

	private sealed class _N__N_lambda__85777__85816 : Function<TypeInfo, list<TypeInfo>, list<TypeInfo>>
	{
		[SpecialName]
		private _N_closureOf_AddType_85788 _N_AddType_closure_85820;

		public _N__N_lambda__85777__85816(_N_closureOf_AddType_85788 _N_AddType_closure_85820)
		{
			this._N_AddType_closure_85820 = _N_AddType_closure_85820;
		}

		[SpecialName]
		public sealed override list<TypeInfo> apply(TypeInfo x, list<TypeInfo> acc)
		{
			list<TypeInfo>.Cons result;
			if (x.DeclaredTypeParametersCount == _N_AddType_closure_85820._N_new_gparms_85797)
			{
				if (x is TypeBuilder)
				{
					TypeBuilder typeBuilder = (TypeBuilder)x;
					typeBuilder.ExtendPartialClass(_N_AddType_closure_85820._N_newdecl_85801);
					_N_AddType_closure_85820._N_builder_85795 = typeBuilder;
					result = new list<TypeInfo>.Cons(x, acc);
				}
				else
				{
					Message.Error(_N_AddType_closure_85820._N_newdecl_85801.Location, string.Concat("redefinition of external type `" + x.FullName, "'"));
					Message.Error(x.Location, "first defined here");
					_N_AddType_closure_85820._N_builder_85795 = _N_AddType_closure_85820._N__N_closurised_this_ptr_85793.Manager.Hierarchy.CreateTypeBuilder(_N_AddType_closure_85820._N_par_85803, _N_AddType_closure_85820._N_newdecl_85801, _N_AddType_closure_85820._N_ns_node_85799);
					result = new list<TypeInfo>.Cons(_N_AddType_closure_85820._N_builder_85795, acc);
				}
			}
			else
			{
				result = new list<TypeInfo>.Cons(x, acc);
			}
			return result;
		}
	}

	private sealed class _N_closureOf_LiftMacroContexts_85970
	{
		internal string[] _N_ar_85975;

		internal _N_closureOf_LiftMacroContexts_85970()
		{
		}
	}

	private sealed class _N__N_lambda__85958__85977 : FunctionVoid<string, int>
	{
		[SpecialName]
		private _N_closureOf_LiftMacroContexts_85970 _N_LiftMacroContexts_closure_85981;

		public _N__N_lambda__85958__85977(_N_closureOf_LiftMacroContexts_85970 _N_LiftMacroContexts_closure_85981)
		{
			this._N_LiftMacroContexts_closure_85981 = _N_LiftMacroContexts_closure_85981;
		}

		[SpecialName]
		public sealed override void apply_void(string k, int v)
		{
			_N_LiftMacroContexts_closure_85981._N_ar_85975[checked(v - 1)] = k;
		}
	}

	private sealed class _N_make_expr__85986 : Function<string, PExpr>
	{
		[SpecialName]
		public static readonly _N_make_expr__85986 Instance = new _N_make_expr__85986();

		[SpecialName]
		public sealed override PExpr apply(string s)
		{
			if (!(s != null))
			{
				throw new AssertionException("ncc\\hierarchy\\NamespaceTree.n", 732, "s != null", "");
			}
			return new PExpr.Literal(new Literal.String(s));
		}
	}

	internal int macro_context;

	internal readonly Hashtable<string, int> macro_contexts;

	private TypeBuilder macro_context_class;

	internal readonly Node namespace_tree;

	internal readonly List<Nemerle.Builtins.Tuple<list<Node>, Location>> referenced_namespace_nodes;

	public readonly ManagerClass Manager;

	public InternalTypeClass InternalType => Manager.InternalType;

	public SystemTypeClass SystemTypeCache => Manager.SystemTypeCache;

	public Node NamespaceTree
	{
		[DebuggerStepThrough]
		[CompilerGenerated]
		get
		{
			return namespace_tree;
		}
	}

	internal NamespaceTree(ManagerClass man)
	{
		macro_contexts = new Hashtable<string, int>(100);
		namespace_tree = new Node(null, "", TypeInfoCache.NamespaceReference._N_constant_object);
		referenced_namespace_nodes = new List<Nemerle.Builtins.Tuple<list<Node>, Location>>();
		Manager = man;
	}

	public void Init()
	{
		macro_contexts.Clear();
		macro_context = 0;
		macro_context_class = null;
		referenced_namespace_nodes.Clear();
	}

	public void ResetAllTypes()
	{
		_N_closureOf_ResetAllTypes_85736 n_ResetAllTypes_cp_ = new _N_closureOf_ResetAllTypes_85736();
		if (NamespaceTree.Children != null)
		{
			_N_resetChildren_85742(n_ResetAllTypes_cp_, NamespaceTree.Children);
		}
	}

	[Macro("Nemerle.Assertions.Ensures:method:postadd", 0, "value != null")]
	internal TypeBuilder AddType(TypeBuilder par, Node parent_node, TopDeclaration newdecl)
	{
		list<TypeInfo> list = null;
		_N_closureOf_AddType_85788 n_closureOf_AddType_ = new _N_closureOf_AddType_85788();
		n_closureOf_AddType_._N_par_85803 = par;
		n_closureOf_AddType_._N_newdecl_85801 = newdecl;
		n_closureOf_AddType_._N__N_closurised_this_ptr_85793 = this;
		Name pName = n_closureOf_AddType_._N_newdecl_85801.PName;
		n_closureOf_AddType_._N_ns_node_85799 = parent_node.Path(new list<string>.Cons(pName.Id, list<string>.Nil._N_constant_object));
		n_closureOf_AddType_._N_new_gparms_85797 = n_closureOf_AddType_._N_newdecl_85801.TypeParametersCount;
		TypeInfoCache value = n_closureOf_AddType_._N_ns_node_85799.Value;
		object obj;
		if (value is TypeInfoCache.Cached)
		{
			TypeInfo tycon = ((TypeInfoCache.Cached)value).tycon;
			obj = new list<TypeInfo>.Cons(tycon, list<TypeInfo>.Nil._N_constant_object);
		}
		else if (value is TypeInfoCache.CachedAmbiguous)
		{
			list = ((TypeInfoCache.CachedAmbiguous)value).elems;
			obj = list;
		}
		else if (value is TypeInfoCache.NotLoaded)
		{
			ExternalType e = ((TypeInfoCache.NotLoaded)value).e;
			e.ConstructTypeInfo(n_closureOf_AddType_._N_ns_node_85799, fix_node: true);
			obj = new list<TypeInfo>.Cons(e.tycon, list<TypeInfo>.Nil._N_constant_object);
		}
		else if (value is TypeInfoCache.NotLoadedList)
		{
			obj = n_closureOf_AddType_._N_ns_node_85799.LoadValue((TypeInfoCache.NotLoadedList)value);
		}
		else if (value is TypeInfoCache.MacroCall)
		{
			IMacro m = ((TypeInfoCache.MacroCall)value).m;
			Message.Error("type declaration `" + Convert.ToString(pName.Id) + "' hides macro " + Convert.ToString(m.GetName()));
			obj = list<TypeInfo>.Nil._N_constant_object;
		}
		else
		{
			obj = list<TypeInfo>.Nil._N_constant_object;
		}
		list = (list<TypeInfo>)obj;
		n_closureOf_AddType_._N_builder_85795 = null;
		list<TypeInfo> list2 = list;
		list<TypeInfo>.Nil n_constant_object = list<TypeInfo>.Nil._N_constant_object;
		Function<TypeInfo, list<TypeInfo>, list<TypeInfo>> f = new _N__N_lambda__85777__85816(n_closureOf_AddType_);
		list = list2.FoldLeft(n_constant_object, f);
		if (n_closureOf_AddType_._N_builder_85795 == null)
		{
			n_closureOf_AddType_._N_builder_85795 = Manager.Hierarchy.CreateTypeBuilder(n_closureOf_AddType_._N_par_85803, n_closureOf_AddType_._N_newdecl_85801, n_closureOf_AddType_._N_ns_node_85799);
			list = new list<TypeInfo>.Cons(n_closureOf_AddType_._N_builder_85795, list);
		}
		Node n_ns_node_ = n_closureOf_AddType_._N_ns_node_85799;
		TypeInfoCache typeInfoCache = (n_ns_node_.Value = ((!(list is list<TypeInfo>.Cons) || (object)((list<TypeInfo>.Cons)list).tl != list<TypeInfo>.Nil._N_constant_object) ? ((TypeInfoCache)new TypeInfoCache.CachedAmbiguous(list)) : ((TypeInfoCache)new TypeInfoCache.Cached(n_closureOf_AddType_._N_builder_85795))));
		TypeBuilder n_builder_ = n_closureOf_AddType_._N_builder_85795;
		if (n_builder_ == null)
		{
			throw new AssertionException("ncc\\hierarchy\\NamespaceTree.n", 580, "value != null", "The ``Ensures'' contract of method `AddType' has been violated.".ToString());
		}
		return n_builder_;
	}

	public void AddMacro(list<string> split, IMacro m)
	{
		AddMacro(namespace_tree.Path(split), m);
	}

	public static void AddMacro(Node ns, IMacro m)
	{
		TypeInfoCache value = ns.Value;
		if (value == TypeInfoCache.No._N_constant_object)
		{
			ns.Value = new TypeInfoCache.MacroCall(m);
		}
		else if (value == TypeInfoCache.NamespaceReference._N_constant_object)
		{
			Message.Error(string.Concat("cannot define `" + ns.GetDisplayName(), "' because the same namespace exists "));
		}
		else
		{
			Message.Error(string.Concat("redefinition of `" + ns.GetDisplayName(), "'"));
		}
	}

	internal TypeInfo LookupInternalType(list<string> name)
	{
		option<TypeInfo> option = LookupExactType(name);
		if (option is option<TypeInfo>.Some)
		{
			return ((option<TypeInfo>.Some)option).val;
		}
		if (option == option<TypeInfo>.None._N_constant_object)
		{
			if (!Message.SeenError)
			{
				string text = ("unbound internal type " + name.ToString(".")).ToString();
				Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
			}
			throw new AssertionException("ncc\\hierarchy\\NamespaceTree.n", 664, "", ("unbound internal type " + name.ToString(".")).ToString());
		}
		throw new MatchFailureException();
	}

	internal TypeInfo LookupInternalType(list<string> name, int args_count)
	{
		option<TypeInfo> option = LookupExactType(name, args_count);
		if (option is option<TypeInfo>.Some)
		{
			return ((option<TypeInfo>.Some)option).val;
		}
		if (option == option<TypeInfo>.None._N_constant_object)
		{
			if (!Message.SeenError)
			{
				string text = string.Concat(string.Concat("unbound internal type " + name.ToString("."), "`"), args_count.ToString()).ToString();
				Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
			}
			throw new AssertionException("ncc\\hierarchy\\NamespaceTree.n", 671, "", string.Concat(string.Concat("unbound internal type " + name.ToString("."), "`"), args_count.ToString()).ToString());
		}
		throw new MatchFailureException();
	}

	public option<TypeInfo> LookupExactType(string name)
	{
		return LookupExactType(name, -1);
	}

	public option<TypeInfo> LookupExactType(string name, int args_count)
	{
		return namespace_tree.LookupType(NString.Split(name, '.'), args_count);
	}

	public option<TypeInfo> LookupExactType(list<string> name)
	{
		return namespace_tree.LookupType(name, -1);
	}

	public option<TypeInfo> LookupExactType(list<string> name, int args_count)
	{
		return namespace_tree.LookupType(name, args_count);
	}

	public option<Type> LookupSystemType(string name)
	{
		return namespace_tree.LookupSystemType(NString.Split(name, '.'));
	}

	public Node ExactPath(list<string> path)
	{
		return namespace_tree.Path(path);
	}

	public option<IMacro> LookupExactMacro(list<string> name)
	{
		return namespace_tree.LookupMacro(name);
	}

	internal void CheckReferencedNamespaces()
	{
		foreach (Nemerle.Builtins.Tuple<list<Node>, Location> referenced_namespace_node in referenced_namespace_nodes)
		{
			list<Node> list = referenced_namespace_node.Field0;
			Location field = referenced_namespace_node.Field1;
			bool flag = true;
			list<Node> list2 = list;
			while (list2 is list<Node>.Cons)
			{
				Node hd = ((list<Node>.Cons)list2).hd;
				list<Node> list3 = ((list<Node>.Cons)list2).tl;
				Node node = hd;
				TypeInfoCache value = node.Value;
				if (value == TypeInfoCache.No._N_constant_object)
				{
					node.Value = TypeInfoCache.NamespaceReference._N_constant_object;
				}
				else
				{
					flag = false;
				}
				list2 = list3;
			}
			if (flag)
			{
				Message.Error(field, string.Concat("referenced namespace `" + list.Last.GetDisplayName(), "' does not exist"));
			}
		}
	}

	private PExpr LiftMacroContexts()
	{
		_N_closureOf_LiftMacroContexts_85970 n_closureOf_LiftMacroContexts_ = new _N_closureOf_LiftMacroContexts_85970();
		n_closureOf_LiftMacroContexts_._N_ar_85975 = new string[macro_context];
		Hashtable<string, int> hashtable = macro_contexts;
		FunctionVoid<string, int> f = new _N__N_lambda__85958__85977(n_closureOf_LiftMacroContexts_);
		hashtable.Iter(f);
		Function<string, PExpr> instance = _N_make_expr__85986.Instance;
		return new PExpr.Array(new PExpr.Literal(new Literal.Integer(1uL, is_negative: false, null).WithProperType()), new PExpr.ListLiteral(Macros.QuotationChoose(NList.MapFromArray(n_closureOf_LiftMacroContexts_._N_ar_85975, instance))));
	}

	internal void prepare_macro_context_class()
	{
		if (macro_context_class == null)
		{
			ClassMember.TypeDeclaration typeDeclaration = new ClassMember.TypeDeclaration(new TopDeclaration.Class(new Splicable.Name(Name.NameInCurrentColor("_N_MacroContexts", _N_MacroContexts.Get(11, ManagerClass.Instance))), new AttributesAndModifiers(NemerleModifiers.Static | NemerleModifiers.Internal, list<PExpr>.Nil._N_constant_object), new Typarms(list<Splicable>.Nil._N_constant_object, list<Constraint>.Nil._N_constant_object), list<PExpr>.Nil._N_constant_object, new list<ClassMember>.Cons(new ClassMember.Field(new Splicable.Name(Name.NameInCurrentColor("serialized", _N_MacroContexts.Get(11, ManagerClass.Instance))), new AttributesAndModifiers(NemerleModifiers.Private | NemerleModifiers.Static, list<PExpr>.Nil._N_constant_object), new PExpr.Array(new PExpr.Literal(new Literal.Integer(1uL, is_negative: false, null).WithProperType()), new PExpr.ListLiteral(new list<PExpr>.Cons(new PExpr.Ref(Name.NameInCurrentColor("string", _N_MacroContexts.Get(11, ManagerClass.Instance))), list<PExpr>.Nil._N_constant_object)))), new list<ClassMember>.Cons(new ClassMember.Field(new Splicable.Name(Name.NameInCurrentColor("contexts", _N_MacroContexts.Get(11, ManagerClass.Instance))), new AttributesAndModifiers(NemerleModifiers.Private | NemerleModifiers.Static, list<PExpr>.Nil._N_constant_object), new PExpr.Array(new PExpr.Literal(new Literal.Integer(1uL, is_negative: false, null).WithProperType()), new PExpr.ListLiteral(new list<PExpr>.Cons(new PExpr.Ref(Name.NameInCurrentColor("GlobalEnv", _N_MacroContexts.Get(11, ManagerClass.Instance))), list<PExpr>.Nil._N_constant_object)))), new list<ClassMember>.Cons(new ClassMember.Field(new Splicable.Name(Name.NameInCurrentColor("last_manager", _N_MacroContexts.Get(11, ManagerClass.Instance))), new AttributesAndModifiers(NemerleModifiers.Private | (NemerleModifiers.Static | NemerleModifiers.Mutable), list<PExpr>.Nil._N_constant_object), new PExpr.Ref(Name.NameInCurrentColor("ManagerClass", _N_MacroContexts.Get(11, ManagerClass.Instance)))), new list<ClassMember>.Cons(new ClassMember.Function(new Splicable.Name(Name.NameInCurrentColor("Get", _N_MacroContexts.Get(11, ManagerClass.Instance))), new AttributesAndModifiers(NemerleModifiers.Static | NemerleModifiers.Internal, list<PExpr>.Nil._N_constant_object), new PFunHeader(new Typarms(list<Splicable>.Nil._N_constant_object, list<Constraint>.Nil._N_constant_object), new Splicable.Name(Name.NameInCurrentColor("Get", _N_MacroContexts.Get(11, ManagerClass.Instance))), new PExpr.Ref(Name.NameInCurrentColor("GlobalEnv", _N_MacroContexts.Get(11, ManagerClass.Instance))), new list<PParameter>.Cons(new PParameter(new Splicable.Name(Name.NameInCurrentColor("no", _N_MacroContexts.Get(11, ManagerClass.Instance))), new AttributesAndModifiers(NemerleModifiers.None, list<PExpr>.Nil._N_constant_object), new PExpr.Ref(Name.NameInCurrentColor("int", _N_MacroContexts.Get(11, ManagerClass.Instance)))), new list<PParameter>.Cons(new PParameter(new Splicable.Name(Name.NameInCurrentColor("from_manager", _N_MacroContexts.Get(11, ManagerClass.Instance))), new AttributesAndModifiers(NemerleModifiers.None, list<PExpr>.Nil._N_constant_object), new PExpr.Ref(Name.NameInCurrentColor("ManagerClass", _N_MacroContexts.Get(11, ManagerClass.Instance)))), list<PParameter>.Nil._N_constant_object))), list<PExpr>.Nil._N_constant_object, new FunBody.Parsed(new PExpr.Sequence(new list<PExpr>.Cons(new PExpr.MacroCall(Name.NameInCurrentColor("when", _N_MacroContexts.Get(11, ManagerClass.Instance)), ManagerClass.Instance.NameTree.ExactPath(new list<string>.Cons("Nemerle", new list<string>.Cons("Core", new list<string>.Cons("whenmacro", list<string>.Nil._N_constant_object)))), new list<SyntaxElement>.Cons(new SyntaxElement.Expression(new PExpr.Call(new PExpr.Ref(Name.NameInCurrentColor("!=", _N_MacroContexts.Get(11, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.TypeEnforcement(new PExpr.Ref(Name.NameInCurrentColor("from_manager", _N_MacroContexts.Get(11, ManagerClass.Instance))), new PExpr.Ref(Name.NameInCurrentColor("object", _N_MacroContexts.Get(11, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Ref(Name.NameInCurrentColor("last_manager", _N_MacroContexts.Get(11, ManagerClass.Instance))), list<PExpr>.Nil._N_constant_object)))), new list<SyntaxElement>.Cons(new SyntaxElement.Expression(new PExpr.Sequence(new list<PExpr>.Cons(new PExpr.Call(new PExpr.Ref(Name.NameInCurrentColor("Clear", _N_MacroContexts.Get(11, ManagerClass.Instance))), list<PExpr>.Nil._N_constant_object), new list<PExpr>.Cons(new PExpr.Assign(new PExpr.Ref(Name.NameInCurrentColor("last_manager", _N_MacroContexts.Get(11, ManagerClass.Instance))), new PExpr.Ref(Name.NameInCurrentColor("from_manager", _N_MacroContexts.Get(11, ManagerClass.Instance)))), list<PExpr>.Nil._N_constant_object)))), list<SyntaxElement>.Nil._N_constant_object))), new list<PExpr>.Cons(new PExpr.MacroCall(Name.NameInCurrentColor("when", _N_MacroContexts.Get(11, ManagerClass.Instance)), ManagerClass.Instance.NameTree.ExactPath(new list<string>.Cons("Nemerle", new list<string>.Cons("Core", new list<string>.Cons("whenmacro", list<string>.Nil._N_constant_object)))), new list<SyntaxElement>.Cons(new SyntaxElement.Expression(new PExpr.Call(new PExpr.Ref(Name.NameInCurrentColor("==", _N_MacroContexts.Get(11, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Indexer(new PExpr.Ref(Name.NameInCurrentColor("contexts", _N_MacroContexts.Get(11, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Call(new PExpr.Ref(Name.NameInCurrentColor("-", _N_MacroContexts.Get(11, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Ref(Name.NameInCurrentColor("no", _N_MacroContexts.Get(11, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Literal(new Literal.Integer(1uL, is_negative: false, null).WithProperType()), list<PExpr>.Nil._N_constant_object))), list<PExpr>.Nil._N_constant_object)), new list<PExpr>.Cons(new PExpr.Literal(new Literal.Null()), list<PExpr>.Nil._N_constant_object)))), new list<SyntaxElement>.Cons(new SyntaxElement.Expression(new PExpr.Assign(new PExpr.Indexer(new PExpr.Ref(Name.NameInCurrentColor("contexts", _N_MacroContexts.Get(11, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Call(new PExpr.Ref(Name.NameInCurrentColor("-", _N_MacroContexts.Get(11, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Ref(Name.NameInCurrentColor("no", _N_MacroContexts.Get(11, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Literal(new Literal.Integer(1uL, is_negative: false, null).WithProperType()), list<PExpr>.Nil._N_constant_object))), list<PExpr>.Nil._N_constant_object)), new PExpr.Call(new PExpr.Ref(Name.NameInCurrentColor("GlobalEnv", _N_MacroContexts.Get(11, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Indexer(new PExpr.Ref(Name.NameInCurrentColor("serialized", _N_MacroContexts.Get(11, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Call(new PExpr.Ref(Name.NameInCurrentColor("-", _N_MacroContexts.Get(11, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Ref(Name.NameInCurrentColor("no", _N_MacroContexts.Get(11, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Literal(new Literal.Integer(1uL, is_negative: false, null).WithProperType()), list<PExpr>.Nil._N_constant_object))), list<PExpr>.Nil._N_constant_object)), new list<PExpr>.Cons(new PExpr.Ref(Name.NameInCurrentColor("from_manager", _N_MacroContexts.Get(11, ManagerClass.Instance))), list<PExpr>.Nil._N_constant_object))))), list<SyntaxElement>.Nil._N_constant_object))), new list<PExpr>.Cons(new PExpr.Indexer(new PExpr.Ref(Name.NameInCurrentColor("contexts", _N_MacroContexts.Get(11, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Call(new PExpr.Ref(Name.NameInCurrentColor("-", _N_MacroContexts.Get(11, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Ref(Name.NameInCurrentColor("no", _N_MacroContexts.Get(11, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Literal(new Literal.Integer(1uL, is_negative: false, null).WithProperType()), list<PExpr>.Nil._N_constant_object))), list<PExpr>.Nil._N_constant_object)), list<PExpr>.Nil._N_constant_object)))))), new list<ClassMember>.Cons(new ClassMember.Function(new Splicable.Name(Name.NameInCurrentColor("Clear", _N_MacroContexts.Get(11, ManagerClass.Instance))), new AttributesAndModifiers(NemerleModifiers.Private | NemerleModifiers.Static, list<PExpr>.Nil._N_constant_object), new PFunHeader(new Typarms(list<Splicable>.Nil._N_constant_object, list<Constraint>.Nil._N_constant_object), new Splicable.Name(Name.NameInCurrentColor("Clear", _N_MacroContexts.Get(11, ManagerClass.Instance))), new PExpr.Void(), list<PParameter>.Nil._N_constant_object), list<PExpr>.Nil._N_constant_object, new FunBody.Parsed(new PExpr.Sequence(new list<PExpr>.Cons(new PExpr.MacroCall(Name.NameInCurrentColor("for", _N_MacroContexts.Get(11, ManagerClass.Instance)), ManagerClass.Instance.NameTree.ExactPath(new list<string>.Cons("Nemerle", new list<string>.Cons("Core", new list<string>.Cons("for", list<string>.Nil._N_constant_object)))), new list<SyntaxElement>.Cons(new SyntaxElement.Expression(new PExpr.DefMutable(new PExpr.Ref(Name.NameInCurrentColor("i", _N_MacroContexts.Get(11, ManagerClass.Instance))), new PExpr.Literal(new Literal.Integer(0uL, is_negative: false, null).WithProperType()))), new list<SyntaxElement>.Cons(new SyntaxElement.Expression(new PExpr.Call(new PExpr.Ref(Name.NameInCurrentColor("<", _N_MacroContexts.Get(11, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Ref(Name.NameInCurrentColor("i", _N_MacroContexts.Get(11, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("contexts", _N_MacroContexts.Get(11, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Length", _N_MacroContexts.Get(11, ManagerClass.Instance)))), list<PExpr>.Nil._N_constant_object)))), new list<SyntaxElement>.Cons(new SyntaxElement.Expression(new PExpr.Call(new PExpr.Ref(Name.NameInCurrentColor("++", _N_MacroContexts.Get(11, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Ref(Name.NameInCurrentColor("i", _N_MacroContexts.Get(11, ManagerClass.Instance))), list<PExpr>.Nil._N_constant_object))), new list<SyntaxElement>.Cons(new SyntaxElement.Expression(new PExpr.Assign(new PExpr.Indexer(new PExpr.Ref(Name.NameInCurrentColor("contexts", _N_MacroContexts.Get(11, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Ref(Name.NameInCurrentColor("i", _N_MacroContexts.Get(11, ManagerClass.Instance))), list<PExpr>.Nil._N_constant_object)), new PExpr.Literal(new Literal.Null()))), list<SyntaxElement>.Nil._N_constant_object))))), new list<PExpr>.Cons(new PExpr.Assign(new PExpr.Ref(Name.NameInCurrentColor("last_manager", _N_MacroContexts.Get(11, ManagerClass.Instance))), new PExpr.Literal(new Literal.Null())), list<PExpr>.Nil._N_constant_object))))), list<ClassMember>.Nil._N_constant_object)))))));
			Manager.Hierarchy.GenerateFakeSourceCode(null, typeDeclaration);
			macro_context_class = Manager.CoreEnv.Define(typeDeclaration);
			macro_context_class.MarkWithSpecialName();
			macro_context_class.Compile();
			list<IField> list = macro_context_class.GetFields();
			while (list is list<IField>.Cons)
			{
				IField hd = ((list<IField>.Cons)list).hd;
				list = ((list<IField>.Cons)list).tl;
				Manager.MarkAsAssigned(hd);
				list = list;
			}
			macro_context_class.CannotFinalize = true;
		}
	}

	internal void FinishMacroContextClass()
	{
		TypeBuilder typeBuilder = macro_context_class;
		if (typeBuilder == null)
		{
			return;
		}
		Location location = typeBuilder.Location;
		bool flag = location.FileIndex != 0;
		if (flag)
		{
			LocationStack.Push(location);
		}
		try
		{
			typeBuilder.Define(new ClassMember.Function(new Splicable.Name(Name.NameInCurrentColor(".ctor", _N_MacroContexts.Get(11, ManagerClass.Instance))), new AttributesAndModifiers(NemerleModifiers.None, list<PExpr>.Nil._N_constant_object), new PFunHeader(new Typarms(list<Splicable>.Nil._N_constant_object, list<Constraint>.Nil._N_constant_object), new Splicable.Name(Name.NameInCurrentColor(".ctor", _N_MacroContexts.Get(11, ManagerClass.Instance))), new PExpr.Void(), list<PParameter>.Nil._N_constant_object), list<PExpr>.Nil._N_constant_object, new FunBody.Parsed(new PExpr.Sequence(new list<PExpr>.Cons(new PExpr.Assign(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("_N_MacroContexts", _N_MacroContexts.Get(11, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("serialized", _N_MacroContexts.Get(11, ManagerClass.Instance)))), Macros.QuotationChoose(LiftMacroContexts())), new list<PExpr>.Cons(new PExpr.Assign(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("_N_MacroContexts", _N_MacroContexts.Get(11, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("contexts", _N_MacroContexts.Get(11, ManagerClass.Instance)))), new PExpr.EmptyArray(new list<PExpr>.Cons(new PExpr.Literal(Literal.FromInt(macro_context)), list<PExpr>.Nil._N_constant_object))), new list<PExpr>.Cons(new PExpr.Call(new PExpr.Ref(Name.NameInCurrentColor("+=", _N_MacroContexts.Get(11, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("ManagerClass", _N_MacroContexts.Get(11, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("OnInit", _N_MacroContexts.Get(11, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Ref(Name.NameInCurrentColor("Clear", _N_MacroContexts.Get(11, ManagerClass.Instance))), list<PExpr>.Nil._N_constant_object))), list<PExpr>.Nil._N_constant_object)))))));
		}
		finally
		{
			if (flag)
			{
				LocationStack.RemoveTop();
			}
		}
		typeBuilder.CannotFinalize = false;
	}

	private void __fake()
	{
		__fake();
		SystemTypeClass systemTypeCache = SystemTypeCache;
		InternalTypeClass internalType = InternalType;
	}

	[CompilerGenerated]
	internal override void RelocateImplInternal(RelocationInfo _info)
	{
		if (!_info.VisitedObjects.ContainsKey(this))
		{
			_info.VisitedObjects[this] = 0;
			namespace_tree?.RelocateImplInternal(_info);
			macro_context_class?.RelocateImplInternal(_info);
		}
	}

	void ISupportRelocation.RelocateImpl(RelocationInfo _info)
	{
		//ILSpy generated this explicit interface implementation from .override directive in RelocateImplInternal
		this.RelocateImplInternal(_info);
	}

	private static void _N_resetChildren_85742(_N_closureOf_ResetAllTypes_85736 _N_ResetAllTypes_cp_85741, Hashtable<string, Node> children)
	{
		foreach (Node value in children.Values)
		{
			Node node = value;
			if (node.Children != null)
			{
				_N_resetChildren_85742(_N_ResetAllTypes_cp_85741, node.Children);
			}
			node.CleanUp();
		}
	}
}
