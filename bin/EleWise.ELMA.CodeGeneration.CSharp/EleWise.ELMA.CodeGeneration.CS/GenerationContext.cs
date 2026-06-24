using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using EleWise.ELMA.CodeGeneration.CSharp.Enums;
using EleWise.ELMA.CodeGeneration.CSharp.Extensions;
using EleWise.ELMA.CodeGeneration.CSharp.Nodes;
using EleWise.ELMA.CodeGeneration.CSharp.Trivias;

namespace EleWise.ELMA.CodeGeneration.CSharp;

public class GenerationContext : IDisposable
{
	[ThreadStatic]
	private static GenerationContext _current;

	private readonly GenerationContext _oldContext;

	private readonly TextWriter _writer;

	private readonly Stack<SyntaxNode> _generationStack;

	private SyntaxNode _parentNodeCache;

	private readonly string _indentation;

	private string _currentIndentation;

	private bool _needIndentation;

	public static GenerationContext Current => _current;

	public SyntaxNode ParentNode => _parentNodeCache ?? (_parentNodeCache = _generationStack.Skip(1).FirstOrDefault());

	internal GenerationContext(TextWriter writer, string indentation)
	{
		_oldContext = _current;
		_writer = writer;
		_indentation = indentation;
		_currentIndentation = "";
		_generationStack = new Stack<SyntaxNode>();
		_current = this;
	}

	public void Dispose()
	{
		_current = _oldContext;
	}

	public GenerationContext If(bool condition, Action<GenerationContext> action)
	{
		if (condition)
		{
			action(this);
		}
		return this;
	}

	public GenerationContext Call(Action action)
	{
		action();
		return this;
	}

	private void InternalWrite(string value)
	{
		if (_needIndentation)
		{
			_writer.Write(_currentIndentation);
		}
		_writer.Write(value);
		_needIndentation = false;
	}

	public GenerationContext Write(string value, bool ignoreIndentation = false)
	{
		if (ignoreIndentation)
		{
			_needIndentation = false;
		}
		InternalWrite(value);
		return this;
	}

	public GenerationContext WriteLine()
	{
		_writer.WriteLine();
		_needIndentation = true;
		return this;
	}

	public GenerationContext WriteLine(string value, bool ignoreIndentation = false)
	{
		if (ignoreIndentation)
		{
			_needIndentation = false;
		}
		InternalWrite(value);
		return WriteLine();
	}

	public GenerationContext WriteComaSeparated(IEnumerable<string> values)
	{
		return Write(string.Join(", ", values));
	}

	public GenerationContext Write(SyntaxNode node)
	{
		SyntaxNode parentNodeCache = _parentNodeCache;
		_parentNodeCache = null;
		_generationStack.Push(node);
		node.Generate();
		_parentNodeCache = parentNodeCache;
		_generationStack.Pop();
		return this;
	}

	public GenerationContext Write(IEnumerable<SyntaxNode> nodes, Action<GenerationContext> separatorAction = null)
	{
		bool flag = true;
		foreach (SyntaxNode node in nodes)
		{
			if (!flag)
			{
				separatorAction?.Invoke(this);
			}
			Write(node);
			flag = false;
		}
		return this;
	}

	public GenerationContext WriteComaSeparated(IEnumerable<SyntaxNode> nodes)
	{
		return Write(nodes, delegate(GenerationContext _)
		{
			_.Write(", ");
		});
	}

	public GenerationContext WriteNewLineComaSeparated(IEnumerable<SyntaxNode> nodes)
	{
		return Write(nodes, delegate(GenerationContext _)
		{
			_.WriteLine(", ");
		});
	}

	public GenerationContext WriteNewLineSeparated(IEnumerable<SyntaxNode> nodes)
	{
		return Write(nodes, delegate(GenerationContext _)
		{
			_.WriteLine();
		});
	}

	public GenerationContext Indentation(Action<GenerationContext> indentationAction)
	{
		string currentIndentation = _currentIndentation;
		try
		{
			_currentIndentation += _indentation;
			indentationAction(this);
		}
		finally
		{
			_currentIndentation = currentIndentation;
		}
		return this;
	}

	public GenerationContext Indentation(IEnumerable<SyntaxNode> nodes)
	{
		return Indentation(delegate(GenerationContext _)
		{
			_.Write(nodes);
		});
	}

	public GenerationContext Write(IEnumerable<SyntaxTrivia> trivias)
	{
		foreach (SyntaxTrivia trivia in trivias)
		{
			trivia.Generate();
		}
		return this;
	}

	internal GenerationContext Write(ExpressionSyntaxPriority priority)
	{
		priority.Generate();
		return this;
	}

	internal GenerationContext Write(RefKind refKind)
	{
		refKind.Generate();
		return this;
	}

	internal GenerationContext Write(Accessibility accessibility)
	{
		accessibility.Generate();
		return this;
	}

	internal GenerationContext Write(DeclarationModifiers modifiers)
	{
		modifiers.Generate();
		return this;
	}
}
