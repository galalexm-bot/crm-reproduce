// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Providers.NHProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using Autofac;
using Autofac.Builder;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Runtime.Db;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Exceptions;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Runtime.NH.Listeners;
using EleWise.ELMA.Runtime.NH.Proxy;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Cfg.Loquacious;
using NHibernate.Cfg.MappingSchema;
using NHibernate.Criterion;
using NHibernate.Engine;
using NHibernate.Event;
using NHibernate.Mapping.ByCode;
using NHibernate.SqlCommand;
using NHibernate.Tool.hbm2ddl;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.Providers
{
  /// <summary>Базовый класс для провайдеров БД на основе NHibernate</summary>
  public abstract class NHProvider : 
    AbstractProvider,
    IMainDatabaseProvider,
    IProvider,
    IConfigurableProvider,
    IDisposable
  {
    private DbStructure[] dbStructures;
    internal static NHProvider h1sdPJWEPb0S33mFM7dv;

    public abstract string ConnectionString { get; }

    public abstract string DataProviderName { get; }

    public virtual bool Enabled
    {
      get => this.\u003CEnabled\u003Ek__BackingField;
      protected set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CEnabled\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 0 : 0;
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

    /// <summary>
    /// Начать инициализацию.
    /// Доступен <see cref="P:EleWise.ELMA.ComponentModel.ComponentManager.Current" /> и <see cref="P:EleWise.ELMA.ComponentModel.ComponentManager.Builder" />
    /// </summary>
    public override void Init()
    {
      int num1 = 2;
      IStartInformation startInformation1;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_154;
          case 1:
            goto label_2;
          case 2:
            startInformation1 = (IStartInformation) NHProvider.t2saf6WEpS98FQCvbhef(100.0, (object) EleWise.ELMA.SR.M((string) NHProvider.HeKR9RWE3F1PkePe16DB(-1380439818 << 3 ^ 1841358602)));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 1 : 1;
            continue;
          default:
            goto label_149;
        }
      }
label_154:
      return;
label_149:
      return;
label_2:
      try
      {
        this.InitInternal();
        int num2 = 13;
        while (true)
        {
          int num3;
          IEnumerable<INHManagerRegistrar> extensionPoints;
          IStartInformation startInformation2;
          IRuntimeApplication serviceNotNull;
          NHManagerRegisterParams parameters;
          SessionFactoryHolder instance;
          NHibernate.Cfg.Configuration configuration;
          IEnumerator<INHProviderDependentUserTypeRegistrar> enumerator1;
          switch (num2)
          {
            case 1:
              try
              {
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0)
                  num4 = 0;
                IEnumerable<IDbStructureExtension> structureExtensions;
                HbmMapping hbmMapping;
                IStartInformation startInformation3;
                IEnumerable<string> deactivatingModules;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      deactivatingModules = ((DbPreUpdater) NHProvider.VGWMDbWEyswbndfAuIct((object) serviceNotNull)).GetDeactivatingModules();
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 12 : 1;
                      continue;
                    case 2:
                      structureExtensions = this.SortDbStructures(structureExtensions);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 1 : 0;
                      continue;
                    case 3:
                      NHProvider.eYf7nTWEYCS78w69Ih1c((object) configuration, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1669212571 ^ 1669302939), (object) TZ.ServerOffset.ToString());
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 8 : 7;
                      continue;
                    case 4:
                      NHProvider.eYf7nTWEYCS78w69Ih1c((object) configuration, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1858993163), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1033719030 - 2012070891 ^ -978441333));
                      num4 = 3;
                      continue;
                    case 5:
                      try
                      {
                        hbmMapping = (HbmMapping) NHProvider.qkDsKjWEJlchZ8XDkljE(NHProvider.Jy62nhWEM7qe9YY1KXPB((object) parameters));
                        int num5 = 0;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
                          num5 = 0;
                        while (true)
                        {
                          switch (num5)
                          {
                            case 1:
                              goto label_68;
                            default:
                              hbmMapping.defaultaccess = typeof (EntityPropertyAccessor).AssemblyQualifiedName;
                              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 1;
                              continue;
                          }
                        }
                      }
                      finally
                      {
                        int num6;
                        if (startInformation3 == null)
                          num6 = 2;
                        else
                          goto label_65;
label_64:
                        switch (num6)
                        {
                          case 1:
                            break;
                          default:
                        }
label_65:
                        NHProvider.ubHXZOWE6Vou1NCIHia3((object) startInformation3);
                        num6 = 0;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0)
                        {
                          num6 = 0;
                          goto label_64;
                        }
                        else
                          goto label_64;
                      }
                    case 6:
                      try
                      {
                        // ISSUE: reference to a compiler-generated method
                        IEnumerator<DbStructure> enumerator2 = ((IEnumerable<DbStructure>) this.dbStructures).Where<DbStructure>((Func<DbStructure, bool>) (db => !NHProvider.\u003C\u003Ec.d6oJk0QNtC0AUirAVlxe((object) db))).GetEnumerator();
                        int num7 = 0;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
                          num7 = 0;
                        switch (num7)
                        {
                          default:
                            try
                            {
label_91:
                              if (NHProvider.RNjLyPWE42Y6SZYis3QZ((object) enumerator2))
                                goto label_89;
                              else
                                goto label_92;
label_74:
                              DbStructure current1;
                              Dictionary<string, DbStructure.DbProcedure>.ValueCollection.Enumerator enumerator3;
                              Dictionary<string, DbStructure.DbView>.ValueCollection.Enumerator enumerator4;
                              int num8;
                              while (true)
                              {
                                switch (num8)
                                {
                                  case 1:
label_90:
                                    enumerator4 = current1.Views.Values.GetEnumerator();
                                    num8 = 2;
                                    continue;
                                  case 2:
                                    goto label_93;
                                  case 3:
                                    goto label_120;
                                  case 4:
                                    try
                                    {
label_79:
                                      if (enumerator3.MoveNext())
                                        goto label_81;
                                      else
                                        goto label_80;
label_77:
                                      DbStructure.DbProcedure current2;
                                      int num9;
                                      while (true)
                                      {
                                        switch (num9)
                                        {
                                          case 1:
                                            if (NHProvider.udr4LiWErhmyAf8Nuv3G(NHProvider.XSgZiJWElg9VF5y9MOYU((object) current2)))
                                            {
                                              num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 2 : 0;
                                              continue;
                                            }
                                            goto case 5;
                                          case 2:
                                          case 3:
                                            goto label_79;
                                          case 4:
                                            goto label_90;
                                          case 5:
                                            NHProvider.FnvR49WEgeMKyGVgUW9r((object) configuration, (object) current2.Mappings);
                                            num9 = 3;
                                            continue;
                                          default:
                                            goto label_81;
                                        }
                                      }
label_80:
                                      num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 3 : 4;
                                      goto label_77;
label_81:
                                      current2 = enumerator3.Current;
                                      num9 = 1;
                                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
                                      {
                                        num9 = 1;
                                        goto label_77;
                                      }
                                      else
                                        goto label_77;
                                    }
                                    finally
                                    {
                                      enumerator3.Dispose();
                                      int num10 = 0;
                                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
                                        num10 = 0;
                                      switch (num10)
                                      {
                                        default:
                                      }
                                    }
                                  case 5:
                                    goto label_89;
                                  case 6:
                                    enumerator3 = current1.Procedures.Values.GetEnumerator();
                                    num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 4;
                                    continue;
                                  default:
                                    goto label_91;
                                }
                              }
label_93:
                              try
                              {
label_100:
                                if (enumerator4.MoveNext())
                                  goto label_95;
                                else
                                  goto label_101;
label_94:
                                DbStructure.DbView current3;
                                int num11;
                                while (true)
                                {
                                  switch (num11)
                                  {
                                    case 1:
                                      NHProvider.FnvR49WEgeMKyGVgUW9r((object) configuration, NHProvider.kihwtxWE5fTvHCWRUL3J((object) current3));
                                      num11 = 2;
                                      continue;
                                    case 2:
                                    case 3:
                                      goto label_100;
                                    case 4:
                                      goto label_91;
                                    case 5:
                                      if (NHProvider.udr4LiWErhmyAf8Nuv3G(NHProvider.kihwtxWE5fTvHCWRUL3J((object) current3)))
                                      {
                                        num11 = 3;
                                        continue;
                                      }
                                      goto case 1;
                                    default:
                                      goto label_95;
                                  }
                                }
label_95:
                                current3 = enumerator4.Current;
                                num11 = 5;
                                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
                                {
                                  num11 = 1;
                                  goto label_94;
                                }
                                else
                                  goto label_94;
label_101:
                                num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 3 : 4;
                                goto label_94;
                              }
                              finally
                              {
                                enumerator4.Dispose();
                                int num12 = 0;
                                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
                                  num12 = 0;
                                switch (num12)
                                {
                                  default:
                                }
                              }
label_89:
                              current1 = enumerator2.Current;
                              num8 = 6;
                              goto label_74;
label_92:
                              num8 = 3;
                              goto label_74;
                            }
                            finally
                            {
                              int num13;
                              if (enumerator2 == null)
                                num13 = 2;
                              else
                                goto label_109;
label_108:
                              switch (num13)
                              {
                                case 1:
                                case 2:
                              }
label_109:
                              NHProvider.ubHXZOWE6Vou1NCIHia3((object) enumerator2);
                              num13 = 0;
                              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
                              {
                                num13 = 1;
                                goto label_108;
                              }
                              else
                                goto label_108;
                            }
                        }
                      }
                      finally
                      {
                        if (startInformation3 != null)
                        {
                          int num14 = 0;
                          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
                            num14 = 0;
                          while (true)
                          {
                            switch (num14)
                            {
                              case 1:
                                goto label_117;
                              default:
                                NHProvider.ubHXZOWE6Vou1NCIHia3((object) startInformation3);
                                num14 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 1 : 1;
                                continue;
                            }
                          }
                        }
label_117:;
                      }
                    case 7:
label_119:
                      startInformation3 = (IStartInformation) NHProvider.t2saf6WEpS98FQCvbhef(97.0, NHProvider.th4tViWE0kDOJwC5x96v(NHProvider.HeKR9RWE3F1PkePe16DB(--1418440330 ^ 1418333320)));
                      num4 = 6;
                      continue;
                    case 8:
                      goto label_131;
                    case 9:
label_68:
                      startInformation3 = (IStartInformation) NHProvider.t2saf6WEpS98FQCvbhef(88.0, NHProvider.th4tViWE0kDOJwC5x96v(NHProvider.HeKR9RWE3F1PkePe16DB(333888594 ^ 1075625116 ^ 1408999796)));
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 2 : 10;
                      continue;
                    case 10:
                      try
                      {
                        configuration = (NHibernate.Cfg.Configuration) NHProvider.a2KfrOWE91Imh7KtBiAc((object) this);
                        int num15 = 0;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0)
                          num15 = 0;
                        while (true)
                        {
                          switch (num15)
                          {
                            case 1:
                              goto label_119;
                            default:
                              NHProvider.qkBNKJWEdfeRMClZBoCB((object) configuration, (object) hbmMapping);
                              num15 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 1 : 1;
                              continue;
                          }
                        }
                      }
                      finally
                      {
                        int num16;
                        if (startInformation3 == null)
                          num16 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 0 : 0;
                        else
                          goto label_55;
label_54:
                        switch (num16)
                        {
                          case 2:
                            break;
                          default:
                        }
label_55:
                        NHProvider.ubHXZOWE6Vou1NCIHia3((object) startInformation3);
                        num16 = 0;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
                        {
                          num16 = 1;
                          goto label_54;
                        }
                        else
                          goto label_54;
                      }
                    case 11:
                      startInformation3 = StartInformation.Operation(60.0, (string) NHProvider.th4tViWE0kDOJwC5x96v(NHProvider.HeKR9RWE3F1PkePe16DB(-1487388570 ^ -1487281674)));
                      num4 = 5;
                      continue;
                    case 12:
                      this.dbStructures = structureExtensions.Select<IDbStructureExtension, DbStructure>((Func<IDbStructureExtension, DbStructure>) (db =>
                      {
                        int num17 = 6;
                        DbStructure dbStructure;
                        while (true)
                        {
                          int num18 = num17;
                          IModule module;
                          while (true)
                          {
                            switch (num18)
                            {
                              case 1:
                                // ISSUE: reference to a compiler-generated method
                                NHProvider.\u003C\u003Ec__DisplayClass8_0.GKWZNHQNND8f6obLRFAy((object) dbStructure, true);
                                num18 = 8;
                                continue;
                              case 2:
                                // ISSUE: reference to a compiler-generated method
                                // ISSUE: reference to a compiler-generated method
                                module = (IModule) NHProvider.\u003C\u003Ec__DisplayClass8_0.aC0PbTQNP38NWyRTxlQu((object) ((ComponentManager) NHProvider.\u003C\u003Ec__DisplayClass8_0.NlLstBQNe3ZvnfSPkXvP()).ModuleManager, (object) db.GetType().Assembly);
                                num18 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
                                continue;
                              case 3:
                                // ISSUE: reference to a compiler-generated method
                                if (!((ComponentManager) NHProvider.\u003C\u003Ec__DisplayClass8_0.NlLstBQNe3ZvnfSPkXvP()).ModuleManager.IsAssemblyAvailable(db.GetType().Assembly))
                                {
                                  num18 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 2 : 2;
                                  continue;
                                }
                                goto label_11;
                              case 4:
                                // ISSUE: reference to a compiler-generated method
                                if (deactivatingModules.Contains<string>((string) NHProvider.\u003C\u003Ec__DisplayClass8_0.AppqkuQN1jR2wkd0iu3m((object) module)))
                                  goto case 1;
                                else
                                  goto label_4;
                              case 5:
                                if (dbStructure != null)
                                {
                                  num18 = 3;
                                  continue;
                                }
                                goto label_12;
                              case 6:
                                // ISSUE: reference to a compiler-generated method
                                dbStructure = (DbStructure) NHProvider.\u003C\u003Ec__DisplayClass8_0.TBlkynQN2raTja1DwYno((object) db);
                                num18 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 5 : 0;
                                continue;
                              case 7:
                                goto label_10;
                              case 8:
                                goto label_9;
                              case 9:
                                goto label_12;
                              default:
                                if (module != null)
                                {
                                  num18 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 1 : 4;
                                  continue;
                                }
                                goto label_10;
                            }
                          }
label_4:
                          num17 = 7;
                        }
label_9:
                        return dbStructure;
label_10:
                        return (DbStructure) null;
label_11:
                        return dbStructure;
label_12:
                        return (DbStructure) null;
                      })).Where<DbStructure>((Func<DbStructure, bool>) (s => s != null)).ToArray<DbStructure>();
                      num4 = 11;
                      continue;
                    case 13:
