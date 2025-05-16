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
    public partial class Hrvatski : Form
    {
        Hrvatski_film film = new Hrvatski_film();
        public Hrvatski()
        {
            InitializeComponent();
        }

        private void Stvori_objekt()
        {
            film.Film_ID = Int32.Parse(Film_ID_text.Text);
            film.Englesko_ime = Englesko_ime_filma_text.Text;
        }
        private void Očisti()
        {
            Film_ID_text.Text = "";
            Englesko_ime_filma_text.Text = "";
        }

        private void Popuni_tablicu()
        {
            using (FilmoviEntities3 Film_a = new FilmoviEntities3())
            {
                Tablica.DataSource = Film_a.Hrvatski_film.ToList<Hrvatski_film>();
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
                Stvori_objekt();

                using (FilmoviEntities3 Film_a = new FilmoviEntities3())
                {
                    Film_a.Hrvatski_film.Add(film);
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
                Stvori_objekt();

                using (FilmoviEntities3 Film_a = new FilmoviEntities3())
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
                Stvori_objekt();

                using (FilmoviEntities3 film_a = new FilmoviEntities3())
                {
                    film_a.Hrvatski_film.Attach(film);
                    film_a.Hrvatski_film.Remove(film);
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

        private void Tablica_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int redak = e.RowIndex;
            Film_ID_text.Text = Tablica.Rows[redak].Cells[0].Value.ToString();
            Englesko_ime_filma_text.Text = Tablica.Rows[redak].Cells[1].Value.ToString();
        }

        private void Hrvatski_Load(object sender, EventArgs e)
        {
            Popuni_tablicu();
            Očisti();
        }

        private void Hrvatski_FormClosing(object sender, FormClosingEventArgs e)
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
