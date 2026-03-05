struct ColorRGB
{
    int R;
    int G;
    int B;

    public ColorRGB(int r, int g, int b)
    {
        R = r;
        G = g;
        B = b;
    }

    public int GetBrightness() => (R + G + B) / 3;
}