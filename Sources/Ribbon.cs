using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading;
using System.IO;
using WordxTex.Properties;
using Microsoft.Office.Interop.Word;
using Microsoft.Office.Tools.Ribbon;
using System.Windows.Forms;
using Microsoft.Office.Tools.Word;
using System.Runtime.InteropServices;

namespace WordxTex
{
    public partial class Ribbon
    {
        public static string Box_Font_Fx;
        public static string Compile_Info;
        public bool Program_Check;


        private void btn_baselineU_Click(object sender, RibbonControlEventArgs e)
        {
            Microsoft.Office.Interop.Word.Document ThisDoc = Globals.ThisAddIn.Application.ActiveDocument;
            if (ThisDoc == null || ThisDoc.ReadOnly)
                return;
            ThisDoc.Application.Selection.Font.Position = ThisDoc.Application.Selection.Font.Position + 1;
        }

        private void btn_baselineRt_Click(object sender, RibbonControlEventArgs e)
        {
            Microsoft.Office.Interop.Word.Document ThisDoc = Globals.ThisAddIn.Application.ActiveDocument;
            if (ThisDoc == null || ThisDoc.ReadOnly)
                return;
            ThisDoc.Application.Selection.Font.Position = 0;
        }

        private void btn_baselineDn_Click(object sender, RibbonControlEventArgs e)
        {
            Microsoft.Office.Interop.Word.Document ThisDoc = Globals.ThisAddIn.Application.ActiveDocument;
            if (ThisDoc == null || ThisDoc.ReadOnly)
                return;
            ThisDoc.Application.Selection.Font.Position = ThisDoc.Application.Selection.Font.Position - 1;

        }

        private void btn_edit_Click(object sender, RibbonControlEventArgs e)
        {
            Microsoft.Office.Interop.Word.Document ThisDoc = Globals.ThisAddIn.Application.ActiveDocument;
            if (ThisDoc == null || ThisDoc.ReadOnly)
                return;
            InlineShapes SelectedObj = ThisDoc.Application.Selection.InlineShapes;
            if (SelectedObj.Count == 0)
                return;
            InlineShape SelectedObjFirst = SelectedObj[1];
            if (!SelectedObjFirst.AlternativeText.Contains("WordxTex_TexContent"))
                return;
            //if (SelectedObj[0].AlternativeText.Length == 0)
            //    return;
            LaTexEdt CodeEditor = new LaTexEdt(false);
            CodeEditor.updateSRC(SelectedObjFirst.AlternativeText);
            CodeEditor.ShowDialog();
        }

        private void btn_insChemStruct_Click(object sender, RibbonControlEventArgs e)
        {
            Microsoft.Office.Interop.Word.Document ThisDoc = Globals.ThisAddIn.Application.ActiveDocument;
            if (ThisDoc == null || ThisDoc.ReadOnly)
                return;
            LaTexEdt CodeEditor = new LaTexEdt(false);
            CodeEditor.updateSRC(Resources.tex_sample_chemstr);
            CodeEditor.Show();
        }

        private void btn_insChemReact_Click(object sender, RibbonControlEventArgs e)
        {
            Microsoft.Office.Interop.Word.Document ThisDoc = Globals.ThisAddIn.Application.ActiveDocument;
            if (ThisDoc == null || ThisDoc.ReadOnly)
                return;
            LaTexEdt CodeEditor = new LaTexEdt(false);
            CodeEditor.updateSRC(Resources.tex_sample_chemrea);
            CodeEditor.Show();
        }

        private void btn_insMath_Click(object sender, RibbonControlEventArgs e)
        {
            Microsoft.Office.Interop.Word.Document ThisDoc = Globals.ThisAddIn.Application.ActiveDocument;
            if (ThisDoc == null || ThisDoc.ReadOnly)
                return;
            LaTexEdt CodeEditor = new LaTexEdt(false);
            CodeEditor.updateSRC(Resources.tex_sample_matheq);
            CodeEditor.Show();
        }

        public static string get_param_value(string param, string name)
        {
            char spep = ';';
            string[] CompileI = param.Split(spep); string[] K;
            foreach (string cI in CompileI)
            {
                K = cI.Split('=');
                if (K[0] == name)
                {
                    return K[1];
                }
            }
            return "";
        }

