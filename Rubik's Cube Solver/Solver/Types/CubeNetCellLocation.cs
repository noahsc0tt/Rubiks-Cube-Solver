﻿namespace Rubiks_Cube_Solver.Solver
{
    internal class CubeNetCellLocation
    {
        public readonly int X;
        public readonly int Y;
        public readonly FaceColour Face;

        public CubeNetCellLocation((int x, int y) coords, FaceColour face) : this(coords.x, coords.y, face) { }
        public CubeNetCellLocation(int x, int y, FaceColour face)
        {
            Util.CoordValidator.ValidateCoords(0, 2, (x, nameof(x)), (y, nameof(y)));
            X = x;
            Y = y;
            Face = face;
        }

        public (int X, int Y, FaceColour Face) GetLocation() => (X, Y, Face);
        public (int X, int Y) GetCoords() => (X, Y);

        public override bool Equals(object obj) =>
            (obj is CubeNetCellLocation other) && X == other.X && Y == other.Y && Face.Equals(other.Face);

        public override int GetHashCode() =>
            // using hash of ValueTuple
            (X, Y, Face).GetHashCode();
    }

}
