using CriatorioAves.Interface;
using CriatorioAves.Modelo;
using CriatorioAves.Repositorio;
using System;
using System.Collections.Generic;

namespace CriatorioAves.Util
{
    public class PreenchimentoPedigree
    {
        public static List<Parents> listaPedigree = new List<Parents>();

        public static Boolean MontarPedigree(Int32 idAve)
        {
            Boolean blnRet = true;
            Parents parents_0 = new Parents(); // raiz
            Parents parents_1 = new Parents(); // avós paternos
            Parents parents_2 = new Parents(); // avós maternos
            Parents parents_3 = new Parents(); // bisavós paternos 1
            Parents parents_4 = new Parents(); // bisavós paternos 2
            Parents parents_5 = new Parents(); // bisavós maternos 1
            Parents parents_6 = new Parents(); // bisavós maternos 2
            IAveRepos aveRep = new AveRepos();

            listaPedigree.Clear();
            // descrição da ave - Nivel 0
            parents_0 = aveRep.ObterCelulaPedigree(idAve);
            parents_0.NivelParents = 0;
            listaPedigree.Add(parents_0);
            // descrição da ave - Nivel 1 - avós paternos
            if (parents_0.IdPai > 0)
            {
                parents_1 = aveRep.ObterCelulaPedigree(parents_0.IdPai);
                parents_1.NivelParents = 1;
            }
            listaPedigree.Add(parents_1);
            // descrição da ave - Nivel 2 - avós maternos
            if (parents_0.IdMae > 0)
            {
                parents_2 = aveRep.ObterCelulaPedigree(parents_0.IdMae);
                parents_2.NivelParents = 2;
            }
            listaPedigree.Add(parents_2);
            // descrição da ave - Nivel 3 - bisavós paternos 1
            if (parents_1.IdPai > 0)
            {
                parents_3 = aveRep.ObterCelulaPedigree(parents_1.IdPai);
                parents_3.NivelParents = 3;
            }
            listaPedigree.Add(parents_3);
            listaPedigree.Add(parents_4);
            listaPedigree.Add(parents_5);
            listaPedigree.Add(parents_6);
            // descrição da ave - Nivel 4 - bisavós paternos 2
            // descrição da ave - Nivel 5 - bisavós maternos 1
            // descrição da ave - Nivel 6 - bisavós maternos 2

            return blnRet;
        }
    }
}
