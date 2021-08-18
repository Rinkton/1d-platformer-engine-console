﻿using System;
using OneEngine;

namespace Game
{
    //TODO: Make a opportunity console can have colors
    //TODO: Make a Player more fat(more width)
    //TODO: Make near-sightedness function
    class Program
    {
        static void Main(string[] args)
        {
            var window = new OneEngine.Windows.ConsoleView.Window(35, 36, "1D Platformer");
            OneEngine.Objs.Obj[] firstObjs =
                new OneEngine.Objs.Obj[]
                {
                    //TODO: Update MORE to add player a detector
new OneEngine.Objs.Block(26, 23), new OneEngine.Objs.Block(28, 24), new OneEngine.Objs.Block(30, 25),
new OneEngine.Objs.Block(32, 26), new OneEngine.Objs.Block(34, 27), new OneEngine.Objs.Player(0, 29, window.KeyDetector),
new OneEngine.Objs.Block(11, 29), new OneEngine.Objs.Block(12, 29), new OneEngine.Objs.Block(9, 30),
new OneEngine.Objs.Block(10, 30), new OneEngine.Objs.Block(11, 30), new OneEngine.Objs.Block(12, 30),
new OneEngine.Objs.Block(7, 31), new OneEngine.Objs.Block(8, 31), new OneEngine.Objs.Block(9, 31),
new OneEngine.Objs.Block(10, 31), new OneEngine.Objs.Block(11, 31), new OneEngine.Objs.Block(12, 31),
new OneEngine.Objs.Block(5, 32), new OneEngine.Objs.Block(6, 32), new OneEngine.Objs.Block(7, 32),
new OneEngine.Objs.Block(8, 32), new OneEngine.Objs.Block(9, 32), new OneEngine.Objs.Block(10, 32),
new OneEngine.Objs.Block(11, 32), new OneEngine.Objs.Block(12, 32), new OneEngine.Objs.Block(29, 32),
new OneEngine.Objs.Block(30, 32), new OneEngine.Objs.Block(31, 32), new OneEngine.Objs.Block(3, 33),
new OneEngine.Objs.Block(4, 33), new OneEngine.Objs.Block(5, 33), new OneEngine.Objs.Block(6, 33),
new OneEngine.Objs.Block(7, 33), new OneEngine.Objs.Block(8, 33), new OneEngine.Objs.Block(9, 33),
new OneEngine.Objs.Block(10, 33), new OneEngine.Objs.Block(11, 33), new OneEngine.Objs.Block(12, 33),
new OneEngine.Objs.Block(29, 33), new OneEngine.Objs.Block(30, 33), new OneEngine.Objs.Block(31, 33),
new OneEngine.Objs.Block(0, 34), new OneEngine.Objs.Block(1, 34), new OneEngine.Objs.Block(2, 34),
new OneEngine.Objs.Block(3, 34), new OneEngine.Objs.Block(4, 34), new OneEngine.Objs.Block(5, 34),
new OneEngine.Objs.Block(6, 34), new OneEngine.Objs.Block(7, 34), new OneEngine.Objs.Block(8, 34),
new OneEngine.Objs.Block(9, 34), new OneEngine.Objs.Block(10, 34), new OneEngine.Objs.Block(11, 34),
new OneEngine.Objs.Block(12, 34), new OneEngine.Objs.Block(13, 34), new OneEngine.Objs.Block(14, 34),
new OneEngine.Objs.Block(15, 34), new OneEngine.Objs.Block(16, 34), new OneEngine.Objs.Block(17, 34),
new OneEngine.Objs.Block(18, 34), new OneEngine.Objs.Block(19, 34), new OneEngine.Objs.Block(20, 34),
new OneEngine.Objs.Block(21, 34), new OneEngine.Objs.Block(22, 34), new OneEngine.Objs.Block(23, 34),
new OneEngine.Objs.Block(24, 34), new OneEngine.Objs.Block(25, 34), new OneEngine.Objs.Block(26, 34),
new OneEngine.Objs.Block(27, 34), new OneEngine.Objs.Block(28, 34), new OneEngine.Objs.Block(29, 34),
new OneEngine.Objs.Block(30, 34), new OneEngine.Objs.Block(31, 34), new OneEngine.Objs.Block(32, 34),
new OneEngine.Objs.Block(33, 34), new OneEngine.Objs.Block(34, 34),
                };

            GameProc gameProc = new GameProc(firstObjs, window);
            gameProc.Run();
        }
    }
}
