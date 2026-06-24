using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.CodeGeneration.CSharp.Enums;

namespace EleWise.ELMA.CodeGeneration.CSharp.Nodes;

public class PropertyDeclarationSyntax : InterfaceMemberSyntax
{
	private readonly Accessibility getterAccessibility;

	private readonly Accessibility setterAccessibility;

	private readonly StatementSyntax[] getAccessorStatements;

	private readonly StatementSyntax[] setAccessorStatements;

	public bool HasGetter
	{
		get
		{
			if (getAccessorStatements == null)
			{
				return setAccessorStatements == null;
			}
			return true;
		}
	}

	public bool HasSetter
	{
		get
		{
			if (setAccessorStatements == null)
			{
				return getAccessorStatements == null;
			}
			return true;
		}
	}

	public PropertyDeclarationSyntax(string name, TypeSyntax type, Accessibility accessibility, DeclarationModifiers modifiers, IEnumerable<StatementSyntax> getAccessorStatements, IEnumerable<StatementSyntax> setAccessorStatements, Accessibility getterAccessibility, Accessibility setterAccessibility)
		: base(name, type, accessibility, modifiers)
	{
		this.getterAccessibility = getterAccessibility;
		this.setterAccessibility = setterAccessibility;
		this.getAccessorStatements = getAccessorStatements.ToArrayOrNull();
		this.setAccessorStatements = setAccessorStatements.ToArrayOrNull();
	}

	protected override void InternalGenerate()
	{
		bool isClass = GenerationContext.Current.ParentNode is ClassDeclarationSyntax;
		bool needGetAccessor = getAccessorStatements != null;
		bool hasGetAccessor = needGetAccessor && getAccessorStatements.Length != 0;
		bool needSetAccessor = setAccessorStatements != null;
		bool hasSetAccessor = needSetAccessor && setAccessorStatements.Length != 0;
		GenerationContext.Current.Call(delegate
		{
			base.InternalGenerate();
		}).WriteLine().WriteLine("{")
			.Indentation(delegate(GenerationContext p)
			{
				p.If(!needGetAccessor && !needSetAccessor, delegate(GenerationContext __)
				{
					__.Write(getterAccessibility).WriteLine("get;").Write(setterAccessibility)
						.WriteLine("set;");
				}).If(isClass, delegate(GenerationContext _)
				{
					_.If(needGetAccessor, delegate(GenerationContext __)
					{
						__.Write(getterAccessibility).WriteLine("get").If(hasGetAccessor, delegate(GenerationContext ___)
						{
							___.WriteLine("{").Indentation(getAccessorStatements).WriteLine("}");
						})
							.If(!hasGetAccessor, delegate(GenerationContext ___)
							{
								___.WriteLine(";");
							});
					}).If(needSetAccessor, delegate(GenerationContext __)
					{
						__.Write(setterAccessibility).WriteLine("set").If(hasGetAccessor || hasSetAccessor, delegate(GenerationContext ___)
						{
							___.WriteLine("{").Indentation(setAccessorStatements).WriteLine("}");
						})
							.If(!hasGetAccessor && !hasSetAccessor, delegate(GenerationContext ___)
							{
								___.WriteLine(";");
							});
					});
				}).If(!isClass, delegate(GenerationContext _)
				{
					_.If(needGetAccessor, delegate(GenerationContext __)
					{
						__.Write(getterAccessibility).WriteLine("get;");
					}).If(needSetAccessor, delegate(GenerationContext __)
					{
						__.Write(setterAccessibility).WriteLine("set;");
					});
				});
			})
			.WriteLine("}");
	}
}
