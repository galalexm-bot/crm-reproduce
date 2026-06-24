using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using Nemerle.Builtins;
using Nemerle.Collections;
using Nemerle.Core;

namespace Nemerle.Compiler;

public sealed class DispatchingFileParser : IParser, ISupportRelocation
{
	private readonly ManagerClass manager;

	private readonly Hashtable<string, option<IParser>> registeredParsers = new Hashtable<string, option<IParser>>();

	public DispatchingFileParser(ManagerClass manager)
		: this(manager, new DefaultParser(manager))
	{
	}

	public DispatchingFileParser(ManagerClass manager, IParser defaultParser)
	{
		this.manager = manager;
		registeredParsers[NormalizeExtension("n")] = new option<IParser>.Some(defaultParser);
	}

	public void Register(Type parserType, string fileExtension)
	{
		string text = NormalizeExtension(fileExtension);
		if (registeredParsers.ContainsKey(text))
		{
			Message.Warning("parser for '$fileExtension' files already registered");
			return;
		}
		ConstructorInfo constructor = parserType.GetConstructor(new Type[1] { typeof(ManagerClass) });
		if (constructor != null)
		{
			try
			{
				IParser val = (IParser)constructor.Invoke(new object[1] { manager });
				registeredParsers[text] = new option<IParser>.Some(val);
				return;
			}
			catch (Exception ex)
			{
				Message.Warning("failed to create instance of '" + Convert.ToString(text) + "' file parser '" + Convert.ToString(parserType) + "': " + Convert.ToString(ex.Message));
				registeredParsers[text] = option<IParser>.None._N_constant_object;
				return;
			}
		}
		Message.Warning("can't find proper constructor for '" + Convert.ToString(text) + "' file parser '" + Convert.ToString(parserType) + "'");
		registeredParsers[text] = option<IParser>.None._N_constant_object;
	}

	public bool IsExtensionRegistered(string fileExtension)
	{
		return registeredParsers.ContainsKey(NormalizeExtension(fileExtension));
	}

	public ParseResult Parse(ISource source)
	{
		string fileName = Location.GetFileName(source.FileIndex);
		fileName = (string.IsNullOrEmpty(fileName) ? "" : NormalizeExtension(Path.GetExtension(fileName)));
		Nemerle.Builtins.Tuple<option<IParser>, bool> tuple = registeredParsers.TryGetValue(fileName);
		ParseResult result;
		if (!tuple.Field1)
		{
			Message.Error(new Location(source.FileIndex, 1, 1), "can't parse file with extension '" + Convert.ToString(fileName) + "', parser not registered");
			result = new ParseResult(list<Nemerle.Compiler.Parsetree.TopDeclaration>.Nil._N_constant_object);
		}
		else if (tuple.Field0 == option<IParser>.None._N_constant_object)
		{
			Message.Error(new Location(source.FileIndex, 1, 1), "can't parse file with extension '" + Convert.ToString(fileName) + "', see parser initialization warnings");
			result = new ParseResult(list<Nemerle.Compiler.Parsetree.TopDeclaration>.Nil._N_constant_object);
		}
		else
		{
			if (!(tuple.Field0 is option<IParser>.Some))
			{
				throw new MatchFailureException();
			}
			IParser val = ((option<IParser>.Some)tuple.Field0).val;
			result = val.Parse(source);
		}
		return result;
	}

	private static string NormalizeExtension(string extension)
	{
		return string.IsNullOrEmpty(extension) ? "" : ((extension[0] != '.') ? extension.ToLowerInvariant() : extension.Substring(1).ToLowerInvariant());
	}

	[CompilerGenerated]
	internal void RelocateImplInternal(RelocationInfo _info)
	{
	}

	void ISupportRelocation.RelocateImpl(RelocationInfo _info)
	{
		//ILSpy generated this explicit interface implementation from .override directive in RelocateImplInternal
		this.RelocateImplInternal(_info);
	}
}
