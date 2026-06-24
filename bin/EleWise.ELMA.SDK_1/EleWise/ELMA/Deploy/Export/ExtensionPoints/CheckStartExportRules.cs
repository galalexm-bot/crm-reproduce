// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Export.ExtensionPoints.CheckStartExportRules
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Deploy.Export.ExtensionPoints
{
  /// <summary>
  /// Проверка наличия у ВСЕХ объектов (сущностей) системы правил исключения в соответствующем им менеджере
  /// </summary>
  [Component(Type = ComponentType.Server)]
  public class CheckStartExportRules : IInitHandler
  {
    internal static CheckStartExportRules EG8IUTEUBhKsMMHiWie2;

    private void GenerateForInterface()
    {
      int num1 = 4;
      FileInfo fileInfo;
      StreamWriter streamWriter1;
      int num2;
      IMetadataRuntimeService serviceNotNull;
      IEnumerator<EntityMetadata> enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            try
            {
label_58:
              if (enumerator.MoveNext())
                goto label_60;
              else
                goto label_59;
label_16:
              int num3;
              int num4 = num3;
label_17:
              EntityMetadata current;
              Type typeByUid1;
              string str;
              Guid uid;
              IEntityManager entityManager;
              Type typeByUid2;
              StreamWriter streamWriter2;
              while (true)
              {
                switch (num4)
                {
                  case 1:
                    goto label_58;
                  case 2:
                    streamWriter2 = (StreamWriter) CheckStartExportRules.wmGUU4EUCZyLQPQKsCYP((object) fileInfo);
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 8 : 11;
                    continue;
                  case 3:
                    entityManager = (IEntityManager) CheckStartExportRules.yjY9iCEUQNafFQcBHV0P(typeByUid1);
                    num4 = 4;
                    continue;
                  case 4:
                    ++num2;
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 2 : 1;
                    continue;
                  case 5:
                    if (current.IsSystem())
                    {
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 0;
                      continue;
                    }
                    goto label_58;
                  case 6:
                    typeByUid2 = serviceNotNull.GetTypeByUid(current.ImplementationUid);
                    num4 = 10;
                    continue;
                  case 7:
                    goto label_60;
                  case 8:
                    typeByUid1 = serviceNotNull.GetTypeByUid(uid, false);
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 6 : 6;
                    continue;
                  case 9:
                    goto label_2;
                  case 10:
                    str = (string) CheckStartExportRules.MLaEIWEUf4cEw8jsex0O((object) typeByUid1.Assembly);
                    num4 = 3;
                    continue;
                  case 11:
                    goto label_28;
                  case 12:
                    goto label_19;
                  default:
                    uid = CheckStartExportRules.m0nWokEUEWiAWN4FR1fV((object) current);
                    num4 = 8;
                    continue;
                }
              }
label_19:
              if (CheckStartExportRules.G8ph3jEUGkDkZInVJ0ZI((object) current) == EntityMetadataType.Interface)
              {
                num3 = 5;
                goto label_16;
              }
              else
                goto label_58;
label_28:
              try
              {
                CheckStartExportRules.MF0DUDEUZTEmMm6NYZCE((object) streamWriter2, (object) ((string) CheckStartExportRules.NrkVMaEUvx2feqv2XBFP(-1350312861 << 3 ^ 2082203582) + (string) CheckStartExportRules.no64IIEU8fgm5lZkB8fu((object) current)));
                int num5 = 2;
                PropertyMetadata[] array;
                int num6;
                PropertyMetadata propertyMetadata;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                    case 11:
                      propertyMetadata = array[num6 - 1];
                      num5 = 16;
                      continue;
                    case 2:
                      CheckStartExportRules.MF0DUDEUZTEmMm6NYZCE((object) streamWriter2, CheckStartExportRules.ncF3RTEUupkmFKnZIqRP((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(694673736 ^ -23604109 ^ -671796751), (object) str));
                      num5 = 6;
                      continue;
                    case 3:
                      CheckStartExportRules.MF0DUDEUZTEmMm6NYZCE((object) streamWriter2, CheckStartExportRules.NrkVMaEUvx2feqv2XBFP(1242972401 >> 4 ^ 77882181));
                      num5 = 22;
                      continue;
                    case 4:
                      CheckStartExportRules.rJDNeuEUqRlRIrA1CtyP((object) streamWriter2);
                      num5 = 8;
                      continue;
                    case 5:
                      array = current.Properties.OrderBy<PropertyMetadata, string>((Func<PropertyMetadata, string>) (m => m.Name)).ToArray<PropertyMetadata>();
                      num5 = 17;
                      continue;
                    case 6:
                      if (entityManager == null)
                      {
                        num5 = 19;
                        continue;
                      }
                      goto case 18;
                    case 7:
                    case 19:
                      CheckStartExportRules.MF0DUDEUZTEmMm6NYZCE((object) streamWriter2, CheckStartExportRules.Tt0falEUI9QepKTNClkE(CheckStartExportRules.NrkVMaEUvx2feqv2XBFP(1917256330 ^ 1916929944), (object) typeByUid2));
                      num5 = 10;
                      continue;
                    case 8:
                      goto label_58;
                    case 9:
                      CheckStartExportRules.MF0DUDEUZTEmMm6NYZCE((object) streamWriter2, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~1767720452 ^ -1767391305));
                      num5 = 5;
                      continue;
                    case 10:
                      CheckStartExportRules.MF0DUDEUZTEmMm6NYZCE((object) streamWriter2, CheckStartExportRules.NrkVMaEUvx2feqv2XBFP(1242972401 >> 4 ^ 77881657));
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 21 : 15;
                      continue;
                    case 12:
                    case 20:
                      if (num6 <= ((IEnumerable<PropertyMetadata>) array).Count<PropertyMetadata>())
                      {
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 1 : 1;
                        continue;
                      }
                      goto case 3;
                    case 13:
                      CheckStartExportRules.MF0DUDEUZTEmMm6NYZCE((object) streamWriter2, CheckStartExportRules.NrkVMaEUvx2feqv2XBFP(~538519529 ^ -538520570));
                      num5 = 4;
                      continue;
                    case 14:
                      streamWriter2.WriteLine((string) CheckStartExportRules.NrkVMaEUvx2feqv2XBFP(-688192331 - 435440695 ^ -1123828098));
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 3 : 9;
                      continue;
                    case 15:
                      CheckStartExportRules.MF0DUDEUZTEmMm6NYZCE((object) streamWriter2, CheckStartExportRules.HjmMTjEUVwIdTbSG9IrT(CheckStartExportRules.NrkVMaEUvx2feqv2XBFP(~541731958 ^ -542058981), (object) typeByUid1.FullName, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1598106783 - -968262081 ^ -630173482)));
                      num5 = 14;
                      continue;
                    case 16:
                      CheckStartExportRules.MF0DUDEUZTEmMm6NYZCE((object) streamWriter2, (object) ((string) CheckStartExportRules.NrkVMaEUvx2feqv2XBFP(-1487388570 ^ -1487059396) + (string) CheckStartExportRules.xy9tYQEURwGLce1FcvgI(CheckStartExportRules.NrkVMaEUvx2feqv2XBFP(-35995181 ^ -35666105), !CheckStartExportRules.bqxfMOEUigsl2x9e66WG(CheckStartExportRules.vub1TuEUSs6R0fJoRBgE((object) current), Guid.Empty) ? (object) serviceNotNull.GetTypeByUid(CheckStartExportRules.vub1TuEUSs6R0fJoRBgE((object) current)).Name : (object) "", CheckStartExportRules.no64IIEU8fgm5lZkB8fu((object) propertyMetadata)) + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97773804) + (num6 == ((IEnumerable<PropertyMetadata>) array).Count<PropertyMetadata>() ? "" : (string) CheckStartExportRules.NrkVMaEUvx2feqv2XBFP(-740338220 ^ -740358364))));
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 0 : 0;
                      continue;
                    case 17:
                      num6 = 1;
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 20 : 11;
                      continue;
                    case 18:
                      CheckStartExportRules.MF0DUDEUZTEmMm6NYZCE((object) streamWriter2, CheckStartExportRules.Tt0falEUI9QepKTNClkE(CheckStartExportRules.NrkVMaEUvx2feqv2XBFP(1470998129 - 231418599 ^ 1239908196), (object) entityManager));
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 7 : 2;
                      continue;
                    case 21:
                      streamWriter2.WriteLine((string) CheckStartExportRules.NrkVMaEUvx2feqv2XBFP(1142330761 ^ 1541959139 ^ 536802198));
                      num5 = 15;
                      continue;
                    case 22:
                      streamWriter2.WriteLine(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1033719030 - 2012070891 ^ -978678191));
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 3 : 13;
                      continue;
                    default:
                      ++num6;
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 12 : 2;
                      continue;
                  }
                }
              }
              finally
              {
                if (streamWriter2 != null)
                {
                  int num7 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
                    num7 = 0;
                  while (true)
                  {
                    switch (num7)
                    {
                      case 1:
                        goto label_56;
                      default:
                        streamWriter2.Dispose();
                        num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 1;
                        continue;
                    }
                  }
                }
label_56:;
              }
