using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_task_1
{
    internal class Task3
    {
        public static void Execute()
        {
            Console.WriteLine();
            Console.WriteLine("Цiпковський_Вадим_Задача_3");
            Console.WriteLine();
            int[,,] array3D = new int[,,] {
            {  {1,1,1},
               {1,0,1},
               {1,1,1}
            },

            {   {1,1,1},
                {1,0,1},
                {1,1,1}
            },
             {  {1,1,1},
                {1,0,1},
                {1,1,1}
            }
        };

            Cube cube = new Cube(array3D);
            cube.Execute();
        }


        }
}
