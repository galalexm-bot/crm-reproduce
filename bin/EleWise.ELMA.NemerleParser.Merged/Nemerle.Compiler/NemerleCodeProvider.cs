using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Nemerle.Compiler;

public class NemerleCodeProvider : CodeDomProvider, ISupportRelocation
{
	public override string FileExtension => "n";

	[Obsolete("do not use CreateCompiler directly")]
	public override ICodeCompiler CreateCompiler()
	{
		return new NemerleCodeCompiler();
	}

	[Obsolete("do not use CreateGenerator directly")]
	public override ICodeGenerator CreateGenerator()
	{
		return new NemerleCodeGenerator();
	}

	public override TypeConverter GetConverter(Type ty)
	{
		return (!typeof(MemberAttributes).Equals(ty)) ? base.GetConverter(ty) : NemerleMemberAttributeConverter.Default;
	}

	[CompilerGenerated]
	internal override void RelocateImplInternal(RelocationInfo _info)
	{
	}

	void ISupportRelocation.RelocateImpl(RelocationInfo _info)
	{
		//ILSpy generated this explicit interface implementation from .override directive in RelocateImplInternal
		this.RelocateImplInternal(_info);
	}
}
