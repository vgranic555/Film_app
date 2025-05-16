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
    public partial class Nagrade : Form
    {
        Nagrada nagrada = new Nagrada();

        public Nagrade()
        {
            InitializeComponent();
        }

        private void Stvori_objekt()
        {
            nagrada.Film_ID = Int32.Parse(Film_ID_text.Text);
            nagrada.Organizacija = Organizacija_text.Text;
            nagrada.Kategorija = Kategorija_text.Text;
            nagrada.Godina_dodjele = Int32.Parse(Godina_dodjele_text.Text);
        }

        private void Očisti()
        {
            Nagrada_ID_text.Text = "";
            Film_ID_text.Text = "";
            Organizacija_text.Text = "";
            Kategorija_text.Text = "";
            Godina_dodjele_text.Text = "";
        }

        private void Popuni_tablicu()
        {
            using (NagradaEntities Nagrada_a = new NagradaEntities())
            {
                Tablica.DataSource = Nagrada_a.Nagrada.ToList<Nagrada>();
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

                using (NagradaEntities Nagrada_a = new NagradaEntities())
                {
                    Nagrada_a.Nagrada.Add(nagrada);
                    Nagrada_a.SaveChanges();
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

        private void Nagrade_Load(object sender, EventArgs e)
        {
            Popuni_tablicu();
            Očisti();
        }

        private void Tablica_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int redak = e.RowIndex;
            Nagrada_ID_text.Text = Tablica.Rows[redak].Cells[0].Value.ToString();
            Film_ID_text.Text = Tablica.Rows[redak].Cells[1].Value.ToString();
            Organizacija_text.Text = Tablica.Rows[redak].Cells[2].Value.ToString();
            Kategorija_text.Text = Tablica.Rows[redak].Cells[3].Value.ToString();
            Godina_dodjele_text.Text = Tablica.Rows[redak].Cells[4].Value.ToString();
        }

        private void Ažuriraj_button_Click(object sender, EventArgs e)
        {
            try
            {
                nagrada.Nagrada_ID = Int32.Parse(Nagrada_ID_text.Text);
                Stvori_objekt();

                using (NagradaEntities Nagrada_a = new NagradaEntities())
                {
                    Nagrada_a.Entry(nagrada).State = EntityState.Modified;
                    Nagrada_a.SaveChanges();
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
                nagrada.Nagrada_ID = Int32.Parse(Nagrada_ID_text.Text);
                Stvori_objekt(); 
                using (NagradaEntities Nagrada_a = new NagradaEntities())
                {
                    Nagrada_a.Nagrada.Attach(nagrada);
                    Nagrada_a.Nagrada.Remove(nagrada);
                    Nagrada_a.SaveChanges();
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

        private void Nagrade_FormClosing(object sender, FormClosingEventArgs e)
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
