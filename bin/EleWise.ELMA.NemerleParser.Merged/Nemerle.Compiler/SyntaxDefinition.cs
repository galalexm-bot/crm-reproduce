using System.Runtime.CompilerServices;
using Nemerle.Builtins;
using Nemerle.Compiler.Parsetree;
using Nemerle.Core;
using Nemerle.Internal;

namespace Nemerle.Compiler;

public class SyntaxDefinition : ISupportRelocation
{
	public readonly string Start;

	public readonly list<string> Keywords;

	public readonly NamespaceTree.Node MacroNamespace;

	public readonly GrammarElement Tree;

	public readonly Function<list<SyntaxElement>, list<SyntaxElement>> Permute;

	[RecordCtor]
	public SyntaxDefinition([MappedMember("Start")] string start, [MappedMember("Keywords")] list<string> keywords, [MappedMember("MacroNamespace")] NamespaceTree.Node macroNamespace, [MappedMember("Tree")] GrammarElement tree, [MappedMember("Permute")] Function<list<SyntaxElement>, list<SyntaxElement>> permute)
	{
		Start = start;
		Keywords = keywords;
		MacroNamespace = macroNamespace;
		Tree = tree;
		Permute = permute;
	}

	[CompilerGenerated]
	internal override void RelocateImplInternal(RelocationInfo _info)
	{
		if (!_info.VisitedObjects.ContainsKey(this))
		{
			_info.VisitedObjects[this] = 0;
			Tree?.RelocateImplInternal(_info);
		}
	}

	void ISupportRelocation.RelocateImpl(RelocationInfo _info)
	{
		//ILSpy generated this explicit interface implementation from .override directive in RelocateImplInternal
		this.RelocateImplInternal(_info);
	}
}
