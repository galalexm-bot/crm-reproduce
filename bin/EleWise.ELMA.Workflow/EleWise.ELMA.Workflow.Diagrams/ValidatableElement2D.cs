using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Services;
using EleWise.ELMA.Templates.TemplateGenerator;
using EleWise.ELMA.UI.Helpers;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements;
using EleWise.ELMA.Workflow.DTO.Models;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Validation;
using EleWise.ELMA.Workflow.ViewItems;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Diagrams.Elements;

[Serializable]
public class ValidatableElement2D : Element2D, IValidatable
{
	[NonSerialized]
	private ElementValidationHelper validationHelper;

	internal static ValidatableElement2D GpSLYAh5W61liLuY5So;

	protected ElementValidationHelper ValidationHelper
	{
		get
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					validationHelper = new ElementValidationHelper(this);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 != 0)
					{
						num2 = 0;
					}
					break;
				default:
					return validationHelper;
				case 2:
					if (validationHelper == null)
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8a6cf36da0b84f319a7cf27018f28f5b != 0)
						{
							num2 = 1;
						}
						break;
					}
					goto default;
				}
			}
		}
	}

	public virtual void Validate(WorkflowProcessValidator validator)
	{
		//Discarded unreachable code: IL_0198, IL_01a7, IL_020b, IL_021a, IL_029c, IL_02bc, IL_02cb, IL_0449, IL_0458, IL_0468
		int num = 30;
		ITemplateSetNameElement templateSetNameElement = default(ITemplateSetNameElement);
		string text = default(string);
		FormViewItem formViewItem = default(FormViewItem);
		WorkflowTaskForm workflowTaskForm = default(WorkflowTaskForm);
		IFormViewItemTransformation formViewItemTransformation = default(IFormViewItemTransformation);
		_003C_003Ec__DisplayClass0_1 _003C_003Ec__DisplayClass0_ = default(_003C_003Ec__DisplayClass0_1);
		ITemplateSetDescriptionElement templateSetDescriptionElement = default(ITemplateSetDescriptionElement);
		_003C_003Ec__DisplayClass0_0 _003C_003Ec__DisplayClass0_2 = default(_003C_003Ec__DisplayClass0_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				string defaultName;
				switch (num2)
				{
				case 13:
					validator.ValidateTemplate(this, (string)g0pG63hXJdnVbICRgiA(templateSetNameElement), SR.T((string)HPZJVMhdRBkrYbPNWeS(-1430645277 ^ -1430564977), text));
					num2 = 16;
					continue;
				case 15:
					formViewItem = (FormViewItem)CRGouEhRu8DWvJwwKkd(workflowTaskForm, kW8cc7hjJg13mn1Io8c(validator));
					num2 = 19;
					continue;
				case 17:
					return;
				case 2:
					validator.Messages.Add((ProcessValidationMessage)TcTJj3h6xfP9dVUgt8E(ValidationHelper, WnWqy8hnhZdfHZGC3eR(HPZJVMhdRBkrYbPNWeS(0x56F860D7 ^ 0x56F93B5D), new object[1] { text })));
					num2 = 21;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c == 0)
					{
						num2 = 21;
					}
					continue;
				case 20:
					jwGCu5hH1KVpI9hYqmv(validator, this, X5yBechDaXteNaNCRbY(this), WnWqy8hnhZdfHZGC3eR(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-22348816 ^ -22306536), new object[1] { text }));
					num2 = 11;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 != 0)
					{
						num2 = 26;
					}
					continue;
				case 23:
					return;
				case 4:
					if (((FormViewItemTransformation)RytG7lhWOgLHDtaOeX6(formViewItemTransformation)).Items.Find(_003C_003Ec__DisplayClass0_._003CValidate_003Eb__1) != null)
					{
						num2 = 22;
						continue;
					}
					goto case 7;
				case 19:
					ValidateFormV2(validator, text, formViewItem);
					num2 = 17;
					continue;
				case 16:
					templateSetDescriptionElement = this as ITemplateSetDescriptionElement;
					num2 = 9;
					continue;
				case 29:
					if (!b01TRjhPwpucvWtTl8M(v3cyPnhcOUgNiKbXfM9(this)))
					{
						num2 = 2;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4cc62744d0eb4cd68219b70dcad3e68e == 0)
						{
							num2 = 11;
						}
						continue;
					}
					defaultName = DefaultName;
					break;
				case 12:
					if (templateSetNameElement != null)
					{
						num2 = 8;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 16;
				case 9:
					if (templateSetDescriptionElement == null)
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_46e05b4e09174e34a9c81741b8b77a2f == 0)
						{
							num2 = 14;
						}
						continue;
					}
					goto case 1;
				case 11:
					defaultName = Name;
					break;
				case 8:
					if (templateSetNameElement.FormingTemplateName)
					{
						num2 = 13;
						continue;
					}
					goto case 16;
				case 24:
					formViewItemTransformation = validator.ProcessForms.Find(_003C_003Ec__DisplayClass0_2._003CValidate_003Eb__0) as IFormViewItemTransformation;
					num2 = 10;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a50dda04dedf4515816f963c67783c8f != 0)
					{
						num2 = 3;
					}
					continue;
				case 1:
					if (SB7PTphurZhh5CXNFbQ(templateSetDescriptionElement))
					{
						num2 = 20;
						continue;
					}
					goto case 14;
				case 14:
				case 26:
					_003C_003Ec__DisplayClass0_2.formElement = this as IElementWithFormConstructorView;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3b4403f77a00495e957e5e4a6840e5d3 != 0)
					{
						num2 = 0;
					}
					continue;
				case 10:
					if (formViewItemTransformation == null)
					{
						num2 = 2;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f91acf223c4b4303819d2f8f2fc6c8e1 != 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 3;
				case 6:
					return;
				case 21:
					return;
				case 7:
					ValidateFormV1(validator, text, (FormViewItemTransformation)RytG7lhWOgLHDtaOeX6(formViewItemTransformation));
					num2 = 21;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 != 0)
					{
						num2 = 25;
					}
					continue;
				case 18:
					templateSetNameElement = this as ITemplateSetNameElement;
					num2 = 12;
					continue;
				case 30:
					_003C_003Ec__DisplayClass0_2 = new _003C_003Ec__DisplayClass0_0();
					num2 = 29;
					continue;
				case 28:
					if (!prJibBhfbP1bTOXYXmL(DqNk5HhLgMmPAQT8Oyw(_003C_003Ec__DisplayClass0_2.formElement), Guid.Empty))
					{
						goto end_IL_0012;
					}
					goto case 24;
				default:
					if (_003C_003Ec__DisplayClass0_2.formElement == null)
					{
						return;
					}
					num2 = 28;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e2e244178c44ea09cd756894b022a62 == 0)
					{
						num2 = 4;
					}
					continue;
				case 5:
					_003C_003Ec__DisplayClass0_.typeName = GDHOkTh9k7rjEaO0Qme(typeof(FormViewItem).TypeHandle).AssemblyQualifiedName;
					num2 = 27;
					continue;
				case 25:
					return;
				case 22:
					if ((workflowTaskForm = formViewItemTransformation as WorkflowTaskForm) == null)
					{
						num2 = 6;
						continue;
					}
					goto case 15;
				case 27:
					_003C_003Ec__DisplayClass0_.runtimeVersionPropertyName = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-935313063 ^ -935257549);
					num2 = 4;
					continue;
				case 3:
					_003C_003Ec__DisplayClass0_ = new _003C_003Ec__DisplayClass0_1();
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_60c5782a184b457aa78da2e5c62d4e27 == 0)
					{
						num2 = 5;
					}
					continue;
				}
				text = defaultName;
				num2 = 7;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f8a84e2cb374827a50ba2cbcf11cf48 == 0)
				{
					num2 = 18;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 23;
		}
	}

	private void ValidateFormV1(WorkflowProcessValidator validator, string elementName, FormViewItemTransformation transformation)
	{
		//Discarded unreachable code: IL_005a, IL_0064, IL_0137, IL_0146, IL_01ea, IL_01fd
		int num = 2;
		int num2 = num;
		List<ViewItemTransformation>.Enumerator enumerator = default(List<ViewItemTransformation>.Enumerator);
		ClassMetadataPartsContainer classMetadataPartsContainer = default(ClassMetadataPartsContainer);
		ViewItemTransformationAdd viewItemTransformationAdd = default(ViewItemTransformationAdd);
		GridViewItem gridViewItem = default(GridViewItem);
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 1:
				enumerator = transformation.Items.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 == 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				return;
			case 2:
				classMetadataPartsContainer = new ClassMetadataPartsContainer(new ClassMetadata[1] { (ClassMetadata)InterfaceActivator.LoadMetadata<IWorkflowTask>(inherit: false, loadImplementation: false) });
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 != 0)
				{
					num2 = 1;
				}
				continue;
			}
			try
			{
				while (true)
				{
					IL_010c:
					int num3;
					if (!enumerator.MoveNext())
					{
						num3 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 != 0)
						{
							num3 = 0;
						}
						goto IL_0068;
					}
					goto IL_00e3;
					IL_00e3:
					viewItemTransformationAdd = enumerator.Current as ViewItemTransformationAdd;
					num3 = 5;
					goto IL_0068;
					IL_0068:
					while (true)
					{
						switch (num3)
						{
						default:
							return;
						case 0:
							return;
						case 8:
							if (gridViewItem != null)
							{
								num3 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ffb1346d351f436b84bb1e9954c3bfa8 == 0)
								{
									num3 = 1;
								}
								continue;
							}
							goto IL_010c;
						case 6:
							X8Zu2NhTZHtRMpwK2N9(validator, this, eQF3Cch3R2lW5WsGDnL(gridViewItem), text, classMetadataPartsContainer);
							num3 = 7;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b == 0)
							{
								num3 = 3;
							}
							continue;
						case 2:
							break;
						case 5:
							if (viewItemTransformationAdd == null)
							{
								num3 = 3;
								continue;
							}
							goto case 4;
						case 3:
						case 7:
							goto IL_010c;
						case 4:
							gridViewItem = CwQaDDhqDP8drEqxTAV(viewItemTransformationAdd) as GridViewItem;
							num3 = 8;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_978f838cc41a4debb9700ede4b63f820 == 0)
							{
								num3 = 7;
							}
							continue;
						case 1:
							text = (string)WnWqy8hnhZdfHZGC3eR(HPZJVMhdRBkrYbPNWeS(-1647793954 ^ -1647709386), new object[2] { elementName, gridViewItem.Name });
							num3 = 6;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f8a84e2cb374827a50ba2cbcf11cf48 == 0)
							{
								num3 = 6;
							}
							continue;
						}
						break;
					}
					goto IL_00e3;
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
		}
	}

	private void ValidateFormV2(WorkflowProcessValidator validator, string elementName, FormViewItem formViewItem)
	{
		//Discarded unreachable code: IL_00b7, IL_00c6, IL_011d, IL_0155, IL_018d, IL_019c
		int num = 14;
		List<ValidationError> list = default(List<ValidationError>);
		ProcessValidationMessage processValidationMessage = default(ProcessValidationMessage);
		GridViewItem[] array = default(GridViewItem[]);
		int num3 = default(int);
		DataClassMetadata dataClassMetadata = default(DataClassMetadata);
		MetadataServiceContext metadataServiceContext = default(MetadataServiceContext);
		ISearchMetadataService serviceNotNull = default(ISearchMetadataService);
		GridViewItem gridViewItem = default(GridViewItem);
		string text = default(string);
		ClassMetadataPartsContainer classMetadataPartsContainer = default(ClassMetadataPartsContainer);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (xw7VKihU7sCLLru7p13(list) == 0)
					{
						num2 = 15;
						continue;
					}
					processValidationMessage = (ProcessValidationMessage)TcTJj3h6xfP9dVUgt8E(ValidationHelper, q0aP9ChVXGtNFifd7Cb(HPZJVMhdRBkrYbPNWeS(-1647793954 ^ -1647708730)));
					num2 = 12;
					continue;
				case 11:
					validator.Messages.Add(processValidationMessage);
					num = 5;
					break;
				case 13:
					array = formViewItem.GetAllItems(ignoreHide: false).OfType<GridViewItem>().ToArray();
					num2 = 6;
					continue;
				case 6:
					num3 = 0;
					num2 = 10;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 == 0)
					{
						num2 = 6;
					}
					continue;
				case 17:
					try
					{
						list.AddRange(CheckComponentHelper.CheckComponentViewItems(formViewItem, ufLQhshMMpbT76DP4t0(dataClassMetadata)));
						int num4 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f91acf223c4b4303819d2f8f2fc6c8e1 != 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
					finally
					{
						if (metadataServiceContext != null)
						{
							int num5 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ac5d16a577a84bb0b8ee3654769d2d33 == 0)
							{
								num5 = 1;
							}
							while (true)
							{
								switch (num5)
								{
								case 1:
									Re25gMhksHwadGHqRNE(metadataServiceContext);
									num5 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f2d402219199402696ade21eab23d086 != 0)
									{
										num5 = 0;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
						}
					}
					goto case 2;
				case 5:
					return;
				case 14:
					dataClassMetadata = (DataClassMetadata)mN9abchpMPMvTR3eIaV(XTfqMNhQ3l1qiJ6TCDK(validator.Process));
					num2 = 13;
					continue;
				case 12:
					processValidationMessage.ValidationErrors = (ValidationError[])lIpMhfhAJQeMINrymCK(list);
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 != 0)
					{
						num2 = 11;
					}
					continue;
				case 3:
					serviceNotNull = Locator.GetServiceNotNull<ISearchMetadataService>();
					num2 = 9;
					continue;
				case 1:
					gridViewItem = array[num3];
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_85ba8d91af394836ac86666c40b1e150 != 0)
					{
						num2 = 0;
					}
					continue;
				case 15:
					return;
				case 8:
				case 10:
					if (num3 >= array.Length)
					{
						num2 = 2;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9570b4a70465495fba22c942f586465a != 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 1;
				case 7:
					text = (string)WnWqy8hnhZdfHZGC3eR(HPZJVMhdRBkrYbPNWeS(-1498811449 ^ -1498896337), new object[2]
					{
						elementName,
						K1d61HhCaJ6exo6fahT(gridViewItem)
					});
					num2 = 16;
					continue;
				case 4:
					num3++;
					num2 = 8;
					continue;
				case 9:
				{
					IEnumerable<IMetadata> metadataList = serviceNotNull.GetPublishedDataClasses().ToList().Concat<IMetadata>(serviceNotNull.GetPublishedFunctions())
						.Concat(serviceNotNull.GetPublishedComponents());
					list = new List<ValidationError>();
					metadataServiceContext = MetadataServiceContext.Extend(metadataList);
					num2 = 17;
					continue;
				}
				default:
					classMetadataPartsContainer = new ClassMetadataPartsContainer(new DataClassMetadata[1] { dataClassMetadata });
					num = 7;
					break;
				case 16:
					X8Zu2NhTZHtRMpwK2N9(validator, this, eQF3Cch3R2lW5WsGDnL(gridViewItem), text, classMetadataPartsContainer);
					num2 = 4;
					continue;
				}
				break;
			}
		}
	}

	public ValidatableElement2D()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object v3cyPnhcOUgNiKbXfM9(object P_0)
	{
		return ((Element)P_0).Name;
	}

	internal static bool b01TRjhPwpucvWtTl8M(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object g0pG63hXJdnVbICRgiA(object P_0)
	{
		return ((ITemplateSetNameElement)P_0).TemplateName;
	}

	internal static object HPZJVMhdRBkrYbPNWeS(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool SB7PTphurZhh5CXNFbQ(object P_0)
	{
		return ((ITemplateSetDescriptionElement)P_0).FormingTemplateDescription;
	}

	internal static object X5yBechDaXteNaNCRbY(object P_0)
	{
		return ((Element)P_0).Description;
	}

	internal static object WnWqy8hnhZdfHZGC3eR(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static void jwGCu5hH1KVpI9hYqmv(object P_0, object P_1, object P_2, object P_3)
	{
		((WorkflowProcessValidator)P_0).ValidateTemplate(P_1, (string)P_2, (string)P_3);
	}

	internal static Guid DqNk5HhLgMmPAQT8Oyw(object P_0)
	{
		return ((IElementWithFormConstructorView)P_0).FormUid;
	}

	internal static bool prJibBhfbP1bTOXYXmL(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static Type GDHOkTh9k7rjEaO0Qme(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object RytG7lhWOgLHDtaOeX6(object P_0)
	{
		return ((IFormViewItemTransformation)P_0).Transformation;
	}

	internal static object kW8cc7hjJg13mn1Io8c(object P_0)
	{
		return ((WorkflowProcessValidator)P_0).Process;
	}

	internal static object CRGouEhRu8DWvJwwKkd(object P_0, object P_1)
	{
		return ((WorkflowForm)P_0).CreateFormViewItem((WorkflowProcessDTO)P_1);
	}

	internal static object TcTJj3h6xfP9dVUgt8E(object P_0, object P_1)
	{
		return ((ElementValidationHelper)P_0).CreateValidationError((string)P_1);
	}

	internal static bool zwgH8Chg7fmLYy0pWHx()
	{
		return GpSLYAh5W61liLuY5So == null;
	}

	internal static ValidatableElement2D HcfvlohBb6sIFYElAkq()
	{
		return GpSLYAh5W61liLuY5So;
	}

	internal static object CwQaDDhqDP8drEqxTAV(object P_0)
	{
		return ((ViewItemTransformationAdd)P_0).Item;
	}

	internal static object eQF3Cch3R2lW5WsGDnL(object P_0)
	{
		return ((GridViewItem)P_0).Query;
	}

	internal static void X8Zu2NhTZHtRMpwK2N9(object P_0, object P_1, object P_2, object P_3, object P_4)
	{
		((WorkflowProcessValidator)P_0).ValidateTemplate(P_1, (string)P_2, (string)P_3, (ClassMetadataPartsContainer)P_4);
	}

	internal static object XTfqMNhQ3l1qiJ6TCDK(object P_0)
	{
		return ((WorkflowProcessDTO)P_0).Context;
	}

	internal static object mN9abchpMPMvTR3eIaV(object P_0)
	{
		return ((EntityMetadata)P_0).ViewModelMetadata;
	}

	internal static object K1d61HhCaJ6exo6fahT(object P_0)
	{
		return ((ViewItem)P_0).Name;
	}

	internal static Guid ufLQhshMMpbT76DP4t0(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static void Re25gMhksHwadGHqRNE(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static int xw7VKihU7sCLLru7p13(object P_0)
	{
		return ((List<ValidationError>)P_0).Count;
	}

	internal static object q0aP9ChVXGtNFifd7Cb(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object lIpMhfhAJQeMINrymCK(object P_0)
	{
		return ((List<ValidationError>)P_0).ToArray();
	}
}