label_120:
                      NHProvider.kSlA2dWEjYR3rSeWWwdq((object) configuration);
                      num4 = 4;
                      continue;
                    default:
                      structureExtensions = ((ComponentManager) NHProvider.uWDe7UWEtqeS2Xx4CPeC()).GetExtensionPoints<IDbStructureExtension>().Where<IDbStructureExtension>((Func<IDbStructureExtension, bool>) (db =>
                      {
                        int num19 = 1;
                        while (true)
                        {
                          switch (num19)
                          {
                            case 1:
                              if (NHProvider.IJVGXiWfCCI0Eh1Rr2Rg(NHProvider.m0aRYsWfYrYqHXfylIwd((object) db), NHProvider.twb10qWfj6Qd8pYRnvNf((object) this)))
                              {
                                num19 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 0 : 0;
                                continue;
                              }
                              goto label_4;
                            case 2:
                              goto label_4;
                            default:
                              goto label_5;
                          }
                        }
label_4:
                        return NHProvider.IJVGXiWfCCI0Eh1Rr2Rg(NHProvider.m0aRYsWfYrYqHXfylIwd((object) db), Guid.Empty);
label_5:
                        return true;
                      }));
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 2 : 2;
                      continue;
                  }
                }
              }
              finally
              {
                if (startInformation2 != null)
                {
                  int num20 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
                    num20 = 0;
                  while (true)
                  {
                    switch (num20)
                    {
                      case 1:
                        goto label_130;
                      default:
                        NHProvider.ubHXZOWE6Vou1NCIHia3((object) startInformation2);
                        num20 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 1 : 1;
                        continue;
                    }
                  }
                }
label_130:;
              }
            case 2:
