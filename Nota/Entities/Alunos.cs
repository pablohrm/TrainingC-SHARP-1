using System;
using System.Collections.Generic;
using System.Text;

namespace Nota.Entities
{
    class Alunos
    {
        public string Name { get; set; }
        public int FinallyNote { get; set; }

        public Alunos(string name, int finallyNote)
        {
            Name = name;
            FinallyNote = finallyNote;
        }
    }
}
