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
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace testtooltip
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The PresenceOfElementsInHistory recording.
    /// </summary>
    [TestModule("95608af8-c09a-4a14-b164-193f2bde2fde", ModuleType.Recording, 1)]
    public partial class PresenceOfElementsInHistory : ITestModule
    {
        /// <summary>
        /// Holds an instance of the testtooltipRepository repository.
        /// </summary>
        public static testtooltipRepository repo = testtooltipRepository.Instance;

        static PresenceOfElementsInHistory instance = new PresenceOfElementsInHistory();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public PresenceOfElementsInHistory()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static PresenceOfElementsInHistory Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "5.4.5")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "5.4.5")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SYSTRANInteractiveTranslator1.History' at 6;5.", repo.SYSTRANInteractiveTranslator1.HistoryInfo, new RecordItemIndex(0));
            repo.SYSTRANInteractiveTranslator1.History.Click("6;5");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse None Move item 'SYSTRANInteractiveTranslator1.SomeContainer1.HeaderSite1' at 1760;11.", repo.SYSTRANInteractiveTranslator1.SomeContainer1.HeaderSite1Info, new RecordItemIndex(1));
            repo.SYSTRANInteractiveTranslator1.SomeContainer1.HeaderSite1.MoveTo("1760;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse None Move item 'SYSTRANInteractiveTranslator1.SomeContainer1.Purge' at 18;6.", repo.SYSTRANInteractiveTranslator1.SomeContainer1.PurgeInfo, new RecordItemIndex(2));
            repo.SYSTRANInteractiveTranslator1.SomeContainer1.Purge.MoveTo("18;6");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Purge old translations') on item 'PurgeOldTranslations'.", repo.PurgeOldTranslations.SelfInfo, new RecordItemIndex(3));
            Validate.Attribute(repo.PurgeOldTranslations.SelfInfo, "Text", "Purge old translations");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse None Move item 'SYSTRANInteractiveTranslator1.SomeContainer1.Grid' at 458;11.", repo.SYSTRANInteractiveTranslator1.SomeContainer1.GridInfo, new RecordItemIndex(4));
            repo.SYSTRANInteractiveTranslator1.SomeContainer1.Grid.MoveTo("458;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse None Move item 'SYSTRANInteractiveTranslator1.SomeContainer1.Background6' at 5;17.", repo.SYSTRANInteractiveTranslator1.SomeContainer1.Background6Info, new RecordItemIndex(5));
            repo.SYSTRANInteractiveTranslator1.SomeContainer1.Background6.MoveTo("5;17");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Refresh') on item 'Refresh'.", repo.Refresh.SelfInfo, new RecordItemIndex(6));
            Validate.Attribute(repo.Refresh.SelfInfo, "Text", "Refresh");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
