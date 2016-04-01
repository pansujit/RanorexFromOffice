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

namespace helloproj
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ValidateImportUserDictTMNorm recording.
    /// </summary>
    [TestModule("e6ce057a-06d2-4424-bed2-096d656f1091", ModuleType.Recording, 1)]
    public partial class ValidateImportUserDictTMNorm : ITestModule
    {
        /// <summary>
        /// Holds an instance of the DictionaryManagerRepository repository.
        /// </summary>
        public static DictionaryManagerRepository repo = DictionaryManagerRepository.Instance;

        static ValidateImportUserDictTMNorm instance = new ValidateImportUserDictTMNorm();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateImportUserDictTMNorm()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ValidateImportUserDictTMNorm Instance
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='File &name:') on item 'Import.Text1090'.", repo.Import.Text1090Info, new RecordItemIndex(0));
            Validate.Attribute(repo.Import.Text1090Info, "Text", "File &name:");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Import.Cancel' at 41;10.", repo.Import.CancelInfo, new RecordItemIndex(1));
            repo.Import.Cancel.Click("41;10");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
