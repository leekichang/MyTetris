using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.CompilerServices;

namespace MyTetris
{
    class Block
    {
        public int X, Y, RotateCount; //X좌표, Y좌표
        public int[,,] Shape;
        Map _Map = null;
        public Block(Map map)
        {
            _Map = map;
            X = _Map.XSize / 2 - 3;
            Y = 1;
            RotateCount = 0;
            Shape = new int[4, 4, 4];
        }
        public void Type1() //|
        {
            Shape = new int[4, 4, 4]{
                {
                    { 1, 0, 0, 0},
                    { 1, 0, 0, 0},
                    { 1, 0, 0, 0},
                    { 1, 0, 0, 0}},
                {
                    { 1, 1, 1, 1},
                    { 0, 0, 0, 0},
                    { 0, 0, 0, 0},
                    { 0, 0, 0, 0}},
                {
                    { 1, 0, 0, 0},
                    { 1, 0, 0, 0},
                    { 1, 0, 0, 0},
                    { 1, 0, 0, 0}},
                {
                    { 1, 1, 1, 1},
                    { 0, 0, 0, 0},
                    { 0, 0, 0, 0},
                    { 0, 0, 0, 0}}
            };
        }
        public void Type2()// ㅗ
        {
            Shape = new int[4, 4, 4]{
                {
                    { 1, 1, 1, 0},
                    { 0, 1, 0, 0},
                    { 0, 0, 0, 0},
                    { 0, 0, 0, 0}
                },
                {
                    { 0, 1, 0, 0},
                    { 1, 1, 0, 0},
                    { 0, 1, 0, 0},
                    { 0, 0, 0, 0}
                },
                {
                    { 0, 1, 0, 0},
                    { 1, 1, 1, 0},
                    { 0, 0, 0, 0},
                    { 0, 0, 0, 0}
                },
                {
                    { 1, 0, 0, 0},
                    { 1, 1, 0, 0},
                    { 1, 0, 0, 0},
                    { 0, 0, 0, 0}
                }
            };
        }
        public void Type3()// S
        {
            Shape = new int[4, 4, 4]{
                {
                    { 0, 1, 1, 0},
                    { 1, 1, 0, 0},
                    { 0, 0, 0, 0},
                    { 0, 0, 0, 0}
                },
                {
                    { 1, 0, 0, 0},
                    { 1, 1, 0, 0},
                    { 0, 1, 0, 0},
                    { 0, 0, 0, 0}
                },
                {
                    { 0, 1, 1, 0},
                    { 1, 1, 0, 0},
                    { 0, 0, 0, 0},
                    { 0, 0, 0, 0}
                },
                {
                    { 1, 0, 0, 0},
                    { 1, 1, 0, 0},
                    { 0, 1, 0, 0},
                    { 0, 0, 0, 0}
                }
            };
        }
        public void Type4()// Z
        {
            Shape = new int[4, 4, 4]{
                {
                    { 1, 1, 0, 0},
                    { 0, 1, 1, 0},
                    { 0, 0, 0, 0},
                    { 0, 0, 0, 0}
                },
                {
                    { 0, 1, 0, 0},
                    { 1, 1, 0, 0},
                    { 1, 0, 0, 0},
                    { 0, 0, 0, 0}
                },
                {
                    { 1, 1, 0, 0},
                    { 0, 1, 1, 0},
                    { 0, 0, 0, 0},
                    { 0, 0, 0, 0}
                },
                {
                    { 0, 1, 0, 0},
                    { 1, 1, 0, 0},
                    { 1, 0, 0, 0},
                    { 0, 0, 0, 0}
                }
            };
        }
        public void Type5()// J
        {
            Shape = new int[4, 4, 4]{
                {
                    { 0, 1, 0, 0},
                    { 0, 1, 0, 0},
                    { 1, 1, 0, 0},
                    { 0, 0, 0, 0}
                },
                {
                    { 1, 0, 0, 0},
                    { 1, 1, 1, 0},
                    { 0, 0, 0, 0},
                    { 0, 0, 0, 0}
                },
                {
                    { 1, 1, 0, 0},
                    { 1, 0, 0, 0},
                    { 1, 0, 0, 0},
                    { 0, 0, 0, 0}
                },
                {
                    { 1, 1, 1, 0},
                    { 0, 0, 1, 0},
                    { 0, 0, 0, 0},
                    { 0, 0, 0, 0}
                }
            };
        }
        public void Type6()// L
        {
            Shape = new int[4, 4, 4]{
                {
                    { 1, 0, 0, 0},
                    { 1, 0, 0, 0},
                    { 1, 1, 0, 0},
                    { 0, 0, 0, 0}
                },
                {
                    { 1, 1, 1, 0},
                    { 1, 0, 0, 0},
                    { 0, 0, 0, 0},
                    { 0, 0, 0, 0}
                },
                {
                    { 1, 1, 0, 0},
                    { 0, 1, 0, 0},
                    { 0, 1, 0, 0},
                    { 0, 0, 0, 0}
                },
                {
                    { 0, 0, 1, 0},
                    { 1, 1, 1, 0},
                    { 0, 0, 0, 0},
                    { 0, 0, 0, 0}
                }
            };
        }
        public void Type7()// ㅁ
        {
            Shape = new int[4, 4, 4]{
                {
                    { 1, 1, 0, 0},
                    { 1, 1, 0, 0},
                    { 0, 0, 0, 0},
                    { 0, 0, 0, 0}
                },
                {
                    { 1, 1, 0, 0},
                    { 1, 1, 0, 0},
                    { 0, 0, 0, 0},
                    { 0, 0, 0, 0}
                },
                {
                    { 1, 1, 0, 0},
                    { 1, 1, 0, 0},
                    { 0, 0, 0, 0},
                    { 0, 0, 0, 0}
                },
                {
                    { 1, 1, 0, 0},
                    { 1, 1, 0, 0},
                    { 0, 0, 0, 0},
                    { 0, 0, 0, 0}
                }
            };
        }
       
