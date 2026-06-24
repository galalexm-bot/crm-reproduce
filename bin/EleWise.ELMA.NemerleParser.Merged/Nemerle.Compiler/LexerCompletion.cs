namespace Nemerle.Compiler;

public class LexerCompletion : LexerString
{
	private sealed class _N_closureOf_GetToken_34569
	{
		internal LexerCompletion _N__N_closurised_this_ptr_34574;

		internal _N_closureOf_GetToken_34569()
		{
		}
	}

	protected int CompletionMarkLine;

	protected int CompletionMarkChar;

	public LexerCompletion(ManagerClass manager, string code, Location loc, int completionMarkLine, int completionMarkChar)
		: base(manager, code, loc)
	{
		CompletionMarkLine = completionMarkLine;
		CompletionMarkChar = completionMarkChar;
	}

	public override Token GetToken()
	{
		_N_closureOf_GetToken_34569 n_closureOf_GetToken_ = new _N_closureOf_GetToken_34569();
		n_closureOf_GetToken_._N__N_closurised_this_ptr_34574 = this;
		Token token = base.GetToken();
		Location location = token.Location;
		object result;
		if (location.Contains(CompletionMarkLine, CompletionMarkChar))
		{
			if (token is Token.Identifier)
			{
				string name = ((Token.Identifier)token).name;
				_N_resetCompletionMark_34577(n_closureOf_GetToken_);
				result = new Token.IdentifierToComplete(token.Location, name);
			}
			else if (token is Token.Keyword)
			{
				_N_resetCompletionMark_34577(n_closureOf_GetToken_);
				result = new Token.IdentifierToComplete(token.Location, token.ToString());
			}
			else if (token is Token.Operator)
			{
				location = new Location(file_idx, CompletionMarkLine, CompletionMarkChar);
				_N_resetCompletionMark_34577(n_closureOf_GetToken_);
				tok_pending = new Token.IdentifierToComplete(location, "");
				result = token;
			}
			else if (token is Token.StringLiteral)
			{
				result = token;
			}
			else
			{
				location = new Location(file_idx, CompletionMarkLine, CompletionMarkChar);
				_N_resetCompletionMark_34577(n_closureOf_GetToken_);
				tok_pending = token;
				result = new Token.IdentifierToComplete(location, "");
			}
		}
		else if (CompletionMarkLine >= 0 && (location.Line > CompletionMarkLine || (location.Line == CompletionMarkLine && location.Column > CompletionMarkChar)))
		{
			_N_resetCompletionMark_34577(n_closureOf_GetToken_);
			tok_pending = token;
			result = new Token.IdentifierToComplete("");
		}
		else
		{
			result = token;
		}
		return (Token)result;
	}

	private void _N_resetCompletionMark_34577(_N_closureOf_GetToken_34569 _N_GetToken_cp_34576)
	{
		CompletionMarkLine = -1;
		CompletionMarkChar = -1;
	}
}
