// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Db.PropertiesAndTablePartsOrderDbStructure
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Runtime.Db;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Db
{
  /// <summary>
  /// Обновить порядок свойств и блоков
  /// Убрать шаг - 10
  /// </summary>
  internal class PropertiesAndTablePartsOrderDbStructure : DbStructureExtension
  {
    internal static PropertiesAndTablePartsOrderDbStructure qmtLhvfF8YL0nOMK3CgF;

    /// <summary>Все провайдеры</summary>
    public override Guid ProviderUid => Guid.Empty;

    /// <summary>Обновить порядок свойств и блоков</summary>
    internal void UpdatePropertiesAndTablePartsOrder()
    {
      int num1 = 3;
      while (true)
      {
        IEnumerable<IMetadataItem> draftItems;
        IEnumerator<IMetadataItem> enumerator1;
        switch (num1)
        {
          case 1:
            try
            {
label_9:
              if (PropertiesAndTablePartsOrderDbStructure.RiVbyvfFSb0Id3YJTlL3((object) enumerator1))
                goto label_6;
              else
                goto label_10;
label_5:
              int num2;
              List<\u003C\u003Ef__AnonymousType0<int, IMetadata>>.Enumerator enumerator2;
              int num3;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    List<PropertyMetadata> properties = metadata1.Properties;
                    // ISSUE: reference to a compiler-generated field
                    Func<PropertyMetadata, \u003C\u003Ef__AnonymousType0<int, IMetadata>> func = PropertiesAndTablePartsOrderDbStructure.\u003C\u003Ec.\u003C\u003E9__2_0;
                    Func<PropertyMetadata, \u003C\u003Ef__AnonymousType0<int, IMetadata>> selector;
                    if (func == null)
                    {
                      // ISSUE: reference to a compiler-generated field
                      // ISSUE: object of a compiler-generated type is created
                      PropertiesAndTablePartsOrderDbStructure.\u003C\u003Ec.\u003C\u003E9__2_0 = selector = p => new \u003C\u003Ef__AnonymousType0<int, IMetadata>(p.Order, (IMetadata) p);
                    }
                    else
                      goto label_39;
label_30:
                    List<\u003C\u003Ef__AnonymousType0<int, IMetadata>> list = properties.Select(selector).ToList();
                    // ISSUE: object of a compiler-generated type is created
                    list.AddRange(metadata1.TableParts.Select(tp => new \u003C\u003Ef__AnonymousType0<int, IMetadata>(tp.Order, (IMetadata) tp)));
                    list.Sort((po1, po2) => po1.Order.CompareTo(po2.Order));
                    num2 = 1;
                    enumerator2 = list.GetEnumerator();
                    num3 = 2;
                    continue;
label_39:
                    selector = func;
                    goto label_30;
                  case 2:
                    goto label_11;
                  case 3:
                    goto label_2;
                  case 4:
                    goto label_9;
                  default:
                    goto label_6;
                }
              }
label_11:
              try
              {
label_18:
                if (enumerator2.MoveNext())
                  goto label_22;
                else
                  goto label_19;
label_12:
                IMetadata metadata;
                int num4;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                    case 2:
                    case 5:
                      ++num2;
                      num4 = 8;
                      continue;
                    case 3:
                      if (!(metadata is TablePartMetadata tablePartMetadata))
                      {
                        num4 = 5;
                        continue;
                      }
                      goto case 6;
                    case 4:
                      goto label_9;
                    case 6:
                      PropertiesAndTablePartsOrderDbStructure.T5thIhfFV4Gdgp1gyKgM((object) tablePartMetadata, num2);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 1 : 1;
                      continue;
                    case 7:
                      PropertiesAndTablePartsOrderDbStructure.r1mtcffFISpDF3tuW3aM((object) propertyMetadata, num2);
                      num4 = 2;
                      continue;
                    case 8:
                      goto label_18;
                    case 9:
                      if (metadata is PropertyMetadata propertyMetadata)
                      {
                        num4 = 7;
                        continue;
                      }
                      goto case 3;
                    default:
                      goto label_22;
                  }
                }
label_19:
                num4 = 4;
                goto label_12;
label_22:
                metadata = enumerator2.Current.Metadata;
                num4 = 8;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0)
                {
                  num4 = 9;
                  goto label_12;
                }
                else
                  goto label_12;
              }
              finally
              {
                enumerator2.Dispose();
                int num5 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0)
                  num5 = 0;
                switch (num5)
                {
                  default:
                }
              }
label_6:
              if (enumerator1.Current.Metadata is EntityMetadata metadata1)
              {
                num3 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
                {
                  num3 = 1;
                  goto label_5;
                }
                else
                  goto label_5;
              }
              else
                goto label_9;
label_10:
              num3 = 3;
              goto label_5;
            }
            finally
            {
              if (enumerator1 != null)
              {
                int num6 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
                  num6 = 1;
                while (true)
                {
                  switch (num6)
                  {
                    case 1:
                      PropertiesAndTablePartsOrderDbStructure.OnUcygfFicdoOtqEDpew((object) enumerator1);
                      num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_37;
                  }
                }
              }
label_37:;
            }
          case 2:
            enumerator1 = draftItems.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 1 : 1;
            continue;
          case 3:
            draftItems = MetadataItemManager.Instance.FindDraftItems();
            num1 = 2;
            continue;
          case 4:
            goto label_35;
        }
label_2:
        ((MetadataItemManager) PropertiesAndTablePartsOrderDbStructure.rOk5rafFRI4YIPYbHD4q()).Save(draftItems);
        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 4 : 0;
      }
label_35:;
    }

    public PropertiesAndTablePartsOrderDbStructure()
    {
      PropertiesAndTablePartsOrderDbStructure.L7hJiHfFqNsxyumIFPjR();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void r1mtcffFISpDF3tuW3aM([In] object obj0, int value) => ((PropertyMetadata) obj0).Order = value;

    internal static void T5thIhfFV4Gdgp1gyKgM([In] object obj0, int value) => ((TablePartMetadata) obj0).Order = value;

    internal static bool RiVbyvfFSb0Id3YJTlL3([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void OnUcygfFicdoOtqEDpew([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object rOk5rafFRI4YIPYbHD4q() => (object) MetadataItemManager.Instance;

    internal static bool GvxoBjfFZVGKDYCA59Hp() => PropertiesAndTablePartsOrderDbStructure.qmtLhvfF8YL0nOMK3CgF == null;

    internal static PropertiesAndTablePartsOrderDbStructure mrNl3MfFuxUOTvVXhFJL() => PropertiesAndTablePartsOrderDbStructure.qmtLhvfF8YL0nOMK3CgF;

    internal static void L7hJiHfFqNsxyumIFPjR() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
