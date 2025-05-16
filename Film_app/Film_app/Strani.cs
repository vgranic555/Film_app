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
    public partial class Strani : Form
    {
        Strani_film film = new Strani_film();
        public Strani()
        {
            InitializeComponent();
        }

        private void Stvori_Objekt()
        {
            film.Film_ID = Int32.Parse(Film_ID_text.Text);
            film.Država_podrijetla = Država_podrijetla_text.Text;
            film.Lokalizirano_hrvatsko_ime = Lokalizirano_hrvatsko_ime_text.Text;
        }

        private void Očisti()
        {
            Film_ID_text.Text = "";
            Država_podrijetla_text.Text = "";
            Lokalizirano_hrvatsko_ime_text.Text = "";
        }

        private void Popuni_tablicu()
        {
            using (FilmoviEntities2 Film_a = new FilmoviEntities2())
            {
                Tablica.DataSource = Film_a.Strani_film.ToList<Strani_film>();
            }
            using (FilmoviEntities1 Film_A = new FilmoviEntities1())
            {
                Tablica2.DataSource = Film_A.Film.ToList<Film>();
            }
        }


        private void Dodaj_button_Click(object sender, EventArgs e)
        {
            try
            {
                Stvori_Objekt();

                using ( FilmoviEntities2 Film_a = new FilmoviEntities2())
                {
                    Film_a.Strani_film.Add(film);
                    Film_a.SaveChanges();
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
                Stvori_Objekt();

                using (FilmoviEntities2 Film_a = new FilmoviEntities2())
                {
                    Film_a.Entry(film).State = EntityState.Modified;
                    Film_a.SaveChanges();
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
                Stvori_Objekt();

                using (FilmoviEntities2 film_a = new FilmoviEntities2())
                {
                    film_a.Strani_film.Attach(film);
                    film_a.Strani_film.Remove(film);
                    film_a.SaveChanges();
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

        private void Strani_Load(object sender, EventArgs e)
        {
            Popuni_tablicu();
            Očisti();
        }

        private void Tablica_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int redak = e.RowIndex;
            Film_ID_text.Text = Tablica.Rows[redak].Cells[0].Value.ToString();
            Država_podrijetla_text.Text = Tablica.Rows[redak].Cells[2].Value.ToString();
            Lokalizirano_hrvatsko_ime_text.Text = Tablica.Rows[redak].Cells[1].Value.ToString();
        }

        private void Strani_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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

        private void Produkcijska_kuća_button_Click(object sender, EventArgs e)
        {
            ProdKuća form = new ProdKuća();
            form.Show();
            this.Hide();
        }

        private void Produkcijska_kuća_film_button_Click(object sender, EventArgs e)
        {
            ProdFilm form = new ProdFilm();
            form.Show();
            this.Hide();
        }

        private void Tablica2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int redak = e.RowIndex;
            Film_ID_text.Text = Tablica2.Rows[redak].Cells[0].Value.ToString(); 
        }
    }
}
