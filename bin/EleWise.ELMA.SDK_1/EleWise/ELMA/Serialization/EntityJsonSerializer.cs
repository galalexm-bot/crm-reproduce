// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Serialization.EntityJsonSerializer
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Diagnostics;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using Iesi.Collections;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Web.Script.Serialization;

namespace EleWise.ELMA.Serialization
{
  /// <summary>
  /// Сериализатор сущностей в Json или в словарь строка-объект
  /// </summary>
  public class EntityJsonSerializer
  {
    private static readonly Type OwnerType;
    private static readonly MethodInfo ConvertToSerializableCall;
    private static readonly MethodInfo ConvertFromSerializableCall;
    /// <summary>Название поля для хранения настроек</summary>
    public const string SettingsFieldName = "__settings";
    private static readonly string IdPropertyName;
    private static EntityJsonSerializer WgwoIsBreZxYoYOUmtth;

    /// <summary>Сконвертировать сущность в сериализованный объект</summary>
    /// <param name="obj">Сущность или объект</param>
    /// <returns>Сериализуемый объект</returns>
    public object ConvertToSerializable(object obj) => this.ConvertToSerializable(obj, (EntitySerializationSettings) null);

    /// <summary>Сконвертировать сущность в сериализованный объект</summary>
    /// <param name="obj">Сущность или объект</param>
    /// <param name="settings">Настройки</param>
    /// <returns>Сериализуемый объект</returns>
    public object ConvertToSerializable(object obj, EntitySerializationSettings settings)
    {
      int num = 2;
      ClassMetadata metadata;
      while (true)
      {
        switch (num)
        {
          case 1:
            metadata = MetadataLoader.LoadMetadata(EntityJsonSerializer.ELM1vCBrpJqE1h8INrAs(obj).GetType()) as ClassMetadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 0 : 0;
            continue;
          case 2:
            EntityJsonSerializer.dtAtYPBr37LMjfr30FIk(obj, EntityJsonSerializer.CV43EWBrNKSDAZ8S6FRi(92412609 - 1050237057 ^ -957849144));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 1 : 1;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return this.ConvertToSerializable(obj, metadata, settings);
    }

    internal object ConvertToSerializable(
      object obj,
      ClassMetadata metadata,
      EntitySerializationSettings settings)
    {
      int num1 = 3;
      MethodCallInfo methodCallInfo;
      object obj1;
      EntitySerializationSettings settings1;
      ClassMetadata metadata1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            settings1 = settings;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 0 : 0;
            continue;
          case 2:
            obj1 = obj;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 1 : 1;
            continue;
          case 3:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 1 : 2;
            continue;
          case 4:
            goto label_2;
          case 5:
            EntityJsonSerializer.dtAtYPBr37LMjfr30FIk((object) metadata1, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1939377524 ^ -1939391566));
            num1 = 8;
            continue;
          case 6:
            goto label_243;
          case 7:
            EntityJsonSerializer.dtAtYPBr37LMjfr30FIk(obj1, EntityJsonSerializer.CV43EWBrNKSDAZ8S6FRi(~-122002947 ^ 121978250));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 1 : 5;
            continue;
          case 8:
            methodCallInfo = DiagnosticsManager.StartCall<MethodCallInfo>((Func<MethodCallInfo>) (() => new MethodCallInfo(EntityJsonSerializer.OwnerType, EntityJsonSerializer.ConvertToSerializableCall, new object[2]
            {
              obj1,
              (object) settings1
            })));
            num1 = 4;
            continue;
          default:
            metadata1 = metadata;
            num1 = 7;
            continue;
        }
      }
label_2:
      object serializable1;
      try
      {
        SerializableDictionary<string, object> serializableDictionary = new SerializableDictionary<string, object>();
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
          num2 = 0;
        while (true)
        {
          switch (num2)
          {
            case 1:
label_230:
              serializable1 = (object) serializableDictionary;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 2 : 0;
              continue;
            case 2:
              goto label_243;
            default:
              try
              {
                int num3;
                if (settings1 == null)
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 3 : 3;
                else
                  goto label_220;
label_8:
                bool flag1;
                IDisposable disposable1;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_230;
                    case 2:
                      goto label_10;
                    case 3:
                      goto label_221;
                    case 4:
                      disposable1 = (IDisposable) EntityJsonSerializer.tBVp43BrtBxyxSSMQkj0(EntityJsonSerializer.xWVskSBrDKR1fTolQB4W() != null | flag1);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 2 : 2;
                      continue;
                    default:
                      goto label_220;
                  }
                }
label_10:
                try
                {
                  IReferenceResolver referenceResolver = (IReferenceResolver) EntityJsonSerializer.xWVskSBrDKR1fTolQB4W();
                  int num4 = 29;
                  IEnumerator<ITablePartMetadata> enumerator1;
                  Guid[] source;
                  IEntity entity1;
                  while (true)
                  {
                    int num5;
                    Dictionary<string, SerializableDictionary<string, object>> jsonObject;
                    List<PropertyMetadata>.Enumerator enumerator2;
                    ITablePartContainer tablePartContainer;
                    ITypeSettingsInstanceStore settingsInstanceStore;
                    IEntityManager entityManager;
                    IMetadataService metadataService;
                    string reference;
                    object obj2;
                    object obj3;
                    switch (num4)
                    {
                      case 1:
                        goto label_18;
                      case 2:
                        if (settings1 != null)
                        {
                          num4 = 3;
                          continue;
                        }
                        goto case 32;
                      case 3:
                        if (EntityJsonSerializer.AbjLE8BrwZsCgPlG48pi((object) settings1) == EntitySerializationMode.ChangesOnly)
                        {
                          num4 = 15;
                          continue;
                        }
                        goto case 32;
                      case 4:
label_72:
                        if (entity1 != null)
                        {
                          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 16 : 28;
                          continue;
                        }
                        goto case 9;
                      case 5:
                        if (!referenceResolver.TryGetReference(obj1, (IMetadata) metadata1, out reference))
                        {
                          num4 = 21;
                          continue;
                        }
                        goto case 20;
                      case 6:
                      case 16:
                      case 30:
                        goto label_230;
                      case 7:
                        serializable1 = (object) serializableDictionary;
                        num5 = 46;
                        break;
                      case 8:
                        if (!EntityJsonSerializer.QLCJI0Br4XcKqKfuNXVB((object) entity1))
                        {
                          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 9 : 12;
                          continue;
                        }
                        goto case 32;
                      case 9:
                      case 13:
                      case 31:
                      case 51:
                        tablePartContainer = metadata1 as ITablePartContainer;
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 18 : 1;
                        continue;
                      case 10:
                        jsonObject = ((TypeSettingsInstanceData) EntityJsonSerializer.kDglQ5BrrCkM5SflOkIH((object) settingsInstanceStore)).SerializeToJsonObject();
                        num4 = 17;
                        continue;
                      case 11:
                        if (EntityJsonSerializer.kDglQ5BrrCkM5SflOkIH((object) settingsInstanceStore) != null)
                        {
                          num4 = 48;
                          continue;
                        }
                        goto case 9;
                      case 12:
                        if (entityManager == null)
                        {
                          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 12 : 35;
                          continue;
                        }
                        obj3 = (object) entityManager.GetDirtyPropertyUids((object) entity1, EntityJsonSerializer.sRRdGoBr7eiXsaBqQb4p((object) settings1));
                        goto label_213;
                      case 14:
                      case 41:
                        if (entity1 == null)
                        {
                          num4 = 24;
                          continue;
                        }
                        obj2 = EntityJsonSerializer.dnj12rBrH3DsMvnkrW3a(entity1.CastAsRealType<IEntity>().GetType());
                        goto label_211;
                      case 15:
                        if (entity1 == null)
                        {
                          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 36 : 7;
                          continue;
                        }
                        goto case 8;
                      case 17:
                        if (jsonObject == null)
                        {
                          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 13 : 8;
                          continue;
                        }
                        goto case 22;
                      case 18:
                        if (tablePartContainer == null)
                        {
                          num4 = 16;
                          continue;
                        }
                        goto case 47;
                      case 19:
                      case 45:
                        serializableDictionary[(string) EntityJsonSerializer.CV43EWBrNKSDAZ8S6FRi(979449278 ^ 979466204)] = (object) EntityJsonSerializer.chbMOVBr6iCd0igt8IYm((object) metadata1);
                        num4 = 41;
                        continue;
                      case 20:
                        serializableDictionary[(string) EntityJsonSerializer.CV43EWBrNKSDAZ8S6FRi(-2138958856 ^ -2138872406)] = (object) reference;
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 7 : 7;
                        continue;
                      case 21:
                      case 25:
                        serializableDictionary[(string) EntityJsonSerializer.CV43EWBrNKSDAZ8S6FRi(-342626196 - 1290888215 ^ -1633420789)] = (object) reference;
                        num4 = 50;
                        continue;
                      case 22:
                        serializableDictionary[(string) EntityJsonSerializer.CV43EWBrNKSDAZ8S6FRi(~289714581 ^ -289785854)] = (object) jsonObject;
                        num4 = 51;
                        continue;
                      case 23:
                        enumerator2 = metadata1.Properties.GetEnumerator();
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 6 : 26;
                        continue;
                      case 24:
                        obj2 = (object) null;
                        goto label_211;
                      case 26:
                        try
                        {
label_177:
                          if (enumerator2.MoveNext())
                            goto label_119;
                          else
                            goto label_178;
label_114:
                          PropertyMetadata current1;
                          IEnumerator<KeyValuePair<string, object>> enumerator3;
                          int num6;
                          while (true)
                          {
                            int num7;
                            bool flag2;
                            object obj4;
                            bool flag3;
                            EntitySerializationSettings settings2;
                            ISerializableTypeDescriptor serializableTypeDescriptor;
                            EntitySerializationSettings settings3;
                            IDictionary<string, object> dictionary;
                            object serializable2;
                            bool flag4;
                            IPropertyPermissionService service;
                            ITypeDescriptor typeDescriptor;
                            switch (num6)
                            {
                              case 1:
                              case 9:
                              case 16:
                              case 32:
                              case 43:
                                typeDescriptor = (ITypeDescriptor) EntityJsonSerializer.HbpRqlBrMZ855HvM8iS0((object) metadataService, EntityJsonSerializer.V4Hof2Brm0w0WBeGuE8x((object) current1), EntityJsonSerializer.AIBoY6BryqQihLylklFb((object) current1));
                                num6 = 17;
                                continue;
                              case 2:
                              case 23:
                              case 44:
                                serializableTypeDescriptor = typeDescriptor as ISerializableTypeDescriptor;
                                num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 4 : 6;
                                continue;
                              case 3:
                                if (this.PropertyFilter != null)
                                {
                                  num7 = 33;
                                  break;
                                }
                                goto case 7;
                              case 4:
                                flag4 = true;
                                num6 = 45;
                                continue;
                              case 5:
                                if (settings1 == null)
                                {
                                  num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 49 : 11;
                                  continue;
                                }
                                goto case 22;
                              case 6:
                                if (serializableTypeDescriptor != null)
                                {
                                  num6 = 56;
                                  continue;
                                }
                                goto label_177;
                              case 7:
                                if (source == null)
                                {
                                  num7 = 27;
                                  break;
                                }
                                goto case 11;
                              case 8:
                                goto label_139;
                              case 10:
                                flag4 = ((EntitySerializationFunctions) EntityJsonSerializer.JIbcIeBrdSCTWs6s5Vva((object) settings1)).Filter(obj1, metadata1, current1, settings3);
                                num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 0 : 0;
                                continue;
                              case 11:
                                if (((IEnumerable<Guid>) source).Contains<Guid>(EntityJsonSerializer.chbMOVBr6iCd0igt8IYm((object) current1)))
                                {
                                  num6 = 19;
                                  continue;
                                }
                                goto label_177;
                              case 12:
                              case 29:
                              case 53:
                                if (dictionary != null)
                                {
                                  num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 29 : 41;
                                  continue;
                                }
                                goto label_177;
                              case 14:
                                if (EntityJsonSerializer.JIbcIeBrdSCTWs6s5Vva((object) settings1) == null)
                                {
                                  num6 = 20;
                                  continue;
                                }
                                goto case 40;
                              case 15:
                                serializableDictionary[(string) EntityJsonSerializer.gIrWvBBrJH5uQ9iaduLl((object) current1)] = (object) null;
                                num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 2 : 0;
                                continue;
                              case 17:
                                if (typeDescriptor != null)
                                {
                                  num6 = 23;
                                  continue;
                                }
                                goto case 58;
                              case 18:
                                dictionary = serializableTypeDescriptor.Serialize(obj1, metadata1, current1, settings3);
                                num6 = 29;
                                continue;
                              case 19:
                              case 27:
                                if (settings1 == null)
                                {
                                  num6 = 9;
                                  continue;
                                }
                                goto case 24;
                              case 20:
                              case 46:
                              case 48:
                                dictionary = serializableTypeDescriptor.Serialize(obj1, metadata1, current1, settings3);
                                num7 = 12;
                                break;
                              case 21:
                                if (entity1 == null)
                                {
                                  num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 32 : 21;
                                  continue;
                                }
                                goto case 25;
                              case 22:
                                (flag3, settings2) = Continue(settings1, (IPropertyMetadata) current1, (string) EntityJsonSerializer.gIrWvBBrJH5uQ9iaduLl((object) current1));
                                num6 = 47;
                                continue;
                              case 24:
                                if (!EntityJsonSerializer.Hf97Z1Br0FSnTqEaGB1A((object) settings1))
                                {
                                  num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 43 : 27;
                                  continue;
                                }
                                goto case 21;
                              case 25:
                                service = Locator.GetService<IPropertyPermissionService>();
                                num6 = 50;
                                continue;
                              case 26:
                                if (obj4 != null)
                                {
                                  num6 = 42;
                                  continue;
                                }
                                goto case 15;
                              case 28:
                                (flag2, settings3) = Continue(settings1, (IPropertyMetadata) current1, current1.Name);
                                num6 = 52;
                                continue;
                              case 30:
                                goto label_72;
                              case 31:
                              case 37:
                              case 39:
                              case 59:
                                goto label_177;
                              case 33:
                                if (!this.PropertyFilter(current1))
                                {
                                  num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 59 : 15;
                                  continue;
                                }
                                goto case 7;
                              case 34:
                              case 42:
                                settings2 = (EntitySerializationSettings) null;
                                num6 = 5;
                                continue;
                              case 35:
                                goto label_119;
                              case 36:
                                if (settings1 == null)
                                {
                                  num6 = 48;
                                  continue;
                                }
                                goto case 14;
                              case 38:
                                dictionary = settings1.Functions.Serialize(serializableTypeDescriptor, obj1, metadata1, current1, settings3);
                                num6 = 53;
                                continue;
                              case 40:
                                if (((EntitySerializationFunctions) EntityJsonSerializer.JIbcIeBrdSCTWs6s5Vva((object) settings1)).Serialize != null)
                                {
                                  num7 = 4;
                                  break;
                                }
                                goto case 20;
                              case 41:
                                enumerator3 = dictionary.GetEnumerator();
                                num6 = 8;
                                continue;
                              case 45:
                                if (((EntitySerializationFunctions) EntityJsonSerializer.JIbcIeBrdSCTWs6s5Vva((object) settings1)).Filter == null)
                                {
                                  num6 = 13;
                                  continue;
                                }
                                goto case 10;
                              case 47:
                                if (flag3)
                                {
                                  num6 = 31;
                                  continue;
                                }
                                goto case 49;
                              case 49:
                              case 51:
                                serializable2 = this.ConvertToSerializable(obj4, settings2);
                                num6 = 60;
                                continue;
                              case 50:
                                if (service == null)
                                {
                                  num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 1 : 0;
                                  continue;
                                }
                                goto case 54;
                              case 52:
                                if (flag2)
                                {
                                  num6 = 37;
                                  continue;
                                }
                                goto case 57;
                              case 54:
                                if (service.CheckPropertyPermission((object) entity1, EntityJsonSerializer.chbMOVBr6iCd0igt8IYm((object) current1)) != PropertyPermissionType.Hide)
                                {
                                  num6 = 16;
                                  continue;
                                }
                                goto label_177;
                              case 55:
                                if (settings1 != null)
                                {
                                  num6 = 28;
                                  continue;
                                }
                                goto case 57;
                              case 56:
                                settings3 = (EntitySerializationSettings) null;
                                num6 = 55;
                                continue;
                              case 57:
                                dictionary = (IDictionary<string, object>) null;
                                num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 5 : 36;
                                continue;
                              case 58:
                                obj4 = EntityJsonSerializer.D6akmUBr9N6mGgevZR6k(obj1, EntityJsonSerializer.gIrWvBBrJH5uQ9iaduLl((object) current1), (object) null);
                                num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 26 : 22;
                                continue;
                              case 60:
                                serializableDictionary[(string) EntityJsonSerializer.gIrWvBBrJH5uQ9iaduLl((object) current1)] = serializable2;
                                num7 = 44;
                                break;
                              default:
                                if (flag4)
                                {
                                  num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 38 : 30;
                                  continue;
                                }
                                goto case 18;
                            }
                            num6 = num7;
                          }
label_139:
                          try
                          {
label_141:
                            if (enumerator3.MoveNext())
                              goto label_143;
                            else
                              goto label_142;
label_140:
                            KeyValuePair<string, object> current2;
                            int num8;
                            while (true)
                            {
                              switch (num8)
                              {
                                case 1:
                                  goto label_141;
                                case 2:
                                  goto label_143;
                                case 3:
                                  goto label_177;
                                default:
                                  serializableDictionary[current2.Key] = current2.Value;
                                  num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 1;
                                  continue;
                              }
                            }
label_142:
                            num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 3 : 0;
                            goto label_140;
label_143:
                            current2 = enumerator3.Current;
                            num8 = 0;
                            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
                            {
                              num8 = 0;
                              goto label_140;
                            }
                            else
                              goto label_140;
                          }
                          finally
                          {
                            int num9;
                            if (enumerator3 == null)
                              num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 2 : 2;
                            else
                              goto label_149;
label_148:
                            switch (num9)
                            {
                              case 1:
                              case 2:
                            }
label_149:
                            enumerator3.Dispose();
                            num9 = 1;
                            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
                            {
                              num9 = 1;
                              goto label_148;
                            }
                            else
                              goto label_148;
                          }
label_119:
                          current1 = enumerator2.Current;
                          num6 = 3;
                          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
                          {
                            num6 = 1;
                            goto label_114;
                          }
                          else
                            goto label_114;
label_178:
                          num6 = 30;
                          goto label_114;
                        }
                        finally
                        {
                          enumerator2.Dispose();
                          int num10 = 0;
                          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
                            num10 = 0;
                          switch (num10)
                          {
                            default:
                          }
                        }
                      case 27:
                        if (settingsInstanceStore == null)
                        {
                          num4 = 31;
                          continue;
                        }
                        goto case 11;
                      case 28:
                        settingsInstanceStore = (ITypeSettingsInstanceStore) EntityJsonSerializer.eu9MqaBrlpca1JPpJqtc((object) entity1, false, false);
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 27 : 2;
                        continue;
                      case 29:
                        if (referenceResolver != null & flag1)
                        {
                          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 1 : 5;
                          continue;
                        }
                        goto case 50;
                      case 32:
                      case 36:
                        obj3 = (object) null;
                        goto label_213;
                      case 33:
                        if (entity1 == null)
                        {
                          num4 = 34;
                          continue;
                        }
                        goto case 44;
                      case 34:
                      case 42:
                        if (settings1 == null)
                        {
                          num5 = 19;
                          break;
                        }
                        goto case 49;
                      case 35:
                        obj3 = EntityJsonSerializer.L0eTMhBrAsYS2YYDfW7c((object) entity1);
                        goto label_213;
                      case 37:
                        metadataService = (IMetadataService) EntityJsonSerializer.bqcpbxBrxNwAqZVwFPgd();
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 12 : 23;
                        continue;
                      case 38:
                        serializableDictionary[(string) EntityJsonSerializer.CV43EWBrNKSDAZ8S6FRi(589593376 ^ -1977315327 ^ -1459511715)] = (object) entity1.ToString();
                        num4 = 42;
                        continue;
                      case 39:
                        enumerator1 = tablePartContainer.TableParts.GetEnumerator();
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 1 : 0;
                        continue;
                      case 40:
                        if (entity1 != null)
                        {
                          num4 = 39;
                          continue;
                        }
                        goto label_230;
                      case 43:
                        if (!EntityJsonSerializer.QLCJI0Br4XcKqKfuNXVB((object) entity1))
                        {
                          num5 = 14;
                          break;
                        }
                        goto case 52;
                      case 44:
                        serializableDictionary[(string) EntityJsonSerializer.CV43EWBrNKSDAZ8S6FRi(-244066886 - -48452443 ^ -195581877)] = entity1.GetId();
                        num4 = 38;
                        continue;
                      case 46:
                        goto label_243;
                      case 47:
                        if (!(tablePartContainer is IEntityMetadata))
                        {
                          num4 = 30;
                          continue;
                        }
                        goto case 40;
                      case 48:
                        if (EntityJsonSerializer.jr59I2BrgiCr4i7MX2eS((object) ((TypeSettingsInstanceData) EntityJsonSerializer.kDglQ5BrrCkM5SflOkIH((object) settingsInstanceStore)).Items) <= 0)
                        {
                          num4 = 9;
                          continue;
                        }
                        goto case 10;
                      case 49:
                        if (EntityJsonSerializer.AbjLE8BrwZsCgPlG48pi((object) settings1) != EntitySerializationMode.Default)
                        {
                          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 0 : 0;
                          continue;
                        }
                        goto case 19;
                      case 50:
                        entity1 = obj1 as IEntity;
                        num4 = 33;
                        continue;
                      case 52:
                        if (entity1 is IInheritable)
                        {
                          num4 = 45;
                          continue;
                        }
                        goto case 14;
                      default:
                        if (entity1 != null)
                        {
                          num4 = 43;
                          continue;
                        }
                        goto case 14;
                    }
                    num4 = num5;
                    continue;
label_211:
                    entityManager = (IEntityManager) obj2;
                    num4 = 2;
                    continue;
label_213:
                    source = (Guid[]) obj3;
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 37 : 27;
                  }
label_18:
                  try
                  {
label_60:
                    if (enumerator1.MoveNext())
                      goto label_22;
                    else
                      goto label_61;
label_19:
                    SerializableList<object> serializableList;
                    ITablePartMetadata current;
                    bool flag5;
                    EntitySerializationSettings settings4;
                    IEnumerable enumerable;
                    IEnumerator enumerator4;
                    int num11;
                    while (true)
                    {
                      switch (num11)
                      {
                        case 1:
                          try
                          {
label_51:
                            if (enumerator4.MoveNext())
                              goto label_49;
                            else
                              goto label_52;
label_47:
                            IEntity entity2;
                            int num12;
                            while (true)
                            {
                              switch (num12)
                              {
                                case 1:
                                  goto label_51;
                                case 2:
                                  serializableList.Add(this.ConvertToSerializable((object) entity2, settings4));
                                  num12 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 1 : 0;
                                  continue;
                                case 3:
                                  goto label_49;
                                default:
                                  goto label_29;
                              }
                            }
label_49:
                            entity2 = (IEntity) EntityJsonSerializer.xD6YjPBrU3slIB069iFj((object) enumerator4);
                            num12 = 0;
                            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0)
                            {
                              num12 = 2;
                              goto label_47;
                            }
                            else
                              goto label_47;
label_52:
                            num12 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 0;
                            goto label_47;
                          }
                          finally
                          {
                            IDisposable disposable2 = enumerator4 as IDisposable;
                            int num13 = 0;
                            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
                              num13 = 0;
                            while (true)
                            {
                              switch (num13)
                              {
                                case 1:
                                  goto label_59;
                                case 2:
                                  EntityJsonSerializer.S2JZIsBrsKd90OvN4Nbg((object) disposable2);
                                  num13 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 1 : 1;
                                  continue;
                                default:
                                  if (disposable2 != null)
                                  {
                                    num13 = 2;
                                    continue;
                                  }
                                  goto label_59;
                              }
                            }
label_59:;
                          }
                        case 2:
                          if (!flag5)
                          {
                            num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 4 : 19;
                            continue;
                          }
                          goto label_60;
                        case 3:
label_29:
                          serializableDictionary[(string) EntityJsonSerializer.SoBUMMBrjxwVcAwfuCnI((object) current)] = (object) serializableList;
                          num11 = 18;
                          continue;
                        case 4:
                          if (settings1.Mode == EntitySerializationMode.ChangesOnly)
                          {
                            num11 = 14;
                            continue;
                          }
                          goto case 9;
                        case 5:
                          if (settings1 == null)
                          {
                            num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 9 : 6;
                            continue;
                          }
                          goto case 4;
                        case 6:
                          (flag5, settings4) = Continue(settings1, (IPropertyMetadata) current, (string) EntityJsonSerializer.SoBUMMBrjxwVcAwfuCnI((object) current));
                          num11 = 2;
                          continue;
                        case 7:
                          if (!this.NeedBindTablePart(current))
                          {
                            num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 0;
                            continue;
                          }
                          goto case 16;
                        case 8:
                          enumerator4 = (IEnumerator) EntityJsonSerializer.oGhD9aBrLhLkLRSGH2Mr((object) enumerable);
                          num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 1 : 1;
                          continue;
                        case 9:
                        case 11:
                          serializableList = new SerializableList<object>();
                          num11 = 8;
                          continue;
                        case 10:
                          if (((IEnumerable<Guid>) source).Contains<Guid>(EntityJsonSerializer.iE5FM0Br5Y2AMx24nypq((object) current)))
                          {
                            num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 13 : 8;
                            continue;
                          }
                          goto label_60;
                        case 13:
                          settings4 = (EntitySerializationSettings) null;
                          num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 24 : 5;
                          continue;
                        case 14:
                          serializableDictionary[current.TablePartPropertyName] = (object) new TablePartChangesModel(enumerable, enumerable).ToDictionary();
                          num11 = 12;
                          continue;
                        case 15:
                          goto label_230;
                        case 16:
                          if (source != null)
                          {
                            num11 = 10;
                            continue;
                          }
                          goto case 13;
                        case 17:
                          goto label_22;
                        case 19:
                        case 20:
                          enumerable = EntityJsonSerializer.HyLDxABrYTNTc1q1Z0iC((object) entity1, current.TablePartPropertyUid) as IEnumerable;
                          num11 = 22;
                          continue;
                        case 22:
                          if (enumerable == null)
                          {
                            num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 3 : 21;
                            continue;
                          }
                          goto case 5;
                        case 23:
                          if (this.NeedBindTablePart != null)
                          {
                            num11 = 7;
                            continue;
                          }
                          goto case 16;
                        case 24:
                          if (settings1 == null)
                          {
                            num11 = 20;
                            continue;
                          }
                          goto case 6;
                        default:
                          goto label_60;
                      }
                    }
label_22:
                    current = enumerator1.Current;
                    num11 = 23;
                    goto label_19;
label_61:
                    num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 14 : 15;
                    goto label_19;
                  }
                  finally
                  {
                    int num14;
                    if (enumerator1 == null)
                      num14 = 2;
                    else
                      goto label_65;
label_64:
                    switch (num14)
                    {
                      case 1:
                      case 2:
                    }
label_65:
                    EntityJsonSerializer.S2JZIsBrsKd90OvN4Nbg((object) enumerator1);
                    num14 = 1;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
                    {
                      num14 = 1;
                      goto label_64;
                    }
                    else
                      goto label_64;
                  }
                }
                finally
                {
                  int num15;
                  if (disposable1 == null)
                    num15 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 0 : 0;
                  else
                    goto label_217;
label_216:
                  switch (num15)
                  {
                    case 2:
                      break;
                    default:
                  }
label_217:
                  EntityJsonSerializer.S2JZIsBrsKd90OvN4Nbg((object) disposable1);
                  num15 = 1;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
                  {
                    num15 = 1;
                    goto label_216;
                  }
                  else
                    goto label_216;
                }
label_221:
                int num16 = 0;
                goto label_222;
label_220:
                num16 = EntityJsonSerializer.IcBTPaBrajQixJIkmFEk((object) settings1) ? 1 : 0;
label_222:
                flag1 = num16 != 0;
                num3 = 4;
                goto label_8;
              }
              catch (Exception ex)
              {
                int num17 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
                  num17 = 0;
                while (true)
                {
                  switch (num17)
                  {
                    case 1:
                      EntityJsonSerializer.nYHrVXBrcHNJMSIeSIs4((object) methodCallInfo, (object) ex);
                      num17 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 2;
                      continue;
                    case 2:
                      goto label_229;
                    default:
                      if (methodCallInfo != null)
                      {
                        num17 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 1 : 1;
                        continue;
                      }
                      goto label_229;
                  }
                }
label_229:
                throw;
              }
          }
        }
      }
      finally
      {
        int num18;
        if (methodCallInfo == null)
          num18 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 1 : 1;
        else
          goto label_234;
label_233:
        switch (num18)
        {
          case 2:
            break;
          default:
        }
label_234:
        EntityJsonSerializer.S2JZIsBrsKd90OvN4Nbg((object) methodCallInfo);
        num18 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
        {
          num18 = 0;
          goto label_233;
        }
        else
          goto label_233;
      }
