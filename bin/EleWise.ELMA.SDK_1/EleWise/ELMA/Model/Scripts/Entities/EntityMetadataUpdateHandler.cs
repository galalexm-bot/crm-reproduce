// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.Entities.EntityMetadataUpdateHandler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Mappings;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Transformations;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Scripts.Entities
{
  /// <summary>Обновление метаданных на новый рантайм для сущностей</summary>
  [Component]
  internal sealed class EntityMetadataUpdateHandler : BaseMetadataUpdateHandler
  {
    internal static EntityMetadataUpdateHandler WNRENZbeYnJAIQP5YPy8;

    /// <inheritdoc />
    public override bool Check(IMetadata metadata)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            if (!(metadata is EntityMetadata entityMetadata))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 1 : 1;
              continue;
            }
            goto label_2;
          default:
            goto label_2;
        }
      }
label_2:
      return EntityMetadataUpdateHandler.Uw3tyabesSGScZY7OwsQ((object) entityMetadata) == EntityMetadata.UID;
label_3:
      return false;
    }

    /// <inheritdoc />
    public override void UpdateMetadata(IMetadataUpdateResult updateResult)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            if (!(updateResult.Metadata is EntityMetadata metadata))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 0 : 0;
              continue;
            }
            goto case 3;
          case 2:
            goto label_9;
          case 3:
            if (EntityMetadataUpdateHandler.iSkdVjbecDMYF8PcJU3E((object) metadata) == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 4 : 1;
              continue;
            }
            goto label_2;
          case 4:
            EntityMetadataUpdateHandler.KjF39ObPFJlXXIhBfVX2((object) metadata, EntityMetadataUpdateHandler.DxQfDlbez5g40bqq4LaW((object) metadata));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 2;
            continue;
          default:
            goto label_10;
        }
      }
label_3:
      return;
label_9:
      return;
label_10:
      return;
