using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace PizzaGuy
{
    enum Direction
    {
        UP,
        DOWN,
        LEFT,
        RIGHT
    }

    class PizzaGuy : Sprite
    {
        int Speed = 64;
        Direction direction;
        Vector2 target;

        public PizzaGuy(
            Vector2 location,
            Texture2D texture,
            Rectangle initialFrame,
            Vector2 velocity):
                base(location, texture, initialFrame, velocity)

        {
            direction = Direction.RIGHT;
            target = location;
            UpdateDirection();
        }

        public void UpdateDirection()
        {
            switch (direction)
            {
                case Direction.RIGHT:
                    Velocity = new Vector2(Speed, 0);
                    Rotation = 0;
                    target = location + new Vector2(Speed, 0);
                    break;
                case Direction.LEFT:
                    Velocity = new Vector2(-Speed, 0);
                    Rotation = MathHelper.Pi;
                    target = location + new Vector2(Speed, 0);
                    break;
                case Direction.UP:
                    Velocity = new Vector2(0, Speed);
                    Rotation = MathHelper.PiOver2;
                    target = location + new Vector2(0, Speed);
                    break;
                case Direction.DOWN:
                    Velocity = new Vector2(0, -Speed);
                    Rotation = -MathHelper.PiOver2;
                    target = location + new Vector2(0, -Speed);
                    break;
            }
        }

        public override void Update(GameTime gameTime)
        {
            KeyboardState kb = Keyboard.GetState();

            if (kb.IsKeyDown(Keys.Right))
            {
                Rotation = 0;
                Velocity = new Vector2(50, 0);
            }

            if (kb.IsKeyDown(Keys.Left))
            {
                Rotation = -MathHelper.Pi;
                Velocity = new Vector2(-50, 0);
            }

            if (kb.IsKeyDown(Keys.Up))
            {
                Rotation = -MathHelper.PiOver2;
                Velocity = new Vector2(0, -50);
            }

            if (kb.IsKeyDown(Keys.Down))
            {
                Rotation = MathHelper.PiOver2;
                Velocity = new Vector2(0, 50);
            }

 	         base.Update(gameTime);
        }
    }
}
