using System;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Tasks;

public class MultiInstanceSettings
{
	public enum ValueType
	{
		[DisplayName(typeof(ValueType_SR), "Value")]
		Value,
		[DisplayName(typeof(ValueType_SR), "Property")]
		Property
	}

	internal static class ValueType_SR
	{
		private static ValueType_SR OG5656vnvB0W0yCv0quF;

		public static string Value => (string)H73uGrvnJokNUgtQpiiS(JweN6Hvns13AlKxXyruB(0x4FD00585 ^ 0x4FD2ADDD));

		public static string Property => SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2125897096 ^ -2125763224));

		internal static object JweN6Hvns13AlKxXyruB(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object H73uGrvnJokNUgtQpiiS(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static bool XnX3HLvnYtktoG38DlVj()
		{
			return OG5656vnvB0W0yCv0quF == null;
		}

		internal static ValueType_SR nvCLKSvn8dXTwyghxDJI()
		{
			return OG5656vnvB0W0yCv0quF;
		}
	}

	private static MultiInstanceSettings jFaruWZbPSRHWyNIN24A;

	public ValueType InstanceCountType
	{
		[CompilerGenerated]
		get
		{
			return _003CInstanceCountType_003Ek__BackingField;
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
					_003CInstanceCountType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_938c6be4ea2248868d7ed5d0e3346006 == 0)
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

	public int InstanceCount
	{
		[CompilerGenerated]
		get
		{
			return _003CInstanceCount_003Ek__BackingField;
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
					_003CInstanceCount_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6fe3beca34a9422e873cd6ef331760ae == 0)
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

	public Guid InstanceCountPropertyUid
	{
		[CompilerGenerated]
		get
		{
			return _003CInstanceCountPropertyUid_003Ek__BackingField;
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
				case 0:
					return;
				case 1:
					_003CInstanceCountPropertyUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public MultiInstanceSettings()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Sj6x8lZbuHpmEArMsQ90();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_18b351a59a324c25b4f150a9771bcf69 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			InstanceCount = 1;
			num = 1;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 != 0)
			{
				num = 1;
			}
		}
	}

	internal static void Sj6x8lZbuHpmEArMsQ90()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool EqxQyQZbXxmjoijncOGv()
	{
		return jFaruWZbPSRHWyNIN24A == null;
	}

	internal static MultiInstanceSettings JXBcccZbdeMXwT5WtGDX()
	{
		return jFaruWZbPSRHWyNIN24A;
	}
}