label_2:;
    }

    /// <inheritdoc />
    public override void UpdateForm(IMetadataUpdateResult updateResult, Guid formUid)
    {
      int num1 = 12;
      while (true)
      {
        int num2 = num1;
        PropertyMetadata propertyMetadata;
        EntityMetadata entityMetadata;
        while (true)
        {
          FormViewItem formViewItem;
          DataClassMetadata dataClassMetadata;
          Guid formUid1;
          switch (num2)
          {
            case 1:
              dataClassMetadata = (DataClassMetadata) null;
              break;
            case 2:
              goto label_25;
            case 3:
              if (formViewItem != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 13 : 6;
                continue;
              }
              goto label_18;
            case 4:
              if (entityMetadata == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 1 : 1;
                continue;
              }
              dataClassMetadata = entityMetadata.ViewModelMetadata;
              break;
            case 5:
              EntityMetadataUpdateHandler.sXNNvcbPbuKBmxkPMF90((object) formViewItem, EntityMetadataUpdateHandler.TTfTpkbPoFAA2ugKkuWe((object) propertyMetadata), (object) entityMetadata);
              num2 = 2;
              continue;
            case 6:
              goto label_19;
            case 7:
              if (propertyMetadata != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 9 : 0;
                continue;
              }
              goto label_4;
            case 8:
              goto label_5;
            case 9:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              formViewItem = entityMetadata.Forms.FirstOrDefault<FormViewItem>((Func<FormViewItem, bool>) (viewItem => EntityMetadataUpdateHandler.\u003C\u003Ec__DisplayClass2_0.Ry6EbQCpzYWMjugiUB9u(EntityMetadataUpdateHandler.\u003C\u003Ec__DisplayClass2_0.VF3uXQCpcIEAFXodGVfc((object) viewItem), formUid1)));
              num2 = 3;
              continue;
            case 10:
              goto label_24;
            case 11:
              formUid1 = formUid;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 0;
              continue;
            case 12:
              num2 = 11;
              continue;
            case 13:
              EntityMetadataUpdateHandler.kWSvuAbPWPwYT9nHM4KT((object) formViewItem, RuntimeVersion.Version2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 1 : 5;
              continue;
            default:
              entityMetadata = EntityMetadataUpdateHandler.RwWdUdbPB0g0WWcglGmn((object) updateResult) as EntityMetadata;
              num2 = 4;
              continue;
          }
          if (dataClassMetadata != null)
            num2 = 10;
          else
            goto label_3;
        }
label_24:
        List<PropertyMetadata> properties = entityMetadata.ViewModelMetadata.Properties;
        // ISSUE: reference to a compiler-generated field
        Predicate<PropertyMetadata> predicate = EntityMetadataUpdateHandler.\u003C\u003Ec.\u003C\u003E9__2_0;
        Predicate<PropertyMetadata> match;
        if (predicate == null)
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          EntityMetadataUpdateHandler.\u003C\u003Ec.\u003C\u003E9__2_0 = match = (Predicate<PropertyMetadata>) (property => EntityMetadataUpdateHandler.\u003C\u003Ec.ErRISnCahvTI6ZDWQfVL((object) property.Name, EntityMetadataUpdateHandler.\u003C\u003Ec.GMsUMQCabfZyZqSnQdTi(1669371371 ^ 1669352359)));
        }
        else
          goto label_28;
label_27:
        propertyMetadata = properties.Find(match);
        num1 = 7;
        continue;
label_28:
        match = predicate;
        goto label_27;
      }
label_25:
      return;
label_19:
      return;
label_5:
      return;
label_18:
      return;
label_4:
      return;
label_3:;
    }

    /// <inheritdoc />
    public override void UpdateScriptModules(IMetadataUpdateResult updateResult)
    {
      int num1 = 4;
      EntityMetadata entityMetadata;
      IEnumerator<ScriptModule> enumerator;
      while (true)
      {
        DataClassMetadata dataClassMetadata;
        switch (num1)
        {
          case 0:
            goto label_21;
          case 1:
            goto label_6;
          case 2:
            dataClassMetadata = entityMetadata.ViewModelMetadata;
            break;
          case 3:
            if (entityMetadata != null)
            {
              num1 = 2;
              continue;
            }
            goto case 6;
          case 4:
            entityMetadata = EntityMetadataUpdateHandler.RwWdUdbPB0g0WWcglGmn((object) updateResult) as EntityMetadata;
            num1 = 3;
            continue;
          case 5:
            goto label_8;
          case 6:
            dataClassMetadata = (DataClassMetadata) null;
            break;
          default:
            goto label_16;
        }
        if (dataClassMetadata == null)
        {
          num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 1 : 0;
        }
        else
        {
          enumerator = updateResult.ScriptModules.Where<ScriptModule>((Func<ScriptModule, bool>) (sm =>
          {
            int num2 = 1;
            Guid? nullable1;
            Guid uid;
            while (true)
            {
              int num3 = num2;
              while (true)
              {
                Guid? nullable2;
                Guid? nullable3;
                switch (num3)
                {
                  case 1:
                    if (sm == null)
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 0 : 0;
                      continue;
                    }
                    // ISSUE: reference to a compiler-generated method
                    nullable3 = new Guid?(EntityMetadataUpdateHandler.\u003C\u003Ec.L9m40XCaGfTEHwph2xhv((object) sm));
                    break;
                  case 2:
                    goto label_4;
                  case 3:
                    if (nullable1.HasValue)
                    {
                      if (!nullable1.HasValue)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 4 : 6;
                        continue;
                      }
                      goto label_9;
                    }
                    else
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 2 : 2;
                      continue;
                    }
                  case 4:
                    goto label_12;
                  case 5:
                    nullable3 = nullable2;
                    break;
                  case 6:
                    goto label_8;
                  default:
                    nullable2 = new Guid?();
                    num3 = 5;
                    continue;
                }
                nullable1 = nullable3;
                num3 = 4;
              }
label_12:
              uid = EntityScriptModuleType.UID;
              num2 = 3;
            }
label_4:
            return false;
label_8:
            return true;
label_9:
            // ISSUE: reference to a compiler-generated method
            return EntityMetadataUpdateHandler.\u003C\u003Ec.BpnPE0CaEwiXJJGU5C3F(nullable1.GetValueOrDefault(), uid);
          })).GetEnumerator();
          num1 = 5;
        }
      }
