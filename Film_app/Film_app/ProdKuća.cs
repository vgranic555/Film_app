using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Film_app
{
    public partial class ProdKuća : Form
    {
        Produkcijska_kuća prod = new Produkcijska_kuća();
        public ProdKuća()
        {
            InitializeComponent();
        }

        private void Popuni_tablicu()
        {
            using (ProdEntities Prod_a = new ProdEntities())
            {
                Tablica.DataSource = Prod_a.Produkcijska_kuća.ToList<Produkcijska_kuća>();
            }
        }

        private void Očisti()
        {
            Produkcijska_kuća_ID_text.Text = "";
            Ime_produkcijske_kuće_text.Text = "";
            Država_text.Text = "";
            Godina_osnutka_text.Text = "";
        }
        private void ProdKuća_Load(object sender, EventArgs e)
        {
            Očisti();
            Popuni_tablicu();
        }

        private void Stvori_objekt()
        {
            prod.Ime_produkcijske_kuće = Ime_produkcijske_kuće_text.Text;
            prod.Država = Država_text.Text;
            prod.Godina_osnutka = Int32.Parse(Godina_osnutka_text.Text);
        }

        private void Dodaj_button_Click(object sender, EventArgs e)
        {
            try
            {
                Stvori_objekt();

                using (ProdEntities prod_a = new ProdEntities())
                {
                    prod_a.Produkcijska_kuća.Add(prod);
                    prod_a.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Popuni_tablicu();
                Očisti();
            }
        }

        private void Ažuriraj_button_Click(object sender, EventArgs e)
        {
            try
            {
                prod.Produkcijska_kuća_ID = Int32.Parse(Produkcijska_kuća_ID_text.Text);
                Stvori_objekt();
                using (ProdEntities prod_a = new ProdEntities())
                {
                    prod_a.Entry(prod).State = EntityState.Modified;
                    prod_a.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Popuni_tablicu();
                Očisti();
            }
        }

        private void Izbriši_button_Click(object sender, EventArgs e)
        {
            try
            {
                prod.Produkcijska_kuća_ID = Int32.Parse(Produkcijska_kuća_ID_text.Text);
                Stvori_objekt();
                using (ProdEntities prod_a = new ProdEntities())
                {
                    prod_a.Produkcijska_kuća.Attach(prod);
                    prod_a.Produkcijska_kuća.Remove(prod);
                    prod_a.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Popuni_tablicu();
                Očisti();
            }
        }

        private void Tablica_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int redak = e.RowIndex;
            Produkcijska_kuća_ID_text.Text = Tablica.Rows[redak].Cells[0].Value.ToString();
            Ime_produkcijske_kuće_text.Text = Tablica.Rows[redak].Cells[1].Value.ToString();
            Država_text.Text = Tablica.Rows[redak].Cells[2].Value.ToString();
            Godina_osnutka_text.Text = Tablica.Rows[redak].Cells[3].Value.ToString();
        }

        private void ProdKuća_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Film_button_Click(object sender, EventArgs e)
        {
            Filmovi form = new Filmovi();
            form.Show();
            this.Hide();
        }

        private void Strani_button_Click(object sender, EventArgs e)
        {
            Strani form = new Strani();
            form.Show();
            this.Hide();
        }

        private void Hrvatski_button_Click(object sender, EventArgs e)
        {
            Hrvatski form = new Hrvatski();
            form.Show();
            this.Hide();
        }

        private void Nagrada_button_Click(object sender, EventArgs e)
        {
            Nagrade form = new Nagrade();
            form.Show();
            this.Hide();
        }

        private void Čovjek_button_Click(object sender, EventArgs e)
        {
            Čovjek_1 form = new Čovjek_1();
            form.Show();
            this.Hide();
        }

        private void Film_čovjek_button_Click(object sender, EventArgs e)
        {
            Čovjek_film form = new Čovjek_film();
            form.Show();
            this.Hide();
        }

        private void Produkcijska_kuća_film_button_Click(object sender, EventArgs e)
        {
            ProdFilm form = new ProdFilm();
            form.Show();
            this.Hide();
        }
    }
}
