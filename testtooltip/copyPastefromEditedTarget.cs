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
    ///The copyPastefromEditedTarget recording.
    /// </summary>
    [TestModule("3798758b-f006-47e9-84b3-91fc2a92af51", ModuleType.Recording, 1)]
    public partial class CopyPastefromEditedTarget : ITestModule
    {
        /// <summary>
        /// Holds an instance of the testtooltipRepository repository.
        /// </summary>
        public static testtooltipRepository repo = testtooltipRepository.Instance;

        static CopyPastefromEditedTarget instance = new CopyPastefromEditedTarget();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CopyPastefromEditedTarget()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CopyPastefromEditedTarget Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "6.0")]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "6.0")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Application", "Run application 'C:\\Program Files (x86)\\SYSTRAN 8 TRANSLATOR\\applications\\SYSTRAN.InteractiveTranslator.exe' with arguments '' in normal mode.", new RecordItemIndex(0));
            Host.Local.RunApplication("C:\\Program Files (x86)\\SYSTRAN 8 TRANSLATOR\\applications\\SYSTRAN.InteractiveTranslator.exe", "", "C:\\Program Files (x86)\\SYSTRAN 8 TRANSLATOR\\applications", false);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SYSTRANInteractiveTranslator1.SomeContainer1.SomeElement1' at 59;19.", repo.SYSTRANInteractiveTranslator1.SomeContainer1.SomeElement1Info, new RecordItemIndex(1));
            repo.SYSTRANInteractiveTranslator1.SomeContainer1.SomeElement1.Click("59;19");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'hello'.", new RecordItemIndex(2));
            Keyboard.Press("hello");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SYSTRANInteractiveTranslator1.SomeContainer1.Translate' at 10;8.", repo.SYSTRANInteractiveTranslator1.SomeContainer1.TranslateInfo, new RecordItemIndex(3));
            repo.SYSTRANInteractiveTranslator1.SomeContainer1.Translate.Click("10;8");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SYSTRANInteractiveTranslator1.SomeContainer1.Background' at 23;10.", repo.SYSTRANInteractiveTranslator1.SomeContainer1.BackgroundInfo, new RecordItemIndex(4));
            repo.SYSTRANInteractiveTranslator1.SomeContainer1.Background.Click("23;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'je{Space}suis{Space}desome{Back}{Back}le'.", new RecordItemIndex(5));
            Keyboard.Press("je{Space}suis{Space}desome{Back}{Back}le");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SYSTRANInteractiveTranslator1.SomeContainer1.SomeElement3' at 3;5.", repo.SYSTRANInteractiveTranslator1.SomeContainer1.SomeElement3Info, new RecordItemIndex(6));
            repo.SYSTRANInteractiveTranslator1.SomeContainer1.SomeElement3.Click("3;5");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SYSTRAN.Cancel' at 69;14.", repo.SYSTRAN.CancelInfo, new RecordItemIndex(7));
            repo.SYSTRAN.Cancel.Click("69;14");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SYSTRANInteractiveTranslator1.SomeContainer1.SomeElement4' at 7;6.", repo.SYSTRANInteractiveTranslator1.SomeContainer1.SomeElement4Info, new RecordItemIndex(8));
            repo.SYSTRANInteractiveTranslator1.SomeContainer1.SomeElement4.Click("7;6");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SYSTRANInteractiveTranslator1.SomeContainer1.SomeElement1' at 90;50.", repo.SYSTRANInteractiveTranslator1.SomeContainer1.SomeElement1Info, new RecordItemIndex(9));
            repo.SYSTRANInteractiveTranslator1.SomeContainer1.SomeElement1.Click("90;50");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back}{Back}{Back}'.", new RecordItemIndex(10));
            Keyboard.Press("{Back}{Back}{Back}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}'.", new RecordItemIndex(11));
            Keyboard.Press("{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SYSTRANInteractiveTranslator1.SomeContainer1.Background1' at 20;14.", repo.SYSTRANInteractiveTranslator1.SomeContainer1.Background1Info, new RecordItemIndex(12));
            repo.SYSTRANInteractiveTranslator1.SomeContainer1.Background1.Click("20;14");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SYSTRANInteractiveTranslator1.SomeContainer1.SomeElement5' at 63;16.", repo.SYSTRANInteractiveTranslator1.SomeContainer1.SomeElement5Info, new RecordItemIndex(13));
            repo.SYSTRANInteractiveTranslator1.SomeContainer1.SomeElement5.Click("63;16");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back 12}'.", new RecordItemIndex(14));
            Keyboard.Press("{Back 12}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click item 'SYSTRANInteractiveTranslator1.SomeContainer1.SomeElement1' at 37;12.", repo.SYSTRANInteractiveTranslator1.SomeContainer1.SomeElement1Info, new RecordItemIndex(15));
            repo.SYSTRANInteractiveTranslator1.SomeContainer1.SomeElement1.Click(System.Windows.Forms.MouseButtons.Right, "37;12");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SYSTRANInteractiveTranslator2.ElementBg' at 67;21.", repo.SYSTRANInteractiveTranslator2.ElementBgInfo, new RecordItemIndex(16));
            repo.SYSTRANInteractiveTranslator2.ElementBg.Click("67;21");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SYSTRANInteractiveTranslator1.SomeElement' at 10;6.", repo.SYSTRANInteractiveTranslator1.SomeElementInfo, new RecordItemIndex(17));
            repo.SYSTRANInteractiveTranslator1.SomeElement.Click("10;6");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
