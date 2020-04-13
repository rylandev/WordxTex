using System;
using System.Diagnostics;
using System.IO;

namespace WordxTex.wTModule
{
    public class ProgramQueue : System.Object
    {
        public event EventHandler ProgramsRunResult;
        public event EventHandler ProgramsRunLogStepRs;
        int CurProgramNum = 0;
        int MaxProgramNum = 0;
        string[] uePrograms = new string[] { };
        string[] ueProgramsArgs = new string[] { };
        bool __runAll = true;
        public ProgramQueue(string[] Programs, string[] ProgramArgs)
        {
            if (Programs.Length == ProgramArgs.Length)
            {
                uePrograms = Programs;
                ueProgramsArgs = ProgramArgs;
                CurProgramNum = 0;
                MaxProgramNum = Programs.Length - 1;
            }
        }
        public int MaxProgramsCount()
        {
            return uePrograms.Length;
        }
        public bool RunAll
        {
            get { return __runAll; }
            set { __runAll = value; }
        }
        public bool Terminated()
        {
            return (MaxProgramNum <= CurProgramNum);
        }
        public int GetProgramNum()
        {
            return CurProgramNum;
        }
        public void SetProgramNum(int ProgramNum)
        {
            if (ProgramNum <= MaxProgramNum)
            {
                CurProgramNum = ProgramNum;
            }
        }
        public void Run()
        {
            if (RunAll)
                CurProgramNum = 0;
            object[] prResult = new object[uePrograms.Length];
            for (int i = 0; i < uePrograms.Length; i++)
            {
                prResult[i] = exeProcessWithRslt();
                ExecProgramIteration();
            }
            ProgramsRunResult(prResult, new EventArgs());

        }
        public string[] ExecProgramIteration()
        {
            if (CurProgramNum > MaxProgramNum)
                return new string[] { "", "" };
            string[] ExecProgramCurrent = new string[] { uePrograms[CurProgramNum], ueProgramsArgs[CurProgramNum] };
            if (CurProgramNum <= MaxProgramNum)
                CurProgramNum = CurProgramNum + 1;
            return ExecProgramCurrent;
        }
        public string[] setExecProgram(int ProgramQueNum)
        {
            if (ProgramQueNum <= MaxProgramNum)
            {
                string[] ExecProgramCurrent = new string[] { uePrograms[ProgramQueNum], ueProgramsArgs[ProgramQueNum] };
                return ExecProgramCurrent;
            }
            return null;
        }
        private ProgramResult exeProcessWithRslt()
        {
            string uelogs = "";
            string execPath = uePrograms[CurProgramNum];
            string args = ueProgramsArgs[CurProgramNum];
            using (Process Rprocess = new Process())
            {
                Rprocess.StartInfo.UseShellExecute = false; //不使用CMD
                Rprocess.StartInfo.CreateNoWindow = true; //不显示黑色窗口
                Rprocess.OutputDataReceived += delegate (object sender, DataReceivedEventArgs e)
                {
                    string logs = "";
                    try
                    {
                        logs = e.Data;
                    }
                    catch (System.Exception)
                    {
                    }
                    uelogs = uelogs + "\n" + logs;
                    ProgramsRunLogStepRs(logs, new EventArgs());
                };
                Rprocess.StartInfo.RedirectStandardOutput = true;
                Rprocess.ErrorDataReceived += delegate (object sender, DataReceivedEventArgs e)
                {
                    string logs = "";
                    try
                    {
                        logs = e.Data;
                    }
                    catch (System.Exception)
                    {
                    }
                    uelogs = uelogs + "\n" + logs;
                    ProgramsRunLogStepRs(logs, new EventArgs());
                };
                Rprocess.StartInfo.RedirectStandardError = true;
                Rprocess.StartInfo.FileName = execPath;
                Rprocess.StartInfo.Arguments = args;
                Rprocess.EnableRaisingEvents = true;
                if (!Rprocess.Start())
                {
                    return new ProgramResult(execPath, args, -1, Terminated(), MaxProgramNum - CurProgramNum);
                }
                Rprocess.BeginOutputReadLine();
                Rprocess.BeginErrorReadLine();
                Rprocess.WaitForExit();
                ProgramResult pResult = new ProgramResult(execPath, args, Rprocess.ExitCode, Terminated(), MaxProgramNum - CurProgramNum);
                pResult.execLogs = uelogs;
                return pResult;
            }
        }
        public void execProcess()
        {
            string uelogs = "";
            string execPath = uePrograms[CurProgramNum];
            string args = ueProgramsArgs[CurProgramNum];
            using (Process Rprocess = new Process())
            {
                Rprocess.StartInfo.UseShellExecute = false; //不使用CMD
                Rprocess.StartInfo.CreateNoWindow = true; //不显示黑色窗口
                Rprocess.OutputDataReceived += delegate (object sender, DataReceivedEventArgs e)
                {
                    string logs = "";
                    try
                    {
                        logs = e.Data;
                    }
                    catch (System.Exception)
                    {
                    }
                    uelogs = uelogs + "\n" + logs;
                };
                Rprocess.StartInfo.RedirectStandardOutput = true;
                Rprocess.ErrorDataReceived += delegate (object sender, DataReceivedEventArgs e)
                {
                    string logs = "";
                    try
                    {
                        logs = e.Data;
                    }
                    catch (System.Exception)
                    {
                    }
                    uelogs = uelogs + "\n" + logs;
                };
                Rprocess.StartInfo.RedirectStandardError = true;
                Rprocess.StartInfo.FileName = execPath;
                Rprocess.StartInfo.Arguments = args;
                Rprocess.EnableRaisingEvents = true;
                if (!Rprocess.Start())
                {
                    return;
                }
                Rprocess.BeginOutputReadLine();
                Rprocess.BeginErrorReadLine();
                Rprocess.WaitForExit();
                ProgramResult pResult = new ProgramResult(execPath, args, Rprocess.ExitCode, Terminated(), MaxProgramNum - CurProgramNum);
                pResult.execLogs = uelogs;
                ProgramsRunResult(pResult, new EventArgs());
            }
        }
    }

    public class ProgramResult : System.Object
    {
        string __execName = null;
        string __execArgs = null;
        string __logs = null;
        int __exitCode = -1;
        int __programLeft = 0;
        bool __theLastProgram = true;

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

        public ProgramResult(string execName, string execArgs, int exitCode, bool theLastProgram, int programLeft)
        {
            __execName = GetFullPath(execName);
            __execArgs = execArgs;
            __exitCode = exitCode;
            __theLastProgram = theLastProgram;
            __programLeft = programLeft;

        }
        public string execName
        {
            get { return __execName; }
        }
        public string execArgs
        {
            get { return __execArgs; }
        }
        public string execLogs
        {
            get { return __logs; }
            set { __logs = value; }

        }
        public int exitCode
        {
            get { return __exitCode; }
        }
        public int programLeft
        {
            get { return __programLeft; }
        }
        public bool theLastProgram
        {
            get { return __theLastProgram; }
        }

    }

}
