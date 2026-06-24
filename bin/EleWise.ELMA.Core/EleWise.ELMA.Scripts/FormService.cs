using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Cache;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.Abstractions.Metadata.Models;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Types;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.UI;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Services;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Serialization;
using Microsoft.CSharp.RuntimeBinder;

namespace EleWise.ELMA.Scripts;

[Service]
internal sealed class FormService : IFormService
{
	private static class _003C_003Eo__5
	{
		public static CallSite<Func<CallSite, object, FormViewItem>> _003C_003Ep__0;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<ViewItem, bool> _003C_003E9__6_0;

		public static Func<ComputedValue, bool> _003C_003E9__7_2;

		public static Func<ComputedValue, bool> _003C_003E9__7_3;

		internal bool _003CUpdateForm_003Eb__6_0(ViewItem item)
		{
			return item is PropertyViewItem;
		}

		internal bool _003CProcessPropertyViewItem_003Eb__7_2(ComputedValue a)
		{
			if (a.Name == "ReadOnly")
			{
				if (a.ComputedValueType != 1)
				{
					return a.ComputedValueType == 2;
				}
				return true;
			}
			return false;
		}

		internal bool _003CProcessPropertyViewItem_003Eb__7_3(ComputedValue a)
		{
			if (a.Name == "Hide")
			{
				if (a.ComputedValueType != 1)
				{
					return a.ComputedValueType == 2;
				}
				return true;
			}
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public string expr;

		internal bool _003CProcessPropertyViewItem_003Eb__1(ComputedValue a)
		{
			if (a.Name == expr)
			{
				if (a.ComputedValueType != 1)
				{
					return a.ComputedValueType == 2;
				}
				return true;
			}
			return false;
		}
	}

	private readonly INotificationService notificationService;

	private readonly IScriptLoaderService scriptLoaderService;

	private readonly IMetadataRegistrationService metadataRegistrationService;

	private readonly IMetadataCacheService metadataCacheService;

	public FormService(INotificationService notificationService, IScriptLoaderService scriptLoaderService, IMetadataRegistrationService metadataRegistrationService, IMetadataCacheService metadataCacheService)
	{
		this.notificationService = notificationService;
		this.scriptLoaderService = scriptLoaderService;
		this.metadataRegistrationService = metadataRegistrationService;
		this.metadataCacheService = metadataCacheService;
	}

