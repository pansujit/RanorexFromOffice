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

namespace LanguageManager
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The License_page_Verification recording.
    /// </summary>
    [TestModule("ffb2126c-01d5-446d-9a55-c6f804785821", ModuleType.Recording, 1)]
    public partial class License_page_Verification : ITestModule
    {
        /// <summary>
        /// Holds an instance of the LanguageManagerRepository repository.
        /// </summary>
        public static LanguageManagerRepository repo = LanguageManagerRepository.Instance;

        static License_page_Verification instance = new License_page_Verification();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public License_page_Verification()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static License_page_Verification Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SYSTRANLanguageManager1.Licenses' at 55;24.", repo.SYSTRANLanguageManager1.LicensesInfo, new RecordItemIndex(0));
            repo.SYSTRANLanguageManager1.Licenses.Click("55;24");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Licenses') on item 'SYSTRANLanguageManager1.Licenses1'.", repo.SYSTRANLanguageManager1.Licenses1Info, new RecordItemIndex(1));
            Validate.Attribute(repo.SYSTRANLanguageManager1.Licenses1Info, "InnerText", "Licenses");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='\nAdd Product Key') on item 'SYSTRANLanguageManager1.AddProductKeyButton'.", repo.SYSTRANLanguageManager1.AddProductKeyButtonInfo, new RecordItemIndex(2));
            Validate.Attribute(repo.SYSTRANLanguageManager1.AddProductKeyButtonInfo, "InnerText", "\nAdd Product Key");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