label_59:
              num4 = 9;
              goto label_17;
label_60:
              current = enumerator.Current;
              num3 = 12;
              goto label_16;
            }
            finally
            {
              if (enumerator != null)
              {
                int num8 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0)
                  num8 = 0;
                while (true)
                {
                  switch (num8)
                  {
                    case 1:
                      goto label_68;
                    default:
                      CheckStartExportRules.BXYOC6EUKxO1ORS8FgUQ((object) enumerator);
                      num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 1 : 0;
                      continue;
                  }
                }
              }
label_68:;
            }
          case 2:
label_2:
            streamWriter1 = fileInfo.AppendText();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 0;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated method
            IOrderedEnumerable<EntityMetadata> orderedEnumerable = ((IMetadataService) CheckStartExportRules.NsJoIaEUh3FLPu0HwSmb()).GetMetadataList().OfType<EntityMetadata>().Where<EntityMetadata>((Func<EntityMetadata, bool>) (m => CheckStartExportRules.\u003C\u003Ec.kbjQYs80Ju79VNVYMmvj((object) m) == EntityMetadataType.Interface)).OrderBy<EntityMetadata, string>((Func<EntityMetadata, string>) (md => md.Name));
            num2 = 0;
            serviceNotNull = Locator.GetServiceNotNull<IMetadataRuntimeService>();
            enumerator = orderedEnumerable.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 1 : 1;
            continue;
          case 4:
            fileInfo = new FileInfo((string) CheckStartExportRules.TFYsFZEUbTDCT2YO6kRa());
            num1 = 3;
            continue;
          case 5:
            goto label_66;
          default:
            goto label_3;
        }
      }