        private void Ribbon_Load(object sender, RibbonUIEventArgs e)
        {
            Box_Font_Fx = DD_Font_fx.SelectedItem.Tag.ToString();
            Compile_Info = DD_Complier.SelectedItem.Tag.ToString() + ";" + DD_Grapher.SelectedItem.Tag.ToString();
            check_programs();
            Globals.ThisAddIn.Application.WindowSelectionChange += delegate (Selection Sel)
            {
                if (Program_Check == false)
                {
                    btn_edit.Enabled = false;
                    return;
                }
                //Microsoft.Office.Interop.Word.Document ThisDoc = Globals.ThisAddIn.Application.ActiveDocument;
                if (Globals.ThisAddIn.Application.Selection.Type == WdSelectionType.wdSelectionIP)
                {
                    btn_edit.Enabled = false;
                    return;
                }
                EditContent_check(Sel);
            };
            //new Microsoft.Office.Interop.Word.ApplicationEvents4_WindowSelectionChangeEventHandler(ThisDocument_SelectionChange);
        }


        private void EditContent_check(Selection Sel)
        {
            string AlTex;
            try
            {
                AlTex = Sel.InlineShapes[1].AlternativeText;
            }
            catch (System.NullReferenceException e)
            {
                btn_edit.Enabled = false;
                return;
            }
            catch (COMException e)
            {
                btn_edit.Enabled = false;
                return;
            }
            if (AlTex.Contains("WordxTex_TexContent"))
                btn_edit.Enabled = true;
            {

            }
        }
        private void threadT()
        {
            Thread.Sleep(10000);
            MessageBox.Show("AAC");
        }
        private void btn_settings_Click(object sender, RibbonControlEventArgs e)
        {
            return;
            Microsoft.Office.Interop.Word.Document ThisDoc = Globals.ThisAddIn.Application.ActiveDocument;
            string[] exeA = { "winver.exe" };
            string[] exeArgs = { "" };
            wTModule.ProgramQueue pQ = new wTModule.ProgramQueue(exeA, exeArgs);
            pQ.ProgramsRunResult += delegate (object report, EventArgs ev)
            {
                MessageBox.Show(((wTModule.ProgramResult)report).execName);
            };
            Thread t = new Thread(new ThreadStart(pQ.Run));
            //pQ.Run();
            t.Start();
            ThreadStart childref = new ThreadStart(threadT);
            Thread childThread = new Thread(childref);
            childThread.Start();
            string str;
            switch (ThisDoc.Application.Selection.Type)
            {
                case WdSelectionType.wdSelectionBlock:
                    str = "block";
                    break;
                case WdSelectionType.wdSelectionColumn:
                    str = "column";
                    break;
                case WdSelectionType.wdSelectionFrame:
                    str = "frame";
                    break;
                case WdSelectionType.wdSelectionInlineShape:
                    str = "inline shape";
                    break;
                case WdSelectionType.wdSelectionIP:
                    str = "insertion point";
                    break;
                case WdSelectionType.wdSelectionNormal:
                    str = "normal text";
                    break;
                case WdSelectionType.wdNoSelection:
                    str = "no selection";
                    break;
                case WdSelectionType.wdSelectionRow:
                    str = "row";
                    break;
                default:
                    str = "(unknown)";
                    break;
            }
            //ThisDoc.Application.Selection.Font.Size.ToString;
            MessageBox.Show(str, "ShowSelectionType");
            MessageBox.Show(Box_Font_Fx, "ShowSelectionType");
            MessageBox.Show(ThisDoc.Application.Selection.Font.Size.ToString(), "ShowSelectionType");

        }

        private void btn_insplot_Click(object sender, RibbonControlEventArgs e)
        {
            Microsoft.Office.Interop.Word.Document ThisDoc = Globals.ThisAddIn.Application.ActiveDocument;
            if (ThisDoc == null || ThisDoc.ReadOnly)
                return;
            LaTexEdt CodeEditor = new LaTexEdt(false);
            CodeEditor.updateSRC(Resources.tex_sample_plot);
            CodeEditor.ShowDialog();
        }

        private void DD_Font_fx_SelectionChanged(object sender, RibbonControlEventArgs e)
        {
            Box_Font_Fx = DD_Font_fx.SelectedItem.Tag.ToString();
        }

        private void btn_about_Click(object sender, RibbonControlEventArgs e)
        {
            AboutBox KA = new AboutBox();
            KA.ShowDialog();
            //KA.Show();
        }

