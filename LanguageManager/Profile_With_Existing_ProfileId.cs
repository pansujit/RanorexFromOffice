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
    ///The Profile_With_Existing_ProfileId recording.
    /// </summary>
    [TestModule("2f265d1f-29b0-4627-b35d-424b41d3d3fa", ModuleType.Recording, 1)]
    public partial class Profile_With_Existing_ProfileId : ITestModule
    {
        /// <summary>
        /// Holds an instance of the LanguageManagerRepository repository.
        /// </summary>
        public static LanguageManagerRepository repo = LanguageManagerRepository.Instance;

        static Profile_With_Existing_ProfileId instance = new Profile_With_Existing_ProfileId();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Profile_With_Existing_ProfileId()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Profile_With_Existing_ProfileId Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SYSTRANLanguageManager1.AddProfile' at 29;24.", repo.SYSTRANLanguageManager1.AddProfileInfo, new RecordItemIndex(0));
            repo.SYSTRANLanguageManager1.AddProfile.Click("29;24");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SYSTRANLanguageManager1.SomeBTag' at 8;18.", repo.SYSTRANLanguageManager1.SomeBTagInfo, new RecordItemIndex(1));
            repo.SYSTRANLanguageManager1.SomeBTag.Click("8;18");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SYSTRANLanguageManager1.Select2ResultLabel3' at 67;17.", repo.SYSTRANLanguageManager1.Select2ResultLabel3Info, new RecordItemIndex(2));
            repo.SYSTRANLanguageManager1.Select2ResultLabel3.Click("67;17");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SYSTRANLanguageManager1.SomeBTag1' at 9;15.", repo.SYSTRANLanguageManager1.SomeBTag1Info, new RecordItemIndex(3));
            repo.SYSTRANLanguageManager1.SomeBTag1.Click("9;15");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SYSTRANLanguageManager1.Select2ResultLabel4' at 74;13.", repo.SYSTRANLanguageManager1.Select2ResultLabel4Info, new RecordItemIndex(4));
            repo.SYSTRANLanguageManager1.Select2ResultLabel4.Click("74;13");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SYSTRANLanguageManager1.SelectLanguagesSubmit' at 29;13.", repo.SYSTRANLanguageManager1.SelectLanguagesSubmitInfo, new RecordItemIndex(5));
            repo.SYSTRANLanguageManager1.SelectLanguagesSubmit.Click("29;13");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SYSTRANLanguageManager1.InputNewProfileName' at 44;20.", repo.SYSTRANLanguageManager1.InputNewProfileNameInfo, new RecordItemIndex(6));
            repo.SYSTRANLanguageManager1.InputNewProfileName.Click("44;20");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Profile_With_Existing_ProfileId' with focus on 'SYSTRANLanguageManager1.InputNewProfileName'.", repo.SYSTRANLanguageManager1.InputNewProfileNameInfo, new RecordItemIndex(7));
            repo.SYSTRANLanguageManager1.InputNewProfileName.PressKeys("Profile_With_Existing_ProfileId");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SYSTRANLanguageManager1.InputProfileId' at 46;15.", repo.SYSTRANLanguageManager1.InputProfileIdInfo, new RecordItemIndex(8));
            repo.SYSTRANLanguageManager1.InputProfileId.Click("46;15");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '1' with focus on 'SYSTRANLanguageManager1.InputProfileId'.", repo.SYSTRANLanguageManager1.InputProfileIdInfo, new RecordItemIndex(9));
            repo.SYSTRANLanguageManager1.InputProfileId.PressKeys("1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SYSTRANLanguageManager1.Checkbox1' at 2;5.", repo.SYSTRANLanguageManager1.Checkbox1Info, new RecordItemIndex(10));
            repo.SYSTRANLanguageManager1.Checkbox1.Click("2;5");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SYSTRANLanguageManager1.SubmitAddProfile' at 13;14.", repo.SYSTRANLanguageManager1.SubmitAddProfileInfo, new RecordItemIndex(11));
            repo.SYSTRANLanguageManager1.SubmitAddProfile.Click("13;14");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='This Id has already existed !') on item 'SYSTRANLanguageManager1.ProfileIdHelp'.", repo.SYSTRANLanguageManager1.ProfileIdHelpInfo, new RecordItemIndex(12));
            Validate.Attribute(repo.SYSTRANLanguageManager1.ProfileIdHelpInfo, "InnerText", "This Id has already existed !");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SYSTRANLanguageManager1.Close' at 34;12.", repo.SYSTRANLanguageManager1.CloseInfo, new RecordItemIndex(13));
            repo.SYSTRANLanguageManager1.Close.Click("34;12");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
