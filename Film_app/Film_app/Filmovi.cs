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
    public partial class Filmovi : Form
    {
        Film film = new Film();
        public Filmovi()
        {
            InitializeComponent();
        }

        private void Stvori_objekt()
        {
            film.Ime_filma = Ime_filma_text.Text;
            film.Žanr = Žanr_text.Text;
            film.Godina_izdanja = Int32.Parse(Godina_izdanja_text.Text);
            film.Zarada = Decimal.Parse(Zarada_text.Text);
        }
 
        private void Očisti()
        {
            Film_ID_text.Text = "";
            Ime_filma_text.Text = "";
            Žanr_text.Text = "";
            Godina_izdanja_text.Text = "";
            Zarada_text.Text = "";
        }

        private void Popuni_tablicu()
        {
            using (FilmoviEntities1 Film_a = new FilmoviEntities1())
            {
                Tablica.DataSource = Film_a.Film.ToList<Film>();
            }
        }
        private void Dodaj_button_Click(object sender, EventArgs e)
        {
            try
            {
                Stvori_objekt();

                using (FilmoviEntities1 Film_a = new FilmoviEntities1())
                {
                    Film_a.Film.Add(film);
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

        private void Tablica_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int redak = e.RowIndex;
            Film_ID_text.Text = Tablica.Rows[redak].Cells[0].Value.ToString();
            Ime_filma_text.Text = Tablica.Rows[redak].Cells[1].Value.ToString();
            Žanr_text.Text = Tablica.Rows[redak].Cells[2].Value.ToString();
            Godina_izdanja_text.Text = Tablica.Rows[redak].Cells[3].Value.ToString();
            Zarada_text.Text = Tablica.Rows[redak].Cells[4].Value.ToString();
        }

        private void Ažuriraj_button_Click(object sender, EventArgs e)
        {
            try
            {
                film.Film_ID = Int32.Parse(Film_ID_text.Text);
                Stvori_objekt();
                using (FilmoviEntities1 Film_a = new FilmoviEntities1())
                {
                    Film_a.Entry(film).State = EntityState.Modified;
                    Film_a.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally{
                Popuni_tablicu();
                Očisti();
            }
        }

        private void Izbriši_button_Click(object sender, EventArgs e)
        {
            try
            {
                film.Film_ID = Int32.Parse(Film_ID_text.Text);
                Stvori_objekt();
                using (FilmoviEntities1 film_a = new FilmoviEntities1())
                {
                    film_a.Film.Attach(film);
                    film_a.Film.Remove(film);
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

        private void Strani_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Strani form = new Strani();
            form.Show();
        }

        private void Hrvatski_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Hrvatski form = new Hrvatski();
            form.Show();
        }

        private void Nagrada_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Nagrade form = new Nagrade();
            form.Show();
        }



        private void Čovjek_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Čovjek_1 form = new Čovjek_1();
            form.Show();
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

        private void Form_Load_1(object sender, EventArgs e)
        {
            Popuni_tablicu();
            Očisti();
        }
    }
}