// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Descriptors.FormPartDescriptor`2
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.UI.Descriptors
{
  public class FormPartDescriptor<TOwnerDescriptor, TMetadata> : IFormPartDescriptor
    where TOwnerDescriptor : EleWise.ELMA.UI.Descriptors.FormDescriptor
    where TMetadata : FormPartMetadata
  {
    internal static object zChp3CJFEmTT3kMs9BO;

    public FormPartDescriptor(TOwnerDescriptor formDescriptor, TMetadata metadata)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      Contract.ArgumentNotNull((object) formDescriptor, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837641135));
      Contract.ArgumentNotNull((object) metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317775890));
      this.FormDescriptor = formDescriptor;
      this.Metadata = metadata;
      string str = formDescriptor.Metadata.FullTypeName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1253244298 - 1829393894 ^ -576132998) + metadata.Context.Name;
      this.ContextType = formDescriptor.Assembly.GetType(str);
      if (this.ContextType == (Type) null)
        throw new TypeNotFoundException(str);
      List<Type> typesToRegister = new List<Type>();
      this.GetTypesToRegister((EntityMetadata) this.Metadata.Context, typesToRegister);
      Locator.GetServiceNotNull<IMetadataRuntimeService>().RegisterTypes((IEnumerable<Type>) typesToRegister, false);
    }

    public TOwnerDescriptor FormDescriptor { get; private set; }

    public TMetadata Metadata { get; private set; }

    public Type ContextType
    {
      get => this.\u003CContextType\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CContextType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    private void GetTypesToRegister(EntityMetadata metadata, List<Type> typesToRegister)
    {
      Type type = this.FormDescriptor.Assembly.GetType(this.FormDescriptor.Metadata.FullTypeName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(993438473 ^ 993453271) + metadata.Name);
      if (type != (Type) null)
        typesToRegister.Add(type);
      foreach (EntityMetadata tablePart in metadata.TableParts)
        this.GetTypesToRegister(tablePart, typesToRegister);
    }

    IFormDescriptor IFormPartDescriptor.FormDescriptor => (IFormDescriptor) this.FormDescriptor;

    FormPartMetadata IFormPartDescriptor.Metadata => (FormPartMetadata) this.Metadata;

    internal static bool xdJF8VJB6b6v7dy5YpZ() => FormPartDescriptor<TOwnerDescriptor, TMetadata>.zChp3CJFEmTT3kMs9BO == null;

    internal static object CSdwNLJW6vTeZahde7k() => FormPartDescriptor<TOwnerDescriptor, TMetadata>.zChp3CJFEmTT3kMs9BO;
  }
}
