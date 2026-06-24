using System.Runtime.CompilerServices;
using System.Text;

namespace Nemerle.Compiler;

public class LexerFile : LexerStringBase
{
	private sealed class _N_closureOf_try_read_comment_34362
	{
		internal Location _N_startLocation_34369;

		internal LexerFile _N__N_closurised_this_ptr_34367;

		internal _N_closureOf_try_read_comment_34362()
		{
		}
	}

	private Location comment_loc;

	private StringBuilder currentComment = new StringBuilder();

	private readonly bool storeComments;

	public LexerFile(ManagerClass manager, int fileIndex, string code, bool storeComments)
		: base(manager, code, new Location(fileIndex, 1, 1))
	{
		this.storeComments = storeComments;
	}

	protected override bool try_read_comment()
	{
		_N_closureOf_try_read_comment_34362 n_closureOf_try_read_comment_ = new _N_closureOf_try_read_comment_34362();
		n_closureOf_try_read_comment_._N__N_closurised_this_ptr_34367 = this;
		n_closureOf_try_read_comment_._N_startLocation_34369 = Location;
		int result;
		checked
		{
			switch (peek_or_white())
			{
			case '/':
			{
				int position2 = get_position() - 1;
				bool flag2 = false;
				read();
				try
				{
					flag2 = peek() == '/';
					if (flag2 && storeComments)
					{
						comment_loc = new Location(file_idx, line, col - 2);
						read();
						char c = ' ';
						do
						{
							c = read_or_eol();
							currentComment.Append(c);
						}
						while (c != '\n');
						comment_loc += new Location(file_idx, line, col);
					}
					else
					{
						while (!LexerBase.IsEndOfLine(read_or_eol()))
						{
						}
					}
				}
				catch (Error)
				{
				}
				white_beginning = true;
				register_comment(position2, isMultiline: false, flag2);
				result = 1;
				break;
			}
			case '*':
			{
				int position = get_position() - 1;
				bool flag = false;
				read();
				flag = peek_or_white() == '*';
				if (flag && storeComments)
				{
					comment_loc = new Location(file_idx, line, col - 2);
					read();
					_N_loop1_34392(n_closureOf_try_read_comment_, seen_star: true, store: true);
					if (currentComment.Length == 1)
					{
						currentComment.Remove(0, 1);
					}
					else
					{
						currentComment.Remove(currentComment.Length - 2, 2);
					}
					comment_loc += new Location(file_idx, line, col);
				}
				else
				{
					_N_loop1_34392(n_closureOf_try_read_comment_, seen_star: false, store: false);
				}
				register_comment(position, isMultiline: true, flag);
				result = 1;
				break;
			}
			default:
				result = 0;
				break;
			}
		}
		return (byte)result != 0;
	}

	protected override void ignore_comments()
	{
		if (currentComment.Length > 0)
		{
			Message.Warning(Location, "documentation comments between literals are ignored");
			currentComment.Length = 0;
		}
	}

	public override Token GetToken()
	{
		if (!isPendingChar)
		{
			bool flag = eat_whitespace();
		}
		object result;
		if (currentComment.Length > 0)
		{
			Token.Comment comment = new Token.Comment(currentComment.ToString());
			comment.Location = comment_loc;
			currentComment.Length = 0;
			result = comment;
		}
		else
		{
			result = base.GetToken();
		}
		return (Token)result;
	}

	[CompilerGenerated]
	internal override void RelocateImplInternal(RelocationInfo _info)
	{
		if (!_info.VisitedObjects.ContainsKey(this))
		{
			base.RelocateImplInternal(_info);
			_info.VisitedObjects[this] = 0;
			comment_loc = Completion.Relocate(comment_loc, _info);
		}
	}

	private void _N_loop1_34392(_N_closureOf_try_read_comment_34362 _N_try_read_comment_cp_34391, bool seen_star, bool store)
	{
		while (true)
		{
			char c = read();
			if (store)
			{
				StringBuilder stringBuilder = currentComment.Append(c);
			}
			if (c == '*')
			{
				store = store;
				seen_star = true;
				continue;
			}
			if (c == '/')
			{
				if (seen_star)
				{
					return;
				}
			}
			else if (c == '\0')
			{
				break;
			}
			store = store;
			seen_star = false;
		}
		Message.Error(_N_try_read_comment_cp_34391._N_startLocation_34369, "End-of-file found, '*/' expected!");
	}
}