label_66:
      return;
label_3:
      try
      {
        CheckStartExportRules.rJDNeuEUqRlRIrA1CtyP((object) streamWriter1);
        int num9 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
          num9 = 0;
        while (true)
        {
          switch (num9)
          {
            case 1:
              goto label_61;
            default:
              CheckStartExportRules.NtBfDwEUXSwnlm7KR01W((object) streamWriter1, num2);
              num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 1;
              continue;
          }
        }
label_61:;
      }
      finally
      {
        int num10;
        if (streamWriter1 == null)
          num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 0 : 0;
        else
          goto label_11;
label_10:
        switch (num10)
        {
          case 1:
            break;
          default:
        }
label_11:
        streamWriter1.Dispose();
        num10 = 2;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
        {
          num10 = 0;
          goto label_10;
        }
        else
          goto label_10;
      }
    }

    private void GenerateForEntity()
    {
      int num1 = 6;
      IEnumerator<EntityMetadata> enumerator;
      IEnumerable<IStartExportRulesIgnore> extensionPoints;
      IMetadataRuntimeService serviceNotNull;
      int num2;
      FileInfo fileInfo;
      StreamWriter streamWriter1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            try
            {
label_4:
              if (CheckStartExportRules.rceMaBEUnyM60aHQl7MK((object) enumerator))
                goto label_50;
              else
                goto label_5;
label_3:
              Type typeByUid;
              Type type;
              bool flag;
              StreamWriter streamWriter2;
              IEntityManager entityManager;
              string str;
              Guid uid;
              int num3;
              EntityMetadata md;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    if (!CheckStartExportRules.boGs6xEUTW3oP66XuPqg((object) md))
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 7 : 4;
                      continue;
                    }
                    goto case 14;
                  case 2:
                    goto label_10;
                  case 3:
                  case 7:
                  case 12:
                    goto label_4;
                  case 4:
                    uid = CheckStartExportRules.m0nWokEUEWiAWN4FR1fV((object) md);
                    num3 = 11;
                    continue;
                  case 5:
                    // ISSUE: reference to a compiler-generated method
                    flag = extensionPoints.Any<IStartExportRulesIgnore>((Func<IStartExportRulesIgnore, bool>) (p => CheckStartExportRules.\u003C\u003Ec__DisplayClass1_0.XmmI3G805j3MHDcsRcEq((object) p, (object) md)));
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 1 : 1;
                    continue;
                  case 6:
                    streamWriter2 = (StreamWriter) CheckStartExportRules.wmGUU4EUCZyLQPQKsCYP((object) fileInfo);
                    num3 = 2;
                    continue;
                  case 8:
                    goto label_63;
                  case 9:
                    md = enumerator.Current;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 5 : 3;
                    continue;
                  case 10:
                    ++num2;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 6 : 6;
                    continue;
                  case 11:
                    typeByUid = serviceNotNull.GetTypeByUid(uid, false);
                    num3 = 15;
                    continue;
                  case 13:
                    entityManager = (IEntityManager) CheckStartExportRules.yjY9iCEUQNafFQcBHV0P(typeByUid);
                    num3 = 10;
                    continue;
                  case 14:
                    if (flag)
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 12 : 0;
                      continue;
                    }
                    goto case 4;
                  case 15:
                    type = typeByUid;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 14 : 16;
                    continue;
                  case 16:
                    str = (string) CheckStartExportRules.MLaEIWEUf4cEw8jsex0O((object) typeByUid.Assembly);
                    num3 = 13;
                    continue;
                  default:
                    goto label_50;
                }
              }
