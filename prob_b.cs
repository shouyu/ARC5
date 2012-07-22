using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace Solution
{
    class Solution
    {
        enum Dir
        {
            R, L, U, D, RU, RD, LU, LD
        }
        
        static void picknext(int[,] c, ref Dir dir, ref int x, ref int y)
        {
            // x: [0-8]
            // y: [0-8]
            switch (dir)
            {
                case Dir.R:
                    if (x == 8)
                    {
                        x = 7;
                        dir = Dir.L;
                    }
                    else x++;
                    break;
                case Dir.L:
                    if (x == 0)
                    {
                        x = 1;
                        dir = Dir.R;
                    }
                    else x--;
                    break;
                case Dir.U:
                    if (y == 0)
                    {
                        y = 1;
                        dir = Dir.D;
                    }
                    else y--;
                    break;
                case Dir.D:
                    if (y == 8)
                    {
                        y = 7;
                        dir = Dir.U;
                    }
                    else y++;
                    break;
                case Dir.RU:
                    if (x == 8 && y == 0)
                    {
                        x = 7;
                        y = 1;
                        dir = Dir.LD;
                    }
                    else if (x == 8)
                    {
                        x = 7;
                        y--;
                        dir = Dir.LU;
                    }
                    else if (y == 0)
                    {
                        x++;
                        y = 1;
                        dir = Dir.RD;
                    }
                    else
                    {
                        x++;
                        y--;
                    }
                    break;
                case Dir.RD:
                    if (x == 8 && y == 8)
                    {
                        x = 7;
                        y = 7;
                        dir = Dir.LU;
                    }
                    else if (x == 8)
                    {
                        x = 7;
                        y++;
                        dir = Dir.LD;
                    }
                    else if (y == 8)
                    {
                        x++;
                        y = 7;
                        dir = Dir.RU;
                    }
                    else
                    {
                        x++;
                        y++;
                    }
                    break;
                case Dir.LU:
                    if (x == 0 && y == 0)
                    {
                        x = 1;
                        y = 1;
                        dir = Dir.RD;
                    }
                    else if (x == 0)
                    {
                        x = 1;
                        y--;
                        dir = Dir.RU;
                    }
                    else if (y == 0)
                    {
                        x--;
                        y = 1;
                        dir = Dir.LD;
                    }
                    else
                    {
                        x--;
                        y--;
                    }
                    break;
                case Dir.LD:
                    if (x == 0 && y == 8)
                    {
                        x = 1;
                        y = 7;
                        dir = Dir.RU;
                    }
                    else if (x == 0)
                    {
                        x = 1;
                        y++;
                        dir = Dir.RD;
                    }
                    else if (y == 8)
                    {
                        x--;
                        y = 7;
                        dir = Dir.LU;
                    }
                    else
                    {
                        x--;
                        y++;
                    }
                    break;
                default:
                    break;
            }
            Console.Write(c[y, x]);
        }
 
        static void Main(string[] args)
        {
            var l1 = Console.ReadLine().Split(' ');
            int x = int.Parse(l1[0]) - 1;
            int y = int.Parse(l1[1]) - 1;
            Dir dir = (Dir)Enum.Parse(typeof(Dir), l1[2]);
            int[,] c = new int[9, 9];
            for (int i = 0; i < 9; i++)
            {
                var nums = Console.ReadLine();
                for (int j = 0; j < 9; j++)
                {
                    c[i, j] = int.Parse(nums[j].ToString());
                }
            }
 
            Console.Write(c[y, x]);
 
            for (int i = 0; i < 3; i++)
            {
                picknext(c, ref dir, ref x, ref y);
            }
 
            Console.WriteLine();
        }
    }
}