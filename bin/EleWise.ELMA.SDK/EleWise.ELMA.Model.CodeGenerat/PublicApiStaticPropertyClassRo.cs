using System.Collections.Generic;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.CodeGeneration.PublicApi;

public class PublicApiStaticPropertyClassRootNode : IPublicApiNode
{
	protected readonly string className;

	protected readonly string propertyName;

	protected readonly string fieldName;

	protected readonly bool @sealed;

	protected const string ParentPath = "PublicAPI";

	internal static PublicApiStaticPropertyClassRootNode nsy6DihAzcCNDb3S8VUL;

	string IPublicApiNode.ParentPath => z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837890197);

	public string Path => (string)pWWGSyh7bKgpfleFRual(z8Md7sh7o7l59kHmdoPJ(0xE1229CF ^ 0xE11AA93), propertyName);

	public virtual string Description
	{
		[CompilerGenerated]
		get
		{
			return _003CDescription_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003CDescription_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public virtual string Remarks
	{
		[CompilerGenerated]
		get
		{
			return _003CRemarks_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003CRemarks_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public virtual string Code
	{
		[CompilerGenerated]
		get
		{
			return _003CCode_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003CCode_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	protected PublicApiStaticPropertyClassRootNode(string className, string propertyName, bool @sealed = true)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		K48aHlh7W9gmnQOn92PO();
		base._002Ector();
		int num = 3;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
		{
			num = 3;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				this.@sealed = @sealed;
				num = 4;
				break;
			case 3:
				this.className = className;
				num = 2;
				break;
			default:
				fieldName = (string)pWWGSyh7bKgpfleFRual(z8Md7sh7o7l59kHmdoPJ(0x20261A4F ^ 0x202598ED), propertyName);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
				{
					num = 1;
				}
				break;
			case 4:
				return;
			case 2:
				this.propertyName = propertyName;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	[IteratorStateMachine(typeof(_003CGenerate_003Ed__22))]
	public IEnumerable<ISyntaxNode> Generate(IDictionary<string, IEnumerable<IPublicApiNode>> tree)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CGenerate_003Ed__22(-2)
		{
			_003C_003E4__this = this,
			_003C_003E3__tree = tree
		};
	}

	internal static void K48aHlh7W9gmnQOn92PO()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object z8Md7sh7o7l59kHmdoPJ(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object pWWGSyh7bKgpfleFRual(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static bool tZOyv2h7FXVGcdK41mpH()
	{
		return nsy6DihAzcCNDb3S8VUL == null;
	}

	internal static PublicApiStaticPropertyClassRootNode vFfw1Yh7BXsnnOJn1Y05()
	{
		return nsy6DihAzcCNDb3S8VUL;
	}
}
