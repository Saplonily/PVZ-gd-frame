using Godot;
using System;
using PVZGDFrame;
using static PVZGDFrame.Register;
namespace PVZGDFrame
{
    public class Partizes : Entity, IHurtable
    {
        //可被分化派对的
        //即植物和僵尸这种可划分阵营的
        public float health = 200.0f;
        public float maxHealth = 200.0f;


        [Signal]
        delegate void Died(Node Target);

        public float Health
        {
            get => health;
            set => maxHealth = Math.Clamp(value, 0, maxHealth);
        }

        public void Die()
        {
            Health = 0;
            EmitSignal(nameof(Died),this);
        }

        public void Hurt(HurtType hurtType,float value)
        {
            
        }
    }

}