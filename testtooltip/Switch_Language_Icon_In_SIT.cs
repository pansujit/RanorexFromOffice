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
    ///The Switch_Language_Icon_In_SIT recording.
    /// </summary>
    [TestModule("3d44ff0b-d5a2-4de6-8ebe-4738d4dc79c6", ModuleType.Recording, 1)]
    public partial class Switch_Language_Icon_In_SIT : ITestModule
    {
        /// <summary>
        /// Holds an instance of the testtooltipRepository repository.
        /// </summary>
        public static testtooltipRepository repo = testtooltipRepository.Instance;

        static Switch_Language_Icon_In_SIT instance = new Switch_Language_Icon_In_SIT();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Switch_Language_Icon_In_SIT()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Switch_Language_Icon_In_SIT Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse None Move item 'SYSTRANInteractiveTranslator.MSrcRichTextBox' at 279;133.", repo.SYSTRANInteractiveTranslator.MSrcRichTextBoxInfo, new RecordItemIndex(0));
            repo.SYSTRANInteractiveTranslator.MSrcRichTextBox.MoveTo("279;133");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse None Move item 'SYSTRANInteractiveTranslator.Image' at 11;7.", repo.SYSTRANInteractiveTranslator.ImageInfo, new RecordItemIndex(1));
            repo.SYSTRANInteractiveTranslator.Image.MoveTo("11;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Exchange source and target languages') on item 'ExchangeSourceAndTargetLanguages'.", repo.ExchangeSourceAndTargetLanguages.SelfInfo, new RecordItemIndex(2));
            Validate.Attribute(repo.ExchangeSourceAndTargetLanguages.SelfInfo, "Text", "Exchange source and target languages");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}