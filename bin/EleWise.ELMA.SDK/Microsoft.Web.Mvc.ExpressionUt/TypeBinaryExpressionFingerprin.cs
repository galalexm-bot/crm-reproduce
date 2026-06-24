using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace Microsoft.Web.Mvc.ExpressionUtil;

internal sealed class TypeBinaryExpressionFingerprint : ExpressionFingerprint
{
	internal static TypeBinaryExpressionFingerprint M3Negao0bEwOI1on8Nr;

	public Type TypeOperand
	{
		[CompilerGenerated]
		get
		{
			return _003CTypeOperand_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
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
					_003CTypeOperand_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
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

	public TypeBinaryExpressionFingerprint(ExpressionType nodeType, Type type, Type typeOperand)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		pt4PkdoMfV80IJFbekt();
		base._002Ector(nodeType, type);
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				TypeOperand = typeOperand;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public override bool Equals(object obj)
	{
		//Discarded unreachable code: IL_0077, IL_0086
		int num = 3;
		int num2 = num;
		TypeBinaryExpressionFingerprint typeBinaryExpressionFingerprint = default(TypeBinaryExpressionFingerprint);
		while (true)
		{
			switch (num2)
			{
			default:
				if (object.Equals(TypeOperand, typeBinaryExpressionFingerprint.TypeOperand))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 4;
			case 2:
				if (typeBinaryExpressionFingerprint == null)
				{
					num2 = 4;
					break;
				}
				goto default;
			case 1:
				return Equals(typeBinaryExpressionFingerprint);
			case 4:
				return false;
			case 3:
				typeBinaryExpressionFingerprint = obj as TypeBinaryExpressionFingerprint;
				num2 = 2;
				break;
			}
		}
	}

	internal override void AddToHashCodeCombiner(HashCodeCombiner combiner)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				Enl86ooJDSO4sFLIX1A(combiner, TypeOperand);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				base.AddToHashCodeCombiner(combiner);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool sHEeg6omLrtuqsb34Ju()
	{
		return M3Negao0bEwOI1on8Nr == null;
	}

	internal static TypeBinaryExpressionFingerprint ymTinNoyVUuYkUCHrRY()
	{
		return M3Negao0bEwOI1on8Nr;
	}

	internal static void pt4PkdoMfV80IJFbekt()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static void Enl86ooJDSO4sFLIX1A(object P_0, object P_1)
	{
		((HashCodeCombiner)P_0).AddObject(P_1);
	}
}
