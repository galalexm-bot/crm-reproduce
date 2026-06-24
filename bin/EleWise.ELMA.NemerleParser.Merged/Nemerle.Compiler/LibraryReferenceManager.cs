using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using Nemerle.Builtins;
using Nemerle.Collections;
using Nemerle.Core;
using Nemerle.Internal;
using Nemerle.Utility;

namespace Nemerle.Compiler;

public class LibraryReferenceManager : ISupportRelocation
{
	private sealed class _N_closureOf__ctor_54546
	{
		internal LibraryReferenceManager _N__N_closurised_this_ptr_54551;

		internal _N_closureOf__ctor_54546()
		{
		}
	}

	private class _N_Enumerable_54656 : IEnumerator, IDisposable, IEnumerator<IMethod>, IEnumerable, IEnumerable<IMethod>
	{
		private bool _N_finally_needed_54695;

		internal IMethod _N_method_54693;

		internal List<IMethod> _N_methods_54691;

		internal List<IMethod>.Enumerator _N_enumerator_54689;

		internal string _N_name_54687;

		internal GlobalEnv _N_env_54685;

		internal IMethod _N_current;

		internal int _N_state;

		internal Function<bool> _N__N_yielding_function_54681;

		internal LibraryReferenceManager _N__N_closurised_this_ptr_54679;

		internal Function<bool> _N__N_wildcard_3438_54677;

		private int _N_this_used;

		public IMethod Current => _N_current;

		public void Dispose()
		{
			_N_state = -1;
			if (_N_finally_needed_54695)
			{
				((IDisposable)_N_enumerator_54689).Dispose();
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
					_N_methods_54691 = _N__N_closurised_this_ptr_54679._extension_methods.GetValueOrDefault(_N_name_54687);
					if (_N_methods_54691 == null)
					{
						goto IL_00f5;
					}
					_N_enumerator_54689 = _N_methods_54691.GetEnumerator();
					_N_finally_needed_54695 = true;
				}
				while (_N_enumerator_54689.MoveNext())
				{
					IMethod method = (_N_method_54693 = _N_enumerator_54689.Current);
					if (_N_env_54685.IsOpenNamespace(_N_method_54693.DeclaringType.NamespaceNode.Parent))
					{
						_N_current = _N_method_54693;
						_N_state = 1;
						return true;
					}
				}
				_N_finally_needed_54695 = false;
				((IDisposable)_N_enumerator_54689).Dispose();
				goto IL_00f5;
				IL_00f5:
				return false;
			}
			catch
			{
				//try-fault
				Dispose();
				throw;
			}
		}

		public IEnumerator<IMethod> GetEnumerator()
		{
			object result;
			if (Interlocked.CompareExchange(ref _N_this_used, 1, 0) != 0)
			{
				_N_Enumerable_54656 n_Enumerable_ = new _N_Enumerable_54656();
				n_Enumerable_.CopyFrom(this);
				result = (IEnumerator<IMethod>)n_Enumerable_;
			}
			else
			{
				result = (IEnumerator<IMethod>)this;
			}
			return (IEnumerator<IMethod>)result;
		}

		private IEnumerator NonGenericGetEnum()
		{
			object result;
			if (Interlocked.CompareExchange(ref _N_this_used, 1, 0) != 0)
			{
				_N_Enumerable_54656 n_Enumerable_ = new _N_Enumerable_54656();
				n_Enumerable_.CopyFrom(this);
				result = (IEnumerator)n_Enumerable_;
			}
			else
			{
				result = (IEnumerator)this;
			}
			return (IEnumerator)result;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in NonGenericGetEnum
			return this.NonGenericGetEnum();
		}

		private void CopyFrom(_N_Enumerable_54656 other)
		{
			_N_this_used = 1;
			_N_name_54687 = other._N_name_54687;
			_N_env_54685 = other._N_env_54685;
			_N__N_closurised_this_ptr_54679 = other._N__N_closurised_this_ptr_54679;
		}

