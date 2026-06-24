using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Security;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Listeners;

[Component]
internal class WorkflowTaskBasePermissionUnitOfWorkListener : IUnitOfWorkEventListener
{
	private readonly IContextBoundVariableService contextBoundVariableService;

	private readonly ITransformationProvider transformationProvider;

	internal static WorkflowTaskBasePermissionUnitOfWorkListener lWGxFyqRdwNxA20aURy;

	public WorkflowTaskBasePermissionUnitOfWorkListener(IContextBoundVariableService contextBoundVariableService, ITransformationProvider transformationProvider)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				this.transformationProvider = transformationProvider;
				num = 2;
				continue;
			case 2:
				return;
			}
			this.contextBoundVariableService = contextBoundVariableService;
			num = 1;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_61395ebf330446ac8ce99b55ee3acfa9 != 0)
			{
				num = 1;
			}
		}
	}

	public void OnPreCommitUnitofWork(IUnitOfWork unitOfWork)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				UpdateWorkflowRoleTypePermissions();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a50dda04dedf4515816f963c67783c8f != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 2:
				UpdateCommonRoleTypesPermissions();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private void UpdateWorkflowRoleTypePermissions()
	{
		//Discarded unreachable code: IL_00a9, IL_00b8, IL_0181, IL_018b, IL_026d, IL_032d, IL_0386, IL_03f9, IL_0408, IL_0418, IL_0427, IL_0450, IL_09a3, IL_09b6, IL_09c5, IL_09d5, IL_0a1a, IL_0c18, IL_0c22, IL_0c48, IL_167a, IL_169a, IL_16a9, IL_16b8, IL_16c8, IL_172b, IL_173a, IL_174a, IL_1759, IL_1781, IL_17b6, IL_1803, IL_181e, IL_182d, IL_183e, IL_1848, IL_1f79, IL_1fe1, IL_2027, IL_2036, IL_20bc, IL_20c6, IL_2112, IL_2174, IL_21bc, IL_21dc, IL_2243, IL_2281, IL_22c7, IL_22eb, IL_230e, IL_2319, IL_2367, IL_23c3, IL_23d2, IL_244a, IL_2454, IL_25a8, IL_25bb, IL_25ca, IL_262f, IL_263e, IL_268c
		int num = 8;
		HashSet<IProcessHeaderAccess> value = default(HashSet<IProcessHeaderAccess>);
		EleWise.ELMA.Security.Models.IUser user = default(EleWise.ELMA.Security.Models.IUser);
		_003C_003Ec__DisplayClass4_0 _003C_003Ec__DisplayClass4_ = default(_003C_003Ec__DisplayClass4_0);
		_003C_003Ec__DisplayClass4_1 _003C_003Ec__DisplayClass4_2 = default(_003C_003Ec__DisplayClass4_1);
		HashSet<IProcessHeaderAccess>.Enumerator enumerator = default(HashSet<IProcessHeaderAccess>.Enumerator);
		_003C_003Ec__DisplayClass4_6 _003C_003Ec__DisplayClass4_4 = default(_003C_003Ec__DisplayClass4_6);
		string sql4 = default(string);
		IPropertyExpressionDescriptorWithInstanceUid[] array = default(IPropertyExpressionDescriptorWithInstanceUid[]);
		string text7 = default(string);
		IPropertyExpressionDescriptorWithInstanceUid propertyExpressionDescriptorWithInstanceUid7 = default(IPropertyExpressionDescriptorWithInstanceUid);
		string text8 = default(string);
		IPropertyExpressionDescriptorWithInstanceUid propertyExpressionDescriptorWithInstanceUid6 = default(IPropertyExpressionDescriptorWithInstanceUid);
		string sql5 = default(string);
		IPropertyExpressionDescriptorWithInstanceUid propertyExpressionDescriptorWithInstanceUid4 = default(IPropertyExpressionDescriptorWithInstanceUid);
		_003C_003Ec__DisplayClass4_5 _003C_003Ec__DisplayClass4_3 = default(_003C_003Ec__DisplayClass4_5);
		Guid guid = default(Guid);
		Guid? permissionRole = default(Guid?);
		string text6 = default(string);
		string sql = default(string);
		string text3 = default(string);
		string text = default(string);
		string sql3 = default(string);
		string text2 = default(string);
		IPropertyExpressionDescriptorWithInstanceUid propertyExpressionDescriptorWithInstanceUid5 = default(IPropertyExpressionDescriptorWithInstanceUid);
		IPropertyExpressionDescriptorWithInstanceUid propertyExpressionDescriptorWithInstanceUid3 = default(IPropertyExpressionDescriptorWithInstanceUid);
		string sql2 = default(string);
		string text4 = default(string);
		string text5 = default(string);
		IPropertyExpressionDescriptorWithInstanceUid propertyExpressionDescriptorWithInstanceUid = default(IPropertyExpressionDescriptorWithInstanceUid);
		IPropertyExpressionDescriptorWithInstanceUid propertyExpressionDescriptorWithInstanceUid2 = default(IPropertyExpressionDescriptorWithInstanceUid);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 16:
					if (value == null)
					{
						num2 = 18;
						continue;
					}
					goto case 12;
				case 22:
					user = ((AbstractNHEntityManager<EleWise.ELMA.Security.Models.IUser, long>)dYFMeIqayTkFSFo1dgf()).Load(SecurityConstants.SystemUserUid);
					num2 = 3;
					continue;
				case 10:
				case 18:
					if (_003C_003Ec__DisplayClass4_.deleteProcHeaderAccess == null)
					{
						num2 = 2;
						continue;
					}
					goto case 22;
				case 7:
					contextBoundVariableService.TryGetValue<HashSet<IProcessHeaderAccess>>((string)iBuu1eq30Mlxo9HASSU(-432000546 ^ -431950872), out _003C_003Ec__DisplayClass4_.deleteProcHeaderAccess);
					num2 = 9;
					continue;
				case 11:
					if (value != null)
					{
						num2 = 13;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3bb28bf622874b4689f9265e58d14823 == 0)
						{
							num2 = 21;
						}
						continue;
					}
					goto case 6;
				case 1:
					if (_003C_003Ec__DisplayClass4_2.copyPermissionons.Count() <= 0)
					{
						num = 14;
						break;
					}
					goto case 20;
				case 20:
					_003C_003Ec__DisplayClass4_.deleteProcHeaderAccess.RemoveWhere(_003C_003Ec__DisplayClass4_2._003CUpdateWorkflowRoleTypePermissions_003Eb__1);
					num2 = 17;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_448e6815cb30438893079dcbb906fd65 == 0)
					{
						num2 = 14;
					}
					continue;
				case 13:
					try
					{
						while (true)
						{
							int num6;
							if (!enumerator.MoveNext())
							{
								num6 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eef7d2ca1c3c4b74aeb81172ed542639 != 0)
								{
									num6 = 1;
								}
								goto IL_018f;
							}
							goto IL_06fd;
							IL_06fd:
							_003C_003Ec__DisplayClass4_4 = new _003C_003Ec__DisplayClass4_6();
							num6 = 25;
							goto IL_018f;
							IL_018f:
							while (true)
							{
								switch (num6)
								{
								case 9:
									if (!qk7MkkqpfQPdyoDsvA7(rdvS82qroe7jnY68YPg(_003C_003Ec__DisplayClass4_4.deletePha), S4V9anqQfQlPFlWW5XZ(WorkflowRoleTypes.Initiator)))
									{
										num6 = 3;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_85ba8d91af394836ac86666c40b1e150 == 0)
										{
											num6 = 2;
										}
										continue;
									}
									goto case 7;
								case 20:
									transformationProvider.ExecuteNonQuery(sql4);
									num6 = 7;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cb262bcfe4074a1ab16e653815d57f28 != 0)
									{
										num6 = 26;
									}
									continue;
								case 6:
									if (!(rdvS82qroe7jnY68YPg(_003C_003Ec__DisplayClass4_4.deletePha) == S4V9anqQfQlPFlWW5XZ(WorkflowRoleTypes.CurrentExecutor)))
									{
										num6 = 9;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f8a84e2cb374827a50ba2cbcf11cf48 != 0)
										{
											num6 = 9;
										}
										continue;
									}
									goto case 7;
								case 24:
									if (array == null)
									{
										num6 = 18;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b == 0)
										{
											num6 = 17;
										}
										continue;
									}
									goto case 5;
								case 5:
									text7 = (string)IWi4eyqMugtnldDqsog(iBuu1eq30Mlxo9HASSU(-452127399 ^ -452075703), propertyExpressionDescriptorWithInstanceUid7.Name);
									num6 = 15;
									continue;
								default:
									text8 = (string)IWi4eyqMugtnldDqsog(iBuu1eq30Mlxo9HASSU(0x747FFBE0 ^ 0x747F31F0), lP2UlGqCiaEnIOmRvWL(propertyExpressionDescriptorWithInstanceUid6));
									num6 = 14;
									continue;
								case 4:
								case 11:
								case 12:
								case 18:
								case 26:
									break;
								case 13:
									propertyExpressionDescriptorWithInstanceUid7 = array.FirstOrDefault(_003C_003Ec__DisplayClass4_4._003CUpdateWorkflowRoleTypePermissions_003Eb__12);
									num6 = 24;
									continue;
								case 17:
									if (!qk7MkkqpfQPdyoDsvA7(rdvS82qroe7jnY68YPg(_003C_003Ec__DisplayClass4_4.deletePha), S4V9anqQfQlPFlWW5XZ(WorkflowRoleTypes.ProcessInstanceMember)))
									{
										num6 = 11;
										continue;
									}
									goto case 13;
								case 3:
									if (qk7MkkqpfQPdyoDsvA7(rdvS82qroe7jnY68YPg(_003C_003Ec__DisplayClass4_4.deletePha), S4V9anqQfQlPFlWW5XZ(WorkflowRoleTypes.ProcessOwner)))
									{
										num6 = 21;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4459fbe344a947429d197733d274ef68 == 0)
										{
											num6 = 13;
										}
										continue;
									}
									goto case 23;
								case 10:
									transformationProvider.ExecuteNonQuery(sql5);
									num6 = 12;
									continue;
								case 23:
									if (!qk7MkkqpfQPdyoDsvA7(rdvS82qroe7jnY68YPg(_003C_003Ec__DisplayClass4_4.deletePha), S4V9anqQfQlPFlWW5XZ(WorkflowRoleTypes.ResponsibleForInstance)))
									{
										num6 = 8;
										continue;
									}
									goto case 7;
								case 14:
									if (propertyExpressionDescriptorWithInstanceUid6 == null)
									{
										num6 = 4;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 == 0)
										{
											num6 = 4;
										}
										continue;
									}
									goto case 2;
								case 2:
									sql5 = (string)IS1xeuq25wLEN6Vcs2Y(iBuu1eq30Mlxo9HASSU(0x5DB28AD2 ^ 0x5DB26920), new object[16]
									{
										user.Id,
										p24fEgqouNxrtxkVbAX(),
										tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), iBuu1eq30Mlxo9HASSU(-1001967776 ^ -1001919684)),
										((Dialect)oAK7Q0qk6VT2CXNiJrA(transformationProvider)).QuoteIfNeeded((string)iBuu1eq30Mlxo9HASSU(-398691253 ^ -398710077)),
										tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), iBuu1eq30Mlxo9HASSU(-1393899982 ^ -1393950026)),
										((Dialect)oAK7Q0qk6VT2CXNiJrA(transformationProvider)).QuoteIfNeeded((string)iBuu1eq30Mlxo9HASSU(0x69063C81 ^ 0x6906F96F)),
										text8,
										mfHBxUqA9PjnQdPv2bK(oAK7Q0qk6VT2CXNiJrA(transformationProvider)),
										((Dialect)oAK7Q0qk6VT2CXNiJrA(transformationProvider)).GuidToCharFromSqlWithoutQuote(string.Format((string)iBuu1eq30Mlxo9HASSU(-2057730233 ^ -2057746167), tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), iBuu1eq30Mlxo9HASSU(0x1EA50FCC ^ 0x1EA549B0)))),
										tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), iBuu1eq30Mlxo9HASSU(-495296780 ^ -495319458)),
										tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), iBuu1eq30Mlxo9HASSU(0x1AF6F1F2 ^ 0x1AF6B6F6)),
										tlC11aqUCIT1wvlp1BG(transformationProvider.Dialect, iBuu1eq30Mlxo9HASSU(0x37F755F5 ^ 0x37F71373)),
										tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), iBuu1eq30Mlxo9HASSU(0x6871CA ^ 0x682FF2)),
										tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1050383744 ^ -1050410474)),
										((IEntity<long>)YbMg3vq7m9ZtAeXsG0R(_003C_003Ec__DisplayClass4_4.deletePha)).Id,
										QoERJHqVp8QW3ftwtAM(oAK7Q0qk6VT2CXNiJrA(transformationProvider), user.Id.ToString())
									});
									num6 = 10;
									continue;
								case 25:
									_003C_003Ec__DisplayClass4_4.deletePha = enumerator.Current;
									num6 = 6;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9269d021c6f148b6a1c4afb8cee03b6c == 0)
									{
										num6 = 4;
									}
									continue;
								case 16:
									goto IL_06fd;
								case 15:
									sql4 = (string)IS1xeuq25wLEN6Vcs2Y(iBuu1eq30Mlxo9HASSU(0x1843E01F ^ 0x18430695), new object[12]
									{
										((Dialect)oAK7Q0qk6VT2CXNiJrA(transformationProvider)).QuoteIfNeeded((string)iBuu1eq30Mlxo9HASSU(0x747FFBE0 ^ 0x747F3FBC)),
										tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), iBuu1eq30Mlxo9HASSU(-432000546 ^ -431950800)),
										tlC11aqUCIT1wvlp1BG(transformationProvider.Dialect, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1927DA93 ^ 0x19279CEF)),
										text7,
										mfHBxUqA9PjnQdPv2bK(oAK7Q0qk6VT2CXNiJrA(transformationProvider)),
										hShDL2qGZGwkMCmnPCX(oAK7Q0qk6VT2CXNiJrA(transformationProvider), string.Format((string)iBuu1eq30Mlxo9HASSU(-947937941 ^ -947956955), tlC11aqUCIT1wvlp1BG(transformationProvider.Dialect, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-539998957 ^ -540015761)))),
										((Dialect)oAK7Q0qk6VT2CXNiJrA(transformationProvider)).QuoteIfNeeded((string)iBuu1eq30Mlxo9HASSU(0x74AB4717 ^ 0x74AB1FBD)),
										tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), iBuu1eq30Mlxo9HASSU(0x6F6D7B44 ^ 0x6F6D3C40)),
										tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), iBuu1eq30Mlxo9HASSU(-1716629332 ^ -1716644310)),
										tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), iBuu1eq30Mlxo9HASSU(0x37E97159 ^ 0x37E92F61)),
										tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), iBuu1eq30Mlxo9HASSU(-1214182792 ^ -1214160146)),
										((IEntity<long>)YbMg3vq7m9ZtAeXsG0R(_003C_003Ec__DisplayClass4_4.deletePha)).Id
									});
									num6 = 20;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 == 0)
									{
										num6 = 20;
									}
									continue;
								case 19:
								case 22:
									if (!(rdvS82qroe7jnY68YPg(_003C_003Ec__DisplayClass4_4.deletePha) == S4V9anqQfQlPFlWW5XZ(WorkflowRoleTypes.ProcessCurator)))
									{
										num6 = 17;
										continue;
									}
									goto case 13;
								case 8:
									if (!qk7MkkqpfQPdyoDsvA7(_003C_003Ec__DisplayClass4_4.deletePha.TypeRoleId, S4V9anqQfQlPFlWW5XZ(WorkflowRoleTypes.DirectorsOfCurrentExecutor)))
									{
										num6 = 19;
										continue;
									}
									goto case 7;
								case 7:
								case 21:
									propertyExpressionDescriptorWithInstanceUid6 = array.FirstOrDefault(_003C_003Ec__DisplayClass4_4._003CUpdateWorkflowRoleTypePermissions_003Eb__11);
									num6 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 == 0)
									{
										num6 = 0;
									}
									continue;
								case 1:
									return;
								}
								break;
							}
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num7 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e4c570270f54493d8f3f4763a72f63f7 != 0)
						{
							num7 = 0;
						}
						switch (num7)
						{
						case 0:
							break;
						}
					}
				case 4:
					_003C_003Ec__DisplayClass4_2.copyPermissionons = value.Where(_003C_003Ec__DisplayClass4_._003CUpdateWorkflowRoleTypePermissions_003Eb__0);
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a9be7e056b4e4b6e863b634c418144f1 == 0)
					{
						num2 = 1;
					}
					continue;
				default:
					try
					{
						while (true)
						{
							IL_18ca:
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 36;
								goto IL_0a24;
							}
							goto IL_17dc;
							IL_0a28:
							int num4;
							while (true)
							{
								object obj;
								switch (num4)
								{
								case 55:
									propertyExpressionDescriptorWithInstanceUid4 = array.FirstOrDefault(_003C_003Ec__DisplayClass4_3._003CUpdateWorkflowRoleTypePermissions_003Eb__8);
									num4 = 18;
									continue;
								case 24:
									guid = S4V9anqQfQlPFlWW5XZ(WorkflowRoleTypes.Initiator);
									num4 = 70;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e9561fecdd4d49678d9f9ea7d295fb1b != 0)
									{
										num4 = 11;
									}
									continue;
								case 6:
									guid = S4V9anqQfQlPFlWW5XZ(WorkflowRoleTypes.ResponsibleForInstance);
									num4 = 56;
									continue;
								case 53:
									permissionRole = _003C_003Ec__DisplayClass4_3.insertPha.PermissionRole;
									num4 = 52;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4cc62744d0eb4cd68219b70dcad3e68e != 0)
									{
										num4 = 4;
									}
									continue;
								case 31:
									if (permissionRole.HasValue)
									{
										num4 = 23;
										continue;
									}
									goto case 44;
								case 85:
									transformationProvider.Insert(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1145BED7 ^ 0x11457A8B), new string[5]
									{
										(string)iBuu1eq30Mlxo9HASSU(0x101D10F ^ 0x1019773),
										(string)iBuu1eq30Mlxo9HASSU(-25709590 ^ -25725464),
										(string)iBuu1eq30Mlxo9HASSU(--1436248540 ^ 0x559BAC32),
										(string)iBuu1eq30Mlxo9HASSU(-261315199 ^ -261332077),
										(string)iBuu1eq30Mlxo9HASSU(-935313063 ^ -935295523)
									}, string.Format((string)iBuu1eq30Mlxo9HASSU(0x1134D2C0 ^ 0x1134054C), jMEHG0qiGxZfOOSpv7f(oAK7Q0qk6VT2CXNiJrA(transformationProvider)), QqdkjYqFkncQE1IMKH5()), string.Format((string)iBuu1eq30Mlxo9HASSU(-1214182792 ^ -1214131710), ((Dialect)oAK7Q0qk6VT2CXNiJrA(transformationProvider)).QuoteIfNeeded((string)iBuu1eq30Mlxo9HASSU(0x614CF569 ^ 0x614CB3EF)), text6, mfHBxUqA9PjnQdPv2bK(oAK7Q0qk6VT2CXNiJrA(transformationProvider)), hShDL2qGZGwkMCmnPCX(oAK7Q0qk6VT2CXNiJrA(transformationProvider), string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5DB28AD2 ^ 0x5DB2449C), ((Dialect)oAK7Q0qk6VT2CXNiJrA(transformationProvider)).QuoteIfNeeded((string)iBuu1eq30Mlxo9HASSU(-885093259 ^ -885077495)))), ((Dialect)oAK7Q0qk6VT2CXNiJrA(transformationProvider)).ConvertToInt64((string)IWi4eyqMugtnldDqsog(iBuu1eq30Mlxo9HASSU(-768800937 ^ -768749523), tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), iBuu1eq30Mlxo9HASSU(-1108877388 ^ -1108901588)))), ((Dialect)oAK7Q0qk6VT2CXNiJrA(transformationProvider)).QuoteIfNeeded((string)iBuu1eq30Mlxo9HASSU(--296112178 ^ 0x11A699FC)), tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1927DA93 ^ 0x1927B0A9)), tlC11aqUCIT1wvlp1BG(transformationProvider.Dialect, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1647793954 ^ -1647775628)), ((Dialect)oAK7Q0qk6VT2CXNiJrA(transformationProvider)).QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3C1FFB55 ^ 0x3C1FEBD1)), transformationProvider.Dialect.QuoteIfNeeded((string)iBuu1eq30Mlxo9HASSU(0x74AB4717 ^ 0x74AB0013)), tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), iBuu1eq30Mlxo9HASSU(-708128192 ^ -708146056)), tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), iBuu1eq30Mlxo9HASSU(0x1EA50FCC ^ 0x1EA5675A)), ((IEntity<long>)YbMg3vq7m9ZtAeXsG0R(_003C_003Ec__DisplayClass4_3.insertPha)).Id, transformationProvider.Dialect.QuoteIfNeeded((string)iBuu1eq30Mlxo9HASSU(-862330810 ^ -862339674)), tlC11aqUCIT1wvlp1BG(transformationProvider.Dialect, iBuu1eq30Mlxo9HASSU(-949717965 ^ -949736915)), tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1145BED7 ^ 0x1145D5B3))), isNeedInsertId: true);
									num4 = 5;
									continue;
								case 16:
									sql = (string)IS1xeuq25wLEN6Vcs2Y(iBuu1eq30Mlxo9HASSU(--601115071 ^ 0x23D483A5), new object[20]
									{
										tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), iBuu1eq30Mlxo9HASSU(-1214182792 ^ -1214132700)),
										((Dialect)oAK7Q0qk6VT2CXNiJrA(transformationProvider)).QuoteIfNeeded((string)iBuu1eq30Mlxo9HASSU(-25709590 ^ -25694878)),
										tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x747FFBE0 ^ 0x747F90A0)),
										tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), iBuu1eq30Mlxo9HASSU(-1716629332 ^ -1716610718)),
										((Dialect)oAK7Q0qk6VT2CXNiJrA(transformationProvider)).QuoteIfNeeded((string)iBuu1eq30Mlxo9HASSU(-1542190822 ^ -1542167776)),
										tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x361628FF ^ 0x36166E79)),
										transformationProvider.Dialect.QuoteIfNeeded((string)iBuu1eq30Mlxo9HASSU(0xB7793C9 ^ 0xB77CB63)),
										tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), iBuu1eq30Mlxo9HASSU(-10408775 ^ -10404803)),
										tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), iBuu1eq30Mlxo9HASSU(-1647793954 ^ -1647808804)),
										QoERJHqVp8QW3ftwtAM(oAK7Q0qk6VT2CXNiJrA(transformationProvider), IWi4eyqMugtnldDqsog(iBuu1eq30Mlxo9HASSU(-351369538 ^ -351385360), tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), text3))),
										((Dialect)oAK7Q0qk6VT2CXNiJrA(transformationProvider)).QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-106528299 ^ -106544069)),
										text,
										mfHBxUqA9PjnQdPv2bK(oAK7Q0qk6VT2CXNiJrA(transformationProvider)),
										hShDL2qGZGwkMCmnPCX(transformationProvider.Dialect, string.Format((string)iBuu1eq30Mlxo9HASSU(-420003255 ^ -419984377), tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), iBuu1eq30Mlxo9HASSU(0x6A69C5CD ^ 0x6A6983B1)))),
										tlC11aqUCIT1wvlp1BG(transformationProvider.Dialect, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1574607501 ^ -1574624649)),
										((Dialect)oAK7Q0qk6VT2CXNiJrA(transformationProvider)).QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x75BAD659 ^ 0x75BA8861)),
										tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), iBuu1eq30Mlxo9HASSU(-1716629332 ^ -1716635590)),
										((IEntity<long>)YbMg3vq7m9ZtAeXsG0R(_003C_003Ec__DisplayClass4_3.insertPha)).Id,
										tlC11aqUCIT1wvlp1BG(transformationProvider.Dialect, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-935313063 ^ -935295523)),
										UserSecuritySetHelper.UserMask
									});
									num4 = 58;
									continue;
								case 63:
									sql3 = (string)IS1xeuq25wLEN6Vcs2Y(iBuu1eq30Mlxo9HASSU(-2122743969 ^ -2122731891), new object[24]
									{
										tlC11aqUCIT1wvlp1BG(transformationProvider.Dialect, iBuu1eq30Mlxo9HASSU(-1638225214 ^ -1638240610)),
										((Dialect)oAK7Q0qk6VT2CXNiJrA(transformationProvider)).QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x75872B6 ^ 0x7582C3E)),
										transformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x69063C81 ^ 0x6906F805)),
										QoERJHqVp8QW3ftwtAM(oAK7Q0qk6VT2CXNiJrA(transformationProvider), IWi4eyqMugtnldDqsog(iBuu1eq30Mlxo9HASSU(-862330810 ^ -862374084), transformationProvider.Dialect.QuoteIfNeeded((string)iBuu1eq30Mlxo9HASSU(0xA7339EE ^ 0xA736776)))),
										((Dialect)oAK7Q0qk6VT2CXNiJrA(transformationProvider)).QuoteIfNeeded((string)iBuu1eq30Mlxo9HASSU(-1393899982 ^ -1393946628)),
										((Dialect)oAK7Q0qk6VT2CXNiJrA(transformationProvider)).QuoteIfNeeded((string)iBuu1eq30Mlxo9HASSU(0x628167BE ^ 0x62810D84)),
										tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), iBuu1eq30Mlxo9HASSU(-1895853023 ^ -1895837017)),
										tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), iBuu1eq30Mlxo9HASSU(0x74AB4717 ^ 0x74AB1FBD)),
										((Dialect)oAK7Q0qk6VT2CXNiJrA(transformationProvider)).QuoteIfNeeded((string)iBuu1eq30Mlxo9HASSU(-130098986 ^ -130103214)),
										((Dialect)oAK7Q0qk6VT2CXNiJrA(transformationProvider)).QuoteIfNeeded((string)iBuu1eq30Mlxo9HASSU(-1214182792 ^ -1214165636)),
										tlC11aqUCIT1wvlp1BG(transformationProvider.Dialect, iBuu1eq30Mlxo9HASSU(0x63D6C913 ^ 0x63D6972B)),
										((Dialect)oAK7Q0qk6VT2CXNiJrA(transformationProvider)).QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-667465279 ^ -667479007)),
										tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), iBuu1eq30Mlxo9HASSU(0x651FE29D ^ 0x651FBC83)),
										tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), iBuu1eq30Mlxo9HASSU(0x3C1FFB55 ^ 0x3C1F3D57)),
										tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), iBuu1eq30Mlxo9HASSU(-980570076 ^ -980553950)),
										2,
										tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), iBuu1eq30Mlxo9HASSU(-772614310 ^ -772664652)),
										text2,
										mfHBxUqA9PjnQdPv2bK(oAK7Q0qk6VT2CXNiJrA(transformationProvider)),
										hShDL2qGZGwkMCmnPCX(oAK7Q0qk6VT2CXNiJrA(transformationProvider), IWi4eyqMugtnldDqsog(iBuu1eq30Mlxo9HASSU(0x5F800F5B ^ 0x5F80C115), ((Dialect)oAK7Q0qk6VT2CXNiJrA(transformationProvider)).QuoteIfNeeded((string)iBuu1eq30Mlxo9HASSU(0x7AC609FE ^ 0x7AC64F82)))),
										tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), iBuu1eq30Mlxo9HASSU(-642713667 ^ -642733691)),
										tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), iBuu1eq30Mlxo9HASSU(0x37E97159 ^ 0x37E919CF)),
										_003C_003Ec__DisplayClass4_3.insertPha.ProcessHeader.Id,
										QqdkjYqFkncQE1IMKH5()
									});
									num4 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe4a54387d744988feba4889229faf1 != 0)
									{
										num4 = 4;
									}
									continue;
								case 70:
									if (permissionRole.HasValue)
									{
										num4 = 13;
										continue;
									}
									goto case 57;
								case 38:
									guid = S4V9anqQfQlPFlWW5XZ(WorkflowRoleTypes.ProcessInstanceMember);
									num4 = 31;
									continue;
								case 51:
								case 81:
									permissionRole = _003C_003Ec__DisplayClass4_3.insertPha.PermissionRole;
									num4 = 38;
									continue;
								case 64:
									break;
								case 4:
									transformationProvider.ExecuteNonQuery(sql3);
									num4 = 9;
									continue;
								case 13:
									if (!permissionRole.HasValue)
									{
										num4 = 27;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_448e6815cb30438893079dcbb906fd65 == 0)
										{
											num4 = 27;
										}
										continue;
									}
									if (!qk7MkkqpfQPdyoDsvA7(permissionRole.GetValueOrDefault(), guid))
									{
										goto case 57;
									}
									goto case 27;
								case 83:
									permissionRole = _003C_003Ec__DisplayClass4_3.insertPha.PermissionRole;
									num4 = 6;
									continue;
								case 68:
									goto end_IL_0a28;
								case 86:
									if (propertyExpressionDescriptorWithInstanceUid5 == null)
									{
										num4 = 20;
										continue;
									}
									goto case 69;
								case 82:
									text6 = (string)IWi4eyqMugtnldDqsog(iBuu1eq30Mlxo9HASSU(0x350C0E8 ^ 0x3500AF8), propertyExpressionDescriptorWithInstanceUid3.Name);
									num4 = 85;
									continue;
								case 3:
									if (permissionRole.HasValue)
									{
										num4 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 == 0)
										{
											num4 = 0;
										}
										continue;
									}
									goto case 51;
								case 15:
								case 25:
									propertyExpressionDescriptorWithInstanceUid5 = array.FirstOrDefault(_003C_003Ec__DisplayClass4_3._003CUpdateWorkflowRoleTypePermissions_003Eb__10);
									num4 = 86;
									continue;
								case 2:
								case 5:
								case 7:
								case 9:
								case 11:
								case 20:
								case 33:
								case 35:
								case 65:
								case 76:
									goto IL_18ca;
								case 61:
									goto IL_18e4;
								case 12:
								case 45:
								case 47:
									goto IL_18fe;
								case 49:
									sql2 = (string)IS1xeuq25wLEN6Vcs2Y(iBuu1eq30Mlxo9HASSU(-29981480 ^ -29996410), new object[18]
									{
										tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), iBuu1eq30Mlxo9HASSU(0x42311138 ^ 0x4231D564)),
										tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), iBuu1eq30Mlxo9HASSU(-130098986 ^ -130120098)),
										tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7AC609FE ^ 0x7AC663D8)),
										tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), iBuu1eq30Mlxo9HASSU(0x738ABA6E ^ 0x738A73A0)),
										tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x101D10F ^ 0x1019789)),
										tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), iBuu1eq30Mlxo9HASSU(0x6CC04061 ^ 0x6CC08663)),
										tlC11aqUCIT1wvlp1BG(transformationProvider.Dialect, iBuu1eq30Mlxo9HASSU(-539998957 ^ -539983465)),
										QoERJHqVp8QW3ftwtAM(oAK7Q0qk6VT2CXNiJrA(transformationProvider), IWi4eyqMugtnldDqsog(iBuu1eq30Mlxo9HASSU(-801808857 ^ -801796123), tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), iBuu1eq30Mlxo9HASSU(-708128192 ^ -708134810)))),
										tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), iBuu1eq30Mlxo9HASSU(0x34EA50D4 ^ 0x34EA953A)),
										text4,
										mfHBxUqA9PjnQdPv2bK(transformationProvider.Dialect),
										hShDL2qGZGwkMCmnPCX(oAK7Q0qk6VT2CXNiJrA(transformationProvider), IWi4eyqMugtnldDqsog(iBuu1eq30Mlxo9HASSU(-1647793954 ^ -1647810928), tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), iBuu1eq30Mlxo9HASSU(-1386448964 ^ -1386466880)))),
										tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x213F6477 ^ 0x213F3CDD)),
										tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), iBuu1eq30Mlxo9HASSU(-1776305410 ^ -1776288262)),
										tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), iBuu1eq30Mlxo9HASSU(0x5F534A5C ^ 0x5F531464)),
										tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-17847711 ^ -17841417)),
										_003C_003Ec__DisplayClass4_3.insertPha.ProcessHeader.Id,
										p24fEgqouNxrtxkVbAX()
									});
									num4 = 10;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd != 0)
									{
										num4 = 10;
									}
									continue;
								case 19:
									transformationProvider.Insert((string)iBuu1eq30Mlxo9HASSU(0x69063C81 ^ 0x6906F8DD), new string[5]
									{
										SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x213F6477 ^ 0x213F220B),
										(string)iBuu1eq30Mlxo9HASSU(-642713667 ^ -642764353),
										SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--601115071 ^ 0x23D48C51),
										(string)iBuu1eq30Mlxo9HASSU(0x2269BD32 ^ 0x22697B20),
										(string)iBuu1eq30Mlxo9HASSU(0x5DB28AD2 ^ 0x5DB24E56)
									}, (string)txHiveqIf4SaQr4qGtQ(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2269BD32 ^ 0x2269600C), jMEHG0qiGxZfOOSpv7f(oAK7Q0qk6VT2CXNiJrA(transformationProvider)), UserSecuritySetHelper.UserMask), (string)IS1xeuq25wLEN6Vcs2Y(iBuu1eq30Mlxo9HASSU(0x1927DA93 ^ 0x192704BB), new object[16]
									{
										((Dialect)oAK7Q0qk6VT2CXNiJrA(transformationProvider)).QuoteIfNeeded((string)iBuu1eq30Mlxo9HASSU(-351369538 ^ -351354824)),
										text5,
										((Dialect)oAK7Q0qk6VT2CXNiJrA(transformationProvider)).ConcatenateSymbol(),
										transformationProvider.Dialect.GuidToCharFromSqlWithoutQuote((string)IWi4eyqMugtnldDqsog(iBuu1eq30Mlxo9HASSU(-1600060848 ^ -1600009186), ((Dialect)oAK7Q0qk6VT2CXNiJrA(transformationProvider)).QuoteIfNeeded((string)iBuu1eq30Mlxo9HASSU(-683713632 ^ -683729444)))),
										tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), iBuu1eq30Mlxo9HASSU(-539998957 ^ -540011289)),
										QoERJHqVp8QW3ftwtAM(transformationProvider.Dialect, IWi4eyqMugtnldDqsog(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x65B7F624 ^ 0x65B71594), tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-708128192 ^ -708148300)))),
										tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), iBuu1eq30Mlxo9HASSU(-1393899982 ^ -1393946628)),
										((Dialect)oAK7Q0qk6VT2CXNiJrA(transformationProvider)).QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1927DA93 ^ 0x1927B0A9)),
										tlC11aqUCIT1wvlp1BG(transformationProvider.Dialect, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2F44D93A ^ 0x2F448190)),
										tlC11aqUCIT1wvlp1BG(transformationProvider.Dialect, iBuu1eq30Mlxo9HASSU(0x141C968 ^ 0x141D9EC)),
										tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xD305CC2 ^ 0xD30BF00)),
										tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2122743969 ^ -2122747941)),
										((Dialect)oAK7Q0qk6VT2CXNiJrA(transformationProvider)).QuoteIfNeeded((string)iBuu1eq30Mlxo9HASSU(--1418337216 ^ 0x548A45F8)),
										tlC11aqUCIT1wvlp1BG(transformationProvider.Dialect, iBuu1eq30Mlxo9HASSU(-1303601216 ^ -1303586620)),
										tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), iBuu1eq30Mlxo9HASSU(0x12F686A ^ 0x12F00FC)),
										((IEntity<long>)YbMg3vq7m9ZtAeXsG0R(_003C_003Ec__DisplayClass4_3.insertPha)).Id
									}), isNeedInsertId: true);
									num4 = 11;
									continue;
								case 30:
									text4 = string.Format((string)iBuu1eq30Mlxo9HASSU(-130098986 ^ -130149690), lP2UlGqCiaEnIOmRvWL(propertyExpressionDescriptorWithInstanceUid));
									num4 = 49;
									continue;
								case 57:
								case 79:
									obj = iBuu1eq30Mlxo9HASSU(0x738ABA6E ^ 0x738AEC68);
									goto IL_24db;
								case 26:
								case 41:
									permissionRole = _003C_003Ec__DisplayClass4_3.insertPha.PermissionRole;
									num3 = 61;
									goto IL_0a24;
								case 22:
								case 50:
								case 60:
									goto IL_2002;
								case 23:
									if (permissionRole.HasValue)
									{
										num4 = 32;
										continue;
									}
									goto case 15;
								case 66:
									text2 = string.Format((string)iBuu1eq30Mlxo9HASSU(-949717965 ^ -949699037), lP2UlGqCiaEnIOmRvWL(propertyExpressionDescriptorWithInstanceUid4));
									num4 = 14;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2f119e188994b55be2499c193b880fb != 0)
									{
										num4 = 63;
									}
									continue;
								case 34:
								case 73:
									permissionRole = _003C_003Ec__DisplayClass4_3.insertPha.PermissionRole;
									num4 = 77;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b == 0)
									{
										num4 = 17;
									}
									continue;
								case 21:
									guid = S4V9anqQfQlPFlWW5XZ(WorkflowRoleTypes.Initiator);
									num4 = 62;
									continue;
								case 62:
									goto IL_20e6;
								case 54:
									if (propertyExpressionDescriptorWithInstanceUid2 != null)
									{
										num4 = 13;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 == 0)
										{
											num4 = 14;
										}
										continue;
									}
									goto IL_18ca;
								default:
									if (!permissionRole.HasValue)
									{
										num4 = 28;
										continue;
									}
									if (!qk7MkkqpfQPdyoDsvA7(permissionRole.GetValueOrDefault(), guid))
									{
										goto case 51;
									}
									goto case 28;
								case 40:
									propertyExpressionDescriptorWithInstanceUid3 = array.FirstOrDefault(_003C_003Ec__DisplayClass4_3._003CUpdateWorkflowRoleTypePermissions_003Eb__9);
									num4 = 78;
									continue;
								case 52:
									guid = S4V9anqQfQlPFlWW5XZ(WorkflowRoleTypes.DirectorsOfCurrentExecutor);
									num4 = 8;
									continue;
								case 69:
									text5 = (string)IWi4eyqMugtnldDqsog(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xDF4D1F8 ^ 0xDF41BE8), lP2UlGqCiaEnIOmRvWL(propertyExpressionDescriptorWithInstanceUid5));
									num4 = 19;
									continue;
								case 18:
									if (propertyExpressionDescriptorWithInstanceUid4 == null)
									{
										num4 = 35;
										continue;
									}
									goto case 66;
								case 37:
								case 59:
									permissionRole = _003C_003Ec__DisplayClass4_3.insertPha.PermissionRole;
									num3 = 80;
									goto IL_0a24;
								case 77:
									guid = S4V9anqQfQlPFlWW5XZ(WorkflowRoleTypes.CurrentExecutor);
									num4 = 12;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3ab79470996d472f815915b21f45aac1 != 0)
									{
										num4 = 64;
									}
									continue;
								case 17:
									permissionRole = _003C_003Ec__DisplayClass4_3.insertPha.PermissionRole;
									num4 = 21;
									continue;
								case 78:
									if (propertyExpressionDescriptorWithInstanceUid3 == null)
									{
										num3 = 7;
										goto IL_0a24;
									}
									goto case 82;
								case 10:
									transformationProvider.ExecuteNonQuery(sql2);
									num4 = 33;
									continue;
								case 14:
									permissionRole = _003C_003Ec__DisplayClass4_3.insertPha.PermissionRole;
									num4 = 24;
									continue;
								case 58:
									transformationProvider.ExecuteNonQuery(sql);
									num3 = 65;
									goto IL_0a24;
								case 74:
									goto IL_233b;
								case 56:
									goto IL_236c;
								case 8:
									goto IL_2392;
								case 80:
									guid = S4V9anqQfQlPFlWW5XZ(WorkflowRoleTypes.ProcessOwner);
									num4 = 74;
									continue;
								case 43:
									text = (string)IWi4eyqMugtnldDqsog(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x101D10F ^ 0x1011B1F), lP2UlGqCiaEnIOmRvWL(propertyExpressionDescriptorWithInstanceUid2));
									num4 = 16;
									continue;
								case 46:
									if (propertyExpressionDescriptorWithInstanceUid == null)
									{
										num4 = 76;
										continue;
									}
									goto case 30;
								case 67:
									_003C_003Ec__DisplayClass4_3.insertPha = enumerator.Current;
									num4 = 17;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ecf910d183864897a7c8ec77e01689a4 == 0)
									{
										num4 = 3;
									}
									continue;
								case 29:
									goto IL_2471;
								case 72:
									if (qk7MkkqpfQPdyoDsvA7(permissionRole.GetValueOrDefault(), guid))
									{
										goto IL_18fe;
									}
									goto case 48;
								case 48:
									num4 = 34;
									continue;
								case 27:
									num4 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c != 0)
									{
										num4 = 0;
									}
									continue;
								case 1:
									obj = iBuu1eq30Mlxo9HASSU(-1574607501 ^ -1574629837);
									goto IL_24db;
								case 39:
									if (permissionRole.GetValueOrDefault() == guid)
									{
										goto IL_2002;
									}
									goto case 71;
								case 71:
									num3 = 53;
									goto IL_0a24;
								case 75:
									goto IL_251b;
								case 42:
									if (!qk7MkkqpfQPdyoDsvA7(permissionRole.GetValueOrDefault(), guid))
									{
										goto case 26;
									}
									goto IL_2538;
								case 84:
									goto IL_2538;
								case 28:
									num4 = 40;
									continue;
								case 32:
									if (qk7MkkqpfQPdyoDsvA7(permissionRole.GetValueOrDefault(), guid))
									{
										goto case 15;
									}
									goto case 44;
								case 44:
									num4 = 2;
									continue;
								case 36:
									goto end_IL_18ca;
									IL_24db:
									text3 = (string)obj;
									num4 = 43;
									continue;
								}
								if (!permissionRole.HasValue)
								{
									num4 = 71;
									continue;
								}
								if (permissionRole.HasValue)
								{
									num4 = 39;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6d48f3b4557a49578bf7f5ef0517e0be == 0)
									{
										num4 = 9;
									}
									continue;
								}
								goto IL_2002;
								IL_2392:
								if (permissionRole.HasValue)
								{
									if (!permissionRole.HasValue)
									{
										num4 = 22;
										continue;
									}
									if (permissionRole.GetValueOrDefault() == guid)
									{
										goto IL_2002;
									}
									goto IL_251b;
								}
								num4 = 75;
								continue;
								IL_18fe:
								propertyExpressionDescriptorWithInstanceUid2 = array.FirstOrDefault(_003C_003Ec__DisplayClass4_3._003CUpdateWorkflowRoleTypePermissions_003Eb__6);
								num4 = 54;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f == 0)
								{
									num4 = 29;
								}
								continue;
								IL_2002:
								propertyExpressionDescriptorWithInstanceUid = array.FirstOrDefault(_003C_003Ec__DisplayClass4_3._003CUpdateWorkflowRoleTypePermissions_003Eb__7);
								num4 = 46;
								continue;
								IL_2538:
								num4 = 55;
								continue;
								IL_20e6:
								if (permissionRole.HasValue)
								{
									if (!permissionRole.HasValue)
									{
										num4 = 2;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a23e27b648a042f098a477c26c4beed1 != 0)
										{
											num4 = 45;
										}
										continue;
									}
									if (qk7MkkqpfQPdyoDsvA7(permissionRole.GetValueOrDefault(), guid))
									{
										goto IL_18fe;
									}
									goto IL_2471;
								}
								num4 = 17;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bd84f42638494cb6b4427f8e13ec59af == 0)
								{
									num4 = 29;
								}
								continue;
								IL_251b:
								num4 = 59;
								continue;
								IL_236c:
								if (permissionRole.HasValue)
								{
									if (permissionRole.HasValue)
									{
										num4 = 72;
										continue;
									}
									goto IL_18fe;
								}
								num4 = 48;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9269d021c6f148b6a1c4afb8cee03b6c == 0)
								{
									num4 = 46;
								}
								continue;
								IL_18e4:
								guid = S4V9anqQfQlPFlWW5XZ(WorkflowRoleTypes.ProcessCurator);
								num3 = 3;
								goto IL_0a24;
								IL_2471:
								num4 = 83;
								continue;
								IL_233b:
								if (permissionRole.HasValue)
								{
									if (permissionRole.HasValue)
									{
										num4 = 1;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae4e393cddc4c98b9896b25c9e18c7d == 0)
										{
											num4 = 42;
										}
										continue;
									}
									goto IL_2538;
								}
								num4 = 26;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 == 0)
								{
									num4 = 19;
								}
								continue;
								end_IL_0a28:
								break;
							}
							goto IL_17dc;
							IL_17dc:
							_003C_003Ec__DisplayClass4_3 = new _003C_003Ec__DisplayClass4_5();
							num4 = 55;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c7fe5d092d804f7e91041fb2338cec1a == 0)
							{
								num4 = 67;
							}
							goto IL_0a28;
							IL_0a24:
							num4 = num3;
							goto IL_0a28;
							continue;
							end_IL_18ca:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num5 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f8ecc99a1f4a4b6abc73e9b50261ea83 == 0)
						{
							num5 = 0;
						}
						switch (num5)
						{
						case 0:
							break;
						}
					}
					goto case 10;
				case 21:
					_003C_003Ec__DisplayClass4_2 = new _003C_003Ec__DisplayClass4_1();
					num2 = 4;
					continue;
				case 6:
				case 14:
				case 19:
					array = zKKu9PqT6mKx03LLBLd(ComponentManager.Current.GetExtensionPointByType<WorkflowTaskPermissionProvider>()) as IPropertyExpressionDescriptorWithInstanceUid[];
					num2 = 16;
					continue;
				case 2:
					return;
				case 5:
					return;
				case 12:
					enumerator = value.GetEnumerator();
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9269d021c6f148b6a1c4afb8cee03b6c != 0)
					{
						num2 = 0;
					}
					continue;
				case 9:
					contextBoundVariableService.TryGetValue<HashSet<IProcessHeaderAccess>>((string)iBuu1eq30Mlxo9HASSU(-11799394 ^ -11848668), out value);
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_26fa47f5bd8343debcae8b05a56a3ab5 != 0)
					{
						num2 = 15;
					}
					continue;
				case 8:
					_003C_003Ec__DisplayClass4_ = new _003C_003Ec__DisplayClass4_0();
					num2 = 7;
					continue;
				case 3:
					enumerator = _003C_003Ec__DisplayClass4_.deleteProcHeaderAccess.GetEnumerator();
					num2 = 13;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9570b4a70465495fba22c942f586465a == 0)
					{
						num2 = 10;
					}
					continue;
				case 17:
					value.RemoveWhere(_003C_003Ec__DisplayClass4_2._003CUpdateWorkflowRoleTypePermissions_003Eb__2);
					num = 6;
					break;
				case 15:
					if (_003C_003Ec__DisplayClass4_.deleteProcHeaderAccess == null)
					{
						num = 19;
						break;
					}
					goto case 11;
				}
				break;
			}
		}
	}

	private void UpdateCommonRoleTypesPermissions()
	{
		//Discarded unreachable code: IL_01b9, IL_0217, IL_0226, IL_02e8, IL_02f7, IL_0306, IL_0338, IL_0347, IL_0352, IL_06a6, IL_06de, IL_06ed, IL_073a, IL_0749, IL_0759, IL_0768, IL_0779, IL_0788, IL_0793, IL_0b10, IL_0b1f, IL_0b2b, IL_0b3a, IL_0b66, IL_0b75, IL_0b85, IL_0bd2, IL_0cea, IL_0cf9, IL_0d7c, IL_0d8b, IL_0d96, IL_10c6, IL_10e5, IL_10f4, IL_1121, IL_1193, IL_11c3, IL_11d2, IL_1247, IL_1256, IL_1265, IL_128b, IL_129a, IL_1358, IL_1367, IL_1376
		int num = 30;
		string text6 = default(string);
		IPropertyExpressionDescriptorWithInstanceUid propertyExpressionDescriptorWithInstanceUid5 = default(IPropertyExpressionDescriptorWithInstanceUid);
		HashSet<IOrganizationItem> source = default(HashSet<IOrganizationItem>);
		_003C_003Ec__DisplayClass5_1 _003C_003Ec__DisplayClass5_ = default(_003C_003Ec__DisplayClass5_1);
		HashSet<IProcessHeaderAccess> value = default(HashSet<IProcessHeaderAccess>);
		_003C_003Ec__DisplayClass5_0 _003C_003Ec__DisplayClass5_2 = default(_003C_003Ec__DisplayClass5_0);
		string sql2 = default(string);
		IEnumerable<IProcessHeaderAccess> enumerable2 = default(IEnumerable<IProcessHeaderAccess>);
		IEnumerable<IProcessHeaderAccess> enumerable4 = default(IEnumerable<IProcessHeaderAccess>);
		IEnumerable<IProcessHeaderAccess> enumerable3 = default(IEnumerable<IProcessHeaderAccess>);
		IEnumerable<IProcessHeaderAccess> enumerable5 = default(IEnumerable<IProcessHeaderAccess>);
		IEnumerator<IProcessHeaderAccess> enumerator = default(IEnumerator<IProcessHeaderAccess>);
		IProcessHeaderAccess current3 = default(IProcessHeaderAccess);
		IEnumerable<IProcessHeaderAccess> enumerable6 = default(IEnumerable<IProcessHeaderAccess>);
		IProcessHeaderAccess current2 = default(IProcessHeaderAccess);
		string text4 = default(string);
		IPropertyExpressionDescriptorWithInstanceUid[] array = default(IPropertyExpressionDescriptorWithInstanceUid[]);
		IEnumerable<IProcessHeaderAccess> enumerable = default(IEnumerable<IProcessHeaderAccess>);
		IPropertyExpressionDescriptorWithInstanceUid propertyExpressionDescriptorWithInstanceUid4 = default(IPropertyExpressionDescriptorWithInstanceUid);
		string text5 = default(string);
		IPropertyExpressionDescriptorWithInstanceUid propertyExpressionDescriptorWithInstanceUid3 = default(IPropertyExpressionDescriptorWithInstanceUid);
		string sql = default(string);
		IProcessHeaderAccess current = default(IProcessHeaderAccess);
		string text = default(string);
		string text3 = default(string);
		IPropertyExpressionDescriptorWithInstanceUid propertyExpressionDescriptorWithInstanceUid2 = default(IPropertyExpressionDescriptorWithInstanceUid);
		IPropertyExpressionDescriptorWithInstanceUid propertyExpressionDescriptorWithInstanceUid = default(IPropertyExpressionDescriptorWithInstanceUid);
		string sql3 = default(string);
		IPropertyExpressionDescriptorWithInstanceUid propertyExpressionDescriptorWithInstanceUid6 = default(IPropertyExpressionDescriptorWithInstanceUid);
		string text2 = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 50:
					text6 = string.Format((string)iBuu1eq30Mlxo9HASSU(0xA7339EE ^ 0xA73F3FE), propertyExpressionDescriptorWithInstanceUid5.Name);
					num2 = 14;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae4e393cddc4c98b9896b25c9e18c7d == 0)
					{
						num2 = 18;
					}
					continue;
				case 45:
					source = new HashSet<IOrganizationItem>();
					num2 = 73;
					continue;
				case 24:
					_003C_003Ec__DisplayClass5_.copyInsertPermissions = value.Where(_003C_003Ec__DisplayClass5_2._003CUpdateCommonRoleTypesPermissions_003Eb__0);
					num2 = 83;
					continue;
				case 61:
					transformationProvider.ExecuteNonQuery(sql2);
					num2 = 22;
					continue;
				case 62:
					if (enumerable2 != null)
					{
						num2 = 17;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 != 0)
						{
							num2 = 15;
						}
						continue;
					}
					goto case 6;
				case 77:
					if (enumerable4.Count() <= 0)
					{
						num2 = 21;
						continue;
					}
					goto case 43;
				case 1:
					if (enumerable3 != null)
					{
						num2 = 28;
						continue;
					}
					return;
				case 39:
					if (enumerable5 == null)
					{
						num2 = 41;
						continue;
					}
					goto case 58;
				case 42:
					if (_003C_003Ec__DisplayClass5_2.deleteProcHeaderAccess != null)
					{
						num2 = 46;
						continue;
					}
					goto case 10;
				case 30:
					_003C_003Ec__DisplayClass5_2 = new _003C_003Ec__DisplayClass5_0();
					num2 = 20;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 == 0)
					{
						num2 = 29;
					}
					continue;
				case 72:
					if (propertyExpressionDescriptorWithInstanceUid5 == null)
					{
						num2 = 32;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede == 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 50;
				case 10:
					if (value != null)
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 == 0)
						{
							num2 = 5;
						}
						continue;
					}
					return;
				case 14:
					try
					{
						while (true)
						{
							IL_0393:
							int num8;
							if (!dgAv2pqSfYtY8Nulk0T(enumerator))
							{
								num8 = 2;
								goto IL_0356;
							}
							goto IL_0370;
							IL_0356:
							while (true)
							{
								switch (num8)
								{
								case 1:
									goto IL_0393;
								case 3:
									transformationProvider.Insert((string)iBuu1eq30Mlxo9HASSU(-10408775 ^ -10360603), new string[5]
									{
										SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-961162596 ^ -961178400),
										SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4943E3E4 ^ 0x494325E6),
										(string)iBuu1eq30Mlxo9HASSU(0xDF4D1F8 ^ 0xDF41416),
										(string)iBuu1eq30Mlxo9HASSU(-1965291699 ^ -1965244065),
										(string)iBuu1eq30Mlxo9HASSU(0x65B7F624 ^ 0x65B732A0)
									}, (string)IS1xeuq25wLEN6Vcs2Y(iBuu1eq30Mlxo9HASSU(-865213812 ^ -865268284), new object[4]
									{
										jMEHG0qiGxZfOOSpv7f(oAK7Q0qk6VT2CXNiJrA(transformationProvider)),
										mfHBxUqA9PjnQdPv2bK(transformationProvider.Dialect),
										text6,
										AuFkoAq4eorPbd2CiTk((cBakRoqEBnjrypIkuRt(current3) != null) ? ((IEntity<long>)cBakRoqEBnjrypIkuRt(current3)).Id : ((IEntity<long>)EBOmVBqwfjn5XpaRwB4(current3)).Id)
									}), (string)IS1xeuq25wLEN6Vcs2Y(iBuu1eq30Mlxo9HASSU(-790221436 ^ -790182364), new object[11]
									{
										tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), iBuu1eq30Mlxo9HASSU(-1498811449 ^ -1498858999)),
										tlC11aqUCIT1wvlp1BG(transformationProvider.Dialect, iBuu1eq30Mlxo9HASSU(0x1145BED7 ^ 0x1145D4ED)),
										((Dialect)oAK7Q0qk6VT2CXNiJrA(transformationProvider)).GuidToCharFromSql((string)iBuu1eq30Mlxo9HASSU(0x6CC04061 ^ 0x6CC0061D)),
										tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x8D5763A ^ 0x8D530BC)),
										((Dialect)oAK7Q0qk6VT2CXNiJrA(transformationProvider)).QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-22348816 ^ -22370872)),
										tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), iBuu1eq30Mlxo9HASSU(-684210684 ^ -684220754)),
										tlC11aqUCIT1wvlp1BG(transformationProvider.Dialect, iBuu1eq30Mlxo9HASSU(-768800937 ^ -768796717)),
										tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), iBuu1eq30Mlxo9HASSU(-683713632 ^ -683729756)),
										tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), iBuu1eq30Mlxo9HASSU(-14356676 ^ -14383190)),
										((Dialect)oAK7Q0qk6VT2CXNiJrA(transformationProvider)).QuoteIfNeeded((string)iBuu1eq30Mlxo9HASSU(-1965291699 ^ -1965276879)),
										current3.ProcessHeader.Id
									}), isNeedInsertId: true);
									num8 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f453500aaab143479696408f48a03c17 == 0)
									{
										num8 = 1;
									}
									continue;
								case 2:
									return;
								}
								break;
							}
							goto IL_0370;
							IL_0370:
							current3 = enumerator.Current;
							num8 = 3;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea == 0)
							{
								num8 = 3;
							}
							goto IL_0356;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							int num9 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_85ba8d91af394836ac86666c40b1e150 != 0)
							{
								num9 = 0;
							}
							while (true)
							{
								switch (num9)
								{
								default:
									E5Ga18q1iYFj2q32LxS(enumerator);
									num9 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c7fe5d092d804f7e91041fb2338cec1a != 0)
									{
										num9 = 0;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
				case 5:
					if (Yy9IK0qen7kKWM7yX1d(value) <= 0)
					{
						num2 = 42;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cb262bcfe4074a1ab16e653815d57f28 != 0)
						{
							num2 = 82;
						}
						continue;
					}
					goto case 19;
				case 8:
					if (enumerable6.Count() <= 0)
					{
						num2 = 55;
						continue;
					}
					goto case 56;
				case 13:
					try
					{
						while (true)
						{
							IL_0a90:
							int num5;
							if (!dgAv2pqSfYtY8Nulk0T(enumerator))
							{
								num5 = 3;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe7a0ffe67e4fea8e329ae6574ed2ca != 0)
								{
									num5 = 1;
								}
								goto IL_0797;
							}
							goto IL_07b1;
							IL_07b1:
							current2 = enumerator.Current;
							num5 = 2;
							goto IL_0797;
							IL_0797:
							while (true)
							{
								switch (num5)
								{
								case 2:
									transformationProvider.Insert((string)iBuu1eq30Mlxo9HASSU(-684210684 ^ -684260776), new string[5]
									{
										(string)iBuu1eq30Mlxo9HASSU(0x12F686A ^ 0x12F2E16),
										(string)iBuu1eq30Mlxo9HASSU(-772614310 ^ -772665000),
										(string)iBuu1eq30Mlxo9HASSU(-1638225214 ^ -1638240468),
										(string)iBuu1eq30Mlxo9HASSU(-720457373 ^ -720472207),
										(string)iBuu1eq30Mlxo9HASSU(0x37E97159 ^ 0x37E9B5DD)
									}, (string)IS1xeuq25wLEN6Vcs2Y(iBuu1eq30Mlxo9HASSU(0x2ACCDD87 ^ 0x2ACC371B), new object[5]
									{
										((Dialect)oAK7Q0qk6VT2CXNiJrA(transformationProvider)).GenUid(),
										mfHBxUqA9PjnQdPv2bK(oAK7Q0qk6VT2CXNiJrA(transformationProvider)),
										((IEntity<long>)gBkOl7qxydO97hTNvbM(current2)).Id,
										text4,
										UserSecuritySetHelper.GetUserMask(((IEntity<long>)gBkOl7qxydO97hTNvbM(current2)).Id)
									}), (string)IS1xeuq25wLEN6Vcs2Y(iBuu1eq30Mlxo9HASSU(-1657582555 ^ -1657559163), new object[11]
									{
										tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), iBuu1eq30Mlxo9HASSU(-865213812 ^ -865260734)),
										tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), iBuu1eq30Mlxo9HASSU(0x13F63440 ^ 0x13F65E7A)),
										FPIEq9qNVh5gd9ExLbt(oAK7Q0qk6VT2CXNiJrA(transformationProvider), iBuu1eq30Mlxo9HASSU(-39189604 ^ -39172640)),
										tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), iBuu1eq30Mlxo9HASSU(-1516552726 ^ -1516536980)),
										((Dialect)oAK7Q0qk6VT2CXNiJrA(transformationProvider)).QuoteIfNeeded((string)iBuu1eq30Mlxo9HASSU(0x1EA50FCC ^ 0x1EA551F4)),
										tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), iBuu1eq30Mlxo9HASSU(-432000546 ^ -431986316)),
										tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), iBuu1eq30Mlxo9HASSU(0xDF4D1F8 ^ 0xDF4C17C)),
										((Dialect)oAK7Q0qk6VT2CXNiJrA(transformationProvider)).QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x42311138 ^ 0x4231563C)),
										tlC11aqUCIT1wvlp1BG(transformationProvider.Dialect, iBuu1eq30Mlxo9HASSU(0x37F755F5 ^ 0x37F73D63)),
										tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-684210684 ^ -684228488)),
										current2.ProcessHeader.Id
									}), isNeedInsertId: true);
									num5 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 == 0)
									{
										num5 = 0;
									}
									continue;
								case 1:
									goto IL_0a90;
								case 3:
									goto end_IL_0a90;
								}
								break;
							}
							goto IL_07b1;
							continue;
							end_IL_0a90:
							break;
						}
					}
					finally
					{
						int num7;
						if (enumerator == null)
						{
							int num6 = 2;
							num7 = num6;
							goto IL_0ad4;
						}
						goto IL_0aea;
						IL_0ad4:
						switch (num7)
						{
						default:
							goto end_IL_0abb;
						case 1:
							break;
						case 2:
							goto end_IL_0abb;
						case 0:
							goto end_IL_0abb;
						}
						goto IL_0aea;
						IL_0aea:
						E5Ga18q1iYFj2q32LxS(enumerator);
						num7 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_60c5782a184b457aa78da2e5c62d4e27 == 0)
						{
							num7 = 0;
						}
						goto IL_0ad4;
						end_IL_0abb:;
					}
					goto case 54;
				case 80:
					if (_003C_003Ec__DisplayClass5_.copyInsertPermissions.Count() <= 0)
					{
						num2 = 53;
						continue;
					}
					goto case 23;
				case 28:
					if (enumerable3.Count() <= 0)
					{
						num = 37;
						break;
					}
					goto case 33;
				case 75:
					enumerator = enumerable4.GetEnumerator();
					num2 = 80;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d == 0)
					{
						num2 = 81;
					}
					continue;
				case 17:
					if (enumerable2.Count() <= 0)
					{
						num2 = 9;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_160bffb148c14c5da92d8d6ddf481bdc != 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 67;
				case 3:
				case 53:
				case 59:
				case 87:
					array = zKKu9PqT6mKx03LLBLd(ComponentManager.Current.GetExtensionPointByType<WorkflowTaskPermissionProvider>()) as IPropertyExpressionDescriptorWithInstanceUid[];
					num2 = 4;
					continue;
				case 4:
					if (_003C_003Ec__DisplayClass5_2.deleteProcHeaderAccess == null)
					{
						num2 = 65;
						continue;
					}
					goto case 71;
				case 69:
					_003C_003Ec__DisplayClass5_2.deleteProcHeaderAccess.RemoveWhere(_003C_003Ec__DisplayClass5_._003CUpdateCommonRoleTypesPermissions_003Eb__1);
					num2 = 87;
					continue;
				case 35:
					if (enumerable == null)
					{
						num2 = 60;
						continue;
					}
					goto case 86;
				case 15:
					return;
				case 32:
					return;
				case 37:
					return;
				case 82:
					return;
				case 7:
					text4 = (string)IWi4eyqMugtnldDqsog(iBuu1eq30Mlxo9HASSU(0x37E97159 ^ 0x37E9BB49), lP2UlGqCiaEnIOmRvWL(propertyExpressionDescriptorWithInstanceUid4));
					num2 = 18;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4ef74b4b7d13430e9d2f9b78cbdb367b == 0)
					{
						num2 = 26;
					}
					continue;
				case 57:
					text5 = string.Format((string)iBuu1eq30Mlxo9HASSU(0x6F6D7B44 ^ 0x6F6DB154), propertyExpressionDescriptorWithInstanceUid3.Name);
					num2 = 24;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_938c6be4ea2248868d7ed5d0e3346006 != 0)
					{
						num2 = 74;
					}
					continue;
				case 11:
					transformationProvider.ExecuteNonQuery(sql);
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d == 0)
					{
						num2 = 6;
					}
					continue;
				case 83:
					if (_003C_003Ec__DisplayClass5_.copyInsertPermissions == null)
					{
						num2 = 3;
						continue;
					}
					goto case 80;
				case 29:
					contextBoundVariableService.TryGetValue<HashSet<IProcessHeaderAccess>>((string)iBuu1eq30Mlxo9HASSU(0x6C7F14 ^ 0x6CBE6E), out _003C_003Ec__DisplayClass5_2.deleteProcHeaderAccess);
					num2 = 48;
					continue;
				case 81:
					try
					{
						while (true)
						{
							IL_107a:
							int num3;
							if (!dgAv2pqSfYtY8Nulk0T(enumerator))
							{
								num3 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 == 0)
								{
									num3 = 0;
								}
								goto IL_0d9a;
							}
							goto IL_1057;
							IL_1057:
							current = enumerator.Current;
							num3 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ac5d16a577a84bb0b8ee3654769d2d33 == 0)
							{
								num3 = 1;
							}
							goto IL_0d9a;
							IL_0d9a:
							while (true)
							{
								switch (num3)
								{
								case 1:
									transformationProvider.Insert((string)iBuu1eq30Mlxo9HASSU(-2057730233 ^ -2057747685), new string[5]
									{
										(string)iBuu1eq30Mlxo9HASSU(0x37F755F5 ^ 0x37F71389),
										(string)iBuu1eq30Mlxo9HASSU(-2077784392 ^ -2077802310),
										(string)iBuu1eq30Mlxo9HASSU(-1028861977 ^ -1028912631),
										(string)iBuu1eq30Mlxo9HASSU(--1418337216 ^ 0x548ADDD2),
										(string)iBuu1eq30Mlxo9HASSU(-1657582555 ^ -1657567071)
									}, (string)IS1xeuq25wLEN6Vcs2Y(iBuu1eq30Mlxo9HASSU(-801808857 ^ -801787537), new object[4]
									{
										jMEHG0qiGxZfOOSpv7f(oAK7Q0qk6VT2CXNiJrA(transformationProvider)),
										mfHBxUqA9PjnQdPv2bK(transformationProvider.Dialect),
										text,
										UserSecuritySetHelper.GetGroupMask(((IEntity<long>)IPGIJjqhHR5lGTpgJx9(current)).Id)
									}), (string)IS1xeuq25wLEN6Vcs2Y(iBuu1eq30Mlxo9HASSU(-22348816 ^ -22409136), new object[11]
									{
										tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398691253 ^ -398672507)),
										tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), iBuu1eq30Mlxo9HASSU(0x361628FF ^ 0x361642C5)),
										FPIEq9qNVh5gd9ExLbt(oAK7Q0qk6VT2CXNiJrA(transformationProvider), iBuu1eq30Mlxo9HASSU(-1716458555 ^ -1716474439)),
										tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), iBuu1eq30Mlxo9HASSU(0x1927DA93 ^ 0x19279C15)),
										tlC11aqUCIT1wvlp1BG(transformationProvider.Dialect, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x157D5AF4 ^ 0x157D04CC)),
										tlC11aqUCIT1wvlp1BG(transformationProvider.Dialect, iBuu1eq30Mlxo9HASSU(0xA7339EE ^ 0xA736144)),
										((Dialect)oAK7Q0qk6VT2CXNiJrA(transformationProvider)).QuoteIfNeeded((string)iBuu1eq30Mlxo9HASSU(-197778752 ^ -197774780)),
										tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x738ABA6E ^ 0x738AFD6A)),
										tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), iBuu1eq30Mlxo9HASSU(0x1134D2C0 ^ 0x1134BA56)),
										tlC11aqUCIT1wvlp1BG(transformationProvider.Dialect, iBuu1eq30Mlxo9HASSU(-261315199 ^ -261299203)),
										((IEntity<long>)YbMg3vq7m9ZtAeXsG0R(current)).Id
									}), isNeedInsertId: true);
									num3 = 3;
									continue;
								case 2:
									goto IL_1057;
								case 3:
									goto IL_107a;
								case 0:
									break;
								}
								break;
							}
							break;
						}
					}
					finally
					{
						int num4;
						if (enumerator == null)
						{
							num4 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_60c5782a184b457aa78da2e5c62d4e27 == 0)
							{
								num4 = 1;
							}
							goto IL_10ca;
						}
						goto IL_10ff;
						IL_10ff:
						E5Ga18q1iYFj2q32LxS(enumerator);
						num4 = 2;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_46e05b4e09174e34a9c81741b8b77a2f != 0)
						{
							num4 = 2;
						}
						goto IL_10ca;
						IL_10ca:
						switch (num4)
						{
						case 1:
							goto end_IL_10a5;
						case 2:
							goto end_IL_10a5;
						}
						goto IL_10ff;
						end_IL_10a5:;
					}
					goto case 21;
				case 58:
					if (enumerable5.Count() <= 0)
					{
						num2 = 78;
						continue;
					}
					goto case 52;
				case 26:
					enumerator = enumerable.GetEnumerator();
					num2 = 13;
					continue;
				case 12:
					text3 = (string)IWi4eyqMugtnldDqsog(iBuu1eq30Mlxo9HASSU(0x4FD00585 ^ 0x4FD0CF95), lP2UlGqCiaEnIOmRvWL(propertyExpressionDescriptorWithInstanceUid2));
					num2 = 20;
					continue;
				case 64:
					if (array == null)
					{
						num2 = 68;
						continue;
					}
					goto case 12;
				case 31:
					if (propertyExpressionDescriptorWithInstanceUid == null)
					{
						num2 = 11;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 != 0)
						{
							num2 = 51;
						}
						continue;
					}
					goto case 49;
				case 19:
				case 47:
					_003C_003Ec__DisplayClass5_ = new _003C_003Ec__DisplayClass5_1();
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 == 0)
					{
						num2 = 0;
					}
					continue;
				case 86:
					if (enumerable.Count() <= 0)
					{
						num = 70;
						break;
					}
					goto case 38;
				case 79:
					transformationProvider.ExecuteNonQuery(sql3);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 != 0)
					{
						num2 = 16;
					}
					continue;
				default:
					if (_003C_003Ec__DisplayClass5_2.deleteProcHeaderAccess == null)
					{
						num2 = 59;
						continue;
					}
					goto case 44;
				case 23:
					value.RemoveAll(_003C_003Ec__DisplayClass5_.copyInsertPermissions);
					num2 = 69;
					continue;
				case 6:
				case 9:
				case 65:
				case 66:
					if (value == null)
					{
						return;
					}
					num2 = 25;
					continue;
				case 34:
					if (propertyExpressionDescriptorWithInstanceUid3 != null)
					{
						num2 = 57;
						continue;
					}
					goto case 22;
				case 27:
					if (enumerable4 != null)
					{
						num = 77;
						break;
					}
					goto case 21;
				case 40:
					if (propertyExpressionDescriptorWithInstanceUid4 != null)
					{
						num = 7;
						break;
					}
					goto case 54;
				case 48:
					contextBoundVariableService.TryGetValue<HashSet<IProcessHeaderAccess>>((string)iBuu1eq30Mlxo9HASSU(0x5BCD23A0 ^ 0x5BCD9C5E), out value);
					num2 = 42;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f453500aaab143479696408f48a03c17 != 0)
					{
						num2 = 28;
					}
					continue;
				case 44:
					if (value != null)
					{
						num2 = 24;
						continue;
					}
					goto case 3;
				case 49:
					text = (string)IWi4eyqMugtnldDqsog(iBuu1eq30Mlxo9HASSU(0x5F800F5B ^ 0x5F80C54B), lP2UlGqCiaEnIOmRvWL(propertyExpressionDescriptorWithInstanceUid));
					num2 = 75;
					continue;
				case 85:
					if (propertyExpressionDescriptorWithInstanceUid6 == null)
					{
						num2 = 66;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_448e6815cb30438893079dcbb906fd65 == 0)
						{
							num2 = 37;
						}
						continue;
					}
					goto case 36;
				case 46:
					if (Yy9IK0qen7kKWM7yX1d(_003C_003Ec__DisplayClass5_2.deleteProcHeaderAccess) > 0)
					{
						num2 = 19;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_448e6815cb30438893079dcbb906fd65 == 0)
						{
							num2 = 13;
						}
						continue;
					}
					goto case 10;
				case 2:
					if (enumerable6 != null)
					{
						num2 = 8;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a == 0)
						{
							num2 = 8;
						}
						continue;
					}
					goto case 16;
				case 18:
					enumerator = enumerable3.GetEnumerator();
					num2 = 14;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5d3bc916b5664717ac60544de077bd16 != 0)
					{
						num2 = 0;
					}
					continue;
				case 36:
					text2 = (string)IWi4eyqMugtnldDqsog(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x63D6C913 ^ 0x63D60303), lP2UlGqCiaEnIOmRvWL(propertyExpressionDescriptorWithInstanceUid6));
					num2 = 45;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede == 0)
					{
						num2 = 44;
					}
					continue;
				case 71:
					enumerable6 = _003C_003Ec__DisplayClass5_2.deleteProcHeaderAccess.Where(delegate(IProcessHeaderAccess p)
					{
						//Discarded unreachable code: IL_005b, IL_006a
						int num18 = 4;
						Guid? permissionRole2 = default(Guid?);
						Guid guid = default(Guid);
						while (true)
						{
							int num19 = num18;
							while (true)
							{
								switch (num19)
								{
								case 4:
									permissionRole2 = p.PermissionRole;
									num19 = 2;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5c45a6e5a4614bfba7591d8a1c7ced1d == 0)
									{
										num19 = 3;
									}
									continue;
								case 3:
									guid = _003C_003Ec.RjScrqZAXhffGU9BkHD0(CommonRoleTypes.User);
									num19 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1c37d4e24e094858975336738e156495 != 0)
									{
										num19 = 1;
									}
									continue;
								default:
									return false;
								case 2:
									if (!permissionRole2.HasValue)
									{
										num19 = 5;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8a6cf36da0b84f319a7cf27018f28f5b != 0)
										{
											num19 = 0;
										}
										continue;
									}
									return _003C_003Ec.BtZQQYZAdGIIYKFwKlxf(permissionRole2.GetValueOrDefault(), guid);
								case 5:
									return true;
								case 1:
									if (permissionRole2.HasValue)
									{
										break;
									}
									goto default;
								}
								break;
							}
							num18 = 2;
						}
					});
					num2 = 2;
					continue;
				case 56:
					propertyExpressionDescriptorWithInstanceUid2 = array.FirstOrDefault(delegate(IPropertyExpressionDescriptorWithInstanceUid e)
					{
						//Discarded unreachable code: IL_006f, IL_007e
						int num22 = 1;
						int num23 = num22;
						while (true)
						{
							switch (num23)
							{
							case 1:
								if (_003C_003Ec.eQcjXIZAuTPfE0xTNI9c(e) == null)
								{
									num23 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58fb165cafed422d973d4a7156526541 == 0)
									{
										num23 = 0;
									}
									break;
								}
								goto case 2;
							case 2:
								return _003C_003Ec.RjScrqZAXhffGU9BkHD0(e.RoleType) == _003C_003Ec.RjScrqZAXhffGU9BkHD0(CommonRoleTypes.User);
							default:
								return false;
							}
						}
					});
					num2 = 7;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0991fd79553c4ecc82e8b5cb79c2bff2 == 0)
					{
						num2 = 64;
					}
					continue;
				case 20:
					sql3 = (string)IS1xeuq25wLEN6Vcs2Y(iBuu1eq30Mlxo9HASSU(0x51EF0063 ^ 0x51EFE82D), new object[14]
					{
						tlC11aqUCIT1wvlp1BG(transformationProvider.Dialect, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x141C968 ^ 0x1410D34)),
						((Dialect)oAK7Q0qk6VT2CXNiJrA(transformationProvider)).QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x56F860D7 ^ 0x56F8A539)),
						((Dialect)oAK7Q0qk6VT2CXNiJrA(transformationProvider)).QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2122743969 ^ -2122761949)),
						((Dialect)oAK7Q0qk6VT2CXNiJrA(transformationProvider)).QuoteIfNeeded((string)iBuu1eq30Mlxo9HASSU(-980570076 ^ -980555634)),
						((Dialect)oAK7Q0qk6VT2CXNiJrA(transformationProvider)).QuoteIfNeeded((string)iBuu1eq30Mlxo9HASSU(-398691253 ^ -398710157)),
						tlC11aqUCIT1wvlp1BG(transformationProvider.Dialect, iBuu1eq30Mlxo9HASSU(-1542190822 ^ -1542173154)),
						tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), iBuu1eq30Mlxo9HASSU(0x75BAD659 ^ 0x75BABECF)),
						tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), iBuu1eq30Mlxo9HASSU(0x5F800F5B ^ 0x5F80CBDF)),
						mfHBxUqA9PjnQdPv2bK(oAK7Q0qk6VT2CXNiJrA(transformationProvider)),
						FPIEq9qNVh5gd9ExLbt(transformationProvider.Dialect, iBuu1eq30Mlxo9HASSU(-1712492721 ^ -1712510669)),
						string.Join(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-25709590 ^ -25732738), enumerable6.Select((IProcessHeaderAccess x) => (string)_003C_003Ec.tKbKIbZAnpRrX2r7uNo7(((IEntity<long>)_003C_003Ec.bCa2sMZADxiUoZDiEN7S(x)).Id))),
						string.Join(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2111219045 ^ -2111197169), enumerable6.Select((IProcessHeaderAccess x) => (string)_003C_003Ec.tKbKIbZAnpRrX2r7uNo7(UserSecuritySetHelper.GetUserMask(x.User.Id)))),
						text3,
						tlC11aqUCIT1wvlp1BG(transformationProvider.Dialect, iBuu1eq30Mlxo9HASSU(-790221436 ^ -790205694))
					});
					num2 = 44;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_805f3361d2ba4dac8da4174f89314253 == 0)
					{
						num2 = 79;
					}
					continue;
				case 16:
				case 55:
				case 68:
					enumerable5 = _003C_003Ec__DisplayClass5_2.deleteProcHeaderAccess.Where(delegate(IProcessHeaderAccess p)
					{
						int num20 = 4;
						int num21 = num20;
						Guid? permissionRole3 = default(Guid?);
						Guid guid2 = default(Guid);
						while (true)
						{
							switch (num21)
							{
							case 1:
								return false;
							case 2:
								if (permissionRole3.HasValue)
								{
									if (permissionRole3.HasValue)
									{
										return _003C_003Ec.BtZQQYZAdGIIYKFwKlxf(permissionRole3.GetValueOrDefault(), guid2);
									}
									num21 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 == 0)
									{
										num21 = 0;
									}
								}
								else
								{
									num21 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c447ffb64be44c09b6fd398df506785b != 0)
									{
										num21 = 0;
									}
								}
								break;
							default:
								return true;
							case 3:
								guid2 = _003C_003Ec.RjScrqZAXhffGU9BkHD0(CommonRoleTypes.Group);
								num21 = 2;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bf623f11574746d6bf3837b66460c576 != 0)
								{
									num21 = 2;
								}
								break;
							case 4:
								permissionRole3 = p.PermissionRole;
								num21 = 2;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d87d9a74c9e14f96a288cc3620965fe0 == 0)
								{
									num21 = 3;
								}
								break;
							}
						}
					});
					num = 39;
					break;
				case 52:
					propertyExpressionDescriptorWithInstanceUid3 = array.FirstOrDefault(delegate(IPropertyExpressionDescriptorWithInstanceUid e)
					{
						//Discarded unreachable code: IL_006f, IL_007e
						int num16 = 1;
						int num17 = num16;
						while (true)
						{
							switch (num17)
							{
							case 2:
								return _003C_003Ec.BtZQQYZAdGIIYKFwKlxf(_003C_003Ec.RjScrqZAXhffGU9BkHD0(e.RoleType), _003C_003Ec.RjScrqZAXhffGU9BkHD0(CommonRoleTypes.Group));
							default:
								return false;
							case 1:
								if (e.RoleType == null)
								{
									num17 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_558b46b4f4364838b08ac89d77f9a257 != 0)
									{
										num17 = 0;
									}
									break;
								}
								goto case 2;
							}
						}
					});
					num2 = 23;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_db8eb3e90ad546d4b05544ab6326a49f == 0)
					{
						num2 = 34;
					}
					continue;
				case 74:
					sql2 = (string)IS1xeuq25wLEN6Vcs2Y(iBuu1eq30Mlxo9HASSU(0x65B7F624 ^ 0x65B71E6A), new object[14]
					{
						tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x17F0C5A2 ^ 0x17F001FE)),
						tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), iBuu1eq30Mlxo9HASSU(-398691253 ^ -398675547)),
						((Dialect)oAK7Q0qk6VT2CXNiJrA(transformationProvider)).QuoteIfNeeded((string)iBuu1eq30Mlxo9HASSU(-106528299 ^ -106510423)),
						tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), iBuu1eq30Mlxo9HASSU(0x1AF6F1F2 ^ 0x1AF6A958)),
						tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), iBuu1eq30Mlxo9HASSU(-768800937 ^ -768779921)),
						transformationProvider.Dialect.QuoteIfNeeded((string)iBuu1eq30Mlxo9HASSU(-539998957 ^ -540016105)),
						tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), iBuu1eq30Mlxo9HASSU(-43932417 ^ -43922327)),
						((Dialect)oAK7Q0qk6VT2CXNiJrA(transformationProvider)).QuoteIfNeeded((string)iBuu1eq30Mlxo9HASSU(-2077784392 ^ -2077801924)),
						mfHBxUqA9PjnQdPv2bK(oAK7Q0qk6VT2CXNiJrA(transformationProvider)),
						transformationProvider.Dialect.GuidToCharFromSql(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6871CA ^ 0x6837B6)),
						string.Join((string)iBuu1eq30Mlxo9HASSU(-1028861977 ^ -1028905613), enumerable5.Select((IProcessHeaderAccess x) => (string)_003C_003Ec.tKbKIbZAnpRrX2r7uNo7(((IEntity<long>)_003C_003Ec.bCa2sMZADxiUoZDiEN7S(x)).Id))),
						string.Join(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-683713632 ^ -683691724), enumerable5.Select((IProcessHeaderAccess x) => (string)_003C_003Ec.tKbKIbZAnpRrX2r7uNo7(UserSecuritySetHelper.GetGroupMask(((IEntity<long>)_003C_003Ec.aj5mLmZAHl5AOAZDNKHB(x)).Id)))),
						text5,
						transformationProvider.Dialect.QuoteIfNeeded((string)iBuu1eq30Mlxo9HASSU(0x65B7F624 ^ 0x65B7B0A2))
					});
					num2 = 53;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4cc62744d0eb4cd68219b70dcad3e68e == 0)
					{
						num2 = 61;
					}
					continue;
				case 22:
				case 41:
				case 78:
					enumerable2 = _003C_003Ec__DisplayClass5_2.deleteProcHeaderAccess.Where(delegate(IProcessHeaderAccess p)
					{
						int num12 = 1;
						int num13 = num12;
						Guid id = default(Guid);
						Guid? permissionRole = default(Guid?);
						while (true)
						{
							switch (num13)
							{
							default:
								id = CommonRoleTypes.OrganizationItem.Id;
								num13 = 4;
								break;
							case 2:
								return false;
							case 4:
								if (permissionRole.HasValue)
								{
									if (permissionRole.HasValue)
									{
										return _003C_003Ec.BtZQQYZAdGIIYKFwKlxf(permissionRole.GetValueOrDefault(), id);
									}
									num13 = 3;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4459fbe344a947429d197733d274ef68 == 0)
									{
										num13 = 0;
									}
								}
								else
								{
									num13 = 2;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e8980a9fd9d44c20920ffa276900c96f != 0)
									{
										num13 = 2;
									}
								}
								break;
							case 1:
								permissionRole = p.PermissionRole;
								num13 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a == 0)
								{
									num13 = 0;
								}
								break;
							case 3:
								return true;
							}
						}
					});
					num2 = 62;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3ab79470996d472f815915b21f45aac1 == 0)
					{
						num2 = 14;
					}
					continue;
				case 67:
					propertyExpressionDescriptorWithInstanceUid6 = array.FirstOrDefault(delegate(IPropertyExpressionDescriptorWithInstanceUid e)
					{
						int num14 = 1;
						int num15 = num14;
						while (true)
						{
							switch (num15)
							{
							case 1:
								if (e.RoleType == null)
								{
									return false;
								}
								num15 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_639c11c7bb65456db9f29c9c42f28bf7 == 0)
								{
									num15 = 0;
								}
								break;
							default:
								return _003C_003Ec.BtZQQYZAdGIIYKFwKlxf(_003C_003Ec.RjScrqZAXhffGU9BkHD0(_003C_003Ec.eQcjXIZAuTPfE0xTNI9c(e)), _003C_003Ec.RjScrqZAXhffGU9BkHD0(CommonRoleTypes.OrganizationItem));
							}
						}
					});
					num2 = 85;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1c37d4e24e094858975336738e156495 == 0)
					{
						num2 = 29;
					}
					continue;
				case 73:
					source.AddAll(from x in enumerable2
						where x.OrganizationItem != null
						select (IOrganizationItem)_003C_003Ec.spy3PJZAL66UGiVGdv0X(x));
					num = 84;
					break;
				case 84:
					source.AddAll(from x in enumerable2
						where _003C_003Ec.qgOwyLZAfQ7IuAuoqQ4Y(x) != null
						select x.OrganizationItemPosition);
					num2 = 53;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4cc62744d0eb4cd68219b70dcad3e68e == 0)
					{
						num2 = 76;
					}
					continue;
				case 76:
					sql = (string)IS1xeuq25wLEN6Vcs2Y(iBuu1eq30Mlxo9HASSU(-1716458555 ^ -1716518005), new object[14]
					{
						tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x595C500A ^ 0x595C9456)),
						((Dialect)oAK7Q0qk6VT2CXNiJrA(transformationProvider)).QuoteIfNeeded((string)iBuu1eq30Mlxo9HASSU(-1716629332 ^ -1716611774)),
						tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), iBuu1eq30Mlxo9HASSU(-1214182792 ^ -1214166012)),
						tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), iBuu1eq30Mlxo9HASSU(0x738ABA6E ^ 0x738AE2C4)),
						((Dialect)oAK7Q0qk6VT2CXNiJrA(transformationProvider)).QuoteIfNeeded((string)iBuu1eq30Mlxo9HASSU(0x5F800F5B ^ 0x5F805163)),
						tlC11aqUCIT1wvlp1BG(transformationProvider.Dialect, iBuu1eq30Mlxo9HASSU(-2077784392 ^ -2077769284)),
						tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x37F755F5 ^ 0x37F73D63)),
						tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), iBuu1eq30Mlxo9HASSU(-539998957 ^ -539983465)),
						transformationProvider.Dialect.ConcatenateSymbol(),
						FPIEq9qNVh5gd9ExLbt(oAK7Q0qk6VT2CXNiJrA(transformationProvider), iBuu1eq30Mlxo9HASSU(0x7381F16B ^ 0x7381B717)),
						string.Join((string)iBuu1eq30Mlxo9HASSU(-2111219045 ^ -2111197169), enumerable2.Select((IProcessHeaderAccess x) => (string)_003C_003Ec.tKbKIbZAnpRrX2r7uNo7(((IEntity<long>)_003C_003Ec.bCa2sMZADxiUoZDiEN7S(x)).Id))),
						string.Join((string)iBuu1eq30Mlxo9HASSU(0x6CC04061 ^ 0x6CC0AAF5), source.Select((IOrganizationItem x) => (string)_003C_003Ec.tKbKIbZAnpRrX2r7uNo7(_003C_003Ec.V1QPRbZA90T3x8UXpS1P(x.Id)))),
						text2,
						tlC11aqUCIT1wvlp1BG(oAK7Q0qk6VT2CXNiJrA(transformationProvider), iBuu1eq30Mlxo9HASSU(0x17F0C5A2 ^ 0x17F08324))
					});
					num2 = 11;
					continue;
				case 25:
					enumerable = value.Where(delegate(IProcessHeaderAccess p)
					{
						//Discarded unreachable code: IL_0069, IL_0078
						int num32 = 5;
						Guid guid4 = default(Guid);
						Guid? permissionRole6 = default(Guid?);
						while (true)
						{
							int num33 = num32;
							while (true)
							{
								switch (num33)
								{
								case 4:
									guid4 = _003C_003Ec.RjScrqZAXhffGU9BkHD0(CommonRoleTypes.User);
									num33 = 2;
									break;
								case 2:
									if (!permissionRole6.HasValue)
									{
										goto end_IL_0012;
									}
									if (permissionRole6.HasValue)
									{
										num33 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_545887e65739480a965b7ddfab7d0632 == 0)
										{
											num33 = 1;
										}
										break;
									}
									goto default;
								case 3:
									return false;
								default:
									return true;
								case 1:
									return _003C_003Ec.BtZQQYZAdGIIYKFwKlxf(permissionRole6.GetValueOrDefault(), guid4);
								case 5:
									permissionRole6 = p.PermissionRole;
									num33 = 4;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c7fe5d092d804f7e91041fb2338cec1a != 0)
									{
										num33 = 3;
									}
									break;
								}
								continue;
								end_IL_0012:
								break;
							}
							num32 = 3;
						}
					});
					num2 = 27;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 == 0)
					{
						num2 = 35;
					}
					continue;
				case 38:
					propertyExpressionDescriptorWithInstanceUid4 = array.FirstOrDefault(delegate(IPropertyExpressionDescriptorWithInstanceUid e)
					{
						//Discarded unreachable code: IL_006f, IL_007e
						int num24 = 2;
						int num25 = num24;
						while (true)
						{
							switch (num25)
							{
							default:
								return _003C_003Ec.BtZQQYZAdGIIYKFwKlxf(_003C_003Ec.RjScrqZAXhffGU9BkHD0(e.RoleType), _003C_003Ec.RjScrqZAXhffGU9BkHD0(CommonRoleTypes.User));
							case 1:
								return false;
							case 2:
								if (_003C_003Ec.eQcjXIZAuTPfE0xTNI9c(e) == null)
								{
									num25 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5d3bc916b5664717ac60544de077bd16 != 0)
									{
										num25 = 0;
									}
									break;
								}
								goto default;
							}
						}
					});
					num2 = 40;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a27e75af798c48d692c4325f43aa9e6b == 0)
					{
						num2 = 12;
					}
					continue;
				case 54:
				case 60:
				case 70:
					enumerable4 = value.Where(delegate(IProcessHeaderAccess p)
					{
						//Discarded unreachable code: IL_0086
						int num28 = 1;
						int num29 = num28;
						Guid guid3 = default(Guid);
						Guid? permissionRole4 = default(Guid?);
						while (true)
						{
							switch (num29)
							{
							case 4:
								return true;
							default:
								guid3 = _003C_003Ec.RjScrqZAXhffGU9BkHD0(CommonRoleTypes.Group);
								num29 = 2;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 == 0)
								{
									num29 = 0;
								}
								break;
							case 2:
								if (permissionRole4.HasValue)
								{
									num29 = 5;
									break;
								}
								goto case 3;
							case 1:
								permissionRole4 = p.PermissionRole;
								num29 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c != 0)
								{
									num29 = 0;
								}
								break;
							case 3:
								return false;
							case 5:
								if (permissionRole4.HasValue)
								{
									return permissionRole4.GetValueOrDefault() == guid3;
								}
								num29 = 4;
								break;
							}
						}
					});
					num2 = 27;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae2bde9e5844c638021cdb56fc01122 != 0)
					{
						num2 = 26;
					}
					continue;
				case 43:
					propertyExpressionDescriptorWithInstanceUid = array.FirstOrDefault(delegate(IPropertyExpressionDescriptorWithInstanceUid e)
					{
						int num26 = 1;
						int num27 = num26;
						while (true)
						{
							switch (num27)
							{
							case 1:
								if (_003C_003Ec.eQcjXIZAuTPfE0xTNI9c(e) == null)
								{
									return false;
								}
								num27 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_08023922bb0e4e809e5cff73a2b04988 == 0)
								{
									num27 = 0;
								}
								break;
							default:
								return _003C_003Ec.BtZQQYZAdGIIYKFwKlxf(_003C_003Ec.RjScrqZAXhffGU9BkHD0(_003C_003Ec.eQcjXIZAuTPfE0xTNI9c(e)), CommonRoleTypes.Group.Id);
							}
						}
					});
					num2 = 31;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae4e393cddc4c98b9896b25c9e18c7d != 0)
					{
						num2 = 30;
					}
					continue;
				case 21:
				case 51:
				case 63:
					enumerable3 = value.Where(delegate(IProcessHeaderAccess p)
					{
						int num30 = 2;
						int num31 = num30;
						Guid? permissionRole5 = default(Guid?);
						Guid id2 = default(Guid);
						while (true)
						{
							switch (num31)
							{
							case 4:
								return true;
							case 3:
								return false;
							default:
								if (permissionRole5.HasValue)
								{
									if (permissionRole5.HasValue)
									{
										return _003C_003Ec.BtZQQYZAdGIIYKFwKlxf(permissionRole5.GetValueOrDefault(), id2);
									}
									num31 = 4;
								}
								else
								{
									num31 = 3;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ecf910d183864897a7c8ec77e01689a4 != 0)
									{
										num31 = 3;
									}
								}
								break;
							case 1:
								id2 = CommonRoleTypes.OrganizationItem.Id;
								num31 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e == 0)
								{
									num31 = 0;
								}
								break;
							case 2:
								permissionRole5 = p.PermissionRole;
								num31 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 == 0)
								{
									num31 = 1;
								}
								break;
							}
						}
					});
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a23e27b648a042f098a477c26c4beed1 == 0)
					{
						num2 = 0;
					}
					continue;
				case 33:
					propertyExpressionDescriptorWithInstanceUid5 = array.FirstOrDefault(delegate(IPropertyExpressionDescriptorWithInstanceUid e)
					{
						int num10 = 1;
						int num11 = num10;
						while (true)
						{
							switch (num11)
							{
							default:
								return _003C_003Ec.BtZQQYZAdGIIYKFwKlxf(_003C_003Ec.RjScrqZAXhffGU9BkHD0(e.RoleType), CommonRoleTypes.OrganizationItem.Id);
							case 1:
								if (_003C_003Ec.eQcjXIZAuTPfE0xTNI9c(e) == null)
								{
									return false;
								}
								num11 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ffb1346d351f436b84bb1e9954c3bfa8 == 0)
								{
									num11 = 0;
								}
								break;
							}
						}
					});
					num2 = 72;
					continue;
				}
				break;
			}
		}
	}

	public void OnDisposeUnitofWork(IUnitOfWork unitOfWork)
	{
	}

	public void OnPostCommitUnitofWork(IUnitOfWork unitOfWork)
	{
	}

	public void OnPostFlushUnitofWork(IUnitOfWork unitOfWork)
	{
	}

	public void OnPostRollbackUnitofWork(IUnitOfWork unitOfWork)
	{
	}

	public void OnPreFlushUnitofWork(IUnitOfWork unitOfWork, IEnumerable<object> entities)
	{
	}

	public void OnStartUnitofWork(IUnitOfWork unitOfWork)
	{
	}

	internal static bool IDt9kOq6Pi4GeyMAIOZ()
	{
		return lWGxFyqRdwNxA20aURy == null;
	}

	internal static WorkflowTaskBasePermissionUnitOfWorkListener nSE7W1qqEBER9puAyhF()
	{
		return lWGxFyqRdwNxA20aURy;
	}

	internal static object iBuu1eq30Mlxo9HASSU(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object zKKu9PqT6mKx03LLBLd(object P_0)
	{
		return ((ExpressionPermissionBase<IWorkflowTaskBase, ITaskBasePermission>)P_0).AccessExpressions;
	}

	internal static Guid S4V9anqQfQlPFlWW5XZ(object P_0)
	{
		return ((PermissionRoleType)P_0).Id;
	}

	internal static bool qk7MkkqpfQPdyoDsvA7(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static object lP2UlGqCiaEnIOmRvWL(object P_0)
	{
		return ((IPropertyExpressionDescriptor)P_0).Name;
	}

	internal static object IWi4eyqMugtnldDqsog(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static object oAK7Q0qk6VT2CXNiJrA(object P_0)
	{
		return ((ITransformationProvider)P_0).Dialect;
	}

	internal static object tlC11aqUCIT1wvlp1BG(object P_0, object P_1)
	{
		return ((Dialect)P_0).QuoteIfNeeded((string)P_1);
	}

	internal static object QoERJHqVp8QW3ftwtAM(object P_0, object P_1)
	{
		return ((Dialect)P_0).ConvertToInt64((string)P_1);
	}

	internal static object mfHBxUqA9PjnQdPv2bK(object P_0)
	{
		return ((Dialect)P_0).ConcatenateSymbol();
	}

	internal static object hShDL2qGZGwkMCmnPCX(object P_0, object P_1)
	{
		return ((Dialect)P_0).GuidToCharFromSqlWithoutQuote((string)P_1);
	}

	internal static object YbMg3vq7m9ZtAeXsG0R(object P_0)
	{
		return ((IProcessHeaderAccess)P_0).ProcessHeader;
	}

	internal static object IS1xeuq25wLEN6Vcs2Y(object P_0, object P_1)
	{
		return string.Format((string)P_0, (object[])P_1);
	}

	internal static long p24fEgqouNxrtxkVbAX()
	{
		return UserSecuritySetHelper.UserMask;
	}

	internal static long QqdkjYqFkncQE1IMKH5()
	{
		return UserSecuritySetHelper.OrganizationItemMask;
	}

	internal static object jMEHG0qiGxZfOOSpv7f(object P_0)
	{
		return ((Dialect)P_0).GenUid();
	}

	internal static object txHiveqIf4SaQr4qGtQ(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static object dYFMeIqayTkFSFo1dgf()
	{
		return UserManager.Instance;
	}

	internal static Guid rdvS82qroe7jnY68YPg(object P_0)
	{
		return ((IInstanceSettingsPermissionHolder)P_0).TypeRoleId;
	}

	internal static int Yy9IK0qen7kKWM7yX1d(object P_0)
	{
		return ((HashSet<IProcessHeaderAccess>)P_0).Count;
	}

	internal static object FPIEq9qNVh5gd9ExLbt(object P_0, object P_1)
	{
		return ((Dialect)P_0).GuidToCharFromSql((string)P_1);
	}

	internal static object gBkOl7qxydO97hTNvbM(object P_0)
	{
		return ((IProcessHeaderAccess)P_0).User;
	}

	internal static bool dgAv2pqSfYtY8Nulk0T(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void E5Ga18q1iYFj2q32LxS(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object IPGIJjqhHR5lGTpgJx9(object P_0)
	{
		return ((IProcessHeaderAccess)P_0).Group;
	}

	internal static object cBakRoqEBnjrypIkuRt(object P_0)
	{
		return ((IProcessHeaderAccess)P_0).OrganizationItem;
	}

	internal static object EBOmVBqwfjn5XpaRwB4(object P_0)
	{
		return ((IProcessHeaderAccess)P_0).OrganizationItemPosition;
	}

	internal static long AuFkoAq4eorPbd2CiTk(long P_0)
	{
		return UserSecuritySetHelper.GetOrganizationItemMask(P_0);
	}
}