label_21:
      return;
label_6:
      return;
label_16:
      return;
label_8:
      try
      {
label_13:
        if (EntityMetadataUpdateHandler.OQatlDbPCxgAtgtLQYAt((object) enumerator))
          goto label_11;
        else
          goto label_14;
label_9:
        ScriptModule current;
        int num4;
        while (true)
        {
          switch (num4)
          {
            case 0:
              goto label_10;
            case 1:
              goto label_13;
            case 2:
              EntityMetadataUpdateHandler.GZ85wUbPQ0eC6gRgy92n((object) current, EntityMetadataUpdateHandler.Hq8CkSbPfCChqogYVo6u((object) this, (object) current.SourceCode, EntityMetadataUpdateHandler.xdJmEWbPEc5Cy4ulLJGY(EntityMetadataUpdateHandler.Pvwex4bPhKMVXrOifSpm((object) entityMetadata), EntityMetadataUpdateHandler.Vntnh5bPGHk8sTW9oy8y(654297945 ^ 654219335))));
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 1 : 0;
              continue;
            case 3:
              goto label_11;
            default:
              goto label_7;
          }
        }
label_10:
        return;
label_7:
        return;
label_11:
        current = enumerator.Current;
        num4 = 2;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0)
        {
          num4 = 2;
          goto label_9;
        }
        else
          goto label_9;
label_14:
        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 0;
        goto label_9;
      }
      finally
      {
        if (enumerator != null)
        {
          int num5 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0)
            num5 = 1;
          while (true)
          {
            switch (num5)
            {
              case 1:
                enumerator.Dispose();
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 0;
                continue;
              default:
                goto label_23;
            }
          }
        }
label_23:;
      }
    }

    private static void UpdateForm(object form, Guid modelPropertyUid, object entityMetadata)
    {
      int num = 5;
      ViewItem viewItem;
      ViewItem[] array;
      int index;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 9:
          case 11:
          case 18:
            ++index;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 0;
            continue;
          case 2:
          case 19:
            if (!(viewItem is GridViewItem gridViewItem))
            {
              num = 17;
              continue;
            }
            goto case 10;
          case 3:
            if (!EntityMetadataUpdateHandler.tEWTjrbPvTVP4K3ONd4L(propertyViewItem.GetType(), TypeOf<PropertyViewItem>.Raw))
            {
              num = 19;
              continue;
            }
            goto case 7;
          case 4:
            index = 0;
            num = 14;
            continue;
          case 5:
            array = ((RootViewItem) form).GetAllItems(false).ToArray<ViewItem>();
            num = 4;
            continue;
          case 6:
            if (viewItem is PropertyViewItem propertyViewItem)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 3 : 3;
              continue;
            }
            goto case 2;
          case 7:
            EntityMetadataUpdateHandler.xcXMGnbP8WhYsF7h8q4Y((object) propertyViewItem, modelPropertyUid);
            num = 11;
            continue;
          case 8:
            EntityMetadataUpdateHandler.XDhqrKbPuHQMGHc3qOMn((object) buttonViewItem, modelPropertyUid);
            num = 18;
            continue;
          case 10:
            EntityMetadataUpdateHandler.sqKtfUbPZjJ3nrwdA8ww((object) gridViewItem, entityMetadata);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 9;
            continue;
          case 12:
          case 17:
            if (!(viewItem is ButtonViewItem buttonViewItem))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 1 : 0;
              continue;
            }
            goto case 8;
          case 13:
          case 15:
            viewItem = array[index];
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 1 : 6;
            continue;
          case 16:
            goto label_17;
          default:
            if (index < array.Length)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 13 : 3;
              continue;
            }
            goto label_16;
        }
      }
label_17:
      return;
