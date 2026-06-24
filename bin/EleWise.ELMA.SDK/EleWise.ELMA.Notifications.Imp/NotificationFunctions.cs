using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Web.Mvc;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Templates;
using EleWise.ELMA.Templates.TemplateGenerator;
using EleWise.TemplateGenerator;
using EleWise.TemplateGenerator.Formats;
using EleWise.TemplateGenerator.Functions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Notifications.Impl.TemplateGenerator;

public static class NotificationFunctions
{
	private struct PropertyRowParamIndices
	{
		internal static object PAj265fr9XVEBo0nQZVu;

		public int OldValue
		{
			[CompilerGenerated]
			get
			{
				return _003COldValue_003Ek__BackingField;
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
						_003COldValue_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public int NewValue
		{
			[CompilerGenerated]
			get
			{
				return _003CNewValue_003Ek__BackingField;
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
						_003CNewValue_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public int Caption
		{
			[CompilerGenerated]
			get
			{
				return _003CCaption_003Ek__BackingField;
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
						_003CCaption_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
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

		public int Visibility
		{
			[CompilerGenerated]
			get
			{
				return _003CVisibility_003Ek__BackingField;
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
						_003CVisibility_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
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

		internal static bool agsHkHfrd1mQU1d1TMZZ()
		{
			return PAj265fr9XVEBo0nQZVu == null;
		}

		internal static object uKZtWufrlXI5hFg2vRko()
		{
			return PAj265fr9XVEBo0nQZVu;
		}
	}

	private static readonly PropertyRowParamIndices RowIndices;

	private static readonly PropertyRowParamIndices RowChangesIndices;

	private static NotificationFunctions hiRDaTHCJT43IoTHCbc;

	public static FormatedValue Link(FunctionEvaluationContext context)
	{
		//Discarded unreachable code: IL_0092, IL_00a1, IL_0168, IL_0177, IL_0225
		int num = 6;
		string text2 = default(string);
		FormatedValue formatedValue = default(FormatedValue);
		string text = default(string);
		TemplateRenderMode templateRenderMode = default(TemplateRenderMode);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 12:
					text2 = formatedValue.Value.ToString().HtmlEncode();
					num2 = 4;
					continue;
				case 5:
					if (context.Parameters.Count >= 2)
					{
						num2 = 11;
						continue;
					}
					goto case 10;
				case 18:
					if (formatedValue == null)
					{
						num2 = 14;
						continue;
					}
					goto case 7;
				case 20:
					if (x2IOjnHV5xUe7ttNQhs(text))
					{
						num2 = 10;
						continue;
					}
					goto case 19;
				case 4:
				case 8:
					formatedValue = context.Parameters[1];
					num2 = 18;
					continue;
				case 16:
					if (INCTrIHIxFLySih6GaB(formatedValue) != null)
					{
						num2 = 12;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
						{
							num2 = 12;
						}
						continue;
					}
					goto case 4;
				case 7:
					if (INCTrIHIxFLySih6GaB(formatedValue) != null)
					{
						num2 = 17;
						continue;
					}
					goto case 1;
				case 11:
					text2 = "";
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
					{
						num2 = 9;
					}
					continue;
				case 3:
					if (formatedValue == null)
					{
						num2 = 8;
						continue;
					}
					goto case 16;
				case 17:
					if (!(INCTrIHIxFLySih6GaB(formatedValue) is string))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 13;
				case 15:
					formatedValue = context.Parameters[0];
					num2 = 3;
					continue;
				default:
					return new FormatedValue(LROWAlHR7M37tmoOqEs(c8ROQcHiDGXgunXqRhZ(nmrQgaHS7d4iyPgqr9e(0x5A4C7B29 ^ 0x5A4CE93B), text, text2)));
				case 10:
					return new FormatedValue();
				case 13:
					text = (string)formatedValue.Value;
					num = 2;
					break;
				case 1:
				case 2:
				case 14:
					if (!x2IOjnHV5xUe7ttNQhs(text2))
					{
						num = 20;
						break;
					}
					goto case 10;
				case 19:
					if (templateRenderMode != TemplateRenderMode.HTML)
					{
						return new FormatedValue(c8ROQcHiDGXgunXqRhZ(nmrQgaHS7d4iyPgqr9e(0x3A6135BE ^ 0x3A61A7FE), text, text2));
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
					{
						num2 = 0;
					}
					continue;
				case 9:
					text = "";
					num2 = 15;
					continue;
				case 6:
					templateRenderMode = YOC3ENHuIEcWULVreyp(Vpt0dGHZO0T75E7EkVs(context));
					num2 = 5;
					continue;
				}
				break;
			}
		}
	}

	public static FormatedValue BoldText(FunctionEvaluationContext context)
	{
		//Discarded unreachable code: IL_00ed, IL_0124, IL_0133, IL_0142, IL_0173, IL_0182, IL_01f5, IL_0204
		int num = 2;
		int num2 = num;
		string text = default(string);
		FormatedValue formatedValue = default(FormatedValue);
		TemplateRenderMode renderMode = default(TemplateRenderMode);
		while (true)
		{
			switch (num2)
			{
			case 15:
				text = (string)INCTrIHIxFLySih6GaB(formatedValue);
				num2 = 7;
				break;
			case 11:
				if (renderMode == TemplateRenderMode.HTML)
				{
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
					{
						num2 = 2;
					}
					break;
				}
				return new FormatedValue(text);
			case 8:
				if (!(INCTrIHIxFLySih6GaB(formatedValue) is string))
				{
					num2 = 13;
					break;
				}
				goto case 15;
			case 12:
				text = "";
				num2 = 10;
				break;
			default:
				if (x2IOjnHV5xUe7ttNQhs(text))
				{
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
					{
						num2 = 5;
					}
					break;
				}
				goto case 11;
			case 10:
				formatedValue = context.Parameters[0];
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
				{
					num2 = 3;
				}
				break;
			case 3:
				if (formatedValue == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 14;
			case 14:
				if (INCTrIHIxFLySih6GaB(formatedValue) == null)
				{
					num2 = 4;
					break;
				}
				goto case 8;
			case 1:
				if (context.Parameters.Count < 1)
				{
					num2 = 5;
					break;
				}
				goto case 12;
			case 6:
				return new FormatedValue(LROWAlHR7M37tmoOqEs(vq4opWHqq1Wlou3OwR2(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x26FFCB59 ^ 0x26FF5939), text)));
			case 5:
			case 9:
				return new FormatedValue();
			case 2:
				renderMode = ((GenerationContext)Vpt0dGHZO0T75E7EkVs(context)).GetRenderMode();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public static FormatedValue EntityDisplayName(FunctionEvaluationContext context)
	{
		//Discarded unreachable code: IL_0061, IL_0070, IL_0119, IL_0128, IL_01d9
		int num = 13;
		int num2 = num;
		ClassMetadata classMetadata = default(ClassMetadata);
		FormatedValue formatedValue = default(FormatedValue);
		string value = default(string);
		while (true)
		{
			switch (num2)
			{
			case 12:
				if (context != null)
				{
					num2 = 15;
					break;
				}
				goto default;
			case 11:
				classMetadata = MetadataLoader.LoadMetadata(INCTrIHIxFLySih6GaB(formatedValue).GetType()) as ClassMetadata;
				num2 = 2;
				break;
			case 14:
				if (INCTrIHIxFLySih6GaB(formatedValue) == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 4;
			case 4:
				if (formatedValue.Value is IEntity)
				{
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
					{
						num2 = 7;
					}
					break;
				}
				goto default;
			case 13:
				value = "";
				num2 = 12;
				break;
			case 10:
				value = (string)nWfBImHXN5pWUg2sfcv(classMetadata);
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
				{
					num2 = 3;
				}
				break;
			case 1:
				formatedValue = context.Parameters[0];
				num2 = 8;
				break;
			case 2:
				if (classMetadata == null)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 10;
			default:
				return new FormatedValue(value);
			case 5:
				if (XWXL7gHKFBhlpVyu1b6(context.Parameters) <= 0)
				{
					num2 = 9;
					break;
				}
				goto case 1;
			case 8:
				if (formatedValue != null)
				{
					num2 = 14;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
					{
						num2 = 14;
					}
					break;
				}
				goto default;
			case 15:
				if (context.Parameters == null)
				{
					num2 = 7;
					break;
				}
				goto case 5;
			}
		}
	}

	public static FormatedValue TableStart(FunctionEvaluationContext context)
	{
		int num = 2;
		int num2 = num;
		TemplateRenderMode templateRenderMode = default(TemplateRenderMode);
		while (true)
		{
			switch (num2)
			{
			default:
				return new FormatedValue(MvcHtmlString.Create((string)nmrQgaHS7d4iyPgqr9e(0x1FFEF86A ^ 0x1FFE6A12)));
			case 1:
				if (templateRenderMode != TemplateRenderMode.HTML)
				{
					return (FormatedValue)rEYDjQHTkQYWJ4J8JeI(context);
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				templateRenderMode = YOC3ENHuIEcWULVreyp(Vpt0dGHZO0T75E7EkVs(context));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public static FormatedValue TableEnd(FunctionEvaluationContext context)
	{
		int num = 1;
		int num2 = num;
		TemplateRenderMode templateRenderMode = default(TemplateRenderMode);
		while (true)
		{
			switch (num2)
			{
			case 1:
				templateRenderMode = YOC3ENHuIEcWULVreyp(Vpt0dGHZO0T75E7EkVs(context));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return new FormatedValue(LROWAlHR7M37tmoOqEs(nmrQgaHS7d4iyPgqr9e(0x4EDCBA32 ^ 0x4EDC28F0)));
			}
			if (templateRenderMode == TemplateRenderMode.HTML)
			{
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			return GenerateEmptyRow(context);
		}
	}

	public static FormatedValue EmptyRow(FunctionEvaluationContext context)
	{
		int num = 2;
		int num2 = num;
		TemplateRenderMode renderMode = default(TemplateRenderMode);
		while (true)
		{
			switch (num2)
			{
			default:
				return new FormatedValue(MvcHtmlString.Create((string)nmrQgaHS7d4iyPgqr9e(0x53CACA3 ^ 0x53C3E75)));
			case 1:
				if (renderMode != TemplateRenderMode.HTML)
				{
					return new FormatedValue(string.Empty);
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				renderMode = ((GenerationContext)Vpt0dGHZO0T75E7EkVs(context)).GetRenderMode();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public static FormatedValue PropertyRow(FunctionEvaluationContext context)
	{
		//Discarded unreachable code: IL_007f, IL_008e
		int num = 2;
		int num2 = num;
		string formatedValue = default(string);
		string caption = default(string);
		bool visibility = default(bool);
		while (true)
		{
			switch (num2)
			{
			default:
				return (FormatedValue)rEYDjQHTkQYWJ4J8JeI(context);
			case 3:
				return (FormatedValue)xgqfw7HkwKZCLnWlQMY(context, formatedValue, caption);
			case 2:
				ExtractPropertyRowValues(RowIndices, context, out formatedValue, out caption, out visibility);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				if (visibility)
				{
					num2 = 3;
					break;
				}
				goto default;
			}
		}
	}

	public static FormatedValue PropertyFullRow(FunctionEvaluationContext context)
	{
		int num = 2;
		int num2 = num;
		string formatedValue = default(string);
		string caption = default(string);
		bool visibility = default(bool);
		while (true)
		{
			switch (num2)
			{
			default:
				return GenerateEmptyRow(context);
			case 2:
				ExtractPropertyRowValues(RowIndices, context, out formatedValue, out caption, out visibility);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				if (visibility)
				{
					return (FormatedValue)VRHx62Hn0NtotfIJTkQ(context, formatedValue, caption);
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static FormatedValue PropertyRowWithChanges(FunctionEvaluationContext context)
	{
		int num = 2;
		int num2 = num;
		bool visibility = default(bool);
		string oldFormatedValue = default(string);
		string formatedValue = default(string);
		string caption = default(string);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!visibility)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return (FormatedValue)xgqfw7HkwKZCLnWlQMY(context, FormatValueChanges(context, oldFormatedValue, formatedValue), caption);
			case 2:
				ExtractPropertyRowValues(RowChangesIndices, context, out oldFormatedValue, out formatedValue, out caption, out visibility);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
				{
					num2 = 1;
				}
				break;
			default:
				return (FormatedValue)rEYDjQHTkQYWJ4J8JeI(context);
			}
		}
	}

	public static FormatedValue PropertyFullRowWithChanges(FunctionEvaluationContext context)
	{
		//Discarded unreachable code: IL_007f, IL_008e
		int num = 1;
		int num2 = num;
		string oldFormatedValue = default(string);
		string formatedValue = default(string);
		string caption = default(string);
		bool visibility = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 1:
				ExtractPropertyRowValues(RowChangesIndices, context, out oldFormatedValue, out formatedValue, out caption, out visibility);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (visibility)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 2;
			case 2:
				return (FormatedValue)rEYDjQHTkQYWJ4J8JeI(context);
			case 3:
				return (FormatedValue)VRHx62Hn0NtotfIJTkQ(context, qOFKoZHOcMA4dkLIBS5(context, oldFormatedValue, formatedValue), caption);
			}
		}
	}

	public static FormatedValue PropertyRowIfChanged(FunctionEvaluationContext context)
	{
		//Discarded unreachable code: IL_0035
		int num = 3;
		int num2 = num;
		string oldFormatedValue = default(string);
		string formatedValue = default(string);
		string caption = default(string);
		bool visibility = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 3:
				ExtractPropertyRowValues(RowChangesIndices, context, out oldFormatedValue, out formatedValue, out caption, out visibility);
				num2 = 2;
				break;
			case 4:
				if (oldFormatedValue == formatedValue)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
					{
						num2 = 1;
					}
					break;
				}
				return (FormatedValue)xgqfw7HkwKZCLnWlQMY(context, FormatValueChanges(context, oldFormatedValue, formatedValue), caption);
			default:
				return GenerateEmptyRow(context);
			case 2:
				if (!visibility)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 4;
			}
		}
	}

	public static FormatedValue PropertyFullRowIfChanged(FunctionEvaluationContext context)
	{
		//Discarded unreachable code: IL_0039, IL_0048
		int num = 4;
		int num2 = num;
		string oldFormatedValue = default(string);
		string formatedValue = default(string);
		string caption = default(string);
		bool visibility = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 4:
				ExtractPropertyRowValues(RowChangesIndices, context, out oldFormatedValue, out formatedValue, out caption, out visibility);
				num2 = 3;
				break;
			case 3:
				if (!visibility)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				if (!(oldFormatedValue == formatedValue))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			case 1:
			case 5:
				return GenerateEmptyRow(context);
			default:
				return (FormatedValue)VRHx62Hn0NtotfIJTkQ(context, qOFKoZHOcMA4dkLIBS5(context, oldFormatedValue, formatedValue), caption);
			}
		}
	}

	private static string FormatValueChanges(object context, object oldValue, object newValue)
	{
		//Discarded unreachable code: IL_00a9, IL_00b8
		int num = 6;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 3:
				if (!YhAmYRH2bMipLv0kNpn(oldValue, newValue))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 7;
			case 4:
				text = (string)IfXrL1HeF3CRYd0uGTI(text, SR.T((string)nmrQgaHS7d4iyPgqr9e(-1217523399 ^ -1217494413), oldValue));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
				{
					num2 = 1;
				}
				continue;
			case 7:
				if (string.IsNullOrEmpty((string)oldValue))
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
					{
						num2 = 2;
					}
					continue;
				}
				goto case 4;
			default:
				return text;
			case 6:
				obj = newValue;
				if (obj == null)
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
					{
						num2 = 5;
					}
					continue;
				}
				break;
			case 5:
				obj = string.Empty;
				break;
			}
			text = (string)obj;
			num2 = 3;
		}
	}

	private static void ExtractPropertyRowValues(PropertyRowParamIndices indices, object context, out string formatedValue, out string caption, out bool visibility)
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
			{
				ExtractPropertyRowValues(indices, context, out var _, out formatedValue, out caption, out visibility);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
				{
					num2 = 0;
				}
				break;
			}
			}
		}
	}

	private static void ExtractPropertyRowValues(PropertyRowParamIndices indices, object context, out string oldFormatedValue, out string formatedValue, out string caption, out bool visibility)
	{
		//Discarded unreachable code: IL_015b, IL_019c, IL_01ab, IL_0241, IL_0266, IL_027a, IL_02b5, IL_02c4, IL_02d5, IL_02f0, IL_02ff, IL_030e, IL_031e, IL_032d, IL_0386, IL_04f0, IL_0517, IL_0553, IL_0562
		int num = 36;
		IEnumerable enumerable = default(IEnumerable);
		FormatedValue formatedValue4 = default(FormatedValue);
		FormatedValue formatedValue2 = default(FormatedValue);
		FormatedValue formatedValue3 = default(FormatedValue);
		FormatedValue formatedValue5 = default(FormatedValue);
		MetadataBasedFormat metadataBasedFormat = default(MetadataBasedFormat);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				object obj5;
				object obj4;
				object obj2;
				object obj3;
				switch (num2)
				{
				case 36:
					oldFormatedValue = null;
					num2 = 35;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
					{
						num2 = 34;
					}
					continue;
				case 39:
					if (enumerable.Cast<object>().Count() == 0)
					{
						num2 = 34;
						continue;
					}
					goto IL_013b;
				case 7:
					return;
				case 25:
					formatedValue4 = null;
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
					{
						num2 = 33;
					}
					continue;
				case 22:
					return;
				case 38:
					obj = null;
					goto IL_06d0;
				case 42:
					if (formatedValue2 == null)
					{
						num2 = 27;
						continue;
					}
					goto case 16;
				case 16:
					if (INCTrIHIxFLySih6GaB(formatedValue2) == null)
					{
						num2 = 18;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
						{
							num2 = 11;
						}
					}
					else
					{
						enumerable = INCTrIHIxFLySih6GaB(formatedValue2) as IEnumerable;
						num2 = 2;
					}
					continue;
				case 2:
					if (enumerable != null)
					{
						num2 = 12;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
						{
							num2 = 39;
						}
						continue;
					}
					goto IL_013b;
				case 41:
					caption = string.Empty;
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
					{
						num2 = 15;
					}
					continue;
				case 24:
					if (formatedValue3 != null)
					{
						num2 = 11;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
						{
							num2 = 17;
						}
						continue;
					}
					goto case 42;
				case 47:
					return;
				case 10:
					if (formatedValue2 != null)
					{
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 38;
				case 14:
					caption = string.Empty;
					num2 = 11;
					continue;
				case 1:
					obj5 = null;
					goto IL_05c6;
				case 49:
					if (XWXL7gHKFBhlpVyu1b6(((FunctionEvaluationContext)context).Parameters) <= indices.OldValue)
					{
						num2 = 40;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
						{
							num2 = 20;
						}
						continue;
					}
					obj4 = ((FunctionEvaluationContext)context).Parameters[indices.OldValue];
					goto IL_05e4;
				case 8:
					obj2 = null;
					goto IL_06b8;
				case 15:
					if (formatedValue5 == null)
					{
						num2 = 10;
						continue;
					}
					goto case 4;
				case 44:
					return;
				case 43:
					if (!(formatedValue3.Value is bool))
					{
						num = 25;
						break;
					}
					goto case 29;
				case 19:
					caption = (string)INCTrIHIxFLySih6GaB(formatedValue5);
					num2 = 47;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
					{
						num2 = 12;
					}
					continue;
				case 40:
					obj4 = null;
					goto IL_05e4;
				case 31:
					caption = ((NamedMetadata)Gk5L8wH1F98ykrwfNLO(metadataBasedFormat)).DisplayName;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
					{
						num2 = 13;
					}
					continue;
				case 5:
					return;
				case 4:
					if (INCTrIHIxFLySih6GaB(formatedValue5) != null)
					{
						num = 30;
						break;
					}
					goto case 10;
				case 18:
				case 27:
					visibility = false;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
					{
						num2 = 5;
					}
					continue;
				case 11:
					visibility = true;
					num2 = 9;
					continue;
				case 30:
					if (INCTrIHIxFLySih6GaB(formatedValue5) is string)
					{
						num2 = 19;
						continue;
					}
					goto case 10;
				case 26:
					if (formatedValue3 != null)
					{
						num2 = 15;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
						{
							num2 = 43;
						}
						continue;
					}
					goto case 25;
				case 29:
					if (!(bool)formatedValue3.Value)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 25;
				case 46:
					if (metadataBasedFormat.PropertyMetadata == null)
					{
						num2 = 44;
						continue;
					}
					goto case 31;
				case 9:
					if (indices.Visibility >= 0)
					{
						if (XWXL7gHKFBhlpVyu1b6(((FunctionEvaluationContext)context).Parameters) <= indices.Visibility)
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
							{
								num2 = 1;
							}
							continue;
						}
						obj5 = ((FunctionEvaluationContext)context).Parameters[indices.Visibility];
						goto IL_05c6;
					}
					num2 = 23;
					continue;
				case 34:
					visibility = false;
					num = 22;
					break;
				case 28:
					obj3 = null;
					goto IL_0646;
				case 45:
					visibility = false;
					num2 = 20;
					continue;
				default:
					visibility = false;
					num2 = 7;
					continue;
				case 23:
					obj5 = null;
					goto IL_05c6;
				case 32:
					if (metadataBasedFormat != null)
					{
						num2 = 46;
						continue;
					}
					return;
				case 3:
				case 21:
					if (XWXL7gHKFBhlpVyu1b6(((FunctionEvaluationContext)context).Parameters) <= indices.NewValue)
					{
						num2 = 28;
						continue;
					}
					obj3 = ((FunctionEvaluationContext)context).Parameters[indices.NewValue];
					goto IL_0646;
				case 20:
					return;
				case 17:
					if (XWXL7gHKFBhlpVyu1b6(((FunctionEvaluationContext)context).Parameters) > indices.Caption)
					{
						num2 = 12;
						continue;
					}
					goto case 8;
				case 35:
					formatedValue = null;
					num2 = 14;
					continue;
				case 13:
					return;
				case 33:
					if (indices.OldValue < 0)
					{
						num2 = 21;
						continue;
					}
					goto case 49;
				case 48:
					oldFormatedValue = ((formatedValue4 != null) ? ((FunctionEvaluationContext)context).GenerationContext.FormatProvider.FormatValue(formatedValue4) : string.Empty);
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
					{
						num2 = 2;
					}
					continue;
				case 37:
					formatedValue = ((formatedValue2 != null) ? ((IGeneratorFormatProvider)d2kr0YHPihgXAPZprJg(Vpt0dGHZO0T75E7EkVs(context))).FormatValue(formatedValue2) : string.Empty);
					num2 = 15;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
					{
						num2 = 24;
					}
					continue;
				case 12:
					obj2 = ((FunctionEvaluationContext)context).Parameters[indices.Caption];
					goto IL_06b8;
				case 6:
					{
						obj = formatedValue2.Format as MetadataBasedFormat;
						goto IL_06d0;
					}
					IL_0646:
					formatedValue2 = (FormatedValue)obj3;
					num2 = 37;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
					{
						num2 = 35;
					}
					continue;
					IL_05e4:
					formatedValue4 = (FormatedValue)obj4;
					num2 = 48;
					continue;
					IL_05c6:
					formatedValue3 = (FormatedValue)obj5;
					num2 = 26;
					continue;
					IL_06b8:
					formatedValue5 = (FormatedValue)obj2;
					num2 = 41;
					continue;
					IL_013b:
					if (x2IOjnHV5xUe7ttNQhs(formatedValue))
					{
						num = 45;
						break;
					}
					goto case 17;
					IL_06d0:
					metadataBasedFormat = (MetadataBasedFormat)obj;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
					{
						num2 = 32;
					}
					continue;
				}
				break;
			}
		}
	}

	private static FormatedValue GenerateRow(object context, object formatedValue, object caption)
	{
		//Discarded unreachable code: IL_0115
		int num = 10;
		int num3 = default(int);
		int num4 = default(int);
		StringBuilder stringBuilder = default(StringBuilder);
		TemplateRenderMode renderMode = default(TemplateRenderMode);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					num3 = mPTDmBHpg5eMPyfvoG2(caption);
					num2 = 15;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num2 = 13;
					}
					continue;
				case 2:
					if (num3 > num4)
					{
						num2 = 8;
						continue;
					}
					break;
				case 10:
					stringBuilder = new StringBuilder();
					num2 = 9;
					continue;
				case 7:
					A0UT6sH3BhVImcpAaia(stringBuilder, nmrQgaHS7d4iyPgqr9e(0x7247028A ^ 0x7247913C));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
					{
						num2 = 1;
					}
					continue;
				case 16:
					KDe8yoHNPkRGsApKnrZ(stringBuilder, nmrQgaHS7d4iyPgqr9e(-1411196499 ^ -1411233063));
					num2 = 3;
					continue;
				case 18:
					KDe8yoHNPkRGsApKnrZ(stringBuilder, caption);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					return new FormatedValue(stringBuilder.ToString());
				case 17:
					stringBuilder.AppendLine((string)nmrQgaHS7d4iyPgqr9e(-1921202237 ^ -1921231701));
					num2 = 16;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num2 = 15;
					}
					continue;
				case 13:
					return new FormatedValue(MvcHtmlString.Create(stringBuilder.ToString()));
				default:
					KDe8yoHNPkRGsApKnrZ(stringBuilder, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70036241));
					num2 = 6;
					continue;
				case 15:
					num4 = J4Md9qHaGF2jXKsMBcE(((FunctionEvaluationContext)context).GenerationContext);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
					{
						num2 = 2;
					}
					continue;
				case 9:
					renderMode = ((GenerationContext)Vpt0dGHZO0T75E7EkVs(context)).GetRenderMode();
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
					{
						num2 = 5;
					}
					continue;
				case 8:
					((FunctionEvaluationContext)context).GenerationContext.SetTextCaptionMaxLength(num3);
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
					{
						num2 = 8;
					}
					continue;
				case 19:
					stringBuilder.Append((string)nmrQgaHS7d4iyPgqr9e(-2138958856 ^ -2138931140));
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
					{
						num2 = 1;
					}
					continue;
				case 20:
					A0UT6sH3BhVImcpAaia(stringBuilder, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x8317432 ^ 0x831E784));
					num2 = 19;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
					{
						num2 = 3;
					}
					continue;
				case 5:
					if (renderMode != TemplateRenderMode.HTML)
					{
						if (x2IOjnHV5xUe7ttNQhs(caption))
						{
							num2 = 14;
							continue;
						}
						goto case 18;
					}
					num2 = 17;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
					{
						num2 = 12;
					}
					continue;
				case 12:
				case 14:
					break;
				case 11:
					KDe8yoHNPkRGsApKnrZ(stringBuilder, formatedValue);
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
					{
						num2 = 7;
					}
					continue;
				case 3:
					KDe8yoHNPkRGsApKnrZ(stringBuilder, ((IGeneratorFormatProvider)d2kr0YHPihgXAPZprJg(Vpt0dGHZO0T75E7EkVs(context))).FormatValue(new FormatedValue(caption)));
					num2 = 20;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
					{
						num2 = 9;
					}
					continue;
				case 1:
					stringBuilder.Append((string)nmrQgaHS7d4iyPgqr9e(-70037984 ^ -70001164));
					num2 = 13;
					continue;
				}
				break;
			}
			KDe8yoHNPkRGsApKnrZ(stringBuilder, formatedValue);
			num = 4;
		}
	}

	private static FormatedValue GenerateFullRow(object context, object formatedValue, object caption)
	{
		int num = 14;
		int num2 = num;
		StringBuilder stringBuilder = default(StringBuilder);
		TemplateRenderMode templateRenderMode = default(TemplateRenderMode);
		while (true)
		{
			switch (num2)
			{
			case 5:
				A0UT6sH3BhVImcpAaia(stringBuilder, nmrQgaHS7d4iyPgqr9e(0x8317432 ^ 0x831E058));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
				{
					num2 = 4;
				}
				break;
			case 8:
				KDe8yoHNPkRGsApKnrZ(stringBuilder, nmrQgaHS7d4iyPgqr9e(0x7EC153F ^ 0x7EC8155));
				num2 = 6;
				break;
			case 2:
				KDe8yoHNPkRGsApKnrZ(stringBuilder, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3C5338FF ^ 0x3C53ACF3));
				num2 = 11;
				break;
			case 9:
				if (!x2IOjnHV5xUe7ttNQhs(caption))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 4;
			case 15:
				stringBuilder.Append((string)formatedValue);
				num2 = 10;
				break;
			case 4:
				KDe8yoHNPkRGsApKnrZ(stringBuilder, nmrQgaHS7d4iyPgqr9e(-218496594 ^ -218458836));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
				{
					num2 = 3;
				}
				break;
			case 12:
				if (templateRenderMode == TemplateRenderMode.HTML)
				{
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
					{
						num2 = 8;
					}
					break;
				}
				if (!x2IOjnHV5xUe7ttNQhs(caption))
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
					{
						num2 = 7;
					}
					break;
				}
				goto case 15;
			case 14:
				stringBuilder = new StringBuilder();
				num2 = 13;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
				{
					num2 = 2;
				}
				break;
			case 7:
				A0UT6sH3BhVImcpAaia(stringBuilder, caption);
				num2 = 11;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
				{
					num2 = 15;
				}
				break;
			case 16:
				KDe8yoHNPkRGsApKnrZ(stringBuilder, formatedValue);
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
				{
					num2 = 8;
				}
				break;
			case 3:
				if (string.IsNullOrEmpty((string)caption))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			case 13:
				templateRenderMode = YOC3ENHuIEcWULVreyp(Vpt0dGHZO0T75E7EkVs(context));
				num2 = 12;
				break;
			case 10:
				return new FormatedValue(stringBuilder.ToString());
			case 6:
				return new FormatedValue(LROWAlHR7M37tmoOqEs(stringBuilder.ToString()));
			default:
				KDe8yoHNPkRGsApKnrZ(stringBuilder, nmrQgaHS7d4iyPgqr9e(-538519530 ^ -538535978));
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
				{
					num2 = 16;
				}
				break;
			case 11:
				KDe8yoHNPkRGsApKnrZ(stringBuilder, GuHgdSHDkWMvWSaDm90(d2kr0YHPihgXAPZprJg(((FunctionEvaluationContext)context).GenerationContext), new FormatedValue(caption)));
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				stringBuilder.Append((string)nmrQgaHS7d4iyPgqr9e(-210725949 ^ -210761873));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private static FormatedValue GenerateEmptyRow(object context)
	{
		int num = 1;
		int num2 = num;
		TemplateRenderMode renderMode = default(TemplateRenderMode);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return new FormatedValue(string.Empty);
			case 1:
				renderMode = ((GenerationContext)Vpt0dGHZO0T75E7EkVs(context)).GetRenderMode();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
				{
					num2 = 0;
				}
				continue;
			}
			if (renderMode != TemplateRenderMode.HTML)
			{
				return new FormatedValue(nmrQgaHS7d4iyPgqr9e(0x5A4C7B29 ^ 0x5A4CEFCB));
			}
			num2 = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
			{
				num2 = 2;
			}
		}
	}

	public static FormatedValue PropertyLiteRow(FunctionEvaluationContext context)
	{
		int num = 1;
		int num2 = num;
		string formatedValue = default(string);
		string caption = default(string);
		bool visibility = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 1:
				ExtractPropertyRowValues(RowIndices, context, out formatedValue, out caption, out visibility);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return GenerateEmptyRow(context);
			}
			if (!visibility)
			{
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
				{
					num2 = 2;
				}
				continue;
			}
			return (FormatedValue)OOmjnpHtVfvs2A3bUeZ(context, formatedValue, caption);
		}
	}

	private static FormatedValue GenerateLiteRow(object context, object formatedValue, object caption)
	{
		int num = 5;
		StringBuilder stringBuilder = default(StringBuilder);
		TemplateRenderMode renderMode = default(TemplateRenderMode);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 16:
					KDe8yoHNPkRGsApKnrZ(stringBuilder, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1411196499 ^ -1411233253));
					num2 = 13;
					break;
				case 12:
					A0UT6sH3BhVImcpAaia(stringBuilder, nmrQgaHS7d4iyPgqr9e(-583745292 ^ -583772424));
					num2 = 3;
					break;
				case 1:
					KDe8yoHNPkRGsApKnrZ(stringBuilder, nmrQgaHS7d4iyPgqr9e(0x1C9495B4 ^ 0x1C9406DC));
					num2 = 14;
					break;
				case 10:
					KDe8yoHNPkRGsApKnrZ(stringBuilder, nmrQgaHS7d4iyPgqr9e(-2138958856 ^ -2138931122));
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
					{
						num2 = 2;
					}
					break;
				case 3:
					stringBuilder.Append((string)nmrQgaHS7d4iyPgqr9e(-420743386 ^ -420781722));
					num2 = 11;
					break;
				case 6:
					return new FormatedValue(stringBuilder.ToString());
				case 14:
					if (!x2IOjnHV5xUe7ttNQhs(caption))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 12;
				case 13:
					KDe8yoHNPkRGsApKnrZ(stringBuilder, nmrQgaHS7d4iyPgqr9e(0x3CE17B75 ^ 0x3CE1E8A1));
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					renderMode = ((GenerationContext)Vpt0dGHZO0T75E7EkVs(context)).GetRenderMode();
					num2 = 8;
					break;
				case 8:
					if (renderMode == TemplateRenderMode.HTML)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
						{
							num2 = 0;
						}
						break;
					}
					if (!x2IOjnHV5xUe7ttNQhs(caption))
					{
						goto end_IL_0012;
					}
					goto case 15;
				case 7:
					return new FormatedValue(MvcHtmlString.Create(stringBuilder.ToString()));
				case 9:
					A0UT6sH3BhVImcpAaia(stringBuilder, caption);
					num2 = 15;
					break;
				case 15:
					KDe8yoHNPkRGsApKnrZ(stringBuilder, formatedValue);
					num2 = 6;
					break;
				default:
					KDe8yoHNPkRGsApKnrZ(stringBuilder, nmrQgaHS7d4iyPgqr9e(-521266112 ^ -521238184));
					num2 = 2;
					break;
				case 11:
					KDe8yoHNPkRGsApKnrZ(stringBuilder, formatedValue);
					num2 = 16;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
					{
						num2 = 9;
					}
					break;
				case 2:
					KDe8yoHNPkRGsApKnrZ(stringBuilder, GuHgdSHDkWMvWSaDm90(d2kr0YHPihgXAPZprJg(Vpt0dGHZO0T75E7EkVs(context)), new FormatedValue(caption)));
					num2 = 10;
					break;
				case 5:
					stringBuilder = new StringBuilder();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
					{
						num2 = 4;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 9;
		}
	}

	static NotificationFunctions()
	{
		int num = 4;
		PropertyRowParamIndices propertyRowParamIndices = default(PropertyRowParamIndices);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 10:
					RowChangesIndices = propertyRowParamIndices;
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
					{
						num2 = 8;
					}
					continue;
				default:
					propertyRowParamIndices.NewValue = 0;
					num2 = 7;
					continue;
				case 2:
					RowIndices = propertyRowParamIndices;
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
					{
						num2 = 4;
					}
					continue;
				case 9:
					propertyRowParamIndices = default(PropertyRowParamIndices);
					num2 = 5;
					continue;
				case 1:
					propertyRowParamIndices.OldValue = -1;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					propertyRowParamIndices.OldValue = 0;
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					olc2geHwVWhe9g2KnRQ();
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
					{
						num2 = 3;
					}
					continue;
				case 12:
					return;
				case 11:
					propertyRowParamIndices.Visibility = 2;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
					{
						num2 = 1;
					}
					continue;
				case 6:
					break;
				case 8:
					propertyRowParamIndices.NewValue = 1;
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
					{
						num2 = 13;
					}
					continue;
				case 3:
					propertyRowParamIndices = default(PropertyRowParamIndices);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
					{
						num2 = 1;
					}
					continue;
				case 7:
					propertyRowParamIndices.Caption = 1;
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
					{
						num2 = 11;
					}
					continue;
				case 13:
					propertyRowParamIndices.Caption = 2;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
					{
						num2 = 6;
					}
					continue;
				}
				break;
			}
			propertyRowParamIndices.Visibility = 3;
			num = 10;
		}
	}

	internal static object Vpt0dGHZO0T75E7EkVs(object P_0)
	{
		return ((FunctionEvaluationContext)P_0).GenerationContext;
	}

	internal static TemplateRenderMode YOC3ENHuIEcWULVreyp(object P_0)
	{
		return ((GenerationContext)P_0).GetRenderMode();
	}

	internal static object INCTrIHIxFLySih6GaB(object P_0)
	{
		return ((FormatedValue)P_0).Value;
	}

	internal static bool x2IOjnHV5xUe7ttNQhs(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object nmrQgaHS7d4iyPgqr9e(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object c8ROQcHiDGXgunXqRhZ(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static object LROWAlHR7M37tmoOqEs(object P_0)
	{
		return MvcHtmlString.Create((string)P_0);
	}

	internal static bool XTsqBmHvmqURCBXXMRV()
	{
		return hiRDaTHCJT43IoTHCbc == null;
	}

	internal static NotificationFunctions Nb2WquH8BsrYaZTkXWj()
	{
		return hiRDaTHCJT43IoTHCbc;
	}

	internal static object vq4opWHqq1Wlou3OwR2(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static int XWXL7gHKFBhlpVyu1b6(object P_0)
	{
		return ((List<FormatedValue>)P_0).Count;
	}

	internal static object nWfBImHXN5pWUg2sfcv(object P_0)
	{
		return ((NamedMetadata)P_0).DisplayName;
	}

	internal static object rEYDjQHTkQYWJ4J8JeI(object P_0)
	{
		return GenerateEmptyRow(P_0);
	}

	internal static object xgqfw7HkwKZCLnWlQMY(object P_0, object P_1, object P_2)
	{
		return GenerateRow(P_0, P_1, P_2);
	}

	internal static object VRHx62Hn0NtotfIJTkQ(object P_0, object P_1, object P_2)
	{
		return GenerateFullRow(P_0, P_1, P_2);
	}

	internal static object qOFKoZHOcMA4dkLIBS5(object P_0, object P_1, object P_2)
	{
		return FormatValueChanges(P_0, P_1, P_2);
	}

	internal static bool YhAmYRH2bMipLv0kNpn(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static object IfXrL1HeF3CRYd0uGTI(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object d2kr0YHPihgXAPZprJg(object P_0)
	{
		return ((GenerationContext)P_0).FormatProvider;
	}

	internal static object Gk5L8wH1F98ykrwfNLO(object P_0)
	{
		return ((MetadataBasedFormat)P_0).PropertyMetadata;
	}

	internal static object KDe8yoHNPkRGsApKnrZ(object P_0, object P_1)
	{
		return ((StringBuilder)P_0).Append((string)P_1);
	}

	internal static object A0UT6sH3BhVImcpAaia(object P_0, object P_1)
	{
		return ((StringBuilder)P_0).AppendLine((string)P_1);
	}

	internal static int mPTDmBHpg5eMPyfvoG2(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static int J4Md9qHaGF2jXKsMBcE(object P_0)
	{
		return ((GenerationContext)P_0).GetTextCaptionMaxLength();
	}

	internal static object GuHgdSHDkWMvWSaDm90(object P_0, object P_1)
	{
		return ((IGeneratorFormatProvider)P_0).FormatValue((FormatedValue)P_1);
	}

	internal static object OOmjnpHtVfvs2A3bUeZ(object P_0, object P_1, object P_2)
	{
		return GenerateLiteRow(P_0, P_1, P_2);
	}

	internal static void olc2geHwVWhe9g2KnRQ()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
