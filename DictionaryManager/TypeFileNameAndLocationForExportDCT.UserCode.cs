﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
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

namespace DictionaryManager
{
    public partial class TypeFileNameAndLocationForExportDCT
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void Validate_TreeItemENUserNormalization()
        {
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SYSTRANDictionaryManager.OpenDictionary.DictionariesName.TreeItemENUserNormalization'.", repo.SYSTRANDictionaryManager.OpenDictionary.DictionariesName.TreeItemENUserNormalizationInfo);
            Validate.Exists(repo.SYSTRANDictionaryManager.OpenDictionary.DictionariesName.TreeItemENUserNormalizationInfo);
        }

        public void Validate_SystemItemNameDisplay()
        {
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'ExportDictionaries.SystemItemNameDisplay'.", repo.ExportDictionaries.SystemItemNameDisplayInfo);
            Validate.Exists(repo.ExportDictionaries.SystemItemNameDisplayInfo);
        }

    }
}