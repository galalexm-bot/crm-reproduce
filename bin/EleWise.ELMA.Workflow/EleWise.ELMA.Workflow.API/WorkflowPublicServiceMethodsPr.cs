using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Actions;
using EleWise.ELMA.API.Models;
using EleWise.ELMA.Common;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Types;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Services.Public;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Templates;
using EleWise.ELMA.Workflow.API.Models;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Connectors;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Events;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Tasks;
using EleWise.ELMA.Workflow.Components;
using EleWise.ELMA.Workflow.Diagrams;
using EleWise.ELMA.Workflow.DTO.Models;
using EleWise.ELMA.Workflow.ExtensionPoints;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Security;
using EleWise.ELMA.Workflow.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.API;

[Component]
public class WorkflowPublicServiceMethodsProvider : IPublicServiceMethodsProvider
{
	internal class WorkflowInstanceContextMethodExecutor : PublicServiceMethodExecutor
	{
		private static class Names
		{
		}

		internal const string MethodName = "WorkflowInstanceContext";

		private static WorkflowInstanceContextMethodExecutor JASyWgvWS9vq4lI7wN5k;

		public static string Description => (string)tlU47QvWwgwDAZV2LYT7(J7dmWRvWEnYEXD9RJDHe(-667465279 ^ -667571941));

