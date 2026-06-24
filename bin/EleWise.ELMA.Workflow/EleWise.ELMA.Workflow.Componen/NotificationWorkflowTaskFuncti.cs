using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Web;
using EleWise.ELMA.Collections;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Notifications.Impl.TemplateGenerator;
using EleWise.ELMA.Runtime.Settings;
using EleWise.ELMA.Services;
using EleWise.ELMA.Templates;
using EleWise.ELMA.Templates.TemplateGenerator;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Connectors;
using EleWise.ELMA.Workflow.Models;
using EleWise.TemplateGenerator;
using EleWise.TemplateGenerator.Formats;
using EleWise.TemplateGenerator.Functions;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Util;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Components;

[Component]
public class NotificationWorkflowTaskFunctions : INotificationFunctions
{
	private struct TaskField
	{
		internal static object npFW8NvK5XKUhUUPof63;

		public string Id => (string)B2tmZ3vKc7rIEnJ1Lprx(PropertyMetadata);

		public string Name => PropertyMetadata.DisplayName;

		public string Description => (string)ojX6sjvKPs9SqKKY19LQ(PropertyMetadata);

		public object Value
		{
			[CompilerGenerated]
			get
			{
				return _003CValue_003Ek__BackingField;
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
						_003CValue_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public bool ReadOnly
		{
			get
			{
				//Discarded unreachable code: IL_0061, IL_0070
				int num = 2;
				int num2 = num;
				bool? readOnly = default(bool?);
				while (true)
				{
					switch (num2)
					{
					case 1:
						if (readOnly.HasValue)
						{
							num2 = 3;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6fe3beca34a9422e873cd6ef331760ae != 0)
							{
								num2 = 0;
							}
							break;
						}
						goto default;
					default:
						return false;
					case 3:
						return readOnly.GetValueOrDefault();
					case 2:
						readOnly = ((ViewAttributes)Alt4LjvKXfAcYt4VoSQX(ViewItem)).ReadOnly;
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f05298ca2a4a4a639a58bc7f7d9ff7b9 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public bool Required => GXcvtbvKdRYWT8m2IQgO(ViewItem.Attributes);

		public PropertyViewItem ViewItem
		{
			[CompilerGenerated]
			get
			{
				return _003CViewItem_003Ek__BackingField;
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
						_003CViewItem_003Ek__BackingField = value;
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

		public IPropertyMetadata PropertyMetadata
		{
			[CompilerGenerated]
			get
			{
				return _003CPropertyMetadata_003Ek__BackingField;
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
						_003CPropertyMetadata_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		internal static object B2tmZ3vKc7rIEnJ1Lprx(object P_0)
		{
			return ((IPropertyMetadata)P_0).Name;
		}

		internal static bool hC1NErvKgohmC05cbobF()
		{
			return npFW8NvK5XKUhUUPof63 == null;
		}

		internal static object NAMCLKvKByFA3jRDjItb()
		{
			return npFW8NvK5XKUhUUPof63;
		}

		internal static object ojX6sjvKPs9SqKKY19LQ(object P_0)
		{
			return ((INamedMetadata)P_0).Description;
		}

		internal static object Alt4LjvKXfAcYt4VoSQX(object P_0)
		{
			return ((PropertyViewItem)P_0).Attributes;
		}

		internal static bool GXcvtbvKdRYWT8m2IQgO(object P_0)
		{
			return ((ViewAttributes)P_0).Required;
		}
	}

	private struct TaskButton
	{
		internal static object MP5CVdvKuyLnP1S9gyvT;

		public string Id
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
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a9be7e056b4e4b6e863b634c418144f1 == 0)
						{
							num2 = 0;
						}
						break;
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
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b == 0)
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
					case 0:
						return;
					case 1:
						_003CDescription_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f33560c5d18b4e10b24a458578aa60fd == 0)
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
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public string FontColor
		{
			[CompilerGenerated]
			get
			{
				return _003CFontColor_003Ek__BackingField;
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
						_003CFontColor_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c7fe5d092d804f7e91041fb2338cec1a == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		internal static bool FkiH4SvKD4sWXRl8Vvxk()
		{
			return MP5CVdvKuyLnP1S9gyvT == null;
		}

		internal static object EIT5gcvKnl3Lq85rWHpY()
		{
			return MP5CVdvKuyLnP1S9gyvT;
		}
	}

	private static NotificationWorkflowTaskFunctions ChprWLOJXoVoYKhJkUdb;

	public static FormatedValue WorkflowTaskFields(FunctionEvaluationContext context)
	{
		int num = 1;
		int num2 = num;
		long taskId = default(long);
		string executeUrl = default(string);
		TaskField[] taskFields = default(TaskField[]);
		while (true)
		{
			switch (num2)
			{
			default:
				return (FormatedValue)yr1MxNOJDHph6NgdHqBk(context, taskId, executeUrl, taskFields);
			case 1:
				ExtractFields(context, out taskId, out executeUrl, out taskFields);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static FormatedValue WorkflowTaskButtons(FunctionEvaluationContext context)
	{
		int num = 1;
		int num2 = num;
		long taskId = default(long);
		string executeUrl = default(string);
		TaskButton[] taskButtons = default(TaskButton[]);
		while (true)
		{
			switch (num2)
			{
			default:
				return (FormatedValue)s3jJi6OJn7Dcmo8duTsI(context, taskId, executeUrl, taskButtons);
			case 1:
				ExtractButtons(context, out taskId, out executeUrl, out taskButtons);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a50dda04dedf4515816f963c67783c8f == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private static FormatedValue GenerateWorkflowTaskFields(object context, long taskId, object executeUrl, object taskFields)
	{
		//Discarded unreachable code: IL_0142, IL_0237, IL_02c2, IL_0336, IL_03da
		int num = 11;
		StringBuilder stringBuilder = default(StringBuilder);
		int num4 = default(int);
		TaskField taskField = default(TaskField);
		TaskField[] array = default(TaskField[]);
		IMetadataRuntimeService serviceNotNull = default(IMetadataRuntimeService);
		string text2 = default(string);
		string link = default(string);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 6:
					stringBuilder.Append((string)Y85w7uOJWWmAeIrTv91K(-106528299 ^ -106488007));
					num2 = 14;
					continue;
				case 9:
					num4++;
					num2 = 23;
					continue;
				case 28:
					dZ6c4cOJRIB8voHckcdI(stringBuilder, Y85w7uOJWWmAeIrTv91K(0x6CC04061 ^ 0x6CC1E0C7));
					num2 = 25;
					continue;
				case 22:
					if (eNXvbQOJqVsudvLsHLo6(taskField.Description))
					{
						num2 = 18;
						continue;
					}
					goto case 17;
				case 15:
					dZ6c4cOJRIB8voHckcdI(stringBuilder, taskField.Name);
					num2 = 23;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e4c570270f54493d8f3f4763a72f63f7 == 0)
					{
						num2 = 27;
					}
					continue;
				case 16:
					obj = "";
					goto IL_048a;
				case 19:
					dZ6c4cOJRIB8voHckcdI(stringBuilder, Y85w7uOJWWmAeIrTv91K(-10408775 ^ -10449699));
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c447ffb64be44c09b6fd398df506785b == 0)
					{
						num2 = 12;
					}
					continue;
				case 4:
				case 5:
					taskField = array[num4];
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 != 0)
					{
						num2 = 2;
					}
					continue;
				case 7:
					array = (TaskField[])taskFields;
					num2 = 8;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f91acf223c4b4303819d2f8f2fc6c8e1 != 0)
					{
						num2 = 8;
					}
					continue;
				case 20:
					return new FormatedValue(new HtmlString(stringBuilder.ToString()));
				case 27:
					if (taskField.Required)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_abfb511163674a3eae959fd60da8f319 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 19;
				case 12:
					dZ6c4cOJRIB8voHckcdI(stringBuilder, Y85w7uOJWWmAeIrTv91K(-1542190822 ^ -1542084248));
					num2 = 24;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_26fa47f5bd8343debcae8b05a56a3ab5 != 0)
					{
						num2 = 28;
					}
					continue;
				case 10:
					serviceNotNull = Locator.GetServiceNotNull<IMetadataRuntimeService>();
					num2 = 7;
					continue;
				case 17:
					stringBuilder.Append((string)fkYQxkOJjVcRdnhu8E18(Y85w7uOJWWmAeIrTv91K(0x213F6477 ^ 0x213EC6CD), taskField.Description));
					num2 = 21;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_08023922bb0e4e809e5cff73a2b04988 != 0)
					{
						num2 = 21;
					}
					continue;
				case 2:
					if (!IsHiddenTaskField(serviceNotNull, taskField))
					{
						num2 = 6;
						continue;
					}
					goto case 9;
				case 3:
				case 23:
					if (num4 < array.Length)
					{
						num2 = 5;
						continue;
					}
					goto case 20;
				case 24:
					stringBuilder.Append((string)fkYQxkOJjVcRdnhu8E18(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2269BD32 ^ 0x22682212), text2));
					num = 15;
					break;
				case 13:
					ugivx3OJ3qEAW5GkF2mP(stringBuilder, Y85w7uOJWWmAeIrTv91K(0x1843E01F ^ 0x18424343));
					num2 = 9;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c447ffb64be44c09b6fd398df506785b != 0)
					{
						num2 = 2;
					}
					continue;
				default:
					dZ6c4cOJRIB8voHckcdI(stringBuilder, Y85w7uOJWWmAeIrTv91K(0xD305CC2 ^ 0xD31FCEE));
					num = 19;
					break;
				case 29:
					dZ6c4cOJRIB8voHckcdI(stringBuilder, GenerateBlockOrField(context, taskField.Value, link, taskField.PropertyMetadata, !taskField.ReadOnly));
					num = 22;
					break;
				case 8:
					num4 = 0;
					num2 = 3;
					continue;
				case 18:
				case 21:
					dZ6c4cOJRIB8voHckcdI(stringBuilder, Y85w7uOJWWmAeIrTv91K(0x6C7F14 ^ 0x6DDF70));
					num2 = 13;
					continue;
				case 26:
					if (taskField.Required)
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7de614af35034bd0a6867d08a2ee4a84 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 16;
				case 14:
					if (!string.IsNullOrEmpty(taskField.Name))
					{
						num2 = 26;
						continue;
					}
					goto case 12;
				case 11:
				{
					TemplateRenderMode num3 = of1mn0OJLhQyY5EjlMcM(sBT3v1OJHJKjpGwewcIT(context));
					text = "";
					if (loWxAUOJfYAnDR7NeeVc())
					{
						CommonSettingsModule service = Locator.GetService<CommonSettingsModule>();
						if (service != null)
						{
							text = (string)O70LQpOJ9KRQyE5GAadF(service.Settings);
						}
					}
					stringBuilder = new StringBuilder();
					if (num3 == TemplateRenderMode.HTML)
					{
						num2 = 10;
						continue;
					}
					goto case 20;
				}
				case 1:
					obj = Y85w7uOJWWmAeIrTv91K(0x438A0E43 ^ 0x438B90BB);
					goto IL_048a;
				case 25:
					{
						link = (string)coP9eiOJ6jCZSOAlvfVJ(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638225214 ^ -1638200432), new object[5]
						{
							text,
							taskId,
							taskField.Id,
							taskField.ReadOnly ? SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1386448964 ^ -1386359536) : Y85w7uOJWWmAeIrTv91K(0x46EA3D1 ^ 0x46F014B),
							executeUrl
						});
						num2 = 29;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a == 0)
						{
							num2 = 2;
						}
						continue;
					}
					IL_048a:
					text2 = (string)obj;
					num2 = 24;
					continue;
				}
				break;
			}
		}
	}

