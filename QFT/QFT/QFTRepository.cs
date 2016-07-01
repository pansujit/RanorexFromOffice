﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace QFT
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the QFTRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "5.4.6")]
    [RepositoryFolder("92f22dce-57ca-4d90-9658-0f48e1d101a4")]
    public partial class QFTRepository : RepoGenBaseFolder
    {
        static QFTRepository instance = new QFTRepository();
        QFTRepositoryFolders.SYSTRANQuickFileTranslatorAppFolder _systranquickfiletranslator;
        QFTRepositoryFolders.SYSTRANQuickFileTranslator1AppFolder _systranquickfiletranslator1;

        /// <summary>
        /// Gets the singleton class instance representing the QFTRepository element repository.
        /// </summary>
        [RepositoryFolder("92f22dce-57ca-4d90-9658-0f48e1d101a4")]
        public static QFTRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public QFTRepository() 
            : base("QFTRepository", "/", null, 0, false, "92f22dce-57ca-4d90-9658-0f48e1d101a4", ".\\RepositoryImages\\QFTRepository92f22dce.rximgres")
        {
            _systranquickfiletranslator = new QFTRepositoryFolders.SYSTRANQuickFileTranslatorAppFolder(this);
            _systranquickfiletranslator1 = new QFTRepositoryFolders.SYSTRANQuickFileTranslator1AppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("92f22dce-57ca-4d90-9658-0f48e1d101a4")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The SYSTRANQuickFileTranslator folder.
        /// </summary>
        [RepositoryFolder("63294ffd-a186-4465-b9d6-556a6c441362")]
        public virtual QFTRepositoryFolders.SYSTRANQuickFileTranslatorAppFolder SYSTRANQuickFileTranslator
        {
            get { return _systranquickfiletranslator; }
        }

        /// <summary>
        /// The SYSTRANQuickFileTranslator1 folder.
        /// </summary>
        [RepositoryFolder("9f0f5564-ca1f-4371-b0f6-ca046d7b8a64")]
        public virtual QFTRepositoryFolders.SYSTRANQuickFileTranslator1AppFolder SYSTRANQuickFileTranslator1
        {
            get { return _systranquickfiletranslator1; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "5.4.6")]
    public partial class QFTRepositoryFolders
    {
        /// <summary>
        /// The SYSTRANQuickFileTranslatorAppFolder folder.
        /// </summary>
        [RepositoryFolder("63294ffd-a186-4465-b9d6-556a6c441362")]
        public partial class SYSTRANQuickFileTranslatorAppFolder : RepoGenBaseFolder
        {
            QFTRepositoryFolders.RootFolder _root;
            RepoItemInfo _someelementInfo;
            RepoItemInfo _someelement1Info;
            RepoItemInfo _searchfilesInfo;

            /// <summary>
            /// Creates a new SYSTRANQuickFileTranslator  folder.
            /// </summary>
            public SYSTRANQuickFileTranslatorAppFolder(RepoGenBaseFolder parentFolder) :
                    base("SYSTRANQuickFileTranslator", "/form[@wpfnative='True' and @title~'^SYSTRAN\\ Quick\\ File\\ Transl' and @processname='SYSTRAN.QuickFileTranslator']", parentFolder, 30000, null, true, "63294ffd-a186-4465-b9d6-556a6c441362", "")
            {
                _root = new QFTRepositoryFolders.RootFolder(this);
                _someelementInfo = new RepoItemInfo(this, "SomeElement", "container/element[1]/container/element[7]/container[@automationid='root']//element[@automationid='transitioning']//element[@automationid='CurrentContentPresentationSite']/container/element/element/container/container/container[@automationid='Grid']/element[@automationid='PART_ScrollContentPresenter']/container/container[2]/container/element[3]/container/container[1]/text[@automationid='mSourceRootFolderTextBox']/?/?/container[@automationid='PART_InnerGrid']/container[@automationid='PART_ContentHost']/container[@automationid='Grid']/element[@automationid='PART_ScrollContentPresenter']/element[1]", 30000, null, "56d5c070-c9b0-48db-9e2a-96759f1b1e83");
                _someelement1Info = new RepoItemInfo(this, "SomeElement1", "container/element[1]/container/element[7]/container[@automationid='root']//element[@automationid='transitioning']//element[@automationid='CurrentContentPresentationSite']/container/element/element/container/container/container[@automationid='Grid']/element[@automationid='PART_ScrollContentPresenter']/container/container[2]/container/element[3]/container/container[2]/text[@automationid='mSourcePatternFilterTextbox']/?/?/container[@automationid='PART_InnerGrid']/container[@automationid='PART_ContentHost']/container[@automationid='Grid']/element[@automationid='PART_ScrollContentPresenter']/element[1]", 30000, null, "5c9fb812-577e-4dd7-8afc-57bed2a24715");
                _searchfilesInfo = new RepoItemInfo(this, "SearchFiles", "container/element[1]/container/element[7]/container[@automationid='root']//element[@automationid='transitioning']//element[@automationid='CurrentContentPresentationSite']/container/?/?/element/container/element/container/container/button[@text='Search files']/?/?/element[@automationid='contentPresenter']/text[@caption='Search files']", 30000, null, "0bcdddc9-cdca-4d4d-b6ed-7dc0d881512f");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("63294ffd-a186-4465-b9d6-556a6c441362")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("63294ffd-a186-4465-b9d6-556a6c441362")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The SomeElement item.
            /// </summary>
            [RepositoryItem("56d5c070-c9b0-48db-9e2a-96759f1b1e83")]
            public virtual Ranorex.Unknown SomeElement
            {
                get
                {
                    return _someelementInfo.CreateAdapter<Ranorex.Unknown>(true);
                }
            }

            /// <summary>
            /// The SomeElement item info.
            /// </summary>
            [RepositoryItemInfo("56d5c070-c9b0-48db-9e2a-96759f1b1e83")]
            public virtual RepoItemInfo SomeElementInfo
            {
                get
                {
                    return _someelementInfo;
                }
            }

            /// <summary>
            /// The SomeElement1 item.
            /// </summary>
            [RepositoryItem("5c9fb812-577e-4dd7-8afc-57bed2a24715")]
            public virtual Ranorex.Unknown SomeElement1
            {
                get
                {
                    return _someelement1Info.CreateAdapter<Ranorex.Unknown>(true);
                }
            }

            /// <summary>
            /// The SomeElement1 item info.
            /// </summary>
            [RepositoryItemInfo("5c9fb812-577e-4dd7-8afc-57bed2a24715")]
            public virtual RepoItemInfo SomeElement1Info
            {
                get
                {
                    return _someelement1Info;
                }
            }

            /// <summary>
            /// The SearchFiles item.
            /// </summary>
            [RepositoryItem("0bcdddc9-cdca-4d4d-b6ed-7dc0d881512f")]
            public virtual Ranorex.Text SearchFiles
            {
                get
                {
                    return _searchfilesInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The SearchFiles item info.
            /// </summary>
            [RepositoryItemInfo("0bcdddc9-cdca-4d4d-b6ed-7dc0d881512f")]
            public virtual RepoItemInfo SearchFilesInfo
            {
                get
                {
                    return _searchfilesInfo;
                }
            }

            /// <summary>
            /// The Root folder.
            /// </summary>
            [RepositoryFolder("d2ba1130-c8ae-4421-9aef-1c48632a7450")]
            public virtual QFTRepositoryFolders.RootFolder Root
            {
                get { return _root; }
            }
        }

        /// <summary>
        /// The RootFolder folder.
        /// </summary>
        [RepositoryFolder("d2ba1130-c8ae-4421-9aef-1c48632a7450")]
        public partial class RootFolder : RepoGenBaseFolder
        {
            RepoItemInfo _durationInfo;
            RepoItemInfo _targetInfo;
            RepoItemInfo _translateInfo;
            RepoItemInfo _backgroundInfo;

            /// <summary>
            /// Creates a new Root  folder.
            /// </summary>
            public RootFolder(RepoGenBaseFolder parentFolder) :
                    base("Root", "container/element[1]/container/element[7]/container[@automationid='root']", parentFolder, 30000, null, false, "d2ba1130-c8ae-4421-9aef-1c48632a7450", "")
            {
                _durationInfo = new RepoItemInfo(this, "Duration", ".//element[@automationid='transitioning']//element[@automationid='CurrentContentPresentationSite']//tabpagelist/?/?/container[@automationid='HeaderPanel']/tabpage[@title='1/1']/table/?/?/container[@automationid='DG_ScrollViewer']/?/?/container[@automationid='PART_ColumnHeadersPresenter']/container/list/?/?/cell[@text='Duration']/container//text[@caption='Duration']", 30000, null, "d1767192-eedb-49c8-ac44-2d1b5b4c9263");
                _targetInfo = new RepoItemInfo(this, "Target", ".//element[@automationid='transitioning']//element[@automationid='CurrentContentPresentationSite']//tabpagelist/?/?/container[@automationid='HeaderPanel']/tabpage[@title='1/1']/table/?/?/container[@automationid='DG_ScrollViewer']/container/container[2]/element[@automationid='PART_ScrollContentPresenter']/list/container[@automationid='PART_RowsPresenter']/row[@index='0']/element[@automationid='DGR_Border']/container/list/list/?/?/cell[@columnindex='1']//text[@caption='Target']", 30000, null, "0d816f69-4741-44e5-bb47-ed9cf7013a3c");
                _translateInfo = new RepoItemInfo(this, "Translate", ".//element[@automationid='transitioning']/?/?/container/element[@automationid='CurrentContentPresentationSite']/container/element/element/container/element/container/container[2]/button[@text='Translate']/?/?/element[@automationid='contentPresenter']/text[@caption='Translate']", 30000, null, "0cb3c0ca-5cae-4858-bdd8-816b11558b83");
                _backgroundInfo = new RepoItemInfo(this, "Background", ".//element[@automationid='transitioning']//element[@automationid='CurrentContentPresentationSite']/container/element/element/container/container/container[@automationid='Grid']/element[@automationid='PART_ScrollContentPresenter']/container/container[1]/container/element[3]/container/element/element/container/combobox[3]/container/container/checkbox[@automationid='PART_DropDownToggle']/container[@automationid='ToggleButtonRootGrid']/element[@automationid='Background']", 30000, null, "6d3bd778-e9f0-4cab-839a-7f9919f5961c");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("d2ba1130-c8ae-4421-9aef-1c48632a7450")]
            public virtual Ranorex.Container Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Container>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("d2ba1130-c8ae-4421-9aef-1c48632a7450")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Duration item.
            /// </summary>
            [RepositoryItem("d1767192-eedb-49c8-ac44-2d1b5b4c9263")]
            public virtual Ranorex.Text Duration
            {
                get
                {
                    return _durationInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Duration item info.
            /// </summary>
            [RepositoryItemInfo("d1767192-eedb-49c8-ac44-2d1b5b4c9263")]
            public virtual RepoItemInfo DurationInfo
            {
                get
                {
                    return _durationInfo;
                }
            }

            /// <summary>
            /// The Target item.
            /// </summary>
            [RepositoryItem("0d816f69-4741-44e5-bb47-ed9cf7013a3c")]
            public virtual Ranorex.Text Target
            {
                get
                {
                    return _targetInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Target item info.
            /// </summary>
            [RepositoryItemInfo("0d816f69-4741-44e5-bb47-ed9cf7013a3c")]
            public virtual RepoItemInfo TargetInfo
            {
                get
                {
                    return _targetInfo;
                }
            }

            /// <summary>
            /// The Translate item.
            /// </summary>
            [RepositoryItem("0cb3c0ca-5cae-4858-bdd8-816b11558b83")]
            public virtual Ranorex.Text Translate
            {
                get
                {
                    return _translateInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Translate item info.
            /// </summary>
            [RepositoryItemInfo("0cb3c0ca-5cae-4858-bdd8-816b11558b83")]
            public virtual RepoItemInfo TranslateInfo
            {
                get
                {
                    return _translateInfo;
                }
            }

            /// <summary>
            /// The Background item.
            /// </summary>
            [RepositoryItem("6d3bd778-e9f0-4cab-839a-7f9919f5961c")]
            public virtual Ranorex.Unknown Background
            {
                get
                {
                    return _backgroundInfo.CreateAdapter<Ranorex.Unknown>(true);
                }
            }

            /// <summary>
            /// The Background item info.
            /// </summary>
            [RepositoryItemInfo("6d3bd778-e9f0-4cab-839a-7f9919f5961c")]
            public virtual RepoItemInfo BackgroundInfo
            {
                get
                {
                    return _backgroundInfo;
                }
            }
        }

        /// <summary>
        /// The SYSTRANQuickFileTranslator1AppFolder folder.
        /// </summary>
        [RepositoryFolder("9f0f5564-ca1f-4371-b0f6-ca046d7b8a64")]
        public partial class SYSTRANQuickFileTranslator1AppFolder : RepoGenBaseFolder
        {
            QFTRepositoryFolders.SomeContainerFolder _somecontainer;

            /// <summary>
            /// Creates a new SYSTRANQuickFileTranslator1  folder.
            /// </summary>
            public SYSTRANQuickFileTranslator1AppFolder(RepoGenBaseFolder parentFolder) :
                    base("SYSTRANQuickFileTranslator1", "/contextmenu[@processname='SYSTRAN.QuickFileTranslator' and @win32ownerwindowlevel='1']", parentFolder, 30000, null, false, "9f0f5564-ca1f-4371-b0f6-ca046d7b8a64", "")
            {
                _somecontainer = new QFTRepositoryFolders.SomeContainerFolder(this);
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("9f0f5564-ca1f-4371-b0f6-ca046d7b8a64")]
            public virtual Ranorex.ContextMenu Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.ContextMenu>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("9f0f5564-ca1f-4371-b0f6-ca046d7b8a64")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The SomeContainer folder.
            /// </summary>
            [RepositoryFolder("89e67297-0a65-4d16-92c0-a1b56da32913")]
            public virtual QFTRepositoryFolders.SomeContainerFolder SomeContainer
            {
                get { return _somecontainer; }
            }
        }

        /// <summary>
        /// The SomeContainerFolder folder.
        /// </summary>
        [RepositoryFolder("89e67297-0a65-4d16-92c0-a1b56da32913")]
        public partial class SomeContainerFolder : RepoGenBaseFolder
        {
            RepoItemInfo _translatorenfrInfo;

            /// <summary>
            /// Creates a new SomeContainer  folder.
            /// </summary>
            public SomeContainerFolder(RepoGenBaseFolder parentFolder) :
                    base("SomeContainer", ".//container[@automationid='DropDownScrollViewer']/container[@automationid='Grid']/element[@automationid='PART_ScrollContentPresenter']/list[@automationid='ItemsPresenter']/container", parentFolder, 30000, null, false, "89e67297-0a65-4d16-92c0-a1b56da32913", "")
            {
                _translatorenfrInfo = new RepoItemInfo(this, "TranslatorEnFr", "listitem[2]/element[@automationid='Bd']//text[@caption='Translator en fr']", 30000, null, "bdde935c-b0b3-4619-8540-2053dbc43fb8");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("89e67297-0a65-4d16-92c0-a1b56da32913")]
            public virtual Ranorex.Container Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Container>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("89e67297-0a65-4d16-92c0-a1b56da32913")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The TranslatorEnFr item.
            /// </summary>
            [RepositoryItem("bdde935c-b0b3-4619-8540-2053dbc43fb8")]
            public virtual Ranorex.Text TranslatorEnFr
            {
                get
                {
                    return _translatorenfrInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The TranslatorEnFr item info.
            /// </summary>
            [RepositoryItemInfo("bdde935c-b0b3-4619-8540-2053dbc43fb8")]
            public virtual RepoItemInfo TranslatorEnFrInfo
            {
                get
                {
                    return _translatorenfrInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}