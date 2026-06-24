// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Scripts.FormMetadataUpdateHandler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Transformations;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Model.Views.Toolbar;
using EleWise.ELMA.Scripts.Models;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace EleWise.ELMA.UI.Scripts
{
  /// <summary>
  /// Обновление метаданных на новый рантайм для страниц и портлетов
  /// </summary>
  [Component]
  internal abstract class FormMetadataUpdateHandler : IMetadataUpdateHandler
  {
    internal static FormMetadataUpdateHandler sM7DfOrBsi0mRFfAE3m;

    /// <inheritdoc />
    public abstract bool Check(IMetadata metadata);

    /// <inheritdoc />
    public void UpdateMetadata(IMetadataUpdateResult updateResult)
    {
      int num1 = 9;
      ComponentMetadata metadata;
      FormPartMetadata content;
      ComponentMetadataItem componentMetadataItem;
      List<PropertyMetadata>.Enumerator enumerator;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_25;
          case 1:
label_24:
            FormMetadataUpdateHandler.ProcessTableParts(content.Context.TableParts, (object) metadata, FormMetadataUpdateHandler.PpyWa5rG8jgdFsMjA0R(FormMetadataUpdateHandler.H9wAp3rhRixiAKGTMh0((object) metadata)));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 2 : 3;
            continue;
          case 2:
            this.AdditionalMetadataActions((FormMetadata) FormMetadataUpdateHandler.dVjlPRrvVq5X37SMaZW((object) updateResult), metadata);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 0 : 0;
            continue;
          case 3:
            FormMetadataUpdateHandler.drI8OErCKEvsEppV7cN(FormMetadataUpdateHandler.H9wAp3rhRixiAKGTMh0((object) metadata), (object) (FormViewItem) FormMetadataUpdateHandler.jhjd7QrQgDm82pob9Aj(FormMetadataUpdateHandler.CeoNSMrfeKUhGhvEX5w((object) content)));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 2 : 0;
            continue;
          case 4:
            enumerator = ((ClassMetadata) FormMetadataUpdateHandler.MrqR0HrbcpOZmygTdOe((object) content)).Properties.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 5 : 4;
            continue;
          case 5:
            try
            {
label_14:
              if (enumerator.MoveNext())
                goto label_16;
              else
                goto label_15;
label_12:
              PropertyMetadata current;
              int num2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    goto label_16;
                  case 2:
                    ((ClassMetadata) FormMetadataUpdateHandler.PpyWa5rG8jgdFsMjA0R(FormMetadataUpdateHandler.H9wAp3rhRixiAKGTMh0((object) metadata))).Properties.Add((PropertyMetadata) FormMetadataUpdateHandler.y5an62rES0egbuGCM5Z((object) current));
                    num2 = 3;
                    continue;
                  case 3:
                    goto label_14;
                  default:
                    goto label_24;
                }
              }
label_15:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
              goto label_12;
label_16:
              current = enumerator.Current;
              num2 = 2;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
              {
                num2 = 2;
                goto label_12;
              }
              else
                goto label_12;
            }
            finally
            {
              enumerator.Dispose();
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
                num3 = 0;
              switch (num3)
              {
                default:
              }
            }
          case 6:
            goto label_2;
          case 7:
            content = this.GetContent(updateResult);
            num1 = 10;
            continue;
          case 8:
            if (componentMetadataItem != null)
            {
              num1 = 7;
              continue;
            }
            goto label_18;
          case 9:
            componentMetadataItem = updateResult.Entities.FirstOrDefault<IEntity>() as ComponentMetadataItem;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 0 : 8;
            continue;
          case 10:
            metadata = (ComponentMetadata) componentMetadataItem.Metadata;
            num1 = 4;
            continue;
          default:
            goto label_22;
        }
      }
label_25:
      return;
label_2:
      return;
label_22:
      return;
