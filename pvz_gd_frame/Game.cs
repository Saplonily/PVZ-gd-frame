using Godot;
using System;
namespace PVZGDFrame
{
    class Game : Node
    {
        public Register register;
        public override void _Ready()
        {
            register = new Register();
        }
    }
}