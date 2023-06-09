using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap07_Ex02
{
    class SalaAula
    {
        public string SALA;
    }

    class CadAluno : SalaAula
    {

        public string NOME;
        public float N1, N2;
        private float MEDIA;

        public float CalcMedia(float NT1, float NT2)
        {
            MEDIA = (NT1 + NT2) / 2;
            return MEDIA;
        }

        public static bool CondAluno(float ALUMEDIA, double CORMEDIA)
        {
            bool CONDALUNO = true;
            if (ALUMEDIA < CORMEDIA)
                CONDALUNO = false;
            return CONDALUNO;
        }

    }
}