label_19:
              NHProvider.tg2v2kWEmu2d44oMPfdY();
              num3 = 3;
              break;
            case 3:
              startInformation2 = StartInformation.Operation(93.0, EleWise.ELMA.SR.M((string) NHProvider.HeKR9RWE3F1PkePe16DB(1113862659 ^ 1113953099)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 0 : 1;
              continue;
            case 4:
label_131:
              instance = new SessionFactoryHolder(configuration);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 14 : 7;
              continue;
            case 5:
label_17:
              ((ContainerBuilder) NHProvider.eCJp2qWEaNQrMnTxUngj()).RegisterInstance<SessionFactoryHolder>(instance).SingleInstance();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 4 : 8;
              continue;
            case 6:
label_5:
              extensionPoints = ((ComponentManager) NHProvider.uWDe7UWEtqeS2Xx4CPeC()).GetExtensionPoints<INHManagerRegistrar>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 0 : 0;
              continue;
            case 7:
              try
              {
                IEnumerator<INHManagerRegistrar> enumerator5 = extensionPoints.GetEnumerator();
                int num21 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
                  num21 = 0;
                switch (num21)
                {
                  default:
                    try
                    {
label_26:
                      if (NHProvider.RNjLyPWE42Y6SZYis3QZ((object) enumerator5))
                        goto label_28;
                      else
                        goto label_27;
label_25:
                      int num22;
                      switch (num22)
                      {
                        case 1:
                          goto label_19;
                        case 2:
                          goto label_28;
                        default:
                          goto label_26;
                      }
label_27:
                      num22 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 1 : 1;
                      goto label_25;
label_28:
                      enumerator5.Current.Register(parameters);
                      num22 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
                      {
                        num22 = 0;
                        goto label_25;
                      }
                      else
                        goto label_25;
                    }
                    finally
                    {
                      int num23;
                      if (enumerator5 == null)
                        num23 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 0 : 0;
                      else
                        goto label_33;
label_32:
                      switch (num23)
                      {
                        case 1:
                          break;
                        default:
                      }
label_33:
                      NHProvider.ubHXZOWE6Vou1NCIHia3((object) enumerator5);
                      num23 = 2;
                      goto label_32;
                    }
                }
              }
              finally
              {
                if (startInformation2 != null)
                {
                  int num24 = 1;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
                    num24 = 1;
                  while (true)
                  {
                    switch (num24)
                    {
                      case 1:
                        startInformation2.Dispose();
                        num24 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_40;
                    }
                  }
                }
label_40:;
              }
            case 8:
              NHProvider.OZMgW0WEULCnZpPm5FET((object) this, true);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 2 : 17;
              continue;
            case 9:
              try
              {
                NHProvider.CrLeqZWELU3FExsmGiMI((object) instance);
                int num25 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
                  num25 = 0;
                switch (num25)
                {
                  default:
                    goto label_17;
                }
              }
              finally
              {
                int num26;
                if (startInformation2 == null)
                  num26 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 0 : 0;
                else
                  goto label_14;
label_13:
                switch (num26)
                {
                  case 2:
                    break;
                  default:
                }
label_14:
                NHProvider.ubHXZOWE6Vou1NCIHia3((object) startInformation2);
                num26 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
                {
                  num26 = 1;
                  goto label_13;
                }
                else
                  goto label_13;
              }
            case 10:
              NHProvider.tGfbSXWExMlfxQMrsju9(NHProvider.ifvQwOWE7kfYKACEOlr4((object) this));
              num2 = 12;
              continue;
            case 11:
              try
              {
label_139:
                if (NHProvider.RNjLyPWE42Y6SZYis3QZ((object) enumerator1))
                  goto label_137;
                else
                  goto label_140;
label_136:
                int num27;
                switch (num27)
                {
                  case 1:
                    break;
                  case 2:
                    goto label_139;
                  default:
                    goto label_5;
                }
label_137:
                NHProvider.rCCZEdWEw0C9hYyRBlGF((object) enumerator1.Current);
                num27 = 2;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
                {
                  num27 = 2;
                  goto label_136;
                }
                else
                  goto label_136;
label_140:
                num27 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 0;
                goto label_136;
              }
              finally
              {
                int num28;
                if (enumerator1 == null)
                  num28 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 0 : 0;
                else
                  goto label_144;
label_143:
                switch (num28)
                {
                  case 2:
                    break;
                  default:
                }
label_144:
                NHProvider.ubHXZOWE6Vou1NCIHia3((object) enumerator1);
                num28 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
                {
                  num28 = 1;
                  goto label_143;
                }
                else
                  goto label_143;
              }
            case 12:
              startInformation2 = (IStartInformation) NHProvider.t2saf6WEpS98FQCvbhef(91.0, NHProvider.th4tViWE0kDOJwC5x96v(NHProvider.HeKR9RWE3F1PkePe16DB(-1350312861 << 3 ^ 2082423296)));
              num2 = 7;
              continue;
            case 13:
              ((ContainerBuilder) NHProvider.eCJp2qWEaNQrMnTxUngj()).RegisterType(NHProvider.t3CDWlWEDqpKO4UHE6rd((object) this)).As<ITransformationProvider>().As<ITransformationProviderAsync>().SingleInstance().PropertiesAutowired<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 16 : 0;
              continue;
            case 14:
              startInformation2 = (IStartInformation) NHProvider.t2saf6WEpS98FQCvbhef(100.0, NHProvider.th4tViWE0kDOJwC5x96v(NHProvider.HeKR9RWE3F1PkePe16DB(87862435 ^ 87887763)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 9 : 1;
              continue;
            case 15:
              NHManagerRegisterParams managerRegisterParams = new NHManagerRegisterParams();
              NHProvider.mSt1FTWEH4S9dZ4igr97((object) managerRegisterParams, (object) ComponentManager.Builder);
              managerRegisterParams.TransformationProvider = (ITransformationProvider) NHProvider.lLlQkrWEAMdbnK3PVc8l((object) serviceNotNull);
              parameters = managerRegisterParams;
              num3 = 10;
              break;
            case 16:
              enumerator1 = ((ComponentManager) NHProvider.uWDe7UWEtqeS2Xx4CPeC()).GetExtensionPoints<INHProviderDependentUserTypeRegistrar>().Where<INHProviderDependentUserTypeRegistrar>((Func<INHProviderDependentUserTypeRegistrar, bool>) (registrar => NHProvider.IJVGXiWfCCI0Eh1Rr2Rg(NHProvider.pjWS22Wf5EUq1e6PDuQi((object) registrar), NHProvider.twb10qWfj6Qd8pYRnvNf((object) this)))).GetEnumerator();
              num2 = 11;
              continue;
            case 17:
              goto label_146;
            default:
              serviceNotNull = Locator.GetServiceNotNull<IRuntimeApplication>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 14 : 15;
              continue;
          }
          num2 = num3;
        }
label_146:;
      }
      finally
      {
        if (startInformation1 != null)
        {
          int num29 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
            num29 = 1;
          while (true)
          {
            switch (num29)
            {
              case 1:
                NHProvider.ubHXZOWE6Vou1NCIHia3((object) startInformation1);
                num29 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 0 : 0;
                continue;
              default:
                goto label_156;
            }
          }
        }
label_156:;
      }
    }

    /// <summary>
    /// Завершить инициализацию (вызывается после инициализации Locator-а)
    /// </summary>
    public override void InitComplete()
    {
      int num1 = 1;
      MetadataServiceContext metadataServiceContext;
      while (true)
      {
        switch (num1)
        {
          case 1:
            metadataServiceContext = MetadataServiceContext.New<IMetadataRuntimeService>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_63;
          default:
            goto label_3;
        }
      }
label_63:
      return;
label_3:
      try
      {
        DateTime dateTime = DateTime.Now;
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0)
          num2 = 1;
        IStartInformation startInformation;
        while (true)
        {
          switch (num2)
          {
            case 1:
              startInformation = (IStartInformation) NHProvider.t2saf6WEpS98FQCvbhef(40.0, NHProvider.th4tViWE0kDOJwC5x96v(NHProvider.HeKR9RWE3F1PkePe16DB(~1767720452 ^ -1767695737)));
              num2 = 5;
              continue;
            case 2:
label_32:
              NHProvider.AaZulgWfEEiepy2saa0J(NHProvider.oGZ3VPWfWGtL1AV5ZZjD(), NHProvider.CRjEMAWfFKBhhSk32Jok(NHProvider.HeKR9RWE3F1PkePe16DB(~-306453669 ^ 306560844), (object) (int) NHProvider.veOg29WfGu9YtB7Sd68c(NHProvider.ib6UP1WfhgQ5rsk5DpaD(), dateTime).TotalMilliseconds));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 4;
              continue;
            case 3:
              startInformation = (IStartInformation) NHProvider.t2saf6WEpS98FQCvbhef(91.0, (object) EleWise.ELMA.SR.M((string) NHProvider.HeKR9RWE3F1PkePe16DB(1033719030 - 2012070891 ^ -978440919)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 0 : 0;
              continue;
            case 4:
              dateTime = NHProvider.ib6UP1WfhgQ5rsk5DpaD();
              num2 = 3;
              continue;
            case 5:
              try
              {
                IDbUpdateHandler[] array = ComponentManager.Current.GetExtensionPoints<IDbUpdateHandler>().Where<IDbUpdateHandler>((Func<IDbUpdateHandler, bool>) (db =>
                {
                  int num3 = 1;
                  while (true)
                  {
                    switch (num3)
                    {
                      case 1:
                        if (!(NHProvider.LvRNe1WfLwEAKyMAm7fh((object) db) == this.Uid))
                        {
                          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 0;
                          continue;
                        }
                        goto label_3;
                      default:
                        goto label_2;
                    }
                  }
label_2:
                  return NHProvider.LvRNe1WfLwEAKyMAm7fh((object) db) == Guid.Empty;
label_3:
                  return true;
                })).ToArray<IDbUpdateHandler>();
                int num4 = 4;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
                  num4 = 2;
                IRuntimeApplication serviceNotNull;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                    case 6:
                      goto label_32;
                    case 2:
                      serviceNotNull = Locator.GetServiceNotNull<IRuntimeApplication>();
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 0 : 0;
                      continue;
                    case 3:
                      goto label_12;
                    case 4:
                      Locator.GetServiceNotNull<DbStructureReader>().Read((IEnumerable<DbStructure>) this.dbStructures, (IEnumerable<IDbUpdateHandler>) array);
                      num4 = 2;
                      continue;
                    case 5:
                      NHProvider.jE8Ll1WEcBbG99x0rNbF(NHProvider.lLlQkrWEAMdbnK3PVc8l((object) serviceNotNull));
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 3 : 3;
                      continue;
                    default:
                      if (!NHProvider.g5cNbuWEsiIKliCLOZQb((object) serviceNotNull))
                      {
                        num4 = 6;
                        continue;
                      }
                      goto case 5;
                  }
                }
label_12:
                try
                {
                  ((ITransformationProvider) NHProvider.lLlQkrWEAMdbnK3PVc8l((object) serviceNotNull)).ExecuteNonQuery((string) NHProvider.CRjEMAWfFKBhhSk32Jok(NHProvider.HeKR9RWE3F1PkePe16DB(-1998538950 ^ -1998572764), (object) ((EleWise.ELMA.Runtime.Db.Migrator.Providers.Dialect) NHProvider.A7OT4sWEzOKrJxMa36Oe((object) serviceNotNull.TransformationProvider)).QuoteIfNeeded((string) NHProvider.HeKR9RWE3F1PkePe16DB(92412609 - 1050237057 ^ -957786754))));
                  int num5 = 1;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
                    num5 = 1;
                  while (true)
                  {
                    switch (num5)
                    {
                      case 1:
                        NHProvider.Nfjov4WfBOxTdWIWaW68((object) serviceNotNull.TransformationProvider);
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_32;
                    }
                  }
                }
                catch (Exception ex)
                {
                  int num6 = 2;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
                    num6 = 1;
                  while (true)
                  {
                    switch (num6)
                    {
                      case 1:
                        NHProvider.baf2a8Wfbg7jwHCvKp2o(NHProvider.lLlQkrWEAMdbnK3PVc8l((object) serviceNotNull));
                        num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 0;
                        continue;
                      case 2:
                        NHProvider.hMg2JTWfoSD7PohMRvrq(NHProvider.oGZ3VPWfWGtL1AV5ZZjD(), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -812065906), (object) ex);
                        num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 1 : 1;
                        continue;
                      default:
                        goto label_32;
                    }
                  }
                }
              }
              finally
              {
                int num7;
                if (startInformation == null)
                  num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 1;
                else
                  goto label_27;
label_26:
                switch (num7)
                {
                  case 1:
                  case 2:
                }
label_27:
                NHProvider.ubHXZOWE6Vou1NCIHia3((object) startInformation);
                num7 = 2;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
                {
                  num7 = 2;
                  goto label_26;
                }
                else
                  goto label_26;
              }
            default:
              goto label_34;
          }
        }
