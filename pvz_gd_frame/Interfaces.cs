using Godot;
using PVZGDFrame;
using static PVZGDFrame.Register;
namespace PVZGDFrame
{
    //具有攻击性的借口
    public interface IAttackable
    {
        //无目标性的
        void Attack();
        //有目标性的
        void Attack<T>(T target) where T : IHurtable;
    }
    //可受伤的
    public interface IHurtable
    {
        float HP
        {
            get;
            set;
        }
        void Die();
        void Hurt(HurtType hurtType);
    }
    //在格子内的,包括但不限于植物等..
    public interface IInGrid
    {
        Node2D Grid
        {
            get;
            set;
        }
    }
}