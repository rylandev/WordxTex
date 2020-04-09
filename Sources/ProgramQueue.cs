using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordxTex.Sources
{
    class ProgramQueue : System.Object
    {
        int CurProgramNum = 0;
        int MaxProgramNum = 0;
        string[] uePrograms = new string[] { };
        string[] ueProgramsArgs = new string[] { };
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
        public bool Terminated()
        {
            return (MaxProgramNum != CurProgramNum);
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
        public string[] ExecProgramIteration()
        {
            if (CurProgramNum > MaxProgramNum)
                return new string[] { "", "" };
            string[] ExecProgramCurrent = new string[] { uePrograms[CurProgramNum], ueProgramsArgs[CurProgramNum] };
            if (CurProgramNum <= MaxProgramNum)
                CurProgramNum = CurProgramNum + 1;
            return ExecProgramCurrent;
        }
        public string[] ExecProgram(int ProgramQueNum)
        {
            if (ProgramQueNum <= MaxProgramNum)
            {
                string[] ExecProgramCurrent = new string[] { uePrograms[ProgramQueNum], ueProgramsArgs[ProgramQueNum] };
                return ExecProgramCurrent;
            }
            return null;
        }
    }
}