label_34:
        try
        {
          IEnumerator<INHManager> enumerator = Locator.GetServiceNotNull<IEnumerable<INHManager>>().GetEnumerator();
          int num8 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0)
            num8 = 1;
          while (true)
          {
            switch (num8)
            {
              case 0:
                goto label_57;
              case 1:
                try
                {
label_42:
                  if (NHProvider.RNjLyPWE42Y6SZYis3QZ((object) enumerator))
                    goto label_40;
                  else
                    goto label_43;
label_39:
                  int num9;
                  switch (num9)
                  {
                    case 1:
                      goto label_42;
                    case 2:
                      break;
                    default:
                      goto label_50;
                  }
label_40:
                  NHProvider.odj44xWffsCKBSEZ90nT((object) enumerator.Current);
                  num9 = 1;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
                  {
                    num9 = 1;
                    goto label_39;
                  }
                  else
                    goto label_39;
label_43:
                  num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 0;
                  goto label_39;
                }
                finally
                {
                  if (enumerator != null)
                  {
                    int num10 = 0;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
                      num10 = 0;
                    while (true)
                    {
                      switch (num10)
                      {
                        case 1:
                          goto label_49;
                        default:
                          enumerator.Dispose();
                          num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 1 : 0;
                          continue;
                      }
                    }
                  }
label_49:;
                }
              case 2:
label_50:
                ((ILogger) NHProvider.oGZ3VPWfWGtL1AV5ZZjD()).Debug(NHProvider.CRjEMAWfFKBhhSk32Jok(NHProvider.HeKR9RWE3F1PkePe16DB(~-122002947 ^ 121911914), (object) (int) NHProvider.veOg29WfGu9YtB7Sd68c(NHProvider.ib6UP1WfhgQ5rsk5DpaD(), dateTime).TotalMilliseconds));
                num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 0;
                continue;
              default:
                goto label_54;
            }
          }
label_57:
          return;
label_54:;
        }
        finally
        {
          int num11;
          if (startInformation == null)
            num11 = 2;
          else
            goto label_55;
label_53:
          switch (num11)
          {
            case 1:
            case 2:
          }
label_55:
          NHProvider.ubHXZOWE6Vou1NCIHia3((object) startInformation);
          num11 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
          {
            num11 = 1;
            goto label_53;
          }
          else
            goto label_53;
        }
      }
      finally
      {
        if (metadataServiceContext != null)
        {
          int num12 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
            num12 = 1;
          while (true)
          {
            switch (num12)
            {
              case 1:
                NHProvider.ubHXZOWE6Vou1NCIHia3((object) metadataServiceContext);
                num12 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
                continue;
              default:
                goto label_65;
            }
          }
        }
label_65:;
      }
    }

    /// <summary>
    /// Сгенерировать проекцию для сортировки по свойству сущности
    /// </summary>
    /// <param name="metadata">Метаданные сущности</param>
    /// <param name="propertyMetadata">Метаданные свойствоа сущности, по которому производится сортировка</param>
    public abstract IProjection GenerateOrderByProjection(
      EntityMetadata metadata,
      PropertyMetadata propertyMetadata,
      string entityName = null,
      string si = null);

    /// <summary>
    /// Подготовить проекцию для сортировки для конкретной СУБД
    /// </summary>
    /// <param name="prj">Проекция</param>
    /// <param name="propertyMetadataTypeUid">TypeUid метаданных свойства</param>
    /// <returns>Проекция, готовая для выполнения в БД</returns>
    public virtual IProjection PrepareOrderByProjection(
      IProjection prj,
      Guid? propertyMetadataTypeUid)
    {
      return prj;
    }

    /// <summary>
    /// Сгенерировать проекцию для строкового поля, применимую для сравнения, сортировки, группировки и т.д.
    /// </summary>
    /// <param name="propertyProjection">Проекция поля</param>
    /// <param name="maxLength">Максимальная длина</param>
    /// <returns></returns>
    public abstract IProjection GenerateComparableStringProjection(
      IProjection propertyProjection,
      int maxLength = 255);

    /// <summary>Кастомизация построения хибернейтовского маппинга</summary>
    /// <param name="mapper">Мэппинг</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    public virtual void CustomMapping(
      INHibernatePropertyTypeMapper mapper,
      PropertyMetadata propertyMetadata)
    {
    }

    /// <summary>
    /// Создать провайдер для обновления структуры базы данных, отвязанный от сессии NHibernate
    /// </summary>
    public abstract ITransformationProvider CreateTransformationProvider();

    protected bool PropertyIsString(IEntityPropertyMetadata propertyMetadata)
    {
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_9;
          case 2:
            goto label_8;
          case 3:
            if (NHProvider.g4cmc7WfQUHxnoQ3lPB3((object) propertyMetadata) == StringDescriptor.UID)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 1 : 0;
              continue;
            }
            break;
          case 4:
            if (propertyMetadata != null)
            {
              num = 3;
              continue;
            }
            goto label_10;
          case 5:
            if (!NHProvider.IJVGXiWfCCI0Eh1Rr2Rg(NHProvider.g4cmc7WfQUHxnoQ3lPB3((object) propertyMetadata), UrlDescriptor.UID))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 2 : 2;
              continue;
            }
            goto label_9;
        }
        if (!NHProvider.IJVGXiWfCCI0Eh1Rr2Rg(NHProvider.g4cmc7WfQUHxnoQ3lPB3((object) propertyMetadata), TextDescriptor.UID))
          num = 5;
        else
          goto label_9;
      }
label_8:
      return NHProvider.IJVGXiWfCCI0Eh1Rr2Rg(NHProvider.g4cmc7WfQUHxnoQ3lPB3((object) propertyMetadata), HtmlStringDescriptor.UID);
label_9:
      return true;
label_10:
      return false;
    }

    /// <summary>
    /// Возращает строку запроса для сравнения свойства со значением через равенство (для строк - регистронезависимо)
    /// </summary>
    public virtual SqlString EqualToSqlString(
      ICriteria criteria,
      ICriteriaQuery criteriaQuery,
      string lhsPropertyPath,
      IEntityPropertyMetadata lhsPropertyMetadata,
      object rhsValue)
    {
      int num1 = 14;
      SqlString[] sqlStringArray;
      NHibernate.SqlCommand.Parameter parameter1;
      SqlStringBuilder sqlStringBuilder;
      ICriteriaQuery criteriaQuery1;
      while (true)
      {
        int num2 = num1;
        int index1;
        NHibernate.SqlCommand.Parameter[] array1;
        int index2;
        TypedValue[] typedValueArray;
        TypedValue parameter2;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 22:
              if (index1 < sqlStringArray.Length)
              {
                num2 = 24;
                continue;
              }
              goto label_27;
            case 2:
            case 18:
              NHProvider.bswnHCWfRTVP3WgSj8Yf((object) ((SqlStringBuilder) NHProvider.Hu22DpWfiA4EN0Cqtlvg((object) sqlStringBuilder, (object) sqlStringArray[index1])).Add((string) NHProvider.HeKR9RWE3F1PkePe16DB(-867826612 ^ -867721008)), (object) array1[index1]);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 25 : 3;
              continue;
            case 3:
              ++index2;
              num2 = 21;
              continue;
            case 4:
              array1 = ((IEnumerable<TypedValue>) NHProvider.kgau1MWfZILAJ3gIVGda((object) criteriaQuery1, (object) criteria, (object) null, (object) lhsPropertyPath, (object) new object[1]
              {
                rhsValue
              })).SelectMany<TypedValue, NHibernate.SqlCommand.Parameter>((Func<TypedValue, IEnumerable<NHibernate.SqlCommand.Parameter>>) (t => criteriaQuery1.NewQueryParameter(t))).ToArray<NHibernate.SqlCommand.Parameter>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 0 : 0;
              continue;
            case 5:
            case 27:
              goto label_27;
            case 6:
              index1 = 0;
              num2 = 22;
              continue;
            case 7:
              parameter1 = (NHibernate.SqlCommand.Parameter) null;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 8 : 23;
              continue;
            case 8:
              goto label_7;
            case 9:
              goto label_28;
            case 10:
              goto label_31;
            case 11:
            case 24:
              if (index1 <= 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 8 : 18;
                continue;
              }
              goto case 16;
            case 12:
              index2 = 0;
              num2 = 20;
              continue;
            case 13:
              criteriaQuery1 = criteriaQuery;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 6 : 9;
              continue;
            case 14:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 3 : 13;
              continue;
            case 15:
            case 17:
              parameter2 = typedValueArray[index2];
              num2 = 26;
              continue;
            case 16:
              sqlStringBuilder.Add((string) NHProvider.HeKR9RWE3F1PkePe16DB(-688192331 - 435440695 ^ -1123607336));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 2 : 0;
              continue;
            case 19:
              goto label_6;
            case 20:
            case 21:
              if (index2 < typedValueArray.Length)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 17 : 10;
                continue;
              }
              goto label_6;
            case 23:
              if (!this.PropertyIsString(lhsPropertyMetadata))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 8 : 2;
                continue;
              }
              goto label_31;
            case 25:
              ++index1;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 0 : 1;
              continue;
            case 26:
              parameter1 = criteriaQuery1.NewQueryParameter(parameter2).Last<NHibernate.SqlCommand.Parameter>();
              num2 = 3;
              continue;
            default:
              if (!((IEnumerable<NHibernate.SqlCommand.Parameter>) array1).Any<NHibernate.SqlCommand.Parameter>())
              {
                num2 = 27;
                continue;
              }
              goto case 6;
          }
        }
label_7:
        sqlStringBuilder = new SqlStringBuilder();
        num1 = 4;
        continue;