label_243:
      return serializable1;

      (bool, EntitySerializationSettings) Continue(
        EntitySerializationSettings oldSettings,
        IPropertyMetadata propertyMetadata,
        string propertyName)
      {
        EntitySerializationSettings newSettings = new EntitySerializationSettings()
        {
          CheckPropertyPermissions = settings1.CheckPropertyPermissions,
          Mode = settings1.Mode,
          TypePropertySelector = settings1.TypePropertySelector,
          WriteReferences = oldSettings.WriteReferences
        };
        Dictionary<Guid, EntitySerializationSelector> oldTypePropertyTypeSelector = oldSettings.TypePropertySelector;
        if (oldTypePropertyTypeSelector.Count > 0)
        {
          bool flag = false;
          (bool result1, EntitySerializationSelector selector1) = TryGetPropertySelector((Func<IEnumerable<ClassMetadata>>) (() => (IEnumerable<ClassMetadata>) new ClassMetadata[1]
          {
            metadata1
          }));
          if (selector1 != null)
          {
            newSettings.PropertySelector = selector1;
            return (false, newSettings);
          }
          if (result1)
            flag = true;
          (bool result2, EntitySerializationSelector selector2) = TryGetPropertySelector((Func<IEnumerable<ClassMetadata>>) (() => (IEnumerable<ClassMetadata>) MetadataLoader.GetBaseClasses(metadata1)));
          if (selector2 != null)
          {
            newSettings.PropertySelector = selector2;
            return (false, newSettings);
          }
          if (result2)
            flag = true;
          (bool result3, EntitySerializationSelector selector3) = TryGetPropertySelector((Func<IEnumerable<ClassMetadata>>) (() => (IEnumerable<ClassMetadata>) MetadataLoader.GetChildClasses(metadata1)));
          if (selector3 != null)
          {
            newSettings.PropertySelector = selector3;
            return (false, newSettings);
          }
          if (result3)
            flag = true;
          if (flag)
            return metadata1 is ITablePartContainer && propertyMetadata is ITablePartMetadata ? (false, newSettings) : (true, (EntitySerializationSettings) null);
        }
        EntitySerializationSelector propertySelector = oldSettings.PropertySelector;
        newSettings.PropertySelector = propertySelector?.GetSelector(propertyName);
        newSettings.Functions = settings1.Functions.Copy(obj1, metadata1, propertyMetadata, settings1, newSettings);
        return (propertySelector != null && propertySelector.SelectionMode == SelectionMode.ByName && newSettings.PropertySelector == null, newSettings);

        (bool result, EntitySerializationSelector selector) TryGetPropertySelector(
          Func<IEnumerable<ClassMetadata>> metadataList)
        {
          bool flag = false;
          foreach (ClassMetadata classMetadata in metadataList())
          {
            EntitySerializationSelector serializationSelector;
            if (oldTypePropertyTypeSelector.TryGetValue(classMetadata.Uid, out serializationSelector))
            {
              flag = true;
              EntitySerializationSelector selector = serializationSelector?.GetSelector(propertyName);
              if (selector != null)
                return (true, selector);
            }
            if (classMetadata is EntityMetadata entityMetadata && oldTypePropertyTypeSelector.TryGetValue(entityMetadata.ImplementationUid, out serializationSelector))
            {
              flag = true;
              EntitySerializationSelector selector = serializationSelector?.GetSelector(propertyName);
              if (selector != null)
                return (true, selector);
            }
          }
          return (flag, (EntitySerializationSelector) null);
        }
      }
    }

    /// <summary>
    /// Сконвертировать из сериализованного объекта в сущность или объект
    /// </summary>
    /// <typeparam name="T">Тип сущности или объекта</typeparam>
    /// <param name="obj">Сериализованный объект</param>
    /// <returns>Сущность</returns>
    public T ConvertFromSerializable<T>(IDictionary<string, object> obj) where T : class => (T) this.ConvertFromSerializable(obj, typeof (T));

    /// <summary>
    /// Сконвертировать из сериализованного объекта в сущность или объект
    /// </summary>
    /// <param name="serObj">Сериализованный объект</param>
    /// <param name="entityType">Тип сущности или объекта</param>
    /// <param name="loadEntityIfExists">Если False, то будет всегда создаваться новая сущность. Если True - то будет загружена из БД, если существует. Или новая, если не существует.</param>
    /// <returns>Сущность</returns>
    public object ConvertFromSerializable(
      IDictionary<string, object> serObj,
      Type entityType,
      bool loadEntityIfExists = true)
    {
      return this.ConvertFromSerializable(serObj, entityType, (Func<object, Type, bool>) ((id, type) => loadEntityIfExists));
    }

    /// <summary>
    /// Сконвертировать из сериализованного объекта в сущность или объект
    /// </summary>
    /// <param name="serObj">Сериализованный объект</param>
    /// <param name="entityType">Тип сущности или объекта</param>
    /// <param name="loadEntityIfExistsHandler">Делегат возвращает: если False, то будет всегда создаваться новая сущность. Если True - то будет загружена из БД, если существует. Или новая, если не существует.</param>
    /// <returns>Сущность</returns>
    public object ConvertFromSerializable(
      IDictionary<string, object> serObj,
      Type entityType,
      Func<object, Type, bool> loadEntityIfExistsHandler)
    {
      Contract.ArgumentNotNull((object) serObj, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1012087039 ^ 1012027007));
      Contract.ArgumentNotNull((object) entityType, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1872275253 >> 6 ^ -29274377));
      object obj1 = this.TryDeserializeEntityId(serObj, entityType);
      Guid? nullable = this.TryDeserializeEntityUid(serObj);
      object obj2 = (object) null;
      bool loadEntityIfExists = loadEntityIfExistsHandler == null || loadEntityIfExistsHandler(obj1, entityType);
      if (loadEntityIfExists)
      {
        Type entityIdType = ModelHelper.GetEntityIdType(entityType);
        IEntityManager entityManagerOrNull = ModelHelper.GetEntityManagerOrNull(entityType);
        if ((obj1 == null || entityType.IsDefaultId(entityIdType, obj1)) && nullable.HasValue && nullable.Value != Guid.Empty)
          obj2 = entityManagerOrNull?.LoadOrCreate(nullable.Value);
        if (obj2 == null && obj1 != null)
          obj2 = entityManagerOrNull?.LoadOrNull(obj1);
      }
      if (obj2 == null)
        obj2 = InterfaceActivator.Create(entityType);
      if (obj2 is IEntity entity && this.NeedBindProperties != null && !this.NeedBindProperties(entity))
        return (object) entity;
      if (obj1 != null && entity != null)
      {
        object id = entity.GetId();
        if (id == null || id.GetType() != typeof (long) || (long) id <= 0L)
          entity.SetId(obj1);
      }
      return this.ConvertFromSerializable(obj2, serObj, loadEntityIfExists);
    }

    /// <summary>
    /// Сконвертировать из сериализованного объекта в сущность или объект
    /// </summary>
    /// <param name="obj">Сущность или объект, в который будут записаные десериализованные значения</param>
    /// <param name="serObj">Сериализованный объект</param>
    /// <param name="loadEntityIfExists">Если False, то будет всегда создаваться новая сущность. Если True - то будет загружена из БД, если существует. Или новая, если не существует.</param>
    /// <returns>Сущность</returns>
    public object ConvertFromSerializable(
      object obj,
      IDictionary<string, object> serObj,
      bool loadEntityIfExists = true)
    {
      obj = obj.CastAsRealType();
      return this.ConvertFromSerializable(obj, (ClassMetadata) MetadataLoader.LoadMetadata(obj.GetType()), serObj, loadEntityIfExists);
    }

    /// <summary>
    /// Сконвертировать из сериализованного объекта в сущность или объект
    /// </summary>
    /// <param name="obj">Сущность или объект, в который будут записаные десериализованные значения</param>
    /// <param name="metadata">Метаданные объекта</param>
    /// <param name="serObj">Сериализованный объект</param>
    /// <param name="loadEntityIfExists">Если False, то будет всегда создаваться новая сущность. Если True - то будет загружена из БД, если существует. Или новая, если не существует.</param>
    /// <returns>Сущность</returns>
    internal object ConvertFromSerializable(
      object obj,
      ClassMetadata metadata,
      IDictionary<string, object> serObj,
      bool loadEntityIfExists = true)
    {
      Contract.ArgumentNotNull(obj, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1052221104 - 768835541 ^ 283426131));
      Contract.ArgumentNotNull((object) serObj, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099699241));
      EntityJsonSerializer.AddSerializerMarker((object) this);
      using (MethodCallInfo methodCallInfo = DiagnosticsManager.StartCall<MethodCallInfo>((Func<MethodCallInfo>) (() => new MethodCallInfo(EntityJsonSerializer.OwnerType, EntityJsonSerializer.ConvertFromSerializableCall, new object[3]
      {
        obj,
        (object) serObj,
        (object) loadEntityIfExists
      }))))
      {
        IEntity entity = obj as IEntity;
        try
        {
          using (ReferenceResolverSerializer.CreateResolver(true))
          {
            object obj1;
            if (serObj.TryGetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1051802738 - -1831968059 ^ -1411141633), out obj1))
              return ReferenceResolverSerializer.CurrentResolver.ResolveReference(obj1.ToString());
            object obj2;
            if (serObj.TryGetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418440330 ^ 1418385620), out obj2))
              ReferenceResolverSerializer.CurrentResolver.AddReference(obj2.ToString(), obj);
            IMetadataService service = MetadataServiceContext.Service;
            object obj3;
            if (entity != null && serObj.TryGetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099699393), out obj3) && obj3 is IDictionary<string, object> dictionary1)
            {
              Dictionary<string, IDictionary<string, object>> jsonObject = new Dictionary<string, IDictionary<string, object>>();
              foreach (KeyValuePair<string, object> keyValuePair in (IEnumerable<KeyValuePair<string, object>>) dictionary1)
              {
                if (keyValuePair.Value is IDictionary<string, object> dictionary)
                  jsonObject[keyValuePair.Key] = dictionary;
              }
              TypeSettingsInstanceData settingsInstanceData = new TypeSettingsInstanceData();
              settingsInstanceData.DeserializeFromJsonObject(jsonObject);
              foreach (TypeSettingsInstanceData.DataItem dataItem in settingsInstanceData.Items)
                entity.SavePropertyInstanceSettings(dataItem.PropertyUid, dataItem.Settings);
            }
            IDictionary<string, object> values = serObj;
            foreach (PropertyMetadata property in metadata.Properties)
            {
              if ((this.PropertyFilter == null || this.PropertyFilter(property)) && property.TypeUid != Guid.Empty)
              {
                ITypeDescriptor typeDescriptor = service.GetTypeDescriptor(property.TypeUid, property.SubTypeUid);
                if (typeDescriptor == null)
                  throw new EleWise.ELMA.Model.Metadata.MetadataException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-882126494 ^ -882202638), (object) property.TypeUid));
                if (typeDescriptor is ISerializableTypeDescriptor serializableTypeDescriptor)
                  serializableTypeDescriptor.Deserialize(obj, metadata, property, values);
              }
            }
            if (metadata is ITablePartContainer tablePartContainer)
            {
              if (tablePartContainer is IEntityMetadata)
              {
                if (entity != null)
                {
                  foreach (ITablePartMetadata tablePart in (IEnumerable<ITablePartMetadata>) tablePartContainer.TableParts)
                  {
                    object obj4;
                    if ((this.NeedBindTablePart == null || this.NeedBindTablePart(tablePart)) && entity.GetPropertyValue(tablePart.TablePartPropertyUid) is ISet propertyValue && values != null && values.TryGetValue(tablePart.TablePartPropertyName, out obj4))
                    {
                      IDictionary<string, object> dict = obj4 as IDictionary<string, object>;
                      IEnumerable enumerable = obj4 as IEnumerable;
                      Type typeByUid = MetadataServiceContext.MetadataRuntimeService.GetTypeByUid(tablePart.Uid);
                      if (dict != null)
                        TablePartChangesModel.FromDictionary(dict).Apply(propertyValue, typeByUid, true);
                      else if (enumerable != null)
                      {
                        propertyValue.Clear();
                        foreach (object obj5 in enumerable)
                        {
                          if (obj5 is IDictionary<string, object> serObj1)
                          {
                            IEntity o = (IEntity) this.ConvertFromSerializable(serObj1, typeByUid, loadEntityIfExists);
                            o?.SetPropertyValue(tablePart.ParentPropertyUid, (object) entity);
                            propertyValue.Add((object) o);
                          }
                        }
                      }
                    }
                  }
                }
              }
            }
          }
        }
        catch (Exception ex)
        {
          if (methodCallInfo != null)
            methodCallInfo.Exception = ex;
          throw;
        }
        EntityJsonSerializer.InvokeActions((object) this);
        return obj;
      }
    }

    /// <summary>Добавить в словарь по пути</summary>
    /// <param name="path">Путь. Н-р. Blok1[0].FailVBloke.Uid</param>
    /// <param name="value">Значение</param>
    /// <param name="dic">Ссылка на словарь</param>
    private void AddDictionaryByPath(string path, object value, Dictionary<string, object> dic)
    {
      List<string> list = ((IEnumerable<string>) path.Split(new char[1]
      {
        '.'
      }, StringSplitOptions.RemoveEmptyEntries)).ToList<string>();
      string key = list[0];
      string str = string.Empty;
      if (list.Count > 1)
      {
        str = list[1];
        int length = str.IndexOf(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886586003), StringComparison.InvariantCultureIgnoreCase);
        if (length > 0)
          str = str.Substring(0, length);
      }
      list.RemoveAt(0);
      string path1 = string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488875761), (IEnumerable<string>) list);
      string s = "";
      if (key.IndexOf(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1581325282 << 3 ^ -234345998), StringComparison.InvariantCultureIgnoreCase) > 0)
      {
        int length = key.IndexOf(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1819636893 << 3 ^ 1672172042), StringComparison.InvariantCultureIgnoreCase);
        int num = key.LastIndexOf(z2jc63fLkugS1X8Q9N.tE1kD1vbB(825385222 ^ 825399278), StringComparison.InvariantCultureIgnoreCase);
        s = key.Substring(length + 1, num - length - 1);
        key = key.Substring(0, length);
      }
      if (!string.IsNullOrWhiteSpace(str))
      {
        if (!string.IsNullOrWhiteSpace(s) && long.TryParse(s, out long _))
        {
          List<Dictionary<string, object>> dictionaryList = new List<Dictionary<string, object>>();
          Dictionary<string, object> dic1 = new Dictionary<string, object>();
          string uniqueId = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2112703338 ^ -2112634296), (object) (key + z2jc63fLkugS1X8Q9N.tE1kD1vbB(516838154 ^ 516859368) + s + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97917250)).GetDeterministicGuid());
          if (dic.ContainsKey(key))
          {
            if (dic[key] is List<Dictionary<string, object>> source)
            {
              Dictionary<string, object> dic2 = source.FirstOrDefault<Dictionary<string, object>>((Func<Dictionary<string, object>, bool>) (k => k.ContainsKey(uniqueId) && k[uniqueId] is long && (long) k[uniqueId] == index));
              if (dic2 == null)
              {
                dic1.Add(uniqueId, (object) index);
                source.Add(dic1);
                this.AddDictionaryByPath(path1, value, dic1);
              }
              else
                this.AddDictionaryByPath(path1, value, dic2);
            }
            else
              dictionaryList.Add(dic1);
          }
          else
          {
            dic1.Add(uniqueId, (object) index);
            dictionaryList.Add(dic1);
            dic.Add(key, (object) dictionaryList);
            this.AddDictionaryByPath(path1, value, dic1);
          }
        }
        else
        {
          Dictionary<string, object> dic3 = dic.ContainsKey(key) ? dic[key] as Dictionary<string, object> : (Dictionary<string, object>) null;
          if (dic3 != null)
          {
            this.AddDictionaryByPath(path1, value, dic3);
          }
          else
          {
            Dictionary<string, object> dic4 = new Dictionary<string, object>();
            dic.Add(key, (object) dic4);
            this.AddDictionaryByPath(path1, value, dic4);
          }
        }
      }
      else
        dic.Add(key, value);
    }

    /// <summary>
    /// Сконвертировать из сериализованного объекта в сущность или объект
    /// </summary>
    /// <param name="obj">Сущность или объект, в который будут записаные десериализованные значения</param>
    /// <param name="dict">Словарь &lt;Свойство,Значение&gt;</param>
    /// <param name="errors">Ошибки разбора строк словаря (необязательный параметр, может быть null)</param>
    /// <returns></returns>
    public object ConvertFromSerializable(
      object obj,
      NameValueCollection dict,
      ref Dictionary<string, Exception> errors,
      bool loadEntityIfExists = true)
    {
      int num1 = 1;
      Dictionary<string, object> dictionary;
      List<string>.Enumerator enumerator;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (dict == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 0 : 0;
                continue;
              }
              goto label_7;
            case 2:
              goto label_5;
            case 3:
              goto label_8;
            default:
              goto label_6;
          }
        }
