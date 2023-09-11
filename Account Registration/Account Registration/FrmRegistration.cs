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
            StudentInfoClass student = new StudentInfoClass();

            StudentInfoClass.FirstName = txtFirstName.Text.ToString();
            StudentInfoClass.LastName = txtLastName.Text.ToString();
            StudentInfoClass.MiddleName = txtMiddleName.Text.ToString();
            StudentInfoClass.Address = txtAddress.Text.ToString();
            StudentInfoClass.Program = cbProgram.Text.ToString();

            if (long.TryParse(txtAge.Text, out long age))
            {
                StudentInfoClass.Age = age;
            }
            if (long.TryParse(txtContactNo.Text, out long contactNo))
            {
                StudentInfoClass.ContactNo = contactNo;
            }
            if (long.TryParse(txtStudentNo.Text, out long studentNo))
            {
                StudentInfoClass.StudentNo = studentNo;
            }


            FrmConfirm frmConfirm = new FrmConfirm();
            frmConfirm.ShowDialog();


            if (frmConfirm.DialogResult == DialogResult.OK)
            {
                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtMiddleName.Text = "";
                txtAddress.Text = "";
                cbProgram.Text = "";
                txtAge.Text = "";
                txtContactNo.Text = "";
                txtStudentNo.Text = "";
            }
        }
    } 
}