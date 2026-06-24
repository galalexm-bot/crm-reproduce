// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.AbstractObjectFormProvider`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Extensions
{
  /// <summary>Абстрактая реализация провайдера форм для сущности</summary>
  /// <typeparam name="T">Тип сущности</typeparam>
  public abstract class AbstractObjectFormProvider<T> : AbstractObjectFormProvider where T : IEntity
  {
    private static object gY5SdnGp8fFvPKRkYKuF;

    /// <inheritdoc />
    protected AbstractObjectFormProvider(
      IMetadataRuntimeService metadataRuntimeService,
      ViewModelDescriptor viewModelDescriptor)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(metadataRuntimeService, viewModelDescriptor);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <inheritdoc />
    public override bool Check(Guid typeUid, Guid subTypeUid)
    {
      int num = 1;
      Type typeByUidOrNull;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!(typeUid != EntityMetadata.UID))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 2:
            goto label_2;
          case 3:
            goto label_6;
          case 4:
            if (typeByUidOrNull != (Type) null)
            {
              num = 3;
              continue;
            }
            goto label_7;
          default:
            typeByUidOrNull = this.MetadataRuntimeService.GetTypeByUidOrNull(subTypeUid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 4;
            continue;
        }
      }
label_2:
      return false;
label_6:
      return typeof (T).IsAssignableFrom(typeByUidOrNull);
label_7:
      return false;
    }

    internal static bool NtvQZFGpZoPDtn0niDRQ() => AbstractObjectFormProvider<T>.gY5SdnGp8fFvPKRkYKuF == null;

    internal static object SA7OD0GpuN2XhVLBQBLV() => AbstractObjectFormProvider<T>.gY5SdnGp8fFvPKRkYKuF;
  }
}