label_7:
        List<string> list = ((IEnumerable<string>) EntityJsonSerializer.OXSpVQBrzGjIFhVUkL8o((object) dict)).ToList<string>();
        list.Sort();
        dictionary = new Dictionary<string, object>();
        enumerator = list.GetEnumerator();
        num1 = 3;
      }
label_5:
      return this.ConvertFromSerializable(obj, (IDictionary<string, object>) dictionary, loadEntityIfExists);
label_6:
      return obj;
label_8:
      try
      {
label_21:
        if (enumerator.MoveNext())
          goto label_10;
        else
          goto label_22;
label_9:
        string current;
        string str;
        int num3;
        while (true)
        {
          switch (num3)
          {
            case 1:
              if (!EntityJsonSerializer.I6AyW3BgBQveuYTuRGuX((object) str))
              {
                num3 = 5;
                continue;
              }
              goto label_21;
            case 2:
              goto label_21;
            case 3:
              goto label_5;
            case 4:
              str = (string) EntityJsonSerializer.QW1cgeBgFPfBE44HCOUB((object) dict, (object) current);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 1 : 1;
              continue;
            case 5:
              goto label_12;
            default:
              goto label_10;
          }
        }
label_12:
        try
        {
          this.AddDictionaryByPath(current, (object) str, dictionary);
          int num4 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
            num4 = 0;
          switch (num4)
          {
            default:
              goto label_21;
          }
        }
        catch (Exception ex)
        {
          int num5 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
            num5 = 0;
          while (true)
          {
            switch (num5)
            {
              case 1:
                goto label_21;
              case 2:
                errors.Add(current, ex);
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 1 : 1;
                continue;
              default:
                if (errors != null)
                {
                  num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 1 : 2;
                  continue;
                }
                goto label_21;
            }
          }
        }
label_10:
        current = enumerator.Current;
        num3 = 4;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
        {
          num3 = 1;
          goto label_9;
        }
        else
          goto label_9;
label_22:
        num3 = 3;
        goto label_9;
      }
      finally
      {
        enumerator.Dispose();
        int num6 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0)
          num6 = 0;
        switch (num6)
        {
          default:
        }
      }
    }

    /// <summary>
    /// Сконвертировать из сериализованного объекта в сущность или объект
    /// </summary>
    /// <param name="obj">Сущность или объект, в который будут записаные десериализованные значения</param>
    /// <param name="dict">Словарь &lt;Свойство,Значение&gt;</param>
    /// <returns></returns>
    public object ConvertFromSerializable(
      object obj,
      IDictionary<string, string> dict,
      bool loadEntityIfExists = true)
    {
      if (dict == null)
        return obj;
      List<string> list = dict.Keys.ToList<string>();
      list.Sort();
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      foreach (string str1 in list)
      {
        string str2 = dict[str1];
        if (!string.IsNullOrWhiteSpace(str2))
          this.AddDictionaryByPath(str1, (object) str2, dictionary);
      }
      return this.ConvertFromSerializable(obj, (IDictionary<string, object>) dictionary, loadEntityIfExists);
    }

    /// <summary>Сериализовать сущность или объект в Json-строку</summary>
    /// <param name="obj">Сущность или объект</param>
    /// <returns>Сериализованная сущность</returns>
    public string Serialize(object obj) => this.Serialize(obj, (EntitySerializationSettings) null);

    /// <summary>Сериализовать сущность или объект в Json-строку</summary>
    /// <param name="obj">Сущность или объект</param>
    /// <param name="settings">Настройки сериализации</param>
    /// <returns>Сериализованная сущность</returns>
    public string Serialize(object obj, EntitySerializationSettings settings)
    {
      int num = 2;
      object serializable;
      while (true)
      {
        switch (num)
        {
          case 1:
            serializable = this.ConvertToSerializable(obj, settings);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 0 : 0;
            continue;
          case 2:
            Contract.ArgumentNotNull(obj, (string) EntityJsonSerializer.CV43EWBrNKSDAZ8S6FRi(1461625753 ^ 1461583889));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 1 : 1;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return (string) EntityJsonSerializer.RanddiBgW7lvLWxS0jHB((object) new JsonSerializer(), serializable);
    }

    /// <summary>Десериализовать сущность или объект из Json-строки</summary>
    /// <param name="json">Json-строка</param>
    /// <returns>Сущность или объект</returns>
    public object Deserialize(string json, Type type, bool loadEntityIfExists = true)
    {
      int num = 3;
      ExpandoObject serObj;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_4;
          case 2:
            EntityJsonSerializer.dtAtYPBr37LMjfr30FIk((object) type, EntityJsonSerializer.CV43EWBrNKSDAZ8S6FRi(236071375 ^ 236070381));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 0 : 0;
            continue;
          case 3:
            EntityJsonSerializer.dtAtYPBr37LMjfr30FIk((object) json, EntityJsonSerializer.CV43EWBrNKSDAZ8S6FRi(-1824388195 ^ -1824293517));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 2 : 1;
            continue;
          default:
            serObj = new JsonSerializer().Deserialize<ExpandoObject>(json);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 1 : 1;
            continue;
        }
      }
label_4:
      return this.ConvertFromSerializable((IDictionary<string, object>) serObj, type, loadEntityIfExists);
    }

    /// <summary>Десериализовать сущность или объект из Json-строки</summary>
    /// <param name="json">Json-строка</param>
    /// <param name="obj">Объект</param>
    /// <returns>Сущность или объект</returns>
    public object Deserialize(string json, object obj, bool loadEntityIfExists = true)
    {
      int num = 3;
      ExpandoObject serObj;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_4;
          case 2:
            EntityJsonSerializer.dtAtYPBr37LMjfr30FIk(obj, EntityJsonSerializer.CV43EWBrNKSDAZ8S6FRi(-87337865 ^ -87296001));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 0;
            continue;
          case 3:
            EntityJsonSerializer.dtAtYPBr37LMjfr30FIk((object) json, EntityJsonSerializer.CV43EWBrNKSDAZ8S6FRi(~-122002947 ^ 121956588));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 2;
            continue;
          default:
            serObj = new JsonSerializer().Deserialize<ExpandoObject>(json);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 1 : 1;
            continue;
        }
      }