label_10:
              try
              {
                CheckStartExportRules.MF0DUDEUZTEmMm6NYZCE((object) streamWriter2, CheckStartExportRules.ncF3RTEUupkmFKnZIqRP(CheckStartExportRules.NrkVMaEUvx2feqv2XBFP(1142330761 ^ 1541959139 ^ 536607948), CheckStartExportRules.no64IIEU8fgm5lZkB8fu((object) md)));
                int num4 = 10;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
                  num4 = 7;
                while (true)
                {
                  int num5;
                  int num6;
                  PropertyMetadata[] array;
                  PropertyMetadata propertyMetadata;
                  switch (num4)
                  {
                    case 1:
                      CheckStartExportRules.rJDNeuEUqRlRIrA1CtyP((object) streamWriter2);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 13 : 15;
                      continue;
                    case 2:
                      CheckStartExportRules.MF0DUDEUZTEmMm6NYZCE((object) streamWriter2, CheckStartExportRules.NrkVMaEUvx2feqv2XBFP(-1334993905 ^ -1335321771));
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 19 : 0;
                      continue;
                    case 3:
                      streamWriter2.WriteLine((string) CheckStartExportRules.Tt0falEUI9QepKTNClkE(CheckStartExportRules.NrkVMaEUvx2feqv2XBFP(-787452571 ^ -787125877), (object) entityManager));
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 6 : 5;
                      continue;
                    case 4:
                      CheckStartExportRules.MF0DUDEUZTEmMm6NYZCE((object) streamWriter2, CheckStartExportRules.NrkVMaEUvx2feqv2XBFP(1304605005 ^ 1304607409));
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 8 : 11;
                      continue;
                    case 5:
                      CheckStartExportRules.MF0DUDEUZTEmMm6NYZCE((object) streamWriter2, CheckStartExportRules.NrkVMaEUvx2feqv2XBFP(236071375 ^ 236400261));
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 2 : 2;
                      continue;
                    case 6:
                    case 17:
                      CheckStartExportRules.MF0DUDEUZTEmMm6NYZCE((object) streamWriter2, CheckStartExportRules.Tt0falEUI9QepKTNClkE((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978149408), (object) type));
                      num4 = 8;
                      continue;
                    case 7:
                      List<PropertyMetadata> properties = md.Properties;
                      // ISSUE: reference to a compiler-generated field
                      Func<PropertyMetadata, string> func = CheckStartExportRules.\u003C\u003Ec.\u003C\u003E9__1_3;
                      Func<PropertyMetadata, string> keySelector;
                      if (func == null)
                      {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated method
                        CheckStartExportRules.\u003C\u003Ec.\u003C\u003E9__1_3 = keySelector = (Func<PropertyMetadata, string>) (m => (string) CheckStartExportRules.\u003C\u003Ec.bNKmqM809X8YZJX0083K((object) m));
                      }
                      else
                        goto label_83;
label_35:
                      array = properties.OrderBy<PropertyMetadata, string>(keySelector).ToArray<PropertyMetadata>();
                      num4 = 18;
                      continue;
label_83:
                      keySelector = func;
                      goto label_35;
                    case 8:
                      CheckStartExportRules.MF0DUDEUZTEmMm6NYZCE((object) streamWriter2, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138630450));
                      num4 = 4;
                      continue;
                    case 9:
                    case 20:
                      if (num6 > ((IEnumerable<PropertyMetadata>) array).Count<PropertyMetadata>())
                      {
                        num4 = 5;
                        continue;
                      }
                      goto default;
                    case 10:
                      CheckStartExportRules.MF0DUDEUZTEmMm6NYZCE((object) streamWriter2, (object) ((string) CheckStartExportRules.NrkVMaEUvx2feqv2XBFP(-420743386 ^ -420547604) + str));
                      num4 = 12;
                      continue;
                    case 11:
                      CheckStartExportRules.MF0DUDEUZTEmMm6NYZCE((object) streamWriter2, (object) ((string) CheckStartExportRules.NrkVMaEUvx2feqv2XBFP(-1852837372 ^ -1853163626) + typeByUid.FullName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1839087379 - 334718690 ^ 2120966143)));
                      num4 = 14;
                      continue;
                    case 12:
                      if (entityManager == null)
                      {
                        num4 = 17;
                        continue;
                      }
                      goto case 3;
                    case 13:
                      CheckStartExportRules.MF0DUDEUZTEmMm6NYZCE((object) streamWriter2, (object) (z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978149208) + (string) CheckStartExportRules.xy9tYQEURwGLce1FcvgI(CheckStartExportRules.NrkVMaEUvx2feqv2XBFP(-281842504 ^ -281646548), !CheckStartExportRules.bqxfMOEUigsl2x9e66WG(CheckStartExportRules.vub1TuEUSs6R0fJoRBgE((object) md), Guid.Empty) ? CheckStartExportRules.r7a4PIEUkNCTKaUordC8((object) serviceNotNull.GetTypeByUid(CheckStartExportRules.vub1TuEUSs6R0fJoRBgE((object) md))) : (object) "", CheckStartExportRules.no64IIEU8fgm5lZkB8fu((object) propertyMetadata)) + (string) CheckStartExportRules.NrkVMaEUvx2feqv2XBFP(-1939377524 ^ -1939704370) + (num6 == ((IEnumerable<PropertyMetadata>) array).Count<PropertyMetadata>() ? "" : (string) CheckStartExportRules.NrkVMaEUvx2feqv2XBFP(-1255365154 ^ 596875508 ^ -1765838886))));
                      num5 = 16;
                      break;
                    case 14:
                      CheckStartExportRules.MF0DUDEUZTEmMm6NYZCE((object) streamWriter2, CheckStartExportRules.NrkVMaEUvx2feqv2XBFP(~210725948 ^ -210397757));
                      num4 = 21;
                      continue;
                    case 15:
                      goto label_4;
                    case 16:
                      ++num6;
                      num5 = 20;
                      break;
                    case 18:
                      num6 = 1;
                      num4 = 9;
                      continue;
                    case 19:
                      CheckStartExportRules.MF0DUDEUZTEmMm6NYZCE((object) streamWriter2, CheckStartExportRules.NrkVMaEUvx2feqv2XBFP(~289714581 ^ -289717638));
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 1 : 1;
                      continue;
                    case 21:
                      streamWriter2.WriteLine((string) CheckStartExportRules.NrkVMaEUvx2feqv2XBFP(-1839087379 - 334718690 ^ 2120965191));
                      num4 = 7;
                      continue;
                    default:
                      propertyMetadata = array[num6 - 1];
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 13 : 13;
                      continue;
                  }
                  num4 = num5;
                }
              }
              finally
              {
                int num7;
                if (streamWriter2 == null)
                  num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 2 : 0;
                else
                  goto label_40;
label_39:
                switch (num7)
                {
                  case 1:
                    break;
                  default:
                }
label_40:
                streamWriter2.Dispose();
                num7 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0)
                {
                  num7 = 0;
                  goto label_39;
                }
                else
                  goto label_39;
              }
