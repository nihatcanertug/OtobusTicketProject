using OTOBÜS_BİLETİ_UYGULAMASI_PROJESİ.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTOBÜS_BİLETİ_UYGULAMASI_PROJESİ.Entities.Concrete
{
    public class AppMember:BaseEntity
    {
      
        public string Username { get; set; }
        public string Password { get; set; }

        


        public void AddMember(string userName,string passWord,ListView listView)
        {
            AppMember appMember = new AppMember();
            appMember.Id = Guid.NewGuid();
            appMember.Username = userName;
            appMember.Password = passWord;

            // MessageBox.Show($"ad:{appMember.Username}  Şifre:{appMember.Password}");

            ListViewItem listViewItem = new ListViewItem();
            listViewItem.Text = appMember.Id.ToString();
            listViewItem.SubItems.Add(appMember.Username);
            listViewItem.SubItems.Add(appMember.Password);
            
            listView.Items.Add(listViewItem);
            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);


        }










    }
}
