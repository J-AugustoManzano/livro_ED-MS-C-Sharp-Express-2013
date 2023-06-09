using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cap07_Ex01
{
    class SalaAula
    {
        public string SALA;
    }

    class CadAluno : SalaAula
    {

        public string NOME;
        public float[] NOTA = new float[4];

        public float CalcMedia()
        {
            byte I;
            float SOMA, MEDIA;
            SOMA = 0;
            for (I = 0; I <= 3; I++)
                SOMA = SOMA + NOTA[I];
            MEDIA = SOMA / 4;
            return MEDIA;
        }

    }
}