	private static string GenerateBlockOrField(object context, object taskFieldValue, object link, object propeertyMetadata, bool input = false)
	{
		//Discarded unreachable code: IL_00d3, IL_00e2, IL_0116, IL_016f, IL_0239, IL_0248, IL_0253, IL_0341, IL_0381, IL_0390, IL_039c, IL_03ab, IL_03bb, IL_03ce, IL_03dd, IL_04e7, IL_04f6, IL_054c, IL_0556, IL_067f, IL_0692, IL_06a1, IL_06ea, IL_06f8, IL_0807, IL_081a, IL_0829, IL_08cc, IL_08eb, IL_0917, IL_09f2, IL_0a01
		int num = 1;
		StringBuilder stringBuilder = default(StringBuilder);
		string text = default(string);
		List<TablePartMetadata> list2 = default(List<TablePartMetadata>);
		EntityMetadata entityMetadata = default(EntityMetadata);
		object obj = default(object);
		IEnumerator<WorkflowEntity> enumerator2 = default(IEnumerator<WorkflowEntity>);
		IInheritedSet inheritedSet = default(IInheritedSet);
		IEnumerator<string> enumerator = default(IEnumerator<string>);
		string current4 = default(string);
		MetadataBasedValue metadataBasedValue = default(MetadataBasedValue);
		List<PropertyMetadata> list = default(List<PropertyMetadata>);
		List<PropertyMetadata>.Enumerator enumerator4 = default(List<PropertyMetadata>.Enumerator);
		PropertyMetadata current3 = default(PropertyMetadata);
		WorkflowEntity current2 = default(WorkflowEntity);
		List<TablePartMetadata>.Enumerator enumerator3 = default(List<TablePartMetadata>.Enumerator);
		TablePartMetadata current = default(TablePartMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
					dZ6c4cOJRIB8voHckcdI(stringBuilder, Y85w7uOJWWmAeIrTv91K(-1716458555 ^ -1716432943));
					num2 = 21;
					continue;
				case 17:
					dZ6c4cOJRIB8voHckcdI(stringBuilder, text);
					num2 = 8;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7de614af35034bd0a6867d08a2ee4a84 == 0)
					{
						num2 = 13;
					}
					continue;
				case 20:
					stringBuilder.Append((string)Y85w7uOJWWmAeIrTv91K(0x8D5763A ^ 0x8D4D21E));
					num2 = 30;
					continue;
				case 32:
					list2 = entityMetadata.TableParts;
					num2 = 29;
					continue;
				case 35:
					if (obj == null)
					{
						num2 = 27;
						continue;
					}
					goto case 26;
				case 2:
					dZ6c4cOJRIB8voHckcdI(stringBuilder, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xDF4D1F8 ^ 0xDF572A4));
					num2 = 34;
					continue;
				case 4:
					if (entityMetadata != null)
					{
						num = 14;
						break;
					}
					goto case 27;
				case 21:
					if (string.IsNullOrEmpty((string)link))
					{
						num2 = 31;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a == 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 20;
				case 13:
					if (input)
					{
						num2 = 7;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 21;
				case 6:
					if (eNXvbQOJqVsudvLsHLo6(link))
					{
						num2 = 9;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6b089b0d02ae4d3186c8d2cb8a24d4d3 == 0)
						{
							num2 = 33;
						}
						continue;
					}
					goto case 28;
				case 34:
					enumerator2 = inheritedSet.OfType<WorkflowEntity>().GetEnumerator();
					num2 = 3;
					continue;
				case 24:
					try
					{
						while (true)
						{
							IL_0279:
							int num10;
							if (!enumerator.MoveNext())
							{
								num10 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_978f838cc41a4debb9700ede4b63f820 != 0)
								{
									num10 = 0;
								}
								goto IL_0257;
							}
							goto IL_02c2;
							IL_02c2:
							current4 = enumerator.Current;
							num10 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f453500aaab143479696408f48a03c17 != 0)
							{
								num10 = 0;
							}
							goto IL_0257;
							IL_0257:
							while (true)
							{
								switch (num10)
								{
								case 5:
									goto IL_0279;
								case 1:
									dZ6c4cOJRIB8voHckcdI(stringBuilder, Y85w7uOJWWmAeIrTv91K(0x74AB4717 ^ 0x74AAE3F1));
									num10 = 4;
									continue;
								case 3:
									goto IL_02c2;
								case 4:
									dZ6c4cOJRIB8voHckcdI(stringBuilder, current4);
									num10 = 2;
									continue;
								case 2:
									dZ6c4cOJRIB8voHckcdI(stringBuilder, Y85w7uOJWWmAeIrTv91K(-1647793954 ^ -1647767976));
									num10 = 5;
									continue;
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
						int num11;
						if (enumerator == null)
						{
							num11 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6fe3beca34a9422e873cd6ef331760ae != 0)
							{
								num11 = 0;
							}
							goto IL_0345;
						}
						goto IL_035b;
						IL_035b:
						enumerator.Dispose();
						num11 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1c37d4e24e094858975336738e156495 != 0)
						{
							num11 = 2;
						}
						goto IL_0345;
						IL_0345:
						switch (num11)
						{
						default:
							goto end_IL_0320;
						case 1:
							break;
						case 0:
							goto end_IL_0320;
						case 2:
							goto end_IL_0320;
						}
						goto IL_035b;
						end_IL_0320:;
					}
					goto case 2;
				case 9:
					list2 = new List<TablePartMetadata>();
					num2 = 35;
					continue;
				case 18:
				case 19:
					if (JKgUvUOJkk1UanvE8ak2(inheritedSet))
					{
						num = 5;
						break;
					}
					goto case 11;
				case 12:
				{
					MetadataBasedValue metadataBasedValue2 = new MetadataBasedValue();
					Thbgc8OJTr0fjogRLNwf(metadataBasedValue2, taskFieldValue);
					MetadataBasedFormat metadataBasedFormat = new MetadataBasedFormat();
					jq6mdoOJQrvv28sirrPO(metadataBasedFormat, propeertyMetadata as PropertyMetadata);
					chxMZnOJpxR6ZIs2al7c(metadataBasedValue2, metadataBasedFormat);
					metadataBasedValue = metadataBasedValue2;
					num2 = 9;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a23e27b648a042f098a477c26c4beed1 != 0)
					{
						num2 = 10;
					}
					continue;
				}
				case 11:
					return string.Empty;
				case 5:
					obj = yghuWqOJUFbgMoCUFtfB(inheritedSet);
					num2 = 7;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 == 0)
					{
						num2 = 8;
					}
					continue;
				case 16:
				case 33:
					if (input)
					{
						num2 = 23;
						continue;
					}
					goto case 17;
				case 8:
					list = new List<PropertyMetadata>();
					num2 = 9;
					continue;
				case 28:
					dZ6c4cOJRIB8voHckcdI(stringBuilder, link);
					num2 = 16;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 == 0)
					{
						num2 = 5;
					}
					continue;
				case 1:
					stringBuilder = new StringBuilder();
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					try
					{
						while (true)
						{
							int num3;
							if (!hxBL9JOJ7NQCsnAZvOw9(enumerator2))
							{
								num3 = 6;
								goto IL_0505;
							}
							goto IL_0883;
							IL_0505:
							while (true)
							{
								switch (num3)
								{
								default:
									enumerator4 = list.GetEnumerator();
									num3 = 8;
									continue;
								case 8:
									try
									{
										while (true)
										{
											IL_060b:
											int num6;
											if (!enumerator4.MoveNext())
											{
												num6 = 4;
												if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6fe3beca34a9422e873cd6ef331760ae != 0)
												{
													num6 = 1;
												}
												goto IL_055a;
											}
											goto IL_057c;
											IL_057c:
											current3 = enumerator4.Current;
											num6 = 1;
											if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ffb1346d351f436b84bb1e9954c3bfa8 == 0)
											{
												num6 = 1;
											}
											goto IL_055a;
											IL_055a:
											while (true)
											{
												switch (num6)
												{
												case 5:
													break;
												default:
													stringBuilder.Append(GenerateBlockOrField(context, Tu7YPXOJAS3KeWwBsPsn(current2, UPFgpZOJV0J0NdwhIMwq(current3)), null, current3));
													num6 = 3;
													if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cb262bcfe4074a1ab16e653815d57f28 == 0)
													{
														num6 = 2;
													}
													continue;
												case 1:
													dZ6c4cOJRIB8voHckcdI(stringBuilder, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6871CA ^ 0x69D75E));
													num6 = 0;
													if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3bb28bf622874b4689f9265e58d14823 == 0)
													{
														num6 = 0;
													}
													continue;
												case 2:
													goto IL_060b;
												case 3:
													stringBuilder.Append((string)Y85w7uOJWWmAeIrTv91K(-2002063381 ^ -2002038897));
													num6 = 2;
													continue;
												case 4:
													goto end_IL_060b;
												}
												break;
											}
											goto IL_057c;
											continue;
											end_IL_060b:
											break;
										}
									}
									finally
									{
										((IDisposable)enumerator4).Dispose();
										int num7 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b84ccb8b1bd147ef900b852047ecbf45 != 0)
										{
											num7 = 0;
										}
										switch (num7)
										{
										case 0:
											break;
										}
									}
									goto case 7;
								case 4:
									dZ6c4cOJRIB8voHckcdI(stringBuilder, Y85w7uOJWWmAeIrTv91K(-682910880 ^ -683014772));
									num3 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd == 0)
									{
										num3 = 0;
									}
									continue;
								case 5:
									try
									{
										while (true)
										{
											IL_076a:
											int num4;
											if (!enumerator3.MoveNext())
											{
												num4 = 0;
												if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e != 0)
												{
													num4 = 0;
												}
												goto IL_06fc;
											}
											goto IL_0790;
											IL_0790:
											current = enumerator3.Current;
											num4 = 3;
											goto IL_06fc;
											IL_06fc:
											while (true)
											{
												switch (num4)
												{
												case 3:
													dZ6c4cOJRIB8voHckcdI(stringBuilder, Y85w7uOJWWmAeIrTv91K(0x8D5763A ^ 0x8D4D0AE));
													num4 = 5;
													continue;
												case 5:
													dZ6c4cOJRIB8voHckcdI(stringBuilder, GenerateBlockOrField(context, Tu7YPXOJAS3KeWwBsPsn(current2, LrOrUeOJGCvLRBTt5s5n(current)), null, current));
													num4 = 4;
													continue;
												case 1:
													goto IL_076a;
												case 2:
													goto IL_0790;
												case 4:
													dZ6c4cOJRIB8voHckcdI(stringBuilder, Y85w7uOJWWmAeIrTv91K(0x350C0E8 ^ 0x351608C));
													num4 = 0;
													if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede != 0)
													{
														num4 = 1;
													}
													continue;
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
										((IDisposable)enumerator3).Dispose();
										int num5 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b876fa7b083748c8abf8c4b192a11078 != 0)
										{
											num5 = 0;
										}
										switch (num5)
										{
										case 0:
											break;
										}
									}
									goto case 3;
								case 7:
								{
									enumerator3 = list2.GetEnumerator();
									int num8 = 5;
									num3 = num8;
									continue;
								}
								case 2:
									break;
								case 3:
									dZ6c4cOJRIB8voHckcdI(stringBuilder, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3C1FFB55 ^ 0x3C1E5809));
									num3 = 2;
									continue;
								case 1:
									goto IL_0883;
								case 6:
									goto end_IL_084b;
								}
								break;
							}
							continue;
							IL_0883:
							current2 = enumerator2.Current;
							num3 = 2;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f453500aaab143479696408f48a03c17 == 0)
							{
								num3 = 4;
							}
							goto IL_0505;
							continue;
							end_IL_084b:
							break;
						}
					}
					finally
					{
						int num9;
						if (enumerator2 == null)
						{
							num9 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8a6cf36da0b84f319a7cf27018f28f5b != 0)
							{
								num9 = 0;
							}
							goto IL_08d0;
						}
						goto IL_08f5;
						IL_08f5:
						eXupvNOJ2O09jf01tVAT(enumerator2);
						num9 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_639c11c7bb65456db9f29c9c42f28bf7 == 0)
						{
							num9 = 1;
						}
						goto IL_08d0;
						IL_08d0:
						switch (num9)
						{
						default:
							goto end_IL_08ab;
						case 0:
							goto end_IL_08ab;
						case 2:
							break;
						case 1:
							goto end_IL_08ab;
						}
						goto IL_08f5;
						end_IL_08ab:;
					}
					goto case 15;
				case 10:
					text = (string)XbQgxwOJM3lZdp0ut2xf(lkZTwGOJCtFqcZtwO6DA(sBT3v1OJHJKjpGwewcIT(context)), metadataBasedValue);
					num2 = 6;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f2d402219199402696ade21eab23d086 == 0)
					{
						num2 = 1;
					}
					continue;
				case 26:
					entityMetadata = MetadataLoader.LoadMetadata(obj.GetType()) as EntityMetadata;
					num2 = 4;
					continue;
				case 25:
				case 30:
				case 31:
					return stringBuilder.ToString();
				case 23:
					dZ6c4cOJRIB8voHckcdI(stringBuilder, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x74AB4717 ^ 0x74AAE47D));
					num2 = 9;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c7fe5d092d804f7e91041fb2338cec1a == 0)
					{
						num2 = 17;
					}
					continue;
				case 15:
					dZ6c4cOJRIB8voHckcdI(stringBuilder, Y85w7uOJWWmAeIrTv91K(-684210684 ^ -684302070));
					num2 = 25;
					continue;
				case 22:
					if (inheritedSet != null)
					{
						num2 = 18;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_46e05b4e09174e34a9c81741b8b77a2f != 0)
						{
							num2 = 15;
						}
						continue;
					}
					goto case 12;
				default:
					inheritedSet = taskFieldValue as IInheritedSet;
					num2 = 6;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c447ffb64be44c09b6fd398df506785b == 0)
					{
						num2 = 22;
					}
					continue;
				case 14:
					list = entityMetadata.Properties.Where((PropertyMetadata p) => !p.IsSystem).ToList();
					num2 = 32;
					continue;
				case 27:
				case 29:
				{
					IEnumerable<string> enumerable = list.Select((PropertyMetadata it) => (string)_003C_003Ec.nKYhiYvKWhMZFQvGyNDR(it)).Union(list2.Select((TablePartMetadata it) => (string)_003C_003Ec.nKYhiYvKWhMZFQvGyNDR(it)));
					dZ6c4cOJRIB8voHckcdI(stringBuilder, Y85w7uOJWWmAeIrTv91K(0x614CF569 ^ 0x614D5159));
					stringBuilder.Append((string)Y85w7uOJWWmAeIrTv91K(0x3C1FFB55 ^ 0x3C1E65B9));
					enumerator = enumerable.GetEnumerator();
					num2 = 15;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1b8b735647da470aa2d45d64d6f538d1 != 0)
					{
						num2 = 24;
					}
					continue;
				}
				}
				break;
			}
		}
	}

	private static FormatedValue GenerateWorkflowTaskButtons(object context, long taskId, object executeUrl, object taskButtons)
	{
		//Discarded unreachable code: IL_0045, IL_008f
		int num = 8;
		StringBuilder stringBuilder = default(StringBuilder);
		int num4 = default(int);
		string text2 = default(string);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					return new FormatedValue(new HtmlString(stringBuilder.ToString()));
				case 4:
					num4++;
					num2 = 2;
					break;
				case 1:
				case 2:
					if (num4 < ((Array)taskButtons).Length)
					{
						goto end_IL_0012;
					}
					goto case 6;
				default:
					dZ6c4cOJRIB8voHckcdI(stringBuilder, coP9eiOJ6jCZSOAlvfVJ(Y85w7uOJWWmAeIrTv91K(0x56A753C9 ^ 0x56A6F44B), new object[5]
					{
						text2,
						((TaskButton[])taskButtons)[num4].Name,
						((TaskButton[])taskButtons)[num4].Description,
						((TaskButton[])taskButtons)[num4].Color,
						((TaskButton[])taskButtons)[num4].FontColor
					}));
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 != 0)
					{
						num2 = 4;
					}
					break;
				case 7:
					num4 = 0;
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1a2d7634479d44fb8d3718c31b05f73c == 0)
					{
						num2 = 1;
					}
					break;
				case 3:
				case 5:
					text2 = (string)coP9eiOJ6jCZSOAlvfVJ(Y85w7uOJWWmAeIrTv91K(0x5F800F5B ^ 0x5F81A869), new object[4]
					{
						text,
						executeUrl,
						taskId,
						((TaskButton[])taskButtons)[num4].Id
					});
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d843b0b7f23e489fb6d586d64b0a634a == 0)
					{
						num2 = 0;
					}
					break;
				case 8:
				{
					TemplateRenderMode num3 = of1mn0OJLhQyY5EjlMcM(sBT3v1OJHJKjpGwewcIT(context));
					text = "";
					if (Locator.Initialized)
					{
						CommonSettingsModule service = Locator.GetService<CommonSettingsModule>();
						if (service != null)
						{
							text = (string)O70LQpOJ9KRQyE5GAadF(service.Settings);
						}
					}
					stringBuilder = new StringBuilder();
					if (num3 == TemplateRenderMode.HTML)
					{
						num2 = 7;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 6;
				}
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 3;
		}
	}

	private static void ExtractFields(object context, out long taskId, out string executeUrl, out TaskField[] taskFields)
	{
		//Discarded unreachable code: IL_00e0, IL_00f0, IL_00ff, IL_022e, IL_026e, IL_027d, IL_0289, IL_02ae, IL_0312, IL_048f, IL_049e
		int num = 1;
		IElementWithView elementWithView = default(IElementWithView);
		List<TaskField> list = default(List<TaskField>);
		IEnumerator<PropertyViewItem> enumerator = default(IEnumerator<PropertyViewItem>);
		_003C_003Ec__DisplayClass8_0 _003C_003Ec__DisplayClass8_ = default(_003C_003Ec__DisplayClass8_0);
		FormatedValue formatedValue2 = default(FormatedValue);
		_003C_003Ec__DisplayClass8_1 _003C_003Ec__DisplayClass8_2 = default(_003C_003Ec__DisplayClass8_1);
		IPropertyMetadata propertyMetadata = default(IPropertyMetadata);
		List<IPropertyMetadata> propertiesAndTableParts = default(List<IPropertyMetadata>);
		FormatedValue formatedValue = default(FormatedValue);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				object obj2;
				switch (num2)
				{
				case 3:
				{
					if (M1KMCKOJx53nLVrxZusa(elementWithView) == null)
					{
						num2 = 5;
						continue;
					}
					IEnumerable<PropertyViewItem> enumerable = ((IEnumerable)vP42pTOJSGAgW4qAPoOV(M1KMCKOJx53nLVrxZusa(elementWithView))).Cast<PropertyViewItem>();
					list = new List<TaskField>();
					enumerator = enumerable.GetEnumerator();
					num2 = 8;
					continue;
				}
				case 14:
					return;
				case 21:
					_003C_003Ec__DisplayClass8_.workflowTask = formatedValue2.Value as IWorkflowTaskBase;
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe4a54387d744988feba4889229faf1 != 0)
					{
						num2 = 6;
					}
					continue;
				case 8:
					try
					{
						while (true)
						{
							IL_0134:
							int num3;
							if (!hxBL9JOJ7NQCsnAZvOw9(enumerator))
							{
								num3 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_160bffb148c14c5da92d8d6ddf481bdc != 0)
								{
									num3 = 0;
								}
								goto IL_010e;
							}
							goto IL_015a;
							IL_015a:
							_003C_003Ec__DisplayClass8_2 = new _003C_003Ec__DisplayClass8_1();
							int num4 = 5;
							num3 = num4;
							goto IL_010e;
							IL_010e:
							while (true)
							{
								switch (num3)
								{
								case 4:
									goto IL_0134;
								case 1:
									goto IL_015a;
								case 2:
									if (propertyMetadata != null)
									{
										num3 = 3;
										continue;
									}
									goto IL_0134;
								case 5:
									_003C_003Ec__DisplayClass8_2.item = enumerator.Current;
									num3 = 6;
									continue;
								case 3:
									list.Add(new TaskField
									{
										Value = Tu7YPXOJAS3KeWwBsPsn(mhs2UuOJe7vLeVM97Wuu(_003C_003Ec__DisplayClass8_.workflowTask.WorkflowBookmark.Instance), ER6cNmOJ1yX24BhPdKsC(_003C_003Ec__DisplayClass8_2.item)),
										ViewItem = _003C_003Ec__DisplayClass8_2.item,
										PropertyMetadata = propertyMetadata
									});
									num3 = 4;
									continue;
								case 6:
									propertyMetadata = propertiesAndTableParts.FirstOrDefault(_003C_003Ec__DisplayClass8_2._003CExtractFields_003Eb__1);
									num3 = 2;
									continue;
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
						int num5;
						if (enumerator == null)
						{
							num5 = 2;
							goto IL_0232;
						}
						goto IL_0248;
						IL_0232:
						switch (num5)
						{
						case 2:
							goto end_IL_021d;
						case 1:
							goto end_IL_021d;
						}
						goto IL_0248;
						IL_0248:
						eXupvNOJ2O09jf01tVAT(enumerator);
						num5 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_558b46b4f4364838b08ac89d77f9a257 == 0)
						{
							num5 = 1;
						}
						goto IL_0232;
						end_IL_021d:;
					}
					goto case 23;
				case 9:
					if (elementWithView != null)
					{
						propertiesAndTableParts = MetadataLoader.GetPropertiesAndTableParts(CI66vTOJNDyLeSmEsrQZ(mhs2UuOJe7vLeVM97Wuu(PGyDmlOJIkAyo0U3RX5F(Fm93kwOJiajoE3xIWCWp(_003C_003Ec__DisplayClass8_.workflowTask))).GetType(), true, true) as ClassMetadata);
						num2 = 3;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto end_IL_0012;
				case 4:
					obj = null;
					break;
				case 23:
					taskFields = (TaskField[])R13rl4OJhj2Mqpc7Q8Cp(list);
					num2 = 12;
					continue;
				case 5:
					return;
				case 11:
					executeUrl = (string)Y85w7uOJWWmAeIrTv91K(-351369538 ^ -351325996);
					num2 = 19;
					continue;
				case 7:
					obj2 = null;
					goto IL_04b5;
				case 22:
					return;
				case 19:
					if (((FunctionEvaluationContext)context).Parameters.Count < 1)
					{
						num2 = 7;
						continue;
					}
					obj2 = ((FunctionEvaluationContext)context).Parameters[0];
					goto IL_04b5;
				default:
					taskFields = new TaskField[0];
					num2 = 15;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b84ccb8b1bd147ef900b852047ecbf45 != 0)
					{
						num2 = 7;
					}
					continue;
				case 20:
					elementWithView = ((Diagram)QTmCc1OJr2aFmfHlBaFs(uiXsXZOJaLYgGKlBy9sx(PGyDmlOJIkAyo0U3RX5F(Fm93kwOJiajoE3xIWCWp(_003C_003Ec__DisplayClass8_.workflowTask))))).Elements.FirstOrDefault(_003C_003Ec__DisplayClass8_._003CExtractFields_003Eb__0) as IElementWithView;
					num2 = 9;
					continue;
				case 12:
					return;
				case 13:
					if (formatedValue2 != null)
					{
						if (FhF0iLOJoDFS3qS52sGD(((FunctionEvaluationContext)context).Parameters) >= 2)
						{
							num2 = 17;
							continue;
						}
						goto case 4;
					}
					num2 = 14;
					continue;
				case 16:
					executeUrl = As8UlYOJFZjL2TEq2qqV(formatedValue).ToString();
					num2 = 21;
					continue;
				case 2:
					return;
				case 10:
					taskId = _003C_003Ec__DisplayClass8_.workflowTask.Id;
					num2 = 12;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_938c6be4ea2248868d7ed5d0e3346006 != 0)
					{
						num2 = 20;
					}
					continue;
				case 18:
					if (formatedValue != null)
					{
						num2 = 16;
						continue;
					}
					goto case 21;
				case 1:
					_003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_0();
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2f119e188994b55be2499c193b880fb == 0)
					{
						num2 = 0;
					}
					continue;
				case 6:
					if (_003C_003Ec__DisplayClass8_.workflowTask == null)
					{
						return;
					}
					num2 = 10;
					continue;
				case 15:
					taskId = 0L;
					num2 = 11;
					continue;
				case 17:
					{
						obj = ((FunctionEvaluationContext)context).Parameters[1];
						break;
					}
					IL_04b5:
					formatedValue2 = (FormatedValue)obj2;
					num2 = 13;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eef7d2ca1c3c4b74aeb81172ed542639 == 0)
					{
						num2 = 2;
					}
					continue;
				}
				formatedValue = (FormatedValue)obj;
				num2 = 18;
				continue;
				end_IL_0012:
				break;
			}
			num = 22;
		}
	}

	private static IEnumerable<FlowConnectorElement> SelectConnector(object elementThis)
	{
		List<FlowConnectorElement> standardOutputFlows = ((BPMNFlowElement)elementThis).StandardOutputFlows;
		List<FlowConnectorElement> list = new List<FlowConnectorElement>();
		if (((BPMNFlowElement)elementThis).ListButtonLocations != null && ((BPMNFlowElement)elementThis).ListButtonLocations.Count > 1)
		{
			foreach (Guid listButtonLocation in ((BPMNFlowElement)elementThis).ListButtonLocations)
			{
				foreach (FlowConnectorElement item in standardOutputFlows)
				{
					if (listButtonLocation == item.Uid)
					{
						list.Add(item);
					}
				}
			}
			{
				foreach (FlowConnectorElement item2 in standardOutputFlows)
				{
					_003C_003Ec__DisplayClass9_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass9_0();
					CS_0024_003C_003E8__locals0.element = item2;
					if (!list.Exists(delegate(FlowConnectorElement a)
					{
						int num = 1;
						int num2 = num;
						Guid guid = default(Guid);
						while (true)
						{
							switch (num2)
							{
							case 1:
								guid = _003C_003Ec__DisplayClass9_0.rdPniXvKrnoxgSKPMOe9(a);
								num2 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 == 0)
								{
									num2 = 0;
								}
								break;
							default:
								return guid.Equals(CS_0024_003C_003E8__locals0.element.Uid);
							}
						}
					}))
					{
						list.Add(CS_0024_003C_003E8__locals0.element);
					}
				}
				return list;
			}
		}
		return standardOutputFlows;
	}

	private static string GetButtonStyle(object connector)
	{
		//Discarded unreachable code: IL_0033, IL_0062, IL_0071
		int num = 2;
		int num2 = num;
		int style;
		while (true)
		{
			switch (num2)
			{
			default:
				style = (int)iD35I6OJELSsLn4EhNOI(connector);
				break;
			case 2:
				if (((FlowConnectorElement)connector).ColorConnectorButton == ButtonStyle.Default)
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				goto default;
			case 1:
				style = 1;
				break;
			}
			break;
		}
		return ButtonStyleHelper.GetColorString((ButtonStyle)style);
	}

	private static void ExtractButtons(object context, out long taskId, out string executeUrl, out TaskButton[] taskButtons)
	{
		//Discarded unreachable code: IL_007e, IL_013f, IL_019e, IL_01ad, IL_01bc, IL_0227
		int num = 2;
		_003C_003Ec__DisplayClass11_0 _003C_003Ec__DisplayClass11_ = default(_003C_003Ec__DisplayClass11_0);
		BPMNFlowElement bPMNFlowElement = default(BPMNFlowElement);
		FormatedValue formatedValue = default(FormatedValue);
		FormatedValue formatedValue2 = default(FormatedValue);
		IEnumerable<FlowConnectorElement> source = default(IEnumerable<FlowConnectorElement>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				object obj2;
				switch (num2)
				{
				case 22:
					obj = null;
					goto IL_02db;
				default:
					taskId = 0L;
					num2 = 8;
					continue;
				case 1:
					taskButtons = new TaskButton[0];
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4ef74b4b7d13430e9d2f9b78cbdb367b == 0)
					{
						num2 = 0;
					}
					continue;
				case 8:
					executeUrl = (string)Y85w7uOJWWmAeIrTv91K(-1514166050 ^ -1514266956);
					num2 = 19;
					continue;
				case 2:
					_003C_003Ec__DisplayClass11_ = new _003C_003Ec__DisplayClass11_0();
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f508947b0d94af1961e5aa17a8a2044 == 0)
					{
						num2 = 1;
					}
					continue;
				case 13:
					bPMNFlowElement = ((IEnumerable<Element>)C5tvQYOJwwNIctttulVL(QTmCc1OJr2aFmfHlBaFs(uiXsXZOJaLYgGKlBy9sx(_003C_003Ec__DisplayClass11_.workflowTask.WorkflowBookmark.Instance)))).FirstOrDefault(_003C_003Ec__DisplayClass11_._003CExtractButtons_003Eb__0) as BPMNFlowElement;
					num2 = 18;
					continue;
				case 17:
					obj2 = null;
					goto IL_02b3;
				case 15:
					if (formatedValue == null)
					{
						num2 = 11;
						continue;
					}
					goto case 14;
				case 10:
					return;
				case 6:
					taskId = _003C_003Ec__DisplayClass11_.workflowTask.Id;
					num2 = 13;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd == 0)
					{
						num2 = 10;
					}
					continue;
				case 19:
					if (FhF0iLOJoDFS3qS52sGD(((FunctionEvaluationContext)context).Parameters) < 1)
					{
						num2 = 17;
						continue;
					}
					obj2 = ((FunctionEvaluationContext)context).Parameters[0];
					goto IL_02b3;
				case 20:
					return;
				case 7:
					break;
				case 21:
					return;
				case 4:
					if (formatedValue2 == null)
					{
						num2 = 9;
						continue;
					}
					if (((FunctionEvaluationContext)context).Parameters.Count >= 2)
					{
						num2 = 5;
						continue;
					}
					goto case 22;
				case 9:
					return;
				case 16:
					if (_003C_003Ec__DisplayClass11_.workflowTask == null)
					{
						return;
					}
					num2 = 6;
					continue;
				case 14:
					executeUrl = As8UlYOJFZjL2TEq2qqV(formatedValue).ToString();
					num2 = 6;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ffb1346d351f436b84bb1e9954c3bfa8 == 0)
					{
						num2 = 12;
					}
					continue;
				case 11:
				case 12:
					_003C_003Ec__DisplayClass11_.workflowTask = formatedValue2.Value as IWorkflowTaskBase;
					num2 = 6;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0991fd79553c4ecc82e8b5cb79c2bff2 == 0)
					{
						num2 = 16;
					}
					continue;
				case 18:
					if (bPMNFlowElement == null)
					{
						return;
					}
					num2 = 7;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b == 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					obj = ((FunctionEvaluationContext)context).Parameters[1];
					goto IL_02db;
				case 3:
					{
						taskButtons = source.Select(delegate(FlowConnectorElement connector)
						{
							int num3 = 5;
							int num4 = num3;
							TaskButton result = default(TaskButton);
							while (true)
							{
								switch (num4)
								{
								case 5:
									result = default(TaskButton);
									num4 = 4;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f91acf223c4b4303819d2f8f2fc6c8e1 != 0)
									{
										num4 = 3;
									}
									break;
								case 3:
									result.Description = connector.LocalizableDescription;
									num4 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f33560c5d18b4e10b24a458578aa60fd == 0)
									{
										num4 = 0;
									}
									break;
								default:
									result.Color = GetButtonStyle(connector);
									num4 = 2;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 == 0)
									{
										num4 = 2;
									}
									break;
								case 1:
									return result;
								case 4:
									result.Id = (string)_003C_003Ec.HchfPxvKRjTHCSneUSGu(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xA7339EE ^ 0xA71EEEE), _003C_003Ec.OEZv6TvKjjpwdPKUsX1C(connector).ToString(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1214182792 ^ -1214137746)));
									num4 = 6;
									break;
								case 6:
									result.Name = (string)(_003C_003Ec.dSsZAIvKq7YIDKiTE0C3(_003C_003Ec.UCBnTAvK6bk2KbBOyegA(connector)) ? connector.EndElement.LocalizableName : _003C_003Ec.UCBnTAvK6bk2KbBOyegA(connector));
									num4 = 3;
									break;
								case 2:
									result.FontColor = (string)((_003C_003Ec.I3YDW1vK3brC2711FPTO(connector) == ButtonStyle.Yellow) ? _003C_003Ec.elLo36vKThLWIAxC5eZy(-801808857 ^ -801833845) : SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1776305410 ^ -1776456204));
									num4 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 == 0)
									{
										num4 = 1;
									}
									break;
								}
							}
						}).ToArray();
						num2 = 21;
						continue;
					}
					IL_02db:
					formatedValue = (FormatedValue)obj;
					num2 = 15;
					continue;
					IL_02b3:
					formatedValue2 = (FormatedValue)obj2;
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a == 0)
					{
						num2 = 4;
					}
					continue;
				}
				break;
			}
			source = SelectConnector(bPMNFlowElement);
			num = 3;
		}
	}

	private static bool IsHiddenTaskField(object metadataService, TaskField taskField)
	{
		//Discarded unreachable code: IL_011d, IL_012c, IL_013c, IL_014b, IL_01fb
		int num = 12;
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		IInheritedSet inheritedSet = default(IInheritedSet);
		ITypeDescriptor typeDescriptor = default(ITypeDescriptor);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (kMv9gqOlKcBuLR7SGZwK(UO63AAOJzgNSXqbflUQm(taskField.ViewItem)))
					{
						num2 = 4;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bf623f11574746d6bf3837b66460c576 == 0)
						{
							num2 = 1;
						}
						break;
					}
					propertyMetadata = taskField.PropertyMetadata as PropertyMetadata;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1b8b735647da470aa2d45d64d6f538d1 == 0)
					{
						num2 = 0;
					}
					break;
				case 8:
					return !JKgUvUOJkk1UanvE8ak2(inheritedSet);
				case 3:
					return false;
				default:
					if (propertyMetadata == null)
					{
						num2 = 10;
						break;
					}
					goto case 9;
				case 9:
					typeDescriptor = (ITypeDescriptor)LbR7MWOlv477X9Xx65lL(metadataService, rkagdJOlOuVXgkglaY6F(propertyMetadata), AbekpWOlZTgQVhQU7YhV(propertyMetadata));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_160bffb148c14c5da92d8d6ddf481bdc == 0)
					{
						num2 = 13;
					}
					break;
				case 4:
				case 11:
					return false;
				case 7:
					if (JmcVxGOJ4mkQQwZG9hPM(taskField.ViewItem, null))
					{
						num2 = 2;
						break;
					}
					goto case 4;
				case 13:
					if (typeDescriptor != null)
					{
						goto end_IL_0012;
					}
					goto case 10;
				case 1:
					if (inheritedSet == null)
					{
						num2 = 3;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 == 0)
						{
							num2 = 3;
						}
						break;
					}
					goto case 8;
				case 6:
					inheritedSet = taskField.Value as IInheritedSet;
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_719514a5a8ae47ed84e5a777ead0dc9f != 0)
					{
						num2 = 1;
					}
					break;
				case 12:
					if (!taskField.ReadOnly)
					{
						num2 = 11;
						break;
					}
					goto case 7;
				case 5:
					return typeDescriptor.IsEmpty(propertyMetadata, taskField.Value);
				case 10:
					if (taskField.PropertyMetadata is TablePartMetadata)
					{
						num2 = 6;
						break;
					}
					goto case 3;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 5;
		}
	}

	public NotificationWorkflowTaskFunctions()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		RSnOhkOlYaCOKrQY8RFt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8a6cf36da0b84f319a7cf27018f28f5b != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object yr1MxNOJDHph6NgdHqBk(object P_0, long taskId, object P_2, object P_3)
	{
		return GenerateWorkflowTaskFields(P_0, taskId, P_2, P_3);
	}

	internal static bool hZJqpSOJdCLZIlbLutdT()
	{
		return ChprWLOJXoVoYKhJkUdb == null;
	}

	internal static NotificationWorkflowTaskFunctions f5MFcnOJuMdAweNN3QJN()
	{
		return ChprWLOJXoVoYKhJkUdb;
	}

	internal static object s3jJi6OJn7Dcmo8duTsI(object P_0, long taskId, object P_2, object P_3)
	{
		return GenerateWorkflowTaskButtons(P_0, taskId, P_2, P_3);
	}

	internal static object sBT3v1OJHJKjpGwewcIT(object P_0)
	{
		return ((FunctionEvaluationContext)P_0).GenerationContext;
	}

	internal static TemplateRenderMode of1mn0OJLhQyY5EjlMcM(object P_0)
	{
		return ((GenerationContext)P_0).GetRenderMode();
	}

	internal static bool loWxAUOJfYAnDR7NeeVc()
	{
		return Locator.Initialized;
	}

	internal static object O70LQpOJ9KRQyE5GAadF(object P_0)
	{
		return ((CommonSettings)P_0).ApplicationBaseUrl;
	}

	internal static object Y85w7uOJWWmAeIrTv91K(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object fkYQxkOJjVcRdnhu8E18(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static object dZ6c4cOJRIB8voHckcdI(object P_0, object P_1)
	{
		return ((StringBuilder)P_0).Append((string)P_1);
	}

	internal static object coP9eiOJ6jCZSOAlvfVJ(object P_0, object P_1)
	{
		return string.Format((string)P_0, (object[])P_1);
	}

	internal static bool eNXvbQOJqVsudvLsHLo6(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object ugivx3OJ3qEAW5GkF2mP(object P_0, object P_1)
	{
		return ((StringBuilder)P_0).AppendLine((string)P_1);
	}

	internal static void Thbgc8OJTr0fjogRLNwf(object P_0, object P_1)
	{
		((FormatedValue)P_0).Value = P_1;
	}

	internal static void jq6mdoOJQrvv28sirrPO(object P_0, object P_1)
	{
		((MetadataBasedFormat)P_0).PropertyMetadata = (PropertyMetadata)P_1;
	}

	internal static void chxMZnOJpxR6ZIs2al7c(object P_0, object P_1)
	{
		((FormatedValue)P_0).Format = (BaseFormat)P_1;
	}

	internal static object lkZTwGOJCtFqcZtwO6DA(object P_0)
	{
		return ((GenerationContext)P_0).FormatProvider;
	}

	internal static object XbQgxwOJM3lZdp0ut2xf(object P_0, object P_1)
	{
		return ((IGeneratorFormatProvider)P_0).FormatValue((FormatedValue)P_1);
	}

	internal static bool JKgUvUOJkk1UanvE8ak2(object P_0)
	{
		return EnumerableExtensions.Any((IEnumerable)P_0);
	}

	internal static object yghuWqOJUFbgMoCUFtfB(object P_0)
	{
		return EnumerableExtensions.FirstOrNull((IEnumerable)P_0);
	}

	internal static Guid UPFgpZOJV0J0NdwhIMwq(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static object Tu7YPXOJAS3KeWwBsPsn(object P_0, Guid P_1)
	{
		return ((Entity<long>)P_0).GetPropertyValue(P_1);
	}

	internal static Guid LrOrUeOJGCvLRBTt5s5n(object P_0)
	{
		return ((TablePartMetadata)P_0).TablePartPropertyUid;
	}

	internal static bool hxBL9JOJ7NQCsnAZvOw9(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void eXupvNOJ2O09jf01tVAT(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static int FhF0iLOJoDFS3qS52sGD(object P_0)
	{
		return ((List<FormatedValue>)P_0).Count;
	}

	internal static object As8UlYOJFZjL2TEq2qqV(object P_0)
	{
		return ((FormatedValue)P_0).Value;
	}

	internal static object Fm93kwOJiajoE3xIWCWp(object P_0)
	{
		return ((IWorkflowTaskBase)P_0).WorkflowBookmark;
	}

	internal static object PGyDmlOJIkAyo0U3RX5F(object P_0)
	{
		return ((IWorkflowBookmark)P_0).Instance;
	}

	internal static object uiXsXZOJaLYgGKlBy9sx(object P_0)
	{
		return ((IWorkflowInstance)P_0).Process;
	}

	internal static object QTmCc1OJr2aFmfHlBaFs(object P_0)
	{
		return ((IWorkflowProcess)P_0).Diagram;
	}

	internal static object mhs2UuOJe7vLeVM97Wuu(object P_0)
	{
		return ((IWorkflowInstance)P_0).Context;
	}

	internal static object CI66vTOJNDyLeSmEsrQZ(Type P_0, bool P_1, bool P_2)
	{
		return MetadataLoader.LoadMetadata(P_0, P_1, P_2);
	}

	internal static object M1KMCKOJx53nLVrxZusa(object P_0)
	{
		return ((IElementWithView)P_0).View;
	}

	internal static object vP42pTOJSGAgW4qAPoOV(object P_0)
	{
		return ((RootViewItem)P_0).Items;
	}

	internal static Guid ER6cNmOJ1yX24BhPdKsC(object P_0)
	{
		return ((PropertyViewItem)P_0).PropertyUid;
	}

	internal static object R13rl4OJhj2Mqpc7Q8Cp(object P_0)
	{
		return ((List<TaskField>)P_0).ToArray();
	}

	internal static ButtonStyle iD35I6OJELSsLn4EhNOI(object P_0)
	{
		return ((FlowConnectorElement)P_0).ColorConnectorButton;
	}

	internal static object C5tvQYOJwwNIctttulVL(object P_0)
	{
		return ((Diagram)P_0).Elements;
	}

	internal static bool JmcVxGOJ4mkQQwZG9hPM(object P_0, object P_1)
	{
		return ((RootViewItem)P_0).IsHideEmpty((RootViewItem)P_1);
	}

	internal static object UO63AAOJzgNSXqbflUQm(object P_0)
	{
		return ((PropertyViewItem)P_0).Attributes;
	}

	internal static bool kMv9gqOlKcBuLR7SGZwK(object P_0)
	{
		return ((ViewAttributes)P_0).ShowEmpty;
	}

	internal static Guid rkagdJOlOuVXgkglaY6F(object P_0)
	{
		return ((PropertyMetadata)P_0).TypeUid;
	}

	internal static Guid AbekpWOlZTgQVhQU7YhV(object P_0)
	{
		return ((PropertyMetadata)P_0).SubTypeUid;
	}

	internal static object LbR7MWOlv477X9Xx65lL(object P_0, Guid P_1, Guid P_2)
	{
		return ((IMetadataService)P_0).GetTypeDescriptor(P_1, P_2);
	}

	internal static void RSnOhkOlYaCOKrQY8RFt()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