label_28:
        object array2 = NHProvider.e5dQVcWfv7fEOYj52gQn((object) criteriaQuery1, (object) criteria, (object) lhsPropertyPath);
        // ISSUE: reference to a compiler-generated field
        Converter<string, SqlString> converter1 = NHProvider.\u003C\u003Ec.\u003C\u003E9__16_0;
        Converter<string, SqlString> converter2;
        if (converter1 == null)
        {
          // ISSUE: reference to a compiler-generated field
          NHProvider.\u003C\u003Ec.\u003C\u003E9__16_0 = converter2 = (Converter<string, SqlString>) (col => new SqlString(col));
        }
        else
          goto label_32;
label_30:
        sqlStringArray = Array.ConvertAll<string, SqlString>((string[]) array2, converter2);
        num1 = 7;
        continue;
label_32:
        converter2 = converter1;
        goto label_30;
label_31:
        typedValueArray = (TypedValue[]) NHProvider.kgau1MWfZILAJ3gIVGda((object) criteriaQuery1, (object) criteria, (object) null, (object) lhsPropertyPath, (object) new object[1]
        {
          rhsValue == null ? (object) null : NHProvider.ORVVgXWf8YSdiunapy4U((object) rhsValue.ToString())
        });
        num1 = 12;
      }
label_6:
      return ((SqlStringBuilder) NHProvider.bswnHCWfRTVP3WgSj8Yf(NHProvider.oiFbr3WfSVmMM3WJUpow(NHProvider.oiFbr3WfSVmMM3WJUpow(NHProvider.Hu22DpWfiA4EN0Cqtlvg(NHProvider.oiFbr3WfSVmMM3WJUpow(NHProvider.pvsggwWfVnAvnYAwY03t((object) new SqlStringBuilder(), NHProvider.qHGZvPWfI6q38YpcwGGF((object) ((IMapping) NHProvider.rsEkvZWfuIJeqKN76RYB((object) criteriaQuery1)).Dialect)), NHProvider.HeKR9RWE3F1PkePe16DB(2008901894 << 3 ^ -1108650106)), (object) sqlStringArray[0]), NHProvider.HeKR9RWE3F1PkePe16DB(~-122002947 ^ 121995710)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(333888594 ^ 1075625116 ^ 1409000530)), (object) parameter1)).ToSqlString();
label_27:
      return (SqlString) NHProvider.cKXGfOWfqrlXGFbDqbpy((object) sqlStringBuilder);
    }

    /// <summary>
    /// Возращает строку запроса для сравнения 2-х свойств через равенство (для строк - регистронезависимо)
    /// </summary>
    public virtual SqlString EqualToSqlString(
      ICriteria criteria,
      ICriteriaQuery criteriaQuery,
      SqlString[] lhsColumnNames,
      IEntityPropertyMetadata lhsPropertyMetadata,
      SqlString[] rhsColumnNames,
      IEntityPropertyMetadata rhsPropertyMetadata)
    {
      int num1 = 10;
      SqlStringBuilder sqlStringBuilder;
      while (true)
      {
        int num2 = num1;
        int index;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 3:
              goto label_13;
            case 2:
              goto label_7;
            case 4:
              if (!this.PropertyIsString(rhsPropertyMetadata))
              {
                sqlStringBuilder = new SqlStringBuilder();
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 14 : 11;
                continue;
              }
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 13 : 12;
              continue;
            case 5:
            case 17:
              if (index <= 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 0 : 0;
                continue;
              }
              goto case 18;
            case 6:
              if (lhsColumnNames.Length <= 1)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 3;
                continue;
              }
              goto case 11;
            case 7:
            case 12:
              index = 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 8 : 7;
              continue;
            case 8:
            case 19:
              if (index < lhsColumnNames.Length)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 17 : 0;
                continue;
              }
              goto case 6;
            case 9:
            case 13:
              goto label_8;
            case 10:
              if (this.PropertyIsString(lhsPropertyMetadata))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 9 : 3;
                continue;
              }
              goto case 4;
            case 11:
              NHProvider.oiFbr3WfSVmMM3WJUpow((object) sqlStringBuilder, NHProvider.HeKR9RWE3F1PkePe16DB(1242972401 >> 4 ^ 77691827));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 1;
              continue;
            case 14:
              goto label_19;
            case 16:
              ++index;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 8 : 19;
              continue;
            case 18:
              sqlStringBuilder.Add((string) NHProvider.HeKR9RWE3F1PkePe16DB(1319452732 ^ 1319429274));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 15 : 1;
              continue;
            default:
              NHProvider.Hu22DpWfiA4EN0Cqtlvg((object) sqlStringBuilder, NHProvider.cKXGfOWfqrlXGFbDqbpy(NHProvider.Hu22DpWfiA4EN0Cqtlvg((object) new SqlStringBuilder().Add(lhsColumnNames[index]).Add((string) NHProvider.HeKR9RWE3F1PkePe16DB(-867826612 ^ -867721008)), (object) rhsColumnNames[index])));
              num2 = 16;
              continue;
          }
        }
label_7:
        NHProvider.oiFbr3WfSVmMM3WJUpow((object) sqlStringBuilder, NHProvider.HeKR9RWE3F1PkePe16DB(-1204263869 ^ -1341583247 ^ 137456516));
        num1 = 7;
        continue;
label_19:
        if (lhsColumnNames.Length <= 1)
          num1 = 12;
        else
          goto label_7;
      }
label_8:
      return ((SqlStringBuilder) NHProvider.oiFbr3WfSVmMM3WJUpow((object) ((SqlStringBuilder) NHProvider.oiFbr3WfSVmMM3WJUpow(NHProvider.oiFbr3WfSVmMM3WJUpow(NHProvider.oiFbr3WfSVmMM3WJUpow((object) ((SqlStringBuilder) NHProvider.Hu22DpWfiA4EN0Cqtlvg((object) ((SqlStringBuilder) NHProvider.pvsggwWfVnAvnYAwY03t((object) new SqlStringBuilder(), NHProvider.qHGZvPWfI6q38YpcwGGF(NHProvider.HoQE7wWfKC7EgAutgSIQ((object) criteriaQuery.Factory)))).Add((string) NHProvider.HeKR9RWE3F1PkePe16DB(381945751 ^ 1158627804 ^ 1405835773)), (object) lhsColumnNames[0])).Add((string) NHProvider.HeKR9RWE3F1PkePe16DB(-53329496 >> 4 ^ -3327066)), NHProvider.HeKR9RWE3F1PkePe16DB(-420743386 ^ -420850758)), NHProvider.qHGZvPWfI6q38YpcwGGF(NHProvider.HoQE7wWfKC7EgAutgSIQ(NHProvider.rsEkvZWfuIJeqKN76RYB((object) criteriaQuery)))), NHProvider.HeKR9RWE3F1PkePe16DB(~289714581 ^ -289713700))).Add(rhsColumnNames[0]), NHProvider.HeKR9RWE3F1PkePe16DB(95909607 + 343705423 ^ 439607690))).ToSqlString();
label_13:
      return (SqlString) NHProvider.cKXGfOWfqrlXGFbDqbpy((object) sqlStringBuilder);
    }

    /// <summary>Сконфигурировать БД</summary>
    /// <returns>Конфигурация</returns>
    protected virtual NHibernate.Cfg.Configuration ConfigureDb()
    {
      int num1 = 5;
      EleWise.ELMA.Runtime.NH.Configuration configuration;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_7;
            case 2:
              NHProvider.IpOIgaWfkYsB4he26uZ0((object) this, (object) configuration);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 0 : 0;
              continue;
            case 3:
              NHProvider.oyUCt9WfTUR2xlDPnqAF((object) this, (object) configuration);
              num2 = 2;
              continue;
            case 4:
              configuration = new EleWise.ELMA.Runtime.NH.Configuration();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 3;
              continue;
            case 5:
              NHProvider.uQbaapWfXlJvvwDmoadD(false);
              num2 = 4;
              continue;
            case 6:
              configuration.SetProperty((string) NHProvider.HeKR9RWE3F1PkePe16DB(381945751 ^ 1158627804 ^ 1405805237), (string) NHProvider.HeKR9RWE3F1PkePe16DB(-1255365154 ^ 596875508 ^ -1765894120));
              num2 = 10;
              continue;
            case 7:
              NHProvider.eYf7nTWEYCS78w69Ih1c((object) configuration, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488773883), NHProvider.HeKR9RWE3F1PkePe16DB(654297945 ^ 654208941));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 6 : 2;
              continue;
            case 8:
              configuration.SetProperty((string) NHProvider.HeKR9RWE3F1PkePe16DB(1051276242 - 990076387 ^ 61108571), (string) NHProvider.HeKR9RWE3F1PkePe16DB(1654249598 >> 2 ^ 413559813));
              num2 = 7;
              continue;
            case 9:
              configuration.CollectionTypeFactory<ElmaCollectionTypeFactory>();
              num2 = 8;
              continue;
            case 10:
              goto label_6;
            default:
              configuration.Proxy((Action<IProxyConfigurationProperties>) (p => p.ProxyFactoryFactory<ProxyFactoryFactory>()));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 1;
              continue;
          }
        }
label_7:
        NHProvider.QI6oJqWfn9kwkMH1f8xK((object) this, (object) configuration);
        num1 = 9;
      }
