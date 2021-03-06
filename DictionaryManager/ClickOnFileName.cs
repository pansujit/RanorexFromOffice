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
    ///The ClickOnFileName recording.
    /// </summary>
    [TestModule("7425ee06-de9a-4a86-be77-ba23a751b4e5", ModuleType.Recording, 1)]
    public partial class ClickOnFileName : ITestModule
    {
        /// <summary>
        /// Holds an instance of the DictionaryManagerRepository repository.
        /// </summary>
        public static DictionaryManagerRepository repo = DictionaryManagerRepository.Instance;

        static ClickOnFileName instance = new ClickOnFileName();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ClickOnFileName()
        {
            Filename = "none";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ClickOnFileName Instance
        {
            get { return instance; }
        }

#region Variables

        string _Filename;

        /// <summary>
        /// Gets or sets the value of variable Filename.
        /// </summary>
        [TestVariable("af95faed-677c-4eef-a813-50f84d067493")]
        public string Filename
        {
            get { return _Filename; }
            set { _Filename = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Import.TypeFileName' at Center.", repo.Import.TypeFileNameInfo, new RecordItemIndex(0));
            repo.Import.TypeFileName.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Filename' with focus on 'Import.TypeFileName'.", repo.Import.TypeFileNameInfo, new RecordItemIndex(1));
            repo.Import.TypeFileName.PressKeys(Filename);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Import.ButtonOpenInImport' at Center.", repo.Import.ButtonOpenInImportInfo, new RecordItemIndex(2));
            repo.Import.ButtonOpenInImport.Click();
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
