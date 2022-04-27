using Godot;
using System;

namespace PVZGDFrame
{
    public class UICard : UIProcessable
    {
        protected Area2D Area;
        public override void _Ready()
        {
            Area = GetNode<Area2D>("Area2D");
            if (Area == null)
            {
                GD.PrintErr("UICard: Area2D is null");
            }
        }
        public override void OnClick()
        {
            base.OnClick();
            GD.Print("Clicked");
        }
    }

}