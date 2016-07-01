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
    ///The InputDictionaryName recording.
    /// </summary>
    [TestModule("92ca6fde-c3be-4986-9591-dd3aadb41cf5", ModuleType.Recording, 1)]
    public partial class InputDictionaryName : ITestModule
    {
        /// <summary>
        /// Holds an instance of the DictionaryManagerRepository repository.
        /// </summary>
        public static DictionaryManagerRepository repo = DictionaryManagerRepository.Instance;

        static InputDictionaryName instance = new InputDictionaryName();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public InputDictionaryName()
        {
            CreateUserDictName = "UserDict";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static InputDictionaryName Instance
        {
            get { return instance; }
        }

#region Variables

        string _CreateUserDictName;

        /// <summary>
        /// Gets or sets the value of variable CreateUserDictName.
        /// </summary>
        [TestVariable("40517324-1c6d-470d-a32f-a2ce5533ab27")]
        public string CreateUserDictName
        {
            get { return _CreateUserDictName; }
            set { _CreateUserDictName = value; }
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
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$CreateUserDictName' with focus on 'NewDictionaryBase.TextFields.DictName'.", repo.NewDictionaryBase.TextFields.DictNameInfo, new RecordItemIndex(1));
            repo.NewDictionaryBase.TextFields.DictName.PressKeys(CreateUserDictName);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}