using Microsoft.Office.Interop.Word;
using Microsoft.Office.Tools.Ribbon;
using System;
using System.IO;
using WordxTex.Properties;

namespace WordxTex
{
    public partial class Ribbon
    {
        public bool programCheck;
        public static SettingsForm settingsBox = new SettingsForm();

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
            LaTexEdt CodeEditor = new LaTexEdt(false, SelectedObjFirst.AlternativeText, 0, 0);
            CodeEditor.ShowDialog();
        }

        private void btn_insChemStruct_Click(object sender, RibbonControlEventArgs e)
        {
            Microsoft.Office.Interop.Word.Document ThisDoc = Globals.ThisAddIn.Application.ActiveDocument;
            if (ThisDoc == null || ThisDoc.ReadOnly)
                return;
            LaTexEdt CodeEditor = new LaTexEdt(false, Resources.tex_sample_chemstr, 289, 321);
            CodeEditor.Show();
        }

        private void btn_insChemReact_Click(object sender, RibbonControlEventArgs e)
        {
            Microsoft.Office.Interop.Word.Document ThisDoc = Globals.ThisAddIn.Application.ActiveDocument;
            if (ThisDoc == null || ThisDoc.ReadOnly)
                return;
            LaTexEdt CodeEditor = new LaTexEdt(false, Resources.tex_sample_chemrea, 217, 252);
            CodeEditor.Show();
        }

        private void btn_insMath_Click(object sender, RibbonControlEventArgs e)
        {
            Microsoft.Office.Interop.Word.Document ThisDoc = Globals.ThisAddIn.Application.ActiveDocument;
            if (ThisDoc == null || ThisDoc.ReadOnly)
                return;
            LaTexEdt CodeEditor = new LaTexEdt(false, Resources.tex_sample_matheq, 163, 218);
            CodeEditor.Show();
        }

        public static string get_param_value(string param, string name)
        {
            char spep = ';';
            string[] CompileI = param.Split(spep);
            string[] K;
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
            SettingsBox_Intl(false);
            //settingsBox.generChangeEventHandler += delegate (Object prg_params, EventArgs Evr)
            //{
            //    check_programs();
            //};

            Globals.ThisAddIn.Application.WindowSelectionChange += delegate (Selection Sel)
            {
                if (programCheck == false)
                {
                    btn_edit.Enabled = false;
                    return;
                }
                if (Globals.ThisAddIn.Application.Selection.Type == WdSelectionType.wdSelectionIP)
                {
                    btn_edit.Enabled = false;
                    return;
                }
                editContentCheck(Sel);
            };
        }

        private void SettingsBox_Intl(bool form_terminated)
        {
            //读取配置
            if (form_terminated) settingsBox = new SettingsForm();
            settingsBox.FormClosed += ((formObj, ea) => SettingsBox_Intl(true)); //防止设置窗口中止
            settingsBox.generChangeEventHandler += ((prg_params, Evr) => check_programs()); //即TeX程序配置
            //显示标签与否
            btn_insMath.ShowLabel = settingsBox.showLabel;
            btn_insChemReact.ShowLabel = settingsBox.showLabel;
            btn_insChemStruct.ShowLabel = settingsBox.showLabel;
            btn_ins_symbol.ShowLabel = settingsBox.showLabel;
            btn_insplot.ShowLabel = settingsBox.showLabel;
            btn_baselineU.ShowLabel = settingsBox.showLabel;
            btn_baselineDn.ShowLabel = settingsBox.showLabel;
            btn_baselineRt.ShowLabel = settingsBox.showLabel;
            settingsBox.showLabelOptionChangeEventHandler += delegate (Object checkStatus, EventArgs Evr)
            {
                btn_insMath.ShowLabel = (bool)checkStatus;
                btn_insChemReact.ShowLabel = (bool)checkStatus;
                btn_insChemStruct.ShowLabel = (bool)checkStatus;
                btn_ins_symbol.ShowLabel = (bool)checkStatus;
                btn_insplot.ShowLabel = (bool)checkStatus;
                btn_baselineU.ShowLabel = (bool)checkStatus;
                btn_baselineDn.ShowLabel = (bool)checkStatus;
                btn_baselineRt.ShowLabel = (bool)checkStatus;
            };

            check_programs();//检查Tex配置
        }