label_16:;
    }

    private static void UpdatePropertyViewItem(object propertyViewItem, Guid modelPropertyUid)
    {
      int num1 = 1;
      while (true)
      {
        int num2 = num1;
        Guid? metadataUid;
        while (true)
        {
          switch (num2)
          {
            case 1:
              metadataUid = ((RootViewItem) propertyViewItem).MetadataUid;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 0 : 0;
              continue;
            case 2:
            case 6:
              ((PropertyViewItem) propertyViewItem).PropertyParents.Add(modelPropertyUid);
              num2 = 5;
              continue;
            case 3:
              goto label_3;
            case 4:
              goto label_12;
            case 5:
              EntityMetadataUpdateHandler.Yqqv2mbPVQD75t08tQU4(propertyViewItem);
              num2 = 3;
              continue;
            case 7:
              EntityMetadataUpdateHandler.L0Dc9pbPIbcQyOx9Ls7r((object) ((PropertyViewItem) propertyViewItem).PropertyParents);
              num2 = 6;
              continue;
            case 8:
              ((PropertyViewItem) propertyViewItem).PropertyParents = new List<Guid>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 2 : 2;
              continue;
            default:
              if (!metadataUid.HasValue)
              {
                if (((PropertyViewItem) propertyViewItem).PropertyParents != null)
                  goto case 7;
                else
                  goto label_5;
              }
              else
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 4 : 3;
                continue;
              }
          }
        }
label_5:
        num1 = 8;
      }
label_3:
      return;
label_12:;
    }

    private static void UpdateNestedPropertyViewItem(object propertyViewItem)
    {
      int num1 = 1;
      IEnumerator<PropertyViewItem> enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            enumerator = ((IEnumerable) EntityMetadataUpdateHandler.TDtk4HbPS5drx3rYqnOS(propertyViewItem)).OfType<PropertyViewItem>().GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_27;
          default:
            goto label_3;
        }
      }
label_27:
      return;
label_3:
      try
      {
label_9:
        if (EntityMetadataUpdateHandler.OQatlDbPCxgAtgtLQYAt((object) enumerator))
          goto label_20;
        else
          goto label_10;
label_5:
        PropertyViewItem current;
        Guid? metadataUid;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              current.PropertyParents = new List<Guid>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 12 : 3;
              continue;
            case 2:
              EntityMetadataUpdateHandler.Yqqv2mbPVQD75t08tQU4((object) current);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 4 : 4;
              continue;
            case 3:
              current.PropertyParents.Add(((PropertyViewItem) propertyViewItem).PropertyUid);
              num2 = 5;
              continue;
            case 4:
            case 7:
            case 10:
              goto label_9;
            case 5:
              if (EntityMetadataUpdateHandler.IFudhCbPiNZJS2WQ0doq(EntityMetadataUpdateHandler.TDtk4HbPS5drx3rYqnOS((object) current)) <= 0)
              {
                num2 = 10;
                continue;
              }
              goto case 2;
            case 6:
              if (!metadataUid.HasValue)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 1 : 7;
                continue;
              }
              goto case 13;
            case 8:
              goto label_22;
            case 9:
              EntityMetadataUpdateHandler.L0Dc9pbPIbcQyOx9Ls7r((object) current.PropertyParents);
              num2 = 11;
              continue;
            case 11:
            case 12:
              current.PropertyParents.AddRange((IEnumerable<Guid>) ((PropertyViewItem) propertyViewItem).PropertyParents);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 3 : 2;
              continue;
            case 13:
              if (current.PropertyParents == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 1 : 1;
                continue;
              }
              goto case 9;
            case 14:
              goto label_20;
            default:
              metadataUid = current.MetadataUid;
              num2 = 6;
              continue;
          }
        }
label_22:
        return;
label_10:
        num2 = 8;
        goto label_5;
