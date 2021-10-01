using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asmduanmau
{
    public partial class formmenuchinh : Form
    {
        private formdangnhap dn;

        public formmenuchinh()
        {
            InitializeComponent();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {

            dn = new formdangnhap();
            if (!checkExisForm("formdangnhap"))
            {
                dn.MdiParent = this;
                dn.Show();
            }
            else
            {
                ActiveChildForm("formdangnhap");
            }
        }
        private bool checkExisForm(string name)
        {
            bool check = false;
            foreach(Form  frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        private void ActiveChildForm(string name)
        {
            foreach(Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    frm.Activate();
                    break;
                }
            }
        }

        private void menustriphuongdan_Click(object sender, EventArgs e)
        {
            try
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "Tailieuhuongdansudung.pdf");
                System.Diagnostics.Process.Start(path);
            }
            catch(FileNotFoundException)
            {
                MessageBox.Show("The file is not found in the specified location");
            }
        }
    }
}
