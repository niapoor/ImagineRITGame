using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Audio;


namespace ImagineRITGame
{
    internal class GameButtonsOverlay : Menu
    {
        /// <summary>
        /// A constructor that defines a Pause Menu object
        /// </summary>
        /// <param name="textures">list of all textures used by menus</param>
        public GameButtonsOverlay(List<Texture2D> textures) : base(textures)
        {
            // Giving positions and sizes to the main menu's buttons
            buttons = new List<Button>() {
                new Button(base.AlignButton(.17, .03), ButtonType.ViewItems, textures[(int)MenuTextures.GeneralButtons]),
                new Button(base.AlignButton(.02, .03), ButtonType.Pause, textures[(int)MenuTextures.GeneralButtons])
            };
        }

        /// <summary>
        /// Updating the planet's animation and updating information about the buttons
        /// </summary>
        /// <param name="gameTime">info about the time from MonoGame</param>
        public void Update(GameTime gameTime)
        {
            base.Update();
        }
    }
}
