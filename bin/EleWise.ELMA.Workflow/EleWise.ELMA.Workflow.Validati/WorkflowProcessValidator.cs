using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Templates;
using EleWise.ELMA.Templates.TemplateGenerator;
using EleWise.ELMA.Workflow.DTO.Managers;
using EleWise.ELMA.Workflow.DTO.Models;
using EleWise.ELMA.Workflow.Models;
using EleWise.TemplateGenerator;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Validation;

public class WorkflowProcessValidator
{
	private static IWorkflowProcessDTOManager workflowProcessDtoManager;

	private static IEnumerable<IWorkflowProcessValidate> workflowProcessValidates;

	private static IProcessHeaderDTOManager processHeaderDtoManager;

	private readonly List<ProcessValidationMessage> messages;

	private List<IPropertyMetadata> allProperties;

	private ClassMetadataPartsContainer metadataContainer;

	private List<EntityMetadata> extendMetadata;

	private List<WorkflowForm> processForms;

	internal static WorkflowProcessValidator cDySIHYGHRVNOW43M0g;

	public ICollection<ProcessValidationMessage> Messages => messages;

	public bool HasErrors => messages.Count((ProcessValidationMessage m) => _003C_003Ec.Je41IOZL4Hke8RxeNy5R(m) == ProcessValidationMessageType.Error) > 0;

	public bool HasWarnings => messages.Count((ProcessValidationMessage m) => _003C_003Ec.Je41IOZL4Hke8RxeNy5R(m) == ProcessValidationMessageType.Warning) > 0;

