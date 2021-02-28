using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Risk
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool[,] AdjacencyMatrix = new bool[43,43];
            AdjacencyMatrix[1,2] = true;
            AdjacencyMatrix[1,3] = true;
            AdjacencyMatrix[1,25] = true;
            AdjacencyMatrix[1,41] = true;
            AdjacencyMatrix[2,1] = true;
            AdjacencyMatrix[2,3] = true;
            AdjacencyMatrix[2,41] = true;
            AdjacencyMatrix[2,22] = true;
            AdjacencyMatrix[3,1] = true;
            AdjacencyMatrix[3,2] = true;
            AdjacencyMatrix[3,4] = true;
            AdjacencyMatrix[4,3] = true;
            AdjacencyMatrix[4,5] = true;
            AdjacencyMatrix[4,10] = true;
            AdjacencyMatrix[4,11] = true;
            AdjacencyMatrix[4,12] = true;
            AdjacencyMatrix[5,4] = true;
            AdjacencyMatrix[5,6] = true;
            AdjacencyMatrix[5,11] = true;
            AdjacencyMatrix[6,5] = true;
            AdjacencyMatrix[6,7] = true;
            AdjacencyMatrix[6,9] = true;
            AdjacencyMatrix[6,10] = true;
            AdjacencyMatrix[6,11] = true;
            AdjacencyMatrix[7,6] = true;
            AdjacencyMatrix[7,8] = true;
            AdjacencyMatrix[7,9] = true;
            AdjacencyMatrix[7,42] = true;
            AdjacencyMatrix[8,7] = true;
            AdjacencyMatrix[8,9] = true;
            AdjacencyMatrix[8,14] = true;
            AdjacencyMatrix[8,15] = true;
            AdjacencyMatrix[8,42] = true;
            AdjacencyMatrix[9,6] = true;
            AdjacencyMatrix[9,7] = true;
            AdjacencyMatrix[9,8] = true;
            AdjacencyMatrix[9,10] = true;
            AdjacencyMatrix[9,13] = true;
            AdjacencyMatrix[9,14] = true;
            AdjacencyMatrix[10,4] = true;
            AdjacencyMatrix[10,6] = true;
            AdjacencyMatrix[10,9] = true;
            AdjacencyMatrix[10,11] = true;
            AdjacencyMatrix[10,12] = true;
            AdjacencyMatrix[11,4] = true;
            AdjacencyMatrix[11,5] = true;
            AdjacencyMatrix[11,6] = true;
            AdjacencyMatrix[11,10] = true;
            AdjacencyMatrix[12,4] = true;
            AdjacencyMatrix[12,10] = true;
            AdjacencyMatrix[13,9] = true;
            AdjacencyMatrix[13,14] = true;
            AdjacencyMatrix[13,37] = true;
            AdjacencyMatrix[14,8] = true;
            AdjacencyMatrix[14,9] = true;
            AdjacencyMatrix[14,13] = true;
            AdjacencyMatrix[14,15] = true;
            AdjacencyMatrix[15,8] = true;
            AdjacencyMatrix[15,14] = true;
            AdjacencyMatrix[15,16] = true;
            AdjacencyMatrix[15,32] = true;
            AdjacencyMatrix[15,36] = true;
            AdjacencyMatrix[15,42] = true;
            AdjacencyMatrix[16,15] = true;
            AdjacencyMatrix[16,17] = true;
            AdjacencyMatrix[16,18] = true;
            AdjacencyMatrix[16,31] = true;
            AdjacencyMatrix[16,32] = true;
            AdjacencyMatrix[16,42] = true;
            AdjacencyMatrix[17,16] = true;
            AdjacencyMatrix[17,18] = true;
            AdjacencyMatrix[17,19] = true;
            AdjacencyMatrix[17,21] = true;
            AdjacencyMatrix[17,42] = true;
            AdjacencyMatrix[18,16] = true;
            AdjacencyMatrix[18,17] = true;
            AdjacencyMatrix[18,19] = true;
            AdjacencyMatrix[18,31] = true;
            AdjacencyMatrix[19,17] = true;
            AdjacencyMatrix[19,18] = true;
            AdjacencyMatrix[19,20] = true;
            AdjacencyMatrix[19,21] = true;
            AdjacencyMatrix[20,19] = true;
            AdjacencyMatrix[20,21] = true;
            AdjacencyMatrix[20,22] = true;
            AdjacencyMatrix[21,17] = true;
            AdjacencyMatrix[21,19] = true;
            AdjacencyMatrix[21,20] = true;
            AdjacencyMatrix[21,42] = true;
            AdjacencyMatrix[22,2] = true;
            AdjacencyMatrix[22,20] = true;
            AdjacencyMatrix[22,23] = true;
            AdjacencyMatrix[22,41] = true;
            AdjacencyMatrix[23,22] = true;
            AdjacencyMatrix[23,24] = true;
            AdjacencyMatrix[23,41] = true;
            AdjacencyMatrix[24,23] = true;
            AdjacencyMatrix[24,25] = true;
            AdjacencyMatrix[24,26] = true;
            AdjacencyMatrix[24,41] = true;
            AdjacencyMatrix[25,1] = true;
            AdjacencyMatrix[25,24] = true;
            AdjacencyMatrix[25,26] = true;
            AdjacencyMatrix[25,41] = true;
            AdjacencyMatrix[26,24] = true;
            AdjacencyMatrix[26,25] = true;
            AdjacencyMatrix[26,27] = true;
            AdjacencyMatrix[27,26] = true;
            AdjacencyMatrix[27,28] = true;
            AdjacencyMatrix[27,30] = true;
            AdjacencyMatrix[28,27] = true;
            AdjacencyMatrix[28,29] = true;
            AdjacencyMatrix[28,30] = true;
            AdjacencyMatrix[29,28] = true;
            AdjacencyMatrix[29,30] = true;
            AdjacencyMatrix[30,27] = true;
            AdjacencyMatrix[30,28] = true;
            AdjacencyMatrix[30,29] = true;
            AdjacencyMatrix[30,31] = true;
            AdjacencyMatrix[31,16] = true;
            AdjacencyMatrix[31,18] = true;
            AdjacencyMatrix[31,30] = true;
            AdjacencyMatrix[31,32] = true;
            AdjacencyMatrix[31,33] = true;
            AdjacencyMatrix[31,36] = true;
            AdjacencyMatrix[32,15] = true;
            AdjacencyMatrix[32,16] = true;
            AdjacencyMatrix[32,31] = true;
            AdjacencyMatrix[32,36] = true;
            AdjacencyMatrix[33,31] = true;
            AdjacencyMatrix[33,34] = true;
            AdjacencyMatrix[33,36] = true;
            AdjacencyMatrix[34,33] = true;
            AdjacencyMatrix[34,35] = true;
            AdjacencyMatrix[34,36] = true;
            AdjacencyMatrix[35,34] = true;
            AdjacencyMatrix[35,36] = true;
            AdjacencyMatrix[36,15] = true;
            AdjacencyMatrix[36,31] = true;
            AdjacencyMatrix[36,32] = true;
            AdjacencyMatrix[36,33] = true;
            AdjacencyMatrix[36,34] = true;
            AdjacencyMatrix[36,35] = true;
            AdjacencyMatrix[37,13] = true;
            AdjacencyMatrix[37,38] = true;
            AdjacencyMatrix[38,37] = true;
            AdjacencyMatrix[38,39] = true;
            AdjacencyMatrix[38,40] = true;
            AdjacencyMatrix[39,38] = true;
            AdjacencyMatrix[39,40] = true;
            AdjacencyMatrix[40,38] = true;
            AdjacencyMatrix[40,39] = true;
            AdjacencyMatrix[41,1] = true;
            AdjacencyMatrix[41,2] = true;
            AdjacencyMatrix[41,22] = true;
            AdjacencyMatrix[41,23] = true;
            AdjacencyMatrix[41,24] = true;
            AdjacencyMatrix[41,25] = true;
            AdjacencyMatrix[42,7] = true;
            AdjacencyMatrix[42,8] = true;
            AdjacencyMatrix[42,15] = true;
            AdjacencyMatrix[42,16] = true;
            AdjacencyMatrix[42,17] = true;
            AdjacencyMatrix[42,21] = true;
            for (int i = 1; i < 43; i++)
            {
                for (int j = 1; j < 43; j++)
                {
                    if (AdjacencyMatrix[i,j] != true)
                    {
                        AdjacencyMatrix[i,j] = false;
                    }                                                                         
                }                                                                             
            }                                                                                 
        ///for (int i = 1; i < 43; i++) //displays what adjacency matrix looks like            
        ///{                                                                                   
        ///    for (int j = 1; j < 43; j++)                                                    
        ///    {                                                                               
        ///        if (AdjacencyMatrix[i, j] == false)                                         
        ///        {                                                                           
        ///            Console.Write("  ");                                                    
        ///        }                                                                           
        ///        else                                                                        
        ///        {                                                                           
        ///            Console.Write("b ");                                                    
        ///        }                                                                           
        ///    }                                                                               
        ///    Console.WriteLine("");                                                          
        ///}
        
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Risk_Home(ref AdjacencyMatrix));
        }
        
    }
}
