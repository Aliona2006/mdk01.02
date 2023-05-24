using System.Text;
using System.IO;

namespace redactor_text
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOpen_Click_1_Click_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) //��������� ��� �� ������ ����
            {
                richTextBox.Clear(); //������� richTextBox
                openFileDialog1.Filter = "Text Files (*.txt)|*.txt"; //��������� ��� ��� ���������� ������ ��������� �����
string fileName = openFileDialog1.FileName; //�������� ������������ ���� � ���� � ����.
                richTextBox.Text = File.ReadAllText(fileName, Encoding.GetEncoding(1251)); //�������� ���������� ����� � richTextBox
}
        }

        private void buttonSave_Click_1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files|*.txt";//������ ��������� ����������
            saveFileDialog1.DefaultExt = ".txt"; //������ ���������� �� ��������� 3
if (saveFileDialog1.ShowDialog() == DialogResult.OK) //��������� ������������� ���������� ����������.
{
                var name = saveFileDialog1.FileName; //������ ��� �����
                File.WriteAllText(name, richTextBox.Text, Encoding.GetEncoding(1251)); //���������� � ���� ���������� textBox � ���������� 1251
}
            richTextBox.Clear();
        }

        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Cut();
        }

        private void ����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Copy();
        }

        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Paste();
        }

        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Clear();
        }

        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Select();
            richTextBox.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void �������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Select();
            richTextBox.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Select();
            richTextBox.SelectionAlignment = HorizontalAlignment.Center;
        }
    }
}