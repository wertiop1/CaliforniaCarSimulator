public static class LaneConfig
{
    public const int LaneCount = 4;

    // Horizontal center X of each lane, left to right
    // e.g. a road centered at x=0 with 1.5-unit-wide lanes
    public static readonly float[] LaneX = { -2.25f, -0.75f, 0.75f, 2.25f };

    // Returns the X position for a given lane index (0 = leftmost)
    public static float GetLaneX(int laneIndex) => LaneX[laneIndex];
}
