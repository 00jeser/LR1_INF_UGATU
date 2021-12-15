namespace LR3_GavrilenkoSergey;
public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        A = new int[(int)numericUpDown1.Value];
        ArrayWorcker.SL(ref A);
        ArrayWorcker.out_put(A, NLabel);
        B = new int[(int)numericUpDown2.Value];
        ArrayWorcker.SL(ref B);
        ArrayWorcker.out_put(B, MLabel);
        ArrayWorcker.out_put(A.Concat(B).ToArray(), RezLabel);
    }

    int[] A; int[] B;

    private void numericUpDown1_ValueChanged(object sender, EventArgs e)
    {
        A = new int[(int)numericUpDown1.Value];
        ArrayWorcker.SL(ref A);
        ArrayWorcker.out_put(A, NLabel);
        ArrayWorcker.out_put(A.Concat(B).ToArray(), RezLabel);
        ACountLabel.Text = A.Where(x => x % 5 == 0).Count().ToString();
    }

    private void numericUpDown2_ValueChanged(object sender, EventArgs e)
    {
        B = new int[(int)numericUpDown2.Value];
        ArrayWorcker.SL(ref B);
        ArrayWorcker.out_put(B, MLabel);
        ArrayWorcker.out_put(A.Concat(B).ToArray(), RezLabel);
        BCountLabel.Text = B.Where(x => x % 5 == 0).Count().ToString();
    }
}
