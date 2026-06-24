using System;
using System.Collections.Generic;
using EleWise.ELMA.Collections;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.Logging;
using EleWise.ELMA.DTO;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Types.Models;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.Model.Types;

internal class TablePartDescriptor : EntityDescriptor
{
	private sealed class _003C_003Ec__DisplayClass6_0
	{
		public string subTypeUid;

		public TablePartDescriptor _003C_003E4__this;

		internal object _003CPropertyGetter_003Eb__1()
		{
			return ReactiveCollectionExtensions.CreateSpecificISet(subTypeUid, _003C_003E4__this.context);
		}
	}

	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public string subTypeUid;

		public TablePartDescriptor _003C_003E4__this;

		internal object _003CPropertySetter_003Eb__1()
		{
			return ReactiveCollectionExtensions.CreateSpecificISet(subTypeUid, _003C_003E4__this.context);
		}
	}

	public override Guid Uid => TypeConstants.TablePartUid;

	public override bool Visible => false;

	public TablePartDescriptor(IProxyGeneratorService proxyGeneratorService, IExtendEntityService extendEntityService, ILogger logger)
		: base(proxyGeneratorService, extendEntityService, logger)
	{
	}

	public override bool IsNullable(IPropertyMetadata property)
	{
		return true;
	}

	public override Func<GetterInfo, PropertyInfo, object> PropertyGetter(PropertyInfo propertyInfo)
	{
		return delegate(GetterInfo getterInfo, PropertyInfo info)
		{
			_003C_003Ec__DisplayClass6_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass6_0();
			CS_0024_003C_003E8__locals0._003C_003E4__this = this;
			CS_0024_003C_003E8__locals0.subTypeUid = info.SubTypeUid;
			return ConvertHelper.GetSetCollection(ObjectExtensions.As<System.Type>((object)DTOHelper.ProxyType(CS_0024_003C_003E8__locals0.subTypeUid)), getterInfo.Target, info.Expression, info.ShouldSerialize, context, () => ReactiveCollectionExtensions.CreateSpecificISet(CS_0024_003C_003E8__locals0.subTypeUid, CS_0024_003C_003E8__locals0._003C_003E4__this.context));
		};
	}

	public override Action<SetterInfo, PropertyInfo> PropertySetter(PropertyInfo propertyInfo)
	{
		return delegate(SetterInfo setterInfo, PropertyInfo info)
		{
			_003C_003Ec__DisplayClass7_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass7_0();
			CS_0024_003C_003E8__locals0._003C_003E4__this = this;
			CS_0024_003C_003E8__locals0.subTypeUid = info.SubTypeUid;
			ConvertHelper.SetSetCollection(setterInfo.Target, info.Expression, (System.Collections.Generic.IEnumerable<Entity>)ObjectExtensions.As<System.Collections.Generic.ICollection<Entity>>(setterInfo.Value), info.ShouldSerialize, context, () => ReactiveCollectionExtensions.CreateSpecificISet(CS_0024_003C_003E8__locals0.subTypeUid, CS_0024_003C_003E8__locals0._003C_003E4__this.context));
		};
	}

	private object _003CPropertyGetter_003Eb__6_0(GetterInfo getterInfo, PropertyInfo info)
	{
		_003C_003Ec__DisplayClass6_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass6_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.subTypeUid = info.SubTypeUid;
		return ConvertHelper.GetSetCollection(ObjectExtensions.As<System.Type>((object)DTOHelper.ProxyType(CS_0024_003C_003E8__locals0.subTypeUid)), getterInfo.Target, info.Expression, info.ShouldSerialize, context, () => ReactiveCollectionExtensions.CreateSpecificISet(CS_0024_003C_003E8__locals0.subTypeUid, CS_0024_003C_003E8__locals0._003C_003E4__this.context));
	}

	private void _003CPropertySetter_003Eb__7_0(SetterInfo setterInfo, PropertyInfo info)
	{
		_003C_003Ec__DisplayClass7_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass7_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.subTypeUid = info.SubTypeUid;
		ConvertHelper.SetSetCollection(setterInfo.Target, info.Expression, (System.Collections.Generic.IEnumerable<Entity>)ObjectExtensions.As<System.Collections.Generic.ICollection<Entity>>(setterInfo.Value), info.ShouldSerialize, context, () => ReactiveCollectionExtensions.CreateSpecificISet(CS_0024_003C_003E8__locals0.subTypeUid, CS_0024_003C_003E8__locals0._003C_003E4__this.context));
	}
}
