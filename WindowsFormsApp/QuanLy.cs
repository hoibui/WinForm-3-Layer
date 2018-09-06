using BUS_QUANLY;
using DTO_QUANLY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class QuanLy : Form
    {
        BUS_ThanhVien busThanhVien = new BUS_ThanhVien();

        public QuanLy()
        {
            InitializeComponent();
        }



        private void QuanLy_Load(object sender, EventArgs e)
        {
            dgThanhVien.DataSource = busThanhVien.getThanhVien();
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != "" && txtName.Text != "" && txtPhone.Text != "")
            {
                DTO_ThanhVien dtoThanhVien = new DTO_ThanhVien(0, txtName.Text, txtPhone.Text, txtEmail.Text);
                if (busThanhVien.addThanhVien(dtoThanhVien))
                {
                    MessageBox.Show("Thêm thành công");
                    dgThanhVien.DataSource = busThanhVien.getThanhVien();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đẩy đủ thông tin");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != "" && txtName.Text != "" && txtPhone.Text != "")
            {
                if (dgThanhVien.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dgThanhVien.SelectedRows[0];
                    int ID = Convert.ToInt16(row.Cells[0].Value.ToString());

                    DTO_ThanhVien dtoThanhVien = new DTO_ThanhVien(ID, txtName.Text, txtPhone.Text, txtEmail.Text);
                    if (busThanhVien.editThanhVien(dtoThanhVien))
                    {
                        MessageBox.Show("Sửa thành công");
                        dgThanhVien.DataSource = busThanhVien.getThanhVien();
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Chọn thành viên muốn sửa");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đẩy đủ thông tin");
            }
        }


         

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgThanhVien.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgThanhVien.SelectedRows[0];
                int ID = Convert.ToInt16(row.Cells[0].Value.ToString());


                if (busThanhVien.deleteThanhVien(ID))
                {
                    MessageBox.Show("Xóa thành công");
                    dgThanhVien.DataSource = busThanhVien.getThanhVien();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công");
                }
            }
        }

       

        private void dgThanhVien_Click_1(object sender, EventArgs e)
        {

            
              

            if (dgThanhVien.SelectedRows.Count > 0)
            {
                txtName.Text = dgThanhVien.SelectedRows[0].Cells[1].Value.ToString();
                txtPhone.Text = dgThanhVien.SelectedRows[0].Cells[2].Value.ToString();
                txtEmail.Text = dgThanhVien.SelectedRows[0].Cells[3].Value.ToString();
            }
             
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dgThanhVien.DataSource = busThanhVien.findThanhVien(txtTimKiem.Text.Trim());
        }
    }
}
