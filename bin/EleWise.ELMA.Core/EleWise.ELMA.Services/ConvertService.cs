using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Signatures;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Types;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.UI.Metadata;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Views;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Model.Managers;
using EleWise.ELMA.Core.Services;
using EleWise.ELMA.DataClasses;
using EleWise.ELMA.DTO;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Ioc;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Signatures;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Scripts.Models;

namespace EleWise.ELMA.Services;

[Service]
internal sealed class ConvertService : IConvertService, IClientConvertService
{
	private sealed class _003C_003Ec__DisplayClass9_0
	{
		public IMetadata metadata;

		internal bool _003CToString_003Eb__0(DataClassMetadata d)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			return ((IMetadata)d).get_Uid() == metadata.get_Uid();
		}
	}

	[StructLayout(3)]
	private struct _003CToString_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public TypeSignature typeSignature;

		public ConvertService _003C_003E4__this;

		private _003C_003Ec__DisplayClass9_0 _003C_003E8__1;

		public CodeType codeType;

		private ITypeDescriptor _003CtypeDescriptor_003E5__2;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_0271: Unknown result type (might be due to invalid IL or missing references)
			//IL_0306: Unknown result type (might be due to invalid IL or missing references)
			//IL_030b: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			ConvertService convertService = _003C_003E4__this;
			string result;
			try
			{
				TaskAwaiter<IMetadata> val;
				string text;
				IMetadata result2;
				EnumMetadata val2;
				IMetadata result3;
				ClassMetadata val3;
				IMetadata result4;
				IMetadata metadata;
				ClassMetadata val4;
				IMetadata metadata2;
				DataClassMetadata val5;
				ComponentMetadata val6;
				switch (num)
				{
				default:
					text = "";
					if (typeSignature == null || typeSignature.TypeUid == Guid.Empty)
					{
						result = text;
					}
					else
					{
						ValueTuple<System.Type, ITypeDescriptor> runtimeType = convertService.GetRuntimeType(typeSignature);
						System.Type item = runtimeType.Item1;
						_003CtypeDescriptor_003E5__2 = runtimeType.Item2;
						if (item != null)
						{
							if (item == typeof(ReactiveProxy) || item == typeof(ProxyType))
							{
								_003C_003E8__1 = new _003C_003Ec__DisplayClass9_0();
								val = convertService.metadataService.GetMetadataAsync(typeSignature.SubTypeUid).GetAwaiter();
								if (!val.get_IsCompleted())
								{
									num = (_003C_003E1__state = 0);
									_003C_003Eu__1 = val;
									_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<IMetadata>, _003CToString_003Ed__9>(ref val, ref this);
									return;
								}
								goto IL_010c;
							}
							if (item == typeof(Entity))
							{
								val = convertService.metadataService.GetMetadataAsync(typeSignature.SubTypeUid).GetAwaiter();
								if (!val.get_IsCompleted())
								{
									num = (_003C_003E1__state = 1);
									_003C_003Eu__1 = val;
									_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<IMetadata>, _003CToString_003Ed__9>(ref val, ref this);
									return;
								}
								goto IL_0225;
							}
							if (item == typeof(EnumWrapper))
							{
								val = convertService.metadataService.GetMetadataAsync(typeSignature.SubTypeUid).GetAwaiter();
								if (!val.get_IsCompleted())
								{
									num = (_003C_003E1__state = 2);
									_003C_003Eu__1 = val;
									_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<IMetadata>, _003CToString_003Ed__9>(ref val, ref this);
									return;
								}
								goto IL_02cc;
							}
							text = GetSimpleTypeString(item);
							break;
						}
						result = text;
					}
					goto end_IL_000e;
				case 0:
					val = (TaskAwaiter<IMetadata>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_010c;
				case 1:
					val = (TaskAwaiter<IMetadata>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_0225;
				case 2:
					{
						val = (TaskAwaiter<IMetadata>)_003C_003Eu__1;
						_003C_003Eu__1 = null;
						num = (_003C_003E1__state = -1);
						goto IL_02cc;
					}
					IL_02cc:
					result2 = val.GetResult();
					text = (((val2 = (EnumMetadata)(object)((result2 is EnumMetadata) ? result2 : null)) != null) ? ((ICodeItemMetadata)val2).get_FullTypeName() : typeof(int).get_FullName());
					break;
					IL_0225:
					result3 = val.GetResult();
					text = (((val3 = (ClassMetadata)(object)((result3 is ClassMetadata) ? result3 : null)) != null) ? ((ICodeItemMetadata)val3).get_FullTypeName() : typeof(Entity).get_FullName());
					break;
					IL_010c:
					result4 = val.GetResult();
					_003C_003E8__1.metadata = result4;
					metadata = _003C_003E8__1.metadata;
					text = (((val4 = (ClassMetadata)(object)((metadata is ClassMetadata) ? metadata : null)) != null) ? ((ICodeItemMetadata)val4).get_FullTypeName() : typeof(ReactiveProxy).get_FullName());
					metadata2 = _003C_003E8__1.metadata;
					if ((val5 = (DataClassMetadata)(object)((metadata2 is DataClassMetadata) ? metadata2 : null)) != null && (val6 = (ComponentMetadata)/*isinst with value type is only supported in some contexts*/) != null && Enumerable.Any<DataClassMetadata>((System.Collections.Generic.IEnumerable<DataClassMetadata>)val6.get_DataClasses(), (Func<DataClassMetadata, bool>)((DataClassMetadata d) => ((IMetadata)d).get_Uid() == _003C_003E8__1.metadata.get_Uid())))
					{
						text = ((INamedMetadata)val5).get_Name();
					}
					_003C_003E8__1 = null;
					break;
				}
				result = ((_003CtypeDescriptor_003E5__2.Uid == ListOfSimpleTypeDescriptor.UID && codeType == CodeType.Client) ? ("ICollection<" + text + ">") : ((typeSignature.RelationType != 0) ? ((codeType != CodeType.Server && codeType != CodeType.GlobalFunction) ? ("System.Collections.Generic.ICollection<" + text + ">") : (text + "[]")) : ((!typeSignature.Nullable || !_003CtypeDescriptor_003E5__2.CanBeNullable) ? text : ("System.Nullable<" + text + ">"))));
				end_IL_000e:;
			}
			catch (System.Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult(result);
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}
	}

	private sealed class _003C_003Ec__DisplayClass12_0
	{
		public IMetadata metadata;

		internal bool _003CTypeValueString_003Eb__0(DataClassMetadata d)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			return ((IMetadata)d).get_Uid() == metadata.get_Uid();
		}
	}

	[StructLayout(3)]
	private struct _003CTypeValueString_003Ed__12 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public TypeSignature typeSignature;

		public ConvertService _003C_003E4__this;

		private _003C_003Ec__DisplayClass12_0 _003C_003E8__1;

		public CodeType codeType;

		private ITypeDescriptor _003CtypeDescriptor_003E5__2;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0280: Unknown result type (might be due to invalid IL or missing references)
			//IL_0352: Unknown result type (might be due to invalid IL or missing references)
			//IL_0357: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			ConvertService convertService = _003C_003E4__this;
			string result;
			try
			{
				TaskAwaiter<IMetadata> val;
				string text2;
				string text;
				IMetadata result2;
				IMetadata metadata;
				ClassMetadata val2;
				IMetadata metadata2;
				DataClassMetadata val3;
				ComponentMetadata val4;
				IMetadata result3;
				EnumMetadata val5;
				IMetadata result4;
				ClassMetadata val7;
				switch (num)
				{
				default:
					text = "";
					if (typeSignature == null || typeSignature.TypeUid == Guid.Empty)
					{
						result = text;
					}
					else
					{
						ValueTuple<System.Type, ITypeDescriptor> runtimeType = convertService.GetRuntimeType(typeSignature);
						System.Type item = runtimeType.Item1;
						_003CtypeDescriptor_003E5__2 = runtimeType.Item2;
						if (item != null)
						{
							if (item == typeof(ReactiveProxy) || item == typeof(ProxyType))
							{
								_003C_003E8__1 = new _003C_003Ec__DisplayClass12_0();
								val = convertService.metadataService.GetMetadataAsync(typeSignature.SubTypeUid).GetAwaiter();
								if (!val.get_IsCompleted())
								{
									num = (_003C_003E1__state = 0);
									_003C_003Eu__1 = val;
									_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<IMetadata>, _003CTypeValueString_003Ed__12>(ref val, ref this);
									return;
								}
								goto IL_010c;
							}
							if (item == typeof(Entity))
							{
								val = convertService.metadataService.GetMetadataAsync(typeSignature.SubTypeUid).GetAwaiter();
								if (!val.get_IsCompleted())
								{
									num = (_003C_003E1__state = 1);
									_003C_003Eu__1 = val;
									_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<IMetadata>, _003CTypeValueString_003Ed__12>(ref val, ref this);
									return;
								}
								goto IL_022d;
							}
							if (item == typeof(EnumWrapper))
							{
								val = convertService.metadataService.GetMetadataAsync(typeSignature.SubTypeUid).GetAwaiter();
								if (!val.get_IsCompleted())
								{
									num = (_003C_003E1__state = 2);
									_003C_003Eu__1 = val;
									_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<IMetadata>, _003CTypeValueString_003Ed__12>(ref val, ref this);
									return;
								}
								goto IL_02db;
							}
							text2 = GetSimpleTypeString(item);
							text = GetSimpleTypeDefaultValueString(item);
							break;
						}
						result = text;
					}
					goto end_IL_000e;
				case 0:
					val = (TaskAwaiter<IMetadata>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_010c;
				case 1:
					val = (TaskAwaiter<IMetadata>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_022d;
				case 2:
					{
						val = (TaskAwaiter<IMetadata>)_003C_003Eu__1;
						_003C_003Eu__1 = null;
						num = (_003C_003E1__state = -1);
						goto IL_02db;
					}
					IL_010c:
					result2 = val.GetResult();
					_003C_003E8__1.metadata = result2;
					metadata = _003C_003E8__1.metadata;
					text2 = (((val2 = (ClassMetadata)(object)((metadata is ClassMetadata) ? metadata : null)) != null) ? ((ICodeItemMetadata)val2).get_FullTypeName() : typeof(ReactiveProxy).get_FullName());
					metadata2 = _003C_003E8__1.metadata;
					if ((val3 = (DataClassMetadata)(object)((metadata2 is DataClassMetadata) ? metadata2 : null)) != null && (val4 = (ComponentMetadata)/*isinst with value type is only supported in some contexts*/) != null && Enumerable.Any<DataClassMetadata>((System.Collections.Generic.IEnumerable<DataClassMetadata>)val4.get_DataClasses(), (Func<DataClassMetadata, bool>)((DataClassMetadata d) => ((IMetadata)d).get_Uid() == _003C_003E8__1.metadata.get_Uid())))
					{
						text2 = ((INamedMetadata)val3).get_Name();
					}
					text = "null";
					_003C_003E8__1 = null;
					break;
					IL_02db:
					result3 = val.GetResult();
					if ((val5 = (EnumMetadata)(object)((result3 is EnumMetadata) ? result3 : null)) != null)
					{
						EnumValueMetadata val6 = Enumerable.FirstOrDefault<EnumValueMetadata>((System.Collections.Generic.IEnumerable<EnumValueMetadata>)val5.get_Values());
						if (val6 != null)
						{
							text2 = ((ICodeItemMetadata)val5).get_FullTypeName();
							text = text2 + "." + ((INamedMetadata)val6).get_Name();
						}
						else
						{
							text2 = "int";
							text = "0";
						}
					}
					else
					{
						text2 = "int";
						text = "0";
					}
					break;
					IL_022d:
					result4 = val.GetResult();
					text2 = (((val7 = (ClassMetadata)(object)((result4 is ClassMetadata) ? result4 : null)) != null) ? ((ICodeItemMetadata)val7).get_FullTypeName() : typeof(Entity).get_FullName());
					text = "null";
					break;
				}
				result = ((_003CtypeDescriptor_003E5__2.Uid == ListOfSimpleTypeDescriptor.UID && codeType == CodeType.Client) ? ("new " + text2 + "[0]") : ((typeSignature.RelationType != 0) ? ((codeType != CodeType.Server && codeType != CodeType.GlobalFunction) ? ("System.Collections.Generic.List<" + text2 + ">()") : ("new " + text2 + "[0]")) : ((!typeSignature.Nullable || !_003CtypeDescriptor_003E5__2.CanBeNullable) ? text : "null")));
				end_IL_000e:;
			}
			catch (System.Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult(result);
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(3)]
	private struct _003CGetTypeName_003Ed__15 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public INamedMetadata metadata;

		public ConvertService _003C_003E4__this;

		private PropertyMetadata _003Cproperty_003E5__2;

		private Guid _003CtypeUid_003E5__3;

		private string _003CactionTypeName_003E5__4;

		private ActionSettings _003CactionSettings_003E5__5;

		private string _003CparameterString_003E5__6;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_007e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Unknown result type (might be due to invalid IL or missing references)
			//IL_008e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0093: Unknown result type (might be due to invalid IL or missing references)
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00da: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0104: Unknown result type (might be due to invalid IL or missing references)
			//IL_011a: Unknown result type (might be due to invalid IL or missing references)
			//IL_011f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0139: Unknown result type (might be due to invalid IL or missing references)
			//IL_013e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0150: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0347: Unknown result type (might be due to invalid IL or missing references)
			//IL_034c: Unknown result type (might be due to invalid IL or missing references)
			//IL_037f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0384: Unknown result type (might be due to invalid IL or missing references)
			//IL_0391: Unknown result type (might be due to invalid IL or missing references)
			//IL_0396: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ef: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			ConvertService convertService = _003C_003E4__this;
			string result;
			try
			{
				Guid subTypeUid;
				TaskAwaiter<string> val2;
				TaskAwaiter<MetadataHeader> val;
				string text;
				TypeSignature typeSignature2;
				string result2;
				switch (num)
				{
				default:
					if (metadata == null)
					{
						result = "";
					}
					else
					{
						INamedMetadata obj = metadata;
						DataClassMetadata val3;
						if ((val3 = (DataClassMetadata)(object)((obj is DataClassMetadata) ? obj : null)) != null)
						{
							result = ((INamedMetadata)val3).get_Name();
						}
						else
						{
							ref PropertyMetadata reference = ref _003Cproperty_003E5__2;
							INamedMetadata obj2 = metadata;
							if ((reference = (PropertyMetadata)(object)((obj2 is PropertyMetadata) ? obj2 : null)) == null)
							{
								result = metadata.get_Name();
							}
							else
							{
								_003CtypeUid_003E5__3 = ((IPropertyMetadata)_003Cproperty_003E5__2).get_TypeUid();
								subTypeUid = ((IPropertyMetadata)_003Cproperty_003E5__2).get_SubTypeUid();
								if (!(_003CtypeUid_003E5__3 != EntityDescriptor.UID) || !(_003CtypeUid_003E5__3 != DocumentTypeDescriptor.UID) || !(_003CtypeUid_003E5__3 != ProjectTypeDescriptor.UID) || !(_003CtypeUid_003E5__3 != RegistrationCardTypeDescriptor.UID) || !(_003CtypeUid_003E5__3 != DataClassDescriptor.UID) || !(_003CtypeUid_003E5__3 != EnumDescriptor.UID))
								{
									goto IL_02cd;
								}
								ITypeDescriptor typeDescriptor = convertService.descriptorService.GetTypeDescriptor(_003CtypeUid_003E5__3, subTypeUid);
								if (!(typeDescriptor is IPropertyTypeInfo propertyTypeInfo))
								{
									goto IL_02cd;
								}
								if (typeDescriptor.Uid == ActionDescriptor.UID)
								{
									_003CactionTypeName_003E5__4 = propertyTypeInfo.GetTypeDisplayName(subTypeUid);
									ref ActionSettings reference2 = ref _003CactionSettings_003E5__5;
									TypeSettings settings = ((IPropertyMetadata)_003Cproperty_003E5__2).get_Settings();
									if ((reference2 = (ActionSettings)(object)((settings is ActionSettings) ? settings : null)) != null)
									{
										TypeSignature typeSignature = DynamicPropertyHelper.TypeSignatureMapToObject(_003CactionSettings_003E5__5.get_ParameterType());
										val2 = convertService.ToString(typeSignature, CodeType.Client).GetAwaiter();
										if (!val2.get_IsCompleted())
										{
											num = (_003C_003E1__state = 0);
											_003C_003Eu__1 = val2;
											_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<string>, _003CGetTypeName_003Ed__15>(ref val2, ref this);
											return;
										}
										goto IL_01e9;
									}
									_003CactionTypeName_003E5__4 = null;
									_003CactionSettings_003E5__5 = null;
								}
								result = propertyTypeInfo.GetTypeDisplayName(subTypeUid);
							}
						}
					}
					goto end_IL_000e;
				case 0:
					val2 = (TaskAwaiter<string>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_01e9;
				case 1:
					val2 = (TaskAwaiter<string>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_0267;
				case 2:
					{
						val = (TaskAwaiter<MetadataHeader>)_003C_003Eu__1;
						_003C_003Eu__1 = null;
						num = (_003C_003E1__state = -1);
						break;
					}
					IL_01e9:
					text = (_003CparameterString_003E5__6 = val2.GetResult());
					typeSignature2 = DynamicPropertyHelper.TypeSignatureMapToObject(_003CactionSettings_003E5__5.get_ReturnType());
					val2 = convertService.ToString(typeSignature2, CodeType.Client).GetAwaiter();
					if (!val2.get_IsCompleted())
					{
						num = (_003C_003E1__state = 1);
						_003C_003Eu__1 = val2;
						_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<string>, _003CGetTypeName_003Ed__15>(ref val2, ref this);
						return;
					}
					goto IL_0267;
					IL_02cd:
					val = convertService.metadataService.GetMetadataHeader(subTypeUid).GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 2);
						_003C_003Eu__1 = val;
						_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<MetadataHeader>, _003CGetTypeName_003Ed__15>(ref val, ref this);
						return;
					}
					break;
					IL_0267:
					result2 = val2.GetResult();
					result = string.Concat(new string[6] { _003CactionTypeName_003E5__4, "<", _003CparameterString_003E5__6, ", ", result2, ">" });
					goto end_IL_000e;
				}
				MetadataHeader result3 = val.GetResult();
				if (result3 == null)
				{
					result = "";
				}
				else
				{
					bool flag = false;
					DataClassSettings val4;
					EntitySettings val5;
					EnumSettings val6;
					if (_003CtypeUid_003E5__3 == DataClassDescriptor.UID && (val4 = (DataClassSettings)/*isinst with value type is only supported in some contexts*/) != null)
					{
						flag = val4.get_RelationType() != 0;
					}
					else if ((_003CtypeUid_003E5__3 == EntityDescriptor.UID || _003CtypeUid_003E5__3 == DocumentTypeDescriptor.UID || _003CtypeUid_003E5__3 == ProjectTypeDescriptor.UID || _003CtypeUid_003E5__3 == RegistrationCardTypeDescriptor.UID) && (val5 = (EntitySettings)/*isinst with value type is only supported in some contexts*/) != null)
					{
						flag = val5.get_RelationType() != 0;
					}
					else if (_003CtypeUid_003E5__3 == EnumDescriptor.UID && (val6 = (EnumSettings)/*isinst with value type is only supported in some contexts*/) != null)
					{
						flag = val6.get_RelationType() != 0;
					}
					string displayName = result3.get_DisplayName();
					result = (flag ? SR.T("Список<{0}>", displayName) : displayName);
				}
				end_IL_000e:;
			}
			catch (System.Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult(result);
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(3)]
	private struct _003CGetTypeName_003Ed__16 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public Guid typeUid;

		public ConvertService _003C_003E4__this;

		public Guid subTypeUid;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Unknown result type (might be due to invalid IL or missing references)
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			//IL_0075: Unknown result type (might be due to invalid IL or missing references)
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0093: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			ConvertService convertService = _003C_003E4__this;
			string result;
			try
			{
				TaskAwaiter<MetadataHeader> val;
				if (num == 0)
				{
					val = (TaskAwaiter<MetadataHeader>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_012a;
				}
				if (!(typeUid != EntityDescriptor.UID) || !(typeUid != DocumentTypeDescriptor.UID) || !(typeUid != ProjectTypeDescriptor.UID) || !(typeUid != RegistrationCardTypeDescriptor.UID) || !(typeUid != DataClassDescriptor.UID) || !(typeUid != EnumDescriptor.UID))
				{
					val = convertService.metadataService.GetMetadataHeader(subTypeUid).GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val;
						_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<MetadataHeader>, _003CGetTypeName_003Ed__16>(ref val, ref this);
						return;
					}
					goto IL_012a;
				}
				ITypeDescriptor typeDescriptor = convertService.descriptorService.GetTypeDescriptor(typeUid, subTypeUid);
				result = ((!(typeDescriptor is IPropertyTypeInfo propertyTypeInfo)) ? typeDescriptor.Name : propertyTypeInfo.GetTypeDisplayName(subTypeUid));
				goto end_IL_000e;
				IL_012a:
				MetadataHeader result2 = val.GetResult();
				result = ((result2 != null) ? result2.get_DisplayName() : "");
				end_IL_000e:;
			}
			catch (System.Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult(result);
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}
	}

	private readonly IMetadataServiceContext metadataService;

	private readonly IDescriptorService descriptorService;

	private readonly ILazy<ICurrentPageService> lazyCurrentPageService;

	private ICurrentPageService currentPageService => lazyCurrentPageService.Value();

	public ConvertService(IMetadataServiceContext metadataService, IDescriptorService descriptorService, ILazy<ICurrentPageService> lazyCurrentPageService)
	{
		this.metadataService = metadataService;
		this.descriptorService = descriptorService;
		this.lazyCurrentPageService = lazyCurrentPageService;
	}

	public System.Type ToType(TypeSignature typeSignature)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		if (typeSignature == null)
		{
			return null;
		}
		if (typeSignature.TypeUid == Guid.Empty)
		{
			return null;
		}
		ValueTuple<System.Type, ITypeDescriptor> runtimeType = GetRuntimeType(typeSignature);
		System.Type type = runtimeType.Item1;
		ITypeDescriptor item = runtimeType.Item2;
		if (type == null)
		{
			return null;
		}
		if (typeSignature.RelationType != 0)
		{
			type = typeof(System.Collections.Generic.ICollection<>).MakeGenericType(new System.Type[1] { type });
		}
		if (typeSignature.Nullable && item != null && item.CanBeNullable)
		{
			return typeof(System.Nullable<>).MakeGenericType(new System.Type[1] { type });
		}
		return type;
	}

	public System.Threading.Tasks.Task<string> ToString(InputComputedValue inputComputedValue, CodeType codeType)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		TypeSignature typeSignature = new TypeSignature();
		typeSignature.TypeUid = inputComputedValue.TypeUid;
		typeSignature.SubTypeUid = inputComputedValue.SubTypeUid;
		typeSignature.Nullable = inputComputedValue.Nullable;
		typeSignature.RelationType = inputComputedValue.RelationType;
		return ToString(typeSignature, codeType);
	}

	public System.Threading.Tasks.Task<string> ToString(TypeSignature typeSignature, CodeType codeType)
	{
		TypeSignature typeSignature2 = DynamicPropertyHelper.TypeSignatureMapToObject(typeSignature);
		return ToString(typeSignature2, codeType);
	}

	public System.Threading.Tasks.Task<string> ToString(TypeSignature typeSignature, CodeType codeType)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		_003CToString_003Ed__9 _003CToString_003Ed__ = default(_003CToString_003Ed__9);
		_003CToString_003Ed__._003C_003E4__this = this;
		_003CToString_003Ed__.typeSignature = typeSignature;
		_003CToString_003Ed__.codeType = codeType;
		_003CToString_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<string>.Create();
		_003CToString_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<string> _003C_003Et__builder = _003CToString_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CToString_003Ed__9>(ref _003CToString_003Ed__);
		return _003CToString_003Ed__._003C_003Et__builder.get_Task();
	}

	public System.Threading.Tasks.Task<string> TypeValueString(InputComputedValue computedValue, CodeType codeType)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		TypeSignature typeSignature = new TypeSignature
		{
			Nullable = computedValue.get_Nullable(),
			RelationType = computedValue.get_RelationType(),
			TypeUid = computedValue.get_TypeUid(),
			SubTypeUid = computedValue.get_SubTypeUid()
		};
		return TypeValueString(typeSignature, codeType);
	}

	public System.Threading.Tasks.Task<string> TypeValueString(TypeSignature typeSignature, CodeType codeType)
	{
		TypeSignature typeSignature2 = DynamicPropertyHelper.TypeSignatureMapToObject(typeSignature);
		return TypeValueString(typeSignature2, codeType);
	}

	public System.Threading.Tasks.Task<string> TypeValueString(TypeSignature typeSignature, CodeType codeType)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		_003CTypeValueString_003Ed__12 _003CTypeValueString_003Ed__ = default(_003CTypeValueString_003Ed__12);
		_003CTypeValueString_003Ed__._003C_003E4__this = this;
		_003CTypeValueString_003Ed__.typeSignature = typeSignature;
		_003CTypeValueString_003Ed__.codeType = codeType;
		_003CTypeValueString_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<string>.Create();
		_003CTypeValueString_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<string> _003C_003Et__builder = _003CTypeValueString_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CTypeValueString_003Ed__12>(ref _003CTypeValueString_003Ed__);
		return _003CTypeValueString_003Ed__._003C_003Et__builder.get_Task();
	}

	public string ToString(System.Type type)
	{
		if (type == typeof(void))
		{
			return "void";
		}
		bool flag = type.IsNullableType();
		if (flag)
		{
			type = type.GetNonNullableType();
		}
		if (type.get_IsGenericType())
		{
			string name = type.GetGenericTypeDefinition().get_Name();
			return name.Substring(0, name.IndexOf("`", (StringComparison)0)) + "<" + string.Join(",", (System.Collections.Generic.IEnumerable<string>)Enumerable.Select<System.Type, string>((System.Collections.Generic.IEnumerable<System.Type>)type.GetGenericArguments(), (Func<System.Type, string>)ToString)) + ">";
		}
		string text = GetSimpleTypeString(type);
		if (flag)
		{
			text = "Nullable<" + text + ">";
		}
		return text;
	}

	public TypeSignature ToSignature(System.Type type)
	{
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		TypeSignature typeSignature = new TypeSignature();
		if (type == typeof(void))
		{
			return typeSignature;
		}
		if (type.IsNullableType())
		{
			typeSignature.Nullable = true;
			type = type.GetNonNullableType();
		}
		if (type.get_IsGenericType() && typeof(System.Collections.Generic.ICollection<>).IsAssignableFrom(type.GetGenericTypeDefinition()))
		{
			typeSignature.RelationType = 2;
			type = Enumerable.FirstOrDefault<System.Type>((System.Collections.Generic.IEnumerable<System.Type>)type.GetGenericArguments());
		}
		if (typeof(IDataClass).IsAssignableFrom(type))
		{
			typeSignature.TypeUid = DataClassDescriptor.UID;
		}
		else if (type == typeof(Entity))
		{
			typeSignature.TypeUid = EntityDescriptor.UID;
		}
		else if (type.get_IsEnum())
		{
			typeSignature.TypeUid = EnumDescriptor.UID;
		}
		else
		{
			ITypeDescriptor typeDescriptor = descriptorService.GetTypeDescriptor(type);
			if (typeDescriptor != null)
			{
				typeSignature.TypeUid = typeDescriptor.Uid;
				typeSignature.SubTypeUid = typeDescriptor.SubTypeUid;
			}
		}
		return typeSignature;
	}

	public System.Threading.Tasks.Task<string> GetTypeName(INamedMetadata metadata)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003CGetTypeName_003Ed__15 _003CGetTypeName_003Ed__ = default(_003CGetTypeName_003Ed__15);
		_003CGetTypeName_003Ed__._003C_003E4__this = this;
		_003CGetTypeName_003Ed__.metadata = metadata;
		_003CGetTypeName_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<string>.Create();
		_003CGetTypeName_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<string> _003C_003Et__builder = _003CGetTypeName_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CGetTypeName_003Ed__15>(ref _003CGetTypeName_003Ed__);
		return _003CGetTypeName_003Ed__._003C_003Et__builder.get_Task();
	}

	public System.Threading.Tasks.Task<string> GetTypeName(Guid typeUid, Guid subTypeUid)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		_003CGetTypeName_003Ed__16 _003CGetTypeName_003Ed__ = default(_003CGetTypeName_003Ed__16);
		_003CGetTypeName_003Ed__._003C_003E4__this = this;
		_003CGetTypeName_003Ed__.typeUid = typeUid;
		_003CGetTypeName_003Ed__.subTypeUid = subTypeUid;
		_003CGetTypeName_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<string>.Create();
		_003CGetTypeName_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<string> _003C_003Et__builder = _003CGetTypeName_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CGetTypeName_003Ed__16>(ref _003CGetTypeName_003Ed__);
		return _003CGetTypeName_003Ed__._003C_003Et__builder.get_Task();
	}

	public System.Threading.Tasks.Task<string> GetTypeName(DataClass dto)
	{
		return GetTypeName((INamedMetadata)(object)((dto is INamedMetadata) ? dto : null));
	}

	private static string GetSimpleTypeString(System.Type type)
	{
		string result = type.get_Name();
		if (type == typeof(Guid))
		{
			result = "Guid";
		}
		else if (type == typeof(System.DateTime))
		{
			result = "DateTime";
		}
		else if (type == typeof(bool))
		{
			result = "bool";
		}
		else if (type == typeof(float))
		{
			result = "float";
		}
		else if (type == typeof(double))
		{
			result = "double";
		}
		else if (type == typeof(short))
		{
			result = "short";
		}
		else if (type == typeof(int))
		{
			result = "int";
		}
		else if (type == typeof(long))
		{
			result = "long";
		}
		else if (type == typeof(TimeSpan))
		{
			result = "TimeSpan";
		}
		else if (type == typeof(Money))
		{
			result = "Money";
		}
		else if (type == typeof(StringSettings) || type == typeof(string))
		{
			result = "string";
		}
		else if (type == typeof(Entity))
		{
			result = typeof(Entity).get_FullName();
		}
		return result;
	}

	private static string GetSimpleTypeDefaultValueString(System.Type type)
	{
		string result = "null";
		if (type == typeof(Guid))
		{
			result = "System.Guid.Empty";
		}
		else if (type == typeof(System.DateTime))
		{
			result = "System.DateTime.Now";
		}
		else if (type == typeof(bool))
		{
			result = "false";
		}
		else if (type == typeof(float))
		{
			result = "0";
		}
		else if (type == typeof(double))
		{
			result = "0";
		}
		else if (type == typeof(short))
		{
			result = "0";
		}
		else if (type == typeof(int))
		{
			result = "0";
		}
		else if (type == typeof(long))
		{
			result = "0";
		}
		else
		{
			if (type == typeof(TimeSpan))
			{
				return "System.TimeSpan.Zero";
			}
			if (type == typeof(Money))
			{
				result = "0";
			}
			else if (type == typeof(WorkTime))
			{
				result = "0";
			}
			else if (type == typeof(byte[]))
			{
				result = "new byte[0]";
			}
			else if (type == typeof(StringSettings) || type == typeof(string))
			{
				result = "null";
			}
			else if (type == typeof(Entity))
			{
				result = "null";
			}
			else if (type == typeof(Int16Range))
			{
				result = "new EleWise.ELMA.Model.Ranges.Int16Range()";
			}
			else if (type == typeof(Int32Range))
			{
				result = "new EleWise.ELMA.Model.Ranges.Int32Range()";
			}
			else if (type == typeof(Int64Range))
			{
				result = "new EleWise.ELMA.Model.Ranges.Int64Range()";
			}
			else if (type == typeof(MoneyRange))
			{
				result = "new EleWise.ELMA.Model.Ranges.MoneyRange()";
			}
			else if (type == typeof(DoubleRange))
			{
				result = "new EleWise.ELMA.Model.Ranges.DoubleRange()";
			}
			else if (type == typeof(DateTimeRange))
			{
				result = "new EleWise.ELMA.Model.Ranges.DateTimeRange()";
			}
		}
		return result;
	}

	private ValueTuple<System.Type, ITypeDescriptor> GetRuntimeType(TypeSignature typeSignature)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		ITypeDescriptor typeDescriptor = descriptorService.GetTypeDescriptor(typeSignature.TypeUid, typeSignature.SubTypeUid);
		if (typeDescriptor is IRuntimeTypeDescriptor runtimeTypeDescriptor && runtimeTypeDescriptor.IsRuntimeType)
		{
			if (typeSignature.TypeUid == ListOfSimpleTypeDescriptor.UID && typeSignature.SubTypeUid != Guid.Empty && descriptorService.GetTypeDescriptor(typeSignature.SubTypeUid, Guid.Empty) is IRuntimeTypeDescriptor runtimeTypeDescriptor2)
			{
				return new ValueTuple<System.Type, ITypeDescriptor>(runtimeTypeDescriptor2.RuntimeType, typeDescriptor);
			}
			return new ValueTuple<System.Type, ITypeDescriptor>(runtimeTypeDescriptor.RuntimeType, typeDescriptor);
		}
		if (typeSignature.TypeUid == DataClassDescriptor.UID)
		{
			return new ValueTuple<System.Type, ITypeDescriptor>(typeof(ReactiveProxy), typeDescriptor);
		}
		if (typeSignature.TypeUid == EntityDescriptor.UID || typeSignature.TypeUid == DocumentTypeDescriptor.UID || typeSignature.TypeUid == ProjectTypeDescriptor.UID || typeSignature.TypeUid == RegistrationCardTypeDescriptor.UID)
		{
			return new ValueTuple<System.Type, ITypeDescriptor>(typeof(Entity), typeDescriptor);
		}
		if (typeSignature.TypeUid == EnumDescriptor.UID)
		{
			return new ValueTuple<System.Type, ITypeDescriptor>(typeof(EnumWrapper), typeDescriptor);
		}
		if (typeSignature.TypeUid == TextDescriptor.UID)
		{
			return new ValueTuple<System.Type, ITypeDescriptor>(typeof(string), typeDescriptor);
		}
		return new ValueTuple<System.Type, ITypeDescriptor>((System.Type)null, (ITypeDescriptor)null);
	}
}
