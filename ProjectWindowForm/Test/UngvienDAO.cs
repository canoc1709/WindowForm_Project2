using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class UngvienDAO
    {
        Connection connection = new Connection();
        public void Themtaikhoan(string username,string password,string mail)
        {
            string s = string.Format($"insert into Ungvien(Ten, Gioitinh, Ngaysinh, Sdt, Mail, username, password) " +
                "values('','','','0000000000','{0}','{1}','{2}')", mail, username, password);
            connection.ThucThi(s);
        }
    }
}
