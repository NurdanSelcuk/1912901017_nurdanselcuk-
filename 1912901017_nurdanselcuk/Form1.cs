using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Net;
using System.IO;
using System.Xml.Linq;




namespace _1912901017_nurdanselcuk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            XmlTextReader xmlAdres = new XmlTextReader("https://www.sabah.com.tr/rss/ekonomi.xml");


            while (xmlAdres.Read())
            {
                if (xmlAdres.Name == "title")
                {
                    listBox1.Items.Add(xmlAdres.ReadString());


                }

            }
            listBox1.Text =1912901017.text;
            kaydet();

             
            
            /*FileStream fs = new FileStream(@" 1912901017.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter swadi = new StreamWriter(fs);
            swadi.WriteLine(listBox1.Text);
            swadi.Flush();
            swadi.Close();
            fs.Close(); */



            
           
        }
         public void kaydet()
         {
            string url = "https://www.sabah.com.tr/rss/ekonomi.xml";
            XDocument basl = XDocument.Load(url);
            


            string dosya_adi = "1912901017.txt";
            string dosya_yolu = @"C:/ Users / PC / Desktop / NTP / 1912901017_nurdanselcuk / 1912901017_nurdanselcuk / Debug / 1912901017.txt";
            string hedef_yol = System.IO.Path.Combine(dosya_yolu, dosya_adi);
            if (System.IO.File.Exists(hedef_yol))
            {
                Console.WriteLine(listBox1);
            }
            else
            {
                FileStream fs = new FileStream("1912901017.txt", FileMode.OpenOrCreate, FileAccess.Write);
                fs.Close();
            }
            /*
            FileStream ad = new FileStream(@"C:/Users/PC/Desktop/NTP/1912901017_nurdanselcuk/1912901017_nurdanselcuk/Debug/1912901017.txt", FileMode.Create, FileAccess.Write);
            StreamWriter swadi = new StreamWriter(ad);
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                swadi.WriteLine(listBox1.Items[i].ToString());
            }
            ad.Close();
            swadi.Close();*/

            /*
              if (File.Exists("1912901017.txt"))
              {

              }
              else
              {
                  FileStream fs = new FileStream("1912901017.txt", FileMode.OpenOrCreate, FileAccess.Write);
                  fs.Close();

              }
              StreamWriter sw = new StreamWriter("1912901017.txt");
              sw.Flush();
              sw.Close();*/






        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }


  }