	public void ProcessForm(EntityFormView model)
	{
		if (model == null)
		{
			return;
		}
		ClassMetadata metadata = model.get_Metadata();
		if (metadata != null)
		{
			metadataRegistrationService.Register((IMetadata)(object)metadata);
			EntityMetadata val;
			if ((val = (EntityMetadata)(object)((metadata is EntityMetadata) ? metadata : null)) != null && val.get_ViewModelMetadata() != null)
			{
				metadataRegistrationService.Register((IMetadata)(object)val.get_ViewModelMetadata());
			}
			metadataCacheService.Cache((System.Collections.Generic.IEnumerable<IMetadata>)(object)new ClassMetadata[1] { metadata });
		}
		System.Collections.Generic.ICollection<IMetadata> additionalMetadata = model.get_AdditionalMetadata();
		if (model.get_AdditionalMetadata() != null && model.get_AdditionalMetadata().get_Count() != 0)
		{
			System.Collections.Generic.IEnumerator<IMetadata> enumerator = ((System.Collections.Generic.IEnumerable<IMetadata>)additionalMetadata).GetEnumerator();
			try
			{
				while (((System.Collections.IEnumerator)enumerator).MoveNext())
				{
					IMetadata current = enumerator.get_Current();
					metadataRegistrationService.Register(current);
					EntityMetadata val2;
					if ((val2 = (EntityMetadata)(object)((metadata is EntityMetadata) ? metadata : null)) != null && val2.get_ViewModelMetadata() != null)
					{
						metadataRegistrationService.Register((IMetadata)(object)val2.get_ViewModelMetadata());
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator)?.Dispose();
			}
			metadataCacheService.Cache((System.Collections.Generic.IEnumerable<IMetadata>)additionalMetadata);
		}
		if (model.get_ClientScriptModels() != null)
		{
			System.Collections.Generic.IEnumerator<ClientScriptModel> enumerator2 = ((System.Collections.Generic.IEnumerable<ClientScriptModel>)model.get_ClientScriptModels()).GetEnumerator();
			try
			{
				while (((System.Collections.IEnumerator)enumerator2).MoveNext())
				{
					ClientScriptModel current2 = enumerator2.get_Current();
					if (current2 != null)
					{
						scriptLoaderService.ApplyScript(current2.get_AssemblyName(), current2.get_SourceCode());
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator2)?.Dispose();
			}
		}
		if (_003C_003Eo__5._003C_003Ep__0 == null)
		{
			_003C_003Eo__5._003C_003Ep__0 = CallSite<Func<CallSite, object, FormViewItem>>.Create(Binder.Convert((CSharpBinderFlags)16, typeof(FormViewItem), typeof(FormService)));
		}
		FormViewItem formViewItem = _003C_003Eo__5._003C_003Ep__0.Target.Invoke((CallSite)(object)_003C_003Eo__5._003C_003Ep__0, model.get_View());
		UpdateForm(formViewItem, model.get_FormViewBuilderInfo());
	}

	public void UpdateForm(FormViewItem formViewItem, FormViewBuilderInfo builderInfo)
	{
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		if (builderInfo == null)
		{
			return;
		}
		System.Collections.Generic.IEnumerator<NotificationInfo> enumerator = ((System.Collections.Generic.IEnumerable<NotificationInfo>)builderInfo.get_Notifications()).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				NotificationInfo current = enumerator.get_Current();
				switch (current.get_Type())
				{
				case 0:
					notificationService.Info(SR.T("Информация"), current.get_Message());
					break;
				case 1:
					notificationService.Warning(SR.T("Предупреждение"), current.get_Message());
					break;
				case 2:
					notificationService.Error(SR.T("Ошибка"), current.get_Message());
					break;
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		if (formViewItem == null)
		{
			return;
		}
		List<PropertyViewItem> val = Enumerable.OfType<PropertyViewItem>((System.Collections.IEnumerable)formViewItem.FindItems(ignoreHide: false, (ViewItem item) => item is PropertyViewItem)).ToList();
		System.Collections.Generic.IEnumerator<PropertyViewInfo> enumerator2 = ((System.Collections.Generic.IEnumerable<PropertyViewInfo>)builderInfo.get_Properties()).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator2).MoveNext())
			{
				PropertyViewInfo current2 = enumerator2.get_Current();
				Enumerator<PropertyViewItem> enumerator3 = val.GetEnumerator();
				try
				{
					while (enumerator3.MoveNext())
					{
						PropertyViewItem current3 = enumerator3.get_Current();
						if (current3.PropertyUid == current2.get_Uid())
						{
							ProcessPropertyViewItem(current3, current2);
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator3).Dispose();
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator2)?.Dispose();
		}
	}

	private static void ProcessPropertyViewItem(PropertyViewItem viewItem, PropertyViewInfo property)
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		ViewAttributes viewAttributes = viewItem?.Attributes;
		if (viewAttributes == null)
		{
			return;
		}
		if (property.get_Required().get_HasValue())
		{
			_003C_003Ec__DisplayClass7_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass7_0();
			bool value = property.get_Required().get_Value();
			ParameterExpression val = Expression.Parameter(typeof(PropertyViewItem), "q");
			CS_0024_003C_003E8__locals0.expr = DynamicPropertyHelper<PropertyViewItem>.GetExpression<bool>(Expression.Lambda<Func<PropertyViewItem, bool>>((Expression)(object)Expression.Property((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
			if (Enumerable.FirstOrDefault<ComputedValue>((System.Collections.Generic.IEnumerable<ComputedValue>)viewItem.DynamicProperties, (Func<ComputedValue, bool>)((ComputedValue a) => a.Name == CS_0024_003C_003E8__locals0.expr && (a.ComputedValueType == 1 || a.ComputedValueType == 2))) == null)
			{
				viewAttributes.Required = value;
			}
		}
		if (property.get_ReadOnly().get_HasValue())
		{
			bool value2 = property.get_ReadOnly().get_Value();
			if (Enumerable.FirstOrDefault<ComputedValue>((System.Collections.Generic.IEnumerable<ComputedValue>)viewItem.DynamicProperties, (Func<ComputedValue, bool>)((ComputedValue a) => a.Name == "ReadOnly" && (a.ComputedValueType == 1 || a.ComputedValueType == 2))) == null)
			{
				viewAttributes.ReadOnly = value2;
			}
		}
		if (property.get_Visible().get_HasValue())
		{
			bool hide = !property.get_Visible().get_Value();
			if (Enumerable.FirstOrDefault<ComputedValue>((System.Collections.Generic.IEnumerable<ComputedValue>)viewItem.DynamicProperties, (Func<ComputedValue, bool>)((ComputedValue a) => a.Name == "Hide" && (a.ComputedValueType == 1 || a.ComputedValueType == 2))) == null)
			{
				viewAttributes.Hide = hide;
			}
		}
		if (property.get_IsValid().get_HasValue())
		{
			viewAttributes.ValidationMessage = !property.get_IsValid().get_Value();
			viewAttributes.ValidationError = property.get_ValidationMessage();
		}
		if (property.get_Settings() != null)
		{
			if (viewAttributes.TypeSettings == null)
			{
				viewAttributes.TypeSettings = property.get_Settings();
			}
			else
			{
				ConvertHelper.Reconcile<TypeSettings>(viewAttributes.TypeSettings, property.get_Settings());
			}
		}
	}
}
