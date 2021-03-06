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

namespace QFT
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The XmlFileFormatAndLocation recording.
    /// </summary>
    [TestModule("35a5a9b5-1d8d-4ae1-bc52-d0f1eaefa4fa", ModuleType.Recording, 1)]
    public partial class XmlFileFormatAndLocation : ITestModule
    {
        /// <summary>
        /// Holds an instance of the QFTRepository repository.
        /// </summary>
        public static QFTRepository repo = QFTRepository.Instance;

        static XmlFileFormatAndLocation instance = new XmlFileFormatAndLocation();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public XmlFileFormatAndLocation()
        {
            varLocation = "None";
            varFormat = "None";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static XmlFileFormatAndLocation Instance
        {
            get { return instance; }
        }

#region Variables

        string _varLocation;

        /// <summary>
        /// Gets or sets the value of variable varLocation.
        /// </summary>
        [TestVariable("9c6875a2-e889-4c7a-8f77-fdea22dd1552")]
        public string varLocation
        {
            get { return _varLocation; }
            set { _varLocation = value; }
        }

        string _varFormat;

        /// <summary>
        /// Gets or sets the value of variable varFormat.
        /// </summary>
        [TestVariable("23e74468-6523-463b-8810-2ff7798f1540")]
        public string varFormat
        {
            get { return _varFormat; }
            set { _varFormat = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "5.4.6")]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "5.4.6")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SYSTRANQuickFileTranslator.SomeElement' at 93;4.", repo.SYSTRANQuickFileTranslator.SomeElementInfo, new RecordItemIndex(0));
            repo.SYSTRANQuickFileTranslator.SomeElement.Click("93;4");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press.", new RecordItemIndex(1));
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 16, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$varLocation'.", new RecordItemIndex(2));
            Keyboard.Press(varLocation);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SYSTRANQuickFileTranslator.SomeElement1' at 56;4.", repo.SYSTRANQuickFileTranslator.SomeElement1Info, new RecordItemIndex(3));
            repo.SYSTRANQuickFileTranslator.SomeElement1.Click("56;4");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press.", new RecordItemIndex(4));
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 16, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$varFormat'.", new RecordItemIndex(5));
            Keyboard.Press(varFormat);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(6));
            Delay.Duration(500, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
