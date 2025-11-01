namespace Assessment2Maria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dGraphicsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new formGraphics();//opens part A
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.Show(this);

        }

        private void dragAndDropToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new formDragDrop();//opens part B
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.Show(this);
        }

        private void linkedListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new formlinkedlist();//opens part C
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.Show(this);
        }

        private void carAndEngineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Formcar();//opens part D
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.Show(this);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String msg=
                 "C# Assessment 2 \n" +
                "Student: Camila Parada\n" +
                "CIT ID: 290562\n\n" +
                "This program demonstrates:\n" +
                "• Part A – 2D Graphics\n" +
                "• Part B – Drag and Drop\n" +
                "• Part C – Doubly Linked List\n" +
                "• Part D – Nested Classes (Car/Engine)";
            MessageBox.Show(msg, "about ", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
