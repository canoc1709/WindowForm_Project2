using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Test
{
    internal class UngVien
    {
		private int id;
		public int ID
		{
			get { return id; }
			set { id = value; }
		}
		private string name;
		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		private string phonenumber;

		public string Phonenumber
		{
			get { return phonenumber; }
			set { phonenumber = value; }
		}
		private string mail;

		public string Mail
		{
			get { return mail; }
			set { mail = value; }
		}
		public UngVien() { }
		public UngVien(int id,string name,string phonenumber,string mail)
		{
			this.id = id;
			this.name = name;
			this.phonenumber = phonenumber;
			this.mail = mail;
		}
		public bool Checknull(object myObject)
		{
			foreach(PropertyInfo pi in myObject.GetType().GetProperties())
			{
				if(pi.PropertyType == typeof(string))
				{
					string value = (string)pi.GetValue(myObject);
					if(string.IsNullOrEmpty(value))
					{
						return false;
					}
				}
			}
			return true;
		}
		public bool Checkmail()
		{
			return Regex.IsMatch(mail, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
		}
	}
}
