using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Flood_Control
{
    class FallingPiece : GamePiece
    {
        public int VerticalOffset;
        public static int fallRate = 5;

        public FallingPiece(string pieceType, int verticalOffset, String suffix)
            : base(pieceType,suffix)
        {
            VerticalOffset = verticalOffset;
        }


        public void UpdatePiece()
        {
            VerticalOffset = (int)MathHelper.Max(0, VerticalOffset - fallRate);
        }
    }
}