		[SpecialName]
		object IEnumerator.get_Current()
		{
			return Current;
		}
	}

	private class _N_Enumerable_54766 : IEnumerator, IDisposable, IEnumerator<IMethod>, IEnumerable, IEnumerable<IMethod>
	{
		private bool _N_finally_needed_54811;

		internal IMethod _N_method_54809;

		internal string _N_name_54807;

		internal List<IMethod> _N_methods_54805;

		internal List<IMethod>.Enumerator _N_enumerator_54803;

		internal Nemerle.Builtins.Tuple<string, List<IMethod>>[] _N_cached_collection_54801;

		internal int _N_index_54799;

		internal string _N_pattern_54797;

		internal GlobalEnv _N_env_54795;

		internal IMethod _N_current;

		internal int _N_state;

		internal Function<bool> _N__N_yielding_function_54791;

		internal LibraryReferenceManager _N__N_closurised_this_ptr_54789;

		internal Function<bool> _N__N_wildcard_3438_54787;

		private int _N_this_used;

		public IMethod Current => _N_current;

		public void Dispose()
		{
			_N_state = -1;
			if (_N_finally_needed_54811)
			{
				((IDisposable)_N_enumerator_54803).Dispose();
			}
		}

		public void Reset()
		{
			//Discarded unreachable code: IL_0006
			throw new NotSupportedException();
		}

		public bool MoveNext()
		{
			checked
			{
				try
				{
					bool flag = false;
					if (_N_state == 1)
					{
						goto IL_00c2;
					}
					if (_N_state != 0)
					{
						return false;
					}
					_N_cached_collection_54801 = _N__N_closurised_this_ptr_54789._extension_methods.KeyValuePairs;
					_N_index_54799 = 0;
					goto IL_0048;
					IL_00c2:
					while (_N_enumerator_54803.MoveNext())
					{
						IMethod method = (_N_method_54809 = _N_enumerator_54803.Current);
						if (_N_env_54795.IsOpenNamespace(_N_method_54809.DeclaringType.NamespaceNode.Parent))
						{
							_N_current = _N_method_54809;
							_N_state = 1;
							return true;
						}
					}
					_N_finally_needed_54811 = false;
					((IDisposable)_N_enumerator_54803).Dispose();
					goto IL_0147;
					IL_0147:
					_N_index_54799++;
					goto IL_0048;
					IL_0048:
					if (_N_index_54799 < _N_cached_collection_54801.Length)
					{
						Nemerle.Builtins.Tuple<string, List<IMethod>> tuple = _N_cached_collection_54801[_N_index_54799];
						_N_name_54807 = tuple.Field0;
						_N_methods_54805 = tuple.Field1;
						if (Completion.MatchName(_N_name_54807, _N_pattern_54797))
						{
							_N_enumerator_54803 = _N_methods_54805.GetEnumerator();
							_N_finally_needed_54811 = true;
							goto IL_00c2;
						}
						goto IL_0147;
					}
					return false;
				}
				catch
				{
					//try-fault
					Dispose();
					throw;
				}
			}
		}

		public IEnumerator<IMethod> GetEnumerator()
		{
			object result;
			if (Interlocked.CompareExchange(ref _N_this_used, 1, 0) != 0)
			{
				_N_Enumerable_54766 n_Enumerable_ = new _N_Enumerable_54766();
				n_Enumerable_.CopyFrom(this);
				result = (IEnumerator<IMethod>)n_Enumerable_;
			}
			else
			{
				result = (IEnumerator<IMethod>)this;
			}
			return (IEnumerator<IMethod>)result;
		}

		private IEnumerator NonGenericGetEnum()
		{
			object result;
			if (Interlocked.CompareExchange(ref _N_this_used, 1, 0) != 0)
			{
				_N_Enumerable_54766 n_Enumerable_ = new _N_Enumerable_54766();
				n_Enumerable_.CopyFrom(this);
				result = (IEnumerator)n_Enumerable_;
			}
			else
			{
				result = (IEnumerator)this;
			}
			return (IEnumerator)result;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in NonGenericGetEnum
			return this.NonGenericGetEnum();
		}

		private void CopyFrom(_N_Enumerable_54766 other)
		{
			_N_this_used = 1;
			_N_pattern_54797 = other._N_pattern_54797;
			_N_env_54795 = other._N_env_54795;
			_N__N_closurised_this_ptr_54789 = other._N__N_closurised_this_ptr_54789;
		}

		[SpecialName]
		object IEnumerator.get_Current()
		{
			return Current;
		}
	}

	private class _N_Enumerable_54886 : IEnumerator, IDisposable, IEnumerator<IMethod>, IEnumerable, IEnumerable<IMethod>
	{
		private bool _N_finally_needed_54929;

		internal IMethod _N_method_54927;

		internal string _N_name_54925;

		internal List<IMethod> _N_methods_54923;

		internal List<IMethod>.Enumerator _N_enumerator_54921;

		internal Nemerle.Builtins.Tuple<string, List<IMethod>>[] _N_cached_collection_54919;

		internal int _N_index_54917;

		internal string _N_pattern_54915;

		internal IMethod _N_current;

		internal int _N_state;

		internal Function<bool> _N__N_yielding_function_54911;

		internal LibraryReferenceManager _N__N_closurised_this_ptr_54909;

		internal Function<bool> _N__N_wildcard_3438_54907;

		private int _N_this_used;

		public IMethod Current => _N_current;

		public void Dispose()
		{
			_N_state = -1;
			if (_N_finally_needed_54929)
			{
				((IDisposable)_N_enumerator_54921).Dispose();
			}
		}

		public void Reset()
		{
			//Discarded unreachable code: IL_0006
			throw new NotSupportedException();
		}

		public bool MoveNext()
		{
			checked
			{
				try
				{
					bool flag = false;
					if (_N_state == 1)
					{
						goto IL_00c2;
					}
					if (_N_state != 0)
					{
						return false;
					}
					_N_cached_collection_54919 = _N__N_closurised_this_ptr_54909._extension_methods.KeyValuePairs;
					_N_index_54917 = 0;
					goto IL_0048;
					IL_00c2:
					if (_N_enumerator_54921.MoveNext())
					{
						IMethod method = (_N_method_54927 = _N_enumerator_54921.Current);
						_N_current = _N_method_54927;
						_N_state = 1;
						return true;
					}
					_N_finally_needed_54929 = false;
					((IDisposable)_N_enumerator_54921).Dispose();
					goto IL_011d;
					IL_011d:
					_N_index_54917++;
					goto IL_0048;
					IL_0048:
					if (_N_index_54917 < _N_cached_collection_54919.Length)
					{
						Nemerle.Builtins.Tuple<string, List<IMethod>> tuple = _N_cached_collection_54919[_N_index_54917];
						_N_name_54925 = tuple.Field0;
						_N_methods_54923 = tuple.Field1;
						if (Completion.MatchName(_N_name_54925, _N_pattern_54915))
						{
							_N_enumerator_54921 = _N_methods_54923.GetEnumerator();
							_N_finally_needed_54929 = true;
							goto IL_00c2;
						}
						goto IL_011d;
					}
					return false;
				}
				catch
				{
					//try-fault
					Dispose();
					throw;
				}
			}
		}

		public IEnumerator<IMethod> GetEnumerator()
		{
			object result;
			if (Interlocked.CompareExchange(ref _N_this_used, 1, 0) != 0)
			{
				_N_Enumerable_54886 n_Enumerable_ = new _N_Enumerable_54886();
				n_Enumerable_.CopyFrom(this);
				result = (IEnumerator<IMethod>)n_Enumerable_;
			}
			else
			{
				result = (IEnumerator<IMethod>)this;
			}
			return (IEnumerator<IMethod>)result;
		}

		private IEnumerator NonGenericGetEnum()
		{
			object result;
			if (Interlocked.CompareExchange(ref _N_this_used, 1, 0) != 0)
			{
				_N_Enumerable_54886 n_Enumerable_ = new _N_Enumerable_54886();
				n_Enumerable_.CopyFrom(this);
				result = (IEnumerator)n_Enumerable_;
			}
			else
			{
				result = (IEnumerator)this;
			}
			return (IEnumerator)result;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in NonGenericGetEnum
			return this.NonGenericGetEnum();
		}

		private void CopyFrom(_N_Enumerable_54886 other)
		{
			_N_this_used = 1;
			_N_pattern_54915 = other._N_pattern_54915;
			_N__N_closurised_this_ptr_54909 = other._N__N_closurised_this_ptr_54909;
		}

		[SpecialName]
		object IEnumerator.get_Current()
		{
			return Current;
		}
	}

	private sealed class _N_closureOf_LookupAssembly_55462
	{
		internal LibraryReferenceManager _N__N_closurised_this_ptr_55467;

		internal _N_closureOf_LookupAssembly_55462()
		{
		}
	}

	private sealed class _N__N_lambda__55640__55716 : Function<object, bool>
	{
		[SpecialName]
		public static readonly _N__N_lambda__55640__55716 Instance = new _N__N_lambda__55640__55716();

		[SpecialName]
		public sealed override bool apply(object t)
		{
			return t.GetType().FullName == "Nemerle.Internal.ContainsMacroAttribute";
		}
	}

	private sealed class _N__N_lambda__55646__55726 : Function<object, bool>
	{
		[SpecialName]
		public static readonly _N__N_lambda__55646__55726 Instance = new _N__N_lambda__55646__55726();

		[SpecialName]
		public sealed override bool apply(object t)
		{
			return t.GetType().FullName == "Nemerle.Internal.OperatorAttribute";
		}
	}

	private sealed class _N__N_lambda__55753__55780 : Function<object, bool>
	{
		[SpecialName]
		public static readonly _N__N_lambda__55753__55780 Instance = new _N__N_lambda__55753__55780();

		[SpecialName]
		public sealed override bool apply(object t)
		{
			return t.GetType().FullName == "Nemerle.Internal.RegisterParserAttribute";
		}
	}

	private sealed class _N__N_lambda__55900__55926 : Function<Type, bool>
	{
		[SpecialName]
		public static readonly _N__N_lambda__55900__55926 Instance = new _N__N_lambda__55900__55926();

		[SpecialName]
		public sealed override bool apply(Type t)
		{
			return t.IsPublic || t.IsNotPublic || t.IsNestedPublic || t.IsNestedFamORAssem || t.IsNestedAssembly;
		}
	}

	private sealed class _N_closureOf_framework_nesting_56071
	{
		internal LibraryReferenceManager _N__N_closurised_this_ptr_56076;

		internal _N_closureOf_framework_nesting_56071()
		{
		}
	}

	public readonly NamespaceTree NameTree;

	internal readonly List<LibraryReference> ReferencedAssemblies;

	internal bool add_buildins;

	private readonly list<string> _lib_path;

	private readonly Hashtable<string, LibraryReference> _loaded_assemblies_by_name;

	private readonly Hashtable<string, Assembly> _loaded_macro_assemblies;

	private readonly Hashtable<string, int> _assemblies_loaded_by_hand;

	private readonly Hashtable<string, NamespaceTree.Node> namespace_nodes;

	private list<NamespaceTree.Node> _construct_right_away;

	private readonly Hashtable<string, List<IMethod>> _extension_methods;

	public readonly ManagerClass Manager;

	public InternalTypeClass InternalType => Manager.InternalType;

	public SystemTypeClass SystemTypeCache => Manager.SystemTypeCache;

	public LibraryReferenceManager(ManagerClass man, [Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] list<string> lib_paths)
	{
		_N_closureOf__ctor_54546 n_closureOf__ctor_ = new _N_closureOf__ctor_54546();
		ReferencedAssemblies = new List<LibraryReference>();
		add_buildins = false;
		_loaded_assemblies_by_name = new Hashtable<string, LibraryReference>(20);
		_loaded_macro_assemblies = new Hashtable<string, Assembly>(20);
		_assemblies_loaded_by_hand = new Hashtable<string, int>(20);
		namespace_nodes = new Hashtable<string, NamespaceTree.Node>(300);
		_construct_right_away = list<NamespaceTree.Node>.Nil._N_constant_object;
		_extension_methods = new Hashtable<string, List<IMethod>>();
		base._002Ector();
		n_closureOf__ctor_._N__N_closurised_this_ptr_54551 = this;
		if ((object)lib_paths == null)
		{
			throw new ArgumentNullException("lib_paths", "The ``NotNull'' contract of parameter ``lib_paths'' has been violated. See ncc\\external\\LibraryReferenceManager.n:62:48:62:57: .");
		}
		NameTree = man.NameTree;
		Manager = man;
		_lib_path = new list<string>.Cons(_N_assembly_dir_54557(n_closureOf__ctor_, typeof(AssertionException)), new list<string>.Cons(Environment.CurrentDirectory, new list<string>.Cons(_N_assembly_dir_54557(n_closureOf__ctor_, typeof(Match)), new list<string>.Cons(_N_assembly_dir_54557(n_closureOf__ctor_, typeof(LibraryReferenceManager)), new list<string>.Cons(_N_assembly_dir_54557(n_closureOf__ctor_, typeof(object)), lib_paths)))));
	}

	public void AddLibrary(string name, bool isUserReference)
	{
		Assembly assembly;
		string name2;
		if (name == "mscorlib")
		{
			if (Manager.Options.UseLoadedCorlib)
			{
				assembly = typeof(object).Assembly;
				goto IL_008d;
			}
			name2 = name;
		}
		else if (name == "System")
		{
			if (Manager.Options.UseLoadedCorlib)
			{
				assembly = typeof(Match).Assembly;
				goto IL_008d;
			}
			name2 = name;
		}
		else
		{
			name2 = name;
		}
		assembly = LookupAssembly(name2);
		goto IL_008d;
		IL_008d:
		Assembly assembly2 = assembly;
		if (assembly2 == null)
		{
			Message.Error("cannot find assembly `" + Convert.ToString(name) + "'");
			throw new AssemblyFindException();
		}
		if (_loaded_assemblies_by_name.Contains(assembly2.FullName))
		{
			if (_assemblies_loaded_by_hand.Contains(assembly2.FullName) && !Manager.Options.PersistentLibraries)
			{
				Message.Warning("assembly `" + Convert.ToString(name) + "' already loaded");
			}
			_assemblies_loaded_by_hand[assembly2.FullName] = 42;
		}
		else
		{
			_assemblies_loaded_by_hand[assembly2.FullName] = 42;
			AddAssembly(assembly2, isUserReference);
		}
	}

	public void AddAssembly(Assembly assembly, bool isUserReference)
	{
		if (_loaded_assemblies_by_name.Contains(assembly.FullName))
		{
			return;
		}
		_loaded_assemblies_by_name[assembly.FullName] = new LibraryReference(this, assembly, isUserReference);
		if (!Manager.Options.GreedyReferences)
		{
			return;
		}
		AssemblyName[] referencedAssemblies = assembly.GetReferencedAssemblies();
		AssemblyName[] array = referencedAssemblies;
		foreach (AssemblyName assemblyName in array)
		{
			AssemblyName assemblyName2 = assemblyName;
			Assembly assembly2;
			try
			{
				assembly2 = assemblyLoad(assemblyName2);
			}
			catch (FileNotFoundException)
			{
				Assembly assembly3;
				try
				{
					assembly3 = assemblyLoadFrom(getAssemblyLocation(assemblyName2));
				}
				catch (Exception)
				{
					assembly3 = LookupAssembly(assemblyName2.Name);
				}
				assembly2 = assembly3;
			}
			Assembly assembly4 = assembly2;
			if (assembly4 != null)
			{
				AddAssembly(assembly4, isUserReference: false);
			}
		}
	}

	public IEnumerable<IMethod> GetExtensionMethods(string name, GlobalEnv env)
	{
		_N_Enumerable_54656 n_Enumerable_ = new _N_Enumerable_54656();
		n_Enumerable_._N_name_54687 = name;
		n_Enumerable_._N_env_54685 = env;
		n_Enumerable_._N__N_closurised_this_ptr_54679 = this;
		return n_Enumerable_;
	}

	public IEnumerable<IMethod> GetExtensionMethodsForCompletion(string pattern, GlobalEnv env)
	{
		_N_Enumerable_54766 n_Enumerable_ = new _N_Enumerable_54766();
		n_Enumerable_._N_pattern_54797 = pattern;
		n_Enumerable_._N_env_54795 = env;
		n_Enumerable_._N__N_closurised_this_ptr_54789 = this;
		return n_Enumerable_;
	}

	public IEnumerable<IMethod> GetExtensionMethodsForCompletion(string pattern)
	{
		_N_Enumerable_54886 n_Enumerable_ = new _N_Enumerable_54886();
		n_Enumerable_._N_pattern_54915 = pattern;
		n_Enumerable_._N__N_closurised_this_ptr_54909 = this;
		return n_Enumerable_;
	}

	public void AddExtensionMethod(IMethod m)
	{
		List<IMethod> valueOrDefault = _extension_methods.GetValueOrDefault(m.Name);
		if (valueOrDefault == null)
		{
			valueOrDefault = new List<IMethod>();
			valueOrDefault.Add(m);
			_extension_methods[m.Name] = valueOrDefault;
		}
		else
		{
			valueOrDefault.Add(m);
		}
		if (m is MethodBuilder)
		{
			((MethodBuilder)m).IsExtension = true;
		}
		else if (m is LibraryReference.ExternalMethodInfo)
		{
			((LibraryReference.ExternalMethodInfo)m).IsExtension = true;
		}
		else if (m is BuiltinMethod)
		{
			((BuiltinMethod)m).IsExtension = true;
		}
	}

	public static string DirectoryOfCodebase(string path)
	{
		path = Path.GetDirectoryName(path);
		int num = path.IndexOf("mono/gac");
		path = ((num == -1) ? path : checked((path.LastIndexOf("Nemerle") > num) ? (path.Substring(0, num + 5) + "nemerle/") : ((path.LastIndexOf("/2.0.") <= num) ? (path.Substring(0, num + 5) + "1.0/") : (path.Substring(0, num + 5) + "2.0/"))));
		return path;
	}

	protected override Assembly assemblyLoad(string name)
	{
		return Assembly.Load(name);
	}

	protected override Assembly assemblyLoad(AssemblyName name)
	{
		return Assembly.Load(name);
	}

	protected override Assembly assemblyLoadFrom(string path)
	{
		try
		{
			return Assembly.LoadFrom(path);
		}
		catch (BadImageFormatException)
		{
			return assemblyLoad(AssemblyName.GetAssemblyName(path).FullName);
		}
	}

	public override string getAssemblyLocation(Assembly assembly)
	{
		return new Uri(assembly.CodeBase).LocalPath;
	}

	public override string getAssemblyLocation(AssemblyName assembly)
	{
		return new Uri(assembly.CodeBase).LocalPath;
	}

	private Assembly LookupAssembly(string name)
	{
		_N_closureOf_LookupAssembly_55462 n_closureOf_LookupAssembly_ = new _N_closureOf_LookupAssembly_55462();
		n_closureOf_LookupAssembly_._N__N_closurised_this_ptr_55467 = this;
		object result;
		if (name.IndexOf('/') != -1 || name.IndexOf('\\') != -1)
		{
			result = _N_assembly_by_name_55470(n_closureOf_LookupAssembly_, name);
		}
		else if (name.IndexOf(',') != -1)
		{
			Assembly assembly;
			try
			{
				assembly = assemblyLoad(name);
			}
			catch (FileNotFoundException)
			{
				assembly = null;
			}
			catch (BadImageFormatException)
			{
				Message.Error("passed strong name is invalid or assembly was not found");
				assembly = null;
			}
			result = assembly;
		}
		else
		{
			list<string> list = _lib_path;
			object obj;
			while (true)
			{
				if (list is list<string>.Cons)
				{
					string hd = ((list<string>.Cons)list).hd;
					list<string> tl = ((list<string>.Cons)list).tl;
					Assembly assembly2 = _N_assembly_by_name_55470(n_closureOf_LookupAssembly_, Path.Combine(hd, name));
					if (assembly2 == null)
					{
						list = tl;
						continue;
					}
					obj = assembly2;
					break;
				}
				if ((object)list == list<string>.Nil._N_constant_object)
				{
					obj = null;
					break;
				}
				throw new MatchFailureException();
			}
			Assembly assembly3 = (Assembly)obj;
			result = ((!(assembly3 == null)) ? assembly3 : Assembly.LoadWithPartialName(name));
		}
		return (Assembly)result;
	}

	private void load_macro(Assembly lib, string macro_name)
	{
		Type type = lib.GetType(macro_name.Replace("&", "\\&"));
		if (type == null)
		{
			Message.Warning("failed to lookup macro `" + Convert.ToString(macro_name) + "' in assembly " + Convert.ToString(lib.FullName));
			return;
		}
		ConstructorInfo constructor = type.GetConstructor(Type.EmptyTypes);
		if (constructor == null)
		{
			Message.Warning("failed to lookup constructor in macro `" + Convert.ToString(macro_name) + "' from assembly " + Convert.ToString(lib.FullName));
			return;
		}
		object obj = constructor.Invoke(null);
		if (obj == null)
		{
			Message.Warning("failed to construct instance of macro `" + Convert.ToString(macro_name) + "' from assembly " + Convert.ToString(lib.FullName));
			return;
		}
		if (obj is IMacro)
		{
			IMacro macro = (IMacro)obj;
			string @namespace = macro.GetNamespace();
			if (namespace_nodes.Get(@namespace).IsNone)
			{
				NamespaceTree.Node node = cache_namespace_node(@namespace);
			}
			Manager.MacrosRegistry.RegisterMacro(macro);
			return;
		}
		type = obj.GetType().GetInterface("Nemerle.Compiler.IMacro");
		if (type == null)
		{
			Message.Error("instance of macro `" + Convert.ToString(macro_name) + "' from assembly " + Convert.ToString(lib.FullName) + " does not implement IMacro interface");
			return;
		}
		Type typeFromHandle = typeof(IMacro);
		if (type.Equals(typeFromHandle))
		{
		}
		Message.Error("The macro `" + Convert.ToString(macro_name) + "' implement the IMacro interface from '" + Convert.ToString(_N_getAssemblyPath_55547(type)) + "' but the compiler use this interface from '" + Convert.ToString(_N_getAssemblyPath_55547(typeFromHandle)) + "'.");
	}

	internal void LoadLibrariesContents()
	{
		try
		{
			AppDomain currentDomain = AppDomain.CurrentDomain;
			currentDomain.AssemblyResolve += OnAssemblyResolve;
			Nemerle.Builtins.Tuple<string, LibraryReference>[] keyValuePairs = _loaded_assemblies_by_name.KeyValuePairs;
			for (int i = 0; i < keyValuePairs.Length; i = checked(i + 1))
			{
				Nemerle.Builtins.Tuple<string, LibraryReference> tuple = keyValuePairs[i];
				string field = tuple.Field0;
				LibraryReference field2 = tuple.Field1;
				if (field2 != null)
				{
					field2.LoadContents();
					_loaded_assemblies_by_name[field] = null;
					if (field2.IsUserReference)
					{
						ReferencedAssemblies.Add(field2);
					}
				}
			}
		}
		finally
		{
			AppDomain currentDomain2 = AppDomain.CurrentDomain;
			currentDomain2.AssemblyResolve -= OnAssemblyResolve;
		}
	}

	private Assembly OnAssemblyResolve(object _N_wildcard_3340, ResolveEventArgs args)
	{
		LibraryReference value = null;
		return (!_loaded_assemblies_by_name.TryGetValue(args.Name, out value)) ? null : value?.Assembly;
	}

	public void LoadPluginsFrom(string name, string strongPart = null, bool loadMacros = true, bool loadParsers = true)
	{
		Assembly assembly = null;
		assembly = LookupAssembly(name);
		if (assembly == null && strongPart != null)
		{
			assembly = assemblyLoad(name + strongPart);
		}
		if (assembly == null)
		{
			Message.Error(string.Concat("cannot load assembly with macros `" + name, "'"));
			return;
		}
		if (loadMacros)
		{
			LoadMacrosFrom(assembly);
		}
		if (loadParsers)
		{
			LoadParsersFrom(assembly);
		}
	}

	public void LoadMacrosFrom(Assembly assembly)
	{
		if (!(assembly != null))
		{
			throw new AssertionException("ncc\\external\\LibraryReferenceManager.n", 392, "assembly != null", "");
		}
		option<LibraryReference> option = _loaded_assemblies_by_name.Get(assembly.FullName);
		if (option is option<LibraryReference>.Some && (object)((option<LibraryReference>.Some)option).val == null)
		{
			return;
		}
		object[] customAttributes = assembly.GetCustomAttributes(inherit: false);
		Function<object, bool> instance = _N__N_lambda__55640__55716.Instance;
		list<object> list = customAttributes.Filter(instance);
		Function<object, bool> instance2 = _N__N_lambda__55646__55726.Instance;
		list<object> list2 = customAttributes.Filter(instance2);
		try
		{
			list<object> list3 = list;
			while (list3 is list<object>.Cons)
			{
				object hd = ((list<object>.Cons)list3).hd;
				list<object> tl = ((list<object>.Cons)list3).tl;
				object obj = hd;
				object obj2 = null;
				obj2 = obj;
				load_macro(assembly, (string)obj2.GetType().InvokeMember("Name", System.Reflection.BindingFlags.GetField | System.Reflection.BindingFlags.GetProperty, null, obj2, null, null, null, null));
				list3 = tl;
			}
			list<object> list4 = list2;
			while (list4 is list<object>.Cons)
			{
				object hd2 = ((list<object>.Cons)list4).hd;
				list<object> tl2 = ((list<object>.Cons)list4).tl;
				object obj3 = hd2;
				NamespaceTree nameTree = NameTree;
				object obj4 = null;
				obj4 = obj3;
				NamespaceTree.Node node = nameTree.ExactPath(NString.Split((string)obj4.GetType().InvokeMember("Env", System.Reflection.BindingFlags.GetField | System.Reflection.BindingFlags.GetProperty, null, obj4, null, null, null, null), '.'));
				object obj5 = null;
				obj5 = obj3;
				string name = (string)obj5.GetType().InvokeMember("Name", System.Reflection.BindingFlags.GetField | System.Reflection.BindingFlags.GetProperty, null, obj5, null, null, null, null);
				object obj6 = null;
				obj6 = obj3;
				int left = (int)obj6.GetType().InvokeMember("Left", System.Reflection.BindingFlags.GetField | System.Reflection.BindingFlags.GetProperty, null, obj6, null, null, null, null);
				object obj7 = null;
				obj7 = obj3;
				int right = (int)obj7.GetType().InvokeMember("Right", System.Reflection.BindingFlags.GetField | System.Reflection.BindingFlags.GetProperty, null, obj7, null, null, null, null);
				object obj8 = null;
				obj8 = obj3;
				OperatorDefinition info = new OperatorDefinition(node, name, left, right, (bool)obj8.GetType().InvokeMember("IsUnary", System.Reflection.BindingFlags.GetField | System.Reflection.BindingFlags.GetProperty, null, obj8, null, null, null, null));
				Manager.MacrosRegistry.AddOperatorDefinition(info);
				list4 = tl2;
			}
		}
		catch (TypeLoadException ex)
		{
			Message.Error("cannot load types from macroassembly `" + Convert.ToString(assembly.FullName) + "' (" + Convert.ToString(getAssemblyLocation(assembly)) + "): " + Convert.ToString(ex.Message));
		}
	}

	public void LoadParsersFrom(Assembly assembly)
	{
		if (!(assembly != null))
		{
			throw new AssertionException("ncc\\external\\LibraryReferenceManager.n", 431, "assembly != null", "");
		}
		object[] customAttributes = assembly.GetCustomAttributes(inherit: false);
		Function<object, bool> instance = _N__N_lambda__55753__55780.Instance;
		list<object> list = customAttributes.Filter(instance);
		try
		{
			list<object> list2 = list;
			while (list2 is list<object>.Cons)
			{
				object hd = ((list<object>.Cons)list2).hd;
				list<object> tl = ((list<object>.Cons)list2).tl;
				object obj = hd;
				object obj2 = null;
				obj2 = obj;
				string text = (string)obj2.GetType().InvokeMember("Name", System.Reflection.BindingFlags.GetField | System.Reflection.BindingFlags.GetProperty, null, obj2, null, null, null, null);
				object obj3 = null;
				obj3 = obj;
				string fileExtension = (string)obj3.GetType().InvokeMember("Extension", System.Reflection.BindingFlags.GetField | System.Reflection.BindingFlags.GetProperty, null, obj3, null, null, null, null);
				Type type = assembly.GetType(text);
				if ((object)type == null)
				{
					Message.Warning("failed to lookup parser `" + Convert.ToString(text) + "' in assembly " + Convert.ToString(assembly.FullName));
				}
				else
				{
					Type parserType = type;
					Manager.Parser.Register(parserType, fileExtension);
				}
				list2 = tl;
			}
		}
		catch (TypeLoadException ex)
		{
			Message.Error("cannot load parsers from assembly `" + Convert.ToString(assembly.FullName) + "' (" + Convert.ToString(getAssemblyLocation(assembly)) + "): " + Convert.ToString(ex.Message));
		}
	}

	public bool IsAssemblyLoaded(string assemblyFullName)
	{
		return _loaded_assemblies_by_name.Contains(assemblyFullName);
	}

	public void RemoveInternalExtensionMethods()
	{
		int num = 0;
		Nemerle.Builtins.Tuple<string, List<IMethod>>[] keyValuePairs = _extension_methods.KeyValuePairs;
		for (num = 0; num < keyValuePairs.Length; num = checked(num + 1))
		{
			Nemerle.Builtins.Tuple<string, List<IMethod>> tuple = keyValuePairs[num];
			string field = tuple.Field0;
			List<IMethod> list = tuple.Field1;
			if (list.Exists(_N__N_lambda__55817_55841))
			{
				int num2 = list.RemoveAll(_N__N_lambda__55823_55849);
				if (list.Count == 0)
				{
					_extension_methods.Remove(field);
				}
			}
		}
	}

	internal void LoadExtensions()
	{
		list<NamespaceTree.Node> list = _construct_right_away;
		while (list is list<NamespaceTree.Node>.Cons)
		{
			NamespaceTree.Node hd = ((list<NamespaceTree.Node>.Cons)list).hd;
			list = ((list<NamespaceTree.Node>.Cons)list).tl;
			option<TypeInfo> option = hd.LookupValue();
			list = list;
		}
		_construct_right_away = list<NamespaceTree.Node>.Nil._N_constant_object;
	}

	public bool IsExtension(ICustomAttributeProvider attrsProvider)
	{
		return (SystemTypeCache.ExtensionAttribute != null && attrsProvider.IsDefined(SystemTypeCache.ExtensionAttribute, inherit: false)) || (SystemTypeCache.SQ_ExtensionAttribute != null && attrsProvider.IsDefined(SystemTypeCache.SQ_ExtensionAttribute, inherit: false));
	}

	internal void LoadTypesFrom(LibraryReference lib)
	{
		Assembly assembly = lib.Assembly;
		try
		{
			Type[] array;
			if (lib.IsFriend)
			{
				Type[] types = assembly.GetTypes();
				Function<Type, bool> instance = _N__N_lambda__55900__55926.Instance;
				array = types.Filter(instance).ToArray();
			}
			else
			{
				array = assembly.GetExportedTypes();
			}
			Type[] array2 = array;
			Type[] array3 = array2;
			foreach (Type type in array3)
			{
				Type type2 = type;
				ExternalType externalType = new ExternalType(type2, lib, null);
				Nemerle.Builtins.Tuple<NamespaceTree.Node, list<string>> tuple = framework_nesting(type2);
				NamespaceTree.Node field = tuple.Field0;
				list<string> field2 = tuple.Field1;
				NamespaceTree.Node node = field.Path(field2);
				if (IsExtension(type2))
				{
					_construct_right_away = new list<NamespaceTree.Node>.Cons(node, _construct_right_away);
				}
				NamespaceTree.TypeInfoCache value = node.Value;
				object value2;
				if (value is NamespaceTree.TypeInfoCache.NotLoaded)
				{
					ExternalType e = ((NamespaceTree.TypeInfoCache.NotLoaded)value).e;
					value2 = new NamespaceTree.TypeInfoCache.NotLoadedList(new list<ExternalType>.Cons(externalType, new list<ExternalType>.Cons(e, list<ExternalType>.Nil._N_constant_object)));
				}
				else if (value is NamespaceTree.TypeInfoCache.NotLoadedList)
				{
					list<ExternalType> tl = ((NamespaceTree.TypeInfoCache.NotLoadedList)value).elems;
					value2 = new NamespaceTree.TypeInfoCache.NotLoadedList(new list<ExternalType>.Cons(externalType, tl));
				}
				else
				{
					value2 = new NamespaceTree.TypeInfoCache.NotLoaded(externalType);
				}
				NamespaceTree.TypeInfoCache typeInfoCache = (node.Value = (NamespaceTree.TypeInfoCache)value2);
			}
		}
		catch (Exception ex)
		{
			Message.Error("Can't load types from '" + Convert.ToString(assembly) + "'. Error: " + Convert.ToString(ex.Message) + ".");
		}
	}

	internal static void CacheTypeInfo(Type t, TypeInfo tc, NamespaceTree.Node node)
	{
		NamespaceTree.TypeInfoCache value = node.Value;
		if (value == NamespaceTree.TypeInfoCache.No._N_constant_object)
		{
			node.Value = new NamespaceTree.TypeInfoCache.Cached(tc);
			return;
		}
		if (value is NamespaceTree.TypeInfoCache.Cached || value is NamespaceTree.TypeInfoCache.CachedAmbiguous)
		{
			if (!Message.SeenError)
			{
				string text = ("wanted to cache cached value " + t.TypeFullName()).ToString();
				Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
			}
			throw new AssertionException("ncc\\external\\LibraryReferenceManager.n", 567, "", ("wanted to cache cached value " + t.TypeFullName()).ToString());
		}
		if (value is NamespaceTree.TypeInfoCache.NotLoaded)
		{
			ExternalType e = ((NamespaceTree.TypeInfoCache.NotLoaded)value).e;
			e.tycon = tc;
			if (e.system_type.Equals(t))
			{
			}
			return;
		}
		if (value is NamespaceTree.TypeInfoCache.NotLoadedList)
		{
			list<ExternalType> list = ((NamespaceTree.TypeInfoCache.NotLoadedList)value).elems;
			list = list;
			while (list is list<ExternalType>.Cons)
			{
				ExternalType e = ((list<ExternalType>.Cons)list).hd;
				list = ((list<ExternalType>.Cons)list).tl;
				e = e;
				if (e.system_type.Equals(t))
				{
					e.tycon = tc;
					break;
				}
				list = list;
			}
			return;
		}
		if (value is NamespaceTree.TypeInfoCache.MacroCall || value == NamespaceTree.TypeInfoCache.NamespaceReference._N_constant_object)
		{
			if (!Message.SeenError)
			{
				string text = ("wanted to cache in wrong place - value " + t.TypeFullName()).ToString();
				Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
			}
			throw new AssertionException("ncc\\external\\LibraryReferenceManager.n", 564, "", ("wanted to cache in wrong place - value " + t.TypeFullName()).ToString());
		}
		throw new MatchFailureException();
	}

	internal static TypeInfo GetInternalType(LibraryReference lib, Type t, NamespaceTree.Node node)
	{
		NamespaceTree.TypeInfoCache value = node.Value;
		TypeInfo result;
		if (value is NamespaceTree.TypeInfoCache.Cached)
		{
			TypeInfo tycon = ((NamespaceTree.TypeInfoCache.Cached)value).tycon;
			result = tycon;
		}
		else
		{
			if (value != NamespaceTree.TypeInfoCache.No._N_constant_object)
			{
				if (!Message.SeenError)
				{
					string text = string.Concat(string.Concat("not loaded internal type... " + t.Assembly.CodeBase, ":"), t.TypeFullName()).ToString();
					Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
				}
				throw new AssertionException("ncc\\external\\LibraryReferenceManager.n", 578, "", string.Concat(string.Concat("not loaded internal type... " + t.Assembly.CodeBase, ":"), t.TypeFullName()).ToString());
			}
			result = lib.ConstructTypeInfo(t, node);
		}
		return result;
	}

	internal NamespaceTree.Node cache_namespace_node(string namespc)
	{
		NamespaceTree.Node node = null;
		NamespaceTree.Node node2 = NameTree.ExactPath(NString.Split(namespc, '.'));
		for (node = node2; node != null; node = node.Parent)
		{
			NamespaceTree.TypeInfoCache value = node.Value;
			if (value is NamespaceTree.TypeInfoCache.No)
			{
				node.Value = NamespaceTree.TypeInfoCache.NamespaceReference._N_constant_object;
			}
		}
		namespace_nodes.Add(namespc, node2);
		return node2;
	}

	internal Nemerle.Builtins.Tuple<NamespaceTree.Node, list<string>> framework_nesting(Type t)
	{
		_N_closureOf_framework_nesting_56071 n_closureOf_framework_nesting_ = new _N_closureOf_framework_nesting_56071();
		n_closureOf_framework_nesting_._N__N_closurised_this_ptr_56076 = this;
		if (!IsAssemblyLoaded(t.Assembly.FullName))
		{
			AddAssembly(t.Assembly, isUserReference: false);
			LoadLibrariesContents();
		}
		Nemerle.Builtins.Tuple<NamespaceTree.Node, list<string>> result;
		if (t.IsPointer)
		{
			string text = "";
			Type type = t;
			while (type.IsPointer)
			{
				string text2 = text + "*";
				type = type.GetElementType();
				text = text2;
			}
			result = _N_loop_56082(n_closureOf_framework_nesting_, type, new list<string>.Cons(type.Name + text, list<string>.Nil._N_constant_object));
		}
		else
		{
			result = _N_loop_56082(n_closureOf_framework_nesting_, t, new list<string>.Cons(Util.StripGenericMark(t.Name), list<string>.Nil._N_constant_object));
		}
		return result;
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
		if (_info.VisitedObjects.ContainsKey(this))
		{
			return;
		}
		_info.VisitedObjects[this] = 0;
		list<NamespaceTree.Node> construct_right_away = _construct_right_away;
		if (construct_right_away != null)
		{
			list<NamespaceTree.Node> list = construct_right_away;
			while (list is list<NamespaceTree.Node>.Cons)
			{
				NamespaceTree.Node hd = ((list<NamespaceTree.Node>.Cons)list).hd;
				list<NamespaceTree.Node> list2 = ((list<NamespaceTree.Node>.Cons)list).tl;
				NamespaceTree.Node node = hd;
				((ISupportRelocation)node).RelocateImpl(_info);
				list = list2;
			}
		}
		List<LibraryReference> referencedAssemblies = ReferencedAssemblies;
		if (referencedAssemblies != null)
		{
			foreach (LibraryReference item in referencedAssemblies)
			{
				LibraryReference libraryReference = item;
				((ISupportRelocation)libraryReference).RelocateImpl(_info);
			}
		}
		NameTree?.RelocateImplInternal(_info);
	}

	void ISupportRelocation.RelocateImpl(RelocationInfo _info)
	{
		//ILSpy generated this explicit interface implementation from .override directive in RelocateImplInternal
		this.RelocateImplInternal(_info);
	}

	private string _N_assembly_dir_54557(_N_closureOf__ctor_54546 _N__ctor_cp_54556, Type t)
	{
		return DirectoryOfCodebase(getAssemblyLocation(t.Assembly));
	}

	private Assembly _N_assembly_by_name_55470(_N_closureOf_LookupAssembly_55462 _N_LookupAssembly_cp_55469, string path)
	{
		try
		{
			string extension = Path.GetExtension(path);
			string text = extension.ToLower();
			string path2 = ((!(text == ".dll") && !(text == ".exe")) ? (path + ".dll") : path);
			return (!File.Exists(path2)) ? null : assemblyLoadFrom(path2);
		}
		catch (FileNotFoundException)
		{
			return null;
		}
		catch (ArgumentException)
		{
			return null;
		}
	}

	private static string _N_getAssemblyPath_55547(Type type)
	{
		return new Uri(type.Assembly.CodeBase).LocalPath;
	}

	private static bool _N__N_lambda__55817_55841(IMethod _N__55816)
	{
		return _N__55816 is MethodBuilder;
	}

	private static bool _N__N_lambda__55823_55849(IMethod _N__55822)
	{
		return _N__55822 is MethodBuilder;
	}

	private Nemerle.Builtins.Tuple<NamespaceTree.Node, list<string>> _N_loop_56082(_N_closureOf_framework_nesting_56071 _N_framework_nesting_cp_56081, Type t, list<string> acc)
	{
		while (true)
		{
			Type declaringType = t.DeclaringType;
			if (!(declaringType != null))
			{
				break;
			}
			acc = new list<string>.Cons(Util.StripGenericMark(declaringType.Name), acc);
			t = declaringType;
		}
		string text = ((!(t.Namespace != null)) ? "" : t.Namespace);
		option<NamespaceTree.Node> option = namespace_nodes.Get(text);
		Nemerle.Builtins.Tuple<NamespaceTree.Node, list<string>> result;
		if (option is option<NamespaceTree.Node>.Some)
		{
			NamespaceTree.Node val = ((option<NamespaceTree.Node>.Some)option).val;
			result = new Nemerle.Builtins.Tuple<NamespaceTree.Node, list<string>>(val, acc);
		}
		else
		{
			if (option != option<NamespaceTree.Node>.None._N_constant_object)
			{
				throw new MatchFailureException();
			}
			result = new Nemerle.Builtins.Tuple<NamespaceTree.Node, list<string>>(cache_namespace_node(text), acc);
		}
		return result;
	}
}