	public WorkflowProcessDTO Process
	{
		[CompilerGenerated]
		get
		{
			return _003CProcess_003Ek__BackingField;
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
					_003CProcess_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_08023922bb0e4e809e5cff73a2b04988 == 0)
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

	public IEnumerable<IPropertyMetadata> AllProperties
	{
		get
		{
			if (allProperties == null)
			{
				allProperties = new List<IPropertyMetadata>();
				AddProperties(allProperties, Process);
			}
			return allProperties;
		}
	}

	internal ClassMetadataPartsContainer MetadataContainer
	{
		get
		{
			int num = 5;
			int num2 = num;
			ProcessContext processContext = default(ProcessContext);
			PropertyMetadata item2 = default(PropertyMetadata);
			ClassMetadata classMetadata = default(ClassMetadata);
			PropertyMetadata item = default(PropertyMetadata);
			while (true)
			{
				switch (num2)
				{
				case 6:
				{
					PropertyMetadata propertyMetadata = new PropertyMetadata();
					WI2t2DY1xb3mkEZ8rgA(propertyMetadata, kb5Qv3YFqc2ygCokIed(0x37E97159 ^ 0x37E961C1));
					HuaJVaYeT6b8FnaTxEv(propertyMetadata, f9BcY0YhT82g165iBV7(processContext));
					propertyMetadata.SubTypeUid = sVwtK8YEYfyBNpjBP2i(processContext);
					EntitySettings entitySettings2 = new EntitySettings();
					uJmMG9YxOMhd89HBu73(entitySettings2, RelationType.OneToOne);
					propertyMetadata.Settings = entitySettings2;
					item2 = propertyMetadata;
					num2 = 8;
					break;
				}
				case 3:
					classMetadata.Properties.Add(item2);
					num2 = 7;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1a2d7634479d44fb8d3718c31b05f73c == 0)
					{
						num2 = 2;
					}
					break;
				case 1:
					processContext = (ProcessContext)HxpMphYSO5bLcsRWGlk(Process);
					num2 = 6;
					break;
				case 8:
					classMetadata.Properties.Add(item);
					num2 = 3;
					break;
				default:
					return metadataContainer;
				case 4:
					return metadataContainer;
				case 2:
				{
					PropertyMetadata obj = new PropertyMetadata
					{
						Name = (string)kb5Qv3YFqc2ygCokIed(0x37E97159 ^ 0x37E961DD)
					};
					HuaJVaYeT6b8FnaTxEv(obj, EntityDescriptor.UID);
					apxFDIYNPBx4N7tVMlH(obj, InterfaceActivator.UID<IWorkflowInstance>());
					EntitySettings entitySettings = new EntitySettings();
					uJmMG9YxOMhd89HBu73(entitySettings, RelationType.OneToOne);
					obj.Settings = entitySettings;
					item = obj;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea != 0)
					{
						num2 = 1;
					}
					break;
				}
				case 5:
					if (metadataContainer == null)
					{
						classMetadata = new ClassMetadata();
						num2 = 2;
						break;
					}
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e8980a9fd9d44c20920ffa276900c96f != 0)
					{
						num2 = 4;
					}
					break;
				case 7:
					metadataContainer = new ClassMetadataPartsContainer(new ClassMetadata[1] { classMetadata });
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cb262bcfe4074a1ab16e653815d57f28 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	internal List<EntityMetadata> ExtendMetadata
	{
		get
		{
			if (extendMetadata != null)
			{
				return extendMetadata;
			}
			extendMetadata = new List<EntityMetadata>();
			extendMetadata.Add(GetModifiedWorkflowInstanceMetadata());
			AddModifiedContextMetadataWithParents(extendMetadata);
			return extendMetadata;
		}
	}

	internal List<WorkflowForm> ProcessForms
	{
		get
		{
			if (processForms != null)
			{
				return processForms;
			}
			processForms = new List<WorkflowForm>();
			for (WorkflowProcessDTO workflowProcessDTO = Process; workflowProcessDTO != null; workflowProcessDTO = workflowProcessDTO.Parent)
			{
				processForms.AddRange(workflowProcessDTO.Forms.Items);
			}
			return processForms;
		}
	}

	private static IWorkflowProcessDTOManager WorkflowProcessDtoManager
	{
		get
		{
			int num = 1;
			int num2 = num;
			IWorkflowProcessDTOManager workflowProcessDTOManager;
			while (true)
			{
				switch (num2)
				{
				case 1:
					workflowProcessDTOManager = workflowProcessDtoManager;
					if (workflowProcessDTOManager == null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_60c5782a184b457aa78da2e5c62d4e27 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				default:
					workflowProcessDTOManager = (workflowProcessDtoManager = Locator.GetServiceNotNull<IWorkflowProcessDTOManager>());
					break;
				}
				break;
			}
			return workflowProcessDTOManager;
		}
	}

	private static IEnumerable<IWorkflowProcessValidate> WorkflowProcessValidates => workflowProcessValidates ?? (workflowProcessValidates = ComponentManager.Current.GetExtensionPoints<IWorkflowProcessValidate>());

	private static IProcessHeaderDTOManager ProcessHeaderDtoManager
	{
		get
		{
			int num = 1;
			int num2 = num;
			IProcessHeaderDTOManager processHeaderDTOManager;
			while (true)
			{
				switch (num2)
				{
				case 1:
					processHeaderDTOManager = processHeaderDtoManager;
					if (processHeaderDTOManager != null)
					{
						break;
					}
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_639c11c7bb65456db9f29c9c42f28bf7 != 0)
					{
						num2 = 0;
					}
					continue;
				default:
					processHeaderDTOManager = (processHeaderDtoManager = Locator.GetService<IProcessHeaderDTOManager>());
					break;
				}
				break;
			}
			return processHeaderDTOManager;
		}
	}

	public WorkflowProcessValidator(WorkflowProcessDTO process)
	{
		//Discarded unreachable code: IL_003a, IL_003f
		nK1yaLYoLnD8fabKyov();
		messages = new List<ProcessValidationMessage>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_938c6be4ea2248868d7ed5d0e3346006 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				Process = process;
				num = 2;
				continue;
			case 2:
				return;
			}
			mSJPpfYiNRHtYmwduP5(process, kb5Qv3YFqc2ygCokIed(0x651FE29D ^ 0x651FF2EF));
			num = 1;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e == 0)
			{
				num = 0;
			}
		}
	}

	public bool Validate()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return HasErrors;
			case 1:
				N0AGIvYa1eT81UiUxju(this);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				PwHsa9YIWoWBtY4SCxS(messages);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a9be7e056b4e4b6e863b634c418144f1 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal void ValidateTemplate(object element, string template, string errorMessage)
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
				ValidateTemplate(element, template, errorMessage, MetadataContainer);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal void ValidateTemplate(object element, string template, string errorMessage, ClassMetadataPartsContainer container)
	{
		//Discarded unreachable code: IL_0035
		int num = 2;
		TextTemplateGenerator generator = default(TextTemplateGenerator);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 3:
					return;
				case 1:
					break;
				case 4:
					ValidateTemplate(element, generator, errorMessage, container);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5d3bc916b5664717ac60544de077bd16 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					if (zIctMNYrQRuCrQo9ypk(template))
					{
						return;
					}
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4cc62744d0eb4cd68219b70dcad3e68e != 0)
					{
						num2 = 1;
					}
					continue;
				case 0:
					return;
				}
				break;
			}
			generator = new TextTemplateGenerator(template);
			num = 4;
		}
	}

	internal void ValidateTemplate(object element, GeneratorBase generator, string errorMessage, ClassMetadataPartsContainer container)
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
				ValidateTemplate(element, generator, container, errorMessage);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected virtual void ValidateAll()
	{
		//Discarded unreachable code: IL_0056, IL_0064, IL_0108, IL_0140, IL_014f
		int num = 3;
		int num2 = num;
		IEnumerator<ProcessValidationMessage> enumerator = default(IEnumerator<ProcessValidationMessage>);
		ProcessValidationMessage current = default(ProcessValidationMessage);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				CiSMS2YwhblBnjxWxWs(this);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 != 0)
				{
					num2 = 2;
				}
				break;
			case 4:
				try
				{
					while (true)
					{
						IL_00cc:
						int num3;
						if (!cLZ2IfY49ZIcq8F3IDv(enumerator))
						{
							num3 = 2;
							goto IL_0068;
						}
						goto IL_0082;
						IL_0068:
						while (true)
						{
							switch (num3)
							{
							case 3:
								break;
							default:
								Messages.Add(current);
								num3 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b84ccb8b1bd147ef900b852047ecbf45 != 0)
								{
									num3 = 1;
								}
								continue;
							case 1:
								goto IL_00cc;
							case 2:
								return;
							}
							break;
						}
						goto IL_0082;
						IL_0082:
						current = enumerator.Current;
						num3 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae2bde9e5844c638021cdb56fc01122 != 0)
						{
							num3 = 0;
						}
						goto IL_0068;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num4 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 == 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								T72xNuYzJrDSLVJ5io0(enumerator);
								num4 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f05298ca2a4a4a639a58bc7f7d9ff7b9 != 0)
								{
									num4 = 0;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
			case 1:
				enumerator = WorkflowProcessValidates.SelectMany((IWorkflowProcessValidate p) => p.Validate(Process)).GetEnumerator();
				num2 = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_719514a5a8ae47ed84e5a777ead0dc9f == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 2:
				ValidateProcess();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_60c5782a184b457aa78da2e5c62d4e27 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected virtual void ValidateDiagram()
	{
		//Discarded unreachable code: IL_00a8, IL_00b7
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
			case 2:
				return;
			case 3:
			{
				List<ProcessValidationMessage> list = messages;
				ProcessValidationMessage processValidationMessage = new ProcessValidationMessage();
				vImmwq8OJCrpsW6Pw93(processValidationMessage, ProcessValidationMessageType.Error);
				D3aXAy8ZvoR64fWBJRk(processValidationMessage, SR.T((string)kb5Qv3YFqc2ygCokIed(-105863102 ^ -105858840)));
				list.Add(processValidationMessage);
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f91acf223c4b4303819d2f8f2fc6c8e1 == 0)
				{
					num2 = 2;
				}
				break;
			}
			case 1:
				if (hlNrjf8KWMSgunEs4QA(Process) != null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			}
		}
	}

	protected virtual void ValidateProcess()
	{
		//Discarded unreachable code: IL_0059, IL_006a, IL_0079, IL_013c, IL_014b, IL_01a3, IL_0360, IL_036f, IL_03a2, IL_03b1, IL_03d2, IL_03f1, IL_0400, IL_042d, IL_0538, IL_05ae, IL_05e6, IL_05f5
		int num = 2;
		int num2 = num;
		IEnumerator<IPropertyMetadata> enumerator = default(IEnumerator<IPropertyMetadata>);
		IPropertyMetadata current = default(IPropertyMetadata);
		string text = default(string);
		string message = default(string);
		EntitySettings entitySettings = default(EntitySettings);
		TablePartMetadata tablePartMetadata = default(TablePartMetadata);
		IEnumerator<PropertyMetadata> enumerator2 = default(IEnumerator<PropertyMetadata>);
		EntityPropertyMetadata entityPropertyMetadata2 = default(EntityPropertyMetadata);
		PropertyMetadata current2 = default(PropertyMetadata);
		string text2 = default(string);
		string message2 = default(string);
		EntitySettings entitySettings2 = default(EntitySettings);
		EntityPropertyMetadata entityPropertyMetadata = default(EntityPropertyMetadata);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				if (YhTnfo8vtR1geGUE8dD() == null)
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 != 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			case 1:
				return;
			case 0:
				return;
			case 3:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 4;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 == 0)
							{
								num3 = 8;
							}
							goto IL_0088;
						}
						goto IL_04a9;
						IL_04a9:
						current = enumerator.Current;
						num3 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_43af423d081c48e3bc6cea30ce47523d == 0)
						{
							num3 = 3;
						}
						goto IL_0088;
						IL_0088:
						while (true)
						{
							int num4;
							switch (num3)
							{
							case 8:
								return;
							default:
								if (((IProcessHeaderDTOManager)YhTnfo8vtR1geGUE8dD()).ValidateTableName(T4bIhr8JuQt9pVE8vt5(current), text, out message))
								{
									num3 = 12;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_43af423d081c48e3bc6cea30ce47523d == 0)
									{
										num3 = 16;
									}
									continue;
								}
								goto case 1;
							case 5:
								if (entitySettings != null)
								{
									num3 = 2;
									continue;
								}
								goto case 15;
							case 14:
								entitySettings = UxTv9y8Y1L4IYQlgNc6(current) as EntitySettings;
								num4 = 5;
								goto IL_0084;
							case 9:
							case 12:
								break;
							case 13:
								if (tablePartMetadata == null)
								{
									num3 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 == 0)
									{
										num3 = 9;
									}
									continue;
								}
								goto case 10;
							case 4:
								try
								{
									while (true)
									{
										IL_0308:
										int num5;
										if (!cLZ2IfY49ZIcq8F3IDv(enumerator2))
										{
											num5 = 7;
											goto IL_01b1;
										}
										goto IL_02d4;
										IL_01b1:
										while (true)
										{
											switch (num5)
											{
											case 8:
												if (entityPropertyMetadata2 == null)
												{
													num5 = 1;
													if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 != 0)
													{
														num5 = 1;
													}
													continue;
												}
												goto case 3;
											case 6:
											{
												ICollection<ProcessValidationMessage> collection = Messages;
												ProcessValidationMessage processValidationMessage = new ProcessValidationMessage();
												D3aXAy8ZvoR64fWBJRk(processValidationMessage, pGmvbP80PT6KWAbngX4(kb5Qv3YFqc2ygCokIed(0x13F63440 ^ 0x13F6249C), new object[3]
												{
													PX8cHu8mTcbLif5EBJK(current2),
													text2,
													message2
												}));
												processValidationMessage.Type = ProcessValidationMessageType.Error;
												collection.Add(processValidationMessage);
												num5 = 13;
												continue;
											}
											case 12:
												entityPropertyMetadata2 = current2 as EntityPropertyMetadata;
												num5 = 8;
												continue;
											case 2:
												if (((IProcessHeaderDTOManager)YhTnfo8vtR1geGUE8dD()).ValidateTableName(sVwtK8YEYfyBNpjBP2i(current2), text2, out message2))
												{
													num5 = 9;
													if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1c37d4e24e094858975336738e156495 == 0)
													{
														num5 = 8;
													}
													continue;
												}
												goto case 6;
											case 4:
												if (entitySettings2.RelationType == RelationType.ManyToMany)
												{
													num5 = 11;
													continue;
												}
												goto IL_0308;
											case 5:
												break;
											case 10:
												if (entitySettings2 != null)
												{
													num5 = 4;
													if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_61395ebf330446ac8ce99b55ee3acfa9 == 0)
													{
														num5 = 1;
													}
													continue;
												}
												goto IL_0308;
											case 1:
											case 9:
											case 13:
												goto IL_0308;
											default:
											{
												message2 = "";
												int num6 = 2;
												num5 = num6;
												continue;
											}
											case 3:
												entitySettings2 = ey6Dsv8yVKvihS1SxCm(entityPropertyMetadata2) as EntitySettings;
												num5 = 10;
												if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 == 0)
												{
													num5 = 0;
												}
												continue;
											case 11:
												text2 = (string)qK0CmH8sCIeUwOllnqn(entityPropertyMetadata2);
												num5 = 0;
												if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2f119e188994b55be2499c193b880fb == 0)
												{
													num5 = 0;
												}
												continue;
											case 7:
												goto end_IL_0308;
											}
											break;
										}
										goto IL_02d4;
										IL_02d4:
										current2 = enumerator2.Current;
										num5 = 12;
										goto IL_01b1;
										continue;
										end_IL_0308:
										break;
									}
								}
								finally
								{
									int num7;
									if (enumerator2 == null)
									{
										num7 = 2;
										goto IL_03d6;
									}
									goto IL_040b;
									IL_03d6:
									switch (num7)
									{
									default:
										goto end_IL_03c1;
									case 2:
										goto end_IL_03c1;
									case 1:
										break;
									case 0:
										goto end_IL_03c1;
									}
									goto IL_040b;
									IL_040b:
									T72xNuYzJrDSLVJ5io0(enumerator2);
									num7 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c559093b7320494babd70d164a6df42d == 0)
									{
										num7 = 0;
									}
									goto IL_03d6;
									end_IL_03c1:;
								}
								break;
							case 1:
							{
								ICollection<ProcessValidationMessage> collection2 = Messages;
								ProcessValidationMessage processValidationMessage = new ProcessValidationMessage();
								D3aXAy8ZvoR64fWBJRk(processValidationMessage, pGmvbP80PT6KWAbngX4(kb5Qv3YFqc2ygCokIed(-1965291699 ^ -1965287535), new object[3]
								{
									o1ulVw8lC4KIaiNrbvH(current),
									text,
									message
								}));
								vImmwq8OJCrpsW6Pw93(processValidationMessage, ProcessValidationMessageType.Error);
								collection2.Add(processValidationMessage);
								num3 = 15;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b1ab9396b25b43af8f32e24b1948be96 != 0)
								{
									num3 = 8;
								}
								continue;
							}
							case 7:
								goto IL_04a9;
							case 2:
								if (A5nu6T88o3cVLl6JDx3(entitySettings) == RelationType.ManyToMany)
								{
									num3 = 6;
									continue;
								}
								goto case 15;
							case 15:
							case 16:
								tablePartMetadata = current as TablePartMetadata;
								num3 = 13;
								continue;
							case 10:
								enumerator2 = tablePartMetadata.GetAllProperties().GetEnumerator();
								num3 = 4;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cb262bcfe4074a1ab16e653815d57f28 != 0)
								{
									num3 = 4;
								}
								continue;
							case 11:
								if (entityPropertyMetadata != null)
								{
									num4 = 14;
									goto IL_0084;
								}
								goto case 15;
							case 6:
								text = (string)qK0CmH8sCIeUwOllnqn(entityPropertyMetadata);
								num3 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f == 0)
								{
									num3 = 0;
								}
								continue;
							case 3:
								{
									entityPropertyMetadata = current as EntityPropertyMetadata;
									num3 = 2;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6b089b0d02ae4d3186c8d2cb8a24d4d3 == 0)
									{
										num3 = 11;
									}
									continue;
								}
								IL_0084:
								num3 = num4;
								continue;
							}
							break;
						}
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num8 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 == 0)
						{
							num8 = 1;
						}
						while (true)
						{
							switch (num8)
							{
							case 1:
								T72xNuYzJrDSLVJ5io0(enumerator);
								num8 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_719514a5a8ae47ed84e5a777ead0dc9f != 0)
								{
									num8 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
				}
			case 4:
				break;
			}
			enumerator = AllProperties.GetEnumerator();
			num2 = 3;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b == 0)
			{
				num2 = 2;
			}
		}
	}

	private void AddProperties(List<IPropertyMetadata> list, WorkflowProcessDTO process)
	{
		if (process != null)
		{
			WorkflowProcessDTO workflowProcessDTO = ((process.ParentId > 0) ? WorkflowProcessDtoManager.LoadOrNull(process.ParentId) : process.Parent);
			if (workflowProcessDTO != null)
			{
				AddProperties(list, workflowProcessDTO);
			}
			list.AddRange(process.Context.GetPropertiesAndTableParts());
		}
	}

	private static ProcessValidationMessage CreateValidationError(object element, object message)
	{
		ProcessValidationMessage processValidationMessage = new ProcessValidationMessage();
		D3aXAy8ZvoR64fWBJRk(processValidationMessage, message);
		processValidationMessage.Type = ProcessValidationMessageType.Error;
		MYoWDo8tPcJUZqhJjOn(processValidationMessage, element);
		return processValidationMessage;
	}

	private void ValidateTemplate(object element, GeneratorBase generator, ClassMetadataPartsContainer container, string errorMessage)
	{
		//Discarded unreachable code: IL_004c, IL_0127, IL_0136, IL_0146, IL_0155, IL_016f, IL_020c, IL_024c, IL_025b, IL_0267, IL_0276
		int num = 2;
		int num2 = num;
		DocumentGeneratorBase documentGeneratorBase = default(DocumentGeneratorBase);
		MetadataServiceContext metadataServiceContext = default(MetadataServiceContext);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				try
				{
					TextTemplateGenerator textTemplateGenerator = generator as TextTemplateGenerator;
					int num3 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9269d021c6f148b6a1c4afb8cee03b6c != 0)
					{
						num3 = 1;
					}
					while (true)
					{
						switch (num3)
						{
						case 8:
							ProcessMessages(element, documentGeneratorBase.Validate(container).ToArray(), errorMessage);
							num3 = 5;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_805f3361d2ba4dac8da4174f89314253 != 0)
							{
								num3 = 4;
							}
							break;
						case 1:
							if (textTemplateGenerator == null)
							{
								num3 = 6;
								break;
							}
							goto case 4;
						case 4:
							ProcessMessages(element, textTemplateGenerator.Validate(container).ToArray(), errorMessage);
							num3 = 2;
							break;
						default:
							documentGeneratorBase = generator as DocumentGeneratorBase;
							num3 = 7;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_32f3e755437f4eacb85c8a0d536f83ea != 0)
							{
								num3 = 6;
							}
							break;
						case 7:
							if (documentGeneratorBase == null)
							{
								num3 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5d3bc916b5664717ac60544de077bd16 == 0)
								{
									num3 = 3;
								}
								break;
							}
							goto case 8;
						case 2:
							return;
						case 3:
							return;
						case 5:
							return;
						}
					}
				}
				catch (Exception)
				{
					int num4 = 2;
					while (true)
					{
						switch (num4)
						{
						case 2:
							Messages.Add((ProcessValidationMessage)pE3OZq8bp4fXWInR6rc(element, errorMessage));
							num4 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_69cb4a76addb44f28bb765f059e441c7 == 0)
							{
								num4 = 0;
							}
							break;
						default:
							Messages.Add((ProcessValidationMessage)pE3OZq8bp4fXWInR6rc(element, cAgrUU85OP0xmvOleEb(kb5Qv3YFqc2ygCokIed(0x5F534A5C ^ 0x5F535BE0))));
							num4 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b == 0)
							{
								num4 = 1;
							}
							break;
						case 1:
							return;
						}
					}
				}
				finally
				{
					int num5;
					if (metadataServiceContext == null)
					{
						num5 = 2;
						goto IL_0210;
					}
					goto IL_0226;
					IL_0210:
					switch (num5)
					{
					default:
						goto end_IL_01fb;
					case 1:
						break;
					case 2:
						goto end_IL_01fb;
					case 0:
						goto end_IL_01fb;
					}
					goto IL_0226;
					IL_0226:
					T72xNuYzJrDSLVJ5io0(metadataServiceContext);
					num5 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae4e393cddc4c98b9896b25c9e18c7d == 0)
					{
						num5 = 0;
					}
					goto IL_0210;
					end_IL_01fb:;
				}
			case 2:
				metadataServiceContext = MetadataServiceContext.Extend(ExtendMetadata);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bd84f42638494cb6b4427f8e13ec59af != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	private void ProcessMessages(object element, ValidateMessage[] validateMessages, string errorMessage)
	{
		//Discarded unreachable code: IL_0070, IL_007f, IL_008f, IL_0175
		int num = 5;
		ValidateMessage validateMessage = default(ValidateMessage);
		string text2 = default(string);
		int num3 = default(int);
		ValidateMessage[] array = default(ValidateMessage[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				string text;
				switch (num2)
				{
				case 11:
					if (pbbUAb8gFntw1CNNtIZ(validateMessage) != ValidateErrorPartType.InRunningTitle)
					{
						num = 2;
						break;
					}
					text = SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12F686A ^ 0x12F7A5E), oWbpmH8BE3VAA6AbtKx(validateMessage));
					goto IL_01d7;
				case 10:
					return;
				case 4:
					Messages.Add((ProcessValidationMessage)pE3OZq8bp4fXWInR6rc(element, errorMessage));
					num2 = 6;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b == 0)
					{
						num2 = 2;
					}
					continue;
				case 5:
					if (validateMessages.Length == 0)
					{
						return;
					}
					num = 4;
					break;
				case 8:
					Messages.Add((ProcessValidationMessage)pE3OZq8bp4fXWInR6rc(element, text2));
					num2 = 3;
					continue;
				case 3:
					num3++;
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bd84f42638494cb6b4427f8e13ec59af == 0)
					{
						num2 = 12;
					}
					continue;
				case 9:
					return;
				default:
					num3 = 0;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_abfb511163674a3eae959fd60da8f319 == 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
				case 12:
					if (num3 >= array.Length)
					{
						num2 = 9;
						continue;
					}
					goto case 7;
				case 2:
					text = SR.T((string)kb5Qv3YFqc2ygCokIed(0x614CF569 ^ 0x614CE493), oWbpmH8BE3VAA6AbtKx(validateMessage));
					goto IL_01d7;
				case 6:
					array = validateMessages;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3bb28bf622874b4689f9265e58d14823 != 0)
					{
						num2 = 0;
					}
					continue;
				case 7:
					{
						validateMessage = array[num3];
						num = 11;
						break;
					}
					IL_01d7:
					text2 = text;
					num2 = 8;
					continue;
				}
				break;
			}
		}
	}

	private EntityMetadata GetModifiedWorkflowInstanceMetadata()
	{
		int num = 10;
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		ProcessContext processContext = default(ProcessContext);
		EntityMetadata entityMetadata = default(EntityMetadata);
		PropertyMetadata item = default(PropertyMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					if (propertyMetadata != null)
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 2;
				case 8:
					break;
				case 2:
					processContext = (ProcessContext)HxpMphYSO5bLcsRWGlk(Process);
					num2 = 7;
					continue;
				case 4:
					return entityMetadata;
				case 7:
				{
					PropertyMetadata propertyMetadata2 = new PropertyMetadata();
					WI2t2DY1xb3mkEZ8rgA(propertyMetadata2, kb5Qv3YFqc2ygCokIed(-135674354 ^ -135670122));
					propertyMetadata2.TypeUid = f9BcY0YhT82g165iBV7(processContext);
					apxFDIYNPBx4N7tVMlH(propertyMetadata2, sVwtK8YEYfyBNpjBP2i(processContext));
					EntitySettings entitySettings = new EntitySettings();
					uJmMG9YxOMhd89HBu73(entitySettings, RelationType.OneToOne);
					LqVrgc8c9j2JqeNTAqq(propertyMetadata2, entitySettings);
					item = propertyMetadata2;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ac5d16a577a84bb0b8ee3654769d2d33 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				case 5:
					entityMetadata.Description = (string)kb5Qv3YFqc2ygCokIed(0x5F800F5B ^ 0x5F801C63);
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a9be7e056b4e4b6e863b634c418144f1 != 0)
					{
						num2 = 6;
					}
					continue;
				case 10:
					entityMetadata = ClassSerializationHelper.CloneObject((EntityMetadata)InterfaceActivator.LoadMetadata<IWorkflowInstance>(inherit: false, loadImplementation: false));
					num2 = 9;
					continue;
				case 9:
					WI2t2DY1xb3mkEZ8rgA(entityMetadata, kb5Qv3YFqc2ygCokIed(-398691253 ^ -398694699));
					num2 = 8;
					continue;
				default:
					entityMetadata.Properties.Add(item);
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_46e05b4e09174e34a9c81741b8b77a2f == 0)
					{
						num2 = 4;
					}
					continue;
				case 1:
					entityMetadata.Properties.Remove(propertyMetadata);
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 == 0)
					{
						num2 = 2;
					}
					continue;
				case 6:
					propertyMetadata = entityMetadata.Properties.Find((PropertyMetadata property) => _003C_003Ec.XZtipgZfOVFqk4HJn2ek(_003C_003Ec.PPdC6DZLzyEnlvt4GnkK(property), _003C_003Ec.zLF96JZfKuxxs1s5bOWl(-642713667 ^ -642717915)));
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_160bffb148c14c5da92d8d6ddf481bdc == 0)
					{
						num2 = 3;
					}
					continue;
				}
				break;
			}
			entityMetadata.DisplayName = (string)kb5Qv3YFqc2ygCokIed(-10408775 ^ -10404255);
			num = 5;
		}
	}

	private void AddModifiedContextMetadataWithParents(List<EntityMetadata> source)
	{
		ProcessContext processContext = null;
		WorkflowProcessDTO parent = Process.Parent;
		if (parent != null)
		{
			processContext = ClassSerializationHelper.CloneObject(Process.Context);
			processContext.Name = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6F6D7B44 ^ 0x6F6D6E44);
			processContext.DisplayName = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-790221436 ^ -790218574);
			processContext.Description = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1965291699 ^ -1965288743);
			while (parent != null)
			{
				processContext.Properties.AddRange(parent.Context.Properties);
				processContext.Properties.AddRange((IEnumerable<PropertyMetadata>)parent.Context.EntityProperties);
				processContext.TableParts.AddRange(parent.Context.TableParts);
				processContext.TableParts.AddRange((IEnumerable<TablePartMetadata>)parent.Context.EntityTableParts);
				parent = parent.Parent;
			}
			source.Add(processContext);
		}
		else
		{
			source.Add(Process.Context);
		}
	}

	internal static void nK1yaLYoLnD8fabKyov()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static object kb5Qv3YFqc2ygCokIed(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void mSJPpfYiNRHtYmwduP5(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static bool efFZ0dY7YDbTxD6UEww()
	{
		return cDySIHYGHRVNOW43M0g == null;
	}

	internal static WorkflowProcessValidator y9uLGuY2RcGuVYF8Uch()
	{
		return cDySIHYGHRVNOW43M0g;
	}

	internal static void PwHsa9YIWoWBtY4SCxS(object P_0)
	{
		((List<ProcessValidationMessage>)P_0).Clear();
	}

	internal static void N0AGIvYa1eT81UiUxju(object P_0)
	{
		((WorkflowProcessValidator)P_0).ValidateAll();
	}

	internal static bool zIctMNYrQRuCrQo9ypk(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static void HuaJVaYeT6b8FnaTxEv(object P_0, Guid P_1)
	{
		((PropertyMetadata)P_0).TypeUid = P_1;
	}

	internal static void apxFDIYNPBx4N7tVMlH(object P_0, Guid P_1)
	{
		((PropertyMetadata)P_0).SubTypeUid = P_1;
	}

	internal static void uJmMG9YxOMhd89HBu73(object P_0, RelationType P_1)
	{
		((EntitySettings)P_0).RelationType = P_1;
	}

	internal static object HxpMphYSO5bLcsRWGlk(object P_0)
	{
		return ((WorkflowProcessDTO)P_0).Context;
	}

	internal static void WI2t2DY1xb3mkEZ8rgA(object P_0, object P_1)
	{
		((NamedMetadata)P_0).Name = (string)P_1;
	}

	internal static Guid f9BcY0YhT82g165iBV7(object P_0)
	{
		return ((EntityMetadata)P_0).TypeUid;
	}

	internal static Guid sVwtK8YEYfyBNpjBP2i(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static void CiSMS2YwhblBnjxWxWs(object P_0)
	{
		((WorkflowProcessValidator)P_0).ValidateDiagram();
	}

	internal static bool cLZ2IfY49ZIcq8F3IDv(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void T72xNuYzJrDSLVJ5io0(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object hlNrjf8KWMSgunEs4QA(object P_0)
	{
		return ((WorkflowProcessDTO)P_0).Diagram;
	}

	internal static void vImmwq8OJCrpsW6Pw93(object P_0, ProcessValidationMessageType value)
	{
		((ProcessValidationMessage)P_0).Type = value;
	}

	internal static void D3aXAy8ZvoR64fWBJRk(object P_0, object P_1)
	{
		((ProcessValidationMessage)P_0).Message = (string)P_1;
	}

	internal static object YhTnfo8vtR1geGUE8dD()
	{
		return ProcessHeaderDtoManager;
	}

	internal static object UxTv9y8Y1L4IYQlgNc6(object P_0)
	{
		return ((IPropertyMetadata)P_0).Settings;
	}

	internal static RelationType A5nu6T88o3cVLl6JDx3(object P_0)
	{
		return ((EntitySettings)P_0).RelationType;
	}

	internal static object qK0CmH8sCIeUwOllnqn(object P_0)
	{
		return ((EntityPropertyMetadata)P_0).RelationTableName;
	}

	internal static Guid T4bIhr8JuQt9pVE8vt5(object P_0)
	{
		return ((IMetadata)P_0).Uid;
	}

	internal static object o1ulVw8lC4KIaiNrbvH(object P_0)
	{
		return ((IPropertyMetadata)P_0).Name;
	}

	internal static object pGmvbP80PT6KWAbngX4(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static object ey6Dsv8yVKvihS1SxCm(object P_0)
	{
		return ((PropertyMetadata)P_0).Settings;
	}

	internal static object PX8cHu8mTcbLif5EBJK(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static void MYoWDo8tPcJUZqhJjOn(object P_0, object P_1)
	{
		((ProcessValidationMessage)P_0).Object = P_1;
	}

	internal static object pE3OZq8bp4fXWInR6rc(object P_0, object P_1)
	{
		return CreateValidationError(P_0, P_1);
	}

	internal static object cAgrUU85OP0xmvOleEb(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static ValidateErrorPartType pbbUAb8gFntw1CNNtIZ(object P_0)
	{
		return ((ValidateMessage)P_0).ValidateErrorPartType;
	}

	internal static object oWbpmH8BE3VAA6AbtKx(object P_0)
	{
		return ((ValidateMessage)P_0).PatternString;
	}

	internal static void LqVrgc8c9j2JqeNTAqq(object P_0, object P_1)
	{
		((PropertyMetadata)P_0).Settings = (TypeSettings)P_1;
	}
}
