using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Nemerle.Builtins;

namespace Nemerle.Compiler;

public class LexerString : LexerStringBase
{
	private sealed class _N_closureOf_try_read_comment_34484
	{
		internal Location _N_startLocation_34491;

		internal LexerString _N__N_closurised_this_ptr_34489;

		internal _N_closureOf_try_read_comment_34484()
		{
		}
	}

	protected Location comment_loc;

	protected StringBuilder currentComment = new StringBuilder();

	public List<Tuple<Location, string, bool>> CommentLocations = new List<Tuple<Location, string, bool>>();

	public LexerString(ManagerClass manager, string code, Location loc)
		: base(manager, code, loc)
	{
	}

	protected override bool try_read_comment()
	{
		_N_closureOf_try_read_comment_34484 n_closureOf_try_read_comment_ = new _N_closureOf_try_read_comment_34484();
		n_closureOf_try_read_comment_._N__N_closurised_this_ptr_34489 = this;
		n_closureOf_try_read_comment_._N_startLocation_34491 = Location;
		int result;
		checked
		{
			switch (peek_or_white())
			{
			case '/':
			{
				int position2 = get_position() - 1;
				try
				{
					read();
					int num = col - 2;
					if (num == 0)
					{
						num = 1;
					}
					Location field = new Location(file_idx, line, num);
					char c = ' ';
					int num2 = 0;
					int num3 = 0;
					do
					{
						num2 = line;
						num3 = col;
						c = read_or_eol();
						if (white_beginning)
						{
							currentComment.Append(c);
						}
					}
					while (!LexerBase.IsEndOfLine(c));
					if (white_beginning)
					{
						if (CommentLocations.Count > 0)
						{
							Tuple<Location, string, bool> tuple = CommentLocations[CommentLocations.Count - 1];
							bool field2 = tuple.Field2;
							Location field3 = tuple.Field0;
							int endLine = field3.EndLine;
							if (field2 && num2 - endLine == 1)
							{
								Location field4 = new Location(file_idx, field3.Line, field3.Column, num2, num3);
								CommentLocations[CommentLocations.Count - 1] = new Tuple<Location, string, bool>(field4, tuple.Field1, field2: true);
							}
							else
							{
								CommentLocations.Add(new Tuple<Location, string, bool>(field, currentComment.ToString(), field2: true));
							}
						}
						else
						{
							CommentLocations.Add(new Tuple<Location, string, bool>(field, currentComment.ToString(), field2: true));
						}
					}
					currentComment.Length = 0;
				}
				catch (Error)
				{
					white_beginning = true;
				}
				white_beginning = true;
				register_comment(position2, isMultiline: false, isDocument: false);
				result = 1;
				break;
			}
			case '*':
			{
				int position = get_position() - 1;
				white_beginning = false;
				read();
				currentComment.Length = 0;
				comment_loc = new Location(file_idx, line, col - 2);
				if (Manager.Options.LexerStoreComments && peek_or_white() == '*')
				{
					read();
					_N_loop1_34522(n_closureOf_try_read_comment_, seen_star: true, store: true);
				}
				else
				{
					_N_loop1_34522(n_closureOf_try_read_comment_, seen_star: false, store: false);
				}
				white_beginning = false;
				register_comment(position, isMultiline: true, isDocument: false);
				result = 1;
				break;
			}
			default:
				white_beginning = false;
				result = 0;
				break;
			}
		}
		return (byte)result != 0;
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

	private void _N_loop1_34522(_N_closureOf_try_read_comment_34484 _N_try_read_comment_cp_34521, bool seen_star, bool store)
	{
		while (true)
		{
			char c = read();
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
					Location field = new Location(file_idx, comment_loc.Line, comment_loc.Column, line, col);
					CommentLocations.Add(new Tuple<Location, string, bool>(field, currentComment.ToString(), field2: false));
					currentComment.Length = 0;
					return;
				}
				c = c;
			}
			else
			{
				if (c == '\0')
				{
					break;
				}
				c = c;
			}
			StringBuilder stringBuilder = currentComment.Append(c);
			store = store;
			seen_star = false;
		}
		Message.Error(_N_try_read_comment_cp_34521._N_startLocation_34491, "End-of-file found, '*/' expected!");
	}
}
