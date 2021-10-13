using System;
using System.Collections.Generic;
using System.Text;
using MathLibrary;

namespace MathForGames
{
    class Projectile : Actor
    {
        private float _speed;
        private Vector2 _velocity;

        public float Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }

        public Vector2 Velocity
        {
            get { return _velocity; }
            set { _velocity = value; }
        }

        public Projectile(char icon, float x, float y, float speed, string name = "Actor", ConsoleColor color = ConsoleColor.White) :
            base(icon, x, y, name, color)
        {
            _speed = speed;
        }


    }
}