label_5:
              num3 = 8;
              goto label_3;
label_50:
              num3 = 9;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
              {
                num3 = 2;
                goto label_3;
              }
              else
                goto label_3;
            }
            finally
            {
              int num8;
              if (enumerator == null)
                num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 0 : 0;
              else
                goto label_57;
label_56:
              switch (num8)
              {
                case 1:
                  break;
                default:
              }
label_57:
              enumerator.Dispose();
              num8 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
              {
                num8 = 2;
                goto label_56;
              }
              else
                goto label_56;
            }
          case 2:
            goto label_80;
          case 3:
label_63:
            streamWriter1 = fileInfo.AppendText();
            num1 = 4;
            continue;
          case 4:
            goto label_64;
          case 5:
            extensionPoints = ComponentManager.Current.GetExtensionPoints<IStartExportRulesIgnore>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
            continue;
          case 6:
            fileInfo = new FileInfo((string) CheckStartExportRules.TFYsFZEUbTDCT2YO6kRa());
            num1 = 5;
            continue;
          default:
            IEnumerable<EntityMetadata> source1 = ((IMetadataService) CheckStartExportRules.NsJoIaEUh3FLPu0HwSmb()).GetMetadataList().OfType<EntityMetadata>();
            // ISSUE: reference to a compiler-generated field
            Func<EntityMetadata, bool> func1 = CheckStartExportRules.\u003C\u003Ec.\u003C\u003E9__1_0;
            Func<EntityMetadata, bool> predicate;
            if (func1 == null)
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              CheckStartExportRules.\u003C\u003Ec.\u003C\u003E9__1_0 = predicate = (Func<EntityMetadata, bool>) (m => CheckStartExportRules.\u003C\u003Ec.kbjQYs80Ju79VNVYMmvj((object) m) == EntityMetadataType.Entity);
            }
            else
              goto label_59;
