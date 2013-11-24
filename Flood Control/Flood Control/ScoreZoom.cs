using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Flood_Control
{
    class ScoreZoom
    {
        public string Text;
        public Color DrawColor;
        private int displayCounter;
        private int maxDisplayCount = 50;
        private float scale = 0.01f;
        private float lastScaleAmount = 0.0f;
        private float scaleAmount = 0.03f;

        public float Scale
        {
            get { return scale; }
        }

        public bool isCompleted
        {
            get { return (displayCounter > maxDisplayCount); }
        }

        public ScoreZoom(string displayText, Color fontColor)
        {
            Text = displayText;
            DrawColor = fontColor;
            displayCounter = 0;
        }

        public void Update()
        {
            scale += lastScaleAmount + scaleAmount;
            lastScaleAmount += scaleAmount;
            displayCounter++;
        }
    }
}
