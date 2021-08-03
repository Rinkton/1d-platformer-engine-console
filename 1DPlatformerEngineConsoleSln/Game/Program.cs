﻿using System;
using OneEngine;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            OneEngine.Objs.Obj[] firstObjs =
                new OneEngine.Objs.Obj[]
                {
new OneEngine.Objs.Player(1, 15), new OneEngine.Objs.Block(8, 15), new OneEngine.Objs.Block(18, 15),
new OneEngine.Objs.Block(18, 16), new OneEngine.Objs.Block(18, 17), new OneEngine.Objs.Block(0, 18),
new OneEngine.Objs.Block(1, 18), new OneEngine.Objs.Block(2, 18), new OneEngine.Objs.Block(3, 18),
new OneEngine.Objs.Block(4, 18), new OneEngine.Objs.Block(5, 18), new OneEngine.Objs.Block(6, 18),
new OneEngine.Objs.Block(7, 18), new OneEngine.Objs.Block(8, 18), new OneEngine.Objs.Block(9, 18),
new OneEngine.Objs.Block(10, 18), new OneEngine.Objs.Block(11, 18), new OneEngine.Objs.Block(12, 18),
new OneEngine.Objs.Block(13, 18), new OneEngine.Objs.Block(14, 18), new OneEngine.Objs.Block(15, 18),
new OneEngine.Objs.Block(16, 18), new OneEngine.Objs.Block(17, 18), new OneEngine.Objs.Block(18, 18),
                };
            var visualizer = new ConsoleViewVisualizer(16, 36, "1D Platformer");

            GameProc gameProc = new GameProc(firstObjs, visualizer);
            gameProc.Run();
        }
    }
}
