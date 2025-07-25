﻿using System;
using System.Drawing;

namespace RubiksCubeSolver.Solver
{
    /// <summary>
    /// Defines the colors of Rubik's Cube faces and provides extension methods for conversion and mapping.
    /// </summary>
    internal enum FaceColour 
    {
        White,
        Yellow,
        Green,
        Blue,
        Red,
        Orange
    }

    internal static class FaceColourExtension
    {
        public static readonly Color DefaultCellColour = Color.Silver;
        public static FaceColour FromFaceName(string faceName) => faceName switch
        {
            "whiteFace" => FaceColour.White,
            "yellowFace" => FaceColour.Yellow,
            "greenFace" => FaceColour.Green,
            "blueFace" => FaceColour.Blue,
            "redFace" => FaceColour.Red,
            "orangeFace" => FaceColour.Orange,
            _ => throw new ArgumentException($"Invalid face name: {faceName}", nameof(faceName))
        };
        
        public static Color ToColor(this FaceColour colour) => colour switch
        {
            FaceColour.White => Color.White,
            FaceColour.Yellow => Color.Yellow,
            FaceColour.Green => Color.Green,
            FaceColour.Blue => Color.RoyalBlue,
            FaceColour.Red => Color.Red,
            FaceColour.Orange => Color.Orange,
            _ => throw new ArgumentException($"Invalid face colour: {colour}", nameof(colour))
        };
    }
}
