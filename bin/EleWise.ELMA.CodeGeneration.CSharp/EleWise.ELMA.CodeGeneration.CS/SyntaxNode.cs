using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.CodeGeneration.CSharp.Enums;
using EleWise.ELMA.CodeGeneration.CSharp.Extensions;
using EleWise.ELMA.CodeGeneration.CSharp.Trivias;

namespace EleWise.ELMA.CodeGeneration.CSharp.Nodes;

public abstract class SyntaxNode
{
	private List<SyntaxTrivia> _leadingTrivias;

	private List<SyntaxTrivia> _trailingTrivias;

	private List<AttributeSyntax> _attributes;

	private List<Tuple<string, SyntaxNode[]>> _typeConstraints;

	public SyntaxNode WithLeadingTrivia(IEnumerable<SyntaxTrivia> trivias)
	{
		_leadingTrivias = trivias.ToList();
		return this;
	}

	public SyntaxNode AddLeadingTrivia(IEnumerable<SyntaxTrivia> trivias)
	{
		if (_leadingTrivias == null)
		{
			_leadingTrivias = trivias.ToList();
		}
		else
		{
			_leadingTrivias.AddRange(trivias);
		}
		return this;
	}

	public SyntaxNode WithTrailingTrivia(IEnumerable<SyntaxTrivia> trivias)
	{
		_trailingTrivias = trivias.ToList();
		return this;
	}

	public SyntaxNode AddTrailingTrivia(IEnumerable<SyntaxTrivia> trivias)
	{
		if (_trailingTrivias == null)
		{
			_trailingTrivias = trivias.ToList();
		}
		else
		{
			_trailingTrivias.AddRange(trivias);
		}
		return this;
	}

	public SyntaxNode WithAttributes(IEnumerable<AttributeSyntax> attributes)
	{
		_attributes = attributes.ToList();
		return this;
	}

	public SyntaxNode AddAttributes(IEnumerable<AttributeSyntax> attributes)
	{
		if (_attributes == null)
		{
			_attributes = attributes.ToList();
		}
		else
		{
			_attributes.AddRange(attributes);
		}
		return this;
	}

	public SyntaxNode WithTypeConstraint(string typeParameterName, SpecialTypeConstraintKind kinds, IEnumerable<TypeSyntax> types)
	{
		if (_typeConstraints == null)
		{
			_typeConstraints = new List<Tuple<string, SyntaxNode[]>>();
		}
		_typeConstraints.Add(new Tuple<string, SyntaxNode[]>(typeParameterName, (types ?? Enumerable.Empty<TypeSyntax>()).Concat(kinds.Generate()).ToArray()));
		return this;
	}

	internal void GenerateLeading()
	{
		if (_leadingTrivias != null)
		{
			GenerationContext.Current.Write(_leadingTrivias);
		}
		if (_attributes != null)
		{
			_attributes.ForEach(delegate(AttributeSyntax a)
			{
				a.Generate(AttributeEol);
			});
		}
	}

	protected virtual void AttributeEol()
	{
		GenerationContext.Current.WriteLine();
	}

	internal void GenerateTrailing()
	{
		if (_trailingTrivias != null)
		{
			GenerationContext.Current.Write(_trailingTrivias);
		}
	}

	internal void GenerateTypeConstraints()
	{
		if (_typeConstraints == null)
		{
			return;
		}
		_typeConstraints.ForEach(delegate(Tuple<string, SyntaxNode[]> tc)
		{
			GenerationContext.Current.Indentation(delegate(GenerationContext _)
			{
				_.WriteLine().Write("where ").Write(tc.Item1)
					.Write(" : ")
					.WriteComaSeparated(tc.Item2);
			});
		});
	}

	internal abstract void Generate();

	public override string ToString()
	{
		return SyntaxGenerator.GenerateInternal(new SyntaxNode[1] { this }, "", " ");
	}
}