label_6:
      return (NHibernate.Cfg.Configuration) configuration;
    }

    /// <summary>Конфигурировать классы обработчиков событий</summary>
    /// <param name="t">Конфигурация NHibernate</param>
    protected virtual void ConfigListeners(NHibernate.Cfg.Configuration t)
    {
      int num1 = 8;
      while (true)
      {
        int num2 = num1;
        ExtensionPointsForwardListener pointsForwardListener;
        HHH2763Fix hhH2763Fix;
        while (true)
        {
          switch (num2)
          {
            case 1:
              NHProvider.jOZopSWf6p4kXe6QSusQ(NHProvider.ixRAjfWfO9LW1a80BY9d((object) t), (object) ((IEnumerable<IPreLoadEventListener>) new IPreLoadEventListener[1]
              {
                (IPreLoadEventListener) pointsForwardListener
              }).Concat<IPreLoadEventListener>((IEnumerable<IPreLoadEventListener>) NHProvider.epd31sWf4JIWbUEfCA1p((object) t.EventListeners)).ToArray<IPreLoadEventListener>());
              num2 = 6;
              continue;
            case 2:
              NHProvider.KVeVT8Wf121T6neRmSbU(NHProvider.ixRAjfWfO9LW1a80BY9d((object) t), (object) ((IEnumerable<IPostInsertEventListener>) new IPostInsertEventListener[1]
              {
                (IPostInsertEventListener) pointsForwardListener
              }).Concat<IPostInsertEventListener>((IEnumerable<IPostInsertEventListener>) NHProvider.Xa1tU4WfPX1vwldnPQxg(NHProvider.ixRAjfWfO9LW1a80BY9d((object) t))).ToArray<IPostInsertEventListener>());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 5 : 10;
              continue;
            case 3:
              NHProvider.Glt6qTWf7I1EVbT6agLJ(NHProvider.ixRAjfWfO9LW1a80BY9d((object) t), (object) ((IEnumerable<IPostCollectionUpdateEventListener>) new IPostCollectionUpdateEventListener[1]
              {
                (IPostCollectionUpdateEventListener) pointsForwardListener
              }).Concat<IPostCollectionUpdateEventListener>((IEnumerable<IPostCollectionUpdateEventListener>) NHProvider.l4ZUtdWfAxWVQ1EWKs87(NHProvider.ixRAjfWfO9LW1a80BY9d((object) t))).ToArray<IPostCollectionUpdateEventListener>());
              num2 = 13;
              continue;
            case 4:
              NHProvider.Mj9CjZWfmQGMBw7yHSVK(NHProvider.ixRAjfWfO9LW1a80BY9d((object) t), (object) ((IEnumerable<IPreCollectionRemoveEventListener>) new IPreCollectionRemoveEventListener[1]
              {
                (IPreCollectionRemoveEventListener) pointsForwardListener
              }).Concat<IPreCollectionRemoveEventListener>((IEnumerable<IPreCollectionRemoveEventListener>) t.EventListeners.PreCollectionRemoveEventListeners).ToArray<IPreCollectionRemoveEventListener>());
              num2 = 15;
              continue;
            case 5:
              NHProvider.H0WsnHWfwNrwTGnnSIFR(NHProvider.ixRAjfWfO9LW1a80BY9d((object) t), (object) ((IEnumerable<IPostDeleteEventListener>) new IPostDeleteEventListener[1]
              {
                (IPostDeleteEventListener) pointsForwardListener
              }).Concat<IPostDeleteEventListener>((IEnumerable<IPostDeleteEventListener>) NHProvider.plL4aQWfthyUNtxljpAe(NHProvider.ixRAjfWfO9LW1a80BY9d((object) t))).ToArray<IPostDeleteEventListener>());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 1 : 1;
              continue;
            case 6:
              NHProvider.aljOk7WfHs0kwF8ljiEw(NHProvider.ixRAjfWfO9LW1a80BY9d((object) t), (object) ((IEnumerable<IPostCollectionRecreateEventListener>) new IPostCollectionRecreateEventListener[1]
              {
                (IPostCollectionRecreateEventListener) pointsForwardListener
              }).Concat<IPostCollectionRecreateEventListener>((IEnumerable<IPostCollectionRecreateEventListener>) ((EventListeners) NHProvider.ixRAjfWfO9LW1a80BY9d((object) t)).PostCollectionRecreateEventListeners).ToArray<IPostCollectionRecreateEventListener>());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 14 : 3;
              continue;
            case 7:
              pointsForwardListener = new ExtensionPointsForwardListener();
              num2 = 16;
              continue;
            case 8:
              NHProvider.ji5DbxWf2qTqyo4Oge0U(NHProvider.ixRAjfWfO9LW1a80BY9d((object) t), (object) new IDeleteEventListener[1]
              {
                (IDeleteEventListener) new SoftDeleteEventListener()
              });
              num2 = 7;
              continue;
            case 9:
              NHProvider.AOwnxkWfedFgHtvJbE6w(NHProvider.ixRAjfWfO9LW1a80BY9d((object) t), (object) new IFlushEventListener[2]
              {
                (IFlushEventListener) pointsForwardListener,
                (IFlushEventListener) hhH2763Fix
              });
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 2 : 1;
              continue;
            case 10:
              NHProvider.GCvNHfWf3KrVmGx4GiFQ(NHProvider.ixRAjfWfO9LW1a80BY9d((object) t), (object) ((IEnumerable<IPostUpdateEventListener>) new IPostUpdateEventListener[1]
              {
                (IPostUpdateEventListener) pointsForwardListener
              }).Concat<IPostUpdateEventListener>((IEnumerable<IPostUpdateEventListener>) NHProvider.KYX1GOWfNfOBjF4TnF2s((object) t.EventListeners)).ToArray<IPostUpdateEventListener>());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 4 : 11;
              continue;
            case 11:
              ((EventListeners) NHProvider.ixRAjfWfO9LW1a80BY9d((object) t)).PreUpdateEventListeners = ((IEnumerable<IPreUpdateEventListener>) new IPreUpdateEventListener[1]
              {
                (IPreUpdateEventListener) pointsForwardListener
              }).Concat<IPreUpdateEventListener>((IEnumerable<IPreUpdateEventListener>) NHProvider.cP2tdCWfpNLgqDVKMZfW(NHProvider.ixRAjfWfO9LW1a80BY9d((object) t))).ToArray<IPreUpdateEventListener>();
              num2 = 17;
              continue;
            case 12:
              goto label_3;
            case 13:
              goto label_9;
            case 14:
              goto label_8;
            case 15:
              ((EventListeners) NHProvider.ixRAjfWfO9LW1a80BY9d((object) t)).PreCollectionUpdateEventListeners = ((IEnumerable<IPreCollectionUpdateEventListener>) new IPreCollectionUpdateEventListener[1]
              {
                (IPreCollectionUpdateEventListener) pointsForwardListener
              }).Concat<IPreCollectionUpdateEventListener>((IEnumerable<IPreCollectionUpdateEventListener>) NHProvider.zgfTcoWfyA01HjjXJtCG(NHProvider.ixRAjfWfO9LW1a80BY9d((object) t))).ToArray<IPreCollectionUpdateEventListener>();
              num2 = 12;
              continue;
            case 16:
              hhH2763Fix = new HHH2763Fix();
              num2 = 9;
              continue;
            case 17:
              NHProvider.YZSJF0WfaadbQ9qNtQEE(NHProvider.ixRAjfWfO9LW1a80BY9d((object) t), (object) ((IEnumerable<IPreInsertEventListener>) new IPreInsertEventListener[1]
              {
                (IPreInsertEventListener) pointsForwardListener
              }).Concat<IPreInsertEventListener>((IEnumerable<IPreInsertEventListener>) ((EventListeners) NHProvider.ixRAjfWfO9LW1a80BY9d((object) t)).PreInsertEventListeners).ToArray<IPreInsertEventListener>());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
              continue;
            default:
              goto label_19;
          }
        }
label_8:
        t.EventListeners.PostCollectionRemoveEventListeners = ((IEnumerable<IPostCollectionRemoveEventListener>) new IPostCollectionRemoveEventListener[1]
        {
          (IPostCollectionRemoveEventListener) pointsForwardListener
        }).Concat<IPostCollectionRemoveEventListener>((IEnumerable<IPostCollectionRemoveEventListener>) ((EventListeners) NHProvider.ixRAjfWfO9LW1a80BY9d((object) t)).PostCollectionRemoveEventListeners).ToArray<IPostCollectionRemoveEventListener>();
        num1 = 3;
        continue;
label_9:
        NHProvider.haKB9eWf0ATNg7LYJIg7(NHProvider.ixRAjfWfO9LW1a80BY9d((object) t), (object) ((IEnumerable<IPreCollectionRecreateEventListener>) new IPreCollectionRecreateEventListener[1]
        {
          (IPreCollectionRecreateEventListener) pointsForwardListener
        }).Concat<IPreCollectionRecreateEventListener>((IEnumerable<IPreCollectionRecreateEventListener>) NHProvider.HkoRH2Wfx6oiIaH58jK1((object) t.EventListeners)).ToArray<IPreCollectionRecreateEventListener>());
        num1 = 4;
        continue;
label_19:
        ((EventListeners) NHProvider.ixRAjfWfO9LW1a80BY9d((object) t)).PreDeleteEventListeners = ((IEnumerable<IPreDeleteEventListener>) new IPreDeleteEventListener[1]
        {
          (IPreDeleteEventListener) pointsForwardListener
        }).Concat<IPreDeleteEventListener>((IEnumerable<IPreDeleteEventListener>) NHProvider.rBRrrLWfDgPlKjWLmEMj(NHProvider.ixRAjfWfO9LW1a80BY9d((object) t))).ToArray<IPreDeleteEventListener>();
        num1 = 5;
      }
label_3:;
    }

    protected virtual void ConfigureCacheProvider(NHibernate.Cfg.Configuration cfg)
    {
      int num1 = 1;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_2;
          case 1:
            cfg.Cache((Action<ICacheConfigurationProperties>) (c =>
            {
              int num2 = 4;
              bool setting;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    c.QueryCacheFactory<NHQueryCacheFactoryWrapper>();
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 0 : 0;
                    continue;
                  case 2:
                    if (setting)
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 1 : 0;
                      continue;
                    }
                    goto label_8;
                  case 3:
                    // ISSUE: reference to a compiler-generated method
                    c.UseQueryCache = setting = EleWise.ELMA.SR.GetSetting<bool>((string) NHProvider.\u003C\u003Ec.UTobv6QNwCs842qehuCO(323422137 << 2 ^ 1293510106));
                    num2 = 2;
                    continue;
                  case 4:
                    c.Provider<NHCacheProviderWrapper>();
                    num2 = 3;
                    continue;
                  default:
                    goto label_9;
                }
              }
label_2:
              return;
label_9:
              return;
label_8:;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>
    /// Выполнить проверку версии СУБД на соответствие минимальным требованиям
    /// </summary>
    protected void CheckDatabaseServerVersion()
    {
      int num = 4;
      Version version;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            if (NHProvider.FmDlifWfdX7nrerqLLxt((object) version, NHProvider.c8ZMxaWf9rHmaYXnrCVP((object) this)))
            {
              num = 2;
              continue;
            }
            goto label_5;
          case 2:
            goto label_8;
          case 3:
            if (!NHProvider.cxXYbtWfJMPuush3bYtr((object) version, (object) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 0 : 0;
              continue;
            }
            goto case 1;
          case 4:
            version = (Version) NHProvider.I14Fu7WfM5OEFDr6mcA9((object) this);
            num = 3;
            continue;
          default:
            goto label_10;
        }
      }
label_2:
      return;
label_10:
      return;
label_5:
      return;
label_8:
      throw new ConfigurationInitializeException(EleWise.ELMA.SR.T((string) NHProvider.HeKR9RWE3F1PkePe16DB(-87337865 ^ -87363251), NHProvider.ebDyAaWfljOX9CHiTf0c((object) this), NHProvider.XdeeCJWfr9tvOZp7MCC0((object) this, (object) version), (object) this.GetDatabaseServerName((Version) NHProvider.c8ZMxaWf9rHmaYXnrCVP((object) this))));
    }

    /// <summary>Внутренняя инициализация провайдера базы данных</summary>
    protected abstract void InitInternal();

    /// <summary>
    /// Провайдер генератора идентификатора для класса OR-маппинга
    /// </summary>
    protected abstract IMapIdentityProvider MapIdentityProvider { get; }

    /// <summary>Сконфигурировать (применить реализацию провайдера БД)</summary>
    /// <param name="cfg">Конфигурация NHibernate</param>
    /// <returns></returns>
    protected abstract void Configure(NHibernate.Cfg.Configuration cfg);

    /// <summary>Тип провайдер для обновления структуры базы данных</summary>
    protected abstract Type TransformationProviderType { get; }

    /// <summary>
    /// Минимальая версия СУБД, работу с которой поддерживает провайдер БД
    /// </summary>
    protected abstract Version MinServerVersion { get; }

    /// <summary>
    /// Получить общепринятое наименование СУБД, с которой провайдер БД работает
    /// </summary>
    /// <param name="version">Версия СУБД</param>
    /// <returns>Строка с общепринятым наименованим СУБД</returns>
    protected abstract string GetDatabaseServerName(Version version);

    /// <summary>Получить версию СУБД</summary>
    /// <returns>Версия, если её удалось получить, иначе - null</returns>
    protected abstract Version GetDatabaseServerVersion();

    private IEnumerable<IDbStructureExtension> SortDbStructures(
      IEnumerable<IDbStructureExtension> structures)
    {
      IDbStructureExtension[] array = structures.ToArray<IDbStructureExtension>();
      List<IDbStructureExtension> result = new List<IDbStructureExtension>();
      foreach (IDbStructureExtension structure in array)
      {
        List<IDbStructureExtension> stack = new List<IDbStructureExtension>();
        this.SortDbStructureItem(structure, (IEnumerable<IDbStructureExtension>) array, result, stack);
      }
      return (IEnumerable<IDbStructureExtension>) result;
    }

    private void SortDbStructureItem(
      IDbStructureExtension structure,
      IEnumerable<IDbStructureExtension> structures,
      List<IDbStructureExtension> result,
      List<IDbStructureExtension> stack)
    {
      if (structure == null || result.Contains(structure) || stack.Contains(structure))
        return;
      stack.Add(structure);
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      IDbStructureExtension structure1 = structure.Parent != (Type) null ? structures.FirstOrDefault<IDbStructureExtension>((Func<IDbStructureExtension, bool>) (s => NHProvider.\u003C\u003Ec__DisplayClass34_0.LaGTrBQNM8KIjQxI3Jnu(s.GetType(), NHProvider.\u003C\u003Ec__DisplayClass34_0.S4nM1mQNyG0VPJ37113L((object) structure)))) : (IDbStructureExtension) null;
      if (structure1 != null)
        this.SortDbStructureItem(structure1, structures, result, new List<IDbStructureExtension>((IEnumerable<IDbStructureExtension>) stack));
      if (structure.References != null)
      {
        foreach (Type reference in structure.References)
        {
          Type refStructType = reference;
          // ISSUE: reference to a compiler-generated method
          IDbStructureExtension structure2 = structures.FirstOrDefault<IDbStructureExtension>((Func<IDbStructureExtension, bool>) (s => NHProvider.\u003C\u003Ec__DisplayClass34_1.pAmoJSQNr2PdYsjN8S3S(s.GetType(), refStructType)));
          if (structure2 != null)
            this.SortDbStructureItem(structure2, structures, result, new List<IDbStructureExtension>((IEnumerable<IDbStructureExtension>) stack));
        }
      }
      result.Add(structure);
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      foreach (IDbStructureExtension structure3 in structures.Where<IDbStructureExtension>((Func<IDbStructureExtension, bool>) (s => NHProvider.\u003C\u003Ec__DisplayClass34_0.LaGTrBQNM8KIjQxI3Jnu(NHProvider.\u003C\u003Ec__DisplayClass34_0.S4nM1mQNyG0VPJ37113L((object) s), structure.GetType()))))
        this.SortDbStructureItem(structure3, structures, result, new List<IDbStructureExtension>((IEnumerable<IDbStructureExtension>) stack));
    }

    protected NHProvider()
    {
      NHProvider.s0txMIWfg1uY1yZ3XkYY();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool tO1GLYWE1Gw0FZqWtVjZ() => NHProvider.h1sdPJWEPb0S33mFM7dv == null;

    internal static NHProvider vFGIO9WEN9fu7XDfa3AB() => NHProvider.h1sdPJWEPb0S33mFM7dv;

    internal static object HeKR9RWE3F1PkePe16DB(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object t2saf6WEpS98FQCvbhef(double completePercent, [In] object obj1) => (object) StartInformation.Operation(completePercent, (string) obj1);

    internal static object eCJp2qWEaNQrMnTxUngj() => (object) ComponentManager.Builder;

    internal static Type t3CDWlWEDqpKO4UHE6rd([In] object obj0) => ((NHProvider) obj0).TransformationProviderType;

    internal static object uWDe7UWEtqeS2Xx4CPeC() => (object) ComponentManager.Current;

    internal static void rCCZEdWEw0C9hYyRBlGF([In] object obj0) => ((INHProviderDependentUserTypeRegistrar) obj0).Register();

    internal static bool RNjLyPWE42Y6SZYis3QZ([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void ubHXZOWE6Vou1NCIHia3([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static void mSt1FTWEH4S9dZ4igr97([In] object obj0, [In] object obj1) => ((NHManagerRegisterParams) obj0).Builder = (ContainerBuilder) obj1;

    internal static object lLlQkrWEAMdbnK3PVc8l([In] object obj0) => (object) ((IRuntimeApplication) obj0).TransformationProvider;

    internal static object ifvQwOWE7kfYKACEOlr4([In] object obj0) => (object) ((NHProvider) obj0).MapIdentityProvider;

    internal static void tGfbSXWExMlfxQMrsju9([In] object obj0) => EleWise.ELMA.Runtime.Db.MapIdentityProvider.CurrentThreadProvider = (IMapIdentityProvider) obj0;

    internal static object th4tViWE0kDOJwC5x96v([In] object obj0) => (object) EleWise.ELMA.SR.M((string) obj0);

    internal static void tg2v2kWEmu2d44oMPfdY() => ElmaInExpression.Init();

    internal static object VGWMDbWEyswbndfAuIct([In] object obj0) => (object) ((IRuntimeApplication) obj0).DbPreUpdater;

    internal static object Jy62nhWEM7qe9YY1KXPB([In] object obj0) => (object) ((NHManagerRegisterParams) obj0).CreateModelMapper();

    internal static object qkDsKjWEJlchZ8XDkljE([In] object obj0) => (object) ((ModelMapper) obj0).CompileMappingForAllExplicitlyAddedEntities();

    internal static object a2KfrOWE91Imh7KtBiAc([In] object obj0) => (object) ((NHProvider) obj0).ConfigureDb();

    internal static void qkBNKJWEdfeRMClZBoCB([In] object obj0, [In] object obj1) => ((NHibernate.Cfg.Configuration) obj0).AddMapping((HbmMapping) obj1);

    internal static object XSgZiJWElg9VF5y9MOYU([In] object obj0) => (object) ((DbStructure.DbProcedure) obj0).Mappings;

    internal static bool udr4LiWErhmyAf8Nuv3G([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object FnvR49WEgeMKyGVgUW9r([In] object obj0, [In] object obj1) => (object) ((NHibernate.Cfg.Configuration) obj0).AddXml((string) obj1);

    internal static object kihwtxWE5fTvHCWRUL3J([In] object obj0) => (object) ((DbStructure.DbView) obj0).Mappings;

    internal static void kSlA2dWEjYR3rSeWWwdq([In] object obj0) => SchemaMetadataUpdater.QuoteTableAndColumns((NHibernate.Cfg.Configuration) obj0);

    internal static object eYf7nTWEYCS78w69Ih1c([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((NHibernate.Cfg.Configuration) obj0).SetProperty((string) obj1, (string) obj2);

    internal static void CrLeqZWELU3FExsmGiMI([In] object obj0) => ((SessionFactoryHolder) obj0).CreateSessionFactory();

    internal static void OZMgW0WEULCnZpPm5FET([In] object obj0, bool value) => ((NHProvider) obj0).Enabled = value;

    internal static bool g5cNbuWEsiIKliCLOZQb([In] object obj0) => ((IRuntimeApplication) obj0).IsFirstServerInCluster;

    internal static void jE8Ll1WEcBbG99x0rNbF([In] object obj0) => ((ITransformationProvider) obj0).BeginTransaction();

    internal static object A7OT4sWEzOKrJxMa36Oe([In] object obj0) => (object) ((ITransformationProvider) obj0).Dialect;

    internal static object CRjEMAWfFKBhhSk32Jok([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static void Nfjov4WfBOxTdWIWaW68([In] object obj0) => ((ITransformationProviderBase) obj0).CommitTransaction();

    internal static object oGZ3VPWfWGtL1AV5ZZjD() => (object) Logger.Log;

    internal static void hMg2JTWfoSD7PohMRvrq([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Error(obj1, (Exception) obj2);

    internal static void baf2a8Wfbg7jwHCvKp2o([In] object obj0) => ((ITransformationProvider) obj0).RollbackTransaction();

    internal static DateTime ib6UP1WfhgQ5rsk5DpaD() => DateTime.Now;

    internal static TimeSpan veOg29WfGu9YtB7Sd68c([In] DateTime obj0, [In] DateTime obj1) => obj0 - obj1;

    internal static void AaZulgWfEEiepy2saa0J([In] object obj0, [In] object obj1) => ((ILogger) obj0).Debug(obj1);

    internal static void odj44xWffsCKBSEZ90nT([In] object obj0) => ((INHManager) obj0).Init();

    internal static Guid g4cmc7WfQUHxnoQ3lPB3([In] object obj0) => ((IPropertyMetadata) obj0).TypeUid;

    internal static bool IJVGXiWfCCI0Eh1Rr2Rg([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static object e5dQVcWfv7fEOYj52gQn([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((ICriteriaQuery) obj0).GetColumnsUsingProjection((ICriteria) obj1, (string) obj2);

    internal static object ORVVgXWf8YSdiunapy4U([In] object obj0) => (object) ((string) obj0).ToLower();

    internal static object kgau1MWfZILAJ3gIVGda(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3,
      [In] object obj4)
    {
      return (object) CriterionUtil.GetTypedValues((ICriteriaQuery) obj0, (ICriteria) obj1, (IProjection) obj2, (string) obj3, (object[]) obj4);
    }

    internal static object rsEkvZWfuIJeqKN76RYB([In] object obj0) => (object) ((ICriteriaQuery) obj0).Factory;

    internal static object qHGZvPWfI6q38YpcwGGF([In] object obj0) => (object) ((NHibernate.Dialect.Dialect) obj0).LowercaseFunction;

    internal static object pvsggwWfVnAvnYAwY03t([In] object obj0, [In] object obj1) => (object) ((SqlStringBuilder) obj0).Add((string) obj1);

    internal static object oiFbr3WfSVmMM3WJUpow([In] object obj0, [In] object obj1) => (object) ((SqlStringBuilder) obj0).Add((string) obj1);

    internal static object Hu22DpWfiA4EN0Cqtlvg([In] object obj0, [In] object obj1) => (object) ((SqlStringBuilder) obj0).Add((SqlString) obj1);

    internal static object bswnHCWfRTVP3WgSj8Yf([In] object obj0, [In] object obj1) => (object) ((SqlStringBuilder) obj0).Add((NHibernate.SqlCommand.Parameter) obj1);

    internal static object cKXGfOWfqrlXGFbDqbpy([In] object obj0) => (object) ((SqlStringBuilder) obj0).ToSqlString();

    internal static object HoQE7wWfKC7EgAutgSIQ([In] object obj0) => (object) ((IMapping) obj0).Dialect;

    internal static void uQbaapWfXlJvvwDmoadD([In] bool obj0) => NHibernate.Cfg.Environment.UseReflectionOptimizer = obj0;

    internal static void oyUCt9WfTUR2xlDPnqAF([In] object obj0, [In] object obj1) => ((NHProvider) obj0).Configure((NHibernate.Cfg.Configuration) obj1);

    internal static void IpOIgaWfkYsB4he26uZ0([In] object obj0, [In] object obj1) => ((NHProvider) obj0).ConfigureCacheProvider((NHibernate.Cfg.Configuration) obj1);

    internal static void QI6oJqWfn9kwkMH1f8xK([In] object obj0, [In] object obj1) => ((NHProvider) obj0).ConfigListeners((NHibernate.Cfg.Configuration) obj1);

    internal static object ixRAjfWfO9LW1a80BY9d([In] object obj0) => (object) ((NHibernate.Cfg.Configuration) obj0).EventListeners;

    internal static void ji5DbxWf2qTqyo4Oge0U([In] object obj0, [In] object obj1) => ((EventListeners) obj0).DeleteEventListeners = (IDeleteEventListener[]) obj1;

    internal static void AOwnxkWfedFgHtvJbE6w([In] object obj0, [In] object obj1) => ((EventListeners) obj0).FlushEventListeners = (IFlushEventListener[]) obj1;

    internal static object Xa1tU4WfPX1vwldnPQxg([In] object obj0) => (object) ((EventListeners) obj0).PostInsertEventListeners;

    internal static void KVeVT8Wf121T6neRmSbU([In] object obj0, [In] object obj1) => ((EventListeners) obj0).PostInsertEventListeners = (IPostInsertEventListener[]) obj1;

    internal static object KYX1GOWfNfOBjF4TnF2s([In] object obj0) => (object) ((EventListeners) obj0).PostUpdateEventListeners;

    internal static void GCvNHfWf3KrVmGx4GiFQ([In] object obj0, [In] object obj1) => ((EventListeners) obj0).PostUpdateEventListeners = (IPostUpdateEventListener[]) obj1;

    internal static object cP2tdCWfpNLgqDVKMZfW([In] object obj0) => (object) ((EventListeners) obj0).PreUpdateEventListeners;

    internal static void YZSJF0WfaadbQ9qNtQEE([In] object obj0, [In] object obj1) => ((EventListeners) obj0).PreInsertEventListeners = (IPreInsertEventListener[]) obj1;

    internal static object rBRrrLWfDgPlKjWLmEMj([In] object obj0) => (object) ((EventListeners) obj0).PreDeleteEventListeners;

    internal static object plL4aQWfthyUNtxljpAe([In] object obj0) => (object) ((EventListeners) obj0).PostDeleteEventListeners;

    internal static void H0WsnHWfwNrwTGnnSIFR([In] object obj0, [In] object obj1) => ((EventListeners) obj0).PostDeleteEventListeners = (IPostDeleteEventListener[]) obj1;

    internal static object epd31sWf4JIWbUEfCA1p([In] object obj0) => (object) ((EventListeners) obj0).PreLoadEventListeners;

    internal static void jOZopSWf6p4kXe6QSusQ([In] object obj0, [In] object obj1) => ((EventListeners) obj0).PreLoadEventListeners = (IPreLoadEventListener[]) obj1;

    internal static void aljOk7WfHs0kwF8ljiEw([In] object obj0, [In] object obj1) => ((EventListeners) obj0).PostCollectionRecreateEventListeners = (IPostCollectionRecreateEventListener[]) obj1;

    internal static object l4ZUtdWfAxWVQ1EWKs87([In] object obj0) => (object) ((EventListeners) obj0).PostCollectionUpdateEventListeners;

    internal static void Glt6qTWf7I1EVbT6agLJ([In] object obj0, [In] object obj1) => ((EventListeners) obj0).PostCollectionUpdateEventListeners = (IPostCollectionUpdateEventListener[]) obj1;

    internal static object HkoRH2Wfx6oiIaH58jK1([In] object obj0) => (object) ((EventListeners) obj0).PreCollectionRecreateEventListeners;

    internal static void haKB9eWf0ATNg7LYJIg7([In] object obj0, [In] object obj1) => ((EventListeners) obj0).PreCollectionRecreateEventListeners = (IPreCollectionRecreateEventListener[]) obj1;

    internal static void Mj9CjZWfmQGMBw7yHSVK([In] object obj0, [In] object obj1) => ((EventListeners) obj0).PreCollectionRemoveEventListeners = (IPreCollectionRemoveEventListener[]) obj1;

    internal static object zgfTcoWfyA01HjjXJtCG([In] object obj0) => (object) ((EventListeners) obj0).PreCollectionUpdateEventListeners;

    internal static object I14Fu7WfM5OEFDr6mcA9([In] object obj0) => (object) ((NHProvider) obj0).GetDatabaseServerVersion();

    internal static bool cxXYbtWfJMPuush3bYtr([In] object obj0, [In] object obj1) => (Version) obj0 != (Version) obj1;

    internal static object c8ZMxaWf9rHmaYXnrCVP([In] object obj0) => (object) ((NHProvider) obj0).MinServerVersion;

    internal static bool FmDlifWfdX7nrerqLLxt([In] object obj0, [In] object obj1) => (Version) obj0 < (Version) obj1;

    internal static object ebDyAaWfljOX9CHiTf0c([In] object obj0) => (object) ((AbstractProvider) obj0).Name;

    internal static object XdeeCJWfr9tvOZp7MCC0([In] object obj0, [In] object obj1) => (object) ((NHProvider) obj0).GetDatabaseServerName((Version) obj1);

    internal static void s0txMIWfg1uY1yZ3XkYY() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static Guid pjWS22Wf5EUq1e6PDuQi([In] object obj0) => ((INHProviderDependentUserTypeRegistrar) obj0).ProviderUid;

    internal static Guid twb10qWfj6Qd8pYRnvNf([In] object obj0) => ((AbstractProvider) obj0).Uid;

    internal static Guid m0aRYsWfYrYqHXfylIwd([In] object obj0) => ((IDbStructureExtension) obj0).ProviderUid;

    internal static Guid LvRNe1WfLwEAKyMAm7fh([In] object obj0) => ((IDbUpdateHandler) obj0).ProviderUid;
  }
}
