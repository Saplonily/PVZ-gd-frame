using System.Collections.Generic;
using Godot;
using System;
using System.Linq;
namespace PVZGDFrame
{
    class Game : Node
    {
        static public Game game;
        public Register register;
        public mBoard mBoard;
        public override void _Ready()
        {
            register = new Register();
            mBoard = GetNode<mBoard>("/root/mBoard");
            if(mBoard == null)
            {
                GD.PrintErr("mBoard is null");
            }
            game = this;
        }
    }
}