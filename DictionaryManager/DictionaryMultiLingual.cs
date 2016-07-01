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

namespace DictionaryManager
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The DictionaryMultiLingual recording.
    /// </summary>
    [TestModule("3f5843e9-43e6-4d8e-831e-3448a79a7420", ModuleType.Recording, 1)]
    public partial class DictionaryMultiLingual : ITestModule
    {
        /// <summary>
        /// Holds an instance of the DictionaryManagerRepository repository.
        /// </summary>
        public static DictionaryManagerRepository repo = DictionaryManagerRepository.Instance;

        static DictionaryMultiLingual instance = new DictionaryMultiLingual();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DictionaryMultiLingual()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static DictionaryMultiLingual Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DictionaryMenu.DictionaryMultiLingual' at Center.", repo.DictionaryMenu.DictionaryMultiLingualInfo, new RecordItemIndex(0));
            repo.DictionaryMenu.DictionaryMultiLingual.Click();
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}