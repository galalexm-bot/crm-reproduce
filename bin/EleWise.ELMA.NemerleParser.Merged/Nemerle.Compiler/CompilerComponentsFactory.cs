using System;
using System.Runtime.CompilerServices;
using Nemerle.Compiler.Parsetree;
using Nemerle.Compiler.Typedtree;
using Nemerle.Core;
using Nemerle.Internal;

namespace Nemerle.Compiler;

public class CompilerComponentsFactory : ISupportRelocation
{
	[CompilerGenerated]
	internal override void RelocateImplInternal(RelocationInfo _info)
	{
	}

	void ISupportRelocation.RelocateImpl(RelocationInfo _info)
	{
		//ILSpy generated this explicit interface implementation from .override directive in RelocateImplInternal
		this.RelocateImplInternal(_info);
	}

	public override MethodBuilder CreateMethodBuilder(TypeBuilder par, ClassMember.Function functionAst, bool is_property)
	{
		return new MethodBuilder(par, functionAst, is_property);
	}

	public override MethodBuilder CreateMethodBuilder(TypeBuilder par, ClassMember.Function functionAst)
	{
		return new MethodBuilder(par, functionAst);
	}

	public override Typer CreateTyper(Typer parent, TFunHeader fn)
	{
		return new Typer(parent, fn);
	}

	public override Typer CreateTyper(GlobalEnv env, TypeBuilder tb)
	{
		return new Typer(env, tb);
	}

	public override Typer CreateTyper(GlobalEnv env)
	{
		return new Typer(env);
	}

	public override Typer CreateTyper(TypeBuilder tb, TypeVarEnv tenv, MethodBuilder mb, GlobalEnv env)
	{
		return new Typer(tb, tenv, mb, env);
	}

	public override Typer CreateTyper(MethodBuilder m)
	{
		return new Typer(m);
	}

	public override LibraryReferenceManager CreateLibraryReferenceManager(ManagerClass man, [Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] list<string> lib_paths)
	{
		if ((object)lib_paths == null)
		{
			throw new ArgumentNullException("lib_paths", "The ``NotNull'' contract of parameter ``lib_paths'' has been violated. See ncc\\external\\LibraryReferenceManager.n:62:48:62:57: .");
		}
		return new LibraryReferenceManager(man, lib_paths);
	}
}
