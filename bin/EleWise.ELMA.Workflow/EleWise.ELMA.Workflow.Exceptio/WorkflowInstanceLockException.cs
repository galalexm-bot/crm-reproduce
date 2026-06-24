using System;
using System.Runtime.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Exceptions;

[Serializable]
public class WorkflowInstanceLockException : Exception
{
	internal static WorkflowInstanceLockException mcwrUoa7aBZDkJGD2qQ;

	public WorkflowInstanceLockException()
	{
		//Discarded unreachable code: IL_003f, IL_0044
		L8Dd5LaFidMtwTX0NLw();
		base._002Ector(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1716629332 ^ -1716583652)));
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public WorkflowInstanceLockException(long instanceId)
	{
		//Discarded unreachable code: IL_004e, IL_0053
		L8Dd5LaFidMtwTX0NLw();
		base._002Ector((string)YkddlpaID2GRDVSvkb1(RmjcOKai2CF2iiPYd4m(-432000546 ^ -431921722), new object[1] { instanceId }));
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public WorkflowInstanceLockException(long instanceId, Exception innerException)
	{
		//Discarded unreachable code: IL_004f, IL_0054
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector((string)YkddlpaID2GRDVSvkb1(RmjcOKai2CF2iiPYd4m(-43932417 ^ -43978521), new object[1] { instanceId }), innerException);
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e8980a9fd9d44c20920ffa276900c96f != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected WorkflowInstanceLockException(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector(info, context);
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void L8Dd5LaFidMtwTX0NLw()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool Yxhq4pa29pvjQIZCAgj()
	{
		return mcwrUoa7aBZDkJGD2qQ == null;
	}

	internal static WorkflowInstanceLockException nLqe1RaoEe1ifD48yZ8()
	{
		return mcwrUoa7aBZDkJGD2qQ;
	}

	internal static object RmjcOKai2CF2iiPYd4m(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object YkddlpaID2GRDVSvkb1(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}
}
