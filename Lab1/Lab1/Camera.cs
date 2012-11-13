using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Lab1
{
    class Camera
    {
        //Hej
        internal Vector2 getViewCoordinatesWhite(int model_x, int model_y)
        {
            int sizeOfTile = 64;
            int borderSize = 64;
            int visualX = borderSize + model_x * sizeOfTile;
            int visualY = borderSize + model_y * sizeOfTile;

            return new Vector2(visualX, visualY);
        }

        internal Vector2 getViewCoordinatesBlack(int model_x, int model_y)
        {
            int sizeOfTile = 64;
            int borderSize = 64;
            int visualX = borderSize + (7-model_x) * sizeOfTile;
            int visualY = borderSize + (7-model_y) * sizeOfTile;

            return new Vector2(visualX, visualY);
        }


        internal Vector2 getViewCoordinatesMobileWhite(int model_x, int model_y)
        {
            int sizeOfTile = 24;
            int borderSize = 24;
            int visualX = borderSize + model_x * sizeOfTile;
            int visualY = borderSize + model_y * sizeOfTile;

            return new Vector2(visualX, visualY);
        }


    }
}
