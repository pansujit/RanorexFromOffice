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
    ///The ValidateAddEntryNormalizedDictionary recording.
    /// </summary>
    [TestModule("46cd7e2a-2b5e-416f-882f-fc068f6852d0", ModuleType.Recording, 1)]
    public partial class ValidateAddEntryNormalizedDictionary : ITestModule
    {
        /// <summary>
        /// Holds an instance of the DictionaryManagerRepository repository.
        /// </summary>
        public static DictionaryManagerRepository repo = DictionaryManagerRepository.Instance;

        static ValidateAddEntryNormalizedDictionary instance = new ValidateAddEntryNormalizedDictionary();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateAddEntryNormalizedDictionary()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ValidateAddEntryNormalizedDictionary Instance
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (AccessibleDescription='Number of entries: 1') on item 'SYSTRANDictionaryManager.ValidateAddEntryUserDictionary.NumberOfEntries1'.", repo.SYSTRANDictionaryManager.ValidateAddEntryUserDictionary.NumberOfEntries1Info, new RecordItemIndex(0));
            Validate.Attribute(repo.SYSTRANDictionaryManager.ValidateAddEntryUserDictionary.NumberOfEntries1Info, "AccessibleDescription", "Number of entries: 1");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='grtea') on item 'SYSTRANDictionaryManager.ValidateAddEntryTranslationMemory.EnglishSourceLanguage'.", repo.SYSTRANDictionaryManager.ValidateAddEntryTranslationMemory.EnglishSourceLanguageInfo, new RecordItemIndex(1));
            Validate.Attribute(repo.SYSTRANDictionaryManager.ValidateAddEntryTranslationMemory.EnglishSourceLanguageInfo, "Text", "grtea");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='great') on item 'SYSTRANDictionaryManager.ValidateAddEntryNormaizedDictionary.EnglishNormalized'.", repo.SYSTRANDictionaryManager.ValidateAddEntryNormaizedDictionary.EnglishNormalizedInfo, new RecordItemIndex(2));
            Validate.Attribute(repo.SYSTRANDictionaryManager.ValidateAddEntryNormaizedDictionary.EnglishNormalizedInfo, "Text", "great");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}