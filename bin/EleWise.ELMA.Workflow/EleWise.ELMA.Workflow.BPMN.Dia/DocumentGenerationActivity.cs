using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Templates;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Connectors;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Events;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Plugins;
using EleWise.ELMA.Workflow.BPMN.Diagrams.ExtensionPoints;
using EleWise.ELMA.Workflow.Diagrams.Activities;
using EleWise.ELMA.Workflow.Models;
using EleWise.TemplateGenerator;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Activities.Plugins;

public class DocumentGenerationActivity : BPMNActivity<DocumentGenerationElement>, IActivityNotificationRecipientsByExecutors, IActivityNotificationRecipients
{
	[Component]
	private class Info : IWorkflowActivityInfo
	{
		internal static object Ea3f4BvL9egxaM1STKsf;

		public Type ActivityType => PbnpVAvLRcqVCQVQNix7(typeof(DocumentGenerationActivity).TypeHandle);

		public Type DiagramElementType => PbnpVAvLRcqVCQVQNix7(typeof(DocumentGenerationElement).TypeHandle);

		public Info()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			LsoCMAvL6ojjV05BNbFT();
			base._002Ector();
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

		internal static Type PbnpVAvLRcqVCQVQNix7(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static void LsoCMAvL6ojjV05BNbFT()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}

		internal static bool GwJE43vLW1hbfuIjkFhp()
		{
			return Ea3f4BvL9egxaM1STKsf == null;
		}

		internal static Info fvqj0cvLji3qTAdtM9gw()
		{
			return (Info)Ea3f4BvL9egxaM1STKsf;
		}
	}

	private static DocumentGenerationActivity BMaMpFZcHBievLRqk2Dr;