label_18:;
    }

    /// <inheritdoc />
    public void UpdateForm(IMetadataUpdateResult updateResult, Guid formUid)
    {
      int num1 = 3;
      while (true)
      {
        FormViewItem formViewItem;
        List<ToolbarItem>.Enumerator enumerator1;
        FormPartMetadata formPartMetadata;
        ComponentMetadata componentMetadata;
        List<ViewItem>.Enumerator enumerator2;
        object obj;
        switch (num1)
        {
          case 1:
            try
            {
label_76:
              if (enumerator1.MoveNext())
                goto label_73;
              else
                goto label_77;
label_68:
              Button current;
              int num2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    List<ComputedValue> dynamicProperties = current.DynamicProperties;
                    ComputedValue computedValue = new ComputedValue();
                    FormMetadataUpdateHandler.oWtdKlr2LXEqh4vIEwi((object) computedValue, FormMetadataUpdateHandler.rWV6Arr33cqBQRkeYxX(1033719030 - 2012070891 ^ -978367971));
                    FormMetadataUpdateHandler.EvlL9jre6s6xutCVxrb((object) computedValue, ComputedValueType.Function);
                    dynamicProperties.Add(computedValue);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 7 : 7;
                    continue;
                  case 2:
                    if (current == null)
                    {
                      num2 = 3;
                      continue;
                    }
                    goto case 1;
                  case 3:
                  case 6:
                    goto label_76;
                  case 4:
                    goto label_73;
                  case 5:
                    FormMetadataUpdateHandler.Usye9lraC9JxpfW81h8((object) current, CodeType.Server);
                    num2 = 6;
                    continue;
                  case 7:
                    current.ScriptName = (string) FormMetadataUpdateHandler.xALCBRrKhwkZ0BQI4ua(FormMetadataUpdateHandler.MOc0umrpFhC3moYbLYE((object) current), FormMetadataUpdateHandler.VY87cbrqrpr0h7WOyB9((object) componentMetadata));
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 3 : 5;
                    continue;
                  default:
                    goto label_62;
                }
              }
label_73:
              current = enumerator1.Current as Button;
              num2 = 2;
              goto label_68;
label_77:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
              goto label_68;
            }
            finally
            {
              enumerator1.Dispose();
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
                num3 = 0;
              switch (num3)
              {
                default:
              }
            }
          case 2:
            obj = (object) null;
            break;
          case 3:
            if (!(updateResult.Entities.FirstOrDefault<IEntity>() is ComponentMetadataItem componentMetadataItem))
            {
              num1 = 2;
              continue;
            }
            obj = FormMetadataUpdateHandler.sx9QCrr87fDlWQpjd62((object) componentMetadataItem);
            break;
          case 4:
            try
            {
label_29:
              if (enumerator2.MoveNext())
                goto label_31;
              else
                goto label_30;
label_10:
              ViewItem current;
              int num4;
              while (true)
              {
                int num5;
                TablePartMetadata tablePartMetadata1;
                TablePartMetadata tablePartMetadata2;
                string str1;
                Guid? metadataUid;
                string str2;
                FormContextMetadata formContextMetadata;
                PropertyMetadata propertyMetadata;
                Guid propertyUid;
                switch (num4)
                {
                  case 1:
                  case 15:
                  case 17:
                    FormMetadataUpdateHandler.wkXidwrXj7IWSg06oll(FormMetadataUpdateHandler.B20yE5rIyHevNQd7Sei((object) propertyViewItem), FormMetadataUpdateHandler.xALCBRrKhwkZ0BQI4ua((object) str1, FormMetadataUpdateHandler.VY87cbrqrpr0h7WOyB9((object) componentMetadata)));
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 38 : 7;
                    continue;
                  case 2:
                    str2 = tablePartMetadata2.OnViewLoadScriptName;
                    num4 = 10;
                    continue;
                  case 3:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    tablePartMetadata1 = formContextMetadata.TableParts.FirstOrDefault<TablePartMetadata>((Func<TablePartMetadata, bool>) (tp => FormMetadataUpdateHandler.\u003C\u003Ec__DisplayClass2_0.bObA76fjZUMfuPFQMpcU(FormMetadataUpdateHandler.\u003C\u003Ec__DisplayClass2_0.c0IuJafj86y1NpR7k9Yi((object) tp), propertyUid)));
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 0 : 0;
                    continue;
                  case 4:
                    goto label_63;
                  case 5:
                    FormMetadataUpdateHandler.bJfuJlrOZffNN5s76bu((object) propertyViewItem);
                    num4 = 18;
                    continue;
                  case 6:
                    if (current is PropertyViewItem propertyViewItem)
                    {
                      num4 = 23;
                      continue;
                    }
                    goto case 8;
                  case 7:
                    // ISSUE: reference to a compiler-generated method
                    propertyMetadata = formContextMetadata.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (prop => FormMetadataUpdateHandler.\u003C\u003Ec__DisplayClass2_0.Dh54jPfjvVQPjPO7N8Zo((object) prop) == propertyUid));
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 22 : 30;
                    continue;
                  case 8:
                    if (!(current is ButtonViewItem buttonViewItem))
                    {
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 36 : 21;
                      continue;
                    }
                    goto case 21;
                  case 9:
                    FormMetadataUpdateHandler.SAqTv5r1g6PvyF9LDSc((object) buttonViewItem, CodeType.Server);
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 19 : 28;
                    continue;
                  case 10:
                  case 12:
                    ((ViewAttributes) FormMetadataUpdateHandler.B20yE5rIyHevNQd7Sei((object) propertyViewItem)).OnViewLoadScriptName = (string) FormMetadataUpdateHandler.xALCBRrKhwkZ0BQI4ua((object) str2, FormMetadataUpdateHandler.VY87cbrqrpr0h7WOyB9((object) componentMetadata));
                    num5 = 31;
                    break;
                  case 11:
                    if (propertyViewItem.PropertyParents.Count > 0)
                    {
                      num5 = 25;
                      break;
                    }
                    goto case 5;
                  case 13:
                    str1 = (string) FormMetadataUpdateHandler.QFtvdtriSDvn1EaG8bG((object) propertyMetadata);
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 1 : 1;
                    continue;
                  case 14:
                  case 18:
                  case 28:
                  case 36:
                    goto label_29;
                  case 16:
                    str1 = propertyViewItem.Attributes.OnChangeScriptName;
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 19 : 20;
                    continue;
                  case 19:
                    str1 = (string) FormMetadataUpdateHandler.tdjmrcrRnKujflQdhNP((object) tablePartMetadata1);
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 6 : 17;
                    continue;
                  case 20:
                    if (FormMetadataUpdateHandler.Td9p0IrSKVU9ohu72C6((object) str1))
                    {
                      num4 = 7;
                      continue;
                    }
                    goto case 1;
                  case 21:
                    List<ComputedValue> dynamicProperties = buttonViewItem.DynamicProperties;
                    ComputedValue computedValue = new ComputedValue();
                    FormMetadataUpdateHandler.oWtdKlr2LXEqh4vIEwi((object) computedValue, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1120607109 - 305487170 ^ -1426111025));
                    FormMetadataUpdateHandler.EvlL9jre6s6xutCVxrb((object) computedValue, ComputedValueType.Function);
                    dynamicProperties.Add(computedValue);
                    num4 = 35;
                    continue;
                  case 22:
                    goto label_31;
                  case 23:
                    num4 = 32;
                    continue;
                  case 24:
                    formContextMetadata = (FormContextMetadata) FormMetadataUpdateHandler.MrqR0HrbcpOZmygTdOe((object) formPartMetadata);
                    num4 = 39;
                    continue;
                  case 25:
                    goto label_78;
                  case 26:
                    metadataUid = propertyViewItem.MetadataUid;
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 37 : 23;
                    continue;
                  case 27:
                    if (tablePartMetadata2 != null)
                    {
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 1 : 2;
                      continue;
                    }
                    goto case 10;
                  case 29:
                    // ISSUE: reference to a compiler-generated method
                    tablePartMetadata2 = formContextMetadata.TableParts.FirstOrDefault<TablePartMetadata>((Func<TablePartMetadata, bool>) (tp => FormMetadataUpdateHandler.\u003C\u003Ec__DisplayClass2_0.bObA76fjZUMfuPFQMpcU(tp.TablePartPropertyUid, propertyUid)));
                    num4 = 27;
                    continue;
                  case 30:
                    if (propertyMetadata != null)
                    {
                      num4 = 13;
                      continue;
                    }
                    goto case 3;
                  case 31:
                    if (((EventedList<ViewItem>) FormMetadataUpdateHandler.UEtUAvrnTgIEthkKCEI((object) propertyViewItem)).Count <= 0)
                    {
                      num4 = 14;
                      continue;
                    }
                    goto case 26;
                  case 32:
                    if (FormMetadataUpdateHandler.B20yE5rIyHevNQd7Sei((object) propertyViewItem) != null)
                    {
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 18 : 24;
                      continue;
                    }
                    goto label_29;
                  case 33:
                    if (!FormMetadataUpdateHandler.Td9p0IrSKVU9ohu72C6((object) str2))
                    {
                      num4 = 12;
                      continue;
                    }
                    goto case 29;
                  case 34:
                    str2 = (string) FormMetadataUpdateHandler.o4RVf5rkKycPEjBv5mH((object) propertyViewItem.Attributes);
                    num4 = 33;
                    continue;
                  case 35:
                    buttonViewItem.ScriptName = FormMetadataUpdateHandler.GetNewScriptMethodName(FormMetadataUpdateHandler.dZJLaQrPUf7cfyTxMbo((object) buttonViewItem), FormMetadataUpdateHandler.VY87cbrqrpr0h7WOyB9((object) componentMetadata));
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 0 : 9;
                    continue;
                  case 37:
                    if (!metadataUid.HasValue)
                    {
                      num5 = 11;
                      break;
                    }
                    goto label_75;
                  case 38:
                    FormMetadataUpdateHandler.VM7mMxrTesSPsFbr0tR(FormMetadataUpdateHandler.B20yE5rIyHevNQd7Sei((object) propertyViewItem), CodeType.Server);
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 34 : 1;
                    continue;
                  case 39:
                    propertyUid = FormMetadataUpdateHandler.MsCIegrVuscyMVFg0M9((object) propertyViewItem);
                    num4 = 16;
                    continue;
                  default:
                    if (tablePartMetadata1 == null)
                    {
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 7 : 15;
                      continue;
                    }
                    goto case 19;
                }
                num4 = num5;
              }
label_78:
              return;
label_75:
              return;
label_30:
              num4 = 4;
              goto label_10;
label_31:
              current = enumerator2.Current;
              num4 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
              {
                num4 = 6;
                goto label_10;
              }
              else
                goto label_10;
            }
            finally
            {
              enumerator2.Dispose();
              int num6 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
                num6 = 0;
              switch (num6)
              {
                default:
              }
            }
          case 5:
            goto label_6;
          case 6:
            enumerator1 = ((RootToolbarItem) FormMetadataUpdateHandler.IPGHcArNpO0rK6ENjkJ((object) formViewItem)).GetAllItems(false).ToList<ToolbarItem>().GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 1 : 0;
            continue;
          case 7:
            formViewItem = (FormViewItem) FormMetadataUpdateHandler.xobluAruT4OY4FHo96T(FormMetadataUpdateHandler.H9wAp3rhRixiAKGTMh0((object) componentMetadata));
            num1 = 12;
            continue;
          case 9:
            FormMetadataUpdateHandler.YvDakZrtMadynhdy26m((object) formViewItem, RuntimeVersion.Version2);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 5 : 2;
            continue;
          case 10:
            goto label_82;
          case 11:
