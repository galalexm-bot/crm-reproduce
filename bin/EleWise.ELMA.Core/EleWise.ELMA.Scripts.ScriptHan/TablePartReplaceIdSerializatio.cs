using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Services;
using EleWise.ELMA.DTO;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Scripts.ScriptHandlers;

[Component]
internal sealed class TablePartReplaceIdSerializationHandler : ISerializationHandler
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<PropertyMetadata, bool> _003C_003E9__2_0;

		internal bool _003CBeforeSerialize_003Eb__2_0(PropertyMetadata a)
		{
			if (a.get_IsSystem())
			{
				return ((INamedMetadata)a).get_Name() == "Model";
			}
			return false;
		}
	}

	private readonly IMetadataServiceContext metadataServiceContext;

	public TablePartReplaceIdSerializationHandler(IMetadataServiceContext metadataServiceContext)
	{
		this.metadataServiceContext = metadataServiceContext;
	}

	public void BeforeSerialize(ReactiveProxy proxy)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		if (proxy == null)
		{
			return;
		}
		ClassMetadata metadata = proxy.Metadata;
		if (metadata == null)
		{
			return;
		}
		EntityMetadata val = null;
		if (((INamedMetadata)metadata).get_Name() == "ViewModelContext")
		{
			PropertyMetadata val2 = Enumerable.FirstOrDefault<PropertyMetadata>((System.Collections.Generic.IEnumerable<PropertyMetadata>)metadata.get_Properties(), (Func<PropertyMetadata, bool>)((PropertyMetadata a) => a.get_IsSystem() && ((INamedMetadata)a).get_Name() == "Model"));
			EntityMetadata val3;
			if (val2 != null && (val3 = (EntityMetadata)/*isinst with value type is only supported in some contexts*/) != null)
			{
				val = val3;
				PropertyInfoExpression propertyExpression = metadataServiceContext.GetPropertyExpression((IPropertyMetadata)(object)val2, metadata);
				proxy = ObjectExtensions.As<ReactiveProxy>(((object)proxy).get_Item(propertyExpression.ObjectExpression));
			}
		}
		else
		{
			val = (EntityMetadata)(object)((metadata is EntityMetadata) ? metadata : null);
		}
		if (val != null)
		{
			ProcessTableParts(val, proxy);
		}
	}

	private static void ProcessTableParts(EntityMetadata entityMetadata, ReactiveProxy proxy)
	{
		if (proxy == null)
		{
			return;
		}
		System.Collections.Generic.IEnumerator<TablePartMetadata> enumerator = ((System.Collections.Generic.IEnumerable<TablePartMetadata>)entityMetadata.get_TableParts()).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				TablePartMetadata current = enumerator.get_Current();
				if (!(((object)proxy).get_Item(current.get_TablePartPropertyName()) is System.Collections.IEnumerable enumerable))
				{
					continue;
				}
				{
					System.Collections.IEnumerator enumerator2 = enumerable.GetEnumerator();
					try
					{
						while (enumerator2.MoveNext())
						{
							object current2 = enumerator2.get_Current();
							Entity entity = ObjectExtensions.As<Entity>(current2);
							if (entity.Id < 0)
							{
								entity.Id = 0L;
							}
							ProcessTableParts((EntityMetadata)(object)current, ObjectExtensions.As<ReactiveProxy>(current2));
						}
					}
					finally
					{
						System.IDisposable disposable = enumerator2 as System.IDisposable;
						if (disposable != null)
						{
							disposable.Dispose();
						}
					}
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
	}
}
