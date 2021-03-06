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
    ///The HelpInSIT recording.
    /// </summary>
    [TestModule("5a295b99-b0e5-4e4a-8a28-66df83f99202", ModuleType.Recording, 1)]
    public partial class HelpInSIT : ITestModule
    {
        /// <summary>
        /// Holds an instance of the testtooltipRepository repository.
        /// </summary>
        public static testtooltipRepository repo = testtooltipRepository.Instance;

        static HelpInSIT instance = new HelpInSIT();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public HelpInSIT()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static HelpInSIT Instance
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Help') on item 'SYSTRANInteractiveTranslator1.Help'.", repo.SYSTRANInteractiveTranslator1.HelpInfo, new RecordItemIndex(0));
            Validate.Attribute(repo.SYSTRANInteractiveTranslator1.HelpInfo, "Text", "Help");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SYSTRANInteractiveTranslator1.Help' at 6;10.", repo.SYSTRANInteractiveTranslator1.HelpInfo, new RecordItemIndex(1));
            repo.SYSTRANInteractiveTranslator1.Help.Click("6;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='http://support.systran.net/desktop/tutorial/systran-interactive-translator/') on item 'HowToPerformTranslationsAndLookupT.Address'.", repo.HowToPerformTranslationsAndLookupT.AddressInfo, new RecordItemIndex(2));
            Validate.Attribute(repo.HowToPerformTranslationsAndLookupT.AddressInfo, "Text", "http://support.systran.net/desktop/tutorial/systran-interactive-translator/");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