label_63:
            if (formViewItem.Toolbar == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 0 : 0;
              continue;
            }
            goto case 6;
          case 12:
            enumerator2 = formViewItem.GetAllItems(false).ToList<ViewItem>().GetEnumerator();
            num1 = 4;
            continue;
          case 13:
            if (componentMetadata != null)
            {
              formPartMetadata = (FormPartMetadata) FormMetadataUpdateHandler.jCd7xhrZX6mQ06lq4Jx((object) this, (object) updateResult);
              num1 = 7;
              continue;
            }
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 10 : 10;
            continue;
          default:
label_62:
            FormMetadataUpdateHandler.OhHl1krDaVqgOFOU7Nw((object) formViewItem, (object) this.OnLoadScriptName);
            num1 = 9;
            continue;
        }
        componentMetadata = obj as ComponentMetadata;
        num1 = 13;
      }
label_6:
      return;
label_82:;
    }

    /// <inheritdoc />
    public void UpdateScriptModules(IMetadataUpdateResult updateResult)
    {
      int num1 = 94;
      while (true)
      {
        int num2 = num1;
        NamespaceDeclarationSyntax oldNode1;
        UsingDirectiveSyntax current1;
        int num3;
        SeparatedSyntaxList<ParameterSyntax> parameters1;
        ParameterSyntax current2;
        string[] strArray;
        CompilationUnitSyntax root1;
        string str1;
        NamespaceDeclarationSyntax newNode1;
        string oldUsingName;
        ScriptModule newScriptModule;
        while (true)
        {
          MemberDeclarationSyntax current3;
          MethodDeclarationSyntax declarationSyntax1;
          List<MemberDeclarationSyntax> nodes1;
          SyntaxToken syntaxToken1;
          string str2;
          SeparatedSyntaxList<ParameterSyntax> parameters2;
          SeparatedSyntaxList<ParameterSyntax>.Enumerator enumerator1;
          SyntaxList<MemberDeclarationSyntax> members1;
          SyntaxList<MemberDeclarationSyntax>.Enumerator enumerator2;
          SyntaxList<UsingDirectiveSyntax>.Enumerator enumerator3;
          NamespaceDeclarationSyntax declarationSyntax2;
          CompilationUnitSyntax root2;
          List<ClassDeclarationSyntax> list;
          string str3;
          ClassDeclarationSyntax declarationSyntax3;
          List<MemberDeclarationSyntax> nodes2;
          MethodDeclarationSyntax declarationSyntax4;
          int index;
          MemberDeclarationSyntax current4;
          ClassDeclarationSyntax oldNode2;
          SyntaxTokenList syntaxTokenList;
          string str4;
          string str5;
          string str6;
          List<UsingDirectiveSyntax> nodes3;
          ClassDeclarationSyntax newNode2;
          SyntaxList<UsingDirectiveSyntax> usings1;
          string str7;
          ComponentMetadataItem componentMetadataItem;
          SyntaxToken syntaxToken2;
          ClassDeclarationSyntax declarationSyntax5;
          ScriptModule oldScriptModule;
          switch (num2)
          {
            case 1:
            case 25:
            case 113:
              if (enumerator2.MoveNext())
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 15 : 22;
                continue;
              }
              goto case 62;
            case 2:
            case 23:
            case 37:
              if (enumerator2.MoveNext())
              {
                num2 = 21;
                continue;
              }
              goto case 72;
            case 3:
              if (declarationSyntax2 == null)
              {
                num2 = 95;
                continue;
              }
              goto case 36;
            case 4:
              nodes1 = new List<MemberDeclarationSyntax>();
              num2 = 53;
              continue;
            case 5:
              goto label_19;
            case 6:
              str1 = (string) FormMetadataUpdateHandler.WDAIHarxL0MR7HLB8GN((object) this, (object) updateResult);
              num2 = 32;
              continue;
            case 7:
              num2 = 19;
              continue;
            case 8:
              if (index <= num3)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 114 : 1;
                continue;
              }
              goto case 66;
            case 9:
              if (!(current4 is ClassDeclarationSyntax declarationSyntax6))
                goto case 38;
              else
                goto label_44;
            case 10:
              parameters1 = new SeparatedSyntaxList<ParameterSyntax>();
              num2 = 50;
              continue;
            case 11:
              syntaxToken1 = declarationSyntax6.Identifier;
              num2 = 30;
              continue;
            case 12:
              declarationSyntax5 = (ClassDeclarationSyntax) null;
              break;
            case 13:
              declarationSyntax3 = list.FirstOrDefault<ClassDeclarationSyntax>((Func<ClassDeclarationSyntax, bool>) (c =>
              {
                int num4 = 1;
                SyntaxToken syntaxToken3;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      syntaxToken3 = FormMetadataUpdateHandler.\u003C\u003Ec__DisplayClass3_0.vSBd47fjiIPTU7ChBF04((object) c);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_2;
                  }
                }
label_2:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                return FormMetadataUpdateHandler.\u003C\u003Ec__DisplayClass3_0.kP0Y9LfjqiefwSUmDR4Q((object) syntaxToken3.ToString(), FormMetadataUpdateHandler.\u003C\u003Ec__DisplayClass3_0.P6cejefjRwCP0J1AuyN7((object) oldScriptModule));
              }));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 56 : 4;
              continue;
            case 14:
              goto label_25;
            case 15:
              goto label_62;
            case 16:
              nodes2.Add(current3);
              num2 = 37;
              continue;
            case 17:
            case 18:
              syntaxTokenList = FormMetadataUpdateHandler.UNV9okr0AQ3mkIvt0s3((object) declarationSyntax1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 48 : 108;
              continue;
            case 19:
              goto label_54;
            case 20:
              if (!FormMetadataUpdateHandler.LbDodyr586pN13ZjWlR((object) str3, (object) str6))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 29 : 83;
                continue;
              }
              goto label_50;
            case 21:
            case 90:
              current3 = enumerator2.Current;
              num2 = 57;
              continue;
            case 22:
            case 96:
              current4 = enumerator2.Current;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 8 : 9;
              continue;
            case 24:
            case 104:
            case 109:
              if (enumerator3.MoveNext())
              {
                num2 = 100;
                continue;
              }
              goto case 6;
            case 26:
              if (oldNode2 == null)
              {
                num2 = 63;
                continue;
              }
              nodes3 = new List<UsingDirectiveSyntax>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 56 : 84;
              continue;
            case 27:
              goto label_27;
            case 28:
              componentMetadataItem = updateResult.Entities.FirstOrDefault<IEntity>() as ComponentMetadataItem;
              num2 = 112;
              continue;
            case 29:
            case 43:
            case 95:
              goto label_64;
            case 30:
              if (FormMetadataUpdateHandler.LbDodyr586pN13ZjWlR((object) syntaxToken1.ToString(), (object) str2))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 1;
                continue;
              }
              goto case 38;
            case 31:
            case 48:
              current2 = enumerator1.Current;
              num2 = 103;
              continue;
            case 32:
              nodes2 = new List<MemberDeclarationSyntax>();
              num2 = 74;
              continue;
            case 33:
              num3 = index + 1;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 42 : 111;
              continue;
            case 34:
              if (!(str3 == str7))
              {
                num2 = 20;
                continue;
              }
              goto label_50;
            case 35:
              goto label_72;
            case 36:
              if (oldNode1 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 2 : 29;
                continue;
              }
              goto case 41;
            case 38:
              nodes1.Add(current4);
              num2 = 25;
              continue;
            case 39:
              index = 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 46 : 21;
              continue;
            case 40:
            case 45:
              if (num3 != -1)
              {
                num2 = 8;
                continue;
              }
              goto case 70;
            case 41:
              syntaxToken1 = FormMetadataUpdateHandler.liMSIjrcM7xvGO0Shyr((object) declarationSyntax3);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 107 : 4;
              continue;
            case 42:
              str7 = (string) FormMetadataUpdateHandler.mi5wNbryEBj6TbuDyHx((object) this, (object) updateResult);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 57 : 68;
              continue;
            case 44:
              str4 = strArray[index];
              num2 = 75;
              continue;
            case 46:
            case 47:
              if (index < strArray.Length)
                goto case 44;
              else
                goto label_117;
            case 50:
              parameters2 = ((BaseParameterListSyntax) FormMetadataUpdateHandler.iSkaTcr9LaRmDwN1Ite((object) declarationSyntax1)).Parameters;
              num2 = 60;
              continue;
            case 51:
              goto label_51;
            case 52:
              if (oldScriptModule != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 10 : 28;
                continue;
              }
              goto label_118;
            case 53:
              members1 = declarationSyntax2.Members;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 106 : 61;
              continue;
            case 54:
            case 58:
            case 85:
              parameters1 = parameters1.Add(current2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 0 : 0;
              continue;
            case 55:
              enumerator3 = usings1.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 27 : 104;
              continue;
            case 56:
              if (declarationSyntax3 != null)
              {
                root1 = (CompilationUnitSyntax) FormMetadataUpdateHandler.J6wtPNrArWqgM58V4OP((object) CSharpSyntaxTree.ParseText((string) FormMetadataUpdateHandler.vvZ7hyrHQJfEKntXuFL((object) newScriptModule), (CSharpParseOptions) FormMetadataUpdateHandler.COWXvVr60lNhJrVyDAY(FormMetadataUpdateHandler.vkKrYmr4r9WpZvw8jH6(), LanguageVersion.CSharp7), "", (Encoding) null, (ImmutableDictionary<string, ReportDiagnostic>) null, new CancellationToken()), new CancellationToken());
                num2 = 91;
                continue;
              }
              goto label_111;
            case 57:
              declarationSyntax1 = current3 as MethodDeclarationSyntax;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 48 : 67;
              continue;
            case 59:
              if (!FormMetadataUpdateHandler.LbDodyr586pN13ZjWlR(FormMetadataUpdateHandler.ClscPLrUqvnrJy1wHI8((object) str3, (object) new char[1]
              {
                '<'
              })[0], (object) str5))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 50 : 54;
                continue;
              }
              goto case 88;
            case 60:
              enumerator1 = parameters2.GetEnumerator();
              num2 = 73;
              continue;
            case 61:
              if (newScriptModule != null)
              {
                num2 = 102;
                continue;
              }
              goto label_120;
            case 62:
              NamespaceDeclarationSyntax declarationSyntax7 = oldNode1;
              members1 = oldNode1.Members;
              SyntaxList<MemberDeclarationSyntax> members2 = members1.AddRange((IEnumerable<MemberDeclarationSyntax>) nodes1);
              newNode1 = declarationSyntax7.WithMembers(members2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 5 : 35;
              continue;
            case 63:
              goto label_88;
            case 64:
              nodes2.Add((MemberDeclarationSyntax) declarationSyntax4);
              num2 = 23;
              continue;
            case 65:
              members1 = root2.Members;
              num2 = 97;
              continue;
            case 66:
              strArray[index] = (string) FormMetadataUpdateHandler.hquljLgB1VwXei7iToX(FormMetadataUpdateHandler.rWV6Arr33cqBQRkeYxX(-1852837372 ^ -1852838482), (object) str4);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 70 : 13;
              continue;
            case 67:
              if (declarationSyntax1 != null)
              {
                num2 = 18;
                continue;
              }
              goto case 16;
            case 68:
              str6 = (string) FormMetadataUpdateHandler.cbC7XQrMfYOQYc4YaFo((object) this, (object) updateResult);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 59 : 79;
              continue;
            case 70:
            case 114:
              ++index;
              num2 = 47;
              continue;
            case 71:
              list = root2.DescendantNodes().OfType<ClassDeclarationSyntax>().ToList<ClassDeclarationSyntax>();
              num2 = 13;
              continue;
            case 72:
              ClassDeclarationSyntax declarationSyntax8 = oldNode2;
              members1 = oldNode2.Members;
              SyntaxList<MemberDeclarationSyntax> members3 = members1.AddRange((IEnumerable<MemberDeclarationSyntax>) nodes2);
              newNode2 = declarationSyntax8.WithMembers(members3);
              num2 = 78;
              continue;
            case 74:
              members1 = declarationSyntax3.Members;
              num2 = 101;
              continue;
            case 75:
              if (FormMetadataUpdateHandler.LbDodyr586pN13ZjWlR((object) str4.Trim(), FormMetadataUpdateHandler.rWV6Arr33cqBQRkeYxX(132912447 ^ 132961909)))
              {
                num2 = 33;
                continue;
              }
              goto case 111;
            case 76:
              declarationSyntax4 = (MethodDeclarationSyntax) FormMetadataUpdateHandler.uIFwRwrsCw5FXV9rdX4((object) declarationSyntax4, (object) SyntaxFactory.ParameterList(parameters1).WithTrailingTrivia<ParameterListSyntax>(FormMetadataUpdateHandler.qCMWjarYd22ntNehs2r(FormMetadataUpdateHandler.iSkaTcr9LaRmDwN1Ite((object) declarationSyntax4))));
              num2 = 64;
              continue;
            case 77:
              num3 = -1;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 22 : 39;
              continue;
            case 78:
              CompilationUnitSyntax compilationUnitSyntax = root1.ReplaceNode<CompilationUnitSyntax>((SyntaxNode) oldNode2, (SyntaxNode) newNode2);
              usings1 = root1.Usings;
              SyntaxList<UsingDirectiveSyntax> usings2 = usings1.AddRange((IEnumerable<UsingDirectiveSyntax>) nodes3);
              root1 = compilationUnitSyntax.WithUsings(usings2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 92 : 11;
              continue;
            case 79:
              str5 = (string) FormMetadataUpdateHandler.ih9fXhrJNRt1QARXQXC((object) this);
              num2 = 10;
              continue;
            case 80:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              if (root1.Usings.FirstOrDefault<UsingDirectiveSyntax>((Func<UsingDirectiveSyntax, bool>) (u => FormMetadataUpdateHandler.\u003C\u003Ec__DisplayClass3_1.PaBJJEfjO2pT2N1e18MR((object) FormMetadataUpdateHandler.\u003C\u003Ec__DisplayClass3_1.K1PBlEfjnxkFEg43Jalu((object) u).ToString(), (object) oldUsingName))) != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 109 : 82;
                continue;
              }
              goto case 81;
            case 81:
              nodes3.Add(current1);
              num2 = 24;
              continue;
            case 82:
              oldNode1 = members1.FirstOrDefault() as NamespaceDeclarationSyntax;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 3 : 3;
              continue;
            case 83:
            case 86:
              if (!str3.Contains((string) FormMetadataUpdateHandler.rWV6Arr33cqBQRkeYxX(1253244298 - 1829393894 ^ -576133022)))
              {
                num2 = 58;
                continue;
              }
              goto case 59;
            case 84:
              usings1 = root2.Usings;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 3 : 55;
              continue;
            case 87:
            case 100:
              current1 = enumerator3.Current;
              num2 = 7;
              continue;
            case 88:
              parameters1 = parameters1.Add(current2);
              num2 = 49;
              continue;
            case 89:
              goto label_122;
            case 91:
              ClassDeclarationSyntax declarationSyntax9 = root1.DescendantNodes().OfType<ClassDeclarationSyntax>().ToList<ClassDeclarationSyntax>().FirstOrDefault<ClassDeclarationSyntax>((Func<ClassDeclarationSyntax, bool>) (q =>
              {
                int num5 = 1;
                SyntaxToken identifier;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      identifier = q.Identifier;
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_2;
                  }
                }
label_2:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                return FormMetadataUpdateHandler.\u003C\u003Ec__DisplayClass3_0.kP0Y9LfjqiefwSUmDR4Q((object) identifier.ToString(), FormMetadataUpdateHandler.\u003C\u003Ec__DisplayClass3_0.P6cejefjRwCP0J1AuyN7((object) newScriptModule));
              }));
              if (declarationSyntax9 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 12 : 2;
                continue;
              }
              declarationSyntax5 = declarationSyntax9.Members.OfType<ClassDeclarationSyntax>().FirstOrDefault<ClassDeclarationSyntax>((Func<ClassDeclarationSyntax, bool>) (q =>
              {
                int num6 = 1;
                SyntaxToken syntaxToken4;
                while (true)
                {
                  switch (num6)
                  {
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      syntaxToken4 = FormMetadataUpdateHandler.\u003C\u003Ec.qfwoJEfjNhg0okqJ5PMM((object) q);
                      num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_3;
                  }
                }
label_3:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                return FormMetadataUpdateHandler.\u003C\u003Ec.aMPKuifjpvurkGkFFkxq((object) syntaxToken4.ToString(), FormMetadataUpdateHandler.\u003C\u003Ec.lLQIbEfj3ZqTyUuYl8cX(--1418440330 ^ 1418379112));
              }));
              break;
            case 92:
              if (list.Count > 1)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 35 : 65;
                continue;
              }
              goto label_64;
            case 93:
              oldScriptModule = updateResult.ScriptModules.FirstOrDefault<ScriptModule>();
              num2 = 52;
              continue;
            case 94:
              num2 = 93;
              continue;
            case 97:
              declarationSyntax2 = members1.FirstOrDefault() as NamespaceDeclarationSyntax;
              num2 = 105;
              continue;
            case 98:
              declarationSyntax4 = declarationSyntax1.WithModifiers(FormMetadataUpdateHandler.EfRHVurmIoKp5rGR2i0(syntaxToken2));
              num2 = 42;
              continue;
            case 99:
              goto label_56;
            case 101:
              enumerator2 = members1.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 2 : 1;
              continue;
            case 102:
              root2 = (CompilationUnitSyntax) CSharpSyntaxTree.ParseText(oldScriptModule.SourceCode, (CSharpParseOptions) FormMetadataUpdateHandler.COWXvVr60lNhJrVyDAY(FormMetadataUpdateHandler.vkKrYmr4r9WpZvw8jH6(), LanguageVersion.CSharp7), "", (Encoding) null, (ImmutableDictionary<string, ReportDiagnostic>) null, new CancellationToken()).GetRoot();
              num2 = 71;
              continue;
            case 103:
              str3 = ((string) FormMetadataUpdateHandler.fmUDr7rrrfRUlZkEhxq(FormMetadataUpdateHandler.fmUDr7rrrfRUlZkEhxq(FormMetadataUpdateHandler.WEoim0rlVRR30pfgGI0((object) FormMetadataUpdateHandler.vTdNW6rdPwODiIETfGj((object) current2).ToString()), FormMetadataUpdateHandler.rWV6Arr33cqBQRkeYxX(1232639661 >> 3 ^ 154098679), (object) ""), FormMetadataUpdateHandler.rWV6Arr33cqBQRkeYxX(1461825605 - 1531863589 ^ -70037110), (object) "")).Replace((string) FormMetadataUpdateHandler.vbpkyrrgxGCfCgPtnds(), "");
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 4 : 34;
              continue;
            case 105:
              members1 = root1.Members;
              num2 = 82;
              continue;
            case 106:
              enumerator2 = members1.GetEnumerator();
              num2 = 113;
              continue;
            case 107:
              str2 = syntaxToken1.ToString();
              num2 = 4;
              continue;
            case 108:
              syntaxToken2 = syntaxTokenList.First();
              num2 = 98;
              continue;
            case 110:
              goto label_50;
            case 111:
              if (!FormMetadataUpdateHandler.LbDodyr586pN13ZjWlR((object) str4, FormMetadataUpdateHandler.rWV6Arr33cqBQRkeYxX(813604817 ^ 813587521)))
              {
                num2 = 45;
                continue;
              }
              goto label_25;
            case 112:
              newScriptModule = componentMetadataItem == null ? (ScriptModule) (object) null : (ScriptModule) FormMetadataUpdateHandler.jwFDDyrw0XeTWakf6ZD((object) componentMetadataItem);
              num2 = 61;
              continue;
            default:
              if (enumerator1.MoveNext())
              {
                num2 = 31;
                continue;
              }
              goto case 76;
          }
          oldNode2 = declarationSyntax5;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 26 : 26;
        }
