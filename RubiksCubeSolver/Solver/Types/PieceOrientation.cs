﻿using System;

namespace RubiksCubeSolver.Solver
{
    /// <summary>
    /// Defines possible orientations for a Rubik's Cube piece and provides an extension method to flip it.
    /// </summary>
    internal enum PieceOrientation
    {
        Good, Bad, Corner
    }

    internal static class OrientationFlipExtension
    {
        public static PieceOrientation Flip(this PieceOrientation originalOrientation) => originalOrientation switch
        {
            PieceOrientation.Good => PieceOrientation.Bad,
            PieceOrientation.Bad => PieceOrientation.Good,
            PieceOrientation.Corner => PieceOrientation.Corner,
            _ => throw new ArgumentException($"Invalid orientation: {originalOrientation}", nameof(originalOrientation))
        };
    }
}
