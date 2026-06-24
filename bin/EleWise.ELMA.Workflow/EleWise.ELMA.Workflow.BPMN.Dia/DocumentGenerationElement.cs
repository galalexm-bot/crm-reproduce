using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Diagrams.Toolbox;
using EleWise.ELMA.Documents.DTO.Managers;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Files.DTO.Managers;
using EleWise.ELMA.Files.DTO.Models;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Services;
using EleWise.ELMA.Templates;
using EleWise.ELMA.Templates.TemplateGenerator;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Events;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Swimlanes;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Tasks;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Plugins;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Toolbox;
using EleWise.ELMA.Workflow.Diagrams;
using EleWise.ELMA.Workflow.Diagrams.Elements;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Properties;
using EleWise.ELMA.Workflow.Validation;
using EleWise.TemplateGenerator;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Plugins;

[Serializable]
[HintShape(typeof(DocumentGenerationHintShape))]
[Shape(typeof(DocumentGenerationShape))]
[WebDiagrammerShape(typeof(WebDiagrammerCyanRectangleElementShape))]
public class DocumentGenerationElement : BPMNFlowElement, IExceptionFlowSupported, IReplaceContextVar, IHintDrawElement
{
	[Component(Order = 100)]
	public class ToolboxItem : IBPMNToolboxItem, IToolboxItem, IContainingElementIcon
	{
		internal static ToolboxItem UyYPSKvXCwPZKGS7qrWZ;

		public string Name => (string)BnjRgKvXUHJW2HD7jo0x(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2125897096 ^ -2125727924));

		public Guid GroupUid => PluginGroups.DocumentGeneration.UID;

		public Image Image => Resources.docGenerate;

		public Type ElementType => typeof(DocumentGenerationElement);

		public string ElementIcon => (string)kyOUfLvXVN8OhkUknrkn(-22348816 ^ -22534404);

		public ToolboxItem()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			oP7kaVvXAHuorKGLDY7s();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6fe3beca34a9422e873cd6ef331760ae == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static object BnjRgKvXUHJW2HD7jo0x(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static bool kPFYmTvXM0AntbXGPJuZ()
		{
			return UyYPSKvXCwPZKGS7qrWZ == null;
		}

		internal static ToolboxItem nWve74vXkoMNHUVXOMq7()
		{
			return UyYPSKvXCwPZKGS7qrWZ;
		}

		internal static object kyOUfLvXVN8OhkUknrkn(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static void oP7kaVvXAHuorKGLDY7s()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}
	}

	internal static DocumentGenerationElement Q3MHPqZswv7o8o60GUge;