label_25:
        num3 = -1;
        num1 = 40;
        continue;
label_44:
        num1 = 11;
        continue;
label_50:
        ParameterSyntax node = (ParameterSyntax) FormMetadataUpdateHandler.kGeHEHrL7Og3sAN9spx((object) current2, (object) ((TypeSyntax) FormMetadataUpdateHandler.MHDFxJrjJgXhXaoJ9UP(FormMetadataUpdateHandler.rWV6Arr33cqBQRkeYxX(322893104 - -1992822529 ^ -1979201787), 0, true)).WithTrailingTrivia<TypeSyntax>(FormMetadataUpdateHandler.qCMWjarYd22ntNehs2r(FormMetadataUpdateHandler.vTdNW6rdPwODiIETfGj((object) current2))));
        num1 = 51;
        continue;
label_51:
        parameters1 = parameters1.Add(node.WithTrailingTrivia<ParameterSyntax>(current2.GetTrailingTrivia()));
        num1 = 69;
        continue;
label_54:
        oldUsingName = FormMetadataUpdateHandler.RXsW06r7fXKiOOaD7eW((object) current1).ToString();
        num1 = 80;
        continue;
label_56:
        newScriptModule.SourceCode = string.Join((string) FormMetadataUpdateHandler.vbpkyrrgxGCfCgPtnds(), strArray);
        num1 = 89;
        continue;