        public int GetRight(int y)
        {
            int Right = 0;
            for(int x = 0; x < 4; x++)
            {
                if(Shape[RotateCount, y, x] == 1 && x > Right)
                {
                    Right = x;
                }
            }
            return Right;
        }
        public int GetLeft(int y)
        {
            int Left = 4;
            for (int x = 0; x < 4; x++)
            {
                if (Shape[RotateCount, y, x] == 1 && x < Left)
                {
                    Left = x;
                }
            }
            return Left;
        }
        public int GetDown(int x)
        {
            int Down = -1;
            for (int y = 0; y < 4; y++)
            {
                if (Shape[RotateCount, y, x] == 1 && y > Down)
                {
                    Down = y;
                }
            }
            return Down;
        }
        public bool IsColEmpty(int x)
        {
            for(int y = 0; y < 4; y++)
            {
                if(Shape[RotateCount, y, x] == 1)
                {
                    return true;
                }
            }
            return false;
        }
        public bool IsRowEmpty(int y)
        {
            {
                for (int x = 0; x < 4; x++)
                {
                    if (Shape[RotateCount, y, x] == 1)
                    {
                        return true;
                    }
                }
                return false;
            }
        }
        public void Rotate()
        {
            RotateCount = (RotateCount + 1)%4;
        }
        public bool CanRotate()
        {
            for (int y = 0; y < 4; y++)
            {
                for (int x = 0; x < 4; x++) { 
                    if(Shape[(RotateCount+1)%4, y, x] == 1 && (_Map.Table[Y+y, X+x] == 2 || _Map.Table[Y + y, X + x] == 3))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public bool CanDrop()
        {
            if ((_Map.Table[Y + GetDown(0) + 1, X + 0] != 0 && IsColEmpty(0) == true) ||
                (_Map.Table[Y + GetDown(1) + 1, X + 1] != 0 && IsColEmpty(1) == true) ||
                (_Map.Table[Y + GetDown(2) + 1, X + 2] != 0 && IsColEmpty(2) == true) ||
                (_Map.Table[Y + GetDown(3) + 1, X + 3] != 0 && IsColEmpty(3) == true))
            {
                return false;
            }
            return true;
        }
        public bool CanMoveLeft()
        {
            if ((_Map.Table[Y + 0, X + GetLeft(0) - 1] != 0 && IsRowEmpty(0) == true) ||
                (_Map.Table[Y + 1, X + GetLeft(1) - 1] != 0 && IsRowEmpty(1) == true) ||
                (_Map.Table[Y + 2, X + GetLeft(2) - 1] != 0 && IsRowEmpty(2) == true) ||
                (_Map.Table[Y + 3, X + GetLeft(3) - 1] != 0 && IsRowEmpty(3) == true))
            {
                return false;
            }
            return true;
        }
        public bool CanMoveRight()
        {
            if ((_Map.Table[Y + 0, X + GetRight(0) + 1] != 0 && IsRowEmpty(0) == true) ||
                (_Map.Table[Y + 1, X + GetRight(1) + 1] != 0 && IsRowEmpty(1) == true) ||
                (_Map.Table[Y + 2, X + GetRight(2) + 1] != 0 && IsRowEmpty(2) == true) ||
                (_Map.Table[Y + 3, X + GetRight(3) + 1] != 0 && IsRowEmpty(3) == true))
            {
                return false;
            }
            return true;
        }
        public void Drop()
        {
            if(CanDrop() == true)
            {
                BlockClear();
                Y += 1;
            }
        }
        public void BlockClear()
        {
            for (int y = 0; y < 4; y++)
            {
                for (int x = 0; x < 4; x++)
                {
                    if (_Map.Table[Y + y, X + x] == 1)
                    {
                        _Map.Table[Y + y, X + x] = 0;
                    }
                }
            }
        }
        public void Move()
        {
            if(Console.KeyAvailable == true)
            {
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.W:
                        if (CanRotate() == true)
                        {
                            BlockClear();
                            Rotate();
                        }
                        Drop();
                        break;
                    case ConsoleKey.A:
                        // 만약 지금 내 왼쪽에 겹치는 블록이 하나라도 있으면 stop
                        if (CanMoveLeft() == true)
                        {
                            BlockClear();
                            X -= 1;
                            Drop();
                            break;
                        }
                        Drop();
                        break;
                    case ConsoleKey.S:
                        if (CanDrop() == true)
                        {
                            BlockClear();
                            Y += 1;
                            Drop();
                            break;
                        }
                        Drop();
                        break;
                    case ConsoleKey.D:
                        if (CanMoveRight() == true)
                        {
                            BlockClear();
                            X += 1;
                            Drop();
                            break;
                        }
                        Drop();
                        break;
                    default:
                        Drop();
                        break;
                }
            }
            else
            {
                if (CanDrop() == true)
                {
                    BlockClear();
                    Y += 1;
                }
            }
        }
    }
}