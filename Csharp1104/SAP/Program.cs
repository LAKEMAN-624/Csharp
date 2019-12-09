using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
namespace TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] X = new double[2]; double[] XL = new double[2];
            double[] XU = new double[2]; double[] G = new double[2];
            double[] WK = new double[800];
            int[] IWK = new int[200];
            double[] RPRM = new double[20];
            int[] IPRM = new int[20];
            int NRWK = 800; int NRIWK = 200;
            double OBJ = new double();
            OBJ = 0;
            for (int i = 0; i < 20; i++)
            {
                RPRM[i] = 0.0; IPRM[i] = 0;
            }
            int METHOD = 3; int NDV = 2; int NCON = 2;
            for (int i = 0; i < NDV; i++)
            {
                X[i] = 1.0; XL[i] = 0.1; XU[i] = 100.0;
            }
            int IPRINT = 3; int MINMAX = -1; int INFO = 0;
            while (true)
            {
                FortranMethod.DOT(ref INFO, ref METHOD, ref IPRINT, ref NDV, ref NCON, ref X[0], ref XL[0], ref XU[0], ref OBJ, ref MINMAX, ref G[0], ref RPRM[0], ref IPRM[0], ref WK[0], ref NRWK, ref IWK[0], ref NRIWK);
                if (INFO == 0)
                {
                    break;
                }
                FortranMethod.EVAL(ref OBJ, ref X[0], ref G[0]);
            }

        }
    }
    public static class FortranMethod
    {
        [DllImport("DOTBOX.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern double DOT(ref int INFO, ref int METHOD, ref int IPRINT, ref int NDV, ref int NCON, ref double X, ref double XL, ref double XU, ref double OBJ, ref int MINMAX, ref double G, ref double RPRM, ref int IPRM, ref double WK, ref int NRWK, ref int IWK, ref int NRIWK);
        [DllImport("EVAL.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern double EVAL(ref double A, ref double B, ref double C);

    }



}