label_64:
        strArray = (string[]) FormMetadataUpdateHandler.nj4XDBgFtKGH2sXNEJX(FormMetadataUpdateHandler.fmUDr7rrrfRUlZkEhxq(FormMetadataUpdateHandler.UMB2lyrzdiff8p1T5d2((object) root1), (object) (str1 + (string) FormMetadataUpdateHandler.rWV6Arr33cqBQRkeYxX(-1638402543 ^ -1638404907)), (object) ""), (object) new string[1]
        {
          (string) FormMetadataUpdateHandler.vbpkyrrgxGCfCgPtnds()
        }, StringSplitOptions.None);
        num1 = 77;
        continue;
label_72:
        root1 = root1.ReplaceNode<CompilationUnitSyntax>((SyntaxNode) oldNode1, (SyntaxNode) newNode1);
        num1 = 43;
        continue;
label_111:
        num1 = 27;
        continue;
label_117:
        num1 = 99;
      }
label_19:
      return;
label_62:
      return;
label_27:
      return;
label_88:
      return;
label_122:
      return;
label_120:
      return;
label_118:;
    }

    /// <summary>Имя скрипта при загрузке формы</summary>
    protected abstract string OnLoadScriptName { get; }

    /// <summary>Получить имя метаданных</summary>
    /// <param name="updateResult">Результат обновления метаданных</param>
    /// <returns>Имя метаданных</returns>
    protected abstract string GetMetadataName(IMetadataUpdateResult updateResult);

    /// <summary>Получить метаданные контента</summary>
    /// <param name="updateResult">Результат обновления метаданных</param>
    /// <returns>Метаданные контента</returns>
    protected abstract FormPartMetadata GetContent(IMetadataUpdateResult updateResult);

    /// <summary>
    /// Получить имя типа параметра метода для обычных скриптов
    /// </summary>
    /// <param name="updateResult">Результат обновления метаданных</param>
    /// <returns>Имя типа параметра для обычных скриптов</returns>
    protected abstract string GetViewModelTypeName(IMetadataUpdateResult updateResult);

    /// <summary>
    /// Получить имя типа параметра метода для скрипта при загрузке формы
    /// </summary>
    /// <param name="updateResult">Результат обновления метаданных</param>
    /// <returns>Имя типа параметра для скрипта при загрузке формы</returns>
    protected abstract string GetLoadViewModelTypeName(IMetadataUpdateResult updateResult);

    /// <summary>Имя типа параметра метода для скриптов блоков</summary>
    protected abstract string ItemViewModelTypeName { get; }

    /// <summary>Дополнительные действия с метаданными</summary>
    /// <param name="formMetadata">Метаданные формы</param>
    /// <param name="componentMetadata">Метаданные компонента</param>
    protected virtual void AdditionalMetadataActions(
      FormMetadata formMetadata,
      ComponentMetadata componentMetadata)
    {
    }

    /// <summary>Склонировать в метаданные свойства</summary>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <returns>Клонированные метаданные свойства</returns>
    protected static ViewModelPropertyMetadata CloneToViewModelPropertyMetadata(
      PropertyMetadata propertyMetadata)
    {
      ViewModelPropertyMetadata propertyMetadata1 = FormMetadataUpdateHandler.ClonePropertyMetadata<ViewModelPropertyMetadata>((object) propertyMetadata);
      FormMetadataUpdateHandler.llKYIYgWt3NRycrXZbk((object) propertyMetadata1, false);
      propertyMetadata1.ClientOnly = false;
      FormMetadataUpdateHandler.khO4JigoL4GyUFJ6NUL((object) propertyMetadata1, (object) null);
      return propertyMetadata1;
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
            enumerator = ((IEnumerable) FormMetadataUpdateHandler.UEtUAvrnTgIEthkKCEI(propertyViewItem)).OfType<PropertyViewItem>().GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_23;
          default:
            goto label_2;
        }
      }
