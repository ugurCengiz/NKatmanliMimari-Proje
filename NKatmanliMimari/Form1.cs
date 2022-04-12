using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using DataAccesLayer;
using LogicLayer;


namespace NKatmanliMimari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            List<EntityPersonel> Perlist = LogicPersonel.LLPersonelListesi();
            dataGridView1.DataSource = Perlist;

        }

        private void BTNEKLE_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Ad = TXTAD.Text;
            ent.Soyad = TXTSOYAD.Text;
            ent.Sehir = TXTŞEHİR.Text;
            ent.Gorev = TXTGÖREV.Text;
            ent.Maas = short.Parse(TXTMAAŞ.Text);
            LogicPersonel.LLPersonelEkle(ent);          

        }

        private void BTNSİL_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Id = Convert.ToInt32(TXTID.Text);
            LogicPersonel.LLPersonelSil(ent.Id);

        }

        private void BTNGÜNCELLE_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Id = Convert.ToInt32(TXTID.Text);            ;
            ent.Ad = TXTAD.Text;
            ent.Soyad = TXTSOYAD.Text;
            ent.Sehir = TXTŞEHİR.Text;
            ent.Gorev = TXTGÖREV.Text;
            ent.Maas = short.Parse(TXTMAAŞ.Text);
            LogicPersonel.LLPersonelGüncelle(ent);
        }
    }
}
