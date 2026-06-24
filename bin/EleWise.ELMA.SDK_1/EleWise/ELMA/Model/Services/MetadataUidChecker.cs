// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Services.MetadataUidChecker
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Services
{
  /// <summary>Проверка наличия уникального идентификатора в блоках</summary>
  [Service(Type = ComponentType.Server)]
  internal class MetadataUidChecker : IMetadataUidChecker
  {
    private static MetadataUidChecker F6Y0ryb8CQYmyMY0TaWL;

    /// <inheritdoc />
    public bool AddUidIfNeeded(IEnumerable<IMetadata> metadata)
    {
      bool flag = false;
      foreach (IMetadata metadata1 in metadata)
      {
        if (this.AddUidIfNeeded(metadata1))
          flag = true;
      }
      return flag;
    }

    /// <inheritdoc />
    public bool AddUidIfNeeded(IEnumerable<IMetadataItem> metadataItems)
    {
      bool flag = false;
      foreach (IMetadataItem metadataItem in metadataItems)
      {
        if (this.AddUidIfNeeded((IMetadata) (metadataItem.Metadata as AbstractMetadata)))
          flag = true;
      }
      return flag;
    }

    /// <inheritdoc />
    public bool AddUidIfNeeded(IMetadata metadata)
    {
      int num1 = 11;
      bool flag;
      List<TablePartMetadata>.Enumerator enumerator;
      while (true)
      {
        int num2 = num1;
        TablePartMetadata tablePartMetadata;
        EntityMetadata entityMetadata;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 5:
            case 7:
              entityMetadata = metadata as EntityMetadata;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 4 : 0;
              continue;
            case 2:
              if (tablePartMetadata == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 1 : 0;
                continue;
              }
              goto default;
            case 3:
              goto label_14;
            case 4:
              if (entityMetadata != null)
              {
                num2 = 8;
                continue;
              }
              goto label_3;
            case 6:
              flag = true;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 7 : 2;
              continue;
            case 8:
              enumerator = entityMetadata.TableParts.GetEnumerator();
              num2 = 3;
              continue;
            case 9:
              goto label_3;
            case 10:
              tablePartMetadata = metadata as TablePartMetadata;
              num2 = 2;
              continue;
            case 11:
              flag = false;
              num2 = 10;
              continue;
            case 12:
              MetadataUidChecker.KQYxuHb8ZlmDgDGv8Ikl((object) tablePartMetadata);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 6 : 6;
              continue;
            default:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              if (!tablePartMetadata.Properties.Any<PropertyMetadata>((Func<PropertyMetadata, bool>) (p1 => MetadataUidChecker.\u003C\u003Ec.tbod2OC2o60OAwad08b2(MetadataUidChecker.\u003C\u003Ec.JbA1knC2BoqE0IwvABRy((object) p1), MetadataUidChecker.\u003C\u003Ec.UujaJ4C2WWA8VaM2G8lu(-1487388570 ^ -1487392780)))))
                goto case 12;
              else
                goto label_28;
          }
        }
label_28:
        num1 = 5;
      }
label_3:
      return flag;
label_14:
      try
      {
label_21:
        if (enumerator.MoveNext())
          goto label_19;
        else
          goto label_22;
label_15:
        TablePartMetadata current;
        int num3;
        while (true)
        {
          switch (num3)
          {
            case 1:
              if (this.AddUidIfNeeded((IMetadata) current))
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 0 : 2;
                continue;
              }
              goto label_21;
            case 2:
              flag = true;
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 0 : 0;
              continue;
            case 3:
              goto label_19;
            case 4:
              goto label_3;
            default:
              goto label_21;
          }
        }
label_19:
        current = enumerator.Current;
        num3 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
        {
          num3 = 0;
          goto label_15;
        }
        else
          goto label_15;
label_22:
        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 3 : 4;
        goto label_15;
      }
      finally
      {
        enumerator.Dispose();
        int num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
          num4 = 0;
        switch (num4)
        {
          default:
        }
      }
    }

    public MetadataUidChecker()
    {
      MetadataUidChecker.Yyu6qhb8uf85qiTEnF0X();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object KQYxuHb8ZlmDgDGv8Ikl([In] object obj0) => (object) ((EntityMetadata) obj0).CreateUidProperty();

    internal static bool yrJ9d6b8vTW9CVqm3k0s() => MetadataUidChecker.F6Y0ryb8CQYmyMY0TaWL == null;

    internal static MetadataUidChecker HXMTLYb88ymowL5nxIHL() => MetadataUidChecker.F6Y0ryb8CQYmyMY0TaWL;

    internal static void Yyu6qhb8uf85qiTEnF0X() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