	public override string DefaultName => (string)FyDXt5ZJKU1yAlnOZcU0(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1212129906 ^ 0x483D3746));

	public List<DocumentGenerationTemplateInfo> Templates { get; set; }

	public virtual EventTrigger[] SupportedTriggers => new EventTrigger[1] { EventTrigger.ErrorCatch };

	public override string ChapterName => (string)FyDXt5ZJKU1yAlnOZcU0(GaegfuZJYeIdLhWEQP0Z(-1516552726 ^ -1516655900));

	public DocumentGenerationElement()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_639c11c7bb65456db9f29c9c42f28bf7 != 0)
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
				Templates = new List<DocumentGenerationTemplateInfo>();
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public override void Validate(WorkflowProcessValidator validator)
	{
		//Discarded unreachable code: IL_0123, IL_013e, IL_016e, IL_017d, IL_018d, IL_019c, IL_01ad, IL_0232, IL_0241, IL_02f9, IL_0303, IL_0312, IL_03d7, IL_03e6, IL_0419, IL_04bf, IL_057d, IL_059c, IL_05ab, IL_05d8, IL_06f2, IL_0705, IL_0714
		int num = 9;
		int num2 = num;
		DocumentGeneratorManager serviceNotNull = default(DocumentGeneratorManager);
		ITemplateFileDTOManager serviceNotNull2 = default(ITemplateFileDTOManager);
		List<DocumentGenerationTemplateInfo>.Enumerator enumerator = default(List<DocumentGenerationTemplateInfo>.Enumerator);
		IDocumentDTOManager serviceNotNull3 = default(IDocumentDTOManager);
		Guid? resultPropertyUid = default(Guid?);
		DocumentGenerationTemplateInfo current = default(DocumentGenerationTemplateInfo);
		BinaryFileDTO binaryFileDTO = default(BinaryFileDTO);
		GenerationTemplateType generationTemplateType = default(GenerationTemplateType);
		string text2 = default(string);
		Guid propertyUid = default(Guid);
		long? documentId = default(long?);
		MemoryStream memoryStream = default(MemoryStream);
		string errorMessage = default(string);
		string text = default(string);
		ClassMetadataPartsContainer container = default(ClassMetadataPartsContainer);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 5:
				if (Templates.Count != 0)
				{
					num2 = 7;
					continue;
				}
				return;
			case 12:
				return;
			case 8:
				if (Templates == null)
				{
					num2 = 6;
					continue;
				}
				goto case 5;
			case 13:
				serviceNotNull = Locator.GetServiceNotNull<DocumentGeneratorManager>();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_719514a5a8ae47ed84e5a777ead0dc9f != 0)
				{
					num2 = 1;
				}
				continue;
			case 6:
				return;
			case 10:
				return;
			case 7:
				if (wKAidoZJZGISpgAKAgur(ph7EHaZJOgbMZ3y5yY5R(this)))
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_61395ebf330446ac8ce99b55ee3acfa9 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 4;
			case 11:
				serviceNotNull2 = Locator.GetServiceNotNull<ITemplateFileDTOManager>();
				num2 = 13;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae4e393cddc4c98b9896b25c9e18c7d != 0)
				{
					num2 = 6;
				}
				continue;
			case 3:
				enumerator = Templates.GetEnumerator();
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe4a54387d744988feba4889229faf1 == 0)
				{
					num2 = 0;
				}
				continue;
			case 4:
				obj = ph7EHaZJOgbMZ3y5yY5R(this);
				break;
			case 9:
				base.Validate(validator);
				num2 = 8;
				continue;
			case 1:
				serviceNotNull3 = Locator.GetServiceNotNull<IDocumentDTOManager>();
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a23e27b648a042f098a477c26c4beed1 == 0)
				{
					num2 = 3;
				}
				continue;
			case 2:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 24;
							goto IL_01bb;
						}
						goto IL_036c;
						IL_01bb:
						while (true)
						{
							Guid guid;
							int num6;
							switch (num3)
							{
							case 24:
								return;
							case 1:
								resultPropertyUid = current.ResultPropertyUid;
								num3 = 16;
								continue;
							case 19:
								binaryFileDTO = (BinaryFileDTO)J5i5VhZJysCHNRtUmKkA(serviceNotNull2, GCAnDGZJ0O1H0WXeeMDF(current));
								num3 = 20;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3b4403f77a00495e957e5e4a6840e5d3 != 0)
								{
									num3 = 8;
								}
								continue;
							case 23:
								binaryFileDTO = null;
								num3 = 7;
								continue;
							case 14:
							case 21:
								break;
							case 15:
								if (generationTemplateType != GenerationTemplateType.Document)
								{
									num3 = 13;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eef7d2ca1c3c4b74aeb81172ed542639 != 0)
									{
										num3 = 22;
									}
									continue;
								}
								goto case 13;
							case 6:
							case 20:
							case 22:
								if (binaryFileDTO == null)
								{
									num3 = 2;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7ed81ca3cf804abbade4684f28f485d1 == 0)
									{
										num3 = 14;
									}
									continue;
								}
								goto case 25;
							case 3:
								guid = Guid.Empty;
								goto IL_064a;
							case 11:
								if (!wKAidoZJZGISpgAKAgur(text2))
								{
									num3 = 4;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 == 0)
									{
										num3 = 4;
									}
									continue;
								}
								goto case 6;
							case 10:
								resultPropertyUid = current.ResultPropertyUid;
								num6 = 8;
								goto IL_01b7;
							case 17:
								if (generationTemplateType != GenerationTemplateType.File)
								{
									num3 = 15;
									continue;
								}
								goto case 19;
							case 12:
								goto IL_036c;
							case 5:
								h5ByFwZJsICSrVB3gKGL(base.ValidationHelper, validator, propertyUid, zhOFxHZJ8iRPuNTrukrV(GaegfuZJYeIdLhWEQP0Z(0x6A69C5CD ^ 0x6A6B5093), new object[1] { current.Name }), true);
								num6 = 18;
								goto IL_01b7;
							case 13:
								documentId = current.DocumentId;
								num3 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 != 0)
								{
									num3 = 0;
								}
								continue;
							case 4:
								binaryFileDTO = (BinaryFileDTO)J5i5VhZJysCHNRtUmKkA(serviceNotNull2, text2);
								num3 = 6;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a == 0)
								{
									num3 = 6;
								}
								continue;
							case 2:
							{
								IDocumentDTOManager documentDTOManager = serviceNotNull3;
								documentId = current.DocumentId;
								text2 = (string)bQxffKZJmQIcQJW8iMXX(documentDTOManager, documentId.Value);
								num3 = 11;
								continue;
							}
							case 16:
								if (resultPropertyUid.HasValue)
								{
									num3 = 8;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_61395ebf330446ac8ce99b55ee3acfa9 != 0)
									{
										num3 = 10;
									}
									continue;
								}
								goto case 3;
							case 9:
								try
								{
									DocumentGeneratorBase generator = (DocumentGeneratorBase)Mw6OHEZJb1vDwo6KW16T(serviceNotNull, memoryStream, tuMLFpZJtPenYcbee2ZC(binaryFileDTO), null);
									int num4 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_938c6be4ea2248868d7ed5d0e3346006 == 0)
									{
										num4 = 0;
									}
									while (true)
									{
										switch (num4)
										{
										case 1:
											errorMessage = (string)zhOFxHZJ8iRPuNTrukrV(GaegfuZJYeIdLhWEQP0Z(-17847711 ^ -18006979), new object[2]
											{
												text,
												K9fMThZJJuIUl7R9OalW(current)
											});
											num4 = 2;
											continue;
										case 2:
											validator.ValidateTemplate(this, generator, errorMessage, container);
											num4 = 3;
											continue;
										default:
											container = new ClassMetadataPartsContainer(validator.ExtendMetadata);
											num4 = 1;
											if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6b089b0d02ae4d3186c8d2cb8a24d4d3 != 0)
											{
												num4 = 1;
											}
											continue;
										case 3:
											break;
										}
										break;
									}
								}
								finally
								{
									int num5;
									if (memoryStream == null)
									{
										num5 = 2;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f8a84e2cb374827a50ba2cbcf11cf48 != 0)
										{
											num5 = 2;
										}
										goto IL_0581;
									}
									goto IL_05b6;
									IL_05b6:
									kD7kTOZJ5rPR8FyiioHG(memoryStream);
									num5 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 != 0)
									{
										num5 = 0;
									}
									goto IL_0581;
									IL_0581:
									switch (num5)
									{
									case 2:
										goto end_IL_055c;
									case 1:
										goto end_IL_055c;
									}
									goto IL_05b6;
									end_IL_055c:;
								}
								break;
							case 7:
								generationTemplateType = OkXgxqZJl0nrvdPMQK6P(current);
								num3 = 17;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bf623f11574746d6bf3837b66460c576 == 0)
								{
									num3 = 11;
								}
								continue;
							default:
								if (documentId.HasValue)
								{
									num3 = 2;
									continue;
								}
								goto case 6;
							case 25:
								memoryStream = new MemoryStream(binaryFileDTO.Content);
								num3 = 3;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 != 0)
								{
									num3 = 9;
								}
								continue;
							case 8:
								guid = resultPropertyUid.Value;
								goto IL_064a;
							case 18:
								{
									base.ValidationHelper.ValidateProperty(validator, propertyUid, (IPropertyMetadata p) => _003C_003Ec.AFG9IVvXiMGZZ4TQ8J3U(_003C_003Ec.XJriGFvXFWc5FuhKuWDC(p), BinaryFileDescriptor.UID), (string)zhOFxHZJ8iRPuNTrukrV(GaegfuZJYeIdLhWEQP0Z(-961162596 ^ -961067194), new object[1] { K9fMThZJJuIUl7R9OalW(current) }));
									num3 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e != 0)
									{
										num3 = 23;
									}
									continue;
								}
								IL_064a:
								propertyUid = guid;
								num3 = 5;
								continue;
								IL_01b7:
								num3 = num6;
								continue;
							}
							break;
						}
						continue;
						IL_036c:
						current = enumerator.Current;
						num3 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6b089b0d02ae4d3186c8d2cb8a24d4d3 == 0)
						{
							num3 = 1;
						}
						goto IL_01bb;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num7 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe4a54387d744988feba4889229faf1 != 0)
					{
						num7 = 0;
					}
					switch (num7)
					{
					case 0:
						break;
					}
				}
			default:
				obj = im2JYnZJvRJMRf8f113c(this);
				break;
			}
			text = (string)obj;
			num2 = 11;
		}
	}

	public override string HtmlHeader(ProcessContext context, int orgStructVersion, bool subFolders, WorkflowDiagram diagram, GenerationSettings gs = null)
	{
		int num = 6;
		StringBuilder stringBuilder = default(StringBuilder);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					break;
				default:
					return stringBuilder.ToString();
				case 6:
					stringBuilder = new StringBuilder();
					num2 = 5;
					continue;
				case 2:
					AtP0qAZJPfoyPaNVkbd5(stringBuilder, GaegfuZJYeIdLhWEQP0Z(0x157D5AF4 ^ 0x157F26E8));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d843b0b7f23e489fb6d586d64b0a634a == 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					stringBuilder.Append((string)GaegfuZJYeIdLhWEQP0Z(-539998957 ^ -539869651));
					num2 = 3;
					continue;
				case 5:
					AtP0qAZJPfoyPaNVkbd5(stringBuilder, xAKgIIZJct80aJfVvCYy(new object[5]
					{
						GaegfuZJYeIdLhWEQP0Z(--1756698829 ^ 0x68B763D5),
						((string)eD5xlXZJgI9owSefPGwj(ph7EHaZJOgbMZ3y5yY5R(this)) == "") ? im2JYnZJvRJMRf8f113c(this) : ph7EHaZJOgbMZ3y5yY5R(this),
						GaegfuZJYeIdLhWEQP0Z(0x614274E3 ^ 0x61404E4F),
						DpCYDVZJBfneRCvHSo8J(this),
						GaegfuZJYeIdLhWEQP0Z(0x5BCD23A0 ^ 0x5BCF5884)
					}));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7ed81ca3cf804abbade4684f28f485d1 == 0)
					{
						num2 = 1;
					}
					continue;
				case 3:
					AtP0qAZJPfoyPaNVkbd5(stringBuilder, RkwesYZJnXFFUZFpgBwQ(GJX80JZJdtHqgf9ZAWtQ(GaegfuZJYeIdLhWEQP0Z(-1712492721 ^ -1712384813), v0RwvYZJXt1ik5rGWQ5g(base.Uid.ToString()), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5F534A5C ^ 0x5F5131AC)), subFolders ? "" : k3tfF9ZJDpHgtyn5gtp1(J8Q7beZJuRMluWUQ8p3H(context).ToString(), GaegfuZJYeIdLhWEQP0Z(-539998957 ^ -539855599), "")));
					num2 = 4;
					continue;
				}
				break;
			}
			stringBuilder.Append((string)GaegfuZJYeIdLhWEQP0Z(0x3C1FFB55 ^ 0x3C1E5809));
			num = 2;
		}
	}

	public override string HtmlBody(Element element, List<ProcessContext> contexts, int orgStructVersion, bool subFolders, WorkflowDiagram diagram, IWorkflowProcess wp = null, GenerationSettings gs = null)
	{
		StringBuilder stringBuilder = new StringBuilder();
		SwimlaneElement swimlane = GetSwimlane(diagram);
		if (swimlane != null && !string.IsNullOrEmpty(swimlane.Name))
		{
			string arg = HTMLUtility.InsertHyperLink(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x17F0C5A2 ^ 0x17F2FA4E), swimlane.Uid.ToString().Replace(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-43932417 ^ -43805443), "")), swimlane.Name);
			stringBuilder.Append(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-642713667 ^ -642615693), SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-39189604 ^ -39288220)), arg));
		}
		if (!string.IsNullOrEmpty(element.Description))
		{
			stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-10408775 ^ -10267311) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-539998957 ^ -539853525)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x747FFBE0 ^ 0x747D878A) + element.Description);
		}
		if (Templates.Count > 0)
		{
			stringBuilder.Append(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x628167BE ^ 0x62831B7E), SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6C7F14 ^ 0x6EE9AE))));
			stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1145BED7 ^ 0x114788BF));
			stringBuilder.Append(HTMLUtility.InsertRowToTable(new string[5]
			{
				SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-683713632 ^ -683815596)),
				SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638225214 ^ -1638171524)),
				SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1539486135 ^ -1539318595)),
				SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398691253 ^ -398532607)),
				SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105863102 ^ -105821022))
			}, isBold: true, null));
			IFileManager serviceNotNull = Locator.GetServiceNotNull<IFileManager>();
			foreach (DocumentGenerationTemplateInfo template in Templates)
			{
				string errMessage = null;
				if (string.IsNullOrEmpty(template.TemplateFileId))
				{
					EntityPropertyMetadata property = GetProperty(template, contexts);
					BinaryFile documentFile = GetDocumentFile(template, serviceNotNull, out errMessage);
					if (documentFile != null && gs != null)
					{
						errMessage = TryCopyFile(documentFile, gs);
					}
					AppendFileRow(template, documentFile, stringBuilder, property, SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7381F16B ^ 0x7383816F)), errMessage);
				}
				else
				{
					EntityPropertyMetadata property2 = GetProperty(template, contexts);
					BinaryFile documentFile = GetFile(serviceNotNull, template.TemplateFileId);
					if (documentFile != null && gs != null)
					{
						errMessage = TryCopyFile(documentFile, gs);
					}
					AppendFileRow(template, documentFile, stringBuilder, property2, SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4943E3E4 ^ 0x49417110)), errMessage);
				}
			}
		}
		stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4FD00585 ^ 0x4FD238C1));
		return stringBuilder.ToString();
	}

	public override string HtmlFooter()
	{
		StringBuilder stringBuilder = new StringBuilder();
		AtP0qAZJPfoyPaNVkbd5(stringBuilder, wZ9apkZJLOlkSZ6hsuSh(GaegfuZJYeIdLhWEQP0Z(-949717965 ^ -949614241), UVvO6OZJH0rWeBRxJT0p(this)));
		AtP0qAZJPfoyPaNVkbd5(stringBuilder, GaegfuZJYeIdLhWEQP0Z(-642713667 ^ -642610627));
		return stringBuilder.ToString();
	}

	private EntityPropertyMetadata GetEntityProperty(List<ProcessContext> contexts, Guid fUid)
	{
		_003C_003Ec__DisplayClass16_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass16_0();
		CS_0024_003C_003E8__locals0.fUid = fUid;
		foreach (ProcessContext context in contexts)
		{
			EntityPropertyMetadata entityPropertyMetadata = ((IEnumerable<EntityPropertyMetadata>)context.EntityProperties).FirstOrDefault((EntityPropertyMetadata p) => p.Uid == CS_0024_003C_003E8__locals0.fUid);
			if (entityPropertyMetadata == null)
			{
				foreach (TablePartMetadata item in (IEnumerable<TablePartMetadata>)context.EntityTableParts)
				{
					entityPropertyMetadata = GetPropertyRow(item, CS_0024_003C_003E8__locals0.fUid, context);
					if (entityPropertyMetadata != null)
					{
						return entityPropertyMetadata;
					}
				}
				continue;
			}
			return entityPropertyMetadata;
		}
		return null;
	}

	private EntityPropertyMetadata GetPropertyRow(TablePartMetadata tablePart, Guid uid, ProcessContext context)
	{
		int num = 5;
		int num2 = num;
		_003C_003Ec__DisplayClass17_0 _003C_003Ec__DisplayClass17_ = default(_003C_003Ec__DisplayClass17_0);
		EntityPropertyMetadata entityPropertyMetadata;
		while (true)
		{
			switch (num2)
			{
			default:
				_003C_003Ec__DisplayClass17_.context = context;
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 != 0)
				{
					num2 = 1;
				}
				continue;
			case 1:
				entityPropertyMetadata = ((IEnumerable<EntityPropertyMetadata>)tablePart.EntityProperties).FirstOrDefault(_003C_003Ec__DisplayClass17_._003CGetPropertyRow_003Eb__0);
				if (entityPropertyMetadata == null)
				{
					num2 = 2;
					continue;
				}
				break;
			case 4:
				_003C_003Ec__DisplayClass17_.uid = uid;
				num2 = 3;
				continue;
			case 3:
				_003C_003Ec__DisplayClass17_._003C_003E4__this = this;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d == 0)
				{
					num2 = 0;
				}
				continue;
			case 5:
				_003C_003Ec__DisplayClass17_ = new _003C_003Ec__DisplayClass17_0();
				num2 = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_719514a5a8ae47ed84e5a777ead0dc9f == 0)
				{
					num2 = 2;
				}
				continue;
			case 2:
				entityPropertyMetadata = ((IEnumerable<TablePartMetadata>)tablePart.EntityTableParts).Select(_003C_003Ec__DisplayClass17_._003CGetPropertyRow_003Eb__1).FirstOrDefault();
				break;
			}
			break;
		}
		return entityPropertyMetadata;
	}

	private EntityPropertyMetadata GetProperty(DocumentGenerationTemplateInfo info, List<ProcessContext> contexts)
	{
		if (!info.ResultPropertyUid.HasValue)
		{
			return null;
		}
		return GetEntityProperty(contexts, info.ResultPropertyUid.Value);
	}

	private BinaryFile GetDocumentFile(DocumentGenerationTemplateInfo info, IFileManager fileManager, out string errMessage)
	{
		//Discarded unreachable code: IL_00c9, IL_00d8, IL_010c, IL_01bc
		int num = 10;
		long? documentId = default(long?);
		IDocument document = default(IDocument);
		BinaryFile result = default(BinaryFile);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 8:
					if (!documentId.HasValue)
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b876fa7b083748c8abf8c4b192a11078 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 6;
				case 10:
					document = null;
					num2 = 9;
					continue;
				case 3:
					errMessage = null;
					num = 7;
					break;
				case 11:
					return null;
				case 5:
					if (document.CurrentVersion == null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 4;
				case 14:
					result = GetFile(fileManager, ((BinaryFile)CICYJNZJ94IFWQtYfK86(document.CurrentVersion)).Id);
					num2 = 12;
					continue;
				case 13:
					errMessage = SR.T((string)GaegfuZJYeIdLhWEQP0Z(-1386448964 ^ -1386291066));
					num = 11;
					break;
				case 9:
					result = null;
					num2 = 3;
					continue;
				default:
					return result;
				case 7:
					documentId = info.DocumentId;
					num2 = 8;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5c45a6e5a4614bfba7591d8a1c7ced1d != 0)
					{
						num2 = 7;
					}
					continue;
				case 6:
				{
					DocumentManager instance = DocumentManager.Instance;
					documentId = info.DocumentId;
					document = instance.LoadOrNull(documentId.Value);
					num = 2;
					break;
				}
				case 1:
				case 2:
					if (document != null)
					{
						num2 = 5;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_978f838cc41a4debb9700ede4b63f820 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 13;
				case 4:
					if (CICYJNZJ94IFWQtYfK86(NxdHh6ZJfKtQNYlo10A7(document)) != null)
					{
						num2 = 14;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58fb165cafed422d973d4a7156526541 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto default;
				}
				break;
			}
		}
	}

	private BinaryFile GetFile(IFileManager fileManager, string id)
	{
		//Discarded unreachable code: IL_004b, IL_007d, IL_00b5, IL_00c4
		BinaryFile binaryFile = default(BinaryFile);
		switch (1)
		{
		default:
			return binaryFile;
		case 1:
			try
			{
				binaryFile = fileManager.LoadFile(id);
				int num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd == 0)
				{
					num = 0;
				}
				return num switch
				{
					0 => binaryFile, 
					_ => binaryFile, 
				};
			}
			catch
			{
				int num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4ef74b4b7d13430e9d2f9b78cbdb367b == 0)
				{
					num2 = 1;
				}
				while (true)
				{
					switch (num2)
					{
					default:
						return binaryFile;
					case 0:
						return binaryFile;
					case 1:
						binaryFile = null;
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}
	}

	private void AppendFileRow(DocumentGenerationTemplateInfo info, BinaryFile file, StringBuilder sb, EntityPropertyMetadata property, string templateName, string errMessage = null)
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
				AtP0qAZJPfoyPaNVkbd5(sb, TYS6Y1ZJTKP1l4u7Y1o5(new string[5]
				{
					templateName,
					(string)(tsHK21ZJWq2fNYTaPk9J(((string)K9fMThZJJuIUl7R9OalW(info)).Trim(), "") ? K9fMThZJJuIUl7R9OalW(info) : FyDXt5ZJKU1yAlnOZcU0(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1212129906 ^ 0x483D3510))),
					(string)(errMessage ?? ((file != null) ? VKKm3VZJRkv1VXYkF0cp(file.Name, string.Empty, Path.GetFileNameWithoutExtension(((string)dnc0aYZJjQdtm3DmsUht(file)).ReplaceInvalidFileNameChars())) : SR.T((string)GaegfuZJYeIdLhWEQP0Z(0x51EF0063 ^ 0x51ED97ED)))),
					(string)((property != null) ? mrbQqLZJqaq6oUWxSri1(string.Format((string)GaegfuZJYeIdLhWEQP0Z(0x651FE29D ^ 0x651DDD71), k3tfF9ZJDpHgtyn5gtp1(J8Q7beZJuRMluWUQ8p3H(property).ToString(), GaegfuZJYeIdLhWEQP0Z(-1514166050 ^ -1514301220), "")), wxiDGeZJ6rXv7lMGjTdU(property)) : FyDXt5ZJKU1yAlnOZcU0(GaegfuZJYeIdLhWEQP0Z(-452127399 ^ -451968265))),
					(string)EubyLEZJ3h5g2CgkId8K(info)
				}, false, null));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cb262bcfe4074a1ab16e653815d57f28 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private string TryCopyFile(BinaryFile file, GenerationSettings gs)
	{
		//Discarded unreachable code: IL_0091, IL_00ef, IL_0106, IL_0115
		int num = 2;
		int num2 = num;
		string result = default(string);
		while (true)
		{
			switch (num2)
			{
			case 2:
				result = null;
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5c45a6e5a4614bfba7591d8a1c7ced1d != 0)
				{
					num2 = 1;
				}
				break;
			default:
				return result;
			case 1:
				try
				{
					string text = (string)ex5QLvZJpTgBnqqUXjm0(GaegfuZJYeIdLhWEQP0Z(-197778752 ^ -197872356), gs.ServerDirectory, xAM9PBZJQc1K2wB2RkIt(dnc0aYZJjQdtm3DmsUht(file)));
					int num3 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3ab79470996d472f815915b21f45aac1 != 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						case 1:
							return result;
						}
						bGqIDmZJCX5T3TyVK18s(file, text);
						num3 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 != 0)
						{
							num3 = 0;
						}
					}
				}
				catch (Exception ex)
				{
					result = (string)cMsHlHZJMr78Ldh89hZ2(ex);
					int num4 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b876fa7b083748c8abf8c4b192a11078 == 0)
					{
						num4 = 0;
					}
					return num4 switch
					{
						0 => result, 
						_ => result, 
					};
				}
			}
		}
	}

	public override void ReplaceContextVar(Dictionary<Guid, Guid> ReplaceContextVar)
	{
		base.ReplaceContextVar(ReplaceContextVar);
		Guid value = Guid.Empty;
		if (Templates == null)
		{
			return;
		}
		foreach (DocumentGenerationTemplateInfo template in Templates)
		{
			Guid key = (template.ResultPropertyUid.HasValue ? template.ResultPropertyUid.Value : default(Guid));
			if (ReplaceContextVar.TryGetValue(key, out value))
			{
				template.ResultPropertyUid = value;
			}
		}
	}

	public Type[] GetAvaiableOutputElementTypes()
	{
		return HintDrawElementHelper.GetAvaiableOutputElementTypes<TaskElement>();
	}

	internal static bool z4h0yCZs4qgaXDUgnZPg()
	{
		return Q3MHPqZswv7o8o60GUge == null;
	}

	internal static DocumentGenerationElement pQdTRKZszOD2mtNqLOaL()
	{
		return Q3MHPqZswv7o8o60GUge;
	}

	internal static object FyDXt5ZJKU1yAlnOZcU0(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object ph7EHaZJOgbMZ3y5yY5R(object P_0)
	{
		return ((Element)P_0).Name;
	}

	internal static bool wKAidoZJZGISpgAKAgur(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object im2JYnZJvRJMRf8f113c(object P_0)
	{
		return ((Element)P_0).DefaultName;
	}

	internal static object GaegfuZJYeIdLhWEQP0Z(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object zhOFxHZJ8iRPuNTrukrV(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static void h5ByFwZJsICSrVB3gKGL(object P_0, object P_1, Guid propertyUid, object P_3, bool errorOnEmptyUid)
	{
		((ElementValidationHelper)P_0).ValidatePropertyExists((WorkflowProcessValidator)P_1, propertyUid, (string)P_3, errorOnEmptyUid);
	}

	internal static object K9fMThZJJuIUl7R9OalW(object P_0)
	{
		return ((DocumentGenerationTemplateInfo)P_0).Name;
	}

	internal static GenerationTemplateType OkXgxqZJl0nrvdPMQK6P(object P_0)
	{
		return ((DocumentGenerationTemplateInfo)P_0).TemplateType;
	}

	internal static object GCAnDGZJ0O1H0WXeeMDF(object P_0)
	{
		return ((DocumentGenerationTemplateInfo)P_0).TemplateFileId;
	}

	internal static object J5i5VhZJysCHNRtUmKkA(object P_0, object P_1)
	{
		return ((ITemplateFileDTOManager)P_0).LoadTemplate((string)P_1);
	}

	internal static object bQxffKZJmQIcQJW8iMXX(object P_0, long P_1)
	{
		return ((IDocumentDTOManager)P_0).GetCurrentVersionFileId(P_1);
	}

	internal static object tuMLFpZJtPenYcbee2ZC(object P_0)
	{
		return ((BinaryFileDTO)P_0).Name;
	}

	internal static object Mw6OHEZJb1vDwo6KW16T(object P_0, object P_1, object P_2, object P_3)
	{
		return ((DocumentGeneratorManager)P_0).Create((Stream)P_1, (string)P_2, (IGeneratorProvider)P_3);
	}

	internal static void kD7kTOZJ5rPR8FyiioHG(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object eD5xlXZJgI9owSefPGwj(object P_0)
	{
		return ((string)P_0).Trim();
	}

	internal static Guid DpCYDVZJBfneRCvHSo8J(object P_0)
	{
		return ((Element)P_0).Uid;
	}

	internal static object xAKgIIZJct80aJfVvCYy(object P_0)
	{
		return string.Concat((object[])P_0);
	}

	internal static object AtP0qAZJPfoyPaNVkbd5(object P_0, object P_1)
	{
		return ((StringBuilder)P_0).Append((string)P_1);
	}

	internal static object v0RwvYZJXt1ik5rGWQ5g(object P_0)
	{
		return HTMLUtility.MakeValidFileName((string)P_0);
	}

	internal static object GJX80JZJdtHqgf9ZAWtQ(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static Guid J8Q7beZJuRMluWUQ8p3H(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static object k3tfF9ZJDpHgtyn5gtp1(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static object RkwesYZJnXFFUZFpgBwQ(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static object UVvO6OZJH0rWeBRxJT0p(object P_0)
	{
		return ((BPMNFlowElement)P_0).GetConnectorsLink();
	}

	internal static object wZ9apkZJLOlkSZ6hsuSh(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object NxdHh6ZJfKtQNYlo10A7(object P_0)
	{
		return ((IDocument)P_0).CurrentVersion;
	}

	internal static object CICYJNZJ94IFWQtYfK86(object P_0)
	{
		return ((IDocumentVersion)P_0).File;
	}

	internal static bool tsHK21ZJWq2fNYTaPk9J(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static object dnc0aYZJjQdtm3DmsUht(object P_0)
	{
		return ((BinaryFile)P_0).Name;
	}

	internal static object VKKm3VZJRkv1VXYkF0cp(object P_0, object P_1, object P_2)
	{
		return HTMLUtility.InsertHyperLink((string)P_0, (string)P_1, (string)P_2);
	}

	internal static object wxiDGeZJ6rXv7lMGjTdU(object P_0)
	{
		return ((NamedMetadata)P_0).DisplayName;
	}

	internal static object mrbQqLZJqaq6oUWxSri1(object P_0, object P_1)
	{
		return HTMLUtility.InsertHyperLink((string)P_0, (string)P_1);
	}

	internal static object EubyLEZJ3h5g2CgkId8K(object P_0)
	{
		return ((DocumentGenerationTemplateInfo)P_0).Comment;
	}

	internal static object TYS6Y1ZJTKP1l4u7Y1o5(object P_0, bool isBold, object P_2)
	{
		return HTMLUtility.InsertRowToTable((string[])P_0, isBold, (string[])P_2);
	}

	internal static object xAM9PBZJQc1K2wB2RkIt(object P_0)
	{
		return ((string)P_0).ReplaceInvalidFileNameChars();
	}

	internal static object ex5QLvZJpTgBnqqUXjm0(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static void bGqIDmZJCX5T3TyVK18s(object P_0, object P_1)
	{
		((BinaryFile)P_0).SaveToLocalPath((string)P_1);
	}

	internal static object cMsHlHZJMr78Ldh89hZ2(object P_0)
	{
		return ((Exception)P_0).Message;
	}
}
