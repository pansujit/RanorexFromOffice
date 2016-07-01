/*
 * Created by Ranorex
 * User: pandey
 * Date: 4/14/2016
 * Time: 2:29 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;
using Excel;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
namespace testAutomation
{
	/// <summary>
	/// Description of ClickOnPackage.
	/// </summary>
	[TestModule("3861D624-9F27-4601-9E27-85B13C37B5C1", ModuleType.UserCode, 1)]
	public class ClickOnPackage : ITestModule
	{
		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public ClickOnPackage()
		{
			// Do not delete - a parameterless constructor is required!
			SearchName = "none";
			
			
		}
		
		

		/// <summary>
		/// Gets or sets the value of variable testVar.
		/// </summary>
		string _SearchName;
		public static bool flag=false;
		public int test=0;
		public int tps=1;
		[TestVariable("3274c05f-8756-4eed-a3d3-871387615427")]
		public string SearchName
		{
			get { return _SearchName; }
			set { _SearchName = value; }
		}

		/// <summary>
		/// Performs the playback of actions in this module.
		/// </summary>
		/// <remarks>You should not call this method directly, instead pass the module
		/// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
		/// that will in turn invoke this method.</remarks>
		void ITestModule.Run()
		{
			Mouse.DefaultMoveTime = 300;
			Keyboard.DefaultKeyPressTime = 100;
			Delay.SpeedFactor = 1.0;
			//My Code Start Here
			// Creating an instance
			var repo = testAutomationRepository.Instance;
			
			//declaring list of all variables (WebElements)
			var packages = repo.TranslationResources.Packages;
			
			//This condition will check the visibility of package and click
			if (packages.Visible){
				packages.Click("46;24");
				Delay.Seconds(2);
			}
			else{
				Console.WriteLine("Bye");
			}
			var filterPackage = repo.Packages.FilterPackage;
			filterPackage.Click();
			filterPackage.PressKeys(SearchName);
			Delay.Seconds(3);
			var getVersion = repo.Packages.getVersion;
			var testData=getVersion.InnerText.ToString();
			System.Diagnostics.Debug.WriteLine("Hello");
			System.Diagnostics.Debug.WriteLine(testData);
			Delay.Seconds(2);
			
			string str;
			int rCnt = 0;
			int cCnt = 0;
			Excel.Application xlApp ;
			Excel.Workbook xlWorkBook ;
			Excel.Worksheet xlWorkSheet;
			Excel.Range range ;
			
			xlApp = new Excel.Application();
			//xlWorkBook = xlApp.Workbooks.Open("test.xlsx", 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
			System.Diagnostics.Debug.WriteLine(SearchName);
			xlWorkBook= xlApp.Workbooks.Open(string.Format("C:\\Users\\pandey\\Documents\\Ranorex\\RanorexStudio Projects\\testtooltip\\AutomationExample\\{0}.xlsx",SearchName));
			xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
			range = xlWorkSheet.UsedRange;
			for (rCnt = 1; rCnt <= range.Rows.Count; rCnt++)
			{
				for (cCnt = 1; cCnt <= range.Columns.Count; cCnt++)
				{
					str = (string)(range.Cells[rCnt, cCnt] as Excel.Range).Value2 ;
					if(testData==str){
						flag=true;
						break;
					}
				}
				
			}
			xlWorkBook.Close(true, null, null);
			xlApp.Quit();
			if(!flag){
				Console.WriteLine("Bye");
				xlApp = new Excel.Application();
				//xlWorkBook = xlApp.Workbooks.Open("test.xlsx", 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
				xlWorkBook= xlApp.Workbooks.Open(string.Format("C:\\Users\\pandey\\Documents\\Ranorex\\RanorexStudio Projects\\testtooltip\\AutomationExample\\{0}.xlsx",SearchName));
				xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
				range = xlWorkSheet.UsedRange;
				//range.Value2=testData;
				xlApp.Cells[rCnt,1]=testData;
				//xlApp.Visible = true;
				xlWorkBook.Save();
				xlWorkBook.Close(true, null, null);
				xlApp.Quit();
				
				//Start Download from here
				Delay.Seconds(3);
				//var aTagDownload = repo.test.ATagDownload;
				var aTagDownload = repo.Packages.ATagDownload;
				aTagDownload.EnsureVisible();
				// Mouse.MoveTo(aTagDownload);
				aTagDownload.Click("Center");
				// aTagDownload.PerformClick();
				Delay.Seconds(5);
				var saveFile = repo.OpeningSYSTRAN8TRANSLATORProfessiona.SaveFile;
				saveFile.EnsureVisible();
				saveFile.Click();
				Delay.Seconds(3);
				saveFile.Click();
				//var toolBar1001 = repo.EnterNameOfFileToSaveTo.ToolBar1001;
				//Delay.Seconds(1);
				//toolBar1001.Click();
				Delay.Seconds(3);
				/*var text1001 = repo.EnterNameOfFileToSaveTo.Text1001;
				text1001.Click();
				Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 16, Keyboard.DefaultKeyPressTime, 1, true);
				Keyboard.Press(string.Format("C:\\Users\\pandey\\Documents\\{0}",SearchName));
				Keyboard.Press("{Return}");
				Delay.Seconds(3);
				var buttonSave = repo.EnterNameOfFileToSaveTo.ButtonSave;
				buttonSave.Click();
				if (repo.ConfirmSaveAs.ButtonYesInfo.Exists()){
					var buttonYes = repo.ConfirmSaveAs.ButtonYes;
				}
				Delay.Seconds(10);*/
				
				while( tps<=5)
				{
					tps++;
					System.Diagnostics.Debug.WriteLine(tps);
					Delay.Seconds(25);
				}
			}
			

			
			
		}
	}
}