        private void DD_Complier_SelectionChanged(object sender, RibbonControlEventArgs e)
        {
            check_programs();
        }
        private void DD_Grapher_SelectionChanged(object sender, RibbonControlEventArgs e)
        {
            check_programs();
        }
        private void check_programs()
        {
            Compile_Info = DD_Complier.SelectedItem.Tag.ToString() + ";" + DD_Grapher.SelectedItem.Tag.ToString();
            if ((!ExistsOnPath(get_param_value(Compile_Info, "complier") + ".exe")) || (!ExistsOnPath(get_param_value(Compile_Info, "grapher") + ".exe")))
            {
                lb_gen_tip.Label = "Fatal: Programs invalid!";
                btn_insertTex.Enabled = false;
                btn_insChemStruct.Enabled = false;
                btn_insMath.Enabled = false;
                btn_insChemReact.Enabled = false;
                btn_insplot.Enabled = false;
                Program_Check = false;
                btn_edit.Enabled = false;
                return;
            }
            if (get_param_value(Compile_Info, "gaccept").Contains(get_param_value(Compile_Info, "ctarget")))
            {
                lb_gen_tip.Label = "Ready: " + get_param_value(Compile_Info, "ctip") + get_param_value(Compile_Info, "gtip");
                btn_insertTex.Enabled = true;
                btn_insChemStruct.Enabled = true;
                btn_insMath.Enabled = true;
                btn_insChemReact.Enabled = true;
                btn_insplot.Enabled = true;
                Program_Check = true;
            }
            else
            {
                lb_gen_tip.Label = "Fatal: Improper combination!";
                btn_insertTex.Enabled = false;
                btn_insChemStruct.Enabled = false;
                btn_insMath.Enabled = false;
                btn_insChemReact.Enabled = false;
                btn_insplot.Enabled = false;
                Program_Check = false;
                btn_edit.Enabled = false;
            }
        }
        public static bool ExistsOnPath(string fileName)
        {
            return GetFullPath(fileName) != null;
        }

        public static string GetFullPath(string fileName)
        {
            if (File.Exists(fileName))
                return Path.GetFullPath(fileName);

            var values = Environment.GetEnvironmentVariable("PATH");
            foreach (var path in values.Split(Path.PathSeparator))
            {
                var fullPath = Path.Combine(path, fileName);
                if (File.Exists(fullPath))
                    return fullPath;
            }
            return null;
        }

        private void btn_batchEdit_Click(object sender, RibbonControlEventArgs e)
        {
            Microsoft.Office.Interop.Word.Document ThisDoc = Globals.ThisAddIn.Application.ActiveDocument;
            if (ThisDoc == null || ThisDoc.ReadOnly)
                return;
            int IntlStart = ThisDoc.Application.Selection.Start;
            int IntlEnd = ThisDoc.Application.Selection.End;
            ThisDoc.Application.Selection.SetRange(ThisDoc.Application.Selection.Start, ThisDoc.Application.Selection.Start + 1);

            Selection TexObj = ThisDoc.Application.Selection;
            Range TexItem = null;
            bool if_TexObject = false;

            InlineShape TexObjInline = null;
            int TexObjInline_prvstart = 0;
            int TexObjInline_start = 1;

            if (TexObj.InlineShapes.Count != 0)
            {
                TexObjInline = TexObj.InlineShapes[1];
                if_TexObject = (TexObjInline.Type != WdInlineShapeType.wdInlineShapePicture);
                if_TexObject = (if_TexObject && TexObjInline.AlternativeText.Contains("WordxTex_TexContent"));
            }
            else
            {
                TexItem = ThisDoc.Application.Selection.GoToNext(WdGoToItem.wdGoToGraphic);
                ThisDoc.Application.Selection.SetRange(ThisDoc.Application.Selection.Start, ThisDoc.Application.Selection.Start + 1);
                TexObj = ThisDoc.Application.Selection;
            }
            while ((!if_TexObject) && TexObj.InlineShapes.Count != 0 && ((TexObjInline_prvstart != TexObjInline_start)))
            {
                TexObjInline_prvstart = TexObjInline_start;
                TexItem = ThisDoc.Application.Selection.GoToNext(WdGoToItem.wdGoToGraphic);
                ThisDoc.Application.Selection.SetRange(ThisDoc.Application.Selection.Start, ThisDoc.Application.Selection.Start + 1);
                TexObj = ThisDoc.Application.Selection;
                TexObjInline_start = TexObj.Start;
                TexObjInline = TexObj.InlineShapes[1];
                if_TexObject = (TexObjInline.Type != WdInlineShapeType.wdInlineShapePicture);
                if_TexObject = (if_TexObject && TexObjInline.AlternativeText.Contains("WordxTex_TexContent"));
            };
            if (if_TexObject)
            {
                LaTexEdt CodeEditor = new LaTexEdt(true);
                CodeEditor.updateSRC(TexObjInline.AlternativeText);
                CodeEditor.Show();
            }
            else
            {
                ThisDoc.Application.Selection.SetRange(IntlStart, IntlEnd);
            }
        }

        private void btn_insertTex_Click(object sender, RibbonControlEventArgs e)
        {
            LaTexEdt CodeEditor = new LaTexEdt(false);
            CodeEditor.updateSRC("%!WordxTex_TexContent DO NOT DELETE THIS LINE\n");
            CodeEditor.Show();
        }
    }
}