label_20:
        current = enumerator.Current;
        num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
        {
          num2 = 0;
          goto label_5;
        }
        else
          goto label_5;
      }
      finally
      {
        if (enumerator != null)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
            num3 = 1;
          while (true)
          {
            switch (num3)
            {
              case 1:
                EntityMetadataUpdateHandler.j2b90jbPRTpwQks7hYaY((object) enumerator);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 0 : 0;
                continue;
              default:
                goto label_29;
            }
          }
        }
label_29:;
      }
    }

    private static void UpdateGridViewItem(object gridViewItem, object entityMetadata)
    {
      int num1 = 2;
      while (true)
      {
        int num2 = num1;
        List<PropertyMetadata>.Enumerator enumerator1;
        List<TablePartMetadata>.Enumerator enumerator2;
        string str1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              enumerator1 = ((ClassMetadata) entityMetadata).Properties.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 0;
              continue;
            case 2:
              str1 = (string) EntityMetadataUpdateHandler.mTC7ZXbPqkuwFALVbZZm(gridViewItem);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 0 : 1;
              continue;
            case 3:
              goto label_4;
            case 4:
label_17:
              enumerator2 = ((EntityMetadata) entityMetadata).TableParts.GetEnumerator();
              num2 = 3;
              continue;
            case 5:
              goto label_34;
            case 6:
              goto label_32;
            default:
              try
              {
label_25:
                if (enumerator1.MoveNext())
                  goto label_22;
                else
                  goto label_26;
label_21:
                PropertyMetadata current;
                string newValue;
                string oldValue;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_17;
                    case 2:
                      newValue = (string) EntityMetadataUpdateHandler.xdJmEWbPEc5Cy4ulLJGY(EntityMetadataUpdateHandler.Vntnh5bPGHk8sTW9oy8y(-1120607109 - 305487170 ^ -1426233803), EntityMetadataUpdateHandler.Pvwex4bPhKMVXrOifSpm((object) current));
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 5 : 5;
                      continue;
                    case 3:
                      goto label_25;
                    case 4:
                      goto label_22;
                    case 5:
                      str1 = str1.Replace(oldValue, newValue);
                      num3 = 3;
                      continue;
                    default:
                      oldValue = (string) EntityMetadataUpdateHandler.Vntnh5bPGHk8sTW9oy8y(1917256330 ^ 1917182862) + (string) EntityMetadataUpdateHandler.Pvwex4bPhKMVXrOifSpm((object) current);
                      num3 = 2;
                      continue;
                  }
                }
label_22:
                current = enumerator1.Current;
                num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
                {
                  num3 = 0;
                  goto label_21;
                }
                else
                  goto label_21;
label_26:
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 1 : 1;
                goto label_21;
              }
              finally
              {
                enumerator1.Dispose();
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0)
                  num4 = 0;
                switch (num4)
                {
                  default:
                }
              }
          }
        }
label_4:
        try
        {
label_7:
          if (enumerator2.MoveNext())
            goto label_9;
          else
            goto label_8;
label_5:
          TablePartMetadata current;
          string str2;
          string str3;
          int num5;
          while (true)
          {
            switch (num5)
            {
              case 1:
                str3 = (string) EntityMetadataUpdateHandler.xdJmEWbPEc5Cy4ulLJGY(EntityMetadataUpdateHandler.Vntnh5bPGHk8sTW9oy8y(1470440286 ^ 1470612050), (object) current.TablePartPropertyName);
                num5 = 5;
                continue;
              case 2:
                goto label_7;
              case 3:
                goto label_9;
              case 4:
                goto label_34;
              case 5:
                str1 = (string) EntityMetadataUpdateHandler.UHghgNbPXaDuOGxG7iCq((object) str1, (object) str2, (object) str3);
                num5 = 2;
                continue;
              default:
                str2 = (string) EntityMetadataUpdateHandler.xdJmEWbPEc5Cy4ulLJGY((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(236071375 ^ 235981003), EntityMetadataUpdateHandler.G87TUXbPKMufaIwk4KEA((object) current));
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 1 : 0;
                continue;
            }
          }
label_8:
          num5 = 4;
          goto label_5;
label_9:
          current = enumerator2.Current;
          num5 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0)
          {
            num5 = 0;
            goto label_5;
          }
          else
            goto label_5;
        }
        finally
        {
          enumerator2.Dispose();
          int num6 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
            num6 = 0;
          switch (num6)
          {
            default:
          }
        }