label_4:
      return this.ConvertFromSerializable(obj, (IDictionary<string, object>) serObj, loadEntityIfExists);
    }

    /// <summary>Десериализовать в ExpandoObject из Json-строки</summary>
    /// <param name="json">Json-строка</param>
    /// <returns>ExpandoObject</returns>
    public ExpandoObject DeserializeJson(string json)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            EntityJsonSerializer.dtAtYPBr37LMjfr30FIk((object) json, EntityJsonSerializer.CV43EWBrNKSDAZ8S6FRi(~-122002947 ^ 121956588));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return new JsonSerializer().Deserialize<ExpandoObject>(json);
    }

    /// <summary>
    /// Функция, определяющая нужно ли биндить значения свойств сущности
    /// </summary>
    public Func<IEntity, bool> NeedBindProperties { get; set; }

    /// <summary>
    /// Функция определяющая, требуется ли данное свойство при обработке.
    /// Для пропуска свойства необходимо возвращать <c>false</c>
    /// </summary>
    public Func<PropertyMetadata, bool> PropertyFilter { get; set; }

    /// <summary>
    /// Функция определяющая, требуется ли данный блок при обработке
    /// Для пропуска блок необходимо возвращать <c>false</c>
    /// </summary>
    [Obsolete("Свойство устарело, используйте вместо него NeedBindTablePart", true)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public Func<TablePartMetadata, bool> TablePartFilter { get; set; }

    /// <summary>
    /// Функция определяющая, требуется ли данный блок при обработке
    /// Для пропуска блок необходимо возвращать <c>false</c>
    /// </summary>
    public Func<ITablePartMetadata, bool> NeedBindTablePart { get; set; }

    /// <summary>Добавить ссылку на указатель сериализатора</summary>
    /// <param name="serializerMarker">Указатель сериализатора</param>
    internal static void AddSerializerMarker(object serializerMarker)
    {
      int num = 3;
      object serializerMarker1;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            serializerMarker1 = serializerMarker;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
            continue;
          case 3:
            num = 2;
            continue;
          default:
            ContextVars.GetOrAdd<object>((string) EntityJsonSerializer.CV43EWBrNKSDAZ8S6FRi(372753449 ^ 372683475), (Func<object>) (() => serializerMarker1));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 1 : 0;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Выполнить действия после сериализации</summary>
    /// <param name="serializerMarker">Указатель сериализатора</param>
    internal static void InvokeActions(object serializerMarker)
    {
      int num1 = 8;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          object obj;
          List<System.Action> actionList;
          List<System.Action>.Enumerator enumerator;
          switch (num2)
          {
            case 1:
            case 2:
              goto label_8;
            case 3:
              if (!ContextVars.TryGetValue<List<System.Action>>((string) EntityJsonSerializer.CV43EWBrNKSDAZ8S6FRi(92412609 - 1050237057 ^ -957762200), out actionList))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 1 : 1;
                continue;
              }
              goto case 4;
            case 4:
              enumerator = actionList.GetEnumerator();
              num2 = 5;
              continue;
            case 5:
              try
              {
label_14:
                if (enumerator.MoveNext())
                  goto label_16;
                else
                  goto label_15;
label_13:
                int num3;
                switch (num3)
                {
                  case 1:
                    goto label_16;
                  case 2:
                    goto label_14;
                  default:
                    goto label_11;
                }
label_15:
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 0 : 0;
                goto label_13;
label_16:
                EntityJsonSerializer.TH2EQ4BgobdldpA1Pbs8((object) enumerator.Current);
                num3 = 2;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
                {
                  num3 = 2;
                  goto label_13;
                }
                else
                  goto label_13;
              }
              finally
              {
                enumerator.Dispose();
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
                  num4 = 0;
                switch (num4)
                {
                  default:
                }
              }
            case 6:
              goto label_24;
            case 7:
              goto label_21;
            case 8:
              if (!ContextVars.TryGetValue<object>((string) EntityJsonSerializer.CV43EWBrNKSDAZ8S6FRi(-1638402543 ^ -1638498069), out obj))
              {
                num2 = 7;
                continue;
              }
              break;
            case 9:
label_11:
              EntityJsonSerializer.R6qo3qBgbGBY88iOhP6S(EntityJsonSerializer.CV43EWBrNKSDAZ8S6FRi(-2106517564 ^ -2106564372));
              num2 = 2;
              continue;
          }
          if (obj == serializerMarker)
            num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 3 : 3;
          else
            goto label_23;
        }
label_8:
        EntityJsonSerializer.R6qo3qBgbGBY88iOhP6S(EntityJsonSerializer.CV43EWBrNKSDAZ8S6FRi(-2092274397 << 4 ^ 883401930));
        num1 = 6;
      }