        private void editContentCheck(Selection Sel)
        {
            try
            {
                if (Sel.InlineShapes[1].AlternativeText.Contains("WordxTex_TexContent")) btn_edit.Enabled = true;
            }
            catch (System.Exception)
            {
                btn_edit.Enabled = false;
                return;
            }
        }
        private void btn_settings_Click(object sender, RibbonControlEventArgs e) => settingsBox.Show();

        private void btn_insplot_Click(object sender, RibbonControlEventArgs e)
        {
            Microsoft.Office.Interop.Word.Document ThisDoc = Globals.ThisAddIn.Application.ActiveDocument;
            if (ThisDoc == null || ThisDoc.ReadOnly)
                return;
            LaTexEdt CodeEditor = new LaTexEdt(false, Resources.tex_sample_plot, 0, 0);
            //CodeEditor.updateSRC(Resources.tex_sample_plot);
            CodeEditor.ShowDialog();
        }

        private void btn_about_Click(object sender, RibbonControlEventArgs e) => new AboutBox().ShowDialog();

        private void check_programs()
        {
            if (
                (!ExistsOnPath(get_param_value(settingsBox.program_exec_params, "complier") + ".exe")) ||
                (!ExistsOnPath(get_param_value(settingsBox.program_exec_params, "grapher") + ".exe"))
                )
            {
                lb_gen_tip.Label = "Fatal: Programs invalid!";
                btn_insertTex.Enabled = false;
                btn_insChemStruct.Enabled = false;
                btn_insMath.Enabled = false;
                btn_insChemReact.Enabled = false;
                btn_insplot.Enabled = false;
                btn_ins_symbol.Enabled = false;
                programCheck = false;
                btn_edit.Enabled = false;
                return;
            }
            if (get_param_value(settingsBox.program_exec_params, "gaccept").Contains(get_param_value(settingsBox.program_exec_params, "ctarget")))
            {
                lb_gen_tip.Label = "Ready: " + get_param_value(settingsBox.program_exec_params, "ctip") + get_param_value(settingsBox.program_exec_params, "gtip");
                btn_insertTex.Enabled = true;
                btn_insChemStruct.Enabled = true;
                btn_insMath.Enabled = true;
                btn_insChemReact.Enabled = true;
                btn_insplot.Enabled = true;
                btn_ins_symbol.Enabled = true;
                programCheck = true;
            }
            else
            {
                lb_gen_tip.Label = "Fatal: Improper combination!";
                btn_insertTex.Enabled = false;
                btn_insChemStruct.Enabled = false;
                btn_insMath.Enabled = false;
                btn_insChemReact.Enabled = false;
                btn_insplot.Enabled = false;
                btn_ins_symbol.Enabled = false;
                programCheck = false;
                btn_edit.Enabled = false;
            }
        }
        public static bool ExistsOnPath(string fileName) => GetFullPath(fileName) != null;

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
                LaTexEdt CodeEditor = new LaTexEdt(true, TexObjInline.AlternativeText, 0, 0);
                //CodeEditor.updateSRC(TexObjInline.AlternativeText);
                CodeEditor.Show();
            }
            else
            {
                ThisDoc.Application.Selection.SetRange(IntlStart, IntlEnd);
            }
        }

        private void btn_insertTex_Click(object sender, RibbonControlEventArgs e)
        {
            LaTexEdt CodeEditor = new LaTexEdt(false, "%!WordxTex_TexContent DO NOT DELETE THIS LINE\n", 46, 46);
            CodeEditor.Show();
        }

        private void btn_ins_symbol_Click(object sender, RibbonControlEventArgs e)
        {
            Microsoft.Office.Interop.Word.Document ThisDoc = Globals.ThisAddIn.Application.ActiveDocument; ;
            if (ThisDoc == null || ThisDoc.ReadOnly)
                return;
            LaTexEdt CodeEditor = new LaTexEdt(false, Resources.tex_sample_awesymbol, 183, 248);
            //CodeEditor.updateSRC(Resources.tex_sample_matheq);
            CodeEditor.Show();
        }
    }
}
