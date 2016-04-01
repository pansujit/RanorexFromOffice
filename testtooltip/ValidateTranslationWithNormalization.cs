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
    ///The ValidateTranslationWithNormalization recording.
    /// </summary>
    [TestModule("4abde20f-5847-4f31-9f5c-837e051b3d4b", ModuleType.Recording, 1)]
    public partial class ValidateTranslationWithNormalization : ITestModule
    {
        /// <summary>
        /// Holds an instance of the testtooltipRepository repository.
        /// </summary>
        public static testtooltipRepository repo = testtooltipRepository.Instance;

        static ValidateTranslationWithNormalization instance = new ValidateTranslationWithNormalization();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateTranslationWithNormalization()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ValidateTranslationWithNormalization Instance
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='ceci') on item 'SYSTRANInteractiveTranslator.MTgtRichTextBox'.", repo.SYSTRANInteractiveTranslator.MTgtRichTextBoxInfo, new RecordItemIndex(0));
            Validate.Attribute(repo.SYSTRANInteractiveTranslator.MTgtRichTextBoxInfo, "Text", "ceci");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