label_34:
        EntityMetadataUpdateHandler.YXox7rbPT6ZpH67d3LTJ(gridViewItem, (object) str1);
        num1 = 6;
      }
label_32:;
    }

    private static void UpdateButtonViewItem(object buttonViewItem, Guid modelPropertyUid)
    {
      int num = 2;
      string[] source;
      string str1;
      string str2;
      FormBindingModel formBindingModel;
      while (true)
      {
        switch (num)
        {
          case 1:
            str2 = (string) EntityMetadataUpdateHandler.k0Be0DbPOxvpiNAeUpYA(buttonViewItem);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 1 : 3;
            continue;
          case 2:
            if (EntityMetadataUpdateHandler.idHBYUbPnVWTBob16BNX(EntityMetadataUpdateHandler.sHRST6bPkONgVT8AVYSb(buttonViewItem), EntityMetadataUpdateHandler.Vntnh5bPGHk8sTW9oy8y(825385222 ^ 825262118)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 0 : 1;
              continue;
            }
            goto label_2;
          case 3:
            if (string.IsNullOrWhiteSpace(str2))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 8 : 9;
              continue;
            }
            goto case 6;
          case 4:
            EntityMetadataUpdateHandler.ET5xjKbPPlP1HoDkQ9ju(buttonViewItem, EntityMetadataUpdateHandler.fjT8MBbPetHM3vubcmYr(EntityMetadataUpdateHandler.Vntnh5bPGHk8sTW9oy8y(-740338220 ^ -740445100), (object) source));
            num = 7;
            continue;
          case 5:
            formBindingModel = ClassSerializationHelper.DeserializeObjectByXml<FormBindingModel>(((IEnumerable<string>) source).ElementAt<string>(source.Length - 2));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 10 : 7;
            continue;
          case 6:
            source = (string[]) EntityMetadataUpdateHandler.UiwmaKbP2gl3W7VSWkWJ((object) str2, (object) new string[1]
            {
              (string) EntityMetadataUpdateHandler.Vntnh5bPGHk8sTW9oy8y(~538519529 ^ -538691178)
            }, StringSplitOptions.None);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 5 : 1;
            continue;
          case 7:
            goto label_10;
          case 8:
            source[source.Length - 2] = str1;
            num = 4;
            continue;
          case 9:
            goto label_15;
          case 10:
            formBindingModel.PropertyParents = new Guid[1]
            {
              modelPropertyUid
            };
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 0 : 0;
            continue;
          default:
            str1 = ClassSerializationHelper.SerializeObjectByXml((object) formBindingModel);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 8 : 6;
            continue;
        }
      }
label_10:
      return;
label_15:
      return;
label_2:;
    }

    public EntityMetadataUpdateHandler()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Guid Uw3tyabesSGScZY7OwsQ([In] object obj0) => ((EntityMetadata) obj0).TypeUid;

    internal static bool TEOKiNbeLBiNARSeW6nd() => EntityMetadataUpdateHandler.WNRENZbeYnJAIQP5YPy8 == null;

    internal static EntityMetadataUpdateHandler BeIrE8beUvLpBDucIIgv() => EntityMetadataUpdateHandler.WNRENZbeYnJAIQP5YPy8;

    internal static object iSkdVjbecDMYF8PcJU3E([In] object obj0) => (object) ((EntityMetadata) obj0).ViewModelMetadata;

    internal static object DxQfDlbez5g40bqq4LaW([In] object obj0) => (object) ((EntityMetadata) obj0).CreateViewModelMetadata();

    internal static void KjF39ObPFJlXXIhBfVX2([In] object obj0, [In] object obj1) => ((EntityMetadata) obj0).ViewModelMetadata = (DataClassMetadata) obj1;

    internal static object RwWdUdbPB0g0WWcglGmn([In] object obj0) => (object) ((IMetadataUpdateResult) obj0).Metadata;

    internal static void kWSvuAbPWPwYT9nHM4KT([In] object obj0, RuntimeVersion value) => ((FormViewItem) obj0).RuntimeVersion = value;

    internal static Guid TTfTpkbPoFAA2ugKkuWe([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static void sXNNvcbPbuKBmxkPMF90([In] object obj0, Guid modelPropertyUid, [In] object obj2) => EntityMetadataUpdateHandler.UpdateForm(obj0, modelPropertyUid, obj2);

    internal static object Pvwex4bPhKMVXrOifSpm([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static object Vntnh5bPGHk8sTW9oy8y(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object xdJmEWbPEc5Cy4ulLJGY([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static object Hq8CkSbPfCChqogYVo6u([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((BaseMetadataUpdateHandler) obj0).UpdateServerSourceCode((string) obj1, (string) obj2);

    internal static void GZ85wUbPQ0eC6gRgy92n([In] object obj0, [In] object obj1) => ((ScriptModule) obj0).SourceCode = (string) obj1;

    internal static bool OQatlDbPCxgAtgtLQYAt([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static bool tEWTjrbPvTVP4K3ONd4L([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static void xcXMGnbP8WhYsF7h8q4Y([In] object obj0, Guid modelPropertyUid) => EntityMetadataUpdateHandler.UpdatePropertyViewItem(obj0, modelPropertyUid);

    internal static void sqKtfUbPZjJ3nrwdA8ww([In] object obj0, [In] object obj1) => EntityMetadataUpdateHandler.UpdateGridViewItem(obj0, obj1);

    internal static void XDhqrKbPuHQMGHc3qOMn([In] object obj0, Guid modelPropertyUid) => EntityMetadataUpdateHandler.UpdateButtonViewItem(obj0, modelPropertyUid);

    internal static void L0Dc9pbPIbcQyOx9Ls7r([In] object obj0) => ((List<Guid>) obj0).Clear();

    internal static void Yqqv2mbPVQD75t08tQU4([In] object obj0) => EntityMetadataUpdateHandler.UpdateNestedPropertyViewItem(obj0);

    internal static object TDtk4HbPS5drx3rYqnOS([In] object obj0) => (object) ((RootViewItem) obj0).Items;

    internal static int IFudhCbPiNZJS2WQ0doq([In] object obj0) => ((EventedList<ViewItem>) obj0).Count;

    internal static void j2b90jbPRTpwQks7hYaY([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object mTC7ZXbPqkuwFALVbZZm([In] object obj0) => (object) ((GridViewItem) obj0).Query;

    internal static object G87TUXbPKMufaIwk4KEA([In] object obj0) => (object) ((TablePartMetadata) obj0).TablePartPropertyName;

    internal static object UHghgNbPXaDuOGxG7iCq([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0).Replace((string) obj1, (string) obj2);

    internal static void YXox7rbPT6ZpH67d3LTJ([In] object obj0, [In] object obj1) => ((GridViewItem) obj0).Query = (string) obj1;

    internal static object sHRST6bPkONgVT8AVYSb([In] object obj0) => (object) ((ButtonViewItem) obj0).ActionTypeProviderId;

    internal static bool idHBYUbPnVWTBob16BNX([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static object k0Be0DbPOxvpiNAeUpYA([In] object obj0) => (object) ((ButtonViewItem) obj0).ActionId;

    internal static object UiwmaKbP2gl3W7VSWkWJ([In] object obj0, [In] object obj1, [In] StringSplitOptions obj2) => (object) ((string) obj0).Split((string[]) obj1, obj2);

    internal static object fjT8MBbPetHM3vubcmYr([In] object obj0, [In] object obj1) => (object) string.Join((string) obj0, (string[]) obj1);

    internal static void ET5xjKbPPlP1HoDkQ9ju([In] object obj0, [In] object obj1) => ((ButtonViewItem) obj0).ActionId = (string) obj1;
  }
}