label_23:
      return;
label_2:
      try
      {
label_5:
        if (enumerator.MoveNext())
          goto label_11;
        else
          goto label_6;
label_4:
        PropertyViewItem current;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (current.PropertyParents != null)
              {
                num2 = 8;
                continue;
              }
              break;
            case 2:
            case 10:
              current.PropertyParents.AddRange((IEnumerable<Guid>) ((PropertyViewItem) propertyViewItem).PropertyParents);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 3 : 2;
              continue;
            case 3:
              current.PropertyParents.Add(FormMetadataUpdateHandler.MsCIegrVuscyMVFg0M9(propertyViewItem));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 5 : 0;
              continue;
            case 4:
              FormMetadataUpdateHandler.bJfuJlrOZffNN5s76bu((object) current);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 9 : 2;
              continue;
            case 5:
              if (FormMetadataUpdateHandler.ANtxYkghj88QxxXL3br(FormMetadataUpdateHandler.UEtUAvrnTgIEthkKCEI((object) current)) > 0)
              {
                num2 = 4;
                continue;
              }
              goto label_5;
            case 6:
              goto label_18;
            case 7:
            case 8:
              FormMetadataUpdateHandler.beN7DCgb0QRmEbycXxL((object) current.PropertyParents);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 5 : 10;
              continue;
            case 9:
              goto label_5;
            case 11:
              goto label_11;
          }
          current.PropertyParents = new List<Guid>();
          num2 = 2;
        }
label_18:
        return;
label_6:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 6 : 3;
        goto label_4;
label_11:
        current = enumerator.Current;
        num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
        {
          num2 = 1;
          goto label_4;
        }
        else
          goto label_4;
      }
      finally
      {
        if (enumerator != null)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_25;
              default:
                enumerator.Dispose();
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 1 : 0;
                continue;
            }
          }
        }
