using System.Runtime.CompilerServices;
using Nemerle.Compiler.Parsetree;
using Nemerle.Core;

namespace Nemerle.Compiler;

public class ScanTypeHierarchy : ISupportRelocation
{
	private sealed class _N_closureOf_ProcessDeclaration_86934
	{
		internal TopDeclaration _N_decl_86941;

		internal ScanTypeHierarchy _N__N_closurised_this_ptr_86939;

		internal _N_closureOf_ProcessDeclaration_86934()
		{
		}
	}

	public readonly ManagerClass Manager;

	public InternalTypeClass InternalType => Manager.InternalType;

	public SystemTypeClass SystemTypeCache => Manager.SystemTypeCache;

	public ScanTypeHierarchy(ManagerClass man)
	{
		Manager = man;
	}

	public void ProcessDeclaration(TopDeclaration decl)
	{
		_N_closureOf_ProcessDeclaration_86934 n_closureOf_ProcessDeclaration_ = new _N_closureOf_ProcessDeclaration_86934();
		n_closureOf_ProcessDeclaration_._N_decl_86941 = decl;
		n_closureOf_ProcessDeclaration_._N__N_closurised_this_ptr_86939 = this;
		_N_handle_type_86944(n_closureOf_ProcessDeclaration_, null, n_closureOf_ProcessDeclaration_._N_decl_86941.PName.context.CurrentNamespace, n_closureOf_ProcessDeclaration_._N_decl_86941);
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
	}

	void ISupportRelocation.RelocateImpl(RelocationInfo _info)
	{
		//ILSpy generated this explicit interface implementation from .override directive in RelocateImplInternal
		this.RelocateImplInternal(_info);
	}

	private void _N_handle_type_86944(_N_closureOf_ProcessDeclaration_86934 _N_ProcessDeclaration_cp_86943, TypeBuilder parent, NamespaceTree.Node ns_node, TopDeclaration t)
	{
		if (t is TopDeclaration.Macro)
		{
			if (parent != null)
			{
				Message.Error(_N_ProcessDeclaration_cp_86943._N_decl_86941.Location, "macro declarations are allowed only at top level, move it outside the class definition");
			}
			MacroClasses.GenerateMacroClass(Manager, (TopDeclaration.Macro)t, ns_node);
			return;
		}
		TypeBuilder typeBuilder;
		if (t is TopDeclaration.Delegate)
		{
			TopDeclaration.Delegate @delegate = (TopDeclaration.Delegate)t;
			PFunHeader header = ((TopDeclaration.Delegate)t).header;
			option<GlobalEnv> option = @delegate.TryGetEnv();
			if (option is option<GlobalEnv>.Some)
			{
				GlobalEnv val = ((option<GlobalEnv>.Some)option).val;
				typeBuilder = Delegates.GenerateDelegateClass(val, parent, @delegate.modifiers, @delegate.ReturnValueModifiers, header);
			}
			return;
		}
		typeBuilder = Manager.NameTree.AddType(parent, ns_node, t);
		NamespaceTree.Node namespaceNode = typeBuilder.NamespaceNode;
		string m;
		list<ClassMember> list;
		if (t is TopDeclaration.Class)
		{
			list = ((TopDeclaration.Class)t).decls;
			m = "variant option can appear only in variant type declaration";
			goto IL_0206;
		}
		if (!(t is TopDeclaration.Alias))
		{
			if (t is TopDeclaration.Interface)
			{
				list = ((TopDeclaration.Interface)t).methods;
				m = "variant option can appear only in variant type declaration";
				goto IL_0206;
			}
			if (t is TopDeclaration.Variant)
			{
				list = ((TopDeclaration.Variant)t).decls;
				list = list;
				while (list is list<ClassMember>.Cons)
				{
					ClassMember hd = ((list<ClassMember>.Cons)list).hd;
					list = ((list<ClassMember>.Cons)list).tl;
					if (hd is ClassMember.TypeDeclaration)
					{
						TopDeclaration td = ((ClassMember.TypeDeclaration)hd).td;
						_N_handle_type_86944(_N_ProcessDeclaration_cp_86943, typeBuilder, namespaceNode, td);
					}
					else if (hd is ClassMember.EnumOption)
					{
						Message.Error(hd.Location, "variant options cannot have value, they are not enums");
					}
					list = list;
				}
			}
			else
			{
				if (t is TopDeclaration.VariantOption)
				{
					list = ((TopDeclaration.VariantOption)t).decls;
					m = "multi-level variants are not supported";
					goto IL_0206;
				}
				if (!(t is TopDeclaration.Enum))
				{
					throw new AssertionException("ncc\\hierarchy\\ScanTypeHierarchy.n", 106, "", "");
				}
			}
		}
		goto IL_02d5;
		IL_02d5:
		typeBuilder.ReverseChildren();
		return;
		IL_0206:
		for (list = list; list is list<ClassMember>.Cons; list = list)
		{
			ClassMember hd = ((list<ClassMember>.Cons)list).hd;
			list = ((list<ClassMember>.Cons)list).tl;
			if (!(hd is ClassMember.EnumOption))
			{
				if (!(hd is ClassMember.TypeDeclaration))
				{
					continue;
				}
				if (!(((ClassMember.TypeDeclaration)hd).td is TopDeclaration.VariantOption))
				{
					TopDeclaration td = ((ClassMember.TypeDeclaration)hd).td;
					_N_handle_type_86944(_N_ProcessDeclaration_cp_86943, typeBuilder, namespaceNode, td);
					continue;
				}
			}
			Message.Error(hd.Location, m);
		}
		goto IL_02d5;
	}
}
