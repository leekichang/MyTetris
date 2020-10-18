using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.CompilerServices;

namespace MyTetris
{
    class Program
    {
        static void Main(string[] args)
        {
            Map NewMap = new Map();
            while (true)
            {
                NewMap.Stay();
                NewMap.CheckRow();
                NewMap.SpawnBlock();   
                while (NewMap.BlockObject.CanDrop() == true)
                {
                    NewMap.BlockObject.Move();
                    NewMap.SetBlock();
                    Console.Clear();
                    NewMap.DrawMap();
                    Thread.Sleep(500);
                }

            }
        }
    }
}
