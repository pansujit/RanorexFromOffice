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
    ///The ValidationZeroZoom recording.
    /// </summary>
    [TestModule("6a7a7e85-dee4-40e1-a032-0b2252236261", ModuleType.Recording, 1)]
    public partial class ValidationZeroZoom : ITestModule
    {
        /// <summary>
        /// Holds an instance of the testtooltipRepository repository.
        /// </summary>
        public static testtooltipRepository repo = testtooltipRepository.Instance;

        static ValidationZeroZoom instance = new ValidationZeroZoom();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidationZeroZoom()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ValidationZeroZoom Instance
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

            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot3' with region {X=0,Y=0,Width=271,Height=24}) on item 'SYSTRANInteractiveTranslator1.SomeContainer1.SomeText'.", repo.SYSTRANInteractiveTranslator1.SomeContainer1.SomeTextInfo, new RecordItemIndex(0));
            Validate.ContainsImage(repo.SYSTRANInteractiveTranslator1.SomeContainer1.SomeTextInfo, SomeText_Screenshot3, SomeText_Screenshot3_Options);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
        CompressedImage SomeText_Screenshot3
        { get { return repo.SYSTRANInteractiveTranslator1.SomeContainer1.SomeTextInfo.GetScreenshot3(new Rectangle(0, 0, 271, 24)); } }

        Imaging.FindOptions SomeText_Screenshot3_Options
        { get { return Imaging.FindOptions.Default; } }

#endregion
    }
#pragma warning restore 0436
}