label_25:;
      }
    }

    private static PropertyMetadata CloneToPropertyMetadata(object propertyMetadata) => FormMetadataUpdateHandler.ClonePropertyMetadata<PropertyMetadata>(propertyMetadata);

    private static string GetNewScriptMethodName(object oldMethodName, Guid componentMetadataUid)
    {
      int num = 4;
      string str1;
      while (true)
      {
        string str2;
        object obj;
        switch (num)
        {
          case 1:
            if (!FormMetadataUpdateHandler.eAm4JmgGmZa8gEh62hy((object) str2, FormMetadataUpdateHandler.rWV6Arr33cqBQRkeYxX(-649342099 - -1150814748 ^ 501465663)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 0 : 0;
              continue;
            }
            obj = FormMetadataUpdateHandler.NfhNJdgEvye7B4YVOOF((object) str2, 0, str2.IndexOf('('));
            break;
          case 2:
            goto label_8;
          case 3:
            str2 = (string) FormMetadataUpdateHandler.nj4XDBgFtKGH2sXNEJX(oldMethodName, (object) new string[1]
            {
              (string) FormMetadataUpdateHandler.rWV6Arr33cqBQRkeYxX(95909607 + 343705423 ^ 439565712)
            }, StringSplitOptions.None)[0];
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 1 : 1;
            continue;
          case 4:
            if (!FormMetadataUpdateHandler.Td9p0IrSKVU9ohu72C6(oldMethodName))
            {
              num = 3;
              continue;
            }
            goto label_8;
          case 5:
            goto label_6;
          default:
            obj = (object) str2;
            break;
        }
        str1 = (string) obj;
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 0 : 5;
      }
label_6:
      ScriptMethodInfo scriptMethodInfo = new ScriptMethodInfo();
      scriptMethodInfo.Name = str1;
      scriptMethodInfo.CodeType = CodeType.Server;
      FormMetadataUpdateHandler.zwTfAwgffHKtB1YxFq4((object) scriptMethodInfo, componentMetadataUid);
      return (string) FormMetadataUpdateHandler.k1kgTogQfJIVNtTAQHn((object) scriptMethodInfo);
label_8:
      return string.Empty;
    }

    private static T ClonePropertyMetadata<T>(object propertyMetadata) where T : PropertyMetadata, new()
    {
      T obj = new T();
      obj.Description = ((NamedMetadata) propertyMetadata).Description;
      obj.Groupable = ((PropertyMetadata) propertyMetadata).Groupable;
      obj.Handlers = ((PropertyMetadata) propertyMetadata).Handlers;
      obj.Id = ((Entity<long>) propertyMetadata).Id;
      obj.Images = ((NamedMetadata) propertyMetadata).Images;
      obj.Internal = ((AbstractMetadata) propertyMetadata).Internal;
      obj.Name = ((NamedMetadata) propertyMetadata).Name;
      obj.Nullable = ((PropertyMetadata) propertyMetadata).Nullable;
      obj.Order = ((PropertyMetadata) propertyMetadata).Order;
      obj.Required = ((PropertyMetadata) propertyMetadata).Required;
      obj.Settings = ((PropertyMetadata) propertyMetadata).Settings;
      obj.Sortable = ((PropertyMetadata) propertyMetadata).Sortable;
      obj.Uid = ((AbstractMetadata) propertyMetadata).Uid;
      obj.AdditionalAttributes = ((PropertyMetadata) propertyMetadata).AdditionalAttributes;
      obj.CalculateScript = ((PropertyMetadata) propertyMetadata).CalculateScript;
      obj.CalculateType = ((PropertyMetadata) propertyMetadata).CalculateType;
      obj.DeclaringType = ((PropertyMetadata) propertyMetadata).DeclaringType;
      obj.DisplayName = ((NamedMetadata) propertyMetadata).DisplayName;
      obj.ModuleUid = ((AbstractMetadata) propertyMetadata).ModuleUid;
      obj.NamedImages = ((NamedMetadata) propertyMetadata).NamedImages;
      obj.TypeResolver = ((PropertyMetadata) propertyMetadata).TypeResolver;
      obj.TypeUid = ((PropertyMetadata) propertyMetadata).TypeUid;
      obj.SubTypeUid = ((PropertyMetadata) propertyMetadata).SubTypeUid;
      obj.ViewSettings = ((PropertyMetadata) propertyMetadata).ViewSettings;
      obj.XmlComments = ((NamedDocumentedMetadata) propertyMetadata).XmlComments;
      obj.OwnerPropertyUid = ((PropertyMetadata) propertyMetadata).OwnerPropertyUid;
      obj.TableCellAlignment = ((PropertyMetadata) propertyMetadata).TableCellAlignment;
      obj.TableColumnWidth = ((PropertyMetadata) propertyMetadata).TableColumnWidth;
      obj.OnChangeScriptName = ((PropertyMetadata) propertyMetadata).OnChangeScriptName;
      obj.SQLFormula = ((PropertyMetadata) propertyMetadata).SQLFormula;
      obj.IsSystem = false;
      return obj;
    }

    private static void ProcessTableParts(
      List<TablePartMetadata> tableParts,
      object componentMetadata,
      object tablePartPropertyOwner)
    {
      if (tableParts.Count > 0)
        throw new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1113862659 ^ 1113911731)));
      foreach (TablePartMetadata tablePart in tableParts)
      {
        DataClassMetadata tablePartPropertyOwner1 = new DataClassMetadata(Guid.Empty);
        tablePartPropertyOwner1.InitNew();
        tablePartPropertyOwner1.Internal = true;
        tablePartPropertyOwner1.Namespace = ((ComponentMetadata) componentMetadata).Namespace;
        tablePartPropertyOwner1.Name = tablePart.Name;
        tablePartPropertyOwner1.DisplayName = tablePart.DisplayName;
        tablePartPropertyOwner1.Description = tablePart.Description;
        TableView tableView1 = tablePart.TableViews.FirstOrDefault<TableView>();
        TableView tableView2 = tablePartPropertyOwner1.TableViews.FirstOrDefault<TableView>();
        if (tableView1 != null && tableView2 != null)
        {
          tableView2.Customizable = tableView1.Customizable;
          tableView2.Groupable = tableView1.Groupable;
          tableView2.Pageable = tableView1.Pageable;
          tableView2.Reorderable = tableView1.Reorderable;
          tableView2.Resizeable = tableView1.Resizeable;
          tableView2.Sortable = tableView1.Sortable;
          tableView2.CanAdd = tableView1.CanAdd;
          tableView2.CanDelete = tableView1.CanDelete;
          tableView2.CanEdit = tableView1.CanEdit;
          tableView2.GroupDescriptors = tableView1.GroupDescriptors;
          tableView2.PageSize = tableView1.PageSize;
          tableView2.ShowHeader = tableView1.ShowHeader;
          tableView2.SortDescriptors = tableView1.SortDescriptors;
          tableView2.ViewType = tableView1.ViewType;
          tableView2.AddRowMode = tableView1.AddRowMode;
          tableView2.EditRowMode = tableView1.EditRowMode;
        }
        foreach (PropertyMetadata property in tablePart.Properties)
        {
          if (!(property.Name == z2jc63fLkugS1X8Q9N.tE1kD1vbB(901793403 ^ 901830221)))
            tablePartPropertyOwner1.Properties.Add(FormMetadataUpdateHandler.CloneToPropertyMetadata((object) property));
        }
        PropertyMetadata propertyMetadata = tablePartPropertyOwner is DataClassMetadata ? new PropertyMetadata() : (PropertyMetadata) new ViewModelPropertyMetadata();
        propertyMetadata.Uid = tablePart.TablePartPropertyUid;
        propertyMetadata.Name = tablePart.TablePartPropertyName;
        propertyMetadata.DisplayName = tablePart.DisplayName;
        propertyMetadata.TypeUid = DataClassDescriptor.UID;
        propertyMetadata.SubTypeUid = tablePartPropertyOwner1.Uid;
        propertyMetadata.Description = tablePart.Description;
        if (propertyMetadata.Settings is DataClassSettings settings)
        {
          settings.RelationType = RelationType.ManyToMany;
          settings.DisplayType = DataClassDisplayType.Table;
        }
        ((ClassMetadata) tablePartPropertyOwner).Properties.Add(propertyMetadata);
        ((ComponentMetadata) componentMetadata).DataClasses.Add(tablePartPropertyOwner1);
        FormMetadataUpdateHandler.ProcessTableParts(tablePart.TableParts, componentMetadata, (object) tablePartPropertyOwner1);
      }
    }

    protected FormMetadataUpdateHandler()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object MrqR0HrbcpOZmygTdOe([In] object obj0) => (object) ((FormPartMetadata) obj0).Context;

    internal static object H9wAp3rhRixiAKGTMh0([In] object obj0) => (object) ((ComponentMetadata) obj0).Content;

    internal static object PpyWa5rG8jgdFsMjA0R([In] object obj0) => (object) ((ComponentContentMetadata) obj0).Context;

    internal static object y5an62rES0egbuGCM5Z([In] object obj0) => (object) FormMetadataUpdateHandler.CloneToViewModelPropertyMetadata((PropertyMetadata) obj0);

    internal static object CeoNSMrfeKUhGhvEX5w([In] object obj0) => (object) ((FormPartMetadata) obj0).View;

    internal static object jhjd7QrQgDm82pob9Aj([In] object obj0) => (object) ((ViewItem) obj0).Clone();

    internal static void drI8OErCKEvsEppV7cN([In] object obj0, [In] object obj1) => ((ComponentContentMetadata) obj0).View = (FormViewItem) obj1;

    internal static object dVjlPRrvVq5X37SMaZW([In] object obj0) => (object) ((IMetadataUpdateResult) obj0).Metadata;

    internal static bool FHJDx6rWslVLPrBtAy1() => FormMetadataUpdateHandler.sM7DfOrBsi0mRFfAE3m == null;

    internal static FormMetadataUpdateHandler KYmLTmroYWhsemYbuQ8() => FormMetadataUpdateHandler.sM7DfOrBsi0mRFfAE3m;

    internal static object sx9QCrr87fDlWQpjd62([In] object obj0) => ((ComponentMetadataItem) obj0).Metadata;

    internal static object jCd7xhrZX6mQ06lq4Jx([In] object obj0, [In] object obj1) => (object) ((FormMetadataUpdateHandler) obj0).GetContent((IMetadataUpdateResult) obj1);

    internal static object xobluAruT4OY4FHo96T([In] object obj0) => (object) ((ComponentContentMetadata) obj0).View;

    internal static object B20yE5rIyHevNQd7Sei([In] object obj0) => (object) ((PropertyViewItem) obj0).Attributes;

    internal static Guid MsCIegrVuscyMVFg0M9([In] object obj0) => ((PropertyViewItem) obj0).PropertyUid;

    internal static bool Td9p0IrSKVU9ohu72C6([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object QFtvdtriSDvn1EaG8bG([In] object obj0) => (object) ((PropertyMetadata) obj0).OnChangeScriptName;

    internal static object tdjmrcrRnKujflQdhNP([In] object obj0) => (object) ((TablePartMetadata) obj0).OnChangeScriptName;

    internal static Guid VY87cbrqrpr0h7WOyB9([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static object xALCBRrKhwkZ0BQI4ua([In] object obj0, Guid componentMetadataUid) => (object) FormMetadataUpdateHandler.GetNewScriptMethodName(obj0, componentMetadataUid);

    internal static void wkXidwrXj7IWSg06oll([In] object obj0, [In] object obj1) => ((ViewAttributes) obj0).OnChangeScriptName = (string) obj1;

    internal static void VM7mMxrTesSPsFbr0tR([In] object obj0, CodeType value) => ((ViewAttributes) obj0).OnChangeCodeType = value;

    internal static object o4RVf5rkKycPEjBv5mH([In] object obj0) => (object) ((ViewAttributes) obj0).OnViewLoadScriptName;

    internal static object UEtUAvrnTgIEthkKCEI([In] object obj0) => (object) ((RootViewItem) obj0).Items;

    internal static void bJfuJlrOZffNN5s76bu([In] object obj0) => FormMetadataUpdateHandler.UpdateNestedPropertyViewItem(obj0);

    internal static void oWtdKlr2LXEqh4vIEwi([In] object obj0, [In] object obj1) => ((ComputedValue) obj0).Name = (string) obj1;

    internal static void EvlL9jre6s6xutCVxrb([In] object obj0, ComputedValueType value) => ((ComputedValue) obj0).ComputedValueType = value;

    internal static object dZJLaQrPUf7cfyTxMbo([In] object obj0) => (object) ((ButtonViewItem) obj0).ScriptName;

    internal static void SAqTv5r1g6PvyF9LDSc([In] object obj0, CodeType value) => ((ButtonViewItem) obj0).CodeType = value;

    internal static object IPGHcArNpO0rK6ENjkJ([In] object obj0) => (object) ((FormViewItem) obj0).Toolbar;

    internal static object rWV6Arr33cqBQRkeYxX(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object MOc0umrpFhC3moYbLYE([In] object obj0) => (object) ((Button) obj0).ScriptName;

    internal static void Usye9lraC9JxpfW81h8([In] object obj0, CodeType value) => ((Button) obj0).CodeType = value;

    internal static void OhHl1krDaVqgOFOU7Nw([In] object obj0, [In] object obj1) => ((FormView) obj0).OnLoadScriptName = (string) obj1;

    internal static void YvDakZrtMadynhdy26m([In] object obj0, RuntimeVersion value) => ((FormViewItem) obj0).RuntimeVersion = value;

    internal static object jwFDDyrw0XeTWakf6ZD([In] object obj0) => (object) ((ComponentMetadataItem) obj0).ScriptModule;

    internal static object vkKrYmr4r9WpZvw8jH6() => (object) CSharpParseOptions.Default;

    internal static object COWXvVr60lNhJrVyDAY([In] object obj0, [In] LanguageVersion obj1) => (object) ((CSharpParseOptions) obj0).WithLanguageVersion(obj1);

    internal static object vvZ7hyrHQJfEKntXuFL([In] object obj0) => (object) ((ScriptModule) obj0).SourceCode;

    internal static object J6wtPNrArWqgM58V4OP([In] object obj0, [In] CancellationToken obj1) => (object) ((SyntaxTree) obj0).GetRoot(obj1);

    internal static object RXsW06r7fXKiOOaD7eW([In] object obj0) => (object) ((UsingDirectiveSyntax) obj0).Name;

    internal static object WDAIHarxL0MR7HLB8GN([In] object obj0, [In] object obj1) => (object) ((FormMetadataUpdateHandler) obj0).GetMetadataName((IMetadataUpdateResult) obj1);

    internal static SyntaxTokenList UNV9okr0AQ3mkIvt0s3([In] object obj0) => ((MemberDeclarationSyntax) obj0).Modifiers;

    internal static SyntaxTokenList EfRHVurmIoKp5rGR2i0([In] SyntaxToken obj0) => SyntaxTokenList.Create(obj0);

    internal static object mi5wNbryEBj6TbuDyHx([In] object obj0, [In] object obj1) => (object) ((FormMetadataUpdateHandler) obj0).GetViewModelTypeName((IMetadataUpdateResult) obj1);

    internal static object cbC7XQrMfYOQYc4YaFo([In] object obj0, [In] object obj1) => (object) ((FormMetadataUpdateHandler) obj0).GetLoadViewModelTypeName((IMetadataUpdateResult) obj1);

    internal static object ih9fXhrJNRt1QARXQXC([In] object obj0) => (object) ((FormMetadataUpdateHandler) obj0).ItemViewModelTypeName;

    internal static object iSkaTcr9LaRmDwN1Ite([In] object obj0) => (object) ((BaseMethodDeclarationSyntax) obj0).ParameterList;

    internal static object vTdNW6rdPwODiIETfGj([In] object obj0) => (object) ((ParameterSyntax) obj0).Type;

    internal static object WEoim0rlVRR30pfgGI0([In] object obj0) => (object) ((string) obj0).Trim();

    internal static object fmUDr7rrrfRUlZkEhxq([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0).Replace((string) obj1, (string) obj2);

    internal static object vbpkyrrgxGCfCgPtnds() => (object) Environment.NewLine;

    internal static bool LbDodyr586pN13ZjWlR([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static object MHDFxJrjJgXhXaoJ9UP([In] object obj0, [In] int obj1, [In] bool obj2) => (object) SyntaxFactory.ParseTypeName((string) obj0, obj1, obj2);

    internal static SyntaxTriviaList qCMWjarYd22ntNehs2r([In] object obj0) => ((CSharpSyntaxNode) obj0).GetTrailingTrivia();

    internal static object kGeHEHrL7Og3sAN9spx([In] object obj0, [In] object obj1) => (object) ((ParameterSyntax) obj0).WithType((TypeSyntax) obj1);

    internal static object ClscPLrUqvnrJy1wHI8([In] object obj0, [In] object obj1) => (object) ((string) obj0).Split((char[]) obj1);

    internal static object uIFwRwrsCw5FXV9rdX4([In] object obj0, [In] object obj1) => (object) ((MethodDeclarationSyntax) obj0).WithParameterList((ParameterListSyntax) obj1);

    internal static SyntaxToken liMSIjrcM7xvGO0Shyr([In] object obj0) => ((BaseTypeDeclarationSyntax) obj0).Identifier;

    internal static object UMB2lyrzdiff8p1T5d2([In] object obj0) => (object) ((SyntaxNode) obj0).ToFullString();

    internal static object nj4XDBgFtKGH2sXNEJX([In] object obj0, [In] object obj1, [In] StringSplitOptions obj2) => (object) ((string) obj0).Split((string[]) obj1, obj2);

    internal static object hquljLgB1VwXei7iToX([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static void llKYIYgWt3NRycrXZbk([In] object obj0, bool value) => ((ViewModelPropertyMetadata) obj0).Input = value;

    internal static void khO4JigoL4GyUFJ6NUL([In] object obj0, [In] object obj1) => ((ViewModelPropertyMetadata) obj0).ComputedValue = (ComputedValue) obj1;

    internal static void beN7DCgb0QRmEbycXxL([In] object obj0) => ((List<Guid>) obj0).Clear();

    internal static int ANtxYkghj88QxxXL3br([In] object obj0) => ((EventedList<ViewItem>) obj0).Count;

    internal static bool eAm4JmgGmZa8gEh62hy([In] object obj0, [In] object obj1) => ((string) obj0).Contains((string) obj1);

    internal static object NfhNJdgEvye7B4YVOOF([In] object obj0, [In] int obj1, [In] int obj2) => (object) ((string) obj0).Substring(obj1, obj2);

    internal static void zwTfAwgffHKtB1YxFq4([In] object obj0, Guid value) => ((ScriptMethodInfo) obj0).MetadataUid = value;

    internal static object k1kgTogQfJIVNtTAQHn([In] object obj0) => (object) ScriptMethodInfoHelper.Serialize((ScriptMethodInfo) obj0);
  }
}
