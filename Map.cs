using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyTetris
{
    class Map
    {
        public int XSize, YSize;
        public int[,] Table;
        public Block BlockObject;
        public Map()
        {
            XSize = 12+4;
            YSize = 22+2;
            Table = new int[YSize, XSize];
            BlockObject = new Block(this);
            for (int y = 0; y < YSize-2; y++)
            {
                for (int x = 0+2; x < XSize-2; x++)
                {
                    if (x == 0+2 || x == XSize - 1 -2 || y == 0 || y == YSize - 3)
                    {
                        Table[y,x] = 2;
                    }
                    else
                    {
                        Table[y, x] = 0;
                    }
                }
            }
        }
        public void SpawnBlock()
        {
            Random rand = new Random();
            BlockObject = new Block(this);
            switch (rand)
            {
                case 1:
                    BlockObject.Type1();
                    break;
                case 2:
                    BlockObject.Type2();
                    break;
                case 3:
                    BlockObject.Type3();
                    break;
                case 4:
                    BlockObject.Type4();
                    break;
                case 5:
                    BlockObject.Type5();
                    break;
                case 6:
                    BlockObject.Type6();
                    break;
                case 7:
                    BlockObject.Type7();
                    break;
                default:
                    break;
            }
        }

        public void SetBlock()
        {
            for(int y = 0; y < 4; y++)
            {
                for(int x = 0; x < 4; x++)
                {
                    if (Table[BlockObject.Y + y, BlockObject.X + x] != 1 && Table[BlockObject.Y + y, BlockObject.X + x] != 2 && BlockObject.Shape[BlockObject.RotateCount, y, x] == 1)
                    {
                        Table[BlockObject.Y + y, BlockObject.X + x] = BlockObject.Shape[BlockObject.RotateCount, y, x];
                    }
                }
            }
        }

        public void DrawMap()
        {
            for(int y = 0; y < YSize; y++)
            {
                for(int x = 0; x < XSize; x++)
                {
                    if (Table[y,x] == 2)
                    {
                        Console.Write("▦");
                    }
                    else if(Table[y,x] == 0)
                    {
                        Console.Write("  ");
                    }
                    else if (Table[y, x] == 1 || Table[y, x] == 3)
                    {
                        Console.Write("■");
                    }
                }
                Console.WriteLine();
            }
        }

        public void CopyAbove(int y)
        {
            for (int i = y; y > 1; y--)
            {
                for (int j = 3; j < XSize - 3; j++)
                {
                    Table[i, j] = Table[i - 1, j];
                }
            }
        }

        public void Stay()
        {
            for (int y = 0; y < 4; y++)
            {
                for (int x = 0; x < 4; x++)
                {
                    if (BlockObject.Shape[BlockObject.RotateCount, y, x] == 1)
                    {
                        Table[BlockObject.Y + y, BlockObject.X + x] = 3;
                    }

                }
            }
        }

        public void CheckRow()
        {
            int y = YSize - 4;
            while (y > 1)
            {
                for (int x = 3; x < XSize - 3; x++)
                {
                    if (Table[y, x] != 3)
                    {
                        y -= 1;
                        break;
                    }
                    if (x == XSize - 4)
                    {
                        for(int i = y; i > 1; i--)
                        {
                            CopyAbove(i);
                        }
                    }
                }
            }
        }
    }
}