label_79:
            IEnumerable<EntityMetadata> source2 = source1.Where<EntityMetadata>(predicate);
            // ISSUE: reference to a compiler-generated field
            Func<EntityMetadata, string> func2 = CheckStartExportRules.\u003C\u003Ec.\u003C\u003E9__1_1;
            Func<EntityMetadata, string> keySelector1;
            if (func2 == null)
            {
              // ISSUE: reference to a compiler-generated field
              CheckStartExportRules.\u003C\u003Ec.\u003C\u003E9__1_1 = keySelector1 = (Func<EntityMetadata, string>) (md => md.Name);
            }
            else
              goto label_67;
label_82:
            IOrderedEnumerable<EntityMetadata> orderedEnumerable = source2.OrderBy<EntityMetadata, string>(keySelector1);
            num2 = 0;
            serviceNotNull = Locator.GetServiceNotNull<IMetadataRuntimeService>();
            enumerator = orderedEnumerable.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 1;
            continue;
label_67:
            keySelector1 = func2;
            goto label_82;
label_59:
            predicate = func1;
            goto label_79;
        }
      }
label_80:
      return;
label_64:
      try
      {
        CheckStartExportRules.rJDNeuEUqRlRIrA1CtyP((object) streamWriter1);
        int num9 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
          num9 = 1;
        while (true)
        {
          switch (num9)
          {
            case 0:
              goto label_77;
            case 1:
              CheckStartExportRules.NtBfDwEUXSwnlm7KR01W((object) streamWriter1, num2);
              num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 0 : 0;
              continue;
            default:
              goto label_73;
          }
        }
label_77:
        return;
label_73:;
      }
      finally
      {
        if (streamWriter1 != null)
        {
          int num10 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
            num10 = 1;
          while (true)
          {
            switch (num10)
            {
              case 1:
                streamWriter1.Dispose();
                num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 0;
                continue;
              default:
                goto label_75;
            }
          }
        }
label_75:;
      }
    }

    /// <summary>
    /// Генерирует в темповской папке файл с кодом переопределенных методов получения списка правил экспорта сущностей
    /// </summary>
    /// 
    ///             tuev: НЕ УДАЛЯТЬ. Если удалить очень хочется, то спросить сначала меня, зачем это
    private void GenerateCodeExportRuleList()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.GenerateForEntity();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 0 : 0;
            continue;
          case 2:
            this.GenerateForInterface();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    /// <summary>
    /// Проверка наличия правил экспорта-импорта у всех свойств всех сущностей
    /// </summary>
    private void CheckExportRuleList()
    {
      switch (1)
      {
        case 1:
          try
          {
            IMetadataRuntimeService serviceNotNull = Locator.GetServiceNotNull<IMetadataRuntimeService>();
            int num1 = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
              num1 = 1;
            IEnumerator<EntityMetadata> enumerator1;
            while (true)
            {
              switch (num1)
              {
                case 0:
                  goto label_34;
                case 1:
                  // ISSUE: reference to a compiler-generated method
                  enumerator1 = ((IMetadataService) CheckStartExportRules.NsJoIaEUh3FLPu0HwSmb()).GetMetadataList().OfType<EntityMetadata>().Where<EntityMetadata>((Func<EntityMetadata, bool>) (m => CheckStartExportRules.\u003C\u003Ec.kbjQYs80Ju79VNVYMmvj((object) m) == EntityMetadataType.Interface)).OrderBy<EntityMetadata, string>((Func<EntityMetadata, string>) (md => md.Name)).GetEnumerator();
                  num1 = 2;
                  continue;
                case 2:
                  goto label_4;
                default:
                  goto label_29;
              }
            }
label_34:
            break;
label_29:
            break;
label_4:
            try
            {
label_24:
              if (enumerator1.MoveNext())
                goto label_27;
              else
                goto label_25;
label_5:
              EntityMetadata current;
              List<PropertyMetadata>.Enumerator enumerator2;
              // ISSUE: variable of a compiler-generated type
              CheckStartExportRules.\u003C\u003Ec__DisplayClass3_0 cDisplayClass30;
              ExportRuleList source;
              Guid uid;
              int num2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    // ISSUE: object of a compiler-generated type is created
                    cDisplayClass30 = new CheckStartExportRules.\u003C\u003Ec__DisplayClass3_0();
                    num2 = 3;
                    continue;
                  case 2:
                    goto label_24;
                  case 3:
                    uid = current.Uid;
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 3 : 5;
                    continue;
                  case 4:
                    goto label_6;
                  case 5:
                    Type typeByUid = serviceNotNull.GetTypeByUid(uid, false);
                    // ISSUE: reference to a compiler-generated field
                    cDisplayClass30.typeMdImpl = serviceNotNull.GetTypeByUid(CheckStartExportRules.vub1TuEUSs6R0fJoRBgE((object) current));
                    source = ((IEntityManager) CheckStartExportRules.yjY9iCEUQNafFQcBHV0P(typeByUid)).ExportRules();
                    num2 = 6;
                    continue;
                  case 6:
                    enumerator2 = current.Properties.GetEnumerator();
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 4 : 3;
                    continue;
                  case 7:
                    goto label_19;
                  default:
                    goto label_27;
                }
              }
label_19:
              break;
label_6:
              try
              {
label_9:
                if (enumerator2.MoveNext())
                  goto label_15;
                else
                  goto label_10;
label_7:
                // ISSUE: variable of a compiler-generated type
                CheckStartExportRules.\u003C\u003Ec__DisplayClass3_1 cDisplayClass31;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      // ISSUE: reference to a compiler-generated field
                      cDisplayClass31.property = enumerator2.Current;
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 0 : 0;
                      continue;
                    case 2:
                      goto label_24;
                    case 3:
                      // ISSUE: reference to a compiler-generated field
                      cDisplayClass31.CS\u0024\u003C\u003E8__locals1 = cDisplayClass30;
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 1 : 1;
                      continue;
                    case 4:
                      goto label_15;
                    case 5:
                      goto label_8;
                    default:
                      // ISSUE: reference to a compiler-generated method
                      if (!source.Any<ExportRule>(new Func<ExportRule, bool>(cDisplayClass31.\u003CCheckExportRuleList\u003Eb__2)))
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 5 : 1;
                        continue;
                      }
                      goto label_9;
                  }
                }
