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
    ///The ValidateMaxZoom recording.
    /// </summary>
    [TestModule("1c3790bb-934d-44ad-b5d3-4d2bfafa708b", ModuleType.Recording, 1)]
    public partial class ValidateMaxZoom : ITestModule
    {
        /// <summary>
        /// Holds an instance of the testtooltipRepository repository.
        /// </summary>
        public static testtooltipRepository repo = testtooltipRepository.Instance;

        static ValidateMaxZoom instance = new ValidateMaxZoom();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateMaxZoom()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ValidateMaxZoom Instance
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

            Report.Log(ReportLevel.Info, "Validation", "Validating CompareImage (Screenshot: 'Screenshot2' with region {X=1,Y=0,Width=210,Height=42}) on item 'SYSTRANInteractiveTranslator1.SomeContainer1.SomeText'.", repo.SYSTRANInteractiveTranslator1.SomeContainer1.SomeTextInfo, new RecordItemIndex(0));
            Validate.CompareImage(repo.SYSTRANInteractiveTranslator1.SomeContainer1.SomeTextInfo, SomeText_Screenshot2, SomeText_Screenshot2_Options);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
        CompressedImage SomeText_Screenshot2
        { get { return repo.SYSTRANInteractiveTranslator1.SomeContainer1.SomeTextInfo.GetScreenshot2(new Rectangle(1, 0, 210, 42)); } }

        Imaging.FindOptions SomeText_Screenshot2_Options
        { get { return Imaging.FindOptions.Parse("1;None;1,0,210,42;True;10000000;0ms"); } }

#endregion
    }
#pragma warning restore 0436
}