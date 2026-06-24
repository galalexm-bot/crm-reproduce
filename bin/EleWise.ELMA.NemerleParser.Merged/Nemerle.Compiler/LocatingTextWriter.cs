using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using Nemerle.Internal;

namespace Nemerle.Compiler;

internal class LocatingTextWriter : LocatableTextWriter
{
	private Location loc;

	public override Location Loc
	{
		[CompilerGenerated]
		[DebuggerStepThrough]
		get
		{
			return loc;
		}
	}

	public override void Write(string txt)
	{
		string txt2 = txt.Replace("\r\n", "\n");
		moveLoc(txt2);
		base.Write(txt2);
	}

	private void moveLoc(string txt)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		num = loc.Line;
		num2 = loc.Column;
		checked
		{
			for (num3 = 0; num3 < txt.Length; num3++)
			{
				char c = txt[num3];
				if (c == '\n')
				{
					num++;
					num2 = 1;
					continue;
				}
				if (c == '\r')
				{
					if (num3 + 1 < txt.Length && txt[num3 + 1] != '\n')
					{
						num++;
						num2 = 1;
						continue;
					}
				}
				else
				{
					switch (c)
					{
					case '\u2028':
						num++;
						num2 = 1;
						continue;
					case '\u2029':
						num++;
						num2 = 1;
						continue;
					case '\u0085':
						num++;
						num2 = 1;
						continue;
					}
				}
				num2++;
			}
			loc = new Location(loc, num, num2);
		}
	}

	public override void MoveLocation(int from_position)
	{
		if (from_position != sbuilder.Length)
		{
			moveLoc(sbuilder.ToString(from_position, checked(sbuilder.Length - from_position)));
		}
	}

	public override void FetchUpdatedLocation(Located entity, Location begin_loc)
	{
		if (entity != null && (entity.Location = begin_loc + loc).IsSourceAvailable)
		{
		}
	}

	[CompilerGenerated]
	internal override void RelocateImplInternal(RelocationInfo _info)
	{
		if (!_info.VisitedObjects.ContainsKey(this))
		{
			base.RelocateImplInternal(_info);
			_info.VisitedObjects[this] = 0;
			loc = Completion.Relocate(loc, _info);
		}
	}

	[RecordCtor]
	public LocatingTextWriter([MappedMember("sbuilder")] StringBuilder sbuilder, [MappedMember("loc")] Location loc)
		: base(sbuilder)
	{
		this.loc = loc;
	}
}