label_8:
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                throw new Exception(EleWise.ELMA.SR.T((string) CheckStartExportRules.NrkVMaEUvx2feqv2XBFP(-1598106783 - -968262081 ^ -630173022), CheckStartExportRules.ATT0BqEUOPNbSuQYMsIZ((object) cDisplayClass31.property), CheckStartExportRules.no64IIEU8fgm5lZkB8fu((object) cDisplayClass31.property), CheckStartExportRules.ATT0BqEUOPNbSuQYMsIZ((object) current), CheckStartExportRules.no64IIEU8fgm5lZkB8fu((object) current)));
label_10:
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 2 : 1;
                goto label_7;
label_15:
                // ISSUE: object of a compiler-generated type is created
                cDisplayClass31 = new CheckStartExportRules.\u003C\u003Ec__DisplayClass3_1();
                num3 = 3;
                goto label_7;
              }
              finally
              {
                enumerator2.Dispose();
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
                  num4 = 0;
                switch (num4)
                {
                  default:
                }
              }
label_25:
              num2 = 7;
              goto label_5;
label_27:
              current = enumerator1.Current;
              num2 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
              {
                num2 = 1;
                goto label_5;
              }
              else
                goto label_5;
            }
            finally
            {
              if (enumerator1 != null)
              {
                int num5 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
                  num5 = 1;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      enumerator1.Dispose();
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_36;
                  }
                }
              }
