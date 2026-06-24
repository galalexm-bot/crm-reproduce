using System.Runtime.CompilerServices;

namespace Nemerle.Compiler.Parsetree;

public class Function_decl : ParsedBase
{
	public readonly PFunHeader header;

	public PExpr body;

	public Function_decl(PFunHeader header, PExpr body)
	{
		Location location = default(Location);
		if (header != null)
		{
			location = header.Location;
		}
		if (body != null)
		{
			location += body.Location;
		}
		this._002Ector(location, header, body);
	}

	public Function_decl(Location location, PFunHeader header, PExpr body)
		: base(location)
	{
		this.header = header;
		this.body = body;
	}

	[CompilerGenerated]
	internal override void RelocateImplInternal(RelocationInfo _info)
	{
		if (!_info.VisitedObjects.ContainsKey(this))
		{
			base.RelocateImplInternal(_info);
			_info.VisitedObjects[this] = 0;
			body?.RelocateImplInternal(_info);
			header?.RelocateImplInternal(_info);
		}
	}
}
