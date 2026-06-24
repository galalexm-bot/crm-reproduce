using EleWise.ELMA.Model.Entities.EntityReferences;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Models;

internal static class ObservedContextPropertyConsts
{
	public static class Fields
	{
		public const string ProcessHeader = "ProcessHeader";

		public const string Type = "Type";

		public const string SubType = "SubType";

		public const string Context = "Context";

		public const string WorkflowInstance = "WorkflowInstance";

		public const string PropertyUid = "PropertyUid";

		public const string Object = "Object";

		public static readonly string ObjectOI;

		public static readonly string ObjectTU;

		private static Fields mTWPSavYXYB8pEGTwOL8;

		static Fields()
		{
			int num = 3;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					ObjectTU = (string)iI8CODvYHPyxNkL6wdGn(RwZoi4vYDnUSymadh1yp(-1361036319 ^ -1360862211));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a23e27b648a042f098a477c26c4beed1 != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				case 2:
					ObjectOI = (string)JTpwRXvYnceIdfRwoZ7L(RwZoi4vYDnUSymadh1yp(-1539486135 ^ -1539336619));
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_32f3e755437f4eacb85c8a0d536f83ea != 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3bb28bf622874b4689f9265e58d14823 == 0)
					{
						num2 = 2;
					}
					break;
				}
			}
		}

		internal static object RwZoi4vYDnUSymadh1yp(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object JTpwRXvYnceIdfRwoZ7L(object P_0)
		{
			return ReferenceOnEntityNHType.GenerateObjectIdName((string)P_0);
		}

		internal static object iI8CODvYHPyxNkL6wdGn(object P_0)
		{
			return ReferenceOnEntityNHType.GenerateObjectTypeName((string)P_0);
		}

		internal static bool rNUBVZvYdix6eKSoVViT()
		{
			return mTWPSavYXYB8pEGTwOL8 == null;
		}

		internal static Fields ucduVDvYudPtaEq3Ihg2()
		{
			return mTWPSavYXYB8pEGTwOL8;
		}
	}

	public const string TableName = "Sys_ObservedCtxProperty";
}