label_36:;
            }
          }
          catch (Exception ex)
          {
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
              num = 0;
            while (true)
            {
              switch (num)
              {
                case 1:
                  goto label_44;
                default:
                  CheckStartExportRules.kBQ1VbEUehAy82csmYZU(CheckStartExportRules.dd7JZNEU2Lf5ej18vaX3(), (object) ex);
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 0 : 1;
                  continue;
              }
            }
label_44:
            throw new Exception((string) CheckStartExportRules.B7caL6EUP4V0LtpOoDej((object) ex));
          }
      }
    }

    public void Init()
    {
    }

    /// <summary>Вызов исполняемых методов при старте системы</summary>
    /// 
    ///             tuev: НЕ УДАЛЯТЬ. Если удалить очень хочется, то спросить сначала меня, зачем это
    public void InitComplete()
    {
    }

    public CheckStartExportRules()
    {
      CheckStartExportRules.M38hLcEU11Zs8YgqITM7();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object TFYsFZEUbTDCT2YO6kRa() => (object) IOExtensions.GetTempFileName();

    internal static object NsJoIaEUh3FLPu0HwSmb() => (object) MetadataServiceContext.Service;

    internal static EntityMetadataType G8ph3jEUGkDkZInVJ0ZI([In] object obj0) => ((EntityMetadata) obj0).Type;

    internal static Guid m0nWokEUEWiAWN4FR1fV([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static object MLaEIWEUf4cEw8jsex0O([In] object obj0) => (object) ComponentManager.GetAssemblyShortName((Assembly) obj0);

    internal static object yjY9iCEUQNafFQcBHV0P(Type entityType) => (object) ModelHelper.GetEntityManagerOrNull(entityType);

    internal static object wmGUU4EUCZyLQPQKsCYP([In] object obj0) => (object) ((FileInfo) obj0).AppendText();

    internal static object NrkVMaEUvx2feqv2XBFP(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object no64IIEU8fgm5lZkB8fu([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static void MF0DUDEUZTEmMm6NYZCE([In] object obj0, [In] object obj1) => ((TextWriter) obj0).WriteLine((string) obj1);

    internal static object ncF3RTEUupkmFKnZIqRP([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static object Tt0falEUI9QepKTNClkE([In] object obj0, [In] object obj1) => (object) (obj0.ToString() + obj1);

    internal static object HjmMTjEUVwIdTbSG9IrT([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static Guid vub1TuEUSs6R0fJoRBgE([In] object obj0) => ((EntityMetadata) obj0).ImplementationUid;

    internal static bool bqxfMOEUigsl2x9e66WG([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static object xy9tYQEURwGLce1FcvgI([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static void rJDNeuEUqRlRIrA1CtyP([In] object obj0) => ((TextWriter) obj0).WriteLine();

    internal static void BXYOC6EUKxO1ORS8FgUQ([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static void NtBfDwEUXSwnlm7KR01W([In] object obj0, [In] int obj1) => ((TextWriter) obj0).WriteLine(obj1);

    internal static bool uQtIEBEUWD79yGgw5B5K() => CheckStartExportRules.EG8IUTEUBhKsMMHiWie2 == null;

    internal static CheckStartExportRules cimO34EUor85BxNSS57j() => CheckStartExportRules.EG8IUTEUBhKsMMHiWie2;

    internal static bool boGs6xEUTW3oP66XuPqg([In] object obj0) => ((EntityMetadata) obj0).IsUnique;

    internal static object r7a4PIEUkNCTKaUordC8([In] object obj0) => (object) ((MemberInfo) obj0).Name;

    internal static bool rceMaBEUnyM60aHQl7MK([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static object ATT0BqEUOPNbSuQYMsIZ([In] object obj0) => (object) ((NamedMetadata) obj0).DisplayName;

    internal static object dd7JZNEU2Lf5ej18vaX3() => (object) Logger.Log;

    internal static void kBQ1VbEUehAy82csmYZU([In] object obj0, [In] object obj1) => ((ILogger) obj0).Error(obj1);

    internal static object B7caL6EUP4V0LtpOoDej([In] object obj0) => (object) ((Exception) obj0).Message;

    internal static void M38hLcEU11Zs8YgqITM7() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
