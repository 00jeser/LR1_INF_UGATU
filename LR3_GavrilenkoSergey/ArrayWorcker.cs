namespace LR3_GavrilenkoSergey;
public class ArrayWorcker
{
    static Random r = new();
    public static void SL(ref int[] arr) => arr = Enumerable.Range(0, arr.Length).Select(i => r.Next(-10, 10)).ToArray();
    public static void out_put(int[] arr, Label tb) => tb.Text = string.Join(' ', arr);
}