using System;
using Godot;
namespace PVZGDFrame
{
    static class Math
    {
        //the value of pi
        public const float PI = 3.1415926f;
        public static float Clamp(float value, float min, float max)
        {
            return Math.Min(Math.Max(value, min), max);
        }
        public static float Max(float A,float B)
        {
            return (A>B)?A:B;
        }
        public static float Min(float A,float B)
        {
            return (A<B)?A:B;
        }
        public static float 
        

    }

}