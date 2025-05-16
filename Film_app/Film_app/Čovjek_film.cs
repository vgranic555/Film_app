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
    public partial class Čovjek_film : Form
    {
        Film_čovjek film_čovjek = new Film_čovjek();
        public Čovjek_film()
        {
            InitializeComponent();
        }

        private void Stvori_objekt()
        {
            film_čovjek.Film_ID = Int32.Parse(Film_ID_text.Text);
            film_čovjek.Čovjek_ID = Int32.Parse(Čovjek_ID_text.Text);
            film_čovjek.Zanimanje = Zanimanje_text.Text;
            film_čovjek.Glumačka_uloga = Glumačka_uloga_text.Text;
        }

        private void Očisti()
        {
            Film_čovjek_ID_text.Text = "";
            Film_ID_text.Text = "";
            Čovjek_ID_text.Text = "";
            Zanimanje_text.Text = "";
            Glumačka_uloga_text.Text = "";
        }

        private void Popuni_tablicu()
        {
            using (ČovjekFilmEntities Film_čovjek_a = new ČovjekFilmEntities())
            {
                Tablica.DataSource = Film_čovjek_a.Film_čovjek.ToList<Film_čovjek>();
            }
            using (FilmoviEntities1 Film_a = new FilmoviEntities1())
            {
                Tablica2.DataSource = Film_a.Film.ToList<Film>();
            }
            using (ČovjekFilmEntities Čovjek_a = new ČovjekFilmEntities())
            {
                Tablica3.DataSource = Čovjek_a.Film_čovjek.ToList<Film_čovjek>();
            }
        }

        private void Dodaj_button_Click(object sender, EventArgs e)
        {
            try
            {

                Stvori_objekt();

                using (ČovjekFilmEntities čovjekfilm = new ČovjekFilmEntities())
                {
                    čovjekfilm.Film_čovjek.Add(film_čovjek);
                    čovjekfilm.SaveChanges();
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
                film_čovjek.Film_Čovjek_ID = Int32.Parse(Film_čovjek_ID_text.Text);
                Stvori_objekt();
                using (ČovjekFilmEntities čovjek_a = new ČovjekFilmEntities())
                {
                    čovjek_a.Entry(film_čovjek).State = EntityState.Modified;
                    čovjek_a.SaveChanges();
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
                film_čovjek.Film_Čovjek_ID = Int32.Parse(Film_čovjek_ID_text.Text);
                Stvori_objekt();
                using (ČovjekFilmEntities čovjek_a = new ČovjekFilmEntities())
                {
                    čovjek_a.Film_čovjek.Attach(film_čovjek);
                    čovjek_a.Film_čovjek.Remove(film_čovjek);
                    čovjek_a.SaveChanges();
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

        private void Čovjek_film_Load(object sender, EventArgs e)
        {
            Popuni_tablicu();
            Očisti();
        }

        private void Čovjek_film_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Tablica_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int redak = e.RowIndex;
            Film_čovjek_ID_text.Text = Tablica.Rows[redak].Cells[0].Value.ToString();
            Čovjek_ID_text.Text = Tablica.Rows[redak].Cells[1].Value.ToString();
            Film_ID_text.Text = Tablica.Rows[redak].Cells[2].Value.ToString();
            Zanimanje_text.Text = Tablica.Rows[redak].Cells[3].Value.ToString();
            Glumačka_uloga_text.Text = Tablica.Rows[redak].Cells[4].Value.ToString();
        }

        private void Film_button_Click(object sender, EventArgs e)
        {
            Filmovi form = new Filmovi();
            this.Hide();
            form.Show();
        }

        private void Hrvatski_button_Click(object sender, EventArgs e)
        {
            Hrvatski form = new Hrvatski();
            this.Hide();
            form.Show();
        }

        private void Strani_button_Click(object sender, EventArgs e)
        {
            Strani form = new Strani();
            this.Hide();
            form.Show();
        }

        private void Nagrada_button_Click(object sender, EventArgs e)
        {
            Nagrade form = new Nagrade();
            this.Hide();
            form.Show();
        }

        private void Čovjek_button_Click(object sender, EventArgs e)
        {
            Čovjek_1 form = new Čovjek_1();
            this.Hide();
            form.Show();
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

        private void Tablica3_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int redak = e.RowIndex;
            Čovjek_ID_text.Text = Tablica3.Rows[redak].Cells[0].Value.ToString();
        }
    }
    }