label_24:
      return;
label_21:
      return;
label_23:;
    }

    /// <summary>
    /// Добавить действие, которое необходимо выполнить после сериализации
    /// </summary>
    /// <param name="action">Действие</param>
    internal static void AddAction(System.Action action)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ContextVars.GetOrAdd<List<System.Action>>((string) EntityJsonSerializer.CV43EWBrNKSDAZ8S6FRi(-244066886 - -48452443 ^ -195666371), (Func<List<System.Action>>) (() => new List<System.Action>())).Add(action);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Попытаться десериализовать идентификатор сущности</summary>
    /// <param name="dictionary">Словарь, который может содержать идентификатор (в ключе Id)</param>
    /// <param name="entityType">Тип сущности</param>
    /// <returns>Идентификатор сущности нужного типа</returns>
    protected virtual object TryDeserializeEntityId(
      IDictionary<string, object> dictionary,
      Type entityType)
    {
      object idValue;
      return dictionary != null && dictionary.TryGetValue(EntityJsonSerializer.IdPropertyName, out idValue) ? ModelHelper.TryConvertEntityId(entityType, idValue) : (object) null;
    }

    /// <summary>
    /// Попытаться десериализовать уникальный идентификатор сущности
    /// </summary>
    /// <param name="dictionary">Словарь, который может содержать уникальный идентификатор (в ключе Uid)</param>
    /// <returns>Уникальный идентификатор сущности (или null)</returns>
    protected virtual Guid? TryDeserializeEntityUid(IDictionary<string, object> dictionary)
    {
      object obj;
      Guid result;
      return dictionary != null && dictionary.TryGetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978482848), out obj) && obj != null && Guid.TryParse(obj.ToString(), out result) ? new Guid?(result) : new Guid?();
    }

    public EntityJsonSerializer()
    {
      EntityJsonSerializer.YQHaNoBghix4E9dWAt20();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static EntityJsonSerializer()
    {
      int num = 4;
      ParameterExpression parameterExpression;
      while (true)
      {
        switch (num)
        {
          case 1:
            // ISSUE: type reference
            // ISSUE: type reference
            // ISSUE: explicit non-virtual call
            EntityJsonSerializer.ConvertFromSerializableCall = __nonvirtual (EntityJsonSerializer.DLOkrDBgGaVU18Di8uRB(__typeref (EntityJsonSerializer)).GetMethod((string) EntityJsonSerializer.CV43EWBrNKSDAZ8S6FRi(1021410165 ^ 1021316123), new Type[3]
            {
              typeof (object),
              typeof (IDictionary<string, object>),
              EntityJsonSerializer.DLOkrDBgGaVU18Di8uRB(__typeref (bool))
            }));
            num = 5;
            continue;
          case 2:
            // ISSUE: method reference
            // ISSUE: type reference
            EntityJsonSerializer.IdPropertyName = LinqUtils.NameOf<IEntity<object>>(Expression.Lambda<Func<IEntity<object>, object>>((Expression) EntityJsonSerializer.aLMOSnBgQhfCQuutRluR((object) parameterExpression, (object) (MethodInfo) EntityJsonSerializer.rYdVrwBgfn6GkHDiK6Ot(__methodref (IEntity<object>.get_Id), __typeref (IEntity<object>))), parameterExpression));
            num = 6;
            continue;
          case 3:
            // ISSUE: type reference
            EntityJsonSerializer.OwnerType = EntityJsonSerializer.DLOkrDBgGaVU18Di8uRB(__typeref (EntityJsonSerializer));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
            continue;
          case 4:
            EntityJsonSerializer.YQHaNoBghix4E9dWAt20();
            num = 3;
            continue;
          case 5:
            // ISSUE: type reference
            parameterExpression = (ParameterExpression) EntityJsonSerializer.OM87ePBgEafJ2qSd3ad2(EntityJsonSerializer.DLOkrDBgGaVU18Di8uRB(__typeref (IEntity<object>)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~1767720452 ^ -1767755309));
            num = 2;
            continue;
          case 6:
            goto label_2;
          default:
            // ISSUE: type reference
            // ISSUE: type reference
            // ISSUE: explicit non-virtual call
            EntityJsonSerializer.ConvertToSerializableCall = __nonvirtual (EntityJsonSerializer.DLOkrDBgGaVU18Di8uRB(__typeref (EntityJsonSerializer)).GetMethod((string) EntityJsonSerializer.CV43EWBrNKSDAZ8S6FRi(-488881205 ^ -488819573), new Type[2]
            {
              typeof (object),
              EntityJsonSerializer.DLOkrDBgGaVU18Di8uRB(__typeref (EntitySerializationSettings))
            }));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 1 : 0;
            continue;
        }
      }
label_2:;
    }

    internal static bool j08Z3pBrPON0by2K6OOj() => EntityJsonSerializer.WgwoIsBreZxYoYOUmtth == null;

    internal static EntityJsonSerializer oW6XAfBr1TqdlS4e6Uit() => EntityJsonSerializer.WgwoIsBreZxYoYOUmtth;

    internal static object CV43EWBrNKSDAZ8S6FRi(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void dtAtYPBr37LMjfr30FIk([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static object ELM1vCBrpJqE1h8INrAs([In] object obj0) => obj0.CastAsRealType();

    internal static bool IcBTPaBrajQixJIkmFEk([In] object obj0) => ((EntitySerializationSettings) obj0).WriteReferences;

    internal static object xWVskSBrDKR1fTolQB4W() => (object) ReferenceResolverSerializer.CurrentResolver;

    internal static object tBVp43BrtBxyxSSMQkj0(bool needResolver) => (object) ReferenceResolverSerializer.CreateResolver(needResolver);

    internal static EntitySerializationMode AbjLE8BrwZsCgPlG48pi([In] object obj0) => ((EntitySerializationSettings) obj0).Mode;

    internal static bool QLCJI0Br4XcKqKfuNXVB([In] object obj0) => ((IEntity) obj0).IsNew();

    internal static Guid chbMOVBr6iCd0igt8IYm([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static object dnj12rBrH3DsMvnkrW3a(Type entityType) => (object) ModelHelper.GetEntityManager(entityType);

    internal static object L0eTMhBrAsYS2YYDfW7c([In] object obj0) => (object) ((IEntity) obj0).GetDirtyPropertyUids();

    internal static object sRRdGoBr7eiXsaBqQb4p([In] object obj0) => ((EntitySerializationSettings) obj0).OriginalState;

    internal static object bqcpbxBrxNwAqZVwFPgd() => (object) MetadataServiceContext.Service;

    internal static bool Hf97Z1Br0FSnTqEaGB1A([In] object obj0) => ((EntitySerializationSettings) obj0).CheckPropertyPermissions;

    internal static Guid V4Hof2Brm0w0WBeGuE8x([In] object obj0) => ((PropertyMetadata) obj0).TypeUid;

    internal static Guid AIBoY6BryqQihLylklFb([In] object obj0) => ((PropertyMetadata) obj0).SubTypeUid;

    internal static object HbpRqlBrMZ855HvM8iS0([In] object obj0, Guid typeUid, Guid subTypeUid) => (object) ((IMetadataService) obj0).GetTypeDescriptor(typeUid, subTypeUid);

    internal static object gIrWvBBrJH5uQ9iaduLl([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static object D6akmUBr9N6mGgevZR6k([In] object obj0, [In] object obj1, [In] object obj2) => obj0.GetPropertyValue((string) obj1, obj2);

    internal static object JIbcIeBrdSCTWs6s5Vva([In] object obj0) => (object) ((EntitySerializationSettings) obj0).Functions;

    internal static object eu9MqaBrlpca1JPpJqtc(
      [In] object obj0,
      bool createIfNotExists,
      bool loadIfNotLoaded)
    {
      return (object) ((IEntity) obj0).LoadSettingsInstanceStore(createIfNotExists, loadIfNotLoaded);
    }

    internal static object kDglQ5BrrCkM5SflOkIH([In] object obj0) => (object) ((ITypeSettingsInstanceStore) obj0).Settings;

    internal static int jr59I2BrgiCr4i7MX2eS([In] object obj0) => ((List<TypeSettingsInstanceData.DataItem>) obj0).Count;

    internal static Guid iE5FM0Br5Y2AMx24nypq([In] object obj0) => ((ITablePartMetadata) obj0).TablePartPropertyUid;

    internal static object SoBUMMBrjxwVcAwfuCnI([In] object obj0) => (object) ((ITablePartMetadata) obj0).TablePartPropertyName;

    internal static object HyLDxABrYTNTc1q1Z0iC([In] object obj0, Guid propertyUid) => ((IEntity) obj0).GetPropertyValue(propertyUid);

    internal static object oGhD9aBrLhLkLRSGH2Mr([In] object obj0) => (object) ((IEnumerable) obj0).GetEnumerator();

    internal static object xD6YjPBrU3slIB069iFj([In] object obj0) => ((IEnumerator) obj0).Current;

    internal static void S2JZIsBrsKd90OvN4Nbg([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static void nYHrVXBrcHNJMSIeSIs4([In] object obj0, [In] object obj1) => ((AbstractCallInfo) obj0).Exception = (Exception) obj1;

    internal static object OXSpVQBrzGjIFhVUkL8o([In] object obj0) => (object) ((NameValueCollection) obj0).AllKeys;

    internal static object QW1cgeBgFPfBE44HCOUB([In] object obj0, [In] object obj1) => (object) ((NameValueCollection) obj0)[(string) obj1];

    internal static bool I6AyW3BgBQveuYTuRGuX([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static object RanddiBgW7lvLWxS0jHB([In] object obj0, [In] object obj1) => (object) ((JavaScriptSerializer) obj0).Serialize(obj1);

    internal static void TH2EQ4BgobdldpA1Pbs8([In] object obj0) => ((System.Action) obj0)();

    internal static void R6qo3qBgbGBY88iOhP6S([In] object obj0) => ContextVars.Remove((string) obj0);

    internal static void YQHaNoBghix4E9dWAt20() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static Type DLOkrDBgGaVU18Di8uRB([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object OM87ePBgEafJ2qSd3ad2([In] Type obj0, [In] object obj1) => (object) Expression.Parameter(obj0, (string) obj1);

    internal static object rYdVrwBgfn6GkHDiK6Ot([In] RuntimeMethodHandle obj0, [In] RuntimeTypeHandle obj1) => (object) MethodBase.GetMethodFromHandle(obj0, obj1);

    internal static object aLMOSnBgQhfCQuutRluR([In] object obj0, [In] object obj1) => (object) Expression.Property((Expression) obj0, (MethodInfo) obj1);
  }
}
