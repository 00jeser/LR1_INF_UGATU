namespace LR1_GavrilenkoSergey;
public partial class Form1 : Form
{
    public Form1() => InitializeComponent();

    private void button1_Click(object sender, EventArgs e) => (new FormZ1()).Show();

    private void button4_Click(object sender, EventArgs e) => (new FormZ2()).Show();

    private void button3_Click(object sender, EventArgs e) => (new FormZ3()).Show();

    private void button2_Click(object sender, EventArgs e) => Application.Exit();
}