	protected override void Execute(NativeActivityContext context)
	{
		//Discarded unreachable code: IL_0089, IL_0098, IL_0123, IL_0156, IL_0230, IL_023f, IL_024f, IL_025e, IL_0273, IL_02ad, IL_02c0, IL_02cf
		int num = 1;
		int num2 = num;
		IWorkflowInstance instance = default(IWorkflowInstance);
		List<DocumentGenerationTemplateInfo>.Enumerator enumerator = default(List<DocumentGenerationTemplateInfo>.Enumerator);
		DocumentGenerationTemplateInfo current = default(DocumentGenerationTemplateInfo);
		string message = default(string);
		FlowConnectorElement flowConnectorElement = default(FlowConnectorElement);
		while (true)
		{
			switch (num2)
			{
			default:
				instance = GetInstance(context);
				num2 = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_448e6815cb30438893079dcbb906fd65 == 0)
				{
					num2 = 4;
				}
				break;
			case 4:
				enumerator = base.Element.Templates.GetEnumerator();
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 == 0)
							{
								num3 = 1;
							}
							goto IL_00a7;
						}
						goto IL_00e7;
						IL_00e7:
						current = enumerator.Current;
						int num4 = 3;
						num3 = num4;
						goto IL_00a7;
						IL_00a7:
						switch (num3)
						{
						case 2:
							break;
						default:
							goto IL_00e7;
						case 3:
							try
							{
								ExecuteTemplate(current, instance);
								int num5 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe4a54387d744988feba4889229faf1 == 0)
								{
									num5 = 0;
								}
								switch (num5)
								{
								case 0:
									break;
								}
							}
							catch (Exception ex)
							{
								int num6 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_639c11c7bb65456db9f29c9c42f28bf7 == 0)
								{
									num6 = 0;
								}
								while (true)
								{
									switch (num6)
									{
									default:
										message = (string)JyG49RZc6u2hIHuyZnc5(JOVm1gZc9rvEKRJr0ZsD(-452127399 ^ -451957187), new object[4]
										{
											Het9ZiZcWU6nQPjsfVLn(current),
											hFBqLqZcjHfUW1OdjVsX(current),
											ThLkb9ZcRJt97vk2rPsc(current),
											current.DocumentId
										});
										num6 = 6;
										break;
									case 5:
										ContinueOnConnector(context, I4J80VZc36es9lymhreH(flowConnectorElement));
										num6 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e == 0)
										{
											num6 = 1;
										}
										break;
									case 3:
										yXCBibZcqpw6gTNPeama(instance);
										num6 = 5;
										break;
									case 6:
										if (!ExceptionActivity(context, flowConnectorElement, ex, instance, message))
										{
											num6 = 4;
											break;
										}
										goto case 3;
									case 1:
										return;
									case 2:
									case 4:
										throw new Exception(message, ex);
									}
								}
							}
							break;
						case 1:
							goto end_IL_00c1;
						}
						continue;
						end_IL_00c1:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num7 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b876fa7b083748c8abf8c4b192a11078 == 0)
					{
						num7 = 0;
					}
					switch (num7)
					{
					case 0:
						break;
					}
				}
				goto case 3;
			case 5:
				return;
			case 3:
				ContinueOnDefaultConnector(context);
				num2 = 5;
				break;
			case 1:
				flowConnectorElement = base.Element.ExceptionOutputFlows.FirstOrDefault((FlowConnectorElement e) => _003C_003Ec.FcqQQKvLpubVwEPTKlUE(e) == EventTrigger.ErrorCatch);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2f119e188994b55be2499c193b880fb == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void ExecuteTemplate(DocumentGenerationTemplateInfo template, IWorkflowInstance instance)
	{
		//Discarded unreachable code: IL_0056, IL_0073, IL_008e, IL_009d, IL_00ad, IL_00bc
		int num = 4;
		int num2 = num;
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = default(_003C_003Ec__DisplayClass2_0);
		Guid empty = default(Guid);
		Guid? resultPropertyUid = default(Guid?);
		BinaryFile binaryFile = default(BinaryFile);
		WorkflowInstanceContext context = default(WorkflowInstanceContext);
		while (true)
		{
			switch (num2)
			{
			case 3:
				_003C_003Ec__DisplayClass2_.template = template;
				num2 = 5;
				continue;
			case 12:
				empty = Guid.Empty;
				num2 = 11;
				continue;
			case 6:
				return;
			case 8:
				if (!resultPropertyUid.HasValue)
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe7a0ffe67e4fea8e329ae6574ed2ca == 0)
					{
						num2 = 2;
					}
					continue;
				}
				if (!CnehllZcGtk7451HsPYi(resultPropertyUid.GetValueOrDefault(), empty))
				{
					break;
				}
				goto default;
			case 4:
				_003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
				num2 = 3;
				continue;
			case 10:
				p5hBBtZcADPv0MX0bIZj(Locator.GetServiceNotNull<IFileManager>(), binaryFile);
				num2 = 9;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3bb28bf622874b4689f9265e58d14823 != 0)
				{
					num2 = 8;
				}
				continue;
			case 9:
				resultPropertyUid = _003C_003Ec__DisplayClass2_.template.ResultPropertyUid;
				num2 = 12;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_978f838cc41a4debb9700ede4b63f820 == 0)
				{
					num2 = 8;
				}
				continue;
			case 11:
				if (resultPropertyUid.HasValue)
				{
					num2 = 8;
					continue;
				}
				goto default;
			case 7:
				return;
			default:
			{
				WorkflowInstanceContext workflowInstanceContext = context;
				resultPropertyUid = _003C_003Ec__DisplayClass2_.template.ResultPropertyUid;
				workflowInstanceContext.SetPropertyValue(resultPropertyUid.Value, binaryFile);
				num2 = 7;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_85ba8d91af394836ac86666c40b1e150 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			case 5:
			{
				object obj = IeBSbVZcT4W7BPIET5bs(instance, _003C_003Ec__DisplayClass2_.template);
				string text = (string)dcQqC0ZcpyLyAgO2yHri(rOEKc6ZcQu43pHjBLJQy(obj));
				pG0ff3ZcCs4ULasmMPMD(obj, text);
				DocumentGeneratorBase documentGeneratorBase = (DocumentGeneratorBase)srZaguZcM5rb6t8tk5gq(Locator.GetServiceNotNull<DocumentGeneratorManager>(), text, null);
				context = instance.Context;
				FrrqNrZckI1Fp9IujCVU(documentGeneratorBase, context);
				if (documentGeneratorBase.LastExceptions != null)
				{
					documentGeneratorBase.LastExceptions.Each(_003C_003Ec__DisplayClass2_._003CExecuteTemplate_003Eb__0);
				}
				binaryFile = (BinaryFile)t661xMZcVHsuiddRmYNL(vr1llMZcUbG1104oWvCm(BinaryFile.CreateFrom((BinaryFile)obj), text, true));
				num2 = 10;
				continue;
			}
			case 2:
				break;
			}
			num2 = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 == 0)
			{
				num2 = 6;
			}
		}
	}

	private static BinaryFile GetFromDocumentByObject(object obj)
	{
		//Discarded unreachable code: IL_0077, IL_0086
		int num = 1;
		IDocument document = default(IDocument);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (document != null)
					{
						goto end_IL_0012;
					}
					goto case 2;
				case 1:
					document = obj as IDocument;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					return null;
				case 3:
					return (BinaryFile)e6uDmSZc7FM3fKe2BTsA(document.Id);
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 3;
		}
	}

	private static BinaryFile GetFromDocument(long documentId)
	{
		//Discarded unreachable code: IL_0093, IL_00a2, IL_00b2, IL_00c1
		int num = 3;
		int num2 = num;
		BinaryFile binaryFile = default(BinaryFile);
		while (true)
		{
			switch (num2)
			{
			default:
				return binaryFile;
			case 4:
				return (BinaryFile)B8RrkxZcF0BuE47YZG3h(Locator.GetServiceNotNull<ITemplateFileManager>(), o23FG9ZcoQwQj12kxBM6(binaryFile));
			case 1:
				return null;
			case 5:
				if (!string.IsNullOrEmpty((string)o23FG9ZcoQwQj12kxBM6(binaryFile)))
				{
					num2 = 4;
					break;
				}
				goto default;
			case 3:
				binaryFile = (BinaryFile)FVk6hdZc2fqtYTVaOAmC(Locator.GetServiceNotNull<IDocumentFileManager>(), documentId);
				num2 = 2;
				break;
			case 2:
				if (binaryFile != null)
				{
					num2 = 5;
					break;
				}
				goto case 1;
			}
		}
	}

	private static BinaryFile GetFile(object instance, object template)
	{
		//Discarded unreachable code: IL_01eb, IL_01ff, IL_021e, IL_022d, IL_0253, IL_02cf, IL_03ad, IL_03bc, IL_03cc, IL_0407, IL_0416, IL_0497, IL_04b8, IL_04ee
		int num = 37;
		long? documentId = default(long?);
		BinaryFile binaryFile = default(BinaryFile);
		GenerationTemplateType generationTemplateType = default(GenerationTemplateType);
		object obj = default(object);
		long num4 = default(long);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3;
				switch (num2)
				{
				case 8:
					documentId = ((DocumentGenerationTemplateInfo)template).DocumentId;
					num2 = 32;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b876fa7b083748c8abf8c4b192a11078 == 0)
					{
						num2 = 7;
					}
					continue;
				case 22:
					UBt2DiZchQxB5gPq0xUZ(binaryFile, k2VoivZc1roX21Ttarh5(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1657582555 ^ -1657546383), Het9ZiZcWU6nQPjsfVLn(template), rOEKc6ZcQu43pHjBLJQy(binaryFile)));
					num2 = 30;
					continue;
				case 20:
					switch (generationTemplateType)
					{
					case GenerationTemplateType.Document:
						goto IL_0318;
					case GenerationTemplateType.ContextVar:
						goto IL_0341;
					case GenerationTemplateType.File:
						goto IL_03d6;
					}
					num2 = 19;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_abfb511163674a3eae959fd60da8f319 != 0)
					{
						num2 = 19;
					}
					continue;
				case 18:
					binaryFile = GetFromDocumentByObject(obj);
					num = 33;
					break;
				case 29:
					if (!documentId.HasValue)
					{
						num2 = 25;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58fb165cafed422d973d4a7156526541 != 0)
						{
							num2 = 26;
						}
						continue;
					}
					goto case 21;
				case 7:
					if (binaryFile != null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 18;
				case 23:
					binaryFile = GetFromDocumentByObject(obj);
					num2 = 2;
					continue;
				case 36:
					generationTemplateType = ((DocumentGenerationTemplateInfo)template).TemplateType;
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 == 0)
					{
						num2 = 25;
					}
					continue;
				case 3:
					if (binaryFile != null)
					{
						num2 = 15;
						continue;
					}
					goto case 23;
				case 21:
					num3 = 2;
					goto IL_050e;
				case 25:
					if (generationTemplateType == GenerationTemplateType.None)
					{
						num = 5;
						break;
					}
					goto case 20;
				case 16:
					if (documentId.HasValue)
					{
						num2 = 8;
						continue;
					}
					goto default;
				case 6:
					num4 = nXUNmPZcxO0AAyGrhEDU(obj);
					num = 31;
					break;
				case 32:
					binaryFile = GetFromDocument(documentId.Value);
					num2 = 27;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7de614af35034bd0a6867d08a2ee4a84 != 0)
					{
						num2 = 3;
					}
					continue;
				case 10:
					if (obj != null)
					{
						num2 = 24;
						continue;
					}
					goto default;
				case 37:
					binaryFile = null;
					num2 = 36;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 == 0)
					{
						num2 = 30;
					}
					continue;
				case 15:
					binaryFile = (BinaryFile)t661xMZcVHsuiddRmYNL(((BinaryFileBuilder)T5taojZcNBOsSpD5293Y(BinaryFile.CreateFrom(binaryFile).Uid(Guid.NewGuid()), m4gbaYZceB2X9ED7aDDr())).Content(binaryFile.GetContent(GetContentOptions.NonSeekable), autoCloseStream: true, (string)null));
					num2 = 7;
					continue;
				case 35:
					goto IL_0318;
				case 24:
					binaryFile = obj as BinaryFile;
					num2 = 3;
					continue;
				case 11:
					goto IL_0341;
				case 4:
					throw new Exception((string)NBRoteZca8fUAlfV2S9B(JOVm1gZc9rvEKRJr0ZsD(-642713667 ^ -642626755)));
				case 17:
					if (AseGbeZcSFBZuxU95Xcy(Het9ZiZcWU6nQPjsfVLn(template)))
					{
						num2 = 28;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3ab79470996d472f815915b21f45aac1 == 0)
						{
							num2 = 26;
						}
						continue;
					}
					goto case 22;
				case 28:
				case 30:
					return binaryFile;
				case 14:
					goto IL_03d6;
				case 38:
					binaryFile = (BinaryFile)e6uDmSZc7FM3fKe2BTsA(num4);
					num2 = 9;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7ed81ca3cf804abbade4684f28f485d1 != 0)
					{
						num2 = 5;
					}
					continue;
				case 34:
					throw new Exception((string)NBRoteZca8fUAlfV2S9B(JOVm1gZc9rvEKRJr0ZsD(0x5DB28AD2 ^ 0x5DB036D4)));
				case 13:
					obj = t7wggkZcrmYnLDQJ2B9K(((IWorkflowInstance)instance).Context, laJpB8ZcidtC3CEUVMeC(template));
					num = 10;
					break;
				case 33:
					if (binaryFile != null)
					{
						num2 = 12;
						continue;
					}
					goto case 6;
				case 5:
					documentId = ((DocumentGenerationTemplateInfo)template).DocumentId;
					num2 = 29;
					continue;
				case 31:
					if (num4 > 0)
					{
						num2 = 38;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a9be7e056b4e4b6e863b634c418144f1 == 0)
						{
							num2 = 34;
						}
						continue;
					}
					goto default;
				default:
					if (binaryFile != null)
					{
						num2 = 17;
						continue;
					}
					goto case 4;
				case 26:
					{
						num3 = 1;
						goto IL_050e;
					}
					IL_0341:
					if (!muxUB0ZcIvbD6VLZgRX8(laJpB8ZcidtC3CEUVMeC(template), Guid.Empty))
					{
						num2 = 13;
						continue;
					}
					goto case 34;
					IL_0318:
					documentId = ((DocumentGenerationTemplateInfo)template).DocumentId;
					num = 16;
					break;
					IL_050e:
					generationTemplateType = (GenerationTemplateType)num3;
					num2 = 20;
					continue;
					IL_03d6:
					binaryFile = (BinaryFile)B8RrkxZcF0BuE47YZG3h(Locator.GetServiceNotNull<ITemplateFileManager>(), ThLkb9ZcRJt97vk2rPsc(template));
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 != 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
		}
	}

	private void MessageException(NativeActivityContext context, IWorkflowInstance instance, FlowConnectorElement element, string subject, string description = "")
	{
		int num = 1;
		int num2 = num;
		IUser[] swimlaneExecutors = default(IUser[]);
		IEnumerable<IUser> recipientsForNotification = default(IEnumerable<IUser>);
		while (true)
		{
			switch (num2)
			{
			case 1:
			{
				swimlaneExecutors = GetSwimlaneExecutors(context, out var _);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 == 0)
				{
					num2 = 0;
				}
				break;
			}
			case 2:
			{
				IEntityActionHandler serviceNotNull = Locator.GetServiceNotNull<IEntityActionHandler>();
				EntityActionEventArgs entityActionEventArgs = new EntityActionEventArgs(null, instance, (string)JOVm1gZc9rvEKRJr0ZsD(0x75BAD659 ^ 0x75BBB223));
				entityActionEventArgs.ExtendedProperties[(string)JOVm1gZc9rvEKRJr0ZsD(0x350C0E8 ^ 0x350866E)] = instance.Id;
				entityActionEventArgs.ExtendedProperties[(string)JOVm1gZc9rvEKRJr0ZsD(0x2F44D93A ^ 0x2F449FB4)] = mYNLZ8ZcETHJp2KkvLTN(instance);
				entityActionEventArgs.ExtendedProperties[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xDF4D1F8 ^ 0xDF5B5F6)] = subject;
				entityActionEventArgs.ExtendedProperties[(string)JOVm1gZc9rvEKRJr0ZsD(0x4FD00585 ^ 0x4FD05BBD)] = IGBsrnZcwpi60xP7UaQX(instance);
				entityActionEventArgs.ExtendedProperties[(string)JOVm1gZc9rvEKRJr0ZsD(-432000546 ^ -431980482)] = description;
				entityActionEventArgs.ExtendedProperties[(string)JOVm1gZc9rvEKRJr0ZsD(-961162596 ^ -961235202)] = recipientsForNotification;
				serviceNotNull.ActionExecuted(entityActionEventArgs);
				num2 = 3;
				break;
			}
			default:
				recipientsForNotification = Locator.GetServiceNotNull<IActivityEscalationNotifyService>().GetRecipientsForNotification(new GetRecipientsParameters(this, instance, element, swimlaneExecutors));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_545887e65739480a965b7ddfab7d0632 == 0)
				{
					num2 = 2;
				}
				break;
			case 3:
				return;
			}
		}
	}

	private bool ExceptionActivity(NativeActivityContext context, FlowConnectorElement errorConnector, Exception e, IWorkflowInstance instance, string message)
	{
		//Discarded unreachable code: IL_0081, IL_00b8, IL_00f6, IL_01da, IL_01e9, IL_01f8, IL_021a
		int num = 1;
		Exception ex2 = default(Exception);
		Exception ex = default(Exception);
		bool flag = default(bool);
		WorkflowInstanceContext context2 = default(WorkflowInstanceContext);
		ExceptionData exceptionData = default(ExceptionData);
		ScriptExecuteException ex3 = default(ScriptExecuteException);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 10:
				case 20:
					ex2 = (Exception)aHBcXlZczTdeDxaB4ALE(ex);
					num2 = 9;
					continue;
				case 2:
				case 6:
				case 8:
					if (flag)
					{
						num = 10;
						break;
					}
					goto case 14;
				case 16:
				case 19:
					e5eNMPZPvNjufIqJY1ds(context2, E1k1HDZPZjWnlAwgF0Yk(errorConnector), new ExceptionData(0, (string)NnimwHZPYeZunQq4ovlL(message, csYL4IZPOEIHbmwrDFyC(e)), e));
					num = 21;
					break;
				case 1:
					if (errorConnector != null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f508947b0d94af1961e5aa17a8a2044 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					return false;
				case 23:
					e5eNMPZPvNjufIqJY1ds(context2, E1k1HDZPZjWnlAwgF0Yk(errorConnector), exceptionData);
					num2 = 7;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe4a54387d744988feba4889229faf1 != 0)
					{
						num2 = 7;
					}
					continue;
				case 22:
					ex = e;
					num2 = 4;
					continue;
				case 17:
					ex = ex2;
					num = 6;
					break;
				case 3:
				case 15:
					flag = false;
					num2 = 8;
					continue;
				case 12:
					if (ex3 == null)
					{
						num = 16;
						break;
					}
					goto case 13;
				default:
					context2 = instance.Context;
					num = 11;
					break;
				case 18:
					return true;
				case 5:
				case 7:
				case 21:
					MessageException(context, instance, errorConnector, (string)aivvVQZP8bYFSRxTqK4o(base.Element), (string)NnimwHZPYeZunQq4ovlL(message, csYL4IZPOEIHbmwrDFyC(e)));
					num2 = 18;
					continue;
				case 14:
					ex3 = ex as ScriptExecuteException;
					num2 = 12;
					continue;
				case 9:
					if (ex2 == null)
					{
						num2 = 15;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d87d9a74c9e14f96a288cc3620965fe0 != 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 17;
				case 11:
					if (xjunQoZc4PT91UtEBFHI(context2, errorConnector.ContextExceptionVar) == null)
					{
						num2 = 5;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 22;
				case 13:
					exceptionData = new ExceptionData(FdZe4QZPKPY95rYjAxDq(ex3), (string)csYL4IZPOEIHbmwrDFyC(ex3), ex3);
					num2 = 14;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e == 0)
					{
						num2 = 23;
					}
					continue;
				case 4:
					flag = true;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c != 0)
					{
						num2 = 2;
					}
					continue;
				}
				break;
			}
		}
	}

	public DocumentGenerationActivity()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		K1sZsHZPsSDf4GTbZfVG();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1de08766357542bdb81146373079f817 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object JOVm1gZc9rvEKRJr0ZsD(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object Het9ZiZcWU6nQPjsfVLn(object P_0)
	{
		return ((DocumentGenerationTemplateInfo)P_0).Name;
	}

	internal static object hFBqLqZcjHfUW1OdjVsX(object P_0)
	{
		return ((DocumentGenerationTemplateInfo)P_0).FileName;
	}

	internal static object ThLkb9ZcRJt97vk2rPsc(object P_0)
	{
		return ((DocumentGenerationTemplateInfo)P_0).TemplateFileId;
	}

	internal static object JyG49RZc6u2hIHuyZnc5(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static void yXCBibZcqpw6gTNPeama(object P_0)
	{
		((IEntity)P_0).Save();
	}

	internal static Guid I4J80VZc36es9lymhreH(object P_0)
	{
		return ((Element)P_0).Uid;
	}

	internal static bool pGF5j2ZcL7vDLRSFnccL()
	{
		return BMaMpFZcHBievLRqk2Dr == null;
	}

	internal static DocumentGenerationActivity ssiGUmZcfn5HBR60n7rs()
	{
		return BMaMpFZcHBievLRqk2Dr;
	}

	internal static object IeBSbVZcT4W7BPIET5bs(object P_0, object P_1)
	{
		return GetFile(P_0, P_1);
	}

	internal static object rOEKc6ZcQu43pHjBLJQy(object P_0)
	{
		return ((BinaryFile)P_0).Extension;
	}

	internal static object dcQqC0ZcpyLyAgO2yHri(object P_0)
	{
		return IOExtensions.GetTempFileName((string)P_0);
	}

	internal static void pG0ff3ZcCs4ULasmMPMD(object P_0, object P_1)
	{
		((BinaryFile)P_0).SaveToLocalPath((string)P_1);
	}

	internal static object srZaguZcM5rb6t8tk5gq(object P_0, object P_1, object P_2)
	{
		return ((DocumentGeneratorManager)P_0).Create((string)P_1, (IGeneratorProvider)P_2);
	}

	internal static void FrrqNrZckI1Fp9IujCVU(object P_0, object P_1)
	{
		((DocumentGeneratorBase)P_0).Generate(P_1);
	}

	internal static object vr1llMZcUbG1104oWvCm(object P_0, object P_1, bool P_2)
	{
		return ((BinaryFileBuilder)P_0).Content((string)P_1, P_2);
	}

	internal static object t661xMZcVHsuiddRmYNL(object P_0)
	{
		return ((BinaryFileBuilder)P_0).Build();
	}

	internal static object p5hBBtZcADPv0MX0bIZj(object P_0, object P_1)
	{
		return ((IFileManager)P_0).SaveFile((BinaryFile)P_1);
	}

	internal static bool CnehllZcGtk7451HsPYi(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static object e6uDmSZc7FM3fKe2BTsA(long documentId)
	{
		return GetFromDocument(documentId);
	}

	internal static object FVk6hdZc2fqtYTVaOAmC(object P_0, long P_1)
	{
		return ((IDocumentFileManager)P_0).GetFileByDocumentId(P_1);
	}

	internal static object o23FG9ZcoQwQj12kxBM6(object P_0)
	{
		return ((BinaryFile)P_0).Id;
	}

	internal static object B8RrkxZcF0BuE47YZG3h(object P_0, object P_1)
	{
		return ((ITemplateFileManager)P_0).CreateFromTemplate((string)P_1);
	}

	internal static Guid laJpB8ZcidtC3CEUVMeC(object P_0)
	{
		return ((DocumentGenerationTemplateInfo)P_0).ContextVarUid;
	}

	internal static bool muxUB0ZcIvbD6VLZgRX8(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static object NBRoteZca8fUAlfV2S9B(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object t7wggkZcrmYnLDQJ2B9K(object P_0, Guid P_1)
	{
		return ((Entity<long>)P_0).GetPropertyValue(P_1);
	}

	internal static DateTime m4gbaYZceB2X9ED7aDDr()
	{
		return DateTime.Now;
	}

	internal static object T5taojZcNBOsSpD5293Y(object P_0, DateTime P_1)
	{
		return ((BinaryFileBuilder)P_0).Created(P_1);
	}

	internal static long nXUNmPZcxO0AAyGrhEDU(object P_0)
	{
		return Convert.ToInt64(P_0);
	}

	internal static bool AseGbeZcSFBZuxU95Xcy(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object k2VoivZc1roX21Ttarh5(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static void UBt2DiZchQxB5gPq0xUZ(object P_0, object P_1)
	{
		((BinaryFile)P_0).Name = (string)P_1;
	}

	internal static object mYNLZ8ZcETHJp2KkvLTN(object P_0)
	{
		return ((IWorkflowInstance)P_0).Name;
	}

	internal static object IGBsrnZcwpi60xP7UaQX(object P_0)
	{
		return ((IWorkflowInstance)P_0).Process;
	}

	internal static object xjunQoZc4PT91UtEBFHI(object P_0, Guid P_1)
	{
		return ((Entity<long>)P_0).GetPropertySettings(P_1);
	}

	internal static object aHBcXlZczTdeDxaB4ALE(object P_0)
	{
		return ((Exception)P_0).InnerException;
	}

	internal static int FdZe4QZPKPY95rYjAxDq(object P_0)
	{
		return ((ScriptExecuteException)P_0).CodeException;
	}

	internal static object csYL4IZPOEIHbmwrDFyC(object P_0)
	{
		return ((Exception)P_0).Message;
	}

	internal static Guid E1k1HDZPZjWnlAwgF0Yk(object P_0)
	{
		return ((FlowConnectorElement)P_0).ContextExceptionVar;
	}

	internal static void e5eNMPZPvNjufIqJY1ds(object P_0, Guid P_1, object P_2)
	{
		((Entity<long>)P_0).SetPropertyValue(P_1, P_2);
	}

	internal static object NnimwHZPYeZunQq4ovlL(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object aivvVQZP8bYFSRxTqK4o(object P_0)
	{
		return ((Element)P_0).Name;
	}

	internal static void K1sZsHZPsSDf4GTbZfVG()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
