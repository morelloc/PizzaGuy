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
    class PizzaGuy : Sprite
    {
        public PizzaGuy(
            Vector2 location,
            Texture2D texture,
            Rectangle initialFrame,
            Vector2 velocity):
                base(location, texture, initialFrame, velocity)

        {
            
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
