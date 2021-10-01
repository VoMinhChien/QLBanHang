using BUS_QLBanHang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_QLBanHang;

namespace asmduanmau
{
    public partial class formkhachhang : Form
    {
        public formkhachhang()
        {
            InitializeComponent();
        }
       
        BUS_KhachHang buskhachhang = new BUS_KhachHang();
        

        private void formkhachhang_Load(object sender, EventArgs e)
        {
            ResetValues();
            loadgridview_Khachhang();
        }
        private void ResetValues()
        {
            txttimkiemkhachhang.Text = "Nhập tên sinh viên";
            txtdienthoai.Text = null;
            txttenkhachhang.Text = null;
            txtdiachikhachhang.Text = null;
            txtdienthoai.Enabled = false;
            txttenkhachhang.Enabled = false;
            txtdiachikhachhang.Enabled = false;
            rdonam.Enabled = false;
            rdonu.Enabled = false;
            btnthem.Enabled = true;
            btnluu.Enabled = false;
            btndong.Enabled = true;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
        }
        private void loadgridview_Khachhang()
        {
            dtgvdanhsachkhachhang.DataSource = buskhachhang.getkhachhang();
            dtgvdanhsachkhachhang.Columns[0].HeaderText = "SỐ ĐIỆN THOẠI";
            dtgvdanhsachkhachhang.Columns[1].HeaderText = "TÊN KHÁCH HÀNG";
            dtgvdanhsachkhachhang.Columns[2].HeaderText = "ĐỊA CHỈ";
            dtgvdanhsachkhachhang.Columns[3].HeaderText = "GIỚI TÍNH";
            

        }

        
        private void btnluu_Click(object sender, EventArgs e)
        {
            string phai;
            if (rdonam.Checked)
            {
                phai = "Nam";
            }
            else
            {
                phai = "Nữ";
            }
           
            if (txtdienthoai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập só điện thoại của khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtdienthoai.Focus();
                return;

            }
            
            if (txttenkhachhang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên của khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txttenkhachhang.Focus();
                return;
            }
            else if (txtdiachikhachhang.Text.Trim().Length == 0)
            {

                MessageBox.Show("Bạn phải nhập địa chỉ của khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtdiachikhachhang.Focus();
                return;
            }
            if (rdonam.Checked == false && rdonu.Checked == false)
            {
                MessageBox.Show("Bạn phải chọn giới tính của khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtdiachikhachhang.Focus();
                return;
            }          
            else
            {
                
                DTO_KhachHang kh = new DTO_KhachHang(txtdienthoai.Text, txttenkhachhang.Text,txtdiachikhachhang.Text, phai,formmain.email);
                if (buskhachhang.insertKhachHang(kh))
                {
                    MessageBox.Show("Thêm thành công");
                    ResetValues();
                    loadgridview_Khachhang();
                    //chạy thử coi
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
           txtdienthoai.Text = null;
            txttenkhachhang.Text = null;
            txtdiachikhachhang.Text = null;
            txtdienthoai.Enabled = true;
            txttenkhachhang.Enabled = true;
            txtdiachikhachhang.Enabled = true;
           rdonam.Enabled = true;
            rdonu.Enabled = true;
            
            btnluu.Enabled = true;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            rdonam.Checked = false;
            rdonu.Checked = false;
            
            txtdienthoai.Focus();
        }
    }
}
