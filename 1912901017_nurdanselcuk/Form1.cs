﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Net;

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
            //string xmladresi= "https://www.sabah.com.tr/rss/ekonomi.xml";

            //var XMLdokuman = new XmlDocument();
             //XMLdokuman.Load(xmladresi);

            /* WebRequest iste = WebRequest.Create(xmladresi);
            WebRequest istek = HttpWebRequest.Create(xmladresi);
            WebResponse yanıt;
            yanıt = istek .GetResponse();
            StreamReader bilgiler = new StreamReader(yanıt.GetResponseStream());
            string gelen = bilgiler.ReadToEnd();
            int baslikbaslangic = gelen.IndexOf("<title>") + 7;
            int baslikbitis = gelen.Substring(baslikbaslangic).IndexOf("</title>");
            string baslik = gelen.Substring(baslikbaslangic, baslikbitis);
            MessageBox.Show(baslik);
            DateTime tarih = Convert.ToDateTime(XMLdokuman.SelectSingleNode("//lastBuildDate").Attributes["tarih"].Value);
            string Bas= XMLdokuman.SelectSingleNode("lastBuildDate/title { @kod= ''")
            label1.Text= string.Format("tarih {0} ") */

            while (xmlAdres.Read())
            {
                if ( xmlAdres.Name=="title")
                {
                    listBox1.Items.Add(xmlAdres.ReadString());
                    

                }
                

     

            }




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
