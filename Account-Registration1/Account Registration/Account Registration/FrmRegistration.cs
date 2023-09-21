using System.Collections;

namespace Account_Registration
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentInfoClass.Program = cbProgram.Text;
            StudentInfoClass.FirstName = txtFirstName.Text;
            StudentInfoClass.LastName = txtLastN.Text;
            StudentInfoClass.MiddleName = txtMiddleN.Text;
            StudentInfoClass.Age = Int32.Parse(txtAge.Text);
            StudentInfoClass.ContactNo = Int32.Parse(txtContactNo.Text);
            StudentInfoClass.StudentNo = Int32.Parse(txtStudentNo.Text);
            StudentInfoClass.Address = txtAddress.Text;

            FrmConfirm frmConfirm = new FrmConfirm();
            frmConfirm.Show();

            FrmConfirm confirm = new FrmConfirm();
            DialogResult result = confirm.ShowDialog();

            if (result == DialogResult.OK)
            {
                txtLastN.Clear();
                txtFirstName.Clear();
                txtMiddleN.Clear();
                txtAge.Clear();
                txtAddress.Clear();
                txtStudentNo.Clear();
                txtContactNo.Clear();
                cbProgram.SelectedIndex = -1;
            }
        }

        private void FrmRegistration_Load(object sender, EventArgs e)
        {
            List<string> programList = new List<string>(); 

            programList.Add("Bachelor of Science in Computer Science");
            programList.Add("Bachelor of Science in Information Technology");
            programList.Add("Bachelor of Science in Information Systems");
            programList.Add("Bachelor of Science in Computer Engineering");

            cbProgram.Items.AddRange(programList.ToArray());

            foreach (string program in programList)
            {
                Console.WriteLine(program);
            }
        }
    }
}