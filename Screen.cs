using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MyTetris
{
    class Board
    {
        public int XSize, YSize;
        public Block[,] BlockList;
        
        public Board()
        {
            this.XSize = 10;
            this.YSize = 15;
            this.BlockList = new Block[YSize, XSize];
        }
        public void Frame()
        {
            for (int y = 0; y < YSize; y++)
            {
                for (int x = 0; x < XSize; x++)
                {
                    if (y == 0 || y == YSize - 1 || x == 0 || x == XSize-1)
                    {
                        BlockList[y, x].Type = "▦";
                    }
                    else
                    {
                        BlockList[y, x].Type = " ";
                    }
                }
            }
        }
        public void Render()
        {
            for(int y = 0; y<YSize; y++)
            {
                for(int x = 0; x<XSize; x++)
                {
                    Console.Write(BlockList[y, x].Type);
                }
                Console.WriteLine();
            }
        }
    }
}
