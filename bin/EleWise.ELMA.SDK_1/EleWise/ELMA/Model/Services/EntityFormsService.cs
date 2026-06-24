// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Services.EntityFormsService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Model.Services
{
  /// <inheritdoc />
  [Service]
  internal sealed class EntityFormsService : IEntityFormsService
  {
    private static EntityFormsService sZiONbbvbsPqiAqQAAY6;

    /// <inheritdoc />
    public IEnumerable<FormViewItem> GetAllForms(ClassMetadata metadata)
    {
      IMetadata metadata1 = metadata.BaseClassUid != Guid.Empty ? MetadataServiceContext.Service.GetMetadata(metadata.BaseClassUid, false) : (IMetadata) null;
      List<FormViewItem> forms = new List<FormViewItem>();
      ClassDefaultForms defaultForms = new ClassDefaultForms();
      if (metadata1 != null)
        this.GetBaseForms(forms, defaultForms, metadata as EntityMetadata, metadata.Uid);
      else
        this.AddForms(forms, defaultForms, metadata);
      return (IEnumerable<FormViewItem>) forms;
    }

    /// <inheritdoc />
    public void GetBaseForms(
      List<FormViewItem> forms,
      ClassDefaultForms defaultForms,
      EntityMetadata metadata,
      Guid ignoreExtensionUid)
    {
      if (metadata == null)
        return;
      EntityMetadata metadata1 = metadata.BaseClassUid != Guid.Empty ? (EntityMetadata) MetadataServiceContext.Service.GetMetadata(metadata.BaseClassUid, false) : (EntityMetadata) null;
      if (metadata1 != null)
        this.GetBaseForms(forms, defaultForms, metadata1, Guid.Empty);
      this.AddForms(forms, defaultForms, (ClassMetadata) metadata);
      if (metadata.Type != EntityMetadataType.Interface)
        return;
      foreach (EntityMetadata metadata2 in MetadataServiceContext.Service.GetMetadataList().OfType<EntityMetadata>().Where<EntityMetadata>((Func<EntityMetadata, bool>) (m =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (m.Type == EntityMetadataType.InterfaceExtension)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 0 : 0;
                continue;
              }
              goto label_7;
            case 2:
              goto label_6;
            default:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              if (EntityFormsService.\u003C\u003Ec__DisplayClass1_0.vfqqeqCOQH0jeJVJbJmX(m.BaseClassUid, EntityFormsService.\u003C\u003Ec__DisplayClass1_0.BeJVFiCOf5m0xscQCZeo((object) metadata)))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 2 : 1;
                continue;
              }
              goto label_7;
          }
        }
label_6:
        // ISSUE: reference to a compiler-generated method
        return EntityFormsService.\u003C\u003Ec__DisplayClass1_0.BeJVFiCOf5m0xscQCZeo((object) m) != ignoreExtensionUid;
label_7:
        return false;
      })).ToList<EntityMetadata>())
        this.AddForms(forms, defaultForms, (ClassMetadata) metadata2);
    }

    /// <inheritdoc />
    public void AddForms(
      List<FormViewItem> forms,
      ClassDefaultForms defaultForms,
      ClassMetadata metadata)
    {
      foreach (FormViewItemTransformation formTransformation in metadata.FormTransformations)
      {
        FormViewItemTransformation transform = formTransformation;
        FormViewItem formViewItem1 = forms.Find((Predicate<FormViewItem>) (f =>
        {
          int num = 5;
          Guid uid1;
          Guid? uid2;
          while (true)
          {
            switch (num)
            {
              case 1:
                goto label_4;
              case 2:
                goto label_7;
              case 3:
                goto label_3;
              case 4:
                uid1 = transform.Uid;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 0;
                continue;
              case 5:
                uid2 = f.uid;
                num = 4;
                continue;
              default:
                if (!uid2.HasValue)
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 2 : 2;
                  continue;
                }
                if (uid2.HasValue)
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 1 : 1;
                  continue;
                }
                goto label_3;
            }
          }
label_3:
          return true;
label_4:
          // ISSUE: reference to a compiler-generated method
          return EntityFormsService.\u003C\u003Ec__DisplayClass2_0.h7bsKSCOuFfQe0wGschd(uid2.GetValueOrDefault(), uid1);
label_7:
          return false;
        }));
        if (formViewItem1 != null)
        {
          int index = forms.IndexOf(formViewItem1);
          FormViewItem formViewItem2 = formViewItem1.Transformate((ViewItemTransformation) transform);
          forms[index] = formViewItem2;
        }
      }
      forms.AddRange((IEnumerable<FormViewItem>) metadata.Forms);
      // ISSUE: reference to a compiler-generated method
      IEnumerable<FormViewItemTransformation> childFormTransformations = metadata.FormTransformations.Where<FormViewItemTransformation>((Func<FormViewItemTransformation, bool>) (t => EntityFormsService.\u003C\u003Ec.Avw128CORCLVNQwiQWtq((object) t) != Guid.Empty));
      foreach (FormViewItemTransformation transform in childFormTransformations)
        this.AddChildForm(forms, childFormTransformations, transform);
      defaultForms.FromDictionary(metadata.DefaultForms.ToDictionary(), false);
      defaultForms.FormSettingsFromDictionary(metadata.DefaultForms.FormSettingsToDictionary(), false);
    }

    /// <inheritdoc />
    public FormViewItem AddChildForm(
      List<FormViewItem> forms,
      IEnumerable<FormViewItemTransformation> childFormTransformations,
      FormViewItemTransformation transform)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      FormViewItem formViewItem1 = forms.Find((Predicate<FormViewItem>) (f => EntityFormsService.\u003C\u003Ec__DisplayClass3_0.IdCh0qCOndKEElPKujDI(EntityFormsService.\u003C\u003Ec__DisplayClass3_0.sEX1DXCOk0SMIguFl1Lr((object) f), transform.NewFormUid)));
      if (formViewItem1 != null)
        return formViewItem1;
      // ISSUE: reference to a compiler-generated method
      FormViewItem formViewItem2 = forms.Find((Predicate<FormViewItem>) (f => EntityFormsService.\u003C\u003Ec__DisplayClass3_0.IdCh0qCOndKEElPKujDI(f.Uid, transform.Uid)));
      if (formViewItem2 == null)
      {
        // ISSUE: reference to a compiler-generated method
        FormViewItemTransformation transform1 = childFormTransformations.FirstOrDefault<FormViewItemTransformation>((Func<FormViewItemTransformation, bool>) (t => EntityFormsService.\u003C\u003Ec__DisplayClass3_0.Nm7KDLCOOSkxuY57uDy8((object) t) == transform.Uid));
        if (transform1 == null)
          return (FormViewItem) null;
        formViewItem2 = this.AddChildForm(forms, childFormTransformations, transform1);
        if (formViewItem2 == null)
          return (FormViewItem) null;
      }
      FormViewItem formViewItem3 = formViewItem2.Transformate((ViewItemTransformation) transform);
      forms.Add(formViewItem3);
      return formViewItem3;
    }

    public EntityFormsService()
    {
      EntityFormsService.cBDZ7ubvE79QcHNWdPN2();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void cBDZ7ubvE79QcHNWdPN2() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool rpnJLlbvhuNRycRFnrNa() => EntityFormsService.sZiONbbvbsPqiAqQAAY6 == null;

    internal static EntityFormsService ROAlRObvG64RUrNvSoLV() => EntityFormsService.sZiONbbvbsPqiAqQAAY6;
  }
}
