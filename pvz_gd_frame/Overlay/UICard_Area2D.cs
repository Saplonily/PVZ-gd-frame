using System;
using Godot;
namespace PVZGDFrame
{
    class UICard_Area2D : Area2D
    {
        public override void _Ready()
        {
            this.InputPickable = true;
        }
        //check in InputEvent if mouse clicked on me
        public override void _InputEvent(InputEvent inputEvent)
        {
            if (inputEvent.IsActionPressed("mouse_button_left"))
            {
                //if clicked on me, call the function
                this.CallDeferred("_on_UICard_Area2D_input_event");
            }
        }

    }
}