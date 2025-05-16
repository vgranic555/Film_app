
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
    public partial class ProdFilm : Form
    {
        Produkcijska_kuća_film prodfilm = new Produkcijska_kuća_film();
        public ProdFilm()
        {
            InitializeComponent();
        }

        private void Stvori_objekt()
        {
            prodfilm.Film_ID = Int32.Parse(Film_ID_text.Text);
            prodfilm.Produkcijska_kuća_ID = Int32.Parse(Produkcijska_kuća_ID_text.Text);
        }

        private void Očisti()
        {
            Produkcijska_kuća_ID_text.Text = "";
            Produkcijska_kuća_ID_text.Text = "";
            Film_ID_text.Text = "";
        }

        private void Popuni_tablicu()
        {
            using (ProdFilmEntities prod_film_a = new ProdFilmEntities())
            {
                Tablica.DataSource = prod_film_a.Produkcijska_kuća_film.ToList<Produkcijska_kuća_film>();
            }
            using (FilmoviEntities1 film_A = new FilmoviEntities1())
            {
                Tablica2.DataSource = film_A.Film.ToList<Film>();
            }
            using (ProdEntities prod_a = new ProdEntities())
            {
                Tablica3.DataSource = prod_a.Produkcijska_kuća.ToList<Produkcijska_kuća>();
            }
        }
        private void Dodaj_button_Click(object sender, EventArgs e)
        {
            try
            {
                Stvori_objekt();

                using (ProdFilmEntities prod_film_a = new ProdFilmEntities())
                {
                    prod_film_a.Produkcijska_kuća_film.Add(prodfilm);
                    prod_film_a.SaveChanges();
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
                prodfilm.Produkcijska_kuća_film_ID = Int32.Parse(Produkcijska_kuća_film_ID_text.Text);
                Stvori_objekt();

                using (ProdFilmEntities prod_film_a = new ProdFilmEntities())
                {
                    prod_film_a.Entry(prodfilm).State = EntityState.Modified;
                    prod_film_a.SaveChanges();
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
                prodfilm.Produkcijska_kuća_film_ID = Int32.Parse(Produkcijska_kuća_film_ID_text.Text);
                Stvori_objekt();

                using (ProdFilmEntities prod_film_a = new ProdFilmEntities())
                {
                    prod_film_a.Produkcijska_kuća_film.Attach(prodfilm);
                    prod_film_a.Produkcijska_kuća_film.Remove(prodfilm);
                    prod_film_a.SaveChanges();
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

        private void ProdFilm_Load(object sender, EventArgs e)
        {
            Očisti();
            Popuni_tablicu();
        }

        private void ProdFilm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Tablica_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int redak = e.RowIndex;
            Produkcijska_kuća_film_ID_text.Text = Tablica.Rows[redak].Cells[0].Value.ToString();
            Produkcijska_kuća_ID_text.Text = Tablica.Rows[redak].Cells[1].Value.ToString();
            Film_ID_text.Text = Tablica.Rows[redak].Cells[2].Value.ToString();
        }

        private void Film_button_Click(object sender, EventArgs e)
        {
            Filmovi form = new Filmovi();
            form.Show();
            this.Hide();
        }

        private void Hrvatski_button_Click(object sender, EventArgs e)
        {
            Hrvatski form = new Hrvatski();
            form.Show();
            this.Hide();
        }

        private void Strani_button_Click(object sender, EventArgs e)
        {
            Strani form = new Strani();
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

        private void Čovjek_film_button_Click(object sender, EventArgs e)
        {
            Čovjek_film form = new Čovjek_film();
            form.Show();
            this.Hide();
        }

        private void Produkcijska_kuća_button_Click(object sender, EventArgs e)
        {
            ProdKuća form = new ProdKuća();
            form.Show();
            this.Hide();
        }

        private void Tablica2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int redak = e.RowIndex;
            Film_ID_text.Text = Tablica2.Rows[redak].Cells[0].Value.ToString();
        }

        private void Tablica3_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int redak = e.RowIndex;
            Produkcijska_kuća_ID_text.Text = Tablica3.Rows[redak].Cells[0].Value.ToString();
        }
    }
}
