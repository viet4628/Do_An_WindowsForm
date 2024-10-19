using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_An_WindowsForm
{
    public partial class frm_Quan_Ly : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frm_Quan_Ly()
        {
            InitializeComponent();
            // mở thuộc tính để hiển thị nút "x" trên tab có sẵn trong dev expess
            xtraTabControl1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            // xử lý sự kiện đóng tab khi người dùng nhấn vào dấu "x"
            xtraTabControl1.CloseButtonClick += xtraTabControl1_CloseButtonClick;
        }

        private void dev1_information_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnTrangThaiPhong_Click(object sender, ItemClickEventArgs e)
        {
            try
            {
                // Tạo một XtraTabPage mới
                DevExpress.XtraTab.XtraTabPage newTab = new DevExpress.XtraTab.XtraTabPage();

                // Đặt tên tab giống với tên button
                newTab.Text = e.Item.Caption;

                // Thêm một điều khiển vào tab (ví dụ Label)
                Label label = new Label();
                label.Text = "Nội dung của " + e.Item.Caption;
                label.Location = new Point(20, 20);
                newTab.Controls.Add(label);

                // Thêm XtraTabPage vào XtraTabControl
                xtraTabControl1.TabPages.Add(newTab);

                // Chọn tab mới
                xtraTabControl1.SelectedTabPage = newTab;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHinhAnhPhong_Click(object sender, ItemClickEventArgs e)
        {
            try
            {
                // Tạo một XtraTabPage mới
                DevExpress.XtraTab.XtraTabPage newTab = new DevExpress.XtraTab.XtraTabPage();

                // Đặt tên tab giống với tên button
                newTab.Text = e.Item.Caption;

                // Thêm một điều khiển vào tab (ví dụ Label)
                Label label = new Label();
                label.Text = "Nội dung của " + e.Item.Caption;
                label.Location = new Point(20, 20);
                newTab.Controls.Add(label);

                // Thêm XtraTabPage vào XtraTabControl
                xtraTabControl1.TabPages.Add(newTab);

                // Chọn tab mới
                xtraTabControl1.SelectedTabPage = newTab;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // Xử lý sự kiện khi người dùng nhấn vào nút "X" để đóng tab
        private void xtraTabControl1_CloseButtonClick(object sender, EventArgs e)
        {
            // Xác định tab mà người dùng nhấn "X"
            DevExpress.XtraTab.XtraTabPage tabPage = (sender as DevExpress.XtraTab.XtraTabControl).SelectedTabPage;

            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đóng tab này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Xóa tab
                xtraTabControl1.TabPages.Remove(tabPage);
            }
        }

        private void btnDSkhachthue_Click(object sender, ItemClickEventArgs e)
        {
            try
            {
                // Tạo một XtraTabPage mới
                DevExpress.XtraTab.XtraTabPage newTab = new DevExpress.XtraTab.XtraTabPage();

                // Đặt tên tab giống với tên button
                newTab.Text = e.Item.Caption;

                // Thêm một điều khiển vào tab (ví dụ Label)
                Label label = new Label();
                label.Text = "Nội dung của " + e.Item.Caption;
                label.Location = new Point(20, 20);
                newTab.Controls.Add(label);

                // Thêm XtraTabPage vào XtraTabControl
                xtraTabControl1.TabPages.Add(newTab);

                // Chọn tab mới
                xtraTabControl1.SelectedTabPage = newTab;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLogout_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Bạn có chắc chắn muốn đóng chương trình không?", "Chương trình quản lý phòng trọ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dlg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}