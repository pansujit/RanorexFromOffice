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
    ///The InputNormalizationName recording.
    /// </summary>
    [TestModule("d260afe0-3fd4-47af-938c-6c0224e6127d", ModuleType.Recording, 1)]
    public partial class InputNormalizationName : ITestModule
    {
        /// <summary>
        /// Holds an instance of the DictionaryManagerRepository repository.
        /// </summary>
        public static DictionaryManagerRepository repo = DictionaryManagerRepository.Instance;

        static InputNormalizationName instance = new InputNormalizationName();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public InputNormalizationName()
        {
            NormalizedDictName = "UserNormalization";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static InputNormalizationName Instance
        {
            get { return instance; }
        }

#region Variables

        string _NormalizedDictName;

        /// <summary>
        /// Gets or sets the value of variable NormalizedDictName.
        /// </summary>
        [TestVariable("5b715caf-e2d6-4eec-8876-3d86ee69e5c4")]
        public string NormalizedDictName
        {
            get { return _NormalizedDictName; }
            set { _NormalizedDictName = value; }
        }

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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewDictionaryBase.TextFields.DictName' at Center.", repo.NewDictionaryBase.TextFields.DictNameInfo, new RecordItemIndex(0));
            repo.NewDictionaryBase.TextFields.DictName.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$NormalizedDictName'.", new RecordItemIndex(1));
            Keyboard.Press(NormalizedDictName);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