		public static TypeSerializationDescriptor ParametersDescriptor => (TypeSerializationDescriptor)jIbEOEvW4cklQ1haI4bN(new TypeSerializationDescriptorBuilder().ItemWithDescriptor(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34EA50D4 ^ 0x34EA1652), delegate(TypeSerializationDescriptorBuilder id)
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
					_003C_003Ec.xohaVOvQRDFSJCMW1sm8(id.Description((string)_003C_003Ec.F3OmgVvQjSnKywrlFQYv(_003C_003Ec.e4oNjbvQWihaQNjPN2M9(-1303601216 ^ -1303549242))), typeof(long));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2f119e188994b55be2499c193b880fb == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}));

		public static TypeSerializationDescriptor ResultDescriptor => new TypeSerializationDescriptorBuilder().ItemWithDescriptor(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x614CF569 ^ 0x614E303F), delegate(TypeSerializationDescriptorBuilder i)
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
					_003C_003Ec.xohaVOvQRDFSJCMW1sm8(_003C_003Ec.e64AZhvQ6AIo3ohS7kue(i, _003C_003Ec.F3OmgVvQjSnKywrlFQYv(_003C_003Ec.e4oNjbvQWihaQNjPN2M9(-1214182792 ^ -1214180348))), _003C_003Ec.LLV3r0vQquiUm4rWD7Pd(typeof(WebData).TypeHandle));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}).Descriptor;

		public WorkflowInstanceContextMethodExecutor(WebData parameters)
		{
			//Discarded unreachable code: IL_002b, IL_0030
			hWCyeQvWzFNb5CvcaUOq();
			base._002Ector(parameters);
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		public override WebData Execute()
		{
			return ExecuteInternal();
		}

		private WebData ExecuteInternal()
		{
			//Discarded unreachable code: IL_0066, IL_0075, IL_009b, IL_00a5, IL_012e
			int num = 4;
			WebData webData = default(WebData);
			WebDataItem webDataItem = default(WebDataItem);
			WebData webData3 = default(WebData);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					object obj;
					switch (num2)
					{
					case 8:
						webData = new WebData();
						num2 = 10;
						continue;
					default:
						if (webDataItem == null)
						{
							num = 7;
							break;
						}
						goto case 5;
					case 11:
						obj = null;
						goto IL_01b9;
					case 10:
					{
						WebData webData2 = webData;
						WebDataItem[] array = new WebDataItem[1];
						WebDataItem obj2 = new WebDataItem
						{
							Name = (string)J7dmWRvWEnYEXD9RJDHe(0x56A753C9 ^ 0x56A5969F)
						};
						mh7UAbvjlKTHsO3KLHj8(obj2, webData3);
						array[0] = obj2;
						fhTGZnvj0CvFI2CMbaaW(webData2, array);
						num2 = 9;
						continue;
					}
					case 1:
					case 7:
						throw vNd7C0vjvUhyOqKaTAoJ(tlU47QvWwgwDAZV2LYT7(J7dmWRvWEnYEXD9RJDHe(0x1EA50FCC ^ 0x1EA7EE8A)), 200);
					case 6:
					{
						if (!long.TryParse((string)a7YYqVvjYUCY1q5NhESI(webDataItem), out var result))
						{
							num2 = 2;
							continue;
						}
						object entity = Fm0Bn0vjsS1eGQe5logE(((AbstractNHEntityManager<IWorkflowInstance, long>)BKdpHYvj8okovH2TMTii()).LoadOrNull(result) ?? throw vNd7C0vjvUhyOqKaTAoJ(tlU47QvWwgwDAZV2LYT7(J7dmWRvWEnYEXD9RJDHe(0x2269BD32 ^ 0x226B5F1E)), 200));
						EntitySerializationSettings entitySerializationSettings = new EntitySerializationSettings();
						TxVTD1vjJiBmrOf1uonP(entitySerializationSettings, WorkflowTaskWCF.ContextSerializationFunctions);
						webData3 = WebData.CreateFromEntity((IEntity)entity, entitySerializationSettings);
						num2 = 8;
						continue;
					}
					case 4:
						if (Parameters != null)
						{
							num = 3;
							break;
						}
						goto case 11;
					case 3:
						if (ell9P3vjOTEO60qEFRLT(IbE8iQvjK1sAOfAmq6Gu(this)) != null)
						{
							num2 = 12;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1de08766357542bdb81146373079f817 == 0)
							{
								num2 = 6;
							}
							continue;
						}
						goto case 11;
					case 9:
						return webData;
					case 5:
						if (!string.IsNullOrEmpty(webDataItem.Value))
						{
							num2 = 6;
							continue;
						}
						goto case 1;
					case 12:
						obj = RNM3pYvjZSfR9U3ADPiH(IbE8iQvjK1sAOfAmq6Gu(this), J7dmWRvWEnYEXD9RJDHe(--1212129906 ^ 0x483FE4F4));
						goto IL_01b9;
					case 2:
						{
							throw vNd7C0vjvUhyOqKaTAoJ(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-862330810 ^ -862256680)), 200);
						}
						IL_01b9:
						webDataItem = (WebDataItem)obj;
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4459fbe344a947429d197733d274ef68 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				}
			}
		}

		internal static object J7dmWRvWEnYEXD9RJDHe(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object tlU47QvWwgwDAZV2LYT7(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static bool qBGyHMvW1n9pXlqd9VmH()
		{
			return JASyWgvWS9vq4lI7wN5k == null;
		}

		internal static WorkflowInstanceContextMethodExecutor cBhUYavWhWE7pcfofsrx()
		{
			return JASyWgvWS9vq4lI7wN5k;
		}

		internal static object jIbEOEvW4cklQ1haI4bN(object P_0)
		{
			return ((TypeSerializationDescriptorBuilder)P_0).Descriptor;
		}

		internal static void hWCyeQvWzFNb5CvcaUOq()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}

		internal static object IbE8iQvjK1sAOfAmq6Gu(object P_0)
		{
			return ((PublicServiceMethodExecutor)P_0).Parameters;
		}

		internal static object ell9P3vjOTEO60qEFRLT(object P_0)
		{
			return ((WebData)P_0).Items;
		}

		internal static object RNM3pYvjZSfR9U3ADPiH(object P_0, object P_1)
		{
			return ((WebData)P_0).FindItem((string)P_1);
		}

		internal static object vNd7C0vjvUhyOqKaTAoJ(object P_0, int P_1)
		{
			return PublicServiceException.CreateWebFault((string)P_0, P_1);
		}

		internal static object a7YYqVvjYUCY1q5NhESI(object P_0)
		{
			return ((WebDataItem)P_0).Value;
		}

		internal static object BKdpHYvj8okovH2TMTii()
		{
			return WorkflowInstanceManager.Instance;
		}

		internal static object Fm0Bn0vjsS1eGQe5logE(object P_0)
		{
			return ((IWorkflowInstance)P_0).Context;
		}

		internal static void TxVTD1vjJiBmrOf1uonP(object P_0, object P_1)
		{
			((EntitySerializationSettings)P_0).Functions = (EntitySerializationFunctions)P_1;
		}

		internal static void mh7UAbvjlKTHsO3KLHj8(object P_0, object P_1)
		{
			((WebDataItem)P_0).Data = (WebData)P_1;
		}

		internal static void fhTGZnvj0CvFI2CMbaaW(object P_0, object P_1)
		{
			((WebData)P_0).Items = (WebDataItem[])P_1;
		}
	}

	internal class StartProcessAsyncMethodExecutor : PublicServiceMethodExecutor
	{
		private static class Names
		{
		}

		internal const string MethodName = "StartProcessAsync";

		internal static StartProcessAsyncMethodExecutor UrEiLQvjyUfhQssb4Qcq;

		public static string Description => (string)ocOQi0vj5Y3uAZvxNj6o(C8ynFkvjbPC3upVwxHUU(0x7381F16B ^ 0x738313F1));

		public static TypeSerializationDescriptor ParametersDescriptor => (TypeSerializationDescriptor)viDJ5mvjggDbdMKwW87U(new TypeSerializationDescriptorBuilder().ItemWithDescriptor((string)C8ynFkvjbPC3upVwxHUU(-2077784392 ^ -2077767224), delegate(TypeSerializationDescriptorBuilder i)
		{
			int num7 = 1;
			int num8 = num7;
			while (true)
			{
				switch (num8)
				{
				default:
					return;
				case 1:
					_003C_003Ec.tbRJpkvQ7PfMsdmRQgvZ(_003C_003Ec.wit1rXvQG4e3PUFvKCvt(_003C_003Ec.euj6ExvQVgr1e26pfjUm(i, SR.T((string)_003C_003Ec.SDC384vQU9Q6MhETCNcM(0x628167BE ^ 0x62839D7E))), _003C_003Ec.Jt3FZLvQAVBf6QNS0RNR(typeof(long).TypeHandle)), null);
					num8 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_61395ebf330446ac8ce99b55ee3acfa9 != 0)
					{
						num8 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}).ItemWithDescriptor((string)C8ynFkvjbPC3upVwxHUU(0x6C7F14 ^ 0x6E9DD4), delegate(TypeSerializationDescriptorBuilder i)
		{
			int num5 = 1;
			int num6 = num5;
			while (true)
			{
				switch (num6)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					((TypeSerializationDescriptorBuilder)_003C_003Ec.euj6ExvQVgr1e26pfjUm(i, _003C_003Ec.aIAxMGvQ25lh37mNDSc9(_003C_003Ec.SDC384vQU9Q6MhETCNcM(-45832783 ^ -45720043)))).Type(_003C_003Ec.Jt3FZLvQAVBf6QNS0RNR(typeof(string).TypeHandle)).Optional();
					num6 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_dcdfd019631e458b9cb5fa34a16a2fe1 == 0)
					{
						num6 = 0;
					}
					break;
				}
			}
		}).ItemWithDescriptor((string)C8ynFkvjbPC3upVwxHUU(-1361036319 ^ -1361041793), delegate(TypeSerializationDescriptorBuilder i)
		{
			int num3 = 1;
			int num4 = num3;
			while (true)
			{
				switch (num4)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					_003C_003Ec.wit1rXvQG4e3PUFvKCvt(_003C_003Ec.euj6ExvQVgr1e26pfjUm(i, _003C_003Ec.aIAxMGvQ25lh37mNDSc9(_003C_003Ec.SDC384vQU9Q6MhETCNcM(0x75872B6 ^ 0x75A8EC2))), _003C_003Ec.Jt3FZLvQAVBf6QNS0RNR(typeof(string).TypeHandle));
					num4 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ffb1346d351f436b84bb1e9954c3bfa8 == 0)
					{
						num4 = 0;
					}
					break;
				}
			}
		})
			.ItemWithDescriptor((string)C8ynFkvjbPC3upVwxHUU(-1600060848 ^ -1600056632), delegate(TypeSerializationDescriptorBuilder i)
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
						_003C_003Ec.wit1rXvQG4e3PUFvKCvt(_003C_003Ec.euj6ExvQVgr1e26pfjUm(i, _003C_003Ec.aIAxMGvQ25lh37mNDSc9(_003C_003Ec.SDC384vQU9Q6MhETCNcM(0x37F755F5 ^ 0x37F582ED))), typeof(WebData));
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 != 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}));

		public static TypeSerializationDescriptor ResultDescriptor => (TypeSerializationDescriptor)viDJ5mvjggDbdMKwW87U(new TypeSerializationDescriptorBuilder().ItemWithDescriptor((string)C8ynFkvjbPC3upVwxHUU(-961162596 ^ -961073088), delegate(TypeSerializationDescriptorBuilder i)
		{
			int num19 = 1;
			int num20 = num19;
			while (true)
			{
				switch (num20)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					((TypeSerializationDescriptorBuilder)_003C_003Ec.euj6ExvQVgr1e26pfjUm(i, _003C_003Ec.aIAxMGvQ25lh37mNDSc9(_003C_003Ec.SDC384vQU9Q6MhETCNcM(0x63D6C913 ^ 0x63D435AB)))).Type(_003C_003Ec.Jt3FZLvQAVBf6QNS0RNR(typeof(bool).TypeHandle));
					num20 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0991fd79553c4ecc82e8b5cb79c2bff2 == 0)
					{
						num20 = 0;
					}
					break;
				}
			}
		}).ItemWithDescriptor(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2077784392 ^ -2077769608), delegate(TypeSerializationDescriptorBuilder i)
		{
			int num17 = 1;
			int num18 = num17;
			while (true)
			{
				switch (num18)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					_003C_003Ec.wit1rXvQG4e3PUFvKCvt(i.Description((string)_003C_003Ec.QrYSCFvQon87WeolTJA6(_003C_003Ec.SDC384vQU9Q6MhETCNcM(0x651FE29D ^ 0x651D1FB9), new object[3]
					{
						WorkflowTaskBaseExtensions.ExecuteStatusEnum.Executing,
						WorkflowTaskBaseExtensions.ExecuteStatusEnum.Executed,
						WorkflowTaskBaseExtensions.ExecuteStatusEnum.Unknown
					})), _003C_003Ec.Jt3FZLvQAVBf6QNS0RNR(typeof(string).TypeHandle));
					num18 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_85ba8d91af394836ac86666c40b1e150 == 0)
					{
						num18 = 0;
					}
					break;
				}
			}
		}).ItemWithDescriptor((string)C8ynFkvjbPC3upVwxHUU(-17847711 ^ -17997081), delegate(TypeSerializationDescriptorBuilder i)
		{
			int num15 = 1;
			int num16 = num15;
			while (true)
			{
				switch (num16)
				{
				default:
					return;
				case 1:
					((TypeSerializationDescriptorBuilder)_003C_003Ec.euj6ExvQVgr1e26pfjUm(i, _003C_003Ec.aIAxMGvQ25lh37mNDSc9(_003C_003Ec.SDC384vQU9Q6MhETCNcM(0x747FFBE0 ^ 0x747D08D4)))).Optional((object)null).Type(typeof(string));
					num16 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c559093b7320494babd70d164a6df42d == 0)
					{
						num16 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		})
			.ItemWithDescriptor((string)C8ynFkvjbPC3upVwxHUU(-197778752 ^ -197860084), delegate(TypeSerializationDescriptorBuilder i)
			{
				int num13 = 1;
				int num14 = num13;
				while (true)
				{
					switch (num14)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						_003C_003Ec.tbRJpkvQ7PfMsdmRQgvZ(_003C_003Ec.wit1rXvQG4e3PUFvKCvt(_003C_003Ec.euj6ExvQVgr1e26pfjUm(i, _003C_003Ec.aIAxMGvQ25lh37mNDSc9(_003C_003Ec.SDC384vQU9Q6MhETCNcM(0x1145BED7 ^ 0x11474EF7))), _003C_003Ec.Jt3FZLvQAVBf6QNS0RNR(typeof(long).TypeHandle)), null);
						num14 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 == 0)
						{
							num14 = 0;
						}
						break;
					}
				}
			})
			.ItemWithDescriptor((string)C8ynFkvjbPC3upVwxHUU(0x63D6C913 ^ 0x63D40EF7), delegate(TypeSerializationDescriptorBuilder i)
			{
				int num11 = 1;
				int num12 = num11;
				while (true)
				{
					switch (num12)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						_003C_003Ec.tbRJpkvQ7PfMsdmRQgvZ(_003C_003Ec.wit1rXvQG4e3PUFvKCvt(i.Description(SR.T((string)_003C_003Ec.SDC384vQU9Q6MhETCNcM(-14356676 ^ -14279092))), _003C_003Ec.Jt3FZLvQAVBf6QNS0RNR(typeof(Guid).TypeHandle)), null);
						num12 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b != 0)
						{
							num12 = 0;
						}
						break;
					}
				}
			})
			.ItemWithDescriptor((string)C8ynFkvjbPC3upVwxHUU(-360662087 ^ -360549377), delegate(TypeSerializationDescriptorBuilder co)
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
						_003C_003Ec.tbRJpkvQ7PfMsdmRQgvZ(co.IsArray(delegate(TypeSerializationDescriptorBuilder a)
						{
							int num3 = 1;
							int num4 = num3;
							while (true)
							{
								switch (num4)
								{
								default:
									return;
								case 0:
									return;
								case 1:
									a.ItemWithDescriptor((string)_003C_003Ec.SDC384vQU9Q6MhETCNcM(--1756698829 ^ 0x68B7EDF5), delegate(TypeSerializationDescriptorBuilder i)
									{
										int num9 = 1;
										int num10 = num9;
										while (true)
										{
											switch (num10)
											{
											default:
												return;
											case 1:
												_003C_003Ec.wit1rXvQG4e3PUFvKCvt(_003C_003Ec.euj6ExvQVgr1e26pfjUm(i, _003C_003Ec.aIAxMGvQ25lh37mNDSc9(_003C_003Ec.SDC384vQU9Q6MhETCNcM(0x1843E01F ^ 0x18411561))), typeof(string));
												num10 = 0;
												if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7de614af35034bd0a6867d08a2ee4a84 == 0)
												{
													num10 = 0;
												}
												break;
											case 0:
												return;
											}
										}
									}).ItemWithDescriptor((string)_003C_003Ec.SDC384vQU9Q6MhETCNcM(0x2ACCDD87 ^ 0x2ACDD42D), delegate(TypeSerializationDescriptorBuilder i)
									{
										int num7 = 1;
										int num8 = num7;
										while (true)
										{
											switch (num8)
											{
											default:
												return;
											case 1:
												_003C_003Ec.wit1rXvQG4e3PUFvKCvt(_003C_003Ec.tbRJpkvQ7PfMsdmRQgvZ(_003C_003Ec.euj6ExvQVgr1e26pfjUm(i, _003C_003Ec.aIAxMGvQ25lh37mNDSc9(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1927DA93 ^ 0x1925FBDF))), null), _003C_003Ec.Jt3FZLvQAVBf6QNS0RNR(typeof(DateTime).TypeHandle));
												num8 = 0;
												if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ac5d16a577a84bb0b8ee3654769d2d33 == 0)
												{
													num8 = 0;
												}
												break;
											case 0:
												return;
											}
										}
									}).ItemWithDescriptor((string)_003C_003Ec.SDC384vQU9Q6MhETCNcM(0xB7793C9 ^ 0xB756695), delegate(TypeSerializationDescriptorBuilder i)
									{
										int num5 = 1;
										int num6 = num5;
										while (true)
										{
											switch (num6)
											{
											default:
												return;
											case 0:
												return;
											case 1:
												((TypeSerializationDescriptorBuilder)_003C_003Ec.tbRJpkvQ7PfMsdmRQgvZ(i.Description((string)_003C_003Ec.aIAxMGvQ25lh37mNDSc9(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x361628FF ^ 0x3614DD5B))), null)).Type(typeof(DateTime));
												num6 = 0;
												if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_46e05b4e09174e34a9c81741b8b77a2f != 0)
												{
													num6 = 0;
												}
												break;
											}
										}
									});
									num4 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 == 0)
									{
										num4 = 0;
									}
									break;
								}
							}
						}), null);
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_08023922bb0e4e809e5cff73a2b04988 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}));

		public StartProcessAsyncMethodExecutor(WebData parameters)
		{
			//Discarded unreachable code: IL_002b, IL_0030
			O2WFRwvjBMEHLFnfMlA6();
			base._002Ector(parameters);
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c559093b7320494babd70d164a6df42d != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		public override WebData Execute()
		{
			return ExecuteInternal();
		}

		private WebData ExecuteInternal()
		{
			//Discarded unreachable code: IL_0140, IL_014a, IL_0159, IL_017f, IL_018e, IL_039e, IL_03f8, IL_041a, IL_0471, IL_0480, IL_06bd, IL_0795, IL_07a4, IL_07d7, IL_07fb, IL_080a, IL_09d2, IL_0aab, IL_0aba, IL_0aca, IL_0b8b, IL_0c0c
			int num = 27;
			IWorkflowInstance workflowInstance = default(IWorkflowInstance);
			IDictionary<string, object> serObj = default(IDictionary<string, object>);
			WebDataItem webDataItem3 = default(WebDataItem);
			IProcessHeader processHeader = default(IProcessHeader);
			_003C_003Ec__DisplayClass10_0 _003C_003Ec__DisplayClass10_ = default(_003C_003Ec__DisplayClass10_0);
			WebDataItem webDataItem2 = default(WebDataItem);
			Guid guid = default(Guid);
			long result = default(long);
			string text = default(string);
			IWorkflowProcess workflowProcess = default(IWorkflowProcess);
			WebDataItem webDataItem = default(WebDataItem);
			Dictionary<string, object> dictionary = default(Dictionary<string, object>);
			IWorkflowRuntimeService serviceNotNull = default(IWorkflowRuntimeService);
			IList<IWorkflowTaskBase> list = default(IList<IWorkflowTaskBase>);
			string value = default(string);
			IList<IWorkflowQueueItem> source = default(IList<IWorkflowQueueItem>);
			IWorkflowTaskBase workflowTaskBase = default(IWorkflowTaskBase);
			ClassMetadata classMetadata = default(ClassMetadata);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					int num3;
					bool flag;
					switch (num2)
					{
					case 52:
						new EntityJsonSerializer().ConvertFromSerializable(Qu6FWcvjM1uo5RckNekD(workflowInstance), serObj);
						num2 = 37;
						break;
					case 8:
						num3 = (string.IsNullOrEmpty((string)cl7gnsvjXuOnuuYbw7BA(webDataItem3)) ? 1 : 0);
						goto IL_0c1b;
					case 29:
						if (processHeader.RunByWebQueryPOST)
						{
							num2 = 35;
							break;
						}
						goto case 9;
					case 39:
						throw PublicServiceException.CreateWebFault((string)wBoW8AvjRaU5unQBB7pU(C8ynFkvjbPC3upVwxHUU(0x141C968 ^ 0x1432CE0), new object[1] { cl7gnsvjXuOnuuYbw7BA(_003C_003Ec__DisplayClass10_.processTokenItem) }));
					case 41:
						webDataItem2 = (WebDataItem)buCRKsvjc1ijk796sjU9(Parameters, C8ynFkvjbPC3upVwxHUU(0xB7793C9 ^ 0xB778E57));
						num2 = 32;
						break;
					case 43:
						guid = YMqvDMvjGXxB9xx5m9ID(workflowInstance);
						num2 = 48;
						break;
					case 14:
						throw QF0YB9vjubvLuphRxv0i(SR.T((string)C8ynFkvjbPC3upVwxHUU(-790221436 ^ -790312524)), 200);
					case 34:
						processHeader = ((AbstractNHEntityManager<IProcessHeader, long>)YvOaRCvjDXIr1BJpTwyJ()).LoadOrNull(result);
						num2 = 2;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ac5d16a577a84bb0b8ee3654769d2d33 == 0)
						{
							num2 = 25;
						}
						break;
					case 27:
						_003C_003Ec__DisplayClass10_ = new _003C_003Ec__DisplayClass10_0();
						num2 = 26;
						break;
					case 33:
						throw QF0YB9vjubvLuphRxv0i(ocOQi0vj5Y3uAZvxNj6o(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x56A753C9 ^ 0x56A5B4F7)), 200);
					case 58:
						text = (string)cl7gnsvjXuOnuuYbw7BA(webDataItem2);
						num2 = 31;
						break;
					case 17:
						throw QF0YB9vjubvLuphRxv0i(SR.T((string)C8ynFkvjbPC3upVwxHUU(-1895853023 ^ -1895992693)), 200);
					case 40:
						text = null;
						num2 = 11;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a != 0)
						{
							num2 = 60;
						}
						break;
					case 51:
						if (processHeader != null)
						{
							if (!processHeader.RunByFromExternalSystem)
							{
								num2 = 9;
								break;
							}
							goto case 15;
						}
						num2 = 39;
						break;
					case 25:
						if (processHeader != null)
						{
							num2 = 12;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5537a063960e465db83a04e35eea441b == 0)
							{
								num2 = 4;
							}
							break;
						}
						goto case 45;
					case 23:
						UdWq2qvjQnfPXOpd5S9L(workflowInstance, workflowProcess);
						num2 = 42;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3ab79470996d472f815915b21f45aac1 == 0)
						{
							num2 = 40;
						}
						break;
					case 21:
						if (webDataItem3 == null)
						{
							num2 = 6;
							break;
						}
						goto case 8;
					case 44:
						if (iTeba9vjCCwjJtEqcKEe(webDataItem) == null)
						{
							num2 = 20;
							break;
						}
						goto case 4;
					case 5:
						return new WebData(dictionary);
					case 13:
						try
						{
							ogsnUtvjkfC7gb1bnfY2(workflowInstance, AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>());
							int num4 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_08023922bb0e4e809e5cff73a2b04988 == 0)
							{
								num4 = 1;
							}
							while (true)
							{
								switch (num4)
								{
								case 1:
									serviceNotNull.Run(workflowInstance);
									num4 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea == 0)
									{
										num4 = 0;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
						}
						catch (Exception ex)
						{
							int num5 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 != 0)
							{
								num5 = 1;
							}
							object obj2;
							while (true)
							{
								switch (num5)
								{
								default:
									obj2 = ex.Message;
									break;
								case 1:
									if (aepAFMvjUn54EQ2l3OOG(ex) == null)
									{
										num5 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e4c570270f54493d8f3f4763a72f63f7 != 0)
										{
											num5 = 0;
										}
										continue;
									}
									obj2 = CVSkW8vjVI2LYxR3M5rq(aepAFMvjUn54EQ2l3OOG(ex));
									break;
								}
								break;
							}
							throw WUfej5vjA7r2p0DcsDa6(obj2, aepAFMvjUn54EQ2l3OOG(ex) ?? ex, 200);
						}
						goto case 19;
					case 49:
						if (long.TryParse((string)cl7gnsvjXuOnuuYbw7BA(webDataItem3), out result))
						{
							num2 = 34;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_08023922bb0e4e809e5cff73a2b04988 == 0)
							{
								num2 = 11;
							}
							break;
						}
						goto case 14;
					case 11:
					case 56:
						_003C_003Ec__DisplayClass10_.currentExecutions = Locator.GetServiceNotNull<IWorkflowQueueService>().GetGlobalExecutions();
						num2 = 53;
						break;
					case 20:
					case 37:
						num2 = 13;
						break;
					case 46:
						webDataItem = (WebDataItem)buCRKsvjc1ijk796sjU9(s8vWjlvjPA01t8QZtM30(this), C8ynFkvjbPC3upVwxHUU(-682910880 ^ -682914824));
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6b089b0d02ae4d3186c8d2cb8a24d4d3 == 0)
						{
							num2 = 16;
						}
						break;
					case 7:
						_003C_003Ec__DisplayClass10_.processTokenItem = (WebDataItem)buCRKsvjc1ijk796sjU9(s8vWjlvjPA01t8QZtM30(this), C8ynFkvjbPC3upVwxHUU(-1712492721 ^ -1712353905));
						num2 = 21;
						break;
					case 47:
						list = ((WorkflowTaskBaseManager)uc5Gmmvj7pMorJ7qIB3J()).FindMyActiveTasks(workflowInstance, allowSubInstances: true);
						num2 = 55;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e == 0)
						{
							num2 = 13;
						}
						break;
					case 10:
						throw QF0YB9vjubvLuphRxv0i(ocOQi0vj5Y3uAZvxNj6o(C8ynFkvjbPC3upVwxHUU(-539998957 ^ -539843735)), 200);
					default:
						if (zXKMRnvjq0eqHhnr4Sdq(Locator.GetServiceNotNull<ISecurityService>(), WorkflowPermissionProvider.StartProcess, workflowProcess, false))
						{
							num2 = 40;
							break;
						}
						goto case 17;
					case 59:
						return new WebData(new Dictionary<string, object>
						{
							{
								(string)C8ynFkvjbPC3upVwxHUU(0x75872B6 ^ 0x75A906A),
								true
							},
							{
								SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-39189604 ^ -39172772),
								WorkflowTaskBaseExtensions.ExecuteStatusEnum.Executing.ToString()
							},
							{
								SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xF400DF8 ^ 0xF42C57E),
								value
							}
						});
					case 32:
						if (webDataItem2 != null)
						{
							num2 = 50;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5537a063960e465db83a04e35eea441b == 0)
							{
								num2 = 34;
							}
							break;
						}
						goto case 33;
					case 45:
						throw QF0YB9vjubvLuphRxv0i(ocOQi0vj5Y3uAZvxNj6o(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1498811449 ^ -1498736773)), 200);
					case 12:
						if (QL7VbVvjnWxqGHDy1l49(processHeader) == WorkflowProcessRunAvailability.Denied)
						{
							num2 = 8;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a != 0)
							{
								num2 = 18;
							}
							break;
						}
						goto case 35;
					case 48:
						value = guid.ToString();
						num2 = 49;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a27e75af798c48d692c4325f43aa9e6b != 0)
						{
							num2 = 54;
						}
						break;
					case 55:
						if (iFvsqsvj2Rmc7FFxVhLR(list) <= 0)
						{
							num2 = 43;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_639c11c7bb65456db9f29c9c42f28bf7 == 0)
							{
								num2 = 56;
							}
							break;
						}
						goto case 24;
					case 26:
						webDataItem3 = (WebDataItem)buCRKsvjc1ijk796sjU9(Parameters, C8ynFkvjbPC3upVwxHUU(-1542190822 ^ -1542175126));
						num2 = 7;
						break;
					case 42:
						BogouXvjpQsF3kQxyOVf(workflowInstance, text);
						num2 = 46;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1de08766357542bdb81146373079f817 == 0)
						{
							num2 = 11;
						}
						break;
					case 16:
						if (webDataItem != null)
						{
							goto end_IL_0012;
						}
						goto case 20;
					case 31:
						serviceNotNull = Locator.GetServiceNotNull<IWorkflowRuntimeService>();
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 == 0)
						{
							num2 = 1;
						}
						break;
					case 1:
						G0vWCyvjTKfAOltE68QP(odOYaPvj3nOS0589cE0t(), C8ynFkvjbPC3upVwxHUU(0x5F534A5C ^ 0x5F51ADCA));
						num2 = 22;
						break;
					case 18:
						throw QF0YB9vjubvLuphRxv0i(ocOQi0vj5Y3uAZvxNj6o(C8ynFkvjbPC3upVwxHUU(-148495695 ^ -148584565)), 200);
					case 28:
					{
						object obj = YvOaRCvjDXIr1BJpTwyJ();
						ParameterExpression parameterExpression = (ParameterExpression)bjdZTHvjLRJcSXw0em5X(GYujvXvjHquXnDA3OTMZ(typeof(IProcessHeader).TypeHandle), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1965291699 ^ -1965258059));
						processHeader = ((AbstractNHEntityManager<IProcessHeader, long>)obj).Find(Expression.Lambda<Func<IProcessHeader, bool>>(Expression.Equal((Expression)JjMywSvj9yaxZRmWvfMy(parameterExpression, (MethodInfo)sIChGXvjfojBwdfYSwjh((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (Expression)JjMywSvj9yaxZRmWvfMy(KLBbX8vjjflpKe9JvkK8(Expression.Constant(_003C_003Ec__DisplayClass10_, GYujvXvjHquXnDA3OTMZ(typeof(_003C_003Ec__DisplayClass10_0).TypeHandle)), jSXSltvjWhvDeof7CJsr((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)sIChGXvjfojBwdfYSwjh((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/))), new ParameterExpression[1] { parameterExpression })).FirstOrDefault();
						num2 = 51;
						break;
					}
					case 38:
						if (!source.Any())
						{
							dictionary = new Dictionary<string, object>
							{
								{
									(string)C8ynFkvjbPC3upVwxHUU(-1657582555 ^ -1657688327),
									true
								},
								{
									(string)C8ynFkvjbPC3upVwxHUU(0x13F63440 ^ 0x13F67280),
									WorkflowTaskBaseExtensions.ExecuteStatusEnum.Executed.ToString()
								}
							};
							num2 = 29;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5c45a6e5a4614bfba7591d8a1c7ced1d == 0)
							{
								num2 = 47;
							}
						}
						else
						{
							num2 = 4;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 != 0)
							{
								num2 = 59;
							}
						}
						break;
					case 9:
					case 30:
						throw PublicServiceException.CreateWebFault((string)ocOQi0vj5Y3uAZvxNj6o(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5F800F5B ^ 0x5F82EA85)));
					case 35:
						workflowProcess = (IWorkflowProcess)gwJMldvj6kghCxJHr6by(processHeader);
						num2 = 2;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_69cb4a76addb44f28bb765f059e441c7 == 0)
						{
							num2 = 2;
						}
						break;
					case 3:
						dictionary.Add((string)C8ynFkvjbPC3upVwxHUU(0x361628FF ^ 0x3614EF33), workflowTaskBase.Id);
						num2 = 10;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2f119e188994b55be2499c193b880fb != 0)
						{
							num2 = 57;
						}
						break;
					case 54:
						source = Locator.GetServiceNotNull<IWorkflowQueueService>().WaitWhileQueued(workflowInstance, TimeSpan.Zero);
						num2 = 38;
						break;
					case 60:
						if (workflowProcess.NamingScheme.AskNameOnStart)
						{
							num2 = 8;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_db8eb3e90ad546d4b05544ab6326a49f == 0)
							{
								num2 = 41;
							}
							break;
						}
						goto case 31;
					case 19:
						G0vWCyvjTKfAOltE68QP(Logger.Log, C8ynFkvjbPC3upVwxHUU(0x7381F16B ^ 0x738316D7));
						num2 = 43;
						break;
					case 15:
						if (!processHeader.RunByWebQueryGET)
						{
							num2 = 29;
							break;
						}
						goto case 35;
					case 4:
						serObj = ((WebData)iTeba9vjCCwjJtEqcKEe(webDataItem)).ToDictionary();
						num2 = 52;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_32f3e755437f4eacb85c8a0d536f83ea == 0)
						{
							num2 = 52;
						}
						break;
					case 50:
						if (!hnhsaCvjdIHknxfPJ1q2(webDataItem2.Value))
						{
							num2 = 58;
							break;
						}
						goto case 33;
					case 24:
						workflowTaskBase = list[0];
						num2 = 2;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a9be7e056b4e4b6e863b634c418144f1 != 0)
						{
							num2 = 3;
						}
						break;
					case 22:
						workflowInstance = WorkflowInstanceManager.Instance.Create();
						num2 = 23;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e8980a9fd9d44c20920ffa276900c96f == 0)
						{
							num2 = 3;
						}
						break;
					case 2:
						if (workflowProcess != null)
						{
							num2 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f91acf223c4b4303819d2f8f2fc6c8e1 != 0)
							{
								num2 = 0;
							}
							break;
						}
						goto case 10;
					case 36:
						dictionary.Add((string)C8ynFkvjbPC3upVwxHUU(-708128192 ^ -708307548), Hrbn37vjopIta3Tr8b1J(classMetadata));
						num2 = 11;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_85ba8d91af394836ac86666c40b1e150 == 0)
						{
							num2 = 11;
						}
						break;
					case 57:
						classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(workflowTaskBase.CastAsRealType().GetType());
						num2 = 36;
						break;
					case 53:
						dictionary.Add((string)C8ynFkvjbPC3upVwxHUU(-63028171 ^ -63140749), new SerializableList<object>(source.Select(_003C_003Ec__DisplayClass10_._003CExecuteInternal_003Eb__1)));
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_69cb4a76addb44f28bb765f059e441c7 == 0)
						{
							num2 = 5;
						}
						break;
					case 6:
						{
							num3 = 1;
							goto IL_0c1b;
						}
						IL_0c1b:
						flag = _003C_003Ec__DisplayClass10_.processTokenItem == null || hnhsaCvjdIHknxfPJ1q2(cl7gnsvjXuOnuuYbw7BA(_003C_003Ec__DisplayClass10_.processTokenItem));
						if (((uint)num3 & (flag ? 1u : 0u)) != 0)
						{
							throw QF0YB9vjubvLuphRxv0i(SR.T((string)C8ynFkvjbPC3upVwxHUU(--727842433 ^ 0x2B631C6D)), 200);
						}
						if (num3 == 0 && !flag)
						{
							throw QF0YB9vjubvLuphRxv0i(ocOQi0vj5Y3uAZvxNj6o(C8ynFkvjbPC3upVwxHUU(-768800937 ^ -768613177)), 200);
						}
						processHeader = null;
						if (num3 != 0)
						{
							num2 = 18;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_938c6be4ea2248868d7ed5d0e3346006 != 0)
							{
								num2 = 28;
							}
							break;
						}
						goto case 49;
					}
					continue;
					end_IL_0012:
					break;
				}
				num = 44;
			}
		}

		internal static object C8ynFkvjbPC3upVwxHUU(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object ocOQi0vj5Y3uAZvxNj6o(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static bool Yx4tjKvjmnb0rrfKAaTd()
		{
			return UrEiLQvjyUfhQssb4Qcq == null;
		}

		internal static StartProcessAsyncMethodExecutor kwR1ygvjtGXcDaxef2ex()
		{
			return UrEiLQvjyUfhQssb4Qcq;
		}

		internal static object viDJ5mvjggDbdMKwW87U(object P_0)
		{
			return ((TypeSerializationDescriptorBuilder)P_0).Descriptor;
		}

		internal static void O2WFRwvjBMEHLFnfMlA6()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}

		internal static object buCRKsvjc1ijk796sjU9(object P_0, object P_1)
		{
			return ((WebData)P_0).FindItem((string)P_1);
		}

		internal static object s8vWjlvjPA01t8QZtM30(object P_0)
		{
			return ((PublicServiceMethodExecutor)P_0).Parameters;
		}

		internal static object cl7gnsvjXuOnuuYbw7BA(object P_0)
		{
			return ((WebDataItem)P_0).Value;
		}

		internal static bool hnhsaCvjdIHknxfPJ1q2(object P_0)
		{
			return string.IsNullOrEmpty((string)P_0);
		}

		internal static object QF0YB9vjubvLuphRxv0i(object P_0, int P_1)
		{
			return PublicServiceException.CreateWebFault((string)P_0, P_1);
		}

		internal static object YvOaRCvjDXIr1BJpTwyJ()
		{
			return ProcessHeaderManager.Instance;
		}

		internal static WorkflowProcessRunAvailability QL7VbVvjnWxqGHDy1l49(object P_0)
		{
			return ((IProcessHeader)P_0).RunAvailability;
		}

		internal static Type GYujvXvjHquXnDA3OTMZ(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static object bjdZTHvjLRJcSXw0em5X(Type P_0, object P_1)
		{
			return Expression.Parameter(P_0, (string)P_1);
		}

		internal static object sIChGXvjfojBwdfYSwjh(RuntimeMethodHandle P_0)
		{
			return MethodBase.GetMethodFromHandle(P_0);
		}

		internal static object JjMywSvj9yaxZRmWvfMy(object P_0, object P_1)
		{
			return Expression.Property((Expression)P_0, (MethodInfo)P_1);
		}

		internal static object jSXSltvjWhvDeof7CJsr(RuntimeFieldHandle P_0)
		{
			return FieldInfo.GetFieldFromHandle(P_0);
		}

		internal static object KLBbX8vjjflpKe9JvkK8(object P_0, object P_1)
		{
			return Expression.Field((Expression)P_0, (FieldInfo)P_1);
		}

		internal static object wBoW8AvjRaU5unQBB7pU(object P_0, object P_1)
		{
			return SR.T((string)P_0, (object[])P_1);
		}

		internal static object gwJMldvj6kghCxJHr6by(object P_0)
		{
			return ((IProcessHeader)P_0).Published;
		}

		internal static bool zXKMRnvjq0eqHhnr4Sdq(object P_0, object P_1, object P_2, bool P_3)
		{
			return ((ISecurityService)P_0).HasPermission((Permission)P_1, P_2, P_3);
		}

		internal static object odOYaPvj3nOS0589cE0t()
		{
			return Logger.Log;
		}

		internal static void G0vWCyvjTKfAOltE68QP(object P_0, object P_1)
		{
			((ILogger)P_0).Debug(P_1);
		}

		internal static void UdWq2qvjQnfPXOpd5S9L(object P_0, object P_1)
		{
			((IWorkflowInstance)P_0).Process = (IWorkflowProcess)P_1;
		}

		internal static void BogouXvjpQsF3kQxyOVf(object P_0, object P_1)
		{
			((IWorkflowInstance)P_0).Name = (string)P_1;
		}

		internal static object iTeba9vjCCwjJtEqcKEe(object P_0)
		{
			return ((WebDataItem)P_0).Data;
		}

		internal static object Qu6FWcvjM1uo5RckNekD(object P_0)
		{
			return ((IWorkflowInstance)P_0).Context;
		}

		internal static void ogsnUtvjkfC7gb1bnfY2(object P_0, object P_1)
		{
			((IWorkflowInstance)P_0).Initiator = (EleWise.ELMA.Security.Models.IUser)P_1;
		}

		internal static object aepAFMvjUn54EQ2l3OOG(object P_0)
		{
			return ((Exception)P_0).InnerException;
		}

		internal static object CVSkW8vjVI2LYxR3M5rq(object P_0)
		{
			return ((Exception)P_0).Message;
		}

		internal static object WUfej5vjA7r2p0DcsDa6(object P_0, object P_1, int P_2)
		{
			return PublicServiceException.CreateWebFault((string)P_0, (Exception)P_1, P_2);
		}

		internal static Guid YMqvDMvjGXxB9xx5m9ID(object P_0)
		{
			return ((IWorkflowInstance)P_0).Uid;
		}

		internal static object uc5Gmmvj7pMorJ7qIB3J()
		{
			return WorkflowTaskBaseManager.Instance;
		}

		internal static int iFvsqsvj2Rmc7FFxVhLR(object P_0)
		{
			return ((ICollection<IWorkflowTaskBase>)P_0).Count;
		}

		internal static Guid Hrbn37vjopIta3Tr8b1J(object P_0)
		{
			return ((AbstractMetadata)P_0).Uid;
		}
	}

	internal class StartProcessFormMethodExecutor : PublicServiceMethodExecutor
	{
		private static class Names
		{
		}

		internal const string MethodName = "StartProcessForm";

		internal static StartProcessFormMethodExecutor TmjJLfvjFDEF8ds5TqXk;

		public static string Description => (string)Awux8svjaAZh4tbaGkMR(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-25709590 ^ -25865164));

		public static TypeSerializationDescriptor ParametersDescriptor => (TypeSerializationDescriptor)ANLu6Nvjrbt9BN4IMO2p(new TypeSerializationDescriptorBuilder().ItemWithDescriptor(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xA7339EE ^ 0xA73769E), delegate(TypeSerializationDescriptorBuilder i)
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
					_003C_003Ec.o8JhhOvp8OTIMHAJRifR(_003C_003Ec.mL1chhvpvGdWBKTOGKW9(i, SR.T((string)_003C_003Ec.HLZjpgvpZDEwq8ZOkd63(0x6F6D7B44 ^ 0x6F6C8E08))), _003C_003Ec.GKu2envpY6UHPgAkXq7q(typeof(string).TypeHandle));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}));

		public static TypeSerializationDescriptor ResultDescriptor => (TypeSerializationDescriptor)ANLu6Nvjrbt9BN4IMO2p(new TypeSerializationDescriptorBuilder().ItemWithDescriptor((string)iAVtNQvjeM9slhQi1Cy4(--1418337216 ^ 0x5488F3D6), delegate(TypeSerializationDescriptorBuilder i)
		{
			int num5 = 1;
			int num6 = num5;
			while (true)
			{
				switch (num6)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					((TypeSerializationDescriptorBuilder)_003C_003Ec.mL1chhvpvGdWBKTOGKW9(i, _003C_003Ec.fjwenovps0dG8dFZvF6H(_003C_003Ec.HLZjpgvpZDEwq8ZOkd63(-398691253 ^ -398554541)))).Type(typeof(bool));
					num6 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e4c570270f54493d8f3f4763a72f63f7 == 0)
					{
						num6 = 0;
					}
					break;
				}
			}
		}).ItemWithDescriptor((string)iAVtNQvjeM9slhQi1Cy4(-360662087 ^ -360557681), delegate(TypeSerializationDescriptorBuilder i)
		{
			int num3 = 1;
			int num4 = num3;
			while (true)
			{
				switch (num4)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					i.ItemWithDescriptor(SR.T((string)_003C_003Ec.HLZjpgvpZDEwq8ZOkd63(--1418337216 ^ 0x5488FC1E)), EntityFormData.GetDescriptor);
					num4 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e2e244178c44ea09cd756894b022a62 == 0)
					{
						num4 = 0;
					}
					break;
				}
			}
		}).ItemWithDescriptor((string)iAVtNQvjeM9slhQi1Cy4(-398691253 ^ -398695213), delegate(TypeSerializationDescriptorBuilder i)
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
					_003C_003Ec.o8JhhOvp8OTIMHAJRifR(_003C_003Ec.mL1chhvpvGdWBKTOGKW9(i, _003C_003Ec.fjwenovps0dG8dFZvF6H(_003C_003Ec.HLZjpgvpZDEwq8ZOkd63(-1542190822 ^ -1542005246))), _003C_003Ec.GKu2envpY6UHPgAkXq7q(typeof(WebData).TypeHandle));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}));

		public StartProcessFormMethodExecutor(WebData parameters)
		{
			//Discarded unreachable code: IL_002b, IL_0030
			A9WeoSvjNeWTXQdpHan6();
			base._002Ector(parameters);
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8a6cf36da0b84f319a7cf27018f28f5b == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		public override WebData Execute()
		{
			return ExecuteInternal();
		}

		private WebData ExecuteInternal()
		{
			//Discarded unreachable code: IL_026e, IL_027d, IL_029e, IL_02ad
			int num = 16;
			EntityFormData entityFormData = default(EntityFormData);
			WorkflowInstanceContext workflowInstanceContext = default(WorkflowInstanceContext);
			FormView viewItem = default(FormView);
			WebData webData = default(WebData);
			StartEventElement startEventElement = default(StartEventElement);
			WebData data = default(WebData);
			_003C_003Ec__DisplayClass10_0 _003C_003Ec__DisplayClass10_ = default(_003C_003Ec__DisplayClass10_0);
			WebDataItem webDataItem4 = default(WebDataItem);
			IWorkflowProcess workflowProcess = default(IWorkflowProcess);
			IProcessHeader processHeader = default(IProcessHeader);
			long result = default(long);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 6:
						entityFormData = new EntityFormData(workflowInstanceContext.GetType(), viewItem);
						num2 = 13;
						break;
					case 18:
						return webData;
					case 22:
						if ((viewItem = (FormView)UQkAbvvROGBHDODmGknN(startEventElement)) != null)
						{
							num2 = 20;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_abfb511163674a3eae959fd60da8f319 != 0)
							{
								num2 = 3;
							}
							break;
						}
						goto case 10;
					case 3:
						throw TRwgtlvjhyr7GiEXx5CO(SR.T((string)iAVtNQvjeM9slhQi1Cy4(-398691253 ^ -398552527)), 200);
					case 13:
						data = WebData.CreateFromEntity(workflowInstanceContext, _003C_003Ec__DisplayClass10_._003CExecuteInternal_003Eb__0, _003C_003Ec__DisplayClass10_._003CExecuteInternal_003Eb__1);
						num2 = 11;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9269d021c6f148b6a1c4afb8cee03b6c != 0)
						{
							num2 = 12;
						}
						break;
					case 11:
						if (startEventElement != null)
						{
							num2 = 3;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3bb28bf622874b4689f9265e58d14823 == 0)
							{
								num2 = 22;
							}
							break;
						}
						goto case 10;
					case 2:
						throw TRwgtlvjhyr7GiEXx5CO(Awux8svjaAZh4tbaGkMR(iAVtNQvjeM9slhQi1Cy4(0x1927DA93 ^ 0x192532D1)), 200);
					case 10:
						webData = new WebData();
						num2 = 4;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 == 0)
						{
							num2 = 2;
						}
						break;
					case 15:
						webDataItem4 = (WebDataItem)OAOFmwvjSxRNeq9IEX4D(oMV19NvjxOvguIGC2QDD(this), iAVtNQvjeM9slhQi1Cy4(-1716458555 ^ -1716476747));
						num2 = 14;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4cc62744d0eb4cd68219b70dcad3e68e != 0)
						{
							num2 = 9;
						}
						break;
					case 16:
						_003C_003Ec__DisplayClass10_ = new _003C_003Ec__DisplayClass10_0();
						num2 = 15;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d87d9a74c9e14f96a288cc3620965fe0 != 0)
						{
							num2 = 8;
						}
						break;
					case 1:
						return webData;
					case 20:
						_003C_003Ec__DisplayClass10_.allPropertyUids = new HashSet<Guid>();
						num2 = 17;
						break;
					case 17:
						GetAllPropertyUids(viewItem, _003C_003Ec__DisplayClass10_.allPropertyUids);
						num2 = 6;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 == 0)
						{
							num2 = 2;
						}
						break;
					case 21:
						if (workflowProcess != null)
						{
							if (processHeader.RunAvailability == WorkflowProcessRunAvailability.Denied)
							{
								num2 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f508947b0d94af1961e5aa17a8a2044 != 0)
								{
									num2 = 0;
								}
								break;
							}
							IWorkflowInstance workflowInstance = InterfaceActivator.Create<IWorkflowInstance>();
							wHuQqjvj4pnoW9lAKjv4(workflowInstance, processHeader.Published);
							workflowInstanceContext = (WorkflowInstanceContext)ym3gFDvjzqZ7MI7xolbM(workflowInstance);
							num2 = 3;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6fe3beca34a9422e873cd6ef331760ae == 0)
							{
								num2 = 5;
							}
						}
						else
						{
							num2 = 3;
						}
						break;
					case 23:
						workflowProcess = (IWorkflowProcess)s1xqsivjwSavVYCNn5QW(processHeader);
						num2 = 17;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 != 0)
						{
							num2 = 21;
						}
						break;
					case 14:
						if (webDataItem4 != null)
						{
							num2 = 8;
							break;
						}
						goto case 2;
					case 5:
						startEventElement = yQSX5kvRKSDJ83JrM033(((IWorkflowProcess)s1xqsivjwSavVYCNn5QW(processHeader)).Diagram) as StartEventElement;
						num2 = 11;
						break;
					case 8:
						if (!aZqjbtvj1frZafdDdMUv(webDataItem4.Value))
						{
							if (long.TryParse(webDataItem4.Value, out result))
							{
								goto end_IL_0012;
							}
							goto case 9;
						}
						num2 = 2;
						break;
					case 19:
					{
						WebData webData3 = webData;
						WebDataItem[] array = new WebDataItem[3];
						WebDataItem webDataItem2 = new WebDataItem();
						DiG2HavRY02TjLKyLIiX(webDataItem2, iAVtNQvjeM9slhQi1Cy4(0x1EA50FCC ^ 0x1EA7E7DA));
						GEVTy6vRsEWisw01qiNd(webDataItem2, HcTZ6bvRvu1J3AYxlXKZ(workflowProcess.NamingScheme).ToString());
						array[0] = webDataItem2;
						WebDataItem webDataItem3 = new WebDataItem();
						DiG2HavRY02TjLKyLIiX(webDataItem3, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-197778752 ^ -197866762));
						EiZi3qvRlLe3HtTim2rd(webDataItem3, hOj8luvRJ3x4SVmK6AUd(entityFormData));
						array[1] = webDataItem3;
						array[2] = new WebDataItem
						{
							Name = (string)iAVtNQvjeM9slhQi1Cy4(0x350C0E8 ^ 0x350D070),
							Data = data
						};
						webData3.Items = array;
						num2 = 18;
						break;
					}
					case 12:
						webData = new WebData();
						num2 = 3;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 == 0)
						{
							num2 = 19;
						}
						break;
					case 4:
					{
						WebData webData2 = webData;
						WebDataItem[] obj = new WebDataItem[3]
						{
							new WebDataItem
							{
								Name = (string)iAVtNQvjeM9slhQi1Cy4(-398691253 ^ -398549923),
								Value = HcTZ6bvRvu1J3AYxlXKZ(JVeTsJvRZYymP0nI2oDk(workflowProcess)).ToString()
							},
							null,
							null
						};
						WebDataItem webDataItem = new WebDataItem();
						DiG2HavRY02TjLKyLIiX(webDataItem, iAVtNQvjeM9slhQi1Cy4(0x614274E3 ^ 0x61409CD5));
						obj[1] = webDataItem;
						obj[2] = new WebDataItem
						{
							Name = (string)iAVtNQvjeM9slhQi1Cy4(--601115071 ^ 0x23D45927)
						};
						Va1QRWvR8sESIvPdBIOi(webData2, obj);
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea != 0)
						{
							num2 = 1;
						}
						break;
					}
					default:
						throw TRwgtlvjhyr7GiEXx5CO(Awux8svjaAZh4tbaGkMR(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x63D6C913 ^ 0x63D42C29)), 200);
					case 9:
						throw TRwgtlvjhyr7GiEXx5CO(Awux8svjaAZh4tbaGkMR(iAVtNQvjeM9slhQi1Cy4(0x5F800F5B ^ 0x5F82EB6B)), 200);
					case 7:
						processHeader = ((AbstractNHEntityManager<IProcessHeader, long>)VWS87JvjEV3ddskm9Rkv()).Load(result);
						num2 = 23;
						break;
					}
					continue;
					end_IL_0012:
					break;
				}
				num = 7;
			}
		}

		private void GetAllPropertyUids(RootViewItem viewItem, ISet<Guid> uids)
		{
			foreach (ViewItem item in viewItem.Items)
			{
				if (item is PropertyViewItem propertyViewItem)
				{
					uids.Add(propertyViewItem.PropertyUid);
				}
				if (item is RootViewItem viewItem2)
				{
					GetAllPropertyUids(viewItem2, uids);
				}
			}
		}

		internal static object Awux8svjaAZh4tbaGkMR(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static bool ziFnPjvjiS22p7leGeLr()
		{
			return TmjJLfvjFDEF8ds5TqXk == null;
		}

		internal static StartProcessFormMethodExecutor xRuNZfvjIALKD7i0PH2N()
		{
			return TmjJLfvjFDEF8ds5TqXk;
		}

		internal static object ANLu6Nvjrbt9BN4IMO2p(object P_0)
		{
			return ((TypeSerializationDescriptorBuilder)P_0).Descriptor;
		}

		internal static object iAVtNQvjeM9slhQi1Cy4(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static void A9WeoSvjNeWTXQdpHan6()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}

		internal static object oMV19NvjxOvguIGC2QDD(object P_0)
		{
			return ((PublicServiceMethodExecutor)P_0).Parameters;
		}

		internal static object OAOFmwvjSxRNeq9IEX4D(object P_0, object P_1)
		{
			return ((WebData)P_0).FindItem((string)P_1);
		}

		internal static bool aZqjbtvj1frZafdDdMUv(object P_0)
		{
			return string.IsNullOrEmpty((string)P_0);
		}

		internal static object TRwgtlvjhyr7GiEXx5CO(object P_0, int P_1)
		{
			return PublicServiceException.CreateWebFault((string)P_0, P_1);
		}

		internal static object VWS87JvjEV3ddskm9Rkv()
		{
			return ProcessHeaderManager.Instance;
		}

		internal static object s1xqsivjwSavVYCNn5QW(object P_0)
		{
			return ((IProcessHeader)P_0).Published;
		}

		internal static void wHuQqjvj4pnoW9lAKjv4(object P_0, object P_1)
		{
			((IWorkflowInstance)P_0).Process = (IWorkflowProcess)P_1;
		}

		internal static object ym3gFDvjzqZ7MI7xolbM(object P_0)
		{
			return ((IWorkflowInstance)P_0).Context;
		}

		internal static object yQSX5kvRKSDJ83JrM033(object P_0)
		{
			return ((WorkflowDiagram)P_0).GetStartElement();
		}

		internal static object UQkAbvvROGBHDODmGknN(object P_0)
		{
			return ((StartEventElement)P_0).View;
		}

		internal static object JVeTsJvRZYymP0nI2oDk(object P_0)
		{
			return ((IWorkflowProcess)P_0).NamingScheme;
		}

		internal static bool HcTZ6bvRvu1J3AYxlXKZ(object P_0)
		{
			return ((InstanceNamingScheme)P_0).AskNameOnStart;
		}

		internal static void DiG2HavRY02TjLKyLIiX(object P_0, object P_1)
		{
			((WebDataItem)P_0).Name = (string)P_1;
		}

		internal static void Va1QRWvR8sESIvPdBIOi(object P_0, object P_1)
		{
			((WebData)P_0).Items = (WebDataItem[])P_1;
		}

		internal static void GEVTy6vRsEWisw01qiNd(object P_0, object P_1)
		{
			((WebDataItem)P_0).Value = (string)P_1;
		}

		internal static object hOj8luvRJ3x4SVmK6AUd(object P_0)
		{
			return ((EntityFormData)P_0).ToWebData();
		}

		internal static void EiZi3qvRlLe3HtTim2rd(object P_0, object P_1)
		{
			((WebDataItem)P_0).Data = (WebData)P_1;
		}
	}

	internal class StartProcessMethodExecutor : PublicServiceMethodExecutor
	{
		private static class Names
		{
		}

		internal const string MethodName = "StartProcess";

		private static StartProcessMethodExecutor gEQk97vR0ZUDq2STEuvC;

		public static string Description => (string)cIAwBwvRtYk9EmKnRMdj(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1108877388 ^ -1109050066));

		public static TypeSerializationDescriptor ParametersDescriptor => (TypeSerializationDescriptor)GOUnBfvR5gA7wZxTj3xU(new TypeSerializationDescriptorBuilder().ItemWithDescriptor((string)LwTX2bvRb43382Q7JIto(0x1843E01F ^ 0x1843AF6F), delegate(TypeSerializationDescriptorBuilder i)
		{
			int num7 = 1;
			int num8 = num7;
			while (true)
			{
				switch (num8)
				{
				default:
					return;
				case 1:
					((TypeSerializationDescriptorBuilder)_003C_003Ec.PxX4qTvpXwnQMhV0A21j(i, SR.T((string)_003C_003Ec.xbBIV6vpP4FyNWYMLFws(0x56F860D7 ^ 0x56FA9A17)))).Type(typeof(long)).Optional();
					num8 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe4a54387d744988feba4889229faf1 != 0)
					{
						num8 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}).ItemWithDescriptor((string)LwTX2bvRb43382Q7JIto(-432000546 ^ -431828194), delegate(TypeSerializationDescriptorBuilder i)
		{
			int num5 = 1;
			int num6 = num5;
			while (true)
			{
				switch (num6)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					_003C_003Ec.SVFAswvpDBFxDN21gEwJ(_003C_003Ec.lOUHaYvpuNaJN6JVvlHS(_003C_003Ec.PxX4qTvpXwnQMhV0A21j(i, _003C_003Ec.syCfMhvpdSMfWj46Le9K(_003C_003Ec.xbBIV6vpP4FyNWYMLFws(0x4943E3E4 ^ 0x49411840))), typeof(string)), null);
					num6 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6d48f3b4557a49578bf7f5ef0517e0be == 0)
					{
						num6 = 0;
					}
					break;
				}
			}
		}).ItemWithDescriptor((string)LwTX2bvRb43382Q7JIto(0x213F6477 ^ 0x213F79E9), delegate(TypeSerializationDescriptorBuilder i)
		{
			int num3 = 1;
			int num4 = num3;
			while (true)
			{
				switch (num4)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					_003C_003Ec.lOUHaYvpuNaJN6JVvlHS(_003C_003Ec.PxX4qTvpXwnQMhV0A21j(i, _003C_003Ec.syCfMhvpdSMfWj46Le9K(_003C_003Ec.xbBIV6vpP4FyNWYMLFws(0x51EF0063 ^ 0x51EDFC17))), _003C_003Ec.lJSAVUvpnE9phYwaTViu(typeof(string).TypeHandle));
					num4 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 != 0)
					{
						num4 = 0;
					}
					break;
				}
			}
		})
			.ItemWithDescriptor((string)LwTX2bvRb43382Q7JIto(-39189604 ^ -39185660), delegate(TypeSerializationDescriptorBuilder i)
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
						((TypeSerializationDescriptorBuilder)_003C_003Ec.PxX4qTvpXwnQMhV0A21j(i, _003C_003Ec.syCfMhvpdSMfWj46Le9K(_003C_003Ec.xbBIV6vpP4FyNWYMLFws(0x595C500A ^ 0x595E8712)))).Type(_003C_003Ec.lJSAVUvpnE9phYwaTViu(typeof(WebData).TypeHandle));
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7ed81ca3cf804abbade4684f28f485d1 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}));

		public static TypeSerializationDescriptor ResultDescriptor => (TypeSerializationDescriptor)GOUnBfvR5gA7wZxTj3xU(new TypeSerializationDescriptorBuilder().ItemWithDescriptor(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x42311138 ^ 0x4233F3E4), delegate(TypeSerializationDescriptorBuilder i)
		{
			int num15 = 1;
			int num16 = num15;
			while (true)
			{
				switch (num16)
				{
				default:
					return;
				case 1:
					_003C_003Ec.lOUHaYvpuNaJN6JVvlHS(i.Description(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-39189604 ^ -39256284))), _003C_003Ec.lJSAVUvpnE9phYwaTViu(typeof(bool).TypeHandle));
					num16 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 != 0)
					{
						num16 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}).ItemWithDescriptor(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x42311138 ^ 0x4233D6F4), delegate(TypeSerializationDescriptorBuilder i)
		{
			int num13 = 1;
			int num14 = num13;
			while (true)
			{
				switch (num14)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					_003C_003Ec.SVFAswvpDBFxDN21gEwJ(_003C_003Ec.lOUHaYvpuNaJN6JVvlHS(_003C_003Ec.PxX4qTvpXwnQMhV0A21j(i, _003C_003Ec.syCfMhvpdSMfWj46Le9K(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1712492721 ^ -1712349329))), _003C_003Ec.lJSAVUvpnE9phYwaTViu(typeof(long).TypeHandle)), null);
					num14 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1a2d7634479d44fb8d3718c31b05f73c == 0)
					{
						num14 = 0;
					}
					break;
				}
			}
		}).ItemWithDescriptor((string)LwTX2bvRb43382Q7JIto(-935313063 ^ -935164227), delegate(TypeSerializationDescriptorBuilder i)
		{
			int num11 = 1;
			int num12 = num11;
			while (true)
			{
				switch (num12)
				{
				default:
					return;
				case 1:
					_003C_003Ec.SVFAswvpDBFxDN21gEwJ(_003C_003Ec.lOUHaYvpuNaJN6JVvlHS(_003C_003Ec.PxX4qTvpXwnQMhV0A21j(i, _003C_003Ec.syCfMhvpdSMfWj46Le9K(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x614274E3 ^ 0x61408593))), _003C_003Ec.lJSAVUvpnE9phYwaTViu(typeof(Guid).TypeHandle)), null);
					num12 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f33560c5d18b4e10b24a458578aa60fd == 0)
					{
						num12 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		})
			.ItemWithDescriptor((string)LwTX2bvRb43382Q7JIto(-772614310 ^ -772792548), delegate(TypeSerializationDescriptorBuilder co)
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
						co.IsArray(delegate(TypeSerializationDescriptorBuilder a)
						{
							int num3 = 1;
							int num4 = num3;
							while (true)
							{
								switch (num4)
								{
								default:
									return;
								case 0:
									return;
								case 1:
									a.ItemWithDescriptor((string)_003C_003Ec.xbBIV6vpP4FyNWYMLFws(0x1AF6F1F2 ^ 0x1AF404CA), delegate(TypeSerializationDescriptorBuilder i)
									{
										int num9 = 1;
										int num10 = num9;
										while (true)
										{
											switch (num10)
											{
											default:
												return;
											case 0:
												return;
											case 1:
												_003C_003Ec.lOUHaYvpuNaJN6JVvlHS(i.Description((string)_003C_003Ec.syCfMhvpdSMfWj46Le9K(_003C_003Ec.xbBIV6vpP4FyNWYMLFws(-360662087 ^ -360558905))), _003C_003Ec.lJSAVUvpnE9phYwaTViu(typeof(string).TypeHandle));
												num10 = 0;
												if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5d3bc916b5664717ac60544de077bd16 == 0)
												{
													num10 = 0;
												}
												break;
											}
										}
									}).ItemWithDescriptor((string)_003C_003Ec.xbBIV6vpP4FyNWYMLFws(0x46EA3D1 ^ 0x46FAA7B), delegate(TypeSerializationDescriptorBuilder i)
									{
										int num7 = 1;
										int num8 = num7;
										while (true)
										{
											switch (num8)
											{
											default:
												return;
											case 1:
												_003C_003Ec.lOUHaYvpuNaJN6JVvlHS(_003C_003Ec.SVFAswvpDBFxDN21gEwJ(_003C_003Ec.PxX4qTvpXwnQMhV0A21j(i, _003C_003Ec.syCfMhvpdSMfWj46Le9K(_003C_003Ec.xbBIV6vpP4FyNWYMLFws(-2122743969 ^ -2122621421))), null), typeof(DateTime));
												num8 = 0;
												if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2f119e188994b55be2499c193b880fb == 0)
												{
													num8 = 0;
												}
												break;
											case 0:
												return;
											}
										}
									}).ItemWithDescriptor((string)_003C_003Ec.xbBIV6vpP4FyNWYMLFws(-1514166050 ^ -1514316414), delegate(TypeSerializationDescriptorBuilder i)
									{
										int num5 = 1;
										int num6 = num5;
										while (true)
										{
											switch (num6)
											{
											default:
												return;
											case 0:
												return;
											case 1:
												_003C_003Ec.lOUHaYvpuNaJN6JVvlHS(((TypeSerializationDescriptorBuilder)_003C_003Ec.PxX4qTvpXwnQMhV0A21j(i, _003C_003Ec.syCfMhvpdSMfWj46Le9K(_003C_003Ec.xbBIV6vpP4FyNWYMLFws(0x13F63440 ^ 0x13F4C1E4)))).Optional((object)null), _003C_003Ec.lJSAVUvpnE9phYwaTViu(typeof(DateTime).TypeHandle));
												num6 = 0;
												if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a27e75af798c48d692c4325f43aa9e6b == 0)
												{
													num6 = 0;
												}
												break;
											}
										}
									});
									num4 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0991fd79553c4ecc82e8b5cb79c2bff2 == 0)
									{
										num4 = 0;
									}
									break;
								}
							}
						}).Optional();
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0991fd79553c4ecc82e8b5cb79c2bff2 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}));

		public StartProcessMethodExecutor(WebData parameters)
		{
			//Discarded unreachable code: IL_002b, IL_0030
			NJDfE5vRgQauxkXSM5ex();
			base._002Ector(parameters);
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1c37d4e24e094858975336738e156495 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		public override WebData Execute()
		{
			return ExecuteInternal();
		}

		private WebData ExecuteInternal()
		{
			//Discarded unreachable code: IL_0136, IL_01d4, IL_02e8, IL_02f7, IL_0364, IL_0373, IL_0423, IL_043e, IL_044d, IL_08a4, IL_08fe, IL_0946, IL_0972, IL_0a2a, IL_0a39
			int num = 15;
			WebDataItem webDataItem2 = default(WebDataItem);
			IProcessHeader processHeader = default(IProcessHeader);
			long result = default(long);
			IWorkflowProcess workflowProcess = default(IWorkflowProcess);
			IWorkflowRuntimeService serviceNotNull = default(IWorkflowRuntimeService);
			Dictionary<string, object> dictionary = default(Dictionary<string, object>);
			ClassMetadata classMetadata = default(ClassMetadata);
			WebDataItem webDataItem3 = default(WebDataItem);
			string text = default(string);
			IList<IWorkflowTaskBase> list = default(IList<IWorkflowTaskBase>);
			IWorkflowInstance workflowInstance = default(IWorkflowInstance);
			IDictionary<string, object> serObj = default(IDictionary<string, object>);
			WebDataItem webDataItem = default(WebDataItem);
			IList<IWorkflowQueueItem> source = default(IList<IWorkflowQueueItem>);
			_003C_003Ec__DisplayClass10_0 _003C_003Ec__DisplayClass10_ = default(_003C_003Ec__DisplayClass10_0);
			IWorkflowTaskBase workflowTaskBase = default(IWorkflowTaskBase);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					int num3;
					bool flag;
					switch (num2)
					{
					case 21:
						throw TO37CcvRdsOGLS1qFAYR(cIAwBwvRtYk9EmKnRMdj(LwTX2bvRb43382Q7JIto(-885093259 ^ -885233463)), 200);
					case 3:
						if (webDataItem2 != null)
						{
							num2 = 7;
							continue;
						}
						goto case 27;
					case 39:
						throw TO37CcvRdsOGLS1qFAYR(cIAwBwvRtYk9EmKnRMdj(LwTX2bvRb43382Q7JIto(0x651FE29D ^ 0x651D06AD)), 200);
					case 8:
						processHeader = ((AbstractNHEntityManager<IProcessHeader, long>)CNnVsrvRuLKI1Kv2eEss()).LoadOrNull(result);
						num2 = 6;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_938c6be4ea2248868d7ed5d0e3346006 != 0)
						{
							num2 = 40;
						}
						continue;
					case 33:
						if (workflowProcess != null)
						{
							num2 = 35;
							continue;
						}
						goto case 45;
					case 32:
						serviceNotNull = Locator.GetServiceNotNull<IWorkflowRuntimeService>();
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a == 0)
						{
							num2 = 1;
						}
						continue;
					case 36:
						dictionary.Add((string)LwTX2bvRb43382Q7JIto(0x614CF569 ^ 0x614E328D), XBMulOvRag039QxLyM7v(classMetadata));
						num2 = 12;
						continue;
					case 5:
						if (!string.IsNullOrEmpty((string)tOOQDivRPHlBJ9QygmB8(webDataItem3)))
						{
							num2 = 24;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 != 0)
							{
								num2 = 42;
							}
							continue;
						}
						goto case 46;
					case 46:
						throw PublicServiceException.CreateWebFault((string)cIAwBwvRtYk9EmKnRMdj(LwTX2bvRb43382Q7JIto(-1050383744 ^ -1050243650)));
					case 42:
						text = (string)tOOQDivRPHlBJ9QygmB8(webDataItem3);
						num2 = 32;
						continue;
					case 17:
						Logger.Log.Debug(LwTX2bvRb43382Q7JIto(0x42311138 ^ 0x4233F684));
						num2 = 19;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 == 0)
						{
							num2 = 29;
						}
						continue;
					case 4:
						if (V38jwVvRIerclRl9SKdw(list) > 0)
						{
							num2 = 20;
							continue;
						}
						goto case 12;
					case 16:
						list = ((WorkflowTaskBaseManager)GqZ7advRiJwUyTf811vx()).FindMyActiveTasks(workflowInstance, allowSubInstances: true);
						num2 = 49;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe4a54387d744988feba4889229faf1 == 0)
						{
							num2 = 36;
						}
						continue;
					case 19:
						new EntityJsonSerializer().ConvertFromSerializable(workflowInstance.Context, serObj);
						num2 = 44;
						continue;
					case 26:
						if (long.TryParse((string)tOOQDivRPHlBJ9QygmB8(webDataItem), out result))
						{
							num2 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_558b46b4f4364838b08ac89d77f9a257 == 0)
							{
								num2 = 8;
							}
							continue;
						}
						goto case 39;
					case 41:
						if (webDataItem == null)
						{
							num2 = 48;
							continue;
						}
						goto case 2;
					case 11:
						rAguVHvRUbe95pi43icG(workflowInstance, text);
						num2 = 24;
						continue;
					case 38:
						dictionary.Add((string)LwTX2bvRb43382Q7JIto(0x614274E3 ^ 0x6140BCA5), new SerializableList<object>(source.Select(_003C_003Ec__DisplayClass10_._003CExecuteInternal_003Eb__1)));
						num2 = 6;
						continue;
					case 20:
						workflowTaskBase = list[0];
						num = 47;
						break;
					case 6:
						return new WebData(dictionary);
					case 18:
						if (webDataItem3 != null)
						{
							num2 = 4;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_dcdfd019631e458b9cb5fa34a16a2fe1 != 0)
							{
								num2 = 5;
							}
							continue;
						}
						goto case 46;
					case 2:
						num3 = (qTMNVrvRX8t6sJUl4c3p(tOOQDivRPHlBJ9QygmB8(webDataItem)) ? 1 : 0);
						goto IL_0a5b;
					case 15:
						_003C_003Ec__DisplayClass10_ = new _003C_003Ec__DisplayClass10_0();
						num2 = 14;
						continue;
					case 47:
						dictionary.Add(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x614274E3 ^ 0x6140B32F), workflowTaskBase.Id);
						num2 = 50;
						continue;
					case 34:
						if (PGpY2SvRQkm3nFis6GiY(hLygOAvRTDnXSy7GroCt(workflowProcess)))
						{
							num2 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe7a0ffe67e4fea8e329ae6574ed2ca == 0)
							{
								num2 = 0;
							}
							continue;
						}
						goto case 32;
					case 43:
						throw TO37CcvRdsOGLS1qFAYR(cIAwBwvRtYk9EmKnRMdj(LwTX2bvRb43382Q7JIto(0x738ABA6E ^ 0x73885F54)), 200);
					default:
						webDataItem3 = (WebDataItem)U8YwnDvRcYZYjjpaUSEr(n8EXGkvRBTy5qnw7cSYC(this), LwTX2bvRb43382Q7JIto(0x51EF0063 ^ 0x51EF1DFD));
						num = 18;
						break;
					case 27:
					case 44:
						num2 = 16;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a != 0)
						{
							num2 = 37;
						}
						continue;
					case 53:
						workflowInstance = ((AbstractNHEntityManager<IWorkflowInstance, long>)edZDvivRMZWPbqcO2lsR()).Create();
						num2 = 31;
						continue;
					case 25:
						throw TO37CcvRdsOGLS1qFAYR(SR.T((string)LwTX2bvRb43382Q7JIto(-683713632 ^ -683819394)), 200);
					case 30:
						workflowProcess = (IWorkflowProcess)jYSM0dvRqVe7Z1Qdc8vq(processHeader);
						num = 33;
						break;
					case 40:
						if (processHeader != null)
						{
							if (QvsV9BvRDwx88saQgtam(processHeader) == WorkflowProcessRunAvailability.Denied)
							{
								num2 = 43;
								continue;
							}
							goto case 30;
						}
						num2 = 21;
						continue;
					case 22:
						if (KmwFOpvR6lfXIy7Mwk9w(processHeader))
						{
							num = 30;
							break;
						}
						goto case 9;
					case 50:
						classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(workflowTaskBase.CastAsRealType().GetType());
						num2 = 32;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f8ecc99a1f4a4b6abc73e9b50261ea83 != 0)
						{
							num2 = 36;
						}
						continue;
					case 10:
						_003C_003Ec__DisplayClass10_.processTokenItem = (WebDataItem)U8YwnDvRcYZYjjpaUSEr(n8EXGkvRBTy5qnw7cSYC(this), LwTX2bvRb43382Q7JIto(-980570076 ^ -980462876));
						num2 = 41;
						continue;
					case 14:
						webDataItem = (WebDataItem)U8YwnDvRcYZYjjpaUSEr(n8EXGkvRBTy5qnw7cSYC(this), LwTX2bvRb43382Q7JIto(0x2ACCDD87 ^ 0x2ACC92F7));
						num2 = 10;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a50dda04dedf4515816f963c67783c8f != 0)
						{
							num2 = 3;
						}
						continue;
					case 23:
						throw TO37CcvRdsOGLS1qFAYR(FI8V3WvRjCfFlBhV9Ln7(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x56F860D7 ^ 0x56FA855F), new object[1] { tOOQDivRPHlBJ9QygmB8(_003C_003Ec__DisplayClass10_.processTokenItem) }), 200);
					case 52:
						if (processHeader != null)
						{
							if (OXo4Q7vRRaH8CCrpqw8P(processHeader))
							{
								num2 = 22;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c559093b7320494babd70d164a6df42d == 0)
								{
									num2 = 19;
								}
								continue;
							}
							goto case 25;
						}
						num2 = 23;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 != 0)
						{
							num2 = 18;
						}
						continue;
					case 1:
						U442fNvRCDXqU9ifkJIr(CM4hASvRpKdgeVKR0q2p(), LwTX2bvRb43382Q7JIto(0x246EEF98 ^ 0x246C080E));
						num2 = 49;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_18b351a59a324c25b4f150a9771bcf69 == 0)
						{
							num2 = 53;
						}
						continue;
					case 45:
						throw TO37CcvRdsOGLS1qFAYR(cIAwBwvRtYk9EmKnRMdj(LwTX2bvRb43382Q7JIto(0x34EA50D4 ^ 0x34E8B6AE)), 200);
					case 35:
						if (LhqEjEvR3yEVxfKxpicN(Locator.GetServiceNotNull<ISecurityService>(), WorkflowPermissionProvider.StartProcess, workflowProcess, false))
						{
							num2 = 51;
							continue;
						}
						goto case 13;
					case 7:
						if (Brb8T4vRVIUFXcDKQ6oP(webDataItem2) == null)
						{
							num2 = 27;
							continue;
						}
						goto case 28;
					case 31:
						tOwsHyvRkmUgD8FnChL3(workflowInstance, workflowProcess);
						num2 = 7;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0991fd79553c4ecc82e8b5cb79c2bff2 == 0)
						{
							num2 = 11;
						}
						continue;
					case 24:
						webDataItem2 = (WebDataItem)U8YwnDvRcYZYjjpaUSEr(n8EXGkvRBTy5qnw7cSYC(this), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-683713632 ^ -683717832));
						num2 = 3;
						continue;
					case 28:
						serObj = ((WebData)Brb8T4vRVIUFXcDKQ6oP(webDataItem2)).ToDictionary();
						num2 = 19;
						continue;
					case 49:
						dictionary = new Dictionary<string, object> { 
						{
							(string)LwTX2bvRb43382Q7JIto(-862330810 ^ -862256486),
							true
						} };
						num2 = 4;
						continue;
					case 37:
						try
						{
							uQtQpyvRAhnBm84b8X8h(workflowInstance, AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>());
							int num4 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cb262bcfe4074a1ab16e653815d57f28 != 0)
							{
								num4 = 0;
							}
							while (true)
							{
								switch (num4)
								{
								default:
									RyM1ALvRGSBVQy3rVtl1(serviceNotNull, workflowInstance);
									num4 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7de614af35034bd0a6867d08a2ee4a84 != 0)
									{
										num4 = 1;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
						catch (Exception ex)
						{
							int num5 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b84ccb8b1bd147ef900b852047ecbf45 != 0)
							{
								num5 = 0;
							}
							object obj;
							while (true)
							{
								switch (num5)
								{
								case 1:
									if (ex.InnerException == null)
									{
										num5 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 == 0)
										{
											num5 = 0;
										}
										continue;
									}
									obj = fdJxXrvR7fMDPHMLJxN4(rjP8GSvR2nB72wZHcw6p(ex));
									break;
								default:
									obj = fdJxXrvR7fMDPHMLJxN4(ex);
									break;
								}
								break;
							}
							throw mKaWaAvRoW4VjIOSGQaF(obj, rjP8GSvR2nB72wZHcw6p(ex) ?? ex, 200);
						}
						goto case 17;
					case 29:
						source = Locator.GetServiceNotNull<IWorkflowQueueService>().WaitWhileQueued(workflowInstance, ykJLbxvRFIlIiDULXrBe(1.0));
						num2 = 16;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c == 0)
						{
							num2 = 0;
						}
						continue;
					case 13:
						throw TO37CcvRdsOGLS1qFAYR(cIAwBwvRtYk9EmKnRMdj(LwTX2bvRb43382Q7JIto(-682910880 ^ -683049526)), 200);
					case 51:
						text = null;
						num2 = 12;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e == 0)
						{
							num2 = 34;
						}
						continue;
					case 12:
						_003C_003Ec__DisplayClass10_.currentExecutions = Locator.GetServiceNotNull<IWorkflowQueueService>().GetGlobalExecutions();
						num2 = 38;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_08023922bb0e4e809e5cff73a2b04988 == 0)
						{
							num2 = 19;
						}
						continue;
					case 9:
						if (!processHeader.RunByWebQueryPOST)
						{
							num2 = 25;
							continue;
						}
						goto case 30;
					case 48:
						{
							num3 = 1;
							goto IL_0a5b;
						}
						IL_0a5b:
						flag = _003C_003Ec__DisplayClass10_.processTokenItem == null || string.IsNullOrEmpty((string)tOOQDivRPHlBJ9QygmB8(_003C_003Ec__DisplayClass10_.processTokenItem));
						if (((uint)num3 & (flag ? 1u : 0u)) != 0)
						{
							throw TO37CcvRdsOGLS1qFAYR(cIAwBwvRtYk9EmKnRMdj(LwTX2bvRb43382Q7JIto(-772614310 ^ -772786762)), 200);
						}
						if (num3 == 0 && !flag)
						{
							throw TO37CcvRdsOGLS1qFAYR(SR.T((string)LwTX2bvRb43382Q7JIto(-420003255 ^ -420109863)), 200);
						}
						processHeader = null;
						if (num3 != 0)
						{
							object obj2 = CNnVsrvRuLKI1Kv2eEss();
							ParameterExpression parameterExpression = (ParameterExpression)xv03IBvRnFF0Z8nSClxS(typeof(IProcessHeader), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638225214 ^ -1638258886));
							processHeader = ((AbstractNHEntityManager<IProcessHeader, long>)obj2).Find(Expression.Lambda<Func<IProcessHeader, bool>>((Expression)haLTPBvRWcQT2cds0Ihf(Expression.Property(parameterExpression, (MethodInfo)nxJ11fvRHurM9H83Q7Lk((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), hW5CewvR9NbibqOJ6gEZ(Expression.Field(Expression.Constant(_003C_003Ec__DisplayClass10_, FWnYJGvRLeoofYMlqPU1(typeof(_003C_003Ec__DisplayClass10_0).TypeHandle)), (FieldInfo)EXxWtdvRfBmENZHevwgR((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)nxJ11fvRHurM9H83Q7Lk((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/))), new ParameterExpression[1] { parameterExpression })).FirstOrDefault();
							num = 52;
							break;
						}
						num2 = 26;
						continue;
					}
					break;
				}
			}
		}

		internal static object cIAwBwvRtYk9EmKnRMdj(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static bool CJWpqOvRynZYUgieSM0A()
		{
			return gEQk97vR0ZUDq2STEuvC == null;
		}

		internal static StartProcessMethodExecutor KG19cbvRmfHUaY3pJDjK()
		{
			return gEQk97vR0ZUDq2STEuvC;
		}

		internal static object LwTX2bvRb43382Q7JIto(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object GOUnBfvR5gA7wZxTj3xU(object P_0)
		{
			return ((TypeSerializationDescriptorBuilder)P_0).Descriptor;
		}

		internal static void NJDfE5vRgQauxkXSM5ex()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}

		internal static object n8EXGkvRBTy5qnw7cSYC(object P_0)
		{
			return ((PublicServiceMethodExecutor)P_0).Parameters;
		}

		internal static object U8YwnDvRcYZYjjpaUSEr(object P_0, object P_1)
		{
			return ((WebData)P_0).FindItem((string)P_1);
		}

		internal static object tOOQDivRPHlBJ9QygmB8(object P_0)
		{
			return ((WebDataItem)P_0).Value;
		}

		internal static bool qTMNVrvRX8t6sJUl4c3p(object P_0)
		{
			return string.IsNullOrEmpty((string)P_0);
		}

		internal static object TO37CcvRdsOGLS1qFAYR(object P_0, int P_1)
		{
			return PublicServiceException.CreateWebFault((string)P_0, P_1);
		}

		internal static object CNnVsrvRuLKI1Kv2eEss()
		{
			return ProcessHeaderManager.Instance;
		}

		internal static WorkflowProcessRunAvailability QvsV9BvRDwx88saQgtam(object P_0)
		{
			return ((IProcessHeader)P_0).RunAvailability;
		}

		internal static object xv03IBvRnFF0Z8nSClxS(Type P_0, object P_1)
		{
			return Expression.Parameter(P_0, (string)P_1);
		}

		internal static object nxJ11fvRHurM9H83Q7Lk(RuntimeMethodHandle P_0)
		{
			return MethodBase.GetMethodFromHandle(P_0);
		}

		internal static Type FWnYJGvRLeoofYMlqPU1(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static object EXxWtdvRfBmENZHevwgR(RuntimeFieldHandle P_0)
		{
			return FieldInfo.GetFieldFromHandle(P_0);
		}

		internal static object hW5CewvR9NbibqOJ6gEZ(object P_0, object P_1)
		{
			return Expression.Property((Expression)P_0, (MethodInfo)P_1);
		}

		internal static object haLTPBvRWcQT2cds0Ihf(object P_0, object P_1)
		{
			return Expression.Equal((Expression)P_0, (Expression)P_1);
		}

		internal static object FI8V3WvRjCfFlBhV9Ln7(object P_0, object P_1)
		{
			return SR.T((string)P_0, (object[])P_1);
		}

		internal static bool OXo4Q7vRRaH8CCrpqw8P(object P_0)
		{
			return ((IProcessHeader)P_0).RunByFromExternalSystem;
		}

		internal static bool KmwFOpvR6lfXIy7Mwk9w(object P_0)
		{
			return ((IProcessHeader)P_0).RunByWebQueryGET;
		}

		internal static object jYSM0dvRqVe7Z1Qdc8vq(object P_0)
		{
			return ((IProcessHeader)P_0).Published;
		}

		internal static bool LhqEjEvR3yEVxfKxpicN(object P_0, object P_1, object P_2, bool P_3)
		{
			return ((ISecurityService)P_0).HasPermission((Permission)P_1, P_2, P_3);
		}

		internal static object hLygOAvRTDnXSy7GroCt(object P_0)
		{
			return ((IWorkflowProcess)P_0).NamingScheme;
		}

		internal static bool PGpY2SvRQkm3nFis6GiY(object P_0)
		{
			return ((InstanceNamingScheme)P_0).AskNameOnStart;
		}

		internal static object CM4hASvRpKdgeVKR0q2p()
		{
			return Logger.Log;
		}

		internal static void U442fNvRCDXqU9ifkJIr(object P_0, object P_1)
		{
			((ILogger)P_0).Debug(P_1);
		}

		internal static object edZDvivRMZWPbqcO2lsR()
		{
			return WorkflowInstanceManager.Instance;
		}

		internal static void tOwsHyvRkmUgD8FnChL3(object P_0, object P_1)
		{
			((IWorkflowInstance)P_0).Process = (IWorkflowProcess)P_1;
		}

		internal static void rAguVHvRUbe95pi43icG(object P_0, object P_1)
		{
			((IWorkflowInstance)P_0).Name = (string)P_1;
		}

		internal static object Brb8T4vRVIUFXcDKQ6oP(object P_0)
		{
			return ((WebDataItem)P_0).Data;
		}

		internal static void uQtQpyvRAhnBm84b8X8h(object P_0, object P_1)
		{
			((IWorkflowInstance)P_0).Initiator = (EleWise.ELMA.Security.Models.IUser)P_1;
		}

		internal static void RyM1ALvRGSBVQy3rVtl1(object P_0, object P_1)
		{
			((IWorkflowRuntimeService)P_0).Run((IWorkflowInstance)P_1);
		}

		internal static object fdJxXrvR7fMDPHMLJxN4(object P_0)
		{
			return ((Exception)P_0).Message;
		}

		internal static object rjP8GSvR2nB72wZHcw6p(object P_0)
		{
			return ((Exception)P_0).InnerException;
		}

		internal static object mKaWaAvRoW4VjIOSGQaF(object P_0, object P_1, int P_2)
		{
			return PublicServiceException.CreateWebFault((string)P_0, (Exception)P_1, P_2);
		}

		internal static TimeSpan ykJLbxvRFIlIiDULXrBe(double P_0)
		{
			return TimeSpan.FromHours(P_0);
		}

		internal static object GqZ7advRiJwUyTf811vx()
		{
			return WorkflowTaskBaseManager.Instance;
		}

		internal static int V38jwVvRIerclRl9SKdw(object P_0)
		{
			return ((ICollection<IWorkflowTaskBase>)P_0).Count;
		}

		internal static Guid XBMulOvRag039QxLyM7v(object P_0)
		{
			return ((AbstractMetadata)P_0).Uid;
		}
	}

	internal class StartableProcessesMethodExecutor : PublicServiceMethodExecutor
	{
		private static class Names
		{
		}

		internal class ProcessGroupInfo
		{
			private static class Names
			{
				public static readonly object Id;

				public static readonly object Name;

				public static readonly object ParentId;

				private static object qQr88ovkRa7CdoJ8HxVE;

				static Names()
				{
					int num = 1;
					int num2 = num;
					ParameterExpression parameterExpression = default(ParameterExpression);
					while (true)
					{
						switch (num2)
						{
						case 1:
							y73i2rvk3RyaCPdWH4ce();
							num2 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 != 0)
							{
								num2 = 0;
							}
							break;
						case 6:
							Id = LinqUtils.NameOf(Expression.Lambda<Func<ProcessGroupInfo, object>>((Expression)tjQtQJvkMXjiYtqXudJc(uCwpeBvkCuFAiFxlQIxa(parameterExpression, (MethodInfo)KwMXdIvkpBnIQw47raTf((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), WGK20MvkTHDuB6DgLho5(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
							num2 = 4;
							break;
						case 5:
							return;
						default:
							parameterExpression = Expression.Parameter(WGK20MvkTHDuB6DgLho5(typeof(ProcessGroupInfo).TypeHandle), (string)wQoRRJvkQo2gnYs58gDg(--1418337216 ^ 0x548A430E));
							num2 = 6;
							break;
						case 3:
							parameterExpression = (ParameterExpression)Rq4Q4gvkkxOljvg3G5Gi(WGK20MvkTHDuB6DgLho5(typeof(ProcessGroupInfo).TypeHandle), wQoRRJvkQo2gnYs58gDg(0x65B7F624 ^ 0x65B7AEEA));
							num2 = 7;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1de08766357542bdb81146373079f817 != 0)
							{
								num2 = 7;
							}
							break;
						case 4:
							parameterExpression = (ParameterExpression)Rq4Q4gvkkxOljvg3G5Gi(WGK20MvkTHDuB6DgLho5(typeof(ProcessGroupInfo).TypeHandle), wQoRRJvkQo2gnYs58gDg(--601115071 ^ 0x23D41171));
							num2 = 2;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c == 0)
							{
								num2 = 0;
							}
							break;
						case 7:
							ParentId = LinqUtils.NameOf(Expression.Lambda<Func<ProcessGroupInfo, object>>((Expression)tjQtQJvkMXjiYtqXudJc(uCwpeBvkCuFAiFxlQIxa(parameterExpression, (MethodInfo)KwMXdIvkpBnIQw47raTf((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), WGK20MvkTHDuB6DgLho5(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
							num2 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_69cb4a76addb44f28bb765f059e441c7 == 0)
							{
								num2 = 5;
							}
							break;
						case 2:
							Name = LinqUtils.NameOf(Expression.Lambda<Func<ProcessGroupInfo, object>>((Expression)uCwpeBvkCuFAiFxlQIxa(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
							num2 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 == 0)
							{
								num2 = 3;
							}
							break;
						}
					}
				}

				internal static void y73i2rvk3RyaCPdWH4ce()
				{
					j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
				}

				internal static Type WGK20MvkTHDuB6DgLho5(RuntimeTypeHandle P_0)
				{
					return Type.GetTypeFromHandle(P_0);
				}

				internal static object wQoRRJvkQo2gnYs58gDg(int _0020)
				{
					return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
				}

				internal static object KwMXdIvkpBnIQw47raTf(RuntimeMethodHandle P_0)
				{
					return MethodBase.GetMethodFromHandle(P_0);
				}

				internal static object uCwpeBvkCuFAiFxlQIxa(object P_0, object P_1)
				{
					return Expression.Property((Expression)P_0, (MethodInfo)P_1);
				}

				internal static object tjQtQJvkMXjiYtqXudJc(object P_0, Type P_1)
				{
					return Expression.Convert((Expression)P_0, P_1);
				}

				internal static object Rq4Q4gvkkxOljvg3G5Gi(Type P_0, object P_1)
				{
					return Expression.Parameter(P_0, (string)P_1);
				}

				internal static bool k0v2dYvk6H5F45An5575()
				{
					return qQr88ovkRa7CdoJ8HxVE == null;
				}

				internal static Names DfgwNFvkq56wVrnhACIp()
				{
					return (Names)qQr88ovkRa7CdoJ8HxVE;
				}
			}

			internal static ProcessGroupInfo GkvAwfvpClsloe7bWLiL;

			public long Id
			{
				[CompilerGenerated]
				get
				{
					return _003CId_003Ek__BackingField;
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
							_003CId_003Ek__BackingField = value;
							num2 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f8ecc99a1f4a4b6abc73e9b50261ea83 == 0)
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

			public string Name
			{
				[CompilerGenerated]
				get
				{
					return _003CName_003Ek__BackingField;
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
							_003CName_003Ek__BackingField = value;
							num2 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe7a0ffe67e4fea8e329ae6574ed2ca == 0)
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

			public long ParentId
			{
				[CompilerGenerated]
				get
				{
					return _003CParentId_003Ek__BackingField;
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
							_003CParentId_003Ek__BackingField = value;
							num2 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1b8b735647da470aa2d45d64d6f538d1 == 0)
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

			public ProcessGroupInfo(ProcessGroupDTO group)
			{
				//Discarded unreachable code: IL_001a, IL_001f
				RxChDhvpUIrUIQoU2iA7();
				base._002Ector();
				int num = 2;
				while (true)
				{
					switch (num)
					{
					default:
						return;
					case 1:
						Name = (string)SYAhdcvpVCrFB5dVV5WI(group);
						num = 3;
						break;
					case 3:
						ParentId = DmWI90vpAkJffsHmDXq2(group);
						num = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe7a0ffe67e4fea8e329ae6574ed2ca != 0)
						{
							num = 0;
						}
						break;
					case 0:
						return;
					case 2:
						Id = group.Id;
						num = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ecf910d183864897a7c8ec77e01689a4 != 0)
						{
							num = 1;
						}
						break;
					}
				}
			}

			public static void GetDescriptor(TypeSerializationDescriptorBuilder builder)
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
						builder.ItemWithDescriptor((string)Names.Id, delegate(TypeSerializationDescriptorBuilder i)
						{
							int num7 = 1;
							int num8 = num7;
							while (true)
							{
								switch (num8)
								{
								default:
									return;
								case 0:
									return;
								case 1:
									i.Description(SR.T((string)_003C_003Ec.o8sX0evk7KHx0YOytxAE(-360662087 ^ -360466333))).Type(_003C_003Ec.Qa5l7nvk2eUy1x2cjiPS(typeof(long).TypeHandle));
									num8 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6dd19c81ff5e41fb8db9b50574437301 == 0)
									{
										num8 = 0;
									}
									break;
								}
							}
						}).ItemWithDescriptor((string)Names.Name, delegate(TypeSerializationDescriptorBuilder i)
						{
							int num5 = 1;
							int num6 = num5;
							while (true)
							{
								switch (num6)
								{
								default:
									return;
								case 1:
									_003C_003Ec.QfwPyhvkF1iUmEk4TRdO(i.Description((string)_003C_003Ec.YPTm47vkokIZIMxVKYYI(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1050383744 ^ -1050186106))), typeof(string));
									num6 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 == 0)
									{
										num6 = 0;
									}
									break;
								case 0:
									return;
								}
							}
						}).ItemWithDescriptor((string)Names.ParentId, delegate(TypeSerializationDescriptorBuilder i)
						{
							int num3 = 1;
							int num4 = num3;
							while (true)
							{
								switch (num4)
								{
								default:
									return;
								case 1:
									_003C_003Ec.gdiYqlvkI0vqZPbnUMtb(_003C_003Ec.QfwPyhvkF1iUmEk4TRdO(_003C_003Ec.JffVqfvkioktLylkInZb(i, SR.T((string)_003C_003Ec.o8sX0evk7KHx0YOytxAE(0xDF4D1F8 ^ 0xDF7D5C8))), _003C_003Ec.Qa5l7nvk2eUy1x2cjiPS(typeof(long).TypeHandle)), null);
									num4 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_85ba8d91af394836ac86666c40b1e150 == 0)
									{
										num4 = 0;
									}
									break;
								case 0:
									return;
								}
							}
						});
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1c37d4e24e094858975336738e156495 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}

			public WebData ToWebData()
			{
				int num = 1;
				Dictionary<string, object> dictionary = default(Dictionary<string, object>);
				while (true)
				{
					int num2 = num;
					while (true)
					{
						switch (num2)
						{
						case 3:
							return new WebData(dictionary);
						case 2:
							dictionary[(string)Names.ParentId] = ParentId;
							num = 3;
							break;
						case 4:
							dictionary[(string)Names.Name] = Name;
							num = 5;
							break;
						default:
							dictionary[(string)Names.Id] = Id;
							num2 = 4;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7de614af35034bd0a6867d08a2ee4a84 != 0)
							{
								num2 = 3;
							}
							continue;
						case 1:
							dictionary = new Dictionary<string, object>();
							num2 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4459fbe344a947429d197733d274ef68 != 0)
							{
								num2 = 0;
							}
							continue;
						case 5:
							if (ParentId != 0L)
							{
								num2 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b84ccb8b1bd147ef900b852047ecbf45 == 0)
								{
									num2 = 2;
								}
								continue;
							}
							goto case 3;
						}
						break;
					}
				}
			}

			internal static void RxChDhvpUIrUIQoU2iA7()
			{
				j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
			}

			internal static object SYAhdcvpVCrFB5dVV5WI(object P_0)
			{
				return ((ProcessGroupDTO)P_0).Name;
			}

			internal static long DmWI90vpAkJffsHmDXq2(object P_0)
			{
				return ((ProcessGroupDTO)P_0).ParentId;
			}

			internal static bool rGYRIlvpMI5kaXxmBIP8()
			{
				return GkvAwfvpClsloe7bWLiL == null;
			}

			internal static ProcessGroupInfo B7skl3vpkQLqAokwRvkW()
			{
				return GkvAwfvpClsloe7bWLiL;
			}
		}

		internal class ProcessHeaderInfo
		{
			private static class Names
			{
				public static readonly object Id;

				public static readonly object Name;

				public static readonly object GroupId;

				internal static object TdpoUOvkal7GZrIuTtRM;

				static Names()
				{
					int num = 2;
					ParameterExpression parameterExpression = default(ParameterExpression);
					while (true)
					{
						int num2 = num;
						while (true)
						{
							switch (num2)
							{
							case 5:
								Name = LinqUtils.NameOf(Expression.Lambda<Func<ProcessHeaderInfo, object>>(Expression.Property(parameterExpression, (MethodInfo)C74EFxvkhYJo5oLKuL7J((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
								num2 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4cc62744d0eb4cd68219b70dcad3e68e != 0)
								{
									num2 = 0;
								}
								continue;
							case 7:
								break;
							case 1:
								parameterExpression = (ParameterExpression)YW1RSJvk1GA3fThW2GRa(EbvdLJvkxL2ZrTbKYMBc(typeof(ProcessHeaderInfo).TypeHandle), LTxKaPvkS5GBHyuin2JR(-22348816 ^ -22371522));
								num2 = 6;
								continue;
							case 6:
								Id = LinqUtils.NameOf(Expression.Lambda<Func<ProcessHeaderInfo, object>>((Expression)XIjA06vkwywvrvQxTKfX(lDSTQAvkE2pXrZbUUWwN(parameterExpression, (MethodInfo)C74EFxvkhYJo5oLKuL7J((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object)), new ParameterExpression[1] { parameterExpression }));
								num2 = 7;
								continue;
							case 2:
								JnlB1GvkNuD3F0b0fegg();
								num2 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd == 0)
								{
									num2 = 1;
								}
								continue;
							default:
								parameterExpression = (ParameterExpression)YW1RSJvk1GA3fThW2GRa(EbvdLJvkxL2ZrTbKYMBc(typeof(ProcessHeaderInfo).TypeHandle), LTxKaPvkS5GBHyuin2JR(0x628167BE ^ 0x62813F70));
								num2 = 3;
								continue;
							case 3:
								GroupId = LinqUtils.NameOf(Expression.Lambda<Func<ProcessHeaderInfo, object>>((Expression)XIjA06vkwywvrvQxTKfX(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), EbvdLJvkxL2ZrTbKYMBc(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
								num2 = 3;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 != 0)
								{
									num2 = 4;
								}
								continue;
							case 4:
								return;
							}
							break;
						}
						parameterExpression = (ParameterExpression)YW1RSJvk1GA3fThW2GRa(EbvdLJvkxL2ZrTbKYMBc(typeof(ProcessHeaderInfo).TypeHandle), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-25709590 ^ -25695452));
						num = 5;
					}
				}

				internal static void JnlB1GvkNuD3F0b0fegg()
				{
					j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
				}

				internal static Type EbvdLJvkxL2ZrTbKYMBc(RuntimeTypeHandle P_0)
				{
					return Type.GetTypeFromHandle(P_0);
				}

				internal static object LTxKaPvkS5GBHyuin2JR(int _0020)
				{
					return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
				}

				internal static object YW1RSJvk1GA3fThW2GRa(Type P_0, object P_1)
				{
					return Expression.Parameter(P_0, (string)P_1);
				}

				internal static object C74EFxvkhYJo5oLKuL7J(RuntimeMethodHandle P_0)
				{
					return MethodBase.GetMethodFromHandle(P_0);
				}

				internal static object lDSTQAvkE2pXrZbUUWwN(object P_0, object P_1)
				{
					return Expression.Property((Expression)P_0, (MethodInfo)P_1);
				}

				internal static object XIjA06vkwywvrvQxTKfX(object P_0, Type P_1)
				{
					return Expression.Convert((Expression)P_0, P_1);
				}

				internal static bool HqyKnLvkrFG6bNS4NoRL()
				{
					return TdpoUOvkal7GZrIuTtRM == null;
				}

				internal static Names YDAhDcvkeCvS19TwU0pk()
				{
					return (Names)TdpoUOvkal7GZrIuTtRM;
				}
			}

			internal static ProcessHeaderInfo l1owALvpGGj13yoHVb0m;

			public long Id
			{
				[CompilerGenerated]
				get
				{
					return _003CId_003Ek__BackingField;
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
							_003CId_003Ek__BackingField = value;
							num2 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8a6cf36da0b84f319a7cf27018f28f5b == 0)
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

			public string Name
			{
				[CompilerGenerated]
				get
				{
					return _003CName_003Ek__BackingField;
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
							_003CName_003Ek__BackingField = value;
							num2 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4ef74b4b7d13430e9d2f9b78cbdb367b != 0)
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

			public long GroupId
			{
				[CompilerGenerated]
				get
				{
					return _003CGroupId_003Ek__BackingField;
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
							_003CGroupId_003Ek__BackingField = value;
							num2 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_26fa47f5bd8343debcae8b05a56a3ab5 != 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			public ProcessHeaderInfo(IProcessHeader processHeader)
			{
				//Discarded unreachable code: IL_002a, IL_002f
				RnPNkJvpoIap3yv5Gshe();
				base._002Ector();
				int num = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_978f838cc41a4debb9700ede4b63f820 != 0)
				{
					num = 1;
				}
				while (true)
				{
					switch (num)
					{
					default:
						return;
					case 1:
						Id = processHeader.Id;
						num = 3;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 == 0)
						{
							num = 1;
						}
						break;
					case 0:
						return;
					case 3:
						Name = (string)am4e3hvpFjMxJCrkw2q7(processHeader);
						num = 2;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_abfb511163674a3eae959fd60da8f319 == 0)
						{
							num = 2;
						}
						break;
					case 2:
						GroupId = ((NlR6i0vpiPRWeYeWpMHR(processHeader) != null) ? ((IEntity<long>)NlR6i0vpiPRWeYeWpMHR(processHeader)).Id : 0);
						num = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_85ba8d91af394836ac86666c40b1e150 == 0)
						{
							num = 0;
						}
						break;
					}
				}
			}

			public static void GetDescriptor(TypeSerializationDescriptorBuilder builder)
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
						builder.ItemWithDescriptor((string)Names.Id, delegate(TypeSerializationDescriptorBuilder i)
						{
							int num7 = 1;
							int num8 = num7;
							while (true)
							{
								switch (num8)
								{
								default:
									return;
								case 0:
									return;
								case 1:
									_003C_003Ec.RZEkgrvUYLYHDBOlg4cQ(i.Description(SR.T((string)_003C_003Ec.fLCxHnvUZVWIhg9yNSVl(0x101D10F ^ 0x1002443))), _003C_003Ec.uWXiPavUvPxgx1BLfCb2(typeof(long).TypeHandle));
									num8 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ecf910d183864897a7c8ec77e01689a4 == 0)
									{
										num8 = 0;
									}
									break;
								}
							}
						}).ItemWithDescriptor((string)Names.Name, delegate(TypeSerializationDescriptorBuilder i)
						{
							int num5 = 1;
							int num6 = num5;
							while (true)
							{
								switch (num6)
								{
								default:
									return;
								case 0:
									return;
								case 1:
									((TypeSerializationDescriptorBuilder)_003C_003Ec.PoRH4fvUsdlZOZ7DxabR(i, _003C_003Ec.EDhu5CvU8dH18WnG12Ti(_003C_003Ec.fLCxHnvUZVWIhg9yNSVl(-2057730233 ^ -2057665743)))).Type(_003C_003Ec.uWXiPavUvPxgx1BLfCb2(typeof(string).TypeHandle));
									num6 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 == 0)
									{
										num6 = 0;
									}
									break;
								}
							}
						}).ItemWithDescriptor((string)Names.GroupId, delegate(TypeSerializationDescriptorBuilder i)
						{
							int num3 = 1;
							int num4 = num3;
							while (true)
							{
								switch (num4)
								{
								default:
									return;
								case 0:
									return;
								case 1:
									((TypeSerializationDescriptorBuilder)_003C_003Ec.RZEkgrvUYLYHDBOlg4cQ(_003C_003Ec.PoRH4fvUsdlZOZ7DxabR(i, _003C_003Ec.EDhu5CvU8dH18WnG12Ti(_003C_003Ec.fLCxHnvUZVWIhg9yNSVl(-105863102 ^ -105665422))), _003C_003Ec.uWXiPavUvPxgx1BLfCb2(typeof(long).TypeHandle))).Optional((object)null);
									num4 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f05298ca2a4a4a639a58bc7f7d9ff7b9 == 0)
									{
										num4 = 0;
									}
									break;
								}
							}
						});
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}

			public WebData ToWebData()
			{
				int num = 3;
				Dictionary<string, object> dictionary = default(Dictionary<string, object>);
				while (true)
				{
					int num2 = num;
					while (true)
					{
						switch (num2)
						{
						case 4:
							dictionary[(string)Names.GroupId] = GroupId;
							num2 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 != 0)
							{
								num2 = 0;
							}
							continue;
						case 2:
							dictionary[(string)Names.Id] = Id;
							num2 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 == 0)
							{
								num2 = 1;
							}
							continue;
						case 5:
							if (GroupId != 0L)
							{
								num2 = 4;
								continue;
							}
							goto default;
						case 3:
							break;
						default:
							return new WebData(dictionary);
						case 1:
							dictionary[(string)Names.Name] = Name;
							num2 = 5;
							continue;
						}
						break;
					}
					dictionary = new Dictionary<string, object>();
					num = 2;
				}
			}

			internal static void RnPNkJvpoIap3yv5Gshe()
			{
				j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
			}

			internal static object am4e3hvpFjMxJCrkw2q7(object P_0)
			{
				return ((IProcessHeader)P_0).Name;
			}

			internal static object NlR6i0vpiPRWeYeWpMHR(object P_0)
			{
				return ((IProcessHeader)P_0).ParentGroup;
			}

			internal static bool TXDstgvp78k0FfALjbPA()
			{
				return l1owALvpGGj13yoHVb0m == null;
			}

			internal static ProcessHeaderInfo zpFQfNvp2x3xvMIVnLEd()
			{
				return l1owALvpGGj13yoHVb0m;
			}
		}

		internal const string MethodName = "StartableProcesses";

		internal static StartableProcessesMethodExecutor oLDcKJvRrBdNHFIbo4um;

		public static string Description => (string)eUbfGTvRSHgu9tyXxpOy(FtPaZDvRxyZSVktvkVjj(-2077784392 ^ -2077921760));

		public static TypeSerializationDescriptor ParametersDescriptor => new TypeSerializationDescriptorBuilder().Descriptor;

		public static TypeSerializationDescriptor ResultDescriptor => (TypeSerializationDescriptor)zGIw9NvR1Fk4Dus17pki(new TypeSerializationDescriptorBuilder().ItemWithDescriptor((string)FtPaZDvRxyZSVktvkVjj(-1638225214 ^ -1638383042), delegate(TypeSerializationDescriptorBuilder i)
		{
			int num3 = 1;
			int num4 = num3;
			while (true)
			{
				switch (num4)
				{
				default:
					return;
				case 1:
					((TypeSerializationDescriptorBuilder)_003C_003Ec.T8dT9wvpxUPJloa4XsFk(i, _003C_003Ec.HdWpklvpN0S248XoKBiw(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1965291699 ^ -1965098707)))).IsArray((Action<TypeSerializationDescriptorBuilder>)ProcessGroupInfo.GetDescriptor);
					num4 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f453500aaab143479696408f48a03c17 == 0)
					{
						num4 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}).ItemWithDescriptor((string)FtPaZDvRxyZSVktvkVjj(0xD305CC2 ^ 0xD30D17A), delegate(TypeSerializationDescriptorBuilder i)
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
					i.Description((string)_003C_003Ec.HdWpklvpN0S248XoKBiw(_003C_003Ec.WVyAm8vpSFSLStVjwjsv(-14356676 ^ -14282256))).IsArray(ProcessHeaderInfo.GetDescriptor);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6dd19c81ff5e41fb8db9b50574437301 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}));

		public StartableProcessesMethodExecutor(WebData parameters)
		{
			//Discarded unreachable code: IL_002b, IL_0030
			jjBhXJvRhgOPupbAvcxE();
			base._002Ector(parameters);
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_85ba8d91af394836ac86666c40b1e150 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		public override WebData Execute()
		{
			int num = 8;
			_003C_003Ec__DisplayClass9_0 _003C_003Ec__DisplayClass9_ = default(_003C_003Ec__DisplayClass9_0);
			WebData webData = default(WebData);
			List<IProcessHeader> source = default(List<IProcessHeader>);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 6:
						_003C_003Ec__DisplayClass9_.addGroup = null;
						num2 = 2;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 != 0)
						{
							num2 = 2;
						}
						continue;
					case 8:
						_003C_003Ec__DisplayClass9_ = new _003C_003Ec__DisplayClass9_0();
						num2 = 7;
						continue;
					case 2:
						_003C_003Ec__DisplayClass9_.addGroup = _003C_003Ec__DisplayClass9_._003CExecute_003Eb__2;
						num2 = 5;
						continue;
					case 3:
						webData = new WebData();
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe4a54387d744988feba4889229faf1 != 0)
						{
							num2 = 1;
						}
						continue;
					case 4:
						return webData;
					default:
						_003C_003Ec__DisplayClass9_.groups = new Dictionary<long, ProcessGroupDTO>();
						num2 = 6;
						continue;
					case 7:
						_003C_003Ec__DisplayClass9_.allGroups = (from g in ((ProcessGroupManager)WcBCn4vREEOu2aD5Qi0o()).LoadGroupsTree()
							where !_003C_003Ec.B8FcExvphwOP9J1VF5EV(_003C_003Ec.pHFTBsvp1E5UQ1laFK2B(g))
							select g).ToDictionary((ProcessGroupDTO g) => g.Id);
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae2bde9e5844c638021cdb56fc01122 != 0)
						{
							num2 = 0;
						}
						continue;
					case 5:
						source = (from h in ((ProcessHeaderManager)W7mQeQvRwswa4XfXAsEG()).GetStartableProcesses((IProcessHeaderFilter)null)
							where !_003C_003Ec.B8FcExvphwOP9J1VF5EV(h.Name)
							select h).Where(_003C_003Ec__DisplayClass9_._003CExecute_003Eb__4).ToList();
						num2 = 3;
						continue;
					case 1:
					{
						WebData webData2 = webData;
						WebDataItem[] array = new WebDataItem[2];
						WebDataItem webDataItem = new WebDataItem();
						UKGhLHvR4A65P8Gb3x6Q(webDataItem, FtPaZDvRxyZSVktvkVjj(0x1EA50FCC ^ 0x1EA7E730));
						HKteG0vRzxFFAAysVcC8(webDataItem, _003C_003Ec__DisplayClass9_.groups.Values.Select((ProcessGroupDTO g) => new ProcessGroupInfo(g).ToWebData()).ToArray());
						array[0] = webDataItem;
						WebDataItem webDataItem2 = new WebDataItem();
						UKGhLHvR4A65P8Gb3x6Q(webDataItem2, FtPaZDvRxyZSVktvkVjj(-1430645277 ^ -1430611877));
						webDataItem2.DataArray = source.Select((IProcessHeader ph) => new ProcessHeaderInfo(ph).ToWebData()).ToArray();
						array[1] = webDataItem2;
						webData2.Items = array;
						num = 4;
						break;
					}
					}
					break;
				}
			}
		}

		internal static object FtPaZDvRxyZSVktvkVjj(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object eUbfGTvRSHgu9tyXxpOy(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static bool CIH1O8vRetmIvXxDgIdm()
		{
			return oLDcKJvRrBdNHFIbo4um == null;
		}

		internal static StartableProcessesMethodExecutor magcsDvRN9VmDa3yuSZP()
		{
			return oLDcKJvRrBdNHFIbo4um;
		}

		internal static object zGIw9NvR1Fk4Dus17pki(object P_0)
		{
			return ((TypeSerializationDescriptorBuilder)P_0).Descriptor;
		}

		internal static void jjBhXJvRhgOPupbAvcxE()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}

		internal static object WcBCn4vREEOu2aD5Qi0o()
		{
			return ProcessGroupManager.Instance;
		}

		internal static object W7mQeQvRwswa4XfXAsEG()
		{
			return ProcessHeaderManager.Instance;
		}

		internal static void UKGhLHvR4A65P8Gb3x6Q(object P_0, object P_1)
		{
			((WebDataItem)P_0).Name = (string)P_1;
		}

		internal static void HKteG0vRzxFFAAysVcC8(object P_0, object P_1)
		{
			((WebDataItem)P_0).DataArray = (WebData[])P_1;
		}
	}

	internal class ExecuteUserTaskAsyncMethodExecutor : PublicServiceMethodExecutor
	{
		private static class Names
		{
		}

		internal const string MethodName = "ExecuteUserTaskAsync";

		private static ExecuteUserTaskAsyncMethodExecutor vvi3U6v6KdobbwYvAJ6M;

		public static string Description => (string)JTLs00v6YxP8LkrqhaPN(RF5aQDv6vEZLBN5054GD(-1514166050 ^ -1514323502));

		public static TypeSerializationDescriptor ParametersDescriptor => (TypeSerializationDescriptor)BudiIwv68raoI0RLsIXX(new TypeSerializationDescriptorBuilder().ItemWithDescriptor((string)RF5aQDv6vEZLBN5054GD(-45832783 ^ -45817033), delegate(TypeSerializationDescriptorBuilder i)
		{
			int num5 = 1;
			int num6 = num5;
			while (true)
			{
				switch (num6)
				{
				default:
					return;
				case 1:
					i.Description(SR.T((string)_003C_003Ec.jQXy5WvC0m8MmmJWuCdi(--296112178 ^ 0x11A4AF1A))).Type(_003C_003Ec.HApnc9vCy1OcclVo736D(typeof(long).TypeHandle));
					num6 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b != 0)
					{
						num6 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}).ItemWithDescriptor(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1657582555 ^ -1657578307), delegate(TypeSerializationDescriptorBuilder i)
		{
			int num3 = 1;
			int num4 = num3;
			while (true)
			{
				switch (num4)
				{
				default:
					return;
				case 1:
					_003C_003Ec.zNPEeuvCmC1JwQhsqDxx(i.Description(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638225214 ^ -1638367782))), _003C_003Ec.HApnc9vCy1OcclVo736D(typeof(WebData).TypeHandle));
					num4 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e8980a9fd9d44c20920ffa276900c96f != 0)
					{
						num4 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}).ItemWithDescriptor((string)RF5aQDv6vEZLBN5054GD(0x56F860D7 ^ 0x56FA89BF), delegate(TypeSerializationDescriptorBuilder i)
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
					_003C_003Ec.zNPEeuvCmC1JwQhsqDxx(_003C_003Ec.Fqrqw4vCbJQuXh8aL3EW(i, _003C_003Ec.KakSHkvCt1oTFuCDRROO(_003C_003Ec.jQXy5WvC0m8MmmJWuCdi(-947937941 ^ -948084161))), _003C_003Ec.HApnc9vCy1OcclVo736D(typeof(Guid).TypeHandle));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bd84f42638494cb6b4427f8e13ec59af == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}));

		public static TypeSerializationDescriptor ResultDescriptor => new TypeSerializationDescriptorBuilder().ItemWithDescriptor((string)RF5aQDv6vEZLBN5054GD(0x350C0E8 ^ 0x3522234), delegate(TypeSerializationDescriptorBuilder i)
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
					_003C_003Ec.zNPEeuvCmC1JwQhsqDxx(i.Description((string)_003C_003Ec.KakSHkvCt1oTFuCDRROO(_003C_003Ec.jQXy5WvC0m8MmmJWuCdi(-1895853023 ^ -1895994403))), _003C_003Ec.HApnc9vCy1OcclVo736D(typeof(bool).TypeHandle));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1de08766357542bdb81146373079f817 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}).ApplyParametersDescriptor().Descriptor;

		public ExecuteUserTaskAsyncMethodExecutor(WebData parameters)
		{
			//Discarded unreachable code: IL_002b, IL_0030
			hTPXXvv6saRncrwgoXx4();
			base._002Ector(parameters);
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		public override WebData Execute()
		{
			return ExecuteInternal();
		}

		private WebData ExecuteInternal()
		{
			//Discarded unreachable code: IL_00ab, IL_00e7, IL_018a, IL_0378
			int num = 10;
			IDictionary<string, object> dictionary2 = default(IDictionary<string, object>);
			WebDataItem webDataItem3 = default(WebDataItem);
			IWorkflowTaskBase workflowTaskBase = default(IWorkflowTaskBase);
			WebDataItem webDataItem = default(WebDataItem);
			Dictionary<string, object> dictionary = default(Dictionary<string, object>);
			WebDataItem webDataItem2 = default(WebDataItem);
			Guid result = default(Guid);
			long result2 = default(long);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 16:
						if (dictionary2.Any())
						{
							num2 = 4;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 != 0)
							{
								num2 = 3;
							}
							continue;
						}
						goto case 21;
					case 10:
						webDataItem3 = (WebDataItem)gIU9cSv6J2tsREe3s1nj(Parameters, RF5aQDv6vEZLBN5054GD(0x2F44D93A ^ 0x2F449FBC));
						num2 = 9;
						continue;
					case 4:
						new EntityJsonSerializer().ConvertFromSerializable(giBer9v6BkncYWPWIOb4(yIeAWev6gccxlF1SnfJV(OTvmXrv65oy3evDqD3ei(workflowTaskBase))), dictionary2);
						num2 = 21;
						continue;
					case 12:
						if (CqpvOOv6bGNqqchCSA1q(webDataItem) != null)
						{
							num2 = 24;
							continue;
						}
						goto case 21;
					case 11:
						if (workflowTaskBase is IWorkflowTask)
						{
							num2 = 4;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3bb28bf622874b4689f9265e58d14823 == 0)
							{
								num2 = 6;
							}
							continue;
						}
						goto case 5;
					case 18:
						ExecuteUserTaskStatusHelper.Execute(workflowTaskBase, dictionary);
						num2 = 16;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe4a54387d744988feba4889229faf1 != 0)
						{
							num2 = 17;
						}
						continue;
					default:
						throw odaqOXv6lpgwJOfCH83a(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1AF6F1F2 ^ 0x1AF41AF6)), 200);
					case 13:
						throw odaqOXv6lpgwJOfCH83a(JTLs00v6YxP8LkrqhaPN(RF5aQDv6vEZLBN5054GD(0xDF4D1F8 ^ 0xDF63B18)), 200);
					case 14:
						if (!X2ks2Rv6mCPtikAOISaj(aTrtl3v6ymYgAGEADJRM(webDataItem2)))
						{
							if (!Guid.TryParse((string)aTrtl3v6ymYgAGEADJRM(webDataItem2), out result))
							{
								num2 = 22;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3b4403f77a00495e957e5e4a6840e5d3 != 0)
								{
									num2 = 7;
								}
								continue;
							}
							webDataItem = (WebDataItem)gIU9cSv6J2tsREe3s1nj(F0JcqSv6t4A5AWcR92cv(this), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418337216 ^ 0x548A0B58));
							num = 8;
							break;
						}
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f == 0)
						{
							num2 = 0;
						}
						continue;
					case 19:
						throw odaqOXv6lpgwJOfCH83a(JTLs00v6YxP8LkrqhaPN(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x101D10F ^ 0x103389B)), 200);
					case 20:
						if (long.TryParse(webDataItem3.Value, out result2))
						{
							num2 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 != 0)
							{
								num2 = 1;
							}
							continue;
						}
						goto case 23;
					case 24:
						dictionary2 = ((WebData)CqpvOOv6bGNqqchCSA1q(webDataItem)).ToDictionary();
						num = 16;
						break;
					case 22:
						throw odaqOXv6lpgwJOfCH83a(JTLs00v6YxP8LkrqhaPN(RF5aQDv6vEZLBN5054GD(-1539486135 ^ -1539332849)), 200);
					case 15:
						if (!string.IsNullOrEmpty(webDataItem3.Value))
						{
							num2 = 20;
							continue;
						}
						goto case 19;
					case 23:
						throw odaqOXv6lpgwJOfCH83a(SR.T((string)RF5aQDv6vEZLBN5054GD(-763667953 ^ -763776035)), 200);
					case 1:
						workflowTaskBase = WorkflowTaskBaseManager.Instance.Load(result2).CastAsRealType();
						num2 = 11;
						continue;
					case 3:
						if (webDataItem2 == null)
						{
							num2 = 2;
							continue;
						}
						goto case 14;
					case 17:
						return new WebData(dictionary);
					case 5:
						throw odaqOXv6lpgwJOfCH83a(SR.T((string)RF5aQDv6vEZLBN5054GD(0x75872B6 ^ 0x75A98F0)), 200);
					case 6:
						if (!ERSyWcv60YY4T0gU6J4G(workflowTaskBase))
						{
							webDataItem2 = (WebDataItem)gIU9cSv6J2tsREe3s1nj(Parameters, RF5aQDv6vEZLBN5054GD(-25709590 ^ -25863550));
							num2 = 3;
							continue;
						}
						num2 = 4;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 != 0)
						{
							num2 = 13;
						}
						continue;
					case 9:
						if (webDataItem3 != null)
						{
							num2 = 15;
							continue;
						}
						goto case 19;
					case 7:
						dictionary = new Dictionary<string, object> { 
						{
							(string)RF5aQDv6vEZLBN5054GD(--1436248540 ^ 0x55998B00),
							true
						} };
						num2 = 18;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c559093b7320494babd70d164a6df42d != 0)
						{
							num2 = 18;
						}
						continue;
					case 8:
						if (webDataItem != null)
						{
							num2 = 8;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6d48f3b4557a49578bf7f5ef0517e0be != 0)
							{
								num2 = 12;
							}
							continue;
						}
						goto case 21;
					case 21:
						oATgq2v6cFBuQQjaQqax(workflowTaskBase, result);
						num = 7;
						break;
					}
					break;
				}
			}
		}

		internal static object RF5aQDv6vEZLBN5054GD(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object JTLs00v6YxP8LkrqhaPN(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static bool vtEuA7v6OrNqvbXmQC0l()
		{
			return vvi3U6v6KdobbwYvAJ6M == null;
		}

		internal static ExecuteUserTaskAsyncMethodExecutor AaCWmQv6ZNLmCl2V8QRX()
		{
			return vvi3U6v6KdobbwYvAJ6M;
		}

		internal static object BudiIwv68raoI0RLsIXX(object P_0)
		{
			return ((TypeSerializationDescriptorBuilder)P_0).Descriptor;
		}

		internal static void hTPXXvv6saRncrwgoXx4()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}

		internal static object gIU9cSv6J2tsREe3s1nj(object P_0, object P_1)
		{
			return ((WebData)P_0).FindItem((string)P_1);
		}

		internal static object odaqOXv6lpgwJOfCH83a(object P_0, int P_1)
		{
			return PublicServiceException.CreateWebFault((string)P_0, P_1);
		}

		internal static bool ERSyWcv60YY4T0gU6J4G(object P_0)
		{
			return ((ITaskBase)P_0).IsComplete();
		}

		internal static object aTrtl3v6ymYgAGEADJRM(object P_0)
		{
			return ((WebDataItem)P_0).Value;
		}

		internal static bool X2ks2Rv6mCPtikAOISaj(object P_0)
		{
			return string.IsNullOrEmpty((string)P_0);
		}

		internal static object F0JcqSv6t4A5AWcR92cv(object P_0)
		{
			return ((PublicServiceMethodExecutor)P_0).Parameters;
		}

		internal static object CqpvOOv6bGNqqchCSA1q(object P_0)
		{
			return ((WebDataItem)P_0).Data;
		}

		internal static object OTvmXrv65oy3evDqD3ei(object P_0)
		{
			return ((IWorkflowTaskBase)P_0).WorkflowBookmark;
		}

		internal static object yIeAWev6gccxlF1SnfJV(object P_0)
		{
			return ((IWorkflowBookmark)P_0).Instance;
		}

		internal static object giBer9v6BkncYWPWIOb4(object P_0)
		{
			return ((IWorkflowInstance)P_0).Context;
		}

		internal static void oATgq2v6cFBuQQjaQqax(object P_0, Guid connectorUid)
		{
			((IWorkflowTaskBase)P_0).Execute(connectorUid);
		}
	}

	internal class ExecuteUserTaskStatusMethodExecutor : PublicServiceMethodExecutor
	{
		private static class Names
		{
		}

		internal const string MethodName = "ExecuteUserTaskStatus";

		private static ExecuteUserTaskStatusMethodExecutor NpBLDhv6P8CkNYqihkie;

		public static string Description => (string)mA76Vav6DS7swPrVWD3O(es7sRxv6uh7Ti77MwPmt(-398691253 ^ -398549001));

		public static TypeSerializationDescriptor ParametersDescriptor => new TypeSerializationDescriptorBuilder().ItemWithDescriptor((string)es7sRxv6uh7Ti77MwPmt(-1514166050 ^ -1514315688), delegate(TypeSerializationDescriptorBuilder i)
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
					i.Description((string)_003C_003Ec.W99QxNvCDlQyZqhj1gY5(_003C_003Ec.dNhGpOvCuiGKEyTUr7tf(0x56F860D7 ^ 0x56FB60B5))).Type(_003C_003Ec.qoULkSvCnunsiVwVvNf5(typeof(string).TypeHandle));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_805f3361d2ba4dac8da4174f89314253 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}).Descriptor;

		public static TypeSerializationDescriptor ResultDescriptor => (TypeSerializationDescriptor)GaoK8Fv6nRgV7Kf8VU9u(new TypeSerializationDescriptorBuilder().ApplyParametersDescriptor(needUnknownStatus: true, needExecutionToken: false));

		public ExecuteUserTaskStatusMethodExecutor(WebData parameters)
		{
			//Discarded unreachable code: IL_002b, IL_0030
			GOftAEv6HUBghPc0Nmmb();
			base._002Ector(parameters);
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d87d9a74c9e14f96a288cc3620965fe0 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		public override WebData Execute()
		{
			return ExecuteInternal();
		}

		private WebData ExecuteInternal()
		{
			int num = 4;
			Dictionary<string, object> dictionary = default(Dictionary<string, object>);
			WebDataItem webDataItem = default(WebDataItem);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 2:
						return new WebData(dictionary);
					case 1:
						throw PublicServiceException.CreateWebFault((string)mA76Vav6DS7swPrVWD3O(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6CC04061 ^ 0x6CC2AC4D)));
					default:
						if (!cyZNo6v69vWqfuEefWfA(f45FnXv6fSxGuDcFb3Ho(webDataItem)))
						{
							goto end_IL_0012;
						}
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_85ba8d91af394836ac86666c40b1e150 != 0)
						{
							num2 = 1;
						}
						break;
					case 3:
						if (webDataItem != null)
						{
							num2 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0991fd79553c4ecc82e8b5cb79c2bff2 == 0)
							{
								num2 = 0;
							}
							break;
						}
						goto case 1;
					case 4:
						webDataItem = (WebDataItem)rkcXgjv6LHgt9Foq3nJI(Parameters, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2111219045 ^ -2111073763));
						num2 = 3;
						break;
					}
					continue;
					end_IL_0012:
					break;
				}
				string value = webDataItem.Value;
				dictionary = new Dictionary<string, object>();
				ExecuteUserTaskStatusHelper.Execute(value, dictionary);
				num = 2;
			}
		}

		internal static object es7sRxv6uh7Ti77MwPmt(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object mA76Vav6DS7swPrVWD3O(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static bool IyJr4Fv6Xbss0auFJmPa()
		{
			return NpBLDhv6P8CkNYqihkie == null;
		}

		internal static ExecuteUserTaskStatusMethodExecutor x9AWoiv6d5MRWusDy9NI()
		{
			return NpBLDhv6P8CkNYqihkie;
		}

		internal static object GaoK8Fv6nRgV7Kf8VU9u(object P_0)
		{
			return ((TypeSerializationDescriptorBuilder)P_0).Descriptor;
		}

		internal static void GOftAEv6HUBghPc0Nmmb()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}

		internal static object rkcXgjv6LHgt9Foq3nJI(object P_0, object P_1)
		{
			return ((WebData)P_0).FindItem((string)P_1);
		}

		internal static object f45FnXv6fSxGuDcFb3Ho(object P_0)
		{
			return ((WebDataItem)P_0).Value;
		}

		internal static bool cyZNo6v69vWqfuEefWfA(object P_0)
		{
			return string.IsNullOrEmpty((string)P_0);
		}
	}

	internal class TasksInfoMethodExecutor : PublicServiceMethodExecutor
	{
		private static class Names
		{
		}

		private class ContextEntitySerializationSelector : EntitySerializationSelector
		{
			internal static object xElwfovC9M4X1jDd6ME9;

			public ContextEntitySerializationSelector()
			{
				//Discarded unreachable code: IL_002a, IL_002f
				i0s8NHvCRhfOnD07sUWv();
				base._002Ector();
				int num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
			}

			internal static void i0s8NHvCRhfOnD07sUWv()
			{
				j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
			}

			internal static bool KQA6JovCWwlVFTFryEPv()
			{
				return xElwfovC9M4X1jDd6ME9 == null;
			}

			internal static ContextEntitySerializationSelector usRxSTvCjIGL43EPmevQ()
			{
				return (ContextEntitySerializationSelector)xElwfovC9M4X1jDd6ME9;
			}
		}

		internal class TaskForm
		{
			private static class Names
			{
				public static readonly object Id;

				public static readonly object TypeUid;

				public static readonly object IsAvailable;

				public static readonly object Context;

				public static readonly object Form;

				public static readonly object TaskDescription;

				public static readonly object Flows;

				public static readonly object ProcessInfo;

				public static readonly object DenyReassign;

				private static object PrN7dUvUJgBOD28hwtC4;

				static Names()
				{
					int num = 16;
					ParameterExpression parameterExpression = default(ParameterExpression);
					while (true)
					{
						int num2 = num;
						while (true)
						{
							switch (num2)
							{
							case 9:
								DenyReassign = LinqUtils.NameOf(Expression.Lambda<Func<TaskForm, object>>((Expression)DfBigsvUgXM5FY8j9juF(aBPlSevU5YOhK4rYZcLP(parameterExpression, (MethodInfo)TPDwBWvUbdbltwmm055C((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object)), new ParameterExpression[1] { parameterExpression }));
								num2 = 5;
								continue;
							case 3:
								Form = LinqUtils.NameOf(Expression.Lambda<Func<TaskForm, object>>((Expression)aBPlSevU5YOhK4rYZcLP(parameterExpression, (MethodInfo)TPDwBWvUbdbltwmm055C((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
								num2 = 6;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b876fa7b083748c8abf8c4b192a11078 != 0)
								{
									num2 = 7;
								}
								continue;
							case 6:
								parameterExpression = (ParameterExpression)XrwReyvUtHeApE9H8jAW(DcpBRhvUmSTTIaZ3xXr8(typeof(TaskForm).TypeHandle), eqDeKJvUBKJXgrT05wjY(-1542190822 ^ -1542172204));
								num2 = 9;
								continue;
							case 18:
								parameterExpression = Expression.Parameter(DcpBRhvUmSTTIaZ3xXr8(typeof(TaskForm).TypeHandle), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-961162596 ^ -961181102));
								num2 = 13;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 == 0)
								{
									num2 = 4;
								}
								continue;
							case 8:
								parameterExpression = (ParameterExpression)XrwReyvUtHeApE9H8jAW(DcpBRhvUmSTTIaZ3xXr8(typeof(TaskForm).TypeHandle), eqDeKJvUBKJXgrT05wjY(-14356676 ^ -14370830));
								num2 = 2;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a9be7e056b4e4b6e863b634c418144f1 != 0)
								{
									num2 = 12;
								}
								continue;
							default:
								Id = LinqUtils.NameOf(Expression.Lambda<Func<TaskForm, object>>((Expression)DfBigsvUgXM5FY8j9juF(aBPlSevU5YOhK4rYZcLP(parameterExpression, (MethodInfo)TPDwBWvUbdbltwmm055C((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), DcpBRhvUmSTTIaZ3xXr8(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
								num = 8;
								break;
							case 11:
								parameterExpression = Expression.Parameter(DcpBRhvUmSTTIaZ3xXr8(typeof(TaskForm).TypeHandle), (string)eqDeKJvUBKJXgrT05wjY(0x614CF569 ^ 0x614CADA7));
								num = 2;
								break;
							case 5:
								return;
							case 13:
								Context = LinqUtils.NameOf(Expression.Lambda<Func<TaskForm, object>>((Expression)aBPlSevU5YOhK4rYZcLP(parameterExpression, (MethodInfo)TPDwBWvUbdbltwmm055C((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
								num2 = 4;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9570b4a70465495fba22c942f586465a == 0)
								{
									num2 = 4;
								}
								continue;
							case 10:
								parameterExpression = (ParameterExpression)XrwReyvUtHeApE9H8jAW(typeof(TaskForm), eqDeKJvUBKJXgrT05wjY(-790221436 ^ -790203062));
								num2 = 14;
								continue;
							case 17:
								parameterExpression = (ParameterExpression)XrwReyvUtHeApE9H8jAW(typeof(TaskForm), eqDeKJvUBKJXgrT05wjY(-398691253 ^ -398709627));
								num2 = 14;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_60c5782a184b457aa78da2e5c62d4e27 == 0)
								{
									num2 = 19;
								}
								continue;
							case 2:
								ProcessInfo = LinqUtils.NameOf(Expression.Lambda<Func<TaskForm, object>>((Expression)aBPlSevU5YOhK4rYZcLP(parameterExpression, (MethodInfo)TPDwBWvUbdbltwmm055C((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
								num2 = 6;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_18b351a59a324c25b4f150a9771bcf69 != 0)
								{
									num2 = 5;
								}
								continue;
							case 7:
								parameterExpression = (ParameterExpression)XrwReyvUtHeApE9H8jAW(DcpBRhvUmSTTIaZ3xXr8(typeof(TaskForm).TypeHandle), eqDeKJvUBKJXgrT05wjY(-17847711 ^ -17829201));
								num2 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b1ab9396b25b43af8f32e24b1948be96 == 0)
								{
									num2 = 1;
								}
								continue;
							case 19:
								Flows = LinqUtils.NameOf(Expression.Lambda<Func<TaskForm, object>>(Expression.Property(parameterExpression, (MethodInfo)TPDwBWvUbdbltwmm055C((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
								num2 = 11;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2f119e188994b55be2499c193b880fb == 0)
								{
									num2 = 5;
								}
								continue;
							case 14:
								IsAvailable = LinqUtils.NameOf(Expression.Lambda<Func<TaskForm, object>>((Expression)DfBigsvUgXM5FY8j9juF(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), DcpBRhvUmSTTIaZ3xXr8(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
								num2 = 18;
								continue;
							case 15:
								parameterExpression = (ParameterExpression)XrwReyvUtHeApE9H8jAW(DcpBRhvUmSTTIaZ3xXr8(typeof(TaskForm).TypeHandle), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x51EF0063 ^ 0x51EF58AD));
								num2 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b != 0)
								{
									num2 = 0;
								}
								continue;
							case 16:
								EDuHo1vUymGl0JJGvfgn();
								num2 = 15;
								continue;
							case 12:
								TypeUid = LinqUtils.NameOf(Expression.Lambda<Func<TaskForm, object>>((Expression)DfBigsvUgXM5FY8j9juF(aBPlSevU5YOhK4rYZcLP(parameterExpression, (MethodInfo)TPDwBWvUbdbltwmm055C((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), DcpBRhvUmSTTIaZ3xXr8(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
								num2 = 10;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e8980a9fd9d44c20920ffa276900c96f == 0)
								{
									num2 = 1;
								}
								continue;
							case 1:
								TaskDescription = LinqUtils.NameOf(Expression.Lambda<Func<TaskForm, object>>(Expression.Property(parameterExpression, (MethodInfo)TPDwBWvUbdbltwmm055C((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
								num2 = 17;
								continue;
							case 4:
								parameterExpression = Expression.Parameter(typeof(TaskForm), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-865213812 ^ -865224126));
								num2 = 3;
								continue;
							}
							break;
						}
					}
				}

				internal static void EDuHo1vUymGl0JJGvfgn()
				{
					j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
				}

				internal static Type DcpBRhvUmSTTIaZ3xXr8(RuntimeTypeHandle P_0)
				{
					return Type.GetTypeFromHandle(P_0);
				}

				internal static object XrwReyvUtHeApE9H8jAW(Type P_0, object P_1)
				{
					return Expression.Parameter(P_0, (string)P_1);
				}

				internal static object TPDwBWvUbdbltwmm055C(RuntimeMethodHandle P_0)
				{
					return MethodBase.GetMethodFromHandle(P_0);
				}

				internal static object aBPlSevU5YOhK4rYZcLP(object P_0, object P_1)
				{
					return Expression.Property((Expression)P_0, (MethodInfo)P_1);
				}

				internal static object DfBigsvUgXM5FY8j9juF(object P_0, Type P_1)
				{
					return Expression.Convert((Expression)P_0, P_1);
				}

				internal static object eqDeKJvUBKJXgrT05wjY(int _0020)
				{
					return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
				}

				internal static bool Qv9547vUlAfLqkK3GR5K()
				{
					return PrN7dUvUJgBOD28hwtC4 == null;
				}

				internal static Names kaQSGGvU0unaty7pWIt8()
				{
					return (Names)PrN7dUvUJgBOD28hwtC4;
				}
			}

			private Action<TaskForm, Dictionary<string, object>> toWebDataHandler;

			private IWorkflowTaskBase task;

			private static TaskForm H3J8cavC6JLvrDLnqeRd;

			public long Id
			{
				[CompilerGenerated]
				get
				{
					return _003CId_003Ek__BackingField;
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
							_003CId_003Ek__BackingField = value;
							num2 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a27e75af798c48d692c4325f43aa9e6b == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			public Guid TypeUid
			{
				[CompilerGenerated]
				get
				{
					return _003CTypeUid_003Ek__BackingField;
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
							_003CTypeUid_003Ek__BackingField = value;
							num2 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_545887e65739480a965b7ddfab7d0632 != 0)
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

			public bool IsAvailable
			{
				[CompilerGenerated]
				get
				{
					return _003CIsAvailable_003Ek__BackingField;
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
							_003CIsAvailable_003Ek__BackingField = value;
							num2 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_719514a5a8ae47ed84e5a777ead0dc9f != 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			public WebData Context
			{
				[CompilerGenerated]
				get
				{
					return _003CContext_003Ek__BackingField;
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
							_003CContext_003Ek__BackingField = value;
							num2 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1b8b735647da470aa2d45d64d6f538d1 != 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			public EntityFormData Form
			{
				[CompilerGenerated]
				get
				{
					return _003CForm_003Ek__BackingField;
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
							_003CForm_003Ek__BackingField = value;
							num2 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5537a063960e465db83a04e35eea441b != 0)
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

			public string TaskDescription
			{
				[CompilerGenerated]
				get
				{
					return _003CTaskDescription_003Ek__BackingField;
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
							_003CTaskDescription_003Ek__BackingField = value;
							num2 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c == 0)
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

			public List<FlowItem> Flows { get; set; }

			public ProcessInfo ProcessInfo
			{
				[CompilerGenerated]
				get
				{
					return _003CProcessInfo_003Ek__BackingField;
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
							_003CProcessInfo_003Ek__BackingField = value;
							num2 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a23e27b648a042f098a477c26c4beed1 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			public bool DenyReassign
			{
				[CompilerGenerated]
				get
				{
					return _003CDenyReassign_003Ek__BackingField;
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
							_003CDenyReassign_003Ek__BackingField = value;
							num2 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1a2d7634479d44fb8d3718c31b05f73c != 0)
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

			public TaskForm(IWorkflowTaskBase task, Action<TaskForm, Dictionary<string, object>> toWebDataHandler)
			{
				j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
				this._002Ector(task);
				this.toWebDataHandler = toWebDataHandler;
			}

			public TaskForm(IWorkflowTaskBase task)
			{
				//Discarded unreachable code: IL_0033, IL_010f, IL_011e, IL_01e4, IL_021b, IL_037b, IL_038a, IL_03e8, IL_042d, IL_043c, IL_044b, IL_055b, IL_069b, IL_06ae, IL_06bd, IL_06cd
				FNU7fVvCT6qGHwvoOeDr();
				_003C_003Ec__DisplayClass2_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass2_0();
				CS_0024_003C_003E8__locals0.task = task;
				base._002Ector();
				int num = 36;
				BPMNFlowElement bPMNFlowElement = default(BPMNFlowElement);
				WorkflowInstanceContext workflowInstanceContext = default(WorkflowInstanceContext);
				FormView formView = default(FormView);
				IElementCheckPublicApplication elementCheckPublicApplication = default(IElementCheckPublicApplication);
				EntityMetadata entityMetadata = default(EntityMetadata);
				List<IPublicApplicationCompatibilityError> list = default(List<IPublicApplicationCompatibilityError>);
				Element element = default(Element);
				ClassMetadata classMetadata = default(ClassMetadata);
				ActionDispatcherService serviceNotNull = default(ActionDispatcherService);
				List<FlowConnectorElement>.Enumerator enumerator = default(List<FlowConnectorElement>.Enumerator);
				FlowConnectorElement current = default(FlowConnectorElement);
				string name = default(string);
				while (true)
				{
					switch (num)
					{
					case 8:
						TaskDescription = CS_0024_003C_003E8__locals0.task.Description;
						num = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1de08766357542bdb81146373079f817 != 0)
						{
							num = 0;
						}
						break;
					case 15:
						if (bPMNFlowElement.StandardOutputFlows == null)
						{
							num = 3;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2f119e188994b55be2499c193b880fb != 0)
							{
								num = 5;
							}
							break;
						}
						goto case 13;
					case 18:
						Form = new EntityFormData(workflowInstanceContext.CastAsRealType().GetType(), formView);
						num = 8;
						break;
					case 14:
						elementCheckPublicApplication.CheckPublicApplicationCompatibility(entityMetadata, entityMetadata.GetPropertiesAndTableParts(), list);
						num = 37;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58fb165cafed422d973d4a7156526541 == 0)
						{
							num = 8;
						}
						break;
					case 34:
						element = ((IEnumerable<Element>)LxMHcjvCAef9NmvXfZ4N(W8dpHqvCVRj3ZfLxihsb(y8L8juvCUN9vrEXL9MWP(hr4GI9vCMP7waVrQXX6x(yeJCOovCC1i06WGdcy9M(CS_0024_003C_003E8__locals0.task)))))).FirstOrDefault(delegate(Element e)
						{
							//Discarded unreachable code: IL_0098
							int num6 = 4;
							int num7 = num6;
							Guid guid = default(Guid);
							Guid? elementUid = default(Guid?);
							while (true)
							{
								switch (num7)
								{
								case 2:
									return false;
								case 1:
									return _003C_003Ec__DisplayClass2_0.WR60UnvUDWhRF8X47aoj(guid, elementUid.GetValueOrDefault());
								default:
									if (elementUid.HasValue)
									{
										num7 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 == 0)
										{
											num7 = 1;
										}
										break;
									}
									goto case 2;
								case 3:
									elementUid = ((IWorkflowBookmark)_003C_003Ec__DisplayClass2_0.kxnVGfvUuImwx7u9G7Yq(CS_0024_003C_003E8__locals0.task)).ElementUid;
									num7 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_43af423d081c48e3bc6cea30ce47523d == 0)
									{
										num7 = 0;
									}
									break;
								case 4:
									guid = _003C_003Ec__DisplayClass2_0.HZJY4CvUdpI1Mf9GLeRV(e);
									num7 = 3;
									break;
								}
							}
						});
						num = 28;
						break;
					case 25:
						return;
					case 4:
						ProcessInfo = new ProcessInfo(CS_0024_003C_003E8__locals0.task.WorkflowBookmark.Instance);
						num = 7;
						break;
					case 2:
						return;
					case 5:
					case 11:
						elementCheckPublicApplication = element as IElementCheckPublicApplication;
						num = 10;
						break;
					case 9:
						if (formView != null)
						{
							num = 12;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6b089b0d02ae4d3186c8d2cb8a24d4d3 == 0)
							{
								num = 18;
							}
							break;
						}
						goto case 29;
					case 21:
						if (!elementCheckPublicApplication.CanCheckPublicApplicationCompatibility)
						{
							num = 24;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6b089b0d02ae4d3186c8d2cb8a24d4d3 == 0)
							{
								num = 24;
							}
							break;
						}
						goto case 16;
					case 10:
						if (elementCheckPublicApplication == null)
						{
							num = 13;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_558b46b4f4364838b08ac89d77f9a257 == 0)
							{
								num = 22;
							}
							break;
						}
						goto case 21;
					case 20:
						classMetadata = (ClassMetadata)HNIufOvCQXVxKtqLmA1t(CS_0024_003C_003E8__locals0.task.CastAsRealType().GetType(), true, true);
						num = 35;
						break;
					case 36:
						this.task = CS_0024_003C_003E8__locals0.task;
						num = 19;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eef7d2ca1c3c4b74aeb81172ed542639 == 0)
						{
							num = 5;
						}
						break;
					case 31:
						entityMetadata = (EntityMetadata)MetadataLoader.LoadMetadata(workflowInstanceContext.CastAsRealType().GetType());
						num = 34;
						break;
					case 13:
						Flows = new List<FlowItem>();
						num = 17;
						break;
					case 1:
						IsAvailable = false;
						num = 20;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b == 0)
						{
							num = 7;
						}
						break;
					case 19:
						Id = CS_0024_003C_003E8__locals0.task.Id;
						num = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a23e27b648a042f098a477c26c4beed1 == 0)
						{
							num = 0;
						}
						break;
					case 23:
						if (bPMNFlowElement != null)
						{
							num = 15;
							break;
						}
						goto case 5;
					case 35:
						TypeUid = qpuwqJvCpu6PD0yMBXsi(classMetadata);
						num = 3;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a != 0)
						{
							num = 0;
						}
						break;
					case 27:
					{
						serviceNotNull = Locator.GetServiceNotNull<ActionDispatcherService>();
						int num5 = 33;
						num = num5;
						break;
					}
					case 12:
						try
						{
							while (true)
							{
								IL_04f3:
								int num2;
								if (!enumerator.MoveNext())
								{
									num2 = 8;
									goto IL_03f6;
								}
								goto IL_0456;
								IL_03f6:
								while (true)
								{
									object obj3;
									switch (num2)
									{
									case 6:
										break;
									default:
									{
										TextTemplateGenerator textTemplateGenerator = new TextTemplateGenerator((string)WvD3ApvCeXjwjl5xmF2T(current));
										NotificationElement.DataSource dataSource = new NotificationElement.DataSource();
										IdRytXvCNl9rHqhDCaAA(dataSource, ((IWorkflowBookmark)yeJCOovCC1i06WGdcy9M(CS_0024_003C_003E8__locals0.task)).Instance);
										dpPmW7vCxoBpP65LhuUp(dataSource, Wxw2wlvCkopW4WDdGkPF(hr4GI9vCMP7waVrQXX6x(CS_0024_003C_003E8__locals0.task.WorkflowBookmark)));
										NotificationElement.DataSource dataSourceObject = dataSource;
										name = textTemplateGenerator.Generate(dataSourceObject);
										int num3 = 5;
										num2 = num3;
										continue;
									}
									case 7:
										if (!xKM5FwvCFV8ye4hlpXRh(current.Name))
										{
											num2 = 4;
											continue;
										}
										goto case 9;
									case 2:
										goto IL_04f3;
									case 1:
										if (!ehEa9NvCrZoHheHFJZWJ(current))
										{
											num2 = 3;
											continue;
										}
										goto default;
									case 9:
										obj3 = (string)zn0PKgvCir2Al6pkOHRe(0x75872B6 ^ 0x75A9CAE) + (string)((BxA2divCIX5tJnp0KTUS(current) != null) ? eIh5NyvCae5fHCyKeTyG(BxA2divCIX5tJnp0KTUS(current)) : "");
										goto IL_0567;
									case 4:
										obj3 = eIh5NyvCae5fHCyKeTyG(current);
										goto IL_0567;
									case 3:
									case 5:
									{
										List<FlowItem> flows = Flows;
										FlowItem obj2 = new FlowItem
										{
											Name = name
										};
										D7KlhmvCSl4k95doDr8W(obj2, current.Description);
										pXK7VPvC1teBDMB8LQUO(obj2, current.Uid);
										psZMMuvCEY4fg54oNtxW(obj2, PvSGLYvChlYxTrEJMrSS(current));
										wYbovfvCwPLgoNPF07Hd(obj2, (current.ColorConnectorButton != 0) ? current.ColorConnectorButton.ToString() : null);
										lQjtNxvCzunLKQc61du1(obj2, yktb23vC4f8jAClB9r9H(current));
										obj2.ValidateContextVariables = EtpUMovMKD3Yb8QiTxYn(current);
										KtuPxhvMZ7Cu3GvmlJ5E(obj2, mvVVbhvMOGQGjd1OdSMY(current));
										xjAm6WvMY716lO0C2rm7(obj2, Tvr540vMvkpsmstvaYM8(current));
										obj2.EnableComment = ofnYHcvM8opOuXwd8uBW(current);
										OAn0UmvMJNZIiA6Do7Em(obj2, hQtiFlvMsomsVkFTw5ne(current));
										tpRPZjvMlGg9dbHqLxeA(obj2, current.IsDefault);
										obj2.IsSignNeeded = VmiaDavM0cDfjZQ9L3p8(current);
										obj2.SignType = q5idDLvMyLvD9oh28t1h(current);
										flows.Add(obj2);
										num2 = 2;
										continue;
									}
									case 8:
										goto end_IL_04f3;
										IL_0567:
										name = (string)obj3;
										num2 = 1;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 == 0)
										{
											num2 = 1;
										}
										continue;
									}
									break;
								}
								goto IL_0456;
								IL_0456:
								current = enumerator.Current;
								num2 = 3;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_938c6be4ea2248868d7ed5d0e3346006 != 0)
								{
									num2 = 7;
								}
								goto IL_03f6;
								continue;
								end_IL_04f3:
								break;
							}
						}
						finally
						{
							((IDisposable)enumerator).Dispose();
							int num4 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3b4403f77a00495e957e5e4a6840e5d3 == 0)
							{
								num4 = 0;
							}
							switch (num4)
							{
							case 0:
								break;
							}
						}
						goto case 5;
					case 28:
						if (element == null)
						{
							return;
						}
						num = 4;
						break;
					case 7:
						formView = (FormView)RQ9gUsvCGkewteCLOWPd(CS_0024_003C_003E8__locals0.task);
						num = 3;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a27e75af798c48d692c4325f43aa9e6b != 0)
						{
							num = 9;
						}
						break;
					case 29:
						bPMNFlowElement = element as BPMNFlowElement;
						num = 23;
						break;
					case 6:
						return;
					case 22:
					case 24:
					case 32:
						IsAvailable = true;
						num = 27;
						break;
					case 26:
						return;
					case 30:
						workflowInstanceContext = (WorkflowInstanceContext)Wxw2wlvCkopW4WDdGkPF(hr4GI9vCMP7waVrQXX6x(yeJCOovCC1i06WGdcy9M(CS_0024_003C_003E8__locals0.task)));
						num = 31;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 == 0)
						{
							num = 8;
						}
						break;
					case 3:
						if (yeJCOovCC1i06WGdcy9M(CS_0024_003C_003E8__locals0.task) == null)
						{
							return;
						}
						num = 30;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f508947b0d94af1961e5aa17a8a2044 != 0)
						{
							num = 20;
						}
						break;
					case 16:
						list = new List<IPublicApplicationCompatibilityError>();
						num = 14;
						break;
					case 17:
						enumerator = bPMNFlowElement.StandardOutputFlows.GetEnumerator();
						num = 12;
						break;
					default:
					{
						WorkflowInstanceContext entity = workflowInstanceContext;
						EntitySerializationSettings entitySerializationSettings = new EntitySerializationSettings();
						DAMHGTvC7SlWZyI8hiAS(entitySerializationSettings, ContextSerializationFunctions);
						EntitySerializationSelector obj = new EntitySerializationSelector
						{
							Properties = CreateEntitySerializationSelectorProperties(entityMetadata, formView.FindItems(ignoreHide: false, (ViewItem i) => i is PropertyViewItem, (ViewItem i) => !(i is PropertyViewItem)).Cast<PropertyViewItem>())
						};
						KdhHP3vC2gFtrItagTHr(obj, SelectionMode.ByName);
						WQeqn2vCouZqce9dadOi(entitySerializationSettings, obj);
						Context = WebData.CreateFromEntity(entity, entitySerializationSettings);
						num = 29;
						break;
					}
					case 37:
						if (list.Any((IPublicApplicationCompatibilityError e) => _003C_003Ec.A6ZGStvU9o6kb8ZF2RDE(e)))
						{
							return;
						}
						num = 32;
						break;
					case 33:
					{
						int denyReassign;
						if (vkMlr7vMmZCOBoG53bgr(CS_0024_003C_003E8__locals0.task))
						{
							ActionDispatcherService service = serviceNotNull;
							ParameterExpression parameterExpression = (ParameterExpression)yYrO0dvMbO9syaYNXrEW(Ndt4y3vMt2vyEa5xYeY2(typeof(TaskBaseManager).TypeHandle), zn0PKgvCir2Al6pkOHRe(-801808857 ^ -801881591));
							denyReassign = ((!service.CheckAction(Expression.Lambda<Action<TaskBaseManager>>((Expression)rW7HQSvML4X9tlQJar6y(parameterExpression, (MethodInfo)RYk0DQvM59NViuqJ8p5N((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(TaskBaseManager<ITaskBase>).TypeHandle), new Expression[1] { Expression.Property((Expression)WKZanfvMHe3kytR99IBF(mMQUujvMgePtIfd0V9hY(Ndt4y3vMt2vyEa5xYeY2(typeof(InstanceOf<IReAssignActionModel>).TypeHandle)), new MemberBinding[1] { (MemberBinding)VbX8NPvMnl5aVCS0n52n((MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(InstanceOf<IReAssignActionModel>).TypeHandle), new MemberBinding[5]
							{
								(MemberBinding)gbkEokvMdFZ320KLEL3Y((MethodInfo)nrILH6vMBKCrqVGb3cox((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), OgPXwovMXu8TcYloHsD7(kxl0JevMPYXVyxKUjePE(D8RgXNvMcEnREo0OQPcU(CS_0024_003C_003E8__locals0, typeof(_003C_003Ec__DisplayClass2_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)RYk0DQvM59NViuqJ8p5N((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(IEntity<long>).TypeHandle))),
								(MemberBinding)gbkEokvMdFZ320KLEL3Y((MethodInfo)nrILH6vMBKCrqVGb3cox((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), Expression.Coalesce((Expression)OgPXwovMXu8TcYloHsD7(kxl0JevMPYXVyxKUjePE(D8RgXNvMcEnREo0OQPcU(CS_0024_003C_003E8__locals0, typeof(_003C_003Ec__DisplayClass2_0)), JlfcgkvMuLe53PHrGvFr((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)nrILH6vMBKCrqVGb3cox((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (Expression)kxl0JevMPYXVyxKUjePE(null, JlfcgkvMuLe53PHrGvFr((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)))),
								(MemberBinding)gbkEokvMdFZ320KLEL3Y((MethodInfo)nrILH6vMBKCrqVGb3cox((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), Gtdi9TvMDIiWQM4H7mKs(OgPXwovMXu8TcYloHsD7(kxl0JevMPYXVyxKUjePE(D8RgXNvMcEnREo0OQPcU(CS_0024_003C_003E8__locals0, typeof(_003C_003Ec__DisplayClass2_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), kxl0JevMPYXVyxKUjePE(null, FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)))),
								(MemberBinding)gbkEokvMdFZ320KLEL3Y((MethodInfo)nrILH6vMBKCrqVGb3cox((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), Expression.Property(Expression.Field((Expression)D8RgXNvMcEnREo0OQPcU(CS_0024_003C_003E8__locals0, typeof(_003C_003Ec__DisplayClass2_0)), (FieldInfo)JlfcgkvMuLe53PHrGvFr((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)nrILH6vMBKCrqVGb3cox((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/))),
								(MemberBinding)gbkEokvMdFZ320KLEL3Y((MethodInfo)nrILH6vMBKCrqVGb3cox((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), Expression.Property(Expression.Field((Expression)D8RgXNvMcEnREo0OQPcU(CS_0024_003C_003E8__locals0, Ndt4y3vMt2vyEa5xYeY2(typeof(_003C_003Ec__DisplayClass2_0).TypeHandle)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)))
							}) }), (MethodInfo)RYk0DQvM59NViuqJ8p5N((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(InstanceOf<IReAssignActionModel>).TypeHandle)) }), new ParameterExpression[1] { parameterExpression }), CS_0024_003C_003E8__locals0.task.CastAsRealType().GetType())) ? 1 : 0);
						}
						else
						{
							denyReassign = 1;
						}
						DenyReassign = (byte)denyReassign != 0;
						num = 2;
						break;
					}
					}
				}
			}

			public static void GetDescriptor(TypeSerializationDescriptorBuilder builder)
			{
				int num = 3;
				int num2 = num;
				_003C_003Ec__DisplayClass41_0 _003C_003Ec__DisplayClass41_ = default(_003C_003Ec__DisplayClass41_0);
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						((ComponentManager)aLrAUyvMfmMXoIwwylrt()).GetExtensionPoints<IWorkflowPublicServiceTaskFormExtension>().Each(_003C_003Ec__DisplayClass41_._003CGetDescriptor_003Eb__9);
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7ed81ca3cf804abbade4684f28f485d1 != 0)
						{
							num2 = 0;
						}
						break;
					case 2:
						_003C_003Ec__DisplayClass41_.builder = builder;
						num2 = 4;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1b8b735647da470aa2d45d64d6f538d1 == 0)
						{
							num2 = 2;
						}
						break;
					case 0:
						return;
					case 3:
						_003C_003Ec__DisplayClass41_ = new _003C_003Ec__DisplayClass41_0();
						num2 = 2;
						break;
					case 4:
						_003C_003Ec__DisplayClass41_.builder.ItemWithDescriptor((string)Names.Id, delegate(TypeSerializationDescriptorBuilder i)
						{
							int num19 = 1;
							int num20 = num19;
							while (true)
							{
								switch (num20)
								{
								default:
									return;
								case 1:
									_003C_003Ec.jdJfwwvUq0VagmUKSy9B(_003C_003Ec.dpymP9vURTE3ibiDLi2a(i, _003C_003Ec.huuc2ZvUjM02MTjiv0X8(_003C_003Ec.HV6ifZvUW8KWA7nL0kWF(0x1C7F6FED ^ 0x1C7D90C5))), _003C_003Ec.nON7qbvU6sK0uUaLwVD0(typeof(long).TypeHandle));
									num20 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d87d9a74c9e14f96a288cc3620965fe0 == 0)
									{
										num20 = 0;
									}
									break;
								case 0:
									return;
								}
							}
						}).ItemWithDescriptor((string)Names.TypeUid, delegate(TypeSerializationDescriptorBuilder i)
						{
							int num17 = 1;
							int num18 = num17;
							while (true)
							{
								switch (num18)
								{
								default:
									return;
								case 1:
									_003C_003Ec.jdJfwwvUq0VagmUKSy9B(_003C_003Ec.dpymP9vURTE3ibiDLi2a(i, _003C_003Ec.huuc2ZvUjM02MTjiv0X8(_003C_003Ec.HV6ifZvUW8KWA7nL0kWF(0x75872B6 ^ 0x75B7624))), _003C_003Ec.nON7qbvU6sK0uUaLwVD0(typeof(Guid).TypeHandle));
									num18 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6fe3beca34a9422e873cd6ef331760ae == 0)
									{
										num18 = 0;
									}
									break;
								case 0:
									return;
								}
							}
						}).ItemWithDescriptor((string)Names.IsAvailable, delegate(TypeSerializationDescriptorBuilder i)
						{
							int num15 = 1;
							int num16 = num15;
							while (true)
							{
								switch (num16)
								{
								default:
									return;
								case 1:
									_003C_003Ec.jdJfwwvUq0VagmUKSy9B(_003C_003Ec.dpymP9vURTE3ibiDLi2a(i, _003C_003Ec.huuc2ZvUjM02MTjiv0X8(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1AF6F1F2 ^ 0x1AF5F52C))), _003C_003Ec.nON7qbvU6sK0uUaLwVD0(typeof(bool).TypeHandle));
									num16 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e632863bfb124ba083e3ba9b363fd70e != 0)
									{
										num16 = 0;
									}
									break;
								case 0:
									return;
								}
							}
						})
							.ItemWithDescriptor((string)Names.Context, delegate(TypeSerializationDescriptorBuilder i)
							{
								int num13 = 1;
								int num14 = num13;
								while (true)
								{
									switch (num14)
									{
									default:
										return;
									case 1:
										_003C_003Ec.jdJfwwvUq0VagmUKSy9B(i.Description((string)_003C_003Ec.huuc2ZvUjM02MTjiv0X8(_003C_003Ec.HV6ifZvUW8KWA7nL0kWF(-790221436 ^ -790300004))), _003C_003Ec.nON7qbvU6sK0uUaLwVD0(typeof(WebData).TypeHandle));
										num14 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae2bde9e5844c638021cdb56fc01122 != 0)
										{
											num14 = 0;
										}
										break;
									case 0:
										return;
									}
								}
							})
							.ItemWithDescriptor((string)Names.Form, delegate(TypeSerializationDescriptorBuilder i)
							{
								int num11 = 1;
								int num12 = num11;
								while (true)
								{
									switch (num12)
									{
									default:
										return;
									case 1:
										i.ItemWithDescriptor(SR.T((string)_003C_003Ec.HV6ifZvUW8KWA7nL0kWF(0x4940763B ^ 0x4943730D)), EntityFormData.GetDescriptor);
										num12 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_61395ebf330446ac8ce99b55ee3acfa9 == 0)
										{
											num12 = 0;
										}
										break;
									case 0:
										return;
									}
								}
							})
							.ItemWithDescriptor((string)Names.TaskDescription, delegate(TypeSerializationDescriptorBuilder i)
							{
								int num9 = 1;
								int num10 = num9;
								while (true)
								{
									switch (num10)
									{
									default:
										return;
									case 0:
										return;
									case 1:
										_003C_003Ec.pk4NcIvU3U1pF6jQ7DS9(_003C_003Ec.jdJfwwvUq0VagmUKSy9B(_003C_003Ec.dpymP9vURTE3ibiDLi2a(i, _003C_003Ec.huuc2ZvUjM02MTjiv0X8(_003C_003Ec.HV6ifZvUW8KWA7nL0kWF(0x246EEF98 ^ 0x246DEAEA))), typeof(string)), null);
										num10 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 == 0)
										{
											num10 = 0;
										}
										break;
									}
								}
							})
							.ItemWithDescriptor((string)Names.Flows, delegate(TypeSerializationDescriptorBuilder i)
							{
								int num7 = 1;
								int num8 = num7;
								while (true)
								{
									switch (num8)
									{
									default:
										return;
									case 0:
										return;
									case 1:
										((TypeSerializationDescriptorBuilder)_003C_003Ec.dpymP9vURTE3ibiDLi2a(i, _003C_003Ec.huuc2ZvUjM02MTjiv0X8(_003C_003Ec.HV6ifZvUW8KWA7nL0kWF(-1647793954 ^ -1647596214)))).IsArray((Action<TypeSerializationDescriptorBuilder>)FlowItem.GetDescriptor);
										num8 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4459fbe344a947429d197733d274ef68 != 0)
										{
											num8 = 0;
										}
										break;
									}
								}
							})
							.ItemWithDescriptor((string)Names.ProcessInfo, delegate(TypeSerializationDescriptorBuilder i)
							{
								int num5 = 1;
								int num6 = num5;
								while (true)
								{
									switch (num6)
									{
									default:
										return;
									case 0:
										return;
									case 1:
										i.ItemWithDescriptor((string)_003C_003Ec.huuc2ZvUjM02MTjiv0X8(_003C_003Ec.HV6ifZvUW8KWA7nL0kWF(-10408775 ^ -10393885)), ProcessInfo.GetDescriptor);
										num6 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3b4403f77a00495e957e5e4a6840e5d3 == 0)
										{
											num6 = 0;
										}
										break;
									}
								}
							})
							.ItemWithDescriptor((string)Names.DenyReassign, delegate(TypeSerializationDescriptorBuilder i)
							{
								int num3 = 1;
								int num4 = num3;
								while (true)
								{
									switch (num4)
									{
									default:
										return;
									case 1:
										_003C_003Ec.pk4NcIvU3U1pF6jQ7DS9(i.Description(SR.T((string)_003C_003Ec.HV6ifZvUW8KWA7nL0kWF(-1600060848 ^ -1599993936))).Type(typeof(bool)), null);
										num4 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d843b0b7f23e489fb6d586d64b0a634a == 0)
										{
											num4 = 0;
										}
										break;
									case 0:
										return;
									}
								}
							});
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 == 0)
						{
							num2 = 1;
						}
						break;
					}
				}
			}

			public WebData ToWebData(bool needId)
			{
				//Discarded unreachable code: IL_008d, IL_032e, IL_035b, IL_036a
				int num = 7;
				_003C_003Ec__DisplayClass42_0 _003C_003Ec__DisplayClass42_ = default(_003C_003Ec__DisplayClass42_0);
				Dictionary<string, object> dictionary = default(Dictionary<string, object>);
				while (true)
				{
					int num2 = num;
					while (true)
					{
						switch (num2)
						{
						case 7:
							_003C_003Ec__DisplayClass42_ = new _003C_003Ec__DisplayClass42_0();
							num2 = 6;
							break;
						case 8:
							return _003C_003Ec__DisplayClass42_.webData;
						case 25:
							dictionary[(string)Names.Form] = Form.ToWebData();
							num2 = 10;
							break;
						case 13:
							dictionary[(string)Names.IsAvailable] = IsAvailable;
							num2 = 20;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_61395ebf330446ac8ce99b55ee3acfa9 != 0)
							{
								num2 = 24;
							}
							break;
						case 16:
							dictionary[(string)Names.ProcessInfo] = ProcessInfo.ToWebData();
							num2 = 18;
							break;
						case 3:
						case 5:
							if (toWebDataHandler != null)
							{
								num2 = 19;
								break;
							}
							goto case 9;
						case 23:
							dictionary[(string)Names.DenyReassign] = DenyReassign;
							num2 = 3;
							break;
						case 24:
							dictionary[(string)Names.TypeUid] = TypeUid;
							num2 = 12;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 != 0)
							{
								num2 = 7;
							}
							break;
						case 9:
							_003C_003Ec__DisplayClass42_.webData = new WebData(dictionary);
							num2 = 22;
							break;
						case 2:
						case 11:
							if (Flows != null)
							{
								num2 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6b089b0d02ae4d3186c8d2cb8a24d4d3 == 0)
								{
									num2 = 1;
								}
								break;
							}
							goto case 20;
						case 15:
							if (needId)
							{
								num2 = 4;
								break;
							}
							goto case 13;
						default:
							dictionary = new Dictionary<string, object>();
							num2 = 8;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f453500aaab143479696408f48a03c17 == 0)
							{
								num2 = 15;
							}
							break;
						case 19:
							toWebDataHandler(this, dictionary);
							num2 = 9;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b == 0)
							{
								num2 = 6;
							}
							break;
						case 20:
							if (ProcessInfo != null)
							{
								num2 = 16;
								break;
							}
							goto case 18;
						case 4:
							dictionary[(string)Names.Id] = Id;
							num2 = 13;
							break;
						case 22:
							((ComponentManager)aLrAUyvMfmMXoIwwylrt()).GetExtensionPoints<IWorkflowPublicServiceTaskFormExtension>().Each(_003C_003Ec__DisplayClass42_._003CToWebData_003Eb__1);
							num2 = 8;
							break;
						case 17:
							dictionary[(string)Names.Context] = Context;
							num2 = 21;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f33560c5d18b4e10b24a458578aa60fd != 0)
							{
								num2 = 21;
							}
							break;
						case 12:
							if (Context == null)
							{
								goto end_IL_0012;
							}
							goto case 17;
						case 21:
						case 26:
							if (Form != null)
							{
								num2 = 25;
								break;
							}
							goto case 10;
						case 6:
							_003C_003Ec__DisplayClass42_._003C_003E4__this = this;
							num2 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f8ecc99a1f4a4b6abc73e9b50261ea83 == 0)
							{
								num2 = 0;
							}
							break;
						case 18:
							if (!DenyReassign)
							{
								num2 = 5;
								break;
							}
							goto case 23;
						case 14:
							dictionary[(string)Names.TaskDescription] = TaskDescription;
							num2 = 11;
							break;
						case 10:
							if (daGlSDvM9nZlfqq7HdTm(TaskDescription))
							{
								num2 = 2;
								break;
							}
							goto case 14;
						case 1:
							dictionary[(string)Names.Flows] = new SerializableList<object>(Flows.Select((FlowItem fi) => (WebData)_003C_003Ec.dQEDEevUTdMilmL5gof6(fi)));
							num2 = 20;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 == 0)
							{
								num2 = 8;
							}
							break;
						}
						continue;
						end_IL_0012:
						break;
					}
					num = 26;
				}
			}

			internal static void FNU7fVvCT6qGHwvoOeDr()
			{
				j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
			}

			internal static object HNIufOvCQXVxKtqLmA1t(Type P_0, bool P_1, bool P_2)
			{
				return MetadataLoader.LoadMetadata(P_0, P_1, P_2);
			}

			internal static Guid qpuwqJvCpu6PD0yMBXsi(object P_0)
			{
				return ((AbstractMetadata)P_0).Uid;
			}

			internal static object yeJCOovCC1i06WGdcy9M(object P_0)
			{
				return ((IWorkflowTaskBase)P_0).WorkflowBookmark;
			}

			internal static object hr4GI9vCMP7waVrQXX6x(object P_0)
			{
				return ((IWorkflowBookmark)P_0).Instance;
			}

			internal static object Wxw2wlvCkopW4WDdGkPF(object P_0)
			{
				return ((IWorkflowInstance)P_0).Context;
			}

			internal static object y8L8juvCUN9vrEXL9MWP(object P_0)
			{
				return ((IWorkflowInstance)P_0).Process;
			}

			internal static object W8dpHqvCVRj3ZfLxihsb(object P_0)
			{
				return ((IWorkflowProcess)P_0).Diagram;
			}

			internal static object LxMHcjvCAef9NmvXfZ4N(object P_0)
			{
				return ((Diagram)P_0).Elements;
			}

			internal static object RQ9gUsvCGkewteCLOWPd(object P_0)
			{
				return WorkflowTaskFormViewTransformate.GetViewItem((IWorkflowTaskBase)P_0);
			}

			internal static void DAMHGTvC7SlWZyI8hiAS(object P_0, object P_1)
			{
				((EntitySerializationSettings)P_0).Functions = (EntitySerializationFunctions)P_1;
			}

			internal static void KdhHP3vC2gFtrItagTHr(object P_0, SelectionMode P_1)
			{
				((EntitySerializationSelector)P_0).SelectionMode = P_1;
			}

			internal static void WQeqn2vCouZqce9dadOi(object P_0, object P_1)
			{
				((EntitySerializationSettings)P_0).PropertySelector = (EntitySerializationSelector)P_1;
			}

			internal static bool xKM5FwvCFV8ye4hlpXRh(object P_0)
			{
				return string.IsNullOrEmpty((string)P_0);
			}

			internal static object zn0PKgvCir2Al6pkOHRe(int _0020)
			{
				return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
			}

			internal static object BxA2divCIX5tJnp0KTUS(object P_0)
			{
				return ((Connector)P_0).EndElement;
			}

			internal static object eIh5NyvCae5fHCyKeTyG(object P_0)
			{
				return ((Element)P_0).Name;
			}

			internal static bool ehEa9NvCrZoHheHFJZWJ(object P_0)
			{
				return ((FlowConnectorElement)P_0).FormingTemplateName;
			}

			internal static object WvD3ApvCeXjwjl5xmF2T(object P_0)
			{
				return ((FlowConnectorElement)P_0).TemplateName;
			}

			internal static void IdRytXvCNl9rHqhDCaAA(object P_0, object P_1)
			{
				((NotificationElement.DataSource)P_0).Instance = (IWorkflowInstance)P_1;
			}

			internal static void dpPmW7vCxoBpP65LhuUp(object P_0, object P_1)
			{
				((NotificationElement.DataSource)P_0).Context = P_1;
			}

			internal static void D7KlhmvCSl4k95doDr8W(object P_0, object P_1)
			{
				((FlowItem)P_0).Description = (string)P_1;
			}

			internal static void pXK7VPvC1teBDMB8LQUO(object P_0, Guid value)
			{
				((FlowItem)P_0).Uid = value;
			}

			internal static Guid PvSGLYvChlYxTrEJMrSS(object P_0)
			{
				return ((FlowConnectorElement)P_0).Status;
			}

			internal static void psZMMuvCEY4fg54oNtxW(object P_0, Guid value)
			{
				((FlowItem)P_0).Status = value;
			}

			internal static void wYbovfvCwPLgoNPF07Hd(object P_0, object P_1)
			{
				((FlowItem)P_0).Color = (string)P_1;
			}

			internal static bool yktb23vC4f8jAClB9r9H(object P_0)
			{
				return ((FlowConnectorElement)P_0).OutputCancel;
			}

			internal static void lQjtNxvCzunLKQc61du1(object P_0, bool value)
			{
				((FlowItem)P_0).OutputCancel = value;
			}

			internal static bool EtpUMovMKD3Yb8QiTxYn(object P_0)
			{
				return ((FlowConnectorElement)P_0).ValidateContextVariables;
			}

			internal static bool mvVVbhvMOGQGjd1OdSMY(object P_0)
			{
				return ((FlowConnectorElement)P_0).UseConfirmConnector;
			}

			internal static void KtuPxhvMZ7Cu3GvmlJ5E(object P_0, bool value)
			{
				((FlowItem)P_0).UseConfirmConnector = value;
			}

			internal static object Tvr540vMvkpsmstvaYM8(object P_0)
			{
				return ((FlowConnectorElement)P_0).ConfirmConnectorText;
			}

			internal static void xjAm6WvMY716lO0C2rm7(object P_0, object P_1)
			{
				((FlowItem)P_0).ConfirmConnectorText = (string)P_1;
			}

			internal static bool ofnYHcvM8opOuXwd8uBW(object P_0)
			{
				return ((FlowConnectorElement)P_0).EnableComment;
			}

			internal static bool hQtiFlvMsomsVkFTw5ne(object P_0)
			{
				return ((FlowConnectorElement)P_0).CommentRequired;
			}

			internal static void OAn0UmvMJNZIiA6Do7Em(object P_0, bool value)
			{
				((FlowItem)P_0).CommentRequired = value;
			}

			internal static void tpRPZjvMlGg9dbHqLxeA(object P_0, bool value)
			{
				((FlowItem)P_0).IsDefault = value;
			}

			internal static bool VmiaDavM0cDfjZQ9L3p8(object P_0)
			{
				return ((FlowConnectorElement)P_0).IsSignNeeded;
			}

			internal static Guid q5idDLvMyLvD9oh28t1h(object P_0)
			{
				return ((FlowConnectorElement)P_0).SignType;
			}

			internal static bool vkMlr7vMmZCOBoG53bgr(object P_0)
			{
				return ((ITaskBase)P_0).IsActive();
			}

			internal static Type Ndt4y3vMt2vyEa5xYeY2(RuntimeTypeHandle P_0)
			{
				return Type.GetTypeFromHandle(P_0);
			}

			internal static object yYrO0dvMbO9syaYNXrEW(Type P_0, object P_1)
			{
				return Expression.Parameter(P_0, (string)P_1);
			}

			internal static object RYk0DQvM59NViuqJ8p5N(RuntimeMethodHandle P_0, RuntimeTypeHandle P_1)
			{
				return MethodBase.GetMethodFromHandle(P_0, P_1);
			}

			internal static object mMQUujvMgePtIfd0V9hY(Type P_0)
			{
				return Expression.New(P_0);
			}

			internal static object nrILH6vMBKCrqVGb3cox(RuntimeMethodHandle P_0)
			{
				return MethodBase.GetMethodFromHandle(P_0);
			}

			internal static object D8RgXNvMcEnREo0OQPcU(object P_0, Type P_1)
			{
				return Expression.Constant(P_0, P_1);
			}

			internal static object kxl0JevMPYXVyxKUjePE(object P_0, object P_1)
			{
				return Expression.Field((Expression)P_0, (FieldInfo)P_1);
			}

			internal static object OgPXwovMXu8TcYloHsD7(object P_0, object P_1)
			{
				return Expression.Property((Expression)P_0, (MethodInfo)P_1);
			}

			internal static object gbkEokvMdFZ320KLEL3Y(object P_0, object P_1)
			{
				return Expression.Bind((MethodInfo)P_0, (Expression)P_1);
			}

			internal static object JlfcgkvMuLe53PHrGvFr(RuntimeFieldHandle P_0)
			{
				return FieldInfo.GetFieldFromHandle(P_0);
			}

			internal static object Gtdi9TvMDIiWQM4H7mKs(object P_0, object P_1)
			{
				return Expression.Coalesce((Expression)P_0, (Expression)P_1);
			}

			internal static object VbX8NPvMnl5aVCS0n52n(object P_0, object P_1)
			{
				return Expression.MemberBind((MethodInfo)P_0, (MemberBinding[])P_1);
			}

			internal static object WKZanfvMHe3kytR99IBF(object P_0, object P_1)
			{
				return Expression.MemberInit((NewExpression)P_0, (MemberBinding[])P_1);
			}

			internal static object rW7HQSvML4X9tlQJar6y(object P_0, object P_1, object P_2)
			{
				return Expression.Call((Expression)P_0, (MethodInfo)P_1, (Expression[])P_2);
			}

			internal static bool oUd5oMvCq0H2pjg5OrmZ()
			{
				return H3J8cavC6JLvrDLnqeRd == null;
			}

			internal static TaskForm l0U93hvC347kPuANvnxR()
			{
				return H3J8cavC6JLvrDLnqeRd;
			}

			internal static object aLrAUyvMfmMXoIwwylrt()
			{
				return ComponentManager.Current;
			}

			internal static bool daGlSDvM9nZlfqq7HdTm(object P_0)
			{
				return ((string)P_0).IsNullOrWhiteSpace();
			}
		}

		internal class FlowItem
		{
			private static class Names
			{
				public static readonly object Uid;

				public static readonly object Name;

				public static readonly object Description;

				public static readonly object Status;

				public static readonly object Color;

				public static readonly object OutputCancel;

				public static readonly object ValidateContextVariables;

				public static readonly object UseConfirmConnector;

				public static readonly object ConfirmConnectorText;

				public static readonly object EnableComment;

				public static readonly object CommentRequired;

				public static readonly object IsDefault;

				public static readonly object IsSignNeeded;

				public static readonly object SignType;

				private static object rLWAnHvU7vaIKZ9nYdh6;

				static Names()
				{
					int num = 11;
					ParameterExpression parameterExpression = default(ParameterExpression);
					while (true)
					{
						int num2 = num;
						while (true)
						{
							switch (num2)
							{
							case 7:
								EnableComment = LinqUtils.NameOf(Expression.Lambda<Func<FlowItem, object>>((Expression)fvBxrhvUr7iLMylQCVyv(RltyI7vUevwLPeHem5LB(parameterExpression, (MethodInfo)CT8LhyvUaZLBwnSSmXKl((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), vvjhfVvUF53RsQcJXHHw(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
								num2 = 16;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c != 0)
								{
									num2 = 16;
								}
								continue;
							case 28:
								SignType = LinqUtils.NameOf(Expression.Lambda<Func<FlowItem, object>>((Expression)fvBxrhvUr7iLMylQCVyv(Expression.Property(parameterExpression, (MethodInfo)CT8LhyvUaZLBwnSSmXKl((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), vvjhfVvUF53RsQcJXHHw(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
								num2 = 26;
								continue;
							case 9:
								Description = LinqUtils.NameOf(Expression.Lambda<Func<FlowItem, object>>((Expression)RltyI7vUevwLPeHem5LB(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
								num2 = 3;
								continue;
							case 4:
								parameterExpression = (ParameterExpression)XtVSeQvUIXqtHRbp7rfa(vvjhfVvUF53RsQcJXHHw(typeof(FlowItem).TypeHandle), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2111219045 ^ -2111241643));
								num2 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 != 0)
								{
									num2 = 1;
								}
								continue;
							case 12:
								parameterExpression = Expression.Parameter(typeof(FlowItem), (string)UKAPKnvUiX1QdubjC9gG(-1108877388 ^ -1108899974));
								num2 = 25;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9269d021c6f148b6a1c4afb8cee03b6c != 0)
								{
									num2 = 28;
								}
								continue;
							case 13:
								parameterExpression = Expression.Parameter(vvjhfVvUF53RsQcJXHHw(typeof(FlowItem).TypeHandle), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1430645277 ^ -1430631123));
								num2 = 9;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5537a063960e465db83a04e35eea441b == 0)
								{
									num2 = 8;
								}
								continue;
							case 2:
								UseConfirmConnector = LinqUtils.NameOf(Expression.Lambda<Func<FlowItem, object>>((Expression)fvBxrhvUr7iLMylQCVyv(RltyI7vUevwLPeHem5LB(parameterExpression, (MethodInfo)CT8LhyvUaZLBwnSSmXKl((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), vvjhfVvUF53RsQcJXHHw(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
								num = 4;
								break;
							case 20:
								Color = LinqUtils.NameOf(Expression.Lambda<Func<FlowItem, object>>((Expression)RltyI7vUevwLPeHem5LB(parameterExpression, (MethodInfo)CT8LhyvUaZLBwnSSmXKl((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
								num2 = 4;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_dcdfd019631e458b9cb5fa34a16a2fe1 != 0)
								{
									num2 = 25;
								}
								continue;
							case 1:
								ConfirmConnectorText = LinqUtils.NameOf(Expression.Lambda<Func<FlowItem, object>>(Expression.Property(parameterExpression, (MethodInfo)CT8LhyvUaZLBwnSSmXKl((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
								num2 = 7;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f05298ca2a4a4a639a58bc7f7d9ff7b9 == 0)
								{
									num2 = 17;
								}
								continue;
							case 27:
								Name = LinqUtils.NameOf(Expression.Lambda<Func<FlowItem, object>>((Expression)RltyI7vUevwLPeHem5LB(parameterExpression, (MethodInfo)CT8LhyvUaZLBwnSSmXKl((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
								num2 = 13;
								continue;
							case 10:
								parameterExpression = (ParameterExpression)XtVSeQvUIXqtHRbp7rfa(vvjhfVvUF53RsQcJXHHw(typeof(FlowItem).TypeHandle), UKAPKnvUiX1QdubjC9gG(0x8D5763A ^ 0x8D52EF4));
								num2 = 6;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f8ecc99a1f4a4b6abc73e9b50261ea83 == 0)
								{
									num2 = 5;
								}
								continue;
							case 17:
								parameterExpression = (ParameterExpression)XtVSeQvUIXqtHRbp7rfa(vvjhfVvUF53RsQcJXHHw(typeof(FlowItem).TypeHandle), UKAPKnvUiX1QdubjC9gG(0x37E97159 ^ 0x37E92997));
								num2 = 7;
								continue;
							case 21:
								parameterExpression = (ParameterExpression)XtVSeQvUIXqtHRbp7rfa(vvjhfVvUF53RsQcJXHHw(typeof(FlowItem).TypeHandle), UKAPKnvUiX1QdubjC9gG(-29981480 ^ -29959146));
								num2 = 29;
								continue;
							case 29:
								ValidateContextVariables = LinqUtils.NameOf(Expression.Lambda<Func<FlowItem, object>>((Expression)fvBxrhvUr7iLMylQCVyv(RltyI7vUevwLPeHem5LB(parameterExpression, (MethodInfo)CT8LhyvUaZLBwnSSmXKl((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), vvjhfVvUF53RsQcJXHHw(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
								num2 = 24;
								continue;
							case 18:
								Status = LinqUtils.NameOf(Expression.Lambda<Func<FlowItem, object>>((Expression)fvBxrhvUr7iLMylQCVyv(RltyI7vUevwLPeHem5LB(parameterExpression, (MethodInfo)CT8LhyvUaZLBwnSSmXKl((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object)), new ParameterExpression[1] { parameterExpression }));
								num2 = 19;
								continue;
							case 23:
								IsSignNeeded = LinqUtils.NameOf(Expression.Lambda<Func<FlowItem, object>>((Expression)fvBxrhvUr7iLMylQCVyv(RltyI7vUevwLPeHem5LB(parameterExpression, (MethodInfo)CT8LhyvUaZLBwnSSmXKl((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), vvjhfVvUF53RsQcJXHHw(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
								num2 = 12;
								continue;
							case 19:
								parameterExpression = (ParameterExpression)XtVSeQvUIXqtHRbp7rfa(vvjhfVvUF53RsQcJXHHw(typeof(FlowItem).TypeHandle), UKAPKnvUiX1QdubjC9gG(-768800937 ^ -768778343));
								num2 = 20;
								continue;
							case 14:
								parameterExpression = (ParameterExpression)XtVSeQvUIXqtHRbp7rfa(vvjhfVvUF53RsQcJXHHw(typeof(FlowItem).TypeHandle), UKAPKnvUiX1QdubjC9gG(0x361628FF ^ 0x36167031));
								num = 5;
								break;
							case 8:
								parameterExpression = (ParameterExpression)XtVSeQvUIXqtHRbp7rfa(vvjhfVvUF53RsQcJXHHw(typeof(FlowItem).TypeHandle), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1134D2C0 ^ 0x11348A0E));
								num2 = 27;
								continue;
							case 15:
								parameterExpression = (ParameterExpression)XtVSeQvUIXqtHRbp7rfa(vvjhfVvUF53RsQcJXHHw(typeof(FlowItem).TypeHandle), UKAPKnvUiX1QdubjC9gG(-1965291699 ^ -1965269117));
								num2 = 23;
								continue;
							case 24:
								parameterExpression = (ParameterExpression)XtVSeQvUIXqtHRbp7rfa(vvjhfVvUF53RsQcJXHHw(typeof(FlowItem).TypeHandle), UKAPKnvUiX1QdubjC9gG(--1212129906 ^ 0x483FFABC));
								num2 = 2;
								continue;
							case 6:
								Uid = LinqUtils.NameOf(Expression.Lambda<Func<FlowItem, object>>((Expression)fvBxrhvUr7iLMylQCVyv(Expression.Property(parameterExpression, (MethodInfo)CT8LhyvUaZLBwnSSmXKl((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), vvjhfVvUF53RsQcJXHHw(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
								num2 = 8;
								continue;
							case 11:
								j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
								num2 = 10;
								continue;
							case 3:
								parameterExpression = (ParameterExpression)XtVSeQvUIXqtHRbp7rfa(vvjhfVvUF53RsQcJXHHw(typeof(FlowItem).TypeHandle), UKAPKnvUiX1QdubjC9gG(0x13F63440 ^ 0x13F66C8E));
								num2 = 18;
								continue;
							case 25:
								parameterExpression = Expression.Parameter(vvjhfVvUF53RsQcJXHHw(typeof(FlowItem).TypeHandle), (string)UKAPKnvUiX1QdubjC9gG(-885093259 ^ -885074757));
								num2 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eef7d2ca1c3c4b74aeb81172ed542639 == 0)
								{
									num2 = 0;
								}
								continue;
							case 16:
								parameterExpression = Expression.Parameter(vvjhfVvUF53RsQcJXHHw(typeof(FlowItem).TypeHandle), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12F686A ^ 0x12F30A4));
								num2 = 22;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f8ecc99a1f4a4b6abc73e9b50261ea83 == 0)
								{
									num2 = 7;
								}
								continue;
							default:
								OutputCancel = LinqUtils.NameOf(Expression.Lambda<Func<FlowItem, object>>(Expression.Convert(Expression.Property(parameterExpression, (MethodInfo)CT8LhyvUaZLBwnSSmXKl((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), vvjhfVvUF53RsQcJXHHw(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
								num2 = 21;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d843b0b7f23e489fb6d586d64b0a634a == 0)
								{
									num2 = 21;
								}
								continue;
							case 5:
								IsDefault = LinqUtils.NameOf(Expression.Lambda<Func<FlowItem, object>>((Expression)fvBxrhvUr7iLMylQCVyv(RltyI7vUevwLPeHem5LB(parameterExpression, (MethodInfo)CT8LhyvUaZLBwnSSmXKl((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), vvjhfVvUF53RsQcJXHHw(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
								num2 = 15;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e == 0)
								{
									num2 = 11;
								}
								continue;
							case 22:
								CommentRequired = LinqUtils.NameOf(Expression.Lambda<Func<FlowItem, object>>((Expression)fvBxrhvUr7iLMylQCVyv(Expression.Property(parameterExpression, (MethodInfo)CT8LhyvUaZLBwnSSmXKl((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), vvjhfVvUF53RsQcJXHHw(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
								num2 = 14;
								continue;
							case 26:
								return;
							}
							break;
						}
					}
				}

				internal static Type vvjhfVvUF53RsQcJXHHw(RuntimeTypeHandle P_0)
				{
					return Type.GetTypeFromHandle(P_0);
				}

				internal static object UKAPKnvUiX1QdubjC9gG(int _0020)
				{
					return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
				}

				internal static object XtVSeQvUIXqtHRbp7rfa(Type P_0, object P_1)
				{
					return Expression.Parameter(P_0, (string)P_1);
				}

				internal static object CT8LhyvUaZLBwnSSmXKl(RuntimeMethodHandle P_0)
				{
					return MethodBase.GetMethodFromHandle(P_0);
				}

				internal static object fvBxrhvUr7iLMylQCVyv(object P_0, Type P_1)
				{
					return Expression.Convert((Expression)P_0, P_1);
				}

				internal static object RltyI7vUevwLPeHem5LB(object P_0, object P_1)
				{
					return Expression.Property((Expression)P_0, (MethodInfo)P_1);
				}

				internal static bool qD9a7FvU2P6e9AFiMjpH()
				{
					return rLWAnHvU7vaIKZ9nYdh6 == null;
				}

				internal static Names rNkGTTvUoPfv0SDNc6Tw()
				{
					return (Names)rLWAnHvU7vaIKZ9nYdh6;
				}
			}

			private static FlowItem ebOuRCvMWs3iKSiIPWBd;

			public Guid Uid
			{
				[CompilerGenerated]
				get
				{
					return _003CUid_003Ek__BackingField;
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
							_003CUid_003Ek__BackingField = value;
							num2 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a23e27b648a042f098a477c26c4beed1 == 0)
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

			public string Name
			{
				[CompilerGenerated]
				get
				{
					return _003CName_003Ek__BackingField;
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
							_003CName_003Ek__BackingField = value;
							num2 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			public string Description
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
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5d3bc916b5664717ac60544de077bd16 != 0)
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

			public Guid Status
			{
				[CompilerGenerated]
				get
				{
					return _003CStatus_003Ek__BackingField;
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
							_003CStatus_003Ek__BackingField = value;
							num2 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_43af423d081c48e3bc6cea30ce47523d == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			public string Color
			{
				[CompilerGenerated]
				get
				{
					return _003CColor_003Ek__BackingField;
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
							_003CColor_003Ek__BackingField = value;
							num2 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 != 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			public bool OutputCancel
			{
				[CompilerGenerated]
				get
				{
					return _003COutputCancel_003Ek__BackingField;
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
							_003COutputCancel_003Ek__BackingField = value;
							num2 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0991fd79553c4ecc82e8b5cb79c2bff2 == 0)
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

			public bool ValidateContextVariables
			{
				[CompilerGenerated]
				get
				{
					return _003CValidateContextVariables_003Ek__BackingField;
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
							_003CValidateContextVariables_003Ek__BackingField = value;
							num2 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 == 0)
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

			public bool UseConfirmConnector
			{
				[CompilerGenerated]
				get
				{
					return _003CUseConfirmConnector_003Ek__BackingField;
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
							_003CUseConfirmConnector_003Ek__BackingField = value;
							num2 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c == 0)
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

			public string ConfirmConnectorText
			{
				[CompilerGenerated]
				get
				{
					return _003CConfirmConnectorText_003Ek__BackingField;
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
							_003CConfirmConnectorText_003Ek__BackingField = value;
							num2 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd != 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			public bool EnableComment
			{
				[CompilerGenerated]
				get
				{
					return _003CEnableComment_003Ek__BackingField;
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
							_003CEnableComment_003Ek__BackingField = value;
							num2 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1a2d7634479d44fb8d3718c31b05f73c == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			public bool CommentRequired
			{
				[CompilerGenerated]
				get
				{
					return _003CCommentRequired_003Ek__BackingField;
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
							_003CCommentRequired_003Ek__BackingField = value;
							num2 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7ed81ca3cf804abbade4684f28f485d1 != 0)
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

			public bool IsDefault
			{
				[CompilerGenerated]
				get
				{
					return _003CIsDefault_003Ek__BackingField;
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
							_003CIsDefault_003Ek__BackingField = value;
							num2 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5537a063960e465db83a04e35eea441b == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			public bool IsSignNeeded
			{
				[CompilerGenerated]
				get
				{
					return _003CIsSignNeeded_003Ek__BackingField;
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
							_003CIsSignNeeded_003Ek__BackingField = value;
							num2 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f05298ca2a4a4a639a58bc7f7d9ff7b9 != 0)
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

			public Guid SignType
			{
				[CompilerGenerated]
				get
				{
					return _003CSignType_003Ek__BackingField;
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
							_003CSignType_003Ek__BackingField = value;
							num2 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b != 0)
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

			public static void GetDescriptor(TypeSerializationDescriptorBuilder builder)
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
						builder.ItemWithDescriptor((string)Names.Uid, delegate(TypeSerializationDescriptorBuilder i)
						{
							int num29 = 1;
							int num30 = num29;
							while (true)
							{
								switch (num30)
								{
								default:
									return;
								case 0:
									return;
								case 1:
									_003C_003Ec.JcaG7avUzHEh5iVU6CEP(_003C_003Ec.MnE6psvUwpq4vZkFbPj1(i, _003C_003Ec.rW7kFsvUEV87yZ9rjClu(_003C_003Ec.yUA7rnvUhUVHqyx2dV94(-935313063 ^ -935181681))), _003C_003Ec.JOJ04PvU4xX3UC9KaVAZ(typeof(Guid).TypeHandle));
									num30 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f33560c5d18b4e10b24a458578aa60fd != 0)
									{
										num30 = 0;
									}
									break;
								}
							}
						}).ItemWithDescriptor((string)Names.Name, delegate(TypeSerializationDescriptorBuilder i)
						{
							int num27 = 1;
							int num28 = num27;
							while (true)
							{
								switch (num28)
								{
								default:
									return;
								case 1:
									_003C_003Ec.JcaG7avUzHEh5iVU6CEP(_003C_003Ec.MnE6psvUwpq4vZkFbPj1(i, _003C_003Ec.rW7kFsvUEV87yZ9rjClu(_003C_003Ec.yUA7rnvUhUVHqyx2dV94(0x747FFBE0 ^ 0x747CFDCC))), _003C_003Ec.JOJ04PvU4xX3UC9KaVAZ(typeof(string).TypeHandle));
									num28 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d != 0)
									{
										num28 = 0;
									}
									break;
								case 0:
									return;
								}
							}
						}).ItemWithDescriptor((string)Names.Description, delegate(TypeSerializationDescriptorBuilder i)
						{
							int num25 = 1;
							int num26 = num25;
							while (true)
							{
								switch (num26)
								{
								default:
									return;
								case 0:
									return;
								case 1:
									_003C_003Ec.HBMiETvVKSeYrHuIacSp(_003C_003Ec.JcaG7avUzHEh5iVU6CEP(_003C_003Ec.MnE6psvUwpq4vZkFbPj1(i, SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1539486135 ^ -1539422181))), _003C_003Ec.JOJ04PvU4xX3UC9KaVAZ(typeof(string).TypeHandle)), null);
									num26 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe7a0ffe67e4fea8e329ae6574ed2ca != 0)
									{
										num26 = 0;
									}
									break;
								}
							}
						})
							.ItemWithDescriptor((string)Names.Status, delegate(TypeSerializationDescriptorBuilder i)
							{
								int num23 = 1;
								int num24 = num23;
								while (true)
								{
									switch (num24)
									{
									default:
										return;
									case 1:
										_003C_003Ec.HBMiETvVKSeYrHuIacSp(((TypeSerializationDescriptorBuilder)_003C_003Ec.MnE6psvUwpq4vZkFbPj1(i, _003C_003Ec.rW7kFsvUEV87yZ9rjClu(_003C_003Ec.yUA7rnvUhUVHqyx2dV94(-763667953 ^ -763863945)))).Type(_003C_003Ec.JOJ04PvU4xX3UC9KaVAZ(typeof(Guid).TypeHandle)), null);
										num24 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 == 0)
										{
											num24 = 0;
										}
										break;
									case 0:
										return;
									}
								}
							})
							.ItemWithDescriptor((string)Names.Color, delegate(TypeSerializationDescriptorBuilder i)
							{
								int num21 = 1;
								int num22 = num21;
								while (true)
								{
									switch (num22)
									{
									default:
										return;
									case 0:
										return;
									case 1:
										_003C_003Ec.HBMiETvVKSeYrHuIacSp(_003C_003Ec.JcaG7avUzHEh5iVU6CEP(_003C_003Ec.MnE6psvUwpq4vZkFbPj1(i, SR.T((string)_003C_003Ec.yUA7rnvUhUVHqyx2dV94(-2122743969 ^ -2122679867))), _003C_003Ec.JOJ04PvU4xX3UC9KaVAZ(typeof(string).TypeHandle)), null);
										num22 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_448e6815cb30438893079dcbb906fd65 != 0)
										{
											num22 = 0;
										}
										break;
									}
								}
							})
							.ItemWithDescriptor((string)Names.OutputCancel, delegate(TypeSerializationDescriptorBuilder i)
							{
								int num19 = 1;
								int num20 = num19;
								while (true)
								{
									switch (num20)
									{
									default:
										return;
									case 1:
										_003C_003Ec.HBMiETvVKSeYrHuIacSp(_003C_003Ec.JcaG7avUzHEh5iVU6CEP(_003C_003Ec.MnE6psvUwpq4vZkFbPj1(i, _003C_003Ec.rW7kFsvUEV87yZ9rjClu(_003C_003Ec.yUA7rnvUhUVHqyx2dV94(0x46EA3D1 ^ 0x46DA569))), _003C_003Ec.JOJ04PvU4xX3UC9KaVAZ(typeof(bool).TypeHandle)), null);
										num20 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bf623f11574746d6bf3837b66460c576 != 0)
										{
											num20 = 0;
										}
										break;
									case 0:
										return;
									}
								}
							})
							.ItemWithDescriptor((string)Names.ValidateContextVariables, delegate(TypeSerializationDescriptorBuilder i)
							{
								int num17 = 1;
								int num18 = num17;
								while (true)
								{
									switch (num18)
									{
									default:
										return;
									case 0:
										return;
									case 1:
										_003C_003Ec.HBMiETvVKSeYrHuIacSp(_003C_003Ec.JcaG7avUzHEh5iVU6CEP(_003C_003Ec.MnE6psvUwpq4vZkFbPj1(i, _003C_003Ec.rW7kFsvUEV87yZ9rjClu(_003C_003Ec.yUA7rnvUhUVHqyx2dV94(-17847711 ^ -18043605))), _003C_003Ec.JOJ04PvU4xX3UC9KaVAZ(typeof(bool).TypeHandle)), null);
										num18 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7de614af35034bd0a6867d08a2ee4a84 != 0)
										{
											num18 = 0;
										}
										break;
									}
								}
							})
							.ItemWithDescriptor((string)Names.UseConfirmConnector, delegate(TypeSerializationDescriptorBuilder i)
							{
								int num15 = 1;
								int num16 = num15;
								while (true)
								{
									switch (num16)
									{
									default:
										return;
									case 1:
										i.Description((string)_003C_003Ec.rW7kFsvUEV87yZ9rjClu(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6F6D7B44 ^ 0x6F6E7374))).Type(_003C_003Ec.JOJ04PvU4xX3UC9KaVAZ(typeof(bool).TypeHandle)).Optional();
										num16 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 != 0)
										{
											num16 = 0;
										}
										break;
									case 0:
										return;
									}
								}
							})
							.ItemWithDescriptor((string)Names.ConfirmConnectorText, delegate(TypeSerializationDescriptorBuilder i)
							{
								int num13 = 1;
								int num14 = num13;
								while (true)
								{
									switch (num14)
									{
									default:
										return;
									case 1:
										_003C_003Ec.HBMiETvVKSeYrHuIacSp(_003C_003Ec.JcaG7avUzHEh5iVU6CEP(_003C_003Ec.MnE6psvUwpq4vZkFbPj1(i, SR.T((string)_003C_003Ec.yUA7rnvUhUVHqyx2dV94(0x628167BE ^ 0x62826F20))), _003C_003Ec.JOJ04PvU4xX3UC9KaVAZ(typeof(string).TypeHandle)), null);
										num14 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 != 0)
										{
											num14 = 0;
										}
										break;
									case 0:
										return;
									}
								}
							})
							.ItemWithDescriptor((string)Names.EnableComment, delegate(TypeSerializationDescriptorBuilder i)
							{
								int num11 = 1;
								int num12 = num11;
								while (true)
								{
									switch (num12)
									{
									default:
										return;
									case 0:
										return;
									case 1:
										_003C_003Ec.HBMiETvVKSeYrHuIacSp(_003C_003Ec.JcaG7avUzHEh5iVU6CEP(_003C_003Ec.MnE6psvUwpq4vZkFbPj1(i, _003C_003Ec.rW7kFsvUEV87yZ9rjClu(_003C_003Ec.yUA7rnvUhUVHqyx2dV94(-947937941 ^ -948136521))), _003C_003Ec.JOJ04PvU4xX3UC9KaVAZ(typeof(bool).TypeHandle)), null);
										num12 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_60c5782a184b457aa78da2e5c62d4e27 != 0)
										{
											num12 = 0;
										}
										break;
									}
								}
							})
							.ItemWithDescriptor((string)Names.CommentRequired, delegate(TypeSerializationDescriptorBuilder i)
							{
								int num9 = 1;
								int num10 = num9;
								while (true)
								{
									switch (num10)
									{
									default:
										return;
									case 1:
										_003C_003Ec.HBMiETvVKSeYrHuIacSp(_003C_003Ec.JcaG7avUzHEh5iVU6CEP(_003C_003Ec.MnE6psvUwpq4vZkFbPj1(i, _003C_003Ec.rW7kFsvUEV87yZ9rjClu(_003C_003Ec.yUA7rnvUhUVHqyx2dV94(-667465279 ^ -667664183))), _003C_003Ec.JOJ04PvU4xX3UC9KaVAZ(typeof(bool).TypeHandle)), null);
										num10 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 != 0)
										{
											num10 = 0;
										}
										break;
									case 0:
										return;
									}
								}
							})
							.ItemWithDescriptor((string)Names.IsDefault, delegate(TypeSerializationDescriptorBuilder i)
							{
								int num7 = 1;
								int num8 = num7;
								while (true)
								{
									switch (num8)
									{
									default:
										return;
									case 1:
										_003C_003Ec.HBMiETvVKSeYrHuIacSp(_003C_003Ec.JcaG7avUzHEh5iVU6CEP(_003C_003Ec.MnE6psvUwpq4vZkFbPj1(i, _003C_003Ec.rW7kFsvUEV87yZ9rjClu(_003C_003Ec.yUA7rnvUhUVHqyx2dV94(-148495695 ^ -148558969))), _003C_003Ec.JOJ04PvU4xX3UC9KaVAZ(typeof(bool).TypeHandle)), null);
										num8 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c7fe5d092d804f7e91041fb2338cec1a == 0)
										{
											num8 = 0;
										}
										break;
									case 0:
										return;
									}
								}
							})
							.ItemWithDescriptor((string)Names.IsSignNeeded, delegate(TypeSerializationDescriptorBuilder i)
							{
								int num5 = 1;
								int num6 = num5;
								while (true)
								{
									switch (num6)
									{
									default:
										return;
									case 1:
										((TypeSerializationDescriptorBuilder)_003C_003Ec.MnE6psvUwpq4vZkFbPj1(i, _003C_003Ec.rW7kFsvUEV87yZ9rjClu(_003C_003Ec.yUA7rnvUhUVHqyx2dV94(-1001967776 ^ -1002166754)))).Type(_003C_003Ec.JOJ04PvU4xX3UC9KaVAZ(typeof(Guid).TypeHandle)).Optional();
										num6 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_32f3e755437f4eacb85c8a0d536f83ea != 0)
										{
											num6 = 0;
										}
										break;
									case 0:
										return;
									}
								}
							})
							.ItemWithDescriptor((string)Names.SignType, delegate(TypeSerializationDescriptorBuilder i)
							{
								int num3 = 1;
								int num4 = num3;
								while (true)
								{
									switch (num4)
									{
									default:
										return;
									case 1:
										i.Description((string)_003C_003Ec.rW7kFsvUEV87yZ9rjClu(_003C_003Ec.yUA7rnvUhUVHqyx2dV94(-45832783 ^ -45634531))).Type(typeof(bool)).Optional();
										num4 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6dd19c81ff5e41fb8db9b50574437301 == 0)
										{
											num4 = 0;
										}
										break;
									case 0:
										return;
									}
								}
							});
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}

			public WebData ToWebData()
			{
				//Discarded unreachable code: IL_0194, IL_01a3, IL_01f5, IL_03d5, IL_0499, IL_04a8, IL_04b8
				int num = 21;
				Dictionary<string, object> dictionary = default(Dictionary<string, object>);
				while (true)
				{
					int num2 = num;
					while (true)
					{
						switch (num2)
						{
						case 22:
							dictionary[(string)Names.IsDefault] = IsDefault;
							num2 = 7;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f8ecc99a1f4a4b6abc73e9b50261ea83 == 0)
							{
								num2 = 6;
							}
							continue;
						case 5:
						case 18:
							if (!(SignType != Guid.Empty))
							{
								num = 4;
								break;
							}
							goto case 16;
						case 8:
							dictionary[(string)Names.Description] = Description;
							num = 31;
							break;
						case 3:
							dictionary[(string)Names.CommentRequired] = CommentRequired;
							num2 = 12;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 != 0)
							{
								num2 = 11;
							}
							continue;
						case 1:
							dictionary[(string)Names.EnableComment] = EnableComment;
							num2 = 11;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae2bde9e5844c638021cdb56fc01122 != 0)
							{
								num2 = 2;
							}
							continue;
						default:
							if (!UseConfirmConnector)
							{
								num = 14;
								break;
							}
							goto case 10;
						case 28:
							if (!OutputCancel)
							{
								num2 = 23;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_abfb511163674a3eae959fd60da8f319 != 0)
								{
									num2 = 10;
								}
								continue;
							}
							goto case 29;
						case 27:
							if (EjfAOovM6jk1dcQKeOOD(Description))
							{
								num = 2;
								break;
							}
							goto case 8;
						case 29:
							dictionary[(string)Names.OutputCancel] = OutputCancel;
							num2 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f8ecc99a1f4a4b6abc73e9b50261ea83 != 0)
							{
								num2 = 19;
							}
							continue;
						case 19:
						case 23:
							if (!ValidateContextVariables)
							{
								num2 = 6;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 != 0)
								{
									num2 = 6;
								}
								continue;
							}
							goto case 13;
						case 2:
						case 31:
							if (L9KrnMvMqpNX9XnQ63Mv(Status, Guid.Empty))
							{
								num2 = 25;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b == 0)
								{
									num2 = 20;
								}
								continue;
							}
							goto case 9;
						case 32:
							dictionary[(string)Names.Color] = Color;
							num2 = 28;
							continue;
						case 4:
						case 30:
							return new WebData(dictionary);
						case 11:
							if (CommentRequired)
							{
								num2 = 3;
								continue;
							}
							goto case 12;
						case 20:
							dictionary[(string)Names.Uid] = Uid;
							num2 = 15;
							continue;
						case 21:
							dictionary = new Dictionary<string, object>();
							num2 = 16;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 != 0)
							{
								num2 = 20;
							}
							continue;
						case 25:
							dictionary[(string)Names.Status] = Status;
							num2 = 9;
							continue;
						case 10:
							dictionary[(string)Names.UseConfirmConnector] = UseConfirmConnector;
							num2 = 24;
							continue;
						case 7:
							if (!IsSignNeeded)
							{
								num2 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b1ab9396b25b43af8f32e24b1948be96 == 0)
								{
									num2 = 5;
								}
								continue;
							}
							goto case 26;
						case 16:
							dictionary[(string)Names.SignType] = SignType;
							num = 30;
							break;
						case 12:
							if (IsDefault)
							{
								num2 = 22;
								continue;
							}
							goto case 7;
						case 24:
							dictionary[(string)Names.ConfirmConnectorText] = ConfirmConnectorText;
							num2 = 14;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cb262bcfe4074a1ab16e653815d57f28 != 0)
							{
								num2 = 17;
							}
							continue;
						case 9:
							if (!EjfAOovM6jk1dcQKeOOD(Color))
							{
								num2 = 32;
								continue;
							}
							goto case 28;
						case 14:
						case 17:
							if (EnableComment)
							{
								num2 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b != 0)
								{
									num2 = 1;
								}
								continue;
							}
							goto case 11;
						case 13:
							dictionary[(string)Names.ValidateContextVariables] = ValidateContextVariables;
							num2 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_26fa47f5bd8343debcae8b05a56a3ab5 != 0)
							{
								num2 = 0;
							}
							continue;
						case 15:
							dictionary[(string)Names.Name] = Name;
							num2 = 27;
							continue;
						case 26:
							dictionary[(string)Names.IsSignNeeded] = IsSignNeeded;
							num = 18;
							break;
						}
						break;
					}
				}
			}

			public FlowItem()
			{
				//Discarded unreachable code: IL_002a, IL_002f
				TrXjp0vM3V60suQ2XtqK();
				base._002Ector();
				int num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_08023922bb0e4e809e5cff73a2b04988 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
			}

			internal static bool mNfWRyvMjqxWH1IcxsrD()
			{
				return ebOuRCvMWs3iKSiIPWBd == null;
			}

			internal static FlowItem kmJKpvvMRuppSDaunUGx()
			{
				return ebOuRCvMWs3iKSiIPWBd;
			}

			internal static bool EjfAOovM6jk1dcQKeOOD(object P_0)
			{
				return ((string)P_0).IsNullOrWhiteSpace();
			}

			internal static bool L9KrnMvMqpNX9XnQ63Mv(Guid P_0, Guid P_1)
			{
				return P_0 != P_1;
			}

			internal static void TrXjp0vM3V60suQ2XtqK()
			{
				j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
			}
		}

		internal class ProcessInfo
		{
			private static class Names
			{
				public static readonly object ProcessName;

				public static readonly object ProcessVersionNumber;

				public static readonly object InstanceName;

				public static readonly object InstanceId;

				public static readonly object StartDate;

				public static readonly object Initiator;

				public static readonly object Responsible;

				private static object QcGlEgvVOlCKUF0FDmmi;

				static Names()
				{
					int num = 12;
					ParameterExpression parameterExpression = default(ParameterExpression);
					while (true)
					{
						int num2 = num;
						while (true)
						{
							switch (num2)
							{
							case 7:
								parameterExpression = (ParameterExpression)U8hRO2vV0UZedPKELx1D(kQEV9rvV8xVScMtK3dyT(typeof(ProcessInfo).TypeHandle), sM7jkuvVsZleHCimopXa(0x7AC609FE ^ 0x7AC65130));
								num2 = 9;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b == 0)
								{
									num2 = 6;
								}
								continue;
							case 5:
								parameterExpression = Expression.Parameter(typeof(ProcessInfo), (string)sM7jkuvVsZleHCimopXa(-2125897096 ^ -2125907274));
								num2 = 15;
								continue;
							case 8:
								parameterExpression = (ParameterExpression)U8hRO2vV0UZedPKELx1D(typeof(ProcessInfo), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-197778752 ^ -197756402));
								num2 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58fb165cafed422d973d4a7156526541 == 0)
								{
									num2 = 0;
								}
								continue;
							case 4:
								parameterExpression = (ParameterExpression)U8hRO2vV0UZedPKELx1D(kQEV9rvV8xVScMtK3dyT(typeof(ProcessInfo).TypeHandle), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x8D5763A ^ 0x8D52EF4));
								num2 = 13;
								continue;
							default:
								InstanceName = LinqUtils.NameOf(Expression.Lambda<Func<ProcessInfo, object>>((Expression)TJ0gtvvVlpUeA49Rguep(parameterExpression, (MethodInfo)yt1JRovVJNrbQdxm4yI2((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
								num2 = 7;
								continue;
							case 11:
								parameterExpression = Expression.Parameter(kQEV9rvV8xVScMtK3dyT(typeof(ProcessInfo).TypeHandle), (string)sM7jkuvVsZleHCimopXa(0x70EBB9F3 ^ 0x70EBE13D));
								num2 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0991fd79553c4ecc82e8b5cb79c2bff2 != 0)
								{
									num2 = 0;
								}
								continue;
							case 12:
								ybKrrqvVYENS1CkeiJ45();
								num2 = 11;
								continue;
							case 3:
								break;
							case 13:
								ProcessVersionNumber = LinqUtils.NameOf(Expression.Lambda<Func<ProcessInfo, object>>((Expression)EOU3V9vVyVqe7Wj7Nhpl(Expression.Property(parameterExpression, (MethodInfo)yt1JRovVJNrbQdxm4yI2((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), kQEV9rvV8xVScMtK3dyT(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
								num2 = 8;
								continue;
							case 10:
								parameterExpression = (ParameterExpression)U8hRO2vV0UZedPKELx1D(kQEV9rvV8xVScMtK3dyT(typeof(ProcessInfo).TypeHandle), sM7jkuvVsZleHCimopXa(-790221436 ^ -790203062));
								num2 = 14;
								continue;
							case 6:
								return;
							case 1:
								ProcessName = LinqUtils.NameOf(Expression.Lambda<Func<ProcessInfo, object>>((Expression)TJ0gtvvVlpUeA49Rguep(parameterExpression, (MethodInfo)yt1JRovVJNrbQdxm4yI2((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
								num2 = 4;
								continue;
							case 15:
								Initiator = LinqUtils.NameOf(Expression.Lambda<Func<ProcessInfo, object>>((Expression)EOU3V9vVyVqe7Wj7Nhpl(TJ0gtvvVlpUeA49Rguep(parameterExpression, (MethodInfo)yt1JRovVJNrbQdxm4yI2((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), kQEV9rvV8xVScMtK3dyT(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
								num2 = 10;
								continue;
							case 2:
								StartDate = LinqUtils.NameOf(Expression.Lambda<Func<ProcessInfo, object>>(Expression.Convert((Expression)TJ0gtvvVlpUeA49Rguep(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), kQEV9rvV8xVScMtK3dyT(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
								num2 = 5;
								continue;
							case 14:
								Responsible = LinqUtils.NameOf(Expression.Lambda<Func<ProcessInfo, object>>((Expression)EOU3V9vVyVqe7Wj7Nhpl(TJ0gtvvVlpUeA49Rguep(parameterExpression, (MethodInfo)yt1JRovVJNrbQdxm4yI2((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object)), new ParameterExpression[1] { parameterExpression }));
								num2 = 6;
								continue;
							case 9:
								InstanceId = LinqUtils.NameOf(Expression.Lambda<Func<ProcessInfo, object>>((Expression)EOU3V9vVyVqe7Wj7Nhpl(TJ0gtvvVlpUeA49Rguep(parameterExpression, (MethodInfo)yt1JRovVJNrbQdxm4yI2((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), kQEV9rvV8xVScMtK3dyT(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
								num2 = 3;
								continue;
							}
							break;
						}
						parameterExpression = (ParameterExpression)U8hRO2vV0UZedPKELx1D(kQEV9rvV8xVScMtK3dyT(typeof(ProcessInfo).TypeHandle), sM7jkuvVsZleHCimopXa(-1776305410 ^ -1776295376));
						num = 2;
					}
				}

				internal static void ybKrrqvVYENS1CkeiJ45()
				{
					j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
				}

				internal static Type kQEV9rvV8xVScMtK3dyT(RuntimeTypeHandle P_0)
				{
					return Type.GetTypeFromHandle(P_0);
				}

				internal static object sM7jkuvVsZleHCimopXa(int _0020)
				{
					return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
				}

				internal static object yt1JRovVJNrbQdxm4yI2(RuntimeMethodHandle P_0)
				{
					return MethodBase.GetMethodFromHandle(P_0);
				}

				internal static object TJ0gtvvVlpUeA49Rguep(object P_0, object P_1)
				{
					return Expression.Property((Expression)P_0, (MethodInfo)P_1);
				}

				internal static object U8hRO2vV0UZedPKELx1D(Type P_0, object P_1)
				{
					return Expression.Parameter(P_0, (string)P_1);
				}

				internal static object EOU3V9vVyVqe7Wj7Nhpl(object P_0, Type P_1)
				{
					return Expression.Convert((Expression)P_0, P_1);
				}

				internal static bool p5tpKlvVZm2hHh2KQrSx()
				{
					return QcGlEgvVOlCKUF0FDmmi == null;
				}

				internal static Names oj3MQYvVv4l92fy88kg3()
				{
					return (Names)QcGlEgvVOlCKUF0FDmmi;
				}
			}

			internal static ProcessInfo En8FqCvMTUkJcEJ8yZYL;

			public string ProcessName
			{
				[CompilerGenerated]
				get
				{
					return _003CProcessName_003Ek__BackingField;
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
							_003CProcessName_003Ek__BackingField = value;
							num2 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f8a84e2cb374827a50ba2cbcf11cf48 == 0)
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

			public long ProcessVersionNumber
			{
				[CompilerGenerated]
				get
				{
					return _003CProcessVersionNumber_003Ek__BackingField;
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
							_003CProcessVersionNumber_003Ek__BackingField = value;
							num2 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eef7d2ca1c3c4b74aeb81172ed542639 == 0)
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

			public string InstanceName
			{
				[CompilerGenerated]
				get
				{
					return _003CInstanceName_003Ek__BackingField;
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
							_003CInstanceName_003Ek__BackingField = value;
							num2 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58fb165cafed422d973d4a7156526541 != 0)
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

			public long InstanceId
			{
				[CompilerGenerated]
				get
				{
					return _003CInstanceId_003Ek__BackingField;
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
							_003CInstanceId_003Ek__BackingField = value;
							num2 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ecf910d183864897a7c8ec77e01689a4 != 0)
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

			public DateTime StartDate
			{
				[CompilerGenerated]
				get
				{
					return _003CStartDate_003Ek__BackingField;
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
							_003CStartDate_003Ek__BackingField = value;
							num2 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede != 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			public long Initiator
			{
				[CompilerGenerated]
				get
				{
					return _003CInitiator_003Ek__BackingField;
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
							_003CInitiator_003Ek__BackingField = value;
							num2 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			public long Responsible
			{
				[CompilerGenerated]
				get
				{
					return _003CResponsible_003Ek__BackingField;
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
							_003CResponsible_003Ek__BackingField = value;
							num2 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bd84f42638494cb6b4427f8e13ec59af == 0)
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

			public ProcessInfo(IWorkflowInstance instance)
			{
				//Discarded unreachable code: IL_001a
				zyupcpvMCkLCYCAFs6Rh();
				base._002Ector();
				int num = 5;
				while (true)
				{
					switch (num)
					{
					case 3:
						InstanceId = instance.Id;
						num = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c447ffb64be44c09b6fd398df506785b != 0)
						{
							num = 0;
						}
						break;
					case 4:
						ProcessVersionNumber = NXhQRVvMUPA1EAxaQpBH(YUQE6SvMkSsXNDkcG4NN(instance));
						num = 7;
						break;
					case 1:
						Responsible = ((IEntity<long>)mxo9PsvMAU5d0CDeVflm(instance)).Id;
						num = 2;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae4e393cddc4c98b9896b25c9e18c7d == 0)
						{
							num = 6;
						}
						break;
					case 7:
					{
						InstanceName = (string)ApNOm3vMVx1K62ciINGM(instance);
						int num2 = 3;
						num = num2;
						break;
					}
					case 5:
						ProcessName = (string)I8NZYvvMM9Q80RuHCLLW(instance.Process);
						num = 4;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1c37d4e24e094858975336738e156495 == 0)
						{
							num = 0;
						}
						break;
					case 2:
						Initiator = instance.Initiator.Id;
						num = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea != 0)
						{
							num = 1;
						}
						break;
					case 6:
						return;
					default:
						StartDate = instance.StartDate ?? DateTime.MinValue;
						num = 2;
						break;
					}
				}
			}

			public static void GetDescriptor(TypeSerializationDescriptorBuilder builder)
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
						builder.ItemWithDescriptor((string)Names.ProcessName, delegate(TypeSerializationDescriptorBuilder i)
						{
							int num15 = 1;
							int num16 = num15;
							while (true)
							{
								switch (num16)
								{
								default:
									return;
								case 0:
									return;
								case 1:
									_003C_003Ec.Hbv06LvVXog8baSAaL25(_003C_003Ec.fw4ASKvVcapY514Q7Tu2(i, _003C_003Ec.eVpNrjvVBJ55SX42VHil(_003C_003Ec.ytAgeGvVgPtBKOb72giW(0x42311138 ^ 0x4230F21C))), _003C_003Ec.F3U2jJvVPuMGdST4Uq8y(typeof(string).TypeHandle));
									num16 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_85ba8d91af394836ac86666c40b1e150 != 0)
									{
										num16 = 0;
									}
									break;
								}
							}
						}).ItemWithDescriptor((string)Names.ProcessVersionNumber, delegate(TypeSerializationDescriptorBuilder i)
						{
							int num13 = 1;
							int num14 = num13;
							while (true)
							{
								switch (num14)
								{
								default:
									return;
								case 0:
									return;
								case 1:
									((TypeSerializationDescriptorBuilder)_003C_003Ec.fw4ASKvVcapY514Q7Tu2(i, _003C_003Ec.eVpNrjvVBJ55SX42VHil(_003C_003Ec.ytAgeGvVgPtBKOb72giW(0x6F6D7B44 ^ 0x6F6E7288)))).Type(typeof(long));
									num14 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 == 0)
									{
										num14 = 0;
									}
									break;
								}
							}
						}).ItemWithDescriptor((string)Names.InstanceName, delegate(TypeSerializationDescriptorBuilder i)
						{
							int num11 = 1;
							int num12 = num11;
							while (true)
							{
								switch (num12)
								{
								default:
									return;
								case 0:
									return;
								case 1:
									((TypeSerializationDescriptorBuilder)_003C_003Ec.fw4ASKvVcapY514Q7Tu2(i, _003C_003Ec.eVpNrjvVBJ55SX42VHil(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x747FFBE0 ^ 0x747CF20E)))).Type(_003C_003Ec.F3U2jJvVPuMGdST4Uq8y(typeof(string).TypeHandle));
									num12 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0991fd79553c4ecc82e8b5cb79c2bff2 != 0)
									{
										num12 = 0;
									}
									break;
								}
							}
						})
							.ItemWithDescriptor((string)Names.InstanceId, delegate(TypeSerializationDescriptorBuilder i)
							{
								int num9 = 1;
								int num10 = num9;
								while (true)
								{
									switch (num10)
									{
									default:
										return;
									case 0:
										return;
									case 1:
										((TypeSerializationDescriptorBuilder)_003C_003Ec.fw4ASKvVcapY514Q7Tu2(i, _003C_003Ec.eVpNrjvVBJ55SX42VHil(_003C_003Ec.ytAgeGvVgPtBKOb72giW(-1514166050 ^ -1514364218)))).Type(_003C_003Ec.F3U2jJvVPuMGdST4Uq8y(typeof(long).TypeHandle));
										num10 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d87d9a74c9e14f96a288cc3620965fe0 == 0)
										{
											num10 = 0;
										}
										break;
									}
								}
							})
							.ItemWithDescriptor((string)Names.StartDate, delegate(TypeSerializationDescriptorBuilder i)
							{
								int num7 = 1;
								int num8 = num7;
								while (true)
								{
									switch (num8)
									{
									default:
										return;
									case 0:
										return;
									case 1:
										_003C_003Ec.Hbv06LvVXog8baSAaL25(i.Description(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x70EBB9F3 ^ 0x70E8B3BF))), _003C_003Ec.F3U2jJvVPuMGdST4Uq8y(typeof(DateTime).TypeHandle));
										num8 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1b8b735647da470aa2d45d64d6f538d1 != 0)
										{
											num8 = 0;
										}
										break;
									}
								}
							})
							.ItemWithDescriptor((string)Names.Initiator, delegate(TypeSerializationDescriptorBuilder i)
							{
								int num5 = 1;
								int num6 = num5;
								while (true)
								{
									switch (num6)
									{
									default:
										return;
									case 0:
										return;
									case 1:
										_003C_003Ec.Hbv06LvVXog8baSAaL25(_003C_003Ec.fw4ASKvVcapY514Q7Tu2(i, _003C_003Ec.eVpNrjvVBJ55SX42VHil(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-683713632 ^ -683912760))), _003C_003Ec.F3U2jJvVPuMGdST4Uq8y(typeof(long).TypeHandle));
										num6 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_26fa47f5bd8343debcae8b05a56a3ab5 != 0)
										{
											num6 = 0;
										}
										break;
									}
								}
							})
							.ItemWithDescriptor((string)Names.Responsible, delegate(TypeSerializationDescriptorBuilder i)
							{
								int num3 = 1;
								int num4 = num3;
								while (true)
								{
									switch (num4)
									{
									default:
										return;
									case 0:
										return;
									case 1:
										_003C_003Ec.Hbv06LvVXog8baSAaL25(_003C_003Ec.fw4ASKvVcapY514Q7Tu2(i, SR.T((string)_003C_003Ec.ytAgeGvVgPtBKOb72giW(--727842433 ^ 0x2B62F41D))), _003C_003Ec.F3U2jJvVPuMGdST4Uq8y(typeof(long).TypeHandle));
										num4 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 == 0)
										{
											num4 = 0;
										}
										break;
									}
								}
							});
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5c45a6e5a4614bfba7591d8a1c7ced1d != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}

			public WebData ToWebData()
			{
				return new WebData(new Dictionary<string, object>
				{
					[(string)Names.ProcessName] = ProcessName,
					[(string)Names.ProcessVersionNumber] = ProcessVersionNumber,
					[(string)Names.InstanceName] = InstanceName,
					[(string)Names.InstanceId] = InstanceId,
					[(string)Names.StartDate] = StartDate,
					[(string)Names.Initiator] = Initiator,
					[(string)Names.Responsible] = Responsible
				});
			}

			internal static void zyupcpvMCkLCYCAFs6Rh()
			{
				j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
			}

			internal static object I8NZYvvMM9Q80RuHCLLW(object P_0)
			{
				return ((IWorkflowProcess)P_0).Name;
			}

			internal static object YUQE6SvMkSsXNDkcG4NN(object P_0)
			{
				return ((IWorkflowInstance)P_0).Process;
			}

			internal static long NXhQRVvMUPA1EAxaQpBH(object P_0)
			{
				return ((IWorkflowProcess)P_0).VersionNumber;
			}

			internal static object ApNOm3vMVx1K62ciINGM(object P_0)
			{
				return ((IWorkflowInstance)P_0).Name;
			}

			internal static object mxo9PsvMAU5d0CDeVflm(object P_0)
			{
				return ((IWorkflowInstance)P_0).Responsible;
			}

			internal static bool DRfsCHvMQc4wDxx3iPpN()
			{
				return En8FqCvMTUkJcEJ8yZYL == null;
			}

			internal static ProcessInfo OjasRpvMpVAVYTMitM2T()
			{
				return En8FqCvMTUkJcEJ8yZYL;
			}
		}

		internal const string MethodName = "TasksInfo";

		internal static EntitySerializationFunctions ContextSerializationFunctions;

		internal static TasksInfoMethodExecutor rREDm4v6WofsYdjVvxql;

		public static string Description => (string)CWQV87v6qu70vo2R2yNm(MFKR43v66gWFiuDOtCZd(0x157D5AF4 ^ 0x157FB696));

		public static TypeSerializationDescriptor ParametersDescriptor => new TypeSerializationDescriptorBuilder().ItemWithDescriptor(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-10408775 ^ -10239927), delegate(TypeSerializationDescriptorBuilder ids)
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
					((TypeSerializationDescriptorBuilder)_003C_003Ec.EHMOELvMFuKTVn13TIox(ids, _003C_003Ec.TLi2R2vMoVPhInWN23rW(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6C7F14 ^ 0x6F7F92)))).IsArray((Action<TypeSerializationDescriptorBuilder>)delegate(TypeSerializationDescriptorBuilder i)
					{
						int num3 = 1;
						int num4 = num3;
						while (true)
						{
							switch (num4)
							{
							default:
								return;
							case 0:
								return;
							case 1:
								i.ItemWithDescriptor((string)_003C_003Ec.uZHB6UvMi1Y2HHrKKNIX(0xA7339EE ^ 0xA737F68), delegate(TypeSerializationDescriptorBuilder id)
								{
									int num5 = 1;
									int num6 = num5;
									while (true)
									{
										switch (num6)
										{
										default:
											return;
										case 1:
											_003C_003Ec.aMhNufvMaRiPs0FNGs0X(_003C_003Ec.EHMOELvMFuKTVn13TIox(id, _003C_003Ec.TLi2R2vMoVPhInWN23rW(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x213F6477 ^ 0x213D9B5F))), _003C_003Ec.om5Gs9vMICPfsxl23fMX(typeof(long).TypeHandle));
											num6 = 0;
											if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e4c570270f54493d8f3f4763a72f63f7 == 0)
											{
												num6 = 0;
											}
											break;
										case 0:
											return;
										}
									}
								});
								num4 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f508947b0d94af1961e5aa17a8a2044 != 0)
								{
									num4 = 0;
								}
								break;
							}
						}
					});
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1de08766357542bdb81146373079f817 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}).Descriptor;

		public static TypeSerializationDescriptor ResultDescriptor => new TypeSerializationDescriptorBuilder().ItemWithDescriptor((string)MFKR43v66gWFiuDOtCZd(-1895853023 ^ -1895991077), delegate(TypeSerializationDescriptorBuilder i)
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
					((TypeSerializationDescriptorBuilder)_003C_003Ec.EHMOELvMFuKTVn13TIox(i, _003C_003Ec.TLi2R2vMoVPhInWN23rW(_003C_003Ec.uZHB6UvMi1Y2HHrKKNIX(-667465279 ^ -667662075)))).IsArray((Action<TypeSerializationDescriptorBuilder>)TaskForm.GetDescriptor);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_160bffb148c14c5da92d8d6ddf481bdc == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}).Descriptor;

		public TasksInfoMethodExecutor(WebData parameters)
		{
			//Discarded unreachable code: IL_002b, IL_0030
			AhGaEPv635SvWQRN9iwF();
			base._002Ector(parameters);
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e632863bfb124ba083e3ba9b363fd70e != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		public override WebData Execute()
		{
			return ExecuteInternal();
		}

		private WebData ExecuteInternal()
		{
			//Discarded unreachable code: IL_0096, IL_00b0, IL_01bf, IL_01ce, IL_0324, IL_0333
			int num = 22;
			TaskForm taskForm = default(TaskForm);
			IWorkflowTaskBase workflowTaskBase = default(IWorkflowTaskBase);
			int num3 = default(int);
			WebDataItem webDataItem = default(WebDataItem);
			WebDataItem webDataItem2 = default(WebDataItem);
			List<WebData> list = default(List<WebData>);
			WebData[] array = default(WebData[]);
			WebData webData = default(WebData);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					object obj;
					switch (num2)
					{
					case 3:
						taskForm = (TaskForm)v9p1nev6AfTGcf7uJRxI(this, workflowTaskBase);
						num2 = 7;
						continue;
					case 9:
					case 21:
						obj = null;
						goto IL_03af;
					case 11:
						num3++;
						num2 = 13;
						continue;
					case 12:
						if (webDataItem != null)
						{
							num2 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f8a84e2cb374827a50ba2cbcf11cf48 != 0)
							{
								num2 = 0;
							}
							continue;
						}
						goto case 2;
					case 22:
						if (Parameters == null)
						{
							num2 = 18;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6b089b0d02ae4d3186c8d2cb8a24d4d3 == 0)
							{
								num2 = 21;
							}
							continue;
						}
						goto case 10;
					case 14:
						if (DISQ3tv6pHpuy1bDbCOq(webDataItem2) == null)
						{
							num2 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_db8eb3e90ad546d4b05544ab6326a49f == 0)
							{
								num2 = 16;
							}
							continue;
						}
						list = new List<WebData>();
						num2 = 3;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7ed81ca3cf804abbade4684f28f485d1 == 0)
						{
							num2 = 8;
						}
						continue;
					case 2:
						throw ogxcvKv6UAfCTj33yyU5(SR.T((string)MFKR43v66gWFiuDOtCZd(-1647793954 ^ -1647689398)), 200);
					case 16:
						throw PublicServiceException.CreateWebFault((string)CWQV87v6qu70vo2R2yNm(MFKR43v66gWFiuDOtCZd(0x1AF6F1F2 ^ 0x1AF41CFA)));
					case 6:
						list.Add((WebData)G71ir1v6GgbpPE3N30se(taskForm, true));
						num2 = 11;
						continue;
					case 17:
						if (webDataItem2 != null)
						{
							num2 = 14;
							continue;
						}
						goto case 16;
					case 8:
						array = (WebData[])DISQ3tv6pHpuy1bDbCOq(webDataItem2);
						num2 = 4;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9570b4a70465495fba22c942f586465a != 0)
						{
							num2 = 4;
						}
						continue;
					case 7:
						if (taskForm != null)
						{
							num2 = 6;
							continue;
						}
						goto case 11;
					case 1:
						throw ogxcvKv6UAfCTj33yyU5(CWQV87v6qu70vo2R2yNm(MFKR43v66gWFiuDOtCZd(0x8D5763A ^ 0x8D79FE8)), 200);
					case 4:
						num3 = 0;
						num2 = 19;
						continue;
					case 18:
					{
						WebData webData2 = webData;
						WebDataItem[] array2 = new WebDataItem[1];
						WebDataItem webDataItem3 = new WebDataItem();
						ksTEXJv674ggmu5C9imR(webDataItem3, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6C7F14 ^ 0x6E93EE));
						OiIg07v6oC2PoPZ0TTIu(webDataItem3, tvYwNMv62EMqnpSC70Eg(list));
						array2[0] = webDataItem3;
						webData2.Items = array2;
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 == 0)
						{
							num2 = 5;
						}
						continue;
					}
					case 13:
					case 19:
						if (num3 >= array.Length)
						{
							num2 = 23;
							continue;
						}
						goto case 20;
					case 5:
						return webData;
					case 10:
						if (LAvR2iv6QvPxdwA3qfev(ft5T1rv6TFXUw3TEZZVk(this)) != null)
						{
							num = 15;
							break;
						}
						goto case 9;
					case 20:
						webDataItem = (WebDataItem)n9C3hqv6CrkiKA64fpoY(array[num3], SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x213F6477 ^ 0x213F22F1));
						num2 = 12;
						continue;
					default:
						if (!RPJDg1v6kDTO7UT8DYw5(y8NX8gv6MPMeXMVFgXO8(webDataItem)))
						{
							if (!long.TryParse(webDataItem.Value, out var result))
							{
								num2 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a == 0)
								{
									num2 = 1;
								}
								continue;
							}
							workflowTaskBase = ((EntityExtensionManager<ITaskBase, IWorkflowTaskBase, long, TaskBaseManager>)FBsArSv6VBJK5eCDd8vS()).Load(result).CastAsRealType();
							num2 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8a6cf36da0b84f319a7cf27018f28f5b == 0)
							{
								num2 = 3;
							}
						}
						else
						{
							num2 = 2;
						}
						continue;
					case 23:
						webData = new WebData();
						num = 18;
						break;
					case 15:
						{
							obj = Parameters.FindItem(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420003255 ^ -420106567));
							goto IL_03af;
						}
						IL_03af:
						webDataItem2 = (WebDataItem)obj;
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4459fbe344a947429d197733d274ef68 != 0)
						{
							num2 = 17;
						}
						continue;
					}
					break;
				}
			}
		}

		private static Dictionary<string, EntitySerializationSelector> CreateEntitySerializationSelectorProperties(object metadata, IEnumerable<PropertyViewItem> properties)
		{
			Dictionary<string, EntitySerializationSelector> dictionary = new Dictionary<string, EntitySerializationSelector>();
			using IEnumerator<IGrouping<Guid, PropertyViewItem>> enumerator = (from p in properties
				group p by p.PropertyUid).GetEnumerator();
			while (enumerator.MoveNext())
			{
				_003C_003Ec__DisplayClass11_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass11_0();
				CS_0024_003C_003E8__locals0.grouping = enumerator.Current;
				IPropertyMetadata propertyMetadata = ((ClassMetadata)metadata).Properties.Cast<IPropertyMetadata>().Concat(((EntityMetadata)metadata).TableParts).FirstOrDefault((IPropertyMetadata p) => _003C_003Ec__DisplayClass11_0.gIY82NvM4AWfaH6uA89v(p.Uid, CS_0024_003C_003E8__locals0.grouping.Key));
				if (propertyMetadata == null)
				{
					continue;
				}
				PropertyViewItem[] array = CS_0024_003C_003E8__locals0.grouping.SelectMany((PropertyViewItem p) => p.FindItems(ignoreHide: false, (ViewItem i) => i is PropertyViewItem, (ViewItem i) => !(i is PropertyViewItem))).Cast<PropertyViewItem>().ToArray();
				if (array.Length != 0)
				{
					dictionary[propertyMetadata.Name] = new EntitySerializationSelector
					{
						Properties = CreateEntitySerializationSelectorProperties((EntityMetadata)MetadataLoader.LoadMetadata(propertyMetadata.SubTypeUid), array),
						SelectionMode = SelectionMode.ByName
					};
				}
				else
				{
					dictionary[propertyMetadata.Name] = new EntitySerializationSelector();
				}
			}
			return dictionary;
		}

		protected virtual TaskForm CreateTaskFormInternal(IWorkflowTaskBase task)
		{
			return (TaskForm)Xi7ZBFv6FN2Ag0RcvcnS(task);
		}

		internal static TaskForm CreateTaskForm(IWorkflowTaskBase task)
		{
			return new TaskForm(task);
		}

		static TasksInfoMethodExecutor()
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					AhGaEPv635SvWQRN9iwF();
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4cc62744d0eb4cd68219b70dcad3e68e == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					return;
				}
				ContextSerializationFunctions = new EntitySerializationFunctions
				{
					CopyForSettings = delegate(EntitySerializationFunctions functions, object obj, ClassMetadata metadata, IPropertyMetadata propertyMetadata, EntitySerializationSettings oldSettings, EntitySerializationSettings newSettings)
					{
						//Discarded unreachable code: IL_0090, IL_0230, IL_023f, IL_02c5
						int num3 = 13;
						int num4 = num3;
						while (true)
						{
							switch (num4)
							{
							case 8:
								if (((EntitySerializationSelector)_003C_003Ec.CjaNBdvMSUroPPkF8OHH(newSettings)).Properties == null)
								{
									num4 = 4;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 == 0)
									{
										num4 = 14;
									}
									break;
								}
								goto case 7;
							case 6:
								if (!_003C_003Ec.LH5aDsvMe2huMLauD893(_003C_003Ec.AYEiUdvMNF91c1pnvVAX(propertyMetadata), DocumentTypeDescriptor.UID))
								{
									num4 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a50dda04dedf4515816f963c67783c8f != 0)
									{
										num4 = 0;
									}
									break;
								}
								goto case 10;
							case 14:
							{
								ContextEntitySerializationSelector obj3 = new ContextEntitySerializationSelector
								{
									Properties = new Dictionary<string, EntitySerializationSelector>
									{
										{
											SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-790221436 ^ -790205694),
											new EntitySerializationSelector()
										},
										{
											(string)_003C_003Ec.uZHB6UvMi1Y2HHrKKNIX(-801808857 ^ -801870959),
											new EntitySerializationSelector()
										},
										{
											(string)_003C_003Ec.uZHB6UvMi1Y2HHrKKNIX(-1303601216 ^ -1303586372),
											new EntitySerializationSelector()
										},
										{
											SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1430645277 ^ -1430629523),
											new EntitySerializationSelector()
										},
										{
											SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-14356676 ^ -14384890),
											new EntitySerializationSelector()
										},
										{
											(string)_003C_003Ec.uZHB6UvMi1Y2HHrKKNIX(-1001967776 ^ -1001948280),
											new EntitySerializationSelector()
										}
									}
								};
								_003C_003Ec.zyBbiHvMxi94IJUtPX1e(obj3, SelectionMode.ByName);
								newSettings.PropertySelector = obj3;
								num4 = 14;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1b8b735647da470aa2d45d64d6f538d1 != 0)
								{
									num4 = 15;
								}
								break;
							}
							case 4:
								if (!_003C_003Ec.LH5aDsvMe2huMLauD893(_003C_003Ec.VgWDoGvMridHrNYclJ83(propertyMetadata), InterfaceActivator.UID<IDocument>(loadImplementation: false)))
								{
									num4 = 6;
									break;
								}
								goto case 10;
							case 7:
							case 15:
								return functions;
							case 13:
								if (oldSettings.PropertySelector is ContextEntitySerializationSelector)
								{
									num4 = 12;
									break;
								}
								if (propertyMetadata.TypeUid == EntityDescriptor.UID)
								{
									num4 = 4;
									break;
								}
								goto case 6;
							case 9:
								if (newSettings.PropertySelector.Properties != null)
								{
									num4 = 16;
									break;
								}
								goto case 2;
							case 11:
								if (_003C_003Ec.CjaNBdvMSUroPPkF8OHH(newSettings) != null)
								{
									num4 = 8;
									break;
								}
								goto case 14;
							default:
								if (propertyMetadata.TypeUid == EntityDescriptor.UID)
								{
									num4 = 5;
									break;
								}
								goto case 7;
							case 5:
								if (!(_003C_003Ec.VgWDoGvMridHrNYclJ83(propertyMetadata) == InterfaceActivator.UID<IAttachment>(loadImplementation: false)))
								{
									num4 = 7;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd == 0)
									{
										num4 = 5;
									}
									break;
								}
								goto case 11;
							case 10:
								if (newSettings.PropertySelector == null)
								{
									num4 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f8a84e2cb374827a50ba2cbcf11cf48 == 0)
									{
										num4 = 2;
									}
									break;
								}
								goto case 9;
							case 2:
							case 3:
							{
								ContextEntitySerializationSelector obj2 = new ContextEntitySerializationSelector
								{
									Properties = new Dictionary<string, EntitySerializationSelector>
									{
										{
											(string)_003C_003Ec.uZHB6UvMi1Y2HHrKKNIX(-11799394 ^ -11816424),
											new EntitySerializationSelector()
										},
										{
											(string)_003C_003Ec.uZHB6UvMi1Y2HHrKKNIX(-1498811449 ^ -1498888591),
											new EntitySerializationSelector()
										},
										{
											(string)_003C_003Ec.uZHB6UvMi1Y2HHrKKNIX(--296112178 ^ 0x11A6164E),
											new EntitySerializationSelector()
										},
										{
											(string)_003C_003Ec.uZHB6UvMi1Y2HHrKKNIX(-935313063 ^ -935327785),
											new EntitySerializationSelector()
										},
										{
											SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-667465279 ^ -667662089),
											new ContextEntitySerializationSelector
											{
												Properties = new Dictionary<string, EntitySerializationSelector>
												{
													{
														(string)_003C_003Ec.uZHB6UvMi1Y2HHrKKNIX(-1001967776 ^ -1001952794),
														new EntitySerializationSelector()
													},
													{
														(string)_003C_003Ec.uZHB6UvMi1Y2HHrKKNIX(-1712492721 ^ -1712563463),
														new EntitySerializationSelector()
													},
													{
														(string)_003C_003Ec.uZHB6UvMi1Y2HHrKKNIX(0x213F6477 ^ 0x213F220B),
														new EntitySerializationSelector()
													},
													{
														(string)_003C_003Ec.uZHB6UvMi1Y2HHrKKNIX(0x46EA3D1 ^ 0x46EE55F),
														new EntitySerializationSelector()
													},
													{
														(string)_003C_003Ec.uZHB6UvMi1Y2HHrKKNIX(0x3C1FFB55 ^ 0x3C1CFA03),
														new EntitySerializationSelector()
													},
													{
														(string)_003C_003Ec.uZHB6UvMi1Y2HHrKKNIX(0x614CF569 ^ 0x614FF401),
														new EntitySerializationSelector()
													},
													{
														(string)_003C_003Ec.uZHB6UvMi1Y2HHrKKNIX(0x56A753C9 ^ 0x56A73DF3),
														new EntitySerializationSelector()
													},
													{
														(string)_003C_003Ec.uZHB6UvMi1Y2HHrKKNIX(-1716458555 ^ -1716262331),
														new EntitySerializationSelector()
													},
													{
														(string)_003C_003Ec.uZHB6UvMi1Y2HHrKKNIX(-17847711 ^ -17920891),
														new EntitySerializationSelector()
													}
												},
												SelectionMode = SelectionMode.ByName
											}
										}
									}
								};
								_003C_003Ec.zyBbiHvMxi94IJUtPX1e(obj2, SelectionMode.ByName);
								newSettings.PropertySelector = obj2;
								num4 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e != 0)
								{
									num4 = 0;
								}
								break;
							}
							case 12:
								return functions;
							}
						}
					}
				};
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1b8b735647da470aa2d45d64d6f538d1 != 0)
				{
					num2 = 2;
				}
			}
		}

		internal static object MFKR43v66gWFiuDOtCZd(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object CWQV87v6qu70vo2R2yNm(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static bool qp6kOcv6jxm0w4h69Amw()
		{
			return rREDm4v6WofsYdjVvxql == null;
		}

		internal static TasksInfoMethodExecutor oTfoGvv6RXlC1Xha2i4D()
		{
			return rREDm4v6WofsYdjVvxql;
		}

		internal static void AhGaEPv635SvWQRN9iwF()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}

		internal static object ft5T1rv6TFXUw3TEZZVk(object P_0)
		{
			return ((PublicServiceMethodExecutor)P_0).Parameters;
		}

		internal static object LAvR2iv6QvPxdwA3qfev(object P_0)
		{
			return ((WebData)P_0).Items;
		}

		internal static object DISQ3tv6pHpuy1bDbCOq(object P_0)
		{
			return ((WebDataItem)P_0).DataArray;
		}

		internal static object n9C3hqv6CrkiKA64fpoY(object P_0, object P_1)
		{
			return ((WebData)P_0).FindItem((string)P_1);
		}

		internal static object y8NX8gv6MPMeXMVFgXO8(object P_0)
		{
			return ((WebDataItem)P_0).Value;
		}

		internal static bool RPJDg1v6kDTO7UT8DYw5(object P_0)
		{
			return string.IsNullOrEmpty((string)P_0);
		}

		internal static object ogxcvKv6UAfCTj33yyU5(object P_0, int P_1)
		{
			return PublicServiceException.CreateWebFault((string)P_0, P_1);
		}

		internal static object FBsArSv6VBJK5eCDd8vS()
		{
			return WorkflowTaskBaseManager.Instance;
		}

		internal static object v9p1nev6AfTGcf7uJRxI(object P_0, object P_1)
		{
			return ((TasksInfoMethodExecutor)P_0).CreateTaskFormInternal((IWorkflowTaskBase)P_1);
		}

		internal static object G71ir1v6GgbpPE3N30se(object P_0, bool needId)
		{
			return ((TaskForm)P_0).ToWebData(needId);
		}

		internal static void ksTEXJv674ggmu5C9imR(object P_0, object P_1)
		{
			((WebDataItem)P_0).Name = (string)P_1;
		}

		internal static object tvYwNMv62EMqnpSC70Eg(object P_0)
		{
			return ((List<WebData>)P_0).ToArray();
		}

		internal static void OiIg07v6oC2PoPZ0TTIu(object P_0, object P_1)
		{
			((WebDataItem)P_0).DataArray = (WebData[])P_1;
		}

		internal static object Xi7ZBFv6FN2Ag0RcvcnS(object P_0)
		{
			return CreateTaskForm((IWorkflowTaskBase)P_0);
		}
	}

	internal class ExecuteUserTaskMethodExecutor : PublicServiceMethodExecutor
	{
		private static class Names
		{
		}

		internal const string MethodName = "ExecuteUserTask";

		private static ExecuteUserTaskMethodExecutor i4iH9Yv6iJWKNiSfaFCq;

		public static string Description => (string)qlEFcAv6e2e2udqEpunJ(dcSbOgv6rpyBI0i3QLnM(--1436248540 ^ 0x55998484));

		public static TypeSerializationDescriptor ParametersDescriptor => new TypeSerializationDescriptorBuilder().ItemWithDescriptor((string)dcSbOgv6rpyBI0i3QLnM(-1028861977 ^ -1028880031), delegate(TypeSerializationDescriptorBuilder i)
		{
			int num5 = 1;
			int num6 = num5;
			while (true)
			{
				switch (num6)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					_003C_003Ec.g8BFCmvk0t88D46yYt5o(i.Description((string)_003C_003Ec.raQC5fvkJghC44v3i1Br(_003C_003Ec.fdt0prvksXBsaabiC6Yr(-452127399 ^ -451941775))), _003C_003Ec.ORfN7NvklkDcJHk8BuNv(typeof(long).TypeHandle));
					num6 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd != 0)
					{
						num6 = 0;
					}
					break;
				}
			}
		}).ItemWithDescriptor((string)dcSbOgv6rpyBI0i3QLnM(0x5F534A5C ^ 0x5F535AC4), delegate(TypeSerializationDescriptorBuilder i)
		{
			int num3 = 1;
			int num4 = num3;
			while (true)
			{
				switch (num4)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					((TypeSerializationDescriptorBuilder)_003C_003Ec.RHP5C2vky53WBMpYlGJN(i, _003C_003Ec.raQC5fvkJghC44v3i1Br(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x13F63440 ^ 0x13F4E358)))).Type(_003C_003Ec.ORfN7NvklkDcJHk8BuNv(typeof(WebData).TypeHandle));
					num4 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3ab79470996d472f815915b21f45aac1 != 0)
					{
						num4 = 0;
					}
					break;
				}
			}
		}).ItemWithDescriptor((string)dcSbOgv6rpyBI0i3QLnM(-495296780 ^ -495405156), delegate(TypeSerializationDescriptorBuilder i)
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
					_003C_003Ec.g8BFCmvk0t88D46yYt5o(_003C_003Ec.RHP5C2vky53WBMpYlGJN(i, SR.T((string)_003C_003Ec.fdt0prvksXBsaabiC6Yr(0x74AB4717 ^ 0x74A9B843))), _003C_003Ec.ORfN7NvklkDcJHk8BuNv(typeof(Guid).TypeHandle));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		})
			.Descriptor;

		public static TypeSerializationDescriptor ResultDescriptor => (TypeSerializationDescriptor)Vx7yK7v6NmU9SHbqImyr(new TypeSerializationDescriptorBuilder().ItemWithDescriptor((string)dcSbOgv6rpyBI0i3QLnM(-106528299 ^ -106667255), delegate(TypeSerializationDescriptorBuilder i)
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
					((TypeSerializationDescriptorBuilder)_003C_003Ec.RHP5C2vky53WBMpYlGJN(i, SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1574607501 ^ -1574542111)))).Type(_003C_003Ec.ORfN7NvklkDcJHk8BuNv(typeof(bool).TypeHandle));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b1ab9396b25b43af8f32e24b1948be96 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}).ApplyParametersDescriptor(needUnknownStatus: false, needExecutionToken: false, needStatus: false));

		public ExecuteUserTaskMethodExecutor(WebData parameters)
		{
			//Discarded unreachable code: IL_002b, IL_0030
			e83R2hv6xqf0l8POffQ3();
			base._002Ector(parameters);
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0991fd79553c4ecc82e8b5cb79c2bff2 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		public override WebData Execute()
		{
			return ExecuteInternal();
		}

		private WebData ExecuteInternal()
		{
			//Discarded unreachable code: IL_0115, IL_01c8, IL_03eb, IL_040b
			int num = 5;
			WebDataItem webDataItem2 = default(WebDataItem);
			IWorkflowTaskBase workflowTaskBase = default(IWorkflowTaskBase);
			WebDataItem webDataItem = default(WebDataItem);
			long result = default(long);
			WebDataItem webDataItem3 = default(WebDataItem);
			IDictionary<string, object> serObj = default(IDictionary<string, object>);
			Dictionary<string, object> dictionary = default(Dictionary<string, object>);
			Guid result2 = default(Guid);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 6:
						throw GAfOslv6ELRvF3tKuSAK(qlEFcAv6e2e2udqEpunJ(dcSbOgv6rpyBI0i3QLnM(-1361036319 ^ -1360867161)), 200);
					case 1:
						webDataItem2 = (WebDataItem)yBgMsBv6186w8qmXGrJ1(BGoIiVv6SNB8KCvd3R0Q(this), dcSbOgv6rpyBI0i3QLnM(-790221436 ^ -790217444));
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9570b4a70465495fba22c942f586465a != 0)
						{
							num2 = 0;
						}
						break;
					case 3:
						throw GAfOslv6ELRvF3tKuSAK(qlEFcAv6e2e2udqEpunJ(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1574607501 ^ -1574465739)), 200);
					case 17:
						if (workflowTaskBase.IsComplete())
						{
							num2 = 8;
							break;
						}
						webDataItem = (WebDataItem)yBgMsBv6186w8qmXGrJ1(BGoIiVv6SNB8KCvd3R0Q(this), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x614CF569 ^ 0x614E1C01));
						num2 = 13;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6d48f3b4557a49578bf7f5ef0517e0be == 0)
						{
							num2 = 11;
						}
						break;
					case 22:
						throw GAfOslv6ELRvF3tKuSAK(qlEFcAv6e2e2udqEpunJ(dcSbOgv6rpyBI0i3QLnM(-43932417 ^ -43823109)), 200);
					case 2:
						throw GAfOslv6ELRvF3tKuSAK(qlEFcAv6e2e2udqEpunJ(dcSbOgv6rpyBI0i3QLnM(0x56F860D7 ^ 0x56FA8905)), 200);
					case 14:
						workflowTaskBase = ((EntityExtensionManager<ITaskBase, IWorkflowTaskBase, long, TaskBaseManager>)lhNOMXv6w4VOUiGmyrMb()).Load(result).CastAsRealType();
						num2 = 12;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e2e244178c44ea09cd756894b022a62 == 0)
						{
							num2 = 8;
						}
						break;
					case 5:
						webDataItem3 = (WebDataItem)yBgMsBv6186w8qmXGrJ1(BGoIiVv6SNB8KCvd3R0Q(this), dcSbOgv6rpyBI0i3QLnM(-1638225214 ^ -1638208444));
						num2 = 4;
						break;
					case 8:
						throw GAfOslv6ELRvF3tKuSAK(SR.T((string)dcSbOgv6rpyBI0i3QLnM(-865213812 ^ -865138580)), 200);
					case 16:
						new EntityJsonSerializer().ConvertFromSerializable(qcN5j1vqZYTSaFsfq1jl(aoqQntvqOQpWwETTSBbE(ONhnLrvqKpByrcja6VV0(workflowTaskBase))), serObj);
						num2 = 18;
						break;
					case 19:
						serObj = ((WebData)Wi7v71v6zs0G9jE1IUMH(webDataItem2)).ToDictionary();
						num2 = 16;
						break;
					case 9:
						dictionary = new Dictionary<string, object> { 
						{
							(string)dcSbOgv6rpyBI0i3QLnM(-135674354 ^ -135584558),
							true
						} };
						num2 = 7;
						break;
					case 7:
						ExecuteUserTaskStatusHelper.Execute(workflowTaskBase, dictionary, EUZUpfvqYO5m8mexOqGG(1.0), needExecutionToken: false);
						num2 = 11;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_938c6be4ea2248868d7ed5d0e3346006 == 0)
						{
							num2 = 8;
						}
						break;
					case 12:
						if (workflowTaskBase is IWorkflowTask)
						{
							num2 = 17;
							break;
						}
						goto case 3;
					case 10:
						if (!KJQakfv64yUE5YH4BrHK(zpxmOmv6h01DFbq5AcAb(webDataItem)))
						{
							if (Guid.TryParse((string)zpxmOmv6h01DFbq5AcAb(webDataItem), out result2))
							{
								num2 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 == 0)
								{
									num2 = 1;
								}
								break;
							}
							goto case 6;
						}
						num2 = 22;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_545887e65739480a965b7ddfab7d0632 != 0)
						{
							num2 = 3;
						}
						break;
					case 21:
						throw PublicServiceException.CreateWebFault((string)qlEFcAv6e2e2udqEpunJ(dcSbOgv6rpyBI0i3QLnM(-642713667 ^ -642638295)));
					case 11:
						return new WebData(dictionary);
					case 18:
					case 20:
						t5uT0svqvmUCoUXt3vDB(workflowTaskBase, result2);
						num2 = 9;
						break;
					default:
						if (webDataItem2 == null)
						{
							num2 = 20;
							break;
						}
						goto case 23;
					case 15:
						if (!string.IsNullOrEmpty((string)zpxmOmv6h01DFbq5AcAb(webDataItem3)))
						{
							if (long.TryParse(webDataItem3.Value, out result))
							{
								goto end_IL_0012;
							}
							goto case 2;
						}
						num2 = 21;
						break;
					case 4:
						if (webDataItem3 != null)
						{
							num2 = 15;
							break;
						}
						goto case 21;
					case 23:
						if (webDataItem2.Data != null)
						{
							num2 = 19;
							break;
						}
						goto case 18;
					case 13:
						if (webDataItem != null)
						{
							num2 = 10;
							break;
						}
						goto case 22;
					}
					continue;
					end_IL_0012:
					break;
				}
				num = 14;
			}
		}

		internal static object dcSbOgv6rpyBI0i3QLnM(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object qlEFcAv6e2e2udqEpunJ(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static bool Vlwuyfv6IxiaYVBVFjIt()
		{
			return i4iH9Yv6iJWKNiSfaFCq == null;
		}

		internal static ExecuteUserTaskMethodExecutor jRZtpuv6aIeN1F7Daui6()
		{
			return i4iH9Yv6iJWKNiSfaFCq;
		}

		internal static object Vx7yK7v6NmU9SHbqImyr(object P_0)
		{
			return ((TypeSerializationDescriptorBuilder)P_0).Descriptor;
		}

		internal static void e83R2hv6xqf0l8POffQ3()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}

		internal static object BGoIiVv6SNB8KCvd3R0Q(object P_0)
		{
			return ((PublicServiceMethodExecutor)P_0).Parameters;
		}

		internal static object yBgMsBv6186w8qmXGrJ1(object P_0, object P_1)
		{
			return ((WebData)P_0).FindItem((string)P_1);
		}

		internal static object zpxmOmv6h01DFbq5AcAb(object P_0)
		{
			return ((WebDataItem)P_0).Value;
		}

		internal static object GAfOslv6ELRvF3tKuSAK(object P_0, int P_1)
		{
			return PublicServiceException.CreateWebFault((string)P_0, P_1);
		}

		internal static object lhNOMXv6w4VOUiGmyrMb()
		{
			return WorkflowTaskBaseManager.Instance;
		}

		internal static bool KJQakfv64yUE5YH4BrHK(object P_0)
		{
			return string.IsNullOrEmpty((string)P_0);
		}

		internal static object Wi7v71v6zs0G9jE1IUMH(object P_0)
		{
			return ((WebDataItem)P_0).Data;
		}

		internal static object ONhnLrvqKpByrcja6VV0(object P_0)
		{
			return ((IWorkflowTaskBase)P_0).WorkflowBookmark;
		}

		internal static object aoqQntvqOQpWwETTSBbE(object P_0)
		{
			return ((IWorkflowBookmark)P_0).Instance;
		}

		internal static object qcN5j1vqZYTSaFsfq1jl(object P_0)
		{
			return ((IWorkflowInstance)P_0).Context;
		}

		internal static void t5uT0svqvmUCoUXt3vDB(object P_0, Guid connectorUid)
		{
			((IWorkflowTaskBase)P_0).Execute(connectorUid);
		}

		internal static TimeSpan EUZUpfvqYO5m8mexOqGG(double P_0)
		{
			return TimeSpan.FromHours(P_0);
		}
	}

	internal class TaskStandardOutputFlowsMethodExecutor : PublicServiceMethodExecutor
	{
		internal class FlowItem
		{
			private static FlowItem lUwLgMvkmuBrNyth3U0g;

			public Guid Uid
			{
				[CompilerGenerated]
				get
				{
					return _003CUid_003Ek__BackingField;
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
							_003CUid_003Ek__BackingField = value;
							num2 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a != 0)
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

			public Guid Status
			{
				[CompilerGenerated]
				get
				{
					return _003CStatus_003Ek__BackingField;
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
							_003CStatus_003Ek__BackingField = value;
							num2 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b876fa7b083748c8abf8c4b192a11078 != 0)
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

			public string Name
			{
				[CompilerGenerated]
				get
				{
					return _003CName_003Ek__BackingField;
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
							_003CName_003Ek__BackingField = value;
							num2 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ac5d16a577a84bb0b8ee3654769d2d33 == 0)
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

			public FlowItem()
			{
				//Discarded unreachable code: IL_002a, IL_002f
				yY7NqGvk58thRXcN3GJB();
				base._002Ector();
				int num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea != 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
			}

			internal static bool FdwrefvkttHXilqUkvej()
			{
				return lUwLgMvkmuBrNyth3U0g == null;
			}

			internal static FlowItem P6rYBYvkbeDVr2mv2var()
			{
				return lUwLgMvkmuBrNyth3U0g;
			}

			internal static void yY7NqGvk58thRXcN3GJB()
			{
				j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
			}
		}

		internal const string MethodName = "TaskStandardOutputFlows";

		private static TaskStandardOutputFlowsMethodExecutor ojcIk2vq8rZpNQJiBNrN;

		public static string Description => (string)cY6ZKuvq009UEL3kdQPv(RDbcrEvqlcNEScNydPXb(-2002063381 ^ -2002255243));

		public static TypeSerializationDescriptor ParametersDescriptor => (TypeSerializationDescriptor)dVNB7RvqyvlU0dnGEBUv(new TypeSerializationDescriptorBuilder().Item(delegate(TypeSerializationItemDescriptorBuilder b)
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
					((TypeSerializationItemDescriptorBuilder)_003C_003Ec.QrOJYUvkdaRPSX9rOvVM(b, _003C_003Ec.LyX1gqvkXYKBIXu7HqDt(0x628167BE ^ 0x628389B6))).Descriptor((string)_003C_003Ec.oJDURFvkuO2oR18g8pJA(_003C_003Ec.LyX1gqvkXYKBIXu7HqDt(-539998957 ^ -539802393)));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_805f3361d2ba4dac8da4174f89314253 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}));

		public static TypeSerializationDescriptor ResultDescriptor => (TypeSerializationDescriptor)dVNB7RvqyvlU0dnGEBUv(new TypeSerializationDescriptorBuilder().Item(delegate(TypeSerializationItemDescriptorBuilder b)
		{
			int num15 = 1;
			int num16 = num15;
			while (true)
			{
				switch (num16)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					_003C_003Ec.IosAhMvkDT9esZbOv3vZ(_003C_003Ec.QrOJYUvkdaRPSX9rOvVM(b, _003C_003Ec.LyX1gqvkXYKBIXu7HqDt(0x7AC609FE ^ 0x7AC4EB22)), _003C_003Ec.oJDURFvkuO2oR18g8pJA(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5BCD23A0 ^ 0x5BCE2190)));
					num16 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 != 0)
					{
						num16 = 0;
					}
					break;
				}
			}
		}).Item(delegate(TypeSerializationItemDescriptorBuilder b)
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
					b.Name((string)_003C_003Ec.LyX1gqvkXYKBIXu7HqDt(-1386448964 ^ -1386253044)).Descriptor(delegate(TypeSerializationDescriptorBuilder bi)
					{
						int num3 = 1;
						int num4 = num3;
						while (true)
						{
							switch (num4)
							{
							default:
								return;
							case 0:
								return;
							case 1:
								((TypeSerializationDescriptorBuilder)_003C_003Ec.E3QJJfvkn6TebXSliMl1(bi, true)).Description((string)_003C_003Ec.oJDURFvkuO2oR18g8pJA(_003C_003Ec.LyX1gqvkXYKBIXu7HqDt(0x37F755F5 ^ 0x37F4574B))).Item(delegate(TypeSerializationItemDescriptorBuilder ai)
								{
									int num5 = 1;
									int num6 = num5;
									while (true)
									{
										switch (num6)
										{
										default:
											return;
										case 0:
											return;
										case 1:
											ai.Descriptor(delegate(TypeSerializationDescriptorBuilder aai)
											{
												int num7 = 3;
												int num8 = num7;
												while (true)
												{
													switch (num8)
													{
													default:
														return;
													case 0:
														return;
													case 3:
														aai.Item(delegate(TypeSerializationItemDescriptorBuilder ia)
														{
															int num9 = 1;
															int num10 = num9;
															while (true)
															{
																switch (num10)
																{
																default:
																	return;
																case 1:
																	_003C_003Ec.IosAhMvkDT9esZbOv3vZ(_003C_003Ec.QrOJYUvkdaRPSX9rOvVM(ia, _003C_003Ec.LyX1gqvkXYKBIXu7HqDt(0x361628FF ^ 0x36166E83)), _003C_003Ec.oJDURFvkuO2oR18g8pJA(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-17847711 ^ -18044797)));
																	num10 = 0;
																	if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4cc62744d0eb4cd68219b70dcad3e68e != 0)
																	{
																		num10 = 0;
																	}
																	break;
																case 0:
																	return;
																}
															}
														});
														num8 = 2;
														break;
													case 2:
														aai.Item(delegate(TypeSerializationItemDescriptorBuilder ia)
														{
															int num11 = 1;
															int num12 = num11;
															while (true)
															{
																switch (num12)
																{
																default:
																	return;
																case 1:
																	((TypeSerializationItemDescriptorBuilder)_003C_003Ec.QrOJYUvkdaRPSX9rOvVM(ia, _003C_003Ec.LyX1gqvkXYKBIXu7HqDt(-790221436 ^ -790205628))).Descriptor((string)_003C_003Ec.oJDURFvkuO2oR18g8pJA(_003C_003Ec.LyX1gqvkXYKBIXu7HqDt(-947937941 ^ -948134325)));
																	num12 = 0;
																	if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a50dda04dedf4515816f963c67783c8f == 0)
																	{
																		num12 = 0;
																	}
																	break;
																case 0:
																	return;
																}
															}
														});
														num8 = 1;
														if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eef7d2ca1c3c4b74aeb81172ed542639 == 0)
														{
															num8 = 1;
														}
														break;
													case 1:
														aai.Item(delegate(TypeSerializationItemDescriptorBuilder ia)
														{
															int num13 = 1;
															int num14 = num13;
															while (true)
															{
																switch (num14)
																{
																default:
																	return;
																case 1:
																	_003C_003Ec.IosAhMvkDT9esZbOv3vZ(_003C_003Ec.QrOJYUvkdaRPSX9rOvVM(ia, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x37F755F5 ^ 0x37F7137B)), _003C_003Ec.oJDURFvkuO2oR18g8pJA(_003C_003Ec.LyX1gqvkXYKBIXu7HqDt(0x628167BE ^ 0x62826412)));
																	num14 = 0;
																	if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_69cb4a76addb44f28bb765f059e441c7 != 0)
																	{
																		num14 = 0;
																	}
																	break;
																case 0:
																	return;
																}
															}
														});
														num8 = 0;
														if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c == 0)
														{
															num8 = 0;
														}
														break;
													}
												}
											});
											num6 = 0;
											if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1c37d4e24e094858975336738e156495 == 0)
											{
												num6 = 0;
											}
											break;
										}
									}
								});
								num4 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 == 0)
								{
									num4 = 0;
								}
								break;
							}
						}
					});
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9570b4a70465495fba22c942f586465a == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}));

		public TaskStandardOutputFlowsMethodExecutor(WebData parameters)
		{
			//Discarded unreachable code: IL_002b, IL_0030
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
			base._002Ector(parameters);
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4ef74b4b7d13430e9d2f9b78cbdb367b == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		public override WebData Execute()
		{
			return ExecuteInternal();
		}

		private WebData ExecuteInternal()
		{
			//Discarded unreachable code: IL_005e, IL_006d, IL_0078, IL_019c, IL_01f0, IL_0203, IL_0352, IL_03e3, IL_03f2, IL_0402
			int num = 5;
			List<FlowConnectorElement>.Enumerator enumerator = default(List<FlowConnectorElement>.Enumerator);
			FlowConnectorElement current = default(FlowConnectorElement);
			List<FlowItem> list = default(List<FlowItem>);
			string name = default(string);
			WebDataItem webDataItem = default(WebDataItem);
			_003C_003Ec__DisplayClass9_0 _003C_003Ec__DisplayClass9_ = default(_003C_003Ec__DisplayClass9_0);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 9:
						try
						{
							while (true)
							{
								int num3;
								if (!enumerator.MoveNext())
								{
									num3 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 == 0)
									{
										num3 = 0;
									}
									goto IL_007c;
								}
								goto IL_0137;
								IL_0137:
								current = enumerator.Current;
								num3 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 != 0)
								{
									num3 = 0;
								}
								goto IL_007c;
								IL_007c:
								while (true)
								{
									object obj;
									switch (num3)
									{
									case 2:
										break;
									case 5:
										list.Add(new FlowItem
										{
											Name = name,
											Uid = current.Uid,
											Status = om9Rq7vqHmhh9KmDGoLP(current)
										});
										num3 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eef7d2ca1c3c4b74aeb81172ed542639 != 0)
										{
											num3 = 2;
										}
										continue;
									default:
										if (PEWC9Kvqu16ai2fHV2oP(C64wrXvqdyDuFE3tAnkQ(current)))
										{
											num3 = 3;
											if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 == 0)
											{
												num3 = 3;
											}
											continue;
										}
										obj = C64wrXvqdyDuFE3tAnkQ(current);
										goto IL_01a8;
									case 4:
										goto IL_0137;
									case 3:
										obj = duWOFHvqnJtas1rwE4X3(RDbcrEvqlcNEScNydPXb(--601115071 ^ 0x23D6A7A7), (putf1ivqD64RlJ26jn5R(current) != null) ? C64wrXvqdyDuFE3tAnkQ(current.EndElement) : "");
										goto IL_01a8;
									case 1:
										goto end_IL_009e;
										IL_01a8:
										name = (string)obj;
										num3 = 5;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_46e05b4e09174e34a9c81741b8b77a2f == 0)
										{
											num3 = 5;
										}
										continue;
									}
									break;
								}
								continue;
								end_IL_009e:
								break;
							}
						}
						finally
						{
							((IDisposable)enumerator).Dispose();
							int num4 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede != 0)
							{
								num4 = 0;
							}
							switch (num4)
							{
							case 0:
								break;
							}
						}
						goto case 3;
					case 7:
					case 13:
						return (WebData)ESquesvqbRZ0Dcb6ujE6(this);
					case 11:
						if (z3na40vqtnBrb02uvZXK(KQBcXivqmMI9mou1MSkH(this)) != null)
						{
							num2 = 14;
							continue;
						}
						goto case 8;
					case 1:
						throw U65si9vqgofBW6ZR1pjT(cY6ZKuvq009UEL3kdQPv(RDbcrEvqlcNEScNydPXb(-768800937 ^ -768610683)), 400);
					case 8:
					case 10:
						return (WebData)ESquesvqbRZ0Dcb6ujE6(this);
					case 14:
						webDataItem = Parameters.FindItem((string)RDbcrEvqlcNEScNydPXb(0x1145BED7 ^ 0x114750DF));
						num2 = 6;
						continue;
					case 6:
						if (webDataItem == null)
						{
							num = 7;
							break;
						}
						goto case 12;
					default:
						if (_003C_003Ec__DisplayClass9_.task.WorkflowBookmark == null)
						{
							num2 = 2;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea != 0)
							{
								num2 = 2;
							}
						}
						else
						{
							Element element = ((IEnumerable<Element>)KpOeUYvqXBUPieCy4SAl(((IWorkflowInstance)oE7K5rvqPrAxHVQwDnCF(CieBBAvqcr1AeEcLrHlQ(_003C_003Ec__DisplayClass9_.task))).Process.Diagram)).FirstOrDefault(_003C_003Ec__DisplayClass9_._003CExecuteInternal_003Eb__0);
							list = new List<FlowItem>();
							enumerator = ((BPMNFlowElement)element).StandardOutputFlows.GetEnumerator();
							num2 = 9;
						}
						continue;
					case 5:
						_003C_003Ec__DisplayClass9_ = new _003C_003Ec__DisplayClass9_0();
						num2 = 4;
						continue;
					case 12:
						if (!string.IsNullOrEmpty((string)QUGtSRvq5vbZe7gfUwNJ(webDataItem)))
						{
							if (!long.TryParse((string)QUGtSRvq5vbZe7gfUwNJ(webDataItem), out var result))
							{
								num2 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c != 0)
								{
									num2 = 1;
								}
								continue;
							}
							_003C_003Ec__DisplayClass9_.task = ((EntityExtensionManager<ITaskBase, IWorkflowTaskBase, long, TaskBaseManager>)Cic1i1vqBWf7AYbpQwYF()).Load(result).CastAsRealType();
							num2 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e8980a9fd9d44c20920ffa276900c96f != 0)
							{
								num2 = 0;
							}
						}
						else
						{
							num2 = 13;
						}
						continue;
					case 3:
						return GetResult(list);
					case 2:
						return GetResult(null);
					case 4:
						if (KQBcXivqmMI9mou1MSkH(this) == null)
						{
							num = 10;
							break;
						}
						goto case 11;
					}
					break;
				}
			}
		}

		protected virtual WebData GetResult(IEnumerable<FlowItem> flows)
		{
			if (flows != null)
			{
				return WebData.CreateFromObject(new
				{
					Result = true,
					Flows = flows.ToArray()
				});
			}
			return WebData.CreateFromObject(new
			{
				Result = true,
				Flows = new FlowItem[0]
			});
		}

		protected virtual WebData GetError()
		{
			return (WebData)VZR4mtvqLMPaSqyg7lHu(new
			{
				Result = false
			});
		}

		internal static object RDbcrEvqlcNEScNydPXb(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object cY6ZKuvq009UEL3kdQPv(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static bool XpetvGvqsFKBaqtv0aQ7()
		{
			return ojcIk2vq8rZpNQJiBNrN == null;
		}

		internal static TaskStandardOutputFlowsMethodExecutor aTFnMyvqJlB3GXlpe0bI()
		{
			return ojcIk2vq8rZpNQJiBNrN;
		}

		internal static object dVNB7RvqyvlU0dnGEBUv(object P_0)
		{
			return ((TypeSerializationDescriptorBuilder)P_0).Descriptor;
		}

		internal static object KQBcXivqmMI9mou1MSkH(object P_0)
		{
			return ((PublicServiceMethodExecutor)P_0).Parameters;
		}

		internal static object z3na40vqtnBrb02uvZXK(object P_0)
		{
			return ((WebData)P_0).Items;
		}

		internal static object ESquesvqbRZ0Dcb6ujE6(object P_0)
		{
			return ((TaskStandardOutputFlowsMethodExecutor)P_0).GetError();
		}

		internal static object QUGtSRvq5vbZe7gfUwNJ(object P_0)
		{
			return ((WebDataItem)P_0).Value;
		}

		internal static object U65si9vqgofBW6ZR1pjT(object P_0, int P_1)
		{
			return PublicServiceException.CreateWebFault((string)P_0, P_1);
		}

		internal static object Cic1i1vqBWf7AYbpQwYF()
		{
			return WorkflowTaskBaseManager.Instance;
		}

		internal static object CieBBAvqcr1AeEcLrHlQ(object P_0)
		{
			return ((IWorkflowTaskBase)P_0).WorkflowBookmark;
		}

		internal static object oE7K5rvqPrAxHVQwDnCF(object P_0)
		{
			return ((IWorkflowBookmark)P_0).Instance;
		}

		internal static object KpOeUYvqXBUPieCy4SAl(object P_0)
		{
			return ((Diagram)P_0).Elements;
		}

		internal static object C64wrXvqdyDuFE3tAnkQ(object P_0)
		{
			return ((Element)P_0).Name;
		}

		internal static bool PEWC9Kvqu16ai2fHV2oP(object P_0)
		{
			return string.IsNullOrEmpty((string)P_0);
		}

		internal static object putf1ivqD64RlJ26jn5R(object P_0)
		{
			return ((Connector)P_0).EndElement;
		}

		internal static object duWOFHvqnJtas1rwE4X3(object P_0, object P_1)
		{
			return (string)P_0 + (string)P_1;
		}

		internal static Guid om9Rq7vqHmhh9KmDGoLP(object P_0)
		{
			return ((FlowConnectorElement)P_0).Status;
		}

		internal static object VZR4mtvqLMPaSqyg7lHu(object P_0)
		{
			return WebData.CreateFromObject(P_0);
		}
	}

	internal const string NextTaskId = "NextTaskId";

	internal const string NextTaskTypeUid = "NextTaskTypeUid";

	internal static WorkflowPublicServiceMethodsProvider snW7HkZnML3LhWVqb1gJ;

	public IEnumerable<IPublicServiceMethod> GetMethods()
	{
		return new PublicServiceMethod[10]
		{
			new PublicServiceMethod(WorkflowPublicService.UID, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1108877388 ^ -1109058668), TaskStandardOutputFlowsMethodExecutor.Description, new Version(1, 0, 0), (WebData data) => new TaskStandardOutputFlowsMethodExecutor(data))
			{
				ParametersDescriptor = TaskStandardOutputFlowsMethodExecutor.ParametersDescriptor,
				ResultDescriptor = TaskStandardOutputFlowsMethodExecutor.ResultDescriptor
			},
			new PublicServiceMethod(WorkflowPublicService.UID, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1542190822 ^ -1542009528), TasksInfoMethodExecutor.Description, new Version(1, 0, 0), (WebData data) => new TasksInfoMethodExecutor(data))
			{
				ParametersDescriptor = TasksInfoMethodExecutor.ParametersDescriptor,
				ResultDescriptor = TasksInfoMethodExecutor.ResultDescriptor
			},
			new PublicServiceMethod(WorkflowPublicService.UID, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-135674354 ^ -135593370), ExecuteUserTaskMethodExecutor.Description, new Version(1, 0, 1), (WebData data) => new ExecuteUserTaskMethodExecutor(data))
			{
				ParametersDescriptor = ExecuteUserTaskMethodExecutor.ParametersDescriptor,
				ResultDescriptor = ExecuteUserTaskMethodExecutor.ResultDescriptor
			},
			new PublicServiceMethod(WorkflowPublicService.UID, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x70EBB9F3 ^ 0x70E97D79), ExecuteUserTaskAsyncMethodExecutor.Description, new Version(1, 0, 1), (WebData data) => new ExecuteUserTaskAsyncMethodExecutor(data))
			{
				ParametersDescriptor = ExecuteUserTaskAsyncMethodExecutor.ParametersDescriptor,
				ResultDescriptor = ExecuteUserTaskAsyncMethodExecutor.ResultDescriptor
			},
			new PublicServiceMethod(WorkflowPublicService.UID, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6A69C5CD ^ 0x6A6B017B), ExecuteUserTaskStatusMethodExecutor.Description, new Version(1, 0, 1), (WebData data) => new ExecuteUserTaskStatusMethodExecutor(data))
			{
				ParametersDescriptor = ExecuteUserTaskStatusMethodExecutor.ParametersDescriptor,
				ResultDescriptor = ExecuteUserTaskStatusMethodExecutor.ResultDescriptor
			},
			new PublicServiceMethod(WorkflowPublicService.UID, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1430645277 ^ -1430728441), StartableProcessesMethodExecutor.Description, new Version(1, 0, 0), (WebData data) => new StartableProcessesMethodExecutor(data))
			{
				ParametersDescriptor = StartableProcessesMethodExecutor.ParametersDescriptor,
				ResultDescriptor = StartableProcessesMethodExecutor.ResultDescriptor
			},
			new PublicServiceMethod(WorkflowPublicService.UID, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-45832783 ^ -45719363), StartProcessFormMethodExecutor.Description, new Version(1, 0, 0), (WebData data) => new StartProcessFormMethodExecutor(data))
			{
				ParametersDescriptor = StartProcessFormMethodExecutor.ParametersDescriptor,
				ResultDescriptor = StartProcessFormMethodExecutor.ResultDescriptor
			},
			new PublicServiceMethod(WorkflowPublicService.UID, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2269BD32 ^ 0x22699B18), StartProcessMethodExecutor.Description, new Version(1, 0, 0), (WebData data) => new StartProcessMethodExecutor(data))
			{
				ParametersDescriptor = StartProcessMethodExecutor.ParametersDescriptor,
				ResultDescriptor = StartProcessMethodExecutor.ResultDescriptor
			},
			new PublicServiceMethod(WorkflowPublicService.UID, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-45832783 ^ -45719423), StartProcessAsyncMethodExecutor.Description, new Version(1, 0, 0), (WebData data) => new StartProcessAsyncMethodExecutor(data))
			{
				ParametersDescriptor = StartProcessAsyncMethodExecutor.ParametersDescriptor,
				ResultDescriptor = StartProcessAsyncMethodExecutor.ResultDescriptor
			},
			new PublicServiceMethod(WorkflowPublicService.UID, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x246EEF98 ^ 0x246C2ACE), WorkflowInstanceContextMethodExecutor.Description, new Version(1, 0, 0), (WebData data) => new WorkflowInstanceContextMethodExecutor(data))
			{
				ParametersDescriptor = WorkflowInstanceContextMethodExecutor.ParametersDescriptor,
				ResultDescriptor = WorkflowInstanceContextMethodExecutor.ResultDescriptor
			}
		};
	}

	public WorkflowPublicServiceMethodsProvider()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_938c6be4ea2248868d7ed5d0e3346006 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool b1HdkdZnkU8KnTUaHhVR()
	{
		return snW7HkZnML3LhWVqb1gJ == null;
	}

	internal static WorkflowPublicServiceMethodsProvider rhysCGZnUG0UFZGud0Hr()
	{
		return snW7HkZnML3LhWVqb1gJ;
	}
}
